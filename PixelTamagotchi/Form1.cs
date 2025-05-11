using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;   

namespace PixelTamagotchi
{
    public partial class Form1 : Form
    {

        private Tamagotchi pet = new Tamagotchi();
        private Timer gameTimer;

        public Form1()
        {
            InitializeComponent();
            int scale = 7;
            picPet.Width = picPet.Image.Width * scale;
            picPet.Height = picPet.Image.Height * scale;
            gameTimer = new Timer { Interval = 2000 }; // Aggiorna ogni 2 secondi
            gameTimer.Tick += (s, e) => { pet.Update(); UpdateUI(); };
            gameTimer.Start();
        }
        private void UpdateUI()
        {
            // Mostra lo stato del Tamagotchi
            lblHappiness.Text = $"Felicità: {pet.Happiness}";
            lblHunger.Text = $"Fame: {pet.Hunger}";
            lblEnergy.Text = $"Energia: {pet.Energy}";

            // Cambia sprite in base allo stato
            if (pet.Energy < 40)
                picPet.Image = Properties.Resources.pet_spleepy;
            else if (pet.Hunger > 70)
                picPet.Image = Properties.Resources.pet_hungry;
            else if (pet.Happiness < 40)
                picPet.Image = Properties.Resources.pet_sad;
            else
                picPet.Image = Properties.Resources.pet_happy;
        }

        private void btnFeed_Click(object sender, EventArgs e)
        {
            pet.Feed();
            UpdateUI();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            pet.Play();
            UpdateUI();
        }

        private void btnSleep_Click(object sender, EventArgs e)
        {
            pet.Sleep();
            UpdateUI();
        }

        private void picPet_Paint(object sender, PaintEventArgs e)
        {
            if (picPet.Image != null)
            {
                // 1. Cancella l'area del PictureBox (fondamentale!)
                e.Graphics.Clear(picPet.BackColor);

                // 2. Imposta la modalità pixel-perfetta
                e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;

                // 3. Ridisegna l'immagine con lo zoom desiderato (es. 4x)
                int scale = 7;
                e.Graphics.DrawImage(
                    picPet.Image,
                    new Rectangle(0, 0, picPet.Image.Width * scale, picPet.Image.Height * scale),
                    new Rectangle(0, 0, picPet.Image.Width, picPet.Image.Height),
                    GraphicsUnit.Pixel
                );
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Tamagotchi File (*.tama)|*.tama";  // Estensione personalizzata
            saveDialog.Title = "Salva il tuo Tamagotchi";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Usa FileStream per creare il file
                    using (FileStream stream = new FileStream(saveDialog.FileName, FileMode.Create))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        formatter.Serialize(stream, pet);  // 'pet' è la tua istanza di Tamagotchi
                    }
                    MessageBox.Show("Tamagotchi salvato con successo!", "Salvataggio riuscito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Errore durante il salvataggio: {ex.Message}", "Errore");
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Tamagotchi File (*.tama)|*.tama";
            openDialog.Title = "Carica un Tamagotchi";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream stream = new FileStream(openDialog.FileName, FileMode.Open))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        pet = (Tamagotchi)formatter.Deserialize(stream);  // Ricarica i dati
                        UpdateUI();  // Aggiorna l'interfaccia
                    }
                    MessageBox.Show("Tamagotchi caricato con successo!", "Caricamento riuscito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Errore durante il caricamento: {ex.Message}", "Errore");
                }
            }
        }
    }
}
