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

                if (Field[0] == Field[1] == Field[2])
                Console.WriteLine($"Выиграли {State}");
                return 1;

                if (Field[3] == State && Field[4] == State && Field[5] == State);
                Console.WriteLine($"Выиграли {State}");
                return 1;

                if (Field[6] == State && Field[7] == State && Field[8] == State);
                Console.WriteLine($"Выиграли {State}");
                return 1;

                if (Field[0] == State && Field[3] == State && Field[6] == State);
                Console.WriteLine($"Выиграли {State}");
                return 1;

                if (Field[1] == State && Field[4] == State && Field[7] == State);
                Console.WriteLine($"Выиграли {State}");
                return 1;

                if (Field[2] == State && Field[5] == State && Field[8] == State);
                Console.WriteLine($"Выиграли {State}");
                return 1;

                if (Field[0] == State && Field[4] == State && Field[8] == State);
                Console.WriteLine($"Выиграли {State}");
                return 1;

                if (Field[2] == State && Field[4] == State && Field[6] == State);
                Console.WriteLine($"Выиграли {State}");
                return 1;

                return 0;

            }

            void CheckEnd(string[] Field)
            {
                if (Field[0] != "1" && Field[1] != "2" && Field[2] != "3" && Field[3] != "4" && Field[4] != "5" && Field[5] != "6" && Field[6] != "7" && Field[7] != "8" && Field[8] != "9")
                  {
                    Console.WriteLine("Ничья");
                    Status = 1; 
                  }
                else 
                  {
                    Status = 0;
                }
            }

            void MakeMove(string Player)
            {
                Console.WriteLine($"Игрок играющий за {Player} введите номер клетки (от 1 до 9) для следующего хода :");
                if (int.TryParse(Console.ReadLine(), out int CMove))
                  {
                    if (CMove < 0 || CMove > 9)
                        Console.WriteLine("Неправильный номер клетки");

                    else if ((GameField[CMove - 1] == "X") || (GameField[CMove - 1] == "O"))
                        Console.WriteLine("Клетка занята");

                    else
                    {
                        GameField[CMove - 1] = Player;
                        ChangePlayers(Player);
                    }
                   }
                else
                    Console.WriteLine("Некорректный ввод");
                
                Console.ReadLine();
            }

            void ChangePlayers(string Player)
            {
                if (Player == "X")
                    Player = "O";
                else Player = "X";
            }

            do
            {
                WriteGameField(GameField);
                MakeMove(Player);
                Status = CheckWinner(GameField, Player);
                CheckEnd(GameField);

            } while (Status == 1);
            
            Console.WriteLine(Status);
            
        }
        
    }

    
}