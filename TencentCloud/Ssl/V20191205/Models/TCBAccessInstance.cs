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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TCBAccessInstance : AbstractModel
    {
        
        /// <summary>
        /// Domain
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Status.
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Unified domain status
        /// </summary>
        [JsonProperty("UnionStatus")]
        public long? UnionStatus{ get; set; }

        /// <summary>
        /// Whether it is preempted. Preemption means the domain name is bound to another environment and must be unbound or rebound.
        /// </summary>
        [JsonProperty("IsPreempted")]
        public bool? IsPreempted{ get; set; }

        /// <summary>
        /// icp blocklist ban status. 0 - Not blocked. 1 - Blocked.
        /// </summary>
        [JsonProperty("ICPStatus")]
        public long? ICPStatus{ get; set; }

        /// <summary>
        /// Bound Certificate ID
        /// </summary>
        [JsonProperty("OldCertificateId")]
        public string OldCertificateId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "UnionStatus", this.UnionStatus);
            this.SetParamSimple(map, prefix + "IsPreempted", this.IsPreempted);
            this.SetParamSimple(map, prefix + "ICPStatus", this.ICPStatus);
            this.SetParamSimple(map, prefix + "OldCertificateId", this.OldCertificateId);
        }
    }
}

