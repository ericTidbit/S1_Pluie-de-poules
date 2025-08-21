# 
Pour créez un nouveau répertoire à partir de ce template

<img width="572" height="316" alt="Use template" src="https://github.com/user-attachments/assets/baf0c948-05c2-4749-8993-4b8cf563482a" />

# Pluie-de-poules
Un mystérieux phénomène météorologique frappe la région : il pleut des poules ! Votre mission est de créer un simulateur pour étudier ce phénomène étrange.

Objectif : Programmer la chute de plusieurs poules du haut de l'écran jusqu'au sol.

## Spécifications fonctionnelles
- Chaque poule doit tomber en ligne droite
- Les poules apparaissent à des positions horizontales aléatoires (ex. entre les colonnes 10 et 60).
- Les poules partent toutes du même point de départ et arrivent toutes à 2 lignes du bas de l'écran.

## Indications
- Console capable d'afficher des emojis 🐔 : ```Console.OutputEncoding = System.Text.Encoding.UTF8;```
- Positionner le curseur sur une position spécifique dans la console:
  ```
  Console.SetCursorPosition(x, y);
  x = la colonne (de gauche à droite, commence à 0).
  y = la ligne (de haut en bas, commence à 0).
  ```
- Effacer la console : ```Console.Clear();```
- Hauteur de la fenêtre console en nombre de lignes : ```Console.WindowHeight```
- Générer un nombre aléatoire :
  ```C# 
	Random random = new Random(); // Une seule instance de Random pour éviter les répétitions
	random.Next(posMin, posMax + 1);
  ```
- ```Thread.Sleep(50);```

## Spécifications techniques
- Créer un nouveau dépôt pour votre projet.
- Poussez votre projet dans GitHub.
- Utilisez des fonctions.
- Au moins un tableau et/ou une liste (faites le bon choix!).
