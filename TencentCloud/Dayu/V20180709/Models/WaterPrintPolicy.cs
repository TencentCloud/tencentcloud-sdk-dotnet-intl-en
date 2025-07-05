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

namespace TencentCloud.Dayu.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WaterPrintPolicy : AbstractModel
    {
        
        /// <summary>
        /// TCP port range, such as ["2000-3000","3500-4000"]
        /// </summary>
        [JsonProperty("TcpPortList")]
        public string[] TcpPortList{ get; set; }

        /// <summary>
        /// UDP port range, such as ["2000-3000","3500-4000"]
        /// </summary>
        [JsonProperty("UdpPortList")]
        public string[] UdpPortList{ get; set; }

        /// <summary>
        /// Watermark offset. Value range: [0, 100)
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Whether to automatically remove. Valid values: [0 (no), 1 (yes)]
        /// </summary>
        [JsonProperty("RemoveSwitch")]
        public ulong? RemoveSwitch{ get; set; }

        /// <summary>
        /// Whether it is enabled. Valid values: [0 (no), 1 (yes)]
        /// </summary>
        [JsonProperty("OpenStatus")]
        public ulong? OpenStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "TcpPortList.", this.TcpPortList);
            this.SetParamArraySimple(map, prefix + "UdpPortList.", this.UdpPortList);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "RemoveSwitch", this.RemoveSwitch);
            this.SetParamSimple(map, prefix + "OpenStatus", this.OpenStatus);
        }
    }
}

