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

namespace TencentCloud.Iss.V20230517.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeVideoDownloadUrlData : AbstractModel
    {
        
        /// <summary>
        /// Video recording file download URL
        /// Note:
        /// The URL is valid for 10 minutes. Access will be denied after expiry. Obtain a new one if needed. 
        /// Video file download uses chunked transfer encoding, and the response header is Transfer-Encoding: chunked. 
        /// The naming format of the downloaded file is {ChannelId}-{BeginTime}-{EndTime}.{FileType}
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// Actual download start time of the video recording
        /// Note: This field is returned only when the IsRespActualTime parameter is set to true in the request.
        /// </summary>
        [JsonProperty("ActualBeginTime")]
        public string ActualBeginTime{ get; set; }

        /// <summary>
        /// Actual download end time of the video recording
        /// Note: This field is returned only when the IsRespActualTime parameter is set to true in the request.
        /// </summary>
        [JsonProperty("ActualEndTime")]
        public string ActualEndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "ActualBeginTime", this.ActualBeginTime);
            this.SetParamSimple(map, prefix + "ActualEndTime", this.ActualEndTime);
        }
    }
}

