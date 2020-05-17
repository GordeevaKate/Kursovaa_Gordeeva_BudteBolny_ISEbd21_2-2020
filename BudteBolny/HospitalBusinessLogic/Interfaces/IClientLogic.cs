using System.Collections.Generic;
using HospitalBusinessLogic.BindingModels;
using HospitalBusinessLogic.ViewModels;

namespace HospitalBusinessLogic.Interfaces
{
    public interface IClientLogic
    {
        List<ClientViewModel> Read(ClientBindingModel model);
        void CreateOrUpdate(ClientBindingModel model);
        void Delete(ClientBindingModel model);
    }
}
