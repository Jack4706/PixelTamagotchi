namespace PixelTamagotchi
{
    partial class MenuPrincipale
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
            this.lblTitolo = new System.Windows.Forms.Label();
            this.timerLampeggio = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblTitolo
            // 
            this.lblTitolo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitolo.Font = new System.Drawing.Font("Roland", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitolo.ForeColor = System.Drawing.Color.Gold;
            this.lblTitolo.Location = new System.Drawing.Point(0, 0);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(784, 561);
            this.lblTitolo.TabIndex = 0;
            this.lblTitolo.Text = "CLICCA LO SCHERMO PER GIOCARE";
            this.lblTitolo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerLampeggio
            // 
            this.timerLampeggio.Interval = 500;
            this.timerLampeggio.Tick += new System.EventHandler(this.timerLampeggio_Tick);
            // 
            // MenuPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblTitolo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MenuPrincipale";
            this.Text = "Tamagotchi Pixel";
            this.Click += new System.EventHandler(this.MenuPrincipale_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.Timer timerLampeggio;
    }
}