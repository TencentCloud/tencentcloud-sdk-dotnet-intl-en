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
        /// Base64 value of photos used for face comparison. 
        /// The size of image data encoded by Base64 shall not exceed 3M, only jpg and png are supported. 
        /// Please use standard Base64 encoding (use = for padding). Refer to RFC4648 for encoding specifications. 
        /// Example values: "/9j/4AAQSk... (total length:61944)KiiK//2Q=="
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// Base64 value of videos used for face comparison. 
        /// The size of videos data encoded by Base64 shall not exceed 8M, only mp4,avi,flv are supported. 
        /// Please use standard Base64 encoding (use = for padding). Refer to RFC4648 for encoding specifications. 
        /// Example values: "/9j/4AAQSk... (total length:61944)KiiK//2Q=="
        /// </summary>
        [JsonProperty("VideoBase64")]
        public string VideoBase64{ get; set; }

        /// <summary>
        /// The liveness detection type. Valid values: `ACTION`, and `SILENT`.
        /// `ACTION`: Motion mode; `SILENT`: silent mode. Select one of them.
        /// Example value: "SILENT"
        /// </summary>
        [JsonProperty("LivenessType")]
        public string LivenessType{ get; set; }

        /// <summary>
        /// When the "LivenessType" parameter is "ACTION", it must be specified.
        /// It is used to control the action sequence. Action types: 
        /// 1 (open mouth)
        /// 2 (blink)
        /// 3 (nod)
        /// 4 (shake head). 
        /// Select one or two from the four actions.
        /// Example of passing single action parameter: "1".
        /// Example of passing multiple action parameters: "4,2".
        /// When the "LivenessType" parameter value is "SILENT", it shall be unspecified.
        /// Example value: ""
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

