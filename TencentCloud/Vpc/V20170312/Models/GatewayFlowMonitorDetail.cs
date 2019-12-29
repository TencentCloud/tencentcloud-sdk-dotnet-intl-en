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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GatewayFlowMonitorDetail : AbstractModel
    {
        
        /// <summary>
        /// Origin `IP`.
        /// </summary>
        [JsonProperty("PrivateIpAddress")]
        public string PrivateIpAddress{ get; set; }

        /// <summary>
        /// Inbound packets.
        /// </summary>
        [JsonProperty("InPkg")]
        public ulong? InPkg{ get; set; }

        /// <summary>
        /// Outbound packets.
        /// </summary>
        [JsonProperty("OutPkg")]
        public ulong? OutPkg{ get; set; }

        /// <summary>
        /// Inbound bandwidth, unit: `Byte`.
        /// </summary>
        [JsonProperty("InTraffic")]
        public ulong? InTraffic{ get; set; }

        /// <summary>
        /// Outbound bandwidth, unit: `Byte`.
        /// </summary>
        [JsonProperty("OutTraffic")]
        public ulong? OutTraffic{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PrivateIpAddress", this.PrivateIpAddress);
            this.SetParamSimple(map, prefix + "InPkg", this.InPkg);
            this.SetParamSimple(map, prefix + "OutPkg", this.OutPkg);
            this.SetParamSimple(map, prefix + "InTraffic", this.InTraffic);
            this.SetParamSimple(map, prefix + "OutTraffic", this.OutTraffic);
        }
    }
}

