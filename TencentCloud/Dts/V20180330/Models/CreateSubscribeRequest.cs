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

namespace TencentCloud.Dts.V20180330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSubscribeRequest : AbstractModel
    {
        
        /// <summary>
        /// Subscribed database type. Currently, MySQL is supported
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }

        /// <summary>
        /// Instance billing mode, which is always 1 (hourly billing),
        /// </summary>
        [JsonProperty("PayType")]
        public long? PayType{ get; set; }

        /// <summary>
        /// Purchase duration in months, which is required if `PayType` is 0. Maximum value: 120 (this field is not required of global site users and is better to be hidden)
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// Quantity. Default value: 1. Maximum value: 10
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// Whether to auto-renew. Default value: 0. This flag does not take effect for hourly billed instances (this field should be hidden from global site users)
        /// </summary>
        [JsonProperty("AutoRenew")]
        public long? AutoRenew{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Product", this.Product);
            this.SetParamSimple(map, prefix + "PayType", this.PayType);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "AutoRenew", this.AutoRenew);
        }
    }
}

