namespace CDCatalog
{
    partial class MainForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownCreatePlaylist = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonRate = new System.Windows.Forms.Button();
            this.comboBoxRateSongorCD = new System.Windows.Forms.ComboBox();
            this.numericUpDownRateSongCD = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxFindKeywordSearch = new System.Windows.Forms.TextBox();
            this.radioButtonFindTitle = new System.Windows.Forms.RadioButton();
            this.radioButtonFindArtist = new System.Windows.Forms.RadioButton();
            this.radioButtonFindGenre = new System.Windows.Forms.RadioButton();
            this.btnFind = new System.Windows.Forms.Button();
            this.buttonCreatePlaylist = new System.Windows.Forms.Button();
            this.btnAddArtist = new System.Windows.Forms.Button();
            this.textBoxAddArtist = new System.Windows.Forms.TextBox();
            this.textBoxAddGenre = new System.Windows.Forms.TextBox();
            this.buttonAddGenre = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridViewFindSongCD = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBoxFindSongCD = new System.Windows.Forms.GroupBox();
            this.dataGridViewDetails = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridViewPlaylist = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.songToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.songToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.byArtistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.genreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCreatePlaylist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRateSongCD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFindSongCD)).BeginInit();
            this.groupBoxFindSongCD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaylist)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rate a specific Song or CD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(766, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Find a song or CD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(767, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Create a Playlist for a specific time";
            // 
            // numericUpDownCreatePlaylist
            // 
            this.numericUpDownCreatePlaylist.Location = new System.Drawing.Point(18, 452);
            this.numericUpDownCreatePlaylist.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.numericUpDownCreatePlaylist.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCreatePlaylist.Name = "numericUpDownCreatePlaylist";
            this.numericUpDownCreatePlaylist.Size = new System.Drawing.Size(36, 20);
            this.numericUpDownCreatePlaylist.TabIndex = 5;
            this.numericUpDownCreatePlaylist.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            // buttonRate
            // 
            this.buttonRate.Location = new System.Drawing.Point(600, 401);
            this.buttonRate.Name = "buttonRate";
            this.buttonRate.Size = new System.Drawing.Size(75, 23);
            this.buttonRate.TabIndex = 12;
            this.buttonRate.Text = "Rate";
            this.buttonRate.UseVisualStyleBackColor = true;
            this.buttonRate.Click += new System.EventHandler(this.buttonRate_Click);
            // 
            // comboBoxRateSongorCD
            // 
            this.comboBoxRateSongorCD.FormattingEnabled = true;
            this.comboBoxRateSongorCD.Location = new System.Drawing.Point(117, 406);
            this.comboBoxRateSongorCD.Name = "comboBoxRateSongorCD";
            this.comboBoxRateSongorCD.Size = new System.Drawing.Size(294, 21);
            this.comboBoxRateSongorCD.TabIndex = 33;
            // 
            // numericUpDownRateSongCD
            // 
            this.numericUpDownRateSongCD.Location = new System.Drawing.Point(520, 404);
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
            this.label16.Location = new System.Drawing.Point(476, 427);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "(1=Lowest : 5= Highest)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(476, 406);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Rating";
            // 
            // textBoxFindKeywordSearch
            // 
            this.textBoxFindKeywordSearch.Location = new System.Drawing.Point(770, 77);
            this.textBoxFindKeywordSearch.Name = "textBoxFindKeywordSearch";
            this.textBoxFindKeywordSearch.Size = new System.Drawing.Size(183, 20);
            this.textBoxFindKeywordSearch.TabIndex = 42;
            this.textBoxFindKeywordSearch.Text = "Keyword Search";
            // 
            // radioButtonFindTitle
            // 
            this.radioButtonFindTitle.AutoSize = true;
            this.radioButtonFindTitle.Checked = true;
            this.radioButtonFindTitle.Location = new System.Drawing.Point(961, 74);
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
            this.radioButtonFindArtist.Location = new System.Drawing.Point(1015, 74);
            this.radioButtonFindArtist.Name = "radioButtonFindArtist";
            this.radioButtonFindArtist.Size = new System.Drawing.Size(48, 17);
            this.radioButtonFindArtist.TabIndex = 44;
            this.radioButtonFindArtist.Text = "Artist";
            this.radioButtonFindArtist.UseVisualStyleBackColor = true;
            // 
            // radioButtonFindGenre
            // 
            this.radioButtonFindGenre.AutoSize = true;
            this.radioButtonFindGenre.Location = new System.Drawing.Point(1069, 74);
            this.radioButtonFindGenre.Name = "radioButtonFindGenre";
            this.radioButtonFindGenre.Size = new System.Drawing.Size(54, 17);
            this.radioButtonFindGenre.TabIndex = 45;
            this.radioButtonFindGenre.Text = "Genre";
            this.radioButtonFindGenre.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(1145, 71);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 46;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // buttonCreatePlaylist
            // 
            this.buttonCreatePlaylist.Location = new System.Drawing.Point(386, 447);
            this.buttonCreatePlaylist.Name = "buttonCreatePlaylist";
            this.buttonCreatePlaylist.Size = new System.Drawing.Size(75, 23);
            this.buttonCreatePlaylist.TabIndex = 48;
            this.buttonCreatePlaylist.Text = "Create";
            this.buttonCreatePlaylist.UseVisualStyleBackColor = true;
            this.buttonCreatePlaylist.Click += new System.EventHandler(this.buttonCreatePlaylist_Click);
            // 
            // btnAddArtist
            // 
            this.btnAddArtist.Location = new System.Drawing.Point(672, 524);
            this.btnAddArtist.Name = "btnAddArtist";
            this.btnAddArtist.Size = new System.Drawing.Size(75, 23);
            this.btnAddArtist.TabIndex = 55;
            this.btnAddArtist.Text = "Add Artist";
            this.btnAddArtist.UseVisualStyleBackColor = true;
            this.btnAddArtist.Click += new System.EventHandler(this.btnAddArtist_Click);
            // 
            // textBoxAddArtist
            // 
            this.textBoxAddArtist.Location = new System.Drawing.Point(553, 526);
            this.textBoxAddArtist.Name = "textBoxAddArtist";
            this.textBoxAddArtist.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddArtist.TabIndex = 56;
            // 
            // textBoxAddGenre
            // 
            this.textBoxAddGenre.Location = new System.Drawing.Point(553, 564);
            this.textBoxAddGenre.Name = "textBoxAddGenre";
            this.textBoxAddGenre.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddGenre.TabIndex = 58;
            // 
            // buttonAddGenre
            // 
            this.buttonAddGenre.Location = new System.Drawing.Point(672, 562);
            this.buttonAddGenre.Name = "buttonAddGenre";
            this.buttonAddGenre.Size = new System.Drawing.Size(75, 23);
            this.buttonAddGenre.TabIndex = 57;
            this.buttonAddGenre.Text = "Add Genre";
            this.buttonAddGenre.UseVisualStyleBackColor = true;
            this.buttonAddGenre.Click += new System.EventHandler(this.buttonAddGenre_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(772, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(235, 13);
            this.label12.TabIndex = 65;
            this.label12.Text = "Click on any of the results above for more details";
            // 
            // dataGridViewFindSongCD
            // 
            this.dataGridViewFindSongCD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFindSongCD.Location = new System.Drawing.Point(769, 104);
            this.dataGridViewFindSongCD.Name = "dataGridViewFindSongCD";
            this.dataGridViewFindSongCD.RowHeadersVisible = false;
            this.dataGridViewFindSongCD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFindSongCD.Size = new System.Drawing.Size(451, 137);
            this.dataGridViewFindSongCD.TabIndex = 66;
            this.dataGridViewFindSongCD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFindSongCD_CellContentClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 67;
            this.label14.Text = "label14";
            // 
            // groupBoxFindSongCD
            // 
            this.groupBoxFindSongCD.Controls.Add(this.dataGridViewDetails);
            this.groupBoxFindSongCD.Controls.Add(this.label15);
            this.groupBoxFindSongCD.Controls.Add(this.label14);
            this.groupBoxFindSongCD.Location = new System.Drawing.Point(770, 296);
            this.groupBoxFindSongCD.Name = "groupBoxFindSongCD";
            this.groupBoxFindSongCD.Size = new System.Drawing.Size(451, 289);
            this.groupBoxFindSongCD.TabIndex = 68;
            this.groupBoxFindSongCD.TabStop = false;
            this.groupBoxFindSongCD.Text = "groupBox1";
            // 
            // dataGridViewDetails
            // 
            this.dataGridViewDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetails.Location = new System.Drawing.Point(9, 108);
            this.dataGridViewDetails.Name = "dataGridViewDetails";
            this.dataGridViewDetails.RowHeadersVisible = false;
            this.dataGridViewDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDetails.Size = new System.Drawing.Size(436, 175);
            this.dataGridViewDetails.TabIndex = 75;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 51);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 68;
            this.label15.Text = "label15";
            // 
            // dataGridViewPlaylist
            // 
            this.dataGridViewPlaylist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlaylist.Location = new System.Drawing.Point(12, 478);
            this.dataGridViewPlaylist.Name = "dataGridViewPlaylist";
            this.dataGridViewPlaylist.RowHeadersVisible = false;
            this.dataGridViewPlaylist.Size = new System.Drawing.Size(454, 124);
            this.dataGridViewPlaylist.TabIndex = 69;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.rateToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1246, 24);
            this.menuStrip1.TabIndex = 70;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.albumToolStripMenuItem,
            this.artistToolStripMenuItem,
            this.genreToolStripMenuItem,
            this.songToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // albumToolStripMenuItem
            // 
            this.albumToolStripMenuItem.Name = "albumToolStripMenuItem";
            this.albumToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.albumToolStripMenuItem.Text = "Album";
            this.albumToolStripMenuItem.Click += new System.EventHandler(this.albumToolStripMenuItem_Click);
            // 
            // artistToolStripMenuItem
            // 
            this.artistToolStripMenuItem.Name = "artistToolStripMenuItem";
            this.artistToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.artistToolStripMenuItem.Text = "Artist";
            // 
            // genreToolStripMenuItem
            // 
            this.genreToolStripMenuItem.Name = "genreToolStripMenuItem";
            this.genreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.genreToolStripMenuItem.Text = "Genre";
            // 
            // songToolStripMenuItem
            // 
            this.songToolStripMenuItem.Name = "songToolStripMenuItem";
            this.songToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.songToolStripMenuItem.Text = "Song";
            this.songToolStripMenuItem.Click += new System.EventHandler(this.songToolStripMenuItem_Click);
            // 
            // rateToolStripMenuItem
            // 
            this.rateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.albumToolStripMenuItem1,
            this.songToolStripMenuItem1});
            this.rateToolStripMenuItem.Name = "rateToolStripMenuItem";
            this.rateToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.rateToolStripMenuItem.Text = "Rate";
            // 
            // albumToolStripMenuItem1
            // 
            this.albumToolStripMenuItem1.Name = "albumToolStripMenuItem1";
            this.albumToolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
            this.albumToolStripMenuItem1.Text = "Album";
            // 
            // songToolStripMenuItem1
            // 
            this.songToolStripMenuItem1.Name = "songToolStripMenuItem1";
            this.songToolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
            this.songToolStripMenuItem1.Text = "Song";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.albumToolStripMenuItem2,
            this.byArtistToolStripMenuItem,
            this.genreToolStripMenuItem1});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // albumToolStripMenuItem2
            // 
            this.albumToolStripMenuItem2.Name = "albumToolStripMenuItem2";
            this.albumToolStripMenuItem2.Size = new System.Drawing.Size(118, 22);
            this.albumToolStripMenuItem2.Text = "By Artist";
            // 
            // byArtistToolStripMenuItem
            // 
            this.byArtistToolStripMenuItem.Name = "byArtistToolStripMenuItem";
            this.byArtistToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.byArtistToolStripMenuItem.Text = "Genre";
            // 
            // genreToolStripMenuItem1
            // 
            this.genreToolStripMenuItem1.Name = "genreToolStripMenuItem1";
            this.genreToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.genreToolStripMenuItem1.Text = "Title";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 612);
            this.Controls.Add(this.dataGridViewPlaylist);
            this.Controls.Add(this.groupBoxFindSongCD);
            this.Controls.Add(this.dataGridViewFindSongCD);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxAddGenre);
            this.Controls.Add(this.buttonAddGenre);
            this.Controls.Add(this.textBoxAddArtist);
            this.Controls.Add(this.btnAddArtist);
            this.Controls.Add(this.buttonCreatePlaylist);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.radioButtonFindGenre);
            this.Controls.Add(this.radioButtonFindArtist);
            this.Controls.Add(this.radioButtonFindTitle);
            this.Controls.Add(this.textBoxFindKeywordSearch);
            this.Controls.Add(this.numericUpDownRateSongCD);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.comboBoxRateSongorCD);
            this.Controls.Add(this.buttonRate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownCreatePlaylist);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Compact Disc Catalog";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCreatePlaylist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRateSongCD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFindSongCD)).EndInit();
            this.groupBoxFindSongCD.ResumeLayout(false);
            this.groupBoxFindSongCD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaylist)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownCreatePlaylist;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonRate;
        private System.Windows.Forms.ComboBox comboBoxRateSongorCD;
        private System.Windows.Forms.NumericUpDown numericUpDownRateSongCD;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxFindKeywordSearch;
        private System.Windows.Forms.RadioButton radioButtonFindTitle;
        private System.Windows.Forms.RadioButton radioButtonFindArtist;
        private System.Windows.Forms.RadioButton radioButtonFindGenre;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button buttonCreatePlaylist;
        private System.Windows.Forms.Button btnAddArtist;
        private System.Windows.Forms.TextBox textBoxAddArtist;
        private System.Windows.Forms.TextBox textBoxAddGenre;
        private System.Windows.Forms.Button buttonAddGenre;
        private System.Windows.Forms.BindingSource genreBindingSource;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridViewFindSongCD;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBoxFindSongCD;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridViewDetails;
        private System.Windows.Forms.DataGridView dataGridViewPlaylist;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem albumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem songToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem albumToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem songToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem albumToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem byArtistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genreToolStripMenuItem1;
    }
}

