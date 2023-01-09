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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InquireCkafkaPriceRequest : AbstractModel
    {
        
        /// <summary>
        /// `standard`: Standard Edition; `profession`: Pro Edition
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
        /// Private network bandwidth in MB/sec, which is required when you purchase an instance.
        /// </summary>
        [JsonProperty("Bandwidth")]
        public long? Bandwidth{ get; set; }

        /// <summary>
        /// Disk type and size, which is required when you purchase an instance.
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
        /// The number of instance partitions to be purchased, which is required when you purchase an instance.
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
        /// Billing mode for public network bandwidth, which is required when you purchase public network bandwidth. Currently, public network bandwidth is only supported for Pro Edition.
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

