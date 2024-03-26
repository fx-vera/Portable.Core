using System;

namespace Tucodev.Core.Interfaces
{
    public interface IVVMMappingModel
    {
         Type View { get; set; }
         Type ViewModel { get; set; }
    }
}
