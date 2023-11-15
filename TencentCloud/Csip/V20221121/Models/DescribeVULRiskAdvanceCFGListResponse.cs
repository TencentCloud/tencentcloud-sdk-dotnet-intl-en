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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeVULRiskAdvanceCFGListResponse : AbstractModel
    {
        
        /// <summary>
        /// List of configuration items
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Data")]
        public VULRiskAdvanceCFGList[] Data{ get; set; }

        /// <summary>
        /// Total number of results
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// List of risk levels
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RiskLevelLists")]
        public FilterDataObject[] RiskLevelLists{ get; set; }

        /// <summary>
        /// List of vulnerabilities types
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VULTypeLists")]
        public FilterDataObject[] VULTypeLists{ get; set; }

        /// <summary>
        /// List of check source
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CheckFromLists")]
        public FilterDataObject[] CheckFromLists{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "Data.", this.Data);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamArrayObj(map, prefix + "RiskLevelLists.", this.RiskLevelLists);
            this.SetParamArrayObj(map, prefix + "VULTypeLists.", this.VULTypeLists);
            this.SetParamArrayObj(map, prefix + "CheckFromLists.", this.CheckFromLists);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

