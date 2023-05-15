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

    public class McuLayoutParams : AbstractModel
    {
        
        /// <summary>
        /// The layout mode. Valid values: 1 (floating), 2 (screen sharing), 3 (grid), 4 (custom). Floating, screen sharing, and grid are dynamic layouts. Custom layouts are static layouts.
        /// </summary>
        [JsonProperty("MixLayoutMode")]
        public ulong? MixLayoutMode{ get; set; }

        /// <summary>
        /// Whether to display users who publish only audio. 0: No; 1: Yes. This parameter is valid only if a dynamic layout is used. If you do not pass this parameter, 0 will be used.
        /// </summary>
        [JsonProperty("PureAudioHoldPlaceMode")]
        public ulong? PureAudioHoldPlaceMode{ get; set; }

        /// <summary>
        /// The details of a custom layout.
        /// </summary>
        [JsonProperty("MixLayoutList")]
        public McuLayout[] MixLayoutList{ get; set; }

        /// <summary>
        /// The information of the large video in screen sharing or floating layout mode.
        /// </summary>
        [JsonProperty("MaxVideoUser")]
        public MaxVideoUser MaxVideoUser{ get; set; }

        /// <summary>
        /// The image fill mode. This parameter is valid if the layout mode is screen sharing, floating, or grid. `0`: The image will be cropped. `1`: The image will be scaled. `2`: The image will be scaled and there may be black bars.
        /// </summary>
        [JsonProperty("RenderMode")]
        public ulong? RenderMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MixLayoutMode", this.MixLayoutMode);
            this.SetParamSimple(map, prefix + "PureAudioHoldPlaceMode", this.PureAudioHoldPlaceMode);
            this.SetParamArrayObj(map, prefix + "MixLayoutList.", this.MixLayoutList);
            this.SetParamObj(map, prefix + "MaxVideoUser.", this.MaxVideoUser);
            this.SetParamSimple(map, prefix + "RenderMode", this.RenderMode);
        }
    }
}

