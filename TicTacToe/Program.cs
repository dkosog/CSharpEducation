namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] GameField = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

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
            
            bool CheckWinner(string[] Field, string State)
              {

                if (Field[0] == State && Field[1] == State && Field[2] == State);
                return true;

                if (Field[3] == State && Field[4] == State && Field[5] == State);
                return true;

                if (Field[6] == State && Field[7] == State && Field[8] == State);
                return true;

                if (Field[0] == State && Field[3] == State && Field[6] == State);
                return true;

                if (Field[1] == State && Field[4] == State && Field[7] == State);
                return true;

                if (Field[2] == State && Field[5] == State && Field[8] == State);
                return true;

                if (Field[0] == State && Field[4] == State && Field[8] == State);
                return true;

                if (Field[2] == State && Field[4] == State && Field[6] == State);
                return true;

                return false;

            }
            

            WriteGameField(GameField);
            GameField[3] = "X";
            GameField[4] = "X";
            GameField[5] = "X";
            WriteGameField(GameField);
            Console.WriteLine(CheckWinner(GameField, "X"));
        }

    }
}