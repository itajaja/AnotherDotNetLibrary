using System;
using System.Globalization;
using System.Windows.Data;

namespace Adnl.Windows.Data
{
    /// <summary>
    /// Provides binding conversion From an int to a bool.
    /// </summary>
    public class IntToFalseConverter : IValueConverter
    {
        #region IValueConverter Members

        /// <summary>
        ///     returns false if the (int)value equals the (int)parameter
        /// </summary>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var val = (int) value;
            int par = int.Parse(parameter.ToString());
            return val != par;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new InvalidOperationException();
        }

        #endregion
    }
}