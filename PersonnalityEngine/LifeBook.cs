using System.Collections.Generic;

namespace PersonnalityEngine
{
    public class LifeBook
    {
        List<PotentialEvent> Events { get; }

        Human Owner { get; }

        //TODO : Define basics automatically from events or add manually
        List<ImportantPrinciple> Basics { get; }

        /// <summary>
        /// TODO : Define the majority from feelings of each event in Events property
        /// </summary>
        /// <returns></returns>
        Dictionary<string, int> LifeFeelings()
        {
            Dictionary<string, int> d = new Dictionary<string, int>();
            d.Add("anger", 0);
            d.Add("joy", 0);
            d.Add("happiness", 0);
            d.Add("fear", 0);
            d.Add("sadness", 0);
            d.Add("disgust", 0);
            d.Add("love", 0);

            foreach (PotentialEvent e in Events)
            {
                d["anger"] += e.LevelAnger;
                d["joy"] += e.LevelJoy;
                d["happiness"] += e.LevelHappiness;
                d["fear"] += e.LevelFear;
                d["sadness"] += e.LevelSadness;
                d["disgust"] += e.LevelDisgust;
                d["love"] += e.LevelLove;
            }


            return d; 
        }
    }
}