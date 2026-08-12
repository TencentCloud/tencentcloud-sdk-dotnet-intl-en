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

    public class VulFixedItem : AbstractModel
    {
        
        /// <summary>
        /// Vulnerability ID
        /// </summary>
        [JsonProperty("VulId")]
        public long? VulId{ get; set; }

        /// <summary>
        /// Vulnerability name
        /// </summary>
        [JsonProperty("VulName")]
        public string VulName{ get; set; }

        /// <summary>
        /// Vulnerability level
        /// Enumeration values:
        /// LOW: low-risk
        /// MEDIUM: Medium risk
        /// HIGH: High risk
        /// CRITICAL
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// VPR rating information (including rating result, description, and phased score), consistent with DescribeHostVulRiskList
        /// </summary>
        [JsonProperty("VRPRatingInfo")]
        public VPRRatingInfo VRPRatingInfo{ get; set; }

        /// <summary>
        /// Vulnerability Type
        /// Enumeration values:
        /// LINUX: Linux software vulnerability
        /// WINDOWS: Windows system patch vulnerability
        /// WEB_CMS: Web-CMS vulnerabilities
        /// APPLICATION: Application vulnerability
        /// EMERGENCY: Urgent vulnerability
        /// </summary>
        [JsonProperty("VulCategory")]
        public string VulCategory{ get; set; }

        /// <summary>
        /// CVE id
        /// </summary>
        [JsonProperty("CveId")]
        public string CveId{ get; set; }

        /// <summary>
        /// Repair the host name
        /// </summary>
        [JsonProperty("MachineName")]
        public string MachineName{ get; set; }

        /// <summary>
        /// Repair the host instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Associated component & number of paths
        /// </summary>
        [JsonProperty("ComponentCount")]
        public long? ComponentCount{ get; set; }

        /// <summary>
        /// Associated component & path list
        /// </summary>
        [JsonProperty("Components")]
        public string[] Components{ get; set; }

        /// <summary>
        /// Last repair time
        /// Parameter format: YYYY-MM-DDTHH:mm:ssZ (ISO8601 format).
        /// </summary>
        [JsonProperty("LatestFixTime")]
        public string LatestFixTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VulId", this.VulId);
            this.SetParamSimple(map, prefix + "VulName", this.VulName);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamObj(map, prefix + "VRPRatingInfo.", this.VRPRatingInfo);
            this.SetParamSimple(map, prefix + "VulCategory", this.VulCategory);
            this.SetParamSimple(map, prefix + "CveId", this.CveId);
            this.SetParamSimple(map, prefix + "MachineName", this.MachineName);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ComponentCount", this.ComponentCount);
            this.SetParamArraySimple(map, prefix + "Components.", this.Components);
            this.SetParamSimple(map, prefix + "LatestFixTime", this.LatestFixTime);
        }
    }
}

