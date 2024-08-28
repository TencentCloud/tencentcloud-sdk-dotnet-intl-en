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

    public class VulStoreListInfo : AbstractModel
    {
        
        /// <summary>
        /// Vulnerability ID
        /// </summary>
        [JsonProperty("VulId")]
        public ulong? VulId{ get; set; }

        /// <summary>
        /// Vulnerability level
        /// </summary>
        [JsonProperty("Level")]
        public ulong? Level{ get; set; }

        /// <summary>
        /// Vulnerability name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// CVE ID
        /// </summary>
        [JsonProperty("CveId")]
        public string CveId{ get; set; }

        /// <summary>
        /// 1: web-cms vulnerabilities; 2: application vulnerabilities; 4: Linux software vulnerabilities; 5: Windows system vulnerabilities; 0: emergency vulnerabilities.
        /// </summary>
        [JsonProperty("VulCategory")]
        public ulong? VulCategory{ get; set; }

        /// <summary>
        /// Release time
        /// </summary>
        [JsonProperty("PublishDate")]
        public string PublishDate{ get; set; }

        /// <summary>
        /// Vulnerability Detection Method: 0 - Version Comparison, 1 - POC Verification
        /// </summary>
        [JsonProperty("Method")]
        public ulong? Method{ get; set; }

        /// <summary>
        /// Vulnerability attack level
        /// </summary>
        [JsonProperty("AttackLevel")]
        public ulong? AttackLevel{ get; set; }

        /// <summary>
        /// Whether automatic vulnerability fixing is supported
        /// 0: not supported on Windows/Linux; 1: supported on Windows/Linux; 2: supported on Linux only; 3: supported on Windows only.
        /// </summary>
        [JsonProperty("FixSwitch")]
        public ulong? FixSwitch{ get; set; }

        /// <summary>
        /// Whether defense against vulnerabilities is supported
        /// 0: not supported; 1: supported.
        /// </summary>
        [JsonProperty("SupportDefense")]
        public ulong? SupportDefense{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VulId", this.VulId);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "CveId", this.CveId);
            this.SetParamSimple(map, prefix + "VulCategory", this.VulCategory);
            this.SetParamSimple(map, prefix + "PublishDate", this.PublishDate);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamSimple(map, prefix + "AttackLevel", this.AttackLevel);
            this.SetParamSimple(map, prefix + "FixSwitch", this.FixSwitch);
            this.SetParamSimple(map, prefix + "SupportDefense", this.SupportDefense);
        }
    }
}

