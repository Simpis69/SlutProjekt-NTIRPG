public class Enemy
{
    private string name = "";
    private int hp = 0;
    private int dmg = 0;
    public Enemy()
    {
        hp = Random.Shared.Next(100,800);
        dmg = Random.Shared.Next(10,250);
    }
}
