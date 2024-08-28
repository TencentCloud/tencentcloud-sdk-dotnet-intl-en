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

    public class ScanBaselineRequest : AbstractModel
    {
        
        /// <summary>
        /// Policy ID array (Either StrategyIdList, CategoryIdList, or RuleIdList must be selected.)
        /// </summary>
        [JsonProperty("StrategyIdList")]
        public ulong?[] StrategyIdList{ get; set; }

        /// <summary>
        /// Baseline ID array (Either StrategyIdList, CategoryIdList, or RuleIdList must be selected.)
        /// </summary>
        [JsonProperty("CategoryIdList")]
        public ulong?[] CategoryIdList{ get; set; }

        /// <summary>
        /// Detection item ID array (Either StrategyIdList, CategoryIdList, or RuleIdList must be selected.)
        /// </summary>
        [JsonProperty("RuleIdList")]
        public ulong?[] RuleIdList{ get; set; }

        /// <summary>
        /// Not required when StrategyIdList is selected, but required in other cases.
        /// </summary>
        [JsonProperty("QuuidList")]
        public string[] QuuidList{ get; set; }

        /// <summary>
        /// Host UUID array
        /// </summary>
        [JsonProperty("UuidList")]
        public string[] UuidList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "StrategyIdList.", this.StrategyIdList);
            this.SetParamArraySimple(map, prefix + "CategoryIdList.", this.CategoryIdList);
            this.SetParamArraySimple(map, prefix + "RuleIdList.", this.RuleIdList);
            this.SetParamArraySimple(map, prefix + "QuuidList.", this.QuuidList);
            this.SetParamArraySimple(map, prefix + "UuidList.", this.UuidList);
        }
    }
}

