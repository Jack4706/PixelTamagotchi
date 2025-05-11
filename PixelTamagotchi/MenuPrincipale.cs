using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelTamagotchi
{
    public partial class MenuPrincipale: Form
    {
        public MenuPrincipale()
        {
            InitializeComponent();
            this.DoubleBuffered = true;  // Riduce flickering
            this.Click += MenuPrincipale_Click;
            lblTitolo.Click += MenuPrincipale_Click;
            // Carica lo sfondo dalle risorse
            this.BackgroundImage = Properties.Resources.Summer2;  // Sostituisci "menu_bg" con il nome del tuo file
            this.BackgroundImageLayout = ImageLayout.Stretch;  // Adatta all'intero form
            lblTitolo.BackColor = Color.Transparent;
            lblTitolo.Parent = this;
        }

        private void timerLampeggio_Tick(object sender, EventArgs e)
        {
            lblTitolo.Visible = !lblTitolo.Visible;  // Alterna visibilità
        }

        private void MenuPrincipale_Click(object sender, EventArgs e)
        {
            var gioco = new Form1();
            gioco.Show();
            this.Hide();
        }
    }
}
