﻿using System.Globalization;
using System;
using System.Windows.Data;

namespace SIMS_Booking.Utility
{
    internal class SuperOwnerColorConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
