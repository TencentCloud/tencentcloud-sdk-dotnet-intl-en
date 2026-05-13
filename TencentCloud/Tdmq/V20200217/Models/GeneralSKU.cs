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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GeneralSKU : AbstractModel
    {
        
        /// <summary>
        /// Specification flag
        /// </summary>
        [JsonProperty("SkuCode")]
        public string SkuCode{ get; set; }

        /// <summary>
        /// available for sale
        /// </summary>
        [JsonProperty("OnSale")]
        public bool? OnSale{ get; set; }

        /// <summary>
        /// TPS limit
        /// </summary>
        [JsonProperty("TpsLimit")]
        public long? TpsLimit{ get; set; }

        /// <summary>
        /// Number of topics free quota
        /// </summary>
        [JsonProperty("TopicNumLimit")]
        public long? TopicNumLimit{ get; set; }

        /// <summary>
        /// Number of topics cap
        /// </summary>
        [JsonProperty("TopicNumUpperLimit")]
        public long? TopicNumUpperLimit{ get; set; }

        /// <summary>
        /// Billing item information
        /// </summary>
        [JsonProperty("PriceTags")]
        public PriceTag[] PriceTags{ get; set; }

        /// <summary>
        /// Number of storage nodes
        /// </summary>
        [JsonProperty("NodeCount")]
        public long? NodeCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SkuCode", this.SkuCode);
            this.SetParamSimple(map, prefix + "OnSale", this.OnSale);
            this.SetParamSimple(map, prefix + "TpsLimit", this.TpsLimit);
            this.SetParamSimple(map, prefix + "TopicNumLimit", this.TopicNumLimit);
            this.SetParamSimple(map, prefix + "TopicNumUpperLimit", this.TopicNumUpperLimit);
            this.SetParamArrayObj(map, prefix + "PriceTags.", this.PriceTags);
            this.SetParamSimple(map, prefix + "NodeCount", this.NodeCount);
        }
    }
}

