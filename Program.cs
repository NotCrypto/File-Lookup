using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using Notepad.Util;



namespace Notepad
{
    class Program 
    {
        private string lastResult;
        private int lastCount;

        static void Main(string[] args)
        {
            Console.Title = "Search Engine - Made by HollandsHoekje";
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                                                                                                              ║");              
            Console.WriteLine("║      ██╗░░██╗░█████╗░██╗░░░░░██╗░░░░░░█████╗░███╗░░██╗██████╗░░██████╗  ██╗░░░░░░█████╗░░█████╗░██╗░░██╗██╗░░░██╗██████╗░    ║");
            Console.WriteLine("║      ██║░░██║██╔══██╗██║░░░░░██║░░░░░██╔══██╗████╗░██║██╔══██╗██╔════╝  ██║░░░░░██╔══██╗██╔══██╗██║░██╔╝██║░░░██║██╔══██╗    ║");
            Console.WriteLine("║      ███████║██║░░██║██║░░░░░██║░░░░░███████║██╔██╗██║██║░░██║╚█████╗░  ██║░░░░░██║░░██║██║░░██║█████═╝░██║░░░██║██████╔╝    ║");
            Console.WriteLine("║      ██╔══██║██║░░██║██║░░░░░██║░░░░░██╔══██║██║╚████║██║░░██║░╚═══██╗  ██║░░░░░██║░░██║██║░░██║██╔═██╗░██║░░░██║██╔═══╝░    ║");
            Console.WriteLine("║      ██║░░██║╚█████╔╝███████╗███████╗██║░░██║██║░╚███║██████╔╝██████╔╝  ███████╗╚█████╔╝╚█████╔╝██║░╚██╗╚██████╔╝██║░░░░░    ║");
            Console.WriteLine("║      ╚═╝░░╚═╝░╚════╝░╚══════╝╚══════╝╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░╚═════╝░  ╚══════╝░╚════╝░░╚════╝░╚═╝░░╚═╝░╚═════╝░╚═╝░░░░░    ║");
            Console.WriteLine("║                                                                                                                              ║");
            Console.WriteLine("║                                                                                                                              ║");
            Console.WriteLine("║                                            Created by | Sir Sloth | NotCrypto.                                               ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine("╔══════════════════════════════════════════════════════╗                                                     ");
            Console.WriteLine(" 		Type your Login Credentials				                                                            ");
            Console.WriteLine("╚══════════════════════════════════════════════════════╝                                         ");
            string us = getInput(" Username:");
            Console.WriteLine("  ");
            string pw = getInput(" Password: ");
            Login lg = new Login(us, pw);
            Console.Clear();

            if (lg.isPassword())
            {
                Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                                                                                                                              ║");
                Console.WriteLine("║      ██╗░░██╗░█████╗░██╗░░░░░██╗░░░░░░█████╗░███╗░░██╗██████╗░░██████╗  ██╗░░░░░░█████╗░░█████╗░██╗░░██╗██╗░░░██╗██████╗░    ║");
                Console.WriteLine("║      ██║░░██║██╔══██╗██║░░░░░██║░░░░░██╔══██╗████╗░██║██╔══██╗██╔════╝  ██║░░░░░██╔══██╗██╔══██╗██║░██╔╝██║░░░██║██╔══██╗    ║");
                Console.WriteLine("║      ███████║██║░░██║██║░░░░░██║░░░░░███████║██╔██╗██║██║░░██║╚█████╗░  ██║░░░░░██║░░██║██║░░██║█████═╝░██║░░░██║██████╔╝    ║");
                Console.WriteLine("║      ██╔══██║██║░░██║██║░░░░░██║░░░░░██╔══██║██║╚████║██║░░██║░╚═══██╗  ██║░░░░░██║░░██║██║░░██║██╔═██╗░██║░░░██║██╔═══╝░    ║");
                Console.WriteLine("║      ██║░░██║╚█████╔╝███████╗███████╗██║░░██║██║░╚███║██████╔╝██████╔╝  ███████╗╚█████╔╝╚█████╔╝██║░╚██╗╚██████╔╝██║░░░░░    ║");
                Console.WriteLine("║      ╚═╝░░╚═╝░╚════╝░╚══════╝╚══════╝╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░╚═════╝░  ╚══════╝░╚════╝░░╚════╝░╚═╝░░╚═╝░╚═════╝░╚═╝░░░░░    ║");
                Console.WriteLine("║                                                                                                                              ║");
                Console.WriteLine("║                                                                                                                              ║");
                Console.WriteLine("║                                            Created by | Sir Sloth | NotCrypto.                                               ║");
                Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("  ");
                Console.WriteLine("  ");
                Console.WriteLine("  ");
                Console.WriteLine("  ");
                Console.WriteLine("  ");
                Console.WriteLine("  ");
                Console.WriteLine("  ");
                Console.WriteLine("╔══════════════════════════════════════════════════════╗                                                     ");
                Console.WriteLine(" 		Type your Database Name!				                                                            ");
                Console.WriteLine("╚══════════════════════════════════════════════════════╝ ");
    

                    string path = getInput("Database: ");

                if (us.Equals("encrypt"))
                {
                    new Program().StartCrypt($"{path}.txt", true);
                }
                else

                if (us.Equals("decrypt"))
                {
                    new Program().StartCrypt($"{path}.txt", false);
                }
                else

                if (lg.isSuccess()) new Program().StartReading(path.Split(' ')[0] + ".txt", path.Contains("--encrypted")); else Environment.Exit(0);
                
            }
        }

        private void StartReading(string path, bool encrypted)
        {
            Console.Clear();
            try
            {

                Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                                                                                                                              ║");
                Console.WriteLine("║      ██╗░░██╗░█████╗░██╗░░░░░██╗░░░░░░█████╗░███╗░░██╗██████╗░░██████╗  ██╗░░░░░░█████╗░░█████╗░██╗░░██╗██╗░░░██╗██████╗░    ║");
                Console.WriteLine("║      ██║░░██║██╔══██╗██║░░░░░██║░░░░░██╔══██╗████╗░██║██╔══██╗██╔════╝  ██║░░░░░██╔══██╗██╔══██╗██║░██╔╝██║░░░██║██╔══██╗    ║");
                Console.WriteLine("║      ███████║██║░░██║██║░░░░░██║░░░░░███████║██╔██╗██║██║░░██║╚█████╗░  ██║░░░░░██║░░██║██║░░██║█████═╝░██║░░░██║██████╔╝    ║");
                Console.WriteLine("║      ██╔══██║██║░░██║██║░░░░░██║░░░░░██╔══██║██║╚████║██║░░██║░╚═══██╗  ██║░░░░░██║░░██║██║░░██║██╔═██╗░██║░░░██║██╔═══╝░    ║");
                Console.WriteLine("║      ██║░░██║╚█████╔╝███████╗███████╗██║░░██║██║░╚███║██████╔╝██████╔╝  ███████╗╚█████╔╝╚█████╔╝██║░╚██╗╚██████╔╝██║░░░░░    ║");
                Console.WriteLine("║      ╚═╝░░╚═╝░╚════╝░╚══════╝╚══════╝╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░╚═════╝░  ╚══════╝░╚════╝░░╚════╝░╚═╝░░╚═╝░╚═════╝░╚═╝░░░░░    ║");
                Console.WriteLine("║                                                                                                                              ║");
                Console.WriteLine("║                                                                                                                              ║");
                Console.WriteLine("║                                            Created by | Sir Sloth | NotCrypto.                                               ║");
                Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("  ");
                Console.WriteLine("  ");
                Console.WriteLine("  ");
                Console.WriteLine("  ");
                Console.WriteLine("  ");
                Console.WriteLine("  ");
                Console.WriteLine("  ");
                Console.WriteLine("╔══════════════════════════════════════════════════════╗                                                     ");
                Console.WriteLine(" 	        File information			                                                            ");
                Console.WriteLine("╚══════════════════════════════════════════════════════╝ ");


                int lenght = File.ReadAllLines(path).Length;
                Console.WriteLine($"List Length: {lenght}");
                Console.WriteLine($"File Encrypted: {encrypted}");
                if (lastResult != null) Console.WriteLine($"Last Search: {lastResult}\nLast Results: {lastCount}");

                string search = getInput("\nZoeken: ");

                this.read(search, path, encrypted);
                this.StartReading(path, encrypted);
            } catch(FileNotFoundException e)
            {
                Console.WriteLine("Kon geen file vinden!.");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }

        void StartCrypt(string path, bool b)
        {
            string newPath = getInput("Bestand naam: ");
            FileStream str = File.OpenRead(path);
            Console.WriteLine($"Writing to {newPath}...");
            this.write(str, $"{newPath}.txt", b);
        }

        private async void read(string search, string path, bool encrypted)
        {
            lastCount = 0;
            FileStream stream = File.OpenRead(path);
            using (StreamReader reader = new StreamReader(stream)) 
            {
                string El;
                while ((El = reader.ReadLine()) != null)
                {
                    var dE = "";
                    if (encrypted) dE = Encrypt.decodeToString(El); else dE = El;
                    if (dE.Contains(search))
                    {
                        Console.WriteLine(dE);
                        lastCount++;
                    }
                }
            }
            this.lastResult = search;
            Console.Write("Klik op enter om verder te gaan.");
            Console.ReadKey();
            Console.Clear();
        }

        private async void write(FileStream db, string path, bool encrypt)
        {
            int count = 0;
            StreamWriter wr = File.CreateText(path);
            using(StreamReader rdr = new StreamReader(db))
            {
                string l;
                while((l = rdr.ReadLine()) != null)
                {
                    string value = "";
                    switch(encrypt)
                    {
                        case true:
                            value = Encrypt.encodeToString(l);
                            break;
                        case false:
                            value = Encrypt.decodeToString(l);
                            break;
                    };

                    wr.WriteLine(value);
                    count++;
                }
            }


            Console.WriteLine($"Succesvol Encrypted Algorithm used [TRIPPLEDES] : {count} IPs");
            Console.ReadKey();
            Environment.Exit(0);
        }

        private static string getInput(string msg)
        {
            Console.Write(msg);
            return Console.ReadLine();
        }
    }
}
