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

    public class DescribeAutoScalingGroupsRequest : AbstractModel
    {
        
        /// <summary>
        /// Queries by one or more auto scaling group IDs in the format of `asg-nkdwoui0`. The maximum quantity per request is 100. This parameter does not support specifying both `AutoScalingGroupIds` and `Filters` at the same time.
        /// </summary>
        [JsonProperty("AutoScalingGroupIds")]
        public string[] AutoScalingGroupIds{ get; set; }

        /// <summary>
        /// Filter criteria
        /// 
        /// <li> auto-scaling-group-id - String - required: no - (filter) filter by auto scaling group id.</li>.
        /// Specifies the scaling group ID obtained by logging in to the [console](https://console.cloud.tencent.com/autoscaling/group) or calling the api [DescribeAutoScalingGroups](https://intl.cloud.tencent.com/document/api/377/20438?from_cn_redirect=1) and retrieving the AutoScalingGroupId from the return information.
        /// <li> auto-scaling-group-name - String - required: no - (filter) filter by auto scaling group name.</li>.
        /// <li> vague-auto-scaling-group-name - String - required: no - (filter) filter by scaling group name fuzzy search.</li>.
        /// <li>launch-configuration-id - String - required: no - (filter condition) filter by launch configuration id. you can obtain the launch configuration id by logging in to the console (https://console.cloud.tencent.com/autoscaling/config) or calling the api DescribeLaunchConfigurations (https://intl.cloud.tencent.com/document/api/377/20445?from_cn_redirect=1) and retrieving the LaunchConfigurationId from the returned information.</li>.
        /// <li> `tag-key` - String - optional - filter by the tag key. you can call the API [GetTags](https://intl.cloud.tencent.com/document/product/651/72275?from_cn_redirect=1) to obtain the tag key from the returned information.</li>.
        /// <li>tag-value - String - required: no - (filter condition) filter by tag value. you can obtain the tag value by calling the API [GetTags](https://intl.cloud.tencent.com/document/product/651/72275?from_cn_redirect=1) and retrieving the TagValue from the returned information.</li>.
        /// <li>tag:tag-key - String - required: no - (filter condition) filter by tag key-value pair. replace tag-key with a specific tag key. see example 2 for reference. call the API [GetTags](https://intl.cloud.tencent.com/document/product/651/72275?from_cn_redirect=1) to obtain the TagKey from the returned information.</li>.
        /// The maximum number of `Filters` per request is 10, and that of `Filter.Values` is 5. the `AutoScalingGroupIds` and `Filters` parameters cannot be specified simultaneously.
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
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "AutoScalingGroupIds.", this.AutoScalingGroupIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}

