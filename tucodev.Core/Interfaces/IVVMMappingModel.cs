using System;

namespace Tucodev.Core.Interfaces
{
    /// <summary>
    /// Interface to support viewmodel mapping.
    /// </summary>
    public interface IVVMMappingModel
    {
        /// <summary>
        /// The view pared with the viewmodel
        /// </summary>
        Type View { get; set; }
        /// <summary>
        /// The viewmodel paired with the view
        /// </summary>
        Type ViewModel { get; set; }
    }
}
