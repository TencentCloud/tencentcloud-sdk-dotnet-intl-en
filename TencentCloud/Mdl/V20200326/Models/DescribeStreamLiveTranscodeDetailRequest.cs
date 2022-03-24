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

namespace TencentCloud.Mdl.V20200326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeStreamLiveTranscodeDetailRequest : AbstractModel
    {
        
        /// <summary>
        /// The query start time (UTC+8) in the format of yyyy-MM-dd.
        /// You can only query data in the last month (not including the current day).
        /// </summary>
        [JsonProperty("StartDayTime")]
        public string StartDayTime{ get; set; }

        /// <summary>
        /// The query end time (UTC+8) in the format of yyyy-MM-dd.
        /// You can only query data in the last month (not including the current day).
        /// </summary>
        [JsonProperty("EndDayTime")]
        public string EndDayTime{ get; set; }

        /// <summary>
        /// The channel ID (optional).
        /// </summary>
        [JsonProperty("ChannelId")]
        public string ChannelId{ get; set; }

        /// <summary>
        /// The number of pages. Default value: 1.
        /// The value cannot exceed 100.
        /// </summary>
        [JsonProperty("PageNum")]
        public long? PageNum{ get; set; }

        /// <summary>
        /// The number of records per page. Default value: 10.
        /// Value range: 1-1000.
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartDayTime", this.StartDayTime);
            this.SetParamSimple(map, prefix + "EndDayTime", this.EndDayTime);
            this.SetParamSimple(map, prefix + "ChannelId", this.ChannelId);
            this.SetParamSimple(map, prefix + "PageNum", this.PageNum);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
        }
    }
}

