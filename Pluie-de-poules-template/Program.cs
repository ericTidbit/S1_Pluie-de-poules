class Program
{
    // Créez des fonctions et documentez les.

    static void Main(string[] args)
    {


        // 1 au dessus du vrai sol
        int sol = Console.WindowHeight - 2;
        int posMin = 0;
        List<int> listePouletsSol = new List<int>();
        Random random = new Random();

        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // max poulet
        for (int i = 0; i <= 10; i++)
        {
            int posMax = Console.WindowWidth - 1;
            int randomColumn = random.Next(posMin, posMax);
            int cursorPosY = 0;

            Console.SetCursorPosition(randomColumn, cursorPosY);

            // loop au travers chaque poulet
            while (cursorPosY <= sol)
            {
                Console.Clear();
                cursorPosY++;
                Console.SetCursorPosition(randomColumn, cursorPosY);
                Console.Write("🐔");

                // loop pour descendre le poulet
                foreach (int poulet in listePouletsSol)
                {
                    Console.SetCursorPosition(poulet, sol + 1);
                    Console.Write("🐔");
                }

                Thread.Sleep(100);
            }

            listePouletsSol.Add(randomColumn);
        }
    }
}