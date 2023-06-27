using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mastermind
{
    public partial class mainForm : Form
    {
        static private Color formBackColor = Color.GhostWhite;
        static private Color toolStripBackColor = Color.Ivory;
        static private Color guessAreaBackColor = Color.LightSteelBlue;
        static private Color guessPanelBackColor = Color.Ivory;
        static private Color activeGuessPanelBackColor = Color.DodgerBlue;
        static private Color itemDefaultColor = Color.Wheat;
        static private Color itemFontColor = Color.Tan;
        static private Color feedbackPanelDefaultColor = Color.Ivory;
        static private Color feedbackItemDefaultColor = Color.PaleGreen;
        static private Color hiddenItemsPanelBackColor = Color.LightSteelBlue;
        static private Color hiddenItemsDefaultColor = Color.BlanchedAlmond;
        static private Color feedbackIncludedNotRightPlaceColor = Color.White;
        static private Color feedbackIncludedRightPlaceColor = Color.Black;
        public mainForm()
        {
            InitializeComponent();
            SetFormColors();
            Game.NewGame();
            this.RefreshForm();
        }
        private void SetFormColors()
        {
            BackColor = formBackColor;
            guessArea.BackColor = guessAreaBackColor;
            menuStrip1.BackColor = toolStripBackColor;
            hiddenColorsPanel.BackColor = hiddenItemsPanelBackColor;
            colorPanel.BackColor = guessAreaBackColor;
            questionMark1.ForeColor = itemFontColor;
            questionMark2.ForeColor = itemFontColor;
            questionMark3.ForeColor = itemFontColor;
            questionMark4.ForeColor = itemFontColor;

            yellow_btn.BackColor = Color.Yellow;
            blue_btn.BackColor = Color.Blue;
            red_btn.BackColor = Color.Red;
            pink_btn.BackColor = Color.Pink;
            orange_btn.BackColor = Color.Orange;
            green_btn.BackColor = Color.Green;

            Color panelColor = guessPanelBackColor;
            panel1.BackColor = panelColor;
            panel2.BackColor = panelColor;
            panel3.BackColor = panelColor;
            panel4.BackColor = panelColor;
            panel5.BackColor = panelColor;
            panel6.BackColor = panelColor;
            panel7.BackColor = panelColor;
            panel8.BackColor = panelColor;
            panel9.BackColor = panelColor;
            panel10.BackColor = panelColor;

            hiddenColor1.BackColor = hiddenItemsDefaultColor;
            hiddenColor2.BackColor = hiddenItemsDefaultColor;
            hiddenColor3.BackColor = hiddenItemsDefaultColor;
            hiddenColor4.BackColor = hiddenItemsDefaultColor;
            questionMark1.BackColor = hiddenItemsDefaultColor;
            questionMark2.BackColor = hiddenItemsDefaultColor;
            questionMark3.BackColor = hiddenItemsDefaultColor;
            questionMark4.BackColor = hiddenItemsDefaultColor;

            Color itemColor = itemDefaultColor;
            color1.BackColor = itemColor;
            color2.BackColor = itemColor;
            color3.BackColor = itemColor;
            color4.BackColor = itemColor;
            color5.BackColor = itemColor;
            color6.BackColor = itemColor;
            color7.BackColor = itemColor;
            color8.BackColor = itemColor;
            color9.BackColor = itemColor;
            color10.BackColor = itemColor;
            color11.BackColor = itemColor;
            color12.BackColor = itemColor;
            color13.BackColor = itemColor;
            color14.BackColor = itemColor;
            color15.BackColor = itemColor;
            color16.BackColor = itemColor;
            color17.BackColor = itemColor;
            color18.BackColor = itemColor;
            color19.BackColor = itemColor;
            color20.BackColor = itemColor;
            color21.BackColor = itemColor;
            color22.BackColor = itemColor;
            color23.BackColor = itemColor;
            color24.BackColor = itemColor;
            color25.BackColor = itemColor;
            color26.BackColor = itemColor;
            color27.BackColor = itemColor;
            color28.BackColor = itemColor;
            color29.BackColor = itemColor;
            color30.BackColor = itemColor;
            color31.BackColor = itemColor;
            color32.BackColor = itemColor;
            color33.BackColor = itemColor;
            color34.BackColor = itemColor;
            color35.BackColor = itemColor;
            color36.BackColor = itemColor;
            color37.BackColor = itemColor;
            color38.BackColor = itemColor;
            color39.BackColor = itemColor;
            color40.BackColor = itemColor;

            xMark1.BackColor = itemColor;
            xMark2.BackColor = itemColor;
            xMark3.BackColor = itemColor;
            xMark4.BackColor = itemColor;
            xMark5.BackColor = itemColor;
            xMark6.BackColor = itemColor;
            xMark7.BackColor = itemColor;
            xMark8.BackColor = itemColor;
            xMark9.BackColor = itemColor;
            xMark10.BackColor = itemColor;
            xMark11.BackColor = itemColor;
            xMark12.BackColor = itemColor;
            xMark13.BackColor = itemColor;
            xMark14.BackColor = itemColor;
            xMark15.BackColor = itemColor;
            xMark16.BackColor = itemColor;
            xMark17.BackColor = itemColor;
            xMark18.BackColor = itemColor;
            xMark19.BackColor = itemColor;
            xMark20.BackColor = itemColor;
            xMark21.BackColor = itemColor;
            xMark22.BackColor = itemColor;
            xMark23.BackColor = itemColor;
            xMark24.BackColor = itemColor;
            xMark25.BackColor = itemColor;
            xMark26.BackColor = itemColor;
            xMark27.BackColor = itemColor;
            xMark28.BackColor = itemColor;
            xMark29.BackColor = itemColor;
            xMark30.BackColor = itemColor;
            xMark31.BackColor = itemColor;
            xMark32.BackColor = itemColor;
            xMark33.BackColor = itemColor;
            xMark34.BackColor = itemColor;
            xMark35.BackColor = itemColor;
            xMark36.BackColor = itemColor;
            xMark37.BackColor = itemColor;
            xMark38.BackColor = itemColor;
            xMark39.BackColor = itemColor;
            xMark40.BackColor = itemColor;

            xMark1.ForeColor = itemFontColor;
            xMark2.ForeColor = itemFontColor;
            xMark3.ForeColor = itemFontColor;
            xMark4.ForeColor = itemFontColor;
            xMark5.ForeColor = itemFontColor;
            xMark6.ForeColor = itemFontColor;
            xMark7.ForeColor = itemFontColor;
            xMark8.ForeColor = itemFontColor;
            xMark9.ForeColor = itemFontColor;
            xMark10.ForeColor = itemFontColor;
            xMark11.ForeColor = itemFontColor;
            xMark12.ForeColor = itemFontColor;
            xMark13.ForeColor = itemFontColor;
            xMark14.ForeColor = itemFontColor;
            xMark15.ForeColor = itemFontColor;
            xMark16.ForeColor = itemFontColor;
            xMark17.ForeColor = itemFontColor;
            xMark18.ForeColor = itemFontColor;
            xMark19.ForeColor = itemFontColor;
            xMark20.ForeColor = itemFontColor;
            xMark21.ForeColor = itemFontColor;
            xMark22.ForeColor = itemFontColor;
            xMark23.ForeColor = itemFontColor;
            xMark24.ForeColor = itemFontColor;
            xMark25.ForeColor = itemFontColor;
            xMark26.ForeColor = itemFontColor;
            xMark27.ForeColor = itemFontColor;
            xMark28.ForeColor = itemFontColor;
            xMark29.ForeColor = itemFontColor;
            xMark30.ForeColor = itemFontColor;
            xMark31.ForeColor = itemFontColor;
            xMark32.ForeColor = itemFontColor;
            xMark33.ForeColor = itemFontColor;
            xMark34.ForeColor = itemFontColor;
            xMark35.ForeColor = itemFontColor;
            xMark36.ForeColor = itemFontColor;
            xMark37.ForeColor = itemFontColor;
            xMark38.ForeColor = itemFontColor;
            xMark39.ForeColor = itemFontColor;
            xMark40.ForeColor = itemFontColor;




            Color feedbackPanelColor = feedbackPanelDefaultColor;
            feedbackPanel1.BackColor = feedbackPanelColor;
            feedbackPanel2.BackColor = feedbackPanelColor;
            feedbackPanel3.BackColor = feedbackPanelColor;
            feedbackPanel4.BackColor = feedbackPanelColor;
            feedbackPanel5.BackColor = feedbackPanelColor;
            feedbackPanel6.BackColor = feedbackPanelColor;
            feedbackPanel7.BackColor = feedbackPanelColor;
            feedbackPanel8.BackColor = feedbackPanelColor;
            feedbackPanel9.BackColor = feedbackPanelColor;
            feedbackPanel10.BackColor = feedbackPanelColor;

            Color feedbackColor = feedbackItemDefaultColor;
            feedback1.BackColor = feedbackColor;
            feedback2.BackColor = feedbackColor;
            feedback3.BackColor = feedbackColor;
            feedback4.BackColor = feedbackColor;
            feedback5.BackColor = feedbackColor;
            feedback6.BackColor = feedbackColor;
            feedback7.BackColor = feedbackColor;
            feedback8.BackColor = feedbackColor;
            feedback9.BackColor = feedbackColor;
            feedback10.BackColor = feedbackColor;
            feedback11.BackColor = feedbackColor;
            feedback12.BackColor = feedbackColor;
            feedback13.BackColor = feedbackColor;
            feedback14.BackColor = feedbackColor;
            feedback15.BackColor = feedbackColor;
            feedback16.BackColor = feedbackColor;
            feedback17.BackColor = feedbackColor;
            feedback18.BackColor = feedbackColor;
            feedback19.BackColor = feedbackColor;
            feedback20.BackColor = feedbackColor;
            feedback21.BackColor = feedbackColor;
            feedback22.BackColor = feedbackColor;
            feedback23.BackColor = feedbackColor;
            feedback24.BackColor = feedbackColor;
            feedback25.BackColor = feedbackColor;
            feedback26.BackColor = feedbackColor;
            feedback27.BackColor = feedbackColor;
            feedback28.BackColor = feedbackColor;
            feedback29.BackColor = feedbackColor;
            feedback30.BackColor = feedbackColor;
            feedback31.BackColor = feedbackColor;
            feedback32.BackColor = feedbackColor;
            feedback33.BackColor = feedbackColor;
            feedback34.BackColor = feedbackColor;
            feedback35.BackColor = feedbackColor;
            feedback36.BackColor = feedbackColor;
            feedback37.BackColor = feedbackColor;
            feedback38.BackColor = feedbackColor;
            feedback39.BackColor = feedbackColor;
            feedback40.BackColor = feedbackColor;
        }
        private void RefreshForm()
        {
            if (Game.ReadyToPlay())
            {
                Color panelColor = guessPanelBackColor;
                Color activePanelColor = activeGuessPanelBackColor;
                switch (Game.CurrentGame.RoundNumber())
                {
                    case 0:
                        panel1.BackColor = activePanelColor;
                        panel2.BackColor = panelColor;
                        panel3.BackColor = panelColor;
                        panel4.BackColor = panelColor;
                        panel5.BackColor = panelColor;
                        panel6.BackColor = panelColor;
                        panel7.BackColor = panelColor;
                        panel8.BackColor = panelColor;
                        panel9.BackColor = panelColor;
                        panel10.BackColor = panelColor;
                        break;
                    case 1:
                        panel1.BackColor = panelColor;
                        panel2.BackColor = activePanelColor;
                        panel3.BackColor = panelColor;
                        panel4.BackColor = panelColor;
                        panel5.BackColor = panelColor;
                        panel6.BackColor = panelColor;
                        panel7.BackColor = panelColor;
                        panel8.BackColor = panelColor;
                        panel9.BackColor = panelColor;
                        panel10.BackColor = panelColor;
                        break;
                    case 2:
                        panel1.BackColor = panelColor;
                        panel2.BackColor = panelColor;
                        panel3.BackColor = activePanelColor;
                        panel4.BackColor = panelColor;
                        panel5.BackColor = panelColor;
                        panel6.BackColor = panelColor;
                        panel7.BackColor = panelColor;
                        panel8.BackColor = panelColor;
                        panel9.BackColor = panelColor;
                        panel10.BackColor = panelColor;
                        break;
                    case 3:
                        panel1.BackColor = panelColor;
                        panel2.BackColor = panelColor;
                        panel3.BackColor = panelColor;
                        panel4.BackColor = activePanelColor;
                        panel5.BackColor = panelColor;
                        panel6.BackColor = panelColor;
                        panel7.BackColor = panelColor;
                        panel8.BackColor = panelColor;
                        panel9.BackColor = panelColor;
                        panel10.BackColor = panelColor;
                        break;
                    case 4:
                        panel1.BackColor = panelColor;
                        panel2.BackColor = panelColor;
                        panel3.BackColor = panelColor;
                        panel4.BackColor = panelColor;
                        panel5.BackColor = activePanelColor;
                        panel6.BackColor = panelColor;
                        panel7.BackColor = panelColor;
                        panel8.BackColor = panelColor;
                        panel9.BackColor = panelColor;
                        panel10.BackColor = panelColor;
                        break;
                    case 5:
                        panel1.BackColor = panelColor;
                        panel2.BackColor = panelColor;
                        panel3.BackColor = panelColor;
                        panel4.BackColor = panelColor;
                        panel5.BackColor = panelColor;
                        panel6.BackColor = activePanelColor;
                        panel7.BackColor = panelColor;
                        panel8.BackColor = panelColor;
                        panel9.BackColor = panelColor;
                        panel10.BackColor = panelColor;
                        break;
                    case 6:
                        panel1.BackColor = panelColor;
                        panel2.BackColor = panelColor;
                        panel3.BackColor = panelColor;
                        panel4.BackColor = panelColor;
                        panel5.BackColor = panelColor;
                        panel6.BackColor = panelColor;
                        panel7.BackColor = activePanelColor;
                        panel8.BackColor = panelColor;
                        panel9.BackColor = panelColor;
                        panel10.BackColor = panelColor;
                        break;
                    case 7:
                        panel1.BackColor = panelColor;
                        panel2.BackColor = panelColor;
                        panel3.BackColor = panelColor;
                        panel4.BackColor = panelColor;
                        panel5.BackColor = panelColor;
                        panel6.BackColor = panelColor;
                        panel7.BackColor = panelColor;
                        panel8.BackColor = activePanelColor;
                        panel9.BackColor = panelColor;
                        panel10.BackColor = panelColor;
                        break;
                    case 8:
                        panel1.BackColor = panelColor;
                        panel2.BackColor = panelColor;
                        panel3.BackColor = panelColor;
                        panel4.BackColor = panelColor;
                        panel5.BackColor = panelColor;
                        panel6.BackColor = panelColor;
                        panel7.BackColor = panelColor;
                        panel8.BackColor = panelColor;
                        panel9.BackColor = activePanelColor;
                        panel10.BackColor = panelColor;
                        break;
                    case 9:
                        panel1.BackColor = panelColor;
                        panel2.BackColor = panelColor;
                        panel3.BackColor = panelColor;
                        panel4.BackColor = panelColor;
                        panel5.BackColor = panelColor;
                        panel6.BackColor = panelColor;
                        panel7.BackColor = panelColor;
                        panel8.BackColor = panelColor;
                        panel9.BackColor = panelColor;
                        panel10.BackColor = activePanelColor;
                        break;
                    default:
                        break;
                }

                if (Game.CurrentGame.RevealedHiddenColors)
                {
                    hiddenColor1.BackColor = Game.CurrentGame.HiddenColors[0].Color;
                    hiddenColor2.BackColor = Game.CurrentGame.HiddenColors[1].Color;
                    hiddenColor3.BackColor = Game.CurrentGame.HiddenColors[2].Color;
                    hiddenColor4.BackColor = Game.CurrentGame.HiddenColors[3].Color;
                    questionMark1.Hide();
                    questionMark2.Hide();
                    questionMark3.Hide();
                    questionMark4.Hide();
                }
                else
                {
                    hiddenColor1.BackColor = hiddenItemsDefaultColor;
                    hiddenColor2.BackColor = hiddenItemsDefaultColor;
                    hiddenColor3.BackColor = hiddenItemsDefaultColor;
                    hiddenColor4.BackColor = hiddenItemsDefaultColor;
                    questionMark1.BackColor = hiddenItemsDefaultColor;
                    questionMark2.BackColor = hiddenItemsDefaultColor;
                    questionMark3.BackColor = hiddenItemsDefaultColor;
                    questionMark4.BackColor = hiddenItemsDefaultColor;
                    questionMark1.Show();
                    questionMark2.Show();
                    questionMark3.Show();
                    questionMark4.Show();
                }

                color1.BackColor = GetColorFromColorItem(Game.CurrentGame.Guesses[0].Items[0]);
                color2.BackColor = GetColorFromColorItem(Game.CurrentGame.Guesses[0].Items[1]);
                color3.BackColor = GetColorFromColorItem(Game.CurrentGame.Guesses[0].Items[2]);
                color4.BackColor = GetColorFromColorItem(Game.CurrentGame.Guesses[0].Items[3]);
                color5.BackColor = GetColorFromColorItem(Game.CurrentGame.Guesses[1].Items[0]);
                color6.BackColor = GetColorFromColorItem(Game.CurrentGame.Guesses[1].Items[1]);
                color7.BackColor = GetColorFromColorItem(Game.CurrentGame.Guesses[1].Items[2]);
                color8.BackColor = GetColorFromColorItem(Game.CurrentGame.Guesses[1].Items[3]);
                color9.BackColor = GetColorFromColorItem(Game.CurrentGame.Guesses[2].Items[0]);
                color10.BackColor = GetColorFromColorItem(Game.CurrentGame.Guesses[2].Items[1]);
                color11.BackColor = GetColorFromColorItem(Game.CurrentGame.Guesses[2].Items[2]);
                color12.BackColor = GetColorFromColorItem(Game.CurrentGame.Guesses[2].Items[3]);
                color13.BackColor = GetColorFromColorItem(Game.CurrentGame.Guesses[3].Items[0]);
                color14.BackColor = GetColorFromColorItem(Game.CurrentGame.Guesses[3].Items[1]);
                color15.BackColor = GetColorFromColorItem(Game.CurrentGame.Guesses[3].Items[2]);
                color16.BackColor = GetColorFromColorItem(Game.CurrentGame.Guesses[3].Items[3]);
                color17.BackColor = GetColorFromColorItem(Game.CurrentGame.Guesses[4].Items[0]);
                color18.BackColor = GetColorFromColorItem(Game.CurrentGame.Guesses[4].Items[1]);
                color19.BackColor = GetColorFromColorItem(Game.CurrentGame.Guesses[4].Items[2]);
                color20.BackColor = GetColorFromColorItem(Game.CurrentGame.Guesses[4].Items[3]);
                color21.BackColor = GetColorFromColorItem(Game.CurrentGame.Guesses[5].Items[0]);
                color22.BackColor = GetColorFromColorItem(Game.CurrentGame.Guesses[5].Items[1]);
                color23.BackColor = GetColorFromColorItem(Game.CurrentGame.Guesses[5].Items[2]);
                color24.BackColor = GetColorFromColorItem(Game.CurrentGame.Guesses[5].Items[3]);
                color25.BackColor = GetColorFromColorItem(Game.CurrentGame.Guesses[6].Items[0]);
                color26.BackColor = GetColorFromColorItem(Game.CurrentGame.Guesses[6].Items[1]);
                color27.BackColor = GetColorFromColorItem(Game.CurrentGame.Guesses[6].Items[2]);
                color28.BackColor = GetColorFromColorItem(Game.CurrentGame.Guesses[6].Items[3]);
                color29.BackColor = GetColorFromColorItem(Game.CurrentGame.Guesses[7].Items[0]);
                color30.BackColor = GetColorFromColorItem(Game.CurrentGame.Guesses[7].Items[1]);
                color31.BackColor = GetColorFromColorItem(Game.CurrentGame.Guesses[7].Items[2]);
                color32.BackColor = GetColorFromColorItem(Game.CurrentGame.Guesses[7].Items[3]);
                color33.BackColor = GetColorFromColorItem(Game.CurrentGame.Guesses[8].Items[0]);
                color34.BackColor = GetColorFromColorItem(Game.CurrentGame.Guesses[8].Items[1]);
                color35.BackColor = GetColorFromColorItem(Game.CurrentGame.Guesses[8].Items[2]);
                color36.BackColor = GetColorFromColorItem(Game.CurrentGame.Guesses[8].Items[3]);
                color37.BackColor = GetColorFromColorItem(Game.CurrentGame.Guesses[9].Items[0]);
                color38.BackColor = GetColorFromColorItem(Game.CurrentGame.Guesses[9].Items[1]);
                color39.BackColor = GetColorFromColorItem(Game.CurrentGame.Guesses[9].Items[2]);
                color40.BackColor = GetColorFromColorItem(Game.CurrentGame.Guesses[9].Items[3]);

                if (GetStateFromColorItem(Game.CurrentGame.Guesses[0].Items[0])) xMark1.Hide(); else xMark1.Show();
                if (GetStateFromColorItem(Game.CurrentGame.Guesses[0].Items[1])) xMark2.Hide(); else xMark2.Show();
                if (GetStateFromColorItem(Game.CurrentGame.Guesses[0].Items[2])) xMark3.Hide(); else xMark3.Show();
                if (GetStateFromColorItem(Game.CurrentGame.Guesses[0].Items[3])) xMark4.Hide(); else xMark4.Show();
                if (GetStateFromColorItem(Game.CurrentGame.Guesses[1].Items[0])) xMark5.Hide(); else xMark5.Show();
                if (GetStateFromColorItem(Game.CurrentGame.Guesses[1].Items[1])) xMark6.Hide(); else xMark6.Show();
                if (GetStateFromColorItem(Game.CurrentGame.Guesses[1].Items[2])) xMark7.Hide(); else xMark7.Show();
                if (GetStateFromColorItem(Game.CurrentGame.Guesses[1].Items[3])) xMark8.Hide(); else xMark8.Show();
                if (GetStateFromColorItem(Game.CurrentGame.Guesses[2].Items[0])) xMark9.Hide(); else xMark9.Show();
                if (GetStateFromColorItem(Game.CurrentGame.Guesses[2].Items[1])) xMark10.Hide(); else xMark10.Show();
                if (GetStateFromColorItem(Game.CurrentGame.Guesses[2].Items[2])) xMark11.Hide(); else xMark11.Show();
                if (GetStateFromColorItem(Game.CurrentGame.Guesses[2].Items[3])) xMark12.Hide(); else xMark12.Show();
                if (GetStateFromColorItem(Game.CurrentGame.Guesses[3].Items[0])) xMark13.Hide(); else xMark13.Show();
                if (GetStateFromColorItem(Game.CurrentGame.Guesses[3].Items[1])) xMark14.Hide(); else xMark14.Show();
                if (GetStateFromColorItem(Game.CurrentGame.Guesses[3].Items[2])) xMark15.Hide(); else xMark15.Show();
                if (GetStateFromColorItem(Game.CurrentGame.Guesses[3].Items[3])) xMark16.Hide(); else xMark16.Show();
                if (GetStateFromColorItem(Game.CurrentGame.Guesses[4].Items[0])) xMark17.Hide(); else xMark17.Show();
                if (GetStateFromColorItem(Game.CurrentGame.Guesses[4].Items[1])) xMark18.Hide(); else xMark18.Show();
                if (GetStateFromColorItem(Game.CurrentGame.Guesses[4].Items[2])) xMark19.Hide(); else xMark19.Show();
                if (GetStateFromColorItem(Game.CurrentGame.Guesses[4].Items[3])) xMark20.Hide(); else xMark20.Show();
                if (GetStateFromColorItem(Game.CurrentGame.Guesses[5].Items[0])) xMark21.Hide(); else xMark21.Show();
                if (GetStateFromColorItem(Game.CurrentGame.Guesses[5].Items[1])) xMark22.Hide(); else xMark22.Show();
                if (GetStateFromColorItem(Game.CurrentGame.Guesses[5].Items[2])) xMark23.Hide(); else xMark23.Show();
                if (GetStateFromColorItem(Game.CurrentGame.Guesses[5].Items[3])) xMark24.Hide(); else xMark24.Show();
                if (GetStateFromColorItem(Game.CurrentGame.Guesses[6].Items[0])) xMark25.Hide(); else xMark25.Show();
                if (GetStateFromColorItem(Game.CurrentGame.Guesses[6].Items[1])) xMark26.Hide(); else xMark26.Show();
                if (GetStateFromColorItem(Game.CurrentGame.Guesses[6].Items[2])) xMark27.Hide(); else xMark27.Show();
                if (GetStateFromColorItem(Game.CurrentGame.Guesses[6].Items[3])) xMark28.Hide(); else xMark28.Show();
                if (GetStateFromColorItem(Game.CurrentGame.Guesses[7].Items[0])) xMark29.Hide(); else xMark29.Show();
                if (GetStateFromColorItem(Game.CurrentGame.Guesses[7].Items[1])) xMark30.Hide(); else xMark30.Show();
                if (GetStateFromColorItem(Game.CurrentGame.Guesses[7].Items[2])) xMark31.Hide(); else xMark31.Show();
                if (GetStateFromColorItem(Game.CurrentGame.Guesses[7].Items[3])) xMark32.Hide(); else xMark32.Show();
                if (GetStateFromColorItem(Game.CurrentGame.Guesses[8].Items[0])) xMark33.Hide(); else xMark33.Show();
                if (GetStateFromColorItem(Game.CurrentGame.Guesses[8].Items[1])) xMark34.Hide(); else xMark34.Show();
                if (GetStateFromColorItem(Game.CurrentGame.Guesses[8].Items[2])) xMark35.Hide(); else xMark35.Show();
                if (GetStateFromColorItem(Game.CurrentGame.Guesses[8].Items[3])) xMark36.Hide(); else xMark36.Show();
                if (GetStateFromColorItem(Game.CurrentGame.Guesses[9].Items[0])) xMark37.Hide(); else xMark37.Show();
                if (GetStateFromColorItem(Game.CurrentGame.Guesses[9].Items[1])) xMark38.Hide(); else xMark38.Show();
                if (GetStateFromColorItem(Game.CurrentGame.Guesses[9].Items[2])) xMark39.Hide(); else xMark39.Show();
                if (GetStateFromColorItem(Game.CurrentGame.Guesses[9].Items[3])) xMark40.Hide(); else xMark40.Show();

                Color feedbackPanelColor = feedbackPanelDefaultColor;
                feedbackPanel1.BackColor = feedbackPanelColor;
                feedbackPanel2.BackColor = feedbackPanelColor;
                feedbackPanel3.BackColor = feedbackPanelColor;
                feedbackPanel4.BackColor = feedbackPanelColor;
                feedbackPanel5.BackColor = feedbackPanelColor;
                feedbackPanel6.BackColor = feedbackPanelColor;
                feedbackPanel7.BackColor = feedbackPanelColor;
                feedbackPanel8.BackColor = feedbackPanelColor;
                feedbackPanel9.BackColor = feedbackPanelColor;
                feedbackPanel10.BackColor = feedbackPanelColor;


                feedback1.BackColor = GetFeedbackColor(Game.CurrentGame.Guesses[0].Feedbacks[0]);
                feedback2.BackColor = GetFeedbackColor(Game.CurrentGame.Guesses[0].Feedbacks[1]);
                feedback3.BackColor = GetFeedbackColor(Game.CurrentGame.Guesses[0].Feedbacks[2]);
                feedback4.BackColor = GetFeedbackColor(Game.CurrentGame.Guesses[0].Feedbacks[3]);
                feedback5.BackColor = GetFeedbackColor(Game.CurrentGame.Guesses[1].Feedbacks[0]);
                feedback6.BackColor = GetFeedbackColor(Game.CurrentGame.Guesses[1].Feedbacks[1]);
                feedback7.BackColor = GetFeedbackColor(Game.CurrentGame.Guesses[1].Feedbacks[2]);
                feedback8.BackColor = GetFeedbackColor(Game.CurrentGame.Guesses[1].Feedbacks[3]);
                feedback9.BackColor = GetFeedbackColor(Game.CurrentGame.Guesses[2].Feedbacks[0]);
                feedback10.BackColor = GetFeedbackColor(Game.CurrentGame.Guesses[2].Feedbacks[1]);
                feedback11.BackColor = GetFeedbackColor(Game.CurrentGame.Guesses[2].Feedbacks[2]);
                feedback12.BackColor = GetFeedbackColor(Game.CurrentGame.Guesses[2].Feedbacks[3]);
                feedback13.BackColor = GetFeedbackColor(Game.CurrentGame.Guesses[3].Feedbacks[0]);
                feedback14.BackColor = GetFeedbackColor(Game.CurrentGame.Guesses[3].Feedbacks[1]);
                feedback15.BackColor = GetFeedbackColor(Game.CurrentGame.Guesses[3].Feedbacks[2]);
                feedback16.BackColor = GetFeedbackColor(Game.CurrentGame.Guesses[3].Feedbacks[3]);
                feedback17.BackColor = GetFeedbackColor(Game.CurrentGame.Guesses[4].Feedbacks[0]);
                feedback18.BackColor = GetFeedbackColor(Game.CurrentGame.Guesses[4].Feedbacks[1]);
                feedback19.BackColor = GetFeedbackColor(Game.CurrentGame.Guesses[4].Feedbacks[2]);
                feedback20.BackColor = GetFeedbackColor(Game.CurrentGame.Guesses[4].Feedbacks[3]);
                feedback21.BackColor = GetFeedbackColor(Game.CurrentGame.Guesses[5].Feedbacks[0]);
                feedback22.BackColor = GetFeedbackColor(Game.CurrentGame.Guesses[5].Feedbacks[1]);
                feedback23.BackColor = GetFeedbackColor(Game.CurrentGame.Guesses[5].Feedbacks[2]);
                feedback24.BackColor = GetFeedbackColor(Game.CurrentGame.Guesses[5].Feedbacks[3]);
                feedback25.BackColor = GetFeedbackColor(Game.CurrentGame.Guesses[6].Feedbacks[0]);
                feedback26.BackColor = GetFeedbackColor(Game.CurrentGame.Guesses[6].Feedbacks[1]);
                feedback27.BackColor = GetFeedbackColor(Game.CurrentGame.Guesses[6].Feedbacks[2]);
                feedback28.BackColor = GetFeedbackColor(Game.CurrentGame.Guesses[6].Feedbacks[3]);
                feedback29.BackColor = GetFeedbackColor(Game.CurrentGame.Guesses[7].Feedbacks[0]);
                feedback30.BackColor = GetFeedbackColor(Game.CurrentGame.Guesses[7].Feedbacks[1]);
                feedback31.BackColor = GetFeedbackColor(Game.CurrentGame.Guesses[7].Feedbacks[2]);
                feedback32.BackColor = GetFeedbackColor(Game.CurrentGame.Guesses[7].Feedbacks[3]);
                feedback33.BackColor = GetFeedbackColor(Game.CurrentGame.Guesses[8].Feedbacks[0]);
                feedback34.BackColor = GetFeedbackColor(Game.CurrentGame.Guesses[8].Feedbacks[1]);
                feedback35.BackColor = GetFeedbackColor(Game.CurrentGame.Guesses[8].Feedbacks[2]);
                feedback36.BackColor = GetFeedbackColor(Game.CurrentGame.Guesses[8].Feedbacks[3]);
                feedback37.BackColor = GetFeedbackColor(Game.CurrentGame.Guesses[9].Feedbacks[0]);
                feedback38.BackColor = GetFeedbackColor(Game.CurrentGame.Guesses[9].Feedbacks[1]);
                feedback39.BackColor = GetFeedbackColor(Game.CurrentGame.Guesses[9].Feedbacks[2]);
                feedback40.BackColor = GetFeedbackColor(Game.CurrentGame.Guesses[9].Feedbacks[3]);
            }
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            Game.NewGame();
            this.RefreshForm();
        }
        private void color_Click(object sender, EventArgs e)
        {
            bool success = false;
            if (Game.ReadyToPlay())
            {
                if (sender == this.red_btn || sender == this.redToolStripMenuItem)
                {
                    //RED BUTTON
                    success = Game.CurrentGame.NextGuessIs(Color.Red);
                }
                else if (sender == this.green_btn || sender == this.greenToolStripMenuItem)
                {
                    //GREEN BUTTON
                    success = Game.CurrentGame.NextGuessIs(Color.Green);
                }
                else if (sender == this.blue_btn || sender == this.blueToolStripMenuItem)
                {
                    //BLUE BUTTON
                    success = Game.CurrentGame.NextGuessIs(Color.Blue);
                }
                else if (sender == this.yellow_btn || sender == this.yellowToolStripMenuItem)
                {
                    //YELLOW BUTTON
                    success = Game.CurrentGame.NextGuessIs(Color.Yellow);
                }
                else if (sender == this.orange_btn || sender == this.orangeToolStripMenuItem)
                {
                    //ORANGE BUTTON
                    success = Game.CurrentGame.NextGuessIs(Color.Orange);
                }
                else if (sender == this.pink_btn || sender == this.pinkToolStripMenuItem)
                {
                    //PINK BUTTON
                    success = Game.CurrentGame.NextGuessIs(Color.Pink);
                }
                else { }
            }

            if (!success)
            {
                if (Game.ReadyToPlay())
                {
                    MessageBox.Show("No more! Click next!");
                }
                
            }
            this.RefreshForm();
        }
        private void next_Click(object sender, EventArgs e)
        {
            if (Game.ReadyToPlay())
            {
                switch (Game.CurrentGame.NextRound())
                {
                    case GameState.None:
                        MessageBox.Show("Pick color!");
                        this.RefreshForm();
                        break;
                    case GameState.NextRound:
                        this.RefreshForm();
                        break;
                    case GameState.Winner:
                        this.RefreshForm();
                        Game.GameOver();
                        MessageBox.Show("You win!");
                        break;
                    case GameState.GameOver:
                        this.RefreshForm();
                        Game.GameOver();
                        MessageBox.Show("You lose!");
                        break;
                }
            }
            
        }
        private void back_Click(object sender, EventArgs e)
        {
            if (Game.ReadyToPlay())
            {
                bool a = Game.CurrentGame.Guesses[Game.CurrentGame.Round].RemoveLastGuess();


            }
            this.RefreshForm();
        }
        private void wiki_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Mastermind_(board_game)");
        }
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void forTestersShowColors_Click(object sender, EventArgs e)
        {
            if (Game.ReadyToPlay())
            {
                Game.CurrentGame.ShowHiddenColors();
                this.RefreshForm();
            }
        }
        private void forTestersHideColors_Click(object sender, EventArgs e)
        {
            if (Game.ReadyToPlay())
            {
                Game.CurrentGame.HideHiddenColors();
                this.RefreshForm();
            }
        }

        static private Color GetColorFromColorItem(ColorItem colorItem)
        {
            switch (colorItem.State)
            {
                case ItemState.None:
                    return itemDefaultColor;
                case ItemState.Color:
                    return colorItem.Color;
                default:
                    return Color.Transparent;
            }
        }
        static private bool GetStateFromColorItem(ColorItem colorItem)
        {
            switch (colorItem.State)
            {
                case ItemState.None:
                    return false;
                case ItemState.Color:
                    return true;
                case ItemState.WaitToGuess:
                    return false;
                default:
                    return false;
            }
        }
        static private Color GetFeedbackColor(FeedbackState fbs)
        {
            switch (fbs)
            {
                case FeedbackState.None:
                    return feedbackItemDefaultColor;
                case FeedbackState.IncludedNotRightPlace:
                    return feedbackIncludedNotRightPlaceColor;
                case FeedbackState.IncludedRightPlace:
                    return feedbackIncludedRightPlaceColor;
                default:
                    return Color.Transparent;
            }
        }
    }
}
