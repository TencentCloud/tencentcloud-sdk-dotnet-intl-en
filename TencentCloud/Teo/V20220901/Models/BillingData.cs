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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BillingData : AbstractModel
    {
        
        /// <summary>
        /// Specifies the data timestamp.
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// Value.
        /// </summary>
        [JsonProperty("Value")]
        public ulong? Value{ get; set; }

        /// <summary>
        /// Site ID of the associated data point. if the content identifier feature is enabled, this item is the content identifier.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Specifies the domain name of the data point.
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }

        /// <summary>
        /// Specifies the layer-4 proxy instance ID the data point belongs to.
        /// </summary>
        [JsonProperty("ProxyId")]
        public string ProxyId{ get; set; }

        /// <summary>
        /// Specifies the billing region ID the data point belongs to. the billing region is determined by the EdgeOne node region where the actual service user client is located. valid values: <li>CH: chinese mainland</li><li>AF: africa</li><li>AS1: asia pacific zone 1</li><li>AS2: asia pacific zone 2</li><li>AS3: asia pacific zone 3</li><li>EU: europe</li><li>MidEast: middle east</li><li>NA: north america</li><li>SA: south america</li>.
        /// </summary>
        [JsonProperty("RegionId")]
        public string RegionId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "Value", this.Value);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "ProxyId", this.ProxyId);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
        }
    }
}

