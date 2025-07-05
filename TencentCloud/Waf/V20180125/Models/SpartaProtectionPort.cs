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

    public class SpartaProtectionPort : AbstractModel
    {
        
        /// <summary>
        /// nginx Id
        /// </summary>
        [JsonProperty("NginxServerId")]
        public ulong? NginxServerId{ get; set; }

        /// <summary>
        /// Port
        /// </summary>
        [JsonProperty("Port")]
        public string Port{ get; set; }

        /// <summary>
        /// Protocol
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Backend port
        /// </summary>
        [JsonProperty("UpstreamPort")]
        public string UpstreamPort{ get; set; }

        /// <summary>
        /// Backend protocol
        /// </summary>
        [JsonProperty("UpstreamProtocol")]
        public string UpstreamProtocol{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NginxServerId", this.NginxServerId);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "UpstreamPort", this.UpstreamPort);
            this.SetParamSimple(map, prefix + "UpstreamProtocol", this.UpstreamProtocol);
        }
    }
}

