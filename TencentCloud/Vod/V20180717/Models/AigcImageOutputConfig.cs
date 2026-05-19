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
        /// <p>Storage mode</p><p>Enumeration value:</p><ul><li>Temporary: Temporary storage. The generated video file will not be stored in VOD. You can obtain the temporary access URL from event notification. The valid period is 7 days.</li><li>Permanent: Permanent storage. The generated video file will be stored in VOD. You can obtain the FileId from event notification.</li></ul><p>Default value: Temporary</p>
        /// </summary>
        [JsonProperty("StorageMode")]
        public string StorageMode{ get; set; }

        /// <summary>
        /// <p>Output filename, up to 64 characters. Default filename is specified by the system.</p>
        /// </summary>
        [JsonProperty("MediaName")]
        public string MediaName{ get; set; }

        /// <summary>
        /// <p>Category ID, used to categorize and manage media. You can create a category and obtain the category ID via the <a href="/document/product/266/7812">create category</a> API.</p><li>Default value: 0, indicate other categories.</li>
        /// </summary>
        [JsonProperty("ClassId")]
        public long? ClassId{ get; set; }

        /// <summary>
        /// <p>The expiry date of the output file. The file will be deleted longer than this time. It defaults to no expiration, format according to ISO 8601 standard. For details, see <a href="https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I">ISO date format description</a>.</p>
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// <p>Resolution of the generated image. Available values for each model:</p><ul><li>OG: 1K, 2K, 4K, default 1K;</li><li>GG 2.5: 1K, 2K, 4K, default 1K;</li><li>GG 3.0: 1K, 2K, 4K, default 1K;</li><li>GG 3.1: 512, 1K, 2K, 4K, default 1K;</li><li>Kling 2.1: 1k, 2k, default 1k;</li><li>Kling 3.0: 1k, 2k, default 1k;</li><li>Kling 3.0-Omni: 1k, 2k, 4k, default 1k;</li><li>Kling O1: 1k, 2k, 4k, default 1k;</li><li>SI 4.0: 1K, 2K, 4K, default 1K;</li><li>SI 4.5: 2K, 4K, default 2K;</li><li>SI 5.0-lite: 2K, 3K, default 2K;</li><li>Vidu q2: 1080p, 2K, 4K, default 1080p;</li><li>Hunyuan 3.0: This field is not currently supported. Set resolution via the <code>ExtInfo</code> field;</li><li>Qwen 0925: This field is not currently supported. Set resolution via the <code>ExtInfo</code> field;</li></ul>
        /// </summary>
        [JsonProperty("Resolution")]
        public string Resolution{ get; set; }

        /// <summary>
        /// <p>Specify the aspect ratio of the generated image.</p><ul><li>OG: 1:1, 3:2, 2:3, 3:4, 4:3, 16:9, 9:16, 21:9, 9:21;</li><li>GG 2.5: 1:1, 2:3, 3:2, 3:4, 4:3, 4:5, 5:4, 9:16, 16:9, 21:9;</li><li>GG 3.0: 1:1, 2:3, 3:2, 3:4, 4:3, 4:5, 5:4, 9:16, 16:9, 21:9;</li><li>GG 3.1: 1:1, 1:4, 1:8, 2:3, 3:2, 3:4, 4:1, 4:3, 4:5, 5:4, 8:1, 9:16, 16:9, 21:9;</li><li>Kling 2.1: 16:9, 9:16, 1:1, 4:3, 3:4, 3:2, 2:3, 21:9;</li><li>Kling 3.0: 16:9, 9:16, 1:1, 4:3, 3:4, 3:2, 2:3, 21:9;</li><li>Kling 3.0-Omni: 16:9, 9:16, 1:1, 4:3, 3:4, 3:2, 2:3, 21:9, auto;</li><li>Kling O1: 16:9, 9:16, 1:1, 4:3, 3:4, 3:2, 2:3, 21:9, auto;</li><li>Vidu q2: 16:9, 9:16, 1:1, 3:4, 4:3, 21:9, 2:3, 3:2;</li><li>SI 4.0: <strong>unsupported</strong>. Use prompt to specify 16:9, 9:16, 1:1, 4:3, 3:4, 3:2, 2:3, 21:9;</li><li>SI 4.5: <strong>unsupported</strong>. Use prompt to specify 16:9, 9:16, 1:1, 4:3, 3:4, 3:2, 2:3, 21:9;</li><li>SI 5.0-lite: <strong>unsupported</strong>. Use prompt to specify 16:9, 9:16, 1:1, 4:3, 3:4, 3:2, 2:3, 21:9;</li><li>Hunyuan 3.0: unsupported;</li><li>Qwen 2.0: unsupported;</li><li>Qwen 0925: unsupported;</li></ul>
        /// </summary>
        [JsonProperty("AspectRatio")]
        public string AspectRatio{ get; set; }

        /// <summary>
        /// <p>Whether to allow figure or human face generation. Valid values: <li>AllowAdult: Allow adult generation;</li> <li>Disallowed: Forbid including figure or human face in the image;</li></p>
        /// </summary>
        [JsonProperty("PersonGeneration")]
        public string PersonGeneration{ get; set; }

        /// <summary>
        /// <p>Whether to enable compliance check for input content. Valid values: <li>Enabled: Enable;</li> <li>Disabled: Disable;</li></p>
        /// </summary>
        [JsonProperty("InputComplianceCheck")]
        public string InputComplianceCheck{ get; set; }

        /// <summary>
        /// <p>Whether to enable compliance check for output content. Valid values: <li>Enabled: Enable;</li> <li>Disabled: Disable;</li></p>
        /// </summary>
        [JsonProperty("OutputComplianceCheck")]
        public string OutputComplianceCheck{ get; set; }

        /// <summary>
        /// <p>Number of images generated. Available values for each model:</p><ul><li>Kling: value range 1-9;</li><li>OG: value range 1-8;</li></ul><p><strong>Other models are disabled.</strong></p>
        /// </summary>
        [JsonProperty("OutputImageCount")]
        public ulong? OutputImageCount{ get; set; }

        /// <summary>
        /// <p>Specify the image format of the model output. If not specified, it follows the default value of the model. Available values:</p><ul><li>jpeg</li><li>png</li></ul>
        /// </summary>
        [JsonProperty("OutputFormat")]
        public string OutputFormat{ get; set; }

        /// <summary>
        /// <p>Indicates whether to enable the icon watermark. Default is Disabled. Valid values:</p><ul><li>Enabled: Enable;</li><li>Disabled: Disable;</li></ul>
        /// </summary>
        [JsonProperty("LogoAdd")]
        public string LogoAdd{ get; set; }


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
            this.SetParamSimple(map, prefix + "OutputImageCount", this.OutputImageCount);
            this.SetParamSimple(map, prefix + "OutputFormat", this.OutputFormat);
            this.SetParamSimple(map, prefix + "LogoAdd", this.LogoAdd);
        }
    }
}

