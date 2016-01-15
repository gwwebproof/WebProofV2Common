﻿using System;
using System.Collections.Generic;
using System.Text;
using IntercomIoRest.Model;
using Newtonsoft.Json;

namespace Segment.Model
{
    public class Track : BaseAction
    {
        [JsonProperty(PropertyName = "event")]
        private string EventName { get; set; }

        [JsonProperty(PropertyName = "properties")]
        private Properties Properties { get; set; }

        internal Track(string userId, 
		               string eventName,
            		   Properties properties, 
					   Options options)

			: base("track", userId, options)
        {
            this.EventName = eventName;
            this.Properties = properties ?? new Properties();
        }
    }
}
