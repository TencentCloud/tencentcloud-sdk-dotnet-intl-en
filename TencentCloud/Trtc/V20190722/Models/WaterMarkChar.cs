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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WaterMarkChar : AbstractModel
    {
        
        /// <summary>
        /// The Y coordinate of the text watermark from the top left.
        /// </summary>
        [JsonProperty("Top")]
        public ulong? Top{ get; set; }

        /// <summary>
        /// The X coordinate of the text watermark from the top left.
        /// </summary>
        [JsonProperty("Left")]
        public ulong? Left{ get; set; }

        /// <summary>
        /// The watermark width (pixels).
        /// </summary>
        [JsonProperty("Width")]
        public ulong? Width{ get; set; }

        /// <summary>
        /// The watermark height (pixels).
        /// </summary>
        [JsonProperty("Height")]
        public ulong? Height{ get; set; }

        /// <summary>
        /// The text.
        /// </summary>
        [JsonProperty("Chars")]
        public string Chars{ get; set; }

        /// <summary>
        /// The font size (pixels). The default value is `14`.
        /// </summary>
        [JsonProperty("FontSize")]
        public ulong? FontSize{ get; set; }

        /// <summary>
        /// The text color. The default color is white.
        /// </summary>
        [JsonProperty("FontColor")]
        public string FontColor{ get; set; }

        /// <summary>
        /// The background color. If this parameter is empty, the background will be transparent (default).
        /// </summary>
        [JsonProperty("BackGroundColor")]
        public string BackGroundColor{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Top", this.Top);
            this.SetParamSimple(map, prefix + "Left", this.Left);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "Chars", this.Chars);
            this.SetParamSimple(map, prefix + "FontSize", this.FontSize);
            this.SetParamSimple(map, prefix + "FontColor", this.FontColor);
            this.SetParamSimple(map, prefix + "BackGroundColor", this.BackGroundColor);
        }
    }
}

