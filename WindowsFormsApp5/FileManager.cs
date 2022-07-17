using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp5
{
    class FileManager
    {

        private const string fileVersionToken = "KitchenTimer_21";

        private const double fileVersionNr = 1.0;


        /// <summary>
        /// Save and write values from timerList to StreamWriter with string fileName
        /// </summary>
        /// <param name="timerList"></param>
        /// <param name="fileName"></param>
        /// <returns>bool value</returns>
        public bool SaveKitchenTimerListToFile(List<KitchenTimer> timerList, string fileName)
        {
            bool value = true;

            StreamWriter writer = null;
       
          
            try
            {
                writer = new StreamWriter(fileName);
                writer.WriteLine(fileVersionToken);
                writer.WriteLine(fileVersionNr);
                writer.WriteLine(timerList.Count);


                for (int i = 0; i < timerList.Count; i++)
                {
                    writer.WriteLine(timerList[i].Minutes);
                    writer.WriteLine(timerList[i].Seconds);

                    writer.WriteLine(timerList[i].SetMinutes);
                    writer.WriteLine(timerList[i].SetSeconds);

                    writer.WriteLine(timerList[i].StartMinute);
                    writer.WriteLine(timerList[i].StartSecond);

                    writer.WriteLine(timerList[i].Description);
                    writer.WriteLine(timerList[i].TimerStatus.ToString());

                    writer.WriteLine(timerList[i].Count);
                    writer.WriteLine(timerList[i].Finished);


                }


            }
            catch
            {
                value = false;
            }
            finally
            {
                if (writer != null)
                    writer.Close();

            }


            return value;
        }



     
        /// <summary>
        /// Read values from List timerList from the string fileName
        /// </summary>
        /// <param name="timerList"></param>
        /// <param name="fileName"></param>
        /// <returns>bool value</returns>
        public bool ReadKitchenTimerListFromFile(List<KitchenTimer> timerList, string fileName)
        {
            bool value = true;


            StreamReader reader = null;


            try
            {
                if (timerList != null)
                    timerList.Clear();
                else
                    timerList = new List<KitchenTimer>();


                reader = new StreamReader(fileName);

                string versionTest = reader.ReadLine();

                double version = double.Parse(reader.ReadLine());


                if((versionTest == fileVersionToken) && (version == fileVersionNr))
                {

                    int count = int.Parse(reader.ReadLine());

                    for (int i = 0; i < count; i++)
                    {

                        KitchenTimer kitchenTimer = new KitchenTimer();


                        kitchenTimer.Minutes = int.Parse(reader.ReadLine());
                        kitchenTimer.Seconds = int.Parse(reader.ReadLine());

                        kitchenTimer.SetMinutes = int.Parse(reader.ReadLine());
                        kitchenTimer.SetSeconds = int.Parse(reader.ReadLine());

                        kitchenTimer.StartMinute = int.Parse(reader.ReadLine());
                        kitchenTimer.StartSecond = int.Parse(reader.ReadLine());

                        kitchenTimer.Description = reader.ReadLine();
                        kitchenTimer.TimerStatus = (TimerStatus)Enum.Parse(typeof(TimerStatus), reader.ReadLine());


                        kitchenTimer.Count = int.Parse(reader.ReadLine());
                        kitchenTimer.Finished = bool.Parse(reader.ReadLine());



                        timerList.Add(kitchenTimer);

                    }



                }


            }
            catch
            {
                value = false;
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }



            return value;
        }





    }

}
