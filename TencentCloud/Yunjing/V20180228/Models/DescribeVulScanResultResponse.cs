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

namespace TencentCloud.Yunjing.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeVulScanResultResponse : AbstractModel
    {
        
        /// <summary>
        /// Number of vulnerabilities.
        /// </summary>
        [JsonProperty("VulNum")]
        public ulong? VulNum{ get; set; }

        /// <summary>
        /// Number of servers activated CWP Pro
        /// </summary>
        [JsonProperty("ProVersionNum")]
        public ulong? ProVersionNum{ get; set; }

        /// <summary>
        /// Number of affected activated CWP Pro.
        /// </summary>
        [JsonProperty("ImpactedHostNum")]
        public ulong? ImpactedHostNum{ get; set; }

        /// <summary>
        /// Total number of servers.
        /// </summary>
        [JsonProperty("HostNum")]
        public ulong? HostNum{ get; set; }

        /// <summary>
        /// Number of servers on CWP Basic.
        /// </summary>
        [JsonProperty("BasicVersionNum")]
        public ulong? BasicVersionNum{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VulNum", this.VulNum);
            this.SetParamSimple(map, prefix + "ProVersionNum", this.ProVersionNum);
            this.SetParamSimple(map, prefix + "ImpactedHostNum", this.ImpactedHostNum);
            this.SetParamSimple(map, prefix + "HostNum", this.HostNum);
            this.SetParamSimple(map, prefix + "BasicVersionNum", this.BasicVersionNum);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

