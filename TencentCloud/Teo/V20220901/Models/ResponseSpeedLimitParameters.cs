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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResponseSpeedLimitParameters : AbstractModel
    {
        
        /// <summary>
        /// Download speed limit mode. Valid values:
        /// <li>LimitUponDownload: download speed limit for the entire process;</li>
        /// <li>LimitAfterSpecificBytesDownloaded: Start speed limit after downloading specific bytes at full speed;</li>
        /// <li>LimitAfterSpecificSecondsDownloaded: Start rate limiting after downloading at full speed for a specified time.</li>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// Rate-limiting value. Specify the rate limit. Fill in a value with a unit or a variable. Currently supported unit: KB/s.
        /// </summary>
        [JsonProperty("MaxSpeed")]
        public string MaxSpeed{ get; set; }

        /// <summary>
        /// Speed limit start value, which can be the download size or specified duration. Fill in a value with a unit or a variable to specify the download size or duration.
        /// 
        /// -When Mode is LimitAfterSpecificBytesDownloaded, valid values of the unit are: KB;
        /// 
        /// -When Mode is LimitAfterSpecificSecondsDownloaded, valid values of the measurement unit: s.
        /// </summary>
        [JsonProperty("StartAt")]
        public string StartAt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "MaxSpeed", this.MaxSpeed);
            this.SetParamSimple(map, prefix + "StartAt", this.StartAt);
        }
    }
}

