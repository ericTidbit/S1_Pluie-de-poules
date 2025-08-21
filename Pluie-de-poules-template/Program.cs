class Program
{
    // Créez des fonctions et documentez les.

    static void Main(string[] args)
    {
        // 1 au dessus du vrai sol
        int sol = Console.WindowHeight - 2;
        int posMin = 0;
        List<(int, int)> listePoulets = new List<(int, int)>();
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
            while (Console.CursorLeft >= randomColumn && Console.CursorTop <= sol) 
            {
                Console.Clear();
                cursorPosY++;
                Console.SetCursorPosition(randomColumn, cursorPosY);
                Console.Write("🐔");

                // loop pour descendre le poulet
                foreach ((int, int) poulet in listePoulets)
                {
                    Console.SetCursorPosition(poulet.Item1, poulet.Item2);
                    Console.Write("🐔");
                } 

                Thread.Sleep(100);
            }

            listePoulets.Add((randomColumn, sol + 1));
        }
    }
}