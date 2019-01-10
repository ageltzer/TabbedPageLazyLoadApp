namespace TabbedPageLazyLoadApp.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new TabbedPageLazyLoadApp.App());
        }
    }
}
