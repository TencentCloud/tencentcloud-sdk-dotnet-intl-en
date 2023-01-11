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
        /// The cluster instance ID.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// The type and number of nodes to be added.
        /// </summary>
        [JsonProperty("ScaleOutNodeConfig")]
        public ScaleOutNodeConfig ScaleOutNodeConfig{ get; set; }

        /// <summary>
        /// A unique random token, which is valid for 5 minutes and needs to be specified by the caller to prevent the client from repeatedly creating resources. An example value is `a9a90aa6-751a-41b6-aad6-fae36063280`.
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// The details of the monthly subscription, including the instance period and auto-renewal. It is required if the `InstanceChargeType` is `PREPAID`.
        /// </summary>
        [JsonProperty("InstanceChargePrepaid")]
        public InstanceChargePrepaid InstanceChargePrepaid{ get; set; }

        /// <summary>
        /// The [Bootstrap action](https://intl.cloud.tencent.com/document/product/589/35656?from_cn_redirect=1) script settings.
        /// </summary>
        [JsonProperty("ScriptBootstrapActionConfig")]
        public ScriptBootstrapActionConfig[] ScriptBootstrapActionConfig{ get; set; }

        /// <summary>
        /// The services to be deployed for new nodes. By default, new nodes will inherit all services deployed for the current node type. Deployed services include default optional services. This parameter only supports optional services. For example, if `HDFS`, `YARN`, and `Impala` have been deployed for existing task nodes, only `HDFS` and `YARN` are passed in with this parameter if `Impala` is not deployed during the task node scale-out with API.
        /// </summary>
        [JsonProperty("SoftDeployInfo")]
        public long?[] SoftDeployInfo{ get; set; }

        /// <summary>
        /// The processes to be deployed. All processes for services to be added are deployed by default. Deployed processes can be changed. For example, `HDFS`, `YARN`, and `Impala` have been deployed for current task nodes, and default services are `DataNode`, `NodeManager`, and `ImpalaServer`; if you want to change deployed processes, you can set this parameter to `DataNode,NodeManager,ImpalaServerCoordinator` or `DataNode,NodeManager,ImpalaServerExecutor`.
        /// </summary>
        [JsonProperty("ServiceNodeInfo")]
        public long?[] ServiceNodeInfo{ get; set; }

        /// <summary>
        /// The list of spread placement group IDs. Only one can be specified.
        /// You can call the [DescribeDisasterRecoverGroups](https://intl.cloud.tencent.com/document/product/213/17810?from_cn_redirect=1) API and obtain this parameter from the `DisasterRecoverGroupId` field in the response.
        /// </summary>
        [JsonProperty("DisasterRecoverGroupIds")]
        public string[] DisasterRecoverGroupIds{ get; set; }

        /// <summary>
        /// The list of tags bound to added nodes.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// The type of resources to add. Valid values: `host` (general CVM resources) and `pod` (resources provided by a TKE or EKS cluster).
        /// </summary>
        [JsonProperty("HardwareSourceType")]
        public string HardwareSourceType{ get; set; }

        /// <summary>
        /// The pod resource information.
        /// </summary>
        [JsonProperty("PodSpecInfo")]
        public PodSpecInfo PodSpecInfo{ get; set; }

        /// <summary>
        /// The server group name selected for ClickHouse cluster scale-out.
        /// </summary>
        [JsonProperty("ClickHouseClusterName")]
        public string ClickHouseClusterName{ get; set; }

        /// <summary>
        /// The server group type selected for ClickHouse cluster scale-out. Valid values: `new` (create a group) and `old` (select an existing group).
        /// </summary>
        [JsonProperty("ClickHouseClusterType")]
        public string ClickHouseClusterType{ get; set; }

        /// <summary>
        /// The YARN node label specified for scale-out.
        /// </summary>
        [JsonProperty("YarnNodeLabel")]
        public string YarnNodeLabel{ get; set; }

        /// <summary>
        /// Whether to start services after scale-out.
        /// <li>`true`: Yes</li>
        /// <li>`false` (default): No</li>
        /// </summary>
        [JsonProperty("EnableStartServiceFlag")]
        public bool? EnableStartServiceFlag{ get; set; }

        /// <summary>
        /// The spec settings.
        /// </summary>
        [JsonProperty("ResourceSpec")]
        public NodeResourceSpec ResourceSpec{ get; set; }

        /// <summary>
        /// The ID of the AZ where the instance resides, such as `ap-guangzhou-1`. You can call the [DescribeZones](https://intl.cloud.tencent.com/document/product/213/15707?from_cn_redirect=1) API and obtain this ID from the `Zone` field in the response.
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// The subnet, which defaults to the subnet used when the cluster is created.
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }


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
        }
    }
}

