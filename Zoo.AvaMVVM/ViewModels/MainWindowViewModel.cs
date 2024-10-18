namespace Zoo.AvaMVVM.ViewModels
{
  public partial class MainWindowViewModel : ViewModelBase
  {
#pragma warning disable CA1822 // Mark members as static
    private string _greeting =
        "Welcome to Avalonia!";
    public string Greeting { get => _greeting; set { _greeting = value; } }
#pragma warning restore CA1822 // Mark members as static

    public void ButtonAction()
    {
      Greeting = "Hallo";
    }
  }
}
