using Tucodev.Core.Models;

namespace Tucodev.Core.Interfaces
{
    /// <summary>
    /// The viewmodel of the main window. The IViewmodel is the content.
    /// </summary>
    public interface IMainWindowViewModel
    {
        /// <summary>
        /// The title.
        /// </summary>
        string Title { get; }

        string Id { get; set; }
        IViewModel ViewModel { get; set; }

        void SetSelectedPlugin();
        void SetPlugins(LoadPluginEventArgs args);
    }
}
