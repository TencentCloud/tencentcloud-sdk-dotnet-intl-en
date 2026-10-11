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

    public class ScaleOutClusterRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Node billing mode. Valid values:</p><li>PREPAID: prepaid, that is, yearly/monthly subscription</li><li>POSTPAID_BY_HOUR: pay-as-you-go on an hourly basis</li><li>SPOTPAID: spot billing (for Task nodes only)</li>
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// <p>Cluster ID.</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Type and number of nodes for the scale-out.</p>
        /// </summary>
        [JsonProperty("ScaleOutNodeConfig")]
        public ScaleOutNodeConfig ScaleOutNodeConfig{ get; set; }

        /// <summary>
        /// <p>Unique random identifier, which is valid for five minutes and needs to be specified by the caller. This prevents the client from repeatedly creating resources. Example value: a9a90aa6-<strong><strong>-</strong></strong>-****-fae36063280.</p>
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// <p>Parameter settings related to yearly/monthly subscription. This parameter can be used to specify the purchase duration of a yearly/monthly subscription instance, whether to enable auto-renewal, and other attributes. This parameter is required if the billing mode of the specified instance is prepaid.</p>
        /// </summary>
        [JsonProperty("InstanceChargePrepaid")]
        public InstanceChargePrepaid InstanceChargePrepaid{ get; set; }

        /// <summary>
        /// <p><a href="https://www.tencentcloud.com/document/product/589/35656?from_cn_redirect=1">Bootstrap operation</a> script settings.</p>
        /// </summary>
        [JsonProperty("ScriptBootstrapActionConfig")]
        public ScriptBootstrapActionConfig[] ScriptBootstrapActionConfig{ get; set; }

        /// <summary>
        /// <p>To scale out deployment services, new nodes will inherit the services deployed on the current node type by default. The deployment service includes default optional services. This parameter is supported only when optional services are used. For example, if existing task nodes have HDFS, YARN, and impala deployed, when using the API to scale out Task nodes without deploying impala, fill in only HDFS and YARN for the deployment service. For details, see <a href="https://www.tencentcloud.com/document/product/589/98760?from_cn_redirect=1">Component Name Mapping Table</a>.</p>
        /// </summary>
        [JsonProperty("SoftDeployInfo")]
        public long?[] SoftDeployInfo{ get; set; }

        /// <summary>
        /// <p>Deployment processes. By default, all processes of the scaled‑out service are deployed. Deployment processes can be modified. For example, if the deployed services for the current task node are HDFS, YARN, and impala, the default deployment services are DataNode, NodeManager, and ImpalaServer. If you need to modify deployment process information, the deployment processes can be DataNode, NodeManager, and ImpalaServerCoordinator or DataNode, NodeManager, and ImpalaServerExecutor. For details, see <a href="https://www.tencentcloud.com/document/product/589/98760?from_cn_redirect=1">Process Name Mapping Table</a>.</p>
        /// </summary>
        [JsonProperty("ServiceNodeInfo")]
        public long?[] ServiceNodeInfo{ get; set; }

        /// <summary>
        /// <p>List of dispersed placement group IDs. Currently, only one ID can be specified.<br>This parameter can be obtained by calling the DisasterRecoverGroupId field in the response result of <a href="https://www.tencentcloud.com/document/product/213/17810?from_cn_redirect=1">DescribeDisasterRecoverGroups</a>.</p>
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
        [JsonProperty("HardwareSourceType")]
        public string HardwareSourceType{ get; set; }

        /// <summary>
        /// <p>Pod-related resource information.</p>
        /// </summary>
        [JsonProperty("PodSpecInfo")]
        public PodSpecInfo PodSpecInfo{ get; set; }

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
        /// <p>YARN node label specified for the scale-out.</p>
        /// </summary>
        [JsonProperty("YarnNodeLabel")]
        public string YarnNodeLabel{ get; set; }

        /// <summary>
        /// <p>Whether to start the service after a scale-out. Default value: false. Valid values:</p><li>true: yes</li><li>false: no</li>
        /// </summary>
        [JsonProperty("EnableStartServiceFlag")]
        public bool? EnableStartServiceFlag{ get; set; }

        /// <summary>
        /// <p>Specification settings.</p>
        /// </summary>
        [JsonProperty("ResourceSpec")]
        public NodeResourceSpec ResourceSpec{ get; set; }

        /// <summary>
        /// <p>AZ to which the instance belongs, for example, ap-guangzhou-1. This parameter can be obtained from the Zone field in the response of <a href="https://www.tencentcloud.com/document/product/213/15707?from_cn_redirect=1">DescribeZones</a>.</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>Subnet. The subnet used during cluster creation is selected by default.</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>Configuration group specified for the scale-out.</p>
        /// </summary>
        [JsonProperty("ScaleOutServiceConfGroupsInfo")]
        public ScaleOutServiceConfGroupsInfo[] ScaleOutServiceConfGroupsInfo{ get; set; }

        /// <summary>
        /// <p>Node flag information, which is currently only provided for the Terraform platform.</p>
        /// </summary>
        [JsonProperty("NodeMarks")]
        public NodeMark NodeMarks{ get; set; }

        /// <summary>
        /// <p>Name of the compute group specified for the scale-out.</p>
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
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamObj(map, prefix + "ScaleOutNodeConfig.", this.ScaleOutNodeConfig);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
            this.SetParamObj(map, prefix + "InstanceChargePrepaid.", this.InstanceChargePrepaid);
            this.SetParamArrayObj(map, prefix + "ScriptBootstrapActionConfig.", this.ScriptBootstrapActionConfig);
            this.SetParamArraySimple(map, prefix + "SoftDeployInfo.", this.SoftDeployInfo);
            this.SetParamArraySimple(map, prefix + "ServiceNodeInfo.", this.ServiceNodeInfo);
            this.SetParamArraySimple(map, prefix + "DisasterRecoverGroupIds.", this.DisasterRecoverGroupIds);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "HardwareSourceType", this.HardwareSourceType);
            this.SetParamObj(map, prefix + "PodSpecInfo.", this.PodSpecInfo);
            this.SetParamSimple(map, prefix + "ClickHouseClusterName", this.ClickHouseClusterName);
            this.SetParamSimple(map, prefix + "ClickHouseClusterType", this.ClickHouseClusterType);
            this.SetParamSimple(map, prefix + "YarnNodeLabel", this.YarnNodeLabel);
            this.SetParamSimple(map, prefix + "EnableStartServiceFlag", this.EnableStartServiceFlag);
            this.SetParamObj(map, prefix + "ResourceSpec.", this.ResourceSpec);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamArrayObj(map, prefix + "ScaleOutServiceConfGroupsInfo.", this.ScaleOutServiceConfGroupsInfo);
            this.SetParamObj(map, prefix + "NodeMarks.", this.NodeMarks);
            this.SetParamSimple(map, prefix + "WarehouseName", this.WarehouseName);
            this.SetParamSimple(map, prefix + "PartitionNumber", this.PartitionNumber);
        }
    }
}

