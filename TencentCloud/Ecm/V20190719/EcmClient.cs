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

namespace TencentCloud.Ecm.V20190719
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ecm.V20190719.Models;

   public class EcmClient : AbstractClient{

       private const string endpoint = "ecm.tencentcloudapi.com";
       private const string version = "2019-07-19";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public EcmClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public EcmClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to apply for one or multiple EIPs.
        /// </summary>
        /// <param name="req"><see cref="AllocateAddressesRequest"/></param>
        /// <returns><see cref="AllocateAddressesResponse"/></returns>
        public async Task<AllocateAddressesResponse> AllocateAddresses(AllocateAddressesRequest req)
        {
             JsonResponseModel<AllocateAddressesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AllocateAddresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AllocateAddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to apply for one or multiple EIPs.
        /// </summary>
        /// <param name="req"><see cref="AllocateAddressesRequest"/></param>
        /// <returns><see cref="AllocateAddressesResponse"/></returns>
        public AllocateAddressesResponse AllocateAddressesSync(AllocateAddressesRequest req)
        {
             JsonResponseModel<AllocateAddressesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AllocateAddresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AllocateAddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to apply for an IPv6 address for an ENI.
        /// </summary>
        /// <param name="req"><see cref="AssignIpv6AddressesRequest"/></param>
        /// <returns><see cref="AssignIpv6AddressesResponse"/></returns>
        public async Task<AssignIpv6AddressesResponse> AssignIpv6Addresses(AssignIpv6AddressesRequest req)
        {
             JsonResponseModel<AssignIpv6AddressesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssignIpv6Addresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssignIpv6AddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to apply for an IPv6 address for an ENI.
        /// </summary>
        /// <param name="req"><see cref="AssignIpv6AddressesRequest"/></param>
        /// <returns><see cref="AssignIpv6AddressesResponse"/></returns>
        public AssignIpv6AddressesResponse AssignIpv6AddressesSync(AssignIpv6AddressesRequest req)
        {
             JsonResponseModel<AssignIpv6AddressesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssignIpv6Addresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssignIpv6AddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to apply for a private IP for an ENI.
        /// </summary>
        /// <param name="req"><see cref="AssignPrivateIpAddressesRequest"/></param>
        /// <returns><see cref="AssignPrivateIpAddressesResponse"/></returns>
        public async Task<AssignPrivateIpAddressesResponse> AssignPrivateIpAddresses(AssignPrivateIpAddressesRequest req)
        {
             JsonResponseModel<AssignPrivateIpAddressesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssignPrivateIpAddresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssignPrivateIpAddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to apply for a private IP for an ENI.
        /// </summary>
        /// <param name="req"><see cref="AssignPrivateIpAddressesRequest"/></param>
        /// <returns><see cref="AssignPrivateIpAddressesResponse"/></returns>
        public AssignPrivateIpAddressesResponse AssignPrivateIpAddressesSync(AssignPrivateIpAddressesRequest req)
        {
             JsonResponseModel<AssignPrivateIpAddressesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssignPrivateIpAddresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssignPrivateIpAddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind an EIP to an instance or the specified private IP of an ENI.
        /// Binding an EIP to an instance (ECM) is essentially to bind it to the primary private IP of the primary ENI of the instance.
        /// When you bind an EIP to the private IP of the specified ENI, if the private IP is already bound to an EIP or public IP, a failure will be reported, and you must unbind it first before you can bind it to a new EIP.
        /// Only EIPs in `UNBIND` status can be bound to a private IP.
        /// </summary>
        /// <param name="req"><see cref="AssociateAddressRequest"/></param>
        /// <returns><see cref="AssociateAddressResponse"/></returns>
        public async Task<AssociateAddressResponse> AssociateAddress(AssociateAddressRequest req)
        {
             JsonResponseModel<AssociateAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssociateAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind an EIP to an instance or the specified private IP of an ENI.
        /// Binding an EIP to an instance (ECM) is essentially to bind it to the primary private IP of the primary ENI of the instance.
        /// When you bind an EIP to the private IP of the specified ENI, if the private IP is already bound to an EIP or public IP, a failure will be reported, and you must unbind it first before you can bind it to a new EIP.
        /// Only EIPs in `UNBIND` status can be bound to a private IP.
        /// </summary>
        /// <param name="req"><see cref="AssociateAddressRequest"/></param>
        /// <returns><see cref="AssociateAddressResponse"/></returns>
        public AssociateAddressResponse AssociateAddressSync(AssociateAddressRequest req)
        {
             JsonResponseModel<AssociateAddressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssociateAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind a security group.
        /// </summary>
        /// <param name="req"><see cref="AssociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateSecurityGroupsResponse"/></returns>
        public async Task<AssociateSecurityGroupsResponse> AssociateSecurityGroups(AssociateSecurityGroupsRequest req)
        {
             JsonResponseModel<AssociateSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssociateSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind a security group.
        /// </summary>
        /// <param name="req"><see cref="AssociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateSecurityGroupsResponse"/></returns>
        public AssociateSecurityGroupsResponse AssociateSecurityGroupsSync(AssociateSecurityGroupsRequest req)
        {
             JsonResponseModel<AssociateSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssociateSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind an ENI to a CVM instance.
        /// </summary>
        /// <param name="req"><see cref="AttachNetworkInterfaceRequest"/></param>
        /// <returns><see cref="AttachNetworkInterfaceResponse"/></returns>
        public async Task<AttachNetworkInterfaceResponse> AttachNetworkInterface(AttachNetworkInterfaceRequest req)
        {
             JsonResponseModel<AttachNetworkInterfaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AttachNetworkInterface");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachNetworkInterfaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind an ENI to a CVM instance.
        /// </summary>
        /// <param name="req"><see cref="AttachNetworkInterfaceRequest"/></param>
        /// <returns><see cref="AttachNetworkInterfaceResponse"/></returns>
        public AttachNetworkInterfaceResponse AttachNetworkInterfaceSync(AttachNetworkInterfaceRequest req)
        {
             JsonResponseModel<AttachNetworkInterfaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AttachNetworkInterface");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachNetworkInterfaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to batch unbind real servers.
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
        /// This API is used to batch unbind real servers.
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
        /// This API is used to batch modify the forwarding weights of the real servers bound to a listener.
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
        /// This API is used to batch modify the forwarding weights of the real servers bound to a listener.
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
        /// This API is used to batch bind backend targets.
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
        /// This API is used to batch bind backend targets.
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
        /// This API is used to create an HAVIP.
        /// </summary>
        /// <param name="req"><see cref="CreateHaVipRequest"/></param>
        /// <returns><see cref="CreateHaVipResponse"/></returns>
        public async Task<CreateHaVipResponse> CreateHaVip(CreateHaVipRequest req)
        {
             JsonResponseModel<CreateHaVipResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateHaVip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateHaVipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an HAVIP.
        /// </summary>
        /// <param name="req"><see cref="CreateHaVipRequest"/></param>
        /// <returns><see cref="CreateHaVipResponse"/></returns>
        public CreateHaVipResponse CreateHaVipSync(CreateHaVipRequest req)
        {
             JsonResponseModel<CreateHaVipResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateHaVip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateHaVipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an image with the system disk of an instance. The image can be used to create instances.
        /// </summary>
        /// <param name="req"><see cref="CreateImageRequest"/></param>
        /// <returns><see cref="CreateImageResponse"/></returns>
        public async Task<CreateImageResponse> CreateImage(CreateImageRequest req)
        {
             JsonResponseModel<CreateImageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an image with the system disk of an instance. The image can be used to create instances.
        /// </summary>
        /// <param name="req"><see cref="CreateImageRequest"/></param>
        /// <returns><see cref="CreateImageResponse"/></returns>
        public CreateImageResponse CreateImageSync(CreateImageRequest req)
        {
             JsonResponseModel<CreateImageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an `OpenSSH RSA` key pair, which can be used to log in to a Linux instance.
        /// </summary>
        /// <param name="req"><see cref="CreateKeyPairRequest"/></param>
        /// <returns><see cref="CreateKeyPairResponse"/></returns>
        public async Task<CreateKeyPairResponse> CreateKeyPair(CreateKeyPairRequest req)
        {
             JsonResponseModel<CreateKeyPairResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateKeyPair");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateKeyPairResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an `OpenSSH RSA` key pair, which can be used to log in to a Linux instance.
        /// </summary>
        /// <param name="req"><see cref="CreateKeyPairRequest"/></param>
        /// <returns><see cref="CreateKeyPairResponse"/></returns>
        public CreateKeyPairResponse CreateKeyPairSync(CreateKeyPairRequest req)
        {
             JsonResponseModel<CreateKeyPairResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateKeyPair");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateKeyPairResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a CLB listener.
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
        /// This API is used to create a CLB listener.
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
        /// This API is used to purchase a CLB instance.
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
        /// This API is used to purchase a CLB instance.
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
        /// This API is used to create a module.
        /// </summary>
        /// <param name="req"><see cref="CreateModuleRequest"/></param>
        /// <returns><see cref="CreateModuleResponse"/></returns>
        public async Task<CreateModuleResponse> CreateModule(CreateModuleRequest req)
        {
             JsonResponseModel<CreateModuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateModule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateModuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a module.
        /// </summary>
        /// <param name="req"><see cref="CreateModuleRequest"/></param>
        /// <returns><see cref="CreateModuleResponse"/></returns>
        public CreateModuleResponse CreateModuleSync(CreateModuleRequest req)
        {
             JsonResponseModel<CreateModuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateModule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateModuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an ENI.
        /// </summary>
        /// <param name="req"><see cref="CreateNetworkInterfaceRequest"/></param>
        /// <returns><see cref="CreateNetworkInterfaceResponse"/></returns>
        public async Task<CreateNetworkInterfaceResponse> CreateNetworkInterface(CreateNetworkInterfaceRequest req)
        {
             JsonResponseModel<CreateNetworkInterfaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateNetworkInterface");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNetworkInterfaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an ENI.
        /// </summary>
        /// <param name="req"><see cref="CreateNetworkInterfaceRequest"/></param>
        /// <returns><see cref="CreateNetworkInterfaceResponse"/></returns>
        public CreateNetworkInterfaceResponse CreateNetworkInterfaceSync(CreateNetworkInterfaceRequest req)
        {
             JsonResponseModel<CreateNetworkInterfaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateNetworkInterface");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNetworkInterfaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// After a VPC is created, the system will create a default route table, with which all new subnets will be associated. By default, you can use the default route table to manage your routing policies. If you have multiple routing policies, you can call the API for route table creation to create more route tables to manage your routing policies.
        /// </summary>
        /// <param name="req"><see cref="CreateRouteTableRequest"/></param>
        /// <returns><see cref="CreateRouteTableResponse"/></returns>
        public async Task<CreateRouteTableResponse> CreateRouteTable(CreateRouteTableRequest req)
        {
             JsonResponseModel<CreateRouteTableResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRouteTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRouteTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// After a VPC is created, the system will create a default route table, with which all new subnets will be associated. By default, you can use the default route table to manage your routing policies. If you have multiple routing policies, you can call the API for route table creation to create more route tables to manage your routing policies.
        /// </summary>
        /// <param name="req"><see cref="CreateRouteTableRequest"/></param>
        /// <returns><see cref="CreateRouteTableResponse"/></returns>
        public CreateRouteTableResponse CreateRouteTableSync(CreateRouteTableRequest req)
        {
             JsonResponseModel<CreateRouteTableResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRouteTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRouteTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a routing policy.
        /// </summary>
        /// <param name="req"><see cref="CreateRoutesRequest"/></param>
        /// <returns><see cref="CreateRoutesResponse"/></returns>
        public async Task<CreateRoutesResponse> CreateRoutes(CreateRoutesRequest req)
        {
             JsonResponseModel<CreateRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a routing policy.
        /// </summary>
        /// <param name="req"><see cref="CreateRoutesRequest"/></param>
        /// <returns><see cref="CreateRoutesResponse"/></returns>
        public CreateRoutesResponse CreateRoutesSync(CreateRoutesRequest req)
        {
             JsonResponseModel<CreateRoutesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a security group.
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityGroupRequest"/></param>
        /// <returns><see cref="CreateSecurityGroupResponse"/></returns>
        public async Task<CreateSecurityGroupResponse> CreateSecurityGroup(CreateSecurityGroupRequest req)
        {
             JsonResponseModel<CreateSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a security group.
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityGroupRequest"/></param>
        /// <returns><see cref="CreateSecurityGroupResponse"/></returns>
        public CreateSecurityGroupResponse CreateSecurityGroupSync(CreateSecurityGroupRequest req)
        {
             JsonResponseModel<CreateSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p>This API is used to create a security group policy.</p>
        /// <p>In the `SecurityGroupPolicySet` parameter:</p>
        /// <ul>
        /// <li>`Version`: the version number of a security group policy, which automatically increases by one each time you update the security policy, to prevent expiration of the updated routing policies. If it is left empty, any conflicts will be ignored.</li>
        /// <li>When creating the `Egress` and `Ingress` polices,<ul>
        /// <li><code>Protocol</code>: <code>TCP</code>, <code>UDP</code>, <code>ICMP</code>, <code>GRE</code>, or <code>ALL</code>.</li>
        /// <li>`CidrBlock`: a CIDR block in the correct format. In a classic network, if a `CidrBlock` contains private IPs on Tencent Cloud for devices under your account other than CVMs, it does not mean this policy allows you to access these devices. The network isolation policies between tenants take priority over the private network policies in security groups.</li>
        /// <li>`SecurityGroupId`: ID of the security group. It can be the ID of security group to be modified, or the ID of other security group in the same project. All private IPs of all CVMs under the security group will be covered. If this field is used, the policy will automatically change according to the CVM associated with the group ID while being used to match network messages. You don’t need to change it manually.</li>
        /// <li>`Port`: a single port number such as 80, or a port range in the format of “8000-8010”. You may use this field only if the `Protocol` field takes the value `TCP` or `UDP`. Otherwise `Protocol` and `Port` are mutually exclusive.</li>
        /// <li>`Action`: only allows `ACCEPT` or `DROP`.</li>
        /// <li>`CidrBlock`, `SecurityGroupId`, and `AddressTemplate` are mutually exclusive. `Protocol` + `Port` and `ServiceTemplate` are mutually exclusive.</li>
        /// <li>You can only create policies in one direction in each request. To specify the `PolicyIndex` parameter, use the same index number in policies.</li>
        /// </ul></li></ul>
        /// <p>Default API request rate limit: 20 requests/sec.</p>
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityGroupPoliciesRequest"/></param>
        /// <returns><see cref="CreateSecurityGroupPoliciesResponse"/></returns>
        public async Task<CreateSecurityGroupPoliciesResponse> CreateSecurityGroupPolicies(CreateSecurityGroupPoliciesRequest req)
        {
             JsonResponseModel<CreateSecurityGroupPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSecurityGroupPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSecurityGroupPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// <p>This API is used to create a security group policy.</p>
        /// <p>In the `SecurityGroupPolicySet` parameter:</p>
        /// <ul>
        /// <li>`Version`: the version number of a security group policy, which automatically increases by one each time you update the security policy, to prevent expiration of the updated routing policies. If it is left empty, any conflicts will be ignored.</li>
        /// <li>When creating the `Egress` and `Ingress` polices,<ul>
        /// <li><code>Protocol</code>: <code>TCP</code>, <code>UDP</code>, <code>ICMP</code>, <code>GRE</code>, or <code>ALL</code>.</li>
        /// <li>`CidrBlock`: a CIDR block in the correct format. In a classic network, if a `CidrBlock` contains private IPs on Tencent Cloud for devices under your account other than CVMs, it does not mean this policy allows you to access these devices. The network isolation policies between tenants take priority over the private network policies in security groups.</li>
        /// <li>`SecurityGroupId`: ID of the security group. It can be the ID of security group to be modified, or the ID of other security group in the same project. All private IPs of all CVMs under the security group will be covered. If this field is used, the policy will automatically change according to the CVM associated with the group ID while being used to match network messages. You don’t need to change it manually.</li>
        /// <li>`Port`: a single port number such as 80, or a port range in the format of “8000-8010”. You may use this field only if the `Protocol` field takes the value `TCP` or `UDP`. Otherwise `Protocol` and `Port` are mutually exclusive.</li>
        /// <li>`Action`: only allows `ACCEPT` or `DROP`.</li>
        /// <li>`CidrBlock`, `SecurityGroupId`, and `AddressTemplate` are mutually exclusive. `Protocol` + `Port` and `ServiceTemplate` are mutually exclusive.</li>
        /// <li>You can only create policies in one direction in each request. To specify the `PolicyIndex` parameter, use the same index number in policies.</li>
        /// </ul></li></ul>
        /// <p>Default API request rate limit: 20 requests/sec.</p>
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityGroupPoliciesRequest"/></param>
        /// <returns><see cref="CreateSecurityGroupPoliciesResponse"/></returns>
        public CreateSecurityGroupPoliciesResponse CreateSecurityGroupPoliciesSync(CreateSecurityGroupPoliciesRequest req)
        {
             JsonResponseModel<CreateSecurityGroupPoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSecurityGroupPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSecurityGroupPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a subnet. After the subnet is created successfully, it will become the default subnet for the AZ.
        /// </summary>
        /// <param name="req"><see cref="CreateSubnetRequest"/></param>
        /// <returns><see cref="CreateSubnetResponse"/></returns>
        public async Task<CreateSubnetResponse> CreateSubnet(CreateSubnetRequest req)
        {
             JsonResponseModel<CreateSubnetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSubnet");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSubnetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a subnet. After the subnet is created successfully, it will become the default subnet for the AZ.
        /// </summary>
        /// <param name="req"><see cref="CreateSubnetRequest"/></param>
        /// <returns><see cref="CreateSubnetResponse"/></returns>
        public CreateSubnetResponse CreateSubnetSync(CreateSubnetRequest req)
        {
             JsonResponseModel<CreateSubnetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSubnet");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSubnetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a VPC.
        /// </summary>
        /// <param name="req"><see cref="CreateVpcRequest"/></param>
        /// <returns><see cref="CreateVpcResponse"/></returns>
        public async Task<CreateVpcResponse> CreateVpc(CreateVpcRequest req)
        {
             JsonResponseModel<CreateVpcResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateVpc");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVpcResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a VPC.
        /// </summary>
        /// <param name="req"><see cref="CreateVpcRequest"/></param>
        /// <returns><see cref="CreateVpcResponse"/></returns>
        public CreateVpcResponse CreateVpcSync(CreateVpcRequest req)
        {
             JsonResponseModel<CreateVpcResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateVpc");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVpcResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an HAVIP.
        /// </summary>
        /// <param name="req"><see cref="DeleteHaVipRequest"/></param>
        /// <returns><see cref="DeleteHaVipResponse"/></returns>
        public async Task<DeleteHaVipResponse> DeleteHaVip(DeleteHaVipRequest req)
        {
             JsonResponseModel<DeleteHaVipResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteHaVip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteHaVipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an HAVIP.
        /// </summary>
        /// <param name="req"><see cref="DeleteHaVipRequest"/></param>
        /// <returns><see cref="DeleteHaVipResponse"/></returns>
        public DeleteHaVipResponse DeleteHaVipSync(DeleteHaVipRequest req)
        {
             JsonResponseModel<DeleteHaVipResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteHaVip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteHaVipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an image.
        /// </summary>
        /// <param name="req"><see cref="DeleteImageRequest"/></param>
        /// <returns><see cref="DeleteImageResponse"/></returns>
        public async Task<DeleteImageResponse> DeleteImage(DeleteImageRequest req)
        {
             JsonResponseModel<DeleteImageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an image.
        /// </summary>
        /// <param name="req"><see cref="DeleteImageRequest"/></param>
        /// <returns><see cref="DeleteImageResponse"/></returns>
        public DeleteImageResponse DeleteImageSync(DeleteImageRequest req)
        {
             JsonResponseModel<DeleteImageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a CLB listener.
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
        /// This API is used to delete a CLB listener.
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
        /// This API is used to delete a CLB instance.
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
        /// This API is used to delete a CLB instance.
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
        /// This API is used to delete multiple CLB listeners.
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
        /// This API is used to delete multiple CLB listeners.
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
        /// This API is used to delete a business module.
        /// </summary>
        /// <param name="req"><see cref="DeleteModuleRequest"/></param>
        /// <returns><see cref="DeleteModuleResponse"/></returns>
        public async Task<DeleteModuleResponse> DeleteModule(DeleteModuleRequest req)
        {
             JsonResponseModel<DeleteModuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteModule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteModuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a business module.
        /// </summary>
        /// <param name="req"><see cref="DeleteModuleRequest"/></param>
        /// <returns><see cref="DeleteModuleResponse"/></returns>
        public DeleteModuleResponse DeleteModuleSync(DeleteModuleRequest req)
        {
             JsonResponseModel<DeleteModuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteModule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteModuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an ENI.
        /// </summary>
        /// <param name="req"><see cref="DeleteNetworkInterfaceRequest"/></param>
        /// <returns><see cref="DeleteNetworkInterfaceResponse"/></returns>
        public async Task<DeleteNetworkInterfaceResponse> DeleteNetworkInterface(DeleteNetworkInterfaceRequest req)
        {
             JsonResponseModel<DeleteNetworkInterfaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteNetworkInterface");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNetworkInterfaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an ENI.
        /// </summary>
        /// <param name="req"><see cref="DeleteNetworkInterfaceRequest"/></param>
        /// <returns><see cref="DeleteNetworkInterfaceResponse"/></returns>
        public DeleteNetworkInterfaceResponse DeleteNetworkInterfaceSync(DeleteNetworkInterfaceRequest req)
        {
             JsonResponseModel<DeleteNetworkInterfaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteNetworkInterface");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNetworkInterfaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a route table.
        /// </summary>
        /// <param name="req"><see cref="DeleteRouteTableRequest"/></param>
        /// <returns><see cref="DeleteRouteTableResponse"/></returns>
        public async Task<DeleteRouteTableResponse> DeleteRouteTable(DeleteRouteTableRequest req)
        {
             JsonResponseModel<DeleteRouteTableResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRouteTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRouteTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a route table.
        /// </summary>
        /// <param name="req"><see cref="DeleteRouteTableRequest"/></param>
        /// <returns><see cref="DeleteRouteTableResponse"/></returns>
        public DeleteRouteTableResponse DeleteRouteTableSync(DeleteRouteTableRequest req)
        {
             JsonResponseModel<DeleteRouteTableResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRouteTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRouteTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to batch delete routing policies from a route table.
        /// </summary>
        /// <param name="req"><see cref="DeleteRoutesRequest"/></param>
        /// <returns><see cref="DeleteRoutesResponse"/></returns>
        public async Task<DeleteRoutesResponse> DeleteRoutes(DeleteRoutesRequest req)
        {
             JsonResponseModel<DeleteRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to batch delete routing policies from a route table.
        /// </summary>
        /// <param name="req"><see cref="DeleteRoutesRequest"/></param>
        /// <returns><see cref="DeleteRoutesResponse"/></returns>
        public DeleteRoutesResponse DeleteRoutesSync(DeleteRoutesRequest req)
        {
             JsonResponseModel<DeleteRoutesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Only security groups under the current account can be deleted.
        /// A security group cannot be deleted directly if its instance ID is used in the policy of another security group. In this case, you need to modify the policy first before deleting the security group.
        /// Deleted security groups cannot be recovered. Therefore, call this API with caution.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityGroupRequest"/></param>
        /// <returns><see cref="DeleteSecurityGroupResponse"/></returns>
        public async Task<DeleteSecurityGroupResponse> DeleteSecurityGroup(DeleteSecurityGroupRequest req)
        {
             JsonResponseModel<DeleteSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Only security groups under the current account can be deleted.
        /// A security group cannot be deleted directly if its instance ID is used in the policy of another security group. In this case, you need to modify the policy first before deleting the security group.
        /// Deleted security groups cannot be recovered. Therefore, call this API with caution.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityGroupRequest"/></param>
        /// <returns><see cref="DeleteSecurityGroupResponse"/></returns>
        public DeleteSecurityGroupResponse DeleteSecurityGroupSync(DeleteSecurityGroupRequest req)
        {
             JsonResponseModel<DeleteSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// `SecurityGroupPolicySet.Version` is used to specify the version of the security group to be manipulated. If the `Version` value passed in differs from the current latest version of the security group, a failure will be returned. If `Version` is not passed in, the policy of the specified `PolicyIndex` will be deleted directly.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityGroupPoliciesRequest"/></param>
        /// <returns><see cref="DeleteSecurityGroupPoliciesResponse"/></returns>
        public async Task<DeleteSecurityGroupPoliciesResponse> DeleteSecurityGroupPolicies(DeleteSecurityGroupPoliciesRequest req)
        {
             JsonResponseModel<DeleteSecurityGroupPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSecurityGroupPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSecurityGroupPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// `SecurityGroupPolicySet.Version` is used to specify the version of the security group to be manipulated. If the `Version` value passed in differs from the current latest version of the security group, a failure will be returned. If `Version` is not passed in, the policy of the specified `PolicyIndex` will be deleted directly.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityGroupPoliciesRequest"/></param>
        /// <returns><see cref="DeleteSecurityGroupPoliciesResponse"/></returns>
        public DeleteSecurityGroupPoliciesResponse DeleteSecurityGroupPoliciesSync(DeleteSecurityGroupPoliciesRequest req)
        {
             JsonResponseModel<DeleteSecurityGroupPoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSecurityGroupPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSecurityGroupPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a snapshot.
        /// 
        /// * Only snapshots in the `NORMAL` state can be deleted. To query the state of a snapshot, you can call the [DescribeSnapshots](https://intl.cloud.tencent.com/document/product/362/15647?from_cn_redirect=1) API and check the `SnapshotState` field in the response.
        /// * Batch operations are supported. If there is any snapshot that cannot be deleted, the operation will not be performed and a specific error code will be returned.
        /// </summary>
        /// <param name="req"><see cref="DeleteSnapshotsRequest"/></param>
        /// <returns><see cref="DeleteSnapshotsResponse"/></returns>
        public async Task<DeleteSnapshotsResponse> DeleteSnapshots(DeleteSnapshotsRequest req)
        {
             JsonResponseModel<DeleteSnapshotsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSnapshots");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSnapshotsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a snapshot.
        /// 
        /// * Only snapshots in the `NORMAL` state can be deleted. To query the state of a snapshot, you can call the [DescribeSnapshots](https://intl.cloud.tencent.com/document/product/362/15647?from_cn_redirect=1) API and check the `SnapshotState` field in the response.
        /// * Batch operations are supported. If there is any snapshot that cannot be deleted, the operation will not be performed and a specific error code will be returned.
        /// </summary>
        /// <param name="req"><see cref="DeleteSnapshotsRequest"/></param>
        /// <returns><see cref="DeleteSnapshotsResponse"/></returns>
        public DeleteSnapshotsResponse DeleteSnapshotsSync(DeleteSnapshotsRequest req)
        {
             JsonResponseModel<DeleteSnapshotsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSnapshots");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSnapshotsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a subnet. If the subnet is the current default subnet in the AZ, after it is deleted, the default subnet automatically created by the system rather than the last subnet created by you will be used as the new default subnet. If the new default subnet does not meet your needs, you can call the API for setting the default subnet to configure it.
        /// </summary>
        /// <param name="req"><see cref="DeleteSubnetRequest"/></param>
        /// <returns><see cref="DeleteSubnetResponse"/></returns>
        public async Task<DeleteSubnetResponse> DeleteSubnet(DeleteSubnetRequest req)
        {
             JsonResponseModel<DeleteSubnetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSubnet");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSubnetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a subnet. If the subnet is the current default subnet in the AZ, after it is deleted, the default subnet automatically created by the system rather than the last subnet created by you will be used as the new default subnet. If the new default subnet does not meet your needs, you can call the API for setting the default subnet to configure it.
        /// </summary>
        /// <param name="req"><see cref="DeleteSubnetRequest"/></param>
        /// <returns><see cref="DeleteSubnetResponse"/></returns>
        public DeleteSubnetResponse DeleteSubnetSync(DeleteSubnetRequest req)
        {
             JsonResponseModel<DeleteSubnetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSubnet");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSubnetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a VPC.
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcRequest"/></param>
        /// <returns><see cref="DeleteVpcResponse"/></returns>
        public async Task<DeleteVpcResponse> DeleteVpc(DeleteVpcRequest req)
        {
             JsonResponseModel<DeleteVpcResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteVpc");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteVpcResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a VPC.
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcRequest"/></param>
        /// <returns><see cref="DeleteVpcResponse"/></returns>
        public DeleteVpcResponse DeleteVpcSync(DeleteVpcRequest req)
        {
             JsonResponseModel<DeleteVpcResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteVpc");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteVpcResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the quota information of the EIP under your account in the current region.
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressQuotaRequest"/></param>
        /// <returns><see cref="DescribeAddressQuotaResponse"/></returns>
        public async Task<DescribeAddressQuotaResponse> DescribeAddressQuota(DescribeAddressQuotaRequest req)
        {
             JsonResponseModel<DescribeAddressQuotaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAddressQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAddressQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the quota information of the EIP under your account in the current region.
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressQuotaRequest"/></param>
        /// <returns><see cref="DescribeAddressQuotaResponse"/></returns>
        public DescribeAddressQuotaResponse DescribeAddressQuotaSync(DescribeAddressQuotaRequest req)
        {
             JsonResponseModel<DescribeAddressQuotaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAddressQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAddressQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of EIPs.
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressesRequest"/></param>
        /// <returns><see cref="DescribeAddressesResponse"/></returns>
        public async Task<DescribeAddressesResponse> DescribeAddresses(DescribeAddressesRequest req)
        {
             JsonResponseModel<DescribeAddressesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAddresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of EIPs.
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressesRequest"/></param>
        /// <returns><see cref="DescribeAddressesResponse"/></returns>
        public DescribeAddressesResponse DescribeAddressesSync(DescribeAddressesRequest req)
        {
             JsonResponseModel<DescribeAddressesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAddresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the basic data displayed on the overview page.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaseOverviewRequest"/></param>
        /// <returns><see cref="DescribeBaseOverviewResponse"/></returns>
        public async Task<DescribeBaseOverviewResponse> DescribeBaseOverview(DescribeBaseOverviewRequest req)
        {
             JsonResponseModel<DescribeBaseOverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBaseOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaseOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the basic data displayed on the overview page.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaseOverviewRequest"/></param>
        /// <returns><see cref="DescribeBaseOverviewResponse"/></returns>
        public DescribeBaseOverviewResponse DescribeBaseOverviewSync(DescribeBaseOverviewRequest req)
        {
             JsonResponseModel<DescribeBaseOverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBaseOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaseOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the limits of data such as bandwidth and disk.
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigRequest"/></param>
        /// <returns><see cref="DescribeConfigResponse"/></returns>
        public async Task<DescribeConfigResponse> DescribeConfig(DescribeConfigRequest req)
        {
             JsonResponseModel<DescribeConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the limits of data such as bandwidth and disk.
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigRequest"/></param>
        /// <returns><see cref="DescribeConfigResponse"/></returns>
        public DescribeConfigResponse DescribeConfigSync(DescribeConfigRequest req)
        {
             JsonResponseModel<DescribeConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query an image import task.
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomImageTaskRequest"/></param>
        /// <returns><see cref="DescribeCustomImageTaskResponse"/></returns>
        public async Task<DescribeCustomImageTaskResponse> DescribeCustomImageTask(DescribeCustomImageTaskRequest req)
        {
             JsonResponseModel<DescribeCustomImageTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCustomImageTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomImageTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query an image import task.
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomImageTaskRequest"/></param>
        /// <returns><see cref="DescribeCustomImageTaskResponse"/></returns>
        public DescribeCustomImageTaskResponse DescribeCustomImageTaskSync(DescribeCustomImageTaskRequest req)
        {
             JsonResponseModel<DescribeCustomImageTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCustomImageTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomImageTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the default subnet in an AZ.
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultSubnetRequest"/></param>
        /// <returns><see cref="DescribeDefaultSubnetResponse"/></returns>
        public async Task<DescribeDefaultSubnetResponse> DescribeDefaultSubnet(DescribeDefaultSubnetRequest req)
        {
             JsonResponseModel<DescribeDefaultSubnetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDefaultSubnet");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDefaultSubnetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the default subnet in an AZ.
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultSubnetRequest"/></param>
        /// <returns><see cref="DescribeDefaultSubnetResponse"/></returns>
        public DescribeDefaultSubnetResponse DescribeDefaultSubnetSync(DescribeDefaultSubnetRequest req)
        {
             JsonResponseModel<DescribeDefaultSubnetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDefaultSubnet");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDefaultSubnetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of HAVIPs.
        /// </summary>
        /// <param name="req"><see cref="DescribeHaVipsRequest"/></param>
        /// <returns><see cref="DescribeHaVipsResponse"/></returns>
        public async Task<DescribeHaVipsResponse> DescribeHaVips(DescribeHaVipsRequest req)
        {
             JsonResponseModel<DescribeHaVipsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeHaVips");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHaVipsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of HAVIPs.
        /// </summary>
        /// <param name="req"><see cref="DescribeHaVipsRequest"/></param>
        /// <returns><see cref="DescribeHaVipsResponse"/></returns>
        public DescribeHaVipsResponse DescribeHaVipsSync(DescribeHaVipsRequest req)
        {
             JsonResponseModel<DescribeHaVipsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeHaVips");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHaVipsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to display the list of images.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRequest"/></param>
        /// <returns><see cref="DescribeImageResponse"/></returns>
        public async Task<DescribeImageResponse> DescribeImage(DescribeImageRequest req)
        {
             JsonResponseModel<DescribeImageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to display the list of images.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRequest"/></param>
        /// <returns><see cref="DescribeImageResponse"/></returns>
        public DescribeImageResponse DescribeImageSync(DescribeImageRequest req)
        {
             JsonResponseModel<DescribeImageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of operating systems supported by an image imported from an external resource.
        /// </summary>
        /// <param name="req"><see cref="DescribeImportImageOsRequest"/></param>
        /// <returns><see cref="DescribeImportImageOsResponse"/></returns>
        public async Task<DescribeImportImageOsResponse> DescribeImportImageOs(DescribeImportImageOsRequest req)
        {
             JsonResponseModel<DescribeImportImageOsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImportImageOs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImportImageOsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of operating systems supported by an image imported from an external resource.
        /// </summary>
        /// <param name="req"><see cref="DescribeImportImageOsRequest"/></param>
        /// <returns><see cref="DescribeImportImageOsResponse"/></returns>
        public DescribeImportImageOsResponse DescribeImportImageOsSync(DescribeImportImageOsRequest req)
        {
             JsonResponseModel<DescribeImportImageOsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImportImageOs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImportImageOsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of model configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceTypeConfigRequest"/></param>
        /// <returns><see cref="DescribeInstanceTypeConfigResponse"/></returns>
        public async Task<DescribeInstanceTypeConfigResponse> DescribeInstanceTypeConfig(DescribeInstanceTypeConfigRequest req)
        {
             JsonResponseModel<DescribeInstanceTypeConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceTypeConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceTypeConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of model configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceTypeConfigRequest"/></param>
        /// <returns><see cref="DescribeInstanceTypeConfigResponse"/></returns>
        public DescribeInstanceTypeConfigResponse DescribeInstanceTypeConfigSync(DescribeInstanceTypeConfigRequest req)
        {
             JsonResponseModel<DescribeInstanceTypeConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceTypeConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceTypeConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the VNC URL of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceVncUrlRequest"/></param>
        /// <returns><see cref="DescribeInstanceVncUrlResponse"/></returns>
        public async Task<DescribeInstanceVncUrlResponse> DescribeInstanceVncUrl(DescribeInstanceVncUrlRequest req)
        {
             JsonResponseModel<DescribeInstanceVncUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceVncUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceVncUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the VNC URL of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceVncUrlRequest"/></param>
        /// <returns><see cref="DescribeInstanceVncUrlResponse"/></returns>
        public DescribeInstanceVncUrlResponse DescribeInstanceVncUrlSync(DescribeInstanceVncUrlRequest req)
        {
             JsonResponseModel<DescribeInstanceVncUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceVncUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceVncUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public async Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
             JsonResponseModel<DescribeInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
             JsonResponseModel<DescribeInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information of prohibited operations by instance ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeInstancesDeniedActionsResponse"/></returns>
        public async Task<DescribeInstancesDeniedActionsResponse> DescribeInstancesDeniedActions(DescribeInstancesDeniedActionsRequest req)
        {
             JsonResponseModel<DescribeInstancesDeniedActionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstancesDeniedActions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesDeniedActionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information of prohibited operations by instance ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeInstancesDeniedActionsResponse"/></returns>
        public DescribeInstancesDeniedActionsResponse DescribeInstancesDeniedActionsSync(DescribeInstancesDeniedActionsRequest req)
        {
             JsonResponseModel<DescribeInstancesDeniedActionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstancesDeniedActions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesDeniedActionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of CLB listeners.
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
        /// This API is used to query the list of CLB listeners.
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
        /// This API is used to query the task status of a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalanceTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeLoadBalanceTaskStatusResponse"/></returns>
        public async Task<DescribeLoadBalanceTaskStatusResponse> DescribeLoadBalanceTaskStatus(DescribeLoadBalanceTaskStatusRequest req)
        {
             JsonResponseModel<DescribeLoadBalanceTaskStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLoadBalanceTaskStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoadBalanceTaskStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the task status of a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalanceTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeLoadBalanceTaskStatusResponse"/></returns>
        public DescribeLoadBalanceTaskStatusResponse DescribeLoadBalanceTaskStatusSync(DescribeLoadBalanceTaskStatusRequest req)
        {
             JsonResponseModel<DescribeLoadBalanceTaskStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLoadBalanceTaskStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoadBalanceTaskStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of CLB instances.
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
        /// This API is used to query the list of CLB instances.
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
        /// This API is used to get the list of modules.
        /// </summary>
        /// <param name="req"><see cref="DescribeModuleRequest"/></param>
        /// <returns><see cref="DescribeModuleResponse"/></returns>
        public async Task<DescribeModuleResponse> DescribeModule(DescribeModuleRequest req)
        {
             JsonResponseModel<DescribeModuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeModule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of modules.
        /// </summary>
        /// <param name="req"><see cref="DescribeModuleRequest"/></param>
        /// <returns><see cref="DescribeModuleResponse"/></returns>
        public DescribeModuleResponse DescribeModuleSync(DescribeModuleRequest req)
        {
             JsonResponseModel<DescribeModuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeModule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to display the details of a module.
        /// </summary>
        /// <param name="req"><see cref="DescribeModuleDetailRequest"/></param>
        /// <returns><see cref="DescribeModuleDetailResponse"/></returns>
        public async Task<DescribeModuleDetailResponse> DescribeModuleDetail(DescribeModuleDetailRequest req)
        {
             JsonResponseModel<DescribeModuleDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeModuleDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModuleDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to display the details of a module.
        /// </summary>
        /// <param name="req"><see cref="DescribeModuleDetailRequest"/></param>
        /// <returns><see cref="DescribeModuleDetailResponse"/></returns>
        public DescribeModuleDetailResponse DescribeModuleDetailSync(DescribeModuleDetailRequest req)
        {
             JsonResponseModel<DescribeModuleDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeModuleDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModuleDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the monthly peak and billable inbound/outbound bandwidth values of your node.
        /// </summary>
        /// <param name="req"><see cref="DescribeMonthPeakNetworkRequest"/></param>
        /// <returns><see cref="DescribeMonthPeakNetworkResponse"/></returns>
        public async Task<DescribeMonthPeakNetworkResponse> DescribeMonthPeakNetwork(DescribeMonthPeakNetworkRequest req)
        {
             JsonResponseModel<DescribeMonthPeakNetworkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMonthPeakNetwork");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMonthPeakNetworkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the monthly peak and billable inbound/outbound bandwidth values of your node.
        /// </summary>
        /// <param name="req"><see cref="DescribeMonthPeakNetworkRequest"/></param>
        /// <returns><see cref="DescribeMonthPeakNetworkResponse"/></returns>
        public DescribeMonthPeakNetworkResponse DescribeMonthPeakNetworkSync(DescribeMonthPeakNetworkRequest req)
        {
             JsonResponseModel<DescribeMonthPeakNetworkResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMonthPeakNetwork");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMonthPeakNetworkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of ENIs.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkInterfacesRequest"/></param>
        /// <returns><see cref="DescribeNetworkInterfacesResponse"/></returns>
        public async Task<DescribeNetworkInterfacesResponse> DescribeNetworkInterfaces(DescribeNetworkInterfacesRequest req)
        {
             JsonResponseModel<DescribeNetworkInterfacesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNetworkInterfaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetworkInterfacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of ENIs.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkInterfacesRequest"/></param>
        /// <returns><see cref="DescribeNetworkInterfacesResponse"/></returns>
        public DescribeNetworkInterfacesResponse DescribeNetworkInterfacesSync(DescribeNetworkInterfacesRequest req)
        {
             JsonResponseModel<DescribeNetworkInterfacesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNetworkInterfaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetworkInterfacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of nodes.
        /// </summary>
        /// <param name="req"><see cref="DescribeNodeRequest"/></param>
        /// <returns><see cref="DescribeNodeResponse"/></returns>
        public async Task<DescribeNodeResponse> DescribeNode(DescribeNodeRequest req)
        {
             JsonResponseModel<DescribeNodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of nodes.
        /// </summary>
        /// <param name="req"><see cref="DescribeNodeRequest"/></param>
        /// <returns><see cref="DescribeNodeResponse"/></returns>
        public DescribeNodeResponse DescribeNodeSync(DescribeNodeRequest req)
        {
             JsonResponseModel<DescribeNodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the packing quota of a model in a region (when a virtual model is used, a set of correlated packing quotas will be returned).
        /// </summary>
        /// <param name="req"><see cref="DescribePackingQuotaGroupRequest"/></param>
        /// <returns><see cref="DescribePackingQuotaGroupResponse"/></returns>
        public async Task<DescribePackingQuotaGroupResponse> DescribePackingQuotaGroup(DescribePackingQuotaGroupRequest req)
        {
             JsonResponseModel<DescribePackingQuotaGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePackingQuotaGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePackingQuotaGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the packing quota of a model in a region (when a virtual model is used, a set of correlated packing quotas will be returned).
        /// </summary>
        /// <param name="req"><see cref="DescribePackingQuotaGroupRequest"/></param>
        /// <returns><see cref="DescribePackingQuotaGroupResponse"/></returns>
        public DescribePackingQuotaGroupResponse DescribePackingQuotaGroupSync(DescribePackingQuotaGroupRequest req)
        {
             JsonResponseModel<DescribePackingQuotaGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePackingQuotaGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePackingQuotaGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the peak data of basic information such as CPU, memory, and disk.
        /// </summary>
        /// <param name="req"><see cref="DescribePeakBaseOverviewRequest"/></param>
        /// <returns><see cref="DescribePeakBaseOverviewResponse"/></returns>
        public async Task<DescribePeakBaseOverviewResponse> DescribePeakBaseOverview(DescribePeakBaseOverviewRequest req)
        {
             JsonResponseModel<DescribePeakBaseOverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePeakBaseOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePeakBaseOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the peak data of basic information such as CPU, memory, and disk.
        /// </summary>
        /// <param name="req"><see cref="DescribePeakBaseOverviewRequest"/></param>
        /// <returns><see cref="DescribePeakBaseOverviewResponse"/></returns>
        public DescribePeakBaseOverviewResponse DescribePeakBaseOverviewSync(DescribePeakBaseOverviewRequest req)
        {
             JsonResponseModel<DescribePeakBaseOverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePeakBaseOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePeakBaseOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the peak network data.
        /// </summary>
        /// <param name="req"><see cref="DescribePeakNetworkOverviewRequest"/></param>
        /// <returns><see cref="DescribePeakNetworkOverviewResponse"/></returns>
        public async Task<DescribePeakNetworkOverviewResponse> DescribePeakNetworkOverview(DescribePeakNetworkOverviewRequest req)
        {
             JsonResponseModel<DescribePeakNetworkOverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePeakNetworkOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePeakNetworkOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the peak network data.
        /// </summary>
        /// <param name="req"><see cref="DescribePeakNetworkOverviewRequest"/></param>
        /// <returns><see cref="DescribePeakNetworkOverviewResponse"/></returns>
        public DescribePeakNetworkOverviewResponse DescribePeakNetworkOverviewSync(DescribePeakNetworkOverviewRequest req)
        {
             JsonResponseModel<DescribePeakNetworkOverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePeakNetworkOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePeakNetworkOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the price of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribePriceRunInstanceRequest"/></param>
        /// <returns><see cref="DescribePriceRunInstanceResponse"/></returns>
        public async Task<DescribePriceRunInstanceResponse> DescribePriceRunInstance(DescribePriceRunInstanceRequest req)
        {
             JsonResponseModel<DescribePriceRunInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePriceRunInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePriceRunInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the price of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribePriceRunInstanceRequest"/></param>
        /// <returns><see cref="DescribePriceRunInstanceResponse"/></returns>
        public DescribePriceRunInstanceResponse DescribePriceRunInstanceSync(DescribePriceRunInstanceRequest req)
        {
             JsonResponseModel<DescribePriceRunInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePriceRunInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePriceRunInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of conflicts between a custom routing policy and a CCN routing policy.
        /// </summary>
        /// <param name="req"><see cref="DescribeRouteConflictsRequest"/></param>
        /// <returns><see cref="DescribeRouteConflictsResponse"/></returns>
        public async Task<DescribeRouteConflictsResponse> DescribeRouteConflicts(DescribeRouteConflictsRequest req)
        {
             JsonResponseModel<DescribeRouteConflictsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRouteConflicts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRouteConflictsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of conflicts between a custom routing policy and a CCN routing policy.
        /// </summary>
        /// <param name="req"><see cref="DescribeRouteConflictsRequest"/></param>
        /// <returns><see cref="DescribeRouteConflictsResponse"/></returns>
        public DescribeRouteConflictsResponse DescribeRouteConflictsSync(DescribeRouteConflictsRequest req)
        {
             JsonResponseModel<DescribeRouteConflictsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRouteConflicts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRouteConflictsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of the objects in a route table.
        /// </summary>
        /// <param name="req"><see cref="DescribeRouteTablesRequest"/></param>
        /// <returns><see cref="DescribeRouteTablesResponse"/></returns>
        public async Task<DescribeRouteTablesResponse> DescribeRouteTables(DescribeRouteTablesRequest req)
        {
             JsonResponseModel<DescribeRouteTablesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRouteTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRouteTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of the objects in a route table.
        /// </summary>
        /// <param name="req"><see cref="DescribeRouteTablesRequest"/></param>
        /// <returns><see cref="DescribeRouteTablesResponse"/></returns>
        public DescribeRouteTablesResponse DescribeRouteTablesSync(DescribeRouteTablesRequest req)
        {
             JsonResponseModel<DescribeRouteTablesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRouteTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRouteTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query statistics on the instances associated with a security group.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupAssociationStatisticsRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupAssociationStatisticsResponse"/></returns>
        public async Task<DescribeSecurityGroupAssociationStatisticsResponse> DescribeSecurityGroupAssociationStatistics(DescribeSecurityGroupAssociationStatisticsRequest req)
        {
             JsonResponseModel<DescribeSecurityGroupAssociationStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecurityGroupAssociationStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityGroupAssociationStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query statistics on the instances associated with a security group.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupAssociationStatisticsRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupAssociationStatisticsResponse"/></returns>
        public DescribeSecurityGroupAssociationStatisticsResponse DescribeSecurityGroupAssociationStatisticsSync(DescribeSecurityGroupAssociationStatisticsRequest req)
        {
             JsonResponseModel<DescribeSecurityGroupAssociationStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecurityGroupAssociationStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityGroupAssociationStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the security group quota.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupLimitsRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupLimitsResponse"/></returns>
        public async Task<DescribeSecurityGroupLimitsResponse> DescribeSecurityGroupLimits(DescribeSecurityGroupLimitsRequest req)
        {
             JsonResponseModel<DescribeSecurityGroupLimitsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecurityGroupLimits");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityGroupLimitsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the security group quota.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupLimitsRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupLimitsResponse"/></returns>
        public DescribeSecurityGroupLimitsResponse DescribeSecurityGroupLimitsSync(DescribeSecurityGroupLimitsRequest req)
        {
             JsonResponseModel<DescribeSecurityGroupLimitsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecurityGroupLimits");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityGroupLimitsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query a security group rule.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupPoliciesRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupPoliciesResponse"/></returns>
        public async Task<DescribeSecurityGroupPoliciesResponse> DescribeSecurityGroupPolicies(DescribeSecurityGroupPoliciesRequest req)
        {
             JsonResponseModel<DescribeSecurityGroupPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecurityGroupPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityGroupPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query a security group rule.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupPoliciesRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupPoliciesResponse"/></returns>
        public DescribeSecurityGroupPoliciesResponse DescribeSecurityGroupPoliciesSync(DescribeSecurityGroupPoliciesRequest req)
        {
             JsonResponseModel<DescribeSecurityGroupPoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecurityGroupPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityGroupPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to view a security group.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupsResponse"/></returns>
        public async Task<DescribeSecurityGroupsResponse> DescribeSecurityGroups(DescribeSecurityGroupsRequest req)
        {
             JsonResponseModel<DescribeSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to view a security group.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupsResponse"/></returns>
        public DescribeSecurityGroupsResponse DescribeSecurityGroupsSync(DescribeSecurityGroupsRequest req)
        {
             JsonResponseModel<DescribeSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of snapshots.
        /// 
        /// * You can filter results by snapshot ID and the ID and type of the cloud disk for which the snapshot is created. The relationship between different filters is `AND`. For more information on filters, see `Filter`.
        /// * If no parameter is defined, the status of a certain number of snapshots under the current account will be returned. The number is specified by `Limit` and is 20 by default.
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotsRequest"/></param>
        /// <returns><see cref="DescribeSnapshotsResponse"/></returns>
        public async Task<DescribeSnapshotsResponse> DescribeSnapshots(DescribeSnapshotsRequest req)
        {
             JsonResponseModel<DescribeSnapshotsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSnapshots");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of snapshots.
        /// 
        /// * You can filter results by snapshot ID and the ID and type of the cloud disk for which the snapshot is created. The relationship between different filters is `AND`. For more information on filters, see `Filter`.
        /// * If no parameter is defined, the status of a certain number of snapshots under the current account will be returned. The number is specified by `Limit` and is 20 by default.
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotsRequest"/></param>
        /// <returns><see cref="DescribeSnapshotsResponse"/></returns>
        public DescribeSnapshotsResponse DescribeSnapshotsSync(DescribeSnapshotsRequest req)
        {
             JsonResponseModel<DescribeSnapshotsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSnapshots");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of subnets.
        /// </summary>
        /// <param name="req"><see cref="DescribeSubnetsRequest"/></param>
        /// <returns><see cref="DescribeSubnetsResponse"/></returns>
        public async Task<DescribeSubnetsResponse> DescribeSubnets(DescribeSubnetsRequest req)
        {
             JsonResponseModel<DescribeSubnetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSubnets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSubnetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of subnets.
        /// </summary>
        /// <param name="req"><see cref="DescribeSubnetsRequest"/></param>
        /// <returns><see cref="DescribeSubnetsResponse"/></returns>
        public DescribeSubnetsResponse DescribeSubnetsSync(DescribeSubnetsRequest req)
        {
             JsonResponseModel<DescribeSubnetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSubnets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSubnetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the health check status of a CLB real server.
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
        /// This API is used to get the health check status of a CLB real server.
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
        /// This API is used to query the list of the real servers bound to a CLB instance.
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
        /// This API is used to query the list of the real servers bound to a CLB instance.
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
        /// This API is used to query the execution result of an EIP async task.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskResultRequest"/></param>
        /// <returns><see cref="DescribeTaskResultResponse"/></returns>
        public async Task<DescribeTaskResultResponse> DescribeTaskResult(DescribeTaskResultRequest req)
        {
             JsonResponseModel<DescribeTaskResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the execution result of an EIP async task.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskResultRequest"/></param>
        /// <returns><see cref="DescribeTaskResultResponse"/></returns>
        public DescribeTaskResultResponse DescribeTaskResultSync(DescribeTaskResultRequest req)
        {
             JsonResponseModel<DescribeTaskResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the status of an async task.
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
        /// This API is used to get the status of an async task.
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
        /// This API is used to query the list of VPCs.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcsRequest"/></param>
        /// <returns><see cref="DescribeVpcsResponse"/></returns>
        public async Task<DescribeVpcsResponse> DescribeVpcs(DescribeVpcsRequest req)
        {
             JsonResponseModel<DescribeVpcsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVpcs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of VPCs.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcsRequest"/></param>
        /// <returns><see cref="DescribeVpcsResponse"/></returns>
        public DescribeVpcsResponse DescribeVpcsSync(DescribeVpcsRequest req)
        {
             JsonResponseModel<DescribeVpcsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVpcs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind an ENI from a CVM instance.
        /// </summary>
        /// <param name="req"><see cref="DetachNetworkInterfaceRequest"/></param>
        /// <returns><see cref="DetachNetworkInterfaceResponse"/></returns>
        public async Task<DetachNetworkInterfaceResponse> DetachNetworkInterface(DetachNetworkInterfaceRequest req)
        {
             JsonResponseModel<DetachNetworkInterfaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetachNetworkInterface");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachNetworkInterfaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind an ENI from a CVM instance.
        /// </summary>
        /// <param name="req"><see cref="DetachNetworkInterfaceRequest"/></param>
        /// <returns><see cref="DetachNetworkInterfaceResponse"/></returns>
        public DetachNetworkInterfaceResponse DetachNetworkInterfaceSync(DetachNetworkInterfaceRequest req)
        {
             JsonResponseModel<DetachNetworkInterfaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DetachNetworkInterface");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachNetworkInterfaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable a subnet route.
        /// </summary>
        /// <param name="req"><see cref="DisableRoutesRequest"/></param>
        /// <returns><see cref="DisableRoutesResponse"/></returns>
        public async Task<DisableRoutesResponse> DisableRoutes(DisableRoutesRequest req)
        {
             JsonResponseModel<DisableRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable a subnet route.
        /// </summary>
        /// <param name="req"><see cref="DisableRoutesRequest"/></param>
        /// <returns><see cref="DisableRoutesResponse"/></returns>
        public DisableRoutesResponse DisableRoutesSync(DisableRoutesRequest req)
        {
             JsonResponseModel<DisableRoutesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind an EIP.
        /// Only EIPs in `BIND` or `BIND_ENI` status can be unbound.
        /// Blocked EIPs cannot be unbound.
        /// </summary>
        /// <param name="req"><see cref="DisassociateAddressRequest"/></param>
        /// <returns><see cref="DisassociateAddressResponse"/></returns>
        public async Task<DisassociateAddressResponse> DisassociateAddress(DisassociateAddressRequest req)
        {
             JsonResponseModel<DisassociateAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisassociateAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind an EIP.
        /// Only EIPs in `BIND` or `BIND_ENI` status can be unbound.
        /// Blocked EIPs cannot be unbound.
        /// </summary>
        /// <param name="req"><see cref="DisassociateAddressRequest"/></param>
        /// <returns><see cref="DisassociateAddressResponse"/></returns>
        public DisassociateAddressResponse DisassociateAddressSync(DisassociateAddressRequest req)
        {
             JsonResponseModel<DisassociateAddressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisassociateAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind a key pair from an instance.
        /// </summary>
        /// <param name="req"><see cref="DisassociateInstancesKeyPairsRequest"/></param>
        /// <returns><see cref="DisassociateInstancesKeyPairsResponse"/></returns>
        public async Task<DisassociateInstancesKeyPairsResponse> DisassociateInstancesKeyPairs(DisassociateInstancesKeyPairsRequest req)
        {
             JsonResponseModel<DisassociateInstancesKeyPairsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisassociateInstancesKeyPairs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateInstancesKeyPairsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind a key pair from an instance.
        /// </summary>
        /// <param name="req"><see cref="DisassociateInstancesKeyPairsRequest"/></param>
        /// <returns><see cref="DisassociateInstancesKeyPairsResponse"/></returns>
        public DisassociateInstancesKeyPairsResponse DisassociateInstancesKeyPairsSync(DisassociateInstancesKeyPairsRequest req)
        {
             JsonResponseModel<DisassociateInstancesKeyPairsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisassociateInstancesKeyPairs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateInstancesKeyPairsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind a security group.
        /// </summary>
        /// <param name="req"><see cref="DisassociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateSecurityGroupsResponse"/></returns>
        public async Task<DisassociateSecurityGroupsResponse> DisassociateSecurityGroups(DisassociateSecurityGroupsRequest req)
        {
             JsonResponseModel<DisassociateSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisassociateSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind a security group.
        /// </summary>
        /// <param name="req"><see cref="DisassociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateSecurityGroupsResponse"/></returns>
        public DisassociateSecurityGroupsResponse DisassociateSecurityGroupsSync(DisassociateSecurityGroupsRequest req)
        {
             JsonResponseModel<DisassociateSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisassociateSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable a disabled subnet route.
        /// This API verifies whether a CCN route will conflict with an existing route after it is enabled, and if so, you cannot enable it before you disable the conflicting route first.
        /// </summary>
        /// <param name="req"><see cref="EnableRoutesRequest"/></param>
        /// <returns><see cref="EnableRoutesResponse"/></returns>
        public async Task<EnableRoutesResponse> EnableRoutes(EnableRoutesRequest req)
        {
             JsonResponseModel<EnableRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable a disabled subnet route.
        /// This API verifies whether a CCN route will conflict with an existing route after it is enabled, and if so, you cannot enable it before you disable the conflicting route first.
        /// </summary>
        /// <param name="req"><see cref="EnableRoutesRequest"/></param>
        /// <returns><see cref="EnableRoutesResponse"/></returns>
        public EnableRoutesResponse EnableRoutesSync(EnableRoutesRequest req)
        {
             JsonResponseModel<EnableRoutesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to import an image from a CVM instance to an ECM instance.
        /// </summary>
        /// <param name="req"><see cref="ImportImageRequest"/></param>
        /// <returns><see cref="ImportImageResponse"/></returns>
        public async Task<ImportImageResponse> ImportImage(ImportImageRequest req)
        {
             JsonResponseModel<ImportImageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ImportImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImportImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to import an image from a CVM instance to an ECM instance.
        /// </summary>
        /// <param name="req"><see cref="ImportImageRequest"/></param>
        /// <returns><see cref="ImportImageResponse"/></returns>
        public ImportImageResponse ImportImageSync(ImportImageRequest req)
        {
             JsonResponseModel<ImportImageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ImportImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImportImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to migrate an ENI.
        /// </summary>
        /// <param name="req"><see cref="MigrateNetworkInterfaceRequest"/></param>
        /// <returns><see cref="MigrateNetworkInterfaceResponse"/></returns>
        public async Task<MigrateNetworkInterfaceResponse> MigrateNetworkInterface(MigrateNetworkInterfaceRequest req)
        {
             JsonResponseModel<MigrateNetworkInterfaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "MigrateNetworkInterface");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MigrateNetworkInterfaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to migrate an ENI.
        /// </summary>
        /// <param name="req"><see cref="MigrateNetworkInterfaceRequest"/></param>
        /// <returns><see cref="MigrateNetworkInterfaceResponse"/></returns>
        public MigrateNetworkInterfaceResponse MigrateNetworkInterfaceSync(MigrateNetworkInterfaceRequest req)
        {
             JsonResponseModel<MigrateNetworkInterfaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "MigrateNetworkInterface");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MigrateNetworkInterfaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to migrate a private IP from an ENI.
        /// It migrates a private IP from one ENI to another. Primary IPs cannot be migrated.
        /// The source and destination ENIs must be in the same subnet.
        /// </summary>
        /// <param name="req"><see cref="MigratePrivateIpAddressRequest"/></param>
        /// <returns><see cref="MigratePrivateIpAddressResponse"/></returns>
        public async Task<MigratePrivateIpAddressResponse> MigratePrivateIpAddress(MigratePrivateIpAddressRequest req)
        {
             JsonResponseModel<MigratePrivateIpAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "MigratePrivateIpAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MigratePrivateIpAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to migrate a private IP from an ENI.
        /// It migrates a private IP from one ENI to another. Primary IPs cannot be migrated.
        /// The source and destination ENIs must be in the same subnet.
        /// </summary>
        /// <param name="req"><see cref="MigratePrivateIpAddressRequest"/></param>
        /// <returns><see cref="MigratePrivateIpAddressResponse"/></returns>
        public MigratePrivateIpAddressResponse MigratePrivateIpAddressSync(MigratePrivateIpAddressRequest req)
        {
             JsonResponseModel<MigratePrivateIpAddressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "MigratePrivateIpAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MigratePrivateIpAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify EIP attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressAttributeRequest"/></param>
        /// <returns><see cref="ModifyAddressAttributeResponse"/></returns>
        public async Task<ModifyAddressAttributeResponse> ModifyAddressAttribute(ModifyAddressAttributeRequest req)
        {
             JsonResponseModel<ModifyAddressAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAddressAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAddressAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify EIP attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressAttributeRequest"/></param>
        /// <returns><see cref="ModifyAddressAttributeResponse"/></returns>
        public ModifyAddressAttributeResponse ModifyAddressAttributeSync(ModifyAddressAttributeRequest req)
        {
             JsonResponseModel<ModifyAddressAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAddressAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAddressAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the EIP bandwidth.
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressesBandwidthRequest"/></param>
        /// <returns><see cref="ModifyAddressesBandwidthResponse"/></returns>
        public async Task<ModifyAddressesBandwidthResponse> ModifyAddressesBandwidth(ModifyAddressesBandwidthRequest req)
        {
             JsonResponseModel<ModifyAddressesBandwidthResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAddressesBandwidth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAddressesBandwidthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the EIP bandwidth.
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressesBandwidthRequest"/></param>
        /// <returns><see cref="ModifyAddressesBandwidthResponse"/></returns>
        public ModifyAddressesBandwidthResponse ModifyAddressesBandwidthSync(ModifyAddressesBandwidthRequest req)
        {
             JsonResponseModel<ModifyAddressesBandwidthResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAddressesBandwidth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAddressesBandwidthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the default subnet used when you create an instance in an AZ (if you don't specify the VPC parameter when creating the instance, `sunbetId` will be used).
        /// </summary>
        /// <param name="req"><see cref="ModifyDefaultSubnetRequest"/></param>
        /// <returns><see cref="ModifyDefaultSubnetResponse"/></returns>
        public async Task<ModifyDefaultSubnetResponse> ModifyDefaultSubnet(ModifyDefaultSubnetRequest req)
        {
             JsonResponseModel<ModifyDefaultSubnetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDefaultSubnet");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDefaultSubnetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the default subnet used when you create an instance in an AZ (if you don't specify the VPC parameter when creating the instance, `sunbetId` will be used).
        /// </summary>
        /// <param name="req"><see cref="ModifyDefaultSubnetRequest"/></param>
        /// <returns><see cref="ModifyDefaultSubnetResponse"/></returns>
        public ModifyDefaultSubnetResponse ModifyDefaultSubnetSync(ModifyDefaultSubnetRequest req)
        {
             JsonResponseModel<ModifyDefaultSubnetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDefaultSubnet");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDefaultSubnetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of an HAVIP.
        /// </summary>
        /// <param name="req"><see cref="ModifyHaVipAttributeRequest"/></param>
        /// <returns><see cref="ModifyHaVipAttributeResponse"/></returns>
        public async Task<ModifyHaVipAttributeResponse> ModifyHaVipAttribute(ModifyHaVipAttributeRequest req)
        {
             JsonResponseModel<ModifyHaVipAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyHaVipAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyHaVipAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of an HAVIP.
        /// </summary>
        /// <param name="req"><see cref="ModifyHaVipAttributeRequest"/></param>
        /// <returns><see cref="ModifyHaVipAttributeResponse"/></returns>
        public ModifyHaVipAttributeResponse ModifyHaVipAttributeSync(ModifyHaVipAttributeRequest req)
        {
             JsonResponseModel<ModifyHaVipAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyHaVipAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyHaVipAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of an image.
        /// </summary>
        /// <param name="req"><see cref="ModifyImageAttributeRequest"/></param>
        /// <returns><see cref="ModifyImageAttributeResponse"/></returns>
        public async Task<ModifyImageAttributeResponse> ModifyImageAttribute(ModifyImageAttributeRequest req)
        {
             JsonResponseModel<ModifyImageAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyImageAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyImageAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of an image.
        /// </summary>
        /// <param name="req"><see cref="ModifyImageAttributeRequest"/></param>
        /// <returns><see cref="ModifyImageAttributeResponse"/></returns>
        public ModifyImageAttributeResponse ModifyImageAttributeSync(ModifyImageAttributeRequest req)
        {
             JsonResponseModel<ModifyImageAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyImageAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyImageAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesAttributeRequest"/></param>
        /// <returns><see cref="ModifyInstancesAttributeResponse"/></returns>
        public async Task<ModifyInstancesAttributeResponse> ModifyInstancesAttribute(ModifyInstancesAttributeRequest req)
        {
             JsonResponseModel<ModifyInstancesAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstancesAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstancesAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesAttributeRequest"/></param>
        /// <returns><see cref="ModifyInstancesAttributeResponse"/></returns>
        public ModifyInstancesAttributeResponse ModifyInstancesAttributeSync(ModifyInstancesAttributeRequest req)
        {
             JsonResponseModel<ModifyInstancesAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstancesAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstancesAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the IPv6 address attributes of an ENI.
        /// </summary>
        /// <param name="req"><see cref="ModifyIpv6AddressesAttributeRequest"/></param>
        /// <returns><see cref="ModifyIpv6AddressesAttributeResponse"/></returns>
        public async Task<ModifyIpv6AddressesAttributeResponse> ModifyIpv6AddressesAttribute(ModifyIpv6AddressesAttributeRequest req)
        {
             JsonResponseModel<ModifyIpv6AddressesAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyIpv6AddressesAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyIpv6AddressesAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the IPv6 address attributes of an ENI.
        /// </summary>
        /// <param name="req"><see cref="ModifyIpv6AddressesAttributeRequest"/></param>
        /// <returns><see cref="ModifyIpv6AddressesAttributeResponse"/></returns>
        public ModifyIpv6AddressesAttributeResponse ModifyIpv6AddressesAttributeSync(ModifyIpv6AddressesAttributeRequest req)
        {
             JsonResponseModel<ModifyIpv6AddressesAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyIpv6AddressesAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyIpv6AddressesAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of a CLB listener.
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
        /// This API is used to modify the attributes of a CLB listener.
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
        /// This API is used to modify the attributes of a CLB instance.
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
        /// This API is used to modify the attributes of a CLB instance.
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
        /// This API is used to modify the configuration of a module. You cannot modify the configuration of the module if it is associated with an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleConfigRequest"/></param>
        /// <returns><see cref="ModifyModuleConfigResponse"/></returns>
        public async Task<ModifyModuleConfigResponse> ModifyModuleConfig(ModifyModuleConfigRequest req)
        {
             JsonResponseModel<ModifyModuleConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyModuleConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyModuleConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the configuration of a module. You cannot modify the configuration of the module if it is associated with an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleConfigRequest"/></param>
        /// <returns><see cref="ModifyModuleConfigResponse"/></returns>
        public ModifyModuleConfigResponse ModifyModuleConfigSync(ModifyModuleConfigRequest req)
        {
             JsonResponseModel<ModifyModuleConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyModuleConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyModuleConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to specify whether to prohibit public IP assignment for a module.
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleDisableWanIpRequest"/></param>
        /// <returns><see cref="ModifyModuleDisableWanIpResponse"/></returns>
        public async Task<ModifyModuleDisableWanIpResponse> ModifyModuleDisableWanIp(ModifyModuleDisableWanIpRequest req)
        {
             JsonResponseModel<ModifyModuleDisableWanIpResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyModuleDisableWanIp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyModuleDisableWanIpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to specify whether to prohibit public IP assignment for a module.
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleDisableWanIpRequest"/></param>
        /// <returns><see cref="ModifyModuleDisableWanIpResponse"/></returns>
        public ModifyModuleDisableWanIpResponse ModifyModuleDisableWanIpSync(ModifyModuleDisableWanIpRequest req)
        {
             JsonResponseModel<ModifyModuleDisableWanIpResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyModuleDisableWanIp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyModuleDisableWanIpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the default image of a module.
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleImageRequest"/></param>
        /// <returns><see cref="ModifyModuleImageResponse"/></returns>
        public async Task<ModifyModuleImageResponse> ModifyModuleImage(ModifyModuleImageRequest req)
        {
             JsonResponseModel<ModifyModuleImageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyModuleImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyModuleImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the default image of a module.
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleImageRequest"/></param>
        /// <returns><see cref="ModifyModuleImageResponse"/></returns>
        public ModifyModuleImageResponse ModifyModuleImageSync(ModifyModuleImageRequest req)
        {
             JsonResponseModel<ModifyModuleImageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyModuleImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyModuleImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the IP direct access of a module.
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleIpDirectRequest"/></param>
        /// <returns><see cref="ModifyModuleIpDirectResponse"/></returns>
        public async Task<ModifyModuleIpDirectResponse> ModifyModuleIpDirect(ModifyModuleIpDirectRequest req)
        {
             JsonResponseModel<ModifyModuleIpDirectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyModuleIpDirect");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyModuleIpDirectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the IP direct access of a module.
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleIpDirectRequest"/></param>
        /// <returns><see cref="ModifyModuleIpDirectResponse"/></returns>
        public ModifyModuleIpDirectResponse ModifyModuleIpDirectSync(ModifyModuleIpDirectRequest req)
        {
             JsonResponseModel<ModifyModuleIpDirectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyModuleIpDirect");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyModuleIpDirectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to rename a module.
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleNameRequest"/></param>
        /// <returns><see cref="ModifyModuleNameResponse"/></returns>
        public async Task<ModifyModuleNameResponse> ModifyModuleName(ModifyModuleNameRequest req)
        {
             JsonResponseModel<ModifyModuleNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyModuleName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyModuleNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to rename a module.
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleNameRequest"/></param>
        /// <returns><see cref="ModifyModuleNameResponse"/></returns>
        public ModifyModuleNameResponse ModifyModuleNameSync(ModifyModuleNameRequest req)
        {
             JsonResponseModel<ModifyModuleNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyModuleName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyModuleNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the default bandwidth cap of a module.
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleNetworkRequest"/></param>
        /// <returns><see cref="ModifyModuleNetworkResponse"/></returns>
        public async Task<ModifyModuleNetworkResponse> ModifyModuleNetwork(ModifyModuleNetworkRequest req)
        {
             JsonResponseModel<ModifyModuleNetworkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyModuleNetwork");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyModuleNetworkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the default bandwidth cap of a module.
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleNetworkRequest"/></param>
        /// <returns><see cref="ModifyModuleNetworkResponse"/></returns>
        public ModifyModuleNetworkResponse ModifyModuleNetworkSync(ModifyModuleNetworkRequest req)
        {
             JsonResponseModel<ModifyModuleNetworkResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyModuleNetwork");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyModuleNetworkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the default security group of a module.
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleSecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifyModuleSecurityGroupsResponse"/></returns>
        public async Task<ModifyModuleSecurityGroupsResponse> ModifyModuleSecurityGroups(ModifyModuleSecurityGroupsRequest req)
        {
             JsonResponseModel<ModifyModuleSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyModuleSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyModuleSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the default security group of a module.
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleSecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifyModuleSecurityGroupsResponse"/></returns>
        public ModifyModuleSecurityGroupsResponse ModifyModuleSecurityGroupsSync(ModifyModuleSecurityGroupsRequest req)
        {
             JsonResponseModel<ModifyModuleSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyModuleSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyModuleSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the private IP attributes of an ENI.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateIpAddressesAttributeRequest"/></param>
        /// <returns><see cref="ModifyPrivateIpAddressesAttributeResponse"/></returns>
        public async Task<ModifyPrivateIpAddressesAttributeResponse> ModifyPrivateIpAddressesAttribute(ModifyPrivateIpAddressesAttributeRequest req)
        {
             JsonResponseModel<ModifyPrivateIpAddressesAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPrivateIpAddressesAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPrivateIpAddressesAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the private IP attributes of an ENI.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateIpAddressesAttributeRequest"/></param>
        /// <returns><see cref="ModifyPrivateIpAddressesAttributeResponse"/></returns>
        public ModifyPrivateIpAddressesAttributeResponse ModifyPrivateIpAddressesAttributeSync(ModifyPrivateIpAddressesAttributeRequest req)
        {
             JsonResponseModel<ModifyPrivateIpAddressesAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPrivateIpAddressesAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPrivateIpAddressesAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of a route table.
        /// </summary>
        /// <param name="req"><see cref="ModifyRouteTableAttributeRequest"/></param>
        /// <returns><see cref="ModifyRouteTableAttributeResponse"/></returns>
        public async Task<ModifyRouteTableAttributeResponse> ModifyRouteTableAttribute(ModifyRouteTableAttributeRequest req)
        {
             JsonResponseModel<ModifyRouteTableAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRouteTableAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRouteTableAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of a route table.
        /// </summary>
        /// <param name="req"><see cref="ModifyRouteTableAttributeRequest"/></param>
        /// <returns><see cref="ModifyRouteTableAttributeResponse"/></returns>
        public ModifyRouteTableAttributeResponse ModifyRouteTableAttributeSync(ModifyRouteTableAttributeRequest req)
        {
             JsonResponseModel<ModifyRouteTableAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRouteTableAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRouteTableAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of a security group.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupAttributeResponse"/></returns>
        public async Task<ModifySecurityGroupAttributeResponse> ModifySecurityGroupAttribute(ModifySecurityGroupAttributeRequest req)
        {
             JsonResponseModel<ModifySecurityGroupAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySecurityGroupAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecurityGroupAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of a security group.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupAttributeResponse"/></returns>
        public ModifySecurityGroupAttributeResponse ModifySecurityGroupAttributeSync(ModifySecurityGroupAttributeRequest req)
        {
             JsonResponseModel<ModifySecurityGroupAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySecurityGroupAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecurityGroupAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the outbound and inbound rules of a security group.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupPoliciesRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupPoliciesResponse"/></returns>
        public async Task<ModifySecurityGroupPoliciesResponse> ModifySecurityGroupPolicies(ModifySecurityGroupPoliciesRequest req)
        {
             JsonResponseModel<ModifySecurityGroupPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySecurityGroupPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecurityGroupPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the outbound and inbound rules of a security group.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupPoliciesRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupPoliciesResponse"/></returns>
        public ModifySecurityGroupPoliciesResponse ModifySecurityGroupPoliciesSync(ModifySecurityGroupPoliciesRequest req)
        {
             JsonResponseModel<ModifySecurityGroupPoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySecurityGroupPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecurityGroupPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of a subnet.
        /// </summary>
        /// <param name="req"><see cref="ModifySubnetAttributeRequest"/></param>
        /// <returns><see cref="ModifySubnetAttributeResponse"/></returns>
        public async Task<ModifySubnetAttributeResponse> ModifySubnetAttribute(ModifySubnetAttributeRequest req)
        {
             JsonResponseModel<ModifySubnetAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySubnetAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySubnetAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of a subnet.
        /// </summary>
        /// <param name="req"><see cref="ModifySubnetAttributeRequest"/></param>
        /// <returns><see cref="ModifySubnetAttributeResponse"/></returns>
        public ModifySubnetAttributeResponse ModifySubnetAttributeSync(ModifySubnetAttributeRequest req)
        {
             JsonResponseModel<ModifySubnetAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySubnetAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySubnetAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the port of a real server bound to a listener.
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
        /// This API is used to modify the port of a real server bound to a listener.
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
        /// This API is used to modify the forwarding weight of a real server bound to a listener.
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
        /// This API is used to modify the forwarding weight of a real server bound to a listener.
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
        /// This API is used to modify the attributes of a VPC.
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcAttributeRequest"/></param>
        /// <returns><see cref="ModifyVpcAttributeResponse"/></returns>
        public async Task<ModifyVpcAttributeResponse> ModifyVpcAttribute(ModifyVpcAttributeRequest req)
        {
             JsonResponseModel<ModifyVpcAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyVpcAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVpcAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of a VPC.
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcAttributeRequest"/></param>
        /// <returns><see cref="ModifyVpcAttributeResponse"/></returns>
        public ModifyVpcAttributeResponse ModifyVpcAttributeSync(ModifyVpcAttributeRequest req)
        {
             JsonResponseModel<ModifyVpcAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyVpcAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVpcAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to restart an instance. Only instances in `RUNNING` status can be restarted. The instance status will become `REBOOTING` when the API is called successfully and will become `RUNNING` when the instance is restarted successfully. Forced restart is supported. Just like powering off a physical PC and restarting it, a forced restart may cause data loss or file system corruption. Make sure that you use this API only when the server cannot be restarted normally.
        /// </summary>
        /// <param name="req"><see cref="RebootInstancesRequest"/></param>
        /// <returns><see cref="RebootInstancesResponse"/></returns>
        public async Task<RebootInstancesResponse> RebootInstances(RebootInstancesRequest req)
        {
             JsonResponseModel<RebootInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RebootInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RebootInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to restart an instance. Only instances in `RUNNING` status can be restarted. The instance status will become `REBOOTING` when the API is called successfully and will become `RUNNING` when the instance is restarted successfully. Forced restart is supported. Just like powering off a physical PC and restarting it, a forced restart may cause data loss or file system corruption. Make sure that you use this API only when the server cannot be restarted normally.
        /// </summary>
        /// <param name="req"><see cref="RebootInstancesRequest"/></param>
        /// <returns><see cref="RebootInstancesResponse"/></returns>
        public RebootInstancesResponse RebootInstancesSync(RebootInstancesRequest req)
        {
             JsonResponseModel<RebootInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RebootInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RebootInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to release one or multiple EIPs.
        /// This operation is irreversible. Once you release an EIP, the IP address associated with it will no longer belong to you.
        /// Only EIPs in `UNBIND` status can be released.
        /// </summary>
        /// <param name="req"><see cref="ReleaseAddressesRequest"/></param>
        /// <returns><see cref="ReleaseAddressesResponse"/></returns>
        public async Task<ReleaseAddressesResponse> ReleaseAddresses(ReleaseAddressesRequest req)
        {
             JsonResponseModel<ReleaseAddressesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReleaseAddresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReleaseAddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to release one or multiple EIPs.
        /// This operation is irreversible. Once you release an EIP, the IP address associated with it will no longer belong to you.
        /// Only EIPs in `UNBIND` status can be released.
        /// </summary>
        /// <param name="req"><see cref="ReleaseAddressesRequest"/></param>
        /// <returns><see cref="ReleaseAddressesResponse"/></returns>
        public ReleaseAddressesResponse ReleaseAddressesSync(ReleaseAddressesRequest req)
        {
             JsonResponseModel<ReleaseAddressesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReleaseAddresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReleaseAddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to release the IPv6 addresses of an ENI.
        /// </summary>
        /// <param name="req"><see cref="ReleaseIpv6AddressesRequest"/></param>
        /// <returns><see cref="ReleaseIpv6AddressesResponse"/></returns>
        public async Task<ReleaseIpv6AddressesResponse> ReleaseIpv6Addresses(ReleaseIpv6AddressesRequest req)
        {
             JsonResponseModel<ReleaseIpv6AddressesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReleaseIpv6Addresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReleaseIpv6AddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to release the IPv6 addresses of an ENI.
        /// </summary>
        /// <param name="req"><see cref="ReleaseIpv6AddressesRequest"/></param>
        /// <returns><see cref="ReleaseIpv6AddressesResponse"/></returns>
        public ReleaseIpv6AddressesResponse ReleaseIpv6AddressesSync(ReleaseIpv6AddressesRequest req)
        {
             JsonResponseModel<ReleaseIpv6AddressesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReleaseIpv6Addresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReleaseIpv6AddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to return the private IPs of an ENI.
        /// To return the secondary private IPs of an ENI, the API will automatically unbind them from the ENI. The primary private IP of the ENI cannot be returned.
        /// </summary>
        /// <param name="req"><see cref="RemovePrivateIpAddressesRequest"/></param>
        /// <returns><see cref="RemovePrivateIpAddressesResponse"/></returns>
        public async Task<RemovePrivateIpAddressesResponse> RemovePrivateIpAddresses(RemovePrivateIpAddressesRequest req)
        {
             JsonResponseModel<RemovePrivateIpAddressesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RemovePrivateIpAddresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemovePrivateIpAddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to return the private IPs of an ENI.
        /// To return the secondary private IPs of an ENI, the API will automatically unbind them from the ENI. The primary private IP of the ENI cannot be returned.
        /// </summary>
        /// <param name="req"><see cref="RemovePrivateIpAddressesRequest"/></param>
        /// <returns><see cref="RemovePrivateIpAddressesResponse"/></returns>
        public RemovePrivateIpAddressesResponse RemovePrivateIpAddressesSync(RemovePrivateIpAddressesRequest req)
        {
             JsonResponseModel<RemovePrivateIpAddressesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RemovePrivateIpAddresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemovePrivateIpAddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the route table associated with a subnet. A subnet can be associated with only one route table.
        /// </summary>
        /// <param name="req"><see cref="ReplaceRouteTableAssociationRequest"/></param>
        /// <returns><see cref="ReplaceRouteTableAssociationResponse"/></returns>
        public async Task<ReplaceRouteTableAssociationResponse> ReplaceRouteTableAssociation(ReplaceRouteTableAssociationRequest req)
        {
             JsonResponseModel<ReplaceRouteTableAssociationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReplaceRouteTableAssociation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReplaceRouteTableAssociationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the route table associated with a subnet. A subnet can be associated with only one route table.
        /// </summary>
        /// <param name="req"><see cref="ReplaceRouteTableAssociationRequest"/></param>
        /// <returns><see cref="ReplaceRouteTableAssociationResponse"/></returns>
        public ReplaceRouteTableAssociationResponse ReplaceRouteTableAssociationSync(ReplaceRouteTableAssociationRequest req)
        {
             JsonResponseModel<ReplaceRouteTableAssociationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReplaceRouteTableAssociation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReplaceRouteTableAssociationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to replace a routing policy.
        /// </summary>
        /// <param name="req"><see cref="ReplaceRoutesRequest"/></param>
        /// <returns><see cref="ReplaceRoutesResponse"/></returns>
        public async Task<ReplaceRoutesResponse> ReplaceRoutes(ReplaceRoutesRequest req)
        {
             JsonResponseModel<ReplaceRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReplaceRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReplaceRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to replace a routing policy.
        /// </summary>
        /// <param name="req"><see cref="ReplaceRoutesRequest"/></param>
        /// <returns><see cref="ReplaceRoutesResponse"/></returns>
        public ReplaceRoutesResponse ReplaceRoutesSync(ReplaceRoutesRequest req)
        {
             JsonResponseModel<ReplaceRoutesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReplaceRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReplaceRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to replace a single routing rule of a security group. You can replace only one rule in a single direction in one request and must specify the index (PolicyIndex).
        /// </summary>
        /// <param name="req"><see cref="ReplaceSecurityGroupPolicyRequest"/></param>
        /// <returns><see cref="ReplaceSecurityGroupPolicyResponse"/></returns>
        public async Task<ReplaceSecurityGroupPolicyResponse> ReplaceSecurityGroupPolicy(ReplaceSecurityGroupPolicyRequest req)
        {
             JsonResponseModel<ReplaceSecurityGroupPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReplaceSecurityGroupPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReplaceSecurityGroupPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to replace a single routing rule of a security group. You can replace only one rule in a single direction in one request and must specify the index (PolicyIndex).
        /// </summary>
        /// <param name="req"><see cref="ReplaceSecurityGroupPolicyRequest"/></param>
        /// <returns><see cref="ReplaceSecurityGroupPolicyResponse"/></returns>
        public ReplaceSecurityGroupPolicyResponse ReplaceSecurityGroupPolicySync(ReplaceSecurityGroupPolicyRequest req)
        {
             JsonResponseModel<ReplaceSecurityGroupPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReplaceSecurityGroupPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReplaceSecurityGroupPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to reinstall an instance. If you specify the `ImageId` parameter, the specified image will be used; otherwise, the image used by the current instance will be used. If you don't specify the password, a password will be sent later in Message Center.
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesRequest"/></param>
        /// <returns><see cref="ResetInstancesResponse"/></returns>
        public async Task<ResetInstancesResponse> ResetInstances(ResetInstancesRequest req)
        {
             JsonResponseModel<ResetInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to reinstall an instance. If you specify the `ImageId` parameter, the specified image will be used; otherwise, the image used by the current instance will be used. If you don't specify the password, a password will be sent later in Message Center.
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesRequest"/></param>
        /// <returns><see cref="ResetInstancesResponse"/></returns>
        public ResetInstancesResponse ResetInstancesSync(ResetInstancesRequest req)
        {
             JsonResponseModel<ResetInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to reset the bandwidth cap of an instance.
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesMaxBandwidthRequest"/></param>
        /// <returns><see cref="ResetInstancesMaxBandwidthResponse"/></returns>
        public async Task<ResetInstancesMaxBandwidthResponse> ResetInstancesMaxBandwidth(ResetInstancesMaxBandwidthRequest req)
        {
             JsonResponseModel<ResetInstancesMaxBandwidthResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetInstancesMaxBandwidth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetInstancesMaxBandwidthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to reset the bandwidth cap of an instance.
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesMaxBandwidthRequest"/></param>
        /// <returns><see cref="ResetInstancesMaxBandwidthResponse"/></returns>
        public ResetInstancesMaxBandwidthResponse ResetInstancesMaxBandwidthSync(ResetInstancesMaxBandwidthRequest req)
        {
             JsonResponseModel<ResetInstancesMaxBandwidthResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetInstancesMaxBandwidth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetInstancesMaxBandwidthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to reset the password for a running status. You need to explicitly specify the `ForceStop` parameter; otherwise, you can reset the password only for instances that have been shut down.
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesPasswordRequest"/></param>
        /// <returns><see cref="ResetInstancesPasswordResponse"/></returns>
        public async Task<ResetInstancesPasswordResponse> ResetInstancesPassword(ResetInstancesPasswordRequest req)
        {
             JsonResponseModel<ResetInstancesPasswordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetInstancesPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetInstancesPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to reset the password for a running status. You need to explicitly specify the `ForceStop` parameter; otherwise, you can reset the password only for instances that have been shut down.
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesPasswordRequest"/></param>
        /// <returns><see cref="ResetInstancesPasswordResponse"/></returns>
        public ResetInstancesPasswordResponse ResetInstancesPasswordSync(ResetInstancesPasswordRequest req)
        {
             JsonResponseModel<ResetInstancesPasswordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetInstancesPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetInstancesPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to reset a route table name and all routing policies.
        /// </summary>
        /// <param name="req"><see cref="ResetRoutesRequest"/></param>
        /// <returns><see cref="ResetRoutesResponse"/></returns>
        public async Task<ResetRoutesResponse> ResetRoutes(ResetRoutesRequest req)
        {
             JsonResponseModel<ResetRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to reset a route table name and all routing policies.
        /// </summary>
        /// <param name="req"><see cref="ResetRoutesRequest"/></param>
        /// <returns><see cref="ResetRoutesResponse"/></returns>
        public ResetRoutesResponse ResetRoutesSync(ResetRoutesRequest req)
        {
             JsonResponseModel<ResetRoutesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an ECM instance.
        /// </summary>
        /// <param name="req"><see cref="RunInstancesRequest"/></param>
        /// <returns><see cref="RunInstancesResponse"/></returns>
        public async Task<RunInstancesResponse> RunInstances(RunInstancesRequest req)
        {
             JsonResponseModel<RunInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RunInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an ECM instance.
        /// </summary>
        /// <param name="req"><see cref="RunInstancesRequest"/></param>
        /// <returns><see cref="RunInstancesResponse"/></returns>
        public RunInstancesResponse RunInstancesSync(RunInstancesRequest req)
        {
             JsonResponseModel<RunInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RunInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to configure security groups for a CLB instance.
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
        /// This API is used to configure security groups for a CLB instance.
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
        /// This API is used to bind or unbind a security group to or from multiple CLB instances.
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
        /// This API is used to bind or unbind a security group to or from multiple CLB instances.
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

        /// <summary>
        /// This API is used to start an instance. Only instances in `STOPPED` status can be started. The instance status will become `STARTING` when this API is called successfully and will become `RUNNING` when the instance is started successfully.
        /// </summary>
        /// <param name="req"><see cref="StartInstancesRequest"/></param>
        /// <returns><see cref="StartInstancesResponse"/></returns>
        public async Task<StartInstancesResponse> StartInstances(StartInstancesRequest req)
        {
             JsonResponseModel<StartInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to start an instance. Only instances in `STOPPED` status can be started. The instance status will become `STARTING` when this API is called successfully and will become `RUNNING` when the instance is started successfully.
        /// </summary>
        /// <param name="req"><see cref="StartInstancesRequest"/></param>
        /// <returns><see cref="StartInstancesResponse"/></returns>
        public StartInstancesResponse StartInstancesSync(StartInstancesRequest req)
        {
             JsonResponseModel<StartInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Only instances in `RUNNING` status can be shut down.
        /// The instance status will become `STOPPING` when the API is called successfully and will become `STOPPED` when the instance is shut down successfully.
        /// Forced shutdown is supported. Just like powering off a physical PC, a forced shutdown may cause data loss or file system corruption. Make sure that you use this API only when the server cannot be shut down normally.
        /// </summary>
        /// <param name="req"><see cref="StopInstancesRequest"/></param>
        /// <returns><see cref="StopInstancesResponse"/></returns>
        public async Task<StopInstancesResponse> StopInstances(StopInstancesRequest req)
        {
             JsonResponseModel<StopInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Only instances in `RUNNING` status can be shut down.
        /// The instance status will become `STOPPING` when the API is called successfully and will become `STOPPED` when the instance is shut down successfully.
        /// Forced shutdown is supported. Just like powering off a physical PC, a forced shutdown may cause data loss or file system corruption. Make sure that you use this API only when the server cannot be shut down normally.
        /// </summary>
        /// <param name="req"><see cref="StopInstancesRequest"/></param>
        /// <returns><see cref="StopInstancesResponse"/></returns>
        public StopInstancesResponse StopInstancesSync(StopInstancesRequest req)
        {
             JsonResponseModel<StopInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to terminate an instance.
        /// </summary>
        /// <param name="req"><see cref="TerminateInstancesRequest"/></param>
        /// <returns><see cref="TerminateInstancesResponse"/></returns>
        public async Task<TerminateInstancesResponse> TerminateInstances(TerminateInstancesRequest req)
        {
             JsonResponseModel<TerminateInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TerminateInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to terminate an instance.
        /// </summary>
        /// <param name="req"><see cref="TerminateInstancesRequest"/></param>
        /// <returns><see cref="TerminateInstancesResponse"/></returns>
        public TerminateInstancesResponse TerminateInstancesSync(TerminateInstancesRequest req)
        {
             JsonResponseModel<TerminateInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TerminateInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
