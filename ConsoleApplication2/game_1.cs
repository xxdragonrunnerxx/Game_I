using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Game_I
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowPosition(0, 0);
            Console.SetWindowSize(Console.LargestWindowWidth - 5, Console.LargestWindowHeight - 5);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"                                         ,   ,  ");
            Console.WriteLine(@"                                         $,  $,     ,");
            Console.WriteLine(@"                                         'ss.$ss. .s'     ");
            Console.WriteLine(@"                                 ,     .ss$$$$$$$$$$s,          ");
            Console.Write(@"                                 $. s$$$$$$$$$$$$$$");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(@"^");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"$$Ss");
            Console.WriteLine(@"                                 '$$$$$$$$$$$$$$$$$$$$$$       ,");
            Console.WriteLine(@"                                s$$$$$$$$$$$$$$$$$$$$$$$$s,  ,s");
            Console.WriteLine(@"                               s$$$$$$$$$'$$$$$$''''$$$$$$'$$$$$,");
            Console.WriteLine(@"                               s$$$$$$$$$$s''$$$$ssssss'$$$$$$$$'");
            Console.WriteLine(@"                              s$$$$$$$$$$'         `'''ss'$'$s''");
            Console.WriteLine(@"                              s$$$$$$$$$$,              `'''''$  .s$$s");
            Console.WriteLine(@"                              s$$$$$$$$$$$$s,...               `s$$'  `");
            Console.WriteLine(@"                          `ssss$$$$$$$$$$$$$$$$$$$$####s.     .$$'$.   , s-");
            Console.WriteLine(@"                            `''''$$$$$$$$$$$$$$$$$$$$#####$$$$$$'     $.$'");
            Console.WriteLine(@"                                  '$$$$$$$$$$$$$$$$$$$$$####s''     .$$$|");
            Console.WriteLine(@"                                   '$$$$$$$$$$$$$$$$$$$$$$$$##s    .$$' $ ");
            Console.WriteLine(@"                                    $$''$$$$$$$$$$$$$$$$$$$$$$$$$$$$$'   `");
            Console.WriteLine(@"                                   $$'  '$'$$$$$$$$$$$$$$$$$$$$S''''' ");
            Console.WriteLine(@"                              ,   ,'     '  $$$$$$$$$$$$$$$$####s  ");
            Console.WriteLine(@"                              $.          .s$$$$$$$$$$$$$$$$$####'");
            Console.WriteLine(@"                  ,           '$s.   ..ssS$$$$$$$$$$$$$$$$$$$####'");
            Console.WriteLine(@"                  $           .$$$S$$$$$$$$$$$$$$$$$$$$$$$$#####'");
            Console.WriteLine(@"                  Ss     ..sS$$$$$$$$$$$$$$$$$$$$$$$$$$$######''");
            Console.WriteLine(@"                   '$$sS$$$$$$$$$$$$$$$$$$$$$$$$$$$########'");
            Console.WriteLine(@"            ,      s$$$$$$$$$$$$$$$$$$$$$$$$#########'''");
            Console.WriteLine(@"            $    s$$$$$$$$$$$$$$$$$$$$$#######'''      s'         ,");
            Console.WriteLine(@"            $$..$$$$$$$$$$$$$$$$$$######''       ....,$$....    ,$");
            Console.WriteLine(@"             '$$$$$$$$$$$$$$$######'' ,     .sS$$$$$$$$$$$$$$$$s$$");
            Console.WriteLine(@"               $$$$$$$$$$$$#####'     $, .s$$$$$$$$$$$$$$$$$$$$$$$$s.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(@"    )          ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"$$$$$$$$$$$#####'      `$$$$$$$$$###########$$$$$$$$$$$.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(@"   ((          ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"$$$$$$$$$$$#####       $$$$$$$$###'       '####$$$$$$$$$$ ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(@"   ) \         ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"$$$$$$$$$$$$####.     $$$$$$###'             '###$$$$$$$$$   s'");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(@"  (   )        ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"$$$$$$$$$$$$$####.   $$$$$###'                ####$$$$$$$$s$$'");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(@"  )  ( (       ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"$$'$$$$$$$$$$$#####.$$$$$###'                .###$$$$$$$$$$'");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(@"  (  )  )   ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"_,$'   $$$$$$$$$$$$######.$$##'                .###$$$$$$$$$$");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(@"  ) (  ( \.");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"         '$$$$$$$$$$$$$#######,,,.          ..####$$$$$$$$$$$'");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(@" (   )");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(@"$");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(@")  )        ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@",$$$$$$$$$$$$$$$$$$####################$$$$$$$$$$$'");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(@" (   (");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(@"$$  ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(@"( \     ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"_sS'  `'$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$S$$,      ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(@"  )  )");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(@"$$$s ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(@") )  ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@".      .   `$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$''  `$$   ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(@"   (   ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(@"$$$Ss");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(@"/  ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@".$,    .$,,s$$$$$$##S$$$$$$$$$$$$$$$$$$$$$$$$S''        ' ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(@"     \)_");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"$$$$$$$$$$$$$$$$$$$$$$$##'  $$        `$$.        `$$.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(@"         `'");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"S$$$$$$$$$$$$$$$$$#'      $          `$          `$");
            Console.WriteLine(@"             `''''''''''''''         '           '           '");
            Console.WriteLine("\n\n");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"             ___                               __    __     _ _ ");
            Console.WriteLine(@"            /   \_ __ __ _  __ _  ___  _ __   / / /\ \ \___| | |");
            Console.WriteLine(@"           / /\ / '__/ _` |/ _` |/ _ \| '_ \  \ \/  \/ / _ \ | |");
            Console.WriteLine(@"          / /_//| | | (_| | (_| | (_) | | | |  \  /\  /  __/ | |");
            Console.WriteLine(@"         /___,' |_|  \__,_|\__, |\___/|_| |_|   \/  \/ \___|_|_|");
            Console.WriteLine(@"                           |___/                                ");
            Console.ForegroundColor = ConsoleColor.White;
            /*Console.WriteLine(@" _______  _______  _______  _______            _________");
            Console.WriteLine(@"(  ____ \(  ___  )(       )(  ____ \           \__   __/");
            Console.WriteLine(@"| (    \/| (   ) || () () || (    \/              ) (   ");
            Console.WriteLine(@"| |      | (___) || || || || (__       _____      | |   ");
            Console.WriteLine(@"| | ____ |  ___  || |(_)| ||  __)     (_____)     | |   ");
            Console.WriteLine(@"| | \_  )| (   ) || |   | || (                    | |   ");
            Console.WriteLine(@"| (___) || )   ( || )   ( || (____/\           ___) (___");
            Console.WriteLine(@"(_______)|/     \||/     \|(_______/           \_______/");*/
            Console.WriteLine("\n\n");
            bool again = true;
            playerClass character;
            do
            {
                character = playerClass.newPlayer();
                Console.WriteLine("Name: " + character.getName());
                Console.WriteLine(character.getHistory());
                Console.WriteLine(character.getGender());
                if (!playerClass.newCharacter())
                    break;
                Console.Write("(C)ontinue?(Y)es or (N)o?");
                string continued = Console.ReadLine();
                char c = Char.ToUpper(continued.FirstOrDefault());
                switch (c)
                {
                    case 'C':
                        again = false;
                            break;
                    case 'Y':
                        again = false;
                        break;
                    case 'N':
                        break;
                    default:
                        again = false;
                        break;
                }
            } while (again && playerClass.newCharacter());
            character.printStat();
            Console.ReadKey();
            Console.WriteLine("\n\n");
            character.upStat("Str", 2);
            character.printStat();
            character.printMoney();
            /*Console.WriteLine("\n\n");
            Console.ReadKey();
            playerClass boss = new playerClass(5, "male");
            Console.WriteLine("Name: " + boss.getName());
            Console.WriteLine(boss.getHistory());
            Console.WriteLine(boss.getGender());
            boss.printStat();
            Console.WriteLine("\n\n");
            Console.ReadKey();
            playerClass boss2 = new playerClass(5, "female");
            Console.WriteLine("Name: " + boss2.getName());
            Console.WriteLine(boss2.getHistory());
            Console.WriteLine(boss2.getGender());
            boss2.printStat();
            Console.WriteLine("\n\n");
            Console.ReadKey();*/
            board map = new board(dieroller.totalRoll(35, 2), dieroller.totalRoll(50, 3), false);
            map.printBoard();
            Console.ReadKey();
            Console.WriteLine("\n\n");
            board map2 = new board(60, 80, true);
            map2.printBoard();            
            Console.ReadKey();

        }

    }
}
