using System;
using System.Collections.ObjectModel;
using System.Linq;
using Tucodev.Core.Interfaces;
using Tucodev.Core.Models;
using Tucodev.Core.MVVM;

namespace tucodev.Core.Mainframe
{
    //[System.ComponentModel.Composition.Export(typeof(IMainWindowViewModel))]
    //[PropertyChanged.AddINotifyPropertyChangedInterface]
    public class MainWindowViewModel : IMainWindowViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindowViewModel"/> class.
        /// </summary>
        /// <param name="pm">The pm.</param>
        public MainWindowViewModel()
        {
            Title = "tucodev";
            Plugins = new ObservableCollection<PluginItemBase>();
            Id = "{EA29CDC3-073D-4C08-BE0A-7D1C9DB1A27C}";
        }

        public string Title { get; set; }

        public ObservableCollection<PluginItemBase> Plugins { get; set; }

        public string Id { get; set; }

        public IViewModel ViewModel { get; set; }

        public void SetSelectedPlugin()
        {
            Plugins.FirstOrDefault()?.Command.Execute(null);
        }

        public void SetPlugins(LoadPluginEventArgs args)
        {
            if (string.IsNullOrEmpty(args.Item.Id))
            {
                return;
            }

            var plugin = Plugins.FirstOrDefault(x => x.Id.Equals(args.Item.Id, StringComparison.InvariantCultureIgnoreCase));
            if (plugin == null)
            {
                plugin = new PluginItemBase(args.Item.Id, args.Item.Name, args.Item.Command);
                Plugins.Add(plugin);
            }
        }
    }
}
