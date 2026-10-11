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
        /// <p>Time unit for the scale-out. Valid values:</p><li>s: indicates seconds. When PayMode is set to 0, TimeUnit can only be set to s.</li><li>m: indicates months. When PayMode is set to 1, TimeUnit can only be set to m.</li>
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// <p>Scale-out duration, which is used together with TimeUnit.</p><li>When TimeUnit is set to s, this parameter can only be set to 3600, indicating a pay-as-you-go instance.</li><li>When TimeUnit is set to m, the value set for this parameter indicates the subscription duration of the instance. For example, 1 indicates a one-month subscription.</li>
        /// </summary>
        [JsonProperty("TimeSpan")]
        public ulong? TimeSpan{ get; set; }

        /// <summary>
        /// <p>Instance ID.</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Instance billing mode. Valid values:</p><li>0: pay-as-you-go</li><li>1: yearly/monthly subscription</li>
        /// </summary>
        [JsonProperty("PayMode")]
        public ulong? PayMode{ get; set; }

        /// <summary>
        /// <p>Unique random identifier, which is valid for five minutes and needs to be specified by the caller. This prevents the client from repeatedly creating resources. Example value: a9a90aa6-<strong><strong>-</strong></strong>-****-fae36063280.</p>
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// <p>Bootstrap script settings.</p>
        /// </summary>
        [JsonProperty("PreExecutedFileSettings")]
        public PreExecuteFileSettings[] PreExecutedFileSettings{ get; set; }

        /// <summary>
        /// <p>Number of Task nodes to be scaled out.</p>
        /// </summary>
        [JsonProperty("TaskCount")]
        public ulong? TaskCount{ get; set; }

        /// <summary>
        /// <p>Number of scale-out Core nodes.</p>
        /// </summary>
        [JsonProperty("CoreCount")]
        public ulong? CoreCount{ get; set; }

        /// <summary>
        /// <p>Processes, which are not required during the scale-out.</p>
        /// </summary>
        [JsonProperty("UnNecessaryNodeList")]
        public ulong?[] UnNecessaryNodeList{ get; set; }

        /// <summary>
        /// <p>Number of Router nodes to be scaled out.</p>
        /// </summary>
        [JsonProperty("RouterCount")]
        public ulong? RouterCount{ get; set; }

        /// <summary>
        /// <p>Deployed service.</p><li>SoftDeployInfo and ServiceNodeInfo are parameters in the same group and are mutually exclusive with UnNecessaryNodeList.</li><li>It is recommended to use SoftDeployInfo and ServiceNodeInfo together.</li>
        /// </summary>
        [JsonProperty("SoftDeployInfo")]
        public ulong?[] SoftDeployInfo{ get; set; }

        /// <summary>
        /// <p>Started process.</p>
        /// </summary>
        [JsonProperty("ServiceNodeInfo")]
        public ulong?[] ServiceNodeInfo{ get; set; }

        /// <summary>
        /// <p>List of dispersed placement group IDs. Currently, only one ID is supported.</p>
        /// </summary>
        [JsonProperty("DisasterRecoverGroupIds")]
        public string[] DisasterRecoverGroupIds{ get; set; }

        /// <summary>
        /// <p>List of tags bound to nodes for the scale-out.</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>Resource type selected for the scale-out. Valid values: &quot;HOST&quot;, &quot;POD&quot;, and &quot;MNode&quot;. HOST indicates ordinary CVM resources, POD indicates resources provided by a TKE cluster or an EKS cluster, and MNode indicates fully managed resources.</p>
        /// </summary>
        [JsonProperty("HardwareResourceType")]
        public string HardwareResourceType{ get; set; }

        /// <summary>
        /// <p>Pod specifications and source information, which are specified when Pod resources are used for the scale-out.</p>
        /// </summary>
        [JsonProperty("PodSpec")]
        public PodSpec PodSpec{ get; set; }

        /// <summary>
        /// <p>Machine group name selected for the ClickHouse cluster scale-out.</p>
        /// </summary>
        [JsonProperty("ClickHouseClusterName")]
        public string ClickHouseClusterName{ get; set; }

        /// <summary>
        /// <p>Machine group type selected for the ClickHouse cluster scale-out. Valid values: new (adds a group) and old (selects an existing group).</p>
        /// </summary>
        [JsonProperty("ClickHouseClusterType")]
        public string ClickHouseClusterType{ get; set; }

        /// <summary>
        /// <p>YARN node label specified for the rule-based scale-out.</p>
        /// </summary>
        [JsonProperty("YarnNodeLabel")]
        public string YarnNodeLabel{ get; set; }

        /// <summary>
        /// <p>Pod custom permission and parameter.</p>
        /// </summary>
        [JsonProperty("PodParameter")]
        public PodParameter PodParameter{ get; set; }

        /// <summary>
        /// <p>Number of Master nodes for the scale-out.<br>When a ClickHouse cluster is used for the scale-out, this parameter does not take effect.<br>When a Kafka cluster is used for the scale-out, this parameter does not take effect.<br>When HardwareResourceType is set to POD, this parameter does not take effect.</p>
        /// </summary>
        [JsonProperty("MasterCount")]
        public ulong? MasterCount{ get; set; }

        /// <summary>
        /// <p>Whether the service is started after the scale-out. Valid values: true (yes) and false (no).</p>
        /// </summary>
        [JsonProperty("StartServiceAfterScaleOut")]
        public string StartServiceAfterScaleOut{ get; set; }

        /// <summary>
        /// <p>AZ. The primary AZ of the cluster is selected by default.</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public long? ZoneId{ get; set; }

        /// <summary>
        /// <p>Subnet. The subnet used during cluster creation is selected by default.</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>Preset configuration group.</p>
        /// </summary>
        [JsonProperty("ScaleOutServiceConfAssign")]
        public string ScaleOutServiceConfAssign{ get; set; }

        /// <summary>
        /// <p>Auto-renewal. Valid values: 0 (disabled) and 1 (enabled).</p>
        /// </summary>
        [JsonProperty("AutoRenew")]
        public long? AutoRenew{ get; set; }

        /// <summary>
        /// <p>Type. Valid values: ComputeResource and EMR. Default value: EMR. If this parameter is set to EMR, InstanceId takes effect. If this parameter is set to ComputeResource, ComputeResourceId is used.</p>
        /// </summary>
        [JsonProperty("ResourceBaseType")]
        public string ResourceBaseType{ get; set; }

        /// <summary>
        /// <p>Computing resource ID.</p>
        /// </summary>
        [JsonProperty("ComputeResourceId")]
        public string ComputeResourceId{ get; set; }

        /// <summary>
        /// <p>Advanced settings of computing resources.</p>
        /// </summary>
        [JsonProperty("ComputeResourceAdvanceParams")]
        public ComputeResourceAdvanceParams ComputeResourceAdvanceParams{ get; set; }

        /// <summary>
        /// <p>Node tag information, which is currently only provided for the Terraform platform.</p>
        /// </summary>
        [JsonProperty("NodeMarks")]
        public NodeMark NodeMarks{ get; set; }

        /// <summary>
        /// <p>Compute group specified for the scale-out.</p>
        /// </summary>
        [JsonProperty("WarehouseName")]
        public string WarehouseName{ get; set; }

        /// <summary>
        /// <p>Partition of a partition placement group.</p>
        /// </summary>
        [JsonProperty("PartitionNumber")]
        public long? PartitionNumber{ get; set; }


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
            this.SetParamSimple(map, prefix + "ResourceBaseType", this.ResourceBaseType);
            this.SetParamSimple(map, prefix + "ComputeResourceId", this.ComputeResourceId);
            this.SetParamObj(map, prefix + "ComputeResourceAdvanceParams.", this.ComputeResourceAdvanceParams);
            this.SetParamObj(map, prefix + "NodeMarks.", this.NodeMarks);
            this.SetParamSimple(map, prefix + "WarehouseName", this.WarehouseName);
            this.SetParamSimple(map, prefix + "PartitionNumber", this.PartitionNumber);
        }
    }
}

