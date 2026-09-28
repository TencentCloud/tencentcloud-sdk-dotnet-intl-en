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

namespace TencentCloud.Alb.V20251030.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InsertHTTPHeaderInfo : AbstractModel
    {
        
        /// <summary>
        /// Key of the inserted HTTP Header. Length: 1–40 characters. Supported character sets: a-z, a-z, 0-9, -, and _.
        /// Chinese characters are not allowed. No support for Cookie, Host, Content-Length, Connection, Upgrade, transfer-encoding, keep-alive, te, authority, x-forwarded-for, x-forwarded-proto, x-forwarded-host, and x-forwarded-port.
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// Type of the HTTP Header value.
        /// When ValueType is SystemDefined, the value range is as follows: ClientPort: client port, ClientIp: client IP address, Protocol: protocol of client requests, CLBPort: listening port of the load balancing instance.
        /// When ValueType is UserDefined, it is a printable character of 1 to 128 characters in length. It does not support ". It cannot be space at the beginning and ending, and cannot be \ at the end.
        /// When ValueType is ReferenceHeader, refer to a header in the request header. It must be 1–128 printable characters. It does not support ". It cannot begin or end with a space, and cannot end with \.
        /// </summary>
        [JsonProperty("Value")]
        public string Value{ get; set; }

        /// <summary>
        /// Type of the HTTP Header value. Value:
        /// SystemDefined: system defined header.
        /// UserDefined: user-defined header.
        /// ReferenceHeader: refers to one header in the request header.
        /// </summary>
        [JsonProperty("ValueType")]
        public string ValueType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "Value", this.Value);
            this.SetParamSimple(map, prefix + "ValueType", this.ValueType);
        }
    }
}

