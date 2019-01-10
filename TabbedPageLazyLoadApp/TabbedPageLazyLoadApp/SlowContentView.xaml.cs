using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TabbedPageLazyLoadApp
{
    public partial class SlowContentView : ContentView
    {
        public SlowContentView()
        {
            InitializeComponent();

            // Simulating a complex view
            // NEVER do this in real code
            Task.Delay(TimeSpan.FromSeconds(5)).Wait();
        }
    }
}