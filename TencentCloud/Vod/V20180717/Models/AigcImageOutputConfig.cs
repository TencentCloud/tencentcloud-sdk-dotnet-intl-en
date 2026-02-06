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

    public class AigcImageOutputConfig : AbstractModel
    {
        
        /// <summary>
        /// Storage mode. valid values: <li>Permanent: Permanent storage. the generated image file will be stored in VOD (video on demand), and the FileId can be obtained in the event notification.</li> <li>Temporary: Temporary storage. the generated image file will not be stored in vod, and the Temporary access URL can be obtained in the event notification.</li>.
        /// Default value: Temporary.
        /// </summary>
        [JsonProperty("StorageMode")]
        public string StorageMode{ get; set; }

        /// <summary>
        /// Output filename, up to 64 characters. default filename is assigned by the system.
        /// </summary>
        [JsonProperty("MediaName")]
        public string MediaName{ get; set; }

        /// <summary>
        /// Category ID, used to categorize and manage media. you can create a category and obtain the category ID via the [create classification](https://www.tencentcloud.com/document/product/266/7812?from_cn_redirect=1) api.
        /// <Li>Default value: 0, indicating other categories.</li>.
        /// </summary>
        [JsonProperty("ClassId")]
        public long? ClassId{ get; set; }

        /// <summary>
        /// The expiry date of the output file. files will be deleted longer than this time. default is no expiration. format according to ISO 8601 standard. for details, see [ISO date format description](https://www.tencentcloud.comom/document/product/266/11732?from_cn_redirect=1#I).
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// Image generation resolution. available values are 720P, 1080P, 2K, 4K, 1024x1024, 2048x2048, 2304x1728, 2496x1664, 2560x1440, 3024x1296, 4096x4096, 4694x3520, 4992x3328, 5404x3040, 6198x2656.
        /// </summary>
        [JsonProperty("Resolution")]
        public string Resolution{ get; set; }

        /// <summary>
        /// Specify the aspect ratio of the generated image. <li>when ModelName is GEM, the available values are 1:1, 3:2, 2:3, 3:4, 4:3, 4:5, 5:4, 9:16, 16:9, and 21:9.</li> <li>when ModelName is Qwen, it is not currently supported.</li>.
        /// </summary>
        [JsonProperty("AspectRatio")]
        public string AspectRatio{ get; set; }

        /// <summary>
        /// Whether to allow figure or human face generation. valid values: <li>AllowAdult: allow adult generation.</li> <li>Disallowed: forbid including figures or human faces in images.</li>.
        /// </summary>
        [JsonProperty("PersonGeneration")]
        public string PersonGeneration{ get; set; }

        /// <summary>
        /// Whether to enable compliance check for input content. valid values: <li>Enabled: enable;</li> <li>Disabled: disable;</li>.
        /// </summary>
        [JsonProperty("InputComplianceCheck")]
        public string InputComplianceCheck{ get; set; }

        /// <summary>
        /// Whether to enable compliance check for output content. valid values: <li>Enabled: enable;</li> <li>Disabled: disable;</li>.
        /// </summary>
        [JsonProperty("OutputComplianceCheck")]
        public string OutputComplianceCheck{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StorageMode", this.StorageMode);
            this.SetParamSimple(map, prefix + "MediaName", this.MediaName);
            this.SetParamSimple(map, prefix + "ClassId", this.ClassId);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
            this.SetParamSimple(map, prefix + "AspectRatio", this.AspectRatio);
            this.SetParamSimple(map, prefix + "PersonGeneration", this.PersonGeneration);
            this.SetParamSimple(map, prefix + "InputComplianceCheck", this.InputComplianceCheck);
            this.SetParamSimple(map, prefix + "OutputComplianceCheck", this.OutputComplianceCheck);
        }
    }
}

