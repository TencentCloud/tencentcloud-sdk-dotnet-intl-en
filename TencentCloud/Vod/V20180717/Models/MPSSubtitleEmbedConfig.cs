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

    public class MPSSubtitleEmbedConfig : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("FontType")]
        public string FontType{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("FontPath")]
        public string FontPath{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("FontSize")]
        public long? FontSize{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("FontSizeUnit")]
        public long? FontSizeUnit{ get; set; }

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
        [JsonProperty("PosX")]
        public long? PosX{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("PosXUnit")]
        public long? PosXUnit{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("PosY")]
        public long? PosY{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("PosYUnit")]
        public long? PosYUnit{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SubtitleBoardConfig")]
        public MPSSubtitleBoardConfig SubtitleBoardConfig{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SubtitleLayoutConfig")]
        public MPSSubtitleLayoutConfig SubtitleLayoutConfig{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SubtitleOutlineConfig")]
        public MPSSubtitleOutlineConfig SubtitleOutlineConfig{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SubtitleShadowConfig")]
        public MPSSubtitleShadowConfig SubtitleShadowConfig{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SampleWidth")]
        public long? SampleWidth{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SampleHeight")]
        public long? SampleHeight{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FontType", this.FontType);
            this.SetParamSimple(map, prefix + "FontPath", this.FontPath);
            this.SetParamSimple(map, prefix + "FontSize", this.FontSize);
            this.SetParamSimple(map, prefix + "FontSizeUnit", this.FontSizeUnit);
            this.SetParamSimple(map, prefix + "FontColor", this.FontColor);
            this.SetParamSimple(map, prefix + "FontAlpha", this.FontAlpha);
            this.SetParamSimple(map, prefix + "PosX", this.PosX);
            this.SetParamSimple(map, prefix + "PosXUnit", this.PosXUnit);
            this.SetParamSimple(map, prefix + "PosY", this.PosY);
            this.SetParamSimple(map, prefix + "PosYUnit", this.PosYUnit);
            this.SetParamObj(map, prefix + "SubtitleBoardConfig.", this.SubtitleBoardConfig);
            this.SetParamObj(map, prefix + "SubtitleLayoutConfig.", this.SubtitleLayoutConfig);
            this.SetParamObj(map, prefix + "SubtitleOutlineConfig.", this.SubtitleOutlineConfig);
            this.SetParamObj(map, prefix + "SubtitleShadowConfig.", this.SubtitleShadowConfig);
            this.SetParamSimple(map, prefix + "SampleWidth", this.SampleWidth);
            this.SetParamSimple(map, prefix + "SampleHeight", this.SampleHeight);
        }
    }
}

