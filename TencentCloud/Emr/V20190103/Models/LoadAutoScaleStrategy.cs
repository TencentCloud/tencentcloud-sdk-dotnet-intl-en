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
        /// Cooling time for a rule to take effect.
        /// </summary>
        [JsonProperty("CalmDownTime")]
        public long? CalmDownTime{ get; set; }

        /// <summary>
        /// Scaling action. 1: scale-out, 2: scale-in.
        /// </summary>
        [JsonProperty("ScaleAction")]
        public long? ScaleAction{ get; set; }

        /// <summary>
        /// Scaling amount each time the rule takes effect.
        /// </summary>
        [JsonProperty("ScaleNum")]
        public long? ScaleNum{ get; set; }

        /// <summary>
        /// Metric processing method. 1: MAX, 2: MIN, 3: AVG.
        /// </summary>
        [JsonProperty("ProcessMethod")]
        public long? ProcessMethod{ get; set; }

        /// <summary>
        /// Rule priority, which is not applicable during adding. The default is auto-increment.
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// Rule status. 1: enabled, 3: disabled.
        /// </summary>
        [JsonProperty("StrategyStatus")]
        public long? StrategyStatus{ get; set; }

        /// <summary>
        /// Specified Yarn Node Label for rule scale-out.
        /// </summary>
        [JsonProperty("YarnNodeLabel")]
        public string YarnNodeLabel{ get; set; }

        /// <summary>
        /// Effective time of the rule
        /// </summary>
        [JsonProperty("PeriodValid")]
        public string PeriodValid{ get; set; }

        /// <summary>
        /// Graceful scale-in switch
        /// </summary>
        [JsonProperty("GraceDownFlag")]
        public bool? GraceDownFlag{ get; set; }

        /// <summary>
        /// Graceful scale-in wait time
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
        /// Calculation method of scale-out resources:"DEFAULT","INSTANCE", "CPU", "MEMORYGB".
        /// "DEFAULT" indicates the default method, which is the same as "INSTANCE".
        /// "INSTANCE" indicates calculation based on nodes (default mode).
        /// "CPU" indicates calculation based on the quantity of cores of the machine.
        /// "MEMORYGB" indicates calculation based on the memory size of the machine.
        /// </summary>
        [JsonProperty("MeasureMethod")]
        public string MeasureMethod{ get; set; }

        /// <summary>
        /// Node deployment service list, such as ["HDFS-3.1.2","YARN-3.1.2"].
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SoftDeployDesc")]
        public string[] SoftDeployDesc{ get; set; }

        /// <summary>
        /// Startup process list, such as ["NodeManager"].
        /// </summary>
        [JsonProperty("ServiceNodeDesc")]
        public string ServiceNodeDesc{ get; set; }

        /// <summary>
        /// Startup process list.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ServiceNodeInfo")]
        public long?[] ServiceNodeInfo{ get; set; }

        /// <summary>
        /// Node deployment service list. Only HDFS and YARN should be specified in the deployment service list. For details, see [Mapping Table for Component Names](https://www.tencentcloud.com/document/product/589/98760?from_cn_redirect=1).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SoftDeployInfo")]
        public long?[] SoftDeployInfo{ get; set; }

        /// <summary>
        /// Multi-metric trigger condition.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LoadMetricsConditions")]
        public LoadMetricsConditions LoadMetricsConditions{ get; set; }

        /// <summary>
        /// Scaling group ID.
        /// </summary>
        [JsonProperty("GroupId")]
        public long? GroupId{ get; set; }

        /// <summary>
        /// Soft (for example, YARN).
        /// </summary>
        [JsonProperty("Soft")]
        public string Soft{ get; set; }


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
        }
    }
}

