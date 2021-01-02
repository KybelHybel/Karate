using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using DataLayer.Persist;
//using BusinessLayer.Table;

namespace TerminalApp
{
    class Login
    {
        public static string ReadPassword()
        {
            string password = "";
            ConsoleKeyInfo info = Console.ReadKey(true);
            while (info.Key != ConsoleKey.Enter)
            {
                if (info.Key != ConsoleKey.Backspace)
                {
                    Console.Write("*");
                    password += info.KeyChar;
                }
                else if (info.Key == ConsoleKey.Backspace)
                {
                    if (!string.IsNullOrEmpty(password))
                    {
                        // remove one character from the list of password characters
                        password = password.Substring(0, password.Length - 1);
                        // get the location of the cursor
                        int pos = Console.CursorLeft;
                        // move the cursor to the left by one character
                        Console.SetCursorPosition(pos - 1, Console.CursorTop);
                        // replace it with space
                        Console.Write(" ");
                        // move the cursor to the left by one character again
                        Console.SetCursorPosition(pos - 1, Console.CursorTop);
                    }
                }
                info = Console.ReadKey(true);
            }
            // add a new line because user pressed enter at the end of their password
            Console.WriteLine();
            return password;
        }
        public void LoginToDb() {

            Console.Write("Zadej prijmeni: ");
            string lastname1 = Console.ReadLine();

            Console.Write("Zadej heslo: ");
            string password1 = ReadPassword();

            var t = TrenerSingleton.Instance.SelectLoginPwd(DbPersist.Instance.Db, lastname1, password1);
            if (t == null)
            {
                Console.WriteLine("Zadal jsi sptane informace");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Proběhlo uspěšné přihlašení");
            Console.ReadKey();
            var menu = new Menu();
            menu.MenuOptions();
        }
    }
}
