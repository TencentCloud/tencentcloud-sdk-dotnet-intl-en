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
        /// Required for Widevine encryption. Valid values: SD, HD, UHD1, UHD2, AUDIO, ALL.
        /// ALL refers to all tracks. If this parameter is set to ALL, no other tracks can be added.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Track")]
        public string Track{ get; set; }

        /// <summary>
        /// Required for Widevine encryption. It is a 32-bit hexadecimal string.
        /// Note: uppercase letters in the string will be automatically converted to lowercase ones.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("KeyId")]
        public string KeyId{ get; set; }

        /// <summary>
        /// Required when FairPlay uses the AES encryption method. It is a 32-bit hexadecimal string.
        /// For more information about this parameter, please see: 
        /// https://tools.ietf.org/html/rfc3826
        /// Note: uppercase letters in the string will be automatically converted to lowercase ones.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Iv")]
        public string Iv{ get; set; }

        /// <summary>
        /// The URI of the license server when AES-128 is used. This parameter may be empty.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
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

