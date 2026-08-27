/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Tokenhub.V20260322.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UsageRankItem : AbstractModel
    {
        
        /// <summary>
        /// Global ranking (starting from 1). In pagination scenarios, this is still the position in the full sorting order, not the serial number within the page.
        /// </summary>
        [JsonProperty("Rank")]
        public long? Rank{ get; set; }

        /// <summary>
        /// Object identifier. The apikey dimension is the APIKey ID; the endpoint dimension is the access point; the model dimension is the model name.
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// Display name of the object. In the apikey dimension, return the APIKey name (deleted APIKeys retain their original names);
        /// Key whose endpoint and model dimensions are equal.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Statistical value within a time period
        /// </summary>
        [JsonProperty("Stats")]
        public UsageStats Stats{ get; set; }

        /// <summary>
        /// List of time series points within a time period
        /// </summary>
        [JsonProperty("Series")]
        public UsageSeries Series{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Rank", this.Rank);
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamObj(map, prefix + "Stats.", this.Stats);
            this.SetParamObj(map, prefix + "Series.", this.Series);
        }
    }
}

