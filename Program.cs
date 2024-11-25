using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //levels= new List<decimal>();
            WriteLine();
            

           string str= RedLine("set lower praice: ");

            praiceDown = decimal.Parse(str);

            //countLevels=Convert.ToInt32(str);

            str = RedLine("set upper praice: ");
            
            praiceUp = decimal.Parse(str);

            str = RedLine("enter step levels: ");
            

            StepLevel= decimal.Parse(str);

            

            WriteLine();
            if (Levels > 0)
                praiceY_1 = praiceDown + ((praiceUp - praiceDown) / Levels);
            
            Console.WriteLine(Math.Round(praiceY_1, 4).ToString() + " Praice: 1");
            WriteLineY();
            


            Console.ReadLine();


        }
        //static List<decimal> levels;
        static decimal praiceUp;
        static decimal praiceDown;
        static decimal praiceY;
        static decimal praiceY_1;
        // static int countLevels;
        static int Levels;
        static int countY=1;

        static decimal stepLevel;
        static void WriteLine()
        {
       
            if (StepLevel > 0)
                Levels = (int)((int)(praiceUp - praiceDown) / StepLevel);
            Console.WriteLine("numbers of elements in the list: " + Levels.ToString());
           

        }
        static void WriteLineY()
        {
            for (int i = 0; i <= Levels; i++)
            {
                if (Levels > 0)
                {
                    

                    countY++;
                    praiceY = praiceDown + ((praiceUp - praiceDown) / Levels) * countY;

                }
                if(countY<= Levels)
                Console.WriteLine(Math.Round(praiceY, 4).ToString() + " Praice: " + countY.ToString());
            }



        }

        static decimal StepLevel
        {
            get
            {

                return stepLevel;
            }

            set
            { 
                stepLevel = value;
                decimal praicelevel = praiceUp;

                
            }
        }
        

        static string RedLine(string message)
        {
            Console.WriteLine(message);
             return Console.ReadLine(); ;
        }
    }
}
