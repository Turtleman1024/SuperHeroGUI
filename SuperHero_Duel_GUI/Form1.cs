using System;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace SuperHero_Duel_GUI
{
    public partial class Form1 : Form
    {

        //private SuperHero captain = new SuperHero("Captain America", 10, 12, 8);
        //private SuperHero red_skull = new SuperHero("Red Skull", 12, 12, 6);

        private MetaHuman Captain = new Hero("Captain America", 10, 12, 8);
        private MetaHuman Thanos = new Villian("Thanos", 12, 12, 6);

        public Form1()
        {

            InitializeComponent();

            UpdateHealthBar();
        }

        private async void Attack_button_ClickAsync(object sender, EventArgs e)
        {
            ///Set the attack Images to visable
            await SetAttackImageAsync();

            ///Show the health bars
            UpdateHealthBar();

            ///Display that the duel has begun
            greeting_label.Text = "Fight!";

            ///Clear the action label
            action_label.Text = "";

            ///Start the fight 
            StartBattle(ref Captain, ref Thanos);            
        }


        /// <summary>
        /// A method that makes the MetaHuman health bar visible
        /// </summary>
        private void UpdateHealthBar()
        {
            hero_health_label.Visible = true;
            villian_health_label.Visible = true;

            hero_health_label.Text = Captain.Name +" Health: " + Captain.GetHealth();
            villian_health_label.Text = Thanos.Name + " Health: " + Thanos.GetHealth();
        }

        /// <summary>
        /// This method starts the battle of the two MetaHumans.
        /// </summary>
        /// <param name="fighter1">The hero of the duel</param>
        /// <param name="fighter2">The villian of the duel</param>
        private void StartBattle(ref MetaHuman fighter1, ref MetaHuman fighter2)
        {
            
            ///Check if they knocked each other out
            if (fighter1.GetHealth() <= 0 && fighter2.GetHealth() <= 0)
            {
                ///Set the health of the heroes back to original, game on.
                hero_health_label.Visible = false;
                villian_health_label.Visible = false;

                ///Display message to the greeting label that a draw has occured.
                action_label.Text += "Duel is a draw";

                ///Set background image to the appropriate images.
                HeroLossAnimation(hero_picture_box);
                VillianLossAnimation(villian_picture_box);

                ///Disable attack button
                attack_button.Enabled = false;
                attack_button.Visible = false;

                ///Activate rest button
                reset_button.Visible = true;
                reset_button.Enabled = true;

                return;
            }
            
            ///Neither fighter has been knocked out, fight.
            ///Fighter1 attacks first
            Battle(ref fighter1, ref fighter2);
            

            ///Check if fighter2 has not been knocked out
            if (fighter2.GetHealth() <= 0)
            {
                ///Display message to the action label that red skull has been knocked out and captain is victorius.
                action_label.Text += "\n\n" + fighter2.Name + " has been knocked out and " + fighter1.Name + " is Victorius\n";

                ///Display message of the winner in greeting label
                greeting_label.Text = fighter1.Name + " Wins!";

                ///Set background image to the appropriate images.
                HeroWinAnimation(hero_picture_box);
                VillianLossAnimation(villian_picture_box);

                ///Disable attack button
                attack_button.Enabled = false;
                attack_button.Visible = false;

                ///Activate rest button
                reset_button.Visible = true;
                reset_button.Enabled = true;

                return;
            }


            ////Fighter2 attacks back
            Battle(ref fighter2, ref fighter1);

            ///Check if fighter1 has not been knocked out
            if (fighter1.GetHealth() <= 0)
            {
                ///Display message to the action label that fighter1 has been knocked out and fighter2 is victorius.
                action_label.Text += "\n\n" + fighter1.Name + " has been knocked out and " + fighter2.Name + " is Victorius\n";

                ///Display message of the winner in greeting label
                greeting_label.Text = fighter2.Name + " Wins!";

                ///Set background image to the appropriate images. 
                HeroLossAnimation(hero_picture_box);
                VillianWinAnimation(villian_picture_box);

                ///Disable attack button
                attack_button.Enabled = false;
                attack_button.Visible = false;

                ///Activate rest button
                reset_button.Visible = true;
                reset_button.Enabled = true;

                return;
            }

        }

        /// <summary>
        /// A method that has fighter1 attack fighter2
        /// </summary>
        private void Battle(ref MetaHuman fighter1, ref MetaHuman fighter2)
        {
            ///Create a new battle 
            Fight battle = new Fight(ref fighter1, ref fighter2);

            /// Start a battle
            battle.StartBattle();

            ///Get the results and 
            action_label.Text += battle.GetResults();

            ///Update the health bars
            UpdateHealthBar();

        }

        /// <summary>
        /// A method that sets the background image to attack stance.
        /// </summary>
        private async Task SetAttackImageAsync()
        {
            switch (Captain.GetBattlesFought())
            {
                case 1 :
                    await HeroAttackAnimation2Async(hero_picture_box);
                    break;
                case 2 :
                    await HeroAttackAnimation3Async(hero_picture_box);
                    break;
                default :
                    await HeroAttackAnimation1Async(hero_picture_box);
                    break;
            }

            switch (Thanos.GetBattlesFought())
            {
                case 1 :
                    await VillianAttackAnimation2Async(villian_picture_box);
                    break;
                case 2 :
                    await VillianAttackAnimation3Async(villian_picture_box);
                    break;
                default:
                    await VillianAttackAnimation1Async(villian_picture_box);
                    break;
            }

        }


        #region Thanos Action Animation

        /// <summary>
        /// A method that sets thano's attack one animation
        /// </summary>
        /// <param name="currentBox">The current picture box</param>
        private async Task VillianAttackAnimation1Async(PictureBox currentBox)
        {
            GenerateFrames frames = new GenerateFrames(Properties.Resources.than_attack1);
            for (int index = 0; index < frames.GetLength(); index++)
            {
                currentBox.Image = frames.GetImages(index);
                await Task.Delay(60);

            }
            VillianIntoAnimation(currentBox);
        }

        /// <summary>
        /// A method that sets thano's attack two animation
        /// </summary>
        /// <param name="currentBox">The current picture box</param>
        private async Task VillianAttackAnimation3Async(PictureBox currentBox)
        {
            GenerateFrames frames = new GenerateFrames(Properties.Resources.than_attack2);
            for (int index = 0; index < frames.GetLength(); index++)
            {
                currentBox.Image = frames.GetImages(index);
                await Task.Delay(60);

            }
            VillianIntoAnimation(currentBox);
        }

        /// <summary>
        /// A method that sets thano's attack three animation
        /// </summary>
        /// <param name="currentBox">The current picture box</param>
        private async Task VillianAttackAnimation2Async(PictureBox currentBox)
        {
            GenerateFrames frames = new GenerateFrames(Properties.Resources.than_attack1);
            for (int index = 0; index < frames.GetLength(); index++)
            {
                currentBox.Image = frames.GetImages(index);
                await Task.Delay(60);

            }
            VillianIntoAnimation(currentBox);
        }

        /// <summary>
        /// A method that sets hero's into animation
        /// </summary>
        /// <param name="currentBox">The current picture box</param>
        private void VillianIntoAnimation(PictureBox currentBox)
        {
            currentBox.Image = Properties.Resources.than_stand;
            currentBox.Refresh();
            currentBox.Visible = true;
        }

        /// <summary>
        /// A method that sets thano's defeat animation
        /// </summary>
        /// <param name="currentBox">The current picture box</param>
        private void VillianLossAnimation(PictureBox currentBox)
        {
            currentBox.Image = Properties.Resources.than_defeat;
            currentBox.Refresh();
            currentBox.Visible = true;
        }

        /// <summary>
        /// A method that sets thano's victory animation
        /// </summary>
        /// <param name="currentBox">The current picture box</param>
        private void VillianWinAnimation(PictureBox currentBox)
        {
            currentBox.Image = Properties.Resources.thanos_wins;
            currentBox.Refresh();
            currentBox.Visible = true;
        }
        #endregion

        #region Captain Action Animation
        /// <summary>
        /// A method that sets captain's attack one animation
        /// </summary>
        /// <param name="currentBox">The current picture box</param>
        private async Task HeroAttackAnimation1Async(PictureBox currentBox)
        {
            GenerateFrames frames = new GenerateFrames(Properties.Resources.captain_cartoon_attack1);
            for (int index = 0; index < frames.GetLength(); index++)
            {
                currentBox.Image = frames.GetImages(index);
                await Task.Delay(60);

            }
            HeroIntoAnimation(currentBox);
        }

        /// <summary>
        /// A method that sets captain's attack two animation
        /// </summary>
        /// <param name="currentBox">The current picture box</param>
        private async Task HeroAttackAnimation2Async(PictureBox currentBox)
        {
            GenerateFrames frames = new GenerateFrames(Properties.Resources.captain_cartoon_attack2gif);
            //Image[] frames = GetFrames(Properties.Resources.captain_cartoon_attack2gif);
            for (int index = 0; index < frames.GetLength(); index++)
            {
                currentBox.Image = frames.GetImages(index);
                await Task.Delay(60);

            }
            HeroIntoAnimation(currentBox);
        }

        /// <summary>
        /// A method that sets captain's attack three animation
        /// </summary>
        /// <param name="currentBox">The current picture box</param>
        private async Task HeroAttackAnimation3Async(PictureBox currentBox)
        {
            GenerateFrames frames = new GenerateFrames(Properties.Resources.captain_cartoon_attack3);
            for (int index = 0; index < frames.GetLength(); index++)
            {
                currentBox.Image = frames.GetImages(index);
                await Task.Delay(60);

            }
            HeroIntoAnimation(currentBox);
        }

        /// <summary>
        /// A method that sets hero's into animation
        /// </summary>
        /// <param name="currentBox">The current picture box</param>
        private void HeroIntoAnimation(PictureBox currentBox)
        {
            currentBox.Image = Properties.Resources.captain_cartoon_standing;
            currentBox.Refresh();
            currentBox.Visible = true;
        }

        /// <summary>
        /// A method that sets captain's defeat animation
        /// </summary>
        /// <param name="currentBox">The current picture box</param>
        private void HeroLossAnimation(PictureBox currentBox)
        {
            currentBox.Image = Properties.Resources.captain_cartoon_defeat;
            currentBox.Refresh();
            currentBox.Visible = true;
        }

        /// <summary>
        /// A method that sets captain's victory animation
        /// </summary>
        /// <param name="currentBox">The current picture box</param>
        private void HeroWinAnimation(PictureBox currentBox)
        {
            /*Image[] frames = GetFrames(Properties.Resources.captain_cartoon_victory);
            for (int index = 0; index < frames.Length; index++)
            {
                currentBox.Image = frames[index];
                await Task.Delay(60);

            }*/
            currentBox.Image = Properties.Resources.captain_cartoon_victory;
            currentBox.Refresh();
            currentBox.Visible = true;
        }
        #endregion

        private void Reset_button_Click(object sender, EventArgs e)
        {
            ///Set images back to standing images
            SetStandingImage();

            ///Set the health of the MetaHumans back to original, game on.                
            Thanos.SetHealth(12);
            Captain.SetHealth(10);
            Captain.ZeroBattle();
            Thanos.ZeroBattle();

            ///Update the health bars
            UpdateHealthBar();

            ///Clear the attack label
            action_label.Text = "";

            ///Swap buttons
            attack_button.Enabled = true;
            attack_button.Visible = true;
            reset_button.Enabled = false;
            reset_button.Visible = false;

            ///Change greeting label
            greeting_label.Text = "Who will win?";


        }

        /// <summary>
        /// A method that changing the picture boxes to standing image
        /// </summary>
        private void SetStandingImage()
        {
            hero_picture_box.Refresh();
            villian_picture_box.Refresh();
            hero_picture_box.Image = Properties.Resources.captain_cartoon_standing;
            villian_picture_box.Image = Properties.Resources.than_stand;
        }

        /// <summary>
        /// A method that extracts the frames of a gif and flips the image horizantally.
        /// This method is untest.
        /// </summary>
        /// <param name="originalGif">The original gif</param>
        /// <returns>Array of image frames</returns>
        private Image[] GetFlippedFrames(Image originalGif)
        {
            ///Get the frame count of the gif
            int numberOfFrames = originalGif.GetFrameCount(FrameDimension.Time);

            ///New image array to store the extracted frames
            Image[] frames = new Image[numberOfFrames];

            ///Loop through the gif and store each frame in the frames array
            for (int i = 0; i < numberOfFrames; i++)
            {
                originalGif.SelectActiveFrame(FrameDimension.Time, i);
                frames[i] = new Bitmap(originalGif);
                frames[i].RotateFlip(RotateFlipType.RotateNoneFlipX);
                //frames[i] = ((Image)originalGif.Clone());
            }

            return frames;
        }

    }
}
