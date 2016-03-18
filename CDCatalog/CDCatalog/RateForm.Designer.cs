namespace CDCatalog
{
    partial class RateForm
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
            this.numericUpDownRateSongCD = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBoxRateSongorCD = new System.Windows.Forms.ComboBox();
            this.buttonRate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRateSongCD)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownRateSongCD
            // 
            this.numericUpDownRateSongCD.Location = new System.Drawing.Point(374, 64);
            this.numericUpDownRateSongCD.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownRateSongCD.Name = "numericUpDownRateSongCD";
            this.numericUpDownRateSongCD.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownRateSongCD.TabIndex = 42;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(330, 87);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 13);
            this.label16.TabIndex = 41;
            this.label16.Text = "(1=Lowest : 5= Highest)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(330, 66);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 40;
            this.label17.Text = "Rating";
            // 
            // comboBoxRateSongorCD
            // 
            this.comboBoxRateSongorCD.FormattingEnabled = true;
            this.comboBoxRateSongorCD.Location = new System.Drawing.Point(15, 64);
            this.comboBoxRateSongorCD.Name = "comboBoxRateSongorCD";
            this.comboBoxRateSongorCD.Size = new System.Drawing.Size(294, 21);
            this.comboBoxRateSongorCD.TabIndex = 39;
            // 
            // buttonRate
            // 
            this.buttonRate.Location = new System.Drawing.Point(444, 61);
            this.buttonRate.Name = "buttonRate";
            this.buttonRate.Size = new System.Drawing.Size(75, 23);
            this.buttonRate.TabIndex = 38;
            this.buttonRate.Text = "Rate";
            this.buttonRate.UseVisualStyleBackColor = true;
            this.buttonRate.Click += new System.EventHandler(this.buttonRate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 30);
            this.label1.TabIndex = 66;
            this.label1.Text = "Rate album or song";
            // 
            // RateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 803);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownRateSongCD);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.comboBoxRateSongorCD);
            this.Controls.Add(this.buttonRate);
            this.Name = "RateForm";
            this.Text = "RateForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRateSongCD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownRateSongCD;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBoxRateSongorCD;
        private System.Windows.Forms.Button buttonRate;
        private System.Windows.Forms.Label label1;
    }
}