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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InquireCkafkaPriceRequest : AbstractModel
    {
        
        /// <summary>
        /// Chinese site standard version fill in standards2 international site standard version fill in standard pro edition fill in profession advanced edition fill in premium.
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// Billing mode for instance purchase/renewal. If this parameter is left empty when you purchase an instance, the fees for one month under the monthly subscription mode will be displayed by default.
        /// </summary>
        [JsonProperty("InstanceChargeParam")]
        public InstanceChargeParam InstanceChargeParam{ get; set; }

        /// <summary>
        /// The number of instances to be purchased or renewed. If this parameter is left empty, the default value is `1`.
        /// </summary>
        [JsonProperty("InstanceNum")]
        public long? InstanceNum{ get; set; }

        /// <summary>
        /// Specifies the internal network bandwidth size of the instance, in MB/s (required when purchased; bandwidth information is required for pro edition/advanced edition inquiries).
        /// </summary>
        [JsonProperty("Bandwidth")]
        public long? Bandwidth{ get; set; }

        /// <summary>
        /// Specifies the purchase type and size of the hard disk of the instance. required when purchased. disk information is required for pro edition or advanced edition inquiries.
        /// </summary>
        [JsonProperty("InquiryDiskParam")]
        public InquiryDiskParam InquiryDiskParam{ get; set; }

        /// <summary>
        /// Message retention period in hours, which is required when you purchase an instance.
        /// </summary>
        [JsonProperty("MessageRetention")]
        public long? MessageRetention{ get; set; }

        /// <summary>
        /// The number of instance topics to be purchased, which is required when you purchase an instance.
        /// </summary>
        [JsonProperty("Topic")]
        public long? Topic{ get; set; }

        /// <summary>
        /// Number of partitions for instance purchase, unit: unit (required when purchased; bandwidth information required for pro edition/advanced edition inquiry).
        /// Partition upper limit. maximum value of 40000. step length of 100.
        /// Specifies the specifications and limits that can be viewed through the following link: https://www.tencentcloud.comom/document/product/597/122563.?from_cn_redirect=1
        /// </summary>
        [JsonProperty("Partition")]
        public long? Partition{ get; set; }

        /// <summary>
        /// The region for instance purchase, which can be obtained via the `DescribeCkafkaZone` API.
        /// </summary>
        [JsonProperty("ZoneIds")]
        public long?[] ZoneIds{ get; set; }

        /// <summary>
        /// Operation type flag. `purchase`: Making new purchases; `renew`: Renewing an instance. The default value is `purchase` if this parameter is left empty.
        /// </summary>
        [JsonProperty("CategoryAction")]
        public string CategoryAction{ get; set; }

        /// <summary>
        /// This field is not required.
        /// </summary>
        [JsonProperty("BillType")]
        public string BillType{ get; set; }

        /// <summary>
        /// Public network bandwidth billing mode. currently only the pro edition supports public network bandwidth. required when purchasing public network bandwidth. value must be a multiple of 3.
        /// </summary>
        [JsonProperty("PublicNetworkParam")]
        public InquiryPublicNetworkParam PublicNetworkParam{ get; set; }

        /// <summary>
        /// ID of the instance to be renewed, which is required when you renew an instance.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamObj(map, prefix + "InstanceChargeParam.", this.InstanceChargeParam);
            this.SetParamSimple(map, prefix + "InstanceNum", this.InstanceNum);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamObj(map, prefix + "InquiryDiskParam.", this.InquiryDiskParam);
            this.SetParamSimple(map, prefix + "MessageRetention", this.MessageRetention);
            this.SetParamSimple(map, prefix + "Topic", this.Topic);
            this.SetParamSimple(map, prefix + "Partition", this.Partition);
            this.SetParamArraySimple(map, prefix + "ZoneIds.", this.ZoneIds);
            this.SetParamSimple(map, prefix + "CategoryAction", this.CategoryAction);
            this.SetParamSimple(map, prefix + "BillType", this.BillType);
            this.SetParamObj(map, prefix + "PublicNetworkParam.", this.PublicNetworkParam);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
        }
    }
}

