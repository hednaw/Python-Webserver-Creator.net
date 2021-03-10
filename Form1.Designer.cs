namespace Python_Webserver_Creator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PortTextbox = new System.Windows.Forms.TextBox();
            this.MakeButton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PortTextbox
            // 
            this.PortTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PortTextbox.BackColor = System.Drawing.SystemColors.Info;
            this.PortTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PortTextbox.Location = new System.Drawing.Point(73, 31);
            this.PortTextbox.Name = "PortTextbox";
            this.PortTextbox.Size = new System.Drawing.Size(227, 20);
            this.PortTextbox.TabIndex = 1;
            this.PortTextbox.Text = "8000";
            this.PortTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PortTextbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // MakeButton
            // 
            this.MakeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MakeButton.ForeColor = System.Drawing.Color.Black;
            this.MakeButton.Location = new System.Drawing.Point(73, 57);
            this.MakeButton.MaximumSize = new System.Drawing.Size(227, 66);
            this.MakeButton.MinimumSize = new System.Drawing.Size(227, 66);
            this.MakeButton.Name = "MakeButton";
            this.MakeButton.Size = new System.Drawing.Size(227, 66);
            this.MakeButton.TabIndex = 2;
            this.MakeButton.Text = "Make";
            this.MakeButton.UseVisualStyleBackColor = true;
            this.MakeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Crimson;
            this.ErrorLabel.Location = new System.Drawing.Point(82, 98);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel.TabIndex = 3;
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PathTextBox
            // 
            this.PathTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.PathTextBox.Location = new System.Drawing.Point(133, 5);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(167, 20);
            this.PathTextBox.TabIndex = 4;
            this.PathTextBox.TextChanged += new System.EventHandler(this.PathTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 20);
            this.button1.TabIndex = 5;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(371, 129);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.MakeButton);
            this.Controls.Add(this.PortTextbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Python Webserver Maker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox PortTextbox;
        private System.Windows.Forms.Button MakeButton;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
    }
}

