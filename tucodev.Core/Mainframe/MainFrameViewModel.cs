using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Tucodev.Core.Interfaces;
using Tucodev.Core.MVVM;

namespace Tucodev.Core.Mainframe
{
    public sealed class MainFrameViewModel : IMainFrameViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainFrameViewModel"/> class.
        /// </summary>
        public MainFrameViewModel()
        {
            Title = "tucodev";
            Plugins = new ObservableCollection<PluginItemBase>();
            Id = "{EA29CDC3-073D-4C08-BE0A-7D1C9DB1A27C}";
        }

        public string Id { get; set; }
        public string Title { get; set; }
        public IViewModelBase ViewModel { get; set; }
        public ObservableCollection<PluginItemBase> Plugins { get; set; }

        public void LoadPlugin(string id, string name, ICommand command)
        {
            if (string.IsNullOrEmpty(id))
            {
                return;
            }

            var plugin = Plugins.FirstOrDefault(x => x.Id.Equals(id, StringComparison.InvariantCultureIgnoreCase));
            if (plugin == null)
            {
                plugin = new PluginItemBase(id, name, command);
                Plugins.Add(plugin);
            }
        }

        public void DisplaySelectedPlugin(string id)
        {
            Plugins.FirstOrDefault(x => x.Id.Equals(id))?.Command.Execute(null);
        }
    }
}
