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

namespace TencentCloud.Trocket.V20230308.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProductSKU : AbstractModel
    {
        
        /// <summary>
        /// Specifies the product type.
        /// Trial version.
        /// BASIC version.
        /// PRO, professional edition.
        /// PLATINUM edition.
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// Specification code
        /// </summary>
        [JsonProperty("SkuCode")]
        public string SkuCode{ get; set; }

        /// <summary>
        /// TPS limit
        /// </summary>
        [JsonProperty("TpsLimit")]
        public long? TpsLimit{ get; set; }

        /// <summary>
        /// Elastic TPS upper limit
        /// </summary>
        [JsonProperty("ScaledTpsLimit")]
        public long? ScaledTpsLimit{ get; set; }

        /// <summary>
        /// Default maximum number of topics.
        /// </summary>
        [JsonProperty("TopicNumLimit")]
        public long? TopicNumLimit{ get; set; }

        /// <summary>
        /// Maximum number of consumer groups
        /// </summary>
        [JsonProperty("GroupNumLimit")]
        public long? GroupNumLimit{ get; set; }

        /// <summary>
        /// Default message retention time, in hours
        /// </summary>
        [JsonProperty("DefaultRetention")]
        public long? DefaultRetention{ get; set; }

        /// <summary>
        /// Adjustable maximum message retention time, in hours
        /// </summary>
        [JsonProperty("RetentionUpperLimit")]
        public long? RetentionUpperLimit{ get; set; }

        /// <summary>
        /// Adjustable minimum message retention time, in hours
        /// </summary>
        [JsonProperty("RetentionLowerLimit")]
        public long? RetentionLowerLimit{ get; set; }

        /// <summary>
        /// Maximum delayed message duration, in hours
        /// </summary>
        [JsonProperty("MaxMessageDelay")]
        public long? MaxMessageDelay{ get; set; }

        /// <summary>
        /// Whether it is purchasable
        /// </summary>
        [JsonProperty("OnSale")]
        public bool? OnSale{ get; set; }

        /// <summary>
        /// Billing item information
        /// </summary>
        [JsonProperty("PriceTags")]
        public PriceTag[] PriceTags{ get; set; }

        /// <summary>
        /// Default maximum number of topics.
        /// </summary>
        [JsonProperty("TopicNumUpperLimit")]
        public long? TopicNumUpperLimit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "SkuCode", this.SkuCode);
            this.SetParamSimple(map, prefix + "TpsLimit", this.TpsLimit);
            this.SetParamSimple(map, prefix + "ScaledTpsLimit", this.ScaledTpsLimit);
            this.SetParamSimple(map, prefix + "TopicNumLimit", this.TopicNumLimit);
            this.SetParamSimple(map, prefix + "GroupNumLimit", this.GroupNumLimit);
            this.SetParamSimple(map, prefix + "DefaultRetention", this.DefaultRetention);
            this.SetParamSimple(map, prefix + "RetentionUpperLimit", this.RetentionUpperLimit);
            this.SetParamSimple(map, prefix + "RetentionLowerLimit", this.RetentionLowerLimit);
            this.SetParamSimple(map, prefix + "MaxMessageDelay", this.MaxMessageDelay);
            this.SetParamSimple(map, prefix + "OnSale", this.OnSale);
            this.SetParamArrayObj(map, prefix + "PriceTags.", this.PriceTags);
            this.SetParamSimple(map, prefix + "TopicNumUpperLimit", this.TopicNumUpperLimit);
        }
    }
}

