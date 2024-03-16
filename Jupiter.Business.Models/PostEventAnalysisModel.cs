using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Business.Models
{
    public class PostEventAnalysisModel
    {
        public int EmergencyId { get; set; }
        public PostEventAnalysis postEventAnalysis { get; set; }
        public EmergencyPostEventAnalysisFollowUp emergencyPostEventAnalysisFollowUp { get; set; }
        public string ActionTakenByStaff { get; set; }
        public string Observation { get; set; }
        public List<QuickResponseTeam> quickResponseTeams { get; set; }
        //public BasicLifeSupport basicLifeSupport { get; set; }
        public UploadAttachments uploadAttachments { get; set; }
        public CAPA cAPA { get; set; }
    }
    public class PostEventAnalysis
    {
        public int TypeOfArrestId { get; set; }  // enum
        public string TypeOfArrestDescription { get; set; }
        public int TypeOfRythmId { get; set; }  //enum
        public bool IsBLSInitiated { get; set; }
        public bool IsDefibrillatorAttached { get; set; }
        public bool IsACLS { get; set; }
        public bool IsConsciousnessRegained { get; set; }
        public bool IsFamilyCounseled { get; set; }
        public DateTime PatientLastAccessed { get; set; }  // Time
        public decimal Temperature { get; set; }
        public decimal Pulse { get; set; }
        public decimal R { get; set; }
        public decimal BPSystolic { get; set; }
        public decimal BPDiastolic { get; set; }
        public decimal SPO2 { get; set; }
        public decimal HGT { get; set; }
        public decimal GCS { get; set; }
    }

    public class EmergencyPostEventAnalysisFollowUp
    {
        public bool IsROCSAchieved { get; set; }
        public string ROCSTransferredTo { get; set; }
        public DateTime ROCSTransferredTime { get; set; }  // Time
        public bool IsTTM { get; set; }
        public bool IsCS48Hrs { get; set; }
        public string TransferOutTo { get; set; }
        public DateTime TransferOn { get; set; }  // Time
        public string DischargedToHome { get; set; }
        public bool IsExpired { get; set; }

    }


    public class QuickResponseTeam
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpDesignation { get; set; }
    }

    //public class BasicLifeSupport
    //{
    //    public DateTime BLSStartedOn { get; set; }
    //    public bool IsACABFollowed { get; set; }
    //    public string IsACABFollowed { get; set; }
    //    public bool IsExpired { get; set; }
    //    public bool IsCCABFollowed { get; set; }
    //    public bool IsExpired { get; set; }
    //    public bool IsACLSTeamOnTime { get; set; }
    //    public bool IsExpired { get; set; }
    //    public bool IsExpired { get; set; }
    //}

    public class UploadAttachments
    {

    }

    public class CAPA
    {

    }
}
