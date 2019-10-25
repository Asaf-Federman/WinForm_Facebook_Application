using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine
{
    public class Place
    {
        public string CountryName
        {
            get;
            set;
        }

        public string CityName
        {
            get;
            set;
        }

        public string FullPlaceName
        {
            get;
            set;
        }

        public List<PlaceRelatedInfo> PlaceRelatedInformationList
        {
            get;
        }

        public Place(string i_CountryName, string i_CityName)
        {
            CountryName = i_CountryName;
            CityName = i_CityName;
            FullPlaceName = placeToString();
            PlaceRelatedInformationList = new List<PlaceRelatedInfo>();
        }

        public static string PlaceToString(string i_CountryName, string i_CityName)
        {
            return string.Format("{0},{1}", i_CountryName, i_CityName);
        }

        public void AddRelatedInformation(PlaceRelatedInfo i_PlaceInformation)
        {
            PlaceRelatedInformationList.Add(i_PlaceInformation);
        }

        private string placeToString()
        {
            return string.Format("{0},{1}", CountryName, CityName);
        }
    }
}
