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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MediaVideoStreamItem : AbstractModel
    {
        
        /// <summary>
        /// Bitrate of a video stream in bps.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Bitrate")]
        public long? Bitrate{ get; set; }

        /// <summary>
        /// Height of a video stream in px.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// Width of a video stream in px.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// Video stream codec, such as h264.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Codec")]
        public string Codec{ get; set; }

        /// <summary>
        /// Frame rate in Hz.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Fps")]
        public long? Fps{ get; set; }

        /// <summary>
        /// Color primaries
        /// Note: this field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("ColorPrimaries")]
        public string ColorPrimaries{ get; set; }

        /// <summary>
        /// Color space
        /// Note: this field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("ColorSpace")]
        public string ColorSpace{ get; set; }

        /// <summary>
        /// Color transfer
        /// Note: this field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("ColorTransfer")]
        public string ColorTransfer{ get; set; }

        /// <summary>
        /// HDR type
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("HdrType")]
        public string HdrType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Bitrate", this.Bitrate);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Codec", this.Codec);
            this.SetParamSimple(map, prefix + "Fps", this.Fps);
            this.SetParamSimple(map, prefix + "ColorPrimaries", this.ColorPrimaries);
            this.SetParamSimple(map, prefix + "ColorSpace", this.ColorSpace);
            this.SetParamSimple(map, prefix + "ColorTransfer", this.ColorTransfer);
            this.SetParamSimple(map, prefix + "HdrType", this.HdrType);
        }
    }
}

