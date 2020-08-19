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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReservedInstances : AbstractModel
    {
        
        /// <summary>
        /// The ID of the purchased reserved instance, taking the form 650c138f-ae7e-4750-952a-96841d6e9fc1.
        /// </summary>
        [JsonProperty("ReservedInstancesId")]
        public string ReservedInstancesId{ get; set; }

        /// <summary>
        /// The type of the reserved instance. For example, S3.MEDIUM4.
        /// Returned value: <a href="https://intl.cloud.tencent.com/document/product/213/11518?from_cn_redirect=1">list of reserved instance types</a>
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// Availability zones in which the reserved instance can be purchased. For example, "ap-guangzhou-1".
        /// Returned values: <a href="https://intl.cloud.tencent.com/document/product/213/6091?from_cn_redirect=1">list of availability zones</a>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Start time of the reserved instance billing, taking the form of 2019-10-23 00:00:00.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End time of the reserved instance, taking the form of 2019-10-23 00:00:00
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// The **validity** of the reserved instance in seconds, which is the purchased usage period. For example, 31536000.
        /// Measurement unit: second.
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// The number of reserved instances that have been purchased. For example, 10.
        /// </summary>
        [JsonProperty("InstanceCount")]
        public long? InstanceCount{ get; set; }

        /// <summary>
        /// The operating system of the reserved instance. For example, "linux".
        /// Returned value: linux.
        /// </summary>
        [JsonProperty("ProductDescription")]
        public string ProductDescription{ get; set; }

        /// <summary>
        /// The status of the reserved instance. For example, "active".
        /// Returned value: "active" (created) | "pending" (waiting to be created) | "retired" (expired).
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// The currency in which the reserved instance is billed. The ISO 4217 standard currency codes are used. For example, USD.
        /// Returned value: USD.
        /// </summary>
        [JsonProperty("CurrencyCode")]
        public string CurrencyCode{ get; set; }

        /// <summary>
        /// The payment method of the reserved instance. For example, "All Upfront".
        /// Returned value: All Upfront.
        /// </summary>
        [JsonProperty("OfferingType")]
        public string OfferingType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReservedInstancesId", this.ReservedInstancesId);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "InstanceCount", this.InstanceCount);
            this.SetParamSimple(map, prefix + "ProductDescription", this.ProductDescription);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "CurrencyCode", this.CurrencyCode);
            this.SetParamSimple(map, prefix + "OfferingType", this.OfferingType);
        }
    }
}

