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

    public class AigcVideoOutputConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>Storage mode</p><p>Enumeration values:</p><ul><li>Temporary: Temporary storage. The generated video file will not be stored in VOD. You can obtain a temporary access URL from the event notification, with a valid period of 7 days.</li><li>Permanent: Permanent storage. The generated video file will be stored in VOD. You can obtain the FileId from the event notification.</li></ul><p>Default value: Temporary</p>
        /// </summary>
        [JsonProperty("StorageMode")]
        public string StorageMode{ get; set; }

        /// <summary>
        /// <p>Output media filename, up to 64 characters. By default, the system assigns the generated filename.</p>
        /// </summary>
        [JsonProperty("MediaName")]
        public string MediaName{ get; set; }

        /// <summary>
        /// <p>Category ID, used to categorize and manage media. You can create a category and obtain the category ID through the <a href="https://www.tencentcloud.com/document/product/266/7812?from_cn_redirect=1">Create Category</a> API.</p><li>Default value: 0, indicating other categories.</li>
        /// </summary>
        [JsonProperty("ClassId")]
        public long? ClassId{ get; set; }

        /// <summary>
        /// <p>Expiry date of the output file. The file will be deleted after this time. By default, it never expires. The format follows the ISO 8601 standard. For details, see <a href="https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I">ISO date format description</a>.</p>
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// <p>Duration of the generated video, in seconds.</p><li>When ModelName is Kling, optional values: 3-15, default: 5;</li><li>When ModelName is Hailuo, optional values: 6, 10, default: 6; when the version is H3, optional values: 4-15 seconds (integer)</li><li>When ModelName is Vidu, specify 1-10;</li><li>When ModelName is GV, optional value: 8, default: 8;</li><li>When ModelName is OS, optional values: 4, 8, 12, default: 8;</li><li>When ModelName is PixVerse, specify 1-15, default: 5;</li>
        /// </summary>
        [JsonProperty("Duration")]
        public float? Duration{ get; set; }

        /// <summary>
        /// <p>Resolution of the generated video.</p><li>When ModelName is Kling, optional values: 720P and 1080P. Default value: 720P.</li><li>When ModelName is Hailuo, optional values: 768P and 1080P. Default value: 768P. When the version is H3, optional values: 768P, 1080P, 2K, and 4K.</li><li>When ModelName is Vidu, optional values: 720P and 1080P. Default value: 720P.</li><li>When ModelName is GV, optional values: 720P and 1080P. Default value: 720P.</li><li>When ModelName is OS, optional value: 720P.</li><li>When ModelName is PixVerse, optional values: 540p, 720p, 1080p, 2k, and 4k. Default value: 720p.</li>
        /// </summary>
        [JsonProperty("Resolution")]
        public string Resolution{ get; set; }

        /// <summary>
        /// <p>Aspect ratio of the generated video.</p><li>When ModelName is Kling, for text-to-video, available values are 16:9, 9:16, and 1:1, with a default value of 16:9;</li><li>When ModelName is Vidu, for text-to-video and reference image-to-video, available values are 16:9, 9:16, 4:3, 3:4, and 1:1. Only version q2 supports 4:3 and 3:4.</li><li>When ModelName is GV, available values are 16:9 and 9:16, with a default value of 16:9;</li><li>When ModelName is OS, for text-to-video, available values are 16:9 and 9:16, with a default value of 16:9;</li><li>When ModelName is Hailuo and the version is H3, for text-to-video and reference image-to-video, available values are 21:9, 16:9, 4:3, 1:1, 3:4, and 9:16. For image-to-video (first and last frame video), the resolution matches the image.</li><li>When ModelName is PixVerse, available values are 16:9, 4:3, 1:1, 3:4, 9:16, 2:3, 3:2, and 21:9;</li>
        /// </summary>
        [JsonProperty("AspectRatio")]
        public string AspectRatio{ get; set; }

        /// <summary>
        /// <p>Whether to generate audio. Supported models include GV, OS, Vidu, Jimeng, and Kling.</p><p>Enumeration values:</p><ul><li>Enabled: enable</li><li>Disabled: disable</li></ul><p>Default value: Disabled</p>
        /// </summary>
        [JsonProperty("AudioGeneration")]
        public string AudioGeneration{ get; set; }

        /// <summary>
        /// <p>Whether to allow generation of people or human faces. Valid values: <li>AllowAdult: allow generation of adults;</li> <li>Disallowed: forbid including people or human faces in images;</li></p>
        /// </summary>
        [JsonProperty("PersonGeneration")]
        public string PersonGeneration{ get; set; }

        /// <summary>
        /// <p>Whether compliance check is enabled for the input. Valid values: <li>Enabled: enable;</li> <li>Disabled: disable;</li></p>
        /// </summary>
        [JsonProperty("InputComplianceCheck")]
        public string InputComplianceCheck{ get; set; }

        /// <summary>
        /// <p>Whether to enable compliance check on output content. Valid values: <li>Enabled: enable;</li> <li>Disabled: disable;</li></p>
        /// </summary>
        [JsonProperty("OutputComplianceCheck")]
        public string OutputComplianceCheck{ get; set; }

        /// <summary>
        /// <p>Whether to enable video enhancement. Valid values: <li>Enabled: Turn on;</li> <li>Disabled: Turn off;</li><br>Description:</p><ol><li>If the selected resolution exceeds the model's generation resolution, enhancement is enabled by default.</li><li>For resolutions the model can generate directly, you can also choose direct low-resolution output and use enhancement to obtain the specified resolution.</li></ol>
        /// </summary>
        [JsonProperty("EnhanceSwitch")]
        public string EnhanceSwitch{ get; set; }

        /// <summary>
        /// <p>Whether to enable off-peak. Valid values: <li>Enabled: enable;</li> <li>Disabled: disable;</li></p>
        /// </summary>
        [JsonProperty("OffPeak")]
        public string OffPeak{ get; set; }

        /// <summary>
        /// <p>Whether intelligent frame interpolation is enabled for vidu. Valid values: <li>Enabled: enable;</li> <li>Disabled: disable;</li></p>
        /// </summary>
        [JsonProperty("FrameInterpolate")]
        public string FrameInterpolate{ get; set; }

        /// <summary>
        /// <p>Indicates whether to enable the logo watermark. Valid values: <li>Enabled: enable;</li> <li>Disabled: disable;</li></p>
        /// </summary>
        [JsonProperty("LogoAdd")]
        public string LogoAdd{ get; set; }

        /// <summary>
        /// <p>Whether to add background music to the generated video.</p><p>Enumeration values:</p><ul><li>Enabled: The system will automatically select suitable music from the preset BGM library and add it.</li><li>Disabled: Do not add BGM.</li></ul><p>Default value: Disabled</p>
        /// </summary>
        [JsonProperty("EnableBGM")]
        public string EnableBGM{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StorageMode", this.StorageMode);
            this.SetParamSimple(map, prefix + "MediaName", this.MediaName);
            this.SetParamSimple(map, prefix + "ClassId", this.ClassId);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
            this.SetParamSimple(map, prefix + "AspectRatio", this.AspectRatio);
            this.SetParamSimple(map, prefix + "AudioGeneration", this.AudioGeneration);
            this.SetParamSimple(map, prefix + "PersonGeneration", this.PersonGeneration);
            this.SetParamSimple(map, prefix + "InputComplianceCheck", this.InputComplianceCheck);
            this.SetParamSimple(map, prefix + "OutputComplianceCheck", this.OutputComplianceCheck);
            this.SetParamSimple(map, prefix + "EnhanceSwitch", this.EnhanceSwitch);
            this.SetParamSimple(map, prefix + "OffPeak", this.OffPeak);
            this.SetParamSimple(map, prefix + "FrameInterpolate", this.FrameInterpolate);
            this.SetParamSimple(map, prefix + "LogoAdd", this.LogoAdd);
            this.SetParamSimple(map, prefix + "EnableBGM", this.EnableBGM);
        }
    }
}

