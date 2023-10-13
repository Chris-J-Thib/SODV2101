using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Media;
using System.Runtime.Versioning;
using System.Diagnostics;
using System.Threading;

namespace BlackJack
{
    [SupportedOSPlatform("windows")]
    public partial class FormMain : Form
    {
        //Creating Class Constants and variables
        private const string savePath = "./src/saves/data.txt"; //File where the leaderboard data is saved.
        private const string sfxPath = "./src/sfx/";
        private static Color cardColour = Color.White; //card back colour
        private static Color activeButColour = Color.SkyBlue; //when true
        private static Color deadButColour = Color.LightGray; //when false
        private static readonly Color[] colours = { Color.Black, Color.Red }; //colour of suits
        private static readonly string[] suits = { "♠", "♥", "♣", "♦" }; //The Available Suits
        private static readonly string[] cards = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        // Cards in a suit - NOTE A is 11 unless bust then 1, face cards have a value of 10.

        private SoundPlayer gameOver;
        private SoundPlayer bet;
        private SoundPlayer flip;
        private SoundPlayer win;
        private SoundPlayer lose;
        private SoundPlayer tie;


        bool music = true;
        bool sfx = true;
        float highScore = 0;
        int[] deck = new int[suits.Length * cards.Length];
        Random rnd = new Random();

        //initialization
        public FormMain()
        {
            InitializeComponent();
            WMP.URL = @".\src\music\house_party.mp3";
            WMP.settings.playCount = 99999;
            Debug.WriteLine(Directory.GetCurrentDirectory());

            gameOver = new SoundPlayer(sfxPath +
            "zapsplat_multimedia_game_sound_lose_tone_classic_arcade_style_86018.wav");

            bet = new SoundPlayer(sfxPath +
            "zapsplat_foley_money_british_coin_20p_set_down_on_other_coins_in_hand_change_001_90492.wav");

            flip = new SoundPlayer(sfxPath +
            "zapsplat_leisure_trading_card_or_playing_card_single_turn_over_on_table_011_68339.wav");

            win = new SoundPlayer(sfxPath +
            "little_robot_sound_factory_Jingle_Win_Synth_03.wav");

            lose = new SoundPlayer(sfxPath +
            "app_alert_tone_remove_delete_003.wav");

            tie = new SoundPlayer(sfxPath +
            "little_robot_sound_factory_Jingle_Win_Synth_02.wav");

        }

        //when a "new game" starts
        private void FormLoad(object sender, EventArgs e)
        {
            if (music) WMP.Ctlcontrols.play();
            GetLB();
            funds.Text = "100";
            highScore = 0;
            betMin.Checked = true;
            prvRnds.Items.Clear();
            NewRound();
        }

        //converting from float to a shorter notation so as to not overflow text fields
        private string ShortScore(string score)
        {
            string[] nota = { "", "K", "M", "B", "T", "Qa", "Qi", "H", "S", "O", "N", "D", "?" }; //? would be 1*10^36 float caps at +1*10^38
            float val = float.Parse(score);
            int flag = 0;

            while (val / 1000 >= 1)
            {
                flag++;
                val /= 1000;

            }

            return Math.Round(val, 1).ToString() + nota[Math.Min(flag, nota.Length - 1)];
        }

        //adds the value of a given card to the given player field
        private void AddCount(System.Windows.Forms.TextBox card, Label p)
        {
            int val = 0;
            string[] face = { "J", "Q", "K" };//face cards are worth 10
            if (face.Contains(card.Text.Split(Environment.NewLine)[0]))
            {
                val = 10;
            }
            else if (card.Text.Split(Environment.NewLine)[0] == "A")//aces are worth 11, unless 11 will bust then worth 1
            {
                if (float.Parse(p.Text) + 11 > 21)
                {
                    val = 1;
                }
                else
                {
                    val = 11;
                }
            }
            else //all other cards are their own value
            {
                val = Int32.Parse(card.Text.Split(Environment.NewLine)[0]);
            }

            p.Text = (val + (float.Parse(p.Text))).ToString();

        }

        //For a new round but same game
        private void NewRound()
        {
            //update highscore
            scoreCurrent.Text = ShortScore(highScore.ToString());

            //check if player still has money
            if (float.Parse(funds.Text) > 0)
            {
                //updates betting values
                betAll.Text = funds.Text;
                betHalf.Text = Math.Max(Math.Ceiling(float.Parse(funds.Text.ToString()) / 2), 1).ToString();
                betMin.Text = Math.Max(Math.Round(float.Parse(funds.Text) / 10, 0), 1).ToString();

                //Clearing data from last round
                cardsDealer.Controls.Clear();
                cardsPlayer.Controls.Clear();
                cntDlr.Text = "0";
                cntPlr.Text = "0";
                lblBet.Text = "BET";
                lblActiveBet.Text = "";
                Array.Clear(deck, 0, deck.Length);

                //displaying and hiding controls accordingly and updating display
                lblActiveBet.Hide();
                butHit.Hide();
                butHit.Enabled = false;
                butHold.Hide();
                butHold.Enabled = false;
                butStart.Show();
                butStart.Enabled = true;
                butQuit.Show();
                butQuit.Enabled = true;
                betMin.Show();
                betMin.Enabled = true;
                betHalf.Show();
                betHalf.Enabled = true;
                betAll.Show();
                betAll.Enabled = true;
                Update();
            }
            else
            {
                //game over sequence
                WMP.Ctlcontrols.stop();
                FormEnd end = new FormEnd(highScore);
                if (sfx) gameOver.Play();
                switch (end.ShowDialog())
                {
                    //start a new game
                    case DialogResult.Yes:
                        SetLB();//save score?
                        FormLoad(null, null);
                        break;
                    default://save score? and quit
                        SetLB();
                        Close();
                        break;
                }
            }
        }

        //picks a random card from given deck size 
        /// <summary>
        /// Gets a random card that is not already present on the board
        /// </summary>
        /// <param name="p"></param>
        /// <returns> a card as a control</returns>
        private Control GetCard(Label p)
        {
            //blank card
            System.Windows.Forms.TextBox card = new System.Windows.Forms.TextBox();
            //find an unused card
            while (true)
            {
                int sel = rnd.Next(52);
                if (deck[sel] == 0)
                {
                    //sets look of card
                    deck[sel] = 1;
                    card.BackColor = cardColour;
                    card.ForeColor = colours[(sel / (deck.Length / suits.Length)) % colours.Length];
                    card.Multiline = true;
                    card.TextAlign = HorizontalAlignment.Center;
                    card.Font = new Font(FontFamily.GenericSerif, 13, FontStyle.Regular);
                    card.Size = new Size(25, 40);
                    card.Text = cards[sel % (deck.Length / suits.Length)] + Environment.NewLine + suits[sel / (deck.Length / suits.Length)];
                    card.TabStop = false;
                    card.ReadOnly = true;
                    //adds count to player and returns card
                    if (sfx) flip.Play();
                    AddCount(card, p);
                    return card;
                }
            }
        }

        //loads the leaderboard
        /// <summary>
        /// Populates the leader board based on the data.txt
        /// </summary>
        private void GetLB()
        {
            //clears the data in case of new game yes
            ldrbrd.Controls.Clear();
            try
            {
                //makes sure the file exists
                File.AppendAllText(savePath, "");
                Label lab;


                //reading score and populating a 2d array with score and initals
                string[][] scores = File.ReadAllLines(savePath)
                   .Select(line => line.Split('\t').Select(val => val).ToArray())
                   .ToArray();

                //Ordering items in scores array by highest to lowest score
                scores = scores.OrderByDescending(score => float.Parse(score[1])).ToArray();

                //populates the leaderboard with the info from the scores array
                for (int i = 0; i < Math.Min(scores.Length, 10); i++)
                {
                    for (int j = -1; j < scores[i].Length; j++)
                    {
                        lab = new Label();
                        lab.AutoEllipsis = true;
                        lab.AutoSize = true;

                        if (j == -1)
                        {
                            lab.Text = (i + 1).ToString();
                        }
                        else
                        {
                            if (j == 1)
                            {
                                lab.Text = ShortScore(scores[i][j]);
                            }
                            else
                            {
                                lab.Text = scores[i][j];
                            }
                        }
                        ldrbrd.Controls.Add(lab);

                    }
                }
            }
            catch (IOException e)
            {
                MessageBox.Show("Error:" + e, "ERROR", MessageBoxButtons.OK);

            }
            Update();
        }

        /// <summary>
        /// Prompts the user, and updates the save file.
        /// </summary>
        /// <returns> save was updated true/false </returns>
        private bool SetLB()
        {
            //prompts if you would like to save your score   
            switch (MessageBox.Show(this, "Would you like to save your highscore of " + ShortScore(highScore.ToString()) + "?", "Save Score?", MessageBoxButtons.YesNoCancel))
            {
                case DialogResult.Yes:
                    try
                    {
                        //launches the save form to get initials
                        FormSave save = new FormSave();
                        System.Windows.Forms.TextBox tb = new System.Windows.Forms.TextBox();
                        save.Text += ShortScore(highScore.ToString());


                        switch (save.ShowDialog())
                        {
                            //if ok is pressed, update the save file
                            case DialogResult.OK:
                                File.AppendAllText(savePath, save.Controls[1].Text + '\t' + highScore + '\n');
                                return true;
                            default:
                                return false;
                        }
                    }
                    catch (IOException e)
                    {
                        //if the save file is corrupt or something
                        MessageBox.Show("Error:" + e, "ERROR", MessageBoxButtons.OK);
                        return false;
                    }
                case DialogResult.No:
                    return true;
                default:
                    return false;
            }
        }

        //updates funds based on a given positive or negative value
        private void ChangeFunds(float val)
        {
            funds.Text = (float.Parse(funds.Text) + val).ToString();
        }

        //starts the next round
        private void ClickStart(object sender, EventArgs e)
        {
            if (!(sender as Control).Enabled) return;
            //sets display
            butHit.Show();
            butHit.Enabled = true;
            butHold.Show();
            butHold.Enabled = true;
            butStart.Hide();
            butStart.Enabled = false;
            butQuit.Hide();
            butQuit.Enabled = false;
            betMin.Hide();
            betMin.Enabled = false;
            betHalf.Hide();
            betHalf.Enabled = false;
            betAll.Hide();
            betAll.Enabled = false;
            //gets starting cards
            cardsPlayer.Controls.Add(GetCard(cntPlr));
            cardsPlayer.Controls.Add(GetCard(cntPlr));
            cardsDealer.Controls.Add(GetCard(cntDlr));
            Update();

            //charges the bet
            if (betMin.Checked)
            {
                lblActiveBet.Text = betMin.Text;
                ChangeFunds(-float.Parse(betMin.Text));

            }
            else if (betHalf.Checked)
            {
                lblActiveBet.Text = betHalf.Text;
                ChangeFunds(-float.Parse(betHalf.Text));
            }
            else
            {
                lblActiveBet.Text = betAll.Text;
                ChangeFunds(-float.Parse(betAll.Text));
            }
            if (sfx) bet.Play();
            //shows the bet and checks if the player has won on the draw
            lblActiveBet.Show();
            CheckWin(cntPlr);
            Update();

        }

        //starts the dealer's turn
        private void ClickHold(object sender, EventArgs e)
        {
            //updates display
            if (!(sender as Control).Enabled) return;
            butHit.Hide();
            butHit.Enabled = false;
            butHold.Hide();
            butHold.Enabled = false;
            Update();
            //dealer loop
            while (true)
            {
                System.Threading.Thread.Sleep(1000);
                cardsDealer.Controls.Add(GetCard(cntDlr));
                Update();
                if (CheckWin(cntDlr)) break;//will always end the infinite loop.
            }
        }

        //adds card to player's cards
        private void ClickHit(object sender, EventArgs e)
        {
            if (!(sender as Control).Enabled) return;
            butHit.Enabled = false;
            cardsPlayer.Controls.Add(GetCard(cntPlr));
            Update();
            CheckWin(cntPlr);
        }

        //checks if the given player has won, lost, bust, or tied
        private bool CheckWin(Label p)
        {
            int count = Int32.Parse(p.Text);

            if (p.Name == "cntPlr")
            {
                if (count > 21)
                {
                    EndRound(0);
                }
                else if (count == 21)
                {
                    EndRound(1);
                }
                butHit.Enabled = true;
                return false;
            }
            else
            {
                if (count > 21)
                {
                    EndRound(1);
                    return true;
                }
                else if (count > Int32.Parse(cntPlr.Text))
                {
                    EndRound(3);
                    return true;
                }
                else if (count == Int32.Parse(cntPlr.Text))
                {
                    EndRound(2);
                    return true;
                }
                return false;
            }

        }

        private void ClickSFX(object sender, EventArgs e)
        {
            if (sfx)
            {
                sfx = false;
                butSFX.BackColor = deadButColour;
            }
            else
            {
                sfx = true;
                butSFX.BackColor = activeButColour;
            }
        }
        private void ClickMusic(object sender, EventArgs e)
        {
            if (music)
            {
                music = false;
                butMusic.BackColor = deadButColour;
                WMP.Ctlcontrols.pause();
            }
            else
            {
                music = true;
                butMusic.BackColor = activeButColour;
                WMP.Ctlcontrols.play();

            }
        }


        //event handles quit button
        private void ClickQuit(object sender, EventArgs e)
        {
            //checks if you want to save your score before quiting. or if you hit cancle it cancles the quit
            if (!(sender as Control).Enabled) return;
            if (SetLB()) Close();
        }

        //event handles help button
        private void ClickHelp(object sender, CancelEventArgs e)
        {
            //displays the help form
            FormHelp help = new FormHelp();
            help.Show();
        }

        //ends the game based on the state provided by checkWin
        private void EndRound(int state) //0 bust, 1 win, 2 tie, 3 lose
        {
            butHit.Hide();
            butHit.Enabled = false;
            butHold.Hide();
            butHold.Enabled = false;
            switch (state)
            {
                case 0:
                    if (sfx) lose.Play();
                    prvRnds.Items.Insert(0, "-" + lblActiveBet.Text);
                    lblBet.Text = "BUST!";
                    highScore++;
                    break;
                case 1:
                    if (sfx) win.Play();
                    ChangeFunds(float.Parse(lblActiveBet.Text) * 2);
                    prvRnds.Items.Insert(0, "+" + (float.Parse(lblActiveBet.Text) * 2).ToString());
                    lblBet.Text = "WIN!";
                    highScore += (float.Parse(lblActiveBet.Text) * 2) + 1;
                    break;
                case 2:
                    if (sfx) tie.Play();
                    ChangeFunds(float.Parse(lblActiveBet.Text));
                    prvRnds.Items.Insert(0, "0");
                    lblBet.Text = "TIE!";
                    highScore += float.Parse(lblActiveBet.Text) + 1;
                    break;
                case 3:
                    if (sfx) lose.Play();
                    prvRnds.Items.Insert(0, "-" + lblActiveBet.Text);
                    lblBet.Text = "LOSE!";
                    highScore++;
                    break;

            }
            //updates score
            scoreCurrent.Text = ShortScore((highScore).ToString());
            Update();
            System.Threading.Thread.Sleep(3000);
            NewRound();

        }

    }
}
