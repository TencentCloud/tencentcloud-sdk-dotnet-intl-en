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

    public class ModifyScalingPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// Alarm policy ID.
        /// </summary>
        [JsonProperty("AutoScalingPolicyId")]
        public string AutoScalingPolicyId{ get; set; }

        /// <summary>
        /// Alarm policy name.
        /// </summary>
        [JsonProperty("ScalingPolicyName")]
        public string ScalingPolicyName{ get; set; }

        /// <summary>
        /// The method to adjust the desired number of instances after the alarm is triggered. Value range: <br><li>CHANGE_IN_CAPACITY: Increase or decrease the desired number of instances </li><li>EXACT_CAPACITY: Adjust to the specified desired number of instances </li> <li>PERCENT_CHANGE_IN_CAPACITY: Adjust the desired number of instances by percentage </li>
        /// </summary>
        [JsonProperty("AdjustmentType")]
        public string AdjustmentType{ get; set; }

        /// <summary>
        /// The adjusted value of desired number of instances after the alarm is triggered. Value range: <br><li>When AdjustmentType is CHANGE_IN_CAPACITY, if AdjustmentValue is a positive value, some new instances will be added after the alarm is triggered, and if it is a negative value, some existing instances will be removed after the alarm is triggered </li> <li> When AdjustmentType is EXACT_CAPACITY, the value of AdjustmentValue is the desired number of instances after the alarm is triggered, which should be equal to or greater than 0 </li> <li> When AdjustmentType is PERCENT_CHANGE_IN_CAPACITY, if AdjusmentValue (in %) is a positive value, new instances will be added by percentage after the alarm is triggered; if it is a negative value, existing instances will be removed by percentage after the alarm is triggered.
        /// </summary>
        [JsonProperty("AdjustmentValue")]
        public long? AdjustmentValue{ get; set; }

        /// <summary>
        /// Cooldown period in seconds.
        /// </summary>
        [JsonProperty("Cooldown")]
        public ulong? Cooldown{ get; set; }

        /// <summary>
        /// Alarm monitoring metric.
        /// </summary>
        [JsonProperty("MetricAlarm")]
        public MetricAlarm MetricAlarm{ get; set; }

        /// <summary>
        /// Notification group ID, which is the set of user group IDs. You can query the user group IDs through the [ListGroups](https://intl.cloud.tencent.com/document/product/598/34589?from_cn_redirect=1) API.
        /// If you want to clear the user group, you need to pass in the specific string "NULL" to the list.
        /// </summary>
        [JsonProperty("NotificationUserGroupIds")]
        public string[] NotificationUserGroupIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoScalingPolicyId", this.AutoScalingPolicyId);
            this.SetParamSimple(map, prefix + "ScalingPolicyName", this.ScalingPolicyName);
            this.SetParamSimple(map, prefix + "AdjustmentType", this.AdjustmentType);
            this.SetParamSimple(map, prefix + "AdjustmentValue", this.AdjustmentValue);
            this.SetParamSimple(map, prefix + "Cooldown", this.Cooldown);
            this.SetParamObj(map, prefix + "MetricAlarm.", this.MetricAlarm);
            this.SetParamArraySimple(map, prefix + "NotificationUserGroupIds.", this.NotificationUserGroupIds);
        }
    }
}

