using System.Collections.ObjectModel;

namespace MauiListViewDuplicateItem;

public partial class NewContent1 : ContentView
{
	public NewContent1()
	{
		InitializeComponent();
        BindingContext = this;
        ListView_Items.Add(count.ToString());
    }

    int count = 1;
    private void Button_Clicked(object sender, EventArgs e)
    {
        count++;
        ListView_Items.Add(count.ToString());
    }
    public ObservableCollection<string> ListView_Items { get; set; } = new ObservableCollection<string>();
}