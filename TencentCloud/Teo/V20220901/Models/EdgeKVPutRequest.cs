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
        /// Key name, 1-512 characters long, supports valid UTF-8 characters.
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// Key-value. It cannot be empty and supports up to 1 MB. It supports storing string data.
        /// </summary>
        [JsonProperty("Value")]
        public string Value{ get; set; }

        /// <summary>
        /// Expiration time of the key-value pair. It is an absolute time in seconds, representing the number of seconds elapsed since 00:00:00 (UTC) on January 1, 1970 (Unix timestamp). The value must be greater than or equal to the current time + 60, meaning the Expiration time must be at least 60 seconds from now. If both Expiration and ExpirationTTL are filled in, ExpirationTTL takes precedence. If both are left empty, the key-value pair never expires.
        /// </summary>
        [JsonProperty("Expiration")]
        public long? Expiration{ get; set; }

        /// <summary>
        /// Survival time of the key-value pair, relative time, in seconds. It means the data will expire after the specified seconds following the write. Value range: equal to or greater than 60. If both Expiration and ExpirationTTL are filled in, ExpirationTTL takes precedence. If both are left empty, the key-value pair will never expire.
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

