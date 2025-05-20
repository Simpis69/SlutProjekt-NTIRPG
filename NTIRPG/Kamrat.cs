public class Kamrat : Karaktär
{
    public string name = "";
    private int dmg = 0;
    public Kamrat()
    {
        dmg = Random.Shared.Next(10,150);
    }
}
