using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TArduino_1._8._13
{
    public partial class PortCizici : Form
    {
        public static int maxvalue = 1000;

        public int sonsayi;

        public PortCizici()
        {
            InitializeComponent();
        }

        private void PortCizici_Load(object sender, EventArgs e)
        {
            arduinoport.PortName = TArduino.portsayisi;
            Control.CheckForIllegalCrossThreadCalls = false;
            angularGauge1.ToValue = maxvalue;
            comboBox1.SelectedIndex = comboBox1.FindStringExact("9600");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            maxvalue = (int)numericUpDown1.Value;
            angularGauge1.ToValue = maxvalue;
            solidGauge1.To = maxvalue;
        }

        private void durdurbutton_Click(object sender, EventArgs e)
        {
            arduinoport.Close();
            appendtimer.Stop();
            gonderbutton.Enabled = false;
        }

        private void PortCizici_FormClosing(object sender, FormClosingEventArgs e)
        {
            arduinoport.Close();
            appendtimer.Stop();
        }

        private void arduinoport_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string rddata = arduinoport.ReadExisting();

            if (Int32.TryParse(rddata, out int sayi))
            {
                
                sonsayi = sayi;
            }

            yaz(rddata);
        }

        private void başlatbutton_Click(object sender, EventArgs e)
        {
            arduinoport.Open();
            appendtimer.Start();
            gonderbutton.Enabled = true;
        }

        private void appendtimer_Tick(object sender, EventArgs e)
        {
            angularGauge1.Value = sonsayi;
            solidGauge1.Value = sonsayi;
        }

        public void yaz(string data)
        {
            textBox1.AppendText(data);

            Thread.Sleep(5);

            if (Int32.TryParse(textBox1.Lines.Last(), out int sayi))
            {
                sonsayi = sayi;
            }
        }

        private void gonderbutton_Click(object sender, EventArgs e)
        {
            arduinoport.WriteLine(textBox2.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = comboBox1.GetItemText(comboBox1.SelectedItem);
            arduinoport.BaudRate = Convert.ToInt32(selected);
        }
    }
}
