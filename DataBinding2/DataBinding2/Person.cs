namespace DataBinding2
{
  public class Person
  {
    public string? Name { get; set; }
    public string? Address { get; set; }

    public int Age { get; set; }

  }

  public class Company
  {
    public string? Name { get; set; } = "Hinz & Kunz";
    public List<Person> Employees { get; set; } = [
      new Person(){Name="Donald Duck", Address="Ducksburg", Age=30},
      new Person(){Name="Tick Duck", Address="Berlin", Age=15},
      new Person(){Name="Mike Smith", Address="Hamburg", Age=70},
      new Person(){Name="Sarah Muller", Address="Cologne", Age=48}

      ];
  }
}
