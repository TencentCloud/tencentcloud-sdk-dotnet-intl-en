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

namespace TencentCloud.Gwlb.V20240906
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Gwlb.V20240906.Models;

   public class GwlbClient : AbstractClient{

       private const string endpoint = "gwlb.intl.tencentcloudapi.com";
       private const string version = "2024-09-06";
       private const string sdkVersion = "SDK_NET_3.0.1136";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public GwlbClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public GwlbClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to bind target groups to a CLB.This is an async API. After the API return succeeds, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="AssociateTargetGroupsRequest"/></param>
        /// <returns><see cref="AssociateTargetGroupsResponse"/></returns>
        public Task<AssociateTargetGroupsResponse> AssociateTargetGroups(AssociateTargetGroupsRequest req)
        {
            return InternalRequestAsync<AssociateTargetGroupsResponse>(req, "AssociateTargetGroups");
        }

        /// <summary>
        /// This API is used to bind target groups to a CLB.This is an async API. After the API return succeeds, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="AssociateTargetGroupsRequest"/></param>
        /// <returns><see cref="AssociateTargetGroupsResponse"/></returns>
        public AssociateTargetGroupsResponse AssociateTargetGroupsSync(AssociateTargetGroupsRequest req)
        {
            return InternalRequestAsync<AssociateTargetGroupsResponse>(req, "AssociateTargetGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a GWLB instance. To use the GWLB service, you must purchase one or more GWLB instances. After this API is called successfully, a unique ID for the GWLB instance will be returned.Note: The default purchase quota for each account in each region is 10.This is an async API. After the API is called successfully, you can use the DescribeGatewayLoadBalancers API to query the status of the GWLB instance (such as creating and normal) to determine whether the creation is successful.
        /// </summary>
        /// <param name="req"><see cref="CreateGatewayLoadBalancerRequest"/></param>
        /// <returns><see cref="CreateGatewayLoadBalancerResponse"/></returns>
        public Task<CreateGatewayLoadBalancerResponse> CreateGatewayLoadBalancer(CreateGatewayLoadBalancerRequest req)
        {
            return InternalRequestAsync<CreateGatewayLoadBalancerResponse>(req, "CreateGatewayLoadBalancer");
        }

        /// <summary>
        /// This API is used to create a GWLB instance. To use the GWLB service, you must purchase one or more GWLB instances. After this API is called successfully, a unique ID for the GWLB instance will be returned.Note: The default purchase quota for each account in each region is 10.This is an async API. After the API is called successfully, you can use the DescribeGatewayLoadBalancers API to query the status of the GWLB instance (such as creating and normal) to determine whether the creation is successful.
        /// </summary>
        /// <param name="req"><see cref="CreateGatewayLoadBalancerRequest"/></param>
        /// <returns><see cref="CreateGatewayLoadBalancerResponse"/></returns>
        public CreateGatewayLoadBalancerResponse CreateGatewayLoadBalancerSync(CreateGatewayLoadBalancerRequest req)
        {
            return InternalRequestAsync<CreateGatewayLoadBalancerResponse>(req, "CreateGatewayLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a target group. This feature is in beta testing. If you need to use it, please [submit a ticket](https://console.cloud.tencent.com/workorder/category?level1_id=6&level2_id=163&source=0&data_title=%E8%B4%9F%E8%BD%BD%E5%9D%87%E8%A1%A1%20LB&step=1).
        /// </summary>
        /// <param name="req"><see cref="CreateTargetGroupRequest"/></param>
        /// <returns><see cref="CreateTargetGroupResponse"/></returns>
        public Task<CreateTargetGroupResponse> CreateTargetGroup(CreateTargetGroupRequest req)
        {
            return InternalRequestAsync<CreateTargetGroupResponse>(req, "CreateTargetGroup");
        }

        /// <summary>
        /// This API is used to create a target group. This feature is in beta testing. If you need to use it, please [submit a ticket](https://console.cloud.tencent.com/workorder/category?level1_id=6&level2_id=163&source=0&data_title=%E8%B4%9F%E8%BD%BD%E5%9D%87%E8%A1%A1%20LB&step=1).
        /// </summary>
        /// <param name="req"><see cref="CreateTargetGroupRequest"/></param>
        /// <returns><see cref="CreateTargetGroupResponse"/></returns>
        public CreateTargetGroupResponse CreateTargetGroupSync(CreateTargetGroupRequest req)
        {
            return InternalRequestAsync<CreateTargetGroupResponse>(req, "CreateTargetGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete one or more specified GWLB instances. After successful deletion, the GWLB instances will be unbound from the backend service.This is an async API. After the API return succeeds, you can call the DescribeTaskStatus API with the returned RequestId as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="DeleteGatewayLoadBalancerRequest"/></param>
        /// <returns><see cref="DeleteGatewayLoadBalancerResponse"/></returns>
        public Task<DeleteGatewayLoadBalancerResponse> DeleteGatewayLoadBalancer(DeleteGatewayLoadBalancerRequest req)
        {
            return InternalRequestAsync<DeleteGatewayLoadBalancerResponse>(req, "DeleteGatewayLoadBalancer");
        }

        /// <summary>
        /// This API is used to delete one or more specified GWLB instances. After successful deletion, the GWLB instances will be unbound from the backend service.This is an async API. After the API return succeeds, you can call the DescribeTaskStatus API with the returned RequestId as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="DeleteGatewayLoadBalancerRequest"/></param>
        /// <returns><see cref="DeleteGatewayLoadBalancerResponse"/></returns>
        public DeleteGatewayLoadBalancerResponse DeleteGatewayLoadBalancerSync(DeleteGatewayLoadBalancerRequest req)
        {
            return InternalRequestAsync<DeleteGatewayLoadBalancerResponse>(req, "DeleteGatewayLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a target group.
        /// </summary>
        /// <param name="req"><see cref="DeleteTargetGroupsRequest"/></param>
        /// <returns><see cref="DeleteTargetGroupsResponse"/></returns>
        public Task<DeleteTargetGroupsResponse> DeleteTargetGroups(DeleteTargetGroupsRequest req)
        {
            return InternalRequestAsync<DeleteTargetGroupsResponse>(req, "DeleteTargetGroups");
        }

        /// <summary>
        /// This API is used to delete a target group.
        /// </summary>
        /// <param name="req"><see cref="DeleteTargetGroupsRequest"/></param>
        /// <returns><see cref="DeleteTargetGroupsResponse"/></returns>
        public DeleteTargetGroupsResponse DeleteTargetGroupsSync(DeleteTargetGroupsRequest req)
        {
            return InternalRequestAsync<DeleteTargetGroupsResponse>(req, "DeleteTargetGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind a server from a target group.
        /// This is an async API. After the API return succeeds, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="DeregisterTargetGroupInstancesRequest"/></param>
        /// <returns><see cref="DeregisterTargetGroupInstancesResponse"/></returns>
        public Task<DeregisterTargetGroupInstancesResponse> DeregisterTargetGroupInstances(DeregisterTargetGroupInstancesRequest req)
        {
            return InternalRequestAsync<DeregisterTargetGroupInstancesResponse>(req, "DeregisterTargetGroupInstances");
        }

        /// <summary>
        /// This API is used to unbind a server from a target group.
        /// This is an async API. After the API return succeeds, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="DeregisterTargetGroupInstancesRequest"/></param>
        /// <returns><see cref="DeregisterTargetGroupInstancesResponse"/></returns>
        public DeregisterTargetGroupInstancesResponse DeregisterTargetGroupInstancesSync(DeregisterTargetGroupInstancesRequest req)
        {
            return InternalRequestAsync<DeregisterTargetGroupInstancesResponse>(req, "DeregisterTargetGroupInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of GWLB instances in a region.
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayLoadBalancersRequest"/></param>
        /// <returns><see cref="DescribeGatewayLoadBalancersResponse"/></returns>
        public Task<DescribeGatewayLoadBalancersResponse> DescribeGatewayLoadBalancers(DescribeGatewayLoadBalancersRequest req)
        {
            return InternalRequestAsync<DescribeGatewayLoadBalancersResponse>(req, "DescribeGatewayLoadBalancers");
        }

        /// <summary>
        /// This API is used to query the list of GWLB instances in a region.
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayLoadBalancersRequest"/></param>
        /// <returns><see cref="DescribeGatewayLoadBalancersResponse"/></returns>
        public DescribeGatewayLoadBalancersResponse DescribeGatewayLoadBalancersSync(DescribeGatewayLoadBalancersRequest req)
        {
            return InternalRequestAsync<DescribeGatewayLoadBalancersResponse>(req, "DescribeGatewayLoadBalancers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the backend service status of a target group. Currently, only GWLB type target groups support querying backend service status.
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupInstanceStatusRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupInstanceStatusResponse"/></returns>
        public Task<DescribeTargetGroupInstanceStatusResponse> DescribeTargetGroupInstanceStatus(DescribeTargetGroupInstanceStatusRequest req)
        {
            return InternalRequestAsync<DescribeTargetGroupInstanceStatusResponse>(req, "DescribeTargetGroupInstanceStatus");
        }

        /// <summary>
        /// This API is used to query the backend service status of a target group. Currently, only GWLB type target groups support querying backend service status.
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupInstanceStatusRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupInstanceStatusResponse"/></returns>
        public DescribeTargetGroupInstanceStatusResponse DescribeTargetGroupInstanceStatusSync(DescribeTargetGroupInstanceStatusRequest req)
        {
            return InternalRequestAsync<DescribeTargetGroupInstanceStatusResponse>(req, "DescribeTargetGroupInstanceStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain information on servers bound to a target group.
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupInstancesRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupInstancesResponse"/></returns>
        public Task<DescribeTargetGroupInstancesResponse> DescribeTargetGroupInstances(DescribeTargetGroupInstancesRequest req)
        {
            return InternalRequestAsync<DescribeTargetGroupInstancesResponse>(req, "DescribeTargetGroupInstances");
        }

        /// <summary>
        /// This API is used to obtain information on servers bound to a target group.
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupInstancesRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupInstancesResponse"/></returns>
        public DescribeTargetGroupInstancesResponse DescribeTargetGroupInstancesSync(DescribeTargetGroupInstancesRequest req)
        {
            return InternalRequestAsync<DescribeTargetGroupInstancesResponse>(req, "DescribeTargetGroupInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain a target group list.
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupListRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupListResponse"/></returns>
        public Task<DescribeTargetGroupListResponse> DescribeTargetGroupList(DescribeTargetGroupListRequest req)
        {
            return InternalRequestAsync<DescribeTargetGroupListResponse>(req, "DescribeTargetGroupList");
        }

        /// <summary>
        /// This API is used to obtain a target group list.
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupListRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupListResponse"/></returns>
        public DescribeTargetGroupListResponse DescribeTargetGroupListSync(DescribeTargetGroupListRequest req)
        {
            return InternalRequestAsync<DescribeTargetGroupListResponse>(req, "DescribeTargetGroupList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query target group information.
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupsRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupsResponse"/></returns>
        public Task<DescribeTargetGroupsResponse> DescribeTargetGroups(DescribeTargetGroupsRequest req)
        {
            return InternalRequestAsync<DescribeTargetGroupsResponse>(req, "DescribeTargetGroups");
        }

        /// <summary>
        /// This API is used to query target group information.
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupsRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupsResponse"/></returns>
        public DescribeTargetGroupsResponse DescribeTargetGroupsSync(DescribeTargetGroupsRequest req)
        {
            return InternalRequestAsync<DescribeTargetGroupsResponse>(req, "DescribeTargetGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the execution status of an async task. After non-query APIs (for example, used to create/delete CLB instances) are called successfully, this API needs to be used to query whether the task is successful.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskStatusResponse"/></returns>
        public Task<DescribeTaskStatusResponse> DescribeTaskStatus(DescribeTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeTaskStatusResponse>(req, "DescribeTaskStatus");
        }

        /// <summary>
        /// This API is used to query the execution status of an async task. After non-query APIs (for example, used to create/delete CLB instances) are called successfully, this API needs to be used to query whether the task is successful.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskStatusResponse"/></returns>
        public DescribeTaskStatusResponse DescribeTaskStatusSync(DescribeTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeTaskStatusResponse>(req, "DescribeTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disassociate a CLB from a target group.This is an async API. After the API return succeeds, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="DisassociateTargetGroupsRequest"/></param>
        /// <returns><see cref="DisassociateTargetGroupsResponse"/></returns>
        public Task<DisassociateTargetGroupsResponse> DisassociateTargetGroups(DisassociateTargetGroupsRequest req)
        {
            return InternalRequestAsync<DisassociateTargetGroupsResponse>(req, "DisassociateTargetGroups");
        }

        /// <summary>
        /// This API is used to disassociate a CLB from a target group.This is an async API. After the API return succeeds, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="DisassociateTargetGroupsRequest"/></param>
        /// <returns><see cref="DisassociateTargetGroupsResponse"/></returns>
        public DisassociateTargetGroupsResponse DisassociateTargetGroupsSync(DisassociateTargetGroupsRequest req)
        {
            return InternalRequestAsync<DisassociateTargetGroupsResponse>(req, "DisassociateTargetGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the price for creating a GWLB.
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateGatewayLoadBalancerRequest"/></param>
        /// <returns><see cref="InquirePriceCreateGatewayLoadBalancerResponse"/></returns>
        public Task<InquirePriceCreateGatewayLoadBalancerResponse> InquirePriceCreateGatewayLoadBalancer(InquirePriceCreateGatewayLoadBalancerRequest req)
        {
            return InternalRequestAsync<InquirePriceCreateGatewayLoadBalancerResponse>(req, "InquirePriceCreateGatewayLoadBalancer");
        }

        /// <summary>
        /// This API is used to query the price for creating a GWLB.
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateGatewayLoadBalancerRequest"/></param>
        /// <returns><see cref="InquirePriceCreateGatewayLoadBalancerResponse"/></returns>
        public InquirePriceCreateGatewayLoadBalancerResponse InquirePriceCreateGatewayLoadBalancerSync(InquirePriceCreateGatewayLoadBalancerRequest req)
        {
            return InternalRequestAsync<InquirePriceCreateGatewayLoadBalancerResponse>(req, "InquirePriceCreateGatewayLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the attributes of a CLB instance. It supports modifying the name and bandwidth cap of the CLB instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyGatewayLoadBalancerAttributeRequest"/></param>
        /// <returns><see cref="ModifyGatewayLoadBalancerAttributeResponse"/></returns>
        public Task<ModifyGatewayLoadBalancerAttributeResponse> ModifyGatewayLoadBalancerAttribute(ModifyGatewayLoadBalancerAttributeRequest req)
        {
            return InternalRequestAsync<ModifyGatewayLoadBalancerAttributeResponse>(req, "ModifyGatewayLoadBalancerAttribute");
        }

        /// <summary>
        /// This API is used to modify the attributes of a CLB instance. It supports modifying the name and bandwidth cap of the CLB instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyGatewayLoadBalancerAttributeRequest"/></param>
        /// <returns><see cref="ModifyGatewayLoadBalancerAttributeResponse"/></returns>
        public ModifyGatewayLoadBalancerAttributeResponse ModifyGatewayLoadBalancerAttributeSync(ModifyGatewayLoadBalancerAttributeRequest req)
        {
            return InternalRequestAsync<ModifyGatewayLoadBalancerAttributeResponse>(req, "ModifyGatewayLoadBalancerAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the name, health check, and other attributes of the target group.
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyTargetGroupAttributeResponse"/></returns>
        public Task<ModifyTargetGroupAttributeResponse> ModifyTargetGroupAttribute(ModifyTargetGroupAttributeRequest req)
        {
            return InternalRequestAsync<ModifyTargetGroupAttributeResponse>(req, "ModifyTargetGroupAttribute");
        }

        /// <summary>
        /// This API is used to modify the name, health check, and other attributes of the target group.
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyTargetGroupAttributeResponse"/></returns>
        public ModifyTargetGroupAttributeResponse ModifyTargetGroupAttributeSync(ModifyTargetGroupAttributeRequest req)
        {
            return InternalRequestAsync<ModifyTargetGroupAttributeResponse>(req, "ModifyTargetGroupAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the server weight of a target group.This is an async API. After the API return succeeds, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetGroupInstancesWeightRequest"/></param>
        /// <returns><see cref="ModifyTargetGroupInstancesWeightResponse"/></returns>
        public Task<ModifyTargetGroupInstancesWeightResponse> ModifyTargetGroupInstancesWeight(ModifyTargetGroupInstancesWeightRequest req)
        {
            return InternalRequestAsync<ModifyTargetGroupInstancesWeightResponse>(req, "ModifyTargetGroupInstancesWeight");
        }

        /// <summary>
        /// This API is used to modify the server weight of a target group.This is an async API. After the API return succeeds, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetGroupInstancesWeightRequest"/></param>
        /// <returns><see cref="ModifyTargetGroupInstancesWeightResponse"/></returns>
        public ModifyTargetGroupInstancesWeightResponse ModifyTargetGroupInstancesWeightSync(ModifyTargetGroupInstancesWeightRequest req)
        {
            return InternalRequestAsync<ModifyTargetGroupInstancesWeightResponse>(req, "ModifyTargetGroupInstancesWeight")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to register servers to a target group.This is an async API. After the API return succeeds, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="RegisterTargetGroupInstancesRequest"/></param>
        /// <returns><see cref="RegisterTargetGroupInstancesResponse"/></returns>
        public Task<RegisterTargetGroupInstancesResponse> RegisterTargetGroupInstances(RegisterTargetGroupInstancesRequest req)
        {
            return InternalRequestAsync<RegisterTargetGroupInstancesResponse>(req, "RegisterTargetGroupInstances");
        }

        /// <summary>
        /// This API is used to register servers to a target group.This is an async API. After the API return succeeds, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="RegisterTargetGroupInstancesRequest"/></param>
        /// <returns><see cref="RegisterTargetGroupInstancesResponse"/></returns>
        public RegisterTargetGroupInstancesResponse RegisterTargetGroupInstancesSync(RegisterTargetGroupInstancesRequest req)
        {
            return InternalRequestAsync<RegisterTargetGroupInstancesResponse>(req, "RegisterTargetGroupInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
