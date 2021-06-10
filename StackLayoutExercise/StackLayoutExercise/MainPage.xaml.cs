using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StackLayoutExercise
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        //-1,0,+1:round down, none, round up
        private void CalculateTip(int rounding)
        {
            if (rounding > 1 || rounding < -1)
                return;

            double t;
            if (Double.TryParse(input.Text, out t) && t > 0)
            {

            }
        }
    }
}
