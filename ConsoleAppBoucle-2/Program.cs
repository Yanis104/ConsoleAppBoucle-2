namespace ConsoleAppBoucle_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entrez un nombre entier : ");
            int n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("La factorielle n'existe pas pour un nombre negatif.");
            }
            else
            {
                long resultat = 1;
                int i = 1;

                while (i <= n)
                {
                    resultat = resultat * i;
                    i = i + 1;
                }

                Console.WriteLine(n + "! = " + resultat);
            }
        }
    }
}
