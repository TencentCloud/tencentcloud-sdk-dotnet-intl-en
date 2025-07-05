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
        /// Start timestamp, unix timestamp (query dimension supports only daily. for example, to query may 1st, pass starttime:"2023-05-01 00:00:00","endtime":"2023-05-01 23:59:59" timestamp. to query may 1st and may 2nd, pass starttime:"2023-05-01 00:00:00","endtime":"2023-05-02 23:59:59" timestamp).
        /// </summary>
        [JsonProperty("StartTimeStamp")]
        public long? StartTimeStamp{ get; set; }

        /// <summary>
        /// End timestamp, unix timestamp, the query time range is up to 90 days (query dimension supports only daily. for example, to query may 1st, pass starttime:"2023-05-01 00:00:00","endtime":"2023-05-01 23:59:59" timestamp. to query may 1st and may 2nd, pass starttime:"2023-05-01 00:00:00","endtime":"2023-05-02 23:59:59" timestamp).
        /// </summary>
        [JsonProperty("EndTimeStamp")]
        public long? EndTimeStamp{ get; set; }

        /// <summary>
        /// Application id list, when having multiple ids, the returned value is the sum of all the ids.
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

