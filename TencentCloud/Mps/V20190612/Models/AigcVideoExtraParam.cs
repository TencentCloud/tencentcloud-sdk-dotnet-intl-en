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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AigcVideoExtraParam : AbstractModel
    {
        
        /// <summary>
        /// The resolution of the generated video, which is related to the selected model and set video duration.Supported resolution options for different models:1. Kling: 720P (default) and 1080P.2. Hailuo: 768P (default) and 1080P.3. Vidu: 720P (default) and 1080P.4. GV: 720P (default) and 1080P.5. OS: 720P. For images, only 1280x720 and 720x1280 are supported. Resolution cannot be specified.Note: In addition to the resolution supported by the model, 2K and 4K resolutions are also available.
        /// </summary>
        [JsonProperty("Resolution")]
        public string Resolution{ get; set; }

        /// <summary>
        /// The aspect ratio of the generated video.Support for this parameter by different models:1. Kling only supports this parameter for text-to-video, with aspect ratios of 16:9 (default), 9:16, and 1:1.2. Hailuo does not support this parameter.3. Vidu supports [16:9, 9:16, 4:3, 3:4, 1:1] for text-to-video and reference image-to-video only. Only q2 supports 4:3 and 3:4.4. GV supports 16:9 (default) and 9:16.5. OS only supports this parameter for text-to-video, with aspect ratios of 16:9 (default) and 9:16.Note: For more information about the supported aspect ratios of specific models, see the model website.
        /// </summary>
        [JsonProperty("AspectRatio")]
        public string AspectRatio{ get; set; }

        /// <summary>
        /// Indicates whether to add a logo watermark.1. Hailuo supports this parameter.2. Kling supports this parameter.
        /// 3. Vidu supports this parameter.
        /// </summary>
        [JsonProperty("LogoAdd")]
        public long? LogoAdd{ get; set; }

        /// <summary>
        /// Indicates whether to generate audio for the video. Valid values: true or false.Models that support this parameter:1. GV. Default value: true.2. OS. Default value: true.
        /// </summary>
        [JsonProperty("EnableAudio")]
        public bool? EnableAudio{ get; set; }

        /// <summary>
        /// Indicates whether to use the off-peak scheduling mode. Only Vidu supports this parameter.Tasks submitted in off-peak mode will be processed within 48 hours. Uncompleted tasks will be canceled.
        /// </summary>
        [JsonProperty("OffPeak")]
        public bool? OffPeak{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
            this.SetParamSimple(map, prefix + "AspectRatio", this.AspectRatio);
            this.SetParamSimple(map, prefix + "LogoAdd", this.LogoAdd);
            this.SetParamSimple(map, prefix + "EnableAudio", this.EnableAudio);
            this.SetParamSimple(map, prefix + "OffPeak", this.OffPeak);
        }
    }
}

