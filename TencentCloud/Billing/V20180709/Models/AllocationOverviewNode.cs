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

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AllocationOverviewNode : AbstractModel
    {
        
        /// <summary>
        /// Cost allocation unit ID
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// Name of a cost allocation unit
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Unique identifier of a cost allocation unit
        /// </summary>
        [JsonProperty("TreeNodeUniqKey")]
        public string TreeNodeUniqKey{ get; set; }

        /// <summary>
        /// Billing unit including a rule flag
        /// 0 - No rule exists.
        /// 1 - Both collection rules and allocation rules exist.
        /// 2 - Only collection rules exist.
        /// 3 - Only allocation rules exist.
        /// </summary>
        [JsonProperty("Symbol")]
        public ulong? Symbol{ get; set; }

        /// <summary>
        /// Detailed monthly overview of a sub-unit
        /// </summary>
        [JsonProperty("Children")]
        public AllocationOverviewNode[] Children{ get; set; }

        /// <summary>
        /// Monthly overview amount details of a cost allocation bill
        /// </summary>
        [JsonProperty("Detail")]
        public AllocationMonthOverviewDetail Detail{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "TreeNodeUniqKey", this.TreeNodeUniqKey);
            this.SetParamSimple(map, prefix + "Symbol", this.Symbol);
            this.SetParamArrayObj(map, prefix + "Children.", this.Children);
            this.SetParamObj(map, prefix + "Detail.", this.Detail);
        }
    }
}

