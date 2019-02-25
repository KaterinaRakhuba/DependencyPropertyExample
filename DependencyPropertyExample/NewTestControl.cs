using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace DependencyPropertyExample
{
    class NewTestControl:FrameworkElement
    {
        public static DependencyProperty testDataProperty;
        
        static NewTestControl()
        {
            testDataProperty = DependencyProperty.Register("testData", typeof(double), typeof(NewTestControl));
        }

        public double testData
        {
            get
            {
                //return ((double)GetValue(testDataProperty) / 100d);
                return (double)GetValue(testDataProperty);
            }
            set
            {
                SetValue(testDataProperty, value);
            }
        }
    }
}
