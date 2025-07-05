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

namespace TencentCloud.Yunjing.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WeeklyReportVul : AbstractModel
    {
        
        /// <summary>
        /// Private IP of server.
        /// </summary>
        [JsonProperty("MachineIp")]
        public string MachineIp{ get; set; }

        /// <summary>
        /// Vulnerability name.
        /// </summary>
        [JsonProperty("VulName")]
        public string VulName{ get; set; }

        /// <summary>
        /// Vulnerability type.
        /// <li> WEB: web vulnerability</li>
        /// <li> SYSTEM: system component vulnerability</li>
        /// <li> BASELINE: security baseline</li>
        /// </summary>
        [JsonProperty("VulType")]
        public string VulType{ get; set; }

        /// <summary>
        /// Vulnerability description.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Vulnerability status.
        /// <li> UN_OPERATED: to be processed</li>
        /// <li> SCANING: scanning</li>
        /// <li> FIXED: fixed</li>
        /// </summary>
        [JsonProperty("VulStatus")]
        public string VulStatus{ get; set; }

        /// <summary>
        /// Last scanned time.
        /// </summary>
        [JsonProperty("LastScanTime")]
        public string LastScanTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MachineIp", this.MachineIp);
            this.SetParamSimple(map, prefix + "VulName", this.VulName);
            this.SetParamSimple(map, prefix + "VulType", this.VulType);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "VulStatus", this.VulStatus);
            this.SetParamSimple(map, prefix + "LastScanTime", this.LastScanTime);
        }
    }
}

