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

namespace TencentCloud.Mdp.V20200527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DRMInfo : AbstractModel
    {
        
        /// <summary>
        /// Encryption method, optional values: `CBCS`, `CENC`.
        /// </summary>
        [JsonProperty("EncryptionMethod")]
        public string EncryptionMethod{ get; set; }

        /// <summary>
        /// DRM system providers, when the encryption method is CBCS, the optional values are `PlayReady`, `Widevine`, `FairPlay`; when the encryption method is CENC, the oprional values are `PlayReady`, `Widevine`.
        /// </summary>
        [JsonProperty("DRMSystems")]
        public string[] DRMSystems{ get; set; }

        /// <summary>
        /// The resource ID sent to the key server. It can contain 1 to 128 characters, including numbers, letters, underscores (_), and hyphens (-).
        /// </summary>
        [JsonProperty("ResourceID")]
        public string ResourceID{ get; set; }

        /// <summary>
        /// Key server address; must start with https://.
        /// </summary>
        [JsonProperty("KeyServerUrl")]
        public string KeyServerUrl{ get; set; }

        /// <summary>
        /// Video encryption presets, options: 
        /// `Preset Video 1` - Encrypts all video tracks with one key
        /// `Preset Video 2` - Encrypts SD and HD video tracks with 2 different keys
        /// `Preset Video 3` - Encrypts SD, HD and UHD video tracks with 3 different keys
        /// `Preset Video 4` - Encrypts SD, HD, UHD1 and UHD2 video tracks with 4 different keys
        /// `Preset Video 5` - Encrypts SD, HD1, HD2, UHD1 and UHD2 video tracks with 5 different keys
        /// `Preset Video 6` - Encrypts SD, HD1, HD2, UHD video tracks with 4 different keys
        /// `Preset Video 7` - Encrypts SD + HD1, HD2, UHD video tracks with 3 different keys
        /// `Preset Video 8` - Encrypts SD + HD1, HD2, UHD1, UHD2 video tracks with 4 different keys
        /// `Shared` - Encrypts all video and audio tracks with one key
        /// `Unencrypted` - Does not encrypt any track
        /// </summary>
        [JsonProperty("VideoEncryptionPreset")]
        public string VideoEncryptionPreset{ get; set; }

        /// <summary>
        /// Audio encryption presets, options:
        /// `Preset Audio 1` - Encrypts all audio tracks with one key
        /// `Preset Audio 2` - Encrypts STEREO and MULTICHANNEL audio tracks with 2 different keys
        /// `Preset Audio 3` - Encrypts STEREO, MULTICHANNEL 3-6 and MULTICHANNEL 7 audio tracks with 3 different keys
        /// `Shared` - Encrypts all video and audio tracks with one key
        /// `Unencrypted` - Does not encrypt any track
        /// </summary>
        [JsonProperty("AudioEncryptionPreset")]
        public string AudioEncryptionPreset{ get; set; }

        /// <summary>
        /// Optional, used together with the key to encrypt the content; a 128-bit, 32-character, hexadecimal-encoded string.
        /// </summary>
        [JsonProperty("ConstantInitializationVector")]
        public string ConstantInitializationVector{ get; set; }

        /// <summary>
        /// Optional, specifies the rotation interval in seconds; empty, or an integer between 300-2592000.
        /// </summary>
        [JsonProperty("KeyRotationInterval")]
        public long? KeyRotationInterval{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EncryptionMethod", this.EncryptionMethod);
            this.SetParamArraySimple(map, prefix + "DRMSystems.", this.DRMSystems);
            this.SetParamSimple(map, prefix + "ResourceID", this.ResourceID);
            this.SetParamSimple(map, prefix + "KeyServerUrl", this.KeyServerUrl);
            this.SetParamSimple(map, prefix + "VideoEncryptionPreset", this.VideoEncryptionPreset);
            this.SetParamSimple(map, prefix + "AudioEncryptionPreset", this.AudioEncryptionPreset);
            this.SetParamSimple(map, prefix + "ConstantInitializationVector", this.ConstantInitializationVector);
            this.SetParamSimple(map, prefix + "KeyRotationInterval", this.KeyRotationInterval);
        }
    }
}

