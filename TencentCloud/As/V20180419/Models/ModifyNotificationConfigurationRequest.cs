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

    public class ModifyNotificationConfigurationRequest : AbstractModel
    {
        
        /// <summary>
        /// Specifies the notification ID that needs modification. get the notification ID by logging in to the [console](https://console.cloud.tencent.com/autoscaling/group) or calling the api [DescribeNotificationConfigurations](https://intl.cloud.tencent.com/document/api/377/33183?from_cn_redirect=1) and getting `AutoScalingNotificationId` from the returned information.
        /// </summary>
        [JsonProperty("AutoScalingNotificationId")]
        public string AutoScalingNotificationId{ get; set; }

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
        /// Notification GROUP ID, which is the USER GROUP ID collection. USER GROUP ID can be accessed through [ListGroups](https://intl.cloud.tencent.com/document/product/598/34589?from_cn_redirect=1). this parameter is valid only when `TargetType` is `USER_GROUP`.
        /// </summary>
        [JsonProperty("NotificationUserGroupIds")]
        public string[] NotificationUserGroupIds{ get; set; }

        /// <summary>
        /// The TDMQ CMQ QUEUE name. [the original CMQ is offline](https://intl.cloud.tencent.com/document/product/1496/83970?from_cn_redirect=1). currently, only TDMQ CMQ is recommended for use. this parameter is valid only when `TargetType` is `TDMQ_CMQ_QUEUE`.
        /// </summary>
        [JsonProperty("QueueName")]
        public string QueueName{ get; set; }

        /// <summary>
        /// The TDMQ CMQ TOPIC name. [original CMQ is offline](https://intl.cloud.tencent.com/document/product/1496/83970?from_cn_redirect=1). currently, only TDMQ CMQ is recommended for use. this parameter is valid only when `TargetType` is `TDMQ_CMQ_TOPIC`.
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoScalingNotificationId", this.AutoScalingNotificationId);
            this.SetParamArraySimple(map, prefix + "NotificationTypes.", this.NotificationTypes);
            this.SetParamArraySimple(map, prefix + "NotificationUserGroupIds.", this.NotificationUserGroupIds);
            this.SetParamSimple(map, prefix + "QueueName", this.QueueName);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
        }
    }
}

