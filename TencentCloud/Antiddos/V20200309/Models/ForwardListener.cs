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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ForwardListener : AbstractModel
    {
        
        /// <summary>
        /// The starting port for listener forwarding. Value range: 1 to 65535.
        /// </summary>
        [JsonProperty("FrontendPort")]
        public long? FrontendPort{ get; set; }

        /// <summary>
        /// Forwarding protocol. Valid values:
        /// `TCP`
        /// `UDP`
        /// ]
        /// </summary>
        [JsonProperty("ForwardProtocol")]
        public string ForwardProtocol{ get; set; }

        /// <summary>
        /// The ending port for listener forwarding. Value range: 1 to 65535.
        /// </summary>
        [JsonProperty("FrontendPortEnd")]
        public long? FrontendPortEnd{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FrontendPort", this.FrontendPort);
            this.SetParamSimple(map, prefix + "ForwardProtocol", this.ForwardProtocol);
            this.SetParamSimple(map, prefix + "FrontendPortEnd", this.FrontendPortEnd);
        }
    }
}

