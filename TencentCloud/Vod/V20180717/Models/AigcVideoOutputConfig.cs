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
        /// Storage mode. valid values: <li>Permanent: Permanent storage. the generated video file will be stored in vod, and the FileId can be obtained from the event notification.</li> <li>Temporary: Temporary storage. the generated video file will not be stored in vod, and a Temporary access URL can be obtained from the event notification.</li>
        /// Default value: Temporary.
        /// </summary>
        [JsonProperty("StorageMode")]
        public string StorageMode{ get; set; }

        /// <summary>
        /// Output media filename, longest 64 characters. default filename is specified by the system.
        /// </summary>
        [JsonProperty("MediaName")]
        public string MediaName{ get; set; }

        /// <summary>
        /// Category ID, used to categorize and manage media. you can create a category and obtain the category ID via the [create category](https://www.tencentcloud.com/document/product/266/7812?from_cn_redirect=1) api.
        /// <Li>Default value: 0, indicate other categories.</li>.
        /// </summary>
        [JsonProperty("ClassId")]
        public long? ClassId{ get; set; }

        /// <summary>
        /// The expiry date of the output file. files will be deleted longer than this time. default is never expire. format according to ISO 8601 standard. see [ISO date format description](https://www.tencentcloud.comom/document/product/266/11732?from_cn_redirect=1#I).
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// Video duration, unit: seconds. <li>when ModelName is Kling, optional values: 5, 10, defaults to 5;</li> <li>when ModelName is Hailuo, optional values: 6, 10, defaults to 6;</li> <li>when ModelName is Vidu, specify 1-10;</li> <li>when ModelName is GV, optional values: 8, defaults to 8;</li> <li>when ModelName is OS, optional values: 4, 8, 12, defaults to 8;</li>
        /// </summary>
        [JsonProperty("Duration")]
        public float? Duration{ get; set; }

        /// <summary>
        /// Generated video resolution.
        /// <li>When ModelName is Kling, available values are 720P and 1080P, with a default value of 720P.</li>
        /// <li>When ModelName is Hailuo, optional values are 768P and 1080P, with a default value of 768P.</li>
        /// <li>When ModelName is Vidu, optional values are 720P, 1080P, defaults to 720P.</li>
        /// <li>When ModelName is GV, optional values are 720P, 1080P, with a default value of 720P.</li>
        /// <li>When ModelName is OS, the optional values are 720P.</li>
        /// </summary>
        [JsonProperty("Resolution")]
        public string Resolution{ get; set; }

        /// <summary>
        /// Specify the aspect ratio of the generated video.
        /// <li>When ModelName is Kling, for text-to-video, the optional values are 16:9, 9:16, 1:1, default is 16:9.</li>
        /// <li>When ModelName is Vidu, the optional values for video generation and image generation usage reference are 16:9, 9:16, 4:3, 3:4, and 1:1. among them, only version q2 supports 4:3 and 3:4.</li>
        /// <li>When ModelName is GV, optional values are 16:9 and 9:16, with a default value of 16:9.</li>
        /// <li>When ModelName is OS, for text-to-video, optional values are 16:9, 9:16, default is 16:9;</li>
        /// <li>When ModelName is Hailuo, it is not currently supported.</li>
        /// </summary>
        [JsonProperty("AspectRatio")]
        public string AspectRatio{ get; set; }

        /// <summary>
        /// Whether to generate audio. supported models include GV, OS, Vidu. valid values: <li>Enabled: enable;</li> <li>Disabled: disable;</li>
        /// Default value: Disabled.
        /// </summary>
        [JsonProperty("AudioGeneration")]
        public string AudioGeneration{ get; set; }

        /// <summary>
        /// Whether to allow figure or human face generation. valid values: <li>AllowAdult: allow adult generation.</li> <li>Disallowed: forbid including figures or human faces in images.</li>
        /// </summary>
        [JsonProperty("PersonGeneration")]
        public string PersonGeneration{ get; set; }

        /// <summary>
        /// Whether to enable compliance check for input content. valid values: <li>Enabled: enable;</li> <li>Disabled: disable;</li>
        /// </summary>
        [JsonProperty("InputComplianceCheck")]
        public string InputComplianceCheck{ get; set; }

        /// <summary>
        /// Whether to enable compliance check for output content. valid values: <li>Enabled: enable;</li> <li>Disabled: disable;</li>
        /// </summary>
        [JsonProperty("OutputComplianceCheck")]
        public string OutputComplianceCheck{ get; set; }

        /// <summary>
        /// Whether to enable video enhancement. valid values: <li>Enabled: enable;</li> <li>Disabled: disable;</li>
        /// Note:
        /// 1. when the selected resolution exceeds the resolution the model can generate, enhancement is enabled by default.
        /// 2. for resolutions that the model can directly output, you can also proactively select the model to directly output low-resolution images and use enhancement to obtain the specified resolution.
        /// </summary>
        [JsonProperty("EnhanceSwitch")]
        public string EnhanceSwitch{ get; set; }

        /// <summary>
        /// Whether to enable vidu intelligent frame interpolation. valid values: <li>Enabled: enable;</li> <li>Disabled: disable;</li>
        /// </summary>
        [JsonProperty("FrameInterpolate")]
        public string FrameInterpolate{ get; set; }


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
            this.SetParamSimple(map, prefix + "FrameInterpolate", this.FrameInterpolate);
        }
    }
}

