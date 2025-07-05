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

namespace TencentCloud.Domain.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateIntlDomainBatchRequest : AbstractModel
    {
        
        /// <summary>
        /// The profile ID.
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// The purchase period (years) of the domain. Value range: [1-10]
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// The domains (maximum 4,000) to purchase.
        /// </summary>
        [JsonProperty("Domains")]
        public string[] Domains{ get; set; }

        /// <summary>
        /// The payment method. Valid values: `0` (online payment), `1` (account balance), `2` (package), `3` (offline settlement).
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// Whether to enable auto-renewal.
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public bool? AutoRenewFlag{ get; set; }

        /// <summary>
        /// Whether to enable the transfer prohibition lock.
        /// </summary>
        [JsonProperty("TransferProhibition")]
        public bool? TransferProhibition{ get; set; }

        /// <summary>
        /// Whether to enable the update prohibition lock.
        /// </summary>
        [JsonProperty("UpdateProhibition")]
        public bool? UpdateProhibition{ get; set; }

        /// <summary>
        /// The custom DNS servers
        /// </summary>
        [JsonProperty("CustomDns")]
        public string[] CustomDns{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamArraySimple(map, prefix + "Domains.", this.Domains);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "TransferProhibition", this.TransferProhibition);
            this.SetParamSimple(map, prefix + "UpdateProhibition", this.UpdateProhibition);
            this.SetParamArraySimple(map, prefix + "CustomDns.", this.CustomDns);
        }
    }
}

