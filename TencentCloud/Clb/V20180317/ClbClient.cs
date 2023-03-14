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

namespace TencentCloud.Clb.V20180317
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Clb.V20180317.Models;

   public class ClbClient : AbstractClient{

       private const string endpoint = "clb.tencentcloudapi.com";
       private const string version = "2018-03-17";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public ClbClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// This API is used to bind target groups to CLB listeners (layer-4 protocol) or forwarding rules (layer-7 protocol).
        /// This is an async API. After it is returned successfully, you can call the `DescribeTaskStatus` API with the returned `RequestID` as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="AssociateTargetGroupsRequest"/></param>
        /// <returns><see cref="AssociateTargetGroupsResponse"/></returns>
        public async Task<AssociateTargetGroupsResponse> AssociateTargetGroups(AssociateTargetGroupsRequest req)
        {
             JsonResponseModel<AssociateTargetGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssociateTargetGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateTargetGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind target groups to CLB listeners (layer-4 protocol) or forwarding rules (layer-7 protocol).
        /// This is an async API. After it is returned successfully, you can call the `DescribeTaskStatus` API with the returned `RequestID` as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="AssociateTargetGroupsRequest"/></param>
        /// <returns><see cref="AssociateTargetGroupsResponse"/></returns>
        public AssociateTargetGroupsResponse AssociateTargetGroupsSync(AssociateTargetGroupsRequest req)
        {
             JsonResponseModel<AssociateTargetGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssociateTargetGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateTargetGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// An HTTPS:443 listener needs to be created first, along with a forwarding rule. When this API is called, an HTTP:80 listener will be created automatically if it did not exist and a forwarding rule corresponding to `Domains` (specified in the input parameter) under the HTTPS:443 listener will also be created. After successful creation, access requests to an HTTP:80 address will be redirected to an HTTPS:443 address automatically.
        /// </summary>
        /// <param name="req"><see cref="AutoRewriteRequest"/></param>
        /// <returns><see cref="AutoRewriteResponse"/></returns>
        public async Task<AutoRewriteResponse> AutoRewrite(AutoRewriteRequest req)
        {
             JsonResponseModel<AutoRewriteResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AutoRewrite");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AutoRewriteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// An HTTPS:443 listener needs to be created first, along with a forwarding rule. When this API is called, an HTTP:80 listener will be created automatically if it did not exist and a forwarding rule corresponding to `Domains` (specified in the input parameter) under the HTTPS:443 listener will also be created. After successful creation, access requests to an HTTP:80 address will be redirected to an HTTPS:443 address automatically.
        /// </summary>
        /// <param name="req"><see cref="AutoRewriteRequest"/></param>
        /// <returns><see cref="AutoRewriteResponse"/></returns>
        public AutoRewriteResponse AutoRewriteSync(AutoRewriteRequest req)
        {
             JsonResponseModel<AutoRewriteResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AutoRewrite");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AutoRewriteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to batch unbind real servers of the layer-4 and layer-7 VPC-based CLBs. Up to 500 real servers can be unbound in a batch.
        /// </summary>
        /// <param name="req"><see cref="BatchDeregisterTargetsRequest"/></param>
        /// <returns><see cref="BatchDeregisterTargetsResponse"/></returns>
        public async Task<BatchDeregisterTargetsResponse> BatchDeregisterTargets(BatchDeregisterTargetsRequest req)
        {
             JsonResponseModel<BatchDeregisterTargetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchDeregisterTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchDeregisterTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to batch unbind real servers of the layer-4 and layer-7 VPC-based CLBs. Up to 500 real servers can be unbound in a batch.
        /// </summary>
        /// <param name="req"><see cref="BatchDeregisterTargetsRequest"/></param>
        /// <returns><see cref="BatchDeregisterTargetsResponse"/></returns>
        public BatchDeregisterTargetsResponse BatchDeregisterTargetsSync(BatchDeregisterTargetsRequest req)
        {
             JsonResponseModel<BatchDeregisterTargetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchDeregisterTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchDeregisterTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify forwarding weights of real servers bound to CLB listeners in batches. Up to 500 servers can be unbound in a batch. As this API is async, you should check whether the task is successful by passing the RequestId returned to the API call `DescribeTaskStatus`.<br/> This API is supported by CLB layer-4 and layer-7 listeners, but not Classis CLB counterparts.
        /// </summary>
        /// <param name="req"><see cref="BatchModifyTargetWeightRequest"/></param>
        /// <returns><see cref="BatchModifyTargetWeightResponse"/></returns>
        public async Task<BatchModifyTargetWeightResponse> BatchModifyTargetWeight(BatchModifyTargetWeightRequest req)
        {
             JsonResponseModel<BatchModifyTargetWeightResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchModifyTargetWeight");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchModifyTargetWeightResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify forwarding weights of real servers bound to CLB listeners in batches. Up to 500 servers can be unbound in a batch. As this API is async, you should check whether the task is successful by passing the RequestId returned to the API call `DescribeTaskStatus`.<br/> This API is supported by CLB layer-4 and layer-7 listeners, but not Classis CLB counterparts.
        /// </summary>
        /// <param name="req"><see cref="BatchModifyTargetWeightRequest"/></param>
        /// <returns><see cref="BatchModifyTargetWeightResponse"/></returns>
        public BatchModifyTargetWeightResponse BatchModifyTargetWeightSync(BatchModifyTargetWeightRequest req)
        {
             JsonResponseModel<BatchModifyTargetWeightResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchModifyTargetWeight");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchModifyTargetWeightResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to batch bind CVM instances or ENIs. Up to 500 servers can be bound in a batch. It supports cross-region binding, layer-4 and layer-7 (TCP/UDP/HTTP/HTTPS) protocols, and VPC-based CLBs only.
        /// </summary>
        /// <param name="req"><see cref="BatchRegisterTargetsRequest"/></param>
        /// <returns><see cref="BatchRegisterTargetsResponse"/></returns>
        public async Task<BatchRegisterTargetsResponse> BatchRegisterTargets(BatchRegisterTargetsRequest req)
        {
             JsonResponseModel<BatchRegisterTargetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchRegisterTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchRegisterTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to batch bind CVM instances or ENIs. Up to 500 servers can be bound in a batch. It supports cross-region binding, layer-4 and layer-7 (TCP/UDP/HTTP/HTTPS) protocols, and VPC-based CLBs only.
        /// </summary>
        /// <param name="req"><see cref="BatchRegisterTargetsRequest"/></param>
        /// <returns><see cref="BatchRegisterTargetsResponse"/></returns>
        public BatchRegisterTargetsResponse BatchRegisterTargetsSync(BatchRegisterTargetsRequest req)
        {
             JsonResponseModel<BatchRegisterTargetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchRegisterTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchRegisterTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a clone of the source CLB instance with the same forwarding rules and binding relations. Note that this API is asynchronous, which means that changes to the source CLB after invocation of the API are not included in the clone.
        /// 
        /// Use limits:
        /// Unsupported instance types: Classic network CLB, Classic CLB, IPv6 CLB, and NAT64 CLB.
        /// Monthly subscribed CLB instances are not supported.
        /// QUIC and port listeners are not supported.
        /// The CLB backend service cannot be a target group or an SCF function.
        /// The following settings will not be cloned automatically and require manual configuration: "Custom Configuration", "Redirection Configuration" and "Allow Traffic by Default in Security Group".
        /// 
        /// Notes:
        /// If you are using a BGP bandwidth package, you need to pass the package ID.
        /// To create a dedicated cluster-based CLB by cloning the source CLB, you need to pass the cluster ID. Otherwise, a normal CLB is created.
        /// This API is only available for beta users. If you want to try it out, please [submit a ticket](https://console.cloud.tencent.com/workorder/category?level1_id=6&level2_id=163&source=0&data_title=%E8%B4%9F%E8%BD%BD%E5%9D%87%E8%A1%A1%20CLB&step=1).
        /// </summary>
        /// <param name="req"><see cref="CloneLoadBalancerRequest"/></param>
        /// <returns><see cref="CloneLoadBalancerResponse"/></returns>
        public async Task<CloneLoadBalancerResponse> CloneLoadBalancer(CloneLoadBalancerRequest req)
        {
             JsonResponseModel<CloneLoadBalancerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CloneLoadBalancer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloneLoadBalancerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a clone of the source CLB instance with the same forwarding rules and binding relations. Note that this API is asynchronous, which means that changes to the source CLB after invocation of the API are not included in the clone.
        /// 
        /// Use limits:
        /// Unsupported instance types: Classic network CLB, Classic CLB, IPv6 CLB, and NAT64 CLB.
        /// Monthly subscribed CLB instances are not supported.
        /// QUIC and port listeners are not supported.
        /// The CLB backend service cannot be a target group or an SCF function.
        /// The following settings will not be cloned automatically and require manual configuration: "Custom Configuration", "Redirection Configuration" and "Allow Traffic by Default in Security Group".
        /// 
        /// Notes:
        /// If you are using a BGP bandwidth package, you need to pass the package ID.
        /// To create a dedicated cluster-based CLB by cloning the source CLB, you need to pass the cluster ID. Otherwise, a normal CLB is created.
        /// This API is only available for beta users. If you want to try it out, please [submit a ticket](https://console.cloud.tencent.com/workorder/category?level1_id=6&level2_id=163&source=0&data_title=%E8%B4%9F%E8%BD%BD%E5%9D%87%E8%A1%A1%20CLB&step=1).
        /// </summary>
        /// <param name="req"><see cref="CloneLoadBalancerRequest"/></param>
        /// <returns><see cref="CloneLoadBalancerResponse"/></returns>
        public CloneLoadBalancerResponse CloneLoadBalancerSync(CloneLoadBalancerRequest req)
        {
             JsonResponseModel<CloneLoadBalancerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CloneLoadBalancer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloneLoadBalancerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a CLB exclusive logset for storing CLB logs.
        /// </summary>
        /// <param name="req"><see cref="CreateClsLogSetRequest"/></param>
        /// <returns><see cref="CreateClsLogSetResponse"/></returns>
        public async Task<CreateClsLogSetResponse> CreateClsLogSet(CreateClsLogSetRequest req)
        {
             JsonResponseModel<CreateClsLogSetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateClsLogSet");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClsLogSetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a CLB exclusive logset for storing CLB logs.
        /// </summary>
        /// <param name="req"><see cref="CreateClsLogSetRequest"/></param>
        /// <returns><see cref="CreateClsLogSetResponse"/></returns>
        public CreateClsLogSetResponse CreateClsLogSetSync(CreateClsLogSetRequest req)
        {
             JsonResponseModel<CreateClsLogSetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateClsLogSet");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClsLogSetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a listener for a CLB instance.
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestId as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="CreateListenerRequest"/></param>
        /// <returns><see cref="CreateListenerResponse"/></returns>
        public async Task<CreateListenerResponse> CreateListener(CreateListenerRequest req)
        {
             JsonResponseModel<CreateListenerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateListener");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateListenerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a listener for a CLB instance.
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestId as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="CreateListenerRequest"/></param>
        /// <returns><see cref="CreateListenerResponse"/></returns>
        public CreateListenerResponse CreateListenerSync(CreateListenerRequest req)
        {
             JsonResponseModel<CreateListenerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateListener");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateListenerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateLoadBalancer) is used to create a CLB instance. To use the CLB service, you first need to purchase one or more instances. After this API is called successfully, a unique instance ID will be returned. There are two types of instances: public network and private network. For more information, see the product types in the product documentation.
        /// Note: (1) To apply for a CLB instance in the specified AZ and cross-AZ disaster recovery, please [submit a ticket](https://console.cloud.tencent.com/workorder/category); (2) Currently, IPv6 is supported only in Beijing, Shanghai, and Guangzhou regions.
        /// This is an async API. After it is returned successfully, you can call the DescribeLoadBalancers API to query the status of the instance (such as creating and normal) to check whether it is successfully created.
        /// </summary>
        /// <param name="req"><see cref="CreateLoadBalancerRequest"/></param>
        /// <returns><see cref="CreateLoadBalancerResponse"/></returns>
        public async Task<CreateLoadBalancerResponse> CreateLoadBalancer(CreateLoadBalancerRequest req)
        {
             JsonResponseModel<CreateLoadBalancerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLoadBalancer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLoadBalancerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<CreateLoadBalancerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLoadBalancer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLoadBalancerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add an SNAT IP for an SnatPro CLB instance. If SnatPro is not enabled for CLB, it will be automatically enabled after the SNAT IP is added.
        /// This is an async API. After it is returned successfully, you can check the task result by calling `DescribeTaskStatus` with the returned `RequestID`.
        /// </summary>
        /// <param name="req"><see cref="CreateLoadBalancerSnatIpsRequest"/></param>
        /// <returns><see cref="CreateLoadBalancerSnatIpsResponse"/></returns>
        public async Task<CreateLoadBalancerSnatIpsResponse> CreateLoadBalancerSnatIps(CreateLoadBalancerSnatIpsRequest req)
        {
             JsonResponseModel<CreateLoadBalancerSnatIpsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLoadBalancerSnatIps");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLoadBalancerSnatIpsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add an SNAT IP for an SnatPro CLB instance. If SnatPro is not enabled for CLB, it will be automatically enabled after the SNAT IP is added.
        /// This is an async API. After it is returned successfully, you can check the task result by calling `DescribeTaskStatus` with the returned `RequestID`.
        /// </summary>
        /// <param name="req"><see cref="CreateLoadBalancerSnatIpsRequest"/></param>
        /// <returns><see cref="CreateLoadBalancerSnatIpsResponse"/></returns>
        public CreateLoadBalancerSnatIpsResponse CreateLoadBalancerSnatIpsSync(CreateLoadBalancerSnatIpsRequest req)
        {
             JsonResponseModel<CreateLoadBalancerSnatIpsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLoadBalancerSnatIps");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLoadBalancerSnatIpsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateRule) is used to create a forwarding rule under an existing layer-7 CLB listener, where real servers must be bound to the rule instead of the listener.
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="CreateRuleRequest"/></param>
        /// <returns><see cref="CreateRuleResponse"/></returns>
        public async Task<CreateRuleResponse> CreateRule(CreateRuleRequest req)
        {
             JsonResponseModel<CreateRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateRule) is used to create a forwarding rule under an existing layer-7 CLB listener, where real servers must be bound to the rule instead of the listener.
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="CreateRuleRequest"/></param>
        /// <returns><see cref="CreateRuleResponse"/></returns>
        public CreateRuleResponse CreateRuleSync(CreateRuleRequest req)
        {
             JsonResponseModel<CreateRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a target group. This feature is in beta test, if you want to try it out, please [submit a ticket](https://console.cloud.tencent.com/workorder/category?level1_id=6&level2_id=163&source=0&data_title=%E8%B4%9F%E8%BD%BD%E5%9D%87%E8%A1%A1%20LB&step=1).
        /// </summary>
        /// <param name="req"><see cref="CreateTargetGroupRequest"/></param>
        /// <returns><see cref="CreateTargetGroupResponse"/></returns>
        public async Task<CreateTargetGroupResponse> CreateTargetGroup(CreateTargetGroupRequest req)
        {
             JsonResponseModel<CreateTargetGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTargetGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTargetGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a target group. This feature is in beta test, if you want to try it out, please [submit a ticket](https://console.cloud.tencent.com/workorder/category?level1_id=6&level2_id=163&source=0&data_title=%E8%B4%9F%E8%BD%BD%E5%9D%87%E8%A1%A1%20LB&step=1).
        /// </summary>
        /// <param name="req"><see cref="CreateTargetGroupRequest"/></param>
        /// <returns><see cref="CreateTargetGroupResponse"/></returns>
        public CreateTargetGroupResponse CreateTargetGroupSync(CreateTargetGroupRequest req)
        {
             JsonResponseModel<CreateTargetGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTargetGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTargetGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a topic with the full-text index and key-value index enabled by default. The creation will fail if there is no CLB exclusive logset.
        /// </summary>
        /// <param name="req"><see cref="CreateTopicRequest"/></param>
        /// <returns><see cref="CreateTopicResponse"/></returns>
        public async Task<CreateTopicResponse> CreateTopic(CreateTopicRequest req)
        {
             JsonResponseModel<CreateTopicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a topic with the full-text index and key-value index enabled by default. The creation will fail if there is no CLB exclusive logset.
        /// </summary>
        /// <param name="req"><see cref="CreateTopicRequest"/></param>
        /// <returns><see cref="CreateTopicResponse"/></returns>
        public CreateTopicResponse CreateTopicSync(CreateTopicRequest req)
        {
             JsonResponseModel<CreateTopicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a listener from a CLB instance (layer-4 or layer-7).
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="DeleteListenerRequest"/></param>
        /// <returns><see cref="DeleteListenerResponse"/></returns>
        public async Task<DeleteListenerResponse> DeleteListener(DeleteListenerRequest req)
        {
             JsonResponseModel<DeleteListenerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteListener");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteListenerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a listener from a CLB instance (layer-4 or layer-7).
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="DeleteListenerRequest"/></param>
        /// <returns><see cref="DeleteListenerResponse"/></returns>
        public DeleteListenerResponse DeleteListenerSync(DeleteListenerRequest req)
        {
             JsonResponseModel<DeleteListenerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteListener");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteListenerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteLoadBalancer) is used to delete one or more specified CLB instances.
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestId as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerResponse"/></returns>
        public async Task<DeleteLoadBalancerResponse> DeleteLoadBalancer(DeleteLoadBalancerRequest req)
        {
             JsonResponseModel<DeleteLoadBalancerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLoadBalancer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLoadBalancerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteLoadBalancer) is used to delete one or more specified CLB instances.
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestId as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerResponse"/></returns>
        public DeleteLoadBalancerResponse DeleteLoadBalancerSync(DeleteLoadBalancerRequest req)
        {
             JsonResponseModel<DeleteLoadBalancerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLoadBalancer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLoadBalancerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete multiple listeners of a CLB instance.
        /// This is an async API. After it is returned successfully, you can call the `DescribeTaskStatus` API with the returned `RequestID` as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerListenersRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerListenersResponse"/></returns>
        public async Task<DeleteLoadBalancerListenersResponse> DeleteLoadBalancerListeners(DeleteLoadBalancerListenersRequest req)
        {
             JsonResponseModel<DeleteLoadBalancerListenersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLoadBalancerListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLoadBalancerListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete multiple listeners of a CLB instance.
        /// This is an async API. After it is returned successfully, you can call the `DescribeTaskStatus` API with the returned `RequestID` as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerListenersRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerListenersResponse"/></returns>
        public DeleteLoadBalancerListenersResponse DeleteLoadBalancerListenersSync(DeleteLoadBalancerListenersRequest req)
        {
             JsonResponseModel<DeleteLoadBalancerListenersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLoadBalancerListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLoadBalancerListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete the SNAT IP for an SnatPro CLB instance.
        /// This is an async API. After it is returned successfully, you can check the task result by calling `DescribeTaskStatus` with the returned `RequestID`.
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerSnatIpsRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerSnatIpsResponse"/></returns>
        public async Task<DeleteLoadBalancerSnatIpsResponse> DeleteLoadBalancerSnatIps(DeleteLoadBalancerSnatIpsRequest req)
        {
             JsonResponseModel<DeleteLoadBalancerSnatIpsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLoadBalancerSnatIps");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLoadBalancerSnatIpsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete the SNAT IP for an SnatPro CLB instance.
        /// This is an async API. After it is returned successfully, you can check the task result by calling `DescribeTaskStatus` with the returned `RequestID`.
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerSnatIpsRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerSnatIpsResponse"/></returns>
        public DeleteLoadBalancerSnatIpsResponse DeleteLoadBalancerSnatIpsSync(DeleteLoadBalancerSnatIpsRequest req)
        {
             JsonResponseModel<DeleteLoadBalancerSnatIpsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLoadBalancerSnatIps");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLoadBalancerSnatIpsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteRewrite) is used to delete the redirection relationship between the specified forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteRewriteRequest"/></param>
        /// <returns><see cref="DeleteRewriteResponse"/></returns>
        public async Task<DeleteRewriteResponse> DeleteRewrite(DeleteRewriteRequest req)
        {
             JsonResponseModel<DeleteRewriteResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRewrite");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRewriteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteRewrite) is used to delete the redirection relationship between the specified forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteRewriteRequest"/></param>
        /// <returns><see cref="DeleteRewriteResponse"/></returns>
        public DeleteRewriteResponse DeleteRewriteSync(DeleteRewriteRequest req)
        {
             JsonResponseModel<DeleteRewriteResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRewrite");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRewriteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteRule) is used to delete a forwarding rule under a layer-7 CLB instance listener
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="DeleteRuleRequest"/></param>
        /// <returns><see cref="DeleteRuleResponse"/></returns>
        public async Task<DeleteRuleResponse> DeleteRule(DeleteRuleRequest req)
        {
             JsonResponseModel<DeleteRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteRule) is used to delete a forwarding rule under a layer-7 CLB instance listener
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="DeleteRuleRequest"/></param>
        /// <returns><see cref="DeleteRuleResponse"/></returns>
        public DeleteRuleResponse DeleteRuleSync(DeleteRuleRequest req)
        {
             JsonResponseModel<DeleteRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a target group.
        /// </summary>
        /// <param name="req"><see cref="DeleteTargetGroupsRequest"/></param>
        /// <returns><see cref="DeleteTargetGroupsResponse"/></returns>
        public async Task<DeleteTargetGroupsResponse> DeleteTargetGroups(DeleteTargetGroupsRequest req)
        {
             JsonResponseModel<DeleteTargetGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTargetGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTargetGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a target group.
        /// </summary>
        /// <param name="req"><see cref="DeleteTargetGroupsRequest"/></param>
        /// <returns><see cref="DeleteTargetGroupsResponse"/></returns>
        public DeleteTargetGroupsResponse DeleteTargetGroupsSync(DeleteTargetGroupsRequest req)
        {
             JsonResponseModel<DeleteTargetGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTargetGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTargetGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind a SCF function with a CLB forwarding rule. For L7 listeners, you need to specify the forwarding rule by using `LocationId` or `Domain+Url`. 
        /// This is an async API. After it is returned successfully, you can call the [DescribeTaskStatus](https://intl.cloud.tencent.com/document/product/214/30683?from_cn_redirect=1) API with the returned RequestID to check whether this task is successful.
        /// <br/>Limits: 
        /// 
        /// - Binding with SCF is only available in Guangzhou, Shenzhen Finance, Shanghai, Shanghai Finance, Beijing, Chengdu, Hong Kong (China), Singapore, Mumbai, Tokyo, and Silicon Valley.
        /// - SCF functions can only be bound with CLB instances of bill-by-IP accounts but not with bill-by-CVM accounts. If you are using a bill-by-CVM account, we recommend upgrading it to a bill-by-IP account. For more information, please see [Checking Account Type](https://intl.cloud.tencent.com/document/product/1199/49090?from_cn_redirect=1).
        /// - SCF functions cannot be bound with classic CLB instances.
        /// - SCF functions cannot be bound with classic network-based CLB instances.
        /// - SCF functions in the same region can be bound with CLB instances. SCF functions can only be bound across VPCs but not regions.
        /// - SCF functions can only be bound with IPv4 and IPv6 NAT64 CLB instances, but currently not with IPv6 CLB instances.
        /// - SCF functions can only be bound with layer-7 HTTP and HTTPS listeners, but not with layer-7 QUIC listeners or layer-4 (TCP, UDP, and TCP SSL) listeners.
        /// - Only SCF event-triggered functions can be bound with CLB instances.
        /// </summary>
        /// <param name="req"><see cref="DeregisterFunctionTargetsRequest"/></param>
        /// <returns><see cref="DeregisterFunctionTargetsResponse"/></returns>
        public async Task<DeregisterFunctionTargetsResponse> DeregisterFunctionTargets(DeregisterFunctionTargetsRequest req)
        {
             JsonResponseModel<DeregisterFunctionTargetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeregisterFunctionTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeregisterFunctionTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind a SCF function with a CLB forwarding rule. For L7 listeners, you need to specify the forwarding rule by using `LocationId` or `Domain+Url`. 
        /// This is an async API. After it is returned successfully, you can call the [DescribeTaskStatus](https://intl.cloud.tencent.com/document/product/214/30683?from_cn_redirect=1) API with the returned RequestID to check whether this task is successful.
        /// <br/>Limits: 
        /// 
        /// - Binding with SCF is only available in Guangzhou, Shenzhen Finance, Shanghai, Shanghai Finance, Beijing, Chengdu, Hong Kong (China), Singapore, Mumbai, Tokyo, and Silicon Valley.
        /// - SCF functions can only be bound with CLB instances of bill-by-IP accounts but not with bill-by-CVM accounts. If you are using a bill-by-CVM account, we recommend upgrading it to a bill-by-IP account. For more information, please see [Checking Account Type](https://intl.cloud.tencent.com/document/product/1199/49090?from_cn_redirect=1).
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
             JsonResponseModel<DeregisterFunctionTargetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeregisterFunctionTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeregisterFunctionTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind a server from a target group.
        /// This is an async API. After it is returned successfully, you can call the API `DescribeTaskStatus` with the returned RequestId as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="DeregisterTargetGroupInstancesRequest"/></param>
        /// <returns><see cref="DeregisterTargetGroupInstancesResponse"/></returns>
        public async Task<DeregisterTargetGroupInstancesResponse> DeregisterTargetGroupInstances(DeregisterTargetGroupInstancesRequest req)
        {
             JsonResponseModel<DeregisterTargetGroupInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeregisterTargetGroupInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeregisterTargetGroupInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind a server from a target group.
        /// This is an async API. After it is returned successfully, you can call the API `DescribeTaskStatus` with the returned RequestId as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="DeregisterTargetGroupInstancesRequest"/></param>
        /// <returns><see cref="DeregisterTargetGroupInstancesResponse"/></returns>
        public DeregisterTargetGroupInstancesResponse DeregisterTargetGroupInstancesSync(DeregisterTargetGroupInstancesRequest req)
        {
             JsonResponseModel<DeregisterTargetGroupInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeregisterTargetGroupInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeregisterTargetGroupInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeregisterTargets) is used to unbind one or more real servers from a CLB listener or forwarding rule. For layer-4 listeners, only the listener ID needs to be specified. For layer-7 listeners, the forwarding rule also needs to be specified through LocationId or Domain+Url.
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="DeregisterTargetsRequest"/></param>
        /// <returns><see cref="DeregisterTargetsResponse"/></returns>
        public async Task<DeregisterTargetsResponse> DeregisterTargets(DeregisterTargetsRequest req)
        {
             JsonResponseModel<DeregisterTargetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeregisterTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeregisterTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeregisterTargets) is used to unbind one or more real servers from a CLB listener or forwarding rule. For layer-4 listeners, only the listener ID needs to be specified. For layer-7 listeners, the forwarding rule also needs to be specified through LocationId or Domain+Url.
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="DeregisterTargetsRequest"/></param>
        /// <returns><see cref="DeregisterTargetsResponse"/></returns>
        public DeregisterTargetsResponse DeregisterTargetsSync(DeregisterTargetsRequest req)
        {
             JsonResponseModel<DeregisterTargetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeregisterTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeregisterTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind a CLB real server. This is an async API. After it is returned successfully, you can call the API `DescribeTaskStatus` with the returned RequestId as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="DeregisterTargetsFromClassicalLBRequest"/></param>
        /// <returns><see cref="DeregisterTargetsFromClassicalLBResponse"/></returns>
        public async Task<DeregisterTargetsFromClassicalLBResponse> DeregisterTargetsFromClassicalLB(DeregisterTargetsFromClassicalLBRequest req)
        {
             JsonResponseModel<DeregisterTargetsFromClassicalLBResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeregisterTargetsFromClassicalLB");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeregisterTargetsFromClassicalLBResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind a CLB real server. This is an async API. After it is returned successfully, you can call the API `DescribeTaskStatus` with the returned RequestId as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="DeregisterTargetsFromClassicalLBRequest"/></param>
        /// <returns><see cref="DeregisterTargetsFromClassicalLBResponse"/></returns>
        public DeregisterTargetsFromClassicalLBResponse DeregisterTargetsFromClassicalLBSync(DeregisterTargetsFromClassicalLBRequest req)
        {
             JsonResponseModel<DeregisterTargetsFromClassicalLBResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeregisterTargetsFromClassicalLB");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeregisterTargetsFromClassicalLBResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of blocked IPs (blocklist) of a CLB instance. (This API is in beta test. To use it, please submit a ticket.)
        /// </summary>
        /// <param name="req"><see cref="DescribeBlockIPListRequest"/></param>
        /// <returns><see cref="DescribeBlockIPListResponse"/></returns>
        public async Task<DescribeBlockIPListResponse> DescribeBlockIPList(DescribeBlockIPListRequest req)
        {
             JsonResponseModel<DescribeBlockIPListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBlockIPList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBlockIPListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of blocked IPs (blocklist) of a CLB instance. (This API is in beta test. To use it, please submit a ticket.)
        /// </summary>
        /// <param name="req"><see cref="DescribeBlockIPListRequest"/></param>
        /// <returns><see cref="DescribeBlockIPListResponse"/></returns>
        public DescribeBlockIPListResponse DescribeBlockIPListSync(DescribeBlockIPListRequest req)
        {
             JsonResponseModel<DescribeBlockIPListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBlockIPList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBlockIPListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the execution status of an async IP blocking (blocklisting) task by the async task ID returned by the `ModifyBlockIPList` API. (This API is in beta test. To use it, please submit a ticket.)
        /// </summary>
        /// <param name="req"><see cref="DescribeBlockIPTaskRequest"/></param>
        /// <returns><see cref="DescribeBlockIPTaskResponse"/></returns>
        public async Task<DescribeBlockIPTaskResponse> DescribeBlockIPTask(DescribeBlockIPTaskRequest req)
        {
             JsonResponseModel<DescribeBlockIPTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBlockIPTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBlockIPTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the execution status of an async IP blocking (blocklisting) task by the async task ID returned by the `ModifyBlockIPList` API. (This API is in beta test. To use it, please submit a ticket.)
        /// </summary>
        /// <param name="req"><see cref="DescribeBlockIPTaskRequest"/></param>
        /// <returns><see cref="DescribeBlockIPTaskResponse"/></returns>
        public DescribeBlockIPTaskResponse DescribeBlockIPTaskSync(DescribeBlockIPTaskRequest req)
        {
             JsonResponseModel<DescribeBlockIPTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBlockIPTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBlockIPTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of classic CLB instance IDs through a real server ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeClassicalLBByInstanceIdRequest"/></param>
        /// <returns><see cref="DescribeClassicalLBByInstanceIdResponse"/></returns>
        public async Task<DescribeClassicalLBByInstanceIdResponse> DescribeClassicalLBByInstanceId(DescribeClassicalLBByInstanceIdRequest req)
        {
             JsonResponseModel<DescribeClassicalLBByInstanceIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClassicalLBByInstanceId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClassicalLBByInstanceIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of classic CLB instance IDs through a real server ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeClassicalLBByInstanceIdRequest"/></param>
        /// <returns><see cref="DescribeClassicalLBByInstanceIdResponse"/></returns>
        public DescribeClassicalLBByInstanceIdResponse DescribeClassicalLBByInstanceIdSync(DescribeClassicalLBByInstanceIdRequest req)
        {
             JsonResponseModel<DescribeClassicalLBByInstanceIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClassicalLBByInstanceId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClassicalLBByInstanceIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeClassicalLBHealthStatus) is used to get the real server health status of a classic CLB
        /// </summary>
        /// <param name="req"><see cref="DescribeClassicalLBHealthStatusRequest"/></param>
        /// <returns><see cref="DescribeClassicalLBHealthStatusResponse"/></returns>
        public async Task<DescribeClassicalLBHealthStatusResponse> DescribeClassicalLBHealthStatus(DescribeClassicalLBHealthStatusRequest req)
        {
             JsonResponseModel<DescribeClassicalLBHealthStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClassicalLBHealthStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClassicalLBHealthStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeClassicalLBHealthStatus) is used to get the real server health status of a classic CLB
        /// </summary>
        /// <param name="req"><see cref="DescribeClassicalLBHealthStatusRequest"/></param>
        /// <returns><see cref="DescribeClassicalLBHealthStatusResponse"/></returns>
        public DescribeClassicalLBHealthStatusResponse DescribeClassicalLBHealthStatusSync(DescribeClassicalLBHealthStatusRequest req)
        {
             JsonResponseModel<DescribeClassicalLBHealthStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClassicalLBHealthStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClassicalLBHealthStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeClassicalLBListeners) is used to get the listener information of a classic CLB.
        /// </summary>
        /// <param name="req"><see cref="DescribeClassicalLBListenersRequest"/></param>
        /// <returns><see cref="DescribeClassicalLBListenersResponse"/></returns>
        public async Task<DescribeClassicalLBListenersResponse> DescribeClassicalLBListeners(DescribeClassicalLBListenersRequest req)
        {
             JsonResponseModel<DescribeClassicalLBListenersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClassicalLBListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClassicalLBListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeClassicalLBListeners) is used to get the listener information of a classic CLB.
        /// </summary>
        /// <param name="req"><see cref="DescribeClassicalLBListenersRequest"/></param>
        /// <returns><see cref="DescribeClassicalLBListenersResponse"/></returns>
        public DescribeClassicalLBListenersResponse DescribeClassicalLBListenersSync(DescribeClassicalLBListenersRequest req)
        {
             JsonResponseModel<DescribeClassicalLBListenersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClassicalLBListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClassicalLBListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the real servers bound to a classic CLB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeClassicalLBTargetsRequest"/></param>
        /// <returns><see cref="DescribeClassicalLBTargetsResponse"/></returns>
        public async Task<DescribeClassicalLBTargetsResponse> DescribeClassicalLBTargets(DescribeClassicalLBTargetsRequest req)
        {
             JsonResponseModel<DescribeClassicalLBTargetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClassicalLBTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClassicalLBTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the real servers bound to a classic CLB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeClassicalLBTargetsRequest"/></param>
        /// <returns><see cref="DescribeClassicalLBTargetsResponse"/></returns>
        public DescribeClassicalLBTargetsResponse DescribeClassicalLBTargetsSync(DescribeClassicalLBTargetsRequest req)
        {
             JsonResponseModel<DescribeClassicalLBTargetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClassicalLBTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClassicalLBTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the CLB exclusive logset.
        /// </summary>
        /// <param name="req"><see cref="DescribeClsLogSetRequest"/></param>
        /// <returns><see cref="DescribeClsLogSetResponse"/></returns>
        public async Task<DescribeClsLogSetResponse> DescribeClsLogSet(DescribeClsLogSetRequest req)
        {
             JsonResponseModel<DescribeClsLogSetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClsLogSet");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClsLogSetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the CLB exclusive logset.
        /// </summary>
        /// <param name="req"><see cref="DescribeClsLogSetRequest"/></param>
        /// <returns><see cref="DescribeClsLogSetResponse"/></returns>
        public DescribeClsLogSetResponse DescribeClsLogSetSync(DescribeClsLogSetRequest req)
        {
             JsonResponseModel<DescribeClsLogSetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClsLogSet");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClsLogSetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Queries information of CVMs and ENIs that use cross-region binding 2.0
        /// </summary>
        /// <param name="req"><see cref="DescribeCrossTargetsRequest"/></param>
        /// <returns><see cref="DescribeCrossTargetsResponse"/></returns>
        public async Task<DescribeCrossTargetsResponse> DescribeCrossTargets(DescribeCrossTargetsRequest req)
        {
             JsonResponseModel<DescribeCrossTargetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCrossTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCrossTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Queries information of CVMs and ENIs that use cross-region binding 2.0
        /// </summary>
        /// <param name="req"><see cref="DescribeCrossTargetsRequest"/></param>
        /// <returns><see cref="DescribeCrossTargetsResponse"/></returns>
        public DescribeCrossTargetsResponse DescribeCrossTargetsSync(DescribeCrossTargetsRequest req)
        {
             JsonResponseModel<DescribeCrossTargetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCrossTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCrossTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the configured location, bound server or bound CLB instance. If there are domain names, the result will be filtered by domain name.
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomizedConfigAssociateListRequest"/></param>
        /// <returns><see cref="DescribeCustomizedConfigAssociateListResponse"/></returns>
        public async Task<DescribeCustomizedConfigAssociateListResponse> DescribeCustomizedConfigAssociateList(DescribeCustomizedConfigAssociateListRequest req)
        {
             JsonResponseModel<DescribeCustomizedConfigAssociateListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCustomizedConfigAssociateList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomizedConfigAssociateListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the configured location, bound server or bound CLB instance. If there are domain names, the result will be filtered by domain name.
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomizedConfigAssociateListRequest"/></param>
        /// <returns><see cref="DescribeCustomizedConfigAssociateListResponse"/></returns>
        public DescribeCustomizedConfigAssociateListResponse DescribeCustomizedConfigAssociateListSync(DescribeCustomizedConfigAssociateListRequest req)
        {
             JsonResponseModel<DescribeCustomizedConfigAssociateListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCustomizedConfigAssociateList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomizedConfigAssociateListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to pull custom configuration lists to return the user configuration of `AppId`.
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomizedConfigListRequest"/></param>
        /// <returns><see cref="DescribeCustomizedConfigListResponse"/></returns>
        public async Task<DescribeCustomizedConfigListResponse> DescribeCustomizedConfigList(DescribeCustomizedConfigListRequest req)
        {
             JsonResponseModel<DescribeCustomizedConfigListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCustomizedConfigList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomizedConfigListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to pull custom configuration lists to return the user configuration of `AppId`.
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomizedConfigListRequest"/></param>
        /// <returns><see cref="DescribeCustomizedConfigListResponse"/></returns>
        public DescribeCustomizedConfigListResponse DescribeCustomizedConfigListSync(DescribeCustomizedConfigListRequest req)
        {
             JsonResponseModel<DescribeCustomizedConfigListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCustomizedConfigList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomizedConfigListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Idle CLB instances are pay-as-you-go load balancers that, within seven days after the creation, do not have rules configured or the configured rules are not associated with any servers. 
        /// </summary>
        /// <param name="req"><see cref="DescribeIdleLoadBalancersRequest"/></param>
        /// <returns><see cref="DescribeIdleLoadBalancersResponse"/></returns>
        public async Task<DescribeIdleLoadBalancersResponse> DescribeIdleLoadBalancers(DescribeIdleLoadBalancersRequest req)
        {
             JsonResponseModel<DescribeIdleLoadBalancersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIdleLoadBalancers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIdleLoadBalancersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Idle CLB instances are pay-as-you-go load balancers that, within seven days after the creation, do not have rules configured or the configured rules are not associated with any servers. 
        /// </summary>
        /// <param name="req"><see cref="DescribeIdleLoadBalancersRequest"/></param>
        /// <returns><see cref="DescribeIdleLoadBalancersResponse"/></returns>
        public DescribeIdleLoadBalancersResponse DescribeIdleLoadBalancersSync(DescribeIdleLoadBalancersRequest req)
        {
             JsonResponseModel<DescribeIdleLoadBalancersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIdleLoadBalancers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIdleLoadBalancersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query CLB instances bound to the CVM or ENI.
        /// </summary>
        /// <param name="req"><see cref="DescribeLBListenersRequest"/></param>
        /// <returns><see cref="DescribeLBListenersResponse"/></returns>
        public async Task<DescribeLBListenersResponse> DescribeLBListeners(DescribeLBListenersRequest req)
        {
             JsonResponseModel<DescribeLBListenersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLBListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLBListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query CLB instances bound to the CVM or ENI.
        /// </summary>
        /// <param name="req"><see cref="DescribeLBListenersRequest"/></param>
        /// <returns><see cref="DescribeLBListenersResponse"/></returns>
        public DescribeLBListenersResponse DescribeLBListenersSync(DescribeLBListenersRequest req)
        {
             JsonResponseModel<DescribeLBListenersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLBListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLBListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of listeners by CLB ID, listener protocol, or listener port. If no filter is specified, all listeners for the CLB instance will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeListenersRequest"/></param>
        /// <returns><see cref="DescribeListenersResponse"/></returns>
        public async Task<DescribeListenersResponse> DescribeListeners(DescribeListenersRequest req)
        {
             JsonResponseModel<DescribeListenersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of listeners by CLB ID, listener protocol, or listener port. If no filter is specified, all listeners for the CLB instance will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeListenersRequest"/></param>
        /// <returns><see cref="DescribeListenersResponse"/></returns>
        public DescribeListenersResponse DescribeListenersSync(DescribeListenersRequest req)
        {
             JsonResponseModel<DescribeListenersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeListeners");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeListenersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of CLB instances associated with a certificate in a region by certificate ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancerListByCertIdRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancerListByCertIdResponse"/></returns>
        public async Task<DescribeLoadBalancerListByCertIdResponse> DescribeLoadBalancerListByCertId(DescribeLoadBalancerListByCertIdRequest req)
        {
             JsonResponseModel<DescribeLoadBalancerListByCertIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLoadBalancerListByCertId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoadBalancerListByCertIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of CLB instances associated with a certificate in a region by certificate ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancerListByCertIdRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancerListByCertIdResponse"/></returns>
        public DescribeLoadBalancerListByCertIdResponse DescribeLoadBalancerListByCertIdSync(DescribeLoadBalancerListByCertIdRequest req)
        {
             JsonResponseModel<DescribeLoadBalancerListByCertIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLoadBalancerListByCertId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoadBalancerListByCertIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Queries the total number of CLB instances and the number of CLB instances in different status (running, isolated and about to expire).
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancerOverviewRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancerOverviewResponse"/></returns>
        public async Task<DescribeLoadBalancerOverviewResponse> DescribeLoadBalancerOverview(DescribeLoadBalancerOverviewRequest req)
        {
             JsonResponseModel<DescribeLoadBalancerOverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLoadBalancerOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoadBalancerOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Queries the total number of CLB instances and the number of CLB instances in different status (running, isolated and about to expire).
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancerOverviewRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancerOverviewResponse"/></returns>
        public DescribeLoadBalancerOverviewResponse DescribeLoadBalancerOverviewSync(DescribeLoadBalancerOverviewRequest req)
        {
             JsonResponseModel<DescribeLoadBalancerOverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLoadBalancerOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoadBalancerOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query CLB instances with high traffic under the current account, and return the top 10 results. For queries using a sub-account, only the CLB instances authorized to the sub-account will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancerTrafficRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancerTrafficResponse"/></returns>
        public async Task<DescribeLoadBalancerTrafficResponse> DescribeLoadBalancerTraffic(DescribeLoadBalancerTrafficRequest req)
        {
             JsonResponseModel<DescribeLoadBalancerTrafficResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLoadBalancerTraffic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoadBalancerTrafficResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query CLB instances with high traffic under the current account, and return the top 10 results. For queries using a sub-account, only the CLB instances authorized to the sub-account will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancerTrafficRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancerTrafficResponse"/></returns>
        public DescribeLoadBalancerTrafficResponse DescribeLoadBalancerTrafficSync(DescribeLoadBalancerTrafficRequest req)
        {
             JsonResponseModel<DescribeLoadBalancerTrafficResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLoadBalancerTraffic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoadBalancerTrafficResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of CLB instances in a region.
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancersRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancersResponse"/></returns>
        public async Task<DescribeLoadBalancersResponse> DescribeLoadBalancers(DescribeLoadBalancersRequest req)
        {
             JsonResponseModel<DescribeLoadBalancersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLoadBalancers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoadBalancersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of CLB instances in a region.
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancersRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancersResponse"/></returns>
        public DescribeLoadBalancersResponse DescribeLoadBalancersSync(DescribeLoadBalancersRequest req)
        {
             JsonResponseModel<DescribeLoadBalancersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLoadBalancers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoadBalancersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query CLB instance details, including listener, rules, and target real servers.
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancersDetailRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancersDetailResponse"/></returns>
        public async Task<DescribeLoadBalancersDetailResponse> DescribeLoadBalancersDetail(DescribeLoadBalancersDetailRequest req)
        {
             JsonResponseModel<DescribeLoadBalancersDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLoadBalancersDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoadBalancersDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query CLB instance details, including listener, rules, and target real servers.
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancersDetailRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancersDetailResponse"/></returns>
        public DescribeLoadBalancersDetailResponse DescribeLoadBalancersDetailSync(DescribeLoadBalancersDetailRequest req)
        {
             JsonResponseModel<DescribeLoadBalancersDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLoadBalancersDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoadBalancersDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query various quotas in the current region.
        /// </summary>
        /// <param name="req"><see cref="DescribeQuotaRequest"/></param>
        /// <returns><see cref="DescribeQuotaResponse"/></returns>
        public async Task<DescribeQuotaResponse> DescribeQuota(DescribeQuotaRequest req)
        {
             JsonResponseModel<DescribeQuotaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query various quotas in the current region.
        /// </summary>
        /// <param name="req"><see cref="DescribeQuotaRequest"/></param>
        /// <returns><see cref="DescribeQuotaResponse"/></returns>
        public DescribeQuotaResponse DescribeQuotaSync(DescribeQuotaRequest req)
        {
             JsonResponseModel<DescribeQuotaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of AZs and resources supported for the user in the current region.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcesRequest"/></param>
        /// <returns><see cref="DescribeResourcesResponse"/></returns>
        public async Task<DescribeResourcesResponse> DescribeResources(DescribeResourcesRequest req)
        {
             JsonResponseModel<DescribeResourcesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of AZs and resources supported for the user in the current region.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcesRequest"/></param>
        /// <returns><see cref="DescribeResourcesResponse"/></returns>
        public DescribeResourcesResponse DescribeResourcesSync(DescribeResourcesRequest req)
        {
             JsonResponseModel<DescribeResourcesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeRewrite) is used to query the redirection relationship between the forwarding rules of a CLB instance by instance ID. If no listener ID or forwarding rule ID is specified, all redirection relationships in the instance will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeRewriteRequest"/></param>
        /// <returns><see cref="DescribeRewriteResponse"/></returns>
        public async Task<DescribeRewriteResponse> DescribeRewrite(DescribeRewriteRequest req)
        {
             JsonResponseModel<DescribeRewriteResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRewrite");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRewriteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeRewrite) is used to query the redirection relationship between the forwarding rules of a CLB instance by instance ID. If no listener ID or forwarding rule ID is specified, all redirection relationships in the instance will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeRewriteRequest"/></param>
        /// <returns><see cref="DescribeRewriteResponse"/></returns>
        public DescribeRewriteResponse DescribeRewriteSync(DescribeRewriteRequest req)
        {
             JsonResponseModel<DescribeRewriteResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRewrite");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRewriteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information of servers bound to a target group.
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupInstancesRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupInstancesResponse"/></returns>
        public async Task<DescribeTargetGroupInstancesResponse> DescribeTargetGroupInstances(DescribeTargetGroupInstancesRequest req)
        {
             JsonResponseModel<DescribeTargetGroupInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTargetGroupInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTargetGroupInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information of servers bound to a target group.
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupInstancesRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupInstancesResponse"/></returns>
        public DescribeTargetGroupInstancesResponse DescribeTargetGroupInstancesSync(DescribeTargetGroupInstancesRequest req)
        {
             JsonResponseModel<DescribeTargetGroupInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTargetGroupInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTargetGroupInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the target group list.
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupListRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupListResponse"/></returns>
        public async Task<DescribeTargetGroupListResponse> DescribeTargetGroupList(DescribeTargetGroupListRequest req)
        {
             JsonResponseModel<DescribeTargetGroupListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTargetGroupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTargetGroupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the target group list.
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupListRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupListResponse"/></returns>
        public DescribeTargetGroupListResponse DescribeTargetGroupListSync(DescribeTargetGroupListRequest req)
        {
             JsonResponseModel<DescribeTargetGroupListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTargetGroupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTargetGroupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the target group information.
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupsRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupsResponse"/></returns>
        public async Task<DescribeTargetGroupsResponse> DescribeTargetGroups(DescribeTargetGroupsRequest req)
        {
             JsonResponseModel<DescribeTargetGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTargetGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTargetGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the target group information.
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetGroupsRequest"/></param>
        /// <returns><see cref="DescribeTargetGroupsResponse"/></returns>
        public DescribeTargetGroupsResponse DescribeTargetGroupsSync(DescribeTargetGroupsRequest req)
        {
             JsonResponseModel<DescribeTargetGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTargetGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTargetGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeTargetHealth) is used to query the health check result of a real server of a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetHealthRequest"/></param>
        /// <returns><see cref="DescribeTargetHealthResponse"/></returns>
        public async Task<DescribeTargetHealthResponse> DescribeTargetHealth(DescribeTargetHealthRequest req)
        {
             JsonResponseModel<DescribeTargetHealthResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTargetHealth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTargetHealthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeTargetHealth) is used to query the health check result of a real server of a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetHealthRequest"/></param>
        /// <returns><see cref="DescribeTargetHealthResponse"/></returns>
        public DescribeTargetHealthResponse DescribeTargetHealthSync(DescribeTargetHealthRequest req)
        {
             JsonResponseModel<DescribeTargetHealthResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTargetHealth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTargetHealthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeTargets) is used to query the list of real servers bound to some listeners of a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetsRequest"/></param>
        /// <returns><see cref="DescribeTargetsResponse"/></returns>
        public async Task<DescribeTargetsResponse> DescribeTargets(DescribeTargetsRequest req)
        {
             JsonResponseModel<DescribeTargetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeTargets) is used to query the list of real servers bound to some listeners of a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetsRequest"/></param>
        /// <returns><see cref="DescribeTargetsResponse"/></returns>
        public DescribeTargetsResponse DescribeTargetsSync(DescribeTargetsRequest req)
        {
             JsonResponseModel<DescribeTargetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the execution status of an async task. After non-query APIs (used to create/delete CLB instances, listeners, or rules or to bind/unbind real servers) are called successfully, this API needs to be used to query whether the task is successful.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskStatusResponse"/></returns>
        public async Task<DescribeTaskStatusResponse> DescribeTaskStatus(DescribeTaskStatusRequest req)
        {
             JsonResponseModel<DescribeTaskStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the execution status of an async task. After non-query APIs (used to create/delete CLB instances, listeners, or rules or to bind/unbind real servers) are called successfully, this API needs to be used to query whether the task is successful.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskStatusResponse"/></returns>
        public DescribeTaskStatusResponse DescribeTaskStatusSync(DescribeTaskStatusRequest req)
        {
             JsonResponseModel<DescribeTaskStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind target groups from a rule.
        /// This is an async API. After it is returned successfully, you can call the `DescribeTaskStatus` API with the returned `RequestID` as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="DisassociateTargetGroupsRequest"/></param>
        /// <returns><see cref="DisassociateTargetGroupsResponse"/></returns>
        public async Task<DisassociateTargetGroupsResponse> DisassociateTargetGroups(DisassociateTargetGroupsRequest req)
        {
             JsonResponseModel<DisassociateTargetGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisassociateTargetGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateTargetGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind target groups from a rule.
        /// This is an async API. After it is returned successfully, you can call the `DescribeTaskStatus` API with the returned `RequestID` as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="DisassociateTargetGroupsRequest"/></param>
        /// <returns><see cref="DisassociateTargetGroupsResponse"/></returns>
        public DisassociateTargetGroupsResponse DisassociateTargetGroupsSync(DisassociateTargetGroupsRequest req)
        {
             JsonResponseModel<DisassociateTargetGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisassociateTargetGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateTargetGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// After the original access address and the address to be redirected are configured manually, the system will automatically redirect requests made to the original access address to the target address of the corresponding path. Multiple paths can be configured as a redirection policy under one domain name to achieve automatic redirection between HTTP and HTTPS. A redirection policy should meet the following rules: if A has already been redirected to B, then it cannot be redirected to C (unless the original redirection relationship is deleted and a new one is created), and B cannot be redirected to any other addresses.
        /// </summary>
        /// <param name="req"><see cref="ManualRewriteRequest"/></param>
        /// <returns><see cref="ManualRewriteResponse"/></returns>
        public async Task<ManualRewriteResponse> ManualRewrite(ManualRewriteRequest req)
        {
             JsonResponseModel<ManualRewriteResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ManualRewrite");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ManualRewriteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// After the original access address and the address to be redirected are configured manually, the system will automatically redirect requests made to the original access address to the target address of the corresponding path. Multiple paths can be configured as a redirection policy under one domain name to achieve automatic redirection between HTTP and HTTPS. A redirection policy should meet the following rules: if A has already been redirected to B, then it cannot be redirected to C (unless the original redirection relationship is deleted and a new one is created), and B cannot be redirected to any other addresses.
        /// </summary>
        /// <param name="req"><see cref="ManualRewriteRequest"/></param>
        /// <returns><see cref="ManualRewriteResponse"/></returns>
        public ManualRewriteResponse ManualRewriteSync(ManualRewriteRequest req)
        {
             JsonResponseModel<ManualRewriteResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ManualRewrite");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ManualRewriteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upgrade classic CLB instances to application CLB instances.
        /// This is an async API. After it is returned successfully, you can check the action result by calling `DescribeLoadBalancers`. 
        /// </summary>
        /// <param name="req"><see cref="MigrateClassicalLoadBalancersRequest"/></param>
        /// <returns><see cref="MigrateClassicalLoadBalancersResponse"/></returns>
        public async Task<MigrateClassicalLoadBalancersResponse> MigrateClassicalLoadBalancers(MigrateClassicalLoadBalancersRequest req)
        {
             JsonResponseModel<MigrateClassicalLoadBalancersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "MigrateClassicalLoadBalancers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MigrateClassicalLoadBalancersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upgrade classic CLB instances to application CLB instances.
        /// This is an async API. After it is returned successfully, you can check the action result by calling `DescribeLoadBalancers`. 
        /// </summary>
        /// <param name="req"><see cref="MigrateClassicalLoadBalancersRequest"/></param>
        /// <returns><see cref="MigrateClassicalLoadBalancersResponse"/></returns>
        public MigrateClassicalLoadBalancersResponse MigrateClassicalLoadBalancersSync(MigrateClassicalLoadBalancersRequest req)
        {
             JsonResponseModel<MigrateClassicalLoadBalancersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "MigrateClassicalLoadBalancers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MigrateClassicalLoadBalancersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the client IP blocklist of a CLB instance. One forwarding rule supports blocking up to 2,000,000 IPs. One blocklist can contain up to 2,000,000 entries.
        /// (This API is in beta test. To use it, please submit a ticket.)
        /// </summary>
        /// <param name="req"><see cref="ModifyBlockIPListRequest"/></param>
        /// <returns><see cref="ModifyBlockIPListResponse"/></returns>
        public async Task<ModifyBlockIPListResponse> ModifyBlockIPList(ModifyBlockIPListRequest req)
        {
             JsonResponseModel<ModifyBlockIPListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBlockIPList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBlockIPListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the client IP blocklist of a CLB instance. One forwarding rule supports blocking up to 2,000,000 IPs. One blocklist can contain up to 2,000,000 entries.
        /// (This API is in beta test. To use it, please submit a ticket.)
        /// </summary>
        /// <param name="req"><see cref="ModifyBlockIPListRequest"/></param>
        /// <returns><see cref="ModifyBlockIPListResponse"/></returns>
        public ModifyBlockIPListResponse ModifyBlockIPListSync(ModifyBlockIPListRequest req)
        {
             JsonResponseModel<ModifyBlockIPListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyBlockIPList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBlockIPListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyDomain) is used to modify a domain name under a layer-7 CLB listener.
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainRequest"/></param>
        /// <returns><see cref="ModifyDomainResponse"/></returns>
        public async Task<ModifyDomainResponse> ModifyDomain(ModifyDomainRequest req)
        {
             JsonResponseModel<ModifyDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyDomain) is used to modify a domain name under a layer-7 CLB listener.
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainRequest"/></param>
        /// <returns><see cref="ModifyDomainResponse"/></returns>
        public ModifyDomainResponse ModifyDomainSync(ModifyDomainRequest req)
        {
             JsonResponseModel<ModifyDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the domain name-level attributes of a layer-7 listener's forwarding rule, such as modifying the domain name, changing the DefaultServer, enabling/disabling HTTP/2, and modifying certificates.
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestId as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainAttributesRequest"/></param>
        /// <returns><see cref="ModifyDomainAttributesResponse"/></returns>
        public async Task<ModifyDomainAttributesResponse> ModifyDomainAttributes(ModifyDomainAttributesRequest req)
        {
             JsonResponseModel<ModifyDomainAttributesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDomainAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the domain name-level attributes of a layer-7 listener's forwarding rule, such as modifying the domain name, changing the DefaultServer, enabling/disabling HTTP/2, and modifying certificates.
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestId as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainAttributesRequest"/></param>
        /// <returns><see cref="ModifyDomainAttributesResponse"/></returns>
        public ModifyDomainAttributesResponse ModifyDomainAttributesSync(ModifyDomainAttributesRequest req)
        {
             JsonResponseModel<ModifyDomainAttributesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDomainAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyListener) is used to modify the attributes of a CLB listener, such as listener name, health check parameter, certificate information, and forwarding policy.
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyListenerRequest"/></param>
        /// <returns><see cref="ModifyListenerResponse"/></returns>
        public async Task<ModifyListenerResponse> ModifyListener(ModifyListenerRequest req)
        {
             JsonResponseModel<ModifyListenerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyListener");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyListenerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyListener) is used to modify the attributes of a CLB listener, such as listener name, health check parameter, certificate information, and forwarding policy.
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyListenerRequest"/></param>
        /// <returns><see cref="ModifyListenerResponse"/></returns>
        public ModifyListenerResponse ModifyListenerSync(ModifyListenerRequest req)
        {
             JsonResponseModel<ModifyListenerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyListener");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyListenerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of a CLB instance such as name and cross-region attributes.
        /// This is an async API. After it is returned successfully, you can check the task result by calling `DescribeTaskStatus` with the returned `RequestID`.
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerAttributesRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerAttributesResponse"/></returns>
        public async Task<ModifyLoadBalancerAttributesResponse> ModifyLoadBalancerAttributes(ModifyLoadBalancerAttributesRequest req)
        {
             JsonResponseModel<ModifyLoadBalancerAttributesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLoadBalancerAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLoadBalancerAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of a CLB instance such as name and cross-region attributes.
        /// This is an async API. After it is returned successfully, you can check the task result by calling `DescribeTaskStatus` with the returned `RequestID`.
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerAttributesRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerAttributesResponse"/></returns>
        public ModifyLoadBalancerAttributesResponse ModifyLoadBalancerAttributesSync(ModifyLoadBalancerAttributesRequest req)
        {
             JsonResponseModel<ModifyLoadBalancerAttributesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLoadBalancerAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLoadBalancerAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upgrade shared CLB instances to LCU-supported CLB instances.
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerSlaRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerSlaResponse"/></returns>
        public async Task<ModifyLoadBalancerSlaResponse> ModifyLoadBalancerSla(ModifyLoadBalancerSlaRequest req)
        {
             JsonResponseModel<ModifyLoadBalancerSlaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLoadBalancerSla");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLoadBalancerSlaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upgrade shared CLB instances to LCU-supported CLB instances.
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerSlaRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerSlaResponse"/></returns>
        public ModifyLoadBalancerSlaResponse ModifyLoadBalancerSlaSync(ModifyLoadBalancerSlaRequest req)
        {
             JsonResponseModel<ModifyLoadBalancerSlaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLoadBalancerSla");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLoadBalancerSlaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyRule) is used to modify the attributes of a forwarding rule under a layer-7 CLB listener, such as forwarding path, health check attribute, and forwarding policy.
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleRequest"/></param>
        /// <returns><see cref="ModifyRuleResponse"/></returns>
        public async Task<ModifyRuleResponse> ModifyRule(ModifyRuleRequest req)
        {
             JsonResponseModel<ModifyRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyRule) is used to modify the attributes of a forwarding rule under a layer-7 CLB listener, such as forwarding path, health check attribute, and forwarding policy.
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleRequest"/></param>
        /// <returns><see cref="ModifyRuleResponse"/></returns>
        public ModifyRuleResponse ModifyRuleSync(ModifyRuleRequest req)
        {
             JsonResponseModel<ModifyRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to rename a target group or modify its default port attribute.
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyTargetGroupAttributeResponse"/></returns>
        public async Task<ModifyTargetGroupAttributeResponse> ModifyTargetGroupAttribute(ModifyTargetGroupAttributeRequest req)
        {
             JsonResponseModel<ModifyTargetGroupAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTargetGroupAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTargetGroupAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to rename a target group or modify its default port attribute.
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyTargetGroupAttributeResponse"/></returns>
        public ModifyTargetGroupAttributeResponse ModifyTargetGroupAttributeSync(ModifyTargetGroupAttributeRequest req)
        {
             JsonResponseModel<ModifyTargetGroupAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTargetGroupAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTargetGroupAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify server ports of a target group in batches.
        /// This is an async API. After it is returned successfully, you can call the `DescribeTaskStatus` API with the returned `RequestID` as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetGroupInstancesPortRequest"/></param>
        /// <returns><see cref="ModifyTargetGroupInstancesPortResponse"/></returns>
        public async Task<ModifyTargetGroupInstancesPortResponse> ModifyTargetGroupInstancesPort(ModifyTargetGroupInstancesPortRequest req)
        {
             JsonResponseModel<ModifyTargetGroupInstancesPortResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTargetGroupInstancesPort");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTargetGroupInstancesPortResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify server ports of a target group in batches.
        /// This is an async API. After it is returned successfully, you can call the `DescribeTaskStatus` API with the returned `RequestID` as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetGroupInstancesPortRequest"/></param>
        /// <returns><see cref="ModifyTargetGroupInstancesPortResponse"/></returns>
        public ModifyTargetGroupInstancesPortResponse ModifyTargetGroupInstancesPortSync(ModifyTargetGroupInstancesPortRequest req)
        {
             JsonResponseModel<ModifyTargetGroupInstancesPortResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTargetGroupInstancesPort");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTargetGroupInstancesPortResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify server weights of a target group in batches.
        /// This is an async API. After it is returned successfully, you can call the `DescribeTaskStatus` API with the returned `RequestID` as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetGroupInstancesWeightRequest"/></param>
        /// <returns><see cref="ModifyTargetGroupInstancesWeightResponse"/></returns>
        public async Task<ModifyTargetGroupInstancesWeightResponse> ModifyTargetGroupInstancesWeight(ModifyTargetGroupInstancesWeightRequest req)
        {
             JsonResponseModel<ModifyTargetGroupInstancesWeightResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTargetGroupInstancesWeight");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTargetGroupInstancesWeightResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify server weights of a target group in batches.
        /// This is an async API. After it is returned successfully, you can call the `DescribeTaskStatus` API with the returned `RequestID` as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetGroupInstancesWeightRequest"/></param>
        /// <returns><see cref="ModifyTargetGroupInstancesWeightResponse"/></returns>
        public ModifyTargetGroupInstancesWeightResponse ModifyTargetGroupInstancesWeightSync(ModifyTargetGroupInstancesWeightRequest req)
        {
             JsonResponseModel<ModifyTargetGroupInstancesWeightResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTargetGroupInstancesWeight");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTargetGroupInstancesWeightResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyTargetPort) is used to modify the port of a real server bound to a listener.
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetPortRequest"/></param>
        /// <returns><see cref="ModifyTargetPortResponse"/></returns>
        public async Task<ModifyTargetPortResponse> ModifyTargetPort(ModifyTargetPortRequest req)
        {
             JsonResponseModel<ModifyTargetPortResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTargetPort");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTargetPortResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyTargetPort) is used to modify the port of a real server bound to a listener.
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetPortRequest"/></param>
        /// <returns><see cref="ModifyTargetPortResponse"/></returns>
        public ModifyTargetPortResponse ModifyTargetPortSync(ModifyTargetPortRequest req)
        {
             JsonResponseModel<ModifyTargetPortResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTargetPort");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTargetPortResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyTargetWeight) is used to modify the forwarding weight of a real server bound to a CLB instance.
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetWeightRequest"/></param>
        /// <returns><see cref="ModifyTargetWeightResponse"/></returns>
        public async Task<ModifyTargetWeightResponse> ModifyTargetWeight(ModifyTargetWeightRequest req)
        {
             JsonResponseModel<ModifyTargetWeightResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTargetWeight");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTargetWeightResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyTargetWeight) is used to modify the forwarding weight of a real server bound to a CLB instance.
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetWeightRequest"/></param>
        /// <returns><see cref="ModifyTargetWeightResponse"/></returns>
        public ModifyTargetWeightResponse ModifyTargetWeightSync(ModifyTargetWeightRequest req)
        {
             JsonResponseModel<ModifyTargetWeightResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTargetWeight");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTargetWeightResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind an SCF function with the L7 forwarding rule of a CLB instance. Note that you need to create an L7 listener (HTTP, HTTPS) and forwarding rule first.
        /// This is an async API. After it is returned successfully, you can call the `DescribeTaskStatus` API with the returned `RequestID` as an input parameter to check whether this task is successful.<br/>
        /// **Limits:**
        /// - Binding with SCF is only available in Guangzhou, Shenzhen Finance, Shanghai, Shanghai Finance, Beijing, Chengdu, Hong Kong (China), Singapore, Mumbai, Tokyo, and Silicon Valley.
        /// - SCF functions can only be bound with CLB instances of bill-by-IP accounts but not with bill-by-CVM accounts. If you are using a bill-by-CVM account, we recommend upgrading it to a bill-by-IP account. For more information, please see [Checking Account Type](https://intl.cloud.tencent.com/document/product/1199/49090?from_cn_redirect=1). 
        /// - SCF functions cannot be bound with classic CLB instances.
        /// - SCF functions cannot be bound with classic network-based CLB instances.
        /// - SCF functions in the same region can be bound with CLB instances. SCF functions can only be bound across VPCs but not regions.
        /// - SCF functions can only be bound with IPv4 and IPv6 NAT64 CLB instances, but currently not with IPv6 CLB instances.
        /// - SCF functions can only be bound with layer-7 HTTP and HTTPS listeners, but not with layer-7 QUIC listeners or layer-4 (TCP, UDP, and TCP SSL) listeners.
        /// - Only SCF event-triggered functions can be bound with CLB instances.
        /// </summary>
        /// <param name="req"><see cref="RegisterFunctionTargetsRequest"/></param>
        /// <returns><see cref="RegisterFunctionTargetsResponse"/></returns>
        public async Task<RegisterFunctionTargetsResponse> RegisterFunctionTargets(RegisterFunctionTargetsRequest req)
        {
             JsonResponseModel<RegisterFunctionTargetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RegisterFunctionTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterFunctionTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind an SCF function with the L7 forwarding rule of a CLB instance. Note that you need to create an L7 listener (HTTP, HTTPS) and forwarding rule first.
        /// This is an async API. After it is returned successfully, you can call the `DescribeTaskStatus` API with the returned `RequestID` as an input parameter to check whether this task is successful.<br/>
        /// **Limits:**
        /// - Binding with SCF is only available in Guangzhou, Shenzhen Finance, Shanghai, Shanghai Finance, Beijing, Chengdu, Hong Kong (China), Singapore, Mumbai, Tokyo, and Silicon Valley.
        /// - SCF functions can only be bound with CLB instances of bill-by-IP accounts but not with bill-by-CVM accounts. If you are using a bill-by-CVM account, we recommend upgrading it to a bill-by-IP account. For more information, please see [Checking Account Type](https://intl.cloud.tencent.com/document/product/1199/49090?from_cn_redirect=1). 
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
             JsonResponseModel<RegisterFunctionTargetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RegisterFunctionTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterFunctionTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to register servers to a target group.
        /// This is an async API. After it is returned successfully, you can call the `DescribeTaskStatus` API with the returned `RequestID` as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="RegisterTargetGroupInstancesRequest"/></param>
        /// <returns><see cref="RegisterTargetGroupInstancesResponse"/></returns>
        public async Task<RegisterTargetGroupInstancesResponse> RegisterTargetGroupInstances(RegisterTargetGroupInstancesRequest req)
        {
             JsonResponseModel<RegisterTargetGroupInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RegisterTargetGroupInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterTargetGroupInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to register servers to a target group.
        /// This is an async API. After it is returned successfully, you can call the `DescribeTaskStatus` API with the returned `RequestID` as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="RegisterTargetGroupInstancesRequest"/></param>
        /// <returns><see cref="RegisterTargetGroupInstancesResponse"/></returns>
        public RegisterTargetGroupInstancesResponse RegisterTargetGroupInstancesSync(RegisterTargetGroupInstancesRequest req)
        {
             JsonResponseModel<RegisterTargetGroupInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RegisterTargetGroupInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterTargetGroupInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (RegisterTargets) is used to bind one or more real servers to a CLB listener or layer-7 forwarding rule. Before using this API, you need to create relevant layer-4 listeners or layer-7 forwarding rules. For the former (TCP/UDP), only the listener ID needs to be specified, while for the latter (HTTP/HTTPS), the forwarding rule also needs to be specified through LocationId or Domain+Url.
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="RegisterTargetsRequest"/></param>
        /// <returns><see cref="RegisterTargetsResponse"/></returns>
        public async Task<RegisterTargetsResponse> RegisterTargets(RegisterTargetsRequest req)
        {
             JsonResponseModel<RegisterTargetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RegisterTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (RegisterTargets) is used to bind one or more real servers to a CLB listener or layer-7 forwarding rule. Before using this API, you need to create relevant layer-4 listeners or layer-7 forwarding rules. For the former (TCP/UDP), only the listener ID needs to be specified, while for the latter (HTTP/HTTPS), the forwarding rule also needs to be specified through LocationId or Domain+Url.
        /// This is an async API. After it is returned successfully, you can call the DescribeTaskStatus API with the returned RequestID as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="RegisterTargetsRequest"/></param>
        /// <returns><see cref="RegisterTargetsResponse"/></returns>
        public RegisterTargetsResponse RegisterTargetsSync(RegisterTargetsRequest req)
        {
             JsonResponseModel<RegisterTargetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RegisterTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind a real server with a classic CLB instance. This is an async API. After it is returned successfully, you can call the API `DescribeTaskStatus` with the returned RequestId as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="RegisterTargetsWithClassicalLBRequest"/></param>
        /// <returns><see cref="RegisterTargetsWithClassicalLBResponse"/></returns>
        public async Task<RegisterTargetsWithClassicalLBResponse> RegisterTargetsWithClassicalLB(RegisterTargetsWithClassicalLBRequest req)
        {
             JsonResponseModel<RegisterTargetsWithClassicalLBResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RegisterTargetsWithClassicalLB");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterTargetsWithClassicalLBResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind a real server with a classic CLB instance. This is an async API. After it is returned successfully, you can call the API `DescribeTaskStatus` with the returned RequestId as an input parameter to check whether this task is successful.
        /// </summary>
        /// <param name="req"><see cref="RegisterTargetsWithClassicalLBRequest"/></param>
        /// <returns><see cref="RegisterTargetsWithClassicalLBResponse"/></returns>
        public RegisterTargetsWithClassicalLBResponse RegisterTargetsWithClassicalLBSync(RegisterTargetsWithClassicalLBRequest req)
        {
             JsonResponseModel<RegisterTargetsWithClassicalLBResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RegisterTargetsWithClassicalLB");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterTargetsWithClassicalLBResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ReplaceCertForLoadBalancers) is used to replace the certificate associated with a CLB instance. A new certificates can be associated with a CLB only after the original certificate is disassociated from it.
        /// This API supports replacing server certificates and client certificates.
        /// The new certificate to be used can be specified by passing in the certificate ID. If no certificate ID is specified, relevant information such as certificate content must be passed in to create a new certificate and bind it to the CLB.
        /// Note: This API can only be called in the Guangzhou region; for other regions, an error will occur due to domain name resolution problems.
        /// </summary>
        /// <param name="req"><see cref="ReplaceCertForLoadBalancersRequest"/></param>
        /// <returns><see cref="ReplaceCertForLoadBalancersResponse"/></returns>
        public async Task<ReplaceCertForLoadBalancersResponse> ReplaceCertForLoadBalancers(ReplaceCertForLoadBalancersRequest req)
        {
             JsonResponseModel<ReplaceCertForLoadBalancersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReplaceCertForLoadBalancers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReplaceCertForLoadBalancersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<ReplaceCertForLoadBalancersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReplaceCertForLoadBalancers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReplaceCertForLoadBalancersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create or manage a user-defined CLB configuration template.
        /// </summary>
        /// <param name="req"><see cref="SetCustomizedConfigForLoadBalancerRequest"/></param>
        /// <returns><see cref="SetCustomizedConfigForLoadBalancerResponse"/></returns>
        public async Task<SetCustomizedConfigForLoadBalancerResponse> SetCustomizedConfigForLoadBalancer(SetCustomizedConfigForLoadBalancerRequest req)
        {
             JsonResponseModel<SetCustomizedConfigForLoadBalancerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetCustomizedConfigForLoadBalancer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetCustomizedConfigForLoadBalancerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create or manage a user-defined CLB configuration template.
        /// </summary>
        /// <param name="req"><see cref="SetCustomizedConfigForLoadBalancerRequest"/></param>
        /// <returns><see cref="SetCustomizedConfigForLoadBalancerResponse"/></returns>
        public SetCustomizedConfigForLoadBalancerResponse SetCustomizedConfigForLoadBalancerSync(SetCustomizedConfigForLoadBalancerRequest req)
        {
             JsonResponseModel<SetCustomizedConfigForLoadBalancerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetCustomizedConfigForLoadBalancer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetCustomizedConfigForLoadBalancerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add, delete, and update the CLS topic of a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="SetLoadBalancerClsLogRequest"/></param>
        /// <returns><see cref="SetLoadBalancerClsLogResponse"/></returns>
        public async Task<SetLoadBalancerClsLogResponse> SetLoadBalancerClsLog(SetLoadBalancerClsLogRequest req)
        {
             JsonResponseModel<SetLoadBalancerClsLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetLoadBalancerClsLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetLoadBalancerClsLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add, delete, and update the CLS topic of a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="SetLoadBalancerClsLogRequest"/></param>
        /// <returns><see cref="SetLoadBalancerClsLogResponse"/></returns>
        public SetLoadBalancerClsLogResponse SetLoadBalancerClsLogSync(SetLoadBalancerClsLogRequest req)
        {
             JsonResponseModel<SetLoadBalancerClsLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetLoadBalancerClsLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetLoadBalancerClsLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (SetLoadBalancerSecurityGroups) is used to bind/unbind security groups for a public network CLB instance. You can use the DescribeLoadBalancers API to query the security groups bound to a CLB instance. This API uses `set` semantics.
        /// During a binding operation, the input parameters need to be all security groups to be bound to the CLB instance (including those already bound ones and new ones).
        /// During an unbinding operation, the input parameters need to be all the security groups still bound to the CLB instance after the unbinding operation. To unbind all security groups, you can leave this parameter empty or pass in an empty array. Note: Private network CLB do not support binding security groups.
        /// </summary>
        /// <param name="req"><see cref="SetLoadBalancerSecurityGroupsRequest"/></param>
        /// <returns><see cref="SetLoadBalancerSecurityGroupsResponse"/></returns>
        public async Task<SetLoadBalancerSecurityGroupsResponse> SetLoadBalancerSecurityGroups(SetLoadBalancerSecurityGroupsRequest req)
        {
             JsonResponseModel<SetLoadBalancerSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetLoadBalancerSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetLoadBalancerSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (SetLoadBalancerSecurityGroups) is used to bind/unbind security groups for a public network CLB instance. You can use the DescribeLoadBalancers API to query the security groups bound to a CLB instance. This API uses `set` semantics.
        /// During a binding operation, the input parameters need to be all security groups to be bound to the CLB instance (including those already bound ones and new ones).
        /// During an unbinding operation, the input parameters need to be all the security groups still bound to the CLB instance after the unbinding operation. To unbind all security groups, you can leave this parameter empty or pass in an empty array. Note: Private network CLB do not support binding security groups.
        /// </summary>
        /// <param name="req"><see cref="SetLoadBalancerSecurityGroupsRequest"/></param>
        /// <returns><see cref="SetLoadBalancerSecurityGroupsResponse"/></returns>
        public SetLoadBalancerSecurityGroupsResponse SetLoadBalancerSecurityGroupsSync(SetLoadBalancerSecurityGroupsRequest req)
        {
             JsonResponseModel<SetLoadBalancerSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetLoadBalancerSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetLoadBalancerSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind or unbind a security group for multiple public network CLB instances. Note: Private network CLB do not support binding security groups.
        /// </summary>
        /// <param name="req"><see cref="SetSecurityGroupForLoadbalancersRequest"/></param>
        /// <returns><see cref="SetSecurityGroupForLoadbalancersResponse"/></returns>
        public async Task<SetSecurityGroupForLoadbalancersResponse> SetSecurityGroupForLoadbalancers(SetSecurityGroupForLoadbalancersRequest req)
        {
             JsonResponseModel<SetSecurityGroupForLoadbalancersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetSecurityGroupForLoadbalancers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetSecurityGroupForLoadbalancersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind or unbind a security group for multiple public network CLB instances. Note: Private network CLB do not support binding security groups.
        /// </summary>
        /// <param name="req"><see cref="SetSecurityGroupForLoadbalancersRequest"/></param>
        /// <returns><see cref="SetSecurityGroupForLoadbalancersResponse"/></returns>
        public SetSecurityGroupForLoadbalancersResponse SetSecurityGroupForLoadbalancersSync(SetSecurityGroupForLoadbalancersRequest req)
        {
             JsonResponseModel<SetSecurityGroupForLoadbalancersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetSecurityGroupForLoadbalancers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetSecurityGroupForLoadbalancersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
