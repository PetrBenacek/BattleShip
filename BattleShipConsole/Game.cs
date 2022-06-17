namespace BattleShipConsole
{
    public class Game
    {
        private Player player1;
        private Player player2;
        
        public Game()
        {
            Console.WriteLine("Zadejte jméno prvního hráče:");
            string player1Name = Console.ReadLine();
            Console.WriteLine("Zadejte jméno druhého hráče:");
            string player2Name = Console.ReadLine();
            player1 = new Player();
            player1.SetName(player1Name);
            player2 = new Player();
            player2.SetName(player2Name);
            Console.WriteLine($"vytvorena nova hra pro hráče: {player1.GetName()} a {player2.GetName()}");
        }
        
        private void Start()
        {
        }
    }
}

