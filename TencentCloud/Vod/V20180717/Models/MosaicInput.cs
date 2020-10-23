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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MosaicInput : AbstractModel
    {
        
        /// <summary>
        /// Origin position, which currently can only be:
        /// <li>TopLeft: the origin of coordinates is in the top-left corner of the video, and the origin of the blur is in the top-left corner of the image or text.</li>
        /// Default value: TopLeft.
        /// </summary>
        [JsonProperty("CoordinateOrigin")]
        public string CoordinateOrigin{ get; set; }

        /// <summary>
        /// The horizontal position of the origin of the blur relative to the origin of coordinates of the video. % and px formats are supported:
        /// <li>If the string ends in %, the `XPos` of the blur will be the specified percentage of the video width; for example, `10%` means that `XPos` is 10% of the video width;</li>
        /// <li>If the string ends in px, the `XPos` of the blur will be the specified px; for example, `100px` means that `XPos` is 100 px.</li>
        /// Default value: 0 px.
        /// </summary>
        [JsonProperty("XPos")]
        public string XPos{ get; set; }

        /// <summary>
        /// Vertical position of the origin of blur relative to the origin of coordinates of video. % and px formats are supported:
        /// <li>If the string ends in %, the `YPos` of the blur will be the specified percentage of the video height; for example, `10%` means that `YPos` is 10% of the video height;</li>
        /// <li>If the string ends in px, the `YPos` of the blur will be the specified px; for example, `100px` means that `YPos` is 100 px.</li>
        /// Default value: 0 px.
        /// </summary>
        [JsonProperty("YPos")]
        public string YPos{ get; set; }

        /// <summary>
        /// Blur width. % and px formats are supported:
        /// <li>If the string ends in %, the `Width` of the blur will be the specified percentage of the video width; for example, `10%` means that `Width` is 10% of the video width;</li>
        /// <li>If the string ends in px, the `Width` of the blur will be in px; for example, `100px` means that `Width` is 100 px.</li>
        /// Default value: 10%.
        /// </summary>
        [JsonProperty("Width")]
        public string Width{ get; set; }

        /// <summary>
        /// Blur height. % and px formats are supported:
        /// <li>If the string ends in %, the `Height` of the blur will be the specified percentage of the video height; for example, `10%` means that `Height` is 10% of the video height;</li>
        /// <li>If the string ends in px, the `Height` of the blur will be in px; for example, `100px` means that `Height` is 100 px.</li>
        /// Default value: 10%.
        /// </summary>
        [JsonProperty("Height")]
        public string Height{ get; set; }

        /// <summary>
        /// Start time offset of blur in seconds. If this parameter is left empty or 0 is entered, the blur will appear upon the first video frame.
        /// <li>If this parameter is left empty or 0 is entered, the blur will appear upon the first video frame;</li>
        /// <li>If this value is greater than 0 (e.g., n), the blur will appear at second n after the first video frame;</li>
        /// <li>If this value is smaller than 0 (e.g., -n), the blur will appear at second n before the last video frame.</li>
        /// </summary>
        [JsonProperty("StartTimeOffset")]
        public float? StartTimeOffset{ get; set; }

        /// <summary>
        /// End time offset of blur in seconds.
        /// <li>If this parameter is left empty or 0 is entered, the blur will exist till the last video frame;</li>
        /// <li>If this value is greater than 0 (e.g., n), the blur will exist till second n;</li>
        /// <li>If this value is smaller than 0 (e.g., -n), the blur will exist till second n before the last video frame.</li>
        /// </summary>
        [JsonProperty("EndTimeOffset")]
        public float? EndTimeOffset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CoordinateOrigin", this.CoordinateOrigin);
            this.SetParamSimple(map, prefix + "XPos", this.XPos);
            this.SetParamSimple(map, prefix + "YPos", this.YPos);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "StartTimeOffset", this.StartTimeOffset);
            this.SetParamSimple(map, prefix + "EndTimeOffset", this.EndTimeOffset);
        }
    }
}

