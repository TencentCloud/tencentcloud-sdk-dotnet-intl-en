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

    public class CreateScalingPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// Auto scaling group ID.
        /// </summary>
        [JsonProperty("AutoScalingGroupId")]
        public string AutoScalingGroupId{ get; set; }

        /// <summary>
        /// Alarm trigger policy name.
        /// </summary>
        [JsonProperty("ScalingPolicyName")]
        public string ScalingPolicyName{ get; set; }

        /// <summary>
        /// Scaling policy type. Valid values: <br><li>`SIMPLE` (default): A simple policy</li><li>`TARGET_TRACKING`: A target tracking policy</li>.
        /// </summary>
        [JsonProperty("ScalingPolicyType")]
        public string ScalingPolicyType{ get; set; }

        /// <summary>
        /// The method to adjust the desired capacity after the alarm is triggered. It’s only available when `ScalingPolicyType` is `Simple`. Valid values: <br><li>`CHANGE_IN_CAPACITY`: Increase or decrease the desired capacity </li><li>`EXACT_CAPACITY`: Adjust to the specified desired capacity </li> <li>`PERCENT_CHANGE_IN_CAPACITY`: Adjust the desired capacity by percentage </li>
        /// </summary>
        [JsonProperty("AdjustmentType")]
        public string AdjustmentType{ get; set; }

        /// <summary>
        /// Specifies how to adjust the number of desired capacity when the alarm is triggered. It’s only available when `ScalingPolicyType` is `Simple`. Values: <br><li>`AdjustmentType`=`CHANGE_IN_CAPACITY`: Number of instances to add (positive number) or remove (negative number). </li> <li>`AdjustmentType`=`EXACT_CAPACITY`: Set the desired capacity to the specified number. It must be ≥ 0. </li> <li>`AdjustmentType`=`PERCENT_CHANGE_IN_CAPACITY`: Percentage of instance number. Add instances (positive value) or remove instances (negative value) accordingly.
        /// </summary>
        [JsonProperty("AdjustmentValue")]
        public long? AdjustmentValue{ get; set; }

        /// <summary>
        /// Cooldown period (in seconds). This parameter is only applicable to a simple policy. Default value: 300.
        /// </summary>
        [JsonProperty("Cooldown")]
        public ulong? Cooldown{ get; set; }

        /// <summary>
        /// Alarm monitoring metric. It’s only available when `ScalingPolicyType` is `Simple`.
        /// </summary>
        [JsonProperty("MetricAlarm")]
        public MetricAlarm MetricAlarm{ get; set; }

        /// <summary>
        /// Preset monitoring item. It’s only available when `ScalingPolicyType` is `TARGET_TRACKING`. Valid values: <br><li>ASG_AVG_CPU_UTILIZATION: Average CPU utilization</li><li>ASG_AVG_LAN_TRAFFIC_OUT: Average private bandwidth out</li><li>ASG_AVG_LAN_TRAFFIC_IN: Average private bandwidth in</li><li>ASG_AVG_WAN_TRAFFIC_OUT: Average public bandwidth out</li><li>ASG_AVG_WAN_TRAFFIC_IN: Average public bandwidth in</li>
        /// </summary>
        [JsonProperty("PredefinedMetricType")]
        public string PredefinedMetricType{ get; set; }

        /// <summary>
        /// Target value. It’s only available when `ScalingPolicyType` is `TARGET_TRACKING`. Value ranges: <br><li>`ASG_AVG_CPU_UTILIZATION` (in %): [1, 100)</li><li>`ASG_AVG_LAN_TRAFFIC_OUT` (in Mbps): >0</li><li>`ASG_AVG_LAN_TRAFFIC_IN` (in Mbps): >0</li><li>`ASG_AVG_WAN_TRAFFIC_OUT` (in Mbps): >0</li><li>`ASG_AVG_WAN_TRAFFIC_IN` (in Mbps): >0</li>
        /// </summary>
        [JsonProperty("TargetValue")]
        public ulong? TargetValue{ get; set; }

        /// <summary>
        /// Instance warm-up period (in seconds). It’s only available when `ScalingPolicyType` is `TARGET_TRACKING`. Value range: 0-3600. Default value: 300.
        /// </summary>
        [JsonProperty("EstimatedInstanceWarmup")]
        public ulong? EstimatedInstanceWarmup{ get; set; }

        /// <summary>
        /// Whether to disable scale-in. It’s only available when `ScalingPolicyType` is `TARGET_TRACKING`. Valid values: <br><li>`true`: Do not scale in </li><li>`false` (default): Both scale-out and scale-in can be triggered.</li>
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

