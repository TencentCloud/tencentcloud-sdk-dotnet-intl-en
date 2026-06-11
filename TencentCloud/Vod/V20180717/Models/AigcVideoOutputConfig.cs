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
        /// <p>Storage mode</p><p>Enumeration value:</p><ul><li>Temporary: Temporary storage. The generated video file will not be stored in VOD. You can obtain the temporary access URL from event notification. The valid period is 7 days.</li><li>Permanent: Permanent storage. The generated video file will be stored in VOD. You can obtain the FileId from event notification.</li></ul><p>Default value: Temporary</p>
        /// </summary>
        [JsonProperty("StorageMode")]
        public string StorageMode{ get; set; }

        /// <summary>
        /// <p>Output media file name, up to 64 characters. Default filename is specified by the system.</p>
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
        /// <p>Duration of the generated video, unit: seconds.</p><li>When ModelName is Kling, optional values are 3-15, default is 5.</li><li>When ModelName is Hailuo, optional values are 6 and 10, default is 6.</li><li>When ModelName is Vidu, specify 1-10.</li><li>When ModelName is GV, optional value is 8, default is 8.</li><li>When ModelName is OS, optional values are 4, 8, and 12, default is 8.</li><li>When ModelName is PixVerse, specify 1-15, default is 5.</li>
        /// </summary>
        [JsonProperty("Duration")]
        public float? Duration{ get; set; }

        /// <summary>
        /// <p>Resolution of the generated video.</p><li>When ModelName is Kling, available values are 720P and 1080P, default is 720P;</li><li>When ModelName is Hailuo, available values are 768P and 1080P, default is 768P;</li><li>When ModelName is Vidu, available values are 720P and 1080P, default is 720P;</li><li>When ModelName is GV, available values are 720P and 1080P, default is 720P;</li><li>When ModelName is OS, available value is 720P;</li><li>When ModelName is PixVerse, available values are 540p, 720p, 1080p, 2k, and 4k, default is 720p;</li>
        /// </summary>
        [JsonProperty("Resolution")]
        public string Resolution{ get; set; }

        /// <summary>
        /// <p>Specify the aspect ratio of the generated video.</p><li>When ModelName is Kling, for text-to-video, the optional values are 16:9, 9:16, and 1:1, with a default value of 16:9.</li><li>When ModelName is Vidu, for text-to-video and reference image-to-video, the optional values are 16:9, 9:16, 4:3, 3:4, and 1:1. Only version q2 supports 4:3 and 3:4.</li><li>When ModelName is GV, the optional values are 16:9 and 9:16, with a default value of 16:9.</li><li>When ModelName is OS, for text-to-video, the optional values are 16:9 and 9:16, with a default value of 16:9.</li><li>When ModelName is Hailuo, this parameter is not currently supported.</li><li>When ModelName is PixVerse, the optional values are 16:9, 4:3, 1:1, 3:4, 9:16, 2:3, 3:2, and 21:9.</li>
        /// </summary>
        [JsonProperty("AspectRatio")]
        public string AspectRatio{ get; set; }

        /// <summary>
        /// <p>Whether to generate audio. Supported models include GV, OS, Vidu, Jimeng, and Kling.</p><p>Enumeration value:</p><ul><li>Enabled: Enable</li><li>Disabled: Disable</li></ul><p>Default value: Disabled</p>
        /// </summary>
        [JsonProperty("AudioGeneration")]
        public string AudioGeneration{ get; set; }

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
        /// <p>Whether to enable video enhancement. Valid values: <li>Enabled: Turn on;</li> <li>Disabled: Turn off;</li><br>Description:</p><ol><li>For selected resolution exceeding the resolution the model can generate, enhancement is enabled by default.</li><li>For resolutions the model can directly output, you can also proactively select the model to directly output low-resolution and use enhancement to obtain the specified resolution.</li></ol>
        /// </summary>
        [JsonProperty("EnhanceSwitch")]
        public string EnhanceSwitch{ get; set; }

        /// <summary>
        /// <p>Whether peak shaving is enabled. Valid values: <li>Enabled: Enable;</li> <li>Disabled: Disable;</li></p>
        /// </summary>
        [JsonProperty("OffPeak")]
        public string OffPeak{ get; set; }

        /// <summary>
        /// <p>Whether to enable vidu intelligent frame interpolation. Valid values: <li>Enabled: Enable;</li> <li>Disabled: Disable;</li></p>
        /// </summary>
        [JsonProperty("FrameInterpolate")]
        public string FrameInterpolate{ get; set; }

        /// <summary>
        /// <p>Indicates whether to enable the icon watermark. Valid values: <li>Enabled: Enable;</li> <li>Disabled: Disable;</li><br>Currently supported models include Vidu. Other models are not supported.</p>
        /// </summary>
        [JsonProperty("LogoAdd")]
        public string LogoAdd{ get; set; }

        /// <summary>
        /// <p>Whether to add background music to the generated video.</p><p>Enumeration value:</p><ul><li>Enabled: The system will automatically select suitable music from the preset BGM library and add it.</li><li>Disabled: Do not add BGM.</li></ul><p>Default value: Disabled</p>
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

