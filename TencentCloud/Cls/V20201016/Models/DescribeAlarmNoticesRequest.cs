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

    public class DescribeAlarmNoticesRequest : AbstractModel
    {
        
        /// <summary>
        /// name
        /// Filter by [notification channel group name].
        /// Type: String
        /// "Filters":[{"Key":"name","Values":["test-notice"]}]
        /// Required: No
        /// alarmNoticeId
        /// Filter by [notification channel group ID].
        /// Type: String
        /// "Filters": [{Key: "alarmNoticeId", Values: ["notice-5281f1d2-6275-4e56-9ec3-a1eb19d8bc2f"]}]
        /// Required: No
        /// uid
        /// Filter by [recipient user ID].
        /// Type: String
        /// "Filters": [{Key: "uid", Values: ["1137546"]}]
        /// Required: No
        /// groupId
        /// Filter by [recipient user group ID].
        /// Type: String
        /// "Filters": [{Key: "groupId", Values: ["344098"]}]
        /// Required: No
        /// 
        /// deliverFlag
        /// Filter by [delivery status].
        /// Type: String
        /// Required: No
        /// Available values: "1": disabled, "2": enabled, "3": delivery exception
        /// "Filters":[{"Key":"deliverFlag","Values":["2"]}]
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
        /// Whether to return the quantity information of alarm silence statistics status in the configured notification channel group.
        /// - true: Need to return.
        /// - false: do not return (default false).
        /// </summary>
        [JsonProperty("HasAlarmShieldCount")]
        public bool? HasAlarmShieldCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "HasAlarmShieldCount", this.HasAlarmShieldCount);
        }
    }
}

