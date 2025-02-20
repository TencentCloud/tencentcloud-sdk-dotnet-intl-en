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
        /// Rate-Limiting value, in kb/s. enter a numerical value to specify the rate limit.
        /// </summary>
        [JsonProperty("MaxSpeed")]
        public string MaxSpeed{ get; set; }

        /// <summary>
        /// Rate-Limiting start value, which can be the download size or specified duration, in kb or s. this parameter is required when mode is set to limitafterspecificbytesdownloaded or limitafterspecificsecondsdownloaded. enter a numerical value to specify the download size or duration.
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

