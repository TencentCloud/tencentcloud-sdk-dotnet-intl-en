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

    public class CreateImageSettings : AbstractModel
    {
        
        /// <summary>
        /// Image file format. Valid values: png, jpg.
        /// </summary>
        [JsonProperty("ImageType")]
        public string ImageType{ get; set; }

        /// <summary>
        /// Base64 encoded image content
        /// </summary>
        [JsonProperty("ImageContent")]
        public string ImageContent{ get; set; }

        /// <summary>
        /// Origin. Valid values: TOP_LEFT, BOTTOM_LEFT, TOP_RIGHT, BOTTOM_RIGHT.
        /// </summary>
        [JsonProperty("Location")]
        public string Location{ get; set; }

        /// <summary>
        /// The watermark’s horizontal distance from the origin as a percentage of the video width. Value range: 0-100. Default: 10.
        /// </summary>
        [JsonProperty("XPos")]
        public long? XPos{ get; set; }

        /// <summary>
        /// The watermark’s vertical distance from the origin as a percentage of the video height. Value range: 0-100. Default: 10.
        /// </summary>
        [JsonProperty("YPos")]
        public long? YPos{ get; set; }

        /// <summary>
        /// The watermark image’s width as a percentage of the video width. Value range: 0-100. Default: 10.
        /// `0` means to scale the width proportionally to the height.
        /// You cannot set both `Width` and `Height` to `0`.
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// The watermark image’s height as a percentage of the video height. Value range: 0-100. Default: 10.
        /// `0` means to scale the height proportionally to the width.
        /// You cannot set both `Width` and `Height` to `0`.
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageType", this.ImageType);
            this.SetParamSimple(map, prefix + "ImageContent", this.ImageContent);
            this.SetParamSimple(map, prefix + "Location", this.Location);
            this.SetParamSimple(map, prefix + "XPos", this.XPos);
            this.SetParamSimple(map, prefix + "YPos", this.YPos);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
        }
    }
}

