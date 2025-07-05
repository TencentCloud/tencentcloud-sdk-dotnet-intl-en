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

    public class ScaleOutInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// Time unit of scale-out. Valid values:
        /// <li>s: Second. When `PayMode` is 0, `TimeUnit` can only be `s`.</li>
        /// <li>m: Month. When `PayMode` is 1, `TimeUnit` can only be `m`.</li>
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// Time span of scale-out, which needs to be used together with `TimeUnit`.
        /// </summary>
        [JsonProperty("TimeSpan")]
        public ulong? TimeSpan{ get; set; }

        /// <summary>
        /// Instance ID.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Instance billing mode. Valid value:
        /// <li>0: Pay-as-you-go.</li>
        /// </summary>
        [JsonProperty("PayMode")]
        public ulong? PayMode{ get; set; }

        /// <summary>
        /// Client token.
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// Bootstrap script settings.
        /// </summary>
        [JsonProperty("PreExecutedFileSettings")]
        public PreExecuteFileSettings[] PreExecutedFileSettings{ get; set; }

        /// <summary>
        /// Number of task nodes to be added.
        /// </summary>
        [JsonProperty("TaskCount")]
        public ulong? TaskCount{ get; set; }

        /// <summary>
        /// Number of core nodes to be added.
        /// </summary>
        [JsonProperty("CoreCount")]
        public ulong? CoreCount{ get; set; }

        /// <summary>
        /// Processes unnecessary for scale-out.
        /// </summary>
        [JsonProperty("UnNecessaryNodeList")]
        public ulong?[] UnNecessaryNodeList{ get; set; }

        /// <summary>
        /// Number of router nodes to be added.
        /// </summary>
        [JsonProperty("RouterCount")]
        public ulong? RouterCount{ get; set; }

        /// <summary>
        /// Deployed service.
        /// <li>`SoftDeployInfo` and `ServiceNodeInfo` are in the same group and mutually exclusive with `UnNecessaryNodeList`.</li>
        /// <li>The combination of `SoftDeployInfo` and `ServiceNodeInfo` is recommended.</li>
        /// </summary>
        [JsonProperty("SoftDeployInfo")]
        public ulong?[] SoftDeployInfo{ get; set; }

        /// <summary>
        /// Started process.
        /// </summary>
        [JsonProperty("ServiceNodeInfo")]
        public ulong?[] ServiceNodeInfo{ get; set; }

        /// <summary>
        /// List of spread placement group IDs. Only one can be specified currently.
        /// </summary>
        [JsonProperty("DisasterRecoverGroupIds")]
        public string[] DisasterRecoverGroupIds{ get; set; }

        /// <summary>
        /// List of tags bound to added nodes.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Resource type selected for scaling. Valid values: `host` (general CVM resource) and `pod` (resource provided by TKE or EKS cluster).
        /// </summary>
        [JsonProperty("HardwareResourceType")]
        public string HardwareResourceType{ get; set; }

        /// <summary>
        /// Specified information such as pod specification and source for scale-out with pod resources.
        /// </summary>
        [JsonProperty("PodSpec")]
        public PodSpec PodSpec{ get; set; }

        /// <summary>
        /// Server group name selected for ClickHouse cluster scale-out.
        /// </summary>
        [JsonProperty("ClickHouseClusterName")]
        public string ClickHouseClusterName{ get; set; }

        /// <summary>
        /// Server group type selected for ClickHouse cluster scale-out. Valid values: `new` (create a group) and `old` (select an existing group).
        /// </summary>
        [JsonProperty("ClickHouseClusterType")]
        public string ClickHouseClusterType{ get; set; }

        /// <summary>
        /// Yarn node label specified for rule-based scale-out.
        /// </summary>
        [JsonProperty("YarnNodeLabel")]
        public string YarnNodeLabel{ get; set; }

        /// <summary>
        /// Custom pod permission and parameter
        /// </summary>
        [JsonProperty("PodParameter")]
        public PodParameter PodParameter{ get; set; }

        /// <summary>
        /// Number of master nodes to be added.
        /// When a ClickHouse cluster is scaled, this parameter does not take effect.
        /// When a Kafka cluster is scaled, this parameter does not take effect.
        /// When `HardwareResourceType` is `pod`, this parameter does not take effect.
        /// </summary>
        [JsonProperty("MasterCount")]
        public ulong? MasterCount{ get; set; }

        /// <summary>
        /// Whether to start the service after scale-out. `true`: Yes; `false`: No.
        /// </summary>
        [JsonProperty("StartServiceAfterScaleOut")]
        public string StartServiceAfterScaleOut{ get; set; }

        /// <summary>
        /// AZ, which defaults to the primary AZ of the cluster.
        /// </summary>
        [JsonProperty("ZoneId")]
        public long? ZoneId{ get; set; }

        /// <summary>
        /// Subnet, which defaults to the subnet used when the cluster is created.
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// Pre-defined configuration set
        /// </summary>
        [JsonProperty("ScaleOutServiceConfAssign")]
        public string ScaleOutServiceConfAssign{ get; set; }

        /// <summary>
        /// Whether to enable auto-renewal. Valid values: `0` (no), `1` (yes).
        /// </summary>
        [JsonProperty("AutoRenew")]
        public long? AutoRenew{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
            this.SetParamArrayObj(map, prefix + "PreExecutedFileSettings.", this.PreExecutedFileSettings);
            this.SetParamSimple(map, prefix + "TaskCount", this.TaskCount);
            this.SetParamSimple(map, prefix + "CoreCount", this.CoreCount);
            this.SetParamArraySimple(map, prefix + "UnNecessaryNodeList.", this.UnNecessaryNodeList);
            this.SetParamSimple(map, prefix + "RouterCount", this.RouterCount);
            this.SetParamArraySimple(map, prefix + "SoftDeployInfo.", this.SoftDeployInfo);
            this.SetParamArraySimple(map, prefix + "ServiceNodeInfo.", this.ServiceNodeInfo);
            this.SetParamArraySimple(map, prefix + "DisasterRecoverGroupIds.", this.DisasterRecoverGroupIds);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "HardwareResourceType", this.HardwareResourceType);
            this.SetParamObj(map, prefix + "PodSpec.", this.PodSpec);
            this.SetParamSimple(map, prefix + "ClickHouseClusterName", this.ClickHouseClusterName);
            this.SetParamSimple(map, prefix + "ClickHouseClusterType", this.ClickHouseClusterType);
            this.SetParamSimple(map, prefix + "YarnNodeLabel", this.YarnNodeLabel);
            this.SetParamObj(map, prefix + "PodParameter.", this.PodParameter);
            this.SetParamSimple(map, prefix + "MasterCount", this.MasterCount);
            this.SetParamSimple(map, prefix + "StartServiceAfterScaleOut", this.StartServiceAfterScaleOut);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "ScaleOutServiceConfAssign", this.ScaleOutServiceConfAssign);
            this.SetParamSimple(map, prefix + "AutoRenew", this.AutoRenew);
        }
    }
}

