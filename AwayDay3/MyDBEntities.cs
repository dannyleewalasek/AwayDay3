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

        public void AddCustomer(String fName, String lName, String companyName, String departmentName, String companyEmail,
                                String address, String city, String postCode, String phoneNumber)
        {
                using (var context = new MyDBEntities())
                {
                Company a = new Company();
                Department d = new Department();
                a.CompanyName = companyName;
                a.companyEmail = companyEmail;
                a.firstName = fName;
                a.lastName = lName;
                a.address = address;
                a.city = city;
                a.postCode = postCode;
                a.phone = phoneNumber;
                d.DepartmentName = companyName + " - " + departmentName;
                d.companyName = companyName;
                d.company = a;
                context.Companys.Add(a);
                context.Departments.Add(d);
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

        public void AddRequest()
        {

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
      //  public DbSet<CommunicationRecord> Communications { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }   
}