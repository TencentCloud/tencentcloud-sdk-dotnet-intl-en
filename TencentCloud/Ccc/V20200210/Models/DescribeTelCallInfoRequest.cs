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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTelCallInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Start timestamp, Unix timestamp (query dimension only supports day, for example, to query may 1, you should pass startTime:"2023-05-01 00:00:00","endTime":"2023-05-01 23:59:59" timestamp; to query may 1 and may 2, you should pass startTime:"2023-05-01 00:00:00","endTime":"2023-05-02 23:59:59" timestamp)</p>.
        /// </summary>
        [JsonProperty("StartTimeStamp")]
        public long? StartTimeStamp{ get; set; }

        /// <summary>
        /// <p>End timestamp, Unix timestamp. the maximum query time range is 90 days (query dimension only supports day, for example, to query may 1, you should pass startTime:"2023-05-01 00:00:00","endTime":"2023-05-01 23:59:59" timestamp; to query may 1 and may 2, you should pass startTime:"2023-05-01 00:00:00","endTime":"2023-05-02 23:59:59" timestamp).</p>.
        /// </summary>
        [JsonProperty("EndTimeStamp")]
        public long? EndTimeStamp{ get; set; }

        /// <summary>
        /// <p>Application ID list. for multiple ids, the return value is the sum of multiple ids.</p>.
        /// </summary>
        [JsonProperty("SdkAppIdList")]
        public long?[] SdkAppIdList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTimeStamp", this.StartTimeStamp);
            this.SetParamSimple(map, prefix + "EndTimeStamp", this.EndTimeStamp);
            this.SetParamArraySimple(map, prefix + "SdkAppIdList.", this.SdkAppIdList);
        }
    }
}

