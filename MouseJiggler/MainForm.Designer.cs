
namespace ArkaneSystems.MouseJiggler
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            jiggleTimer = new System.Windows.Forms.Timer(components);
            flpLayout = new System.Windows.Forms.FlowLayoutPanel();
            panelBase = new System.Windows.Forms.Panel();
            button1 = new System.Windows.Forms.Button();
            cmdAbout = new System.Windows.Forms.Button();
            cmdTrayify = new System.Windows.Forms.Button();
            cbJiggling = new System.Windows.Forms.CheckBox();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            cbStartup = new System.Windows.Forms.CheckBox();
            label1 = new System.Windows.Forms.Label();
            lbPeriod = new System.Windows.Forms.Label();
            tbPeriod = new System.Windows.Forms.TrackBar();
            cbMinimize = new System.Windows.Forms.CheckBox();
            cbZen = new System.Windows.Forms.CheckBox();
            tabPage2 = new System.Windows.Forms.TabPage();
            button3 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            dtEnd = new System.Windows.Forms.DateTimePicker();
            dtBegin = new System.Windows.Forms.DateTimePicker();
            lv = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            rbSchedule = new System.Windows.Forms.RadioButton();
            rbEverytime = new System.Windows.Forms.RadioButton();
            niTray = new System.Windows.Forms.NotifyIcon(components);
            tabPage3 = new System.Windows.Forms.TabPage();
            lbOutOfSchedule = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            flpLayout.SuspendLayout();
            panelBase.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbPeriod).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // jiggleTimer
            // 
            jiggleTimer.Interval = 1000;
            jiggleTimer.Tick += jiggleTimer_Tick;
            // 
            // flpLayout
            // 
            flpLayout.AutoSize = true;
            flpLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flpLayout.Controls.Add(panelBase);
            flpLayout.Controls.Add(tabControl1);
            flpLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            flpLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flpLayout.Location = new System.Drawing.Point(0, 0);
            flpLayout.Name = "flpLayout";
            flpLayout.Padding = new System.Windows.Forms.Padding(5);
            flpLayout.Size = new System.Drawing.Size(358, 324);
            flpLayout.TabIndex = 2;
            // 
            // panelBase
            // 
            panelBase.Controls.Add(button1);
            panelBase.Controls.Add(cmdAbout);
            panelBase.Controls.Add(cmdTrayify);
            panelBase.Controls.Add(cbJiggling);
            panelBase.Location = new System.Drawing.Point(8, 8);
            panelBase.Name = "panelBase";
            panelBase.Size = new System.Drawing.Size(289, 28);
            panelBase.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(118, 2);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(61, 23);
            button1.TabIndex = 4;
            button1.Text = "Settings";
            button1.UseVisualStyleBackColor = true;
            button1.Click += cbSettings_CheckedChanged;
            // 
            // cmdAbout
            // 
            cmdAbout.Location = new System.Drawing.Point(185, 2);
            cmdAbout.Name = "cmdAbout";
            cmdAbout.Size = new System.Drawing.Size(53, 23);
            cmdAbout.TabIndex = 2;
            cmdAbout.Text = "About";
            cmdAbout.UseVisualStyleBackColor = true;
            cmdAbout.Click += cmdAbout_Click;
            // 
            // cmdTrayify
            // 
            cmdTrayify.Location = new System.Drawing.Point(244, 2);
            cmdTrayify.Name = "cmdTrayify";
            cmdTrayify.Size = new System.Drawing.Size(40, 23);
            cmdTrayify.TabIndex = 3;
            cmdTrayify.Text = "Hide";
            cmdTrayify.UseVisualStyleBackColor = true;
            cmdTrayify.Click += cmdTrayify_Click;
            // 
            // cbJiggling
            // 
            cbJiggling.AutoSize = true;
            cbJiggling.Location = new System.Drawing.Point(10, 5);
            cbJiggling.Name = "cbJiggling";
            cbJiggling.Size = new System.Drawing.Size(104, 19);
            cbJiggling.TabIndex = 0;
            cbJiggling.Text = "Enable jiggling";
            cbJiggling.UseVisualStyleBackColor = true;
            cbJiggling.CheckedChanged += cbJiggling_CheckedChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new System.Drawing.Point(8, 42);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(289, 242);
            tabControl1.TabIndex = 4;
            tabControl1.Visible = false;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(cbStartup);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(lbPeriod);
            tabPage1.Controls.Add(tbPeriod);
            tabPage1.Controls.Add(cbMinimize);
            tabPage1.Controls.Add(cbZen);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(281, 214);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Settings";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbStartup
            // 
            cbStartup.AutoSize = true;
            cbStartup.Location = new System.Drawing.Point(10, 62);
            cbStartup.Name = "cbStartup";
            cbStartup.Size = new System.Drawing.Size(107, 19);
            cbStartup.TabIndex = 8;
            cbStartup.Text = "Jigging on start";
            cbStartup.UseVisualStyleBackColor = true;
            cbStartup.Click += checkBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(10, 101);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(46, 15);
            label1.TabIndex = 7;
            label1.Text = "Interval";
            // 
            // lbPeriod
            // 
            lbPeriod.AutoSize = true;
            lbPeriod.Location = new System.Drawing.Point(232, 119);
            lbPeriod.Name = "lbPeriod";
            lbPeriod.Size = new System.Drawing.Size(21, 15);
            lbPeriod.TabIndex = 3;
            lbPeriod.Text = "1 s";
            // 
            // tbPeriod
            // 
            tbPeriod.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbPeriod.BackColor = System.Drawing.SystemColors.ControlLightLight;
            tbPeriod.Location = new System.Drawing.Point(3, 119);
            tbPeriod.Maximum = 60;
            tbPeriod.Minimum = 1;
            tbPeriod.Name = "tbPeriod";
            tbPeriod.Size = new System.Drawing.Size(223, 45);
            tbPeriod.TabIndex = 6;
            tbPeriod.TickFrequency = 2;
            tbPeriod.Value = 1;
            tbPeriod.ValueChanged += tbPeriod_ValueChanged;
            // 
            // cbMinimize
            // 
            cbMinimize.AutoSize = true;
            cbMinimize.Location = new System.Drawing.Point(10, 37);
            cbMinimize.Name = "cbMinimize";
            cbMinimize.Size = new System.Drawing.Size(117, 19);
            cbMinimize.TabIndex = 5;
            cbMinimize.Text = "Minimize on start";
            cbMinimize.UseVisualStyleBackColor = true;
            cbMinimize.CheckedChanged += cbMinimize_CheckedChanged;
            // 
            // cbZen
            // 
            cbZen.AutoSize = true;
            cbZen.Location = new System.Drawing.Point(10, 12);
            cbZen.Name = "cbZen";
            cbZen.Size = new System.Drawing.Size(161, 19);
            cbZen.TabIndex = 4;
            cbZen.Text = "Don't move mouse cursor";
            cbZen.UseVisualStyleBackColor = true;
            cbZen.CheckedChanged += cbZen_CheckedChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(dtEnd);
            tabPage2.Controls.Add(dtBegin);
            tabPage2.Controls.Add(lv);
            tabPage2.Controls.Add(rbSchedule);
            tabPage2.Controls.Add(rbEverytime);
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(281, 214);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Schedule";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(208, 149);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(67, 52);
            button3.TabIndex = 8;
            button3.Text = "Remove";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(135, 149);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(67, 52);
            button2.TabIndex = 7;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 184);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(27, 15);
            label3.TabIndex = 6;
            label3.Text = "End";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 155);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(37, 15);
            label2.TabIndex = 5;
            label2.Text = "Begin";
            // 
            // dtEnd
            // 
            dtEnd.CustomFormat = "HH:mm";
            dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtEnd.Location = new System.Drawing.Point(49, 178);
            dtEnd.Name = "dtEnd";
            dtEnd.ShowUpDown = true;
            dtEnd.Size = new System.Drawing.Size(80, 23);
            dtEnd.TabIndex = 4;
            dtEnd.Value = new System.DateTime(2024, 8, 6, 18, 0, 0, 0);
            // 
            // dtBegin
            // 
            dtBegin.CustomFormat = "HH:mm";
            dtBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtBegin.Location = new System.Drawing.Point(49, 149);
            dtBegin.Name = "dtBegin";
            dtBegin.ShowUpDown = true;
            dtBegin.Size = new System.Drawing.Size(80, 23);
            dtBegin.TabIndex = 3;
            dtBegin.Value = new System.DateTime(2024, 8, 6, 9, 0, 0, 0);
            // 
            // lv
            // 
            lv.CheckBoxes = true;
            lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2 });
            lv.FullRowSelect = true;
            lv.Location = new System.Drawing.Point(6, 33);
            lv.Name = "lv";
            lv.Size = new System.Drawing.Size(269, 110);
            lv.TabIndex = 2;
            lv.UseCompatibleStateImageBehavior = false;
            lv.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Begin";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "End";
            columnHeader2.Width = 100;
            // 
            // rbSchedule
            // 
            rbSchedule.AutoSize = true;
            rbSchedule.Location = new System.Drawing.Point(88, 6);
            rbSchedule.Name = "rbSchedule";
            rbSchedule.Size = new System.Drawing.Size(73, 19);
            rbSchedule.TabIndex = 1;
            rbSchedule.Text = "Schedule";
            rbSchedule.UseVisualStyleBackColor = true;
            rbSchedule.Click += radioButton2_Click;
            // 
            // rbEverytime
            // 
            rbEverytime.AutoSize = true;
            rbEverytime.Checked = true;
            rbEverytime.Location = new System.Drawing.Point(6, 6);
            rbEverytime.Name = "rbEverytime";
            rbEverytime.Size = new System.Drawing.Size(76, 19);
            rbEverytime.TabIndex = 0;
            rbEverytime.TabStop = true;
            rbEverytime.Text = "Everytime";
            rbEverytime.UseVisualStyleBackColor = true;
            rbEverytime.Click += radioButton2_Click;
            // 
            // niTray
            // 
            niTray.Icon = (System.Drawing.Icon)resources.GetObject("niTray.Icon");
            niTray.Text = "Mouse Jiggler";
            niTray.DoubleClick += niTray_DoubleClick;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(lbOutOfSchedule);
            tabPage3.Location = new System.Drawing.Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new System.Windows.Forms.Padding(3);
            tabPage3.Size = new System.Drawing.Size(281, 214);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Status";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // lbOutOfSchedule
            // 
            lbOutOfSchedule.AutoSize = true;
            lbOutOfSchedule.Location = new System.Drawing.Point(114, 13);
            lbOutOfSchedule.Name = "lbOutOfSchedule";
            lbOutOfSchedule.Size = new System.Drawing.Size(99, 15);
            lbOutOfSchedule.TabIndex = 10;
            lbOutOfSchedule.Text = "[Out of schedule]";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(11, 13);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(90, 15);
            label4.TabIndex = 11;
            label4.Text = "Schedule Status";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ClientSize = new System.Drawing.Size(358, 324);
            Controls.Add(flpLayout);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Text = "Mouse Jiggler";
            Load += MainForm_Load;
            Shown += MainForm_Shown;
            flpLayout.ResumeLayout(false);
            panelBase.ResumeLayout(false);
            panelBase.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbPeriod).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer jiggleTimer;
        private System.Windows.Forms.FlowLayoutPanel flpLayout;
        private System.Windows.Forms.TrackBar tbPeriod;
        private System.Windows.Forms.CheckBox cbMinimize;
        private System.Windows.Forms.CheckBox cbZen;
        private System.Windows.Forms.Panel panelBase;
        private System.Windows.Forms.CheckBox cbJiggling;
        private System.Windows.Forms.Label lbPeriod;
        private System.Windows.Forms.Button cmdAbout;
        private System.Windows.Forms.NotifyIcon niTray;
        private System.Windows.Forms.Button cmdTrayify;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.RadioButton rbSchedule;
        private System.Windows.Forms.RadioButton rbEverytime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtBegin;
        private System.Windows.Forms.CheckBox cbStartup;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbOutOfSchedule;
    }
}

