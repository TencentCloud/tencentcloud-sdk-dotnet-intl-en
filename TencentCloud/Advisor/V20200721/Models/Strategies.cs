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

namespace TencentCloud.Advisor.V20200721.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Strategies : AbstractModel
    {
        
        /// <summary>
        /// Assessment item ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StrategyId")]
        public ulong? StrategyId{ get; set; }

        /// <summary>
        /// Assessment item name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Assessment item description
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }

        /// <summary>
        /// Product ID corresponding to the assessment item
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }

        /// <summary>
        /// Product name corresponding to the assessment item
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProductDesc")]
        public string ProductDesc{ get; set; }

        /// <summary>
        /// Optimization suggestions for the assessment item
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Repair")]
        public string Repair{ get; set; }

        /// <summary>
        /// Category ID of the assessment item 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("GroupId")]
        public ulong? GroupId{ get; set; }

        /// <summary>
        /// Category name of the assessment item 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// Risk list of the assessment item 
        /// Note: This field may return null, indicating that no valid values can be obtained.
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

