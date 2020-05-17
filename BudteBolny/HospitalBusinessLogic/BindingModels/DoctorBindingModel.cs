using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
namespace HospitalBusinessLogic.BindingModels
{
    [DataContract]
    public class DoctorBindingModel
    {
        [DataMember]
        public int? Id { get; set; }
        [DataMember]
        public string DoctorName { get; set; }
        [DataMember]
        public decimal Price { get; set; }
        [DataMember]
        public Dictionary<int, (string, int)> DoctorProfessions { get; set; }
    }
}
