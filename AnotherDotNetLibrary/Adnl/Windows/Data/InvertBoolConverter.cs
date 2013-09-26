using System;
using System.Globalization;
using System.Windows.Data;

namespace Adnl.Windows.Data
{
    /// <summary>
    ///     returns !(value)
    /// </summary>
    public class InvertBoolConverter : IValueConverter
    {
        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !(bool)value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !(bool)value;
        }

        #endregion
    }
}