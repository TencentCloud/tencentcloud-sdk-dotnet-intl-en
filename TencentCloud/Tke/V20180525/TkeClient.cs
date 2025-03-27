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

namespace TencentCloud.Tke.V20180525
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tke.V20180525.Models;

   public class TkeClient : AbstractClient{

       private const string endpoint = "tke.intl.tencentcloudapi.com";
       private const string version = "2018-05-25";
       private const string sdkVersion = "SDK_NET_3.0.1099";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TkeClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TkeClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API can be called to acquire the ClusterRole tke:admin. By setting a CAM policy, you can grant permission of this API to a sub-account that has higher permission in CAM. In this way, this sub-account can call this API directly to acquire the admin role of a Kubernetes cluster.
        /// </summary>
        /// <param name="req"><see cref="AcquireClusterAdminRoleRequest"/></param>
        /// <returns><see cref="AcquireClusterAdminRoleResponse"/></returns>
        public Task<AcquireClusterAdminRoleResponse> AcquireClusterAdminRole(AcquireClusterAdminRoleRequest req)
        {
            return InternalRequestAsync<AcquireClusterAdminRoleResponse>(req, "AcquireClusterAdminRole");
        }

        /// <summary>
        /// This API can be called to acquire the ClusterRole tke:admin. By setting a CAM policy, you can grant permission of this API to a sub-account that has higher permission in CAM. In this way, this sub-account can call this API directly to acquire the admin role of a Kubernetes cluster.
        /// </summary>
        /// <param name="req"><see cref="AcquireClusterAdminRoleRequest"/></param>
        /// <returns><see cref="AcquireClusterAdminRoleResponse"/></returns>
        public AcquireClusterAdminRoleResponse AcquireClusterAdminRoleSync(AcquireClusterAdminRoleRequest req)
        {
            return InternalRequestAsync<AcquireClusterAdminRoleResponse>(req, "AcquireClusterAdminRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add one or more existing instances to a cluster.
        /// </summary>
        /// <param name="req"><see cref="AddExistedInstancesRequest"/></param>
        /// <returns><see cref="AddExistedInstancesResponse"/></returns>
        public Task<AddExistedInstancesResponse> AddExistedInstances(AddExistedInstancesRequest req)
        {
            return InternalRequestAsync<AddExistedInstancesResponse>(req, "AddExistedInstances");
        }

        /// <summary>
        /// This API is used to add one or more existing instances to a cluster.
        /// </summary>
        /// <param name="req"><see cref="AddExistedInstancesRequest"/></param>
        /// <returns><see cref="AddExistedInstancesResponse"/></returns>
        public AddExistedInstancesResponse AddExistedInstancesSync(AddExistedInstancesRequest req)
        {
            return InternalRequestAsync<AddExistedInstancesResponse>(req, "AddExistedInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to move nodes in a cluster to a node pool.
        /// </summary>
        /// <param name="req"><see cref="AddNodeToNodePoolRequest"/></param>
        /// <returns><see cref="AddNodeToNodePoolResponse"/></returns>
        public Task<AddNodeToNodePoolResponse> AddNodeToNodePool(AddNodeToNodePoolRequest req)
        {
            return InternalRequestAsync<AddNodeToNodePoolResponse>(req, "AddNodeToNodePool");
        }

        /// <summary>
        /// This API is used to move nodes in a cluster to a node pool.
        /// </summary>
        /// <param name="req"><see cref="AddNodeToNodePoolRequest"/></param>
        /// <returns><see cref="AddNodeToNodePoolResponse"/></returns>
        public AddNodeToNodePoolResponse AddNodeToNodePoolSync(AddNodeToNodePoolRequest req)
        {
            return InternalRequestAsync<AddNodeToNodePoolResponse>(req, "AddNodeToNodePool")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add subnets in the container network for a VPC-CNI cluster.
        /// </summary>
        /// <param name="req"><see cref="AddVpcCniSubnetsRequest"/></param>
        /// <returns><see cref="AddVpcCniSubnetsResponse"/></returns>
        public Task<AddVpcCniSubnetsResponse> AddVpcCniSubnets(AddVpcCniSubnetsRequest req)
        {
            return InternalRequestAsync<AddVpcCniSubnetsResponse>(req, "AddVpcCniSubnets");
        }

        /// <summary>
        /// This API is used to add subnets in the container network for a VPC-CNI cluster.
        /// </summary>
        /// <param name="req"><see cref="AddVpcCniSubnetsRequest"/></param>
        /// <returns><see cref="AddVpcCniSubnetsResponse"/></returns>
        public AddVpcCniSubnetsResponse AddVpcCniSubnetsSync(AddVpcCniSubnetsRequest req)
        {
            return InternalRequestAsync<AddVpcCniSubnetsResponse>(req, "AddVpcCniSubnets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to check if the CIDR block of a TKE Edge cluster conflicts with other CIDR blocks.
        /// </summary>
        /// <param name="req"><see cref="CheckEdgeClusterCIDRRequest"/></param>
        /// <returns><see cref="CheckEdgeClusterCIDRResponse"/></returns>
        public Task<CheckEdgeClusterCIDRResponse> CheckEdgeClusterCIDR(CheckEdgeClusterCIDRRequest req)
        {
            return InternalRequestAsync<CheckEdgeClusterCIDRResponse>(req, "CheckEdgeClusterCIDR");
        }

        /// <summary>
        /// This API is used to check if the CIDR block of a TKE Edge cluster conflicts with other CIDR blocks.
        /// </summary>
        /// <param name="req"><see cref="CheckEdgeClusterCIDRRequest"/></param>
        /// <returns><see cref="CheckEdgeClusterCIDRResponse"/></returns>
        public CheckEdgeClusterCIDRResponse CheckEdgeClusterCIDRSync(CheckEdgeClusterCIDRRequest req)
        {
            return InternalRequestAsync<CheckEdgeClusterCIDRResponse>(req, "CheckEdgeClusterCIDR")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query nodes eligible for an upgrade in the given node list.
        /// </summary>
        /// <param name="req"><see cref="CheckInstancesUpgradeAbleRequest"/></param>
        /// <returns><see cref="CheckInstancesUpgradeAbleResponse"/></returns>
        public Task<CheckInstancesUpgradeAbleResponse> CheckInstancesUpgradeAble(CheckInstancesUpgradeAbleRequest req)
        {
            return InternalRequestAsync<CheckInstancesUpgradeAbleResponse>(req, "CheckInstancesUpgradeAble");
        }

        /// <summary>
        /// This API is used to query nodes eligible for an upgrade in the given node list.
        /// </summary>
        /// <param name="req"><see cref="CheckInstancesUpgradeAbleRequest"/></param>
        /// <returns><see cref="CheckInstancesUpgradeAbleResponse"/></returns>
        public CheckInstancesUpgradeAbleResponse CheckInstancesUpgradeAbleSync(CheckInstancesUpgradeAbleRequest req)
        {
            return InternalRequestAsync<CheckInstancesUpgradeAbleResponse>(req, "CheckInstancesUpgradeAble")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a backup repository. You can specify the storage type (such as COS), the bucket region and the name. Up to 100 repositories can be created. Note that the settings of this API apply globally. You only need to create one backup repository, and back up TKE clusters in different regions in it.
        /// </summary>
        /// <param name="req"><see cref="CreateBackupStorageLocationRequest"/></param>
        /// <returns><see cref="CreateBackupStorageLocationResponse"/></returns>
        public Task<CreateBackupStorageLocationResponse> CreateBackupStorageLocation(CreateBackupStorageLocationRequest req)
        {
            return InternalRequestAsync<CreateBackupStorageLocationResponse>(req, "CreateBackupStorageLocation");
        }

        /// <summary>
        /// This API is used to create a backup repository. You can specify the storage type (such as COS), the bucket region and the name. Up to 100 repositories can be created. Note that the settings of this API apply globally. You only need to create one backup repository, and back up TKE clusters in different regions in it.
        /// </summary>
        /// <param name="req"><see cref="CreateBackupStorageLocationRequest"/></param>
        /// <returns><see cref="CreateBackupStorageLocationResponse"/></returns>
        public CreateBackupStorageLocationResponse CreateBackupStorageLocationSync(CreateBackupStorageLocationRequest req)
        {
            return InternalRequestAsync<CreateBackupStorageLocationResponse>(req, "CreateBackupStorageLocation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create log collection configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateCLSLogConfigRequest"/></param>
        /// <returns><see cref="CreateCLSLogConfigResponse"/></returns>
        public Task<CreateCLSLogConfigResponse> CreateCLSLogConfig(CreateCLSLogConfigRequest req)
        {
            return InternalRequestAsync<CreateCLSLogConfigResponse>(req, "CreateCLSLogConfig");
        }

        /// <summary>
        /// This API is used to create log collection configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateCLSLogConfigRequest"/></param>
        /// <returns><see cref="CreateCLSLogConfigResponse"/></returns>
        public CreateCLSLogConfigResponse CreateCLSLogConfigSync(CreateCLSLogConfigRequest req)
        {
            return InternalRequestAsync<CreateCLSLogConfigResponse>(req, "CreateCLSLogConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a cluster.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRequest"/></param>
        /// <returns><see cref="CreateClusterResponse"/></returns>
        public Task<CreateClusterResponse> CreateCluster(CreateClusterRequest req)
        {
            return InternalRequestAsync<CreateClusterResponse>(req, "CreateCluster");
        }

        /// <summary>
        /// This API is used to create a cluster.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRequest"/></param>
        /// <returns><see cref="CreateClusterResponse"/></returns>
        public CreateClusterResponse CreateClusterSync(CreateClusterRequest req)
        {
            return InternalRequestAsync<CreateClusterResponse>(req, "CreateCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a cluster access endpoint.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterEndpointRequest"/></param>
        /// <returns><see cref="CreateClusterEndpointResponse"/></returns>
        public Task<CreateClusterEndpointResponse> CreateClusterEndpoint(CreateClusterEndpointRequest req)
        {
            return InternalRequestAsync<CreateClusterEndpointResponse>(req, "CreateClusterEndpoint");
        }

        /// <summary>
        /// This API is used to create a cluster access endpoint.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterEndpointRequest"/></param>
        /// <returns><see cref="CreateClusterEndpointResponse"/></returns>
        public CreateClusterEndpointResponse CreateClusterEndpointSync(CreateClusterEndpointRequest req)
        {
            return InternalRequestAsync<CreateClusterEndpointResponse>(req, "CreateClusterEndpoint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a public network access port for a managed cluster. Note: This API will be disused soon. Please call `CreateClusterEndpoint` instead.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterEndpointVipRequest"/></param>
        /// <returns><see cref="CreateClusterEndpointVipResponse"/></returns>
        public Task<CreateClusterEndpointVipResponse> CreateClusterEndpointVip(CreateClusterEndpointVipRequest req)
        {
            return InternalRequestAsync<CreateClusterEndpointVipResponse>(req, "CreateClusterEndpointVip");
        }

        /// <summary>
        /// This API is used to create a public network access port for a managed cluster. Note: This API will be disused soon. Please call `CreateClusterEndpoint` instead.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterEndpointVipRequest"/></param>
        /// <returns><see cref="CreateClusterEndpointVipResponse"/></returns>
        public CreateClusterEndpointVipResponse CreateClusterEndpointVipSync(CreateClusterEndpointVipRequest req)
        {
            return InternalRequestAsync<CreateClusterEndpointVipResponse>(req, "CreateClusterEndpointVip")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create one or more nodes in a cluster.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterInstancesRequest"/></param>
        /// <returns><see cref="CreateClusterInstancesResponse"/></returns>
        public Task<CreateClusterInstancesResponse> CreateClusterInstances(CreateClusterInstancesRequest req)
        {
            return InternalRequestAsync<CreateClusterInstancesResponse>(req, "CreateClusterInstances");
        }

        /// <summary>
        /// This API is used to create one or more nodes in a cluster.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterInstancesRequest"/></param>
        /// <returns><see cref="CreateClusterInstancesResponse"/></returns>
        public CreateClusterInstancesResponse CreateClusterInstancesSync(CreateClusterInstancesRequest req)
        {
            return InternalRequestAsync<CreateClusterInstancesResponse>(req, "CreateClusterInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a node pool.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterNodePoolRequest"/></param>
        /// <returns><see cref="CreateClusterNodePoolResponse"/></returns>
        public Task<CreateClusterNodePoolResponse> CreateClusterNodePool(CreateClusterNodePoolRequest req)
        {
            return InternalRequestAsync<CreateClusterNodePoolResponse>(req, "CreateClusterNodePool");
        }

        /// <summary>
        /// This API is used to create a node pool.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterNodePoolRequest"/></param>
        /// <returns><see cref="CreateClusterNodePoolResponse"/></returns>
        public CreateClusterNodePoolResponse CreateClusterNodePoolSync(CreateClusterNodePoolRequest req)
        {
            return InternalRequestAsync<CreateClusterNodePoolResponse>(req, "CreateClusterNodePool")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a cluster route table.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRouteTableRequest"/></param>
        /// <returns><see cref="CreateClusterRouteTableResponse"/></returns>
        public Task<CreateClusterRouteTableResponse> CreateClusterRouteTable(CreateClusterRouteTableRequest req)
        {
            return InternalRequestAsync<CreateClusterRouteTableResponse>(req, "CreateClusterRouteTable");
        }

        /// <summary>
        /// This API is used to create a cluster route table.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRouteTableRequest"/></param>
        /// <returns><see cref="CreateClusterRouteTableResponse"/></returns>
        public CreateClusterRouteTableResponse CreateClusterRouteTableSync(CreateClusterRouteTableRequest req)
        {
            return InternalRequestAsync<CreateClusterRouteTableResponse>(req, "CreateClusterRouteTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create the Pay-as-you-go Super Node.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterVirtualNodeRequest"/></param>
        /// <returns><see cref="CreateClusterVirtualNodeResponse"/></returns>
        public Task<CreateClusterVirtualNodeResponse> CreateClusterVirtualNode(CreateClusterVirtualNodeRequest req)
        {
            return InternalRequestAsync<CreateClusterVirtualNodeResponse>(req, "CreateClusterVirtualNode");
        }

        /// <summary>
        /// This API is used to create the Pay-as-you-go Super Node.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterVirtualNodeRequest"/></param>
        /// <returns><see cref="CreateClusterVirtualNodeResponse"/></returns>
        public CreateClusterVirtualNodeResponse CreateClusterVirtualNodeSync(CreateClusterVirtualNodeRequest req)
        {
            return InternalRequestAsync<CreateClusterVirtualNodeResponse>(req, "CreateClusterVirtualNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create the Super Node Pool.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterVirtualNodePoolRequest"/></param>
        /// <returns><see cref="CreateClusterVirtualNodePoolResponse"/></returns>
        public Task<CreateClusterVirtualNodePoolResponse> CreateClusterVirtualNodePool(CreateClusterVirtualNodePoolRequest req)
        {
            return InternalRequestAsync<CreateClusterVirtualNodePoolResponse>(req, "CreateClusterVirtualNodePool");
        }

        /// <summary>
        /// This API is used to create the Super Node Pool.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterVirtualNodePoolRequest"/></param>
        /// <returns><see cref="CreateClusterVirtualNodePoolResponse"/></returns>
        public CreateClusterVirtualNodePoolResponse CreateClusterVirtualNodePoolSync(CreateClusterVirtualNodePoolRequest req)
        {
            return InternalRequestAsync<CreateClusterVirtualNodePoolResponse>(req, "CreateClusterVirtualNodePool")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an ECM instance.
        /// </summary>
        /// <param name="req"><see cref="CreateECMInstancesRequest"/></param>
        /// <returns><see cref="CreateECMInstancesResponse"/></returns>
        public Task<CreateECMInstancesResponse> CreateECMInstances(CreateECMInstancesRequest req)
        {
            return InternalRequestAsync<CreateECMInstancesResponse>(req, "CreateECMInstances");
        }

        /// <summary>
        /// This API is used to create an ECM instance.
        /// </summary>
        /// <param name="req"><see cref="CreateECMInstancesRequest"/></param>
        /// <returns><see cref="CreateECMInstancesResponse"/></returns>
        public CreateECMInstancesResponse CreateECMInstancesSync(CreateECMInstancesRequest req)
        {
            return InternalRequestAsync<CreateECMInstancesResponse>(req, "CreateECMInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create CVM instances in the specified TKE edge cluster.
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeCVMInstancesRequest"/></param>
        /// <returns><see cref="CreateEdgeCVMInstancesResponse"/></returns>
        public Task<CreateEdgeCVMInstancesResponse> CreateEdgeCVMInstances(CreateEdgeCVMInstancesRequest req)
        {
            return InternalRequestAsync<CreateEdgeCVMInstancesResponse>(req, "CreateEdgeCVMInstances");
        }

        /// <summary>
        /// This API is used to create CVM instances in the specified TKE edge cluster.
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeCVMInstancesRequest"/></param>
        /// <returns><see cref="CreateEdgeCVMInstancesResponse"/></returns>
        public CreateEdgeCVMInstancesResponse CreateEdgeCVMInstancesSync(CreateEdgeCVMInstancesRequest req)
        {
            return InternalRequestAsync<CreateEdgeCVMInstancesResponse>(req, "CreateEdgeCVMInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create log collection configuration for a TKE Edge cluster.
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeLogConfigRequest"/></param>
        /// <returns><see cref="CreateEdgeLogConfigResponse"/></returns>
        public Task<CreateEdgeLogConfigResponse> CreateEdgeLogConfig(CreateEdgeLogConfigRequest req)
        {
            return InternalRequestAsync<CreateEdgeLogConfigResponse>(req, "CreateEdgeLogConfig");
        }

        /// <summary>
        /// This API is used to create log collection configuration for a TKE Edge cluster.
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeLogConfigRequest"/></param>
        /// <returns><see cref="CreateEdgeLogConfigResponse"/></returns>
        public CreateEdgeLogConfigResponse CreateEdgeLogConfigSync(CreateEdgeLogConfigRequest req)
        {
            return InternalRequestAsync<CreateEdgeLogConfigResponse>(req, "CreateEdgeLogConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create Log Collection Configuration for Elastic Cluster.
        /// </summary>
        /// <param name="req"><see cref="CreateEksLogConfigRequest"/></param>
        /// <returns><see cref="CreateEksLogConfigResponse"/></returns>
        public Task<CreateEksLogConfigResponse> CreateEksLogConfig(CreateEksLogConfigRequest req)
        {
            return InternalRequestAsync<CreateEksLogConfigResponse>(req, "CreateEksLogConfig");
        }

        /// <summary>
        /// This API is used to create Log Collection Configuration for Elastic Cluster.
        /// </summary>
        /// <param name="req"><see cref="CreateEksLogConfigRequest"/></param>
        /// <returns><see cref="CreateEksLogConfigResponse"/></returns>
        public CreateEksLogConfigResponse CreateEksLogConfigSync(CreateEksLogConfigRequest req)
        {
            return InternalRequestAsync<CreateEksLogConfigResponse>(req, "CreateEksLogConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an alarm rule.
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusAlertRuleRequest"/></param>
        /// <returns><see cref="CreatePrometheusAlertRuleResponse"/></returns>
        public Task<CreatePrometheusAlertRuleResponse> CreatePrometheusAlertRule(CreatePrometheusAlertRuleRequest req)
        {
            return InternalRequestAsync<CreatePrometheusAlertRuleResponse>(req, "CreatePrometheusAlertRule");
        }

        /// <summary>
        /// This API is used to create an alarm rule.
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusAlertRuleRequest"/></param>
        /// <returns><see cref="CreatePrometheusAlertRuleResponse"/></returns>
        public CreatePrometheusAlertRuleResponse CreatePrometheusAlertRuleSync(CreatePrometheusAlertRuleRequest req)
        {
            return InternalRequestAsync<CreatePrometheusAlertRuleResponse>(req, "CreatePrometheusAlertRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a TKE Edge cluster.
        /// </summary>
        /// <param name="req"><see cref="CreateTKEEdgeClusterRequest"/></param>
        /// <returns><see cref="CreateTKEEdgeClusterResponse"/></returns>
        public Task<CreateTKEEdgeClusterResponse> CreateTKEEdgeCluster(CreateTKEEdgeClusterRequest req)
        {
            return InternalRequestAsync<CreateTKEEdgeClusterResponse>(req, "CreateTKEEdgeCluster");
        }

        /// <summary>
        /// This API is used to create a TKE Edge cluster.
        /// </summary>
        /// <param name="req"><see cref="CreateTKEEdgeClusterRequest"/></param>
        /// <returns><see cref="CreateTKEEdgeClusterResponse"/></returns>
        public CreateTKEEdgeClusterResponse CreateTKEEdgeClusterSync(CreateTKEEdgeClusterRequest req)
        {
            return InternalRequestAsync<CreateTKEEdgeClusterResponse>(req, "CreateTKEEdgeCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an add-on.
        /// </summary>
        /// <param name="req"><see cref="DeleteAddonRequest"/></param>
        /// <returns><see cref="DeleteAddonResponse"/></returns>
        public Task<DeleteAddonResponse> DeleteAddon(DeleteAddonRequest req)
        {
            return InternalRequestAsync<DeleteAddonResponse>(req, "DeleteAddon");
        }

        /// <summary>
        /// This API is used to delete an add-on.
        /// </summary>
        /// <param name="req"><see cref="DeleteAddonRequest"/></param>
        /// <returns><see cref="DeleteAddonResponse"/></returns>
        public DeleteAddonResponse DeleteAddonSync(DeleteAddonRequest req)
        {
            return InternalRequestAsync<DeleteAddonResponse>(req, "DeleteAddon")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a backup repository.
        /// </summary>
        /// <param name="req"><see cref="DeleteBackupStorageLocationRequest"/></param>
        /// <returns><see cref="DeleteBackupStorageLocationResponse"/></returns>
        public Task<DeleteBackupStorageLocationResponse> DeleteBackupStorageLocation(DeleteBackupStorageLocationRequest req)
        {
            return InternalRequestAsync<DeleteBackupStorageLocationResponse>(req, "DeleteBackupStorageLocation");
        }

        /// <summary>
        /// This API is used to delete a backup repository.
        /// </summary>
        /// <param name="req"><see cref="DeleteBackupStorageLocationRequest"/></param>
        /// <returns><see cref="DeleteBackupStorageLocationResponse"/></returns>
        public DeleteBackupStorageLocationResponse DeleteBackupStorageLocationSync(DeleteBackupStorageLocationRequest req)
        {
            return InternalRequestAsync<DeleteBackupStorageLocationResponse>(req, "DeleteBackupStorageLocation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a cluster. (Cloud API v3).
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRequest"/></param>
        /// <returns><see cref="DeleteClusterResponse"/></returns>
        public Task<DeleteClusterResponse> DeleteCluster(DeleteClusterRequest req)
        {
            return InternalRequestAsync<DeleteClusterResponse>(req, "DeleteCluster");
        }

        /// <summary>
        /// This API is used to delete a cluster. (Cloud API v3).
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRequest"/></param>
        /// <returns><see cref="DeleteClusterResponse"/></returns>
        public DeleteClusterResponse DeleteClusterSync(DeleteClusterRequest req)
        {
            return InternalRequestAsync<DeleteClusterResponse>(req, "DeleteCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a cluster scaling group
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterAsGroupsRequest"/></param>
        /// <returns><see cref="DeleteClusterAsGroupsResponse"/></returns>
        public Task<DeleteClusterAsGroupsResponse> DeleteClusterAsGroups(DeleteClusterAsGroupsRequest req)
        {
            return InternalRequestAsync<DeleteClusterAsGroupsResponse>(req, "DeleteClusterAsGroups");
        }

        /// <summary>
        /// Delete a cluster scaling group
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterAsGroupsRequest"/></param>
        /// <returns><see cref="DeleteClusterAsGroupsResponse"/></returns>
        public DeleteClusterAsGroupsResponse DeleteClusterAsGroupsSync(DeleteClusterAsGroupsRequest req)
        {
            return InternalRequestAsync<DeleteClusterAsGroupsResponse>(req, "DeleteClusterAsGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a cluster access endpoint.
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterEndpointRequest"/></param>
        /// <returns><see cref="DeleteClusterEndpointResponse"/></returns>
        public Task<DeleteClusterEndpointResponse> DeleteClusterEndpoint(DeleteClusterEndpointRequest req)
        {
            return InternalRequestAsync<DeleteClusterEndpointResponse>(req, "DeleteClusterEndpoint");
        }

        /// <summary>
        /// This API is used to delete a cluster access endpoint.
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterEndpointRequest"/></param>
        /// <returns><see cref="DeleteClusterEndpointResponse"/></returns>
        public DeleteClusterEndpointResponse DeleteClusterEndpointSync(DeleteClusterEndpointRequest req)
        {
            return InternalRequestAsync<DeleteClusterEndpointResponse>(req, "DeleteClusterEndpoint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete the external network access port of the managed cluster (the old way, only the external network port of the managed cluster is supported)
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterEndpointVipRequest"/></param>
        /// <returns><see cref="DeleteClusterEndpointVipResponse"/></returns>
        public Task<DeleteClusterEndpointVipResponse> DeleteClusterEndpointVip(DeleteClusterEndpointVipRequest req)
        {
            return InternalRequestAsync<DeleteClusterEndpointVipResponse>(req, "DeleteClusterEndpointVip");
        }

        /// <summary>
        /// Delete the external network access port of the managed cluster (the old way, only the external network port of the managed cluster is supported)
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterEndpointVipRequest"/></param>
        /// <returns><see cref="DeleteClusterEndpointVipResponse"/></returns>
        public DeleteClusterEndpointVipResponse DeleteClusterEndpointVipSync(DeleteClusterEndpointVipRequest req)
        {
            return InternalRequestAsync<DeleteClusterEndpointVipResponse>(req, "DeleteClusterEndpointVip")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete one or more nodes from a cluster.
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterInstancesRequest"/></param>
        /// <returns><see cref="DeleteClusterInstancesResponse"/></returns>
        public Task<DeleteClusterInstancesResponse> DeleteClusterInstances(DeleteClusterInstancesRequest req)
        {
            return InternalRequestAsync<DeleteClusterInstancesResponse>(req, "DeleteClusterInstances");
        }

        /// <summary>
        /// This API is used to delete one or more nodes from a cluster.
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterInstancesRequest"/></param>
        /// <returns><see cref="DeleteClusterInstancesResponse"/></returns>
        public DeleteClusterInstancesResponse DeleteClusterInstancesSync(DeleteClusterInstancesRequest req)
        {
            return InternalRequestAsync<DeleteClusterInstancesResponse>(req, "DeleteClusterInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a node pool.
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterNodePoolRequest"/></param>
        /// <returns><see cref="DeleteClusterNodePoolResponse"/></returns>
        public Task<DeleteClusterNodePoolResponse> DeleteClusterNodePool(DeleteClusterNodePoolRequest req)
        {
            return InternalRequestAsync<DeleteClusterNodePoolResponse>(req, "DeleteClusterNodePool");
        }

        /// <summary>
        /// This API is used to delete a node pool.
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterNodePoolRequest"/></param>
        /// <returns><see cref="DeleteClusterNodePoolResponse"/></returns>
        public DeleteClusterNodePoolResponse DeleteClusterNodePoolSync(DeleteClusterNodePoolRequest req)
        {
            return InternalRequestAsync<DeleteClusterNodePoolResponse>(req, "DeleteClusterNodePool")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a cluster route.
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRouteRequest"/></param>
        /// <returns><see cref="DeleteClusterRouteResponse"/></returns>
        public Task<DeleteClusterRouteResponse> DeleteClusterRoute(DeleteClusterRouteRequest req)
        {
            return InternalRequestAsync<DeleteClusterRouteResponse>(req, "DeleteClusterRoute");
        }

        /// <summary>
        /// This API is used to delete a cluster route.
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRouteRequest"/></param>
        /// <returns><see cref="DeleteClusterRouteResponse"/></returns>
        public DeleteClusterRouteResponse DeleteClusterRouteSync(DeleteClusterRouteRequest req)
        {
            return InternalRequestAsync<DeleteClusterRouteResponse>(req, "DeleteClusterRoute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete cluster a route table.
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRouteTableRequest"/></param>
        /// <returns><see cref="DeleteClusterRouteTableResponse"/></returns>
        public Task<DeleteClusterRouteTableResponse> DeleteClusterRouteTable(DeleteClusterRouteTableRequest req)
        {
            return InternalRequestAsync<DeleteClusterRouteTableResponse>(req, "DeleteClusterRouteTable");
        }

        /// <summary>
        /// This API is used to delete cluster a route table.
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRouteTableRequest"/></param>
        /// <returns><see cref="DeleteClusterRouteTableResponse"/></returns>
        public DeleteClusterRouteTableResponse DeleteClusterRouteTableSync(DeleteClusterRouteTableRequest req)
        {
            return InternalRequestAsync<DeleteClusterRouteTableResponse>(req, "DeleteClusterRouteTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the super node.
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterVirtualNodeRequest"/></param>
        /// <returns><see cref="DeleteClusterVirtualNodeResponse"/></returns>
        public Task<DeleteClusterVirtualNodeResponse> DeleteClusterVirtualNode(DeleteClusterVirtualNodeRequest req)
        {
            return InternalRequestAsync<DeleteClusterVirtualNodeResponse>(req, "DeleteClusterVirtualNode");
        }

        /// <summary>
        /// This API is used to delete the super node.
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterVirtualNodeRequest"/></param>
        /// <returns><see cref="DeleteClusterVirtualNodeResponse"/></returns>
        public DeleteClusterVirtualNodeResponse DeleteClusterVirtualNodeSync(DeleteClusterVirtualNodeRequest req)
        {
            return InternalRequestAsync<DeleteClusterVirtualNodeResponse>(req, "DeleteClusterVirtualNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the Super Node Pool.
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterVirtualNodePoolRequest"/></param>
        /// <returns><see cref="DeleteClusterVirtualNodePoolResponse"/></returns>
        public Task<DeleteClusterVirtualNodePoolResponse> DeleteClusterVirtualNodePool(DeleteClusterVirtualNodePoolRequest req)
        {
            return InternalRequestAsync<DeleteClusterVirtualNodePoolResponse>(req, "DeleteClusterVirtualNodePool");
        }

        /// <summary>
        /// This API is used to delete the Super Node Pool.
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterVirtualNodePoolRequest"/></param>
        /// <returns><see cref="DeleteClusterVirtualNodePoolResponse"/></returns>
        public DeleteClusterVirtualNodePoolResponse DeleteClusterVirtualNodePoolSync(DeleteClusterVirtualNodePoolRequest req)
        {
            return InternalRequestAsync<DeleteClusterVirtualNodePoolResponse>(req, "DeleteClusterVirtualNodePool")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete one or more ECM instances.
        /// </summary>
        /// <param name="req"><see cref="DeleteECMInstancesRequest"/></param>
        /// <returns><see cref="DeleteECMInstancesResponse"/></returns>
        public Task<DeleteECMInstancesResponse> DeleteECMInstances(DeleteECMInstancesRequest req)
        {
            return InternalRequestAsync<DeleteECMInstancesResponse>(req, "DeleteECMInstances");
        }

        /// <summary>
        /// This API is used to delete one or more ECM instances.
        /// </summary>
        /// <param name="req"><see cref="DeleteECMInstancesRequest"/></param>
        /// <returns><see cref="DeleteECMInstancesResponse"/></returns>
        public DeleteECMInstancesResponse DeleteECMInstancesSync(DeleteECMInstancesRequest req)
        {
            return InternalRequestAsync<DeleteECMInstancesResponse>(req, "DeleteECMInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete one or more edge CVM instances.
        /// </summary>
        /// <param name="req"><see cref="DeleteEdgeCVMInstancesRequest"/></param>
        /// <returns><see cref="DeleteEdgeCVMInstancesResponse"/></returns>
        public Task<DeleteEdgeCVMInstancesResponse> DeleteEdgeCVMInstances(DeleteEdgeCVMInstancesRequest req)
        {
            return InternalRequestAsync<DeleteEdgeCVMInstancesResponse>(req, "DeleteEdgeCVMInstances");
        }

        /// <summary>
        /// This API is used to delete one or more edge CVM instances.
        /// </summary>
        /// <param name="req"><see cref="DeleteEdgeCVMInstancesRequest"/></param>
        /// <returns><see cref="DeleteEdgeCVMInstancesResponse"/></returns>
        public DeleteEdgeCVMInstancesResponse DeleteEdgeCVMInstancesSync(DeleteEdgeCVMInstancesRequest req)
        {
            return InternalRequestAsync<DeleteEdgeCVMInstancesResponse>(req, "DeleteEdgeCVMInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete one or more edge compute instances.
        /// </summary>
        /// <param name="req"><see cref="DeleteEdgeClusterInstancesRequest"/></param>
        /// <returns><see cref="DeleteEdgeClusterInstancesResponse"/></returns>
        public Task<DeleteEdgeClusterInstancesResponse> DeleteEdgeClusterInstances(DeleteEdgeClusterInstancesRequest req)
        {
            return InternalRequestAsync<DeleteEdgeClusterInstancesResponse>(req, "DeleteEdgeClusterInstances");
        }

        /// <summary>
        /// This API is used to delete one or more edge compute instances.
        /// </summary>
        /// <param name="req"><see cref="DeleteEdgeClusterInstancesRequest"/></param>
        /// <returns><see cref="DeleteEdgeClusterInstancesResponse"/></returns>
        public DeleteEdgeClusterInstancesResponse DeleteEdgeClusterInstancesSync(DeleteEdgeClusterInstancesRequest req)
        {
            return InternalRequestAsync<DeleteEdgeClusterInstancesResponse>(req, "DeleteEdgeClusterInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete collection rules within the cluster.
        /// </summary>
        /// <param name="req"><see cref="DeleteLogConfigsRequest"/></param>
        /// <returns><see cref="DeleteLogConfigsResponse"/></returns>
        public Task<DeleteLogConfigsResponse> DeleteLogConfigs(DeleteLogConfigsRequest req)
        {
            return InternalRequestAsync<DeleteLogConfigsResponse>(req, "DeleteLogConfigs");
        }

        /// <summary>
        /// This API is used to delete collection rules within the cluster.
        /// </summary>
        /// <param name="req"><see cref="DeleteLogConfigsRequest"/></param>
        /// <returns><see cref="DeleteLogConfigsResponse"/></returns>
        public DeleteLogConfigsResponse DeleteLogConfigsSync(DeleteLogConfigsRequest req)
        {
            return InternalRequestAsync<DeleteLogConfigsResponse>(req, "DeleteLogConfigs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an alarm rule.
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusAlertRuleRequest"/></param>
        /// <returns><see cref="DeletePrometheusAlertRuleResponse"/></returns>
        public Task<DeletePrometheusAlertRuleResponse> DeletePrometheusAlertRule(DeletePrometheusAlertRuleRequest req)
        {
            return InternalRequestAsync<DeletePrometheusAlertRuleResponse>(req, "DeletePrometheusAlertRule");
        }

        /// <summary>
        /// This API is used to delete an alarm rule.
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusAlertRuleRequest"/></param>
        /// <returns><see cref="DeletePrometheusAlertRuleResponse"/></returns>
        public DeletePrometheusAlertRuleResponse DeletePrometheusAlertRuleSync(DeletePrometheusAlertRuleRequest req)
        {
            return InternalRequestAsync<DeletePrometheusAlertRuleResponse>(req, "DeletePrometheusAlertRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a TKE Edge cluster.
        /// </summary>
        /// <param name="req"><see cref="DeleteTKEEdgeClusterRequest"/></param>
        /// <returns><see cref="DeleteTKEEdgeClusterResponse"/></returns>
        public Task<DeleteTKEEdgeClusterResponse> DeleteTKEEdgeCluster(DeleteTKEEdgeClusterRequest req)
        {
            return InternalRequestAsync<DeleteTKEEdgeClusterResponse>(req, "DeleteTKEEdgeCluster");
        }

        /// <summary>
        /// This API is used to delete a TKE Edge cluster.
        /// </summary>
        /// <param name="req"><see cref="DeleteTKEEdgeClusterRequest"/></param>
        /// <returns><see cref="DeleteTKEEdgeClusterResponse"/></returns>
        public DeleteTKEEdgeClusterResponse DeleteTKEEdgeClusterSync(DeleteTKEEdgeClusterRequest req)
        {
            return InternalRequestAsync<DeleteTKEEdgeClusterResponse>(req, "DeleteTKEEdgeCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of add-ons.
        /// </summary>
        /// <param name="req"><see cref="DescribeAddonRequest"/></param>
        /// <returns><see cref="DescribeAddonResponse"/></returns>
        public Task<DescribeAddonResponse> DescribeAddon(DescribeAddonRequest req)
        {
            return InternalRequestAsync<DescribeAddonResponse>(req, "DescribeAddon");
        }

        /// <summary>
        /// This API is used to query the list of add-ons.
        /// </summary>
        /// <param name="req"><see cref="DescribeAddonRequest"/></param>
        /// <returns><see cref="DescribeAddonResponse"/></returns>
        public DescribeAddonResponse DescribeAddonSync(DescribeAddonRequest req)
        {
            return InternalRequestAsync<DescribeAddonResponse>(req, "DescribeAddon")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query parameters of an add-on.
        /// </summary>
        /// <param name="req"><see cref="DescribeAddonValuesRequest"/></param>
        /// <returns><see cref="DescribeAddonValuesResponse"/></returns>
        public Task<DescribeAddonValuesResponse> DescribeAddonValues(DescribeAddonValuesRequest req)
        {
            return InternalRequestAsync<DescribeAddonValuesResponse>(req, "DescribeAddonValues");
        }

        /// <summary>
        /// This API is used to query parameters of an add-on.
        /// </summary>
        /// <param name="req"><see cref="DescribeAddonValuesRequest"/></param>
        /// <returns><see cref="DescribeAddonValuesResponse"/></returns>
        public DescribeAddonValuesResponse DescribeAddonValuesSync(DescribeAddonValuesRequest req)
        {
            return InternalRequestAsync<DescribeAddonValuesResponse>(req, "DescribeAddonValues")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain all versions that the cluster can upgrade to.
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableClusterVersionRequest"/></param>
        /// <returns><see cref="DescribeAvailableClusterVersionResponse"/></returns>
        public Task<DescribeAvailableClusterVersionResponse> DescribeAvailableClusterVersion(DescribeAvailableClusterVersionRequest req)
        {
            return InternalRequestAsync<DescribeAvailableClusterVersionResponse>(req, "DescribeAvailableClusterVersion");
        }

        /// <summary>
        /// This API is used to obtain all versions that the cluster can upgrade to.
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableClusterVersionRequest"/></param>
        /// <returns><see cref="DescribeAvailableClusterVersionResponse"/></returns>
        public DescribeAvailableClusterVersionResponse DescribeAvailableClusterVersionSync(DescribeAvailableClusterVersionRequest req)
        {
            return InternalRequestAsync<DescribeAvailableClusterVersionResponse>(req, "DescribeAvailableClusterVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to check the edge component versions and K8s versions supported by TKE Edge.
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableTKEEdgeVersionRequest"/></param>
        /// <returns><see cref="DescribeAvailableTKEEdgeVersionResponse"/></returns>
        public Task<DescribeAvailableTKEEdgeVersionResponse> DescribeAvailableTKEEdgeVersion(DescribeAvailableTKEEdgeVersionRequest req)
        {
            return InternalRequestAsync<DescribeAvailableTKEEdgeVersionResponse>(req, "DescribeAvailableTKEEdgeVersion");
        }

        /// <summary>
        /// This API is used to check the edge component versions and K8s versions supported by TKE Edge.
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableTKEEdgeVersionRequest"/></param>
        /// <returns><see cref="DescribeAvailableTKEEdgeVersionResponse"/></returns>
        public DescribeAvailableTKEEdgeVersionResponse DescribeAvailableTKEEdgeVersionSync(DescribeAvailableTKEEdgeVersionRequest req)
        {
            return InternalRequestAsync<DescribeAvailableTKEEdgeVersionResponse>(req, "DescribeAvailableTKEEdgeVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query backup repositories.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupStorageLocationsRequest"/></param>
        /// <returns><see cref="DescribeBackupStorageLocationsResponse"/></returns>
        public Task<DescribeBackupStorageLocationsResponse> DescribeBackupStorageLocations(DescribeBackupStorageLocationsRequest req)
        {
            return InternalRequestAsync<DescribeBackupStorageLocationsResponse>(req, "DescribeBackupStorageLocations");
        }

        /// <summary>
        /// This API is used to query backup repositories.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupStorageLocationsRequest"/></param>
        /// <returns><see cref="DescribeBackupStorageLocationsResponse"/></returns>
        public DescribeBackupStorageLocationsResponse DescribeBackupStorageLocationsSync(DescribeBackupStorageLocationsRequest req)
        {
            return InternalRequestAsync<DescribeBackupStorageLocationsResponse>(req, "DescribeBackupStorageLocations")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query batch modification Tag status.
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchModifyTagsStatusRequest"/></param>
        /// <returns><see cref="DescribeBatchModifyTagsStatusResponse"/></returns>
        public Task<DescribeBatchModifyTagsStatusResponse> DescribeBatchModifyTagsStatus(DescribeBatchModifyTagsStatusRequest req)
        {
            return InternalRequestAsync<DescribeBatchModifyTagsStatusResponse>(req, "DescribeBatchModifyTagsStatus");
        }

        /// <summary>
        /// This API is used to query batch modification Tag status.
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchModifyTagsStatusRequest"/></param>
        /// <returns><see cref="DescribeBatchModifyTagsStatusResponse"/></returns>
        public DescribeBatchModifyTagsStatusResponse DescribeBatchModifyTagsStatusSync(DescribeBatchModifyTagsStatusRequest req)
        {
            return InternalRequestAsync<DescribeBatchModifyTagsStatusResponse>(req, "DescribeBatchModifyTagsStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Cluster auto scaling configuration
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterAsGroupOptionRequest"/></param>
        /// <returns><see cref="DescribeClusterAsGroupOptionResponse"/></returns>
        public Task<DescribeClusterAsGroupOptionResponse> DescribeClusterAsGroupOption(DescribeClusterAsGroupOptionRequest req)
        {
            return InternalRequestAsync<DescribeClusterAsGroupOptionResponse>(req, "DescribeClusterAsGroupOption");
        }

        /// <summary>
        /// Cluster auto scaling configuration
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterAsGroupOptionRequest"/></param>
        /// <returns><see cref="DescribeClusterAsGroupOptionResponse"/></returns>
        public DescribeClusterAsGroupOptionResponse DescribeClusterAsGroupOptionSync(DescribeClusterAsGroupOptionRequest req)
        {
            return InternalRequestAsync<DescribeClusterAsGroupOptionResponse>(req, "DescribeClusterAsGroupOption")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Cluster-associated scaling group list
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterAsGroupsRequest"/></param>
        /// <returns><see cref="DescribeClusterAsGroupsResponse"/></returns>
        public Task<DescribeClusterAsGroupsResponse> DescribeClusterAsGroups(DescribeClusterAsGroupsRequest req)
        {
            return InternalRequestAsync<DescribeClusterAsGroupsResponse>(req, "DescribeClusterAsGroups");
        }

        /// <summary>
        /// Cluster-associated scaling group list
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterAsGroupsRequest"/></param>
        /// <returns><see cref="DescribeClusterAsGroupsResponse"/></returns>
        public DescribeClusterAsGroupsResponse DescribeClusterAsGroupsSync(DescribeClusterAsGroupsRequest req)
        {
            return InternalRequestAsync<DescribeClusterAsGroupsResponse>(req, "DescribeClusterAsGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query cluster authentication configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterAuthenticationOptionsRequest"/></param>
        /// <returns><see cref="DescribeClusterAuthenticationOptionsResponse"/></returns>
        public Task<DescribeClusterAuthenticationOptionsResponse> DescribeClusterAuthenticationOptions(DescribeClusterAuthenticationOptionsRequest req)
        {
            return InternalRequestAsync<DescribeClusterAuthenticationOptionsResponse>(req, "DescribeClusterAuthenticationOptions");
        }

        /// <summary>
        /// This API is used to query cluster authentication configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterAuthenticationOptionsRequest"/></param>
        /// <returns><see cref="DescribeClusterAuthenticationOptionsResponse"/></returns>
        public DescribeClusterAuthenticationOptionsResponse DescribeClusterAuthenticationOptionsSync(DescribeClusterAuthenticationOptionsRequest req)
        {
            return InternalRequestAsync<DescribeClusterAuthenticationOptionsResponse>(req, "DescribeClusterAuthenticationOptions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the CommonName from the kube-apiserver client certificate that corresponding to the sub-account in RBAC authorization mode. 
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterCommonNamesRequest"/></param>
        /// <returns><see cref="DescribeClusterCommonNamesResponse"/></returns>
        public Task<DescribeClusterCommonNamesResponse> DescribeClusterCommonNames(DescribeClusterCommonNamesRequest req)
        {
            return InternalRequestAsync<DescribeClusterCommonNamesResponse>(req, "DescribeClusterCommonNames");
        }

        /// <summary>
        /// This API is used to obtain the CommonName from the kube-apiserver client certificate that corresponding to the sub-account in RBAC authorization mode. 
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterCommonNamesRequest"/></param>
        /// <returns><see cref="DescribeClusterCommonNamesResponse"/></returns>
        public DescribeClusterCommonNamesResponse DescribeClusterCommonNamesSync(DescribeClusterCommonNamesRequest req)
        {
            return InternalRequestAsync<DescribeClusterCommonNamesResponse>(req, "DescribeClusterCommonNames")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query cluster access port status (intranet / extranet access is enabled for independent clusters, and intranet access is supported for managed clusters)
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterEndpointStatusRequest"/></param>
        /// <returns><see cref="DescribeClusterEndpointStatusResponse"/></returns>
        public Task<DescribeClusterEndpointStatusResponse> DescribeClusterEndpointStatus(DescribeClusterEndpointStatusRequest req)
        {
            return InternalRequestAsync<DescribeClusterEndpointStatusResponse>(req, "DescribeClusterEndpointStatus");
        }

        /// <summary>
        /// Query cluster access port status (intranet / extranet access is enabled for independent clusters, and intranet access is supported for managed clusters)
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterEndpointStatusRequest"/></param>
        /// <returns><see cref="DescribeClusterEndpointStatusResponse"/></returns>
        public DescribeClusterEndpointStatusResponse DescribeClusterEndpointStatusSync(DescribeClusterEndpointStatusRequest req)
        {
            return InternalRequestAsync<DescribeClusterEndpointStatusResponse>(req, "DescribeClusterEndpointStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query cluster open port process status (only supports external ports of the managed cluster)
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterEndpointVipStatusRequest"/></param>
        /// <returns><see cref="DescribeClusterEndpointVipStatusResponse"/></returns>
        public Task<DescribeClusterEndpointVipStatusResponse> DescribeClusterEndpointVipStatus(DescribeClusterEndpointVipStatusRequest req)
        {
            return InternalRequestAsync<DescribeClusterEndpointVipStatusResponse>(req, "DescribeClusterEndpointVipStatus");
        }

        /// <summary>
        /// Query cluster open port process status (only supports external ports of the managed cluster)
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterEndpointVipStatusRequest"/></param>
        /// <returns><see cref="DescribeClusterEndpointVipStatusResponse"/></returns>
        public DescribeClusterEndpointVipStatusResponse DescribeClusterEndpointVipStatusSync(DescribeClusterEndpointVipStatusRequest req)
        {
            return InternalRequestAsync<DescribeClusterEndpointVipStatusResponse>(req, "DescribeClusterEndpointVipStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query cluster access addresses, including private network address, public network address, public network domain name, and security policy for public network access.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterEndpointsRequest"/></param>
        /// <returns><see cref="DescribeClusterEndpointsResponse"/></returns>
        public Task<DescribeClusterEndpointsResponse> DescribeClusterEndpoints(DescribeClusterEndpointsRequest req)
        {
            return InternalRequestAsync<DescribeClusterEndpointsResponse>(req, "DescribeClusterEndpoints");
        }

        /// <summary>
        /// This API is used to query cluster access addresses, including private network address, public network address, public network domain name, and security policy for public network access.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterEndpointsRequest"/></param>
        /// <returns><see cref="DescribeClusterEndpointsResponse"/></returns>
        public DescribeClusterEndpointsResponse DescribeClusterEndpointsSync(DescribeClusterEndpointsRequest req)
        {
            return InternalRequestAsync<DescribeClusterEndpointsResponse>(req, "DescribeClusterEndpoints")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query custom parameters of a cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterExtraArgsRequest"/></param>
        /// <returns><see cref="DescribeClusterExtraArgsResponse"/></returns>
        public Task<DescribeClusterExtraArgsResponse> DescribeClusterExtraArgs(DescribeClusterExtraArgsRequest req)
        {
            return InternalRequestAsync<DescribeClusterExtraArgsResponse>(req, "DescribeClusterExtraArgs");
        }

        /// <summary>
        /// This API is used to query custom parameters of a cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterExtraArgsRequest"/></param>
        /// <returns><see cref="DescribeClusterExtraArgsResponse"/></returns>
        public DescribeClusterExtraArgsResponse DescribeClusterExtraArgsSync(DescribeClusterExtraArgsRequest req)
        {
            return InternalRequestAsync<DescribeClusterExtraArgsResponse>(req, "DescribeClusterExtraArgs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query information of node instances in a cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterInstancesRequest"/></param>
        /// <returns><see cref="DescribeClusterInstancesResponse"/></returns>
        public Task<DescribeClusterInstancesResponse> DescribeClusterInstances(DescribeClusterInstancesRequest req)
        {
            return InternalRequestAsync<DescribeClusterInstancesResponse>(req, "DescribeClusterInstances");
        }

        /// <summary>
        /// This API is used to query information of node instances in a cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterInstancesRequest"/></param>
        /// <returns><see cref="DescribeClusterInstancesResponse"/></returns>
        public DescribeClusterInstancesResponse DescribeClusterInstancesSync(DescribeClusterInstancesRequest req)
        {
            return InternalRequestAsync<DescribeClusterInstancesResponse>(req, "DescribeClusterInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the cluster kubeconfig file. Different sub-accounts have their own kubeconfig files. The kubeconfig file contains the kube-apiserver client certificate of the corresponding sub-account. By default, the client certificate is created when this API is called for the first time, and the certificate is valid for 20 years with no permissions granted. For the cluster owner or primary account, the cluster-admin permission is granted by default.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterKubeconfigRequest"/></param>
        /// <returns><see cref="DescribeClusterKubeconfigResponse"/></returns>
        public Task<DescribeClusterKubeconfigResponse> DescribeClusterKubeconfig(DescribeClusterKubeconfigRequest req)
        {
            return InternalRequestAsync<DescribeClusterKubeconfigResponse>(req, "DescribeClusterKubeconfig");
        }

        /// <summary>
        /// This API is used to obtain the cluster kubeconfig file. Different sub-accounts have their own kubeconfig files. The kubeconfig file contains the kube-apiserver client certificate of the corresponding sub-account. By default, the client certificate is created when this API is called for the first time, and the certificate is valid for 20 years with no permissions granted. For the cluster owner or primary account, the cluster-admin permission is granted by default.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterKubeconfigRequest"/></param>
        /// <returns><see cref="DescribeClusterKubeconfigResponse"/></returns>
        public DescribeClusterKubeconfigResponse DescribeClusterKubeconfigSync(DescribeClusterKubeconfigRequest req)
        {
            return InternalRequestAsync<DescribeClusterKubeconfigResponse>(req, "DescribeClusterKubeconfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the cluster model.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterLevelAttributeRequest"/></param>
        /// <returns><see cref="DescribeClusterLevelAttributeResponse"/></returns>
        public Task<DescribeClusterLevelAttributeResponse> DescribeClusterLevelAttribute(DescribeClusterLevelAttributeRequest req)
        {
            return InternalRequestAsync<DescribeClusterLevelAttributeResponse>(req, "DescribeClusterLevelAttribute");
        }

        /// <summary>
        /// This API is used to obtain the cluster model.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterLevelAttributeRequest"/></param>
        /// <returns><see cref="DescribeClusterLevelAttributeResponse"/></returns>
        public DescribeClusterLevelAttributeResponse DescribeClusterLevelAttributeSync(DescribeClusterLevelAttributeRequest req)
        {
            return InternalRequestAsync<DescribeClusterLevelAttributeResponse>(req, "DescribeClusterLevelAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the cluster model adjustment history.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterLevelChangeRecordsRequest"/></param>
        /// <returns><see cref="DescribeClusterLevelChangeRecordsResponse"/></returns>
        public Task<DescribeClusterLevelChangeRecordsResponse> DescribeClusterLevelChangeRecords(DescribeClusterLevelChangeRecordsRequest req)
        {
            return InternalRequestAsync<DescribeClusterLevelChangeRecordsResponse>(req, "DescribeClusterLevelChangeRecords");
        }

        /// <summary>
        /// This API is used to query the cluster model adjustment history.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterLevelChangeRecordsRequest"/></param>
        /// <returns><see cref="DescribeClusterLevelChangeRecordsResponse"/></returns>
        public DescribeClusterLevelChangeRecordsResponse DescribeClusterLevelChangeRecordsSync(DescribeClusterLevelChangeRecordsRequest req)
        {
            return InternalRequestAsync<DescribeClusterLevelChangeRecordsResponse>(req, "DescribeClusterLevelChangeRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query detailed information of a node pool.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterNodePoolDetailRequest"/></param>
        /// <returns><see cref="DescribeClusterNodePoolDetailResponse"/></returns>
        public Task<DescribeClusterNodePoolDetailResponse> DescribeClusterNodePoolDetail(DescribeClusterNodePoolDetailRequest req)
        {
            return InternalRequestAsync<DescribeClusterNodePoolDetailResponse>(req, "DescribeClusterNodePoolDetail");
        }

        /// <summary>
        /// This API is used to query detailed information of a node pool.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterNodePoolDetailRequest"/></param>
        /// <returns><see cref="DescribeClusterNodePoolDetailResponse"/></returns>
        public DescribeClusterNodePoolDetailResponse DescribeClusterNodePoolDetailSync(DescribeClusterNodePoolDetailRequest req)
        {
            return InternalRequestAsync<DescribeClusterNodePoolDetailResponse>(req, "DescribeClusterNodePoolDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the node pool list
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterNodePoolsRequest"/></param>
        /// <returns><see cref="DescribeClusterNodePoolsResponse"/></returns>
        public Task<DescribeClusterNodePoolsResponse> DescribeClusterNodePools(DescribeClusterNodePoolsRequest req)
        {
            return InternalRequestAsync<DescribeClusterNodePoolsResponse>(req, "DescribeClusterNodePools");
        }

        /// <summary>
        /// This API is used to query the node pool list
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterNodePoolsRequest"/></param>
        /// <returns><see cref="DescribeClusterNodePoolsResponse"/></returns>
        public DescribeClusterNodePoolsResponse DescribeClusterNodePoolsSync(DescribeClusterNodePoolsRequest req)
        {
            return InternalRequestAsync<DescribeClusterNodePoolsResponse>(req, "DescribeClusterNodePools")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query one or more cluster route tables.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterRouteTablesRequest"/></param>
        /// <returns><see cref="DescribeClusterRouteTablesResponse"/></returns>
        public Task<DescribeClusterRouteTablesResponse> DescribeClusterRouteTables(DescribeClusterRouteTablesRequest req)
        {
            return InternalRequestAsync<DescribeClusterRouteTablesResponse>(req, "DescribeClusterRouteTables");
        }

        /// <summary>
        /// This API is used to query one or more cluster route tables.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterRouteTablesRequest"/></param>
        /// <returns><see cref="DescribeClusterRouteTablesResponse"/></returns>
        public DescribeClusterRouteTablesResponse DescribeClusterRouteTablesSync(DescribeClusterRouteTablesRequest req)
        {
            return InternalRequestAsync<DescribeClusterRouteTablesResponse>(req, "DescribeClusterRouteTables")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query cluster routes.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterRoutesRequest"/></param>
        /// <returns><see cref="DescribeClusterRoutesResponse"/></returns>
        public Task<DescribeClusterRoutesResponse> DescribeClusterRoutes(DescribeClusterRoutesRequest req)
        {
            return InternalRequestAsync<DescribeClusterRoutesResponse>(req, "DescribeClusterRoutes");
        }

        /// <summary>
        /// This API is used to query cluster routes.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterRoutesRequest"/></param>
        /// <returns><see cref="DescribeClusterRoutesResponse"/></returns>
        public DescribeClusterRoutesResponse DescribeClusterRoutesSync(DescribeClusterRoutesRequest req)
        {
            return InternalRequestAsync<DescribeClusterRoutesResponse>(req, "DescribeClusterRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the key information of a cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterSecurityRequest"/></param>
        /// <returns><see cref="DescribeClusterSecurityResponse"/></returns>
        public Task<DescribeClusterSecurityResponse> DescribeClusterSecurity(DescribeClusterSecurityRequest req)
        {
            return InternalRequestAsync<DescribeClusterSecurityResponse>(req, "DescribeClusterSecurity");
        }

        /// <summary>
        /// This API is used to query the key information of a cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterSecurityRequest"/></param>
        /// <returns><see cref="DescribeClusterSecurityResponse"/></returns>
        public DescribeClusterSecurityResponse DescribeClusterSecuritySync(DescribeClusterSecurityRequest req)
        {
            return InternalRequestAsync<DescribeClusterSecurityResponse>(req, "DescribeClusterSecurity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of clusters under the current account.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterStatusRequest"/></param>
        /// <returns><see cref="DescribeClusterStatusResponse"/></returns>
        public Task<DescribeClusterStatusResponse> DescribeClusterStatus(DescribeClusterStatusRequest req)
        {
            return InternalRequestAsync<DescribeClusterStatusResponse>(req, "DescribeClusterStatus");
        }

        /// <summary>
        /// This API is used to query the information of clusters under the current account.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterStatusRequest"/></param>
        /// <returns><see cref="DescribeClusterStatusResponse"/></returns>
        public DescribeClusterStatusResponse DescribeClusterStatusSync(DescribeClusterStatusRequest req)
        {
            return InternalRequestAsync<DescribeClusterStatusResponse>(req, "DescribeClusterStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to view the Super Node list.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterVirtualNodeRequest"/></param>
        /// <returns><see cref="DescribeClusterVirtualNodeResponse"/></returns>
        public Task<DescribeClusterVirtualNodeResponse> DescribeClusterVirtualNode(DescribeClusterVirtualNodeRequest req)
        {
            return InternalRequestAsync<DescribeClusterVirtualNodeResponse>(req, "DescribeClusterVirtualNode");
        }

        /// <summary>
        /// This API is used to view the Super Node list.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterVirtualNodeRequest"/></param>
        /// <returns><see cref="DescribeClusterVirtualNodeResponse"/></returns>
        public DescribeClusterVirtualNodeResponse DescribeClusterVirtualNodeSync(DescribeClusterVirtualNodeRequest req)
        {
            return InternalRequestAsync<DescribeClusterVirtualNodeResponse>(req, "DescribeClusterVirtualNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to view the Super Node Pool list.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterVirtualNodePoolsRequest"/></param>
        /// <returns><see cref="DescribeClusterVirtualNodePoolsResponse"/></returns>
        public Task<DescribeClusterVirtualNodePoolsResponse> DescribeClusterVirtualNodePools(DescribeClusterVirtualNodePoolsRequest req)
        {
            return InternalRequestAsync<DescribeClusterVirtualNodePoolsResponse>(req, "DescribeClusterVirtualNodePools");
        }

        /// <summary>
        /// This API is used to view the Super Node Pool list.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterVirtualNodePoolsRequest"/></param>
        /// <returns><see cref="DescribeClusterVirtualNodePoolsResponse"/></returns>
        public DescribeClusterVirtualNodePoolsResponse DescribeClusterVirtualNodePoolsSync(DescribeClusterVirtualNodePoolsRequest req)
        {
            return InternalRequestAsync<DescribeClusterVirtualNodePoolsResponse>(req, "DescribeClusterVirtualNodePools")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query clusters list.
        /// </summary>
        /// <param name="req"><see cref="DescribeClustersRequest"/></param>
        /// <returns><see cref="DescribeClustersResponse"/></returns>
        public Task<DescribeClustersResponse> DescribeClusters(DescribeClustersRequest req)
        {
            return InternalRequestAsync<DescribeClustersResponse>(req, "DescribeClusters");
        }

        /// <summary>
        /// This API is used to query clusters list.
        /// </summary>
        /// <param name="req"><see cref="DescribeClustersRequest"/></param>
        /// <returns><see cref="DescribeClustersResponse"/></returns>
        public DescribeClustersResponse DescribeClustersSync(DescribeClustersRequest req)
        {
            return InternalRequestAsync<DescribeClustersResponse>(req, "DescribeClusters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the ECM instance information.
        /// </summary>
        /// <param name="req"><see cref="DescribeECMInstancesRequest"/></param>
        /// <returns><see cref="DescribeECMInstancesResponse"/></returns>
        public Task<DescribeECMInstancesResponse> DescribeECMInstances(DescribeECMInstancesRequest req)
        {
            return InternalRequestAsync<DescribeECMInstancesResponse>(req, "DescribeECMInstances");
        }

        /// <summary>
        /// This API is used to obtain the ECM instance information.
        /// </summary>
        /// <param name="req"><see cref="DescribeECMInstancesRequest"/></param>
        /// <returns><see cref="DescribeECMInstancesResponse"/></returns>
        public DescribeECMInstancesResponse DescribeECMInstancesSync(DescribeECMInstancesRequest req)
        {
            return InternalRequestAsync<DescribeECMInstancesResponse>(req, "DescribeECMInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the custom parameters available for an edge cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeAvailableExtraArgsRequest"/></param>
        /// <returns><see cref="DescribeEdgeAvailableExtraArgsResponse"/></returns>
        public Task<DescribeEdgeAvailableExtraArgsResponse> DescribeEdgeAvailableExtraArgs(DescribeEdgeAvailableExtraArgsRequest req)
        {
            return InternalRequestAsync<DescribeEdgeAvailableExtraArgsResponse>(req, "DescribeEdgeAvailableExtraArgs");
        }

        /// <summary>
        /// This API is used to query the custom parameters available for an edge cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeAvailableExtraArgsRequest"/></param>
        /// <returns><see cref="DescribeEdgeAvailableExtraArgsResponse"/></returns>
        public DescribeEdgeAvailableExtraArgsResponse DescribeEdgeAvailableExtraArgsSync(DescribeEdgeAvailableExtraArgsRequest req)
        {
            return InternalRequestAsync<DescribeEdgeAvailableExtraArgsResponse>(req, "DescribeEdgeAvailableExtraArgs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the edge CVM instance information.
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeCVMInstancesRequest"/></param>
        /// <returns><see cref="DescribeEdgeCVMInstancesResponse"/></returns>
        public Task<DescribeEdgeCVMInstancesResponse> DescribeEdgeCVMInstances(DescribeEdgeCVMInstancesRequest req)
        {
            return InternalRequestAsync<DescribeEdgeCVMInstancesResponse>(req, "DescribeEdgeCVMInstances");
        }

        /// <summary>
        /// This API is used to obtain the edge CVM instance information.
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeCVMInstancesRequest"/></param>
        /// <returns><see cref="DescribeEdgeCVMInstancesResponse"/></returns>
        public DescribeEdgeCVMInstancesResponse DescribeEdgeCVMInstancesSync(DescribeEdgeCVMInstancesRequest req)
        {
            return InternalRequestAsync<DescribeEdgeCVMInstancesResponse>(req, "DescribeEdgeCVMInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query custom parameters of an edge cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeClusterExtraArgsRequest"/></param>
        /// <returns><see cref="DescribeEdgeClusterExtraArgsResponse"/></returns>
        public Task<DescribeEdgeClusterExtraArgsResponse> DescribeEdgeClusterExtraArgs(DescribeEdgeClusterExtraArgsRequest req)
        {
            return InternalRequestAsync<DescribeEdgeClusterExtraArgsResponse>(req, "DescribeEdgeClusterExtraArgs");
        }

        /// <summary>
        /// This API is used to query custom parameters of an edge cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeClusterExtraArgsRequest"/></param>
        /// <returns><see cref="DescribeEdgeClusterExtraArgsResponse"/></returns>
        public DescribeEdgeClusterExtraArgsResponse DescribeEdgeClusterExtraArgsSync(DescribeEdgeClusterExtraArgsRequest req)
        {
            return InternalRequestAsync<DescribeEdgeClusterExtraArgsResponse>(req, "DescribeEdgeClusterExtraArgs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the TKE Edge cluster node information.
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeClusterInstancesRequest"/></param>
        /// <returns><see cref="DescribeEdgeClusterInstancesResponse"/></returns>
        public Task<DescribeEdgeClusterInstancesResponse> DescribeEdgeClusterInstances(DescribeEdgeClusterInstancesRequest req)
        {
            return InternalRequestAsync<DescribeEdgeClusterInstancesResponse>(req, "DescribeEdgeClusterInstances");
        }

        /// <summary>
        /// This API is used to query the TKE Edge cluster node information.
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeClusterInstancesRequest"/></param>
        /// <returns><see cref="DescribeEdgeClusterInstancesResponse"/></returns>
        public DescribeEdgeClusterInstancesResponse DescribeEdgeClusterInstancesSync(DescribeEdgeClusterInstancesRequest req)
        {
            return InternalRequestAsync<DescribeEdgeClusterInstancesResponse>(req, "DescribeEdgeClusterInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the upgrade information of an edge cluster, including the upgradeable components, the current upgrade status, and errors occur during the upgrade.
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeClusterUpgradeInfoRequest"/></param>
        /// <returns><see cref="DescribeEdgeClusterUpgradeInfoResponse"/></returns>
        public Task<DescribeEdgeClusterUpgradeInfoResponse> DescribeEdgeClusterUpgradeInfo(DescribeEdgeClusterUpgradeInfoRequest req)
        {
            return InternalRequestAsync<DescribeEdgeClusterUpgradeInfoResponse>(req, "DescribeEdgeClusterUpgradeInfo");
        }

        /// <summary>
        /// This API is used to query the upgrade information of an edge cluster, including the upgradeable components, the current upgrade status, and errors occur during the upgrade.
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeClusterUpgradeInfoRequest"/></param>
        /// <returns><see cref="DescribeEdgeClusterUpgradeInfoResponse"/></returns>
        public DescribeEdgeClusterUpgradeInfoResponse DescribeEdgeClusterUpgradeInfoSync(DescribeEdgeClusterUpgradeInfoRequest req)
        {
            return InternalRequestAsync<DescribeEdgeClusterUpgradeInfoResponse>(req, "DescribeEdgeClusterUpgradeInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the status of event storage, cluster auditing and logging.
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeLogSwitchesRequest"/></param>
        /// <returns><see cref="DescribeEdgeLogSwitchesResponse"/></returns>
        public Task<DescribeEdgeLogSwitchesResponse> DescribeEdgeLogSwitches(DescribeEdgeLogSwitchesRequest req)
        {
            return InternalRequestAsync<DescribeEdgeLogSwitchesResponse>(req, "DescribeEdgeLogSwitches");
        }

        /// <summary>
        /// This API is used to query the status of event storage, cluster auditing and logging.
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeLogSwitchesRequest"/></param>
        /// <returns><see cref="DescribeEdgeLogSwitchesResponse"/></returns>
        public DescribeEdgeLogSwitchesResponse DescribeEdgeLogSwitchesSync(DescribeEdgeLogSwitchesRequest req)
        {
            return InternalRequestAsync<DescribeEdgeLogSwitchesResponse>(req, "DescribeEdgeLogSwitches")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the task progress of enabling VPC-CNI mode.
        /// </summary>
        /// <param name="req"><see cref="DescribeEnableVpcCniProgressRequest"/></param>
        /// <returns><see cref="DescribeEnableVpcCniProgressResponse"/></returns>
        public Task<DescribeEnableVpcCniProgressResponse> DescribeEnableVpcCniProgress(DescribeEnableVpcCniProgressRequest req)
        {
            return InternalRequestAsync<DescribeEnableVpcCniProgressResponse>(req, "DescribeEnableVpcCniProgress");
        }

        /// <summary>
        /// This API is used to query the task progress of enabling VPC-CNI mode.
        /// </summary>
        /// <param name="req"><see cref="DescribeEnableVpcCniProgressRequest"/></param>
        /// <returns><see cref="DescribeEnableVpcCniProgressResponse"/></returns>
        public DescribeEnableVpcCniProgressResponse DescribeEnableVpcCniProgressSync(DescribeEnableVpcCniProgressRequest req)
        {
            return InternalRequestAsync<DescribeEnableVpcCniProgressResponse>(req, "DescribeEnableVpcCniProgress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the encryption status of etcd data.
        /// </summary>
        /// <param name="req"><see cref="DescribeEncryptionStatusRequest"/></param>
        /// <returns><see cref="DescribeEncryptionStatusResponse"/></returns>
        public Task<DescribeEncryptionStatusResponse> DescribeEncryptionStatus(DescribeEncryptionStatusRequest req)
        {
            return InternalRequestAsync<DescribeEncryptionStatusResponse>(req, "DescribeEncryptionStatus");
        }

        /// <summary>
        /// This API is used to query the encryption status of etcd data.
        /// </summary>
        /// <param name="req"><see cref="DescribeEncryptionStatusRequest"/></param>
        /// <returns><see cref="DescribeEncryptionStatusResponse"/></returns>
        public DescribeEncryptionStatusResponse DescribeEncryptionStatusSync(DescribeEncryptionStatusRequest req)
        {
            return InternalRequestAsync<DescribeEncryptionStatusResponse>(req, "DescribeEncryptionStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query one or more existing node and determine whether they can be added to a cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeExistedInstancesRequest"/></param>
        /// <returns><see cref="DescribeExistedInstancesResponse"/></returns>
        public Task<DescribeExistedInstancesResponse> DescribeExistedInstances(DescribeExistedInstancesRequest req)
        {
            return InternalRequestAsync<DescribeExistedInstancesResponse>(req, "DescribeExistedInstances");
        }

        /// <summary>
        /// This API is used to query one or more existing node and determine whether they can be added to a cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeExistedInstancesRequest"/></param>
        /// <returns><see cref="DescribeExistedInstancesResponse"/></returns>
        public DescribeExistedInstancesResponse DescribeExistedInstancesSync(DescribeExistedInstancesRequest req)
        {
            return InternalRequestAsync<DescribeExistedInstancesResponse>(req, "DescribeExistedInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to view third-party node pool configuration information.
        /// </summary>
        /// <param name="req"><see cref="DescribeExternalNodeSupportConfigRequest"/></param>
        /// <returns><see cref="DescribeExternalNodeSupportConfigResponse"/></returns>
        public Task<DescribeExternalNodeSupportConfigResponse> DescribeExternalNodeSupportConfig(DescribeExternalNodeSupportConfigRequest req)
        {
            return InternalRequestAsync<DescribeExternalNodeSupportConfigResponse>(req, "DescribeExternalNodeSupportConfig");
        }

        /// <summary>
        /// This API is used to view third-party node pool configuration information.
        /// </summary>
        /// <param name="req"><see cref="DescribeExternalNodeSupportConfigRequest"/></param>
        /// <returns><see cref="DescribeExternalNodeSupportConfigResponse"/></returns>
        public DescribeExternalNodeSupportConfigResponse DescribeExternalNodeSupportConfigSync(DescribeExternalNodeSupportConfigRequest req)
        {
            return InternalRequestAsync<DescribeExternalNodeSupportConfigResponse>(req, "DescribeExternalNodeSupportConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain eniipamd component information.
        /// </summary>
        /// <param name="req"><see cref="DescribeIPAMDRequest"/></param>
        /// <returns><see cref="DescribeIPAMDResponse"/></returns>
        public Task<DescribeIPAMDResponse> DescribeIPAMD(DescribeIPAMDRequest req)
        {
            return InternalRequestAsync<DescribeIPAMDResponse>(req, "DescribeIPAMD");
        }

        /// <summary>
        /// This API is used to obtain eniipamd component information.
        /// </summary>
        /// <param name="req"><see cref="DescribeIPAMDRequest"/></param>
        /// <returns><see cref="DescribeIPAMDResponse"/></returns>
        public DescribeIPAMDResponse DescribeIPAMDSync(DescribeIPAMDRequest req)
        {
            return InternalRequestAsync<DescribeIPAMDResponse>(req, "DescribeIPAMD")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get image information.
        /// </summary>
        /// <param name="req"><see cref="DescribeImagesRequest"/></param>
        /// <returns><see cref="DescribeImagesResponse"/></returns>
        public Task<DescribeImagesResponse> DescribeImages(DescribeImagesRequest req)
        {
            return InternalRequestAsync<DescribeImagesResponse>(req, "DescribeImages");
        }

        /// <summary>
        /// This API is used to get image information.
        /// </summary>
        /// <param name="req"><see cref="DescribeImagesRequest"/></param>
        /// <returns><see cref="DescribeImagesResponse"/></returns>
        public DescribeImagesResponse DescribeImagesSync(DescribeImagesRequest req)
        {
            return InternalRequestAsync<DescribeImagesResponse>(req, "DescribeImages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the log collection rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogConfigsRequest"/></param>
        /// <returns><see cref="DescribeLogConfigsResponse"/></returns>
        public Task<DescribeLogConfigsResponse> DescribeLogConfigs(DescribeLogConfigsRequest req)
        {
            return InternalRequestAsync<DescribeLogConfigsResponse>(req, "DescribeLogConfigs");
        }

        /// <summary>
        /// This API is used to query the log collection rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogConfigsRequest"/></param>
        /// <returns><see cref="DescribeLogConfigsResponse"/></returns>
        public DescribeLogConfigsResponse DescribeLogConfigsSync(DescribeLogConfigsRequest req)
        {
            return InternalRequestAsync<DescribeLogConfigsResponse>(req, "DescribeLogConfigs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query Cluster Log (Auditing, Event, Common Log) Switch List.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogSwitchesRequest"/></param>
        /// <returns><see cref="DescribeLogSwitchesResponse"/></returns>
        public Task<DescribeLogSwitchesResponse> DescribeLogSwitches(DescribeLogSwitchesRequest req)
        {
            return InternalRequestAsync<DescribeLogSwitchesResponse>(req, "DescribeLogSwitches");
        }

        /// <summary>
        /// This API is used to query Cluster Log (Auditing, Event, Common Log) Switch List.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogSwitchesRequest"/></param>
        /// <returns><see cref="DescribeLogSwitchesResponse"/></returns>
        public DescribeLogSwitchesResponse DescribeLogSwitchesSync(DescribeLogSwitchesRequest req)
        {
            return InternalRequestAsync<DescribeLogSwitchesResponse>(req, "DescribeLogSwitches")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the billing information of running Pods. You can query a specific Pod by Namespace and Name or batch query by Pod Uid.
        /// </summary>
        /// <param name="req"><see cref="DescribePodChargeInfoRequest"/></param>
        /// <returns><see cref="DescribePodChargeInfoResponse"/></returns>
        public Task<DescribePodChargeInfoResponse> DescribePodChargeInfo(DescribePodChargeInfoRequest req)
        {
            return InternalRequestAsync<DescribePodChargeInfoResponse>(req, "DescribePodChargeInfo");
        }

        /// <summary>
        /// This API is used to query the billing information of running Pods. You can query a specific Pod by Namespace and Name or batch query by Pod Uid.
        /// </summary>
        /// <param name="req"><see cref="DescribePodChargeInfoRequest"/></param>
        /// <returns><see cref="DescribePodChargeInfoResponse"/></returns>
        public DescribePodChargeInfoResponse DescribePodChargeInfoSync(DescribePodChargeInfoRequest req)
        {
            return InternalRequestAsync<DescribePodChargeInfoResponse>(req, "DescribePodChargeInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the instance details.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusInstanceRequest"/></param>
        /// <returns><see cref="DescribePrometheusInstanceResponse"/></returns>
        public Task<DescribePrometheusInstanceResponse> DescribePrometheusInstance(DescribePrometheusInstanceRequest req)
        {
            return InternalRequestAsync<DescribePrometheusInstanceResponse>(req, "DescribePrometheusInstance");
        }

        /// <summary>
        /// This API is used to obtain the instance details.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusInstanceRequest"/></param>
        /// <returns><see cref="DescribePrometheusInstanceResponse"/></returns>
        public DescribePrometheusInstanceResponse DescribePrometheusInstanceSync(DescribePrometheusInstanceRequest req)
        {
            return InternalRequestAsync<DescribePrometheusInstanceResponse>(req, "DescribePrometheusInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain all regions supported by TKE.
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public Task<DescribeRegionsResponse> DescribeRegions(DescribeRegionsRequest req)
        {
            return InternalRequestAsync<DescribeRegionsResponse>(req, "DescribeRegions");
        }

        /// <summary>
        /// This API is used to obtain all regions supported by TKE.
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public DescribeRegionsResponse DescribeRegionsSync(DescribeRegionsRequest req)
        {
            return InternalRequestAsync<DescribeRegionsResponse>(req, "DescribeRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the usage rate of various types of Reserved Coupons.
        /// </summary>
        /// <param name="req"><see cref="DescribeReservedInstanceUtilizationRateRequest"/></param>
        /// <returns><see cref="DescribeReservedInstanceUtilizationRateResponse"/></returns>
        public Task<DescribeReservedInstanceUtilizationRateResponse> DescribeReservedInstanceUtilizationRate(DescribeReservedInstanceUtilizationRateRequest req)
        {
            return InternalRequestAsync<DescribeReservedInstanceUtilizationRateResponse>(req, "DescribeReservedInstanceUtilizationRate");
        }

        /// <summary>
        /// This API is used to query the usage rate of various types of Reserved Coupons.
        /// </summary>
        /// <param name="req"><see cref="DescribeReservedInstanceUtilizationRateRequest"/></param>
        /// <returns><see cref="DescribeReservedInstanceUtilizationRateResponse"/></returns>
        public DescribeReservedInstanceUtilizationRateResponse DescribeReservedInstanceUtilizationRateSync(DescribeReservedInstanceUtilizationRateRequest req)
        {
            return InternalRequestAsync<DescribeReservedInstanceUtilizationRateResponse>(req, "DescribeReservedInstanceUtilizationRate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the cluster resource usage.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceUsageRequest"/></param>
        /// <returns><see cref="DescribeResourceUsageResponse"/></returns>
        public Task<DescribeResourceUsageResponse> DescribeResourceUsage(DescribeResourceUsageRequest req)
        {
            return InternalRequestAsync<DescribeResourceUsageResponse>(req, "DescribeResourceUsage");
        }

        /// <summary>
        /// This API is used to query the cluster resource usage.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceUsageRequest"/></param>
        /// <returns><see cref="DescribeResourceUsageResponse"/></returns>
        public DescribeResourceUsageResponse DescribeResourceUsageSync(DescribeResourceUsageRequest req)
        {
            return InternalRequestAsync<DescribeResourceUsageResponse>(req, "DescribeResourceUsage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of route table conflicts.
        /// </summary>
        /// <param name="req"><see cref="DescribeRouteTableConflictsRequest"/></param>
        /// <returns><see cref="DescribeRouteTableConflictsResponse"/></returns>
        public Task<DescribeRouteTableConflictsResponse> DescribeRouteTableConflicts(DescribeRouteTableConflictsRequest req)
        {
            return InternalRequestAsync<DescribeRouteTableConflictsResponse>(req, "DescribeRouteTableConflicts");
        }

        /// <summary>
        /// This API is used to query the list of route table conflicts.
        /// </summary>
        /// <param name="req"><see cref="DescribeRouteTableConflictsRequest"/></param>
        /// <returns><see cref="DescribeRouteTableConflictsResponse"/></returns>
        public DescribeRouteTableConflictsResponse DescribeRouteTableConflictsSync(DescribeRouteTableConflictsRequest req)
        {
            return InternalRequestAsync<DescribeRouteTableConflictsResponse>(req, "DescribeRouteTableConflicts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to retrieve optional runtime versions based on K8S version.
        /// </summary>
        /// <param name="req"><see cref="DescribeSupportedRuntimeRequest"/></param>
        /// <returns><see cref="DescribeSupportedRuntimeResponse"/></returns>
        public Task<DescribeSupportedRuntimeResponse> DescribeSupportedRuntime(DescribeSupportedRuntimeRequest req)
        {
            return InternalRequestAsync<DescribeSupportedRuntimeResponse>(req, "DescribeSupportedRuntime");
        }

        /// <summary>
        /// This API is used to retrieve optional runtime versions based on K8S version.
        /// </summary>
        /// <param name="req"><see cref="DescribeSupportedRuntimeRequest"/></param>
        /// <returns><see cref="DescribeSupportedRuntimeResponse"/></returns>
        public DescribeSupportedRuntimeResponse DescribeSupportedRuntimeSync(DescribeSupportedRuntimeRequest req)
        {
            return InternalRequestAsync<DescribeSupportedRuntimeResponse>(req, "DescribeSupportedRuntime")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the authentication information of a TKE Edge cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeTKEEdgeClusterCredentialRequest"/></param>
        /// <returns><see cref="DescribeTKEEdgeClusterCredentialResponse"/></returns>
        public Task<DescribeTKEEdgeClusterCredentialResponse> DescribeTKEEdgeClusterCredential(DescribeTKEEdgeClusterCredentialRequest req)
        {
            return InternalRequestAsync<DescribeTKEEdgeClusterCredentialResponse>(req, "DescribeTKEEdgeClusterCredential");
        }

        /// <summary>
        /// This API is used to obtain the authentication information of a TKE Edge cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeTKEEdgeClusterCredentialRequest"/></param>
        /// <returns><see cref="DescribeTKEEdgeClusterCredentialResponse"/></returns>
        public DescribeTKEEdgeClusterCredentialResponse DescribeTKEEdgeClusterCredentialSync(DescribeTKEEdgeClusterCredentialRequest req)
        {
            return InternalRequestAsync<DescribeTKEEdgeClusterCredentialResponse>(req, "DescribeTKEEdgeClusterCredential")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the current status and process information of a TKE Edge cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeTKEEdgeClusterStatusRequest"/></param>
        /// <returns><see cref="DescribeTKEEdgeClusterStatusResponse"/></returns>
        public Task<DescribeTKEEdgeClusterStatusResponse> DescribeTKEEdgeClusterStatus(DescribeTKEEdgeClusterStatusRequest req)
        {
            return InternalRequestAsync<DescribeTKEEdgeClusterStatusResponse>(req, "DescribeTKEEdgeClusterStatus");
        }

        /// <summary>
        /// This API is used to query the current status and process information of a TKE Edge cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeTKEEdgeClusterStatusRequest"/></param>
        /// <returns><see cref="DescribeTKEEdgeClusterStatusResponse"/></returns>
        public DescribeTKEEdgeClusterStatusResponse DescribeTKEEdgeClusterStatusSync(DescribeTKEEdgeClusterStatusRequest req)
        {
            return InternalRequestAsync<DescribeTKEEdgeClusterStatusResponse>(req, "DescribeTKEEdgeClusterStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of TKE Edge clusters.
        /// </summary>
        /// <param name="req"><see cref="DescribeTKEEdgeClustersRequest"/></param>
        /// <returns><see cref="DescribeTKEEdgeClustersResponse"/></returns>
        public Task<DescribeTKEEdgeClustersResponse> DescribeTKEEdgeClusters(DescribeTKEEdgeClustersRequest req)
        {
            return InternalRequestAsync<DescribeTKEEdgeClustersResponse>(req, "DescribeTKEEdgeClusters");
        }

        /// <summary>
        /// This API is used to query the list of TKE Edge clusters.
        /// </summary>
        /// <param name="req"><see cref="DescribeTKEEdgeClustersRequest"/></param>
        /// <returns><see cref="DescribeTKEEdgeClustersResponse"/></returns>
        public DescribeTKEEdgeClustersResponse DescribeTKEEdgeClustersSync(DescribeTKEEdgeClustersRequest req)
        {
            return InternalRequestAsync<DescribeTKEEdgeClustersResponse>(req, "DescribeTKEEdgeClusters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the kubeconfig for access to a TKE Edge cluster through the public network.
        /// </summary>
        /// <param name="req"><see cref="DescribeTKEEdgeExternalKubeconfigRequest"/></param>
        /// <returns><see cref="DescribeTKEEdgeExternalKubeconfigResponse"/></returns>
        public Task<DescribeTKEEdgeExternalKubeconfigResponse> DescribeTKEEdgeExternalKubeconfig(DescribeTKEEdgeExternalKubeconfigRequest req)
        {
            return InternalRequestAsync<DescribeTKEEdgeExternalKubeconfigResponse>(req, "DescribeTKEEdgeExternalKubeconfig");
        }

        /// <summary>
        /// This API is used to obtain the kubeconfig for access to a TKE Edge cluster through the public network.
        /// </summary>
        /// <param name="req"><see cref="DescribeTKEEdgeExternalKubeconfigRequest"/></param>
        /// <returns><see cref="DescribeTKEEdgeExternalKubeconfigResponse"/></returns>
        public DescribeTKEEdgeExternalKubeconfigResponse DescribeTKEEdgeExternalKubeconfigSync(DescribeTKEEdgeExternalKubeconfigRequest req)
        {
            return InternalRequestAsync<DescribeTKEEdgeExternalKubeconfigResponse>(req, "DescribeTKEEdgeExternalKubeconfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the URL of TKE edge script. You can add external nodes to a TKE Edge cluster by downloading the URL.
        /// </summary>
        /// <param name="req"><see cref="DescribeTKEEdgeScriptRequest"/></param>
        /// <returns><see cref="DescribeTKEEdgeScriptResponse"/></returns>
        public Task<DescribeTKEEdgeScriptResponse> DescribeTKEEdgeScript(DescribeTKEEdgeScriptRequest req)
        {
            return InternalRequestAsync<DescribeTKEEdgeScriptResponse>(req, "DescribeTKEEdgeScript");
        }

        /// <summary>
        /// This API is used to query the URL of TKE edge script. You can add external nodes to a TKE Edge cluster by downloading the URL.
        /// </summary>
        /// <param name="req"><see cref="DescribeTKEEdgeScriptRequest"/></param>
        /// <returns><see cref="DescribeTKEEdgeScriptResponse"/></returns>
        public DescribeTKEEdgeScriptResponse DescribeTKEEdgeScriptSync(DescribeTKEEdgeScriptRequest req)
        {
            return InternalRequestAsync<DescribeTKEEdgeScriptResponse>(req, "DescribeTKEEdgeScript")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query cluster version information.
        /// </summary>
        /// <param name="req"><see cref="DescribeVersionsRequest"/></param>
        /// <returns><see cref="DescribeVersionsResponse"/></returns>
        public Task<DescribeVersionsResponse> DescribeVersions(DescribeVersionsRequest req)
        {
            return InternalRequestAsync<DescribeVersionsResponse>(req, "DescribeVersions");
        }

        /// <summary>
        /// This API is used to query cluster version information.
        /// </summary>
        /// <param name="req"><see cref="DescribeVersionsRequest"/></param>
        /// <returns><see cref="DescribeVersionsResponse"/></returns>
        public DescribeVersionsResponse DescribeVersionsSync(DescribeVersionsRequest req)
        {
            return InternalRequestAsync<DescribeVersionsResponse>(req, "DescribeVersions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the maximum number of Pods in the VPC-CNI network mode supported by the models in the specified availability zone of the current user and region.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcCniPodLimitsRequest"/></param>
        /// <returns><see cref="DescribeVpcCniPodLimitsResponse"/></returns>
        public Task<DescribeVpcCniPodLimitsResponse> DescribeVpcCniPodLimits(DescribeVpcCniPodLimitsRequest req)
        {
            return InternalRequestAsync<DescribeVpcCniPodLimitsResponse>(req, "DescribeVpcCniPodLimits");
        }

        /// <summary>
        /// This API is used to query the maximum number of Pods in the VPC-CNI network mode supported by the models in the specified availability zone of the current user and region.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcCniPodLimitsRequest"/></param>
        /// <returns><see cref="DescribeVpcCniPodLimitsResponse"/></returns>
        public DescribeVpcCniPodLimitsResponse DescribeVpcCniPodLimitsSync(DescribeVpcCniPodLimitsRequest req)
        {
            return InternalRequestAsync<DescribeVpcCniPodLimitsResponse>(req, "DescribeVpcCniPodLimits")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable cluster deletion protection.
        /// </summary>
        /// <param name="req"><see cref="DisableClusterDeletionProtectionRequest"/></param>
        /// <returns><see cref="DisableClusterDeletionProtectionResponse"/></returns>
        public Task<DisableClusterDeletionProtectionResponse> DisableClusterDeletionProtection(DisableClusterDeletionProtectionRequest req)
        {
            return InternalRequestAsync<DisableClusterDeletionProtectionResponse>(req, "DisableClusterDeletionProtection");
        }

        /// <summary>
        /// This API is used to disable cluster deletion protection.
        /// </summary>
        /// <param name="req"><see cref="DisableClusterDeletionProtectionRequest"/></param>
        /// <returns><see cref="DisableClusterDeletionProtectionResponse"/></returns>
        public DisableClusterDeletionProtectionResponse DisableClusterDeletionProtectionSync(DisableClusterDeletionProtectionRequest req)
        {
            return InternalRequestAsync<DisableClusterDeletionProtectionResponse>(req, "DisableClusterDeletionProtection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable encryption protection.
        /// </summary>
        /// <param name="req"><see cref="DisableEncryptionProtectionRequest"/></param>
        /// <returns><see cref="DisableEncryptionProtectionResponse"/></returns>
        public Task<DisableEncryptionProtectionResponse> DisableEncryptionProtection(DisableEncryptionProtectionRequest req)
        {
            return InternalRequestAsync<DisableEncryptionProtectionResponse>(req, "DisableEncryptionProtection");
        }

        /// <summary>
        /// This API is used to disable encryption protection.
        /// </summary>
        /// <param name="req"><see cref="DisableEncryptionProtectionRequest"/></param>
        /// <returns><see cref="DisableEncryptionProtectionResponse"/></returns>
        public DisableEncryptionProtectionResponse DisableEncryptionProtectionSync(DisableEncryptionProtectionRequest req)
        {
            return InternalRequestAsync<DisableEncryptionProtectionResponse>(req, "DisableEncryptionProtection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to evict the Super Node.
        /// </summary>
        /// <param name="req"><see cref="DrainClusterVirtualNodeRequest"/></param>
        /// <returns><see cref="DrainClusterVirtualNodeResponse"/></returns>
        public Task<DrainClusterVirtualNodeResponse> DrainClusterVirtualNode(DrainClusterVirtualNodeRequest req)
        {
            return InternalRequestAsync<DrainClusterVirtualNodeResponse>(req, "DrainClusterVirtualNode");
        }

        /// <summary>
        /// This API is used to evict the Super Node.
        /// </summary>
        /// <param name="req"><see cref="DrainClusterVirtualNodeRequest"/></param>
        /// <returns><see cref="DrainClusterVirtualNodeResponse"/></returns>
        public DrainClusterVirtualNodeResponse DrainClusterVirtualNodeSync(DrainClusterVirtualNodeRequest req)
        {
            return InternalRequestAsync<DrainClusterVirtualNodeResponse>(req, "DrainClusterVirtualNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable cluster deletion protection.
        /// </summary>
        /// <param name="req"><see cref="EnableClusterDeletionProtectionRequest"/></param>
        /// <returns><see cref="EnableClusterDeletionProtectionResponse"/></returns>
        public Task<EnableClusterDeletionProtectionResponse> EnableClusterDeletionProtection(EnableClusterDeletionProtectionRequest req)
        {
            return InternalRequestAsync<EnableClusterDeletionProtectionResponse>(req, "EnableClusterDeletionProtection");
        }

        /// <summary>
        /// This API is used to enable cluster deletion protection.
        /// </summary>
        /// <param name="req"><see cref="EnableClusterDeletionProtectionRequest"/></param>
        /// <returns><see cref="EnableClusterDeletionProtectionResponse"/></returns>
        public EnableClusterDeletionProtectionResponse EnableClusterDeletionProtectionSync(EnableClusterDeletionProtectionRequest req)
        {
            return InternalRequestAsync<EnableClusterDeletionProtectionResponse>(req, "EnableClusterDeletionProtection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable Encrypted Data Protection, which requires enabling KMS capability and completing KMS authorization.
        /// </summary>
        /// <param name="req"><see cref="EnableEncryptionProtectionRequest"/></param>
        /// <returns><see cref="EnableEncryptionProtectionResponse"/></returns>
        public Task<EnableEncryptionProtectionResponse> EnableEncryptionProtection(EnableEncryptionProtectionRequest req)
        {
            return InternalRequestAsync<EnableEncryptionProtectionResponse>(req, "EnableEncryptionProtection");
        }

        /// <summary>
        /// This API is used to enable Encrypted Data Protection, which requires enabling KMS capability and completing KMS authorization.
        /// </summary>
        /// <param name="req"><see cref="EnableEncryptionProtectionRequest"/></param>
        /// <returns><see cref="EnableEncryptionProtectionResponse"/></returns>
        public EnableEncryptionProtectionResponse EnableEncryptionProtectionSync(EnableEncryptionProtectionRequest req)
        {
            return InternalRequestAsync<EnableEncryptionProtectionResponse>(req, "EnableEncryptionProtection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable the VPC-CNI network mode for GR clusters.
        /// </summary>
        /// <param name="req"><see cref="EnableVpcCniNetworkTypeRequest"/></param>
        /// <returns><see cref="EnableVpcCniNetworkTypeResponse"/></returns>
        public Task<EnableVpcCniNetworkTypeResponse> EnableVpcCniNetworkType(EnableVpcCniNetworkTypeRequest req)
        {
            return InternalRequestAsync<EnableVpcCniNetworkTypeResponse>(req, "EnableVpcCniNetworkType");
        }

        /// <summary>
        /// This API is used to enable the VPC-CNI network mode for GR clusters.
        /// </summary>
        /// <param name="req"><see cref="EnableVpcCniNetworkTypeRequest"/></param>
        /// <returns><see cref="EnableVpcCniNetworkTypeResponse"/></returns>
        public EnableVpcCniNetworkTypeResponse EnableVpcCniNetworkTypeSync(EnableVpcCniNetworkTypeRequest req)
        {
            return InternalRequestAsync<EnableVpcCniNetworkTypeResponse>(req, "EnableVpcCniNetworkType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to work with the add-ons of a TKE Edge cluster.
        /// </summary>
        /// <param name="req"><see cref="ForwardTKEEdgeApplicationRequestV3Request"/></param>
        /// <returns><see cref="ForwardTKEEdgeApplicationRequestV3Response"/></returns>
        public Task<ForwardTKEEdgeApplicationRequestV3Response> ForwardTKEEdgeApplicationRequestV3(ForwardTKEEdgeApplicationRequestV3Request req)
        {
            return InternalRequestAsync<ForwardTKEEdgeApplicationRequestV3Response>(req, "ForwardTKEEdgeApplicationRequestV3");
        }

        /// <summary>
        /// This API is used to work with the add-ons of a TKE Edge cluster.
        /// </summary>
        /// <param name="req"><see cref="ForwardTKEEdgeApplicationRequestV3Request"/></param>
        /// <returns><see cref="ForwardTKEEdgeApplicationRequestV3Response"/></returns>
        public ForwardTKEEdgeApplicationRequestV3Response ForwardTKEEdgeApplicationRequestV3Sync(ForwardTKEEdgeApplicationRequestV3Request req)
        {
            return InternalRequestAsync<ForwardTKEEdgeApplicationRequestV3Response>(req, "ForwardTKEEdgeApplicationRequestV3")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtaining the price of specified cluster model
        /// </summary>
        /// <param name="req"><see cref="GetClusterLevelPriceRequest"/></param>
        /// <returns><see cref="GetClusterLevelPriceResponse"/></returns>
        public Task<GetClusterLevelPriceResponse> GetClusterLevelPrice(GetClusterLevelPriceRequest req)
        {
            return InternalRequestAsync<GetClusterLevelPriceResponse>(req, "GetClusterLevelPrice");
        }

        /// <summary>
        /// Obtaining the price of specified cluster model
        /// </summary>
        /// <param name="req"><see cref="GetClusterLevelPriceRequest"/></param>
        /// <returns><see cref="GetClusterLevelPriceResponse"/></returns>
        public GetClusterLevelPriceResponse GetClusterLevelPriceSync(GetClusterLevelPriceRequest req)
        {
            return InternalRequestAsync<GetClusterLevelPriceResponse>(req, "GetClusterLevelPrice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the current progress of node upgrade. If the cluster is not in node upgrade status, the API will report an error: Task not found.
        /// </summary>
        /// <param name="req"><see cref="GetUpgradeInstanceProgressRequest"/></param>
        /// <returns><see cref="GetUpgradeInstanceProgressResponse"/></returns>
        public Task<GetUpgradeInstanceProgressResponse> GetUpgradeInstanceProgress(GetUpgradeInstanceProgressRequest req)
        {
            return InternalRequestAsync<GetUpgradeInstanceProgressResponse>(req, "GetUpgradeInstanceProgress");
        }

        /// <summary>
        /// This API is used to obtain the current progress of node upgrade. If the cluster is not in node upgrade status, the API will report an error: Task not found.
        /// </summary>
        /// <param name="req"><see cref="GetUpgradeInstanceProgressRequest"/></param>
        /// <returns><see cref="GetUpgradeInstanceProgressResponse"/></returns>
        public GetUpgradeInstanceProgressResponse GetUpgradeInstanceProgressSync(GetUpgradeInstanceProgressRequest req)
        {
            return InternalRequestAsync<GetUpgradeInstanceProgressResponse>(req, "GetUpgradeInstanceProgress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to install an add-on on the target cluster.
        /// </summary>
        /// <param name="req"><see cref="InstallAddonRequest"/></param>
        /// <returns><see cref="InstallAddonResponse"/></returns>
        public Task<InstallAddonResponse> InstallAddon(InstallAddonRequest req)
        {
            return InternalRequestAsync<InstallAddonResponse>(req, "InstallAddon");
        }

        /// <summary>
        /// This API is used to install an add-on on the target cluster.
        /// </summary>
        /// <param name="req"><see cref="InstallAddonRequest"/></param>
        /// <returns><see cref="InstallAddonResponse"/></returns>
        public InstallAddonResponse InstallAddonSync(InstallAddonRequest req)
        {
            return InternalRequestAsync<InstallAddonResponse>(req, "InstallAddon")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to install the log collection add-on on TKE Edge cluster nodes.
        /// </summary>
        /// <param name="req"><see cref="InstallEdgeLogAgentRequest"/></param>
        /// <returns><see cref="InstallEdgeLogAgentResponse"/></returns>
        public Task<InstallEdgeLogAgentResponse> InstallEdgeLogAgent(InstallEdgeLogAgentRequest req)
        {
            return InternalRequestAsync<InstallEdgeLogAgentResponse>(req, "InstallEdgeLogAgent");
        }

        /// <summary>
        /// This API is used to install the log collection add-on on TKE Edge cluster nodes.
        /// </summary>
        /// <param name="req"><see cref="InstallEdgeLogAgentRequest"/></param>
        /// <returns><see cref="InstallEdgeLogAgentResponse"/></returns>
        public InstallEdgeLogAgentResponse InstallEdgeLogAgentSync(InstallEdgeLogAgentRequest req)
        {
            return InternalRequestAsync<InstallEdgeLogAgentResponse>(req, "InstallEdgeLogAgent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify cluster scaling group attributes
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterAsGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyClusterAsGroupAttributeResponse"/></returns>
        public Task<ModifyClusterAsGroupAttributeResponse> ModifyClusterAsGroupAttribute(ModifyClusterAsGroupAttributeRequest req)
        {
            return InternalRequestAsync<ModifyClusterAsGroupAttributeResponse>(req, "ModifyClusterAsGroupAttribute");
        }

        /// <summary>
        /// Modify cluster scaling group attributes
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterAsGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyClusterAsGroupAttributeResponse"/></returns>
        public ModifyClusterAsGroupAttributeResponse ModifyClusterAsGroupAttributeSync(ModifyClusterAsGroupAttributeRequest req)
        {
            return InternalRequestAsync<ModifyClusterAsGroupAttributeResponse>(req, "ModifyClusterAsGroupAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify cluster auto scaling attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterAsGroupOptionAttributeRequest"/></param>
        /// <returns><see cref="ModifyClusterAsGroupOptionAttributeResponse"/></returns>
        public Task<ModifyClusterAsGroupOptionAttributeResponse> ModifyClusterAsGroupOptionAttribute(ModifyClusterAsGroupOptionAttributeRequest req)
        {
            return InternalRequestAsync<ModifyClusterAsGroupOptionAttributeResponse>(req, "ModifyClusterAsGroupOptionAttribute");
        }

        /// <summary>
        /// This API is used to modify cluster auto scaling attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterAsGroupOptionAttributeRequest"/></param>
        /// <returns><see cref="ModifyClusterAsGroupOptionAttributeResponse"/></returns>
        public ModifyClusterAsGroupOptionAttributeResponse ModifyClusterAsGroupOptionAttributeSync(ModifyClusterAsGroupOptionAttributeRequest req)
        {
            return InternalRequestAsync<ModifyClusterAsGroupOptionAttributeResponse>(req, "ModifyClusterAsGroupOptionAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify cluster attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterAttributeRequest"/></param>
        /// <returns><see cref="ModifyClusterAttributeResponse"/></returns>
        public Task<ModifyClusterAttributeResponse> ModifyClusterAttribute(ModifyClusterAttributeRequest req)
        {
            return InternalRequestAsync<ModifyClusterAttributeResponse>(req, "ModifyClusterAttribute");
        }

        /// <summary>
        /// This API is used to modify cluster attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterAttributeRequest"/></param>
        /// <returns><see cref="ModifyClusterAttributeResponse"/></returns>
        public ModifyClusterAttributeResponse ModifyClusterAttributeSync(ModifyClusterAttributeRequest req)
        {
            return InternalRequestAsync<ModifyClusterAttributeResponse>(req, "ModifyClusterAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify cluster authentication configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterAuthenticationOptionsRequest"/></param>
        /// <returns><see cref="ModifyClusterAuthenticationOptionsResponse"/></returns>
        public Task<ModifyClusterAuthenticationOptionsResponse> ModifyClusterAuthenticationOptions(ModifyClusterAuthenticationOptionsRequest req)
        {
            return InternalRequestAsync<ModifyClusterAuthenticationOptionsResponse>(req, "ModifyClusterAuthenticationOptions");
        }

        /// <summary>
        /// This API is used to modify cluster authentication configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterAuthenticationOptionsRequest"/></param>
        /// <returns><see cref="ModifyClusterAuthenticationOptionsResponse"/></returns>
        public ModifyClusterAuthenticationOptionsResponse ModifyClusterAuthenticationOptionsSync(ModifyClusterAuthenticationOptionsRequest req)
        {
            return InternalRequestAsync<ModifyClusterAuthenticationOptionsResponse>(req, "ModifyClusterAuthenticationOptions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify the security policy of the external port of the managed cluster (the old way, only the external port of the managed cluster is supported)
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterEndpointSPRequest"/></param>
        /// <returns><see cref="ModifyClusterEndpointSPResponse"/></returns>
        public Task<ModifyClusterEndpointSPResponse> ModifyClusterEndpointSP(ModifyClusterEndpointSPRequest req)
        {
            return InternalRequestAsync<ModifyClusterEndpointSPResponse>(req, "ModifyClusterEndpointSP");
        }

        /// <summary>
        /// Modify the security policy of the external port of the managed cluster (the old way, only the external port of the managed cluster is supported)
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterEndpointSPRequest"/></param>
        /// <returns><see cref="ModifyClusterEndpointSPResponse"/></returns>
        public ModifyClusterEndpointSPResponse ModifyClusterEndpointSPSync(ModifyClusterEndpointSPRequest req)
        {
            return InternalRequestAsync<ModifyClusterEndpointSPResponse>(req, "ModifyClusterEndpointSP")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the cluster image.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterImageRequest"/></param>
        /// <returns><see cref="ModifyClusterImageResponse"/></returns>
        public Task<ModifyClusterImageResponse> ModifyClusterImage(ModifyClusterImageRequest req)
        {
            return InternalRequestAsync<ModifyClusterImageResponse>(req, "ModifyClusterImage");
        }

        /// <summary>
        /// This API is used to modify the cluster image.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterImageRequest"/></param>
        /// <returns><see cref="ModifyClusterImageResponse"/></returns>
        public ModifyClusterImageResponse ModifyClusterImageSync(ModifyClusterImageRequest req)
        {
            return InternalRequestAsync<ModifyClusterImageResponse>(req, "ModifyClusterImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to edit a node pool.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterNodePoolRequest"/></param>
        /// <returns><see cref="ModifyClusterNodePoolResponse"/></returns>
        public Task<ModifyClusterNodePoolResponse> ModifyClusterNodePool(ModifyClusterNodePoolRequest req)
        {
            return InternalRequestAsync<ModifyClusterNodePoolResponse>(req, "ModifyClusterNodePool");
        }

        /// <summary>
        /// This API is used to edit a node pool.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterNodePoolRequest"/></param>
        /// <returns><see cref="ModifyClusterNodePoolResponse"/></returns>
        public ModifyClusterNodePoolResponse ModifyClusterNodePoolSync(ModifyClusterNodePoolRequest req)
        {
            return InternalRequestAsync<ModifyClusterNodePoolResponse>(req, "ModifyClusterNodePool")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the latitude runtime configuration of clusters and node pools.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterRuntimeConfigRequest"/></param>
        /// <returns><see cref="ModifyClusterRuntimeConfigResponse"/></returns>
        public Task<ModifyClusterRuntimeConfigResponse> ModifyClusterRuntimeConfig(ModifyClusterRuntimeConfigRequest req)
        {
            return InternalRequestAsync<ModifyClusterRuntimeConfigResponse>(req, "ModifyClusterRuntimeConfig");
        }

        /// <summary>
        /// This API is used to modify the latitude runtime configuration of clusters and node pools.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterRuntimeConfigRequest"/></param>
        /// <returns><see cref="ModifyClusterRuntimeConfigResponse"/></returns>
        public ModifyClusterRuntimeConfigResponse ModifyClusterRuntimeConfigSync(ModifyClusterRuntimeConfigRequest req)
        {
            return InternalRequestAsync<ModifyClusterRuntimeConfigResponse>(req, "ModifyClusterRuntimeConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify cluster tags.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterTagsRequest"/></param>
        /// <returns><see cref="ModifyClusterTagsResponse"/></returns>
        public Task<ModifyClusterTagsResponse> ModifyClusterTags(ModifyClusterTagsRequest req)
        {
            return InternalRequestAsync<ModifyClusterTagsResponse>(req, "ModifyClusterTags");
        }

        /// <summary>
        /// This API is used to modify cluster tags.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterTagsRequest"/></param>
        /// <returns><see cref="ModifyClusterTagsResponse"/></returns>
        public ModifyClusterTagsResponse ModifyClusterTagsSync(ModifyClusterTagsRequest req)
        {
            return InternalRequestAsync<ModifyClusterTagsResponse>(req, "ModifyClusterTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the Super Node Pool.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterVirtualNodePoolRequest"/></param>
        /// <returns><see cref="ModifyClusterVirtualNodePoolResponse"/></returns>
        public Task<ModifyClusterVirtualNodePoolResponse> ModifyClusterVirtualNodePool(ModifyClusterVirtualNodePoolRequest req)
        {
            return InternalRequestAsync<ModifyClusterVirtualNodePoolResponse>(req, "ModifyClusterVirtualNodePool");
        }

        /// <summary>
        /// This API is used to modify the Super Node Pool.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterVirtualNodePoolRequest"/></param>
        /// <returns><see cref="ModifyClusterVirtualNodePoolResponse"/></returns>
        public ModifyClusterVirtualNodePoolResponse ModifyClusterVirtualNodePoolSync(ModifyClusterVirtualNodePoolRequest req)
        {
            return InternalRequestAsync<ModifyClusterVirtualNodePoolResponse>(req, "ModifyClusterVirtualNodePool")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the model of instances in a node pool.
        /// </summary>
        /// <param name="req"><see cref="ModifyNodePoolInstanceTypesRequest"/></param>
        /// <returns><see cref="ModifyNodePoolInstanceTypesResponse"/></returns>
        public Task<ModifyNodePoolInstanceTypesResponse> ModifyNodePoolInstanceTypes(ModifyNodePoolInstanceTypesRequest req)
        {
            return InternalRequestAsync<ModifyNodePoolInstanceTypesResponse>(req, "ModifyNodePoolInstanceTypes");
        }

        /// <summary>
        /// This API is used to modify the model of instances in a node pool.
        /// </summary>
        /// <param name="req"><see cref="ModifyNodePoolInstanceTypesRequest"/></param>
        /// <returns><see cref="ModifyNodePoolInstanceTypesResponse"/></returns>
        public ModifyNodePoolInstanceTypesResponse ModifyNodePoolInstanceTypesSync(ModifyNodePoolInstanceTypesRequest req)
        {
            return InternalRequestAsync<ModifyNodePoolInstanceTypesResponse>(req, "ModifyNodePoolInstanceTypes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify an alert rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusAlertRuleRequest"/></param>
        /// <returns><see cref="ModifyPrometheusAlertRuleResponse"/></returns>
        public Task<ModifyPrometheusAlertRuleResponse> ModifyPrometheusAlertRule(ModifyPrometheusAlertRuleRequest req)
        {
            return InternalRequestAsync<ModifyPrometheusAlertRuleResponse>(req, "ModifyPrometheusAlertRule");
        }

        /// <summary>
        /// This API is used to modify an alert rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusAlertRuleRequest"/></param>
        /// <returns><see cref="ModifyPrometheusAlertRuleResponse"/></returns>
        public ModifyPrometheusAlertRuleResponse ModifyPrometheusAlertRuleSync(ModifyPrometheusAlertRuleRequest req)
        {
            return InternalRequestAsync<ModifyPrometheusAlertRuleResponse>(req, "ModifyPrometheusAlertRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to remove a node from a node pool but retain it in the cluster.
        /// </summary>
        /// <param name="req"><see cref="RemoveNodeFromNodePoolRequest"/></param>
        /// <returns><see cref="RemoveNodeFromNodePoolResponse"/></returns>
        public Task<RemoveNodeFromNodePoolResponse> RemoveNodeFromNodePool(RemoveNodeFromNodePoolRequest req)
        {
            return InternalRequestAsync<RemoveNodeFromNodePoolResponse>(req, "RemoveNodeFromNodePool");
        }

        /// <summary>
        /// This API is used to remove a node from a node pool but retain it in the cluster.
        /// </summary>
        /// <param name="req"><see cref="RemoveNodeFromNodePoolRequest"/></param>
        /// <returns><see cref="RemoveNodeFromNodePoolResponse"/></returns>
        public RemoveNodeFromNodePoolResponse RemoveNodeFromNodePoolSync(RemoveNodeFromNodePoolRequest req)
        {
            return InternalRequestAsync<RemoveNodeFromNodePoolResponse>(req, "RemoveNodeFromNodePool")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable removal protection for the nodes automatically created by the scaling group in a node pool.
        /// </summary>
        /// <param name="req"><see cref="SetNodePoolNodeProtectionRequest"/></param>
        /// <returns><see cref="SetNodePoolNodeProtectionResponse"/></returns>
        public Task<SetNodePoolNodeProtectionResponse> SetNodePoolNodeProtection(SetNodePoolNodeProtectionRequest req)
        {
            return InternalRequestAsync<SetNodePoolNodeProtectionResponse>(req, "SetNodePoolNodeProtection");
        }

        /// <summary>
        /// This API is used to enable removal protection for the nodes automatically created by the scaling group in a node pool.
        /// </summary>
        /// <param name="req"><see cref="SetNodePoolNodeProtectionRequest"/></param>
        /// <returns><see cref="SetNodePoolNodeProtectionResponse"/></returns>
        public SetNodePoolNodeProtectionResponse SetNodePoolNodeProtectionSync(SetNodePoolNodeProtectionRequest req)
        {
            return InternalRequestAsync<SetNodePoolNodeProtectionResponse>(req, "SetNodePoolNodeProtection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to uninstall the log collection add-on from TKE Edge cluster nodes.
        /// </summary>
        /// <param name="req"><see cref="UninstallEdgeLogAgentRequest"/></param>
        /// <returns><see cref="UninstallEdgeLogAgentResponse"/></returns>
        public Task<UninstallEdgeLogAgentResponse> UninstallEdgeLogAgent(UninstallEdgeLogAgentRequest req)
        {
            return InternalRequestAsync<UninstallEdgeLogAgentResponse>(req, "UninstallEdgeLogAgent");
        }

        /// <summary>
        /// This API is used to uninstall the log collection add-on from TKE Edge cluster nodes.
        /// </summary>
        /// <param name="req"><see cref="UninstallEdgeLogAgentRequest"/></param>
        /// <returns><see cref="UninstallEdgeLogAgentResponse"/></returns>
        public UninstallEdgeLogAgentResponse UninstallEdgeLogAgentSync(UninstallEdgeLogAgentRequest req)
        {
            return InternalRequestAsync<UninstallEdgeLogAgentResponse>(req, "UninstallEdgeLogAgent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update parameters and version of an add-on.
        /// </summary>
        /// <param name="req"><see cref="UpdateAddonRequest"/></param>
        /// <returns><see cref="UpdateAddonResponse"/></returns>
        public Task<UpdateAddonResponse> UpdateAddon(UpdateAddonRequest req)
        {
            return InternalRequestAsync<UpdateAddonResponse>(req, "UpdateAddon");
        }

        /// <summary>
        /// This API is used to update parameters and version of an add-on.
        /// </summary>
        /// <param name="req"><see cref="UpdateAddonRequest"/></param>
        /// <returns><see cref="UpdateAddonResponse"/></returns>
        public UpdateAddonResponse UpdateAddonSync(UpdateAddonRequest req)
        {
            return InternalRequestAsync<UpdateAddonResponse>(req, "UpdateAddon")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the Kubeconfig information of a cluster.
        /// </summary>
        /// <param name="req"><see cref="UpdateClusterKubeconfigRequest"/></param>
        /// <returns><see cref="UpdateClusterKubeconfigResponse"/></returns>
        public Task<UpdateClusterKubeconfigResponse> UpdateClusterKubeconfig(UpdateClusterKubeconfigRequest req)
        {
            return InternalRequestAsync<UpdateClusterKubeconfigResponse>(req, "UpdateClusterKubeconfig");
        }

        /// <summary>
        /// This API is used to update the Kubeconfig information of a cluster.
        /// </summary>
        /// <param name="req"><see cref="UpdateClusterKubeconfigRequest"/></param>
        /// <returns><see cref="UpdateClusterKubeconfigResponse"/></returns>
        public UpdateClusterKubeconfigResponse UpdateClusterKubeconfigSync(UpdateClusterKubeconfigRequest req)
        {
            return InternalRequestAsync<UpdateClusterKubeconfigResponse>(req, "UpdateClusterKubeconfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to upgrade the master component of the cluster to the specified version.
        /// </summary>
        /// <param name="req"><see cref="UpdateClusterVersionRequest"/></param>
        /// <returns><see cref="UpdateClusterVersionResponse"/></returns>
        public Task<UpdateClusterVersionResponse> UpdateClusterVersion(UpdateClusterVersionRequest req)
        {
            return InternalRequestAsync<UpdateClusterVersionResponse>(req, "UpdateClusterVersion");
        }

        /// <summary>
        /// This API is used to upgrade the master component of the cluster to the specified version.
        /// </summary>
        /// <param name="req"><see cref="UpdateClusterVersionRequest"/></param>
        /// <returns><see cref="UpdateClusterVersionResponse"/></returns>
        public UpdateClusterVersionResponse UpdateClusterVersionSync(UpdateClusterVersionRequest req)
        {
            return InternalRequestAsync<UpdateClusterVersionResponse>(req, "UpdateClusterVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to upgrade an edge cluster component to a TKE Edge version.
        /// </summary>
        /// <param name="req"><see cref="UpdateEdgeClusterVersionRequest"/></param>
        /// <returns><see cref="UpdateEdgeClusterVersionResponse"/></returns>
        public Task<UpdateEdgeClusterVersionResponse> UpdateEdgeClusterVersion(UpdateEdgeClusterVersionRequest req)
        {
            return InternalRequestAsync<UpdateEdgeClusterVersionResponse>(req, "UpdateEdgeClusterVersion");
        }

        /// <summary>
        /// This API is used to upgrade an edge cluster component to a TKE Edge version.
        /// </summary>
        /// <param name="req"><see cref="UpdateEdgeClusterVersionRequest"/></param>
        /// <returns><see cref="UpdateEdgeClusterVersionResponse"/></returns>
        public UpdateEdgeClusterVersionResponse UpdateEdgeClusterVersionSync(UpdateEdgeClusterVersionRequest req)
        {
            return InternalRequestAsync<UpdateEdgeClusterVersionResponse>(req, "UpdateEdgeClusterVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to upgrade work nodes in a cluster.
        /// </summary>
        /// <param name="req"><see cref="UpgradeClusterInstancesRequest"/></param>
        /// <returns><see cref="UpgradeClusterInstancesResponse"/></returns>
        public Task<UpgradeClusterInstancesResponse> UpgradeClusterInstances(UpgradeClusterInstancesRequest req)
        {
            return InternalRequestAsync<UpgradeClusterInstancesResponse>(req, "UpgradeClusterInstances");
        }

        /// <summary>
        /// This API is used to upgrade work nodes in a cluster.
        /// </summary>
        /// <param name="req"><see cref="UpgradeClusterInstancesRequest"/></param>
        /// <returns><see cref="UpgradeClusterInstancesResponse"/></returns>
        public UpgradeClusterInstancesResponse UpgradeClusterInstancesSync(UpgradeClusterInstancesRequest req)
        {
            return InternalRequestAsync<UpgradeClusterInstancesResponse>(req, "UpgradeClusterInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
