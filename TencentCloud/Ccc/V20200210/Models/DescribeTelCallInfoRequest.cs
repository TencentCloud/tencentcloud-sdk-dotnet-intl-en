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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTelCallInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// Start timestamp Unix timestamp (supports only day dimension. For example, for querying May 1st, you should pass a timestamp from "2023-05-01 00:00:00" to "2023-05-01 23:59:59" and for querying both May 1st and 2nd, you should pass a timestamp from "2023-05-01 00:00:00" to "2023-05-02 23:59:59").
        /// </summary>
        [JsonProperty("StartTimeStamp")]
        public long? StartTimeStamp{ get; set; }

        /// <summary>
        /// End timestamp. Unix timestamp and the maximum query time range is 90 days (supports only day dimension, for example, for querying May 1st, you should pass timestamp from "2023-05-01 00:00:00" to "2023-05-01 23:59:59" and for querying both May 1st and May 2nd, you should pass timestamp from "2023-05-01 00:00:00" to "2023-05-02 23:59:59").
        /// </summary>
        [JsonProperty("EndTimeStamp")]
        public long? EndTimeStamp{ get; set; }

        /// <summary>
        /// Application ID list, when having multiple IDs, the returned value is the sum of all the IDs.
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

