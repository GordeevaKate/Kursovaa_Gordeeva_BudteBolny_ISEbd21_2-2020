using System.Collections.Generic;
using HospitalBusinessLogic.BindingModels;
using HospitalBusinessLogic.ViewModels;

namespace HospitalBusinessLogic.Interfaces
{
    public interface IProfessionLogic
    {
        List<ProfessionViewModel> Read(ProfessionBindingModel model);
        void CreateOrUpdate(ProfessionBindingModel model);
        void Delete(ProfessionBindingModel model);

    }
}
