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
    public class Day : BaseModel 
    {
        // These fields hold the values for the public properties.
        private double? maxtempC;
        private double? maxtempF;
        private double? mintempC;
        private double? mintempF;
        private double? avgtempC;
        private double? avgtempF;
        private double? maxwindMph;
        private double? maxwindKph;
        private double? totalprecipMm;
        private double? totalprecipIn;
        private double? avgvisKm;
        private double? avgvisMiles;
        private double? avghumidity;
        private Models.Condition condition;
        private double? uv;

        /// <summary>
        /// Maximum temperature in celsius for the day.
        /// </summary>
        [JsonProperty("maxtemp_c")]
        public double? MaxtempC 
        { 
            get 
            {
                return this.maxtempC; 
            } 
            set 
            {
                this.maxtempC = value;
                onPropertyChanged("MaxtempC");
            }
        }

        /// <summary>
        /// Maximum temperature in fahrenheit for the day
        /// </summary>
        [JsonProperty("maxtemp_f")]
        public double? MaxtempF 
        { 
            get 
            {
                return this.maxtempF; 
            } 
            set 
            {
                this.maxtempF = value;
                onPropertyChanged("MaxtempF");
            }
        }

        /// <summary>
        /// Minimum temperature in celsius for the day
        /// </summary>
        [JsonProperty("mintemp_c")]
        public double? MintempC 
        { 
            get 
            {
                return this.mintempC; 
            } 
            set 
            {
                this.mintempC = value;
                onPropertyChanged("MintempC");
            }
        }

        /// <summary>
        /// Minimum temperature in fahrenheit for the day
        /// </summary>
        [JsonProperty("mintemp_f")]
        public double? MintempF 
        { 
            get 
            {
                return this.mintempF; 
            } 
            set 
            {
                this.mintempF = value;
                onPropertyChanged("MintempF");
            }
        }

        /// <summary>
        /// Average temperature in celsius for the day
        /// </summary>
        [JsonProperty("avgtemp_c")]
        public double? AvgtempC 
        { 
            get 
            {
                return this.avgtempC; 
            } 
            set 
            {
                this.avgtempC = value;
                onPropertyChanged("AvgtempC");
            }
        }

        /// <summary>
        /// Average temperature in fahrenheit for the day
        /// </summary>
        [JsonProperty("avgtemp_f")]
        public double? AvgtempF 
        { 
            get 
            {
                return this.avgtempF; 
            } 
            set 
            {
                this.avgtempF = value;
                onPropertyChanged("AvgtempF");
            }
        }

        /// <summary>
        /// Maximum wind speed in miles per hour
        /// </summary>
        [JsonProperty("maxwind_mph")]
        public double? MaxwindMph 
        { 
            get 
            {
                return this.maxwindMph; 
            } 
            set 
            {
                this.maxwindMph = value;
                onPropertyChanged("MaxwindMph");
            }
        }

        /// <summary>
        /// Maximum wind speed in kilometer per hour
        /// </summary>
        [JsonProperty("maxwind_kph")]
        public double? MaxwindKph 
        { 
            get 
            {
                return this.maxwindKph; 
            } 
            set 
            {
                this.maxwindKph = value;
                onPropertyChanged("MaxwindKph");
            }
        }

        /// <summary>
        /// Total precipitation in milimeter
        /// </summary>
        [JsonProperty("totalprecip_mm")]
        public double? TotalprecipMm 
        { 
            get 
            {
                return this.totalprecipMm; 
            } 
            set 
            {
                this.totalprecipMm = value;
                onPropertyChanged("TotalprecipMm");
            }
        }

        /// <summary>
        /// Total precipitation in inches
        /// </summary>
        [JsonProperty("totalprecip_in")]
        public double? TotalprecipIn 
        { 
            get 
            {
                return this.totalprecipIn; 
            } 
            set 
            {
                this.totalprecipIn = value;
                onPropertyChanged("TotalprecipIn");
            }
        }

        /// <summary>
        /// Average visibility in kilometer
        /// </summary>
        [JsonProperty("avgvis_km")]
        public double? AvgvisKm 
        { 
            get 
            {
                return this.avgvisKm; 
            } 
            set 
            {
                this.avgvisKm = value;
                onPropertyChanged("AvgvisKm");
            }
        }

        /// <summary>
        /// Average visibility in miles
        /// </summary>
        [JsonProperty("avgvis_miles")]
        public double? AvgvisMiles 
        { 
            get 
            {
                return this.avgvisMiles; 
            } 
            set 
            {
                this.avgvisMiles = value;
                onPropertyChanged("AvgvisMiles");
            }
        }

        /// <summary>
        /// Average humidity as percentage
        /// </summary>
        [JsonProperty("avghumidity")]
        public double? Avghumidity 
        { 
            get 
            {
                return this.avghumidity; 
            } 
            set 
            {
                this.avghumidity = value;
                onPropertyChanged("Avghumidity");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("condition")]
        public Models.Condition Condition 
        { 
            get 
            {
                return this.condition; 
            } 
            set 
            {
                this.condition = value;
                onPropertyChanged("Condition");
            }
        }

        /// <summary>
        /// UV Index
        /// </summary>
        [JsonProperty("uv")]
        public double? Uv 
        { 
            get 
            {
                return this.uv; 
            } 
            set 
            {
                this.uv = value;
                onPropertyChanged("Uv");
            }
        }
    }
} 