using System;

namespace TabbedPageLazyLoadApp
{
    interface IActiveAware
    {
        bool IsActive { get; set; }
        event EventHandler IsActiveChanged;
    }
}
