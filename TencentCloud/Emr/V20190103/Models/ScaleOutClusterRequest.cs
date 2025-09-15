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
        /// The node billing mode. Valid values:
        /// <li>`POSTPAID_BY_HOUR`: The postpaid mode by hour.</li>
        /// <li>`SPOTPAID`: The spot instance mode (for task nodes only).</li>
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// Cluster instance ID.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Scale-up node type and quantity.
        /// </summary>
        [JsonProperty("ScaleOutNodeConfig")]
        public ScaleOutNodeConfig ScaleOutNodeConfig{ get; set; }

        /// <summary>
        /// Unique random identifier with the time efficiency of 5 minutes, which needs to be specified by the caller to prevent the client from creating resources again, for example, a9a90aa6-****-****-****-fae36063280.
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// Setting of parameters related to monthly subscription. Through this parameter, you can specify the duration of purchase for monthly subscription instances, whether to set auto-renewal, and other attributes. This parameter is required when the specified instance is subject to the payment mode of prepaid.
        /// </summary>
        [JsonProperty("InstanceChargePrepaid")]
        public InstanceChargePrepaid InstanceChargePrepaid{ get; set; }

        /// <summary>
        /// [Bootstrap Actions](https://www.tencentcloud.comom/document/product/589/35656?from_cn_redirect=1) script settings.
        /// </summary>
        [JsonProperty("ScriptBootstrapActionConfig")]
        public ScriptBootstrapActionConfig[] ScriptBootstrapActionConfig{ get; set; }

        /// <summary>
        /// Scale-out deployment service. New nodes inherit services deployed in the current node type by default, including default optional services. This parameter only supports optional service filling, for example: HDFS, YARN, and Impala have been deployed to existing task nodes. When API is used to scale out the task nodes without deploying Impala, only HDFS and YARN are filled for deployment services. For more details, see [Mapping Table of Component Names](https://www.tencentcloud.comom/document/product/589/98760?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("SoftDeployInfo")]
        public long?[] SoftDeployInfo{ get; set; }

        /// <summary>
        /// Deployment process. By default, all scale-out service processes are deployed. Deployment processes can be modified. For example, HDFS, YARN, or Impala has been deployed for the current Task node. The default deployment services include DataNode,NodeManager,ImpalaServer. If users need to modify deployment process information, the deployment process can be DataNode, NodeManager, ImpalaServerCoordinator or DataNode, NodeManager, ImpalaServerExecutor. For more details, see [Mapping Table of Process Names](https://www.tencentcloud.comom/document/product/589/98760?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("ServiceNodeInfo")]
        public long?[] ServiceNodeInfo{ get; set; }

        /// <summary>
        /// Spread placement group ID list. Only one can be specified currently.
        /// This parameter can be obtained by calling the DisasterRecoverGroupId field in the return value of the [DescribeDisasterRecoverGroups](https://www.tencentcloud.comom/document/product/213/17810?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("DisasterRecoverGroupIds")]
        public string[] DisasterRecoverGroupIds{ get; set; }

        /// <summary>
        /// List of tags bound to scale-out nodes.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Resource type selected for scale-out with valid values "HOST","POD","MNode", where HOST indicates an ordinary CVM resource, POD indicates a resource provided by the TKE cluster or EKS cluster, and MNode indicates a fully managed resource type.
        /// </summary>
        [JsonProperty("HardwareSourceType")]
        public string HardwareSourceType{ get; set; }

        /// <summary>
        /// Pod-related resource information.
        /// </summary>
        [JsonProperty("PodSpecInfo")]
        public PodSpecInfo PodSpecInfo{ get; set; }

        /// <summary>
        /// Machine group name selected for ClickHouse cluster scale-out.
        /// </summary>
        [JsonProperty("ClickHouseClusterName")]
        public string ClickHouseClusterName{ get; set; }

        /// <summary>
        /// Machine group type selected for ClickHouse cluster scale-out. "New" indicates creating a group type, and "old" indicates using an existing group type.
        /// </summary>
        [JsonProperty("ClickHouseClusterType")]
        public string ClickHouseClusterType{ get; set; }

        /// <summary>
        /// Specified Yarn Node Label for scale-out.
        /// </summary>
        [JsonProperty("YarnNodeLabel")]
        public string YarnNodeLabel{ get; set; }

        /// <summary>
        /// Whether to start a service after scale-out (default: false).
        /// <li>true: yes</li>.
        /// <li>false: no</li>.
        /// </summary>
        [JsonProperty("EnableStartServiceFlag")]
        public bool? EnableStartServiceFlag{ get; set; }

        /// <summary>
        /// Specifications settings.
        /// </summary>
        [JsonProperty("ResourceSpec")]
        public NodeResourceSpec ResourceSpec{ get; set; }

        /// <summary>
        /// Availability zone of the instance, such as ap-guangzhou-1. This parameter can also be obtained from the Zone field in the return value of [DescribeZones](https://www.tencentcloud.comom/document/product/213/15707?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Subnet, which is the subnet at the time of cluster creation by default.
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// Configuration group specified for scale-out.
        /// </summary>
        [JsonProperty("ScaleOutServiceConfGroupsInfo")]
        public ScaleOutServiceConfGroupsInfo[] ScaleOutServiceConfGroupsInfo{ get; set; }

        /// <summary>
        /// Node tag information: currently used only in Terraform.
        /// </summary>
        [JsonProperty("NodeMarks")]
        public NodeMark NodeMarks{ get; set; }


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
        }
    }
}

