namespace PixelTamagotchi
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
            this.picPet = new System.Windows.Forms.PictureBox();
            this.lblHappiness = new System.Windows.Forms.Label();
            this.lblHunger = new System.Windows.Forms.Label();
            this.lblEnergy = new System.Windows.Forms.Label();
            this.btnFeed = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnSleep = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPet)).BeginInit();
            this.SuspendLayout();
            // 
            // picPet
            // 
            this.picPet.BackColor = System.Drawing.SystemColors.Control;
            this.picPet.Image = global::PixelTamagotchi.Properties.Resources.pet_happy;
            this.picPet.Location = new System.Drawing.Point(207, 181);
            this.picPet.Name = "picPet";
            this.picPet.Size = new System.Drawing.Size(252, 214);
            this.picPet.TabIndex = 0;
            this.picPet.TabStop = false;
            this.picPet.Paint += new System.Windows.Forms.PaintEventHandler(this.picPet_Paint);
            // 
            // lblHappiness
            // 
            this.lblHappiness.AutoSize = true;
            this.lblHappiness.Font = new System.Drawing.Font("Roland", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHappiness.ForeColor = System.Drawing.Color.HotPink;
            this.lblHappiness.Location = new System.Drawing.Point(12, 26);
            this.lblHappiness.Name = "lblHappiness";
            this.lblHappiness.Size = new System.Drawing.Size(75, 13);
            this.lblHappiness.TabIndex = 1;
            this.lblHappiness.Text = "Felicità: 50";
            // 
            // lblHunger
            // 
            this.lblHunger.AutoSize = true;
            this.lblHunger.Font = new System.Drawing.Font("Roland", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHunger.ForeColor = System.Drawing.Color.Tomato;
            this.lblHunger.Location = new System.Drawing.Point(12, 55);
            this.lblHunger.Name = "lblHunger";
            this.lblHunger.Size = new System.Drawing.Size(63, 13);
            this.lblHunger.TabIndex = 2;
            this.lblHunger.Text = "Fame: 50";
            // 
            // lblEnergy
            // 
            this.lblEnergy.AutoSize = true;
            this.lblEnergy.Font = new System.Drawing.Font("Roland", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnergy.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblEnergy.Location = new System.Drawing.Point(12, 87);
            this.lblEnergy.Name = "lblEnergy";
            this.lblEnergy.Size = new System.Drawing.Size(79, 13);
            this.lblEnergy.TabIndex = 3;
            this.lblEnergy.Text = "Energia: 50";
            // 
            // btnFeed
            // 
            this.btnFeed.Location = new System.Drawing.Point(182, 416);
            this.btnFeed.Name = "btnFeed";
            this.btnFeed.Size = new System.Drawing.Size(75, 23);
            this.btnFeed.TabIndex = 4;
            this.btnFeed.Text = "Nutri";
            this.btnFeed.UseVisualStyleBackColor = true;
            this.btnFeed.Click += new System.EventHandler(this.btnFeed_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(296, 416);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "Gioca";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnSleep
            // 
            this.btnSleep.Location = new System.Drawing.Point(414, 416);
            this.btnSleep.Name = "btnSleep";
            this.btnSleep.Size = new System.Drawing.Size(75, 23);
            this.btnSleep.TabIndex = 6;
            this.btnSleep.Text = "Dormi";
            this.btnSleep.UseVisualStyleBackColor = true;
            this.btnSleep.Click += new System.EventHandler(this.btnSleep_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(589, 181);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Salva";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(589, 226);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 8;
            this.btnLoad.Text = "Carica";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSleep);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnFeed);
            this.Controls.Add(this.lblEnergy);
            this.Controls.Add(this.lblHunger);
            this.Controls.Add(this.lblHappiness);
            this.Controls.Add(this.picPet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Pixel Tamagotchi";
            ((System.ComponentModel.ISupportInitialize)(this.picPet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPet;
        private System.Windows.Forms.Label lblHappiness;
        private System.Windows.Forms.Label lblHunger;
        private System.Windows.Forms.Label lblEnergy;
        private System.Windows.Forms.Button btnFeed;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnSleep;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
    }
}

