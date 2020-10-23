/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateUDPListenersRequest : AbstractModel
    {
        
        /// <summary>
        /// Listener name
        /// </summary>
        [JsonProperty("ListenerName")]
        public string ListenerName{ get; set; }

        /// <summary>
        /// List of listener ports
        /// </summary>
        [JsonProperty("Ports")]
        public ulong?[] Ports{ get; set; }

        /// <summary>
        /// Origin server scheduling policy of listeners, which supports round robin (rr), weighted round robin (wrr), and least connections (lc).
        /// </summary>
        [JsonProperty("Scheduler")]
        public string Scheduler{ get; set; }

        /// <summary>
        /// Origin server type of listeners, which supports IP or DOMAIN type.
        /// </summary>
        [JsonProperty("RealServerType")]
        public string RealServerType{ get; set; }

        /// <summary>
        /// Connection ID; Either `ProxyId` or `GroupId` must be set, but you cannot set both.
        /// </summary>
        [JsonProperty("ProxyId")]
        public string ProxyId{ get; set; }

        /// <summary>
        /// Connection group ID; Either `ProxyId` or `GroupId` must be set, but you cannot set both.
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// List of origin server ports, which only supports the listeners of version 1.0 and connection group.
        /// </summary>
        [JsonProperty("RealServerPorts")]
        public ulong?[] RealServerPorts{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ListenerName", this.ListenerName);
            this.SetParamArraySimple(map, prefix + "Ports.", this.Ports);
            this.SetParamSimple(map, prefix + "Scheduler", this.Scheduler);
            this.SetParamSimple(map, prefix + "RealServerType", this.RealServerType);
            this.SetParamSimple(map, prefix + "ProxyId", this.ProxyId);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamArraySimple(map, prefix + "RealServerPorts.", this.RealServerPorts);
        }
    }
}

