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
        /// <p>Configuration ID.</p>
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// <p>Cluster ID.</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public long? ClusterId{ get; set; }

        /// <summary>
        /// <p>Minimum number of reserved instances for auto scaling.</p>
        /// </summary>
        [JsonProperty("ScaleLowerBound")]
        public long? ScaleLowerBound{ get; set; }

        /// <summary>
        /// <p>Maximum number of instances for auto scaling.</p>
        /// </summary>
        [JsonProperty("ScaleUpperBound")]
        public long? ScaleUpperBound{ get; set; }

        /// <summary>
        /// <p>Scale-out rule type. Valid values: 1 (scale-out rule by load metrics) and 2 (scale-out rule by time).</p>
        /// </summary>
        [JsonProperty("StrategyType")]
        public long? StrategyType{ get; set; }

        /// <summary>
        /// <p>Next scale-out time.</p>
        /// </summary>
        [JsonProperty("NextTimeCanScale")]
        public ulong? NextTimeCanScale{ get; set; }

        /// <summary>
        /// <p>Graceful scale-in switch.</p>
        /// </summary>
        [JsonProperty("GraceDownFlag")]
        public bool? GraceDownFlag{ get; set; }

        /// <summary>
        /// <p>&quot;CVM&quot; indicates that all specifications use CVM-related types, and &quot;POD&quot; indicates that specifications use container-related types. The default value is &quot;CVM&quot;.</p>
        /// </summary>
        [JsonProperty("HardwareType")]
        public string HardwareType{ get; set; }

        /// <summary>
        /// <p>&quot;POSTPAY&quot; indicates that only pay-as-you-go billing is used. &quot;SPOT_FIRST&quot; indicates that spot instances are preferred, which is supported only when HardwareType is &quot;HOST&quot;. &quot;POD&quot; only supports pure pay-as-you-go billing.</p>
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// <p>Minimum percentage of pay-as-you-go resources in the scenario where spot instances are preferred. It is an integer.</p>
        /// </summary>
        [JsonProperty("PostPayPercentMin")]
        public long? PostPayPercentMin{ get; set; }

        /// <summary>
        /// <p>When the preset resource type is HOST, you can select &quot;switch to POD when resources are insufficient&quot; or clear the selection. 0 indicates that it is not selected by default (0), and 1 indicates that it is selected.</p>
        /// </summary>
        [JsonProperty("ChangeToPod")]
        public long? ChangeToPod{ get; set; }

        /// <summary>
        /// <p>Scaling group name.</p>
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// <p>Tag.</p>
        /// </summary>
        [JsonProperty("YarnNodeLabel")]
        public string YarnNodeLabel{ get; set; }

        /// <summary>
        /// <p>Corresponding computing group.</p>
        /// </summary>
        [JsonProperty("WarehouseName")]
        public string WarehouseName{ get; set; }

        /// <summary>
        /// <p>Scaling group status.</p>
        /// </summary>
        [JsonProperty("GroupStatus")]
        public long? GroupStatus{ get; set; }

        /// <summary>
        /// <p>Parallel scaling. Valid values: 0 (disabled) and 1 (enabled).</p>
        /// </summary>
        [JsonProperty("Parallel")]
        public long? Parallel{ get; set; }

        /// <summary>
        /// <p>Whether MNode is supported.</p>
        /// </summary>
        [JsonProperty("EnableMNode")]
        public long? EnableMNode{ get; set; }

        /// <summary>
        /// <p>More scaling group settings.</p>
        /// </summary>
        [JsonProperty("ExtraAdvanceAttrs")]
        public AutoScaleGroupAdvanceAttrs ExtraAdvanceAttrs{ get; set; }

        /// <summary>
        /// <p>Custom hostname.</p>
        /// </summary>
        [JsonProperty("CustomNodeName")]
        public string CustomNodeName{ get; set; }


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
            this.SetParamSimple(map, prefix + "WarehouseName", this.WarehouseName);
            this.SetParamSimple(map, prefix + "GroupStatus", this.GroupStatus);
            this.SetParamSimple(map, prefix + "Parallel", this.Parallel);
            this.SetParamSimple(map, prefix + "EnableMNode", this.EnableMNode);
            this.SetParamObj(map, prefix + "ExtraAdvanceAttrs.", this.ExtraAdvanceAttrs);
            this.SetParamSimple(map, prefix + "CustomNodeName", this.CustomNodeName);
        }
    }
}

