namespace CDCatalog
{
    partial class FindForm
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
            this.dataGridViewDetails = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFindSongCD)).BeginInit();
            this.groupBoxFindSongCD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFindSongCD
            // 
            this.dataGridViewFindSongCD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFindSongCD.Location = new System.Drawing.Point(15, 89);
            this.dataGridViewFindSongCD.Name = "dataGridViewFindSongCD";
            this.dataGridViewFindSongCD.RowHeadersVisible = false;
            this.dataGridViewFindSongCD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFindSongCD.Size = new System.Drawing.Size(451, 137);
            this.dataGridViewFindSongCD.TabIndex = 74;
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
            this.btnFind.Location = new System.Drawing.Point(391, 56);
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
            this.radioButtonFindGenre.Location = new System.Drawing.Point(315, 59);
            this.radioButtonFindGenre.Name = "radioButtonFindGenre";
            this.radioButtonFindGenre.Size = new System.Drawing.Size(54, 17);
            this.radioButtonFindGenre.TabIndex = 71;
            this.radioButtonFindGenre.Text = "Genre";
            this.radioButtonFindGenre.UseVisualStyleBackColor = true;
            // 
            // radioButtonFindArtist
            // 
            this.radioButtonFindArtist.AutoSize = true;
            this.radioButtonFindArtist.Location = new System.Drawing.Point(261, 59);
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
            this.radioButtonFindTitle.Location = new System.Drawing.Point(207, 59);
            this.radioButtonFindTitle.Name = "radioButtonFindTitle";
            this.radioButtonFindTitle.Size = new System.Drawing.Size(45, 17);
            this.radioButtonFindTitle.TabIndex = 69;
            this.radioButtonFindTitle.TabStop = true;
            this.radioButtonFindTitle.Text = "Title";
            this.radioButtonFindTitle.UseVisualStyleBackColor = true;
            // 
            // textBoxFindKeywordSearch
            // 
            this.textBoxFindKeywordSearch.Location = new System.Drawing.Point(16, 62);
            this.textBoxFindKeywordSearch.Name = "textBoxFindKeywordSearch";
            this.textBoxFindKeywordSearch.Size = new System.Drawing.Size(183, 20);
            this.textBoxFindKeywordSearch.TabIndex = 68;
            this.textBoxFindKeywordSearch.Text = "Keyword Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 30);
            this.label1.TabIndex = 75;
            this.label1.Text = "Find a song or cd";
            // 
            // groupBoxFindSongCD
            // 
            this.groupBoxFindSongCD.Controls.Add(this.dataGridViewDetails);
            this.groupBoxFindSongCD.Controls.Add(this.label15);
            this.groupBoxFindSongCD.Controls.Add(this.label14);
            this.groupBoxFindSongCD.Location = new System.Drawing.Point(12, 232);
            this.groupBoxFindSongCD.Name = "groupBoxFindSongCD";
            this.groupBoxFindSongCD.Size = new System.Drawing.Size(618, 262);
            this.groupBoxFindSongCD.TabIndex = 76;
            this.groupBoxFindSongCD.TabStop = false;
            this.groupBoxFindSongCD.Text = "groupBox1";
            // 
            // dataGridViewDetails
            // 
            this.dataGridViewDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetails.Location = new System.Drawing.Point(6, 67);
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 67;
            this.label14.Text = "label14";
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 507);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxFindSongCD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewFindSongCD);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.radioButtonFindGenre);
            this.Controls.Add(this.radioButtonFindArtist);
            this.Controls.Add(this.radioButtonFindTitle);
            this.Controls.Add(this.textBoxFindKeywordSearch);
            this.Name = "FindForm";
            this.Text = "FindForm";
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
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
    }
}