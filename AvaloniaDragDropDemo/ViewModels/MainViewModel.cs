using Avalonia.Input;
using Avalonia.Xaml.Interactions.DragAndDrop;
using AvaloniaDragDropDemo.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.ComponentModel;

namespace AvaloniaDragDropDemo.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty] private MainView mainView;

    public MainViewModel()
    {

    }
    public MainViewModel(MainView mainView)
    {
        MainView = mainView;
    }
    
    public string Greeting => "Welcome to Avalonia!";



    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        base.OnPropertyChanged(e);

        if (e.PropertyName!.Equals(nameof(MainView)))
            AddEventHandlers();
    }

    private void AddEventHandlers()
    {
        MainView.gridDropZoneInput.AddHandler(DragDrop.DragEnterEvent, FileDropArea_DragEnterEvent);
        MainView.gridDropZoneInput.AddHandler(DragDrop.DropEvent, FileDropArea_DropEvent);
        MainView.gridDropZoneInput.AddHandler(DragDrop.DragOverEvent, FileDropArea_DragOverEvent);
        MainView.gridDropZoneInput.AddHandler(DragDrop.DragLeaveEvent, FileDropArea_DragLeaveEvent);
    }

    

    private void FileDropArea_DragEnterEvent(object? sender, DragEventArgs e)
    {

    
    }
    private void FileDropArea_DropEvent(object? sender, DragEventArgs e)
    {
        var files = e.Data.GetFiles();
    }
    private void FileDropArea_DragOverEvent(object? sender, DragEventArgs e)
    {

    }
    private void FileDropArea_DragLeaveEvent(object? sender, DragEventArgs e)
    {

    }
}



public class MyDropHandler : DropHandlerBase
{
    public override void Drop(object? sender, DragEventArgs e, object? sourceContext, object? targetContext)
    {
        base.Drop(sender, e, sourceContext, targetContext);

        var files = e.Data.GetFiles();
    }

    public override bool Validate(object? sender, DragEventArgs e, object? sourceContext, object? targetContext, object? state)
    {
        return true;
    }

    public override bool Execute(object? sender, DragEventArgs e, object? sourceContext, object? targetContext, object? state)
    {
        return true;
    }
}
