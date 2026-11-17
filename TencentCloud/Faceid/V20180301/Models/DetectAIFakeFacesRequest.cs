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

    public class DetectAIFakeFacesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Pass in the face image or face video to be detected (currently only single-face detection is supported), encoded in Base64. If both video and image are available in your scenario, we recommend using video for detection. For better detection results, note the following restrictions and recommendations for input data:</p><ul><li><p>Base64 value of the image:<br>Recommended overall image resolution is 480x640, with the face size above 100X100, captured by the front camera of a mobile phone.<br>The Base64-encoded image data is recommended to be no more than 3 MB, and must not exceed 10 MB. Only jpg and png formats are supported.<br>Use the standard Base64 encoding method (with = padding). For encoding specifications, refer to RFC4648.</p></li><li><p>Base64 value of the video:<br>The Base64-encoded size is recommended to be within 8 MB, and must not exceed 10 MB. mp4, avi, flv, and mov formats are supported, captured by the front camera of a mobile phone.<br>Recommended video duration is 2 to 5 seconds, and must not exceed 20 seconds.<br>Recommended video resolution is 480x640 (up to 720p supported), with a frame rate between 25 fps and 30 fps.<br>Use the standard Base64 encoding method (with = padding). For encoding specifications, refer to RFC4648.</p></li></ul><p>If you do not use Encryption for encrypted transmission, this field is required.</p>
        /// </summary>
        [JsonProperty("FaceInput")]
        public string FaceInput{ get; set; }

        /// <summary>
        /// <p>Type of the input.</p><ul><li>Valid values:<br>1: image type.<br>2: video type.<br>Others: the error code InvalidParameter is returned.</li></ul><p>If you do not use Encryption for encrypted transmission, this field is required.</p>
        /// </summary>
        [JsonProperty("FaceInputType")]
        public long? FaceInputType{ get; set; }

        /// <summary>
        /// <p>Whether to encrypt the entire request body.</p><ul><li>Supported encryption algorithms: AES-256-CBC and SM4-GCM.</li><li>Users with encryption requirements can use this parameter. For details, click the link on the left.</li></ul>
        /// </summary>
        [JsonProperty("Encryption")]
        public Encryption Encryption{ get; set; }

        /// <summary>
        /// <p>Encrypted ciphertext.</p><ul><li>The data format before encryption is as follows: {&quot;FaceInput&quot;:&quot;AAAAA&quot;,&quot;FaceInputType&quot;:1}.</li></ul>
        /// </summary>
        [JsonProperty("EncryptedBody")]
        public string EncryptedBody{ get; set; }

        /// <summary>
        /// <p>Carries the risk control context of this request at one time, that is, "who, where, and from which IP the request is initiated".</p>
        /// </summary>
        [JsonProperty("ExtraRiskInfo")]
        public ExtraRiskInfo ExtraRiskInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FaceInput", this.FaceInput);
            this.SetParamSimple(map, prefix + "FaceInputType", this.FaceInputType);
            this.SetParamObj(map, prefix + "Encryption.", this.Encryption);
            this.SetParamSimple(map, prefix + "EncryptedBody", this.EncryptedBody);
            this.SetParamObj(map, prefix + "ExtraRiskInfo.", this.ExtraRiskInfo);
        }
    }
}

