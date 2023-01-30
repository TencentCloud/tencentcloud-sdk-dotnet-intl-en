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

    public class DescribeClusterSummaryResponse : AbstractModel
    {
        
        /// <summary>
        /// Total number of clusters
        /// </summary>
        [JsonProperty("TotalCount")]
        public ulong? TotalCount{ get; set; }

        /// <summary>
        /// Number of clusters at risk
        /// </summary>
        [JsonProperty("RiskClusterCount")]
        public ulong? RiskClusterCount{ get; set; }

        /// <summary>
        /// Number of clusters not checked
        /// </summary>
        [JsonProperty("UncheckClusterCount")]
        public ulong? UncheckClusterCount{ get; set; }

        /// <summary>
        /// Number of managed clusters
        /// </summary>
        [JsonProperty("ManagedClusterCount")]
        public ulong? ManagedClusterCount{ get; set; }

        /// <summary>
        /// Number of self-deployed clusters
        /// </summary>
        [JsonProperty("IndependentClusterCount")]
        public ulong? IndependentClusterCount{ get; set; }

        /// <summary>
        /// Number of clusters involving no risks
        /// </summary>
        [JsonProperty("NoRiskClusterCount")]
        public ulong? NoRiskClusterCount{ get; set; }

        /// <summary>
        /// Number of checked clusters
        /// </summary>
        [JsonProperty("CheckedClusterCount")]
        public ulong? CheckedClusterCount{ get; set; }

        /// <summary>
        /// Number of clusters automatically checked
        /// </summary>
        [JsonProperty("AutoCheckClusterCount")]
        public ulong? AutoCheckClusterCount{ get; set; }

        /// <summary>
        /// Number of clusters manually checked
        /// </summary>
        [JsonProperty("ManualCheckClusterCount")]
        public ulong? ManualCheckClusterCount{ get; set; }

        /// <summary>
        /// Number of clusters that failed the check
        /// </summary>
        [JsonProperty("FailedClusterCount")]
        public ulong? FailedClusterCount{ get; set; }

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
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "RiskClusterCount", this.RiskClusterCount);
            this.SetParamSimple(map, prefix + "UncheckClusterCount", this.UncheckClusterCount);
            this.SetParamSimple(map, prefix + "ManagedClusterCount", this.ManagedClusterCount);
            this.SetParamSimple(map, prefix + "IndependentClusterCount", this.IndependentClusterCount);
            this.SetParamSimple(map, prefix + "NoRiskClusterCount", this.NoRiskClusterCount);
            this.SetParamSimple(map, prefix + "CheckedClusterCount", this.CheckedClusterCount);
            this.SetParamSimple(map, prefix + "AutoCheckClusterCount", this.AutoCheckClusterCount);
            this.SetParamSimple(map, prefix + "ManualCheckClusterCount", this.ManualCheckClusterCount);
            this.SetParamSimple(map, prefix + "FailedClusterCount", this.FailedClusterCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

