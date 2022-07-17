using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    class KitchenTimer
    {

        // Fields
        private int minutes = 0;
        private int seconds = 0;

        private int setMinutes = 0;
        private int setSeconds = 0;


        private int startMinute = 0;
        private int startSecond = 0;

        private string description;

        private TimerStatus timerStatus;

        private int count = 0;

        private bool finished = false;


        /// <summary>
        /// Constructor for KitchenTimer class
        /// </summary>
        public KitchenTimer()
        {
            description = string.Empty;
            timerStatus = TimerStatus.Running;
            finished = false;
            count = 0;
        }


        /// <summary>
        /// bool Finished get; set;
        /// </summary>
        public bool Finished
        {
            get { return finished; }

            set { finished = value; }
        }

        /// <summary>
        /// int Count get; set;
        /// </summary>
        public int Count
        {
            get { return count; }

            set { count = value; }
        }

        /// <summary>
        /// int Minutes get; set;
        /// </summary>
        public int Minutes
        {
            get
            {
                return minutes;
            }

            set
            {
                minutes = value;
            }
        }

        /// <summary>
        /// int Seconds get; set;
        /// </summary>
        public int Seconds
        {
            get { return seconds; }

            set { seconds = value; }
        }


        /// <summary>
        /// int SetSeconds get; set;
        /// </summary>
        public int SetSeconds
        {
            get { return setSeconds; }

            set { setSeconds = value; }
        }

        /// <summary>
        /// int SetMinutes get; set;
        /// </summary>
        public int SetMinutes
        {
            get { return setMinutes; }

            set { setMinutes = value; }
        }


        /// <summary>
        /// int StartSecond get; set;
        /// </summary>
        public int StartSecond
        {
            get { return startSecond; }

            set { startSecond = value; }
        }

        /// <summary>
        /// int StartMinute get; set;
        /// </summary>
        public int StartMinute
        {
            get { return startMinute; }

            set { startMinute = value; }
        }


        /// <summary>
        /// string Description get; set;
        /// </summary>
        public string Description
        {
            get { return description; }

            set 
            {
                if (!string.IsNullOrEmpty(value))
                    description = value; 
            }
        }

        /// <summary>
        /// TimerStatus TimerStatus get; set;
        /// </summary>
        public TimerStatus TimerStatus
        {
            get { return timerStatus; }

            set { timerStatus = value; }
        }







    }
}
