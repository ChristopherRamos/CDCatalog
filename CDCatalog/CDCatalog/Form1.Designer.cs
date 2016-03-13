namespace CDCatalog
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.btnAddCD = new System.Windows.Forms.Button();
            this.buttonRate = new System.Windows.Forms.Button();
            this.textBoxAddSongTitle = new System.Windows.Forms.TextBox();
            this.comboBoxAddSongGenre = new System.Windows.Forms.ComboBox();
            this.genreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDownAddSongTrackLength = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxAddCDTitle = new System.Windows.Forms.TextBox();
            this.comboBoxRateSongorCD = new System.Windows.Forms.ComboBox();
            this.numericUpDownRateSongCD = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxFindKeywordSearch = new System.Windows.Forms.TextBox();
            this.radioButtonFindTitle = new System.Windows.Forms.RadioButton();
            this.radioButtonFindArtist = new System.Windows.Forms.RadioButton();
            this.radioButtonFindGenre = new System.Windows.Forms.RadioButton();
            this.btnFind = new System.Windows.Forms.Button();
            this.listViewFind = new System.Windows.Forms.ListView();
            this.button6 = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.label19 = new System.Windows.Forms.Label();
            this.labelAddSongTrackNumber = new System.Windows.Forms.Label();
            this.numericUpDownAddSongTrackNumber = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAddCDYear = new System.Windows.Forms.NumericUpDown();
            this.labelAddCDYear = new System.Windows.Forms.Label();
            this.btnAddArtist = new System.Windows.Forms.Button();
            this.textBoxAddArtist = new System.Windows.Forms.TextBox();
            this.textBoxAddGenre = new System.Windows.Forms.TextBox();
            this.buttonAddGenre = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxAddSongAlbum = new System.Windows.Forms.ComboBox();
            this.comboBoxAddSongArtist = new System.Windows.Forms.ComboBox();
            this.comboBoxAddCDArtist = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddSongTrackLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRateSongCD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddSongTrackNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddCDYear)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add a new Song";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Add a new CD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rate a specific Song or CD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Find a song or CD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 436);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Create a Playlist for a specific time";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(18, 452);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(36, 20);
            this.numericUpDown1.TabIndex = 5;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(94, 452);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(56, 20);
            this.numericUpDown2.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 457);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "mins";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 457);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "seconds";
            // 
            // btnAddSong
            // 
            this.btnAddSong.Location = new System.Drawing.Point(975, 23);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(75, 23);
            this.btnAddSong.TabIndex = 9;
            this.btnAddSong.Text = "Add Song";
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // btnAddCD
            // 
            this.btnAddCD.Location = new System.Drawing.Point(428, 96);
            this.btnAddCD.Name = "btnAddCD";
            this.btnAddCD.Size = new System.Drawing.Size(75, 23);
            this.btnAddCD.TabIndex = 10;
            this.btnAddCD.Text = "Add CD";
            this.btnAddCD.UseVisualStyleBackColor = true;
            this.btnAddCD.Click += new System.EventHandler(this.btnAddCD_Click);
            // 
            // buttonRate
            // 
            this.buttonRate.Location = new System.Drawing.Point(498, 156);
            this.buttonRate.Name = "buttonRate";
            this.buttonRate.Size = new System.Drawing.Size(75, 23);
            this.buttonRate.TabIndex = 12;
            this.buttonRate.Text = "Rate";
            this.buttonRate.UseVisualStyleBackColor = true;
            this.buttonRate.Click += new System.EventHandler(this.buttonRate_Click);
            // 
            // textBoxAddSongTitle
            // 
            this.textBoxAddSongTitle.Location = new System.Drawing.Point(12, 25);
            this.textBoxAddSongTitle.Name = "textBoxAddSongTitle";
            this.textBoxAddSongTitle.Size = new System.Drawing.Size(80, 20);
            this.textBoxAddSongTitle.TabIndex = 14;
            this.textBoxAddSongTitle.Text = "Title";
            // 
            // comboBoxAddSongGenre
            // 
            this.comboBoxAddSongGenre.DisplayMember = "ID";
            this.comboBoxAddSongGenre.FormattingEnabled = true;
            this.comboBoxAddSongGenre.Location = new System.Drawing.Point(470, 19);
            this.comboBoxAddSongGenre.Name = "comboBoxAddSongGenre";
            this.comboBoxAddSongGenre.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAddSongGenre.TabIndex = 18;
            this.comboBoxAddSongGenre.ValueMember = "ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(893, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "seconds";
            // 
            // numericUpDownAddSongTrackLength
            // 
            this.numericUpDownAddSongTrackLength.Location = new System.Drawing.Point(811, 25);
            this.numericUpDownAddSongTrackLength.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.numericUpDownAddSongTrackLength.Name = "numericUpDownAddSongTrackLength";
            this.numericUpDownAddSongTrackLength.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownAddSongTrackLength.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(720, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Track Length";
            // 
            // textBoxAddCDTitle
            // 
            this.textBoxAddCDTitle.Location = new System.Drawing.Point(15, 96);
            this.textBoxAddCDTitle.Name = "textBoxAddCDTitle";
            this.textBoxAddCDTitle.Size = new System.Drawing.Size(80, 20);
            this.textBoxAddCDTitle.TabIndex = 27;
            this.textBoxAddCDTitle.Text = "Title";
            // 
            // comboBoxRateSongorCD
            // 
            this.comboBoxRateSongorCD.FormattingEnabled = true;
            this.comboBoxRateSongorCD.Location = new System.Drawing.Point(15, 161);
            this.comboBoxRateSongorCD.Name = "comboBoxRateSongorCD";
            this.comboBoxRateSongorCD.Size = new System.Drawing.Size(294, 21);
            this.comboBoxRateSongorCD.TabIndex = 33;
            // 
            // numericUpDownRateSongCD
            // 
            this.numericUpDownRateSongCD.Location = new System.Drawing.Point(418, 159);
            this.numericUpDownRateSongCD.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownRateSongCD.Name = "numericUpDownRateSongCD";
            this.numericUpDownRateSongCD.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownRateSongCD.TabIndex = 36;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(374, 182);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "(1=Lowest : 5= Highest)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(374, 161);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Rating";
            // 
            // textBoxFindKeywordSearch
            // 
            this.textBoxFindKeywordSearch.Location = new System.Drawing.Point(16, 269);
            this.textBoxFindKeywordSearch.Name = "textBoxFindKeywordSearch";
            this.textBoxFindKeywordSearch.Size = new System.Drawing.Size(183, 20);
            this.textBoxFindKeywordSearch.TabIndex = 42;
            this.textBoxFindKeywordSearch.Text = "Keyword Search";
            // 
            // radioButtonFindTitle
            // 
            this.radioButtonFindTitle.AutoSize = true;
            this.radioButtonFindTitle.Location = new System.Drawing.Point(207, 266);
            this.radioButtonFindTitle.Name = "radioButtonFindTitle";
            this.radioButtonFindTitle.Size = new System.Drawing.Size(45, 17);
            this.radioButtonFindTitle.TabIndex = 43;
            this.radioButtonFindTitle.TabStop = true;
            this.radioButtonFindTitle.Text = "Title";
            this.radioButtonFindTitle.UseVisualStyleBackColor = true;
            // 
            // radioButtonFindArtist
            // 
            this.radioButtonFindArtist.AutoSize = true;
            this.radioButtonFindArtist.Location = new System.Drawing.Point(261, 266);
            this.radioButtonFindArtist.Name = "radioButtonFindArtist";
            this.radioButtonFindArtist.Size = new System.Drawing.Size(48, 17);
            this.radioButtonFindArtist.TabIndex = 44;
            this.radioButtonFindArtist.TabStop = true;
            this.radioButtonFindArtist.Text = "Artist";
            this.radioButtonFindArtist.UseVisualStyleBackColor = true;
            // 
            // radioButtonFindGenre
            // 
            this.radioButtonFindGenre.AutoSize = true;
            this.radioButtonFindGenre.Location = new System.Drawing.Point(315, 266);
            this.radioButtonFindGenre.Name = "radioButtonFindGenre";
            this.radioButtonFindGenre.Size = new System.Drawing.Size(54, 17);
            this.radioButtonFindGenre.TabIndex = 45;
            this.radioButtonFindGenre.TabStop = true;
            this.radioButtonFindGenre.Text = "Genre";
            this.radioButtonFindGenre.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(391, 263);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 46;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // listViewFind
            // 
            this.listViewFind.Location = new System.Drawing.Point(16, 295);
            this.listViewFind.Name = "listViewFind";
            this.listViewFind.Size = new System.Drawing.Size(450, 127);
            this.listViewFind.TabIndex = 47;
            this.listViewFind.UseCompatibleStateImageBehavior = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(386, 452);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 48;
            this.button6.Text = "Create";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(16, 488);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(450, 97);
            this.listView2.TabIndex = 49;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(428, 19);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(36, 13);
            this.label19.TabIndex = 50;
            this.label19.Text = "Genre";
            // 
            // labelAddSongTrackNumber
            // 
            this.labelAddSongTrackNumber.AutoSize = true;
            this.labelAddSongTrackNumber.Location = new System.Drawing.Point(597, 23);
            this.labelAddSongTrackNumber.Name = "labelAddSongTrackNumber";
            this.labelAddSongTrackNumber.Size = new System.Drawing.Size(75, 13);
            this.labelAddSongTrackNumber.TabIndex = 51;
            this.labelAddSongTrackNumber.Text = "Track Number";
            // 
            // numericUpDownAddSongTrackNumber
            // 
            this.numericUpDownAddSongTrackNumber.Location = new System.Drawing.Point(678, 25);
            this.numericUpDownAddSongTrackNumber.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.numericUpDownAddSongTrackNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAddSongTrackNumber.Name = "numericUpDownAddSongTrackNumber";
            this.numericUpDownAddSongTrackNumber.Size = new System.Drawing.Size(36, 20);
            this.numericUpDownAddSongTrackNumber.TabIndex = 52;
            this.numericUpDownAddSongTrackNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownAddCDYear
            // 
            this.numericUpDownAddCDYear.Location = new System.Drawing.Point(369, 96);
            this.numericUpDownAddCDYear.Maximum = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            this.numericUpDownAddCDYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDownAddCDYear.Name = "numericUpDownAddCDYear";
            this.numericUpDownAddCDYear.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownAddCDYear.TabIndex = 53;
            this.numericUpDownAddCDYear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // labelAddCDYear
            // 
            this.labelAddCDYear.AutoSize = true;
            this.labelAddCDYear.Location = new System.Drawing.Point(321, 101);
            this.labelAddCDYear.Name = "labelAddCDYear";
            this.labelAddCDYear.Size = new System.Drawing.Size(29, 13);
            this.labelAddCDYear.TabIndex = 54;
            this.labelAddCDYear.Text = "Year";
            // 
            // btnAddArtist
            // 
            this.btnAddArtist.Location = new System.Drawing.Point(762, 85);
            this.btnAddArtist.Name = "btnAddArtist";
            this.btnAddArtist.Size = new System.Drawing.Size(75, 23);
            this.btnAddArtist.TabIndex = 55;
            this.btnAddArtist.Text = "Add Artist";
            this.btnAddArtist.UseVisualStyleBackColor = true;
            this.btnAddArtist.Click += new System.EventHandler(this.btnAddArtist_Click);
            // 
            // textBoxAddArtist
            // 
            this.textBoxAddArtist.Location = new System.Drawing.Point(643, 87);
            this.textBoxAddArtist.Name = "textBoxAddArtist";
            this.textBoxAddArtist.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddArtist.TabIndex = 56;
            // 
            // textBoxAddGenre
            // 
            this.textBoxAddGenre.Location = new System.Drawing.Point(643, 125);
            this.textBoxAddGenre.Name = "textBoxAddGenre";
            this.textBoxAddGenre.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddGenre.TabIndex = 58;
            // 
            // buttonAddGenre
            // 
            this.buttonAddGenre.Location = new System.Drawing.Point(762, 123);
            this.buttonAddGenre.Name = "buttonAddGenre";
            this.buttonAddGenre.Size = new System.Drawing.Size(75, 23);
            this.buttonAddGenre.TabIndex = 57;
            this.buttonAddGenre.Text = "Add Genre";
            this.buttonAddGenre.UseVisualStyleBackColor = true;
            this.buttonAddGenre.Click += new System.EventHandler(this.buttonAddGenre_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(273, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "Album";
            // 
            // comboBoxAddSongAlbum
            // 
            this.comboBoxAddSongAlbum.DisplayMember = "ID";
            this.comboBoxAddSongAlbum.FormattingEnabled = true;
            this.comboBoxAddSongAlbum.Location = new System.Drawing.Point(300, 28);
            this.comboBoxAddSongAlbum.Name = "comboBoxAddSongAlbum";
            this.comboBoxAddSongAlbum.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAddSongAlbum.TabIndex = 60;
            this.comboBoxAddSongAlbum.ValueMember = "ID";
            // 
            // comboBoxAddSongArtist
            // 
            this.comboBoxAddSongArtist.DisplayMember = "ID";
            this.comboBoxAddSongArtist.FormattingEnabled = true;
            this.comboBoxAddSongArtist.Location = new System.Drawing.Point(159, 28);
            this.comboBoxAddSongArtist.Name = "comboBoxAddSongArtist";
            this.comboBoxAddSongArtist.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAddSongArtist.TabIndex = 61;
            this.comboBoxAddSongArtist.ValueMember = "ID";
            // 
            // comboBoxAddCDArtist
            // 
            this.comboBoxAddCDArtist.DisplayMember = "ID";
            this.comboBoxAddCDArtist.FormattingEnabled = true;
            this.comboBoxAddCDArtist.Location = new System.Drawing.Point(169, 95);
            this.comboBoxAddCDArtist.Name = "comboBoxAddCDArtist";
            this.comboBoxAddCDArtist.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAddCDArtist.TabIndex = 62;
            this.comboBoxAddCDArtist.ValueMember = "ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(133, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 63;
            this.label9.Text = "Artist";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(133, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 64;
            this.label10.Text = "Artist";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 612);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxAddCDArtist);
            this.Controls.Add(this.comboBoxAddSongArtist);
            this.Controls.Add(this.comboBoxAddSongAlbum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxAddGenre);
            this.Controls.Add(this.buttonAddGenre);
            this.Controls.Add(this.textBoxAddArtist);
            this.Controls.Add(this.btnAddArtist);
            this.Controls.Add(this.labelAddCDYear);
            this.Controls.Add(this.numericUpDownAddCDYear);
            this.Controls.Add(this.numericUpDownAddSongTrackNumber);
            this.Controls.Add(this.labelAddSongTrackNumber);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.listViewFind);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.radioButtonFindGenre);
            this.Controls.Add(this.radioButtonFindArtist);
            this.Controls.Add(this.radioButtonFindTitle);
            this.Controls.Add(this.textBoxFindKeywordSearch);
            this.Controls.Add(this.numericUpDownRateSongCD);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.comboBoxRateSongorCD);
            this.Controls.Add(this.textBoxAddCDTitle);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numericUpDownAddSongTrackLength);
            this.Controls.Add(this.comboBoxAddSongGenre);
            this.Controls.Add(this.textBoxAddSongTitle);
            this.Controls.Add(this.buttonRate);
            this.Controls.Add(this.btnAddCD);
            this.Controls.Add(this.btnAddSong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Compact Disc Catalog";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddSongTrackLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRateSongCD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddSongTrackNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddCDYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.Button btnAddCD;
        private System.Windows.Forms.Button buttonRate;
        private System.Windows.Forms.TextBox textBoxAddSongTitle;
        private System.Windows.Forms.ComboBox comboBoxAddSongGenre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDownAddSongTrackLength;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxAddCDTitle;
        private System.Windows.Forms.ComboBox comboBoxRateSongorCD;
        private System.Windows.Forms.NumericUpDown numericUpDownRateSongCD;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxFindKeywordSearch;
        private System.Windows.Forms.RadioButton radioButtonFindTitle;
        private System.Windows.Forms.RadioButton radioButtonFindArtist;
        private System.Windows.Forms.RadioButton radioButtonFindGenre;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ListView listViewFind;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label labelAddSongTrackNumber;
        private System.Windows.Forms.NumericUpDown numericUpDownAddSongTrackNumber;
        private System.Windows.Forms.NumericUpDown numericUpDownAddCDYear;
        private System.Windows.Forms.Label labelAddCDYear;
        private System.Windows.Forms.Button btnAddArtist;
        private System.Windows.Forms.TextBox textBoxAddArtist;
        private System.Windows.Forms.TextBox textBoxAddGenre;
        private System.Windows.Forms.Button buttonAddGenre;
        private System.Windows.Forms.BindingSource genreBindingSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxAddSongAlbum;
        private System.Windows.Forms.ComboBox comboBoxAddSongArtist;
        private System.Windows.Forms.ComboBox comboBoxAddCDArtist;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

