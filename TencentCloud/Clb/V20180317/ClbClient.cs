/*
 * Copyright (c) 2018 Tencent. All Rights Reserved.
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

namespace TencentCloud.Clb.V20180317
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Clb.V20180317.Models;

   public class ClbClient : AbstractClient{

       private const string endpoint = "clb.intl.tencentcloudapi.com";
       private const string version = "2018-03-17";
       private const string sdkVersion = "SDK_NET_3.0.1223";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public ClbClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public ClbClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to bind target groups to CLB listeners (layer-4 protocol) or forwarding rules (layer-7 protocol).
        /// This is an async API. After it is returned successfully, you can call the `DescribeTaskStatus` API with the returned `RequestID` as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="AssociateTargetGroupsRequest"/></param>
        /// <returns><see cref="AssociateTargetGroupsResponse"/></returns>
        public Task<AssociateTargetGroupsResponse> AssociateTargetGroups(AssociateTargetGroupsRequest req)
        {
            return InternalRequestAsync<AssociateTargetGroupsResponse>(req, "AssociateTargetGroups");
        }

        /// <summary>
        /// This API is used to bind target groups to CLB listeners (layer-4 protocol) or forwarding rules (layer-7 protocol).
        /// This is an async API. After it is returned successfully, you can call the `DescribeTaskStatus` API with the returned `RequestID` as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="AssociateTargetGroupsRequest"/></param>
        /// <returns><see cref="AssociateTargetGroupsResponse"/></returns>
        public AssociateTargetGroupsResponse AssociateTargetGroupsSync(AssociateTargetGroupsRequest req)
        {
            return InternalRequestAsync<AssociateTargetGroupsResponse>(req, "AssociateTargetGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// An HTTPS:443 listener needs to be created first, along with a forwarding rule. When this API is called, an HTTP:80 listener will be created automatically if it did not exist and a forwarding rule corresponding to `Domains` (specified in the input parameter) under the HTTPS:443 listener will also be created. After successful creation, access requests to an HTTP:80 address will be redirected to an HTTPS:443 address automatically.
        /// </summary>
        /// <param name="req"><see cref="AutoRewriteRequest"/></param>
        /// <returns><see cref="AutoRewriteResponse"/></returns>
        public Task<AutoRewriteResponse> AutoRewrite(AutoRewriteRequest req)
        {
            return InternalRequestAsync<AutoRewriteResponse>(req, "AutoRewrite");
        }

        /// <summary>
        /// An HTTPS:443 listener needs to be created first, along with a forwarding rule. When this API is called, an HTTP:80 listener will be created automatically if it did not exist and a forwarding rule corresponding to `Domains` (specified in the input parameter) under the HTTPS:443 listener will also be created. After successful creation, access requests to an HTTP:80 address will be redirected to an HTTPS:443 address automatically.
        /// </summary>
        /// <param name="req"><see cref="AutoRewriteRequest"/></param>
        /// <returns><see cref="AutoRewriteResponse"/></returns>
        public AutoRewriteResponse AutoRewriteSync(AutoRewriteRequest req)
        {
            return InternalRequestAsync<AutoRewriteResponse>(req, "AutoRewrite")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch unbind real servers of the layer-4 and layer-7 VPC-based CLBs. Up to 500 real servers can be unbound in a batch.
        /// </summary>
        /// <param name="req"><see cref="BatchDeregisterTargetsRequest"/></param>
        /// <returns><see cref="BatchDeregisterTargetsResponse"/></returns>
        public Task<BatchDeregisterTargetsResponse> BatchDeregisterTargets(BatchDeregisterTargetsRequest req)
        {
            return InternalRequestAsync<BatchDeregisterTargetsResponse>(req, "BatchDeregisterTargets");
        }

        /// <summary>
        /// This API is used to batch unbind real servers of the layer-4 and layer-7 VPC-based CLBs. Up to 500 real servers can be unbound in a batch.
        /// </summary>
        /// <param name="req"><see cref="BatchDeregisterTargetsRequest"/></param>
        /// <returns><see cref="BatchDeregisterTargetsResponse"/></returns>
        public BatchDeregisterTargetsResponse BatchDeregisterTargetsSync(BatchDeregisterTargetsRequest req)
        {
            return InternalRequestAsync<BatchDeregisterTargetsResponse>(req, "BatchDeregisterTargets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the tags of real servers bound to CLB listeners in batches. The maximum number of resources that can be modified in a batch is 500. This is a synchronous API. <br/> It is supported for Layer-4 and Layer-7 listeners of CLB instances, but not for classic CLB instances.
        /// </summary>
        /// <param name="req"><see cref="BatchModifyTargetTagRequest"/></param>
        /// <returns><see cref="BatchModifyTargetTagResponse"/></returns>
        public Task<BatchModifyTargetTagResponse> BatchModifyTargetTag(BatchModifyTargetTagRequest req)
        {
            return InternalRequestAsync<BatchModifyTargetTagResponse>(req, "BatchModifyTargetTag");
        }

        /// <summary>
        /// This API is used to modify the tags of real servers bound to CLB listeners in batches. The maximum number of resources that can be modified in a batch is 500. This is a synchronous API. <br/> It is supported for Layer-4 and Layer-7 listeners of CLB instances, but not for classic CLB instances.
        /// </summary>
        /// <param name="req"><see cref="BatchModifyTargetTagRequest"/></param>
        /// <returns><see cref="BatchModifyTargetTagResponse"/></returns>
        public BatchModifyTargetTagResponse BatchModifyTargetTagSync(BatchModifyTargetTagRequest req)
        {
            return InternalRequestAsync<BatchModifyTargetTagResponse>(req, "BatchModifyTargetTag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify forwarding weights of real servers bound to CLB listeners in batches. Up to 500 servers can be unbound in a batch. As this API is async, you should check whether the task is successful by passing the RequestId returned to the API call `DescribeTaskStatus`.<br/> This API is supported by CLB layer-4 and layer-7 listeners, but not Classis CLB counterparts.
        /// </summary>
        /// <param name="req"><see cref="BatchModifyTargetWeightRequest"/></param>
        /// <returns><see cref="BatchModifyTargetWeightResponse"/></returns>
        public Task<BatchModifyTargetWeightResponse> BatchModifyTargetWeight(BatchModifyTargetWeightRequest req)
        {
            return InternalRequestAsync<BatchModifyTargetWeightResponse>(req, "BatchModifyTargetWeight");
        }

        /// <summary>
        /// This API is used to modify forwarding weights of real servers bound to CLB listeners in batches. Up to 500 servers can be unbound in a batch. As this API is async, you should check whether the task is successful by passing the RequestId returned to the API call `DescribeTaskStatus`.<br/> This API is supported by CLB layer-4 and layer-7 listeners, but not Classis CLB counterparts.
        /// </summary>
        /// <param name="req"><see cref="BatchModifyTargetWeightRequest"/></param>
        /// <returns><see cref="BatchModifyTargetWeightResponse"/></returns>
        public BatchModifyTargetWeightResponse BatchModifyTargetWeightSync(BatchModifyTargetWeightRequest req)
        {
            return InternalRequestAsync<BatchModifyTargetWeightResponse>(req, "BatchModifyTargetWeight")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch bind CVM instances or ENIs. Up to 500 servers can be bound in a batch. It supports cross-region binding, layer-4 and layer-7 (TCP/UDP/HTTP/HTTPS) protocols, and VPC-based CLBs only.
        /// </summary>
        /// <param name="req"><see cref="BatchRegisterTargetsRequest"/></param>
        /// <returns><see cref="BatchRegisterTargetsResponse"/></returns>
        public Task<BatchRegisterTargetsResponse> BatchRegisterTargets(BatchRegisterTargetsRequest req)
        {
            return InternalRequestAsync<BatchRegisterTargetsResponse>(req, "BatchRegisterTargets");
        }

        /// <summary>
        /// This API is used to batch bind CVM instances or ENIs. Up to 500 servers can be bound in a batch. It supports cross-region binding, layer-4 and layer-7 (TCP/UDP/HTTP/HTTPS) protocols, and VPC-based CLBs only.
        /// </summary>
        /// <param name="req"><see cref="BatchRegisterTargetsRequest"/></param>
        /// <returns><see cref="BatchRegisterTargetsResponse"/></returns>
        public BatchRegisterTargetsResponse BatchRegisterTargetsSync(BatchRegisterTargetsRequest req)
        {
            return InternalRequestAsync<BatchRegisterTargetsResponse>(req, "BatchRegisterTargets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to clone a CLB instance. CLB instance cloning indicates copying a specified CLB instance to create one with the same rules and binding relationships. The operation of this cloning API is asynchronous. The cloned data is based on the state when CloneLoadBalancer is called. If the cloned CLB instance changes after CloneLoadBalancer is called, the changed rules will not be cloned.Note: You can query the instance creation status by calling the [DescribeTaskStatus](https://intl.cloud.tencent.com/document/product/214/30683?from_cn_redirect=1) API with the returned requestId.RestrictionsInstance attribute restrictions:- Instances billed in pay-as-you-go and monthly subscription modes can be cloned. For a new instance cloned from a monthly subscription instance, its network billing mode will switch to billing by hourly bandwidth, but its bandwidth and specifications will remain the same as the settings of the original instance.- CLB instances not associated with any billable items cannot be cloned.- Classic CLB instances and CLB instances with Anti-DDoS Pro cannot be cloned.- Classic network-based instances cannot be cloned.- Anycast instances cannot be cloned.- IPv6 NAT64 instances cannot be cloned.- Blocked or frozen instances cannot be cloned.- Before cloning an instance, make sure that all certificates used on the instance have not expired; otherwise, the cloning will fail.Quota restrictions:- Instances with more than 50 listeners cannot be cloned.- Shared instances with the public network bandwidth cap exceeding 2 Gbps cannot be cloned.API calling restrictions:The bandwidth package ID must be input for BGP bandwidth packages.Corresponding parameters should be input for cloning of an exclusive cluster; otherwise, a shared instance will be created.The feature is in beta test. You can submit a [beta test application](https://intl.cloud.tencent.com/apply/p/1akuvsmyn0g?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CloneLoadBalancerRequest"/></param>
        /// <returns><see cref="CloneLoadBalancerResponse"/></returns>
        public Task<CloneLoadBalancerResponse> CloneLoadBalancer(CloneLoadBalancerRequest req)
        {
            return InternalRequestAsync<CloneLoadBalancerResponse>(req, "CloneLoadBalancer");
        }

        /// <summary>
        /// This API is used to clone a CLB instance. CLB instance cloning indicates copying a specified CLB instance to create one with the same rules and binding relationships. The operation of this cloning API is asynchronous. The cloned data is based on the state when CloneLoadBalancer is called. If the cloned CLB instance changes after CloneLoadBalancer is called, the changed rules will not be cloned.Note: You can query the instance creation status by calling the [DescribeTaskStatus](https://intl.cloud.tencent.com/document/product/214/30683?from_cn_redirect=1) API with the returned requestId.RestrictionsInstance attribute restrictions:- Instances billed in pay-as-you-go and monthly subscription modes can be cloned. For a new instance cloned from a monthly subscription instance, its network billing mode will switch to billing by hourly bandwidth, but its bandwidth and specifications will remain the same as the settings of the original instance.- CLB instances not associated with any billable items cannot be cloned.- Classic CLB instances and CLB instances with Anti-DDoS Pro cannot be cloned.- Classic network-based instances cannot be cloned.- Anycast instances cannot be cloned.- IPv6 NAT64 instances cannot be cloned.- Blocked or frozen instances cannot be cloned.- Before cloning an instance, make sure that all certificates used on the instance have not expired; otherwise, the cloning will fail.Quota restrictions:- Instances with more than 50 listeners cannot be cloned.- Shared instances with the public network bandwidth cap exceeding 2 Gbps cannot be cloned.API calling restrictions:The bandwidth package ID must be input for BGP bandwidth packages.Corresponding parameters should be input for cloning of an exclusive cluster; otherwise, a shared instance will be created.The feature is in beta test. You can submit a [beta test application](https://intl.cloud.tencent.com/apply/p/1akuvsmyn0g?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CloneLoadBalancerRequest"/></param>
        /// <returns><see cref="CloneLoadBalancerResponse"/></returns>
        public CloneLoadBalancerResponse CloneLoadBalancerSync(CloneLoadBalancerRequest req)
        {
            return InternalRequestAsync<CloneLoadBalancerResponse>(req, "CloneLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a CLB exclusive logset for storing CLB logs.
        /// </summary>
        /// <param name="req"><see cref="CreateClsLogSetRequest"/></param>
        /// <returns><see cref="CreateClsLogSetResponse"/></returns>
        public Task<CreateClsLogSetResponse> CreateClsLogSet(CreateClsLogSetRequest req)
        {
            return InternalRequestAsync<CreateClsLogSetResponse>(req, "CreateClsLogSet");
        }

        /// <summary>
        /// This API is used to create a CLB exclusive logset for storing CLB logs.
        /// </summary>
        /// <param name="req"><see cref="CreateClsLogSetRequest"/></param>
        /// <returns><see cref="CreateClsLogSetResponse"/></returns>
        public CreateClsLogSetResponse CreateClsLogSetSync(CreateClsLogSetRequest req)
        {
            return InternalRequestAsync<CreateClsLogSetResponse>(req, "CreateClsLogSet")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a listener for a CLB instance.
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestId as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="CreateListenerRequest"/></param>
        /// <returns><see cref="CreateListenerResponse"/></returns>
        public Task<CreateListenerResponse> CreateListener(CreateListenerRequest req)
        {
            return InternalRequestAsync<CreateListenerResponse>(req, "CreateListener");
        }

        /// <summary>
        /// This API is used to create a listener for a CLB instance.
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestId as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="CreateListenerRequest"/></param>
        /// <returns><see cref="CreateListenerResponse"/></returns>
        public CreateListenerResponse CreateListenerSync(CreateListenerRequest req)
        {
            return InternalRequestAsync<CreateListenerResponse>(req, "CreateListener")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (CreateLoadBalancer) is used to create a CLB instance. To use the CLB service, you first need to purchase one or more instances. After this API is called successfully, a unique instance ID will be returned. There are two types of instances: public network and private network. For more information, see the product types in the product documentation.
        /// Note: (1) To apply for a CLB instance in the specified AZ and cross-AZ disaster recovery, please [submit a ticket](https://console.cloud.tencent.com/workorder/category); (2) Currently, IPv6 is supported only in Beijing, Shanghai, and Guangzhou regions.
        /// This is an async API. After it is returned successfully, you can call the DescribeLoadBalancers API to query the status of the instance (such as creating and normal) to check whether it is successfully created.
        /// </summary>
        /// <param name="req"><see cref="CreateLoadBalancerRequest"/></param>
        /// <returns><see cref="CreateLoadBalancerResponse"/></returns>
        public Task<CreateLoadBalancerResponse> CreateLoadBalancer(CreateLoadBalancerRequest req)
        {
            return InternalRequestAsync<CreateLoadBalancerResponse>(req, "CreateLoadBalancer");
        }

        /// <summary>
        /// This API (CreateLoadBalancer) is used to create a CLB instance. To use the CLB service, you first need to purchase one or more instances. After this API is called successfully, a unique instance ID will be returned. There are two types of instances: public network and private network. For more information, see the product types in the product documentation.
        /// Note: (1) To apply for a CLB instance in the specified AZ and cross-AZ disaster recovery, please [submit a ticket](https://console.cloud.tencent.com/workorder/category); (2) Currently, IPv6 is supported only in Beijing, Shanghai, and Guangzhou regions.
        /// This is an async API. After it is returned successfully, you can call the DescribeLoadBalancers API to query the status of the instance (such as creating and normal) to check whether it is successfully created.
        /// </summary>
        /// <param name="req"><see cref="CreateLoadBalancerRequest"/></param>
        /// <returns><see cref="CreateLoadBalancerResponse"/></returns>
        public CreateLoadBalancerResponse CreateLoadBalancerSync(CreateLoadBalancerRequest req)
        {
            return InternalRequestAsync<CreateLoadBalancerResponse>(req, "CreateLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add an SNAT IP for an SnatPro CLB instance. If SnatPro is not enabled for CLB, it will be automatically enabled after the SNAT IP is added.
        /// This is an async API. After it is returned successfully, you can check the task result by calling `DescribeTaskStatus` with the returned `RequestID`.
        /// </summary>
        /// <param name="req"><see cref="CreateLoadBalancerSnatIpsRequest"/></param>
        /// <returns><see cref="CreateLoadBalancerSnatIpsResponse"/></returns>
        public Task<CreateLoadBalancerSnatIpsResponse> CreateLoadBalancerSnatIps(CreateLoadBalancerSnatIpsRequest req)
        {
            return InternalRequestAsync<CreateLoadBalancerSnatIpsResponse>(req, "CreateLoadBalancerSnatIps");
        }

        /// <summary>
        /// This API is used to add an SNAT IP for an SnatPro CLB instance. If SnatPro is not enabled for CLB, it will be automatically enabled after the SNAT IP is added.
        /// This is an async API. After it is returned successfully, you can check the task result by calling `DescribeTaskStatus` with the returned `RequestID`.
        /// </summary>
        /// <param name="req"><see cref="CreateLoadBalancerSnatIpsRequest"/></param>
        /// <returns><see cref="CreateLoadBalancerSnatIpsResponse"/></returns>
        public CreateLoadBalancerSnatIpsResponse CreateLoadBalancerSnatIpsSync(CreateLoadBalancerSnatIpsRequest req)
        {
            return InternalRequestAsync<CreateLoadBalancerSnatIpsResponse>(req, "CreateLoadBalancerSnatIps")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (CreateRule) is used to create a forwarding rule under an existing layer-7 CLB listener, where real servers must be bound to the rule instead of the listener.
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="CreateRuleRequest"/></param>
        /// <returns><see cref="CreateRuleResponse"/></returns>
        public Task<CreateRuleResponse> CreateRule(CreateRuleRequest req)
        {
            return InternalRequestAsync<CreateRuleResponse>(req, "CreateRule");
        }

        /// <summary>
        /// This API (CreateRule) is used to create a forwarding rule under an existing layer-7 CLB listener, where real servers must be bound to the rule instead of the listener.
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="CreateRuleRequest"/></param>
        /// <returns><see cref="CreateRuleResponse"/></returns>
        public CreateRuleResponse CreateRuleSync(CreateRuleRequest req)
        {
            return InternalRequestAsync<CreateRuleResponse>(req, "CreateRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a target group. This feature is in beta test, if you want to try it out, please [submit a ticket](https://console.cloud.tencent.com/workorder/category?level1_id=6&level2_id=163&source=0&data_title=%E8%B4%9F%E8%BD%BD%E5%9D%87%E8%A1%A1%20LB&step=1).
        /// </summary>
        /// <param name="req"><see cref="CreateTargetGroupRequest"/></param>
        /// <returns><see cref="CreateTargetGroupResponse"/></returns>
        public Task<CreateTargetGroupResponse> CreateTargetGroup(CreateTargetGroupRequest req)
        {
            return InternalRequestAsync<CreateTargetGroupResponse>(req, "CreateTargetGroup");
        }

        /// <summary>
        /// This API is used to create a target group. This feature is in beta test, if you want to try it out, please [submit a ticket](https://console.cloud.tencent.com/workorder/category?level1_id=6&level2_id=163&source=0&data_title=%E8%B4%9F%E8%BD%BD%E5%9D%87%E8%A1%A1%20LB&step=1).
        /// </summary>
        /// <param name="req"><see cref="CreateTargetGroupRequest"/></param>
        /// <returns><see cref="CreateTargetGroupResponse"/></returns>
        public CreateTargetGroupResponse CreateTargetGroupSync(CreateTargetGroupRequest req)
        {
            return InternalRequestAsync<CreateTargetGroupResponse>(req, "CreateTargetGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a topic with the full-text index and key-value index enabled by default. The creation will fail if there is no CLB exclusive logset.
        /// </summary>
        /// <param name="req"><see cref="CreateTopicRequest"/></param>
        /// <returns><see cref="CreateTopicResponse"/></returns>
        public Task<CreateTopicResponse> CreateTopic(CreateTopicRequest req)
        {
            return InternalRequestAsync<CreateTopicResponse>(req, "CreateTopic");
        }

        /// <summary>
        /// This API is used to create a topic with the full-text index and key-value index enabled by default. The creation will fail if there is no CLB exclusive logset.
        /// </summary>
        /// <param name="req"><see cref="CreateTopicRequest"/></param>
        /// <returns><see cref="CreateTopicResponse"/></returns>
        public CreateTopicResponse CreateTopicSync(CreateTopicRequest req)
        {
            return InternalRequestAsync<CreateTopicResponse>(req, "CreateTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a listener from a CLB instance (layer-4 or layer-7).
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="DeleteListenerRequest"/></param>
        /// <returns><see cref="DeleteListenerResponse"/></returns>
        public Task<DeleteListenerResponse> DeleteListener(DeleteListenerRequest req)
        {
            return InternalRequestAsync<DeleteListenerResponse>(req, "DeleteListener");
        }

        /// <summary>
        /// This API is used to delete a listener from a CLB instance (layer-4 or layer-7).
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="DeleteListenerRequest"/></param>
        /// <returns><see cref="DeleteListenerResponse"/></returns>
        public DeleteListenerResponse DeleteListenerSync(DeleteListenerRequest req)
        {
            return InternalRequestAsync<DeleteListenerResponse>(req, "DeleteListener")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete one or more specified CLB instances. After successful deletion, the listeners and forwarding rules under the CLB instance will be deleted together, and the backend service will be unbound.
        /// This API is asynchronous. After it returns the result successfully, you can call the [DescribeTaskStatus](https://www.tencentcloud.comom/document/product/214/30683?from_cn_redirect=1) API with the returned RequestId as an input parameter to query whether the task is successful.
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerResponse"/></returns>
        public Task<DeleteLoadBalancerResponse> DeleteLoadBalancer(DeleteLoadBalancerRequest req)
        {
            return InternalRequestAsync<DeleteLoadBalancerResponse>(req, "DeleteLoadBalancer");
        }

        /// <summary>
        /// This API is used to delete one or more specified CLB instances. After successful deletion, the listeners and forwarding rules under the CLB instance will be deleted together, and the backend service will be unbound.
        /// This API is asynchronous. After it returns the result successfully, you can call the [DescribeTaskStatus](https://www.tencentcloud.comom/document/product/214/30683?from_cn_redirect=1) API with the returned RequestId as an input parameter to query whether the task is successful.
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerResponse"/></returns>
        public DeleteLoadBalancerResponse DeleteLoadBalancerSync(DeleteLoadBalancerRequest req)
        {
            return InternalRequestAsync<DeleteLoadBalancerResponse>(req, "DeleteLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete multiple listeners of a CLB instance.
        /// This is an async API. After it is returned successfully, you can call the `DescribeTaskStatus` API with the returned `RequestID` as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerListenersRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerListenersResponse"/></returns>
        public Task<DeleteLoadBalancerListenersResponse> DeleteLoadBalancerListeners(DeleteLoadBalancerListenersRequest req)
        {
            return InternalRequestAsync<DeleteLoadBalancerListenersResponse>(req, "DeleteLoadBalancerListeners");
        }

        /// <summary>
        /// This API is used to delete multiple listeners of a CLB instance.
        /// This is an async API. After it is returned successfully, you can call the `DescribeTaskStatus` API with the returned `RequestID` as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerListenersRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerListenersResponse"/></returns>
        public DeleteLoadBalancerListenersResponse DeleteLoadBalancerListenersSync(DeleteLoadBalancerListenersRequest req)
        {
            return InternalRequestAsync<DeleteLoadBalancerListenersResponse>(req, "DeleteLoadBalancerListeners")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the SNAT IP for an SnatPro CLB instance.
        /// This is an async API. After it is returned successfully, you can check the task result by calling `DescribeTaskStatus` with the returned `RequestID`.
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerSnatIpsRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerSnatIpsResponse"/></returns>
        public Task<DeleteLoadBalancerSnatIpsResponse> DeleteLoadBalancerSnatIps(DeleteLoadBalancerSnatIpsRequest req)
        {
            return InternalRequestAsync<DeleteLoadBalancerSnatIpsResponse>(req, "DeleteLoadBalancerSnatIps");
        }

        /// <summary>
        /// This API is used to delete the SNAT IP for an SnatPro CLB instance.
        /// This is an async API. After it is returned successfully, you can check the task result by calling `DescribeTaskStatus` with the returned `RequestID`.
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerSnatIpsRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerSnatIpsResponse"/></returns>
        public DeleteLoadBalancerSnatIpsResponse DeleteLoadBalancerSnatIpsSync(DeleteLoadBalancerSnatIpsRequest req)
        {
            return InternalRequestAsync<DeleteLoadBalancerSnatIpsResponse>(req, "DeleteLoadBalancerSnatIps")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DeleteRewrite) is used to delete the redirection relationship between the specified forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteRewriteRequest"/></param>
        /// <returns><see cref="DeleteRewriteResponse"/></returns>
        public Task<DeleteRewriteResponse> DeleteRewrite(DeleteRewriteRequest req)
        {
            return InternalRequestAsync<DeleteRewriteResponse>(req, "DeleteRewrite");
        }

        /// <summary>
        /// This API (DeleteRewrite) is used to delete the redirection relationship between the specified forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteRewriteRequest"/></param>
        /// <returns><see cref="DeleteRewriteResponse"/></returns>
        public DeleteRewriteResponse DeleteRewriteSync(DeleteRewriteRequest req)
        {
            return InternalRequestAsync<DeleteRewriteResponse>(req, "DeleteRewrite")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DeleteRule) is used to delete a forwarding rule under a layer-7 CLB instance listener
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="DeleteRuleRequest"/></param>
        /// <returns><see cref="DeleteRuleResponse"/></returns>
        public Task<DeleteRuleResponse> DeleteRule(DeleteRuleRequest req)
        {
            return InternalRequestAsync<DeleteRuleResponse>(req, "DeleteRule");
        }

        /// <summary>
        /// This API (DeleteRule) is used to delete a forwarding rule under a layer-7 CLB instance listener
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="DeleteRuleRequest"/></param>
        /// <returns><see cref="DeleteRuleResponse"/></returns>
        public DeleteRuleResponse DeleteRuleSync(DeleteRuleRequest req)
        {
            return InternalRequestAsync<DeleteRuleResponse>(req, "DeleteRule")
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
        /// This API is used to unbind a SCF function with a CLB forwarding rule. For L7 listeners, you need to specify the forwarding rule by using `LocationId` or `Domain+Url`. 
        /// This is an async API. After it is returned successfully, you can call the [DescribeTaskStatus](https://intl.cloud.tencent.com/document/product/214/30683?from_cn_redirect=1) API with the returned RequestID to check whether this task is successful.
        /// <br/>Limits: 
        /// 
        /// - Binding with SCF is only available in Guangzhou, Shenzhen Finance, Shanghai, Shanghai Finance, Beijing, Chengdu, Hong Kong (China), Singapore, Mumbai, Tokyo, and Silicon Valley.
        /// - SCF functions can only be bound with CLB instances of bill-by-IP accounts but not with bill-by-CVM accounts. If you are using a bill-by-CVM account, we recommend upgrading it to a bill-by-IP account. 
        /// - SCF functions cannot be bound with classic CLB instances.
        /// - SCF functions cannot be bound with classic network-based CLB instances.
        /// - SCF functions in the same region can be bound with CLB instances. SCF functions can only be bound across VPCs but not regions.
        /// - SCF functions can only be bound with IPv4 and IPv6 NAT64 CLB instances, but currently not with IPv6 CLB instances.
        /// - SCF functions can only be bound with layer-7 HTTP and HTTPS listeners, but not with layer-7 QUIC listeners or layer-4 (TCP, UDP, and TCP SSL) listeners.
        /// - Only SCF event-triggered functions can be bound with CLB instances.
        /// </summary>
        /// <param name="req"><see cref="DeregisterFunctionTargetsRequest"/></param>
        /// <returns><see cref="DeregisterFunctionTargetsResponse"/></returns>
        public Task<DeregisterFunctionTargetsResponse> DeregisterFunctionTargets(DeregisterFunctionTargetsRequest req)
        {
            return InternalRequestAsync<DeregisterFunctionTargetsResponse>(req, "DeregisterFunctionTargets");
        }

        /// <summary>
        /// This API is used to unbind a SCF function with a CLB forwarding rule. For L7 listeners, you need to specify the forwarding rule by using `LocationId` or `Domain+Url`. 
        /// This is an async API. After it is returned successfully, you can call the [DescribeTaskStatus](https://intl.cloud.tencent.com/document/product/214/30683?from_cn_redirect=1) API with the returned RequestID to check whether this task is successful.
        /// <br/>Limits: 
        /// 
        /// - Binding with SCF is only available in Guangzhou, Shenzhen Finance, Shanghai, Shanghai Finance, Beijing, Chengdu, Hong Kong (China), Singapore, Mumbai, Tokyo, and Silicon Valley.
        /// - SCF functions can only be bound with CLB instances of bill-by-IP accounts but not with bill-by-CVM accounts. If you are using a bill-by-CVM account, we recommend upgrading it to a bill-by-IP account. 
        /// - SCF functions cannot be bound with classic CLB instances.
        /// - SCF functions cannot be bound with classic network-based CLB instances.
        /// - SCF functions in the same region can be bound with CLB instances. SCF functions can only be bound across VPCs but not regions.
        /// - SCF functions can only be bound with IPv4 and IPv6 NAT64 CLB instances, but currently not with IPv6 CLB instances.
        /// - SCF functions can only be bound with layer-7 HTTP and HTTPS listeners, but not with layer-7 QUIC listeners or layer-4 (TCP, UDP, and TCP SSL) listeners.
        /// - Only SCF event-triggered functions can be bound with CLB instances.
        /// </summary>
        /// <param name="req"><see cref="DeregisterFunctionTargetsRequest"/></param>
        /// <returns><see cref="DeregisterFunctionTargetsResponse"/></returns>
        public DeregisterFunctionTargetsResponse DeregisterFunctionTargetsSync(DeregisterFunctionTargetsRequest req)
        {
            return InternalRequestAsync<DeregisterFunctionTargetsResponse>(req, "DeregisterFunctionTargets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind a server from a target group.
        /// This is an async API. After it is returned successfully, you can call the API `DescribeTaskStatus` with the returned RequestId as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="DeregisterTargetGroupInstancesRequest"/></param>
        /// <returns><see cref="DeregisterTargetGroupInstancesResponse"/></returns>
        public Task<DeregisterTargetGroupInstancesResponse> DeregisterTargetGroupInstances(DeregisterTargetGroupInstancesRequest req)
        {
            return InternalRequestAsync<DeregisterTargetGroupInstancesResponse>(req, "DeregisterTargetGroupInstances");
        }

        /// <summary>
        /// This API is used to unbind a server from a target group.
        /// This is an async API. After it is returned successfully, you can call the API `DescribeTaskStatus` with the returned RequestId as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="DeregisterTargetGroupInstancesRequest"/></param>
        /// <returns><see cref="DeregisterTargetGroupInstancesResponse"/></returns>
        public DeregisterTargetGroupInstancesResponse DeregisterTargetGroupInstancesSync(DeregisterTargetGroupInstancesRequest req)
        {
            return InternalRequestAsync<DeregisterTargetGroupInstancesResponse>(req, "DeregisterTargetGroupInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DeregisterTargets) is used to unbind one or more real servers from a CLB listener or forwarding rule. For layer-4 listeners, only the listener ID needs to be specified. For layer-7 listeners, the forwarding rule also needs to be specified through LocationId or Domain+Url.
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="DeregisterTargetsRequest"/></param>
        /// <returns><see cref="DeregisterTargetsResponse"/></returns>
        public Task<DeregisterTargetsResponse> DeregisterTargets(DeregisterTargetsRequest req)
        {
            return InternalRequestAsync<DeregisterTargetsResponse>(req, "DeregisterTargets");
        }

        /// <summary>
        /// This API (DeregisterTargets) is used to unbind one or more real servers from a CLB listener or forwarding rule. For layer-4 listeners, only the listener ID needs to be specified. For layer-7 listeners, the forwarding rule also needs to be specified through LocationId or Domain+Url.
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="DeregisterTargetsRequest"/></param>
        /// <returns><see cref="DeregisterTargetsResponse"/></returns>
        public DeregisterTargetsResponse DeregisterTargetsSync(DeregisterTargetsRequest req)
        {
            return InternalRequestAsync<DeregisterTargetsResponse>(req, "DeregisterTargets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind a CLB real server. This is an async API. After it is returned successfully, you can call the API `DescribeTaskStatus` with the returned RequestId as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="DeregisterTargetsFromClassicalLBRequest"/></param>
        /// <returns><see cref="DeregisterTargetsFromClassicalLBResponse"/></returns>
        public Task<DeregisterTargetsFromClassicalLBResponse> DeregisterTargetsFromClassicalLB(DeregisterTargetsFromClassicalLBRequest req)
        {
            return InternalRequestAsync<DeregisterTargetsFromClassicalLBResponse>(req, "DeregisterTargetsFromClassicalLB");
        }

        /// <summary>
        /// This API is used to unbind a CLB real server. This is an async API. After it is returned successfully, you can call the API `DescribeTaskStatus` with the returned RequestId as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="DeregisterTargetsFromClassicalLBRequest"/></param>
        /// <returns><see cref="DeregisterTargetsFromClassicalLBResponse"/></returns>
        public DeregisterTargetsFromClassicalLBResponse DeregisterTargetsFromClassicalLBSync(DeregisterTargetsFromClassicalLBRequest req)
        {
            return InternalRequestAsync<DeregisterTargetsFromClassicalLBResponse>(req, "DeregisterTargetsFromClassicalLB")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of blocked IPs (blocklist) of a CLB instance. (This API is in beta test. To use it, please submit a ticket.)
        /// </summary>
        /// <param name="req"><see cref="DescribeBlockIPListRequest"/></param>
        /// <returns><see cref="DescribeBlockIPListResponse"/></returns>
        public Task<DescribeBlockIPListResponse> DescribeBlockIPList(DescribeBlockIPListRequest req)
        {
            return InternalRequestAsync<DescribeBlockIPListResponse>(req, "DescribeBlockIPList");
        }

        /// <summary>
        /// This API is used to query the list of blocked IPs (blocklist) of a CLB instance. (This API is in beta test. To use it, please submit a ticket.)
        /// </summary>
        /// <param name="req"><see cref="DescribeBlockIPListRequest"/></param>
        /// <returns><see cref="DescribeBlockIPListResponse"/></returns>
        public DescribeBlockIPListResponse DescribeBlockIPListSync(DescribeBlockIPListRequest req)
        {
            return InternalRequestAsync<DescribeBlockIPListResponse>(req, "DescribeBlockIPList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the execution status of an async IP blocking (blocklisting) task by the async task ID returned by the `ModifyBlockIPList` API. (This API is in beta test. To use it, please submit a ticket.)
        /// </summary>
        /// <param name="req"><see cref="DescribeBlockIPTaskRequest"/></param>
        /// <returns><see cref="DescribeBlockIPTaskResponse"/></returns>
        public Task<DescribeBlockIPTaskResponse> DescribeBlockIPTask(DescribeBlockIPTaskRequest req)
        {
            return InternalRequestAsync<DescribeBlockIPTaskResponse>(req, "DescribeBlockIPTask");
        }

        /// <summary>
        /// This API is used to query the execution status of an async IP blocking (blocklisting) task by the async task ID returned by the `ModifyBlockIPList` API. (This API is in beta test. To use it, please submit a ticket.)
        /// </summary>
        /// <param name="req"><see cref="DescribeBlockIPTaskRequest"/></param>
        /// <returns><see cref="DescribeBlockIPTaskResponse"/></returns>
        public DescribeBlockIPTaskResponse DescribeBlockIPTaskSync(DescribeBlockIPTaskRequest req)
        {
            return InternalRequestAsync<DescribeBlockIPTaskResponse>(req, "DescribeBlockIPTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of classic CLB instance IDs through a real server ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeClassicalLBByInstanceIdRequest"/></param>
        /// <returns><see cref="DescribeClassicalLBByInstanceIdResponse"/></returns>
        public Task<DescribeClassicalLBByInstanceIdResponse> DescribeClassicalLBByInstanceId(DescribeClassicalLBByInstanceIdRequest req)
        {
            return InternalRequestAsync<DescribeClassicalLBByInstanceIdResponse>(req, "DescribeClassicalLBByInstanceId");
        }

        /// <summary>
        /// This API is used to get the list of classic CLB instance IDs through a real server ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeClassicalLBByInstanceIdRequest"/></param>
        /// <returns><see cref="DescribeClassicalLBByInstanceIdResponse"/></returns>
        public DescribeClassicalLBByInstanceIdResponse DescribeClassicalLBByInstanceIdSync(DescribeClassicalLBByInstanceIdRequest req)
        {
            return InternalRequestAsync<DescribeClassicalLBByInstanceIdResponse>(req, "DescribeClassicalLBByInstanceId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeClassicalLBHealthStatus) is used to get the real server health status of a classic CLB
        /// </summary>
        /// <param name="req"><see cref="DescribeClassicalLBHealthStatusRequest"/></param>
        /// <returns><see cref="DescribeClassicalLBHealthStatusResponse"/></returns>
        public Task<DescribeClassicalLBHealthStatusResponse> DescribeClassicalLBHealthStatus(DescribeClassicalLBHealthStatusRequest req)
        {
            return InternalRequestAsync<DescribeClassicalLBHealthStatusResponse>(req, "DescribeClassicalLBHealthStatus");
        }

        /// <summary>
        /// This API (DescribeClassicalLBHealthStatus) is used to get the real server health status of a classic CLB
        /// </summary>
        /// <param name="req"><see cref="DescribeClassicalLBHealthStatusRequest"/></param>
        /// <returns><see cref="DescribeClassicalLBHealthStatusResponse"/></returns>
        public DescribeClassicalLBHealthStatusResponse DescribeClassicalLBHealthStatusSync(DescribeClassicalLBHealthStatusRequest req)
        {
            return InternalRequestAsync<DescribeClassicalLBHealthStatusResponse>(req, "DescribeClassicalLBHealthStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeClassicalLBListeners) is used to get the listener information of a classic CLB.
        /// </summary>
        /// <param name="req"><see cref="DescribeClassicalLBListenersRequest"/></param>
        /// <returns><see cref="DescribeClassicalLBListenersResponse"/></returns>
        public Task<DescribeClassicalLBListenersResponse> DescribeClassicalLBListeners(DescribeClassicalLBListenersRequest req)
        {
            return InternalRequestAsync<DescribeClassicalLBListenersResponse>(req, "DescribeClassicalLBListeners");
        }

        /// <summary>
        /// This API (DescribeClassicalLBListeners) is used to get the listener information of a classic CLB.
        /// </summary>
        /// <param name="req"><see cref="DescribeClassicalLBListenersRequest"/></param>
        /// <returns><see cref="DescribeClassicalLBListenersResponse"/></returns>
        public DescribeClassicalLBListenersResponse DescribeClassicalLBListenersSync(DescribeClassicalLBListenersRequest req)
        {
            return InternalRequestAsync<DescribeClassicalLBListenersResponse>(req, "DescribeClassicalLBListeners")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the real servers bound to a classic CLB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeClassicalLBTargetsRequest"/></param>
        /// <returns><see cref="DescribeClassicalLBTargetsResponse"/></returns>
        public Task<DescribeClassicalLBTargetsResponse> DescribeClassicalLBTargets(DescribeClassicalLBTargetsRequest req)
        {
            return InternalRequestAsync<DescribeClassicalLBTargetsResponse>(req, "DescribeClassicalLBTargets");
        }

        /// <summary>
        /// This API is used to get the real servers bound to a classic CLB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeClassicalLBTargetsRequest"/></param>
        /// <returns><see cref="DescribeClassicalLBTargetsResponse"/></returns>
        public DescribeClassicalLBTargetsResponse DescribeClassicalLBTargetsSync(DescribeClassicalLBTargetsRequest req)
        {
            return InternalRequestAsync<DescribeClassicalLBTargetsResponse>(req, "DescribeClassicalLBTargets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the CLB exclusive logset.
        /// </summary>
        /// <param name="req"><see cref="DescribeClsLogSetRequest"/></param>
        /// <returns><see cref="DescribeClsLogSetResponse"/></returns>
        public Task<DescribeClsLogSetResponse> DescribeClsLogSet(DescribeClsLogSetRequest req)
        {
            return InternalRequestAsync<DescribeClsLogSetResponse>(req, "DescribeClsLogSet");
        }

        /// <summary>
        /// This API is used to get the CLB exclusive logset.
        /// </summary>
        /// <param name="req"><see cref="DescribeClsLogSetRequest"/></param>
        /// <returns><see cref="DescribeClsLogSetResponse"/></returns>
        public DescribeClsLogSetResponse DescribeClsLogSetSync(DescribeClsLogSetRequest req)
        {
            return InternalRequestAsync<DescribeClsLogSetResponse>(req, "DescribeClsLogSet")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries information of CVMs and ENIs that use cross-region binding 2.0
        /// </summary>
        /// <param name="req"><see cref="DescribeCrossTargetsRequest"/></param>
        /// <returns><see cref="DescribeCrossTargetsResponse"/></returns>
        public Task<DescribeCrossTargetsResponse> DescribeCrossTargets(DescribeCrossTargetsRequest req)
        {
            return InternalRequestAsync<DescribeCrossTargetsResponse>(req, "DescribeCrossTargets");
        }

        /// <summary>
        /// Queries information of CVMs and ENIs that use cross-region binding 2.0
        /// </summary>
        /// <param name="req"><see cref="DescribeCrossTargetsRequest"/></param>
        /// <returns><see cref="DescribeCrossTargetsResponse"/></returns>
        public DescribeCrossTargetsResponse DescribeCrossTargetsSync(DescribeCrossTargetsRequest req)
        {
            return InternalRequestAsync<DescribeCrossTargetsResponse>(req, "DescribeCrossTargets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the configured location, bound server or bound CLB instance. If there are domain names, the result will be filtered by domain name.
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomizedConfigAssociateListRequest"/></param>
        /// <returns><see cref="DescribeCustomizedConfigAssociateListResponse"/></returns>
        public Task<DescribeCustomizedConfigAssociateListResponse> DescribeCustomizedConfigAssociateList(DescribeCustomizedConfigAssociateListRequest req)
        {
            return InternalRequestAsync<DescribeCustomizedConfigAssociateListResponse>(req, "DescribeCustomizedConfigAssociateList");
        }

        /// <summary>
        /// This API is used to query the configured location, bound server or bound CLB instance. If there are domain names, the result will be filtered by domain name.
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomizedConfigAssociateListRequest"/></param>
        /// <returns><see cref="DescribeCustomizedConfigAssociateListResponse"/></returns>
        public DescribeCustomizedConfigAssociateListResponse DescribeCustomizedConfigAssociateListSync(DescribeCustomizedConfigAssociateListRequest req)
        {
            return InternalRequestAsync<DescribeCustomizedConfigAssociateListResponse>(req, "DescribeCustomizedConfigAssociateList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to pull custom configuration lists to return the user configuration of `AppId`.
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomizedConfigListRequest"/></param>
        /// <returns><see cref="DescribeCustomizedConfigListResponse"/></returns>
        public Task<DescribeCustomizedConfigListResponse> DescribeCustomizedConfigList(DescribeCustomizedConfigListRequest req)
        {
            return InternalRequestAsync<DescribeCustomizedConfigListResponse>(req, "DescribeCustomizedConfigList");
        }

        /// <summary>
        /// This API is used to pull custom configuration lists to return the user configuration of `AppId`.
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomizedConfigListRequest"/></param>
        /// <returns><see cref="DescribeCustomizedConfigListResponse"/></returns>
        public DescribeCustomizedConfigListResponse DescribeCustomizedConfigListSync(DescribeCustomizedConfigListRequest req)
        {
            return InternalRequestAsync<DescribeCustomizedConfigListResponse>(req, "DescribeCustomizedConfigList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Idle CLB instances are pay-as-you-go load balancers that, within seven days after the creation, do not have rules configured or the configured rules are not associated with any servers. 
        /// </summary>
        /// <param name="req"><see cref="DescribeIdleLoadBalancersRequest"/></param>
        /// <returns><see cref="DescribeIdleLoadBalancersResponse"/></returns>
        public Task<DescribeIdleLoadBalancersResponse> DescribeIdleLoadBalancers(DescribeIdleLoadBalancersRequest req)
        {
            return InternalRequestAsync<DescribeIdleLoadBalancersResponse>(req, "DescribeIdleLoadBalancers");
        }

        /// <summary>
        /// Idle CLB instances are pay-as-you-go load balancers that, within seven days after the creation, do not have rules configured or the configured rules are not associated with any servers. 
        /// </summary>
        /// <param name="req"><see cref="DescribeIdleLoadBalancersRequest"/></param>
        /// <returns><see cref="DescribeIdleLoadBalancersResponse"/></returns>
        public DescribeIdleLoadBalancersResponse DescribeIdleLoadBalancersSync(DescribeIdleLoadBalancersRequest req)
        {
            return InternalRequestAsync<DescribeIdleLoadBalancersResponse>(req, "DescribeIdleLoadBalancers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query CLB instances bound to the CVM or ENI.
        /// </summary>
        /// <param name="req"><see cref="DescribeLBListenersRequest"/></param>
        /// <returns><see cref="DescribeLBListenersResponse"/></returns>
        public Task<DescribeLBListenersResponse> DescribeLBListeners(DescribeLBListenersRequest req)
        {
            return InternalRequestAsync<DescribeLBListenersResponse>(req, "DescribeLBListeners");
        }

        /// <summary>
        /// This API is used to query CLB instances bound to the CVM or ENI.
        /// </summary>
        /// <param name="req"><see cref="DescribeLBListenersRequest"/></param>
        /// <returns><see cref="DescribeLBListenersResponse"/></returns>
        public DescribeLBListenersResponse DescribeLBListenersSync(DescribeLBListenersRequest req)
        {
            return InternalRequestAsync<DescribeLBListenersResponse>(req, "DescribeLBListeners")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of listeners by CLB ID, listener protocol, or listener port. If no filter is specified, all listeners for the CLB instance will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeListenersRequest"/></param>
        /// <returns><see cref="DescribeListenersResponse"/></returns>
        public Task<DescribeListenersResponse> DescribeListeners(DescribeListenersRequest req)
        {
            return InternalRequestAsync<DescribeListenersResponse>(req, "DescribeListeners");
        }

        /// <summary>
        /// This API is used to get the list of listeners by CLB ID, listener protocol, or listener port. If no filter is specified, all listeners for the CLB instance will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeListenersRequest"/></param>
        /// <returns><see cref="DescribeListenersResponse"/></returns>
        public DescribeListenersResponse DescribeListenersSync(DescribeListenersRequest req)
        {
            return InternalRequestAsync<DescribeListenersResponse>(req, "DescribeListeners")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of CLB instances associated with a certificate in a region by certificate ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancerListByCertIdRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancerListByCertIdResponse"/></returns>
        public Task<DescribeLoadBalancerListByCertIdResponse> DescribeLoadBalancerListByCertId(DescribeLoadBalancerListByCertIdRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancerListByCertIdResponse>(req, "DescribeLoadBalancerListByCertId");
        }

        /// <summary>
        /// This API is used to query the list of CLB instances associated with a certificate in a region by certificate ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancerListByCertIdRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancerListByCertIdResponse"/></returns>
        public DescribeLoadBalancerListByCertIdResponse DescribeLoadBalancerListByCertIdSync(DescribeLoadBalancerListByCertIdRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancerListByCertIdResponse>(req, "DescribeLoadBalancerListByCertId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the total number of CLB instances and the number of CLB instances in different status (running, isolated and about to expire).
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancerOverviewRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancerOverviewResponse"/></returns>
        public Task<DescribeLoadBalancerOverviewResponse> DescribeLoadBalancerOverview(DescribeLoadBalancerOverviewRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancerOverviewResponse>(req, "DescribeLoadBalancerOverview");
        }

        /// <summary>
        /// Queries the total number of CLB instances and the number of CLB instances in different status (running, isolated and about to expire).
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancerOverviewRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancerOverviewResponse"/></returns>
        public DescribeLoadBalancerOverviewResponse DescribeLoadBalancerOverviewSync(DescribeLoadBalancerOverviewRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancerOverviewResponse>(req, "DescribeLoadBalancerOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query CLB instances with high traffic under the current account, and return the top 10 results. For queries using a sub-account, only the CLB instances authorized to the sub-account will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancerTrafficRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancerTrafficResponse"/></returns>
        public Task<DescribeLoadBalancerTrafficResponse> DescribeLoadBalancerTraffic(DescribeLoadBalancerTrafficRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancerTrafficResponse>(req, "DescribeLoadBalancerTraffic");
        }

        /// <summary>
        /// This API is used to query CLB instances with high traffic under the current account, and return the top 10 results. For queries using a sub-account, only the CLB instances authorized to the sub-account will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancerTrafficRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancerTrafficResponse"/></returns>
        public DescribeLoadBalancerTrafficResponse DescribeLoadBalancerTrafficSync(DescribeLoadBalancerTrafficRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancerTrafficResponse>(req, "DescribeLoadBalancerTraffic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of CLB instances in a region.
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancersRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancersResponse"/></returns>
        public Task<DescribeLoadBalancersResponse> DescribeLoadBalancers(DescribeLoadBalancersRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancersResponse>(req, "DescribeLoadBalancers");
        }

        /// <summary>
        /// This API is used to query the list of CLB instances in a region.
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancersRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancersResponse"/></returns>
        public DescribeLoadBalancersResponse DescribeLoadBalancersSync(DescribeLoadBalancersRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancersResponse>(req, "DescribeLoadBalancers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query CLB instance details, including listener, rules, and target real servers.
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancersDetailRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancersDetailResponse"/></returns>
        public Task<DescribeLoadBalancersDetailResponse> DescribeLoadBalancersDetail(DescribeLoadBalancersDetailRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancersDetailResponse>(req, "DescribeLoadBalancersDetail");
        }

        /// <summary>
        /// This API is used to query CLB instance details, including listener, rules, and target real servers.
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancersDetailRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancersDetailResponse"/></returns>
        public DescribeLoadBalancersDetailResponse DescribeLoadBalancersDetailSync(DescribeLoadBalancersDetailRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancersDetailResponse>(req, "DescribeLoadBalancersDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query various quotas in the current region.
        /// </summary>
        /// <param name="req"><see cref="DescribeQuotaRequest"/></param>
        /// <returns><see cref="DescribeQuotaResponse"/></returns>
        public Task<DescribeQuotaResponse> DescribeQuota(DescribeQuotaRequest req)
        {
            return InternalRequestAsync<DescribeQuotaResponse>(req, "DescribeQuota");
        }

        /// <summary>
        /// This API is used to query various quotas in the current region.
        /// </summary>
        /// <param name="req"><see cref="DescribeQuotaRequest"/></param>
        /// <returns><see cref="DescribeQuotaResponse"/></returns>
        public DescribeQuotaResponse DescribeQuotaSync(DescribeQuotaRequest req)
        {
            return InternalRequestAsync<DescribeQuotaResponse>(req, "DescribeQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of AZs and resources supported for the user in the current region.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcesRequest"/></param>
        /// <returns><see cref="DescribeResourcesResponse"/></returns>
        public Task<DescribeResourcesResponse> DescribeResources(DescribeResourcesRequest req)
        {
            return InternalRequestAsync<DescribeResourcesResponse>(req, "DescribeResources");
        }

        /// <summary>
        /// This API is used to query the list of AZs and resources supported for the user in the current region.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcesRequest"/></param>
        /// <returns><see cref="DescribeResourcesResponse"/></returns>
        public DescribeResourcesResponse DescribeResourcesSync(DescribeResourcesRequest req)
        {
            return InternalRequestAsync<DescribeResourcesResponse>(req, "DescribeResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeRewrite) is used to query the redirection relationship between the forwarding rules of a CLB instance by instance ID. If no listener ID or forwarding rule ID is specified, all redirection relationships in the instance will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeRewriteRequest"/></param>
        /// <returns><see cref="DescribeRewriteResponse"/></returns>
        public Task<DescribeRewriteResponse> DescribeRewrite(DescribeRewriteRequest req)
        {
            return InternalRequestAsync<DescribeRewriteResponse>(req, "DescribeRewrite");
        }

        /// <summary>
        /// This API (DescribeRewrite) is used to query the redirection relationship between the forwarding rules of a CLB instance by instance ID. If no listener ID or forwarding rule ID is specified, all redirection relationships in the instance will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeRewriteRequest"/></param>
        /// <returns><see cref="DescribeRewriteResponse"/></returns>
        public DescribeRewriteResponse DescribeRewriteSync(DescribeRewriteRequest req)
        {
            return InternalRequestAsync<DescribeRewriteResponse>(req, "DescribeRewrite")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the information of servers bound to a target group.
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupInstancesRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupInstancesResponse"/></returns>
        public Task<DescribeTargetGroupInstancesResponse> DescribeTargetGroupInstances(DescribeTargetGroupInstancesRequest req)
        {
            return InternalRequestAsync<DescribeTargetGroupInstancesResponse>(req, "DescribeTargetGroupInstances");
        }

        /// <summary>
        /// This API is used to get the information of servers bound to a target group.
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupInstancesRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupInstancesResponse"/></returns>
        public DescribeTargetGroupInstancesResponse DescribeTargetGroupInstancesSync(DescribeTargetGroupInstancesRequest req)
        {
            return InternalRequestAsync<DescribeTargetGroupInstancesResponse>(req, "DescribeTargetGroupInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the target group list.
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupListRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupListResponse"/></returns>
        public Task<DescribeTargetGroupListResponse> DescribeTargetGroupList(DescribeTargetGroupListRequest req)
        {
            return InternalRequestAsync<DescribeTargetGroupListResponse>(req, "DescribeTargetGroupList");
        }

        /// <summary>
        /// This API is used to get the target group list.
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupListRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupListResponse"/></returns>
        public DescribeTargetGroupListResponse DescribeTargetGroupListSync(DescribeTargetGroupListRequest req)
        {
            return InternalRequestAsync<DescribeTargetGroupListResponse>(req, "DescribeTargetGroupList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the target group information.
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupsRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupsResponse"/></returns>
        public Task<DescribeTargetGroupsResponse> DescribeTargetGroups(DescribeTargetGroupsRequest req)
        {
            return InternalRequestAsync<DescribeTargetGroupsResponse>(req, "DescribeTargetGroups");
        }

        /// <summary>
        /// This API is used to query the target group information.
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupsRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupsResponse"/></returns>
        public DescribeTargetGroupsResponse DescribeTargetGroupsSync(DescribeTargetGroupsRequest req)
        {
            return InternalRequestAsync<DescribeTargetGroupsResponse>(req, "DescribeTargetGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeTargetHealth) is used to query the health check result of a real server of a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetHealthRequest"/></param>
        /// <returns><see cref="DescribeTargetHealthResponse"/></returns>
        public Task<DescribeTargetHealthResponse> DescribeTargetHealth(DescribeTargetHealthRequest req)
        {
            return InternalRequestAsync<DescribeTargetHealthResponse>(req, "DescribeTargetHealth");
        }

        /// <summary>
        /// This API (DescribeTargetHealth) is used to query the health check result of a real server of a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetHealthRequest"/></param>
        /// <returns><see cref="DescribeTargetHealthResponse"/></returns>
        public DescribeTargetHealthResponse DescribeTargetHealthSync(DescribeTargetHealthRequest req)
        {
            return InternalRequestAsync<DescribeTargetHealthResponse>(req, "DescribeTargetHealth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeTargets) is used to query the list of real servers bound to some listeners of a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetsRequest"/></param>
        /// <returns><see cref="DescribeTargetsResponse"/></returns>
        public Task<DescribeTargetsResponse> DescribeTargets(DescribeTargetsRequest req)
        {
            return InternalRequestAsync<DescribeTargetsResponse>(req, "DescribeTargets");
        }

        /// <summary>
        /// This API (DescribeTargets) is used to query the list of real servers bound to some listeners of a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetsRequest"/></param>
        /// <returns><see cref="DescribeTargetsResponse"/></returns>
        public DescribeTargetsResponse DescribeTargetsSync(DescribeTargetsRequest req)
        {
            return InternalRequestAsync<DescribeTargetsResponse>(req, "DescribeTargets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the execution status of an async task. After non-query APIs (used to create/delete CLB instances, listeners, or rules or to bind/unbind real servers) are called successfully, this API needs to be used to query whether the task is successful.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskStatusResponse"/></returns>
        public Task<DescribeTaskStatusResponse> DescribeTaskStatus(DescribeTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeTaskStatusResponse>(req, "DescribeTaskStatus");
        }

        /// <summary>
        /// This API is used to query the execution status of an async task. After non-query APIs (used to create/delete CLB instances, listeners, or rules or to bind/unbind real servers) are called successfully, this API needs to be used to query whether the task is successful.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskStatusResponse"/></returns>
        public DescribeTaskStatusResponse DescribeTaskStatusSync(DescribeTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeTaskStatusResponse>(req, "DescribeTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind target groups from a rule.
        /// This is an async API. After it is returned successfully, you can call the `DescribeTaskStatus` API with the returned `RequestID` as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="DisassociateTargetGroupsRequest"/></param>
        /// <returns><see cref="DisassociateTargetGroupsResponse"/></returns>
        public Task<DisassociateTargetGroupsResponse> DisassociateTargetGroups(DisassociateTargetGroupsRequest req)
        {
            return InternalRequestAsync<DisassociateTargetGroupsResponse>(req, "DisassociateTargetGroups");
        }

        /// <summary>
        /// This API is used to unbind target groups from a rule.
        /// This is an async API. After it is returned successfully, you can call the `DescribeTaskStatus` API with the returned `RequestID` as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="DisassociateTargetGroupsRequest"/></param>
        /// <returns><see cref="DisassociateTargetGroupsResponse"/></returns>
        public DisassociateTargetGroupsResponse DisassociateTargetGroupsSync(DisassociateTargetGroupsRequest req)
        {
            return InternalRequestAsync<DisassociateTargetGroupsResponse>(req, "DisassociateTargetGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the price of creating a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateLoadBalancerRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateLoadBalancerResponse"/></returns>
        public Task<InquiryPriceCreateLoadBalancerResponse> InquiryPriceCreateLoadBalancer(InquiryPriceCreateLoadBalancerRequest req)
        {
            return InternalRequestAsync<InquiryPriceCreateLoadBalancerResponse>(req, "InquiryPriceCreateLoadBalancer");
        }

        /// <summary>
        /// This API is used to query the price of creating a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateLoadBalancerRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateLoadBalancerResponse"/></returns>
        public InquiryPriceCreateLoadBalancerResponse InquiryPriceCreateLoadBalancerSync(InquiryPriceCreateLoadBalancerRequest req)
        {
            return InternalRequestAsync<InquiryPriceCreateLoadBalancerResponse>(req, "InquiryPriceCreateLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the price of adjusting the specification of a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceModifyLoadBalancerRequest"/></param>
        /// <returns><see cref="InquiryPriceModifyLoadBalancerResponse"/></returns>
        public Task<InquiryPriceModifyLoadBalancerResponse> InquiryPriceModifyLoadBalancer(InquiryPriceModifyLoadBalancerRequest req)
        {
            return InternalRequestAsync<InquiryPriceModifyLoadBalancerResponse>(req, "InquiryPriceModifyLoadBalancer");
        }

        /// <summary>
        /// This API is used to query the price of adjusting the specification of a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceModifyLoadBalancerRequest"/></param>
        /// <returns><see cref="InquiryPriceModifyLoadBalancerResponse"/></returns>
        public InquiryPriceModifyLoadBalancerResponse InquiryPriceModifyLoadBalancerSync(InquiryPriceModifyLoadBalancerRequest req)
        {
            return InternalRequestAsync<InquiryPriceModifyLoadBalancerResponse>(req, "InquiryPriceModifyLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the refund amount of returning a CLB instance. 
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRefundLoadBalancerRequest"/></param>
        /// <returns><see cref="InquiryPriceRefundLoadBalancerResponse"/></returns>
        public Task<InquiryPriceRefundLoadBalancerResponse> InquiryPriceRefundLoadBalancer(InquiryPriceRefundLoadBalancerRequest req)
        {
            return InternalRequestAsync<InquiryPriceRefundLoadBalancerResponse>(req, "InquiryPriceRefundLoadBalancer");
        }

        /// <summary>
        /// This API is used to query the refund amount of returning a CLB instance. 
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRefundLoadBalancerRequest"/></param>
        /// <returns><see cref="InquiryPriceRefundLoadBalancerResponse"/></returns>
        public InquiryPriceRefundLoadBalancerResponse InquiryPriceRefundLoadBalancerSync(InquiryPriceRefundLoadBalancerRequest req)
        {
            return InternalRequestAsync<InquiryPriceRefundLoadBalancerResponse>(req, "InquiryPriceRefundLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the price of renewing a CLB instance. It's only available to prepaid CLB instances.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRenewLoadBalancerRequest"/></param>
        /// <returns><see cref="InquiryPriceRenewLoadBalancerResponse"/></returns>
        public Task<InquiryPriceRenewLoadBalancerResponse> InquiryPriceRenewLoadBalancer(InquiryPriceRenewLoadBalancerRequest req)
        {
            return InternalRequestAsync<InquiryPriceRenewLoadBalancerResponse>(req, "InquiryPriceRenewLoadBalancer");
        }

        /// <summary>
        /// This API is used to query the price of renewing a CLB instance. It's only available to prepaid CLB instances.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRenewLoadBalancerRequest"/></param>
        /// <returns><see cref="InquiryPriceRenewLoadBalancerResponse"/></returns>
        public InquiryPriceRenewLoadBalancerResponse InquiryPriceRenewLoadBalancerSync(InquiryPriceRenewLoadBalancerRequest req)
        {
            return InternalRequestAsync<InquiryPriceRenewLoadBalancerResponse>(req, "InquiryPriceRenewLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// After the original access address and the address to be redirected are configured manually, the system will automatically redirect requests made to the original access address to the target address of the corresponding path. Multiple paths can be configured as a redirection policy under one domain name to achieve automatic redirection between HTTP and HTTPS. A redirection policy should meet the following rules: if A has already been redirected to B, then it cannot be redirected to C (unless the original redirection relationship is deleted and a new one is created), and B cannot be redirected to any other addresses.
        /// </summary>
        /// <param name="req"><see cref="ManualRewriteRequest"/></param>
        /// <returns><see cref="ManualRewriteResponse"/></returns>
        public Task<ManualRewriteResponse> ManualRewrite(ManualRewriteRequest req)
        {
            return InternalRequestAsync<ManualRewriteResponse>(req, "ManualRewrite");
        }

        /// <summary>
        /// After the original access address and the address to be redirected are configured manually, the system will automatically redirect requests made to the original access address to the target address of the corresponding path. Multiple paths can be configured as a redirection policy under one domain name to achieve automatic redirection between HTTP and HTTPS. A redirection policy should meet the following rules: if A has already been redirected to B, then it cannot be redirected to C (unless the original redirection relationship is deleted and a new one is created), and B cannot be redirected to any other addresses.
        /// </summary>
        /// <param name="req"><see cref="ManualRewriteRequest"/></param>
        /// <returns><see cref="ManualRewriteResponse"/></returns>
        public ManualRewriteResponse ManualRewriteSync(ManualRewriteRequest req)
        {
            return InternalRequestAsync<ManualRewriteResponse>(req, "ManualRewrite")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to upgrade classic CLB instances to application CLB instances.
        /// This is an async API. After it is returned successfully, you can check the action result by calling `DescribeLoadBalancers`. 
        /// </summary>
        /// <param name="req"><see cref="MigrateClassicalLoadBalancersRequest"/></param>
        /// <returns><see cref="MigrateClassicalLoadBalancersResponse"/></returns>
        public Task<MigrateClassicalLoadBalancersResponse> MigrateClassicalLoadBalancers(MigrateClassicalLoadBalancersRequest req)
        {
            return InternalRequestAsync<MigrateClassicalLoadBalancersResponse>(req, "MigrateClassicalLoadBalancers");
        }

        /// <summary>
        /// This API is used to upgrade classic CLB instances to application CLB instances.
        /// This is an async API. After it is returned successfully, you can check the action result by calling `DescribeLoadBalancers`. 
        /// </summary>
        /// <param name="req"><see cref="MigrateClassicalLoadBalancersRequest"/></param>
        /// <returns><see cref="MigrateClassicalLoadBalancersResponse"/></returns>
        public MigrateClassicalLoadBalancersResponse MigrateClassicalLoadBalancersSync(MigrateClassicalLoadBalancersRequest req)
        {
            return InternalRequestAsync<MigrateClassicalLoadBalancersResponse>(req, "MigrateClassicalLoadBalancers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the client IP blocklist of a CLB instance. One forwarding rule supports blocking up to 2,000,000 IPs. One blocklist can contain up to 2,000,000 entries.
        /// (This API is in beta test. To use it, please submit a ticket.)
        /// </summary>
        /// <param name="req"><see cref="ModifyBlockIPListRequest"/></param>
        /// <returns><see cref="ModifyBlockIPListResponse"/></returns>
        public Task<ModifyBlockIPListResponse> ModifyBlockIPList(ModifyBlockIPListRequest req)
        {
            return InternalRequestAsync<ModifyBlockIPListResponse>(req, "ModifyBlockIPList");
        }

        /// <summary>
        /// This API is used to modify the client IP blocklist of a CLB instance. One forwarding rule supports blocking up to 2,000,000 IPs. One blocklist can contain up to 2,000,000 entries.
        /// (This API is in beta test. To use it, please submit a ticket.)
        /// </summary>
        /// <param name="req"><see cref="ModifyBlockIPListRequest"/></param>
        /// <returns><see cref="ModifyBlockIPListResponse"/></returns>
        public ModifyBlockIPListResponse ModifyBlockIPListSync(ModifyBlockIPListRequest req)
        {
            return InternalRequestAsync<ModifyBlockIPListResponse>(req, "ModifyBlockIPList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyDomain) is used to modify a domain name under a layer-7 CLB listener.
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainRequest"/></param>
        /// <returns><see cref="ModifyDomainResponse"/></returns>
        public Task<ModifyDomainResponse> ModifyDomain(ModifyDomainRequest req)
        {
            return InternalRequestAsync<ModifyDomainResponse>(req, "ModifyDomain");
        }

        /// <summary>
        /// This API (ModifyDomain) is used to modify a domain name under a layer-7 CLB listener.
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainRequest"/></param>
        /// <returns><see cref="ModifyDomainResponse"/></returns>
        public ModifyDomainResponse ModifyDomainSync(ModifyDomainRequest req)
        {
            return InternalRequestAsync<ModifyDomainResponse>(req, "ModifyDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the domain name-level attributes of a layer-7 listener's forwarding rule, such as modifying the domain name, changing the DefaultServer, enabling/disabling HTTP/2, and modifying certificates.
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestId as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainAttributesRequest"/></param>
        /// <returns><see cref="ModifyDomainAttributesResponse"/></returns>
        public Task<ModifyDomainAttributesResponse> ModifyDomainAttributes(ModifyDomainAttributesRequest req)
        {
            return InternalRequestAsync<ModifyDomainAttributesResponse>(req, "ModifyDomainAttributes");
        }

        /// <summary>
        /// This API is used to modify the domain name-level attributes of a layer-7 listener's forwarding rule, such as modifying the domain name, changing the DefaultServer, enabling/disabling HTTP/2, and modifying certificates.
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestId as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainAttributesRequest"/></param>
        /// <returns><see cref="ModifyDomainAttributesResponse"/></returns>
        public ModifyDomainAttributesResponse ModifyDomainAttributesSync(ModifyDomainAttributesRequest req)
        {
            return InternalRequestAsync<ModifyDomainAttributesResponse>(req, "ModifyDomainAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the cloud functions associated with a load balancing forwarding rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyFunctionTargetsRequest"/></param>
        /// <returns><see cref="ModifyFunctionTargetsResponse"/></returns>
        public Task<ModifyFunctionTargetsResponse> ModifyFunctionTargets(ModifyFunctionTargetsRequest req)
        {
            return InternalRequestAsync<ModifyFunctionTargetsResponse>(req, "ModifyFunctionTargets");
        }

        /// <summary>
        /// This API is used to modify the cloud functions associated with a load balancing forwarding rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyFunctionTargetsRequest"/></param>
        /// <returns><see cref="ModifyFunctionTargetsResponse"/></returns>
        public ModifyFunctionTargetsResponse ModifyFunctionTargetsSync(ModifyFunctionTargetsRequest req)
        {
            return InternalRequestAsync<ModifyFunctionTargetsResponse>(req, "ModifyFunctionTargets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyListener) is used to modify the attributes of a CLB listener, such as listener name, health check parameter, certificate information, and forwarding policy.
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyListenerRequest"/></param>
        /// <returns><see cref="ModifyListenerResponse"/></returns>
        public Task<ModifyListenerResponse> ModifyListener(ModifyListenerRequest req)
        {
            return InternalRequestAsync<ModifyListenerResponse>(req, "ModifyListener");
        }

        /// <summary>
        /// This API (ModifyListener) is used to modify the attributes of a CLB listener, such as listener name, health check parameter, certificate information, and forwarding policy.
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyListenerRequest"/></param>
        /// <returns><see cref="ModifyListenerResponse"/></returns>
        public ModifyListenerResponse ModifyListenerSync(ModifyListenerRequest req)
        {
            return InternalRequestAsync<ModifyListenerResponse>(req, "ModifyListener")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the attributes of a CLB instance, such as name and cross-region attributes.
        /// 
        /// Note: For CLB instances of bill-by-CVM users, cross-region attributes can be set only after a bandwidth package is purchased.This is an asynchronous API. After it returns a result successfully, the obtained RequestID should be used as an input parameter to call the DescribeTaskStatus API, for checking whether this task succeeds.
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerAttributesRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerAttributesResponse"/></returns>
        public Task<ModifyLoadBalancerAttributesResponse> ModifyLoadBalancerAttributes(ModifyLoadBalancerAttributesRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancerAttributesResponse>(req, "ModifyLoadBalancerAttributes");
        }

        /// <summary>
        /// This API is used to modify the attributes of a CLB instance, such as name and cross-region attributes.
        /// 
        /// Note: For CLB instances of bill-by-CVM users, cross-region attributes can be set only after a bandwidth package is purchased.This is an asynchronous API. After it returns a result successfully, the obtained RequestID should be used as an input parameter to call the DescribeTaskStatus API, for checking whether this task succeeds.
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerAttributesRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerAttributesResponse"/></returns>
        public ModifyLoadBalancerAttributesResponse ModifyLoadBalancerAttributesSync(ModifyLoadBalancerAttributesRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancerAttributesResponse>(req, "ModifyLoadBalancerAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to upgrade a pay-as-you-go shared CLB instance to an LCU-supported CLB instance. <br/>
        /// Limits
        /// - This API can only be used to upgrade pay-as-you-go shared instances. To upgrade monthly-subscribed shared instances, please go to the CLB console.
        /// - An LCU-supported instance cannot be changed back to a shared instance.
        /// - Classic CLB instances cannot be upgraded to LCU-supported instances.
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerSlaRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerSlaResponse"/></returns>
        public Task<ModifyLoadBalancerSlaResponse> ModifyLoadBalancerSla(ModifyLoadBalancerSlaRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancerSlaResponse>(req, "ModifyLoadBalancerSla");
        }

        /// <summary>
        /// This API is used to upgrade a pay-as-you-go shared CLB instance to an LCU-supported CLB instance. <br/>
        /// Limits
        /// - This API can only be used to upgrade pay-as-you-go shared instances. To upgrade monthly-subscribed shared instances, please go to the CLB console.
        /// - An LCU-supported instance cannot be changed back to a shared instance.
        /// - Classic CLB instances cannot be upgraded to LCU-supported instances.
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerSlaRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerSlaResponse"/></returns>
        public ModifyLoadBalancerSlaResponse ModifyLoadBalancerSlaSync(ModifyLoadBalancerSlaRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancerSlaResponse>(req, "ModifyLoadBalancerSla")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the projects of CLB instances. 
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancersProjectRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancersProjectResponse"/></returns>
        public Task<ModifyLoadBalancersProjectResponse> ModifyLoadBalancersProject(ModifyLoadBalancersProjectRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancersProjectResponse>(req, "ModifyLoadBalancersProject");
        }

        /// <summary>
        /// This API is used to modify the projects of CLB instances. 
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancersProjectRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancersProjectResponse"/></returns>
        public ModifyLoadBalancersProjectResponse ModifyLoadBalancersProjectSync(ModifyLoadBalancersProjectRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancersProjectResponse>(req, "ModifyLoadBalancersProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyRule) is used to modify the attributes of a forwarding rule under a layer-7 CLB listener, such as forwarding path, health check attribute, and forwarding policy.
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleRequest"/></param>
        /// <returns><see cref="ModifyRuleResponse"/></returns>
        public Task<ModifyRuleResponse> ModifyRule(ModifyRuleRequest req)
        {
            return InternalRequestAsync<ModifyRuleResponse>(req, "ModifyRule");
        }

        /// <summary>
        /// This API (ModifyRule) is used to modify the attributes of a forwarding rule under a layer-7 CLB listener, such as forwarding path, health check attribute, and forwarding policy.
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleRequest"/></param>
        /// <returns><see cref="ModifyRuleResponse"/></returns>
        public ModifyRuleResponse ModifyRuleSync(ModifyRuleRequest req)
        {
            return InternalRequestAsync<ModifyRuleResponse>(req, "ModifyRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to rename a target group or modify its default port attribute.
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyTargetGroupAttributeResponse"/></returns>
        public Task<ModifyTargetGroupAttributeResponse> ModifyTargetGroupAttribute(ModifyTargetGroupAttributeRequest req)
        {
            return InternalRequestAsync<ModifyTargetGroupAttributeResponse>(req, "ModifyTargetGroupAttribute");
        }

        /// <summary>
        /// This API is used to rename a target group or modify its default port attribute.
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyTargetGroupAttributeResponse"/></returns>
        public ModifyTargetGroupAttributeResponse ModifyTargetGroupAttributeSync(ModifyTargetGroupAttributeRequest req)
        {
            return InternalRequestAsync<ModifyTargetGroupAttributeResponse>(req, "ModifyTargetGroupAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify server ports of a target group in batches.
        /// This is an async API. After it is returned successfully, you can call the `DescribeTaskStatus` API with the returned `RequestID` as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetGroupInstancesPortRequest"/></param>
        /// <returns><see cref="ModifyTargetGroupInstancesPortResponse"/></returns>
        public Task<ModifyTargetGroupInstancesPortResponse> ModifyTargetGroupInstancesPort(ModifyTargetGroupInstancesPortRequest req)
        {
            return InternalRequestAsync<ModifyTargetGroupInstancesPortResponse>(req, "ModifyTargetGroupInstancesPort");
        }

        /// <summary>
        /// This API is used to modify server ports of a target group in batches.
        /// This is an async API. After it is returned successfully, you can call the `DescribeTaskStatus` API with the returned `RequestID` as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetGroupInstancesPortRequest"/></param>
        /// <returns><see cref="ModifyTargetGroupInstancesPortResponse"/></returns>
        public ModifyTargetGroupInstancesPortResponse ModifyTargetGroupInstancesPortSync(ModifyTargetGroupInstancesPortRequest req)
        {
            return InternalRequestAsync<ModifyTargetGroupInstancesPortResponse>(req, "ModifyTargetGroupInstancesPort")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify server weights of a target group in batches.
        /// This is an async API. After it is returned successfully, you can call the `DescribeTaskStatus` API with the returned `RequestID` as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetGroupInstancesWeightRequest"/></param>
        /// <returns><see cref="ModifyTargetGroupInstancesWeightResponse"/></returns>
        public Task<ModifyTargetGroupInstancesWeightResponse> ModifyTargetGroupInstancesWeight(ModifyTargetGroupInstancesWeightRequest req)
        {
            return InternalRequestAsync<ModifyTargetGroupInstancesWeightResponse>(req, "ModifyTargetGroupInstancesWeight");
        }

        /// <summary>
        /// This API is used to modify server weights of a target group in batches.
        /// This is an async API. After it is returned successfully, you can call the `DescribeTaskStatus` API with the returned `RequestID` as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetGroupInstancesWeightRequest"/></param>
        /// <returns><see cref="ModifyTargetGroupInstancesWeightResponse"/></returns>
        public ModifyTargetGroupInstancesWeightResponse ModifyTargetGroupInstancesWeightSync(ModifyTargetGroupInstancesWeightRequest req)
        {
            return InternalRequestAsync<ModifyTargetGroupInstancesWeightResponse>(req, "ModifyTargetGroupInstancesWeight")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyTargetPort) is used to modify the port of a real server bound to a listener.
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetPortRequest"/></param>
        /// <returns><see cref="ModifyTargetPortResponse"/></returns>
        public Task<ModifyTargetPortResponse> ModifyTargetPort(ModifyTargetPortRequest req)
        {
            return InternalRequestAsync<ModifyTargetPortResponse>(req, "ModifyTargetPort");
        }

        /// <summary>
        /// This API (ModifyTargetPort) is used to modify the port of a real server bound to a listener.
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetPortRequest"/></param>
        /// <returns><see cref="ModifyTargetPortResponse"/></returns>
        public ModifyTargetPortResponse ModifyTargetPortSync(ModifyTargetPortRequest req)
        {
            return InternalRequestAsync<ModifyTargetPortResponse>(req, "ModifyTargetPort")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyTargetWeight) is used to modify the forwarding weight of a real server bound to a CLB instance.
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetWeightRequest"/></param>
        /// <returns><see cref="ModifyTargetWeightResponse"/></returns>
        public Task<ModifyTargetWeightResponse> ModifyTargetWeight(ModifyTargetWeightRequest req)
        {
            return InternalRequestAsync<ModifyTargetWeightResponse>(req, "ModifyTargetWeight");
        }

        /// <summary>
        /// This API (ModifyTargetWeight) is used to modify the forwarding weight of a real server bound to a CLB instance.
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetWeightRequest"/></param>
        /// <returns><see cref="ModifyTargetWeightResponse"/></returns>
        public ModifyTargetWeightResponse ModifyTargetWeightSync(ModifyTargetWeightRequest req)
        {
            return InternalRequestAsync<ModifyTargetWeightResponse>(req, "ModifyTargetWeight")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bind an SCF function with the L7 forwarding rule of a CLB instance. Note that you need to create an L7 listener (HTTP, HTTPS) and forwarding rule first.
        /// This is an async API. After it is returned successfully, you can call the `DescribeTaskStatus` API with the returned `RequestID` as an input parameter to check whether this task is successful.<br/>
        /// **Limits:**
        /// - Binding with SCF is only available in Guangzhou, Shenzhen Finance, Shanghai, Shanghai Finance, Beijing, Chengdu, Hong Kong (China), Singapore, Mumbai, Tokyo, and Silicon Valley.
        /// - SCF functions can only be bound with CLB instances of bill-by-IP accounts but not with bill-by-CVM accounts. If you are using a bill-by-CVM account, we recommend upgrading it to a bill-by-IP account. 
        /// - SCF functions cannot be bound with classic CLB instances.
        /// - SCF functions cannot be bound with classic network-based CLB instances.
        /// - SCF functions in the same region can be bound with CLB instances. SCF functions can only be bound across VPCs but not regions.
        /// - SCF functions can only be bound with IPv4 and IPv6 NAT64 CLB instances, but currently not with IPv6 CLB instances.
        /// - SCF functions can only be bound with layer-7 HTTP and HTTPS listeners, but not with layer-7 QUIC listeners or layer-4 (TCP, UDP, and TCP SSL) listeners.
        /// - Only SCF event-triggered functions can be bound with CLB instances.
        /// </summary>
        /// <param name="req"><see cref="RegisterFunctionTargetsRequest"/></param>
        /// <returns><see cref="RegisterFunctionTargetsResponse"/></returns>
        public Task<RegisterFunctionTargetsResponse> RegisterFunctionTargets(RegisterFunctionTargetsRequest req)
        {
            return InternalRequestAsync<RegisterFunctionTargetsResponse>(req, "RegisterFunctionTargets");
        }

        /// <summary>
        /// This API is used to bind an SCF function with the L7 forwarding rule of a CLB instance. Note that you need to create an L7 listener (HTTP, HTTPS) and forwarding rule first.
        /// This is an async API. After it is returned successfully, you can call the `DescribeTaskStatus` API with the returned `RequestID` as an input parameter to check whether this task is successful.<br/>
        /// **Limits:**
        /// - Binding with SCF is only available in Guangzhou, Shenzhen Finance, Shanghai, Shanghai Finance, Beijing, Chengdu, Hong Kong (China), Singapore, Mumbai, Tokyo, and Silicon Valley.
        /// - SCF functions can only be bound with CLB instances of bill-by-IP accounts but not with bill-by-CVM accounts. If you are using a bill-by-CVM account, we recommend upgrading it to a bill-by-IP account. 
        /// - SCF functions cannot be bound with classic CLB instances.
        /// - SCF functions cannot be bound with classic network-based CLB instances.
        /// - SCF functions in the same region can be bound with CLB instances. SCF functions can only be bound across VPCs but not regions.
        /// - SCF functions can only be bound with IPv4 and IPv6 NAT64 CLB instances, but currently not with IPv6 CLB instances.
        /// - SCF functions can only be bound with layer-7 HTTP and HTTPS listeners, but not with layer-7 QUIC listeners or layer-4 (TCP, UDP, and TCP SSL) listeners.
        /// - Only SCF event-triggered functions can be bound with CLB instances.
        /// </summary>
        /// <param name="req"><see cref="RegisterFunctionTargetsRequest"/></param>
        /// <returns><see cref="RegisterFunctionTargetsResponse"/></returns>
        public RegisterFunctionTargetsResponse RegisterFunctionTargetsSync(RegisterFunctionTargetsRequest req)
        {
            return InternalRequestAsync<RegisterFunctionTargetsResponse>(req, "RegisterFunctionTargets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to register servers to a target group.
        /// This is an async API. After it is returned successfully, you can call the `DescribeTaskStatus` API with the returned `RequestID` as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="RegisterTargetGroupInstancesRequest"/></param>
        /// <returns><see cref="RegisterTargetGroupInstancesResponse"/></returns>
        public Task<RegisterTargetGroupInstancesResponse> RegisterTargetGroupInstances(RegisterTargetGroupInstancesRequest req)
        {
            return InternalRequestAsync<RegisterTargetGroupInstancesResponse>(req, "RegisterTargetGroupInstances");
        }

        /// <summary>
        /// This API is used to register servers to a target group.
        /// This is an async API. After it is returned successfully, you can call the `DescribeTaskStatus` API with the returned `RequestID` as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="RegisterTargetGroupInstancesRequest"/></param>
        /// <returns><see cref="RegisterTargetGroupInstancesResponse"/></returns>
        public RegisterTargetGroupInstancesResponse RegisterTargetGroupInstancesSync(RegisterTargetGroupInstancesRequest req)
        {
            return InternalRequestAsync<RegisterTargetGroupInstancesResponse>(req, "RegisterTargetGroupInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (RegisterTargets) is used to bind one or more real servers to a CLB listener or layer-7 forwarding rule. Before using this API, you need to create relevant layer-4 listeners or layer-7 forwarding rules. For the former (TCP/UDP), only the listener ID needs to be specified, while for the latter (HTTP/HTTPS), the forwarding rule also needs to be specified through LocationId or Domain+Url.
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="RegisterTargetsRequest"/></param>
        /// <returns><see cref="RegisterTargetsResponse"/></returns>
        public Task<RegisterTargetsResponse> RegisterTargets(RegisterTargetsRequest req)
        {
            return InternalRequestAsync<RegisterTargetsResponse>(req, "RegisterTargets");
        }

        /// <summary>
        /// This API (RegisterTargets) is used to bind one or more real servers to a CLB listener or layer-7 forwarding rule. Before using this API, you need to create relevant layer-4 listeners or layer-7 forwarding rules. For the former (TCP/UDP), only the listener ID needs to be specified, while for the latter (HTTP/HTTPS), the forwarding rule also needs to be specified through LocationId or Domain+Url.
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="RegisterTargetsRequest"/></param>
        /// <returns><see cref="RegisterTargetsResponse"/></returns>
        public RegisterTargetsResponse RegisterTargetsSync(RegisterTargetsRequest req)
        {
            return InternalRequestAsync<RegisterTargetsResponse>(req, "RegisterTargets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bind a real server with a classic CLB instance. This is an async API. After it is returned successfully, you can call the API `DescribeTaskStatus` with the returned RequestId as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="RegisterTargetsWithClassicalLBRequest"/></param>
        /// <returns><see cref="RegisterTargetsWithClassicalLBResponse"/></returns>
        public Task<RegisterTargetsWithClassicalLBResponse> RegisterTargetsWithClassicalLB(RegisterTargetsWithClassicalLBRequest req)
        {
            return InternalRequestAsync<RegisterTargetsWithClassicalLBResponse>(req, "RegisterTargetsWithClassicalLB");
        }

        /// <summary>
        /// This API is used to bind a real server with a classic CLB instance. This is an async API. After it is returned successfully, you can call the API `DescribeTaskStatus` with the returned RequestId as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="RegisterTargetsWithClassicalLBRequest"/></param>
        /// <returns><see cref="RegisterTargetsWithClassicalLBResponse"/></returns>
        public RegisterTargetsWithClassicalLBResponse RegisterTargetsWithClassicalLBSync(RegisterTargetsWithClassicalLBRequest req)
        {
            return InternalRequestAsync<RegisterTargetsWithClassicalLBResponse>(req, "RegisterTargetsWithClassicalLB")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ReplaceCertForLoadBalancers) is used to replace the certificate associated with a CLB instance. A new certificates can be associated with a CLB only after the original certificate is disassociated from it.
        /// This API supports replacing server certificates and client certificates.
        /// The new certificate to be used can be specified by passing in the certificate ID. If no certificate ID is specified, relevant information such as certificate content must be passed in to create a new certificate and bind it to the CLB.
        /// Note: This API can only be called in the Guangzhou region; for other regions, an error will occur due to domain name resolution problems.
        /// </summary>
        /// <param name="req"><see cref="ReplaceCertForLoadBalancersRequest"/></param>
        /// <returns><see cref="ReplaceCertForLoadBalancersResponse"/></returns>
        public Task<ReplaceCertForLoadBalancersResponse> ReplaceCertForLoadBalancers(ReplaceCertForLoadBalancersRequest req)
        {
            return InternalRequestAsync<ReplaceCertForLoadBalancersResponse>(req, "ReplaceCertForLoadBalancers");
        }

        /// <summary>
        /// This API (ReplaceCertForLoadBalancers) is used to replace the certificate associated with a CLB instance. A new certificates can be associated with a CLB only after the original certificate is disassociated from it.
        /// This API supports replacing server certificates and client certificates.
        /// The new certificate to be used can be specified by passing in the certificate ID. If no certificate ID is specified, relevant information such as certificate content must be passed in to create a new certificate and bind it to the CLB.
        /// Note: This API can only be called in the Guangzhou region; for other regions, an error will occur due to domain name resolution problems.
        /// </summary>
        /// <param name="req"><see cref="ReplaceCertForLoadBalancersRequest"/></param>
        /// <returns><see cref="ReplaceCertForLoadBalancersResponse"/></returns>
        public ReplaceCertForLoadBalancersResponse ReplaceCertForLoadBalancersSync(ReplaceCertForLoadBalancersRequest req)
        {
            return InternalRequestAsync<ReplaceCertForLoadBalancersResponse>(req, "ReplaceCertForLoadBalancers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create or manage a user-defined CLB configuration template.
        /// </summary>
        /// <param name="req"><see cref="SetCustomizedConfigForLoadBalancerRequest"/></param>
        /// <returns><see cref="SetCustomizedConfigForLoadBalancerResponse"/></returns>
        public Task<SetCustomizedConfigForLoadBalancerResponse> SetCustomizedConfigForLoadBalancer(SetCustomizedConfigForLoadBalancerRequest req)
        {
            return InternalRequestAsync<SetCustomizedConfigForLoadBalancerResponse>(req, "SetCustomizedConfigForLoadBalancer");
        }

        /// <summary>
        /// This API is used to create or manage a user-defined CLB configuration template.
        /// </summary>
        /// <param name="req"><see cref="SetCustomizedConfigForLoadBalancerRequest"/></param>
        /// <returns><see cref="SetCustomizedConfigForLoadBalancerResponse"/></returns>
        public SetCustomizedConfigForLoadBalancerResponse SetCustomizedConfigForLoadBalancerSync(SetCustomizedConfigForLoadBalancerRequest req)
        {
            return InternalRequestAsync<SetCustomizedConfigForLoadBalancerResponse>(req, "SetCustomizedConfigForLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add, delete, and update the CLS topic of a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="SetLoadBalancerClsLogRequest"/></param>
        /// <returns><see cref="SetLoadBalancerClsLogResponse"/></returns>
        public Task<SetLoadBalancerClsLogResponse> SetLoadBalancerClsLog(SetLoadBalancerClsLogRequest req)
        {
            return InternalRequestAsync<SetLoadBalancerClsLogResponse>(req, "SetLoadBalancerClsLog");
        }

        /// <summary>
        /// This API is used to add, delete, and update the CLS topic of a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="SetLoadBalancerClsLogRequest"/></param>
        /// <returns><see cref="SetLoadBalancerClsLogResponse"/></returns>
        public SetLoadBalancerClsLogResponse SetLoadBalancerClsLogSync(SetLoadBalancerClsLogRequest req)
        {
            return InternalRequestAsync<SetLoadBalancerClsLogResponse>(req, "SetLoadBalancerClsLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to configure (bind and unbind) security groups for a public network CLB instance. You can use the DescribeLoadBalancers API to query the security groups currently bound to a CLB instance. This API follows the set semantics.For binding operations, the input parameters should specify all security groups that should be bound (have been bound and will be bound) to the CLB instance.For unbinding operations, the input parameters should specify all security groups bound to a CLB instance after unbinding. If you want to unbind all security groups, you can omit this parameter or input an empty array. Note: After a private network CLB is bound to an EIP, the security groups on the CLB do not take effect for the traffic from the EIP, but take effect for the traffic from the private network CLB.
        /// </summary>
        /// <param name="req"><see cref="SetLoadBalancerSecurityGroupsRequest"/></param>
        /// <returns><see cref="SetLoadBalancerSecurityGroupsResponse"/></returns>
        public Task<SetLoadBalancerSecurityGroupsResponse> SetLoadBalancerSecurityGroups(SetLoadBalancerSecurityGroupsRequest req)
        {
            return InternalRequestAsync<SetLoadBalancerSecurityGroupsResponse>(req, "SetLoadBalancerSecurityGroups");
        }

        /// <summary>
        /// This API is used to configure (bind and unbind) security groups for a public network CLB instance. You can use the DescribeLoadBalancers API to query the security groups currently bound to a CLB instance. This API follows the set semantics.For binding operations, the input parameters should specify all security groups that should be bound (have been bound and will be bound) to the CLB instance.For unbinding operations, the input parameters should specify all security groups bound to a CLB instance after unbinding. If you want to unbind all security groups, you can omit this parameter or input an empty array. Note: After a private network CLB is bound to an EIP, the security groups on the CLB do not take effect for the traffic from the EIP, but take effect for the traffic from the private network CLB.
        /// </summary>
        /// <param name="req"><see cref="SetLoadBalancerSecurityGroupsRequest"/></param>
        /// <returns><see cref="SetLoadBalancerSecurityGroupsResponse"/></returns>
        public SetLoadBalancerSecurityGroupsResponse SetLoadBalancerSecurityGroupsSync(SetLoadBalancerSecurityGroupsRequest req)
        {
            return InternalRequestAsync<SetLoadBalancerSecurityGroupsResponse>(req, "SetLoadBalancerSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable or disable a CLB instance or listener.This is an asynchronous API. After it returns a result successfully, the obtained RequestID should be used as an input parameter to call the DescribeTaskStatus API, for checking whether this task succeeds.This feature is currently in beta test. To use it, submit a [ticket](https://console.cloud.tencent.com/workorder/category?level1_id=6&level2_id=163&source=0&data_title=%E8%B4%9F%E8%BD%BD%E5%9D%87%E8%A1%A1%20LB&step=1) for application.
        /// </summary>
        /// <param name="req"><see cref="SetLoadBalancerStartStatusRequest"/></param>
        /// <returns><see cref="SetLoadBalancerStartStatusResponse"/></returns>
        public Task<SetLoadBalancerStartStatusResponse> SetLoadBalancerStartStatus(SetLoadBalancerStartStatusRequest req)
        {
            return InternalRequestAsync<SetLoadBalancerStartStatusResponse>(req, "SetLoadBalancerStartStatus");
        }

        /// <summary>
        /// This API is used to enable or disable a CLB instance or listener.This is an asynchronous API. After it returns a result successfully, the obtained RequestID should be used as an input parameter to call the DescribeTaskStatus API, for checking whether this task succeeds.This feature is currently in beta test. To use it, submit a [ticket](https://console.cloud.tencent.com/workorder/category?level1_id=6&level2_id=163&source=0&data_title=%E8%B4%9F%E8%BD%BD%E5%9D%87%E8%A1%A1%20LB&step=1) for application.
        /// </summary>
        /// <param name="req"><see cref="SetLoadBalancerStartStatusRequest"/></param>
        /// <returns><see cref="SetLoadBalancerStartStatusResponse"/></returns>
        public SetLoadBalancerStartStatusResponse SetLoadBalancerStartStatusSync(SetLoadBalancerStartStatusRequest req)
        {
            return InternalRequestAsync<SetLoadBalancerStartStatusResponse>(req, "SetLoadBalancerStartStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bind or unbind a security group for multiple public network CLB instances. Note: Private network CLB do not support binding security groups.
        /// </summary>
        /// <param name="req"><see cref="SetSecurityGroupForLoadbalancersRequest"/></param>
        /// <returns><see cref="SetSecurityGroupForLoadbalancersResponse"/></returns>
        public Task<SetSecurityGroupForLoadbalancersResponse> SetSecurityGroupForLoadbalancers(SetSecurityGroupForLoadbalancersRequest req)
        {
            return InternalRequestAsync<SetSecurityGroupForLoadbalancersResponse>(req, "SetSecurityGroupForLoadbalancers");
        }

        /// <summary>
        /// This API is used to bind or unbind a security group for multiple public network CLB instances. Note: Private network CLB do not support binding security groups.
        /// </summary>
        /// <param name="req"><see cref="SetSecurityGroupForLoadbalancersRequest"/></param>
        /// <returns><see cref="SetSecurityGroupForLoadbalancersResponse"/></returns>
        public SetSecurityGroupForLoadbalancersResponse SetSecurityGroupForLoadbalancersSync(SetSecurityGroupForLoadbalancersRequest req)
        {
            return InternalRequestAsync<SetSecurityGroupForLoadbalancersResponse>(req, "SetSecurityGroupForLoadbalancers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
