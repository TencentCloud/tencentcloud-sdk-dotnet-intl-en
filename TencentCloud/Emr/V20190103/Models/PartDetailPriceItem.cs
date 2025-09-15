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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PartDetailPriceItem : AbstractModel
    {
        
        /// <summary>
        /// Types, including node: node (denoting node), rootDisk (denoting system disk), dataDisk (denoting cloud data disk), and metaDB.
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// Unit price (original price).
        /// </summary>
        [JsonProperty("Price")]
        public float? Price{ get; set; }

        /// <summary>
        /// Unit price (discounted price).
        /// </summary>
        [JsonProperty("RealCost")]
        public float? RealCost{ get; set; }

        /// <summary>
        /// Total price (discounted price).
        /// </summary>
        [JsonProperty("RealTotalCost")]
        public float? RealTotalCost{ get; set; }

        /// <summary>
        /// Discount.
        /// </summary>
        [JsonProperty("Policy")]
        public float? Policy{ get; set; }

        /// <summary>
        /// Quantity.
        /// </summary>
        [JsonProperty("GoodsNum")]
        public long? GoodsNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "Price", this.Price);
            this.SetParamSimple(map, prefix + "RealCost", this.RealCost);
            this.SetParamSimple(map, prefix + "RealTotalCost", this.RealTotalCost);
            this.SetParamSimple(map, prefix + "Policy", this.Policy);
            this.SetParamSimple(map, prefix + "GoodsNum", this.GoodsNum);
        }
    }
}

