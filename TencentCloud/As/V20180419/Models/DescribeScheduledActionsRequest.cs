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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeScheduledActionsRequest : AbstractModel
    {
        
        /// <summary>
        /// Query by one or more scheduled task ids. you can obtain the scheduled task ID by logging in to the console (https://console.cloud.tencent.com/autoscaling/group). the maximum number of instances per request is 100. parameters ScheduledActionIds and Filters must not be specified simultaneously.
        /// </summary>
        [JsonProperty("ScheduledActionIds")]
        public string[] ScheduledActionIds{ get; set; }

        /// <summary>
        /// Filter criteria. obtain the scheduled task ID, scheduled task name, and scaling group ID by logging in to the console (https://console.cloud.tencent.com/autoscaling/group).
        /// <li> scheduled-action-id - String - required: no - (filter) filter by scheduled task id.</li>.
        /// <li> scheduled-action-name - String - required: no - (filter criteria) filters by scheduled task name.</li>.
        /// <li> auto-scaling-group-id - String - required: no - (filter) filter by auto scaling group id.</li>.
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Offset. Default value: 0. For more information on `Offset`, see the relevant section in the API [overview](https://intl.cloud.tencent.com/document/api/213/15688?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Number of returned results. Default value: 20. Maximum value: 100. For more information on `Limit`, see the relevant section in the API [overview](https://intl.cloud.tencent.com/document/api/213/15688?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ScheduledActionIds.", this.ScheduledActionIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

