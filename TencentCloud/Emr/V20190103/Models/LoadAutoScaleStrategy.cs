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

    public class LoadAutoScaleStrategy : AbstractModel
    {
        
        /// <summary>
        /// Rule ID.
        /// </summary>
        [JsonProperty("StrategyId")]
        public long? StrategyId{ get; set; }

        /// <summary>
        /// Rule name.
        /// </summary>
        [JsonProperty("StrategyName")]
        public string StrategyName{ get; set; }

        /// <summary>
        /// Cooldown time for a rule to take effect.
        /// </summary>
        [JsonProperty("CalmDownTime")]
        public long? CalmDownTime{ get; set; }

        /// <summary>
        /// Scaling action. Valid values: 1 (scale-out) and 2 (scale-in).
        /// </summary>
        [JsonProperty("ScaleAction")]
        public long? ScaleAction{ get; set; }

        /// <summary>
        /// Number of scaling items each time the rule takes effect.
        /// </summary>
        [JsonProperty("ScaleNum")]
        public long? ScaleNum{ get; set; }

        /// <summary>
        /// Metric processing method. Valid values: 1 (MAX), 2 (MIN), and 3 (AVG).
        /// </summary>
        [JsonProperty("ProcessMethod")]
        public long? ProcessMethod{ get; set; }

        /// <summary>
        /// Rule priority, which is invalid during addition. By default, the auto-increment rule is used.
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// Rule status. Valid values: 1 (enabled) and 3 (disabled).
        /// </summary>
        [JsonProperty("StrategyStatus")]
        public long? StrategyStatus{ get; set; }

        /// <summary>
        /// YARN node label specified for the rule-based scale-out.
        /// </summary>
        [JsonProperty("YarnNodeLabel")]
        public string YarnNodeLabel{ get; set; }

        /// <summary>
        /// Effective time of the rule.
        /// </summary>
        [JsonProperty("PeriodValid")]
        public string PeriodValid{ get; set; }

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
        /// Whether to enable task protection.
        /// </summary>
        [JsonProperty("GraceDownProtectFlag")]
        public bool? GraceDownProtectFlag{ get; set; }

        /// <summary>
        /// Bound tag list.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Preset configuration group.
        /// </summary>
        [JsonProperty("ConfigGroupAssigned")]
        public string ConfigGroupAssigned{ get; set; }

        /// <summary>
        /// Calculation method for scaled‑out resources. Valid values: "DEFAULT", "INSTANCE", "CPU", and "MEMORYGB".
        /// "DEFAULT" indicates the default calculation method, which is identical to "INSTANCE".
        /// "INSTANCE" indicates the calculation method based on nodes. This is the default method.
        /// "CPU" indicates the calculation method based on the number of cores of the machine.
        /// "MEMORYGB" indicates the calculation method based on the memory size of the machine.
        /// </summary>
        [JsonProperty("MeasureMethod")]
        public string MeasureMethod{ get; set; }

        /// <summary>
        /// List of node deployment services, for example, ["HDFS-3.1.2","YARN-3.1.2"].
        /// </summary>
        [JsonProperty("SoftDeployDesc")]
        public string[] SoftDeployDesc{ get; set; }

        /// <summary>
        /// Startup process list, for example, ["NodeManager"].
        /// </summary>
        [JsonProperty("ServiceNodeDesc")]
        public string ServiceNodeDesc{ get; set; }

        /// <summary>
        /// Startup process list.
        /// </summary>
        [JsonProperty("ServiceNodeInfo")]
        public long?[] ServiceNodeInfo{ get; set; }

        /// <summary>
        /// List of services deployed on the node. Valid values: HDFS and YARN. For details, see [Mapping Table for Component Names](https://www.tencentcloud.com/document/product/589/98760?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("SoftDeployInfo")]
        public long?[] SoftDeployInfo{ get; set; }

        /// <summary>
        /// Multi-metric triggering condition.
        /// </summary>
        [JsonProperty("LoadMetricsConditions")]
        public LoadMetricsConditions LoadMetricsConditions{ get; set; }

        /// <summary>
        /// Scaling group ID.
        /// </summary>
        [JsonProperty("GroupId")]
        public long? GroupId{ get; set; }

        /// <summary>
        /// Soft. Example value: yarn.
        /// </summary>
        [JsonProperty("Soft")]
        public string Soft{ get; set; }

        /// <summary>
        /// Task protection time.
        /// </summary>
        [JsonProperty("GraceDownProtectTime")]
        public long? GraceDownProtectTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StrategyId", this.StrategyId);
            this.SetParamSimple(map, prefix + "StrategyName", this.StrategyName);
            this.SetParamSimple(map, prefix + "CalmDownTime", this.CalmDownTime);
            this.SetParamSimple(map, prefix + "ScaleAction", this.ScaleAction);
            this.SetParamSimple(map, prefix + "ScaleNum", this.ScaleNum);
            this.SetParamSimple(map, prefix + "ProcessMethod", this.ProcessMethod);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "StrategyStatus", this.StrategyStatus);
            this.SetParamSimple(map, prefix + "YarnNodeLabel", this.YarnNodeLabel);
            this.SetParamSimple(map, prefix + "PeriodValid", this.PeriodValid);
            this.SetParamSimple(map, prefix + "GraceDownFlag", this.GraceDownFlag);
            this.SetParamSimple(map, prefix + "GraceDownTime", this.GraceDownTime);
            this.SetParamSimple(map, prefix + "GraceDownProtectFlag", this.GraceDownProtectFlag);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "ConfigGroupAssigned", this.ConfigGroupAssigned);
            this.SetParamSimple(map, prefix + "MeasureMethod", this.MeasureMethod);
            this.SetParamArraySimple(map, prefix + "SoftDeployDesc.", this.SoftDeployDesc);
            this.SetParamSimple(map, prefix + "ServiceNodeDesc", this.ServiceNodeDesc);
            this.SetParamArraySimple(map, prefix + "ServiceNodeInfo.", this.ServiceNodeInfo);
            this.SetParamArraySimple(map, prefix + "SoftDeployInfo.", this.SoftDeployInfo);
            this.SetParamObj(map, prefix + "LoadMetricsConditions.", this.LoadMetricsConditions);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "Soft", this.Soft);
            this.SetParamSimple(map, prefix + "GraceDownProtectTime", this.GraceDownProtectTime);
        }
    }
}

