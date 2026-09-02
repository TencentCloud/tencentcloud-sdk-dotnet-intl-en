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
        /// Plugin installation status (upper-level aggregation)
        /// Enumeration value:
        /// NONE: not installed
        /// INSTALLING: installing
        /// INSTALLED: installed
        /// INSTALL_FAIL: installation failure
        /// </summary>
        [JsonProperty("InstallStatus")]
        public string InstallStatus{ get; set; }

        /// <summary>
        /// Plug-in installation sub-status. The value corresponds to InstallStatus: empty string when not installed (InstallStatus=UNINSTALL); SUCCESS when installation is successful (InstallStatus=INSTALLED); specific failure reason when installation fails (InstallStatus=INSTALL_FAIL).
        /// Enumeration value:
        /// NOT_SUPPORT: The environment does not support it
        /// CONTAINER_NOT_FOUND: container does not exist.
        /// REQUIRE_RESTART: restart required
        /// CA_FAILED: CA failed
        /// EBPF_FAILED: eBPF failure
        /// IPTABLE_FAILED: iptables failed.
        /// REDIRECT_FAILED: Traffic redirection failed.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Status copywriting (an internationalized description derived from Status based on the request language)
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// Recent activity time of the plug-in
        /// Parameter format: YYYY-MM-DDTHH:mm:ssZ (ISO8601 format)
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

