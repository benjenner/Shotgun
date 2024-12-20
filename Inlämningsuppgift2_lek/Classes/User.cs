namespace Inlämningsuppgift2_lek.Classes
{
    public class User : Player
    {

        public User()
        {
        }


        // Statisk instansvariabel som räknare
        public static int userBullets = 0;


        public bool CheckUserMove(string move)
        {
            if (move == "Fire" && userBullets == 0)
            {
                MessageBox.Show("No bullets to fire.");
                return false;
            }
            if(move == "Shotgun" && userBullets <3)
            {
                MessageBox.Show("No rounds to fire. You need minimum 3 bullets");
                return false;
            }
            else
            {
                return true;
            }
        }

        public override string GetBullets()
        {
            return userBullets.ToString();
        }

        
    }
}
