class Program
{
    // Créez des fonctions et documentez les.

    static void Main(string[] args)
    {
        // Point d'entrée du programme

        //Hauteur de la fenêtre console en nombre de lignes
        Console.WindowHeight

        int sol = Console.WindowHeight - 2;

        //Positionner le curseur sur une position spécifique dans la console:
        Console.SetCursorPosition(x, y);
        //x = la colonne(de gauche à droite, commence à 0).
        //y = la ligne(de haut en bas, commence à 0).

        // Configuration pour afficher les emojis
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Random random = new Random(); // Une seule instance de Random pour éviter les répétitions
        random.Next(posMin, posMax + 1);

        Thread.Sleep(50);

        // Effacer la console 
        Console.Clear();

    }
}