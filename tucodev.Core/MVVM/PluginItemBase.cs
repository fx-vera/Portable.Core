using System.Windows.Input;
using Tucodev.Core.Interfaces;

namespace Tucodev.Core.MVVM
{
    public class PluginItemBase : IPluginItemBase
    {
        public PluginItemBase()
        {
        }

        public PluginItemBase(string id, string name, ICommand command)
        {
            Id = id;
            Name = name;
            Command = command;
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public ICommand Command { get; set; }
    }
}
