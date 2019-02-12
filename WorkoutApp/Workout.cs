using System;
using System.Collections.Generic;
using System.Text;

namespace WorkoutApp
{

    enum TypeOfWorkout
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
    class Workout
    {
        /// <summary>
        /// Workout number
        /// </summary>
        private static int lastWorkoutNumber = 0;

        #region Properties

        public int WorkoutNumber { get; }

        public DateTime WorkoutDate { get; set; }

        public TypeOfWorkout WorkoutType { get; set; }

        public int WorkoutDuration { get; set; }

        #endregion

        #region Constructors

        public Workout()
        {
            WorkoutNumber = ++lastWorkoutNumber;
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