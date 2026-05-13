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

namespace TencentCloud.Mqtt.V20240516.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProductSkuItem : AbstractModel
    {
        
        /// <summary>
        /// Specification type
        /// BASIC: Basic Edition.
        /// PRO: Professional Edition
        /// PLATINUM: Platinum version
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// Specification code
        /// </summary>
        [JsonProperty("SkuCode")]
        public string SkuCode{ get; set; }

        /// <summary>
        /// whether required or not
        /// 1: available for sale
        /// 0: unsellable
        /// </summary>
        [JsonProperty("OnSale")]
        public bool? OnSale{ get; set; }

        /// <summary>
        /// Limit on the number of topics.
        /// </summary>
        [JsonProperty("TopicNumLimit")]
        public long? TopicNumLimit{ get; set; }

        /// <summary>
        /// Sum of the quantity of messages produced and consumed per second in an MQTT cluster.
        /// </summary>
        [JsonProperty("TpsLimit")]
        public long? TpsLimit{ get; set; }

        /// <summary>
        /// Number of client connections
        /// </summary>
        [JsonProperty("ClientNumLimit")]
        public long? ClientNumLimit{ get; set; }

        /// <summary>
        /// Maximum number of subscriptions for a single client
        /// </summary>
        [JsonProperty("MaxSubscriptionPerClient")]
        public long? MaxSubscriptionPerClient{ get; set; }

        /// <summary>
        /// Number of authorization rules
        /// </summary>
        [JsonProperty("AuthorizationPolicyLimit")]
        public long? AuthorizationPolicyLimit{ get; set; }

        /// <summary>
        /// Billing item information
        /// </summary>
        [JsonProperty("PriceTags")]
        public PriceTag[] PriceTags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "SkuCode", this.SkuCode);
            this.SetParamSimple(map, prefix + "OnSale", this.OnSale);
            this.SetParamSimple(map, prefix + "TopicNumLimit", this.TopicNumLimit);
            this.SetParamSimple(map, prefix + "TpsLimit", this.TpsLimit);
            this.SetParamSimple(map, prefix + "ClientNumLimit", this.ClientNumLimit);
            this.SetParamSimple(map, prefix + "MaxSubscriptionPerClient", this.MaxSubscriptionPerClient);
            this.SetParamSimple(map, prefix + "AuthorizationPolicyLimit", this.AuthorizationPolicyLimit);
            this.SetParamArrayObj(map, prefix + "PriceTags.", this.PriceTags);
        }
    }
}

