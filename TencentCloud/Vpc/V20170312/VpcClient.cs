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
       private const string sdkVersion = "SDK_NET_3.0.969";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public VpcClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API (AcceptAttachCcnInstances) is used to associate instances across accounts. Cloud Connect Network (CCN) owners accept and agree to the operations.
        /// </summary>
        /// <param name="req"><see cref="AcceptAttachCcnInstancesRequest"/></param>
        /// <returns><see cref="AcceptAttachCcnInstancesResponse"/></returns>
        public Task<AcceptAttachCcnInstancesResponse> AcceptAttachCcnInstances(AcceptAttachCcnInstancesRequest req)
        {
            return InternalRequestAsync<AcceptAttachCcnInstancesResponse>(req, "AcceptAttachCcnInstances");
        }

        /// <summary>
        /// This API (AcceptAttachCcnInstances) is used to associate instances across accounts. Cloud Connect Network (CCN) owners accept and agree to the operations.
        /// </summary>
        /// <param name="req"><see cref="AcceptAttachCcnInstancesRequest"/></param>
        /// <returns><see cref="AcceptAttachCcnInstancesResponse"/></returns>
        public AcceptAttachCcnInstancesResponse AcceptAttachCcnInstancesSync(AcceptAttachCcnInstancesRequest req)
        {
            return InternalRequestAsync<AcceptAttachCcnInstancesResponse>(req, "AcceptAttachCcnInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add resources to a bandwidth package, including [Elastic IP](https://intl.cloud.tencent.com/document/product/213/1941?from_cn_redirect=1), [Cloud Load Balancer](https://intl.cloud.tencent.com/document/product/214/517?from_cn_redirect=1), and so on.
        /// </summary>
        /// <param name="req"><see cref="AddBandwidthPackageResourcesRequest"/></param>
        /// <returns><see cref="AddBandwidthPackageResourcesResponse"/></returns>
        public Task<AddBandwidthPackageResourcesResponse> AddBandwidthPackageResources(AddBandwidthPackageResourcesRequest req)
        {
            return InternalRequestAsync<AddBandwidthPackageResourcesResponse>(req, "AddBandwidthPackageResources");
        }

        /// <summary>
        /// This API is used to add resources to a bandwidth package, including [Elastic IP](https://intl.cloud.tencent.com/document/product/213/1941?from_cn_redirect=1), [Cloud Load Balancer](https://intl.cloud.tencent.com/document/product/214/517?from_cn_redirect=1), and so on.
        /// </summary>
        /// <param name="req"><see cref="AddBandwidthPackageResourcesRequest"/></param>
        /// <returns><see cref="AddBandwidthPackageResourcesResponse"/></returns>
        public AddBandwidthPackageResourcesResponse AddBandwidthPackageResourcesSync(AddBandwidthPackageResourcesRequest req)
        {
            return InternalRequestAsync<AddBandwidthPackageResourcesResponse>(req, "AddBandwidthPackageResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to change the public IP of a CVM or the EIP of the associated bandwidth package.
        /// </summary>
        /// <param name="req"><see cref="AdjustPublicAddressRequest"/></param>
        /// <returns><see cref="AdjustPublicAddressResponse"/></returns>
        public Task<AdjustPublicAddressResponse> AdjustPublicAddress(AdjustPublicAddressRequest req)
        {
            return InternalRequestAsync<AdjustPublicAddressResponse>(req, "AdjustPublicAddress");
        }

        /// <summary>
        /// This API is used to change the public IP of a CVM or the EIP of the associated bandwidth package.
        /// </summary>
        /// <param name="req"><see cref="AdjustPublicAddressRequest"/></param>
        /// <returns><see cref="AdjustPublicAddressResponse"/></returns>
        public AdjustPublicAddressResponse AdjustPublicAddressSync(AdjustPublicAddressRequest req)
        {
            return InternalRequestAsync<AdjustPublicAddressResponse>(req, "AdjustPublicAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to apply for one or more [Elastic IP Addresses](https://intl.cloud.tencent.com/document/product/213/1941?from_cn_redirect=1) (EIPs for short).
        /// * An EIP is a static IP address that is dedicated for dynamic cloud computing. You can quickly re-map an EIP to another instance under your account to protect against instance failures.
        /// * Your EIP is associated with your Tencent Cloud account rather than an instance. It remains associated with your Tencent Cloud account until you choose to explicitly release it or your account is in arrears for more than 24 hours.
        /// * The maximum number of EIPs that can be applied for a Tencent Cloud account in each region is restricted. For more information, see [EIP Product Introduction](https://intl.cloud.tencent.com/document/product/213/5733?from_cn_redirect=1). You can get the quota information through the DescribeAddressQuota API.
        /// </summary>
        /// <param name="req"><see cref="AllocateAddressesRequest"/></param>
        /// <returns><see cref="AllocateAddressesResponse"/></returns>
        public Task<AllocateAddressesResponse> AllocateAddresses(AllocateAddressesRequest req)
        {
            return InternalRequestAsync<AllocateAddressesResponse>(req, "AllocateAddresses");
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
            return InternalRequestAsync<AllocateAddressesResponse>(req, "AllocateAddresses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        public Task<AssignIpv6AddressesResponse> AssignIpv6Addresses(AssignIpv6AddressesRequest req)
        {
            return InternalRequestAsync<AssignIpv6AddressesResponse>(req, "AssignIpv6Addresses");
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
            return InternalRequestAsync<AssignIpv6AddressesResponse>(req, "AssignIpv6Addresses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to assign IPv6 ranges.
        /// * To use this API, you must already have a VPC instance. If you do not have a VPC instance yet, use the <a href="https://intl.cloud.tencent.com/document/api/215/15774?from_cn_redirect=1" title="CreateVpc" target="_blank">CreateVpc</a> API to create one.
        /// * Each VPC can apply for only one IPv6 range.
        /// </summary>
        /// <param name="req"><see cref="AssignIpv6CidrBlockRequest"/></param>
        /// <returns><see cref="AssignIpv6CidrBlockResponse"/></returns>
        public Task<AssignIpv6CidrBlockResponse> AssignIpv6CidrBlock(AssignIpv6CidrBlockRequest req)
        {
            return InternalRequestAsync<AssignIpv6CidrBlockResponse>(req, "AssignIpv6CidrBlock");
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
            return InternalRequestAsync<AssignIpv6CidrBlockResponse>(req, "AssignIpv6CidrBlock")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (AssignIpv6SubnetCidrBlock) is used to assign IPv6 subnet IP ranges.
        /// * To assign an `IPv6` IP range to a subnet, the `VPC` that the subnet belongs to should have obtained the `IPv6` IP range. If this has not been assigned, use the `AssignIpv6CidrBlock` API to assign an `IPv6` IP range to the `VPC` to which the subnet belongs. Otherwise, the `IPv6` subnet IP range cannot be assigned.
        /// * Each subnet can only be assigned one IPv6 IP range.
        /// </summary>
        /// <param name="req"><see cref="AssignIpv6SubnetCidrBlockRequest"/></param>
        /// <returns><see cref="AssignIpv6SubnetCidrBlockResponse"/></returns>
        public Task<AssignIpv6SubnetCidrBlockResponse> AssignIpv6SubnetCidrBlock(AssignIpv6SubnetCidrBlockRequest req)
        {
            return InternalRequestAsync<AssignIpv6SubnetCidrBlockResponse>(req, "AssignIpv6SubnetCidrBlock");
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
            return InternalRequestAsync<AssignIpv6SubnetCidrBlockResponse>(req, "AssignIpv6SubnetCidrBlock")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        public Task<AssignPrivateIpAddressesResponse> AssignPrivateIpAddresses(AssignPrivateIpAddressesRequest req)
        {
            return InternalRequestAsync<AssignPrivateIpAddressesResponse>(req, "AssignPrivateIpAddresses");
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
            return InternalRequestAsync<AssignPrivateIpAddressesResponse>(req, "AssignPrivateIpAddresses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        public Task<AssociateAddressResponse> AssociateAddress(AssociateAddressRequest req)
        {
            return InternalRequestAsync<AssociateAddressResponse>(req, "AssociateAddress");
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
            return InternalRequestAsync<AssociateAddressResponse>(req, "AssociateAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bind a direct connect gateway with a NAT gateway,  and direct its default route to the NAT Gateway.
        /// </summary>
        /// <param name="req"><see cref="AssociateDirectConnectGatewayNatGatewayRequest"/></param>
        /// <returns><see cref="AssociateDirectConnectGatewayNatGatewayResponse"/></returns>
        public Task<AssociateDirectConnectGatewayNatGatewayResponse> AssociateDirectConnectGatewayNatGateway(AssociateDirectConnectGatewayNatGatewayRequest req)
        {
            return InternalRequestAsync<AssociateDirectConnectGatewayNatGatewayResponse>(req, "AssociateDirectConnectGatewayNatGateway");
        }

        /// <summary>
        /// This API is used to bind a direct connect gateway with a NAT gateway,  and direct its default route to the NAT Gateway.
        /// </summary>
        /// <param name="req"><see cref="AssociateDirectConnectGatewayNatGatewayRequest"/></param>
        /// <returns><see cref="AssociateDirectConnectGatewayNatGatewayResponse"/></returns>
        public AssociateDirectConnectGatewayNatGatewayResponse AssociateDirectConnectGatewayNatGatewaySync(AssociateDirectConnectGatewayNatGatewayRequest req)
        {
            return InternalRequestAsync<AssociateDirectConnectGatewayNatGatewayResponse>(req, "AssociateDirectConnectGatewayNatGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bind an EIP to a NAT gateway.
        /// </summary>
        /// <param name="req"><see cref="AssociateNatGatewayAddressRequest"/></param>
        /// <returns><see cref="AssociateNatGatewayAddressResponse"/></returns>
        public Task<AssociateNatGatewayAddressResponse> AssociateNatGatewayAddress(AssociateNatGatewayAddressRequest req)
        {
            return InternalRequestAsync<AssociateNatGatewayAddressResponse>(req, "AssociateNatGatewayAddress");
        }

        /// <summary>
        /// This API is used to bind an EIP to a NAT gateway.
        /// </summary>
        /// <param name="req"><see cref="AssociateNatGatewayAddressRequest"/></param>
        /// <returns><see cref="AssociateNatGatewayAddressResponse"/></returns>
        public AssociateNatGatewayAddressResponse AssociateNatGatewayAddressSync(AssociateNatGatewayAddressRequest req)
        {
            return InternalRequestAsync<AssociateNatGatewayAddressResponse>(req, "AssociateNatGatewayAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to associate a network ACL with subnets in a VPC instance.
        /// </summary>
        /// <param name="req"><see cref="AssociateNetworkAclSubnetsRequest"/></param>
        /// <returns><see cref="AssociateNetworkAclSubnetsResponse"/></returns>
        public Task<AssociateNetworkAclSubnetsResponse> AssociateNetworkAclSubnets(AssociateNetworkAclSubnetsRequest req)
        {
            return InternalRequestAsync<AssociateNetworkAclSubnetsResponse>(req, "AssociateNetworkAclSubnets");
        }

        /// <summary>
        /// This API is used to associate a network ACL with subnets in a VPC instance.
        /// </summary>
        /// <param name="req"><see cref="AssociateNetworkAclSubnetsRequest"/></param>
        /// <returns><see cref="AssociateNetworkAclSubnetsResponse"/></returns>
        public AssociateNetworkAclSubnetsResponse AssociateNetworkAclSubnetsSync(AssociateNetworkAclSubnetsRequest req)
        {
            return InternalRequestAsync<AssociateNetworkAclSubnetsResponse>(req, "AssociateNetworkAclSubnets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (AssociateNetworkInterfaceSecurityGroups) is used to attach a security group to an ENI.
        /// </summary>
        /// <param name="req"><see cref="AssociateNetworkInterfaceSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateNetworkInterfaceSecurityGroupsResponse"/></returns>
        public Task<AssociateNetworkInterfaceSecurityGroupsResponse> AssociateNetworkInterfaceSecurityGroups(AssociateNetworkInterfaceSecurityGroupsRequest req)
        {
            return InternalRequestAsync<AssociateNetworkInterfaceSecurityGroupsResponse>(req, "AssociateNetworkInterfaceSecurityGroups");
        }

        /// <summary>
        /// This API (AssociateNetworkInterfaceSecurityGroups) is used to attach a security group to an ENI.
        /// </summary>
        /// <param name="req"><see cref="AssociateNetworkInterfaceSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateNetworkInterfaceSecurityGroupsResponse"/></returns>
        public AssociateNetworkInterfaceSecurityGroupsResponse AssociateNetworkInterfaceSecurityGroupsSync(AssociateNetworkInterfaceSecurityGroupsRequest req)
        {
            return InternalRequestAsync<AssociateNetworkInterfaceSecurityGroupsResponse>(req, "AssociateNetworkInterfaceSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add a network instance to a CCN instance. Network instances include VPCs and Direct Connect gateways. <br />
        /// The number of network instances that each CCN can be associated with is limited. For more information, see the product documentation. If you need to associate more instances, please submit a ticket.
        /// </summary>
        /// <param name="req"><see cref="AttachCcnInstancesRequest"/></param>
        /// <returns><see cref="AttachCcnInstancesResponse"/></returns>
        public Task<AttachCcnInstancesResponse> AttachCcnInstances(AttachCcnInstancesRequest req)
        {
            return InternalRequestAsync<AttachCcnInstancesResponse>(req, "AttachCcnInstances");
        }

        /// <summary>
        /// This API is used to add a network instance to a CCN instance. Network instances include VPCs and Direct Connect gateways. <br />
        /// The number of network instances that each CCN can be associated with is limited. For more information, see the product documentation. If you need to associate more instances, please submit a ticket.
        /// </summary>
        /// <param name="req"><see cref="AttachCcnInstancesRequest"/></param>
        /// <returns><see cref="AttachCcnInstancesResponse"/></returns>
        public AttachCcnInstancesResponse AttachCcnInstancesSync(AttachCcnInstancesRequest req)
        {
            return InternalRequestAsync<AttachCcnInstancesResponse>(req, "AttachCcnInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        public Task<AttachClassicLinkVpcResponse> AttachClassicLinkVpc(AttachClassicLinkVpcRequest req)
        {
            return InternalRequestAsync<AttachClassicLinkVpcResponse>(req, "AttachClassicLinkVpc");
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
            return InternalRequestAsync<AttachClassicLinkVpcResponse>(req, "AttachClassicLinkVpc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        public Task<AttachNetworkInterfaceResponse> AttachNetworkInterface(AttachNetworkInterfaceRequest req)
        {
            return InternalRequestAsync<AttachNetworkInterfaceResponse>(req, "AttachNetworkInterface");
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
            return InternalRequestAsync<AttachNetworkInterfaceResponse>(req, "AttachNetworkInterface")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to associate a snapshot policy with specified instances.
        /// </summary>
        /// <param name="req"><see cref="AttachSnapshotInstancesRequest"/></param>
        /// <returns><see cref="AttachSnapshotInstancesResponse"/></returns>
        public Task<AttachSnapshotInstancesResponse> AttachSnapshotInstances(AttachSnapshotInstancesRequest req)
        {
            return InternalRequestAsync<AttachSnapshotInstancesResponse>(req, "AttachSnapshotInstances");
        }

        /// <summary>
        /// This API is used to associate a snapshot policy with specified instances.
        /// </summary>
        /// <param name="req"><see cref="AttachSnapshotInstancesRequest"/></param>
        /// <returns><see cref="AttachSnapshotInstancesResponse"/></returns>
        public AttachSnapshotInstancesResponse AttachSnapshotInstancesSync(AttachSnapshotInstancesRequest req)
        {
            return InternalRequestAsync<AttachSnapshotInstancesResponse>(req, "AttachSnapshotInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used by the service provider to perform a compliance audit.
        /// * This API is only provided for service providers to audit compliance review requests received. Tencent Cloud will verify the identity of the service provider by the `APPID`. 
        /// * The status of the review request can be changed between `APPROVED` and `DENY`.
        /// </summary>
        /// <param name="req"><see cref="AuditCrossBorderComplianceRequest"/></param>
        /// <returns><see cref="AuditCrossBorderComplianceResponse"/></returns>
        public Task<AuditCrossBorderComplianceResponse> AuditCrossBorderCompliance(AuditCrossBorderComplianceRequest req)
        {
            return InternalRequestAsync<AuditCrossBorderComplianceResponse>(req, "AuditCrossBorderCompliance");
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
            return InternalRequestAsync<AuditCrossBorderComplianceResponse>(req, "AuditCrossBorderCompliance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to check whether the secondary CIDR block conflicts with existing routes, peering connections (peer VPC CIDR blocks), and other resources. 
        /// * Check whether the secondary CIDR block overlaps with the primary/secondary CIDR block of the current VPC.
        /// * Check whether the secondary CIDR block overlaps with the routing destination of the current VPC.
        /// * If the current VPC is used in a peering connection, check whether the secondary CIDR block overlaps with the primary/secondary CIDR block of the peer VPC.
        /// </summary>
        /// <param name="req"><see cref="CheckAssistantCidrRequest"/></param>
        /// <returns><see cref="CheckAssistantCidrResponse"/></returns>
        public Task<CheckAssistantCidrResponse> CheckAssistantCidr(CheckAssistantCidrRequest req)
        {
            return InternalRequestAsync<CheckAssistantCidrResponse>(req, "CheckAssistantCidr");
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
            return InternalRequestAsync<CheckAssistantCidrResponse>(req, "CheckAssistantCidr")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to verify the network detection status.
        /// </summary>
        /// <param name="req"><see cref="CheckNetDetectStateRequest"/></param>
        /// <returns><see cref="CheckNetDetectStateResponse"/></returns>
        public Task<CheckNetDetectStateResponse> CheckNetDetectState(CheckNetDetectStateRequest req)
        {
            return InternalRequestAsync<CheckNetDetectStateResponse>(req, "CheckNetDetectState");
        }

        /// <summary>
        /// This API is used to verify the network detection status.
        /// </summary>
        /// <param name="req"><see cref="CheckNetDetectStateRequest"/></param>
        /// <returns><see cref="CheckNetDetectStateResponse"/></returns>
        public CheckNetDetectStateResponse CheckNetDetectStateSync(CheckNetDetectStateRequest req)
        {
            return InternalRequestAsync<CheckNetDetectStateResponse>(req, "CheckNetDetectState")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a security group with the same rule configurations as an existing security group. The cloning only copies the security group and its rules, but not the security group tags.
        /// </summary>
        /// <param name="req"><see cref="CloneSecurityGroupRequest"/></param>
        /// <returns><see cref="CloneSecurityGroupResponse"/></returns>
        public Task<CloneSecurityGroupResponse> CloneSecurityGroup(CloneSecurityGroupRequest req)
        {
            return InternalRequestAsync<CloneSecurityGroupResponse>(req, "CloneSecurityGroup");
        }

        /// <summary>
        /// This API is used to create a security group with the same rule configurations as an existing security group. The cloning only copies the security group and its rules, but not the security group tags.
        /// </summary>
        /// <param name="req"><see cref="CloneSecurityGroupRequest"/></param>
        /// <returns><see cref="CloneSecurityGroupResponse"/></returns>
        public CloneSecurityGroupResponse CloneSecurityGroupSync(CloneSecurityGroupRequest req)
        {
            return InternalRequestAsync<CloneSecurityGroupResponse>(req, "CloneSecurityGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an IP address template.
        /// </summary>
        /// <param name="req"><see cref="CreateAddressTemplateRequest"/></param>
        /// <returns><see cref="CreateAddressTemplateResponse"/></returns>
        public Task<CreateAddressTemplateResponse> CreateAddressTemplate(CreateAddressTemplateRequest req)
        {
            return InternalRequestAsync<CreateAddressTemplateResponse>(req, "CreateAddressTemplate");
        }

        /// <summary>
        /// This API is used to create an IP address template.
        /// </summary>
        /// <param name="req"><see cref="CreateAddressTemplateRequest"/></param>
        /// <returns><see cref="CreateAddressTemplateResponse"/></returns>
        public CreateAddressTemplateResponse CreateAddressTemplateSync(CreateAddressTemplateRequest req)
        {
            return InternalRequestAsync<CreateAddressTemplateResponse>(req, "CreateAddressTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an IP address template group.
        /// </summary>
        /// <param name="req"><see cref="CreateAddressTemplateGroupRequest"/></param>
        /// <returns><see cref="CreateAddressTemplateGroupResponse"/></returns>
        public Task<CreateAddressTemplateGroupResponse> CreateAddressTemplateGroup(CreateAddressTemplateGroupRequest req)
        {
            return InternalRequestAsync<CreateAddressTemplateGroupResponse>(req, "CreateAddressTemplateGroup");
        }

        /// <summary>
        /// This API is used to create an IP address template group.
        /// </summary>
        /// <param name="req"><see cref="CreateAddressTemplateGroupRequest"/></param>
        /// <returns><see cref="CreateAddressTemplateGroupResponse"/></returns>
        public CreateAddressTemplateGroupResponse CreateAddressTemplateGroupSync(CreateAddressTemplateGroupRequest req)
        {
            return InternalRequestAsync<CreateAddressTemplateGroupResponse>(req, "CreateAddressTemplateGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        public Task<CreateAndAttachNetworkInterfaceResponse> CreateAndAttachNetworkInterface(CreateAndAttachNetworkInterfaceRequest req)
        {
            return InternalRequestAsync<CreateAndAttachNetworkInterfaceResponse>(req, "CreateAndAttachNetworkInterface");
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
            return InternalRequestAsync<CreateAndAttachNetworkInterfaceResponse>(req, "CreateAndAttachNetworkInterface")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch create secondary CIDR blocks.
        /// </summary>
        /// <param name="req"><see cref="CreateAssistantCidrRequest"/></param>
        /// <returns><see cref="CreateAssistantCidrResponse"/></returns>
        public Task<CreateAssistantCidrResponse> CreateAssistantCidr(CreateAssistantCidrRequest req)
        {
            return InternalRequestAsync<CreateAssistantCidrResponse>(req, "CreateAssistantCidr");
        }

        /// <summary>
        /// This API is used to batch create secondary CIDR blocks.
        /// </summary>
        /// <param name="req"><see cref="CreateAssistantCidrRequest"/></param>
        /// <returns><see cref="CreateAssistantCidrResponse"/></returns>
        public CreateAssistantCidrResponse CreateAssistantCidrSync(CreateAssistantCidrRequest req)
        {
            return InternalRequestAsync<CreateAssistantCidrResponse>(req, "CreateAssistantCidr")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a [device bandwidth package](https://intl.cloud.tencent.com/document/product/684/15245?from_cn_redirect=1#bwptype) or an [IP bandwidth package](https://intl.cloud.tencent.com/document/product/684/15245?from_cn_redirect=1#bwptype).
        /// </summary>
        /// <param name="req"><see cref="CreateBandwidthPackageRequest"/></param>
        /// <returns><see cref="CreateBandwidthPackageResponse"/></returns>
        public Task<CreateBandwidthPackageResponse> CreateBandwidthPackage(CreateBandwidthPackageRequest req)
        {
            return InternalRequestAsync<CreateBandwidthPackageResponse>(req, "CreateBandwidthPackage");
        }

        /// <summary>
        /// This API is used to create a [device bandwidth package](https://intl.cloud.tencent.com/document/product/684/15245?from_cn_redirect=1#bwptype) or an [IP bandwidth package](https://intl.cloud.tencent.com/document/product/684/15245?from_cn_redirect=1#bwptype).
        /// </summary>
        /// <param name="req"><see cref="CreateBandwidthPackageRequest"/></param>
        /// <returns><see cref="CreateBandwidthPackageResponse"/></returns>
        public CreateBandwidthPackageResponse CreateBandwidthPackageSync(CreateBandwidthPackageRequest req)
        {
            return InternalRequestAsync<CreateBandwidthPackageResponse>(req, "CreateBandwidthPackage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a CCN instance.
        /// * You can add tags to a CCN instance upon the creation. The tags are added successfully if they are listed in the response.
        /// * There is a quota of CCN instances for each account. For more information, see product documentation. To increase the quota, please submit a ticket.
        /// </summary>
        /// <param name="req"><see cref="CreateCcnRequest"/></param>
        /// <returns><see cref="CreateCcnResponse"/></returns>
        public Task<CreateCcnResponse> CreateCcn(CreateCcnRequest req)
        {
            return InternalRequestAsync<CreateCcnResponse>(req, "CreateCcn");
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
            return InternalRequestAsync<CreateCcnResponse>(req, "CreateCcn")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (CreateCustomerGateway) is used to create customer gateways.
        /// </summary>
        /// <param name="req"><see cref="CreateCustomerGatewayRequest"/></param>
        /// <returns><see cref="CreateCustomerGatewayResponse"/></returns>
        public Task<CreateCustomerGatewayResponse> CreateCustomerGateway(CreateCustomerGatewayRequest req)
        {
            return InternalRequestAsync<CreateCustomerGatewayResponse>(req, "CreateCustomerGateway");
        }

        /// <summary>
        /// This API (CreateCustomerGateway) is used to create customer gateways.
        /// </summary>
        /// <param name="req"><see cref="CreateCustomerGatewayRequest"/></param>
        /// <returns><see cref="CreateCustomerGatewayResponse"/></returns>
        public CreateCustomerGatewayResponse CreateCustomerGatewaySync(CreateCustomerGatewayRequest req)
        {
            return InternalRequestAsync<CreateCustomerGatewayResponse>(req, "CreateCustomerGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a VPC with default settings.
        /// 
        /// To create a VPC with custom settings, such as VPC name, IP range, subnet IP range, and subnet availability zone, use `CreateVpc` instead.
        /// 
        /// This API may not create a default VPC. It depends on the network attributes (`DescribeAccountAttributes`) of your account.
        /// * If both basic network and VPC are supported, the returned `VpcId` is 0.
        /// * If only VPC is supported, the default VPC information is returned.
        /// 
        /// You can also use the `Force` parameter to forcibly return a default VPC.
        /// </summary>
        /// <param name="req"><see cref="CreateDefaultVpcRequest"/></param>
        /// <returns><see cref="CreateDefaultVpcResponse"/></returns>
        public Task<CreateDefaultVpcResponse> CreateDefaultVpc(CreateDefaultVpcRequest req)
        {
            return InternalRequestAsync<CreateDefaultVpcResponse>(req, "CreateDefaultVpc");
        }

        /// <summary>
        /// This API is used to create a VPC with default settings.
        /// 
        /// To create a VPC with custom settings, such as VPC name, IP range, subnet IP range, and subnet availability zone, use `CreateVpc` instead.
        /// 
        /// This API may not create a default VPC. It depends on the network attributes (`DescribeAccountAttributes`) of your account.
        /// * If both basic network and VPC are supported, the returned `VpcId` is 0.
        /// * If only VPC is supported, the default VPC information is returned.
        /// 
        /// You can also use the `Force` parameter to forcibly return a default VPC.
        /// </summary>
        /// <param name="req"><see cref="CreateDefaultVpcRequest"/></param>
        /// <returns><see cref="CreateDefaultVpcResponse"/></returns>
        public CreateDefaultVpcResponse CreateDefaultVpcSync(CreateDefaultVpcRequest req)
        {
            return InternalRequestAsync<CreateDefaultVpcResponse>(req, "CreateDefaultVpc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a direct connect gateway.
        /// </summary>
        /// <param name="req"><see cref="CreateDirectConnectGatewayRequest"/></param>
        /// <returns><see cref="CreateDirectConnectGatewayResponse"/></returns>
        public Task<CreateDirectConnectGatewayResponse> CreateDirectConnectGateway(CreateDirectConnectGatewayRequest req)
        {
            return InternalRequestAsync<CreateDirectConnectGatewayResponse>(req, "CreateDirectConnectGateway");
        }

        /// <summary>
        /// This API is used to create a direct connect gateway.
        /// </summary>
        /// <param name="req"><see cref="CreateDirectConnectGatewayRequest"/></param>
        /// <returns><see cref="CreateDirectConnectGatewayResponse"/></returns>
        public CreateDirectConnectGatewayResponse CreateDirectConnectGatewaySync(CreateDirectConnectGatewayRequest req)
        {
            return InternalRequestAsync<CreateDirectConnectGatewayResponse>(req, "CreateDirectConnectGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (CreateDirectConnectGatewayCcnRoutes) is used to create the CCN route (IDC IP range) of a Direct Connect gateway.
        /// </summary>
        /// <param name="req"><see cref="CreateDirectConnectGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="CreateDirectConnectGatewayCcnRoutesResponse"/></returns>
        public Task<CreateDirectConnectGatewayCcnRoutesResponse> CreateDirectConnectGatewayCcnRoutes(CreateDirectConnectGatewayCcnRoutesRequest req)
        {
            return InternalRequestAsync<CreateDirectConnectGatewayCcnRoutesResponse>(req, "CreateDirectConnectGatewayCcnRoutes");
        }

        /// <summary>
        /// This API (CreateDirectConnectGatewayCcnRoutes) is used to create the CCN route (IDC IP range) of a Direct Connect gateway.
        /// </summary>
        /// <param name="req"><see cref="CreateDirectConnectGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="CreateDirectConnectGatewayCcnRoutesResponse"/></returns>
        public CreateDirectConnectGatewayCcnRoutesResponse CreateDirectConnectGatewayCcnRoutesSync(CreateDirectConnectGatewayCcnRoutesRequest req)
        {
            return InternalRequestAsync<CreateDirectConnectGatewayCcnRoutesResponse>(req, "CreateDirectConnectGatewayCcnRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a flow log.
        /// </summary>
        /// <param name="req"><see cref="CreateFlowLogRequest"/></param>
        /// <returns><see cref="CreateFlowLogResponse"/></returns>
        public Task<CreateFlowLogResponse> CreateFlowLog(CreateFlowLogRequest req)
        {
            return InternalRequestAsync<CreateFlowLogResponse>(req, "CreateFlowLog");
        }

        /// <summary>
        /// This API is used to create a flow log.
        /// </summary>
        /// <param name="req"><see cref="CreateFlowLogRequest"/></param>
        /// <returns><see cref="CreateFlowLogResponse"/></returns>
        public CreateFlowLogResponse CreateFlowLogSync(CreateFlowLogRequest req)
        {
            return InternalRequestAsync<CreateFlowLogResponse>(req, "CreateFlowLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a highly available virtual IP (HAVIP).
        /// </summary>
        /// <param name="req"><see cref="CreateHaVipRequest"/></param>
        /// <returns><see cref="CreateHaVipResponse"/></returns>
        public Task<CreateHaVipResponse> CreateHaVip(CreateHaVipRequest req)
        {
            return InternalRequestAsync<CreateHaVipResponse>(req, "CreateHaVip");
        }

        /// <summary>
        /// This API is used to create a highly available virtual IP (HAVIP).
        /// </summary>
        /// <param name="req"><see cref="CreateHaVipRequest"/></param>
        /// <returns><see cref="CreateHaVipResponse"/></returns>
        public CreateHaVipResponse CreateHaVipSync(CreateHaVipRequest req)
        {
            return InternalRequestAsync<CreateHaVipResponse>(req, "CreateHaVip")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a local gateway for a CDC instance.
        /// </summary>
        /// <param name="req"><see cref="CreateLocalGatewayRequest"/></param>
        /// <returns><see cref="CreateLocalGatewayResponse"/></returns>
        public Task<CreateLocalGatewayResponse> CreateLocalGateway(CreateLocalGatewayRequest req)
        {
            return InternalRequestAsync<CreateLocalGatewayResponse>(req, "CreateLocalGateway");
        }

        /// <summary>
        /// This API is used to create a local gateway for a CDC instance.
        /// </summary>
        /// <param name="req"><see cref="CreateLocalGatewayRequest"/></param>
        /// <returns><see cref="CreateLocalGatewayResponse"/></returns>
        public CreateLocalGatewayResponse CreateLocalGatewaySync(CreateLocalGatewayRequest req)
        {
            return InternalRequestAsync<CreateLocalGatewayResponse>(req, "CreateLocalGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a NAT Gateway.
        /// Before taking actions on a NAT gateway, ensure that it has been successfully created, namely, the `State` field in the response of the `DescribeNatGateway` API is `AVAILABLE`.
        /// </summary>
        /// <param name="req"><see cref="CreateNatGatewayRequest"/></param>
        /// <returns><see cref="CreateNatGatewayResponse"/></returns>
        public Task<CreateNatGatewayResponse> CreateNatGateway(CreateNatGatewayRequest req)
        {
            return InternalRequestAsync<CreateNatGatewayResponse>(req, "CreateNatGateway");
        }

        /// <summary>
        /// This API is used to create a NAT Gateway.
        /// Before taking actions on a NAT gateway, ensure that it has been successfully created, namely, the `State` field in the response of the `DescribeNatGateway` API is `AVAILABLE`.
        /// </summary>
        /// <param name="req"><see cref="CreateNatGatewayRequest"/></param>
        /// <returns><see cref="CreateNatGatewayResponse"/></returns>
        public CreateNatGatewayResponse CreateNatGatewaySync(CreateNatGatewayRequest req)
        {
            return InternalRequestAsync<CreateNatGatewayResponse>(req, "CreateNatGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create the port forwarding rules of a NAT gateway.
        /// </summary>
        /// <param name="req"><see cref="CreateNatGatewayDestinationIpPortTranslationNatRuleRequest"/></param>
        /// <returns><see cref="CreateNatGatewayDestinationIpPortTranslationNatRuleResponse"/></returns>
        public Task<CreateNatGatewayDestinationIpPortTranslationNatRuleResponse> CreateNatGatewayDestinationIpPortTranslationNatRule(CreateNatGatewayDestinationIpPortTranslationNatRuleRequest req)
        {
            return InternalRequestAsync<CreateNatGatewayDestinationIpPortTranslationNatRuleResponse>(req, "CreateNatGatewayDestinationIpPortTranslationNatRule");
        }

        /// <summary>
        /// This API is used to create the port forwarding rules of a NAT gateway.
        /// </summary>
        /// <param name="req"><see cref="CreateNatGatewayDestinationIpPortTranslationNatRuleRequest"/></param>
        /// <returns><see cref="CreateNatGatewayDestinationIpPortTranslationNatRuleResponse"/></returns>
        public CreateNatGatewayDestinationIpPortTranslationNatRuleResponse CreateNatGatewayDestinationIpPortTranslationNatRuleSync(CreateNatGatewayDestinationIpPortTranslationNatRuleRequest req)
        {
            return InternalRequestAsync<CreateNatGatewayDestinationIpPortTranslationNatRuleResponse>(req, "CreateNatGatewayDestinationIpPortTranslationNatRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create SNAT rules for a NAT gateway.
        /// </summary>
        /// <param name="req"><see cref="CreateNatGatewaySourceIpTranslationNatRuleRequest"/></param>
        /// <returns><see cref="CreateNatGatewaySourceIpTranslationNatRuleResponse"/></returns>
        public Task<CreateNatGatewaySourceIpTranslationNatRuleResponse> CreateNatGatewaySourceIpTranslationNatRule(CreateNatGatewaySourceIpTranslationNatRuleRequest req)
        {
            return InternalRequestAsync<CreateNatGatewaySourceIpTranslationNatRuleResponse>(req, "CreateNatGatewaySourceIpTranslationNatRule");
        }

        /// <summary>
        /// This API is used to create SNAT rules for a NAT gateway.
        /// </summary>
        /// <param name="req"><see cref="CreateNatGatewaySourceIpTranslationNatRuleRequest"/></param>
        /// <returns><see cref="CreateNatGatewaySourceIpTranslationNatRuleResponse"/></returns>
        public CreateNatGatewaySourceIpTranslationNatRuleResponse CreateNatGatewaySourceIpTranslationNatRuleSync(CreateNatGatewaySourceIpTranslationNatRuleRequest req)
        {
            return InternalRequestAsync<CreateNatGatewaySourceIpTranslationNatRuleResponse>(req, "CreateNatGatewaySourceIpTranslationNatRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a network probe.
        /// </summary>
        /// <param name="req"><see cref="CreateNetDetectRequest"/></param>
        /// <returns><see cref="CreateNetDetectResponse"/></returns>
        public Task<CreateNetDetectResponse> CreateNetDetect(CreateNetDetectRequest req)
        {
            return InternalRequestAsync<CreateNetDetectResponse>(req, "CreateNetDetect");
        }

        /// <summary>
        /// This API is used to create a network probe.
        /// </summary>
        /// <param name="req"><see cref="CreateNetDetectRequest"/></param>
        /// <returns><see cref="CreateNetDetectResponse"/></returns>
        public CreateNetDetectResponse CreateNetDetectSync(CreateNetDetectRequest req)
        {
            return InternalRequestAsync<CreateNetDetectResponse>(req, "CreateNetDetect")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a <a href="https://intl.cloud.tencent.com/document/product/215/20088?from_cn_redirect=1">network ACL</a>.
        /// * The inbound and outbound rules for a new network ACL are "Deny All" by default. You need to call `ModifyNetworkAclEntries` to set rules for the new network ACL as needed.
        /// </summary>
        /// <param name="req"><see cref="CreateNetworkAclRequest"/></param>
        /// <returns><see cref="CreateNetworkAclResponse"/></returns>
        public Task<CreateNetworkAclResponse> CreateNetworkAcl(CreateNetworkAclRequest req)
        {
            return InternalRequestAsync<CreateNetworkAclResponse>(req, "CreateNetworkAcl");
        }

        /// <summary>
        /// This API is used to create a <a href="https://intl.cloud.tencent.com/document/product/215/20088?from_cn_redirect=1">network ACL</a>.
        /// * The inbound and outbound rules for a new network ACL are "Deny All" by default. You need to call `ModifyNetworkAclEntries` to set rules for the new network ACL as needed.
        /// </summary>
        /// <param name="req"><see cref="CreateNetworkAclRequest"/></param>
        /// <returns><see cref="CreateNetworkAclResponse"/></returns>
        public CreateNetworkAclResponse CreateNetworkAclSync(CreateNetworkAclRequest req)
        {
            return InternalRequestAsync<CreateNetworkAclResponse>(req, "CreateNetworkAcl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add one or more in/outbound rules of the network ACL quintuple.
        /// </summary>
        /// <param name="req"><see cref="CreateNetworkAclQuintupleEntriesRequest"/></param>
        /// <returns><see cref="CreateNetworkAclQuintupleEntriesResponse"/></returns>
        public Task<CreateNetworkAclQuintupleEntriesResponse> CreateNetworkAclQuintupleEntries(CreateNetworkAclQuintupleEntriesRequest req)
        {
            return InternalRequestAsync<CreateNetworkAclQuintupleEntriesResponse>(req, "CreateNetworkAclQuintupleEntries");
        }

        /// <summary>
        /// This API is used to add one or more in/outbound rules of the network ACL quintuple.
        /// </summary>
        /// <param name="req"><see cref="CreateNetworkAclQuintupleEntriesRequest"/></param>
        /// <returns><see cref="CreateNetworkAclQuintupleEntriesResponse"/></returns>
        public CreateNetworkAclQuintupleEntriesResponse CreateNetworkAclQuintupleEntriesSync(CreateNetworkAclQuintupleEntriesRequest req)
        {
            return InternalRequestAsync<CreateNetworkAclQuintupleEntriesResponse>(req, "CreateNetworkAclQuintupleEntries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        public Task<CreateNetworkInterfaceResponse> CreateNetworkInterface(CreateNetworkInterfaceRequest req)
        {
            return InternalRequestAsync<CreateNetworkInterfaceResponse>(req, "CreateNetworkInterface");
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
            return InternalRequestAsync<CreateNetworkInterfaceResponse>(req, "CreateNetworkInterface")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a route table.
        /// * After the VPC instance has been created, the system creates a default route table with which all newly created subnets will be associated. By default, you can use this route table to manage your routing policies. If you have multiple routing policies, you can call the API for creating route tables to create more route tables to manage these routing policies.
        /// * You can bind a tag when creating a route table. The tag list in the response indicates the tags that have been successfully added.
        /// </summary>
        /// <param name="req"><see cref="CreateRouteTableRequest"/></param>
        /// <returns><see cref="CreateRouteTableResponse"/></returns>
        public Task<CreateRouteTableResponse> CreateRouteTable(CreateRouteTableRequest req)
        {
            return InternalRequestAsync<CreateRouteTableResponse>(req, "CreateRouteTable");
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
            return InternalRequestAsync<CreateRouteTableResponse>(req, "CreateRouteTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create routes. 
        /// * You can batch add routes to a specified route table.
        /// </summary>
        /// <param name="req"><see cref="CreateRoutesRequest"/></param>
        /// <returns><see cref="CreateRoutesResponse"/></returns>
        public Task<CreateRoutesResponse> CreateRoutes(CreateRoutesRequest req)
        {
            return InternalRequestAsync<CreateRoutesResponse>(req, "CreateRoutes");
        }

        /// <summary>
        /// This API is used to create routes. 
        /// * You can batch add routes to a specified route table.
        /// </summary>
        /// <param name="req"><see cref="CreateRoutesRequest"/></param>
        /// <returns><see cref="CreateRoutesResponse"/></returns>
        public CreateRoutesResponse CreateRoutesSync(CreateRoutesRequest req)
        {
            return InternalRequestAsync<CreateRoutesResponse>(req, "CreateRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a security group (SecurityGroup).
        /// * Note the <a href="https://intl.cloud.tencent.com/document/product/213/12453?from_cn_redirect=1">maximum number of security groups</a> per project in each region under each account.
        /// * Both the inbound and outbound rules for a newly created security group are "Deny All" by default. You need to call CreateSecurityGroupPolicies to set security group rules based on your needs.
        /// * You can bind a tag when creating a security group. The tag list in the response indicates the tags that have been successfully added.
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityGroupRequest"/></param>
        /// <returns><see cref="CreateSecurityGroupResponse"/></returns>
        public Task<CreateSecurityGroupResponse> CreateSecurityGroup(CreateSecurityGroupRequest req)
        {
            return InternalRequestAsync<CreateSecurityGroupResponse>(req, "CreateSecurityGroup");
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
            return InternalRequestAsync<CreateSecurityGroupResponse>(req, "CreateSecurityGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        public Task<CreateSecurityGroupPoliciesResponse> CreateSecurityGroupPolicies(CreateSecurityGroupPoliciesRequest req)
        {
            return InternalRequestAsync<CreateSecurityGroupPoliciesResponse>(req, "CreateSecurityGroupPolicies");
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
            return InternalRequestAsync<CreateSecurityGroupPoliciesResponse>(req, "CreateSecurityGroupPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create u200da security group, and add security group policies.
        /// * For the the upper limit of security groups per project in each region under each account, <a href="https://intl.cloud.tencent.com/document/product/213/12453?from_cn_redirect=1">see here</a>
        /// * u200dFor u200dnewly u200dcreated security groups, u200dthe inbound and outbound policies are set to `Deny All` by default. You need to call <a href="https://intl.cloud.tencent.com/document/product/215/15807?from_cn_redirect=1">CreateSecurityGroupPolicies</a>
        /// to change it.
        /// 
        /// Description:
        /// * `Version`: The version number of a security group policy. It automatically increments by 1 every time you update the security policy, so to prevent the expiration of the updated policies. If this field is left empty, any conflicts will be ignored.
        /// * `Protocol`: Values can be `TCP`, `UDP`, `ICMP`, `ICMPV6`, `GRE`, and `ALL`.
        /// * `CidrBlock`: Enter a CIDR block in the correct format. In the classic network, even if the CIDR block specified in u200d`CidrBlock` contains the Tencent Cloud private IPs not used for CVMs under your Tencent Cloud account, it does not mean this policy allows you to access those resources. The network isolation policies between tenants take priority over the private network policies in security groups.
        /// * `Ipv6CidrBlock`: Enter an IPv6 CIDR block in the correct format. In the classic network, even if the CIDR block specified in `Ipv6CidrBlock` contains the Tencent Cloud private IPv6 addresses not used for CVMs under your Tencent Cloud account, it does not mean this policy allows you to access those resources. The network isolation policies between tenants take priority over the private network policies in security groups.
        /// * `SecurityGroupId`: ID of the security group. It can be the ID of a security group to be modified, or the ID of another security group in the same project. All private IPs of all CVMs under the security group will be covered. If this field is used, the policy will automatically change according to the CVM associated with the group ID while being used to match network messages. You don't need to change it manually.
        /// * `Port`: Enter a single port number (such as `80`), or a port range (such as `8000-8010`). `Port` is only applicable when `Protocol` is `TCP` or `UDP`. If `Protocol` is not `TCP` or `UDP`, `Protocol` and `Port` cannot be both specified. 
        /// * `Action`: Values can be `ACCEPT` or `DROP`.
        /// * `CidrBlock`, `Ipv6CidrBlock`, `SecurityGroupId`, and `AddressTemplate` are exclusive u200dto one another. “Protocol + Port” and `ServiceTemplate` are mutually exclusive.
        /// * Only policies in one direction can be created in each request. If you need to specify the `PolicyIndex` parameter, the indexes of policies must be consistent.
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityGroupWithPoliciesRequest"/></param>
        /// <returns><see cref="CreateSecurityGroupWithPoliciesResponse"/></returns>
        public Task<CreateSecurityGroupWithPoliciesResponse> CreateSecurityGroupWithPolicies(CreateSecurityGroupWithPoliciesRequest req)
        {
            return InternalRequestAsync<CreateSecurityGroupWithPoliciesResponse>(req, "CreateSecurityGroupWithPolicies");
        }

        /// <summary>
        /// This API is used to create u200da security group, and add security group policies.
        /// * For the the upper limit of security groups per project in each region under each account, <a href="https://intl.cloud.tencent.com/document/product/213/12453?from_cn_redirect=1">see here</a>
        /// * u200dFor u200dnewly u200dcreated security groups, u200dthe inbound and outbound policies are set to `Deny All` by default. You need to call <a href="https://intl.cloud.tencent.com/document/product/215/15807?from_cn_redirect=1">CreateSecurityGroupPolicies</a>
        /// to change it.
        /// 
        /// Description:
        /// * `Version`: The version number of a security group policy. It automatically increments by 1 every time you update the security policy, so to prevent the expiration of the updated policies. If this field is left empty, any conflicts will be ignored.
        /// * `Protocol`: Values can be `TCP`, `UDP`, `ICMP`, `ICMPV6`, `GRE`, and `ALL`.
        /// * `CidrBlock`: Enter a CIDR block in the correct format. In the classic network, even if the CIDR block specified in u200d`CidrBlock` contains the Tencent Cloud private IPs not used for CVMs under your Tencent Cloud account, it does not mean this policy allows you to access those resources. The network isolation policies between tenants take priority over the private network policies in security groups.
        /// * `Ipv6CidrBlock`: Enter an IPv6 CIDR block in the correct format. In the classic network, even if the CIDR block specified in `Ipv6CidrBlock` contains the Tencent Cloud private IPv6 addresses not used for CVMs under your Tencent Cloud account, it does not mean this policy allows you to access those resources. The network isolation policies between tenants take priority over the private network policies in security groups.
        /// * `SecurityGroupId`: ID of the security group. It can be the ID of a security group to be modified, or the ID of another security group in the same project. All private IPs of all CVMs under the security group will be covered. If this field is used, the policy will automatically change according to the CVM associated with the group ID while being used to match network messages. You don't need to change it manually.
        /// * `Port`: Enter a single port number (such as `80`), or a port range (such as `8000-8010`). `Port` is only applicable when `Protocol` is `TCP` or `UDP`. If `Protocol` is not `TCP` or `UDP`, `Protocol` and `Port` cannot be both specified. 
        /// * `Action`: Values can be `ACCEPT` or `DROP`.
        /// * `CidrBlock`, `Ipv6CidrBlock`, `SecurityGroupId`, and `AddressTemplate` are exclusive u200dto one another. “Protocol + Port” and `ServiceTemplate` are mutually exclusive.
        /// * Only policies in one direction can be created in each request. If you need to specify the `PolicyIndex` parameter, the indexes of policies must be consistent.
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityGroupWithPoliciesRequest"/></param>
        /// <returns><see cref="CreateSecurityGroupWithPoliciesResponse"/></returns>
        public CreateSecurityGroupWithPoliciesResponse CreateSecurityGroupWithPoliciesSync(CreateSecurityGroupWithPoliciesRequest req)
        {
            return InternalRequestAsync<CreateSecurityGroupWithPoliciesResponse>(req, "CreateSecurityGroupWithPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (CreateServiceTemplate) is used to create a protocol port template.
        /// </summary>
        /// <param name="req"><see cref="CreateServiceTemplateRequest"/></param>
        /// <returns><see cref="CreateServiceTemplateResponse"/></returns>
        public Task<CreateServiceTemplateResponse> CreateServiceTemplate(CreateServiceTemplateRequest req)
        {
            return InternalRequestAsync<CreateServiceTemplateResponse>(req, "CreateServiceTemplate");
        }

        /// <summary>
        /// This API (CreateServiceTemplate) is used to create a protocol port template.
        /// </summary>
        /// <param name="req"><see cref="CreateServiceTemplateRequest"/></param>
        /// <returns><see cref="CreateServiceTemplateResponse"/></returns>
        public CreateServiceTemplateResponse CreateServiceTemplateSync(CreateServiceTemplateRequest req)
        {
            return InternalRequestAsync<CreateServiceTemplateResponse>(req, "CreateServiceTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (CreateServiceTemplateGroup) is used to create a protocol port template group.
        /// </summary>
        /// <param name="req"><see cref="CreateServiceTemplateGroupRequest"/></param>
        /// <returns><see cref="CreateServiceTemplateGroupResponse"/></returns>
        public Task<CreateServiceTemplateGroupResponse> CreateServiceTemplateGroup(CreateServiceTemplateGroupRequest req)
        {
            return InternalRequestAsync<CreateServiceTemplateGroupResponse>(req, "CreateServiceTemplateGroup");
        }

        /// <summary>
        /// This API (CreateServiceTemplateGroup) is used to create a protocol port template group.
        /// </summary>
        /// <param name="req"><see cref="CreateServiceTemplateGroupRequest"/></param>
        /// <returns><see cref="CreateServiceTemplateGroupResponse"/></returns>
        public CreateServiceTemplateGroupResponse CreateServiceTemplateGroupSync(CreateServiceTemplateGroupRequest req)
        {
            return InternalRequestAsync<CreateServiceTemplateGroupResponse>(req, "CreateServiceTemplateGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create snapshot policies.
        /// </summary>
        /// <param name="req"><see cref="CreateSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="CreateSnapshotPoliciesResponse"/></returns>
        public Task<CreateSnapshotPoliciesResponse> CreateSnapshotPolicies(CreateSnapshotPoliciesRequest req)
        {
            return InternalRequestAsync<CreateSnapshotPoliciesResponse>(req, "CreateSnapshotPolicies");
        }

        /// <summary>
        /// This API is used to create snapshot policies.
        /// </summary>
        /// <param name="req"><see cref="CreateSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="CreateSnapshotPoliciesResponse"/></returns>
        public CreateSnapshotPoliciesResponse CreateSnapshotPoliciesSync(CreateSnapshotPoliciesRequest req)
        {
            return InternalRequestAsync<CreateSnapshotPoliciesResponse>(req, "CreateSnapshotPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        public Task<CreateSubnetResponse> CreateSubnet(CreateSubnetRequest req)
        {
            return InternalRequestAsync<CreateSubnetResponse>(req, "CreateSubnet");
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
            return InternalRequestAsync<CreateSubnetResponse>(req, "CreateSubnet")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        public Task<CreateSubnetsResponse> CreateSubnets(CreateSubnetsRequest req)
        {
            return InternalRequestAsync<CreateSubnetsResponse>(req, "CreateSubnets");
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
            return InternalRequestAsync<CreateSubnetsResponse>(req, "CreateSubnets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a VPC instance.
        /// * The subnet mask of the smallest IP address range that can be created is 28 (16 IP addresses), that of the largest IP address ranges 10.0.0.0/12 and 172.16.0.0/12 is 12 (1,048,576 IP addresses), and that of the largest IP address range 192.168.0.0/16 is 16 (65,536 IP addresses). For more information on how to plan VPC IP ranges, see [Network Planning](https://intl.cloud.tencent.com/document/product/215/30313?from_cn_redirect=1).
        /// * The number of VPC instances that can be created in a region is limited. For more information, see <a href="https://intl.cloud.tencent.com/doc/product/215/537?from_cn_redirect=1" title="VPC Use Limits">VPC Use Limits</a>. To request more resources, [submit a ticket](https://console.cloud.tencent.com/workorder/category).
        /// * You can bind tags when creating a VPC instance. The tag list in the response indicates the tags that have been successfully added.
        /// </summary>
        /// <param name="req"><see cref="CreateVpcRequest"/></param>
        /// <returns><see cref="CreateVpcResponse"/></returns>
        public Task<CreateVpcResponse> CreateVpc(CreateVpcRequest req)
        {
            return InternalRequestAsync<CreateVpcResponse>(req, "CreateVpc");
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
            return InternalRequestAsync<CreateVpcResponse>(req, "CreateVpc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an endpoint.
        /// </summary>
        /// <param name="req"><see cref="CreateVpcEndPointRequest"/></param>
        /// <returns><see cref="CreateVpcEndPointResponse"/></returns>
        public Task<CreateVpcEndPointResponse> CreateVpcEndPoint(CreateVpcEndPointRequest req)
        {
            return InternalRequestAsync<CreateVpcEndPointResponse>(req, "CreateVpcEndPoint");
        }

        /// <summary>
        /// This API is used to create an endpoint.
        /// </summary>
        /// <param name="req"><see cref="CreateVpcEndPointRequest"/></param>
        /// <returns><see cref="CreateVpcEndPointResponse"/></returns>
        public CreateVpcEndPointResponse CreateVpcEndPointSync(CreateVpcEndPointRequest req)
        {
            return InternalRequestAsync<CreateVpcEndPointResponse>(req, "CreateVpcEndPoint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an endpoint service.
        /// </summary>
        /// <param name="req"><see cref="CreateVpcEndPointServiceRequest"/></param>
        /// <returns><see cref="CreateVpcEndPointServiceResponse"/></returns>
        public Task<CreateVpcEndPointServiceResponse> CreateVpcEndPointService(CreateVpcEndPointServiceRequest req)
        {
            return InternalRequestAsync<CreateVpcEndPointServiceResponse>(req, "CreateVpcEndPointService");
        }

        /// <summary>
        /// This API is used to create an endpoint service.
        /// </summary>
        /// <param name="req"><see cref="CreateVpcEndPointServiceRequest"/></param>
        /// <returns><see cref="CreateVpcEndPointServiceResponse"/></returns>
        public CreateVpcEndPointServiceResponse CreateVpcEndPointServiceSync(CreateVpcEndPointServiceRequest req)
        {
            return InternalRequestAsync<CreateVpcEndPointServiceResponse>(req, "CreateVpcEndPointService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create the endpoint service allowlist.
        /// </summary>
        /// <param name="req"><see cref="CreateVpcEndPointServiceWhiteListRequest"/></param>
        /// <returns><see cref="CreateVpcEndPointServiceWhiteListResponse"/></returns>
        public Task<CreateVpcEndPointServiceWhiteListResponse> CreateVpcEndPointServiceWhiteList(CreateVpcEndPointServiceWhiteListRequest req)
        {
            return InternalRequestAsync<CreateVpcEndPointServiceWhiteListResponse>(req, "CreateVpcEndPointServiceWhiteList");
        }

        /// <summary>
        /// This API is used to create the endpoint service allowlist.
        /// </summary>
        /// <param name="req"><see cref="CreateVpcEndPointServiceWhiteListRequest"/></param>
        /// <returns><see cref="CreateVpcEndPointServiceWhiteListResponse"/></returns>
        public CreateVpcEndPointServiceWhiteListResponse CreateVpcEndPointServiceWhiteListSync(CreateVpcEndPointServiceWhiteListRequest req)
        {
            return InternalRequestAsync<CreateVpcEndPointServiceWhiteListResponse>(req, "CreateVpcEndPointServiceWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a VPN tunnel.
        /// >?This API is async. You can call the [`DescribeVpcTaskResult`](https://intl.cloud.tencent.com/document/api/215/59037?from_cn_redirect=1) API to query the task result. When the task is completed, you can continue other tasks.
        /// >
        /// </summary>
        /// <param name="req"><see cref="CreateVpnConnectionRequest"/></param>
        /// <returns><see cref="CreateVpnConnectionResponse"/></returns>
        public Task<CreateVpnConnectionResponse> CreateVpnConnection(CreateVpnConnectionRequest req)
        {
            return InternalRequestAsync<CreateVpnConnectionResponse>(req, "CreateVpnConnection");
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
            return InternalRequestAsync<CreateVpnConnectionResponse>(req, "CreateVpnConnection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (CreateVpnGateway) is used to create a VPN gateway.
        /// </summary>
        /// <param name="req"><see cref="CreateVpnGatewayRequest"/></param>
        /// <returns><see cref="CreateVpnGatewayResponse"/></returns>
        public Task<CreateVpnGatewayResponse> CreateVpnGateway(CreateVpnGatewayRequest req)
        {
            return InternalRequestAsync<CreateVpnGatewayResponse>(req, "CreateVpnGateway");
        }

        /// <summary>
        /// This API (CreateVpnGateway) is used to create a VPN gateway.
        /// </summary>
        /// <param name="req"><see cref="CreateVpnGatewayRequest"/></param>
        /// <returns><see cref="CreateVpnGatewayResponse"/></returns>
        public CreateVpnGatewayResponse CreateVpnGatewaySync(CreateVpnGatewayRequest req)
        {
            return InternalRequestAsync<CreateVpnGatewayResponse>(req, "CreateVpnGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create destination routes of a route-based VPN gateway.
        /// </summary>
        /// <param name="req"><see cref="CreateVpnGatewayRoutesRequest"/></param>
        /// <returns><see cref="CreateVpnGatewayRoutesResponse"/></returns>
        public Task<CreateVpnGatewayRoutesResponse> CreateVpnGatewayRoutes(CreateVpnGatewayRoutesRequest req)
        {
            return InternalRequestAsync<CreateVpnGatewayRoutesResponse>(req, "CreateVpnGatewayRoutes");
        }

        /// <summary>
        /// This API is used to create destination routes of a route-based VPN gateway.
        /// </summary>
        /// <param name="req"><see cref="CreateVpnGatewayRoutesRequest"/></param>
        /// <returns><see cref="CreateVpnGatewayRoutesResponse"/></returns>
        public CreateVpnGatewayRoutesResponse CreateVpnGatewayRoutesSync(CreateVpnGatewayRoutesRequest req)
        {
            return InternalRequestAsync<CreateVpnGatewayRoutesResponse>(req, "CreateVpnGatewayRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DeleteAddressTemplate) is used to delete an IP address template.
        /// </summary>
        /// <param name="req"><see cref="DeleteAddressTemplateRequest"/></param>
        /// <returns><see cref="DeleteAddressTemplateResponse"/></returns>
        public Task<DeleteAddressTemplateResponse> DeleteAddressTemplate(DeleteAddressTemplateRequest req)
        {
            return InternalRequestAsync<DeleteAddressTemplateResponse>(req, "DeleteAddressTemplate");
        }

        /// <summary>
        /// This API (DeleteAddressTemplate) is used to delete an IP address template.
        /// </summary>
        /// <param name="req"><see cref="DeleteAddressTemplateRequest"/></param>
        /// <returns><see cref="DeleteAddressTemplateResponse"/></returns>
        public DeleteAddressTemplateResponse DeleteAddressTemplateSync(DeleteAddressTemplateRequest req)
        {
            return InternalRequestAsync<DeleteAddressTemplateResponse>(req, "DeleteAddressTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DeleteAddressTemplateGroup) is used to delete an IP address template group.
        /// </summary>
        /// <param name="req"><see cref="DeleteAddressTemplateGroupRequest"/></param>
        /// <returns><see cref="DeleteAddressTemplateGroupResponse"/></returns>
        public Task<DeleteAddressTemplateGroupResponse> DeleteAddressTemplateGroup(DeleteAddressTemplateGroupRequest req)
        {
            return InternalRequestAsync<DeleteAddressTemplateGroupResponse>(req, "DeleteAddressTemplateGroup");
        }

        /// <summary>
        /// This API (DeleteAddressTemplateGroup) is used to delete an IP address template group.
        /// </summary>
        /// <param name="req"><see cref="DeleteAddressTemplateGroupRequest"/></param>
        /// <returns><see cref="DeleteAddressTemplateGroupResponse"/></returns>
        public DeleteAddressTemplateGroupResponse DeleteAddressTemplateGroupSync(DeleteAddressTemplateGroupRequest req)
        {
            return InternalRequestAsync<DeleteAddressTemplateGroupResponse>(req, "DeleteAddressTemplateGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a secondary CIDR block.
        /// </summary>
        /// <param name="req"><see cref="DeleteAssistantCidrRequest"/></param>
        /// <returns><see cref="DeleteAssistantCidrResponse"/></returns>
        public Task<DeleteAssistantCidrResponse> DeleteAssistantCidr(DeleteAssistantCidrRequest req)
        {
            return InternalRequestAsync<DeleteAssistantCidrResponse>(req, "DeleteAssistantCidr");
        }

        /// <summary>
        /// This API is used to delete a secondary CIDR block.
        /// </summary>
        /// <param name="req"><see cref="DeleteAssistantCidrRequest"/></param>
        /// <returns><see cref="DeleteAssistantCidrResponse"/></returns>
        public DeleteAssistantCidrResponse DeleteAssistantCidrSync(DeleteAssistantCidrRequest req)
        {
            return InternalRequestAsync<DeleteAssistantCidrResponse>(req, "DeleteAssistantCidr")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete bandwidth packages, including [device bandwidth packages](https://intl.cloud.tencent.com/document/product/684/15246?from_cn_redirect=1#.E8.AE.BE.E5.A4.87.E5.B8.A6.E5.AE.BD.E5.8C.85) and [IP bandwidth packages](https://intl.cloud.tencent.com/document/product/684/15246?from_cn_redirect=1#ip-.E5.B8.A6.E5.AE.BD.E5.8C.85).
        /// </summary>
        /// <param name="req"><see cref="DeleteBandwidthPackageRequest"/></param>
        /// <returns><see cref="DeleteBandwidthPackageResponse"/></returns>
        public Task<DeleteBandwidthPackageResponse> DeleteBandwidthPackage(DeleteBandwidthPackageRequest req)
        {
            return InternalRequestAsync<DeleteBandwidthPackageResponse>(req, "DeleteBandwidthPackage");
        }

        /// <summary>
        /// This API is used to delete bandwidth packages, including [device bandwidth packages](https://intl.cloud.tencent.com/document/product/684/15246?from_cn_redirect=1#.E8.AE.BE.E5.A4.87.E5.B8.A6.E5.AE.BD.E5.8C.85) and [IP bandwidth packages](https://intl.cloud.tencent.com/document/product/684/15246?from_cn_redirect=1#ip-.E5.B8.A6.E5.AE.BD.E5.8C.85).
        /// </summary>
        /// <param name="req"><see cref="DeleteBandwidthPackageRequest"/></param>
        /// <returns><see cref="DeleteBandwidthPackageResponse"/></returns>
        public DeleteBandwidthPackageResponse DeleteBandwidthPackageSync(DeleteBandwidthPackageRequest req)
        {
            return InternalRequestAsync<DeleteBandwidthPackageResponse>(req, "DeleteBandwidthPackage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DeleteCcn) is used to delete CCNs.
        /// * After deletion, the routes between all instances associated with the CCN will be deleted, and the network will be interrupted. Please confirm this operation in advance.
        /// * CCN deletion is an irreversible operation. Please proceed with caution.
        /// </summary>
        /// <param name="req"><see cref="DeleteCcnRequest"/></param>
        /// <returns><see cref="DeleteCcnResponse"/></returns>
        public Task<DeleteCcnResponse> DeleteCcn(DeleteCcnRequest req)
        {
            return InternalRequestAsync<DeleteCcnResponse>(req, "DeleteCcn");
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
            return InternalRequestAsync<DeleteCcnResponse>(req, "DeleteCcn")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DeleteCustomerGateway) is used to delete customer gateways.
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomerGatewayRequest"/></param>
        /// <returns><see cref="DeleteCustomerGatewayResponse"/></returns>
        public Task<DeleteCustomerGatewayResponse> DeleteCustomerGateway(DeleteCustomerGatewayRequest req)
        {
            return InternalRequestAsync<DeleteCustomerGatewayResponse>(req, "DeleteCustomerGateway");
        }

        /// <summary>
        /// This API (DeleteCustomerGateway) is used to delete customer gateways.
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomerGatewayRequest"/></param>
        /// <returns><see cref="DeleteCustomerGatewayResponse"/></returns>
        public DeleteCustomerGatewayResponse DeleteCustomerGatewaySync(DeleteCustomerGatewayRequest req)
        {
            return InternalRequestAsync<DeleteCustomerGatewayResponse>(req, "DeleteCustomerGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a direct connect gateway.
        /// <li>For a NAT gateway, NAT and ACL rules will be cleared upon the deletion of a direct connect gateway.
        /// <li>After the deletion of a direct connect gateway, the routing policy associated with the gateway in the route table will also be deleted.
        /// This API is completed asynchronously. If you need to query the async job execution results, please use the `RequestId` returned by this API to poll the `QueryTask` API.
        /// </summary>
        /// <param name="req"><see cref="DeleteDirectConnectGatewayRequest"/></param>
        /// <returns><see cref="DeleteDirectConnectGatewayResponse"/></returns>
        public Task<DeleteDirectConnectGatewayResponse> DeleteDirectConnectGateway(DeleteDirectConnectGatewayRequest req)
        {
            return InternalRequestAsync<DeleteDirectConnectGatewayResponse>(req, "DeleteDirectConnectGateway");
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
            return InternalRequestAsync<DeleteDirectConnectGatewayResponse>(req, "DeleteDirectConnectGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DeleteDirectConnectGatewayCcnRoutes) is used to delete the CCN routes (IDC IP range) of a Direct Connect gateway.
        /// </summary>
        /// <param name="req"><see cref="DeleteDirectConnectGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="DeleteDirectConnectGatewayCcnRoutesResponse"/></returns>
        public Task<DeleteDirectConnectGatewayCcnRoutesResponse> DeleteDirectConnectGatewayCcnRoutes(DeleteDirectConnectGatewayCcnRoutesRequest req)
        {
            return InternalRequestAsync<DeleteDirectConnectGatewayCcnRoutesResponse>(req, "DeleteDirectConnectGatewayCcnRoutes");
        }

        /// <summary>
        /// This API (DeleteDirectConnectGatewayCcnRoutes) is used to delete the CCN routes (IDC IP range) of a Direct Connect gateway.
        /// </summary>
        /// <param name="req"><see cref="DeleteDirectConnectGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="DeleteDirectConnectGatewayCcnRoutesResponse"/></returns>
        public DeleteDirectConnectGatewayCcnRoutesResponse DeleteDirectConnectGatewayCcnRoutesSync(DeleteDirectConnectGatewayCcnRoutesRequest req)
        {
            return InternalRequestAsync<DeleteDirectConnectGatewayCcnRoutesResponse>(req, "DeleteDirectConnectGatewayCcnRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a flow log.
        /// </summary>
        /// <param name="req"><see cref="DeleteFlowLogRequest"/></param>
        /// <returns><see cref="DeleteFlowLogResponse"/></returns>
        public Task<DeleteFlowLogResponse> DeleteFlowLog(DeleteFlowLogRequest req)
        {
            return InternalRequestAsync<DeleteFlowLogResponse>(req, "DeleteFlowLog");
        }

        /// <summary>
        /// This API is used to delete a flow log.
        /// </summary>
        /// <param name="req"><see cref="DeleteFlowLogRequest"/></param>
        /// <returns><see cref="DeleteFlowLogResponse"/></returns>
        public DeleteFlowLogResponse DeleteFlowLogSync(DeleteFlowLogRequest req)
        {
            return InternalRequestAsync<DeleteFlowLogResponse>(req, "DeleteFlowLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an HAVIP. <br />
        /// This API is completed asynchronously. If you need to query the execution result of an async task, please use the `RequestId` returned by this API to poll the `DescribeVpcTaskResult` API.
        /// </summary>
        /// <param name="req"><see cref="DeleteHaVipRequest"/></param>
        /// <returns><see cref="DeleteHaVipResponse"/></returns>
        public Task<DeleteHaVipResponse> DeleteHaVip(DeleteHaVipRequest req)
        {
            return InternalRequestAsync<DeleteHaVipResponse>(req, "DeleteHaVip");
        }

        /// <summary>
        /// This API is used to delete an HAVIP. <br />
        /// This API is completed asynchronously. If you need to query the execution result of an async task, please use the `RequestId` returned by this API to poll the `DescribeVpcTaskResult` API.
        /// </summary>
        /// <param name="req"><see cref="DeleteHaVipRequest"/></param>
        /// <returns><see cref="DeleteHaVipResponse"/></returns>
        public DeleteHaVipResponse DeleteHaVipSync(DeleteHaVipRequest req)
        {
            return InternalRequestAsync<DeleteHaVipResponse>(req, "DeleteHaVip")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the local gateway of a CDC instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteLocalGatewayRequest"/></param>
        /// <returns><see cref="DeleteLocalGatewayResponse"/></returns>
        public Task<DeleteLocalGatewayResponse> DeleteLocalGateway(DeleteLocalGatewayRequest req)
        {
            return InternalRequestAsync<DeleteLocalGatewayResponse>(req, "DeleteLocalGateway");
        }

        /// <summary>
        /// This API is used to delete the local gateway of a CDC instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteLocalGatewayRequest"/></param>
        /// <returns><see cref="DeleteLocalGatewayResponse"/></returns>
        public DeleteLocalGatewayResponse DeleteLocalGatewaySync(DeleteLocalGatewayRequest req)
        {
            return InternalRequestAsync<DeleteLocalGatewayResponse>(req, "DeleteLocalGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a NAT gateway.
        /// When a NAT gateway is deleted, all routes containing this gateway are deleted automatically, and the elastic IP is unbound.
        /// </summary>
        /// <param name="req"><see cref="DeleteNatGatewayRequest"/></param>
        /// <returns><see cref="DeleteNatGatewayResponse"/></returns>
        public Task<DeleteNatGatewayResponse> DeleteNatGateway(DeleteNatGatewayRequest req)
        {
            return InternalRequestAsync<DeleteNatGatewayResponse>(req, "DeleteNatGateway");
        }

        /// <summary>
        /// This API is used to delete a NAT gateway.
        /// When a NAT gateway is deleted, all routes containing this gateway are deleted automatically, and the elastic IP is unbound.
        /// </summary>
        /// <param name="req"><see cref="DeleteNatGatewayRequest"/></param>
        /// <returns><see cref="DeleteNatGatewayResponse"/></returns>
        public DeleteNatGatewayResponse DeleteNatGatewaySync(DeleteNatGatewayRequest req)
        {
            return InternalRequestAsync<DeleteNatGatewayResponse>(req, "DeleteNatGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the port forwarding rule of a NAT gateway.
        /// </summary>
        /// <param name="req"><see cref="DeleteNatGatewayDestinationIpPortTranslationNatRuleRequest"/></param>
        /// <returns><see cref="DeleteNatGatewayDestinationIpPortTranslationNatRuleResponse"/></returns>
        public Task<DeleteNatGatewayDestinationIpPortTranslationNatRuleResponse> DeleteNatGatewayDestinationIpPortTranslationNatRule(DeleteNatGatewayDestinationIpPortTranslationNatRuleRequest req)
        {
            return InternalRequestAsync<DeleteNatGatewayDestinationIpPortTranslationNatRuleResponse>(req, "DeleteNatGatewayDestinationIpPortTranslationNatRule");
        }

        /// <summary>
        /// This API is used to delete the port forwarding rule of a NAT gateway.
        /// </summary>
        /// <param name="req"><see cref="DeleteNatGatewayDestinationIpPortTranslationNatRuleRequest"/></param>
        /// <returns><see cref="DeleteNatGatewayDestinationIpPortTranslationNatRuleResponse"/></returns>
        public DeleteNatGatewayDestinationIpPortTranslationNatRuleResponse DeleteNatGatewayDestinationIpPortTranslationNatRuleSync(DeleteNatGatewayDestinationIpPortTranslationNatRuleRequest req)
        {
            return InternalRequestAsync<DeleteNatGatewayDestinationIpPortTranslationNatRuleResponse>(req, "DeleteNatGatewayDestinationIpPortTranslationNatRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a SNAT forwarding rule of a NAT gateway.
        /// </summary>
        /// <param name="req"><see cref="DeleteNatGatewaySourceIpTranslationNatRuleRequest"/></param>
        /// <returns><see cref="DeleteNatGatewaySourceIpTranslationNatRuleResponse"/></returns>
        public Task<DeleteNatGatewaySourceIpTranslationNatRuleResponse> DeleteNatGatewaySourceIpTranslationNatRule(DeleteNatGatewaySourceIpTranslationNatRuleRequest req)
        {
            return InternalRequestAsync<DeleteNatGatewaySourceIpTranslationNatRuleResponse>(req, "DeleteNatGatewaySourceIpTranslationNatRule");
        }

        /// <summary>
        /// This API is used to delete a SNAT forwarding rule of a NAT gateway.
        /// </summary>
        /// <param name="req"><see cref="DeleteNatGatewaySourceIpTranslationNatRuleRequest"/></param>
        /// <returns><see cref="DeleteNatGatewaySourceIpTranslationNatRuleResponse"/></returns>
        public DeleteNatGatewaySourceIpTranslationNatRuleResponse DeleteNatGatewaySourceIpTranslationNatRuleSync(DeleteNatGatewaySourceIpTranslationNatRuleRequest req)
        {
            return InternalRequestAsync<DeleteNatGatewaySourceIpTranslationNatRuleResponse>(req, "DeleteNatGatewaySourceIpTranslationNatRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a network probe.
        /// </summary>
        /// <param name="req"><see cref="DeleteNetDetectRequest"/></param>
        /// <returns><see cref="DeleteNetDetectResponse"/></returns>
        public Task<DeleteNetDetectResponse> DeleteNetDetect(DeleteNetDetectRequest req)
        {
            return InternalRequestAsync<DeleteNetDetectResponse>(req, "DeleteNetDetect");
        }

        /// <summary>
        /// This API is used to delete a network probe.
        /// </summary>
        /// <param name="req"><see cref="DeleteNetDetectRequest"/></param>
        /// <returns><see cref="DeleteNetDetectResponse"/></returns>
        public DeleteNetDetectResponse DeleteNetDetectSync(DeleteNetDetectRequest req)
        {
            return InternalRequestAsync<DeleteNetDetectResponse>(req, "DeleteNetDetect")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a network ACL.
        /// </summary>
        /// <param name="req"><see cref="DeleteNetworkAclRequest"/></param>
        /// <returns><see cref="DeleteNetworkAclResponse"/></returns>
        public Task<DeleteNetworkAclResponse> DeleteNetworkAcl(DeleteNetworkAclRequest req)
        {
            return InternalRequestAsync<DeleteNetworkAclResponse>(req, "DeleteNetworkAcl");
        }

        /// <summary>
        /// This API is used to delete a network ACL.
        /// </summary>
        /// <param name="req"><see cref="DeleteNetworkAclRequest"/></param>
        /// <returns><see cref="DeleteNetworkAclResponse"/></returns>
        public DeleteNetworkAclResponse DeleteNetworkAclSync(DeleteNetworkAclRequest req)
        {
            return InternalRequestAsync<DeleteNetworkAclResponse>(req, "DeleteNetworkAcl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete specified in/outbound rules of the network ACL quintuple. In the `NetworkAclQuintupleEntrySet` parameters, `NetworkAclQuintupleEntryId` is required for `NetworkAclQuintupleEntry`.
        /// </summary>
        /// <param name="req"><see cref="DeleteNetworkAclQuintupleEntriesRequest"/></param>
        /// <returns><see cref="DeleteNetworkAclQuintupleEntriesResponse"/></returns>
        public Task<DeleteNetworkAclQuintupleEntriesResponse> DeleteNetworkAclQuintupleEntries(DeleteNetworkAclQuintupleEntriesRequest req)
        {
            return InternalRequestAsync<DeleteNetworkAclQuintupleEntriesResponse>(req, "DeleteNetworkAclQuintupleEntries");
        }

        /// <summary>
        /// This API is used to delete specified in/outbound rules of the network ACL quintuple. In the `NetworkAclQuintupleEntrySet` parameters, `NetworkAclQuintupleEntryId` is required for `NetworkAclQuintupleEntry`.
        /// </summary>
        /// <param name="req"><see cref="DeleteNetworkAclQuintupleEntriesRequest"/></param>
        /// <returns><see cref="DeleteNetworkAclQuintupleEntriesResponse"/></returns>
        public DeleteNetworkAclQuintupleEntriesResponse DeleteNetworkAclQuintupleEntriesSync(DeleteNetworkAclQuintupleEntriesRequest req)
        {
            return InternalRequestAsync<DeleteNetworkAclQuintupleEntriesResponse>(req, "DeleteNetworkAclQuintupleEntries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        public Task<DeleteNetworkInterfaceResponse> DeleteNetworkInterface(DeleteNetworkInterfaceRequest req)
        {
            return InternalRequestAsync<DeleteNetworkInterfaceResponse>(req, "DeleteNetworkInterface");
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
            return InternalRequestAsync<DeleteNetworkInterfaceResponse>(req, "DeleteNetworkInterface")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a route table.
        /// </summary>
        /// <param name="req"><see cref="DeleteRouteTableRequest"/></param>
        /// <returns><see cref="DeleteRouteTableResponse"/></returns>
        public Task<DeleteRouteTableResponse> DeleteRouteTable(DeleteRouteTableRequest req)
        {
            return InternalRequestAsync<DeleteRouteTableResponse>(req, "DeleteRouteTable");
        }

        /// <summary>
        /// This API is used to delete a route table.
        /// </summary>
        /// <param name="req"><see cref="DeleteRouteTableRequest"/></param>
        /// <returns><see cref="DeleteRouteTableResponse"/></returns>
        public DeleteRouteTableResponse DeleteRouteTableSync(DeleteRouteTableRequest req)
        {
            return InternalRequestAsync<DeleteRouteTableResponse>(req, "DeleteRouteTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DeleteRoutes) is used to delete routing policies in batches from a route table.
        /// </summary>
        /// <param name="req"><see cref="DeleteRoutesRequest"/></param>
        /// <returns><see cref="DeleteRoutesResponse"/></returns>
        public Task<DeleteRoutesResponse> DeleteRoutes(DeleteRoutesRequest req)
        {
            return InternalRequestAsync<DeleteRoutesResponse>(req, "DeleteRoutes");
        }

        /// <summary>
        /// This API (DeleteRoutes) is used to delete routing policies in batches from a route table.
        /// </summary>
        /// <param name="req"><see cref="DeleteRoutesRequest"/></param>
        /// <returns><see cref="DeleteRoutesResponse"/></returns>
        public DeleteRoutesResponse DeleteRoutesSync(DeleteRoutesRequest req)
        {
            return InternalRequestAsync<DeleteRoutesResponse>(req, "DeleteRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DeleteSecurityGroup) is used to delete security groups (SecurityGroup).
        /// * Only security groups under the current account can be deleted.
        /// * A security group cannot be deleted directly if its instance ID is used in the policy of another security group. You need to modify the policy first and then delete the security group.
        /// * A security group cannot be recovered after deletion, please proceed with caution.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityGroupRequest"/></param>
        /// <returns><see cref="DeleteSecurityGroupResponse"/></returns>
        public Task<DeleteSecurityGroupResponse> DeleteSecurityGroup(DeleteSecurityGroupRequest req)
        {
            return InternalRequestAsync<DeleteSecurityGroupResponse>(req, "DeleteSecurityGroup");
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
            return InternalRequestAsync<DeleteSecurityGroupResponse>(req, "DeleteSecurityGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DeleteSecurityGroupPolicies) is used to delete security group policies (SecurityGroupPolicy).
        /// * SecurityGroupPolicySet.Version is used to specify the version of the security group you are operating. If the specified Version number differs from the latest version of the current security group, a failure will be returned. If Version is not specified, the policy of the specified PolicyIndex will be deleted directly.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityGroupPoliciesRequest"/></param>
        /// <returns><see cref="DeleteSecurityGroupPoliciesResponse"/></returns>
        public Task<DeleteSecurityGroupPoliciesResponse> DeleteSecurityGroupPolicies(DeleteSecurityGroupPoliciesRequest req)
        {
            return InternalRequestAsync<DeleteSecurityGroupPoliciesResponse>(req, "DeleteSecurityGroupPolicies");
        }

        /// <summary>
        /// This API (DeleteSecurityGroupPolicies) is used to delete security group policies (SecurityGroupPolicy).
        /// * SecurityGroupPolicySet.Version is used to specify the version of the security group you are operating. If the specified Version number differs from the latest version of the current security group, a failure will be returned. If Version is not specified, the policy of the specified PolicyIndex will be deleted directly.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityGroupPoliciesRequest"/></param>
        /// <returns><see cref="DeleteSecurityGroupPoliciesResponse"/></returns>
        public DeleteSecurityGroupPoliciesResponse DeleteSecurityGroupPoliciesSync(DeleteSecurityGroupPoliciesRequest req)
        {
            return InternalRequestAsync<DeleteSecurityGroupPoliciesResponse>(req, "DeleteSecurityGroupPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DeleteServiceTemplate) is used to delete a protocol port template.
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceTemplateRequest"/></param>
        /// <returns><see cref="DeleteServiceTemplateResponse"/></returns>
        public Task<DeleteServiceTemplateResponse> DeleteServiceTemplate(DeleteServiceTemplateRequest req)
        {
            return InternalRequestAsync<DeleteServiceTemplateResponse>(req, "DeleteServiceTemplate");
        }

        /// <summary>
        /// This API (DeleteServiceTemplate) is used to delete a protocol port template.
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceTemplateRequest"/></param>
        /// <returns><see cref="DeleteServiceTemplateResponse"/></returns>
        public DeleteServiceTemplateResponse DeleteServiceTemplateSync(DeleteServiceTemplateRequest req)
        {
            return InternalRequestAsync<DeleteServiceTemplateResponse>(req, "DeleteServiceTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DeleteServiceTemplateGroup) is used to delete a protocol port template group.
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceTemplateGroupRequest"/></param>
        /// <returns><see cref="DeleteServiceTemplateGroupResponse"/></returns>
        public Task<DeleteServiceTemplateGroupResponse> DeleteServiceTemplateGroup(DeleteServiceTemplateGroupRequest req)
        {
            return InternalRequestAsync<DeleteServiceTemplateGroupResponse>(req, "DeleteServiceTemplateGroup");
        }

        /// <summary>
        /// This API (DeleteServiceTemplateGroup) is used to delete a protocol port template group.
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceTemplateGroupRequest"/></param>
        /// <returns><see cref="DeleteServiceTemplateGroupResponse"/></returns>
        public DeleteServiceTemplateGroupResponse DeleteServiceTemplateGroupSync(DeleteServiceTemplateGroupRequest req)
        {
            return InternalRequestAsync<DeleteServiceTemplateGroupResponse>(req, "DeleteServiceTemplateGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete snapshot policies.
        /// </summary>
        /// <param name="req"><see cref="DeleteSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="DeleteSnapshotPoliciesResponse"/></returns>
        public Task<DeleteSnapshotPoliciesResponse> DeleteSnapshotPolicies(DeleteSnapshotPoliciesRequest req)
        {
            return InternalRequestAsync<DeleteSnapshotPoliciesResponse>(req, "DeleteSnapshotPolicies");
        }

        /// <summary>
        /// This API is used to delete snapshot policies.
        /// </summary>
        /// <param name="req"><see cref="DeleteSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="DeleteSnapshotPoliciesResponse"/></returns>
        public DeleteSnapshotPoliciesResponse DeleteSnapshotPoliciesSync(DeleteSnapshotPoliciesRequest req)
        {
            return InternalRequestAsync<DeleteSnapshotPoliciesResponse>(req, "DeleteSnapshotPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a subnet.
        /// * Remove all resources in the subnet before deleting it
        /// </summary>
        /// <param name="req"><see cref="DeleteSubnetRequest"/></param>
        /// <returns><see cref="DeleteSubnetResponse"/></returns>
        public Task<DeleteSubnetResponse> DeleteSubnet(DeleteSubnetRequest req)
        {
            return InternalRequestAsync<DeleteSubnetResponse>(req, "DeleteSubnet");
        }

        /// <summary>
        /// This API is used to delete a subnet.
        /// * Remove all resources in the subnet before deleting it
        /// </summary>
        /// <param name="req"><see cref="DeleteSubnetRequest"/></param>
        /// <returns><see cref="DeleteSubnetResponse"/></returns>
        public DeleteSubnetResponse DeleteSubnetSync(DeleteSubnetRequest req)
        {
            return InternalRequestAsync<DeleteSubnetResponse>(req, "DeleteSubnet")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete traffic packages. Note that only non-valid traffic packages can be deleted. 
        /// </summary>
        /// <param name="req"><see cref="DeleteTrafficPackagesRequest"/></param>
        /// <returns><see cref="DeleteTrafficPackagesResponse"/></returns>
        public Task<DeleteTrafficPackagesResponse> DeleteTrafficPackages(DeleteTrafficPackagesRequest req)
        {
            return InternalRequestAsync<DeleteTrafficPackagesResponse>(req, "DeleteTrafficPackages");
        }

        /// <summary>
        /// This API is used to delete traffic packages. Note that only non-valid traffic packages can be deleted. 
        /// </summary>
        /// <param name="req"><see cref="DeleteTrafficPackagesRequest"/></param>
        /// <returns><see cref="DeleteTrafficPackagesResponse"/></returns>
        public DeleteTrafficPackagesResponse DeleteTrafficPackagesSync(DeleteTrafficPackagesRequest req)
        {
            return InternalRequestAsync<DeleteTrafficPackagesResponse>(req, "DeleteTrafficPackages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DeleteVpc) is used to delete VPCs.
        /// * Before deleting a VPC, ensure that the VPC contains no resources, including CVMs, cloud databases, NoSQL databases, VPN gateways, direct connect gateways, load balancers, peering connections, and basic network devices that are linked to the VPC.
        /// * The deletion of VPCs is irreversible. Proceed with caution.
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcRequest"/></param>
        /// <returns><see cref="DeleteVpcResponse"/></returns>
        public Task<DeleteVpcResponse> DeleteVpc(DeleteVpcRequest req)
        {
            return InternalRequestAsync<DeleteVpcResponse>(req, "DeleteVpc");
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
            return InternalRequestAsync<DeleteVpcResponse>(req, "DeleteVpc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an endpoint.
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcEndPointRequest"/></param>
        /// <returns><see cref="DeleteVpcEndPointResponse"/></returns>
        public Task<DeleteVpcEndPointResponse> DeleteVpcEndPoint(DeleteVpcEndPointRequest req)
        {
            return InternalRequestAsync<DeleteVpcEndPointResponse>(req, "DeleteVpcEndPoint");
        }

        /// <summary>
        /// This API is used to delete an endpoint.
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcEndPointRequest"/></param>
        /// <returns><see cref="DeleteVpcEndPointResponse"/></returns>
        public DeleteVpcEndPointResponse DeleteVpcEndPointSync(DeleteVpcEndPointRequest req)
        {
            return InternalRequestAsync<DeleteVpcEndPointResponse>(req, "DeleteVpcEndPoint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an endpoint service.
        /// 
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcEndPointServiceRequest"/></param>
        /// <returns><see cref="DeleteVpcEndPointServiceResponse"/></returns>
        public Task<DeleteVpcEndPointServiceResponse> DeleteVpcEndPointService(DeleteVpcEndPointServiceRequest req)
        {
            return InternalRequestAsync<DeleteVpcEndPointServiceResponse>(req, "DeleteVpcEndPointService");
        }

        /// <summary>
        /// This API is used to delete an endpoint service.
        /// 
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcEndPointServiceRequest"/></param>
        /// <returns><see cref="DeleteVpcEndPointServiceResponse"/></returns>
        public DeleteVpcEndPointServiceResponse DeleteVpcEndPointServiceSync(DeleteVpcEndPointServiceRequest req)
        {
            return InternalRequestAsync<DeleteVpcEndPointServiceResponse>(req, "DeleteVpcEndPointService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the endpoint service allowlist.
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcEndPointServiceWhiteListRequest"/></param>
        /// <returns><see cref="DeleteVpcEndPointServiceWhiteListResponse"/></returns>
        public Task<DeleteVpcEndPointServiceWhiteListResponse> DeleteVpcEndPointServiceWhiteList(DeleteVpcEndPointServiceWhiteListRequest req)
        {
            return InternalRequestAsync<DeleteVpcEndPointServiceWhiteListResponse>(req, "DeleteVpcEndPointServiceWhiteList");
        }

        /// <summary>
        /// This API is used to delete the endpoint service allowlist.
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcEndPointServiceWhiteListRequest"/></param>
        /// <returns><see cref="DeleteVpcEndPointServiceWhiteListResponse"/></returns>
        public DeleteVpcEndPointServiceWhiteListResponse DeleteVpcEndPointServiceWhiteListSync(DeleteVpcEndPointServiceWhiteListRequest req)
        {
            return InternalRequestAsync<DeleteVpcEndPointServiceWhiteListResponse>(req, "DeleteVpcEndPointServiceWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a VPN tunnel.
        /// </summary>
        /// <param name="req"><see cref="DeleteVpnConnectionRequest"/></param>
        /// <returns><see cref="DeleteVpnConnectionResponse"/></returns>
        public Task<DeleteVpnConnectionResponse> DeleteVpnConnection(DeleteVpnConnectionRequest req)
        {
            return InternalRequestAsync<DeleteVpnConnectionResponse>(req, "DeleteVpnConnection");
        }

        /// <summary>
        /// This API is used to delete a VPN tunnel.
        /// </summary>
        /// <param name="req"><see cref="DeleteVpnConnectionRequest"/></param>
        /// <returns><see cref="DeleteVpnConnectionResponse"/></returns>
        public DeleteVpnConnectionResponse DeleteVpnConnectionSync(DeleteVpnConnectionRequest req)
        {
            return InternalRequestAsync<DeleteVpnConnectionResponse>(req, "DeleteVpnConnection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DeleteVpnGateway) is used to delete a VPN gateway. Currently, only deletion of pay-as-you-go IPSEC gateway instances in running status is supported.
        /// </summary>
        /// <param name="req"><see cref="DeleteVpnGatewayRequest"/></param>
        /// <returns><see cref="DeleteVpnGatewayResponse"/></returns>
        public Task<DeleteVpnGatewayResponse> DeleteVpnGateway(DeleteVpnGatewayRequest req)
        {
            return InternalRequestAsync<DeleteVpnGatewayResponse>(req, "DeleteVpnGateway");
        }

        /// <summary>
        /// This API (DeleteVpnGateway) is used to delete a VPN gateway. Currently, only deletion of pay-as-you-go IPSEC gateway instances in running status is supported.
        /// </summary>
        /// <param name="req"><see cref="DeleteVpnGatewayRequest"/></param>
        /// <returns><see cref="DeleteVpnGatewayResponse"/></returns>
        public DeleteVpnGatewayResponse DeleteVpnGatewaySync(DeleteVpnGatewayRequest req)
        {
            return InternalRequestAsync<DeleteVpnGatewayResponse>(req, "DeleteVpnGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete routes of a VPN gateway. 
        /// </summary>
        /// <param name="req"><see cref="DeleteVpnGatewayRoutesRequest"/></param>
        /// <returns><see cref="DeleteVpnGatewayRoutesResponse"/></returns>
        public Task<DeleteVpnGatewayRoutesResponse> DeleteVpnGatewayRoutes(DeleteVpnGatewayRoutesRequest req)
        {
            return InternalRequestAsync<DeleteVpnGatewayRoutesResponse>(req, "DeleteVpnGatewayRoutes");
        }

        /// <summary>
        /// This API is used to delete routes of a VPN gateway. 
        /// </summary>
        /// <param name="req"><see cref="DeleteVpnGatewayRoutesRequest"/></param>
        /// <returns><see cref="DeleteVpnGatewayRoutesResponse"/></returns>
        public DeleteVpnGatewayRoutesResponse DeleteVpnGatewayRoutesSync(DeleteVpnGatewayRoutesRequest req)
        {
            return InternalRequestAsync<DeleteVpnGatewayRoutesResponse>(req, "DeleteVpnGatewayRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeAccountAttributes) is used to query your account attributes.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountAttributesRequest"/></param>
        /// <returns><see cref="DescribeAccountAttributesResponse"/></returns>
        public Task<DescribeAccountAttributesResponse> DescribeAccountAttributes(DescribeAccountAttributesRequest req)
        {
            return InternalRequestAsync<DescribeAccountAttributesResponse>(req, "DescribeAccountAttributes");
        }

        /// <summary>
        /// This API (DescribeAccountAttributes) is used to query your account attributes.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountAttributesRequest"/></param>
        /// <returns><see cref="DescribeAccountAttributesResponse"/></returns>
        public DescribeAccountAttributesResponse DescribeAccountAttributesSync(DescribeAccountAttributesRequest req)
        {
            return InternalRequestAsync<DescribeAccountAttributesResponse>(req, "DescribeAccountAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeAddressQuota) is used to query the quota information of your [Elastic IP](https://intl.cloud.tencent.com/document/product/213/1941?from_cn_redirect=1) (EIP) in the current region. For more information, see [EIP product introduction](https://intl.cloud.tencent.com/document/product/213/5733?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressQuotaRequest"/></param>
        /// <returns><see cref="DescribeAddressQuotaResponse"/></returns>
        public Task<DescribeAddressQuotaResponse> DescribeAddressQuota(DescribeAddressQuotaRequest req)
        {
            return InternalRequestAsync<DescribeAddressQuotaResponse>(req, "DescribeAddressQuota");
        }

        /// <summary>
        /// This API (DescribeAddressQuota) is used to query the quota information of your [Elastic IP](https://intl.cloud.tencent.com/document/product/213/1941?from_cn_redirect=1) (EIP) in the current region. For more information, see [EIP product introduction](https://intl.cloud.tencent.com/document/product/213/5733?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressQuotaRequest"/></param>
        /// <returns><see cref="DescribeAddressQuotaResponse"/></returns>
        public DescribeAddressQuotaResponse DescribeAddressQuotaSync(DescribeAddressQuotaRequest req)
        {
            return InternalRequestAsync<DescribeAddressQuotaResponse>(req, "DescribeAddressQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeAddressTemplateGroups) is used to query an IP address template group.
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressTemplateGroupsRequest"/></param>
        /// <returns><see cref="DescribeAddressTemplateGroupsResponse"/></returns>
        public Task<DescribeAddressTemplateGroupsResponse> DescribeAddressTemplateGroups(DescribeAddressTemplateGroupsRequest req)
        {
            return InternalRequestAsync<DescribeAddressTemplateGroupsResponse>(req, "DescribeAddressTemplateGroups");
        }

        /// <summary>
        /// This API (DescribeAddressTemplateGroups) is used to query an IP address template group.
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressTemplateGroupsRequest"/></param>
        /// <returns><see cref="DescribeAddressTemplateGroupsResponse"/></returns>
        public DescribeAddressTemplateGroupsResponse DescribeAddressTemplateGroupsSync(DescribeAddressTemplateGroupsRequest req)
        {
            return InternalRequestAsync<DescribeAddressTemplateGroupsResponse>(req, "DescribeAddressTemplateGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeAddressTemplates) is used to query an IP address template.
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAddressTemplatesResponse"/></returns>
        public Task<DescribeAddressTemplatesResponse> DescribeAddressTemplates(DescribeAddressTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeAddressTemplatesResponse>(req, "DescribeAddressTemplates");
        }

        /// <summary>
        /// This API (DescribeAddressTemplates) is used to query an IP address template.
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAddressTemplatesResponse"/></returns>
        public DescribeAddressTemplatesResponse DescribeAddressTemplatesSync(DescribeAddressTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeAddressTemplatesResponse>(req, "DescribeAddressTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeAddresses) is used to query the information of one or multiple [Elastic IPs](https://intl.cloud.tencent.com/document/product/213/1941?from_cn_redirect=1).
        /// * If the parameter is empty, a number (as specified by the `Limit`, the default value is 20) of EIPs will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressesRequest"/></param>
        /// <returns><see cref="DescribeAddressesResponse"/></returns>
        public Task<DescribeAddressesResponse> DescribeAddresses(DescribeAddressesRequest req)
        {
            return InternalRequestAsync<DescribeAddressesResponse>(req, "DescribeAddresses");
        }

        /// <summary>
        /// This API (DescribeAddresses) is used to query the information of one or multiple [Elastic IPs](https://intl.cloud.tencent.com/document/product/213/1941?from_cn_redirect=1).
        /// * If the parameter is empty, a number (as specified by the `Limit`, the default value is 20) of EIPs will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressesRequest"/></param>
        /// <returns><see cref="DescribeAddressesResponse"/></returns>
        public DescribeAddressesResponse DescribeAddressesSync(DescribeAddressesRequest req)
        {
            return InternalRequestAsync<DescribeAddressesResponse>(req, "DescribeAddresses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of secondary CIDR blocks.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssistantCidrRequest"/></param>
        /// <returns><see cref="DescribeAssistantCidrResponse"/></returns>
        public Task<DescribeAssistantCidrResponse> DescribeAssistantCidr(DescribeAssistantCidrRequest req)
        {
            return InternalRequestAsync<DescribeAssistantCidrResponse>(req, "DescribeAssistantCidr");
        }

        /// <summary>
        /// This API is used to query the list of secondary CIDR blocks.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssistantCidrRequest"/></param>
        /// <returns><see cref="DescribeAssistantCidrResponse"/></returns>
        public DescribeAssistantCidrResponse DescribeAssistantCidrSync(DescribeAssistantCidrRequest req)
        {
            return InternalRequestAsync<DescribeAssistantCidrResponse>(req, "DescribeAssistantCidr")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the current billable usage of a pay-as-you-go bandwidth package.
        /// </summary>
        /// <param name="req"><see cref="DescribeBandwidthPackageBillUsageRequest"/></param>
        /// <returns><see cref="DescribeBandwidthPackageBillUsageResponse"/></returns>
        public Task<DescribeBandwidthPackageBillUsageResponse> DescribeBandwidthPackageBillUsage(DescribeBandwidthPackageBillUsageRequest req)
        {
            return InternalRequestAsync<DescribeBandwidthPackageBillUsageResponse>(req, "DescribeBandwidthPackageBillUsage");
        }

        /// <summary>
        /// This API is used to query the current billable usage of a pay-as-you-go bandwidth package.
        /// </summary>
        /// <param name="req"><see cref="DescribeBandwidthPackageBillUsageRequest"/></param>
        /// <returns><see cref="DescribeBandwidthPackageBillUsageResponse"/></returns>
        public DescribeBandwidthPackageBillUsageResponse DescribeBandwidthPackageBillUsageSync(DescribeBandwidthPackageBillUsageRequest req)
        {
            return InternalRequestAsync<DescribeBandwidthPackageBillUsageResponse>(req, "DescribeBandwidthPackageBillUsage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the maximum and used number of bandwidth packages under the account in the current region.
        /// </summary>
        /// <param name="req"><see cref="DescribeBandwidthPackageQuotaRequest"/></param>
        /// <returns><see cref="DescribeBandwidthPackageQuotaResponse"/></returns>
        public Task<DescribeBandwidthPackageQuotaResponse> DescribeBandwidthPackageQuota(DescribeBandwidthPackageQuotaRequest req)
        {
            return InternalRequestAsync<DescribeBandwidthPackageQuotaResponse>(req, "DescribeBandwidthPackageQuota");
        }

        /// <summary>
        /// This API is used to query the maximum and used number of bandwidth packages under the account in the current region.
        /// </summary>
        /// <param name="req"><see cref="DescribeBandwidthPackageQuotaRequest"/></param>
        /// <returns><see cref="DescribeBandwidthPackageQuotaResponse"/></returns>
        public DescribeBandwidthPackageQuotaResponse DescribeBandwidthPackageQuotaSync(DescribeBandwidthPackageQuotaRequest req)
        {
            return InternalRequestAsync<DescribeBandwidthPackageQuotaResponse>(req, "DescribeBandwidthPackageQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query resources in a bandwidth package based on the unique package ID. You can filter the result by specifying conditions and paginate the query results.
        /// </summary>
        /// <param name="req"><see cref="DescribeBandwidthPackageResourcesRequest"/></param>
        /// <returns><see cref="DescribeBandwidthPackageResourcesResponse"/></returns>
        public Task<DescribeBandwidthPackageResourcesResponse> DescribeBandwidthPackageResources(DescribeBandwidthPackageResourcesRequest req)
        {
            return InternalRequestAsync<DescribeBandwidthPackageResourcesResponse>(req, "DescribeBandwidthPackageResources");
        }

        /// <summary>
        /// This API is used to query resources in a bandwidth package based on the unique package ID. You can filter the result by specifying conditions and paginate the query results.
        /// </summary>
        /// <param name="req"><see cref="DescribeBandwidthPackageResourcesRequest"/></param>
        /// <returns><see cref="DescribeBandwidthPackageResourcesResponse"/></returns>
        public DescribeBandwidthPackageResourcesResponse DescribeBandwidthPackageResourcesSync(DescribeBandwidthPackageResourcesRequest req)
        {
            return InternalRequestAsync<DescribeBandwidthPackageResourcesResponse>(req, "DescribeBandwidthPackageResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query bandwidth package information, including the unique ID of the bandwidth package, the type, the billing mode, the name, and the resource information.
        /// </summary>
        /// <param name="req"><see cref="DescribeBandwidthPackagesRequest"/></param>
        /// <returns><see cref="DescribeBandwidthPackagesResponse"/></returns>
        public Task<DescribeBandwidthPackagesResponse> DescribeBandwidthPackages(DescribeBandwidthPackagesRequest req)
        {
            return InternalRequestAsync<DescribeBandwidthPackagesResponse>(req, "DescribeBandwidthPackages");
        }

        /// <summary>
        /// This API is used to query bandwidth package information, including the unique ID of the bandwidth package, the type, the billing mode, the name, and the resource information.
        /// </summary>
        /// <param name="req"><see cref="DescribeBandwidthPackagesRequest"/></param>
        /// <returns><see cref="DescribeBandwidthPackagesResponse"/></returns>
        public DescribeBandwidthPackagesResponse DescribeBandwidthPackagesSync(DescribeBandwidthPackagesRequest req)
        {
            return InternalRequestAsync<DescribeBandwidthPackagesResponse>(req, "DescribeBandwidthPackages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeCcnAttachedInstances) is used to query the network instances associated with the CCN instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnAttachedInstancesRequest"/></param>
        /// <returns><see cref="DescribeCcnAttachedInstancesResponse"/></returns>
        public Task<DescribeCcnAttachedInstancesResponse> DescribeCcnAttachedInstances(DescribeCcnAttachedInstancesRequest req)
        {
            return InternalRequestAsync<DescribeCcnAttachedInstancesResponse>(req, "DescribeCcnAttachedInstances");
        }

        /// <summary>
        /// This API (DescribeCcnAttachedInstances) is used to query the network instances associated with the CCN instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnAttachedInstancesRequest"/></param>
        /// <returns><see cref="DescribeCcnAttachedInstancesResponse"/></returns>
        public DescribeCcnAttachedInstancesResponse DescribeCcnAttachedInstancesSync(DescribeCcnAttachedInstancesRequest req)
        {
            return InternalRequestAsync<DescribeCcnAttachedInstancesResponse>(req, "DescribeCcnAttachedInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the outbound bandwidth caps of all regions connected with a CCN instance. The API only returns regions included in the associated network instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnRegionBandwidthLimitsRequest"/></param>
        /// <returns><see cref="DescribeCcnRegionBandwidthLimitsResponse"/></returns>
        public Task<DescribeCcnRegionBandwidthLimitsResponse> DescribeCcnRegionBandwidthLimits(DescribeCcnRegionBandwidthLimitsRequest req)
        {
            return InternalRequestAsync<DescribeCcnRegionBandwidthLimitsResponse>(req, "DescribeCcnRegionBandwidthLimits");
        }

        /// <summary>
        /// This API is used to query the outbound bandwidth caps of all regions connected with a CCN instance. The API only returns regions included in the associated network instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnRegionBandwidthLimitsRequest"/></param>
        /// <returns><see cref="DescribeCcnRegionBandwidthLimitsResponse"/></returns>
        public DescribeCcnRegionBandwidthLimitsResponse DescribeCcnRegionBandwidthLimitsSync(DescribeCcnRegionBandwidthLimitsRequest req)
        {
            return InternalRequestAsync<DescribeCcnRegionBandwidthLimitsResponse>(req, "DescribeCcnRegionBandwidthLimits")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeCcnRoutes) is used to query routes that have been added to a CCN.
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnRoutesRequest"/></param>
        /// <returns><see cref="DescribeCcnRoutesResponse"/></returns>
        public Task<DescribeCcnRoutesResponse> DescribeCcnRoutes(DescribeCcnRoutesRequest req)
        {
            return InternalRequestAsync<DescribeCcnRoutesResponse>(req, "DescribeCcnRoutes");
        }

        /// <summary>
        /// This API (DescribeCcnRoutes) is used to query routes that have been added to a CCN.
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnRoutesRequest"/></param>
        /// <returns><see cref="DescribeCcnRoutesResponse"/></returns>
        public DescribeCcnRoutesResponse DescribeCcnRoutesSync(DescribeCcnRoutesRequest req)
        {
            return InternalRequestAsync<DescribeCcnRoutesResponse>(req, "DescribeCcnRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeCcns) is used to query the CCN list.
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnsRequest"/></param>
        /// <returns><see cref="DescribeCcnsResponse"/></returns>
        public Task<DescribeCcnsResponse> DescribeCcns(DescribeCcnsRequest req)
        {
            return InternalRequestAsync<DescribeCcnsResponse>(req, "DescribeCcns");
        }

        /// <summary>
        /// This API (DescribeCcns) is used to query the CCN list.
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnsRequest"/></param>
        /// <returns><see cref="DescribeCcnsResponse"/></returns>
        public DescribeCcnsResponse DescribeCcnsSync(DescribeCcnsRequest req)
        {
            return InternalRequestAsync<DescribeCcnsResponse>(req, "DescribeCcns")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeClassicLinkInstances) is used to query the Classiclink instances list.
        /// </summary>
        /// <param name="req"><see cref="DescribeClassicLinkInstancesRequest"/></param>
        /// <returns><see cref="DescribeClassicLinkInstancesResponse"/></returns>
        public Task<DescribeClassicLinkInstancesResponse> DescribeClassicLinkInstances(DescribeClassicLinkInstancesRequest req)
        {
            return InternalRequestAsync<DescribeClassicLinkInstancesResponse>(req, "DescribeClassicLinkInstances");
        }

        /// <summary>
        /// This API (DescribeClassicLinkInstances) is used to query the Classiclink instances list.
        /// </summary>
        /// <param name="req"><see cref="DescribeClassicLinkInstancesRequest"/></param>
        /// <returns><see cref="DescribeClassicLinkInstancesResponse"/></returns>
        public DescribeClassicLinkInstancesResponse DescribeClassicLinkInstancesSync(DescribeClassicLinkInstancesRequest req)
        {
            return InternalRequestAsync<DescribeClassicLinkInstancesResponse>(req, "DescribeClassicLinkInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the compliance review requests created by the user. 
        /// A service provider can query all review requests created by any `APPID` under its account. Other users can only query their own review requests.
        /// </summary>
        /// <param name="req"><see cref="DescribeCrossBorderComplianceRequest"/></param>
        /// <returns><see cref="DescribeCrossBorderComplianceResponse"/></returns>
        public Task<DescribeCrossBorderComplianceResponse> DescribeCrossBorderCompliance(DescribeCrossBorderComplianceRequest req)
        {
            return InternalRequestAsync<DescribeCrossBorderComplianceResponse>(req, "DescribeCrossBorderCompliance");
        }

        /// <summary>
        /// This API is used to query the compliance review requests created by the user. 
        /// A service provider can query all review requests created by any `APPID` under its account. Other users can only query their own review requests.
        /// </summary>
        /// <param name="req"><see cref="DescribeCrossBorderComplianceRequest"/></param>
        /// <returns><see cref="DescribeCrossBorderComplianceResponse"/></returns>
        public DescribeCrossBorderComplianceResponse DescribeCrossBorderComplianceSync(DescribeCrossBorderComplianceRequest req)
        {
            return InternalRequestAsync<DescribeCrossBorderComplianceResponse>(req, "DescribeCrossBorderCompliance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeCustomerGatewayVendors) is used to query the information of supported customer gateway vendors.
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomerGatewayVendorsRequest"/></param>
        /// <returns><see cref="DescribeCustomerGatewayVendorsResponse"/></returns>
        public Task<DescribeCustomerGatewayVendorsResponse> DescribeCustomerGatewayVendors(DescribeCustomerGatewayVendorsRequest req)
        {
            return InternalRequestAsync<DescribeCustomerGatewayVendorsResponse>(req, "DescribeCustomerGatewayVendors");
        }

        /// <summary>
        /// This API (DescribeCustomerGatewayVendors) is used to query the information of supported customer gateway vendors.
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomerGatewayVendorsRequest"/></param>
        /// <returns><see cref="DescribeCustomerGatewayVendorsResponse"/></returns>
        public DescribeCustomerGatewayVendorsResponse DescribeCustomerGatewayVendorsSync(DescribeCustomerGatewayVendorsRequest req)
        {
            return InternalRequestAsync<DescribeCustomerGatewayVendorsResponse>(req, "DescribeCustomerGatewayVendors")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeCustomerGateways) is used to query the customer gateway list.
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomerGatewaysRequest"/></param>
        /// <returns><see cref="DescribeCustomerGatewaysResponse"/></returns>
        public Task<DescribeCustomerGatewaysResponse> DescribeCustomerGateways(DescribeCustomerGatewaysRequest req)
        {
            return InternalRequestAsync<DescribeCustomerGatewaysResponse>(req, "DescribeCustomerGateways");
        }

        /// <summary>
        /// This API (DescribeCustomerGateways) is used to query the customer gateway list.
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomerGatewaysRequest"/></param>
        /// <returns><see cref="DescribeCustomerGatewaysResponse"/></returns>
        public DescribeCustomerGatewaysResponse DescribeCustomerGatewaysSync(DescribeCustomerGatewaysRequest req)
        {
            return InternalRequestAsync<DescribeCustomerGatewaysResponse>(req, "DescribeCustomerGateways")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeDirectConnectGatewayCcnRoutes) is used to query the CCN routes (IDC IP range) of the Direct Connect gateway.
        /// </summary>
        /// <param name="req"><see cref="DescribeDirectConnectGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="DescribeDirectConnectGatewayCcnRoutesResponse"/></returns>
        public Task<DescribeDirectConnectGatewayCcnRoutesResponse> DescribeDirectConnectGatewayCcnRoutes(DescribeDirectConnectGatewayCcnRoutesRequest req)
        {
            return InternalRequestAsync<DescribeDirectConnectGatewayCcnRoutesResponse>(req, "DescribeDirectConnectGatewayCcnRoutes");
        }

        /// <summary>
        /// This API (DescribeDirectConnectGatewayCcnRoutes) is used to query the CCN routes (IDC IP range) of the Direct Connect gateway.
        /// </summary>
        /// <param name="req"><see cref="DescribeDirectConnectGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="DescribeDirectConnectGatewayCcnRoutesResponse"/></returns>
        public DescribeDirectConnectGatewayCcnRoutesResponse DescribeDirectConnectGatewayCcnRoutesSync(DescribeDirectConnectGatewayCcnRoutesRequest req)
        {
            return InternalRequestAsync<DescribeDirectConnectGatewayCcnRoutesResponse>(req, "DescribeDirectConnectGatewayCcnRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query direct connect gateways.
        /// </summary>
        /// <param name="req"><see cref="DescribeDirectConnectGatewaysRequest"/></param>
        /// <returns><see cref="DescribeDirectConnectGatewaysResponse"/></returns>
        public Task<DescribeDirectConnectGatewaysResponse> DescribeDirectConnectGateways(DescribeDirectConnectGatewaysRequest req)
        {
            return InternalRequestAsync<DescribeDirectConnectGatewaysResponse>(req, "DescribeDirectConnectGateways");
        }

        /// <summary>
        /// This API is used to query direct connect gateways.
        /// </summary>
        /// <param name="req"><see cref="DescribeDirectConnectGatewaysRequest"/></param>
        /// <returns><see cref="DescribeDirectConnectGatewaysResponse"/></returns>
        public DescribeDirectConnectGatewaysResponse DescribeDirectConnectGatewaysSync(DescribeDirectConnectGatewaysRequest req)
        {
            return InternalRequestAsync<DescribeDirectConnectGatewaysResponse>(req, "DescribeDirectConnectGateways")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of a flow log.
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowLogRequest"/></param>
        /// <returns><see cref="DescribeFlowLogResponse"/></returns>
        public Task<DescribeFlowLogResponse> DescribeFlowLog(DescribeFlowLogRequest req)
        {
            return InternalRequestAsync<DescribeFlowLogResponse>(req, "DescribeFlowLog");
        }

        /// <summary>
        /// This API is used to query the information of a flow log.
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowLogRequest"/></param>
        /// <returns><see cref="DescribeFlowLogResponse"/></returns>
        public DescribeFlowLogResponse DescribeFlowLogSync(DescribeFlowLogRequest req)
        {
            return InternalRequestAsync<DescribeFlowLogResponse>(req, "DescribeFlowLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query all the flow logs of the current account.
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowLogsRequest"/></param>
        /// <returns><see cref="DescribeFlowLogsResponse"/></returns>
        public Task<DescribeFlowLogsResponse> DescribeFlowLogs(DescribeFlowLogsRequest req)
        {
            return InternalRequestAsync<DescribeFlowLogsResponse>(req, "DescribeFlowLogs");
        }

        /// <summary>
        /// This API is used to query all the flow logs of the current account.
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowLogsRequest"/></param>
        /// <returns><see cref="DescribeFlowLogsResponse"/></returns>
        public DescribeFlowLogsResponse DescribeFlowLogsSync(DescribeFlowLogsRequest req)
        {
            return InternalRequestAsync<DescribeFlowLogsResponse>(req, "DescribeFlowLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the traffic monitoring details of the gateway.
        /// * You can only use this API to query a single gateway instance, which means you must pass in only one of `VpnId`, `DirectConnectGatewayId`, `PeeringConnectionId`, or `NatId`.
        /// * If the gateway has traffic, but no data is returned when this API is called, please check whether gateway traffic monitoring has been enabled in the corresponding gateway details page in the console.
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayFlowMonitorDetailRequest"/></param>
        /// <returns><see cref="DescribeGatewayFlowMonitorDetailResponse"/></returns>
        public Task<DescribeGatewayFlowMonitorDetailResponse> DescribeGatewayFlowMonitorDetail(DescribeGatewayFlowMonitorDetailRequest req)
        {
            return InternalRequestAsync<DescribeGatewayFlowMonitorDetailResponse>(req, "DescribeGatewayFlowMonitorDetail");
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
            return InternalRequestAsync<DescribeGatewayFlowMonitorDetailResponse>(req, "DescribeGatewayFlowMonitorDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the inbound IP bandwidth limit of a gateway.
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayFlowQosRequest"/></param>
        /// <returns><see cref="DescribeGatewayFlowQosResponse"/></returns>
        public Task<DescribeGatewayFlowQosResponse> DescribeGatewayFlowQos(DescribeGatewayFlowQosRequest req)
        {
            return InternalRequestAsync<DescribeGatewayFlowQosResponse>(req, "DescribeGatewayFlowQos");
        }

        /// <summary>
        /// This API is used to query the inbound IP bandwidth limit of a gateway.
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayFlowQosRequest"/></param>
        /// <returns><see cref="DescribeGatewayFlowQosResponse"/></returns>
        public DescribeGatewayFlowQosResponse DescribeGatewayFlowQosSync(DescribeGatewayFlowQosRequest req)
        {
            return InternalRequestAsync<DescribeGatewayFlowQosResponse>(req, "DescribeGatewayFlowQos")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeHaVips) is used to query the list of highly available virtual IPs (HAVIP).
        /// </summary>
        /// <param name="req"><see cref="DescribeHaVipsRequest"/></param>
        /// <returns><see cref="DescribeHaVipsResponse"/></returns>
        public Task<DescribeHaVipsResponse> DescribeHaVips(DescribeHaVipsRequest req)
        {
            return InternalRequestAsync<DescribeHaVipsResponse>(req, "DescribeHaVips");
        }

        /// <summary>
        /// This API (DescribeHaVips) is used to query the list of highly available virtual IPs (HAVIP).
        /// </summary>
        /// <param name="req"><see cref="DescribeHaVipsRequest"/></param>
        /// <returns><see cref="DescribeHaVipsResponse"/></returns>
        public DescribeHaVipsResponse DescribeHaVipsSync(DescribeHaVipsRequest req)
        {
            return InternalRequestAsync<DescribeHaVipsResponse>(req, "DescribeHaVips")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the download link of an IP location database.
        /// <font color="#FF0000">This API will be discontinued soon and is only available for existing users.</font>
        /// </summary>
        /// <param name="req"><see cref="DescribeIpGeolocationDatabaseUrlRequest"/></param>
        /// <returns><see cref="DescribeIpGeolocationDatabaseUrlResponse"/></returns>
        public Task<DescribeIpGeolocationDatabaseUrlResponse> DescribeIpGeolocationDatabaseUrl(DescribeIpGeolocationDatabaseUrlRequest req)
        {
            return InternalRequestAsync<DescribeIpGeolocationDatabaseUrlResponse>(req, "DescribeIpGeolocationDatabaseUrl");
        }

        /// <summary>
        /// This API is used to obtain the download link of an IP location database.
        /// <font color="#FF0000">This API will be discontinued soon and is only available for existing users.</font>
        /// </summary>
        /// <param name="req"><see cref="DescribeIpGeolocationDatabaseUrlRequest"/></param>
        /// <returns><see cref="DescribeIpGeolocationDatabaseUrlResponse"/></returns>
        public DescribeIpGeolocationDatabaseUrlResponse DescribeIpGeolocationDatabaseUrlSync(DescribeIpGeolocationDatabaseUrlRequest req)
        {
            return InternalRequestAsync<DescribeIpGeolocationDatabaseUrlResponse>(req, "DescribeIpGeolocationDatabaseUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the location and network information of one or more IP addresses.
        /// <font color="#FF0000">This API will be discontinued soon and is only available for existing users.</font>
        /// </summary>
        /// <param name="req"><see cref="DescribeIpGeolocationInfosRequest"/></param>
        /// <returns><see cref="DescribeIpGeolocationInfosResponse"/></returns>
        public Task<DescribeIpGeolocationInfosResponse> DescribeIpGeolocationInfos(DescribeIpGeolocationInfosRequest req)
        {
            return InternalRequestAsync<DescribeIpGeolocationInfosResponse>(req, "DescribeIpGeolocationInfos");
        }

        /// <summary>
        /// This API is used to query the location and network information of one or more IP addresses.
        /// <font color="#FF0000">This API will be discontinued soon and is only available for existing users.</font>
        /// </summary>
        /// <param name="req"><see cref="DescribeIpGeolocationInfosRequest"/></param>
        /// <returns><see cref="DescribeIpGeolocationInfosResponse"/></returns>
        public DescribeIpGeolocationInfosResponse DescribeIpGeolocationInfosSync(DescribeIpGeolocationInfosRequest req)
        {
            return InternalRequestAsync<DescribeIpGeolocationInfosResponse>(req, "DescribeIpGeolocationInfos")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query local gateways of a CDC instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeLocalGatewayRequest"/></param>
        /// <returns><see cref="DescribeLocalGatewayResponse"/></returns>
        public Task<DescribeLocalGatewayResponse> DescribeLocalGateway(DescribeLocalGatewayRequest req)
        {
            return InternalRequestAsync<DescribeLocalGatewayResponse>(req, "DescribeLocalGateway");
        }

        /// <summary>
        /// This API is used to query local gateways of a CDC instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeLocalGatewayRequest"/></param>
        /// <returns><see cref="DescribeLocalGatewayResponse"/></returns>
        public DescribeLocalGatewayResponse DescribeLocalGatewaySync(DescribeLocalGatewayRequest req)
        {
            return InternalRequestAsync<DescribeLocalGatewayResponse>(req, "DescribeLocalGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the array of objects of a NAT gateway's port forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeNatGatewayDestinationIpPortTranslationNatRulesRequest"/></param>
        /// <returns><see cref="DescribeNatGatewayDestinationIpPortTranslationNatRulesResponse"/></returns>
        public Task<DescribeNatGatewayDestinationIpPortTranslationNatRulesResponse> DescribeNatGatewayDestinationIpPortTranslationNatRules(DescribeNatGatewayDestinationIpPortTranslationNatRulesRequest req)
        {
            return InternalRequestAsync<DescribeNatGatewayDestinationIpPortTranslationNatRulesResponse>(req, "DescribeNatGatewayDestinationIpPortTranslationNatRules");
        }

        /// <summary>
        /// This API is used to query the array of objects of a NAT gateway's port forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeNatGatewayDestinationIpPortTranslationNatRulesRequest"/></param>
        /// <returns><see cref="DescribeNatGatewayDestinationIpPortTranslationNatRulesResponse"/></returns>
        public DescribeNatGatewayDestinationIpPortTranslationNatRulesResponse DescribeNatGatewayDestinationIpPortTranslationNatRulesSync(DescribeNatGatewayDestinationIpPortTranslationNatRulesRequest req)
        {
            return InternalRequestAsync<DescribeNatGatewayDestinationIpPortTranslationNatRulesResponse>(req, "DescribeNatGatewayDestinationIpPortTranslationNatRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the routes between a NAT gateway and Direct Connect.
        /// </summary>
        /// <param name="req"><see cref="DescribeNatGatewayDirectConnectGatewayRouteRequest"/></param>
        /// <returns><see cref="DescribeNatGatewayDirectConnectGatewayRouteResponse"/></returns>
        public Task<DescribeNatGatewayDirectConnectGatewayRouteResponse> DescribeNatGatewayDirectConnectGatewayRoute(DescribeNatGatewayDirectConnectGatewayRouteRequest req)
        {
            return InternalRequestAsync<DescribeNatGatewayDirectConnectGatewayRouteResponse>(req, "DescribeNatGatewayDirectConnectGatewayRoute");
        }

        /// <summary>
        /// This API is used to query the routes between a NAT gateway and Direct Connect.
        /// </summary>
        /// <param name="req"><see cref="DescribeNatGatewayDirectConnectGatewayRouteRequest"/></param>
        /// <returns><see cref="DescribeNatGatewayDirectConnectGatewayRouteResponse"/></returns>
        public DescribeNatGatewayDirectConnectGatewayRouteResponse DescribeNatGatewayDirectConnectGatewayRouteSync(DescribeNatGatewayDirectConnectGatewayRouteRequest req)
        {
            return InternalRequestAsync<DescribeNatGatewayDirectConnectGatewayRouteResponse>(req, "DescribeNatGatewayDirectConnectGatewayRoute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the NAT gateway's SNAT forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeNatGatewaySourceIpTranslationNatRulesRequest"/></param>
        /// <returns><see cref="DescribeNatGatewaySourceIpTranslationNatRulesResponse"/></returns>
        public Task<DescribeNatGatewaySourceIpTranslationNatRulesResponse> DescribeNatGatewaySourceIpTranslationNatRules(DescribeNatGatewaySourceIpTranslationNatRulesRequest req)
        {
            return InternalRequestAsync<DescribeNatGatewaySourceIpTranslationNatRulesResponse>(req, "DescribeNatGatewaySourceIpTranslationNatRules");
        }

        /// <summary>
        /// This API is used to query the NAT gateway's SNAT forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeNatGatewaySourceIpTranslationNatRulesRequest"/></param>
        /// <returns><see cref="DescribeNatGatewaySourceIpTranslationNatRulesResponse"/></returns>
        public DescribeNatGatewaySourceIpTranslationNatRulesResponse DescribeNatGatewaySourceIpTranslationNatRulesSync(DescribeNatGatewaySourceIpTranslationNatRulesRequest req)
        {
            return InternalRequestAsync<DescribeNatGatewaySourceIpTranslationNatRulesResponse>(req, "DescribeNatGatewaySourceIpTranslationNatRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query NAT gateways.
        /// </summary>
        /// <param name="req"><see cref="DescribeNatGatewaysRequest"/></param>
        /// <returns><see cref="DescribeNatGatewaysResponse"/></returns>
        public Task<DescribeNatGatewaysResponse> DescribeNatGateways(DescribeNatGatewaysRequest req)
        {
            return InternalRequestAsync<DescribeNatGatewaysResponse>(req, "DescribeNatGateways");
        }

        /// <summary>
        /// This API is used to query NAT gateways.
        /// </summary>
        /// <param name="req"><see cref="DescribeNatGatewaysRequest"/></param>
        /// <returns><see cref="DescribeNatGatewaysResponse"/></returns>
        public DescribeNatGatewaysResponse DescribeNatGatewaysSync(DescribeNatGatewaysRequest req)
        {
            return InternalRequestAsync<DescribeNatGatewaysResponse>(req, "DescribeNatGateways")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeNetDetectStates) is used to query the list of network detection verification results.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetDetectStatesRequest"/></param>
        /// <returns><see cref="DescribeNetDetectStatesResponse"/></returns>
        public Task<DescribeNetDetectStatesResponse> DescribeNetDetectStates(DescribeNetDetectStatesRequest req)
        {
            return InternalRequestAsync<DescribeNetDetectStatesResponse>(req, "DescribeNetDetectStates");
        }

        /// <summary>
        /// This API (DescribeNetDetectStates) is used to query the list of network detection verification results.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetDetectStatesRequest"/></param>
        /// <returns><see cref="DescribeNetDetectStatesResponse"/></returns>
        public DescribeNetDetectStatesResponse DescribeNetDetectStatesSync(DescribeNetDetectStatesRequest req)
        {
            return InternalRequestAsync<DescribeNetDetectStatesResponse>(req, "DescribeNetDetectStates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeNetDetects) is used to query the list of network detection instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetDetectsRequest"/></param>
        /// <returns><see cref="DescribeNetDetectsResponse"/></returns>
        public Task<DescribeNetDetectsResponse> DescribeNetDetects(DescribeNetDetectsRequest req)
        {
            return InternalRequestAsync<DescribeNetDetectsResponse>(req, "DescribeNetDetects");
        }

        /// <summary>
        /// This API (DescribeNetDetects) is used to query the list of network detection instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetDetectsRequest"/></param>
        /// <returns><see cref="DescribeNetDetectsResponse"/></returns>
        public DescribeNetDetectsResponse DescribeNetDetectsSync(DescribeNetDetectsRequest req)
        {
            return InternalRequestAsync<DescribeNetDetectsResponse>(req, "DescribeNetDetects")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of in/outbound network ACL quintuple entries.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkAclQuintupleEntriesRequest"/></param>
        /// <returns><see cref="DescribeNetworkAclQuintupleEntriesResponse"/></returns>
        public Task<DescribeNetworkAclQuintupleEntriesResponse> DescribeNetworkAclQuintupleEntries(DescribeNetworkAclQuintupleEntriesRequest req)
        {
            return InternalRequestAsync<DescribeNetworkAclQuintupleEntriesResponse>(req, "DescribeNetworkAclQuintupleEntries");
        }

        /// <summary>
        /// This API is used to query the list of in/outbound network ACL quintuple entries.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkAclQuintupleEntriesRequest"/></param>
        /// <returns><see cref="DescribeNetworkAclQuintupleEntriesResponse"/></returns>
        public DescribeNetworkAclQuintupleEntriesResponse DescribeNetworkAclQuintupleEntriesSync(DescribeNetworkAclQuintupleEntriesRequest req)
        {
            return InternalRequestAsync<DescribeNetworkAclQuintupleEntriesResponse>(req, "DescribeNetworkAclQuintupleEntries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query a list of network ACLs.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkAclsRequest"/></param>
        /// <returns><see cref="DescribeNetworkAclsResponse"/></returns>
        public Task<DescribeNetworkAclsResponse> DescribeNetworkAcls(DescribeNetworkAclsRequest req)
        {
            return InternalRequestAsync<DescribeNetworkAclsResponse>(req, "DescribeNetworkAcls");
        }

        /// <summary>
        /// This API is used to query a list of network ACLs.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkAclsRequest"/></param>
        /// <returns><see cref="DescribeNetworkAclsResponse"/></returns>
        public DescribeNetworkAclsResponse DescribeNetworkAclsSync(DescribeNetworkAclsRequest req)
        {
            return InternalRequestAsync<DescribeNetworkAclsResponse>(req, "DescribeNetworkAcls")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeNetworkInterfaceLimit) is used to query the ENI quota based on the ID of CVM instance or ENI. It returns the ENI quota to which the CVM instance can be bound and the IP address quota that can be allocated to the ENI.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkInterfaceLimitRequest"/></param>
        /// <returns><see cref="DescribeNetworkInterfaceLimitResponse"/></returns>
        public Task<DescribeNetworkInterfaceLimitResponse> DescribeNetworkInterfaceLimit(DescribeNetworkInterfaceLimitRequest req)
        {
            return InternalRequestAsync<DescribeNetworkInterfaceLimitResponse>(req, "DescribeNetworkInterfaceLimit");
        }

        /// <summary>
        /// This API (DescribeNetworkInterfaceLimit) is used to query the ENI quota based on the ID of CVM instance or ENI. It returns the ENI quota to which the CVM instance can be bound and the IP address quota that can be allocated to the ENI.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkInterfaceLimitRequest"/></param>
        /// <returns><see cref="DescribeNetworkInterfaceLimitResponse"/></returns>
        public DescribeNetworkInterfaceLimitResponse DescribeNetworkInterfaceLimitSync(DescribeNetworkInterfaceLimitRequest req)
        {
            return InternalRequestAsync<DescribeNetworkInterfaceLimitResponse>(req, "DescribeNetworkInterfaceLimit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeNetworkInterfaces) is used to query the ENI list.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkInterfacesRequest"/></param>
        /// <returns><see cref="DescribeNetworkInterfacesResponse"/></returns>
        public Task<DescribeNetworkInterfacesResponse> DescribeNetworkInterfaces(DescribeNetworkInterfacesRequest req)
        {
            return InternalRequestAsync<DescribeNetworkInterfacesResponse>(req, "DescribeNetworkInterfaces");
        }

        /// <summary>
        /// This API (DescribeNetworkInterfaces) is used to query the ENI list.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkInterfacesRequest"/></param>
        /// <returns><see cref="DescribeNetworkInterfacesResponse"/></returns>
        public DescribeNetworkInterfacesResponse DescribeNetworkInterfacesSync(DescribeNetworkInterfacesRequest req)
        {
            return InternalRequestAsync<DescribeNetworkInterfacesResponse>(req, "DescribeNetworkInterfaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query route tables.
        /// </summary>
        /// <param name="req"><see cref="DescribeRouteTablesRequest"/></param>
        /// <returns><see cref="DescribeRouteTablesResponse"/></returns>
        public Task<DescribeRouteTablesResponse> DescribeRouteTables(DescribeRouteTablesRequest req)
        {
            return InternalRequestAsync<DescribeRouteTablesResponse>(req, "DescribeRouteTables");
        }

        /// <summary>
        /// This API is used to query route tables.
        /// </summary>
        /// <param name="req"><see cref="DescribeRouteTablesRequest"/></param>
        /// <returns><see cref="DescribeRouteTablesResponse"/></returns>
        public DescribeRouteTablesResponse DescribeRouteTablesSync(DescribeRouteTablesRequest req)
        {
            return InternalRequestAsync<DescribeRouteTablesResponse>(req, "DescribeRouteTables")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeSecurityGroupAssociationStatistics) is used to query statistics on the instances associated with a security group.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupAssociationStatisticsRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupAssociationStatisticsResponse"/></returns>
        public Task<DescribeSecurityGroupAssociationStatisticsResponse> DescribeSecurityGroupAssociationStatistics(DescribeSecurityGroupAssociationStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupAssociationStatisticsResponse>(req, "DescribeSecurityGroupAssociationStatistics");
        }

        /// <summary>
        /// This API (DescribeSecurityGroupAssociationStatistics) is used to query statistics on the instances associated with a security group.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupAssociationStatisticsRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupAssociationStatisticsResponse"/></returns>
        public DescribeSecurityGroupAssociationStatisticsResponse DescribeSecurityGroupAssociationStatisticsSync(DescribeSecurityGroupAssociationStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupAssociationStatisticsResponse>(req, "DescribeSecurityGroupAssociationStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeSecurityGroupPolicies) is used to query security group policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupPoliciesRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupPoliciesResponse"/></returns>
        public Task<DescribeSecurityGroupPoliciesResponse> DescribeSecurityGroupPolicies(DescribeSecurityGroupPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupPoliciesResponse>(req, "DescribeSecurityGroupPolicies");
        }

        /// <summary>
        /// This API (DescribeSecurityGroupPolicies) is used to query security group policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupPoliciesRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupPoliciesResponse"/></returns>
        public DescribeSecurityGroupPoliciesResponse DescribeSecurityGroupPoliciesSync(DescribeSecurityGroupPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupPoliciesResponse>(req, "DescribeSecurityGroupPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeSecurityGroupReferences) is used to query referred security groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupReferencesRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupReferencesResponse"/></returns>
        public Task<DescribeSecurityGroupReferencesResponse> DescribeSecurityGroupReferences(DescribeSecurityGroupReferencesRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupReferencesResponse>(req, "DescribeSecurityGroupReferences");
        }

        /// <summary>
        /// This API (DescribeSecurityGroupReferences) is used to query referred security groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupReferencesRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupReferencesResponse"/></returns>
        public DescribeSecurityGroupReferencesResponse DescribeSecurityGroupReferencesSync(DescribeSecurityGroupReferencesRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupReferencesResponse>(req, "DescribeSecurityGroupReferences")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeSecurityGroups) is used to query security groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupsResponse"/></returns>
        public Task<DescribeSecurityGroupsResponse> DescribeSecurityGroups(DescribeSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupsResponse>(req, "DescribeSecurityGroups");
        }

        /// <summary>
        /// This API (DescribeSecurityGroups) is used to query security groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupsResponse"/></returns>
        public DescribeSecurityGroupsResponse DescribeSecurityGroupsSync(DescribeSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupsResponse>(req, "DescribeSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeServiceTemplateGroups) is used to query a protocol port template group.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceTemplateGroupsRequest"/></param>
        /// <returns><see cref="DescribeServiceTemplateGroupsResponse"/></returns>
        public Task<DescribeServiceTemplateGroupsResponse> DescribeServiceTemplateGroups(DescribeServiceTemplateGroupsRequest req)
        {
            return InternalRequestAsync<DescribeServiceTemplateGroupsResponse>(req, "DescribeServiceTemplateGroups");
        }

        /// <summary>
        /// This API (DescribeServiceTemplateGroups) is used to query a protocol port template group.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceTemplateGroupsRequest"/></param>
        /// <returns><see cref="DescribeServiceTemplateGroupsResponse"/></returns>
        public DescribeServiceTemplateGroupsResponse DescribeServiceTemplateGroupsSync(DescribeServiceTemplateGroupsRequest req)
        {
            return InternalRequestAsync<DescribeServiceTemplateGroupsResponse>(req, "DescribeServiceTemplateGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeServiceTemplates) is used to query protocol port templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceTemplatesRequest"/></param>
        /// <returns><see cref="DescribeServiceTemplatesResponse"/></returns>
        public Task<DescribeServiceTemplatesResponse> DescribeServiceTemplates(DescribeServiceTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeServiceTemplatesResponse>(req, "DescribeServiceTemplates");
        }

        /// <summary>
        /// This API (DescribeServiceTemplates) is used to query protocol port templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceTemplatesRequest"/></param>
        /// <returns><see cref="DescribeServiceTemplatesResponse"/></returns>
        public DescribeServiceTemplatesResponse DescribeServiceTemplatesSync(DescribeServiceTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeServiceTemplatesResponse>(req, "DescribeServiceTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the snapshot file contents.
        /// </summary>
        /// <param name="req"><see cref="DescribeSgSnapshotFileContentRequest"/></param>
        /// <returns><see cref="DescribeSgSnapshotFileContentResponse"/></returns>
        public Task<DescribeSgSnapshotFileContentResponse> DescribeSgSnapshotFileContent(DescribeSgSnapshotFileContentRequest req)
        {
            return InternalRequestAsync<DescribeSgSnapshotFileContentResponse>(req, "DescribeSgSnapshotFileContent");
        }

        /// <summary>
        /// This API is used to query the snapshot file contents.
        /// </summary>
        /// <param name="req"><see cref="DescribeSgSnapshotFileContentRequest"/></param>
        /// <returns><see cref="DescribeSgSnapshotFileContentResponse"/></returns>
        public DescribeSgSnapshotFileContentResponse DescribeSgSnapshotFileContentSync(DescribeSgSnapshotFileContentRequest req)
        {
            return InternalRequestAsync<DescribeSgSnapshotFileContentResponse>(req, "DescribeSgSnapshotFileContent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query instances associated with a snapshot policy.
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotAttachedInstancesRequest"/></param>
        /// <returns><see cref="DescribeSnapshotAttachedInstancesResponse"/></returns>
        public Task<DescribeSnapshotAttachedInstancesResponse> DescribeSnapshotAttachedInstances(DescribeSnapshotAttachedInstancesRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotAttachedInstancesResponse>(req, "DescribeSnapshotAttachedInstances");
        }

        /// <summary>
        /// This API is used to query instances associated with a snapshot policy.
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotAttachedInstancesRequest"/></param>
        /// <returns><see cref="DescribeSnapshotAttachedInstancesResponse"/></returns>
        public DescribeSnapshotAttachedInstancesResponse DescribeSnapshotAttachedInstancesSync(DescribeSnapshotAttachedInstancesRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotAttachedInstancesResponse>(req, "DescribeSnapshotAttachedInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query snapshot files.
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotFilesRequest"/></param>
        /// <returns><see cref="DescribeSnapshotFilesResponse"/></returns>
        public Task<DescribeSnapshotFilesResponse> DescribeSnapshotFiles(DescribeSnapshotFilesRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotFilesResponse>(req, "DescribeSnapshotFiles");
        }

        /// <summary>
        /// This API is used to query snapshot files.
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotFilesRequest"/></param>
        /// <returns><see cref="DescribeSnapshotFilesResponse"/></returns>
        public DescribeSnapshotFilesResponse DescribeSnapshotFilesSync(DescribeSnapshotFilesRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotFilesResponse>(req, "DescribeSnapshotFiles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query snapshot policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="DescribeSnapshotPoliciesResponse"/></returns>
        public Task<DescribeSnapshotPoliciesResponse> DescribeSnapshotPolicies(DescribeSnapshotPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotPoliciesResponse>(req, "DescribeSnapshotPolicies");
        }

        /// <summary>
        /// This API is used to query snapshot policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="DescribeSnapshotPoliciesResponse"/></returns>
        public DescribeSnapshotPoliciesResponse DescribeSnapshotPoliciesSync(DescribeSnapshotPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotPoliciesResponse>(req, "DescribeSnapshotPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the subnet resource.
        /// </summary>
        /// <param name="req"><see cref="DescribeSubnetResourceDashboardRequest"/></param>
        /// <returns><see cref="DescribeSubnetResourceDashboardResponse"/></returns>
        public Task<DescribeSubnetResourceDashboardResponse> DescribeSubnetResourceDashboard(DescribeSubnetResourceDashboardRequest req)
        {
            return InternalRequestAsync<DescribeSubnetResourceDashboardResponse>(req, "DescribeSubnetResourceDashboard");
        }

        /// <summary>
        /// This API is used to query the subnet resource.
        /// </summary>
        /// <param name="req"><see cref="DescribeSubnetResourceDashboardRequest"/></param>
        /// <returns><see cref="DescribeSubnetResourceDashboardResponse"/></returns>
        public DescribeSubnetResourceDashboardResponse DescribeSubnetResourceDashboardSync(DescribeSubnetResourceDashboardRequest req)
        {
            return InternalRequestAsync<DescribeSubnetResourceDashboardResponse>(req, "DescribeSubnetResourceDashboard")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeSubnets) is used to query the list of subnets.
        /// </summary>
        /// <param name="req"><see cref="DescribeSubnetsRequest"/></param>
        /// <returns><see cref="DescribeSubnetsResponse"/></returns>
        public Task<DescribeSubnetsResponse> DescribeSubnets(DescribeSubnetsRequest req)
        {
            return InternalRequestAsync<DescribeSubnetsResponse>(req, "DescribeSubnets");
        }

        /// <summary>
        /// This API (DescribeSubnets) is used to query the list of subnets.
        /// </summary>
        /// <param name="req"><see cref="DescribeSubnetsRequest"/></param>
        /// <returns><see cref="DescribeSubnetsResponse"/></returns>
        public DescribeSubnetsResponse DescribeSubnetsSync(DescribeSubnetsRequest req)
        {
            return InternalRequestAsync<DescribeSubnetsResponse>(req, "DescribeSubnets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the EIP async job execution results.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskResultRequest"/></param>
        /// <returns><see cref="DescribeTaskResultResponse"/></returns>
        public Task<DescribeTaskResultResponse> DescribeTaskResult(DescribeTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeTaskResultResponse>(req, "DescribeTaskResult");
        }

        /// <summary>
        /// This API is used to query the EIP async job execution results.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskResultRequest"/></param>
        /// <returns><see cref="DescribeTaskResultResponse"/></returns>
        public DescribeTaskResultResponse DescribeTaskResultSync(DescribeTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeTaskResultResponse>(req, "DescribeTaskResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of shared traffic packages.
        /// </summary>
        /// <param name="req"><see cref="DescribeTrafficPackagesRequest"/></param>
        /// <returns><see cref="DescribeTrafficPackagesResponse"/></returns>
        public Task<DescribeTrafficPackagesResponse> DescribeTrafficPackages(DescribeTrafficPackagesRequest req)
        {
            return InternalRequestAsync<DescribeTrafficPackagesResponse>(req, "DescribeTrafficPackages");
        }

        /// <summary>
        /// This API is used to query the details of shared traffic packages.
        /// </summary>
        /// <param name="req"><see cref="DescribeTrafficPackagesRequest"/></param>
        /// <returns><see cref="DescribeTrafficPackagesResponse"/></returns>
        public DescribeTrafficPackagesResponse DescribeTrafficPackagesSync(DescribeTrafficPackagesRequest req)
        {
            return InternalRequestAsync<DescribeTrafficPackagesResponse>(req, "DescribeTrafficPackages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the IP usage of a subnet or VPC.
        /// If the IP is occupied, the resource type and ID associated with the are is returned. If the IP is not used, it returns null.
        /// </summary>
        /// <param name="req"><see cref="DescribeUsedIpAddressRequest"/></param>
        /// <returns><see cref="DescribeUsedIpAddressResponse"/></returns>
        public Task<DescribeUsedIpAddressResponse> DescribeUsedIpAddress(DescribeUsedIpAddressRequest req)
        {
            return InternalRequestAsync<DescribeUsedIpAddressResponse>(req, "DescribeUsedIpAddress");
        }

        /// <summary>
        /// This API is used to query the IP usage of a subnet or VPC.
        /// If the IP is occupied, the resource type and ID associated with the are is returned. If the IP is not used, it returns null.
        /// </summary>
        /// <param name="req"><see cref="DescribeUsedIpAddressRequest"/></param>
        /// <returns><see cref="DescribeUsedIpAddressResponse"/></returns>
        public DescribeUsedIpAddressResponse DescribeUsedIpAddressSync(DescribeUsedIpAddressRequest req)
        {
            return InternalRequestAsync<DescribeUsedIpAddressResponse>(req, "DescribeUsedIpAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the endpoint list.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcEndPointRequest"/></param>
        /// <returns><see cref="DescribeVpcEndPointResponse"/></returns>
        public Task<DescribeVpcEndPointResponse> DescribeVpcEndPoint(DescribeVpcEndPointRequest req)
        {
            return InternalRequestAsync<DescribeVpcEndPointResponse>(req, "DescribeVpcEndPoint");
        }

        /// <summary>
        /// This API is used to query the endpoint list.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcEndPointRequest"/></param>
        /// <returns><see cref="DescribeVpcEndPointResponse"/></returns>
        public DescribeVpcEndPointResponse DescribeVpcEndPointSync(DescribeVpcEndPointRequest req)
        {
            return InternalRequestAsync<DescribeVpcEndPointResponse>(req, "DescribeVpcEndPoint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the endpoint service list.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcEndPointServiceRequest"/></param>
        /// <returns><see cref="DescribeVpcEndPointServiceResponse"/></returns>
        public Task<DescribeVpcEndPointServiceResponse> DescribeVpcEndPointService(DescribeVpcEndPointServiceRequest req)
        {
            return InternalRequestAsync<DescribeVpcEndPointServiceResponse>(req, "DescribeVpcEndPointService");
        }

        /// <summary>
        /// This API is used to query the endpoint service list.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcEndPointServiceRequest"/></param>
        /// <returns><see cref="DescribeVpcEndPointServiceResponse"/></returns>
        public DescribeVpcEndPointServiceResponse DescribeVpcEndPointServiceSync(DescribeVpcEndPointServiceRequest req)
        {
            return InternalRequestAsync<DescribeVpcEndPointServiceResponse>(req, "DescribeVpcEndPointService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the endpoint service allowlist.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcEndPointServiceWhiteListRequest"/></param>
        /// <returns><see cref="DescribeVpcEndPointServiceWhiteListResponse"/></returns>
        public Task<DescribeVpcEndPointServiceWhiteListResponse> DescribeVpcEndPointServiceWhiteList(DescribeVpcEndPointServiceWhiteListRequest req)
        {
            return InternalRequestAsync<DescribeVpcEndPointServiceWhiteListResponse>(req, "DescribeVpcEndPointServiceWhiteList");
        }

        /// <summary>
        /// This API is used to query the endpoint service allowlist.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcEndPointServiceWhiteListRequest"/></param>
        /// <returns><see cref="DescribeVpcEndPointServiceWhiteListResponse"/></returns>
        public DescribeVpcEndPointServiceWhiteListResponse DescribeVpcEndPointServiceWhiteListSync(DescribeVpcEndPointServiceWhiteListRequest req)
        {
            return InternalRequestAsync<DescribeVpcEndPointServiceWhiteListResponse>(req, "DescribeVpcEndPointServiceWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        ///  This API (DescribeVpcInstances) is used to query a list of VCM instances on VPC.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcInstancesRequest"/></param>
        /// <returns><see cref="DescribeVpcInstancesResponse"/></returns>
        public Task<DescribeVpcInstancesResponse> DescribeVpcInstances(DescribeVpcInstancesRequest req)
        {
            return InternalRequestAsync<DescribeVpcInstancesResponse>(req, "DescribeVpcInstances");
        }

        /// <summary>
        ///  This API (DescribeVpcInstances) is used to query a list of VCM instances on VPC.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcInstancesRequest"/></param>
        /// <returns><see cref="DescribeVpcInstancesResponse"/></returns>
        public DescribeVpcInstancesResponse DescribeVpcInstancesSync(DescribeVpcInstancesRequest req)
        {
            return InternalRequestAsync<DescribeVpcInstancesResponse>(req, "DescribeVpcInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeVpcIpv6Addresses) is used to query `VPC` `IPv6` information.
        /// This API is used to query only the information of `IPv6` addresses that are already in use. When querying IPs that have not yet been used, this API will not report an error, but the IPs will not appear in the returned results.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcIpv6AddressesRequest"/></param>
        /// <returns><see cref="DescribeVpcIpv6AddressesResponse"/></returns>
        public Task<DescribeVpcIpv6AddressesResponse> DescribeVpcIpv6Addresses(DescribeVpcIpv6AddressesRequest req)
        {
            return InternalRequestAsync<DescribeVpcIpv6AddressesResponse>(req, "DescribeVpcIpv6Addresses");
        }

        /// <summary>
        /// This API (DescribeVpcIpv6Addresses) is used to query `VPC` `IPv6` information.
        /// This API is used to query only the information of `IPv6` addresses that are already in use. When querying IPs that have not yet been used, this API will not report an error, but the IPs will not appear in the returned results.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcIpv6AddressesRequest"/></param>
        /// <returns><see cref="DescribeVpcIpv6AddressesResponse"/></returns>
        public DescribeVpcIpv6AddressesResponse DescribeVpcIpv6AddressesSync(DescribeVpcIpv6AddressesRequest req)
        {
            return InternalRequestAsync<DescribeVpcIpv6AddressesResponse>(req, "DescribeVpcIpv6Addresses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeVpcPrivateIpAddresses) is used to query the private IP information of a VPC.<br />
        /// This API is used to query only the information of IP addresses that are already in use. When querying IPs that have not yet been used, this API will not report an error, but the IPs will not appear in the returned results.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcPrivateIpAddressesRequest"/></param>
        /// <returns><see cref="DescribeVpcPrivateIpAddressesResponse"/></returns>
        public Task<DescribeVpcPrivateIpAddressesResponse> DescribeVpcPrivateIpAddresses(DescribeVpcPrivateIpAddressesRequest req)
        {
            return InternalRequestAsync<DescribeVpcPrivateIpAddressesResponse>(req, "DescribeVpcPrivateIpAddresses");
        }

        /// <summary>
        /// This API (DescribeVpcPrivateIpAddresses) is used to query the private IP information of a VPC.<br />
        /// This API is used to query only the information of IP addresses that are already in use. When querying IPs that have not yet been used, this API will not report an error, but the IPs will not appear in the returned results.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcPrivateIpAddressesRequest"/></param>
        /// <returns><see cref="DescribeVpcPrivateIpAddressesResponse"/></returns>
        public DescribeVpcPrivateIpAddressesResponse DescribeVpcPrivateIpAddressesSync(DescribeVpcPrivateIpAddressesRequest req)
        {
            return InternalRequestAsync<DescribeVpcPrivateIpAddressesResponse>(req, "DescribeVpcPrivateIpAddresses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// View VPC resources.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcResourceDashboardRequest"/></param>
        /// <returns><see cref="DescribeVpcResourceDashboardResponse"/></returns>
        public Task<DescribeVpcResourceDashboardResponse> DescribeVpcResourceDashboard(DescribeVpcResourceDashboardRequest req)
        {
            return InternalRequestAsync<DescribeVpcResourceDashboardResponse>(req, "DescribeVpcResourceDashboard");
        }

        /// <summary>
        /// View VPC resources.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcResourceDashboardRequest"/></param>
        /// <returns><see cref="DescribeVpcResourceDashboardResponse"/></returns>
        public DescribeVpcResourceDashboardResponse DescribeVpcResourceDashboardSync(DescribeVpcResourceDashboardRequest req)
        {
            return InternalRequestAsync<DescribeVpcResourceDashboardResponse>(req, "DescribeVpcResourceDashboard")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the execution result of a VPC task.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcTaskResultRequest"/></param>
        /// <returns><see cref="DescribeVpcTaskResultResponse"/></returns>
        public Task<DescribeVpcTaskResultResponse> DescribeVpcTaskResult(DescribeVpcTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeVpcTaskResultResponse>(req, "DescribeVpcTaskResult");
        }

        /// <summary>
        /// This API is used to query the execution result of a VPC task.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcTaskResultRequest"/></param>
        /// <returns><see cref="DescribeVpcTaskResultResponse"/></returns>
        public DescribeVpcTaskResultResponse DescribeVpcTaskResultSync(DescribeVpcTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeVpcTaskResultResponse>(req, "DescribeVpcTaskResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeVpcs) is used to query the VPC list.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcsRequest"/></param>
        /// <returns><see cref="DescribeVpcsResponse"/></returns>
        public Task<DescribeVpcsResponse> DescribeVpcs(DescribeVpcsRequest req)
        {
            return InternalRequestAsync<DescribeVpcsResponse>(req, "DescribeVpcs");
        }

        /// <summary>
        /// This API (DescribeVpcs) is used to query the VPC list.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcsRequest"/></param>
        /// <returns><see cref="DescribeVpcsResponse"/></returns>
        public DescribeVpcsResponse DescribeVpcsSync(DescribeVpcsRequest req)
        {
            return InternalRequestAsync<DescribeVpcsResponse>(req, "DescribeVpcs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to used to query the list of VPN tunnels.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpnConnectionsRequest"/></param>
        /// <returns><see cref="DescribeVpnConnectionsResponse"/></returns>
        public Task<DescribeVpnConnectionsResponse> DescribeVpnConnections(DescribeVpnConnectionsRequest req)
        {
            return InternalRequestAsync<DescribeVpnConnectionsResponse>(req, "DescribeVpnConnections");
        }

        /// <summary>
        /// This API is used to used to query the list of VPN tunnels.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpnConnectionsRequest"/></param>
        /// <returns><see cref="DescribeVpnConnectionsResponse"/></returns>
        public DescribeVpnConnectionsResponse DescribeVpnConnectionsSync(DescribeVpnConnectionsRequest req)
        {
            return InternalRequestAsync<DescribeVpnConnectionsResponse>(req, "DescribeVpnConnections")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query VPN gateway-based CCN routes.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpnGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="DescribeVpnGatewayCcnRoutesResponse"/></returns>
        public Task<DescribeVpnGatewayCcnRoutesResponse> DescribeVpnGatewayCcnRoutes(DescribeVpnGatewayCcnRoutesRequest req)
        {
            return InternalRequestAsync<DescribeVpnGatewayCcnRoutesResponse>(req, "DescribeVpnGatewayCcnRoutes");
        }

        /// <summary>
        /// This API is used to query VPN gateway-based CCN routes.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpnGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="DescribeVpnGatewayCcnRoutesResponse"/></returns>
        public DescribeVpnGatewayCcnRoutesResponse DescribeVpnGatewayCcnRoutesSync(DescribeVpnGatewayCcnRoutesRequest req)
        {
            return InternalRequestAsync<DescribeVpnGatewayCcnRoutesResponse>(req, "DescribeVpnGatewayCcnRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query VPN gateway routes.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpnGatewayRoutesRequest"/></param>
        /// <returns><see cref="DescribeVpnGatewayRoutesResponse"/></returns>
        public Task<DescribeVpnGatewayRoutesResponse> DescribeVpnGatewayRoutes(DescribeVpnGatewayRoutesRequest req)
        {
            return InternalRequestAsync<DescribeVpnGatewayRoutesResponse>(req, "DescribeVpnGatewayRoutes");
        }

        /// <summary>
        /// This API is used to query VPN gateway routes.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpnGatewayRoutesRequest"/></param>
        /// <returns><see cref="DescribeVpnGatewayRoutesResponse"/></returns>
        public DescribeVpnGatewayRoutesResponse DescribeVpnGatewayRoutesSync(DescribeVpnGatewayRoutesRequest req)
        {
            return InternalRequestAsync<DescribeVpnGatewayRoutesResponse>(req, "DescribeVpnGatewayRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeVpnGateways) is used to query the VPN gateway list.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpnGatewaysRequest"/></param>
        /// <returns><see cref="DescribeVpnGatewaysResponse"/></returns>
        public Task<DescribeVpnGatewaysResponse> DescribeVpnGateways(DescribeVpnGatewaysRequest req)
        {
            return InternalRequestAsync<DescribeVpnGatewaysResponse>(req, "DescribeVpnGateways");
        }

        /// <summary>
        /// This API (DescribeVpnGateways) is used to query the VPN gateway list.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpnGatewaysRequest"/></param>
        /// <returns><see cref="DescribeVpnGatewaysResponse"/></returns>
        public DescribeVpnGatewaysResponse DescribeVpnGatewaysSync(DescribeVpnGatewaysRequest req)
        {
            return InternalRequestAsync<DescribeVpnGatewaysResponse>(req, "DescribeVpnGateways")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DetachCcnInstances) is used to unbind a specified network instance from a CCN instance.<br />
        /// After unbinding the network instance, the corresponding routing policy will also be deleted.
        /// </summary>
        /// <param name="req"><see cref="DetachCcnInstancesRequest"/></param>
        /// <returns><see cref="DetachCcnInstancesResponse"/></returns>
        public Task<DetachCcnInstancesResponse> DetachCcnInstances(DetachCcnInstancesRequest req)
        {
            return InternalRequestAsync<DetachCcnInstancesResponse>(req, "DetachCcnInstances");
        }

        /// <summary>
        /// This API (DetachCcnInstances) is used to unbind a specified network instance from a CCN instance.<br />
        /// After unbinding the network instance, the corresponding routing policy will also be deleted.
        /// </summary>
        /// <param name="req"><see cref="DetachCcnInstancesRequest"/></param>
        /// <returns><see cref="DetachCcnInstancesResponse"/></returns>
        public DetachCcnInstancesResponse DetachCcnInstancesSync(DetachCcnInstancesRequest req)
        {
            return InternalRequestAsync<DetachCcnInstancesResponse>(req, "DetachCcnInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a Classiclink.
        /// >?This API is async. You can call the [`DescribeVpcTaskResult`](https://intl.cloud.tencent.com/document/api/215/59037?from_cn_redirect=1) API to query the task result. When the task is completed, you can continue other tasks.
        /// >
        /// </summary>
        /// <param name="req"><see cref="DetachClassicLinkVpcRequest"/></param>
        /// <returns><see cref="DetachClassicLinkVpcResponse"/></returns>
        public Task<DetachClassicLinkVpcResponse> DetachClassicLinkVpc(DetachClassicLinkVpcRequest req)
        {
            return InternalRequestAsync<DetachClassicLinkVpcResponse>(req, "DetachClassicLinkVpc");
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
            return InternalRequestAsync<DetachClassicLinkVpcResponse>(req, "DetachClassicLinkVpc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind an ENI from a CVM.
        /// This API is completed asynchronously. If you need to query the execution result of an async task, please use the `RequestId` returned by this API to poll the `DescribeVpcTaskResult` API.
        /// </summary>
        /// <param name="req"><see cref="DetachNetworkInterfaceRequest"/></param>
        /// <returns><see cref="DetachNetworkInterfaceResponse"/></returns>
        public Task<DetachNetworkInterfaceResponse> DetachNetworkInterface(DetachNetworkInterfaceRequest req)
        {
            return InternalRequestAsync<DetachNetworkInterfaceResponse>(req, "DetachNetworkInterface");
        }

        /// <summary>
        /// This API is used to unbind an ENI from a CVM.
        /// This API is completed asynchronously. If you need to query the execution result of an async task, please use the `RequestId` returned by this API to poll the `DescribeVpcTaskResult` API.
        /// </summary>
        /// <param name="req"><see cref="DetachNetworkInterfaceRequest"/></param>
        /// <returns><see cref="DetachNetworkInterfaceResponse"/></returns>
        public DetachNetworkInterfaceResponse DetachNetworkInterfaceSync(DetachNetworkInterfaceRequest req)
        {
            return InternalRequestAsync<DetachNetworkInterfaceResponse>(req, "DetachNetworkInterface")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disassociate a snapshot policy with instances.
        /// </summary>
        /// <param name="req"><see cref="DetachSnapshotInstancesRequest"/></param>
        /// <returns><see cref="DetachSnapshotInstancesResponse"/></returns>
        public Task<DetachSnapshotInstancesResponse> DetachSnapshotInstances(DetachSnapshotInstancesRequest req)
        {
            return InternalRequestAsync<DetachSnapshotInstancesResponse>(req, "DetachSnapshotInstances");
        }

        /// <summary>
        /// This API is used to disassociate a snapshot policy with instances.
        /// </summary>
        /// <param name="req"><see cref="DetachSnapshotInstancesRequest"/></param>
        /// <returns><see cref="DetachSnapshotInstancesResponse"/></returns>
        public DetachSnapshotInstancesResponse DetachSnapshotInstancesSync(DetachSnapshotInstancesRequest req)
        {
            return InternalRequestAsync<DetachSnapshotInstancesResponse>(req, "DetachSnapshotInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DisableCcnRoutes) is used to disable CCN routes that are already enabled.
        /// </summary>
        /// <param name="req"><see cref="DisableCcnRoutesRequest"/></param>
        /// <returns><see cref="DisableCcnRoutesResponse"/></returns>
        public Task<DisableCcnRoutesResponse> DisableCcnRoutes(DisableCcnRoutesRequest req)
        {
            return InternalRequestAsync<DisableCcnRoutesResponse>(req, "DisableCcnRoutes");
        }

        /// <summary>
        /// This API (DisableCcnRoutes) is used to disable CCN routes that are already enabled.
        /// </summary>
        /// <param name="req"><see cref="DisableCcnRoutesRequest"/></param>
        /// <returns><see cref="DisableCcnRoutesResponse"/></returns>
        public DisableCcnRoutesResponse DisableCcnRoutesSync(DisableCcnRoutesRequest req)
        {
            return InternalRequestAsync<DisableCcnRoutesResponse>(req, "DisableCcnRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable flow log.
        /// </summary>
        /// <param name="req"><see cref="DisableFlowLogsRequest"/></param>
        /// <returns><see cref="DisableFlowLogsResponse"/></returns>
        public Task<DisableFlowLogsResponse> DisableFlowLogs(DisableFlowLogsRequest req)
        {
            return InternalRequestAsync<DisableFlowLogsResponse>(req, "DisableFlowLogs");
        }

        /// <summary>
        /// This API is used to disable flow log.
        /// </summary>
        /// <param name="req"><see cref="DisableFlowLogsRequest"/></param>
        /// <returns><see cref="DisableFlowLogsResponse"/></returns>
        public DisableFlowLogsResponse DisableFlowLogsSync(DisableFlowLogsRequest req)
        {
            return InternalRequestAsync<DisableFlowLogsResponse>(req, "DisableFlowLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable gateway traffic monitor.
        /// </summary>
        /// <param name="req"><see cref="DisableGatewayFlowMonitorRequest"/></param>
        /// <returns><see cref="DisableGatewayFlowMonitorResponse"/></returns>
        public Task<DisableGatewayFlowMonitorResponse> DisableGatewayFlowMonitor(DisableGatewayFlowMonitorRequest req)
        {
            return InternalRequestAsync<DisableGatewayFlowMonitorResponse>(req, "DisableGatewayFlowMonitor");
        }

        /// <summary>
        /// This API is used to disable gateway traffic monitor.
        /// </summary>
        /// <param name="req"><see cref="DisableGatewayFlowMonitorRequest"/></param>
        /// <returns><see cref="DisableGatewayFlowMonitorResponse"/></returns>
        public DisableGatewayFlowMonitorResponse DisableGatewayFlowMonitorSync(DisableGatewayFlowMonitorRequest req)
        {
            return InternalRequestAsync<DisableGatewayFlowMonitorResponse>(req, "DisableGatewayFlowMonitor")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable specified snapshot policies.
        /// </summary>
        /// <param name="req"><see cref="DisableSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="DisableSnapshotPoliciesResponse"/></returns>
        public Task<DisableSnapshotPoliciesResponse> DisableSnapshotPolicies(DisableSnapshotPoliciesRequest req)
        {
            return InternalRequestAsync<DisableSnapshotPoliciesResponse>(req, "DisableSnapshotPolicies");
        }

        /// <summary>
        /// This API is used to disable specified snapshot policies.
        /// </summary>
        /// <param name="req"><see cref="DisableSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="DisableSnapshotPoliciesResponse"/></returns>
        public DisableSnapshotPoliciesResponse DisableSnapshotPoliciesSync(DisableSnapshotPoliciesRequest req)
        {
            return InternalRequestAsync<DisableSnapshotPoliciesResponse>(req, "DisableSnapshotPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        public Task<DisassociateAddressResponse> DisassociateAddress(DisassociateAddressRequest req)
        {
            return InternalRequestAsync<DisassociateAddressResponse>(req, "DisassociateAddress");
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
            return InternalRequestAsync<DisassociateAddressResponse>(req, "DisassociateAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind a direct connect gateway from a NAT Gateway. After unbinding, the direct connect gateway cannot access internet through the NAT Gateway.
        /// </summary>
        /// <param name="req"><see cref="DisassociateDirectConnectGatewayNatGatewayRequest"/></param>
        /// <returns><see cref="DisassociateDirectConnectGatewayNatGatewayResponse"/></returns>
        public Task<DisassociateDirectConnectGatewayNatGatewayResponse> DisassociateDirectConnectGatewayNatGateway(DisassociateDirectConnectGatewayNatGatewayRequest req)
        {
            return InternalRequestAsync<DisassociateDirectConnectGatewayNatGatewayResponse>(req, "DisassociateDirectConnectGatewayNatGateway");
        }

        /// <summary>
        /// This API is used to unbind a direct connect gateway from a NAT Gateway. After unbinding, the direct connect gateway cannot access internet through the NAT Gateway.
        /// </summary>
        /// <param name="req"><see cref="DisassociateDirectConnectGatewayNatGatewayRequest"/></param>
        /// <returns><see cref="DisassociateDirectConnectGatewayNatGatewayResponse"/></returns>
        public DisassociateDirectConnectGatewayNatGatewayResponse DisassociateDirectConnectGatewayNatGatewaySync(DisassociateDirectConnectGatewayNatGatewayRequest req)
        {
            return InternalRequestAsync<DisassociateDirectConnectGatewayNatGatewayResponse>(req, "DisassociateDirectConnectGatewayNatGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind an EIP from a NAT gateway.
        /// </summary>
        /// <param name="req"><see cref="DisassociateNatGatewayAddressRequest"/></param>
        /// <returns><see cref="DisassociateNatGatewayAddressResponse"/></returns>
        public Task<DisassociateNatGatewayAddressResponse> DisassociateNatGatewayAddress(DisassociateNatGatewayAddressRequest req)
        {
            return InternalRequestAsync<DisassociateNatGatewayAddressResponse>(req, "DisassociateNatGatewayAddress");
        }

        /// <summary>
        /// This API is used to unbind an EIP from a NAT gateway.
        /// </summary>
        /// <param name="req"><see cref="DisassociateNatGatewayAddressRequest"/></param>
        /// <returns><see cref="DisassociateNatGatewayAddressResponse"/></returns>
        public DisassociateNatGatewayAddressResponse DisassociateNatGatewayAddressSync(DisassociateNatGatewayAddressRequest req)
        {
            return InternalRequestAsync<DisassociateNatGatewayAddressResponse>(req, "DisassociateNatGatewayAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disassociate a network ACL from subnets in a VPC instance.
        /// </summary>
        /// <param name="req"><see cref="DisassociateNetworkAclSubnetsRequest"/></param>
        /// <returns><see cref="DisassociateNetworkAclSubnetsResponse"/></returns>
        public Task<DisassociateNetworkAclSubnetsResponse> DisassociateNetworkAclSubnets(DisassociateNetworkAclSubnetsRequest req)
        {
            return InternalRequestAsync<DisassociateNetworkAclSubnetsResponse>(req, "DisassociateNetworkAclSubnets");
        }

        /// <summary>
        /// This API is used to disassociate a network ACL from subnets in a VPC instance.
        /// </summary>
        /// <param name="req"><see cref="DisassociateNetworkAclSubnetsRequest"/></param>
        /// <returns><see cref="DisassociateNetworkAclSubnetsResponse"/></returns>
        public DisassociateNetworkAclSubnetsResponse DisassociateNetworkAclSubnetsSync(DisassociateNetworkAclSubnetsRequest req)
        {
            return InternalRequestAsync<DisassociateNetworkAclSubnetsResponse>(req, "DisassociateNetworkAclSubnets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DisassociateNetworkInterfaceSecurityGroups) is used to detach (or fully detach if possible) a security group from an ENI.
        /// </summary>
        /// <param name="req"><see cref="DisassociateNetworkInterfaceSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateNetworkInterfaceSecurityGroupsResponse"/></returns>
        public Task<DisassociateNetworkInterfaceSecurityGroupsResponse> DisassociateNetworkInterfaceSecurityGroups(DisassociateNetworkInterfaceSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DisassociateNetworkInterfaceSecurityGroupsResponse>(req, "DisassociateNetworkInterfaceSecurityGroups");
        }

        /// <summary>
        /// This API (DisassociateNetworkInterfaceSecurityGroups) is used to detach (or fully detach if possible) a security group from an ENI.
        /// </summary>
        /// <param name="req"><see cref="DisassociateNetworkInterfaceSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateNetworkInterfaceSecurityGroupsResponse"/></returns>
        public DisassociateNetworkInterfaceSecurityGroupsResponse DisassociateNetworkInterfaceSecurityGroupsSync(DisassociateNetworkInterfaceSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DisassociateNetworkInterfaceSecurityGroupsResponse>(req, "DisassociateNetworkInterfaceSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind an endpoint from a security group.
        /// </summary>
        /// <param name="req"><see cref="DisassociateVpcEndPointSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateVpcEndPointSecurityGroupsResponse"/></returns>
        public Task<DisassociateVpcEndPointSecurityGroupsResponse> DisassociateVpcEndPointSecurityGroups(DisassociateVpcEndPointSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DisassociateVpcEndPointSecurityGroupsResponse>(req, "DisassociateVpcEndPointSecurityGroups");
        }

        /// <summary>
        /// This API is used to unbind an endpoint from a security group.
        /// </summary>
        /// <param name="req"><see cref="DisassociateVpcEndPointSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateVpcEndPointSecurityGroupsResponse"/></returns>
        public DisassociateVpcEndPointSecurityGroupsResponse DisassociateVpcEndPointSecurityGroupsSync(DisassociateVpcEndPointSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DisassociateVpcEndPointSecurityGroupsResponse>(req, "DisassociateVpcEndPointSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to download VPN tunnel configurations.
        /// </summary>
        /// <param name="req"><see cref="DownloadCustomerGatewayConfigurationRequest"/></param>
        /// <returns><see cref="DownloadCustomerGatewayConfigurationResponse"/></returns>
        public Task<DownloadCustomerGatewayConfigurationResponse> DownloadCustomerGatewayConfiguration(DownloadCustomerGatewayConfigurationRequest req)
        {
            return InternalRequestAsync<DownloadCustomerGatewayConfigurationResponse>(req, "DownloadCustomerGatewayConfiguration");
        }

        /// <summary>
        /// This API is used to download VPN tunnel configurations.
        /// </summary>
        /// <param name="req"><see cref="DownloadCustomerGatewayConfigurationRequest"/></param>
        /// <returns><see cref="DownloadCustomerGatewayConfigurationResponse"/></returns>
        public DownloadCustomerGatewayConfigurationResponse DownloadCustomerGatewayConfigurationSync(DownloadCustomerGatewayConfigurationRequest req)
        {
            return InternalRequestAsync<DownloadCustomerGatewayConfigurationResponse>(req, "DownloadCustomerGatewayConfiguration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (EnableCcnRoutes) is used to enable CCN routes that are already added.<br />
        /// This API is used to verify whether there will be conflict with an existing route after a CCN route is enabled. If there is a conflict, the route will not be enabled, and the process will fail. When a conflict occurs, you must disable the conflicting route before you can enable the desired route.
        /// </summary>
        /// <param name="req"><see cref="EnableCcnRoutesRequest"/></param>
        /// <returns><see cref="EnableCcnRoutesResponse"/></returns>
        public Task<EnableCcnRoutesResponse> EnableCcnRoutes(EnableCcnRoutesRequest req)
        {
            return InternalRequestAsync<EnableCcnRoutesResponse>(req, "EnableCcnRoutes");
        }

        /// <summary>
        /// This API (EnableCcnRoutes) is used to enable CCN routes that are already added.<br />
        /// This API is used to verify whether there will be conflict with an existing route after a CCN route is enabled. If there is a conflict, the route will not be enabled, and the process will fail. When a conflict occurs, you must disable the conflicting route before you can enable the desired route.
        /// </summary>
        /// <param name="req"><see cref="EnableCcnRoutesRequest"/></param>
        /// <returns><see cref="EnableCcnRoutesResponse"/></returns>
        public EnableCcnRoutesResponse EnableCcnRoutesSync(EnableCcnRoutesRequest req)
        {
            return InternalRequestAsync<EnableCcnRoutesResponse>(req, "EnableCcnRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable flow log.
        /// </summary>
        /// <param name="req"><see cref="EnableFlowLogsRequest"/></param>
        /// <returns><see cref="EnableFlowLogsResponse"/></returns>
        public Task<EnableFlowLogsResponse> EnableFlowLogs(EnableFlowLogsRequest req)
        {
            return InternalRequestAsync<EnableFlowLogsResponse>(req, "EnableFlowLogs");
        }

        /// <summary>
        /// This API is used to enable flow log.
        /// </summary>
        /// <param name="req"><see cref="EnableFlowLogsRequest"/></param>
        /// <returns><see cref="EnableFlowLogsResponse"/></returns>
        public EnableFlowLogsResponse EnableFlowLogsSync(EnableFlowLogsRequest req)
        {
            return InternalRequestAsync<EnableFlowLogsResponse>(req, "EnableFlowLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable gateway traffic monitor.
        /// </summary>
        /// <param name="req"><see cref="EnableGatewayFlowMonitorRequest"/></param>
        /// <returns><see cref="EnableGatewayFlowMonitorResponse"/></returns>
        public Task<EnableGatewayFlowMonitorResponse> EnableGatewayFlowMonitor(EnableGatewayFlowMonitorRequest req)
        {
            return InternalRequestAsync<EnableGatewayFlowMonitorResponse>(req, "EnableGatewayFlowMonitor");
        }

        /// <summary>
        /// This API is used to enable gateway traffic monitor.
        /// </summary>
        /// <param name="req"><see cref="EnableGatewayFlowMonitorRequest"/></param>
        /// <returns><see cref="EnableGatewayFlowMonitorResponse"/></returns>
        public EnableGatewayFlowMonitorResponse EnableGatewayFlowMonitorSync(EnableGatewayFlowMonitorRequest req)
        {
            return InternalRequestAsync<EnableGatewayFlowMonitorResponse>(req, "EnableGatewayFlowMonitor")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable specified snapshot policies. 
        /// </summary>
        /// <param name="req"><see cref="EnableSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="EnableSnapshotPoliciesResponse"/></returns>
        public Task<EnableSnapshotPoliciesResponse> EnableSnapshotPolicies(EnableSnapshotPoliciesRequest req)
        {
            return InternalRequestAsync<EnableSnapshotPoliciesResponse>(req, "EnableSnapshotPolicies");
        }

        /// <summary>
        /// This API is used to enable specified snapshot policies. 
        /// </summary>
        /// <param name="req"><see cref="EnableSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="EnableSnapshotPoliciesResponse"/></returns>
        public EnableSnapshotPoliciesResponse EnableSnapshotPoliciesSync(EnableSnapshotPoliciesRequest req)
        {
            return InternalRequestAsync<EnableSnapshotPoliciesResponse>(req, "EnableSnapshotPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to determine whether to accept the request of connecting with an endpoint.
        /// </summary>
        /// <param name="req"><see cref="EnableVpcEndPointConnectRequest"/></param>
        /// <returns><see cref="EnableVpcEndPointConnectResponse"/></returns>
        public Task<EnableVpcEndPointConnectResponse> EnableVpcEndPointConnect(EnableVpcEndPointConnectRequest req)
        {
            return InternalRequestAsync<EnableVpcEndPointConnectResponse>(req, "EnableVpcEndPointConnect");
        }

        /// <summary>
        /// This API is used to determine whether to accept the request of connecting with an endpoint.
        /// </summary>
        /// <param name="req"><see cref="EnableVpcEndPointConnectRequest"/></param>
        /// <returns><see cref="EnableVpcEndPointConnectResponse"/></returns>
        public EnableVpcEndPointConnectResponse EnableVpcEndPointConnectSync(EnableVpcEndPointConnectRequest req)
        {
            return InternalRequestAsync<EnableVpcEndPointConnectResponse>(req, "EnableVpcEndPointConnect")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get a pair of VPN tunnel health check addresses. 
        /// </summary>
        /// <param name="req"><see cref="GenerateVpnConnectionDefaultHealthCheckIpRequest"/></param>
        /// <returns><see cref="GenerateVpnConnectionDefaultHealthCheckIpResponse"/></returns>
        public Task<GenerateVpnConnectionDefaultHealthCheckIpResponse> GenerateVpnConnectionDefaultHealthCheckIp(GenerateVpnConnectionDefaultHealthCheckIpRequest req)
        {
            return InternalRequestAsync<GenerateVpnConnectionDefaultHealthCheckIpResponse>(req, "GenerateVpnConnectionDefaultHealthCheckIp");
        }

        /// <summary>
        /// This API is used to get a pair of VPN tunnel health check addresses. 
        /// </summary>
        /// <param name="req"><see cref="GenerateVpnConnectionDefaultHealthCheckIpRequest"/></param>
        /// <returns><see cref="GenerateVpnConnectionDefaultHealthCheckIpResponse"/></returns>
        public GenerateVpnConnectionDefaultHealthCheckIpResponse GenerateVpnConnectionDefaultHealthCheckIpSync(GenerateVpnConnectionDefaultHealthCheckIpRequest req)
        {
            return InternalRequestAsync<GenerateVpnConnectionDefaultHealthCheckIpResponse>(req, "GenerateVpnConnectionDefaultHealthCheckIp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the bandwidth limits of a CCN instance. Monthly-subscribed CCNs only support Inter-region Bandwidth Limits, while the pay-as-you-go CCNs support both the Inter-region Bandwidth Limits and Region Outbound Bandwidth Limits. 
        /// </summary>
        /// <param name="req"><see cref="GetCcnRegionBandwidthLimitsRequest"/></param>
        /// <returns><see cref="GetCcnRegionBandwidthLimitsResponse"/></returns>
        public Task<GetCcnRegionBandwidthLimitsResponse> GetCcnRegionBandwidthLimits(GetCcnRegionBandwidthLimitsRequest req)
        {
            return InternalRequestAsync<GetCcnRegionBandwidthLimitsResponse>(req, "GetCcnRegionBandwidthLimits");
        }

        /// <summary>
        /// This API is used to query the bandwidth limits of a CCN instance. Monthly-subscribed CCNs only support Inter-region Bandwidth Limits, while the pay-as-you-go CCNs support both the Inter-region Bandwidth Limits and Region Outbound Bandwidth Limits. 
        /// </summary>
        /// <param name="req"><see cref="GetCcnRegionBandwidthLimitsRequest"/></param>
        /// <returns><see cref="GetCcnRegionBandwidthLimitsResponse"/></returns>
        public GetCcnRegionBandwidthLimitsResponse GetCcnRegionBandwidthLimitsSync(GetCcnRegionBandwidthLimitsRequest req)
        {
            return InternalRequestAsync<GetCcnRegionBandwidthLimitsResponse>(req, "GetCcnRegionBandwidthLimits")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bind an EIP to an HAVIP. <br />
        /// This API is completed asynchronously. If you need to query the execution result of an async task, please use the `RequestId` returned by this API to poll the `DescribeVpcTaskResult` API.
        /// </summary>
        /// <param name="req"><see cref="HaVipAssociateAddressIpRequest"/></param>
        /// <returns><see cref="HaVipAssociateAddressIpResponse"/></returns>
        public Task<HaVipAssociateAddressIpResponse> HaVipAssociateAddressIp(HaVipAssociateAddressIpRequest req)
        {
            return InternalRequestAsync<HaVipAssociateAddressIpResponse>(req, "HaVipAssociateAddressIp");
        }

        /// <summary>
        /// This API is used to bind an EIP to an HAVIP. <br />
        /// This API is completed asynchronously. If you need to query the execution result of an async task, please use the `RequestId` returned by this API to poll the `DescribeVpcTaskResult` API.
        /// </summary>
        /// <param name="req"><see cref="HaVipAssociateAddressIpRequest"/></param>
        /// <returns><see cref="HaVipAssociateAddressIpResponse"/></returns>
        public HaVipAssociateAddressIpResponse HaVipAssociateAddressIpSync(HaVipAssociateAddressIpRequest req)
        {
            return InternalRequestAsync<HaVipAssociateAddressIpResponse>(req, "HaVipAssociateAddressIp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind an EIP from an HAVIP. <br />
        /// This API is completed asynchronously. If you need to query the execution result of an async task, please use the `RequestId` returned by this API to poll the `DescribeVpcTaskResult` API.
        /// </summary>
        /// <param name="req"><see cref="HaVipDisassociateAddressIpRequest"/></param>
        /// <returns><see cref="HaVipDisassociateAddressIpResponse"/></returns>
        public Task<HaVipDisassociateAddressIpResponse> HaVipDisassociateAddressIp(HaVipDisassociateAddressIpRequest req)
        {
            return InternalRequestAsync<HaVipDisassociateAddressIpResponse>(req, "HaVipDisassociateAddressIp");
        }

        /// <summary>
        /// This API is used to unbind an EIP from an HAVIP. <br />
        /// This API is completed asynchronously. If you need to query the execution result of an async task, please use the `RequestId` returned by this API to poll the `DescribeVpcTaskResult` API.
        /// </summary>
        /// <param name="req"><see cref="HaVipDisassociateAddressIpRequest"/></param>
        /// <returns><see cref="HaVipDisassociateAddressIpResponse"/></returns>
        public HaVipDisassociateAddressIpResponse HaVipDisassociateAddressIpSync(HaVipDisassociateAddressIpRequest req)
        {
            return InternalRequestAsync<HaVipDisassociateAddressIpResponse>(req, "HaVipDisassociateAddressIp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the price of creating a direct connect gateway.
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateDirectConnectGatewayRequest"/></param>
        /// <returns><see cref="InquirePriceCreateDirectConnectGatewayResponse"/></returns>
        public Task<InquirePriceCreateDirectConnectGatewayResponse> InquirePriceCreateDirectConnectGateway(InquirePriceCreateDirectConnectGatewayRequest req)
        {
            return InternalRequestAsync<InquirePriceCreateDirectConnectGatewayResponse>(req, "InquirePriceCreateDirectConnectGateway");
        }

        /// <summary>
        /// This API is used to query the price of creating a direct connect gateway.
        /// </summary>
        /// <param name="req"><see cref="InquirePriceCreateDirectConnectGatewayRequest"/></param>
        /// <returns><see cref="InquirePriceCreateDirectConnectGatewayResponse"/></returns>
        public InquirePriceCreateDirectConnectGatewayResponse InquirePriceCreateDirectConnectGatewaySync(InquirePriceCreateDirectConnectGatewayRequest req)
        {
            return InternalRequestAsync<InquirePriceCreateDirectConnectGatewayResponse>(req, "InquirePriceCreateDirectConnectGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (InquiryPriceRenewVpnGateway) is used to query the price for VPN gateway renewal. Currently, only querying prices for IPSEC-type gateways is supported.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRenewVpnGatewayRequest"/></param>
        /// <returns><see cref="InquiryPriceRenewVpnGatewayResponse"/></returns>
        public Task<InquiryPriceRenewVpnGatewayResponse> InquiryPriceRenewVpnGateway(InquiryPriceRenewVpnGatewayRequest req)
        {
            return InternalRequestAsync<InquiryPriceRenewVpnGatewayResponse>(req, "InquiryPriceRenewVpnGateway");
        }

        /// <summary>
        /// This API (InquiryPriceRenewVpnGateway) is used to query the price for VPN gateway renewal. Currently, only querying prices for IPSEC-type gateways is supported.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRenewVpnGatewayRequest"/></param>
        /// <returns><see cref="InquiryPriceRenewVpnGatewayResponse"/></returns>
        public InquiryPriceRenewVpnGatewayResponse InquiryPriceRenewVpnGatewaySync(InquiryPriceRenewVpnGatewayRequest req)
        {
            return InternalRequestAsync<InquiryPriceRenewVpnGatewayResponse>(req, "InquiryPriceRenewVpnGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (InquiryPriceResetVpnGatewayInternetMaxBandwidth) is used to query the price for adjusting the bandwidth cap of a VPN gateway.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceResetVpnGatewayInternetMaxBandwidthRequest"/></param>
        /// <returns><see cref="InquiryPriceResetVpnGatewayInternetMaxBandwidthResponse"/></returns>
        public Task<InquiryPriceResetVpnGatewayInternetMaxBandwidthResponse> InquiryPriceResetVpnGatewayInternetMaxBandwidth(InquiryPriceResetVpnGatewayInternetMaxBandwidthRequest req)
        {
            return InternalRequestAsync<InquiryPriceResetVpnGatewayInternetMaxBandwidthResponse>(req, "InquiryPriceResetVpnGatewayInternetMaxBandwidth");
        }

        /// <summary>
        /// This API (InquiryPriceResetVpnGatewayInternetMaxBandwidth) is used to query the price for adjusting the bandwidth cap of a VPN gateway.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceResetVpnGatewayInternetMaxBandwidthRequest"/></param>
        /// <returns><see cref="InquiryPriceResetVpnGatewayInternetMaxBandwidthResponse"/></returns>
        public InquiryPriceResetVpnGatewayInternetMaxBandwidthResponse InquiryPriceResetVpnGatewayInternetMaxBandwidthSync(InquiryPriceResetVpnGatewayInternetMaxBandwidthRequest req)
        {
            return InternalRequestAsync<InquiryPriceResetVpnGatewayInternetMaxBandwidthResponse>(req, "InquiryPriceResetVpnGatewayInternetMaxBandwidth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to migrate ENIs.
        /// This API is completed asynchronously. If you need to query the execution result of an async task, please use the `RequestId` returned by this API to poll the `DescribeVpcTaskResult` API.
        /// </summary>
        /// <param name="req"><see cref="MigrateNetworkInterfaceRequest"/></param>
        /// <returns><see cref="MigrateNetworkInterfaceResponse"/></returns>
        public Task<MigrateNetworkInterfaceResponse> MigrateNetworkInterface(MigrateNetworkInterfaceRequest req)
        {
            return InternalRequestAsync<MigrateNetworkInterfaceResponse>(req, "MigrateNetworkInterface");
        }

        /// <summary>
        /// This API is used to migrate ENIs.
        /// This API is completed asynchronously. If you need to query the execution result of an async task, please use the `RequestId` returned by this API to poll the `DescribeVpcTaskResult` API.
        /// </summary>
        /// <param name="req"><see cref="MigrateNetworkInterfaceRequest"/></param>
        /// <returns><see cref="MigrateNetworkInterfaceResponse"/></returns>
        public MigrateNetworkInterfaceResponse MigrateNetworkInterfaceSync(MigrateNetworkInterfaceRequest req)
        {
            return InternalRequestAsync<MigrateNetworkInterfaceResponse>(req, "MigrateNetworkInterface")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to migrate the private IPs between ENIs. 
        /// * Note that primary IPs cannot be migrated. 
        /// * The source and destination ENI must be within the same subnet.  
        /// 
        /// This API is completed asynchronously. If you need to query the execution result of an async task, please use the `RequestId` returned by this API to poll the `DescribeVpcTaskResult` API.
        /// </summary>
        /// <param name="req"><see cref="MigratePrivateIpAddressRequest"/></param>
        /// <returns><see cref="MigratePrivateIpAddressResponse"/></returns>
        public Task<MigratePrivateIpAddressResponse> MigratePrivateIpAddress(MigratePrivateIpAddressRequest req)
        {
            return InternalRequestAsync<MigratePrivateIpAddressResponse>(req, "MigratePrivateIpAddress");
        }

        /// <summary>
        /// This API is used to migrate the private IPs between ENIs. 
        /// * Note that primary IPs cannot be migrated. 
        /// * The source and destination ENI must be within the same subnet.  
        /// 
        /// This API is completed asynchronously. If you need to query the execution result of an async task, please use the `RequestId` returned by this API to poll the `DescribeVpcTaskResult` API.
        /// </summary>
        /// <param name="req"><see cref="MigratePrivateIpAddressRequest"/></param>
        /// <returns><see cref="MigratePrivateIpAddressResponse"/></returns>
        public MigratePrivateIpAddressResponse MigratePrivateIpAddressSync(MigratePrivateIpAddressRequest req)
        {
            return InternalRequestAsync<MigratePrivateIpAddressResponse>(req, "MigratePrivateIpAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyAddressAttribute) is used to modify the name of an [Elastic IP](https://intl.cloud.tencent.com/document/product/213/1941?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressAttributeRequest"/></param>
        /// <returns><see cref="ModifyAddressAttributeResponse"/></returns>
        public Task<ModifyAddressAttributeResponse> ModifyAddressAttribute(ModifyAddressAttributeRequest req)
        {
            return InternalRequestAsync<ModifyAddressAttributeResponse>(req, "ModifyAddressAttribute");
        }

        /// <summary>
        /// This API (ModifyAddressAttribute) is used to modify the name of an [Elastic IP](https://intl.cloud.tencent.com/document/product/213/1941?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressAttributeRequest"/></param>
        /// <returns><see cref="ModifyAddressAttributeResponse"/></returns>
        public ModifyAddressAttributeResponse ModifyAddressAttributeSync(ModifyAddressAttributeRequest req)
        {
            return InternalRequestAsync<ModifyAddressAttributeResponse>(req, "ModifyAddressAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to adjust the network billing mode of an EIP. Please note that it's available to users whose network fees are billed on IPs but not CVMs.
        /// * The network billing mode can be switched between `BANDWIDTH_PREPAID_BY_MONTH` and `TRAFFIC_POSTPAID_BY_HOUR`.
        /// * The network billing mode for each EIP be changed for up to twice.
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressInternetChargeTypeRequest"/></param>
        /// <returns><see cref="ModifyAddressInternetChargeTypeResponse"/></returns>
        public Task<ModifyAddressInternetChargeTypeResponse> ModifyAddressInternetChargeType(ModifyAddressInternetChargeTypeRequest req)
        {
            return InternalRequestAsync<ModifyAddressInternetChargeTypeResponse>(req, "ModifyAddressInternetChargeType");
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
            return InternalRequestAsync<ModifyAddressInternetChargeTypeResponse>(req, "ModifyAddressInternetChargeType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyAddressTemplateAttribute) is used to modify an IP address template.
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressTemplateAttributeRequest"/></param>
        /// <returns><see cref="ModifyAddressTemplateAttributeResponse"/></returns>
        public Task<ModifyAddressTemplateAttributeResponse> ModifyAddressTemplateAttribute(ModifyAddressTemplateAttributeRequest req)
        {
            return InternalRequestAsync<ModifyAddressTemplateAttributeResponse>(req, "ModifyAddressTemplateAttribute");
        }

        /// <summary>
        /// This API (ModifyAddressTemplateAttribute) is used to modify an IP address template.
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressTemplateAttributeRequest"/></param>
        /// <returns><see cref="ModifyAddressTemplateAttributeResponse"/></returns>
        public ModifyAddressTemplateAttributeResponse ModifyAddressTemplateAttributeSync(ModifyAddressTemplateAttributeRequest req)
        {
            return InternalRequestAsync<ModifyAddressTemplateAttributeResponse>(req, "ModifyAddressTemplateAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyAddressTemplateGroupAttribute) is used to modify an IP address template group.
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressTemplateGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyAddressTemplateGroupAttributeResponse"/></returns>
        public Task<ModifyAddressTemplateGroupAttributeResponse> ModifyAddressTemplateGroupAttribute(ModifyAddressTemplateGroupAttributeRequest req)
        {
            return InternalRequestAsync<ModifyAddressTemplateGroupAttributeResponse>(req, "ModifyAddressTemplateGroupAttribute");
        }

        /// <summary>
        /// This API (ModifyAddressTemplateGroupAttribute) is used to modify an IP address template group.
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressTemplateGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyAddressTemplateGroupAttributeResponse"/></returns>
        public ModifyAddressTemplateGroupAttributeResponse ModifyAddressTemplateGroupAttributeSync(ModifyAddressTemplateGroupAttributeRequest req)
        {
            return InternalRequestAsync<ModifyAddressTemplateGroupAttributeResponse>(req, "ModifyAddressTemplateGroupAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to adjust the bandwidth of [Elastic IP](https://intl.cloud.tencent.com/document/product/213/1941?from_cn_redirect=1), including EIP billed on a pay-as-you-go, monthly subscription, and bandwidth package basis.
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressesBandwidthRequest"/></param>
        /// <returns><see cref="ModifyAddressesBandwidthResponse"/></returns>
        public Task<ModifyAddressesBandwidthResponse> ModifyAddressesBandwidth(ModifyAddressesBandwidthRequest req)
        {
            return InternalRequestAsync<ModifyAddressesBandwidthResponse>(req, "ModifyAddressesBandwidth");
        }

        /// <summary>
        /// This API is used to adjust the bandwidth of [Elastic IP](https://intl.cloud.tencent.com/document/product/213/1941?from_cn_redirect=1), including EIP billed on a pay-as-you-go, monthly subscription, and bandwidth package basis.
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressesBandwidthRequest"/></param>
        /// <returns><see cref="ModifyAddressesBandwidthResponse"/></returns>
        public ModifyAddressesBandwidthResponse ModifyAddressesBandwidthSync(ModifyAddressesBandwidthRequest req)
        {
            return InternalRequestAsync<ModifyAddressesBandwidthResponse>(req, "ModifyAddressesBandwidth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch modify (add or delete) secondary CIDR blocks.
        /// </summary>
        /// <param name="req"><see cref="ModifyAssistantCidrRequest"/></param>
        /// <returns><see cref="ModifyAssistantCidrResponse"/></returns>
        public Task<ModifyAssistantCidrResponse> ModifyAssistantCidr(ModifyAssistantCidrRequest req)
        {
            return InternalRequestAsync<ModifyAssistantCidrResponse>(req, "ModifyAssistantCidr");
        }

        /// <summary>
        /// This API is used to batch modify (add or delete) secondary CIDR blocks.
        /// </summary>
        /// <param name="req"><see cref="ModifyAssistantCidrRequest"/></param>
        /// <returns><see cref="ModifyAssistantCidrResponse"/></returns>
        public ModifyAssistantCidrResponse ModifyAssistantCidrSync(ModifyAssistantCidrRequest req)
        {
            return InternalRequestAsync<ModifyAssistantCidrResponse>(req, "ModifyAssistantCidr")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the attributes of a bandwidth package, including the bandwidth package name, and so on.
        /// </summary>
        /// <param name="req"><see cref="ModifyBandwidthPackageAttributeRequest"/></param>
        /// <returns><see cref="ModifyBandwidthPackageAttributeResponse"/></returns>
        public Task<ModifyBandwidthPackageAttributeResponse> ModifyBandwidthPackageAttribute(ModifyBandwidthPackageAttributeRequest req)
        {
            return InternalRequestAsync<ModifyBandwidthPackageAttributeResponse>(req, "ModifyBandwidthPackageAttribute");
        }

        /// <summary>
        /// This API is used to modify the attributes of a bandwidth package, including the bandwidth package name, and so on.
        /// </summary>
        /// <param name="req"><see cref="ModifyBandwidthPackageAttributeRequest"/></param>
        /// <returns><see cref="ModifyBandwidthPackageAttributeResponse"/></returns>
        public ModifyBandwidthPackageAttributeResponse ModifyBandwidthPackageAttributeSync(ModifyBandwidthPackageAttributeRequest req)
        {
            return InternalRequestAsync<ModifyBandwidthPackageAttributeResponse>(req, "ModifyBandwidthPackageAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify CCN-associated instance attributes. Currently, only the `description` can be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyCcnAttachedInstancesAttributeRequest"/></param>
        /// <returns><see cref="ModifyCcnAttachedInstancesAttributeResponse"/></returns>
        public Task<ModifyCcnAttachedInstancesAttributeResponse> ModifyCcnAttachedInstancesAttribute(ModifyCcnAttachedInstancesAttributeRequest req)
        {
            return InternalRequestAsync<ModifyCcnAttachedInstancesAttributeResponse>(req, "ModifyCcnAttachedInstancesAttribute");
        }

        /// <summary>
        /// This API is used to modify CCN-associated instance attributes. Currently, only the `description` can be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyCcnAttachedInstancesAttributeRequest"/></param>
        /// <returns><see cref="ModifyCcnAttachedInstancesAttributeResponse"/></returns>
        public ModifyCcnAttachedInstancesAttributeResponse ModifyCcnAttachedInstancesAttributeSync(ModifyCcnAttachedInstancesAttributeRequest req)
        {
            return InternalRequestAsync<ModifyCcnAttachedInstancesAttributeResponse>(req, "ModifyCcnAttachedInstancesAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyCcnAttribute) is used to modify CCN attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyCcnAttributeRequest"/></param>
        /// <returns><see cref="ModifyCcnAttributeResponse"/></returns>
        public Task<ModifyCcnAttributeResponse> ModifyCcnAttribute(ModifyCcnAttributeRequest req)
        {
            return InternalRequestAsync<ModifyCcnAttributeResponse>(req, "ModifyCcnAttribute");
        }

        /// <summary>
        /// This API (ModifyCcnAttribute) is used to modify CCN attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyCcnAttributeRequest"/></param>
        /// <returns><see cref="ModifyCcnAttributeResponse"/></returns>
        public ModifyCcnAttributeResponse ModifyCcnAttributeSync(ModifyCcnAttributeRequest req)
        {
            return InternalRequestAsync<ModifyCcnAttributeResponse>(req, "ModifyCcnAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the bandwidth limit policy of a postpaid CCN instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyCcnRegionBandwidthLimitsTypeRequest"/></param>
        /// <returns><see cref="ModifyCcnRegionBandwidthLimitsTypeResponse"/></returns>
        public Task<ModifyCcnRegionBandwidthLimitsTypeResponse> ModifyCcnRegionBandwidthLimitsType(ModifyCcnRegionBandwidthLimitsTypeRequest req)
        {
            return InternalRequestAsync<ModifyCcnRegionBandwidthLimitsTypeResponse>(req, "ModifyCcnRegionBandwidthLimitsType");
        }

        /// <summary>
        /// This API is used to modify the bandwidth limit policy of a postpaid CCN instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyCcnRegionBandwidthLimitsTypeRequest"/></param>
        /// <returns><see cref="ModifyCcnRegionBandwidthLimitsTypeResponse"/></returns>
        public ModifyCcnRegionBandwidthLimitsTypeResponse ModifyCcnRegionBandwidthLimitsTypeSync(ModifyCcnRegionBandwidthLimitsTypeRequest req)
        {
            return InternalRequestAsync<ModifyCcnRegionBandwidthLimitsTypeResponse>(req, "ModifyCcnRegionBandwidthLimitsType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyCustomerGatewayAttribute) is used to modify the customer gateway information.
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomerGatewayAttributeRequest"/></param>
        /// <returns><see cref="ModifyCustomerGatewayAttributeResponse"/></returns>
        public Task<ModifyCustomerGatewayAttributeResponse> ModifyCustomerGatewayAttribute(ModifyCustomerGatewayAttributeRequest req)
        {
            return InternalRequestAsync<ModifyCustomerGatewayAttributeResponse>(req, "ModifyCustomerGatewayAttribute");
        }

        /// <summary>
        /// This API (ModifyCustomerGatewayAttribute) is used to modify the customer gateway information.
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomerGatewayAttributeRequest"/></param>
        /// <returns><see cref="ModifyCustomerGatewayAttributeResponse"/></returns>
        public ModifyCustomerGatewayAttributeResponse ModifyCustomerGatewayAttributeSync(ModifyCustomerGatewayAttributeRequest req)
        {
            return InternalRequestAsync<ModifyCustomerGatewayAttributeResponse>(req, "ModifyCustomerGatewayAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the attributes of a direct connect gateway.
        /// </summary>
        /// <param name="req"><see cref="ModifyDirectConnectGatewayAttributeRequest"/></param>
        /// <returns><see cref="ModifyDirectConnectGatewayAttributeResponse"/></returns>
        public Task<ModifyDirectConnectGatewayAttributeResponse> ModifyDirectConnectGatewayAttribute(ModifyDirectConnectGatewayAttributeRequest req)
        {
            return InternalRequestAsync<ModifyDirectConnectGatewayAttributeResponse>(req, "ModifyDirectConnectGatewayAttribute");
        }

        /// <summary>
        /// This API is used to modify the attributes of a direct connect gateway.
        /// </summary>
        /// <param name="req"><see cref="ModifyDirectConnectGatewayAttributeRequest"/></param>
        /// <returns><see cref="ModifyDirectConnectGatewayAttributeResponse"/></returns>
        public ModifyDirectConnectGatewayAttributeResponse ModifyDirectConnectGatewayAttributeSync(ModifyDirectConnectGatewayAttributeRequest req)
        {
            return InternalRequestAsync<ModifyDirectConnectGatewayAttributeResponse>(req, "ModifyDirectConnectGatewayAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the attributes of a flow log.
        /// </summary>
        /// <param name="req"><see cref="ModifyFlowLogAttributeRequest"/></param>
        /// <returns><see cref="ModifyFlowLogAttributeResponse"/></returns>
        public Task<ModifyFlowLogAttributeResponse> ModifyFlowLogAttribute(ModifyFlowLogAttributeRequest req)
        {
            return InternalRequestAsync<ModifyFlowLogAttributeResponse>(req, "ModifyFlowLogAttribute");
        }

        /// <summary>
        /// This API is used to modify the attributes of a flow log.
        /// </summary>
        /// <param name="req"><see cref="ModifyFlowLogAttributeRequest"/></param>
        /// <returns><see cref="ModifyFlowLogAttributeResponse"/></returns>
        public ModifyFlowLogAttributeResponse ModifyFlowLogAttributeSync(ModifyFlowLogAttributeRequest req)
        {
            return InternalRequestAsync<ModifyFlowLogAttributeResponse>(req, "ModifyFlowLogAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to adjust the bandwidth limit of a gateway.
        /// </summary>
        /// <param name="req"><see cref="ModifyGatewayFlowQosRequest"/></param>
        /// <returns><see cref="ModifyGatewayFlowQosResponse"/></returns>
        public Task<ModifyGatewayFlowQosResponse> ModifyGatewayFlowQos(ModifyGatewayFlowQosRequest req)
        {
            return InternalRequestAsync<ModifyGatewayFlowQosResponse>(req, "ModifyGatewayFlowQos");
        }

        /// <summary>
        /// This API is used to adjust the bandwidth limit of a gateway.
        /// </summary>
        /// <param name="req"><see cref="ModifyGatewayFlowQosRequest"/></param>
        /// <returns><see cref="ModifyGatewayFlowQosResponse"/></returns>
        public ModifyGatewayFlowQosResponse ModifyGatewayFlowQosSync(ModifyGatewayFlowQosRequest req)
        {
            return InternalRequestAsync<ModifyGatewayFlowQosResponse>(req, "ModifyGatewayFlowQos")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyHaVipAttribute) is used to modify HAVIP attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyHaVipAttributeRequest"/></param>
        /// <returns><see cref="ModifyHaVipAttributeResponse"/></returns>
        public Task<ModifyHaVipAttributeResponse> ModifyHaVipAttribute(ModifyHaVipAttributeRequest req)
        {
            return InternalRequestAsync<ModifyHaVipAttributeResponse>(req, "ModifyHaVipAttribute");
        }

        /// <summary>
        /// This API (ModifyHaVipAttribute) is used to modify HAVIP attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyHaVipAttributeRequest"/></param>
        /// <returns><see cref="ModifyHaVipAttributeResponse"/></returns>
        public ModifyHaVipAttributeResponse ModifyHaVipAttributeSync(ModifyHaVipAttributeRequest req)
        {
            return InternalRequestAsync<ModifyHaVipAttributeResponse>(req, "ModifyHaVipAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyIpv6AddressesAttribute) is used to modify the private IPv6 address attributes of an ENI.
        /// </summary>
        /// <param name="req"><see cref="ModifyIpv6AddressesAttributeRequest"/></param>
        /// <returns><see cref="ModifyIpv6AddressesAttributeResponse"/></returns>
        public Task<ModifyIpv6AddressesAttributeResponse> ModifyIpv6AddressesAttribute(ModifyIpv6AddressesAttributeRequest req)
        {
            return InternalRequestAsync<ModifyIpv6AddressesAttributeResponse>(req, "ModifyIpv6AddressesAttribute");
        }

        /// <summary>
        /// This API (ModifyIpv6AddressesAttribute) is used to modify the private IPv6 address attributes of an ENI.
        /// </summary>
        /// <param name="req"><see cref="ModifyIpv6AddressesAttributeRequest"/></param>
        /// <returns><see cref="ModifyIpv6AddressesAttributeResponse"/></returns>
        public ModifyIpv6AddressesAttributeResponse ModifyIpv6AddressesAttributeSync(ModifyIpv6AddressesAttributeRequest req)
        {
            return InternalRequestAsync<ModifyIpv6AddressesAttributeResponse>(req, "ModifyIpv6AddressesAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the local gateway of a CDC instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyLocalGatewayRequest"/></param>
        /// <returns><see cref="ModifyLocalGatewayResponse"/></returns>
        public Task<ModifyLocalGatewayResponse> ModifyLocalGateway(ModifyLocalGatewayRequest req)
        {
            return InternalRequestAsync<ModifyLocalGatewayResponse>(req, "ModifyLocalGateway");
        }

        /// <summary>
        /// This API is used to modify the local gateway of a CDC instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyLocalGatewayRequest"/></param>
        /// <returns><see cref="ModifyLocalGatewayResponse"/></returns>
        public ModifyLocalGatewayResponse ModifyLocalGatewaySync(ModifyLocalGatewayRequest req)
        {
            return InternalRequestAsync<ModifyLocalGatewayResponse>(req, "ModifyLocalGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the attributes of a NAT gateway.
        /// </summary>
        /// <param name="req"><see cref="ModifyNatGatewayAttributeRequest"/></param>
        /// <returns><see cref="ModifyNatGatewayAttributeResponse"/></returns>
        public Task<ModifyNatGatewayAttributeResponse> ModifyNatGatewayAttribute(ModifyNatGatewayAttributeRequest req)
        {
            return InternalRequestAsync<ModifyNatGatewayAttributeResponse>(req, "ModifyNatGatewayAttribute");
        }

        /// <summary>
        /// This API is used to modify the attributes of a NAT gateway.
        /// </summary>
        /// <param name="req"><see cref="ModifyNatGatewayAttributeRequest"/></param>
        /// <returns><see cref="ModifyNatGatewayAttributeResponse"/></returns>
        public ModifyNatGatewayAttributeResponse ModifyNatGatewayAttributeSync(ModifyNatGatewayAttributeRequest req)
        {
            return InternalRequestAsync<ModifyNatGatewayAttributeResponse>(req, "ModifyNatGatewayAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the port forwarding rule of a NAT gateway.
        /// </summary>
        /// <param name="req"><see cref="ModifyNatGatewayDestinationIpPortTranslationNatRuleRequest"/></param>
        /// <returns><see cref="ModifyNatGatewayDestinationIpPortTranslationNatRuleResponse"/></returns>
        public Task<ModifyNatGatewayDestinationIpPortTranslationNatRuleResponse> ModifyNatGatewayDestinationIpPortTranslationNatRule(ModifyNatGatewayDestinationIpPortTranslationNatRuleRequest req)
        {
            return InternalRequestAsync<ModifyNatGatewayDestinationIpPortTranslationNatRuleResponse>(req, "ModifyNatGatewayDestinationIpPortTranslationNatRule");
        }

        /// <summary>
        /// This API is used to modify the port forwarding rule of a NAT gateway.
        /// </summary>
        /// <param name="req"><see cref="ModifyNatGatewayDestinationIpPortTranslationNatRuleRequest"/></param>
        /// <returns><see cref="ModifyNatGatewayDestinationIpPortTranslationNatRuleResponse"/></returns>
        public ModifyNatGatewayDestinationIpPortTranslationNatRuleResponse ModifyNatGatewayDestinationIpPortTranslationNatRuleSync(ModifyNatGatewayDestinationIpPortTranslationNatRuleRequest req)
        {
            return InternalRequestAsync<ModifyNatGatewayDestinationIpPortTranslationNatRuleResponse>(req, "ModifyNatGatewayDestinationIpPortTranslationNatRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a NAT gateway's SNAT forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyNatGatewaySourceIpTranslationNatRuleRequest"/></param>
        /// <returns><see cref="ModifyNatGatewaySourceIpTranslationNatRuleResponse"/></returns>
        public Task<ModifyNatGatewaySourceIpTranslationNatRuleResponse> ModifyNatGatewaySourceIpTranslationNatRule(ModifyNatGatewaySourceIpTranslationNatRuleRequest req)
        {
            return InternalRequestAsync<ModifyNatGatewaySourceIpTranslationNatRuleResponse>(req, "ModifyNatGatewaySourceIpTranslationNatRule");
        }

        /// <summary>
        /// This API is used to modify a NAT gateway's SNAT forwarding rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyNatGatewaySourceIpTranslationNatRuleRequest"/></param>
        /// <returns><see cref="ModifyNatGatewaySourceIpTranslationNatRuleResponse"/></returns>
        public ModifyNatGatewaySourceIpTranslationNatRuleResponse ModifyNatGatewaySourceIpTranslationNatRuleSync(ModifyNatGatewaySourceIpTranslationNatRuleRequest req)
        {
            return InternalRequestAsync<ModifyNatGatewaySourceIpTranslationNatRuleResponse>(req, "ModifyNatGatewaySourceIpTranslationNatRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyNetDetect) is used to modify network detection parameters.
        /// </summary>
        /// <param name="req"><see cref="ModifyNetDetectRequest"/></param>
        /// <returns><see cref="ModifyNetDetectResponse"/></returns>
        public Task<ModifyNetDetectResponse> ModifyNetDetect(ModifyNetDetectRequest req)
        {
            return InternalRequestAsync<ModifyNetDetectResponse>(req, "ModifyNetDetect");
        }

        /// <summary>
        /// This API (ModifyNetDetect) is used to modify network detection parameters.
        /// </summary>
        /// <param name="req"><see cref="ModifyNetDetectRequest"/></param>
        /// <returns><see cref="ModifyNetDetectResponse"/></returns>
        public ModifyNetDetectResponse ModifyNetDetectSync(ModifyNetDetectRequest req)
        {
            return InternalRequestAsync<ModifyNetDetectResponse>(req, "ModifyNetDetect")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the attributes of a network ACL.
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkAclAttributeRequest"/></param>
        /// <returns><see cref="ModifyNetworkAclAttributeResponse"/></returns>
        public Task<ModifyNetworkAclAttributeResponse> ModifyNetworkAclAttribute(ModifyNetworkAclAttributeRequest req)
        {
            return InternalRequestAsync<ModifyNetworkAclAttributeResponse>(req, "ModifyNetworkAclAttribute");
        }

        /// <summary>
        /// This API is used to modify the attributes of a network ACL.
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkAclAttributeRequest"/></param>
        /// <returns><see cref="ModifyNetworkAclAttributeResponse"/></returns>
        public ModifyNetworkAclAttributeResponse ModifyNetworkAclAttributeSync(ModifyNetworkAclAttributeRequest req)
        {
            return InternalRequestAsync<ModifyNetworkAclAttributeResponse>(req, "ModifyNetworkAclAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify (add or delete) the inbound and outbound rules of a network ACL. In `NetworkAclEntrySet` parameters,
        /// * Passing in the new inbound/outbound rules will reset the original rules.
        /// * Passing in the inbound rules will only reset the original inbound rules and not affect the original outbound rules, and vice versa.
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkAclEntriesRequest"/></param>
        /// <returns><see cref="ModifyNetworkAclEntriesResponse"/></returns>
        public Task<ModifyNetworkAclEntriesResponse> ModifyNetworkAclEntries(ModifyNetworkAclEntriesRequest req)
        {
            return InternalRequestAsync<ModifyNetworkAclEntriesResponse>(req, "ModifyNetworkAclEntries");
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
            return InternalRequestAsync<ModifyNetworkAclEntriesResponse>(req, "ModifyNetworkAclEntries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the in/outbound rules of the network ACL quintuple. In the `NetworkAclQuintupleEntrySet` parameters, `NetworkAclQuintupleEntryId` is required for `NetworkAclQuintupleEntry`.
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkAclQuintupleEntriesRequest"/></param>
        /// <returns><see cref="ModifyNetworkAclQuintupleEntriesResponse"/></returns>
        public Task<ModifyNetworkAclQuintupleEntriesResponse> ModifyNetworkAclQuintupleEntries(ModifyNetworkAclQuintupleEntriesRequest req)
        {
            return InternalRequestAsync<ModifyNetworkAclQuintupleEntriesResponse>(req, "ModifyNetworkAclQuintupleEntries");
        }

        /// <summary>
        /// This API is used to modify the in/outbound rules of the network ACL quintuple. In the `NetworkAclQuintupleEntrySet` parameters, `NetworkAclQuintupleEntryId` is required for `NetworkAclQuintupleEntry`.
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkAclQuintupleEntriesRequest"/></param>
        /// <returns><see cref="ModifyNetworkAclQuintupleEntriesResponse"/></returns>
        public ModifyNetworkAclQuintupleEntriesResponse ModifyNetworkAclQuintupleEntriesSync(ModifyNetworkAclQuintupleEntriesRequest req)
        {
            return InternalRequestAsync<ModifyNetworkAclQuintupleEntriesResponse>(req, "ModifyNetworkAclQuintupleEntries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyNetworkInterfaceAttribute) is used to modify ENI attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkInterfaceAttributeRequest"/></param>
        /// <returns><see cref="ModifyNetworkInterfaceAttributeResponse"/></returns>
        public Task<ModifyNetworkInterfaceAttributeResponse> ModifyNetworkInterfaceAttribute(ModifyNetworkInterfaceAttributeRequest req)
        {
            return InternalRequestAsync<ModifyNetworkInterfaceAttributeResponse>(req, "ModifyNetworkInterfaceAttribute");
        }

        /// <summary>
        /// This API (ModifyNetworkInterfaceAttribute) is used to modify ENI attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkInterfaceAttributeRequest"/></param>
        /// <returns><see cref="ModifyNetworkInterfaceAttributeResponse"/></returns>
        public ModifyNetworkInterfaceAttributeResponse ModifyNetworkInterfaceAttributeSync(ModifyNetworkInterfaceAttributeRequest req)
        {
            return InternalRequestAsync<ModifyNetworkInterfaceAttributeResponse>(req, "ModifyNetworkInterfaceAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyPrivateIpAddressesAttribute) is used to modify the private IP attributes of an ENI.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateIpAddressesAttributeRequest"/></param>
        /// <returns><see cref="ModifyPrivateIpAddressesAttributeResponse"/></returns>
        public Task<ModifyPrivateIpAddressesAttributeResponse> ModifyPrivateIpAddressesAttribute(ModifyPrivateIpAddressesAttributeRequest req)
        {
            return InternalRequestAsync<ModifyPrivateIpAddressesAttributeResponse>(req, "ModifyPrivateIpAddressesAttribute");
        }

        /// <summary>
        /// This API (ModifyPrivateIpAddressesAttribute) is used to modify the private IP attributes of an ENI.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateIpAddressesAttributeRequest"/></param>
        /// <returns><see cref="ModifyPrivateIpAddressesAttributeResponse"/></returns>
        public ModifyPrivateIpAddressesAttributeResponse ModifyPrivateIpAddressesAttributeSync(ModifyPrivateIpAddressesAttributeRequest req)
        {
            return InternalRequestAsync<ModifyPrivateIpAddressesAttributeResponse>(req, "ModifyPrivateIpAddressesAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyRouteTableAttribute) is used to modify the attributes of a route table.
        /// </summary>
        /// <param name="req"><see cref="ModifyRouteTableAttributeRequest"/></param>
        /// <returns><see cref="ModifyRouteTableAttributeResponse"/></returns>
        public Task<ModifyRouteTableAttributeResponse> ModifyRouteTableAttribute(ModifyRouteTableAttributeRequest req)
        {
            return InternalRequestAsync<ModifyRouteTableAttributeResponse>(req, "ModifyRouteTableAttribute");
        }

        /// <summary>
        /// This API (ModifyRouteTableAttribute) is used to modify the attributes of a route table.
        /// </summary>
        /// <param name="req"><see cref="ModifyRouteTableAttributeRequest"/></param>
        /// <returns><see cref="ModifyRouteTableAttributeResponse"/></returns>
        public ModifyRouteTableAttributeResponse ModifyRouteTableAttributeSync(ModifyRouteTableAttributeRequest req)
        {
            return InternalRequestAsync<ModifyRouteTableAttributeResponse>(req, "ModifyRouteTableAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifySecurityGroupAttribute) is used to modify the attributes of a security group (SecurityGroupPolicy).
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupAttributeResponse"/></returns>
        public Task<ModifySecurityGroupAttributeResponse> ModifySecurityGroupAttribute(ModifySecurityGroupAttributeRequest req)
        {
            return InternalRequestAsync<ModifySecurityGroupAttributeResponse>(req, "ModifySecurityGroupAttribute");
        }

        /// <summary>
        /// This API (ModifySecurityGroupAttribute) is used to modify the attributes of a security group (SecurityGroupPolicy).
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupAttributeResponse"/></returns>
        public ModifySecurityGroupAttributeResponse ModifySecurityGroupAttributeSync(ModifySecurityGroupAttributeRequest req)
        {
            return InternalRequestAsync<ModifySecurityGroupAttributeResponse>(req, "ModifySecurityGroupAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        public Task<ModifySecurityGroupPoliciesResponse> ModifySecurityGroupPolicies(ModifySecurityGroupPoliciesRequest req)
        {
            return InternalRequestAsync<ModifySecurityGroupPoliciesResponse>(req, "ModifySecurityGroupPolicies");
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
            return InternalRequestAsync<ModifySecurityGroupPoliciesResponse>(req, "ModifySecurityGroupPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyServiceTemplateAttribute) is used to modify a protocol port template.
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceTemplateAttributeRequest"/></param>
        /// <returns><see cref="ModifyServiceTemplateAttributeResponse"/></returns>
        public Task<ModifyServiceTemplateAttributeResponse> ModifyServiceTemplateAttribute(ModifyServiceTemplateAttributeRequest req)
        {
            return InternalRequestAsync<ModifyServiceTemplateAttributeResponse>(req, "ModifyServiceTemplateAttribute");
        }

        /// <summary>
        /// This API (ModifyServiceTemplateAttribute) is used to modify a protocol port template.
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceTemplateAttributeRequest"/></param>
        /// <returns><see cref="ModifyServiceTemplateAttributeResponse"/></returns>
        public ModifyServiceTemplateAttributeResponse ModifyServiceTemplateAttributeSync(ModifyServiceTemplateAttributeRequest req)
        {
            return InternalRequestAsync<ModifyServiceTemplateAttributeResponse>(req, "ModifyServiceTemplateAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyServiceTemplateGroupAttribute) is used to modify a protocol port template group.
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceTemplateGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyServiceTemplateGroupAttributeResponse"/></returns>
        public Task<ModifyServiceTemplateGroupAttributeResponse> ModifyServiceTemplateGroupAttribute(ModifyServiceTemplateGroupAttributeRequest req)
        {
            return InternalRequestAsync<ModifyServiceTemplateGroupAttributeResponse>(req, "ModifyServiceTemplateGroupAttribute");
        }

        /// <summary>
        /// This API (ModifyServiceTemplateGroupAttribute) is used to modify a protocol port template group.
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceTemplateGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifyServiceTemplateGroupAttributeResponse"/></returns>
        public ModifyServiceTemplateGroupAttributeResponse ModifyServiceTemplateGroupAttributeSync(ModifyServiceTemplateGroupAttributeRequest req)
        {
            return InternalRequestAsync<ModifyServiceTemplateGroupAttributeResponse>(req, "ModifyServiceTemplateGroupAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify specified snapshot policies.
        /// </summary>
        /// <param name="req"><see cref="ModifySnapshotPoliciesRequest"/></param>
        /// <returns><see cref="ModifySnapshotPoliciesResponse"/></returns>
        public Task<ModifySnapshotPoliciesResponse> ModifySnapshotPolicies(ModifySnapshotPoliciesRequest req)
        {
            return InternalRequestAsync<ModifySnapshotPoliciesResponse>(req, "ModifySnapshotPolicies");
        }

        /// <summary>
        /// This API is used to modify specified snapshot policies.
        /// </summary>
        /// <param name="req"><see cref="ModifySnapshotPoliciesRequest"/></param>
        /// <returns><see cref="ModifySnapshotPoliciesResponse"/></returns>
        public ModifySnapshotPoliciesResponse ModifySnapshotPoliciesSync(ModifySnapshotPoliciesRequest req)
        {
            return InternalRequestAsync<ModifySnapshotPoliciesResponse>(req, "ModifySnapshotPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifySubnetAttribute) is used to modify subnet attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifySubnetAttributeRequest"/></param>
        /// <returns><see cref="ModifySubnetAttributeResponse"/></returns>
        public Task<ModifySubnetAttributeResponse> ModifySubnetAttribute(ModifySubnetAttributeRequest req)
        {
            return InternalRequestAsync<ModifySubnetAttributeResponse>(req, "ModifySubnetAttribute");
        }

        /// <summary>
        /// This API (ModifySubnetAttribute) is used to modify subnet attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifySubnetAttributeRequest"/></param>
        /// <returns><see cref="ModifySubnetAttributeResponse"/></returns>
        public ModifySubnetAttributeResponse ModifySubnetAttributeSync(ModifySubnetAttributeRequest req)
        {
            return InternalRequestAsync<ModifySubnetAttributeResponse>(req, "ModifySubnetAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyVpcAttribute) is used to modify VPC attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcAttributeRequest"/></param>
        /// <returns><see cref="ModifyVpcAttributeResponse"/></returns>
        public Task<ModifyVpcAttributeResponse> ModifyVpcAttribute(ModifyVpcAttributeRequest req)
        {
            return InternalRequestAsync<ModifyVpcAttributeResponse>(req, "ModifyVpcAttribute");
        }

        /// <summary>
        /// This API (ModifyVpcAttribute) is used to modify VPC attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcAttributeRequest"/></param>
        /// <returns><see cref="ModifyVpcAttributeResponse"/></returns>
        public ModifyVpcAttributeResponse ModifyVpcAttributeSync(ModifyVpcAttributeRequest req)
        {
            return InternalRequestAsync<ModifyVpcAttributeResponse>(req, "ModifyVpcAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify endpoint attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcEndPointAttributeRequest"/></param>
        /// <returns><see cref="ModifyVpcEndPointAttributeResponse"/></returns>
        public Task<ModifyVpcEndPointAttributeResponse> ModifyVpcEndPointAttribute(ModifyVpcEndPointAttributeRequest req)
        {
            return InternalRequestAsync<ModifyVpcEndPointAttributeResponse>(req, "ModifyVpcEndPointAttribute");
        }

        /// <summary>
        /// This API is used to modify endpoint attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcEndPointAttributeRequest"/></param>
        /// <returns><see cref="ModifyVpcEndPointAttributeResponse"/></returns>
        public ModifyVpcEndPointAttributeResponse ModifyVpcEndPointAttributeSync(ModifyVpcEndPointAttributeRequest req)
        {
            return InternalRequestAsync<ModifyVpcEndPointAttributeResponse>(req, "ModifyVpcEndPointAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the VPC endpoint service attributes.
        /// 
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcEndPointServiceAttributeRequest"/></param>
        /// <returns><see cref="ModifyVpcEndPointServiceAttributeResponse"/></returns>
        public Task<ModifyVpcEndPointServiceAttributeResponse> ModifyVpcEndPointServiceAttribute(ModifyVpcEndPointServiceAttributeRequest req)
        {
            return InternalRequestAsync<ModifyVpcEndPointServiceAttributeResponse>(req, "ModifyVpcEndPointServiceAttribute");
        }

        /// <summary>
        /// This API is used to modify the VPC endpoint service attributes.
        /// 
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcEndPointServiceAttributeRequest"/></param>
        /// <returns><see cref="ModifyVpcEndPointServiceAttributeResponse"/></returns>
        public ModifyVpcEndPointServiceAttributeResponse ModifyVpcEndPointServiceAttributeSync(ModifyVpcEndPointServiceAttributeRequest req)
        {
            return InternalRequestAsync<ModifyVpcEndPointServiceAttributeResponse>(req, "ModifyVpcEndPointServiceAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the attributes of the endpoint service allowlist.
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcEndPointServiceWhiteListRequest"/></param>
        /// <returns><see cref="ModifyVpcEndPointServiceWhiteListResponse"/></returns>
        public Task<ModifyVpcEndPointServiceWhiteListResponse> ModifyVpcEndPointServiceWhiteList(ModifyVpcEndPointServiceWhiteListRequest req)
        {
            return InternalRequestAsync<ModifyVpcEndPointServiceWhiteListResponse>(req, "ModifyVpcEndPointServiceWhiteList");
        }

        /// <summary>
        /// This API is used to modify the attributes of the endpoint service allowlist.
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcEndPointServiceWhiteListRequest"/></param>
        /// <returns><see cref="ModifyVpcEndPointServiceWhiteListResponse"/></returns>
        public ModifyVpcEndPointServiceWhiteListResponse ModifyVpcEndPointServiceWhiteListSync(ModifyVpcEndPointServiceWhiteListRequest req)
        {
            return InternalRequestAsync<ModifyVpcEndPointServiceWhiteListResponse>(req, "ModifyVpcEndPointServiceWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyVpnConnectionAttribute) is used to modify VPN tunnels.
        /// </summary>
        /// <param name="req"><see cref="ModifyVpnConnectionAttributeRequest"/></param>
        /// <returns><see cref="ModifyVpnConnectionAttributeResponse"/></returns>
        public Task<ModifyVpnConnectionAttributeResponse> ModifyVpnConnectionAttribute(ModifyVpnConnectionAttributeRequest req)
        {
            return InternalRequestAsync<ModifyVpnConnectionAttributeResponse>(req, "ModifyVpnConnectionAttribute");
        }

        /// <summary>
        /// This API (ModifyVpnConnectionAttribute) is used to modify VPN tunnels.
        /// </summary>
        /// <param name="req"><see cref="ModifyVpnConnectionAttributeRequest"/></param>
        /// <returns><see cref="ModifyVpnConnectionAttributeResponse"/></returns>
        public ModifyVpnConnectionAttributeResponse ModifyVpnConnectionAttributeSync(ModifyVpnConnectionAttributeRequest req)
        {
            return InternalRequestAsync<ModifyVpnConnectionAttributeResponse>(req, "ModifyVpnConnectionAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyVpnGatewayAttribute) is used to modify the attributes of VPN gateways.
        /// </summary>
        /// <param name="req"><see cref="ModifyVpnGatewayAttributeRequest"/></param>
        /// <returns><see cref="ModifyVpnGatewayAttributeResponse"/></returns>
        public Task<ModifyVpnGatewayAttributeResponse> ModifyVpnGatewayAttribute(ModifyVpnGatewayAttributeRequest req)
        {
            return InternalRequestAsync<ModifyVpnGatewayAttributeResponse>(req, "ModifyVpnGatewayAttribute");
        }

        /// <summary>
        /// This API (ModifyVpnGatewayAttribute) is used to modify the attributes of VPN gateways.
        /// </summary>
        /// <param name="req"><see cref="ModifyVpnGatewayAttributeRequest"/></param>
        /// <returns><see cref="ModifyVpnGatewayAttributeResponse"/></returns>
        public ModifyVpnGatewayAttributeResponse ModifyVpnGatewayAttributeSync(ModifyVpnGatewayAttributeRequest req)
        {
            return InternalRequestAsync<ModifyVpnGatewayAttributeResponse>(req, "ModifyVpnGatewayAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify VPN gateway-based CCN routes.
        /// </summary>
        /// <param name="req"><see cref="ModifyVpnGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="ModifyVpnGatewayCcnRoutesResponse"/></returns>
        public Task<ModifyVpnGatewayCcnRoutesResponse> ModifyVpnGatewayCcnRoutes(ModifyVpnGatewayCcnRoutesRequest req)
        {
            return InternalRequestAsync<ModifyVpnGatewayCcnRoutesResponse>(req, "ModifyVpnGatewayCcnRoutes");
        }

        /// <summary>
        /// This API is used to modify VPN gateway-based CCN routes.
        /// </summary>
        /// <param name="req"><see cref="ModifyVpnGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="ModifyVpnGatewayCcnRoutesResponse"/></returns>
        public ModifyVpnGatewayCcnRoutesResponse ModifyVpnGatewayCcnRoutesSync(ModifyVpnGatewayCcnRoutesRequest req)
        {
            return InternalRequestAsync<ModifyVpnGatewayCcnRoutesResponse>(req, "ModifyVpnGatewayCcnRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify VPN gateway routes.
        /// </summary>
        /// <param name="req"><see cref="ModifyVpnGatewayRoutesRequest"/></param>
        /// <returns><see cref="ModifyVpnGatewayRoutesResponse"/></returns>
        public Task<ModifyVpnGatewayRoutesResponse> ModifyVpnGatewayRoutes(ModifyVpnGatewayRoutesRequest req)
        {
            return InternalRequestAsync<ModifyVpnGatewayRoutesResponse>(req, "ModifyVpnGatewayRoutes");
        }

        /// <summary>
        /// This API is used to modify VPN gateway routes.
        /// </summary>
        /// <param name="req"><see cref="ModifyVpnGatewayRoutesRequest"/></param>
        /// <returns><see cref="ModifyVpnGatewayRoutesResponse"/></returns>
        public ModifyVpnGatewayRoutesResponse ModifyVpnGatewayRoutesSync(ModifyVpnGatewayRoutesRequest req)
        {
            return InternalRequestAsync<ModifyVpnGatewayRoutesResponse>(req, "ModifyVpnGatewayRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to publish a route to CCN. This can also be done by clicking "Publish to CCN" in the operation column on the page of route table list.
        /// </summary>
        /// <param name="req"><see cref="NotifyRoutesRequest"/></param>
        /// <returns><see cref="NotifyRoutesResponse"/></returns>
        public Task<NotifyRoutesResponse> NotifyRoutes(NotifyRoutesRequest req)
        {
            return InternalRequestAsync<NotifyRoutesResponse>(req, "NotifyRoutes");
        }

        /// <summary>
        /// This API is used to publish a route to CCN. This can also be done by clicking "Publish to CCN" in the operation column on the page of route table list.
        /// </summary>
        /// <param name="req"><see cref="NotifyRoutesRequest"/></param>
        /// <returns><see cref="NotifyRoutesResponse"/></returns>
        public NotifyRoutesResponse NotifyRoutesSync(NotifyRoutesRequest req)
        {
            return InternalRequestAsync<NotifyRoutesResponse>(req, "NotifyRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to refresh the route between a NAT gateway and  Direct Connect and update the associated route table.
        /// </summary>
        /// <param name="req"><see cref="RefreshDirectConnectGatewayRouteToNatGatewayRequest"/></param>
        /// <returns><see cref="RefreshDirectConnectGatewayRouteToNatGatewayResponse"/></returns>
        public Task<RefreshDirectConnectGatewayRouteToNatGatewayResponse> RefreshDirectConnectGatewayRouteToNatGateway(RefreshDirectConnectGatewayRouteToNatGatewayRequest req)
        {
            return InternalRequestAsync<RefreshDirectConnectGatewayRouteToNatGatewayResponse>(req, "RefreshDirectConnectGatewayRouteToNatGateway");
        }

        /// <summary>
        /// This API is used to refresh the route between a NAT gateway and  Direct Connect and update the associated route table.
        /// </summary>
        /// <param name="req"><see cref="RefreshDirectConnectGatewayRouteToNatGatewayRequest"/></param>
        /// <returns><see cref="RefreshDirectConnectGatewayRouteToNatGatewayResponse"/></returns>
        public RefreshDirectConnectGatewayRouteToNatGatewayResponse RefreshDirectConnectGatewayRouteToNatGatewaySync(RefreshDirectConnectGatewayRouteToNatGatewayRequest req)
        {
            return InternalRequestAsync<RefreshDirectConnectGatewayRouteToNatGatewayResponse>(req, "RefreshDirectConnectGatewayRouteToNatGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (RejectAttachCcnInstances) is used to reject association operations when instances are associated across accounts for the CCN owner.
        /// </summary>
        /// <param name="req"><see cref="RejectAttachCcnInstancesRequest"/></param>
        /// <returns><see cref="RejectAttachCcnInstancesResponse"/></returns>
        public Task<RejectAttachCcnInstancesResponse> RejectAttachCcnInstances(RejectAttachCcnInstancesRequest req)
        {
            return InternalRequestAsync<RejectAttachCcnInstancesResponse>(req, "RejectAttachCcnInstances");
        }

        /// <summary>
        /// This API (RejectAttachCcnInstances) is used to reject association operations when instances are associated across accounts for the CCN owner.
        /// </summary>
        /// <param name="req"><see cref="RejectAttachCcnInstancesRequest"/></param>
        /// <returns><see cref="RejectAttachCcnInstancesResponse"/></returns>
        public RejectAttachCcnInstancesResponse RejectAttachCcnInstancesSync(RejectAttachCcnInstancesRequest req)
        {
            return InternalRequestAsync<RejectAttachCcnInstancesResponse>(req, "RejectAttachCcnInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ReleaseAddresses) is used to release one or multiple [Elastic IPs](https://intl.cloud.tencent.com/document/product/213/1941?from_cn_redirect=1).
        /// * This operation is irreversible. Once you release an EIP, the IP address associated with the EIP no longer belongs to you.
        /// * Only EIPs in UNBIND status can be released.
        /// </summary>
        /// <param name="req"><see cref="ReleaseAddressesRequest"/></param>
        /// <returns><see cref="ReleaseAddressesResponse"/></returns>
        public Task<ReleaseAddressesResponse> ReleaseAddresses(ReleaseAddressesRequest req)
        {
            return InternalRequestAsync<ReleaseAddressesResponse>(req, "ReleaseAddresses");
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
            return InternalRequestAsync<ReleaseAddressesResponse>(req, "ReleaseAddresses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a bandwidth package resource, including [Elastic IP](https://intl.cloud.tencent.com/document/product/213/1941?from_cn_redirect=1), [Cloud Load Balancer](https://intl.cloud.tencent.com/document/product/214/517?from_cn_redirect=1), and so on.
        /// </summary>
        /// <param name="req"><see cref="RemoveBandwidthPackageResourcesRequest"/></param>
        /// <returns><see cref="RemoveBandwidthPackageResourcesResponse"/></returns>
        public Task<RemoveBandwidthPackageResourcesResponse> RemoveBandwidthPackageResources(RemoveBandwidthPackageResourcesRequest req)
        {
            return InternalRequestAsync<RemoveBandwidthPackageResourcesResponse>(req, "RemoveBandwidthPackageResources");
        }

        /// <summary>
        /// This API is used to delete a bandwidth package resource, including [Elastic IP](https://intl.cloud.tencent.com/document/product/213/1941?from_cn_redirect=1), [Cloud Load Balancer](https://intl.cloud.tencent.com/document/product/214/517?from_cn_redirect=1), and so on.
        /// </summary>
        /// <param name="req"><see cref="RemoveBandwidthPackageResourcesRequest"/></param>
        /// <returns><see cref="RemoveBandwidthPackageResourcesResponse"/></returns>
        public RemoveBandwidthPackageResourcesResponse RemoveBandwidthPackageResourcesSync(RemoveBandwidthPackageResourcesRequest req)
        {
            return InternalRequestAsync<RemoveBandwidthPackageResourcesResponse>(req, "RemoveBandwidthPackageResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (RenewVpnGateway) is used to renew prepaid (monthly subscription) VPN gateways. Currently, only IPSEC gateways are supported.
        /// </summary>
        /// <param name="req"><see cref="RenewVpnGatewayRequest"/></param>
        /// <returns><see cref="RenewVpnGatewayResponse"/></returns>
        public Task<RenewVpnGatewayResponse> RenewVpnGateway(RenewVpnGatewayRequest req)
        {
            return InternalRequestAsync<RenewVpnGatewayResponse>(req, "RenewVpnGateway");
        }

        /// <summary>
        /// This API (RenewVpnGateway) is used to renew prepaid (monthly subscription) VPN gateways. Currently, only IPSEC gateways are supported.
        /// </summary>
        /// <param name="req"><see cref="RenewVpnGatewayRequest"/></param>
        /// <returns><see cref="RenewVpnGatewayResponse"/></returns>
        public RenewVpnGatewayResponse RenewVpnGatewaySync(RenewVpnGatewayRequest req)
        {
            return InternalRequestAsync<RenewVpnGatewayResponse>(req, "RenewVpnGateway")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ReplaceDirectConnectGatewayCcnRoutes) is used to modify the specified route according to the route ID. Batch modification is supported.
        /// </summary>
        /// <param name="req"><see cref="ReplaceDirectConnectGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="ReplaceDirectConnectGatewayCcnRoutesResponse"/></returns>
        public Task<ReplaceDirectConnectGatewayCcnRoutesResponse> ReplaceDirectConnectGatewayCcnRoutes(ReplaceDirectConnectGatewayCcnRoutesRequest req)
        {
            return InternalRequestAsync<ReplaceDirectConnectGatewayCcnRoutesResponse>(req, "ReplaceDirectConnectGatewayCcnRoutes");
        }

        /// <summary>
        /// This API (ReplaceDirectConnectGatewayCcnRoutes) is used to modify the specified route according to the route ID. Batch modification is supported.
        /// </summary>
        /// <param name="req"><see cref="ReplaceDirectConnectGatewayCcnRoutesRequest"/></param>
        /// <returns><see cref="ReplaceDirectConnectGatewayCcnRoutesResponse"/></returns>
        public ReplaceDirectConnectGatewayCcnRoutesResponse ReplaceDirectConnectGatewayCcnRoutesSync(ReplaceDirectConnectGatewayCcnRoutesRequest req)
        {
            return InternalRequestAsync<ReplaceDirectConnectGatewayCcnRoutesResponse>(req, "ReplaceDirectConnectGatewayCcnRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ReplaceRouteTableAssociation) is used to modify the route table associated with a subnet.
        /// * A subnet can only be associated with one route table.
        /// </summary>
        /// <param name="req"><see cref="ReplaceRouteTableAssociationRequest"/></param>
        /// <returns><see cref="ReplaceRouteTableAssociationResponse"/></returns>
        public Task<ReplaceRouteTableAssociationResponse> ReplaceRouteTableAssociation(ReplaceRouteTableAssociationRequest req)
        {
            return InternalRequestAsync<ReplaceRouteTableAssociationResponse>(req, "ReplaceRouteTableAssociation");
        }

        /// <summary>
        /// This API (ReplaceRouteTableAssociation) is used to modify the route table associated with a subnet.
        /// * A subnet can only be associated with one route table.
        /// </summary>
        /// <param name="req"><see cref="ReplaceRouteTableAssociationRequest"/></param>
        /// <returns><see cref="ReplaceRouteTableAssociationResponse"/></returns>
        public ReplaceRouteTableAssociationResponse ReplaceRouteTableAssociationSync(ReplaceRouteTableAssociationRequest req)
        {
            return InternalRequestAsync<ReplaceRouteTableAssociationResponse>(req, "ReplaceRouteTableAssociation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ReplaceRoutes) is used to modify a specified routing policy by its ID (RouteId). Batch modification is supported.
        /// </summary>
        /// <param name="req"><see cref="ReplaceRoutesRequest"/></param>
        /// <returns><see cref="ReplaceRoutesResponse"/></returns>
        public Task<ReplaceRoutesResponse> ReplaceRoutes(ReplaceRoutesRequest req)
        {
            return InternalRequestAsync<ReplaceRoutesResponse>(req, "ReplaceRoutes");
        }

        /// <summary>
        /// This API (ReplaceRoutes) is used to modify a specified routing policy by its ID (RouteId). Batch modification is supported.
        /// </summary>
        /// <param name="req"><see cref="ReplaceRoutesRequest"/></param>
        /// <returns><see cref="ReplaceRoutesResponse"/></returns>
        public ReplaceRoutesResponse ReplaceRoutesSync(ReplaceRoutesRequest req)
        {
            return InternalRequestAsync<ReplaceRoutesResponse>(req, "ReplaceRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch modify security group policies.
        /// Policies to modify must be in the same direction. `PolicyIndex` must be specified.
        /// </summary>
        /// <param name="req"><see cref="ReplaceSecurityGroupPoliciesRequest"/></param>
        /// <returns><see cref="ReplaceSecurityGroupPoliciesResponse"/></returns>
        public Task<ReplaceSecurityGroupPoliciesResponse> ReplaceSecurityGroupPolicies(ReplaceSecurityGroupPoliciesRequest req)
        {
            return InternalRequestAsync<ReplaceSecurityGroupPoliciesResponse>(req, "ReplaceSecurityGroupPolicies");
        }

        /// <summary>
        /// This API is used to batch modify security group policies.
        /// Policies to modify must be in the same direction. `PolicyIndex` must be specified.
        /// </summary>
        /// <param name="req"><see cref="ReplaceSecurityGroupPoliciesRequest"/></param>
        /// <returns><see cref="ReplaceSecurityGroupPoliciesResponse"/></returns>
        public ReplaceSecurityGroupPoliciesResponse ReplaceSecurityGroupPoliciesSync(ReplaceSecurityGroupPoliciesRequest req)
        {
            return InternalRequestAsync<ReplaceSecurityGroupPoliciesResponse>(req, "ReplaceSecurityGroupPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ReplaceSecurityGroupPolicy) is used to replace a single security group policy (SecurityGroupPolicy).
        /// Only one policy in a single direction can be replaced in each request, and the PolicyIndex parameter must be specified.
        /// </summary>
        /// <param name="req"><see cref="ReplaceSecurityGroupPolicyRequest"/></param>
        /// <returns><see cref="ReplaceSecurityGroupPolicyResponse"/></returns>
        public Task<ReplaceSecurityGroupPolicyResponse> ReplaceSecurityGroupPolicy(ReplaceSecurityGroupPolicyRequest req)
        {
            return InternalRequestAsync<ReplaceSecurityGroupPolicyResponse>(req, "ReplaceSecurityGroupPolicy");
        }

        /// <summary>
        /// This API (ReplaceSecurityGroupPolicy) is used to replace a single security group policy (SecurityGroupPolicy).
        /// Only one policy in a single direction can be replaced in each request, and the PolicyIndex parameter must be specified.
        /// </summary>
        /// <param name="req"><see cref="ReplaceSecurityGroupPolicyRequest"/></param>
        /// <returns><see cref="ReplaceSecurityGroupPolicyResponse"/></returns>
        public ReplaceSecurityGroupPolicyResponse ReplaceSecurityGroupPolicySync(ReplaceSecurityGroupPolicyRequest req)
        {
            return InternalRequestAsync<ReplaceSecurityGroupPolicyResponse>(req, "ReplaceSecurityGroupPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ResetAttachCcnInstances) is used to re-apply for the association operation when the application for cross-account instance association expires.
        /// </summary>
        /// <param name="req"><see cref="ResetAttachCcnInstancesRequest"/></param>
        /// <returns><see cref="ResetAttachCcnInstancesResponse"/></returns>
        public Task<ResetAttachCcnInstancesResponse> ResetAttachCcnInstances(ResetAttachCcnInstancesRequest req)
        {
            return InternalRequestAsync<ResetAttachCcnInstancesResponse>(req, "ResetAttachCcnInstances");
        }

        /// <summary>
        /// This API (ResetAttachCcnInstances) is used to re-apply for the association operation when the application for cross-account instance association expires.
        /// </summary>
        /// <param name="req"><see cref="ResetAttachCcnInstancesRequest"/></param>
        /// <returns><see cref="ResetAttachCcnInstancesResponse"/></returns>
        public ResetAttachCcnInstancesResponse ResetAttachCcnInstancesSync(ResetAttachCcnInstancesRequest req)
        {
            return InternalRequestAsync<ResetAttachCcnInstancesResponse>(req, "ResetAttachCcnInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to adjust concurrent connection cap for the NAT gateway.
        /// </summary>
        /// <param name="req"><see cref="ResetNatGatewayConnectionRequest"/></param>
        /// <returns><see cref="ResetNatGatewayConnectionResponse"/></returns>
        public Task<ResetNatGatewayConnectionResponse> ResetNatGatewayConnection(ResetNatGatewayConnectionRequest req)
        {
            return InternalRequestAsync<ResetNatGatewayConnectionResponse>(req, "ResetNatGatewayConnection");
        }

        /// <summary>
        /// This API is used to adjust concurrent connection cap for the NAT gateway.
        /// </summary>
        /// <param name="req"><see cref="ResetNatGatewayConnectionRequest"/></param>
        /// <returns><see cref="ResetNatGatewayConnectionResponse"/></returns>
        public ResetNatGatewayConnectionResponse ResetNatGatewayConnectionSync(ResetNatGatewayConnectionRequest req)
        {
            return InternalRequestAsync<ResetNatGatewayConnectionResponse>(req, "ResetNatGatewayConnection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ResetRoutes) is used to reset the name of a route table and all its routing policies.<br />
        /// Note: When this API is called, all routing policies in the current route table are deleted before new routing policies are saved, which may incur network interruption.
        /// </summary>
        /// <param name="req"><see cref="ResetRoutesRequest"/></param>
        /// <returns><see cref="ResetRoutesResponse"/></returns>
        public Task<ResetRoutesResponse> ResetRoutes(ResetRoutesRequest req)
        {
            return InternalRequestAsync<ResetRoutesResponse>(req, "ResetRoutes");
        }

        /// <summary>
        /// This API (ResetRoutes) is used to reset the name of a route table and all its routing policies.<br />
        /// Note: When this API is called, all routing policies in the current route table are deleted before new routing policies are saved, which may incur network interruption.
        /// </summary>
        /// <param name="req"><see cref="ResetRoutesRequest"/></param>
        /// <returns><see cref="ResetRoutesResponse"/></returns>
        public ResetRoutesResponse ResetRoutesSync(ResetRoutesRequest req)
        {
            return InternalRequestAsync<ResetRoutesResponse>(req, "ResetRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// The API is used to reset a VPN tunnel.
        /// </summary>
        /// <param name="req"><see cref="ResetVpnConnectionRequest"/></param>
        /// <returns><see cref="ResetVpnConnectionResponse"/></returns>
        public Task<ResetVpnConnectionResponse> ResetVpnConnection(ResetVpnConnectionRequest req)
        {
            return InternalRequestAsync<ResetVpnConnectionResponse>(req, "ResetVpnConnection");
        }

        /// <summary>
        /// The API is used to reset a VPN tunnel.
        /// </summary>
        /// <param name="req"><see cref="ResetVpnConnectionRequest"/></param>
        /// <returns><see cref="ResetVpnConnectionResponse"/></returns>
        public ResetVpnConnectionResponse ResetVpnConnectionSync(ResetVpnConnectionRequest req)
        {
            return InternalRequestAsync<ResetVpnConnectionResponse>(req, "ResetVpnConnection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to adjust the bandwidth cap of a VPN gateway. The adjustment of the VPN gateway bandwidth is limited to [5,100] Mbps and [200,1000] Mbps. 
        /// </summary>
        /// <param name="req"><see cref="ResetVpnGatewayInternetMaxBandwidthRequest"/></param>
        /// <returns><see cref="ResetVpnGatewayInternetMaxBandwidthResponse"/></returns>
        public Task<ResetVpnGatewayInternetMaxBandwidthResponse> ResetVpnGatewayInternetMaxBandwidth(ResetVpnGatewayInternetMaxBandwidthRequest req)
        {
            return InternalRequestAsync<ResetVpnGatewayInternetMaxBandwidthResponse>(req, "ResetVpnGatewayInternetMaxBandwidth");
        }

        /// <summary>
        /// This API is used to adjust the bandwidth cap of a VPN gateway. The adjustment of the VPN gateway bandwidth is limited to [5,100] Mbps and [200,1000] Mbps. 
        /// </summary>
        /// <param name="req"><see cref="ResetVpnGatewayInternetMaxBandwidthRequest"/></param>
        /// <returns><see cref="ResetVpnGatewayInternetMaxBandwidthResponse"/></returns>
        public ResetVpnGatewayInternetMaxBandwidthResponse ResetVpnGatewayInternetMaxBandwidthSync(ResetVpnGatewayInternetMaxBandwidthRequest req)
        {
            return InternalRequestAsync<ResetVpnGatewayInternetMaxBandwidthResponse>(req, "ResetVpnGatewayInternetMaxBandwidth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to restore security group policies with a backup.
        /// </summary>
        /// <param name="req"><see cref="ResumeSnapshotInstanceRequest"/></param>
        /// <returns><see cref="ResumeSnapshotInstanceResponse"/></returns>
        public Task<ResumeSnapshotInstanceResponse> ResumeSnapshotInstance(ResumeSnapshotInstanceRequest req)
        {
            return InternalRequestAsync<ResumeSnapshotInstanceResponse>(req, "ResumeSnapshotInstance");
        }

        /// <summary>
        /// This API is used to restore security group policies with a backup.
        /// </summary>
        /// <param name="req"><see cref="ResumeSnapshotInstanceRequest"/></param>
        /// <returns><see cref="ResumeSnapshotInstanceResponse"/></returns>
        public ResumeSnapshotInstanceResponse ResumeSnapshotInstanceSync(ResumeSnapshotInstanceRequest req)
        {
            return InternalRequestAsync<ResumeSnapshotInstanceResponse>(req, "ResumeSnapshotInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind and release public IPs. 
        /// Note: Starting from Dec 15, 2022, CAM authorization is required for a sub-account to call this API. For more details, see [Authorization Guide](https://intl.cloud.tencent.com/document/product/598/34545?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ReturnNormalAddressesRequest"/></param>
        /// <returns><see cref="ReturnNormalAddressesResponse"/></returns>
        public Task<ReturnNormalAddressesResponse> ReturnNormalAddresses(ReturnNormalAddressesRequest req)
        {
            return InternalRequestAsync<ReturnNormalAddressesResponse>(req, "ReturnNormalAddresses");
        }

        /// <summary>
        /// This API is used to unbind and release public IPs. 
        /// Note: Starting from Dec 15, 2022, CAM authorization is required for a sub-account to call this API. For more details, see [Authorization Guide](https://intl.cloud.tencent.com/document/product/598/34545?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ReturnNormalAddressesRequest"/></param>
        /// <returns><see cref="ReturnNormalAddressesResponse"/></returns>
        public ReturnNormalAddressesResponse ReturnNormalAddressesSync(ReturnNormalAddressesRequest req)
        {
            return InternalRequestAsync<ReturnNormalAddressesResponse>(req, "ReturnNormalAddresses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (SetCcnRegionBandwidthLimits) is used to set the outbound bandwidth cap for CCNs in each region. This API can only set the outbound bandwidth cap for regions in the network instances that have already been associated.
        /// </summary>
        /// <param name="req"><see cref="SetCcnRegionBandwidthLimitsRequest"/></param>
        /// <returns><see cref="SetCcnRegionBandwidthLimitsResponse"/></returns>
        public Task<SetCcnRegionBandwidthLimitsResponse> SetCcnRegionBandwidthLimits(SetCcnRegionBandwidthLimitsRequest req)
        {
            return InternalRequestAsync<SetCcnRegionBandwidthLimitsResponse>(req, "SetCcnRegionBandwidthLimits");
        }

        /// <summary>
        /// This API (SetCcnRegionBandwidthLimits) is used to set the outbound bandwidth cap for CCNs in each region. This API can only set the outbound bandwidth cap for regions in the network instances that have already been associated.
        /// </summary>
        /// <param name="req"><see cref="SetCcnRegionBandwidthLimitsRequest"/></param>
        /// <returns><see cref="SetCcnRegionBandwidthLimitsResponse"/></returns>
        public SetCcnRegionBandwidthLimitsResponse SetCcnRegionBandwidthLimitsSync(SetCcnRegionBandwidthLimitsRequest req)
        {
            return InternalRequestAsync<SetCcnRegionBandwidthLimitsResponse>(req, "SetCcnRegionBandwidthLimits")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used set the auto-renewal configuration of a VPN gateway.
        /// </summary>
        /// <param name="req"><see cref="SetVpnGatewaysRenewFlagRequest"/></param>
        /// <returns><see cref="SetVpnGatewaysRenewFlagResponse"/></returns>
        public Task<SetVpnGatewaysRenewFlagResponse> SetVpnGatewaysRenewFlag(SetVpnGatewaysRenewFlagRequest req)
        {
            return InternalRequestAsync<SetVpnGatewaysRenewFlagResponse>(req, "SetVpnGatewaysRenewFlag");
        }

        /// <summary>
        /// This API is used set the auto-renewal configuration of a VPN gateway.
        /// </summary>
        /// <param name="req"><see cref="SetVpnGatewaysRenewFlagRequest"/></param>
        /// <returns><see cref="SetVpnGatewaysRenewFlagResponse"/></returns>
        public SetVpnGatewaysRenewFlagResponse SetVpnGatewaysRenewFlagSync(SetVpnGatewaysRenewFlagRequest req)
        {
            return InternalRequestAsync<SetVpnGatewaysRenewFlagResponse>(req, "SetVpnGatewaysRenewFlag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to convert a common public IP into an [Elastic IP](https://intl.cloud.tencent.com/document/product/213/1941?from_cn_redirect=1) (EIP for short).
        /// * Tencent Cloud limits the number of times that a user can unbind EIPs and reassign public IPs in each region per day. For more information, see product introduction of [Elastic IP](https://intl.cloud.tencent.com/document/product/213/5733?from_cn_redirect=1). The preceding quota can be obtained through the API [DescribeAddressQuota](https://intl.cloud.tencent.com/document/product/215/16701).
        /// </summary>
        /// <param name="req"><see cref="TransformAddressRequest"/></param>
        /// <returns><see cref="TransformAddressResponse"/></returns>
        public Task<TransformAddressResponse> TransformAddress(TransformAddressRequest req)
        {
            return InternalRequestAsync<TransformAddressResponse>(req, "TransformAddress");
        }

        /// <summary>
        /// This API is used to convert a common public IP into an [Elastic IP](https://intl.cloud.tencent.com/document/product/213/1941?from_cn_redirect=1) (EIP for short).
        /// * Tencent Cloud limits the number of times that a user can unbind EIPs and reassign public IPs in each region per day. For more information, see product introduction of [Elastic IP](https://intl.cloud.tencent.com/document/product/213/5733?from_cn_redirect=1). The preceding quota can be obtained through the API [DescribeAddressQuota](https://intl.cloud.tencent.com/document/product/215/16701).
        /// </summary>
        /// <param name="req"><see cref="TransformAddressRequest"/></param>
        /// <returns><see cref="TransformAddressResponse"/></returns>
        public TransformAddressResponse TransformAddressSync(TransformAddressRequest req)
        {
            return InternalRequestAsync<TransformAddressResponse>(req, "TransformAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to release the IPv6 addresses of an ENI. <br />
        /// This API is completed asynchronously. If you need to query the execution result of an async task, please use the `RequestId` returned by this API to poll the `DescribeVpcTaskResult` API.
        /// </summary>
        /// <param name="req"><see cref="UnassignIpv6AddressesRequest"/></param>
        /// <returns><see cref="UnassignIpv6AddressesResponse"/></returns>
        public Task<UnassignIpv6AddressesResponse> UnassignIpv6Addresses(UnassignIpv6AddressesRequest req)
        {
            return InternalRequestAsync<UnassignIpv6AddressesResponse>(req, "UnassignIpv6Addresses");
        }

        /// <summary>
        /// This API is used to release the IPv6 addresses of an ENI. <br />
        /// This API is completed asynchronously. If you need to query the execution result of an async task, please use the `RequestId` returned by this API to poll the `DescribeVpcTaskResult` API.
        /// </summary>
        /// <param name="req"><see cref="UnassignIpv6AddressesRequest"/></param>
        /// <returns><see cref="UnassignIpv6AddressesResponse"/></returns>
        public UnassignIpv6AddressesResponse UnassignIpv6AddressesSync(UnassignIpv6AddressesRequest req)
        {
            return InternalRequestAsync<UnassignIpv6AddressesResponse>(req, "UnassignIpv6Addresses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (UnassignIpv6CidrBlock) is used to release IPv6 IP ranges.
        /// If the IP range still has occupied IPs that are not yet repossessed, the IP range cannot be released.
        /// </summary>
        /// <param name="req"><see cref="UnassignIpv6CidrBlockRequest"/></param>
        /// <returns><see cref="UnassignIpv6CidrBlockResponse"/></returns>
        public Task<UnassignIpv6CidrBlockResponse> UnassignIpv6CidrBlock(UnassignIpv6CidrBlockRequest req)
        {
            return InternalRequestAsync<UnassignIpv6CidrBlockResponse>(req, "UnassignIpv6CidrBlock");
        }

        /// <summary>
        /// This API (UnassignIpv6CidrBlock) is used to release IPv6 IP ranges.
        /// If the IP range still has occupied IPs that are not yet repossessed, the IP range cannot be released.
        /// </summary>
        /// <param name="req"><see cref="UnassignIpv6CidrBlockRequest"/></param>
        /// <returns><see cref="UnassignIpv6CidrBlockResponse"/></returns>
        public UnassignIpv6CidrBlockResponse UnassignIpv6CidrBlockSync(UnassignIpv6CidrBlockRequest req)
        {
            return InternalRequestAsync<UnassignIpv6CidrBlockResponse>(req, "UnassignIpv6CidrBlock")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (UnassignIpv6SubnetCidrBlock) is used to release IPv6 subnet IP ranges.
        /// If the subnet IP range still has occupied IPs that are not yet repossessed, the subnet IP range cannot be released.
        /// </summary>
        /// <param name="req"><see cref="UnassignIpv6SubnetCidrBlockRequest"/></param>
        /// <returns><see cref="UnassignIpv6SubnetCidrBlockResponse"/></returns>
        public Task<UnassignIpv6SubnetCidrBlockResponse> UnassignIpv6SubnetCidrBlock(UnassignIpv6SubnetCidrBlockRequest req)
        {
            return InternalRequestAsync<UnassignIpv6SubnetCidrBlockResponse>(req, "UnassignIpv6SubnetCidrBlock");
        }

        /// <summary>
        /// This API (UnassignIpv6SubnetCidrBlock) is used to release IPv6 subnet IP ranges.
        /// If the subnet IP range still has occupied IPs that are not yet repossessed, the subnet IP range cannot be released.
        /// </summary>
        /// <param name="req"><see cref="UnassignIpv6SubnetCidrBlockRequest"/></param>
        /// <returns><see cref="UnassignIpv6SubnetCidrBlockResponse"/></returns>
        public UnassignIpv6SubnetCidrBlockResponse UnassignIpv6SubnetCidrBlockSync(UnassignIpv6SubnetCidrBlockRequest req)
        {
            return InternalRequestAsync<UnassignIpv6SubnetCidrBlockResponse>(req, "UnassignIpv6SubnetCidrBlock")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to return the private IP addresses of an ENI.
        /// * If a secondary private IP of an ENI is returned, the EIP will be automatically unassociated as well. The primary private IP of the ENI cannot be returned.
        /// 
        /// This API is completed asynchronously. If you need to query the execution result of an async task, please use the `RequestId` returned by this API to poll the `DescribeVpcTaskResult` API.
        /// </summary>
        /// <param name="req"><see cref="UnassignPrivateIpAddressesRequest"/></param>
        /// <returns><see cref="UnassignPrivateIpAddressesResponse"/></returns>
        public Task<UnassignPrivateIpAddressesResponse> UnassignPrivateIpAddresses(UnassignPrivateIpAddressesRequest req)
        {
            return InternalRequestAsync<UnassignPrivateIpAddressesResponse>(req, "UnassignPrivateIpAddresses");
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
            return InternalRequestAsync<UnassignPrivateIpAddressesResponse>(req, "UnassignPrivateIpAddresses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to withdraw a route from CCN. 
        /// </summary>
        /// <param name="req"><see cref="WithdrawNotifyRoutesRequest"/></param>
        /// <returns><see cref="WithdrawNotifyRoutesResponse"/></returns>
        public Task<WithdrawNotifyRoutesResponse> WithdrawNotifyRoutes(WithdrawNotifyRoutesRequest req)
        {
            return InternalRequestAsync<WithdrawNotifyRoutesResponse>(req, "WithdrawNotifyRoutes");
        }

        /// <summary>
        /// This API is used to withdraw a route from CCN. 
        /// </summary>
        /// <param name="req"><see cref="WithdrawNotifyRoutesRequest"/></param>
        /// <returns><see cref="WithdrawNotifyRoutesResponse"/></returns>
        public WithdrawNotifyRoutesResponse WithdrawNotifyRoutesSync(WithdrawNotifyRoutesRequest req)
        {
            return InternalRequestAsync<WithdrawNotifyRoutesResponse>(req, "WithdrawNotifyRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
