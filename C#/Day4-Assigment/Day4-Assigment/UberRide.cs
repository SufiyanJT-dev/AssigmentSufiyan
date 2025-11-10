using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Assigment
{
    public class UberRide
    {
        public static int totalRides;
        public static double totalEarnings;
        public static double basefare = 50;
        public static double surgeMultiplier = 1.0;
         static UberRide()
        {
           
            
        }
        public string RideId {  get; set; }
        public string DriverName{ get; set; }
        public string PassengerName { get; set; }
        public double DistanceKm { get; set; }

        public double Fare {  get; set; }
        public UberRide()
        {
            totalRides++;
            RideId = "Ride_" + (1000 + totalRides);
            
            

        }
        public   void UberDetails(string passengerName, string driverName, double distanceKm)
        {
            DriverName = driverName;
            PassengerName = passengerName;
            DistanceKm = distanceKm;

            Fare = CalcFare(distanceKm);
            totalEarnings = totalEarnings + Fare;
        }
        private double CalcFare(double distanceKm)
        {
            return (basefare + (distanceKm * 15 * surgeMultiplier));
        }
        public static void SetSurgeMultiplier(double multiplier)
        {
            if (surgeMultiplier > 1.0)
            {
                surgeMultiplier = multiplier;
            }
            else
            {
                surgeMultiplier= 1.0;
            }

        }
        public static void ShowRideSummary()
        {
            Console.WriteLine("Your Ride Summary your total ride:" + totalRides + "\n your total Earnings: "+totalEarnings);
        }
        public  void ShowRideDetails()
        {
            Console.WriteLine("Driver Id:" + this.RideId + "\nDriver:"+this.DriverName+"\npassenger: "+this.PassengerName+"\nDistance: "+this.DistanceKm+"\nfare :"+Fare);

        }
    }
}
