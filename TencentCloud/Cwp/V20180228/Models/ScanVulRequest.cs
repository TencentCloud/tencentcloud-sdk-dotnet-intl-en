/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScanVulRequest : AbstractModel
    {
        
        /// <summary>
        /// Whether to count only critical vulnerabilities. 1: only critical vulnerabilities; 0: all vulnerabilities.
        /// </summary>
        [JsonProperty("VulLevels")]
        public string VulLevels{ get; set; }

        /// <summary>
        /// Server type. 1: Pro Edition server; 2: selected server.
        /// </summary>
        [JsonProperty("HostType")]
        public ulong? HostType{ get; set; }

        /// <summary>
        /// Vulnerability category. 1: web CMS vulnerability; 2: application vulnerability; 4: Linux software vulnerability; 5: Windows system vulnerability (separate multiple values by commas).
        /// </summary>
        [JsonProperty("VulCategories")]
        public string VulCategories{ get; set; }

        /// <summary>
        /// String array of host QUUIDs. This parameter is effective for selected servers.
        /// </summary>
        [JsonProperty("QuuidList")]
        public string[] QuuidList{ get; set; }

        /// <summary>
        /// Whether it is an emergency vulnerability. 0: no; 1: yes.
        /// </summary>
        [JsonProperty("VulEmergency")]
        public ulong? VulEmergency{ get; set; }

        /// <summary>
        /// Scan duration, in seconds. Default duration: 3,600 second.
        /// </summary>
        [JsonProperty("TimeoutPeriod")]
        public ulong? TimeoutPeriod{ get; set; }

        /// <summary>
        /// IDs of vulnerabilities to be scanned
        /// </summary>
        [JsonProperty("VulIds")]
        public ulong?[] VulIds{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ScanMethod")]
        public ulong? ScanMethod{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VulLevels", this.VulLevels);
            this.SetParamSimple(map, prefix + "HostType", this.HostType);
            this.SetParamSimple(map, prefix + "VulCategories", this.VulCategories);
            this.SetParamArraySimple(map, prefix + "QuuidList.", this.QuuidList);
            this.SetParamSimple(map, prefix + "VulEmergency", this.VulEmergency);
            this.SetParamSimple(map, prefix + "TimeoutPeriod", this.TimeoutPeriod);
            this.SetParamArraySimple(map, prefix + "VulIds.", this.VulIds);
            this.SetParamSimple(map, prefix + "ScanMethod", this.ScanMethod);
        }
    }
}

