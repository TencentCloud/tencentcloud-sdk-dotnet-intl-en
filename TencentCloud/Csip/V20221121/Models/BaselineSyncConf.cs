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

    public class BaselineSyncConf : AbstractModel
    {
        
        /// <summary>
        /// <p>Whether to automatically sync the baseline configuration to member accounts. true indicates enabled, false indicates disabled.</p>
        /// </summary>
        [JsonProperty("AutoSync")]
        public bool? AutoSync{ get; set; }

        /// <summary>
        /// <p>List of Appids of target member accounts for automatic synchronization. This parameter is valid only when AutoSync=true.</p>
        /// </summary>
        [JsonProperty("TargetAppidList")]
        public ulong?[] TargetAppidList{ get; set; }

        /// <summary>
        /// <p>User Configuration List</p>
        /// </summary>
        [JsonProperty("UserConfList")]
        public UserConfSyncStatus[] UserConfList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoSync", this.AutoSync);
            this.SetParamArraySimple(map, prefix + "TargetAppidList.", this.TargetAppidList);
            this.SetParamArrayObj(map, prefix + "UserConfList.", this.UserConfList);
        }
    }
}

