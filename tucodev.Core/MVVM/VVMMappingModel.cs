using System;
using Tucodev.Core.Interfaces;

namespace tucodev.Core.MVVM
{
    public class VVMMappingModel : IVVMMappingModel
    {
        public Type View { get; set; }
        public Type ViewModel { get; set; }

        public VVMMappingModel() { }

        public VVMMappingModel(Type viewModel, Type view)
        {
            View = view;
            ViewModel = viewModel;
        }
    }
}
