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

    public class SetWatermarkRequest : AbstractModel
    {
        
        /// <summary>
        /// The SDKAppID assigned by LCIC.
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// The URL of the watermark for the teacher’s video. If you pass in an empty string, the teacher’s video will not have a watermark.
        /// </summary>
        [JsonProperty("TeacherUrl")]
        public string TeacherUrl{ get; set; }

        /// <summary>
        /// The URL of the watermark for the whiteboard. If you pass in an empty string, the whiteboard video will not have a watermark.
        /// </summary>
        [JsonProperty("BoardUrl")]
        public string BoardUrl{ get; set; }

        /// <summary>
        /// The image displayed when there is no video. If you pass in an empty string, no images will be displayed.
        /// </summary>
        [JsonProperty("VideoUrl")]
        public string VideoUrl{ get; set; }

        /// <summary>
        /// The width of the whiteboard’s watermark, which is expressed as a percentage of the video width. The value range is 0-100, and the default value is 0.
        /// </summary>
        [JsonProperty("BoardW")]
        public float? BoardW{ get; set; }

        /// <summary>
        /// The height of the whiteboard’s watermark, which is expressed as a percentage of the video height. The value range is 0-100, and the default value is 0.
        /// </summary>
        [JsonProperty("BoardH")]
        public float? BoardH{ get; set; }

        /// <summary>
        /// The horizontal offset of the whiteboard’s watermark, which is expressed as a percentage of the video width. For example, 50 indicates that the watermark will appear in the middle horizontally. Value range: 0-100.
        /// </summary>
        [JsonProperty("BoardX")]
        public float? BoardX{ get; set; }

        /// <summary>
        /// The vertical offset of the whiteboard’s watermark, which is expressed as a percentage of the video width. For example, 50 indicates that the watermark will appear in the middle vertically. Value range: 0-100.
        /// </summary>
        [JsonProperty("BoardY")]
        public float? BoardY{ get; set; }

        /// <summary>
        /// The width of the watermark for the teacher’s video, which is expressed as a percentage of the video width. The value range is 0-100, and the default value is 0.
        /// </summary>
        [JsonProperty("TeacherW")]
        public float? TeacherW{ get; set; }

        /// <summary>
        /// The height of the watermark for the teacher’s video, which is expressed as a percentage of the video height. The value range is 0-100, and the default value is 0.
        /// </summary>
        [JsonProperty("TeacherH")]
        public float? TeacherH{ get; set; }

        /// <summary>
        /// The horizontal offset of the watermark for the teacher’s video, which is expressed as a percentage of the video width. For example, 50 indicates that the watermark will appear in the middle horizontally. Value range: 0-100.
        /// </summary>
        [JsonProperty("TeacherX")]
        public float? TeacherX{ get; set; }

        /// <summary>
        /// The vertical offset of the watermark for the teacher’s video, which is expressed as a percentage of the video width. For example, 50 indicates that the watermark will appear in the middle vertically. Value range: 0-100.
        /// </summary>
        [JsonProperty("TeacherY")]
        public float? TeacherY{ get; set; }

        /// <summary>
        /// The watermark text. If you pass in an empty string, there will be no text.
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// The watermark text color.
        /// </summary>
        [JsonProperty("TextColor")]
        public string TextColor{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "TeacherUrl", this.TeacherUrl);
            this.SetParamSimple(map, prefix + "BoardUrl", this.BoardUrl);
            this.SetParamSimple(map, prefix + "VideoUrl", this.VideoUrl);
            this.SetParamSimple(map, prefix + "BoardW", this.BoardW);
            this.SetParamSimple(map, prefix + "BoardH", this.BoardH);
            this.SetParamSimple(map, prefix + "BoardX", this.BoardX);
            this.SetParamSimple(map, prefix + "BoardY", this.BoardY);
            this.SetParamSimple(map, prefix + "TeacherW", this.TeacherW);
            this.SetParamSimple(map, prefix + "TeacherH", this.TeacherH);
            this.SetParamSimple(map, prefix + "TeacherX", this.TeacherX);
            this.SetParamSimple(map, prefix + "TeacherY", this.TeacherY);
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "TextColor", this.TextColor);
        }
    }
}

