using System;
using System.Collections.Generic;
using System.Text;
using HospitalBusinessLogic.Enums;
using System.Runtime.Serialization;

namespace HospitalBusinessLogic.BindingModels
{
    [DataContract]
    public class VisitBindingModel
    {
        [DataMember]
        public int? Id { get; set; }
        [DataMember]
        public int DoctorId { get; set; }
        [DataMember]
        public int Count { get; set; }
        [DataMember]
        public decimal Sum { get; set; }
        [DataMember]
        public VisitStatus Status { get; set; }
        [DataMember]
        public DateTime DateVisit { get; set; }
        [DataMember]
        public DateTime? DateImplement { get; set; }
    }
}
