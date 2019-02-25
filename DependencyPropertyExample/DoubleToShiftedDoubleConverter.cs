using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Data;

namespace DependencyPropertyExample
{
    class DoubleToShiftedDoubleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double originalValue = (double)value >= -0.1d ? (double)value / 100d : 0;
            if ((double)value>=1)
            {
                originalValue = ((double)value / 100d)-1;
            }
            switch ((ColorShifts)parameter)
            {
                case ColorShifts.Red:
                    return -0.01 + originalValue;
                case ColorShifts.Orange:
                    return 0.15 + originalValue;
                case ColorShifts.Yellow:
                    return 0.3 + originalValue;
                case ColorShifts.LightGreen:
                    return 0.45 + originalValue;
                case ColorShifts.LightBlue:
                    return 0.6+ originalValue;
                case ColorShifts.Blue:
                    return 0.75 + originalValue;
                case ColorShifts.Violet:
                    return 0.9 + originalValue;
                case ColorShifts.Red0:
                    return 1.1+ originalValue;
                case ColorShifts.Orange0:
                    return 1.15 + originalValue;
                case ColorShifts.Yellow0:
                    return 1.3 + originalValue;
                case ColorShifts.LightGreen0:
                    return 1.45 + originalValue;
                case ColorShifts.LightBlue0:
                    return 1.6 + originalValue;
                case ColorShifts.Blue0:
                    return 1.75 + originalValue;
                case ColorShifts.Violet0:
                    return 1.9 + originalValue;
                default:
                    return 0;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
