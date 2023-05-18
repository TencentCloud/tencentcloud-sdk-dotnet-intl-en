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

namespace TencentCloud.Vpc.V20170312
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Vpc.V20170312.Models;

   public class VpcClient : AbstractClient{

       private const string endpoint = "vpc.tencentcloudapi.com";
       private const string version = "2017-03-12";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public VpcClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public VpcClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API (AcceptAttachCcnInstances) is used to associate instances across accounts. Cloud Connect Network (CCN) owners accept and agree to the operations.
        /// </summary>
        /// <param name="req"><see cref="AcceptAttachCcnInstancesRequest"/></param>
        /// <returns><see cref="AcceptAttachCcnInstancesResponse"/></returns>
        public async Task<AcceptAttachCcnInstancesResponse> AcceptAttachCcnInstances(AcceptAttachCcnInstancesRequest req)
        {
             JsonResponseModel<AcceptAttachCcnInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AcceptAttachCcnInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AcceptAttachCcnInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (AcceptAttachCcnInstances) is used to associate instances across accounts. Cloud Connect Network (CCN) owners accept and agree to the operations.
        /// </summary>
        /// <param name="req"><see cref="AcceptAttachCcnInstancesRequest"/></param>
        /// <returns><see cref="AcceptAttachCcnInstancesResponse"/></returns>
        public AcceptAttachCcnInstancesResponse AcceptAttachCcnInstancesSync(AcceptAttachCcnInstancesRequest req)
        {
             JsonResponseModel<AcceptAttachCcnInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AcceptAttachCcnInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AcceptAttachCcnInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add resources to a bandwidth package, including [Elastic IP](https://intl.cloud.tencent.com/document/product/213/1941?from_cn_redirect=1), [Cloud Load Balancer](https://intl.cloud.tencent.com/document/product/214/517?from_cn_redirect=1), and so on.
        /// </summary>
        /// <param name="req"><see cref="AddBandwidthPackageResourcesRequest"/></param>
        /// <returns><see cref="AddBandwidthPackageResourcesResponse"/></returns>
        public async Task<AddBandwidthPackageResourcesResponse> AddBandwidthPackageResources(AddBandwidthPackageResourcesRequest req)
        {
             JsonResponseModel<AddBandwidthPackageResourcesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddBandwidthPackageResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddBandwidthPackageResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add resources to a bandwidth package, including [Elastic IP](https://intl.cloud.tencent.com/document/product/213/1941?from_cn_redirect=1), [Cloud Load Balancer](https://intl.cloud.tencent.com/document/product/214/517?from_cn_redirect=1), and so on.
        /// </summary>
        /// <param name="req"><see cref="AddBandwidthPackageResourcesRequest"/></param>
        /// <returns><see cref="AddBandwidthPackageResourcesResponse"/></returns>
        public AddBandwidthPackageResourcesResponse AddBandwidthPackageResourcesSync(AddBandwidthPackageResourcesRequest req)
        {
             JsonResponseModel<AddBandwidthPackageResourcesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddBandwidthPackageResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddBandwidthPackageResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to change the IP address. It supports changing the common public IPs and EIPs billed by monthly subscribed bandwidth of a CVM instance.
        /// </summary>
        /// <param name="req"><see cref="AdjustPublicAddressRequest"/></param>
        /// <returns><see cref="AdjustPublicAddressResponse"/></returns>
        public async Task<AdjustPublicAddressResponse> AdjustPublicAddress(AdjustPublicAddressRequest req)
        {
             JsonResponseModel<AdjustPublicAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AdjustPublicAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AdjustPublicAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to change the IP address. It supports changing the common public IPs and EIPs billed by monthly subscribed bandwidth of a CVM instance.
        /// </summary>
        /// <param name="req"><see cref="AdjustPublicAddressRequest"/></param>
        /// <returns><see cref="AdjustPublicAddressResponse"/></returns>
        public AdjustPublicAddressResponse AdjustPublicAddressSync(AdjustPublicAddressRequest req)
        {
             JsonResponseModel<AdjustPublicAddressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AdjustPublicAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AdjustPublicAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to apply for one or more [Elastic IP Addresses](https://intl.cloud.tencent.com/document/product/213/1941?from_cn_redirect=1) (EIPs for short).
        /// * An EIP is a static IP address that is dedicated for dynamic cloud computing. You can quickly re-map an EIP to another instance under your account to protect against instance failures.
        /// * Your EIP is associated with your Tencent Cloud account rather than an instance. It remains associated with your Tencent Cloud account until you choose to explicitly release it or your account is in arrears for more than 24 hours.
        /// * The maximum number of EIPs that can be applied for a Tencent Cloud account in each region is restricted. For more information, see [EIP Product Introduction](https://intl.cloud.tencent.com/document/product/213/5733?from_cn_redirect=1). You can get the quota information through the DescribeAddressQuota API.
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
        /// This API is used to apply for one or more [Elastic IP Addresses](https://intl.cloud.tencent.com/document/product/213/1941?from_cn_redirect=1) (EIPs for short).
        /// * An EIP is a static IP address that is dedicated for dynamic cloud computing. You can quickly re-map an EIP to another instance under your account to protect against instance failures.
        /// * Your EIP is associated with your Tencent Cloud account rather than an instance. It remains associated with your Tencent Cloud account until you choose to explicitly release it or your account is in arrears for more than 24 hours.
        /// * The maximum number of EIPs that can be applied for a Tencent Cloud account in each region is restricted. For more information, see [EIP Product Introduction](https://intl.cloud.tencent.com/document/product/213/5733?from_cn_redirect=1). You can get the quota information through the DescribeAddressQuota API.
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
        /// This API is used to apply for an IPv6 address for the ENI. <br />
        /// This API is completed asynchronously. If you need to query the execution result of an async task, please use the `RequestId` returned by this API to poll the `DescribeVpcTaskResult` API.
        /// * The number of IPs bound with an ENI is limited. For more information, see <a href="/document/product/576/18527">ENI Use Limits</a>.
        /// * You can apply for a specified IPv6 address. Currently, the IPv6 address can only be used as a secondary IP, instead of the primary IP.
        /// * The address must be an idle IP in the subnet to which the ENI belongs.
        /// * When applying for one or more secondary IPv6 addresses for an ENI, the API will return the specified number of secondary IPv6 addresses in the subnet range where the ENI is located.
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
        /// This API is used to apply for an IPv6 address for the ENI. <br />
        /// This API is completed asynchronously. If you need to query the execution result of an async task, please use the `RequestId` returned by this API to poll the `DescribeVpcTaskResult` API.
        /// * The number of IPs bound with an ENI is limited. For more information, see <a href="/document/product/576/18527">ENI Use Limits</a>.
        /// * You can apply for a specified IPv6 address. Currently, the IPv6 address can only be used as a secondary IP, instead of the primary IP.
        /// * The address must be an idle IP in the subnet to which the ENI belongs.
        /// * When applying for one or more secondary IPv6 addresses for an ENI, the API will return the specified number of secondary IPv6 addresses in the subnet range where the ENI is located.
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
        /// This API is used to assign IPv6 ranges.
        /// * To use this API, you must already have a VPC instance. If you do not have a VPC instance yet, use the <a href="https://intl.cloud.tencent.com/document/api/215/15774?from_cn_redirect=1" title="CreateVpc" target="_blank">CreateVpc</a> API to create one.
        /// * Each VPC can apply for only one IPv6 range.
        /// </summary>
        /// <param name="req"><see cref="AssignIpv6CidrBlockRequest"/></param>
        /// <returns><see cref="AssignIpv6CidrBlockResponse"/></returns>
        public async Task<AssignIpv6CidrBlockResponse> AssignIpv6CidrBlock(AssignIpv6CidrBlockRequest req)
        {
             JsonResponseModel<AssignIpv6CidrBlockResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssignIpv6CidrBlock");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssignIpv6CidrBlockResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to assign IPv6 ranges.
        /// * To use this API, you must already have a VPC instance. If you do not have a VPC instance yet, use the <a href="https://intl.cloud.tencent.com/document/api/215/15774?from_cn_redirect=1" title="CreateVpc" target="_blank">CreateVpc</a> API to create one.
        /// * Each VPC can apply for only one IPv6 range.
        /// </summary>
        /// <param name="req"><see cref="AssignIpv6CidrBlockRequest"/></param>
        /// <returns><see cref="AssignIpv6CidrBlockResponse"/></returns>
        public AssignIpv6CidrBlockResponse AssignIpv6CidrBlockSync(AssignIpv6CidrBlockRequest req)
        {
             JsonResponseModel<AssignIpv6CidrBlockResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssignIpv6CidrBlock");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssignIpv6CidrBlockResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (AssignIpv6SubnetCidrBlock) is used to assign IPv6 subnet IP ranges.
        /// * To assign an `IPv6` IP range to a subnet, the `VPC` that the subnet belongs to should have obtained the `IPv6` IP range. If this has not been assigned, use the `AssignIpv6CidrBlock` API to assign an `IPv6` IP range to the `VPC` to which the subnet belongs. Otherwise, the `IPv6` subnet IP range cannot be assigned.
        /// * Each subnet can only be assigned one IPv6 IP range.
        /// </summary>
        /// <param name="req"><see cref="AssignIpv6SubnetCidrBlockRequest"/></param>
        /// <returns><see cref="AssignIpv6SubnetCidrBlockResponse"/></returns>
        public async Task<AssignIpv6SubnetCidrBlockResponse> AssignIpv6SubnetCidrBlock(AssignIpv6SubnetCidrBlockRequest req)
        {
             JsonResponseModel<AssignIpv6SubnetCidrBlockResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssignIpv6SubnetCidrBlock");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssignIpv6SubnetCidrBlockResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (AssignIpv6SubnetCidrBlock) is used to assign IPv6 subnet IP ranges.
        /// * To assign an `IPv6` IP range to a subnet, the `VPC` that the subnet belongs to should have obtained the `IPv6` IP range. If this has not been assigned, use the `AssignIpv6CidrBlock` API to assign an `IPv6` IP range to the `VPC` to which the subnet belongs. Otherwise, the `IPv6` subnet IP range cannot be assigned.
        /// * Each subnet can only be assigned one IPv6 IP range.
        /// </summary>
        /// <param name="req"><see cref="AssignIpv6SubnetCidrBlockRequest"/></param>
        /// <returns><see cref="AssignIpv6SubnetCidrBlockResponse"/></returns>
        public AssignIpv6SubnetCidrBlockResponse AssignIpv6SubnetCidrBlockSync(AssignIpv6SubnetCidrBlockRequest req)
        {
             JsonResponseModel<AssignIpv6SubnetCidrBlockResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssignIpv6SubnetCidrBlock");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssignIpv6SubnetCidrBlockResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to apply for private IPs for an ENI.
        /// * An ENI can only be bound with a limited number of IP addresses. For more information about resource limits, see <a href="/document/product/576/18527">ENI Use Limits</a>.
        /// * You can apply for a specified private IP. It cannot be a primary IP because the primary IP already exists and cannot be modified. The private IP address must be an idle IP in the subnet to which the ENI belongs.
        /// * You can apply for more than one secondary private IP on the ENI. The API will return the specified number of secondary private IPs in the subnet IP range.
        /// >?This API is async. You can call the [`DescribeVpcTaskResult`](https://intl.cloud.tencent.com/document/api/215/59037?from_cn_redirect=1) API to query the task result. When the task is completed, you can continue other tasks.
        /// >
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
        /// This API is used to apply for private IPs for an ENI.
        /// * An ENI can only be bound with a limited number of IP addresses. For more information about resource limits, see <a href="/document/product/576/18527">ENI Use Limits</a>.
        /// * You can apply for a specified private IP. It cannot be a primary IP because the primary IP already exists and cannot be modified. The private IP address must be an idle IP in the subnet to which the ENI belongs.
        /// * You can apply for more than one secondary private IP on the ENI. The API will return the specified number of secondary private IPs in the subnet IP range.
        /// >?This API is async. You can call the [`DescribeVpcTaskResult`](https://intl.cloud.tencent.com/document/api/215/59037?from_cn_redirect=1) API to query the task result. When the task is completed, you can continue other tasks.
        /// >
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
        /// This API is used to bind an [Elastic IP](https://intl.cloud.tencent.com/document/product/213/1941?from_cn_redirect=1) (EIP for short) to the specified private IP of an instance or ENI.
        /// * Binding an EIP to a CVM instance is actually binding the EIP to the primary private IP of the primary ENI on the CVM instance.
        /// * When an EIP is bound, the public IP previously bound to the CVM instance will be unbound and released automatically.
        /// * To bind another EIP to the private IP of the specified ENI, you must first unbind the EIP.
        /// * To bind an EIP to a NAT Gateway, use the API [AssociateNatGatewayAddress](https://intl.cloud.tencent.com/document/product/215/36722?from_cn_redirect=1).
        /// * An EIP cannot be bound if it’s overdue or blocked
        /// * Only EIP in the `UNBIND` status can be bound.
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
        /// This API is used to bind an [Elastic IP](https://intl.cloud.tencent.com/document/product/213/1941?from_cn_redirect=1) (EIP for short) to the specified private IP of an instance or ENI.
        /// * Binding an EIP to a CVM instance is actually binding the EIP to the primary private IP of the primary ENI on the CVM instance.
        /// * When an EIP is bound, the public IP previously bound to the CVM instance will be unbound and released automatically.
        /// * To bind another EIP to the private IP of the specified ENI, you must first unbind the EIP.
        /// * To bind an EIP to a NAT Gateway, use the API [AssociateNatGatewayAddress](https://intl.cloud.tencent.com/document/product/215/36722?from_cn_redirect=1).
        /// * An EIP cannot be bound if it’s overdue or blocked
        /// * Only EIP in the `UNBIND` status can be bound.
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
        /// This API is used to bind a direct connect gateway with a NAT gateway,  and direct its default route to the NAT Gateway.
        /// </summary>
        /// <param name="req"><see cref="AssociateDirectConnectGatewayNatGatewayRequest"/></param>
        /// <returns><see cref="AssociateDirectConnectGatewayNatGatewayResponse"/></returns>
        public async Task<AssociateDirectConnectGatewayNatGatewayResponse> AssociateDirectConnectGatewayNatGateway(AssociateDirectConnectGatewayNatGatewayRequest req)
        {
             JsonResponseModel<AssociateDirectConnectGatewayNatGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssociateDirectConnectGatewayNatGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateDirectConnectGatewayNatGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind a direct connect gateway with a NAT gateway,  and direct its default route to the NAT Gateway.
        /// </summary>
        /// <param name="req"><see cref="AssociateDirectConnectGatewayNatGatewayRequest"/></param>
        /// <returns><see cref="AssociateDirectConnectGatewayNatGatewayResponse"/></returns>
        public AssociateDirectConnectGatewayNatGatewayResponse AssociateDirectConnectGatewayNatGatewaySync(AssociateDirectConnectGatewayNatGatewayRequest req)
        {
             JsonResponseModel<AssociateDirectConnectGatewayNatGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssociateDirectConnectGatewayNatGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateDirectConnectGatewayNatGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind an EIP to a NAT gateway.
        /// </summary>
        /// <param name="req"><see cref="AssociateNatGatewayAddressRequest"/></param>
        /// <returns><see cref="AssociateNatGatewayAddressResponse"/></returns>
        public async Task<AssociateNatGatewayAddressResponse> AssociateNatGatewayAddress(AssociateNatGatewayAddressRequest req)
        {
             JsonResponseModel<AssociateNatGatewayAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssociateNatGatewayAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateNatGatewayAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind an EIP to a NAT gateway.
        /// </summary>
        /// <param name="req"><see cref="AssociateNatGatewayAddressRequest"/></param>
        /// <returns><see cref="AssociateNatGatewayAddressResponse"/></returns>
        public AssociateNatGatewayAddressResponse AssociateNatGatewayAddressSync(AssociateNatGatewayAddressRequest req)
        {
             JsonResponseModel<AssociateNatGatewayAddressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssociateNatGatewayAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateNatGatewayAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to associate a network ACL with subnets in a VPC instance.
        /// </summary>
        /// <param name="req"><see cref="AssociateNetworkAclSubnetsRequest"/></param>
        /// <returns><see cref="AssociateNetworkAclSubnetsResponse"/></returns>
        public async Task<AssociateNetworkAclSubnetsResponse> AssociateNetworkAclSubnets(AssociateNetworkAclSubnetsRequest req)
        {
             JsonResponseModel<AssociateNetworkAclSubnetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssociateNetworkAclSubnets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateNetworkAclSubnetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to associate a network ACL with subnets in a VPC instance.
        /// </summary>
        /// <param name="req"><see cref="AssociateNetworkAclSubnetsRequest"/></param>
        /// <returns><see cref="AssociateNetworkAclSubnetsResponse"/></returns>
        public AssociateNetworkAclSubnetsResponse AssociateNetworkAclSubnetsSync(AssociateNetworkAclSubnetsRequest req)
        {
             JsonResponseModel<AssociateNetworkAclSubnetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssociateNetworkAclSubnets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateNetworkAclSubnetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (AssociateNetworkInterfaceSecurityGroups) is used to attach a security group to an ENI.
        /// </summary>
        /// <param name="req"><see cref="AssociateNetworkInterfaceSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateNetworkInterfaceSecurityGroupsResponse"/></returns>
        public async Task<AssociateNetworkInterfaceSecurityGroupsResponse> AssociateNetworkInterfaceSecurityGroups(AssociateNetworkInterfaceSecurityGroupsRequest req)
        {
             JsonResponseModel<AssociateNetworkInterfaceSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssociateNetworkInterfaceSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateNetworkInterfaceSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (AssociateNetworkInterfaceSecurityGroups) is used to attach a security group to an ENI.
        /// </summary>
        /// <param name="req"><see cref="AssociateNetworkInterfaceSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateNetworkInterfaceSecurityGroupsResponse"/></returns>
        public AssociateNetworkInterfaceSecurityGroupsResponse AssociateNetworkInterfaceSecurityGroupsSync(AssociateNetworkInterfaceSecurityGroupsRequest req)
        {
             JsonResponseModel<AssociateNetworkInterfaceSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssociateNetworkInterfaceSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateNetworkInterfaceSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (AttachCcnInstances) is used to load a network instance to a CCN instance. Network instances include VPCs and Direct Connect gateways.<br />
        /// The number of network instances that each CCN can be associated with is limited. For more information, see the product documentation. If you need to associate more instances, please contact online customer service.
        /// </summary>
        /// <param name="req"><see cref="AttachCcnInstancesRequest"/></param>
        /// <returns><see cref="AttachCcnInstancesResponse"/></returns>
        public async Task<AttachCcnInstancesResponse> AttachCcnInstances(AttachCcnInstancesRequest req)
        {
             JsonResponseModel<AttachCcnInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AttachCcnInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachCcnInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (AttachCcnInstances) is used to load a network instance to a CCN instance. Network instances include VPCs and Direct Connect gateways.<br />
        /// The number of network instances that each CCN can be associated with is limited. For more information, see the product documentation. If you need to associate more instances, please contact online customer service.
        /// </summary>
        /// <param name="req"><see cref="AttachCcnInstancesRequest"/></param>
        /// <returns><see cref="AttachCcnInstancesResponse"/></returns>
        public AttachCcnInstancesResponse AttachCcnInstancesSync(AttachCcnInstancesRequest req)
        {
             JsonResponseModel<AttachCcnInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AttachCcnInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachCcnInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a Classiclink between a VPC instance and a classic network device.
        /// * The VPC instance and the classic network device must be in the same region.
        /// * For differences between VPC and the classic network, see <a href="https://intl.cloud.tencent.com/document/product/215/30720?from_cn_redirect=1">VPC and Classic Network</a>.
        /// >?This API is async. You can call the [`DescribeVpcTaskResult`](https://intl.cloud.tencent.com/document/api/215/59037?from_cn_redirect=1) API to query the task result. When the task is completed, you can continue other tasks.
        /// >
        /// </summary>
        /// <param name="req"><see cref="AttachClassicLinkVpcRequest"/></param>
        /// <returns><see cref="AttachClassicLinkVpcResponse"/></returns>
        public async Task<AttachClassicLinkVpcResponse> AttachClassicLinkVpc(AttachClassicLinkVpcRequest req)
        {
             JsonResponseModel<AttachClassicLinkVpcResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AttachClassicLinkVpc");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachClassicLinkVpcResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a Classiclink between a VPC instance and a classic network device.
        /// * The VPC instance and the classic network device must be in the same region.
        /// * For differences between VPC and the classic network, see <a href="https://intl.cloud.tencent.com/document/product/215/30720?from_cn_redirect=1">VPC and Classic Network</a>.
        /// >?This API is async. You can call the [`DescribeVpcTaskResult`](https://intl.cloud.tencent.com/document/api/215/59037?from_cn_redirect=1) API to query the task result. When the task is completed, you can continue other tasks.
        /// >
        /// </summary>
        /// <param name="req"><see cref="AttachClassicLinkVpcRequest"/></param>
        /// <returns><see cref="AttachClassicLinkVpcResponse"/></returns>
        public AttachClassicLinkVpcResponse AttachClassicLinkVpcSync(AttachClassicLinkVpcRequest req)
        {
             JsonResponseModel<AttachClassicLinkVpcResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AttachClassicLinkVpc");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachClassicLinkVpcResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind an ENI to a CVM.
        /// * An ENI must be bound with one security group at least. To bind it, see <a href="https://intl.cloud.tencent.com/document/product/215/43132?from_cn_redirect=1">AssociateNetworkInterfaceSecurityGroups</a>.
        /// * One CVM can be bound with multiple ENIs, but only one can be the primary ENI. For more information about the limits, see <a href="https://intl.cloud.tencent.com/document/product/576/18527?from_cn_redirect=1">ENI Use Limits</a>.
        /// * An ENI can only be bound to one CVM.
        /// * Only the running or shutdown CVMs can be bound with ENIs. For more information about the CVM status, see <a href="https://intl.cloud.tencent.com/document/api/213/9452?from_cn_redirect=1#InstanceStatus">InstanceStatus</a> in the Data Types.
        /// * An ENI can only be bound to a VPC-based CVM under the same availability zone as the ENI subnet.
        /// 
        /// This API is completed asynchronously. If you need to query the execution result of an async task, please use the `RequestId` returned by this API to poll the `DescribeVpcTaskResult` API.
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
        /// This API is used to bind an ENI to a CVM.
        /// * An ENI must be bound with one security group at least. To bind it, see <a href="https://intl.cloud.tencent.com/document/product/215/43132?from_cn_redirect=1">AssociateNetworkInterfaceSecurityGroups</a>.
        /// * One CVM can be bound with multiple ENIs, but only one can be the primary ENI. For more information about the limits, see <a href="https://intl.cloud.tencent.com/document/product/576/18527?from_cn_redirect=1">ENI Use Limits</a>.
        /// * An ENI can only be bound to one CVM.
        /// * Only the running or shutdown CVMs can be bound with ENIs. For more information about the CVM status, see <a href="https://intl.cloud.tencent.com/document/api/213/9452?from_cn_redirect=1#InstanceStatus">InstanceStatus</a> in the Data Types.
        /// * An ENI can only be bound to a VPC-based CVM under the same availability zone as the ENI subnet.
        /// 
        /// This API is completed asynchronously. If you need to query the execution result of an async task, please use the `RequestId` returned by this API to poll the `DescribeVpcTaskResult` API.
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
        /// This API is used to associate a snapshot policy with specified instances.
        /// </summary>
        /// <param name="req"><see cref="AttachSnapshotInstancesRequest"/></param>
        /// <returns><see cref="AttachSnapshotInstancesResponse"/></returns>
        public async Task<AttachSnapshotInstancesResponse> AttachSnapshotInstances(AttachSnapshotInstancesRequest req)
        {
             JsonResponseModel<AttachSnapshotInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AttachSnapshotInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachSnapshotInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to associate a snapshot policy with specified instances.
        /// </summary>
        /// <param name="req"><see cref="AttachSnapshotInstancesRequest"/></param>
        /// <returns><see cref="AttachSnapshotInstancesResponse"/></returns>
        public AttachSnapshotInstancesResponse AttachSnapshotInstancesSync(AttachSnapshotInstancesRequest req)
        {
             JsonResponseModel<AttachSnapshotInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AttachSnapshotInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachSnapshotInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used by the service provider to perform a compliance audit.
        /// * This API is only provided for service providers to audit compliance review requests received. Tencent Cloud will verify the identity of the service provider by the `APPID`. 
        /// * The status of the review request can be changed between `APPROVED` and `DENY`.
        /// </summary>
        /// <param name="req"><see cref="AuditCrossBorderComplianceRequest"/></param>
        /// <returns><see cref="AuditCrossBorderComplianceResponse"/></returns>
        public async Task<AuditCrossBorderComplianceResponse> AuditCrossBorderCompliance(AuditCrossBorderComplianceRequest req)
        {
             JsonResponseModel<AuditCrossBorderComplianceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AuditCrossBorderCompliance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AuditCrossBorderComplianceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used by the service provider to perform a compliance audit.
        /// * This API is only provided for service providers to audit compliance review requests received. Tencent Cloud will verify the identity of the service provider by the `APPID`. 
        /// * The status of the review request can be changed between `APPROVED` and `DENY`.
        /// </summary>
        /// <param name="req"><see cref="AuditCrossBorderComplianceRequest"/></param>
        /// <returns><see cref="AuditCrossBorderComplianceResponse"/></returns>
        public AuditCrossBorderComplianceResponse AuditCrossBorderComplianceSync(AuditCrossBorderComplianceRequest req)
        {
             JsonResponseModel<AuditCrossBorderComplianceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AuditCrossBorderCompliance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AuditCrossBorderComplianceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to check whether the secondary CIDR block conflicts with existing routes, peering connections (peer VPC CIDR blocks), and other resources. 
        /// * Check whether the secondary CIDR block overlaps with the primary/secondary CIDR block of the current VPC.
        /// * Check whether the secondary CIDR block overlaps with the routing destination of the current VPC.
        /// * If the current VPC is used in a peering connection, check whether the secondary CIDR block overlaps with the primary/secondary CIDR block of the peer VPC.
        /// </summary>
        /// <param name="req"><see cref="CheckAssistantCidrRequest"/></param>
        /// <returns><see cref="CheckAssistantCidrResponse"/></returns>
        public async Task<CheckAssistantCidrResponse> CheckAssistantCidr(CheckAssistantCidrRequest req)
        {
             JsonResponseModel<CheckAssistantCidrResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckAssistantCidr");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckAssistantCidrResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to check whether the secondary CIDR block conflicts with existing routes, peering connections (peer VPC CIDR blocks), and other resources. 
        /// * Check whether the secondary CIDR block overlaps with the primary/secondary CIDR block of the current VPC.
        /// * Check whether the secondary CIDR block overlaps with the routing destination of the current VPC.
        /// * If the current VPC is used in a peering connection, check whether the secondary CIDR block overlaps with the primary/secondary CIDR block of the peer VPC.
        /// </summary>
        /// <param name="req"><see cref="CheckAssistantCidrRequest"/></param>
        /// <returns><see cref="CheckAssistantCidrResponse"/></returns>
        public CheckAssistantCidrResponse CheckAssistantCidrSync(CheckAssistantCidrRequest req)
        {
             JsonResponseModel<CheckAssistantCidrResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckAssistantCidr");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckAssistantCidrResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to verify the network detection status.
        /// </summary>
        /// <param name="req"><see cref="CheckNetDetectStateRequest"/></param>
        /// <returns><see cref="CheckNetDetectStateResponse"/></returns>
        public async Task<CheckNetDetectStateResponse> CheckNetDetectState(CheckNetDetectStateRequest req)
        {
             JsonResponseModel<CheckNetDetectStateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckNetDetectState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckNetDetectStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to verify the network detection status.
        /// </summary>
        /// <param name="req"><see cref="CheckNetDetectStateRequest"/></param>
        /// <returns><see cref="CheckNetDetectStateResponse"/></returns>
        public CheckNetDetectStateResponse CheckNetDetectStateSync(CheckNetDetectStateRequest req)
        {
             JsonResponseModel<CheckNetDetectStateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckNetDetectState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckNetDetectStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a security group with the same rule configurations as an existing security group. The cloning only copies the security group and its rules, but not the security group tags.
        /// </summary>
        /// <param name="req"><see cref="CloneSecurityGroupRequest"/></param>
        /// <returns><see cref="CloneSecurityGroupResponse"/></returns>
        public async Task<CloneSecurityGroupResponse> CloneSecurityGroup(CloneSecurityGroupRequest req)
        {
             JsonResponseModel<CloneSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CloneSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloneSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a security group with the same rule configurations as an existing security group. The cloning only copies the security group and its rules, but not the security group tags.
        /// </summary>
        /// <param name="req"><see cref="CloneSecurityGroupRequest"/></param>
        /// <returns><see cref="CloneSecurityGroupResponse"/></returns>
        public CloneSecurityGroupResponse CloneSecurityGroupSync(CloneSecurityGroupRequest req)
        {
             JsonResponseModel<CloneSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CloneSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloneSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an IP address template.
        /// </summary>
        /// <param name="req"><see cref="CreateAddressTemplateRequest"/></param>
        /// <returns><see cref="CreateAddressTemplateResponse"/></returns>
        public async Task<CreateAddressTemplateResponse> CreateAddressTemplate(CreateAddressTemplateRequest req)
        {
             JsonResponseModel<CreateAddressTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAddressTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAddressTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an IP address template.
        /// </summary>
        /// <param name="req"><see cref="CreateAddressTemplateRequest"/></param>
        /// <returns><see cref="CreateAddressTemplateResponse"/></returns>
        public CreateAddressTemplateResponse CreateAddressTemplateSync(CreateAddressTemplateRequest req)
        {
             JsonResponseModel<CreateAddressTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAddressTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAddressTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an IP address template group.
        /// </summary>
        /// <param name="req"><see cref="CreateAddressTemplateGroupRequest"/></param>
        /// <returns><see cref="CreateAddressTemplateGroupResponse"/></returns>
        public async Task<CreateAddressTemplateGroupResponse> CreateAddressTemplateGroup(CreateAddressTemplateGroupRequest req)
        {
             JsonResponseModel<CreateAddressTemplateGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAddressTemplateGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAddressTemplateGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an IP address template group.
        /// </summary>
        /// <param name="req"><see cref="CreateAddressTemplateGroupRequest"/></param>
        /// <returns><see cref="CreateAddressTemplateGroupResponse"/></returns>
        public CreateAddressTemplateGroupResponse CreateAddressTemplateGroupSync(CreateAddressTemplateGroupRequest req)
        {
             JsonResponseModel<CreateAddressTemplateGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAddressTemplateGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAddressTemplateGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an ENI and bind it to a CVM.
        /// * You can specify private IP addresses and a primary IP when creating an ENI. The specified private IP must be idle and in the same subnet as the ENI.
        /// * When creating an ENI, you can specify the number of private IPs that you want to apply for. The system will randomly generate private IP addresses.
        /// * The number of IPs bound with an ENI is limited. For more information, see <a href="/document/product/576/18527">ENI Use Limits</a>.
        /// * You can bind an existing security group when creating an ENI.
        /// * You can bind a tag when creating an ENI. The tag list in the response indicates the tags that have been successfully added.
        /// >?This API is async. You can call the [`DescribeVpcTaskResult`](https://intl.cloud.tencent.com/document/api/215/59037?from_cn_redirect=1) API to query the task result. When the task is completed, you can continue other tasks.
        /// >
        /// </summary>
        /// <param name="req"><see cref="CreateAndAttachNetworkInterfaceRequest"/></param>
        /// <returns><see cref="CreateAndAttachNetworkInterfaceResponse"/></returns>
        public async Task<CreateAndAttachNetworkInterfaceResponse> CreateAndAttachNetworkInterface(CreateAndAttachNetworkInterfaceRequest req)
        {
             JsonResponseModel<CreateAndAttachNetworkInterfaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAndAttachNetworkInterface");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAndAttachNetworkInterfaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an ENI and bind it to a CVM.
        /// * You can specify private IP addresses and a primary IP when creating an ENI. The specified private IP must be idle and in the same subnet as the ENI.
        /// * When creating an ENI, you can specify the number of private IPs that you want to apply for. The system will randomly generate private IP addresses.
        /// * The number of IPs bound with an ENI is limited. For more information, see <a href="/document/product/576/18527">ENI Use Limits</a>.
        /// * You can bind an existing security group when creating an ENI.
        /// * You can bind a tag when creating an ENI. The tag list in the response indicates the tags that have been successfully added.
        /// >?This API is async. You can call the [`DescribeVpcTaskResult`](https://intl.cloud.tencent.com/document/api/215/59037?from_cn_redirect=1) API to query the task result. When the task is completed, you can continue other tasks.
        /// >
        /// </summary>
        /// <param name="req"><see cref="CreateAndAttachNetworkInterfaceRequest"/></param>
        /// <returns><see cref="CreateAndAttachNetworkInterfaceResponse"/></returns>
        public CreateAndAttachNetworkInterfaceResponse CreateAndAttachNetworkInterfaceSync(CreateAndAttachNetworkInterfaceRequest req)
        {
             JsonResponseModel<CreateAndAttachNetworkInterfaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAndAttachNetworkInterface");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAndAttachNetworkInterfaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to batch create secondary CIDR blocks.
        /// </summary>
        /// <param name="req"><see cref="CreateAssistantCidrRequest"/></param>
        /// <returns><see cref="CreateAssistantCidrResponse"/></returns>
        public async Task<CreateAssistantCidrResponse> CreateAssistantCidr(CreateAssistantCidrRequest req)
        {
             JsonResponseModel<CreateAssistantCidrResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAssistantCidr");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAssistantCidrResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to batch create secondary CIDR blocks.
        /// </summary>
        /// <param name="req"><see cref="CreateAssistantCidrRequest"/></param>
        /// <returns><see cref="CreateAssistantCidrResponse"/></returns>
        public CreateAssistantCidrResponse CreateAssistantCidrSync(CreateAssistantCidrRequest req)
        {
             JsonResponseModel<CreateAssistantCidrResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAssistantCidr");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAssistantCidrResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a [device bandwidth package](https://intl.cloud.tencent.com/document/product/684/15245?from_cn_redirect=1#bwptype) or an [IP bandwidth package](https://intl.cloud.tencent.com/document/product/684/15245?from_cn_redirect=1#bwptype).
        /// </summary>
        /// <param name="req"><see cref="CreateBandwidthPackageRequest"/></param>
        /// <returns><see cref="CreateBandwidthPackageResponse"/></returns>
        public async Task<CreateBandwidthPackageResponse> CreateBandwidthPackage(CreateBandwidthPackageRequest req)
        {
             JsonResponseModel<CreateBandwidthPackageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBandwidthPackage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBandwidthPackageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a [device bandwidth package](https://intl.cloud.tencent.com/document/product/684/15245?from_cn_redirect=1#bwptype) or an [IP bandwidth package](https://intl.cloud.tencent.com/document/product/684/15245?from_cn_redirect=1#bwptype).
        /// </summary>
        /// <param name="req"><see cref="CreateBandwidthPackageRequest"/></param>
        /// <returns><see cref="CreateBandwidthPackageResponse"/></returns>
        public CreateBandwidthPackageResponse CreateBandwidthPackageSync(CreateBandwidthPackageRequest req)
        {
             JsonResponseModel<CreateBandwidthPackageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBandwidthPackage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBandwidthPackageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a CCN instance.
        /// * You can add tags to a CCN instance upon the creation. The tags are added successfully if they are listed in the response.
        /// * There is a quota of CCN instances for each account. For more information, see product documentation. To increase the quota, please submit a ticket.
        /// </summary>
        /// <param name="req"><see cref="CreateCcnRequest"/></param>
        /// <returns><see cref="CreateCcnResponse"/></returns>
        public async Task<CreateCcnResponse> CreateCcn(CreateCcnRequest req)
        {
             JsonResponseModel<CreateCcnResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCcn");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCcnResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a CCN instance.
        /// * You can add tags to a CCN instance upon the creation. The tags are added successfully if they are listed in the response.
        /// * There is a quota of CCN instances for each account. For more information, see product documentation. To increase the quota, please submit a ticket.
        /// </summary>
        /// <param name="req"><see cref="CreateCcnRequest"/></param>
        /// <returns><see cref="CreateCcnResponse"/></returns>
        public CreateCcnResponse CreateCcnSync(CreateCcnRequest req)
        {
             JsonResponseModel<CreateCcnResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCcn");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCcnResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateCustomerGateway) is used to create customer gateways.
        /// </summary>
        /// <param name="req"><see cref="CreateCustomerGatewayRequest"/></param>
        /// <returns><see cref="CreateCustomerGatewayResponse"/></returns>
        public async Task<CreateCustomerGatewayResponse> CreateCustomerGateway(CreateCustomerGatewayRequest req)
        {
             JsonResponseModel<CreateCustomerGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCustomerGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCustomerGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateCustomerGateway) is used to create customer gateways.
        /// </summary>
        /// <param name="req"><see cref="CreateCustomerGatewayRequest"/></param>
        /// <returns><see cref="CreateCustomerGatewayResponse"/></returns>
        public CreateCustomerGatewayResponse CreateCustomerGatewaySync(CreateCustomerGatewayRequest req)
        {
             JsonResponseModel<CreateCustomerGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCustomerGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCustomerGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a default VPC.
        /// 
        /// The default VPC is suitable for getting started with and launching public instances, and it can be used like any other VPCs. To create a standard VPC, for which you need to specify a VPC name, VPC IP range, subnet IP range, and subnet availability zone, use the regular CreateVpc API.
        /// 
        /// Under normal circumstances, this API may not create a default VPC. It depends on the network attributes (DescribeAccountAttributes) of your account.
        /// * If both basic network and VPC are supported, the returned VpcId is 0.
        /// * If only VPC is supported, the default VPC information is returned.
        /// 
        /// You can also use the Force parameter to forcibly return a default VPC.
        /// </summary>
        /// <param name="req"><see cref="CreateDefaultVpcRequest"/></param>
        /// <returns><see cref="CreateDefaultVpcResponse"/></returns>
        public async Task<CreateDefaultVpcResponse> CreateDefaultVpc(CreateDefaultVpcRequest req)
        {
             JsonResponseModel<CreateDefaultVpcResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDefaultVpc");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDefaultVpcResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a default VPC.
        /// 
        /// The default VPC is suitable for getting started with and launching public instances, and it can be used like any other VPCs. To create a standard VPC, for which you need to specify a VPC name, VPC IP range, subnet IP range, and subnet availability zone, use the regular CreateVpc API.
        /// 
        /// Under normal circumstances, this API may not create a default VPC. It depends on the network attributes (DescribeAccountAttributes) of your account.
        /// * If both basic network and VPC are supported, the returned VpcId is 0.
        /// * If only VPC is supported, the default VPC information is returned.
        /// 
        /// You can also use the Force parameter to forcibly return a default VPC.
        /// </summary>
        /// <param name="req"><see cref="CreateDefaultVpcRequest"/></param>
        /// <returns><see cref="CreateDefaultVpcResponse"/></returns>
        public CreateDefaultVpcResponse CreateDefaultVpcSync(CreateDefaultVpcRequest req)
        {
             JsonResponseModel<CreateDefaultVpcResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDefaultVpc");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDefaultVpcResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a direct connect gateway.
        /// </summary>
        /// <param name="req"><see cref="CreateDirectConnectGatewayRequest"/></param>
        /// <returns><see cref="CreateDirectConnectGatewayResponse"/></returns>
        public async Task<CreateDirectConnectGatewayResponse> CreateDirectConnectGateway(CreateDirectConnectGatewayRequest req)
        {
             JsonResponseModel<CreateDirectConnectGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDirectConnectGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDirectConnectGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a direct connect gateway.
        /// </summary>
        /// <param name="req"><see cref="CreateDirectConnectGatewayRequest"/></param>
        /// <returns><see cref="CreateDirectConnectGatewayResponse"/></returns>
        public CreateDirectConnectGatewayResponse CreateDirectConnectGatewaySync(CreateDirectConnectGatewayRequest req)
        {
             JsonResponseModel<CreateDirectConnectGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDirectConnectGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDirectConnectGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateDirectConnectGatewayCcnRoutes) is used to create the CCN route (IDC IP range) of a Direct Connect gateway.
        /// </summary>
        /// <param name="req"><see cref="CreateDirectConnectGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="CreateDirectConnectGatewayCcnRoutesResponse"/></returns>
        public async Task<CreateDirectConnectGatewayCcnRoutesResponse> CreateDirectConnectGatewayCcnRoutes(CreateDirectConnectGatewayCcnRoutesRequest req)
        {
             JsonResponseModel<CreateDirectConnectGatewayCcnRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDirectConnectGatewayCcnRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDirectConnectGatewayCcnRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateDirectConnectGatewayCcnRoutes) is used to create the CCN route (IDC IP range) of a Direct Connect gateway.
        /// </summary>
        /// <param name="req"><see cref="CreateDirectConnectGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="CreateDirectConnectGatewayCcnRoutesResponse"/></returns>
        public CreateDirectConnectGatewayCcnRoutesResponse CreateDirectConnectGatewayCcnRoutesSync(CreateDirectConnectGatewayCcnRoutesRequest req)
        {
             JsonResponseModel<CreateDirectConnectGatewayCcnRoutesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDirectConnectGatewayCcnRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDirectConnectGatewayCcnRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a flow log.
        /// </summary>
        /// <param name="req"><see cref="CreateFlowLogRequest"/></param>
        /// <returns><see cref="CreateFlowLogResponse"/></returns>
        public async Task<CreateFlowLogResponse> CreateFlowLog(CreateFlowLogRequest req)
        {
             JsonResponseModel<CreateFlowLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateFlowLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFlowLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a flow log.
        /// </summary>
        /// <param name="req"><see cref="CreateFlowLogRequest"/></param>
        /// <returns><see cref="CreateFlowLogResponse"/></returns>
        public CreateFlowLogResponse CreateFlowLogSync(CreateFlowLogRequest req)
        {
             JsonResponseModel<CreateFlowLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateFlowLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFlowLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateHaVip) is used to create a highly available virtual IP (HAVIP)
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
        /// This API (CreateHaVip) is used to create a highly available virtual IP (HAVIP)
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
        /// This API is used to create a local gateway for a CDC instance.
        /// </summary>
        /// <param name="req"><see cref="CreateLocalGatewayRequest"/></param>
        /// <returns><see cref="CreateLocalGatewayResponse"/></returns>
        public async Task<CreateLocalGatewayResponse> CreateLocalGateway(CreateLocalGatewayRequest req)
        {
             JsonResponseModel<CreateLocalGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLocalGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLocalGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a local gateway for a CDC instance.
        /// </summary>
        /// <param name="req"><see cref="CreateLocalGatewayRequest"/></param>
        /// <returns><see cref="CreateLocalGatewayResponse"/></returns>
        public CreateLocalGatewayResponse CreateLocalGatewaySync(CreateLocalGatewayRequest req)
        {
             JsonResponseModel<CreateLocalGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLocalGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLocalGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a NAT Gateway.
        /// Before taking actions on a NAT gateway, ensure that it has been successfully created, namely, the `State` field in the response of the `DescribeNatGateway` API is `AVAILABLE`.
        /// </summary>
        /// <param name="req"><see cref="CreateNatGatewayRequest"/></param>
        /// <returns><see cref="CreateNatGatewayResponse"/></returns>
        public async Task<CreateNatGatewayResponse> CreateNatGateway(CreateNatGatewayRequest req)
        {
             JsonResponseModel<CreateNatGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateNatGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNatGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a NAT Gateway.
        /// Before taking actions on a NAT gateway, ensure that it has been successfully created, namely, the `State` field in the response of the `DescribeNatGateway` API is `AVAILABLE`.
        /// </summary>
        /// <param name="req"><see cref="CreateNatGatewayRequest"/></param>
        /// <returns><see cref="CreateNatGatewayResponse"/></returns>
        public CreateNatGatewayResponse CreateNatGatewaySync(CreateNatGatewayRequest req)
        {
             JsonResponseModel<CreateNatGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateNatGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNatGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create the port forwarding rules of a NAT gateway.
        /// </summary>
        /// <param name="req"><see cref="CreateNatGatewayDestinationIpPortTranslationNatRuleRequest"/></param>
        /// <returns><see cref="CreateNatGatewayDestinationIpPortTranslationNatRuleResponse"/></returns>
        public async Task<CreateNatGatewayDestinationIpPortTranslationNatRuleResponse> CreateNatGatewayDestinationIpPortTranslationNatRule(CreateNatGatewayDestinationIpPortTranslationNatRuleRequest req)
        {
             JsonResponseModel<CreateNatGatewayDestinationIpPortTranslationNatRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateNatGatewayDestinationIpPortTranslationNatRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNatGatewayDestinationIpPortTranslationNatRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create the port forwarding rules of a NAT gateway.
        /// </summary>
        /// <param name="req"><see cref="CreateNatGatewayDestinationIpPortTranslationNatRuleRequest"/></param>
        /// <returns><see cref="CreateNatGatewayDestinationIpPortTranslationNatRuleResponse"/></returns>
        public CreateNatGatewayDestinationIpPortTranslationNatRuleResponse CreateNatGatewayDestinationIpPortTranslationNatRuleSync(CreateNatGatewayDestinationIpPortTranslationNatRuleRequest req)
        {
             JsonResponseModel<CreateNatGatewayDestinationIpPortTranslationNatRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateNatGatewayDestinationIpPortTranslationNatRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNatGatewayDestinationIpPortTranslationNatRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create SNAT rules for a NAT gateway.
        /// </summary>
        /// <param name="req"><see cref="CreateNatGatewaySourceIpTranslationNatRuleRequest"/></param>
        /// <returns><see cref="CreateNatGatewaySourceIpTranslationNatRuleResponse"/></returns>
        public async Task<CreateNatGatewaySourceIpTranslationNatRuleResponse> CreateNatGatewaySourceIpTranslationNatRule(CreateNatGatewaySourceIpTranslationNatRuleRequest req)
        {
             JsonResponseModel<CreateNatGatewaySourceIpTranslationNatRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateNatGatewaySourceIpTranslationNatRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNatGatewaySourceIpTranslationNatRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create SNAT rules for a NAT gateway.
        /// </summary>
        /// <param name="req"><see cref="CreateNatGatewaySourceIpTranslationNatRuleRequest"/></param>
        /// <returns><see cref="CreateNatGatewaySourceIpTranslationNatRuleResponse"/></returns>
        public CreateNatGatewaySourceIpTranslationNatRuleResponse CreateNatGatewaySourceIpTranslationNatRuleSync(CreateNatGatewaySourceIpTranslationNatRuleRequest req)
        {
             JsonResponseModel<CreateNatGatewaySourceIpTranslationNatRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateNatGatewaySourceIpTranslationNatRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNatGatewaySourceIpTranslationNatRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a network detection instance.
        /// </summary>
        /// <param name="req"><see cref="CreateNetDetectRequest"/></param>
        /// <returns><see cref="CreateNetDetectResponse"/></returns>
        public async Task<CreateNetDetectResponse> CreateNetDetect(CreateNetDetectRequest req)
        {
             JsonResponseModel<CreateNetDetectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateNetDetect");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNetDetectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a network detection instance.
        /// </summary>
        /// <param name="req"><see cref="CreateNetDetectRequest"/></param>
        /// <returns><see cref="CreateNetDetectResponse"/></returns>
        public CreateNetDetectResponse CreateNetDetectSync(CreateNetDetectRequest req)
        {
             JsonResponseModel<CreateNetDetectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateNetDetect");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNetDetectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a <a href="https://intl.cloud.tencent.com/document/product/215/20088?from_cn_redirect=1">network ACL</a>.
        /// * The inbound and outbound rules for a new network ACL are "Deny All" by default. You need to call `ModifyNetworkAclEntries` to set rules for the new network ACL as needed.
        /// </summary>
        /// <param name="req"><see cref="CreateNetworkAclRequest"/></param>
        /// <returns><see cref="CreateNetworkAclResponse"/></returns>
        public async Task<CreateNetworkAclResponse> CreateNetworkAcl(CreateNetworkAclRequest req)
        {
             JsonResponseModel<CreateNetworkAclResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateNetworkAcl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNetworkAclResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a <a href="https://intl.cloud.tencent.com/document/product/215/20088?from_cn_redirect=1">network ACL</a>.
        /// * The inbound and outbound rules for a new network ACL are "Deny All" by default. You need to call `ModifyNetworkAclEntries` to set rules for the new network ACL as needed.
        /// </summary>
        /// <param name="req"><see cref="CreateNetworkAclRequest"/></param>
        /// <returns><see cref="CreateNetworkAclResponse"/></returns>
        public CreateNetworkAclResponse CreateNetworkAclSync(CreateNetworkAclRequest req)
        {
             JsonResponseModel<CreateNetworkAclResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateNetworkAcl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNetworkAclResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add one or more in/outbound rules of the network ACL quintuple.
        /// </summary>
        /// <param name="req"><see cref="CreateNetworkAclQuintupleEntriesRequest"/></param>
        /// <returns><see cref="CreateNetworkAclQuintupleEntriesResponse"/></returns>
        public async Task<CreateNetworkAclQuintupleEntriesResponse> CreateNetworkAclQuintupleEntries(CreateNetworkAclQuintupleEntriesRequest req)
        {
             JsonResponseModel<CreateNetworkAclQuintupleEntriesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateNetworkAclQuintupleEntries");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNetworkAclQuintupleEntriesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add one or more in/outbound rules of the network ACL quintuple.
        /// </summary>
        /// <param name="req"><see cref="CreateNetworkAclQuintupleEntriesRequest"/></param>
        /// <returns><see cref="CreateNetworkAclQuintupleEntriesResponse"/></returns>
        public CreateNetworkAclQuintupleEntriesResponse CreateNetworkAclQuintupleEntriesSync(CreateNetworkAclQuintupleEntriesRequest req)
        {
             JsonResponseModel<CreateNetworkAclQuintupleEntriesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateNetworkAclQuintupleEntries");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNetworkAclQuintupleEntriesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an ENI.
        /// * You can specify private IP addresses and a primary IP when creating an ENI. The specified private IP must be in the same subnet as the ENI and is not occupied.
        /// * When creating an ENI, you can specify the number of private IP addresses that you want to apply for. The system will randomly generate private IP addresses.
        /// * An ENI can only be bound with a limited number of IP addresses. For more information about resource limits, see <a href="/document/product/576/18527">ENI Use Limits</a>.
        /// * You can bind an existing security group when creating an ENI.
        /// * You can bind a tag when creating an ENI. The tag list in the response indicates the tags that have been successfully added.
        /// >?This API is async. You can call the [`DescribeVpcTaskResult`](https://intl.cloud.tencent.com/document/api/215/59037?from_cn_redirect=1) API to query the task result. When the task is completed, you can continue other tasks.
        /// >
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
        /// * You can specify private IP addresses and a primary IP when creating an ENI. The specified private IP must be in the same subnet as the ENI and is not occupied.
        /// * When creating an ENI, you can specify the number of private IP addresses that you want to apply for. The system will randomly generate private IP addresses.
        /// * An ENI can only be bound with a limited number of IP addresses. For more information about resource limits, see <a href="/document/product/576/18527">ENI Use Limits</a>.
        /// * You can bind an existing security group when creating an ENI.
        /// * You can bind a tag when creating an ENI. The tag list in the response indicates the tags that have been successfully added.
        /// >?This API is async. You can call the [`DescribeVpcTaskResult`](https://intl.cloud.tencent.com/document/api/215/59037?from_cn_redirect=1) API to query the task result. When the task is completed, you can continue other tasks.
        /// >
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
        /// This API is used to create a route table.
        /// * After the VPC instance has been created, the system creates a default route table with which all newly created subnets will be associated. By default, you can use this route table to manage your routing policies. If you have multiple routing policies, you can call the API for creating route tables to create more route tables to manage these routing policies.
        /// * You can bind a tag when creating a route table. The tag list in the response indicates the tags that have been successfully added.
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
        /// This API is used to create a route table.
        /// * After the VPC instance has been created, the system creates a default route table with which all newly created subnets will be associated. By default, you can use this route table to manage your routing policies. If you have multiple routing policies, you can call the API for creating route tables to create more route tables to manage these routing policies.
        /// * You can bind a tag when creating a route table. The tag list in the response indicates the tags that have been successfully added.
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
        /// This API (CreateRoutes) is used to create a routing policy.
        /// * You can create routing policies in batch for a specified route table.
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
        /// This API (CreateRoutes) is used to create a routing policy.
        /// * You can create routing policies in batch for a specified route table.
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
        /// This API is used to create a security group (SecurityGroup).
        /// * Note the <a href="https://intl.cloud.tencent.com/document/product/213/12453?from_cn_redirect=1">maximum number of security groups</a> per project in each region under each account.
        /// * Both the inbound and outbound rules for a newly created security group are "Deny All" by default. You need to call CreateSecurityGroupPolicies to set security group rules based on your needs.
        /// * You can bind a tag when creating a security group. The tag list in the response indicates the tags that have been successfully added.
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
        /// This API is used to create a security group (SecurityGroup).
        /// * Note the <a href="https://intl.cloud.tencent.com/document/product/213/12453?from_cn_redirect=1">maximum number of security groups</a> per project in each region under each account.
        /// * Both the inbound and outbound rules for a newly created security group are "Deny All" by default. You need to call CreateSecurityGroupPolicies to set security group rules based on your needs.
        /// * You can bind a tag when creating a security group. The tag list in the response indicates the tags that have been successfully added.
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
        /// This API is used to create security group policies (`SecurityGroupPolicy`).
        /// 
        /// For parameters of `SecurityGroupPolicySet`,
        /// <ul>
        /// <li>`Version`: The version number of a security group policy, which automatically increases by one each time you update the security policy, to prevent expiration of the updated routing policies. If it is left empty, any conflicts will be ignored.</li>
        /// <li>When creating the `Egress` and `Ingress` polices,<ul>
        /// <li>`Protocol`: Allows `TCP`, `UDP`, `ICMP`, `ICMPV6`, `GRE` and `ALL`.</li>
        /// <li>`CidrBlock`: For the classic network, the `CidrBlock` can contain private IPs of Tencent Cloud resources that are not under your account. It does not mean that you can access these devices. The network isolation policies between tenants take priority over the private network policies in security groups.</li>
        /// <li>`Ipv6CidrBlock`: For the classic network, `Ipv6CidrBlock` can contain private IPv6 addresses of Tencent Cloud resources that are not under your account. It does not mean that you can access these devices. The network isolation policies between tenants take priority over the private network policies in security groups.</li>
        /// <li>`SecurityGroupId`: ID of the security group to create policies. </li>
        /// <li>`Port`: A single port (“80”) or a port range ("8000-8010"). This parameter is only available when `Protocol` is `TCP` or `UDP`.</li>
        /// <li>`Action`: `ACCEPT` or `DROP`.</li>
        /// <li><code>CidrBlock</code>, <code>Ipv6CidrBlock</code>, <code>SecurityGroupId</code>, and <code>AddressTemplate</code> are mutually exclusive. <code>Protocol</code> + <code>Port</code> and <code>ServiceTemplate</code> are mutually exclusive. <code>IPv6CidrBlock</code> and <code>ICMP</code> are mutually exclusive; to use them, enter <code>ICMPV6</code>.</li>
        /// <li>You can only create policies in one direction in each request. To specify the `PolicyIndex` parameter, use the same index number in policies. If you want to insert a rule before the first rule, enter 0; if you want to add a rule after the last rule, leave it empty.</li>
        /// </ul></li></ul>
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
        /// This API is used to create security group policies (`SecurityGroupPolicy`).
        /// 
        /// For parameters of `SecurityGroupPolicySet`,
        /// <ul>
        /// <li>`Version`: The version number of a security group policy, which automatically increases by one each time you update the security policy, to prevent expiration of the updated routing policies. If it is left empty, any conflicts will be ignored.</li>
        /// <li>When creating the `Egress` and `Ingress` polices,<ul>
        /// <li>`Protocol`: Allows `TCP`, `UDP`, `ICMP`, `ICMPV6`, `GRE` and `ALL`.</li>
        /// <li>`CidrBlock`: For the classic network, the `CidrBlock` can contain private IPs of Tencent Cloud resources that are not under your account. It does not mean that you can access these devices. The network isolation policies between tenants take priority over the private network policies in security groups.</li>
        /// <li>`Ipv6CidrBlock`: For the classic network, `Ipv6CidrBlock` can contain private IPv6 addresses of Tencent Cloud resources that are not under your account. It does not mean that you can access these devices. The network isolation policies between tenants take priority over the private network policies in security groups.</li>
        /// <li>`SecurityGroupId`: ID of the security group to create policies. </li>
        /// <li>`Port`: A single port (“80”) or a port range ("8000-8010"). This parameter is only available when `Protocol` is `TCP` or `UDP`.</li>
        /// <li>`Action`: `ACCEPT` or `DROP`.</li>
        /// <li><code>CidrBlock</code>, <code>Ipv6CidrBlock</code>, <code>SecurityGroupId</code>, and <code>AddressTemplate</code> are mutually exclusive. <code>Protocol</code> + <code>Port</code> and <code>ServiceTemplate</code> are mutually exclusive. <code>IPv6CidrBlock</code> and <code>ICMP</code> are mutually exclusive; to use them, enter <code>ICMPV6</code>.</li>
        /// <li>You can only create policies in one direction in each request. To specify the `PolicyIndex` parameter, use the same index number in policies. If you want to insert a rule before the first rule, enter 0; if you want to add a rule after the last rule, leave it empty.</li>
        /// </ul></li></ul>
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
        /// This API (CreateSecurityGroupWithPolicies) is used to create security groups, and add security group policies.
        /// * Note the<a href="https://intl.cloud.tencent.com/document/product/213/12453?from_cn_redirect=1">maximum number of security groups</a>per project in each region under each account.
        /// * Both the inbound and outbound policies for a newly created security group are Deny All by default. You need to call CreateSecurityGroupPolicies to set security group policies according to your needs.
        /// 
        /// Description:
        /// * `Version`: Indicates the version number of a security group policy, which will automatically increment by 1 every time you update the security policy, to prevent the expiration of the updated policies. If this field is left empty, any conflicts will be ignored.
        /// * `Protocol`: Values can be TCP, UDP, ICMP, ICMPV6, GRE, or ALL.
        /// * `CidrBlock`:  A CIDR block in the correct format. In a basic network, if a CidrBlock contains private IPs on Tencent Cloud for devices under your account other than CVMs, it does not mean this policy allows you to access these devices. The network isolation policies between tenants take priority over the private network policies in security groups.
        /// * `Ipv6CidrBlock`: An IPv6 CIDR block in the correct format. In a basic network, if an Ipv6CidrBlock contains private IPv6 addresses on Tencent Cloud for devices under your account other than CVMs, it does not mean this policy allows you to access these devices. The network isolation policies between tenants take priority over the private network policies in security groups.
        /// * `SecurityGroupId`: ID of the security group. It can be in the same project as the security group to be modified, including the ID of the security group itself, to represent private IP addresses of all CVMs under the security group. If this field is used, the policy will change without manual modification according to the CVM associated with the policy ID while being used to match network messages.
        /// * `Port`: A single port number, or a port range in the format of “8000-8010”. The Port field is accepted only if the value of the `Protocol` field is `TCP` or `UDP`. Otherwise Protocol and Port are mutually exclusive. 
        /// * `Action`: Values can be `ACCEPT` or `DROP`.
        /// * CidrBlock, Ipv6CidrBlock, SecurityGroupId, and AddressTemplate are exclusive and cannot be entered at the same time. “Protocol + Port” and ServiceTemplate are mutually exclusive and cannot be entered at the same time.
        /// * Only policies in one direction can be created in each request. If you need to specify the `PolicyIndex` parameter, the indexes of policies must be consistent.
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityGroupWithPoliciesRequest"/></param>
        /// <returns><see cref="CreateSecurityGroupWithPoliciesResponse"/></returns>
        public async Task<CreateSecurityGroupWithPoliciesResponse> CreateSecurityGroupWithPolicies(CreateSecurityGroupWithPoliciesRequest req)
        {
             JsonResponseModel<CreateSecurityGroupWithPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSecurityGroupWithPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSecurityGroupWithPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateSecurityGroupWithPolicies) is used to create security groups, and add security group policies.
        /// * Note the<a href="https://intl.cloud.tencent.com/document/product/213/12453?from_cn_redirect=1">maximum number of security groups</a>per project in each region under each account.
        /// * Both the inbound and outbound policies for a newly created security group are Deny All by default. You need to call CreateSecurityGroupPolicies to set security group policies according to your needs.
        /// 
        /// Description:
        /// * `Version`: Indicates the version number of a security group policy, which will automatically increment by 1 every time you update the security policy, to prevent the expiration of the updated policies. If this field is left empty, any conflicts will be ignored.
        /// * `Protocol`: Values can be TCP, UDP, ICMP, ICMPV6, GRE, or ALL.
        /// * `CidrBlock`:  A CIDR block in the correct format. In a basic network, if a CidrBlock contains private IPs on Tencent Cloud for devices under your account other than CVMs, it does not mean this policy allows you to access these devices. The network isolation policies between tenants take priority over the private network policies in security groups.
        /// * `Ipv6CidrBlock`: An IPv6 CIDR block in the correct format. In a basic network, if an Ipv6CidrBlock contains private IPv6 addresses on Tencent Cloud for devices under your account other than CVMs, it does not mean this policy allows you to access these devices. The network isolation policies between tenants take priority over the private network policies in security groups.
        /// * `SecurityGroupId`: ID of the security group. It can be in the same project as the security group to be modified, including the ID of the security group itself, to represent private IP addresses of all CVMs under the security group. If this field is used, the policy will change without manual modification according to the CVM associated with the policy ID while being used to match network messages.
        /// * `Port`: A single port number, or a port range in the format of “8000-8010”. The Port field is accepted only if the value of the `Protocol` field is `TCP` or `UDP`. Otherwise Protocol and Port are mutually exclusive. 
        /// * `Action`: Values can be `ACCEPT` or `DROP`.
        /// * CidrBlock, Ipv6CidrBlock, SecurityGroupId, and AddressTemplate are exclusive and cannot be entered at the same time. “Protocol + Port” and ServiceTemplate are mutually exclusive and cannot be entered at the same time.
        /// * Only policies in one direction can be created in each request. If you need to specify the `PolicyIndex` parameter, the indexes of policies must be consistent.
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityGroupWithPoliciesRequest"/></param>
        /// <returns><see cref="CreateSecurityGroupWithPoliciesResponse"/></returns>
        public CreateSecurityGroupWithPoliciesResponse CreateSecurityGroupWithPoliciesSync(CreateSecurityGroupWithPoliciesRequest req)
        {
             JsonResponseModel<CreateSecurityGroupWithPoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSecurityGroupWithPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSecurityGroupWithPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateServiceTemplate) is used to create a protocol port template.
        /// </summary>
        /// <param name="req"><see cref="CreateServiceTemplateRequest"/></param>
        /// <returns><see cref="CreateServiceTemplateResponse"/></returns>
        public async Task<CreateServiceTemplateResponse> CreateServiceTemplate(CreateServiceTemplateRequest req)
        {
             JsonResponseModel<CreateServiceTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateServiceTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateServiceTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateServiceTemplate) is used to create a protocol port template.
        /// </summary>
        /// <param name="req"><see cref="CreateServiceTemplateRequest"/></param>
        /// <returns><see cref="CreateServiceTemplateResponse"/></returns>
        public CreateServiceTemplateResponse CreateServiceTemplateSync(CreateServiceTemplateRequest req)
        {
             JsonResponseModel<CreateServiceTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateServiceTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateServiceTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateServiceTemplateGroup) is used to create a protocol port template group.
        /// </summary>
        /// <param name="req"><see cref="CreateServiceTemplateGroupRequest"/></param>
        /// <returns><see cref="CreateServiceTemplateGroupResponse"/></returns>
        public async Task<CreateServiceTemplateGroupResponse> CreateServiceTemplateGroup(CreateServiceTemplateGroupRequest req)
        {
             JsonResponseModel<CreateServiceTemplateGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateServiceTemplateGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateServiceTemplateGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateServiceTemplateGroup) is used to create a protocol port template group.
        /// </summary>
        /// <param name="req"><see cref="CreateServiceTemplateGroupRequest"/></param>
        /// <returns><see cref="CreateServiceTemplateGroupResponse"/></returns>
        public CreateServiceTemplateGroupResponse CreateServiceTemplateGroupSync(CreateServiceTemplateGroupRequest req)
        {
             JsonResponseModel<CreateServiceTemplateGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateServiceTemplateGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateServiceTemplateGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create snapshot policies.
        /// </summary>
        /// <param name="req"><see cref="CreateSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="CreateSnapshotPoliciesResponse"/></returns>
        public async Task<CreateSnapshotPoliciesResponse> CreateSnapshotPolicies(CreateSnapshotPoliciesRequest req)
        {
             JsonResponseModel<CreateSnapshotPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSnapshotPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSnapshotPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create snapshot policies.
        /// </summary>
        /// <param name="req"><see cref="CreateSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="CreateSnapshotPoliciesResponse"/></returns>
        public CreateSnapshotPoliciesResponse CreateSnapshotPoliciesSync(CreateSnapshotPoliciesRequest req)
        {
             JsonResponseModel<CreateSnapshotPoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSnapshotPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSnapshotPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a subnet.
        /// * You must create a VPC instance before creating a subnet.
        /// * After the subnet is successfully created, its IP address range cannot be modified. The subnet IP address range must fall within the VPC IP address range. They can be the same if the VPC instance has only one subnet. We recommend that you keep the subnet IP address range within the VPC IP address range to reserve IP address ranges for other subnets.
        /// * The subnet mask of the smallest IP address range that can be created is 28 (16 IP addresses), and that of the largest IP address range is 16 (65,536 IP addresses).
        /// * IP address ranges of different subnets cannot overlap with each other within the same VPC instance.
        /// * A subnet is automatically associated with the default route table once created.
        /// * You can bind a tag when creating a subnet. The tag list in the response indicates the tags that have been successfully added.
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
        /// This API is used to create a subnet.
        /// * You must create a VPC instance before creating a subnet.
        /// * After the subnet is successfully created, its IP address range cannot be modified. The subnet IP address range must fall within the VPC IP address range. They can be the same if the VPC instance has only one subnet. We recommend that you keep the subnet IP address range within the VPC IP address range to reserve IP address ranges for other subnets.
        /// * The subnet mask of the smallest IP address range that can be created is 28 (16 IP addresses), and that of the largest IP address range is 16 (65,536 IP addresses).
        /// * IP address ranges of different subnets cannot overlap with each other within the same VPC instance.
        /// * A subnet is automatically associated with the default route table once created.
        /// * You can bind a tag when creating a subnet. The tag list in the response indicates the tags that have been successfully added.
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
        /// This API is used to create subnets in batches.
        /// * You must create a VPC instance before creating a subnet.
        /// * After the subnet is successfully created, its IP address range cannot be modified. The subnet IP address range must fall within the VPC IP address range. They can be the same if the VPC has only one subnet. We recommend that you keep the subnet IP address range within the VPC IP address range to reserve IP address ranges for other subnets.
        /// * The subnet mask of the smallest IP address range that can be created is 28 (16 IP addresses), and that of the largest IP address range is 16 (65,536 IP addresses).
        /// * IP address ranges of different subnets cannot overlap with each other within the same VPC instance.
        /// * A subnet is automatically associated with the default route table once created.
        /// * You can bind a tag when creating a subnet. The tag list in the response indicates the tags that have been successfully added.
        /// </summary>
        /// <param name="req"><see cref="CreateSubnetsRequest"/></param>
        /// <returns><see cref="CreateSubnetsResponse"/></returns>
        public async Task<CreateSubnetsResponse> CreateSubnets(CreateSubnetsRequest req)
        {
             JsonResponseModel<CreateSubnetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSubnets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSubnetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create subnets in batches.
        /// * You must create a VPC instance before creating a subnet.
        /// * After the subnet is successfully created, its IP address range cannot be modified. The subnet IP address range must fall within the VPC IP address range. They can be the same if the VPC has only one subnet. We recommend that you keep the subnet IP address range within the VPC IP address range to reserve IP address ranges for other subnets.
        /// * The subnet mask of the smallest IP address range that can be created is 28 (16 IP addresses), and that of the largest IP address range is 16 (65,536 IP addresses).
        /// * IP address ranges of different subnets cannot overlap with each other within the same VPC instance.
        /// * A subnet is automatically associated with the default route table once created.
        /// * You can bind a tag when creating a subnet. The tag list in the response indicates the tags that have been successfully added.
        /// </summary>
        /// <param name="req"><see cref="CreateSubnetsRequest"/></param>
        /// <returns><see cref="CreateSubnetsResponse"/></returns>
        public CreateSubnetsResponse CreateSubnetsSync(CreateSubnetsRequest req)
        {
             JsonResponseModel<CreateSubnetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSubnets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSubnetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a VPC instance.
        /// * The subnet mask of the smallest IP address range that can be created is 28 (16 IP addresses), that of the largest IP address ranges 10.0.0.0/12 and 172.16.0.0/12 is 12 (1,048,576 IP addresses), and that of the largest IP address range 192.168.0.0/16 is 16 (65,536 IP addresses). For more information on how to plan VPC IP ranges, see [Network Planning](https://intl.cloud.tencent.com/document/product/215/30313?from_cn_redirect=1).
        /// * The number of VPC instances that can be created in a region is limited. For more information, see <a href="https://intl.cloud.tencent.com/doc/product/215/537?from_cn_redirect=1" title="VPC Use Limits">VPC Use Limits</a>. To request more resources, [submit a ticket](https://console.cloud.tencent.com/workorder/category).
        /// * You can bind tags when creating a VPC instance. The tag list in the response indicates the tags that have been successfully added.
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
        /// This API is used to create a VPC instance.
        /// * The subnet mask of the smallest IP address range that can be created is 28 (16 IP addresses), that of the largest IP address ranges 10.0.0.0/12 and 172.16.0.0/12 is 12 (1,048,576 IP addresses), and that of the largest IP address range 192.168.0.0/16 is 16 (65,536 IP addresses). For more information on how to plan VPC IP ranges, see [Network Planning](https://intl.cloud.tencent.com/document/product/215/30313?from_cn_redirect=1).
        /// * The number of VPC instances that can be created in a region is limited. For more information, see <a href="https://intl.cloud.tencent.com/doc/product/215/537?from_cn_redirect=1" title="VPC Use Limits">VPC Use Limits</a>. To request more resources, [submit a ticket](https://console.cloud.tencent.com/workorder/category).
        /// * You can bind tags when creating a VPC instance. The tag list in the response indicates the tags that have been successfully added.
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
        /// This API is used to create an endpoint.
        /// </summary>
        /// <param name="req"><see cref="CreateVpcEndPointRequest"/></param>
        /// <returns><see cref="CreateVpcEndPointResponse"/></returns>
        public async Task<CreateVpcEndPointResponse> CreateVpcEndPoint(CreateVpcEndPointRequest req)
        {
             JsonResponseModel<CreateVpcEndPointResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateVpcEndPoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVpcEndPointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an endpoint.
        /// </summary>
        /// <param name="req"><see cref="CreateVpcEndPointRequest"/></param>
        /// <returns><see cref="CreateVpcEndPointResponse"/></returns>
        public CreateVpcEndPointResponse CreateVpcEndPointSync(CreateVpcEndPointRequest req)
        {
             JsonResponseModel<CreateVpcEndPointResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateVpcEndPoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVpcEndPointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an endpoint service.
        /// </summary>
        /// <param name="req"><see cref="CreateVpcEndPointServiceRequest"/></param>
        /// <returns><see cref="CreateVpcEndPointServiceResponse"/></returns>
        public async Task<CreateVpcEndPointServiceResponse> CreateVpcEndPointService(CreateVpcEndPointServiceRequest req)
        {
             JsonResponseModel<CreateVpcEndPointServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateVpcEndPointService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVpcEndPointServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an endpoint service.
        /// </summary>
        /// <param name="req"><see cref="CreateVpcEndPointServiceRequest"/></param>
        /// <returns><see cref="CreateVpcEndPointServiceResponse"/></returns>
        public CreateVpcEndPointServiceResponse CreateVpcEndPointServiceSync(CreateVpcEndPointServiceRequest req)
        {
             JsonResponseModel<CreateVpcEndPointServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateVpcEndPointService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVpcEndPointServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create the endpoint service allowlist.
        /// </summary>
        /// <param name="req"><see cref="CreateVpcEndPointServiceWhiteListRequest"/></param>
        /// <returns><see cref="CreateVpcEndPointServiceWhiteListResponse"/></returns>
        public async Task<CreateVpcEndPointServiceWhiteListResponse> CreateVpcEndPointServiceWhiteList(CreateVpcEndPointServiceWhiteListRequest req)
        {
             JsonResponseModel<CreateVpcEndPointServiceWhiteListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateVpcEndPointServiceWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVpcEndPointServiceWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create the endpoint service allowlist.
        /// </summary>
        /// <param name="req"><see cref="CreateVpcEndPointServiceWhiteListRequest"/></param>
        /// <returns><see cref="CreateVpcEndPointServiceWhiteListResponse"/></returns>
        public CreateVpcEndPointServiceWhiteListResponse CreateVpcEndPointServiceWhiteListSync(CreateVpcEndPointServiceWhiteListRequest req)
        {
             JsonResponseModel<CreateVpcEndPointServiceWhiteListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateVpcEndPointServiceWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVpcEndPointServiceWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a VPN tunnel.
        /// >?This API is async. You can call the [`DescribeVpcTaskResult`](https://intl.cloud.tencent.com/document/api/215/59037?from_cn_redirect=1) API to query the task result. When the task is completed, you can continue other tasks.
        /// >
        /// </summary>
        /// <param name="req"><see cref="CreateVpnConnectionRequest"/></param>
        /// <returns><see cref="CreateVpnConnectionResponse"/></returns>
        public async Task<CreateVpnConnectionResponse> CreateVpnConnection(CreateVpnConnectionRequest req)
        {
             JsonResponseModel<CreateVpnConnectionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateVpnConnection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVpnConnectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a VPN tunnel.
        /// >?This API is async. You can call the [`DescribeVpcTaskResult`](https://intl.cloud.tencent.com/document/api/215/59037?from_cn_redirect=1) API to query the task result. When the task is completed, you can continue other tasks.
        /// >
        /// </summary>
        /// <param name="req"><see cref="CreateVpnConnectionRequest"/></param>
        /// <returns><see cref="CreateVpnConnectionResponse"/></returns>
        public CreateVpnConnectionResponse CreateVpnConnectionSync(CreateVpnConnectionRequest req)
        {
             JsonResponseModel<CreateVpnConnectionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateVpnConnection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVpnConnectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateVpnGateway) is used to create a VPN gateway.
        /// </summary>
        /// <param name="req"><see cref="CreateVpnGatewayRequest"/></param>
        /// <returns><see cref="CreateVpnGatewayResponse"/></returns>
        public async Task<CreateVpnGatewayResponse> CreateVpnGateway(CreateVpnGatewayRequest req)
        {
             JsonResponseModel<CreateVpnGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateVpnGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVpnGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateVpnGateway) is used to create a VPN gateway.
        /// </summary>
        /// <param name="req"><see cref="CreateVpnGatewayRequest"/></param>
        /// <returns><see cref="CreateVpnGatewayResponse"/></returns>
        public CreateVpnGatewayResponse CreateVpnGatewaySync(CreateVpnGatewayRequest req)
        {
             JsonResponseModel<CreateVpnGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateVpnGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVpnGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create destination routes of a route-based VPN gateway.
        /// </summary>
        /// <param name="req"><see cref="CreateVpnGatewayRoutesRequest"/></param>
        /// <returns><see cref="CreateVpnGatewayRoutesResponse"/></returns>
        public async Task<CreateVpnGatewayRoutesResponse> CreateVpnGatewayRoutes(CreateVpnGatewayRoutesRequest req)
        {
             JsonResponseModel<CreateVpnGatewayRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateVpnGatewayRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVpnGatewayRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create destination routes of a route-based VPN gateway.
        /// </summary>
        /// <param name="req"><see cref="CreateVpnGatewayRoutesRequest"/></param>
        /// <returns><see cref="CreateVpnGatewayRoutesResponse"/></returns>
        public CreateVpnGatewayRoutesResponse CreateVpnGatewayRoutesSync(CreateVpnGatewayRoutesRequest req)
        {
             JsonResponseModel<CreateVpnGatewayRoutesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateVpnGatewayRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVpnGatewayRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteAddressTemplate) is used to delete an IP address template.
        /// </summary>
        /// <param name="req"><see cref="DeleteAddressTemplateRequest"/></param>
        /// <returns><see cref="DeleteAddressTemplateResponse"/></returns>
        public async Task<DeleteAddressTemplateResponse> DeleteAddressTemplate(DeleteAddressTemplateRequest req)
        {
             JsonResponseModel<DeleteAddressTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAddressTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAddressTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteAddressTemplate) is used to delete an IP address template.
        /// </summary>
        /// <param name="req"><see cref="DeleteAddressTemplateRequest"/></param>
        /// <returns><see cref="DeleteAddressTemplateResponse"/></returns>
        public DeleteAddressTemplateResponse DeleteAddressTemplateSync(DeleteAddressTemplateRequest req)
        {
             JsonResponseModel<DeleteAddressTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAddressTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAddressTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteAddressTemplateGroup) is used to delete an IP address template group.
        /// </summary>
        /// <param name="req"><see cref="DeleteAddressTemplateGroupRequest"/></param>
        /// <returns><see cref="DeleteAddressTemplateGroupResponse"/></returns>
        public async Task<DeleteAddressTemplateGroupResponse> DeleteAddressTemplateGroup(DeleteAddressTemplateGroupRequest req)
        {
             JsonResponseModel<DeleteAddressTemplateGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAddressTemplateGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAddressTemplateGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteAddressTemplateGroup) is used to delete an IP address template group.
        /// </summary>
        /// <param name="req"><see cref="DeleteAddressTemplateGroupRequest"/></param>
        /// <returns><see cref="DeleteAddressTemplateGroupResponse"/></returns>
        public DeleteAddressTemplateGroupResponse DeleteAddressTemplateGroupSync(DeleteAddressTemplateGroupRequest req)
        {
             JsonResponseModel<DeleteAddressTemplateGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAddressTemplateGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAddressTemplateGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a secondary CIDR block.
        /// </summary>
        /// <param name="req"><see cref="DeleteAssistantCidrRequest"/></param>
        /// <returns><see cref="DeleteAssistantCidrResponse"/></returns>
        public async Task<DeleteAssistantCidrResponse> DeleteAssistantCidr(DeleteAssistantCidrRequest req)
        {
             JsonResponseModel<DeleteAssistantCidrResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAssistantCidr");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAssistantCidrResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a secondary CIDR block.
        /// </summary>
        /// <param name="req"><see cref="DeleteAssistantCidrRequest"/></param>
        /// <returns><see cref="DeleteAssistantCidrResponse"/></returns>
        public DeleteAssistantCidrResponse DeleteAssistantCidrSync(DeleteAssistantCidrRequest req)
        {
             JsonResponseModel<DeleteAssistantCidrResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAssistantCidr");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAssistantCidrResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete bandwidth packages, including [device bandwidth packages](https://intl.cloud.tencent.com/document/product/684/15246?from_cn_redirect=1#.E8.AE.BE.E5.A4.87.E5.B8.A6.E5.AE.BD.E5.8C.85) and [IP bandwidth packages](https://intl.cloud.tencent.com/document/product/684/15246?from_cn_redirect=1#ip-.E5.B8.A6.E5.AE.BD.E5.8C.85).
        /// </summary>
        /// <param name="req"><see cref="DeleteBandwidthPackageRequest"/></param>
        /// <returns><see cref="DeleteBandwidthPackageResponse"/></returns>
        public async Task<DeleteBandwidthPackageResponse> DeleteBandwidthPackage(DeleteBandwidthPackageRequest req)
        {
             JsonResponseModel<DeleteBandwidthPackageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteBandwidthPackage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBandwidthPackageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete bandwidth packages, including [device bandwidth packages](https://intl.cloud.tencent.com/document/product/684/15246?from_cn_redirect=1#.E8.AE.BE.E5.A4.87.E5.B8.A6.E5.AE.BD.E5.8C.85) and [IP bandwidth packages](https://intl.cloud.tencent.com/document/product/684/15246?from_cn_redirect=1#ip-.E5.B8.A6.E5.AE.BD.E5.8C.85).
        /// </summary>
        /// <param name="req"><see cref="DeleteBandwidthPackageRequest"/></param>
        /// <returns><see cref="DeleteBandwidthPackageResponse"/></returns>
        public DeleteBandwidthPackageResponse DeleteBandwidthPackageSync(DeleteBandwidthPackageRequest req)
        {
             JsonResponseModel<DeleteBandwidthPackageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteBandwidthPackage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBandwidthPackageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteCcn) is used to delete CCNs.
        /// * After deletion, the routes between all instances associated with the CCN will be deleted, and the network will be interrupted. Please confirm this operation in advance.
        /// * CCN deletion is an irreversible operation. Please proceed with caution.
        /// </summary>
        /// <param name="req"><see cref="DeleteCcnRequest"/></param>
        /// <returns><see cref="DeleteCcnResponse"/></returns>
        public async Task<DeleteCcnResponse> DeleteCcn(DeleteCcnRequest req)
        {
             JsonResponseModel<DeleteCcnResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCcn");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCcnResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteCcn) is used to delete CCNs.
        /// * After deletion, the routes between all instances associated with the CCN will be deleted, and the network will be interrupted. Please confirm this operation in advance.
        /// * CCN deletion is an irreversible operation. Please proceed with caution.
        /// </summary>
        /// <param name="req"><see cref="DeleteCcnRequest"/></param>
        /// <returns><see cref="DeleteCcnResponse"/></returns>
        public DeleteCcnResponse DeleteCcnSync(DeleteCcnRequest req)
        {
             JsonResponseModel<DeleteCcnResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCcn");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCcnResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteCustomerGateway) is used to delete customer gateways.
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomerGatewayRequest"/></param>
        /// <returns><see cref="DeleteCustomerGatewayResponse"/></returns>
        public async Task<DeleteCustomerGatewayResponse> DeleteCustomerGateway(DeleteCustomerGatewayRequest req)
        {
             JsonResponseModel<DeleteCustomerGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCustomerGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCustomerGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteCustomerGateway) is used to delete customer gateways.
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomerGatewayRequest"/></param>
        /// <returns><see cref="DeleteCustomerGatewayResponse"/></returns>
        public DeleteCustomerGatewayResponse DeleteCustomerGatewaySync(DeleteCustomerGatewayRequest req)
        {
             JsonResponseModel<DeleteCustomerGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCustomerGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCustomerGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a direct connect gateway.
        /// <li>For a NAT gateway, NAT and ACL rules will be cleared upon the deletion of a direct connect gateway.
        /// <li>After the deletion of a direct connect gateway, the routing policy associated with the gateway in the route table will also be deleted.
        /// This API is completed asynchronously. If you need to query the async job execution results, please use the `RequestId` returned by this API to poll the `QueryTask` API.
        /// </summary>
        /// <param name="req"><see cref="DeleteDirectConnectGatewayRequest"/></param>
        /// <returns><see cref="DeleteDirectConnectGatewayResponse"/></returns>
        public async Task<DeleteDirectConnectGatewayResponse> DeleteDirectConnectGateway(DeleteDirectConnectGatewayRequest req)
        {
             JsonResponseModel<DeleteDirectConnectGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDirectConnectGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDirectConnectGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a direct connect gateway.
        /// <li>For a NAT gateway, NAT and ACL rules will be cleared upon the deletion of a direct connect gateway.
        /// <li>After the deletion of a direct connect gateway, the routing policy associated with the gateway in the route table will also be deleted.
        /// This API is completed asynchronously. If you need to query the async job execution results, please use the `RequestId` returned by this API to poll the `QueryTask` API.
        /// </summary>
        /// <param name="req"><see cref="DeleteDirectConnectGatewayRequest"/></param>
        /// <returns><see cref="DeleteDirectConnectGatewayResponse"/></returns>
        public DeleteDirectConnectGatewayResponse DeleteDirectConnectGatewaySync(DeleteDirectConnectGatewayRequest req)
        {
             JsonResponseModel<DeleteDirectConnectGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDirectConnectGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDirectConnectGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteDirectConnectGatewayCcnRoutes) is used to delete the CCN routes (IDC IP range) of a Direct Connect gateway.
        /// </summary>
        /// <param name="req"><see cref="DeleteDirectConnectGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="DeleteDirectConnectGatewayCcnRoutesResponse"/></returns>
        public async Task<DeleteDirectConnectGatewayCcnRoutesResponse> DeleteDirectConnectGatewayCcnRoutes(DeleteDirectConnectGatewayCcnRoutesRequest req)
        {
             JsonResponseModel<DeleteDirectConnectGatewayCcnRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDirectConnectGatewayCcnRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDirectConnectGatewayCcnRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteDirectConnectGatewayCcnRoutes) is used to delete the CCN routes (IDC IP range) of a Direct Connect gateway.
        /// </summary>
        /// <param name="req"><see cref="DeleteDirectConnectGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="DeleteDirectConnectGatewayCcnRoutesResponse"/></returns>
        public DeleteDirectConnectGatewayCcnRoutesResponse DeleteDirectConnectGatewayCcnRoutesSync(DeleteDirectConnectGatewayCcnRoutesRequest req)
        {
             JsonResponseModel<DeleteDirectConnectGatewayCcnRoutesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDirectConnectGatewayCcnRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDirectConnectGatewayCcnRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a flow log.
        /// </summary>
        /// <param name="req"><see cref="DeleteFlowLogRequest"/></param>
        /// <returns><see cref="DeleteFlowLogResponse"/></returns>
        public async Task<DeleteFlowLogResponse> DeleteFlowLog(DeleteFlowLogRequest req)
        {
             JsonResponseModel<DeleteFlowLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteFlowLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteFlowLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a flow log.
        /// </summary>
        /// <param name="req"><see cref="DeleteFlowLogRequest"/></param>
        /// <returns><see cref="DeleteFlowLogResponse"/></returns>
        public DeleteFlowLogResponse DeleteFlowLogSync(DeleteFlowLogRequest req)
        {
             JsonResponseModel<DeleteFlowLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteFlowLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteFlowLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an HAVIP. <br />
        /// This API is completed asynchronously. If you need to query the execution result of an async task, please use the `RequestId` returned by this API to poll the `DescribeVpcTaskResult` API.
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
        /// This API is used to delete an HAVIP. <br />
        /// This API is completed asynchronously. If you need to query the execution result of an async task, please use the `RequestId` returned by this API to poll the `DescribeVpcTaskResult` API.
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
        /// This API is used to delete the local gateway of a CDC instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteLocalGatewayRequest"/></param>
        /// <returns><see cref="DeleteLocalGatewayResponse"/></returns>
        public async Task<DeleteLocalGatewayResponse> DeleteLocalGateway(DeleteLocalGatewayRequest req)
        {
             JsonResponseModel<DeleteLocalGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLocalGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLocalGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete the local gateway of a CDC instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteLocalGatewayRequest"/></param>
        /// <returns><see cref="DeleteLocalGatewayResponse"/></returns>
        public DeleteLocalGatewayResponse DeleteLocalGatewaySync(DeleteLocalGatewayRequest req)
        {
             JsonResponseModel<DeleteLocalGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLocalGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLocalGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a NAT gateway.
        /// When a NAT gateway is deleted, all routes containing this gateway are deleted automatically, and the elastic IP is unbound.
        /// </summary>
        /// <param name="req"><see cref="DeleteNatGatewayRequest"/></param>
        /// <returns><see cref="DeleteNatGatewayResponse"/></returns>
        public async Task<DeleteNatGatewayResponse> DeleteNatGateway(DeleteNatGatewayRequest req)
        {
             JsonResponseModel<DeleteNatGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteNatGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNatGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a NAT gateway.
        /// When a NAT gateway is deleted, all routes containing this gateway are deleted automatically, and the elastic IP is unbound.
        /// </summary>
        /// <param name="req"><see cref="DeleteNatGatewayRequest"/></param>
        /// <returns><see cref="DeleteNatGatewayResponse"/></returns>
        public DeleteNatGatewayResponse DeleteNatGatewaySync(DeleteNatGatewayRequest req)
        {
             JsonResponseModel<DeleteNatGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteNatGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNatGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete the port forwarding rule of a NAT gateway.
        /// </summary>
        /// <param name="req"><see cref="DeleteNatGatewayDestinationIpPortTranslationNatRuleRequest"/></param>
        /// <returns><see cref="DeleteNatGatewayDestinationIpPortTranslationNatRuleResponse"/></returns>
        public async Task<DeleteNatGatewayDestinationIpPortTranslationNatRuleResponse> DeleteNatGatewayDestinationIpPortTranslationNatRule(DeleteNatGatewayDestinationIpPortTranslationNatRuleRequest req)
        {
             JsonResponseModel<DeleteNatGatewayDestinationIpPortTranslationNatRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteNatGatewayDestinationIpPortTranslationNatRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNatGatewayDestinationIpPortTranslationNatRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete the port forwarding rule of a NAT gateway.
        /// </summary>
        /// <param name="req"><see cref="DeleteNatGatewayDestinationIpPortTranslationNatRuleRequest"/></param>
        /// <returns><see cref="DeleteNatGatewayDestinationIpPortTranslationNatRuleResponse"/></returns>
        public DeleteNatGatewayDestinationIpPortTranslationNatRuleResponse DeleteNatGatewayDestinationIpPortTranslationNatRuleSync(DeleteNatGatewayDestinationIpPortTranslationNatRuleRequest req)
        {
             JsonResponseModel<DeleteNatGatewayDestinationIpPortTranslationNatRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteNatGatewayDestinationIpPortTranslationNatRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNatGatewayDestinationIpPortTranslationNatRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a SNAT forwarding rule of a NAT gateway.
        /// </summary>
        /// <param name="req"><see cref="DeleteNatGatewaySourceIpTranslationNatRuleRequest"/></param>
        /// <returns><see cref="DeleteNatGatewaySourceIpTranslationNatRuleResponse"/></returns>
        public async Task<DeleteNatGatewaySourceIpTranslationNatRuleResponse> DeleteNatGatewaySourceIpTranslationNatRule(DeleteNatGatewaySourceIpTranslationNatRuleRequest req)
        {
             JsonResponseModel<DeleteNatGatewaySourceIpTranslationNatRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteNatGatewaySourceIpTranslationNatRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNatGatewaySourceIpTranslationNatRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a SNAT forwarding rule of a NAT gateway.
        /// </summary>
        /// <param name="req"><see cref="DeleteNatGatewaySourceIpTranslationNatRuleRequest"/></param>
        /// <returns><see cref="DeleteNatGatewaySourceIpTranslationNatRuleResponse"/></returns>
        public DeleteNatGatewaySourceIpTranslationNatRuleResponse DeleteNatGatewaySourceIpTranslationNatRuleSync(DeleteNatGatewaySourceIpTranslationNatRuleRequest req)
        {
             JsonResponseModel<DeleteNatGatewaySourceIpTranslationNatRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteNatGatewaySourceIpTranslationNatRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNatGatewaySourceIpTranslationNatRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteNetDetect) is used to delete a network detection instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteNetDetectRequest"/></param>
        /// <returns><see cref="DeleteNetDetectResponse"/></returns>
        public async Task<DeleteNetDetectResponse> DeleteNetDetect(DeleteNetDetectRequest req)
        {
             JsonResponseModel<DeleteNetDetectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteNetDetect");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNetDetectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteNetDetect) is used to delete a network detection instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteNetDetectRequest"/></param>
        /// <returns><see cref="DeleteNetDetectResponse"/></returns>
        public DeleteNetDetectResponse DeleteNetDetectSync(DeleteNetDetectRequest req)
        {
             JsonResponseModel<DeleteNetDetectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteNetDetect");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNetDetectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a network ACL.
        /// </summary>
        /// <param name="req"><see cref="DeleteNetworkAclRequest"/></param>
        /// <returns><see cref="DeleteNetworkAclResponse"/></returns>
        public async Task<DeleteNetworkAclResponse> DeleteNetworkAcl(DeleteNetworkAclRequest req)
        {
             JsonResponseModel<DeleteNetworkAclResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteNetworkAcl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNetworkAclResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a network ACL.
        /// </summary>
        /// <param name="req"><see cref="DeleteNetworkAclRequest"/></param>
        /// <returns><see cref="DeleteNetworkAclResponse"/></returns>
        public DeleteNetworkAclResponse DeleteNetworkAclSync(DeleteNetworkAclRequest req)
        {
             JsonResponseModel<DeleteNetworkAclResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteNetworkAcl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNetworkAclResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete specified in/outbound rules of the network ACL quintuple. In the `NetworkAclQuintupleEntrySet` parameters, `NetworkAclQuintupleEntryId` is required for `NetworkAclQuintupleEntry`.
        /// </summary>
        /// <param name="req"><see cref="DeleteNetworkAclQuintupleEntriesRequest"/></param>
        /// <returns><see cref="DeleteNetworkAclQuintupleEntriesResponse"/></returns>
        public async Task<DeleteNetworkAclQuintupleEntriesResponse> DeleteNetworkAclQuintupleEntries(DeleteNetworkAclQuintupleEntriesRequest req)
        {
             JsonResponseModel<DeleteNetworkAclQuintupleEntriesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteNetworkAclQuintupleEntries");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNetworkAclQuintupleEntriesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete specified in/outbound rules of the network ACL quintuple. In the `NetworkAclQuintupleEntrySet` parameters, `NetworkAclQuintupleEntryId` is required for `NetworkAclQuintupleEntry`.
        /// </summary>
        /// <param name="req"><see cref="DeleteNetworkAclQuintupleEntriesRequest"/></param>
        /// <returns><see cref="DeleteNetworkAclQuintupleEntriesResponse"/></returns>
        public DeleteNetworkAclQuintupleEntriesResponse DeleteNetworkAclQuintupleEntriesSync(DeleteNetworkAclQuintupleEntriesRequest req)
        {
             JsonResponseModel<DeleteNetworkAclQuintupleEntriesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteNetworkAclQuintupleEntries");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNetworkAclQuintupleEntriesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an ENI.
        /// * An ENI cannot be deleted when it’s bound to a CVM.
        ///  * After the deletion, all of its private IP addresses will be released.
        /// 
        /// This API is completed asynchronously. If you need to query the execution result of an async task, please use the `RequestId` returned by this API to poll the `DescribeVpcTaskResult` API.
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
        /// * An ENI cannot be deleted when it’s bound to a CVM.
        ///  * After the deletion, all of its private IP addresses will be released.
        /// 
        /// This API is completed asynchronously. If you need to query the execution result of an async task, please use the `RequestId` returned by this API to poll the `DescribeVpcTaskResult` API.
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
        /// This API (DeleteRoutes) is used to delete routing policies in batches from a route table.
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
        /// This API (DeleteRoutes) is used to delete routing policies in batches from a route table.
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
        /// This API (DeleteSecurityGroup) is used to delete security groups (SecurityGroup).
        /// * Only security groups under the current account can be deleted.
        /// * A security group cannot be deleted directly if its instance ID is used in the policy of another security group. You need to modify the policy first and then delete the security group.
        /// * A security group cannot be recovered after deletion, please proceed with caution.
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
        /// This API (DeleteSecurityGroup) is used to delete security groups (SecurityGroup).
        /// * Only security groups under the current account can be deleted.
        /// * A security group cannot be deleted directly if its instance ID is used in the policy of another security group. You need to modify the policy first and then delete the security group.
        /// * A security group cannot be recovered after deletion, please proceed with caution.
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
        /// This API (DeleteSecurityGroupPolicies) is used to delete security group policies (SecurityGroupPolicy).
        /// * SecurityGroupPolicySet.Version is used to specify the version of the security group you are operating. If the specified Version number differs from the latest version of the current security group, a failure will be returned. If Version is not specified, the policy of the specified PolicyIndex will be deleted directly.
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
        /// This API (DeleteSecurityGroupPolicies) is used to delete security group policies (SecurityGroupPolicy).
        /// * SecurityGroupPolicySet.Version is used to specify the version of the security group you are operating. If the specified Version number differs from the latest version of the current security group, a failure will be returned. If Version is not specified, the policy of the specified PolicyIndex will be deleted directly.
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
        /// This API (DeleteServiceTemplate) is used to delete a protocol port template.
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceTemplateRequest"/></param>
        /// <returns><see cref="DeleteServiceTemplateResponse"/></returns>
        public async Task<DeleteServiceTemplateResponse> DeleteServiceTemplate(DeleteServiceTemplateRequest req)
        {
             JsonResponseModel<DeleteServiceTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteServiceTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteServiceTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteServiceTemplate) is used to delete a protocol port template.
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceTemplateRequest"/></param>
        /// <returns><see cref="DeleteServiceTemplateResponse"/></returns>
        public DeleteServiceTemplateResponse DeleteServiceTemplateSync(DeleteServiceTemplateRequest req)
        {
             JsonResponseModel<DeleteServiceTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteServiceTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteServiceTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteServiceTemplateGroup) is used to delete a protocol port template group.
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceTemplateGroupRequest"/></param>
        /// <returns><see cref="DeleteServiceTemplateGroupResponse"/></returns>
        public async Task<DeleteServiceTemplateGroupResponse> DeleteServiceTemplateGroup(DeleteServiceTemplateGroupRequest req)
        {
             JsonResponseModel<DeleteServiceTemplateGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteServiceTemplateGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteServiceTemplateGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteServiceTemplateGroup) is used to delete a protocol port template group.
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceTemplateGroupRequest"/></param>
        /// <returns><see cref="DeleteServiceTemplateGroupResponse"/></returns>
        public DeleteServiceTemplateGroupResponse DeleteServiceTemplateGroupSync(DeleteServiceTemplateGroupRequest req)
        {
             JsonResponseModel<DeleteServiceTemplateGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteServiceTemplateGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteServiceTemplateGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete snapshot policies.
        /// </summary>
        /// <param name="req"><see cref="DeleteSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="DeleteSnapshotPoliciesResponse"/></returns>
        public async Task<DeleteSnapshotPoliciesResponse> DeleteSnapshotPolicies(DeleteSnapshotPoliciesRequest req)
        {
             JsonResponseModel<DeleteSnapshotPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSnapshotPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSnapshotPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete snapshot policies.
        /// </summary>
        /// <param name="req"><see cref="DeleteSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="DeleteSnapshotPoliciesResponse"/></returns>
        public DeleteSnapshotPoliciesResponse DeleteSnapshotPoliciesSync(DeleteSnapshotPoliciesRequest req)
        {
             JsonResponseModel<DeleteSnapshotPoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSnapshotPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSnapshotPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteSubnet) is used to delete subnets.
        /// Before deleting a subnet, you need to remove all resources in the subnet, including CVMs, load balancers, cloud data, NoSQL databases, and ENIs.
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
        /// This API (DeleteSubnet) is used to delete subnets.
        /// Before deleting a subnet, you need to remove all resources in the subnet, including CVMs, load balancers, cloud data, NoSQL databases, and ENIs.
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
        /// This API (DeleteVpc) is used to delete VPCs.
        /// * Before deleting a VPC, ensure that the VPC contains no resources, including CVMs, cloud databases, NoSQL databases, VPN gateways, direct connect gateways, load balancers, peering connections, and basic network devices that are linked to the VPC.
        /// * The deletion of VPCs is irreversible. Proceed with caution.
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
        /// This API (DeleteVpc) is used to delete VPCs.
        /// * Before deleting a VPC, ensure that the VPC contains no resources, including CVMs, cloud databases, NoSQL databases, VPN gateways, direct connect gateways, load balancers, peering connections, and basic network devices that are linked to the VPC.
        /// * The deletion of VPCs is irreversible. Proceed with caution.
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
        /// This API is used to delete an endpoint.
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcEndPointRequest"/></param>
        /// <returns><see cref="DeleteVpcEndPointResponse"/></returns>
        public async Task<DeleteVpcEndPointResponse> DeleteVpcEndPoint(DeleteVpcEndPointRequest req)
        {
             JsonResponseModel<DeleteVpcEndPointResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteVpcEndPoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteVpcEndPointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an endpoint.
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcEndPointRequest"/></param>
        /// <returns><see cref="DeleteVpcEndPointResponse"/></returns>
        public DeleteVpcEndPointResponse DeleteVpcEndPointSync(DeleteVpcEndPointRequest req)
        {
             JsonResponseModel<DeleteVpcEndPointResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteVpcEndPoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteVpcEndPointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an endpoint service.
        /// 
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcEndPointServiceRequest"/></param>
        /// <returns><see cref="DeleteVpcEndPointServiceResponse"/></returns>
        public async Task<DeleteVpcEndPointServiceResponse> DeleteVpcEndPointService(DeleteVpcEndPointServiceRequest req)
        {
             JsonResponseModel<DeleteVpcEndPointServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteVpcEndPointService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteVpcEndPointServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an endpoint service.
        /// 
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcEndPointServiceRequest"/></param>
        /// <returns><see cref="DeleteVpcEndPointServiceResponse"/></returns>
        public DeleteVpcEndPointServiceResponse DeleteVpcEndPointServiceSync(DeleteVpcEndPointServiceRequest req)
        {
             JsonResponseModel<DeleteVpcEndPointServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteVpcEndPointService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteVpcEndPointServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete the endpoint service allowlist.
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcEndPointServiceWhiteListRequest"/></param>
        /// <returns><see cref="DeleteVpcEndPointServiceWhiteListResponse"/></returns>
        public async Task<DeleteVpcEndPointServiceWhiteListResponse> DeleteVpcEndPointServiceWhiteList(DeleteVpcEndPointServiceWhiteListRequest req)
        {
             JsonResponseModel<DeleteVpcEndPointServiceWhiteListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteVpcEndPointServiceWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteVpcEndPointServiceWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete the endpoint service allowlist.
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcEndPointServiceWhiteListRequest"/></param>
        /// <returns><see cref="DeleteVpcEndPointServiceWhiteListResponse"/></returns>
        public DeleteVpcEndPointServiceWhiteListResponse DeleteVpcEndPointServiceWhiteListSync(DeleteVpcEndPointServiceWhiteListRequest req)
        {
             JsonResponseModel<DeleteVpcEndPointServiceWhiteListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteVpcEndPointServiceWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteVpcEndPointServiceWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteVpnConnection) is used to delete VPN tunnels.
        /// </summary>
        /// <param name="req"><see cref="DeleteVpnConnectionRequest"/></param>
        /// <returns><see cref="DeleteVpnConnectionResponse"/></returns>
        public async Task<DeleteVpnConnectionResponse> DeleteVpnConnection(DeleteVpnConnectionRequest req)
        {
             JsonResponseModel<DeleteVpnConnectionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteVpnConnection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteVpnConnectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteVpnConnection) is used to delete VPN tunnels.
        /// </summary>
        /// <param name="req"><see cref="DeleteVpnConnectionRequest"/></param>
        /// <returns><see cref="DeleteVpnConnectionResponse"/></returns>
        public DeleteVpnConnectionResponse DeleteVpnConnectionSync(DeleteVpnConnectionRequest req)
        {
             JsonResponseModel<DeleteVpnConnectionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteVpnConnection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteVpnConnectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteVpnGateway) is used to delete a VPN gateway. Currently, only deletion of pay-as-you-go IPSEC gateway instances in running status is supported.
        /// </summary>
        /// <param name="req"><see cref="DeleteVpnGatewayRequest"/></param>
        /// <returns><see cref="DeleteVpnGatewayResponse"/></returns>
        public async Task<DeleteVpnGatewayResponse> DeleteVpnGateway(DeleteVpnGatewayRequest req)
        {
             JsonResponseModel<DeleteVpnGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteVpnGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteVpnGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteVpnGateway) is used to delete a VPN gateway. Currently, only deletion of pay-as-you-go IPSEC gateway instances in running status is supported.
        /// </summary>
        /// <param name="req"><see cref="DeleteVpnGatewayRequest"/></param>
        /// <returns><see cref="DeleteVpnGatewayResponse"/></returns>
        public DeleteVpnGatewayResponse DeleteVpnGatewaySync(DeleteVpnGatewayRequest req)
        {
             JsonResponseModel<DeleteVpnGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteVpnGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteVpnGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete routes of a VPN gateway.
        /// </summary>
        /// <param name="req"><see cref="DeleteVpnGatewayRoutesRequest"/></param>
        /// <returns><see cref="DeleteVpnGatewayRoutesResponse"/></returns>
        public async Task<DeleteVpnGatewayRoutesResponse> DeleteVpnGatewayRoutes(DeleteVpnGatewayRoutesRequest req)
        {
             JsonResponseModel<DeleteVpnGatewayRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteVpnGatewayRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteVpnGatewayRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete routes of a VPN gateway.
        /// </summary>
        /// <param name="req"><see cref="DeleteVpnGatewayRoutesRequest"/></param>
        /// <returns><see cref="DeleteVpnGatewayRoutesResponse"/></returns>
        public DeleteVpnGatewayRoutesResponse DeleteVpnGatewayRoutesSync(DeleteVpnGatewayRoutesRequest req)
        {
             JsonResponseModel<DeleteVpnGatewayRoutesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteVpnGatewayRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteVpnGatewayRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeAccountAttributes) is used to query your account attributes.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountAttributesRequest"/></param>
        /// <returns><see cref="DescribeAccountAttributesResponse"/></returns>
        public async Task<DescribeAccountAttributesResponse> DescribeAccountAttributes(DescribeAccountAttributesRequest req)
        {
             JsonResponseModel<DescribeAccountAttributesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccountAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccountAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeAccountAttributes) is used to query your account attributes.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountAttributesRequest"/></param>
        /// <returns><see cref="DescribeAccountAttributesResponse"/></returns>
        public DescribeAccountAttributesResponse DescribeAccountAttributesSync(DescribeAccountAttributesRequest req)
        {
             JsonResponseModel<DescribeAccountAttributesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAccountAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccountAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeAddressQuota) is used to query the quota information of your [Elastic IP](https://intl.cloud.tencent.com/document/product/213/1941?from_cn_redirect=1) (EIP) in the current region. For more information, see [EIP product introduction](https://intl.cloud.tencent.com/document/product/213/5733?from_cn_redirect=1).
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
        /// This API (DescribeAddressQuota) is used to query the quota information of your [Elastic IP](https://intl.cloud.tencent.com/document/product/213/1941?from_cn_redirect=1) (EIP) in the current region. For more information, see [EIP product introduction](https://intl.cloud.tencent.com/document/product/213/5733?from_cn_redirect=1).
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
        /// This API (DescribeAddressTemplateGroups) is used to query an IP address template group.
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressTemplateGroupsRequest"/></param>
        /// <returns><see cref="DescribeAddressTemplateGroupsResponse"/></returns>
        public async Task<DescribeAddressTemplateGroupsResponse> DescribeAddressTemplateGroups(DescribeAddressTemplateGroupsRequest req)
        {
             JsonResponseModel<DescribeAddressTemplateGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAddressTemplateGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAddressTemplateGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeAddressTemplateGroups) is used to query an IP address template group.
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressTemplateGroupsRequest"/></param>
        /// <returns><see cref="DescribeAddressTemplateGroupsResponse"/></returns>
        public DescribeAddressTemplateGroupsResponse DescribeAddressTemplateGroupsSync(DescribeAddressTemplateGroupsRequest req)
        {
             JsonResponseModel<DescribeAddressTemplateGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAddressTemplateGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAddressTemplateGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeAddressTemplates) is used to query an IP address template.
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAddressTemplatesResponse"/></returns>
        public async Task<DescribeAddressTemplatesResponse> DescribeAddressTemplates(DescribeAddressTemplatesRequest req)
        {
             JsonResponseModel<DescribeAddressTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAddressTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAddressTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeAddressTemplates) is used to query an IP address template.
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAddressTemplatesResponse"/></returns>
        public DescribeAddressTemplatesResponse DescribeAddressTemplatesSync(DescribeAddressTemplatesRequest req)
        {
             JsonResponseModel<DescribeAddressTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAddressTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAddressTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeAddresses) is used to query the information of one or multiple [Elastic IPs](https://intl.cloud.tencent.com/document/product/213/1941?from_cn_redirect=1).
        /// * If the parameter is empty, a number (as specified by the `Limit`, the default value is 20) of EIPs will be returned.
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
        /// This API (DescribeAddresses) is used to query the information of one or multiple [Elastic IPs](https://intl.cloud.tencent.com/document/product/213/1941?from_cn_redirect=1).
        /// * If the parameter is empty, a number (as specified by the `Limit`, the default value is 20) of EIPs will be returned.
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
        /// This API is used to query the list of secondary CIDR blocks.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssistantCidrRequest"/></param>
        /// <returns><see cref="DescribeAssistantCidrResponse"/></returns>
        public async Task<DescribeAssistantCidrResponse> DescribeAssistantCidr(DescribeAssistantCidrRequest req)
        {
             JsonResponseModel<DescribeAssistantCidrResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssistantCidr");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssistantCidrResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of secondary CIDR blocks.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssistantCidrRequest"/></param>
        /// <returns><see cref="DescribeAssistantCidrResponse"/></returns>
        public DescribeAssistantCidrResponse DescribeAssistantCidrSync(DescribeAssistantCidrRequest req)
        {
             JsonResponseModel<DescribeAssistantCidrResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssistantCidr");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssistantCidrResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the current billable usage of a pay-as-you-go bandwidth package.
        /// </summary>
        /// <param name="req"><see cref="DescribeBandwidthPackageBillUsageRequest"/></param>
        /// <returns><see cref="DescribeBandwidthPackageBillUsageResponse"/></returns>
        public async Task<DescribeBandwidthPackageBillUsageResponse> DescribeBandwidthPackageBillUsage(DescribeBandwidthPackageBillUsageRequest req)
        {
             JsonResponseModel<DescribeBandwidthPackageBillUsageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBandwidthPackageBillUsage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBandwidthPackageBillUsageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the current billable usage of a pay-as-you-go bandwidth package.
        /// </summary>
        /// <param name="req"><see cref="DescribeBandwidthPackageBillUsageRequest"/></param>
        /// <returns><see cref="DescribeBandwidthPackageBillUsageResponse"/></returns>
        public DescribeBandwidthPackageBillUsageResponse DescribeBandwidthPackageBillUsageSync(DescribeBandwidthPackageBillUsageRequest req)
        {
             JsonResponseModel<DescribeBandwidthPackageBillUsageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBandwidthPackageBillUsage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBandwidthPackageBillUsageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the maximum and used number of bandwidth packages under the account in the current region.
        /// </summary>
        /// <param name="req"><see cref="DescribeBandwidthPackageQuotaRequest"/></param>
        /// <returns><see cref="DescribeBandwidthPackageQuotaResponse"/></returns>
        public async Task<DescribeBandwidthPackageQuotaResponse> DescribeBandwidthPackageQuota(DescribeBandwidthPackageQuotaRequest req)
        {
             JsonResponseModel<DescribeBandwidthPackageQuotaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBandwidthPackageQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBandwidthPackageQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the maximum and used number of bandwidth packages under the account in the current region.
        /// </summary>
        /// <param name="req"><see cref="DescribeBandwidthPackageQuotaRequest"/></param>
        /// <returns><see cref="DescribeBandwidthPackageQuotaResponse"/></returns>
        public DescribeBandwidthPackageQuotaResponse DescribeBandwidthPackageQuotaSync(DescribeBandwidthPackageQuotaRequest req)
        {
             JsonResponseModel<DescribeBandwidthPackageQuotaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBandwidthPackageQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBandwidthPackageQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query resources in a bandwidth package based on the unique package ID. You can filter the result by specifying conditions and paginate the query results.
        /// </summary>
        /// <param name="req"><see cref="DescribeBandwidthPackageResourcesRequest"/></param>
        /// <returns><see cref="DescribeBandwidthPackageResourcesResponse"/></returns>
        public async Task<DescribeBandwidthPackageResourcesResponse> DescribeBandwidthPackageResources(DescribeBandwidthPackageResourcesRequest req)
        {
             JsonResponseModel<DescribeBandwidthPackageResourcesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBandwidthPackageResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBandwidthPackageResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query resources in a bandwidth package based on the unique package ID. You can filter the result by specifying conditions and paginate the query results.
        /// </summary>
        /// <param name="req"><see cref="DescribeBandwidthPackageResourcesRequest"/></param>
        /// <returns><see cref="DescribeBandwidthPackageResourcesResponse"/></returns>
        public DescribeBandwidthPackageResourcesResponse DescribeBandwidthPackageResourcesSync(DescribeBandwidthPackageResourcesRequest req)
        {
             JsonResponseModel<DescribeBandwidthPackageResourcesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBandwidthPackageResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBandwidthPackageResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query bandwidth package information, including the unique ID of the bandwidth package, the type, the billing mode, the name, and the resource information.
        /// </summary>
        /// <param name="req"><see cref="DescribeBandwidthPackagesRequest"/></param>
        /// <returns><see cref="DescribeBandwidthPackagesResponse"/></returns>
        public async Task<DescribeBandwidthPackagesResponse> DescribeBandwidthPackages(DescribeBandwidthPackagesRequest req)
        {
             JsonResponseModel<DescribeBandwidthPackagesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBandwidthPackages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBandwidthPackagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query bandwidth package information, including the unique ID of the bandwidth package, the type, the billing mode, the name, and the resource information.
        /// </summary>
        /// <param name="req"><see cref="DescribeBandwidthPackagesRequest"/></param>
        /// <returns><see cref="DescribeBandwidthPackagesResponse"/></returns>
        public DescribeBandwidthPackagesResponse DescribeBandwidthPackagesSync(DescribeBandwidthPackagesRequest req)
        {
             JsonResponseModel<DescribeBandwidthPackagesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBandwidthPackages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBandwidthPackagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeCcnAttachedInstances) is used to query the network instances associated with the CCN instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnAttachedInstancesRequest"/></param>
        /// <returns><see cref="DescribeCcnAttachedInstancesResponse"/></returns>
        public async Task<DescribeCcnAttachedInstancesResponse> DescribeCcnAttachedInstances(DescribeCcnAttachedInstancesRequest req)
        {
             JsonResponseModel<DescribeCcnAttachedInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCcnAttachedInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCcnAttachedInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeCcnAttachedInstances) is used to query the network instances associated with the CCN instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnAttachedInstancesRequest"/></param>
        /// <returns><see cref="DescribeCcnAttachedInstancesResponse"/></returns>
        public DescribeCcnAttachedInstancesResponse DescribeCcnAttachedInstancesSync(DescribeCcnAttachedInstancesRequest req)
        {
             JsonResponseModel<DescribeCcnAttachedInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCcnAttachedInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCcnAttachedInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the outbound bandwidth caps of all regions connected with a CCN instance. The API only returns regions included in the associated network instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnRegionBandwidthLimitsRequest"/></param>
        /// <returns><see cref="DescribeCcnRegionBandwidthLimitsResponse"/></returns>
        public async Task<DescribeCcnRegionBandwidthLimitsResponse> DescribeCcnRegionBandwidthLimits(DescribeCcnRegionBandwidthLimitsRequest req)
        {
             JsonResponseModel<DescribeCcnRegionBandwidthLimitsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCcnRegionBandwidthLimits");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCcnRegionBandwidthLimitsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the outbound bandwidth caps of all regions connected with a CCN instance. The API only returns regions included in the associated network instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnRegionBandwidthLimitsRequest"/></param>
        /// <returns><see cref="DescribeCcnRegionBandwidthLimitsResponse"/></returns>
        public DescribeCcnRegionBandwidthLimitsResponse DescribeCcnRegionBandwidthLimitsSync(DescribeCcnRegionBandwidthLimitsRequest req)
        {
             JsonResponseModel<DescribeCcnRegionBandwidthLimitsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCcnRegionBandwidthLimits");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCcnRegionBandwidthLimitsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeCcnRoutes) is used to query routes that have been added to a CCN.
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnRoutesRequest"/></param>
        /// <returns><see cref="DescribeCcnRoutesResponse"/></returns>
        public async Task<DescribeCcnRoutesResponse> DescribeCcnRoutes(DescribeCcnRoutesRequest req)
        {
             JsonResponseModel<DescribeCcnRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCcnRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCcnRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeCcnRoutes) is used to query routes that have been added to a CCN.
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnRoutesRequest"/></param>
        /// <returns><see cref="DescribeCcnRoutesResponse"/></returns>
        public DescribeCcnRoutesResponse DescribeCcnRoutesSync(DescribeCcnRoutesRequest req)
        {
             JsonResponseModel<DescribeCcnRoutesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCcnRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCcnRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeCcns) is used to query the CCN list.
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnsRequest"/></param>
        /// <returns><see cref="DescribeCcnsResponse"/></returns>
        public async Task<DescribeCcnsResponse> DescribeCcns(DescribeCcnsRequest req)
        {
             JsonResponseModel<DescribeCcnsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCcns");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCcnsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeCcns) is used to query the CCN list.
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnsRequest"/></param>
        /// <returns><see cref="DescribeCcnsResponse"/></returns>
        public DescribeCcnsResponse DescribeCcnsSync(DescribeCcnsRequest req)
        {
             JsonResponseModel<DescribeCcnsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCcns");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCcnsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeClassicLinkInstances) is used to query the Classiclink instances list.
        /// </summary>
        /// <param name="req"><see cref="DescribeClassicLinkInstancesRequest"/></param>
        /// <returns><see cref="DescribeClassicLinkInstancesResponse"/></returns>
        public async Task<DescribeClassicLinkInstancesResponse> DescribeClassicLinkInstances(DescribeClassicLinkInstancesRequest req)
        {
             JsonResponseModel<DescribeClassicLinkInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClassicLinkInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClassicLinkInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeClassicLinkInstances) is used to query the Classiclink instances list.
        /// </summary>
        /// <param name="req"><see cref="DescribeClassicLinkInstancesRequest"/></param>
        /// <returns><see cref="DescribeClassicLinkInstancesResponse"/></returns>
        public DescribeClassicLinkInstancesResponse DescribeClassicLinkInstancesSync(DescribeClassicLinkInstancesRequest req)
        {
             JsonResponseModel<DescribeClassicLinkInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClassicLinkInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClassicLinkInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the compliance review requests created by the user. 
        /// A service provider can query all review requests created by any `APPID` under its account. Other users can only query their own review requests.
        /// </summary>
        /// <param name="req"><see cref="DescribeCrossBorderComplianceRequest"/></param>
        /// <returns><see cref="DescribeCrossBorderComplianceResponse"/></returns>
        public async Task<DescribeCrossBorderComplianceResponse> DescribeCrossBorderCompliance(DescribeCrossBorderComplianceRequest req)
        {
             JsonResponseModel<DescribeCrossBorderComplianceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCrossBorderCompliance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCrossBorderComplianceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the compliance review requests created by the user. 
        /// A service provider can query all review requests created by any `APPID` under its account. Other users can only query their own review requests.
        /// </summary>
        /// <param name="req"><see cref="DescribeCrossBorderComplianceRequest"/></param>
        /// <returns><see cref="DescribeCrossBorderComplianceResponse"/></returns>
        public DescribeCrossBorderComplianceResponse DescribeCrossBorderComplianceSync(DescribeCrossBorderComplianceRequest req)
        {
             JsonResponseModel<DescribeCrossBorderComplianceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCrossBorderCompliance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCrossBorderComplianceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeCustomerGatewayVendors) is used to query the information of supported customer gateway vendors.
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomerGatewayVendorsRequest"/></param>
        /// <returns><see cref="DescribeCustomerGatewayVendorsResponse"/></returns>
        public async Task<DescribeCustomerGatewayVendorsResponse> DescribeCustomerGatewayVendors(DescribeCustomerGatewayVendorsRequest req)
        {
             JsonResponseModel<DescribeCustomerGatewayVendorsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCustomerGatewayVendors");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomerGatewayVendorsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeCustomerGatewayVendors) is used to query the information of supported customer gateway vendors.
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomerGatewayVendorsRequest"/></param>
        /// <returns><see cref="DescribeCustomerGatewayVendorsResponse"/></returns>
        public DescribeCustomerGatewayVendorsResponse DescribeCustomerGatewayVendorsSync(DescribeCustomerGatewayVendorsRequest req)
        {
             JsonResponseModel<DescribeCustomerGatewayVendorsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCustomerGatewayVendors");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomerGatewayVendorsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeCustomerGateways) is used to query the customer gateway list.
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomerGatewaysRequest"/></param>
        /// <returns><see cref="DescribeCustomerGatewaysResponse"/></returns>
        public async Task<DescribeCustomerGatewaysResponse> DescribeCustomerGateways(DescribeCustomerGatewaysRequest req)
        {
             JsonResponseModel<DescribeCustomerGatewaysResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCustomerGateways");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomerGatewaysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeCustomerGateways) is used to query the customer gateway list.
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomerGatewaysRequest"/></param>
        /// <returns><see cref="DescribeCustomerGatewaysResponse"/></returns>
        public DescribeCustomerGatewaysResponse DescribeCustomerGatewaysSync(DescribeCustomerGatewaysRequest req)
        {
             JsonResponseModel<DescribeCustomerGatewaysResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCustomerGateways");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomerGatewaysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeDirectConnectGatewayCcnRoutes) is used to query the CCN routes (IDC IP range) of the Direct Connect gateway.
        /// </summary>
        /// <param name="req"><see cref="DescribeDirectConnectGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="DescribeDirectConnectGatewayCcnRoutesResponse"/></returns>
        public async Task<DescribeDirectConnectGatewayCcnRoutesResponse> DescribeDirectConnectGatewayCcnRoutes(DescribeDirectConnectGatewayCcnRoutesRequest req)
        {
             JsonResponseModel<DescribeDirectConnectGatewayCcnRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDirectConnectGatewayCcnRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDirectConnectGatewayCcnRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeDirectConnectGatewayCcnRoutes) is used to query the CCN routes (IDC IP range) of the Direct Connect gateway.
        /// </summary>
        /// <param name="req"><see cref="DescribeDirectConnectGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="DescribeDirectConnectGatewayCcnRoutesResponse"/></returns>
        public DescribeDirectConnectGatewayCcnRoutesResponse DescribeDirectConnectGatewayCcnRoutesSync(DescribeDirectConnectGatewayCcnRoutesRequest req)
        {
             JsonResponseModel<DescribeDirectConnectGatewayCcnRoutesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDirectConnectGatewayCcnRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDirectConnectGatewayCcnRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query direct connect gateways.
        /// </summary>
        /// <param name="req"><see cref="DescribeDirectConnectGatewaysRequest"/></param>
        /// <returns><see cref="DescribeDirectConnectGatewaysResponse"/></returns>
        public async Task<DescribeDirectConnectGatewaysResponse> DescribeDirectConnectGateways(DescribeDirectConnectGatewaysRequest req)
        {
             JsonResponseModel<DescribeDirectConnectGatewaysResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDirectConnectGateways");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDirectConnectGatewaysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query direct connect gateways.
        /// </summary>
        /// <param name="req"><see cref="DescribeDirectConnectGatewaysRequest"/></param>
        /// <returns><see cref="DescribeDirectConnectGatewaysResponse"/></returns>
        public DescribeDirectConnectGatewaysResponse DescribeDirectConnectGatewaysSync(DescribeDirectConnectGatewaysRequest req)
        {
             JsonResponseModel<DescribeDirectConnectGatewaysResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDirectConnectGateways");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDirectConnectGatewaysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of a flow log.
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowLogRequest"/></param>
        /// <returns><see cref="DescribeFlowLogResponse"/></returns>
        public async Task<DescribeFlowLogResponse> DescribeFlowLog(DescribeFlowLogRequest req)
        {
             JsonResponseModel<DescribeFlowLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFlowLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of a flow log.
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowLogRequest"/></param>
        /// <returns><see cref="DescribeFlowLogResponse"/></returns>
        public DescribeFlowLogResponse DescribeFlowLogSync(DescribeFlowLogRequest req)
        {
             JsonResponseModel<DescribeFlowLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFlowLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query all the flow logs of the current account.
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowLogsRequest"/></param>
        /// <returns><see cref="DescribeFlowLogsResponse"/></returns>
        public async Task<DescribeFlowLogsResponse> DescribeFlowLogs(DescribeFlowLogsRequest req)
        {
             JsonResponseModel<DescribeFlowLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFlowLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query all the flow logs of the current account.
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowLogsRequest"/></param>
        /// <returns><see cref="DescribeFlowLogsResponse"/></returns>
        public DescribeFlowLogsResponse DescribeFlowLogsSync(DescribeFlowLogsRequest req)
        {
             JsonResponseModel<DescribeFlowLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFlowLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the traffic monitoring details of the gateway.
        /// * You can only use this API to query a single gateway instance, which means you must pass in only one of `VpnId`, `DirectConnectGatewayId`, `PeeringConnectionId`, or `NatId`.
        /// * If the gateway has traffic, but no data is returned when this API is called, please check whether gateway traffic monitoring has been enabled in the corresponding gateway details page in the console.
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayFlowMonitorDetailRequest"/></param>
        /// <returns><see cref="DescribeGatewayFlowMonitorDetailResponse"/></returns>
        public async Task<DescribeGatewayFlowMonitorDetailResponse> DescribeGatewayFlowMonitorDetail(DescribeGatewayFlowMonitorDetailRequest req)
        {
             JsonResponseModel<DescribeGatewayFlowMonitorDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGatewayFlowMonitorDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGatewayFlowMonitorDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the traffic monitoring details of the gateway.
        /// * You can only use this API to query a single gateway instance, which means you must pass in only one of `VpnId`, `DirectConnectGatewayId`, `PeeringConnectionId`, or `NatId`.
        /// * If the gateway has traffic, but no data is returned when this API is called, please check whether gateway traffic monitoring has been enabled in the corresponding gateway details page in the console.
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayFlowMonitorDetailRequest"/></param>
        /// <returns><see cref="DescribeGatewayFlowMonitorDetailResponse"/></returns>
        public DescribeGatewayFlowMonitorDetailResponse DescribeGatewayFlowMonitorDetailSync(DescribeGatewayFlowMonitorDetailRequest req)
        {
             JsonResponseModel<DescribeGatewayFlowMonitorDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGatewayFlowMonitorDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGatewayFlowMonitorDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the inbound IP bandwidth limit of a gateway.
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayFlowQosRequest"/></param>
        /// <returns><see cref="DescribeGatewayFlowQosResponse"/></returns>
        public async Task<DescribeGatewayFlowQosResponse> DescribeGatewayFlowQos(DescribeGatewayFlowQosRequest req)
        {
             JsonResponseModel<DescribeGatewayFlowQosResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGatewayFlowQos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGatewayFlowQosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the inbound IP bandwidth limit of a gateway.
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayFlowQosRequest"/></param>
        /// <returns><see cref="DescribeGatewayFlowQosResponse"/></returns>
        public DescribeGatewayFlowQosResponse DescribeGatewayFlowQosSync(DescribeGatewayFlowQosRequest req)
        {
             JsonResponseModel<DescribeGatewayFlowQosResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGatewayFlowQos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGatewayFlowQosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeHaVips) is used to query the list of highly available virtual IPs (HAVIP).
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
        /// This API (DescribeHaVips) is used to query the list of highly available virtual IPs (HAVIP).
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
        /// This API is used to obtain the download link of an IP location database.
        /// </summary>
        /// <param name="req"><see cref="DescribeIpGeolocationDatabaseUrlRequest"/></param>
        /// <returns><see cref="DescribeIpGeolocationDatabaseUrlResponse"/></returns>
        public async Task<DescribeIpGeolocationDatabaseUrlResponse> DescribeIpGeolocationDatabaseUrl(DescribeIpGeolocationDatabaseUrlRequest req)
        {
             JsonResponseModel<DescribeIpGeolocationDatabaseUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIpGeolocationDatabaseUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIpGeolocationDatabaseUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the download link of an IP location database.
        /// </summary>
        /// <param name="req"><see cref="DescribeIpGeolocationDatabaseUrlRequest"/></param>
        /// <returns><see cref="DescribeIpGeolocationDatabaseUrlResponse"/></returns>
        public DescribeIpGeolocationDatabaseUrlResponse DescribeIpGeolocationDatabaseUrlSync(DescribeIpGeolocationDatabaseUrlRequest req)
        {
             JsonResponseModel<DescribeIpGeolocationDatabaseUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIpGeolocationDatabaseUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIpGeolocationDatabaseUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the location and network information of one or more IP addresses.
        /// This API is only available for existing customers. For any questions, please [submit a ticket](https://console.cloud.tencent.com/workorder/category?level1_id=6&level2_id=660&source=0&data_title=%E5%BC%B9%E6%80%A7%E5%85%AC%E7%BD%91%20EIP&level3_id=662&queue=96&scene_code=16400&step=2).
        /// </summary>
        /// <param name="req"><see cref="DescribeIpGeolocationInfosRequest"/></param>
        /// <returns><see cref="DescribeIpGeolocationInfosResponse"/></returns>
        public async Task<DescribeIpGeolocationInfosResponse> DescribeIpGeolocationInfos(DescribeIpGeolocationInfosRequest req)
        {
             JsonResponseModel<DescribeIpGeolocationInfosResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIpGeolocationInfos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIpGeolocationInfosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the location and network information of one or more IP addresses.
        /// This API is only available for existing customers. For any questions, please [submit a ticket](https://console.cloud.tencent.com/workorder/category?level1_id=6&level2_id=660&source=0&data_title=%E5%BC%B9%E6%80%A7%E5%85%AC%E7%BD%91%20EIP&level3_id=662&queue=96&scene_code=16400&step=2).
        /// </summary>
        /// <param name="req"><see cref="DescribeIpGeolocationInfosRequest"/></param>
        /// <returns><see cref="DescribeIpGeolocationInfosResponse"/></returns>
        public DescribeIpGeolocationInfosResponse DescribeIpGeolocationInfosSync(DescribeIpGeolocationInfosRequest req)
        {
             JsonResponseModel<DescribeIpGeolocationInfosResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIpGeolocationInfos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIpGeolocationInfosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query local gateways of a CDC instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeLocalGatewayRequest"/></param>
        /// <returns><see cref="DescribeLocalGatewayResponse"/></returns>
        public async Task<DescribeLocalGatewayResponse> DescribeLocalGateway(DescribeLocalGatewayRequest req)
        {
             JsonResponseModel<DescribeLocalGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLocalGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLocalGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query local gateways of a CDC instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeLocalGatewayRequest"/></param>
        /// <returns><see cref="DescribeLocalGatewayResponse"/></returns>
        public DescribeLocalGatewayResponse DescribeLocalGatewaySync(DescribeLocalGatewayRequest req)
        {
             JsonResponseModel<DescribeLocalGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLocalGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLocalGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the array of objects of a NAT gateway's port forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeNatGatewayDestinationIpPortTranslationNatRulesRequest"/></param>
        /// <returns><see cref="DescribeNatGatewayDestinationIpPortTranslationNatRulesResponse"/></returns>
        public async Task<DescribeNatGatewayDestinationIpPortTranslationNatRulesResponse> DescribeNatGatewayDestinationIpPortTranslationNatRules(DescribeNatGatewayDestinationIpPortTranslationNatRulesRequest req)
        {
             JsonResponseModel<DescribeNatGatewayDestinationIpPortTranslationNatRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNatGatewayDestinationIpPortTranslationNatRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNatGatewayDestinationIpPortTranslationNatRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the array of objects of a NAT gateway's port forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeNatGatewayDestinationIpPortTranslationNatRulesRequest"/></param>
        /// <returns><see cref="DescribeNatGatewayDestinationIpPortTranslationNatRulesResponse"/></returns>
        public DescribeNatGatewayDestinationIpPortTranslationNatRulesResponse DescribeNatGatewayDestinationIpPortTranslationNatRulesSync(DescribeNatGatewayDestinationIpPortTranslationNatRulesRequest req)
        {
             JsonResponseModel<DescribeNatGatewayDestinationIpPortTranslationNatRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNatGatewayDestinationIpPortTranslationNatRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNatGatewayDestinationIpPortTranslationNatRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the routes between a NAT gateway and Direct Connect.
        /// </summary>
        /// <param name="req"><see cref="DescribeNatGatewayDirectConnectGatewayRouteRequest"/></param>
        /// <returns><see cref="DescribeNatGatewayDirectConnectGatewayRouteResponse"/></returns>
        public async Task<DescribeNatGatewayDirectConnectGatewayRouteResponse> DescribeNatGatewayDirectConnectGatewayRoute(DescribeNatGatewayDirectConnectGatewayRouteRequest req)
        {
             JsonResponseModel<DescribeNatGatewayDirectConnectGatewayRouteResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNatGatewayDirectConnectGatewayRoute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNatGatewayDirectConnectGatewayRouteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the routes between a NAT gateway and Direct Connect.
        /// </summary>
        /// <param name="req"><see cref="DescribeNatGatewayDirectConnectGatewayRouteRequest"/></param>
        /// <returns><see cref="DescribeNatGatewayDirectConnectGatewayRouteResponse"/></returns>
        public DescribeNatGatewayDirectConnectGatewayRouteResponse DescribeNatGatewayDirectConnectGatewayRouteSync(DescribeNatGatewayDirectConnectGatewayRouteRequest req)
        {
             JsonResponseModel<DescribeNatGatewayDirectConnectGatewayRouteResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNatGatewayDirectConnectGatewayRoute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNatGatewayDirectConnectGatewayRouteResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the NAT gateway's SNAT forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeNatGatewaySourceIpTranslationNatRulesRequest"/></param>
        /// <returns><see cref="DescribeNatGatewaySourceIpTranslationNatRulesResponse"/></returns>
        public async Task<DescribeNatGatewaySourceIpTranslationNatRulesResponse> DescribeNatGatewaySourceIpTranslationNatRules(DescribeNatGatewaySourceIpTranslationNatRulesRequest req)
        {
             JsonResponseModel<DescribeNatGatewaySourceIpTranslationNatRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNatGatewaySourceIpTranslationNatRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNatGatewaySourceIpTranslationNatRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the NAT gateway's SNAT forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeNatGatewaySourceIpTranslationNatRulesRequest"/></param>
        /// <returns><see cref="DescribeNatGatewaySourceIpTranslationNatRulesResponse"/></returns>
        public DescribeNatGatewaySourceIpTranslationNatRulesResponse DescribeNatGatewaySourceIpTranslationNatRulesSync(DescribeNatGatewaySourceIpTranslationNatRulesRequest req)
        {
             JsonResponseModel<DescribeNatGatewaySourceIpTranslationNatRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNatGatewaySourceIpTranslationNatRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNatGatewaySourceIpTranslationNatRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query NAT gateways.
        /// </summary>
        /// <param name="req"><see cref="DescribeNatGatewaysRequest"/></param>
        /// <returns><see cref="DescribeNatGatewaysResponse"/></returns>
        public async Task<DescribeNatGatewaysResponse> DescribeNatGateways(DescribeNatGatewaysRequest req)
        {
             JsonResponseModel<DescribeNatGatewaysResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNatGateways");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNatGatewaysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query NAT gateways.
        /// </summary>
        /// <param name="req"><see cref="DescribeNatGatewaysRequest"/></param>
        /// <returns><see cref="DescribeNatGatewaysResponse"/></returns>
        public DescribeNatGatewaysResponse DescribeNatGatewaysSync(DescribeNatGatewaysRequest req)
        {
             JsonResponseModel<DescribeNatGatewaysResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNatGateways");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNatGatewaysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeNetDetectStates) is used to query the list of network detection verification results.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetDetectStatesRequest"/></param>
        /// <returns><see cref="DescribeNetDetectStatesResponse"/></returns>
        public async Task<DescribeNetDetectStatesResponse> DescribeNetDetectStates(DescribeNetDetectStatesRequest req)
        {
             JsonResponseModel<DescribeNetDetectStatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNetDetectStates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetDetectStatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeNetDetectStates) is used to query the list of network detection verification results.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetDetectStatesRequest"/></param>
        /// <returns><see cref="DescribeNetDetectStatesResponse"/></returns>
        public DescribeNetDetectStatesResponse DescribeNetDetectStatesSync(DescribeNetDetectStatesRequest req)
        {
             JsonResponseModel<DescribeNetDetectStatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNetDetectStates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetDetectStatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeNetDetects) is used to query the list of network detection instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetDetectsRequest"/></param>
        /// <returns><see cref="DescribeNetDetectsResponse"/></returns>
        public async Task<DescribeNetDetectsResponse> DescribeNetDetects(DescribeNetDetectsRequest req)
        {
             JsonResponseModel<DescribeNetDetectsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNetDetects");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetDetectsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeNetDetects) is used to query the list of network detection instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetDetectsRequest"/></param>
        /// <returns><see cref="DescribeNetDetectsResponse"/></returns>
        public DescribeNetDetectsResponse DescribeNetDetectsSync(DescribeNetDetectsRequest req)
        {
             JsonResponseModel<DescribeNetDetectsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNetDetects");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetDetectsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of in/outbound network ACL quintuple entries.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkAclQuintupleEntriesRequest"/></param>
        /// <returns><see cref="DescribeNetworkAclQuintupleEntriesResponse"/></returns>
        public async Task<DescribeNetworkAclQuintupleEntriesResponse> DescribeNetworkAclQuintupleEntries(DescribeNetworkAclQuintupleEntriesRequest req)
        {
             JsonResponseModel<DescribeNetworkAclQuintupleEntriesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNetworkAclQuintupleEntries");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetworkAclQuintupleEntriesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of in/outbound network ACL quintuple entries.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkAclQuintupleEntriesRequest"/></param>
        /// <returns><see cref="DescribeNetworkAclQuintupleEntriesResponse"/></returns>
        public DescribeNetworkAclQuintupleEntriesResponse DescribeNetworkAclQuintupleEntriesSync(DescribeNetworkAclQuintupleEntriesRequest req)
        {
             JsonResponseModel<DescribeNetworkAclQuintupleEntriesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNetworkAclQuintupleEntries");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetworkAclQuintupleEntriesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query a list of network ACLs.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkAclsRequest"/></param>
        /// <returns><see cref="DescribeNetworkAclsResponse"/></returns>
        public async Task<DescribeNetworkAclsResponse> DescribeNetworkAcls(DescribeNetworkAclsRequest req)
        {
             JsonResponseModel<DescribeNetworkAclsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNetworkAcls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetworkAclsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query a list of network ACLs.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkAclsRequest"/></param>
        /// <returns><see cref="DescribeNetworkAclsResponse"/></returns>
        public DescribeNetworkAclsResponse DescribeNetworkAclsSync(DescribeNetworkAclsRequest req)
        {
             JsonResponseModel<DescribeNetworkAclsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNetworkAcls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetworkAclsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeNetworkInterfaceLimit) is used to query the ENI quota based on the ID of CVM instance or ENI. It returns the ENI quota to which the CVM instance can be bound and the IP address quota that can be allocated to the ENI.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkInterfaceLimitRequest"/></param>
        /// <returns><see cref="DescribeNetworkInterfaceLimitResponse"/></returns>
        public async Task<DescribeNetworkInterfaceLimitResponse> DescribeNetworkInterfaceLimit(DescribeNetworkInterfaceLimitRequest req)
        {
             JsonResponseModel<DescribeNetworkInterfaceLimitResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNetworkInterfaceLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetworkInterfaceLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeNetworkInterfaceLimit) is used to query the ENI quota based on the ID of CVM instance or ENI. It returns the ENI quota to which the CVM instance can be bound and the IP address quota that can be allocated to the ENI.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkInterfaceLimitRequest"/></param>
        /// <returns><see cref="DescribeNetworkInterfaceLimitResponse"/></returns>
        public DescribeNetworkInterfaceLimitResponse DescribeNetworkInterfaceLimitSync(DescribeNetworkInterfaceLimitRequest req)
        {
             JsonResponseModel<DescribeNetworkInterfaceLimitResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNetworkInterfaceLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetworkInterfaceLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeNetworkInterfaces) is used to query the ENI list.
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
        /// This API (DescribeNetworkInterfaces) is used to query the ENI list.
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
        ///  This API (DescribeRouteTables) is used to query route tables.
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
        ///  This API (DescribeRouteTables) is used to query route tables.
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
        /// This API (DescribeSecurityGroupAssociationStatistics) is used to query statistics on the instances associated with a security group.
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
        /// This API (DescribeSecurityGroupAssociationStatistics) is used to query statistics on the instances associated with a security group.
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
        /// This API (DescribeSecurityGroupPolicies) is used to query security group policies.
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
        /// This API (DescribeSecurityGroupPolicies) is used to query security group policies.
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
        /// This API (DescribeSecurityGroupReferences) is used to query referred security groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupReferencesRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupReferencesResponse"/></returns>
        public async Task<DescribeSecurityGroupReferencesResponse> DescribeSecurityGroupReferences(DescribeSecurityGroupReferencesRequest req)
        {
             JsonResponseModel<DescribeSecurityGroupReferencesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecurityGroupReferences");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityGroupReferencesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeSecurityGroupReferences) is used to query referred security groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupReferencesRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupReferencesResponse"/></returns>
        public DescribeSecurityGroupReferencesResponse DescribeSecurityGroupReferencesSync(DescribeSecurityGroupReferencesRequest req)
        {
             JsonResponseModel<DescribeSecurityGroupReferencesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecurityGroupReferences");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityGroupReferencesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeSecurityGroups) is used to query security groups.
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
        /// This API (DescribeSecurityGroups) is used to query security groups.
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
        /// This API (DescribeServiceTemplateGroups) is used to query a protocol port template group.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceTemplateGroupsRequest"/></param>
        /// <returns><see cref="DescribeServiceTemplateGroupsResponse"/></returns>
        public async Task<DescribeServiceTemplateGroupsResponse> DescribeServiceTemplateGroups(DescribeServiceTemplateGroupsRequest req)
        {
             JsonResponseModel<DescribeServiceTemplateGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeServiceTemplateGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceTemplateGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeServiceTemplateGroups) is used to query a protocol port template group.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceTemplateGroupsRequest"/></param>
        /// <returns><see cref="DescribeServiceTemplateGroupsResponse"/></returns>
        public DescribeServiceTemplateGroupsResponse DescribeServiceTemplateGroupsSync(DescribeServiceTemplateGroupsRequest req)
        {
             JsonResponseModel<DescribeServiceTemplateGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeServiceTemplateGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceTemplateGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeServiceTemplates) is used to query protocol port templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceTemplatesRequest"/></param>
        /// <returns><see cref="DescribeServiceTemplatesResponse"/></returns>
        public async Task<DescribeServiceTemplatesResponse> DescribeServiceTemplates(DescribeServiceTemplatesRequest req)
        {
             JsonResponseModel<DescribeServiceTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeServiceTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeServiceTemplates) is used to query protocol port templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceTemplatesRequest"/></param>
        /// <returns><see cref="DescribeServiceTemplatesResponse"/></returns>
        public DescribeServiceTemplatesResponse DescribeServiceTemplatesSync(DescribeServiceTemplatesRequest req)
        {
             JsonResponseModel<DescribeServiceTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeServiceTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the snapshot file contents.
        /// </summary>
        /// <param name="req"><see cref="DescribeSgSnapshotFileContentRequest"/></param>
        /// <returns><see cref="DescribeSgSnapshotFileContentResponse"/></returns>
        public async Task<DescribeSgSnapshotFileContentResponse> DescribeSgSnapshotFileContent(DescribeSgSnapshotFileContentRequest req)
        {
             JsonResponseModel<DescribeSgSnapshotFileContentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSgSnapshotFileContent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSgSnapshotFileContentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the snapshot file contents.
        /// </summary>
        /// <param name="req"><see cref="DescribeSgSnapshotFileContentRequest"/></param>
        /// <returns><see cref="DescribeSgSnapshotFileContentResponse"/></returns>
        public DescribeSgSnapshotFileContentResponse DescribeSgSnapshotFileContentSync(DescribeSgSnapshotFileContentRequest req)
        {
             JsonResponseModel<DescribeSgSnapshotFileContentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSgSnapshotFileContent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSgSnapshotFileContentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query instances associated with a snapshot policy.
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotAttachedInstancesRequest"/></param>
        /// <returns><see cref="DescribeSnapshotAttachedInstancesResponse"/></returns>
        public async Task<DescribeSnapshotAttachedInstancesResponse> DescribeSnapshotAttachedInstances(DescribeSnapshotAttachedInstancesRequest req)
        {
             JsonResponseModel<DescribeSnapshotAttachedInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSnapshotAttachedInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotAttachedInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query instances associated with a snapshot policy.
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotAttachedInstancesRequest"/></param>
        /// <returns><see cref="DescribeSnapshotAttachedInstancesResponse"/></returns>
        public DescribeSnapshotAttachedInstancesResponse DescribeSnapshotAttachedInstancesSync(DescribeSnapshotAttachedInstancesRequest req)
        {
             JsonResponseModel<DescribeSnapshotAttachedInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSnapshotAttachedInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotAttachedInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query snapshot files.
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotFilesRequest"/></param>
        /// <returns><see cref="DescribeSnapshotFilesResponse"/></returns>
        public async Task<DescribeSnapshotFilesResponse> DescribeSnapshotFiles(DescribeSnapshotFilesRequest req)
        {
             JsonResponseModel<DescribeSnapshotFilesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSnapshotFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query snapshot files.
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotFilesRequest"/></param>
        /// <returns><see cref="DescribeSnapshotFilesResponse"/></returns>
        public DescribeSnapshotFilesResponse DescribeSnapshotFilesSync(DescribeSnapshotFilesRequest req)
        {
             JsonResponseModel<DescribeSnapshotFilesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSnapshotFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query snapshot policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="DescribeSnapshotPoliciesResponse"/></returns>
        public async Task<DescribeSnapshotPoliciesResponse> DescribeSnapshotPolicies(DescribeSnapshotPoliciesRequest req)
        {
             JsonResponseModel<DescribeSnapshotPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSnapshotPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query snapshot policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="DescribeSnapshotPoliciesResponse"/></returns>
        public DescribeSnapshotPoliciesResponse DescribeSnapshotPoliciesSync(DescribeSnapshotPoliciesRequest req)
        {
             JsonResponseModel<DescribeSnapshotPoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSnapshotPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeSubnets) is used to query the list of subnets.
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
        /// This API (DescribeSubnets) is used to query the list of subnets.
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
        /// This API is used to query the EIP async job execution results.
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
        /// This API is used to query the EIP async job execution results.
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
        /// This API is used to query the details of shared traffic packages.
        /// </summary>
        /// <param name="req"><see cref="DescribeTrafficPackagesRequest"/></param>
        /// <returns><see cref="DescribeTrafficPackagesResponse"/></returns>
        public async Task<DescribeTrafficPackagesResponse> DescribeTrafficPackages(DescribeTrafficPackagesRequest req)
        {
             JsonResponseModel<DescribeTrafficPackagesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTrafficPackages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrafficPackagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of shared traffic packages.
        /// </summary>
        /// <param name="req"><see cref="DescribeTrafficPackagesRequest"/></param>
        /// <returns><see cref="DescribeTrafficPackagesResponse"/></returns>
        public DescribeTrafficPackagesResponse DescribeTrafficPackagesSync(DescribeTrafficPackagesRequest req)
        {
             JsonResponseModel<DescribeTrafficPackagesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTrafficPackages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrafficPackagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the endpoint list.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcEndPointRequest"/></param>
        /// <returns><see cref="DescribeVpcEndPointResponse"/></returns>
        public async Task<DescribeVpcEndPointResponse> DescribeVpcEndPoint(DescribeVpcEndPointRequest req)
        {
             JsonResponseModel<DescribeVpcEndPointResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVpcEndPoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcEndPointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the endpoint list.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcEndPointRequest"/></param>
        /// <returns><see cref="DescribeVpcEndPointResponse"/></returns>
        public DescribeVpcEndPointResponse DescribeVpcEndPointSync(DescribeVpcEndPointRequest req)
        {
             JsonResponseModel<DescribeVpcEndPointResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVpcEndPoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcEndPointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the endpoint service list.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcEndPointServiceRequest"/></param>
        /// <returns><see cref="DescribeVpcEndPointServiceResponse"/></returns>
        public async Task<DescribeVpcEndPointServiceResponse> DescribeVpcEndPointService(DescribeVpcEndPointServiceRequest req)
        {
             JsonResponseModel<DescribeVpcEndPointServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVpcEndPointService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcEndPointServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the endpoint service list.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcEndPointServiceRequest"/></param>
        /// <returns><see cref="DescribeVpcEndPointServiceResponse"/></returns>
        public DescribeVpcEndPointServiceResponse DescribeVpcEndPointServiceSync(DescribeVpcEndPointServiceRequest req)
        {
             JsonResponseModel<DescribeVpcEndPointServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVpcEndPointService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcEndPointServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the endpoint service allowlist.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcEndPointServiceWhiteListRequest"/></param>
        /// <returns><see cref="DescribeVpcEndPointServiceWhiteListResponse"/></returns>
        public async Task<DescribeVpcEndPointServiceWhiteListResponse> DescribeVpcEndPointServiceWhiteList(DescribeVpcEndPointServiceWhiteListRequest req)
        {
             JsonResponseModel<DescribeVpcEndPointServiceWhiteListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVpcEndPointServiceWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcEndPointServiceWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the endpoint service allowlist.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcEndPointServiceWhiteListRequest"/></param>
        /// <returns><see cref="DescribeVpcEndPointServiceWhiteListResponse"/></returns>
        public DescribeVpcEndPointServiceWhiteListResponse DescribeVpcEndPointServiceWhiteListSync(DescribeVpcEndPointServiceWhiteListRequest req)
        {
             JsonResponseModel<DescribeVpcEndPointServiceWhiteListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVpcEndPointServiceWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcEndPointServiceWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  This API (DescribeVpcInstances) is used to query a list of VCM instances on VPC.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcInstancesRequest"/></param>
        /// <returns><see cref="DescribeVpcInstancesResponse"/></returns>
        public async Task<DescribeVpcInstancesResponse> DescribeVpcInstances(DescribeVpcInstancesRequest req)
        {
             JsonResponseModel<DescribeVpcInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVpcInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  This API (DescribeVpcInstances) is used to query a list of VCM instances on VPC.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcInstancesRequest"/></param>
        /// <returns><see cref="DescribeVpcInstancesResponse"/></returns>
        public DescribeVpcInstancesResponse DescribeVpcInstancesSync(DescribeVpcInstancesRequest req)
        {
             JsonResponseModel<DescribeVpcInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVpcInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeVpcIpv6Addresses) is used to query `VPC` `IPv6` information.
        /// This API is used to query only the information of `IPv6` addresses that are already in use. When querying IPs that have not yet been used, this API will not report an error, but the IPs will not appear in the returned results.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcIpv6AddressesRequest"/></param>
        /// <returns><see cref="DescribeVpcIpv6AddressesResponse"/></returns>
        public async Task<DescribeVpcIpv6AddressesResponse> DescribeVpcIpv6Addresses(DescribeVpcIpv6AddressesRequest req)
        {
             JsonResponseModel<DescribeVpcIpv6AddressesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVpcIpv6Addresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcIpv6AddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeVpcIpv6Addresses) is used to query `VPC` `IPv6` information.
        /// This API is used to query only the information of `IPv6` addresses that are already in use. When querying IPs that have not yet been used, this API will not report an error, but the IPs will not appear in the returned results.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcIpv6AddressesRequest"/></param>
        /// <returns><see cref="DescribeVpcIpv6AddressesResponse"/></returns>
        public DescribeVpcIpv6AddressesResponse DescribeVpcIpv6AddressesSync(DescribeVpcIpv6AddressesRequest req)
        {
             JsonResponseModel<DescribeVpcIpv6AddressesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVpcIpv6Addresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcIpv6AddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeVpcPrivateIpAddresses) is used to query the private IP information of a VPC.<br />
        /// This API is used to query only the information of IP addresses that are already in use. When querying IPs that have not yet been used, this API will not report an error, but the IPs will not appear in the returned results.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcPrivateIpAddressesRequest"/></param>
        /// <returns><see cref="DescribeVpcPrivateIpAddressesResponse"/></returns>
        public async Task<DescribeVpcPrivateIpAddressesResponse> DescribeVpcPrivateIpAddresses(DescribeVpcPrivateIpAddressesRequest req)
        {
             JsonResponseModel<DescribeVpcPrivateIpAddressesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVpcPrivateIpAddresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcPrivateIpAddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeVpcPrivateIpAddresses) is used to query the private IP information of a VPC.<br />
        /// This API is used to query only the information of IP addresses that are already in use. When querying IPs that have not yet been used, this API will not report an error, but the IPs will not appear in the returned results.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcPrivateIpAddressesRequest"/></param>
        /// <returns><see cref="DescribeVpcPrivateIpAddressesResponse"/></returns>
        public DescribeVpcPrivateIpAddressesResponse DescribeVpcPrivateIpAddressesSync(DescribeVpcPrivateIpAddressesRequest req)
        {
             JsonResponseModel<DescribeVpcPrivateIpAddressesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVpcPrivateIpAddresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcPrivateIpAddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// View VPC resources.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcResourceDashboardRequest"/></param>
        /// <returns><see cref="DescribeVpcResourceDashboardResponse"/></returns>
        public async Task<DescribeVpcResourceDashboardResponse> DescribeVpcResourceDashboard(DescribeVpcResourceDashboardRequest req)
        {
             JsonResponseModel<DescribeVpcResourceDashboardResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVpcResourceDashboard");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcResourceDashboardResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// View VPC resources.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcResourceDashboardRequest"/></param>
        /// <returns><see cref="DescribeVpcResourceDashboardResponse"/></returns>
        public DescribeVpcResourceDashboardResponse DescribeVpcResourceDashboardSync(DescribeVpcResourceDashboardRequest req)
        {
             JsonResponseModel<DescribeVpcResourceDashboardResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVpcResourceDashboard");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcResourceDashboardResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the execution result of a VPC task.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcTaskResultRequest"/></param>
        /// <returns><see cref="DescribeVpcTaskResultResponse"/></returns>
        public async Task<DescribeVpcTaskResultResponse> DescribeVpcTaskResult(DescribeVpcTaskResultRequest req)
        {
             JsonResponseModel<DescribeVpcTaskResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVpcTaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcTaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the execution result of a VPC task.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcTaskResultRequest"/></param>
        /// <returns><see cref="DescribeVpcTaskResultResponse"/></returns>
        public DescribeVpcTaskResultResponse DescribeVpcTaskResultSync(DescribeVpcTaskResultRequest req)
        {
             JsonResponseModel<DescribeVpcTaskResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVpcTaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcTaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeVpcs) is used to query the VPC list.
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
        /// This API (DescribeVpcs) is used to query the VPC list.
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
        ///  This API (DescribeVpnConnections) is used to query the VPN tunnel list.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpnConnectionsRequest"/></param>
        /// <returns><see cref="DescribeVpnConnectionsResponse"/></returns>
        public async Task<DescribeVpnConnectionsResponse> DescribeVpnConnections(DescribeVpnConnectionsRequest req)
        {
             JsonResponseModel<DescribeVpnConnectionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVpnConnections");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpnConnectionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  This API (DescribeVpnConnections) is used to query the VPN tunnel list.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpnConnectionsRequest"/></param>
        /// <returns><see cref="DescribeVpnConnectionsResponse"/></returns>
        public DescribeVpnConnectionsResponse DescribeVpnConnectionsSync(DescribeVpnConnectionsRequest req)
        {
             JsonResponseModel<DescribeVpnConnectionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVpnConnections");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpnConnectionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeVpnGatewayCcnRoutes) is used to query VPN gateway-based CCN routes.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpnGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="DescribeVpnGatewayCcnRoutesResponse"/></returns>
        public async Task<DescribeVpnGatewayCcnRoutesResponse> DescribeVpnGatewayCcnRoutes(DescribeVpnGatewayCcnRoutesRequest req)
        {
             JsonResponseModel<DescribeVpnGatewayCcnRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVpnGatewayCcnRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpnGatewayCcnRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeVpnGatewayCcnRoutes) is used to query VPN gateway-based CCN routes.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpnGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="DescribeVpnGatewayCcnRoutesResponse"/></returns>
        public DescribeVpnGatewayCcnRoutesResponse DescribeVpnGatewayCcnRoutesSync(DescribeVpnGatewayCcnRoutesRequest req)
        {
             JsonResponseModel<DescribeVpnGatewayCcnRoutesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVpnGatewayCcnRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpnGatewayCcnRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query destination routes of a route-based VPN gateway.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpnGatewayRoutesRequest"/></param>
        /// <returns><see cref="DescribeVpnGatewayRoutesResponse"/></returns>
        public async Task<DescribeVpnGatewayRoutesResponse> DescribeVpnGatewayRoutes(DescribeVpnGatewayRoutesRequest req)
        {
             JsonResponseModel<DescribeVpnGatewayRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVpnGatewayRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpnGatewayRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query destination routes of a route-based VPN gateway.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpnGatewayRoutesRequest"/></param>
        /// <returns><see cref="DescribeVpnGatewayRoutesResponse"/></returns>
        public DescribeVpnGatewayRoutesResponse DescribeVpnGatewayRoutesSync(DescribeVpnGatewayRoutesRequest req)
        {
             JsonResponseModel<DescribeVpnGatewayRoutesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVpnGatewayRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpnGatewayRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeVpnGateways) is used to query the VPN gateway list.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpnGatewaysRequest"/></param>
        /// <returns><see cref="DescribeVpnGatewaysResponse"/></returns>
        public async Task<DescribeVpnGatewaysResponse> DescribeVpnGateways(DescribeVpnGatewaysRequest req)
        {
             JsonResponseModel<DescribeVpnGatewaysResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVpnGateways");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpnGatewaysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeVpnGateways) is used to query the VPN gateway list.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpnGatewaysRequest"/></param>
        /// <returns><see cref="DescribeVpnGatewaysResponse"/></returns>
        public DescribeVpnGatewaysResponse DescribeVpnGatewaysSync(DescribeVpnGatewaysRequest req)
        {
             JsonResponseModel<DescribeVpnGatewaysResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVpnGateways");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpnGatewaysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DetachCcnInstances) is used to unbind a specified network instance from a CCN instance.<br />
        /// After unbinding the network instance, the corresponding routing policy will also be deleted.
        /// </summary>
        /// <param name="req"><see cref="DetachCcnInstancesRequest"/></param>
        /// <returns><see cref="DetachCcnInstancesResponse"/></returns>
        public async Task<DetachCcnInstancesResponse> DetachCcnInstances(DetachCcnInstancesRequest req)
        {
             JsonResponseModel<DetachCcnInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetachCcnInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachCcnInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DetachCcnInstances) is used to unbind a specified network instance from a CCN instance.<br />
        /// After unbinding the network instance, the corresponding routing policy will also be deleted.
        /// </summary>
        /// <param name="req"><see cref="DetachCcnInstancesRequest"/></param>
        /// <returns><see cref="DetachCcnInstancesResponse"/></returns>
        public DetachCcnInstancesResponse DetachCcnInstancesSync(DetachCcnInstancesRequest req)
        {
             JsonResponseModel<DetachCcnInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DetachCcnInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachCcnInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a Classiclink.
        /// >?This API is async. You can call the [`DescribeVpcTaskResult`](https://intl.cloud.tencent.com/document/api/215/59037?from_cn_redirect=1) API to query the task result. When the task is completed, you can continue other tasks.
        /// >
        /// </summary>
        /// <param name="req"><see cref="DetachClassicLinkVpcRequest"/></param>
        /// <returns><see cref="DetachClassicLinkVpcResponse"/></returns>
        public async Task<DetachClassicLinkVpcResponse> DetachClassicLinkVpc(DetachClassicLinkVpcRequest req)
        {
             JsonResponseModel<DetachClassicLinkVpcResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetachClassicLinkVpc");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachClassicLinkVpcResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a Classiclink.
        /// >?This API is async. You can call the [`DescribeVpcTaskResult`](https://intl.cloud.tencent.com/document/api/215/59037?from_cn_redirect=1) API to query the task result. When the task is completed, you can continue other tasks.
        /// >
        /// </summary>
        /// <param name="req"><see cref="DetachClassicLinkVpcRequest"/></param>
        /// <returns><see cref="DetachClassicLinkVpcResponse"/></returns>
        public DetachClassicLinkVpcResponse DetachClassicLinkVpcSync(DetachClassicLinkVpcRequest req)
        {
             JsonResponseModel<DetachClassicLinkVpcResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DetachClassicLinkVpc");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachClassicLinkVpcResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind an ENI from a CVM.
        /// This API is completed asynchronously. If you need to query the execution result of an async task, please use the `RequestId` returned by this API to poll the `DescribeVpcTaskResult` API.
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
        /// This API is used to unbind an ENI from a CVM.
        /// This API is completed asynchronously. If you need to query the execution result of an async task, please use the `RequestId` returned by this API to poll the `DescribeVpcTaskResult` API.
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
        /// This API is used to disassociate a snapshot policy with instances.
        /// </summary>
        /// <param name="req"><see cref="DetachSnapshotInstancesRequest"/></param>
        /// <returns><see cref="DetachSnapshotInstancesResponse"/></returns>
        public async Task<DetachSnapshotInstancesResponse> DetachSnapshotInstances(DetachSnapshotInstancesRequest req)
        {
             JsonResponseModel<DetachSnapshotInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetachSnapshotInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachSnapshotInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disassociate a snapshot policy with instances.
        /// </summary>
        /// <param name="req"><see cref="DetachSnapshotInstancesRequest"/></param>
        /// <returns><see cref="DetachSnapshotInstancesResponse"/></returns>
        public DetachSnapshotInstancesResponse DetachSnapshotInstancesSync(DetachSnapshotInstancesRequest req)
        {
             JsonResponseModel<DetachSnapshotInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DetachSnapshotInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachSnapshotInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DisableCcnRoutes) is used to disable CCN routes that are already enabled.
        /// </summary>
        /// <param name="req"><see cref="DisableCcnRoutesRequest"/></param>
        /// <returns><see cref="DisableCcnRoutesResponse"/></returns>
        public async Task<DisableCcnRoutesResponse> DisableCcnRoutes(DisableCcnRoutesRequest req)
        {
             JsonResponseModel<DisableCcnRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableCcnRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableCcnRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DisableCcnRoutes) is used to disable CCN routes that are already enabled.
        /// </summary>
        /// <param name="req"><see cref="DisableCcnRoutesRequest"/></param>
        /// <returns><see cref="DisableCcnRoutesResponse"/></returns>
        public DisableCcnRoutesResponse DisableCcnRoutesSync(DisableCcnRoutesRequest req)
        {
             JsonResponseModel<DisableCcnRoutesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableCcnRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableCcnRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable flow log.
        /// </summary>
        /// <param name="req"><see cref="DisableFlowLogsRequest"/></param>
        /// <returns><see cref="DisableFlowLogsResponse"/></returns>
        public async Task<DisableFlowLogsResponse> DisableFlowLogs(DisableFlowLogsRequest req)
        {
             JsonResponseModel<DisableFlowLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableFlowLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableFlowLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable flow log.
        /// </summary>
        /// <param name="req"><see cref="DisableFlowLogsRequest"/></param>
        /// <returns><see cref="DisableFlowLogsResponse"/></returns>
        public DisableFlowLogsResponse DisableFlowLogsSync(DisableFlowLogsRequest req)
        {
             JsonResponseModel<DisableFlowLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableFlowLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableFlowLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable gateway traffic monitor.
        /// </summary>
        /// <param name="req"><see cref="DisableGatewayFlowMonitorRequest"/></param>
        /// <returns><see cref="DisableGatewayFlowMonitorResponse"/></returns>
        public async Task<DisableGatewayFlowMonitorResponse> DisableGatewayFlowMonitor(DisableGatewayFlowMonitorRequest req)
        {
             JsonResponseModel<DisableGatewayFlowMonitorResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableGatewayFlowMonitor");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableGatewayFlowMonitorResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable gateway traffic monitor.
        /// </summary>
        /// <param name="req"><see cref="DisableGatewayFlowMonitorRequest"/></param>
        /// <returns><see cref="DisableGatewayFlowMonitorResponse"/></returns>
        public DisableGatewayFlowMonitorResponse DisableGatewayFlowMonitorSync(DisableGatewayFlowMonitorRequest req)
        {
             JsonResponseModel<DisableGatewayFlowMonitorResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableGatewayFlowMonitor");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableGatewayFlowMonitorResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable specified snapshot policies.
        /// </summary>
        /// <param name="req"><see cref="DisableSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="DisableSnapshotPoliciesResponse"/></returns>
        public async Task<DisableSnapshotPoliciesResponse> DisableSnapshotPolicies(DisableSnapshotPoliciesRequest req)
        {
             JsonResponseModel<DisableSnapshotPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableSnapshotPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableSnapshotPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable specified snapshot policies.
        /// </summary>
        /// <param name="req"><see cref="DisableSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="DisableSnapshotPoliciesResponse"/></returns>
        public DisableSnapshotPoliciesResponse DisableSnapshotPoliciesSync(DisableSnapshotPoliciesRequest req)
        {
             JsonResponseModel<DisableSnapshotPoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableSnapshotPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableSnapshotPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind an [Elastic IP](https://intl.cloud.tencent.com/document/product/213/1941?from_cn_redirect=1) (EIP for short).
        /// * This API supports unbinding an EIP from CVM instances and ENIs.
        /// * This API does not support unbinding an EIP from a NAT Gateway. To unbind an EIP from a NAT Gateway, use the [`DisassociateNatGatewayAddress`](https://intl.cloud.tencent.com/document/api/215/36716?from_cn_redirect=1) API.
        /// * Only EIPs in BIND or BIND_ENI status can be unbound.
        /// * Blocked EIPs cannot be unbound.
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
        /// This API is used to unbind an [Elastic IP](https://intl.cloud.tencent.com/document/product/213/1941?from_cn_redirect=1) (EIP for short).
        /// * This API supports unbinding an EIP from CVM instances and ENIs.
        /// * This API does not support unbinding an EIP from a NAT Gateway. To unbind an EIP from a NAT Gateway, use the [`DisassociateNatGatewayAddress`](https://intl.cloud.tencent.com/document/api/215/36716?from_cn_redirect=1) API.
        /// * Only EIPs in BIND or BIND_ENI status can be unbound.
        /// * Blocked EIPs cannot be unbound.
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
        /// This API is used to unbind a direct connect gateway from a NAT Gateway. After unbinding, the direct connect gateway cannot access internet through the NAT Gateway.
        /// </summary>
        /// <param name="req"><see cref="DisassociateDirectConnectGatewayNatGatewayRequest"/></param>
        /// <returns><see cref="DisassociateDirectConnectGatewayNatGatewayResponse"/></returns>
        public async Task<DisassociateDirectConnectGatewayNatGatewayResponse> DisassociateDirectConnectGatewayNatGateway(DisassociateDirectConnectGatewayNatGatewayRequest req)
        {
             JsonResponseModel<DisassociateDirectConnectGatewayNatGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisassociateDirectConnectGatewayNatGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateDirectConnectGatewayNatGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind a direct connect gateway from a NAT Gateway. After unbinding, the direct connect gateway cannot access internet through the NAT Gateway.
        /// </summary>
        /// <param name="req"><see cref="DisassociateDirectConnectGatewayNatGatewayRequest"/></param>
        /// <returns><see cref="DisassociateDirectConnectGatewayNatGatewayResponse"/></returns>
        public DisassociateDirectConnectGatewayNatGatewayResponse DisassociateDirectConnectGatewayNatGatewaySync(DisassociateDirectConnectGatewayNatGatewayRequest req)
        {
             JsonResponseModel<DisassociateDirectConnectGatewayNatGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisassociateDirectConnectGatewayNatGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateDirectConnectGatewayNatGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind an EIP from a NAT gateway.
        /// </summary>
        /// <param name="req"><see cref="DisassociateNatGatewayAddressRequest"/></param>
        /// <returns><see cref="DisassociateNatGatewayAddressResponse"/></returns>
        public async Task<DisassociateNatGatewayAddressResponse> DisassociateNatGatewayAddress(DisassociateNatGatewayAddressRequest req)
        {
             JsonResponseModel<DisassociateNatGatewayAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisassociateNatGatewayAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateNatGatewayAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind an EIP from a NAT gateway.
        /// </summary>
        /// <param name="req"><see cref="DisassociateNatGatewayAddressRequest"/></param>
        /// <returns><see cref="DisassociateNatGatewayAddressResponse"/></returns>
        public DisassociateNatGatewayAddressResponse DisassociateNatGatewayAddressSync(DisassociateNatGatewayAddressRequest req)
        {
             JsonResponseModel<DisassociateNatGatewayAddressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisassociateNatGatewayAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateNatGatewayAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disassociate a network ACL from subnets in a VPC instance.
        /// </summary>
        /// <param name="req"><see cref="DisassociateNetworkAclSubnetsRequest"/></param>
        /// <returns><see cref="DisassociateNetworkAclSubnetsResponse"/></returns>
        public async Task<DisassociateNetworkAclSubnetsResponse> DisassociateNetworkAclSubnets(DisassociateNetworkAclSubnetsRequest req)
        {
             JsonResponseModel<DisassociateNetworkAclSubnetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisassociateNetworkAclSubnets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateNetworkAclSubnetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disassociate a network ACL from subnets in a VPC instance.
        /// </summary>
        /// <param name="req"><see cref="DisassociateNetworkAclSubnetsRequest"/></param>
        /// <returns><see cref="DisassociateNetworkAclSubnetsResponse"/></returns>
        public DisassociateNetworkAclSubnetsResponse DisassociateNetworkAclSubnetsSync(DisassociateNetworkAclSubnetsRequest req)
        {
             JsonResponseModel<DisassociateNetworkAclSubnetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisassociateNetworkAclSubnets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateNetworkAclSubnetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DisassociateNetworkInterfaceSecurityGroups) is used to detach (or fully detach if possible) a security group from an ENI.
        /// </summary>
        /// <param name="req"><see cref="DisassociateNetworkInterfaceSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateNetworkInterfaceSecurityGroupsResponse"/></returns>
        public async Task<DisassociateNetworkInterfaceSecurityGroupsResponse> DisassociateNetworkInterfaceSecurityGroups(DisassociateNetworkInterfaceSecurityGroupsRequest req)
        {
             JsonResponseModel<DisassociateNetworkInterfaceSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisassociateNetworkInterfaceSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateNetworkInterfaceSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DisassociateNetworkInterfaceSecurityGroups) is used to detach (or fully detach if possible) a security group from an ENI.
        /// </summary>
        /// <param name="req"><see cref="DisassociateNetworkInterfaceSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateNetworkInterfaceSecurityGroupsResponse"/></returns>
        public DisassociateNetworkInterfaceSecurityGroupsResponse DisassociateNetworkInterfaceSecurityGroupsSync(DisassociateNetworkInterfaceSecurityGroupsRequest req)
        {
             JsonResponseModel<DisassociateNetworkInterfaceSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisassociateNetworkInterfaceSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateNetworkInterfaceSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind an endpoint from a security group.
        /// </summary>
        /// <param name="req"><see cref="DisassociateVpcEndPointSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateVpcEndPointSecurityGroupsResponse"/></returns>
        public async Task<DisassociateVpcEndPointSecurityGroupsResponse> DisassociateVpcEndPointSecurityGroups(DisassociateVpcEndPointSecurityGroupsRequest req)
        {
             JsonResponseModel<DisassociateVpcEndPointSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisassociateVpcEndPointSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateVpcEndPointSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind an endpoint from a security group.
        /// </summary>
        /// <param name="req"><see cref="DisassociateVpcEndPointSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateVpcEndPointSecurityGroupsResponse"/></returns>
        public DisassociateVpcEndPointSecurityGroupsResponse DisassociateVpcEndPointSecurityGroupsSync(DisassociateVpcEndPointSecurityGroupsRequest req)
        {
             JsonResponseModel<DisassociateVpcEndPointSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisassociateVpcEndPointSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateVpcEndPointSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DownloadCustomerGatewayConfiguration) is used to download a VPN tunnel configuration.
        /// </summary>
        /// <param name="req"><see cref="DownloadCustomerGatewayConfigurationRequest"/></param>
        /// <returns><see cref="DownloadCustomerGatewayConfigurationResponse"/></returns>
        public async Task<DownloadCustomerGatewayConfigurationResponse> DownloadCustomerGatewayConfiguration(DownloadCustomerGatewayConfigurationRequest req)
        {
             JsonResponseModel<DownloadCustomerGatewayConfigurationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DownloadCustomerGatewayConfiguration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownloadCustomerGatewayConfigurationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DownloadCustomerGatewayConfiguration) is used to download a VPN tunnel configuration.
        /// </summary>
        /// <param name="req"><see cref="DownloadCustomerGatewayConfigurationRequest"/></param>
        /// <returns><see cref="DownloadCustomerGatewayConfigurationResponse"/></returns>
        public DownloadCustomerGatewayConfigurationResponse DownloadCustomerGatewayConfigurationSync(DownloadCustomerGatewayConfigurationRequest req)
        {
             JsonResponseModel<DownloadCustomerGatewayConfigurationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DownloadCustomerGatewayConfiguration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownloadCustomerGatewayConfigurationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (EnableCcnRoutes) is used to enable CCN routes that are already added.<br />
        /// This API is used to verify whether there will be conflict with an existing route after a CCN route is enabled. If there is a conflict, the route will not be enabled, and the process will fail. When a conflict occurs, you must disable the conflicting route before you can enable the desired route.
        /// </summary>
        /// <param name="req"><see cref="EnableCcnRoutesRequest"/></param>
        /// <returns><see cref="EnableCcnRoutesResponse"/></returns>
        public async Task<EnableCcnRoutesResponse> EnableCcnRoutes(EnableCcnRoutesRequest req)
        {
             JsonResponseModel<EnableCcnRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableCcnRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableCcnRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (EnableCcnRoutes) is used to enable CCN routes that are already added.<br />
        /// This API is used to verify whether there will be conflict with an existing route after a CCN route is enabled. If there is a conflict, the route will not be enabled, and the process will fail. When a conflict occurs, you must disable the conflicting route before you can enable the desired route.
        /// </summary>
        /// <param name="req"><see cref="EnableCcnRoutesRequest"/></param>
        /// <returns><see cref="EnableCcnRoutesResponse"/></returns>
        public EnableCcnRoutesResponse EnableCcnRoutesSync(EnableCcnRoutesRequest req)
        {
             JsonResponseModel<EnableCcnRoutesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableCcnRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableCcnRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable flow log.
        /// </summary>
        /// <param name="req"><see cref="EnableFlowLogsRequest"/></param>
        /// <returns><see cref="EnableFlowLogsResponse"/></returns>
        public async Task<EnableFlowLogsResponse> EnableFlowLogs(EnableFlowLogsRequest req)
        {
             JsonResponseModel<EnableFlowLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableFlowLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableFlowLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable flow log.
        /// </summary>
        /// <param name="req"><see cref="EnableFlowLogsRequest"/></param>
        /// <returns><see cref="EnableFlowLogsResponse"/></returns>
        public EnableFlowLogsResponse EnableFlowLogsSync(EnableFlowLogsRequest req)
        {
             JsonResponseModel<EnableFlowLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableFlowLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableFlowLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable gateway traffic monitor.
        /// </summary>
        /// <param name="req"><see cref="EnableGatewayFlowMonitorRequest"/></param>
        /// <returns><see cref="EnableGatewayFlowMonitorResponse"/></returns>
        public async Task<EnableGatewayFlowMonitorResponse> EnableGatewayFlowMonitor(EnableGatewayFlowMonitorRequest req)
        {
             JsonResponseModel<EnableGatewayFlowMonitorResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableGatewayFlowMonitor");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableGatewayFlowMonitorResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable gateway traffic monitor.
        /// </summary>
        /// <param name="req"><see cref="EnableGatewayFlowMonitorRequest"/></param>
        /// <returns><see cref="EnableGatewayFlowMonitorResponse"/></returns>
        public EnableGatewayFlowMonitorResponse EnableGatewayFlowMonitorSync(EnableGatewayFlowMonitorRequest req)
        {
             JsonResponseModel<EnableGatewayFlowMonitorResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableGatewayFlowMonitor");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableGatewayFlowMonitorResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable specified snapshot policies. 
        /// </summary>
        /// <param name="req"><see cref="EnableSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="EnableSnapshotPoliciesResponse"/></returns>
        public async Task<EnableSnapshotPoliciesResponse> EnableSnapshotPolicies(EnableSnapshotPoliciesRequest req)
        {
             JsonResponseModel<EnableSnapshotPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableSnapshotPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableSnapshotPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable specified snapshot policies. 
        /// </summary>
        /// <param name="req"><see cref="EnableSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="EnableSnapshotPoliciesResponse"/></returns>
        public EnableSnapshotPoliciesResponse EnableSnapshotPoliciesSync(EnableSnapshotPoliciesRequest req)
        {
             JsonResponseModel<EnableSnapshotPoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableSnapshotPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableSnapshotPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to determine whether to accept the request of connecting with an endpoint.
        /// </summary>
        /// <param name="req"><see cref="EnableVpcEndPointConnectRequest"/></param>
        /// <returns><see cref="EnableVpcEndPointConnectResponse"/></returns>
        public async Task<EnableVpcEndPointConnectResponse> EnableVpcEndPointConnect(EnableVpcEndPointConnectRequest req)
        {
             JsonResponseModel<EnableVpcEndPointConnectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableVpcEndPointConnect");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableVpcEndPointConnectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to determine whether to accept the request of connecting with an endpoint.
        /// </summary>
        /// <param name="req"><see cref="EnableVpcEndPointConnectRequest"/></param>
        /// <returns><see cref="EnableVpcEndPointConnectResponse"/></returns>
        public EnableVpcEndPointConnectResponse EnableVpcEndPointConnectSync(EnableVpcEndPointConnectRequest req)
        {
             JsonResponseModel<EnableVpcEndPointConnectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableVpcEndPointConnect");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableVpcEndPointConnectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the bandwidth limits of a CCN instance. Monthly-subscribed CCNs only support Inter-region Bandwidth Limits, while the pay-as-you-go CCNs support both the Inter-region Bandwidth Limits and Region Outbound Bandwidth Limits. 
        /// </summary>
        /// <param name="req"><see cref="GetCcnRegionBandwidthLimitsRequest"/></param>
        /// <returns><see cref="GetCcnRegionBandwidthLimitsResponse"/></returns>
        public async Task<GetCcnRegionBandwidthLimitsResponse> GetCcnRegionBandwidthLimits(GetCcnRegionBandwidthLimitsRequest req)
        {
             JsonResponseModel<GetCcnRegionBandwidthLimitsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetCcnRegionBandwidthLimits");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetCcnRegionBandwidthLimitsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the bandwidth limits of a CCN instance. Monthly-subscribed CCNs only support Inter-region Bandwidth Limits, while the pay-as-you-go CCNs support both the Inter-region Bandwidth Limits and Region Outbound Bandwidth Limits. 
        /// </summary>
        /// <param name="req"><see cref="GetCcnRegionBandwidthLimitsRequest"/></param>
        /// <returns><see cref="GetCcnRegionBandwidthLimitsResponse"/></returns>
        public GetCcnRegionBandwidthLimitsResponse GetCcnRegionBandwidthLimitsSync(GetCcnRegionBandwidthLimitsRequest req)
        {
             JsonResponseModel<GetCcnRegionBandwidthLimitsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetCcnRegionBandwidthLimits");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetCcnRegionBandwidthLimitsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind an EIP to an HAVIP. <br />
        /// This API is completed asynchronously. If you need to query the execution result of an async task, please use the `RequestId` returned by this API to poll the `DescribeVpcTaskResult` API.
        /// </summary>
        /// <param name="req"><see cref="HaVipAssociateAddressIpRequest"/></param>
        /// <returns><see cref="HaVipAssociateAddressIpResponse"/></returns>
        public async Task<HaVipAssociateAddressIpResponse> HaVipAssociateAddressIp(HaVipAssociateAddressIpRequest req)
        {
             JsonResponseModel<HaVipAssociateAddressIpResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "HaVipAssociateAddressIp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<HaVipAssociateAddressIpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind an EIP to an HAVIP. <br />
        /// This API is completed asynchronously. If you need to query the execution result of an async task, please use the `RequestId` returned by this API to poll the `DescribeVpcTaskResult` API.
        /// </summary>
        /// <param name="req"><see cref="HaVipAssociateAddressIpRequest"/></param>
        /// <returns><see cref="HaVipAssociateAddressIpResponse"/></returns>
        public HaVipAssociateAddressIpResponse HaVipAssociateAddressIpSync(HaVipAssociateAddressIpRequest req)
        {
             JsonResponseModel<HaVipAssociateAddressIpResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "HaVipAssociateAddressIp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<HaVipAssociateAddressIpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind an EIP from an HAVIP. <br />
        /// This API is completed asynchronously. If you need to query the execution result of an async task, please use the `RequestId` returned by this API to poll the `DescribeVpcTaskResult` API.
        /// </summary>
        /// <param name="req"><see cref="HaVipDisassociateAddressIpRequest"/></param>
        /// <returns><see cref="HaVipDisassociateAddressIpResponse"/></returns>
        public async Task<HaVipDisassociateAddressIpResponse> HaVipDisassociateAddressIp(HaVipDisassociateAddressIpRequest req)
        {
             JsonResponseModel<HaVipDisassociateAddressIpResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "HaVipDisassociateAddressIp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<HaVipDisassociateAddressIpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind an EIP from an HAVIP. <br />
        /// This API is completed asynchronously. If you need to query the execution result of an async task, please use the `RequestId` returned by this API to poll the `DescribeVpcTaskResult` API.
        /// </summary>
        /// <param name="req"><see cref="HaVipDisassociateAddressIpRequest"/></param>
        /// <returns><see cref="HaVipDisassociateAddressIpResponse"/></returns>
        public HaVipDisassociateAddressIpResponse HaVipDisassociateAddressIpSync(HaVipDisassociateAddressIpRequest req)
        {
             JsonResponseModel<HaVipDisassociateAddressIpResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "HaVipDisassociateAddressIp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<HaVipDisassociateAddressIpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the price of creating a direct connect gateway.
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateDirectConnectGatewayRequest"/></param>
        /// <returns><see cref="InquirePriceCreateDirectConnectGatewayResponse"/></returns>
        public async Task<InquirePriceCreateDirectConnectGatewayResponse> InquirePriceCreateDirectConnectGateway(InquirePriceCreateDirectConnectGatewayRequest req)
        {
             JsonResponseModel<InquirePriceCreateDirectConnectGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquirePriceCreateDirectConnectGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquirePriceCreateDirectConnectGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the price of creating a direct connect gateway.
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateDirectConnectGatewayRequest"/></param>
        /// <returns><see cref="InquirePriceCreateDirectConnectGatewayResponse"/></returns>
        public InquirePriceCreateDirectConnectGatewayResponse InquirePriceCreateDirectConnectGatewaySync(InquirePriceCreateDirectConnectGatewayRequest req)
        {
             JsonResponseModel<InquirePriceCreateDirectConnectGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquirePriceCreateDirectConnectGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquirePriceCreateDirectConnectGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (InquiryPriceRenewVpnGateway) is used to query the price for VPN gateway renewal. Currently, only querying prices for IPSEC-type gateways is supported.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRenewVpnGatewayRequest"/></param>
        /// <returns><see cref="InquiryPriceRenewVpnGatewayResponse"/></returns>
        public async Task<InquiryPriceRenewVpnGatewayResponse> InquiryPriceRenewVpnGateway(InquiryPriceRenewVpnGatewayRequest req)
        {
             JsonResponseModel<InquiryPriceRenewVpnGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceRenewVpnGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceRenewVpnGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (InquiryPriceRenewVpnGateway) is used to query the price for VPN gateway renewal. Currently, only querying prices for IPSEC-type gateways is supported.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRenewVpnGatewayRequest"/></param>
        /// <returns><see cref="InquiryPriceRenewVpnGatewayResponse"/></returns>
        public InquiryPriceRenewVpnGatewayResponse InquiryPriceRenewVpnGatewaySync(InquiryPriceRenewVpnGatewayRequest req)
        {
             JsonResponseModel<InquiryPriceRenewVpnGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceRenewVpnGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceRenewVpnGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (InquiryPriceResetVpnGatewayInternetMaxBandwidth) is used to query the price for adjusting the bandwidth cap of a VPN gateway.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceResetVpnGatewayInternetMaxBandwidthRequest"/></param>
        /// <returns><see cref="InquiryPriceResetVpnGatewayInternetMaxBandwidthResponse"/></returns>
        public async Task<InquiryPriceResetVpnGatewayInternetMaxBandwidthResponse> InquiryPriceResetVpnGatewayInternetMaxBandwidth(InquiryPriceResetVpnGatewayInternetMaxBandwidthRequest req)
        {
             JsonResponseModel<InquiryPriceResetVpnGatewayInternetMaxBandwidthResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceResetVpnGatewayInternetMaxBandwidth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceResetVpnGatewayInternetMaxBandwidthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (InquiryPriceResetVpnGatewayInternetMaxBandwidth) is used to query the price for adjusting the bandwidth cap of a VPN gateway.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceResetVpnGatewayInternetMaxBandwidthRequest"/></param>
        /// <returns><see cref="InquiryPriceResetVpnGatewayInternetMaxBandwidthResponse"/></returns>
        public InquiryPriceResetVpnGatewayInternetMaxBandwidthResponse InquiryPriceResetVpnGatewayInternetMaxBandwidthSync(InquiryPriceResetVpnGatewayInternetMaxBandwidthRequest req)
        {
             JsonResponseModel<InquiryPriceResetVpnGatewayInternetMaxBandwidthResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceResetVpnGatewayInternetMaxBandwidth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceResetVpnGatewayInternetMaxBandwidthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to migrate ENIs.
        /// This API is completed asynchronously. If you need to query the execution result of an async task, please use the `RequestId` returned by this API to poll the `DescribeVpcTaskResult` API.
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
        /// This API is used to migrate ENIs.
        /// This API is completed asynchronously. If you need to query the execution result of an async task, please use the `RequestId` returned by this API to poll the `DescribeVpcTaskResult` API.
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
        ///  This API is used to migrate the private IPs between ENIs.
        /// * This API is used to migrate a private IP from one ENI to another. Primary IPs cannot be migrated.
        /// * The source and destination ENIs must be in the same subnet.  
        /// 
        /// This API is completed asynchronously. If you need to query the execution result of an async task, please use the `RequestId` returned by this API to poll the `DescribeVpcTaskResult` API.
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
        ///  This API is used to migrate the private IPs between ENIs.
        /// * This API is used to migrate a private IP from one ENI to another. Primary IPs cannot be migrated.
        /// * The source and destination ENIs must be in the same subnet.  
        /// 
        /// This API is completed asynchronously. If you need to query the execution result of an async task, please use the `RequestId` returned by this API to poll the `DescribeVpcTaskResult` API.
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
        /// This API (ModifyAddressAttribute) is used to modify the name of an [Elastic IP](https://intl.cloud.tencent.com/document/product/213/1941?from_cn_redirect=1).
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
        /// This API (ModifyAddressAttribute) is used to modify the name of an [Elastic IP](https://intl.cloud.tencent.com/document/product/213/1941?from_cn_redirect=1).
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
        /// This API is used to adjust the network billing mode of an EIP. Please note that it's available to users whose network fees are billed on IPs but not CVMs.
        /// * The network billing mode can be switched between `BANDWIDTH_PREPAID_BY_MONTH` and `TRAFFIC_POSTPAID_BY_HOUR`.
        /// * The network billing mode for each EIP be changed for up to twice.
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressInternetChargeTypeRequest"/></param>
        /// <returns><see cref="ModifyAddressInternetChargeTypeResponse"/></returns>
        public async Task<ModifyAddressInternetChargeTypeResponse> ModifyAddressInternetChargeType(ModifyAddressInternetChargeTypeRequest req)
        {
             JsonResponseModel<ModifyAddressInternetChargeTypeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAddressInternetChargeType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAddressInternetChargeTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to adjust the network billing mode of an EIP. Please note that it's available to users whose network fees are billed on IPs but not CVMs.
        /// * The network billing mode can be switched between `BANDWIDTH_PREPAID_BY_MONTH` and `TRAFFIC_POSTPAID_BY_HOUR`.
        /// * The network billing mode for each EIP be changed for up to twice.
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressInternetChargeTypeRequest"/></param>
        /// <returns><see cref="ModifyAddressInternetChargeTypeResponse"/></returns>
        public ModifyAddressInternetChargeTypeResponse ModifyAddressInternetChargeTypeSync(ModifyAddressInternetChargeTypeRequest req)
        {
             JsonResponseModel<ModifyAddressInternetChargeTypeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAddressInternetChargeType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAddressInternetChargeTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyAddressTemplateAttribute) is used to modify an IP address template.
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressTemplateAttributeRequest"/></param>
        /// <returns><see cref="ModifyAddressTemplateAttributeResponse"/></returns>
        public async Task<ModifyAddressTemplateAttributeResponse> ModifyAddressTemplateAttribute(ModifyAddressTemplateAttributeRequest req)
        {
             JsonResponseModel<ModifyAddressTemplateAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAddressTemplateAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAddressTemplateAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyAddressTemplateAttribute) is used to modify an IP address template.
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressTemplateAttributeRequest"/></param>
        /// <returns><see cref="ModifyAddressTemplateAttributeResponse"/></returns>
        public ModifyAddressTemplateAttributeResponse ModifyAddressTemplateAttributeSync(ModifyAddressTemplateAttributeRequest req)
        {
             JsonResponseModel<ModifyAddressTemplateAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAddressTemplateAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAddressTemplateAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyAddressTemplateGroupAttribute) is used to modify an IP address template group.
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressTemplateGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyAddressTemplateGroupAttributeResponse"/></returns>
        public async Task<ModifyAddressTemplateGroupAttributeResponse> ModifyAddressTemplateGroupAttribute(ModifyAddressTemplateGroupAttributeRequest req)
        {
             JsonResponseModel<ModifyAddressTemplateGroupAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAddressTemplateGroupAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAddressTemplateGroupAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyAddressTemplateGroupAttribute) is used to modify an IP address template group.
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressTemplateGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyAddressTemplateGroupAttributeResponse"/></returns>
        public ModifyAddressTemplateGroupAttributeResponse ModifyAddressTemplateGroupAttributeSync(ModifyAddressTemplateGroupAttributeRequest req)
        {
             JsonResponseModel<ModifyAddressTemplateGroupAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAddressTemplateGroupAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAddressTemplateGroupAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to adjust the bandwidth of [Elastic IP](https://intl.cloud.tencent.com/document/product/213/1941?from_cn_redirect=1), including EIP billed on a pay-as-you-go, monthly subscription, and bandwidth package basis.
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
        /// This API is used to adjust the bandwidth of [Elastic IP](https://intl.cloud.tencent.com/document/product/213/1941?from_cn_redirect=1), including EIP billed on a pay-as-you-go, monthly subscription, and bandwidth package basis.
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
        /// This API is used to batch modify (add or delete) secondary CIDR blocks.
        /// </summary>
        /// <param name="req"><see cref="ModifyAssistantCidrRequest"/></param>
        /// <returns><see cref="ModifyAssistantCidrResponse"/></returns>
        public async Task<ModifyAssistantCidrResponse> ModifyAssistantCidr(ModifyAssistantCidrRequest req)
        {
             JsonResponseModel<ModifyAssistantCidrResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAssistantCidr");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAssistantCidrResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to batch modify (add or delete) secondary CIDR blocks.
        /// </summary>
        /// <param name="req"><see cref="ModifyAssistantCidrRequest"/></param>
        /// <returns><see cref="ModifyAssistantCidrResponse"/></returns>
        public ModifyAssistantCidrResponse ModifyAssistantCidrSync(ModifyAssistantCidrRequest req)
        {
             JsonResponseModel<ModifyAssistantCidrResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAssistantCidr");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAssistantCidrResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of a bandwidth package, including the bandwidth package name, and so on.
        /// </summary>
        /// <param name="req"><see cref="ModifyBandwidthPackageAttributeRequest"/></param>
        /// <returns><see cref="ModifyBandwidthPackageAttributeResponse"/></returns>
        public async Task<ModifyBandwidthPackageAttributeResponse> ModifyBandwidthPackageAttribute(ModifyBandwidthPackageAttributeRequest req)
        {
             JsonResponseModel<ModifyBandwidthPackageAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBandwidthPackageAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBandwidthPackageAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of a bandwidth package, including the bandwidth package name, and so on.
        /// </summary>
        /// <param name="req"><see cref="ModifyBandwidthPackageAttributeRequest"/></param>
        /// <returns><see cref="ModifyBandwidthPackageAttributeResponse"/></returns>
        public ModifyBandwidthPackageAttributeResponse ModifyBandwidthPackageAttributeSync(ModifyBandwidthPackageAttributeRequest req)
        {
             JsonResponseModel<ModifyBandwidthPackageAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyBandwidthPackageAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBandwidthPackageAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify CCN-associated instance attributes. Currently, only the `description` can be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyCcnAttachedInstancesAttributeRequest"/></param>
        /// <returns><see cref="ModifyCcnAttachedInstancesAttributeResponse"/></returns>
        public async Task<ModifyCcnAttachedInstancesAttributeResponse> ModifyCcnAttachedInstancesAttribute(ModifyCcnAttachedInstancesAttributeRequest req)
        {
             JsonResponseModel<ModifyCcnAttachedInstancesAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCcnAttachedInstancesAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCcnAttachedInstancesAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify CCN-associated instance attributes. Currently, only the `description` can be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyCcnAttachedInstancesAttributeRequest"/></param>
        /// <returns><see cref="ModifyCcnAttachedInstancesAttributeResponse"/></returns>
        public ModifyCcnAttachedInstancesAttributeResponse ModifyCcnAttachedInstancesAttributeSync(ModifyCcnAttachedInstancesAttributeRequest req)
        {
             JsonResponseModel<ModifyCcnAttachedInstancesAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCcnAttachedInstancesAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCcnAttachedInstancesAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyCcnAttribute) is used to modify CCN attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyCcnAttributeRequest"/></param>
        /// <returns><see cref="ModifyCcnAttributeResponse"/></returns>
        public async Task<ModifyCcnAttributeResponse> ModifyCcnAttribute(ModifyCcnAttributeRequest req)
        {
             JsonResponseModel<ModifyCcnAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCcnAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCcnAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyCcnAttribute) is used to modify CCN attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyCcnAttributeRequest"/></param>
        /// <returns><see cref="ModifyCcnAttributeResponse"/></returns>
        public ModifyCcnAttributeResponse ModifyCcnAttributeSync(ModifyCcnAttributeRequest req)
        {
             JsonResponseModel<ModifyCcnAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCcnAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCcnAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the bandwidth limit policy of a postpaid CCN instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyCcnRegionBandwidthLimitsTypeRequest"/></param>
        /// <returns><see cref="ModifyCcnRegionBandwidthLimitsTypeResponse"/></returns>
        public async Task<ModifyCcnRegionBandwidthLimitsTypeResponse> ModifyCcnRegionBandwidthLimitsType(ModifyCcnRegionBandwidthLimitsTypeRequest req)
        {
             JsonResponseModel<ModifyCcnRegionBandwidthLimitsTypeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCcnRegionBandwidthLimitsType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCcnRegionBandwidthLimitsTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the bandwidth limit policy of a postpaid CCN instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyCcnRegionBandwidthLimitsTypeRequest"/></param>
        /// <returns><see cref="ModifyCcnRegionBandwidthLimitsTypeResponse"/></returns>
        public ModifyCcnRegionBandwidthLimitsTypeResponse ModifyCcnRegionBandwidthLimitsTypeSync(ModifyCcnRegionBandwidthLimitsTypeRequest req)
        {
             JsonResponseModel<ModifyCcnRegionBandwidthLimitsTypeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCcnRegionBandwidthLimitsType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCcnRegionBandwidthLimitsTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyCustomerGatewayAttribute) is used to modify the customer gateway information.
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomerGatewayAttributeRequest"/></param>
        /// <returns><see cref="ModifyCustomerGatewayAttributeResponse"/></returns>
        public async Task<ModifyCustomerGatewayAttributeResponse> ModifyCustomerGatewayAttribute(ModifyCustomerGatewayAttributeRequest req)
        {
             JsonResponseModel<ModifyCustomerGatewayAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCustomerGatewayAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCustomerGatewayAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyCustomerGatewayAttribute) is used to modify the customer gateway information.
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomerGatewayAttributeRequest"/></param>
        /// <returns><see cref="ModifyCustomerGatewayAttributeResponse"/></returns>
        public ModifyCustomerGatewayAttributeResponse ModifyCustomerGatewayAttributeSync(ModifyCustomerGatewayAttributeRequest req)
        {
             JsonResponseModel<ModifyCustomerGatewayAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCustomerGatewayAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCustomerGatewayAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of a direct connect gateway.
        /// </summary>
        /// <param name="req"><see cref="ModifyDirectConnectGatewayAttributeRequest"/></param>
        /// <returns><see cref="ModifyDirectConnectGatewayAttributeResponse"/></returns>
        public async Task<ModifyDirectConnectGatewayAttributeResponse> ModifyDirectConnectGatewayAttribute(ModifyDirectConnectGatewayAttributeRequest req)
        {
             JsonResponseModel<ModifyDirectConnectGatewayAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDirectConnectGatewayAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDirectConnectGatewayAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of a direct connect gateway.
        /// </summary>
        /// <param name="req"><see cref="ModifyDirectConnectGatewayAttributeRequest"/></param>
        /// <returns><see cref="ModifyDirectConnectGatewayAttributeResponse"/></returns>
        public ModifyDirectConnectGatewayAttributeResponse ModifyDirectConnectGatewayAttributeSync(ModifyDirectConnectGatewayAttributeRequest req)
        {
             JsonResponseModel<ModifyDirectConnectGatewayAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDirectConnectGatewayAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDirectConnectGatewayAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of a flow log.
        /// </summary>
        /// <param name="req"><see cref="ModifyFlowLogAttributeRequest"/></param>
        /// <returns><see cref="ModifyFlowLogAttributeResponse"/></returns>
        public async Task<ModifyFlowLogAttributeResponse> ModifyFlowLogAttribute(ModifyFlowLogAttributeRequest req)
        {
             JsonResponseModel<ModifyFlowLogAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyFlowLogAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyFlowLogAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of a flow log.
        /// </summary>
        /// <param name="req"><see cref="ModifyFlowLogAttributeRequest"/></param>
        /// <returns><see cref="ModifyFlowLogAttributeResponse"/></returns>
        public ModifyFlowLogAttributeResponse ModifyFlowLogAttributeSync(ModifyFlowLogAttributeRequest req)
        {
             JsonResponseModel<ModifyFlowLogAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyFlowLogAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyFlowLogAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to adjust the bandwidth limit of a gateway.
        /// </summary>
        /// <param name="req"><see cref="ModifyGatewayFlowQosRequest"/></param>
        /// <returns><see cref="ModifyGatewayFlowQosResponse"/></returns>
        public async Task<ModifyGatewayFlowQosResponse> ModifyGatewayFlowQos(ModifyGatewayFlowQosRequest req)
        {
             JsonResponseModel<ModifyGatewayFlowQosResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyGatewayFlowQos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyGatewayFlowQosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to adjust the bandwidth limit of a gateway.
        /// </summary>
        /// <param name="req"><see cref="ModifyGatewayFlowQosRequest"/></param>
        /// <returns><see cref="ModifyGatewayFlowQosResponse"/></returns>
        public ModifyGatewayFlowQosResponse ModifyGatewayFlowQosSync(ModifyGatewayFlowQosRequest req)
        {
             JsonResponseModel<ModifyGatewayFlowQosResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyGatewayFlowQos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyGatewayFlowQosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyHaVipAttribute) is used to modify HAVIP attributes.
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
        /// This API (ModifyHaVipAttribute) is used to modify HAVIP attributes.
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
        /// This API (ModifyIpv6AddressesAttribute) is used to modify the private IPv6 address attributes of an ENI.
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
        /// This API (ModifyIpv6AddressesAttribute) is used to modify the private IPv6 address attributes of an ENI.
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
        /// This API is used to modify the local gateway of a CDC instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyLocalGatewayRequest"/></param>
        /// <returns><see cref="ModifyLocalGatewayResponse"/></returns>
        public async Task<ModifyLocalGatewayResponse> ModifyLocalGateway(ModifyLocalGatewayRequest req)
        {
             JsonResponseModel<ModifyLocalGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLocalGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLocalGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the local gateway of a CDC instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyLocalGatewayRequest"/></param>
        /// <returns><see cref="ModifyLocalGatewayResponse"/></returns>
        public ModifyLocalGatewayResponse ModifyLocalGatewaySync(ModifyLocalGatewayRequest req)
        {
             JsonResponseModel<ModifyLocalGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLocalGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLocalGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of a NAT gateway.
        /// </summary>
        /// <param name="req"><see cref="ModifyNatGatewayAttributeRequest"/></param>
        /// <returns><see cref="ModifyNatGatewayAttributeResponse"/></returns>
        public async Task<ModifyNatGatewayAttributeResponse> ModifyNatGatewayAttribute(ModifyNatGatewayAttributeRequest req)
        {
             JsonResponseModel<ModifyNatGatewayAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNatGatewayAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNatGatewayAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of a NAT gateway.
        /// </summary>
        /// <param name="req"><see cref="ModifyNatGatewayAttributeRequest"/></param>
        /// <returns><see cref="ModifyNatGatewayAttributeResponse"/></returns>
        public ModifyNatGatewayAttributeResponse ModifyNatGatewayAttributeSync(ModifyNatGatewayAttributeRequest req)
        {
             JsonResponseModel<ModifyNatGatewayAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyNatGatewayAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNatGatewayAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the port forwarding rule of a NAT gateway.
        /// </summary>
        /// <param name="req"><see cref="ModifyNatGatewayDestinationIpPortTranslationNatRuleRequest"/></param>
        /// <returns><see cref="ModifyNatGatewayDestinationIpPortTranslationNatRuleResponse"/></returns>
        public async Task<ModifyNatGatewayDestinationIpPortTranslationNatRuleResponse> ModifyNatGatewayDestinationIpPortTranslationNatRule(ModifyNatGatewayDestinationIpPortTranslationNatRuleRequest req)
        {
             JsonResponseModel<ModifyNatGatewayDestinationIpPortTranslationNatRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNatGatewayDestinationIpPortTranslationNatRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNatGatewayDestinationIpPortTranslationNatRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the port forwarding rule of a NAT gateway.
        /// </summary>
        /// <param name="req"><see cref="ModifyNatGatewayDestinationIpPortTranslationNatRuleRequest"/></param>
        /// <returns><see cref="ModifyNatGatewayDestinationIpPortTranslationNatRuleResponse"/></returns>
        public ModifyNatGatewayDestinationIpPortTranslationNatRuleResponse ModifyNatGatewayDestinationIpPortTranslationNatRuleSync(ModifyNatGatewayDestinationIpPortTranslationNatRuleRequest req)
        {
             JsonResponseModel<ModifyNatGatewayDestinationIpPortTranslationNatRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyNatGatewayDestinationIpPortTranslationNatRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNatGatewayDestinationIpPortTranslationNatRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a NAT gateway's SNAT forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyNatGatewaySourceIpTranslationNatRuleRequest"/></param>
        /// <returns><see cref="ModifyNatGatewaySourceIpTranslationNatRuleResponse"/></returns>
        public async Task<ModifyNatGatewaySourceIpTranslationNatRuleResponse> ModifyNatGatewaySourceIpTranslationNatRule(ModifyNatGatewaySourceIpTranslationNatRuleRequest req)
        {
             JsonResponseModel<ModifyNatGatewaySourceIpTranslationNatRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNatGatewaySourceIpTranslationNatRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNatGatewaySourceIpTranslationNatRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a NAT gateway's SNAT forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyNatGatewaySourceIpTranslationNatRuleRequest"/></param>
        /// <returns><see cref="ModifyNatGatewaySourceIpTranslationNatRuleResponse"/></returns>
        public ModifyNatGatewaySourceIpTranslationNatRuleResponse ModifyNatGatewaySourceIpTranslationNatRuleSync(ModifyNatGatewaySourceIpTranslationNatRuleRequest req)
        {
             JsonResponseModel<ModifyNatGatewaySourceIpTranslationNatRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyNatGatewaySourceIpTranslationNatRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNatGatewaySourceIpTranslationNatRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyNetDetect) is used to modify network detection parameters.
        /// </summary>
        /// <param name="req"><see cref="ModifyNetDetectRequest"/></param>
        /// <returns><see cref="ModifyNetDetectResponse"/></returns>
        public async Task<ModifyNetDetectResponse> ModifyNetDetect(ModifyNetDetectRequest req)
        {
             JsonResponseModel<ModifyNetDetectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNetDetect");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNetDetectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyNetDetect) is used to modify network detection parameters.
        /// </summary>
        /// <param name="req"><see cref="ModifyNetDetectRequest"/></param>
        /// <returns><see cref="ModifyNetDetectResponse"/></returns>
        public ModifyNetDetectResponse ModifyNetDetectSync(ModifyNetDetectRequest req)
        {
             JsonResponseModel<ModifyNetDetectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyNetDetect");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNetDetectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of a network ACL.
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkAclAttributeRequest"/></param>
        /// <returns><see cref="ModifyNetworkAclAttributeResponse"/></returns>
        public async Task<ModifyNetworkAclAttributeResponse> ModifyNetworkAclAttribute(ModifyNetworkAclAttributeRequest req)
        {
             JsonResponseModel<ModifyNetworkAclAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNetworkAclAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNetworkAclAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of a network ACL.
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkAclAttributeRequest"/></param>
        /// <returns><see cref="ModifyNetworkAclAttributeResponse"/></returns>
        public ModifyNetworkAclAttributeResponse ModifyNetworkAclAttributeSync(ModifyNetworkAclAttributeRequest req)
        {
             JsonResponseModel<ModifyNetworkAclAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyNetworkAclAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNetworkAclAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify (add or delete) the inbound and outbound rules of a network ACL. In `NetworkAclEntrySet` parameters,
        /// * Passing in the new inbound/outbound rules will reset the original rules.
        /// * Passing in the inbound rules will only reset the original inbound rules and not affect the original outbound rules, and vice versa.
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkAclEntriesRequest"/></param>
        /// <returns><see cref="ModifyNetworkAclEntriesResponse"/></returns>
        public async Task<ModifyNetworkAclEntriesResponse> ModifyNetworkAclEntries(ModifyNetworkAclEntriesRequest req)
        {
             JsonResponseModel<ModifyNetworkAclEntriesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNetworkAclEntries");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNetworkAclEntriesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify (add or delete) the inbound and outbound rules of a network ACL. In `NetworkAclEntrySet` parameters,
        /// * Passing in the new inbound/outbound rules will reset the original rules.
        /// * Passing in the inbound rules will only reset the original inbound rules and not affect the original outbound rules, and vice versa.
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkAclEntriesRequest"/></param>
        /// <returns><see cref="ModifyNetworkAclEntriesResponse"/></returns>
        public ModifyNetworkAclEntriesResponse ModifyNetworkAclEntriesSync(ModifyNetworkAclEntriesRequest req)
        {
             JsonResponseModel<ModifyNetworkAclEntriesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyNetworkAclEntries");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNetworkAclEntriesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the in/outbound rules of the network ACL quintuple. In the `NetworkAclQuintupleEntrySet` parameters, `NetworkAclQuintupleEntryId` is required for `NetworkAclQuintupleEntry`.
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkAclQuintupleEntriesRequest"/></param>
        /// <returns><see cref="ModifyNetworkAclQuintupleEntriesResponse"/></returns>
        public async Task<ModifyNetworkAclQuintupleEntriesResponse> ModifyNetworkAclQuintupleEntries(ModifyNetworkAclQuintupleEntriesRequest req)
        {
             JsonResponseModel<ModifyNetworkAclQuintupleEntriesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNetworkAclQuintupleEntries");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNetworkAclQuintupleEntriesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the in/outbound rules of the network ACL quintuple. In the `NetworkAclQuintupleEntrySet` parameters, `NetworkAclQuintupleEntryId` is required for `NetworkAclQuintupleEntry`.
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkAclQuintupleEntriesRequest"/></param>
        /// <returns><see cref="ModifyNetworkAclQuintupleEntriesResponse"/></returns>
        public ModifyNetworkAclQuintupleEntriesResponse ModifyNetworkAclQuintupleEntriesSync(ModifyNetworkAclQuintupleEntriesRequest req)
        {
             JsonResponseModel<ModifyNetworkAclQuintupleEntriesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyNetworkAclQuintupleEntries");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNetworkAclQuintupleEntriesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyNetworkInterfaceAttribute) is used to modify ENI attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkInterfaceAttributeRequest"/></param>
        /// <returns><see cref="ModifyNetworkInterfaceAttributeResponse"/></returns>
        public async Task<ModifyNetworkInterfaceAttributeResponse> ModifyNetworkInterfaceAttribute(ModifyNetworkInterfaceAttributeRequest req)
        {
             JsonResponseModel<ModifyNetworkInterfaceAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNetworkInterfaceAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNetworkInterfaceAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyNetworkInterfaceAttribute) is used to modify ENI attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkInterfaceAttributeRequest"/></param>
        /// <returns><see cref="ModifyNetworkInterfaceAttributeResponse"/></returns>
        public ModifyNetworkInterfaceAttributeResponse ModifyNetworkInterfaceAttributeSync(ModifyNetworkInterfaceAttributeRequest req)
        {
             JsonResponseModel<ModifyNetworkInterfaceAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyNetworkInterfaceAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNetworkInterfaceAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyPrivateIpAddressesAttribute) is used to modify the private IP attributes of an ENI.
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
        /// This API (ModifyPrivateIpAddressesAttribute) is used to modify the private IP attributes of an ENI.
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
        /// This API (ModifyRouteTableAttribute) is used to modify the attributes of a route table.
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
        /// This API (ModifyRouteTableAttribute) is used to modify the attributes of a route table.
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
        /// This API (ModifySecurityGroupAttribute) is used to modify the attributes of a security group (SecurityGroupPolicy).
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
        /// This API (ModifySecurityGroupAttribute) is used to modify the attributes of a security group (SecurityGroupPolicy).
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
        /// This API is used to reset the `Egress` and `Ingress` rules (SecurityGroupPolicy) of a security group.
        /// 
        /// <ul>
        /// <li>This API does not support custom indexes <code>PolicyIndex</code>. </li>
        /// <li>For <code>SecurityGroupPolicySet</code> parameter,<ul> <ul>
        /// 	<li>If <code>SecurityGroupPolicySet.Version</code> is set to `0`, all policies will be cleared, and <code>Egress</code> and <code>Ingress</code> will be ignored. </li>
        /// 	<li>If <code>SecurityGroupPolicySet.Version</code> is not set to `0`, add <code>Egress</code> and <code>Ingress</code> policies: <ul>
        /// 		<li><code>Protocol</code>: <code>TCP</code>, <code>UDP</code>, <code>ICMP</code>, <code>ICMPV6</code>, <code>GRE</code>, or <code>ALL</code>. </li>
        /// 		<li><code>CidrBlock</code>: a CIDR block in the correct format. In the classic network, even if the CIDR block specified in <code>CidrBlock</code> contains the Tencent Cloud private IPs that are not using for CVMs under your Tencent Cloud account, it does not mean this policy allows you to access those resources. The network isolation policies between tenants take priority over the private network policies in security groups. </li>
        /// 		<li><code>Ipv6CidrBlock</code>: an IPv6 CIDR block in the correct format. In the classic network, even if the CIDR block specified in <code>Ipv6CidrBlock</code> contains the Tencent Cloud private IPv6 addresses that are not using for CVMs under your Tencent Cloud account, it does not mean this policy allows you to access those resources. The network isolation policies between tenants take priority over the private network policies in security groups. </li>
        /// 		<li><code>SecurityGroupId</code>: ID of the security group. It can be the ID of a security group to be modified, or the ID of another security group in the same project. All private IPs of all CVMs under the security group will be covered. If this field is used, the policy will automatically change according to the CVM associated with the group ID while being used to match network messages. You don't need to change it manually. </li>
        /// 		<li><code>Port</code>: a single port number such as 80, or a port range in the format of '8000-8010'.  You may use this field only if the <code>Protocol</code> field takes the value <code>TCP</code> or <code>UDP</code>. </li>
        /// 		<li><code>Action</code>: only allows <code>ACCEPT</code> or <code>DROP</code>. </li>
        /// 		<li><code>CidrBlock</code>, <code>Ipv6CidrBlock</code>, <code>SecurityGroupId</code>, and <code>AddressTemplate</code> are mutually exclusive. <code>Protocol</code> + <code>Port</code> and <code>ServiceTemplate</code> are mutually exclusive.</li> </li>
        /// </ul></li></ul></li>
        /// </ul>
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
        /// This API is used to reset the `Egress` and `Ingress` rules (SecurityGroupPolicy) of a security group.
        /// 
        /// <ul>
        /// <li>This API does not support custom indexes <code>PolicyIndex</code>. </li>
        /// <li>For <code>SecurityGroupPolicySet</code> parameter,<ul> <ul>
        /// 	<li>If <code>SecurityGroupPolicySet.Version</code> is set to `0`, all policies will be cleared, and <code>Egress</code> and <code>Ingress</code> will be ignored. </li>
        /// 	<li>If <code>SecurityGroupPolicySet.Version</code> is not set to `0`, add <code>Egress</code> and <code>Ingress</code> policies: <ul>
        /// 		<li><code>Protocol</code>: <code>TCP</code>, <code>UDP</code>, <code>ICMP</code>, <code>ICMPV6</code>, <code>GRE</code>, or <code>ALL</code>. </li>
        /// 		<li><code>CidrBlock</code>: a CIDR block in the correct format. In the classic network, even if the CIDR block specified in <code>CidrBlock</code> contains the Tencent Cloud private IPs that are not using for CVMs under your Tencent Cloud account, it does not mean this policy allows you to access those resources. The network isolation policies between tenants take priority over the private network policies in security groups. </li>
        /// 		<li><code>Ipv6CidrBlock</code>: an IPv6 CIDR block in the correct format. In the classic network, even if the CIDR block specified in <code>Ipv6CidrBlock</code> contains the Tencent Cloud private IPv6 addresses that are not using for CVMs under your Tencent Cloud account, it does not mean this policy allows you to access those resources. The network isolation policies between tenants take priority over the private network policies in security groups. </li>
        /// 		<li><code>SecurityGroupId</code>: ID of the security group. It can be the ID of a security group to be modified, or the ID of another security group in the same project. All private IPs of all CVMs under the security group will be covered. If this field is used, the policy will automatically change according to the CVM associated with the group ID while being used to match network messages. You don't need to change it manually. </li>
        /// 		<li><code>Port</code>: a single port number such as 80, or a port range in the format of '8000-8010'.  You may use this field only if the <code>Protocol</code> field takes the value <code>TCP</code> or <code>UDP</code>. </li>
        /// 		<li><code>Action</code>: only allows <code>ACCEPT</code> or <code>DROP</code>. </li>
        /// 		<li><code>CidrBlock</code>, <code>Ipv6CidrBlock</code>, <code>SecurityGroupId</code>, and <code>AddressTemplate</code> are mutually exclusive. <code>Protocol</code> + <code>Port</code> and <code>ServiceTemplate</code> are mutually exclusive.</li> </li>
        /// </ul></li></ul></li>
        /// </ul>
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
        /// This API (ModifyServiceTemplateAttribute) is used to modify a protocol port template.
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceTemplateAttributeRequest"/></param>
        /// <returns><see cref="ModifyServiceTemplateAttributeResponse"/></returns>
        public async Task<ModifyServiceTemplateAttributeResponse> ModifyServiceTemplateAttribute(ModifyServiceTemplateAttributeRequest req)
        {
             JsonResponseModel<ModifyServiceTemplateAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyServiceTemplateAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyServiceTemplateAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyServiceTemplateAttribute) is used to modify a protocol port template.
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceTemplateAttributeRequest"/></param>
        /// <returns><see cref="ModifyServiceTemplateAttributeResponse"/></returns>
        public ModifyServiceTemplateAttributeResponse ModifyServiceTemplateAttributeSync(ModifyServiceTemplateAttributeRequest req)
        {
             JsonResponseModel<ModifyServiceTemplateAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyServiceTemplateAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyServiceTemplateAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyServiceTemplateGroupAttribute) is used to modify a protocol port template group.
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceTemplateGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyServiceTemplateGroupAttributeResponse"/></returns>
        public async Task<ModifyServiceTemplateGroupAttributeResponse> ModifyServiceTemplateGroupAttribute(ModifyServiceTemplateGroupAttributeRequest req)
        {
             JsonResponseModel<ModifyServiceTemplateGroupAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyServiceTemplateGroupAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyServiceTemplateGroupAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyServiceTemplateGroupAttribute) is used to modify a protocol port template group.
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceTemplateGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyServiceTemplateGroupAttributeResponse"/></returns>
        public ModifyServiceTemplateGroupAttributeResponse ModifyServiceTemplateGroupAttributeSync(ModifyServiceTemplateGroupAttributeRequest req)
        {
             JsonResponseModel<ModifyServiceTemplateGroupAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyServiceTemplateGroupAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyServiceTemplateGroupAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify specified snapshot policies.
        /// </summary>
        /// <param name="req"><see cref="ModifySnapshotPoliciesRequest"/></param>
        /// <returns><see cref="ModifySnapshotPoliciesResponse"/></returns>
        public async Task<ModifySnapshotPoliciesResponse> ModifySnapshotPolicies(ModifySnapshotPoliciesRequest req)
        {
             JsonResponseModel<ModifySnapshotPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySnapshotPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySnapshotPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify specified snapshot policies.
        /// </summary>
        /// <param name="req"><see cref="ModifySnapshotPoliciesRequest"/></param>
        /// <returns><see cref="ModifySnapshotPoliciesResponse"/></returns>
        public ModifySnapshotPoliciesResponse ModifySnapshotPoliciesSync(ModifySnapshotPoliciesRequest req)
        {
             JsonResponseModel<ModifySnapshotPoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySnapshotPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySnapshotPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifySubnetAttribute) is used to modify subnet attributes.
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
        /// This API (ModifySubnetAttribute) is used to modify subnet attributes.
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
        /// This API (ModifyVpcAttribute) is used to modify VPC attributes.
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
        /// This API (ModifyVpcAttribute) is used to modify VPC attributes.
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
        /// This API is used to modify endpoint attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcEndPointAttributeRequest"/></param>
        /// <returns><see cref="ModifyVpcEndPointAttributeResponse"/></returns>
        public async Task<ModifyVpcEndPointAttributeResponse> ModifyVpcEndPointAttribute(ModifyVpcEndPointAttributeRequest req)
        {
             JsonResponseModel<ModifyVpcEndPointAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyVpcEndPointAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVpcEndPointAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify endpoint attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcEndPointAttributeRequest"/></param>
        /// <returns><see cref="ModifyVpcEndPointAttributeResponse"/></returns>
        public ModifyVpcEndPointAttributeResponse ModifyVpcEndPointAttributeSync(ModifyVpcEndPointAttributeRequest req)
        {
             JsonResponseModel<ModifyVpcEndPointAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyVpcEndPointAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVpcEndPointAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the VPC endpoint service attributes.
        /// 
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcEndPointServiceAttributeRequest"/></param>
        /// <returns><see cref="ModifyVpcEndPointServiceAttributeResponse"/></returns>
        public async Task<ModifyVpcEndPointServiceAttributeResponse> ModifyVpcEndPointServiceAttribute(ModifyVpcEndPointServiceAttributeRequest req)
        {
             JsonResponseModel<ModifyVpcEndPointServiceAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyVpcEndPointServiceAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVpcEndPointServiceAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the VPC endpoint service attributes.
        /// 
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcEndPointServiceAttributeRequest"/></param>
        /// <returns><see cref="ModifyVpcEndPointServiceAttributeResponse"/></returns>
        public ModifyVpcEndPointServiceAttributeResponse ModifyVpcEndPointServiceAttributeSync(ModifyVpcEndPointServiceAttributeRequest req)
        {
             JsonResponseModel<ModifyVpcEndPointServiceAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyVpcEndPointServiceAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVpcEndPointServiceAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of the endpoint service allowlist.
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcEndPointServiceWhiteListRequest"/></param>
        /// <returns><see cref="ModifyVpcEndPointServiceWhiteListResponse"/></returns>
        public async Task<ModifyVpcEndPointServiceWhiteListResponse> ModifyVpcEndPointServiceWhiteList(ModifyVpcEndPointServiceWhiteListRequest req)
        {
             JsonResponseModel<ModifyVpcEndPointServiceWhiteListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyVpcEndPointServiceWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVpcEndPointServiceWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of the endpoint service allowlist.
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcEndPointServiceWhiteListRequest"/></param>
        /// <returns><see cref="ModifyVpcEndPointServiceWhiteListResponse"/></returns>
        public ModifyVpcEndPointServiceWhiteListResponse ModifyVpcEndPointServiceWhiteListSync(ModifyVpcEndPointServiceWhiteListRequest req)
        {
             JsonResponseModel<ModifyVpcEndPointServiceWhiteListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyVpcEndPointServiceWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVpcEndPointServiceWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyVpnConnectionAttribute) is used to modify VPN tunnels.
        /// </summary>
        /// <param name="req"><see cref="ModifyVpnConnectionAttributeRequest"/></param>
        /// <returns><see cref="ModifyVpnConnectionAttributeResponse"/></returns>
        public async Task<ModifyVpnConnectionAttributeResponse> ModifyVpnConnectionAttribute(ModifyVpnConnectionAttributeRequest req)
        {
             JsonResponseModel<ModifyVpnConnectionAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyVpnConnectionAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVpnConnectionAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyVpnConnectionAttribute) is used to modify VPN tunnels.
        /// </summary>
        /// <param name="req"><see cref="ModifyVpnConnectionAttributeRequest"/></param>
        /// <returns><see cref="ModifyVpnConnectionAttributeResponse"/></returns>
        public ModifyVpnConnectionAttributeResponse ModifyVpnConnectionAttributeSync(ModifyVpnConnectionAttributeRequest req)
        {
             JsonResponseModel<ModifyVpnConnectionAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyVpnConnectionAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVpnConnectionAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyVpnGatewayAttribute) is used to modify the attributes of VPN gateways.
        /// </summary>
        /// <param name="req"><see cref="ModifyVpnGatewayAttributeRequest"/></param>
        /// <returns><see cref="ModifyVpnGatewayAttributeResponse"/></returns>
        public async Task<ModifyVpnGatewayAttributeResponse> ModifyVpnGatewayAttribute(ModifyVpnGatewayAttributeRequest req)
        {
             JsonResponseModel<ModifyVpnGatewayAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyVpnGatewayAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVpnGatewayAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyVpnGatewayAttribute) is used to modify the attributes of VPN gateways.
        /// </summary>
        /// <param name="req"><see cref="ModifyVpnGatewayAttributeRequest"/></param>
        /// <returns><see cref="ModifyVpnGatewayAttributeResponse"/></returns>
        public ModifyVpnGatewayAttributeResponse ModifyVpnGatewayAttributeSync(ModifyVpnGatewayAttributeRequest req)
        {
             JsonResponseModel<ModifyVpnGatewayAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyVpnGatewayAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVpnGatewayAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyVpnGatewayCcnRoutes) is used to modify VPN gateway-based CCN routes.
        /// </summary>
        /// <param name="req"><see cref="ModifyVpnGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="ModifyVpnGatewayCcnRoutesResponse"/></returns>
        public async Task<ModifyVpnGatewayCcnRoutesResponse> ModifyVpnGatewayCcnRoutes(ModifyVpnGatewayCcnRoutesRequest req)
        {
             JsonResponseModel<ModifyVpnGatewayCcnRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyVpnGatewayCcnRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVpnGatewayCcnRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyVpnGatewayCcnRoutes) is used to modify VPN gateway-based CCN routes.
        /// </summary>
        /// <param name="req"><see cref="ModifyVpnGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="ModifyVpnGatewayCcnRoutesResponse"/></returns>
        public ModifyVpnGatewayCcnRoutesResponse ModifyVpnGatewayCcnRoutesSync(ModifyVpnGatewayCcnRoutesRequest req)
        {
             JsonResponseModel<ModifyVpnGatewayCcnRoutesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyVpnGatewayCcnRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVpnGatewayCcnRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the route status of a VPN gateway.
        /// </summary>
        /// <param name="req"><see cref="ModifyVpnGatewayRoutesRequest"/></param>
        /// <returns><see cref="ModifyVpnGatewayRoutesResponse"/></returns>
        public async Task<ModifyVpnGatewayRoutesResponse> ModifyVpnGatewayRoutes(ModifyVpnGatewayRoutesRequest req)
        {
             JsonResponseModel<ModifyVpnGatewayRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyVpnGatewayRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVpnGatewayRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the route status of a VPN gateway.
        /// </summary>
        /// <param name="req"><see cref="ModifyVpnGatewayRoutesRequest"/></param>
        /// <returns><see cref="ModifyVpnGatewayRoutesResponse"/></returns>
        public ModifyVpnGatewayRoutesResponse ModifyVpnGatewayRoutesSync(ModifyVpnGatewayRoutesRequest req)
        {
             JsonResponseModel<ModifyVpnGatewayRoutesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyVpnGatewayRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVpnGatewayRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to publish a route to CCN. This can also be done by clicking "Publish to CCN" in the operation column on the page of route table list.
        /// </summary>
        /// <param name="req"><see cref="NotifyRoutesRequest"/></param>
        /// <returns><see cref="NotifyRoutesResponse"/></returns>
        public async Task<NotifyRoutesResponse> NotifyRoutes(NotifyRoutesRequest req)
        {
             JsonResponseModel<NotifyRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "NotifyRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<NotifyRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to publish a route to CCN. This can also be done by clicking "Publish to CCN" in the operation column on the page of route table list.
        /// </summary>
        /// <param name="req"><see cref="NotifyRoutesRequest"/></param>
        /// <returns><see cref="NotifyRoutesResponse"/></returns>
        public NotifyRoutesResponse NotifyRoutesSync(NotifyRoutesRequest req)
        {
             JsonResponseModel<NotifyRoutesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "NotifyRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<NotifyRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to refresh the route between a NAT gateway and  Direct Connect and update the associated route table.
        /// </summary>
        /// <param name="req"><see cref="RefreshDirectConnectGatewayRouteToNatGatewayRequest"/></param>
        /// <returns><see cref="RefreshDirectConnectGatewayRouteToNatGatewayResponse"/></returns>
        public async Task<RefreshDirectConnectGatewayRouteToNatGatewayResponse> RefreshDirectConnectGatewayRouteToNatGateway(RefreshDirectConnectGatewayRouteToNatGatewayRequest req)
        {
             JsonResponseModel<RefreshDirectConnectGatewayRouteToNatGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RefreshDirectConnectGatewayRouteToNatGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RefreshDirectConnectGatewayRouteToNatGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to refresh the route between a NAT gateway and  Direct Connect and update the associated route table.
        /// </summary>
        /// <param name="req"><see cref="RefreshDirectConnectGatewayRouteToNatGatewayRequest"/></param>
        /// <returns><see cref="RefreshDirectConnectGatewayRouteToNatGatewayResponse"/></returns>
        public RefreshDirectConnectGatewayRouteToNatGatewayResponse RefreshDirectConnectGatewayRouteToNatGatewaySync(RefreshDirectConnectGatewayRouteToNatGatewayRequest req)
        {
             JsonResponseModel<RefreshDirectConnectGatewayRouteToNatGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RefreshDirectConnectGatewayRouteToNatGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RefreshDirectConnectGatewayRouteToNatGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (RejectAttachCcnInstances) is used to reject association operations when instances are associated across accounts for the CCN owner.
        /// </summary>
        /// <param name="req"><see cref="RejectAttachCcnInstancesRequest"/></param>
        /// <returns><see cref="RejectAttachCcnInstancesResponse"/></returns>
        public async Task<RejectAttachCcnInstancesResponse> RejectAttachCcnInstances(RejectAttachCcnInstancesRequest req)
        {
             JsonResponseModel<RejectAttachCcnInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RejectAttachCcnInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RejectAttachCcnInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (RejectAttachCcnInstances) is used to reject association operations when instances are associated across accounts for the CCN owner.
        /// </summary>
        /// <param name="req"><see cref="RejectAttachCcnInstancesRequest"/></param>
        /// <returns><see cref="RejectAttachCcnInstancesResponse"/></returns>
        public RejectAttachCcnInstancesResponse RejectAttachCcnInstancesSync(RejectAttachCcnInstancesRequest req)
        {
             JsonResponseModel<RejectAttachCcnInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RejectAttachCcnInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RejectAttachCcnInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ReleaseAddresses) is used to release one or multiple [Elastic IPs](https://intl.cloud.tencent.com/document/product/213/1941?from_cn_redirect=1).
        /// * This operation is irreversible. Once you release an EIP, the IP address associated with the EIP no longer belongs to you.
        /// * Only EIPs in UNBIND status can be released.
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
        /// This API (ReleaseAddresses) is used to release one or multiple [Elastic IPs](https://intl.cloud.tencent.com/document/product/213/1941?from_cn_redirect=1).
        /// * This operation is irreversible. Once you release an EIP, the IP address associated with the EIP no longer belongs to you.
        /// * Only EIPs in UNBIND status can be released.
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
        /// This API is used to delete a bandwidth package resource, including [Elastic IP](https://intl.cloud.tencent.com/document/product/213/1941?from_cn_redirect=1), [Cloud Load Balancer](https://intl.cloud.tencent.com/document/product/214/517?from_cn_redirect=1), and so on.
        /// </summary>
        /// <param name="req"><see cref="RemoveBandwidthPackageResourcesRequest"/></param>
        /// <returns><see cref="RemoveBandwidthPackageResourcesResponse"/></returns>
        public async Task<RemoveBandwidthPackageResourcesResponse> RemoveBandwidthPackageResources(RemoveBandwidthPackageResourcesRequest req)
        {
             JsonResponseModel<RemoveBandwidthPackageResourcesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RemoveBandwidthPackageResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveBandwidthPackageResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a bandwidth package resource, including [Elastic IP](https://intl.cloud.tencent.com/document/product/213/1941?from_cn_redirect=1), [Cloud Load Balancer](https://intl.cloud.tencent.com/document/product/214/517?from_cn_redirect=1), and so on.
        /// </summary>
        /// <param name="req"><see cref="RemoveBandwidthPackageResourcesRequest"/></param>
        /// <returns><see cref="RemoveBandwidthPackageResourcesResponse"/></returns>
        public RemoveBandwidthPackageResourcesResponse RemoveBandwidthPackageResourcesSync(RemoveBandwidthPackageResourcesRequest req)
        {
             JsonResponseModel<RemoveBandwidthPackageResourcesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RemoveBandwidthPackageResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveBandwidthPackageResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (RenewVpnGateway) is used to renew prepaid (monthly subscription) VPN gateways. Currently, only IPSEC gateways are supported.
        /// </summary>
        /// <param name="req"><see cref="RenewVpnGatewayRequest"/></param>
        /// <returns><see cref="RenewVpnGatewayResponse"/></returns>
        public async Task<RenewVpnGatewayResponse> RenewVpnGateway(RenewVpnGatewayRequest req)
        {
             JsonResponseModel<RenewVpnGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RenewVpnGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewVpnGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (RenewVpnGateway) is used to renew prepaid (monthly subscription) VPN gateways. Currently, only IPSEC gateways are supported.
        /// </summary>
        /// <param name="req"><see cref="RenewVpnGatewayRequest"/></param>
        /// <returns><see cref="RenewVpnGatewayResponse"/></returns>
        public RenewVpnGatewayResponse RenewVpnGatewaySync(RenewVpnGatewayRequest req)
        {
             JsonResponseModel<RenewVpnGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RenewVpnGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewVpnGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ReplaceDirectConnectGatewayCcnRoutes) is used to modify the specified route according to the route ID. Batch modification is supported.
        /// </summary>
        /// <param name="req"><see cref="ReplaceDirectConnectGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="ReplaceDirectConnectGatewayCcnRoutesResponse"/></returns>
        public async Task<ReplaceDirectConnectGatewayCcnRoutesResponse> ReplaceDirectConnectGatewayCcnRoutes(ReplaceDirectConnectGatewayCcnRoutesRequest req)
        {
             JsonResponseModel<ReplaceDirectConnectGatewayCcnRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReplaceDirectConnectGatewayCcnRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReplaceDirectConnectGatewayCcnRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ReplaceDirectConnectGatewayCcnRoutes) is used to modify the specified route according to the route ID. Batch modification is supported.
        /// </summary>
        /// <param name="req"><see cref="ReplaceDirectConnectGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="ReplaceDirectConnectGatewayCcnRoutesResponse"/></returns>
        public ReplaceDirectConnectGatewayCcnRoutesResponse ReplaceDirectConnectGatewayCcnRoutesSync(ReplaceDirectConnectGatewayCcnRoutesRequest req)
        {
             JsonResponseModel<ReplaceDirectConnectGatewayCcnRoutesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReplaceDirectConnectGatewayCcnRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReplaceDirectConnectGatewayCcnRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ReplaceRouteTableAssociation) is used to modify the route table associated with a subnet.
        /// * A subnet can only be associated with one route table.
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
        /// This API (ReplaceRouteTableAssociation) is used to modify the route table associated with a subnet.
        /// * A subnet can only be associated with one route table.
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
        /// This API (ReplaceRoutes) is used to modify a specified routing policy by its ID (RouteId). Batch modification is supported.
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
        /// This API (ReplaceRoutes) is used to modify a specified routing policy by its ID (RouteId). Batch modification is supported.
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
        /// This API (ReplaceSecurityGroupPolicy) is used to replace a single security group policy (SecurityGroupPolicy).
        /// Only one policy in a single direction can be replaced in each request, and the PolicyIndex parameter must be specified.
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
        /// This API (ReplaceSecurityGroupPolicy) is used to replace a single security group policy (SecurityGroupPolicy).
        /// Only one policy in a single direction can be replaced in each request, and the PolicyIndex parameter must be specified.
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
        /// This API (ResetAttachCcnInstances) is used to re-apply for the association operation when the application for cross-account instance association expires.
        /// </summary>
        /// <param name="req"><see cref="ResetAttachCcnInstancesRequest"/></param>
        /// <returns><see cref="ResetAttachCcnInstancesResponse"/></returns>
        public async Task<ResetAttachCcnInstancesResponse> ResetAttachCcnInstances(ResetAttachCcnInstancesRequest req)
        {
             JsonResponseModel<ResetAttachCcnInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetAttachCcnInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetAttachCcnInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ResetAttachCcnInstances) is used to re-apply for the association operation when the application for cross-account instance association expires.
        /// </summary>
        /// <param name="req"><see cref="ResetAttachCcnInstancesRequest"/></param>
        /// <returns><see cref="ResetAttachCcnInstancesResponse"/></returns>
        public ResetAttachCcnInstancesResponse ResetAttachCcnInstancesSync(ResetAttachCcnInstancesRequest req)
        {
             JsonResponseModel<ResetAttachCcnInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetAttachCcnInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetAttachCcnInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to adjust concurrent connection cap for the NAT gateway.
        /// </summary>
        /// <param name="req"><see cref="ResetNatGatewayConnectionRequest"/></param>
        /// <returns><see cref="ResetNatGatewayConnectionResponse"/></returns>
        public async Task<ResetNatGatewayConnectionResponse> ResetNatGatewayConnection(ResetNatGatewayConnectionRequest req)
        {
             JsonResponseModel<ResetNatGatewayConnectionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetNatGatewayConnection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetNatGatewayConnectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to adjust concurrent connection cap for the NAT gateway.
        /// </summary>
        /// <param name="req"><see cref="ResetNatGatewayConnectionRequest"/></param>
        /// <returns><see cref="ResetNatGatewayConnectionResponse"/></returns>
        public ResetNatGatewayConnectionResponse ResetNatGatewayConnectionSync(ResetNatGatewayConnectionRequest req)
        {
             JsonResponseModel<ResetNatGatewayConnectionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetNatGatewayConnection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetNatGatewayConnectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ResetRoutes) is used to reset the name of a route table and all its routing policies.<br />
        /// Note: When this API is called, all routing policies in the current route table are deleted before new routing policies are saved, which may incur network interruption.
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
        /// This API (ResetRoutes) is used to reset the name of a route table and all its routing policies.<br />
        /// Note: When this API is called, all routing policies in the current route table are deleted before new routing policies are saved, which may incur network interruption.
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
        /// The API (ResetVpnConnection) is used to reset VPN tunnels.
        /// </summary>
        /// <param name="req"><see cref="ResetVpnConnectionRequest"/></param>
        /// <returns><see cref="ResetVpnConnectionResponse"/></returns>
        public async Task<ResetVpnConnectionResponse> ResetVpnConnection(ResetVpnConnectionRequest req)
        {
             JsonResponseModel<ResetVpnConnectionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetVpnConnection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetVpnConnectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// The API (ResetVpnConnection) is used to reset VPN tunnels.
        /// </summary>
        /// <param name="req"><see cref="ResetVpnConnectionRequest"/></param>
        /// <returns><see cref="ResetVpnConnectionResponse"/></returns>
        public ResetVpnConnectionResponse ResetVpnConnectionSync(ResetVpnConnectionRequest req)
        {
             JsonResponseModel<ResetVpnConnectionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetVpnConnection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetVpnConnectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ResetVpnGatewayInternetMaxBandwidth) is used to adjust the bandwidth cap of VPN gateways. Currently, only configuration upgrade is supported. VPN gateways with monthly subscription must be within the validity period.
        /// </summary>
        /// <param name="req"><see cref="ResetVpnGatewayInternetMaxBandwidthRequest"/></param>
        /// <returns><see cref="ResetVpnGatewayInternetMaxBandwidthResponse"/></returns>
        public async Task<ResetVpnGatewayInternetMaxBandwidthResponse> ResetVpnGatewayInternetMaxBandwidth(ResetVpnGatewayInternetMaxBandwidthRequest req)
        {
             JsonResponseModel<ResetVpnGatewayInternetMaxBandwidthResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetVpnGatewayInternetMaxBandwidth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetVpnGatewayInternetMaxBandwidthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ResetVpnGatewayInternetMaxBandwidth) is used to adjust the bandwidth cap of VPN gateways. Currently, only configuration upgrade is supported. VPN gateways with monthly subscription must be within the validity period.
        /// </summary>
        /// <param name="req"><see cref="ResetVpnGatewayInternetMaxBandwidthRequest"/></param>
        /// <returns><see cref="ResetVpnGatewayInternetMaxBandwidthResponse"/></returns>
        public ResetVpnGatewayInternetMaxBandwidthResponse ResetVpnGatewayInternetMaxBandwidthSync(ResetVpnGatewayInternetMaxBandwidthRequest req)
        {
             JsonResponseModel<ResetVpnGatewayInternetMaxBandwidthResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetVpnGatewayInternetMaxBandwidth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetVpnGatewayInternetMaxBandwidthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to restore security group policies with a backup.
        /// </summary>
        /// <param name="req"><see cref="ResumeSnapshotInstanceRequest"/></param>
        /// <returns><see cref="ResumeSnapshotInstanceResponse"/></returns>
        public async Task<ResumeSnapshotInstanceResponse> ResumeSnapshotInstance(ResumeSnapshotInstanceRequest req)
        {
             JsonResponseModel<ResumeSnapshotInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResumeSnapshotInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResumeSnapshotInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to restore security group policies with a backup.
        /// </summary>
        /// <param name="req"><see cref="ResumeSnapshotInstanceRequest"/></param>
        /// <returns><see cref="ResumeSnapshotInstanceResponse"/></returns>
        public ResumeSnapshotInstanceResponse ResumeSnapshotInstanceSync(ResumeSnapshotInstanceRequest req)
        {
             JsonResponseModel<ResumeSnapshotInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResumeSnapshotInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResumeSnapshotInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind and release public IPs. 
        /// Note: Starting from Dec 15, 2022, CAM authorization is required for a sub-account to call this API. For more details, see [Authorization Guide](https://intl.cloud.tencent.com/document/product/598/34545?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ReturnNormalAddressesRequest"/></param>
        /// <returns><see cref="ReturnNormalAddressesResponse"/></returns>
        public async Task<ReturnNormalAddressesResponse> ReturnNormalAddresses(ReturnNormalAddressesRequest req)
        {
             JsonResponseModel<ReturnNormalAddressesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReturnNormalAddresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReturnNormalAddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind and release public IPs. 
        /// Note: Starting from Dec 15, 2022, CAM authorization is required for a sub-account to call this API. For more details, see [Authorization Guide](https://intl.cloud.tencent.com/document/product/598/34545?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ReturnNormalAddressesRequest"/></param>
        /// <returns><see cref="ReturnNormalAddressesResponse"/></returns>
        public ReturnNormalAddressesResponse ReturnNormalAddressesSync(ReturnNormalAddressesRequest req)
        {
             JsonResponseModel<ReturnNormalAddressesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReturnNormalAddresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReturnNormalAddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (SetCcnRegionBandwidthLimits) is used to set the outbound bandwidth cap for CCNs in each region. This API can only set the outbound bandwidth cap for regions in the network instances that have already been associated.
        /// </summary>
        /// <param name="req"><see cref="SetCcnRegionBandwidthLimitsRequest"/></param>
        /// <returns><see cref="SetCcnRegionBandwidthLimitsResponse"/></returns>
        public async Task<SetCcnRegionBandwidthLimitsResponse> SetCcnRegionBandwidthLimits(SetCcnRegionBandwidthLimitsRequest req)
        {
             JsonResponseModel<SetCcnRegionBandwidthLimitsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetCcnRegionBandwidthLimits");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetCcnRegionBandwidthLimitsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (SetCcnRegionBandwidthLimits) is used to set the outbound bandwidth cap for CCNs in each region. This API can only set the outbound bandwidth cap for regions in the network instances that have already been associated.
        /// </summary>
        /// <param name="req"><see cref="SetCcnRegionBandwidthLimitsRequest"/></param>
        /// <returns><see cref="SetCcnRegionBandwidthLimitsResponse"/></returns>
        public SetCcnRegionBandwidthLimitsResponse SetCcnRegionBandwidthLimitsSync(SetCcnRegionBandwidthLimitsRequest req)
        {
             JsonResponseModel<SetCcnRegionBandwidthLimitsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetCcnRegionBandwidthLimits");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetCcnRegionBandwidthLimitsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to specify whether to enable auto-renewal for the VPN gateway.
        /// </summary>
        /// <param name="req"><see cref="SetVpnGatewaysRenewFlagRequest"/></param>
        /// <returns><see cref="SetVpnGatewaysRenewFlagResponse"/></returns>
        public async Task<SetVpnGatewaysRenewFlagResponse> SetVpnGatewaysRenewFlag(SetVpnGatewaysRenewFlagRequest req)
        {
             JsonResponseModel<SetVpnGatewaysRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetVpnGatewaysRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetVpnGatewaysRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to specify whether to enable auto-renewal for the VPN gateway.
        /// </summary>
        /// <param name="req"><see cref="SetVpnGatewaysRenewFlagRequest"/></param>
        /// <returns><see cref="SetVpnGatewaysRenewFlagResponse"/></returns>
        public SetVpnGatewaysRenewFlagResponse SetVpnGatewaysRenewFlagSync(SetVpnGatewaysRenewFlagRequest req)
        {
             JsonResponseModel<SetVpnGatewaysRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetVpnGatewaysRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetVpnGatewaysRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to convert a common public IP into an [Elastic IP](https://intl.cloud.tencent.com/document/product/213/1941?from_cn_redirect=1) (EIP for short).
        /// * Tencent Cloud limits the number of times that a user can unbind EIPs and reassign public IPs in each region per day. For more information, see product introduction of [Elastic IP](https://intl.cloud.tencent.com/document/product/213/5733?from_cn_redirect=1). The preceding quota can be obtained through the API [DescribeAddressQuota](https://intl.cloud.tencent.com/document/product/215/16701).
        /// </summary>
        /// <param name="req"><see cref="TransformAddressRequest"/></param>
        /// <returns><see cref="TransformAddressResponse"/></returns>
        public async Task<TransformAddressResponse> TransformAddress(TransformAddressRequest req)
        {
             JsonResponseModel<TransformAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TransformAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TransformAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to convert a common public IP into an [Elastic IP](https://intl.cloud.tencent.com/document/product/213/1941?from_cn_redirect=1) (EIP for short).
        /// * Tencent Cloud limits the number of times that a user can unbind EIPs and reassign public IPs in each region per day. For more information, see product introduction of [Elastic IP](https://intl.cloud.tencent.com/document/product/213/5733?from_cn_redirect=1). The preceding quota can be obtained through the API [DescribeAddressQuota](https://intl.cloud.tencent.com/document/product/215/16701).
        /// </summary>
        /// <param name="req"><see cref="TransformAddressRequest"/></param>
        /// <returns><see cref="TransformAddressResponse"/></returns>
        public TransformAddressResponse TransformAddressSync(TransformAddressRequest req)
        {
             JsonResponseModel<TransformAddressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TransformAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TransformAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to release the IPv6 addresses of an ENI. <br />
        /// This API is completed asynchronously. If you need to query the execution result of an async task, please use the `RequestId` returned by this API to poll the `DescribeVpcTaskResult` API.
        /// </summary>
        /// <param name="req"><see cref="UnassignIpv6AddressesRequest"/></param>
        /// <returns><see cref="UnassignIpv6AddressesResponse"/></returns>
        public async Task<UnassignIpv6AddressesResponse> UnassignIpv6Addresses(UnassignIpv6AddressesRequest req)
        {
             JsonResponseModel<UnassignIpv6AddressesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnassignIpv6Addresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnassignIpv6AddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to release the IPv6 addresses of an ENI. <br />
        /// This API is completed asynchronously. If you need to query the execution result of an async task, please use the `RequestId` returned by this API to poll the `DescribeVpcTaskResult` API.
        /// </summary>
        /// <param name="req"><see cref="UnassignIpv6AddressesRequest"/></param>
        /// <returns><see cref="UnassignIpv6AddressesResponse"/></returns>
        public UnassignIpv6AddressesResponse UnassignIpv6AddressesSync(UnassignIpv6AddressesRequest req)
        {
             JsonResponseModel<UnassignIpv6AddressesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnassignIpv6Addresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnassignIpv6AddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (UnassignIpv6CidrBlock) is used to release IPv6 IP ranges.
        /// If the IP range still has occupied IPs that are not yet repossessed, the IP range cannot be released.
        /// </summary>
        /// <param name="req"><see cref="UnassignIpv6CidrBlockRequest"/></param>
        /// <returns><see cref="UnassignIpv6CidrBlockResponse"/></returns>
        public async Task<UnassignIpv6CidrBlockResponse> UnassignIpv6CidrBlock(UnassignIpv6CidrBlockRequest req)
        {
             JsonResponseModel<UnassignIpv6CidrBlockResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnassignIpv6CidrBlock");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnassignIpv6CidrBlockResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (UnassignIpv6CidrBlock) is used to release IPv6 IP ranges.
        /// If the IP range still has occupied IPs that are not yet repossessed, the IP range cannot be released.
        /// </summary>
        /// <param name="req"><see cref="UnassignIpv6CidrBlockRequest"/></param>
        /// <returns><see cref="UnassignIpv6CidrBlockResponse"/></returns>
        public UnassignIpv6CidrBlockResponse UnassignIpv6CidrBlockSync(UnassignIpv6CidrBlockRequest req)
        {
             JsonResponseModel<UnassignIpv6CidrBlockResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnassignIpv6CidrBlock");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnassignIpv6CidrBlockResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (UnassignIpv6SubnetCidrBlock) is used to release IPv6 subnet IP ranges.
        /// If the subnet IP range still has occupied IPs that are not yet repossessed, the subnet IP range cannot be released.
        /// </summary>
        /// <param name="req"><see cref="UnassignIpv6SubnetCidrBlockRequest"/></param>
        /// <returns><see cref="UnassignIpv6SubnetCidrBlockResponse"/></returns>
        public async Task<UnassignIpv6SubnetCidrBlockResponse> UnassignIpv6SubnetCidrBlock(UnassignIpv6SubnetCidrBlockRequest req)
        {
             JsonResponseModel<UnassignIpv6SubnetCidrBlockResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnassignIpv6SubnetCidrBlock");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnassignIpv6SubnetCidrBlockResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (UnassignIpv6SubnetCidrBlock) is used to release IPv6 subnet IP ranges.
        /// If the subnet IP range still has occupied IPs that are not yet repossessed, the subnet IP range cannot be released.
        /// </summary>
        /// <param name="req"><see cref="UnassignIpv6SubnetCidrBlockRequest"/></param>
        /// <returns><see cref="UnassignIpv6SubnetCidrBlockResponse"/></returns>
        public UnassignIpv6SubnetCidrBlockResponse UnassignIpv6SubnetCidrBlockSync(UnassignIpv6SubnetCidrBlockRequest req)
        {
             JsonResponseModel<UnassignIpv6SubnetCidrBlockResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnassignIpv6SubnetCidrBlock");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnassignIpv6SubnetCidrBlockResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to return the private IP addresses of an ENI.
        /// * If a secondary private IP of an ENI is returned, the EIP will be automatically unassociated as well. The primary private IP of the ENI cannot be returned.
        /// 
        /// This API is completed asynchronously. If you need to query the execution result of an async task, please use the `RequestId` returned by this API to poll the `DescribeVpcTaskResult` API.
        /// </summary>
        /// <param name="req"><see cref="UnassignPrivateIpAddressesRequest"/></param>
        /// <returns><see cref="UnassignPrivateIpAddressesResponse"/></returns>
        public async Task<UnassignPrivateIpAddressesResponse> UnassignPrivateIpAddresses(UnassignPrivateIpAddressesRequest req)
        {
             JsonResponseModel<UnassignPrivateIpAddressesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnassignPrivateIpAddresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnassignPrivateIpAddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to return the private IP addresses of an ENI.
        /// * If a secondary private IP of an ENI is returned, the EIP will be automatically unassociated as well. The primary private IP of the ENI cannot be returned.
        /// 
        /// This API is completed asynchronously. If you need to query the execution result of an async task, please use the `RequestId` returned by this API to poll the `DescribeVpcTaskResult` API.
        /// </summary>
        /// <param name="req"><see cref="UnassignPrivateIpAddressesRequest"/></param>
        /// <returns><see cref="UnassignPrivateIpAddressesResponse"/></returns>
        public UnassignPrivateIpAddressesResponse UnassignPrivateIpAddressesSync(UnassignPrivateIpAddressesRequest req)
        {
             JsonResponseModel<UnassignPrivateIpAddressesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnassignPrivateIpAddresses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnassignPrivateIpAddressesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to withdraw a route from CCN. 
        /// </summary>
        /// <param name="req"><see cref="WithdrawNotifyRoutesRequest"/></param>
        /// <returns><see cref="WithdrawNotifyRoutesResponse"/></returns>
        public async Task<WithdrawNotifyRoutesResponse> WithdrawNotifyRoutes(WithdrawNotifyRoutesRequest req)
        {
             JsonResponseModel<WithdrawNotifyRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "WithdrawNotifyRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<WithdrawNotifyRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to withdraw a route from CCN. 
        /// </summary>
        /// <param name="req"><see cref="WithdrawNotifyRoutesRequest"/></param>
        /// <returns><see cref="WithdrawNotifyRoutesResponse"/></returns>
        public WithdrawNotifyRoutesResponse WithdrawNotifyRoutesSync(WithdrawNotifyRoutesRequest req)
        {
             JsonResponseModel<WithdrawNotifyRoutesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "WithdrawNotifyRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<WithdrawNotifyRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
