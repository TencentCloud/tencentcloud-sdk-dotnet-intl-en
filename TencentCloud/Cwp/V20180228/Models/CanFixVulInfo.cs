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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CanFixVulInfo : AbstractModel
    {
        
        /// <summary>
        /// Vulnerability ID
        /// </summary>
        [JsonProperty("VulId")]
        public ulong? VulId{ get; set; }

        /// <summary>
        /// Vulnerability name
        /// </summary>
        [JsonProperty("VulName")]
        public string VulName{ get; set; }

        /// <summary>
        /// Information on hosts where this vulnerability can be fixed
        /// </summary>
        [JsonProperty("HostList")]
        public VulInfoHostInfo[] HostList{ get; set; }

        /// <summary>
        /// Fixing prompt tag
        /// </summary>
        [JsonProperty("FixTag")]
        public string[] FixTag{ get; set; }

        /// <summary>
        /// Vulnerability category. 1: web CMS vulnerability, 2: application vulnerability, 4: Linux software vulnerability, 5 Windows system vulnerability.
        /// </summary>
        [JsonProperty("VulCategory")]
        public ulong? VulCategory{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VulId", this.VulId);
            this.SetParamSimple(map, prefix + "VulName", this.VulName);
            this.SetParamArrayObj(map, prefix + "HostList.", this.HostList);
            this.SetParamArraySimple(map, prefix + "FixTag.", this.FixTag);
            this.SetParamSimple(map, prefix + "VulCategory", this.VulCategory);
        }
    }
}

