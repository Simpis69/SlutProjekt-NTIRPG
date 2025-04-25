List<Karaktär> karaktärer = []; //lista på karaktärerna som läggs till
//ska göra en lista för namnen som spelar tilldelar kamraterna

Console.WriteLine("Välkommen till NTI rpg, du ska få välja hur många kamrater du har i ditt lag");
Console.WriteLine("välj från 1-4");

string svar = Console.ReadLine();
int resultat;
bool lyckad = int.TryParse(svar, out resultat);

if(resultat < 1 || resultat > 4)
{
    Console.WriteLine("välj ett mellan 1-4");
}
else
{
    Console.WriteLine($"Tack du har nu {resultat} kamrater i ditt lag");
}

for (int i = 0; i < resultat; i++)
{
    Kamrat kamrater = new Kamrat();

    karaktärer.Add(kamrater);
}
Console.ReadLine();