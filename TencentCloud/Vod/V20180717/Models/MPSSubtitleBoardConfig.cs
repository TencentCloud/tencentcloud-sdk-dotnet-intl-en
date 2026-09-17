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

    public class MPSSubtitleBoardConfig : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SubtitleBoardConfigSwitch")]
        public long? SubtitleBoardConfigSwitch{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("BoardX")]
        public long? BoardX{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("BoardXUnit")]
        public long? BoardXUnit{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("BoardY")]
        public long? BoardY{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("BoardYUnit")]
        public long? BoardYUnit{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("BoardWidth")]
        public long? BoardWidth{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("BoardWidthUnit")]
        public long? BoardWidthUnit{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("BoardHeight")]
        public long? BoardHeight{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("BoardHeightUnit")]
        public long? BoardHeightUnit{ get; set; }

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
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubtitleBoardConfigSwitch", this.SubtitleBoardConfigSwitch);
            this.SetParamSimple(map, prefix + "BoardX", this.BoardX);
            this.SetParamSimple(map, prefix + "BoardXUnit", this.BoardXUnit);
            this.SetParamSimple(map, prefix + "BoardY", this.BoardY);
            this.SetParamSimple(map, prefix + "BoardYUnit", this.BoardYUnit);
            this.SetParamSimple(map, prefix + "BoardWidth", this.BoardWidth);
            this.SetParamSimple(map, prefix + "BoardWidthUnit", this.BoardWidthUnit);
            this.SetParamSimple(map, prefix + "BoardHeight", this.BoardHeight);
            this.SetParamSimple(map, prefix + "BoardHeightUnit", this.BoardHeightUnit);
            this.SetParamSimple(map, prefix + "BoardColor", this.BoardColor);
            this.SetParamSimple(map, prefix + "BoardAlpha", this.BoardAlpha);
        }
    }
}

