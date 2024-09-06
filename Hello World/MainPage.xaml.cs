namespace Hello_World;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void Hello_OnClicked(object sender, EventArgs e)
    {
        if (lblDisplay.Text == "Hello World") lblDisplay.Text = "this is cool!";
        else lblDisplay.Text = "Hello World";
    }
}