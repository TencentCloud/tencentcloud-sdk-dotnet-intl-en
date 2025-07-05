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

namespace TencentCloud.Gse.V20191112.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InboundPermission : AbstractModel
    {
        
        /// <summary>
        /// Start port number. Minimum value: 1025.
        /// </summary>
        [JsonProperty("FromPort")]
        public ulong? FromPort{ get; set; }

        /// <summary>
        /// IP range. Valid range of the input IPv4 addresses in CIDR format; for example, 0.0.0.0.0/0.
        /// </summary>
        [JsonProperty("IpRange")]
        public string IpRange{ get; set; }

        /// <summary>
        /// Protocol type: TCP or UDP.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// End port number. Maximum value: 60000.
        /// </summary>
        [JsonProperty("ToPort")]
        public ulong? ToPort{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FromPort", this.FromPort);
            this.SetParamSimple(map, prefix + "IpRange", this.IpRange);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "ToPort", this.ToPort);
        }
    }
}

