using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Collections;

namespace AwayDay3
{

    class EntityDBAccessor : DBAccessor
    {
        //Used to update the customers detail, pass in a fully updated customer object and the old one will be replaced.
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

        //Generic method used to add objects of any type to the database.
        public void addObject<T>(T toAdd)
        {
            using (var context = new MyDBEntities())
            {
                object input = (object)toAdd;
                if (typeof(T) == typeof(Company))
                    context.Companys.Add((Company)input);
                else if (typeof(T) == typeof(Department))
                    context.Departments.Add((Department)input);
                else if (typeof(T) == typeof(CommunicationRecord))
                    context.Communications.Add((CommunicationRecord)input);
                else if (typeof(T) == typeof(Request))
                    context.Requests.Add((Request)input);
                else if (typeof(T) == typeof(Activity))
                    context.Activities.Add((Activity)input);
                context.SaveChanges();
            }
        }

        //Using the company name retreive the company entity from the database
        public Company GetCompany(String companyName)
        {
            Company companyFound = new Company();
            using (var context = new MyDBEntities())
            {
                List<Company> companys = context.Companys.ToList<Company>();
                foreach (Company comp in companys)
                {

                    if (comp.CompanyName == companyName)
                    {
                        companyFound = comp;
                    }
                }
            }
            return companyFound;
        }
        //Generic method used to get a List of a specific type from the database.
        public IList getObjects<T>(T input)
        {
            using (var context = new MyDBEntities())
            {
                if (typeof(T) == typeof(Company))
                    return context.Companys.ToList<Company>();
                else if (typeof(T) == typeof(Department))
                    return context.Departments.ToList<Department>();
                else if (typeof(T) == typeof(CommunicationRecord))
                    return context.Communications.ToList<CommunicationRecord>();
                else if (typeof(T) == typeof(Request))
                    return context.Requests.ToList<Request>();
                else if (typeof(T) == typeof(Activity))
                    return context.Activities.ToList<Activity>();
                else
                    return null;
            }
        }

        //Used to get all communication records tied to a specific customer.
        public List<CommunicationRecord> getCommunications(string companyName)
        {
            using (var context = new MyDBEntities())
            {
                return context.Communications.Where(x => x.companyName == companyName).ToList<CommunicationRecord>();
            }
        }

        //Check to see if a specific activity has been booked on a certain day.
        public bool checkForBookedActivity(string key, DateTime date1)
        {
            using (var context = new MyDBEntities())
            {
                var eventFound = context.Activities.SingleOrDefault(b => b.activity == key && b.date.Day == date1.Day);
                if (eventFound != null)
                    return true;
                else
                    return false;
            }
        }

        //Weeds messages when ran according to a number of criteria.
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

        //Class used to communicate with the database.
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
            public DbSet<Activity> Activities { get; set; }


            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
            }

        }
    }
}