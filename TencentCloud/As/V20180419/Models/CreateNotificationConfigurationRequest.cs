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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateNotificationConfigurationRequest : AbstractModel
    {
        
        /// <summary>
        /// Auto scaling group ID.
        /// </summary>
        [JsonProperty("AutoScalingGroupId")]
        public string AutoScalingGroupId{ get; set; }

        /// <summary>
        /// Notification type, i.e., the set of types of notifications to be subscribed to. Value range:
        /// <li>SCALE_OUT_SUCCESSFUL: scale-out succeeded</li>
        /// <li>SCALE_OUT_FAILED: scale-out failed</li>
        /// <li>SCALE_IN_SUCCESSFUL: scale-in succeeded</li>
        /// <li>SCALE_IN_FAILED: scale-in failed</li>
        /// <li>REPLACE_UNHEALTHY_INSTANCE_SUCCESSFUL: unhealthy instance replacement succeeded</li>
        /// <li>REPLACE_UNHEALTHY_INSTANCE_FAILED: unhealthy instance replacement failed</li>
        /// </summary>
        [JsonProperty("NotificationTypes")]
        public string[] NotificationTypes{ get; set; }

        /// <summary>
        /// Array of String | Notification group ID, which is the set of user group IDs and can be queried through the [DescribeUserGroup API](https://cloud.tencent.com/document/api/378/4404).
        /// </summary>
        [JsonProperty("NotificationUserGroupIds")]
        public string[] NotificationUserGroupIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoScalingGroupId", this.AutoScalingGroupId);
            this.SetParamArraySimple(map, prefix + "NotificationTypes.", this.NotificationTypes);
            this.SetParamArraySimple(map, prefix + "NotificationUserGroupIds.", this.NotificationUserGroupIds);
        }
    }
}

