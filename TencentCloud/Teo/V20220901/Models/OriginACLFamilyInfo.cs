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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OriginACLFamilyInfo : AbstractModel
    {
        
        /// <summary>
        /// Origin protection version number.
        /// Format description:
        /// Standard version.
        /// <li>gaz-xxxxx: global;</li>
        /// <li>mlc-xxxxx: China;</li>
        /// <li>emc-xxxxx: overseas (worldwide excluding China);</li>
        /// Simplified edition (platform-level version)
        /// <li>plat-gaz-xxxxxx: Simplified global edition;</li>
        /// <li>plat-mlc-xxxxxx: Simplified China version;</li>
        /// <li>plat-emc-xxxxxx: Simplified overseas (global excluding China) edition;</li>
        /// Abbreviation description:
        /// <li>gaz:Global AZ Availability Zone;</li>
        /// <li>mlc:mainlandChina;</li>
        /// <li>emc:Exclude mainlandChina.</li>
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// Version effective time, which adopts Beijing time (UTC+8) and follows the date and time format of the ISO 8601 standard.
        /// </summary>
        [JsonProperty("ActiveTime")]
        public string ActiveTime{ get; set; }

        /// <summary>
        /// Origin-pull IP range details.	
        /// </summary>
        [JsonProperty("EntireAddresses")]
        public Addresses EntireAddresses{ get; set; }

        /// <summary>
        /// Origin protection origin-pull ACL control domain. Parameter values are as follows:
        /// <li>gaz: standard global availability zone control domain;</li>
        /// <li>mlc: standard Chinese mainland availability zone control domain;</li>
        /// <li>emc: standard worldwide (excluding Chinese mainland) availability zone control domain;</li>
        /// <li>plat-gaz: simplified global availability zone control domain;</li>
        /// <li>plat-mlc: Simplified Chinese mainland availability zone control domain;</li>
        /// <li>plat-emc: Simplified global (excluding Chinese mainland) availability zone control domain;</li>
        /// </summary>
        [JsonProperty("OriginACLFamily")]
        public string OriginACLFamily{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "ActiveTime", this.ActiveTime);
            this.SetParamObj(map, prefix + "EntireAddresses.", this.EntireAddresses);
            this.SetParamSimple(map, prefix + "OriginACLFamily", this.OriginACLFamily);
        }
    }
}

