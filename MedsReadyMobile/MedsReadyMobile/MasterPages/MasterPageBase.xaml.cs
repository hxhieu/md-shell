using MedsReadyMobile.ViewModels.Base;
using System;
using Xamarin.Forms;

namespace MedsReadyMobile.MasterPages
{
    public abstract partial class MasterPageBase : ContentPage, IMasterPageCommon
    {
        public MasterPageBase()
        {
            InitializeComponent();
        }

        public void AppendChildren(params View[] children)
        {
            var root = Content as Layout<View>;
            if (root == null) throw new NullReferenceException("Cannot find the root of the view. Make sure the root element of the view is an assignable from Layout<View>");
            foreach (var child in children)
            {
                root.Children.Add(child);
            }
        }
    }
}
