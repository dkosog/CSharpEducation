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


            ///<summary>
            ///Задание 4c.
            ///</summary>
            void ConvertSpeed()
            {
                Console.WriteLine("Перевод скорости из метров в секунду в километры в час");
                Console.Write("Введите скорость в м/с: ");
                double Speed = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"{Speed} м/с это {Speed * 3.6} км/ч");
            }

            ///<summary>
            ///Задание 4d.
            ///</summary>
            void ConvertTemperature()
            {
                Console.WriteLine("Перевод температуры из C в F");
                Console.Write("Введите температуру в С: ");
                double Temperature = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"{Temperature} градусов по С это {(Temperature / 5) * 9 + 32} градусов по F");
            }


            ///<summary>
            ///Задание 5a.
            ///</summary>
            void Pifagor2K()
            {
                Console.WriteLine("Найдем гипотенузу через 2 катета");
                Console.Write("Введите катет 1: ");
                double Leg1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите катет 2: ");
                double Leg2 = Convert.ToDouble(Console.ReadLine());
                double Hypotenuse = Math.Sqrt(Math.Pow(Leg1, 2) + Math.Pow(Leg2, 2));
                Console.WriteLine($"Если катет 1 - {Leg1}, а катет 2 - {Leg2}, то гипотенуза составит {Hypotenuse}");
            }

            ///<summary>
            ///Задание 5b.
            ///</summary>
            void Pifagor1H1K()
            {
                Console.WriteLine("Найдем 2 катет через гипотенузу и 1 катет");
                Console.Write("Введите гипотенузу: ");
                double Hypotenuse = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите катет 1: ");
                double Leg1 = Convert.ToDouble(Console.ReadLine());
                double Leg2 = Math.Sqrt(Math.Pow(Hypotenuse, 2) - Math.Pow(Leg1, 2));
                Console.WriteLine($"Если гипотенуза - {Hypotenuse}, а катет 1 - {Leg1}, то катет 2 составит {Leg2}");
            }


            ///<summary>
            ///Задание 6.
            ///</summary>
            void CalcExpression()
            {
                Console.WriteLine("Найдем значение выражения (a + b - f / a) + f * a * a - (a + b)");
                
                Console.Write("Введите значение a не равное 0: ");
                double a = Convert.ToDouble(Console.ReadLine());
                
                if (a == 0) {
                    Console.Write("Введите a не равное 0: ");
                    a = Convert.ToDouble(Console.ReadLine());
                }
                
                Console.Write("Введите значение b: ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите значение f: ");
                double f = Convert.ToDouble(Console.ReadLine());
                
                double Result = (a + b - (f / a) + f * a * a - (a + b));
                Console.WriteLine($"При значениях а = {a}, b = {b}, f = {f}, значение выражения будет = {Result}");
            }


            ///<summary>
            ///Задание 7a.
            ///</summary>
            void WriteStars1()
            { 
            Console.WriteLine("Введите высоту пирамиды из звездочек:");
                int hight = int.Parse(Console.ReadLine());
                
                for (int i = 0; i < hight+1; i++) 
                {
                   for (int j = 0; j < i; j++)
                    { 
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }

            ///<summary>
            ///Задание 7b.
            ///</summary>
            void WriteStars2()
            {
                Console.WriteLine("Введите высоту пирамиды из звездочек:");
                int hight = int.Parse(Console.ReadLine());

                for (int i = 0; i < hight + 1; i++)
                {

                    for (int s = hight; s > i; s--)
                    {
                        Console.Write(" ");
                    }
                    
                    for (int j = 0; j < i; j++)
                    {                        
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }

            ///<summary>
            ///Задание 7c.
            ///</summary>
            void WriteStars3()
            {
                Console.WriteLine("Введите символ для отрисовки пирамиды");
                string Symbol = Console.ReadLine();

                Console.WriteLine($"Введите высоту пирамиды из {Symbol}");
                int hight = int.Parse(Console.ReadLine());

                for (int i = 0; i < hight + 1; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(Symbol);
                    }
                    Console.WriteLine();
                }
            }

            //GetValues();

            //FirstCycle();

            //SecondCycle();

            //ThirdCycle();

            //CycleForWords();

            //SecondCycleForWords();

            //ThirdCycleForWords();

            //ConvertMeters2Kilometers();

            //ConvertKilometers2Santimeters();

            //ConvertSpeed();

            // ConvertTemperature();

            // Pifagor2K();

            //Pifagor1H1K();

            //CalcExpression();

            //WriteStars1 ();

            //WriteStars2();

            WriteStars3();
        }
    }
}