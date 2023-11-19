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

    public class DescribeRiskCenterAssetViewWeakPasswordRiskListResponse : AbstractModel
    {
        
        /// <summary>
        /// Total number of entries
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// List of risks
        /// </summary>
        [JsonProperty("Data")]
        public AssetViewWeakPassRisk[] Data{ get; set; }

        /// <summary>
        /// List of risk handling status
        /// </summary>
        [JsonProperty("StatusLists")]
        public FilterDataObject[] StatusLists{ get; set; }

        /// <summary>
        /// List of risk levels
        /// </summary>
        [JsonProperty("LevelLists")]
        public FilterDataObject[] LevelLists{ get; set; }

        /// <summary>
        /// List of check source
        /// </summary>
        [JsonProperty("FromLists")]
        public FilterDataObject[] FromLists{ get; set; }

        /// <summary>
        /// List of asset types
        /// </summary>
        [JsonProperty("InstanceTypeLists")]
        public FilterDataObject[] InstanceTypeLists{ get; set; }

        /// <summary>
        /// List of weak password types
        /// </summary>
        [JsonProperty("PasswordTypeLists")]
        public FilterDataObject[] PasswordTypeLists{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "Data.", this.Data);
            this.SetParamArrayObj(map, prefix + "StatusLists.", this.StatusLists);
            this.SetParamArrayObj(map, prefix + "LevelLists.", this.LevelLists);
            this.SetParamArrayObj(map, prefix + "FromLists.", this.FromLists);
            this.SetParamArrayObj(map, prefix + "InstanceTypeLists.", this.InstanceTypeLists);
            this.SetParamArrayObj(map, prefix + "PasswordTypeLists.", this.PasswordTypeLists);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

