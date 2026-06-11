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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAlarmsRequest : AbstractModel
    {
        
        /// <summary>
        /// name
        /// -Filter by [alarm policy name].
        /// -Type: String
        /// -Optional: No.
        /// -Example: test-alarm
        /// 
        /// alarmId
        /// -Filter by [alert policy ID].
        /// -Type: String
        /// -Optional: No.
        /// -Example: alarm-b60cf034-c3d6-4b01-xxxx-4e877ebb4751
        /// 
        /// topicId
        /// -Filter by [log topic ID of the monitored object].
        /// -Type: String
        /// -Optional: No.
        /// -Example: 6766f83d-659e-xxxx-a8f7-9104a1012743
        /// 
        /// enable
        /// -Filter by [Enabled status].
        /// -Type: String
        /// -Remark: The parameter value range for enable is 1, t, T, TRUE, true, True, 0, f, F, FALSE, false, False. Other values will return error information.
        /// -Optional: No.
        /// -Example: true
        /// 
        /// The maximum number of Filters per request is 10, and the maximum for Filter.Values is 5.
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Page offset. Default value: 0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Maximum number of entries per page. Default value: 20. Maximum value: 100.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

