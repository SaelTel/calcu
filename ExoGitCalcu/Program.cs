public class Program
{

    public static void Main()
    {

        Calculatrice();
        //test
    }

    private static void Calculatrice()
    {
        bool restart;
        do
        {
            ProposeAction();
            Console.WriteLine("Restart? O/N ?");
            if (Console.ReadLine() == "O") restart = true;
            else restart = false;
        } while (restart);

    }

    private static void ProposeAction()
    {
        AfficheMenu();

        Console.WriteLine("Rentre nb action:");
        int action = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Nombre 1:");
        int nb1 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Nombre 2:");
        int nb2 = int.Parse(Console.ReadLine()!);

        switch (action)
        {
            case 1:
                Addition(nb1, nb2);
                break;
            case 2:
                Soustraction(nb1, nb2);
                break;
            case 3:
                Multiplication(nb1, nb2);
                break;
            case 4:
                Division(nb1, nb2);
                break;
            default:
                Console.WriteLine("nombre non valide");
                break;
        }
    }

    private static void AfficheMenu()
    {
        Console.Clear();
        Console.WriteLine("Entrez le calcul que vous souhaiter effectuer :");
        Console.WriteLine();
        Console.WriteLine("====================");
        Console.WriteLine("PROGRAMME DE CALCUL");
        Console.WriteLine("====================");
        Console.WriteLine();
        Console.WriteLine("1-Addition");
        Console.WriteLine("2-Soustraction");
        Console.WriteLine("3-Multiplication");
        Console.WriteLine("4-Division");
    }

    private static void Division(int nb1, int nb2)
    {
        bool isCorrect = false;
        do
        {
            try
            {
                Console.WriteLine($"{nb1} / {nb2} = {nb1 / nb2}");
                isCorrect = true;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Nombre2 invalide car on ne peut pas diviser par zero, Réessaye");
            }
        } while (!isCorrect);

    }
    private static void Multiplication(int nb1, int nb2)
    {
        Console.WriteLine($"{nb1} * {nb2} = {nb1 * nb2}");
    }

    private static void Soustraction(int nb1, int nb2)
    {
        Console.WriteLine($"{nb1} - {nb2} = {nb1 - nb2}");
    }

    private static void Addition(int nb1, int nb2)
    {
        Console.WriteLine($"{nb1} + {nb2} = {nb1 + nb2}");

    }
}


