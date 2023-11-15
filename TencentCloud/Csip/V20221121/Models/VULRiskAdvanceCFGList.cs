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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VULRiskAdvanceCFGList : AbstractModel
    {
        
        /// <summary>
        /// Risk ID
        /// </summary>
        [JsonProperty("RiskId")]
        public string RiskId{ get; set; }

        /// <summary>
        /// Vulnerability name
        /// </summary>
        [JsonProperty("VULName")]
        public string VULName{ get; set; }

        /// <summary>
        /// Risk level
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }

        /// <summary>
        /// Source of the check task
        /// </summary>
        [JsonProperty("CheckFrom")]
        public string CheckFrom{ get; set; }

        /// <summary>
        /// Whether it's enabled. `1`: Enable; `0`: Disabled
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Enable")]
        public long? Enable{ get; set; }

        /// <summary>
        /// Risk type.
        /// </summary>
        [JsonProperty("VULType")]
        public string VULType{ get; set; }

        /// <summary>
        /// Affected versions
        /// </summary>
        [JsonProperty("ImpactVersion")]
        public string ImpactVersion{ get; set; }

        /// <summary>
        /// CVE number
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CVE")]
        public string CVE{ get; set; }

        /// <summary>
        /// Vulnerability tag
        /// </summary>
        [JsonProperty("VULTag")]
        public string[] VULTag{ get; set; }

        /// <summary>
        /// Fix solution
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FixMethod")]
        public string[] FixMethod{ get; set; }

        /// <summary>
        /// Disclosure time
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ReleaseTime")]
        public string ReleaseTime{ get; set; }

        /// <summary>
        /// Whether it's an emergency vulnerability. Values: `1` (emergency vulnerability); `0` (non-emergency vulnerability
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EMGCVulType")]
        public long? EMGCVulType{ get; set; }

        /// <summary>
        /// Vulnerability description
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VULDescribe")]
        public string VULDescribe{ get; set; }

        /// <summary>
        /// Affected components
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ImpactComponent")]
        public string ImpactComponent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RiskId", this.RiskId);
            this.SetParamSimple(map, prefix + "VULName", this.VULName);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "CheckFrom", this.CheckFrom);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "VULType", this.VULType);
            this.SetParamSimple(map, prefix + "ImpactVersion", this.ImpactVersion);
            this.SetParamSimple(map, prefix + "CVE", this.CVE);
            this.SetParamArraySimple(map, prefix + "VULTag.", this.VULTag);
            this.SetParamArraySimple(map, prefix + "FixMethod.", this.FixMethod);
            this.SetParamSimple(map, prefix + "ReleaseTime", this.ReleaseTime);
            this.SetParamSimple(map, prefix + "EMGCVulType", this.EMGCVulType);
            this.SetParamSimple(map, prefix + "VULDescribe", this.VULDescribe);
            this.SetParamSimple(map, prefix + "ImpactComponent", this.ImpactComponent);
        }
    }
}

