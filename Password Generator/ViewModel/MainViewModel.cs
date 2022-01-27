namespace Password_Generator.ViewModel;

using Password_Generator.Core;
using Password_Generator.Model;
using Password_Generator.View;
using System;
using System.Windows;

public class MainViewModel : ObservableObject
{
    public MainViewModel()
    {
        Random = new Random();

        MainView = new MainView();
        SettingsView = new SettingsView();

        CurrentView = MainView;

        ExitCommand = new RelayCommand(o => Application.Current.Shutdown());

        MinimizeCommand = new RelayCommand(o => Application.Current.MainWindow.WindowState = WindowState.Minimized);

        GenerateCommand = new RelayCommand(o =>
        {
            if (MainView.cboxNumbers.IsChecked == true)
                AllowedChars += CharsData.Numbers;
            if (MainView.cboxSymbols.IsChecked == true)
                AllowedChars += CharsData.Symbols;
            if (MainView.cboxBigChars.IsChecked == true)
                AllowedChars += CharsData.BigChars;
            if (MainView.cboxSmallChars.IsChecked == true)
                AllowedChars += CharsData.SmallChars;

            if (AllowedChars == null)
            {
                MainView.LabelPassword.Text = "null";
                return;
            }

            Attempts++;

            var lenght = MainView.PasswordLenght.Value;
            var charsCount = AllowedChars.Length;

            for (int i = 0; i < lenght; i++)
                Password += AllowedChars[Random.Next(0, charsCount)];

            if (Password == CharsData.TargetWord)
            {
                Matches++;

                MainView.labelMatches.Content = $"Attempts: {Attempts} | Matches: {Matches}";
            }

            MainView.labelMatches.Content = $"Attempts: {Attempts} | Matches: {Matches}";
            MainView.LabelPassword.Text = Password;

            AllowedChars = null;
            Password = null;
        });

        ChangeViewCommand = new RelayCommand(o =>
        {
            CurrentView = CurrentView == MainView ? SettingsView : MainView;
        });
    }
    private MainView MainView { get; set; }
    private SettingsView SettingsView { get; set; }

    private int Attempts { get; set; }
    private int Matches { get; set; }

    private Random Random { get; set; }

    private string AllowedChars { get; set; }
    private string Password { get; set; }

    public RelayCommand ExitCommand { get; set; }
    public RelayCommand MinimizeCommand { get; set; }

    public RelayCommand ChangeViewCommand { get; set; }

    public RelayCommand GenerateCommand { get; set; }

    private object _currentView;
    public object CurrentView
    {
        get => _currentView;
        set
        {
            _currentView = value;
            OnPropertyChanged();
        }
    }
}