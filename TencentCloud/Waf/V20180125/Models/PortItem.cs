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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PortItem : AbstractModel
    {
        
        /// <summary>
        /// Listening Port Configuration
        /// </summary>
        [JsonProperty("Port")]
        public string Port{ get; set; }

        /// <summary>
        /// Corresponds one-to-one with ports, indicating the protocol associated with the port.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Corresponds one-to-one with port, indicates the origin port
        /// </summary>
        [JsonProperty("UpstreamPort")]
        public string UpstreamPort{ get; set; }

        /// <summary>
        /// Corresponds one-to-one with Port, indicating the origin protocol
        /// </summary>
        [JsonProperty("UpstreamProtocol")]
        public string UpstreamProtocol{ get; set; }

        /// <summary>
        /// Nginx Server ID
        /// </summary>
        [JsonProperty("NginxServerId")]
        public string NginxServerId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "UpstreamPort", this.UpstreamPort);
            this.SetParamSimple(map, prefix + "UpstreamProtocol", this.UpstreamProtocol);
            this.SetParamSimple(map, prefix + "NginxServerId", this.NginxServerId);
        }
    }
}

