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

    public class AutoScalingNotification : AbstractModel
    {
        
        /// <summary>
        /// Auto scaling group ID.
        /// </summary>
        [JsonProperty("AutoScalingGroupId")]
        public string AutoScalingGroupId{ get; set; }

        /// <summary>
        /// List of user group IDs.
        /// </summary>
        [JsonProperty("NotificationUserGroupIds")]
        public string[] NotificationUserGroupIds{ get; set; }

        /// <summary>
        /// List of notification events.
        /// </summary>
        [JsonProperty("NotificationTypes")]
        public string[] NotificationTypes{ get; set; }

        /// <summary>
        /// Event notification ID.
        /// </summary>
        [JsonProperty("AutoScalingNotificationId")]
        public string AutoScalingNotificationId{ get; set; }

        /// <summary>
        /// Notification receiver type.
        /// </summary>
        [JsonProperty("TargetType")]
        public string TargetType{ get; set; }

        /// <summary>
        /// CMQ queue name.
        /// </summary>
        [JsonProperty("QueueName")]
        public string QueueName{ get; set; }

        /// <summary>
        /// CMQ topic name.
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoScalingGroupId", this.AutoScalingGroupId);
            this.SetParamArraySimple(map, prefix + "NotificationUserGroupIds.", this.NotificationUserGroupIds);
            this.SetParamArraySimple(map, prefix + "NotificationTypes.", this.NotificationTypes);
            this.SetParamSimple(map, prefix + "AutoScalingNotificationId", this.AutoScalingNotificationId);
            this.SetParamSimple(map, prefix + "TargetType", this.TargetType);
            this.SetParamSimple(map, prefix + "QueueName", this.QueueName);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
        }
    }
}

