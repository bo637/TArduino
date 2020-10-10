using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace TArduino_1._8._13
{
    public partial class PortEkranı : Form
    {
        public string okunandata;

        public PortEkranı()
        {
            InitializeComponent();
        }

        private void PortEkranı_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            this.Text = TArduino.portsayisi + " | Seri Port Ekranı";
            arduinoport.PortName = TArduino.portsayisi;
        }

        private void başlatbutton_Click(object sender, EventArgs e)
        {
            arduinoport.Open();
        }

        private void arduinoport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            okunandata = arduinoport.ReadExisting();
            yaz(okunandata);
        }

        private void durdurbutton_Click(object sender, EventArgs e)
        {
            arduinoport.Close();
        }

        public void yaz(string data)
        {
            portlogbox.AppendText(data);
        }

        private void PortEkranı_FormClosing(object sender, FormClosingEventArgs e)
        {
            arduinoport.Close();
        }
    }
}
