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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EdgeKVPutRequest : AbstractModel
    {
        
        /// <summary>
        /// Zone ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Namespace name.
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// Key name, with a length of 1-512 characters, supports valid UTF-8 characters.
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// Key-value. Cannot be empty and supports up to 1 MB. Supports storing string data.
        /// </summary>
        [JsonProperty("Value")]
        public string Value{ get; set; }

        /// <summary>
        /// Expiry date of the key-value pair, absolute time in seconds, represents the seconds elapsed since 00:00:00 on January 1, 1970 (UTC) (Unix timestamp). The value must be greater than or equal to current time + 60, meaning the expiry date is at least 60 seconds from now. When both Expiration and ExpirationTTL are filled, ExpirationTTL takes precedence. If left empty, the key-value pair will never expire.
        /// </summary>
        [JsonProperty("Expiration")]
        public long? Expiration{ get; set; }

        /// <summary>
        /// The survival time of the key-value pair is a relative time in seconds, indicating that the data will expire after transit of specified seconds. Value ranges from 60. When both Expiration and ExpirationTTL are filled, ExpirationTTL takes precedence; if left empty, the key-value pair will never expire.
        /// </summary>
        [JsonProperty("ExpirationTTL")]
        public long? ExpirationTTL{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "Value", this.Value);
            this.SetParamSimple(map, prefix + "Expiration", this.Expiration);
            this.SetParamSimple(map, prefix + "ExpirationTTL", this.ExpirationTTL);
        }
    }
}

