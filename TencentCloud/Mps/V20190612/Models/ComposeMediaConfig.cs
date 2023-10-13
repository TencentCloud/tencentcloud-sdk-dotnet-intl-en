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

    public class ComposeMediaConfig : AbstractModel
    {
        
        /// <summary>
        /// The information of the output video.
        /// </summary>
        [JsonProperty("TargetInfo")]
        public ComposeTargetInfo TargetInfo{ get; set; }

        /// <summary>
        /// The canvas information of the output video.
        /// </summary>
        [JsonProperty("Canvas")]
        public ComposeCanvas Canvas{ get; set; }

        /// <summary>
        /// The global styles. This parameter is used together with `Tracks` to specify styles, such as the subtitle style.
        /// </summary>
        [JsonProperty("Styles")]
        public ComposeStyles[] Styles{ get; set; }

        /// <summary>
        /// The information of media tracks (consisting of video, audio, image, and text elements) used to composite the video. About tracks and the timeline:
        /// <ul><li>The timeline of a track is the same as the timeline of the output video. </li><li>The elements of different tracks are overlaid at the same time point in the timeline.</li><ul><li>Video, image, and text elements are overlaid according to their track number, with the first track on top. </li><li>Audio elements are mixed. </li></ul></ul>Note: The different elements of the same track cannot be overlaid (except subtitles).
        /// </summary>
        [JsonProperty("Tracks")]
        public ComposeMediaTrack[] Tracks{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "TargetInfo.", this.TargetInfo);
            this.SetParamObj(map, prefix + "Canvas.", this.Canvas);
            this.SetParamArrayObj(map, prefix + "Styles.", this.Styles);
            this.SetParamArrayObj(map, prefix + "Tracks.", this.Tracks);
        }
    }
}

