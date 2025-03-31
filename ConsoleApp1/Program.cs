    // See https://aka.ms/new-console-template for more information
    Console.WriteLine("Hello, World!");

    double air(double a, double b)
    {
        return a * b;
    }
    double hexa(double a)
    {
        return (((3 * Math.Sqrt(3)) / 2) * (a * a)); //formule de l'hexa
    }

    Console.WriteLine("entre ta longueur et largeur");
    double a = Convert.ToDouble(Console.ReadLine());
    double b = Convert.ToDouble(Console.ReadLine());
    double res = air(a,b);
    Console.WriteLine($"resultat {res}");


    Console.WriteLine("entre l'hexa");
    double c = Convert.ToDouble(Console.ReadLine());
    double res2 = hexa(c);
    Console.WriteLine($"resultat {res2}");
