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

namespace TencentCloud.Iai.V20200303.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DetectLiveFaceAccurateRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>base64 data of the image.</p><ul><li>The size after base64 encoding must not exceed 5M.</li><li>For jpg format, the long side pixel must not exceed 4000. For other formats, the long side pixel must not exceed 2000.</li><li>The aspect ratio of the image should be close to 3:4. The ratio from mobile phone shooting is best.</li><li>The human face size must be greater than 100X100 pixels.</li><li>Format support: PNG, jpg, JPEG, and BMP. GIF images are not supported.</li></ul>
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }

        /// <summary>
        /// <p>The Url of the Image.</p><ul><li>The size of the corresponding Image after base64 encoding must not exceed 5M.</li><li>For jpg format, the long side pixel must not exceed 4000. For other formats, the long side pixel must not exceed 2000.</li><li>Either Url or Image must be provided. If both are provided, only use Url.</li><li>The aspect ratio of the Image should be close to 3:4, which is the best ratio for mobile phone shooting.</li><li>The human face size must be greater than 100X100 pixels.</li><li>An Image stored in Tencent Cloud via Url can guarantee higher download speed and stability. It is recommended to store images in Tencent Cloud. The speed and stability of URLs not stored in Tencent Cloud may be affected.</li><li>Supported Image formats include PNG, jpg, JPEG, and BMP. GIF images are not supported.</li></ul>
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// <p>Algorithm model version used by the face recognition service. Currently, the input parameter supports "3.0".</p>
        /// </summary>
        [JsonProperty("FaceModelVersion")]
        public string FaceModelVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Image", this.Image);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "FaceModelVersion", this.FaceModelVersion);
        }
    }
}

