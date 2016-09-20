using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlightIISServices.Property
{
    public class DocumentPath
    {
        public static string mystiflyFlightXMLPath = System.Web.Hosting.HostingEnvironment.MapPath(@"~/Data/mystifly.xml");
        public static string worldSpanFlightXMLPath = System.Web.Hosting.HostingEnvironment.MapPath(@"~/Data/worldspan.xml");
        public static string sabreFlightXMLPath = System.Web.Hosting.HostingEnvironment.MapPath(@"~/Data/sabre.xml");
        public static string FlightXMLPath = System.Web.Hosting.HostingEnvironment.MapPath(@"~/Data/Flights.xml");
       public static string BookingDetailsXMLPath = System.Web.Hosting.HostingEnvironment.MapPath(@"~/Data/BookingDetails.xml");
       public static string cardDetailsxmlPath = System.Web.Hosting.HostingEnvironment.MapPath(@"~/Data/Cards.xml");
    }
}