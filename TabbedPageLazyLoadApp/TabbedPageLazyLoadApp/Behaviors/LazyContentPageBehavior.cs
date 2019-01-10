using Xamarin.Forms;

namespace TabbedPageLazyLoadApp
{
    class LazyContentPageBehavior : LoadContentOnActivateBehavior<ContentPage>
    {
        protected override void SetContent(ContentPage page, View contentView)
        {
            page.Content = contentView;
        }
    }
}
