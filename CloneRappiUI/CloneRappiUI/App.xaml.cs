using Plugin.SharedTransitions;
using Xamarin.Forms;

namespace CloneRappiUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new SharedTransitionNavigationPage( new Views.MasterPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
