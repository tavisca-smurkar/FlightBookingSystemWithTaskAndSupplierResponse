using FlightIISServices.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightIISServices.SupplierData
{
   public interface ISupplier
    {
       List<Flight> GetFlightList(string source, string destination);
    }
}
