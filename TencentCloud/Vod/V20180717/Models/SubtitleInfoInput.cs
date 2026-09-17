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

    public class SubtitleInfoInput : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("StreamIndex")]
        public long? StreamIndex{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("FontType")]
        public string FontType{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("FontSize")]
        public string FontSize{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("FontColor")]
        public string FontColor{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("FontAlpha")]
        public float? FontAlpha{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("YPos")]
        public string YPos{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("BoardY")]
        public string BoardY{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("BoardWidth")]
        public string BoardWidth{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("BoardHeight")]
        public string BoardHeight{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("BoardColor")]
        public string BoardColor{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("BoardAlpha")]
        public float? BoardAlpha{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Alignment")]
        public string Alignment{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("OutlineWidth")]
        public string OutlineWidth{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("OutlineColor")]
        public string OutlineColor{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("OutlineAlpha")]
        public float? OutlineAlpha{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ShadowWidth")]
        public string ShadowWidth{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ShadowColor")]
        public string ShadowColor{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ShadowAlpha")]
        public float? ShadowAlpha{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("LineSpacing")]
        public string LineSpacing{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "StreamIndex", this.StreamIndex);
            this.SetParamSimple(map, prefix + "FontType", this.FontType);
            this.SetParamSimple(map, prefix + "FontSize", this.FontSize);
            this.SetParamSimple(map, prefix + "FontColor", this.FontColor);
            this.SetParamSimple(map, prefix + "FontAlpha", this.FontAlpha);
            this.SetParamSimple(map, prefix + "YPos", this.YPos);
            this.SetParamSimple(map, prefix + "BoardY", this.BoardY);
            this.SetParamSimple(map, prefix + "BoardWidth", this.BoardWidth);
            this.SetParamSimple(map, prefix + "BoardHeight", this.BoardHeight);
            this.SetParamSimple(map, prefix + "BoardColor", this.BoardColor);
            this.SetParamSimple(map, prefix + "BoardAlpha", this.BoardAlpha);
            this.SetParamSimple(map, prefix + "Alignment", this.Alignment);
            this.SetParamSimple(map, prefix + "OutlineWidth", this.OutlineWidth);
            this.SetParamSimple(map, prefix + "OutlineColor", this.OutlineColor);
            this.SetParamSimple(map, prefix + "OutlineAlpha", this.OutlineAlpha);
            this.SetParamSimple(map, prefix + "ShadowWidth", this.ShadowWidth);
            this.SetParamSimple(map, prefix + "ShadowColor", this.ShadowColor);
            this.SetParamSimple(map, prefix + "ShadowAlpha", this.ShadowAlpha);
            this.SetParamSimple(map, prefix + "LineSpacing", this.LineSpacing);
        }
    }
}

