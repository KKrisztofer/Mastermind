using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    internal class ColorItem
    {
        private ItemState state;
        private Color color;

        public ItemState State { get => state; set => state = value; }
        public Color Color { get => color; set => color = value; }

        public ColorItem()
        {
            this.State = ItemState.None;
        }
        public ColorItem(Color color)
        {
            this.State = ItemState.None;
            this.color = color;
        }
        public void SetColor(Color color)
        {
            this.Color = color;
            this.State = ItemState.Color;
        }
        public void RemoveColor()
        {
            this.State = ItemState.None;
        }
        public Color GetColor()
        {
            switch (this.State)
            {
                case ItemState.None:
                    return Color.White;
                case ItemState.Color:
                    return this.Color;
                case ItemState.WaitToGuess:
                    return Color.Turquoise;
                default:
                    return Color.Transparent;
            }
        }
        public static ColorItem NewEmpty()
        {
            return new ColorItem();
        }
    }
}
