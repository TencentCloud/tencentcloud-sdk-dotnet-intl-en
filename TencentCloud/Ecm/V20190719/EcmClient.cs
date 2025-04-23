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

       private const string endpoint = "ecm.intl.tencentcloudapi.com";
       private const string version = "2019-07-19";
       private const string sdkVersion = "SDK_NET_3.0.1116";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public EcmClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to apply for one or multiple EIPs.
        /// </summary>
        /// <param name="req"><see cref="AllocateAddressesRequest"/></param>
        /// <returns><see cref="AllocateAddressesResponse"/></returns>
        public Task<AllocateAddressesResponse> AllocateAddresses(AllocateAddressesRequest req)
        {
            return InternalRequestAsync<AllocateAddressesResponse>(req, "AllocateAddresses");
        }

        /// <summary>
        /// This API is used to apply for one or multiple EIPs.
        /// </summary>
        /// <param name="req"><see cref="AllocateAddressesRequest"/></param>
        /// <returns><see cref="AllocateAddressesResponse"/></returns>
        public AllocateAddressesResponse AllocateAddressesSync(AllocateAddressesRequest req)
        {
            return InternalRequestAsync<AllocateAddressesResponse>(req, "AllocateAddresses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to apply for an IPv6 address for an ENI.
        /// </summary>
        /// <param name="req"><see cref="AssignIpv6AddressesRequest"/></param>
        /// <returns><see cref="AssignIpv6AddressesResponse"/></returns>
        public Task<AssignIpv6AddressesResponse> AssignIpv6Addresses(AssignIpv6AddressesRequest req)
        {
            return InternalRequestAsync<AssignIpv6AddressesResponse>(req, "AssignIpv6Addresses");
        }

        /// <summary>
        /// This API is used to apply for an IPv6 address for an ENI.
        /// </summary>
        /// <param name="req"><see cref="AssignIpv6AddressesRequest"/></param>
        /// <returns><see cref="AssignIpv6AddressesResponse"/></returns>
        public AssignIpv6AddressesResponse AssignIpv6AddressesSync(AssignIpv6AddressesRequest req)
        {
            return InternalRequestAsync<AssignIpv6AddressesResponse>(req, "AssignIpv6Addresses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to apply for a private IP for an ENI.
        /// </summary>
        /// <param name="req"><see cref="AssignPrivateIpAddressesRequest"/></param>
        /// <returns><see cref="AssignPrivateIpAddressesResponse"/></returns>
        public Task<AssignPrivateIpAddressesResponse> AssignPrivateIpAddresses(AssignPrivateIpAddressesRequest req)
        {
            return InternalRequestAsync<AssignPrivateIpAddressesResponse>(req, "AssignPrivateIpAddresses");
        }

        /// <summary>
        /// This API is used to apply for a private IP for an ENI.
        /// </summary>
        /// <param name="req"><see cref="AssignPrivateIpAddressesRequest"/></param>
        /// <returns><see cref="AssignPrivateIpAddressesResponse"/></returns>
        public AssignPrivateIpAddressesResponse AssignPrivateIpAddressesSync(AssignPrivateIpAddressesRequest req)
        {
            return InternalRequestAsync<AssignPrivateIpAddressesResponse>(req, "AssignPrivateIpAddresses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bind an EIP to an instance or the specified private IP of an ENI.
        /// Binding an EIP to an instance (ECM) is essentially to bind it to the primary private IP of the primary ENI of the instance.
        /// When you bind an EIP to the private IP of the specified ENI, if the private IP is already bound to an EIP or public IP, a failure will be reported, and you must unbind it first before you can bind it to a new EIP.
        /// Only EIPs in `UNBIND` status can be bound to a private IP.
        /// </summary>
        /// <param name="req"><see cref="AssociateAddressRequest"/></param>
        /// <returns><see cref="AssociateAddressResponse"/></returns>
        public Task<AssociateAddressResponse> AssociateAddress(AssociateAddressRequest req)
        {
            return InternalRequestAsync<AssociateAddressResponse>(req, "AssociateAddress");
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
            return InternalRequestAsync<AssociateAddressResponse>(req, "AssociateAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bind a security group.
        /// </summary>
        /// <param name="req"><see cref="AssociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateSecurityGroupsResponse"/></returns>
        public Task<AssociateSecurityGroupsResponse> AssociateSecurityGroups(AssociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<AssociateSecurityGroupsResponse>(req, "AssociateSecurityGroups");
        }

        /// <summary>
        /// This API is used to bind a security group.
        /// </summary>
        /// <param name="req"><see cref="AssociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateSecurityGroupsResponse"/></returns>
        public AssociateSecurityGroupsResponse AssociateSecurityGroupsSync(AssociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<AssociateSecurityGroupsResponse>(req, "AssociateSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bind an ENI to a CVM instance.
        /// </summary>
        /// <param name="req"><see cref="AttachNetworkInterfaceRequest"/></param>
        /// <returns><see cref="AttachNetworkInterfaceResponse"/></returns>
        public Task<AttachNetworkInterfaceResponse> AttachNetworkInterface(AttachNetworkInterfaceRequest req)
        {
            return InternalRequestAsync<AttachNetworkInterfaceResponse>(req, "AttachNetworkInterface");
        }

        /// <summary>
        /// This API is used to bind an ENI to a CVM instance.
        /// </summary>
        /// <param name="req"><see cref="AttachNetworkInterfaceRequest"/></param>
        /// <returns><see cref="AttachNetworkInterfaceResponse"/></returns>
        public AttachNetworkInterfaceResponse AttachNetworkInterfaceSync(AttachNetworkInterfaceRequest req)
        {
            return InternalRequestAsync<AttachNetworkInterfaceResponse>(req, "AttachNetworkInterface")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch unbind real servers.
        /// </summary>
        /// <param name="req"><see cref="BatchDeregisterTargetsRequest"/></param>
        /// <returns><see cref="BatchDeregisterTargetsResponse"/></returns>
        public Task<BatchDeregisterTargetsResponse> BatchDeregisterTargets(BatchDeregisterTargetsRequest req)
        {
            return InternalRequestAsync<BatchDeregisterTargetsResponse>(req, "BatchDeregisterTargets");
        }

        /// <summary>
        /// This API is used to batch unbind real servers.
        /// </summary>
        /// <param name="req"><see cref="BatchDeregisterTargetsRequest"/></param>
        /// <returns><see cref="BatchDeregisterTargetsResponse"/></returns>
        public BatchDeregisterTargetsResponse BatchDeregisterTargetsSync(BatchDeregisterTargetsRequest req)
        {
            return InternalRequestAsync<BatchDeregisterTargetsResponse>(req, "BatchDeregisterTargets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch modify the forwarding weights of the real servers bound to a listener.
        /// </summary>
        /// <param name="req"><see cref="BatchModifyTargetWeightRequest"/></param>
        /// <returns><see cref="BatchModifyTargetWeightResponse"/></returns>
        public Task<BatchModifyTargetWeightResponse> BatchModifyTargetWeight(BatchModifyTargetWeightRequest req)
        {
            return InternalRequestAsync<BatchModifyTargetWeightResponse>(req, "BatchModifyTargetWeight");
        }

        /// <summary>
        /// This API is used to batch modify the forwarding weights of the real servers bound to a listener.
        /// </summary>
        /// <param name="req"><see cref="BatchModifyTargetWeightRequest"/></param>
        /// <returns><see cref="BatchModifyTargetWeightResponse"/></returns>
        public BatchModifyTargetWeightResponse BatchModifyTargetWeightSync(BatchModifyTargetWeightRequest req)
        {
            return InternalRequestAsync<BatchModifyTargetWeightResponse>(req, "BatchModifyTargetWeight")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch bind backend targets.
        /// </summary>
        /// <param name="req"><see cref="BatchRegisterTargetsRequest"/></param>
        /// <returns><see cref="BatchRegisterTargetsResponse"/></returns>
        public Task<BatchRegisterTargetsResponse> BatchRegisterTargets(BatchRegisterTargetsRequest req)
        {
            return InternalRequestAsync<BatchRegisterTargetsResponse>(req, "BatchRegisterTargets");
        }

        /// <summary>
        /// This API is used to batch bind backend targets.
        /// </summary>
        /// <param name="req"><see cref="BatchRegisterTargetsRequest"/></param>
        /// <returns><see cref="BatchRegisterTargetsResponse"/></returns>
        public BatchRegisterTargetsResponse BatchRegisterTargetsSync(BatchRegisterTargetsRequest req)
        {
            return InternalRequestAsync<BatchRegisterTargetsResponse>(req, "BatchRegisterTargets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an HAVIP.
        /// </summary>
        /// <param name="req"><see cref="CreateHaVipRequest"/></param>
        /// <returns><see cref="CreateHaVipResponse"/></returns>
        public Task<CreateHaVipResponse> CreateHaVip(CreateHaVipRequest req)
        {
            return InternalRequestAsync<CreateHaVipResponse>(req, "CreateHaVip");
        }

        /// <summary>
        /// This API is used to create an HAVIP.
        /// </summary>
        /// <param name="req"><see cref="CreateHaVipRequest"/></param>
        /// <returns><see cref="CreateHaVipResponse"/></returns>
        public CreateHaVipResponse CreateHaVipSync(CreateHaVipRequest req)
        {
            return InternalRequestAsync<CreateHaVipResponse>(req, "CreateHaVip")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an image with the system disk of an instance. The image can be used to create instances.
        /// </summary>
        /// <param name="req"><see cref="CreateImageRequest"/></param>
        /// <returns><see cref="CreateImageResponse"/></returns>
        public Task<CreateImageResponse> CreateImage(CreateImageRequest req)
        {
            return InternalRequestAsync<CreateImageResponse>(req, "CreateImage");
        }

        /// <summary>
        /// This API is used to create an image with the system disk of an instance. The image can be used to create instances.
        /// </summary>
        /// <param name="req"><see cref="CreateImageRequest"/></param>
        /// <returns><see cref="CreateImageResponse"/></returns>
        public CreateImageResponse CreateImageSync(CreateImageRequest req)
        {
            return InternalRequestAsync<CreateImageResponse>(req, "CreateImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an `OpenSSH RSA` key pair, which can be used to log in to a Linux instance.
        /// </summary>
        /// <param name="req"><see cref="CreateKeyPairRequest"/></param>
        /// <returns><see cref="CreateKeyPairResponse"/></returns>
        public Task<CreateKeyPairResponse> CreateKeyPair(CreateKeyPairRequest req)
        {
            return InternalRequestAsync<CreateKeyPairResponse>(req, "CreateKeyPair");
        }

        /// <summary>
        /// This API is used to create an `OpenSSH RSA` key pair, which can be used to log in to a Linux instance.
        /// </summary>
        /// <param name="req"><see cref="CreateKeyPairRequest"/></param>
        /// <returns><see cref="CreateKeyPairResponse"/></returns>
        public CreateKeyPairResponse CreateKeyPairSync(CreateKeyPairRequest req)
        {
            return InternalRequestAsync<CreateKeyPairResponse>(req, "CreateKeyPair")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a CLB listener.
        /// </summary>
        /// <param name="req"><see cref="CreateListenerRequest"/></param>
        /// <returns><see cref="CreateListenerResponse"/></returns>
        public Task<CreateListenerResponse> CreateListener(CreateListenerRequest req)
        {
            return InternalRequestAsync<CreateListenerResponse>(req, "CreateListener");
        }

        /// <summary>
        /// This API is used to create a CLB listener.
        /// </summary>
        /// <param name="req"><see cref="CreateListenerRequest"/></param>
        /// <returns><see cref="CreateListenerResponse"/></returns>
        public CreateListenerResponse CreateListenerSync(CreateListenerRequest req)
        {
            return InternalRequestAsync<CreateListenerResponse>(req, "CreateListener")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to purchase a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="CreateLoadBalancerRequest"/></param>
        /// <returns><see cref="CreateLoadBalancerResponse"/></returns>
        public Task<CreateLoadBalancerResponse> CreateLoadBalancer(CreateLoadBalancerRequest req)
        {
            return InternalRequestAsync<CreateLoadBalancerResponse>(req, "CreateLoadBalancer");
        }

        /// <summary>
        /// This API is used to purchase a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="CreateLoadBalancerRequest"/></param>
        /// <returns><see cref="CreateLoadBalancerResponse"/></returns>
        public CreateLoadBalancerResponse CreateLoadBalancerSync(CreateLoadBalancerRequest req)
        {
            return InternalRequestAsync<CreateLoadBalancerResponse>(req, "CreateLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a module.
        /// </summary>
        /// <param name="req"><see cref="CreateModuleRequest"/></param>
        /// <returns><see cref="CreateModuleResponse"/></returns>
        public Task<CreateModuleResponse> CreateModule(CreateModuleRequest req)
        {
            return InternalRequestAsync<CreateModuleResponse>(req, "CreateModule");
        }

        /// <summary>
        /// This API is used to create a module.
        /// </summary>
        /// <param name="req"><see cref="CreateModuleRequest"/></param>
        /// <returns><see cref="CreateModuleResponse"/></returns>
        public CreateModuleResponse CreateModuleSync(CreateModuleRequest req)
        {
            return InternalRequestAsync<CreateModuleResponse>(req, "CreateModule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an ENI.
        /// </summary>
        /// <param name="req"><see cref="CreateNetworkInterfaceRequest"/></param>
        /// <returns><see cref="CreateNetworkInterfaceResponse"/></returns>
        public Task<CreateNetworkInterfaceResponse> CreateNetworkInterface(CreateNetworkInterfaceRequest req)
        {
            return InternalRequestAsync<CreateNetworkInterfaceResponse>(req, "CreateNetworkInterface");
        }

        /// <summary>
        /// This API is used to create an ENI.
        /// </summary>
        /// <param name="req"><see cref="CreateNetworkInterfaceRequest"/></param>
        /// <returns><see cref="CreateNetworkInterfaceResponse"/></returns>
        public CreateNetworkInterfaceResponse CreateNetworkInterfaceSync(CreateNetworkInterfaceRequest req)
        {
            return InternalRequestAsync<CreateNetworkInterfaceResponse>(req, "CreateNetworkInterface")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// After a VPC is created, the system will create a default route table, with which all new subnets will be associated. By default, you can use the default route table to manage your routing policies. If you have multiple routing policies, you can call the API for route table creation to create more route tables to manage your routing policies.
        /// </summary>
        /// <param name="req"><see cref="CreateRouteTableRequest"/></param>
        /// <returns><see cref="CreateRouteTableResponse"/></returns>
        public Task<CreateRouteTableResponse> CreateRouteTable(CreateRouteTableRequest req)
        {
            return InternalRequestAsync<CreateRouteTableResponse>(req, "CreateRouteTable");
        }

        /// <summary>
        /// After a VPC is created, the system will create a default route table, with which all new subnets will be associated. By default, you can use the default route table to manage your routing policies. If you have multiple routing policies, you can call the API for route table creation to create more route tables to manage your routing policies.
        /// </summary>
        /// <param name="req"><see cref="CreateRouteTableRequest"/></param>
        /// <returns><see cref="CreateRouteTableResponse"/></returns>
        public CreateRouteTableResponse CreateRouteTableSync(CreateRouteTableRequest req)
        {
            return InternalRequestAsync<CreateRouteTableResponse>(req, "CreateRouteTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a routing policy.
        /// </summary>
        /// <param name="req"><see cref="CreateRoutesRequest"/></param>
        /// <returns><see cref="CreateRoutesResponse"/></returns>
        public Task<CreateRoutesResponse> CreateRoutes(CreateRoutesRequest req)
        {
            return InternalRequestAsync<CreateRoutesResponse>(req, "CreateRoutes");
        }

        /// <summary>
        /// This API is used to create a routing policy.
        /// </summary>
        /// <param name="req"><see cref="CreateRoutesRequest"/></param>
        /// <returns><see cref="CreateRoutesResponse"/></returns>
        public CreateRoutesResponse CreateRoutesSync(CreateRoutesRequest req)
        {
            return InternalRequestAsync<CreateRoutesResponse>(req, "CreateRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a security group.
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityGroupRequest"/></param>
        /// <returns><see cref="CreateSecurityGroupResponse"/></returns>
        public Task<CreateSecurityGroupResponse> CreateSecurityGroup(CreateSecurityGroupRequest req)
        {
            return InternalRequestAsync<CreateSecurityGroupResponse>(req, "CreateSecurityGroup");
        }

        /// <summary>
        /// This API is used to create a security group.
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityGroupRequest"/></param>
        /// <returns><see cref="CreateSecurityGroupResponse"/></returns>
        public CreateSecurityGroupResponse CreateSecurityGroupSync(CreateSecurityGroupRequest req)
        {
            return InternalRequestAsync<CreateSecurityGroupResponse>(req, "CreateSecurityGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        public Task<CreateSecurityGroupPoliciesResponse> CreateSecurityGroupPolicies(CreateSecurityGroupPoliciesRequest req)
        {
            return InternalRequestAsync<CreateSecurityGroupPoliciesResponse>(req, "CreateSecurityGroupPolicies");
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
            return InternalRequestAsync<CreateSecurityGroupPoliciesResponse>(req, "CreateSecurityGroupPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a subnet. After the subnet is created successfully, it will become the default subnet for the AZ.
        /// </summary>
        /// <param name="req"><see cref="CreateSubnetRequest"/></param>
        /// <returns><see cref="CreateSubnetResponse"/></returns>
        public Task<CreateSubnetResponse> CreateSubnet(CreateSubnetRequest req)
        {
            return InternalRequestAsync<CreateSubnetResponse>(req, "CreateSubnet");
        }

        /// <summary>
        /// This API is used to create a subnet. After the subnet is created successfully, it will become the default subnet for the AZ.
        /// </summary>
        /// <param name="req"><see cref="CreateSubnetRequest"/></param>
        /// <returns><see cref="CreateSubnetResponse"/></returns>
        public CreateSubnetResponse CreateSubnetSync(CreateSubnetRequest req)
        {
            return InternalRequestAsync<CreateSubnetResponse>(req, "CreateSubnet")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a VPC.
        /// </summary>
        /// <param name="req"><see cref="CreateVpcRequest"/></param>
        /// <returns><see cref="CreateVpcResponse"/></returns>
        public Task<CreateVpcResponse> CreateVpc(CreateVpcRequest req)
        {
            return InternalRequestAsync<CreateVpcResponse>(req, "CreateVpc");
        }

        /// <summary>
        /// This API is used to create a VPC.
        /// </summary>
        /// <param name="req"><see cref="CreateVpcRequest"/></param>
        /// <returns><see cref="CreateVpcResponse"/></returns>
        public CreateVpcResponse CreateVpcSync(CreateVpcRequest req)
        {
            return InternalRequestAsync<CreateVpcResponse>(req, "CreateVpc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an HAVIP.
        /// </summary>
        /// <param name="req"><see cref="DeleteHaVipRequest"/></param>
        /// <returns><see cref="DeleteHaVipResponse"/></returns>
        public Task<DeleteHaVipResponse> DeleteHaVip(DeleteHaVipRequest req)
        {
            return InternalRequestAsync<DeleteHaVipResponse>(req, "DeleteHaVip");
        }

        /// <summary>
        /// This API is used to delete an HAVIP.
        /// </summary>
        /// <param name="req"><see cref="DeleteHaVipRequest"/></param>
        /// <returns><see cref="DeleteHaVipResponse"/></returns>
        public DeleteHaVipResponse DeleteHaVipSync(DeleteHaVipRequest req)
        {
            return InternalRequestAsync<DeleteHaVipResponse>(req, "DeleteHaVip")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an image.
        /// </summary>
        /// <param name="req"><see cref="DeleteImageRequest"/></param>
        /// <returns><see cref="DeleteImageResponse"/></returns>
        public Task<DeleteImageResponse> DeleteImage(DeleteImageRequest req)
        {
            return InternalRequestAsync<DeleteImageResponse>(req, "DeleteImage");
        }

        /// <summary>
        /// This API is used to delete an image.
        /// </summary>
        /// <param name="req"><see cref="DeleteImageRequest"/></param>
        /// <returns><see cref="DeleteImageResponse"/></returns>
        public DeleteImageResponse DeleteImageSync(DeleteImageRequest req)
        {
            return InternalRequestAsync<DeleteImageResponse>(req, "DeleteImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a CLB listener.
        /// </summary>
        /// <param name="req"><see cref="DeleteListenerRequest"/></param>
        /// <returns><see cref="DeleteListenerResponse"/></returns>
        public Task<DeleteListenerResponse> DeleteListener(DeleteListenerRequest req)
        {
            return InternalRequestAsync<DeleteListenerResponse>(req, "DeleteListener");
        }

        /// <summary>
        /// This API is used to delete a CLB listener.
        /// </summary>
        /// <param name="req"><see cref="DeleteListenerRequest"/></param>
        /// <returns><see cref="DeleteListenerResponse"/></returns>
        public DeleteListenerResponse DeleteListenerSync(DeleteListenerRequest req)
        {
            return InternalRequestAsync<DeleteListenerResponse>(req, "DeleteListener")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerResponse"/></returns>
        public Task<DeleteLoadBalancerResponse> DeleteLoadBalancer(DeleteLoadBalancerRequest req)
        {
            return InternalRequestAsync<DeleteLoadBalancerResponse>(req, "DeleteLoadBalancer");
        }

        /// <summary>
        /// This API is used to delete a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerResponse"/></returns>
        public DeleteLoadBalancerResponse DeleteLoadBalancerSync(DeleteLoadBalancerRequest req)
        {
            return InternalRequestAsync<DeleteLoadBalancerResponse>(req, "DeleteLoadBalancer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete multiple CLB listeners.
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerListenersRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerListenersResponse"/></returns>
        public Task<DeleteLoadBalancerListenersResponse> DeleteLoadBalancerListeners(DeleteLoadBalancerListenersRequest req)
        {
            return InternalRequestAsync<DeleteLoadBalancerListenersResponse>(req, "DeleteLoadBalancerListeners");
        }

        /// <summary>
        /// This API is used to delete multiple CLB listeners.
        /// </summary>
        /// <param name="req"><see cref="DeleteLoadBalancerListenersRequest"/></param>
        /// <returns><see cref="DeleteLoadBalancerListenersResponse"/></returns>
        public DeleteLoadBalancerListenersResponse DeleteLoadBalancerListenersSync(DeleteLoadBalancerListenersRequest req)
        {
            return InternalRequestAsync<DeleteLoadBalancerListenersResponse>(req, "DeleteLoadBalancerListeners")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a business module.
        /// </summary>
        /// <param name="req"><see cref="DeleteModuleRequest"/></param>
        /// <returns><see cref="DeleteModuleResponse"/></returns>
        public Task<DeleteModuleResponse> DeleteModule(DeleteModuleRequest req)
        {
            return InternalRequestAsync<DeleteModuleResponse>(req, "DeleteModule");
        }

        /// <summary>
        /// This API is used to delete a business module.
        /// </summary>
        /// <param name="req"><see cref="DeleteModuleRequest"/></param>
        /// <returns><see cref="DeleteModuleResponse"/></returns>
        public DeleteModuleResponse DeleteModuleSync(DeleteModuleRequest req)
        {
            return InternalRequestAsync<DeleteModuleResponse>(req, "DeleteModule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an ENI.
        /// </summary>
        /// <param name="req"><see cref="DeleteNetworkInterfaceRequest"/></param>
        /// <returns><see cref="DeleteNetworkInterfaceResponse"/></returns>
        public Task<DeleteNetworkInterfaceResponse> DeleteNetworkInterface(DeleteNetworkInterfaceRequest req)
        {
            return InternalRequestAsync<DeleteNetworkInterfaceResponse>(req, "DeleteNetworkInterface");
        }

        /// <summary>
        /// This API is used to delete an ENI.
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
        /// This API is used to batch delete routing policies from a route table.
        /// </summary>
        /// <param name="req"><see cref="DeleteRoutesRequest"/></param>
        /// <returns><see cref="DeleteRoutesResponse"/></returns>
        public Task<DeleteRoutesResponse> DeleteRoutes(DeleteRoutesRequest req)
        {
            return InternalRequestAsync<DeleteRoutesResponse>(req, "DeleteRoutes");
        }

        /// <summary>
        /// This API is used to batch delete routing policies from a route table.
        /// </summary>
        /// <param name="req"><see cref="DeleteRoutesRequest"/></param>
        /// <returns><see cref="DeleteRoutesResponse"/></returns>
        public DeleteRoutesResponse DeleteRoutesSync(DeleteRoutesRequest req)
        {
            return InternalRequestAsync<DeleteRoutesResponse>(req, "DeleteRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Only security groups under the current account can be deleted.
        /// A security group cannot be deleted directly if its instance ID is used in the policy of another security group. In this case, you need to modify the policy first before deleting the security group.
        /// Deleted security groups cannot be recovered. Therefore, call this API with caution.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityGroupRequest"/></param>
        /// <returns><see cref="DeleteSecurityGroupResponse"/></returns>
        public Task<DeleteSecurityGroupResponse> DeleteSecurityGroup(DeleteSecurityGroupRequest req)
        {
            return InternalRequestAsync<DeleteSecurityGroupResponse>(req, "DeleteSecurityGroup");
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
            return InternalRequestAsync<DeleteSecurityGroupResponse>(req, "DeleteSecurityGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// `SecurityGroupPolicySet.Version` is used to specify the version of the security group to be manipulated. If the `Version` value passed in differs from the current latest version of the security group, a failure will be returned. If `Version` is not passed in, the policy of the specified `PolicyIndex` will be deleted directly.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityGroupPoliciesRequest"/></param>
        /// <returns><see cref="DeleteSecurityGroupPoliciesResponse"/></returns>
        public Task<DeleteSecurityGroupPoliciesResponse> DeleteSecurityGroupPolicies(DeleteSecurityGroupPoliciesRequest req)
        {
            return InternalRequestAsync<DeleteSecurityGroupPoliciesResponse>(req, "DeleteSecurityGroupPolicies");
        }

        /// <summary>
        /// `SecurityGroupPolicySet.Version` is used to specify the version of the security group to be manipulated. If the `Version` value passed in differs from the current latest version of the security group, a failure will be returned. If `Version` is not passed in, the policy of the specified `PolicyIndex` will be deleted directly.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityGroupPoliciesRequest"/></param>
        /// <returns><see cref="DeleteSecurityGroupPoliciesResponse"/></returns>
        public DeleteSecurityGroupPoliciesResponse DeleteSecurityGroupPoliciesSync(DeleteSecurityGroupPoliciesRequest req)
        {
            return InternalRequestAsync<DeleteSecurityGroupPoliciesResponse>(req, "DeleteSecurityGroupPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a snapshot.
        /// 
        /// * Only snapshots in the `NORMAL` state can be deleted. To query the state of a snapshot, you can call the [DescribeSnapshots](https://intl.cloud.tencent.com/document/product/362/15647?from_cn_redirect=1) API and check the `SnapshotState` field in the response.
        /// * Batch operations are supported. If there is any snapshot that cannot be deleted, the operation will not be performed and a specific error code will be returned.
        /// </summary>
        /// <param name="req"><see cref="DeleteSnapshotsRequest"/></param>
        /// <returns><see cref="DeleteSnapshotsResponse"/></returns>
        public Task<DeleteSnapshotsResponse> DeleteSnapshots(DeleteSnapshotsRequest req)
        {
            return InternalRequestAsync<DeleteSnapshotsResponse>(req, "DeleteSnapshots");
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
            return InternalRequestAsync<DeleteSnapshotsResponse>(req, "DeleteSnapshots")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a subnet. If the subnet is the current default subnet in the AZ, after it is deleted, the default subnet automatically created by the system rather than the last subnet created by you will be used as the new default subnet. If the new default subnet does not meet your needs, you can call the API for setting the default subnet to configure it.
        /// </summary>
        /// <param name="req"><see cref="DeleteSubnetRequest"/></param>
        /// <returns><see cref="DeleteSubnetResponse"/></returns>
        public Task<DeleteSubnetResponse> DeleteSubnet(DeleteSubnetRequest req)
        {
            return InternalRequestAsync<DeleteSubnetResponse>(req, "DeleteSubnet");
        }

        /// <summary>
        /// This API is used to delete a subnet. If the subnet is the current default subnet in the AZ, after it is deleted, the default subnet automatically created by the system rather than the last subnet created by you will be used as the new default subnet. If the new default subnet does not meet your needs, you can call the API for setting the default subnet to configure it.
        /// </summary>
        /// <param name="req"><see cref="DeleteSubnetRequest"/></param>
        /// <returns><see cref="DeleteSubnetResponse"/></returns>
        public DeleteSubnetResponse DeleteSubnetSync(DeleteSubnetRequest req)
        {
            return InternalRequestAsync<DeleteSubnetResponse>(req, "DeleteSubnet")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a VPC.
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcRequest"/></param>
        /// <returns><see cref="DeleteVpcResponse"/></returns>
        public Task<DeleteVpcResponse> DeleteVpc(DeleteVpcRequest req)
        {
            return InternalRequestAsync<DeleteVpcResponse>(req, "DeleteVpc");
        }

        /// <summary>
        /// This API is used to delete a VPC.
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcRequest"/></param>
        /// <returns><see cref="DeleteVpcResponse"/></returns>
        public DeleteVpcResponse DeleteVpcSync(DeleteVpcRequest req)
        {
            return InternalRequestAsync<DeleteVpcResponse>(req, "DeleteVpc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the quota information of the EIP under your account in the current region.
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressQuotaRequest"/></param>
        /// <returns><see cref="DescribeAddressQuotaResponse"/></returns>
        public Task<DescribeAddressQuotaResponse> DescribeAddressQuota(DescribeAddressQuotaRequest req)
        {
            return InternalRequestAsync<DescribeAddressQuotaResponse>(req, "DescribeAddressQuota");
        }

        /// <summary>
        /// This API is used to query the quota information of the EIP under your account in the current region.
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressQuotaRequest"/></param>
        /// <returns><see cref="DescribeAddressQuotaResponse"/></returns>
        public DescribeAddressQuotaResponse DescribeAddressQuotaSync(DescribeAddressQuotaRequest req)
        {
            return InternalRequestAsync<DescribeAddressQuotaResponse>(req, "DescribeAddressQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of EIPs.
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressesRequest"/></param>
        /// <returns><see cref="DescribeAddressesResponse"/></returns>
        public Task<DescribeAddressesResponse> DescribeAddresses(DescribeAddressesRequest req)
        {
            return InternalRequestAsync<DescribeAddressesResponse>(req, "DescribeAddresses");
        }

        /// <summary>
        /// This API is used to query the list of EIPs.
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressesRequest"/></param>
        /// <returns><see cref="DescribeAddressesResponse"/></returns>
        public DescribeAddressesResponse DescribeAddressesSync(DescribeAddressesRequest req)
        {
            return InternalRequestAsync<DescribeAddressesResponse>(req, "DescribeAddresses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the basic data displayed on the overview page.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaseOverviewRequest"/></param>
        /// <returns><see cref="DescribeBaseOverviewResponse"/></returns>
        public Task<DescribeBaseOverviewResponse> DescribeBaseOverview(DescribeBaseOverviewRequest req)
        {
            return InternalRequestAsync<DescribeBaseOverviewResponse>(req, "DescribeBaseOverview");
        }

        /// <summary>
        /// This API is used to get the basic data displayed on the overview page.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaseOverviewRequest"/></param>
        /// <returns><see cref="DescribeBaseOverviewResponse"/></returns>
        public DescribeBaseOverviewResponse DescribeBaseOverviewSync(DescribeBaseOverviewRequest req)
        {
            return InternalRequestAsync<DescribeBaseOverviewResponse>(req, "DescribeBaseOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the limits of data such as bandwidth and disk.
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigRequest"/></param>
        /// <returns><see cref="DescribeConfigResponse"/></returns>
        public Task<DescribeConfigResponse> DescribeConfig(DescribeConfigRequest req)
        {
            return InternalRequestAsync<DescribeConfigResponse>(req, "DescribeConfig");
        }

        /// <summary>
        /// This API is used to get the limits of data such as bandwidth and disk.
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigRequest"/></param>
        /// <returns><see cref="DescribeConfigResponse"/></returns>
        public DescribeConfigResponse DescribeConfigSync(DescribeConfigRequest req)
        {
            return InternalRequestAsync<DescribeConfigResponse>(req, "DescribeConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query an image import task.
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomImageTaskRequest"/></param>
        /// <returns><see cref="DescribeCustomImageTaskResponse"/></returns>
        public Task<DescribeCustomImageTaskResponse> DescribeCustomImageTask(DescribeCustomImageTaskRequest req)
        {
            return InternalRequestAsync<DescribeCustomImageTaskResponse>(req, "DescribeCustomImageTask");
        }

        /// <summary>
        /// This API is used to query an image import task.
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomImageTaskRequest"/></param>
        /// <returns><see cref="DescribeCustomImageTaskResponse"/></returns>
        public DescribeCustomImageTaskResponse DescribeCustomImageTaskSync(DescribeCustomImageTaskRequest req)
        {
            return InternalRequestAsync<DescribeCustomImageTaskResponse>(req, "DescribeCustomImageTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the default subnet in an AZ.
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultSubnetRequest"/></param>
        /// <returns><see cref="DescribeDefaultSubnetResponse"/></returns>
        public Task<DescribeDefaultSubnetResponse> DescribeDefaultSubnet(DescribeDefaultSubnetRequest req)
        {
            return InternalRequestAsync<DescribeDefaultSubnetResponse>(req, "DescribeDefaultSubnet");
        }

        /// <summary>
        /// This API is used to query the default subnet in an AZ.
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultSubnetRequest"/></param>
        /// <returns><see cref="DescribeDefaultSubnetResponse"/></returns>
        public DescribeDefaultSubnetResponse DescribeDefaultSubnetSync(DescribeDefaultSubnetRequest req)
        {
            return InternalRequestAsync<DescribeDefaultSubnetResponse>(req, "DescribeDefaultSubnet")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of HAVIPs.
        /// </summary>
        /// <param name="req"><see cref="DescribeHaVipsRequest"/></param>
        /// <returns><see cref="DescribeHaVipsResponse"/></returns>
        public Task<DescribeHaVipsResponse> DescribeHaVips(DescribeHaVipsRequest req)
        {
            return InternalRequestAsync<DescribeHaVipsResponse>(req, "DescribeHaVips");
        }

        /// <summary>
        /// This API is used to query the list of HAVIPs.
        /// </summary>
        /// <param name="req"><see cref="DescribeHaVipsRequest"/></param>
        /// <returns><see cref="DescribeHaVipsResponse"/></returns>
        public DescribeHaVipsResponse DescribeHaVipsSync(DescribeHaVipsRequest req)
        {
            return InternalRequestAsync<DescribeHaVipsResponse>(req, "DescribeHaVips")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to display the list of images.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRequest"/></param>
        /// <returns><see cref="DescribeImageResponse"/></returns>
        public Task<DescribeImageResponse> DescribeImage(DescribeImageRequest req)
        {
            return InternalRequestAsync<DescribeImageResponse>(req, "DescribeImage");
        }

        /// <summary>
        /// This API is used to display the list of images.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRequest"/></param>
        /// <returns><see cref="DescribeImageResponse"/></returns>
        public DescribeImageResponse DescribeImageSync(DescribeImageRequest req)
        {
            return InternalRequestAsync<DescribeImageResponse>(req, "DescribeImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of operating systems supported by an image imported from an external resource.
        /// </summary>
        /// <param name="req"><see cref="DescribeImportImageOsRequest"/></param>
        /// <returns><see cref="DescribeImportImageOsResponse"/></returns>
        public Task<DescribeImportImageOsResponse> DescribeImportImageOs(DescribeImportImageOsRequest req)
        {
            return InternalRequestAsync<DescribeImportImageOsResponse>(req, "DescribeImportImageOs");
        }

        /// <summary>
        /// This API is used to query the list of operating systems supported by an image imported from an external resource.
        /// </summary>
        /// <param name="req"><see cref="DescribeImportImageOsRequest"/></param>
        /// <returns><see cref="DescribeImportImageOsResponse"/></returns>
        public DescribeImportImageOsResponse DescribeImportImageOsSync(DescribeImportImageOsRequest req)
        {
            return InternalRequestAsync<DescribeImportImageOsResponse>(req, "DescribeImportImageOs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of model configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceTypeConfigRequest"/></param>
        /// <returns><see cref="DescribeInstanceTypeConfigResponse"/></returns>
        public Task<DescribeInstanceTypeConfigResponse> DescribeInstanceTypeConfig(DescribeInstanceTypeConfigRequest req)
        {
            return InternalRequestAsync<DescribeInstanceTypeConfigResponse>(req, "DescribeInstanceTypeConfig");
        }

        /// <summary>
        /// This API is used to get the list of model configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceTypeConfigRequest"/></param>
        /// <returns><see cref="DescribeInstanceTypeConfigResponse"/></returns>
        public DescribeInstanceTypeConfigResponse DescribeInstanceTypeConfigSync(DescribeInstanceTypeConfigRequest req)
        {
            return InternalRequestAsync<DescribeInstanceTypeConfigResponse>(req, "DescribeInstanceTypeConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the VNC URL of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceVncUrlRequest"/></param>
        /// <returns><see cref="DescribeInstanceVncUrlResponse"/></returns>
        public Task<DescribeInstanceVncUrlResponse> DescribeInstanceVncUrl(DescribeInstanceVncUrlRequest req)
        {
            return InternalRequestAsync<DescribeInstanceVncUrlResponse>(req, "DescribeInstanceVncUrl");
        }

        /// <summary>
        /// This API is used to query the VNC URL of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceVncUrlRequest"/></param>
        /// <returns><see cref="DescribeInstanceVncUrlResponse"/></returns>
        public DescribeInstanceVncUrlResponse DescribeInstanceVncUrlSync(DescribeInstanceVncUrlRequest req)
        {
            return InternalRequestAsync<DescribeInstanceVncUrlResponse>(req, "DescribeInstanceVncUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the information of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances");
        }

        /// <summary>
        /// This API is used to get the information of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the information of prohibited operations by instance ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeInstancesDeniedActionsResponse"/></returns>
        public Task<DescribeInstancesDeniedActionsResponse> DescribeInstancesDeniedActions(DescribeInstancesDeniedActionsRequest req)
        {
            return InternalRequestAsync<DescribeInstancesDeniedActionsResponse>(req, "DescribeInstancesDeniedActions");
        }

        /// <summary>
        /// This API is used to get the information of prohibited operations by instance ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesDeniedActionsRequest"/></param>
        /// <returns><see cref="DescribeInstancesDeniedActionsResponse"/></returns>
        public DescribeInstancesDeniedActionsResponse DescribeInstancesDeniedActionsSync(DescribeInstancesDeniedActionsRequest req)
        {
            return InternalRequestAsync<DescribeInstancesDeniedActionsResponse>(req, "DescribeInstancesDeniedActions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of CLB listeners.
        /// </summary>
        /// <param name="req"><see cref="DescribeListenersRequest"/></param>
        /// <returns><see cref="DescribeListenersResponse"/></returns>
        public Task<DescribeListenersResponse> DescribeListeners(DescribeListenersRequest req)
        {
            return InternalRequestAsync<DescribeListenersResponse>(req, "DescribeListeners");
        }

        /// <summary>
        /// This API is used to query the list of CLB listeners.
        /// </summary>
        /// <param name="req"><see cref="DescribeListenersRequest"/></param>
        /// <returns><see cref="DescribeListenersResponse"/></returns>
        public DescribeListenersResponse DescribeListenersSync(DescribeListenersRequest req)
        {
            return InternalRequestAsync<DescribeListenersResponse>(req, "DescribeListeners")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the task status of a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalanceTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeLoadBalanceTaskStatusResponse"/></returns>
        public Task<DescribeLoadBalanceTaskStatusResponse> DescribeLoadBalanceTaskStatus(DescribeLoadBalanceTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalanceTaskStatusResponse>(req, "DescribeLoadBalanceTaskStatus");
        }

        /// <summary>
        /// This API is used to query the task status of a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalanceTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeLoadBalanceTaskStatusResponse"/></returns>
        public DescribeLoadBalanceTaskStatusResponse DescribeLoadBalanceTaskStatusSync(DescribeLoadBalanceTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalanceTaskStatusResponse>(req, "DescribeLoadBalanceTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of CLB instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancersRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancersResponse"/></returns>
        public Task<DescribeLoadBalancersResponse> DescribeLoadBalancers(DescribeLoadBalancersRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancersResponse>(req, "DescribeLoadBalancers");
        }

        /// <summary>
        /// This API is used to query the list of CLB instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeLoadBalancersRequest"/></param>
        /// <returns><see cref="DescribeLoadBalancersResponse"/></returns>
        public DescribeLoadBalancersResponse DescribeLoadBalancersSync(DescribeLoadBalancersRequest req)
        {
            return InternalRequestAsync<DescribeLoadBalancersResponse>(req, "DescribeLoadBalancers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of modules.
        /// </summary>
        /// <param name="req"><see cref="DescribeModuleRequest"/></param>
        /// <returns><see cref="DescribeModuleResponse"/></returns>
        public Task<DescribeModuleResponse> DescribeModule(DescribeModuleRequest req)
        {
            return InternalRequestAsync<DescribeModuleResponse>(req, "DescribeModule");
        }

        /// <summary>
        /// This API is used to get the list of modules.
        /// </summary>
        /// <param name="req"><see cref="DescribeModuleRequest"/></param>
        /// <returns><see cref="DescribeModuleResponse"/></returns>
        public DescribeModuleResponse DescribeModuleSync(DescribeModuleRequest req)
        {
            return InternalRequestAsync<DescribeModuleResponse>(req, "DescribeModule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to display the details of a module.
        /// </summary>
        /// <param name="req"><see cref="DescribeModuleDetailRequest"/></param>
        /// <returns><see cref="DescribeModuleDetailResponse"/></returns>
        public Task<DescribeModuleDetailResponse> DescribeModuleDetail(DescribeModuleDetailRequest req)
        {
            return InternalRequestAsync<DescribeModuleDetailResponse>(req, "DescribeModuleDetail");
        }

        /// <summary>
        /// This API is used to display the details of a module.
        /// </summary>
        /// <param name="req"><see cref="DescribeModuleDetailRequest"/></param>
        /// <returns><see cref="DescribeModuleDetailResponse"/></returns>
        public DescribeModuleDetailResponse DescribeModuleDetailSync(DescribeModuleDetailRequest req)
        {
            return InternalRequestAsync<DescribeModuleDetailResponse>(req, "DescribeModuleDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the monthly peak and billable inbound/outbound bandwidth values of your node.
        /// </summary>
        /// <param name="req"><see cref="DescribeMonthPeakNetworkRequest"/></param>
        /// <returns><see cref="DescribeMonthPeakNetworkResponse"/></returns>
        public Task<DescribeMonthPeakNetworkResponse> DescribeMonthPeakNetwork(DescribeMonthPeakNetworkRequest req)
        {
            return InternalRequestAsync<DescribeMonthPeakNetworkResponse>(req, "DescribeMonthPeakNetwork");
        }

        /// <summary>
        /// This API is used to get the monthly peak and billable inbound/outbound bandwidth values of your node.
        /// </summary>
        /// <param name="req"><see cref="DescribeMonthPeakNetworkRequest"/></param>
        /// <returns><see cref="DescribeMonthPeakNetworkResponse"/></returns>
        public DescribeMonthPeakNetworkResponse DescribeMonthPeakNetworkSync(DescribeMonthPeakNetworkRequest req)
        {
            return InternalRequestAsync<DescribeMonthPeakNetworkResponse>(req, "DescribeMonthPeakNetwork")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of ENIs.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkInterfacesRequest"/></param>
        /// <returns><see cref="DescribeNetworkInterfacesResponse"/></returns>
        public Task<DescribeNetworkInterfacesResponse> DescribeNetworkInterfaces(DescribeNetworkInterfacesRequest req)
        {
            return InternalRequestAsync<DescribeNetworkInterfacesResponse>(req, "DescribeNetworkInterfaces");
        }

        /// <summary>
        /// This API is used to query the list of ENIs.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkInterfacesRequest"/></param>
        /// <returns><see cref="DescribeNetworkInterfacesResponse"/></returns>
        public DescribeNetworkInterfacesResponse DescribeNetworkInterfacesSync(DescribeNetworkInterfacesRequest req)
        {
            return InternalRequestAsync<DescribeNetworkInterfacesResponse>(req, "DescribeNetworkInterfaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of nodes.
        /// </summary>
        /// <param name="req"><see cref="DescribeNodeRequest"/></param>
        /// <returns><see cref="DescribeNodeResponse"/></returns>
        public Task<DescribeNodeResponse> DescribeNode(DescribeNodeRequest req)
        {
            return InternalRequestAsync<DescribeNodeResponse>(req, "DescribeNode");
        }

        /// <summary>
        /// This API is used to get the list of nodes.
        /// </summary>
        /// <param name="req"><see cref="DescribeNodeRequest"/></param>
        /// <returns><see cref="DescribeNodeResponse"/></returns>
        public DescribeNodeResponse DescribeNodeSync(DescribeNodeRequest req)
        {
            return InternalRequestAsync<DescribeNodeResponse>(req, "DescribeNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the packing quota of a model in a region (when a virtual model is used, a set of correlated packing quotas will be returned).
        /// </summary>
        /// <param name="req"><see cref="DescribePackingQuotaGroupRequest"/></param>
        /// <returns><see cref="DescribePackingQuotaGroupResponse"/></returns>
        public Task<DescribePackingQuotaGroupResponse> DescribePackingQuotaGroup(DescribePackingQuotaGroupRequest req)
        {
            return InternalRequestAsync<DescribePackingQuotaGroupResponse>(req, "DescribePackingQuotaGroup");
        }

        /// <summary>
        /// This API is used to get the packing quota of a model in a region (when a virtual model is used, a set of correlated packing quotas will be returned).
        /// </summary>
        /// <param name="req"><see cref="DescribePackingQuotaGroupRequest"/></param>
        /// <returns><see cref="DescribePackingQuotaGroupResponse"/></returns>
        public DescribePackingQuotaGroupResponse DescribePackingQuotaGroupSync(DescribePackingQuotaGroupRequest req)
        {
            return InternalRequestAsync<DescribePackingQuotaGroupResponse>(req, "DescribePackingQuotaGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the peak data of basic information such as CPU, memory, and disk.
        /// </summary>
        /// <param name="req"><see cref="DescribePeakBaseOverviewRequest"/></param>
        /// <returns><see cref="DescribePeakBaseOverviewResponse"/></returns>
        public Task<DescribePeakBaseOverviewResponse> DescribePeakBaseOverview(DescribePeakBaseOverviewRequest req)
        {
            return InternalRequestAsync<DescribePeakBaseOverviewResponse>(req, "DescribePeakBaseOverview");
        }

        /// <summary>
        /// This API is used to get the peak data of basic information such as CPU, memory, and disk.
        /// </summary>
        /// <param name="req"><see cref="DescribePeakBaseOverviewRequest"/></param>
        /// <returns><see cref="DescribePeakBaseOverviewResponse"/></returns>
        public DescribePeakBaseOverviewResponse DescribePeakBaseOverviewSync(DescribePeakBaseOverviewRequest req)
        {
            return InternalRequestAsync<DescribePeakBaseOverviewResponse>(req, "DescribePeakBaseOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the peak network data.
        /// </summary>
        /// <param name="req"><see cref="DescribePeakNetworkOverviewRequest"/></param>
        /// <returns><see cref="DescribePeakNetworkOverviewResponse"/></returns>
        public Task<DescribePeakNetworkOverviewResponse> DescribePeakNetworkOverview(DescribePeakNetworkOverviewRequest req)
        {
            return InternalRequestAsync<DescribePeakNetworkOverviewResponse>(req, "DescribePeakNetworkOverview");
        }

        /// <summary>
        /// This API is used to get the peak network data.
        /// </summary>
        /// <param name="req"><see cref="DescribePeakNetworkOverviewRequest"/></param>
        /// <returns><see cref="DescribePeakNetworkOverviewResponse"/></returns>
        public DescribePeakNetworkOverviewResponse DescribePeakNetworkOverviewSync(DescribePeakNetworkOverviewRequest req)
        {
            return InternalRequestAsync<DescribePeakNetworkOverviewResponse>(req, "DescribePeakNetworkOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the price of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribePriceRunInstanceRequest"/></param>
        /// <returns><see cref="DescribePriceRunInstanceResponse"/></returns>
        public Task<DescribePriceRunInstanceResponse> DescribePriceRunInstance(DescribePriceRunInstanceRequest req)
        {
            return InternalRequestAsync<DescribePriceRunInstanceResponse>(req, "DescribePriceRunInstance");
        }

        /// <summary>
        /// This API is used to query the price of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribePriceRunInstanceRequest"/></param>
        /// <returns><see cref="DescribePriceRunInstanceResponse"/></returns>
        public DescribePriceRunInstanceResponse DescribePriceRunInstanceSync(DescribePriceRunInstanceRequest req)
        {
            return InternalRequestAsync<DescribePriceRunInstanceResponse>(req, "DescribePriceRunInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of conflicts between a custom routing policy and a CCN routing policy.
        /// </summary>
        /// <param name="req"><see cref="DescribeRouteConflictsRequest"/></param>
        /// <returns><see cref="DescribeRouteConflictsResponse"/></returns>
        public Task<DescribeRouteConflictsResponse> DescribeRouteConflicts(DescribeRouteConflictsRequest req)
        {
            return InternalRequestAsync<DescribeRouteConflictsResponse>(req, "DescribeRouteConflicts");
        }

        /// <summary>
        /// This API is used to query the list of conflicts between a custom routing policy and a CCN routing policy.
        /// </summary>
        /// <param name="req"><see cref="DescribeRouteConflictsRequest"/></param>
        /// <returns><see cref="DescribeRouteConflictsResponse"/></returns>
        public DescribeRouteConflictsResponse DescribeRouteConflictsSync(DescribeRouteConflictsRequest req)
        {
            return InternalRequestAsync<DescribeRouteConflictsResponse>(req, "DescribeRouteConflicts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of the objects in a route table.
        /// </summary>
        /// <param name="req"><see cref="DescribeRouteTablesRequest"/></param>
        /// <returns><see cref="DescribeRouteTablesResponse"/></returns>
        public Task<DescribeRouteTablesResponse> DescribeRouteTables(DescribeRouteTablesRequest req)
        {
            return InternalRequestAsync<DescribeRouteTablesResponse>(req, "DescribeRouteTables");
        }

        /// <summary>
        /// This API is used to query the list of the objects in a route table.
        /// </summary>
        /// <param name="req"><see cref="DescribeRouteTablesRequest"/></param>
        /// <returns><see cref="DescribeRouteTablesResponse"/></returns>
        public DescribeRouteTablesResponse DescribeRouteTablesSync(DescribeRouteTablesRequest req)
        {
            return InternalRequestAsync<DescribeRouteTablesResponse>(req, "DescribeRouteTables")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query statistics on the instances associated with a security group.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupAssociationStatisticsRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupAssociationStatisticsResponse"/></returns>
        public Task<DescribeSecurityGroupAssociationStatisticsResponse> DescribeSecurityGroupAssociationStatistics(DescribeSecurityGroupAssociationStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupAssociationStatisticsResponse>(req, "DescribeSecurityGroupAssociationStatistics");
        }

        /// <summary>
        /// This API is used to query statistics on the instances associated with a security group.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupAssociationStatisticsRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupAssociationStatisticsResponse"/></returns>
        public DescribeSecurityGroupAssociationStatisticsResponse DescribeSecurityGroupAssociationStatisticsSync(DescribeSecurityGroupAssociationStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupAssociationStatisticsResponse>(req, "DescribeSecurityGroupAssociationStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the security group quota.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupLimitsRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupLimitsResponse"/></returns>
        public Task<DescribeSecurityGroupLimitsResponse> DescribeSecurityGroupLimits(DescribeSecurityGroupLimitsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupLimitsResponse>(req, "DescribeSecurityGroupLimits");
        }

        /// <summary>
        /// This API is used to query the security group quota.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupLimitsRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupLimitsResponse"/></returns>
        public DescribeSecurityGroupLimitsResponse DescribeSecurityGroupLimitsSync(DescribeSecurityGroupLimitsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupLimitsResponse>(req, "DescribeSecurityGroupLimits")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query a security group rule.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupPoliciesRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupPoliciesResponse"/></returns>
        public Task<DescribeSecurityGroupPoliciesResponse> DescribeSecurityGroupPolicies(DescribeSecurityGroupPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupPoliciesResponse>(req, "DescribeSecurityGroupPolicies");
        }

        /// <summary>
        /// This API is used to query a security group rule.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupPoliciesRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupPoliciesResponse"/></returns>
        public DescribeSecurityGroupPoliciesResponse DescribeSecurityGroupPoliciesSync(DescribeSecurityGroupPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupPoliciesResponse>(req, "DescribeSecurityGroupPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to view a security group.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupsResponse"/></returns>
        public Task<DescribeSecurityGroupsResponse> DescribeSecurityGroups(DescribeSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupsResponse>(req, "DescribeSecurityGroups");
        }

        /// <summary>
        /// This API is used to view a security group.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupsResponse"/></returns>
        public DescribeSecurityGroupsResponse DescribeSecurityGroupsSync(DescribeSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupsResponse>(req, "DescribeSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of snapshots.
        /// 
        /// * You can filter results by snapshot ID and the ID and type of the cloud disk for which the snapshot is created. The relationship between different filters is `AND`. For more information on filters, see `Filter`.
        /// * If no parameter is defined, the status of a certain number of snapshots under the current account will be returned. The number is specified by `Limit` and is 20 by default.
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotsRequest"/></param>
        /// <returns><see cref="DescribeSnapshotsResponse"/></returns>
        public Task<DescribeSnapshotsResponse> DescribeSnapshots(DescribeSnapshotsRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotsResponse>(req, "DescribeSnapshots");
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
            return InternalRequestAsync<DescribeSnapshotsResponse>(req, "DescribeSnapshots")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of subnets.
        /// </summary>
        /// <param name="req"><see cref="DescribeSubnetsRequest"/></param>
        /// <returns><see cref="DescribeSubnetsResponse"/></returns>
        public Task<DescribeSubnetsResponse> DescribeSubnets(DescribeSubnetsRequest req)
        {
            return InternalRequestAsync<DescribeSubnetsResponse>(req, "DescribeSubnets");
        }

        /// <summary>
        /// This API is used to query the list of subnets.
        /// </summary>
        /// <param name="req"><see cref="DescribeSubnetsRequest"/></param>
        /// <returns><see cref="DescribeSubnetsResponse"/></returns>
        public DescribeSubnetsResponse DescribeSubnetsSync(DescribeSubnetsRequest req)
        {
            return InternalRequestAsync<DescribeSubnetsResponse>(req, "DescribeSubnets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the health check status of a CLB real server.
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetHealthRequest"/></param>
        /// <returns><see cref="DescribeTargetHealthResponse"/></returns>
        public Task<DescribeTargetHealthResponse> DescribeTargetHealth(DescribeTargetHealthRequest req)
        {
            return InternalRequestAsync<DescribeTargetHealthResponse>(req, "DescribeTargetHealth");
        }

        /// <summary>
        /// This API is used to get the health check status of a CLB real server.
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetHealthRequest"/></param>
        /// <returns><see cref="DescribeTargetHealthResponse"/></returns>
        public DescribeTargetHealthResponse DescribeTargetHealthSync(DescribeTargetHealthRequest req)
        {
            return InternalRequestAsync<DescribeTargetHealthResponse>(req, "DescribeTargetHealth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of the real servers bound to a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetsRequest"/></param>
        /// <returns><see cref="DescribeTargetsResponse"/></returns>
        public Task<DescribeTargetsResponse> DescribeTargets(DescribeTargetsRequest req)
        {
            return InternalRequestAsync<DescribeTargetsResponse>(req, "DescribeTargets");
        }

        /// <summary>
        /// This API is used to query the list of the real servers bound to a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeTargetsRequest"/></param>
        /// <returns><see cref="DescribeTargetsResponse"/></returns>
        public DescribeTargetsResponse DescribeTargetsSync(DescribeTargetsRequest req)
        {
            return InternalRequestAsync<DescribeTargetsResponse>(req, "DescribeTargets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the execution result of an EIP async task.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskResultRequest"/></param>
        /// <returns><see cref="DescribeTaskResultResponse"/></returns>
        public Task<DescribeTaskResultResponse> DescribeTaskResult(DescribeTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeTaskResultResponse>(req, "DescribeTaskResult");
        }

        /// <summary>
        /// This API is used to query the execution result of an EIP async task.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskResultRequest"/></param>
        /// <returns><see cref="DescribeTaskResultResponse"/></returns>
        public DescribeTaskResultResponse DescribeTaskResultSync(DescribeTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeTaskResultResponse>(req, "DescribeTaskResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the status of an async task.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskStatusResponse"/></returns>
        public Task<DescribeTaskStatusResponse> DescribeTaskStatus(DescribeTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeTaskStatusResponse>(req, "DescribeTaskStatus");
        }

        /// <summary>
        /// This API is used to get the status of an async task.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskStatusResponse"/></returns>
        public DescribeTaskStatusResponse DescribeTaskStatusSync(DescribeTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeTaskStatusResponse>(req, "DescribeTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of VPCs.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcsRequest"/></param>
        /// <returns><see cref="DescribeVpcsResponse"/></returns>
        public Task<DescribeVpcsResponse> DescribeVpcs(DescribeVpcsRequest req)
        {
            return InternalRequestAsync<DescribeVpcsResponse>(req, "DescribeVpcs");
        }

        /// <summary>
        /// This API is used to query the list of VPCs.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcsRequest"/></param>
        /// <returns><see cref="DescribeVpcsResponse"/></returns>
        public DescribeVpcsResponse DescribeVpcsSync(DescribeVpcsRequest req)
        {
            return InternalRequestAsync<DescribeVpcsResponse>(req, "DescribeVpcs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind an ENI from a CVM instance.
        /// </summary>
        /// <param name="req"><see cref="DetachNetworkInterfaceRequest"/></param>
        /// <returns><see cref="DetachNetworkInterfaceResponse"/></returns>
        public Task<DetachNetworkInterfaceResponse> DetachNetworkInterface(DetachNetworkInterfaceRequest req)
        {
            return InternalRequestAsync<DetachNetworkInterfaceResponse>(req, "DetachNetworkInterface");
        }

        /// <summary>
        /// This API is used to unbind an ENI from a CVM instance.
        /// </summary>
        /// <param name="req"><see cref="DetachNetworkInterfaceRequest"/></param>
        /// <returns><see cref="DetachNetworkInterfaceResponse"/></returns>
        public DetachNetworkInterfaceResponse DetachNetworkInterfaceSync(DetachNetworkInterfaceRequest req)
        {
            return InternalRequestAsync<DetachNetworkInterfaceResponse>(req, "DetachNetworkInterface")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable a subnet route.
        /// </summary>
        /// <param name="req"><see cref="DisableRoutesRequest"/></param>
        /// <returns><see cref="DisableRoutesResponse"/></returns>
        public Task<DisableRoutesResponse> DisableRoutes(DisableRoutesRequest req)
        {
            return InternalRequestAsync<DisableRoutesResponse>(req, "DisableRoutes");
        }

        /// <summary>
        /// This API is used to disable a subnet route.
        /// </summary>
        /// <param name="req"><see cref="DisableRoutesRequest"/></param>
        /// <returns><see cref="DisableRoutesResponse"/></returns>
        public DisableRoutesResponse DisableRoutesSync(DisableRoutesRequest req)
        {
            return InternalRequestAsync<DisableRoutesResponse>(req, "DisableRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind an EIP.
        /// Only EIPs in `BIND` or `BIND_ENI` status can be unbound.
        /// Blocked EIPs cannot be unbound.
        /// </summary>
        /// <param name="req"><see cref="DisassociateAddressRequest"/></param>
        /// <returns><see cref="DisassociateAddressResponse"/></returns>
        public Task<DisassociateAddressResponse> DisassociateAddress(DisassociateAddressRequest req)
        {
            return InternalRequestAsync<DisassociateAddressResponse>(req, "DisassociateAddress");
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
            return InternalRequestAsync<DisassociateAddressResponse>(req, "DisassociateAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind a key pair from an instance.
        /// </summary>
        /// <param name="req"><see cref="DisassociateInstancesKeyPairsRequest"/></param>
        /// <returns><see cref="DisassociateInstancesKeyPairsResponse"/></returns>
        public Task<DisassociateInstancesKeyPairsResponse> DisassociateInstancesKeyPairs(DisassociateInstancesKeyPairsRequest req)
        {
            return InternalRequestAsync<DisassociateInstancesKeyPairsResponse>(req, "DisassociateInstancesKeyPairs");
        }

        /// <summary>
        /// This API is used to unbind a key pair from an instance.
        /// </summary>
        /// <param name="req"><see cref="DisassociateInstancesKeyPairsRequest"/></param>
        /// <returns><see cref="DisassociateInstancesKeyPairsResponse"/></returns>
        public DisassociateInstancesKeyPairsResponse DisassociateInstancesKeyPairsSync(DisassociateInstancesKeyPairsRequest req)
        {
            return InternalRequestAsync<DisassociateInstancesKeyPairsResponse>(req, "DisassociateInstancesKeyPairs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind a security group.
        /// </summary>
        /// <param name="req"><see cref="DisassociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateSecurityGroupsResponse"/></returns>
        public Task<DisassociateSecurityGroupsResponse> DisassociateSecurityGroups(DisassociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DisassociateSecurityGroupsResponse>(req, "DisassociateSecurityGroups");
        }

        /// <summary>
        /// This API is used to unbind a security group.
        /// </summary>
        /// <param name="req"><see cref="DisassociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateSecurityGroupsResponse"/></returns>
        public DisassociateSecurityGroupsResponse DisassociateSecurityGroupsSync(DisassociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DisassociateSecurityGroupsResponse>(req, "DisassociateSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable a disabled subnet route.
        /// This API verifies whether a CCN route will conflict with an existing route after it is enabled, and if so, you cannot enable it before you disable the conflicting route first.
        /// </summary>
        /// <param name="req"><see cref="EnableRoutesRequest"/></param>
        /// <returns><see cref="EnableRoutesResponse"/></returns>
        public Task<EnableRoutesResponse> EnableRoutes(EnableRoutesRequest req)
        {
            return InternalRequestAsync<EnableRoutesResponse>(req, "EnableRoutes");
        }

        /// <summary>
        /// This API is used to enable a disabled subnet route.
        /// This API verifies whether a CCN route will conflict with an existing route after it is enabled, and if so, you cannot enable it before you disable the conflicting route first.
        /// </summary>
        /// <param name="req"><see cref="EnableRoutesRequest"/></param>
        /// <returns><see cref="EnableRoutesResponse"/></returns>
        public EnableRoutesResponse EnableRoutesSync(EnableRoutesRequest req)
        {
            return InternalRequestAsync<EnableRoutesResponse>(req, "EnableRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to import an image from a CVM instance to an ECM instance.
        /// </summary>
        /// <param name="req"><see cref="ImportImageRequest"/></param>
        /// <returns><see cref="ImportImageResponse"/></returns>
        public Task<ImportImageResponse> ImportImage(ImportImageRequest req)
        {
            return InternalRequestAsync<ImportImageResponse>(req, "ImportImage");
        }

        /// <summary>
        /// This API is used to import an image from a CVM instance to an ECM instance.
        /// </summary>
        /// <param name="req"><see cref="ImportImageRequest"/></param>
        /// <returns><see cref="ImportImageResponse"/></returns>
        public ImportImageResponse ImportImageSync(ImportImageRequest req)
        {
            return InternalRequestAsync<ImportImageResponse>(req, "ImportImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to migrate an ENI.
        /// </summary>
        /// <param name="req"><see cref="MigrateNetworkInterfaceRequest"/></param>
        /// <returns><see cref="MigrateNetworkInterfaceResponse"/></returns>
        public Task<MigrateNetworkInterfaceResponse> MigrateNetworkInterface(MigrateNetworkInterfaceRequest req)
        {
            return InternalRequestAsync<MigrateNetworkInterfaceResponse>(req, "MigrateNetworkInterface");
        }

        /// <summary>
        /// This API is used to migrate an ENI.
        /// </summary>
        /// <param name="req"><see cref="MigrateNetworkInterfaceRequest"/></param>
        /// <returns><see cref="MigrateNetworkInterfaceResponse"/></returns>
        public MigrateNetworkInterfaceResponse MigrateNetworkInterfaceSync(MigrateNetworkInterfaceRequest req)
        {
            return InternalRequestAsync<MigrateNetworkInterfaceResponse>(req, "MigrateNetworkInterface")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to migrate a private IP from an ENI.
        /// It migrates a private IP from one ENI to another. Primary IPs cannot be migrated.
        /// The source and destination ENIs must be in the same subnet.
        /// </summary>
        /// <param name="req"><see cref="MigratePrivateIpAddressRequest"/></param>
        /// <returns><see cref="MigratePrivateIpAddressResponse"/></returns>
        public Task<MigratePrivateIpAddressResponse> MigratePrivateIpAddress(MigratePrivateIpAddressRequest req)
        {
            return InternalRequestAsync<MigratePrivateIpAddressResponse>(req, "MigratePrivateIpAddress");
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
            return InternalRequestAsync<MigratePrivateIpAddressResponse>(req, "MigratePrivateIpAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify EIP attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressAttributeRequest"/></param>
        /// <returns><see cref="ModifyAddressAttributeResponse"/></returns>
        public Task<ModifyAddressAttributeResponse> ModifyAddressAttribute(ModifyAddressAttributeRequest req)
        {
            return InternalRequestAsync<ModifyAddressAttributeResponse>(req, "ModifyAddressAttribute");
        }

        /// <summary>
        /// This API is used to modify EIP attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressAttributeRequest"/></param>
        /// <returns><see cref="ModifyAddressAttributeResponse"/></returns>
        public ModifyAddressAttributeResponse ModifyAddressAttributeSync(ModifyAddressAttributeRequest req)
        {
            return InternalRequestAsync<ModifyAddressAttributeResponse>(req, "ModifyAddressAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the EIP bandwidth.
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressesBandwidthRequest"/></param>
        /// <returns><see cref="ModifyAddressesBandwidthResponse"/></returns>
        public Task<ModifyAddressesBandwidthResponse> ModifyAddressesBandwidth(ModifyAddressesBandwidthRequest req)
        {
            return InternalRequestAsync<ModifyAddressesBandwidthResponse>(req, "ModifyAddressesBandwidth");
        }

        /// <summary>
        /// This API is used to modify the EIP bandwidth.
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressesBandwidthRequest"/></param>
        /// <returns><see cref="ModifyAddressesBandwidthResponse"/></returns>
        public ModifyAddressesBandwidthResponse ModifyAddressesBandwidthSync(ModifyAddressesBandwidthRequest req)
        {
            return InternalRequestAsync<ModifyAddressesBandwidthResponse>(req, "ModifyAddressesBandwidth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the default subnet used when you create an instance in an AZ (if you don't specify the VPC parameter when creating the instance, `sunbetId` will be used).
        /// </summary>
        /// <param name="req"><see cref="ModifyDefaultSubnetRequest"/></param>
        /// <returns><see cref="ModifyDefaultSubnetResponse"/></returns>
        public Task<ModifyDefaultSubnetResponse> ModifyDefaultSubnet(ModifyDefaultSubnetRequest req)
        {
            return InternalRequestAsync<ModifyDefaultSubnetResponse>(req, "ModifyDefaultSubnet");
        }

        /// <summary>
        /// This API is used to modify the default subnet used when you create an instance in an AZ (if you don't specify the VPC parameter when creating the instance, `sunbetId` will be used).
        /// </summary>
        /// <param name="req"><see cref="ModifyDefaultSubnetRequest"/></param>
        /// <returns><see cref="ModifyDefaultSubnetResponse"/></returns>
        public ModifyDefaultSubnetResponse ModifyDefaultSubnetSync(ModifyDefaultSubnetRequest req)
        {
            return InternalRequestAsync<ModifyDefaultSubnetResponse>(req, "ModifyDefaultSubnet")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the attributes of an HAVIP.
        /// </summary>
        /// <param name="req"><see cref="ModifyHaVipAttributeRequest"/></param>
        /// <returns><see cref="ModifyHaVipAttributeResponse"/></returns>
        public Task<ModifyHaVipAttributeResponse> ModifyHaVipAttribute(ModifyHaVipAttributeRequest req)
        {
            return InternalRequestAsync<ModifyHaVipAttributeResponse>(req, "ModifyHaVipAttribute");
        }

        /// <summary>
        /// This API is used to modify the attributes of an HAVIP.
        /// </summary>
        /// <param name="req"><see cref="ModifyHaVipAttributeRequest"/></param>
        /// <returns><see cref="ModifyHaVipAttributeResponse"/></returns>
        public ModifyHaVipAttributeResponse ModifyHaVipAttributeSync(ModifyHaVipAttributeRequest req)
        {
            return InternalRequestAsync<ModifyHaVipAttributeResponse>(req, "ModifyHaVipAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the attributes of an image.
        /// </summary>
        /// <param name="req"><see cref="ModifyImageAttributeRequest"/></param>
        /// <returns><see cref="ModifyImageAttributeResponse"/></returns>
        public Task<ModifyImageAttributeResponse> ModifyImageAttribute(ModifyImageAttributeRequest req)
        {
            return InternalRequestAsync<ModifyImageAttributeResponse>(req, "ModifyImageAttribute");
        }

        /// <summary>
        /// This API is used to modify the attributes of an image.
        /// </summary>
        /// <param name="req"><see cref="ModifyImageAttributeRequest"/></param>
        /// <returns><see cref="ModifyImageAttributeResponse"/></returns>
        public ModifyImageAttributeResponse ModifyImageAttributeSync(ModifyImageAttributeRequest req)
        {
            return InternalRequestAsync<ModifyImageAttributeResponse>(req, "ModifyImageAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the attributes of an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesAttributeRequest"/></param>
        /// <returns><see cref="ModifyInstancesAttributeResponse"/></returns>
        public Task<ModifyInstancesAttributeResponse> ModifyInstancesAttribute(ModifyInstancesAttributeRequest req)
        {
            return InternalRequestAsync<ModifyInstancesAttributeResponse>(req, "ModifyInstancesAttribute");
        }

        /// <summary>
        /// This API is used to modify the attributes of an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesAttributeRequest"/></param>
        /// <returns><see cref="ModifyInstancesAttributeResponse"/></returns>
        public ModifyInstancesAttributeResponse ModifyInstancesAttributeSync(ModifyInstancesAttributeRequest req)
        {
            return InternalRequestAsync<ModifyInstancesAttributeResponse>(req, "ModifyInstancesAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the IPv6 address attributes of an ENI.
        /// </summary>
        /// <param name="req"><see cref="ModifyIpv6AddressesAttributeRequest"/></param>
        /// <returns><see cref="ModifyIpv6AddressesAttributeResponse"/></returns>
        public Task<ModifyIpv6AddressesAttributeResponse> ModifyIpv6AddressesAttribute(ModifyIpv6AddressesAttributeRequest req)
        {
            return InternalRequestAsync<ModifyIpv6AddressesAttributeResponse>(req, "ModifyIpv6AddressesAttribute");
        }

        /// <summary>
        /// This API is used to modify the IPv6 address attributes of an ENI.
        /// </summary>
        /// <param name="req"><see cref="ModifyIpv6AddressesAttributeRequest"/></param>
        /// <returns><see cref="ModifyIpv6AddressesAttributeResponse"/></returns>
        public ModifyIpv6AddressesAttributeResponse ModifyIpv6AddressesAttributeSync(ModifyIpv6AddressesAttributeRequest req)
        {
            return InternalRequestAsync<ModifyIpv6AddressesAttributeResponse>(req, "ModifyIpv6AddressesAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the attributes of a CLB listener.
        /// </summary>
        /// <param name="req"><see cref="ModifyListenerRequest"/></param>
        /// <returns><see cref="ModifyListenerResponse"/></returns>
        public Task<ModifyListenerResponse> ModifyListener(ModifyListenerRequest req)
        {
            return InternalRequestAsync<ModifyListenerResponse>(req, "ModifyListener");
        }

        /// <summary>
        /// This API is used to modify the attributes of a CLB listener.
        /// </summary>
        /// <param name="req"><see cref="ModifyListenerRequest"/></param>
        /// <returns><see cref="ModifyListenerResponse"/></returns>
        public ModifyListenerResponse ModifyListenerSync(ModifyListenerRequest req)
        {
            return InternalRequestAsync<ModifyListenerResponse>(req, "ModifyListener")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the attributes of a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerAttributesRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerAttributesResponse"/></returns>
        public Task<ModifyLoadBalancerAttributesResponse> ModifyLoadBalancerAttributes(ModifyLoadBalancerAttributesRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancerAttributesResponse>(req, "ModifyLoadBalancerAttributes");
        }

        /// <summary>
        /// This API is used to modify the attributes of a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerAttributesRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerAttributesResponse"/></returns>
        public ModifyLoadBalancerAttributesResponse ModifyLoadBalancerAttributesSync(ModifyLoadBalancerAttributesRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancerAttributesResponse>(req, "ModifyLoadBalancerAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the configuration of a module. You cannot modify the configuration of the module if it is associated with an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleConfigRequest"/></param>
        /// <returns><see cref="ModifyModuleConfigResponse"/></returns>
        public Task<ModifyModuleConfigResponse> ModifyModuleConfig(ModifyModuleConfigRequest req)
        {
            return InternalRequestAsync<ModifyModuleConfigResponse>(req, "ModifyModuleConfig");
        }

        /// <summary>
        /// This API is used to modify the configuration of a module. You cannot modify the configuration of the module if it is associated with an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleConfigRequest"/></param>
        /// <returns><see cref="ModifyModuleConfigResponse"/></returns>
        public ModifyModuleConfigResponse ModifyModuleConfigSync(ModifyModuleConfigRequest req)
        {
            return InternalRequestAsync<ModifyModuleConfigResponse>(req, "ModifyModuleConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to specify whether to prohibit public IP assignment for a module.
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleDisableWanIpRequest"/></param>
        /// <returns><see cref="ModifyModuleDisableWanIpResponse"/></returns>
        public Task<ModifyModuleDisableWanIpResponse> ModifyModuleDisableWanIp(ModifyModuleDisableWanIpRequest req)
        {
            return InternalRequestAsync<ModifyModuleDisableWanIpResponse>(req, "ModifyModuleDisableWanIp");
        }

        /// <summary>
        /// This API is used to specify whether to prohibit public IP assignment for a module.
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleDisableWanIpRequest"/></param>
        /// <returns><see cref="ModifyModuleDisableWanIpResponse"/></returns>
        public ModifyModuleDisableWanIpResponse ModifyModuleDisableWanIpSync(ModifyModuleDisableWanIpRequest req)
        {
            return InternalRequestAsync<ModifyModuleDisableWanIpResponse>(req, "ModifyModuleDisableWanIp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the default image of a module.
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleImageRequest"/></param>
        /// <returns><see cref="ModifyModuleImageResponse"/></returns>
        public Task<ModifyModuleImageResponse> ModifyModuleImage(ModifyModuleImageRequest req)
        {
            return InternalRequestAsync<ModifyModuleImageResponse>(req, "ModifyModuleImage");
        }

        /// <summary>
        /// This API is used to modify the default image of a module.
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleImageRequest"/></param>
        /// <returns><see cref="ModifyModuleImageResponse"/></returns>
        public ModifyModuleImageResponse ModifyModuleImageSync(ModifyModuleImageRequest req)
        {
            return InternalRequestAsync<ModifyModuleImageResponse>(req, "ModifyModuleImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the IP direct access of a module.
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleIpDirectRequest"/></param>
        /// <returns><see cref="ModifyModuleIpDirectResponse"/></returns>
        public Task<ModifyModuleIpDirectResponse> ModifyModuleIpDirect(ModifyModuleIpDirectRequest req)
        {
            return InternalRequestAsync<ModifyModuleIpDirectResponse>(req, "ModifyModuleIpDirect");
        }

        /// <summary>
        /// This API is used to modify the IP direct access of a module.
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleIpDirectRequest"/></param>
        /// <returns><see cref="ModifyModuleIpDirectResponse"/></returns>
        public ModifyModuleIpDirectResponse ModifyModuleIpDirectSync(ModifyModuleIpDirectRequest req)
        {
            return InternalRequestAsync<ModifyModuleIpDirectResponse>(req, "ModifyModuleIpDirect")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to rename a module.
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleNameRequest"/></param>
        /// <returns><see cref="ModifyModuleNameResponse"/></returns>
        public Task<ModifyModuleNameResponse> ModifyModuleName(ModifyModuleNameRequest req)
        {
            return InternalRequestAsync<ModifyModuleNameResponse>(req, "ModifyModuleName");
        }

        /// <summary>
        /// This API is used to rename a module.
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleNameRequest"/></param>
        /// <returns><see cref="ModifyModuleNameResponse"/></returns>
        public ModifyModuleNameResponse ModifyModuleNameSync(ModifyModuleNameRequest req)
        {
            return InternalRequestAsync<ModifyModuleNameResponse>(req, "ModifyModuleName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the default bandwidth cap of a module.
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleNetworkRequest"/></param>
        /// <returns><see cref="ModifyModuleNetworkResponse"/></returns>
        public Task<ModifyModuleNetworkResponse> ModifyModuleNetwork(ModifyModuleNetworkRequest req)
        {
            return InternalRequestAsync<ModifyModuleNetworkResponse>(req, "ModifyModuleNetwork");
        }

        /// <summary>
        /// This API is used to modify the default bandwidth cap of a module.
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleNetworkRequest"/></param>
        /// <returns><see cref="ModifyModuleNetworkResponse"/></returns>
        public ModifyModuleNetworkResponse ModifyModuleNetworkSync(ModifyModuleNetworkRequest req)
        {
            return InternalRequestAsync<ModifyModuleNetworkResponse>(req, "ModifyModuleNetwork")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the default security group of a module.
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleSecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifyModuleSecurityGroupsResponse"/></returns>
        public Task<ModifyModuleSecurityGroupsResponse> ModifyModuleSecurityGroups(ModifyModuleSecurityGroupsRequest req)
        {
            return InternalRequestAsync<ModifyModuleSecurityGroupsResponse>(req, "ModifyModuleSecurityGroups");
        }

        /// <summary>
        /// This API is used to modify the default security group of a module.
        /// </summary>
        /// <param name="req"><see cref="ModifyModuleSecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifyModuleSecurityGroupsResponse"/></returns>
        public ModifyModuleSecurityGroupsResponse ModifyModuleSecurityGroupsSync(ModifyModuleSecurityGroupsRequest req)
        {
            return InternalRequestAsync<ModifyModuleSecurityGroupsResponse>(req, "ModifyModuleSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the private IP attributes of an ENI.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateIpAddressesAttributeRequest"/></param>
        /// <returns><see cref="ModifyPrivateIpAddressesAttributeResponse"/></returns>
        public Task<ModifyPrivateIpAddressesAttributeResponse> ModifyPrivateIpAddressesAttribute(ModifyPrivateIpAddressesAttributeRequest req)
        {
            return InternalRequestAsync<ModifyPrivateIpAddressesAttributeResponse>(req, "ModifyPrivateIpAddressesAttribute");
        }

        /// <summary>
        /// This API is used to modify the private IP attributes of an ENI.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateIpAddressesAttributeRequest"/></param>
        /// <returns><see cref="ModifyPrivateIpAddressesAttributeResponse"/></returns>
        public ModifyPrivateIpAddressesAttributeResponse ModifyPrivateIpAddressesAttributeSync(ModifyPrivateIpAddressesAttributeRequest req)
        {
            return InternalRequestAsync<ModifyPrivateIpAddressesAttributeResponse>(req, "ModifyPrivateIpAddressesAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the attributes of a route table.
        /// </summary>
        /// <param name="req"><see cref="ModifyRouteTableAttributeRequest"/></param>
        /// <returns><see cref="ModifyRouteTableAttributeResponse"/></returns>
        public Task<ModifyRouteTableAttributeResponse> ModifyRouteTableAttribute(ModifyRouteTableAttributeRequest req)
        {
            return InternalRequestAsync<ModifyRouteTableAttributeResponse>(req, "ModifyRouteTableAttribute");
        }

        /// <summary>
        /// This API is used to modify the attributes of a route table.
        /// </summary>
        /// <param name="req"><see cref="ModifyRouteTableAttributeRequest"/></param>
        /// <returns><see cref="ModifyRouteTableAttributeResponse"/></returns>
        public ModifyRouteTableAttributeResponse ModifyRouteTableAttributeSync(ModifyRouteTableAttributeRequest req)
        {
            return InternalRequestAsync<ModifyRouteTableAttributeResponse>(req, "ModifyRouteTableAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the attributes of a security group.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupAttributeResponse"/></returns>
        public Task<ModifySecurityGroupAttributeResponse> ModifySecurityGroupAttribute(ModifySecurityGroupAttributeRequest req)
        {
            return InternalRequestAsync<ModifySecurityGroupAttributeResponse>(req, "ModifySecurityGroupAttribute");
        }

        /// <summary>
        /// This API is used to modify the attributes of a security group.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupAttributeRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupAttributeResponse"/></returns>
        public ModifySecurityGroupAttributeResponse ModifySecurityGroupAttributeSync(ModifySecurityGroupAttributeRequest req)
        {
            return InternalRequestAsync<ModifySecurityGroupAttributeResponse>(req, "ModifySecurityGroupAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the outbound and inbound rules of a security group.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupPoliciesRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupPoliciesResponse"/></returns>
        public Task<ModifySecurityGroupPoliciesResponse> ModifySecurityGroupPolicies(ModifySecurityGroupPoliciesRequest req)
        {
            return InternalRequestAsync<ModifySecurityGroupPoliciesResponse>(req, "ModifySecurityGroupPolicies");
        }

        /// <summary>
        /// This API is used to modify the outbound and inbound rules of a security group.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupPoliciesRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupPoliciesResponse"/></returns>
        public ModifySecurityGroupPoliciesResponse ModifySecurityGroupPoliciesSync(ModifySecurityGroupPoliciesRequest req)
        {
            return InternalRequestAsync<ModifySecurityGroupPoliciesResponse>(req, "ModifySecurityGroupPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the attributes of a subnet.
        /// </summary>
        /// <param name="req"><see cref="ModifySubnetAttributeRequest"/></param>
        /// <returns><see cref="ModifySubnetAttributeResponse"/></returns>
        public Task<ModifySubnetAttributeResponse> ModifySubnetAttribute(ModifySubnetAttributeRequest req)
        {
            return InternalRequestAsync<ModifySubnetAttributeResponse>(req, "ModifySubnetAttribute");
        }

        /// <summary>
        /// This API is used to modify the attributes of a subnet.
        /// </summary>
        /// <param name="req"><see cref="ModifySubnetAttributeRequest"/></param>
        /// <returns><see cref="ModifySubnetAttributeResponse"/></returns>
        public ModifySubnetAttributeResponse ModifySubnetAttributeSync(ModifySubnetAttributeRequest req)
        {
            return InternalRequestAsync<ModifySubnetAttributeResponse>(req, "ModifySubnetAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the port of a real server bound to a listener.
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetPortRequest"/></param>
        /// <returns><see cref="ModifyTargetPortResponse"/></returns>
        public Task<ModifyTargetPortResponse> ModifyTargetPort(ModifyTargetPortRequest req)
        {
            return InternalRequestAsync<ModifyTargetPortResponse>(req, "ModifyTargetPort");
        }

        /// <summary>
        /// This API is used to modify the port of a real server bound to a listener.
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetPortRequest"/></param>
        /// <returns><see cref="ModifyTargetPortResponse"/></returns>
        public ModifyTargetPortResponse ModifyTargetPortSync(ModifyTargetPortRequest req)
        {
            return InternalRequestAsync<ModifyTargetPortResponse>(req, "ModifyTargetPort")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the forwarding weight of a real server bound to a listener.
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetWeightRequest"/></param>
        /// <returns><see cref="ModifyTargetWeightResponse"/></returns>
        public Task<ModifyTargetWeightResponse> ModifyTargetWeight(ModifyTargetWeightRequest req)
        {
            return InternalRequestAsync<ModifyTargetWeightResponse>(req, "ModifyTargetWeight");
        }

        /// <summary>
        /// This API is used to modify the forwarding weight of a real server bound to a listener.
        /// </summary>
        /// <param name="req"><see cref="ModifyTargetWeightRequest"/></param>
        /// <returns><see cref="ModifyTargetWeightResponse"/></returns>
        public ModifyTargetWeightResponse ModifyTargetWeightSync(ModifyTargetWeightRequest req)
        {
            return InternalRequestAsync<ModifyTargetWeightResponse>(req, "ModifyTargetWeight")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the attributes of a VPC.
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcAttributeRequest"/></param>
        /// <returns><see cref="ModifyVpcAttributeResponse"/></returns>
        public Task<ModifyVpcAttributeResponse> ModifyVpcAttribute(ModifyVpcAttributeRequest req)
        {
            return InternalRequestAsync<ModifyVpcAttributeResponse>(req, "ModifyVpcAttribute");
        }

        /// <summary>
        /// This API is used to modify the attributes of a VPC.
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcAttributeRequest"/></param>
        /// <returns><see cref="ModifyVpcAttributeResponse"/></returns>
        public ModifyVpcAttributeResponse ModifyVpcAttributeSync(ModifyVpcAttributeRequest req)
        {
            return InternalRequestAsync<ModifyVpcAttributeResponse>(req, "ModifyVpcAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to restart an instance. Only instances in `RUNNING` status can be restarted. The instance status will become `REBOOTING` when the API is called successfully and will become `RUNNING` when the instance is restarted successfully. Forced restart is supported. Just like powering off a physical PC and restarting it, a forced restart may cause data loss or file system corruption. Make sure that you use this API only when the server cannot be restarted normally.
        /// </summary>
        /// <param name="req"><see cref="RebootInstancesRequest"/></param>
        /// <returns><see cref="RebootInstancesResponse"/></returns>
        public Task<RebootInstancesResponse> RebootInstances(RebootInstancesRequest req)
        {
            return InternalRequestAsync<RebootInstancesResponse>(req, "RebootInstances");
        }

        /// <summary>
        /// This API is used to restart an instance. Only instances in `RUNNING` status can be restarted. The instance status will become `REBOOTING` when the API is called successfully and will become `RUNNING` when the instance is restarted successfully. Forced restart is supported. Just like powering off a physical PC and restarting it, a forced restart may cause data loss or file system corruption. Make sure that you use this API only when the server cannot be restarted normally.
        /// </summary>
        /// <param name="req"><see cref="RebootInstancesRequest"/></param>
        /// <returns><see cref="RebootInstancesResponse"/></returns>
        public RebootInstancesResponse RebootInstancesSync(RebootInstancesRequest req)
        {
            return InternalRequestAsync<RebootInstancesResponse>(req, "RebootInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to release one or multiple EIPs.
        /// This operation is irreversible. Once you release an EIP, the IP address associated with it will no longer belong to you.
        /// Only EIPs in `UNBIND` status can be released.
        /// </summary>
        /// <param name="req"><see cref="ReleaseAddressesRequest"/></param>
        /// <returns><see cref="ReleaseAddressesResponse"/></returns>
        public Task<ReleaseAddressesResponse> ReleaseAddresses(ReleaseAddressesRequest req)
        {
            return InternalRequestAsync<ReleaseAddressesResponse>(req, "ReleaseAddresses");
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
            return InternalRequestAsync<ReleaseAddressesResponse>(req, "ReleaseAddresses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to release the IPv6 addresses of an ENI.
        /// </summary>
        /// <param name="req"><see cref="ReleaseIpv6AddressesRequest"/></param>
        /// <returns><see cref="ReleaseIpv6AddressesResponse"/></returns>
        public Task<ReleaseIpv6AddressesResponse> ReleaseIpv6Addresses(ReleaseIpv6AddressesRequest req)
        {
            return InternalRequestAsync<ReleaseIpv6AddressesResponse>(req, "ReleaseIpv6Addresses");
        }

        /// <summary>
        /// This API is used to release the IPv6 addresses of an ENI.
        /// </summary>
        /// <param name="req"><see cref="ReleaseIpv6AddressesRequest"/></param>
        /// <returns><see cref="ReleaseIpv6AddressesResponse"/></returns>
        public ReleaseIpv6AddressesResponse ReleaseIpv6AddressesSync(ReleaseIpv6AddressesRequest req)
        {
            return InternalRequestAsync<ReleaseIpv6AddressesResponse>(req, "ReleaseIpv6Addresses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to return the private IPs of an ENI.
        /// To return the secondary private IPs of an ENI, the API will automatically unbind them from the ENI. The primary private IP of the ENI cannot be returned.
        /// </summary>
        /// <param name="req"><see cref="RemovePrivateIpAddressesRequest"/></param>
        /// <returns><see cref="RemovePrivateIpAddressesResponse"/></returns>
        public Task<RemovePrivateIpAddressesResponse> RemovePrivateIpAddresses(RemovePrivateIpAddressesRequest req)
        {
            return InternalRequestAsync<RemovePrivateIpAddressesResponse>(req, "RemovePrivateIpAddresses");
        }

        /// <summary>
        /// This API is used to return the private IPs of an ENI.
        /// To return the secondary private IPs of an ENI, the API will automatically unbind them from the ENI. The primary private IP of the ENI cannot be returned.
        /// </summary>
        /// <param name="req"><see cref="RemovePrivateIpAddressesRequest"/></param>
        /// <returns><see cref="RemovePrivateIpAddressesResponse"/></returns>
        public RemovePrivateIpAddressesResponse RemovePrivateIpAddressesSync(RemovePrivateIpAddressesRequest req)
        {
            return InternalRequestAsync<RemovePrivateIpAddressesResponse>(req, "RemovePrivateIpAddresses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the route table associated with a subnet. A subnet can be associated with only one route table.
        /// </summary>
        /// <param name="req"><see cref="ReplaceRouteTableAssociationRequest"/></param>
        /// <returns><see cref="ReplaceRouteTableAssociationResponse"/></returns>
        public Task<ReplaceRouteTableAssociationResponse> ReplaceRouteTableAssociation(ReplaceRouteTableAssociationRequest req)
        {
            return InternalRequestAsync<ReplaceRouteTableAssociationResponse>(req, "ReplaceRouteTableAssociation");
        }

        /// <summary>
        /// This API is used to modify the route table associated with a subnet. A subnet can be associated with only one route table.
        /// </summary>
        /// <param name="req"><see cref="ReplaceRouteTableAssociationRequest"/></param>
        /// <returns><see cref="ReplaceRouteTableAssociationResponse"/></returns>
        public ReplaceRouteTableAssociationResponse ReplaceRouteTableAssociationSync(ReplaceRouteTableAssociationRequest req)
        {
            return InternalRequestAsync<ReplaceRouteTableAssociationResponse>(req, "ReplaceRouteTableAssociation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to replace a routing policy.
        /// </summary>
        /// <param name="req"><see cref="ReplaceRoutesRequest"/></param>
        /// <returns><see cref="ReplaceRoutesResponse"/></returns>
        public Task<ReplaceRoutesResponse> ReplaceRoutes(ReplaceRoutesRequest req)
        {
            return InternalRequestAsync<ReplaceRoutesResponse>(req, "ReplaceRoutes");
        }

        /// <summary>
        /// This API is used to replace a routing policy.
        /// </summary>
        /// <param name="req"><see cref="ReplaceRoutesRequest"/></param>
        /// <returns><see cref="ReplaceRoutesResponse"/></returns>
        public ReplaceRoutesResponse ReplaceRoutesSync(ReplaceRoutesRequest req)
        {
            return InternalRequestAsync<ReplaceRoutesResponse>(req, "ReplaceRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to replace a single routing rule of a security group. You can replace only one rule in a single direction in one request and must specify the index (PolicyIndex).
        /// </summary>
        /// <param name="req"><see cref="ReplaceSecurityGroupPolicyRequest"/></param>
        /// <returns><see cref="ReplaceSecurityGroupPolicyResponse"/></returns>
        public Task<ReplaceSecurityGroupPolicyResponse> ReplaceSecurityGroupPolicy(ReplaceSecurityGroupPolicyRequest req)
        {
            return InternalRequestAsync<ReplaceSecurityGroupPolicyResponse>(req, "ReplaceSecurityGroupPolicy");
        }

        /// <summary>
        /// This API is used to replace a single routing rule of a security group. You can replace only one rule in a single direction in one request and must specify the index (PolicyIndex).
        /// </summary>
        /// <param name="req"><see cref="ReplaceSecurityGroupPolicyRequest"/></param>
        /// <returns><see cref="ReplaceSecurityGroupPolicyResponse"/></returns>
        public ReplaceSecurityGroupPolicyResponse ReplaceSecurityGroupPolicySync(ReplaceSecurityGroupPolicyRequest req)
        {
            return InternalRequestAsync<ReplaceSecurityGroupPolicyResponse>(req, "ReplaceSecurityGroupPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to reinstall an instance. If you specify the `ImageId` parameter, the specified image will be used; otherwise, the image used by the current instance will be used. If you don't specify the password, a password will be sent later in Message Center.
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesRequest"/></param>
        /// <returns><see cref="ResetInstancesResponse"/></returns>
        public Task<ResetInstancesResponse> ResetInstances(ResetInstancesRequest req)
        {
            return InternalRequestAsync<ResetInstancesResponse>(req, "ResetInstances");
        }

        /// <summary>
        /// This API is used to reinstall an instance. If you specify the `ImageId` parameter, the specified image will be used; otherwise, the image used by the current instance will be used. If you don't specify the password, a password will be sent later in Message Center.
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesRequest"/></param>
        /// <returns><see cref="ResetInstancesResponse"/></returns>
        public ResetInstancesResponse ResetInstancesSync(ResetInstancesRequest req)
        {
            return InternalRequestAsync<ResetInstancesResponse>(req, "ResetInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to reset the bandwidth cap of an instance.
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesMaxBandwidthRequest"/></param>
        /// <returns><see cref="ResetInstancesMaxBandwidthResponse"/></returns>
        public Task<ResetInstancesMaxBandwidthResponse> ResetInstancesMaxBandwidth(ResetInstancesMaxBandwidthRequest req)
        {
            return InternalRequestAsync<ResetInstancesMaxBandwidthResponse>(req, "ResetInstancesMaxBandwidth");
        }

        /// <summary>
        /// This API is used to reset the bandwidth cap of an instance.
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesMaxBandwidthRequest"/></param>
        /// <returns><see cref="ResetInstancesMaxBandwidthResponse"/></returns>
        public ResetInstancesMaxBandwidthResponse ResetInstancesMaxBandwidthSync(ResetInstancesMaxBandwidthRequest req)
        {
            return InternalRequestAsync<ResetInstancesMaxBandwidthResponse>(req, "ResetInstancesMaxBandwidth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to reset the password for a running status. You need to explicitly specify the `ForceStop` parameter; otherwise, you can reset the password only for instances that have been shut down.
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesPasswordRequest"/></param>
        /// <returns><see cref="ResetInstancesPasswordResponse"/></returns>
        public Task<ResetInstancesPasswordResponse> ResetInstancesPassword(ResetInstancesPasswordRequest req)
        {
            return InternalRequestAsync<ResetInstancesPasswordResponse>(req, "ResetInstancesPassword");
        }

        /// <summary>
        /// This API is used to reset the password for a running status. You need to explicitly specify the `ForceStop` parameter; otherwise, you can reset the password only for instances that have been shut down.
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesPasswordRequest"/></param>
        /// <returns><see cref="ResetInstancesPasswordResponse"/></returns>
        public ResetInstancesPasswordResponse ResetInstancesPasswordSync(ResetInstancesPasswordRequest req)
        {
            return InternalRequestAsync<ResetInstancesPasswordResponse>(req, "ResetInstancesPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to reset a route table name and all routing policies.
        /// </summary>
        /// <param name="req"><see cref="ResetRoutesRequest"/></param>
        /// <returns><see cref="ResetRoutesResponse"/></returns>
        public Task<ResetRoutesResponse> ResetRoutes(ResetRoutesRequest req)
        {
            return InternalRequestAsync<ResetRoutesResponse>(req, "ResetRoutes");
        }

        /// <summary>
        /// This API is used to reset a route table name and all routing policies.
        /// </summary>
        /// <param name="req"><see cref="ResetRoutesRequest"/></param>
        /// <returns><see cref="ResetRoutesResponse"/></returns>
        public ResetRoutesResponse ResetRoutesSync(ResetRoutesRequest req)
        {
            return InternalRequestAsync<ResetRoutesResponse>(req, "ResetRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an ECM instance.
        /// </summary>
        /// <param name="req"><see cref="RunInstancesRequest"/></param>
        /// <returns><see cref="RunInstancesResponse"/></returns>
        public Task<RunInstancesResponse> RunInstances(RunInstancesRequest req)
        {
            return InternalRequestAsync<RunInstancesResponse>(req, "RunInstances");
        }

        /// <summary>
        /// This API is used to create an ECM instance.
        /// </summary>
        /// <param name="req"><see cref="RunInstancesRequest"/></param>
        /// <returns><see cref="RunInstancesResponse"/></returns>
        public RunInstancesResponse RunInstancesSync(RunInstancesRequest req)
        {
            return InternalRequestAsync<RunInstancesResponse>(req, "RunInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to configure security groups for a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="SetLoadBalancerSecurityGroupsRequest"/></param>
        /// <returns><see cref="SetLoadBalancerSecurityGroupsResponse"/></returns>
        public Task<SetLoadBalancerSecurityGroupsResponse> SetLoadBalancerSecurityGroups(SetLoadBalancerSecurityGroupsRequest req)
        {
            return InternalRequestAsync<SetLoadBalancerSecurityGroupsResponse>(req, "SetLoadBalancerSecurityGroups");
        }

        /// <summary>
        /// This API is used to configure security groups for a CLB instance.
        /// </summary>
        /// <param name="req"><see cref="SetLoadBalancerSecurityGroupsRequest"/></param>
        /// <returns><see cref="SetLoadBalancerSecurityGroupsResponse"/></returns>
        public SetLoadBalancerSecurityGroupsResponse SetLoadBalancerSecurityGroupsSync(SetLoadBalancerSecurityGroupsRequest req)
        {
            return InternalRequestAsync<SetLoadBalancerSecurityGroupsResponse>(req, "SetLoadBalancerSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bind or unbind a security group to or from multiple CLB instances.
        /// </summary>
        /// <param name="req"><see cref="SetSecurityGroupForLoadbalancersRequest"/></param>
        /// <returns><see cref="SetSecurityGroupForLoadbalancersResponse"/></returns>
        public Task<SetSecurityGroupForLoadbalancersResponse> SetSecurityGroupForLoadbalancers(SetSecurityGroupForLoadbalancersRequest req)
        {
            return InternalRequestAsync<SetSecurityGroupForLoadbalancersResponse>(req, "SetSecurityGroupForLoadbalancers");
        }

        /// <summary>
        /// This API is used to bind or unbind a security group to or from multiple CLB instances.
        /// </summary>
        /// <param name="req"><see cref="SetSecurityGroupForLoadbalancersRequest"/></param>
        /// <returns><see cref="SetSecurityGroupForLoadbalancersResponse"/></returns>
        public SetSecurityGroupForLoadbalancersResponse SetSecurityGroupForLoadbalancersSync(SetSecurityGroupForLoadbalancersRequest req)
        {
            return InternalRequestAsync<SetSecurityGroupForLoadbalancersResponse>(req, "SetSecurityGroupForLoadbalancers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to start an instance. Only instances in `STOPPED` status can be started. The instance status will become `STARTING` when this API is called successfully and will become `RUNNING` when the instance is started successfully.
        /// </summary>
        /// <param name="req"><see cref="StartInstancesRequest"/></param>
        /// <returns><see cref="StartInstancesResponse"/></returns>
        public Task<StartInstancesResponse> StartInstances(StartInstancesRequest req)
        {
            return InternalRequestAsync<StartInstancesResponse>(req, "StartInstances");
        }

        /// <summary>
        /// This API is used to start an instance. Only instances in `STOPPED` status can be started. The instance status will become `STARTING` when this API is called successfully and will become `RUNNING` when the instance is started successfully.
        /// </summary>
        /// <param name="req"><see cref="StartInstancesRequest"/></param>
        /// <returns><see cref="StartInstancesResponse"/></returns>
        public StartInstancesResponse StartInstancesSync(StartInstancesRequest req)
        {
            return InternalRequestAsync<StartInstancesResponse>(req, "StartInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Only instances in `RUNNING` status can be shut down.
        /// The instance status will become `STOPPING` when the API is called successfully and will become `STOPPED` when the instance is shut down successfully.
        /// Forced shutdown is supported. Just like powering off a physical PC, a forced shutdown may cause data loss or file system corruption. Make sure that you use this API only when the server cannot be shut down normally.
        /// </summary>
        /// <param name="req"><see cref="StopInstancesRequest"/></param>
        /// <returns><see cref="StopInstancesResponse"/></returns>
        public Task<StopInstancesResponse> StopInstances(StopInstancesRequest req)
        {
            return InternalRequestAsync<StopInstancesResponse>(req, "StopInstances");
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
            return InternalRequestAsync<StopInstancesResponse>(req, "StopInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to terminate an instance.
        /// </summary>
        /// <param name="req"><see cref="TerminateInstancesRequest"/></param>
        /// <returns><see cref="TerminateInstancesResponse"/></returns>
        public Task<TerminateInstancesResponse> TerminateInstances(TerminateInstancesRequest req)
        {
            return InternalRequestAsync<TerminateInstancesResponse>(req, "TerminateInstances");
        }

        /// <summary>
        /// This API is used to terminate an instance.
        /// </summary>
        /// <param name="req"><see cref="TerminateInstancesRequest"/></param>
        /// <returns><see cref="TerminateInstancesResponse"/></returns>
        public TerminateInstancesResponse TerminateInstancesSync(TerminateInstancesRequest req)
        {
            return InternalRequestAsync<TerminateInstancesResponse>(req, "TerminateInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
