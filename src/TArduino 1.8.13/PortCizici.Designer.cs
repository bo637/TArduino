namespace TArduino_1._8._13
{
    partial class PortCizici
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
            this.arduinoport = new System.IO.Ports.SerialPort(this.components);
            this.angularGauge1 = new LiveCharts.WinForms.AngularGauge();
            this.başlatbutton = new System.Windows.Forms.Button();
            this.durdurbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.appendtimer = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.gonderbutton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.solidGauge1 = new LiveCharts.WinForms.SolidGauge();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // arduinoport
            // 
            this.arduinoport.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.arduinoport_DataReceived);
            // 
            // angularGauge1
            // 
            this.angularGauge1.Location = new System.Drawing.Point(12, 59);
            this.angularGauge1.Name = "angularGauge1";
            this.angularGauge1.Size = new System.Drawing.Size(776, 396);
            this.angularGauge1.TabIndex = 0;
            this.angularGauge1.Text = "angularGauge1";
            // 
            // başlatbutton
            // 
            this.başlatbutton.Location = new System.Drawing.Point(12, 12);
            this.başlatbutton.Name = "başlatbutton";
            this.başlatbutton.Size = new System.Drawing.Size(73, 28);
            this.başlatbutton.TabIndex = 2;
            this.başlatbutton.Text = "Başlat";
            this.başlatbutton.UseVisualStyleBackColor = true;
            this.başlatbutton.Click += new System.EventHandler(this.başlatbutton_Click);
            // 
            // durdurbutton
            // 
            this.durdurbutton.Location = new System.Drawing.Point(715, 12);
            this.durdurbutton.Name = "durdurbutton";
            this.durdurbutton.Size = new System.Drawing.Size(73, 28);
            this.durdurbutton.TabIndex = 3;
            this.durdurbutton.Text = "Durdur";
            this.durdurbutton.UseVisualStyleBackColor = true;
            this.durdurbutton.Click += new System.EventHandler(this.durdurbutton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ayarla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(214, 15);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            -469762048,
            -590869294,
            5421010,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(286, 20);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // appendtimer
            // 
            this.appendtimer.Interval = 10;
            this.appendtimer.Tick += new System.EventHandler(this.appendtimer_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(794, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(275, 443);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(96, 461);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(879, 20);
            this.textBox2.TabIndex = 8;
            // 
            // gonderbutton
            // 
            this.gonderbutton.Enabled = false;
            this.gonderbutton.Location = new System.Drawing.Point(10, 459);
            this.gonderbutton.Name = "gonderbutton";
            this.gonderbutton.Size = new System.Drawing.Size(75, 23);
            this.gonderbutton.TabIndex = 9;
            this.gonderbutton.Text = "Gönder";
            this.gonderbutton.UseVisualStyleBackColor = true;
            this.gonderbutton.Click += new System.EventHandler(this.gonderbutton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "11520"});
            this.comboBox1.Location = new System.Drawing.Point(981, 461);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(88, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // solidGauge1
            // 
            this.solidGauge1.BackColorTransparent = true;
            this.solidGauge1.Location = new System.Drawing.Point(12, 72);
            this.solidGauge1.Name = "solidGauge1";
            this.solidGauge1.Size = new System.Drawing.Size(240, 122);
            this.solidGauge1.TabIndex = 11;
            this.solidGauge1.Text = "solidGauge1";
            // 
            // PortCizici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 490);
            this.Controls.Add(this.solidGauge1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.gonderbutton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.durdurbutton);
            this.Controls.Add(this.başlatbutton);
            this.Controls.Add(this.angularGauge1);
            this.Name = "PortCizici";
            this.Text = "PortCizici";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PortCizici_FormClosing);
            this.Load += new System.EventHandler(this.PortCizici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort arduinoport;
        private LiveCharts.WinForms.AngularGauge angularGauge1;
        private System.Windows.Forms.Button başlatbutton;
        private System.Windows.Forms.Button durdurbutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Timer appendtimer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button gonderbutton;
        private System.Windows.Forms.ComboBox comboBox1;
        private LiveCharts.WinForms.SolidGauge solidGauge1;
    }
}