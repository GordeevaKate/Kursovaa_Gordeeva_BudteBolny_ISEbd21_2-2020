using System;
using HospitalBusinessLogic.Enums;
using System.ComponentModel;

namespace HospitalBusinessLogic.ViewModels
{
    public class VisitViewModel
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        [DisplayName("Доктор")]
        public string DoctorName { get; set; }
        [DisplayName("Количество")]
        public int Count { get; set; }
        [DisplayName("Сумма")]
        public decimal Sum { get; set; }
        [DisplayName("Статус")]
        public VisitStatus Status { get; set; }
        [DisplayName("Дата создания")]
        public DateTime DateCreate { get; set; }
        [DisplayName("Дата выполнения")]
        public DateTime? DateImplement { get; set; }
    }
}
