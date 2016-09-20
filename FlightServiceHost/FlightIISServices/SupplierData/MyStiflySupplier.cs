using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FlightIISServices.Entity;
using System.Xml.Serialization;
using System.IO;
using FlightIISServices.FlightListCreaterData;
using FlightIISServices.Property;
using System.Threading.Tasks;

namespace FlightIISServices.SupplierData
{
    public class MyStiflySupplier : ISupplier
    {
        public List<Flight> GetFlightList(string source, string destination)
        {

            List<Flight> flightListOne;
            XmlSerializer myStiflyserializer = new XmlSerializer(typeof(OTA_AirLowFareSearchRS));
            StreamReader myStiflyReader = new StreamReader(DocumentPath.mystiflyFlightXMLPath);
            OTA_AirLowFareSearchRS ota_AirLowFareSearchResult = (OTA_AirLowFareSearchRS)myStiflyserializer.Deserialize(myStiflyReader);
            flightListOne = FlightListCreater.CreateMyStiflyFlightList(source, destination, ota_AirLowFareSearchResult); 
            return flightListOne;

        }
    }
}