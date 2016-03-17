namespace CDCatalog
{
    partial class AddSongForm
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
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxAddSongArtist = new System.Windows.Forms.ComboBox();
            this.comboBoxAddSongAlbum = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownAddSongTrackNumber = new System.Windows.Forms.NumericUpDown();
            this.labelAddSongTrackNumber = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDownAddSongTrackLength = new System.Windows.Forms.NumericUpDown();
            this.comboBoxAddSongGenre = new System.Windows.Forms.ComboBox();
            this.textBoxAddSongTitle = new System.Windows.Forms.TextBox();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAddSongTitle = new System.Windows.Forms.Label();
            this.lableAddSongStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddSongTrackNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddSongTrackLength)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 78;
            this.label10.Text = "Artist";
            // 
            // comboBoxAddSongArtist
            // 
            this.comboBoxAddSongArtist.DisplayMember = "ID";
            this.comboBoxAddSongArtist.FormattingEnabled = true;
            this.comboBoxAddSongArtist.Location = new System.Drawing.Point(63, 107);
            this.comboBoxAddSongArtist.Name = "comboBoxAddSongArtist";
            this.comboBoxAddSongArtist.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAddSongArtist.TabIndex = 77;
            this.comboBoxAddSongArtist.ValueMember = "ID";
            // 
            // comboBoxAddSongAlbum
            // 
            this.comboBoxAddSongAlbum.DisplayMember = "ID";
            this.comboBoxAddSongAlbum.FormattingEnabled = true;
            this.comboBoxAddSongAlbum.Location = new System.Drawing.Point(63, 134);
            this.comboBoxAddSongAlbum.Name = "comboBoxAddSongAlbum";
            this.comboBoxAddSongAlbum.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAddSongAlbum.TabIndex = 76;
            this.comboBoxAddSongAlbum.ValueMember = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 75;
            this.label8.Text = "Album";
            // 
            // numericUpDownAddSongTrackNumber
            // 
            this.numericUpDownAddSongTrackNumber.Location = new System.Drawing.Point(148, 199);
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
            this.numericUpDownAddSongTrackNumber.TabIndex = 74;
            this.numericUpDownAddSongTrackNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelAddSongTrackNumber
            // 
            this.labelAddSongTrackNumber.AutoSize = true;
            this.labelAddSongTrackNumber.Location = new System.Drawing.Point(21, 201);
            this.labelAddSongTrackNumber.Name = "labelAddSongTrackNumber";
            this.labelAddSongTrackNumber.Size = new System.Drawing.Size(75, 13);
            this.labelAddSongTrackNumber.TabIndex = 73;
            this.labelAddSongTrackNumber.Text = "Track Number";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(21, 175);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(36, 13);
            this.label19.TabIndex = 72;
            this.label19.Text = "Genre";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 237);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 71;
            this.label13.Text = "Track Length";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 259);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 70;
            this.label11.Text = "(seconds)";
            // 
            // numericUpDownAddSongTrackLength
            // 
            this.numericUpDownAddSongTrackLength.Location = new System.Drawing.Point(128, 235);
            this.numericUpDownAddSongTrackLength.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.numericUpDownAddSongTrackLength.Name = "numericUpDownAddSongTrackLength";
            this.numericUpDownAddSongTrackLength.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownAddSongTrackLength.TabIndex = 69;
            // 
            // comboBoxAddSongGenre
            // 
            this.comboBoxAddSongGenre.DisplayMember = "ID";
            this.comboBoxAddSongGenre.FormattingEnabled = true;
            this.comboBoxAddSongGenre.Location = new System.Drawing.Point(64, 167);
            this.comboBoxAddSongGenre.Name = "comboBoxAddSongGenre";
            this.comboBoxAddSongGenre.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAddSongGenre.TabIndex = 68;
            this.comboBoxAddSongGenre.ValueMember = "ID";
            // 
            // textBoxAddSongTitle
            // 
            this.textBoxAddSongTitle.Location = new System.Drawing.Point(64, 75);
            this.textBoxAddSongTitle.Name = "textBoxAddSongTitle";
            this.textBoxAddSongTitle.Size = new System.Drawing.Size(80, 20);
            this.textBoxAddSongTitle.TabIndex = 67;
            // 
            // btnAddSong
            // 
            this.btnAddSong.Location = new System.Drawing.Point(30, 292);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(75, 23);
            this.btnAddSong.TabIndex = 66;
            this.btnAddSong.Text = "Add Song";
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 30);
            this.label1.TabIndex = 65;
            this.label1.Text = "Add new song";
            // 
            // labelAddSongTitle
            // 
            this.labelAddSongTitle.AutoSize = true;
            this.labelAddSongTitle.Location = new System.Drawing.Point(30, 78);
            this.labelAddSongTitle.Name = "labelAddSongTitle";
            this.labelAddSongTitle.Size = new System.Drawing.Size(27, 13);
            this.labelAddSongTitle.TabIndex = 79;
            this.labelAddSongTitle.Text = "Title";
            // 
            // lableAddSongStatus
            // 
            this.lableAddSongStatus.AutoSize = true;
            this.lableAddSongStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableAddSongStatus.Location = new System.Drawing.Point(29, 342);
            this.lableAddSongStatus.Name = "lableAddSongStatus";
            this.lableAddSongStatus.Size = new System.Drawing.Size(108, 20);
            this.lableAddSongStatus.TabIndex = 80;
            this.lableAddSongStatus.Text = "Song Added";
            this.lableAddSongStatus.Visible = false;
            // 
            // AddSongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 710);
            this.ControlBox = false;
            this.Controls.Add(this.lableAddSongStatus);
            this.Controls.Add(this.labelAddSongTitle);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBoxAddSongArtist);
            this.Controls.Add(this.comboBoxAddSongAlbum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDownAddSongTrackNumber);
            this.Controls.Add(this.labelAddSongTrackNumber);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numericUpDownAddSongTrackLength);
            this.Controls.Add(this.comboBoxAddSongGenre);
            this.Controls.Add(this.textBoxAddSongTitle);
            this.Controls.Add(this.btnAddSong);
            this.Controls.Add(this.label1);
            this.Name = "AddSongForm";
            this.Text = "AddSongForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddSongTrackNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddSongTrackLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxAddSongArtist;
        private System.Windows.Forms.ComboBox comboBoxAddSongAlbum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownAddSongTrackNumber;
        private System.Windows.Forms.Label labelAddSongTrackNumber;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDownAddSongTrackLength;
        private System.Windows.Forms.ComboBox comboBoxAddSongGenre;
        private System.Windows.Forms.TextBox textBoxAddSongTitle;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAddSongTitle;
        private System.Windows.Forms.Label lableAddSongStatus;
    }
}