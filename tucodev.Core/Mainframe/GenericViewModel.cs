using Tucodev.Core.Interfaces;

namespace tucodev.Core.Mainframe
{
    /// <summary>
    /// The content of the user controls will be set in this viewmodel
    /// </summary>
    public sealed class GenericViewModel : IWindowViewModel
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericViewModel"/> class.
        /// </summary>
        /// <param name="content">The content.</param>
        public GenericViewModel(IViewModel content)
        {
            Initialize(content);
        }

        #endregion

        #region IWindow events

        #endregion

        #region IWindow Properties

        /// <summary>
        /// Gets or sets the content of the page.
        /// </summary>
        /// <value>
        /// The content of the page.
        /// </value>
        public IViewModel ViewModel { get; set; }

        #endregion

        /// <summary>
        /// Initializes the specified window content.
        /// </summary>
        /// <param name="windowContent">Content of the window.</param>
        private void Initialize(IViewModel windowContent)
        {
            ViewModel = windowContent;
        }
    }
}
