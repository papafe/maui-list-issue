using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MauiApp2.ViewModel;

public partial class MainViewModel : ObservableObject
{
    public MainViewModel()
    {
        Items = new ObservableCollection<Item>()
        {
            new Item("test1"),
            new Item("test2"),
        };
    }

    [ObservableProperty]
    ObservableCollection<Item> items;

    [ObservableProperty]
    string text;

    [RelayCommand]
    void Delete(Item s)
    {
        if(Items.Contains(s))
        {
            Items.Remove(s);
        }
    }
}

public class Item
{
    public string Content { get; set; }

    public bool IsMine { get; set; } = true;

    public Item(string content)
    {
        Content = content;
    }
}
