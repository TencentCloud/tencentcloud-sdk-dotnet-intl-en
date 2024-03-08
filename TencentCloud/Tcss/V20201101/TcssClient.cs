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

namespace TencentCloud.Tcss.V20201101
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tcss.V20201101.Models;

   public class TcssClient : AbstractClient{

       private const string endpoint = "tcss.tencentcloudapi.com";
       private const string version = "2020-11-01";
       private const string sdkVersion = "SDK_NET_3.0.853";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TcssClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TcssClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to create a task to add and publish a network policy in the container network.
        /// </summary>
        /// <param name="req"><see cref="AddAndPublishNetworkFirewallPolicyDetailRequest"/></param>
        /// <returns><see cref="AddAndPublishNetworkFirewallPolicyDetailResponse"/></returns>
        public Task<AddAndPublishNetworkFirewallPolicyDetailResponse> AddAndPublishNetworkFirewallPolicyDetail(AddAndPublishNetworkFirewallPolicyDetailRequest req)
        {
            return InternalRequestAsync<AddAndPublishNetworkFirewallPolicyDetailResponse>(req, "AddAndPublishNetworkFirewallPolicyDetail");
        }

        /// <summary>
        /// This API is used to create a task to add and publish a network policy in the container network.
        /// </summary>
        /// <param name="req"><see cref="AddAndPublishNetworkFirewallPolicyDetailRequest"/></param>
        /// <returns><see cref="AddAndPublishNetworkFirewallPolicyDetailResponse"/></returns>
        public AddAndPublishNetworkFirewallPolicyDetailResponse AddAndPublishNetworkFirewallPolicyDetailSync(AddAndPublishNetworkFirewallPolicyDetailRequest req)
        {
            return InternalRequestAsync<AddAndPublishNetworkFirewallPolicyDetailResponse>(req, "AddAndPublishNetworkFirewallPolicyDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a task to configure and publish a YAML network policy in the container network.
        /// </summary>
        /// <param name="req"><see cref="AddAndPublishNetworkFirewallPolicyYamlDetailRequest"/></param>
        /// <returns><see cref="AddAndPublishNetworkFirewallPolicyYamlDetailResponse"/></returns>
        public Task<AddAndPublishNetworkFirewallPolicyYamlDetailResponse> AddAndPublishNetworkFirewallPolicyYamlDetail(AddAndPublishNetworkFirewallPolicyYamlDetailRequest req)
        {
            return InternalRequestAsync<AddAndPublishNetworkFirewallPolicyYamlDetailResponse>(req, "AddAndPublishNetworkFirewallPolicyYamlDetail");
        }

        /// <summary>
        /// This API is used to create a task to configure and publish a YAML network policy in the container network.
        /// </summary>
        /// <param name="req"><see cref="AddAndPublishNetworkFirewallPolicyYamlDetailRequest"/></param>
        /// <returns><see cref="AddAndPublishNetworkFirewallPolicyYamlDetailResponse"/></returns>
        public AddAndPublishNetworkFirewallPolicyYamlDetailResponse AddAndPublishNetworkFirewallPolicyYamlDetailSync(AddAndPublishNetworkFirewallPolicyYamlDetailRequest req)
        {
            return InternalRequestAsync<AddAndPublishNetworkFirewallPolicyYamlDetailResponse>(req, "AddAndPublishNetworkFirewallPolicyYamlDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add the details of an image repository.
        /// </summary>
        /// <param name="req"><see cref="AddAssetImageRegistryRegistryDetailRequest"/></param>
        /// <returns><see cref="AddAssetImageRegistryRegistryDetailResponse"/></returns>
        public Task<AddAssetImageRegistryRegistryDetailResponse> AddAssetImageRegistryRegistryDetail(AddAssetImageRegistryRegistryDetailRequest req)
        {
            return InternalRequestAsync<AddAssetImageRegistryRegistryDetailResponse>(req, "AddAssetImageRegistryRegistryDetail");
        }

        /// <summary>
        /// This API is used to add the details of an image repository.
        /// </summary>
        /// <param name="req"><see cref="AddAssetImageRegistryRegistryDetailRequest"/></param>
        /// <returns><see cref="AddAssetImageRegistryRegistryDetailResponse"/></returns>
        public AddAssetImageRegistryRegistryDetailResponse AddAssetImageRegistryRegistryDetailSync(AddAssetImageRegistryRegistryDetailRequest req)
        {
            return InternalRequestAsync<AddAssetImageRegistryRegistryDetailResponse>(req, "AddAssetImageRegistryRegistryDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to ignore the specified asset IDs and check item IDs so as to hide the assets contained in the specified check items.
        /// `AddCompliancePolicyItemToWhitelist` is the reference API. Except for the input field, others should be the same, and if not, it may be due to the definition.
        /// </summary>
        /// <param name="req"><see cref="AddComplianceAssetPolicySetToWhitelistRequest"/></param>
        /// <returns><see cref="AddComplianceAssetPolicySetToWhitelistResponse"/></returns>
        public Task<AddComplianceAssetPolicySetToWhitelistResponse> AddComplianceAssetPolicySetToWhitelist(AddComplianceAssetPolicySetToWhitelistRequest req)
        {
            return InternalRequestAsync<AddComplianceAssetPolicySetToWhitelistResponse>(req, "AddComplianceAssetPolicySetToWhitelist");
        }

        /// <summary>
        /// This API is used to ignore the specified asset IDs and check item IDs so as to hide the assets contained in the specified check items.
        /// `AddCompliancePolicyItemToWhitelist` is the reference API. Except for the input field, others should be the same, and if not, it may be due to the definition.
        /// </summary>
        /// <param name="req"><see cref="AddComplianceAssetPolicySetToWhitelistRequest"/></param>
        /// <returns><see cref="AddComplianceAssetPolicySetToWhitelistResponse"/></returns>
        public AddComplianceAssetPolicySetToWhitelistResponse AddComplianceAssetPolicySetToWhitelistSync(AddComplianceAssetPolicySetToWhitelistRequest req)
        {
            return InternalRequestAsync<AddComplianceAssetPolicySetToWhitelistResponse>(req, "AddComplianceAssetPolicySetToWhitelist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to ignore the specified asset IDs and check item IDs so as to hide the assets contained in the specified check items.
        /// `AddCompliancePolicyItemToWhitelist` is the reference API. Except for the input field, others should be the same, and if not, it may be due to the definition.
        /// </summary>
        /// <param name="req"><see cref="AddCompliancePolicyAssetSetToWhitelistRequest"/></param>
        /// <returns><see cref="AddCompliancePolicyAssetSetToWhitelistResponse"/></returns>
        public Task<AddCompliancePolicyAssetSetToWhitelistResponse> AddCompliancePolicyAssetSetToWhitelist(AddCompliancePolicyAssetSetToWhitelistRequest req)
        {
            return InternalRequestAsync<AddCompliancePolicyAssetSetToWhitelistResponse>(req, "AddCompliancePolicyAssetSetToWhitelist");
        }

        /// <summary>
        /// This API is used to ignore the specified asset IDs and check item IDs so as to hide the assets contained in the specified check items.
        /// `AddCompliancePolicyItemToWhitelist` is the reference API. Except for the input field, others should be the same, and if not, it may be due to the definition.
        /// </summary>
        /// <param name="req"><see cref="AddCompliancePolicyAssetSetToWhitelistRequest"/></param>
        /// <returns><see cref="AddCompliancePolicyAssetSetToWhitelistResponse"/></returns>
        public AddCompliancePolicyAssetSetToWhitelistResponse AddCompliancePolicyAssetSetToWhitelistSync(AddCompliancePolicyAssetSetToWhitelistRequest req)
        {
            return InternalRequestAsync<AddCompliancePolicyAssetSetToWhitelistResponse>(req, "AddCompliancePolicyAssetSetToWhitelist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add the specified check item IDs to the allowlist so as to hide the failure result.
        /// </summary>
        /// <param name="req"><see cref="AddCompliancePolicyItemToWhitelistRequest"/></param>
        /// <returns><see cref="AddCompliancePolicyItemToWhitelistResponse"/></returns>
        public Task<AddCompliancePolicyItemToWhitelistResponse> AddCompliancePolicyItemToWhitelist(AddCompliancePolicyItemToWhitelistRequest req)
        {
            return InternalRequestAsync<AddCompliancePolicyItemToWhitelistResponse>(req, "AddCompliancePolicyItemToWhitelist");
        }

        /// <summary>
        /// This API is used to add the specified check item IDs to the allowlist so as to hide the failure result.
        /// </summary>
        /// <param name="req"><see cref="AddCompliancePolicyItemToWhitelistRequest"/></param>
        /// <returns><see cref="AddCompliancePolicyItemToWhitelistResponse"/></returns>
        public AddCompliancePolicyItemToWhitelistResponse AddCompliancePolicyItemToWhitelistSync(AddCompliancePolicyItemToWhitelistRequest req)
        {
            return InternalRequestAsync<AddCompliancePolicyItemToWhitelistResponse>(req, "AddCompliancePolicyItemToWhitelist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add or edit an abnormal process policy at runtime.
        /// </summary>
        /// <param name="req"><see cref="AddEditAbnormalProcessRuleRequest"/></param>
        /// <returns><see cref="AddEditAbnormalProcessRuleResponse"/></returns>
        public Task<AddEditAbnormalProcessRuleResponse> AddEditAbnormalProcessRule(AddEditAbnormalProcessRuleRequest req)
        {
            return InternalRequestAsync<AddEditAbnormalProcessRuleResponse>(req, "AddEditAbnormalProcessRule");
        }

        /// <summary>
        /// This API is used to add or edit an abnormal process policy at runtime.
        /// </summary>
        /// <param name="req"><see cref="AddEditAbnormalProcessRuleRequest"/></param>
        /// <returns><see cref="AddEditAbnormalProcessRuleResponse"/></returns>
        public AddEditAbnormalProcessRuleResponse AddEditAbnormalProcessRuleSync(AddEditAbnormalProcessRuleRequest req)
        {
            return InternalRequestAsync<AddEditAbnormalProcessRuleResponse>(req, "AddEditAbnormalProcessRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add or edit an access control policy at runtime.
        /// </summary>
        /// <param name="req"><see cref="AddEditAccessControlRuleRequest"/></param>
        /// <returns><see cref="AddEditAccessControlRuleResponse"/></returns>
        public Task<AddEditAccessControlRuleResponse> AddEditAccessControlRule(AddEditAccessControlRuleRequest req)
        {
            return InternalRequestAsync<AddEditAccessControlRuleResponse>(req, "AddEditAccessControlRule");
        }

        /// <summary>
        /// This API is used to add or edit an access control policy at runtime.
        /// </summary>
        /// <param name="req"><see cref="AddEditAccessControlRuleRequest"/></param>
        /// <returns><see cref="AddEditAccessControlRuleResponse"/></returns>
        public AddEditAccessControlRuleResponse AddEditAccessControlRuleSync(AddEditAccessControlRuleRequest req)
        {
            return InternalRequestAsync<AddEditAccessControlRuleResponse>(req, "AddEditAccessControlRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add or edit an automatic licensing rule for local images.
        /// </summary>
        /// <param name="req"><see cref="AddEditImageAutoAuthorizedRuleRequest"/></param>
        /// <returns><see cref="AddEditImageAutoAuthorizedRuleResponse"/></returns>
        public Task<AddEditImageAutoAuthorizedRuleResponse> AddEditImageAutoAuthorizedRule(AddEditImageAutoAuthorizedRuleRequest req)
        {
            return InternalRequestAsync<AddEditImageAutoAuthorizedRuleResponse>(req, "AddEditImageAutoAuthorizedRule");
        }

        /// <summary>
        /// This API is used to add or edit an automatic licensing rule for local images.
        /// </summary>
        /// <param name="req"><see cref="AddEditImageAutoAuthorizedRuleRequest"/></param>
        /// <returns><see cref="AddEditImageAutoAuthorizedRuleResponse"/></returns>
        public AddEditImageAutoAuthorizedRuleResponse AddEditImageAutoAuthorizedRuleSync(AddEditImageAutoAuthorizedRuleRequest req)
        {
            return InternalRequestAsync<AddEditImageAutoAuthorizedRuleResponse>(req, "AddEditImageAutoAuthorizedRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add or edit an allowed reverse shell at runtime.
        /// </summary>
        /// <param name="req"><see cref="AddEditReverseShellWhiteListRequest"/></param>
        /// <returns><see cref="AddEditReverseShellWhiteListResponse"/></returns>
        public Task<AddEditReverseShellWhiteListResponse> AddEditReverseShellWhiteList(AddEditReverseShellWhiteListRequest req)
        {
            return InternalRequestAsync<AddEditReverseShellWhiteListResponse>(req, "AddEditReverseShellWhiteList");
        }

        /// <summary>
        /// This API is used to add or edit an allowed reverse shell at runtime.
        /// </summary>
        /// <param name="req"><see cref="AddEditReverseShellWhiteListRequest"/></param>
        /// <returns><see cref="AddEditReverseShellWhiteListResponse"/></returns>
        public AddEditReverseShellWhiteListResponse AddEditReverseShellWhiteListSync(AddEditReverseShellWhiteListRequest req)
        {
            return InternalRequestAsync<AddEditReverseShellWhiteListResponse>(req, "AddEditReverseShellWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add or edit an allowed high-risk syscall at runtime.
        /// </summary>
        /// <param name="req"><see cref="AddEditRiskSyscallWhiteListRequest"/></param>
        /// <returns><see cref="AddEditRiskSyscallWhiteListResponse"/></returns>
        public Task<AddEditRiskSyscallWhiteListResponse> AddEditRiskSyscallWhiteList(AddEditRiskSyscallWhiteListRequest req)
        {
            return InternalRequestAsync<AddEditRiskSyscallWhiteListResponse>(req, "AddEditRiskSyscallWhiteList");
        }

        /// <summary>
        /// This API is used to add or edit an allowed high-risk syscall at runtime.
        /// </summary>
        /// <param name="req"><see cref="AddEditRiskSyscallWhiteListRequest"/></param>
        /// <returns><see cref="AddEditRiskSyscallWhiteListResponse"/></returns>
        public AddEditRiskSyscallWhiteListResponse AddEditRiskSyscallWhiteListSync(AddEditRiskSyscallWhiteListRequest req)
        {
            return InternalRequestAsync<AddEditRiskSyscallWhiteListResponse>(req, "AddEditRiskSyscallWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add or edit an alert policy.
        /// </summary>
        /// <param name="req"><see cref="AddEditWarningRulesRequest"/></param>
        /// <returns><see cref="AddEditWarningRulesResponse"/></returns>
        public Task<AddEditWarningRulesResponse> AddEditWarningRules(AddEditWarningRulesRequest req)
        {
            return InternalRequestAsync<AddEditWarningRulesResponse>(req, "AddEditWarningRules");
        }

        /// <summary>
        /// This API is used to add or edit an alert policy.
        /// </summary>
        /// <param name="req"><see cref="AddEditWarningRulesRequest"/></param>
        /// <returns><see cref="AddEditWarningRulesResponse"/></returns>
        public AddEditWarningRulesResponse AddEditWarningRulesSync(AddEditWarningRulesRequest req)
        {
            return InternalRequestAsync<AddEditWarningRulesResponse>(req, "AddEditWarningRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add an allowed escape.
        /// </summary>
        /// <param name="req"><see cref="AddEscapeWhiteListRequest"/></param>
        /// <returns><see cref="AddEscapeWhiteListResponse"/></returns>
        public Task<AddEscapeWhiteListResponse> AddEscapeWhiteList(AddEscapeWhiteListRequest req)
        {
            return InternalRequestAsync<AddEscapeWhiteListResponse>(req, "AddEscapeWhiteList");
        }

        /// <summary>
        /// This API is used to add an allowed escape.
        /// </summary>
        /// <param name="req"><see cref="AddEscapeWhiteListRequest"/></param>
        /// <returns><see cref="AddEscapeWhiteListResponse"/></returns>
        public AddEscapeWhiteListResponse AddEscapeWhiteListSync(AddEscapeWhiteListRequest req)
        {
            return InternalRequestAsync<AddEscapeWhiteListResponse>(req, "AddEscapeWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add ignored vulnerabilities in a vulnerability scan.
        /// </summary>
        /// <param name="req"><see cref="AddIgnoreVulRequest"/></param>
        /// <returns><see cref="AddIgnoreVulResponse"/></returns>
        public Task<AddIgnoreVulResponse> AddIgnoreVul(AddIgnoreVulRequest req)
        {
            return InternalRequestAsync<AddIgnoreVulResponse>(req, "AddIgnoreVul");
        }

        /// <summary>
        /// This API is used to add ignored vulnerabilities in a vulnerability scan.
        /// </summary>
        /// <param name="req"><see cref="AddIgnoreVulRequest"/></param>
        /// <returns><see cref="AddIgnoreVulResponse"/></returns>
        public AddIgnoreVulResponse AddIgnoreVulSync(AddIgnoreVulRequest req)
        {
            return InternalRequestAsync<AddIgnoreVulResponse>(req, "AddIgnoreVul")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a task to add a network policy in the container network.
        /// </summary>
        /// <param name="req"><see cref="AddNetworkFirewallPolicyDetailRequest"/></param>
        /// <returns><see cref="AddNetworkFirewallPolicyDetailResponse"/></returns>
        public Task<AddNetworkFirewallPolicyDetailResponse> AddNetworkFirewallPolicyDetail(AddNetworkFirewallPolicyDetailRequest req)
        {
            return InternalRequestAsync<AddNetworkFirewallPolicyDetailResponse>(req, "AddNetworkFirewallPolicyDetail");
        }

        /// <summary>
        /// This API is used to create a task to add a network policy in the container network.
        /// </summary>
        /// <param name="req"><see cref="AddNetworkFirewallPolicyDetailRequest"/></param>
        /// <returns><see cref="AddNetworkFirewallPolicyDetailResponse"/></returns>
        public AddNetworkFirewallPolicyDetailResponse AddNetworkFirewallPolicyDetailSync(AddNetworkFirewallPolicyDetailRequest req)
        {
            return InternalRequestAsync<AddNetworkFirewallPolicyDetailResponse>(req, "AddNetworkFirewallPolicyDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a task to add a YAML network policy in the container network.
        /// </summary>
        /// <param name="req"><see cref="AddNetworkFirewallPolicyYamlDetailRequest"/></param>
        /// <returns><see cref="AddNetworkFirewallPolicyYamlDetailResponse"/></returns>
        public Task<AddNetworkFirewallPolicyYamlDetailResponse> AddNetworkFirewallPolicyYamlDetail(AddNetworkFirewallPolicyYamlDetailRequest req)
        {
            return InternalRequestAsync<AddNetworkFirewallPolicyYamlDetailResponse>(req, "AddNetworkFirewallPolicyYamlDetail");
        }

        /// <summary>
        /// This API is used to create a task to add a YAML network policy in the container network.
        /// </summary>
        /// <param name="req"><see cref="AddNetworkFirewallPolicyYamlDetailRequest"/></param>
        /// <returns><see cref="AddNetworkFirewallPolicyYamlDetailResponse"/></returns>
        public AddNetworkFirewallPolicyYamlDetailResponse AddNetworkFirewallPolicyYamlDetailSync(AddNetworkFirewallPolicyYamlDetailRequest req)
        {
            return InternalRequestAsync<AddNetworkFirewallPolicyYamlDetailResponse>(req, "AddNetworkFirewallPolicyYamlDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a task to check a YAML network policy in the container network.
        /// </summary>
        /// <param name="req"><see cref="CheckNetworkFirewallPolicyYamlRequest"/></param>
        /// <returns><see cref="CheckNetworkFirewallPolicyYamlResponse"/></returns>
        public Task<CheckNetworkFirewallPolicyYamlResponse> CheckNetworkFirewallPolicyYaml(CheckNetworkFirewallPolicyYamlRequest req)
        {
            return InternalRequestAsync<CheckNetworkFirewallPolicyYamlResponse>(req, "CheckNetworkFirewallPolicyYaml");
        }

        /// <summary>
        /// This API is used to create a task to check a YAML network policy in the container network.
        /// </summary>
        /// <param name="req"><see cref="CheckNetworkFirewallPolicyYamlRequest"/></param>
        /// <returns><see cref="CheckNetworkFirewallPolicyYamlResponse"/></returns>
        public CheckNetworkFirewallPolicyYamlResponse CheckNetworkFirewallPolicyYamlSync(CheckNetworkFirewallPolicyYamlRequest req)
        {
            return InternalRequestAsync<CheckNetworkFirewallPolicyYamlResponse>(req, "CheckNetworkFirewallPolicyYaml")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to check whether an image repository name is duplicated.
        /// </summary>
        /// <param name="req"><see cref="CheckRepeatAssetImageRegistryRequest"/></param>
        /// <returns><see cref="CheckRepeatAssetImageRegistryResponse"/></returns>
        public Task<CheckRepeatAssetImageRegistryResponse> CheckRepeatAssetImageRegistry(CheckRepeatAssetImageRegistryRequest req)
        {
            return InternalRequestAsync<CheckRepeatAssetImageRegistryResponse>(req, "CheckRepeatAssetImageRegistry");
        }

        /// <summary>
        /// This API is used to check whether an image repository name is duplicated.
        /// </summary>
        /// <param name="req"><see cref="CheckRepeatAssetImageRegistryRequest"/></param>
        /// <returns><see cref="CheckRepeatAssetImageRegistryResponse"/></returns>
        public CheckRepeatAssetImageRegistryResponse CheckRepeatAssetImageRegistrySync(CheckRepeatAssetImageRegistryRequest req)
        {
            return InternalRequestAsync<CheckRepeatAssetImageRegistryResponse>(req, "CheckRepeatAssetImageRegistry")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a task to confirm a network policy in the container network.
        /// </summary>
        /// <param name="req"><see cref="ConfirmNetworkFirewallPolicyRequest"/></param>
        /// <returns><see cref="ConfirmNetworkFirewallPolicyResponse"/></returns>
        public Task<ConfirmNetworkFirewallPolicyResponse> ConfirmNetworkFirewallPolicy(ConfirmNetworkFirewallPolicyRequest req)
        {
            return InternalRequestAsync<ConfirmNetworkFirewallPolicyResponse>(req, "ConfirmNetworkFirewallPolicy");
        }

        /// <summary>
        /// This API is used to create a task to confirm a network policy in the container network.
        /// </summary>
        /// <param name="req"><see cref="ConfirmNetworkFirewallPolicyRequest"/></param>
        /// <returns><see cref="ConfirmNetworkFirewallPolicyResponse"/></returns>
        public ConfirmNetworkFirewallPolicyResponse ConfirmNetworkFirewallPolicySync(ConfirmNetworkFirewallPolicyRequest req)
        {
            return InternalRequestAsync<ConfirmNetworkFirewallPolicyResponse>(req, "ConfirmNetworkFirewallPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export abnormal process rules.
        /// </summary>
        /// <param name="req"><see cref="CreateAbnormalProcessRulesExportJobRequest"/></param>
        /// <returns><see cref="CreateAbnormalProcessRulesExportJobResponse"/></returns>
        public Task<CreateAbnormalProcessRulesExportJobResponse> CreateAbnormalProcessRulesExportJob(CreateAbnormalProcessRulesExportJobRequest req)
        {
            return InternalRequestAsync<CreateAbnormalProcessRulesExportJobResponse>(req, "CreateAbnormalProcessRulesExportJob");
        }

        /// <summary>
        /// This API is used to export abnormal process rules.
        /// </summary>
        /// <param name="req"><see cref="CreateAbnormalProcessRulesExportJobRequest"/></param>
        /// <returns><see cref="CreateAbnormalProcessRulesExportJobResponse"/></returns>
        public CreateAbnormalProcessRulesExportJobResponse CreateAbnormalProcessRulesExportJobSync(CreateAbnormalProcessRulesExportJobRequest req)
        {
            return InternalRequestAsync<CreateAbnormalProcessRulesExportJobResponse>(req, "CreateAbnormalProcessRulesExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export file tampering detection rules.
        /// </summary>
        /// <param name="req"><see cref="CreateAccessControlsRuleExportJobRequest"/></param>
        /// <returns><see cref="CreateAccessControlsRuleExportJobResponse"/></returns>
        public Task<CreateAccessControlsRuleExportJobResponse> CreateAccessControlsRuleExportJob(CreateAccessControlsRuleExportJobRequest req)
        {
            return InternalRequestAsync<CreateAccessControlsRuleExportJobResponse>(req, "CreateAccessControlsRuleExportJob");
        }

        /// <summary>
        /// This API is used to export file tampering detection rules.
        /// </summary>
        /// <param name="req"><see cref="CreateAccessControlsRuleExportJobRequest"/></param>
        /// <returns><see cref="CreateAccessControlsRuleExportJobResponse"/></returns>
        public CreateAccessControlsRuleExportJobResponse CreateAccessControlsRuleExportJobSync(CreateAccessControlsRuleExportJobRequest req)
        {
            return InternalRequestAsync<CreateAccessControlsRuleExportJobResponse>(req, "CreateAccessControlsRuleExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an image scan task for an image repository.
        /// </summary>
        /// <param name="req"><see cref="CreateAssetImageRegistryScanTaskRequest"/></param>
        /// <returns><see cref="CreateAssetImageRegistryScanTaskResponse"/></returns>
        public Task<CreateAssetImageRegistryScanTaskResponse> CreateAssetImageRegistryScanTask(CreateAssetImageRegistryScanTaskRequest req)
        {
            return InternalRequestAsync<CreateAssetImageRegistryScanTaskResponse>(req, "CreateAssetImageRegistryScanTask");
        }

        /// <summary>
        /// This API is used to create an image scan task for an image repository.
        /// </summary>
        /// <param name="req"><see cref="CreateAssetImageRegistryScanTaskRequest"/></param>
        /// <returns><see cref="CreateAssetImageRegistryScanTaskResponse"/></returns>
        public CreateAssetImageRegistryScanTaskResponse CreateAssetImageRegistryScanTaskSync(CreateAssetImageRegistryScanTaskRequest req)
        {
            return InternalRequestAsync<CreateAssetImageRegistryScanTaskResponse>(req, "CreateAssetImageRegistryScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a quick image scan task for an image repository.
        /// </summary>
        /// <param name="req"><see cref="CreateAssetImageRegistryScanTaskOneKeyRequest"/></param>
        /// <returns><see cref="CreateAssetImageRegistryScanTaskOneKeyResponse"/></returns>
        public Task<CreateAssetImageRegistryScanTaskOneKeyResponse> CreateAssetImageRegistryScanTaskOneKey(CreateAssetImageRegistryScanTaskOneKeyRequest req)
        {
            return InternalRequestAsync<CreateAssetImageRegistryScanTaskOneKeyResponse>(req, "CreateAssetImageRegistryScanTaskOneKey");
        }

        /// <summary>
        /// This API is used to create a quick image scan task for an image repository.
        /// </summary>
        /// <param name="req"><see cref="CreateAssetImageRegistryScanTaskOneKeyRequest"/></param>
        /// <returns><see cref="CreateAssetImageRegistryScanTaskOneKeyResponse"/></returns>
        public CreateAssetImageRegistryScanTaskOneKeyResponse CreateAssetImageRegistryScanTaskOneKeySync(CreateAssetImageRegistryScanTaskOneKeyRequest req)
        {
            return InternalRequestAsync<CreateAssetImageRegistryScanTaskOneKeyResponse>(req, "CreateAssetImageRegistryScanTaskOneKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set an image scan.
        /// </summary>
        /// <param name="req"><see cref="CreateAssetImageScanSettingRequest"/></param>
        /// <returns><see cref="CreateAssetImageScanSettingResponse"/></returns>
        public Task<CreateAssetImageScanSettingResponse> CreateAssetImageScanSetting(CreateAssetImageScanSettingRequest req)
        {
            return InternalRequestAsync<CreateAssetImageScanSettingResponse>(req, "CreateAssetImageScanSetting");
        }

        /// <summary>
        /// This API is used to set an image scan.
        /// </summary>
        /// <param name="req"><see cref="CreateAssetImageScanSettingRequest"/></param>
        /// <returns><see cref="CreateAssetImageScanSettingResponse"/></returns>
        public CreateAssetImageScanSettingResponse CreateAssetImageScanSettingSync(CreateAssetImageScanSettingRequest req)
        {
            return InternalRequestAsync<CreateAssetImageScanSettingResponse>(req, "CreateAssetImageScanSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an image scan task.
        /// </summary>
        /// <param name="req"><see cref="CreateAssetImageScanTaskRequest"/></param>
        /// <returns><see cref="CreateAssetImageScanTaskResponse"/></returns>
        public Task<CreateAssetImageScanTaskResponse> CreateAssetImageScanTask(CreateAssetImageScanTaskRequest req)
        {
            return InternalRequestAsync<CreateAssetImageScanTaskResponse>(req, "CreateAssetImageScanTask");
        }

        /// <summary>
        /// This API is used to create an image scan task.
        /// </summary>
        /// <param name="req"><see cref="CreateAssetImageScanTaskRequest"/></param>
        /// <returns><see cref="CreateAssetImageScanTaskResponse"/></returns>
        public CreateAssetImageScanTaskResponse CreateAssetImageScanTaskSync(CreateAssetImageScanTaskRequest req)
        {
            return InternalRequestAsync<CreateAssetImageScanTaskResponse>(req, "CreateAssetImageScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a task to export the list of trojans in a local image.
        /// </summary>
        /// <param name="req"><see cref="CreateAssetImageVirusExportJobRequest"/></param>
        /// <returns><see cref="CreateAssetImageVirusExportJobResponse"/></returns>
        public Task<CreateAssetImageVirusExportJobResponse> CreateAssetImageVirusExportJob(CreateAssetImageVirusExportJobRequest req)
        {
            return InternalRequestAsync<CreateAssetImageVirusExportJobResponse>(req, "CreateAssetImageVirusExportJob");
        }

        /// <summary>
        /// This API is used to create a task to export the list of trojans in a local image.
        /// </summary>
        /// <param name="req"><see cref="CreateAssetImageVirusExportJobRequest"/></param>
        /// <returns><see cref="CreateAssetImageVirusExportJobResponse"/></returns>
        public CreateAssetImageVirusExportJobResponse CreateAssetImageVirusExportJobSync(CreateAssetImageVirusExportJobRequest req)
        {
            return InternalRequestAsync<CreateAssetImageVirusExportJobResponse>(req, "CreateAssetImageVirusExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to install the check component and create a defender.
        /// </summary>
        /// <param name="req"><see cref="CreateCheckComponentRequest"/></param>
        /// <returns><see cref="CreateCheckComponentResponse"/></returns>
        public Task<CreateCheckComponentResponse> CreateCheckComponent(CreateCheckComponentRequest req)
        {
            return InternalRequestAsync<CreateCheckComponentResponse>(req, "CreateCheckComponent");
        }

        /// <summary>
        /// This API is used to install the check component and create a defender.
        /// </summary>
        /// <param name="req"><see cref="CreateCheckComponentRequest"/></param>
        /// <returns><see cref="CreateCheckComponentResponse"/></returns>
        public CreateCheckComponentResponse CreateCheckComponentSync(CreateCheckComponentRequest req)
        {
            return InternalRequestAsync<CreateCheckComponentResponse>(req, "CreateCheckComponent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a cluster check task to check it for risk items.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterCheckTaskRequest"/></param>
        /// <returns><see cref="CreateClusterCheckTaskResponse"/></returns>
        public Task<CreateClusterCheckTaskResponse> CreateClusterCheckTask(CreateClusterCheckTaskRequest req)
        {
            return InternalRequestAsync<CreateClusterCheckTaskResponse>(req, "CreateClusterCheckTask");
        }

        /// <summary>
        /// This API is used to create a cluster check task to check it for risk items.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterCheckTaskRequest"/></param>
        /// <returns><see cref="CreateClusterCheckTaskResponse"/></returns>
        public CreateClusterCheckTaskResponse CreateClusterCheckTaskSync(CreateClusterCheckTaskRequest req)
        {
            return InternalRequestAsync<CreateClusterCheckTaskResponse>(req, "CreateClusterCheckTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a compliance check task for another check triggered at the asset level.
        /// </summary>
        /// <param name="req"><see cref="CreateComplianceTaskRequest"/></param>
        /// <returns><see cref="CreateComplianceTaskResponse"/></returns>
        public Task<CreateComplianceTaskResponse> CreateComplianceTask(CreateComplianceTaskRequest req)
        {
            return InternalRequestAsync<CreateComplianceTaskResponse>(req, "CreateComplianceTask");
        }

        /// <summary>
        /// This API is used to create a compliance check task for another check triggered at the asset level.
        /// </summary>
        /// <param name="req"><see cref="CreateComplianceTaskRequest"/></param>
        /// <returns><see cref="CreateComplianceTaskResponse"/></returns>
        public CreateComplianceTaskResponse CreateComplianceTaskSync(CreateComplianceTaskRequest req)
        {
            return InternalRequestAsync<CreateComplianceTaskResponse>(req, "CreateComplianceTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the list of components in a local image.
        /// </summary>
        /// <param name="req"><see cref="CreateComponentExportJobRequest"/></param>
        /// <returns><see cref="CreateComponentExportJobResponse"/></returns>
        public Task<CreateComponentExportJobResponse> CreateComponentExportJob(CreateComponentExportJobRequest req)
        {
            return InternalRequestAsync<CreateComponentExportJobResponse>(req, "CreateComponentExportJob");
        }

        /// <summary>
        /// This API is used to export the list of components in a local image.
        /// </summary>
        /// <param name="req"><see cref="CreateComponentExportJobRequest"/></param>
        /// <returns><see cref="CreateComponentExportJobResponse"/></returns>
        public CreateComponentExportJobResponse CreateComponentExportJobSync(CreateComponentExportJobRequest req)
        {
            return InternalRequestAsync<CreateComponentExportJobResponse>(req, "CreateComponentExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a task to export vulnerabilities that can be prevented.
        /// </summary>
        /// <param name="req"><see cref="CreateDefenceVulExportJobRequest"/></param>
        /// <returns><see cref="CreateDefenceVulExportJobResponse"/></returns>
        public Task<CreateDefenceVulExportJobResponse> CreateDefenceVulExportJob(CreateDefenceVulExportJobRequest req)
        {
            return InternalRequestAsync<CreateDefenceVulExportJobResponse>(req, "CreateDefenceVulExportJob");
        }

        /// <summary>
        /// This API is used to create a task to export vulnerabilities that can be prevented.
        /// </summary>
        /// <param name="req"><see cref="CreateDefenceVulExportJobRequest"/></param>
        /// <returns><see cref="CreateDefenceVulExportJobResponse"/></returns>
        public CreateDefenceVulExportJobResponse CreateDefenceVulExportJobSync(CreateDefenceVulExportJobRequest req)
        {
            return InternalRequestAsync<CreateDefenceVulExportJobResponse>(req, "CreateDefenceVulExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a task to export emergency vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="CreateEmergencyVulExportJobRequest"/></param>
        /// <returns><see cref="CreateEmergencyVulExportJobResponse"/></returns>
        public Task<CreateEmergencyVulExportJobResponse> CreateEmergencyVulExportJob(CreateEmergencyVulExportJobRequest req)
        {
            return InternalRequestAsync<CreateEmergencyVulExportJobResponse>(req, "CreateEmergencyVulExportJob");
        }

        /// <summary>
        /// This API is used to create a task to export emergency vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="CreateEmergencyVulExportJobRequest"/></param>
        /// <returns><see cref="CreateEmergencyVulExportJobResponse"/></returns>
        public CreateEmergencyVulExportJobResponse CreateEmergencyVulExportJobSync(CreateEmergencyVulExportJobRequest req)
        {
            return InternalRequestAsync<CreateEmergencyVulExportJobResponse>(req, "CreateEmergencyVulExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a task to asynchronously export escape events.
        /// </summary>
        /// <param name="req"><see cref="CreateEscapeEventsExportJobRequest"/></param>
        /// <returns><see cref="CreateEscapeEventsExportJobResponse"/></returns>
        public Task<CreateEscapeEventsExportJobResponse> CreateEscapeEventsExportJob(CreateEscapeEventsExportJobRequest req)
        {
            return InternalRequestAsync<CreateEscapeEventsExportJobResponse>(req, "CreateEscapeEventsExportJob");
        }

        /// <summary>
        /// This API is used to create a task to asynchronously export escape events.
        /// </summary>
        /// <param name="req"><see cref="CreateEscapeEventsExportJobRequest"/></param>
        /// <returns><see cref="CreateEscapeEventsExportJobResponse"/></returns>
        public CreateEscapeEventsExportJobResponse CreateEscapeEventsExportJobSync(CreateEscapeEventsExportJobRequest req)
        {
            return InternalRequestAsync<CreateEscapeEventsExportJobResponse>(req, "CreateEscapeEventsExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a task to export the allowlist of escapes.
        /// </summary>
        /// <param name="req"><see cref="CreateEscapeWhiteListExportJobRequest"/></param>
        /// <returns><see cref="CreateEscapeWhiteListExportJobResponse"/></returns>
        public Task<CreateEscapeWhiteListExportJobResponse> CreateEscapeWhiteListExportJob(CreateEscapeWhiteListExportJobRequest req)
        {
            return InternalRequestAsync<CreateEscapeWhiteListExportJobResponse>(req, "CreateEscapeWhiteListExportJob");
        }

        /// <summary>
        /// This API is used to create a task to export the allowlist of escapes.
        /// </summary>
        /// <param name="req"><see cref="CreateEscapeWhiteListExportJobRequest"/></param>
        /// <returns><see cref="CreateEscapeWhiteListExportJobResponse"/></returns>
        public CreateEscapeWhiteListExportJobResponse CreateEscapeWhiteListExportJobSync(CreateEscapeWhiteListExportJobRequest req)
        {
            return InternalRequestAsync<CreateEscapeWhiteListExportJobResponse>(req, "CreateEscapeWhiteListExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a task to export security compliance information.
        /// </summary>
        /// <param name="req"><see cref="CreateExportComplianceStatusListJobRequest"/></param>
        /// <returns><see cref="CreateExportComplianceStatusListJobResponse"/></returns>
        public Task<CreateExportComplianceStatusListJobResponse> CreateExportComplianceStatusListJob(CreateExportComplianceStatusListJobRequest req)
        {
            return InternalRequestAsync<CreateExportComplianceStatusListJobResponse>(req, "CreateExportComplianceStatusListJob");
        }

        /// <summary>
        /// This API is used to create a task to export security compliance information.
        /// </summary>
        /// <param name="req"><see cref="CreateExportComplianceStatusListJobRequest"/></param>
        /// <returns><see cref="CreateExportComplianceStatusListJobResponse"/></returns>
        public CreateExportComplianceStatusListJobResponse CreateExportComplianceStatusListJobSync(CreateExportComplianceStatusListJobRequest req)
        {
            return InternalRequestAsync<CreateExportComplianceStatusListJobResponse>(req, "CreateExportComplianceStatusListJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a task to export the list of servers.
        /// </summary>
        /// <param name="req"><see cref="CreateHostExportJobRequest"/></param>
        /// <returns><see cref="CreateHostExportJobResponse"/></returns>
        public Task<CreateHostExportJobResponse> CreateHostExportJob(CreateHostExportJobRequest req)
        {
            return InternalRequestAsync<CreateHostExportJobResponse>(req, "CreateHostExportJob");
        }

        /// <summary>
        /// This API is used to create a task to export the list of servers.
        /// </summary>
        /// <param name="req"><see cref="CreateHostExportJobRequest"/></param>
        /// <returns><see cref="CreateHostExportJobResponse"/></returns>
        public CreateHostExportJobResponse CreateHostExportJobSync(CreateHostExportJobRequest req)
        {
            return InternalRequestAsync<CreateHostExportJobResponse>(req, "CreateHostExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an image export task.
        /// </summary>
        /// <param name="req"><see cref="CreateImageExportJobRequest"/></param>
        /// <returns><see cref="CreateImageExportJobResponse"/></returns>
        public Task<CreateImageExportJobResponse> CreateImageExportJob(CreateImageExportJobRequest req)
        {
            return InternalRequestAsync<CreateImageExportJobResponse>(req, "CreateImageExportJob");
        }

        /// <summary>
        /// This API is used to create an image export task.
        /// </summary>
        /// <param name="req"><see cref="CreateImageExportJobRequest"/></param>
        /// <returns><see cref="CreateImageExportJobResponse"/></returns>
        public CreateImageExportJobResponse CreateImageExportJobSync(CreateImageExportJobRequest req)
        {
            return InternalRequestAsync<CreateImageExportJobResponse>(req, "CreateImageExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create K8sApi abnormal event export jobs.
        /// </summary>
        /// <param name="req"><see cref="CreateK8sApiAbnormalEventExportJobRequest"/></param>
        /// <returns><see cref="CreateK8sApiAbnormalEventExportJobResponse"/></returns>
        public Task<CreateK8sApiAbnormalEventExportJobResponse> CreateK8sApiAbnormalEventExportJob(CreateK8sApiAbnormalEventExportJobRequest req)
        {
            return InternalRequestAsync<CreateK8sApiAbnormalEventExportJobResponse>(req, "CreateK8sApiAbnormalEventExportJob");
        }

        /// <summary>
        /// This API is used to create K8sApi abnormal event export jobs.
        /// </summary>
        /// <param name="req"><see cref="CreateK8sApiAbnormalEventExportJobRequest"/></param>
        /// <returns><see cref="CreateK8sApiAbnormalEventExportJobResponse"/></returns>
        public CreateK8sApiAbnormalEventExportJobResponse CreateK8sApiAbnormalEventExportJobSync(CreateK8sApiAbnormalEventExportJobRequest req)
        {
            return InternalRequestAsync<CreateK8sApiAbnormalEventExportJobResponse>(req, "CreateK8sApiAbnormalEventExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export rules of K8sApi exceptions. 
        /// </summary>
        /// <param name="req"><see cref="CreateK8sApiAbnormalRuleExportJobRequest"/></param>
        /// <returns><see cref="CreateK8sApiAbnormalRuleExportJobResponse"/></returns>
        public Task<CreateK8sApiAbnormalRuleExportJobResponse> CreateK8sApiAbnormalRuleExportJob(CreateK8sApiAbnormalRuleExportJobRequest req)
        {
            return InternalRequestAsync<CreateK8sApiAbnormalRuleExportJobResponse>(req, "CreateK8sApiAbnormalRuleExportJob");
        }

        /// <summary>
        /// This API is used to export rules of K8sApi exceptions. 
        /// </summary>
        /// <param name="req"><see cref="CreateK8sApiAbnormalRuleExportJobRequest"/></param>
        /// <returns><see cref="CreateK8sApiAbnormalRuleExportJobResponse"/></returns>
        public CreateK8sApiAbnormalRuleExportJobResponse CreateK8sApiAbnormalRuleExportJobSync(CreateK8sApiAbnormalRuleExportJobRequest req)
        {
            return InternalRequestAsync<CreateK8sApiAbnormalRuleExportJobResponse>(req, "CreateK8sApiAbnormalRuleExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create K8sApi abnormal event rules.
        /// </summary>
        /// <param name="req"><see cref="CreateK8sApiAbnormalRuleInfoRequest"/></param>
        /// <returns><see cref="CreateK8sApiAbnormalRuleInfoResponse"/></returns>
        public Task<CreateK8sApiAbnormalRuleInfoResponse> CreateK8sApiAbnormalRuleInfo(CreateK8sApiAbnormalRuleInfoRequest req)
        {
            return InternalRequestAsync<CreateK8sApiAbnormalRuleInfoResponse>(req, "CreateK8sApiAbnormalRuleInfo");
        }

        /// <summary>
        /// This API is used to create K8sApi abnormal event rules.
        /// </summary>
        /// <param name="req"><see cref="CreateK8sApiAbnormalRuleInfoRequest"/></param>
        /// <returns><see cref="CreateK8sApiAbnormalRuleInfoResponse"/></returns>
        public CreateK8sApiAbnormalRuleInfoResponse CreateK8sApiAbnormalRuleInfoSync(CreateK8sApiAbnormalRuleInfoRequest req)
        {
            return InternalRequestAsync<CreateK8sApiAbnormalRuleInfoResponse>(req, "CreateK8sApiAbnormalRuleInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to distribute a refresh task in the container network cluster.
        /// </summary>
        /// <param name="req"><see cref="CreateNetworkFirewallClusterRefreshRequest"/></param>
        /// <returns><see cref="CreateNetworkFirewallClusterRefreshResponse"/></returns>
        public Task<CreateNetworkFirewallClusterRefreshResponse> CreateNetworkFirewallClusterRefresh(CreateNetworkFirewallClusterRefreshRequest req)
        {
            return InternalRequestAsync<CreateNetworkFirewallClusterRefreshResponse>(req, "CreateNetworkFirewallClusterRefresh");
        }

        /// <summary>
        /// This API is used to distribute a refresh task in the container network cluster.
        /// </summary>
        /// <param name="req"><see cref="CreateNetworkFirewallClusterRefreshRequest"/></param>
        /// <returns><see cref="CreateNetworkFirewallClusterRefreshResponse"/></returns>
        public CreateNetworkFirewallClusterRefreshResponse CreateNetworkFirewallClusterRefreshSync(CreateNetworkFirewallClusterRefreshRequest req)
        {
            return InternalRequestAsync<CreateNetworkFirewallClusterRefreshResponse>(req, "CreateNetworkFirewallClusterRefresh")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a task to sync a network policy from the container network cluster.
        /// </summary>
        /// <param name="req"><see cref="CreateNetworkFirewallPolicyDiscoverRequest"/></param>
        /// <returns><see cref="CreateNetworkFirewallPolicyDiscoverResponse"/></returns>
        public Task<CreateNetworkFirewallPolicyDiscoverResponse> CreateNetworkFirewallPolicyDiscover(CreateNetworkFirewallPolicyDiscoverRequest req)
        {
            return InternalRequestAsync<CreateNetworkFirewallPolicyDiscoverResponse>(req, "CreateNetworkFirewallPolicyDiscover");
        }

        /// <summary>
        /// This API is used to create a task to sync a network policy from the container network cluster.
        /// </summary>
        /// <param name="req"><see cref="CreateNetworkFirewallPolicyDiscoverRequest"/></param>
        /// <returns><see cref="CreateNetworkFirewallPolicyDiscoverResponse"/></returns>
        public CreateNetworkFirewallPolicyDiscoverResponse CreateNetworkFirewallPolicyDiscoverSync(CreateNetworkFirewallPolicyDiscoverRequest req)
        {
            return InternalRequestAsync<CreateNetworkFirewallPolicyDiscoverResponse>(req, "CreateNetworkFirewallPolicyDiscover")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a task to publish a network policy in the container network.
        /// </summary>
        /// <param name="req"><see cref="CreateNetworkFirewallPublishRequest"/></param>
        /// <returns><see cref="CreateNetworkFirewallPublishResponse"/></returns>
        public Task<CreateNetworkFirewallPublishResponse> CreateNetworkFirewallPublish(CreateNetworkFirewallPublishRequest req)
        {
            return InternalRequestAsync<CreateNetworkFirewallPublishResponse>(req, "CreateNetworkFirewallPublish");
        }

        /// <summary>
        /// This API is used to create a task to publish a network policy in the container network.
        /// </summary>
        /// <param name="req"><see cref="CreateNetworkFirewallPublishRequest"/></param>
        /// <returns><see cref="CreateNetworkFirewallPublishResponse"/></returns>
        public CreateNetworkFirewallPublishResponse CreateNetworkFirewallPublishSync(CreateNetworkFirewallPublishRequest req)
        {
            return InternalRequestAsync<CreateNetworkFirewallPublishResponse>(req, "CreateNetworkFirewallPublish")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a task to revoke a network policy in the container network.
        /// </summary>
        /// <param name="req"><see cref="CreateNetworkFirewallUndoPublishRequest"/></param>
        /// <returns><see cref="CreateNetworkFirewallUndoPublishResponse"/></returns>
        public Task<CreateNetworkFirewallUndoPublishResponse> CreateNetworkFirewallUndoPublish(CreateNetworkFirewallUndoPublishRequest req)
        {
            return InternalRequestAsync<CreateNetworkFirewallUndoPublishResponse>(req, "CreateNetworkFirewallUndoPublish");
        }

        /// <summary>
        /// This API is used to create a task to revoke a network policy in the container network.
        /// </summary>
        /// <param name="req"><see cref="CreateNetworkFirewallUndoPublishRequest"/></param>
        /// <returns><see cref="CreateNetworkFirewallUndoPublishResponse"/></returns>
        public CreateNetworkFirewallUndoPublishResponse CreateNetworkFirewallUndoPublishSync(CreateNetworkFirewallUndoPublishRequest req)
        {
            return InternalRequestAsync<CreateNetworkFirewallUndoPublishResponse>(req, "CreateNetworkFirewallUndoPublish")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create or edit the upper limit for elastic billing.
        /// </summary>
        /// <param name="req"><see cref="CreateOrModifyPostPayCoresRequest"/></param>
        /// <returns><see cref="CreateOrModifyPostPayCoresResponse"/></returns>
        public Task<CreateOrModifyPostPayCoresResponse> CreateOrModifyPostPayCores(CreateOrModifyPostPayCoresRequest req)
        {
            return InternalRequestAsync<CreateOrModifyPostPayCoresResponse>(req, "CreateOrModifyPostPayCores");
        }

        /// <summary>
        /// This API is used to create or edit the upper limit for elastic billing.
        /// </summary>
        /// <param name="req"><see cref="CreateOrModifyPostPayCoresRequest"/></param>
        /// <returns><see cref="CreateOrModifyPostPayCoresResponse"/></returns>
        public CreateOrModifyPostPayCoresResponse CreateOrModifyPostPayCoresSync(CreateOrModifyPostPayCoresRequest req)
        {
            return InternalRequestAsync<CreateOrModifyPostPayCoresResponse>(req, "CreateOrModifyPostPayCores")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a task to asynchronously export abnormal process events.
        /// </summary>
        /// <param name="req"><see cref="CreateProcessEventsExportJobRequest"/></param>
        /// <returns><see cref="CreateProcessEventsExportJobResponse"/></returns>
        public Task<CreateProcessEventsExportJobResponse> CreateProcessEventsExportJob(CreateProcessEventsExportJobRequest req)
        {
            return InternalRequestAsync<CreateProcessEventsExportJobResponse>(req, "CreateProcessEventsExportJob");
        }

        /// <summary>
        /// This API is used to create a task to asynchronously export abnormal process events.
        /// </summary>
        /// <param name="req"><see cref="CreateProcessEventsExportJobRequest"/></param>
        /// <returns><see cref="CreateProcessEventsExportJobResponse"/></returns>
        public CreateProcessEventsExportJobResponse CreateProcessEventsExportJobSync(CreateProcessEventsExportJobRequest req)
        {
            return InternalRequestAsync<CreateProcessEventsExportJobResponse>(req, "CreateProcessEventsExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to distribute a task to refresh the asset information.
        /// </summary>
        /// <param name="req"><see cref="CreateRefreshTaskRequest"/></param>
        /// <returns><see cref="CreateRefreshTaskResponse"/></returns>
        public Task<CreateRefreshTaskResponse> CreateRefreshTask(CreateRefreshTaskRequest req)
        {
            return InternalRequestAsync<CreateRefreshTaskResponse>(req, "CreateRefreshTask");
        }

        /// <summary>
        /// This API is used to distribute a task to refresh the asset information.
        /// </summary>
        /// <param name="req"><see cref="CreateRefreshTaskRequest"/></param>
        /// <returns><see cref="CreateRefreshTaskResponse"/></returns>
        public CreateRefreshTaskResponse CreateRefreshTaskSync(CreateRefreshTaskRequest req)
        {
            return InternalRequestAsync<CreateRefreshTaskResponse>(req, "CreateRefreshTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export malicious request events.
        /// </summary>
        /// <param name="req"><see cref="CreateRiskDnsEventExportJobRequest"/></param>
        /// <returns><see cref="CreateRiskDnsEventExportJobResponse"/></returns>
        public Task<CreateRiskDnsEventExportJobResponse> CreateRiskDnsEventExportJob(CreateRiskDnsEventExportJobRequest req)
        {
            return InternalRequestAsync<CreateRiskDnsEventExportJobResponse>(req, "CreateRiskDnsEventExportJob");
        }

        /// <summary>
        /// This API is used to export malicious request events.
        /// </summary>
        /// <param name="req"><see cref="CreateRiskDnsEventExportJobRequest"/></param>
        /// <returns><see cref="CreateRiskDnsEventExportJobResponse"/></returns>
        public CreateRiskDnsEventExportJobResponse CreateRiskDnsEventExportJobSync(CreateRiskDnsEventExportJobRequest req)
        {
            return InternalRequestAsync<CreateRiskDnsEventExportJobResponse>(req, "CreateRiskDnsEventExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add a search template.
        /// </summary>
        /// <param name="req"><see cref="CreateSearchTemplateRequest"/></param>
        /// <returns><see cref="CreateSearchTemplateResponse"/></returns>
        public Task<CreateSearchTemplateResponse> CreateSearchTemplate(CreateSearchTemplateRequest req)
        {
            return InternalRequestAsync<CreateSearchTemplateResponse>(req, "CreateSearchTemplate");
        }

        /// <summary>
        /// This API is used to add a search template.
        /// </summary>
        /// <param name="req"><see cref="CreateSearchTemplateRequest"/></param>
        /// <returns><see cref="CreateSearchTemplateResponse"/></returns>
        public CreateSearchTemplateResponse CreateSearchTemplateSync(CreateSearchTemplateRequest req)
        {
            return InternalRequestAsync<CreateSearchTemplateResponse>(req, "CreateSearchTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a task to export system vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="CreateSystemVulExportJobRequest"/></param>
        /// <returns><see cref="CreateSystemVulExportJobResponse"/></returns>
        public Task<CreateSystemVulExportJobResponse> CreateSystemVulExportJob(CreateSystemVulExportJobRequest req)
        {
            return InternalRequestAsync<CreateSystemVulExportJobResponse>(req, "CreateSystemVulExportJob");
        }

        /// <summary>
        /// This API is used to create a task to export system vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="CreateSystemVulExportJobRequest"/></param>
        /// <returns><see cref="CreateSystemVulExportJobResponse"/></returns>
        public CreateSystemVulExportJobResponse CreateSystemVulExportJobSync(CreateSystemVulExportJobRequest req)
        {
            return InternalRequestAsync<CreateSystemVulExportJobResponse>(req, "CreateSystemVulExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to perform another virus scan at runtime.
        /// </summary>
        /// <param name="req"><see cref="CreateVirusScanAgainRequest"/></param>
        /// <returns><see cref="CreateVirusScanAgainResponse"/></returns>
        public Task<CreateVirusScanAgainResponse> CreateVirusScanAgain(CreateVirusScanAgainRequest req)
        {
            return InternalRequestAsync<CreateVirusScanAgainResponse>(req, "CreateVirusScanAgain");
        }

        /// <summary>
        /// This API is used to perform another virus scan at runtime.
        /// </summary>
        /// <param name="req"><see cref="CreateVirusScanAgainRequest"/></param>
        /// <returns><see cref="CreateVirusScanAgainResponse"/></returns>
        public CreateVirusScanAgainResponse CreateVirusScanAgainSync(CreateVirusScanAgainRequest req)
        {
            return InternalRequestAsync<CreateVirusScanAgainResponse>(req, "CreateVirusScanAgain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to perform a quick virus scan at runtime.
        /// </summary>
        /// <param name="req"><see cref="CreateVirusScanTaskRequest"/></param>
        /// <returns><see cref="CreateVirusScanTaskResponse"/></returns>
        public Task<CreateVirusScanTaskResponse> CreateVirusScanTask(CreateVirusScanTaskRequest req)
        {
            return InternalRequestAsync<CreateVirusScanTaskResponse>(req, "CreateVirusScanTask");
        }

        /// <summary>
        /// This API is used to perform a quick virus scan at runtime.
        /// </summary>
        /// <param name="req"><see cref="CreateVirusScanTaskRequest"/></param>
        /// <returns><see cref="CreateVirusScanTaskResponse"/></returns>
        public CreateVirusScanTaskResponse CreateVirusScanTaskSync(CreateVirusScanTaskRequest req)
        {
            return InternalRequestAsync<CreateVirusScanTaskResponse>(req, "CreateVirusScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a task to export containers affected by vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="CreateVulContainerExportJobRequest"/></param>
        /// <returns><see cref="CreateVulContainerExportJobResponse"/></returns>
        public Task<CreateVulContainerExportJobResponse> CreateVulContainerExportJob(CreateVulContainerExportJobRequest req)
        {
            return InternalRequestAsync<CreateVulContainerExportJobResponse>(req, "CreateVulContainerExportJob");
        }

        /// <summary>
        /// This API is used to create a task to export containers affected by vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="CreateVulContainerExportJobRequest"/></param>
        /// <returns><see cref="CreateVulContainerExportJobResponse"/></returns>
        public CreateVulContainerExportJobResponse CreateVulContainerExportJobSync(CreateVulContainerExportJobRequest req)
        {
            return InternalRequestAsync<CreateVulContainerExportJobResponse>(req, "CreateVulContainerExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an exploit prevention event export task.
        /// </summary>
        /// <param name="req"><see cref="CreateVulDefenceEventExportJobRequest"/></param>
        /// <returns><see cref="CreateVulDefenceEventExportJobResponse"/></returns>
        public Task<CreateVulDefenceEventExportJobResponse> CreateVulDefenceEventExportJob(CreateVulDefenceEventExportJobRequest req)
        {
            return InternalRequestAsync<CreateVulDefenceEventExportJobResponse>(req, "CreateVulDefenceEventExportJob");
        }

        /// <summary>
        /// This API is used to create an exploit prevention event export task.
        /// </summary>
        /// <param name="req"><see cref="CreateVulDefenceEventExportJobRequest"/></param>
        /// <returns><see cref="CreateVulDefenceEventExportJobResponse"/></returns>
        public CreateVulDefenceEventExportJobResponse CreateVulDefenceEventExportJobSync(CreateVulDefenceEventExportJobRequest req)
        {
            return InternalRequestAsync<CreateVulDefenceEventExportJobResponse>(req, "CreateVulDefenceEventExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a task to export servers with exploit prevention enabled.
        /// </summary>
        /// <param name="req"><see cref="CreateVulDefenceHostExportJobRequest"/></param>
        /// <returns><see cref="CreateVulDefenceHostExportJobResponse"/></returns>
        public Task<CreateVulDefenceHostExportJobResponse> CreateVulDefenceHostExportJob(CreateVulDefenceHostExportJobRequest req)
        {
            return InternalRequestAsync<CreateVulDefenceHostExportJobResponse>(req, "CreateVulDefenceHostExportJob");
        }

        /// <summary>
        /// This API is used to create a task to export servers with exploit prevention enabled.
        /// </summary>
        /// <param name="req"><see cref="CreateVulDefenceHostExportJobRequest"/></param>
        /// <returns><see cref="CreateVulDefenceHostExportJobResponse"/></returns>
        public CreateVulDefenceHostExportJobResponse CreateVulDefenceHostExportJobSync(CreateVulDefenceHostExportJobRequest req)
        {
            return InternalRequestAsync<CreateVulDefenceHostExportJobResponse>(req, "CreateVulDefenceHostExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the list of vulnerabilities in a local image.
        /// </summary>
        /// <param name="req"><see cref="CreateVulExportJobRequest"/></param>
        /// <returns><see cref="CreateVulExportJobResponse"/></returns>
        public Task<CreateVulExportJobResponse> CreateVulExportJob(CreateVulExportJobRequest req)
        {
            return InternalRequestAsync<CreateVulExportJobResponse>(req, "CreateVulExportJob");
        }

        /// <summary>
        /// This API is used to export the list of vulnerabilities in a local image.
        /// </summary>
        /// <param name="req"><see cref="CreateVulExportJobRequest"/></param>
        /// <returns><see cref="CreateVulExportJobResponse"/></returns>
        public CreateVulExportJobResponse CreateVulExportJobSync(CreateVulExportJobRequest req)
        {
            return InternalRequestAsync<CreateVulExportJobResponse>(req, "CreateVulExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a task to export images affected by vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="CreateVulImageExportJobRequest"/></param>
        /// <returns><see cref="CreateVulImageExportJobResponse"/></returns>
        public Task<CreateVulImageExportJobResponse> CreateVulImageExportJob(CreateVulImageExportJobRequest req)
        {
            return InternalRequestAsync<CreateVulImageExportJobResponse>(req, "CreateVulImageExportJob");
        }

        /// <summary>
        /// This API is used to create a task to export images affected by vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="CreateVulImageExportJobRequest"/></param>
        /// <returns><see cref="CreateVulImageExportJobResponse"/></returns>
        public CreateVulImageExportJobResponse CreateVulImageExportJobSync(CreateVulImageExportJobRequest req)
        {
            return InternalRequestAsync<CreateVulImageExportJobResponse>(req, "CreateVulImageExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a vulnerability scan task.
        /// </summary>
        /// <param name="req"><see cref="CreateVulScanTaskRequest"/></param>
        /// <returns><see cref="CreateVulScanTaskResponse"/></returns>
        public Task<CreateVulScanTaskResponse> CreateVulScanTask(CreateVulScanTaskRequest req)
        {
            return InternalRequestAsync<CreateVulScanTaskResponse>(req, "CreateVulScanTask");
        }

        /// <summary>
        /// This API is used to create a vulnerability scan task.
        /// </summary>
        /// <param name="req"><see cref="CreateVulScanTaskRequest"/></param>
        /// <returns><see cref="CreateVulScanTaskResponse"/></returns>
        public CreateVulScanTaskResponse CreateVulScanTaskSync(CreateVulScanTaskRequest req)
        {
            return InternalRequestAsync<CreateVulScanTaskResponse>(req, "CreateVulScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a task to export web vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="CreateWebVulExportJobRequest"/></param>
        /// <returns><see cref="CreateWebVulExportJobResponse"/></returns>
        public Task<CreateWebVulExportJobResponse> CreateWebVulExportJob(CreateWebVulExportJobRequest req)
        {
            return InternalRequestAsync<CreateWebVulExportJobResponse>(req, "CreateWebVulExportJob");
        }

        /// <summary>
        /// This API is used to create a task to export web vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="CreateWebVulExportJobRequest"/></param>
        /// <returns><see cref="CreateWebVulExportJobResponse"/></returns>
        public CreateWebVulExportJobResponse CreateWebVulExportJobSync(CreateWebVulExportJobRequest req)
        {
            return InternalRequestAsync<CreateWebVulExportJobResponse>(req, "CreateWebVulExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an abnormal process policy at runtime.
        /// </summary>
        /// <param name="req"><see cref="DeleteAbnormalProcessRulesRequest"/></param>
        /// <returns><see cref="DeleteAbnormalProcessRulesResponse"/></returns>
        public Task<DeleteAbnormalProcessRulesResponse> DeleteAbnormalProcessRules(DeleteAbnormalProcessRulesRequest req)
        {
            return InternalRequestAsync<DeleteAbnormalProcessRulesResponse>(req, "DeleteAbnormalProcessRules");
        }

        /// <summary>
        /// This API is used to delete an abnormal process policy at runtime.
        /// </summary>
        /// <param name="req"><see cref="DeleteAbnormalProcessRulesRequest"/></param>
        /// <returns><see cref="DeleteAbnormalProcessRulesResponse"/></returns>
        public DeleteAbnormalProcessRulesResponse DeleteAbnormalProcessRulesSync(DeleteAbnormalProcessRulesRequest req)
        {
            return InternalRequestAsync<DeleteAbnormalProcessRulesResponse>(req, "DeleteAbnormalProcessRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an access control policy at runtime.
        /// </summary>
        /// <param name="req"><see cref="DeleteAccessControlRulesRequest"/></param>
        /// <returns><see cref="DeleteAccessControlRulesResponse"/></returns>
        public Task<DeleteAccessControlRulesResponse> DeleteAccessControlRules(DeleteAccessControlRulesRequest req)
        {
            return InternalRequestAsync<DeleteAccessControlRulesResponse>(req, "DeleteAccessControlRules");
        }

        /// <summary>
        /// This API is used to delete an access control policy at runtime.
        /// </summary>
        /// <param name="req"><see cref="DeleteAccessControlRulesRequest"/></param>
        /// <returns><see cref="DeleteAccessControlRulesResponse"/></returns>
        public DeleteAccessControlRulesResponse DeleteAccessControlRulesSync(DeleteAccessControlRulesRequest req)
        {
            return InternalRequestAsync<DeleteAccessControlRulesResponse>(req, "DeleteAccessControlRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unignore the specified asset IDs and check item IDs so as to show the assets contained in the specified check items.
        /// `AddCompliancePolicyAssetSetToWhitelist` is the reference API. Except for the input field, others should be the same, and if not, it may be due to the definition.
        /// </summary>
        /// <param name="req"><see cref="DeleteComplianceAssetPolicySetFromWhitelistRequest"/></param>
        /// <returns><see cref="DeleteComplianceAssetPolicySetFromWhitelistResponse"/></returns>
        public Task<DeleteComplianceAssetPolicySetFromWhitelistResponse> DeleteComplianceAssetPolicySetFromWhitelist(DeleteComplianceAssetPolicySetFromWhitelistRequest req)
        {
            return InternalRequestAsync<DeleteComplianceAssetPolicySetFromWhitelistResponse>(req, "DeleteComplianceAssetPolicySetFromWhitelist");
        }

        /// <summary>
        /// This API is used to unignore the specified asset IDs and check item IDs so as to show the assets contained in the specified check items.
        /// `AddCompliancePolicyAssetSetToWhitelist` is the reference API. Except for the input field, others should be the same, and if not, it may be due to the definition.
        /// </summary>
        /// <param name="req"><see cref="DeleteComplianceAssetPolicySetFromWhitelistRequest"/></param>
        /// <returns><see cref="DeleteComplianceAssetPolicySetFromWhitelistResponse"/></returns>
        public DeleteComplianceAssetPolicySetFromWhitelistResponse DeleteComplianceAssetPolicySetFromWhitelistSync(DeleteComplianceAssetPolicySetFromWhitelistRequest req)
        {
            return InternalRequestAsync<DeleteComplianceAssetPolicySetFromWhitelistResponse>(req, "DeleteComplianceAssetPolicySetFromWhitelist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unignore the specified asset IDs and check item IDs so as to show the assets contained in the specified check items.
        /// </summary>
        /// <param name="req"><see cref="DeleteCompliancePolicyAssetSetFromWhitelistRequest"/></param>
        /// <returns><see cref="DeleteCompliancePolicyAssetSetFromWhitelistResponse"/></returns>
        public Task<DeleteCompliancePolicyAssetSetFromWhitelistResponse> DeleteCompliancePolicyAssetSetFromWhitelist(DeleteCompliancePolicyAssetSetFromWhitelistRequest req)
        {
            return InternalRequestAsync<DeleteCompliancePolicyAssetSetFromWhitelistResponse>(req, "DeleteCompliancePolicyAssetSetFromWhitelist");
        }

        /// <summary>
        /// This API is used to unignore the specified asset IDs and check item IDs so as to show the assets contained in the specified check items.
        /// </summary>
        /// <param name="req"><see cref="DeleteCompliancePolicyAssetSetFromWhitelistRequest"/></param>
        /// <returns><see cref="DeleteCompliancePolicyAssetSetFromWhitelistResponse"/></returns>
        public DeleteCompliancePolicyAssetSetFromWhitelistResponse DeleteCompliancePolicyAssetSetFromWhitelistSync(DeleteCompliancePolicyAssetSetFromWhitelistRequest req)
        {
            return InternalRequestAsync<DeleteCompliancePolicyAssetSetFromWhitelistResponse>(req, "DeleteCompliancePolicyAssetSetFromWhitelist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to remove the specified check item from the allowlist.
        /// </summary>
        /// <param name="req"><see cref="DeleteCompliancePolicyItemFromWhitelistRequest"/></param>
        /// <returns><see cref="DeleteCompliancePolicyItemFromWhitelistResponse"/></returns>
        public Task<DeleteCompliancePolicyItemFromWhitelistResponse> DeleteCompliancePolicyItemFromWhitelist(DeleteCompliancePolicyItemFromWhitelistRequest req)
        {
            return InternalRequestAsync<DeleteCompliancePolicyItemFromWhitelistResponse>(req, "DeleteCompliancePolicyItemFromWhitelist");
        }

        /// <summary>
        /// This API is used to remove the specified check item from the allowlist.
        /// </summary>
        /// <param name="req"><see cref="DeleteCompliancePolicyItemFromWhitelistRequest"/></param>
        /// <returns><see cref="DeleteCompliancePolicyItemFromWhitelistResponse"/></returns>
        public DeleteCompliancePolicyItemFromWhitelistResponse DeleteCompliancePolicyItemFromWhitelistSync(DeleteCompliancePolicyItemFromWhitelistRequest req)
        {
            return InternalRequestAsync<DeleteCompliancePolicyItemFromWhitelistResponse>(req, "DeleteCompliancePolicyItemFromWhitelist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an allowed escape.
        /// </summary>
        /// <param name="req"><see cref="DeleteEscapeWhiteListRequest"/></param>
        /// <returns><see cref="DeleteEscapeWhiteListResponse"/></returns>
        public Task<DeleteEscapeWhiteListResponse> DeleteEscapeWhiteList(DeleteEscapeWhiteListRequest req)
        {
            return InternalRequestAsync<DeleteEscapeWhiteListResponse>(req, "DeleteEscapeWhiteList");
        }

        /// <summary>
        /// This API is used to delete an allowed escape.
        /// </summary>
        /// <param name="req"><see cref="DeleteEscapeWhiteListRequest"/></param>
        /// <returns><see cref="DeleteEscapeWhiteListResponse"/></returns>
        public DeleteEscapeWhiteListResponse DeleteEscapeWhiteListSync(DeleteEscapeWhiteListRequest req)
        {
            return InternalRequestAsync<DeleteEscapeWhiteListResponse>(req, "DeleteEscapeWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unignore vulnerabilities in a vulnerability scan.
        /// </summary>
        /// <param name="req"><see cref="DeleteIgnoreVulRequest"/></param>
        /// <returns><see cref="DeleteIgnoreVulResponse"/></returns>
        public Task<DeleteIgnoreVulResponse> DeleteIgnoreVul(DeleteIgnoreVulRequest req)
        {
            return InternalRequestAsync<DeleteIgnoreVulResponse>(req, "DeleteIgnoreVul");
        }

        /// <summary>
        /// This API is used to unignore vulnerabilities in a vulnerability scan.
        /// </summary>
        /// <param name="req"><see cref="DeleteIgnoreVulRequest"/></param>
        /// <returns><see cref="DeleteIgnoreVulResponse"/></returns>
        public DeleteIgnoreVulResponse DeleteIgnoreVulSync(DeleteIgnoreVulRequest req)
        {
            return InternalRequestAsync<DeleteIgnoreVulResponse>(req, "DeleteIgnoreVul")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a K8sApi abnormal event rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteK8sApiAbnormalRuleRequest"/></param>
        /// <returns><see cref="DeleteK8sApiAbnormalRuleResponse"/></returns>
        public Task<DeleteK8sApiAbnormalRuleResponse> DeleteK8sApiAbnormalRule(DeleteK8sApiAbnormalRuleRequest req)
        {
            return InternalRequestAsync<DeleteK8sApiAbnormalRuleResponse>(req, "DeleteK8sApiAbnormalRule");
        }

        /// <summary>
        /// This API is used to delete a K8sApi abnormal event rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteK8sApiAbnormalRuleRequest"/></param>
        /// <returns><see cref="DeleteK8sApiAbnormalRuleResponse"/></returns>
        public DeleteK8sApiAbnormalRuleResponse DeleteK8sApiAbnormalRuleSync(DeleteK8sApiAbnormalRuleRequest req)
        {
            return InternalRequestAsync<DeleteK8sApiAbnormalRuleResponse>(req, "DeleteK8sApiAbnormalRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to uninstall the agent.
        /// </summary>
        /// <param name="req"><see cref="DeleteMachineRequest"/></param>
        /// <returns><see cref="DeleteMachineResponse"/></returns>
        public Task<DeleteMachineResponse> DeleteMachine(DeleteMachineRequest req)
        {
            return InternalRequestAsync<DeleteMachineResponse>(req, "DeleteMachine");
        }

        /// <summary>
        /// This API is used to uninstall the agent.
        /// </summary>
        /// <param name="req"><see cref="DeleteMachineRequest"/></param>
        /// <returns><see cref="DeleteMachineResponse"/></returns>
        public DeleteMachineResponse DeleteMachineSync(DeleteMachineRequest req)
        {
            return InternalRequestAsync<DeleteMachineResponse>(req, "DeleteMachine")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a task to delete a network policy in the container network.
        /// </summary>
        /// <param name="req"><see cref="DeleteNetworkFirewallPolicyDetailRequest"/></param>
        /// <returns><see cref="DeleteNetworkFirewallPolicyDetailResponse"/></returns>
        public Task<DeleteNetworkFirewallPolicyDetailResponse> DeleteNetworkFirewallPolicyDetail(DeleteNetworkFirewallPolicyDetailRequest req)
        {
            return InternalRequestAsync<DeleteNetworkFirewallPolicyDetailResponse>(req, "DeleteNetworkFirewallPolicyDetail");
        }

        /// <summary>
        /// This API is used to create a task to delete a network policy in the container network.
        /// </summary>
        /// <param name="req"><see cref="DeleteNetworkFirewallPolicyDetailRequest"/></param>
        /// <returns><see cref="DeleteNetworkFirewallPolicyDetailResponse"/></returns>
        public DeleteNetworkFirewallPolicyDetailResponse DeleteNetworkFirewallPolicyDetailSync(DeleteNetworkFirewallPolicyDetailRequest req)
        {
            return InternalRequestAsync<DeleteNetworkFirewallPolicyDetailResponse>(req, "DeleteNetworkFirewallPolicyDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a reverse shell event at runtime.
        /// </summary>
        /// <param name="req"><see cref="DeleteReverseShellEventsRequest"/></param>
        /// <returns><see cref="DeleteReverseShellEventsResponse"/></returns>
        public Task<DeleteReverseShellEventsResponse> DeleteReverseShellEvents(DeleteReverseShellEventsRequest req)
        {
            return InternalRequestAsync<DeleteReverseShellEventsResponse>(req, "DeleteReverseShellEvents");
        }

        /// <summary>
        /// This API is used to delete a reverse shell event at runtime.
        /// </summary>
        /// <param name="req"><see cref="DeleteReverseShellEventsRequest"/></param>
        /// <returns><see cref="DeleteReverseShellEventsResponse"/></returns>
        public DeleteReverseShellEventsResponse DeleteReverseShellEventsSync(DeleteReverseShellEventsRequest req)
        {
            return InternalRequestAsync<DeleteReverseShellEventsResponse>(req, "DeleteReverseShellEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an allowed reverse shell at runtime.
        /// </summary>
        /// <param name="req"><see cref="DeleteReverseShellWhiteListsRequest"/></param>
        /// <returns><see cref="DeleteReverseShellWhiteListsResponse"/></returns>
        public Task<DeleteReverseShellWhiteListsResponse> DeleteReverseShellWhiteLists(DeleteReverseShellWhiteListsRequest req)
        {
            return InternalRequestAsync<DeleteReverseShellWhiteListsResponse>(req, "DeleteReverseShellWhiteLists");
        }

        /// <summary>
        /// This API is used to delete an allowed reverse shell at runtime.
        /// </summary>
        /// <param name="req"><see cref="DeleteReverseShellWhiteListsRequest"/></param>
        /// <returns><see cref="DeleteReverseShellWhiteListsResponse"/></returns>
        public DeleteReverseShellWhiteListsResponse DeleteReverseShellWhiteListsSync(DeleteReverseShellWhiteListsRequest req)
        {
            return InternalRequestAsync<DeleteReverseShellWhiteListsResponse>(req, "DeleteReverseShellWhiteLists")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a high-risk syscall event at runtime.
        /// </summary>
        /// <param name="req"><see cref="DeleteRiskSyscallEventsRequest"/></param>
        /// <returns><see cref="DeleteRiskSyscallEventsResponse"/></returns>
        public Task<DeleteRiskSyscallEventsResponse> DeleteRiskSyscallEvents(DeleteRiskSyscallEventsRequest req)
        {
            return InternalRequestAsync<DeleteRiskSyscallEventsResponse>(req, "DeleteRiskSyscallEvents");
        }

        /// <summary>
        /// This API is used to delete a high-risk syscall event at runtime.
        /// </summary>
        /// <param name="req"><see cref="DeleteRiskSyscallEventsRequest"/></param>
        /// <returns><see cref="DeleteRiskSyscallEventsResponse"/></returns>
        public DeleteRiskSyscallEventsResponse DeleteRiskSyscallEventsSync(DeleteRiskSyscallEventsRequest req)
        {
            return InternalRequestAsync<DeleteRiskSyscallEventsResponse>(req, "DeleteRiskSyscallEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an allowed high-risk syscall at runtime.
        /// </summary>
        /// <param name="req"><see cref="DeleteRiskSyscallWhiteListsRequest"/></param>
        /// <returns><see cref="DeleteRiskSyscallWhiteListsResponse"/></returns>
        public Task<DeleteRiskSyscallWhiteListsResponse> DeleteRiskSyscallWhiteLists(DeleteRiskSyscallWhiteListsRequest req)
        {
            return InternalRequestAsync<DeleteRiskSyscallWhiteListsResponse>(req, "DeleteRiskSyscallWhiteLists");
        }

        /// <summary>
        /// This API is used to delete an allowed high-risk syscall at runtime.
        /// </summary>
        /// <param name="req"><see cref="DeleteRiskSyscallWhiteListsRequest"/></param>
        /// <returns><see cref="DeleteRiskSyscallWhiteListsResponse"/></returns>
        public DeleteRiskSyscallWhiteListsResponse DeleteRiskSyscallWhiteListsSync(DeleteRiskSyscallWhiteListsRequest req)
        {
            return InternalRequestAsync<DeleteRiskSyscallWhiteListsResponse>(req, "DeleteRiskSyscallWhiteLists")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a search template.
        /// </summary>
        /// <param name="req"><see cref="DeleteSearchTemplateRequest"/></param>
        /// <returns><see cref="DeleteSearchTemplateResponse"/></returns>
        public Task<DeleteSearchTemplateResponse> DeleteSearchTemplate(DeleteSearchTemplateRequest req)
        {
            return InternalRequestAsync<DeleteSearchTemplateResponse>(req, "DeleteSearchTemplate");
        }

        /// <summary>
        /// This API is used to delete a search template.
        /// </summary>
        /// <param name="req"><see cref="DeleteSearchTemplateRequest"/></param>
        /// <returns><see cref="DeleteSearchTemplateResponse"/></returns>
        public DeleteSearchTemplateResponse DeleteSearchTemplateSync(DeleteSearchTemplateRequest req)
        {
            return InternalRequestAsync<DeleteSearchTemplateResponse>(req, "DeleteSearchTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the current canary configuration of the user.
        /// </summary>
        /// <param name="req"><see cref="DescribeABTestConfigRequest"/></param>
        /// <returns><see cref="DescribeABTestConfigResponse"/></returns>
        public Task<DescribeABTestConfigResponse> DescribeABTestConfig(DescribeABTestConfigRequest req)
        {
            return InternalRequestAsync<DescribeABTestConfigResponse>(req, "DescribeABTestConfig");
        }

        /// <summary>
        /// This API is used to get the current canary configuration of the user.
        /// </summary>
        /// <param name="req"><see cref="DescribeABTestConfigRequest"/></param>
        /// <returns><see cref="DescribeABTestConfigResponse"/></returns>
        public DescribeABTestConfigResponse DescribeABTestConfigSync(DescribeABTestConfigRequest req)
        {
            return InternalRequestAsync<DescribeABTestConfigResponse>(req, "DescribeABTestConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of an abnormal process event at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeAbnormalProcessDetailRequest"/></param>
        /// <returns><see cref="DescribeAbnormalProcessDetailResponse"/></returns>
        public Task<DescribeAbnormalProcessDetailResponse> DescribeAbnormalProcessDetail(DescribeAbnormalProcessDetailRequest req)
        {
            return InternalRequestAsync<DescribeAbnormalProcessDetailResponse>(req, "DescribeAbnormalProcessDetail");
        }

        /// <summary>
        /// This API is used to query the details of an abnormal process event at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeAbnormalProcessDetailRequest"/></param>
        /// <returns><see cref="DescribeAbnormalProcessDetailResponse"/></returns>
        public DescribeAbnormalProcessDetailResponse DescribeAbnormalProcessDetailSync(DescribeAbnormalProcessDetailRequest req)
        {
            return InternalRequestAsync<DescribeAbnormalProcessDetailResponse>(req, "DescribeAbnormalProcessDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the trend of pending abnormal process events.
        /// </summary>
        /// <param name="req"><see cref="DescribeAbnormalProcessEventTendencyRequest"/></param>
        /// <returns><see cref="DescribeAbnormalProcessEventTendencyResponse"/></returns>
        public Task<DescribeAbnormalProcessEventTendencyResponse> DescribeAbnormalProcessEventTendency(DescribeAbnormalProcessEventTendencyRequest req)
        {
            return InternalRequestAsync<DescribeAbnormalProcessEventTendencyResponse>(req, "DescribeAbnormalProcessEventTendency");
        }

        /// <summary>
        /// This API is used to query the trend of pending abnormal process events.
        /// </summary>
        /// <param name="req"><see cref="DescribeAbnormalProcessEventTendencyRequest"/></param>
        /// <returns><see cref="DescribeAbnormalProcessEventTendencyResponse"/></returns>
        public DescribeAbnormalProcessEventTendencyResponse DescribeAbnormalProcessEventTendencySync(DescribeAbnormalProcessEventTendencyRequest req)
        {
            return InternalRequestAsync<DescribeAbnormalProcessEventTendencyResponse>(req, "DescribeAbnormalProcessEventTendency")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of abnormal process events at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeAbnormalProcessEventsRequest"/></param>
        /// <returns><see cref="DescribeAbnormalProcessEventsResponse"/></returns>
        public Task<DescribeAbnormalProcessEventsResponse> DescribeAbnormalProcessEvents(DescribeAbnormalProcessEventsRequest req)
        {
            return InternalRequestAsync<DescribeAbnormalProcessEventsResponse>(req, "DescribeAbnormalProcessEvents");
        }

        /// <summary>
        /// This API is used to query the list of abnormal process events at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeAbnormalProcessEventsRequest"/></param>
        /// <returns><see cref="DescribeAbnormalProcessEventsResponse"/></returns>
        public DescribeAbnormalProcessEventsResponse DescribeAbnormalProcessEventsSync(DescribeAbnormalProcessEventsRequest req)
        {
            return InternalRequestAsync<DescribeAbnormalProcessEventsResponse>(req, "DescribeAbnormalProcessEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query and export the list of abnormal process events at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeAbnormalProcessEventsExportRequest"/></param>
        /// <returns><see cref="DescribeAbnormalProcessEventsExportResponse"/></returns>
        public Task<DescribeAbnormalProcessEventsExportResponse> DescribeAbnormalProcessEventsExport(DescribeAbnormalProcessEventsExportRequest req)
        {
            return InternalRequestAsync<DescribeAbnormalProcessEventsExportResponse>(req, "DescribeAbnormalProcessEventsExport");
        }

        /// <summary>
        /// This API is used to query and export the list of abnormal process events at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeAbnormalProcessEventsExportRequest"/></param>
        /// <returns><see cref="DescribeAbnormalProcessEventsExportResponse"/></returns>
        public DescribeAbnormalProcessEventsExportResponse DescribeAbnormalProcessEventsExportSync(DescribeAbnormalProcessEventsExportRequest req)
        {
            return InternalRequestAsync<DescribeAbnormalProcessEventsExportResponse>(req, "DescribeAbnormalProcessEventsExport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to count the number of pending abnormal process events at each severity level.
        /// </summary>
        /// <param name="req"><see cref="DescribeAbnormalProcessLevelSummaryRequest"/></param>
        /// <returns><see cref="DescribeAbnormalProcessLevelSummaryResponse"/></returns>
        public Task<DescribeAbnormalProcessLevelSummaryResponse> DescribeAbnormalProcessLevelSummary(DescribeAbnormalProcessLevelSummaryRequest req)
        {
            return InternalRequestAsync<DescribeAbnormalProcessLevelSummaryResponse>(req, "DescribeAbnormalProcessLevelSummary");
        }

        /// <summary>
        /// This API is used to count the number of pending abnormal process events at each severity level.
        /// </summary>
        /// <param name="req"><see cref="DescribeAbnormalProcessLevelSummaryRequest"/></param>
        /// <returns><see cref="DescribeAbnormalProcessLevelSummaryResponse"/></returns>
        public DescribeAbnormalProcessLevelSummaryResponse DescribeAbnormalProcessLevelSummarySync(DescribeAbnormalProcessLevelSummaryRequest req)
        {
            return InternalRequestAsync<DescribeAbnormalProcessLevelSummaryResponse>(req, "DescribeAbnormalProcessLevelSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of an abnormal process policy at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeAbnormalProcessRuleDetailRequest"/></param>
        /// <returns><see cref="DescribeAbnormalProcessRuleDetailResponse"/></returns>
        public Task<DescribeAbnormalProcessRuleDetailResponse> DescribeAbnormalProcessRuleDetail(DescribeAbnormalProcessRuleDetailRequest req)
        {
            return InternalRequestAsync<DescribeAbnormalProcessRuleDetailResponse>(req, "DescribeAbnormalProcessRuleDetail");
        }

        /// <summary>
        /// This API is used to query the details of an abnormal process policy at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeAbnormalProcessRuleDetailRequest"/></param>
        /// <returns><see cref="DescribeAbnormalProcessRuleDetailResponse"/></returns>
        public DescribeAbnormalProcessRuleDetailResponse DescribeAbnormalProcessRuleDetailSync(DescribeAbnormalProcessRuleDetailRequest req)
        {
            return InternalRequestAsync<DescribeAbnormalProcessRuleDetailResponse>(req, "DescribeAbnormalProcessRuleDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of abnormal process policies at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeAbnormalProcessRulesRequest"/></param>
        /// <returns><see cref="DescribeAbnormalProcessRulesResponse"/></returns>
        public Task<DescribeAbnormalProcessRulesResponse> DescribeAbnormalProcessRules(DescribeAbnormalProcessRulesRequest req)
        {
            return InternalRequestAsync<DescribeAbnormalProcessRulesResponse>(req, "DescribeAbnormalProcessRules");
        }

        /// <summary>
        /// This API is used to query the list of abnormal process policies at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeAbnormalProcessRulesRequest"/></param>
        /// <returns><see cref="DescribeAbnormalProcessRulesResponse"/></returns>
        public DescribeAbnormalProcessRulesResponse DescribeAbnormalProcessRulesSync(DescribeAbnormalProcessRulesRequest req)
        {
            return InternalRequestAsync<DescribeAbnormalProcessRulesResponse>(req, "DescribeAbnormalProcessRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query and export the list of abnormal process policies at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeAbnormalProcessRulesExportRequest"/></param>
        /// <returns><see cref="DescribeAbnormalProcessRulesExportResponse"/></returns>
        public Task<DescribeAbnormalProcessRulesExportResponse> DescribeAbnormalProcessRulesExport(DescribeAbnormalProcessRulesExportRequest req)
        {
            return InternalRequestAsync<DescribeAbnormalProcessRulesExportResponse>(req, "DescribeAbnormalProcessRulesExport");
        }

        /// <summary>
        /// This API is used to query and export the list of abnormal process policies at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeAbnormalProcessRulesExportRequest"/></param>
        /// <returns><see cref="DescribeAbnormalProcessRulesExportResponse"/></returns>
        public DescribeAbnormalProcessRulesExportResponse DescribeAbnormalProcessRulesExportSync(DescribeAbnormalProcessRulesExportRequest req)
        {
            return InternalRequestAsync<DescribeAbnormalProcessRulesExportResponse>(req, "DescribeAbnormalProcessRulesExport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of an access control event at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessControlDetailRequest"/></param>
        /// <returns><see cref="DescribeAccessControlDetailResponse"/></returns>
        public Task<DescribeAccessControlDetailResponse> DescribeAccessControlDetail(DescribeAccessControlDetailRequest req)
        {
            return InternalRequestAsync<DescribeAccessControlDetailResponse>(req, "DescribeAccessControlDetail");
        }

        /// <summary>
        /// This API is used to query the details of an access control event at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessControlDetailRequest"/></param>
        /// <returns><see cref="DescribeAccessControlDetailResponse"/></returns>
        public DescribeAccessControlDetailResponse DescribeAccessControlDetailSync(DescribeAccessControlDetailRequest req)
        {
            return InternalRequestAsync<DescribeAccessControlDetailResponse>(req, "DescribeAccessControlDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of access control events at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessControlEventsRequest"/></param>
        /// <returns><see cref="DescribeAccessControlEventsResponse"/></returns>
        public Task<DescribeAccessControlEventsResponse> DescribeAccessControlEvents(DescribeAccessControlEventsRequest req)
        {
            return InternalRequestAsync<DescribeAccessControlEventsResponse>(req, "DescribeAccessControlEvents");
        }

        /// <summary>
        /// This API is used to query the list of access control events at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessControlEventsRequest"/></param>
        /// <returns><see cref="DescribeAccessControlEventsResponse"/></returns>
        public DescribeAccessControlEventsResponse DescribeAccessControlEventsSync(DescribeAccessControlEventsRequest req)
        {
            return InternalRequestAsync<DescribeAccessControlEventsResponse>(req, "DescribeAccessControlEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the list of access control events at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessControlEventsExportRequest"/></param>
        /// <returns><see cref="DescribeAccessControlEventsExportResponse"/></returns>
        public Task<DescribeAccessControlEventsExportResponse> DescribeAccessControlEventsExport(DescribeAccessControlEventsExportRequest req)
        {
            return InternalRequestAsync<DescribeAccessControlEventsExportResponse>(req, "DescribeAccessControlEventsExport");
        }

        /// <summary>
        /// This API is used to export the list of access control events at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessControlEventsExportRequest"/></param>
        /// <returns><see cref="DescribeAccessControlEventsExportResponse"/></returns>
        public DescribeAccessControlEventsExportResponse DescribeAccessControlEventsExportSync(DescribeAccessControlEventsExportRequest req)
        {
            return InternalRequestAsync<DescribeAccessControlEventsExportResponse>(req, "DescribeAccessControlEventsExport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of an access control policy at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessControlRuleDetailRequest"/></param>
        /// <returns><see cref="DescribeAccessControlRuleDetailResponse"/></returns>
        public Task<DescribeAccessControlRuleDetailResponse> DescribeAccessControlRuleDetail(DescribeAccessControlRuleDetailRequest req)
        {
            return InternalRequestAsync<DescribeAccessControlRuleDetailResponse>(req, "DescribeAccessControlRuleDetail");
        }

        /// <summary>
        /// This API is used to query the details of an access control policy at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessControlRuleDetailRequest"/></param>
        /// <returns><see cref="DescribeAccessControlRuleDetailResponse"/></returns>
        public DescribeAccessControlRuleDetailResponse DescribeAccessControlRuleDetailSync(DescribeAccessControlRuleDetailRequest req)
        {
            return InternalRequestAsync<DescribeAccessControlRuleDetailResponse>(req, "DescribeAccessControlRuleDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of access control policies at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessControlRulesRequest"/></param>
        /// <returns><see cref="DescribeAccessControlRulesResponse"/></returns>
        public Task<DescribeAccessControlRulesResponse> DescribeAccessControlRules(DescribeAccessControlRulesRequest req)
        {
            return InternalRequestAsync<DescribeAccessControlRulesResponse>(req, "DescribeAccessControlRules");
        }

        /// <summary>
        /// This API is used to query the list of access control policies at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessControlRulesRequest"/></param>
        /// <returns><see cref="DescribeAccessControlRulesResponse"/></returns>
        public DescribeAccessControlRulesResponse DescribeAccessControlRulesSync(DescribeAccessControlRulesRequest req)
        {
            return InternalRequestAsync<DescribeAccessControlRulesResponse>(req, "DescribeAccessControlRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the list of access control policies at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessControlRulesExportRequest"/></param>
        /// <returns><see cref="DescribeAccessControlRulesExportResponse"/></returns>
        public Task<DescribeAccessControlRulesExportResponse> DescribeAccessControlRulesExport(DescribeAccessControlRulesExportRequest req)
        {
            return InternalRequestAsync<DescribeAccessControlRulesExportResponse>(req, "DescribeAccessControlRulesExport");
        }

        /// <summary>
        /// This API is used to export the list of access control policies at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessControlRulesExportRequest"/></param>
        /// <returns><see cref="DescribeAccessControlRulesExportResponse"/></returns>
        public DescribeAccessControlRulesExportResponse DescribeAccessControlRulesExportSync(DescribeAccessControlRulesExportRequest req)
        {
            return InternalRequestAsync<DescribeAccessControlRulesExportResponse>(req, "DescribeAccessControlRulesExport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get and return the number of affected clusters.
        /// </summary>
        /// <param name="req"><see cref="DescribeAffectedClusterCountRequest"/></param>
        /// <returns><see cref="DescribeAffectedClusterCountResponse"/></returns>
        public Task<DescribeAffectedClusterCountResponse> DescribeAffectedClusterCount(DescribeAffectedClusterCountRequest req)
        {
            return InternalRequestAsync<DescribeAffectedClusterCountResponse>(req, "DescribeAffectedClusterCount");
        }

        /// <summary>
        /// This API is used to get and return the number of affected clusters.
        /// </summary>
        /// <param name="req"><see cref="DescribeAffectedClusterCountRequest"/></param>
        /// <returns><see cref="DescribeAffectedClusterCountResponse"/></returns>
        public DescribeAffectedClusterCountResponse DescribeAffectedClusterCountSync(DescribeAffectedClusterCountRequest req)
        {
            return InternalRequestAsync<DescribeAffectedClusterCountResponse>(req, "DescribeAffectedClusterCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query affected node types and return the node list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAffectedNodeListRequest"/></param>
        /// <returns><see cref="DescribeAffectedNodeListResponse"/></returns>
        public Task<DescribeAffectedNodeListResponse> DescribeAffectedNodeList(DescribeAffectedNodeListRequest req)
        {
            return InternalRequestAsync<DescribeAffectedNodeListResponse>(req, "DescribeAffectedNodeList");
        }

        /// <summary>
        /// This API is used to query affected node types and return the node list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAffectedNodeListRequest"/></param>
        /// <returns><see cref="DescribeAffectedNodeListResponse"/></returns>
        public DescribeAffectedNodeListResponse DescribeAffectedNodeListSync(DescribeAffectedNodeListRequest req)
        {
            return InternalRequestAsync<DescribeAffectedNodeListResponse>(req, "DescribeAffectedNodeList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query affected workload types and return the workload list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAffectedWorkloadListRequest"/></param>
        /// <returns><see cref="DescribeAffectedWorkloadListResponse"/></returns>
        public Task<DescribeAffectedWorkloadListResponse> DescribeAffectedWorkloadList(DescribeAffectedWorkloadListRequest req)
        {
            return InternalRequestAsync<DescribeAffectedWorkloadListResponse>(req, "DescribeAffectedWorkloadList");
        }

        /// <summary>
        /// This API is used to query affected workload types and return the workload list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAffectedWorkloadListRequest"/></param>
        /// <returns><see cref="DescribeAffectedWorkloadListResponse"/></returns>
        public DescribeAffectedWorkloadListResponse DescribeAffectedWorkloadListSync(DescribeAffectedWorkloadListRequest req)
        {
            return InternalRequestAsync<DescribeAffectedWorkloadListResponse>(req, "DescribeAffectedWorkloadList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query parallel container installation commands.
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentDaemonSetCmdRequest"/></param>
        /// <returns><see cref="DescribeAgentDaemonSetCmdResponse"/></returns>
        public Task<DescribeAgentDaemonSetCmdResponse> DescribeAgentDaemonSetCmd(DescribeAgentDaemonSetCmdRequest req)
        {
            return InternalRequestAsync<DescribeAgentDaemonSetCmdResponse>(req, "DescribeAgentDaemonSetCmd");
        }

        /// <summary>
        /// This API is used to query parallel container installation commands.
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentDaemonSetCmdRequest"/></param>
        /// <returns><see cref="DescribeAgentDaemonSetCmdResponse"/></returns>
        public DescribeAgentDaemonSetCmdResponse DescribeAgentDaemonSetCmdSync(DescribeAgentDaemonSetCmdRequest req)
        {
            return InternalRequestAsync<DescribeAgentDaemonSetCmdResponse>(req, "DescribeAgentDaemonSetCmd")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query agent installation commands.
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentInstallCommandRequest"/></param>
        /// <returns><see cref="DescribeAgentInstallCommandResponse"/></returns>
        public Task<DescribeAgentInstallCommandResponse> DescribeAgentInstallCommand(DescribeAgentInstallCommandRequest req)
        {
            return InternalRequestAsync<DescribeAgentInstallCommandResponse>(req, "DescribeAgentInstallCommand");
        }

        /// <summary>
        /// This API is used to query agent installation commands.
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentInstallCommandRequest"/></param>
        /// <returns><see cref="DescribeAgentInstallCommandResponse"/></returns>
        public DescribeAgentInstallCommandResponse DescribeAgentInstallCommandSync(DescribeAgentInstallCommandRequest req)
        {
            return InternalRequestAsync<DescribeAgentInstallCommandResponse>(req, "DescribeAgentInstallCommand")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of application services.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetAppServiceListRequest"/></param>
        /// <returns><see cref="DescribeAssetAppServiceListResponse"/></returns>
        public Task<DescribeAssetAppServiceListResponse> DescribeAssetAppServiceList(DescribeAssetAppServiceListRequest req)
        {
            return InternalRequestAsync<DescribeAssetAppServiceListResponse>(req, "DescribeAssetAppServiceList");
        }

        /// <summary>
        /// This API is used to query the list of application services.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetAppServiceListRequest"/></param>
        /// <returns><see cref="DescribeAssetAppServiceListResponse"/></returns>
        public DescribeAssetAppServiceListResponse DescribeAssetAppServiceListSync(DescribeAssetAppServiceListRequest req)
        {
            return InternalRequestAsync<DescribeAssetAppServiceListResponse>(req, "DescribeAssetAppServiceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of clusters.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetClusterListRequest"/></param>
        /// <returns><see cref="DescribeAssetClusterListResponse"/></returns>
        public Task<DescribeAssetClusterListResponse> DescribeAssetClusterList(DescribeAssetClusterListRequest req)
        {
            return InternalRequestAsync<DescribeAssetClusterListResponse>(req, "DescribeAssetClusterList");
        }

        /// <summary>
        /// This API is used to query the list of clusters.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetClusterListRequest"/></param>
        /// <returns><see cref="DescribeAssetClusterListResponse"/></returns>
        public DescribeAssetClusterListResponse DescribeAssetClusterListSync(DescribeAssetClusterListRequest req)
        {
            return InternalRequestAsync<DescribeAssetClusterListResponse>(req, "DescribeAssetClusterList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of container components.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetComponentListRequest"/></param>
        /// <returns><see cref="DescribeAssetComponentListResponse"/></returns>
        public Task<DescribeAssetComponentListResponse> DescribeAssetComponentList(DescribeAssetComponentListRequest req)
        {
            return InternalRequestAsync<DescribeAssetComponentListResponse>(req, "DescribeAssetComponentList");
        }

        /// <summary>
        /// This API is used to query the list of container components.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetComponentListRequest"/></param>
        /// <returns><see cref="DescribeAssetComponentListResponse"/></returns>
        public DescribeAssetComponentListResponse DescribeAssetComponentListSync(DescribeAssetComponentListRequest req)
        {
            return InternalRequestAsync<DescribeAssetComponentListResponse>(req, "DescribeAssetComponentList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of a container.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetContainerDetailRequest"/></param>
        /// <returns><see cref="DescribeAssetContainerDetailResponse"/></returns>
        public Task<DescribeAssetContainerDetailResponse> DescribeAssetContainerDetail(DescribeAssetContainerDetailRequest req)
        {
            return InternalRequestAsync<DescribeAssetContainerDetailResponse>(req, "DescribeAssetContainerDetail");
        }

        /// <summary>
        /// This API is used to query the information of a container.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetContainerDetailRequest"/></param>
        /// <returns><see cref="DescribeAssetContainerDetailResponse"/></returns>
        public DescribeAssetContainerDetailResponse DescribeAssetContainerDetailSync(DescribeAssetContainerDetailRequest req)
        {
            return InternalRequestAsync<DescribeAssetContainerDetailResponse>(req, "DescribeAssetContainerDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of containers.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetContainerListRequest"/></param>
        /// <returns><see cref="DescribeAssetContainerListResponse"/></returns>
        public Task<DescribeAssetContainerListResponse> DescribeAssetContainerList(DescribeAssetContainerListRequest req)
        {
            return InternalRequestAsync<DescribeAssetContainerListResponse>(req, "DescribeAssetContainerList");
        }

        /// <summary>
        /// This API is used to query the list of containers.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetContainerListRequest"/></param>
        /// <returns><see cref="DescribeAssetContainerListResponse"/></returns>
        public DescribeAssetContainerListResponse DescribeAssetContainerListSync(DescribeAssetContainerListRequest req)
        {
            return InternalRequestAsync<DescribeAssetContainerListResponse>(req, "DescribeAssetContainerList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of database services.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetDBServiceListRequest"/></param>
        /// <returns><see cref="DescribeAssetDBServiceListResponse"/></returns>
        public Task<DescribeAssetDBServiceListResponse> DescribeAssetDBServiceList(DescribeAssetDBServiceListRequest req)
        {
            return InternalRequestAsync<DescribeAssetDBServiceListResponse>(req, "DescribeAssetDBServiceList");
        }

        /// <summary>
        /// This API is used to query the list of database services.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetDBServiceListRequest"/></param>
        /// <returns><see cref="DescribeAssetDBServiceListResponse"/></returns>
        public DescribeAssetDBServiceListResponse DescribeAssetDBServiceListSync(DescribeAssetDBServiceListRequest req)
        {
            return InternalRequestAsync<DescribeAssetDBServiceListResponse>(req, "DescribeAssetDBServiceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of a server.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetHostDetailRequest"/></param>
        /// <returns><see cref="DescribeAssetHostDetailResponse"/></returns>
        public Task<DescribeAssetHostDetailResponse> DescribeAssetHostDetail(DescribeAssetHostDetailRequest req)
        {
            return InternalRequestAsync<DescribeAssetHostDetailResponse>(req, "DescribeAssetHostDetail");
        }

        /// <summary>
        /// This API is used to query the details of a server.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetHostDetailRequest"/></param>
        /// <returns><see cref="DescribeAssetHostDetailResponse"/></returns>
        public DescribeAssetHostDetailResponse DescribeAssetHostDetailSync(DescribeAssetHostDetailRequest req)
        {
            return InternalRequestAsync<DescribeAssetHostDetailResponse>(req, "DescribeAssetHostDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of servers.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetHostListRequest"/></param>
        /// <returns><see cref="DescribeAssetHostListResponse"/></returns>
        public Task<DescribeAssetHostListResponse> DescribeAssetHostList(DescribeAssetHostListRequest req)
        {
            return InternalRequestAsync<DescribeAssetHostListResponse>(req, "DescribeAssetHostList");
        }

        /// <summary>
        /// This API is used to query the list of servers.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetHostListRequest"/></param>
        /// <returns><see cref="DescribeAssetHostListResponse"/></returns>
        public DescribeAssetHostListResponse DescribeAssetHostListSync(DescribeAssetHostListRequest req)
        {
            return InternalRequestAsync<DescribeAssetHostListResponse>(req, "DescribeAssetHostList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of rules bound to images, including runtime access control and abnormal process rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageBindRuleInfoRequest"/></param>
        /// <returns><see cref="DescribeAssetImageBindRuleInfoResponse"/></returns>
        public Task<DescribeAssetImageBindRuleInfoResponse> DescribeAssetImageBindRuleInfo(DescribeAssetImageBindRuleInfoRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageBindRuleInfoResponse>(req, "DescribeAssetImageBindRuleInfo");
        }

        /// <summary>
        /// This API is used to query the list of rules bound to images, including runtime access control and abnormal process rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageBindRuleInfoRequest"/></param>
        /// <returns><see cref="DescribeAssetImageBindRuleInfoResponse"/></returns>
        public DescribeAssetImageBindRuleInfoResponse DescribeAssetImageBindRuleInfoSync(DescribeAssetImageBindRuleInfoRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageBindRuleInfoResponse>(req, "DescribeAssetImageBindRuleInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of an image.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageDetailRequest"/></param>
        /// <returns><see cref="DescribeAssetImageDetailResponse"/></returns>
        public Task<DescribeAssetImageDetailResponse> DescribeAssetImageDetail(DescribeAssetImageDetailRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageDetailResponse>(req, "DescribeAssetImageDetail");
        }

        /// <summary>
        /// This API is used to query the details of an image.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageDetailRequest"/></param>
        /// <returns><see cref="DescribeAssetImageDetailResponse"/></returns>
        public DescribeAssetImageDetailResponse DescribeAssetImageDetailSync(DescribeAssetImageDetailRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageDetailResponse>(req, "DescribeAssetImageDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the servers associated with an image.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageHostListRequest"/></param>
        /// <returns><see cref="DescribeAssetImageHostListResponse"/></returns>
        public Task<DescribeAssetImageHostListResponse> DescribeAssetImageHostList(DescribeAssetImageHostListRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageHostListResponse>(req, "DescribeAssetImageHostList");
        }

        /// <summary>
        /// This API is used to query the servers associated with an image.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageHostListRequest"/></param>
        /// <returns><see cref="DescribeAssetImageHostListResponse"/></returns>
        public DescribeAssetImageHostListResponse DescribeAssetImageHostListSync(DescribeAssetImageHostListRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageHostListResponse>(req, "DescribeAssetImageHostList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of images.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageListRequest"/></param>
        /// <returns><see cref="DescribeAssetImageListResponse"/></returns>
        public Task<DescribeAssetImageListResponse> DescribeAssetImageList(DescribeAssetImageListRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageListResponse>(req, "DescribeAssetImageList");
        }

        /// <summary>
        /// This API is used to query the list of images.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageListRequest"/></param>
        /// <returns><see cref="DescribeAssetImageListResponse"/></returns>
        public DescribeAssetImageListResponse DescribeAssetImageListSync(DescribeAssetImageListRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageListResponse>(req, "DescribeAssetImageList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the list of images.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageListExportRequest"/></param>
        /// <returns><see cref="DescribeAssetImageListExportResponse"/></returns>
        public Task<DescribeAssetImageListExportResponse> DescribeAssetImageListExport(DescribeAssetImageListExportRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageListExportResponse>(req, "DescribeAssetImageListExport");
        }

        /// <summary>
        /// This API is used to export the list of images.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageListExportRequest"/></param>
        /// <returns><see cref="DescribeAssetImageListExportResponse"/></returns>
        public DescribeAssetImageListExportResponse DescribeAssetImageListExportSync(DescribeAssetImageListExportRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageListExportResponse>(req, "DescribeAssetImageListExport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to view the update progress of the assets in an image repository.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryAssetStatusRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryAssetStatusResponse"/></returns>
        public Task<DescribeAssetImageRegistryAssetStatusResponse> DescribeAssetImageRegistryAssetStatus(DescribeAssetImageRegistryAssetStatusRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageRegistryAssetStatusResponse>(req, "DescribeAssetImageRegistryAssetStatus");
        }

        /// <summary>
        /// This API is used to view the update progress of the assets in an image repository.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryAssetStatusRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryAssetStatusResponse"/></returns>
        public DescribeAssetImageRegistryAssetStatusResponse DescribeAssetImageRegistryAssetStatusSync(DescribeAssetImageRegistryAssetStatusRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageRegistryAssetStatusResponse>(req, "DescribeAssetImageRegistryAssetStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the image repository details.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryDetailRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryDetailResponse"/></returns>
        public Task<DescribeAssetImageRegistryDetailResponse> DescribeAssetImageRegistryDetail(DescribeAssetImageRegistryDetailRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageRegistryDetailResponse>(req, "DescribeAssetImageRegistryDetail");
        }

        /// <summary>
        /// This API is used to query the image repository details.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryDetailRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryDetailResponse"/></returns>
        public DescribeAssetImageRegistryDetailResponse DescribeAssetImageRegistryDetailSync(DescribeAssetImageRegistryDetailRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageRegistryDetailResponse>(req, "DescribeAssetImageRegistryDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of image repositories.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryListRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryListResponse"/></returns>
        public Task<DescribeAssetImageRegistryListResponse> DescribeAssetImageRegistryList(DescribeAssetImageRegistryListRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageRegistryListResponse>(req, "DescribeAssetImageRegistryList");
        }

        /// <summary>
        /// This API is used to query the list of image repositories.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryListRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryListResponse"/></returns>
        public DescribeAssetImageRegistryListResponse DescribeAssetImageRegistryListSync(DescribeAssetImageRegistryListRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageRegistryListResponse>(req, "DescribeAssetImageRegistryList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the list of images for an image repository.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryListExportRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryListExportResponse"/></returns>
        public Task<DescribeAssetImageRegistryListExportResponse> DescribeAssetImageRegistryListExport(DescribeAssetImageRegistryListExportRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageRegistryListExportResponse>(req, "DescribeAssetImageRegistryListExport");
        }

        /// <summary>
        /// This API is used to export the list of images for an image repository.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryListExportRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryListExportResponse"/></returns>
        public DescribeAssetImageRegistryListExportResponse DescribeAssetImageRegistryListExportSync(DescribeAssetImageRegistryListExportRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageRegistryListExportResponse>(req, "DescribeAssetImageRegistryListExport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to view the details of an image repository.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryRegistryDetailRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryRegistryDetailResponse"/></returns>
        public Task<DescribeAssetImageRegistryRegistryDetailResponse> DescribeAssetImageRegistryRegistryDetail(DescribeAssetImageRegistryRegistryDetailRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageRegistryRegistryDetailResponse>(req, "DescribeAssetImageRegistryRegistryDetail");
        }

        /// <summary>
        /// This API is used to view the details of an image repository.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryRegistryDetailRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryRegistryDetailResponse"/></returns>
        public DescribeAssetImageRegistryRegistryDetailResponse DescribeAssetImageRegistryRegistryDetailSync(DescribeAssetImageRegistryRegistryDetailRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageRegistryRegistryDetailResponse>(req, "DescribeAssetImageRegistryRegistryDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of image registries.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryRegistryListRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryRegistryListResponse"/></returns>
        public Task<DescribeAssetImageRegistryRegistryListResponse> DescribeAssetImageRegistryRegistryList(DescribeAssetImageRegistryRegistryListRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageRegistryRegistryListResponse>(req, "DescribeAssetImageRegistryRegistryList");
        }

        /// <summary>
        /// This API is used to query the list of image registries.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryRegistryListRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryRegistryListResponse"/></returns>
        public DescribeAssetImageRegistryRegistryListResponse DescribeAssetImageRegistryRegistryListSync(DescribeAssetImageRegistryRegistryListRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageRegistryRegistryListResponse>(req, "DescribeAssetImageRegistryRegistryList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of image high-risk behaviors of an image repository.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryRiskInfoListRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryRiskInfoListResponse"/></returns>
        public Task<DescribeAssetImageRegistryRiskInfoListResponse> DescribeAssetImageRegistryRiskInfoList(DescribeAssetImageRegistryRiskInfoListRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageRegistryRiskInfoListResponse>(req, "DescribeAssetImageRegistryRiskInfoList");
        }

        /// <summary>
        /// This API is used to query the list of image high-risk behaviors of an image repository.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryRiskInfoListRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryRiskInfoListResponse"/></returns>
        public DescribeAssetImageRegistryRiskInfoListResponse DescribeAssetImageRegistryRiskInfoListSync(DescribeAssetImageRegistryRiskInfoListRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageRegistryRiskInfoListResponse>(req, "DescribeAssetImageRegistryRiskInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the list of sensitive data for an image repository.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryRiskListExportRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryRiskListExportResponse"/></returns>
        public Task<DescribeAssetImageRegistryRiskListExportResponse> DescribeAssetImageRegistryRiskListExport(DescribeAssetImageRegistryRiskListExportRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageRegistryRiskListExportResponse>(req, "DescribeAssetImageRegistryRiskListExport");
        }

        /// <summary>
        /// This API is used to export the list of sensitive data for an image repository.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryRiskListExportRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryRiskListExportResponse"/></returns>
        public DescribeAssetImageRegistryRiskListExportResponse DescribeAssetImageRegistryRiskListExportSync(DescribeAssetImageRegistryRiskListExportRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageRegistryRiskListExportResponse>(req, "DescribeAssetImageRegistryRiskListExport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the quick image scanning status of an image repository.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryScanStatusOneKeyRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryScanStatusOneKeyResponse"/></returns>
        public Task<DescribeAssetImageRegistryScanStatusOneKeyResponse> DescribeAssetImageRegistryScanStatusOneKey(DescribeAssetImageRegistryScanStatusOneKeyRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageRegistryScanStatusOneKeyResponse>(req, "DescribeAssetImageRegistryScanStatusOneKey");
        }

        /// <summary>
        /// This API is used to query the quick image scanning status of an image repository.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryScanStatusOneKeyRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryScanStatusOneKeyResponse"/></returns>
        public DescribeAssetImageRegistryScanStatusOneKeyResponse DescribeAssetImageRegistryScanStatusOneKeySync(DescribeAssetImageRegistryScanStatusOneKeyRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageRegistryScanStatusOneKeyResponse>(req, "DescribeAssetImageRegistryScanStatusOneKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the image statistics of an image repository.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistrySummaryRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistrySummaryResponse"/></returns>
        public Task<DescribeAssetImageRegistrySummaryResponse> DescribeAssetImageRegistrySummary(DescribeAssetImageRegistrySummaryRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageRegistrySummaryResponse>(req, "DescribeAssetImageRegistrySummary");
        }

        /// <summary>
        /// This API is used to query the image statistics of an image repository.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistrySummaryRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistrySummaryResponse"/></returns>
        public DescribeAssetImageRegistrySummaryResponse DescribeAssetImageRegistrySummarySync(DescribeAssetImageRegistrySummaryRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageRegistrySummaryResponse>(req, "DescribeAssetImageRegistrySummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of viruses and trojans in an image repository.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryVirusListRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryVirusListResponse"/></returns>
        public Task<DescribeAssetImageRegistryVirusListResponse> DescribeAssetImageRegistryVirusList(DescribeAssetImageRegistryVirusListRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageRegistryVirusListResponse>(req, "DescribeAssetImageRegistryVirusList");
        }

        /// <summary>
        /// This API is used to query the list of viruses and trojans in an image repository.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryVirusListRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryVirusListResponse"/></returns>
        public DescribeAssetImageRegistryVirusListResponse DescribeAssetImageRegistryVirusListSync(DescribeAssetImageRegistryVirusListRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageRegistryVirusListResponse>(req, "DescribeAssetImageRegistryVirusList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the list of trojan information for an image repository.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryVirusListExportRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryVirusListExportResponse"/></returns>
        public Task<DescribeAssetImageRegistryVirusListExportResponse> DescribeAssetImageRegistryVirusListExport(DescribeAssetImageRegistryVirusListExportRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageRegistryVirusListExportResponse>(req, "DescribeAssetImageRegistryVirusListExport");
        }

        /// <summary>
        /// This API is used to export the list of trojan information for an image repository.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryVirusListExportRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryVirusListExportResponse"/></returns>
        public DescribeAssetImageRegistryVirusListExportResponse DescribeAssetImageRegistryVirusListExportSync(DescribeAssetImageRegistryVirusListExportRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageRegistryVirusListExportResponse>(req, "DescribeAssetImageRegistryVirusListExport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of image vulnerabilities of an image repository
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryVulListRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryVulListResponse"/></returns>
        public Task<DescribeAssetImageRegistryVulListResponse> DescribeAssetImageRegistryVulList(DescribeAssetImageRegistryVulListRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageRegistryVulListResponse>(req, "DescribeAssetImageRegistryVulList");
        }

        /// <summary>
        /// This API is used to query the list of image vulnerabilities of an image repository
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryVulListRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryVulListResponse"/></returns>
        public DescribeAssetImageRegistryVulListResponse DescribeAssetImageRegistryVulListSync(DescribeAssetImageRegistryVulListRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageRegistryVulListResponse>(req, "DescribeAssetImageRegistryVulList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the list of vulnerabilities for an image repository.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryVulListExportRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryVulListExportResponse"/></returns>
        public Task<DescribeAssetImageRegistryVulListExportResponse> DescribeAssetImageRegistryVulListExport(DescribeAssetImageRegistryVulListExportRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageRegistryVulListExportResponse>(req, "DescribeAssetImageRegistryVulListExport");
        }

        /// <summary>
        /// This API is used to export the list of vulnerabilities for an image repository.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryVulListExportRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryVulListExportResponse"/></returns>
        public DescribeAssetImageRegistryVulListExportResponse DescribeAssetImageRegistryVulListExportSync(DescribeAssetImageRegistryVulListExportRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageRegistryVulListExportResponse>(req, "DescribeAssetImageRegistryVulListExport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of risks in an image.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRiskListRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRiskListResponse"/></returns>
        public Task<DescribeAssetImageRiskListResponse> DescribeAssetImageRiskList(DescribeAssetImageRiskListRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageRiskListResponse>(req, "DescribeAssetImageRiskList");
        }

        /// <summary>
        /// This API is used to query the list of risks in an image.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRiskListRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRiskListResponse"/></returns>
        public DescribeAssetImageRiskListResponse DescribeAssetImageRiskListSync(DescribeAssetImageRiskListRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageRiskListResponse>(req, "DescribeAssetImageRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the list of risks in an image.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRiskListExportRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRiskListExportResponse"/></returns>
        public Task<DescribeAssetImageRiskListExportResponse> DescribeAssetImageRiskListExport(DescribeAssetImageRiskListExportRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageRiskListExportResponse>(req, "DescribeAssetImageRiskListExport");
        }

        /// <summary>
        /// This API is used to export the list of risks in an image.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRiskListExportRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRiskListExportResponse"/></returns>
        public DescribeAssetImageRiskListExportResponse DescribeAssetImageRiskListExportSync(DescribeAssetImageRiskListExportRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageRiskListExportResponse>(req, "DescribeAssetImageRiskListExport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the image scan settings.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageScanSettingRequest"/></param>
        /// <returns><see cref="DescribeAssetImageScanSettingResponse"/></returns>
        public Task<DescribeAssetImageScanSettingResponse> DescribeAssetImageScanSetting(DescribeAssetImageScanSettingRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageScanSettingResponse>(req, "DescribeAssetImageScanSetting");
        }

        /// <summary>
        /// This API is used to get the image scan settings.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageScanSettingRequest"/></param>
        /// <returns><see cref="DescribeAssetImageScanSettingResponse"/></returns>
        public DescribeAssetImageScanSettingResponse DescribeAssetImageScanSettingSync(DescribeAssetImageScanSettingRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageScanSettingResponse>(req, "DescribeAssetImageScanSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the image scanning status.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageScanStatusRequest"/></param>
        /// <returns><see cref="DescribeAssetImageScanStatusResponse"/></returns>
        public Task<DescribeAssetImageScanStatusResponse> DescribeAssetImageScanStatus(DescribeAssetImageScanStatusRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageScanStatusResponse>(req, "DescribeAssetImageScanStatus");
        }

        /// <summary>
        /// This API is used to query the image scanning status.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageScanStatusRequest"/></param>
        /// <returns><see cref="DescribeAssetImageScanStatusResponse"/></returns>
        public DescribeAssetImageScanStatusResponse DescribeAssetImageScanStatusSync(DescribeAssetImageScanStatusRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageScanStatusResponse>(req, "DescribeAssetImageScanStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the ID of a running quick image scan task.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageScanTaskRequest"/></param>
        /// <returns><see cref="DescribeAssetImageScanTaskResponse"/></returns>
        public Task<DescribeAssetImageScanTaskResponse> DescribeAssetImageScanTask(DescribeAssetImageScanTaskRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageScanTaskResponse>(req, "DescribeAssetImageScanTask");
        }

        /// <summary>
        /// This API is used to query the ID of a running quick image scan task.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageScanTaskRequest"/></param>
        /// <returns><see cref="DescribeAssetImageScanTaskResponse"/></returns>
        public DescribeAssetImageScanTaskResponse DescribeAssetImageScanTaskSync(DescribeAssetImageScanTaskRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageScanTaskResponse>(req, "DescribeAssetImageScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the brief information list of an image.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageSimpleListRequest"/></param>
        /// <returns><see cref="DescribeAssetImageSimpleListResponse"/></returns>
        public Task<DescribeAssetImageSimpleListResponse> DescribeAssetImageSimpleList(DescribeAssetImageSimpleListRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageSimpleListResponse>(req, "DescribeAssetImageSimpleList");
        }

        /// <summary>
        /// This API is used to query the brief information list of an image.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageSimpleListRequest"/></param>
        /// <returns><see cref="DescribeAssetImageSimpleListResponse"/></returns>
        public DescribeAssetImageSimpleListResponse DescribeAssetImageSimpleListSync(DescribeAssetImageSimpleListRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageSimpleListResponse>(req, "DescribeAssetImageSimpleList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of viruses in an image.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageVirusListRequest"/></param>
        /// <returns><see cref="DescribeAssetImageVirusListResponse"/></returns>
        public Task<DescribeAssetImageVirusListResponse> DescribeAssetImageVirusList(DescribeAssetImageVirusListRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageVirusListResponse>(req, "DescribeAssetImageVirusList");
        }

        /// <summary>
        /// This API is used to query the list of viruses in an image.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageVirusListRequest"/></param>
        /// <returns><see cref="DescribeAssetImageVirusListResponse"/></returns>
        public DescribeAssetImageVirusListResponse DescribeAssetImageVirusListSync(DescribeAssetImageVirusListRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageVirusListResponse>(req, "DescribeAssetImageVirusList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the list of trojans in an image.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageVirusListExportRequest"/></param>
        /// <returns><see cref="DescribeAssetImageVirusListExportResponse"/></returns>
        public Task<DescribeAssetImageVirusListExportResponse> DescribeAssetImageVirusListExport(DescribeAssetImageVirusListExportRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageVirusListExportResponse>(req, "DescribeAssetImageVirusListExport");
        }

        /// <summary>
        /// This API is used to export the list of trojans in an image.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageVirusListExportRequest"/></param>
        /// <returns><see cref="DescribeAssetImageVirusListExportResponse"/></returns>
        public DescribeAssetImageVirusListExportResponse DescribeAssetImageVirusListExportSync(DescribeAssetImageVirusListExportRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageVirusListExportResponse>(req, "DescribeAssetImageVirusListExport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of vulnerabilities in an image.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageVulListRequest"/></param>
        /// <returns><see cref="DescribeAssetImageVulListResponse"/></returns>
        public Task<DescribeAssetImageVulListResponse> DescribeAssetImageVulList(DescribeAssetImageVulListRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageVulListResponse>(req, "DescribeAssetImageVulList");
        }

        /// <summary>
        /// This API is used to query the list of vulnerabilities in an image.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageVulListRequest"/></param>
        /// <returns><see cref="DescribeAssetImageVulListResponse"/></returns>
        public DescribeAssetImageVulListResponse DescribeAssetImageVulListSync(DescribeAssetImageVulListRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageVulListResponse>(req, "DescribeAssetImageVulList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the list of vulnerabilities in an image.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageVulListExportRequest"/></param>
        /// <returns><see cref="DescribeAssetImageVulListExportResponse"/></returns>
        public Task<DescribeAssetImageVulListExportResponse> DescribeAssetImageVulListExport(DescribeAssetImageVulListExportRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageVulListExportResponse>(req, "DescribeAssetImageVulListExport");
        }

        /// <summary>
        /// This API is used to export the list of vulnerabilities in an image.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageVulListExportRequest"/></param>
        /// <returns><see cref="DescribeAssetImageVulListExportResponse"/></returns>
        public DescribeAssetImageVulListExportResponse DescribeAssetImageVulListExportSync(DescribeAssetImageVulListExportRequest req)
        {
            return InternalRequestAsync<DescribeAssetImageVulListExportResponse>(req, "DescribeAssetImageVulListExport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of occupied ports.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetPortListRequest"/></param>
        /// <returns><see cref="DescribeAssetPortListResponse"/></returns>
        public Task<DescribeAssetPortListResponse> DescribeAssetPortList(DescribeAssetPortListRequest req)
        {
            return InternalRequestAsync<DescribeAssetPortListResponse>(req, "DescribeAssetPortList");
        }

        /// <summary>
        /// This API is used to query the list of occupied ports.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetPortListRequest"/></param>
        /// <returns><see cref="DescribeAssetPortListResponse"/></returns>
        public DescribeAssetPortListResponse DescribeAssetPortListSync(DescribeAssetPortListRequest req)
        {
            return InternalRequestAsync<DescribeAssetPortListResponse>(req, "DescribeAssetPortList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of processes.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetProcessListRequest"/></param>
        /// <returns><see cref="DescribeAssetProcessListResponse"/></returns>
        public Task<DescribeAssetProcessListResponse> DescribeAssetProcessList(DescribeAssetProcessListRequest req)
        {
            return InternalRequestAsync<DescribeAssetProcessListResponse>(req, "DescribeAssetProcessList");
        }

        /// <summary>
        /// This API is used to query the list of processes.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetProcessListRequest"/></param>
        /// <returns><see cref="DescribeAssetProcessListResponse"/></returns>
        public DescribeAssetProcessListResponse DescribeAssetProcessListSync(DescribeAssetProcessListRequest req)
        {
            return InternalRequestAsync<DescribeAssetProcessListResponse>(req, "DescribeAssetProcessList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the statistics of containers and images under an account.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetSummaryRequest"/></param>
        /// <returns><see cref="DescribeAssetSummaryResponse"/></returns>
        public Task<DescribeAssetSummaryResponse> DescribeAssetSummary(DescribeAssetSummaryRequest req)
        {
            return InternalRequestAsync<DescribeAssetSummaryResponse>(req, "DescribeAssetSummary");
        }

        /// <summary>
        /// This API is used to query the statistics of containers and images under an account.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetSummaryRequest"/></param>
        /// <returns><see cref="DescribeAssetSummaryResponse"/></returns>
        public DescribeAssetSummaryResponse DescribeAssetSummarySync(DescribeAssetSummaryRequest req)
        {
            return InternalRequestAsync<DescribeAssetSummaryResponse>(req, "DescribeAssetSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the last asset sync time.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetSyncLastTimeRequest"/></param>
        /// <returns><see cref="DescribeAssetSyncLastTimeResponse"/></returns>
        public Task<DescribeAssetSyncLastTimeResponse> DescribeAssetSyncLastTime(DescribeAssetSyncLastTimeRequest req)
        {
            return InternalRequestAsync<DescribeAssetSyncLastTimeResponse>(req, "DescribeAssetSyncLastTime");
        }

        /// <summary>
        /// This API is used to query the last asset sync time.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetSyncLastTimeRequest"/></param>
        /// <returns><see cref="DescribeAssetSyncLastTimeResponse"/></returns>
        public DescribeAssetSyncLastTimeResponse DescribeAssetSyncLastTimeSync(DescribeAssetSyncLastTimeRequest req)
        {
            return InternalRequestAsync<DescribeAssetSyncLastTimeResponse>(req, "DescribeAssetSyncLastTime")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of web services.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebServiceListRequest"/></param>
        /// <returns><see cref="DescribeAssetWebServiceListResponse"/></returns>
        public Task<DescribeAssetWebServiceListResponse> DescribeAssetWebServiceList(DescribeAssetWebServiceListRequest req)
        {
            return InternalRequestAsync<DescribeAssetWebServiceListResponse>(req, "DescribeAssetWebServiceList");
        }

        /// <summary>
        /// This API is used to query the list of web services.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebServiceListRequest"/></param>
        /// <returns><see cref="DescribeAssetWebServiceListResponse"/></returns>
        public DescribeAssetWebServiceListResponse DescribeAssetWebServiceListSync(DescribeAssetWebServiceListRequest req)
        {
            return InternalRequestAsync<DescribeAssetWebServiceListResponse>(req, "DescribeAssetWebServiceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the servers licensed according to an automatic licensing rule.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoAuthorizedRuleHostRequest"/></param>
        /// <returns><see cref="DescribeAutoAuthorizedRuleHostResponse"/></returns>
        public Task<DescribeAutoAuthorizedRuleHostResponse> DescribeAutoAuthorizedRuleHost(DescribeAutoAuthorizedRuleHostRequest req)
        {
            return InternalRequestAsync<DescribeAutoAuthorizedRuleHostResponse>(req, "DescribeAutoAuthorizedRuleHost");
        }

        /// <summary>
        /// This API is used to query the servers licensed according to an automatic licensing rule.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoAuthorizedRuleHostRequest"/></param>
        /// <returns><see cref="DescribeAutoAuthorizedRuleHostResponse"/></returns>
        public DescribeAutoAuthorizedRuleHostResponse DescribeAutoAuthorizedRuleHostSync(DescribeAutoAuthorizedRuleHostRequest req)
        {
            return InternalRequestAsync<DescribeAutoAuthorizedRuleHostResponse>(req, "DescribeAutoAuthorizedRuleHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query all check items and return the total number and list of check items.
        /// </summary>
        /// <param name="req"><see cref="DescribeCheckItemListRequest"/></param>
        /// <returns><see cref="DescribeCheckItemListResponse"/></returns>
        public Task<DescribeCheckItemListResponse> DescribeCheckItemList(DescribeCheckItemListRequest req)
        {
            return InternalRequestAsync<DescribeCheckItemListResponse>(req, "DescribeCheckItemList");
        }

        /// <summary>
        /// This API is used to query all check items and return the total number and list of check items.
        /// </summary>
        /// <param name="req"><see cref="DescribeCheckItemListRequest"/></param>
        /// <returns><see cref="DescribeCheckItemListResponse"/></returns>
        public DescribeCheckItemListResponse DescribeCheckItemListSync(DescribeCheckItemListRequest req)
        {
            return InternalRequestAsync<DescribeCheckItemListResponse>(req, "DescribeCheckItemList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of a cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterDetailRequest"/></param>
        /// <returns><see cref="DescribeClusterDetailResponse"/></returns>
        public Task<DescribeClusterDetailResponse> DescribeClusterDetail(DescribeClusterDetailRequest req)
        {
            return InternalRequestAsync<DescribeClusterDetailResponse>(req, "DescribeClusterDetail");
        }

        /// <summary>
        /// This API is used to query the details of a cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterDetailRequest"/></param>
        /// <returns><see cref="DescribeClusterDetailResponse"/></returns>
        public DescribeClusterDetailResponse DescribeClusterDetailSync(DescribeClusterDetailRequest req)
        {
            return InternalRequestAsync<DescribeClusterDetailResponse>(req, "DescribeClusterDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the overview of cluster assets.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterSummaryRequest"/></param>
        /// <returns><see cref="DescribeClusterSummaryResponse"/></returns>
        public Task<DescribeClusterSummaryResponse> DescribeClusterSummary(DescribeClusterSummaryRequest req)
        {
            return InternalRequestAsync<DescribeClusterSummaryResponse>(req, "DescribeClusterSummary");
        }

        /// <summary>
        /// This API is used to query the overview of cluster assets.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterSummaryRequest"/></param>
        /// <returns><see cref="DescribeClusterSummaryResponse"/></returns>
        public DescribeClusterSummaryResponse DescribeClusterSummarySync(DescribeClusterSummaryRequest req)
        {
            return InternalRequestAsync<DescribeClusterSummaryResponse>(req, "DescribeClusterSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of an asset.
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceAssetDetailInfoRequest"/></param>
        /// <returns><see cref="DescribeComplianceAssetDetailInfoResponse"/></returns>
        public Task<DescribeComplianceAssetDetailInfoResponse> DescribeComplianceAssetDetailInfo(DescribeComplianceAssetDetailInfoRequest req)
        {
            return InternalRequestAsync<DescribeComplianceAssetDetailInfoResponse>(req, "DescribeComplianceAssetDetailInfo");
        }

        /// <summary>
        /// This API is used to query the details of an asset.
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceAssetDetailInfoRequest"/></param>
        /// <returns><see cref="DescribeComplianceAssetDetailInfoResponse"/></returns>
        public DescribeComplianceAssetDetailInfoResponse DescribeComplianceAssetDetailInfoSync(DescribeComplianceAssetDetailInfoRequest req)
        {
            return InternalRequestAsync<DescribeComplianceAssetDetailInfoResponse>(req, "DescribeComplianceAssetDetailInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of assets of a certain type.
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceAssetListRequest"/></param>
        /// <returns><see cref="DescribeComplianceAssetListResponse"/></returns>
        public Task<DescribeComplianceAssetListResponse> DescribeComplianceAssetList(DescribeComplianceAssetListRequest req)
        {
            return InternalRequestAsync<DescribeComplianceAssetListResponse>(req, "DescribeComplianceAssetList");
        }

        /// <summary>
        /// This API is used to query the list of assets of a certain type.
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceAssetListRequest"/></param>
        /// <returns><see cref="DescribeComplianceAssetListResponse"/></returns>
        public DescribeComplianceAssetListResponse DescribeComplianceAssetListSync(DescribeComplianceAssetListRequest req)
        {
            return InternalRequestAsync<DescribeComplianceAssetListResponse>(req, "DescribeComplianceAssetList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of check items of an asset.
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceAssetPolicyItemListRequest"/></param>
        /// <returns><see cref="DescribeComplianceAssetPolicyItemListResponse"/></returns>
        public Task<DescribeComplianceAssetPolicyItemListResponse> DescribeComplianceAssetPolicyItemList(DescribeComplianceAssetPolicyItemListRequest req)
        {
            return InternalRequestAsync<DescribeComplianceAssetPolicyItemListResponse>(req, "DescribeComplianceAssetPolicyItemList");
        }

        /// <summary>
        /// This API is used to query the list of check items of an asset.
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceAssetPolicyItemListRequest"/></param>
        /// <returns><see cref="DescribeComplianceAssetPolicyItemListResponse"/></returns>
        public DescribeComplianceAssetPolicyItemListResponse DescribeComplianceAssetPolicyItemListSync(DescribeComplianceAssetPolicyItemListRequest req)
        {
            return InternalRequestAsync<DescribeComplianceAssetPolicyItemListResponse>(req, "DescribeComplianceAssetPolicyItemList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of scheduled tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeCompliancePeriodTaskListRequest"/></param>
        /// <returns><see cref="DescribeCompliancePeriodTaskListResponse"/></returns>
        public Task<DescribeCompliancePeriodTaskListResponse> DescribeCompliancePeriodTaskList(DescribeCompliancePeriodTaskListRequest req)
        {
            return InternalRequestAsync<DescribeCompliancePeriodTaskListResponse>(req, "DescribeCompliancePeriodTaskList");
        }

        /// <summary>
        /// This API is used to query the list of scheduled tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeCompliancePeriodTaskListRequest"/></param>
        /// <returns><see cref="DescribeCompliancePeriodTaskListResponse"/></returns>
        public DescribeCompliancePeriodTaskListResponse DescribeCompliancePeriodTaskListSync(DescribeCompliancePeriodTaskListRequest req)
        {
            return InternalRequestAsync<DescribeCompliancePeriodTaskListResponse>(req, "DescribeCompliancePeriodTaskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to apply the asset level in the "check item + asset" two-level structure.
        /// </summary>
        /// <param name="req"><see cref="DescribeCompliancePolicyItemAffectedAssetListRequest"/></param>
        /// <returns><see cref="DescribeCompliancePolicyItemAffectedAssetListResponse"/></returns>
        public Task<DescribeCompliancePolicyItemAffectedAssetListResponse> DescribeCompliancePolicyItemAffectedAssetList(DescribeCompliancePolicyItemAffectedAssetListRequest req)
        {
            return InternalRequestAsync<DescribeCompliancePolicyItemAffectedAssetListResponse>(req, "DescribeCompliancePolicyItemAffectedAssetList");
        }

        /// <summary>
        /// This API is used to apply the asset level in the "check item + asset" two-level structure.
        /// </summary>
        /// <param name="req"><see cref="DescribeCompliancePolicyItemAffectedAssetListRequest"/></param>
        /// <returns><see cref="DescribeCompliancePolicyItemAffectedAssetListResponse"/></returns>
        public DescribeCompliancePolicyItemAffectedAssetListResponse DescribeCompliancePolicyItemAffectedAssetListSync(DescribeCompliancePolicyItemAffectedAssetListRequest req)
        {
            return InternalRequestAsync<DescribeCompliancePolicyItemAffectedAssetListResponse>(req, "DescribeCompliancePolicyItemAffectedAssetList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to apply the check item level in the "check item + asset" two-level structure.
        /// </summary>
        /// <param name="req"><see cref="DescribeCompliancePolicyItemAffectedSummaryRequest"/></param>
        /// <returns><see cref="DescribeCompliancePolicyItemAffectedSummaryResponse"/></returns>
        public Task<DescribeCompliancePolicyItemAffectedSummaryResponse> DescribeCompliancePolicyItemAffectedSummary(DescribeCompliancePolicyItemAffectedSummaryRequest req)
        {
            return InternalRequestAsync<DescribeCompliancePolicyItemAffectedSummaryResponse>(req, "DescribeCompliancePolicyItemAffectedSummary");
        }

        /// <summary>
        /// This API is used to apply the check item level in the "check item + asset" two-level structure.
        /// </summary>
        /// <param name="req"><see cref="DescribeCompliancePolicyItemAffectedSummaryRequest"/></param>
        /// <returns><see cref="DescribeCompliancePolicyItemAffectedSummaryResponse"/></returns>
        public DescribeCompliancePolicyItemAffectedSummaryResponse DescribeCompliancePolicyItemAffectedSummarySync(DescribeCompliancePolicyItemAffectedSummaryRequest req)
        {
            return InternalRequestAsync<DescribeCompliancePolicyItemAffectedSummaryResponse>(req, "DescribeCompliancePolicyItemAffectedSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the aggregate information of the pass rate at the asset level, the first level in the "asset + check item" two-level structure.
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceScanFailedAssetListRequest"/></param>
        /// <returns><see cref="DescribeComplianceScanFailedAssetListResponse"/></returns>
        public Task<DescribeComplianceScanFailedAssetListResponse> DescribeComplianceScanFailedAssetList(DescribeComplianceScanFailedAssetListRequest req)
        {
            return InternalRequestAsync<DescribeComplianceScanFailedAssetListResponse>(req, "DescribeComplianceScanFailedAssetList");
        }

        /// <summary>
        /// This API is used to query the aggregate information of the pass rate at the asset level, the first level in the "asset + check item" two-level structure.
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceScanFailedAssetListRequest"/></param>
        /// <returns><see cref="DescribeComplianceScanFailedAssetListResponse"/></returns>
        public DescribeComplianceScanFailedAssetListResponse DescribeComplianceScanFailedAssetListSync(DescribeComplianceScanFailedAssetListRequest req)
        {
            return InternalRequestAsync<DescribeComplianceScanFailedAssetListResponse>(req, "DescribeComplianceScanFailedAssetList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the aggregated information of the asset pass rate in the last task.
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceTaskAssetSummaryRequest"/></param>
        /// <returns><see cref="DescribeComplianceTaskAssetSummaryResponse"/></returns>
        public Task<DescribeComplianceTaskAssetSummaryResponse> DescribeComplianceTaskAssetSummary(DescribeComplianceTaskAssetSummaryRequest req)
        {
            return InternalRequestAsync<DescribeComplianceTaskAssetSummaryResponse>(req, "DescribeComplianceTaskAssetSummary");
        }

        /// <summary>
        /// This API is used to query the aggregated information of the asset pass rate in the last task.
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceTaskAssetSummaryRequest"/></param>
        /// <returns><see cref="DescribeComplianceTaskAssetSummaryResponse"/></returns>
        public DescribeComplianceTaskAssetSummaryResponse DescribeComplianceTaskAssetSummarySync(DescribeComplianceTaskAssetSummaryRequest req)
        {
            return InternalRequestAsync<DescribeComplianceTaskAssetSummaryResponse>(req, "DescribeComplianceTaskAssetSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of aggregated information of check items identified in the last task in line with the "check item + asset" two-level structure.
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceTaskPolicyItemSummaryListRequest"/></param>
        /// <returns><see cref="DescribeComplianceTaskPolicyItemSummaryListResponse"/></returns>
        public Task<DescribeComplianceTaskPolicyItemSummaryListResponse> DescribeComplianceTaskPolicyItemSummaryList(DescribeComplianceTaskPolicyItemSummaryListRequest req)
        {
            return InternalRequestAsync<DescribeComplianceTaskPolicyItemSummaryListResponse>(req, "DescribeComplianceTaskPolicyItemSummaryList");
        }

        /// <summary>
        /// This API is used to query the list of aggregated information of check items identified in the last task in line with the "check item + asset" two-level structure.
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceTaskPolicyItemSummaryListRequest"/></param>
        /// <returns><see cref="DescribeComplianceTaskPolicyItemSummaryListResponse"/></returns>
        public DescribeComplianceTaskPolicyItemSummaryListResponse DescribeComplianceTaskPolicyItemSummaryListSync(DescribeComplianceTaskPolicyItemSummaryListRequest req)
        {
            return InternalRequestAsync<DescribeComplianceTaskPolicyItemSummaryListResponse>(req, "DescribeComplianceTaskPolicyItemSummaryList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the allowlist.
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceWhitelistItemListRequest"/></param>
        /// <returns><see cref="DescribeComplianceWhitelistItemListResponse"/></returns>
        public Task<DescribeComplianceWhitelistItemListResponse> DescribeComplianceWhitelistItemList(DescribeComplianceWhitelistItemListRequest req)
        {
            return InternalRequestAsync<DescribeComplianceWhitelistItemListResponse>(req, "DescribeComplianceWhitelistItemList");
        }

        /// <summary>
        /// This API is used to query the allowlist.
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceWhitelistItemListRequest"/></param>
        /// <returns><see cref="DescribeComplianceWhitelistItemListResponse"/></returns>
        public DescribeComplianceWhitelistItemListResponse DescribeComplianceWhitelistItemListSync(DescribeComplianceWhitelistItemListRequest req)
        {
            return InternalRequestAsync<DescribeComplianceWhitelistItemListResponse>(req, "DescribeComplianceWhitelistItemList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the asset overview.
        /// </summary>
        /// <param name="req"><see cref="DescribeContainerAssetSummaryRequest"/></param>
        /// <returns><see cref="DescribeContainerAssetSummaryResponse"/></returns>
        public Task<DescribeContainerAssetSummaryResponse> DescribeContainerAssetSummary(DescribeContainerAssetSummaryRequest req)
        {
            return InternalRequestAsync<DescribeContainerAssetSummaryResponse>(req, "DescribeContainerAssetSummary");
        }

        /// <summary>
        /// This API is used to query the asset overview.
        /// </summary>
        /// <param name="req"><see cref="DescribeContainerAssetSummaryRequest"/></param>
        /// <returns><see cref="DescribeContainerAssetSummaryResponse"/></returns>
        public DescribeContainerAssetSummaryResponse DescribeContainerAssetSummarySync(DescribeContainerAssetSummaryRequest req)
        {
            return InternalRequestAsync<DescribeContainerAssetSummaryResponse>(req, "DescribeContainerAssetSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the overview of pending events.
        /// </summary>
        /// <param name="req"><see cref="DescribeContainerSecEventSummaryRequest"/></param>
        /// <returns><see cref="DescribeContainerSecEventSummaryResponse"/></returns>
        public Task<DescribeContainerSecEventSummaryResponse> DescribeContainerSecEventSummary(DescribeContainerSecEventSummaryRequest req)
        {
            return InternalRequestAsync<DescribeContainerSecEventSummaryResponse>(req, "DescribeContainerSecEventSummary");
        }

        /// <summary>
        /// This API is used to query the overview of pending events.
        /// </summary>
        /// <param name="req"><see cref="DescribeContainerSecEventSummaryRequest"/></param>
        /// <returns><see cref="DescribeContainerSecEventSummaryResponse"/></returns>
        public DescribeContainerSecEventSummaryResponse DescribeContainerSecEventSummarySync(DescribeContainerSecEventSummaryRequest req)
        {
            return InternalRequestAsync<DescribeContainerSecEventSummaryResponse>(req, "DescribeContainerSecEventSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the aggregation result of the ES field.
        /// </summary>
        /// <param name="req"><see cref="DescribeESAggregationsRequest"/></param>
        /// <returns><see cref="DescribeESAggregationsResponse"/></returns>
        public Task<DescribeESAggregationsResponse> DescribeESAggregations(DescribeESAggregationsRequest req)
        {
            return InternalRequestAsync<DescribeESAggregationsResponse>(req, "DescribeESAggregations");
        }

        /// <summary>
        /// This API is used to get the aggregation result of the ES field.
        /// </summary>
        /// <param name="req"><see cref="DescribeESAggregationsRequest"/></param>
        /// <returns><see cref="DescribeESAggregationsResponse"/></returns>
        public DescribeESAggregationsResponse DescribeESAggregationsSync(DescribeESAggregationsRequest req)
        {
            return InternalRequestAsync<DescribeESAggregationsResponse>(req, "DescribeESAggregations")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of ES query files.
        /// </summary>
        /// <param name="req"><see cref="DescribeESHitsRequest"/></param>
        /// <returns><see cref="DescribeESHitsResponse"/></returns>
        public Task<DescribeESHitsResponse> DescribeESHits(DescribeESHitsRequest req)
        {
            return InternalRequestAsync<DescribeESHitsResponse>(req, "DescribeESHits");
        }

        /// <summary>
        /// This API is used to get the list of ES query files.
        /// </summary>
        /// <param name="req"><see cref="DescribeESHitsRequest"/></param>
        /// <returns><see cref="DescribeESHitsResponse"/></returns>
        public DescribeESHitsResponse DescribeESHitsSync(DescribeESHitsRequest req)
        {
            return InternalRequestAsync<DescribeESHitsResponse>(req, "DescribeESHits")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of emergency vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="DescribeEmergencyVulListRequest"/></param>
        /// <returns><see cref="DescribeEmergencyVulListResponse"/></returns>
        public Task<DescribeEmergencyVulListResponse> DescribeEmergencyVulList(DescribeEmergencyVulListRequest req)
        {
            return InternalRequestAsync<DescribeEmergencyVulListResponse>(req, "DescribeEmergencyVulList");
        }

        /// <summary>
        /// This API is used to query the list of emergency vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="DescribeEmergencyVulListRequest"/></param>
        /// <returns><see cref="DescribeEmergencyVulListResponse"/></returns>
        public DescribeEmergencyVulListResponse DescribeEmergencyVulListSync(DescribeEmergencyVulListRequest req)
        {
            return InternalRequestAsync<DescribeEmergencyVulListResponse>(req, "DescribeEmergencyVulList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of a container escape event.
        /// </summary>
        /// <param name="req"><see cref="DescribeEscapeEventDetailRequest"/></param>
        /// <returns><see cref="DescribeEscapeEventDetailResponse"/></returns>
        public Task<DescribeEscapeEventDetailResponse> DescribeEscapeEventDetail(DescribeEscapeEventDetailRequest req)
        {
            return InternalRequestAsync<DescribeEscapeEventDetailResponse>(req, "DescribeEscapeEventDetail");
        }

        /// <summary>
        /// This API is used to query the details of a container escape event.
        /// </summary>
        /// <param name="req"><see cref="DescribeEscapeEventDetailRequest"/></param>
        /// <returns><see cref="DescribeEscapeEventDetailResponse"/></returns>
        public DescribeEscapeEventDetailResponse DescribeEscapeEventDetailSync(DescribeEscapeEventDetailRequest req)
        {
            return InternalRequestAsync<DescribeEscapeEventDetailResponse>(req, "DescribeEscapeEventDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of container escape events.
        /// </summary>
        /// <param name="req"><see cref="DescribeEscapeEventInfoRequest"/></param>
        /// <returns><see cref="DescribeEscapeEventInfoResponse"/></returns>
        public Task<DescribeEscapeEventInfoResponse> DescribeEscapeEventInfo(DescribeEscapeEventInfoRequest req)
        {
            return InternalRequestAsync<DescribeEscapeEventInfoResponse>(req, "DescribeEscapeEventInfo");
        }

        /// <summary>
        /// This API is used to query the list of container escape events.
        /// </summary>
        /// <param name="req"><see cref="DescribeEscapeEventInfoRequest"/></param>
        /// <returns><see cref="DescribeEscapeEventInfoResponse"/></returns>
        public DescribeEscapeEventInfoResponse DescribeEscapeEventInfoSync(DescribeEscapeEventInfoRequest req)
        {
            return InternalRequestAsync<DescribeEscapeEventInfoResponse>(req, "DescribeEscapeEventInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the trend of pending escape events.
        /// </summary>
        /// <param name="req"><see cref="DescribeEscapeEventTendencyRequest"/></param>
        /// <returns><see cref="DescribeEscapeEventTendencyResponse"/></returns>
        public Task<DescribeEscapeEventTendencyResponse> DescribeEscapeEventTendency(DescribeEscapeEventTendencyRequest req)
        {
            return InternalRequestAsync<DescribeEscapeEventTendencyResponse>(req, "DescribeEscapeEventTendency");
        }

        /// <summary>
        /// This API is used to query the trend of pending escape events.
        /// </summary>
        /// <param name="req"><see cref="DescribeEscapeEventTendencyRequest"/></param>
        /// <returns><see cref="DescribeEscapeEventTendencyResponse"/></returns>
        public DescribeEscapeEventTendencyResponse DescribeEscapeEventTendencySync(DescribeEscapeEventTendencyRequest req)
        {
            return InternalRequestAsync<DescribeEscapeEventTendencyResponse>(req, "DescribeEscapeEventTendency")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the types of container escape events and the number of pending events.
        /// </summary>
        /// <param name="req"><see cref="DescribeEscapeEventTypeSummaryRequest"/></param>
        /// <returns><see cref="DescribeEscapeEventTypeSummaryResponse"/></returns>
        public Task<DescribeEscapeEventTypeSummaryResponse> DescribeEscapeEventTypeSummary(DescribeEscapeEventTypeSummaryRequest req)
        {
            return InternalRequestAsync<DescribeEscapeEventTypeSummaryResponse>(req, "DescribeEscapeEventTypeSummary");
        }

        /// <summary>
        /// This API is used to query the types of container escape events and the number of pending events.
        /// </summary>
        /// <param name="req"><see cref="DescribeEscapeEventTypeSummaryRequest"/></param>
        /// <returns><see cref="DescribeEscapeEventTypeSummaryResponse"/></returns>
        public DescribeEscapeEventTypeSummaryResponse DescribeEscapeEventTypeSummarySync(DescribeEscapeEventTypeSummaryRequest req)
        {
            return InternalRequestAsync<DescribeEscapeEventTypeSummaryResponse>(req, "DescribeEscapeEventTypeSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the list of container escape events.
        /// </summary>
        /// <param name="req"><see cref="DescribeEscapeEventsExportRequest"/></param>
        /// <returns><see cref="DescribeEscapeEventsExportResponse"/></returns>
        public Task<DescribeEscapeEventsExportResponse> DescribeEscapeEventsExport(DescribeEscapeEventsExportRequest req)
        {
            return InternalRequestAsync<DescribeEscapeEventsExportResponse>(req, "DescribeEscapeEventsExport");
        }

        /// <summary>
        /// This API is used to export the list of container escape events.
        /// </summary>
        /// <param name="req"><see cref="DescribeEscapeEventsExportRequest"/></param>
        /// <returns><see cref="DescribeEscapeEventsExportResponse"/></returns>
        public DescribeEscapeEventsExportResponse DescribeEscapeEventsExportSync(DescribeEscapeEventsExportRequest req)
        {
            return InternalRequestAsync<DescribeEscapeEventsExportResponse>(req, "DescribeEscapeEventsExport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of a container escape scan rule.
        /// </summary>
        /// <param name="req"><see cref="DescribeEscapeRuleInfoRequest"/></param>
        /// <returns><see cref="DescribeEscapeRuleInfoResponse"/></returns>
        public Task<DescribeEscapeRuleInfoResponse> DescribeEscapeRuleInfo(DescribeEscapeRuleInfoRequest req)
        {
            return InternalRequestAsync<DescribeEscapeRuleInfoResponse>(req, "DescribeEscapeRuleInfo");
        }

        /// <summary>
        /// This API is used to query the information of a container escape scan rule.
        /// </summary>
        /// <param name="req"><see cref="DescribeEscapeRuleInfoRequest"/></param>
        /// <returns><see cref="DescribeEscapeRuleInfoResponse"/></returns>
        public DescribeEscapeRuleInfoResponse DescribeEscapeRuleInfoSync(DescribeEscapeRuleInfoRequest req)
        {
            return InternalRequestAsync<DescribeEscapeRuleInfoResponse>(req, "DescribeEscapeRuleInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the container escape security status.
        /// </summary>
        /// <param name="req"><see cref="DescribeEscapeSafeStateRequest"/></param>
        /// <returns><see cref="DescribeEscapeSafeStateResponse"/></returns>
        public Task<DescribeEscapeSafeStateResponse> DescribeEscapeSafeState(DescribeEscapeSafeStateRequest req)
        {
            return InternalRequestAsync<DescribeEscapeSafeStateResponse>(req, "DescribeEscapeSafeState");
        }

        /// <summary>
        /// This API is used to query the container escape security status.
        /// </summary>
        /// <param name="req"><see cref="DescribeEscapeSafeStateRequest"/></param>
        /// <returns><see cref="DescribeEscapeSafeStateResponse"/></returns>
        public DescribeEscapeSafeStateResponse DescribeEscapeSafeStateSync(DescribeEscapeSafeStateRequest req)
        {
            return InternalRequestAsync<DescribeEscapeSafeStateResponse>(req, "DescribeEscapeSafeState")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the allowlist of escapes.
        /// </summary>
        /// <param name="req"><see cref="DescribeEscapeWhiteListRequest"/></param>
        /// <returns><see cref="DescribeEscapeWhiteListResponse"/></returns>
        public Task<DescribeEscapeWhiteListResponse> DescribeEscapeWhiteList(DescribeEscapeWhiteListRequest req)
        {
            return InternalRequestAsync<DescribeEscapeWhiteListResponse>(req, "DescribeEscapeWhiteList");
        }

        /// <summary>
        /// This API is used to query the allowlist of escapes.
        /// </summary>
        /// <param name="req"><see cref="DescribeEscapeWhiteListRequest"/></param>
        /// <returns><see cref="DescribeEscapeWhiteListResponse"/></returns>
        public DescribeEscapeWhiteListResponse DescribeEscapeWhiteListSync(DescribeEscapeWhiteListRequest req)
        {
            return InternalRequestAsync<DescribeEscapeWhiteListResponse>(req, "DescribeEscapeWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the URL to download the result of an exportation task.
        /// </summary>
        /// <param name="req"><see cref="DescribeExportJobDownloadURLRequest"/></param>
        /// <returns><see cref="DescribeExportJobDownloadURLResponse"/></returns>
        public Task<DescribeExportJobDownloadURLResponse> DescribeExportJobDownloadURL(DescribeExportJobDownloadURLRequest req)
        {
            return InternalRequestAsync<DescribeExportJobDownloadURLResponse>(req, "DescribeExportJobDownloadURL");
        }

        /// <summary>
        /// This API is used to query the URL to download the result of an exportation task.
        /// </summary>
        /// <param name="req"><see cref="DescribeExportJobDownloadURLRequest"/></param>
        /// <returns><see cref="DescribeExportJobDownloadURLResponse"/></returns>
        public DescribeExportJobDownloadURLResponse DescribeExportJobDownloadURLSync(DescribeExportJobDownloadURLRequest req)
        {
            return InternalRequestAsync<DescribeExportJobDownloadURLResponse>(req, "DescribeExportJobDownloadURL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the export job management list.
        /// </summary>
        /// <param name="req"><see cref="DescribeExportJobManageListRequest"/></param>
        /// <returns><see cref="DescribeExportJobManageListResponse"/></returns>
        public Task<DescribeExportJobManageListResponse> DescribeExportJobManageList(DescribeExportJobManageListRequest req)
        {
            return InternalRequestAsync<DescribeExportJobManageListResponse>(req, "DescribeExportJobManageList");
        }

        /// <summary>
        /// This API is used to query the export job management list.
        /// </summary>
        /// <param name="req"><see cref="DescribeExportJobManageListRequest"/></param>
        /// <returns><see cref="DescribeExportJobManageListResponse"/></returns>
        public DescribeExportJobManageListResponse DescribeExportJobManageListSync(DescribeExportJobManageListRequest req)
        {
            return InternalRequestAsync<DescribeExportJobManageListResponse>(req, "DescribeExportJobManageList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the result of an export task.
        /// </summary>
        /// <param name="req"><see cref="DescribeExportJobResultRequest"/></param>
        /// <returns><see cref="DescribeExportJobResultResponse"/></returns>
        public Task<DescribeExportJobResultResponse> DescribeExportJobResult(DescribeExportJobResultRequest req)
        {
            return InternalRequestAsync<DescribeExportJobResultResponse>(req, "DescribeExportJobResult");
        }

        /// <summary>
        /// This API is used to query the result of an export task.
        /// </summary>
        /// <param name="req"><see cref="DescribeExportJobResultRequest"/></param>
        /// <returns><see cref="DescribeExportJobResultResponse"/></returns>
        public DescribeExportJobResultResponse DescribeExportJobResultSync(DescribeExportJobResultRequest req)
        {
            return InternalRequestAsync<DescribeExportJobResultResponse>(req, "DescribeExportJobResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the image licensing information.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageAuthorizedInfoRequest"/></param>
        /// <returns><see cref="DescribeImageAuthorizedInfoResponse"/></returns>
        public Task<DescribeImageAuthorizedInfoResponse> DescribeImageAuthorizedInfo(DescribeImageAuthorizedInfoRequest req)
        {
            return InternalRequestAsync<DescribeImageAuthorizedInfoResponse>(req, "DescribeImageAuthorizedInfo");
        }

        /// <summary>
        /// This API is used to query the image licensing information.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageAuthorizedInfoRequest"/></param>
        /// <returns><see cref="DescribeImageAuthorizedInfoResponse"/></returns>
        public DescribeImageAuthorizedInfoResponse DescribeImageAuthorizedInfoSync(DescribeImageAuthorizedInfoRequest req)
        {
            return InternalRequestAsync<DescribeImageAuthorizedInfoResponse>(req, "DescribeImageAuthorizedInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of automatic image licensing results.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageAutoAuthorizedLogListRequest"/></param>
        /// <returns><see cref="DescribeImageAutoAuthorizedLogListResponse"/></returns>
        public Task<DescribeImageAutoAuthorizedLogListResponse> DescribeImageAutoAuthorizedLogList(DescribeImageAutoAuthorizedLogListRequest req)
        {
            return InternalRequestAsync<DescribeImageAutoAuthorizedLogListResponse>(req, "DescribeImageAutoAuthorizedLogList");
        }

        /// <summary>
        /// This API is used to query the list of automatic image licensing results.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageAutoAuthorizedLogListRequest"/></param>
        /// <returns><see cref="DescribeImageAutoAuthorizedLogListResponse"/></returns>
        public DescribeImageAutoAuthorizedLogListResponse DescribeImageAutoAuthorizedLogListSync(DescribeImageAutoAuthorizedLogListRequest req)
        {
            return InternalRequestAsync<DescribeImageAutoAuthorizedLogListResponse>(req, "DescribeImageAutoAuthorizedLogList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query an automatic licensing rule for local images.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageAutoAuthorizedRuleRequest"/></param>
        /// <returns><see cref="DescribeImageAutoAuthorizedRuleResponse"/></returns>
        public Task<DescribeImageAutoAuthorizedRuleResponse> DescribeImageAutoAuthorizedRule(DescribeImageAutoAuthorizedRuleRequest req)
        {
            return InternalRequestAsync<DescribeImageAutoAuthorizedRuleResponse>(req, "DescribeImageAutoAuthorizedRule");
        }

        /// <summary>
        /// This API is used to query an automatic licensing rule for local images.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageAutoAuthorizedRuleRequest"/></param>
        /// <returns><see cref="DescribeImageAutoAuthorizedRuleResponse"/></returns>
        public DescribeImageAutoAuthorizedRuleResponse DescribeImageAutoAuthorizedRuleSync(DescribeImageAutoAuthorizedRuleRequest req)
        {
            return InternalRequestAsync<DescribeImageAutoAuthorizedRuleResponse>(req, "DescribeImageAutoAuthorizedRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of automatic image licensing tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageAutoAuthorizedTaskListRequest"/></param>
        /// <returns><see cref="DescribeImageAutoAuthorizedTaskListResponse"/></returns>
        public Task<DescribeImageAutoAuthorizedTaskListResponse> DescribeImageAutoAuthorizedTaskList(DescribeImageAutoAuthorizedTaskListRequest req)
        {
            return InternalRequestAsync<DescribeImageAutoAuthorizedTaskListResponse>(req, "DescribeImageAutoAuthorizedTaskList");
        }

        /// <summary>
        /// This API is used to query the list of automatic image licensing tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageAutoAuthorizedTaskListRequest"/></param>
        /// <returns><see cref="DescribeImageAutoAuthorizedTaskListResponse"/></returns>
        public DescribeImageAutoAuthorizedTaskListResponse DescribeImageAutoAuthorizedTaskListSync(DescribeImageAutoAuthorizedTaskListRequest req)
        {
            return InternalRequestAsync<DescribeImageAutoAuthorizedTaskListResponse>(req, "DescribeImageAutoAuthorizedTaskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of components in an local image.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageComponentListRequest"/></param>
        /// <returns><see cref="DescribeImageComponentListResponse"/></returns>
        public Task<DescribeImageComponentListResponse> DescribeImageComponentList(DescribeImageComponentListRequest req)
        {
            return InternalRequestAsync<DescribeImageComponentListResponse>(req, "DescribeImageComponentList");
        }

        /// <summary>
        /// This API is used to query the list of components in an local image.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageComponentListRequest"/></param>
        /// <returns><see cref="DescribeImageComponentListResponse"/></returns>
        public DescribeImageComponentListResponse DescribeImageComponentListSync(DescribeImageComponentListRequest req)
        {
            return InternalRequestAsync<DescribeImageComponentListResponse>(req, "DescribeImageComponentList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of namespaces for an image repository.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRegistryNamespaceListRequest"/></param>
        /// <returns><see cref="DescribeImageRegistryNamespaceListResponse"/></returns>
        public Task<DescribeImageRegistryNamespaceListResponse> DescribeImageRegistryNamespaceList(DescribeImageRegistryNamespaceListRequest req)
        {
            return InternalRequestAsync<DescribeImageRegistryNamespaceListResponse>(req, "DescribeImageRegistryNamespaceList");
        }

        /// <summary>
        /// This API is used to query the list of namespaces for an image repository.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRegistryNamespaceListRequest"/></param>
        /// <returns><see cref="DescribeImageRegistryNamespaceListResponse"/></returns>
        public DescribeImageRegistryNamespaceListResponse DescribeImageRegistryNamespaceListSync(DescribeImageRegistryNamespaceListRequest req)
        {
            return InternalRequestAsync<DescribeImageRegistryNamespaceListResponse>(req, "DescribeImageRegistryNamespaceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to view a scheduled task of an image repository.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRegistryTimingScanTaskRequest"/></param>
        /// <returns><see cref="DescribeImageRegistryTimingScanTaskResponse"/></returns>
        public Task<DescribeImageRegistryTimingScanTaskResponse> DescribeImageRegistryTimingScanTask(DescribeImageRegistryTimingScanTaskRequest req)
        {
            return InternalRequestAsync<DescribeImageRegistryTimingScanTaskResponse>(req, "DescribeImageRegistryTimingScanTask");
        }

        /// <summary>
        /// This API is used to view a scheduled task of an image repository.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRegistryTimingScanTaskRequest"/></param>
        /// <returns><see cref="DescribeImageRegistryTimingScanTaskResponse"/></returns>
        public DescribeImageRegistryTimingScanTaskResponse DescribeImageRegistryTimingScanTaskSync(DescribeImageRegistryTimingScanTaskRequest req)
        {
            return InternalRequestAsync<DescribeImageRegistryTimingScanTaskResponse>(req, "DescribeImageRegistryTimingScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the overview of local image risks.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRiskSummaryRequest"/></param>
        /// <returns><see cref="DescribeImageRiskSummaryResponse"/></returns>
        public Task<DescribeImageRiskSummaryResponse> DescribeImageRiskSummary(DescribeImageRiskSummaryRequest req)
        {
            return InternalRequestAsync<DescribeImageRiskSummaryResponse>(req, "DescribeImageRiskSummary");
        }

        /// <summary>
        /// This API is used to query the overview of local image risks.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRiskSummaryRequest"/></param>
        /// <returns><see cref="DescribeImageRiskSummaryResponse"/></returns>
        public DescribeImageRiskSummaryResponse DescribeImageRiskSummarySync(DescribeImageRiskSummaryRequest req)
        {
            return InternalRequestAsync<DescribeImageRiskSummaryResponse>(req, "DescribeImageRiskSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the trend of local image risks.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRiskTendencyRequest"/></param>
        /// <returns><see cref="DescribeImageRiskTendencyResponse"/></returns>
        public Task<DescribeImageRiskTendencyResponse> DescribeImageRiskTendency(DescribeImageRiskTendencyRequest req)
        {
            return InternalRequestAsync<DescribeImageRiskTendencyResponse>(req, "DescribeImageRiskTendency");
        }

        /// <summary>
        /// This API is used to query the trend of local image risks.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRiskTendencyRequest"/></param>
        /// <returns><see cref="DescribeImageRiskTendencyResponse"/></returns>
        public DescribeImageRiskTendencyResponse DescribeImageRiskTendencySync(DescribeImageRiskTendencyRequest req)
        {
            return InternalRequestAsync<DescribeImageRiskTendencyResponse>(req, "DescribeImageRiskTendency")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of all images.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageSimpleListRequest"/></param>
        /// <returns><see cref="DescribeImageSimpleListResponse"/></returns>
        public Task<DescribeImageSimpleListResponse> DescribeImageSimpleList(DescribeImageSimpleListRequest req)
        {
            return InternalRequestAsync<DescribeImageSimpleListResponse>(req, "DescribeImageSimpleList");
        }

        /// <summary>
        /// This API is used to query the list of all images.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageSimpleListRequest"/></param>
        /// <returns><see cref="DescribeImageSimpleListResponse"/></returns>
        public DescribeImageSimpleListResponse DescribeImageSimpleListSync(DescribeImageSimpleListRequest req)
        {
            return InternalRequestAsync<DescribeImageSimpleListResponse>(req, "DescribeImageSimpleList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the index list.
        /// </summary>
        /// <param name="req"><see cref="DescribeIndexListRequest"/></param>
        /// <returns><see cref="DescribeIndexListResponse"/></returns>
        public Task<DescribeIndexListResponse> DescribeIndexList(DescribeIndexListRequest req)
        {
            return InternalRequestAsync<DescribeIndexListResponse>(req, "DescribeIndexList");
        }

        /// <summary>
        /// This API is used to get the index list.
        /// </summary>
        /// <param name="req"><see cref="DescribeIndexListRequest"/></param>
        /// <returns><see cref="DescribeIndexListResponse"/></returns>
        public DescribeIndexListResponse DescribeIndexListSync(DescribeIndexListRequest req)
        {
            return InternalRequestAsync<DescribeIndexListResponse>(req, "DescribeIndexList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query check reports.
        /// </summary>
        /// <param name="req"><see cref="DescribeInspectionReportRequest"/></param>
        /// <returns><see cref="DescribeInspectionReportResponse"/></returns>
        public Task<DescribeInspectionReportResponse> DescribeInspectionReport(DescribeInspectionReportRequest req)
        {
            return InternalRequestAsync<DescribeInspectionReportResponse>(req, "DescribeInspectionReport");
        }

        /// <summary>
        /// This API is used to query check reports.
        /// </summary>
        /// <param name="req"><see cref="DescribeInspectionReportRequest"/></param>
        /// <returns><see cref="DescribeInspectionReportResponse"/></returns>
        public DescribeInspectionReportResponse DescribeInspectionReportSync(DescribeInspectionReportRequest req)
        {
            return InternalRequestAsync<DescribeInspectionReportResponse>(req, "DescribeInspectionReport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Querying details of a K8s API exception event
        /// </summary>
        /// <param name="req"><see cref="DescribeK8sApiAbnormalEventInfoRequest"/></param>
        /// <returns><see cref="DescribeK8sApiAbnormalEventInfoResponse"/></returns>
        public Task<DescribeK8sApiAbnormalEventInfoResponse> DescribeK8sApiAbnormalEventInfo(DescribeK8sApiAbnormalEventInfoRequest req)
        {
            return InternalRequestAsync<DescribeK8sApiAbnormalEventInfoResponse>(req, "DescribeK8sApiAbnormalEventInfo");
        }

        /// <summary>
        /// Querying details of a K8s API exception event
        /// </summary>
        /// <param name="req"><see cref="DescribeK8sApiAbnormalEventInfoRequest"/></param>
        /// <returns><see cref="DescribeK8sApiAbnormalEventInfoResponse"/></returns>
        public DescribeK8sApiAbnormalEventInfoResponse DescribeK8sApiAbnormalEventInfoSync(DescribeK8sApiAbnormalEventInfoRequest req)
        {
            return InternalRequestAsync<DescribeK8sApiAbnormalEventInfoResponse>(req, "DescribeK8sApiAbnormalEventInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the K8sApi abnormal event list.
        /// </summary>
        /// <param name="req"><see cref="DescribeK8sApiAbnormalEventListRequest"/></param>
        /// <returns><see cref="DescribeK8sApiAbnormalEventListResponse"/></returns>
        public Task<DescribeK8sApiAbnormalEventListResponse> DescribeK8sApiAbnormalEventList(DescribeK8sApiAbnormalEventListRequest req)
        {
            return InternalRequestAsync<DescribeK8sApiAbnormalEventListResponse>(req, "DescribeK8sApiAbnormalEventList");
        }

        /// <summary>
        /// This API is used to query the K8sApi abnormal event list.
        /// </summary>
        /// <param name="req"><see cref="DescribeK8sApiAbnormalEventListRequest"/></param>
        /// <returns><see cref="DescribeK8sApiAbnormalEventListResponse"/></returns>
        public DescribeK8sApiAbnormalEventListResponse DescribeK8sApiAbnormalEventListSync(DescribeK8sApiAbnormalEventListRequest req)
        {
            return InternalRequestAsync<DescribeK8sApiAbnormalEventListResponse>(req, "DescribeK8sApiAbnormalEventList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query K8sApi abnormal request rule details.
        /// </summary>
        /// <param name="req"><see cref="DescribeK8sApiAbnormalRuleInfoRequest"/></param>
        /// <returns><see cref="DescribeK8sApiAbnormalRuleInfoResponse"/></returns>
        public Task<DescribeK8sApiAbnormalRuleInfoResponse> DescribeK8sApiAbnormalRuleInfo(DescribeK8sApiAbnormalRuleInfoRequest req)
        {
            return InternalRequestAsync<DescribeK8sApiAbnormalRuleInfoResponse>(req, "DescribeK8sApiAbnormalRuleInfo");
        }

        /// <summary>
        /// This API is used to query K8sApi abnormal request rule details.
        /// </summary>
        /// <param name="req"><see cref="DescribeK8sApiAbnormalRuleInfoRequest"/></param>
        /// <returns><see cref="DescribeK8sApiAbnormalRuleInfoResponse"/></returns>
        public DescribeK8sApiAbnormalRuleInfoResponse DescribeK8sApiAbnormalRuleInfoSync(DescribeK8sApiAbnormalRuleInfoRequest req)
        {
            return InternalRequestAsync<DescribeK8sApiAbnormalRuleInfoResponse>(req, "DescribeK8sApiAbnormalRuleInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to the K8sApi abnormal request rule list.
        /// </summary>
        /// <param name="req"><see cref="DescribeK8sApiAbnormalRuleListRequest"/></param>
        /// <returns><see cref="DescribeK8sApiAbnormalRuleListResponse"/></returns>
        public Task<DescribeK8sApiAbnormalRuleListResponse> DescribeK8sApiAbnormalRuleList(DescribeK8sApiAbnormalRuleListRequest req)
        {
            return InternalRequestAsync<DescribeK8sApiAbnormalRuleListResponse>(req, "DescribeK8sApiAbnormalRuleList");
        }

        /// <summary>
        /// This API is used to the K8sApi abnormal request rule list.
        /// </summary>
        /// <param name="req"><see cref="DescribeK8sApiAbnormalRuleListRequest"/></param>
        /// <returns><see cref="DescribeK8sApiAbnormalRuleListResponse"/></returns>
        public DescribeK8sApiAbnormalRuleListResponse DescribeK8sApiAbnormalRuleListSync(DescribeK8sApiAbnormalRuleListRequest req)
        {
            return InternalRequestAsync<DescribeK8sApiAbnormalRuleListResponse>(req, "DescribeK8sApiAbnormalRuleList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query rules for K8s API exceptions. 
        /// </summary>
        /// <param name="req"><see cref="DescribeK8sApiAbnormalRuleScopeListRequest"/></param>
        /// <returns><see cref="DescribeK8sApiAbnormalRuleScopeListResponse"/></returns>
        public Task<DescribeK8sApiAbnormalRuleScopeListResponse> DescribeK8sApiAbnormalRuleScopeList(DescribeK8sApiAbnormalRuleScopeListRequest req)
        {
            return InternalRequestAsync<DescribeK8sApiAbnormalRuleScopeListResponse>(req, "DescribeK8sApiAbnormalRuleScopeList");
        }

        /// <summary>
        /// This API is used to query rules for K8s API exceptions. 
        /// </summary>
        /// <param name="req"><see cref="DescribeK8sApiAbnormalRuleScopeListRequest"/></param>
        /// <returns><see cref="DescribeK8sApiAbnormalRuleScopeListResponse"/></returns>
        public DescribeK8sApiAbnormalRuleScopeListResponse DescribeK8sApiAbnormalRuleScopeListSync(DescribeK8sApiAbnormalRuleScopeListRequest req)
        {
            return InternalRequestAsync<DescribeK8sApiAbnormalRuleScopeListResponse>(req, "DescribeK8sApiAbnormalRuleScopeList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the statistics of K8sApi abnormal events.
        /// </summary>
        /// <param name="req"><see cref="DescribeK8sApiAbnormalSummaryRequest"/></param>
        /// <returns><see cref="DescribeK8sApiAbnormalSummaryResponse"/></returns>
        public Task<DescribeK8sApiAbnormalSummaryResponse> DescribeK8sApiAbnormalSummary(DescribeK8sApiAbnormalSummaryRequest req)
        {
            return InternalRequestAsync<DescribeK8sApiAbnormalSummaryResponse>(req, "DescribeK8sApiAbnormalSummary");
        }

        /// <summary>
        /// This API is used to query the statistics of K8sApi abnormal events.
        /// </summary>
        /// <param name="req"><see cref="DescribeK8sApiAbnormalSummaryRequest"/></param>
        /// <returns><see cref="DescribeK8sApiAbnormalSummaryResponse"/></returns>
        public DescribeK8sApiAbnormalSummaryResponse DescribeK8sApiAbnormalSummarySync(DescribeK8sApiAbnormalSummaryRequest req)
        {
            return InternalRequestAsync<DescribeK8sApiAbnormalSummaryResponse>(req, "DescribeK8sApiAbnormalSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the trend of K8sApi abnormal events.
        /// </summary>
        /// <param name="req"><see cref="DescribeK8sApiAbnormalTendencyRequest"/></param>
        /// <returns><see cref="DescribeK8sApiAbnormalTendencyResponse"/></returns>
        public Task<DescribeK8sApiAbnormalTendencyResponse> DescribeK8sApiAbnormalTendency(DescribeK8sApiAbnormalTendencyRequest req)
        {
            return InternalRequestAsync<DescribeK8sApiAbnormalTendencyResponse>(req, "DescribeK8sApiAbnormalTendency");
        }

        /// <summary>
        /// This API is used to query the trend of K8sApi abnormal events.
        /// </summary>
        /// <param name="req"><see cref="DescribeK8sApiAbnormalTendencyRequest"/></param>
        /// <returns><see cref="DescribeK8sApiAbnormalTendencyResponse"/></returns>
        public DescribeK8sApiAbnormalTendencyResponse DescribeK8sApiAbnormalTendencySync(DescribeK8sApiAbnormalTendencyRequest req)
        {
            return InternalRequestAsync<DescribeK8sApiAbnormalTendencyResponse>(req, "DescribeK8sApiAbnormalTendency")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the statistics of the log search usage.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogStorageStatisticRequest"/></param>
        /// <returns><see cref="DescribeLogStorageStatisticResponse"/></returns>
        public Task<DescribeLogStorageStatisticResponse> DescribeLogStorageStatistic(DescribeLogStorageStatisticRequest req)
        {
            return InternalRequestAsync<DescribeLogStorageStatisticResponse>(req, "DescribeLogStorageStatistic");
        }

        /// <summary>
        /// This API is used to get the statistics of the log search usage.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogStorageStatisticRequest"/></param>
        /// <returns><see cref="DescribeLogStorageStatisticResponse"/></returns>
        public DescribeLogStorageStatisticResponse DescribeLogStorageStatisticSync(DescribeLogStorageStatisticRequest req)
        {
            return InternalRequestAsync<DescribeLogStorageStatisticResponse>(req, "DescribeLogStorageStatistic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of cluster policy audits.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkFirewallAuditRecordRequest"/></param>
        /// <returns><see cref="DescribeNetworkFirewallAuditRecordResponse"/></returns>
        public Task<DescribeNetworkFirewallAuditRecordResponse> DescribeNetworkFirewallAuditRecord(DescribeNetworkFirewallAuditRecordRequest req)
        {
            return InternalRequestAsync<DescribeNetworkFirewallAuditRecordResponse>(req, "DescribeNetworkFirewallAuditRecord");
        }

        /// <summary>
        /// This API is used to query the list of cluster policy audits.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkFirewallAuditRecordRequest"/></param>
        /// <returns><see cref="DescribeNetworkFirewallAuditRecordResponse"/></returns>
        public DescribeNetworkFirewallAuditRecordResponse DescribeNetworkFirewallAuditRecordSync(DescribeNetworkFirewallAuditRecordRequest req)
        {
            return InternalRequestAsync<DescribeNetworkFirewallAuditRecordResponse>(req, "DescribeNetworkFirewallAuditRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of clusters.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkFirewallClusterListRequest"/></param>
        /// <returns><see cref="DescribeNetworkFirewallClusterListResponse"/></returns>
        public Task<DescribeNetworkFirewallClusterListResponse> DescribeNetworkFirewallClusterList(DescribeNetworkFirewallClusterListRequest req)
        {
            return InternalRequestAsync<DescribeNetworkFirewallClusterListResponse>(req, "DescribeNetworkFirewallClusterList");
        }

        /// <summary>
        /// This API is used to query the list of clusters.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkFirewallClusterListRequest"/></param>
        /// <returns><see cref="DescribeNetworkFirewallClusterListResponse"/></returns>
        public DescribeNetworkFirewallClusterListResponse DescribeNetworkFirewallClusterListSync(DescribeNetworkFirewallClusterListRequest req)
        {
            return InternalRequestAsync<DescribeNetworkFirewallClusterListResponse>(req, "DescribeNetworkFirewallClusterList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the progress of the asset query task in the container network.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkFirewallClusterRefreshStatusRequest"/></param>
        /// <returns><see cref="DescribeNetworkFirewallClusterRefreshStatusResponse"/></returns>
        public Task<DescribeNetworkFirewallClusterRefreshStatusResponse> DescribeNetworkFirewallClusterRefreshStatus(DescribeNetworkFirewallClusterRefreshStatusRequest req)
        {
            return InternalRequestAsync<DescribeNetworkFirewallClusterRefreshStatusResponse>(req, "DescribeNetworkFirewallClusterRefreshStatus");
        }

        /// <summary>
        /// This API is used to query the progress of the asset query task in the container network.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkFirewallClusterRefreshStatusRequest"/></param>
        /// <returns><see cref="DescribeNetworkFirewallClusterRefreshStatusResponse"/></returns>
        public DescribeNetworkFirewallClusterRefreshStatusResponse DescribeNetworkFirewallClusterRefreshStatusSync(DescribeNetworkFirewallClusterRefreshStatusRequest req)
        {
            return InternalRequestAsync<DescribeNetworkFirewallClusterRefreshStatusResponse>(req, "DescribeNetworkFirewallClusterRefreshStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of cluster network namespace labels.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkFirewallNamespaceLabelListRequest"/></param>
        /// <returns><see cref="DescribeNetworkFirewallNamespaceLabelListResponse"/></returns>
        public Task<DescribeNetworkFirewallNamespaceLabelListResponse> DescribeNetworkFirewallNamespaceLabelList(DescribeNetworkFirewallNamespaceLabelListRequest req)
        {
            return InternalRequestAsync<DescribeNetworkFirewallNamespaceLabelListResponse>(req, "DescribeNetworkFirewallNamespaceLabelList");
        }

        /// <summary>
        /// This API is used to query the list of cluster network namespace labels.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkFirewallNamespaceLabelListRequest"/></param>
        /// <returns><see cref="DescribeNetworkFirewallNamespaceLabelListResponse"/></returns>
        public DescribeNetworkFirewallNamespaceLabelListResponse DescribeNetworkFirewallNamespaceLabelListSync(DescribeNetworkFirewallNamespaceLabelListRequest req)
        {
            return InternalRequestAsync<DescribeNetworkFirewallNamespaceLabelListResponse>(req, "DescribeNetworkFirewallNamespaceLabelList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query cluster network Pod labels.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkFirewallPodLabelsListRequest"/></param>
        /// <returns><see cref="DescribeNetworkFirewallPodLabelsListResponse"/></returns>
        public Task<DescribeNetworkFirewallPodLabelsListResponse> DescribeNetworkFirewallPodLabelsList(DescribeNetworkFirewallPodLabelsListRequest req)
        {
            return InternalRequestAsync<DescribeNetworkFirewallPodLabelsListResponse>(req, "DescribeNetworkFirewallPodLabelsList");
        }

        /// <summary>
        /// This API is used to query cluster network Pod labels.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkFirewallPodLabelsListRequest"/></param>
        /// <returns><see cref="DescribeNetworkFirewallPodLabelsListResponse"/></returns>
        public DescribeNetworkFirewallPodLabelsListResponse DescribeNetworkFirewallPodLabelsListSync(DescribeNetworkFirewallPodLabelsListRequest req)
        {
            return InternalRequestAsync<DescribeNetworkFirewallPodLabelsListResponse>(req, "DescribeNetworkFirewallPodLabelsList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to view the details of a policy in the container network cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkFirewallPolicyDetailRequest"/></param>
        /// <returns><see cref="DescribeNetworkFirewallPolicyDetailResponse"/></returns>
        public Task<DescribeNetworkFirewallPolicyDetailResponse> DescribeNetworkFirewallPolicyDetail(DescribeNetworkFirewallPolicyDetailRequest req)
        {
            return InternalRequestAsync<DescribeNetworkFirewallPolicyDetailResponse>(req, "DescribeNetworkFirewallPolicyDetail");
        }

        /// <summary>
        /// This API is used to view the details of a policy in the container network cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkFirewallPolicyDetailRequest"/></param>
        /// <returns><see cref="DescribeNetworkFirewallPolicyDetailResponse"/></returns>
        public DescribeNetworkFirewallPolicyDetailResponse DescribeNetworkFirewallPolicyDetailSync(DescribeNetworkFirewallPolicyDetailRequest req)
        {
            return InternalRequestAsync<DescribeNetworkFirewallPolicyDetailResponse>(req, "DescribeNetworkFirewallPolicyDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the progress of a network policy sync task in the container network.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkFirewallPolicyDiscoverRequest"/></param>
        /// <returns><see cref="DescribeNetworkFirewallPolicyDiscoverResponse"/></returns>
        public Task<DescribeNetworkFirewallPolicyDiscoverResponse> DescribeNetworkFirewallPolicyDiscover(DescribeNetworkFirewallPolicyDiscoverRequest req)
        {
            return InternalRequestAsync<DescribeNetworkFirewallPolicyDiscoverResponse>(req, "DescribeNetworkFirewallPolicyDiscover");
        }

        /// <summary>
        /// This API is used to query the progress of a network policy sync task in the container network.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkFirewallPolicyDiscoverRequest"/></param>
        /// <returns><see cref="DescribeNetworkFirewallPolicyDiscoverResponse"/></returns>
        public DescribeNetworkFirewallPolicyDiscoverResponse DescribeNetworkFirewallPolicyDiscoverSync(DescribeNetworkFirewallPolicyDiscoverRequest req)
        {
            return InternalRequestAsync<DescribeNetworkFirewallPolicyDiscoverResponse>(req, "DescribeNetworkFirewallPolicyDiscover")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of cluster network policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkFirewallPolicyListRequest"/></param>
        /// <returns><see cref="DescribeNetworkFirewallPolicyListResponse"/></returns>
        public Task<DescribeNetworkFirewallPolicyListResponse> DescribeNetworkFirewallPolicyList(DescribeNetworkFirewallPolicyListRequest req)
        {
            return InternalRequestAsync<DescribeNetworkFirewallPolicyListResponse>(req, "DescribeNetworkFirewallPolicyList");
        }

        /// <summary>
        /// This API is used to query the list of cluster network policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkFirewallPolicyListRequest"/></param>
        /// <returns><see cref="DescribeNetworkFirewallPolicyListResponse"/></returns>
        public DescribeNetworkFirewallPolicyListResponse DescribeNetworkFirewallPolicyListSync(DescribeNetworkFirewallPolicyListRequest req)
        {
            return InternalRequestAsync<DescribeNetworkFirewallPolicyListResponse>(req, "DescribeNetworkFirewallPolicyList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the execution status of a network policy in the container network.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkFirewallPolicyStatusRequest"/></param>
        /// <returns><see cref="DescribeNetworkFirewallPolicyStatusResponse"/></returns>
        public Task<DescribeNetworkFirewallPolicyStatusResponse> DescribeNetworkFirewallPolicyStatus(DescribeNetworkFirewallPolicyStatusRequest req)
        {
            return InternalRequestAsync<DescribeNetworkFirewallPolicyStatusResponse>(req, "DescribeNetworkFirewallPolicyStatus");
        }

        /// <summary>
        /// This API is used to query the execution status of a network policy in the container network.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkFirewallPolicyStatusRequest"/></param>
        /// <returns><see cref="DescribeNetworkFirewallPolicyStatusResponse"/></returns>
        public DescribeNetworkFirewallPolicyStatusResponse DescribeNetworkFirewallPolicyStatusSync(DescribeNetworkFirewallPolicyStatusRequest req)
        {
            return InternalRequestAsync<DescribeNetworkFirewallPolicyStatusResponse>(req, "DescribeNetworkFirewallPolicyStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to view the details of a YAML network policy in the container network cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkFirewallPolicyYamlDetailRequest"/></param>
        /// <returns><see cref="DescribeNetworkFirewallPolicyYamlDetailResponse"/></returns>
        public Task<DescribeNetworkFirewallPolicyYamlDetailResponse> DescribeNetworkFirewallPolicyYamlDetail(DescribeNetworkFirewallPolicyYamlDetailRequest req)
        {
            return InternalRequestAsync<DescribeNetworkFirewallPolicyYamlDetailResponse>(req, "DescribeNetworkFirewallPolicyYamlDetail");
        }

        /// <summary>
        /// This API is used to view the details of a YAML network policy in the container network cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkFirewallPolicyYamlDetailRequest"/></param>
        /// <returns><see cref="DescribeNetworkFirewallPolicyYamlDetailResponse"/></returns>
        public DescribeNetworkFirewallPolicyYamlDetailResponse DescribeNetworkFirewallPolicyYamlDetailSync(DescribeNetworkFirewallPolicyYamlDetailRequest req)
        {
            return InternalRequestAsync<DescribeNetworkFirewallPolicyYamlDetailResponse>(req, "DescribeNetworkFirewallPolicyYamlDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the latest list of vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="DescribeNewestVulRequest"/></param>
        /// <returns><see cref="DescribeNewestVulResponse"/></returns>
        public Task<DescribeNewestVulResponse> DescribeNewestVul(DescribeNewestVulRequest req)
        {
            return InternalRequestAsync<DescribeNewestVulResponse>(req, "DescribeNewestVul");
        }

        /// <summary>
        /// This API is used to query the latest list of vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="DescribeNewestVulRequest"/></param>
        /// <returns><see cref="DescribeNewestVulResponse"/></returns>
        public DescribeNewestVulResponse DescribeNewestVulSync(DescribeNewestVulRequest req)
        {
            return InternalRequestAsync<DescribeNewestVulResponse>(req, "DescribeNewestVul")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the pay-as-you-go billing details.
        /// </summary>
        /// <param name="req"><see cref="DescribePostPayDetailRequest"/></param>
        /// <returns><see cref="DescribePostPayDetailResponse"/></returns>
        public Task<DescribePostPayDetailResponse> DescribePostPayDetail(DescribePostPayDetailRequest req)
        {
            return InternalRequestAsync<DescribePostPayDetailResponse>(req, "DescribePostPayDetail");
        }

        /// <summary>
        /// This API is used to query the pay-as-you-go billing details.
        /// </summary>
        /// <param name="req"><see cref="DescribePostPayDetailRequest"/></param>
        /// <returns><see cref="DescribePostPayDetailResponse"/></returns>
        public DescribePostPayDetailResponse DescribePostPayDetailSync(DescribePostPayDetailRequest req)
        {
            return InternalRequestAsync<DescribePostPayDetailResponse>(req, "DescribePostPayDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to check whether the Pro Edition needs to be purchased.
        /// </summary>
        /// <param name="req"><see cref="DescribeProVersionInfoRequest"/></param>
        /// <returns><see cref="DescribeProVersionInfoResponse"/></returns>
        public Task<DescribeProVersionInfoResponse> DescribeProVersionInfo(DescribeProVersionInfoRequest req)
        {
            return InternalRequestAsync<DescribeProVersionInfoResponse>(req, "DescribeProVersionInfo");
        }

        /// <summary>
        /// This API is used to check whether the Pro Edition needs to be purchased.
        /// </summary>
        /// <param name="req"><see cref="DescribeProVersionInfoRequest"/></param>
        /// <returns><see cref="DescribeProVersionInfoResponse"/></returns>
        public DescribeProVersionInfoResponse DescribeProVersionInfoSync(DescribeProVersionInfoRequest req)
        {
            return InternalRequestAsync<DescribeProVersionInfoResponse>(req, "DescribeProVersionInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query promotions.
        /// </summary>
        /// <param name="req"><see cref="DescribePromotionActivityRequest"/></param>
        /// <returns><see cref="DescribePromotionActivityResponse"/></returns>
        public Task<DescribePromotionActivityResponse> DescribePromotionActivity(DescribePromotionActivityRequest req)
        {
            return InternalRequestAsync<DescribePromotionActivityResponse>(req, "DescribePromotionActivity");
        }

        /// <summary>
        /// This API is used to query promotions.
        /// </summary>
        /// <param name="req"><see cref="DescribePromotionActivityRequest"/></param>
        /// <returns><see cref="DescribePromotionActivityResponse"/></returns>
        public DescribePromotionActivityResponse DescribePromotionActivitySync(DescribePromotionActivityRequest req)
        {
            return InternalRequestAsync<DescribePromotionActivityResponse>(req, "DescribePromotionActivity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the public key.
        /// </summary>
        /// <param name="req"><see cref="DescribePublicKeyRequest"/></param>
        /// <returns><see cref="DescribePublicKeyResponse"/></returns>
        public Task<DescribePublicKeyResponse> DescribePublicKey(DescribePublicKeyRequest req)
        {
            return InternalRequestAsync<DescribePublicKeyResponse>(req, "DescribePublicKey");
        }

        /// <summary>
        /// This API is used to get the public key.
        /// </summary>
        /// <param name="req"><see cref="DescribePublicKeyRequest"/></param>
        /// <returns><see cref="DescribePublicKeyResponse"/></returns>
        public DescribePublicKeyResponse DescribePublicKeySync(DescribePublicKeyRequest req)
        {
            return InternalRequestAsync<DescribePublicKeyResponse>(req, "DescribePublicKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to check whether TCSS is purchased.
        /// </summary>
        /// <param name="req"><see cref="DescribePurchaseStateInfoRequest"/></param>
        /// <returns><see cref="DescribePurchaseStateInfoResponse"/></returns>
        public Task<DescribePurchaseStateInfoResponse> DescribePurchaseStateInfo(DescribePurchaseStateInfoRequest req)
        {
            return InternalRequestAsync<DescribePurchaseStateInfoResponse>(req, "DescribePurchaseStateInfo");
        }

        /// <summary>
        /// This API is used to check whether TCSS is purchased.
        /// </summary>
        /// <param name="req"><see cref="DescribePurchaseStateInfoRequest"/></param>
        /// <returns><see cref="DescribePurchaseStateInfoResponse"/></returns>
        public DescribePurchaseStateInfoResponse DescribePurchaseStateInfoSync(DescribePurchaseStateInfoRequest req)
        {
            return InternalRequestAsync<DescribePurchaseStateInfoResponse>(req, "DescribePurchaseStateInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query a refresh task.
        /// </summary>
        /// <param name="req"><see cref="DescribeRefreshTaskRequest"/></param>
        /// <returns><see cref="DescribeRefreshTaskResponse"/></returns>
        public Task<DescribeRefreshTaskResponse> DescribeRefreshTask(DescribeRefreshTaskRequest req)
        {
            return InternalRequestAsync<DescribeRefreshTaskResponse>(req, "DescribeRefreshTask");
        }

        /// <summary>
        /// This API is used to query a refresh task.
        /// </summary>
        /// <param name="req"><see cref="DescribeRefreshTaskRequest"/></param>
        /// <returns><see cref="DescribeRefreshTaskResponse"/></returns>
        public DescribeRefreshTaskResponse DescribeRefreshTaskSync(DescribeRefreshTaskRequest req)
        {
            return InternalRequestAsync<DescribeRefreshTaskResponse>(req, "DescribeRefreshTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of a reverse shell event at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeReverseShellDetailRequest"/></param>
        /// <returns><see cref="DescribeReverseShellDetailResponse"/></returns>
        public Task<DescribeReverseShellDetailResponse> DescribeReverseShellDetail(DescribeReverseShellDetailRequest req)
        {
            return InternalRequestAsync<DescribeReverseShellDetailResponse>(req, "DescribeReverseShellDetail");
        }

        /// <summary>
        /// This API is used to query the details of a reverse shell event at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeReverseShellDetailRequest"/></param>
        /// <returns><see cref="DescribeReverseShellDetailResponse"/></returns>
        public DescribeReverseShellDetailResponse DescribeReverseShellDetailSync(DescribeReverseShellDetailRequest req)
        {
            return InternalRequestAsync<DescribeReverseShellDetailResponse>(req, "DescribeReverseShellDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of reverse shell events at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeReverseShellEventsRequest"/></param>
        /// <returns><see cref="DescribeReverseShellEventsResponse"/></returns>
        public Task<DescribeReverseShellEventsResponse> DescribeReverseShellEvents(DescribeReverseShellEventsRequest req)
        {
            return InternalRequestAsync<DescribeReverseShellEventsResponse>(req, "DescribeReverseShellEvents");
        }

        /// <summary>
        /// This API is used to query the list of reverse shell events at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeReverseShellEventsRequest"/></param>
        /// <returns><see cref="DescribeReverseShellEventsResponse"/></returns>
        public DescribeReverseShellEventsResponse DescribeReverseShellEventsSync(DescribeReverseShellEventsRequest req)
        {
            return InternalRequestAsync<DescribeReverseShellEventsResponse>(req, "DescribeReverseShellEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query and export the list of reverse shell events at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeReverseShellEventsExportRequest"/></param>
        /// <returns><see cref="DescribeReverseShellEventsExportResponse"/></returns>
        public Task<DescribeReverseShellEventsExportResponse> DescribeReverseShellEventsExport(DescribeReverseShellEventsExportRequest req)
        {
            return InternalRequestAsync<DescribeReverseShellEventsExportResponse>(req, "DescribeReverseShellEventsExport");
        }

        /// <summary>
        /// This API is used to query and export the list of reverse shell events at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeReverseShellEventsExportRequest"/></param>
        /// <returns><see cref="DescribeReverseShellEventsExportResponse"/></returns>
        public DescribeReverseShellEventsExportResponse DescribeReverseShellEventsExportSync(DescribeReverseShellEventsExportRequest req)
        {
            return InternalRequestAsync<DescribeReverseShellEventsExportResponse>(req, "DescribeReverseShellEventsExport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of the allowlist of reverse shells at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeReverseShellWhiteListDetailRequest"/></param>
        /// <returns><see cref="DescribeReverseShellWhiteListDetailResponse"/></returns>
        public Task<DescribeReverseShellWhiteListDetailResponse> DescribeReverseShellWhiteListDetail(DescribeReverseShellWhiteListDetailRequest req)
        {
            return InternalRequestAsync<DescribeReverseShellWhiteListDetailResponse>(req, "DescribeReverseShellWhiteListDetail");
        }

        /// <summary>
        /// This API is used to query the details of the allowlist of reverse shells at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeReverseShellWhiteListDetailRequest"/></param>
        /// <returns><see cref="DescribeReverseShellWhiteListDetailResponse"/></returns>
        public DescribeReverseShellWhiteListDetailResponse DescribeReverseShellWhiteListDetailSync(DescribeReverseShellWhiteListDetailRequest req)
        {
            return InternalRequestAsync<DescribeReverseShellWhiteListDetailResponse>(req, "DescribeReverseShellWhiteListDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the allowlist of reverse shells at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeReverseShellWhiteListsRequest"/></param>
        /// <returns><see cref="DescribeReverseShellWhiteListsResponse"/></returns>
        public Task<DescribeReverseShellWhiteListsResponse> DescribeReverseShellWhiteLists(DescribeReverseShellWhiteListsRequest req)
        {
            return InternalRequestAsync<DescribeReverseShellWhiteListsResponse>(req, "DescribeReverseShellWhiteLists");
        }

        /// <summary>
        /// This API is used to query the allowlist of reverse shells at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeReverseShellWhiteListsRequest"/></param>
        /// <returns><see cref="DescribeReverseShellWhiteListsResponse"/></returns>
        public DescribeReverseShellWhiteListsResponse DescribeReverseShellWhiteListsSync(DescribeReverseShellWhiteListsRequest req)
        {
            return InternalRequestAsync<DescribeReverseShellWhiteListsResponse>(req, "DescribeReverseShellWhiteLists")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of risk items identified in the last task and filter them by special field.
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskListResponse"/></returns>
        public Task<DescribeRiskListResponse> DescribeRiskList(DescribeRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskListResponse>(req, "DescribeRiskList");
        }

        /// <summary>
        /// This API is used to query the list of risk items identified in the last task and filter them by special field.
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskListResponse"/></returns>
        public DescribeRiskListResponse DescribeRiskListSync(DescribeRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskListResponse>(req, "DescribeRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of a high-risk syscall event.
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskSyscallDetailRequest"/></param>
        /// <returns><see cref="DescribeRiskSyscallDetailResponse"/></returns>
        public Task<DescribeRiskSyscallDetailResponse> DescribeRiskSyscallDetail(DescribeRiskSyscallDetailRequest req)
        {
            return InternalRequestAsync<DescribeRiskSyscallDetailResponse>(req, "DescribeRiskSyscallDetail");
        }

        /// <summary>
        /// This API is used to query the details of a high-risk syscall event.
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskSyscallDetailRequest"/></param>
        /// <returns><see cref="DescribeRiskSyscallDetailResponse"/></returns>
        public DescribeRiskSyscallDetailResponse DescribeRiskSyscallDetailSync(DescribeRiskSyscallDetailRequest req)
        {
            return InternalRequestAsync<DescribeRiskSyscallDetailResponse>(req, "DescribeRiskSyscallDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of high-risk syscalls at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskSyscallEventsRequest"/></param>
        /// <returns><see cref="DescribeRiskSyscallEventsResponse"/></returns>
        public Task<DescribeRiskSyscallEventsResponse> DescribeRiskSyscallEvents(DescribeRiskSyscallEventsRequest req)
        {
            return InternalRequestAsync<DescribeRiskSyscallEventsResponse>(req, "DescribeRiskSyscallEvents");
        }

        /// <summary>
        /// This API is used to query the list of high-risk syscalls at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskSyscallEventsRequest"/></param>
        /// <returns><see cref="DescribeRiskSyscallEventsResponse"/></returns>
        public DescribeRiskSyscallEventsResponse DescribeRiskSyscallEventsSync(DescribeRiskSyscallEventsRequest req)
        {
            return InternalRequestAsync<DescribeRiskSyscallEventsResponse>(req, "DescribeRiskSyscallEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the list of high-risk syscalls at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskSyscallEventsExportRequest"/></param>
        /// <returns><see cref="DescribeRiskSyscallEventsExportResponse"/></returns>
        public Task<DescribeRiskSyscallEventsExportResponse> DescribeRiskSyscallEventsExport(DescribeRiskSyscallEventsExportRequest req)
        {
            return InternalRequestAsync<DescribeRiskSyscallEventsExportResponse>(req, "DescribeRiskSyscallEventsExport");
        }

        /// <summary>
        /// This API is used to export the list of high-risk syscalls at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskSyscallEventsExportRequest"/></param>
        /// <returns><see cref="DescribeRiskSyscallEventsExportResponse"/></returns>
        public DescribeRiskSyscallEventsExportResponse DescribeRiskSyscallEventsExportSync(DescribeRiskSyscallEventsExportRequest req)
        {
            return InternalRequestAsync<DescribeRiskSyscallEventsExportResponse>(req, "DescribeRiskSyscallEventsExport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of names of high-risk syscalls at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskSyscallNamesRequest"/></param>
        /// <returns><see cref="DescribeRiskSyscallNamesResponse"/></returns>
        public Task<DescribeRiskSyscallNamesResponse> DescribeRiskSyscallNames(DescribeRiskSyscallNamesRequest req)
        {
            return InternalRequestAsync<DescribeRiskSyscallNamesResponse>(req, "DescribeRiskSyscallNames");
        }

        /// <summary>
        /// This API is used to query the list of names of high-risk syscalls at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskSyscallNamesRequest"/></param>
        /// <returns><see cref="DescribeRiskSyscallNamesResponse"/></returns>
        public DescribeRiskSyscallNamesResponse DescribeRiskSyscallNamesSync(DescribeRiskSyscallNamesRequest req)
        {
            return InternalRequestAsync<DescribeRiskSyscallNamesResponse>(req, "DescribeRiskSyscallNames")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of the allowlist of high-risk syscalls at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskSyscallWhiteListDetailRequest"/></param>
        /// <returns><see cref="DescribeRiskSyscallWhiteListDetailResponse"/></returns>
        public Task<DescribeRiskSyscallWhiteListDetailResponse> DescribeRiskSyscallWhiteListDetail(DescribeRiskSyscallWhiteListDetailRequest req)
        {
            return InternalRequestAsync<DescribeRiskSyscallWhiteListDetailResponse>(req, "DescribeRiskSyscallWhiteListDetail");
        }

        /// <summary>
        /// This API is used to query the details of the allowlist of high-risk syscalls at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskSyscallWhiteListDetailRequest"/></param>
        /// <returns><see cref="DescribeRiskSyscallWhiteListDetailResponse"/></returns>
        public DescribeRiskSyscallWhiteListDetailResponse DescribeRiskSyscallWhiteListDetailSync(DescribeRiskSyscallWhiteListDetailRequest req)
        {
            return InternalRequestAsync<DescribeRiskSyscallWhiteListDetailResponse>(req, "DescribeRiskSyscallWhiteListDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the allowlist of high-risk syscalls at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskSyscallWhiteListsRequest"/></param>
        /// <returns><see cref="DescribeRiskSyscallWhiteListsResponse"/></returns>
        public Task<DescribeRiskSyscallWhiteListsResponse> DescribeRiskSyscallWhiteLists(DescribeRiskSyscallWhiteListsRequest req)
        {
            return InternalRequestAsync<DescribeRiskSyscallWhiteListsResponse>(req, "DescribeRiskSyscallWhiteLists");
        }

        /// <summary>
        /// This API is used to query the allowlist of high-risk syscalls at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskSyscallWhiteListsRequest"/></param>
        /// <returns><see cref="DescribeRiskSyscallWhiteListsResponse"/></returns>
        public DescribeRiskSyscallWhiteListsResponse DescribeRiskSyscallWhiteListsSync(DescribeRiskSyscallWhiteListsRequest req)
        {
            return InternalRequestAsync<DescribeRiskSyscallWhiteListsResponse>(req, "DescribeRiskSyscallWhiteLists")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of vulnerabilities ignored in a scan.
        /// </summary>
        /// <param name="req"><see cref="DescribeScanIgnoreVulListRequest"/></param>
        /// <returns><see cref="DescribeScanIgnoreVulListResponse"/></returns>
        public Task<DescribeScanIgnoreVulListResponse> DescribeScanIgnoreVulList(DescribeScanIgnoreVulListRequest req)
        {
            return InternalRequestAsync<DescribeScanIgnoreVulListResponse>(req, "DescribeScanIgnoreVulList");
        }

        /// <summary>
        /// This API is used to query the list of vulnerabilities ignored in a scan.
        /// </summary>
        /// <param name="req"><see cref="DescribeScanIgnoreVulListRequest"/></param>
        /// <returns><see cref="DescribeScanIgnoreVulListResponse"/></returns>
        public DescribeScanIgnoreVulListResponse DescribeScanIgnoreVulListSync(DescribeScanIgnoreVulListRequest req)
        {
            return InternalRequestAsync<DescribeScanIgnoreVulListResponse>(req, "DescribeScanIgnoreVulList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the list of ES query files.
        /// </summary>
        /// <param name="req"><see cref="DescribeSearchExportListRequest"/></param>
        /// <returns><see cref="DescribeSearchExportListResponse"/></returns>
        public Task<DescribeSearchExportListResponse> DescribeSearchExportList(DescribeSearchExportListRequest req)
        {
            return InternalRequestAsync<DescribeSearchExportListResponse>(req, "DescribeSearchExportList");
        }

        /// <summary>
        /// This API is used to export the list of ES query files.
        /// </summary>
        /// <param name="req"><see cref="DescribeSearchExportListRequest"/></param>
        /// <returns><see cref="DescribeSearchExportListResponse"/></returns>
        public DescribeSearchExportListResponse DescribeSearchExportListSync(DescribeSearchExportListRequest req)
        {
            return InternalRequestAsync<DescribeSearchExportListResponse>(req, "DescribeSearchExportList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get historical search records.
        /// </summary>
        /// <param name="req"><see cref="DescribeSearchLogsRequest"/></param>
        /// <returns><see cref="DescribeSearchLogsResponse"/></returns>
        public Task<DescribeSearchLogsResponse> DescribeSearchLogs(DescribeSearchLogsRequest req)
        {
            return InternalRequestAsync<DescribeSearchLogsResponse>(req, "DescribeSearchLogs");
        }

        /// <summary>
        /// This API is used to get historical search records.
        /// </summary>
        /// <param name="req"><see cref="DescribeSearchLogsRequest"/></param>
        /// <returns><see cref="DescribeSearchLogsResponse"/></returns>
        public DescribeSearchLogsResponse DescribeSearchLogsSync(DescribeSearchLogsRequest req)
        {
            return InternalRequestAsync<DescribeSearchLogsResponse>(req, "DescribeSearchLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of search templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeSearchTemplatesRequest"/></param>
        /// <returns><see cref="DescribeSearchTemplatesResponse"/></returns>
        public Task<DescribeSearchTemplatesResponse> DescribeSearchTemplates(DescribeSearchTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeSearchTemplatesResponse>(req, "DescribeSearchTemplates");
        }

        /// <summary>
        /// This API is used to get the list of search templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeSearchTemplatesRequest"/></param>
        /// <returns><see cref="DescribeSearchTemplatesResponse"/></returns>
        public DescribeSearchTemplatesResponse DescribeSearchTemplatesSync(DescribeSearchTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeSearchTemplatesResponse>(req, "DescribeSearchTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the trend of security events at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecEventsTendencyRequest"/></param>
        /// <returns><see cref="DescribeSecEventsTendencyResponse"/></returns>
        public Task<DescribeSecEventsTendencyResponse> DescribeSecEventsTendency(DescribeSecEventsTendencyRequest req)
        {
            return InternalRequestAsync<DescribeSecEventsTendencyResponse>(req, "DescribeSecEventsTendency");
        }

        /// <summary>
        /// This API is used to query the trend of security events at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecEventsTendencyRequest"/></param>
        /// <returns><see cref="DescribeSecEventsTendencyResponse"/></returns>
        public DescribeSecEventsTendencyResponse DescribeSecEventsTendencySync(DescribeSecEventsTendencyRequest req)
        {
            return InternalRequestAsync<DescribeSecEventsTendencyResponse>(req, "DescribeSecEventsTendency")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query a security log alert message.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecLogAlertMsgRequest"/></param>
        /// <returns><see cref="DescribeSecLogAlertMsgResponse"/></returns>
        public Task<DescribeSecLogAlertMsgResponse> DescribeSecLogAlertMsg(DescribeSecLogAlertMsgRequest req)
        {
            return InternalRequestAsync<DescribeSecLogAlertMsgResponse>(req, "DescribeSecLogAlertMsg");
        }

        /// <summary>
        /// This API is used to query a security log alert message.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecLogAlertMsgRequest"/></param>
        /// <returns><see cref="DescribeSecLogAlertMsgResponse"/></returns>
        public DescribeSecLogAlertMsgResponse DescribeSecLogAlertMsgSync(DescribeSecLogAlertMsgRequest req)
        {
            return InternalRequestAsync<DescribeSecLogAlertMsgResponse>(req, "DescribeSecLogAlertMsg")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the settings of security log cleanup.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecLogCleanSettingInfoRequest"/></param>
        /// <returns><see cref="DescribeSecLogCleanSettingInfoResponse"/></returns>
        public Task<DescribeSecLogCleanSettingInfoResponse> DescribeSecLogCleanSettingInfo(DescribeSecLogCleanSettingInfoRequest req)
        {
            return InternalRequestAsync<DescribeSecLogCleanSettingInfoResponse>(req, "DescribeSecLogCleanSettingInfo");
        }

        /// <summary>
        /// This API is used to query the settings of security log cleanup.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecLogCleanSettingInfoRequest"/></param>
        /// <returns><see cref="DescribeSecLogCleanSettingInfoResponse"/></returns>
        public DescribeSecLogCleanSettingInfoResponse DescribeSecLogCleanSettingInfoSync(DescribeSecLogCleanSettingInfoRequest req)
        {
            return InternalRequestAsync<DescribeSecLogCleanSettingInfoResponse>(req, "DescribeSecLogCleanSettingInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the options of security log delivery to CLS.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecLogDeliveryClsOptionsRequest"/></param>
        /// <returns><see cref="DescribeSecLogDeliveryClsOptionsResponse"/></returns>
        public Task<DescribeSecLogDeliveryClsOptionsResponse> DescribeSecLogDeliveryClsOptions(DescribeSecLogDeliveryClsOptionsRequest req)
        {
            return InternalRequestAsync<DescribeSecLogDeliveryClsOptionsResponse>(req, "DescribeSecLogDeliveryClsOptions");
        }

        /// <summary>
        /// This API is used to query the options of security log delivery to CLS.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecLogDeliveryClsOptionsRequest"/></param>
        /// <returns><see cref="DescribeSecLogDeliveryClsOptionsResponse"/></returns>
        public DescribeSecLogDeliveryClsOptionsResponse DescribeSecLogDeliveryClsOptionsSync(DescribeSecLogDeliveryClsOptionsRequest req)
        {
            return InternalRequestAsync<DescribeSecLogDeliveryClsOptionsResponse>(req, "DescribeSecLogDeliveryClsOptions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the settings of security log delivery to CLS.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecLogDeliveryClsSettingRequest"/></param>
        /// <returns><see cref="DescribeSecLogDeliveryClsSettingResponse"/></returns>
        public Task<DescribeSecLogDeliveryClsSettingResponse> DescribeSecLogDeliveryClsSetting(DescribeSecLogDeliveryClsSettingRequest req)
        {
            return InternalRequestAsync<DescribeSecLogDeliveryClsSettingResponse>(req, "DescribeSecLogDeliveryClsSetting");
        }

        /// <summary>
        /// This API is used to query the settings of security log delivery to CLS.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecLogDeliveryClsSettingRequest"/></param>
        /// <returns><see cref="DescribeSecLogDeliveryClsSettingResponse"/></returns>
        public DescribeSecLogDeliveryClsSettingResponse DescribeSecLogDeliveryClsSettingSync(DescribeSecLogDeliveryClsSettingRequest req)
        {
            return InternalRequestAsync<DescribeSecLogDeliveryClsSettingResponse>(req, "DescribeSecLogDeliveryClsSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the options of security log delivery to Kafka.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecLogDeliveryKafkaOptionsRequest"/></param>
        /// <returns><see cref="DescribeSecLogDeliveryKafkaOptionsResponse"/></returns>
        public Task<DescribeSecLogDeliveryKafkaOptionsResponse> DescribeSecLogDeliveryKafkaOptions(DescribeSecLogDeliveryKafkaOptionsRequest req)
        {
            return InternalRequestAsync<DescribeSecLogDeliveryKafkaOptionsResponse>(req, "DescribeSecLogDeliveryKafkaOptions");
        }

        /// <summary>
        /// This API is used to query the options of security log delivery to Kafka.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecLogDeliveryKafkaOptionsRequest"/></param>
        /// <returns><see cref="DescribeSecLogDeliveryKafkaOptionsResponse"/></returns>
        public DescribeSecLogDeliveryKafkaOptionsResponse DescribeSecLogDeliveryKafkaOptionsSync(DescribeSecLogDeliveryKafkaOptionsRequest req)
        {
            return InternalRequestAsync<DescribeSecLogDeliveryKafkaOptionsResponse>(req, "DescribeSecLogDeliveryKafkaOptions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the settings of security log delivery to Kafka.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecLogDeliveryKafkaSettingRequest"/></param>
        /// <returns><see cref="DescribeSecLogDeliveryKafkaSettingResponse"/></returns>
        public Task<DescribeSecLogDeliveryKafkaSettingResponse> DescribeSecLogDeliveryKafkaSetting(DescribeSecLogDeliveryKafkaSettingRequest req)
        {
            return InternalRequestAsync<DescribeSecLogDeliveryKafkaSettingResponse>(req, "DescribeSecLogDeliveryKafkaSetting");
        }

        /// <summary>
        /// This API is used to query the settings of security log delivery to Kafka.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecLogDeliveryKafkaSettingRequest"/></param>
        /// <returns><see cref="DescribeSecLogDeliveryKafkaSettingResponse"/></returns>
        public DescribeSecLogDeliveryKafkaSettingResponse DescribeSecLogDeliveryKafkaSettingSync(DescribeSecLogDeliveryKafkaSettingRequest req)
        {
            return InternalRequestAsync<DescribeSecLogDeliveryKafkaSettingResponse>(req, "DescribeSecLogDeliveryKafkaSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of accessed security log objects.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecLogJoinObjectListRequest"/></param>
        /// <returns><see cref="DescribeSecLogJoinObjectListResponse"/></returns>
        public Task<DescribeSecLogJoinObjectListResponse> DescribeSecLogJoinObjectList(DescribeSecLogJoinObjectListRequest req)
        {
            return InternalRequestAsync<DescribeSecLogJoinObjectListResponse>(req, "DescribeSecLogJoinObjectList");
        }

        /// <summary>
        /// This API is used to query the list of accessed security log objects.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecLogJoinObjectListRequest"/></param>
        /// <returns><see cref="DescribeSecLogJoinObjectListResponse"/></returns>
        public DescribeSecLogJoinObjectListResponse DescribeSecLogJoinObjectListSync(DescribeSecLogJoinObjectListRequest req)
        {
            return InternalRequestAsync<DescribeSecLogJoinObjectListResponse>(req, "DescribeSecLogJoinObjectList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of security log access types.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecLogJoinTypeListRequest"/></param>
        /// <returns><see cref="DescribeSecLogJoinTypeListResponse"/></returns>
        public Task<DescribeSecLogJoinTypeListResponse> DescribeSecLogJoinTypeList(DescribeSecLogJoinTypeListRequest req)
        {
            return InternalRequestAsync<DescribeSecLogJoinTypeListResponse>(req, "DescribeSecLogJoinTypeList");
        }

        /// <summary>
        /// This API is used to query the list of security log access types.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecLogJoinTypeListRequest"/></param>
        /// <returns><see cref="DescribeSecLogJoinTypeListResponse"/></returns>
        public DescribeSecLogJoinTypeListResponse DescribeSecLogJoinTypeListSync(DescribeSecLogJoinTypeListRequest req)
        {
            return InternalRequestAsync<DescribeSecLogJoinTypeListResponse>(req, "DescribeSecLogJoinTypeList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the UIN of a Kafka security log.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecLogKafkaUINRequest"/></param>
        /// <returns><see cref="DescribeSecLogKafkaUINResponse"/></returns>
        public Task<DescribeSecLogKafkaUINResponse> DescribeSecLogKafkaUIN(DescribeSecLogKafkaUINRequest req)
        {
            return InternalRequestAsync<DescribeSecLogKafkaUINResponse>(req, "DescribeSecLogKafkaUIN");
        }

        /// <summary>
        /// This API is used to query the UIN of a Kafka security log.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecLogKafkaUINRequest"/></param>
        /// <returns><see cref="DescribeSecLogKafkaUINResponse"/></returns>
        public DescribeSecLogKafkaUINResponse DescribeSecLogKafkaUINSync(DescribeSecLogKafkaUINRequest req)
        {
            return InternalRequestAsync<DescribeSecLogKafkaUINResponse>(req, "DescribeSecLogKafkaUIN")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of the security log product.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecLogVasInfoRequest"/></param>
        /// <returns><see cref="DescribeSecLogVasInfoResponse"/></returns>
        public Task<DescribeSecLogVasInfoResponse> DescribeSecLogVasInfo(DescribeSecLogVasInfoRequest req)
        {
            return InternalRequestAsync<DescribeSecLogVasInfoResponse>(req, "DescribeSecLogVasInfo");
        }

        /// <summary>
        /// This API is used to query the information of the security log product.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecLogVasInfoRequest"/></param>
        /// <returns><see cref="DescribeSecLogVasInfoResponse"/></returns>
        public DescribeSecLogVasInfoResponse DescribeSecLogVasInfoSync(DescribeSecLogVasInfoRequest req)
        {
            return InternalRequestAsync<DescribeSecLogVasInfoResponse>(req, "DescribeSecLogVasInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of vulnerabilities that can be prevented
        /// </summary>
        /// <param name="req"><see cref="DescribeSupportDefenceVulRequest"/></param>
        /// <returns><see cref="DescribeSupportDefenceVulResponse"/></returns>
        public Task<DescribeSupportDefenceVulResponse> DescribeSupportDefenceVul(DescribeSupportDefenceVulRequest req)
        {
            return InternalRequestAsync<DescribeSupportDefenceVulResponse>(req, "DescribeSupportDefenceVul");
        }

        /// <summary>
        /// This API is used to query the list of vulnerabilities that can be prevented
        /// </summary>
        /// <param name="req"><see cref="DescribeSupportDefenceVulRequest"/></param>
        /// <returns><see cref="DescribeSupportDefenceVulResponse"/></returns>
        public DescribeSupportDefenceVulResponse DescribeSupportDefenceVulSync(DescribeSupportDefenceVulRequest req)
        {
            return InternalRequestAsync<DescribeSupportDefenceVulResponse>(req, "DescribeSupportDefenceVul")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of system vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="DescribeSystemVulListRequest"/></param>
        /// <returns><see cref="DescribeSystemVulListResponse"/></returns>
        public Task<DescribeSystemVulListResponse> DescribeSystemVulList(DescribeSystemVulListRequest req)
        {
            return InternalRequestAsync<DescribeSystemVulListResponse>(req, "DescribeSystemVulList");
        }

        /// <summary>
        /// This API is used to query the list of system vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="DescribeSystemVulListRequest"/></param>
        /// <returns><see cref="DescribeSystemVulListResponse"/></returns>
        public DescribeSystemVulListResponse DescribeSystemVulListSync(DescribeSystemVulListRequest req)
        {
            return InternalRequestAsync<DescribeSystemVulListResponse>(req, "DescribeSystemVulList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the overview of a check result and return the number of affected nodes in the last seven days.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskResultSummaryRequest"/></param>
        /// <returns><see cref="DescribeTaskResultSummaryResponse"/></returns>
        public Task<DescribeTaskResultSummaryResponse> DescribeTaskResultSummary(DescribeTaskResultSummaryRequest req)
        {
            return InternalRequestAsync<DescribeTaskResultSummaryResponse>(req, "DescribeTaskResultSummary");
        }

        /// <summary>
        /// This API is used to query the overview of a check result and return the number of affected nodes in the last seven days.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskResultSummaryRequest"/></param>
        /// <returns><see cref="DescribeTaskResultSummaryResponse"/></returns>
        public DescribeTaskResultSummaryResponse DescribeTaskResultSummarySync(DescribeTaskResultSummaryRequest req)
        {
            return InternalRequestAsync<DescribeTaskResultSummaryResponse>(req, "DescribeTaskResultSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the TCSS overview.
        /// </summary>
        /// <param name="req"><see cref="DescribeTcssSummaryRequest"/></param>
        /// <returns><see cref="DescribeTcssSummaryResponse"/></returns>
        public Task<DescribeTcssSummaryResponse> DescribeTcssSummary(DescribeTcssSummaryRequest req)
        {
            return InternalRequestAsync<DescribeTcssSummaryResponse>(req, "DescribeTcssSummary");
        }

        /// <summary>
        /// This API is used to query the TCSS overview.
        /// </summary>
        /// <param name="req"><see cref="DescribeTcssSummaryRequest"/></param>
        /// <returns><see cref="DescribeTcssSummaryResponse"/></returns>
        public DescribeTcssSummaryResponse DescribeTcssSummarySync(DescribeTcssSummaryRequest req)
        {
            return InternalRequestAsync<DescribeTcssSummaryResponse>(req, "DescribeTcssSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the trend of daily unlicensed cores.
        /// </summary>
        /// <param name="req"><see cref="DescribeUnauthorizedCoresTendencyRequest"/></param>
        /// <returns><see cref="DescribeUnauthorizedCoresTendencyResponse"/></returns>
        public Task<DescribeUnauthorizedCoresTendencyResponse> DescribeUnauthorizedCoresTendency(DescribeUnauthorizedCoresTendencyRequest req)
        {
            return InternalRequestAsync<DescribeUnauthorizedCoresTendencyResponse>(req, "DescribeUnauthorizedCoresTendency");
        }

        /// <summary>
        /// This API is used to query the trend of daily unlicensed cores.
        /// </summary>
        /// <param name="req"><see cref="DescribeUnauthorizedCoresTendencyRequest"/></param>
        /// <returns><see cref="DescribeUnauthorizedCoresTendencyResponse"/></returns>
        public DescribeUnauthorizedCoresTendencyResponse DescribeUnauthorizedCoresTendencySync(DescribeUnauthorizedCoresTendencyRequest req)
        {
            return InternalRequestAsync<DescribeUnauthorizedCoresTendencyResponse>(req, "DescribeUnauthorizedCoresTendency")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of an unfinished asset refreshing task.
        /// </summary>
        /// <param name="req"><see cref="DescribeUnfinishRefreshTaskRequest"/></param>
        /// <returns><see cref="DescribeUnfinishRefreshTaskResponse"/></returns>
        public Task<DescribeUnfinishRefreshTaskResponse> DescribeUnfinishRefreshTask(DescribeUnfinishRefreshTaskRequest req)
        {
            return InternalRequestAsync<DescribeUnfinishRefreshTaskResponse>(req, "DescribeUnfinishRefreshTask");
        }

        /// <summary>
        /// This API is used to query the information of an unfinished asset refreshing task.
        /// </summary>
        /// <param name="req"><see cref="DescribeUnfinishRefreshTaskRequest"/></param>
        /// <returns><see cref="DescribeUnfinishRefreshTaskResponse"/></returns>
        public DescribeUnfinishRefreshTaskResponse DescribeUnfinishRefreshTaskSync(DescribeUnfinishRefreshTaskRequest req)
        {
            return InternalRequestAsync<DescribeUnfinishRefreshTaskResponse>(req, "DescribeUnfinishRefreshTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of a cluster on the Security Dashboard and Cluster Security pages.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserClusterRequest"/></param>
        /// <returns><see cref="DescribeUserClusterResponse"/></returns>
        public Task<DescribeUserClusterResponse> DescribeUserCluster(DescribeUserClusterRequest req)
        {
            return InternalRequestAsync<DescribeUserClusterResponse>(req, "DescribeUserCluster");
        }

        /// <summary>
        /// This API is used to query the information of a cluster on the Security Dashboard and Cluster Security pages.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserClusterRequest"/></param>
        /// <returns><see cref="DescribeUserClusterResponse"/></returns>
        public DescribeUserClusterResponse DescribeUserClusterSync(DescribeUserClusterRequest req)
        {
            return InternalRequestAsync<DescribeUserClusterResponse>(req, "DescribeUserCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of the required value-added service.
        /// </summary>
        /// <param name="req"><see cref="DescribeValueAddedSrvInfoRequest"/></param>
        /// <returns><see cref="DescribeValueAddedSrvInfoResponse"/></returns>
        public Task<DescribeValueAddedSrvInfoResponse> DescribeValueAddedSrvInfo(DescribeValueAddedSrvInfoRequest req)
        {
            return InternalRequestAsync<DescribeValueAddedSrvInfoResponse>(req, "DescribeValueAddedSrvInfo");
        }

        /// <summary>
        /// This API is used to query the information of the required value-added service.
        /// </summary>
        /// <param name="req"><see cref="DescribeValueAddedSrvInfoRequest"/></param>
        /// <returns><see cref="DescribeValueAddedSrvInfoResponse"/></returns>
        public DescribeValueAddedSrvInfoResponse DescribeValueAddedSrvInfoSync(DescribeValueAddedSrvInfoRequest req)
        {
            return InternalRequestAsync<DescribeValueAddedSrvInfoResponse>(req, "DescribeValueAddedSrvInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of an automatically isolated trojan sample.
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusAutoIsolateSampleDetailRequest"/></param>
        /// <returns><see cref="DescribeVirusAutoIsolateSampleDetailResponse"/></returns>
        public Task<DescribeVirusAutoIsolateSampleDetailResponse> DescribeVirusAutoIsolateSampleDetail(DescribeVirusAutoIsolateSampleDetailRequest req)
        {
            return InternalRequestAsync<DescribeVirusAutoIsolateSampleDetailResponse>(req, "DescribeVirusAutoIsolateSampleDetail");
        }

        /// <summary>
        /// This API is used to query the details of an automatically isolated trojan sample.
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusAutoIsolateSampleDetailRequest"/></param>
        /// <returns><see cref="DescribeVirusAutoIsolateSampleDetailResponse"/></returns>
        public DescribeVirusAutoIsolateSampleDetailResponse DescribeVirusAutoIsolateSampleDetailSync(DescribeVirusAutoIsolateSampleDetailRequest req)
        {
            return InternalRequestAsync<DescribeVirusAutoIsolateSampleDetailResponse>(req, "DescribeVirusAutoIsolateSampleDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the download URL of an automatically isolated trojan sample.
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusAutoIsolateSampleDownloadURLRequest"/></param>
        /// <returns><see cref="DescribeVirusAutoIsolateSampleDownloadURLResponse"/></returns>
        public Task<DescribeVirusAutoIsolateSampleDownloadURLResponse> DescribeVirusAutoIsolateSampleDownloadURL(DescribeVirusAutoIsolateSampleDownloadURLRequest req)
        {
            return InternalRequestAsync<DescribeVirusAutoIsolateSampleDownloadURLResponse>(req, "DescribeVirusAutoIsolateSampleDownloadURL");
        }

        /// <summary>
        /// This API is used to query the download URL of an automatically isolated trojan sample.
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusAutoIsolateSampleDownloadURLRequest"/></param>
        /// <returns><see cref="DescribeVirusAutoIsolateSampleDownloadURLResponse"/></returns>
        public DescribeVirusAutoIsolateSampleDownloadURLResponse DescribeVirusAutoIsolateSampleDownloadURLSync(DescribeVirusAutoIsolateSampleDownloadURLRequest req)
        {
            return InternalRequestAsync<DescribeVirusAutoIsolateSampleDownloadURLResponse>(req, "DescribeVirusAutoIsolateSampleDownloadURL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of automatically isolated trojan samples.
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusAutoIsolateSampleListRequest"/></param>
        /// <returns><see cref="DescribeVirusAutoIsolateSampleListResponse"/></returns>
        public Task<DescribeVirusAutoIsolateSampleListResponse> DescribeVirusAutoIsolateSampleList(DescribeVirusAutoIsolateSampleListRequest req)
        {
            return InternalRequestAsync<DescribeVirusAutoIsolateSampleListResponse>(req, "DescribeVirusAutoIsolateSampleList");
        }

        /// <summary>
        /// This API is used to query the list of automatically isolated trojan samples.
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusAutoIsolateSampleListRequest"/></param>
        /// <returns><see cref="DescribeVirusAutoIsolateSampleListResponse"/></returns>
        public DescribeVirusAutoIsolateSampleListResponse DescribeVirusAutoIsolateSampleListSync(DescribeVirusAutoIsolateSampleListRequest req)
        {
            return InternalRequestAsync<DescribeVirusAutoIsolateSampleListResponse>(req, "DescribeVirusAutoIsolateSampleList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the settings of automatic trojan isolation.
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusAutoIsolateSettingRequest"/></param>
        /// <returns><see cref="DescribeVirusAutoIsolateSettingResponse"/></returns>
        public Task<DescribeVirusAutoIsolateSettingResponse> DescribeVirusAutoIsolateSetting(DescribeVirusAutoIsolateSettingRequest req)
        {
            return InternalRequestAsync<DescribeVirusAutoIsolateSettingResponse>(req, "DescribeVirusAutoIsolateSetting");
        }

        /// <summary>
        /// This API is used to query the settings of automatic trojan isolation.
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusAutoIsolateSettingRequest"/></param>
        /// <returns><see cref="DescribeVirusAutoIsolateSettingResponse"/></returns>
        public DescribeVirusAutoIsolateSettingResponse DescribeVirusAutoIsolateSettingSync(DescribeVirusAutoIsolateSettingRequest req)
        {
            return InternalRequestAsync<DescribeVirusAutoIsolateSettingResponse>(req, "DescribeVirusAutoIsolateSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of a trojan file at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusDetailRequest"/></param>
        /// <returns><see cref="DescribeVirusDetailResponse"/></returns>
        public Task<DescribeVirusDetailResponse> DescribeVirusDetail(DescribeVirusDetailRequest req)
        {
            return InternalRequestAsync<DescribeVirusDetailResponse>(req, "DescribeVirusDetail");
        }

        /// <summary>
        /// This API is used to query the information of a trojan file at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusDetailRequest"/></param>
        /// <returns><see cref="DescribeVirusDetailResponse"/></returns>
        public DescribeVirusDetailResponse DescribeVirusDetailSync(DescribeVirusDetailRequest req)
        {
            return InternalRequestAsync<DescribeVirusDetailResponse>(req, "DescribeVirusDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the trend of trojan events.
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusEventTendencyRequest"/></param>
        /// <returns><see cref="DescribeVirusEventTendencyResponse"/></returns>
        public Task<DescribeVirusEventTendencyResponse> DescribeVirusEventTendency(DescribeVirusEventTendencyRequest req)
        {
            return InternalRequestAsync<DescribeVirusEventTendencyResponse>(req, "DescribeVirusEventTendency");
        }

        /// <summary>
        /// This API is used to query the trend of trojan events.
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusEventTendencyRequest"/></param>
        /// <returns><see cref="DescribeVirusEventTendencyResponse"/></returns>
        public DescribeVirusEventTendencyResponse DescribeVirusEventTendencySync(DescribeVirusEventTendencyRequest req)
        {
            return InternalRequestAsync<DescribeVirusEventTendencyResponse>(req, "DescribeVirusEventTendency")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of virus scanning events at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusListRequest"/></param>
        /// <returns><see cref="DescribeVirusListResponse"/></returns>
        public Task<DescribeVirusListResponse> DescribeVirusList(DescribeVirusListRequest req)
        {
            return InternalRequestAsync<DescribeVirusListResponse>(req, "DescribeVirusList");
        }

        /// <summary>
        /// This API is used to query the list of virus scanning events at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusListRequest"/></param>
        /// <returns><see cref="DescribeVirusListResponse"/></returns>
        public DescribeVirusListResponse DescribeVirusListSync(DescribeVirusListRequest req)
        {
            return InternalRequestAsync<DescribeVirusListResponse>(req, "DescribeVirusList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the estimated timeout period of a quick trojan scan.
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusManualScanEstimateTimeoutRequest"/></param>
        /// <returns><see cref="DescribeVirusManualScanEstimateTimeoutResponse"/></returns>
        public Task<DescribeVirusManualScanEstimateTimeoutResponse> DescribeVirusManualScanEstimateTimeout(DescribeVirusManualScanEstimateTimeoutRequest req)
        {
            return InternalRequestAsync<DescribeVirusManualScanEstimateTimeoutResponse>(req, "DescribeVirusManualScanEstimateTimeout");
        }

        /// <summary>
        /// This API is used to query the estimated timeout period of a quick trojan scan.
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusManualScanEstimateTimeoutRequest"/></param>
        /// <returns><see cref="DescribeVirusManualScanEstimateTimeoutResponse"/></returns>
        public DescribeVirusManualScanEstimateTimeoutResponse DescribeVirusManualScanEstimateTimeoutSync(DescribeVirusManualScanEstimateTimeoutRequest req)
        {
            return InternalRequestAsync<DescribeVirusManualScanEstimateTimeoutResponse>(req, "DescribeVirusManualScanEstimateTimeout")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the real-time monitoring settings of virus scanning at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusMonitorSettingRequest"/></param>
        /// <returns><see cref="DescribeVirusMonitorSettingResponse"/></returns>
        public Task<DescribeVirusMonitorSettingResponse> DescribeVirusMonitorSetting(DescribeVirusMonitorSettingRequest req)
        {
            return InternalRequestAsync<DescribeVirusMonitorSettingResponse>(req, "DescribeVirusMonitorSetting");
        }

        /// <summary>
        /// This API is used to query the real-time monitoring settings of virus scanning at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusMonitorSettingRequest"/></param>
        /// <returns><see cref="DescribeVirusMonitorSettingResponse"/></returns>
        public DescribeVirusMonitorSettingResponse DescribeVirusMonitorSettingSync(DescribeVirusMonitorSettingRequest req)
        {
            return InternalRequestAsync<DescribeVirusMonitorSettingResponse>(req, "DescribeVirusMonitorSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the download URL of a trojan sample.
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusSampleDownloadUrlRequest"/></param>
        /// <returns><see cref="DescribeVirusSampleDownloadUrlResponse"/></returns>
        public Task<DescribeVirusSampleDownloadUrlResponse> DescribeVirusSampleDownloadUrl(DescribeVirusSampleDownloadUrlRequest req)
        {
            return InternalRequestAsync<DescribeVirusSampleDownloadUrlResponse>(req, "DescribeVirusSampleDownloadUrl");
        }

        /// <summary>
        /// This API is used to query the download URL of a trojan sample.
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusSampleDownloadUrlRequest"/></param>
        /// <returns><see cref="DescribeVirusSampleDownloadUrlResponse"/></returns>
        public DescribeVirusSampleDownloadUrlResponse DescribeVirusSampleDownloadUrlSync(DescribeVirusSampleDownloadUrlRequest req)
        {
            return InternalRequestAsync<DescribeVirusSampleDownloadUrlResponse>(req, "DescribeVirusSampleDownloadUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query virus scanning settings at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusScanSettingRequest"/></param>
        /// <returns><see cref="DescribeVirusScanSettingResponse"/></returns>
        public Task<DescribeVirusScanSettingResponse> DescribeVirusScanSetting(DescribeVirusScanSettingRequest req)
        {
            return InternalRequestAsync<DescribeVirusScanSettingResponse>(req, "DescribeVirusScanSetting");
        }

        /// <summary>
        /// This API is used to query virus scanning settings at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusScanSettingRequest"/></param>
        /// <returns><see cref="DescribeVirusScanSettingResponse"/></returns>
        public DescribeVirusScanSettingResponse DescribeVirusScanSettingSync(DescribeVirusScanSettingRequest req)
        {
            return InternalRequestAsync<DescribeVirusScanSettingResponse>(req, "DescribeVirusScanSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the status of a virus scanning task at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusScanTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeVirusScanTaskStatusResponse"/></returns>
        public Task<DescribeVirusScanTaskStatusResponse> DescribeVirusScanTaskStatus(DescribeVirusScanTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeVirusScanTaskStatusResponse>(req, "DescribeVirusScanTaskStatus");
        }

        /// <summary>
        /// This API is used to query the status of a virus scanning task at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusScanTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeVirusScanTaskStatusResponse"/></returns>
        public DescribeVirusScanTaskStatusResponse DescribeVirusScanTaskStatusSync(DescribeVirusScanTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeVirusScanTaskStatusResponse>(req, "DescribeVirusScanTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the timeout settings of a file scan at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusScanTimeoutSettingRequest"/></param>
        /// <returns><see cref="DescribeVirusScanTimeoutSettingResponse"/></returns>
        public Task<DescribeVirusScanTimeoutSettingResponse> DescribeVirusScanTimeoutSetting(DescribeVirusScanTimeoutSettingRequest req)
        {
            return InternalRequestAsync<DescribeVirusScanTimeoutSettingResponse>(req, "DescribeVirusScanTimeoutSetting");
        }

        /// <summary>
        /// This API is used to query the timeout settings of a file scan at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusScanTimeoutSettingRequest"/></param>
        /// <returns><see cref="DescribeVirusScanTimeoutSettingResponse"/></returns>
        public DescribeVirusScanTimeoutSettingResponse DescribeVirusScanTimeoutSettingSync(DescribeVirusScanTimeoutSettingRequest req)
        {
            return InternalRequestAsync<DescribeVirusScanTimeoutSettingResponse>(req, "DescribeVirusScanTimeoutSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the trojan overview at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusSummaryRequest"/></param>
        /// <returns><see cref="DescribeVirusSummaryResponse"/></returns>
        public Task<DescribeVirusSummaryResponse> DescribeVirusSummary(DescribeVirusSummaryRequest req)
        {
            return InternalRequestAsync<DescribeVirusSummaryResponse>(req, "DescribeVirusSummary");
        }

        /// <summary>
        /// This API is used to query the trojan overview at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusSummaryRequest"/></param>
        /// <returns><see cref="DescribeVirusSummaryResponse"/></returns>
        public DescribeVirusSummaryResponse DescribeVirusSummarySync(DescribeVirusSummaryRequest req)
        {
            return InternalRequestAsync<DescribeVirusSummaryResponse>(req, "DescribeVirusSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of virus scanning tasks at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusTaskListRequest"/></param>
        /// <returns><see cref="DescribeVirusTaskListResponse"/></returns>
        public Task<DescribeVirusTaskListResponse> DescribeVirusTaskList(DescribeVirusTaskListRequest req)
        {
            return InternalRequestAsync<DescribeVirusTaskListResponse>(req, "DescribeVirusTaskList");
        }

        /// <summary>
        /// This API is used to query the list of virus scanning tasks at runtime.
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusTaskListRequest"/></param>
        /// <returns><see cref="DescribeVirusTaskListResponse"/></returns>
        public DescribeVirusTaskListResponse DescribeVirusTaskListSync(DescribeVirusTaskListRequest req)
        {
            return InternalRequestAsync<DescribeVirusTaskListResponse>(req, "DescribeVirusTaskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of containers affected by vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulContainerListRequest"/></param>
        /// <returns><see cref="DescribeVulContainerListResponse"/></returns>
        public Task<DescribeVulContainerListResponse> DescribeVulContainerList(DescribeVulContainerListRequest req)
        {
            return InternalRequestAsync<DescribeVulContainerListResponse>(req, "DescribeVulContainerList");
        }

        /// <summary>
        /// This API is used to query the list of containers affected by vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulContainerListRequest"/></param>
        /// <returns><see cref="DescribeVulContainerListResponse"/></returns>
        public DescribeVulContainerListResponse DescribeVulContainerListSync(DescribeVulContainerListRequest req)
        {
            return InternalRequestAsync<DescribeVulContainerListResponse>(req, "DescribeVulContainerList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of exploit prevention events.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefenceEventRequest"/></param>
        /// <returns><see cref="DescribeVulDefenceEventResponse"/></returns>
        public Task<DescribeVulDefenceEventResponse> DescribeVulDefenceEvent(DescribeVulDefenceEventRequest req)
        {
            return InternalRequestAsync<DescribeVulDefenceEventResponse>(req, "DescribeVulDefenceEvent");
        }

        /// <summary>
        /// This API is used to query the list of exploit prevention events.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefenceEventRequest"/></param>
        /// <returns><see cref="DescribeVulDefenceEventResponse"/></returns>
        public DescribeVulDefenceEventResponse DescribeVulDefenceEventSync(DescribeVulDefenceEventRequest req)
        {
            return InternalRequestAsync<DescribeVulDefenceEventResponse>(req, "DescribeVulDefenceEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of an exploit prevention event.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefenceEventDetailRequest"/></param>
        /// <returns><see cref="DescribeVulDefenceEventDetailResponse"/></returns>
        public Task<DescribeVulDefenceEventDetailResponse> DescribeVulDefenceEventDetail(DescribeVulDefenceEventDetailRequest req)
        {
            return InternalRequestAsync<DescribeVulDefenceEventDetailResponse>(req, "DescribeVulDefenceEventDetail");
        }

        /// <summary>
        /// This API is used to query the details of an exploit prevention event.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefenceEventDetailRequest"/></param>
        /// <returns><see cref="DescribeVulDefenceEventDetailResponse"/></returns>
        public DescribeVulDefenceEventDetailResponse DescribeVulDefenceEventDetailSync(DescribeVulDefenceEventDetailRequest req)
        {
            return InternalRequestAsync<DescribeVulDefenceEventDetailResponse>(req, "DescribeVulDefenceEventDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the trend of exploit prevention events.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefenceEventTendencyRequest"/></param>
        /// <returns><see cref="DescribeVulDefenceEventTendencyResponse"/></returns>
        public Task<DescribeVulDefenceEventTendencyResponse> DescribeVulDefenceEventTendency(DescribeVulDefenceEventTendencyRequest req)
        {
            return InternalRequestAsync<DescribeVulDefenceEventTendencyResponse>(req, "DescribeVulDefenceEventTendency");
        }

        /// <summary>
        /// This API is used to query the trend of exploit prevention events.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefenceEventTendencyRequest"/></param>
        /// <returns><see cref="DescribeVulDefenceEventTendencyResponse"/></returns>
        public DescribeVulDefenceEventTendencyResponse DescribeVulDefenceEventTendencySync(DescribeVulDefenceEventTendencyRequest req)
        {
            return InternalRequestAsync<DescribeVulDefenceEventTendencyResponse>(req, "DescribeVulDefenceEventTendency")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of servers with exploit prevention enabled.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefenceHostRequest"/></param>
        /// <returns><see cref="DescribeVulDefenceHostResponse"/></returns>
        public Task<DescribeVulDefenceHostResponse> DescribeVulDefenceHost(DescribeVulDefenceHostRequest req)
        {
            return InternalRequestAsync<DescribeVulDefenceHostResponse>(req, "DescribeVulDefenceHost");
        }

        /// <summary>
        /// This API is used to query the list of servers with exploit prevention enabled.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefenceHostRequest"/></param>
        /// <returns><see cref="DescribeVulDefenceHostResponse"/></returns>
        public DescribeVulDefenceHostResponse DescribeVulDefenceHostSync(DescribeVulDefenceHostRequest req)
        {
            return InternalRequestAsync<DescribeVulDefenceHostResponse>(req, "DescribeVulDefenceHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of exploit prevention plugins.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefencePluginRequest"/></param>
        /// <returns><see cref="DescribeVulDefencePluginResponse"/></returns>
        public Task<DescribeVulDefencePluginResponse> DescribeVulDefencePlugin(DescribeVulDefencePluginRequest req)
        {
            return InternalRequestAsync<DescribeVulDefencePluginResponse>(req, "DescribeVulDefencePlugin");
        }

        /// <summary>
        /// This API is used to query the list of exploit prevention plugins.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefencePluginRequest"/></param>
        /// <returns><see cref="DescribeVulDefencePluginResponse"/></returns>
        public DescribeVulDefencePluginResponse DescribeVulDefencePluginSync(DescribeVulDefencePluginRequest req)
        {
            return InternalRequestAsync<DescribeVulDefencePluginResponse>(req, "DescribeVulDefencePlugin")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the exploit prevention settings.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefenceSettingRequest"/></param>
        /// <returns><see cref="DescribeVulDefenceSettingResponse"/></returns>
        public Task<DescribeVulDefenceSettingResponse> DescribeVulDefenceSetting(DescribeVulDefenceSettingRequest req)
        {
            return InternalRequestAsync<DescribeVulDefenceSettingResponse>(req, "DescribeVulDefenceSetting");
        }

        /// <summary>
        /// This API is used to query the exploit prevention settings.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefenceSettingRequest"/></param>
        /// <returns><see cref="DescribeVulDefenceSettingResponse"/></returns>
        public DescribeVulDefenceSettingResponse DescribeVulDefenceSettingSync(DescribeVulDefenceSettingRequest req)
        {
            return InternalRequestAsync<DescribeVulDefenceSettingResponse>(req, "DescribeVulDefenceSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query vulnerability details.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDetailRequest"/></param>
        /// <returns><see cref="DescribeVulDetailResponse"/></returns>
        public Task<DescribeVulDetailResponse> DescribeVulDetail(DescribeVulDetailRequest req)
        {
            return InternalRequestAsync<DescribeVulDetailResponse>(req, "DescribeVulDetail");
        }

        /// <summary>
        /// This API is used to query vulnerability details.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDetailRequest"/></param>
        /// <returns><see cref="DescribeVulDetailResponse"/></returns>
        public DescribeVulDetailResponse DescribeVulDetailSync(DescribeVulDetailRequest req)
        {
            return InternalRequestAsync<DescribeVulDetailResponse>(req, "DescribeVulDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of local images ignored in a vulnerability scan.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulIgnoreLocalImageListRequest"/></param>
        /// <returns><see cref="DescribeVulIgnoreLocalImageListResponse"/></returns>
        public Task<DescribeVulIgnoreLocalImageListResponse> DescribeVulIgnoreLocalImageList(DescribeVulIgnoreLocalImageListRequest req)
        {
            return InternalRequestAsync<DescribeVulIgnoreLocalImageListResponse>(req, "DescribeVulIgnoreLocalImageList");
        }

        /// <summary>
        /// This API is used to query the list of local images ignored in a vulnerability scan.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulIgnoreLocalImageListRequest"/></param>
        /// <returns><see cref="DescribeVulIgnoreLocalImageListResponse"/></returns>
        public DescribeVulIgnoreLocalImageListResponse DescribeVulIgnoreLocalImageListSync(DescribeVulIgnoreLocalImageListRequest req)
        {
            return InternalRequestAsync<DescribeVulIgnoreLocalImageListResponse>(req, "DescribeVulIgnoreLocalImageList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of repository images ignored in a vulnerability scan.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulIgnoreRegistryImageListRequest"/></param>
        /// <returns><see cref="DescribeVulIgnoreRegistryImageListResponse"/></returns>
        public Task<DescribeVulIgnoreRegistryImageListResponse> DescribeVulIgnoreRegistryImageList(DescribeVulIgnoreRegistryImageListRequest req)
        {
            return InternalRequestAsync<DescribeVulIgnoreRegistryImageListResponse>(req, "DescribeVulIgnoreRegistryImageList");
        }

        /// <summary>
        /// This API is used to query the list of repository images ignored in a vulnerability scan.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulIgnoreRegistryImageListRequest"/></param>
        /// <returns><see cref="DescribeVulIgnoreRegistryImageListResponse"/></returns>
        public DescribeVulIgnoreRegistryImageListResponse DescribeVulIgnoreRegistryImageListSync(DescribeVulIgnoreRegistryImageListRequest req)
        {
            return InternalRequestAsync<DescribeVulIgnoreRegistryImageListResponse>(req, "DescribeVulIgnoreRegistryImageList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of images affected by vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulImageListRequest"/></param>
        /// <returns><see cref="DescribeVulImageListResponse"/></returns>
        public Task<DescribeVulImageListResponse> DescribeVulImageList(DescribeVulImageListRequest req)
        {
            return InternalRequestAsync<DescribeVulImageListResponse>(req, "DescribeVulImageList");
        }

        /// <summary>
        /// This API is used to query the list of images affected by vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulImageListRequest"/></param>
        /// <returns><see cref="DescribeVulImageListResponse"/></returns>
        public DescribeVulImageListResponse DescribeVulImageListSync(DescribeVulImageListRequest req)
        {
            return InternalRequestAsync<DescribeVulImageListResponse>(req, "DescribeVulImageList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the statistics of images affected by vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulImageSummaryRequest"/></param>
        /// <returns><see cref="DescribeVulImageSummaryResponse"/></returns>
        public Task<DescribeVulImageSummaryResponse> DescribeVulImageSummary(DescribeVulImageSummaryRequest req)
        {
            return InternalRequestAsync<DescribeVulImageSummaryResponse>(req, "DescribeVulImageSummary");
        }

        /// <summary>
        /// This API is used to query the statistics of images affected by vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulImageSummaryRequest"/></param>
        /// <returns><see cref="DescribeVulImageSummaryResponse"/></returns>
        public DescribeVulImageSummaryResponse DescribeVulImageSummarySync(DescribeVulImageSummaryRequest req)
        {
            return InternalRequestAsync<DescribeVulImageSummaryResponse>(req, "DescribeVulImageSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the numbers of images affected by emergency vulnerabilities at each severity level.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulLevelImageSummaryRequest"/></param>
        /// <returns><see cref="DescribeVulLevelImageSummaryResponse"/></returns>
        public Task<DescribeVulLevelImageSummaryResponse> DescribeVulLevelImageSummary(DescribeVulLevelImageSummaryRequest req)
        {
            return InternalRequestAsync<DescribeVulLevelImageSummaryResponse>(req, "DescribeVulLevelImageSummary");
        }

        /// <summary>
        /// This API is used to query the numbers of images affected by emergency vulnerabilities at each severity level.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulLevelImageSummaryRequest"/></param>
        /// <returns><see cref="DescribeVulLevelImageSummaryResponse"/></returns>
        public DescribeVulLevelImageSummaryResponse DescribeVulLevelImageSummarySync(DescribeVulLevelImageSummaryRequest req)
        {
            return InternalRequestAsync<DescribeVulLevelImageSummaryResponse>(req, "DescribeVulLevelImageSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the numbers of vulnerabilities at each severity level.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulLevelSummaryRequest"/></param>
        /// <returns><see cref="DescribeVulLevelSummaryResponse"/></returns>
        public Task<DescribeVulLevelSummaryResponse> DescribeVulLevelSummary(DescribeVulLevelSummaryRequest req)
        {
            return InternalRequestAsync<DescribeVulLevelSummaryResponse>(req, "DescribeVulLevelSummary");
        }

        /// <summary>
        /// This API is used to query the numbers of vulnerabilities at each severity level.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulLevelSummaryRequest"/></param>
        /// <returns><see cref="DescribeVulLevelSummaryResponse"/></returns>
        public DescribeVulLevelSummaryResponse DescribeVulLevelSummarySync(DescribeVulLevelSummaryRequest req)
        {
            return InternalRequestAsync<DescribeVulLevelSummaryResponse>(req, "DescribeVulLevelSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of repository images affected by vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulRegistryImageListRequest"/></param>
        /// <returns><see cref="DescribeVulRegistryImageListResponse"/></returns>
        public Task<DescribeVulRegistryImageListResponse> DescribeVulRegistryImageList(DescribeVulRegistryImageListRequest req)
        {
            return InternalRequestAsync<DescribeVulRegistryImageListResponse>(req, "DescribeVulRegistryImageList");
        }

        /// <summary>
        /// This API is used to query the list of repository images affected by vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulRegistryImageListRequest"/></param>
        /// <returns><see cref="DescribeVulRegistryImageListResponse"/></returns>
        public DescribeVulRegistryImageListResponse DescribeVulRegistryImageListSync(DescribeVulRegistryImageListRequest req)
        {
            return InternalRequestAsync<DescribeVulRegistryImageListResponse>(req, "DescribeVulRegistryImageList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to count the number of licensed but not scanned images on the vulnerability scanning page.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulScanAuthorizedImageSummaryRequest"/></param>
        /// <returns><see cref="DescribeVulScanAuthorizedImageSummaryResponse"/></returns>
        public Task<DescribeVulScanAuthorizedImageSummaryResponse> DescribeVulScanAuthorizedImageSummary(DescribeVulScanAuthorizedImageSummaryRequest req)
        {
            return InternalRequestAsync<DescribeVulScanAuthorizedImageSummaryResponse>(req, "DescribeVulScanAuthorizedImageSummary");
        }

        /// <summary>
        /// This API is used to count the number of licensed but not scanned images on the vulnerability scanning page.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulScanAuthorizedImageSummaryRequest"/></param>
        /// <returns><see cref="DescribeVulScanAuthorizedImageSummaryResponse"/></returns>
        public DescribeVulScanAuthorizedImageSummaryResponse DescribeVulScanAuthorizedImageSummarySync(DescribeVulScanAuthorizedImageSummaryRequest req)
        {
            return InternalRequestAsync<DescribeVulScanAuthorizedImageSummaryResponse>(req, "DescribeVulScanAuthorizedImageSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of a vulnerability scan task.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulScanInfoRequest"/></param>
        /// <returns><see cref="DescribeVulScanInfoResponse"/></returns>
        public Task<DescribeVulScanInfoResponse> DescribeVulScanInfo(DescribeVulScanInfoRequest req)
        {
            return InternalRequestAsync<DescribeVulScanInfoResponse>(req, "DescribeVulScanInfo");
        }

        /// <summary>
        /// This API is used to query the information of a vulnerability scan task.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulScanInfoRequest"/></param>
        /// <returns><see cref="DescribeVulScanInfoResponse"/></returns>
        public DescribeVulScanInfoResponse DescribeVulScanInfoSync(DescribeVulScanInfoRequest req)
        {
            return InternalRequestAsync<DescribeVulScanInfoResponse>(req, "DescribeVulScanInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of local images in a vulnerability scan task.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulScanLocalImageListRequest"/></param>
        /// <returns><see cref="DescribeVulScanLocalImageListResponse"/></returns>
        public Task<DescribeVulScanLocalImageListResponse> DescribeVulScanLocalImageList(DescribeVulScanLocalImageListRequest req)
        {
            return InternalRequestAsync<DescribeVulScanLocalImageListResponse>(req, "DescribeVulScanLocalImageList");
        }

        /// <summary>
        /// This API is used to query the list of local images in a vulnerability scan task.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulScanLocalImageListRequest"/></param>
        /// <returns><see cref="DescribeVulScanLocalImageListResponse"/></returns>
        public DescribeVulScanLocalImageListResponse DescribeVulScanLocalImageListSync(DescribeVulScanLocalImageListRequest req)
        {
            return InternalRequestAsync<DescribeVulScanLocalImageListResponse>(req, "DescribeVulScanLocalImageList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the overview of vulnerability risks.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulSummaryRequest"/></param>
        /// <returns><see cref="DescribeVulSummaryResponse"/></returns>
        public Task<DescribeVulSummaryResponse> DescribeVulSummary(DescribeVulSummaryRequest req)
        {
            return InternalRequestAsync<DescribeVulSummaryResponse>(req, "DescribeVulSummary");
        }

        /// <summary>
        /// This API is used to query the overview of vulnerability risks.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulSummaryRequest"/></param>
        /// <returns><see cref="DescribeVulSummaryResponse"/></returns>
        public DescribeVulSummaryResponse DescribeVulSummarySync(DescribeVulSummaryRequest req)
        {
            return InternalRequestAsync<DescribeVulSummaryResponse>(req, "DescribeVulSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the trend of critical and high-risk vulnerabilities in local and repository images.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulTendencyRequest"/></param>
        /// <returns><see cref="DescribeVulTendencyResponse"/></returns>
        public Task<DescribeVulTendencyResponse> DescribeVulTendency(DescribeVulTendencyRequest req)
        {
            return InternalRequestAsync<DescribeVulTendencyResponse>(req, "DescribeVulTendency");
        }

        /// <summary>
        /// This API is used to query the trend of critical and high-risk vulnerabilities in local and repository images.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulTendencyRequest"/></param>
        /// <returns><see cref="DescribeVulTendencyResponse"/></returns>
        public DescribeVulTendencyResponse DescribeVulTendencySync(DescribeVulTendencyRequest req)
        {
            return InternalRequestAsync<DescribeVulTendencyResponse>(req, "DescribeVulTendency")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of top vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulTopRankingRequest"/></param>
        /// <returns><see cref="DescribeVulTopRankingResponse"/></returns>
        public Task<DescribeVulTopRankingResponse> DescribeVulTopRanking(DescribeVulTopRankingRequest req)
        {
            return InternalRequestAsync<DescribeVulTopRankingResponse>(req, "DescribeVulTopRanking");
        }

        /// <summary>
        /// This API is used to query the list of top vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulTopRankingRequest"/></param>
        /// <returns><see cref="DescribeVulTopRankingResponse"/></returns>
        public DescribeVulTopRankingResponse DescribeVulTopRankingSync(DescribeVulTopRankingRequest req)
        {
            return InternalRequestAsync<DescribeVulTopRankingResponse>(req, "DescribeVulTopRanking")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of alert policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeWarningRulesRequest"/></param>
        /// <returns><see cref="DescribeWarningRulesResponse"/></returns>
        public Task<DescribeWarningRulesResponse> DescribeWarningRules(DescribeWarningRulesRequest req)
        {
            return InternalRequestAsync<DescribeWarningRulesResponse>(req, "DescribeWarningRules");
        }

        /// <summary>
        /// This API is used to get the list of alert policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeWarningRulesRequest"/></param>
        /// <returns><see cref="DescribeWarningRulesResponse"/></returns>
        public DescribeWarningRulesResponse DescribeWarningRulesSync(DescribeWarningRulesRequest req)
        {
            return InternalRequestAsync<DescribeWarningRulesResponse>(req, "DescribeWarningRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of web application vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebVulListRequest"/></param>
        /// <returns><see cref="DescribeWebVulListResponse"/></returns>
        public Task<DescribeWebVulListResponse> DescribeWebVulList(DescribeWebVulListRequest req)
        {
            return InternalRequestAsync<DescribeWebVulListResponse>(req, "DescribeWebVulList");
        }

        /// <summary>
        /// This API is used to query the list of web application vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebVulListRequest"/></param>
        /// <returns><see cref="DescribeWebVulListResponse"/></returns>
        public DescribeWebVulListResponse DescribeWebVulListSync(DescribeWebVulListRequest req)
        {
            return InternalRequestAsync<DescribeWebVulListResponse>(req, "DescribeWebVulList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the list of virus scanning events at runtime.
        /// </summary>
        /// <param name="req"><see cref="ExportVirusListRequest"/></param>
        /// <returns><see cref="ExportVirusListResponse"/></returns>
        public Task<ExportVirusListResponse> ExportVirusList(ExportVirusListRequest req)
        {
            return InternalRequestAsync<ExportVirusListResponse>(req, "ExportVirusList");
        }

        /// <summary>
        /// This API is used to export the list of virus scanning events at runtime.
        /// </summary>
        /// <param name="req"><see cref="ExportVirusListRequest"/></param>
        /// <returns><see cref="ExportVirusListResponse"/></returns>
        public ExportVirusListResponse ExportVirusListSync(ExportVirusListRequest req)
        {
            return InternalRequestAsync<ExportVirusListResponse>(req, "ExportVirusList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to initialize the compliance baseline environment and create necessary data and options.
        /// </summary>
        /// <param name="req"><see cref="InitializeUserComplianceEnvironmentRequest"/></param>
        /// <returns><see cref="InitializeUserComplianceEnvironmentResponse"/></returns>
        public Task<InitializeUserComplianceEnvironmentResponse> InitializeUserComplianceEnvironment(InitializeUserComplianceEnvironmentRequest req)
        {
            return InternalRequestAsync<InitializeUserComplianceEnvironmentResponse>(req, "InitializeUserComplianceEnvironment");
        }

        /// <summary>
        /// This API is used to initialize the compliance baseline environment and create necessary data and options.
        /// </summary>
        /// <param name="req"><see cref="InitializeUserComplianceEnvironmentRequest"/></param>
        /// <returns><see cref="InitializeUserComplianceEnvironmentResponse"/></returns>
        public InitializeUserComplianceEnvironmentResponse InitializeUserComplianceEnvironmentSync(InitializeUserComplianceEnvironmentRequest req)
        {
            return InternalRequestAsync<InitializeUserComplianceEnvironmentResponse>(req, "InitializeUserComplianceEnvironment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to change the status of an abnormal process policy at runtime.
        /// </summary>
        /// <param name="req"><see cref="ModifyAbnormalProcessRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyAbnormalProcessRuleStatusResponse"/></returns>
        public Task<ModifyAbnormalProcessRuleStatusResponse> ModifyAbnormalProcessRuleStatus(ModifyAbnormalProcessRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyAbnormalProcessRuleStatusResponse>(req, "ModifyAbnormalProcessRuleStatus");
        }

        /// <summary>
        /// This API is used to change the status of an abnormal process policy at runtime.
        /// </summary>
        /// <param name="req"><see cref="ModifyAbnormalProcessRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyAbnormalProcessRuleStatusResponse"/></returns>
        public ModifyAbnormalProcessRuleStatusResponse ModifyAbnormalProcessRuleStatusSync(ModifyAbnormalProcessRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyAbnormalProcessRuleStatusResponse>(req, "ModifyAbnormalProcessRuleStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to change the status of an abnormal process event.
        /// </summary>
        /// <param name="req"><see cref="ModifyAbnormalProcessStatusRequest"/></param>
        /// <returns><see cref="ModifyAbnormalProcessStatusResponse"/></returns>
        public Task<ModifyAbnormalProcessStatusResponse> ModifyAbnormalProcessStatus(ModifyAbnormalProcessStatusRequest req)
        {
            return InternalRequestAsync<ModifyAbnormalProcessStatusResponse>(req, "ModifyAbnormalProcessStatus");
        }

        /// <summary>
        /// This API is used to change the status of an abnormal process event.
        /// </summary>
        /// <param name="req"><see cref="ModifyAbnormalProcessStatusRequest"/></param>
        /// <returns><see cref="ModifyAbnormalProcessStatusResponse"/></returns>
        public ModifyAbnormalProcessStatusResponse ModifyAbnormalProcessStatusSync(ModifyAbnormalProcessStatusRequest req)
        {
            return InternalRequestAsync<ModifyAbnormalProcessStatusResponse>(req, "ModifyAbnormalProcessStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to change the status of an access control policy at runtime, i.e., enable or disable it.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccessControlRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyAccessControlRuleStatusResponse"/></returns>
        public Task<ModifyAccessControlRuleStatusResponse> ModifyAccessControlRuleStatus(ModifyAccessControlRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyAccessControlRuleStatusResponse>(req, "ModifyAccessControlRuleStatus");
        }

        /// <summary>
        /// This API is used to change the status of an access control policy at runtime, i.e., enable or disable it.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccessControlRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyAccessControlRuleStatusResponse"/></returns>
        public ModifyAccessControlRuleStatusResponse ModifyAccessControlRuleStatusSync(ModifyAccessControlRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyAccessControlRuleStatusResponse>(req, "ModifyAccessControlRuleStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to change the status of an access control event at runtime.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccessControlStatusRequest"/></param>
        /// <returns><see cref="ModifyAccessControlStatusResponse"/></returns>
        public Task<ModifyAccessControlStatusResponse> ModifyAccessControlStatus(ModifyAccessControlStatusRequest req)
        {
            return InternalRequestAsync<ModifyAccessControlStatusResponse>(req, "ModifyAccessControlStatus");
        }

        /// <summary>
        /// This API is used to change the status of an access control event at runtime.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccessControlStatusRequest"/></param>
        /// <returns><see cref="ModifyAccessControlStatusResponse"/></returns>
        public ModifyAccessControlStatusResponse ModifyAccessControlStatusSync(ModifyAccessControlStatusRequest req)
        {
            return InternalRequestAsync<ModifyAccessControlStatusResponse>(req, "ModifyAccessControlStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to refresh server assets.
        /// </summary>
        /// <param name="req"><see cref="ModifyAssetRequest"/></param>
        /// <returns><see cref="ModifyAssetResponse"/></returns>
        public Task<ModifyAssetResponse> ModifyAsset(ModifyAssetRequest req)
        {
            return InternalRequestAsync<ModifyAssetResponse>(req, "ModifyAsset");
        }

        /// <summary>
        /// This API is used to refresh server assets.
        /// </summary>
        /// <param name="req"><see cref="ModifyAssetRequest"/></param>
        /// <returns><see cref="ModifyAssetResponse"/></returns>
        public ModifyAssetResponse ModifyAssetSync(ModifyAssetRequest req)
        {
            return InternalRequestAsync<ModifyAssetResponse>(req, "ModifyAsset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to stop an image scan task for an image repository.
        /// </summary>
        /// <param name="req"><see cref="ModifyAssetImageRegistryScanStopRequest"/></param>
        /// <returns><see cref="ModifyAssetImageRegistryScanStopResponse"/></returns>
        public Task<ModifyAssetImageRegistryScanStopResponse> ModifyAssetImageRegistryScanStop(ModifyAssetImageRegistryScanStopRequest req)
        {
            return InternalRequestAsync<ModifyAssetImageRegistryScanStopResponse>(req, "ModifyAssetImageRegistryScanStop");
        }

        /// <summary>
        /// This API is used to stop an image scan task for an image repository.
        /// </summary>
        /// <param name="req"><see cref="ModifyAssetImageRegistryScanStopRequest"/></param>
        /// <returns><see cref="ModifyAssetImageRegistryScanStopResponse"/></returns>
        public ModifyAssetImageRegistryScanStopResponse ModifyAssetImageRegistryScanStopSync(ModifyAssetImageRegistryScanStopRequest req)
        {
            return InternalRequestAsync<ModifyAssetImageRegistryScanStopResponse>(req, "ModifyAssetImageRegistryScanStop")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to stop a quick image scan task for an image repository.
        /// </summary>
        /// <param name="req"><see cref="ModifyAssetImageRegistryScanStopOneKeyRequest"/></param>
        /// <returns><see cref="ModifyAssetImageRegistryScanStopOneKeyResponse"/></returns>
        public Task<ModifyAssetImageRegistryScanStopOneKeyResponse> ModifyAssetImageRegistryScanStopOneKey(ModifyAssetImageRegistryScanStopOneKeyRequest req)
        {
            return InternalRequestAsync<ModifyAssetImageRegistryScanStopOneKeyResponse>(req, "ModifyAssetImageRegistryScanStopOneKey");
        }

        /// <summary>
        /// This API is used to stop a quick image scan task for an image repository.
        /// </summary>
        /// <param name="req"><see cref="ModifyAssetImageRegistryScanStopOneKeyRequest"/></param>
        /// <returns><see cref="ModifyAssetImageRegistryScanStopOneKeyResponse"/></returns>
        public ModifyAssetImageRegistryScanStopOneKeyResponse ModifyAssetImageRegistryScanStopOneKeySync(ModifyAssetImageRegistryScanStopOneKeyRequest req)
        {
            return InternalRequestAsync<ModifyAssetImageRegistryScanStopOneKeyResponse>(req, "ModifyAssetImageRegistryScanStopOneKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to stop an image scan.
        /// </summary>
        /// <param name="req"><see cref="ModifyAssetImageScanStopRequest"/></param>
        /// <returns><see cref="ModifyAssetImageScanStopResponse"/></returns>
        public Task<ModifyAssetImageScanStopResponse> ModifyAssetImageScanStop(ModifyAssetImageScanStopRequest req)
        {
            return InternalRequestAsync<ModifyAssetImageScanStopResponse>(req, "ModifyAssetImageScanStop");
        }

        /// <summary>
        /// This API is used to stop an image scan.
        /// </summary>
        /// <param name="req"><see cref="ModifyAssetImageScanStopRequest"/></param>
        /// <returns><see cref="ModifyAssetImageScanStopResponse"/></returns>
        public ModifyAssetImageScanStopResponse ModifyAssetImageScanStopSync(ModifyAssetImageScanStopRequest req)
        {
            return InternalRequestAsync<ModifyAssetImageScanStopResponse>(req, "ModifyAssetImageScanStop")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the settings of a scheduled task, including the check cycle and the status of the compliance benchmark.
        /// </summary>
        /// <param name="req"><see cref="ModifyCompliancePeriodTaskRequest"/></param>
        /// <returns><see cref="ModifyCompliancePeriodTaskResponse"/></returns>
        public Task<ModifyCompliancePeriodTaskResponse> ModifyCompliancePeriodTask(ModifyCompliancePeriodTaskRequest req)
        {
            return InternalRequestAsync<ModifyCompliancePeriodTaskResponse>(req, "ModifyCompliancePeriodTask");
        }

        /// <summary>
        /// This API is used to modify the settings of a scheduled task, including the check cycle and the status of the compliance benchmark.
        /// </summary>
        /// <param name="req"><see cref="ModifyCompliancePeriodTaskRequest"/></param>
        /// <returns><see cref="ModifyCompliancePeriodTaskResponse"/></returns>
        public ModifyCompliancePeriodTaskResponse ModifyCompliancePeriodTaskSync(ModifyCompliancePeriodTaskRequest req)
        {
            return InternalRequestAsync<ModifyCompliancePeriodTaskResponse>(req, "ModifyCompliancePeriodTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to isolate a container.
        /// </summary>
        /// <param name="req"><see cref="ModifyContainerNetStatusRequest"/></param>
        /// <returns><see cref="ModifyContainerNetStatusResponse"/></returns>
        public Task<ModifyContainerNetStatusResponse> ModifyContainerNetStatus(ModifyContainerNetStatusRequest req)
        {
            return InternalRequestAsync<ModifyContainerNetStatusResponse>(req, "ModifyContainerNetStatus");
        }

        /// <summary>
        /// This API is used to isolate a container.
        /// </summary>
        /// <param name="req"><see cref="ModifyContainerNetStatusRequest"/></param>
        /// <returns><see cref="ModifyContainerNetStatusResponse"/></returns>
        public ModifyContainerNetStatusResponse ModifyContainerNetStatusSync(ModifyContainerNetStatusRequest req)
        {
            return InternalRequestAsync<ModifyContainerNetStatusResponse>(req, "ModifyContainerNetStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to change the status of a container escape scan event.
        /// </summary>
        /// <param name="req"><see cref="ModifyEscapeEventStatusRequest"/></param>
        /// <returns><see cref="ModifyEscapeEventStatusResponse"/></returns>
        public Task<ModifyEscapeEventStatusResponse> ModifyEscapeEventStatus(ModifyEscapeEventStatusRequest req)
        {
            return InternalRequestAsync<ModifyEscapeEventStatusResponse>(req, "ModifyEscapeEventStatus");
        }

        /// <summary>
        /// This API is used to change the status of a container escape scan event.
        /// </summary>
        /// <param name="req"><see cref="ModifyEscapeEventStatusRequest"/></param>
        /// <returns><see cref="ModifyEscapeEventStatusResponse"/></returns>
        public ModifyEscapeEventStatusResponse ModifyEscapeEventStatusSync(ModifyEscapeEventStatusRequest req)
        {
            return InternalRequestAsync<ModifyEscapeEventStatusResponse>(req, "ModifyEscapeEventStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the information of a container escape scan rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyEscapeRuleRequest"/></param>
        /// <returns><see cref="ModifyEscapeRuleResponse"/></returns>
        public Task<ModifyEscapeRuleResponse> ModifyEscapeRule(ModifyEscapeRuleRequest req)
        {
            return InternalRequestAsync<ModifyEscapeRuleResponse>(req, "ModifyEscapeRule");
        }

        /// <summary>
        /// This API is used to modify the information of a container escape scan rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyEscapeRuleRequest"/></param>
        /// <returns><see cref="ModifyEscapeRuleResponse"/></returns>
        public ModifyEscapeRuleResponse ModifyEscapeRuleSync(ModifyEscapeRuleRequest req)
        {
            return InternalRequestAsync<ModifyEscapeRuleResponse>(req, "ModifyEscapeRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify an allowed escape.
        /// </summary>
        /// <param name="req"><see cref="ModifyEscapeWhiteListRequest"/></param>
        /// <returns><see cref="ModifyEscapeWhiteListResponse"/></returns>
        public Task<ModifyEscapeWhiteListResponse> ModifyEscapeWhiteList(ModifyEscapeWhiteListRequest req)
        {
            return InternalRequestAsync<ModifyEscapeWhiteListResponse>(req, "ModifyEscapeWhiteList");
        }

        /// <summary>
        /// This API is used to modify an allowed escape.
        /// </summary>
        /// <param name="req"><see cref="ModifyEscapeWhiteListRequest"/></param>
        /// <returns><see cref="ModifyEscapeWhiteListResponse"/></returns>
        public ModifyEscapeWhiteListResponse ModifyEscapeWhiteListSync(ModifyEscapeWhiteListRequest req)
        {
            return InternalRequestAsync<ModifyEscapeWhiteListResponse>(req, "ModifyEscapeWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch license images to be scanned (v2.0).
        /// </summary>
        /// <param name="req"><see cref="ModifyImageAuthorizedRequest"/></param>
        /// <returns><see cref="ModifyImageAuthorizedResponse"/></returns>
        public Task<ModifyImageAuthorizedResponse> ModifyImageAuthorized(ModifyImageAuthorizedRequest req)
        {
            return InternalRequestAsync<ModifyImageAuthorizedResponse>(req, "ModifyImageAuthorized");
        }

        /// <summary>
        /// This API is used to batch license images to be scanned (v2.0).
        /// </summary>
        /// <param name="req"><see cref="ModifyImageAuthorizedRequest"/></param>
        /// <returns><see cref="ModifyImageAuthorizedResponse"/></returns>
        public ModifyImageAuthorizedResponse ModifyImageAuthorizedSync(ModifyImageAuthorizedRequest req)
        {
            return InternalRequestAsync<ModifyImageAuthorizedResponse>(req, "ModifyImageAuthorized")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the status of K8sApi exception events.
        /// </summary>
        /// <param name="req"><see cref="ModifyK8sApiAbnormalEventStatusRequest"/></param>
        /// <returns><see cref="ModifyK8sApiAbnormalEventStatusResponse"/></returns>
        public Task<ModifyK8sApiAbnormalEventStatusResponse> ModifyK8sApiAbnormalEventStatus(ModifyK8sApiAbnormalEventStatusRequest req)
        {
            return InternalRequestAsync<ModifyK8sApiAbnormalEventStatusResponse>(req, "ModifyK8sApiAbnormalEventStatus");
        }

        /// <summary>
        /// This API is used to modify the status of K8sApi exception events.
        /// </summary>
        /// <param name="req"><see cref="ModifyK8sApiAbnormalEventStatusRequest"/></param>
        /// <returns><see cref="ModifyK8sApiAbnormalEventStatusResponse"/></returns>
        public ModifyK8sApiAbnormalEventStatusResponse ModifyK8sApiAbnormalEventStatusSync(ModifyK8sApiAbnormalEventStatusRequest req)
        {
            return InternalRequestAsync<ModifyK8sApiAbnormalEventStatusResponse>(req, "ModifyK8sApiAbnormalEventStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the information of K8sApi abnormal rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyK8sApiAbnormalRuleInfoRequest"/></param>
        /// <returns><see cref="ModifyK8sApiAbnormalRuleInfoResponse"/></returns>
        public Task<ModifyK8sApiAbnormalRuleInfoResponse> ModifyK8sApiAbnormalRuleInfo(ModifyK8sApiAbnormalRuleInfoRequest req)
        {
            return InternalRequestAsync<ModifyK8sApiAbnormalRuleInfoResponse>(req, "ModifyK8sApiAbnormalRuleInfo");
        }

        /// <summary>
        /// This API is used to modify the information of K8sApi abnormal rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyK8sApiAbnormalRuleInfoRequest"/></param>
        /// <returns><see cref="ModifyK8sApiAbnormalRuleInfoResponse"/></returns>
        public ModifyK8sApiAbnormalRuleInfoResponse ModifyK8sApiAbnormalRuleInfoSync(ModifyK8sApiAbnormalRuleInfoRequest req)
        {
            return InternalRequestAsync<ModifyK8sApiAbnormalRuleInfoResponse>(req, "ModifyK8sApiAbnormalRuleInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the status of K8sApi abnormal event rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyK8sApiAbnormalRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyK8sApiAbnormalRuleStatusResponse"/></returns>
        public Task<ModifyK8sApiAbnormalRuleStatusResponse> ModifyK8sApiAbnormalRuleStatus(ModifyK8sApiAbnormalRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyK8sApiAbnormalRuleStatusResponse>(req, "ModifyK8sApiAbnormalRuleStatus");
        }

        /// <summary>
        /// This API is used to modify the status of K8sApi abnormal event rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyK8sApiAbnormalRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyK8sApiAbnormalRuleStatusResponse"/></returns>
        public ModifyK8sApiAbnormalRuleStatusResponse ModifyK8sApiAbnormalRuleStatusSync(ModifyK8sApiAbnormalRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyK8sApiAbnormalRuleStatusResponse>(req, "ModifyK8sApiAbnormalRuleStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to change the status of a reverse shell event.
        /// </summary>
        /// <param name="req"><see cref="ModifyReverseShellStatusRequest"/></param>
        /// <returns><see cref="ModifyReverseShellStatusResponse"/></returns>
        public Task<ModifyReverseShellStatusResponse> ModifyReverseShellStatus(ModifyReverseShellStatusRequest req)
        {
            return InternalRequestAsync<ModifyReverseShellStatusResponse>(req, "ModifyReverseShellStatus");
        }

        /// <summary>
        /// This API is used to change the status of a reverse shell event.
        /// </summary>
        /// <param name="req"><see cref="ModifyReverseShellStatusRequest"/></param>
        /// <returns><see cref="ModifyReverseShellStatusResponse"/></returns>
        public ModifyReverseShellStatusResponse ModifyReverseShellStatusSync(ModifyReverseShellStatusRequest req)
        {
            return InternalRequestAsync<ModifyReverseShellStatusResponse>(req, "ModifyReverseShellStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to change the status of a high-risk syscall event.
        /// </summary>
        /// <param name="req"><see cref="ModifyRiskSyscallStatusRequest"/></param>
        /// <returns><see cref="ModifyRiskSyscallStatusResponse"/></returns>
        public Task<ModifyRiskSyscallStatusResponse> ModifyRiskSyscallStatus(ModifyRiskSyscallStatusRequest req)
        {
            return InternalRequestAsync<ModifyRiskSyscallStatusResponse>(req, "ModifyRiskSyscallStatus");
        }

        /// <summary>
        /// This API is used to change the status of a high-risk syscall event.
        /// </summary>
        /// <param name="req"><see cref="ModifyRiskSyscallStatusRequest"/></param>
        /// <returns><see cref="ModifyRiskSyscallStatusResponse"/></returns>
        public ModifyRiskSyscallStatusResponse ModifyRiskSyscallStatusSync(ModifyRiskSyscallStatusRequest req)
        {
            return InternalRequestAsync<ModifyRiskSyscallStatusResponse>(req, "ModifyRiskSyscallStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the settings of security log cleanup.
        /// </summary>
        /// <param name="req"><see cref="ModifySecLogCleanSettingInfoRequest"/></param>
        /// <returns><see cref="ModifySecLogCleanSettingInfoResponse"/></returns>
        public Task<ModifySecLogCleanSettingInfoResponse> ModifySecLogCleanSettingInfo(ModifySecLogCleanSettingInfoRequest req)
        {
            return InternalRequestAsync<ModifySecLogCleanSettingInfoResponse>(req, "ModifySecLogCleanSettingInfo");
        }

        /// <summary>
        /// This API is used to modify the settings of security log cleanup.
        /// </summary>
        /// <param name="req"><see cref="ModifySecLogCleanSettingInfoRequest"/></param>
        /// <returns><see cref="ModifySecLogCleanSettingInfoResponse"/></returns>
        public ModifySecLogCleanSettingInfoResponse ModifySecLogCleanSettingInfoSync(ModifySecLogCleanSettingInfoRequest req)
        {
            return InternalRequestAsync<ModifySecLogCleanSettingInfoResponse>(req, "ModifySecLogCleanSettingInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the configuration of security log delivery to CLS.
        /// </summary>
        /// <param name="req"><see cref="ModifySecLogDeliveryClsSettingRequest"/></param>
        /// <returns><see cref="ModifySecLogDeliveryClsSettingResponse"/></returns>
        public Task<ModifySecLogDeliveryClsSettingResponse> ModifySecLogDeliveryClsSetting(ModifySecLogDeliveryClsSettingRequest req)
        {
            return InternalRequestAsync<ModifySecLogDeliveryClsSettingResponse>(req, "ModifySecLogDeliveryClsSetting");
        }

        /// <summary>
        /// This API is used to update the configuration of security log delivery to CLS.
        /// </summary>
        /// <param name="req"><see cref="ModifySecLogDeliveryClsSettingRequest"/></param>
        /// <returns><see cref="ModifySecLogDeliveryClsSettingResponse"/></returns>
        public ModifySecLogDeliveryClsSettingResponse ModifySecLogDeliveryClsSettingSync(ModifySecLogDeliveryClsSettingRequest req)
        {
            return InternalRequestAsync<ModifySecLogDeliveryClsSettingResponse>(req, "ModifySecLogDeliveryClsSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the settings of security log delivery to Kafka.
        /// </summary>
        /// <param name="req"><see cref="ModifySecLogDeliveryKafkaSettingRequest"/></param>
        /// <returns><see cref="ModifySecLogDeliveryKafkaSettingResponse"/></returns>
        public Task<ModifySecLogDeliveryKafkaSettingResponse> ModifySecLogDeliveryKafkaSetting(ModifySecLogDeliveryKafkaSettingRequest req)
        {
            return InternalRequestAsync<ModifySecLogDeliveryKafkaSettingResponse>(req, "ModifySecLogDeliveryKafkaSetting");
        }

        /// <summary>
        /// This API is used to update the settings of security log delivery to Kafka.
        /// </summary>
        /// <param name="req"><see cref="ModifySecLogDeliveryKafkaSettingRequest"/></param>
        /// <returns><see cref="ModifySecLogDeliveryKafkaSettingResponse"/></returns>
        public ModifySecLogDeliveryKafkaSettingResponse ModifySecLogDeliveryKafkaSettingSync(ModifySecLogDeliveryKafkaSettingRequest req)
        {
            return InternalRequestAsync<ModifySecLogDeliveryKafkaSettingResponse>(req, "ModifySecLogDeliveryKafkaSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify an accessed security log object.
        /// </summary>
        /// <param name="req"><see cref="ModifySecLogJoinObjectsRequest"/></param>
        /// <returns><see cref="ModifySecLogJoinObjectsResponse"/></returns>
        public Task<ModifySecLogJoinObjectsResponse> ModifySecLogJoinObjects(ModifySecLogJoinObjectsRequest req)
        {
            return InternalRequestAsync<ModifySecLogJoinObjectsResponse>(req, "ModifySecLogJoinObjects");
        }

        /// <summary>
        /// This API is used to modify an accessed security log object.
        /// </summary>
        /// <param name="req"><see cref="ModifySecLogJoinObjectsRequest"/></param>
        /// <returns><see cref="ModifySecLogJoinObjectsResponse"/></returns>
        public ModifySecLogJoinObjectsResponse ModifySecLogJoinObjectsSync(ModifySecLogJoinObjectsRequest req)
        {
            return InternalRequestAsync<ModifySecLogJoinObjectsResponse>(req, "ModifySecLogJoinObjects")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to change the security log access status.
        /// </summary>
        /// <param name="req"><see cref="ModifySecLogJoinStateRequest"/></param>
        /// <returns><see cref="ModifySecLogJoinStateResponse"/></returns>
        public Task<ModifySecLogJoinStateResponse> ModifySecLogJoinState(ModifySecLogJoinStateRequest req)
        {
            return InternalRequestAsync<ModifySecLogJoinStateResponse>(req, "ModifySecLogJoinState");
        }

        /// <summary>
        /// This API is used to change the security log access status.
        /// </summary>
        /// <param name="req"><see cref="ModifySecLogJoinStateRequest"/></param>
        /// <returns><see cref="ModifySecLogJoinStateResponse"/></returns>
        public ModifySecLogJoinStateResponse ModifySecLogJoinStateSync(ModifySecLogJoinStateRequest req)
        {
            return InternalRequestAsync<ModifySecLogJoinStateResponse>(req, "ModifySecLogJoinState")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the UIN of a Kafka security log.
        /// </summary>
        /// <param name="req"><see cref="ModifySecLogKafkaUINRequest"/></param>
        /// <returns><see cref="ModifySecLogKafkaUINResponse"/></returns>
        public Task<ModifySecLogKafkaUINResponse> ModifySecLogKafkaUIN(ModifySecLogKafkaUINRequest req)
        {
            return InternalRequestAsync<ModifySecLogKafkaUINResponse>(req, "ModifySecLogKafkaUIN");
        }

        /// <summary>
        /// This API is used to modify the UIN of a Kafka security log.
        /// </summary>
        /// <param name="req"><see cref="ModifySecLogKafkaUINRequest"/></param>
        /// <returns><see cref="ModifySecLogKafkaUINResponse"/></returns>
        public ModifySecLogKafkaUINResponse ModifySecLogKafkaUINSync(ModifySecLogKafkaUINRequest req)
        {
            return InternalRequestAsync<ModifySecLogKafkaUINResponse>(req, "ModifySecLogKafkaUIN")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable/disable automatic trojan sample isolation.
        /// </summary>
        /// <param name="req"><see cref="ModifyVirusAutoIsolateExampleSwitchRequest"/></param>
        /// <returns><see cref="ModifyVirusAutoIsolateExampleSwitchResponse"/></returns>
        public Task<ModifyVirusAutoIsolateExampleSwitchResponse> ModifyVirusAutoIsolateExampleSwitch(ModifyVirusAutoIsolateExampleSwitchRequest req)
        {
            return InternalRequestAsync<ModifyVirusAutoIsolateExampleSwitchResponse>(req, "ModifyVirusAutoIsolateExampleSwitch");
        }

        /// <summary>
        /// This API is used to enable/disable automatic trojan sample isolation.
        /// </summary>
        /// <param name="req"><see cref="ModifyVirusAutoIsolateExampleSwitchRequest"/></param>
        /// <returns><see cref="ModifyVirusAutoIsolateExampleSwitchResponse"/></returns>
        public ModifyVirusAutoIsolateExampleSwitchResponse ModifyVirusAutoIsolateExampleSwitchSync(ModifyVirusAutoIsolateExampleSwitchRequest req)
        {
            return InternalRequestAsync<ModifyVirusAutoIsolateExampleSwitchResponse>(req, "ModifyVirusAutoIsolateExampleSwitch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the settings of automatic trojan isolation.
        /// </summary>
        /// <param name="req"><see cref="ModifyVirusAutoIsolateSettingRequest"/></param>
        /// <returns><see cref="ModifyVirusAutoIsolateSettingResponse"/></returns>
        public Task<ModifyVirusAutoIsolateSettingResponse> ModifyVirusAutoIsolateSetting(ModifyVirusAutoIsolateSettingRequest req)
        {
            return InternalRequestAsync<ModifyVirusAutoIsolateSettingResponse>(req, "ModifyVirusAutoIsolateSetting");
        }

        /// <summary>
        /// This API is used to modify the settings of automatic trojan isolation.
        /// </summary>
        /// <param name="req"><see cref="ModifyVirusAutoIsolateSettingRequest"/></param>
        /// <returns><see cref="ModifyVirusAutoIsolateSettingResponse"/></returns>
        public ModifyVirusAutoIsolateSettingResponse ModifyVirusAutoIsolateSettingSync(ModifyVirusAutoIsolateSettingRequest req)
        {
            return InternalRequestAsync<ModifyVirusAutoIsolateSettingResponse>(req, "ModifyVirusAutoIsolateSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the status of a trojan file at runtime.
        /// </summary>
        /// <param name="req"><see cref="ModifyVirusFileStatusRequest"/></param>
        /// <returns><see cref="ModifyVirusFileStatusResponse"/></returns>
        public Task<ModifyVirusFileStatusResponse> ModifyVirusFileStatus(ModifyVirusFileStatusRequest req)
        {
            return InternalRequestAsync<ModifyVirusFileStatusResponse>(req, "ModifyVirusFileStatus");
        }

        /// <summary>
        /// This API is used to update the status of a trojan file at runtime.
        /// </summary>
        /// <param name="req"><see cref="ModifyVirusFileStatusRequest"/></param>
        /// <returns><see cref="ModifyVirusFileStatusResponse"/></returns>
        public ModifyVirusFileStatusResponse ModifyVirusFileStatusSync(ModifyVirusFileStatusRequest req)
        {
            return InternalRequestAsync<ModifyVirusFileStatusResponse>(req, "ModifyVirusFileStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the real-time monitoring settings of virus scanning at runtime.
        /// </summary>
        /// <param name="req"><see cref="ModifyVirusMonitorSettingRequest"/></param>
        /// <returns><see cref="ModifyVirusMonitorSettingResponse"/></returns>
        public Task<ModifyVirusMonitorSettingResponse> ModifyVirusMonitorSetting(ModifyVirusMonitorSettingRequest req)
        {
            return InternalRequestAsync<ModifyVirusMonitorSettingResponse>(req, "ModifyVirusMonitorSetting");
        }

        /// <summary>
        /// This API is used to update the real-time monitoring settings of virus scanning at runtime.
        /// </summary>
        /// <param name="req"><see cref="ModifyVirusMonitorSettingRequest"/></param>
        /// <returns><see cref="ModifyVirusMonitorSettingResponse"/></returns>
        public ModifyVirusMonitorSettingResponse ModifyVirusMonitorSettingSync(ModifyVirusMonitorSettingRequest req)
        {
            return InternalRequestAsync<ModifyVirusMonitorSettingResponse>(req, "ModifyVirusMonitorSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update virus scanning settings at runtime.
        /// </summary>
        /// <param name="req"><see cref="ModifyVirusScanSettingRequest"/></param>
        /// <returns><see cref="ModifyVirusScanSettingResponse"/></returns>
        public Task<ModifyVirusScanSettingResponse> ModifyVirusScanSetting(ModifyVirusScanSettingRequest req)
        {
            return InternalRequestAsync<ModifyVirusScanSettingResponse>(req, "ModifyVirusScanSetting");
        }

        /// <summary>
        /// This API is used to update virus scanning settings at runtime.
        /// </summary>
        /// <param name="req"><see cref="ModifyVirusScanSettingRequest"/></param>
        /// <returns><see cref="ModifyVirusScanSettingResponse"/></returns>
        public ModifyVirusScanSettingResponse ModifyVirusScanSettingSync(ModifyVirusScanSettingRequest req)
        {
            return InternalRequestAsync<ModifyVirusScanSettingResponse>(req, "ModifyVirusScanSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the timeout settings of a file scan at runtime.
        /// </summary>
        /// <param name="req"><see cref="ModifyVirusScanTimeoutSettingRequest"/></param>
        /// <returns><see cref="ModifyVirusScanTimeoutSettingResponse"/></returns>
        public Task<ModifyVirusScanTimeoutSettingResponse> ModifyVirusScanTimeoutSetting(ModifyVirusScanTimeoutSettingRequest req)
        {
            return InternalRequestAsync<ModifyVirusScanTimeoutSettingResponse>(req, "ModifyVirusScanTimeoutSetting");
        }

        /// <summary>
        /// This API is used to modify the timeout settings of a file scan at runtime.
        /// </summary>
        /// <param name="req"><see cref="ModifyVirusScanTimeoutSettingRequest"/></param>
        /// <returns><see cref="ModifyVirusScanTimeoutSettingResponse"/></returns>
        public ModifyVirusScanTimeoutSettingResponse ModifyVirusScanTimeoutSettingSync(ModifyVirusScanTimeoutSettingRequest req)
        {
            return InternalRequestAsync<ModifyVirusScanTimeoutSettingResponse>(req, "ModifyVirusScanTimeoutSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to change the status of an exploit prevention event.
        /// </summary>
        /// <param name="req"><see cref="ModifyVulDefenceEventStatusRequest"/></param>
        /// <returns><see cref="ModifyVulDefenceEventStatusResponse"/></returns>
        public Task<ModifyVulDefenceEventStatusResponse> ModifyVulDefenceEventStatus(ModifyVulDefenceEventStatusRequest req)
        {
            return InternalRequestAsync<ModifyVulDefenceEventStatusResponse>(req, "ModifyVulDefenceEventStatus");
        }

        /// <summary>
        /// This API is used to change the status of an exploit prevention event.
        /// </summary>
        /// <param name="req"><see cref="ModifyVulDefenceEventStatusRequest"/></param>
        /// <returns><see cref="ModifyVulDefenceEventStatusResponse"/></returns>
        public ModifyVulDefenceEventStatusResponse ModifyVulDefenceEventStatusSync(ModifyVulDefenceEventStatusRequest req)
        {
            return InternalRequestAsync<ModifyVulDefenceEventStatusResponse>(req, "ModifyVulDefenceEventStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to edit the exploit prevention settings.
        /// </summary>
        /// <param name="req"><see cref="ModifyVulDefenceSettingRequest"/></param>
        /// <returns><see cref="ModifyVulDefenceSettingResponse"/></returns>
        public Task<ModifyVulDefenceSettingResponse> ModifyVulDefenceSetting(ModifyVulDefenceSettingRequest req)
        {
            return InternalRequestAsync<ModifyVulDefenceSettingResponse>(req, "ModifyVulDefenceSetting");
        }

        /// <summary>
        /// This API is used to edit the exploit prevention settings.
        /// </summary>
        /// <param name="req"><see cref="ModifyVulDefenceSettingRequest"/></param>
        /// <returns><see cref="ModifyVulDefenceSettingResponse"/></returns>
        public ModifyVulDefenceSettingResponse ModifyVulDefenceSettingSync(ModifyVulDefenceSettingRequest req)
        {
            return InternalRequestAsync<ModifyVulDefenceSettingResponse>(req, "ModifyVulDefenceSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to activate TCSS trial.
        /// </summary>
        /// <param name="req"><see cref="OpenTcssTrialRequest"/></param>
        /// <returns><see cref="OpenTcssTrialResponse"/></returns>
        public Task<OpenTcssTrialResponse> OpenTcssTrial(OpenTcssTrialRequest req)
        {
            return InternalRequestAsync<OpenTcssTrialResponse>(req, "OpenTcssTrial");
        }

        /// <summary>
        /// This API is used to activate TCSS trial.
        /// </summary>
        /// <param name="req"><see cref="OpenTcssTrialRequest"/></param>
        /// <returns><see cref="OpenTcssTrialResponse"/></returns>
        public OpenTcssTrialResponse OpenTcssTrialSync(OpenTcssTrialRequest req)
        {
            return InternalRequestAsync<OpenTcssTrialResponse>(req, "OpenTcssTrial")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the details of an image repository.
        /// </summary>
        /// <param name="req"><see cref="RemoveAssetImageRegistryRegistryDetailRequest"/></param>
        /// <returns><see cref="RemoveAssetImageRegistryRegistryDetailResponse"/></returns>
        public Task<RemoveAssetImageRegistryRegistryDetailResponse> RemoveAssetImageRegistryRegistryDetail(RemoveAssetImageRegistryRegistryDetailRequest req)
        {
            return InternalRequestAsync<RemoveAssetImageRegistryRegistryDetailResponse>(req, "RemoveAssetImageRegistryRegistryDetail");
        }

        /// <summary>
        /// This API is used to delete the details of an image repository.
        /// </summary>
        /// <param name="req"><see cref="RemoveAssetImageRegistryRegistryDetailRequest"/></param>
        /// <returns><see cref="RemoveAssetImageRegistryRegistryDetailResponse"/></returns>
        public RemoveAssetImageRegistryRegistryDetailResponse RemoveAssetImageRegistryRegistryDetailSync(RemoveAssetImageRegistryRegistryDetailRequest req)
        {
            return InternalRequestAsync<RemoveAssetImageRegistryRegistryDetailResponse>(req, "RemoveAssetImageRegistryRegistryDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to license an image to be scanned.
        /// </summary>
        /// <param name="req"><see cref="RenewImageAuthorizeStateRequest"/></param>
        /// <returns><see cref="RenewImageAuthorizeStateResponse"/></returns>
        public Task<RenewImageAuthorizeStateResponse> RenewImageAuthorizeState(RenewImageAuthorizeStateRequest req)
        {
            return InternalRequestAsync<RenewImageAuthorizeStateResponse>(req, "RenewImageAuthorizeState");
        }

        /// <summary>
        /// This API is used to license an image to be scanned.
        /// </summary>
        /// <param name="req"><see cref="RenewImageAuthorizeStateRequest"/></param>
        /// <returns><see cref="RenewImageAuthorizeStateResponse"/></returns>
        public RenewImageAuthorizeStateResponse RenewImageAuthorizeStateSync(RenewImageAuthorizeStateRequest req)
        {
            return InternalRequestAsync<RenewImageAuthorizeStateResponse>(req, "RenewImageAuthorizeState")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to reset a security log topic.
        /// </summary>
        /// <param name="req"><see cref="ResetSecLogTopicConfigRequest"/></param>
        /// <returns><see cref="ResetSecLogTopicConfigResponse"/></returns>
        public Task<ResetSecLogTopicConfigResponse> ResetSecLogTopicConfig(ResetSecLogTopicConfigRequest req)
        {
            return InternalRequestAsync<ResetSecLogTopicConfigResponse>(req, "ResetSecLogTopicConfig");
        }

        /// <summary>
        /// This API is used to reset a security log topic.
        /// </summary>
        /// <param name="req"><see cref="ResetSecLogTopicConfigRequest"/></param>
        /// <returns><see cref="ResetSecLogTopicConfigResponse"/></returns>
        public ResetSecLogTopicConfigResponse ResetSecLogTopicConfigSync(ResetSecLogTopicConfigRequest req)
        {
            return InternalRequestAsync<ResetSecLogTopicConfigResponse>(req, "ResetSecLogTopicConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to check the specified asset again.
        /// </summary>
        /// <param name="req"><see cref="ScanComplianceAssetsRequest"/></param>
        /// <returns><see cref="ScanComplianceAssetsResponse"/></returns>
        public Task<ScanComplianceAssetsResponse> ScanComplianceAssets(ScanComplianceAssetsRequest req)
        {
            return InternalRequestAsync<ScanComplianceAssetsResponse>(req, "ScanComplianceAssets");
        }

        /// <summary>
        /// This API is used to check the specified asset again.
        /// </summary>
        /// <param name="req"><see cref="ScanComplianceAssetsRequest"/></param>
        /// <returns><see cref="ScanComplianceAssetsResponse"/></returns>
        public ScanComplianceAssetsResponse ScanComplianceAssetsSync(ScanComplianceAssetsRequest req)
        {
            return InternalRequestAsync<ScanComplianceAssetsResponse>(req, "ScanComplianceAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to check the specified asset again with the specified check item and return the ID of the created compliance check task.
        /// </summary>
        /// <param name="req"><see cref="ScanComplianceAssetsByPolicyItemRequest"/></param>
        /// <returns><see cref="ScanComplianceAssetsByPolicyItemResponse"/></returns>
        public Task<ScanComplianceAssetsByPolicyItemResponse> ScanComplianceAssetsByPolicyItem(ScanComplianceAssetsByPolicyItemRequest req)
        {
            return InternalRequestAsync<ScanComplianceAssetsByPolicyItemResponse>(req, "ScanComplianceAssetsByPolicyItem");
        }

        /// <summary>
        /// This API is used to check the specified asset again with the specified check item and return the ID of the created compliance check task.
        /// </summary>
        /// <param name="req"><see cref="ScanComplianceAssetsByPolicyItemRequest"/></param>
        /// <returns><see cref="ScanComplianceAssetsByPolicyItemResponse"/></returns>
        public ScanComplianceAssetsByPolicyItemResponse ScanComplianceAssetsByPolicyItemSync(ScanComplianceAssetsByPolicyItemRequest req)
        {
            return InternalRequestAsync<ScanComplianceAssetsByPolicyItemResponse>(req, "ScanComplianceAssetsByPolicyItem")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to check all the assets of the specified check item again and return the ID of the created compliance check task.
        /// </summary>
        /// <param name="req"><see cref="ScanCompliancePolicyItemsRequest"/></param>
        /// <returns><see cref="ScanCompliancePolicyItemsResponse"/></returns>
        public Task<ScanCompliancePolicyItemsResponse> ScanCompliancePolicyItems(ScanCompliancePolicyItemsRequest req)
        {
            return InternalRequestAsync<ScanCompliancePolicyItemsResponse>(req, "ScanCompliancePolicyItems");
        }

        /// <summary>
        /// This API is used to check all the assets of the specified check item again and return the ID of the created compliance check task.
        /// </summary>
        /// <param name="req"><see cref="ScanCompliancePolicyItemsRequest"/></param>
        /// <returns><see cref="ScanCompliancePolicyItemsResponse"/></returns>
        public ScanCompliancePolicyItemsResponse ScanCompliancePolicyItemsSync(ScanCompliancePolicyItemsRequest req)
        {
            return InternalRequestAsync<ScanCompliancePolicyItemsResponse>(req, "ScanCompliancePolicyItems")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to check all the failed check items of the specified asset again and return the ID of the created compliance check task.
        /// </summary>
        /// <param name="req"><see cref="ScanComplianceScanFailedAssetsRequest"/></param>
        /// <returns><see cref="ScanComplianceScanFailedAssetsResponse"/></returns>
        public Task<ScanComplianceScanFailedAssetsResponse> ScanComplianceScanFailedAssets(ScanComplianceScanFailedAssetsRequest req)
        {
            return InternalRequestAsync<ScanComplianceScanFailedAssetsResponse>(req, "ScanComplianceScanFailedAssets");
        }

        /// <summary>
        /// This API is used to check all the failed check items of the specified asset again and return the ID of the created compliance check task.
        /// </summary>
        /// <param name="req"><see cref="ScanComplianceScanFailedAssetsRequest"/></param>
        /// <returns><see cref="ScanComplianceScanFailedAssetsResponse"/></returns>
        public ScanComplianceScanFailedAssetsResponse ScanComplianceScanFailedAssetsSync(ScanComplianceScanFailedAssetsRequest req)
        {
            return InternalRequestAsync<ScanComplianceScanFailedAssetsResponse>(req, "ScanComplianceScanFailedAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set the check mode and automatic check.
        /// </summary>
        /// <param name="req"><see cref="SetCheckModeRequest"/></param>
        /// <returns><see cref="SetCheckModeResponse"/></returns>
        public Task<SetCheckModeResponse> SetCheckMode(SetCheckModeRequest req)
        {
            return InternalRequestAsync<SetCheckModeResponse>(req, "SetCheckMode");
        }

        /// <summary>
        /// This API is used to set the check mode and automatic check.
        /// </summary>
        /// <param name="req"><see cref="SetCheckModeRequest"/></param>
        /// <returns><see cref="SetCheckModeResponse"/></returns>
        public SetCheckModeResponse SetCheckModeSync(SetCheckModeRequest req)
        {
            return InternalRequestAsync<SetCheckModeResponse>(req, "SetCheckMode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to stop a trojan scan task at runtime.
        /// </summary>
        /// <param name="req"><see cref="StopVirusScanTaskRequest"/></param>
        /// <returns><see cref="StopVirusScanTaskResponse"/></returns>
        public Task<StopVirusScanTaskResponse> StopVirusScanTask(StopVirusScanTaskRequest req)
        {
            return InternalRequestAsync<StopVirusScanTaskResponse>(req, "StopVirusScanTask");
        }

        /// <summary>
        /// This API is used to stop a trojan scan task at runtime.
        /// </summary>
        /// <param name="req"><see cref="StopVirusScanTaskRequest"/></param>
        /// <returns><see cref="StopVirusScanTaskResponse"/></returns>
        public StopVirusScanTaskResponse StopVirusScanTaskSync(StopVirusScanTaskRequest req)
        {
            return InternalRequestAsync<StopVirusScanTaskResponse>(req, "StopVirusScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to stop a vulnerability scan task.
        /// </summary>
        /// <param name="req"><see cref="StopVulScanTaskRequest"/></param>
        /// <returns><see cref="StopVulScanTaskResponse"/></returns>
        public Task<StopVulScanTaskResponse> StopVulScanTask(StopVulScanTaskRequest req)
        {
            return InternalRequestAsync<StopVulScanTaskResponse>(req, "StopVulScanTask");
        }

        /// <summary>
        /// This API is used to stop a vulnerability scan task.
        /// </summary>
        /// <param name="req"><see cref="StopVulScanTaskRequest"/></param>
        /// <returns><see cref="StopVulScanTaskResponse"/></returns>
        public StopVulScanTaskResponse StopVulScanTaskSync(StopVulScanTaskRequest req)
        {
            return InternalRequestAsync<StopVulScanTaskResponse>(req, "StopVulScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable/disable automatic licensing for local images.
        /// </summary>
        /// <param name="req"><see cref="SwitchImageAutoAuthorizedRuleRequest"/></param>
        /// <returns><see cref="SwitchImageAutoAuthorizedRuleResponse"/></returns>
        public Task<SwitchImageAutoAuthorizedRuleResponse> SwitchImageAutoAuthorizedRule(SwitchImageAutoAuthorizedRuleRequest req)
        {
            return InternalRequestAsync<SwitchImageAutoAuthorizedRuleResponse>(req, "SwitchImageAutoAuthorizedRule");
        }

        /// <summary>
        /// This API is used to enable/disable automatic licensing for local images.
        /// </summary>
        /// <param name="req"><see cref="SwitchImageAutoAuthorizedRuleRequest"/></param>
        /// <returns><see cref="SwitchImageAutoAuthorizedRuleResponse"/></returns>
        public SwitchImageAutoAuthorizedRuleResponse SwitchImageAutoAuthorizedRuleSync(SwitchImageAutoAuthorizedRuleRequest req)
        {
            return InternalRequestAsync<SwitchImageAutoAuthorizedRuleResponse>(req, "SwitchImageAutoAuthorizedRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to refresh the assets in an image repository.
        /// </summary>
        /// <param name="req"><see cref="SyncAssetImageRegistryAssetRequest"/></param>
        /// <returns><see cref="SyncAssetImageRegistryAssetResponse"/></returns>
        public Task<SyncAssetImageRegistryAssetResponse> SyncAssetImageRegistryAsset(SyncAssetImageRegistryAssetRequest req)
        {
            return InternalRequestAsync<SyncAssetImageRegistryAssetResponse>(req, "SyncAssetImageRegistryAsset");
        }

        /// <summary>
        /// This API is used to refresh the assets in an image repository.
        /// </summary>
        /// <param name="req"><see cref="SyncAssetImageRegistryAssetRequest"/></param>
        /// <returns><see cref="SyncAssetImageRegistryAssetResponse"/></returns>
        public SyncAssetImageRegistryAssetResponse SyncAssetImageRegistryAssetSync(SyncAssetImageRegistryAssetRequest req)
        {
            return InternalRequestAsync<SyncAssetImageRegistryAssetResponse>(req, "SyncAssetImageRegistryAsset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a task to update and publish a network policy in the container network.
        /// </summary>
        /// <param name="req"><see cref="UpdateAndPublishNetworkFirewallPolicyDetailRequest"/></param>
        /// <returns><see cref="UpdateAndPublishNetworkFirewallPolicyDetailResponse"/></returns>
        public Task<UpdateAndPublishNetworkFirewallPolicyDetailResponse> UpdateAndPublishNetworkFirewallPolicyDetail(UpdateAndPublishNetworkFirewallPolicyDetailRequest req)
        {
            return InternalRequestAsync<UpdateAndPublishNetworkFirewallPolicyDetailResponse>(req, "UpdateAndPublishNetworkFirewallPolicyDetail");
        }

        /// <summary>
        /// This API is used to create a task to update and publish a network policy in the container network.
        /// </summary>
        /// <param name="req"><see cref="UpdateAndPublishNetworkFirewallPolicyDetailRequest"/></param>
        /// <returns><see cref="UpdateAndPublishNetworkFirewallPolicyDetailResponse"/></returns>
        public UpdateAndPublishNetworkFirewallPolicyDetailResponse UpdateAndPublishNetworkFirewallPolicyDetailSync(UpdateAndPublishNetworkFirewallPolicyDetailRequest req)
        {
            return InternalRequestAsync<UpdateAndPublishNetworkFirewallPolicyDetailResponse>(req, "UpdateAndPublishNetworkFirewallPolicyDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a task to update and publish a YAML network policy in the container network.
        /// </summary>
        /// <param name="req"><see cref="UpdateAndPublishNetworkFirewallPolicyYamlDetailRequest"/></param>
        /// <returns><see cref="UpdateAndPublishNetworkFirewallPolicyYamlDetailResponse"/></returns>
        public Task<UpdateAndPublishNetworkFirewallPolicyYamlDetailResponse> UpdateAndPublishNetworkFirewallPolicyYamlDetail(UpdateAndPublishNetworkFirewallPolicyYamlDetailRequest req)
        {
            return InternalRequestAsync<UpdateAndPublishNetworkFirewallPolicyYamlDetailResponse>(req, "UpdateAndPublishNetworkFirewallPolicyYamlDetail");
        }

        /// <summary>
        /// This API is used to create a task to update and publish a YAML network policy in the container network.
        /// </summary>
        /// <param name="req"><see cref="UpdateAndPublishNetworkFirewallPolicyYamlDetailRequest"/></param>
        /// <returns><see cref="UpdateAndPublishNetworkFirewallPolicyYamlDetailResponse"/></returns>
        public UpdateAndPublishNetworkFirewallPolicyYamlDetailResponse UpdateAndPublishNetworkFirewallPolicyYamlDetailSync(UpdateAndPublishNetworkFirewallPolicyYamlDetailRequest req)
        {
            return InternalRequestAsync<UpdateAndPublishNetworkFirewallPolicyYamlDetailResponse>(req, "UpdateAndPublishNetworkFirewallPolicyYamlDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the details of an image repository.
        /// </summary>
        /// <param name="req"><see cref="UpdateAssetImageRegistryRegistryDetailRequest"/></param>
        /// <returns><see cref="UpdateAssetImageRegistryRegistryDetailResponse"/></returns>
        public Task<UpdateAssetImageRegistryRegistryDetailResponse> UpdateAssetImageRegistryRegistryDetail(UpdateAssetImageRegistryRegistryDetailRequest req)
        {
            return InternalRequestAsync<UpdateAssetImageRegistryRegistryDetailResponse>(req, "UpdateAssetImageRegistryRegistryDetail");
        }

        /// <summary>
        /// This API is used to update the details of an image repository.
        /// </summary>
        /// <param name="req"><see cref="UpdateAssetImageRegistryRegistryDetailRequest"/></param>
        /// <returns><see cref="UpdateAssetImageRegistryRegistryDetailResponse"/></returns>
        public UpdateAssetImageRegistryRegistryDetailResponse UpdateAssetImageRegistryRegistryDetailSync(UpdateAssetImageRegistryRegistryDetailRequest req)
        {
            return InternalRequestAsync<UpdateAssetImageRegistryRegistryDetailResponse>(req, "UpdateAssetImageRegistryRegistryDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update a scheduled task for an image repository.
        /// </summary>
        /// <param name="req"><see cref="UpdateImageRegistryTimingScanTaskRequest"/></param>
        /// <returns><see cref="UpdateImageRegistryTimingScanTaskResponse"/></returns>
        public Task<UpdateImageRegistryTimingScanTaskResponse> UpdateImageRegistryTimingScanTask(UpdateImageRegistryTimingScanTaskRequest req)
        {
            return InternalRequestAsync<UpdateImageRegistryTimingScanTaskResponse>(req, "UpdateImageRegistryTimingScanTask");
        }

        /// <summary>
        /// This API is used to update a scheduled task for an image repository.
        /// </summary>
        /// <param name="req"><see cref="UpdateImageRegistryTimingScanTaskRequest"/></param>
        /// <returns><see cref="UpdateImageRegistryTimingScanTaskResponse"/></returns>
        public UpdateImageRegistryTimingScanTaskResponse UpdateImageRegistryTimingScanTaskSync(UpdateImageRegistryTimingScanTaskRequest req)
        {
            return InternalRequestAsync<UpdateImageRegistryTimingScanTaskResponse>(req, "UpdateImageRegistryTimingScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a task to update a network policy in the container network.
        /// </summary>
        /// <param name="req"><see cref="UpdateNetworkFirewallPolicyDetailRequest"/></param>
        /// <returns><see cref="UpdateNetworkFirewallPolicyDetailResponse"/></returns>
        public Task<UpdateNetworkFirewallPolicyDetailResponse> UpdateNetworkFirewallPolicyDetail(UpdateNetworkFirewallPolicyDetailRequest req)
        {
            return InternalRequestAsync<UpdateNetworkFirewallPolicyDetailResponse>(req, "UpdateNetworkFirewallPolicyDetail");
        }

        /// <summary>
        /// This API is used to create a task to update a network policy in the container network.
        /// </summary>
        /// <param name="req"><see cref="UpdateNetworkFirewallPolicyDetailRequest"/></param>
        /// <returns><see cref="UpdateNetworkFirewallPolicyDetailResponse"/></returns>
        public UpdateNetworkFirewallPolicyDetailResponse UpdateNetworkFirewallPolicyDetailSync(UpdateNetworkFirewallPolicyDetailRequest req)
        {
            return InternalRequestAsync<UpdateNetworkFirewallPolicyDetailResponse>(req, "UpdateNetworkFirewallPolicyDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a task to update a YAML network policy in the container network.
        /// </summary>
        /// <param name="req"><see cref="UpdateNetworkFirewallPolicyYamlDetailRequest"/></param>
        /// <returns><see cref="UpdateNetworkFirewallPolicyYamlDetailResponse"/></returns>
        public Task<UpdateNetworkFirewallPolicyYamlDetailResponse> UpdateNetworkFirewallPolicyYamlDetail(UpdateNetworkFirewallPolicyYamlDetailRequest req)
        {
            return InternalRequestAsync<UpdateNetworkFirewallPolicyYamlDetailResponse>(req, "UpdateNetworkFirewallPolicyYamlDetail");
        }

        /// <summary>
        /// This API is used to create a task to update a YAML network policy in the container network.
        /// </summary>
        /// <param name="req"><see cref="UpdateNetworkFirewallPolicyYamlDetailRequest"/></param>
        /// <returns><see cref="UpdateNetworkFirewallPolicyYamlDetailResponse"/></returns>
        public UpdateNetworkFirewallPolicyYamlDetailResponse UpdateNetworkFirewallPolicyYamlDetailSync(UpdateNetworkFirewallPolicyYamlDetailRequest req)
        {
            return InternalRequestAsync<UpdateNetworkFirewallPolicyYamlDetailResponse>(req, "UpdateNetworkFirewallPolicyYamlDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
