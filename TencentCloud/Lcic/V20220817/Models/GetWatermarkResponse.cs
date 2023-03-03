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

namespace TencentCloud.Lcic.V20220817.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetWatermarkResponse : AbstractModel
    {
        
        /// <summary>
        /// The watermark settings for the teacher’s video.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TeacherLogo")]
        public WatermarkConfig TeacherLogo{ get; set; }

        /// <summary>
        /// The watermark settings for the whiteboard.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BoardLogo")]
        public WatermarkConfig BoardLogo{ get; set; }

        /// <summary>
        /// The background image.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BackgroundPicture")]
        public BackgroundPictureConfig BackgroundPicture{ get; set; }

        /// <summary>
        /// The watermark text.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Text")]
        public TextMarkConfig Text{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "TeacherLogo.", this.TeacherLogo);
            this.SetParamObj(map, prefix + "BoardLogo.", this.BoardLogo);
            this.SetParamObj(map, prefix + "BackgroundPicture.", this.BackgroundPicture);
            this.SetParamObj(map, prefix + "Text.", this.Text);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

