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

    public class AddEditImageAutoAuthorizedRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// Scope. Valid values: `MANUAL` (specified servers); `ALL` (all images).
        /// </summary>
        [JsonProperty("RangeType")]
        public string RangeType{ get; set; }

        /// <summary>
        /// Maximum number of image licenses per day. `0`: Unlimited.
        /// </summary>
        [JsonProperty("MaxDailyCount")]
        public long? MaxDailyCount{ get; set; }

        /// <summary>
        /// Whether the rule takes effect. Valid values: `0` (no); `1` (yes).
        /// </summary>
        [JsonProperty("IsEnabled")]
        public long? IsEnabled{ get; set; }

        /// <summary>
        /// IDs of specified servers. This parameter is required when the scope is `MANUAL` and `HostIdFilters` is empty.
        /// </summary>
        [JsonProperty("HostIdSet")]
        public string[] HostIdSet{ get; set; }

        /// <summary>
        /// Rule ID, which is required during editing.
        /// </summary>
        [JsonProperty("RuleId")]
        public long? RuleId{ get; set; }

        /// <summary>
        /// Filter. This parameter is required when the scope is `MANUAL` and `HostIdSet` is empty.
        /// </summary>
        [JsonProperty("HostIdFilters")]
        public AssetFilters[] HostIdFilters{ get; set; }

        /// <summary>
        /// Specified server IDs to be excluded
        /// </summary>
        [JsonProperty("ExcludeHostIdSet")]
        public string[] ExcludeHostIdSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RangeType", this.RangeType);
            this.SetParamSimple(map, prefix + "MaxDailyCount", this.MaxDailyCount);
            this.SetParamSimple(map, prefix + "IsEnabled", this.IsEnabled);
            this.SetParamArraySimple(map, prefix + "HostIdSet.", this.HostIdSet);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamArrayObj(map, prefix + "HostIdFilters.", this.HostIdFilters);
            this.SetParamArraySimple(map, prefix + "ExcludeHostIdSet.", this.ExcludeHostIdSet);
        }
    }
}

