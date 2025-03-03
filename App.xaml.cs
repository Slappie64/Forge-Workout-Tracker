using ForgeWorkoutTracker;

namespace Forge___Workout_Tracker
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            base.OnStart();

            if (!IsUserLoggedIn())
            {
                // Navigate to LoginPage
                Shell.Current.GoToAsync("//LoginPage");
            }
        }

        private bool IsUserLoggedIn()
        {
            // Implement your authentication check logic
            return false;
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new MainPage()) { Title = "Forge - Workout Tracker" };
        }
    }
}
