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

    public class VulFixStatusInfo : AbstractModel
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
        /// Vulnerability fixing progress: 1-100;
        /// </summary>
        [JsonProperty("Progress")]
        public ulong? Progress{ get; set; }

        /// <summary>
        /// Vulnerability fixing status for corresponding hosts
        /// </summary>
        [JsonProperty("HostList")]
        public VulFixStatusHostInfo[] HostList{ get; set; }

        /// <summary>
        /// Number of hosts with failed vulnerability fixing
        /// </summary>
        [JsonProperty("FailCnt")]
        public ulong? FailCnt{ get; set; }

        /// <summary>
        /// Number of successful repairs
        /// </summary>
        [JsonProperty("FixSuccessCnt")]
        public ulong? FixSuccessCnt{ get; set; }

        /// <summary>
        /// Repair method. 0: Update components or install patches. 1: Disable service.
        /// </summary>
        [JsonProperty("FixMethod")]
        public ulong? FixMethod{ get; set; }

        /// <summary>
        /// kb ID
        /// </summary>
        [JsonProperty("KbId")]
        public ulong? KbId{ get; set; }

        /// <summary>
        /// kb number
        /// </summary>
        [JsonProperty("KbNumber")]
        public string KbNumber{ get; set; }

        /// <summary>
        /// kb name
        /// </summary>
        [JsonProperty("KbName")]
        public string KbName{ get; set; }

        /// <summary>
        /// Pre kb list
        /// </summary>
        [JsonProperty("PreKbList")]
        public string[] PreKbList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VulId", this.VulId);
            this.SetParamSimple(map, prefix + "VulName", this.VulName);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamArrayObj(map, prefix + "HostList.", this.HostList);
            this.SetParamSimple(map, prefix + "FailCnt", this.FailCnt);
            this.SetParamSimple(map, prefix + "FixSuccessCnt", this.FixSuccessCnt);
            this.SetParamSimple(map, prefix + "FixMethod", this.FixMethod);
            this.SetParamSimple(map, prefix + "KbId", this.KbId);
            this.SetParamSimple(map, prefix + "KbNumber", this.KbNumber);
            this.SetParamSimple(map, prefix + "KbName", this.KbName);
            this.SetParamArraySimple(map, prefix + "PreKbList.", this.PreKbList);
        }
    }
}

