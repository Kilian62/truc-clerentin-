// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

double air(double a, double b) //je documente la 
{
    return a * b;
}

Console.WriteLine("entre ta longueur et largeur"); // ecrire la phrase
double a = Convert.ToDouble(Console.ReadLine()); // lire
double b = Convert.ToDouble(Console.ReadLine());
double res = air(a,b);
Console.WriteLine($"resultat {res}");
