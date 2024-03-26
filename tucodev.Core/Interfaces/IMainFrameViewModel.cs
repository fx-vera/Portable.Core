using System.Collections.ObjectModel;
using System.Windows.Input;
using Tucodev.Core.MVVM;

namespace Tucodev.Core.Interfaces
{
    /// <summary>
    /// The viewmodel of the main window. The IViewmodel is the content.
    /// </summary>
    public interface IMainFrameViewModel
    {
        /// <summary>
        /// Unique Identifier of the MainWindowViewModel.
        /// </summary>
        string Id { get; set; }

        /// <summary>
        /// The title for the Mainframe.
        /// </summary>
        string Title { get; }

        /// <summary>
        /// The container viewmodel.
        /// </summary>
        IViewModelBase ViewModel { get; set; }

        /// <summary>
        /// Collection of plugins available for the mainframe.
        /// </summary>
        ObservableCollection<PluginItemBase> Plugins { get; set; }

        /// <summary>
        /// Load the plugin data in the mainframe.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="command"></param>
        void LoadPlugin(string id, string name, ICommand command);

        /// <summary>
        /// Display the selected plugin in the Mainframe
        /// </summary>
        /// <param name="Id"></param>
        void DisplaySelectedPlugin(string Id);
    }
}