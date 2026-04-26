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

namespace TencentCloud.Advisor.V20200721.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Strategies : AbstractModel
    {
        
        /// <summary>
        /// Assessment item ID
        /// </summary>
        [JsonProperty("StrategyId")]
        public ulong? StrategyId{ get; set; }

        /// <summary>
        /// Assessment item name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Assessment item description.
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }

        /// <summary>
        /// Product ID corresponding to the assessment item.
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }

        /// <summary>
        /// Assessment item corresponding product name.
        /// </summary>
        [JsonProperty("ProductDesc")]
        public string ProductDesc{ get; set; }

        /// <summary>
        /// Specifies optimization suggestions for the assessment item.
        /// </summary>
        [JsonProperty("Repair")]
        public string Repair{ get; set; }

        /// <summary>
        /// Assessment item category ID.
        /// </summary>
        [JsonProperty("GroupId")]
        public ulong? GroupId{ get; set; }

        /// <summary>
        /// Specifies the category name of the assessment item.
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// Specifies the evaluation item risk list.
        /// </summary>
        [JsonProperty("Conditions")]
        public Conditions[] Conditions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StrategyId", this.StrategyId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
            this.SetParamSimple(map, prefix + "Product", this.Product);
            this.SetParamSimple(map, prefix + "ProductDesc", this.ProductDesc);
            this.SetParamSimple(map, prefix + "Repair", this.Repair);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamArrayObj(map, prefix + "Conditions.", this.Conditions);
        }
    }
}

