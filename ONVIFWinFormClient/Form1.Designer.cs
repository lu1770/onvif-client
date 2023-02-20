using System.IO;

namespace ONVIFWinFormClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.step_comboBox = new System.Windows.Forms.ComboBox();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.focusadd_button = new System.Windows.Forms.Button();
            this.focusdec_button = new System.Windows.Forms.Button();
            this.apertureadd_button = new System.Windows.Forms.Button();
            this.aperturedec_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.up = new System.Windows.Forms.Button();
            this.plPlayer = new System.Windows.Forms.Panel();
            this.textBox = new System.Windows.Forms.TextBox();
            this.lbChannels = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pwd_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ip_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lvCameras = new System.Windows.Forms.ListView();
            this.Address = new System.Windows.Forms.ColumnHeader();
            this.Mfr = new System.Windows.Forms.ColumnHeader();
            this.Model = new System.Windows.Forms.ColumnHeader();
            this.btnDiscover = new System.Windows.Forms.Button();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(354, 593);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(918, 23);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(354, 557);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(918, 23);
            this.textBox2.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.plPlayer, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(354, 62);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 510F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(918, 489);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel4);
            this.groupBox2.Controls.Add(this.down);
            this.groupBox2.Controls.Add(this.right);
            this.groupBox2.Controls.Add(this.left);
            this.groupBox2.Controls.Add(this.up);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(554, 3);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(360, 504);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "云台";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.step_comboBox, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnZoomOut, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.label9, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.label10, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.label11, 0, 7);
            this.tableLayoutPanel4.Controls.Add(this.btnZoomIn, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.focusadd_button, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.focusdec_button, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.apertureadd_button, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.aperturedec_button, 1, 6);
            this.tableLayoutPanel4.Controls.Add(this.button1, 1, 7);
            this.tableLayoutPanel4.Controls.Add(this.button6, 1, 8);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 156);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 10;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(352, 345);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(4, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 35);
            this.label6.TabIndex = 10;
            this.label6.Text = "zoom out";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(4, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 35);
            this.label5.TabIndex = 7;
            this.label5.Text = "zoom in";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(4, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 35);
            this.label4.TabIndex = 5;
            this.label4.Text = "step";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // step_comboBox
            // 
            this.step_comboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.step_comboBox.FormattingEnabled = true;
            this.step_comboBox.Location = new System.Drawing.Point(120, 3);
            this.step_comboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.step_comboBox.Name = "step_comboBox";
            this.step_comboBox.Size = new System.Drawing.Size(228, 23);
            this.step_comboBox.TabIndex = 6;
            this.step_comboBox.SelectedIndexChanged += new System.EventHandler(this.step_comboBox_SelectedIndexChanged);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnZoomOut.Location = new System.Drawing.Point(120, 38);
            this.btnZoomOut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(228, 29);
            this.btnZoomOut.TabIndex = 9;
            this.btnZoomOut.Text = "+";
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnZoomOut_MouseDown);
            this.btnZoomOut.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopAsync);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(4, 105);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 35);
            this.label7.TabIndex = 18;
            this.label7.Text = "focus add";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(4, 140);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 35);
            this.label8.TabIndex = 19;
            this.label8.Text = "focus dec";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(4, 175);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 35);
            this.label9.TabIndex = 20;
            this.label9.Text = "aperture add";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(4, 210);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 35);
            this.label10.TabIndex = 21;
            this.label10.Text = "aperture dec";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(4, 245);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 35);
            this.label11.TabIndex = 22;
            this.label11.Text = "label11";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnZoomIn.Location = new System.Drawing.Point(120, 73);
            this.btnZoomIn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(228, 29);
            this.btnZoomIn.TabIndex = 12;
            this.btnZoomIn.Text = "-";
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnZoomIn_MouseDown);
            this.btnZoomIn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopAsync);
            // 
            // focusadd_button
            // 
            this.focusadd_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.focusadd_button.Location = new System.Drawing.Point(120, 108);
            this.focusadd_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.focusadd_button.Name = "focusadd_button";
            this.focusadd_button.Size = new System.Drawing.Size(228, 29);
            this.focusadd_button.TabIndex = 13;
            this.focusadd_button.Text = "+";
            this.focusadd_button.UseVisualStyleBackColor = true;
            // 
            // focusdec_button
            // 
            this.focusdec_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.focusdec_button.Location = new System.Drawing.Point(120, 143);
            this.focusdec_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.focusdec_button.Name = "focusdec_button";
            this.focusdec_button.Size = new System.Drawing.Size(228, 29);
            this.focusdec_button.TabIndex = 14;
            this.focusdec_button.Text = "-";
            this.focusdec_button.UseVisualStyleBackColor = true;
            // 
            // apertureadd_button
            // 
            this.apertureadd_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.apertureadd_button.Location = new System.Drawing.Point(120, 178);
            this.apertureadd_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.apertureadd_button.Name = "apertureadd_button";
            this.apertureadd_button.Size = new System.Drawing.Size(228, 29);
            this.apertureadd_button.TabIndex = 15;
            this.apertureadd_button.Text = "+";
            this.apertureadd_button.UseVisualStyleBackColor = true;
            // 
            // aperturedec_button
            // 
            this.aperturedec_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aperturedec_button.Location = new System.Drawing.Point(120, 213);
            this.aperturedec_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.aperturedec_button.Name = "aperturedec_button";
            this.aperturedec_button.Size = new System.Drawing.Size(228, 29);
            this.aperturedec_button.TabIndex = 16;
            this.aperturedec_button.Text = "-";
            this.aperturedec_button.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(120, 248);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 29);
            this.button1.TabIndex = 23;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Location = new System.Drawing.Point(120, 283);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(228, 29);
            this.button6.TabIndex = 23;
            this.button6.Text = "button1";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // down
            // 
            this.down.Location = new System.Drawing.Point(81, 95);
            this.down.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(75, 23);
            this.down.TabIndex = 0;
            this.down.Text = "↓";
            this.down.UseVisualStyleBackColor = true;
            this.down.MouseDown += new System.Windows.Forms.MouseEventHandler(this.down_MouseDown);
            this.down.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopAsync);
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(155, 57);
            this.right.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(75, 23);
            this.right.TabIndex = 0;
            this.right.Text = "→";
            this.right.UseVisualStyleBackColor = true;
            this.right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.right_MouseDown);
            this.right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopAsync);
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(6, 57);
            this.left.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(75, 23);
            this.left.TabIndex = 0;
            this.left.Text = "←";
            this.left.UseVisualStyleBackColor = true;
            this.left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.left_MouseDown);
            this.left.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopAsync);
            // 
            // up
            // 
            this.up.Location = new System.Drawing.Point(81, 17);
            this.up.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(75, 23);
            this.up.TabIndex = 0;
            this.up.Text = "↑";
            this.up.UseVisualStyleBackColor = true;
            this.up.MouseDown += new System.Windows.Forms.MouseEventHandler(this.up_MouseDown);
            this.up.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopAsync);
            // 
            // plPlayer
            // 
            this.plPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plPlayer.Location = new System.Drawing.Point(4, 3);
            this.plPlayer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.plPlayer.Name = "plPlayer";
            this.plPlayer.Size = new System.Drawing.Size(542, 504);
            this.plPlayer.TabIndex = 1;
            // 
            // textBox
            // 
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Location = new System.Drawing.Point(1280, 3);
            this.textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox.Size = new System.Drawing.Size(156, 53);
            this.textBox.TabIndex = 2;
            // 
            // lbChannels
            // 
            this.lbChannels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbChannels.FormattingEnabled = true;
            this.lbChannels.ItemHeight = 15;
            this.lbChannels.Location = new System.Drawing.Point(1280, 62);
            this.lbChannels.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbChannels.Name = "lbChannels";
            this.lbChannels.Size = new System.Drawing.Size(156, 489);
            this.lbChannels.TabIndex = 1;
            this.lbChannels.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(354, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(918, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设备登录";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.pwd_textBox, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ip_textBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.name_textBox, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.login_button, 6, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 19);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(910, 31);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // pwd_textBox
            // 
            this.pwd_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pwd_textBox.Location = new System.Drawing.Point(674, 3);
            this.pwd_textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pwd_textBox.Name = "pwd_textBox";
            this.pwd_textBox.PasswordChar = '*';
            this.pwd_textBox.Size = new System.Drawing.Size(126, 23);
            this.pwd_textBox.TabIndex = 5;
            this.pwd_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(540, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "pwd";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ip_textBox
            // 
            this.ip_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ip_textBox.Location = new System.Drawing.Point(138, 3);
            this.ip_textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ip_textBox.Name = "ip_textBox";
            this.ip_textBox.Size = new System.Drawing.Size(126, 23);
            this.ip_textBox.TabIndex = 1;
            this.ip_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(272, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "user";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // name_textBox
            // 
            this.name_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name_textBox.Location = new System.Drawing.Point(406, 3);
            this.name_textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(126, 23);
            this.name_textBox.TabIndex = 3;
            this.name_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(808, 3);
            this.login_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(95, 26);
            this.login_button.TabIndex = 6;
            this.login_button.Text = "login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbChannels, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lvCameras, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDiscover, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1440, 639);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lvCameras
            // 
            this.lvCameras.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Address,
            this.Mfr,
            this.Model});
            this.lvCameras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCameras.FullRowSelect = true;
            this.lvCameras.GridLines = true;
            this.lvCameras.HideSelection = false;
            this.lvCameras.Location = new System.Drawing.Point(3, 62);
            this.lvCameras.MultiSelect = false;
            this.lvCameras.Name = "lvCameras";
            this.lvCameras.Size = new System.Drawing.Size(344, 489);
            this.lvCameras.TabIndex = 6;
            this.lvCameras.UseCompatibleStateImageBehavior = false;
            this.lvCameras.View = System.Windows.Forms.View.Details;
            this.lvCameras.SelectedIndexChanged += new System.EventHandler(this.lvCameras_SelectedIndexChanged);
            // 
            // Address
            // 
            this.Address.Text = "Address";
            this.Address.Width = 120;
            // 
            // Mfr
            // 
            this.Mfr.Text = "Mfr";
            this.Mfr.Width = 80;
            // 
            // Model
            // 
            this.Model.Text = "Model";
            this.Model.Width = 120;
            // 
            // btnDiscover
            // 
            this.btnDiscover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDiscover.Location = new System.Drawing.Point(3, 3);
            this.btnDiscover.Name = "btnDiscover";
            this.btnDiscover.Size = new System.Drawing.Size(344, 53);
            this.btnDiscover.TabIndex = 7;
            this.btnDiscover.Text = "发现";
            this.btnDiscover.UseVisualStyleBackColor = true;
            this.btnDiscover.Click += new System.EventHandler(this.btnDiscover_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 639);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "ONVIF Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox step_comboBox;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button focusadd_button;
        private System.Windows.Forms.Button focusdec_button;
        private System.Windows.Forms.Button apertureadd_button;
        private System.Windows.Forms.Button aperturedec_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.Panel plPlayer;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ListBox lbChannels;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox pwd_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ip_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView lvCameras;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Mfr;
        private System.Windows.Forms.ColumnHeader Model;
        private System.Windows.Forms.Button btnDiscover;
    }
}
