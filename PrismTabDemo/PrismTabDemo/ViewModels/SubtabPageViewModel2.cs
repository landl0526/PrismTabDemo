using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrismTabDemo.ViewModels
{
    public class SubtabPageViewModel2 : ViewModelBase
    {
        public SubtabPageViewModel2(INavigationService navigationService)
            : base(navigationService)
        {
            LabelText = "Second Tab shows";
        }

        string labelText;
        public string LabelText
        {
            set => SetProperty(ref labelText, value);
            get => labelText;
        }
    }
}
