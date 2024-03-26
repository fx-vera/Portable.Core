﻿using System;
using System.Collections.Generic;
using Tucodev.Core.Interfaces;
using Tucodev.Core.Models;

namespace Tucodev.Core.MVVM
{
    /// <summary>
    /// Base class used to register in the global application dictionary a mapping between 
    /// a specific viewmodel (not the interface it implements) and a view. 
    /// </summary>
    public class ViewViewModelMappingBase : IVVMMappingBase
    {
        private List<IVVMMappingModel> _mappings = new List<IVVMMappingModel>();
        public List<IVVMMappingModel> Mappings { get { return _mappings; } }

        public ViewViewModelMappingBase() { }

        public ViewViewModelMappingBase(IVVMMappingModel vm)
        {
            _mappings.Add(vm);
        }

        public ViewViewModelMappingBase(Type viewModel, Type view)
        {
            AddMapping(viewModel, view);
        }

        public void AddMapping(Type viewModel, Type view)
        {
            _mappings.Add(new VVMMappingModel(viewModel, view));
        }
    }

    public class ViewViewModelMappingBase<ViewModel, View> : ViewViewModelMappingBase
    {
        public ViewViewModelMappingBase() : base(typeof(ViewModel), typeof(View)) { }
    }
}