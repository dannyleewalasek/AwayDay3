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
            List<Company> companys = (List<Company>)database.getObjects(new Company());
            bool companyFound = false;
            foreach(Company comp in companys)
            {
                if (comp.CompanyName == companyName)
                    companyFound = true;
            }

            //See if department is already registered
            List<Department> depts = (List<Department>)database.getObjects(new Department());
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
            string[] facilitatedActivities = { "chocolate", "climbing", "gocart", "meditation" };
            //GO THROUGH ACTIVITYS, IF CONTAINS FACILITATED, CHECK IF ANY OTHER ARE CURRENTLY EXISTING
            bool foundFlag = false;
            foreach (KeyValuePair<string,bool> act in activitys)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (act.Key == facilitatedActivities[i])
                    {
                        if (database.checkForBookedActivity(act.Key, date1));
                            foundFlag = true;
                    }
                }
            }
            if (foundFlag == true)
                return "one of your requested activities is already booked on this date";
            else
            {

                Request r = new Request();
                r.numberOfGuests = numOfGuests;
                r.departmentName = loggedInDepartment.DepartmentName;
                r.Date = date1;
                database.AddRequest(r);
                foreach (KeyValuePair<string, bool> act in activitys)
                {
                    Activity activity = new Activity();
                    activity.activity = act.Key;
                    activity.priceRequested = act.Value;
                    activity.date = date1;
                    activity.requestID = r.RequestID;
                    database.addActivity(activity);
                }
                return "event succesfully created, inform client they will \n be contacted with a pdf once pricing has been finalised";
            }
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
            List<Department> depts = (List<Department>)database.getObjects(new Department());
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
