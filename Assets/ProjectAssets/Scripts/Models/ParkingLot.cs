using System;
//using System.ComponentModel.DataAnnotations;
#if UNITY_UWP
using Newtonsoft.Json;
#endif

namespace ParkingLotApi.Models
{
    public enum ParkingState
    {
        Occupied = 0,
        Free = 1,
        Error = 2
    }
    public class ParkingLot
    {
#if UNITY_UWP
        [JsonProperty("id")]
#endif
        public int Id { get; set; }

#if UNITY_UWP
        [JsonProperty("state")]
#endif
        public ParkingState State { get; set; }

#if UNITY_UWP
        [JsonProperty("registration_time")]
#endif
        public DateTime RegistrationTime { get; set; }

#if UNITY_UWP
        [JsonProperty("temperature")]
#endif
        public double Temperature { get; set; }
    }
}