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

    public class VulFixStatusInfo : AbstractModel
    {
        
        /// <summary>
        /// Vulnerability ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VulId")]
        public ulong? VulId{ get; set; }

        /// <summary>
        /// Vulnerability name
        /// Note: This field may return null, indicating that no valid values can be obtained.
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
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HostList")]
        public VulFixStatusHostInfo[] HostList{ get; set; }

        /// <summary>
        /// Number of hosts with failed vulnerability fixing
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FailCnt")]
        public ulong? FailCnt{ get; set; }

        /// <summary>
        /// Number of hosts with successful vulnerability fixing
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FixSuccessCnt")]
        public ulong? FixSuccessCnt{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("FixMethod")]
        public ulong? FixMethod{ get; set; }


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
        }
    }
}

