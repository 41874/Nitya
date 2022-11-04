using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madlib
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Scary Time!!!";
            Console.Read();

            Console.WriteLine("--------");
            Console.WriteLine("Madlib!");
            Console.WriteLine("-------");

           
            string TitleText = @"
           
                  
('-. .-.  ('-.                                   (`\ .-') /`  ('-.    ('-.      .-') _         .-')   .-') _              _  .-')              
( OO )  / ( OO ).-.                                `.( OO ),'_(  OO) _(  OO)    ( OO ) )       ( OO ).(  OO) )            ( \( -O )             
,--. ,--. / . --. /,--.     ,--.     .-'),-----.,--./  .--. (,------(,------,--./ ,--,'       (_)---\_/     '._ .-'),-----.,------.  ,--.   ,--.
|  | |  | | \-.  \ |  |.-') |  |.-')( OO'  .-.  |      |  |  |  .---'|  .---|   \ |  |\       /    _ ||'--...__( OO'  .-.  |   /`. '  \  `.'  / 
|   .|  .-'-'  |  ||  | OO )|  | OO /   |  | |  |  |   |  |, |  |    |  |   |    \|  | )      \  :` `.'--.  .--/   |  | |  |  /  | |.-')     /  
|       |\| |_.'  ||  |`-' ||  |`-' \_) |  |\|  |  |.'.|  |_(|  '--.(|  '--.|  .     |/        '..`''.)  |  |  \_) |  |\|  |  |_.' (OO  \   /   
|  .-.  | |  .-.  (|  '---.(|  '---.' \ |  | |  |         |  |  .--' |  .--'|  |\    |        .-._)   \  |  |    \ |  | |  |  .  '.'|   /  /\_  
|  | |  | |  | |  ||      | |      |   `'  '-'  |   ,'.   |  |  `---.|  `---|  | \   |        \       /  |  |     `'  '-'  |  |\  \ `-./  /.__) 
`--' `--' `--' `--'`------' `------'     `-----''--'   '--'  `------'`------`--'  `--'         `-----'   `--'       `-----'`--' '--'  `--'      
                                                                                                                                                                ";



            Console.WriteLine(TitleText);
            Console.Write("Press any key to continue");
            Console.ReadKey();


            string adjective1;
            string adjective2;
            string adjective3;
            string adjective6;
            string adjective11;
            
            string animal4;

            string noun5;
            string noun9;
            string noun12;
            string noun13;
            
            string food7;

            string verb8;

            string adverb10;

            string story;

            Console.Write("Please enter a Adjective: ");
             adjective1= Console.ReadLine();
            Console.Write("Please enter a Adjective: ");
            adjective2 = Console.ReadLine();
            Console.Write("Please enter a Adjective: ");
            adjective3 = Console.ReadLine();
            Console.Write("Please enter a Adjective: ");
            adjective6 = Console.ReadLine();
            Console.Write("Please enter a Adjective: ");
            adjective11 = Console.ReadLine();

            Console.Write("Please enter a Animal: ");
            animal4 = Console.ReadLine();

            Console.Write("Please enter a Noun: ");
            noun5 = Console.ReadLine();
            Console.Write("Please enter a Noun: ");
            noun9 = Console.ReadLine();
            Console.Write("Please enter a Noun: ");
            noun12 = Console.ReadLine();
            Console.Write("Please enter a Noun: ");
            noun13 = Console.ReadLine();

            Console.Write("Please enter a Verb: ");
            verb8 = Console.ReadLine();

            Console.Write("Please enter a Adverb: ");
            adverb10= Console.ReadLine();

            Console.Write("Please enter any Food: ");
            food7 = Console.ReadLine();


            story = "\nOne " + adjective1 + "," + adjective2 + " night, no stars in sight." + "\nThunder roared a " + adjective3 + " hello; lighting flashed the trees below." + "\nThe sound of a/an " + animal4 + " could be heard in the distance." +
                      " It was Halloween night. I was dressed as a " + noun5 + "." + " \nMy bag was beside me filled with " + adjective6 + " " + food7 + " that I couldn't wait to eat." +
                         " \nAs I " + verb8 + " up the driveway of the house to trick or treat, I wonder what type of " + noun9 + " I will get. \nI ring the doorbell with " + adverb10 +
                           " It opens and a " + adjective11 + " man wearing a " + noun12 + " looks at me." +
                        
                           "\nI scream trick or treat, I like " + noun13 +".";


            Console.WriteLine(story);

            Console.ReadKey();



        }
    }
}
