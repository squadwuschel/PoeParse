namespace PoeParse
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.ToggleStart = new System.Windows.Forms.Button();
            this.Suche = new System.Windows.Forms.TextBox();
            this.AusgabeText = new System.Windows.Forms.TextBox();
            this.poeBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // ToggleStart
            // 
            this.ToggleStart.Location = new System.Drawing.Point(503, 25);
            this.ToggleStart.Name = "ToggleStart";
            this.ToggleStart.Size = new System.Drawing.Size(75, 23);
            this.ToggleStart.TabIndex = 0;
            this.ToggleStart.Text = "ToggleStart";
            this.ToggleStart.UseVisualStyleBackColor = true;
            this.ToggleStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // Suche
            // 
            this.Suche.Location = new System.Drawing.Point(203, 27);
            this.Suche.Name = "Suche";
            this.Suche.Size = new System.Drawing.Size(284, 20);
            this.Suche.TabIndex = 1;
            // 
            // AusgabeText
            // 
            this.AusgabeText.Location = new System.Drawing.Point(25, 71);
            this.AusgabeText.Multiline = true;
            this.AusgabeText.Name = "AusgabeText";
            this.AusgabeText.Size = new System.Drawing.Size(1181, 357);
            this.AusgabeText.TabIndex = 2;
            // 
            // poeBackgroundWorker
            // 
            this.poeBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.poeBackgroundWorker_DoWork);
            this.poeBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.poeBackgroundWorker_ProgressChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 504);
            this.Controls.Add(this.AusgabeText);
            this.Controls.Add(this.Suche);
            this.Controls.Add(this.ToggleStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ToggleStart;
        private System.Windows.Forms.TextBox Suche;
        private System.Windows.Forms.TextBox AusgabeText;
        private System.ComponentModel.BackgroundWorker poeBackgroundWorker;
    }
}

