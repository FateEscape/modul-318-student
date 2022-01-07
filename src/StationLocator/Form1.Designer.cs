namespace StationLocator;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Startseite = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel16 = new System.Windows.Forms.Panel();
            this.Verbindung4 = new System.Windows.Forms.Label();
            this.Verbindung3 = new System.Windows.Forms.Label();
            this.Verbindung2 = new System.Windows.Forms.Label();
            this.Verbindung1 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.TextEndStation = new System.Windows.Forms.TextBox();
            this.TextStartStation = new System.Windows.Forms.TextBox();
            this.Datumpicker = new System.Windows.Forms.DateTimePicker();
            this.Losfahrenbt = new System.Windows.Forms.Button();
            this.Zeittb = new System.Windows.Forms.TextBox();
            this.Verbindungen = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.VerbindungenGrid = new System.Windows.Forms.DataGridView();
            this.panel17 = new System.Windows.Forms.Panel();
            this.Stationsuchentb = new System.Windows.Forms.TextBox();
            this.Stationsuchenknopf = new System.Windows.Forms.Button();
            this.HilfeundKontakt = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Passwordtb = new System.Windows.Forms.TextBox();
            this.Emailbt = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Anliegentb = new System.Windows.Forms.TextBox();
            this.Stadttb = new System.Windows.Forms.TextBox();
            this.Strassetb = new System.Windows.Forms.TextBox();
            this.Nachnametb = new System.Windows.Forms.TextBox();
            this.Vornametb = new System.Windows.Forms.TextBox();
            this.HostEmailtb = new System.Windows.Forms.TextBox();
            this.Anredetb = new System.Windows.Forms.TextBox();
            this.Betrefftb = new System.Windows.Forms.TextBox();
            this.Firmatb = new System.Windows.Forms.TextBox();
            this.Optionen = new System.Windows.Forms.TabPage();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Startseite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Verbindungen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VerbindungenGrid)).BeginInit();
            this.HilfeundKontakt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            this.Optionen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Startseite);
            this.tabControl1.Controls.Add(this.Verbindungen);
            this.tabControl1.Controls.Add(this.HilfeundKontakt);
            this.tabControl1.Controls.Add(this.Optionen);
            this.tabControl1.Location = new System.Drawing.Point(1, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(936, 660);
            this.tabControl1.TabIndex = 0;
            // 
            // Startseite
            // 
            this.Startseite.Controls.Add(this.pictureBox1);
            this.Startseite.Controls.Add(this.panel16);
            this.Startseite.Controls.Add(this.Verbindung4);
            this.Startseite.Controls.Add(this.Verbindung3);
            this.Startseite.Controls.Add(this.Verbindung2);
            this.Startseite.Controls.Add(this.Verbindung1);
            this.Startseite.Controls.Add(this.panel15);
            this.Startseite.Controls.Add(this.panel14);
            this.Startseite.Controls.Add(this.panel13);
            this.Startseite.Controls.Add(this.TextEndStation);
            this.Startseite.Controls.Add(this.TextStartStation);
            this.Startseite.Controls.Add(this.Datumpicker);
            this.Startseite.Controls.Add(this.Losfahrenbt);
            this.Startseite.Controls.Add(this.Zeittb);
            this.Startseite.Location = new System.Drawing.Point(4, 24);
            this.Startseite.Name = "Startseite";
            this.Startseite.Padding = new System.Windows.Forms.Padding(3);
            this.Startseite.Size = new System.Drawing.Size(928, 632);
            this.Startseite.TabIndex = 0;
            this.Startseite.Text = "Startseite";
            this.Startseite.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::StationLocator.Properties.Resources.Only_Logo_transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(779, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 142);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel16.Location = new System.Drawing.Point(138, 188);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(113, 10);
            this.panel16.TabIndex = 18;
            this.panel16.Paint += new System.Windows.Forms.PaintEventHandler(this.panel16_Paint);
            // 
            // Verbindung4
            // 
            this.Verbindung4.AutoSize = true;
            this.Verbindung4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Verbindung4.Location = new System.Drawing.Point(138, 524);
            this.Verbindung4.Name = "Verbindung4";
            this.Verbindung4.Size = new System.Drawing.Size(130, 28);
            this.Verbindung4.TabIndex = 23;
            this.Verbindung4.Text = "Verbindung 4";
            // 
            // Verbindung3
            // 
            this.Verbindung3.AutoSize = true;
            this.Verbindung3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Verbindung3.Location = new System.Drawing.Point(138, 435);
            this.Verbindung3.Name = "Verbindung3";
            this.Verbindung3.Size = new System.Drawing.Size(130, 28);
            this.Verbindung3.TabIndex = 22;
            this.Verbindung3.Text = "Verbindung 3";
            // 
            // Verbindung2
            // 
            this.Verbindung2.AutoSize = true;
            this.Verbindung2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Verbindung2.Location = new System.Drawing.Point(138, 336);
            this.Verbindung2.Name = "Verbindung2";
            this.Verbindung2.Size = new System.Drawing.Size(130, 28);
            this.Verbindung2.TabIndex = 21;
            this.Verbindung2.Text = "Verbindung 2";
            // 
            // Verbindung1
            // 
            this.Verbindung1.AutoSize = true;
            this.Verbindung1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Verbindung1.Location = new System.Drawing.Point(138, 251);
            this.Verbindung1.Name = "Verbindung1";
            this.Verbindung1.Size = new System.Drawing.Size(130, 28);
            this.Verbindung1.TabIndex = 20;
            this.Verbindung1.Text = "Verbindung 1";
            this.Verbindung1.Click += new System.EventHandler(this.Verbindung1_Click);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel15.Location = new System.Drawing.Point(138, 586);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(635, 10);
            this.panel15.TabIndex = 19;
            this.panel15.Paint += new System.Windows.Forms.PaintEventHandler(this.panel15_Paint);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel14.Location = new System.Drawing.Point(567, 101);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(206, 11);
            this.panel14.TabIndex = 18;
            this.panel14.Paint += new System.Windows.Forms.PaintEventHandler(this.panel14_Paint);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel13.Location = new System.Drawing.Point(138, 101);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(206, 11);
            this.panel13.TabIndex = 17;
            this.panel13.Paint += new System.Windows.Forms.PaintEventHandler(this.panel13_Paint);
            // 
            // TextEndStation
            // 
            this.TextEndStation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextEndStation.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextEndStation.Location = new System.Drawing.Point(567, 48);
            this.TextEndStation.Multiline = true;
            this.TextEndStation.Name = "TextEndStation";
            this.TextEndStation.PlaceholderText = "Bis";
            this.TextEndStation.Size = new System.Drawing.Size(206, 47);
            this.TextEndStation.TabIndex = 10;
            // 
            // TextStartStation
            // 
            this.TextStartStation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextStartStation.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextStartStation.Location = new System.Drawing.Point(138, 48);
            this.TextStartStation.Multiline = true;
            this.TextStartStation.Name = "TextStartStation";
            this.TextStartStation.PlaceholderText = "Von";
            this.TextStartStation.Size = new System.Drawing.Size(206, 47);
            this.TextStartStation.TabIndex = 9;
            this.TextStartStation.TextChanged += new System.EventHandler(this.TextStartStation_TextChanged);
            // 
            // Datumpicker
            // 
            this.Datumpicker.Location = new System.Drawing.Point(287, 151);
            this.Datumpicker.Name = "Datumpicker";
            this.Datumpicker.Size = new System.Drawing.Size(200, 23);
            this.Datumpicker.TabIndex = 8;
            // 
            // Losfahrenbt
            // 
            this.Losfahrenbt.BackColor = System.Drawing.Color.Transparent;
            this.Losfahrenbt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Losfahrenbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Losfahrenbt.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Losfahrenbt.Location = new System.Drawing.Point(567, 132);
            this.Losfahrenbt.Name = "Losfahrenbt";
            this.Losfahrenbt.Size = new System.Drawing.Size(206, 50);
            this.Losfahrenbt.TabIndex = 4;
            this.Losfahrenbt.Text = "Losfahren";
            this.Losfahrenbt.UseVisualStyleBackColor = false;
            this.Losfahrenbt.Click += new System.EventHandler(this.Losfahrenbt_Click);
            // 
            // Zeittb
            // 
            this.Zeittb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Zeittb.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Zeittb.Location = new System.Drawing.Point(138, 147);
            this.Zeittb.Multiline = true;
            this.Zeittb.Name = "Zeittb";
            this.Zeittb.PlaceholderText = "Zeit";
            this.Zeittb.Size = new System.Drawing.Size(111, 35);
            this.Zeittb.TabIndex = 2;
            // 
            // Verbindungen
            // 
            this.Verbindungen.Controls.Add(this.pictureBox2);
            this.Verbindungen.Controls.Add(this.VerbindungenGrid);
            this.Verbindungen.Controls.Add(this.panel17);
            this.Verbindungen.Controls.Add(this.Stationsuchentb);
            this.Verbindungen.Controls.Add(this.Stationsuchenknopf);
            this.Verbindungen.Location = new System.Drawing.Point(4, 24);
            this.Verbindungen.Name = "Verbindungen";
            this.Verbindungen.Padding = new System.Windows.Forms.Padding(3);
            this.Verbindungen.Size = new System.Drawing.Size(928, 632);
            this.Verbindungen.TabIndex = 1;
            this.Verbindungen.Text = "Verbindungen";
            this.Verbindungen.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::StationLocator.Properties.Resources.Only_Logo_transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(779, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(164, 142);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // VerbindungenGrid
            // 
            this.VerbindungenGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.VerbindungenGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VerbindungenGrid.Location = new System.Drawing.Point(170, 258);
            this.VerbindungenGrid.Name = "VerbindungenGrid";
            this.VerbindungenGrid.RowTemplate.Height = 25;
            this.VerbindungenGrid.Size = new System.Drawing.Size(555, 314);
            this.VerbindungenGrid.TabIndex = 21;
            this.VerbindungenGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VerbindungenGrid_CellContentClick);
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel17.Location = new System.Drawing.Point(170, 172);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(237, 11);
            this.panel17.TabIndex = 20;
            // 
            // Stationsuchentb
            // 
            this.Stationsuchentb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Stationsuchentb.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Stationsuchentb.Location = new System.Drawing.Point(170, 78);
            this.Stationsuchentb.Multiline = true;
            this.Stationsuchentb.Name = "Stationsuchentb";
            this.Stationsuchentb.PlaceholderText = "Station";
            this.Stationsuchentb.Size = new System.Drawing.Size(237, 88);
            this.Stationsuchentb.TabIndex = 19;
            // 
            // Stationsuchenknopf
            // 
            this.Stationsuchenknopf.BackColor = System.Drawing.Color.Transparent;
            this.Stationsuchenknopf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Stationsuchenknopf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stationsuchenknopf.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Stationsuchenknopf.Location = new System.Drawing.Point(537, 91);
            this.Stationsuchenknopf.Name = "Stationsuchenknopf";
            this.Stationsuchenknopf.Size = new System.Drawing.Size(188, 64);
            this.Stationsuchenknopf.TabIndex = 18;
            this.Stationsuchenknopf.Text = "Verbindungen Suchen";
            this.Stationsuchenknopf.UseVisualStyleBackColor = false;
            this.Stationsuchenknopf.Click += new System.EventHandler(this.Stationsuchenknopf_Click);
            // 
            // HilfeundKontakt
            // 
            this.HilfeundKontakt.Controls.Add(this.pictureBox3);
            this.HilfeundKontakt.Controls.Add(this.Passwordtb);
            this.HilfeundKontakt.Controls.Add(this.Emailbt);
            this.HilfeundKontakt.Controls.Add(this.panel11);
            this.HilfeundKontakt.Controls.Add(this.panel10);
            this.HilfeundKontakt.Controls.Add(this.panel9);
            this.HilfeundKontakt.Controls.Add(this.panel8);
            this.HilfeundKontakt.Controls.Add(this.panel7);
            this.HilfeundKontakt.Controls.Add(this.panel6);
            this.HilfeundKontakt.Controls.Add(this.panel4);
            this.HilfeundKontakt.Controls.Add(this.Anliegentb);
            this.HilfeundKontakt.Controls.Add(this.Stadttb);
            this.HilfeundKontakt.Controls.Add(this.Strassetb);
            this.HilfeundKontakt.Controls.Add(this.Nachnametb);
            this.HilfeundKontakt.Controls.Add(this.Vornametb);
            this.HilfeundKontakt.Controls.Add(this.HostEmailtb);
            this.HilfeundKontakt.Controls.Add(this.Anredetb);
            this.HilfeundKontakt.Controls.Add(this.Betrefftb);
            this.HilfeundKontakt.Controls.Add(this.Firmatb);
            this.HilfeundKontakt.Location = new System.Drawing.Point(4, 24);
            this.HilfeundKontakt.Name = "HilfeundKontakt";
            this.HilfeundKontakt.Size = new System.Drawing.Size(928, 632);
            this.HilfeundKontakt.TabIndex = 5;
            this.HilfeundKontakt.Text = "Hilfe & Kontakt";
            this.HilfeundKontakt.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::StationLocator.Properties.Resources.Only_Logo_transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(793, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 131);
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // Passwordtb
            // 
            this.Passwordtb.Location = new System.Drawing.Point(537, 176);
            this.Passwordtb.Multiline = true;
            this.Passwordtb.Name = "Passwordtb";
            this.Passwordtb.PasswordChar = '*';
            this.Passwordtb.PlaceholderText = "Ihr E-Mail Passwort";
            this.Passwordtb.Size = new System.Drawing.Size(250, 33);
            this.Passwordtb.TabIndex = 20;
            this.Passwordtb.TextChanged += new System.EventHandler(this.Passwordtb_TextChanged);
            // 
            // Emailbt
            // 
            this.Emailbt.BackColor = System.Drawing.Color.Transparent;
            this.Emailbt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Emailbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Emailbt.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Emailbt.Location = new System.Drawing.Point(126, 521);
            this.Emailbt.Name = "Emailbt";
            this.Emailbt.Size = new System.Drawing.Size(662, 64);
            this.Emailbt.TabIndex = 19;
            this.Emailbt.Text = "E-Mail Senden";
            this.Emailbt.UseVisualStyleBackColor = false;
            this.Emailbt.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel11.Location = new System.Drawing.Point(126, 481);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(662, 10);
            this.panel11.TabIndex = 17;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel10.Location = new System.Drawing.Point(126, 115);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(662, 10);
            this.panel10.TabIndex = 16;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel9.Location = new System.Drawing.Point(537, 340);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(251, 10);
            this.panel9.TabIndex = 12;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel8.Location = new System.Drawing.Point(126, 340);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(251, 10);
            this.panel8.TabIndex = 15;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel7.Location = new System.Drawing.Point(537, 254);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(251, 10);
            this.panel7.TabIndex = 14;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel6.Location = new System.Drawing.Point(126, 254);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(251, 10);
            this.panel6.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(126, 178);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(251, 10);
            this.panel4.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(251, 10);
            this.panel5.TabIndex = 12;
            // 
            // Anliegentb
            // 
            this.Anliegentb.Location = new System.Drawing.Point(126, 405);
            this.Anliegentb.Multiline = true;
            this.Anliegentb.Name = "Anliegentb";
            this.Anliegentb.PlaceholderText = "Anliegen";
            this.Anliegentb.Size = new System.Drawing.Size(661, 70);
            this.Anliegentb.TabIndex = 8;
            // 
            // Stadttb
            // 
            this.Stadttb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Stadttb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.Stadttb.Location = new System.Drawing.Point(537, 301);
            this.Stadttb.Multiline = true;
            this.Stadttb.Name = "Stadttb";
            this.Stadttb.PlaceholderText = "Stadt";
            this.Stadttb.Size = new System.Drawing.Size(250, 33);
            this.Stadttb.TabIndex = 7;
            // 
            // Strassetb
            // 
            this.Strassetb.Location = new System.Drawing.Point(126, 301);
            this.Strassetb.Multiline = true;
            this.Strassetb.Name = "Strassetb";
            this.Strassetb.PlaceholderText = "Strasse";
            this.Strassetb.Size = new System.Drawing.Size(250, 33);
            this.Strassetb.TabIndex = 6;
            // 
            // Nachnametb
            // 
            this.Nachnametb.Location = new System.Drawing.Point(537, 215);
            this.Nachnametb.Multiline = true;
            this.Nachnametb.Name = "Nachnametb";
            this.Nachnametb.PlaceholderText = "Nachname";
            this.Nachnametb.Size = new System.Drawing.Size(250, 33);
            this.Nachnametb.TabIndex = 5;
            // 
            // Vornametb
            // 
            this.Vornametb.Location = new System.Drawing.Point(126, 215);
            this.Vornametb.Multiline = true;
            this.Vornametb.Name = "Vornametb";
            this.Vornametb.PlaceholderText = "Vorname";
            this.Vornametb.Size = new System.Drawing.Size(250, 33);
            this.Vornametb.TabIndex = 4;
            // 
            // HostEmailtb
            // 
            this.HostEmailtb.Location = new System.Drawing.Point(537, 139);
            this.HostEmailtb.Multiline = true;
            this.HostEmailtb.Name = "HostEmailtb";
            this.HostEmailtb.PlaceholderText = "Ihre Outlook E-Mail";
            this.HostEmailtb.Size = new System.Drawing.Size(250, 33);
            this.HostEmailtb.TabIndex = 3;
            // 
            // Anredetb
            // 
            this.Anredetb.Location = new System.Drawing.Point(126, 139);
            this.Anredetb.Multiline = true;
            this.Anredetb.Name = "Anredetb";
            this.Anredetb.PlaceholderText = "Anrede";
            this.Anredetb.Size = new System.Drawing.Size(250, 33);
            this.Anredetb.TabIndex = 2;
            // 
            // Betrefftb
            // 
            this.Betrefftb.Location = new System.Drawing.Point(126, 366);
            this.Betrefftb.Multiline = true;
            this.Betrefftb.Name = "Betrefftb";
            this.Betrefftb.PlaceholderText = "Betreff";
            this.Betrefftb.Size = new System.Drawing.Size(661, 33);
            this.Betrefftb.TabIndex = 1;
            // 
            // Firmatb
            // 
            this.Firmatb.Location = new System.Drawing.Point(126, 76);
            this.Firmatb.Multiline = true;
            this.Firmatb.Name = "Firmatb";
            this.Firmatb.PlaceholderText = "Firma";
            this.Firmatb.Size = new System.Drawing.Size(661, 33);
            this.Firmatb.TabIndex = 0;
            // 
            // Optionen
            // 
            this.Optionen.Controls.Add(this.pictureBox4);
            this.Optionen.Controls.Add(this.button4);
            this.Optionen.Controls.Add(this.button3);
            this.Optionen.Controls.Add(this.button2);
            this.Optionen.Controls.Add(this.label1);
            this.Optionen.Controls.Add(this.button1);
            this.Optionen.Location = new System.Drawing.Point(4, 24);
            this.Optionen.Name = "Optionen";
            this.Optionen.Size = new System.Drawing.Size(928, 632);
            this.Optionen.TabIndex = 2;
            this.Optionen.Text = "Optionen";
            this.Optionen.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::StationLocator.Properties.Resources.Only_Logo_transparent;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(779, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(164, 142);
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Cyan;
            this.button4.Location = new System.Drawing.Point(103, 501);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(662, 64);
            this.button4.TabIndex = 24;
            this.button4.Text = "Cyan";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button3.Location = new System.Drawing.Point(103, 165);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(662, 64);
            this.button3.TabIndex = 23;
            this.button3.Text = "Blau";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.ForestGreen;
            this.button2.Location = new System.Drawing.Point(103, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(662, 64);
            this.button2.TabIndex = 22;
            this.button2.Text = "Grün";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(354, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 28);
            this.label1.TabIndex = 21;
            this.label1.Text = "Farben Umstellen";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(103, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(662, 64);
            this.button1.TabIndex = 20;
            this.button1.Text = "Rot";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 653);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Startseite.ResumeLayout(false);
            this.Startseite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Verbindungen.ResumeLayout(false);
            this.Verbindungen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VerbindungenGrid)).EndInit();
            this.HilfeundKontakt.ResumeLayout(false);
            this.HilfeundKontakt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.Optionen.ResumeLayout(false);
            this.Optionen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private TabControl tabControl1;
    private TabPage Startseite;
    private Button Losfahrenbt;
    private TextBox Zeittb;
    private TabPage Verbindungen;
    private TabPage HilfeundKontakt;
    private TabPage Optionen;
    private TextBox Anliegentb;
    private TextBox Stadttb;
    private TextBox Strassetb;
    private TextBox Nachnametb;
    private TextBox Vornametb;
    private TextBox HostEmailtb;
    private TextBox Anredetb;
    private TextBox Betrefftb;
    private TextBox Firmatb;
    private Panel panel11;
    private Panel panel10;
    private Panel panel9;
    private Panel panel8;
    private Panel panel7;
    private Panel panel6;
    private Panel panel4;
    private Panel panel5;
    private TextBox TextEndStation;
    private TextBox TextStartStation;
    private DateTimePicker Datumpicker;
    private Panel panel14;
    private Panel panel13;
    private Panel panel15;
    private Label Verbindung1;
    private Label Verbindung4;
    private Label Verbindung3;
    private Label Verbindung2;
    private Panel panel16;
    private DataGridView VerbindungenGrid;
    private Panel panel17;
    private TextBox Stationsuchentb;
    private Button Stationsuchenknopf;
    private Button Emailbt;
    private TextBox Passwordtb;
    private Button button1;
    private Label label1;
    private Button button2;
    private Button button3;
    private Button button4;
    private PictureBox pictureBox1;
    private PictureBox pictureBox2;
    private PictureBox pictureBox3;
    private PictureBox pictureBox4;
}
