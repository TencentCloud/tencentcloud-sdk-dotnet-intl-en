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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAllStreamPlayInfoListRequest : AbstractModel
    {
        
        /// <summary>
        /// Query time point accurate to the minute. You can query data within the last month. As there is a 5-minute delay in the data, you're advised to pass in a time point 5 minutes earlier than needed. Format: yyyy-mm-dd HH:MM:00. As the accuracy is to the minute, please set the value of second to `00`.
        /// </summary>
        [JsonProperty("QueryTime")]
        public string QueryTime{ get; set; }

        /// <summary>
        /// Playback domain name list. If this parameter is left empty, full data will be queried.
        /// </summary>
        [JsonProperty("PlayDomains")]
        public string[] PlayDomains{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "QueryTime", this.QueryTime);
            this.SetParamArraySimple(map, prefix + "PlayDomains.", this.PlayDomains);
        }
    }
}

