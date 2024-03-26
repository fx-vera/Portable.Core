using System.Collections.Generic;

namespace Tucodev.Core.Interfaces
{
    /// <summary>
    /// Interface to be exported through MEF to register 
    /// the Views to be assigned to ViewModels
    /// </summary>
    public interface IVVMMappingBase
    {
        /// <summary>
        /// The mapping to store view/viewmodels and make it available for the mainframe.
        /// </summary>
        List<IVVMMappingModel> Mappings { get; }
    }
}
