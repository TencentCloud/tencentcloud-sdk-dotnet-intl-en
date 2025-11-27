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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Quota : AbstractModel
    {
        
        /// <summary>
        /// Quota name. value range:.
        /// <Li>TOTAL_OPEN_CLB_QUOTA: specifies the public network clb quota in the current region for the user.</li>.
        /// <Li>TOTAL_INTERNAL_CLB_QUOTA: specifies the private network clb quota in the current region for the user.</li>.
        /// <li>TOTAL_LISTENER_QUOTA: specifies the LISTENER QUOTA under a CLB.</li>.
        /// <Li>TOTAL_LISTENER_RULE_QUOTA: specifies the forwarding rule quota under a listener.</li>.
        /// <Li>TOTAL_TARGET_BIND_QUOTA: specifies the quota of devices that can be bound to a forwarding rule.</li>.
        /// <li> TOTAL_SNAT_IP_QUOTA: specifies the SNAT IP QUOTA for a cross-regional 2.0 CLB instance. </li>.
        /// <Li>TOTAL_ISP_CLB_QUOTA: specifies the quota of triple-isp (cmcc/cucc/ctcc) clb instances in the current region for the user.</li>.
        /// <li>TOTAL_FULL_PORT_RANGE_LISTENER_QUOTA: specifies the QUOTA of single-protocol FULL PORT RANGE listeners for a CLB instance.</li>.
        /// </summary>
        [JsonProperty("QuotaId")]
        public string QuotaId{ get; set; }

        /// <summary>
        /// Currently used quantity. If it is `null`, it is meaningless.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("QuotaCurrent")]
        public long? QuotaCurrent{ get; set; }

        /// <summary>
        /// Quota limit.
        /// </summary>
        [JsonProperty("QuotaLimit")]
        public long? QuotaLimit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "QuotaId", this.QuotaId);
            this.SetParamSimple(map, prefix + "QuotaCurrent", this.QuotaCurrent);
            this.SetParamSimple(map, prefix + "QuotaLimit", this.QuotaLimit);
        }
    }
}

