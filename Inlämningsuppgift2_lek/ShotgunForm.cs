using Inlämningsuppgift2_lek.Classes;

namespace Inlämningsuppgift2_lek
{
    public partial class ShotgunForm : Form
    {

        public ShotgunForm()
        {
            InitializeComponent();

            labelUserBullets.Text = User.userBullets.ToString();
            labelComputerBullets.Text = Computer.computerBullets.ToString();

        }

        // Instanser av klasserna User och Computer
        User user = new User();
        Computer computer = new Computer();

        private void buttonReload_Click(object sender, EventArgs e)
        {
           
            user.Move = "Reload";

            if(user.CheckUserMove(user.Move) == true)
            {
                computer.Move = computer.GetComputerMove();
                UtilityClass.GetResult(user.Move, computer.Move);
                //labelUserBullets.Text = user.GetBullets();
                //labelComputerBullets.Text = computer.GetBullets();
                labelUserBullets.Text = User.userBullets.ToString();
                labelComputerBullets.Text = Computer.computerBullets.ToString();

                if (UtilityClass.winner == "User")
                {
                    labelAnnouncingWinner.Text = "You win!";
                    PlayAgain();
                }
                if(UtilityClass.winner == "Computer")
                {
                    labelAnnouncingWinner.Text = "You loose!";
                    PlayAgain();
                }
            }
        }

        private void buttonShoot_Click(object sender, EventArgs e)
        {

            user.Move = "Fire";

            if (user.CheckUserMove(user.Move) == true)
            {
                computer.Move = computer.GetComputerMove();
                UtilityClass.GetResult(user.Move, computer.Move);
                labelUserBullets.Text = user.GetBullets();
                labelComputerBullets.Text = computer.GetBullets();

                if (UtilityClass.winner == "User")
                {
                    labelAnnouncingWinner.Text = "You win!";
                    PlayAgain();
                }
                if (UtilityClass.winner == "Computer")
                {
                    labelAnnouncingWinner.Text = "You loose!";
                    PlayAgain();
                }
            }
        }

        private void buttonBlock_Click(object sender, EventArgs e)
        {

            user.Move = "Block";

            if (user.CheckUserMove(user.Move) == true)
            {
                computer.Move = computer.GetComputerMove();
                UtilityClass.GetResult(user.Move, computer.Move);
                labelUserBullets.Text = user.GetBullets();
                labelComputerBullets.Text = computer.GetBullets();

                if (UtilityClass.winner == "User")
                {
                    labelAnnouncingWinner.Text = "You win!";
                    PlayAgain();
                }
                if (UtilityClass.winner == "Computer")
                {
                    labelAnnouncingWinner.Text = "You loose!";
                    PlayAgain();
                }
            }
        }


        private void buttonShotgun_Click(object sender, EventArgs e)
        {
          
            user.Move = "Shotgun";

            if (user.CheckUserMove(user.Move) == true)
            {
                computer.Move = computer.GetComputerMove();
                UtilityClass.GetResult(user.Move, computer.Move);
                labelUserBullets.Text = user.GetBullets();
                labelComputerBullets.Text = computer.GetBullets();

                if (UtilityClass.winner == "User")
                {
                    labelAnnouncingWinner.Text = "You win!";
                    PlayAgain();
                }
                if (UtilityClass.winner == "Computer")
                {
                    labelAnnouncingWinner.Text = "You loose!";
                    PlayAgain();
                }
            }
        }


        private void buttonPlayAgain_Click(object sender, EventArgs e)
        {
            labelAnnouncingWinner.Text = "";
            labelPlayAgain.Visible = false;
            buttonPlayAgain.Visible = false;
            buttonCloseApp.Visible = false;

            buttonReload.Visible = true;
            buttonBlock.Visible = true;
            buttonShoot.Visible = true;
            buttonShotgun.Visible = true;

            User.userBullets = 0;
            labelUserBullets.Text = User.userBullets.ToString();

            Computer.computerBullets = 0;
            labelComputerBullets.Text = Computer.computerBullets.ToString();

            UtilityClass.winner = "";
        }

        private void buttonCloseApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void PlayAgain()
        {
            labelPlayAgain.Visible = true;
            buttonPlayAgain.Visible = true;
            buttonCloseApp.Visible = true;

            buttonReload.Visible = false;
            buttonBlock.Visible = false;
            buttonShoot.Visible = false;
            buttonShotgun.Visible = false;
        }
    }
}
