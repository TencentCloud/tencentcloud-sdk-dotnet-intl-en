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

    public class CreateScalingPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// Scaling group ID. obtain the scaling group ID by logging in to the console (https://console.cloud.tencent.com/autoscaling/group) or calling the api DescribeAutoScalingGroups (https://intl.cloud.tencent.com/document/api/377/20438?from_cn_redirect=1), and retrieve AutoScalingGroupId from the returned information.
        /// </summary>
        [JsonProperty("AutoScalingGroupId")]
        public string AutoScalingGroupId{ get; set; }

        /// <summary>
        /// The Alarm policy name must be unique in your account. the name length cannot exceed 60 characters. the name only supports chinese, english, digits, underscores, hyphens, and decimal points.
        /// </summary>
        [JsonProperty("ScalingPolicyName")]
        public string ScalingPolicyName{ get; set; }

        /// <summary>
        /// Alarm trigger policy type. default: SIMPLE. valid values:.
        /// <Li>`SIMPLE`: a simple policy.</li>.
        /// <Li>`TARGET_TRACKING`: a target tracking policy.</li>.
        /// </summary>
        [JsonProperty("ScalingPolicyType")]
        public string ScalingPolicyType{ get; set; }

        /// <summary>
        /// After an Alarm is triggered, specifies the method for modifying the expected number of instances. required in the scenario of simple policies. valid values:.
        /// <Li>CHANGE_IN_CAPACITY: increase or decrease the expected number of instances</li>.
        /// <Li>EXACT_CAPACITY: adjust to the expected number of instances</li>.
        /// <Li>PERCENT_CHANGE_IN_CAPACITY: adjust expected instance number by percent</li>.
        /// </summary>
        [JsonProperty("AdjustmentType")]
        public string AdjustmentType{ get; set; }

        /// <summary>
        /// Adjustment value for the expected number of instances after an Alarm is triggered, which is applicable only to simple policies and required in simple policy scenarios.
        /// <li>When AdjustmentType is CHANGE_IN_CAPACITY, a positive AdjustmentValue indicates an increase IN instances after Alarm trigger, while a negative value indicates a decrease IN instances after Alarm trigger.</li>. 
        /// <li>When AdjustmentType is set to EXACT_CAPACITY, the value of AdjustmentValue indicates the new desired number of instances after the Alarm is triggered. it must be at least 0.</li>. 
        /// <li>When AdjustmentType is set to PERCENT_CHANGE_IN_CAPACITY, a positive value of AdjustmentValue indicates an increase in the number of instances by a percentage after the alarm is triggered, while a negative value indicates a decrease in the number of instances by a percentage after the alarm is triggered. Unit: %.</li>
        /// </summary>
        [JsonProperty("AdjustmentValue")]
        public long? AdjustmentValue{ get; set; }

        /// <summary>
        /// Cooldown period (in seconds). This parameter is only applicable to a simple policy. Default value: 300.
        /// </summary>
        [JsonProperty("Cooldown")]
        public ulong? Cooldown{ get; set; }

        /// <summary>
        /// Alarm monitoring metric, apply only to simple policies, required in the scenario of simple policy.
        /// </summary>
        [JsonProperty("MetricAlarm")]
        public MetricAlarm MetricAlarm{ get; set; }

        /// <summary>
        /// Predefined monitoring item, applicable only to target tracking policies. required in the scenario. value range:.
        /// <Li>ASG_AVG_CPU_UTILIZATION: average cpu utilization</li>.
        /// <Li>ASG_AVG_LAN_TRAFFIC_OUT: specifies the average outbound private network bandwidth.</li>.
        /// <Li>ASG_AVG_LAN_TRAFFIC_IN: average inbound private network bandwidth</li>.
        /// <Li>ASG_AVG_WAN_TRAFFIC_OUT: specifies the average outbound public network bandwidth.</li>.
        /// <li>ASG_AVG_WAN_TRAFFIC_IN: average inbound public network bandwidth</li>
        /// </summary>
        [JsonProperty("PredefinedMetricType")]
        public string PredefinedMetricType{ get; set; }

        /// <summary>
        /// Target value, applicable only to the target tracking policy, required in the scenario.
        /// <Li>ASG_AVG_CPU_UTILIZATION: value range: [1, 100); unit: %.</li>.
        /// <li>ASG_AVG_LAN_TRAFFIC_OUT: value range: > 0; unit: Mbps.</li>.
        /// <li>ASG_AVG_LAN_TRAFFIC_IN: value range: > 0; unit: Mbps.</li>.
        /// <li>ASG_AVG_WAN_TRAFFIC_OUT: value range: > 0; unit: Mbps.</li>.
        /// <li>ASG_AVG_WAN_TRAFFIC_IN: value range: > 0; unit: Mbps.</li>
        /// </summary>
        [JsonProperty("TargetValue")]
        public ulong? TargetValue{ get; set; }

        /// <summary>
        /// Instance warm-up period (in seconds). It is only available when `ScalingPolicyType` is `TARGET_TRACKING`. Value range: 0-3600. Default value: 300.
        /// </summary>
        [JsonProperty("EstimatedInstanceWarmup")]
        public ulong? EstimatedInstanceWarmup{ get; set; }

        /// <summary>
        /// Whether to disable scale-in, which is applicable only to target tracking policies. Default value: false. Valid values:
        /// <li>true: Target tracking policies trigger only scale-out.</li>
        /// <li>false: Target tracking policies trigger both scale-out and scale-in.</li>
        /// </summary>
        [JsonProperty("DisableScaleIn")]
        public bool? DisableScaleIn{ get; set; }

        /// <summary>
        /// This parameter is diused. Please use [CreateNotificationConfiguration](https://intl.cloud.tencent.com/document/api/377/33185?from_cn_redirect=1) instead.
        /// Notification group ID, which is the set of user group IDs.
        /// </summary>
        [JsonProperty("NotificationUserGroupIds")]
        public string[] NotificationUserGroupIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoScalingGroupId", this.AutoScalingGroupId);
            this.SetParamSimple(map, prefix + "ScalingPolicyName", this.ScalingPolicyName);
            this.SetParamSimple(map, prefix + "ScalingPolicyType", this.ScalingPolicyType);
            this.SetParamSimple(map, prefix + "AdjustmentType", this.AdjustmentType);
            this.SetParamSimple(map, prefix + "AdjustmentValue", this.AdjustmentValue);
            this.SetParamSimple(map, prefix + "Cooldown", this.Cooldown);
            this.SetParamObj(map, prefix + "MetricAlarm.", this.MetricAlarm);
            this.SetParamSimple(map, prefix + "PredefinedMetricType", this.PredefinedMetricType);
            this.SetParamSimple(map, prefix + "TargetValue", this.TargetValue);
            this.SetParamSimple(map, prefix + "EstimatedInstanceWarmup", this.EstimatedInstanceWarmup);
            this.SetParamSimple(map, prefix + "DisableScaleIn", this.DisableScaleIn);
            this.SetParamArraySimple(map, prefix + "NotificationUserGroupIds.", this.NotificationUserGroupIds);
        }
    }
}

