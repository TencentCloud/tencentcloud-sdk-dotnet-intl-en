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

       private const string endpoint = "tke.tencentcloudapi.com";
       private const string version = "2018-05-25";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TkeClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// This API can be called to acquire the ClusterRole tke:admin. By setting a CAM policy, you can grant permission of this API to a sub-account that has higher permission in CAM. In this way, this sub-account can call this API directly to acquire the admin role of a Kubernetes cluster.
        /// </summary>
        /// <param name="req"><see cref="AcquireClusterAdminRoleRequest"/></param>
        /// <returns><see cref="AcquireClusterAdminRoleResponse"/></returns>
        public async Task<AcquireClusterAdminRoleResponse> AcquireClusterAdminRole(AcquireClusterAdminRoleRequest req)
        {
             JsonResponseModel<AcquireClusterAdminRoleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AcquireClusterAdminRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AcquireClusterAdminRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API can be called to acquire the ClusterRole tke:admin. By setting a CAM policy, you can grant permission of this API to a sub-account that has higher permission in CAM. In this way, this sub-account can call this API directly to acquire the admin role of a Kubernetes cluster.
        /// </summary>
        /// <param name="req"><see cref="AcquireClusterAdminRoleRequest"/></param>
        /// <returns><see cref="AcquireClusterAdminRoleResponse"/></returns>
        public AcquireClusterAdminRoleResponse AcquireClusterAdminRoleSync(AcquireClusterAdminRoleRequest req)
        {
             JsonResponseModel<AcquireClusterAdminRoleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AcquireClusterAdminRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AcquireClusterAdminRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add one or more existing instances to a cluster.
        /// </summary>
        /// <param name="req"><see cref="AddExistedInstancesRequest"/></param>
        /// <returns><see cref="AddExistedInstancesResponse"/></returns>
        public async Task<AddExistedInstancesResponse> AddExistedInstances(AddExistedInstancesRequest req)
        {
             JsonResponseModel<AddExistedInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddExistedInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddExistedInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add one or more existing instances to a cluster.
        /// </summary>
        /// <param name="req"><see cref="AddExistedInstancesRequest"/></param>
        /// <returns><see cref="AddExistedInstancesResponse"/></returns>
        public AddExistedInstancesResponse AddExistedInstancesSync(AddExistedInstancesRequest req)
        {
             JsonResponseModel<AddExistedInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddExistedInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddExistedInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to move nodes in a cluster to a node pool.
        /// </summary>
        /// <param name="req"><see cref="AddNodeToNodePoolRequest"/></param>
        /// <returns><see cref="AddNodeToNodePoolResponse"/></returns>
        public async Task<AddNodeToNodePoolResponse> AddNodeToNodePool(AddNodeToNodePoolRequest req)
        {
             JsonResponseModel<AddNodeToNodePoolResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddNodeToNodePool");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddNodeToNodePoolResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to move nodes in a cluster to a node pool.
        /// </summary>
        /// <param name="req"><see cref="AddNodeToNodePoolRequest"/></param>
        /// <returns><see cref="AddNodeToNodePoolResponse"/></returns>
        public AddNodeToNodePoolResponse AddNodeToNodePoolSync(AddNodeToNodePoolRequest req)
        {
             JsonResponseModel<AddNodeToNodePoolResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddNodeToNodePool");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddNodeToNodePoolResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add subnets in the container network for a VPC-CNI cluster.
        /// </summary>
        /// <param name="req"><see cref="AddVpcCniSubnetsRequest"/></param>
        /// <returns><see cref="AddVpcCniSubnetsResponse"/></returns>
        public async Task<AddVpcCniSubnetsResponse> AddVpcCniSubnets(AddVpcCniSubnetsRequest req)
        {
             JsonResponseModel<AddVpcCniSubnetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddVpcCniSubnets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddVpcCniSubnetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add subnets in the container network for a VPC-CNI cluster.
        /// </summary>
        /// <param name="req"><see cref="AddVpcCniSubnetsRequest"/></param>
        /// <returns><see cref="AddVpcCniSubnetsResponse"/></returns>
        public AddVpcCniSubnetsResponse AddVpcCniSubnetsSync(AddVpcCniSubnetsRequest req)
        {
             JsonResponseModel<AddVpcCniSubnetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddVpcCniSubnets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddVpcCniSubnetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to check which nodes can be upgraded in the given node list. 
        /// </summary>
        /// <param name="req"><see cref="CheckInstancesUpgradeAbleRequest"/></param>
        /// <returns><see cref="CheckInstancesUpgradeAbleResponse"/></returns>
        public async Task<CheckInstancesUpgradeAbleResponse> CheckInstancesUpgradeAble(CheckInstancesUpgradeAbleRequest req)
        {
             JsonResponseModel<CheckInstancesUpgradeAbleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckInstancesUpgradeAble");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckInstancesUpgradeAbleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to check which nodes can be upgraded in the given node list. 
        /// </summary>
        /// <param name="req"><see cref="CheckInstancesUpgradeAbleRequest"/></param>
        /// <returns><see cref="CheckInstancesUpgradeAbleResponse"/></returns>
        public CheckInstancesUpgradeAbleResponse CheckInstancesUpgradeAbleSync(CheckInstancesUpgradeAbleRequest req)
        {
             JsonResponseModel<CheckInstancesUpgradeAbleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckInstancesUpgradeAble");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckInstancesUpgradeAbleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a cluster.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRequest"/></param>
        /// <returns><see cref="CreateClusterResponse"/></returns>
        public async Task<CreateClusterResponse> CreateCluster(CreateClusterRequest req)
        {
             JsonResponseModel<CreateClusterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a cluster.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRequest"/></param>
        /// <returns><see cref="CreateClusterResponse"/></returns>
        public CreateClusterResponse CreateClusterSync(CreateClusterRequest req)
        {
             JsonResponseModel<CreateClusterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Create a scaling group for an existing cluster
        /// </summary>
        /// <param name="req"><see cref="CreateClusterAsGroupRequest"/></param>
        /// <returns><see cref="CreateClusterAsGroupResponse"/></returns>
        public async Task<CreateClusterAsGroupResponse> CreateClusterAsGroup(CreateClusterAsGroupRequest req)
        {
             JsonResponseModel<CreateClusterAsGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateClusterAsGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterAsGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Create a scaling group for an existing cluster
        /// </summary>
        /// <param name="req"><see cref="CreateClusterAsGroupRequest"/></param>
        /// <returns><see cref="CreateClusterAsGroupResponse"/></returns>
        public CreateClusterAsGroupResponse CreateClusterAsGroupSync(CreateClusterAsGroupRequest req)
        {
             JsonResponseModel<CreateClusterAsGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateClusterAsGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterAsGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Create a cluster access port (intranet / extranet access is enabled for independent clusters, and intranet access is supported for managed clusters)
        /// </summary>
        /// <param name="req"><see cref="CreateClusterEndpointRequest"/></param>
        /// <returns><see cref="CreateClusterEndpointResponse"/></returns>
        public async Task<CreateClusterEndpointResponse> CreateClusterEndpoint(CreateClusterEndpointRequest req)
        {
             JsonResponseModel<CreateClusterEndpointResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateClusterEndpoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterEndpointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Create a cluster access port (intranet / extranet access is enabled for independent clusters, and intranet access is supported for managed clusters)
        /// </summary>
        /// <param name="req"><see cref="CreateClusterEndpointRequest"/></param>
        /// <returns><see cref="CreateClusterEndpointResponse"/></returns>
        public CreateClusterEndpointResponse CreateClusterEndpointSync(CreateClusterEndpointRequest req)
        {
             JsonResponseModel<CreateClusterEndpointResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateClusterEndpoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterEndpointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Create an external network access port for the managed cluster (the old way, only the external network port for the managed cluster is supported)
        /// </summary>
        /// <param name="req"><see cref="CreateClusterEndpointVipRequest"/></param>
        /// <returns><see cref="CreateClusterEndpointVipResponse"/></returns>
        public async Task<CreateClusterEndpointVipResponse> CreateClusterEndpointVip(CreateClusterEndpointVipRequest req)
        {
             JsonResponseModel<CreateClusterEndpointVipResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateClusterEndpointVip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterEndpointVipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Create an external network access port for the managed cluster (the old way, only the external network port for the managed cluster is supported)
        /// </summary>
        /// <param name="req"><see cref="CreateClusterEndpointVipRequest"/></param>
        /// <returns><see cref="CreateClusterEndpointVipResponse"/></returns>
        public CreateClusterEndpointVipResponse CreateClusterEndpointVipSync(CreateClusterEndpointVipRequest req)
        {
             JsonResponseModel<CreateClusterEndpointVipResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateClusterEndpointVip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterEndpointVipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create one or more nodes in a cluster.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterInstancesRequest"/></param>
        /// <returns><see cref="CreateClusterInstancesResponse"/></returns>
        public async Task<CreateClusterInstancesResponse> CreateClusterInstances(CreateClusterInstancesRequest req)
        {
             JsonResponseModel<CreateClusterInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateClusterInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create one or more nodes in a cluster.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterInstancesRequest"/></param>
        /// <returns><see cref="CreateClusterInstancesResponse"/></returns>
        public CreateClusterInstancesResponse CreateClusterInstancesSync(CreateClusterInstancesRequest req)
        {
             JsonResponseModel<CreateClusterInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateClusterInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a node pool.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterNodePoolRequest"/></param>
        /// <returns><see cref="CreateClusterNodePoolResponse"/></returns>
        public async Task<CreateClusterNodePoolResponse> CreateClusterNodePool(CreateClusterNodePoolRequest req)
        {
             JsonResponseModel<CreateClusterNodePoolResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateClusterNodePool");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterNodePoolResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a node pool.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterNodePoolRequest"/></param>
        /// <returns><see cref="CreateClusterNodePoolResponse"/></returns>
        public CreateClusterNodePoolResponse CreateClusterNodePoolSync(CreateClusterNodePoolRequest req)
        {
             JsonResponseModel<CreateClusterNodePoolResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateClusterNodePool");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterNodePoolResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upgrade a scaling group to a node pool.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterNodePoolFromExistingAsgRequest"/></param>
        /// <returns><see cref="CreateClusterNodePoolFromExistingAsgResponse"/></returns>
        public async Task<CreateClusterNodePoolFromExistingAsgResponse> CreateClusterNodePoolFromExistingAsg(CreateClusterNodePoolFromExistingAsgRequest req)
        {
             JsonResponseModel<CreateClusterNodePoolFromExistingAsgResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateClusterNodePoolFromExistingAsg");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterNodePoolFromExistingAsgResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upgrade a scaling group to a node pool.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterNodePoolFromExistingAsgRequest"/></param>
        /// <returns><see cref="CreateClusterNodePoolFromExistingAsgResponse"/></returns>
        public CreateClusterNodePoolFromExistingAsgResponse CreateClusterNodePoolFromExistingAsgSync(CreateClusterNodePoolFromExistingAsgRequest req)
        {
             JsonResponseModel<CreateClusterNodePoolFromExistingAsgResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateClusterNodePoolFromExistingAsg");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterNodePoolFromExistingAsgResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a cluster route table.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRouteTableRequest"/></param>
        /// <returns><see cref="CreateClusterRouteTableResponse"/></returns>
        public async Task<CreateClusterRouteTableResponse> CreateClusterRouteTable(CreateClusterRouteTableRequest req)
        {
             JsonResponseModel<CreateClusterRouteTableResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateClusterRouteTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterRouteTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a cluster route table.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRouteTableRequest"/></param>
        /// <returns><see cref="CreateClusterRouteTableResponse"/></returns>
        public CreateClusterRouteTableResponse CreateClusterRouteTableSync(CreateClusterRouteTableRequest req)
        {
             JsonResponseModel<CreateClusterRouteTableResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateClusterRouteTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterRouteTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a cluster. (Cloud API v3).
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRequest"/></param>
        /// <returns><see cref="DeleteClusterResponse"/></returns>
        public async Task<DeleteClusterResponse> DeleteCluster(DeleteClusterRequest req)
        {
             JsonResponseModel<DeleteClusterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a cluster. (Cloud API v3).
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRequest"/></param>
        /// <returns><see cref="DeleteClusterResponse"/></returns>
        public DeleteClusterResponse DeleteClusterSync(DeleteClusterRequest req)
        {
             JsonResponseModel<DeleteClusterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Delete a cluster scaling group
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterAsGroupsRequest"/></param>
        /// <returns><see cref="DeleteClusterAsGroupsResponse"/></returns>
        public async Task<DeleteClusterAsGroupsResponse> DeleteClusterAsGroups(DeleteClusterAsGroupsRequest req)
        {
             JsonResponseModel<DeleteClusterAsGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteClusterAsGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterAsGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Delete a cluster scaling group
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterAsGroupsRequest"/></param>
        /// <returns><see cref="DeleteClusterAsGroupsResponse"/></returns>
        public DeleteClusterAsGroupsResponse DeleteClusterAsGroupsSync(DeleteClusterAsGroupsRequest req)
        {
             JsonResponseModel<DeleteClusterAsGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteClusterAsGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterAsGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Delete the cluster access port (intranet / extranet access is enabled for independent clusters, and intranet access is supported for managed clusters)
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterEndpointRequest"/></param>
        /// <returns><see cref="DeleteClusterEndpointResponse"/></returns>
        public async Task<DeleteClusterEndpointResponse> DeleteClusterEndpoint(DeleteClusterEndpointRequest req)
        {
             JsonResponseModel<DeleteClusterEndpointResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteClusterEndpoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterEndpointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Delete the cluster access port (intranet / extranet access is enabled for independent clusters, and intranet access is supported for managed clusters)
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterEndpointRequest"/></param>
        /// <returns><see cref="DeleteClusterEndpointResponse"/></returns>
        public DeleteClusterEndpointResponse DeleteClusterEndpointSync(DeleteClusterEndpointRequest req)
        {
             JsonResponseModel<DeleteClusterEndpointResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteClusterEndpoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterEndpointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Delete the external network access port of the managed cluster (the old way, only the external network port of the managed cluster is supported)
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterEndpointVipRequest"/></param>
        /// <returns><see cref="DeleteClusterEndpointVipResponse"/></returns>
        public async Task<DeleteClusterEndpointVipResponse> DeleteClusterEndpointVip(DeleteClusterEndpointVipRequest req)
        {
             JsonResponseModel<DeleteClusterEndpointVipResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteClusterEndpointVip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterEndpointVipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Delete the external network access port of the managed cluster (the old way, only the external network port of the managed cluster is supported)
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterEndpointVipRequest"/></param>
        /// <returns><see cref="DeleteClusterEndpointVipResponse"/></returns>
        public DeleteClusterEndpointVipResponse DeleteClusterEndpointVipSync(DeleteClusterEndpointVipRequest req)
        {
             JsonResponseModel<DeleteClusterEndpointVipResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteClusterEndpointVip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterEndpointVipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete one or more nodes from a cluster.
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterInstancesRequest"/></param>
        /// <returns><see cref="DeleteClusterInstancesResponse"/></returns>
        public async Task<DeleteClusterInstancesResponse> DeleteClusterInstances(DeleteClusterInstancesRequest req)
        {
             JsonResponseModel<DeleteClusterInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteClusterInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete one or more nodes from a cluster.
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterInstancesRequest"/></param>
        /// <returns><see cref="DeleteClusterInstancesResponse"/></returns>
        public DeleteClusterInstancesResponse DeleteClusterInstancesSync(DeleteClusterInstancesRequest req)
        {
             JsonResponseModel<DeleteClusterInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteClusterInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a node pool.
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterNodePoolRequest"/></param>
        /// <returns><see cref="DeleteClusterNodePoolResponse"/></returns>
        public async Task<DeleteClusterNodePoolResponse> DeleteClusterNodePool(DeleteClusterNodePoolRequest req)
        {
             JsonResponseModel<DeleteClusterNodePoolResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteClusterNodePool");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterNodePoolResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a node pool.
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterNodePoolRequest"/></param>
        /// <returns><see cref="DeleteClusterNodePoolResponse"/></returns>
        public DeleteClusterNodePoolResponse DeleteClusterNodePoolSync(DeleteClusterNodePoolRequest req)
        {
             JsonResponseModel<DeleteClusterNodePoolResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteClusterNodePool");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterNodePoolResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a cluster route.
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRouteRequest"/></param>
        /// <returns><see cref="DeleteClusterRouteResponse"/></returns>
        public async Task<DeleteClusterRouteResponse> DeleteClusterRoute(DeleteClusterRouteRequest req)
        {
             JsonResponseModel<DeleteClusterRouteResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteClusterRoute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterRouteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a cluster route.
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRouteRequest"/></param>
        /// <returns><see cref="DeleteClusterRouteResponse"/></returns>
        public DeleteClusterRouteResponse DeleteClusterRouteSync(DeleteClusterRouteRequest req)
        {
             JsonResponseModel<DeleteClusterRouteResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteClusterRoute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterRouteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete cluster a route table.
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRouteTableRequest"/></param>
        /// <returns><see cref="DeleteClusterRouteTableResponse"/></returns>
        public async Task<DeleteClusterRouteTableResponse> DeleteClusterRouteTable(DeleteClusterRouteTableRequest req)
        {
             JsonResponseModel<DeleteClusterRouteTableResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteClusterRouteTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterRouteTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete cluster a route table.
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRouteTableRequest"/></param>
        /// <returns><see cref="DeleteClusterRouteTableResponse"/></returns>
        public DeleteClusterRouteTableResponse DeleteClusterRouteTableSync(DeleteClusterRouteTableRequest req)
        {
             JsonResponseModel<DeleteClusterRouteTableResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteClusterRouteTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterRouteTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain all versions that the cluster can upgrade to.
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableClusterVersionRequest"/></param>
        /// <returns><see cref="DescribeAvailableClusterVersionResponse"/></returns>
        public async Task<DescribeAvailableClusterVersionResponse> DescribeAvailableClusterVersion(DescribeAvailableClusterVersionRequest req)
        {
             JsonResponseModel<DescribeAvailableClusterVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAvailableClusterVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAvailableClusterVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain all versions that the cluster can upgrade to.
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableClusterVersionRequest"/></param>
        /// <returns><see cref="DescribeAvailableClusterVersionResponse"/></returns>
        public DescribeAvailableClusterVersionResponse DescribeAvailableClusterVersionSync(DescribeAvailableClusterVersionRequest req)
        {
             JsonResponseModel<DescribeAvailableClusterVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAvailableClusterVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAvailableClusterVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Cluster auto scaling configuration
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterAsGroupOptionRequest"/></param>
        /// <returns><see cref="DescribeClusterAsGroupOptionResponse"/></returns>
        public async Task<DescribeClusterAsGroupOptionResponse> DescribeClusterAsGroupOption(DescribeClusterAsGroupOptionRequest req)
        {
             JsonResponseModel<DescribeClusterAsGroupOptionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterAsGroupOption");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterAsGroupOptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Cluster auto scaling configuration
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterAsGroupOptionRequest"/></param>
        /// <returns><see cref="DescribeClusterAsGroupOptionResponse"/></returns>
        public DescribeClusterAsGroupOptionResponse DescribeClusterAsGroupOptionSync(DescribeClusterAsGroupOptionRequest req)
        {
             JsonResponseModel<DescribeClusterAsGroupOptionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterAsGroupOption");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterAsGroupOptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Cluster-associated scaling group list
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterAsGroupsRequest"/></param>
        /// <returns><see cref="DescribeClusterAsGroupsResponse"/></returns>
        public async Task<DescribeClusterAsGroupsResponse> DescribeClusterAsGroups(DescribeClusterAsGroupsRequest req)
        {
             JsonResponseModel<DescribeClusterAsGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterAsGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterAsGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Cluster-associated scaling group list
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterAsGroupsRequest"/></param>
        /// <returns><see cref="DescribeClusterAsGroupsResponse"/></returns>
        public DescribeClusterAsGroupsResponse DescribeClusterAsGroupsSync(DescribeClusterAsGroupsRequest req)
        {
             JsonResponseModel<DescribeClusterAsGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterAsGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterAsGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the CommonName from the kube-apiserver client certificate that corresponding to the sub-account in RBAC authorization mode. 
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterCommonNamesRequest"/></param>
        /// <returns><see cref="DescribeClusterCommonNamesResponse"/></returns>
        public async Task<DescribeClusterCommonNamesResponse> DescribeClusterCommonNames(DescribeClusterCommonNamesRequest req)
        {
             JsonResponseModel<DescribeClusterCommonNamesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterCommonNames");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterCommonNamesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the CommonName from the kube-apiserver client certificate that corresponding to the sub-account in RBAC authorization mode. 
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterCommonNamesRequest"/></param>
        /// <returns><see cref="DescribeClusterCommonNamesResponse"/></returns>
        public DescribeClusterCommonNamesResponse DescribeClusterCommonNamesSync(DescribeClusterCommonNamesRequest req)
        {
             JsonResponseModel<DescribeClusterCommonNamesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterCommonNames");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterCommonNamesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Query cluster access port status (intranet / extranet access is enabled for independent clusters, and intranet access is supported for managed clusters)
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterEndpointStatusRequest"/></param>
        /// <returns><see cref="DescribeClusterEndpointStatusResponse"/></returns>
        public async Task<DescribeClusterEndpointStatusResponse> DescribeClusterEndpointStatus(DescribeClusterEndpointStatusRequest req)
        {
             JsonResponseModel<DescribeClusterEndpointStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterEndpointStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterEndpointStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Query cluster access port status (intranet / extranet access is enabled for independent clusters, and intranet access is supported for managed clusters)
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterEndpointStatusRequest"/></param>
        /// <returns><see cref="DescribeClusterEndpointStatusResponse"/></returns>
        public DescribeClusterEndpointStatusResponse DescribeClusterEndpointStatusSync(DescribeClusterEndpointStatusRequest req)
        {
             JsonResponseModel<DescribeClusterEndpointStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterEndpointStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterEndpointStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Query cluster open port process status (only supports external ports of the managed cluster)
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterEndpointVipStatusRequest"/></param>
        /// <returns><see cref="DescribeClusterEndpointVipStatusResponse"/></returns>
        public async Task<DescribeClusterEndpointVipStatusResponse> DescribeClusterEndpointVipStatus(DescribeClusterEndpointVipStatusRequest req)
        {
             JsonResponseModel<DescribeClusterEndpointVipStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterEndpointVipStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterEndpointVipStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Query cluster open port process status (only supports external ports of the managed cluster)
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterEndpointVipStatusRequest"/></param>
        /// <returns><see cref="DescribeClusterEndpointVipStatusResponse"/></returns>
        public DescribeClusterEndpointVipStatusResponse DescribeClusterEndpointVipStatusSync(DescribeClusterEndpointVipStatusRequest req)
        {
             JsonResponseModel<DescribeClusterEndpointVipStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterEndpointVipStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterEndpointVipStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  This API is used to query information of one or more instances in a cluster. 
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterInstancesRequest"/></param>
        /// <returns><see cref="DescribeClusterInstancesResponse"/></returns>
        public async Task<DescribeClusterInstancesResponse> DescribeClusterInstances(DescribeClusterInstancesRequest req)
        {
             JsonResponseModel<DescribeClusterInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  This API is used to query information of one or more instances in a cluster. 
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterInstancesRequest"/></param>
        /// <returns><see cref="DescribeClusterInstancesResponse"/></returns>
        public DescribeClusterInstancesResponse DescribeClusterInstancesSync(DescribeClusterInstancesRequest req)
        {
             JsonResponseModel<DescribeClusterInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the cluster kubeconfig file. Different sub-accounts have their own kubeconfig files. The kubeconfig file contains the kube-apiserver client certificate of the corresponding sub-account. By default, the client certificate is created when this API is called for the first time, and the certificate is valid for 20 years with no permissions granted. For the cluster owner or primary account, the cluster-admin permission is granted by default.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterKubeconfigRequest"/></param>
        /// <returns><see cref="DescribeClusterKubeconfigResponse"/></returns>
        public async Task<DescribeClusterKubeconfigResponse> DescribeClusterKubeconfig(DescribeClusterKubeconfigRequest req)
        {
             JsonResponseModel<DescribeClusterKubeconfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterKubeconfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterKubeconfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the cluster kubeconfig file. Different sub-accounts have their own kubeconfig files. The kubeconfig file contains the kube-apiserver client certificate of the corresponding sub-account. By default, the client certificate is created when this API is called for the first time, and the certificate is valid for 20 years with no permissions granted. For the cluster owner or primary account, the cluster-admin permission is granted by default.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterKubeconfigRequest"/></param>
        /// <returns><see cref="DescribeClusterKubeconfigResponse"/></returns>
        public DescribeClusterKubeconfigResponse DescribeClusterKubeconfigSync(DescribeClusterKubeconfigRequest req)
        {
             JsonResponseModel<DescribeClusterKubeconfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterKubeconfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterKubeconfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query detailed information of a node pool.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterNodePoolDetailRequest"/></param>
        /// <returns><see cref="DescribeClusterNodePoolDetailResponse"/></returns>
        public async Task<DescribeClusterNodePoolDetailResponse> DescribeClusterNodePoolDetail(DescribeClusterNodePoolDetailRequest req)
        {
             JsonResponseModel<DescribeClusterNodePoolDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterNodePoolDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterNodePoolDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query detailed information of a node pool.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterNodePoolDetailRequest"/></param>
        /// <returns><see cref="DescribeClusterNodePoolDetailResponse"/></returns>
        public DescribeClusterNodePoolDetailResponse DescribeClusterNodePoolDetailSync(DescribeClusterNodePoolDetailRequest req)
        {
             JsonResponseModel<DescribeClusterNodePoolDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterNodePoolDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterNodePoolDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the node pool list
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterNodePoolsRequest"/></param>
        /// <returns><see cref="DescribeClusterNodePoolsResponse"/></returns>
        public async Task<DescribeClusterNodePoolsResponse> DescribeClusterNodePools(DescribeClusterNodePoolsRequest req)
        {
             JsonResponseModel<DescribeClusterNodePoolsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterNodePools");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterNodePoolsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the node pool list
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterNodePoolsRequest"/></param>
        /// <returns><see cref="DescribeClusterNodePoolsResponse"/></returns>
        public DescribeClusterNodePoolsResponse DescribeClusterNodePoolsSync(DescribeClusterNodePoolsRequest req)
        {
             JsonResponseModel<DescribeClusterNodePoolsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterNodePools");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterNodePoolsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query one or more cluster route tables.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterRouteTablesRequest"/></param>
        /// <returns><see cref="DescribeClusterRouteTablesResponse"/></returns>
        public async Task<DescribeClusterRouteTablesResponse> DescribeClusterRouteTables(DescribeClusterRouteTablesRequest req)
        {
             JsonResponseModel<DescribeClusterRouteTablesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterRouteTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterRouteTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query one or more cluster route tables.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterRouteTablesRequest"/></param>
        /// <returns><see cref="DescribeClusterRouteTablesResponse"/></returns>
        public DescribeClusterRouteTablesResponse DescribeClusterRouteTablesSync(DescribeClusterRouteTablesRequest req)
        {
             JsonResponseModel<DescribeClusterRouteTablesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterRouteTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterRouteTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query cluster routes.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterRoutesRequest"/></param>
        /// <returns><see cref="DescribeClusterRoutesResponse"/></returns>
        public async Task<DescribeClusterRoutesResponse> DescribeClusterRoutes(DescribeClusterRoutesRequest req)
        {
             JsonResponseModel<DescribeClusterRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query cluster routes.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterRoutesRequest"/></param>
        /// <returns><see cref="DescribeClusterRoutesResponse"/></returns>
        public DescribeClusterRoutesResponse DescribeClusterRoutesSync(DescribeClusterRoutesRequest req)
        {
             JsonResponseModel<DescribeClusterRoutesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the key information of a cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterSecurityRequest"/></param>
        /// <returns><see cref="DescribeClusterSecurityResponse"/></returns>
        public async Task<DescribeClusterSecurityResponse> DescribeClusterSecurity(DescribeClusterSecurityRequest req)
        {
             JsonResponseModel<DescribeClusterSecurityResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterSecurity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterSecurityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the key information of a cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterSecurityRequest"/></param>
        /// <returns><see cref="DescribeClusterSecurityResponse"/></returns>
        public DescribeClusterSecurityResponse DescribeClusterSecuritySync(DescribeClusterSecurityRequest req)
        {
             JsonResponseModel<DescribeClusterSecurityResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterSecurity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterSecurityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query clusters list.
        /// </summary>
        /// <param name="req"><see cref="DescribeClustersRequest"/></param>
        /// <returns><see cref="DescribeClustersResponse"/></returns>
        public async Task<DescribeClustersResponse> DescribeClusters(DescribeClustersRequest req)
        {
             JsonResponseModel<DescribeClustersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClustersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query clusters list.
        /// </summary>
        /// <param name="req"><see cref="DescribeClustersRequest"/></param>
        /// <returns><see cref="DescribeClustersResponse"/></returns>
        public DescribeClustersResponse DescribeClustersSync(DescribeClustersRequest req)
        {
             JsonResponseModel<DescribeClustersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClustersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the task progress of enabling VPC-CNI mode.
        /// </summary>
        /// <param name="req"><see cref="DescribeEnableVpcCniProgressRequest"/></param>
        /// <returns><see cref="DescribeEnableVpcCniProgressResponse"/></returns>
        public async Task<DescribeEnableVpcCniProgressResponse> DescribeEnableVpcCniProgress(DescribeEnableVpcCniProgressRequest req)
        {
             JsonResponseModel<DescribeEnableVpcCniProgressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEnableVpcCniProgress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEnableVpcCniProgressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the task progress of enabling VPC-CNI mode.
        /// </summary>
        /// <param name="req"><see cref="DescribeEnableVpcCniProgressRequest"/></param>
        /// <returns><see cref="DescribeEnableVpcCniProgressResponse"/></returns>
        public DescribeEnableVpcCniProgressResponse DescribeEnableVpcCniProgressSync(DescribeEnableVpcCniProgressRequest req)
        {
             JsonResponseModel<DescribeEnableVpcCniProgressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEnableVpcCniProgress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEnableVpcCniProgressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query one or more existing node and determine whether they can be added to a cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeExistedInstancesRequest"/></param>
        /// <returns><see cref="DescribeExistedInstancesResponse"/></returns>
        public async Task<DescribeExistedInstancesResponse> DescribeExistedInstances(DescribeExistedInstancesRequest req)
        {
             JsonResponseModel<DescribeExistedInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeExistedInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExistedInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query one or more existing node and determine whether they can be added to a cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeExistedInstancesRequest"/></param>
        /// <returns><see cref="DescribeExistedInstancesResponse"/></returns>
        public DescribeExistedInstancesResponse DescribeExistedInstancesSync(DescribeExistedInstancesRequest req)
        {
             JsonResponseModel<DescribeExistedInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeExistedInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExistedInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get image information.
        /// </summary>
        /// <param name="req"><see cref="DescribeImagesRequest"/></param>
        /// <returns><see cref="DescribeImagesResponse"/></returns>
        public async Task<DescribeImagesResponse> DescribeImages(DescribeImagesRequest req)
        {
             JsonResponseModel<DescribeImagesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get image information.
        /// </summary>
        /// <param name="req"><see cref="DescribeImagesRequest"/></param>
        /// <returns><see cref="DescribeImagesResponse"/></returns>
        public DescribeImagesResponse DescribeImagesSync(DescribeImagesRequest req)
        {
             JsonResponseModel<DescribeImagesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain all regions supported by TKE.
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public async Task<DescribeRegionsResponse> DescribeRegions(DescribeRegionsRequest req)
        {
             JsonResponseModel<DescribeRegionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain all regions supported by TKE.
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public DescribeRegionsResponse DescribeRegionsSync(DescribeRegionsRequest req)
        {
             JsonResponseModel<DescribeRegionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of route table conflicts.
        /// </summary>
        /// <param name="req"><see cref="DescribeRouteTableConflictsRequest"/></param>
        /// <returns><see cref="DescribeRouteTableConflictsResponse"/></returns>
        public async Task<DescribeRouteTableConflictsResponse> DescribeRouteTableConflicts(DescribeRouteTableConflictsRequest req)
        {
             JsonResponseModel<DescribeRouteTableConflictsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRouteTableConflicts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRouteTableConflictsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of route table conflicts.
        /// </summary>
        /// <param name="req"><see cref="DescribeRouteTableConflictsRequest"/></param>
        /// <returns><see cref="DescribeRouteTableConflictsResponse"/></returns>
        public DescribeRouteTableConflictsResponse DescribeRouteTableConflictsSync(DescribeRouteTableConflictsRequest req)
        {
             JsonResponseModel<DescribeRouteTableConflictsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRouteTableConflicts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRouteTableConflictsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable the VPC-CNI network mode for GR clusters.
        /// </summary>
        /// <param name="req"><see cref="EnableVpcCniNetworkTypeRequest"/></param>
        /// <returns><see cref="EnableVpcCniNetworkTypeResponse"/></returns>
        public async Task<EnableVpcCniNetworkTypeResponse> EnableVpcCniNetworkType(EnableVpcCniNetworkTypeRequest req)
        {
             JsonResponseModel<EnableVpcCniNetworkTypeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableVpcCniNetworkType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableVpcCniNetworkTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable the VPC-CNI network mode for GR clusters.
        /// </summary>
        /// <param name="req"><see cref="EnableVpcCniNetworkTypeRequest"/></param>
        /// <returns><see cref="EnableVpcCniNetworkTypeResponse"/></returns>
        public EnableVpcCniNetworkTypeResponse EnableVpcCniNetworkTypeSync(EnableVpcCniNetworkTypeRequest req)
        {
             JsonResponseModel<EnableVpcCniNetworkTypeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableVpcCniNetworkType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableVpcCniNetworkTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the current progress of the node upgrade. 
        /// </summary>
        /// <param name="req"><see cref="GetUpgradeInstanceProgressRequest"/></param>
        /// <returns><see cref="GetUpgradeInstanceProgressResponse"/></returns>
        public async Task<GetUpgradeInstanceProgressResponse> GetUpgradeInstanceProgress(GetUpgradeInstanceProgressRequest req)
        {
             JsonResponseModel<GetUpgradeInstanceProgressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetUpgradeInstanceProgress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetUpgradeInstanceProgressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the current progress of the node upgrade. 
        /// </summary>
        /// <param name="req"><see cref="GetUpgradeInstanceProgressRequest"/></param>
        /// <returns><see cref="GetUpgradeInstanceProgressResponse"/></returns>
        public GetUpgradeInstanceProgressResponse GetUpgradeInstanceProgressSync(GetUpgradeInstanceProgressRequest req)
        {
             JsonResponseModel<GetUpgradeInstanceProgressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetUpgradeInstanceProgress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetUpgradeInstanceProgressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Modify cluster scaling group attributes
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterAsGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyClusterAsGroupAttributeResponse"/></returns>
        public async Task<ModifyClusterAsGroupAttributeResponse> ModifyClusterAsGroupAttribute(ModifyClusterAsGroupAttributeRequest req)
        {
             JsonResponseModel<ModifyClusterAsGroupAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyClusterAsGroupAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterAsGroupAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Modify cluster scaling group attributes
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterAsGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyClusterAsGroupAttributeResponse"/></returns>
        public ModifyClusterAsGroupAttributeResponse ModifyClusterAsGroupAttributeSync(ModifyClusterAsGroupAttributeRequest req)
        {
             JsonResponseModel<ModifyClusterAsGroupAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyClusterAsGroupAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterAsGroupAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify cluster auto scaling attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterAsGroupOptionAttributeRequest"/></param>
        /// <returns><see cref="ModifyClusterAsGroupOptionAttributeResponse"/></returns>
        public async Task<ModifyClusterAsGroupOptionAttributeResponse> ModifyClusterAsGroupOptionAttribute(ModifyClusterAsGroupOptionAttributeRequest req)
        {
             JsonResponseModel<ModifyClusterAsGroupOptionAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyClusterAsGroupOptionAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterAsGroupOptionAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify cluster auto scaling attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterAsGroupOptionAttributeRequest"/></param>
        /// <returns><see cref="ModifyClusterAsGroupOptionAttributeResponse"/></returns>
        public ModifyClusterAsGroupOptionAttributeResponse ModifyClusterAsGroupOptionAttributeSync(ModifyClusterAsGroupOptionAttributeRequest req)
        {
             JsonResponseModel<ModifyClusterAsGroupOptionAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyClusterAsGroupOptionAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterAsGroupOptionAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify cluster attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterAttributeRequest"/></param>
        /// <returns><see cref="ModifyClusterAttributeResponse"/></returns>
        public async Task<ModifyClusterAttributeResponse> ModifyClusterAttribute(ModifyClusterAttributeRequest req)
        {
             JsonResponseModel<ModifyClusterAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyClusterAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify cluster attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterAttributeRequest"/></param>
        /// <returns><see cref="ModifyClusterAttributeResponse"/></returns>
        public ModifyClusterAttributeResponse ModifyClusterAttributeSync(ModifyClusterAttributeRequest req)
        {
             JsonResponseModel<ModifyClusterAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyClusterAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Modify the security policy of the external port of the managed cluster (the old way, only the external port of the managed cluster is supported)
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterEndpointSPRequest"/></param>
        /// <returns><see cref="ModifyClusterEndpointSPResponse"/></returns>
        public async Task<ModifyClusterEndpointSPResponse> ModifyClusterEndpointSP(ModifyClusterEndpointSPRequest req)
        {
             JsonResponseModel<ModifyClusterEndpointSPResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyClusterEndpointSP");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterEndpointSPResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Modify the security policy of the external port of the managed cluster (the old way, only the external port of the managed cluster is supported)
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterEndpointSPRequest"/></param>
        /// <returns><see cref="ModifyClusterEndpointSPResponse"/></returns>
        public ModifyClusterEndpointSPResponse ModifyClusterEndpointSPSync(ModifyClusterEndpointSPRequest req)
        {
             JsonResponseModel<ModifyClusterEndpointSPResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyClusterEndpointSP");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterEndpointSPResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to edit a node pool.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterNodePoolRequest"/></param>
        /// <returns><see cref="ModifyClusterNodePoolResponse"/></returns>
        public async Task<ModifyClusterNodePoolResponse> ModifyClusterNodePool(ModifyClusterNodePoolRequest req)
        {
             JsonResponseModel<ModifyClusterNodePoolResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyClusterNodePool");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterNodePoolResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to edit a node pool.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterNodePoolRequest"/></param>
        /// <returns><see cref="ModifyClusterNodePoolResponse"/></returns>
        public ModifyClusterNodePoolResponse ModifyClusterNodePoolSync(ModifyClusterNodePoolRequest req)
        {
             JsonResponseModel<ModifyClusterNodePoolResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyClusterNodePool");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterNodePoolResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to remove a node from a node pool but retain it in the cluster.
        /// </summary>
        /// <param name="req"><see cref="RemoveNodeFromNodePoolRequest"/></param>
        /// <returns><see cref="RemoveNodeFromNodePoolResponse"/></returns>
        public async Task<RemoveNodeFromNodePoolResponse> RemoveNodeFromNodePool(RemoveNodeFromNodePoolRequest req)
        {
             JsonResponseModel<RemoveNodeFromNodePoolResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RemoveNodeFromNodePool");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveNodeFromNodePoolResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to remove a node from a node pool but retain it in the cluster.
        /// </summary>
        /// <param name="req"><see cref="RemoveNodeFromNodePoolRequest"/></param>
        /// <returns><see cref="RemoveNodeFromNodePoolResponse"/></returns>
        public RemoveNodeFromNodePoolResponse RemoveNodeFromNodePoolSync(RemoveNodeFromNodePoolRequest req)
        {
             JsonResponseModel<RemoveNodeFromNodePoolResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RemoveNodeFromNodePool");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveNodeFromNodePoolResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable removal protection for the nodes automatically created by the scaling group in a node pool.
        /// </summary>
        /// <param name="req"><see cref="SetNodePoolNodeProtectionRequest"/></param>
        /// <returns><see cref="SetNodePoolNodeProtectionResponse"/></returns>
        public async Task<SetNodePoolNodeProtectionResponse> SetNodePoolNodeProtection(SetNodePoolNodeProtectionRequest req)
        {
             JsonResponseModel<SetNodePoolNodeProtectionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetNodePoolNodeProtection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetNodePoolNodeProtectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable removal protection for the nodes automatically created by the scaling group in a node pool.
        /// </summary>
        /// <param name="req"><see cref="SetNodePoolNodeProtectionRequest"/></param>
        /// <returns><see cref="SetNodePoolNodeProtectionResponse"/></returns>
        public SetNodePoolNodeProtectionResponse SetNodePoolNodeProtectionSync(SetNodePoolNodeProtectionRequest req)
        {
             JsonResponseModel<SetNodePoolNodeProtectionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetNodePoolNodeProtection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetNodePoolNodeProtectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upgrade the master component of the cluster to the specified version.
        /// </summary>
        /// <param name="req"><see cref="UpdateClusterVersionRequest"/></param>
        /// <returns><see cref="UpdateClusterVersionResponse"/></returns>
        public async Task<UpdateClusterVersionResponse> UpdateClusterVersion(UpdateClusterVersionRequest req)
        {
             JsonResponseModel<UpdateClusterVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateClusterVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateClusterVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upgrade the master component of the cluster to the specified version.
        /// </summary>
        /// <param name="req"><see cref="UpdateClusterVersionRequest"/></param>
        /// <returns><see cref="UpdateClusterVersionResponse"/></returns>
        public UpdateClusterVersionResponse UpdateClusterVersionSync(UpdateClusterVersionRequest req)
        {
             JsonResponseModel<UpdateClusterVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateClusterVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateClusterVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upgrade one or more work nodes in the cluster. 
        /// </summary>
        /// <param name="req"><see cref="UpgradeClusterInstancesRequest"/></param>
        /// <returns><see cref="UpgradeClusterInstancesResponse"/></returns>
        public async Task<UpgradeClusterInstancesResponse> UpgradeClusterInstances(UpgradeClusterInstancesRequest req)
        {
             JsonResponseModel<UpgradeClusterInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpgradeClusterInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeClusterInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upgrade one or more work nodes in the cluster. 
        /// </summary>
        /// <param name="req"><see cref="UpgradeClusterInstancesRequest"/></param>
        /// <returns><see cref="UpgradeClusterInstancesResponse"/></returns>
        public UpgradeClusterInstancesResponse UpgradeClusterInstancesSync(UpgradeClusterInstancesRequest req)
        {
             JsonResponseModel<UpgradeClusterInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpgradeClusterInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeClusterInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
