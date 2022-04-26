/*
 * WeatherAPI.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using WeatherAPI.Standard;
using WeatherAPI.Standard.Utilities;


namespace WeatherAPI.Standard.Models
{
    public class HistoryJsonResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Models.Location location;
        private Models.Current current;
        private Models.Forecast1 forecast;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("location")]
        public Models.Location Location 
        { 
            get 
            {
                return this.location; 
            } 
            set 
            {
                this.location = value;
                onPropertyChanged("Location");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("current")]
        public Models.Current Current 
        { 
            get 
            {
                return this.current; 
            } 
            set 
            {
                this.current = value;
                onPropertyChanged("Current");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("forecast")]
        public Models.Forecast1 Forecast 
        { 
            get 
            {
                return this.forecast; 
            } 
            set 
            {
                this.forecast = value;
                onPropertyChanged("Forecast");
            }
        }
    }
} 