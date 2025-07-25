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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAffectedClusterCountResponse : AbstractModel
    {
        
        /// <summary>
        /// Number of critical clusters
        /// </summary>
        [JsonProperty("SeriousRiskClusterCount")]
        public ulong? SeriousRiskClusterCount{ get; set; }

        /// <summary>
        /// Number of high-risk clusters
        /// </summary>
        [JsonProperty("HighRiskClusterCount")]
        public ulong? HighRiskClusterCount{ get; set; }

        /// <summary>
        /// Number of medium-risk clusters
        /// </summary>
        [JsonProperty("MiddleRiskClusterCount")]
        public ulong? MiddleRiskClusterCount{ get; set; }

        /// <summary>
        /// Number of low-risk clusters
        /// </summary>
        [JsonProperty("HintRiskClusterCount")]
        public ulong? HintRiskClusterCount{ get; set; }

        /// <summary>
        /// The unique request ID, generated by the server, will be returned for every request (if the request fails to reach the server for other reasons, the request will not obtain a RequestId). RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SeriousRiskClusterCount", this.SeriousRiskClusterCount);
            this.SetParamSimple(map, prefix + "HighRiskClusterCount", this.HighRiskClusterCount);
            this.SetParamSimple(map, prefix + "MiddleRiskClusterCount", this.MiddleRiskClusterCount);
            this.SetParamSimple(map, prefix + "HintRiskClusterCount", this.HintRiskClusterCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

