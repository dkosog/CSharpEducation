using System;
using System.Collections.Generic;
//using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Phonebook
{
    internal class Phonebook
    {

        #region Поля
        /// <summary>
        /// Путь хранения файла телефонной книги.
        /// </summary>
        //private string bookpath = string.Concat(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "\\Phonebook.txt");
        string bookpath = "Phonebook.txt";

        /// <summary>
        /// Коллекция абонентов.
        /// </summary>
        private List<Abonent> abonents = new List<Abonent>();
        #endregion

        /// <summary>
        /// реализация паттерна Singleton класса Phonebook.
        /// </summary>
        private Phonebook()
        {
        }

        private static Phonebook source = null;

        public static Phonebook GetSource
        {
            get { 
                if (source == null)
                    source = new Phonebook();
                return source;
                }
        }

        public string BookPath
        { 
            get { return bookpath; }
        }


        #region Методы работы с файлом
        /// <summary>
        /// Чтение из файла Phonebook.txt.
        /// </summary>
        public void LoadFile()
        {
            if (File.Exists(bookpath))
            {
                abonents.Clear();
                using (StreamReader reader = new StreamReader(bookpath))
                {
                    while (!reader.EndOfStream)
                    {
                        string? line = reader.ReadLine();
                        string[] sstr = line.Split(";");
                        Abonent abo = new Abonent();
                        abo.Name = sstr[0];
                        abo.Phone = sstr[1];
                        abonents.Add(abo);
                   }
                }
            }
            else 
            {
                Console.WriteLine("Файл телефонного справочника не найден");
                File.Create(bookpath).Close();
                Console.WriteLine("Создан новый файл телефонного справочника");
            }

        }

        /// <summary>
        /// Запись в файл Phonebook.txt.
        /// </summary>
        public void SaveFile()
        {
            if (File.Exists(bookpath))
            {
                
                using (StreamWriter sw = new StreamWriter(bookpath))

                {
                    foreach (Abonent abo in abonents) 
                      {
                          string rec = string.Concat(abo.Name, ";", abo.Phone);
                          //Console.WriteLine(rec);
                          sw.WriteLine(rec);
                      }

                        sw.Close();
                }
            }
            //abonents.Clear();
        }
        #endregion

        /// <summary>
        /// Вывод в консоль содержимого коллекции.
        /// </summary>
        public void Display()
        {
            Console.Clear();
            int spaces = 0;
            foreach (Abonent abo in abonents)
            {
                if (abo.Name.Length > spaces)
                {
                    spaces = abo.Name.Length;
                };
            }
            string str = "Имя ";
            Console.Write(str.PadRight(spaces+2));
            Console.WriteLine("Номер");
            foreach (Abonent abo in abonents)
            {
                str=abo.Name;
                Console.Write(str.PadRight(spaces + 2));
                Console.WriteLine(abo.Phone);
                
            }
        }

        #region CRUD функционал
        /// <summary>
        /// Добавление нового абонента.
        /// </summary>
        public void AddAbonent()
        {
            string _name = "";
            string _phone = "";
            Console.WriteLine("Для добавления нового абонента введите его имя:");
            _name = Console.ReadLine();
            Console.WriteLine($"Введите телефон абонента {_name}: ");
            _phone = Console.ReadLine();
            Abonent abo = new Abonent
                { 
                    Name=_name,
                    Phone=_phone
                };

            if (abonents.Exists(x => x.Name == abo.Name && x.Phone == abo.Phone))
                { 
                    Console.WriteLine($"Абонент {abo.Name} с номером {abo.Phone} уже существует!"); 
                }
            else 
                { 
                    abonents.Add(abo);
                    this.SaveFile();
                    Console.WriteLine($"Абонент {abo.Name} с номером {abo.Phone} успешно добавлен в список абонентов");
                }

        }

        /// <summary>
        /// Удаление абонента по номеру телефона.
        /// </summary>
        public void DeleteAbonent()
        {
            string _phone = "";
            Console.WriteLine("Для удаления абонента введите его номер телефона:");
            _phone = Console.ReadLine();
            
            if (abonents.Exists(x => x.Phone == _phone))
            {
                abonents.RemoveAll(x => x.Phone == _phone);
                Console.WriteLine($"Абонент с номером {_phone} удален из списка абонентов");
                this.SaveFile();
            }
            else
            {
                Console.WriteLine($"Абонент с номером {_phone} не найден в списке абонентов");
            }

        }


        /// <summary>
        /// Поиск имени абонента по номеру телефона.
        /// </summary>
        public void GetNameByPhone()
        {
            string _phone = "";
            Console.WriteLine("Для поиска абонента введите его номер телефона:");
            _phone = Console.ReadLine();

            if (abonents.Exists(x => x.Phone == _phone))
            {
                var abo = abonents.Find(x => x.Phone == _phone);
                Console.WriteLine($"Найден абонент {abo.Name} с номером {_phone}");
            }
            else
            {
                Console.WriteLine($"Абонент с номером {_phone} не найден в списке абонентов");
            }

        }

        /// <summary>
        /// Поиск номера телефона по имени абонента.
        /// </summary>
        public void GetPhoneByName()
        {
            string _name = "";
            Console.WriteLine("Для поиска номера телефона абонента введите его имя:");
            _name = Console.ReadLine();

            if (abonents.Exists(x => x.Name == _name))
            {
                var abo = abonents.Find(x => x.Name == _name);
                Console.WriteLine($"Найден абонент {_name} с номером {abo.Phone}");
            }
            else
            {
                Console.WriteLine($"Абонент с именем {_name} не найден в списке абонентов");
            }

        }
        #endregion
    }
}
