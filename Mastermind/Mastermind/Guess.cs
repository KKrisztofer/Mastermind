using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    internal class Guess
    {
        private ColorItem[] items;
        private FeedbackState[] feedbacks;
        private int colorIndex;

        internal ColorItem[] Items { get => items; set => items = value; }
        internal FeedbackState[] Feedbacks { get => feedbacks; set => feedbacks = value; }
        public int ColorIndex { get => colorIndex; set => colorIndex = value; }

        public Guess()
        {
            this.Items = new ColorItem[4];
            this.Feedbacks = new FeedbackState[4];
            for (int i = 0; i < this.Items.Length; i++)
            {
                this.Items[i] = ColorItem.NewEmpty();
                this.feedbacks[i] = FeedbackState.None;
            }
            this.colorIndex = 0;
        }

        public bool NextGuessIs(Color guess)
        {
            if (colorIndex < 4)
            {
                this.Items[colorIndex].SetColor(guess);
                this.colorIndex++;
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public bool RemoveLastGuess()
        {
            if (this.colorIndex > 0)
            {
                this.Items[colorIndex-1].RemoveColor();
                this.colorIndex--;
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool Win()
        {
            for (int i = 0; i < this.Feedbacks.Length; i++)
            {
                if (this.Items[i].Color != Game.CurrentGame.HiddenColors[i].Color)
                {
                    return false;
                }
            }
            return true;
        }

        public void Evaluate()
        {
            int includedAndRightPlace = 0;
            int includedButWrongPlace = 0;
            List<Color> remainingHiddenColors = new List<Color>();

            foreach (ColorItem item in Game.CurrentGame.HiddenColors)
            {
                remainingHiddenColors.Add(item.Color);
            }

            for (int i = 0; i < items.Length; i++)
            {
                Color itemColor = items[i].Color;

                if (itemColor == Game.CurrentGame.HiddenColors[i].Color)
                {
                    includedAndRightPlace++;
                    remainingHiddenColors.Remove(itemColor);
                }
            }

            for (int i = 0; i < items.Length; i++)
            {
                Color itemColor = items[i].Color;

                if (itemColor != Game.CurrentGame.HiddenColors[i].Color)
                {
                    if (remainingHiddenColors.Contains(itemColor))
                    {
                        includedButWrongPlace++;
                        remainingHiddenColors.Remove(itemColor);
                    }
                }
            }

            int feedbackIndex = 0;
            for (int i = 0; i < includedAndRightPlace; i++)
            {
                feedbacks[feedbackIndex++] = FeedbackState.IncludedRightPlace;
            }

            for (int i = 0; i < includedButWrongPlace; i++)
            {
                feedbacks[feedbackIndex++] = FeedbackState.IncludedNotRightPlace;
            }

            for (int i = feedbackIndex; i < feedbacks.Length; i++)
            {
                feedbacks[i] = FeedbackState.None;
            }
        }
    }
}
