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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRecordingUsageRequest : AbstractModel
    {
        
        /// <summary>
        /// The start date in the format of YYYY-MM-DD.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// The end date in the format of YYYY-MM-DD.
        /// The period queried per request cannot be longer than 31 days.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Whether to query single-stream or mixed-stream recording. Valid values: `single`, `multi`.
        /// </summary>
        [JsonProperty("MixType")]
        public string MixType{ get; set; }

        /// <summary>
        /// The `SDKAppID` of the TRTC application to which the target room belongs. If you do not specify this parameter, the usage statistics of all TRTC applications under the current account will be returned.
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "MixType", this.MixType);
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
        }
    }
}

