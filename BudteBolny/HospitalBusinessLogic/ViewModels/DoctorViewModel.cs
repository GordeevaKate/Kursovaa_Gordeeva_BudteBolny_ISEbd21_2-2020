using System.Collections.Generic;
using System.ComponentModel;

namespace HospitalBusinessLogic.ViewModels
{
    public class DoctorViewModel
    {
        public int Id { get; set; }
        [DisplayName("Название Профессии")]
        public string ProductName { get; set; }
        [DisplayName("Цена")]
        public decimal Price { get; set; }
        public Dictionary<int, (string, int)> DoctorProfessions { get; set; }
    }
}
