using System;
using System.Collections.Generic;
using System.Text;

namespace WorkoutApp
{
    class User
    {

        /// <summary>
        /// User number
        /// </summary>
        private static int lastUserNumber = 0;

        #region Properties
        /// <summary>
        /// User properties
        /// </summary>
        private int UserNumber { get; set; }

        public string Username { get; set; }

        public string EmailAddress { get; set; }

        public DateTime CreateDate { get; set; }

        public int TotalWorkouts { get; set; }

        public decimal TotalDuration { get; set; }


        #endregion

        #region Constructors
        /// <summary>
        /// Constructors tell how to build an instance of the class; will always have the same name as the class
        /// </summary>
        public User()
        {
            UserNumber = ++lastUserNumber;
            CreateDate = DateTime.UtcNow;
            TotalWorkouts = 0;
            TotalDuration = 0;
        }
        #endregion

        #region Methods

        /// <summary>
        /// update workout tracking
        /// </summary>
        /// <param name="amount"></param>Amount to be deposited
        public void AddWorkout(int amount)
        {
            TotalWorkouts += amount;
        }

        public void DeleteWorkout(int amount)
        {
            TotalWorkouts += amount;
        }

        public void AddDuration(decimal amount)
        {
            TotalDuration += amount;
        }

        public void RemoveDuration(decimal amount)
        {
            TotalDuration += amount;
        }
        #endregion

    }

}
