using System;
using System.Globalization;
using System.Windows.Data;

namespace Adnl.Windows.Data
{
    /// <summary>
    /// Provides binding conversion to an equality check for two objects.
    /// </summary>
    public class EqualsToTrueConverter : IValueConverter
    {
        #region IValueConverter Members

        /// <summary>
        /// Returns true if value.Equals(parameter) is true
        /// </summary>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                return value.Equals(parameter);
            }
            //if the value is null, check if the parameter is null as well, in this case return true
            return parameter == null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new InvalidOperationException();
        }

        #endregion
    }
}