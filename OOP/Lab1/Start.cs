namespace Lab1;

public class Start
{
    static void Main(string[] args)
    {
        GameAccount account1 = new GameAccount("Mark", 1000);
        GameAccount account2 = new GameAccount("Robert", 1300);

        account1.WinGame(account2, 100);
        account2.LoseGame(account1, 50);
        
        account1.GetStats();
        account2.GetStats();
    }
}