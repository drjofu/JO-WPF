using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Traffic
{
  /// <summary>
  /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
  ///
  /// Step 1a) Using this custom control in a XAML file that exists in the current project.
  /// Add this XmlNamespace attribute to the root element of the markup file where it is 
  /// to be used:
  ///
  ///     xmlns:MyNamespace="clr-namespace:Traffic"
  ///
  ///
  /// Step 1b) Using this custom control in a XAML file that exists in a different project.
  /// Add this XmlNamespace attribute to the root element of the markup file where it is 
  /// to be used:
  ///
  ///     xmlns:MyNamespace="clr-namespace:Traffic;assembly=Traffic"
  ///
  /// You will also need to add a project reference from the project where the XAML file lives
  /// to this project and Rebuild to avoid compilation errors:
  ///
  ///     Right click on the target project in the Solution Explorer and
  ///     "Add Reference"->"Projects"->[Select this project]
  ///
  ///
  /// Step 2)
  /// Go ahead and use your control in the XAML file.
  ///
  ///     <MyNamespace:CustomControl1/>
  ///
  /// </summary>
  public class TrafficLight : Control
  {
    private Shape? lightRed;
    private Shape? lightGreen;

    static TrafficLight()
    {
      DefaultStyleKeyProperty.OverrideMetadata(typeof(TrafficLight), new FrameworkPropertyMetadata(typeof(TrafficLight)));
    }

    //propdp
    //(propa)
    public bool IsGreen
    {
      get { return (bool)GetValue(IsGreenProperty); }
      set { SetValue(IsGreenProperty, value); }
    }

    // Using a DependencyProperty as the backing store for IsGreen.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty IsGreenProperty =
        DependencyProperty.Register(nameof(IsGreen), typeof(bool), typeof(TrafficLight), new FrameworkPropertyMetadata(false, IsGreenChanged));

    private static void IsGreenChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
      var trafficLight = d as TrafficLight;
      trafficLight!.Switch();
    }

    private void Switch()
    {
      if (lightGreen is null)
      {
        return;
      }

      if (IsGreen)
      {
        lightGreen!.Opacity = 1;
        lightRed!.Opacity = 0.2;
      }
      else
      {
        lightRed!.Opacity = 1;
        lightGreen!.Opacity = 0.2;
      }
    }

    public override void OnApplyTemplate()
    {
      base.OnApplyTemplate();
      lightRed = GetTemplateChild("PART_RedLight") as Shape;
      lightGreen = GetTemplateChild("PART_GreenLight") as Shape;

      Switch();
    }
  }
}