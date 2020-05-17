using System;
using System.Collections.Generic;

using System.ComponentModel;
namespace HospitalBusinessLogic.ViewModels
{
    public class ProfessionViewModel
    {
        public int Id { get; set; }
        [DisplayName("Название специальности врача")]
        public string ProfessionName { get; set; }

    }
}
