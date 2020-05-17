using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
namespace HospitalBusinessLogic.BindingModels
{
    [DataContract]
    public class CreateVisitBindingModel
    {
        [DataMember]
        public int DoctorId { get; set; }

        [DataMember]
        public int ClientId { get; set; }
        [DataMember]
        public int Count { get; set; }
        [DataMember]
        public decimal Sum { get; set; }
    }
}
