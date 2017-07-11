using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnalityEngine
{
    public class PotentialEvent
    {
        public PotentialEvent(DateTime date, int intensity, int anger, int sadness, int happiness, int joy, int disgust, int fear)
        {
            TimeSpan difference = DateTime.Now - date.Date;
            int months = (int)Math.Truncate(difference.Days / 30.436875);
            EventRetreatment = months / (intensity / 3);
            Intensity = intensity;
            LevelAnger = anger;
            LevelDisgust = disgust;
            LevelFear = fear;
            LevelHappiness = happiness;
            LevelJoy = joy;
            LevelSadness = sadness;

        }
        int ID { get; }
        public string Title { get; set; }

        public int LevelAnger { get; set; }

        public int LevelSadness { get; set; }

        public int LevelJoy { get; set; }

        public int LevelHappiness { get; set; }

        public int LevelDisgust { get; set; }

        public int LevelFear { get; set; }

        public int LevelLove { get; set; }

        public int EventRetreatment { get; set; }

        public DateTime HappenDate { get; }

        public int Intensity { get; }


        public bool IsRemindable
        {
            get
            {
                return true;
            }
        }
    }
}
