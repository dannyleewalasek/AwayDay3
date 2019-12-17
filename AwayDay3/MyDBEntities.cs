using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;


namespace AwayDay3
{

    class EntityDBAccessor
    {
        public void UpdateCustomer(Company updatedCompany)
        {
            using (var context = new MyDBEntities())
            {
                var companyFound = context.Companys.SingleOrDefault(b => b.CompanyName == updatedCompany.CompanyName);
                if (companyFound != null)
                {
                    companyFound.companyEmail = updatedCompany.companyEmail;
                    context.SaveChanges();
                }
            }
        }

        public void AddCustomer(Company company, Department department)
        {
                using (var context = new MyDBEntities())
                {
                context.Companys.Add(company);
                context.Departments.Add(department);
                context.SaveChanges();
                }
        }
        
        public Company GetCompany(String companyName)
        {
            Company companyFound = new Company();
            using (var context = new MyDBEntities())
            {
                List<Company> companys = context.Companys.ToList<Company>();
                foreach(Company comp in companys)
                {

                    if (comp.CompanyName == companyName)
                    {
                        companyFound = comp;
                    }
                }
            }
            return companyFound;
        }

        public void AddDepartment(String companyName, String departmentName)
        {
            using (var context = new MyDBEntities())
            {
                Department d = new Department();
                d.DepartmentName = companyName + " - " + departmentName;
                d.companyName = companyName;
                context.Departments.Add(d);
                context.SaveChanges();
            }
        }
        
        public void addCommunication(CommunicationRecord.messageType commType, string cName, string dName, bool disagreement,
                    int requestID, DateTime time, string messageText)
        {
            using (var context = new MyDBEntities())
            {
                CommunicationRecord comm = new CommunicationRecord();
                comm.communcationType = commType;
                comm.companyName = cName;
                comm.departmentName = dName;
                comm.disagreementFlagged = disagreement;
                comm.requestID = requestID;
                comm.timeCreated = time;
                comm.messageText = messageText;

                context.Communications.Add(comm);
                context.SaveChanges();
            }
        }
        
        public List<Department> GetDepartments()
        {
            using (var context = new MyDBEntities())
            {
                return context.Departments.ToList<Department>();
            }
        }

        public List<Company> GetCompanys()
        {
            using (var context = new MyDBEntities())
            {
                return context.Companys.ToList<Company>();
            }
        }

        public List<Request> GetRequests()
        {
            using (var context = new MyDBEntities())
            {
                return context.Requests.ToList<Request>();
            }
        }

        public List<CommunicationRecord> getCommunications(string companyName)
        {
            using (var context = new MyDBEntities())
            {
                return context.Communications.Where(x => x.companyName == companyName).ToList<CommunicationRecord>();
            }
        }

        public void AddRequest(Request request)
        {
            using (var context = new MyDBEntities())
            {
                context.Requests.Add(request);
                context.SaveChanges();
            }
        }

        public void weedMessages()
        {
            using (var context = new MyDBEntities())
            {
               // List<CommunicationRecord> communications = context.Communications.ToList<CommunicationRecord>();
               // foreach(CommunicationRecord comm in communications)
                {
                    ////Just need to reqrite this if statement.
                  //   if (comm.disagreementFlagged && comm.timeCreated > 5 years ago  ) || (!comm.disagreementFlagged && comm.timeCreated > 1 year ago)
              //      context.Communications.Remove(comm);
                }
                context.SaveChanges();
            }
        }

    }

    class MyDBEntities : DbContext
    {
        public MyDBEntities()
            : base("name=conString")
        {

            //  Database.SetInitializer(new MigrateDatabaseToLatestVersion<MyDBEntities);
        }

        public DbSet<Company> Companys { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<CommunicationRecord> Communications { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }   
}