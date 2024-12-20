namespace Inlämningsuppgift2_lek.Classes
{
    static class UtilityClass
    {
        // Instansvariabel för vinnaren
        public static string winner ; 


        public static void GetResult(string userMove, string computerMove)
        {
            // Ladda mot ladda       
            if (userMove == "Reload" && computerMove == "Reload")
            {
                User.userBullets++;
                Computer.computerBullets++;
            }


            // Ladda mot blocka 
            if (userMove == "Reload" && computerMove == "Block")
            {
                User.userBullets++;
            }

            if (userMove == "Block" && computerMove == "Reload")
            {
                Computer.computerBullets++;
            }


            // Blocka mot blocka 
            if (userMove == "Block" && computerMove == "Block")
            {

            }


            // Skjuta mot blocka
            if (userMove == "Fire" && computerMove == "Block")
            {
                User.userBullets--;
                
            }

            if (userMove == "Block" && computerMove == "Fire")
            {
                Computer.computerBullets--;
                
            }



            // Skjuta mot skjuta 
            if (userMove == "Fire" && computerMove == "Fire")
            {
                User.userBullets--;
                Computer.computerBullets--;
                
            }


            // Skjuta mot ladda 
            if (userMove == "Fire" && computerMove == "Reload")
            {
                winner = "User";


            }

            if (computerMove == "Fire" && userMove == "Reload")
            {
                winner = "Computer";

            }

            // Shotgun
            if ((userMove == "Shotgun" && computerMove != "Shotgun"))
            {
                winner = "User";
            }

            if (computerMove == "Shotgun" && userMove != "Shotgun")
            {
                winner = "Computer";
            }

            // Båda väljer shotgun = användaren vinner
            if (userMove == "Shotgun" && computerMove == "Shotgun")
            {
                winner = "User";
            }
        }
    }
}
