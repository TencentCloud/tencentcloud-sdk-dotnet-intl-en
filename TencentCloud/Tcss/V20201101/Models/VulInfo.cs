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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VulInfo : AbstractModel
    {
        
        /// <summary>
        /// Vulnerability name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Vulnerability tag
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// CVSS V3 score
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CVSSV3Score")]
        public float? CVSSV3Score{ get; set; }

        /// <summary>
        /// Risk level
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// CVE No.
        /// </summary>
        [JsonProperty("CVEID")]
        public string CVEID{ get; set; }

        /// <summary>
        /// Vulnerability sub-category
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// First discovery time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FoundTime")]
        public string FoundTime{ get; set; }

        /// <summary>
        /// Last discovery time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LatestFoundTime")]
        public string LatestFoundTime{ get; set; }

        /// <summary>
        /// Vulnerability ID
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// Number of affected local images
        /// </summary>
        [JsonProperty("LocalImageCount")]
        public long? LocalImageCount{ get; set; }

        /// <summary>
        /// Number of affected containers
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ContainerCount")]
        public long? ContainerCount{ get; set; }

        /// <summary>
        /// Number of affected repository images
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RegistryImageCount")]
        public long? RegistryImageCount{ get; set; }

        /// <summary>
        /// POC ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PocID")]
        public string PocID{ get; set; }

        /// <summary>
        /// Defense status. Valid values: `NO_DEFENDED`, `DEFENDED`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DefenceStatus")]
        public string DefenceStatus{ get; set; }

        /// <summary>
        /// Scope of servers with exploit prevention enabled. Valid values: `MANUAL` (specified servers); `ALL` (all servers).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DefenceScope")]
        public string DefenceScope{ get; set; }

        /// <summary>
        /// Number of servers with exploit prevention enabled
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DefenceHostCount")]
        public long? DefenceHostCount{ get; set; }

        /// <summary>
        /// Number of attacks defended against
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DefendedCount")]
        public long? DefendedCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "CVSSV3Score", this.CVSSV3Score);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "CVEID", this.CVEID);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "FoundTime", this.FoundTime);
            this.SetParamSimple(map, prefix + "LatestFoundTime", this.LatestFoundTime);
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "LocalImageCount", this.LocalImageCount);
            this.SetParamSimple(map, prefix + "ContainerCount", this.ContainerCount);
            this.SetParamSimple(map, prefix + "RegistryImageCount", this.RegistryImageCount);
            this.SetParamSimple(map, prefix + "PocID", this.PocID);
            this.SetParamSimple(map, prefix + "DefenceStatus", this.DefenceStatus);
            this.SetParamSimple(map, prefix + "DefenceScope", this.DefenceScope);
            this.SetParamSimple(map, prefix + "DefenceHostCount", this.DefenceHostCount);
            this.SetParamSimple(map, prefix + "DefendedCount", this.DefendedCount);
        }
    }
}

