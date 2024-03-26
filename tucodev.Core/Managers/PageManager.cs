using System.Collections.Generic;
using Tucodev.Core.Interfaces;
using Tucodev.Core.Mainframe;

namespace Tucodev.Core.Managers
{
    /// <summary>
    /// Manages the pages created to store in the mainframe.
    /// </summary>
    public abstract class PageManager : IPageManager
    {
        public List<IVVMMappingBase> AvailableViews { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PageManager"/> class.
        /// </summary>
        public PageManager()
        {
        }

        #region IPageManager functions

        public abstract IContainerViewModel SetPageInMainWindow(IViewModelBase newPage);

        public IContainerViewModel CreateNewPage(IViewModelBase newPage)
        {
            return new ContainerViewModel(newPage);
        }

        public abstract void LoadAvailableViews();

        #endregion
    }
}