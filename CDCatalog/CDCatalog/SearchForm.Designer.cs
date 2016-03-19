namespace CDCatalog
{
    partial class SearchForm
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
            this.dataGridViewFindSongCD = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.radioButtonFindGenre = new System.Windows.Forms.RadioButton();
            this.radioButtonFindArtist = new System.Windows.Forms.RadioButton();
            this.radioButtonFindTitle = new System.Windows.Forms.RadioButton();
            this.textBoxFindKeywordSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxFindSongCD = new System.Windows.Forms.GroupBox();
            this.labelDetailsRating = new System.Windows.Forms.Label();
            this.labelDetailsYear = new System.Windows.Forms.Label();
            this.labelDetailsArtist = new System.Windows.Forms.Label();
            this.labelDetailsAlbumTitle = new System.Windows.Forms.Label();
            this.dataGridViewDetails = new System.Windows.Forms.DataGridView();
            this.labelDetailsInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFindSongCD)).BeginInit();
            this.groupBoxFindSongCD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFindSongCD
            // 
            this.dataGridViewFindSongCD.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewFindSongCD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewFindSongCD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFindSongCD.Location = new System.Drawing.Point(12, 139);
            this.dataGridViewFindSongCD.Name = "dataGridViewFindSongCD";
            this.dataGridViewFindSongCD.RowHeadersVisible = false;
            this.dataGridViewFindSongCD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFindSongCD.Size = new System.Drawing.Size(411, 137);
            this.dataGridViewFindSongCD.TabIndex = 74;
            this.dataGridViewFindSongCD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFindSongCD_CellClick);
            this.dataGridViewFindSongCD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFindSongCD_CellContentClick);
            this.dataGridViewFindSongCD.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFindSongCD_CellContentDoubleClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 189);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(235, 13);
            this.label12.TabIndex = 73;
            this.label12.Text = "Click on any of the results above for more details";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(387, 107);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 72;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // radioButtonFindGenre
            // 
            this.radioButtonFindGenre.AutoSize = true;
            this.radioButtonFindGenre.Location = new System.Drawing.Point(311, 110);
            this.radioButtonFindGenre.Name = "radioButtonFindGenre";
            this.radioButtonFindGenre.Size = new System.Drawing.Size(54, 17);
            this.radioButtonFindGenre.TabIndex = 71;
            this.radioButtonFindGenre.Text = "Genre";
            this.radioButtonFindGenre.UseVisualStyleBackColor = true;
            // 
            // radioButtonFindArtist
            // 
            this.radioButtonFindArtist.AutoSize = true;
            this.radioButtonFindArtist.Location = new System.Drawing.Point(257, 110);
            this.radioButtonFindArtist.Name = "radioButtonFindArtist";
            this.radioButtonFindArtist.Size = new System.Drawing.Size(48, 17);
            this.radioButtonFindArtist.TabIndex = 70;
            this.radioButtonFindArtist.Text = "Artist";
            this.radioButtonFindArtist.UseVisualStyleBackColor = true;
            // 
            // radioButtonFindTitle
            // 
            this.radioButtonFindTitle.AutoSize = true;
            this.radioButtonFindTitle.Checked = true;
            this.radioButtonFindTitle.Location = new System.Drawing.Point(203, 110);
            this.radioButtonFindTitle.Name = "radioButtonFindTitle";
            this.radioButtonFindTitle.Size = new System.Drawing.Size(45, 17);
            this.radioButtonFindTitle.TabIndex = 69;
            this.radioButtonFindTitle.TabStop = true;
            this.radioButtonFindTitle.Text = "Title";
            this.radioButtonFindTitle.UseVisualStyleBackColor = true;
            // 
            // textBoxFindKeywordSearch
            // 
            this.textBoxFindKeywordSearch.Location = new System.Drawing.Point(12, 113);
            this.textBoxFindKeywordSearch.Name = "textBoxFindKeywordSearch";
            this.textBoxFindKeywordSearch.Size = new System.Drawing.Size(183, 20);
            this.textBoxFindKeywordSearch.TabIndex = 68;
            this.textBoxFindKeywordSearch.Text = "Keyword Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 30);
            this.label1.TabIndex = 75;
            this.label1.Text = "Find a song or cd";
            // 
            // groupBoxFindSongCD
            // 
            this.groupBoxFindSongCD.Controls.Add(this.labelDetailsRating);
            this.groupBoxFindSongCD.Controls.Add(this.labelDetailsYear);
            this.groupBoxFindSongCD.Controls.Add(this.labelDetailsArtist);
            this.groupBoxFindSongCD.Controls.Add(this.labelDetailsAlbumTitle);
            this.groupBoxFindSongCD.Controls.Add(this.dataGridViewDetails);
            this.groupBoxFindSongCD.Location = new System.Drawing.Point(12, 319);
            this.groupBoxFindSongCD.Name = "groupBoxFindSongCD";
            this.groupBoxFindSongCD.Size = new System.Drawing.Size(712, 203);
            this.groupBoxFindSongCD.TabIndex = 76;
            this.groupBoxFindSongCD.TabStop = false;
            this.groupBoxFindSongCD.Text = "Details";
            // 
            // labelDetailsRating
            // 
            this.labelDetailsRating.AutoSize = true;
            this.labelDetailsRating.Location = new System.Drawing.Point(409, 20);
            this.labelDetailsRating.Name = "labelDetailsRating";
            this.labelDetailsRating.Size = new System.Drawing.Size(0, 13);
            this.labelDetailsRating.TabIndex = 79;
            // 
            // labelDetailsYear
            // 
            this.labelDetailsYear.AutoSize = true;
            this.labelDetailsYear.Location = new System.Drawing.Point(332, 20);
            this.labelDetailsYear.Name = "labelDetailsYear";
            this.labelDetailsYear.Size = new System.Drawing.Size(0, 13);
            this.labelDetailsYear.TabIndex = 78;
            // 
            // labelDetailsArtist
            // 
            this.labelDetailsArtist.AutoSize = true;
            this.labelDetailsArtist.Location = new System.Drawing.Point(200, 20);
            this.labelDetailsArtist.Name = "labelDetailsArtist";
            this.labelDetailsArtist.Size = new System.Drawing.Size(0, 13);
            this.labelDetailsArtist.TabIndex = 77;
            // 
            // labelDetailsAlbumTitle
            // 
            this.labelDetailsAlbumTitle.AutoSize = true;
            this.labelDetailsAlbumTitle.Location = new System.Drawing.Point(6, 20);
            this.labelDetailsAlbumTitle.Name = "labelDetailsAlbumTitle";
            this.labelDetailsAlbumTitle.Size = new System.Drawing.Size(0, 13);
            this.labelDetailsAlbumTitle.TabIndex = 76;
            // 
            // dataGridViewDetails
            // 
            this.dataGridViewDetails.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetails.Location = new System.Drawing.Point(4, 36);
            this.dataGridViewDetails.Name = "dataGridViewDetails";
            this.dataGridViewDetails.RowHeadersVisible = false;
            this.dataGridViewDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDetails.Size = new System.Drawing.Size(701, 161);
            this.dataGridViewDetails.TabIndex = 75;
            // 
            // labelDetailsInfo
            // 
            this.labelDetailsInfo.AutoSize = true;
            this.labelDetailsInfo.Location = new System.Drawing.Point(13, 288);
            this.labelDetailsInfo.Name = "labelDetailsInfo";
            this.labelDetailsInfo.Size = new System.Drawing.Size(0, 13);
            this.labelDetailsInfo.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 13);
            this.label2.TabIndex = 77;
            this.label2.Text = "1. Enter a search keyword in the box below, then click Find.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(427, 13);
            this.label3.TabIndex = 78;
            this.label3.Text = "2. Double click on the search result below to show more details about the Song or" +
    " Album.";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 534);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelDetailsInfo);
            this.Controls.Add(this.groupBoxFindSongCD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewFindSongCD);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.radioButtonFindGenre);
            this.Controls.Add(this.radioButtonFindArtist);
            this.Controls.Add(this.radioButtonFindTitle);
            this.Controls.Add(this.textBoxFindKeywordSearch);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFindSongCD)).EndInit();
            this.groupBoxFindSongCD.ResumeLayout(false);
            this.groupBoxFindSongCD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFindSongCD;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.RadioButton radioButtonFindGenre;
        private System.Windows.Forms.RadioButton radioButtonFindArtist;
        private System.Windows.Forms.RadioButton radioButtonFindTitle;
        private System.Windows.Forms.TextBox textBoxFindKeywordSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxFindSongCD;
        private System.Windows.Forms.DataGridView dataGridViewDetails;
        private System.Windows.Forms.Label labelDetailsInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelDetailsAlbumTitle;
        private System.Windows.Forms.Label labelDetailsRating;
        private System.Windows.Forms.Label labelDetailsYear;
        private System.Windows.Forms.Label labelDetailsArtist;
    }
}