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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSubscribeRequest : AbstractModel
    {
        
        /// <summary>
        /// Subscription database type. Currently, cynosdbmysql, mariadb, mongodb, mysql, percona, tdpg, and tdsqlpercona are supported.
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }

        /// <summary>
        /// Payment method. Valid values: 0 (monthly subscription); 1 (pay-as-you-go).
        /// </summary>
        [JsonProperty("PayType")]
        public long? PayType{ get; set; }

        /// <summary>
        /// Purchase duration. This field needs to be filled in when the payType is monthly subscription. The unit is month. Value range: 1-120. Default value: 1.
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// Whether to renew automatically. This field needs to be filled in when the payType is monthly subscription. Valid values: 0 (auto-renewal disabled); 1 (auto-renewal enabled). Automatic renewal is not performed by default. This flag is invalid for pay-as-you-go.
        /// </summary>
        [JsonProperty("AutoRenew")]
        public long? AutoRenew{ get; set; }

        /// <summary>
        /// Quantity. Default value: 1. Maximum value: 10.
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// Instance resource tags
        /// </summary>
        [JsonProperty("Tags")]
        public TagItem[] Tags{ get; set; }

        /// <summary>
        /// Custom task name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Product", this.Product);
            this.SetParamSimple(map, prefix + "PayType", this.PayType);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "AutoRenew", this.AutoRenew);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Name", this.Name);
        }
    }
}

