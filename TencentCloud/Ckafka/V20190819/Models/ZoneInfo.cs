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
        /// <p>Availability zone</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// <p>Whether the APP is internal</p><p>Enumeration value:</p><ul><li>0: Public</li><li>1: Internal</li></ul><p>Default value: 0</p>
        /// </summary>
        [JsonProperty("IsInternalApp")]
        public long? IsInternalApp{ get; set; }

        /// <summary>
        /// <p>AppID</p>
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// <p>Flag indicating whether the availability zone is sold out. true indicates sold out, false indicates not sold out.</p>
        /// </summary>
        [JsonProperty("Flag")]
        public bool? Flag{ get; set; }

        /// <summary>
        /// <p>Availability zone name</p>
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// <p>Availability zone status</p><p>Enumeration value:</p><ul><li>3: Enable</li><li>4: Disable</li></ul><p>AZ status is subject to SoldOut</p>
        /// </summary>
        [JsonProperty("ZoneStatus")]
        public long? ZoneStatus{ get; set; }

        /// <summary>
        /// <p>Additional flag</p>
        /// </summary>
        [JsonProperty("Exflag")]
        [System.Obsolete]
        public string Exflag{ get; set; }

        /// <summary>
        /// <p>true indicates sold out, false indicates not sold out.</p>
        /// </summary>
        [JsonProperty("SoldOut")]
        public string SoldOut{ get; set; }

        /// <summary>
        /// <p>Standard version sell-out information</p>
        /// </summary>
        [JsonProperty("SalesInfo")]
        public SaleInfo[] SalesInfo{ get; set; }

        /// <summary>
        /// <p>Additional flag</p>
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

