namespace CDCatalog
{
    partial class PlaylistForm
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
            this.dataGridViewPlaylist = new System.Windows.Forms.DataGridView();
            this.buttonCreatePlaylist = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownCreatePlaylist = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaylist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCreatePlaylist)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPlaylist
            // 
            this.dataGridViewPlaylist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlaylist.Location = new System.Drawing.Point(48, 115);
            this.dataGridViewPlaylist.Name = "dataGridViewPlaylist";
            this.dataGridViewPlaylist.RowHeadersVisible = false;
            this.dataGridViewPlaylist.Size = new System.Drawing.Size(532, 564);
            this.dataGridViewPlaylist.TabIndex = 73;
            // 
            // buttonCreatePlaylist
            // 
            this.buttonCreatePlaylist.Location = new System.Drawing.Point(505, 83);
            this.buttonCreatePlaylist.Name = "buttonCreatePlaylist";
            this.buttonCreatePlaylist.Size = new System.Drawing.Size(75, 23);
            this.buttonCreatePlaylist.TabIndex = 72;
            this.buttonCreatePlaylist.Text = "Create";
            this.buttonCreatePlaylist.UseVisualStyleBackColor = true;
            this.buttonCreatePlaylist.Click += new System.EventHandler(this.buttonCreatePlaylist_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 71;
            this.label6.Text = "mins";
            // 
            // numericUpDownCreatePlaylist
            // 
            this.numericUpDownCreatePlaylist.Location = new System.Drawing.Point(140, 81);
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
            this.numericUpDownCreatePlaylist.TabIndex = 70;
            this.numericUpDownCreatePlaylist.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 30);
            this.label1.TabIndex = 74;
            this.label1.Text = "Create a playlist";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Length of playlist:";
            // 
            // PlaylistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 797);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewPlaylist);
            this.Controls.Add(this.buttonCreatePlaylist);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownCreatePlaylist);
            this.Name = "PlaylistForm";
            this.Text = "PlaylistForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaylist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCreatePlaylist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPlaylist;
        private System.Windows.Forms.Button buttonCreatePlaylist;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownCreatePlaylist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}