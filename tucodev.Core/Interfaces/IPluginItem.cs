using System.Windows.Input;

namespace Tucodev.Core.Interfaces
{
    /// <summary>
    /// Interface IPluginItem
    /// </summary>
    //[Browsable(false)]
    //[EditorBrowsable(EditorBrowsableState.Never)]
    public interface IPluginItem
    {
        string Id { get; set; }

        string Name { get; set; }

        ICommand Command { get; set; }
    }
}
