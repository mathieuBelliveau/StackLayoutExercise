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
            up.CheckedChanged += (s, e) => CalculateTip();
            down.CheckedChanged += (s, e) => CalculateTip();
            input.TextChanged += (s, e) => CalculateTip();

            fif.Clicked += (s, e) => { slide.Value = 15; };
            twen.Clicked += (s, e) => { slide.Value = 20; };

            slide.ValueChanged += (s, e) =>
            {
                double pct = Math.Round(e.NewValue);
                percent.Text = pct + "%";
                CalculateTip();
            };
        }


        //round up for positive, round down for negative
        private void CalculateTip()
        {
            bool upCheck = up.IsChecked;
            bool downCheck = down.IsChecked;
            double pct = Math.Round(slide.Value);
            double tipp;
            double totall;
            double bill;
            if (Double.TryParse(input.Text, out bill) && bill > 0)
            {
                tipp = Math.Round(bill * (pct/100),2);
                totall = bill + tipp;

                if (upCheck && !downCheck)
                {
                    totall = Math.Ceiling(totall);

                }

                else if (!upCheck && downCheck)
                {
                    totall = Math.Floor(totall);
                }

                tip.Text = tipp.ToString("C");
                total.Text = totall.ToString("C");
            }
        }
    }
}
