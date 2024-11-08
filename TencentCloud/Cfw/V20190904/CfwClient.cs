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

namespace TencentCloud.Cfw.V20190904
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cfw.V20190904.Models;

   public class CfwClient : AbstractClient{

       private const string endpoint = "cfw.tencentcloudapi.com";
       private const string version = "2019-09-04";
       private const string sdkVersion = "SDK_NET_3.0.1011";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CfwClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CfwClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to add edge firewall rules.
        /// </summary>
        /// <param name="req"><see cref="AddAcRuleRequest"/></param>
        /// <returns><see cref="AddAcRuleResponse"/></returns>
        public Task<AddAcRuleResponse> AddAcRule(AddAcRuleRequest req)
        {
            return InternalRequestAsync<AddAcRuleResponse>(req, "AddAcRule");
        }

        /// <summary>
        /// This API is used to add edge firewall rules.
        /// </summary>
        /// <param name="req"><see cref="AddAcRuleRequest"/></param>
        /// <returns><see cref="AddAcRuleResponse"/></returns>
        public AddAcRuleResponse AddAcRuleSync(AddAcRuleRequest req)
        {
            return InternalRequestAsync<AddAcRuleResponse>(req, "AddAcRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create enterprise security group rules (new).
        /// </summary>
        /// <param name="req"><see cref="AddEnterpriseSecurityGroupRulesRequest"/></param>
        /// <returns><see cref="AddEnterpriseSecurityGroupRulesResponse"/></returns>
        public Task<AddEnterpriseSecurityGroupRulesResponse> AddEnterpriseSecurityGroupRules(AddEnterpriseSecurityGroupRulesRequest req)
        {
            return InternalRequestAsync<AddEnterpriseSecurityGroupRulesResponse>(req, "AddEnterpriseSecurityGroupRules");
        }

        /// <summary>
        /// This API is used to create enterprise security group rules (new).
        /// </summary>
        /// <param name="req"><see cref="AddEnterpriseSecurityGroupRulesRequest"/></param>
        /// <returns><see cref="AddEnterpriseSecurityGroupRulesResponse"/></returns>
        public AddEnterpriseSecurityGroupRulesResponse AddEnterpriseSecurityGroupRulesSync(AddEnterpriseSecurityGroupRulesRequest req)
        {
            return InternalRequestAsync<AddEnterpriseSecurityGroupRulesResponse>(req, "AddEnterpriseSecurityGroupRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add NAT access control rules.
        /// </summary>
        /// <param name="req"><see cref="AddNatAcRuleRequest"/></param>
        /// <returns><see cref="AddNatAcRuleResponse"/></returns>
        public Task<AddNatAcRuleResponse> AddNatAcRule(AddNatAcRuleRequest req)
        {
            return InternalRequestAsync<AddNatAcRuleResponse>(req, "AddNatAcRule");
        }

        /// <summary>
        /// This API is used to add NAT access control rules.
        /// </summary>
        /// <param name="req"><see cref="AddNatAcRuleRequest"/></param>
        /// <returns><see cref="AddNatAcRuleResponse"/></returns>
        public AddNatAcRuleResponse AddNatAcRuleSync(AddNatAcRuleRequest req)
        {
            return InternalRequestAsync<AddNatAcRuleResponse>(req, "AddNatAcRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create access control rules.
        /// </summary>
        /// <param name="req"><see cref="CreateAcRulesRequest"/></param>
        /// <returns><see cref="CreateAcRulesResponse"/></returns>
        public Task<CreateAcRulesResponse> CreateAcRules(CreateAcRulesRequest req)
        {
            return InternalRequestAsync<CreateAcRulesResponse>(req, "CreateAcRules");
        }

        /// <summary>
        /// This API is used to create access control rules.
        /// </summary>
        /// <param name="req"><see cref="CreateAcRulesRequest"/></param>
        /// <returns><see cref="CreateAcRulesResponse"/></returns>
        public CreateAcRulesResponse CreateAcRulesSync(CreateAcRulesRequest req)
        {
            return InternalRequestAsync<CreateAcRulesResponse>(req, "CreateAcRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a NAT firewall instance (The Region parameter is required).
        /// </summary>
        /// <param name="req"><see cref="CreateNatFwInstanceRequest"/></param>
        /// <returns><see cref="CreateNatFwInstanceResponse"/></returns>
        public Task<CreateNatFwInstanceResponse> CreateNatFwInstance(CreateNatFwInstanceRequest req)
        {
            return InternalRequestAsync<CreateNatFwInstanceResponse>(req, "CreateNatFwInstance");
        }

        /// <summary>
        /// This API is used to create a NAT firewall instance (The Region parameter is required).
        /// </summary>
        /// <param name="req"><see cref="CreateNatFwInstanceRequest"/></param>
        /// <returns><see cref="CreateNatFwInstanceResponse"/></returns>
        public CreateNatFwInstanceResponse CreateNatFwInstanceSync(CreateNatFwInstanceRequest req)
        {
            return InternalRequestAsync<CreateNatFwInstanceResponse>(req, "CreateNatFwInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a firewall instance with domain name (The Region parameter is required).
        /// </summary>
        /// <param name="req"><see cref="CreateNatFwInstanceWithDomainRequest"/></param>
        /// <returns><see cref="CreateNatFwInstanceWithDomainResponse"/></returns>
        public Task<CreateNatFwInstanceWithDomainResponse> CreateNatFwInstanceWithDomain(CreateNatFwInstanceWithDomainRequest req)
        {
            return InternalRequestAsync<CreateNatFwInstanceWithDomainResponse>(req, "CreateNatFwInstanceWithDomain");
        }

        /// <summary>
        /// This API is used to create a firewall instance with domain name (The Region parameter is required).
        /// </summary>
        /// <param name="req"><see cref="CreateNatFwInstanceWithDomainRequest"/></param>
        /// <returns><see cref="CreateNatFwInstanceWithDomainResponse"/></returns>
        public CreateNatFwInstanceWithDomainResponse CreateNatFwInstanceWithDomainSync(CreateNatFwInstanceWithDomainRequest req)
        {
            return InternalRequestAsync<CreateNatFwInstanceWithDomainResponse>(req, "CreateNatFwInstanceWithDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create enterprise security group rules.
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityGroupRulesRequest"/></param>
        /// <returns><see cref="CreateSecurityGroupRulesResponse"/></returns>
        public Task<CreateSecurityGroupRulesResponse> CreateSecurityGroupRules(CreateSecurityGroupRulesRequest req)
        {
            return InternalRequestAsync<CreateSecurityGroupRulesResponse>(req, "CreateSecurityGroupRules");
        }

        /// <summary>
        /// This API is used to create enterprise security group rules.
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityGroupRulesRequest"/></param>
        /// <returns><see cref="CreateSecurityGroupRulesResponse"/></returns>
        public CreateSecurityGroupRulesResponse CreateSecurityGroupRulesSync(CreateSecurityGroupRulesRequest req)
        {
            return InternalRequestAsync<CreateSecurityGroupRulesResponse>(req, "CreateSecurityGroupRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteAcRuleRequest"/></param>
        /// <returns><see cref="DeleteAcRuleResponse"/></returns>
        public Task<DeleteAcRuleResponse> DeleteAcRule(DeleteAcRuleRequest req)
        {
            return InternalRequestAsync<DeleteAcRuleResponse>(req, "DeleteAcRule");
        }

        /// <summary>
        /// This API is used to delete a rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteAcRuleRequest"/></param>
        /// <returns><see cref="DeleteAcRuleResponse"/></returns>
        public DeleteAcRuleResponse DeleteAcRuleSync(DeleteAcRuleRequest req)
        {
            return InternalRequestAsync<DeleteAcRuleResponse>(req, "DeleteAcRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete all rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteAllAccessControlRuleRequest"/></param>
        /// <returns><see cref="DeleteAllAccessControlRuleResponse"/></returns>
        public Task<DeleteAllAccessControlRuleResponse> DeleteAllAccessControlRule(DeleteAllAccessControlRuleRequest req)
        {
            return InternalRequestAsync<DeleteAllAccessControlRuleResponse>(req, "DeleteAllAccessControlRule");
        }

        /// <summary>
        /// This API is used to delete all rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteAllAccessControlRuleRequest"/></param>
        /// <returns><see cref="DeleteAllAccessControlRuleResponse"/></returns>
        public DeleteAllAccessControlRuleResponse DeleteAllAccessControlRuleSync(DeleteAllAccessControlRuleRequest req)
        {
            return InternalRequestAsync<DeleteAllAccessControlRuleResponse>(req, "DeleteAllAccessControlRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete asset groups in Asset Management.
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceGroupRequest"/></param>
        /// <returns><see cref="DeleteResourceGroupResponse"/></returns>
        public Task<DeleteResourceGroupResponse> DeleteResourceGroup(DeleteResourceGroupRequest req)
        {
            return InternalRequestAsync<DeleteResourceGroupResponse>(req, "DeleteResourceGroup");
        }

        /// <summary>
        /// This API is used to delete asset groups in Asset Management.
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceGroupRequest"/></param>
        /// <returns><see cref="DeleteResourceGroupResponse"/></returns>
        public DeleteResourceGroupResponse DeleteResourceGroupSync(DeleteResourceGroupRequest req)
        {
            return InternalRequestAsync<DeleteResourceGroupResponse>(req, "DeleteResourceGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete security group rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityGroupRuleRequest"/></param>
        /// <returns><see cref="DeleteSecurityGroupRuleResponse"/></returns>
        public Task<DeleteSecurityGroupRuleResponse> DeleteSecurityGroupRule(DeleteSecurityGroupRuleRequest req)
        {
            return InternalRequestAsync<DeleteSecurityGroupRuleResponse>(req, "DeleteSecurityGroupRule");
        }

        /// <summary>
        /// This API is used to delete security group rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityGroupRuleRequest"/></param>
        /// <returns><see cref="DeleteSecurityGroupRuleResponse"/></returns>
        public DeleteSecurityGroupRuleResponse DeleteSecurityGroupRuleSync(DeleteSecurityGroupRuleRequest req)
        {
            return InternalRequestAsync<DeleteSecurityGroupRuleResponse>(req, "DeleteSecurityGroupRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete firewall instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcInstanceRequest"/></param>
        /// <returns><see cref="DeleteVpcInstanceResponse"/></returns>
        public Task<DeleteVpcInstanceResponse> DeleteVpcInstance(DeleteVpcInstanceRequest req)
        {
            return InternalRequestAsync<DeleteVpcInstanceResponse>(req, "DeleteVpcInstance");
        }

        /// <summary>
        /// This API is used to delete firewall instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcInstanceRequest"/></param>
        /// <returns><see cref="DeleteVpcInstanceResponse"/></returns>
        public DeleteVpcInstanceResponse DeleteVpcInstanceSync(DeleteVpcInstanceRequest req)
        {
            return InternalRequestAsync<DeleteVpcInstanceResponse>(req, "DeleteVpcInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the access control list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAcListsRequest"/></param>
        /// <returns><see cref="DescribeAcListsResponse"/></returns>
        public Task<DescribeAcListsResponse> DescribeAcLists(DescribeAcListsRequest req)
        {
            return InternalRequestAsync<DescribeAcListsResponse>(req, "DescribeAcLists");
        }

        /// <summary>
        /// This API is used to get the access control list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAcListsRequest"/></param>
        /// <returns><see cref="DescribeAcListsResponse"/></returns>
        public DescribeAcListsResponse DescribeAcListsSync(DescribeAcListsRequest req)
        {
            return InternalRequestAsync<DescribeAcListsResponse>(req, "DescribeAcLists")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of instances associated with a security group.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssociatedInstanceListRequest"/></param>
        /// <returns><see cref="DescribeAssociatedInstanceListResponse"/></returns>
        public Task<DescribeAssociatedInstanceListResponse> DescribeAssociatedInstanceList(DescribeAssociatedInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeAssociatedInstanceListResponse>(req, "DescribeAssociatedInstanceList");
        }

        /// <summary>
        /// This API is used to get the list of instances associated with a security group.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssociatedInstanceListRequest"/></param>
        /// <returns><see cref="DescribeAssociatedInstanceListResponse"/></returns>
        public DescribeAssociatedInstanceListResponse DescribeAssociatedInstanceListSync(DescribeAssociatedInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeAssociatedInstanceListResponse>(req, "DescribeAssociatedInstanceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get blocked IP data.
        /// </summary>
        /// <param name="req"><see cref="DescribeBlockByIpTimesListRequest"/></param>
        /// <returns><see cref="DescribeBlockByIpTimesListResponse"/></returns>
        public Task<DescribeBlockByIpTimesListResponse> DescribeBlockByIpTimesList(DescribeBlockByIpTimesListRequest req)
        {
            return InternalRequestAsync<DescribeBlockByIpTimesListResponse>(req, "DescribeBlockByIpTimesList");
        }

        /// <summary>
        /// This API is used to get blocked IP data.
        /// </summary>
        /// <param name="req"><see cref="DescribeBlockByIpTimesListRequest"/></param>
        /// <returns><see cref="DescribeBlockByIpTimesListResponse"/></returns>
        public DescribeBlockByIpTimesListResponse DescribeBlockByIpTimesListSync(DescribeBlockByIpTimesListRequest req)
        {
            return InternalRequestAsync<DescribeBlockByIpTimesListResponse>(req, "DescribeBlockByIpTimesList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get allowlists or blocklists for intrusion prevention.
        /// </summary>
        /// <param name="req"><see cref="DescribeBlockIgnoreListRequest"/></param>
        /// <returns><see cref="DescribeBlockIgnoreListResponse"/></returns>
        public Task<DescribeBlockIgnoreListResponse> DescribeBlockIgnoreList(DescribeBlockIgnoreListRequest req)
        {
            return InternalRequestAsync<DescribeBlockIgnoreListResponse>(req, "DescribeBlockIgnoreList");
        }

        /// <summary>
        /// This API is used to get allowlists or blocklists for intrusion prevention.
        /// </summary>
        /// <param name="req"><see cref="DescribeBlockIgnoreListRequest"/></param>
        /// <returns><see cref="DescribeBlockIgnoreListResponse"/></returns>
        public DescribeBlockIgnoreListResponse DescribeBlockIgnoreListSync(DescribeBlockIgnoreListRequest req)
        {
            return InternalRequestAsync<DescribeBlockIgnoreListResponse>(req, "DescribeBlockIgnoreList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the most frequent attacker.
        /// </summary>
        /// <param name="req"><see cref="DescribeBlockStaticListRequest"/></param>
        /// <returns><see cref="DescribeBlockStaticListResponse"/></returns>
        public Task<DescribeBlockStaticListResponse> DescribeBlockStaticList(DescribeBlockStaticListRequest req)
        {
            return InternalRequestAsync<DescribeBlockStaticListResponse>(req, "DescribeBlockStaticList");
        }

        /// <summary>
        /// This API is used to get the most frequent attacker.
        /// </summary>
        /// <param name="req"><see cref="DescribeBlockStaticListRequest"/></param>
        /// <returns><see cref="DescribeBlockStaticListResponse"/></returns>
        public DescribeBlockStaticListResponse DescribeBlockStaticListSync(DescribeBlockStaticListRequest req)
        {
            return InternalRequestAsync<DescribeBlockStaticListResponse>(req, "DescribeBlockStaticList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of firewall toggles with Intrusion Defense enabled.
        /// </summary>
        /// <param name="req"><see cref="DescribeDefenseSwitchRequest"/></param>
        /// <returns><see cref="DescribeDefenseSwitchResponse"/></returns>
        public Task<DescribeDefenseSwitchResponse> DescribeDefenseSwitch(DescribeDefenseSwitchRequest req)
        {
            return InternalRequestAsync<DescribeDefenseSwitchResponse>(req, "DescribeDefenseSwitch");
        }

        /// <summary>
        /// This API is used to query the list of firewall toggles with Intrusion Defense enabled.
        /// </summary>
        /// <param name="req"><see cref="DescribeDefenseSwitchRequest"/></param>
        /// <returns><see cref="DescribeDefenseSwitchResponse"/></returns>
        public DescribeDefenseSwitchResponse DescribeDefenseSwitchSync(DescribeDefenseSwitchRequest req)
        {
            return InternalRequestAsync<DescribeDefenseSwitchResponse>(req, "DescribeDefenseSwitch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get enterprise security group rules (new).
        /// </summary>
        /// <param name="req"><see cref="DescribeEnterpriseSecurityGroupRuleRequest"/></param>
        /// <returns><see cref="DescribeEnterpriseSecurityGroupRuleResponse"/></returns>
        public Task<DescribeEnterpriseSecurityGroupRuleResponse> DescribeEnterpriseSecurityGroupRule(DescribeEnterpriseSecurityGroupRuleRequest req)
        {
            return InternalRequestAsync<DescribeEnterpriseSecurityGroupRuleResponse>(req, "DescribeEnterpriseSecurityGroupRule");
        }

        /// <summary>
        /// This API is used to get enterprise security group rules (new).
        /// </summary>
        /// <param name="req"><see cref="DescribeEnterpriseSecurityGroupRuleRequest"/></param>
        /// <returns><see cref="DescribeEnterpriseSecurityGroupRuleResponse"/></returns>
        public DescribeEnterpriseSecurityGroupRuleResponse DescribeEnterpriseSecurityGroupRuleSync(DescribeEnterpriseSecurityGroupRuleRequest req)
        {
            return InternalRequestAsync<DescribeEnterpriseSecurityGroupRuleResponse>(req, "DescribeEnterpriseSecurityGroupRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the scan interface information in Get Started.
        /// </summary>
        /// <param name="req"><see cref="DescribeGuideScanInfoRequest"/></param>
        /// <returns><see cref="DescribeGuideScanInfoResponse"/></returns>
        public Task<DescribeGuideScanInfoResponse> DescribeGuideScanInfo(DescribeGuideScanInfoRequest req)
        {
            return InternalRequestAsync<DescribeGuideScanInfoResponse>(req, "DescribeGuideScanInfo");
        }

        /// <summary>
        /// This API is used to get the scan interface information in Get Started.
        /// </summary>
        /// <param name="req"><see cref="DescribeGuideScanInfoRequest"/></param>
        /// <returns><see cref="DescribeGuideScanInfoResponse"/></returns>
        public DescribeGuideScanInfoResponse DescribeGuideScanInfoSync(DescribeGuideScanInfoRequest req)
        {
            return InternalRequestAsync<DescribeGuideScanInfoResponse>(req, "DescribeGuideScanInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the IP protection status.
        /// </summary>
        /// <param name="req"><see cref="DescribeIPStatusListRequest"/></param>
        /// <returns><see cref="DescribeIPStatusListResponse"/></returns>
        public Task<DescribeIPStatusListResponse> DescribeIPStatusList(DescribeIPStatusListRequest req)
        {
            return InternalRequestAsync<DescribeIPStatusListResponse>(req, "DescribeIPStatusList");
        }

        /// <summary>
        /// This API is used to get the IP protection status.
        /// </summary>
        /// <param name="req"><see cref="DescribeIPStatusListRequest"/></param>
        /// <returns><see cref="DescribeIPStatusListResponse"/></returns>
        public DescribeIPStatusListResponse DescribeIPStatusListSync(DescribeIPStatusListRequest req)
        {
            return InternalRequestAsync<DescribeIPStatusListResponse>(req, "DescribeIPStatusList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the NAT access control list.
        /// </summary>
        /// <param name="req"><see cref="DescribeNatAcRuleRequest"/></param>
        /// <returns><see cref="DescribeNatAcRuleResponse"/></returns>
        public Task<DescribeNatAcRuleResponse> DescribeNatAcRule(DescribeNatAcRuleRequest req)
        {
            return InternalRequestAsync<DescribeNatAcRuleResponse>(req, "DescribeNatAcRule");
        }

        /// <summary>
        /// This API is used to get the NAT access control list.
        /// </summary>
        /// <param name="req"><see cref="DescribeNatAcRuleRequest"/></param>
        /// <returns><see cref="DescribeNatAcRuleResponse"/></returns>
        public DescribeNatAcRuleResponse DescribeNatAcRuleSync(DescribeNatAcRuleRequest req)
        {
            return InternalRequestAsync<DescribeNatAcRuleResponse>(req, "DescribeNatAcRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the number of a user's subnets connected to NAT firewall and the number of NAT firewall instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeNatFwInfoCountRequest"/></param>
        /// <returns><see cref="DescribeNatFwInfoCountResponse"/></returns>
        public Task<DescribeNatFwInfoCountResponse> DescribeNatFwInfoCount(DescribeNatFwInfoCountRequest req)
        {
            return InternalRequestAsync<DescribeNatFwInfoCountResponse>(req, "DescribeNatFwInfoCount");
        }

        /// <summary>
        /// This API is used to get the number of a user's subnets connected to NAT firewall and the number of NAT firewall instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeNatFwInfoCountRequest"/></param>
        /// <returns><see cref="DescribeNatFwInfoCountResponse"/></returns>
        public DescribeNatFwInfoCountResponse DescribeNatFwInfoCountSync(DescribeNatFwInfoCountRequest req)
        {
            return InternalRequestAsync<DescribeNatFwInfoCountResponse>(req, "DescribeNatFwInfoCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get all NAT instances of a tenant.
        /// </summary>
        /// <param name="req"><see cref="DescribeNatFwInstanceRequest"/></param>
        /// <returns><see cref="DescribeNatFwInstanceResponse"/></returns>
        public Task<DescribeNatFwInstanceResponse> DescribeNatFwInstance(DescribeNatFwInstanceRequest req)
        {
            return InternalRequestAsync<DescribeNatFwInstanceResponse>(req, "DescribeNatFwInstance");
        }

        /// <summary>
        /// This API is used to get all NAT instances of a tenant.
        /// </summary>
        /// <param name="req"><see cref="DescribeNatFwInstanceRequest"/></param>
        /// <returns><see cref="DescribeNatFwInstanceResponse"/></returns>
        public DescribeNatFwInstanceResponse DescribeNatFwInstanceSync(DescribeNatFwInstanceRequest req)
        {
            return InternalRequestAsync<DescribeNatFwInstanceResponse>(req, "DescribeNatFwInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the NAT instance with the region that is newly maintained by the tenant.
        /// </summary>
        /// <param name="req"><see cref="DescribeNatFwInstanceWithRegionRequest"/></param>
        /// <returns><see cref="DescribeNatFwInstanceWithRegionResponse"/></returns>
        public Task<DescribeNatFwInstanceWithRegionResponse> DescribeNatFwInstanceWithRegion(DescribeNatFwInstanceWithRegionRequest req)
        {
            return InternalRequestAsync<DescribeNatFwInstanceWithRegionResponse>(req, "DescribeNatFwInstanceWithRegion");
        }

        /// <summary>
        /// This API is used to get the NAT instance with the region that is newly maintained by the tenant.
        /// </summary>
        /// <param name="req"><see cref="DescribeNatFwInstanceWithRegionRequest"/></param>
        /// <returns><see cref="DescribeNatFwInstanceWithRegionResponse"/></returns>
        public DescribeNatFwInstanceWithRegionResponse DescribeNatFwInstanceWithRegionSync(DescribeNatFwInstanceWithRegionRequest req)
        {
            return InternalRequestAsync<DescribeNatFwInstanceWithRegionResponse>(req, "DescribeNatFwInstanceWithRegion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get all NAT instances and instance card information of a tenant.
        /// </summary>
        /// <param name="req"><see cref="DescribeNatFwInstancesInfoRequest"/></param>
        /// <returns><see cref="DescribeNatFwInstancesInfoResponse"/></returns>
        public Task<DescribeNatFwInstancesInfoResponse> DescribeNatFwInstancesInfo(DescribeNatFwInstancesInfoRequest req)
        {
            return InternalRequestAsync<DescribeNatFwInstancesInfoResponse>(req, "DescribeNatFwInstancesInfo");
        }

        /// <summary>
        /// This API is used to get all NAT instances and instance card information of a tenant.
        /// </summary>
        /// <param name="req"><see cref="DescribeNatFwInstancesInfoRequest"/></param>
        /// <returns><see cref="DescribeNatFwInstancesInfoResponse"/></returns>
        public DescribeNatFwInstancesInfoResponse DescribeNatFwInstancesInfoSync(DescribeNatFwInstancesInfoRequest req)
        {
            return InternalRequestAsync<DescribeNatFwInstancesInfoResponse>(req, "DescribeNatFwInstancesInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the VPC DNS status of NAT firewall instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeNatFwVpcDnsLstRequest"/></param>
        /// <returns><see cref="DescribeNatFwVpcDnsLstResponse"/></returns>
        public Task<DescribeNatFwVpcDnsLstResponse> DescribeNatFwVpcDnsLst(DescribeNatFwVpcDnsLstRequest req)
        {
            return InternalRequestAsync<DescribeNatFwVpcDnsLstResponse>(req, "DescribeNatFwVpcDnsLst");
        }

        /// <summary>
        /// This API is used to get the VPC DNS status of NAT firewall instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeNatFwVpcDnsLstRequest"/></param>
        /// <returns><see cref="DescribeNatFwVpcDnsLstResponse"/></returns>
        public DescribeNatFwVpcDnsLstResponse DescribeNatFwVpcDnsLstSync(DescribeNatFwVpcDnsLstRequest req)
        {
            return InternalRequestAsync<DescribeNatFwVpcDnsLstResponse>(req, "DescribeNatFwVpcDnsLst")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the asset tree information in Asset Management.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceGroupNewRequest"/></param>
        /// <returns><see cref="DescribeResourceGroupNewResponse"/></returns>
        public Task<DescribeResourceGroupNewResponse> DescribeResourceGroupNew(DescribeResourceGroupNewRequest req)
        {
            return InternalRequestAsync<DescribeResourceGroupNewResponse>(req, "DescribeResourceGroupNew");
        }

        /// <summary>
        /// This API is used to get the asset tree information in Asset Management.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceGroupNewRequest"/></param>
        /// <returns><see cref="DescribeResourceGroupNewResponse"/></returns>
        public DescribeResourceGroupNewResponse DescribeResourceGroupNewSync(DescribeResourceGroupNewRequest req)
        {
            return InternalRequestAsync<DescribeResourceGroupNewResponse>(req, "DescribeResourceGroupNew")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the rule list overview.
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleOverviewRequest"/></param>
        /// <returns><see cref="DescribeRuleOverviewResponse"/></returns>
        public Task<DescribeRuleOverviewResponse> DescribeRuleOverview(DescribeRuleOverviewRequest req)
        {
            return InternalRequestAsync<DescribeRuleOverviewResponse>(req, "DescribeRuleOverview");
        }

        /// <summary>
        /// This API is used to get the rule list overview.
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleOverviewRequest"/></param>
        /// <returns><see cref="DescribeRuleOverviewResponse"/></returns>
        public DescribeRuleOverviewResponse DescribeRuleOverviewSync(DescribeRuleOverviewRequest req)
        {
            return InternalRequestAsync<DescribeRuleOverviewResponse>(req, "DescribeRuleOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the security group rule list.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupListRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupListResponse"/></returns>
        public Task<DescribeSecurityGroupListResponse> DescribeSecurityGroupList(DescribeSecurityGroupListRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupListResponse>(req, "DescribeSecurityGroupList");
        }

        /// <summary>
        /// This API is used to get the security group rule list.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupListRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupListResponse"/></returns>
        public DescribeSecurityGroupListResponse DescribeSecurityGroupListSync(DescribeSecurityGroupListRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupListResponse>(req, "DescribeSecurityGroupList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get all asset information of an asset group.
        /// </summary>
        /// <param name="req"><see cref="DescribeSourceAssetRequest"/></param>
        /// <returns><see cref="DescribeSourceAssetResponse"/></returns>
        public Task<DescribeSourceAssetResponse> DescribeSourceAsset(DescribeSourceAssetRequest req)
        {
            return InternalRequestAsync<DescribeSourceAssetResponse>(req, "DescribeSourceAsset");
        }

        /// <summary>
        /// This API is used to get all asset information of an asset group.
        /// </summary>
        /// <param name="req"><see cref="DescribeSourceAssetRequest"/></param>
        /// <returns><see cref="DescribeSourceAssetResponse"/></returns>
        public DescribeSourceAssetResponse DescribeSourceAssetSync(DescribeSourceAssetRequest req)
        {
            return InternalRequestAsync<DescribeSourceAssetResponse>(req, "DescribeSourceAsset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the firewall status list.
        /// </summary>
        /// <param name="req"><see cref="DescribeSwitchListsRequest"/></param>
        /// <returns><see cref="DescribeSwitchListsResponse"/></returns>
        public Task<DescribeSwitchListsResponse> DescribeSwitchLists(DescribeSwitchListsRequest req)
        {
            return InternalRequestAsync<DescribeSwitchListsResponse>(req, "DescribeSwitchLists");
        }

        /// <summary>
        /// This API is used to get the firewall status list.
        /// </summary>
        /// <param name="req"><see cref="DescribeSwitchListsRequest"/></param>
        /// <returns><see cref="DescribeSwitchListsResponse"/></returns>
        public DescribeSwitchListsResponse DescribeSwitchListsSync(DescribeSwitchListsRequest req)
        {
            return InternalRequestAsync<DescribeSwitchListsResponse>(req, "DescribeSwitchLists")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the current alert monitoring data.
        /// </summary>
        /// <param name="req"><see cref="DescribeTLogInfoRequest"/></param>
        /// <returns><see cref="DescribeTLogInfoResponse"/></returns>
        public Task<DescribeTLogInfoResponse> DescribeTLogInfo(DescribeTLogInfoRequest req)
        {
            return InternalRequestAsync<DescribeTLogInfoResponse>(req, "DescribeTLogInfo");
        }

        /// <summary>
        /// This API is used to get the current alert monitoring data.
        /// </summary>
        /// <param name="req"><see cref="DescribeTLogInfoRequest"/></param>
        /// <returns><see cref="DescribeTLogInfoResponse"/></returns>
        public DescribeTLogInfoResponse DescribeTLogInfoSync(DescribeTLogInfoRequest req)
        {
            return InternalRequestAsync<DescribeTLogInfoResponse>(req, "DescribeTLogInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the most frequent attacker IP.
        /// </summary>
        /// <param name="req"><see cref="DescribeTLogIpListRequest"/></param>
        /// <returns><see cref="DescribeTLogIpListResponse"/></returns>
        public Task<DescribeTLogIpListResponse> DescribeTLogIpList(DescribeTLogIpListRequest req)
        {
            return InternalRequestAsync<DescribeTLogIpListResponse>(req, "DescribeTLogIpList");
        }

        /// <summary>
        /// This API is used to get the most frequent attacker IP.
        /// </summary>
        /// <param name="req"><see cref="DescribeTLogIpListRequest"/></param>
        /// <returns><see cref="DescribeTLogIpListResponse"/></returns>
        public DescribeTLogIpListResponse DescribeTLogIpListSync(DescribeTLogIpListRequest req)
        {
            return InternalRequestAsync<DescribeTLogIpListResponse>(req, "DescribeTLogIpList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the rule list status.
        /// </summary>
        /// <param name="req"><see cref="DescribeTableStatusRequest"/></param>
        /// <returns><see cref="DescribeTableStatusResponse"/></returns>
        public Task<DescribeTableStatusResponse> DescribeTableStatus(DescribeTableStatusRequest req)
        {
            return InternalRequestAsync<DescribeTableStatusResponse>(req, "DescribeTableStatus");
        }

        /// <summary>
        /// This API is used to get the rule list status.
        /// </summary>
        /// <param name="req"><see cref="DescribeTableStatusRequest"/></param>
        /// <returns><see cref="DescribeTableStatusResponse"/></returns>
        public DescribeTableStatusResponse DescribeTableStatusSync(DescribeTableStatusRequest req)
        {
            return InternalRequestAsync<DescribeTableStatusResponse>(req, "DescribeTableStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get unhandled security events.
        /// </summary>
        /// <param name="req"><see cref="DescribeUnHandleEventTabListRequest"/></param>
        /// <returns><see cref="DescribeUnHandleEventTabListResponse"/></returns>
        public Task<DescribeUnHandleEventTabListResponse> DescribeUnHandleEventTabList(DescribeUnHandleEventTabListRequest req)
        {
            return InternalRequestAsync<DescribeUnHandleEventTabListResponse>(req, "DescribeUnHandleEventTabList");
        }

        /// <summary>
        /// This API is used to get unhandled security events.
        /// </summary>
        /// <param name="req"><see cref="DescribeUnHandleEventTabListRequest"/></param>
        /// <returns><see cref="DescribeUnHandleEventTabListResponse"/></returns>
        public DescribeUnHandleEventTabListResponse DescribeUnHandleEventTabListSync(DescribeUnHandleEventTabListRequest req)
        {
            return InternalRequestAsync<DescribeUnHandleEventTabListResponse>(req, "DescribeUnHandleEventTabList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to increase the firewall bandwidth.
        /// </summary>
        /// <param name="req"><see cref="ExpandCfwVerticalRequest"/></param>
        /// <returns><see cref="ExpandCfwVerticalResponse"/></returns>
        public Task<ExpandCfwVerticalResponse> ExpandCfwVertical(ExpandCfwVerticalRequest req)
        {
            return InternalRequestAsync<ExpandCfwVerticalResponse>(req, "ExpandCfwVertical");
        }

        /// <summary>
        /// This API is used to increase the firewall bandwidth.
        /// </summary>
        /// <param name="req"><see cref="ExpandCfwVerticalRequest"/></param>
        /// <returns><see cref="ExpandCfwVerticalResponse"/></returns>
        public ExpandCfwVerticalResponse ExpandCfwVerticalSync(ExpandCfwVerticalRequest req)
        {
            return InternalRequestAsync<ExpandCfwVerticalResponse>(req, "ExpandCfwVertical")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyAcRuleRequest"/></param>
        /// <returns><see cref="ModifyAcRuleResponse"/></returns>
        public Task<ModifyAcRuleResponse> ModifyAcRule(ModifyAcRuleRequest req)
        {
            return InternalRequestAsync<ModifyAcRuleResponse>(req, "ModifyAcRule");
        }

        /// <summary>
        /// This API is used to modify rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyAcRuleRequest"/></param>
        /// <returns><see cref="ModifyAcRuleResponse"/></returns>
        public ModifyAcRuleResponse ModifyAcRuleSync(ModifyAcRuleRequest req)
        {
            return InternalRequestAsync<ModifyAcRuleResponse>(req, "ModifyAcRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable or disable one or multiple edge firewalls.
        /// </summary>
        /// <param name="req"><see cref="ModifyAllPublicIPSwitchStatusRequest"/></param>
        /// <returns><see cref="ModifyAllPublicIPSwitchStatusResponse"/></returns>
        public Task<ModifyAllPublicIPSwitchStatusResponse> ModifyAllPublicIPSwitchStatus(ModifyAllPublicIPSwitchStatusRequest req)
        {
            return InternalRequestAsync<ModifyAllPublicIPSwitchStatusResponse>(req, "ModifyAllPublicIPSwitchStatus");
        }

        /// <summary>
        /// This API is used to enable or disable one or multiple edge firewalls.
        /// </summary>
        /// <param name="req"><see cref="ModifyAllPublicIPSwitchStatusRequest"/></param>
        /// <returns><see cref="ModifyAllPublicIPSwitchStatusResponse"/></returns>
        public ModifyAllPublicIPSwitchStatusResponse ModifyAllPublicIPSwitchStatusSync(ModifyAllPublicIPSwitchStatusRequest req)
        {
            return InternalRequestAsync<ModifyAllPublicIPSwitchStatusResponse>(req, "ModifyAllPublicIPSwitchStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable or disable all rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyAllRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyAllRuleStatusResponse"/></returns>
        public Task<ModifyAllRuleStatusResponse> ModifyAllRuleStatus(ModifyAllRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyAllRuleStatusResponse>(req, "ModifyAllRuleStatus");
        }

        /// <summary>
        /// This API is used to enable or disable all rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyAllRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyAllRuleStatusResponse"/></returns>
        public ModifyAllRuleStatusResponse ModifyAllRuleStatusSync(ModifyAllRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyAllRuleStatusResponse>(req, "ModifyAllRuleStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable or disable one or multiple VPC firewalls.
        /// </summary>
        /// <param name="req"><see cref="ModifyAllVPCSwitchStatusRequest"/></param>
        /// <returns><see cref="ModifyAllVPCSwitchStatusResponse"/></returns>
        public Task<ModifyAllVPCSwitchStatusResponse> ModifyAllVPCSwitchStatus(ModifyAllVPCSwitchStatusRequest req)
        {
            return InternalRequestAsync<ModifyAllVPCSwitchStatusResponse>(req, "ModifyAllVPCSwitchStatus");
        }

        /// <summary>
        /// This API is used to enable or disable one or multiple VPC firewalls.
        /// </summary>
        /// <param name="req"><see cref="ModifyAllVPCSwitchStatusRequest"/></param>
        /// <returns><see cref="ModifyAllVPCSwitchStatusResponse"/></returns>
        public ModifyAllVPCSwitchStatusResponse ModifyAllVPCSwitchStatusSync(ModifyAllVPCSwitchStatusRequest req)
        {
            return InternalRequestAsync<ModifyAllVPCSwitchStatusResponse>(req, "ModifyAllVPCSwitchStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify asset scan settings.
        /// </summary>
        /// <param name="req"><see cref="ModifyAssetScanRequest"/></param>
        /// <returns><see cref="ModifyAssetScanResponse"/></returns>
        public Task<ModifyAssetScanResponse> ModifyAssetScan(ModifyAssetScanRequest req)
        {
            return InternalRequestAsync<ModifyAssetScanResponse>(req, "ModifyAssetScan");
        }

        /// <summary>
        /// This API is used to modify asset scan settings.
        /// </summary>
        /// <param name="req"><see cref="ModifyAssetScanRequest"/></param>
        /// <returns><see cref="ModifyAssetScanResponse"/></returns>
        public ModifyAssetScanResponse ModifyAssetScanSync(ModifyAssetScanRequest req)
        {
            return InternalRequestAsync<ModifyAssetScanResponse>(req, "ModifyAssetScan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to manage blocked/allowed IPs and domains.
        /// Add IPs/domains to the blocked/allowed list
        /// Remove IPs/domains from the blocked/allowed list
        /// Modify events related with the IPs/domains in the blocked/allowed list
        /// </summary>
        /// <param name="req"><see cref="ModifyBlockIgnoreListRequest"/></param>
        /// <returns><see cref="ModifyBlockIgnoreListResponse"/></returns>
        public Task<ModifyBlockIgnoreListResponse> ModifyBlockIgnoreList(ModifyBlockIgnoreListRequest req)
        {
            return InternalRequestAsync<ModifyBlockIgnoreListResponse>(req, "ModifyBlockIgnoreList");
        }

        /// <summary>
        /// This API is used to manage blocked/allowed IPs and domains.
        /// Add IPs/domains to the blocked/allowed list
        /// Remove IPs/domains from the blocked/allowed list
        /// Modify events related with the IPs/domains in the blocked/allowed list
        /// </summary>
        /// <param name="req"><see cref="ModifyBlockIgnoreListRequest"/></param>
        /// <returns><see cref="ModifyBlockIgnoreListResponse"/></returns>
        public ModifyBlockIgnoreListResponse ModifyBlockIgnoreListSync(ModifyBlockIgnoreListRequest req)
        {
            return InternalRequestAsync<ModifyBlockIgnoreListResponse>(req, "ModifyBlockIgnoreList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to pin or unpin a blocking log.
        /// </summary>
        /// <param name="req"><see cref="ModifyBlockTopRequest"/></param>
        /// <returns><see cref="ModifyBlockTopResponse"/></returns>
        public Task<ModifyBlockTopResponse> ModifyBlockTop(ModifyBlockTopRequest req)
        {
            return InternalRequestAsync<ModifyBlockTopResponse>(req, "ModifyBlockTop");
        }

        /// <summary>
        /// This API is used to pin or unpin a blocking log.
        /// </summary>
        /// <param name="req"><see cref="ModifyBlockTopRequest"/></param>
        /// <returns><see cref="ModifyBlockTopResponse"/></returns>
        public ModifyBlockTopResponse ModifyBlockTopSync(ModifyBlockTopRequest req)
        {
            return InternalRequestAsync<ModifyBlockTopResponse>(req, "ModifyBlockTop")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the publishing status of an enterprise security group.
        /// </summary>
        /// <param name="req"><see cref="ModifyEnterpriseSecurityDispatchStatusRequest"/></param>
        /// <returns><see cref="ModifyEnterpriseSecurityDispatchStatusResponse"/></returns>
        public Task<ModifyEnterpriseSecurityDispatchStatusResponse> ModifyEnterpriseSecurityDispatchStatus(ModifyEnterpriseSecurityDispatchStatusRequest req)
        {
            return InternalRequestAsync<ModifyEnterpriseSecurityDispatchStatusResponse>(req, "ModifyEnterpriseSecurityDispatchStatus");
        }

        /// <summary>
        /// This API is used to modify the publishing status of an enterprise security group.
        /// </summary>
        /// <param name="req"><see cref="ModifyEnterpriseSecurityDispatchStatusRequest"/></param>
        /// <returns><see cref="ModifyEnterpriseSecurityDispatchStatusResponse"/></returns>
        public ModifyEnterpriseSecurityDispatchStatusResponse ModifyEnterpriseSecurityDispatchStatusSync(ModifyEnterpriseSecurityDispatchStatusRequest req)
        {
            return InternalRequestAsync<ModifyEnterpriseSecurityDispatchStatusResponse>(req, "ModifyEnterpriseSecurityDispatchStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a new enterprise security group rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyEnterpriseSecurityGroupRuleRequest"/></param>
        /// <returns><see cref="ModifyEnterpriseSecurityGroupRuleResponse"/></returns>
        public Task<ModifyEnterpriseSecurityGroupRuleResponse> ModifyEnterpriseSecurityGroupRule(ModifyEnterpriseSecurityGroupRuleRequest req)
        {
            return InternalRequestAsync<ModifyEnterpriseSecurityGroupRuleResponse>(req, "ModifyEnterpriseSecurityGroupRule");
        }

        /// <summary>
        /// This API is used to modify a new enterprise security group rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyEnterpriseSecurityGroupRuleRequest"/></param>
        /// <returns><see cref="ModifyEnterpriseSecurityGroupRuleResponse"/></returns>
        public ModifyEnterpriseSecurityGroupRuleResponse ModifyEnterpriseSecurityGroupRuleSync(ModifyEnterpriseSecurityGroupRuleRequest req)
        {
            return InternalRequestAsync<ModifyEnterpriseSecurityGroupRuleResponse>(req, "ModifyEnterpriseSecurityGroupRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify NAT access control rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyNatAcRuleRequest"/></param>
        /// <returns><see cref="ModifyNatAcRuleResponse"/></returns>
        public Task<ModifyNatAcRuleResponse> ModifyNatAcRule(ModifyNatAcRuleRequest req)
        {
            return InternalRequestAsync<ModifyNatAcRuleResponse>(req, "ModifyNatAcRule");
        }

        /// <summary>
        /// This API is used to modify NAT access control rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyNatAcRuleRequest"/></param>
        /// <returns><see cref="ModifyNatAcRuleResponse"/></returns>
        public ModifyNatAcRuleResponse ModifyNatAcRuleSync(ModifyNatAcRuleRequest req)
        {
            return InternalRequestAsync<ModifyNatAcRuleResponse>(req, "ModifyNatAcRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the VPC or NAT list for changing associated firewall instances.
        /// </summary>
        /// <param name="req"><see cref="ModifyNatFwReSelectRequest"/></param>
        /// <returns><see cref="ModifyNatFwReSelectResponse"/></returns>
        public Task<ModifyNatFwReSelectResponse> ModifyNatFwReSelect(ModifyNatFwReSelectRequest req)
        {
            return InternalRequestAsync<ModifyNatFwReSelectResponse>(req, "ModifyNatFwReSelect");
        }

        /// <summary>
        /// This API is used to get the VPC or NAT list for changing associated firewall instances.
        /// </summary>
        /// <param name="req"><see cref="ModifyNatFwReSelectRequest"/></param>
        /// <returns><see cref="ModifyNatFwReSelectResponse"/></returns>
        public ModifyNatFwReSelectResponse ModifyNatFwReSelectSync(ModifyNatFwReSelectRequest req)
        {
            return InternalRequestAsync<ModifyNatFwReSelectResponse>(req, "ModifyNatFwReSelect")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable or disable a NAT firewall.
        /// </summary>
        /// <param name="req"><see cref="ModifyNatFwSwitchRequest"/></param>
        /// <returns><see cref="ModifyNatFwSwitchResponse"/></returns>
        public Task<ModifyNatFwSwitchResponse> ModifyNatFwSwitch(ModifyNatFwSwitchRequest req)
        {
            return InternalRequestAsync<ModifyNatFwSwitchResponse>(req, "ModifyNatFwSwitch");
        }

        /// <summary>
        /// This API is used to enable or disable a NAT firewall.
        /// </summary>
        /// <param name="req"><see cref="ModifyNatFwSwitchRequest"/></param>
        /// <returns><see cref="ModifyNatFwSwitchResponse"/></returns>
        public ModifyNatFwSwitchResponse ModifyNatFwSwitchSync(ModifyNatFwSwitchRequest req)
        {
            return InternalRequestAsync<ModifyNatFwSwitchResponse>(req, "ModifyNatFwSwitch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the VPC DNS status of NAT firewall instances.
        /// </summary>
        /// <param name="req"><see cref="ModifyNatFwVpcDnsSwitchRequest"/></param>
        /// <returns><see cref="ModifyNatFwVpcDnsSwitchResponse"/></returns>
        public Task<ModifyNatFwVpcDnsSwitchResponse> ModifyNatFwVpcDnsSwitch(ModifyNatFwVpcDnsSwitchRequest req)
        {
            return InternalRequestAsync<ModifyNatFwVpcDnsSwitchResponse>(req, "ModifyNatFwVpcDnsSwitch");
        }

        /// <summary>
        /// This API is used to modify the VPC DNS status of NAT firewall instances.
        /// </summary>
        /// <param name="req"><see cref="ModifyNatFwVpcDnsSwitchRequest"/></param>
        /// <returns><see cref="ModifyNatFwVpcDnsSwitchResponse"/></returns>
        public ModifyNatFwVpcDnsSwitchResponse ModifyNatFwVpcDnsSwitchSync(ModifyNatFwVpcDnsSwitchRequest req)
        {
            return InternalRequestAsync<ModifyNatFwVpcDnsSwitchResponse>(req, "ModifyNatFwVpcDnsSwitch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to change the sequence number of NAT firewall rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyNatSequenceRulesRequest"/></param>
        /// <returns><see cref="ModifyNatSequenceRulesResponse"/></returns>
        public Task<ModifyNatSequenceRulesResponse> ModifyNatSequenceRules(ModifyNatSequenceRulesRequest req)
        {
            return InternalRequestAsync<ModifyNatSequenceRulesResponse>(req, "ModifyNatSequenceRules");
        }

        /// <summary>
        /// This API is used to change the sequence number of NAT firewall rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyNatSequenceRulesRequest"/></param>
        /// <returns><see cref="ModifyNatSequenceRulesResponse"/></returns>
        public ModifyNatSequenceRulesResponse ModifyNatSequenceRulesSync(ModifyNatSequenceRulesRequest req)
        {
            return InternalRequestAsync<ModifyNatSequenceRulesResponse>(req, "ModifyNatSequenceRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable or disable an edge firewall.
        /// </summary>
        /// <param name="req"><see cref="ModifyPublicIPSwitchStatusRequest"/></param>
        /// <returns><see cref="ModifyPublicIPSwitchStatusResponse"/></returns>
        public Task<ModifyPublicIPSwitchStatusResponse> ModifyPublicIPSwitchStatus(ModifyPublicIPSwitchStatusRequest req)
        {
            return InternalRequestAsync<ModifyPublicIPSwitchStatusResponse>(req, "ModifyPublicIPSwitchStatus");
        }

        /// <summary>
        /// This API is used to enable or disable an edge firewall.
        /// </summary>
        /// <param name="req"><see cref="ModifyPublicIPSwitchStatusRequest"/></param>
        /// <returns><see cref="ModifyPublicIPSwitchStatusResponse"/></returns>
        public ModifyPublicIPSwitchStatusResponse ModifyPublicIPSwitchStatusSync(ModifyPublicIPSwitchStatusRequest req)
        {
            return InternalRequestAsync<ModifyPublicIPSwitchStatusResponse>(req, "ModifyPublicIPSwitchStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the asset group information in Asset Management.
        /// 
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceGroupRequest"/></param>
        /// <returns><see cref="ModifyResourceGroupResponse"/></returns>
        public Task<ModifyResourceGroupResponse> ModifyResourceGroup(ModifyResourceGroupRequest req)
        {
            return InternalRequestAsync<ModifyResourceGroupResponse>(req, "ModifyResourceGroup");
        }

        /// <summary>
        /// This API is used to modify the asset group information in Asset Management.
        /// 
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceGroupRequest"/></param>
        /// <returns><see cref="ModifyResourceGroupResponse"/></returns>
        public ModifyResourceGroupResponse ModifyResourceGroupSync(ModifyResourceGroupRequest req)
        {
            return InternalRequestAsync<ModifyResourceGroupResponse>(req, "ModifyResourceGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to sync assets - Internet & VPC (new).
        /// </summary>
        /// <param name="req"><see cref="ModifyRunSyncAssetRequest"/></param>
        /// <returns><see cref="ModifyRunSyncAssetResponse"/></returns>
        public Task<ModifyRunSyncAssetResponse> ModifyRunSyncAsset(ModifyRunSyncAssetRequest req)
        {
            return InternalRequestAsync<ModifyRunSyncAssetResponse>(req, "ModifyRunSyncAsset");
        }

        /// <summary>
        /// This API is used to sync assets - Internet & VPC (new).
        /// </summary>
        /// <param name="req"><see cref="ModifyRunSyncAssetRequest"/></param>
        /// <returns><see cref="ModifyRunSyncAssetResponse"/></returns>
        public ModifyRunSyncAssetResponse ModifyRunSyncAssetSync(ModifyRunSyncAssetRequest req)
        {
            return InternalRequestAsync<ModifyRunSyncAssetResponse>(req, "ModifyRunSyncAsset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable or disable an enterprise security group rule.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupItemRuleStatusRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupItemRuleStatusResponse"/></returns>
        public Task<ModifySecurityGroupItemRuleStatusResponse> ModifySecurityGroupItemRuleStatus(ModifySecurityGroupItemRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifySecurityGroupItemRuleStatusResponse>(req, "ModifySecurityGroupItemRuleStatus");
        }

        /// <summary>
        /// This API is used to enable or disable an enterprise security group rule.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupItemRuleStatusRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupItemRuleStatusResponse"/></returns>
        public ModifySecurityGroupItemRuleStatusResponse ModifySecurityGroupItemRuleStatusSync(ModifySecurityGroupItemRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifySecurityGroupItemRuleStatusResponse>(req, "ModifySecurityGroupItemRuleStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to sort enterprise security group rules.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupSequenceRulesRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupSequenceRulesResponse"/></returns>
        public Task<ModifySecurityGroupSequenceRulesResponse> ModifySecurityGroupSequenceRules(ModifySecurityGroupSequenceRulesRequest req)
        {
            return InternalRequestAsync<ModifySecurityGroupSequenceRulesResponse>(req, "ModifySecurityGroupSequenceRules");
        }

        /// <summary>
        /// This API is used to sort enterprise security group rules.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupSequenceRulesRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupSequenceRulesResponse"/></returns>
        public ModifySecurityGroupSequenceRulesResponse ModifySecurityGroupSequenceRulesSync(ModifySecurityGroupSequenceRulesRequest req)
        {
            return InternalRequestAsync<ModifySecurityGroupSequenceRulesResponse>(req, "ModifySecurityGroupSequenceRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify rule priority.
        /// </summary>
        /// <param name="req"><see cref="ModifySequenceRulesRequest"/></param>
        /// <returns><see cref="ModifySequenceRulesResponse"/></returns>
        public Task<ModifySequenceRulesResponse> ModifySequenceRules(ModifySequenceRulesRequest req)
        {
            return InternalRequestAsync<ModifySequenceRulesResponse>(req, "ModifySequenceRules");
        }

        /// <summary>
        /// This API is used to modify rule priority.
        /// </summary>
        /// <param name="req"><see cref="ModifySequenceRulesRequest"/></param>
        /// <returns><see cref="ModifySequenceRulesResponse"/></returns>
        public ModifySequenceRulesResponse ModifySequenceRulesSync(ModifySequenceRulesRequest req)
        {
            return InternalRequestAsync<ModifySequenceRulesResponse>(req, "ModifySequenceRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the log retention period or to clear logs.
        /// </summary>
        /// <param name="req"><see cref="ModifyStorageSettingRequest"/></param>
        /// <returns><see cref="ModifyStorageSettingResponse"/></returns>
        public Task<ModifyStorageSettingResponse> ModifyStorageSetting(ModifyStorageSettingRequest req)
        {
            return InternalRequestAsync<ModifyStorageSettingResponse>(req, "ModifyStorageSetting");
        }

        /// <summary>
        /// This API is used to modify the log retention period or to clear logs.
        /// </summary>
        /// <param name="req"><see cref="ModifyStorageSettingRequest"/></param>
        /// <returns><see cref="ModifyStorageSettingResponse"/></returns>
        public ModifyStorageSettingResponse ModifyStorageSettingSync(ModifyStorageSettingRequest req)
        {
            return InternalRequestAsync<ModifyStorageSettingResponse>(req, "ModifyStorageSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify rule list status.
        /// </summary>
        /// <param name="req"><see cref="ModifyTableStatusRequest"/></param>
        /// <returns><see cref="ModifyTableStatusResponse"/></returns>
        public Task<ModifyTableStatusResponse> ModifyTableStatus(ModifyTableStatusRequest req)
        {
            return InternalRequestAsync<ModifyTableStatusResponse>(req, "ModifyTableStatus");
        }

        /// <summary>
        /// This API is used to modify rule list status.
        /// </summary>
        /// <param name="req"><see cref="ModifyTableStatusRequest"/></param>
        /// <returns><see cref="ModifyTableStatusResponse"/></returns>
        public ModifyTableStatusResponse ModifyTableStatusSync(ModifyTableStatusRequest req)
        {
            return InternalRequestAsync<ModifyTableStatusResponse>(req, "ModifyTableStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete edge firewall rules.
        /// </summary>
        /// <param name="req"><see cref="RemoveAcRuleRequest"/></param>
        /// <returns><see cref="RemoveAcRuleResponse"/></returns>
        public Task<RemoveAcRuleResponse> RemoveAcRule(RemoveAcRuleRequest req)
        {
            return InternalRequestAsync<RemoveAcRuleResponse>(req, "RemoveAcRule");
        }

        /// <summary>
        /// This API is used to delete edge firewall rules.
        /// </summary>
        /// <param name="req"><see cref="RemoveAcRuleRequest"/></param>
        /// <returns><see cref="RemoveAcRuleResponse"/></returns>
        public RemoveAcRuleResponse RemoveAcRuleSync(RemoveAcRuleRequest req)
        {
            return InternalRequestAsync<RemoveAcRuleResponse>(req, "RemoveAcRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete enterprise security group rules (new).
        /// </summary>
        /// <param name="req"><see cref="RemoveEnterpriseSecurityGroupRuleRequest"/></param>
        /// <returns><see cref="RemoveEnterpriseSecurityGroupRuleResponse"/></returns>
        public Task<RemoveEnterpriseSecurityGroupRuleResponse> RemoveEnterpriseSecurityGroupRule(RemoveEnterpriseSecurityGroupRuleRequest req)
        {
            return InternalRequestAsync<RemoveEnterpriseSecurityGroupRuleResponse>(req, "RemoveEnterpriseSecurityGroupRule");
        }

        /// <summary>
        /// This API is used to delete enterprise security group rules (new).
        /// </summary>
        /// <param name="req"><see cref="RemoveEnterpriseSecurityGroupRuleRequest"/></param>
        /// <returns><see cref="RemoveEnterpriseSecurityGroupRuleResponse"/></returns>
        public RemoveEnterpriseSecurityGroupRuleResponse RemoveEnterpriseSecurityGroupRuleSync(RemoveEnterpriseSecurityGroupRuleRequest req)
        {
            return InternalRequestAsync<RemoveEnterpriseSecurityGroupRuleResponse>(req, "RemoveEnterpriseSecurityGroupRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete NAT access control rules.
        /// </summary>
        /// <param name="req"><see cref="RemoveNatAcRuleRequest"/></param>
        /// <returns><see cref="RemoveNatAcRuleResponse"/></returns>
        public Task<RemoveNatAcRuleResponse> RemoveNatAcRule(RemoveNatAcRuleRequest req)
        {
            return InternalRequestAsync<RemoveNatAcRuleResponse>(req, "RemoveNatAcRule");
        }

        /// <summary>
        /// This API is used to delete NAT access control rules.
        /// </summary>
        /// <param name="req"><see cref="RemoveNatAcRuleRequest"/></param>
        /// <returns><see cref="RemoveNatAcRuleResponse"/></returns>
        public RemoveNatAcRuleResponse RemoveNatAcRuleSync(RemoveNatAcRuleRequest req)
        {
            return InternalRequestAsync<RemoveNatAcRuleResponse>(req, "RemoveNatAcRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to configure firewall DNAT rules.
        /// </summary>
        /// <param name="req"><see cref="SetNatFwDnatRuleRequest"/></param>
        /// <returns><see cref="SetNatFwDnatRuleResponse"/></returns>
        public Task<SetNatFwDnatRuleResponse> SetNatFwDnatRule(SetNatFwDnatRuleRequest req)
        {
            return InternalRequestAsync<SetNatFwDnatRuleResponse>(req, "SetNatFwDnatRule");
        }

        /// <summary>
        /// This API is used to configure firewall DNAT rules.
        /// </summary>
        /// <param name="req"><see cref="SetNatFwDnatRuleRequest"/></param>
        /// <returns><see cref="SetNatFwDnatRuleResponse"/></returns>
        public SetNatFwDnatRuleResponse SetNatFwDnatRuleSync(SetNatFwDnatRuleRequest req)
        {
            return InternalRequestAsync<SetNatFwDnatRuleResponse>(req, "SetNatFwDnatRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set the firewall instance EIP. (Available for firewall instances in the "Create new" mode. only)
        /// </summary>
        /// <param name="req"><see cref="SetNatFwEipRequest"/></param>
        /// <returns><see cref="SetNatFwEipResponse"/></returns>
        public Task<SetNatFwEipResponse> SetNatFwEip(SetNatFwEipRequest req)
        {
            return InternalRequestAsync<SetNatFwEipResponse>(req, "SetNatFwEip");
        }

        /// <summary>
        /// This API is used to set the firewall instance EIP. (Available for firewall instances in the "Create new" mode. only)
        /// </summary>
        /// <param name="req"><see cref="SetNatFwEipRequest"/></param>
        /// <returns><see cref="SetNatFwEipResponse"/></returns>
        public SetNatFwEipResponse SetNatFwEipSync(SetNatFwEipRequest req)
        {
            return InternalRequestAsync<SetNatFwEipResponse>(req, "SetNatFwEip")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to stop publishing security group rules.
        /// </summary>
        /// <param name="req"><see cref="StopSecurityGroupRuleDispatchRequest"/></param>
        /// <returns><see cref="StopSecurityGroupRuleDispatchResponse"/></returns>
        public Task<StopSecurityGroupRuleDispatchResponse> StopSecurityGroupRuleDispatch(StopSecurityGroupRuleDispatchRequest req)
        {
            return InternalRequestAsync<StopSecurityGroupRuleDispatchResponse>(req, "StopSecurityGroupRuleDispatch");
        }

        /// <summary>
        /// This API is used to stop publishing security group rules.
        /// </summary>
        /// <param name="req"><see cref="StopSecurityGroupRuleDispatchRequest"/></param>
        /// <returns><see cref="StopSecurityGroupRuleDispatchResponse"/></returns>
        public StopSecurityGroupRuleDispatchResponse StopSecurityGroupRuleDispatchSync(StopSecurityGroupRuleDispatchRequest req)
        {
            return InternalRequestAsync<StopSecurityGroupRuleDispatchResponse>(req, "StopSecurityGroupRuleDispatch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
