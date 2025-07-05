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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NetworkCustomPolicy : AbstractModel
    {
        
        /// <summary>
        /// Network policy direction. Valid values: `FROM`, `TO`.
        /// </summary>
        [JsonProperty("Direction")]
        public string Direction{ get; set; }

        /// <summary>
        /// Network policy port
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Ports")]
        public NetworkPorts[] Ports{ get; set; }

        /// <summary>
        /// Network policy object
        /// 
        /// `PublishedNoConfirm`: Enabled and to be confirmed.
        /// 
        /// `PublishedConfirmed`: Enabled and confirmed.
        /// 
        /// `unPublishing`: Disabled.
        /// 
        /// `Publishing`: Enabled.
        /// 
        /// `unPublishEdit`: To be enabled.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Peer")]
        public NetworkPeer[] Peer{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
            this.SetParamArrayObj(map, prefix + "Ports.", this.Ports);
            this.SetParamArrayObj(map, prefix + "Peer.", this.Peer);
        }
    }
}

