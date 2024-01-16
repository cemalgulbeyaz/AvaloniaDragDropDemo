using Avalonia.Controls;
using AvaloniaDragDropDemo.ViewModels;

namespace AvaloniaDragDropDemo.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
        DataContext ??= new MainViewModel(this);
        if (DataContext is MainViewModel model)
            model.MainView = this;
    }
}
