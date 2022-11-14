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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CfwClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// This API is used to add edge firewall rules.
        /// </summary>
        /// <param name="req"><see cref="AddAcRuleRequest"/></param>
        /// <returns><see cref="AddAcRuleResponse"/></returns>
        public async Task<AddAcRuleResponse> AddAcRule(AddAcRuleRequest req)
        {
             JsonResponseModel<AddAcRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddAcRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddAcRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add edge firewall rules.
        /// </summary>
        /// <param name="req"><see cref="AddAcRuleRequest"/></param>
        /// <returns><see cref="AddAcRuleResponse"/></returns>
        public AddAcRuleResponse AddAcRuleSync(AddAcRuleRequest req)
        {
             JsonResponseModel<AddAcRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddAcRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddAcRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create enterprise security group rules (new).
        /// </summary>
        /// <param name="req"><see cref="AddEnterpriseSecurityGroupRulesRequest"/></param>
        /// <returns><see cref="AddEnterpriseSecurityGroupRulesResponse"/></returns>
        public async Task<AddEnterpriseSecurityGroupRulesResponse> AddEnterpriseSecurityGroupRules(AddEnterpriseSecurityGroupRulesRequest req)
        {
             JsonResponseModel<AddEnterpriseSecurityGroupRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddEnterpriseSecurityGroupRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddEnterpriseSecurityGroupRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create enterprise security group rules (new).
        /// </summary>
        /// <param name="req"><see cref="AddEnterpriseSecurityGroupRulesRequest"/></param>
        /// <returns><see cref="AddEnterpriseSecurityGroupRulesResponse"/></returns>
        public AddEnterpriseSecurityGroupRulesResponse AddEnterpriseSecurityGroupRulesSync(AddEnterpriseSecurityGroupRulesRequest req)
        {
             JsonResponseModel<AddEnterpriseSecurityGroupRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddEnterpriseSecurityGroupRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddEnterpriseSecurityGroupRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create rules.
        /// </summary>
        /// <param name="req"><see cref="CreateAcRulesRequest"/></param>
        /// <returns><see cref="CreateAcRulesResponse"/></returns>
        public async Task<CreateAcRulesResponse> CreateAcRules(CreateAcRulesRequest req)
        {
             JsonResponseModel<CreateAcRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAcRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAcRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create rules.
        /// </summary>
        /// <param name="req"><see cref="CreateAcRulesRequest"/></param>
        /// <returns><see cref="CreateAcRulesResponse"/></returns>
        public CreateAcRulesResponse CreateAcRulesSync(CreateAcRulesRequest req)
        {
             JsonResponseModel<CreateAcRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAcRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAcRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a NAT firewall instance (The Region parameter is required).
        /// </summary>
        /// <param name="req"><see cref="CreateNatFwInstanceRequest"/></param>
        /// <returns><see cref="CreateNatFwInstanceResponse"/></returns>
        public async Task<CreateNatFwInstanceResponse> CreateNatFwInstance(CreateNatFwInstanceRequest req)
        {
             JsonResponseModel<CreateNatFwInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateNatFwInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNatFwInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a NAT firewall instance (The Region parameter is required).
        /// </summary>
        /// <param name="req"><see cref="CreateNatFwInstanceRequest"/></param>
        /// <returns><see cref="CreateNatFwInstanceResponse"/></returns>
        public CreateNatFwInstanceResponse CreateNatFwInstanceSync(CreateNatFwInstanceRequest req)
        {
             JsonResponseModel<CreateNatFwInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateNatFwInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNatFwInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a firewall instance with domain name (The Region parameter is required).
        /// </summary>
        /// <param name="req"><see cref="CreateNatFwInstanceWithDomainRequest"/></param>
        /// <returns><see cref="CreateNatFwInstanceWithDomainResponse"/></returns>
        public async Task<CreateNatFwInstanceWithDomainResponse> CreateNatFwInstanceWithDomain(CreateNatFwInstanceWithDomainRequest req)
        {
             JsonResponseModel<CreateNatFwInstanceWithDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateNatFwInstanceWithDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNatFwInstanceWithDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a firewall instance with domain name (The Region parameter is required).
        /// </summary>
        /// <param name="req"><see cref="CreateNatFwInstanceWithDomainRequest"/></param>
        /// <returns><see cref="CreateNatFwInstanceWithDomainResponse"/></returns>
        public CreateNatFwInstanceWithDomainResponse CreateNatFwInstanceWithDomainSync(CreateNatFwInstanceWithDomainRequest req)
        {
             JsonResponseModel<CreateNatFwInstanceWithDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateNatFwInstanceWithDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNatFwInstanceWithDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create enterprise security group rules.
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityGroupRulesRequest"/></param>
        /// <returns><see cref="CreateSecurityGroupRulesResponse"/></returns>
        public async Task<CreateSecurityGroupRulesResponse> CreateSecurityGroupRules(CreateSecurityGroupRulesRequest req)
        {
             JsonResponseModel<CreateSecurityGroupRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSecurityGroupRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSecurityGroupRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create enterprise security group rules.
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityGroupRulesRequest"/></param>
        /// <returns><see cref="CreateSecurityGroupRulesResponse"/></returns>
        public CreateSecurityGroupRulesResponse CreateSecurityGroupRulesSync(CreateSecurityGroupRulesRequest req)
        {
             JsonResponseModel<CreateSecurityGroupRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSecurityGroupRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSecurityGroupRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteAcRuleRequest"/></param>
        /// <returns><see cref="DeleteAcRuleResponse"/></returns>
        public async Task<DeleteAcRuleResponse> DeleteAcRule(DeleteAcRuleRequest req)
        {
             JsonResponseModel<DeleteAcRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAcRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAcRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteAcRuleRequest"/></param>
        /// <returns><see cref="DeleteAcRuleResponse"/></returns>
        public DeleteAcRuleResponse DeleteAcRuleSync(DeleteAcRuleRequest req)
        {
             JsonResponseModel<DeleteAcRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAcRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAcRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete all rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteAllAccessControlRuleRequest"/></param>
        /// <returns><see cref="DeleteAllAccessControlRuleResponse"/></returns>
        public async Task<DeleteAllAccessControlRuleResponse> DeleteAllAccessControlRule(DeleteAllAccessControlRuleRequest req)
        {
             JsonResponseModel<DeleteAllAccessControlRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAllAccessControlRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAllAccessControlRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete all rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteAllAccessControlRuleRequest"/></param>
        /// <returns><see cref="DeleteAllAccessControlRuleResponse"/></returns>
        public DeleteAllAccessControlRuleResponse DeleteAllAccessControlRuleSync(DeleteAllAccessControlRuleRequest req)
        {
             JsonResponseModel<DeleteAllAccessControlRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAllAccessControlRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAllAccessControlRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete asset groups in Asset Management.
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceGroupRequest"/></param>
        /// <returns><see cref="DeleteResourceGroupResponse"/></returns>
        public async Task<DeleteResourceGroupResponse> DeleteResourceGroup(DeleteResourceGroupRequest req)
        {
             JsonResponseModel<DeleteResourceGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteResourceGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteResourceGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete asset groups in Asset Management.
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceGroupRequest"/></param>
        /// <returns><see cref="DeleteResourceGroupResponse"/></returns>
        public DeleteResourceGroupResponse DeleteResourceGroupSync(DeleteResourceGroupRequest req)
        {
             JsonResponseModel<DeleteResourceGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteResourceGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteResourceGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete security group rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityGroupRuleRequest"/></param>
        /// <returns><see cref="DeleteSecurityGroupRuleResponse"/></returns>
        public async Task<DeleteSecurityGroupRuleResponse> DeleteSecurityGroupRule(DeleteSecurityGroupRuleRequest req)
        {
             JsonResponseModel<DeleteSecurityGroupRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSecurityGroupRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSecurityGroupRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete security group rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityGroupRuleRequest"/></param>
        /// <returns><see cref="DeleteSecurityGroupRuleResponse"/></returns>
        public DeleteSecurityGroupRuleResponse DeleteSecurityGroupRuleSync(DeleteSecurityGroupRuleRequest req)
        {
             JsonResponseModel<DeleteSecurityGroupRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSecurityGroupRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSecurityGroupRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete firewall instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcInstanceRequest"/></param>
        /// <returns><see cref="DeleteVpcInstanceResponse"/></returns>
        public async Task<DeleteVpcInstanceResponse> DeleteVpcInstance(DeleteVpcInstanceRequest req)
        {
             JsonResponseModel<DeleteVpcInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteVpcInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteVpcInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete firewall instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcInstanceRequest"/></param>
        /// <returns><see cref="DeleteVpcInstanceResponse"/></returns>
        public DeleteVpcInstanceResponse DeleteVpcInstanceSync(DeleteVpcInstanceRequest req)
        {
             JsonResponseModel<DeleteVpcInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteVpcInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteVpcInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the access control list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAcListsRequest"/></param>
        /// <returns><see cref="DescribeAcListsResponse"/></returns>
        public async Task<DescribeAcListsResponse> DescribeAcLists(DescribeAcListsRequest req)
        {
             JsonResponseModel<DescribeAcListsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAcLists");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAcListsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the access control list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAcListsRequest"/></param>
        /// <returns><see cref="DescribeAcListsResponse"/></returns>
        public DescribeAcListsResponse DescribeAcListsSync(DescribeAcListsRequest req)
        {
             JsonResponseModel<DescribeAcListsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAcLists");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAcListsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of instances associated with a security group.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssociatedInstanceListRequest"/></param>
        /// <returns><see cref="DescribeAssociatedInstanceListResponse"/></returns>
        public async Task<DescribeAssociatedInstanceListResponse> DescribeAssociatedInstanceList(DescribeAssociatedInstanceListRequest req)
        {
             JsonResponseModel<DescribeAssociatedInstanceListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssociatedInstanceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssociatedInstanceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of instances associated with a security group.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssociatedInstanceListRequest"/></param>
        /// <returns><see cref="DescribeAssociatedInstanceListResponse"/></returns>
        public DescribeAssociatedInstanceListResponse DescribeAssociatedInstanceListSync(DescribeAssociatedInstanceListRequest req)
        {
             JsonResponseModel<DescribeAssociatedInstanceListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssociatedInstanceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssociatedInstanceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get blocked IP data.
        /// </summary>
        /// <param name="req"><see cref="DescribeBlockByIpTimesListRequest"/></param>
        /// <returns><see cref="DescribeBlockByIpTimesListResponse"/></returns>
        public async Task<DescribeBlockByIpTimesListResponse> DescribeBlockByIpTimesList(DescribeBlockByIpTimesListRequest req)
        {
             JsonResponseModel<DescribeBlockByIpTimesListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBlockByIpTimesList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBlockByIpTimesListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get blocked IP data.
        /// </summary>
        /// <param name="req"><see cref="DescribeBlockByIpTimesListRequest"/></param>
        /// <returns><see cref="DescribeBlockByIpTimesListResponse"/></returns>
        public DescribeBlockByIpTimesListResponse DescribeBlockByIpTimesListSync(DescribeBlockByIpTimesListRequest req)
        {
             JsonResponseModel<DescribeBlockByIpTimesListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBlockByIpTimesList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBlockByIpTimesListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the most frequent attacker.
        /// </summary>
        /// <param name="req"><see cref="DescribeBlockStaticListRequest"/></param>
        /// <returns><see cref="DescribeBlockStaticListResponse"/></returns>
        public async Task<DescribeBlockStaticListResponse> DescribeBlockStaticList(DescribeBlockStaticListRequest req)
        {
             JsonResponseModel<DescribeBlockStaticListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBlockStaticList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBlockStaticListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the most frequent attacker.
        /// </summary>
        /// <param name="req"><see cref="DescribeBlockStaticListRequest"/></param>
        /// <returns><see cref="DescribeBlockStaticListResponse"/></returns>
        public DescribeBlockStaticListResponse DescribeBlockStaticListSync(DescribeBlockStaticListRequest req)
        {
             JsonResponseModel<DescribeBlockStaticListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBlockStaticList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBlockStaticListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of firewall toggles with Intrusion Defense enabled.
        /// </summary>
        /// <param name="req"><see cref="DescribeDefenseSwitchRequest"/></param>
        /// <returns><see cref="DescribeDefenseSwitchResponse"/></returns>
        public async Task<DescribeDefenseSwitchResponse> DescribeDefenseSwitch(DescribeDefenseSwitchRequest req)
        {
             JsonResponseModel<DescribeDefenseSwitchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDefenseSwitch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDefenseSwitchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of firewall toggles with Intrusion Defense enabled.
        /// </summary>
        /// <param name="req"><see cref="DescribeDefenseSwitchRequest"/></param>
        /// <returns><see cref="DescribeDefenseSwitchResponse"/></returns>
        public DescribeDefenseSwitchResponse DescribeDefenseSwitchSync(DescribeDefenseSwitchRequest req)
        {
             JsonResponseModel<DescribeDefenseSwitchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDefenseSwitch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDefenseSwitchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get enterprise security group rules (new).
        /// </summary>
        /// <param name="req"><see cref="DescribeEnterpriseSecurityGroupRuleRequest"/></param>
        /// <returns><see cref="DescribeEnterpriseSecurityGroupRuleResponse"/></returns>
        public async Task<DescribeEnterpriseSecurityGroupRuleResponse> DescribeEnterpriseSecurityGroupRule(DescribeEnterpriseSecurityGroupRuleRequest req)
        {
             JsonResponseModel<DescribeEnterpriseSecurityGroupRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEnterpriseSecurityGroupRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEnterpriseSecurityGroupRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get enterprise security group rules (new).
        /// </summary>
        /// <param name="req"><see cref="DescribeEnterpriseSecurityGroupRuleRequest"/></param>
        /// <returns><see cref="DescribeEnterpriseSecurityGroupRuleResponse"/></returns>
        public DescribeEnterpriseSecurityGroupRuleResponse DescribeEnterpriseSecurityGroupRuleSync(DescribeEnterpriseSecurityGroupRuleRequest req)
        {
             JsonResponseModel<DescribeEnterpriseSecurityGroupRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEnterpriseSecurityGroupRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEnterpriseSecurityGroupRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the scan interface information in Get Started.
        /// </summary>
        /// <param name="req"><see cref="DescribeGuideScanInfoRequest"/></param>
        /// <returns><see cref="DescribeGuideScanInfoResponse"/></returns>
        public async Task<DescribeGuideScanInfoResponse> DescribeGuideScanInfo(DescribeGuideScanInfoRequest req)
        {
             JsonResponseModel<DescribeGuideScanInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGuideScanInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGuideScanInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the scan interface information in Get Started.
        /// </summary>
        /// <param name="req"><see cref="DescribeGuideScanInfoRequest"/></param>
        /// <returns><see cref="DescribeGuideScanInfoResponse"/></returns>
        public DescribeGuideScanInfoResponse DescribeGuideScanInfoSync(DescribeGuideScanInfoRequest req)
        {
             JsonResponseModel<DescribeGuideScanInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGuideScanInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGuideScanInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the IP protection status.
        /// </summary>
        /// <param name="req"><see cref="DescribeIPStatusListRequest"/></param>
        /// <returns><see cref="DescribeIPStatusListResponse"/></returns>
        public async Task<DescribeIPStatusListResponse> DescribeIPStatusList(DescribeIPStatusListRequest req)
        {
             JsonResponseModel<DescribeIPStatusListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIPStatusList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIPStatusListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the IP protection status.
        /// </summary>
        /// <param name="req"><see cref="DescribeIPStatusListRequest"/></param>
        /// <returns><see cref="DescribeIPStatusListResponse"/></returns>
        public DescribeIPStatusListResponse DescribeIPStatusListSync(DescribeIPStatusListRequest req)
        {
             JsonResponseModel<DescribeIPStatusListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIPStatusList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIPStatusListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the number of a user's subnets connected to NAT firewall and the number of NAT firewall instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeNatFwInfoCountRequest"/></param>
        /// <returns><see cref="DescribeNatFwInfoCountResponse"/></returns>
        public async Task<DescribeNatFwInfoCountResponse> DescribeNatFwInfoCount(DescribeNatFwInfoCountRequest req)
        {
             JsonResponseModel<DescribeNatFwInfoCountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNatFwInfoCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNatFwInfoCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the number of a user's subnets connected to NAT firewall and the number of NAT firewall instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeNatFwInfoCountRequest"/></param>
        /// <returns><see cref="DescribeNatFwInfoCountResponse"/></returns>
        public DescribeNatFwInfoCountResponse DescribeNatFwInfoCountSync(DescribeNatFwInfoCountRequest req)
        {
             JsonResponseModel<DescribeNatFwInfoCountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNatFwInfoCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNatFwInfoCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get all NAT instances of a tenant.
        /// </summary>
        /// <param name="req"><see cref="DescribeNatFwInstanceRequest"/></param>
        /// <returns><see cref="DescribeNatFwInstanceResponse"/></returns>
        public async Task<DescribeNatFwInstanceResponse> DescribeNatFwInstance(DescribeNatFwInstanceRequest req)
        {
             JsonResponseModel<DescribeNatFwInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNatFwInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNatFwInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get all NAT instances of a tenant.
        /// </summary>
        /// <param name="req"><see cref="DescribeNatFwInstanceRequest"/></param>
        /// <returns><see cref="DescribeNatFwInstanceResponse"/></returns>
        public DescribeNatFwInstanceResponse DescribeNatFwInstanceSync(DescribeNatFwInstanceRequest req)
        {
             JsonResponseModel<DescribeNatFwInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNatFwInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNatFwInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the NAT instance with the region that is newly maintained by the tenant.
        /// </summary>
        /// <param name="req"><see cref="DescribeNatFwInstanceWithRegionRequest"/></param>
        /// <returns><see cref="DescribeNatFwInstanceWithRegionResponse"/></returns>
        public async Task<DescribeNatFwInstanceWithRegionResponse> DescribeNatFwInstanceWithRegion(DescribeNatFwInstanceWithRegionRequest req)
        {
             JsonResponseModel<DescribeNatFwInstanceWithRegionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNatFwInstanceWithRegion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNatFwInstanceWithRegionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the NAT instance with the region that is newly maintained by the tenant.
        /// </summary>
        /// <param name="req"><see cref="DescribeNatFwInstanceWithRegionRequest"/></param>
        /// <returns><see cref="DescribeNatFwInstanceWithRegionResponse"/></returns>
        public DescribeNatFwInstanceWithRegionResponse DescribeNatFwInstanceWithRegionSync(DescribeNatFwInstanceWithRegionRequest req)
        {
             JsonResponseModel<DescribeNatFwInstanceWithRegionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNatFwInstanceWithRegion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNatFwInstanceWithRegionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get all NAT instances and instance card information of a tenant.
        /// </summary>
        /// <param name="req"><see cref="DescribeNatFwInstancesInfoRequest"/></param>
        /// <returns><see cref="DescribeNatFwInstancesInfoResponse"/></returns>
        public async Task<DescribeNatFwInstancesInfoResponse> DescribeNatFwInstancesInfo(DescribeNatFwInstancesInfoRequest req)
        {
             JsonResponseModel<DescribeNatFwInstancesInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNatFwInstancesInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNatFwInstancesInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get all NAT instances and instance card information of a tenant.
        /// </summary>
        /// <param name="req"><see cref="DescribeNatFwInstancesInfoRequest"/></param>
        /// <returns><see cref="DescribeNatFwInstancesInfoResponse"/></returns>
        public DescribeNatFwInstancesInfoResponse DescribeNatFwInstancesInfoSync(DescribeNatFwInstancesInfoRequest req)
        {
             JsonResponseModel<DescribeNatFwInstancesInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNatFwInstancesInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNatFwInstancesInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the VPC DNS status of NAT firewall instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeNatFwVpcDnsLstRequest"/></param>
        /// <returns><see cref="DescribeNatFwVpcDnsLstResponse"/></returns>
        public async Task<DescribeNatFwVpcDnsLstResponse> DescribeNatFwVpcDnsLst(DescribeNatFwVpcDnsLstRequest req)
        {
             JsonResponseModel<DescribeNatFwVpcDnsLstResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNatFwVpcDnsLst");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNatFwVpcDnsLstResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the VPC DNS status of NAT firewall instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeNatFwVpcDnsLstRequest"/></param>
        /// <returns><see cref="DescribeNatFwVpcDnsLstResponse"/></returns>
        public DescribeNatFwVpcDnsLstResponse DescribeNatFwVpcDnsLstSync(DescribeNatFwVpcDnsLstRequest req)
        {
             JsonResponseModel<DescribeNatFwVpcDnsLstResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNatFwVpcDnsLst");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNatFwVpcDnsLstResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the asset tree information in Asset Management.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceGroupNewRequest"/></param>
        /// <returns><see cref="DescribeResourceGroupNewResponse"/></returns>
        public async Task<DescribeResourceGroupNewResponse> DescribeResourceGroupNew(DescribeResourceGroupNewRequest req)
        {
             JsonResponseModel<DescribeResourceGroupNewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeResourceGroupNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceGroupNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the asset tree information in Asset Management.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceGroupNewRequest"/></param>
        /// <returns><see cref="DescribeResourceGroupNewResponse"/></returns>
        public DescribeResourceGroupNewResponse DescribeResourceGroupNewSync(DescribeResourceGroupNewRequest req)
        {
             JsonResponseModel<DescribeResourceGroupNewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeResourceGroupNew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceGroupNewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the rule list overview.
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleOverviewRequest"/></param>
        /// <returns><see cref="DescribeRuleOverviewResponse"/></returns>
        public async Task<DescribeRuleOverviewResponse> DescribeRuleOverview(DescribeRuleOverviewRequest req)
        {
             JsonResponseModel<DescribeRuleOverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRuleOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the rule list overview.
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleOverviewRequest"/></param>
        /// <returns><see cref="DescribeRuleOverviewResponse"/></returns>
        public DescribeRuleOverviewResponse DescribeRuleOverviewSync(DescribeRuleOverviewRequest req)
        {
             JsonResponseModel<DescribeRuleOverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRuleOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the security group rule list.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupListRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupListResponse"/></returns>
        public async Task<DescribeSecurityGroupListResponse> DescribeSecurityGroupList(DescribeSecurityGroupListRequest req)
        {
             JsonResponseModel<DescribeSecurityGroupListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecurityGroupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityGroupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the security group rule list.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupListRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupListResponse"/></returns>
        public DescribeSecurityGroupListResponse DescribeSecurityGroupListSync(DescribeSecurityGroupListRequest req)
        {
             JsonResponseModel<DescribeSecurityGroupListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecurityGroupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityGroupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get all asset information of an asset group.
        /// </summary>
        /// <param name="req"><see cref="DescribeSourceAssetRequest"/></param>
        /// <returns><see cref="DescribeSourceAssetResponse"/></returns>
        public async Task<DescribeSourceAssetResponse> DescribeSourceAsset(DescribeSourceAssetRequest req)
        {
             JsonResponseModel<DescribeSourceAssetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSourceAsset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSourceAssetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get all asset information of an asset group.
        /// </summary>
        /// <param name="req"><see cref="DescribeSourceAssetRequest"/></param>
        /// <returns><see cref="DescribeSourceAssetResponse"/></returns>
        public DescribeSourceAssetResponse DescribeSourceAssetSync(DescribeSourceAssetRequest req)
        {
             JsonResponseModel<DescribeSourceAssetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSourceAsset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSourceAssetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the firewall status list.
        /// </summary>
        /// <param name="req"><see cref="DescribeSwitchListsRequest"/></param>
        /// <returns><see cref="DescribeSwitchListsResponse"/></returns>
        public async Task<DescribeSwitchListsResponse> DescribeSwitchLists(DescribeSwitchListsRequest req)
        {
             JsonResponseModel<DescribeSwitchListsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSwitchLists");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSwitchListsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the firewall status list.
        /// </summary>
        /// <param name="req"><see cref="DescribeSwitchListsRequest"/></param>
        /// <returns><see cref="DescribeSwitchListsResponse"/></returns>
        public DescribeSwitchListsResponse DescribeSwitchListsSync(DescribeSwitchListsRequest req)
        {
             JsonResponseModel<DescribeSwitchListsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSwitchLists");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSwitchListsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the current alert monitoring data.
        /// </summary>
        /// <param name="req"><see cref="DescribeTLogInfoRequest"/></param>
        /// <returns><see cref="DescribeTLogInfoResponse"/></returns>
        public async Task<DescribeTLogInfoResponse> DescribeTLogInfo(DescribeTLogInfoRequest req)
        {
             JsonResponseModel<DescribeTLogInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTLogInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTLogInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the current alert monitoring data.
        /// </summary>
        /// <param name="req"><see cref="DescribeTLogInfoRequest"/></param>
        /// <returns><see cref="DescribeTLogInfoResponse"/></returns>
        public DescribeTLogInfoResponse DescribeTLogInfoSync(DescribeTLogInfoRequest req)
        {
             JsonResponseModel<DescribeTLogInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTLogInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTLogInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the most frequent attacker IP.
        /// </summary>
        /// <param name="req"><see cref="DescribeTLogIpListRequest"/></param>
        /// <returns><see cref="DescribeTLogIpListResponse"/></returns>
        public async Task<DescribeTLogIpListResponse> DescribeTLogIpList(DescribeTLogIpListRequest req)
        {
             JsonResponseModel<DescribeTLogIpListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTLogIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTLogIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the most frequent attacker IP.
        /// </summary>
        /// <param name="req"><see cref="DescribeTLogIpListRequest"/></param>
        /// <returns><see cref="DescribeTLogIpListResponse"/></returns>
        public DescribeTLogIpListResponse DescribeTLogIpListSync(DescribeTLogIpListRequest req)
        {
             JsonResponseModel<DescribeTLogIpListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTLogIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTLogIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the rule list status.
        /// </summary>
        /// <param name="req"><see cref="DescribeTableStatusRequest"/></param>
        /// <returns><see cref="DescribeTableStatusResponse"/></returns>
        public async Task<DescribeTableStatusResponse> DescribeTableStatus(DescribeTableStatusRequest req)
        {
             JsonResponseModel<DescribeTableStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTableStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTableStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the rule list status.
        /// </summary>
        /// <param name="req"><see cref="DescribeTableStatusRequest"/></param>
        /// <returns><see cref="DescribeTableStatusResponse"/></returns>
        public DescribeTableStatusResponse DescribeTableStatusSync(DescribeTableStatusRequest req)
        {
             JsonResponseModel<DescribeTableStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTableStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTableStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get unhandled security events.
        /// </summary>
        /// <param name="req"><see cref="DescribeUnHandleEventTabListRequest"/></param>
        /// <returns><see cref="DescribeUnHandleEventTabListResponse"/></returns>
        public async Task<DescribeUnHandleEventTabListResponse> DescribeUnHandleEventTabList(DescribeUnHandleEventTabListRequest req)
        {
             JsonResponseModel<DescribeUnHandleEventTabListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUnHandleEventTabList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUnHandleEventTabListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get unhandled security events.
        /// </summary>
        /// <param name="req"><see cref="DescribeUnHandleEventTabListRequest"/></param>
        /// <returns><see cref="DescribeUnHandleEventTabListResponse"/></returns>
        public DescribeUnHandleEventTabListResponse DescribeUnHandleEventTabListSync(DescribeUnHandleEventTabListRequest req)
        {
             JsonResponseModel<DescribeUnHandleEventTabListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUnHandleEventTabList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUnHandleEventTabListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to increase the firewall bandwidth.
        /// </summary>
        /// <param name="req"><see cref="ExpandCfwVerticalRequest"/></param>
        /// <returns><see cref="ExpandCfwVerticalResponse"/></returns>
        public async Task<ExpandCfwVerticalResponse> ExpandCfwVertical(ExpandCfwVerticalRequest req)
        {
             JsonResponseModel<ExpandCfwVerticalResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExpandCfwVertical");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExpandCfwVerticalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to increase the firewall bandwidth.
        /// </summary>
        /// <param name="req"><see cref="ExpandCfwVerticalRequest"/></param>
        /// <returns><see cref="ExpandCfwVerticalResponse"/></returns>
        public ExpandCfwVerticalResponse ExpandCfwVerticalSync(ExpandCfwVerticalRequest req)
        {
             JsonResponseModel<ExpandCfwVerticalResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExpandCfwVertical");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExpandCfwVerticalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyAcRuleRequest"/></param>
        /// <returns><see cref="ModifyAcRuleResponse"/></returns>
        public async Task<ModifyAcRuleResponse> ModifyAcRule(ModifyAcRuleRequest req)
        {
             JsonResponseModel<ModifyAcRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAcRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAcRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyAcRuleRequest"/></param>
        /// <returns><see cref="ModifyAcRuleResponse"/></returns>
        public ModifyAcRuleResponse ModifyAcRuleSync(ModifyAcRuleRequest req)
        {
             JsonResponseModel<ModifyAcRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAcRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAcRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable or disable one or multiple edge firewalls.
        /// </summary>
        /// <param name="req"><see cref="ModifyAllPublicIPSwitchStatusRequest"/></param>
        /// <returns><see cref="ModifyAllPublicIPSwitchStatusResponse"/></returns>
        public async Task<ModifyAllPublicIPSwitchStatusResponse> ModifyAllPublicIPSwitchStatus(ModifyAllPublicIPSwitchStatusRequest req)
        {
             JsonResponseModel<ModifyAllPublicIPSwitchStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAllPublicIPSwitchStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAllPublicIPSwitchStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable or disable one or multiple edge firewalls.
        /// </summary>
        /// <param name="req"><see cref="ModifyAllPublicIPSwitchStatusRequest"/></param>
        /// <returns><see cref="ModifyAllPublicIPSwitchStatusResponse"/></returns>
        public ModifyAllPublicIPSwitchStatusResponse ModifyAllPublicIPSwitchStatusSync(ModifyAllPublicIPSwitchStatusRequest req)
        {
             JsonResponseModel<ModifyAllPublicIPSwitchStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAllPublicIPSwitchStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAllPublicIPSwitchStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable or disable all rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyAllRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyAllRuleStatusResponse"/></returns>
        public async Task<ModifyAllRuleStatusResponse> ModifyAllRuleStatus(ModifyAllRuleStatusRequest req)
        {
             JsonResponseModel<ModifyAllRuleStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAllRuleStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAllRuleStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable or disable all rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyAllRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyAllRuleStatusResponse"/></returns>
        public ModifyAllRuleStatusResponse ModifyAllRuleStatusSync(ModifyAllRuleStatusRequest req)
        {
             JsonResponseModel<ModifyAllRuleStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAllRuleStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAllRuleStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable or disable one or multiple VPC firewalls.
        /// </summary>
        /// <param name="req"><see cref="ModifyAllVPCSwitchStatusRequest"/></param>
        /// <returns><see cref="ModifyAllVPCSwitchStatusResponse"/></returns>
        public async Task<ModifyAllVPCSwitchStatusResponse> ModifyAllVPCSwitchStatus(ModifyAllVPCSwitchStatusRequest req)
        {
             JsonResponseModel<ModifyAllVPCSwitchStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAllVPCSwitchStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAllVPCSwitchStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable or disable one or multiple VPC firewalls.
        /// </summary>
        /// <param name="req"><see cref="ModifyAllVPCSwitchStatusRequest"/></param>
        /// <returns><see cref="ModifyAllVPCSwitchStatusResponse"/></returns>
        public ModifyAllVPCSwitchStatusResponse ModifyAllVPCSwitchStatusSync(ModifyAllVPCSwitchStatusRequest req)
        {
             JsonResponseModel<ModifyAllVPCSwitchStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAllVPCSwitchStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAllVPCSwitchStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify asset scan settings.
        /// </summary>
        /// <param name="req"><see cref="ModifyAssetScanRequest"/></param>
        /// <returns><see cref="ModifyAssetScanResponse"/></returns>
        public async Task<ModifyAssetScanResponse> ModifyAssetScan(ModifyAssetScanRequest req)
        {
             JsonResponseModel<ModifyAssetScanResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAssetScan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAssetScanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify asset scan settings.
        /// </summary>
        /// <param name="req"><see cref="ModifyAssetScanRequest"/></param>
        /// <returns><see cref="ModifyAssetScanResponse"/></returns>
        public ModifyAssetScanResponse ModifyAssetScanSync(ModifyAssetScanRequest req)
        {
             JsonResponseModel<ModifyAssetScanResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAssetScan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAssetScanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to:
        /// add IPs/domains in the blocklist or ignored list
        /// delete IPs/domains in the blocklist or ignored list
        /// modify IPs/domains in the blocklist or ignored list
        /// </summary>
        /// <param name="req"><see cref="ModifyBlockIgnoreListRequest"/></param>
        /// <returns><see cref="ModifyBlockIgnoreListResponse"/></returns>
        public async Task<ModifyBlockIgnoreListResponse> ModifyBlockIgnoreList(ModifyBlockIgnoreListRequest req)
        {
             JsonResponseModel<ModifyBlockIgnoreListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBlockIgnoreList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBlockIgnoreListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to:
        /// add IPs/domains in the blocklist or ignored list
        /// delete IPs/domains in the blocklist or ignored list
        /// modify IPs/domains in the blocklist or ignored list
        /// </summary>
        /// <param name="req"><see cref="ModifyBlockIgnoreListRequest"/></param>
        /// <returns><see cref="ModifyBlockIgnoreListResponse"/></returns>
        public ModifyBlockIgnoreListResponse ModifyBlockIgnoreListSync(ModifyBlockIgnoreListRequest req)
        {
             JsonResponseModel<ModifyBlockIgnoreListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyBlockIgnoreList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBlockIgnoreListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to pin or unpin a blocking log.
        /// </summary>
        /// <param name="req"><see cref="ModifyBlockTopRequest"/></param>
        /// <returns><see cref="ModifyBlockTopResponse"/></returns>
        public async Task<ModifyBlockTopResponse> ModifyBlockTop(ModifyBlockTopRequest req)
        {
             JsonResponseModel<ModifyBlockTopResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBlockTop");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBlockTopResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to pin or unpin a blocking log.
        /// </summary>
        /// <param name="req"><see cref="ModifyBlockTopRequest"/></param>
        /// <returns><see cref="ModifyBlockTopResponse"/></returns>
        public ModifyBlockTopResponse ModifyBlockTopSync(ModifyBlockTopRequest req)
        {
             JsonResponseModel<ModifyBlockTopResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyBlockTop");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBlockTopResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the VPC or NAT list for changing associated firewall instances.
        /// </summary>
        /// <param name="req"><see cref="ModifyNatFwReSelectRequest"/></param>
        /// <returns><see cref="ModifyNatFwReSelectResponse"/></returns>
        public async Task<ModifyNatFwReSelectResponse> ModifyNatFwReSelect(ModifyNatFwReSelectRequest req)
        {
             JsonResponseModel<ModifyNatFwReSelectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNatFwReSelect");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNatFwReSelectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the VPC or NAT list for changing associated firewall instances.
        /// </summary>
        /// <param name="req"><see cref="ModifyNatFwReSelectRequest"/></param>
        /// <returns><see cref="ModifyNatFwReSelectResponse"/></returns>
        public ModifyNatFwReSelectResponse ModifyNatFwReSelectSync(ModifyNatFwReSelectRequest req)
        {
             JsonResponseModel<ModifyNatFwReSelectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyNatFwReSelect");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNatFwReSelectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable or disable a NAT firewall.
        /// </summary>
        /// <param name="req"><see cref="ModifyNatFwSwitchRequest"/></param>
        /// <returns><see cref="ModifyNatFwSwitchResponse"/></returns>
        public async Task<ModifyNatFwSwitchResponse> ModifyNatFwSwitch(ModifyNatFwSwitchRequest req)
        {
             JsonResponseModel<ModifyNatFwSwitchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNatFwSwitch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNatFwSwitchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable or disable a NAT firewall.
        /// </summary>
        /// <param name="req"><see cref="ModifyNatFwSwitchRequest"/></param>
        /// <returns><see cref="ModifyNatFwSwitchResponse"/></returns>
        public ModifyNatFwSwitchResponse ModifyNatFwSwitchSync(ModifyNatFwSwitchRequest req)
        {
             JsonResponseModel<ModifyNatFwSwitchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyNatFwSwitch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNatFwSwitchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the VPC DNS status of NAT firewall instances.
        /// </summary>
        /// <param name="req"><see cref="ModifyNatFwVpcDnsSwitchRequest"/></param>
        /// <returns><see cref="ModifyNatFwVpcDnsSwitchResponse"/></returns>
        public async Task<ModifyNatFwVpcDnsSwitchResponse> ModifyNatFwVpcDnsSwitch(ModifyNatFwVpcDnsSwitchRequest req)
        {
             JsonResponseModel<ModifyNatFwVpcDnsSwitchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNatFwVpcDnsSwitch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNatFwVpcDnsSwitchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the VPC DNS status of NAT firewall instances.
        /// </summary>
        /// <param name="req"><see cref="ModifyNatFwVpcDnsSwitchRequest"/></param>
        /// <returns><see cref="ModifyNatFwVpcDnsSwitchResponse"/></returns>
        public ModifyNatFwVpcDnsSwitchResponse ModifyNatFwVpcDnsSwitchSync(ModifyNatFwVpcDnsSwitchRequest req)
        {
             JsonResponseModel<ModifyNatFwVpcDnsSwitchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyNatFwVpcDnsSwitch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNatFwVpcDnsSwitchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable or disable an edge firewall.
        /// </summary>
        /// <param name="req"><see cref="ModifyPublicIPSwitchStatusRequest"/></param>
        /// <returns><see cref="ModifyPublicIPSwitchStatusResponse"/></returns>
        public async Task<ModifyPublicIPSwitchStatusResponse> ModifyPublicIPSwitchStatus(ModifyPublicIPSwitchStatusRequest req)
        {
             JsonResponseModel<ModifyPublicIPSwitchStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPublicIPSwitchStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPublicIPSwitchStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable or disable an edge firewall.
        /// </summary>
        /// <param name="req"><see cref="ModifyPublicIPSwitchStatusRequest"/></param>
        /// <returns><see cref="ModifyPublicIPSwitchStatusResponse"/></returns>
        public ModifyPublicIPSwitchStatusResponse ModifyPublicIPSwitchStatusSync(ModifyPublicIPSwitchStatusRequest req)
        {
             JsonResponseModel<ModifyPublicIPSwitchStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPublicIPSwitchStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPublicIPSwitchStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the asset group information in Asset Management.
        /// 
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceGroupRequest"/></param>
        /// <returns><see cref="ModifyResourceGroupResponse"/></returns>
        public async Task<ModifyResourceGroupResponse> ModifyResourceGroup(ModifyResourceGroupRequest req)
        {
             JsonResponseModel<ModifyResourceGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyResourceGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyResourceGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the asset group information in Asset Management.
        /// 
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceGroupRequest"/></param>
        /// <returns><see cref="ModifyResourceGroupResponse"/></returns>
        public ModifyResourceGroupResponse ModifyResourceGroupSync(ModifyResourceGroupRequest req)
        {
             JsonResponseModel<ModifyResourceGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyResourceGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyResourceGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to sync assets - Internet & VPC (new).
        /// </summary>
        /// <param name="req"><see cref="ModifyRunSyncAssetRequest"/></param>
        /// <returns><see cref="ModifyRunSyncAssetResponse"/></returns>
        public async Task<ModifyRunSyncAssetResponse> ModifyRunSyncAsset(ModifyRunSyncAssetRequest req)
        {
             JsonResponseModel<ModifyRunSyncAssetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRunSyncAsset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRunSyncAssetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to sync assets - Internet & VPC (new).
        /// </summary>
        /// <param name="req"><see cref="ModifyRunSyncAssetRequest"/></param>
        /// <returns><see cref="ModifyRunSyncAssetResponse"/></returns>
        public ModifyRunSyncAssetResponse ModifyRunSyncAssetSync(ModifyRunSyncAssetRequest req)
        {
             JsonResponseModel<ModifyRunSyncAssetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRunSyncAsset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRunSyncAssetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable or disable an enterprise security group rule.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupItemRuleStatusRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupItemRuleStatusResponse"/></returns>
        public async Task<ModifySecurityGroupItemRuleStatusResponse> ModifySecurityGroupItemRuleStatus(ModifySecurityGroupItemRuleStatusRequest req)
        {
             JsonResponseModel<ModifySecurityGroupItemRuleStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySecurityGroupItemRuleStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecurityGroupItemRuleStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable or disable an enterprise security group rule.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupItemRuleStatusRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupItemRuleStatusResponse"/></returns>
        public ModifySecurityGroupItemRuleStatusResponse ModifySecurityGroupItemRuleStatusSync(ModifySecurityGroupItemRuleStatusRequest req)
        {
             JsonResponseModel<ModifySecurityGroupItemRuleStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySecurityGroupItemRuleStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecurityGroupItemRuleStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to sort enterprise security group rules.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupSequenceRulesRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupSequenceRulesResponse"/></returns>
        public async Task<ModifySecurityGroupSequenceRulesResponse> ModifySecurityGroupSequenceRules(ModifySecurityGroupSequenceRulesRequest req)
        {
             JsonResponseModel<ModifySecurityGroupSequenceRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySecurityGroupSequenceRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecurityGroupSequenceRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to sort enterprise security group rules.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupSequenceRulesRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupSequenceRulesResponse"/></returns>
        public ModifySecurityGroupSequenceRulesResponse ModifySecurityGroupSequenceRulesSync(ModifySecurityGroupSequenceRulesRequest req)
        {
             JsonResponseModel<ModifySecurityGroupSequenceRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySecurityGroupSequenceRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecurityGroupSequenceRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify rule priority.
        /// </summary>
        /// <param name="req"><see cref="ModifySequenceRulesRequest"/></param>
        /// <returns><see cref="ModifySequenceRulesResponse"/></returns>
        public async Task<ModifySequenceRulesResponse> ModifySequenceRules(ModifySequenceRulesRequest req)
        {
             JsonResponseModel<ModifySequenceRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySequenceRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySequenceRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify rule priority.
        /// </summary>
        /// <param name="req"><see cref="ModifySequenceRulesRequest"/></param>
        /// <returns><see cref="ModifySequenceRulesResponse"/></returns>
        public ModifySequenceRulesResponse ModifySequenceRulesSync(ModifySequenceRulesRequest req)
        {
             JsonResponseModel<ModifySequenceRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySequenceRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySequenceRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify rule list status.
        /// </summary>
        /// <param name="req"><see cref="ModifyTableStatusRequest"/></param>
        /// <returns><see cref="ModifyTableStatusResponse"/></returns>
        public async Task<ModifyTableStatusResponse> ModifyTableStatus(ModifyTableStatusRequest req)
        {
             JsonResponseModel<ModifyTableStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTableStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTableStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify rule list status.
        /// </summary>
        /// <param name="req"><see cref="ModifyTableStatusRequest"/></param>
        /// <returns><see cref="ModifyTableStatusResponse"/></returns>
        public ModifyTableStatusResponse ModifyTableStatusSync(ModifyTableStatusRequest req)
        {
             JsonResponseModel<ModifyTableStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTableStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTableStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete edge firewall rules.
        /// </summary>
        /// <param name="req"><see cref="RemoveAcRuleRequest"/></param>
        /// <returns><see cref="RemoveAcRuleResponse"/></returns>
        public async Task<RemoveAcRuleResponse> RemoveAcRule(RemoveAcRuleRequest req)
        {
             JsonResponseModel<RemoveAcRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RemoveAcRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveAcRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete edge firewall rules.
        /// </summary>
        /// <param name="req"><see cref="RemoveAcRuleRequest"/></param>
        /// <returns><see cref="RemoveAcRuleResponse"/></returns>
        public RemoveAcRuleResponse RemoveAcRuleSync(RemoveAcRuleRequest req)
        {
             JsonResponseModel<RemoveAcRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RemoveAcRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveAcRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete enterprise security group rules (new).
        /// </summary>
        /// <param name="req"><see cref="RemoveEnterpriseSecurityGroupRuleRequest"/></param>
        /// <returns><see cref="RemoveEnterpriseSecurityGroupRuleResponse"/></returns>
        public async Task<RemoveEnterpriseSecurityGroupRuleResponse> RemoveEnterpriseSecurityGroupRule(RemoveEnterpriseSecurityGroupRuleRequest req)
        {
             JsonResponseModel<RemoveEnterpriseSecurityGroupRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RemoveEnterpriseSecurityGroupRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveEnterpriseSecurityGroupRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete enterprise security group rules (new).
        /// </summary>
        /// <param name="req"><see cref="RemoveEnterpriseSecurityGroupRuleRequest"/></param>
        /// <returns><see cref="RemoveEnterpriseSecurityGroupRuleResponse"/></returns>
        public RemoveEnterpriseSecurityGroupRuleResponse RemoveEnterpriseSecurityGroupRuleSync(RemoveEnterpriseSecurityGroupRuleRequest req)
        {
             JsonResponseModel<RemoveEnterpriseSecurityGroupRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RemoveEnterpriseSecurityGroupRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveEnterpriseSecurityGroupRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to configure firewall DNAT rules.
        /// </summary>
        /// <param name="req"><see cref="SetNatFwDnatRuleRequest"/></param>
        /// <returns><see cref="SetNatFwDnatRuleResponse"/></returns>
        public async Task<SetNatFwDnatRuleResponse> SetNatFwDnatRule(SetNatFwDnatRuleRequest req)
        {
             JsonResponseModel<SetNatFwDnatRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetNatFwDnatRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetNatFwDnatRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to configure firewall DNAT rules.
        /// </summary>
        /// <param name="req"><see cref="SetNatFwDnatRuleRequest"/></param>
        /// <returns><see cref="SetNatFwDnatRuleResponse"/></returns>
        public SetNatFwDnatRuleResponse SetNatFwDnatRuleSync(SetNatFwDnatRuleRequest req)
        {
             JsonResponseModel<SetNatFwDnatRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetNatFwDnatRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetNatFwDnatRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the firewall instance EIP. (Available for firewall instances in the "Create new" mode. only)
        /// </summary>
        /// <param name="req"><see cref="SetNatFwEipRequest"/></param>
        /// <returns><see cref="SetNatFwEipResponse"/></returns>
        public async Task<SetNatFwEipResponse> SetNatFwEip(SetNatFwEipRequest req)
        {
             JsonResponseModel<SetNatFwEipResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetNatFwEip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetNatFwEipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the firewall instance EIP. (Available for firewall instances in the "Create new" mode. only)
        /// </summary>
        /// <param name="req"><see cref="SetNatFwEipRequest"/></param>
        /// <returns><see cref="SetNatFwEipResponse"/></returns>
        public SetNatFwEipResponse SetNatFwEipSync(SetNatFwEipRequest req)
        {
             JsonResponseModel<SetNatFwEipResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetNatFwEip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetNatFwEipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to stop publishing security group rules.
        /// </summary>
        /// <param name="req"><see cref="StopSecurityGroupRuleDispatchRequest"/></param>
        /// <returns><see cref="StopSecurityGroupRuleDispatchResponse"/></returns>
        public async Task<StopSecurityGroupRuleDispatchResponse> StopSecurityGroupRuleDispatch(StopSecurityGroupRuleDispatchRequest req)
        {
             JsonResponseModel<StopSecurityGroupRuleDispatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopSecurityGroupRuleDispatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopSecurityGroupRuleDispatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to stop publishing security group rules.
        /// </summary>
        /// <param name="req"><see cref="StopSecurityGroupRuleDispatchRequest"/></param>
        /// <returns><see cref="StopSecurityGroupRuleDispatchResponse"/></returns>
        public StopSecurityGroupRuleDispatchResponse StopSecurityGroupRuleDispatchSync(StopSecurityGroupRuleDispatchRequest req)
        {
             JsonResponseModel<StopSecurityGroupRuleDispatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopSecurityGroupRuleDispatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopSecurityGroupRuleDispatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
