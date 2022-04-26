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
    public class Forecast1 : BaseModel 
    {
        // These fields hold the values for the public properties.
        private List<Models.Forecastday1> forecastday;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("forecastday")]
        public List<Models.Forecastday1> Forecastday 
        { 
            get 
            {
                return this.forecastday; 
            } 
            set 
            {
                this.forecastday = value;
                onPropertyChanged("Forecastday");
            }
        }
    }
} 