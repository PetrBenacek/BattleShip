namespace BattleShipConsole
{
    public class Game
    {
        private Player player;
        
        public Game()
        {
            string[] jmena = new string[10];


            Console.WriteLine("vítej ve hře BattleShip");
            int x = 0;
            do
            {
                Console.WriteLine("zadej jméno hráče:");
                string jmeno = Console.ReadLine();
                player = new Player();
                player.SetName(jmeno);

                x++;
                if (x == 9)
                    {
                    Console.WriteLine("poslední hráč");
                    }
            } while (x < 10) ;

            Console.WriteLine("toto jsou hráči pro dnešní hru:");
            Console.WriteLine("---konec");
        }
        
        private void Start()
        {

            
            
            
        }
    }
}

