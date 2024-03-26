using System.Windows.Input;

namespace Tucodev.Core.Interfaces
{
    /// <summary>
    /// This item will be added to the mainframe and will be available to be openen anywhere.
    /// </summary>
    //[Browsable(false)]
    //[EditorBrowsable(EditorBrowsableState.Never)]
    public interface IPluginItemBase
    {
        /// <summary>
        /// Identify the plugin.
        /// </summary>
        string Id { get; set; }
        /// <summary>
        /// Name of the plugin.
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// The command that will exeuted when the user clics in the plugin if available in the mainframe.
        /// </summary>
        ICommand Command { get; set; }
    }
}
