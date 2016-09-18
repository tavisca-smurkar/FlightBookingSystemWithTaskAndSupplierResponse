using FlightIISServices.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlightIISServices.SupplierData
{
    public class Supplier
    {
        public static List<Flight> CreateMyStiflyFlightList(string source, string destination, OTA_AirLowFareSearchRS ota_AirLowFareSearchResult)
        {
            List<Flight> flightList = new List<Flight>();
            List<string> flightId = new List<string>();
            foreach (var flightDetails in ota_AirLowFareSearchResult.PricedItineraries)
            {
                var flightInfo = flightDetails.AirItineraryInfo.OriginDestinationOptions[0].FlightSegment;
                var flightPricingInfo = flightDetails.AirItineraryPricingInfo.PTC_FareBreakdowns[0].PassengerFare.TotalFare;
                if (flightInfo.DepartureAirport.LocationCode.Equals(source) && flightInfo.ArrivalAirport.LocationCode.Equals(destination))
                {
                    Flight mystiflyFlight = new Flight();
                    mystiflyFlight.FlightId = flightInfo.FlightNumber.ToString();
                    mystiflyFlight.AirlineName = flightInfo.OperatingAirline.Code;
                    mystiflyFlight.Source = flightInfo.DepartureAirport.LocationCode;
                    mystiflyFlight.Destination = flightInfo.ArrivalAirport.LocationCode;
                    mystiflyFlight.Price = Convert.ToInt32(flightDetails.AirItineraryPricingInfo.PTC_FareBreakdowns[0].PassengerFare.TotalFare.Amount) * 70;
                    mystiflyFlight.ArrivalTime = flightInfo.ArrivalDateTime.TimeOfDay.ToString();
                    mystiflyFlight.DepartureTime = flightInfo.DepartureDateTime.TimeOfDay.ToString();



                    if (!flightId.Contains(mystiflyFlight.FlightId))
                    {
                        flightId.Add(mystiflyFlight.FlightId);
                        flightList.Add(mystiflyFlight);
                    }


                    if (!flightList.Contains(mystiflyFlight))
                    {
                        
                    }
                }
            }

            return flightList.Distinct().ToList();
        }
        
        public static List<Flight> CreateWorldSpanFlightList(string source, string destination, PSW5 PSW5Result)
        {
            List<Flight> flightListTwo = new List<Flight>();
            List<string> flightId = new List<string>();
            foreach (var flight in PSW5Result.ALT_INF)
            {
                var flightInfo = flight.FLI_INF[0];
                if (flightInfo.DEP_ARP.Equals(source) && flightInfo.ARR_ARP.Equals(destination))
                {
                    Flight worldspanFlight = new Flight();
                    worldspanFlight.FlightId = flightInfo.FLI_NUM.ToString();
                    worldspanFlight.AirlineName = flightInfo.ARL_COD;
                    worldspanFlight.Source = flightInfo.DEP_ARP;
                    worldspanFlight.Destination = flightInfo.ARR_ARP;

                    int arrivalTime = Convert.ToInt32(flightInfo.ARR_TIM.ToString());
                    worldspanFlight.ArrivalTime = arrivalTime / 100 + ":" + arrivalTime % 100;

                    int departureTime = Convert.ToInt32(flightInfo.DEP_TIM.ToString());
                    worldspanFlight.DepartureTime = departureTime / 100 + ":" + departureTime % 100;
                    worldspanFlight.Price = Convert.ToInt32(flight.TTL_FAR) * 70;


                    if (!flightId.Contains(worldspanFlight.FlightId))
                    {
                        flightId.Add(worldspanFlight.FlightId);
                        flightListTwo.Add(worldspanFlight);
                    }
                    
                }
            }

            return flightListTwo.Distinct().ToList();
        }



        public static List<Flight> CreateSabreFlightList(string source, string destination, Envelope envelopeResult)
        {
            List<Flight> flightListThree = new List<Flight>();
            List<string> flightId = new List<string>();
            foreach (var flight in envelopeResult.Body.OTA_AirLowFareSearchRSS.PricedItineraries)
            {
                var flightInfo = flight.AirItinerary.OriginDestinationOptions.OriginDestinationOption.FlightSegment[0];
                if (flightInfo.DepartureAirport.LocationCode.Equals(source) && flightInfo.ArrivalAirport.LocationCode.Equals(destination))
                {
                    Flight sabreFlight = new Flight();
                    sabreFlight.FlightId = flightInfo.FlightNumber.ToString();
                    sabreFlight.AirlineName = flightInfo.OperatingAirline.Code;
                    sabreFlight.Source = flightInfo.DepartureAirport.LocationCode;
                    sabreFlight.Destination = flightInfo.ArrivalAirport.LocationCode;
                    sabreFlight.ArrivalTime = flightInfo.ArrivalDateTime.TimeOfDay.ToString();
                    sabreFlight.DepartureTime = flightInfo.DepartureDateTime.TimeOfDay.ToString();
                    sabreFlight.Price = (int)(flight.AirItineraryPricingInfo.ItinTotalFare.TotalFare.Amount) * 70;

                    if (!flightId.Contains(sabreFlight.FlightId))
                    {
                        flightId.Add(sabreFlight.FlightId);
                        flightListThree.Add(sabreFlight);
                    }
                }
            }
            return flightListThree.Distinct().ToList();
        }
    }
}