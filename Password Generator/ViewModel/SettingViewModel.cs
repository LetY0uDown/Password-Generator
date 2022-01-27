namespace Password_Generator.ViewModel;

using Password_Generator.Core;
using Password_Generator.Model;

public class SettingViewModel : ObservableObject
{
    public string BigChars
    {
        get => CharsData.BigChars;
        set
        {
            CharsData.BigChars = value;
            OnPropertyChanged();
        }
    }
    public string SmallChars
    {
        get => CharsData.SmallChars;
        set
        {
            CharsData.SmallChars = value;
            OnPropertyChanged();
        }
    }
    public string Symbols
    {
        get => CharsData.Symbols;
        set
        {
            CharsData.Symbols = value;
            OnPropertyChanged();
        }
    }
    public string Numbers
    {
        get => CharsData.Numbers;
        set
        {
            CharsData.Numbers = value;
            OnPropertyChanged();
        }
    }
    public string TargetWord
    {
        get => CharsData.TargetWord;
        set
        {
            CharsData.TargetWord = value;
            OnPropertyChanged();
        }
    }
}