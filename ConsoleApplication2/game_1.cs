/***********************************************************
  * Bradley Massey
  * 9/6/2015
  * C#
  * Game_I
  * 
  * 
  * 
  ***********************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Game_I
{
    class Program
    {
        static void Main(string[] args)
        {
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
            gameSave save;
            playerClass character;
            do
            {
                Console.Write("Do you want to load a game?Y/N");
                string continued = Console.ReadLine();
                char c = Char.ToUpper(continued.FirstOrDefault());
                switch (c)
                {
                    case 'Y':
                        save = loadGame();
                        
                        character = save.player;
                        again = false;
                        break;
                    case 'N':
                        character = newPlayer();
                        again = false;
                        break;
                    default:
                        character = newPlayer();
                        again = false;
                        break;
                }
            } while (again);
            Console.WriteLine("Name: " + character.getName());
            Console.WriteLine(character.getHistory());
            Console.WriteLine(character.getGender());
            /*character.printStat();
            Console.ReadKey();
            Console.WriteLine("\n\n");
            character.upStat("Str", 2);
            character.printStat();
            character.printMoney();
            Console.ReadKey();
            Console.WriteLine("\n\n");
            Console.WriteLine("\n\n");
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
            Console.ForegroundColor = ConsoleColor.White;
            save = new gameSave(character, map);
            saveGame(save);
            Console.ReadKey();

        }
        public static void saveGame(gameSave save)
        {
            bool repeat = false;
            string fileName = "test.dat";
            do
            {
                Console.Write("Which slot do you want to save in?(1 2 3 4)");
                string saveSlot = Console.ReadLine();
                saveSlot = validSave(saveSlot);
                if (saveSlot.CompareTo("no save")==0)
                    { return; }
                char c = Char.ToUpper(saveSlot.FirstOrDefault());
                switch (c)
                {
                    case '1':
                        fileName = "save1.dat";
                        repeat = false;
                        break;
                    case '2':
                        fileName = "save2.dat";
                        repeat = false;
                        break;
                    case '3':
                        fileName = "save3.dat";
                        repeat = false;
                        break;
                    case '4':
                        fileName = "save4.dat";
                        repeat = false;
                        break;
                    default:
                        repeat = true;
                        break;
                }
            } while (repeat);
            System.IO.Stream fs = File.OpenWrite(fileName);

            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(fs, save);

            fs.Flush();
            fs.Close();
            fs.Dispose();

        }
        private static string validSave(string saveSlot)
        {
            int saveNumber;
            bool again = true;
            do
            {
                while (int.TryParse(saveSlot, out saveNumber) == false)
                {
                    Console.WriteLine("You did not enter a valid save slot.");
                    Console.Write("Please enter a valid save slot:");
                    saveSlot = Console.ReadLine();
                }
                if (saveNumber >= 1 && saveNumber <= 4)
                    again = false;
                else
                {
                    Console.WriteLine("You did not enter a valid save slot.");
                    Console.Write("Please enter a valid save slot:");
                    saveSlot = Console.ReadLine();
                }
            } while (again);
            return saveSlot;
        }
        public static gameSave loadGame()
        {
            gameSave save;
            string fileName = "test.dat";
            do
            {
                Console.Write("Which slot do you want to load from?(1 2 3 4)");
                string saveSlot = Console.ReadLine();
                saveSlot = validSave(saveSlot);
                char c = Char.ToUpper(saveSlot.FirstOrDefault());
                switch (c)
                {
                    case '1':
                        fileName = "save1.dat";
                        break;
                    case '2':
                        fileName = "save2.dat";
                        break;
                    case '3':
                        fileName = "save3.dat";
                        break;
                    case '4':
                        fileName = "save4.dat";
                        break;
                    default:
                        break;
                }


                try
                {
                    System.IO.Stream fs = File.Open(fileName, FileMode.Open);

                    BinaryFormatter formatter = new BinaryFormatter();

                    object obj = formatter.Deserialize(fs);
                    save = (gameSave)obj;
                    fs.Flush();
                    fs.Close();
                    fs.Dispose();
                    return save;
                }
                catch (FileNotFoundException save1)//catches if can't find file
                {
                    Console.WriteLine("Could not find that save file.");
                }
                catch (ArgumentException save1)
                {
                    Console.WriteLine("Please enter a file name.");
                }

            } while (true);


        }
        public static playerClass newPlayer()
        {
            playerClass character;
            bool again = true;
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
            return character;
        }
    }
}
