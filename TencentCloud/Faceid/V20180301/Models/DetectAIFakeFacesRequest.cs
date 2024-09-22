/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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
        /// Enter the image or video with a face to be detected, in base64 encoding. Base64 value of the image: The overall image resolution is recommended to be 480x640, and the face size is 100X100 or larger; The image data size after Base64 encoding does not exceed 3M, and only supports jpg and png formats. Please use standard Base64 encoding (use = for padding). Refer to RFC4648 for encoding specifications. Base64 value of the video: The size after Base64 encoding does not exceed 8M, and supports mp4, avi, and flv formats. Please use standard Base64 encoding (use = for padding). Refer to RFC4648 for encoding specifications. The maximum supported video length is 20s, and the recommended length is 2 to 5s. The recommended video resolution is 480x640, and the frame rate is between 25fps and 30fps.
        /// </summary>
        [JsonProperty("FaceInput")]
        public string FaceInput{ get; set; }

        /// <summary>
        /// The type of input is 1- The input type is a picture 2- The input type is a video Others - Return error code InvalidParameter
        /// </summary>
        [JsonProperty("FaceInputType")]
        public long? FaceInputType{ get; set; }

        /// <summary>
        /// Whether the request information needs to be fully encrypted; Supported encryption algorithms: AES-256-CBC, SM4-GCM; Users with encryption requirements can use this parameter, for details, please click the link on the left.
        /// </summary>
        [JsonProperty("Encryption")]
        public Encryption Encryption{ get; set; }

        /// <summary>
        /// Encrypted ciphertext; The data format before encryption is as follows:{"FaceInput":"AAAAA","FaceInputType":1}
        /// </summary>
        [JsonProperty("EncryptedBody")]
        public string EncryptedBody{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FaceInput", this.FaceInput);
            this.SetParamSimple(map, prefix + "FaceInputType", this.FaceInputType);
            this.SetParamObj(map, prefix + "Encryption.", this.Encryption);
            this.SetParamSimple(map, prefix + "EncryptedBody", this.EncryptedBody);
        }
    }
}

