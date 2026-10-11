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

    public class InquiryPriceUpdateInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// Time unit for the configuration change. Valid values:
        /// <li>s: second. When PayMode is set to 0, TimeUnit can only be set to s.</li>
        /// <li>m: month. When PayMode is set to 1, TimeUnit can only be set to m.</li>
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// Configuration change duration, which is used together with TimeUnit.
        /// <li>When TimeUnit is set to s, this parameter can only be set to 3600, indicating a pay-as-you-go instance.</li>
        /// <li>When TimeUnit is set to m, the number entered for this parameter indicates the purchase duration of a yearly/monthly subscription instance. For example, the value 1 indicates one month.</li>
        /// </summary>
        [JsonProperty("TimeSpan")]
        public ulong? TimeSpan{ get; set; }

        /// <summary>
        /// Instance billing mode. Valid values:
        /// <li>0: pay-as-you-go</li>
        /// <li>1: monthly subscription</li>
        /// </summary>
        [JsonProperty("PayMode")]
        public ulong? PayMode{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("UpdateSpec")]
        public UpdateInstanceSettings UpdateSpec{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Placement")]
        public Placement Placement{ get; set; }

        /// <summary>
        /// Currency type. Valid values:
        /// <li>CNY: RMB</li>
        /// </summary>
        [JsonProperty("Currency")]
        public string Currency{ get; set; }

        /// <summary>
        /// ID list of resources modified in batches.
        /// </summary>
        [JsonProperty("ResourceIdList")]
        public string[] ResourceIdList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamObj(map, prefix + "UpdateSpec.", this.UpdateSpec);
            this.SetParamObj(map, prefix + "Placement.", this.Placement);
            this.SetParamSimple(map, prefix + "Currency", this.Currency);
            this.SetParamArraySimple(map, prefix + "ResourceIdList.", this.ResourceIdList);
        }
    }
}

