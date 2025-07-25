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

    public class DescribeTaskResultSummaryResponse : AbstractModel
    {
        
        /// <summary>
        /// Number of nodes affected by critical risks in the last seven days
        /// </summary>
        [JsonProperty("SeriousRiskNodeCount")]
        public ulong?[] SeriousRiskNodeCount{ get; set; }

        /// <summary>
        /// Number of nodes affected by high risks in the last seven days
        /// </summary>
        [JsonProperty("HighRiskNodeCount")]
        public ulong?[] HighRiskNodeCount{ get; set; }

        /// <summary>
        /// Number of nodes affected by medium risks in the last seven days
        /// </summary>
        [JsonProperty("MiddleRiskNodeCount")]
        public ulong?[] MiddleRiskNodeCount{ get; set; }

        /// <summary>
        /// Number of nodes affected by prompt risks in the last seven days
        /// </summary>
        [JsonProperty("HintRiskNodeCount")]
        public ulong?[] HintRiskNodeCount{ get; set; }

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
            this.SetParamArraySimple(map, prefix + "SeriousRiskNodeCount.", this.SeriousRiskNodeCount);
            this.SetParamArraySimple(map, prefix + "HighRiskNodeCount.", this.HighRiskNodeCount);
            this.SetParamArraySimple(map, prefix + "MiddleRiskNodeCount.", this.MiddleRiskNodeCount);
            this.SetParamArraySimple(map, prefix + "HintRiskNodeCount.", this.HintRiskNodeCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

