namespace MVVMMini
{
  public class MainViewModel
  {
    private int number1;

    public int Number1
    {
      get { return number1; }
      set { number1 = value; }
    }

    private int number2;

    public int Number2
    {
      get { return number2; }
      set { number2 = value; }
    }

    private int result;

    public int Result
    {
      get { return result; }
      set { result = value; }
    }

    public ActionCommand PlusCommand { get; set; }
    public ActionCommand MinusCommand { get; set; }

  }
}
