using System;
using System.Globalization;
using System.Windows.Data;

namespace Adnl.Windows.Data
{
    /// <summary>
    /// Provides binding conversion from Date to its short time representation.
    /// </summary>
    public class DateToShortTimeStringConverter : IValueConverter
    {
        #region IValueConverter Members

        /// <summary>
        /// Returns ((DateTime)value).ToShortTimeString().
        /// </summary>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((DateTime)value).ToShortTimeString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new InvalidOperationException();
        }

        #endregion
    }
}