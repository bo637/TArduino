using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.IO.Ports;

namespace TArduino_1._8._13
{
    public partial class TArduino : Form
    {
        public string kart;

        public string kartadi;

        public string tema = "klasik";

        public static string portsayisi;

        public string islemci;

        public static string klasoradi;

        public int dongu = 0;

        public TArduino()
        {
            InitializeComponent();
        }

        private void kontrol_Click(object sender, EventArgs e)
        {
            if (kart == null)
            {
                statuslabel.Text = "Lütfen araçlar kısmından bir kart seçin.";
            }
            else
            {
                compileprogress.Value = 0;
                compileprogress.Visible = true;

                statuslabel.Text = "Kontrol Ediliyor...";

                if (!Directory.Exists(klasoradi))
                {
                    Directory.CreateDirectory(klasoradi);
                }

                if (!File.Exists(Path.Combine(klasoradi, klasoradi + ".ino")))
                {
                    var dosya = File.Create(Path.Combine(klasoradi, klasoradi + ".ino"));
                    dosya.Close();
                }

                File.WriteAllText(Path.Combine(klasoradi, klasoradi + ".ino"), donustur(kodbox.Text));


                Process p = new Process();

                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.FileName = "binaries/arduino.exe";
                p.StartInfo.Arguments = "--fqbn " + kart + ":cpu=" + islemci + " compile " + Path.Combine(klasoradi, klasoradi + ".ino");
                p.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory();
                p.Start();

                StreamReader reader = p.StandardOutput;
                string çıktı = reader.ReadToEnd();

                p.WaitForExit();
                logbox.Text = çıktı;

                if (çıktı == "")
                {
                    statuslabel.Text = "Hata!";
                    compileprogress.Value += 100;
                    compileprogress.ForeColor = Color.Red;
                    panel3.BackColor = Color.Red;
                }
                else
                {
                    statuslabel.Text = "Başarılı.";
                    compileprogress.Value += 100;
                }
            }
        }

        private void kontrol_MouseEnter(object sender, EventArgs e)
        {
            kontrol.BackColor = Color.White;
            yukarılabel.Text = "Kontrol Et";
        }

        private void kontrol_MouseLeave(object sender, EventArgs e)
        {
            Color açıkyeşil = ColorTranslator.FromHtml("#2ECC71");
            Color açıkklasik = ColorTranslator.FromHtml("#17A1A5");
            Color açıkpembe = ColorTranslator.FromHtml("#E17F93");
            Color açıkmor = ColorTranslator.FromHtml("#9B59B6");

            if (tema == "pembe")
            {
                kontrol.BackColor = açıkpembe;
            }
            if (tema == "klasik")
            {
                kontrol.BackColor = açıkklasik;
            }
            if (tema == "yeşil")
            {
                kontrol.BackColor = açıkyeşil;
            }
            if (tema == "mor")
            {
                kontrol.BackColor = açıkmor;
            }

            yukarılabel.Text = "";
        }

        private void yukle_MouseEnter(object sender, EventArgs e)
        {
            yukle.BackColor = Color.White;
            yukarılabel.Text = "Yükle";
        }

        private void yukle_MouseLeave(object sender, EventArgs e)
        {
            Color açıkyeşil = ColorTranslator.FromHtml("#2ECC71");
            Color açıkklasik = ColorTranslator.FromHtml("#17A1A5");
            Color açıkpembe = ColorTranslator.FromHtml("#E17F93");
            Color açıkmor = ColorTranslator.FromHtml("#9B59B6");

            if (tema == "pembe")
            {
                yukle.BackColor = açıkpembe;
            }
            if (tema == "klasik")
            {
                yukle.BackColor = açıkklasik;
            }
            if (tema == "yeşil")
            {
                yukle.BackColor = açıkyeşil;
            }
            if (tema == "mor")
            {
                yukle.BackColor = açıkmor;
            }

            yukarılabel.Text = "";
        }

        private void yukle_Click(object sender, EventArgs e)
        {
            if (kart == null || portsayisi == null || islemci == null)
            {
                statuslabel.Text = "Lütfen araçlar kısmından bir kart/port seçin.";
            }
            else
            {
                kontrol_Click(null, null);

                compileprogress.Value = 0;
                compileprogress.Visible = true;

                statuslabel.Text = "Kontrol Ediliyor...";

                if (!Directory.Exists(klasoradi))
                {
                    Directory.CreateDirectory(klasoradi);
                }

                if (!File.Exists(Path.Combine(klasoradi, klasoradi + ".ino")))
                {
                    var dosya = File.Create(Path.Combine(klasoradi, klasoradi + ".ino"));
                    dosya.Close();
                }

                File.WriteAllText(Path.Combine(klasoradi, klasoradi + ".ino"), donustur(kodbox.Text));


                Process p = new Process();

                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.FileName = "binaries/arduino.exe";
                p.StartInfo.Arguments = "--fqbn " + kart + ":cpu=" + islemci + " --port " + portsayisi + " upload " + Path.Combine(klasoradi, klasoradi + ".ino");
                p.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory();
                p.Start();

                StreamReader reader = p.StandardOutput;
                string çıktı = reader.ReadToEnd();

                p.WaitForExit();
                logbox.Text = çıktı;

                if (çıktı == "")
                {
                    statuslabel.Text = "Başarılı.";
                    compileprogress.Value += 100;
                }
                else
                {
                    statuslabel.Text = "Hata!";
                    compileprogress.Value += 100;
                    compileprogress.BackColor = Color.Red;
                }
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public string donustur(string kod)
        {
            kod = kod.Replace("fonksiyon", "void");
            kod = kod.Replace("pinModu", "pinMode");
            kod = kod.Replace("ÇIKIŞ", "OUTPUT");
            kod = kod.Replace("GİRİŞ", "INPUT");
            kod = kod.Replace("dijitalYaz(", "digitalWrite(");
            kod = kod.Replace("dijitalOku(", "digitalRead(");
            kod = kod.Replace("analogOku(", "analogRead(");
            kod = kod.Replace("YÜKSEK", "HIGH");
            kod = kod.Replace("DÜŞÜK", "LOW");
            kod = kod.Replace("Çıktı.hazırla(", "Serial.begin(");
            kod = kod.Replace("Çıktı.yaz(", "Serial.print(");
            kod = kod.Replace("Çıktı.satırayaz(", "Serial.println(");
            kod = kod.Replace("başlangıç", "setup");
            kod = kod.Replace("döngü", "loop");
            kod = kod.Replace("bekle(", "delay(");

            return kod;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random randomsayi = new Random();
            klasoradi = randomsayi.Next(100000, 999999).ToString();
            programlabel.Text = klasoradi + ".ino";
            compileprogress.Visible = false;
            portcheck.Start();
        }

        private void compileprogress_Click(object sender, EventArgs e)
        {

        }

        private void arduinoMegaYadaMegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kart = "arduino:avr:mega";
            kartadi = arduinoMegaYadaMegaToolStripMenuItem.Text;
            kartToolStripMenuItem.Text = "Kart: '" + kartadi + "'";
        }

        private void arduinoUnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kart = "arduino:avr:uno";
            kartadi = arduinoUnoToolStripMenuItem.Text;
            kartToolStripMenuItem.Text = "Kart: '" + kartadi + "'";
        }

        private void arduinoNanoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kart = "arduino:avr:nano";
            kartadi = arduinoNanoToolStripMenuItem.Text;
            kartToolStripMenuItem.Text = "Kart: '" + kartadi + "'";
        }

        private void kodbox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void portcheck_Tick(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();



            foreach (string port in ports)
            {
                if (dongu == 0)
                {
                    var item = new ToolStripMenuItem()
                    {
                        Name = port,
                        Text = port
                    };

                    portToolStripMenuItem.DropDownItems.Add(item);
                    item.Click += tiklandi;
                }

                else
                {
                    foreach (ToolStripMenuItem portitem in portToolStripMenuItem.DropDownItems)
                    {
                        if (portitem.Text != port)
                        {
                            var item = new ToolStripMenuItem()
                            {
                                Name = port,
                                Text = port
                            };
                            
                            portToolStripMenuItem.DropDownItems.Add(item);
                            item.Click += tiklandi;
                        }
                    }
                }
            }

            dongu++;
        }

        public void tiklandi(object sender, EventArgs e)
        {
            var item = sender as ToolStripMenuItem;
            if (kart == null)
            {
                statuslabel.Text = "Kart seçmeden port seçemezsiniz.";
            }
            else
            {
                portsayisi = item.Text;
                kartbilgisistatus.Text = portsayisi + "'te " + kartadi;
            }
        }

        private void atmega328pToolStripMenuItem_Click(object sender, EventArgs e)
        {
            islemci = "atmega328";
            toolStripStatusLabel2.Text = islemci;
        }

        private void atmega328peskiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            islemci = "atmega328old";
            toolStripStatusLabel2.Text = islemci;
        }

        private void atmega168ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            islemci = "atmega168";
            toolStripStatusLabel2.Text = islemci;
        }

        private void portEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PortEkranı portek = new PortEkranı();
            portek.Show();
        }

        private void portÇiziciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PortCizici portci = new PortCizici();
            portci.Show();
        }

        private void klasikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tema = "klasik";
            Image kontrolimage = Image.FromFile("resimler/klasik/check.png");
            Image yukleimage = Image.FromFile("resimler/klasik/upload.png");
            Color koyuyeşil = ColorTranslator.FromHtml("#006468");
            Color açıkklasik = ColorTranslator.FromHtml("#17A1A5");
            panel1.BackColor = koyuyeşil;
            statusStrip1.BackColor = koyuyeşil;
            panel2.BackColor = açıkklasik;
            panel3.BackColor = açıkklasik;
            kontrol.BackColor = açıkklasik;
            yukle.BackColor = açıkklasik;
            kontrol.Image = kontrolimage;
            yukle.Image = yukleimage;
        }

        private void pembeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tema = "pembe";
            Image kontrolimage = Image.FromFile("resimler/pembe/check.png");
            Image yukleimage = Image.FromFile("resimler/pembe/upload.png");
            Color koyupembe = ColorTranslator.FromHtml("#CD5E77");
            Color açıkpembe = ColorTranslator.FromHtml("#E17F93");
            panel1.BackColor = koyupembe;
            statusStrip1.BackColor = koyupembe;
            panel2.BackColor = açıkpembe;
            panel3.BackColor = açıkpembe;
            kontrol.BackColor = açıkpembe;
            yukle.BackColor = açıkpembe;
            kontrol.Image = kontrolimage;
            yukle.Image = yukleimage;
        }

        private void yeşilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tema = "yeşil";
            Image kontrolimage = Image.FromFile("resimler/yeşil/check.png");
            Image yukleimage = Image.FromFile("resimler/yeşil/upload.png");
            Color koyuyeşil = ColorTranslator.FromHtml("#27AE60");
            Color açıkyeşil = ColorTranslator.FromHtml("#2ECC71");
            panel1.BackColor = koyuyeşil;
            statusStrip1.BackColor = koyuyeşil;
            panel2.BackColor = açıkyeşil;
            panel3.BackColor = açıkyeşil;
            kontrol.BackColor = açıkyeşil;
            yukle.BackColor = açıkyeşil;
            kontrol.Image = kontrolimage;
            yukle.Image = yukleimage;
        }

        private void morToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tema = "mor";
            Image kontrolimage = Image.FromFile("resimler/mor/check.png");
            Image yukleimage = Image.FromFile("resimler/mor/upload.png");
            Color koyumor = ColorTranslator.FromHtml("#8E44AD");
            Color açıkmor = ColorTranslator.FromHtml("#9B59B6");
            panel1.BackColor = koyumor;
            statusStrip1.BackColor = koyumor;
            panel2.BackColor = açıkmor;
            panel3.BackColor = açıkmor;
            kontrol.BackColor = açıkmor;
            yukle.BackColor = açıkmor;
            kontrol.Image = kontrolimage;
            yukle.Image = yukleimage;
        }
    }
}
