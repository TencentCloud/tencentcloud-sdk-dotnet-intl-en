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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VulFixStatusItem : AbstractModel
    {
        
        /// <summary>
        /// Vulnerability ID (empty for KB patch fix tasks)
        /// </summary>
        [JsonProperty("VulId")]
        public long? VulId{ get; set; }

        /// <summary>
        /// Patch ID (empty for vulnerability repair tasks)
        /// </summary>
        [JsonProperty("KBId")]
        public long? KBId{ get; set; }

        /// <summary>
        /// Vulnerability name or KB patch name
        /// </summary>
        [JsonProperty("VulName")]
        public string VulName{ get; set; }

        /// <summary>
        /// Remediation status of the vulnerability
        /// Enumeration value:
        /// 0: In remediation
        /// 1: All successful
        /// 2: partially failed
        /// 3: All failed
        /// </summary>
        [JsonProperty("FixStatus")]
        public long? FixStatus{ get; set; }

        /// <summary>
        /// Total hosts associated with the vulnerability/KB patch
        /// </summary>
        [JsonProperty("HostCount")]
        public long? HostCount{ get; set; }

        /// <summary>
        /// Number of hosts successfully fixed by the vulnerability/KB patch
        /// </summary>
        [JsonProperty("SuccessHostCount")]
        public long? SuccessHostCount{ get; set; }

        /// <summary>
        /// Number of hosts failed to be fixed for the vulnerability/KB patch
        /// </summary>
        [JsonProperty("FailHostCount")]
        public long? FailHostCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VulId", this.VulId);
            this.SetParamSimple(map, prefix + "KBId", this.KBId);
            this.SetParamSimple(map, prefix + "VulName", this.VulName);
            this.SetParamSimple(map, prefix + "FixStatus", this.FixStatus);
            this.SetParamSimple(map, prefix + "HostCount", this.HostCount);
            this.SetParamSimple(map, prefix + "SuccessHostCount", this.SuccessHostCount);
            this.SetParamSimple(map, prefix + "FailHostCount", this.FailHostCount);
        }
    }
}

