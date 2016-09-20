using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FlightIISServices.Entity;
using FlightIISServices.FlightListCreaterData;
using System.IO;
using System.Xml.Serialization;
using FlightIISServices.Property;
using System.Threading.Tasks;   
namespace FlightIISServices.SupplierData
{
    public class WorldSpanSupplier : ISupplier
    {
        public List<Flight> GetFlightList(string source, string destination)
        {
            List<Flight> flightListTwo;
            XmlSerializer worldSpanXmlSerializer = new XmlSerializer(typeof(PSW5));
            StreamReader worldSpanXmlReader = new StreamReader(DocumentPath.worldSpanFlightXMLPath);
            PSW5 PSW5Result = (PSW5)worldSpanXmlSerializer.Deserialize(worldSpanXmlReader);
            flightListTwo = FlightListCreater.CreateWorldSpanFlightList(source, destination, PSW5Result);
            return flightListTwo;
        }
    }
}