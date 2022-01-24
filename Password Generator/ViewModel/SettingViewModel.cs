namespace Password_Generator.ViewModel;

using Password_Generator.Model;

public class SettingViewModel
{
    public string BigChars
    {
        get => CharsData.BigChars;
        set => CharsData.BigChars = value;
    }
    public string SmallChars
    {
        get => CharsData.SmallChars;
        set => CharsData.SmallChars = value;
    }
    public string Symbols
    {
        get => CharsData.Symbols;
        set => CharsData.Symbols = value;
    }
    public string Numbers
    {
        get => CharsData.Numbers;
        set => CharsData.Numbers = value;
    }
}