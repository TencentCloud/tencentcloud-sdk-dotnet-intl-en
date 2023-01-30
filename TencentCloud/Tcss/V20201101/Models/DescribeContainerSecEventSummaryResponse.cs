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

    public class DescribeContainerSecEventSummaryResponse : AbstractModel
    {
        
        /// <summary>
        /// Pending escape event
        /// </summary>
        [JsonProperty("UnhandledEscapeCnt")]
        public ulong? UnhandledEscapeCnt{ get; set; }

        /// <summary>
        /// Pending reverse shell event
        /// </summary>
        [JsonProperty("UnhandledReverseShellCnt")]
        public ulong? UnhandledReverseShellCnt{ get; set; }

        /// <summary>
        /// Pending high-risk syscall
        /// </summary>
        [JsonProperty("UnhandledRiskSyscallCnt")]
        public ulong? UnhandledRiskSyscallCnt{ get; set; }

        /// <summary>
        /// Pending abnormal process
        /// </summary>
        [JsonProperty("UnhandledAbnormalProcessCnt")]
        public ulong? UnhandledAbnormalProcessCnt{ get; set; }

        /// <summary>
        /// Pending file tampering event
        /// </summary>
        [JsonProperty("UnhandledFileCnt")]
        public ulong? UnhandledFileCnt{ get; set; }

        /// <summary>
        /// Pending trojan event
        /// </summary>
        [JsonProperty("UnhandledVirusEventCnt")]
        public ulong? UnhandledVirusEventCnt{ get; set; }

        /// <summary>
        /// Unhandled malicious outgoing connections
        /// </summary>
        [JsonProperty("UnhandledMaliciousConnectionEventCnt")]
        public ulong? UnhandledMaliciousConnectionEventCnt{ get; set; }

        /// <summary>
        /// Unhandled K8sApi events
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("UnhandledK8sApiEventCnt")]
        public ulong? UnhandledK8sApiEventCnt{ get; set; }

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
            this.SetParamSimple(map, prefix + "UnhandledEscapeCnt", this.UnhandledEscapeCnt);
            this.SetParamSimple(map, prefix + "UnhandledReverseShellCnt", this.UnhandledReverseShellCnt);
            this.SetParamSimple(map, prefix + "UnhandledRiskSyscallCnt", this.UnhandledRiskSyscallCnt);
            this.SetParamSimple(map, prefix + "UnhandledAbnormalProcessCnt", this.UnhandledAbnormalProcessCnt);
            this.SetParamSimple(map, prefix + "UnhandledFileCnt", this.UnhandledFileCnt);
            this.SetParamSimple(map, prefix + "UnhandledVirusEventCnt", this.UnhandledVirusEventCnt);
            this.SetParamSimple(map, prefix + "UnhandledMaliciousConnectionEventCnt", this.UnhandledMaliciousConnectionEventCnt);
            this.SetParamSimple(map, prefix + "UnhandledK8sApiEventCnt", this.UnhandledK8sApiEventCnt);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

