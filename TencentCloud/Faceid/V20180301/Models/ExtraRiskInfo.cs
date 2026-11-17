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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExtraRiskInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>A stable and unique person identifier within the customer's business domain, used to correlate multiple location reports from the same person to determine whether abnormal displacement exists.</p><p>Input restrictions: Length ≤ 128 characters; Must not contain control characters (ASCII &lt; 0x20 or 0x7F); It is recommended to pass a desensitized identifier instead of a plaintext ID number or mobile number.</p>
        /// </summary>
        [JsonProperty("PersonId")]
        public string PersonId{ get; set; }

        /// <summary>
        /// <p>Latitude at the time of device collection, in WGS84 decimal degrees    </p><p>Input restrictions: Must be paired with Longitude; Valid range: [-90, 90]; Must be a valid number, NaN/Inf not accepted; Pass as a string in JSON (e.g., &quot;22.5431&quot;)</p>
        /// </summary>
        [JsonProperty("Latitude")]
        public string Latitude{ get; set; }

        /// <summary>
        /// <p>Longitude at the time of device collection, in WGS84 decimal degrees    </p><p>Input restrictions: Must be paired with Latitude; Valid range: [-180, 180]; Other restrictions are the same as above</p>
        /// </summary>
        [JsonProperty("Longitude")]
        public string Longitude{ get; set; }

        /// <summary>
        /// <p>Public egress IP of the device at the time of collection    </p><p>Input restrictions: Length ≤ 64; Must be a resolvable IPv4/IPv6 address; Private, loopback, link-local, and multicast addresses are considered non-locatable</p>
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PersonId", this.PersonId);
            this.SetParamSimple(map, prefix + "Latitude", this.Latitude);
            this.SetParamSimple(map, prefix + "Longitude", this.Longitude);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
        }
    }
}

