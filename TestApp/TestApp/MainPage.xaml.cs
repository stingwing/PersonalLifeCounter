using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Diagnostics;

namespace TestApp
{
    public partial class MainPage : ContentPage
    {

        public enum Level
        {
            LifeAdd,
            LifeRemove,
            StormAdd,
            StormRemove,
            RedAdd,
            RedRemove,
            BlueAdd,
            BlueRemove,
            GreenAdd,
            GreenRemove,
            ColourlessAdd,
            ColourlessRemove,
            BlackAdd,
            BlackRemove,
            WhiteAdd,
            WhiteRemove,
            CommanderLeftAdd,
            CommanderLeftRemove,
            CommanderCenterAdd,
            CommanderCenterRemove,
            CommanderRightAdd,
            CommanderRightRemove
        }

        public int lifeTotal = 40;
        public int storm = 0;
        public int colourless = 0;
        public int blue = 0;
        public int red = 0;
        public int black = 0;
        public int green = 0;
        public int white = 0;

        public int commanderLeft = 0;
        public int commanderRight = 0;
        public int commanderCenter = 0;

        Stopwatch stopwatch = new Stopwatch();
        bool pressAndHold = false;


        private string privatelifeTotal;
        private string StormLabel;
        private string ColourlessLabel;
        private string RedLabel;
        private string BlueLabel;
        private string BlackLabel;
        private string GreenLabel;
        private string WhiteLabel;


        private string CommanderLeftLabel;
        private string CommanderRightLabel;
        private string CommanderCenterLabel;

        public string LifeTotal
        {
            get { return privatelifeTotal; }
            set
            {
                privatelifeTotal = value;
                OnPropertyChanged(nameof(LifeTotal)); // Notify that there was a change on this property
            }
        }
        public string stormLabel
        {
            get { return StormLabel; }
            set
            {
                StormLabel = value;
                OnPropertyChanged(nameof(stormLabel)); // Notify that there was a change on this property
            }
        }

        public string colourlessLabel
        {
            get { return ColourlessLabel; }
            set
            {
                ColourlessLabel = value;
                OnPropertyChanged(nameof(colourlessLabel)); // Notify that there was a change on this property
            }
        }

        public string redLabel
        {
            get { return RedLabel; }
            set
            {
                RedLabel = value;
                OnPropertyChanged(nameof(redLabel)); // Notify that there was a change on this property
            }
        }

        public string blueLabel
        {
            get { return BlueLabel; }
            set
            {
                BlueLabel = value;
                OnPropertyChanged(nameof(blueLabel)); // Notify that there was a change on this property
            }
        }

        public string blackLabel
        {
            get { return BlackLabel; }
            set
            {
                BlackLabel = value;
                OnPropertyChanged(nameof(blackLabel)); // Notify that there was a change on this property
            }
        }

        public string greenLabel
        {
            get { return GreenLabel; }
            set
            {
                GreenLabel = value;
                OnPropertyChanged(nameof(greenLabel)); // Notify that there was a change on this property
            }
        }

        public string whiteLabel
        {
            get { return WhiteLabel; }
            set
            {
                WhiteLabel = value;
                OnPropertyChanged(nameof(whiteLabel)); // Notify that there was a change on this property
            }
        }

        public string commanderLeftLabel
        {
            get { return CommanderLeftLabel; }
            set
            {
                CommanderLeftLabel = value;
                OnPropertyChanged(nameof(commanderLeftLabel)); // Notify that there was a change on this property
            }
        }
        public string commanderRightLabel
        {
            get { return CommanderRightLabel; }
            set
            {
                CommanderRightLabel = value;
                OnPropertyChanged(nameof(commanderRightLabel)); // Notify that there was a change on this property
            }
        }
        public string commanderCenterLabel
        {
            get { return CommanderCenterLabel; }
            set
            {
                CommanderCenterLabel = value;
                OnPropertyChanged(nameof(commanderCenterLabel)); // Notify that there was a change on this property
            }
        }






        public MainPage()
        {
            InitializeComponent();

            BindingContext = this;

            LifeTotal = lifeTotal.ToString(); // It will be shown at your label
            stormLabel = storm.ToString();
            colourlessLabel = colourless.ToString();
            blueLabel = blue.ToString();
            redLabel = red.ToString();
            blackLabel = black.ToString();
            greenLabel = green.ToString();
            whiteLabel = white.ToString();

            commanderLeftLabel = green.ToString();
            commanderRightLabel = black.ToString();
            commanderCenterLabel = white.ToString();

        }

        //void OnButtonPressed(object sender, EventArgs args)
        //{
        //    stopwatch.Start();
        //    pressAndHold = true;

        //    if (stopwatch.ElapsedMilliseconds > 1000)
        //    {
        //        ModifyLife(Level.LifeAdd);
        //    }
        //}
        //void OnButtonReleased(object sender, EventArgs args)
        //{
        //    pressAndHold = false;
        //    stopwatch.Stop();
        //}

        void Button_Life_Add(object sender, System.EventArgs e)
        {
            ModifyLife(Level.LifeAdd);
        }

        void Button_Life_Remove(object sender, System.EventArgs e)
        {
            ModifyLife(Level.LifeRemove);
        }

        public void ModifyLife(Level level)
        {
            if (level == Level.LifeAdd)
            {
                lifeTotal++;
                LifeTotal = lifeTotal.ToString();
            }
            if (level == Level.LifeRemove)
            {
                lifeTotal--;
                LifeTotal = lifeTotal.ToString();
            }
        }


        public void ModifyMiscellaneous(Level level)
        {
            switch (level)
            {
                case Level.StormAdd:
                    storm++;
                    stormLabel = storm.ToString();
                    break;
                case Level.StormRemove:
                    if (storm > 0)
                        storm--;
                    stormLabel = storm.ToString();
                    break;
            }
        }

        void Button_Storm_Add(object sender, System.EventArgs e)
        {
            ModifyMiscellaneous(Level.StormAdd);
        }

        void Button_Storm_Remove(object sender, System.EventArgs e)
        {
            ModifyMiscellaneous(Level.StormRemove);
        }

        //Mana Buttons 

        public void ModifyMana(Level level)
        {
            switch (level)
            {
                case Level.ColourlessAdd:
                    colourless++;
                    colourlessLabel = colourless.ToString();
                    break;

                case Level.ColourlessRemove:
                    if (colourless > 0)
                        colourless--;
                    colourlessLabel = colourless.ToString();
                    break;

                case Level.BlueAdd:
                    blue++;
                    blueLabel = blue.ToString();
                    break;

                case Level.BlueRemove:
                    if (blue > 0)
                        blue--;
                    blueLabel = (blue).ToString();
                    break;

                case Level.RedAdd:
                    red++;
                    redLabel = red.ToString();
                    break;

                case Level.RedRemove:
                    if (red > 0)
                        red--;
                    redLabel = red.ToString();
                    break;

                case Level.GreenAdd:
                    green++;
                    greenLabel = green.ToString();
                    break;

                case Level.GreenRemove:
                    if (green > 0)
                        green--;
                    greenLabel = green.ToString();
                    break;

                case Level.BlackAdd:
                    black++;
                    blackLabel = black.ToString();
                    break;

                case Level.BlackRemove:
                    if (black > 0)
                        black--;
                    blackLabel = black.ToString();
                    break;

                case Level.WhiteAdd:
                    white++;
                    whiteLabel = white.ToString();
                    break;

                case Level.WhiteRemove:

                    if (white > 0)
                        white--;
                    whiteLabel = white.ToString();
                    break;
            }
        }

        void Button_colourless_Add(object sender, System.EventArgs e)
        {
            ModifyMana(Level.ColourlessAdd);
        }

        void Button_colourless_Remove(object sender, System.EventArgs e)
        {
            ModifyMana(Level.ColourlessRemove);
        }

        void Button_Blue_Add(object sender, System.EventArgs e)
        {
            ModifyMana(Level.BlueAdd);
        }

        void Button_Blue_Remove(object sender, System.EventArgs e)
        {
            ModifyMana(Level.BlueRemove);
        }

        void Button_Red_Add(object sender, System.EventArgs e)
        {
            ModifyMana(Level.RedAdd);
        }

        void Button_Red_Remove(object sender, System.EventArgs e)
        {
            ModifyMana(Level.RedRemove);
        }

        void Button_Black_Add(object sender, System.EventArgs e)
        {
            ModifyMana(Level.BlackAdd);
        }

        void Button_Black_Remove(object sender, System.EventArgs e)
        {
            ModifyMana(Level.BlackRemove);
        }

        void Button_Green_Add(object sender, System.EventArgs e)
        {
            ModifyMana(Level.GreenAdd);
        }

        void Button_Green_Remove(object sender, System.EventArgs e)
        {
            ModifyMana(Level.GreenRemove);
        }

        void Button_White_Add(object sender, System.EventArgs e)
        {
            ModifyMana(Level.WhiteAdd);
        }

        void Button_White_Remove(object sender, System.EventArgs e)
        {
            ModifyMana(Level.WhiteRemove);
        }


        public void ModifyCommander(Level level)
        {
            switch (level)
            {
                case Level.CommanderLeftAdd:
                    commanderLeft++;
                    commanderLeftLabel = commanderLeft.ToString();
                    ModifyLife(Level.LifeRemove);
                    break;
                case Level.CommanderLeftRemove:
                    if (commanderLeft > 0)
                    {
                        commanderLeft--;
                        commanderLeftLabel = commanderLeft.ToString();
                        ModifyLife(Level.LifeAdd);
                    }                   
                    break;

                case Level.CommanderCenterAdd:
                    commanderCenter++;
                    commanderCenterLabel = commanderCenter.ToString();
                    ModifyLife(Level.LifeRemove);
                    break;

                case Level.CommanderCenterRemove:
                    if (commanderCenter > 0)
                    {
                        commanderCenter--;
                        commanderCenterLabel = commanderCenter.ToString();
                        ModifyLife(Level.LifeAdd);
                    }
                    
                    break;

                case Level.CommanderRightAdd:
                    commanderRight++;
                    commanderRightLabel = commanderRight.ToString();
                    ModifyLife(Level.LifeRemove);
                    break;

                case Level.CommanderRightRemove:
                    if (commanderRight > 0)
                    {
                        commanderRight--;
                        commanderRightLabel = commanderRight.ToString();
                        ModifyLife(Level.LifeAdd);          
                    }
                    
                    break;
            }
        }

        //Commander buttons
        void Button_CommanderLeft_Add(object sender, System.EventArgs e)
        {
            ModifyCommander(Level.CommanderLeftAdd);
        }

        void Button_CommanderLeft_Remove(object sender, System.EventArgs e)
        {
            ModifyCommander(Level.CommanderLeftRemove);
        }

        void Button_CommanderCenter_Add(object sender, System.EventArgs e)
        {
            ModifyCommander(Level.CommanderCenterAdd);
        }

        void Button_CommanderCenter_Remove(object sender, System.EventArgs e)
        {
            ModifyCommander(Level.CommanderCenterRemove);
        }

        void Button_CommanderRight_Add(object sender, System.EventArgs e)
        {
            ModifyCommander(Level.CommanderRightAdd);
        }

        void Button_CommanderRight_Remove(object sender, System.EventArgs e)
        {
            ModifyCommander(Level.CommanderRightRemove);
        }


        // Reset Buttons
        void Button_ResetLife(object sender, System.EventArgs e)
        {
            lifeTotal = 40;
            LifeTotal = lifeTotal.ToString();
        }
        void Button_Reset_Counts(object sender, System.EventArgs e)
        {
            storm = 0;
            stormLabel = storm.ToString();
            colourless = 0;
            colourlessLabel = colourless.ToString();
            blue = 0;
            blueLabel = blue.ToString();
            red = 0;
            redLabel = red.ToString();
            black = 0;
            blackLabel = black.ToString();
            green = 0;
            greenLabel = green.ToString();
            white = 0;
            whiteLabel = white.ToString();
        }
    }
}
