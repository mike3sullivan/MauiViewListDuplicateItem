using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MauiListViewDuplicateItem;

public partial class PageControls : ContentPage, INotifyPropertyChanged
{
	public PageControls()
	{
		InitializeComponent();
		BindingContext = this;
    }

    int count = 1;
	private void Button_Clicked(object sender, EventArgs e)
    {
        count++;
        ListView_Items.Add(count.ToString());
    }

    private bool _Show_IsChecked = false;
    public bool Show_IsChecked
    {
        get
        {
            return _Show_IsChecked;
        }
        set
        {
            _Show_IsChecked = value;
            OnPropertyChanged(nameof(Show_IsChecked));

            ListView_Items.Add("-- First Row --");
        }
    }

    public int Label_Text
    {
        get
        {
            return ListView_Items.Count;
        }
    }
    public ObservableCollection<string> ListView_Items { get; set; } = new ObservableCollection<string>();

}