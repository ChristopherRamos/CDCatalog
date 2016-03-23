namespace CDCatalog
{
    partial class AddArtistForm
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
            this.textBoxAddArtist = new System.Windows.Forms.TextBox();
            this.btnAddArtist = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxAddArtist
            // 
            this.textBoxAddArtist.Location = new System.Drawing.Point(71, 65);
            this.textBoxAddArtist.Name = "textBoxAddArtist";
            this.textBoxAddArtist.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddArtist.TabIndex = 58;
            // 
            // btnAddArtist
            // 
            this.btnAddArtist.Location = new System.Drawing.Point(188, 62);
            this.btnAddArtist.Name = "btnAddArtist";
            this.btnAddArtist.Size = new System.Drawing.Size(75, 23);
            this.btnAddArtist.TabIndex = 57;
            this.btnAddArtist.Text = "Add Artist";
            this.btnAddArtist.UseVisualStyleBackColor = true;
            this.btnAddArtist.Click += new System.EventHandler(this.btnAddArtist_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 30);
            this.label1.TabIndex = 72;
            this.label1.Text = "Add artist";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Name:";
            // 
            // AddArtistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 806);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAddArtist);
            this.Controls.Add(this.btnAddArtist);
            this.Name = "AddArtistForm";
            this.Text = "AddArtistForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAddArtist;
        private System.Windows.Forms.Button btnAddArtist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}