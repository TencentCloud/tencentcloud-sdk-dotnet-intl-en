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

    public class BaselineInfo : AbstractModel
    {
        
        /// <summary>
        /// Baseline name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Hazard level: 1-Low-risk; 2-Medium-risk; 3-High-risk; 4-Critical
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Level")]
        public ulong? Level{ get; set; }

        /// <summary>
        /// Number of check items
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RuleCount")]
        public ulong? RuleCount{ get; set; }

        /// <summary>
        /// Number of affected servers
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HostCount")]
        public ulong? HostCount{ get; set; }

        /// <summary>
        /// Pass status. 0: passed; 1: failed.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Baseline ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CategoryId")]
        public ulong? CategoryId{ get; set; }

        /// <summary>
        /// Last check time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LastScanTime")]
        public string LastScanTime{ get; set; }

        /// <summary>
        /// 5: checking
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MaxStatus")]
        public ulong? MaxStatus{ get; set; }

        /// <summary>
        /// Baseline check items with risks
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BaselineFailCount")]
        public ulong? BaselineFailCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "RuleCount", this.RuleCount);
            this.SetParamSimple(map, prefix + "HostCount", this.HostCount);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CategoryId", this.CategoryId);
            this.SetParamSimple(map, prefix + "LastScanTime", this.LastScanTime);
            this.SetParamSimple(map, prefix + "MaxStatus", this.MaxStatus);
            this.SetParamSimple(map, prefix + "BaselineFailCount", this.BaselineFailCount);
        }
    }
}

