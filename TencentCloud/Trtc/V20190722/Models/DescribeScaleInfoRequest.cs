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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeScaleInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// The application ID, such as `1400xxxxxx`.
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// The start time, which is a Unix timestamp (seconds) in local time, such as `1590065777`.
        /// Note: Only data in the last 14 days can be queried.
        /// </summary>
        [JsonProperty("StartTime")]
        public ulong? StartTime{ get; set; }

        /// <summary>
        /// The end time, which is a Unix timestamp (seconds) in local time, such as `1590065877`. The end time and start time should preferably be more than 24 hours apart.
        /// Note: Data is collected on a daily basis. To query the data of a day, make sure the end time is later than 00:00 on that day. Otherwise, no data will be returned. For example, to query the data on the 20th, the end time must be later than 00:00 on the 20th.
        /// </summary>
        [JsonProperty("EndTime")]
        public ulong? EndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
        }
    }
}

