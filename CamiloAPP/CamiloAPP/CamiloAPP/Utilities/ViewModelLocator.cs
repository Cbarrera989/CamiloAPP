using CamiloAPP;
using System;
using System.Globalization;
using System.Reflection;
using Xamarin.Forms;

namespace CamiloAPP.Utilities
{
    public class ViewModelLocator
    {
        public static readonly BindableProperty AutoWireViewModelProperty =
            BindableProperty.CreateAttached("AutoWireViewModel", typeof(bool),
                typeof(ViewModelLocator), default(bool),
                propertyChanged: OnAutoWireViewModelChanged);

        public static bool GetAutoWireViewModel(BindableObject bindable)
        {
            return (bool)bindable.GetValue(AutoWireViewModelProperty);
        }

        public static void SetAutoWireViewModel(BindableObject bindable, bool value)
        {
            bindable.SetValue(AutoWireViewModelProperty, value);
        }

        private static void OnAutoWireViewModelChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (!(bindable is Element view))
            {
                return;
            }

            var viewType = view.GetType();
            if (viewType.FullName != null)
            {
                var fullViewName = viewType.FullName.Replace(".Views.", ".ViewModels.");
                var viewName = fullViewName.Remove(fullViewName.Length - 4); //Remove "Page" word
                var viewAssemblyName = viewType.GetTypeInfo().Assembly.FullName;
                var viewModelName = string.Format(CultureInfo.InvariantCulture, "{0}ViewModel, {1}", viewName, viewAssemblyName);

                var viewModelType = Type.GetType(viewModelName);
                if (viewModelType == null)
                {
                    return;
                }

                var viewModel = Startup.Resolve(viewModelType);
                view.BindingContext = viewModel;
            }
        }
    }
}