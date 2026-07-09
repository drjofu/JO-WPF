using System.Windows.Data;

namespace DataBinding1
{
  public class MyFontSizeConverter : IValueConverter
  {
    public double Offset { get; set; } = 20;
    public double Factor { get; set; } = 2;

    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
      double fontSize = (double)value;
      return Offset + fontSize * Factor;
    }
    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }
}
