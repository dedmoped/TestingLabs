using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.model;
using GitHubAutomation.Services;

namespace Framework.Services
{
    class CreateWay
    {
        public static Way GetTestStationInfo()
        {
            return new Way(TestDataReader.GetData("DepartureCity"), TestDataReader.GetData("ArrivalCity"), TestDataReader.GetData("Departure_date"));
        }

        public static Way GetPeopleNumberInfo()
        {
            return new Way(TestNumberofPeople.GetData("DepartureCity"), TestNumberofPeople.GetData("ArrivalCity"), TestNumberofPeople.GetData("Departure_date"));
        }
    }
}
