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
    public class Hour : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int? timeEpoch;
        private string time;
        private double? tempC;
        private double? tempF;
        private int? isDay;
        private Models.Condition condition;
        private double? windMph;
        private double? windKph;
        private int? windDegree;
        private string windDir;
        private double? pressureMb;
        private double? pressureIn;
        private double? precipMm;
        private double? precipIn;
        private int? humidity;
        private int? cloud;
        private double? feelslikeC;
        private double? feelslikeF;
        private double? visKm;
        private double? visMiles;
        private double? uv;
        private double? gustMph;
        private double? gustKph;

        /// <summary>
        /// Time as epoch
        /// </summary>
        [JsonProperty("time_epoch")]
        public int? TimeEpoch 
        { 
            get 
            {
                return this.timeEpoch; 
            } 
            set 
            {
                this.timeEpoch = value;
                onPropertyChanged("TimeEpoch");
            }
        }

        /// <summary>
        /// Date and time
        /// </summary>
        [JsonProperty("time")]
        public string Time 
        { 
            get 
            {
                return this.time; 
            } 
            set 
            {
                this.time = value;
                onPropertyChanged("Time");
            }
        }

        /// <summary>
        /// Temperature in celsius
        /// </summary>
        [JsonProperty("temp_c")]
        public double? TempC 
        { 
            get 
            {
                return this.tempC; 
            } 
            set 
            {
                this.tempC = value;
                onPropertyChanged("TempC");
            }
        }

        /// <summary>
        /// Temperature in fahrenheit
        /// </summary>
        [JsonProperty("temp_f")]
        public double? TempF 
        { 
            get 
            {
                return this.tempF; 
            } 
            set 
            {
                this.tempF = value;
                onPropertyChanged("TempF");
            }
        }

        /// <summary>
        /// 1 = Yes 0 = No <br />Whether to show day condition icon or night icon
        /// </summary>
        [JsonProperty("is_day")]
        public int? IsDay 
        { 
            get 
            {
                return this.isDay; 
            } 
            set 
            {
                this.isDay = value;
                onPropertyChanged("IsDay");
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
        /// Wind speed in miles per hour
        /// </summary>
        [JsonProperty("wind_mph")]
        public double? WindMph 
        { 
            get 
            {
                return this.windMph; 
            } 
            set 
            {
                this.windMph = value;
                onPropertyChanged("WindMph");
            }
        }

        /// <summary>
        /// Wind speed in kilometer per hour
        /// </summary>
        [JsonProperty("wind_kph")]
        public double? WindKph 
        { 
            get 
            {
                return this.windKph; 
            } 
            set 
            {
                this.windKph = value;
                onPropertyChanged("WindKph");
            }
        }

        /// <summary>
        /// Wind direction in degrees
        /// </summary>
        [JsonProperty("wind_degree")]
        public int? WindDegree 
        { 
            get 
            {
                return this.windDegree; 
            } 
            set 
            {
                this.windDegree = value;
                onPropertyChanged("WindDegree");
            }
        }

        /// <summary>
        /// Wind direction as 16 point compass. e.g.: NSW
        /// </summary>
        [JsonProperty("wind_dir")]
        public string WindDir 
        { 
            get 
            {
                return this.windDir; 
            } 
            set 
            {
                this.windDir = value;
                onPropertyChanged("WindDir");
            }
        }

        /// <summary>
        /// Pressure in millibars
        /// </summary>
        [JsonProperty("pressure_mb")]
        public double? PressureMb 
        { 
            get 
            {
                return this.pressureMb; 
            } 
            set 
            {
                this.pressureMb = value;
                onPropertyChanged("PressureMb");
            }
        }

        /// <summary>
        /// Pressure in inches
        /// </summary>
        [JsonProperty("pressure_in")]
        public double? PressureIn 
        { 
            get 
            {
                return this.pressureIn; 
            } 
            set 
            {
                this.pressureIn = value;
                onPropertyChanged("PressureIn");
            }
        }

        /// <summary>
        /// Precipitation amount in millimeters
        /// </summary>
        [JsonProperty("precip_mm")]
        public double? PrecipMm 
        { 
            get 
            {
                return this.precipMm; 
            } 
            set 
            {
                this.precipMm = value;
                onPropertyChanged("PrecipMm");
            }
        }

        /// <summary>
        /// Precipitation amount in inches
        /// </summary>
        [JsonProperty("precip_in")]
        public double? PrecipIn 
        { 
            get 
            {
                return this.precipIn; 
            } 
            set 
            {
                this.precipIn = value;
                onPropertyChanged("PrecipIn");
            }
        }

        /// <summary>
        /// Humidity as percentage
        /// </summary>
        [JsonProperty("humidity")]
        public int? Humidity 
        { 
            get 
            {
                return this.humidity; 
            } 
            set 
            {
                this.humidity = value;
                onPropertyChanged("Humidity");
            }
        }

        /// <summary>
        /// Cloud cover as percentage
        /// </summary>
        [JsonProperty("cloud")]
        public int? Cloud 
        { 
            get 
            {
                return this.cloud; 
            } 
            set 
            {
                this.cloud = value;
                onPropertyChanged("Cloud");
            }
        }

        /// <summary>
        /// Feels like temperature as celcius
        /// </summary>
        [JsonProperty("feelslike_c")]
        public double? FeelslikeC 
        { 
            get 
            {
                return this.feelslikeC; 
            } 
            set 
            {
                this.feelslikeC = value;
                onPropertyChanged("FeelslikeC");
            }
        }

        /// <summary>
        /// Feels like temperature as fahrenheit
        /// </summary>
        [JsonProperty("feelslike_f")]
        public double? FeelslikeF 
        { 
            get 
            {
                return this.feelslikeF; 
            } 
            set 
            {
                this.feelslikeF = value;
                onPropertyChanged("FeelslikeF");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("vis_km")]
        public double? VisKm 
        { 
            get 
            {
                return this.visKm; 
            } 
            set 
            {
                this.visKm = value;
                onPropertyChanged("VisKm");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("vis_miles")]
        public double? VisMiles 
        { 
            get 
            {
                return this.visMiles; 
            } 
            set 
            {
                this.visMiles = value;
                onPropertyChanged("VisMiles");
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

        /// <summary>
        /// Wind gust in miles per hour
        /// </summary>
        [JsonProperty("gust_mph")]
        public double? GustMph 
        { 
            get 
            {
                return this.gustMph; 
            } 
            set 
            {
                this.gustMph = value;
                onPropertyChanged("GustMph");
            }
        }

        /// <summary>
        /// Wind gust in kilometer per hour
        /// </summary>
        [JsonProperty("gust_kph")]
        public double? GustKph 
        { 
            get 
            {
                return this.gustKph; 
            } 
            set 
            {
                this.gustKph = value;
                onPropertyChanged("GustKph");
            }
        }
    }
} 