using System;

namespace MyConsole
{
    //новая ветка
    internal class Program
    {
        static void Main(string[] args)
        {
            //levels= new List<decimal>();
            WriteLine();


            string str = RedLine("set lower praice: ");

            praiceDown = decimal.Parse(str);

            //countLevels=Convert.ToInt32(str);

            str = RedLine("set upper praice: ");

            praiceUp = decimal.Parse(str);

            str = RedLine("enter step levels: ");


            StepLevel = decimal.Parse(str);



            WriteLine();
            if (Levels > 0)
                praiceY_1 = praiceDown + ((praiceUp - praiceDown) / Levels);

            Console.WriteLine(Math.Round(praiceY_1, 4).ToString() + " Praice: 1");
            WriteLineY();



            Console.ReadLine();


        }
        //################################ поля ################################################
        #region Fields  

        static decimal praiceUp;
        static decimal praiceDown;
        static decimal praiceY;
        static decimal praiceY_1;
        static int Levels;
        static int countY = 1;
        //------------------
        static decimal stepLevel;

        #endregion
        //################################ методы ####################################################
        #region Metods
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
                if (countY <= Levels)
                    Console.WriteLine(Math.Round(praiceY, 4).ToString() + " Praice: " + countY.ToString());
            }



        }
        static string RedLine(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine(); ;
        }
        #endregion
        //################################ свойства #################################################
        #region Properties
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
        #endregion

        static Trade Trade = new Trade();
        //------------------передача цены в конструктор---------------------------
        static Levels level = new Levels(1000);

    }

}
