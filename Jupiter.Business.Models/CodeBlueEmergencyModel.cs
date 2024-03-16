using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Business.Models
{
    public class CodeBlueEmergencyModel
    {
        public int EmergencyId { get; set; }
        public bool CaseType { get; set; }
        public EmergencyResucitationEfforts resucEfforts { get; set; }
        public List<EmergencyTreatment> treatmentDone { get; set; }
        public List<EmergencyInterventions> interventions { get; set; }
        public EmergencyPreArrestStatus preArrestStatus { get; set; }
    }

    public class EmergencyResucitationEfforts
    {
        public bool CPRNeeded { get; set; }
        public DateTime CPRStartDateTime { get; set; }  // Change to Time Datatype
        public DateTime CPREndDateTime { get; set; }    // Change to Time Datatype
        public string VenusAccess { get; set; }
        public string Other { get; set; }
        public DateTime Intubation { get; set; }   // Change to Time Datatype
    }

    public class EmergencyTreatment
    {
        public string DrugFluid { get; set; }
        public DateTime GivenTime { get; set; }
        public string Dosage { get; set; }
        // TBD
    }

    public class EmergencyInterventions
    {
        public string InterventionName { get; set; }
        public DateTime ECGRhythmTime { get; set; }
        public DateTime DefibrillatorJTime { get; set; }
        public DateTime PacerMATime { get; set; }
        public DateTime ETCO2Time { get; set; }
        // TBD
    }

    public class EmergencyPreArrestStatus
    {
        public DateTime PatientLastAccessed { get; set; }
        public decimal ParsScore { get; set; }
        public decimal Temperature { get; set; }
        public decimal Pulse { get; set; }
        public decimal R { get; set; }
        public decimal BPSystolic { get; set; }
        public decimal BPDiastolic { get; set; }
        public decimal SPO2 { get; set; }
        public decimal HGT { get; set; }
        public decimal GCS { get; set; }
        public string PreArrestStatus { get; set; }
        public string PreArrestEvent { get; set; }
        public bool IsCulturePositive { get; set; }
        public bool IsInotropes { get; set; }
        public bool IsTracheostomy { get; set; }
        public bool IsVentilation { get; set; }
        public bool IsOxygenRequired { get; set; }
        public bool IsOnBipap { get; set; }
        public bool IsSurgeryDone { get; set; }
        public bool IsVictimCritical { get; set; }
    }
}
