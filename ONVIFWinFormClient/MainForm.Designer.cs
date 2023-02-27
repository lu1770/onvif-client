using System.IO;

namespace ONVIFWinFormClient
{
    partial class MainForm
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
            textBox3 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            groupBox2 = new System.Windows.Forms.GroupBox();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            step_comboBox = new System.Windows.Forms.ComboBox();
            btnZoomOut = new System.Windows.Forms.Button();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            btnZoomIn = new System.Windows.Forms.Button();
            focusadd_button = new System.Windows.Forms.Button();
            focusdec_button = new System.Windows.Forms.Button();
            apertureadd_button = new System.Windows.Forms.Button();
            aperturedec_button = new System.Windows.Forms.Button();
            btnReset = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            down = new System.Windows.Forms.Button();
            right = new System.Windows.Forms.Button();
            left = new System.Windows.Forms.Button();
            up = new System.Windows.Forms.Button();
            plPlayer = new System.Windows.Forms.Panel();
            textBox = new System.Windows.Forms.TextBox();
            lbChannels = new System.Windows.Forms.ListBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            pwd_textBox = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ip_textBox = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            name_textBox = new System.Windows.Forms.TextBox();
            login_button = new System.Windows.Forms.Button();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            lvCameras = new System.Windows.Forms.ListView();
            Address = new System.Windows.Forms.ColumnHeader();
            Mfr = new System.Windows.Forms.ColumnHeader();
            Model = new System.Windows.Forms.ColumnHeader();
            btnDiscover = new System.Windows.Forms.Button();
            tableLayoutPanel3.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            textBox3.Location = new System.Drawing.Point(354, 593);
            textBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(918, 23);
            textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            textBox2.Location = new System.Drawing.Point(354, 557);
            textBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(918, 23);
            textBox2.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            tableLayoutPanel3.Controls.Add(groupBox2, 1, 0);
            tableLayoutPanel3.Controls.Add(plPlayer, 0, 0);
            tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel3.Location = new System.Drawing.Point(354, 62);
            tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 510F));
            tableLayoutPanel3.Size = new System.Drawing.Size(918, 489);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel4);
            groupBox2.Controls.Add(down);
            groupBox2.Controls.Add(right);
            groupBox2.Controls.Add(left);
            groupBox2.Controls.Add(up);
            groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox2.Location = new System.Drawing.Point(554, 3);
            groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Size = new System.Drawing.Size(360, 504);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "云台";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            tableLayoutPanel4.Controls.Add(label6, 0, 2);
            tableLayoutPanel4.Controls.Add(label5, 0, 1);
            tableLayoutPanel4.Controls.Add(label4, 0, 0);
            tableLayoutPanel4.Controls.Add(step_comboBox, 1, 0);
            tableLayoutPanel4.Controls.Add(btnZoomOut, 1, 1);
            tableLayoutPanel4.Controls.Add(label7, 0, 3);
            tableLayoutPanel4.Controls.Add(label8, 0, 4);
            tableLayoutPanel4.Controls.Add(label9, 0, 5);
            tableLayoutPanel4.Controls.Add(label10, 0, 6);
            tableLayoutPanel4.Controls.Add(label11, 0, 7);
            tableLayoutPanel4.Controls.Add(btnZoomIn, 1, 2);
            tableLayoutPanel4.Controls.Add(focusadd_button, 1, 3);
            tableLayoutPanel4.Controls.Add(focusdec_button, 1, 4);
            tableLayoutPanel4.Controls.Add(apertureadd_button, 1, 5);
            tableLayoutPanel4.Controls.Add(aperturedec_button, 1, 6);
            tableLayoutPanel4.Controls.Add(btnReset, 1, 7);
            tableLayoutPanel4.Controls.Add(button6, 1, 8);
            tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            tableLayoutPanel4.Location = new System.Drawing.Point(4, 156);
            tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 10;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel4.Size = new System.Drawing.Size(352, 345);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = System.Windows.Forms.DockStyle.Fill;
            label6.Location = new System.Drawing.Point(4, 70);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(108, 35);
            label6.TabIndex = 10;
            label6.Text = "zoom out";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = System.Windows.Forms.DockStyle.Fill;
            label5.Location = new System.Drawing.Point(4, 35);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(108, 35);
            label5.TabIndex = 7;
            label5.Text = "zoom in";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = System.Windows.Forms.DockStyle.Fill;
            label4.Location = new System.Drawing.Point(4, 0);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(108, 35);
            label4.TabIndex = 5;
            label4.Text = "step";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // step_comboBox
            // 
            step_comboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            step_comboBox.FormattingEnabled = true;
            step_comboBox.Location = new System.Drawing.Point(120, 3);
            step_comboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            step_comboBox.Name = "step_comboBox";
            step_comboBox.Size = new System.Drawing.Size(228, 23);
            step_comboBox.TabIndex = 6;
            step_comboBox.SelectedIndexChanged += step_comboBox_SelectedIndexChanged;
            // 
            // btnZoomOut
            // 
            btnZoomOut.Dock = System.Windows.Forms.DockStyle.Fill;
            btnZoomOut.Location = new System.Drawing.Point(120, 38);
            btnZoomOut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnZoomOut.Name = "btnZoomOut";
            btnZoomOut.Size = new System.Drawing.Size(228, 29);
            btnZoomOut.TabIndex = 9;
            btnZoomOut.Text = "+";
            btnZoomOut.UseVisualStyleBackColor = true;
            btnZoomOut.MouseDown += btnZoomOut_MouseDown;
            btnZoomOut.MouseUp += StopAsync;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = System.Windows.Forms.DockStyle.Fill;
            label7.Location = new System.Drawing.Point(4, 105);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(108, 35);
            label7.TabIndex = 18;
            label7.Text = "focus add";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = System.Windows.Forms.DockStyle.Fill;
            label8.Location = new System.Drawing.Point(4, 140);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(108, 35);
            label8.TabIndex = 19;
            label8.Text = "focus dec";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = System.Windows.Forms.DockStyle.Fill;
            label9.Location = new System.Drawing.Point(4, 175);
            label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(108, 35);
            label9.TabIndex = 20;
            label9.Text = "aperture add";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = System.Windows.Forms.DockStyle.Fill;
            label10.Location = new System.Drawing.Point(4, 210);
            label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(108, 35);
            label10.TabIndex = 21;
            label10.Text = "aperture dec";
            label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = System.Windows.Forms.DockStyle.Fill;
            label11.Location = new System.Drawing.Point(4, 245);
            label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(108, 35);
            label11.TabIndex = 22;
            label11.Text = "reset";
            label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnZoomIn
            // 
            btnZoomIn.Dock = System.Windows.Forms.DockStyle.Fill;
            btnZoomIn.Location = new System.Drawing.Point(120, 73);
            btnZoomIn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnZoomIn.Name = "btnZoomIn";
            btnZoomIn.Size = new System.Drawing.Size(228, 29);
            btnZoomIn.TabIndex = 12;
            btnZoomIn.Text = "-";
            btnZoomIn.UseVisualStyleBackColor = true;
            btnZoomIn.MouseDown += btnZoomIn_MouseDown;
            btnZoomIn.MouseUp += StopAsync;
            // 
            // focusadd_button
            // 
            focusadd_button.Dock = System.Windows.Forms.DockStyle.Fill;
            focusadd_button.Location = new System.Drawing.Point(120, 108);
            focusadd_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            focusadd_button.Name = "focusadd_button";
            focusadd_button.Size = new System.Drawing.Size(228, 29);
            focusadd_button.TabIndex = 13;
            focusadd_button.Text = "+";
            focusadd_button.UseVisualStyleBackColor = true;
            // 
            // focusdec_button
            // 
            focusdec_button.Dock = System.Windows.Forms.DockStyle.Fill;
            focusdec_button.Location = new System.Drawing.Point(120, 143);
            focusdec_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            focusdec_button.Name = "focusdec_button";
            focusdec_button.Size = new System.Drawing.Size(228, 29);
            focusdec_button.TabIndex = 14;
            focusdec_button.Text = "-";
            focusdec_button.UseVisualStyleBackColor = true;
            // 
            // apertureadd_button
            // 
            apertureadd_button.Dock = System.Windows.Forms.DockStyle.Fill;
            apertureadd_button.Location = new System.Drawing.Point(120, 178);
            apertureadd_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            apertureadd_button.Name = "apertureadd_button";
            apertureadd_button.Size = new System.Drawing.Size(228, 29);
            apertureadd_button.TabIndex = 15;
            apertureadd_button.Text = "+";
            apertureadd_button.UseVisualStyleBackColor = true;
            // 
            // aperturedec_button
            // 
            aperturedec_button.Dock = System.Windows.Forms.DockStyle.Fill;
            aperturedec_button.Location = new System.Drawing.Point(120, 213);
            aperturedec_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            aperturedec_button.Name = "aperturedec_button";
            aperturedec_button.Size = new System.Drawing.Size(228, 29);
            aperturedec_button.TabIndex = 16;
            aperturedec_button.Text = "-";
            aperturedec_button.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Dock = System.Windows.Forms.DockStyle.Fill;
            btnReset.Location = new System.Drawing.Point(120, 248);
            btnReset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnReset.Name = "btnReset";
            btnReset.Size = new System.Drawing.Size(228, 29);
            btnReset.TabIndex = 23;
            btnReset.Text = "reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // button6
            // 
            button6.Dock = System.Windows.Forms.DockStyle.Fill;
            button6.Location = new System.Drawing.Point(120, 283);
            button6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(228, 29);
            button6.TabIndex = 23;
            button6.Text = "button1";
            button6.UseVisualStyleBackColor = true;
            // 
            // down
            // 
            down.Location = new System.Drawing.Point(81, 95);
            down.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            down.Name = "down";
            down.Size = new System.Drawing.Size(75, 23);
            down.TabIndex = 0;
            down.Text = "↓";
            down.UseVisualStyleBackColor = true;
            down.MouseDown += down_MouseDown;
            down.MouseUp += StopAsync;
            // 
            // right
            // 
            right.Location = new System.Drawing.Point(155, 57);
            right.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            right.Name = "right";
            right.Size = new System.Drawing.Size(75, 23);
            right.TabIndex = 0;
            right.Text = "→";
            right.UseVisualStyleBackColor = true;
            right.MouseDown += right_MouseDown;
            right.MouseUp += StopAsync;
            // 
            // left
            // 
            left.Location = new System.Drawing.Point(6, 57);
            left.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            left.Name = "left";
            left.Size = new System.Drawing.Size(75, 23);
            left.TabIndex = 0;
            left.Text = "←";
            left.UseVisualStyleBackColor = true;
            left.MouseDown += left_MouseDown;
            left.MouseUp += StopAsync;
            // 
            // up
            // 
            up.Location = new System.Drawing.Point(81, 17);
            up.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            up.Name = "up";
            up.Size = new System.Drawing.Size(75, 23);
            up.TabIndex = 0;
            up.Text = "↑";
            up.UseVisualStyleBackColor = true;
            up.MouseDown += up_MouseDown;
            up.MouseUp += StopAsync;
            // 
            // plPlayer
            // 
            plPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            plPlayer.Location = new System.Drawing.Point(4, 3);
            plPlayer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            plPlayer.Name = "plPlayer";
            plPlayer.Size = new System.Drawing.Size(542, 504);
            plPlayer.TabIndex = 1;
            // 
            // textBox
            // 
            textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            textBox.Location = new System.Drawing.Point(1280, 3);
            textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            textBox.Size = new System.Drawing.Size(156, 53);
            textBox.TabIndex = 2;
            // 
            // lbChannels
            // 
            lbChannels.Dock = System.Windows.Forms.DockStyle.Fill;
            lbChannels.FormattingEnabled = true;
            lbChannels.ItemHeight = 15;
            lbChannels.Location = new System.Drawing.Point(1280, 62);
            lbChannels.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lbChannels.Name = "lbChannels";
            lbChannels.Size = new System.Drawing.Size(156, 489);
            lbChannels.TabIndex = 1;
            lbChannels.SelectedIndexChanged += listBox_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox1.Location = new System.Drawing.Point(354, 3);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Size = new System.Drawing.Size(918, 53);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "设备登录";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 7;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel2.Controls.Add(pwd_textBox, 5, 0);
            tableLayoutPanel2.Controls.Add(label3, 4, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(ip_textBox, 1, 0);
            tableLayoutPanel2.Controls.Add(label2, 2, 0);
            tableLayoutPanel2.Controls.Add(name_textBox, 3, 0);
            tableLayoutPanel2.Controls.Add(login_button, 6, 0);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(4, 19);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            tableLayoutPanel2.Size = new System.Drawing.Size(910, 31);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // pwd_textBox
            // 
            pwd_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            pwd_textBox.Location = new System.Drawing.Point(674, 3);
            pwd_textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pwd_textBox.Name = "pwd_textBox";
            pwd_textBox.PasswordChar = '*';
            pwd_textBox.Size = new System.Drawing.Size(126, 23);
            pwd_textBox.TabIndex = 5;
            pwd_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = System.Windows.Forms.DockStyle.Fill;
            label3.Location = new System.Drawing.Point(540, 0);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(126, 32);
            label3.TabIndex = 4;
            label3.Text = "pwd";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Location = new System.Drawing.Point(4, 0);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(126, 32);
            label1.TabIndex = 0;
            label1.Text = "IP";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ip_textBox
            // 
            ip_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            ip_textBox.Location = new System.Drawing.Point(138, 3);
            ip_textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ip_textBox.Name = "ip_textBox";
            ip_textBox.Size = new System.Drawing.Size(126, 23);
            ip_textBox.TabIndex = 1;
            ip_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Location = new System.Drawing.Point(272, 0);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(126, 32);
            label2.TabIndex = 2;
            label2.Text = "user";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // name_textBox
            // 
            name_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            name_textBox.Location = new System.Drawing.Point(406, 3);
            name_textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            name_textBox.Name = "name_textBox";
            name_textBox.Size = new System.Drawing.Size(126, 23);
            name_textBox.TabIndex = 3;
            name_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // login_button
            // 
            login_button.Location = new System.Drawing.Point(808, 3);
            login_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            login_button.Name = "login_button";
            login_button.Size = new System.Drawing.Size(95, 26);
            login_button.TabIndex = 6;
            login_button.Text = "login";
            login_button.UseVisualStyleBackColor = true;
            login_button.Click += login_button_Click_1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            tableLayoutPanel1.Controls.Add(groupBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(lbChannels, 2, 1);
            tableLayoutPanel1.Controls.Add(textBox, 2, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 1);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 2);
            tableLayoutPanel1.Controls.Add(textBox3, 1, 3);
            tableLayoutPanel1.Controls.Add(lvCameras, 0, 1);
            tableLayoutPanel1.Controls.Add(btnDiscover, 0, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanel1.Size = new System.Drawing.Size(1440, 639);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lvCameras
            // 
            lvCameras.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { Address, Mfr, Model });
            lvCameras.Dock = System.Windows.Forms.DockStyle.Fill;
            lvCameras.FullRowSelect = true;
            lvCameras.GridLines = true;
            lvCameras.HideSelection = false;
            lvCameras.Location = new System.Drawing.Point(3, 62);
            lvCameras.MultiSelect = false;
            lvCameras.Name = "lvCameras";
            lvCameras.Size = new System.Drawing.Size(344, 489);
            lvCameras.TabIndex = 6;
            lvCameras.UseCompatibleStateImageBehavior = false;
            lvCameras.View = System.Windows.Forms.View.Details;
            lvCameras.SelectedIndexChanged += lvCameras_SelectedIndexChanged;
            // 
            // Address
            // 
            Address.Text = "Address";
            Address.Width = 120;
            // 
            // Mfr
            // 
            Mfr.Text = "Mfr";
            Mfr.Width = 80;
            // 
            // Model
            // 
            Model.Text = "Model";
            Model.Width = 120;
            // 
            // btnDiscover
            // 
            btnDiscover.Dock = System.Windows.Forms.DockStyle.Fill;
            btnDiscover.Location = new System.Drawing.Point(3, 3);
            btnDiscover.Name = "btnDiscover";
            btnDiscover.Size = new System.Drawing.Size(344, 53);
            btnDiscover.TabIndex = 7;
            btnDiscover.Text = "发现";
            btnDiscover.UseVisualStyleBackColor = true;
            btnDiscover.Click += btnDiscover_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1440, 639);
            Controls.Add(tableLayoutPanel1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "ONVIF Client";
            FormClosed += OnClosed;
            Load += Form1_Load;
            tableLayoutPanel3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
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
        private System.Windows.Forms.Button btnReset;
    }
}
