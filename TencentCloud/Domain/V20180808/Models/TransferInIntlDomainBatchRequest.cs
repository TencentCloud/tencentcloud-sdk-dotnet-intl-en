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

namespace TencentCloud.Domain.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TransferInIntlDomainBatchRequest : AbstractModel
    {
        
        /// <summary>
        /// The profile ID.
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// The transfer passwords for the domains.
        /// </summary>
        [JsonProperty("PassWords")]
        public string[] PassWords{ get; set; }

        /// <summary>
        /// The domains to be bulk transferred in.
        /// </summary>
        [JsonProperty("Domains")]
        public string[] Domains{ get; set; }

        /// <summary>
        /// The payment method. Valid value: `1` (account balance).
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
        /// Whether to enable the 60-day inter-registrar transfer lock.
        /// </summary>
        [JsonProperty("LockTransfer")]
        public bool? LockTransfer{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamArraySimple(map, prefix + "PassWords.", this.PassWords);
            this.SetParamArraySimple(map, prefix + "Domains.", this.Domains);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "TransferProhibition", this.TransferProhibition);
            this.SetParamSimple(map, prefix + "UpdateProhibition", this.UpdateProhibition);
            this.SetParamSimple(map, prefix + "LockTransfer", this.LockTransfer);
        }
    }
}

