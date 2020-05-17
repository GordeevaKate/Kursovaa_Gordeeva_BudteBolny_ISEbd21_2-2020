using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using HospitalBusinessLogic.Enums;

namespace HospitalBusinessLogic.BindingModels
{
    [DataContract]
    public class ClientBindingModel
    {
        [DataMember]
        public int? Id { get; set; }
        [DataMember]
        public int VisitId { get; set; }
        [DataMember]
        public string ClientLogin{ get; set; }
        [DataMember]
        public string ClientParol { get; set; }
        [DataMember]
        public ClientStatus Status { get; set; }
    }
}
