using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_app
{
    using System;

    namespace ExquisiteCorpse
    {
        class Program
        {
            static void Main(string[] args)
            {
                RandomMode();
                Console.ReadLine();
            }
            static void RandomMode()
            {
                Random randomNumber = new Random();
                int first = randomNumber.Next(1, 4);
                int second = randomNumber.Next(1, 4);
                int third = randomNumber.Next(1, 4);

                SwitchCase(first, second, third);
            }
            static void SwitchCase(int head, int body, int feet)
            {
                switch (head)
                {
                    case 1:
                        GhostHead();
                        break;
                    case 2:
                        MonsterHead();
                        break;
                    case 3:
                        BugHead();
                        break;
                }
                switch (body)
                {
                    case 1:
                        GhostBody();
                        break;
                    case 2:
                        MonsterBody();
                        break;
                    case 3:
                        BugBody();
                        break;
                }
                switch (feet)
                {
                    case 1:
                        GhostFeet();
                        break;
                    case 2:
                        MonsterFeet();
                        break;
                    case 3:
                        BugFeet();
                        break;
                }
            }

            static void GhostHead()
            {
                Console.WriteLine("     ..-..");
                Console.WriteLine("    ( o o )");
                Console.WriteLine("    |  O  |");
            }

            static void GhostBody()
            {
                Console.WriteLine("    |     |");
                Console.WriteLine("    |     |");
                Console.WriteLine("    |     |");
            }

            static void GhostFeet()
            {
                Console.WriteLine("    |     |");
                Console.WriteLine("    |     |");
                Console.WriteLine("    '~~~~~'");
            }

            static void BugHead()
            {
                Console.WriteLine("     /   \\");
                Console.WriteLine("     \\. ./");
                Console.WriteLine("    (o + o)");
            }

            static void BugBody()
            {
                Console.WriteLine("  --|  |  |--");
                Console.WriteLine("  --|  |  |--");
                Console.WriteLine("  --|  |  |--");
            }

            static void BugFeet()
            {
                Console.WriteLine("     v   v");
                Console.WriteLine("     *****");
            }

            static void MonsterHead()
            {
                Console.WriteLine("     _____");
                Console.WriteLine(" .-,;='';_),-.");
                Console.WriteLine("  \\_\\(),()/_/");
                Console.WriteLine("　  (,___,)");
            }

            static void MonsterBody()
            {
                Console.WriteLine("   ,-/`~`\\-,___");
                Console.WriteLine("  / /).:.('--._)");
                Console.WriteLine(" {_[ (_,_)");
            }

            static void MonsterFeet()
            {
                Console.WriteLine("    |  Y  |");
                Console.WriteLine("   /   |   \\");
                Console.WriteLine("   \"\"\"\" \"\"\"\"");
            }
        }
    }

}
