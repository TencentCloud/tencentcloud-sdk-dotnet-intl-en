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
        /// Download rate limit mode. valid values:.
        /// <Li>LimitUponDownload: rate limit throughout the download process;</li>.
        /// <Li>LimitAfterSpecificBytesDownloaded: rate limit after downloading specific bytes at full speed;</li>.
        /// <Li>LimitAfterSpecificSecondsDownloaded: start speed limit after downloading at full speed for a specific duration.</li>.
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// The speed limit value specifies the size of the speed limit. fill in a value or variable with a unit. the currently supported unit is: KB/s.
        /// </summary>
        [JsonProperty("MaxSpeed")]
        public string MaxSpeed{ get; set; }

        /// <summary>
        /// The speed limit start value can be download size or specified duration. fill in a value with unit or variable to specify download size or specified duration.
        /// 
        /// -When the Mode value is LimitAfterSpecificBytesDownloaded, the valid values of the unit are: KB.
        /// 
        /// -When the Mode value is LimitAfterSpecificSecondsDownloaded, the valid value of the unit is: s.
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

