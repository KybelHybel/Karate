using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalApp
{
    class Menu
    {
        public void MenuOptions() 
        {
            while (true)
            {
                Console.Clear();
                Console.Write("<1> vypis trenery\n<2> pridej trenera\n<3> ukoncit\n");
                Console.Write("#:");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int option)) {
                    switch (option)
                    {
                        case 1:
                            var treneris = new TrenerC();
                            treneris.Print();
                            break;
                        case 2:
                            var addtrener = new AddTrenerC();
                            addtrener.Add();
                            break;
                        case 3:

                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("spatna volba");
                            Console.ReadKey();
                            break;
                    }
                }
            }

        }
    }
}
