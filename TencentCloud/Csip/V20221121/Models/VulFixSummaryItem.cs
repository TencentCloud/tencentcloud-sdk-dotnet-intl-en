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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VulFixSummaryItem : AbstractModel
    {
        
        /// <summary>
        /// <p>Vulnerability ID</p>
        /// </summary>
        [JsonProperty("VulId")]
        public long? VulId{ get; set; }

        /// <summary>
        /// <p>Vulnerability name</p>
        /// </summary>
        [JsonProperty("VulName")]
        public string VulName{ get; set; }

        /// <summary>
        /// <p>CVE id</p>
        /// </summary>
        [JsonProperty("CveId")]
        public string CveId{ get; set; }

        /// <summary>
        /// <p>Number of affected hosts</p>
        /// </summary>
        [JsonProperty("AffectedCount")]
        public long? AffectedCount{ get; set; }

        /// <summary>
        /// <p>Whether restart is required after repair</p>
        /// </summary>
        [JsonProperty("NeedReboot")]
        public bool? NeedReboot{ get; set; }

        /// <summary>
        /// <p>Whether one-click repair is supported true-supported false-unsupported</p>
        /// </summary>
        [JsonProperty("FixSwitch")]
        public bool? FixSwitch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VulId", this.VulId);
            this.SetParamSimple(map, prefix + "VulName", this.VulName);
            this.SetParamSimple(map, prefix + "CveId", this.CveId);
            this.SetParamSimple(map, prefix + "AffectedCount", this.AffectedCount);
            this.SetParamSimple(map, prefix + "NeedReboot", this.NeedReboot);
            this.SetParamSimple(map, prefix + "FixSwitch", this.FixSwitch);
        }
    }
}

