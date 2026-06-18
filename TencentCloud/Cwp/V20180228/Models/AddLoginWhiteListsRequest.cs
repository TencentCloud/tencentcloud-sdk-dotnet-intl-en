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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddLoginWhiteListsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Unusual-login allowlist entry</p>
        /// </summary>
        [JsonProperty("HostLoginWhiteObj")]
        public HostLoginWhiteObj HostLoginWhiteObj{ get; set; }

        /// <summary>
        /// <p>Event sync processing method:<br>"" -- No action<br>"All" -- Add all event records matching this configuration to the allowlist<br>"Id" -- Add the event record corresponding to EventId to the allowlist</p>
        /// </summary>
        [JsonProperty("ProcessType")]
        public string ProcessType{ get; set; }

        /// <summary>
        /// <p>Unusual-login event ID. This parameter is required when ProcessType is Id.</p>
        /// </summary>
        [JsonProperty("EventId")]
        public ulong? EventId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "HostLoginWhiteObj.", this.HostLoginWhiteObj);
            this.SetParamSimple(map, prefix + "ProcessType", this.ProcessType);
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
        }
    }
}

