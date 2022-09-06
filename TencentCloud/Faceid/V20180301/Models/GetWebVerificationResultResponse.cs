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

    public class GetWebVerificationResultResponse : AbstractModel
    {
        
        /// <summary>
        /// The final result of this verification. `0` indicates that the person is the same as that in the photo.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ErrorCode")]
        public long? ErrorCode{ get; set; }

        /// <summary>
        /// The description of the final verification result.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ErrorMsg")]
        public string ErrorMsg{ get; set; }

        /// <summary>
        /// The temporary URL of the best face screenshot collected from the video stream. It is valid for 10 minutes. Download the image if needed.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VideoBestFrameUrl")]
        public string VideoBestFrameUrl{ get; set; }

        /// <summary>
        /// The MD5 hash value of the best face screenshot collected from the video stream. It can be used to check whether the image content is consistent with the file content.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VideoBestFrameMd5")]
        public string VideoBestFrameMd5{ get; set; }

        /// <summary>
        /// The details list of this verification process.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VerificationDetailList")]
        public VerificationDetail[] VerificationDetailList{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("VideoUrl")]
        public string VideoUrl{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("VideoMd5")]
        public string VideoMd5{ get; set; }

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
            this.SetParamSimple(map, prefix + "ErrorCode", this.ErrorCode);
            this.SetParamSimple(map, prefix + "ErrorMsg", this.ErrorMsg);
            this.SetParamSimple(map, prefix + "VideoBestFrameUrl", this.VideoBestFrameUrl);
            this.SetParamSimple(map, prefix + "VideoBestFrameMd5", this.VideoBestFrameMd5);
            this.SetParamArrayObj(map, prefix + "VerificationDetailList.", this.VerificationDetailList);
            this.SetParamSimple(map, prefix + "VideoUrl", this.VideoUrl);
            this.SetParamSimple(map, prefix + "VideoMd5", this.VideoMd5);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

