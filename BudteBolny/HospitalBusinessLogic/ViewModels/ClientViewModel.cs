using System;
using HospitalBusinessLogic.Enums;
using System.ComponentModel;

namespace HospitalBusinessLogic.ViewModels
{
    public class ClientViewModel
    {
        public int Id { get; set; }
        public int VisitId { get; set; }
        public ClientStatus Status { get; set; }
    }
}
