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

    public class TimeAutoScaleStrategy : AbstractModel
    {
        
        /// <summary>
        /// Policy name, which is unique within one cluster.
        /// </summary>
        [JsonProperty("StrategyName")]
        public string StrategyName{ get; set; }

        /// <summary>
        /// Cooling time after policy trigger, during which auto scaling cannot be triggered.
        /// </summary>
        [JsonProperty("IntervalTime")]
        public ulong? IntervalTime{ get; set; }

        /// <summary>
        /// Scaling action. 1: scale-out, 2: scale-in.
        /// </summary>
        [JsonProperty("ScaleAction")]
        public ulong? ScaleAction{ get; set; }

        /// <summary>
        /// Scaling amount.
        /// </summary>
        [JsonProperty("ScaleNum")]
        public ulong? ScaleNum{ get; set; }

        /// <summary>
        /// Rule status. 1: valid; 2: invalid; 3: suspended. This field is required.
        /// </summary>
        [JsonProperty("StrategyStatus")]
        public ulong? StrategyStatus{ get; set; }

        /// <summary>
        /// Rule priority. The smaller value indicates the higher priority.
        /// </summary>
        [JsonProperty("Priority")]
        public ulong? Priority{ get; set; }

        /// <summary>
        /// When multiple rules are triggered at the same time and some are not really executed, retries will be performed within this time range.
        /// </summary>
        [JsonProperty("RetryValidTime")]
        public ulong? RetryValidTime{ get; set; }

        /// <summary>
        /// Time scaling repetition policy
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RepeatStrategy")]
        public RepeatStrategy RepeatStrategy{ get; set; }

        /// <summary>
        /// Unique policy ID.
        /// </summary>
        [JsonProperty("StrategyId")]
        public ulong? StrategyId{ get; set; }

        /// <summary>
        /// Graceful scale-in switch.
        /// </summary>
        [JsonProperty("GraceDownFlag")]
        public bool? GraceDownFlag{ get; set; }

        /// <summary>
        /// Graceful scale-in wait time.
        /// </summary>
        [JsonProperty("GraceDownTime")]
        public long? GraceDownTime{ get; set; }

        /// <summary>
        /// Bound tag list
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Preset configuration group.
        /// </summary>
        [JsonProperty("ConfigGroupAssigned")]
        public string ConfigGroupAssigned{ get; set; }

        /// <summary>
        /// Calculation method of scale-out resources. Valid values: "DEFAULT","INSTANCE", "CPU" and "MEMORYGB".
        /// "DEFAULT" indicates the default method, which is the same as "INSTANCE".
        /// "INSTANCE" indicates calculation based on nodes (default mode).
        /// "CPU" indicates calculation based on the quantity of cores of the machine.
        /// "MEMORYGB" indicates calculation based on the memory size of the machine.
        /// </summary>
        [JsonProperty("MeasureMethod")]
        public string MeasureMethod{ get; set; }

        /// <summary>
        /// Termination policy. "DEFAULT" denotes the default policy, which indicates that scale-in is triggered by scale-in rules. "TIMING" denotes timed destruction.
        /// </summary>
        [JsonProperty("TerminatePolicy")]
        public string TerminatePolicy{ get; set; }

        /// <summary>
        /// Maximum use time in seconds. The minimum value is 1 hour, and the maximum is 24 hours.
        /// </summary>
        [JsonProperty("MaxUse")]
        public long? MaxUse{ get; set; }

        /// <summary>
        /// Node deployment service list. Fill in only HDFS and YARN. For details, see [Mapping Table for Component Names](https://intl.cloud.tencent.com/document/product/589/98760?from_cn_redirect=1).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SoftDeployInfo")]
        public long?[] SoftDeployInfo{ get; set; }

        /// <summary>
        /// Startup process list
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ServiceNodeInfo")]
        public long?[] ServiceNodeInfo{ get; set; }

        /// <summary>
        /// Compensatory scale-out. 0: disable, 1: enable.
        /// </summary>
        [JsonProperty("CompensateFlag")]
        public long? CompensateFlag{ get; set; }

        /// <summary>
        /// Scaling group ID.
        /// </summary>
        [JsonProperty("GroupId")]
        public long? GroupId{ get; set; }

        /// <summary>
        /// Graceful scale-in business pod tag. Nodes are scaled in when the pod mentioned above is not found on the node or the graceful scale-in time is passed.
        /// </summary>
        [JsonProperty("GraceDownLabel")]
        public TkeLabel[] GraceDownLabel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StrategyName", this.StrategyName);
            this.SetParamSimple(map, prefix + "IntervalTime", this.IntervalTime);
            this.SetParamSimple(map, prefix + "ScaleAction", this.ScaleAction);
            this.SetParamSimple(map, prefix + "ScaleNum", this.ScaleNum);
            this.SetParamSimple(map, prefix + "StrategyStatus", this.StrategyStatus);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "RetryValidTime", this.RetryValidTime);
            this.SetParamObj(map, prefix + "RepeatStrategy.", this.RepeatStrategy);
            this.SetParamSimple(map, prefix + "StrategyId", this.StrategyId);
            this.SetParamSimple(map, prefix + "GraceDownFlag", this.GraceDownFlag);
            this.SetParamSimple(map, prefix + "GraceDownTime", this.GraceDownTime);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "ConfigGroupAssigned", this.ConfigGroupAssigned);
            this.SetParamSimple(map, prefix + "MeasureMethod", this.MeasureMethod);
            this.SetParamSimple(map, prefix + "TerminatePolicy", this.TerminatePolicy);
            this.SetParamSimple(map, prefix + "MaxUse", this.MaxUse);
            this.SetParamArraySimple(map, prefix + "SoftDeployInfo.", this.SoftDeployInfo);
            this.SetParamArraySimple(map, prefix + "ServiceNodeInfo.", this.ServiceNodeInfo);
            this.SetParamSimple(map, prefix + "CompensateFlag", this.CompensateFlag);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamArrayObj(map, prefix + "GraceDownLabel.", this.GraceDownLabel);
        }
    }
}

