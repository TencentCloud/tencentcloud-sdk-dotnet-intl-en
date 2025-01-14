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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CompareFaceLivenessRequest : AbstractModel
    {
        
        /// <summary>
        /// Base64 string of the image for face comparison.
        /// - The size of the Base64-encoded image data can be up to 3 MB. JPG and PNG formats are supported.
        /// - Please use the standard Base64 encoding method (with = padding). Refer to RFC4648 for the encoding specification.
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// Base64 string of the video for liveness detection.
        /// - The size of the Base64-encoded video data can be up to 8 MB. MP4, AVI, and FLV formats are supported.
        /// -Use standard Base64 encoding (with = padding), following RFC4648.
        /// </summary>
        [JsonProperty("VideoBase64")]
        public string VideoBase64{ get; set; }

        /// <summary>
        /// Liveness detection type.
        /// -Values:
        /// ACTION is action mode.
        /// SILENT is silent mode.
        /// -Choose one of the two modes to pass in.
        /// </summary>
        [JsonProperty("LivenessType")]
        public string LivenessType{ get; set; }

        /// <summary>
        /// Control the action sequence. Action types include: 1 (open mouth), 2 (blink), 3 (nod), 4 (shake head). Supports one or two actions.
        /// -Required when the LivenessType parameter is set to ACTION.
        /// -Single action example: "1".
        /// -Multiple actions parameter passing example: "4,2".
        /// -When the LivenessType parameter is set to SILENT, leave it blank.
        /// </summary>
        [JsonProperty("ValidateData")]
        public string ValidateData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "VideoBase64", this.VideoBase64);
            this.SetParamSimple(map, prefix + "LivenessType", this.LivenessType);
            this.SetParamSimple(map, prefix + "ValidateData", this.ValidateData);
        }
    }
}

