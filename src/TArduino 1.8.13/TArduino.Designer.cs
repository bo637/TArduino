namespace TArduino_1._8._13
{
    partial class TArduino
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TArduino));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taslakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portEkranıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portÇiziciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.kartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arduinoUnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arduinoNanoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arduinoMegaYadaMegaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atmega328pToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atmega328peskiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atmega168ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.yukarılabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.programlabel = new System.Windows.Forms.Label();
            this.kodbox = new ICSharpCode.TextEditor.TextEditorControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.compileprogress = new System.Windows.Forms.ProgressBar();
            this.statuslabel = new System.Windows.Forms.Label();
            this.logbox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.linestatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.kartbilgisistatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.portcheck = new System.Windows.Forms.Timer(this.components);
            this.görünümToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klasikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pembeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeşilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yukle = new OvalPictureBox();
            this.kontrol = new OvalPictureBox();
            this.morToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yukle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontrol)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.düzenleToolStripMenuItem,
            this.taslakToolStripMenuItem,
            this.araçlarToolStripMenuItem,
            this.yardımToolStripMenuItem,
            this.görünümToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(514, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripMenuItem,
            this.açToolStripMenuItem,
            this.kaydetToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // yeniToolStripMenuItem
            // 
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + N";
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.yeniToolStripMenuItem.Text = "Yeni";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.açToolStripMenuItem.Text = "Aç...";
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            // 
            // taslakToolStripMenuItem
            // 
            this.taslakToolStripMenuItem.Name = "taslakToolStripMenuItem";
            this.taslakToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.taslakToolStripMenuItem.Text = "Taslak";
            // 
            // araçlarToolStripMenuItem
            // 
            this.araçlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portEkranıToolStripMenuItem,
            this.portÇiziciToolStripMenuItem,
            this.toolStripSeparator1,
            this.kartToolStripMenuItem,
            this.işlemciToolStripMenuItem,
            this.portToolStripMenuItem});
            this.araçlarToolStripMenuItem.Name = "araçlarToolStripMenuItem";
            this.araçlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.araçlarToolStripMenuItem.Text = "Araçlar";
            // 
            // portEkranıToolStripMenuItem
            // 
            this.portEkranıToolStripMenuItem.Name = "portEkranıToolStripMenuItem";
            this.portEkranıToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.portEkranıToolStripMenuItem.Text = "Port Ekranı";
            this.portEkranıToolStripMenuItem.Click += new System.EventHandler(this.portEkranıToolStripMenuItem_Click);
            // 
            // portÇiziciToolStripMenuItem
            // 
            this.portÇiziciToolStripMenuItem.Name = "portÇiziciToolStripMenuItem";
            this.portÇiziciToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.portÇiziciToolStripMenuItem.Text = "Port Çizici";
            this.portÇiziciToolStripMenuItem.Click += new System.EventHandler(this.portÇiziciToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(128, 6);
            // 
            // kartToolStripMenuItem
            // 
            this.kartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arduinoUnoToolStripMenuItem,
            this.arduinoNanoToolStripMenuItem,
            this.arduinoMegaYadaMegaToolStripMenuItem});
            this.kartToolStripMenuItem.Name = "kartToolStripMenuItem";
            this.kartToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.kartToolStripMenuItem.Text = "Kart";
            // 
            // arduinoUnoToolStripMenuItem
            // 
            this.arduinoUnoToolStripMenuItem.Name = "arduinoUnoToolStripMenuItem";
            this.arduinoUnoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.arduinoUnoToolStripMenuItem.Text = "Arduino Uno";
            this.arduinoUnoToolStripMenuItem.Click += new System.EventHandler(this.arduinoUnoToolStripMenuItem_Click);
            // 
            // arduinoNanoToolStripMenuItem
            // 
            this.arduinoNanoToolStripMenuItem.Name = "arduinoNanoToolStripMenuItem";
            this.arduinoNanoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.arduinoNanoToolStripMenuItem.Text = "Arduino Nano";
            this.arduinoNanoToolStripMenuItem.Click += new System.EventHandler(this.arduinoNanoToolStripMenuItem_Click);
            // 
            // arduinoMegaYadaMegaToolStripMenuItem
            // 
            this.arduinoMegaYadaMegaToolStripMenuItem.Name = "arduinoMegaYadaMegaToolStripMenuItem";
            this.arduinoMegaYadaMegaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.arduinoMegaYadaMegaToolStripMenuItem.Text = "Arduino Mega";
            this.arduinoMegaYadaMegaToolStripMenuItem.Click += new System.EventHandler(this.arduinoMegaYadaMegaToolStripMenuItem_Click);
            // 
            // işlemciToolStripMenuItem
            // 
            this.işlemciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atmega328pToolStripMenuItem,
            this.atmega328peskiToolStripMenuItem,
            this.atmega168ToolStripMenuItem});
            this.işlemciToolStripMenuItem.Name = "işlemciToolStripMenuItem";
            this.işlemciToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.işlemciToolStripMenuItem.Text = "İşlemci";
            // 
            // atmega328pToolStripMenuItem
            // 
            this.atmega328pToolStripMenuItem.Name = "atmega328pToolStripMenuItem";
            this.atmega328pToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.atmega328pToolStripMenuItem.Text = "atmega328p";
            this.atmega328pToolStripMenuItem.Click += new System.EventHandler(this.atmega328pToolStripMenuItem_Click);
            // 
            // atmega328peskiToolStripMenuItem
            // 
            this.atmega328peskiToolStripMenuItem.Name = "atmega328peskiToolStripMenuItem";
            this.atmega328peskiToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.atmega328peskiToolStripMenuItem.Text = "atmega328p (eski)";
            this.atmega328peskiToolStripMenuItem.Click += new System.EventHandler(this.atmega328peskiToolStripMenuItem_Click);
            // 
            // atmega168ToolStripMenuItem
            // 
            this.atmega168ToolStripMenuItem.Name = "atmega168ToolStripMenuItem";
            this.atmega168ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.atmega168ToolStripMenuItem.Text = "atmega168";
            this.atmega168ToolStripMenuItem.Click += new System.EventHandler(this.atmega168ToolStripMenuItem_Click);
            // 
            // portToolStripMenuItem
            // 
            this.portToolStripMenuItem.Name = "portToolStripMenuItem";
            this.portToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.portToolStripMenuItem.Text = "Port";
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.panel1.Controls.Add(this.yukarılabel);
            this.panel1.Controls.Add(this.yukle);
            this.panel1.Controls.Add(this.kontrol);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 33);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // yukarılabel
            // 
            this.yukarılabel.AutoSize = true;
            this.yukarılabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yukarılabel.ForeColor = System.Drawing.Color.White;
            this.yukarılabel.Location = new System.Drawing.Point(75, 9);
            this.yukarılabel.Name = "yukarılabel";
            this.yukarılabel.Size = new System.Drawing.Size(0, 15);
            this.yukarılabel.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(161)))), ((int)(((byte)(165)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(514, 33);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.programlabel);
            this.panel4.Location = new System.Drawing.Point(12, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(85, 27);
            this.panel4.TabIndex = 0;
            // 
            // programlabel
            // 
            this.programlabel.AutoSize = true;
            this.programlabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.programlabel.Location = new System.Drawing.Point(3, 6);
            this.programlabel.Name = "programlabel";
            this.programlabel.Size = new System.Drawing.Size(77, 14);
            this.programlabel.TabIndex = 0;
            this.programlabel.Text = "000000.ino";
            // 
            // kodbox
            // 
            this.kodbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kodbox.IsReadOnly = false;
            this.kodbox.Location = new System.Drawing.Point(0, 86);
            this.kodbox.Name = "kodbox";
            this.kodbox.Size = new System.Drawing.Size(514, 313);
            this.kodbox.TabIndex = 3;
            this.kodbox.Text = "fonksiyon başlangıç()\r\n{\r\n\tpinModu(9, ÇIKIŞ);\r\n}\r\n\r\nfonksiyon döngü()\r\n{\r\n\tdijita" +
    "lYaz(9, YÜKSEK);\r\n\tbekle(500);\r\n\tdijitalYaz(9, DÜŞÜK);\r\n\tbekle(500);\r\n}";
            this.kodbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kodbox_KeyDown);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(161)))), ((int)(((byte)(165)))));
            this.panel3.Controls.Add(this.compileprogress);
            this.panel3.Controls.Add(this.statuslabel);
            this.panel3.Location = new System.Drawing.Point(0, 399);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(514, 34);
            this.panel3.TabIndex = 3;
            // 
            // compileprogress
            // 
            this.compileprogress.Location = new System.Drawing.Point(359, 6);
            this.compileprogress.Name = "compileprogress";
            this.compileprogress.Size = new System.Drawing.Size(147, 23);
            this.compileprogress.Step = 1;
            this.compileprogress.TabIndex = 1;
            this.compileprogress.Click += new System.EventHandler(this.compileprogress_Click);
            // 
            // statuslabel
            // 
            this.statuslabel.AutoSize = true;
            this.statuslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statuslabel.Location = new System.Drawing.Point(9, 8);
            this.statuslabel.Name = "statuslabel";
            this.statuslabel.Size = new System.Drawing.Size(67, 15);
            this.statuslabel.TabIndex = 0;
            this.statuslabel.Text = "Kaydedildi.";
            // 
            // logbox
            // 
            this.logbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logbox.BackColor = System.Drawing.Color.Black;
            this.logbox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.logbox.ForeColor = System.Drawing.Color.White;
            this.logbox.Location = new System.Drawing.Point(-2, 431);
            this.logbox.Multiline = true;
            this.logbox.Name = "logbox";
            this.logbox.ReadOnly = true;
            this.logbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logbox.Size = new System.Drawing.Size(516, 144);
            this.logbox.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linestatus,
            this.toolStripStatusLabel2,
            this.kartbilgisistatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 573);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(514, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // linestatus
            // 
            this.linestatus.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linestatus.ForeColor = System.Drawing.Color.White;
            this.linestatus.Name = "linestatus";
            this.linestatus.Size = new System.Drawing.Size(14, 17);
            this.linestatus.Text = "1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(485, 17);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // kartbilgisistatus
            // 
            this.kartbilgisistatus.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kartbilgisistatus.ForeColor = System.Drawing.Color.White;
            this.kartbilgisistatus.Name = "kartbilgisistatus";
            this.kartbilgisistatus.Size = new System.Drawing.Size(0, 17);
            // 
            // portcheck
            // 
            this.portcheck.Interval = 500;
            this.portcheck.Tick += new System.EventHandler(this.portcheck_Tick);
            // 
            // görünümToolStripMenuItem
            // 
            this.görünümToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temaToolStripMenuItem});
            this.görünümToolStripMenuItem.Name = "görünümToolStripMenuItem";
            this.görünümToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.görünümToolStripMenuItem.Text = "Görünüm";
            // 
            // temaToolStripMenuItem
            // 
            this.temaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.klasikToolStripMenuItem,
            this.pembeToolStripMenuItem,
            this.yeşilToolStripMenuItem,
            this.morToolStripMenuItem});
            this.temaToolStripMenuItem.Name = "temaToolStripMenuItem";
            this.temaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.temaToolStripMenuItem.Text = "Tema";
            // 
            // klasikToolStripMenuItem
            // 
            this.klasikToolStripMenuItem.Name = "klasikToolStripMenuItem";
            this.klasikToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.klasikToolStripMenuItem.Text = "Klasik";
            this.klasikToolStripMenuItem.Click += new System.EventHandler(this.klasikToolStripMenuItem_Click);
            // 
            // pembeToolStripMenuItem
            // 
            this.pembeToolStripMenuItem.Name = "pembeToolStripMenuItem";
            this.pembeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pembeToolStripMenuItem.Text = "Pembe";
            this.pembeToolStripMenuItem.Click += new System.EventHandler(this.pembeToolStripMenuItem_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            // 
            // yeşilToolStripMenuItem
            // 
            this.yeşilToolStripMenuItem.Name = "yeşilToolStripMenuItem";
            this.yeşilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yeşilToolStripMenuItem.Text = "Yeşil";
            this.yeşilToolStripMenuItem.Click += new System.EventHandler(this.yeşilToolStripMenuItem_Click);
            // 
            // yukle
            // 
            this.yukle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(161)))), ((int)(((byte)(165)))));
            this.yukle.Image = ((System.Drawing.Image)(resources.GetObject("yukle.Image")));
            this.yukle.Location = new System.Drawing.Point(39, 2);
            this.yukle.Name = "yukle";
            this.yukle.Size = new System.Drawing.Size(28, 28);
            this.yukle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yukle.TabIndex = 1;
            this.yukle.TabStop = false;
            this.yukle.Click += new System.EventHandler(this.yukle_Click);
            this.yukle.MouseEnter += new System.EventHandler(this.yukle_MouseEnter);
            this.yukle.MouseLeave += new System.EventHandler(this.yukle_MouseLeave);
            // 
            // kontrol
            // 
            this.kontrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(161)))), ((int)(((byte)(165)))));
            this.kontrol.Image = ((System.Drawing.Image)(resources.GetObject("kontrol.Image")));
            this.kontrol.Location = new System.Drawing.Point(6, 2);
            this.kontrol.Name = "kontrol";
            this.kontrol.Size = new System.Drawing.Size(28, 28);
            this.kontrol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kontrol.TabIndex = 0;
            this.kontrol.TabStop = false;
            this.kontrol.Click += new System.EventHandler(this.kontrol_Click);
            this.kontrol.MouseEnter += new System.EventHandler(this.kontrol_MouseEnter);
            this.kontrol.MouseLeave += new System.EventHandler(this.kontrol_MouseLeave);
            // 
            // morToolStripMenuItem
            // 
            this.morToolStripMenuItem.Name = "morToolStripMenuItem";
            this.morToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.morToolStripMenuItem.Text = "Mor";
            this.morToolStripMenuItem.Click += new System.EventHandler(this.morToolStripMenuItem_Click);
            // 
            // TArduino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 595);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.kodbox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.logbox);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TArduino";
            this.Text = "TArduino 1.8.13";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yukle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontrol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private ICSharpCode.TextEditor.TextEditorControl kodbox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label statuslabel;
        private System.Windows.Forms.TextBox logbox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private OvalPictureBox kontrol;
        private OvalPictureBox yukle;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taslakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.Label yukarılabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label programlabel;
        private System.Windows.Forms.ProgressBar compileprogress;
        private System.Windows.Forms.ToolStripMenuItem portEkranıToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem kartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arduinoUnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arduinoNanoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arduinoMegaYadaMegaToolStripMenuItem;
        private System.Windows.Forms.Timer portcheck;
        private System.Windows.Forms.ToolStripMenuItem işlemciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel linestatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel kartbilgisistatus;
        private System.Windows.Forms.ToolStripMenuItem atmega328pToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atmega328peskiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atmega168ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portÇiziciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görünümToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klasikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pembeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeşilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem morToolStripMenuItem;
    }
}

