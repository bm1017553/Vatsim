using System;
using System.IO;
using System.Linq;

using VatsimLibrary.VatsimClient;
using VatsimLibrary.VatsimDb;

namespace hw
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"{VatsimDbHepler.DATA_DIR}");

            using(var db = new VatsimDbContext())
            {
                

                // 1. var pilots = db.Pilots.Select(p => p).ToList();

                // var longestLogOn = from pilot in db.Pilots
                //     select new{
                //         max = pilot.TimeLogon.Max()
                //     };

                // if(longestLogOn != null){
                //     Console.WriteLine($"Pilot found: {longestLogOn.Realname}");
                // } else {
                //     Console.WriteLine("Pilot not found");
                // } 

                // 2. var controllers = db.Controllers.Select(p => p).ToList();

                // var longestLogOn4Controllers = from controller in db.Controllers
                //     select new{
                //         max = controller.TimeLogon.Max()
                //     };

                // if(longestLogOn != null){
                //     Console.WriteLine($"Controller found: {longestLogOn4Controllers.Realname}");
                // } else {
                //     Console.WriteLine("Controller not found");
                // }     

                // var flights = db.Flights.Select(x => x).ToList();

                // 3. var airports = from flight in db.Flights
                // group flight by flight.PlannedDepairport into flightGroup
                // select new{
                //     AirportId = flightGroup.Key,
                //     Count = flightGroup.Count()
                // };

                // var query3 = airports.OrderByDescending(a => a.Count);

                // var maxAirport = query3.FirstOrDefault();

                // Console.WriteLine(maxAirport.ToString());

                // 4. var arrAirport = from flight in db.Flights
                // group flight by flight.PlannedDestairport into flightGroup
                // select new{
                //     AirportId = flightGroup.Key,
                //     Count = flightGroup.Count()
                // };

                // var query4 = arrAirport.OrderByDescending(a => a.Count);

                // var maxArrival = query4.FirstOrDefault();

                // Console.WriteLine(maxArrival.ToString());

                // 5. var positions = db.Positions.Select(po => po).ToList();
                // var flights = db.Flights.Select(f => f).ToList();

                // var highestAlt = from position in db.Positions
                // join flight in db.Flights on position.Cid equals flight.Cid
                // select new{
                //     altitude = position.Altitude.Max(),
                //     aircraft = flight.PlannedAircraft
                // };

                // Console.WriteLine(findMax.realName);

                // 7. var flights = db.Flights.Select(x => x).ToList();

                // var promQueenPlane = from flight in flights
                // group flight by flight.PlannedAircraft into planeGroup
                // select new{
                //     aircraftId = planeGroup.Key,
                //     count = planeGroup.Count()
                // };

                // var query7 = promQueenPlane.OrderByDescending(a => a.count);

                // var maxPlane = query7.FirstOrDefault();

                // Console.WriteLine(maxPlane.ToString());

                // Console.WriteLine(highestAlt.Realname);

                // 8. var maxSpeed = from position in db.Positions
                // select new{
                //     speed = position.Groundspeed
                // };

                // var findMax = maxSpeed.Max(a => a.speed);

                // var _pilots = db.Pilots.Select(p => p).ToList();
                // Console.WriteLine($"The number of pilots records is: {_pilots.Count} ");

                // 9. foreach (var flight in db.Flights){
                //     if(flight.Latitude => 90 && flight.Latitude <= 270){
                //         var countFlightNorth = flight.Realname.Count();
                //     }
                // }

                // Console.WriteLine(countFlightNorth.ToString());

                // //1238470                
                // //UAL2865
                // //20201013162413
                // var _pilot = db.Pilots.Find("1238470", "UAL2865", "20201013162413");                
                // if(_pilot != null){
                //     Console.WriteLine($"Pilot found: {_pilot.Realname}");
                // } else {
                //     Console.WriteLine("Pilot not found");
                // }                

                // //1385451
                // //N130JM
                // //20201021233811
                // _pilot = db.Pilots.Find("1385451", "N130JM", "20201021233811");
                // if(_pilot != null){
                //     Console.WriteLine($"Pilot found: {_pilot.Realname}");
                // } else {
                //     Console.WriteLine("Pilot not found");
                // }

                // //1484591
                // //PAL922
                // //20201028132105
                // _pilot = db.Pilots.Find("1484591", "PAL922", "20201028132105");
                // if(_pilot != null){
                //     Console.WriteLine($"Pilot found: {_pilot.Realname}");
                // } else {
                //     Console.WriteLine("Pilot not found");
                // }                
            }            
        }
    }
}
