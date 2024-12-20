namespace Inlämningsuppgift2_lek.Classes
{
    public class Computer : Player
    {

        public Computer()
        {
        }

        // Statisk instansvariabel som räknare
        public static int computerBullets = 0;


        public override string GetBullets()
        {
            return computerBullets.ToString();
        }


        public string GetComputerMove()
        {
            // Slumpar fram ett heltal beroende på om det finns kulor eller ej
            // För att göra datorn något smartare så är det större chans att datorn väljer att ladda
            Random random = new Random();

            int computerMoveInt;

            if (computerBullets == 0)
            {
                computerMoveInt = 3;
            }

            else if (User.userBullets == 0 && computerBullets >= 1)
            {

                computerMoveInt = 2;
            }
            else
            {
                int randInt = random.Next(1, 5);
                computerMoveInt = randInt;
            }

            // Tilldelar ett strängvärde till heltalet
            // Om datorn har mer än 3 kulor är valet alltid shotgun
            string computerMove = "Shotgun";

            if (computerBullets < 3)
            {
                if (computerMoveInt == 1)
                {
                    computerMove = "Block";
                }
                if (computerMoveInt == 2)
                {
                    computerMove = "Fire";
                }
                if (computerMoveInt == 3 || computerMoveInt == 4)
                {
                    computerMove = "Reload";
                }
            }
            return computerMove;    
        }
    }
}
