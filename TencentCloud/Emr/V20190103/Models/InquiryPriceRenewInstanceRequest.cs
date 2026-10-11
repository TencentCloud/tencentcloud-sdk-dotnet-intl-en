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

    public class InquiryPriceRenewInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// Duration of instance renewal. It is used together with TimeUnit. 1 indicates renewal for one month.
        /// </summary>
        [JsonProperty("TimeSpan")]
        public ulong? TimeSpan{ get; set; }

        /// <summary>
        /// Instance billing mode. Only the value 1 is supported, indicating yearly/monthly subscription.
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// Resource ID list for nodes pending renewal. Resource ID format: emr-vm-xxxxxxxx. You can query valid resource IDs by logging in to the [console](https://console.cloud.tencent.com/emr).
        /// </summary>
        [JsonProperty("ResourceIds")]
        public string[] ResourceIds{ get; set; }

        /// <summary>
        /// Time unit for instance renewal. Valid values:
        /// <li>m: indicates month.</li>
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// Currency type. Valid values:
        /// <li>CNY: RMB</li>
        /// </summary>
        [JsonProperty("Currency")]
        public string Currency{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Placement")]
        public Placement Placement{ get; set; }

        /// <summary>
        /// Whether to convert from pay-as-you-go to yearly/monthly subscription. Valid values: 0 (no) and 1 (yes).
        /// </summary>
        [JsonProperty("ModifyPayMode")]
        public long? ModifyPayMode{ get; set; }

        /// <summary>
        /// Whether to return the renewal price for each node.
        /// </summary>
        [JsonProperty("NeedDetail")]
        public bool? NeedDetail{ get; set; }

        /// <summary>
        /// Cluster ID. Specify this parameter if you need renewal information for all yearly/monthly subscription nodes in the cluster.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamArraySimple(map, prefix + "ResourceIds.", this.ResourceIds);
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamSimple(map, prefix + "Currency", this.Currency);
            this.SetParamObj(map, prefix + "Placement.", this.Placement);
            this.SetParamSimple(map, prefix + "ModifyPayMode", this.ModifyPayMode);
            this.SetParamSimple(map, prefix + "NeedDetail", this.NeedDetail);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
        }
    }
}

