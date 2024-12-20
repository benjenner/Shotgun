namespace Inlämningsuppgift2_lek
{
    partial class ShotgunForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelComputerScore = new Label();
            labelComputerBullets = new Label();
            labelUserBullets = new Label();
            labelUserScore = new Label();
            buttonReload = new Button();
            buttonBlock = new Button();
            buttonShoot = new Button();
            buttonShotgun = new Button();
            buttonPlayAgain = new Button();
            buttonCloseApp = new Button();
            labelAnnouncingWinner = new Label();
            labelPlayAgain = new Label();
            SuspendLayout();
            // 
            // labelComputerScore
            // 
            labelComputerScore.AutoSize = true;
            labelComputerScore.Font = new Font("Stencil-grungy", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelComputerScore.Location = new Point(733, 70);
            labelComputerScore.Name = "labelComputerScore";
            labelComputerScore.Size = new Size(187, 15);
            labelComputerScore.TabIndex = 6;
            labelComputerScore.Text = "OPPONENT BULLETS";
            // 
            // labelComputerBullets
            // 
            labelComputerBullets.AutoSize = true;
            labelComputerBullets.Font = new Font("Stencil-grungy", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelComputerBullets.Location = new Point(834, 100);
            labelComputerBullets.Name = "labelComputerBullets";
            labelComputerBullets.Size = new Size(0, 18);
            labelComputerBullets.TabIndex = 7;
            // 
            // labelUserBullets
            // 
            labelUserBullets.AutoSize = true;
            labelUserBullets.Font = new Font("Stencil-grungy", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUserBullets.Location = new Point(90, 108);
            labelUserBullets.Name = "labelUserBullets";
            labelUserBullets.Size = new Size(0, 18);
            labelUserBullets.TabIndex = 8;
            // 
            // labelUserScore
            // 
            labelUserScore.AutoSize = true;
            labelUserScore.Font = new Font("Stencil-grungy", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUserScore.Location = new Point(37, 70);
            labelUserScore.Name = "labelUserScore";
            labelUserScore.Size = new Size(140, 15);
            labelUserScore.TabIndex = 9;
            labelUserScore.Text = "YOUR BULLETS";
            // 
            // buttonReload
            // 
            buttonReload.Font = new Font("Confidential", 14.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonReload.Location = new Point(226, 358);
            buttonReload.Name = "buttonReload";
            buttonReload.Size = new Size(130, 53);
            buttonReload.TabIndex = 2;
            buttonReload.Text = "Reload";
            buttonReload.UseVisualStyleBackColor = true;
            buttonReload.Click += buttonReload_Click;
            // 
            // buttonBlock
            // 
            buttonBlock.Font = new Font("Confidential", 14.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonBlock.Location = new Point(380, 358);
            buttonBlock.Name = "buttonBlock";
            buttonBlock.Size = new Size(130, 53);
            buttonBlock.TabIndex = 3;
            buttonBlock.Text = "Block";
            buttonBlock.UseVisualStyleBackColor = true;
            buttonBlock.Click += buttonBlock_Click;
            // 
            // buttonShoot
            // 
            buttonShoot.Font = new Font("Confidential", 14.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonShoot.Location = new Point(533, 358);
            buttonShoot.Name = "buttonShoot";
            buttonShoot.Size = new Size(130, 53);
            buttonShoot.TabIndex = 4;
            buttonShoot.Text = "Shoot";
            buttonShoot.UseVisualStyleBackColor = true;
            buttonShoot.Click += buttonShoot_Click;
            // 
            // buttonShotgun
            // 
            buttonShotgun.Font = new Font("Confidential", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonShotgun.ForeColor = Color.Red;
            buttonShotgun.Location = new Point(353, 446);
            buttonShotgun.Name = "buttonShotgun";
            buttonShotgun.Size = new Size(184, 53);
            buttonShotgun.TabIndex = 5;
            buttonShotgun.Text = "Shotgun";
            buttonShotgun.UseVisualStyleBackColor = true;
            buttonShotgun.Click += buttonShotgun_Click;
            // 
            // buttonPlayAgain
            // 
            buttonPlayAgain.Font = new Font("Confidential", 14.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonPlayAgain.Location = new Point(330, 303);
            buttonPlayAgain.Name = "buttonPlayAgain";
            buttonPlayAgain.Size = new Size(113, 39);
            buttonPlayAgain.TabIndex = 10;
            buttonPlayAgain.Text = "Hell yeah";
            buttonPlayAgain.UseVisualStyleBackColor = true;
            buttonPlayAgain.Visible = false;
            buttonPlayAgain.Click += buttonPlayAgain_Click;
            // 
            // buttonCloseApp
            // 
            buttonCloseApp.Font = new Font("Confidential", 14.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonCloseApp.Location = new Point(449, 303);
            buttonCloseApp.Name = "buttonCloseApp";
            buttonCloseApp.Size = new Size(113, 39);
            buttonCloseApp.TabIndex = 10;
            buttonCloseApp.Text = "Hell no";
            buttonCloseApp.UseVisualStyleBackColor = true;
            buttonCloseApp.Visible = false;
            buttonCloseApp.Click += buttonCloseApp_Click;
            // 
            // labelAnnouncingWinner
            // 
            labelAnnouncingWinner.AutoSize = true;
            labelAnnouncingWinner.Font = new Font("Stencil-grungy", 50F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAnnouncingWinner.Location = new Point(230, 55);
            labelAnnouncingWinner.Name = "labelAnnouncingWinner";
            labelAnnouncingWinner.Size = new Size(0, 63);
            labelAnnouncingWinner.TabIndex = 11;
            // 
            // labelPlayAgain
            // 
            labelPlayAgain.AutoSize = true;
            labelPlayAgain.Font = new Font("Stencil-grungy", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPlayAgain.Location = new Point(302, 244);
            labelPlayAgain.Name = "labelPlayAgain";
            labelPlayAgain.Size = new Size(310, 37);
            labelPlayAgain.TabIndex = 11;
            labelPlayAgain.Text = "Play Again?";
            labelPlayAgain.Visible = false;
            // 
            // ShotgunForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 530);
            Controls.Add(labelPlayAgain);
            Controls.Add(labelAnnouncingWinner);
            Controls.Add(buttonCloseApp);
            Controls.Add(buttonPlayAgain);
            Controls.Add(labelComputerScore);
            Controls.Add(labelComputerBullets);
            Controls.Add(labelUserBullets);
            Controls.Add(labelUserScore);
            Controls.Add(buttonReload);
            Controls.Add(buttonBlock);
            Controls.Add(buttonShoot);
            Controls.Add(buttonShotgun);
            Name = "ShotgunForm";
            Text = "SHOTGUN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelComputerScore;
        private Label labelUserScore;
        private Button buttonReload;
        private Button buttonBlock;
        private Button buttonShoot;
        private Button buttonShotgun;
        private Button buttonPlayAgain;
        private Button buttonCloseApp;
        public Label labelComputerBullets;
        public Label labelUserBullets;
        public Label labelAnnouncingWinner;
        public Label labelPlayAgain;
    }
}