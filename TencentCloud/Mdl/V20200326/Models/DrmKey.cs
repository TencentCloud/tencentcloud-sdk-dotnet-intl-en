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

namespace TencentCloud.Mdl.V20200326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DrmKey : AbstractModel
    {
        
        /// <summary>
        /// DRM key, which is a 32-bit hexadecimal string.
        /// Note: uppercase letters in the string will be automatically converted to lowercase ones.
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// Widevine encryption is required. Selectable options: SD/HD/UHD1/UHD2/AUDIO/ALL.
        /// Among them, ALL represents select ALL. If ALL is specified, you cannot add other tracks.
        /// </summary>
        [JsonProperty("Track")]
        public string Track{ get; set; }

        /// <summary>
        /// KeyId for Widevine encryption, a 32-bit length hexadecimal string.
        /// Note: The string will be modified to lowercase.
        /// </summary>
        [JsonProperty("KeyId")]
        public string KeyId{ get; set; }

        /// <summary>
        /// Iv for AES encryption in Fairplay, a 32-bit length hexadecimal string.
        /// Iv parsing reference
        /// https://tools.ietf.org/html/rfc3826
        /// Note: The string will be modified to lowercase.
        /// </summary>
        [JsonProperty("Iv")]
        public string Iv{ get; set; }

        /// <summary>
        /// uri of the license server. AES128 is used. Can be empty.
        /// </summary>
        [JsonProperty("KeyUri")]
        public string KeyUri{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "Track", this.Track);
            this.SetParamSimple(map, prefix + "KeyId", this.KeyId);
            this.SetParamSimple(map, prefix + "Iv", this.Iv);
            this.SetParamSimple(map, prefix + "KeyUri", this.KeyUri);
        }
    }
}

