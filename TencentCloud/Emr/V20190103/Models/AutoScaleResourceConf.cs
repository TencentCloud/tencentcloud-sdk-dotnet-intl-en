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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AutoScaleResourceConf : AbstractModel
    {
        
        /// <summary>
        /// Configuration ID.
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// Cluster instance ID.
        /// </summary>
        [JsonProperty("ClusterId")]
        public long? ClusterId{ get; set; }

        /// <summary>
        /// Minimum number of instances retained for automatic scaling
        /// </summary>
        [JsonProperty("ScaleLowerBound")]
        public long? ScaleLowerBound{ get; set; }

        /// <summary>
        /// Maximum number of instances for auto scaling
        /// </summary>
        [JsonProperty("ScaleUpperBound")]
        public long? ScaleUpperBound{ get; set; }

        /// <summary>
        /// Scale-out rule type. 1: load-based scale-out rule, 2: time-based scale-out rule
        /// </summary>
        [JsonProperty("StrategyType")]
        public long? StrategyType{ get; set; }

        /// <summary>
        /// Next scale-out time.
        /// </summary>
        [JsonProperty("NextTimeCanScale")]
        public ulong? NextTimeCanScale{ get; set; }

        /// <summary>
        /// Graceful scale-in switch.
        /// </summary>
        [JsonProperty("GraceDownFlag")]
        public bool? GraceDownFlag{ get; set; }

        /// <summary>
        /// "CVM" indicates that the CVM type is used for all specifications, and "Pod" indicates that the container type is used for specifications. The default value is "CVM".
        /// </summary>
        [JsonProperty("HardwareType")]
        public string HardwareType{ get; set; }

        /// <summary>
        /// "POSTPAY" indicates the sole adoption of pay-as-you-go, and "SPOT_FIRST" indicates spot instance first, which is only supported when HardwareType is "HOST". "Pod" only supports pay-as-you-go.
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// The minimum percentage of pay-as-you-go resources in scenarios with spot instance first. It is an integer.
        /// </summary>
        [JsonProperty("PostPayPercentMin")]
        public long? PostPayPercentMin{ get; set; }

        /// <summary>
        /// When resource type is preset to HOST: Supports enabling/disabling "Fallback to pod when resources are insufficient"; Default state: 0 (disabled), Toggle state: 1 (enabled).
        /// </summary>
        [JsonProperty("ChangeToPod")]
        public long? ChangeToPod{ get; set; }

        /// <summary>
        /// Scaling group name.
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// Tag.
        /// </summary>
        [JsonProperty("YarnNodeLabel")]
        public string YarnNodeLabel{ get; set; }

        /// <summary>
        /// Scaling group status.
        /// </summary>
        [JsonProperty("GroupStatus")]
        public long? GroupStatus{ get; set; }

        /// <summary>
        /// Parallel scaling. 0: disabled; 1: enabled.
        /// </summary>
        [JsonProperty("Parallel")]
        public long? Parallel{ get; set; }

        /// <summary>
        /// Whether MNode is supported.
        /// </summary>
        [JsonProperty("EnableMNode")]
        public long? EnableMNode{ get; set; }

        /// <summary>
        /// More scaling group settings.
        /// </summary>
        [JsonProperty("ExtraAdvanceAttrs")]
        public AutoScaleGroupAdvanceAttrs ExtraAdvanceAttrs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ScaleLowerBound", this.ScaleLowerBound);
            this.SetParamSimple(map, prefix + "ScaleUpperBound", this.ScaleUpperBound);
            this.SetParamSimple(map, prefix + "StrategyType", this.StrategyType);
            this.SetParamSimple(map, prefix + "NextTimeCanScale", this.NextTimeCanScale);
            this.SetParamSimple(map, prefix + "GraceDownFlag", this.GraceDownFlag);
            this.SetParamSimple(map, prefix + "HardwareType", this.HardwareType);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "PostPayPercentMin", this.PostPayPercentMin);
            this.SetParamSimple(map, prefix + "ChangeToPod", this.ChangeToPod);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "YarnNodeLabel", this.YarnNodeLabel);
            this.SetParamSimple(map, prefix + "GroupStatus", this.GroupStatus);
            this.SetParamSimple(map, prefix + "Parallel", this.Parallel);
            this.SetParamSimple(map, prefix + "EnableMNode", this.EnableMNode);
            this.SetParamObj(map, prefix + "ExtraAdvanceAttrs.", this.ExtraAdvanceAttrs);
        }
    }
}

