using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnalityEngine
{
    public class Human
    {
        int ID { get; }
        string FirstName { get; }
        string LastName { get; }

        string OtherName { get; }

        List<IObservation> Observations { get; }
        string Gender { get; }
        DateTime BirthDate { get; }

        LifeBook LifeBook { get; }

        string GetAstrologicalSign()
        {
            return "";
        }
        string GetAstrologicalAscendant()
        {
            return "";
        }
        

        ObsFeeling ObserveFeelings()
        {
            throw new NotImplementedException();
        }
    }
}
