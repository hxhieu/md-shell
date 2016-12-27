using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xamarin.Forms;

namespace MedsReadyMobile.FreshMvvm
{
    internal class CrossAssembliesModelMapper : IFreshPageModelMapper
    {
        private readonly Dictionary<string, string> _viewTypeNames;
        private readonly string _viewAssemblyName;

        public CrossAssembliesModelMapper(Assembly viewAssembly)
        {
            _viewAssemblyName = viewAssembly.FullName;
            _viewTypeNames = viewAssembly.DefinedTypes.Where(t => t.IsSubclassOf(typeof(VisualElement))).ToDictionary(x => x.Name, x => x.AssemblyQualifiedName);
        }

        public string GetPageTypeName(Type pageModelType)
        {
            var pageTypeName = pageModelType.Name.Replace("PageModel", "Page").Replace("ViewModel", "Page");
            if (!_viewTypeNames.ContainsKey(pageTypeName))
            {
                throw new KeyNotFoundException($"No page / view found to map with {pageModelType.FullName} model.");
            }
            return _viewTypeNames[pageTypeName];
        }
    }
}
