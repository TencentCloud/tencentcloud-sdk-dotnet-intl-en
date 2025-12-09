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

namespace TencentCloud.Trocket.V20230308.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProducerInfo : AbstractModel
    {
        
        /// <summary>
        /// Client ID	
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ClientId")]
        public string ClientId{ get; set; }

        /// <summary>
        /// Client IP.	
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ClientIp")]
        public string ClientIp{ get; set; }

        /// <summary>
        /// Client language. 
        /// - JAVA((byte) 0)
        /// - CPP((byte) 1) 
        /// - DOTNET((byte) 2) 
        /// - PYTHON((byte) 3)
        /// - DELPHI((byte) 4)
        /// - ERLANG((byte) 5)
        /// - RUBY((byte) 6)
        /// - OTHER((byte) 7)
        /// - HTTP((byte) 8)
        /// - GO((byte) 9)
        /// - PHP((byte) 10)
        /// - OMS((byte) 11)
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Language")]
        public string Language{ get; set; }

        /// <summary>
        /// Client version.	
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// Last production time, **Unix timestamp (seconds)**.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LastUpdateTimestamp")]
        public ulong? LastUpdateTimestamp{ get; set; }

        /// <summary>
        /// Producer client protocol type. valid values: the following.
        /// 
        /// -Specifies the grpc protocol.
        /// -remoting protocol.
        /// -http protocol.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ChannelProtocol")]
        public string ChannelProtocol{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClientId", this.ClientId);
            this.SetParamSimple(map, prefix + "ClientIp", this.ClientIp);
            this.SetParamSimple(map, prefix + "Language", this.Language);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "LastUpdateTimestamp", this.LastUpdateTimestamp);
            this.SetParamSimple(map, prefix + "ChannelProtocol", this.ChannelProtocol);
        }
    }
}

