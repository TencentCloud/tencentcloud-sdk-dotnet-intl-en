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

    public class TrafficPluginState : AbstractModel
    {
        
        /// <summary>
        /// Plugin installation status (upper layer aggregation)
        /// Enumeration value:
        /// NONE: Not installed
        /// INSTALLING
        /// INSTALLED: Installed
        /// INSTALL_FAIL: Installation failure
        /// </summary>
        [JsonProperty("InstallStatus")]
        public string InstallStatus{ get; set; }

        /// <summary>
        /// Plugin installation sub-status. The value corresponds to InstallStatus: empty string when not installed (InstallStatus=UNINSTALL); SUCCESS when successfully installed (InstallStatus=INSTALLED); specific failure reason when installation failure (InstallStatus=INSTALL_FAIL).
        /// Enumeration value:
        /// NOT_SUPPORT: Unsupported environment
        /// CONTAINER_NOT_FOUND: Container does not exist.
        /// RESTART required
        /// CA_FAILED: CA failed
        /// EBPF_FAILED: eBPF failed
        /// IPTABLE_FAILED: iptables failed.
        /// REDIRECT_FAILED: Traffic redirection failed.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Status copywriting (internationalization description derived from Status based on request language)
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// Recent activity time of the plug-in
        /// Parameter format: YYYY-MM-DDTHH:mm:ssZ (ISO8601 format).
        /// </summary>
        [JsonProperty("ActivityTime")]
        public string ActivityTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstallStatus", this.InstallStatus);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "ActivityTime", this.ActivityTime);
        }
    }
}

