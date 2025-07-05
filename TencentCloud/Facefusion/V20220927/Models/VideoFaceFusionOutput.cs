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

namespace TencentCloud.Facefusion.V20220927.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VideoFaceFusionOutput : AbstractModel
    {
        
        /// <summary>
        /// URL of the video output after video face fusion
        /// </summary>
        [JsonProperty("VideoUrl")]
        public string VideoUrl{ get; set; }

        /// <summary>
        /// MD5 value of the video output after video face fusion, which is used for verification
        /// </summary>
        [JsonProperty("VideoMD5")]
        public string VideoMD5{ get; set; }

        /// <summary>
        /// Video width
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// Video height
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// Frames per second
        /// </summary>
        [JsonProperty("FPS")]
        public long? FPS{ get; set; }

        /// <summary>
        /// Video duration, in seconds
        /// </summary>
        [JsonProperty("DurationInSec")]
        public float? DurationInSec{ get; set; }

        /// <summary>
        /// Number of frames
        /// </summary>
        [JsonProperty("Frame")]
        public long? Frame{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VideoUrl", this.VideoUrl);
            this.SetParamSimple(map, prefix + "VideoMD5", this.VideoMD5);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "FPS", this.FPS);
            this.SetParamSimple(map, prefix + "DurationInSec", this.DurationInSec);
            this.SetParamSimple(map, prefix + "Frame", this.Frame);
        }
    }
}

