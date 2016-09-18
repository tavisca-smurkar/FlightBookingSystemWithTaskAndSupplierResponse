using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FlightIISServices;
using FlightIISServices.Entity;

namespace FlightIIsServiceTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForGettingListFromSabreFlightList()
        {
            FlightIISServices.FlightServices.FlightService flightService = new FlightIISServices.FlightServices.FlightService();
            Result First = flightService.GetFlightsBySourceDestinationTravellersAndClass("MAA", "BOM", "2", "Economy");
            Assert.IsTrue(First.Status);
        }


        [TestMethod]
        public void TestForGettingListFromWorldSpanFlightList()
        {
            FlightIISServices.FlightServices.FlightService flightService = new FlightIISServices.FlightServices.FlightService();
            Result First = flightService.GetFlightsBySourceDestinationTravellersAndClass("LAS", "LAX", "2", "Economy");
            Assert.IsTrue(First.Status);
        }


        [TestMethod]
        public void TestForGettingListFromMystiflyFlightList()
        {
            FlightIISServices.FlightServices.FlightService flightService = new FlightIISServices.FlightServices.FlightService();
            Result First = flightService.GetFlightsBySourceDestinationTravellersAndClass("KUL", "SIN", "2", "Economy");
            Assert.IsTrue(First.Status);
        }


        [TestMethod]
        public void TestForNoResult()
        {
            FlightIISServices.FlightServices.FlightService flightService = new FlightIISServices.FlightServices.FlightService();
            Result First = flightService.GetFlightsBySourceDestinationTravellersAndClass("PUNE", "MUMBAI", "2", "Economy");
            Assert.IsFalse(First.Status);
        }

    }
        
}
