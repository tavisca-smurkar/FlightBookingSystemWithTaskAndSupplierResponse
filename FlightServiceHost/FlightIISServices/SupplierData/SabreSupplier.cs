using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FlightIISServices.Entity;
using System.Xml.Serialization;
using System.IO;
using FlightIISServices.Property;
using System.Threading.Tasks;
using FlightIISServices.FlightListCreaterData;

namespace FlightIISServices.SupplierData
{
    public class SabreSupplier : ISupplier
    {
        public List<Flight> GetFlightList(string source, string destination)
        {

            List<Flight> flightListThree;
            XmlSerializer sabreXmlSerializer = new XmlSerializer(typeof(Envelope));
            StreamReader sabreXmlReader = new StreamReader(DocumentPath.sabreFlightXMLPath);
            Envelope envelopeResult = (Envelope)sabreXmlSerializer.Deserialize(sabreXmlReader);
            flightListThree = FlightListCreater.CreateSabreFlightList(source, destination, envelopeResult);
            return flightListThree;
        }
    }
}