using System;
using System.Collections.Generic;
using DataAccessLayer;

namespace bussinessLayer
{
    public class clsCountry
    {
        public int CountryID  { get; set; }
        public string CountryName { get; set; }
        public static List<string> getAllCountries()
        {
            return clsCountryTable.GetAllCountries();

        }
    }
}
