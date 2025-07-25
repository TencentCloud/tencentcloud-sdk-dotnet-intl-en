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

    public class DescribeAutoScalingGroupLastActivitiesRequest : AbstractModel
    {
        
        /// <summary>
        /// Auto scaling group ID list. obtain the scaling group ID by logging in to the console (https://console.cloud.tencent.com/autoscaling/group) or calling the api DescribeAutoScalingGroups (https://intl.cloud.tencent.com/document/api/377/20438?from_cn_redirect=1) and retrieving AutoScalingGroupId from the returned information.
        /// </summary>
        [JsonProperty("AutoScalingGroupIds")]
        public string[] AutoScalingGroupIds{ get; set; }

        /// <summary>
        /// Excludes cancelled type activities when querying. Default value is false, which means cancelled type activities are not excluded.
        /// </summary>
        [JsonProperty("ExcludeCancelledActivity")]
        public bool? ExcludeCancelledActivity{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "AutoScalingGroupIds.", this.AutoScalingGroupIds);
            this.SetParamSimple(map, prefix + "ExcludeCancelledActivity", this.ExcludeCancelledActivity);
        }
    }
}

