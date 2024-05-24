using Day1SignalIR.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.SignalR;

namespace Day1SignalIR.Hubs
{
    public class EmpHub : Hub
    {
        EmpContext db;
        public EmpHub(EmpContext db)
        {
           this. db = db;
        }
        public void sendEmp(Table_1 emp)
        {
            db.Table_1s.Add(emp);
            db.SaveChanges();
            Clients.All.SendAsync("newEmp", emp);
           
        }
    }
}
