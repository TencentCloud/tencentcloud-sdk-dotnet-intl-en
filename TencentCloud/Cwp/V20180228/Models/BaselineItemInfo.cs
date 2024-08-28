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

    public class BaselineItemInfo : AbstractModel
    {
        
        /// <summary>
        /// Baseline Detection Item ID
        /// </summary>
        [JsonProperty("ItemId")]
        public long? ItemId{ get; set; }

        /// <summary>
        /// Detection Item Name
        /// </summary>
        [JsonProperty("ItemName")]
        public string ItemName{ get; set; }

        /// <summary>
        /// ID of the Rule to Which the Detection Item Belongs
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RuleId")]
        public ulong? RuleId{ get; set; }

        /// <summary>
        /// Detection item description
        /// </summary>
        [JsonProperty("ItemDesc")]
        public string ItemDesc{ get; set; }

        /// <summary>
        /// Remediation Method for Inspection Items
        /// </summary>
        [JsonProperty("FixMethod")]
        public string FixMethod{ get; set; }

        /// <summary>
        /// Rule Name of Detection Item
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// Risk level
        /// </summary>
        [JsonProperty("Level")]
        public long? Level{ get; set; }

        /// <summary>
        /// System Rule ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SysRuleId")]
        public long? SysRuleId{ get; set; }

        /// <summary>
        /// Referenced Custom Rule Information
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RelatedCustomRuleInfo")]
        public BaselineCustomRuleIdName[] RelatedCustomRuleInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ItemId", this.ItemId);
            this.SetParamSimple(map, prefix + "ItemName", this.ItemName);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "ItemDesc", this.ItemDesc);
            this.SetParamSimple(map, prefix + "FixMethod", this.FixMethod);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "SysRuleId", this.SysRuleId);
            this.SetParamArrayObj(map, prefix + "RelatedCustomRuleInfo.", this.RelatedCustomRuleInfo);
        }
    }
}

