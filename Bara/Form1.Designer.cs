namespace Bara
{
    partial class Form1
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
            this.cmsDodaj = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Dodaj_žabu = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDodaj.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsDodaj
            // 
            this.cmsDodaj.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Dodaj_žabu});
            this.cmsDodaj.Name = "cmsDodaj";
            this.cmsDodaj.Size = new System.Drawing.Size(181, 48);
            this.cmsDodaj.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmsDodaj_MouseClick);
            // 
            // Dodaj_žabu
            // 
            this.Dodaj_žabu.Name = "Dodaj_žabu";
            this.Dodaj_žabu.Size = new System.Drawing.Size(180, 22);
            this.Dodaj_žabu.Text = "Dodaj žabu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.cmsDodaj;
            this.Name = "Form1";
            this.Text = "Žabe u bari";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cmsDodaj.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cmsDodaj;
        private System.Windows.Forms.ToolStripMenuItem Dodaj_žabu;
    }
}

