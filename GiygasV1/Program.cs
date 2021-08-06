/*-mood
 * sound
 * graphics
 * archive of photos
 * 
*/
using System;
using System.Diagnostics;

namespace GiygasV1
{
    class Program
    {
        static void Main(string[] args)
        {
            //intro sequence will require password not too terminate and continue

            beginSeq();
            iniLoadGraphics();
            iniProtocolInquisition();
            choice();

            //end of ini protocol will inquire a protocol string


            string protocolChoice = Console.ReadLine();


            if (protocolChoice == "system properties")
            {
                sysProp();
            }
            if (protocolChoice == "mood")
            {
                todaysMood();
            }
            if (protocolChoice == "macro1")
            {
                macro1();
            }
            else
            {
                Console.WriteLine("Unknown Protocol Command resetting protocol inquisition");
                iniProtocolInquisition();
            }


        }

        public static void sysProp()
        {

        }

        public static void macro1()
        {
            Process.Start("C:\\Games\\Mr Prepper\\mrprepper.exe");
        }

        public static void todaysMood()
        {

            var date = int.Parse(DateTime.Today.ToString("yyyyMMdd"));

            date = date / 2169;

            if (date % 7 == 1)
            {
                Console.WriteLine(@"

.___  __    .__                   __                      
|   |/  |_  |  |__  __ __________/  |_  ______            
|   \   __\ |  |  \|  |  \_  __ \   __\/  ___/            
|   ||  |   |   Y  \  |  /|  | \/|  |  \___ \             
|___||__|   |___|  /____/ |__|   |__| /____  > /\  /\  /\ 
                 \/                        \/  \/  \/  \/ 



");
            }

            if (date % 7 == 2)
            {
                Console.WriteLine(@"

.___    _____             .__                        .___           
|   | _/ ____\____   ____ |  |     ___________     __| _/           
|   | \   __\/ __ \_/ __ \|  |    /  ___/\__  \   / __ |            
|   |  |  | \  ___/\  ___/|  |__  \___ \  / __ \_/ /_/ |            
|___|  |__|  \___  >\___  >____/ /____  >(____  /\____ | /\  /\  /\ 
                 \/     \/            \/      \/      \/ \/  \/  \/ ");
            }

            if (date % 7 == 3)
            {
                Console.WriteLine(@"

");
            }

            if (date % 7 == 4)
            {
                Console.WriteLine("You cannot grasp the true form of my emotion");
            }

            if (date % 7 == 5)
            {

                Console.WriteLine(@"
     ___   .___  ___________           .__              ________ ________        ________   
 /\   \ \  |   | \_   _____/___   ____ |  |            /  _____/ \_____  \   ____\______ \  
 \/   / /  |   |  |    __)/ __ \_/ __ \|  |           /   \  ___  /   |   \ /  _ \|    |  \ 
 /\   > >  |   |  |     \\  ___/\  ___/|  |__         \    \_\  \/    |    (  <_> )    `   \
 \/   \ \  |___|  \___  / \___  >\___  >____/ /\  /\   \______  /\_______  /\____/_______  /
     _/_/             \/      \/     \/       \/  \/          \/         \/              \/ 
");
            }


        }


        public static void beginSeq()
        {
            

            Console.WriteLine("Hello Philip, Giygas initiation succesfull.");


            for (int i = 0; i <= 70; i++)
            {
                Console.WriteLine(@"|-     |");
            }
            for (int i = 0; i <= 70; i++)
            {
                Console.WriteLine(@"|--    |");
            }
            for (int i = 0; i <= 70; i++)
            {
                Console.WriteLine(@"|---   |");
            }
            for (int i = 0; i <= 70; i++)
            {
                Console.WriteLine(@"|----  |");
            }
            for (int i = 0; i <= 70; i++)
            {
                Console.WriteLine(@"|----- |");
            }
            for (int i = 0; i <= 70; i++)
            {
                Console.WriteLine(@"|------|");
            }

            Console.WriteLine("Please enter password to open protocol library array ");
            Console.Write("Here please----------->");
            String enteredPw = Console.ReadLine();


            if (enteredPw == "Hello Ness")
            {
                Console.WriteLine("*****ACCESS GRANTED CONTINUING PROGRAM*****");

            }
            else
            {
                Console.WriteLine("*****ACCESS DENIED TERMINATING PROGRAM*****");
                Environment.Exit(0);


            }

        }

        public static void iniLoadGraphics()
        {


            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(@"|-                 |");
            }
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(@"|---               |");
            }
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(@"|-------           |");
            }
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(@"|----------        |");
            }
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(@"|-------------     |");
            }
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(@"|----------------- |");
            }
            Console.WriteLine("COMPLETE");

        }



        public static void iniProtocolInquisition()
        {

            Console.WriteLine(@" 
                                 x
                                 │xx
                                 │ xx
                                 │  xx
                           xxxxx │  xx
                        xxx    xx│xxx
                     xx─────────xxx───────────xx
                               xxxxxx     xxxxx
                             xxx │  xxxxx
                            xxx  │  xx
                             xx  │
                              x  │
                              x  │
                              xx │
                               x │
                               x │
                               x │
                               xx│
                                x│
                                x│
                                x│
                                xx
                                 x
                                 x

                GIYGAS INITIATED PROTOCOL PAYLOAD COMPLETE 
                     ENTER PROTOCOL ID WHEN READY
       ┌────────────────────────────────────────────────────┐
 ──────┴────────────────────────────────────────────────────┴──────────
");
            Console.WriteLine(@"Protocol List:


system properties

mood

macro1

Initiate:

");







        }

        public static void choice()
        {
            string choicePick = Console.ReadLine();



            if(choicePick == "mood")
            {
                Console.WriteLine(@"Mood protocol selected running

");
                iniLoadGraphics();

                Console.WriteLine(@"Todays mood:

");

                todaysMood();
            }

           
        }
    }

}
