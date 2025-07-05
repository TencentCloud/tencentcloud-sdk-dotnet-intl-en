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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReservedInstances : AbstractModel
    {
        
        /// <summary>
        /// (This field has been deprecated. ReservedInstanceId is recommended.) IDs of purchased reserved instances. For example, ri-rtbh4han.
        /// </summary>
        [JsonProperty("ReservedInstancesId")]
        [System.Obsolete]
        public string ReservedInstancesId{ get; set; }

        /// <summary>
        /// Specifications of reserved instances. For example, S3.MEDIUM4.
        /// Return values: <a href="https://intl.cloud.tencent.com/document/product/213/11518?from_cn_redirect=1">Reserved instance specification list.</a>
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// Availability zones in which reserved instances can be purchased. For example, ap-guangzhou-1.
        /// Return values: <a href="https://intl.cloud.tencent.com/document/product/213/6091?from_cn_redirect=1">Availability zone list.</a>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Billing start time of reserved instances. For example, 1949-10-01 00:00:00.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Billing end time of reserved instances. For example, 1949-10-01 00:00:00.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Validity periods of reserved instances, which is the purchase duration of reserved instances. For example, 31536000.
        /// Unit: second.
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// Number of purchased reserved instances. For example, 10.
        /// </summary>
        [JsonProperty("InstanceCount")]
        public long? InstanceCount{ get; set; }

        /// <summary>
        /// Platform descriptions (operating systems) of reserved instances. For example, linux.
        /// Return value: linux.
        /// </summary>
        [JsonProperty("ProductDescription")]
        public string ProductDescription{ get; set; }

        /// <summary>
        /// Statuses of purchased reserved instances. For example: active.
        /// Return values: active (created) | pending (waiting to be created) | retired (expired).
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// Billing currencies of purchasable reserved instances. Use standard currency codes defined in ISO 4217. For example, USD.
        /// Return value: USD.
        /// </summary>
        [JsonProperty("CurrencyCode")]
        public string CurrencyCode{ get; set; }

        /// <summary>
        /// Payment types of reserved instances. For example, All Upfront.
        /// Return value: All Upfront (fully prepaid).
        /// </summary>
        [JsonProperty("OfferingType")]
        public string OfferingType{ get; set; }

        /// <summary>
        /// Types of reserved instances. For example, S3.
        /// Return values: <a href="https://intl.cloud.tencent.com/document/product/213/11518?from_cn_redirect=1">Reserved instance type list.</a>
        /// </summary>
        [JsonProperty("InstanceFamily")]
        public string InstanceFamily{ get; set; }

        /// <summary>
        /// IDs of purchased reserved instances. For example, ri-rtbh4han.
        /// </summary>
        [JsonProperty("ReservedInstanceId")]
        public string ReservedInstanceId{ get; set; }

        /// <summary>
        /// Display names of reserved instances. For example, riname-01.
        /// </summary>
        [JsonProperty("ReservedInstanceName")]
        public string ReservedInstanceName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
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
            this.SetParamSimple(map, prefix + "InstanceFamily", this.InstanceFamily);
            this.SetParamSimple(map, prefix + "ReservedInstanceId", this.ReservedInstanceId);
            this.SetParamSimple(map, prefix + "ReservedInstanceName", this.ReservedInstanceName);
        }
    }
}

