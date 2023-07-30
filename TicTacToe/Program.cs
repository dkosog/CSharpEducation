namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] GameField = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            int Status = 0;
            string Player = "X";

            void WriteGameField(string[] Field)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine(" --- --- --- ");
                Console.WriteLine($"| {Field[0]} | {Field[1]} | {Field[2]} |");
                Console.WriteLine(" --- --- --- ");
                Console.WriteLine($"| {Field[3]} | {Field[4]} | {Field[5]} |");
                Console.WriteLine(" --- --- --- ");
                Console.WriteLine($"| {Field[6]} | {Field[7]} | {Field[8]} |");
                Console.WriteLine(" --- --- --- ");
            }

            void CheckWinner(string[] Field)
            {

                WriteGameField(Field);
                if (string.Equals(Field[0], Field[1]) && string.Equals(Field[1], Field[2]))
                {
                    Console.WriteLine();
                    Console.WriteLine($"Выиграл игрок играющий за {Player}");
                    Status = 1;
                    
                }

                if (string.Equals(Field[3], Field[4]) && string.Equals(Field[3], Field[5]))
                {
                    Console.WriteLine();
                    Console.WriteLine($"Выиграл игрок играющий за {Player}");
                    Status = 1;
                    
                }

                if (string.Equals(Field[6], Field[7]) && string.Equals(Field[7], Field[8]))
                {
                    Console.WriteLine();
                    Console.WriteLine($"Выиграл игрок играющий за {Player}");
                    Status = 1;
                    
                }

                if (string.Equals(Field[0], Field[3]) && string.Equals(Field[3], Field[6]))
                {
                    Console.WriteLine();
                    Console.WriteLine($"Выиграл игрок играющий за {Player}");
                    Status = 1;
                    
                }

                if (string.Equals(Field[1], Field[4]) && string.Equals(Field[4], Field[7]))
                {
                    Console.WriteLine();
                    Console.WriteLine($"Выиграл игрок играющий за {Player}");
                    Status = 1;
                    
                }

                if (string.Equals(Field[2], Field[5]) && string.Equals(Field[5], Field[8]))
                {
                    Console.WriteLine();
                    Console.WriteLine($"Выиграл игрок играющий за {Player}");
                    Status = 1;
                    
                }

                if (string.Equals(Field[0], Field[4]) && string.Equals(Field[4], Field[8]))
                {
                    Console.WriteLine();
                    Console.WriteLine($"Выиграл игрок играющий за {Player}");
                    Status = 1;
                    
                }

                if (string.Equals(Field[2], Field[4]) && string.Equals(Field[4], Field[6]))
                {
                    Console.WriteLine();
                    Console.WriteLine($"Выиграл игрок играющий за {Player}");
                    Status = 1;
                    
                }
            }

            void CheckEnd(string[] Field)
            {
                if (Field[0] != "1" && Field[1] != "2" && Field[2] != "3" && Field[3] != "4" && Field[4] != "5" && Field[5] != "6" && Field[6] != "7" && Field[7] != "8" && Field[8] != "9" && Status != 1)
                  {
                    Console.WriteLine();
                    Console.WriteLine("Ничья");
                    Status = 1; 
                  }
            }

            void MakeMove(string NPlayer)
            {
                Console.WriteLine();
                Console.WriteLine($"Игрок играющий за {Player} введите номер клетки (от 1 до 9) для следующего хода :");
                if (int.TryParse(Console.ReadLine(), out int CMove))
                {
                    if (CMove < 0 || CMove > 9)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Неправильный номер клетки");
                    }

                    else if ((GameField[CMove - 1] == "X") || (GameField[CMove - 1] == "O"))
                    {
                        Console.WriteLine();
                        Console.WriteLine("Клетка занята");
                    }

                    else
                    {
                        GameField[CMove - 1] = NPlayer;
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Некорректный ввод");
                }
                
                //Console.ReadLine();
            }

            void ChangePlayers()
            {
                if (Player == "X")
                {
                    Player = "O";
                    return;
                }
                else Player = "X";
            }

            do
            {
                WriteGameField(GameField);
                MakeMove(Player);
                CheckWinner(GameField);
                CheckEnd(GameField);
                ChangePlayers();

            } while (Status == 0);
            
        }
        
    }

    
}