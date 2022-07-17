
namespace WindowsFormsApp5
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1Timers = new System.Windows.Forms.ListBox();
            this.button1Start = new System.Windows.Forms.Button();
            this.button2Pause = new System.Windows.Forms.Button();
            this.button3Stop = new System.Windows.Forms.Button();
            this.button4Delete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1Minute = new System.Windows.Forms.TextBox();
            this.textBox2Second = new System.Windows.Forms.TextBox();
            this.label4Timer = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBox3Description = new System.Windows.Forms.TextBox();
            this.button5Plus = new System.Windows.Forms.Button();
            this.button6Minus = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Timer";
            // 
            // listBox1Timers
            // 
            this.listBox1Timers.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1Timers.FormattingEnabled = true;
            this.listBox1Timers.ItemHeight = 14;
            this.listBox1Timers.Location = new System.Drawing.Point(15, 55);
            this.listBox1Timers.Name = "listBox1Timers";
            this.listBox1Timers.Size = new System.Drawing.Size(338, 158);
            this.listBox1Timers.TabIndex = 1;
            this.listBox1Timers.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1Start
            // 
            this.button1Start.Location = new System.Drawing.Point(19, 73);
            this.button1Start.Name = "button1Start";
            this.button1Start.Size = new System.Drawing.Size(75, 23);
            this.button1Start.TabIndex = 2;
            this.button1Start.Text = "Start";
            this.button1Start.UseVisualStyleBackColor = true;
            this.button1Start.Click += new System.EventHandler(this.button1Start_Click);
            // 
            // button2Pause
            // 
            this.button2Pause.Location = new System.Drawing.Point(374, 88);
            this.button2Pause.Name = "button2Pause";
            this.button2Pause.Size = new System.Drawing.Size(66, 23);
            this.button2Pause.TabIndex = 3;
            this.button2Pause.Text = "Pause";
            this.button2Pause.UseVisualStyleBackColor = true;
            this.button2Pause.Click += new System.EventHandler(this.button2Pause_Click);
            // 
            // button3Stop
            // 
            this.button3Stop.Location = new System.Drawing.Point(475, 88);
            this.button3Stop.Name = "button3Stop";
            this.button3Stop.Size = new System.Drawing.Size(75, 23);
            this.button3Stop.TabIndex = 4;
            this.button3Stop.Text = "Stop";
            this.button3Stop.UseVisualStyleBackColor = true;
            this.button3Stop.Click += new System.EventHandler(this.button3Stop_Click);
            // 
            // button4Delete
            // 
            this.button4Delete.Location = new System.Drawing.Point(475, 117);
            this.button4Delete.Name = "button4Delete";
            this.button4Delete.Size = new System.Drawing.Size(75, 23);
            this.button4Delete.TabIndex = 5;
            this.button4Delete.Text = "Delete";
            this.button4Delete.UseVisualStyleBackColor = true;
            this.button4Delete.Click += new System.EventHandler(this.button4Delete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Status";
            // 
            // textBox1Minute
            // 
            this.textBox1Minute.Location = new System.Drawing.Point(19, 37);
            this.textBox1Minute.MaxLength = 2;
            this.textBox1Minute.Name = "textBox1Minute";
            this.textBox1Minute.Size = new System.Drawing.Size(26, 20);
            this.textBox1Minute.TabIndex = 8;
            this.textBox1Minute.Text = "00";
            // 
            // textBox2Second
            // 
            this.textBox2Second.Location = new System.Drawing.Point(60, 37);
            this.textBox2Second.MaxLength = 2;
            this.textBox2Second.Name = "textBox2Second";
            this.textBox2Second.Size = new System.Drawing.Size(25, 20);
            this.textBox2Second.TabIndex = 9;
            this.textBox2Second.Text = "00";
            // 
            // label4Timer
            // 
            this.label4Timer.AutoSize = true;
            this.label4Timer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4Timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4Timer.Location = new System.Drawing.Point(374, 55);
            this.label4Timer.Name = "label4Timer";
            this.label4Timer.Padding = new System.Windows.Forms.Padding(3);
            this.label4Timer.Size = new System.Drawing.Size(42, 21);
            this.label4Timer.TabIndex = 10;
            this.label4Timer.Text = "00:00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = ":";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox3Description
            // 
            this.textBox3Description.Location = new System.Drawing.Point(113, 37);
            this.textBox3Description.Name = "textBox3Description";
            this.textBox3Description.Size = new System.Drawing.Size(100, 20);
            this.textBox3Description.TabIndex = 13;
            // 
            // button5Plus
            // 
            this.button5Plus.Location = new System.Drawing.Point(485, 55);
            this.button5Plus.Name = "button5Plus";
            this.button5Plus.Size = new System.Drawing.Size(27, 23);
            this.button5Plus.TabIndex = 14;
            this.button5Plus.Text = "+";
            this.button5Plus.UseVisualStyleBackColor = true;
            this.button5Plus.Click += new System.EventHandler(this.button5Plus_Click);
            // 
            // button6Minus
            // 
            this.button6Minus.Location = new System.Drawing.Point(523, 55);
            this.button6Minus.Name = "button6Minus";
            this.button6Minus.Size = new System.Drawing.Size(27, 23);
            this.button6Minus.TabIndex = 15;
            this.button6Minus.Text = "-";
            this.button6Minus.UseVisualStyleBackColor = true;
            this.button6Minus.Click += new System.EventHandler(this.button6Minus_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(612, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox1Minute);
            this.groupBox1.Controls.Add(this.textBox3Description);
            this.groupBox1.Controls.Add(this.textBox2Second);
            this.groupBox1.Controls.Add(this.button1Start);
            this.groupBox1.Location = new System.Drawing.Point(372, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 112);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set timer";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(110, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Sec";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Min";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 307);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button6Minus);
            this.Controls.Add(this.button5Plus);
            this.Controls.Add(this.label4Timer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4Delete);
            this.Controls.Add(this.button3Stop);
            this.Controls.Add(this.button2Pause);
            this.Controls.Add(this.listBox1Timers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "KitchenTimer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1Timers;
        private System.Windows.Forms.Button button1Start;
        private System.Windows.Forms.Button button2Pause;
        private System.Windows.Forms.Button button3Stop;
        private System.Windows.Forms.Button button4Delete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1Minute;
        private System.Windows.Forms.TextBox textBox2Second;
        private System.Windows.Forms.Label label4Timer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox3Description;
        private System.Windows.Forms.Button button5Plus;
        private System.Windows.Forms.Button button6Minus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

