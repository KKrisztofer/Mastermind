using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastermind
{
    internal class Game
    {
        private ColorItem[] hiddenColors;
        private bool revealedHiddenColors;
        private Guess[] guesses;
        private int round;

        static public Game CurrentGame;

        internal Guess[] Guesses { get => guesses; set => guesses = value; }
        public int Round { get => round; set => round = value; }
        internal ColorItem[] HiddenColors { get => hiddenColors; set => hiddenColors = value; }
        public bool RevealedHiddenColors { get => revealedHiddenColors; set => revealedHiddenColors = value; }

        public Game()
        {
            this.GenerateColors();
            this.HideHiddenColors();
            this.guesses = new Guess[10];
            for (int i = 0; i < this.guesses.Length; i++)
            {
                this.guesses[i] = new Guess();
            }
            this.Round = 0;
        }
        public static void NewGame()
        {
            Game.CurrentGame = new Game();
        }
        private void GenerateColors()
        {
            Random rnd = new Random();
            this.HiddenColors = new ColorItem[4];
            for (int i = 0; i < this.HiddenColors.Length; i++)
            {
                switch (rnd.Next(0, 6)) {
                    case 0:
                        HiddenColors[i] = new ColorItem(Color.Yellow);
                        break;
                    case 1:
                        HiddenColors[i] = new ColorItem(Color.Blue);
                        break;
                    case 2:
                        HiddenColors[i] = new ColorItem(Color.Red);
                        break;
                    case 3:
                        HiddenColors[i] = new ColorItem(Color.Pink);
                        break;
                    case 4:
                        HiddenColors[i] = new ColorItem(Color.Orange);
                        break;
                    case 5:
                        HiddenColors[i] = new ColorItem(Color.Green);
                        break;
                }
            }
        }

        public static bool ReadyToPlay()
        {
            return Game.CurrentGame != null;
        }
        public int RoundNumber()
        {
            return this.Round;
        }
        public Guess RecentGuess()
        {
            return this.Guesses[this.Round];
        }
        public bool NextGuessIs(Color color)
        {
            return Game.CurrentGame.guesses[this.Round].NextGuessIs(color);
        }

        public GameState NextRound()
        {
            if (this.Round < 10 && this.Guesses[this.Round].ColorIndex == 4)
            {
                this.guesses[this.Round].Evaluate();
                if (this.guesses[this.Round].Win())
                {
                    this.ShowHiddenColors();
                    return GameState.Winner;
                }
                if (this.Round == 9)
                {
                    this.ShowHiddenColors();
                    return GameState.GameOver;
                }
                this.Round++;
                return GameState.NextRound;
            }
            else
            {
                return GameState.None;
            }
        }

        public void ShowHiddenColors()
        {
            this.revealedHiddenColors = true;
        }
        public void HideHiddenColors()
        {
            this.revealedHiddenColors = false;
        }
        

        static public void GameOver()
        {
            Game.CurrentGame = null;
        }
    }
}
