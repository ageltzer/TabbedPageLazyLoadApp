using Xamarin.Forms;

namespace TabbedPageLazyLoadApp
{
    class LazyContentViewBehavior : LoadContentOnActivateBehavior<ContentView>
    {
        protected override void SetContent(ContentView element, View contentView)
        {
            element.Content = contentView;
        }
    }
}
