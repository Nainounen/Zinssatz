using System;

class Program
{

    static void Main(string[] args)
    {
        double Startkapital = 100000; 
        const double Zinssatz = 0.11;
        int Jahrezuberechnen = 10;
        double zwischenzahl;
        

        for (int Jahr = 1; Jahr <= Jahrezuberechnen; Jahr++)
        {
            zwischenzahl = Startkapital / Zinssatz;
            Startkapital = Startkapital - zwischenzahl;
            Console.WriteLine($"Jahr {Jahr}: Kapital = {Startkapital:C2}");
        }
    }
}