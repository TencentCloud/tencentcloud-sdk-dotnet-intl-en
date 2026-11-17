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
        /// <p>Vulnerability level<br>Enumeration values:<br>LOW: Low risk<br>MEDIUM: Medium risk<br>HIGH: High risk<br>CRITICAL: Critical</p>
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// <p>VPR rating information (including rating result, description, and staged score), consistent with DescribeHostVulRiskList</p>
        /// </summary>
        [JsonProperty("VRPRatingInfo")]
        public VPRRatingInfo VRPRatingInfo{ get; set; }

        /// <summary>
        /// <p>Vulnerability type<br>Enumeration values:<br>LINUX: Linux software vulnerability<br>WINDOWS: Windows system patch vulnerability<br>WEB_CMS: Web-CMS vulnerability<br>APPLICATION: Application vulnerability<br>EMERGENCY: Urgent vulnerability</p>
        /// </summary>
        [JsonProperty("VulCategory")]
        public string VulCategory{ get; set; }

        /// <summary>
        /// <p>CVE id</p>
        /// </summary>
        [JsonProperty("CveId")]
        public string CveId{ get; set; }

        /// <summary>
        /// <p>Repair host name</p>
        /// </summary>
        [JsonProperty("MachineName")]
        public string MachineName{ get; set; }

        /// <summary>
        /// <p>Repair host instance ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Associated component &amp; number of paths</p>
        /// </summary>
        [JsonProperty("ComponentCount")]
        public long? ComponentCount{ get; set; }

        /// <summary>
        /// <p>Associated component &amp; path list</p>
        /// </summary>
        [JsonProperty("Components")]
        public string[] Components{ get; set; }

        /// <summary>
        /// <p>Last repair time<br>Parameter format: YYYY-MM-DDTHH:mm:ssZ (ISO8601 format)</p>
        /// </summary>
        [JsonProperty("LatestFixTime")]
        public string LatestFixTime{ get; set; }

        /// <summary>
        /// <p>VPR rating basis</p>
        /// </summary>
        [JsonProperty("VPRExplainInfo")]
        public VPRExplainInfo VPRExplainInfo{ get; set; }


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
            this.SetParamObj(map, prefix + "VPRExplainInfo.", this.VPRExplainInfo);
        }
    }
}

