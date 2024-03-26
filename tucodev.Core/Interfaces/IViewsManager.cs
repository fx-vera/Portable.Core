using System.Collections.Generic;

namespace Tucodev.Core.Interfaces
{
    public interface IViewsManager
    {
        /// <summary>
        /// Gets the available views.
        /// </summary>
        /// <value>
        /// The available views.
        /// </value>
        List<IVVMMappingBase> AvailableViews { get; }

        /// <summary>
        /// Loads the availiable views.
        /// </summary>
        void LoadAvailableViews();
    }
}
