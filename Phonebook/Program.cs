namespace Phonebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phonebook pb = Phonebook.GetSource;
            pb.LoadFile();
            //pb.Display();

            #region Меню
            while (true)
            {
                
                pb.Display();
                Console.WriteLine();
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Добавление нового абонента в справочник.");
                Console.WriteLine("2. Поиск абонента по номеру телефона.");
                Console.WriteLine("3. Поиск номера телефона по имени абонента.");
                Console.WriteLine("4. Удалить абонента из справочника.");
                Console.WriteLine("5. Выйти.");


                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        pb.AddAbonent();
                        Console.ReadLine();
                        break;
                    case "2":
                        pb.GetNameByPhone();
                        Console.ReadLine();
                        break;
                    case "3":
                        pb.GetPhoneByName();
                        Console.ReadLine();
                        break;
                    case "4":
                        pb.DeleteAbonent();
                        Console.ReadLine();
                        break;
                    case "5":
                        pb.SaveFile();
                        return;
                    default:
                        Console.WriteLine("Ошибка: некорректный выбор.");
                        Console.ReadLine();
                        break;
                }
                Console.WriteLine();
            }
            #endregion

            //Console.WriteLine(pb.BookPath);

        }
    }
}