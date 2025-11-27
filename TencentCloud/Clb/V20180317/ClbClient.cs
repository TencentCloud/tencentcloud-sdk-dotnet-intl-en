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
       private const string sdkVersion = "SDK_NET_3.0.1244";

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
        /// This API is used to add new personalized configurations and prepare for decommissioning. Please use SetCustomizedConfigForLoadBalancer.
        /// </summary>
        /// <param name="req"><see cref="AddCustomizedConfigRequest"/></param>
        /// <returns><see cref="AddCustomizedConfigResponse"/></returns>
        public Task<AddCustomizedConfigResponse> AddCustomizedConfig(AddCustomizedConfigRequest req)
        {
            return InternalRequestAsync<AddCustomizedConfigResponse>(req, "AddCustomizedConfig");
        }

        /// <summary>
        /// This API is used to add new personalized configurations and prepare for decommissioning. Please use SetCustomizedConfigForLoadBalancer.
        /// </summary>
        /// <param name="req"><see cref="AddCustomizedConfigRequest"/></param>
        /// <returns><see cref="AddCustomizedConfigResponse"/></returns>
        public AddCustomizedConfigResponse AddCustomizedConfigSync(AddCustomizedConfigRequest req)
        {
            return InternalRequestAsync<AddCustomizedConfigResponse>(req, "AddCustomizedConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to associate configurations with a server or location based on the configuration type. It is preparing for decommissioning, please use SetCustomizedConfigForLoadBalancer.
        /// </summary>
        /// <param name="req"><see cref="AssociateCustomizedConfigRequest"/></param>
        /// <returns><see cref="AssociateCustomizedConfigResponse"/></returns>
        public Task<AssociateCustomizedConfigResponse> AssociateCustomizedConfig(AssociateCustomizedConfigRequest req)
        {
            return InternalRequestAsync<AssociateCustomizedConfigResponse>(req, "AssociateCustomizedConfig");
        }

        /// <summary>
        /// This API is used to associate configurations with a server or location based on the configuration type. It is preparing for decommissioning, please use SetCustomizedConfigForLoadBalancer.
        /// </summary>
        /// <param name="req"><see cref="AssociateCustomizedConfigRequest"/></param>
        /// <returns><see cref="AssociateCustomizedConfigResponse"/></returns>
        public AssociateCustomizedConfigResponse AssociateCustomizedConfigSync(AssociateCustomizedConfigRequest req)
        {
            return InternalRequestAsync<AssociateCustomizedConfigResponse>(req, "AssociateCustomizedConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bind target groups to Cloud Load Balancer listeners (Layer-4 protocol) or forwarding rules (L7 protocol).
        /// This API is asynchronous. After it returns a successful result, you need to call the [DescribeTaskStatus](https://www.tencentcloud.comom/document/product/214/30683?from_cn_redirect=1) API with the returned RequestID as input parameter to check whether this task is successful.
        /// This API is used to describe restrictions.
        /// -Binding a legacy version target group to a Layer-4 listener requires the listener to have backend target groups enabled.
        /// -Layer-7 bind target group. LocationId is a required item in the data structure TargetGroupAssociation.
        /// -The VPC of the Cloud Load Balancer must match the VPC of the target group.
        /// </summary>
        /// <param name="req"><see cref="AssociateTargetGroupsRequest"/></param>
        /// <returns><see cref="AssociateTargetGroupsResponse"/></returns>
        public Task<AssociateTargetGroupsResponse> AssociateTargetGroups(AssociateTargetGroupsRequest req)
        {
            return InternalRequestAsync<AssociateTargetGroupsResponse>(req, "AssociateTargetGroups");
        }

        /// <summary>
        /// This API is used to bind target groups to Cloud Load Balancer listeners (Layer-4 protocol) or forwarding rules (L7 protocol).
        /// This API is asynchronous. After it returns a successful result, you need to call the [DescribeTaskStatus](https://www.tencentcloud.comom/document/product/214/30683?from_cn_redirect=1) API with the returned RequestID as input parameter to check whether this task is successful.
        /// This API is used to describe restrictions.
        /// -Binding a legacy version target group to a Layer-4 listener requires the listener to have backend target groups enabled.
        /// -Layer-7 bind target group. LocationId is a required item in the data structure TargetGroupAssociation.
        /// -The VPC of the Cloud Load Balancer must match the VPC of the target group.
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
        /// The BatchModifyTargetWeight API is used to batch modify the forwarding weight of backend machines bound to a CLB listener. The maximum resource quantity for batch modification is 500. This is an asynchronous API. After it returns a successful result, you need to call the DescribeTaskStatus API with the returned RequestID as input parameter to check whether this task is successful. This API supports both layer-4 and layer-7 CLB listeners but is unsupported for classic CLB.
        /// </summary>
        /// <param name="req"><see cref="BatchModifyTargetWeightRequest"/></param>
        /// <returns><see cref="BatchModifyTargetWeightResponse"/></returns>
        public Task<BatchModifyTargetWeightResponse> BatchModifyTargetWeight(BatchModifyTargetWeightRequest req)
        {
            return InternalRequestAsync<BatchModifyTargetWeightResponse>(req, "BatchModifyTargetWeight");
        }

        /// <summary>
        /// The BatchModifyTargetWeight API is used to batch modify the forwarding weight of backend machines bound to a CLB listener. The maximum resource quantity for batch modification is 500. This is an asynchronous API. After it returns a successful result, you need to call the DescribeTaskStatus API with the returned RequestID as input parameter to check whether this task is successful. This API supports both layer-4 and layer-7 CLB listeners but is unsupported for classic CLB.
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
        /// This API is used to clone a load balancing instance with identical rules and binding relationships based on the designated Cloud Load Balancer. The cloning process is an asynchronous operation. The cloned data is based on the status when calling CloneLoadBalancer. If the source CLB changes after calling CloneLoadBalancer, the change rules will not be cloned.
        /// 
        /// Note: The instance creation status can be queried based on the returned requestId by accessing the DescribeTaskStatus API (https://www.tencentcloud.comom/document/product/214/30683?from_cn_redirect=1).
        /// 
        /// This API is used to describe restriction descriptions.
        /// This API is used to set instance attribute restrictions.
        /// -The cloning feature supports both pay-as-you-go and monthly subscription instances. For cloned monthly subscription instances, the new instance's network billing mode switches to billing by hourly bandwidth, with its bandwidth and specifications remaining consistent with the settings of the original instance.
        /// -CLB instances not associated with billable items cannot be cloned (historic free activity creation).
        /// -Classic CLB instances and Anti-DDoS CLBs cannot be cloned.
        /// -Cloning of classic network-based instances is not supported.
        /// -Anycast instances cannot be cloned.
        /// -IPv6 NAT64 edition instances cannot be cloned.
        /// -Blocked or frozen instances cannot be cloned.
        /// -Before performing the cloning operation, make sure that all certificates used on the instance have not expired, otherwise cloning will fail.
        /// This API is used to set quota dimension restrictions.
        /// -Cloning is not supported when the number of instance listeners exceeds 50.
        /// -Cloning is not supported when the public network bandwidth cap of a shared instance exceeds 2G.
        /// 
        /// This API is used to call APIs.
        /// This API is used to specify the BGP bandwidth package ID.
        /// This API is used to perform exclusive cluster cloning with corresponding parameters, otherwise shared instance creation will be used.
        /// </summary>
        /// <param name="req"><see cref="CloneLoadBalancerRequest"/></param>
        /// <returns><see cref="CloneLoadBalancerResponse"/></returns>
        public Task<CloneLoadBalancerResponse> CloneLoadBalancer(CloneLoadBalancerRequest req)
        {
            return InternalRequestAsync<CloneLoadBalancerResponse>(req, "CloneLoadBalancer");
        }

        /// <summary>
        /// This API is used to clone a load balancing instance with identical rules and binding relationships based on the designated Cloud Load Balancer. The cloning process is an asynchronous operation. The cloned data is based on the status when calling CloneLoadBalancer. If the source CLB changes after calling CloneLoadBalancer, the change rules will not be cloned.
        /// 
        /// Note: The instance creation status can be queried based on the returned requestId by accessing the DescribeTaskStatus API (https://www.tencentcloud.comom/document/product/214/30683?from_cn_redirect=1).
        /// 
        /// This API is used to describe restriction descriptions.
        /// This API is used to set instance attribute restrictions.
        /// -The cloning feature supports both pay-as-you-go and monthly subscription instances. For cloned monthly subscription instances, the new instance's network billing mode switches to billing by hourly bandwidth, with its bandwidth and specifications remaining consistent with the settings of the original instance.
        /// -CLB instances not associated with billable items cannot be cloned (historic free activity creation).
        /// -Classic CLB instances and Anti-DDoS CLBs cannot be cloned.
        /// -Cloning of classic network-based instances is not supported.
        /// -Anycast instances cannot be cloned.
        /// -IPv6 NAT64 edition instances cannot be cloned.
        /// -Blocked or frozen instances cannot be cloned.
        /// -Before performing the cloning operation, make sure that all certificates used on the instance have not expired, otherwise cloning will fail.
        /// This API is used to set quota dimension restrictions.
        /// -Cloning is not supported when the number of instance listeners exceeds 50.
        /// -Cloning is not supported when the public network bandwidth cap of a shared instance exceeds 2G.
        /// 
        /// This API is used to call APIs.
        /// This API is used to specify the BGP bandwidth package ID.
        /// This API is used to perform exclusive cluster cloning with corresponding parameters, otherwise shared instance creation will be used.
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
        /// This is an asynchronous API. After it returns the result successfully, you can call the [DescribeTaskStatus](https://intl.cloud.tencent.com/document/product/214/30683?from_cn_redirect=1) API with the returned RequestId as an input parameter to query whether the task is successful.
        /// </summary>
        /// <param name="req"><see cref="CreateListenerRequest"/></param>
        /// <returns><see cref="CreateListenerResponse"/></returns>
        public Task<CreateListenerResponse> CreateListener(CreateListenerRequest req)
        {
            return InternalRequestAsync<CreateListenerResponse>(req, "CreateListener");
        }

        /// <summary>
        /// This API is used to create a listener for a CLB instance.
        /// This is an asynchronous API. After it returns the result successfully, you can call the [DescribeTaskStatus](https://intl.cloud.tencent.com/document/product/214/30683?from_cn_redirect=1) API with the returned RequestId as an input parameter to query whether the task is successful.
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
        /// This API is used to add SnatIp for SnatPro Cloud Load Balancer. If SnatPro is not enabled, it will be auto on after adding SnatIp.
        /// This API is used to perform asynchronous operations. After returning a successful result, call the [DescribeTaskStatus](https://www.tencentcloud.comom/document/product/214/30683?from_cn_redirect=1) API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="CreateLoadBalancerSnatIpsRequest"/></param>
        /// <returns><see cref="CreateLoadBalancerSnatIpsResponse"/></returns>
        public Task<CreateLoadBalancerSnatIpsResponse> CreateLoadBalancerSnatIps(CreateLoadBalancerSnatIpsRequest req)
        {
            return InternalRequestAsync<CreateLoadBalancerSnatIpsResponse>(req, "CreateLoadBalancerSnatIps");
        }

        /// <summary>
        /// This API is used to add SnatIp for SnatPro Cloud Load Balancer. If SnatPro is not enabled, it will be auto on after adding SnatIp.
        /// This API is used to perform asynchronous operations. After returning a successful result, call the [DescribeTaskStatus](https://www.tencentcloud.comom/document/product/214/30683?from_cn_redirect=1) API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="CreateLoadBalancerSnatIpsRequest"/></param>
        /// <returns><see cref="CreateLoadBalancerSnatIpsResponse"/></returns>
        public CreateLoadBalancerSnatIpsResponse CreateLoadBalancerSnatIpsSync(CreateLoadBalancerSnatIpsRequest req)
        {
            return InternalRequestAsync<CreateLoadBalancerSnatIpsResponse>(req, "CreateLoadBalancerSnatIps")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create forwarding rules under an existing layer-7 CLB listener. In layer-7 CLB listeners, backend services must be bound to rules instead of the listener.
        /// This is an asynchronous API. After it returns the result successfully, you can call the [DescribeTaskStatus](https://www.tencentcloud.comom/document/product/214/30683?from_cn_redirect=1) API with the returned RequestId as an input parameter to query whether the task is successful.
        /// </summary>
        /// <param name="req"><see cref="CreateRuleRequest"/></param>
        /// <returns><see cref="CreateRuleResponse"/></returns>
        public Task<CreateRuleResponse> CreateRule(CreateRuleRequest req)
        {
            return InternalRequestAsync<CreateRuleResponse>(req, "CreateRule");
        }

        /// <summary>
        /// This API is used to create forwarding rules under an existing layer-7 CLB listener. In layer-7 CLB listeners, backend services must be bound to rules instead of the listener.
        /// This is an asynchronous API. After it returns the result successfully, you can call the [DescribeTaskStatus](https://www.tencentcloud.comom/document/product/214/30683?from_cn_redirect=1) API with the returned RequestId as an input parameter to query whether the task is successful.
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
        /// This API is used to delete personalized configurations and prepare for decommissioning. Please use SetCustomizedConfigForLoadBalancer.
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomizedConfigRequest"/></param>
        /// <returns><see cref="DeleteCustomizedConfigResponse"/></returns>
        public Task<DeleteCustomizedConfigResponse> DeleteCustomizedConfig(DeleteCustomizedConfigRequest req)
        {
            return InternalRequestAsync<DeleteCustomizedConfigResponse>(req, "DeleteCustomizedConfig");
        }

        /// <summary>
        /// This API is used to delete personalized configurations and prepare for decommissioning. Please use SetCustomizedConfigForLoadBalancer.
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomizedConfigRequest"/></param>
        /// <returns><see cref="DeleteCustomizedConfigResponse"/></returns>
        public DeleteCustomizedConfigResponse DeleteCustomizedConfigSync(DeleteCustomizedConfigRequest req)
        {
            return InternalRequestAsync<DeleteCustomizedConfigResponse>(req, "DeleteCustomizedConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete listeners (layer-4 and layer-7) under a Cloud Load Balancer instance.
        /// This API is used to perform asynchronous operations. After returning a successful result, call the [DescribeTaskStatus](https://www.tencentcloud.comom/document/product/214/30683?from_cn_redirect=1) API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="DeleteListenerRequest"/></param>
        /// <returns><see cref="DeleteListenerResponse"/></returns>
        public Task<DeleteListenerResponse> DeleteListener(DeleteListenerRequest req)
        {
            return InternalRequestAsync<DeleteListenerResponse>(req, "DeleteListener");
        }

        /// <summary>
        /// This API is used to delete listeners (layer-4 and layer-7) under a Cloud Load Balancer instance.
        /// This API is used to perform asynchronous operations. After returning a successful result, call the [DescribeTaskStatus](https://www.tencentcloud.comom/document/product/214/30683?from_cn_redirect=1) API with the returned RequestID as an input parameter to check whether this task is successful.
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
        /// This API is asynchronous. After it returns the result successfully, you can call the [DescribeTaskStatus](https://www.tencentcloud.com/document/product/214/30683?from_cn_redirect=1) API with the returned RequestId as an input parameter to query whether the task is successful.
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerResponse"/></returns>
        public Task<DeleteLoadBalancerResponse> DeleteLoadBalancer(DeleteLoadBalancerRequest req)
        {
            return InternalRequestAsync<DeleteLoadBalancerResponse>(req, "DeleteLoadBalancer");
        }

        /// <summary>
        /// This API is used to delete one or more specified CLB instances. After successful deletion, the listeners and forwarding rules under the CLB instance will be deleted together, and the backend service will be unbound.
        /// This API is asynchronous. After it returns the result successfully, you can call the [DescribeTaskStatus](https://www.tencentcloud.com/document/product/214/30683?from_cn_redirect=1) API with the returned RequestId as an input parameter to query whether the task is successful.
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerResponse"/></returns>
        public DeleteLoadBalancerResponse DeleteLoadBalancerSync(DeleteLoadBalancerRequest req)
        {
            return InternalRequestAsync<DeleteLoadBalancerResponse>(req, "DeleteLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete multiple listeners of Cloud Load Balancer.
        /// This API is used to perform asynchronous operations. After it returns a successful result, call the [DescribeTaskStatus](https://www.tencentcloud.comom/document/product/214/30683?from_cn_redirect=1) API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerListenersRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerListenersResponse"/></returns>
        public Task<DeleteLoadBalancerListenersResponse> DeleteLoadBalancerListeners(DeleteLoadBalancerListenersRequest req)
        {
            return InternalRequestAsync<DeleteLoadBalancerListenersResponse>(req, "DeleteLoadBalancerListeners");
        }

        /// <summary>
        /// This API is used to delete multiple listeners of Cloud Load Balancer.
        /// This API is used to perform asynchronous operations. After it returns a successful result, call the [DescribeTaskStatus](https://www.tencentcloud.comom/document/product/214/30683?from_cn_redirect=1) API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerListenersRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerListenersResponse"/></returns>
        public DeleteLoadBalancerListenersResponse DeleteLoadBalancerListenersSync(DeleteLoadBalancerListenersRequest req)
        {
            return InternalRequestAsync<DeleteLoadBalancerListenersResponse>(req, "DeleteLoadBalancerListeners")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the SnatIp of the SnatPro load balancing.
        /// This API is used to perform asynchronous operations. After returning a successful result, call the [DescribeTaskStatus](https://www.tencentcloud.comom/document/product/214/30683?from_cn_redirect=1) API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerSnatIpsRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerSnatIpsResponse"/></returns>
        public Task<DeleteLoadBalancerSnatIpsResponse> DeleteLoadBalancerSnatIps(DeleteLoadBalancerSnatIpsRequest req)
        {
            return InternalRequestAsync<DeleteLoadBalancerSnatIpsResponse>(req, "DeleteLoadBalancerSnatIps");
        }

        /// <summary>
        /// This API is used to delete the SnatIp of the SnatPro load balancing.
        /// This API is used to perform asynchronous operations. After returning a successful result, call the [DescribeTaskStatus](https://www.tencentcloud.comom/document/product/214/30683?from_cn_redirect=1) API with the returned RequestID as an input parameter to check whether this task is successful.
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
        /// This API is used to delete forwarding rules under a layer-7 listener of a load balancing instance.
        /// This API is used to perform asynchronous operations. After it returns a successful result, call the [DescribeTaskStatus](https://www.tencentcloud.comom/document/product/214/30683?from_cn_redirect=1) API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="DeleteRuleRequest"/></param>
        /// <returns><see cref="DeleteRuleResponse"/></returns>
        public Task<DeleteRuleResponse> DeleteRule(DeleteRuleRequest req)
        {
            return InternalRequestAsync<DeleteRuleResponse>(req, "DeleteRule");
        }

        /// <summary>
        /// This API is used to delete forwarding rules under a layer-7 listener of a load balancing instance.
        /// This API is used to perform asynchronous operations. After it returns a successful result, call the [DescribeTaskStatus](https://www.tencentcloud.comom/document/product/214/30683?from_cn_redirect=1) API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="DeleteRuleRequest"/></param>
        /// <returns><see cref="DeleteRuleResponse"/></returns>
        public DeleteRuleResponse DeleteRuleSync(DeleteRuleRequest req)
        {
            return InternalRequestAsync<DeleteRuleResponse>(req, "DeleteRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete target groups in batches, with a maximum of 20 target groups at a time.
        /// </summary>
        /// <param name="req"><see cref="DeleteTargetGroupsRequest"/></param>
        /// <returns><see cref="DeleteTargetGroupsResponse"/></returns>
        public Task<DeleteTargetGroupsResponse> DeleteTargetGroups(DeleteTargetGroupsRequest req)
        {
            return InternalRequestAsync<DeleteTargetGroupsResponse>(req, "DeleteTargetGroups");
        }

        /// <summary>
        /// This API is used to delete target groups in batches, with a maximum of 20 target groups at a time.
        /// </summary>
        /// <param name="req"><see cref="DeleteTargetGroupsRequest"/></param>
        /// <returns><see cref="DeleteTargetGroupsResponse"/></returns>
        public DeleteTargetGroupsResponse DeleteTargetGroupsSync(DeleteTargetGroupsRequest req)
        {
            return InternalRequestAsync<DeleteTargetGroupsResponse>(req, "DeleteTargetGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind a cloud function from the forwarding rule of a Cloud Load Balancer. For a layer-7 (HTTP/HTTPS) listener, the forwarding rule must be specified by LocationId or Domain+Url.
        /// This API is used to perform asynchronous operations. After it returns a successful result, call the [DescribeTaskStatus](https://www.tencentcloud.comom/document/product/214/30683?from_cn_redirect=1) API with the returned RequestID as an input parameter to check whether this task is successful.
        /// This API is used to describe restrictions.
        /// 
        /// -SCF binding is supported only in Guangzhou, Shenzhen Finance, Shanghai, Shanghai Finance, Beijing, Chengdu, Hong Kong (China), Singapore, Tokyo, and Silicon Valley.
        /// -Only the standard account type supports binding SCF. The classic account type is unsupported. We recommend upgrading to the standard account type. For more information, see [account type upgrade instructions](https://www.tencentcloud.comom/document/product/1199/49090?from_cn_redirect=1).
        /// -Classic CLB does not support binding SCF.
        /// -Basic Network Type does not support binding SCF.
        /// -CLB supports binding ALL SCFs in the same region by default, supports cross-VPC binding, but cross-region selection is not supported.
        /// -Currently, only IPv4 and IPv6 NAT64 versions of Cloud Load Balancer support binding SCF. IPv6 version is not currently supported.
        /// -Only layer-7 (HTTP, HTTPS) listeners support binding SCF. Layer-4 (TCP, UDP, TCP SSL) listeners and layer-7 QUIC listeners are unsupported.
        /// -CLB binding SCF only supports binding cloud functions of the "Event function" type.
        /// </summary>
        /// <param name="req"><see cref="DeregisterFunctionTargetsRequest"/></param>
        /// <returns><see cref="DeregisterFunctionTargetsResponse"/></returns>
        public Task<DeregisterFunctionTargetsResponse> DeregisterFunctionTargets(DeregisterFunctionTargetsRequest req)
        {
            return InternalRequestAsync<DeregisterFunctionTargetsResponse>(req, "DeregisterFunctionTargets");
        }

        /// <summary>
        /// This API is used to unbind a cloud function from the forwarding rule of a Cloud Load Balancer. For a layer-7 (HTTP/HTTPS) listener, the forwarding rule must be specified by LocationId or Domain+Url.
        /// This API is used to perform asynchronous operations. After it returns a successful result, call the [DescribeTaskStatus](https://www.tencentcloud.comom/document/product/214/30683?from_cn_redirect=1) API with the returned RequestID as an input parameter to check whether this task is successful.
        /// This API is used to describe restrictions.
        /// 
        /// -SCF binding is supported only in Guangzhou, Shenzhen Finance, Shanghai, Shanghai Finance, Beijing, Chengdu, Hong Kong (China), Singapore, Tokyo, and Silicon Valley.
        /// -Only the standard account type supports binding SCF. The classic account type is unsupported. We recommend upgrading to the standard account type. For more information, see [account type upgrade instructions](https://www.tencentcloud.comom/document/product/1199/49090?from_cn_redirect=1).
        /// -Classic CLB does not support binding SCF.
        /// -Basic Network Type does not support binding SCF.
        /// -CLB supports binding ALL SCFs in the same region by default, supports cross-VPC binding, but cross-region selection is not supported.
        /// -Currently, only IPv4 and IPv6 NAT64 versions of Cloud Load Balancer support binding SCF. IPv6 version is not currently supported.
        /// -Only layer-7 (HTTP, HTTPS) listeners support binding SCF. Layer-4 (TCP, UDP, TCP SSL) listeners and layer-7 QUIC listeners are unsupported.
        /// -CLB binding SCF only supports binding cloud functions of the "Event function" type.
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
        /// This API is used to perform asynchronous operations. After it returns a successful result, call the [DescribeTaskStatus](https://www.tencentcloud.comom/document/product/214/30683?from_cn_redirect=1) API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="DeregisterTargetGroupInstancesRequest"/></param>
        /// <returns><see cref="DeregisterTargetGroupInstancesResponse"/></returns>
        public Task<DeregisterTargetGroupInstancesResponse> DeregisterTargetGroupInstances(DeregisterTargetGroupInstancesRequest req)
        {
            return InternalRequestAsync<DeregisterTargetGroupInstancesResponse>(req, "DeregisterTargetGroupInstances");
        }

        /// <summary>
        /// This API is used to unbind a server from a target group.
        /// This API is used to perform asynchronous operations. After it returns a successful result, call the [DescribeTaskStatus](https://www.tencentcloud.comom/document/product/214/30683?from_cn_redirect=1) API with the returned RequestID as an input parameter to check whether this task is successful.
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
        /// This API is used to query the operation protection info of Cloud Load Balancer.
        /// </summary>
        /// <param name="req"><see cref="DescribeLBOperateProtectRequest"/></param>
        /// <returns><see cref="DescribeLBOperateProtectResponse"/></returns>
        public Task<DescribeLBOperateProtectResponse> DescribeLBOperateProtect(DescribeLBOperateProtectRequest req)
        {
            return InternalRequestAsync<DescribeLBOperateProtectResponse>(req, "DescribeLBOperateProtect");
        }

        /// <summary>
        /// This API is used to query the operation protection info of Cloud Load Balancer.
        /// </summary>
        /// <param name="req"><see cref="DescribeLBOperateProtectRequest"/></param>
        /// <returns><see cref="DescribeLBOperateProtectResponse"/></returns>
        public DescribeLBOperateProtectResponse DescribeLBOperateProtectSync(DescribeLBOperateProtectRequest req)
        {
            return InternalRequestAsync<DescribeLBOperateProtectResponse>(req, "DescribeLBOperateProtect")
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
        /// This API is used to disassociate personalized configurations and prepare for decommissioning. Please use SetCustomizedConfigForLoadBalancer.
        /// </summary>
        /// <param name="req"><see cref="DisassociateCustomizedConfigRequest"/></param>
        /// <returns><see cref="DisassociateCustomizedConfigResponse"/></returns>
        public Task<DisassociateCustomizedConfigResponse> DisassociateCustomizedConfig(DisassociateCustomizedConfigRequest req)
        {
            return InternalRequestAsync<DisassociateCustomizedConfigResponse>(req, "DisassociateCustomizedConfig");
        }

        /// <summary>
        /// This API is used to disassociate personalized configurations and prepare for decommissioning. Please use SetCustomizedConfigForLoadBalancer.
        /// </summary>
        /// <param name="req"><see cref="DisassociateCustomizedConfigRequest"/></param>
        /// <returns><see cref="DisassociateCustomizedConfigResponse"/></returns>
        public DisassociateCustomizedConfigResponse DisassociateCustomizedConfigSync(DisassociateCustomizedConfigRequest req)
        {
            return InternalRequestAsync<DisassociateCustomizedConfigResponse>(req, "DisassociateCustomizedConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disassociate a target group from a rule.
        /// This is an async API. After the API return succeeds, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// When unbinding a Layer 7 forwarding rule, LocationId is a required item.
        /// </summary>
        /// <param name="req"><see cref="DisassociateTargetGroupsRequest"/></param>
        /// <returns><see cref="DisassociateTargetGroupsResponse"/></returns>
        public Task<DisassociateTargetGroupsResponse> DisassociateTargetGroups(DisassociateTargetGroupsRequest req)
        {
            return InternalRequestAsync<DisassociateTargetGroupsResponse>(req, "DisassociateTargetGroups");
        }

        /// <summary>
        /// This API is used to disassociate a target group from a rule.
        /// This is an async API. After the API return succeeds, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// When unbinding a Layer 7 forwarding rule, LocationId is a required item.
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
        /// This API is used to query the refund price of Cloud Load Balancer and only supports prepaid load balancing instances.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRefundLoadBalancerRequest"/></param>
        /// <returns><see cref="InquiryPriceRefundLoadBalancerResponse"/></returns>
        public Task<InquiryPriceRefundLoadBalancerResponse> InquiryPriceRefundLoadBalancer(InquiryPriceRefundLoadBalancerRequest req)
        {
            return InternalRequestAsync<InquiryPriceRefundLoadBalancerResponse>(req, "InquiryPriceRefundLoadBalancer");
        }

        /// <summary>
        /// This API is used to query the refund price of Cloud Load Balancer and only supports prepaid load balancing instances.
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
        /// This API is used to modify personalized configuration. If the configuration is already bound to clb, server or location, update simultaneously. Prepare for decommissioning. Please use SetCustomizedConfigForLoadBalancer.
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomizedConfigRequest"/></param>
        /// <returns><see cref="ModifyCustomizedConfigResponse"/></returns>
        public Task<ModifyCustomizedConfigResponse> ModifyCustomizedConfig(ModifyCustomizedConfigRequest req)
        {
            return InternalRequestAsync<ModifyCustomizedConfigResponse>(req, "ModifyCustomizedConfig");
        }

        /// <summary>
        /// This API is used to modify personalized configuration. If the configuration is already bound to clb, server or location, update simultaneously. Prepare for decommissioning. Please use SetCustomizedConfigForLoadBalancer.
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomizedConfigRequest"/></param>
        /// <returns><see cref="ModifyCustomizedConfigResponse"/></returns>
        public ModifyCustomizedConfigResponse ModifyCustomizedConfigSync(ModifyCustomizedConfigRequest req)
        {
            return InternalRequestAsync<ModifyCustomizedConfigResponse>(req, "ModifyCustomizedConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the domain name under a layer-7 (HTTP/HTTPS) listener of Cloud Load Balancer.
        /// This is an asynchronous API. After it returns the result successfully, you can call the [DescribeTaskStatus](https://www.tencentcloud.comom/document/product/214/30683?from_cn_redirect=1) API with the returned RequestId as an input parameter to query whether the task is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainRequest"/></param>
        /// <returns><see cref="ModifyDomainResponse"/></returns>
        public Task<ModifyDomainResponse> ModifyDomain(ModifyDomainRequest req)
        {
            return InternalRequestAsync<ModifyDomainResponse>(req, "ModifyDomain");
        }

        /// <summary>
        /// This API is used to modify the domain name under a layer-7 (HTTP/HTTPS) listener of Cloud Load Balancer.
        /// This is an asynchronous API. After it returns the result successfully, you can call the [DescribeTaskStatus](https://www.tencentcloud.comom/document/product/214/30683?from_cn_redirect=1) API with the returned RequestId as an input parameter to query whether the task is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainRequest"/></param>
        /// <returns><see cref="ModifyDomainResponse"/></returns>
        public ModifyDomainResponse ModifyDomainSync(ModifyDomainRequest req)
        {
            return InternalRequestAsync<ModifyDomainResponse>(req, "ModifyDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify domain-level attributes of Cloud Load Balancer layer-7 listener forwarding rules, such as modifying domain name, changing DefaultServer, enabling/disabling Http/2, and modifying certificates.
        /// This is an async API. After it returns a successful result, call the [DescribeTaskStatus](https://www.tencentcloud.comom/document/product/214/30683?from_cn_redirect=1) API with the returned RequestId as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainAttributesRequest"/></param>
        /// <returns><see cref="ModifyDomainAttributesResponse"/></returns>
        public Task<ModifyDomainAttributesResponse> ModifyDomainAttributes(ModifyDomainAttributesRequest req)
        {
            return InternalRequestAsync<ModifyDomainAttributesResponse>(req, "ModifyDomainAttributes");
        }

        /// <summary>
        /// This API is used to modify domain-level attributes of Cloud Load Balancer layer-7 listener forwarding rules, such as modifying domain name, changing DefaultServer, enabling/disabling Http/2, and modifying certificates.
        /// This is an async API. After it returns a successful result, call the [DescribeTaskStatus](https://www.tencentcloud.comom/document/product/214/30683?from_cn_redirect=1) API with the returned RequestId as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainAttributesRequest"/></param>
        /// <returns><see cref="ModifyDomainAttributesResponse"/></returns>
        public ModifyDomainAttributesResponse ModifyDomainAttributesSync(ModifyDomainAttributesRequest req)
        {
            return InternalRequestAsync<ModifyDomainAttributesResponse>(req, "ModifyDomainAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the SCF bound to a Cloud Load Balancer forwarding rule.
        /// This API is used to describe restrictions.
        /// -Only supports binding SCF of the "Event function" type.
        /// </summary>
        /// <param name="req"><see cref="ModifyFunctionTargetsRequest"/></param>
        /// <returns><see cref="ModifyFunctionTargetsResponse"/></returns>
        public Task<ModifyFunctionTargetsResponse> ModifyFunctionTargets(ModifyFunctionTargetsRequest req)
        {
            return InternalRequestAsync<ModifyFunctionTargetsResponse>(req, "ModifyFunctionTargets");
        }

        /// <summary>
        /// This API is used to modify the SCF bound to a Cloud Load Balancer forwarding rule.
        /// This API is used to describe restrictions.
        /// -Only supports binding SCF of the "Event function" type.
        /// </summary>
        /// <param name="req"><see cref="ModifyFunctionTargetsRequest"/></param>
        /// <returns><see cref="ModifyFunctionTargetsResponse"/></returns>
        public ModifyFunctionTargetsResponse ModifyFunctionTargetsSync(ModifyFunctionTargetsRequest req)
        {
            return InternalRequestAsync<ModifyFunctionTargetsResponse>(req, "ModifyFunctionTargets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the attributes of a CLB instance listener, including the listener name, health check parameters, certificate information, and forwarding policy. This API does not support classic CLB instances.
        /// This is an asynchronous API. After it returns the result successfully, you can call the [DescribeTaskStatus](https://intl.cloud.tencent.com/document/product/214/30683?from_cn_redirect=1) API with the returned RequestId as an input parameter to query whether the task is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyListenerRequest"/></param>
        /// <returns><see cref="ModifyListenerResponse"/></returns>
        public Task<ModifyListenerResponse> ModifyListener(ModifyListenerRequest req)
        {
            return InternalRequestAsync<ModifyListenerResponse>(req, "ModifyListener");
        }

        /// <summary>
        /// This API is used to modify the attributes of a CLB instance listener, including the listener name, health check parameters, certificate information, and forwarding policy. This API does not support classic CLB instances.
        /// This is an asynchronous API. After it returns the result successfully, you can call the [DescribeTaskStatus](https://intl.cloud.tencent.com/document/product/214/30683?from_cn_redirect=1) API with the returned RequestId as an input parameter to query whether the task is successful.
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
        /// Non-bandwidth-upshift users must add their CLB instance to a bandwidth package to configure cross-domain attributes. To modify the network billing mode, go to the console.
        /// This API is used to perform asynchronous operations. After returning a successful result, call the [DescribeTaskStatus](https://www.tencentcloud.comom/document/product/214/30683?from_cn_redirect=1) API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerAttributesRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerAttributesResponse"/></returns>
        public Task<ModifyLoadBalancerAttributesResponse> ModifyLoadBalancerAttributes(ModifyLoadBalancerAttributesRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancerAttributesResponse>(req, "ModifyLoadBalancerAttributes");
        }

        /// <summary>
        /// This API is used to modify the attributes of a CLB instance, such as name and cross-region attributes.
        /// Non-bandwidth-upshift users must add their CLB instance to a bandwidth package to configure cross-domain attributes. To modify the network billing mode, go to the console.
        /// This API is used to perform asynchronous operations. After returning a successful result, call the [DescribeTaskStatus](https://www.tencentcloud.comom/document/product/214/30683?from_cn_redirect=1) API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerAttributesRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerAttributesResponse"/></returns>
        public ModifyLoadBalancerAttributesResponse ModifyLoadBalancerAttributesSync(ModifyLoadBalancerAttributesRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancerAttributesResponse>(req, "ModifyLoadBalancerAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to adjust the performance capacity specification of usage-based billing mode instances, for example upgrading from shared type to performance capacity type or modifying the specification of LCU-supported instances.
        /// This API is used to set use limits.
        /// -This API only supports adjustments for pay-as-you-go CLB instances. For CLB instance upgrades with annual/monthly subscription, make adjustments through the console.
        /// -After upgrading from a shared instance to a performance and capacity instance, reverting to a shared instance is not supported.
        /// -A classic CLB instance does not support upgrading to a performance and capacity instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerSlaRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerSlaResponse"/></returns>
        public Task<ModifyLoadBalancerSlaResponse> ModifyLoadBalancerSla(ModifyLoadBalancerSlaRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancerSlaResponse>(req, "ModifyLoadBalancerSla");
        }

        /// <summary>
        /// This API is used to adjust the performance capacity specification of usage-based billing mode instances, for example upgrading from shared type to performance capacity type or modifying the specification of LCU-supported instances.
        /// This API is used to set use limits.
        /// -This API only supports adjustments for pay-as-you-go CLB instances. For CLB instance upgrades with annual/monthly subscription, make adjustments through the console.
        /// -After upgrading from a shared instance to a performance and capacity instance, reverting to a shared instance is not supported.
        /// -A classic CLB instance does not support upgrading to a performance and capacity instance.
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
        /// This API is used to modify the properties of forwarding rules under a layer-7 (HTTP/HTTPS) listener in Cloud Load Balancer, including forwarding path, health check attributes and forwarding policy.
        /// This is an asynchronous API. After it returns the result successfully, you can call the [DescribeTaskStatus](https://www.tencentcloud.comom/document/product/214/30683?from_cn_redirect=1) API with the returned RequestId as an input parameter to query whether the task is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleRequest"/></param>
        /// <returns><see cref="ModifyRuleResponse"/></returns>
        public Task<ModifyRuleResponse> ModifyRule(ModifyRuleRequest req)
        {
            return InternalRequestAsync<ModifyRuleResponse>(req, "ModifyRule");
        }

        /// <summary>
        /// This API is used to modify the properties of forwarding rules under a layer-7 (HTTP/HTTPS) listener in Cloud Load Balancer, including forwarding path, health check attributes and forwarding policy.
        /// This is an asynchronous API. After it returns the result successfully, you can call the [DescribeTaskStatus](https://www.tencentcloud.comom/document/product/214/30683?from_cn_redirect=1) API with the returned RequestId as an input parameter to query whether the task is successful.
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
        /// This API is used to modify the forwarding weight of backend service bound to Cloud Load Balancer.
        /// This is an asynchronous API. After it returns the result successfully, you can call the [DescribeTaskStatus](https://www.tencentcloud.comom/document/product/214/30683?from_cn_redirect=1) API with the returned RequestId as an input parameter to query whether the task is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetWeightRequest"/></param>
        /// <returns><see cref="ModifyTargetWeightResponse"/></returns>
        public Task<ModifyTargetWeightResponse> ModifyTargetWeight(ModifyTargetWeightRequest req)
        {
            return InternalRequestAsync<ModifyTargetWeightResponse>(req, "ModifyTargetWeight");
        }

        /// <summary>
        /// This API is used to modify the forwarding weight of backend service bound to Cloud Load Balancer.
        /// This is an asynchronous API. After it returns the result successfully, you can call the [DescribeTaskStatus](https://www.tencentcloud.comom/document/product/214/30683?from_cn_redirect=1) API with the returned RequestId as an input parameter to query whether the task is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetWeightRequest"/></param>
        /// <returns><see cref="ModifyTargetWeightResponse"/></returns>
        public ModifyTargetWeightResponse ModifyTargetWeightSync(ModifyTargetWeightRequest req)
        {
            return InternalRequestAsync<ModifyTargetWeightResponse>(req, "ModifyTargetWeight")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bind a cloud function to the forwarding rule of a Cloud Load Balancer. Before that, you need to create a related HTTP or HTTPS listener and forwarding rule.
        /// This API is used to perform asynchronous operations. After returning a successful result, call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// This API is used to describe restrictions.
        /// -SCF binding is supported only in Guangzhou, Shenzhen Finance, Shanghai, Shanghai Finance, Beijing, Chengdu, Hong Kong (China), Singapore, Tokyo, and Silicon Valley.
        /// -Only the standard account type supports binding SCF. The classic account type is unsupported. We recommend upgrading to the standard account type. For more information, see [account type upgrade instructions](https://www.tencentcloud.comom/document/product/1199/49090?from_cn_redirect=1). 
        /// -Classic CLB does not support binding SCF.
        /// -Basic Network Type does not support binding SCF.
        /// -CLB supports binding ALL SCFs in the same region by default, supports cross-VPC binding, but cross-region selection is not supported.
        /// -Currently, only IPv4 and IPv6 NAT64 versions of Cloud Load Balancer support binding SCF. IPv6 version is not currently supported.
        /// -Only layer-7 (HTTP, HTTPS) listeners support binding SCF. Layer-4 (TCP, UDP, TCP SSL) listeners and layer-7 QUIC listeners are unsupported.
        /// - CLB binding SCF only supports binding SCF of the "Event function" type.
        /// -A forwarding rule supports binding only one SCF.
        /// </summary>
        /// <param name="req"><see cref="RegisterFunctionTargetsRequest"/></param>
        /// <returns><see cref="RegisterFunctionTargetsResponse"/></returns>
        public Task<RegisterFunctionTargetsResponse> RegisterFunctionTargets(RegisterFunctionTargetsRequest req)
        {
            return InternalRequestAsync<RegisterFunctionTargetsResponse>(req, "RegisterFunctionTargets");
        }

        /// <summary>
        /// This API is used to bind a cloud function to the forwarding rule of a Cloud Load Balancer. Before that, you need to create a related HTTP or HTTPS listener and forwarding rule.
        /// This API is used to perform asynchronous operations. After returning a successful result, call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// This API is used to describe restrictions.
        /// -SCF binding is supported only in Guangzhou, Shenzhen Finance, Shanghai, Shanghai Finance, Beijing, Chengdu, Hong Kong (China), Singapore, Tokyo, and Silicon Valley.
        /// -Only the standard account type supports binding SCF. The classic account type is unsupported. We recommend upgrading to the standard account type. For more information, see [account type upgrade instructions](https://www.tencentcloud.comom/document/product/1199/49090?from_cn_redirect=1). 
        /// -Classic CLB does not support binding SCF.
        /// -Basic Network Type does not support binding SCF.
        /// -CLB supports binding ALL SCFs in the same region by default, supports cross-VPC binding, but cross-region selection is not supported.
        /// -Currently, only IPv4 and IPv6 NAT64 versions of Cloud Load Balancer support binding SCF. IPv6 version is not currently supported.
        /// -Only layer-7 (HTTP, HTTPS) listeners support binding SCF. Layer-4 (TCP, UDP, TCP SSL) listeners and layer-7 QUIC listeners are unsupported.
        /// - CLB binding SCF only supports binding SCF of the "Event function" type.
        /// -A forwarding rule supports binding only one SCF.
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
        /// This API is used to bind one or more backend services to a Cloud Load Balancer listener or layer-7 forwarding rule. Before that, you need to create a related CLB layer-4 listener or layer-7 forwarding rule. For Layer-4 listeners (TCP/UDP), only specify the listener ID. For layer-7 (HTTP/HTTPS) listeners, forwarding rules must be specified through LocationId or Domain+Url.
        /// This API is used to perform asynchronous operations. After it returns a successful result, call the [DescribeTaskStatus](https://www.tencentcloud.comom/document/product/214/30683?from_cn_redirect=1) API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="RegisterTargetsRequest"/></param>
        /// <returns><see cref="RegisterTargetsResponse"/></returns>
        public Task<RegisterTargetsResponse> RegisterTargets(RegisterTargetsRequest req)
        {
            return InternalRequestAsync<RegisterTargetsResponse>(req, "RegisterTargets");
        }

        /// <summary>
        /// This API is used to bind one or more backend services to a Cloud Load Balancer listener or layer-7 forwarding rule. Before that, you need to create a related CLB layer-4 listener or layer-7 forwarding rule. For Layer-4 listeners (TCP/UDP), only specify the listener ID. For layer-7 (HTTP/HTTPS) listeners, forwarding rules must be specified through LocationId or Domain+Url.
        /// This API is used to perform asynchronous operations. After it returns a successful result, call the [DescribeTaskStatus](https://www.tencentcloud.comom/document/product/214/30683?from_cn_redirect=1) API with the returned RequestID as an input parameter to check whether this task is successful.
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
        /// This API is used to bind or unbind security groups for a public network load balancing instance. To query currently bound security groups of a load balancing instance, use the DescribeLoadBalancers API (https://www.tencentcloud.comom/document/product/1108/48459?from_cn_redirect=1). This API follows set semantics.
        /// This API is used to pass in all security groups that should be bound to the Cloud Load Balancer instance during the binding operation (bound + new binding).
        /// For unbinding operations, the input parameters should specify all security groups bound to a CLB instance after unbinding. If you want to unbind all security groups, you can omit this parameter or input an empty array. Note: After a private network CLB is bound to an EIP, the security groups on the CLB do not take effect for the traffic from the EIP, but take effect for the traffic from the private network CLB.
        /// </summary>
        /// <param name="req"><see cref="SetLoadBalancerSecurityGroupsRequest"/></param>
        /// <returns><see cref="SetLoadBalancerSecurityGroupsResponse"/></returns>
        public Task<SetLoadBalancerSecurityGroupsResponse> SetLoadBalancerSecurityGroups(SetLoadBalancerSecurityGroupsRequest req)
        {
            return InternalRequestAsync<SetLoadBalancerSecurityGroupsResponse>(req, "SetLoadBalancerSecurityGroups");
        }

        /// <summary>
        /// This API is used to bind or unbind security groups for a public network load balancing instance. To query currently bound security groups of a load balancing instance, use the DescribeLoadBalancers API (https://www.tencentcloud.comom/document/product/1108/48459?from_cn_redirect=1). This API follows set semantics.
        /// This API is used to pass in all security groups that should be bound to the Cloud Load Balancer instance during the binding operation (bound + new binding).
        /// For unbinding operations, the input parameters should specify all security groups bound to a CLB instance after unbinding. If you want to unbind all security groups, you can omit this parameter or input an empty array. Note: After a private network CLB is bound to an EIP, the security groups on the CLB do not take effect for the traffic from the EIP, but take effect for the traffic from the private network CLB.
        /// </summary>
        /// <param name="req"><see cref="SetLoadBalancerSecurityGroupsRequest"/></param>
        /// <returns><see cref="SetLoadBalancerSecurityGroupsResponse"/></returns>
        public SetLoadBalancerSecurityGroupsResponse SetLoadBalancerSecurityGroupsSync(SetLoadBalancerSecurityGroupsRequest req)
        {
            return InternalRequestAsync<SetLoadBalancerSecurityGroupsResponse>(req, "SetLoadBalancerSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to start or stop a load balancing instance or listener.
        /// This API is used to perform asynchronous operations. After returning a successful result, call the [DescribeTaskStatus](https://www.tencentcloud.comom/document/product/214/30683?from_cn_redirect=1) API with the returned RequestID as an input parameter to check whether this task is successful.
        /// This feature is currently in beta test. To use it, submit a [ticket](https://console.cloud.tencent.com/workorder/category?level1_id=6&level2_id=163&source=0&data_title=%E8%B4%9F%E8%BD%BD%E5%9D%87%E8%A1%A1%20LB&step=1) for application.
        /// </summary>
        /// <param name="req"><see cref="SetLoadBalancerStartStatusRequest"/></param>
        /// <returns><see cref="SetLoadBalancerStartStatusResponse"/></returns>
        public Task<SetLoadBalancerStartStatusResponse> SetLoadBalancerStartStatus(SetLoadBalancerStartStatusRequest req)
        {
            return InternalRequestAsync<SetLoadBalancerStartStatusResponse>(req, "SetLoadBalancerStartStatus");
        }

        /// <summary>
        /// This API is used to start or stop a load balancing instance or listener.
        /// This API is used to perform asynchronous operations. After returning a successful result, call the [DescribeTaskStatus](https://www.tencentcloud.comom/document/product/214/30683?from_cn_redirect=1) API with the returned RequestID as an input parameter to check whether this task is successful.
        /// This feature is currently in beta test. To use it, submit a [ticket](https://console.cloud.tencent.com/workorder/category?level1_id=6&level2_id=163&source=0&data_title=%E8%B4%9F%E8%BD%BD%E5%9D%87%E8%A1%A1%20LB&step=1) for application.
        /// </summary>
        /// <param name="req"><see cref="SetLoadBalancerStartStatusRequest"/></param>
        /// <returns><see cref="SetLoadBalancerStartStatusResponse"/></returns>
        public SetLoadBalancerStartStatusResponse SetLoadBalancerStartStatusSync(SetLoadBalancerStartStatusRequest req)
        {
            return InternalRequestAsync<SetLoadBalancerStartStatusResponse>(req, "SetLoadBalancerStartStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bind or unbind a security group to or from multiple public network CLB instances.
        /// </summary>
        /// <param name="req"><see cref="SetSecurityGroupForLoadbalancersRequest"/></param>
        /// <returns><see cref="SetSecurityGroupForLoadbalancersResponse"/></returns>
        public Task<SetSecurityGroupForLoadbalancersResponse> SetSecurityGroupForLoadbalancers(SetSecurityGroupForLoadbalancersRequest req)
        {
            return InternalRequestAsync<SetSecurityGroupForLoadbalancersResponse>(req, "SetSecurityGroupForLoadbalancers");
        }

        /// <summary>
        /// This API is used to bind or unbind a security group to or from multiple public network CLB instances.
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
