namespace TArduino_1._8._13
{
    partial class PortEkranı
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
            this.portlogbox = new System.Windows.Forms.TextBox();
            this.arduinoport = new System.IO.Ports.SerialPort(this.components);
            this.başlatbutton = new System.Windows.Forms.Button();
            this.durdurbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // portlogbox
            // 
            this.portlogbox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.portlogbox.Location = new System.Drawing.Point(0, 27);
            this.portlogbox.Multiline = true;
            this.portlogbox.Name = "portlogbox";
            this.portlogbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.portlogbox.Size = new System.Drawing.Size(728, 400);
            this.portlogbox.TabIndex = 0;
            // 
            // arduinoport
            // 
            this.arduinoport.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.arduinoport_DataReceived);
            // 
            // başlatbutton
            // 
            this.başlatbutton.Location = new System.Drawing.Point(0, 0);
            this.başlatbutton.Name = "başlatbutton";
            this.başlatbutton.Size = new System.Drawing.Size(73, 28);
            this.başlatbutton.TabIndex = 1;
            this.başlatbutton.Text = "Başlat";
            this.başlatbutton.UseVisualStyleBackColor = true;
            this.başlatbutton.Click += new System.EventHandler(this.başlatbutton_Click);
            // 
            // durdurbutton
            // 
            this.durdurbutton.Location = new System.Drawing.Point(655, 0);
            this.durdurbutton.Name = "durdurbutton";
            this.durdurbutton.Size = new System.Drawing.Size(73, 28);
            this.durdurbutton.TabIndex = 2;
            this.durdurbutton.Text = "Durdur";
            this.durdurbutton.UseVisualStyleBackColor = true;
            this.durdurbutton.Click += new System.EventHandler(this.durdurbutton_Click);
            // 
            // PortEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 427);
            this.Controls.Add(this.durdurbutton);
            this.Controls.Add(this.başlatbutton);
            this.Controls.Add(this.portlogbox);
            this.Name = "PortEkranı";
            this.Text = "Port Ekranı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PortEkranı_FormClosing);
            this.Load += new System.EventHandler(this.PortEkranı_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox portlogbox;
        private System.IO.Ports.SerialPort arduinoport;
        private System.Windows.Forms.Button başlatbutton;
        private System.Windows.Forms.Button durdurbutton;
    }
}