using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrismTabDemo.ViewModels
{
    public class SubtabPageViewModel1 : ViewModelBase
    {       
        public SubtabPageViewModel1(INavigationService navigationService)
            : base(navigationService)
        {
            LabelText = "This is the first subTab page";
        }
        string labelText;
        public string LabelText
        {
            set => SetProperty(ref labelText, value);
            get => labelText;
        }
    }
}
