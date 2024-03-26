using System.Collections.Generic;

namespace Tucodev.Core.Interfaces
{
    /// <summary>
    /// Manages the pages created to store in the mainframe.
    /// </summary>
    public interface IPageManager
    {
        /// <summary>
        /// Gets the available views.
        /// </summary>
        /// <value>
        /// The available views.
        /// </value>
        List<IVVMMappingBase> AvailableViews { get; }

        /// <summary>
        /// Display the pageViewModel in the mainframe.
        /// </summary>
        /// <param name="pageViewModel"></param>
        /// <returns></returns>
        IContainerViewModel SetPageInMainWindow(IViewModelBase pageViewModel);

        /// <summary>
        /// - For single instance windows: creates the single instance if not present, 
        /// or unminimizes and brings to front the existing one
        /// - For multiple instance windows: opens a new instance of the window if the maximum number has not been reached.
        /// </summary>
        /// <param name="pageViewModel">Page Content to insert in the new window</param>
        /// <returns>The window has been created and/or opened, or null if the operation could not be performed</returns>
        IContainerViewModel CreateNewPage(IViewModelBase pageViewModel);

        /// <summary>
        /// Loads the availiable views in the mainframe.
        /// </summary>
        void LoadAvailableViews();
    }
}
