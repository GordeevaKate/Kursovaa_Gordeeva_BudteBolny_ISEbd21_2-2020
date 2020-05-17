using System.Collections.Generic;
using HospitalBusinessLogic.BindingModels;
using HospitalBusinessLogic.ViewModels;

namespace HospitalBusinessLogic.Interfaces
{
    public interface IDoctorLogic
    {
        List<DoctorViewModel> Read(DoctorBindingModel model);
        void CreateOrUpdate(DoctorBindingModel model);
        void Delete(DoctorBindingModel model);
    }
}
