using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnalityEngine
{
    public interface IObservation
    {
        Dictionary<string, PersonnalityFactors> Factors { get; }
        string GetObservation();

        IObservation Generate();


    }
}
