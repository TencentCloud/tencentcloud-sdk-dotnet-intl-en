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

    public class LivenessCompareRequest : AbstractModel
    {
        
        /// <summary>
        /// Base64 value of a photo for face comparison;
        /// Base64-encoded image data is up to 3 MB. Only JPG and PNG formats are supported.
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// Base64 value of a video for liveness detection;
        /// The size after Base64-encoding cannot exceed 5 MB. MP4, AVI, and FLV formats are supported.
        /// </summary>
        [JsonProperty("VideoBase64")]
        public string VideoBase64{ get; set; }

        /// <summary>
        /// Liveness detection type. Valid values: LIP/ACTION/SILENT.
        /// LIP: numeric mode; ACTION: motion mode; SILENT: silent mode. You need to select a mode to input.
        /// </summary>
        [JsonProperty("LivenessType")]
        public string LivenessType{ get; set; }

        /// <summary>
        /// Input parameter for the numeric mode: numeric verification code (1234). An API needs to be called first to get a numeric verification code;
        /// Input parameter for the motion mode: motion order (2,1 or 1,2). An API needs to be called first to get the motion order;
        /// Input parameter for silent mode: empty.
        /// </summary>
        [JsonProperty("ValidateData")]
        public string ValidateData{ get; set; }

        /// <summary>
        /// This parameter does not need to be passed in for this API.
        /// </summary>
        [JsonProperty("Optional")]
        public string Optional{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "VideoBase64", this.VideoBase64);
            this.SetParamSimple(map, prefix + "LivenessType", this.LivenessType);
            this.SetParamSimple(map, prefix + "ValidateData", this.ValidateData);
            this.SetParamSimple(map, prefix + "Optional", this.Optional);
        }
    }
}

