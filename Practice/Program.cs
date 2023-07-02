namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void GetVariables()
            {
                int Age;
                string FirstName;
                string CompanyName;
                bool LogicalVariable;
                float PersonWeight;
            }

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

            void FirstCycle()
            {
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }
            }

            void SecondCycle()
            {
                int i = 0;
                while (i <= 10)
                {
                    Console.WriteLine(i);
                    i++;
                }
            }

            void ThirdCycle()
            {
                int i = 0;
                do
                {
                    Console.WriteLine(i);
                    i++;
                }
                while (i <= 10);
            }

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

            //GetValues();

            //FirstCycle();

            //SecondCycle();

            //ThirdCycle();

            CycleForWords();
        }
    }
}