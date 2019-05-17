using Prism;
using Prism.Ioc;
using Prism.Mvvm;
using PrismTabDemo.ViewModels;
using PrismTabDemo.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace PrismTabDemo
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("MenuPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MenuPage, MenuPageViewModel>();

            containerRegistry.RegisterForNavigation<SubtabPage1, SubtabPageViewModel1>();
            containerRegistry.RegisterForNavigation<SubtabPage2, SubtabPageViewModel2>();
        }

    }
}
