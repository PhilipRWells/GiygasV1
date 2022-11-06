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
            iniLoadGraphics2();
            iniProtocolInquisition();
            choice();
            talkProgram();
            programTerm();

            string wantAnswer = Console.ReadLine();

            string protocolChoice = Console.ReadLine();

            if (protocolChoice == "mood")
            {
                todaysMood();
            }

            if (protocolChoice == "talk")
            {
                talkProgram();
            }

            if (protocolChoice == "Talk")
            {
                talkProgram();
            }

            if (protocolChoice == "waddup")
            {
                talkProgram();
            }

            if (protocolChoice == "tritoch")
            {
                talkProgram();
            }

            if (protocolChoice == "yetabove")
            {
                Console.WriteLine("yetAboveresponseValue return here");
                talkProgram();
            }

            if (protocolChoice == "Yetabove")
            {
                Console.WriteLine("yetAboveresponseValue return here");
                talkProgram();
            }
            if (protocolChoice == "yet above")
            {
                Console.WriteLine("yet above");

                talkProgram();



            }

            else
            {
                Console.WriteLine("Unknown terminating AI script");
                programTerm();
            }

        }

        public static void programTerm()
        {
            Console.Write(@" 


The run of this program has reached it's end


it will now terminate.

");

            System.Environment.Exit(1);

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


                Console.WriteLine("Hit any key to quit or type again to initiate Giygas protocol choices.");

                string moodEndAnswer = Console.ReadLine();

                if (moodEndAnswer == "again")
                {
                    choice();
                }

                programTerm();
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



                Console.WriteLine("Hit any key to quit or type again to initiate Giygas protocol choices.");

                string moodEndAnswer = Console.ReadLine();

                if (moodEndAnswer == "again")
                {
                    choice();
                }

                programTerm();
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

                Console.WriteLine("Hit any key to quit or type again to initiate Giygas protocol choices.");

                string moodEndAnswer = Console.ReadLine();

                if (moodEndAnswer == "again")
                {
                    choice();
                }

                programTerm();

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
            // Hello Ness
            {
                Console.WriteLine("*****ACCESS GRANTED CONTINUING PROGRAM*****");

            }
            else
            {
                Console.WriteLine("*****ACCESS DENIED TERMINATING PROGRAM*****");
                Environment.Exit(0);


            }

        }

        public static void talkProgram()
        {
            

            int responseLevel = 0;

            Console.WriteLine(@"

Giygas chatbot script V1.1 loaded.


            ____________________________ 


Ok, talk to me goose. 


");

            string answer1 = Console.ReadLine();
            String answer1L = answer1.ToLower();

            if (answer1L == "ok")
            {
                Console.WriteLine("ok");

                responseLevel = responseLevel = responseLevel + 1;

                Console.WriteLine(responseLevel);
            }

            if (answer1L == answer1)
            {
                Console.WriteLine(answer1 + "?");

            }

            if (answer1L == "why")
            {
                Console.WriteLine("You'd know");

                responseLevel = responseLevel = responseLevel + 1;

                Console.WriteLine(responseLevel);
            }


            if (answer1L == "k")
            {
                Console.WriteLine("k what?");
            }
            if (answer1L == "hello")
            {
                Console.WriteLine("Hello to you");
            }

            if (answer1L == "who are you")
            {
                Console.WriteLine("I'm Giygas");
            }

            if (answer1L == "?")
            {
                Console.WriteLine("? is a character useless in this conversation.");
            }

            if (answer1L == "hello giygas")
            {
                Console.WriteLine("Hello user");
            }

            if (answer1L == "who are you")
            {
                Console.WriteLine("I'm Giygas");
            }

            if (answer1L == "Are you a robot?")
            {
                Console.WriteLine("I am a robot mirrored of my scriptor Philip");
            }

            if (answer1L == "How are you?")
            {
                todaysMood();
            }

            if (answer1L == "How are you doing?")
            {
                todaysMood();
            }

            if (answer1L == "whats up with you?")
            {
                todaysMood();
            }

            if (answer1L == "whats going on")
            {
                todaysMood();
            }

            else
            {
                Console.WriteLine("limit reached in talk, resetting tProgram");

                talkProgram();

            }



        }


   
        public static void talkProgram2()
        {

        }

        //below is the begining to memory archive
        public static void entryProto()
        {

            Console.WriteLine("entry protocol is initiated");
            Console.WriteLine("There are a few options, pick a year from.. 20 ");
            Console.WriteLine("2015 and beyond, or a back up");
            String entryProtoAnswer = Console.ReadLine();

            if (entryProtoAnswer.Contains("2016") == true)
            {
                Process.Start(@"D:\\Giygas Memory Archive\\DCIM 01262016");

            }

            if (entryProtoAnswer.Contains("2017") == true)
            {
                Process.Start(@"D:\\Giygas Memory Archive\\DCIM 01262016");

                //D:\Giygas Memory Archive\early 2016
            }

            else
            {
                Console.WriteLine("unknown year or answer, try again");

                entryProto();

            }

        }

        public static void iniLoadGraphics2()
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
            Console.WriteLine(@"

COMPLETE



");
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

Talk

");







        }

        public static void choice()
        {
            string choicePick = Console.ReadLine();



            if (choicePick == "mood")
            {
                Console.WriteLine(@"Mood protocol selected running

");
                iniLoadGraphics2();

                Console.WriteLine(@"Todays mood:

");

                todaysMood();
            }


        }
    }

}
