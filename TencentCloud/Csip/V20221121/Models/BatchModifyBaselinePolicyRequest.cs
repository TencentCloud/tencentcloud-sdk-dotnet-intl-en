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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BatchModifyBaselinePolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>List of baseline policy IDs that need modification. It cannot be empty and elements cannot be 0.</p>
        /// </summary>
        [JsonProperty("PolicyIDList")]
        public ulong?[] PolicyIDList{ get; set; }

        /// <summary>
        /// <p>Period scan configuration; can be omitted if not modified. When Enable=1, IntervalType and IntervalValueList must be simultaneously passed in.</p>
        /// </summary>
        [JsonProperty("CycleScanConf")]
        public CycleScanConf CycleScanConf{ get; set; }

        /// <summary>
        /// <p>Automatic synchronization switch for newly-added built-in detection items. true: automatically join; false: do not join.</p>
        /// </summary>
        [JsonProperty("AutoSyncItem")]
        public bool? AutoSyncItem{ get; set; }

        /// <summary>
        /// <p>Categorization / subcategory / detection item hit configuration; can be omitted if not modified.</p>
        /// </summary>
        [JsonProperty("CategoryConf")]
        public BaselinePolicySystemCategoryConf[] CategoryConf{ get; set; }

        /// <summary>
        /// <p>Group account member id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>Configuration list of custom detection item values; can be omitted if not modified. In each element, RuleID and CustomItemID cannot both be 0.</p>
        /// </summary>
        [JsonProperty("CustomItemConf")]
        public BaselineCustomItemConf[] CustomItemConf{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "PolicyIDList.", this.PolicyIDList);
            this.SetParamObj(map, prefix + "CycleScanConf.", this.CycleScanConf);
            this.SetParamSimple(map, prefix + "AutoSyncItem", this.AutoSyncItem);
            this.SetParamArrayObj(map, prefix + "CategoryConf.", this.CategoryConf);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamArrayObj(map, prefix + "CustomItemConf.", this.CustomItemConf);
        }
    }
}

