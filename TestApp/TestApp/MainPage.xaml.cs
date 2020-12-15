using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestApp
{
    public partial class MainPage : ContentPage
    {

        public int lifeTotal = 40;
        public int storm = 0;
        public int colourless = 0;
        public int blue = 0;
        public int red = 0;
        public int black = 0;
        public int green = 0;
        public int white = 0;

        //private string lifeTotal;
        //private string myStringProperty;
        //private string myStringProperty;
        //private string myStringProperty;
        //private string myStringProperty;
        //private string myStringProperty;
        //private string myStringProperty;



        private string privatelifeTotal;
        private string StormLabel;
        private string ColourlessLabel;
        private string RedLabel;
        private string BlueLabel;
        private string BlackLabel;
        private string GreenLabel;
        private string WhiteLabel;


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

        }

        void Button_Life_Add(object sender, System.EventArgs e)
        {
            lifeTotal++;
            LifeTotal = lifeTotal.ToString();
        }

        void Button_Life_Remove(object sender, System.EventArgs e)
        {
            lifeTotal--;
            LifeTotal = lifeTotal.ToString();
        }


        void Button_Storm_Add(object sender, System.EventArgs e)
        {
            storm++;
            stormLabel = storm.ToString();
        }

        void Button_Storm_Remove(object sender, System.EventArgs e)
        {
            storm--;
            stormLabel = storm.ToString();
        }


        void Button_colourless_Add(object sender, System.EventArgs e)
        {
            colourless++;
            colourlessLabel = colourless.ToString();
        }

        void Button_colourless_Remove(object sender, System.EventArgs e)
        {
            colourless--;
            colourlessLabel = colourless.ToString();
        }


        void Button_Blue_Add(object sender, System.EventArgs e)
        {
            blue++;
            blueLabel = blue.ToString();
        }

        void Button_Blue_Remove(object sender, System.EventArgs e)
        {
            blue--;
            blueLabel = blue.ToString();
        }


        void Button_Red_Add(object sender, System.EventArgs e)
        {
            red++;
            redLabel = red.ToString();
        }

        void Button_Red_Remove(object sender, System.EventArgs e)
        {
            red--;
            redLabel = red.ToString();
        }


        void Button_Black_Add(object sender, System.EventArgs e)
        {
            black++;
            blackLabel = black.ToString();
        }

        void Button_Black_Remove(object sender, System.EventArgs e)
        {
            black--;
            blackLabel = black.ToString();
        }

        void Button_Green_Add(object sender, System.EventArgs e)
        {
            green++;
            greenLabel = green.ToString();
        }

        void Button_Green_Remove(object sender, System.EventArgs e)
        {
            green--;
            greenLabel = green.ToString();
        }

        void Button_White_Add(object sender, System.EventArgs e)
        {
            white++;
            whiteLabel = white.ToString();
        }

        void Button_White_Remove(object sender, System.EventArgs e)
        {
            white--;
            whiteLabel = white.ToString();
        }

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
