namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] GameField = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            int Status = 1;

            void WriteGameField(string[] Field)
            {
                Console.WriteLine(" --- --- --- ");
                Console.WriteLine($"| {Field[0]} | {Field[1]} | {Field[2]} |");
                Console.WriteLine(" --- --- --- ");
                Console.WriteLine($"| {Field[3]} | {Field[4]} | {Field[5]} |");
                Console.WriteLine(" --- --- --- ");
                Console.WriteLine($"| {Field[6]} | {Field[7]} | {Field[8]} |");
                Console.WriteLine(" --- --- --- ");
            }

            int CheckWinner(string[] Field, string State)
            {

                if (Field[0] == State && Field[1] == State && Field[2] == State) ;
                Console.WriteLine($"Выиграли {State}");
                return 1;

                if (Field[3] == State && Field[4] == State && Field[5] == State) ;
                Console.WriteLine($"Выиграли {State}");
                return 1;

                if (Field[6] == State && Field[7] == State && Field[8] == State) ;
                Console.WriteLine($"Выиграли {State}");
                return 1;

                if (Field[0] == State && Field[3] == State && Field[6] == State) ;
                Console.WriteLine($"Выиграли {State}");
                return 1;

                if (Field[1] == State && Field[4] == State && Field[7] == State) ;
                Console.WriteLine($"Выиграли {State}");
                return 1;

                if (Field[2] == State && Field[5] == State && Field[8] == State) ;
                Console.WriteLine($"Выиграли {State}");
                return 1;

                if (Field[0] == State && Field[4] == State && Field[8] == State) ;
                Console.WriteLine($"Выиграли {State}");
                return 1;

                if (Field[2] == State && Field[4] == State && Field[6] == State) ;
                Console.WriteLine($"Выиграли {State}");
                return 1;

                return 0;

            }



            
                WriteGameField(GameField);
                GameField[3] = "O";
                GameField[4] = "O";
                GameField[5] = "O";
                WriteGameField(GameField);
                Status = CheckWinner(GameField, "O");
                Console.WriteLine(Status);

            
            




    }
        
    }

    
}