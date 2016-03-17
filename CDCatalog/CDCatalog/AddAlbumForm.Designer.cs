namespace CDCatalog
{
    partial class AddAlbumForm
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
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxAddCDArtist = new System.Windows.Forms.ComboBox();
            this.labelAddCDYear = new System.Windows.Forms.Label();
            this.numericUpDownAddCDYear = new System.Windows.Forms.NumericUpDown();
            this.textBoxAddCDTitle = new System.Windows.Forms.TextBox();
            this.btnAddCD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddCDYear)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 70;
            this.label9.Text = "Artist";
            // 
            // comboBoxAddCDArtist
            // 
            this.comboBoxAddCDArtist.DisplayMember = "ID";
            this.comboBoxAddCDArtist.FormattingEnabled = true;
            this.comboBoxAddCDArtist.Location = new System.Drawing.Point(76, 110);
            this.comboBoxAddCDArtist.Name = "comboBoxAddCDArtist";
            this.comboBoxAddCDArtist.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAddCDArtist.TabIndex = 69;
            this.comboBoxAddCDArtist.ValueMember = "ID";
            // 
            // labelAddCDYear
            // 
            this.labelAddCDYear.AutoSize = true;
            this.labelAddCDYear.Location = new System.Drawing.Point(41, 147);
            this.labelAddCDYear.Name = "labelAddCDYear";
            this.labelAddCDYear.Size = new System.Drawing.Size(29, 13);
            this.labelAddCDYear.TabIndex = 68;
            this.labelAddCDYear.Text = "Year";
            // 
            // numericUpDownAddCDYear
            // 
            this.numericUpDownAddCDYear.Location = new System.Drawing.Point(76, 147);
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
            this.numericUpDownAddCDYear.TabIndex = 67;
            this.numericUpDownAddCDYear.Value = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            // 
            // textBoxAddCDTitle
            // 
            this.textBoxAddCDTitle.Location = new System.Drawing.Point(73, 75);
            this.textBoxAddCDTitle.Name = "textBoxAddCDTitle";
            this.textBoxAddCDTitle.Size = new System.Drawing.Size(80, 20);
            this.textBoxAddCDTitle.TabIndex = 66;
            // 
            // btnAddCD
            // 
            this.btnAddCD.Location = new System.Drawing.Point(38, 182);
            this.btnAddCD.Name = "btnAddCD";
            this.btnAddCD.Size = new System.Drawing.Size(75, 23);
            this.btnAddCD.TabIndex = 65;
            this.btnAddCD.Text = "Add CD";
            this.btnAddCD.UseVisualStyleBackColor = true;
            this.btnAddCD.Click += new System.EventHandler(this.btnAddCD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 30);
            this.label1.TabIndex = 71;
            this.label1.Text = "Add new album";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "Title";
            // 
            // AddAlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 732);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxAddCDArtist);
            this.Controls.Add(this.labelAddCDYear);
            this.Controls.Add(this.numericUpDownAddCDYear);
            this.Controls.Add(this.textBoxAddCDTitle);
            this.Controls.Add(this.btnAddCD);
            this.Name = "AddAlbumForm";
            this.Text = "AddAlbumForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddCDYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxAddCDArtist;
        private System.Windows.Forms.Label labelAddCDYear;
        private System.Windows.Forms.NumericUpDown numericUpDownAddCDYear;
        private System.Windows.Forms.TextBox textBoxAddCDTitle;
        private System.Windows.Forms.Button btnAddCD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}