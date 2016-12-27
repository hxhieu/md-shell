using System;
using MedsReadyMobile.ViewModels.Base;

namespace MedsReadyMobile.MasterPages
{
    public abstract partial class MasterPageBottomMenu : MasterPageBase, IMasterPageBottomMenu
    {
        public MasterPageBottomMenu()
        {
            InitializeComponent();
        }
    }
}
