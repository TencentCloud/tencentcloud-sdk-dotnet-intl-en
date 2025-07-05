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

namespace TencentCloud.Vm.V20201229.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageSegments : AbstractModel
    {
        
        /// <summary>
        /// This field is used to return the frame capturing time of a video segment in seconds. For video on demand files, this parameter indicates the time offset of the captured image from the video, such as 0 (no offset), 5 (5 seconds after the start of the video), and 10 (10 seconds after the start of the video). For live video stream files, this parameter returns the Unix timestamp of the image, such as `1594650717`.
        /// </summary>
        [JsonProperty("OffsetTime")]
        public string OffsetTime{ get; set; }

        /// <summary>
        /// This field is used to return the specific moderation result of a frame captured from a video segment. For details, see the description of the `ImageResult` data structure.
        /// </summary>
        [JsonProperty("Result")]
        public ImageResult Result{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OffsetTime", this.OffsetTime);
            this.SetParamObj(map, prefix + "Result.", this.Result);
        }
    }
}

