using System.Configuration;
using System.Data;
using System.Globalization;
using System.Windows;
using System.Windows.Markup;

namespace DataBinding1
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {
    static App()
    {
      FrameworkElement.LanguageProperty.OverrideMetadata(
        typeof(FrameworkElement),
        new FrameworkPropertyMetadata(
          XmlLanguage.GetLanguage(
            CultureInfo.CurrentCulture.Name)
          )
        );

    }
  }

}
