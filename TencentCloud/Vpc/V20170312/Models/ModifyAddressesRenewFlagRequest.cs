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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAddressesRenewFlagRequest : AbstractModel
    {
        
        /// <summary>
        /// List of unique EIP IDs, for example, eip-xxxx.
        /// </summary>
        [JsonProperty("AddressIds")]
        public string[] AddressIds{ get; set; }

        /// <summary>
        /// Auto-renewal flag.
        /// <ul style="margin:0">
        /// <li>NOTIFY_AND_AUTO_RENEW: Notify upon expiration and automatically renew.</li>
        /// <li>NOTIFY_AND_MANUAL_RENEW: Notify upon expiration but do not automatically renew.</li>
        /// <li>DISABLE_NOTIFY_AND_MANUAL_RENEW: Do not notify upon expiration and do not automatically renew.</li>
        /// </ul>
        /// If this parameter is set to NOTIFY_AND_AUTO_RENEW and the account balance is sufficient, the instance will be automatically renewed on a monthly basis after expiration.
        /// </summary>
        [JsonProperty("RenewFlag")]
        public string RenewFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "AddressIds.", this.AddressIds);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
        }
    }
}

