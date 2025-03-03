using ForgeWorkoutTracker.Views;
using Microsoft.Maui.Controls;

namespace ForgeWorkoutTracker
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Register routes
            Routing.RegisterRoute(nameof(WorkoutDetails), typeof(Views.WorkoutDetails));
            // Add more routes as needed
        }
    }
}