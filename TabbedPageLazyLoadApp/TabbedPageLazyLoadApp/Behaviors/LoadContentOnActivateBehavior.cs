using System;
using Xamarin.Forms;

namespace TabbedPageLazyLoadApp
{
    abstract class LoadContentOnActivateBehavior<TActivateAwareElement> : Behavior<TActivateAwareElement>
        where TActivateAwareElement : VisualElement
    {
        public DataTemplate ContentTemplate { get; set; }

        protected override void OnAttachedTo(TActivateAwareElement element)
        {
            base.OnAttachedTo(element);
            (element as IActiveAware).IsActiveChanged += OnIsActiveChanged;
        }

        protected override void OnDetachingFrom(TActivateAwareElement element)
        {
            (element as IActiveAware).IsActiveChanged -= OnIsActiveChanged;
            base.OnDetachingFrom(element);
        }

        void OnIsActiveChanged(object sender, EventArgs e)
        {
            var element = (TActivateAwareElement)sender;
            element.Behaviors.Remove(this);
            SetContent(element, (View)ContentTemplate.CreateContent());
        }

        protected abstract void SetContent(TActivateAwareElement element, View contentView);
    }
}
