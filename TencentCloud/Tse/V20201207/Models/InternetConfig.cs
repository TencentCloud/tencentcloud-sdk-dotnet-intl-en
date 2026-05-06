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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InternetConfig : AbstractModel
    {
        
        /// <summary>
        /// Public network address version. Optional: "IPV4" | "IPV6". By default IPV4 if left blank.
        /// </summary>
        [JsonProperty("InternetAddressVersion")]
        public string InternetAddressVersion{ get; set; }

        /// <summary>
        /// Public network payment mode. Currently, only "BANDWIDTH" is selectable. Defaults to "BANDWIDTH" if left blank.
        /// </summary>
        [JsonProperty("InternetPayMode")]
        public string InternetPayMode{ get; set; }

        /// <summary>
        /// Public network bandwidth.
        /// </summary>
        [JsonProperty("InternetMaxBandwidthOut")]
        public ulong? InternetMaxBandwidthOut{ get; set; }

        /// <summary>
        /// Description of load balancing
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Load balancing specification type. Support clb.c2.medium, clb.c3.small, clb.c3.medium, clb.c4.small, clb.c4.medium, clb.c4.large, clb.c4.xlarge. Defaults to shared type.
        /// </summary>
        [JsonProperty("SlaType")]
        public string SlaType{ get; set; }

        /// <summary>
        /// Whether load balancing is multi-availability zone
        /// </summary>
        [JsonProperty("MultiZoneFlag")]
        public bool? MultiZoneFlag{ get; set; }

        /// <summary>
        /// Primary AZ.
        /// </summary>
        [JsonProperty("MasterZoneId")]
        public string MasterZoneId{ get; set; }

        /// <summary>
        /// standby availability zone
        /// </summary>
        [JsonProperty("SlaveZoneId")]
        public string SlaveZoneId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InternetAddressVersion", this.InternetAddressVersion);
            this.SetParamSimple(map, prefix + "InternetPayMode", this.InternetPayMode);
            this.SetParamSimple(map, prefix + "InternetMaxBandwidthOut", this.InternetMaxBandwidthOut);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "SlaType", this.SlaType);
            this.SetParamSimple(map, prefix + "MultiZoneFlag", this.MultiZoneFlag);
            this.SetParamSimple(map, prefix + "MasterZoneId", this.MasterZoneId);
            this.SetParamSimple(map, prefix + "SlaveZoneId", this.SlaveZoneId);
        }
    }
}

