namespace DRPC
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.setActivity = new System.Windows.Forms.Button();
            this.botID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.clearActivityBtn = new System.Windows.Forms.Button();
            this.kucukTextBox = new System.Windows.Forms.TextBox();
            this.buyukTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.kucukResimTextBox = new System.Windows.Forms.TextBox();
            this.buyukResimTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.durumTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.detayTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.shutdownBtn = new System.Windows.Forms.Button();
            this.colorBlack = new System.Windows.Forms.Button();
            this.colorTan = new System.Windows.Forms.Button();
            this.colorRed = new System.Windows.Forms.Button();
            this.colorWhite = new System.Windows.Forms.Button();
            this.colorGray = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.changeLanguageEN = new System.Windows.Forms.Button();
            this.changeLanguageTR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // setActivity
            // 
            this.setActivity.Location = new System.Drawing.Point(3, 137);
            this.setActivity.Name = "setActivity";
            this.setActivity.Size = new System.Drawing.Size(271, 40);
            this.setActivity.TabIndex = 0;
            this.setActivity.Text = "Set Activity";
            this.setActivity.UseVisualStyleBackColor = true;
            this.setActivity.Click += new System.EventHandler(this.button1_Click);
            // 
            // botID
            // 
            this.botID.Location = new System.Drawing.Point(108, 9);
            this.botID.Name = "botID";
            this.botID.Size = new System.Drawing.Size(176, 20);
            this.botID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bot ID:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(557, 254);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.clearActivityBtn);
            this.tabPage1.Controls.Add(this.kucukTextBox);
            this.tabPage1.Controls.Add(this.buyukTextBox);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.kucukResimTextBox);
            this.tabPage1.Controls.Add(this.buyukResimTextBox);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.durumTextBox);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.detayTextBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.botID);
            this.tabPage1.Controls.Add(this.setActivity);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(549, 228);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MAIN";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(290, 9);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(82, 17);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "Use Default";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(70, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Offline";
            // 
            // clearActivityBtn
            // 
            this.clearActivityBtn.Location = new System.Drawing.Point(273, 137);
            this.clearActivityBtn.Name = "clearActivityBtn";
            this.clearActivityBtn.Size = new System.Drawing.Size(268, 40);
            this.clearActivityBtn.TabIndex = 17;
            this.clearActivityBtn.Text = "Clear Activity";
            this.clearActivityBtn.UseVisualStyleBackColor = true;
            this.clearActivityBtn.Click += new System.EventHandler(this.clearActivityBtn_Click);
            // 
            // kucukTextBox
            // 
            this.kucukTextBox.Location = new System.Drawing.Point(441, 111);
            this.kucukTextBox.Name = "kucukTextBox";
            this.kucukTextBox.Size = new System.Drawing.Size(100, 20);
            this.kucukTextBox.TabIndex = 16;
            // 
            // buyukTextBox
            // 
            this.buyukTextBox.Location = new System.Drawing.Point(441, 85);
            this.buyukTextBox.Name = "buyukTextBox";
            this.buyukTextBox.Size = new System.Drawing.Size(100, 20);
            this.buyukTextBox.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(345, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Small Picture Text:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(345, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Big Picture Text:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Small Picture URL:";
            // 
            // kucukResimTextBox
            // 
            this.kucukResimTextBox.Location = new System.Drawing.Point(108, 111);
            this.kucukResimTextBox.Name = "kucukResimTextBox";
            this.kucukResimTextBox.Size = new System.Drawing.Size(176, 20);
            this.kucukResimTextBox.TabIndex = 11;
            // 
            // buyukResimTextBox
            // 
            this.buyukResimTextBox.Location = new System.Drawing.Point(108, 85);
            this.buyukResimTextBox.Name = "buyukResimTextBox";
            this.buyukResimTextBox.Size = new System.Drawing.Size(176, 20);
            this.buyukResimTextBox.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Big Picture URL:";
            // 
            // durumTextBox
            // 
            this.durumTextBox.Location = new System.Drawing.Point(108, 61);
            this.durumTextBox.Name = "durumTextBox";
            this.durumTextBox.Size = new System.Drawing.Size(176, 20);
            this.durumTextBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "State:";
            // 
            // detayTextBox
            // 
            this.detayTextBox.Location = new System.Drawing.Point(108, 35);
            this.detayTextBox.Name = "detayTextBox";
            this.detayTextBox.Size = new System.Drawing.Size(176, 20);
            this.detayTextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Details:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Status :";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(8, 196);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(535, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.shutdownBtn);
            this.tabPage2.Controls.Add(this.colorBlack);
            this.tabPage2.Controls.Add(this.colorTan);
            this.tabPage2.Controls.Add(this.colorRed);
            this.tabPage2.Controls.Add(this.colorWhite);
            this.tabPage2.Controls.Add(this.colorGray);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.changeLanguageEN);
            this.tabPage2.Controls.Add(this.changeLanguageTR);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(549, 228);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SETTINGS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(270, 25);
            this.button2.TabIndex = 12;
            this.button2.Text = "About Me";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 101);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(270, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "RESET";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // shutdownBtn
            // 
            this.shutdownBtn.Location = new System.Drawing.Point(276, 80);
            this.shutdownBtn.Name = "shutdownBtn";
            this.shutdownBtn.Size = new System.Drawing.Size(270, 23);
            this.shutdownBtn.TabIndex = 9;
            this.shutdownBtn.Text = "SHUTDOWN";
            this.shutdownBtn.UseVisualStyleBackColor = true;
            this.shutdownBtn.Click += new System.EventHandler(this.shutdownBtn_Click);
            // 
            // colorBlack
            // 
            this.colorBlack.BackColor = System.Drawing.Color.Black;
            this.colorBlack.Location = new System.Drawing.Point(246, 43);
            this.colorBlack.Name = "colorBlack";
            this.colorBlack.Size = new System.Drawing.Size(30, 30);
            this.colorBlack.TabIndex = 8;
            this.colorBlack.UseVisualStyleBackColor = false;
            this.colorBlack.Click += new System.EventHandler(this.colorBlack_Click);
            // 
            // colorTan
            // 
            this.colorTan.BackColor = System.Drawing.Color.Tan;
            this.colorTan.Location = new System.Drawing.Point(210, 43);
            this.colorTan.Name = "colorTan";
            this.colorTan.Size = new System.Drawing.Size(30, 30);
            this.colorTan.TabIndex = 7;
            this.colorTan.UseVisualStyleBackColor = false;
            this.colorTan.Click += new System.EventHandler(this.colorTan_Click);
            // 
            // colorRed
            // 
            this.colorRed.BackColor = System.Drawing.Color.Red;
            this.colorRed.Location = new System.Drawing.Point(174, 43);
            this.colorRed.Name = "colorRed";
            this.colorRed.Size = new System.Drawing.Size(30, 30);
            this.colorRed.TabIndex = 6;
            this.colorRed.UseVisualStyleBackColor = false;
            this.colorRed.Click += new System.EventHandler(this.colorRed_Click);
            // 
            // colorWhite
            // 
            this.colorWhite.BackColor = System.Drawing.Color.LightGray;
            this.colorWhite.Location = new System.Drawing.Point(138, 43);
            this.colorWhite.Name = "colorWhite";
            this.colorWhite.Size = new System.Drawing.Size(30, 30);
            this.colorWhite.TabIndex = 5;
            this.colorWhite.UseVisualStyleBackColor = false;
            this.colorWhite.Click += new System.EventHandler(this.colorWhite_Click);
            // 
            // colorGray
            // 
            this.colorGray.BackColor = System.Drawing.Color.DarkGray;
            this.colorGray.Location = new System.Drawing.Point(102, 43);
            this.colorGray.Name = "colorGray";
            this.colorGray.Size = new System.Drawing.Size(30, 30);
            this.colorGray.TabIndex = 4;
            this.colorGray.UseVisualStyleBackColor = false;
            this.colorGray.Click += new System.EventHandler(this.colorGray_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select Theme";
            // 
            // changeLanguageEN
            // 
            this.changeLanguageEN.Location = new System.Drawing.Point(138, 6);
            this.changeLanguageEN.Name = "changeLanguageEN";
            this.changeLanguageEN.Size = new System.Drawing.Size(30, 30);
            this.changeLanguageEN.TabIndex = 2;
            this.changeLanguageEN.Text = "EN";
            this.changeLanguageEN.UseVisualStyleBackColor = true;
            this.changeLanguageEN.Click += new System.EventHandler(this.changeLanguageEN_Click);
            // 
            // changeLanguageTR
            // 
            this.changeLanguageTR.Location = new System.Drawing.Point(102, 6);
            this.changeLanguageTR.Name = "changeLanguageTR";
            this.changeLanguageTR.Size = new System.Drawing.Size(30, 30);
            this.changeLanguageTR.TabIndex = 1;
            this.changeLanguageTR.Text = "TR";
            this.changeLanguageTR.UseVisualStyleBackColor = true;
            this.changeLanguageTR.Click += new System.EventHandler(this.changeLanguageTR_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select Language";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(445, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(217, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "min.512x512";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(217, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "min.512x512";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 254);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Discord Fake Rich Asset Visualizer || Developed by Furkan Ulgen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button setActivity;
        private System.Windows.Forms.TextBox botID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button changeLanguageEN;
        private System.Windows.Forms.Button changeLanguageTR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button colorBlack;
        private System.Windows.Forms.Button colorTan;
        private System.Windows.Forms.Button colorRed;
        private System.Windows.Forms.Button colorWhite;
        private System.Windows.Forms.Button colorGray;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox detayTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox durumTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox kucukResimTextBox;
        private System.Windows.Forms.TextBox buyukResimTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox kucukTextBox;
        private System.Windows.Forms.TextBox buyukTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button clearActivityBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button shutdownBtn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

