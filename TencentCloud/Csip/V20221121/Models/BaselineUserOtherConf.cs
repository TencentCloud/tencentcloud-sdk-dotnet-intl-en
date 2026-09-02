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

    public class BaselineUserOtherConf : AbstractModel
    {
        
        /// <summary>
        /// <p>Whether to allow the Group Administrator to sync the baseline configuration to this account. true means allowed, and false means not allowed.</p>
        /// </summary>
        [JsonProperty("AllowSync")]
        public bool? AllowSync{ get; set; }

        /// <summary>
        /// <p>Whether to automatically clear the historical risk results of an asset when it goes offline. true: clear; false: retain.</p>
        /// </summary>
        [JsonProperty("CleanRiskWhenOffline")]
        public bool? CleanRiskWhenOffline{ get; set; }

        /// <summary>
        /// <p>Timeout period for a single scan by the Agent, in seconds. Value ranges from 60 to 86400. Default: 1800.</p>
        /// </summary>
        [JsonProperty("AgentScanTimeout")]
        public ulong? AgentScanTimeout{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AllowSync", this.AllowSync);
            this.SetParamSimple(map, prefix + "CleanRiskWhenOffline", this.CleanRiskWhenOffline);
            this.SetParamSimple(map, prefix + "AgentScanTimeout", this.AgentScanTimeout);
        }
    }
}

