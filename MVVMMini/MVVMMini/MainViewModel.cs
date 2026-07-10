using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MVVMMini
{
  public class MainViewModel : INotifyPropertyChanged
  {
    private int number1;

    public int Number1
    {
      get { return number1; }
      set
      {
        if(number1 == value) return;

        number1 = value;
        OnPropertyChanged();
      }
    }

    private int number2;

    public int Number2
    {
      get { return number2; }
      set
      {
        number2 = value;
        OnPropertyChanged();
      }
    }

    private int result;


    public int Result
    {
      get { return result; }
      set
      {
        result = value;
        OnPropertyChanged();
      }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public ActionCommand PlusCommand { get; set; }
    public ActionCommand MinusCommand { get; set; }

    public MainViewModel()
    {
      PlusCommand = new ActionCommand(Plus);
      MinusCommand = new ActionCommand(Minus);
    }

    private void Plus()
    {
      // here the model would be called to do the calculation, but for this example we will just do it here
      Result = Number1 + Number2;
      PlusCommand.IsEnabled = false;
    }

    private void Minus()
    {
      Result = Number1 - Number2;
      PlusCommand.IsEnabled = true;
    }


  }
}
