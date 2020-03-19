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
        /// This API is used to apply for one or more [Elastic IP Addresses](https://cloud.tencent.com/document/product/213/1941) (EIPs for short).
        /// * An EIP is a static IP address that is dedicated for dynamic cloud computing. You can quickly re-map an EIP to another instance under your account to protect against instance failures.
        /// * Your EIP is associated with your Tencent Cloud account rather than an instance. It remains associated with your Tencent Cloud account until you choose to explicitly release it or your account is in arrears for more than 24 hours.
        /// * The maximum number of EIPs that can be applied for a Tencent Cloud account in each region is restricted. For more information, see [EIP Product Introduction](https://cloud.tencent.com/document/product/213/5733). You can get the quota information through the DescribeAddressQuota API.
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
        /// This API (AssignIpv6Addresses) is used to apply for an IPv6 address for the ENI.<br />
        /// This API is completed asynchronously. If you need to query the async execution results, use the `RequestId` returned by this API to query the `QueryTask` API.
        /// * An ENI can only be bound with a limited number of IPs. For more information about resource limits, see<a href="/document/product/576/18527">ENI use limits</a>.
        /// * You can specify the `IPv6` address when applying. The address type cannot be the primary `IP`. Currently, `IPv6` can only be supported as the secondary `IP`.
        /// * The address must be unoccupied and is in the subnet to which the ENI belongs.
        /// * When applying for one to multiple secondary `IPv6` addresses on ENI, the API will return the specified number of secondary `IPv6` addresses in the subnet range where the ENI is located.
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
        /// This API is used to assign IPv6 ranges.
        /// * To use this API, you must already have a VPC instance. If you do not have a VPC instance yet, use the <a href="https://cloud.tencent.com/document/api/215/15774" title="CreateVpc" target="_blank">CreateVpc</a> API to create one.
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
        /// This API (AssociateAddress) is used to bind an [Elastic IP](https://cloud.tencent.com/document/product/213/1941) (EIP for short) to the specified private IP of an instance or ENI.
        /// * Essentially, binding an EIP to an instance (CVM) means binding an EIP to the primary private IP of the primary ENI on an instance.
        /// * When you bind an EIP to the primary private IP of the primary ENI, the previously bound public IP is automatically unbound and released.
        /// * To bind the EIP to the private IP of the specified ENI (not the primary private IP of the primary ENI), you must unbind the EIP before you can bind a new one.
        /// * To bind the EIP to a NAT gateway, use the API [EipBindNatGateway](https://cloud.tencent.com/document/product/215/4093)
        /// * EIP that is in arrears or blocked cannot be bound.
        /// * Only EIP in the UNBIND status can be bound.
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
        /// This API (AttachClassicLinkVpc) is used to create a Classiclink between a VPC and a basic network device.
        /// * The VPC and the basic network device must be in the same region.
        /// * For the difference between VPCs and basic networks, see VPC product documentation-<a href="https://cloud.tencent.com/document/product/215/535#2.-.E7.A7.81.E6.9C.89.E7.BD.91.E7.BB.9C.E4.B8.8E.E5.9F.BA.E7.A1.80.E7.BD.91.E7.BB.9C">VPCs and basic networks</a>.
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
        /// This API (AttachNetworkInterface) is used to bind an ENI to a CVM.
        /// * One CVM can be bound to multiple ENIs, but only one primary ENI. For more information on the limits, see <a href="https://cloud.tencent.com/document/product/215/6513">ENI use limits</a>.
        /// * An ENI can only be bound to one CVM at a time.
        /// * Only CVMs in running or shutdown status can be bound to an ENI. For more information about CVM status, see <a href="https://cloud.tencent.com/document/api/213/9452#instance_state">Tencent CVM information</a>.
        /// * An ENI can only be bound to a CVM in VPC, and the CVM must reside in the same availability zone as the subnet of the ENI.
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
        /// This API (CreateAddressTemplate) is used to create an IP address template.
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
        /// This API (CreateAddressTemplateGroup) is used to create an IP address template group.
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
        /// This API (CreateCcn) is used to create a Cloud Connect Network (CCN).<br />
        /// Each account can only create a limited number of CCN instances. For more information, see the product documentation. If you need to create more instances, please contact the online customer service.
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
        /// This API (CreateNatGateway) is used to create a NAT gateway.
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
        /// This API (CreateNatGatewayDestinationIpPortTranslationNatRule) is used to create a port forwarding rule for a NAT gateway.
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
        /// This API is used to create one or more ENIs.
        /// * You can specify private IP addresses and a primary IP when creating an ENI. The specified private IP must be in the same subnet as the ENI and is not occupied.
        /// * When creating an ENI, you can specify the number of private IP addresses that you want to apply for. The system will randomly generate private IP addresses.
        /// * An ENI can only be bound with a limited number of IP addresses. For more information about resource limits, see <a href="/document/product/576/18527">ENI Use Limits</a>.
        /// * You can bind an existing security group when creating an ENI.
        /// * You can bind a tag when creating an ENI. The tag list in the response indicates the tags that have been successfully added.
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
        /// This API (CreateRouteTable) is used to create a route table.
        /// * After the VPC has been created, the system will create a default route table with which all newly created subnets will be associated. By default, you can use this route table to manage your routing policies. If you have multiple routing policies, you can call the API for creating route table to create more route tables to manage your routing policies.
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
        /// This API (CreateSecurityGroup) is used to create security groups (SecurityGroup).
        /// * <a href="https://cloud.tencent.com/document/product/213/500#2.-.E5.AE.89.E5.85.A8.E7.BB.84.E7.9A.84.E9.99.90.E5.88.B6">Security group limits</a> for each project in each region under each account.
        /// * Both the inbound and outbound rules for a newly created security group are Deny All by default. You need to call CreateSecurityGroupPolicies to set the security group rules according to your needs.
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
        /// This API is used to create security group policies (SecurityGroupPolicy).
        /// 
        /// * The `Version` field indicates the version number of a security group policy, which will automatically increment by 1 every time you update the security policy, to prevent the expiration of the updated routing policies. If this field is left empty, any conflicts will be ignored.
        /// * The value of the `Protocol` field can be TCP, UDP, ICMP, ICMPV6, GRE, or ALL.
        /// * The `CidrBlock` field allows you to enter any string that conforms to the CIDR format. (More details) In a basic network, if a CidrBlock contains private IP addresses on Tencent Cloud for devices under your account other than CVMs, it does not mean this policy allows you to access these devices. The network isolation policies between tenants take priority over the private network policies in security groups.
        /// * The `Ipv6CidrBlock` field allows you to enter any string that conforms to the IPv6 CIDR format. (More details) In a basic network, if an Ipv6CidrBlock contains private IPv6 addresses on Tencent Cloud for devices under your account other than CVMs, it does not mean this policy allows you to access these devices. The network isolation policies between tenants take priority over the private network policies in security groups.
        /// * The SecurityGroupId field allows you to enter the IDs of security groups that are in the same project as the security group to be modified, including the ID of the security group itself, to represent private IP addresses of all CVMs under the security group. If this field is used, the policy will change without manual modification according to the CVM associated with the policy ID while being used to match network messages.
        /// * The Port field allows you to enter a single port number, or two port numbers separated by a minus sign to represent a port range, such as 80 or 8000-8010. The Port field is accepted only if the value of the Protocol field is TCP or UDP. In other words, if the value of the Protocol field is not TCP or UDP, Protocol and Port are exclusive and cannot be entered at the same time, otherwise an error will occur with the API.
        /// * The Action field only allows you to enter ACCEPT or DROP.
        /// * CidrBlock, Ipv6CidrBlock, SecurityGroupId, and AddressTemplate are exclusive and cannot be entered at the same time. Protocol + Port and ServiceTemplate are mutually exclusive and cannot be entered at the same time.
        /// * Only policies in one direction can be created in each request. If you need to specify the PolicyIndex parameter, the indexes of policies must be consistent.
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
        /// This API (CreateSubnet) is used to create subnets.
        /// * You must create a VPC before creating a subnet.
        /// * After the subnet is successfully created, its IP address range cannot be modified. The subnet IP address range must fall within the VPC IP address range. They can be the same if the VPC has only one subnet. We recommend that you keep the subnet IP address range within the VPC IP address range to reserve IP address ranges for other subnets.
        /// * The subnet mask of the smallest IP address range that can be created is 28 (16 IP addresses), and that of the largest IP address range is 16 (65,536 IP addresses).
        /// * IP address ranges of different subnets cannot overlap with each other within the same VPC.
        /// * A subnet is automatically associated with the default route table once created.
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
        /// This API (CreateSubnets) is used to create subnets in batches.
        /// * You must create a VPC before creating a subnet.
        /// * After the subnet is successfully created, its IP address range cannot be modified. The subnet IP address range must fall within the VPC IP address range. They can be the same if the VPC has only one subnet. We recommend that you keep the subnet IP address range within the VPC IP address range to reserve IP address ranges for other subnets.
        /// * The subnet mask of the smallest IP address range that can be created is 28 (16 IP addresses), and that of the largest IP address range is 16 (65,536 IP addresses).
        /// * IP address ranges of different subnets cannot overlap with each other within the same VPC.
        /// * A subnet is automatically associated with the default route table once created.
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
        /// This API (CreateVpc) is used to create a VPC.
        /// * The subnet mask of the smallest IP address range that can be created is 28 (16 IP addresses), and that of the largest IP address range is 16 (65,536 IP addresses). For more information, please see corresponding documents about VPC IP address ranges.
        /// * The number of VPCs that can be created in a region is limited. For more information, please see <a href="https://intl.cloud.tencent.com/doc/product/215/537" title="VPC use limits">VPC use limits</a>. To request more resources, please contact the online customer service.
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
        /// This API (CreateVpnConnection) is used to create VPN tunnel.
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
        /// This API (DeleteHaVip) is used to delete Highly Available Virtual IP (HAVIP)<br />
        /// This API is completed asynchronously. If you need to query the async job execution results, please use the `RequestId` returned by this API to query the `QueryTask` API.
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
        /// This API (DeleteNatGateway) is used to delete a NAT gateway.
        /// After the deletion of a NAT gateway, the system will automatically delete the routing entry that contains the NAT gateway from the route table. It will also unbind the Elastic IP.
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
        /// This API (DeleteNatGatewayDestinationIpPortTranslationNatRule) is used to delete a port forwarding rule for a NAT gateway.
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
        /// This API (DeleteNetworkInterface) is used to delete ENIs.
        /// * An ENI that has been bound to a CVM cannot be deleted.
        /// * An ENI can be deleted only after being unbound from the server. After the deletion, all private IP addresses associated with the ENI will be released.
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
        /// This API (DescribeAddressQuota) is used to query the quota information of your [Elastic IP](https://cloud.tencent.com/document/product/213/1941) (EIP) in the current region. For more information, see [EIP product introduction](https://cloud.tencent.com/document/product/213/5733).
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
        /// This API (DescribeAddresses) is used to query the information of one or multiple [Elastic IPs](https://cloud.tencent.com/document/product/213/1941).
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
        /// This API (DescribeGatewayFlowMonitorDetail) is used to query the monitoring details of the gateway traffic.
        /// * Only querying of a single gateway instance is supported. That is, only one of the `VpnId`, `DirectConnectGatewayId`, `PeeringConnectionId`, or `NatId` input parameters is supported, and one must be used.
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
        /// This API (DescribeNatGatewayDestinationIpPortTranslationNatRules) is used to query the array of objects of the port forwarding rules for a NAT gateway.
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
        /// This API (DescribeNatGateways) is used to query NAT gateways.
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
        /// This API (DescribeNetworkInterfaceLimit) is used to query the ENI quota based on the CVM instance ID. It returns the ENI quota to which the CVM instance can be bound and the IP address quota that can be allocated to each ENI.
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
        /// This API (DetachClassicLinkVpc) is used to delete a Classiclink.
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
        /// This API (DetachNetworkInterface) is used to unbind an ENI from a CVM.
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
        /// This API (DisassociateAddress) is used to unbind [Elastic IPs](https://cloud.tencent.com/document/product/213/1941).
        /// * The unbinding of EIPs from CVM instances and ENIs is supported.
        /// * The unbinding of EIPs from NATs is not supported. For information about how to unbind an EIP from a NAT, see [EipUnBindNatGateway](https://cloud.tencent.com/document/product/215/4092).
        /// * You can only unbind EIPs in BIND or BIND_ENI status.
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
        /// This API (DisassociateNatGatewayAddress) is used to unbind an EIP from a NAT gateway.
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
        /// This API (HaVipAssociateAddressIp) is used to bind an EIP to an HAVIP.<br />
        /// This API is completed asynchronously. If you need to query the async job execution results, please use the `RequestId` returned by this API to query the `QueryTask` API.
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
        /// This API (HaVipDisassociateAddressIp) is used to unbind an EIP which has been bound to an HAVIP.<br />
        /// This API is completed asynchronously. If you need to query the async job execution results, please use the `RequestId` returned by this API to query the `QueryTask` API.
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
        /// This API (InquiryPriceCreateVpnGateway) is used to query the price for VPN gateway creation.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateVpnGatewayRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateVpnGatewayResponse"/></returns>
        public async Task<InquiryPriceCreateVpnGatewayResponse> InquiryPriceCreateVpnGateway(InquiryPriceCreateVpnGatewayRequest req)
        {
             JsonResponseModel<InquiryPriceCreateVpnGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceCreateVpnGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceCreateVpnGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (MigrateNetworkInterface) is used to migrate ENIs.
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
        ///  This API (MigratePrivateIpAddress) is used to migrate the private IPs of ENIs.
        /// 
        /// * This API is used to migrate a private IP from one ENI to another. Primary IPs cannot be migrated.
        /// * The ENIs before and after migration must belong to the same subnet.
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
        /// This API (ModifyAddressAttribute) is used to modify the name of an [Elastic IP](https://cloud.tencent.com/document/product/213/1941).
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
        /// This API (ModifyAddressesBandwidth) is used to adjust [Elastic IP](https://cloud.tencent.com/document/product/213/1941) bandwidth, including the postpaid EIP, prepaid EIP and bandwidth package EIP.
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
        /// This API (ModifyCcnRegionBandwidthlimitsType) is used to modify the bandwidth limits policy of the postpaid Ccn instances.
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
        /// This API (ModifyNatGatewayAttribute) is used to modify the attributes of a NAT gateway.
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
        /// This API (ModifyNatGatewayDestinationIpPortTranslationNatRule) is used to modify a port forwarding rule for a NAT gateway.
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
        /// This API (ModifySecurityGroupPolicies) is used to reset the egress and ingress policies (SecurityGroupPolicy) of a security group.
        /// 
        /// * This API deletes all the current egress and ingress policies, and then adds new Egress and Ingress policies. It does not support custom PolicyIndex indexes.
        /// * If SecurityGroupPolicySet.Version is set to 0, all policies will be cleared, and Egress and Ingress will be ignored.
        /// * The value of the Protocol field can be TCP, UDP, ICMP, ICMPV6, GRE, or ALL.
        /// * The CidrBlock field allows you to enter any string that conforms to the CIDR format. (More details) In a basic network, if a CidrBlock contains private IP addresses on Tencent Cloud for devices under your account other than CVMs, it does not mean this policy allows you to access these devices. The network isolation policies between tenants take priority over the private network policies in security groups.
        /// * The Ipv6CidrBlock field allows you to enter any string that conforms to the IPv6 CIDR format. (More details) In a basic network, if an Ipv6CidrBlock contains private IPv6 addresses on Tencent Cloud for devices under your account other than CVMs, it does not mean this policy allows you to access these devices. The network isolation policies between tenants take priority over the private network policies in security groups.
        /// * The SecurityGroupId field allows you to enter the IDs of security groups that are in the same project as the security group to be modified, including the ID of the security group itself, to represent private IP addresses of all CVMs under the security group. If this field is used, this policy will change without manual modification according to the CVM associated with the policy ID while being used to match network messages.
        /// * The Port field allows you to enter a single port number, or two port numbers separated by a minus sign to represent a port range, such as 80 or 8000-8010. The Port field can be used only when the value of the Protocol field is TCP or UDP.
        /// * The Action field only allows you to enter ACCEPT or DROP.
        /// * CidrBlock, Ipv6CidrBlock, SecurityGroupId, and AddressTemplate are exclusive and cannot be entered at the same time. Protocol + Port and ServiceTemplate are mutually exclusive and cannot be entered at the same time.
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
        /// This API (ReleaseAddresses) is used to release one or multiple [Elastic IPs](https://cloud.tencent.com/document/product/213/1941).
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
        /// This API (ResetNatGatewayConnection) is used to adjust concurrent connection cap for the NAT gateway.
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
        /// This API (TransformAddress) is used to switch common public IPs into [Elastic IPs](https://cloud.tencent.com/document/product/213/1941).
        /// * The platform limits the number of times that a user can unbind an EIP and reassign public IPs in each region per day. For more information, see [EIP product introduction](/document/product/213/1941)). The preceding quota can be obtained through the [DescribeAddressQuota](https://cloud.tencent.com/document/api/213/1378) API.
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
        /// This API (UnassignIpv6Addresses) is used to release ENI `IPv6` addresses.<br />
        /// This API is completed asynchronously. If you need to query the async execution results, use the `RequestId` returned by this API to query the `QueryTask` API.
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
        /// This API (UnassignPrivateIpAddresses) is used to return the private IPs of ENI.
        /// * To return the secondary private IPs of an ENI, the API will automatically unbind the IPs of an ENI. The primary private IP of the ENI cannot be returned.
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

    }
}
