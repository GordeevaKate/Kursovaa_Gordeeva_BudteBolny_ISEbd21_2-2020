using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
namespace HospitalBusinessLogic.BindingModels
{
    [DataContract]
    public class ProfessionBindingModel
    {
        [DataMember]
        public int? Id { get; set; }
        [DataMember]
        public string ProfessionName { get; set; }
    }
}
