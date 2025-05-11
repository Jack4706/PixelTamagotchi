using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelTamagotchi
{
    [Serializable]
    public class Tamagotchi
    {
        public string Name { get; set; }
        public int Happiness { get; set; } = 50;
        public int Hunger { get; set; } = 50;
        public int Energy { get; set; } = 50;
        public bool IsAlive { get; set; } = true;

        public void Feed()
        {
            Hunger = Math.Max(0, Hunger - 10);
            Happiness = Math.Min(100, Happiness + 5);
        }

        public void Play()
        {
            Happiness = Math.Min(100, Happiness + 10);
            Hunger = Math.Min(100, Hunger + 5);
            Energy = Math.Max(0, Energy - 5);
        }

        public void Sleep()
        {
            Energy = Math.Min(100, Energy + 20);
            Hunger = Math.Min(100, Hunger + 10);
        }

        public void Update()
        {
            Hunger = Math.Min(100, Hunger + 2);
            Energy = Math.Max(0, Energy - 1);
            if (Hunger >= 100 || Energy <= 0) IsAlive = false;
        }
    }
}
