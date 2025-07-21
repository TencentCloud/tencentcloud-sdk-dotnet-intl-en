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

    public class DescribeAutoScalingActivitiesRequest : AbstractModel
    {
        
        /// <summary>
        /// Queries by one or more scaling activity IDs in the format of `asa-5l2ejpfo`. The maximum quantity per request is 100. This parameter does not support specifying both `ActivityIds` and `Filters` at the same time.
        /// </summary>
        [JsonProperty("ActivityIds")]
        public string[] ActivityIds{ get; set; }

        /// <summary>
        /// Filter criteria. the filter field value ranges from...to.
        /// <ul>
        /// <li><strong>auto-scaling-group-id</strong><ul><li>Filter by [<strong>scaling group id</strong>]. you can log IN to the [console](https://console.cloud.tencent.com/autoscaling/group) or call the api [DescribeAutoScalingGroups](https://intl.cloud.tencent.com/document/api/377/20438?from_cn_redirect=1) to obtain the scaling group id from the returned information.</li><li>type: String</li><li>required: no</li><li>example value: asg-kiju7yt5</li></ul></li>  <li><strong>activity-status-code</strong><ul><li>filter by [<strong>scaling activity status</strong>]</li><li>type: String</li><li>required: no</li><li>options: </li><ul><li>INIT: initializing</li><li>RUNNING: RUNNING</li><li>SUCCESSFUL: SUCCESSFUL activity</li><li>PARTIALLY_SUCCESSFUL: PARTIALLY SUCCESSFUL activity</li><li>FAILED: activity FAILED</li><li>CANCELLED: activity CANCELLED</li></ul></ul></li>  <li><strong>activity-type</strong><ul><li>filter by [<strong>scaling activity type</strong>]</li><li>type: String</li><li>required: no</li><li>options: </li><ul><li>SCALE_OUT: SCALE-OUT activity</li><li>SCALE_IN: SCALE-IN activity</li><li>ATTACH_INSTANCES: adding INSTANCES</li><li>REMOVE_INSTANCES: terminating INSTANCES</li><li>DETACH_INSTANCES: REMOVE INSTANCE</li><li>TERMINATE_INSTANCES_UNEXPECTEDLY: TERMINATE INSTANCE IN CVM console</li><li>REPLACE_UNHEALTHY_INSTANCE: REPLACE UNHEALTHY INSTANCES</li><li>START_INSTANCES: START INSTANCES</li><li>STOP_INSTANCES: shut down INSTANCE</li><li>INVOKE_COMMAND: execute COMMAND</li></ul></ul></li>  <li><strong>activity-id</strong><ul><li>filter by [<strong>scaling activity id</strong>]. you can log IN to the [console](https://console.cloud.tencent.com/autoscaling/group) to obtain the scaling activity id.</li><li>type: String</li><li>required: no</li><li>example value: asa-hy6tr4ed</li></ul></li></ul>.
        /// The maximum number of `Filters` per request is 10. the upper limit for `Filter.Values` is 5. parameters must not specify both `ActivityIds` and `Filters` simultaneously.
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Number of returned results. Default value: 20. Maximum value: 100. For more information on `Limit`, see the relevant section in the API [overview](https://intl.cloud.tencent.com/document/api/213/15688?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Offset. Default value: 0. For more information on `Offset`, see the relevant section in the API [overview](https://intl.cloud.tencent.com/document/api/213/15688?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// The earliest start time of the scaling activity, which will be ignored if ActivityIds is specified. The value is in `UTC time` in the format of `YYYY-MM-DDThh:mm:ssZ` according to the `ISO8601` standard.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// The latest end time of the scaling activity, which will be ignored if ActivityIds is specified. The value is in `UTC time` in the format of `YYYY-MM-DDThh:mm:ssZ` according to the `ISO8601` standard.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ActivityIds.", this.ActivityIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
        }
    }
}

