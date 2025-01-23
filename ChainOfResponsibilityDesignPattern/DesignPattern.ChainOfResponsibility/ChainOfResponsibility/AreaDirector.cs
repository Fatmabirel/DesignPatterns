using DesignPattern.ChainOfResponsibility.DataAccessLayer;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class AreaDirector : Employee
    {       
        public override void ProcessRequest(CustomerProcessViewModel request)
        {
            Context context = new Context();
            if (request.Amount <= 400000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.Description = "Bölge Müdürü - Zeynep Yankı";
                customerProcess.EmployeeName = "Para çekme işlemi onaylandı. Müşteriye talep ettiği tutar ödendi";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.Description = "Bölge Müdürü - Zeynep Yankı";
                customerProcess.EmployeeName = "Para çekme tutarı bölge müdürünün günlük ödeyeceği limiti aştığı için işlem gerçekleştirilemedi. Müşterinin günlük maksimum çekebileceği tutar 400.000₺'dir. Daha fazlası için birden fazla gün şubeye gelmesi gerekli...";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
        }
    }
}
