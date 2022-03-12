using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3_1302204075
{
    internal class PosisiKarakterGame
    {
        enum State { TombolS, TombolW, Exit };

        public static void Mulai()
        {
            Console.WriteLine("Masukan State");
            State state = State.TombolS;
            while (state != State.Exit)
            {
                string command = Console.ReadLine();
                switch (command)
                {
                    case "TombolS":
                        Console.WriteLine("tombol arah bawah ditekan");
                        Console.WriteLine();
                        break;
                    case "TombolW":
                        Console.WriteLine("tombol arah atas ditekan");
                        Console.WriteLine();
                        break;
                    case "Exit":
                        state = State.Exit;
                        break;
                    default:
                        Console.WriteLine("Masukan Ulang State");
                        break;

                }
            }
        }
    }
}
