using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trelagsmodellen
{
    public enum PickaxeType
    {
        Iron,
        Copper,
        Bronze,
        Diamond
    }

    class Pickaxe
    {
        private PickaxeType pickaxeType;
        public PickaxeType PickaxeType
        {
            get { return pickaxeType; }
            set { pickaxeType = value; }
        }

        private int strength;
        public int Strength
        {
            get { return strength; }
            set { strength = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Pickaxe(string name, PickaxeType type)
        {
            PickaxeType = type;
            Strength = CalculateStrength(type);
            Name = name;
        }

        private int CalculateStrength(PickaxeType type)
        {
            switch (type)
            {
                case PickaxeType.Iron:
                    return 100;

                case PickaxeType.Copper:
                    return 200;

                case PickaxeType.Bronze:
                    return 300;

                case PickaxeType.Diamond:
                    return 400;
            }

            // something broke
            return 0;
        }
    }
}