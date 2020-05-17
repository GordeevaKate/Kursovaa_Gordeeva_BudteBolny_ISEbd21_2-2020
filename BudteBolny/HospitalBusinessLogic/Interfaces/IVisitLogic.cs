using System.Collections.Generic;
using HospitalBusinessLogic.BindingModels;
using HospitalBusinessLogic.ViewModels;
namespace HospitalBusinessLogic.Interfaces
{
    public interface IVisitLogic
    {
        List<VisitViewModel> Read(VisitBindingModel model);
        void CreateOrUpdate(VisitBindingModel model);
        void Delete(VisitBindingModel model);

    }
}
