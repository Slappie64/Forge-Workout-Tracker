
namespace Forge___Workout_Tracker.Models
{
    class Workout
    {
        public int Id { get; set; }
        public required string UserId { get; set; }
        public DateTime Date { get; set; }
        public List<Exercise> Exercises { get; set; } = new();
    }
}
