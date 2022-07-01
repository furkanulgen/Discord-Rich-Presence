using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DRPC;
using DiscordRpcDemo;
using System.Threading;

namespace DRPC
{
    public partial class Form1 : Form
    {
        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            botID.Enabled = false;
            botID.Text = "992424497951035403";
            tabPage1.BackColor = Color.Black;
            tabPage2.BackColor = Color.Black;
            tabPage1.ForeColor = Color.LimeGreen;
            tabPage2.ForeColor = Color.LimeGreen;
            this.BackColor = Color.Black;
            setActivity.BackColor = Color.Black;
            changeLanguageEN.BackColor = Color.Black;
            changeLanguageTR.BackColor = Color.Black;
            clearActivityBtn.BackColor = Color.Black;
            button2.BackColor = Color.Black;
            shutdownBtn.BackColor = Color.Black;
            button3.BackColor = Color.Black;
            label11.Text = "Offline";
            label11.BackColor = Color.DarkRed;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label11.Text = "Online";
            label11.BackColor = Color.LightGreen;
            label11.ForeColor = Color.Black;
            progressBar1.Value = 0;
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize(botID.Text, ref this.handlers, false, null);
            this.presence.details = detayTextBox.Text;
            this.presence.state = durumTextBox.Text;
            this.presence.largeImageKey = buyukResimTextBox.Text;
            this.presence.smallImageKey = kucukResimTextBox.Text;
            this.presence.largeImageText = buyukTextBox.Text;
            this.presence.smallImageText = kucukTextBox.Text;
            DiscordRpc.UpdatePresence(ref this.presence);
            progressBar1.ForeColor = Color.LimeGreen;
            for (int i = 0; i < 100; i++)
            {
                progressBar1.Value += 1;
                Thread.Sleep(5);
            }
        }

        private void colorGray_Click(object sender, EventArgs e)
        {
            tabPage1.BackColor = Color.DarkGray;
            tabPage2.BackColor = Color.DarkGray;
            tabPage1.ForeColor = Color.Black;
            tabPage2.ForeColor = Color.Black;
            this.BackColor = Color.DarkGray;
            clearActivityBtn.BackColor = Color.DarkGray;
            setActivity.BackColor = Color.DarkGray;
            changeLanguageEN.BackColor = Color.DarkGray;
            changeLanguageTR.BackColor = Color.DarkGray;
            button2.BackColor = Color.DarkGray;
            shutdownBtn.BackColor = Color.DarkGray;
            button3.BackColor = Color.DarkGray;
        }

        private void colorWhite_Click(object sender, EventArgs e)
        {
            tabPage1.BackColor = Color.White;
            tabPage2.BackColor = Color.White;
            tabPage1.ForeColor = Color.Black;
            tabPage2.ForeColor = Color.Black;
            this.BackColor = Color.White;
            clearActivityBtn.BackColor = Color.White;
            setActivity.BackColor = Color.White;
            changeLanguageEN.BackColor = Color.White;
            changeLanguageTR.BackColor = Color.White;
            button2.BackColor = Color.White;
            shutdownBtn.BackColor = Color.White;
            button3.BackColor = Color.White;
        }

        private void colorRed_Click(object sender, EventArgs e)
        {
            tabPage1.BackColor = Color.Red;
            tabPage2.BackColor = Color.Red;
            tabPage1.ForeColor = Color.Black;
            tabPage2.ForeColor = Color.Black;
            this.BackColor = Color.Red;
            clearActivityBtn.BackColor = Color.Red;
            setActivity.BackColor = Color.Red;
            changeLanguageEN.BackColor = Color.Red;
            changeLanguageTR.BackColor = Color.Red;
            button2.BackColor = Color.Red;
            shutdownBtn.BackColor = Color.Red;
            button3.BackColor = Color.Red;
        }

        private void colorTan_Click(object sender, EventArgs e)
        {
            tabPage1.BackColor = Color.Tan;
            tabPage2.BackColor = Color.Tan;
            tabPage1.ForeColor = Color.Black;
            tabPage2.ForeColor = Color.Black;
            this.BackColor = Color.Tan;
            clearActivityBtn.BackColor = Color.Tan;
            setActivity.BackColor = Color.Tan;
            changeLanguageEN.BackColor = Color.Tan;
            changeLanguageTR.BackColor = Color.Tan;
            button2.BackColor = Color.Tan;
            shutdownBtn.BackColor = Color.Tan;
            button3.BackColor = Color.Tan;
        }

        private void colorBlack_Click(object sender, EventArgs e)
        {
            tabPage1.BackColor = Color.Black;
            tabPage2.BackColor = Color.Black;
            tabPage1.ForeColor = Color.LimeGreen;
            tabPage2.ForeColor = Color.LimeGreen;
            this.BackColor = Color.Black;
            clearActivityBtn.BackColor = Color.Black;
            setActivity.BackColor=Color.Black;
            changeLanguageEN.BackColor=Color.Black;
            changeLanguageTR.BackColor=Color.Black;
            button2.BackColor = Color.Black;
            shutdownBtn.BackColor = Color.Black;
            button3.BackColor = Color.Black;
        }

        private void changeLanguageTR_Click(object sender, EventArgs e)
        {
            tabPage1.Text = "Ana Menü";
            tabPage2.Text = "Ayarlar";
            label5.Text = "Detaylar:";
            label6.Text = "Durum:";
            label7.Text = "Büyük Resim URL'si:";
            label8.Text = "Küçük Resim URL'si:";
            label9.Text = "Büyük Resim Yazısı:";
            label10.Text = "Küçük Resim Yazısı:";
            label2.Text = "Dil Seçin :";
            label3.Text = "Tema Seçin :";
            setActivity.Text = "Durumu Ayarla";
            clearActivityBtn.Text = "Durumu Temizle";
            label4.Text = "Durum :";
            checkBox1.Text = "Varsayılanı Kullan";
            button2.Text = "Benim hakkımda";

        }

        private void clearActivityBtn_Click(object sender, EventArgs e)
        {
            progressBar1.Value= 0;
            DiscordRpc.Shutdown();
            label11.Text = "Offline";
            label11.BackColor = Color.DarkRed;
            label11.ForeColor = Color.LimeGreen;
            progressBar1.ForeColor = Color.DarkRed;
            progressBar1.BackColor= Color.DarkRed;
            for (int i = 0; i < 100; i++)
            {
                progressBar1.Value += 1;
                Thread.Sleep(1);
            }
        }

        private void shutdownBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                botID.Enabled = false;
                botID.Text = "992424497951035403";
            }
            else if (checkBox1.Checked == false)
            {
                botID.Enabled = true;
                botID.Text = "";
            }
            else checkBox1.Checked = true;
        }

        private void changeLanguageEN_Click(object sender, EventArgs e)
        {
            tabPage1.Text = "MAIN";
            tabPage2.Text = "SETTINGS";
            label5.Text = "Details:";
            label6.Text = "State:";
            label7.Text = "Big Picture URL:";
            label8.Text = "Small Picture URL:";
            label9.Text = "Big Picture Text:";
            label10.Text = "Small Picture Text:";
            label2.Text = "Select Language";
            label3.Text = "Select Theme :";
            setActivity.Text = "Set Activity";
            clearActivityBtn.Text = "Clear Activity";
            label4.Text = "State:";
            checkBox1.Text = "Use Default";
            button2.Text = "About Me";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Github : https://github.com/furkanulgen\nDiscord : narr0w#5737\nLinkedIn : https://www.linkedin.com/in/furkanulgen/");
        }
    }
}
