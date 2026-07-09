using System.Globalization;
using System.Windows.Data;

namespace DataBinding1
{
  public class SmileyConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      double v = (double)value;
      if (v < 5)
      {
        return "😀";
      }
      else if (v < 8)
      {
        return "😐";
      }
      return "😢";
    }
    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }
}
