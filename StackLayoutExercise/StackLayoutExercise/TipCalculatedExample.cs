using System;
using System.Collections.Generic;
using System.Text;

namespace StackLayoutExercise
{
    class TipCalculatedExample
    {
        public TipCalculatedExample()
        {
            var something = new MainPage();

            something.TipCalculated += (s, e) => { int x = 1 + 1; };
        }
    }
}
