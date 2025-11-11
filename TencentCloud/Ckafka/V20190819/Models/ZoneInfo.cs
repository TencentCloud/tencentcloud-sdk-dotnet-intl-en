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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ZoneInfo : AbstractModel
    {
        
        /// <summary>
        /// Availability zone
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Whether it is an internal application.
        /// </summary>
        [JsonProperty("IsInternalApp")]
        public long? IsInternalApp{ get; set; }

        /// <summary>
        /// Application identifier
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// Indicates whether the AZ is sold out. true indicates sold out. false indicates not sold out.
        /// </summary>
        [JsonProperty("Flag")]
        public bool? Flag{ get; set; }

        /// <summary>
        /// Availability zone name.
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// Availability zone status. enumerates example: 3: enable, 4: disable. availability zone status is subject to SoldOut.
        /// </summary>
        [JsonProperty("ZoneStatus")]
        public long? ZoneStatus{ get; set; }

        /// <summary>
        /// Extra flag
        /// </summary>
        [JsonProperty("Exflag")]
        [System.Obsolete]
        public string Exflag{ get; set; }

        /// <summary>
        /// Specifies whether the item is sold-out. valid values: true (sold-out), false (not sold out).
        /// </summary>
        [JsonProperty("SoldOut")]
        public string SoldOut{ get; set; }

        /// <summary>
        /// Specifies the sell-out information of the standard version.
        /// </summary>
        [JsonProperty("SalesInfo")]
        public SaleInfo[] SalesInfo{ get; set; }

        /// <summary>
        /// Additional flag.
        /// </summary>
        [JsonProperty("ExtraFlag")]
        public string ExtraFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "IsInternalApp", this.IsInternalApp);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Flag", this.Flag);
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamSimple(map, prefix + "ZoneStatus", this.ZoneStatus);
            this.SetParamSimple(map, prefix + "Exflag", this.Exflag);
            this.SetParamSimple(map, prefix + "SoldOut", this.SoldOut);
            this.SetParamArrayObj(map, prefix + "SalesInfo.", this.SalesInfo);
            this.SetParamSimple(map, prefix + "ExtraFlag", this.ExtraFlag);
        }
    }
}

