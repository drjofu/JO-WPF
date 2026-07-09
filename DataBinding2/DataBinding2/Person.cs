using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DataBinding2
{
  public class Person : INotifyPropertyChanged
  {
    private int age;

    public string? Name { get; set; }
    public string? Address { get; set; }

    public int Age
    {
      get => age;
      set
      {
        if(age == value)
        {
          return;
        }

        age = value;
        OnPropertyChanged();
        OnPropertyChanged(nameof(IsExperienced)); 

        //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Age)));
      }
    }

    public bool IsExperienced => Age >= 45;
    protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    public event PropertyChangedEventHandler? PropertyChanged;
  }

  public class Company
  {
    public string? Name { get; set; } = "Hinz & Kunz";
    public ObservableCollection<Person> Employees { get; set; } = [
      new Person(){Name="Donald Duck", Address="Ducksburg", Age=30},
      new Person(){Name="Tick Duck", Address="Berlin", Age=15},
      new Person(){Name="Mike Smith", Address="Hamburg", Age=70},
      new Person(){Name="Sarah Muller", Address="Cologne", Age=48}

      ];
  }
}
