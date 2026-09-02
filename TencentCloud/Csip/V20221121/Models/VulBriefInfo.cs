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

    public class VulBriefInfo : AbstractModel
    {
        
        /// <summary>
        /// Vulnerability ID (vul_vuls.id)
        /// </summary>
        [JsonProperty("VulID")]
        public ulong? VulID{ get; set; }

        /// <summary>
        /// Vulnerability name
        /// </summary>
        [JsonProperty("VulName")]
        public string VulName{ get; set; }

        /// <summary>
        /// CVE No.
        /// Parameter format: e.g. CVE-2018-5377
        /// </summary>
        [JsonProperty("CVEID")]
        public string CVEID{ get; set; }

        /// <summary>
        /// List of VPR risk tags
        /// </summary>
        [JsonProperty("Label")]
        public VPRLabel[] Label{ get; set; }

        /// <summary>
        /// CVSS score
        /// Valid values: [0.0, 10.0]
        /// </summary>
        [JsonProperty("CvssScore")]
        public float? CvssScore{ get; set; }

        /// <summary>
        /// Threat level
        /// Enumeration value:
        /// INVALID: invalid
        /// INFO: Notification
        /// LOW: low-risk
        /// MEDIUM: Medium risk
        /// HIGH: High risk
        /// CRITICAL: Critical
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// Vulnerability disclosure time
        /// Parameter format: YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonProperty("PublishTime")]
        public string PublishTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VulID", this.VulID);
            this.SetParamSimple(map, prefix + "VulName", this.VulName);
            this.SetParamSimple(map, prefix + "CVEID", this.CVEID);
            this.SetParamArrayObj(map, prefix + "Label.", this.Label);
            this.SetParamSimple(map, prefix + "CvssScore", this.CvssScore);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "PublishTime", this.PublishTime);
        }
    }
}

