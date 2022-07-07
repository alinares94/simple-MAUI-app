using Counter.Services;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Counter.ViewModels;

public class MainViewModel : INotifyPropertyChanged
{
    public MainViewModel(IDeviceOrientationService deviceOrientationService)
    {
        CreateCommands();
        Orientation = deviceOrientationService.GetOrientation().ToString();
    }

    private int _counter;
    private string _orientation;

    public string Orientation
    {
        get => _orientation;
        set { _orientation = value; OnPropertyChanged(); }
    }
    public int Counter
    {
        get => _counter;
        set { _counter = value; OnPropertyChanged(); }
    }

    public ICommand ButtonClickCommand { get; set; }

    private void CreateCommands()
    {
        ButtonClickCommand = new Command(ButtonClick);
    }

    private void ButtonClick(object obj)
    {
        Counter++;
    }


    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}