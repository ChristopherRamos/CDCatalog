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
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownCreatePlaylist = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonRate = new System.Windows.Forms.Button();
            this.comboBoxRateSongorCD = new System.Windows.Forms.ComboBox();
            this.numericUpDownRateSongCD = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.buttonCreatePlaylist = new System.Windows.Forms.Button();
            this.btnAddArtist = new System.Windows.Forms.Button();
            this.textBoxAddArtist = new System.Windows.Forms.TextBox();
            this.textBoxAddGenre = new System.Windows.Forms.TextBox();
            this.buttonAddGenre = new System.Windows.Forms.Button();
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
            this.byArtistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byGenreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byTitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCreatePlaylist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRateSongCD)).BeginInit();
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
            this.albumToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.albumToolStripMenuItem.Text = "Album";
            this.albumToolStripMenuItem.Click += new System.EventHandler(this.albumToolStripMenuItem_Click);
            // 
            // artistToolStripMenuItem
            // 
            this.artistToolStripMenuItem.Name = "artistToolStripMenuItem";
            this.artistToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.artistToolStripMenuItem.Text = "Artist";
            // 
            // genreToolStripMenuItem
            // 
            this.genreToolStripMenuItem.Name = "genreToolStripMenuItem";
            this.genreToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.genreToolStripMenuItem.Text = "Genre";
            // 
            // songToolStripMenuItem
            // 
            this.songToolStripMenuItem.Name = "songToolStripMenuItem";
            this.songToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
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
            this.albumToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.albumToolStripMenuItem1.Text = "Album";
            // 
            // songToolStripMenuItem1
            // 
            this.songToolStripMenuItem1.Name = "songToolStripMenuItem1";
            this.songToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.songToolStripMenuItem1.Text = "Song";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byArtistToolStripMenuItem,
            this.byGenreToolStripMenuItem,
            this.byTitleToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // byArtistToolStripMenuItem
            // 
            this.byArtistToolStripMenuItem.Name = "byArtistToolStripMenuItem";
            this.byArtistToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.byArtistToolStripMenuItem.Text = "By Artist";
            this.byArtistToolStripMenuItem.Click += new System.EventHandler(this.byArtistToolStripMenuItem_Click);
            // 
            // byGenreToolStripMenuItem
            // 
            this.byGenreToolStripMenuItem.Name = "byGenreToolStripMenuItem";
            this.byGenreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.byGenreToolStripMenuItem.Text = "By Genre";
            this.byGenreToolStripMenuItem.Click += new System.EventHandler(this.byGenreToolStripMenuItem_Click);
            // 
            // byTitleToolStripMenuItem
            // 
            this.byTitleToolStripMenuItem.Name = "byTitleToolStripMenuItem";
            this.byTitleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.byTitleToolStripMenuItem.Text = "By Title";
            this.byTitleToolStripMenuItem.Click += new System.EventHandler(this.byTitleToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 612);
            this.Controls.Add(this.dataGridViewPlaylist);
            this.Controls.Add(this.textBoxAddGenre);
            this.Controls.Add(this.buttonAddGenre);
            this.Controls.Add(this.textBoxAddArtist);
            this.Controls.Add(this.btnAddArtist);
            this.Controls.Add(this.buttonCreatePlaylist);
            this.Controls.Add(this.numericUpDownRateSongCD);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.comboBoxRateSongorCD);
            this.Controls.Add(this.buttonRate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownCreatePlaylist);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Compact Disc Catalog";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCreatePlaylist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRateSongCD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaylist)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownCreatePlaylist;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonRate;
        private System.Windows.Forms.ComboBox comboBoxRateSongorCD;
        private System.Windows.Forms.NumericUpDown numericUpDownRateSongCD;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button buttonCreatePlaylist;
        private System.Windows.Forms.Button btnAddArtist;
        private System.Windows.Forms.TextBox textBoxAddArtist;
        private System.Windows.Forms.TextBox textBoxAddGenre;
        private System.Windows.Forms.Button buttonAddGenre;
        private System.Windows.Forms.BindingSource genreBindingSource;
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
        private System.Windows.Forms.ToolStripMenuItem byArtistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byGenreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byTitleToolStripMenuItem;
    }
}

