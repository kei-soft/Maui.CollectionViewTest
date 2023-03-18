namespace Maui.CollectionViewTest;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();

        List<string> list = new List<string>();

        for (int i = 1; i <= 25; i++)
        {
            list.Add(i.ToString());
        }

        this.listview.ItemsSource = list;
    }
}

