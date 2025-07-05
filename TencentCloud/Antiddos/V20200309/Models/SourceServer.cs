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

    public class SourceServer : AbstractModel
    {
        
        /// <summary>
        /// Types of the real server address, such as IP or domain name.
        /// </summary>
        [JsonProperty("RealServer")]
        public string RealServer{ get; set; }

        /// <summary>
        /// Types of the real server address:
        /// `1`: domain name
        /// `2`: IP
        /// ]
        /// </summary>
        [JsonProperty("RsType")]
        public long? RsType{ get; set; }

        /// <summary>
        /// Forward weight of the real server. Value range: 1–100.
        /// </summary>
        [JsonProperty("Weight")]
        public long? Weight{ get; set; }

        /// <summary>
        /// Port number. Value range: 0-65535.
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RealServer", this.RealServer);
            this.SetParamSimple(map, prefix + "RsType", this.RsType);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "Port", this.Port);
        }
    }
}

