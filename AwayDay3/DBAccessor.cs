using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwayDay3
{
    interface DBAccessor
    {
        void UpdateCustomer(Company updateCompany);
        void addObject<T>(T toAdd);
        Company GetCompany(String companyName);
        IList getObjects<T>(T input);
        List<CommunicationRecord> getCommunications(string companyName);
        bool checkForBookedActivity(string key, DateTime date1);
        void weedMessages();
    }
}
