using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using media;
using Newtonsoft.Json;
using OnvifDiscovery.Models;
using ptz;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Vlc.DotNet.Core;
using Vlc.DotNet.Forms;
using static ONVIFWinFormClient.ClientOptions;
using System.Data.Common;
using Onvif;
using Onvif.DeviceManagement;
using Onvif.Media;
using Onvif.PTZ;

namespace ONVIFWinFormClient
{
    public partial class MainForm : Form
    {
        private OnvifAgent Agent { get; set; }

        #region Field 字段

        private const int m_WaitTime = 5000;
        private const int SyncFileSize = 5 * 1024 * 1204;


        private IntPtr m_LoginID = IntPtr.Zero;

        private IntPtr m_RealPlayID = IntPtr.Zero;
        private const int MaxSpeed = 8;
        private const int MinSpeed = 1;

        string onvifexPath = ""; // Properties.Resources.ONVIFEXPath;

        String path_to_connexion_file = AppDomain.CurrentDomain.BaseDirectory + @"\login_info.json";


        //MediaProfile[] profiles;
        String[] prms = { };

        #endregion

        DirectoryInfo dd;
        public ClientOptions ClientOptions { get; set; } = new ClientOptions();

        public MainForm()
        {
            InitializeComponent();
            var currentAssembly = System.Reflection.Assembly.GetEntryAssembly();
            var currentDirectory = new FileInfo(currentAssembly.Location).DirectoryName;
            var vlcLibDirectory = IntPtr.Size == 4
                ? new System.IO.DirectoryInfo(System.IO.Path.Combine(
                    System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location),
                    "Vlc"))
                : new DirectoryInfo(System.IO.Path.Combine(currentDirectory, onvifexPath));
            Debug.WriteLine($"vlcLibDirectory {vlcLibDirectory}");
            var vlc = new VlcControl()
            {
                Name = "VLC",
                Dock = DockStyle.Fill,
                VlcLibDirectory = vlcLibDirectory,
                // VlcMediaPlayer = new VlcMediaPlayer(vlcLibDirectory)
            };
            vlc.DoubleClick += vlcControl1_DoubleClick;
            vlc.Click += vlcControl2_Click;
            vlc.Log += OnVlcOnLog;
            vlc.EncounteredError += OnVlcOnEncounteredError;
            vlc.VlcLibDirectoryNeeded += OnVlcControlNeedLibDirectory;
            vlc.Playing += (sender, args) => { Debug.Write($"Playing {args}"); };
            this.vlcControl1 = vlc;
            vlc.EndInit();
            this.Load += new EventHandler(RealPlayAndPTZDemo_Load);
            plPlayer.Controls.Add(vlc);
            this.Discover();
            LoadClientOptions();
        }

        private void LoadClientOptions()
        {
            try
            {
                DoLoadClientOptions();
            }
            catch (Exception exception)
            {
                ResolveException(exception);
            }
        }

        private void ResolveException(Exception exception)
        {
            textBox.Text = exception.Message;
            Debug.WriteLine($"Error: {exception.Message} {exception.StackTrace}");
        }

        private string clientoptionsJson = "ClientOptions.json";

        private void DoLoadClientOptions()
        {
            if (File.Exists(clientoptionsJson))
            {
                ClientOptions = JsonConvert.DeserializeObject<ClientOptions>(File.ReadAllText(clientoptionsJson));
            }
        }

        private async Task Discover()
        {
            IEnumerable<DiscoveryDevice> devices = await new OnvifDiscovery.Discovery().Discover(1);
            devices = devices.OrderBy(d => d.Address);
            this.BeginInvoke(new MethodInvoker(() => { UpdateCameraList(devices); }));
        }

        private void UpdateCameraList(IEnumerable<DiscoveryDevice> devices)
        {
            lvCameras.BeginUpdate();
            lvCameras.Items.Clear();
            foreach (var device in devices)
            {
                var item = ConvertToListViewItem(device);
                lvCameras.Items.Add(item);
            }

            lvCameras.EndUpdate();
        }

        private static ListViewItem ConvertToListViewItem(DiscoveryDevice device)
        {
            var item = new ListViewItem()
            {
                Text = device.Address,
                Tag = device
            };
            var subItems = new[] { device.Mfr, device.Model }.Select(text =>
                new ListViewItem.ListViewSubItem(item, text)).ToArray();
            item.SubItems.AddRange(subItems);
            return item;
        }

        private void OnVlcOnEncounteredError(object sender, VlcMediaPlayerEncounteredErrorEventArgs args)
        {
            Debug.Write("Error ");
            Debug.WriteLine(args);
        }

        private void OnVlcOnLog(object sender, VlcMediaPlayerLogEventArgs args)
        {
            Debug.Write("Log ");
            Debug.Write(args.Module);
            Debug.Write(" ");
            Debug.Write(args.Level);
            Debug.Write(" ");
            Debug.Write(args.Message);
            Debug.Write(" ");
            Debug.Write(args.SourceFile);
            Debug.Write(":");
            Debug.WriteLine(args.SourceLine);
        }

        public VlcControl vlcControl1 { get; set; }

        private void OnVlcControlNeedLibDirectory(object sender, VlcLibDirectoryNeededEventArgs e)
        {
            var currentAssembly = Assembly.GetEntryAssembly();
            var currentDirectory = new FileInfo(currentAssembly.Location).DirectoryName;
            e.VlcLibDirectory = new DirectoryInfo(Path.Combine(currentDirectory, "Vlc"));
            if (!e.VlcLibDirectory.Exists)
            {
                var folderBrowserDialog = new FolderBrowserDialog();
                folderBrowserDialog.Description = "Select Vlc libraries folder.";
                folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;
                folderBrowserDialog.ShowNewFolderButton = true;
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    e.VlcLibDirectory = new DirectoryInfo(folderBrowserDialog.SelectedPath);
                }
            }
        }

        private void RealPlayAndPTZDemo_Load(object sender, EventArgs e)
        {
            try
            {
                InitOrLogoutUI();
            }
            catch (Exception exception)
            {
                ResolveException(exception);
                System.Windows.Forms.MessageBox.Show(exception.Message);
                Process.GetCurrentProcess().Kill();
            }
        }

        private void port_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            LoadProfile();
        }

        private void SaveClientOptions()
        {
            try
            {
                DoSaveClientOptions();
            }
            catch (Exception exception)
            {
                ResolveException(exception);
            }
        }

        private void DoSaveClientOptions()
        {
            File.WriteAllText(clientoptionsJson, JsonConvert.SerializeObject(ClientOptions));
        }

        private void UpdateChannels(string[] channels)
        {
            // Make sure that the list is empty before adding new items
            lbChannels.Items.Clear();
            if (channels != null)
            {
                lbChannels.Items.AddRange(channels);
            }
        }

        private void OnSelectionChanged(object sender, EventArgs e)
        {
            if (Agent != null && lbChannels.SelectedIndex >= 0)
            {
                bool inError = false;
                try
                {
                    StreamVideoOnVLC(prms);
                }
                catch (Exception exception)
                {
                    ResolveException(exception);
                    inError = true;
                }
            }
        }


        #region PTZ Control 云台控制

        private void right_button_MouseUp(object sender, MouseEventArgs e)
        {
            Agent.Ptz.MoveRight();
        }

        #endregion

        #region Update UI 更新UI

        private void InitOrLogoutUI()
        {
            step_comboBox.Enabled = false;
            step_comboBox.Items.Clear();
            login_button.Text = "Login(登录)";

            btnZoomOut.Enabled = true;
            btnZoomIn.Enabled = true;
            focusadd_button.Enabled = false;
            focusdec_button.Enabled = false;
            apertureadd_button.Enabled = false;
            aperturedec_button.Enabled = false;
            m_RealPlayID = IntPtr.Zero;
        }

        #endregion

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            // NETClient.Cleanup();
        }


        private void StreamVideoOnVLC(String[] recordParams)
        {
            var uri = Agent.Media.GetRtspUri(recordParams);
            Debug.Write(uri.Uri);
            // vlcControl1.VlcMediaPlayer.Play(uri.Uri, options.ToArray());
            //vlcControl1.Play(uri2);

            vlcControl1.Play(uri.Uri);
            // vlcControl1.Play(uri.Uri, options.ToArray());
        }


        private void button1_Click(object sender, EventArgs e)
        {
            vlcControl1.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Agent.Ptz.Stop();
        }


        private void vlcControl2_Click(object sender, EventArgs e)
        {
        }

        VlcMediaPlayer recordingMediaPlayer;

        private void button5_Click(object sender, EventArgs e)
        {
            this.vlcControl1.TakeSnapshot("d:\\" + System.DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg"); //截图
            var destination = ("d:\\" + System.DateTime.Now.ToString("yyyyMMddHHmmss") + ".mp4");
            var mediaOptions = new[]
            {
                //":sout=#duplicate{dst=file{dst="+destination+",no-overwrite}}",
                ":sout=#file{dst=" + destination + "}",
                ":sout-keep",
                ":rtsp-user=" + this.name_textBox.Text,
                ":rtsp-pwd=" + this.pwd_textBox.Text
            };
            recordingMediaPlayer = new VlcMediaPlayer(dd);
            Uri uri = new Uri(vlcControl1.VlcMediaPlayer.GetMedia().Mrl);
            this.textBox2.Text = this.textBox2.Text + "</br>" + uri.ToString();
            recordingMediaPlayer.SetMedia(uri,
                ":sout=#file{dst=" + destination + "}",
                ":sout-keep",
                ":rtsp-user=" + this.name_textBox.Text,
                ":rtsp-pwd=" + this.pwd_textBox.Text
            );
            recordingMediaPlayer.Play();

            this.textBox2.Text = "DoubleClick bind;" + this.textBox2.Text;
            vlcControl1.Video.IsMouseInputEnabled = false; //去掉鼠标阻塞点击,使的控件可以触发点击事件
            vlcControl1.Video.IsKeyInputEnabled = false; //去掉键盘阻塞点击要和上面同时设置
            vlcControl1.DoubleClick += vlcControl1_DoubleClick;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            recordingMediaPlayer.Stop();
        }


        private void vlcControl1_DoubleClick(object sender, EventArgs e)
        {
            this.textBox2.Text = "DoubleClick click;" + this.textBox2.Text;
            //new Sample().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void OnClosed(object sender, FormClosedEventArgs e)
        {
            OnClosed(e);
        }

        private void login_button_Click_1(object sender, EventArgs e)
        {
            login_button_Click(sender, e);
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnSelectionChanged(sender, e);
        }

        private void lvCameras_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCameras.SelectedItems.Count == 0)
            {
                return;
            }

            var item = lvCameras.SelectedItems[0];
            ip_textBox.Text = item.Text;
            if (!ClientOptions.Accounts.ContainsKey(item.Text))
            {
                return;
            }

            var account = ClientOptions.Accounts[item.Text];
            name_textBox.Text = account.UserName;
            pwd_textBox.Text = account.Password;
        }

        private void btnDiscover_Click(object sender, EventArgs e)
        {
            Discover();
        }

        private void up_MouseDown(object sender, MouseEventArgs e)
        {
            Catch(Agent.Ptz.MoveUp);
        }

        public void Catch(Action action)
        {
            try
            {
                action();
            }
            catch (Exception e)
            {
                ResolveException(e);
            }
        }

        private void StopAsync(object sender, MouseEventArgs e)
        {
            Catch(Agent.Ptz.Stop);
        }

        private void left_MouseDown(object sender, MouseEventArgs e)
        {
            Catch(Agent.Ptz.MoveLeft);
        }

        private void right_MouseDown(object sender, MouseEventArgs e)
        {
            Catch(Agent.Ptz.MoveRight);
        }

        private void down_MouseDown(object sender, MouseEventArgs e)
        {
            Catch(Agent.Ptz.MoveDown);
        }

        private void btnZoomIn_MouseDown(object sender, MouseEventArgs e)
        {
            Catch(Agent.Ptz.ZoomIn);
        }

        private void btnZoomOut_MouseDown(object sender, MouseEventArgs e)
        {
            Catch(Agent.Ptz.ZoomOut);
        }

        private async Task LoadProfile()
        {
            try
            {
                await DoLoadProfile();
            }
            catch (Exception exception)
            {
                ResolveException(exception);
            }
        }

        private async Task DoLoadProfile()
        {
            var ipAddress = ip_textBox.Text;
            var userName = name_textBox.Text;
            var password = pwd_textBox.Text;
            Agent = new OnvifAgent(ipAddress, userName, password);
            var channels = Agent.Media.GetChannels();
            UpdateChannels(channels);
            this.ClientOptions.Accounts[ipAddress] = new Account
            {
                IpAddress = ipAddress,
                UserName = userName,
                Password = password
            };
            SaveClientOptions();
        }

        private void step_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}