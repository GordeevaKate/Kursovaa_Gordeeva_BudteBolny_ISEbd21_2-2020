    using HospitalBusinessLogic.BindingModels;
    using HospitalBusinessLogic.Enums;
    using HospitalBusinessLogic.Interfaces;
    using System;
    namespace HospitalBusinessLogic.BusinessLogics
    {
        public class MainLogic
        {
            private readonly IVisitLogic visitLogic;
        private readonly IClientLogic clientLogic;
        public MainLogic(IVisitLogic visitLogic, IClientLogic clientLogic)
            {
                this.visitLogic = visitLogic;
            this.clientLogic = clientLogic;
        }
            public void CreateVisit(CreateVisitBindingModel model)
            {
            visitLogic.CreateOrUpdate(new VisitBindingModel
                {
                    DoctorId = model.DoctorId,
                    Count = model.Count,
                    Sum = model.Sum,
                    DateCreate = DateTime.Now,
                    Status = VisitStatus.Неоплачен
                });
            }
            public void PayVisit(ChangeStatusVisitaBindingModel model)
            {
                var visit = visitLogic.Read(new VisitBindingModel
                {
                    Id = model.VisitId
                })?[0];
                if (visit == null)
                {
                    throw new Exception("Не найдено посещение");
                }
                if (visit.Status != VisitStatus.Неоплачен)
                {
                    throw new Exception("посещение не в статусе \"Неоплачен\"");
                }
            visitLogic.CreateOrUpdate(new VisitBindingModel
                {
                    Id = visit.Id,
                    DoctorId = visit.DoctorId,
                    Count = visit.Count,
                    Sum = visit.Sum,
                    DateCreate = visit.DateCreate,
                    DateImplement = DateTime.Now,
                    Status = VisitStatus.Оплачен
                });
            }
       public void CheckingForBlockingClients(ChangeStatusClientaBindingModel model)
        {
            var visit = visitLogic.Read(new VisitBindingModel
            {
                Id = model.VisitId
            })?[0];
            var client = clientLogic.Read(new ClientBindingModel
            {
                VisitId = model.VisitId,
                Id = model.ClientId
            })?[0];
            if (client == null)
            {
                throw new Exception("Не найден клиент");
            }
            if ((visit.Status == VisitStatus.Неоплачен) && (visit.DateCreate.AddMonths(6) <= DateTime.Now))
            {
                clientLogic.CreateOrUpdate(new ClientBindingModel
                {
                    Id = client.Id,
                    VisitId=client.Id,
                    Status = ClientStatus.Заблокирован
                });
            }
        }
       
 }
}