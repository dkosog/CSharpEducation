namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ///<summary>
            ///Первое задание.
            ///</summary>
            void GetVariables()
            {
                int Age;
                string FirstName;
                string CompanyName;
                bool LogicalVariable;
                float PersonWeight;
            }

            ///<summary>
            ///Второе задание.
            ///</summary>
            void GetValues()
            {
                int MyAge = 42;
                string FirstName = "Дмитрий";
                int OutsideTemperature = 25;
                bool IsWoman = false;
                Console.WriteLine($"My Age is: {MyAge}");
                Console.WriteLine($"My Name is: {FirstName}");
                Console.WriteLine($"Outside temperature is: {OutsideTemperature}");
                Console.WriteLine($"Женский ли мой пол? : {IsWoman}");
            }

            ///<summary>
            ///Задание 3a.
            ///</summary>
            void FirstCycle()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i);
                }
            }

            ///<summary>
            ///Задание 3b.
            ///</summary>
            void SecondCycle()
            {
                int i = 0;
                while (i < 10)
                {
                    Console.WriteLine(i);
                    i++;
                }
            }

            ///<summary>
            ///Задание 3c.
            ///</summary>
            void ThirdCycle()
            {
                int i = 0;
                do
                {
                    Console.WriteLine(i);
                    i++;
                }
                while (i < 10);
            }

            ///<summary>
            ///Задание 3d.
            ///</summary>
            
            void CycleForWords()
            {
                Console.WriteLine("Input 5 words:");
                string Phrase = string.Empty;
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Input word # {i + 1}");
                    Phrase += " " + Console.ReadLine();
                }
                Console.WriteLine($"Your phrase is:{Phrase}");

            }

            ///<summary>
            ///Задание 3e.
            ///</summary>
            ///
            void SecondCycleForWords()
            {
                int i = 0;
                string Phrase = string.Empty;
                while (i <5)
                {
                    Console.WriteLine($"Input word # {i + 1}");
                    Phrase += " " + Console.ReadLine();
                    i++;
                }
                Console.WriteLine($"Your phrase is:{Phrase}");
            }

            ///<summary>
            ///Задание 3f.
            ///</summary>
            void ThirdCycleForWords()
            {
                int i = 0;
                string Phrase = string.Empty;
                do
                {
                    Console.WriteLine($"Input word # {i + 1}");
                    Phrase += " " + Console.ReadLine();
                    i++;
                }
                while (i < 5);
                Console.WriteLine($"Your phrase is:{Phrase}");
            }

            ///<summary>
            ///Задание 4a.
            ///</summary>
            void ConvertMeters2Kilometers()
            {
                Console.WriteLine("Перевод из метров в километры");
                Console.Write("Введите величину в метрах: ");
                double ValueInMeters = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"{ValueInMeters} м. это {ValueInMeters / 1000} км.");
            }


            ///<summary>
            ///Задание 4b.
            ///</summary>
            void ConvertKilometers2Santimeters()
            {
                Console.WriteLine("Перевод из километров в сантиметры");
                Console.Write("Введите величину в километрах: ");
                double ValueInKMeters = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"{ValueInKMeters} км. это {ValueInKMeters  * 1000 * 100} см.");
            }

            //GetValues();

            //FirstCycle();

            //SecondCycle();

            //ThirdCycle();

            //CycleForWords();

            //SecondCycleForWords();

            //ThirdCycleForWords();

            //ConvertMeters2Kilometers();

            ConvertKilometers2Santimeters();
        }
    }
}