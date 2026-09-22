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

    public class TextWatermarkTemplateInputForUpdate : AbstractModel
    {
        
        /// <summary>
        /// Font type. Currently two are supported:
        /// <li>simkai.ttf: support Chinese and English;</li>
        /// <li>arial.ttf: English only.</li>
        /// </summary>
        [JsonProperty("FontType")]
        public string FontType{ get; set; }

        /// <summary>
        /// Font size. Format: Npx, where N is a numerical value.
        /// </summary>
        [JsonProperty("FontSize")]
        public string FontSize{ get; set; }

        /// <summary>
        /// Text color. Format: 0xRRGGBB. Default value: 0xFFFFFF (white).
        /// </summary>
        [JsonProperty("FontColor")]
        public string FontColor{ get; set; }

        /// <summary>
        /// Text opacity, value ranges from 0 to 1.
        /// <li>0: completely transparent.</li>
        /// <li>1: completely opaque.</li>
        /// </summary>
        [JsonProperty("FontAlpha")]
        public float? FontAlpha{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FontType", this.FontType);
            this.SetParamSimple(map, prefix + "FontSize", this.FontSize);
            this.SetParamSimple(map, prefix + "FontColor", this.FontColor);
            this.SetParamSimple(map, prefix + "FontAlpha", this.FontAlpha);
        }
    }
}

