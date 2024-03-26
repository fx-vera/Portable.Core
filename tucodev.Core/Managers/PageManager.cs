using tucodev.Core.Mainframe;
using Tucodev.Core.Interfaces;

namespace Tucodev.Core.Managers
{
    public abstract class PageManager : IPageManager
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PageManager"/> class.
        /// </summary>
        public PageManager()
        {
        }

        #region IPageManager functions

        public abstract IWindowViewModel SetPageInMainWindow(IViewModel newPage);

        public IWindowViewModel CreateNewWindow(IViewModel newPage)
        {
            return new GenericViewModel(newPage);
        }

        #endregion
    }
}