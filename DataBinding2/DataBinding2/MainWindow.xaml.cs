using System.Windows;

namespace DataBinding2
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
      this.DataContext=new Company();
    }

    private void GettingOlder(object sender, RoutedEventArgs e)
    {
      var people = ((Company)DataContext).Employees;
      foreach (var person in people)
      {
        person.Age++;
      }
    }
  }
}