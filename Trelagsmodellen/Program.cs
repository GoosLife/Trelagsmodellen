using System;

namespace Trelagsmodellen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Miner miner = new Miner("Neil", new Pickaxe("myPickaxe", PickaxeType.Diamond));

            Console.WriteLine(miner.Name + ' ' + miner.Pickaxe.PickaxeType.ToString());
            Console.ReadKey();
        }
    }
}