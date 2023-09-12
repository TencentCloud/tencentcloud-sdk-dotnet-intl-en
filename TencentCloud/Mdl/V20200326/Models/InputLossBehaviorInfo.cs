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

namespace TencentCloud.Mdl.V20200326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InputLossBehaviorInfo : AbstractModel
    {
        
        /// <summary>
        /// The time to fill in the last video frame, unit ms, range 0-1000000, 1000000 means always inserting, default 0 means filling in black screen frame.
        /// </summary>
        [JsonProperty("RepeatLastFrameMs")]
        public ulong? RepeatLastFrameMs{ get; set; }

        /// <summary>
        /// Fill frame type, COLOR means solid color filling, IMAGE means picture filling, the default is COLOR.
        /// </summary>
        [JsonProperty("InputLossImageType")]
        public string InputLossImageType{ get; set; }

        /// <summary>
        /// When the type is COLOR, the corresponding rgb value
        /// </summary>
        [JsonProperty("ColorRGB")]
        public string ColorRGB{ get; set; }

        /// <summary>
        /// When the type is IMAGE, the corresponding image url value
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RepeatLastFrameMs", this.RepeatLastFrameMs);
            this.SetParamSimple(map, prefix + "InputLossImageType", this.InputLossImageType);
            this.SetParamSimple(map, prefix + "ColorRGB", this.ColorRGB);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
        }
    }
}

