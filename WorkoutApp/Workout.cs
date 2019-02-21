using System;
using System.Collections.Generic;
using System.Text;

namespace WorkoutApp
{

    public enum TypeOfWorkout
    {
        Run,
        Bike,
        Swim,
        Crosstraining,
        Yoga
    }
    /// <summary>
    /// Workout object for the application
    /// </summary>
    public class Workout
    {

        #region Properties

        public int WorkoutNumber { get; set; }

        public DateTime WorkoutDate { get; set; }

        public TypeOfWorkout WorkoutType { get; set; }

        public int WorkoutDuration { get; set; }

        #endregion

        #region Constructors

        public Workout()
        {
            WorkoutDate = DateTime.UtcNow;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Add a workout
        /// </summary>

        #endregion

    }
}