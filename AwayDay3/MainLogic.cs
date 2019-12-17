using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwayDay3
{
    public class MainLogic
    {
        public Company loggedInCompany = new Company();
        public Department loggedInDepartment = new Department();
        private EntityDBAccessor database = new EntityDBAccessor();


        public MainLogic()
        {
        }

        public void UpdateCompany(String emailAddress)
        {
            database.UpdateCustomer(loggedInCompany);
        }

        public String Register(String fName, String lName, String companyName, String departmentName, String companyEmail, 
                                String address, String city, String postCode, String phoneNumber)
        {
            //See if company is already registered
            List<Company> companys = database.GetCompanys();
            bool companyFound = false;
            foreach(Company comp in companys)
            {
                if (comp.CompanyName == companyName)
                    companyFound = true;
            }

            //See if department is already registered
            List<Department> depts = database.GetDepartments();
            bool departmentFound = false;
            foreach(Department dept in depts)
            {
                if (dept.DepartmentName == companyName + " - " + departmentName)
                    departmentFound = true;
            }

            //If company nor department exist, create new c & d
            if (departmentFound == false && companyFound == false)
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

                database.AddCustomer(a,d);
                logIn(companyName, departmentName);
                database.addCommunication(0, loggedInCompany.CompanyName, loggedInDepartment.DepartmentName,
                false, 0, DateTime.Now, "Company and Department registered");
                return "Company and department registered";
            }

            //If company departmentFound but department doesnt
           else if (departmentFound == false && companyFound == true)
            {
                database.AddDepartment(companyName, departmentName);
                logIn(companyName, departmentName);
                database.addCommunication(0, loggedInCompany.CompanyName, loggedInDepartment.DepartmentName,
                false, 0, DateTime.Now, "Department registered");
                return "New department registered to existing company";
            }
            //if both exist
            else
            {
                logIn(companyName, departmentName);
                return "Company already registered, logged in";
            }
        }

        public string submitRequest(int numOfGuests,DateTime date1, DateTime date2, DateTime date3, List<KeyValuePair<string, bool>> activitys)
        {
            //GO THROUGH ACTIVITYS, IF CONTAINS FACILITATED, CHECK IF ANY OTHER ARE CURRENTLY EXISTING
            Request r = new Request();
            r.numberOfGuests = numOfGuests;
            r.departmentName = loggedInDepartment.DepartmentName;
            r.Date = date1;
            database.AddRequest(r);

            return "event succesfully created, inform client they will \n be contacted with a pdf once pricing has been finalised";

        }

        public string getCustomerCommunications()
        {
            List<CommunicationRecord> comms = database.getCommunications(loggedInCompany.CompanyName);
            String allMessages = "";
            foreach(CommunicationRecord comm in comms)
            {
                allMessages = allMessages + comm.companyName + " - " + comm.departmentName + " - " + comm.messageText + comm.timeCreated + "\n";
            }
            return allMessages;

        }

        public String logIn(String companyName, String departmentName)
        {
            List<Department> depts = database.GetDepartments();
            String departmentFound = "Failed to log in, company does not exist";
            foreach (Department dept in depts)
            {
                if (dept.DepartmentName == companyName + " - " + departmentName)
                {
                    departmentFound = "Company logged in ";
                    loggedInDepartment = dept;
                    loggedInCompany = database.GetCompany(companyName);
                }
            }
            return departmentFound;
        }
    }


}
