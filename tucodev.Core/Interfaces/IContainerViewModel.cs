namespace Tucodev.Core.Interfaces
{
    /// <summary>
    /// The viewmodel of IContainerView
    /// </summary>
    public interface IContainerViewModel
    {
        /// <summary>
        /// This viewmodel will be displayed in the mainframe.
        /// </summary>
        IViewModelBase ViewModel { get; set; }
    }
}