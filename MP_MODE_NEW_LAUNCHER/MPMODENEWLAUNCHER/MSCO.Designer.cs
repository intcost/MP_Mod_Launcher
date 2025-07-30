namespace MPMODENEWLAUNCHER
{
	public partial class MSCO : global::System.Windows.Forms.Form
	{
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
            this.panel1 = new System.Windows.Forms.Panel();
            this.icon = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.discordBLINK = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.telegranBLINK = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.screenshots = new System.Windows.Forms.PictureBox();
            this.image_next = new System.Windows.Forms.Button();
            this.image_prev = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RadminVPNCheckBox = new System.Windows.Forms.CheckBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.githubBLINK = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screenshots)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.icon);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 32);
            this.panel1.TabIndex = 0;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // icon
            // 
            this.icon.Dock = System.Windows.Forms.DockStyle.Left;
            this.icon.Location = new System.Drawing.Point(163, 0);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(32, 32);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon.TabIndex = 3;
            this.icon.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(148, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(15, 32);
            this.panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.button1.Location = new System.Drawing.Point(852, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "🗙";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "MSCO Cracks Launcher";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 32);
            this.panel7.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.githubBLINK);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.discordBLINK);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.telegranBLINK);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 426);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(900, 24);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(769, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "MSCO Cracks | 20??";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // discordBLINK
            // 
            this.discordBLINK.Dock = System.Windows.Forms.DockStyle.Left;
            this.discordBLINK.FlatAppearance.BorderSize = 0;
            this.discordBLINK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discordBLINK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discordBLINK.Location = new System.Drawing.Point(100, 0);
            this.discordBLINK.Name = "discordBLINK";
            this.discordBLINK.Size = new System.Drawing.Size(66, 24);
            this.discordBLINK.TabIndex = 2;
            this.discordBLINK.Text = "Discord";
            this.discordBLINK.UseVisualStyleBackColor = true;
            this.discordBLINK.Click += new System.EventHandler(this.discordBLINK_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(68, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(32, 24);
            this.panel4.TabIndex = 1;
            // 
            // telegranBLINK
            // 
            this.telegranBLINK.Dock = System.Windows.Forms.DockStyle.Left;
            this.telegranBLINK.FlatAppearance.BorderSize = 0;
            this.telegranBLINK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.telegranBLINK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.telegranBLINK.Location = new System.Drawing.Point(0, 0);
            this.telegranBLINK.Name = "telegranBLINK";
            this.telegranBLINK.Size = new System.Drawing.Size(68, 24);
            this.telegranBLINK.TabIndex = 0;
            this.telegranBLINK.Text = "Telegram";
            this.telegranBLINK.UseVisualStyleBackColor = true;
            this.telegranBLINK.Click += new System.EventHandler(this.telegranBLINK_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Steam",
            "Steam (Лицензия)",
            "LAN (Локальная сеть)"});
            this.comboBox1.Location = new System.Drawing.Point(12, 388);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel5.Controls.Add(this.screenshots);
            this.panel5.Controls.Add(this.image_next);
            this.panel5.Controls.Add(this.image_prev);
            this.panel5.Location = new System.Drawing.Point(12, 55);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(548, 300);
            this.panel5.TabIndex = 3;
            // 
            // screenshots
            // 
            this.screenshots.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenshots.Location = new System.Drawing.Point(36, 0);
            this.screenshots.Name = "screenshots";
            this.screenshots.Size = new System.Drawing.Size(476, 300);
            this.screenshots.TabIndex = 2;
            this.screenshots.TabStop = false;
            // 
            // image_next
            // 
            this.image_next.Dock = System.Windows.Forms.DockStyle.Right;
            this.image_next.FlatAppearance.BorderSize = 0;
            this.image_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.image_next.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.image_next.Location = new System.Drawing.Point(512, 0);
            this.image_next.Name = "image_next";
            this.image_next.Size = new System.Drawing.Size(36, 300);
            this.image_next.TabIndex = 1;
            this.image_next.Text = "⏵";
            this.image_next.UseVisualStyleBackColor = true;
            this.image_next.Click += new System.EventHandler(this.image_next_Click);
            // 
            // image_prev
            // 
            this.image_prev.Dock = System.Windows.Forms.DockStyle.Left;
            this.image_prev.FlatAppearance.BorderSize = 0;
            this.image_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.image_prev.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.image_prev.Location = new System.Drawing.Point(0, 0);
            this.image_prev.Name = "image_prev";
            this.image_prev.Size = new System.Drawing.Size(36, 300);
            this.image_prev.TabIndex = 0;
            this.image_prev.Text = "⏴";
            this.image_prev.UseVisualStyleBackColor = true;
            this.image_prev.Click += new System.EventHandler(this.image_prev_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(578, 55);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(306, 300);
            this.panel6.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 251);
            this.label4.TabIndex = 1;
            this.label4.Text = "Загружаем описание...\r\nБудьте чутка терпеливее..\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Загрузка...";
            // 
            // startbutton
            // 
            this.startbutton.BackColor = System.Drawing.Color.DarkGreen;
            this.startbutton.FlatAppearance.BorderSize = 0;
            this.startbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.startbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.startbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startbutton.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.startbutton.Location = new System.Drawing.Point(607, 369);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(252, 36);
            this.startbutton.TabIndex = 5;
            this.startbutton.Text = "Start!";
            this.startbutton.UseVisualStyleBackColor = false;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(192, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Состояние серверов:";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(329, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "подключаемся...";
            this.label6.Visible = false;
            // 
            // RadminVPNCheckBox
            // 
            this.RadminVPNCheckBox.AutoSize = true;
            this.RadminVPNCheckBox.Checked = true;
            this.RadminVPNCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RadminVPNCheckBox.Location = new System.Drawing.Point(192, 369);
            this.RadminVPNCheckBox.Name = "RadminVPNCheckBox";
            this.RadminVPNCheckBox.Size = new System.Drawing.Size(97, 19);
            this.RadminVPNCheckBox.TabIndex = 8;
            this.RadminVPNCheckBox.Text = "Radmin VPN";
            this.RadminVPNCheckBox.UseVisualStyleBackColor = true;
            this.RadminVPNCheckBox.Visible = false;
            this.RadminVPNCheckBox.CheckedChanged += new System.EventHandler(this.RadminVPNCheckBox_CheckedChanged);
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(166, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(32, 24);
            this.panel8.TabIndex = 4;
            // 
            // githubBLINK
            // 
            this.githubBLINK.Dock = System.Windows.Forms.DockStyle.Left;
            this.githubBLINK.FlatAppearance.BorderSize = 0;
            this.githubBLINK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.githubBLINK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.githubBLINK.Location = new System.Drawing.Point(198, 0);
            this.githubBLINK.Name = "githubBLINK";
            this.githubBLINK.Size = new System.Drawing.Size(66, 24);
            this.githubBLINK.TabIndex = 5;
            this.githubBLINK.Text = "GitHub";
            this.githubBLINK.UseVisualStyleBackColor = true;
            this.githubBLINK.Click += new System.EventHandler(this.githubBLINK_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Давайте выберем способ подключения.";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // MSCO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RadminVPNCheckBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MSCO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MSCO_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.screenshots)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private global::System.ComponentModel.IContainer components;

		private global::System.Windows.Forms.Panel panel1;

		private global::System.Windows.Forms.Button button1;

		private global::System.Windows.Forms.Label label1;

		private global::System.Windows.Forms.PictureBox icon;

		private global::System.Windows.Forms.Panel panel3;

		private global::System.Windows.Forms.Button telegranBLINK;

		private global::System.Windows.Forms.Button discordBLINK;

		private global::System.Windows.Forms.Panel panel4;

		private global::System.Windows.Forms.ComboBox comboBox1;

		private global::System.Windows.Forms.Panel panel5;

		private global::System.Windows.Forms.Button image_prev;

		private global::System.Windows.Forms.PictureBox screenshots;

		private global::System.Windows.Forms.Button image_next;

		private global::System.Windows.Forms.Label label2;

		private global::System.Windows.Forms.Panel panel6;

		private global::System.Windows.Forms.Label label4;

		private global::System.Windows.Forms.Label label3;

		private global::System.Windows.Forms.Button startbutton;

		private global::System.Windows.Forms.Panel panel2;

		private global::System.Windows.Forms.Panel panel7;

		private global::System.Windows.Forms.Label label5;

		private global::System.Windows.Forms.Label label6;

		private global::System.Windows.Forms.CheckBox RadminVPNCheckBox;
        private System.Windows.Forms.Button githubBLINK;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label7;
    }
}
