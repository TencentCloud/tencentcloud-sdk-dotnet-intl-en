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

namespace TencentCloud.Mdl.V20200326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WebVTTFontStyle : AbstractModel
    {
        
        /// <summary>
        /// Text color, RGB hexadecimal representation, 6 hexadecimal characters (no # needed).
        /// </summary>
        [JsonProperty("TextColor")]
        public string TextColor{ get; set; }

        /// <summary>
        /// Background color, RGB hexadecimal representation, 6 hexadecimal characters (no # needed).
        /// </summary>
        [JsonProperty("BackgroundColor")]
        public string BackgroundColor{ get; set; }

        /// <summary>
        /// Background opacity parameter, a number from 0 to 100, with 0 being the default for full transparency.
        /// </summary>
        [JsonProperty("BackgroundAlpha")]
        public long? BackgroundAlpha{ get; set; }

        /// <summary>
        /// Font size, in units of vh (1% of height), default value 0 means automatic.
        /// </summary>
        [JsonProperty("FontSize")]
        public long? FontSize{ get; set; }

        /// <summary>
        /// The position of the text box, default value AUTO, can be empty; represents the percentage of video height, supports integers from 0 to 100.
        /// </summary>
        [JsonProperty("Line")]
        public string Line{ get; set; }

        /// <summary>
        /// The alignment of the text box on the Line. Optional values: START, CENTER, END. Which can be empty.
        /// </summary>
        [JsonProperty("LineAlignment")]
        public string LineAlignment{ get; set; }

        /// <summary>
        /// The text box is positioned in another direction as a percentage of the video's width. It defaults to AUTO and can be empty.
        /// </summary>
        [JsonProperty("Position")]
        public string Position{ get; set; }

        /// <summary>
        /// The alignment of the text box on the Position. Optional values are LINE_LEFT, LINE_RIGHT, CENTER, and AUTO. The default value is AUTO, and it can be empty.
        /// </summary>
        [JsonProperty("PositionAlignment")]
        public string PositionAlignment{ get; set; }

        /// <summary>
        /// Text box size, a percentage of video width/height, with values (0, 100), default AUTO, can be empty.
        /// </summary>
        [JsonProperty("CueSize")]
        public string CueSize{ get; set; }

        /// <summary>
        /// Text alignment, with possible values  START, CENTER, END, LEFT, and RIGHT; the default value is CENTER, which can be empty.
        /// </summary>
        [JsonProperty("TextAlignment")]
        public string TextAlignment{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TextColor", this.TextColor);
            this.SetParamSimple(map, prefix + "BackgroundColor", this.BackgroundColor);
            this.SetParamSimple(map, prefix + "BackgroundAlpha", this.BackgroundAlpha);
            this.SetParamSimple(map, prefix + "FontSize", this.FontSize);
            this.SetParamSimple(map, prefix + "Line", this.Line);
            this.SetParamSimple(map, prefix + "LineAlignment", this.LineAlignment);
            this.SetParamSimple(map, prefix + "Position", this.Position);
            this.SetParamSimple(map, prefix + "PositionAlignment", this.PositionAlignment);
            this.SetParamSimple(map, prefix + "CueSize", this.CueSize);
            this.SetParamSimple(map, prefix + "TextAlignment", this.TextAlignment);
        }
    }
}

