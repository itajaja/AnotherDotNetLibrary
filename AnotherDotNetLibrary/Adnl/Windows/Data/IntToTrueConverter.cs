using System;
using System.Globalization;
using System.Windows.Data;

namespace Adnl.Windows.Data
{
    /// <summary>
    /// Provides binding conversion From an int to a bool.
    /// </summary>
    public class IntToTrueConverter : IValueConverter
    {
        #region IValueConverter Members

        /// <summary>
        ///     returns true if the (int)value equals the (int)parameter
        /// </summary>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var val = (int)value;
            int par;
            bool parseResult = int.TryParse(parameter.ToString(), out par);
            return (parseResult && val == par);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}