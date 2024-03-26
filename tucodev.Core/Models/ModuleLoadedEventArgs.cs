using System;

namespace Tucodev.Core.Models
{
    public class ModuleLoadedEventArgs : EventArgs
    {
        public string ModuleName { get; set; }
        public ModuleLoadedEventArgs(string name) { ModuleName = name; }
    }
}
