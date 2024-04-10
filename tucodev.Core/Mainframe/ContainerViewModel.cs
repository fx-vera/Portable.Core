using Tucodev.Core.Interfaces;

namespace Tucodev.Core.Mainframe
{
    /// <summary>
    /// The content of the user controls will be set in this viewmodel
    /// </summary>
    public sealed class ContainerViewModel : IContainerViewModel
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerViewModel"/> class.
        /// </summary>
        /// <param name="content">The content.</param>
        public ContainerViewModel(IViewModelBase content)
        {
            ViewModel = content;
        }

        #endregion

        #region IWindow Properties

        /// <summary>
        /// Gets or sets the content of the page.
        /// </summary>
        /// <value>
        /// The content of the page.
        /// </value>
        public IViewModelBase ViewModel { get; set; }

        #endregion
    }
}
