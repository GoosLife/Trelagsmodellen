using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trelagsmodellen
{
    class Miner
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private Pickaxe pickaxe;
        public Pickaxe Pickaxe
        {
            get { return pickaxe; }
            set { pickaxe = value; }
        }

        public Miner(string name, Pickaxe pickaxe)
        {
            Name = name;
            Pickaxe = pickaxe;
        }
    }
}