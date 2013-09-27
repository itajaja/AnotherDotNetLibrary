using System;
using System.Globalization;
using System.Windows.Data;

namespace Adnl.Windows.Data
{
    /// <summary>
    /// Provides binding conversion from boolean to float and viceversa.
    /// </summary>
    public class BoolToFloatConverter : IValueConverter
    {
        #region IValueConverter Members

        /// <summary>
        /// Returns 1 if the value is true, otherwise the float specified by the parameter.
        /// </summary>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(bool)value)
            {
                return (float)parameter;
            }
            return (float)1;
        }

        /// <summary>
        /// Thi
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((float)value == 1) return true;
            return false;
        }

        #endregion
    }
}