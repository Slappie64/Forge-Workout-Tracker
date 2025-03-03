using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forge___Workout_Tracker.Models
{
    class Exercise
    {
        public int Id { get; set; }
        public int WorkoutId { get; set; }
        public required string ExerciseName { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }
        public double Weight { get; set; }
    }
}
