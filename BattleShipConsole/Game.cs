namespace BattleShipConsole
{
    public class Game
    {
        private const int maxPlayerCount = 10;
        public Player[] Players = new Player[maxPlayerCount];
        
        public Game()
        {
            int index = 0;
            
            Console.WriteLine("vítej ve hře BattleShip");
            
            do
            {
                
                Console.WriteLine("zadej jméno hráče:");
                string newPlayerName = Console.ReadLine();
                if (newPlayerName == "ne")
                {
                    break;
                }
                Player newPlayer = new Player();
                newPlayer.SetName(newPlayerName);
                Players[index] = newPlayer;
                
                index++;
                
                if (index == maxPlayerCount-1)
                {
                    Console.WriteLine("poslední hráč");
                }
                
            } while (index < maxPlayerCount) ;

            Console.WriteLine("toto jsou hráči pro dnešní hru:");
            index = 0;
            do
            {
                if (Players[index] == null)
                {
                    break;
                }

                Console.WriteLine(Players[index].GetName());
                index++;
            } while (index < maxPlayerCount);
            
            Console.WriteLine("---konec");
        }
        
        private void Start()
        {

        }
    }
}

