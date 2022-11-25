using Bonus;

Rettangolo rettangoloU = new Rettangolo();
Rettangolo rettangolo1 = new Rettangolo();
Rettangolo rettangolo2 = new Rettangolo();


Console.WriteLine("Creiamo un rettangolo! Dagli un nome!");
rettangoloU.nomeRettangolo = Console.ReadLine();
Console.WriteLine();

Console.WriteLine("Inserisci la base del tuo rettangolo");
rettangoloU.baseRettangolo = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Inserisci l'altezza del tuo rettangolo");
rettangoloU.altezzaRettangolo = int.Parse(Console.ReadLine());
Console.WriteLine();

if (rettangoloU.baseRettangolo == rettangoloU.altezzaRettangolo)
{
    Console.WriteLine("Il quadrato è effettivamente un rettangolo");
    Console.WriteLine();
}

Console.WriteLine("Ecco il suo rettangolo");
rettangoloU.StampaRettangolo();
Console.WriteLine();

Console.WriteLine("Ecoo alcuni rettangoli creati da altri utenti");
Console.WriteLine();

rettangolo1.nomeRettangolo = "Anna";
rettangolo1.baseRettangolo = 12;
rettangolo1.altezzaRettangolo = 24;
rettangolo1.StampaRettangolo();

Console.WriteLine();

rettangolo2.nomeRettangolo = "Saul";
rettangolo2.baseRettangolo = 23;
rettangolo2.altezzaRettangolo = 15;
rettangolo2.StampaRettangolo();
