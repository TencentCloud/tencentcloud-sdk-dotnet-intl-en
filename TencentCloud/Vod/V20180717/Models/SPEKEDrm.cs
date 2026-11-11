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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SPEKEDrm : AbstractModel
    {
        
        /// <summary>
        /// <p>Resource tagging. The field content is user-customized. It supports 1-128 characters, including numbers, letters, underscores (_), and hyphens (-). This field corresponds to the cid field in the Speke request. Note: Different DRM manufacturers have differences in the limits for this field (for example, SDMC does not support underscores in this field). For specific rules, please contact the DRM manufacturer for confirmation.</p>
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// <p>DRM manufacturer access address. This field content is obtained from the DRM manufacturer. Note: Different DRM manufacturers have different limits on the number of substreams. For example, PallyCon allows no more than 5 substreams, while DRMtoday supports up to 9 substreams for encryption.</p>
        /// </summary>
        [JsonProperty("KeyServerUrl")]
        public string KeyServerUrl{ get; set; }

        /// <summary>
        /// <p>Encryption initialization vector (32-byte hexadecimal string). This field content is user-customized.</p>
        /// </summary>
        [JsonProperty("Vector")]
        public string Vector{ get; set; }

        /// <summary>
        /// <p>Encryption method. Available values:<br>cbcs: PlayReady, Widevine, FairPlay, Widevine+FairPlay, Widevine+PlayReady, PlayReady+FairPlay, Widevine+PlayReady+FairPlay are supported;<br>cenc: PlayReady, Widevine, Widevine+PlayReady are supported;<br>If left blank, cbcs is used for FairPlay by default;<br>cenc is used for PlayReady and Widevine by default;<br>cbcs is used for Widevine+FairPlay, PlayReady+FairPlay, Widevine+PlayReady+FairPlay by default;<br>cenc is used for Widevine+PlayReady by default;</p>
        /// </summary>
        [JsonProperty("EncryptionMethod")]
        public string EncryptionMethod{ get; set; }

        /// <summary>
        /// <p>Substream encryption rule. Default: preset 0<br>preset 0: use the same key to encrypt all substreams;<br>preset 1: use different keys to encrypt each substream;</p>
        /// </summary>
        [JsonProperty("EncryptionPreset")]
        public string EncryptionPreset{ get; set; }

        /// <summary>
        /// <p>Request method of the DRM manufacturer.</p><p>Enumeration values:</p><ul><li>POST: Most DRM manufacturers use the POST method for requests.</li><li>GET: Some DRM manufacturers support the GET method for requests. When using this method, request information needs to be included in the KeyServerUrl field.</li></ul><p>Default value: POST</p>
        /// </summary>
        [JsonProperty("KeyAcquireMode")]
        public string KeyAcquireMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "KeyServerUrl", this.KeyServerUrl);
            this.SetParamSimple(map, prefix + "Vector", this.Vector);
            this.SetParamSimple(map, prefix + "EncryptionMethod", this.EncryptionMethod);
            this.SetParamSimple(map, prefix + "EncryptionPreset", this.EncryptionPreset);
            this.SetParamSimple(map, prefix + "KeyAcquireMode", this.KeyAcquireMode);
        }
    }
}

