using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    class TimerManager
    {


        private List<KitchenTimer> kitchenTimers;

        private int currentCount = 0;

        private int currentIndex = -1;


        /// <summary>
        /// Constructor for TimerManager
        /// </summary>
        public TimerManager()
        {
            kitchenTimers = new List<KitchenTimer>();
            currentCount = 0;
            currentIndex = -1;
        }


        /// <summary>
        /// int CurrentCount get; set;
        /// </summary>
        public int CurrentCount
        {
            get { return currentCount; }

            set { currentCount = value; }

        }

        /// <summary>
        /// int CurrentIndex get; set;
        /// </summary>
        public int CurrentIndex
        {
            get { return currentIndex; }

            set { 
                if (CheckIndex(value))
                    currentIndex = value; 
            }

        }



        /// <summary>
        /// Set timer to the List<T> object of class
        /// </summary>
        /// <param name="kitchenTimer">Kitchentimer object</param>
        public bool SetTimer(KitchenTimer kitchenTimer)
        {
            bool value = true;

            if (kitchenTimer != null)
                kitchenTimers.Add(kitchenTimer);
            else
                value = false;

            return value;
        }


        /// <summary>
        /// Get KitchenTimer object
        /// </summary>
        /// <param name="index">index for array</param>
        /// <returns>object if true, null if false</returns>
        public KitchenTimer GetTimer(int index)
        {
            if (CheckIndex(index))
                return kitchenTimers[index];
            else
                return null;
        }


        /// <summary>
        /// Get list length
        /// </summary>
        /// <returns>int length</returns>
        public int GetListLength()
        {
            return kitchenTimers.Count;
        }



        /// <summary>
        /// Update all kitchen timers if status is set to running. 
        /// </summary>
        public void UpdateTimers()
        {

            int countMinutes;
            int countSeconds;

            int valueMinutes;
            float valueSeconds;


            for (int i = 0; i<kitchenTimers.Count; i++)
            {


                if (kitchenTimers[i].TimerStatus == TimerStatus.Running)
                {
                  
                    valueMinutes = (CurrentCount - kitchenTimers[i].Count) / 60;

                    valueSeconds = (((float)(CurrentCount - kitchenTimers[i].Count) / 60) - valueMinutes) * 60;


                    if (valueSeconds > kitchenTimers[i].SetSeconds)
                    {
                        valueMinutes += 1;

                        valueSeconds = 60 - (valueSeconds - kitchenTimers[i].SetSeconds);
                    }
                    else
                    {
                        valueSeconds = (kitchenTimers[i].SetSeconds - valueSeconds);
                    }

                    countMinutes = kitchenTimers[i].SetMinutes - valueMinutes;

                    countSeconds = (int)valueSeconds;

                    
                    kitchenTimers[i].Seconds = countSeconds;

                    kitchenTimers[i].Minutes = countMinutes;

                    if(countMinutes <= 0 && countSeconds <= 0)
                    {
                        kitchenTimers[i].TimerStatus = TimerStatus.Finished;

                        kitchenTimers[i].Finished = true;
                    }

                }


            }


        }



        /// <summary>
        /// Delete timer from the class array at specified index
        /// </summary>
        /// <param name="index">int index</param>
        public void DeleteTimer(int index)
        {
            if (CheckIndex(index))
            {
                kitchenTimers.RemoveAt(index);
            }

        }


        /// <summary>
        /// Pause a timer from the class array at specified index
        /// </summary>
        /// <param name="index">int index</param>
        public void PauseTimer(int index)
        {
            if (CheckIndex(index))
            {
                if (kitchenTimers[index].TimerStatus != TimerStatus.Finished)
                {
                    kitchenTimers[index].TimerStatus = TimerStatus.Paused;

                    kitchenTimers[index].SetMinutes = kitchenTimers[index].Minutes;
                    kitchenTimers[index].SetSeconds = kitchenTimers[index].Seconds;
                }

            }
                    

        }


        /// <summary>
        /// Pause all timers in the class array
        /// </summary>
        public void PauseTimers()
        {

            for (int index = 0; index < kitchenTimers.Count; index++)
            {
                if (CheckIndex(index))
                {
                    if (kitchenTimers[index].TimerStatus == TimerStatus.Running)
                    {
                        kitchenTimers[index].TimerStatus = TimerStatus.Paused;

                        kitchenTimers[index].SetMinutes = kitchenTimers[index].Minutes;
                        kitchenTimers[index].SetSeconds = kitchenTimers[index].Seconds;
                    }

                }
            }


        }


        /// <summary>
        /// Resume timer and set timer status to running at specified index
        /// </summary>
        /// <param name="index">int index</param>
        public void ResumeTimer(int index)
        {
            if (CheckIndex(index))
            {
                if (kitchenTimers[index].TimerStatus != TimerStatus.Finished)
                {
                    kitchenTimers[index].TimerStatus = TimerStatus.Running;

                    kitchenTimers[index].Count = CurrentCount;

                }

            }



        }




        /// <summary>
        /// Increment timer minute by one at specified index
        /// </summary>
        /// <param name="index">int index</param>
        public void PlusMinute(int index)
        {
            if (CheckIndex(index))
            {
                kitchenTimers[index].Minutes += 1;

                kitchenTimers[index].SetMinutes += 1;

                kitchenTimers[index].StartMinute += 1;
            }
        }

        /// <summary>
        /// Decrement timer minute by one at specified index
        /// </summary>
        /// <param name="index"></param>
        public void MinusMinute(int index)
        {
            if (CheckIndex(index))
            {
                if (kitchenTimers[index].Minutes > 0)
                {
                    kitchenTimers[index].Minutes -= 1;

                    kitchenTimers[index].SetMinutes -= 1;

                    kitchenTimers[index].StartMinute -= 1;
                }
                   
            }
        }


        /// <summary>
        /// Set timer status to stopped
        /// </summary>
        public void StopTimer()
        {
            if (CheckIndex(CurrentIndex))
                GetTimer(CurrentIndex).TimerStatus = TimerStatus.Stopped;

        }



        /// <summary>
        /// Retrieve text from minute and second from timer in string format
        /// </summary>
        /// <param name="index">int index</param>
        /// <returns>string text</returns>
        public string GetTimerText(int index)
        {
            string text = "00:00";

            if (CheckIndex(index))
                text = string.Format("{0}:{1}", kitchenTimers[index].Minutes.ToString("00"), kitchenTimers[index].Seconds.ToString("00"));

            return text;
        }

        /// <summary>
        /// Retrieves all texts from kitchen timer objects 
        /// </summary>
        /// <returns>string []array</returns>
        public string[] GetKitchenTimerStringsList()
        {

            string[] infoStrings = new string[kitchenTimers.Count];

            for (int i = 0; i < infoStrings.Length; i++)
            {
                infoStrings[i] = string.Format("{0}:{1, -11} {2, -19} {3, -12} ", kitchenTimers[i].Minutes.ToString("00"), kitchenTimers[i].Seconds.ToString("00"),
                    kitchenTimers[i].Description, kitchenTimers[i].TimerStatus);

            }

            return infoStrings;


        }

        /// <summary>
        /// Check if index in array exist at specified index
        /// </summary>
        /// <param name="index">int index</param>
        /// <returns>bool value</returns>
        public bool CheckIndex(int index)
        {
            bool value = false;

            if (index >= 0 && index < kitchenTimers.Count)
                value = true;

            return value;
        }



        /// <summary>
        /// Read data from file with FileManager class
        /// </summary>
        /// <param name="fileName">string fileName</param>
        /// <returns>bool value</returns>
        public bool ReadDataFromFile(string fileName)
        {
            FileManager fileManager = new FileManager();

            return fileManager.ReadKitchenTimerListFromFile(kitchenTimers, fileName);
        }


        /// <summary>
        /// Write data to file with FileManager class
        /// </summary>
        /// <param name="fileName">string fileName</param>
        /// <returns>bool value</returns>
        public bool WriteDataToFile(string fileName)
        {
            FileManager fileManager = new FileManager();

            return fileManager.SaveKitchenTimerListToFile(kitchenTimers, fileName);
        }


      




    }
}
