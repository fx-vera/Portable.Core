using System.Collections.Generic;

namespace Tucodev.Core.Interfaces
{
    /// <summary>
    /// Allow to manage the basic application operations and the main window.
    /// This class can be extended depending on requirements.
    /// </summary>
    public interface IBootstrapperBase
    {
        /// <summary>
        /// List of substrings of the dll names that WILL be allowed when trying MEF composition
        /// </summary>
        List<string> DllAllowed { get; }
        void OnStartup();

        /// <summary>
        /// Here implements a method to handle the unhandled exceptios.
        /// </summary>
        void UnhandledExceptionHandler();
    }
}