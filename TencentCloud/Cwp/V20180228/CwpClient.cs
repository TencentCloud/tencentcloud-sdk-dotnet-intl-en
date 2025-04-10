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

namespace TencentCloud.Cwp.V20180228
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cwp.V20180228.Models;

   public class CwpClient : AbstractClient{

       private const string endpoint = "cwp.intl.tencentcloudapi.com";
       private const string version = "2018-02-28";
       private const string sdkVersion = "SDK_NET_3.0.1109";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CwpClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CwpClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to add cross-region log-in allowlists in batches.
        /// </summary>
        /// <param name="req"><see cref="AddLoginWhiteListsRequest"/></param>
        /// <returns><see cref="AddLoginWhiteListsResponse"/></returns>
        public Task<AddLoginWhiteListsResponse> AddLoginWhiteLists(AddLoginWhiteListsRequest req)
        {
            return InternalRequestAsync<AddLoginWhiteListsResponse>(req, "AddLoginWhiteLists");
        }

        /// <summary>
        /// This API is used to add cross-region log-in allowlists in batches.
        /// </summary>
        /// <param name="req"><see cref="AddLoginWhiteListsRequest"/></param>
        /// <returns><see cref="AddLoginWhiteListsResponse"/></returns>
        public AddLoginWhiteListsResponse AddLoginWhiteListsSync(AddLoginWhiteListsRequest req)
        {
            return InternalRequestAsync<AddLoginWhiteListsResponse>(req, "AddLoginWhiteLists")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unignore the vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="CancelIgnoreVulRequest"/></param>
        /// <returns><see cref="CancelIgnoreVulResponse"/></returns>
        public Task<CancelIgnoreVulResponse> CancelIgnoreVul(CancelIgnoreVulRequest req)
        {
            return InternalRequestAsync<CancelIgnoreVulResponse>(req, "CancelIgnoreVul");
        }

        /// <summary>
        /// This API is used to unignore the vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="CancelIgnoreVulRequest"/></param>
        /// <returns><see cref="CancelIgnoreVulResponse"/></returns>
        public CancelIgnoreVulResponse CancelIgnoreVulSync(CancelIgnoreVulRequest req)
        {
            return InternalRequestAsync<CancelIgnoreVulResponse>(req, "CancelIgnoreVul")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to ignore events or cancel ignoring in batches based on check item ID or event ID.
        /// </summary>
        /// <param name="req"><see cref="ChangeRuleEventsIgnoreStatusRequest"/></param>
        /// <returns><see cref="ChangeRuleEventsIgnoreStatusResponse"/></returns>
        public Task<ChangeRuleEventsIgnoreStatusResponse> ChangeRuleEventsIgnoreStatus(ChangeRuleEventsIgnoreStatusRequest req)
        {
            return InternalRequestAsync<ChangeRuleEventsIgnoreStatusResponse>(req, "ChangeRuleEventsIgnoreStatus");
        }

        /// <summary>
        /// This API is used to ignore events or cancel ignoring in batches based on check item ID or event ID.
        /// </summary>
        /// <param name="req"><see cref="ChangeRuleEventsIgnoreStatusRequest"/></param>
        /// <returns><see cref="ChangeRuleEventsIgnoreStatusResponse"/></returns>
        public ChangeRuleEventsIgnoreStatusResponse ChangeRuleEventsIgnoreStatusSync(ChangeRuleEventsIgnoreStatusRequest req)
        {
            return InternalRequestAsync<ChangeRuleEventsIgnoreStatusResponse>(req, "ChangeRuleEventsIgnoreStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to change the policy availability status by policy ID.
        /// </summary>
        /// <param name="req"><see cref="ChangeStrategyEnableStatusRequest"/></param>
        /// <returns><see cref="ChangeStrategyEnableStatusResponse"/></returns>
        public Task<ChangeStrategyEnableStatusResponse> ChangeStrategyEnableStatus(ChangeStrategyEnableStatusRequest req)
        {
            return InternalRequestAsync<ChangeStrategyEnableStatusResponse>(req, "ChangeStrategyEnableStatus");
        }

        /// <summary>
        /// This API is used to change the policy availability status by policy ID.
        /// </summary>
        /// <param name="req"><see cref="ChangeStrategyEnableStatusRequest"/></param>
        /// <returns><see cref="ChangeStrategyEnableStatusResponse"/></returns>
        public ChangeStrategyEnableStatusResponse ChangeStrategyEnableStatusSync(ChangeStrategyEnableStatusRequest req)
        {
            return InternalRequestAsync<ChangeStrategyEnableStatusResponse>(req, "ChangeStrategyEnableStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to verify parameters entered for adding and editing high-risk command user rules.
        /// </summary>
        /// <param name="req"><see cref="CheckBashPolicyParamsRequest"/></param>
        /// <returns><see cref="CheckBashPolicyParamsResponse"/></returns>
        public Task<CheckBashPolicyParamsResponse> CheckBashPolicyParams(CheckBashPolicyParamsRequest req)
        {
            return InternalRequestAsync<CheckBashPolicyParamsResponse>(req, "CheckBashPolicyParams");
        }

        /// <summary>
        /// This API is used to verify parameters entered for adding and editing high-risk command user rules.
        /// </summary>
        /// <param name="req"><see cref="CheckBashPolicyParamsRequest"/></param>
        /// <returns><see cref="CheckBashPolicyParamsResponse"/></returns>
        public CheckBashPolicyParamsResponse CheckBashPolicyParamsSync(CheckBashPolicyParamsRequest req)
        {
            return InternalRequestAsync<CheckBashPolicyParamsResponse>(req, "CheckBashPolicyParams")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to verify parameters entered for adding and editing high-risk command user rules.
        /// </summary>
        /// <param name="req"><see cref="CheckBashRuleParamsRequest"/></param>
        /// <returns><see cref="CheckBashRuleParamsResponse"/></returns>
        public Task<CheckBashRuleParamsResponse> CheckBashRuleParams(CheckBashRuleParamsRequest req)
        {
            return InternalRequestAsync<CheckBashRuleParamsResponse>(req, "CheckBashRuleParams");
        }

        /// <summary>
        /// This API is used to verify parameters entered for adding and editing high-risk command user rules.
        /// </summary>
        /// <param name="req"><see cref="CheckBashRuleParamsRequest"/></param>
        /// <returns><see cref="CheckBashRuleParamsResponse"/></returns>
        public CheckBashRuleParamsResponse CheckBashRuleParamsSync(CheckBashRuleParamsRequest req)
        {
            return InternalRequestAsync<CheckBashRuleParamsResponse>(req, "CheckBashRuleParams")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to check the rule parameters entered at the core file monitoring frontend.
        /// </summary>
        /// <param name="req"><see cref="CheckFileTamperRuleRequest"/></param>
        /// <returns><see cref="CheckFileTamperRuleResponse"/></returns>
        public Task<CheckFileTamperRuleResponse> CheckFileTamperRule(CheckFileTamperRuleRequest req)
        {
            return InternalRequestAsync<CheckFileTamperRuleResponse>(req, "CheckFileTamperRule");
        }

        /// <summary>
        /// This API is used to check the rule parameters entered at the core file monitoring frontend.
        /// </summary>
        /// <param name="req"><see cref="CheckFileTamperRuleRequest"/></param>
        /// <returns><see cref="CheckFileTamperRuleResponse"/></returns>
        public CheckFileTamperRuleResponse CheckFileTamperRuleSync(CheckFileTamperRuleRequest req)
        {
            return InternalRequestAsync<CheckFileTamperRuleResponse>(req, "CheckFileTamperRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query whether the baseline is detected for the first time.
        /// </summary>
        /// <param name="req"><see cref="CheckFirstScanBaselineRequest"/></param>
        /// <returns><see cref="CheckFirstScanBaselineResponse"/></returns>
        public Task<CheckFirstScanBaselineResponse> CheckFirstScanBaseline(CheckFirstScanBaselineRequest req)
        {
            return InternalRequestAsync<CheckFirstScanBaselineResponse>(req, "CheckFirstScanBaseline");
        }

        /// <summary>
        /// This API is used to query whether the baseline is detected for the first time.
        /// </summary>
        /// <param name="req"><see cref="CheckFirstScanBaselineRequest"/></param>
        /// <returns><see cref="CheckFirstScanBaselineResponse"/></returns>
        public CheckFirstScanBaselineResponse CheckFirstScanBaselineSync(CheckFirstScanBaselineRequest req)
        {
            return InternalRequestAsync<CheckFirstScanBaselineResponse>(req, "CheckFirstScanBaseline")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to check the connectivity for log shipping from Kafka.
        /// </summary>
        /// <param name="req"><see cref="CheckLogKafkaConnectionStateRequest"/></param>
        /// <returns><see cref="CheckLogKafkaConnectionStateResponse"/></returns>
        public Task<CheckLogKafkaConnectionStateResponse> CheckLogKafkaConnectionState(CheckLogKafkaConnectionStateRequest req)
        {
            return InternalRequestAsync<CheckLogKafkaConnectionStateResponse>(req, "CheckLogKafkaConnectionState");
        }

        /// <summary>
        /// This API is used to check the connectivity for log shipping from Kafka.
        /// </summary>
        /// <param name="req"><see cref="CheckLogKafkaConnectionStateRequest"/></param>
        /// <returns><see cref="CheckLogKafkaConnectionStateResponse"/></returns>
        public CheckLogKafkaConnectionStateResponse CheckLogKafkaConnectionStateSync(CheckLogKafkaConnectionStateRequest req)
        {
            return InternalRequestAsync<CheckLogKafkaConnectionStateResponse>(req, "CheckLogKafkaConnectionState")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to clean up the locally stored data.
        /// </summary>
        /// <param name="req"><see cref="ClearLocalStorageRequest"/></param>
        /// <returns><see cref="ClearLocalStorageResponse"/></returns>
        public Task<ClearLocalStorageResponse> ClearLocalStorage(ClearLocalStorageRequest req)
        {
            return InternalRequestAsync<ClearLocalStorageResponse>(req, "ClearLocalStorage");
        }

        /// <summary>
        /// This API is used to clean up the locally stored data.
        /// </summary>
        /// <param name="req"><see cref="ClearLocalStorageRequest"/></param>
        /// <returns><see cref="ClearLocalStorageResponse"/></returns>
        public ClearLocalStorageResponse ClearLocalStorageSync(ClearLocalStorageRequest req)
        {
            return InternalRequestAsync<ClearLocalStorageResponse>(req, "ClearLocalStorage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add the list of block allowlists.
        /// </summary>
        /// <param name="req"><see cref="CreateBanWhiteListRequest"/></param>
        /// <returns><see cref="CreateBanWhiteListResponse"/></returns>
        public Task<CreateBanWhiteListResponse> CreateBanWhiteList(CreateBanWhiteListRequest req)
        {
            return InternalRequestAsync<CreateBanWhiteListResponse>(req, "CreateBanWhiteList");
        }

        /// <summary>
        /// This API is used to add the list of block allowlists.
        /// </summary>
        /// <param name="req"><see cref="CreateBanWhiteListRequest"/></param>
        /// <returns><see cref="CreateBanWhiteListResponse"/></returns>
        public CreateBanWhiteListResponse CreateBanWhiteListSync(CreateBanWhiteListRequest req)
        {
            return InternalRequestAsync<CreateBanWhiteListResponse>(req, "CreateBanWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a baseline policy based on the policy information.
        /// </summary>
        /// <param name="req"><see cref="CreateBaselineStrategyRequest"/></param>
        /// <returns><see cref="CreateBaselineStrategyResponse"/></returns>
        public Task<CreateBaselineStrategyResponse> CreateBaselineStrategy(CreateBaselineStrategyRequest req)
        {
            return InternalRequestAsync<CreateBaselineStrategyResponse>(req, "CreateBaselineStrategy");
        }

        /// <summary>
        /// This API is used to create a baseline policy based on the policy information.
        /// </summary>
        /// <param name="req"><see cref="CreateBaselineStrategyRequest"/></param>
        /// <returns><see cref="CreateBaselineStrategyResponse"/></returns>
        public CreateBaselineStrategyResponse CreateBaselineStrategySync(CreateBaselineStrategyRequest req)
        {
            return InternalRequestAsync<CreateBaselineStrategyResponse>(req, "CreateBaselineStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an automatic binding task for newly purchased authorizations.
        /// </summary>
        /// <param name="req"><see cref="CreateBuyBindTaskRequest"/></param>
        /// <returns><see cref="CreateBuyBindTaskResponse"/></returns>
        public Task<CreateBuyBindTaskResponse> CreateBuyBindTask(CreateBuyBindTaskRequest req)
        {
            return InternalRequestAsync<CreateBuyBindTaskResponse>(req, "CreateBuyBindTask");
        }

        /// <summary>
        /// This API is used to create an automatic binding task for newly purchased authorizations.
        /// </summary>
        /// <param name="req"><see cref="CreateBuyBindTaskRequest"/></param>
        /// <returns><see cref="CreateBuyBindTaskResponse"/></returns>
        public CreateBuyBindTaskResponse CreateBuyBindTaskSync(CreateBuyBindTaskRequest req)
        {
            return InternalRequestAsync<CreateBuyBindTaskResponse>(req, "CreateBuyBindTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create emergency vulnerability scan tasks.
        /// </summary>
        /// <param name="req"><see cref="CreateEmergencyVulScanRequest"/></param>
        /// <returns><see cref="CreateEmergencyVulScanResponse"/></returns>
        public Task<CreateEmergencyVulScanResponse> CreateEmergencyVulScan(CreateEmergencyVulScanRequest req)
        {
            return InternalRequestAsync<CreateEmergencyVulScanResponse>(req, "CreateEmergencyVulScan");
        }

        /// <summary>
        /// This API is used to create emergency vulnerability scan tasks.
        /// </summary>
        /// <param name="req"><see cref="CreateEmergencyVulScanRequest"/></param>
        /// <returns><see cref="CreateEmergencyVulScanResponse"/></returns>
        public CreateEmergencyVulScanResponse CreateEmergencyVulScanSync(CreateEmergencyVulScanRequest req)
        {
            return InternalRequestAsync<CreateEmergencyVulScanResponse>(req, "CreateEmergencyVulScan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to trigger event investigation and alarm backtracking for Ultimate Edition machines.
        /// </summary>
        /// <param name="req"><see cref="CreateIncidentBacktrackingRequest"/></param>
        /// <returns><see cref="CreateIncidentBacktrackingResponse"/></returns>
        public Task<CreateIncidentBacktrackingResponse> CreateIncidentBacktracking(CreateIncidentBacktrackingRequest req)
        {
            return InternalRequestAsync<CreateIncidentBacktrackingResponse>(req, "CreateIncidentBacktracking");
        }

        /// <summary>
        /// This API is used to trigger event investigation and alarm backtracking for Ultimate Edition machines.
        /// </summary>
        /// <param name="req"><see cref="CreateIncidentBacktrackingRequest"/></param>
        /// <returns><see cref="CreateIncidentBacktrackingResponse"/></returns>
        public CreateIncidentBacktrackingResponse CreateIncidentBacktrackingSync(CreateIncidentBacktrackingRequest req)
        {
            return InternalRequestAsync<CreateIncidentBacktrackingResponse>(req, "CreateIncidentBacktracking")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create Professional/Flagship edition orders
        /// .This API is used to support creating orders through prepaid and pay-as-you-go.
        /// This API is used to directly create postpaid orders.
        /// This API is used to call the billing payment API for payment since prepaid orders are only placed but not paid.
        /// </summary>
        /// <param name="req"><see cref="CreateLicenseOrderRequest"/></param>
        /// <returns><see cref="CreateLicenseOrderResponse"/></returns>
        public Task<CreateLicenseOrderResponse> CreateLicenseOrder(CreateLicenseOrderRequest req)
        {
            return InternalRequestAsync<CreateLicenseOrderResponse>(req, "CreateLicenseOrder");
        }

        /// <summary>
        /// This API is used to create Professional/Flagship edition orders
        /// .This API is used to support creating orders through prepaid and pay-as-you-go.
        /// This API is used to directly create postpaid orders.
        /// This API is used to call the billing payment API for payment since prepaid orders are only placed but not paid.
        /// </summary>
        /// <param name="req"><see cref="CreateLicenseOrderRequest"/></param>
        /// <returns><see cref="CreateLicenseOrderResponse"/></returns>
        public CreateLicenseOrderResponse CreateLicenseOrderSync(CreateLicenseOrderRequest req)
        {
            return InternalRequestAsync<CreateLicenseOrderResponse>(req, "CreateLicenseOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create log download tasks.
        /// </summary>
        /// <param name="req"><see cref="CreateLogExportRequest"/></param>
        /// <returns><see cref="CreateLogExportResponse"/></returns>
        public Task<CreateLogExportResponse> CreateLogExport(CreateLogExportRequest req)
        {
            return InternalRequestAsync<CreateLogExportResponse>(req, "CreateLogExport");
        }

        /// <summary>
        /// This API is used to create log download tasks.
        /// </summary>
        /// <param name="req"><see cref="CreateLogExportRequest"/></param>
        /// <returns><see cref="CreateLogExportResponse"/></returns>
        public CreateLogExportResponse CreateLogExportSync(CreateLogExportRequest req)
        {
            return InternalRequestAsync<CreateLogExportResponse>(req, "CreateLogExport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add malicious request allowlists.
        /// </summary>
        /// <param name="req"><see cref="CreateMaliciousRequestWhiteListRequest"/></param>
        /// <returns><see cref="CreateMaliciousRequestWhiteListResponse"/></returns>
        public Task<CreateMaliciousRequestWhiteListResponse> CreateMaliciousRequestWhiteList(CreateMaliciousRequestWhiteListRequest req)
        {
            return InternalRequestAsync<CreateMaliciousRequestWhiteListResponse>(req, "CreateMaliciousRequestWhiteList");
        }

        /// <summary>
        /// This API is used to add malicious request allowlists.
        /// </summary>
        /// <param name="req"><see cref="CreateMaliciousRequestWhiteListRequest"/></param>
        /// <returns><see cref="CreateMaliciousRequestWhiteListResponse"/></returns>
        public CreateMaliciousRequestWhiteListResponse CreateMaliciousRequestWhiteListSync(CreateMaliciousRequestWhiteListRequest req)
        {
            return InternalRequestAsync<CreateMaliciousRequestWhiteListResponse>(req, "CreateMaliciousRequestWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create the Trojan allowlist.
        /// </summary>
        /// <param name="req"><see cref="CreateMalwareWhiteListRequest"/></param>
        /// <returns><see cref="CreateMalwareWhiteListResponse"/></returns>
        public Task<CreateMalwareWhiteListResponse> CreateMalwareWhiteList(CreateMalwareWhiteListRequest req)
        {
            return InternalRequestAsync<CreateMalwareWhiteListResponse>(req, "CreateMalwareWhiteList");
        }

        /// <summary>
        /// This API is used to create the Trojan allowlist.
        /// </summary>
        /// <param name="req"><see cref="CreateMalwareWhiteListRequest"/></param>
        /// <returns><see cref="CreateMalwareWhiteListResponse"/></returns>
        public CreateMalwareWhiteListResponse CreateMalwareWhiteListSync(CreateMalwareWhiteListRequest req)
        {
            return InternalRequestAsync<CreateMalwareWhiteListResponse>(req, "CreateMalwareWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a network attack allowlist.
        /// </summary>
        /// <param name="req"><see cref="CreateNetAttackWhiteListRequest"/></param>
        /// <returns><see cref="CreateNetAttackWhiteListResponse"/></returns>
        public Task<CreateNetAttackWhiteListResponse> CreateNetAttackWhiteList(CreateNetAttackWhiteListRequest req)
        {
            return InternalRequestAsync<CreateNetAttackWhiteListResponse>(req, "CreateNetAttackWhiteList");
        }

        /// <summary>
        /// This API is used to create a network attack allowlist.
        /// </summary>
        /// <param name="req"><see cref="CreateNetAttackWhiteListRequest"/></param>
        /// <returns><see cref="CreateNetAttackWhiteListResponse"/></returns>
        public CreateNetAttackWhiteListResponse CreateNetAttackWhiteListSync(CreateNetAttackWhiteListRequest req)
        {
            return InternalRequestAsync<CreateNetAttackWhiteListResponse>(req, "CreateNetAttackWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create or modify anti-ransomware policies.
        /// </summary>
        /// <param name="req"><see cref="CreateRansomDefenseStrategyRequest"/></param>
        /// <returns><see cref="CreateRansomDefenseStrategyResponse"/></returns>
        public Task<CreateRansomDefenseStrategyResponse> CreateRansomDefenseStrategy(CreateRansomDefenseStrategyRequest req)
        {
            return InternalRequestAsync<CreateRansomDefenseStrategyResponse>(req, "CreateRansomDefenseStrategy");
        }

        /// <summary>
        /// This API is used to create or modify anti-ransomware policies.
        /// </summary>
        /// <param name="req"><see cref="CreateRansomDefenseStrategyRequest"/></param>
        /// <returns><see cref="CreateRansomDefenseStrategyResponse"/></returns>
        public CreateRansomDefenseStrategyResponse CreateRansomDefenseStrategySync(CreateRansomDefenseStrategyRequest req)
        {
            return InternalRequestAsync<CreateRansomDefenseStrategyResponse>(req, "CreateRansomDefenseStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to detect the intrusion and virus scanning.
        /// </summary>
        /// <param name="req"><see cref="CreateScanMalwareSettingRequest"/></param>
        /// <returns><see cref="CreateScanMalwareSettingResponse"/></returns>
        public Task<CreateScanMalwareSettingResponse> CreateScanMalwareSetting(CreateScanMalwareSettingRequest req)
        {
            return InternalRequestAsync<CreateScanMalwareSettingResponse>(req, "CreateScanMalwareSetting");
        }

        /// <summary>
        /// This API is used to detect the intrusion and virus scanning.
        /// </summary>
        /// <param name="req"><see cref="CreateScanMalwareSettingRequest"/></param>
        /// <returns><see cref="CreateScanMalwareSettingResponse"/></returns>
        public CreateScanMalwareSettingResponse CreateScanMalwareSettingSync(CreateScanMalwareSettingRequest req)
        {
            return InternalRequestAsync<CreateScanMalwareSettingResponse>(req, "CreateScanMalwareSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add history search records.
        /// </summary>
        /// <param name="req"><see cref="CreateSearchLogRequest"/></param>
        /// <returns><see cref="CreateSearchLogResponse"/></returns>
        public Task<CreateSearchLogResponse> CreateSearchLog(CreateSearchLogRequest req)
        {
            return InternalRequestAsync<CreateSearchLogResponse>(req, "CreateSearchLog");
        }

        /// <summary>
        /// This API is used to add history search records.
        /// </summary>
        /// <param name="req"><see cref="CreateSearchLogRequest"/></param>
        /// <returns><see cref="CreateSearchLogResponse"/></returns>
        public CreateSearchLogResponse CreateSearchLogSync(CreateSearchLogRequest req)
        {
            return InternalRequestAsync<CreateSearchLogResponse>(req, "CreateSearchLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add the	retrieval template.
        /// </summary>
        /// <param name="req"><see cref="CreateSearchTemplateRequest"/></param>
        /// <returns><see cref="CreateSearchTemplateResponse"/></returns>
        public Task<CreateSearchTemplateResponse> CreateSearchTemplate(CreateSearchTemplateRequest req)
        {
            return InternalRequestAsync<CreateSearchTemplateResponse>(req, "CreateSearchTemplate");
        }

        /// <summary>
        /// This API is used to add the	retrieval template.
        /// </summary>
        /// <param name="req"><see cref="CreateSearchTemplateRequest"/></param>
        /// <returns><see cref="CreateSearchTemplateResponse"/></returns>
        public CreateSearchTemplateResponse CreateSearchTemplateSync(CreateSearchTemplateRequest req)
        {
            return InternalRequestAsync<CreateSearchTemplateResponse>(req, "CreateSearchTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to submit the vulnerabilities and fix them.
        /// </summary>
        /// <param name="req"><see cref="CreateVulFixRequest"/></param>
        /// <returns><see cref="CreateVulFixResponse"/></returns>
        public Task<CreateVulFixResponse> CreateVulFix(CreateVulFixRequest req)
        {
            return InternalRequestAsync<CreateVulFixResponse>(req, "CreateVulFix");
        }

        /// <summary>
        /// This API is used to submit the vulnerabilities and fix them.
        /// </summary>
        /// <param name="req"><see cref="CreateVulFixRequest"/></param>
        /// <returns><see cref="CreateVulFixResponse"/></returns>
        public CreateVulFixResponse CreateVulFixSync(CreateVulFixRequest req)
        {
            return InternalRequestAsync<CreateVulFixResponse>(req, "CreateVulFix")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create allowlist orders.
        /// </summary>
        /// <param name="req"><see cref="CreateWhiteListOrderRequest"/></param>
        /// <returns><see cref="CreateWhiteListOrderResponse"/></returns>
        public Task<CreateWhiteListOrderResponse> CreateWhiteListOrder(CreateWhiteListOrderRequest req)
        {
            return InternalRequestAsync<CreateWhiteListOrderResponse>(req, "CreateWhiteListOrder");
        }

        /// <summary>
        /// This API is used to create allowlist orders.
        /// </summary>
        /// <param name="req"><see cref="CreateWhiteListOrderRequest"/></param>
        /// <returns><see cref="CreateWhiteListOrderResponse"/></returns>
        public CreateWhiteListOrderResponse CreateWhiteListOrderSync(CreateWhiteListOrderRequest req)
        {
            return InternalRequestAsync<CreateWhiteListOrderResponse>(req, "CreateWhiteListOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete all Java webshell events.
        /// </summary>
        /// <param name="req"><see cref="DeleteAllJavaMemShellsRequest"/></param>
        /// <returns><see cref="DeleteAllJavaMemShellsResponse"/></returns>
        public Task<DeleteAllJavaMemShellsResponse> DeleteAllJavaMemShells(DeleteAllJavaMemShellsRequest req)
        {
            return InternalRequestAsync<DeleteAllJavaMemShellsResponse>(req, "DeleteAllJavaMemShells");
        }

        /// <summary>
        /// This API is used to delete all Java webshell events.
        /// </summary>
        /// <param name="req"><see cref="DeleteAllJavaMemShellsRequest"/></param>
        /// <returns><see cref="DeleteAllJavaMemShellsResponse"/></returns>
        public DeleteAllJavaMemShellsResponse DeleteAllJavaMemShellsSync(DeleteAllJavaMemShellsRequest req)
        {
            return InternalRequestAsync<DeleteAllJavaMemShellsResponse>(req, "DeleteAllJavaMemShells")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the list of blocking allowlists.
        /// </summary>
        /// <param name="req"><see cref="DeleteBanWhiteListRequest"/></param>
        /// <returns><see cref="DeleteBanWhiteListResponse"/></returns>
        public Task<DeleteBanWhiteListResponse> DeleteBanWhiteList(DeleteBanWhiteListRequest req)
        {
            return InternalRequestAsync<DeleteBanWhiteListResponse>(req, "DeleteBanWhiteList");
        }

        /// <summary>
        /// This API is used to delete the list of blocking allowlists.
        /// </summary>
        /// <param name="req"><see cref="DeleteBanWhiteListRequest"/></param>
        /// <returns><see cref="DeleteBanWhiteListResponse"/></returns>
        public DeleteBanWhiteListResponse DeleteBanWhiteListSync(DeleteBanWhiteListRequest req)
        {
            return InternalRequestAsync<DeleteBanWhiteListResponse>(req, "DeleteBanWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the baseline policy configuration.
        /// </summary>
        /// <param name="req"><see cref="DeleteBaselinePolicyRequest"/></param>
        /// <returns><see cref="DeleteBaselinePolicyResponse"/></returns>
        public Task<DeleteBaselinePolicyResponse> DeleteBaselinePolicy(DeleteBaselinePolicyRequest req)
        {
            return InternalRequestAsync<DeleteBaselinePolicyResponse>(req, "DeleteBaselinePolicy");
        }

        /// <summary>
        /// This API is used to delete the baseline policy configuration.
        /// </summary>
        /// <param name="req"><see cref="DeleteBaselinePolicyRequest"/></param>
        /// <returns><see cref="DeleteBaselinePolicyResponse"/></returns>
        public DeleteBaselinePolicyResponse DeleteBaselinePolicySync(DeleteBaselinePolicyRequest req)
        {
            return InternalRequestAsync<DeleteBaselinePolicyResponse>(req, "DeleteBaselinePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the policy by baseline policy ID.
        /// </summary>
        /// <param name="req"><see cref="DeleteBaselineStrategyRequest"/></param>
        /// <returns><see cref="DeleteBaselineStrategyResponse"/></returns>
        public Task<DeleteBaselineStrategyResponse> DeleteBaselineStrategy(DeleteBaselineStrategyRequest req)
        {
            return InternalRequestAsync<DeleteBaselineStrategyResponse>(req, "DeleteBaselineStrategy");
        }

        /// <summary>
        /// This API is used to delete the policy by baseline policy ID.
        /// </summary>
        /// <param name="req"><see cref="DeleteBaselineStrategyRequest"/></param>
        /// <returns><see cref="DeleteBaselineStrategyResponse"/></returns>
        public DeleteBaselineStrategyResponse DeleteBaselineStrategySync(DeleteBaselineStrategyRequest req)
        {
            return InternalRequestAsync<DeleteBaselineStrategyResponse>(req, "DeleteBaselineStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete high-risk command events based on IDs.
        /// </summary>
        /// <param name="req"><see cref="DeleteBashEventsRequest"/></param>
        /// <returns><see cref="DeleteBashEventsResponse"/></returns>
        public Task<DeleteBashEventsResponse> DeleteBashEvents(DeleteBashEventsRequest req)
        {
            return InternalRequestAsync<DeleteBashEventsResponse>(req, "DeleteBashEvents");
        }

        /// <summary>
        /// This API is used to delete high-risk command events based on IDs.
        /// </summary>
        /// <param name="req"><see cref="DeleteBashEventsRequest"/></param>
        /// <returns><see cref="DeleteBashEventsResponse"/></returns>
        public DeleteBashEventsResponse DeleteBashEventsSync(DeleteBashEventsRequest req)
        {
            return InternalRequestAsync<DeleteBashEventsResponse>(req, "DeleteBashEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete high-risk command policies.
        /// </summary>
        /// <param name="req"><see cref="DeleteBashPoliciesRequest"/></param>
        /// <returns><see cref="DeleteBashPoliciesResponse"/></returns>
        public Task<DeleteBashPoliciesResponse> DeleteBashPolicies(DeleteBashPoliciesRequest req)
        {
            return InternalRequestAsync<DeleteBashPoliciesResponse>(req, "DeleteBashPolicies");
        }

        /// <summary>
        /// This API is used to delete high-risk command policies.
        /// </summary>
        /// <param name="req"><see cref="DeleteBashPoliciesRequest"/></param>
        /// <returns><see cref="DeleteBashPoliciesResponse"/></returns>
        public DeleteBashPoliciesResponse DeleteBashPoliciesSync(DeleteBashPoliciesRequest req)
        {
            return InternalRequestAsync<DeleteBashPoliciesResponse>(req, "DeleteBashPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete high-risk command rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteBashRulesRequest"/></param>
        /// <returns><see cref="DeleteBashRulesResponse"/></returns>
        public Task<DeleteBashRulesResponse> DeleteBashRules(DeleteBashRulesRequest req)
        {
            return InternalRequestAsync<DeleteBashRulesResponse>(req, "DeleteBashRules");
        }

        /// <summary>
        /// This API is used to delete high-risk command rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteBashRulesRequest"/></param>
        /// <returns><see cref="DeleteBashRulesResponse"/></returns>
        public DeleteBashRulesResponse DeleteBashRulesSync(DeleteBashRulesRequest req)
        {
            return InternalRequestAsync<DeleteBashRulesResponse>(req, "DeleteBashRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete brute force attack records.
        /// </summary>
        /// <param name="req"><see cref="DeleteBruteAttacksRequest"/></param>
        /// <returns><see cref="DeleteBruteAttacksResponse"/></returns>
        public Task<DeleteBruteAttacksResponse> DeleteBruteAttacks(DeleteBruteAttacksRequest req)
        {
            return InternalRequestAsync<DeleteBruteAttacksResponse>(req, "DeleteBruteAttacks");
        }

        /// <summary>
        /// This API is used to delete brute force attack records.
        /// </summary>
        /// <param name="req"><see cref="DeleteBruteAttacksRequest"/></param>
        /// <returns><see cref="DeleteBruteAttacksResponse"/></returns>
        public DeleteBruteAttacksResponse DeleteBruteAttacksSync(DeleteBruteAttacksRequest req)
        {
            return InternalRequestAsync<DeleteBruteAttacksResponse>(req, "DeleteBruteAttacks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete expired orders in Authorization Management - Order List. (Deleted orders are not counted in statistics.)
        /// </summary>
        /// <param name="req"><see cref="DeleteLicenseRecordRequest"/></param>
        /// <returns><see cref="DeleteLicenseRecordResponse"/></returns>
        public Task<DeleteLicenseRecordResponse> DeleteLicenseRecord(DeleteLicenseRecordRequest req)
        {
            return InternalRequestAsync<DeleteLicenseRecordResponse>(req, "DeleteLicenseRecord");
        }

        /// <summary>
        /// This API is used to delete expired orders in Authorization Management - Order List. (Deleted orders are not counted in statistics.)
        /// </summary>
        /// <param name="req"><see cref="DeleteLicenseRecordRequest"/></param>
        /// <returns><see cref="DeleteLicenseRecordResponse"/></returns>
        public DeleteLicenseRecordResponse DeleteLicenseRecordSync(DeleteLicenseRecordRequest req)
        {
            return InternalRequestAsync<DeleteLicenseRecordResponse>(req, "DeleteLicenseRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete all authorization records.
        /// </summary>
        /// <param name="req"><see cref="DeleteLicenseRecordAllRequest"/></param>
        /// <returns><see cref="DeleteLicenseRecordAllResponse"/></returns>
        public Task<DeleteLicenseRecordAllResponse> DeleteLicenseRecordAll(DeleteLicenseRecordAllRequest req)
        {
            return InternalRequestAsync<DeleteLicenseRecordAllResponse>(req, "DeleteLicenseRecordAll");
        }

        /// <summary>
        /// This API is used to delete all authorization records.
        /// </summary>
        /// <param name="req"><see cref="DeleteLicenseRecordAllRequest"/></param>
        /// <returns><see cref="DeleteLicenseRecordAllResponse"/></returns>
        public DeleteLicenseRecordAllResponse DeleteLicenseRecordAllSync(DeleteLicenseRecordAllRequest req)
        {
            return InternalRequestAsync<DeleteLicenseRecordAllResponse>(req, "DeleteLicenseRecordAll")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete log download tasks.
        /// </summary>
        /// <param name="req"><see cref="DeleteLogExportRequest"/></param>
        /// <returns><see cref="DeleteLogExportResponse"/></returns>
        public Task<DeleteLogExportResponse> DeleteLogExport(DeleteLogExportRequest req)
        {
            return InternalRequestAsync<DeleteLogExportResponse>(req, "DeleteLogExport");
        }

        /// <summary>
        /// This API is used to delete log download tasks.
        /// </summary>
        /// <param name="req"><see cref="DeleteLogExportRequest"/></param>
        /// <returns><see cref="DeleteLogExportResponse"/></returns>
        public DeleteLogExportResponse DeleteLogExportSync(DeleteLogExportRequest req)
        {
            return InternalRequestAsync<DeleteLogExportResponse>(req, "DeleteLogExport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the cross-region log-in allowlist rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteLoginWhiteListRequest"/></param>
        /// <returns><see cref="DeleteLoginWhiteListResponse"/></returns>
        public Task<DeleteLoginWhiteListResponse> DeleteLoginWhiteList(DeleteLoginWhiteListRequest req)
        {
            return InternalRequestAsync<DeleteLoginWhiteListResponse>(req, "DeleteLoginWhiteList");
        }

        /// <summary>
        /// This API is used to delete the cross-region log-in allowlist rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteLoginWhiteListRequest"/></param>
        /// <returns><see cref="DeleteLoginWhiteListResponse"/></returns>
        public DeleteLoginWhiteListResponse DeleteLoginWhiteListSync(DeleteLoginWhiteListRequest req)
        {
            return InternalRequestAsync<DeleteLoginWhiteListResponse>(req, "DeleteLoginWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to uninstall the CWPP client.
        /// </summary>
        /// <param name="req"><see cref="DeleteMachineRequest"/></param>
        /// <returns><see cref="DeleteMachineResponse"/></returns>
        public Task<DeleteMachineResponse> DeleteMachine(DeleteMachineRequest req)
        {
            return InternalRequestAsync<DeleteMachineResponse>(req, "DeleteMachine");
        }

        /// <summary>
        /// This API is used to uninstall the CWPP client.
        /// </summary>
        /// <param name="req"><see cref="DeleteMachineRequest"/></param>
        /// <returns><see cref="DeleteMachineResponse"/></returns>
        public DeleteMachineResponse DeleteMachineSync(DeleteMachineRequest req)
        {
            return InternalRequestAsync<DeleteMachineResponse>(req, "DeleteMachine")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete clearing records of a machine.
        /// </summary>
        /// <param name="req"><see cref="DeleteMachineClearHistoryRequest"/></param>
        /// <returns><see cref="DeleteMachineClearHistoryResponse"/></returns>
        public Task<DeleteMachineClearHistoryResponse> DeleteMachineClearHistory(DeleteMachineClearHistoryRequest req)
        {
            return InternalRequestAsync<DeleteMachineClearHistoryResponse>(req, "DeleteMachineClearHistory");
        }

        /// <summary>
        /// This API is used to delete clearing records of a machine.
        /// </summary>
        /// <param name="req"><see cref="DeleteMachineClearHistoryRequest"/></param>
        /// <returns><see cref="DeleteMachineClearHistoryResponse"/></returns>
        public DeleteMachineClearHistoryResponse DeleteMachineClearHistorySync(DeleteMachineClearHistoryRequest req)
        {
            return InternalRequestAsync<DeleteMachineClearHistoryResponse>(req, "DeleteMachineClearHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete tags associated with the server.
        /// </summary>
        /// <param name="req"><see cref="DeleteMachineTagRequest"/></param>
        /// <returns><see cref="DeleteMachineTagResponse"/></returns>
        public Task<DeleteMachineTagResponse> DeleteMachineTag(DeleteMachineTagRequest req)
        {
            return InternalRequestAsync<DeleteMachineTagResponse>(req, "DeleteMachineTag");
        }

        /// <summary>
        /// This API is used to delete tags associated with the server.
        /// </summary>
        /// <param name="req"><see cref="DeleteMachineTagRequest"/></param>
        /// <returns><see cref="DeleteMachineTagResponse"/></returns>
        public DeleteMachineTagResponse DeleteMachineTagSync(DeleteMachineTagRequest req)
        {
            return InternalRequestAsync<DeleteMachineTagResponse>(req, "DeleteMachineTag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the malicious request allowlist.
        /// </summary>
        /// <param name="req"><see cref="DeleteMaliciousRequestWhiteListRequest"/></param>
        /// <returns><see cref="DeleteMaliciousRequestWhiteListResponse"/></returns>
        public Task<DeleteMaliciousRequestWhiteListResponse> DeleteMaliciousRequestWhiteList(DeleteMaliciousRequestWhiteListRequest req)
        {
            return InternalRequestAsync<DeleteMaliciousRequestWhiteListResponse>(req, "DeleteMaliciousRequestWhiteList");
        }

        /// <summary>
        /// This API is used to delete the malicious request allowlist.
        /// </summary>
        /// <param name="req"><see cref="DeleteMaliciousRequestWhiteListRequest"/></param>
        /// <returns><see cref="DeleteMaliciousRequestWhiteListResponse"/></returns>
        public DeleteMaliciousRequestWhiteListResponse DeleteMaliciousRequestWhiteListSync(DeleteMaliciousRequestWhiteListRequest req)
        {
            return InternalRequestAsync<DeleteMaliciousRequestWhiteListResponse>(req, "DeleteMaliciousRequestWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete malicious request records.
        /// </summary>
        /// <param name="req"><see cref="DeleteMaliciousRequestsRequest"/></param>
        /// <returns><see cref="DeleteMaliciousRequestsResponse"/></returns>
        public Task<DeleteMaliciousRequestsResponse> DeleteMaliciousRequests(DeleteMaliciousRequestsRequest req)
        {
            return InternalRequestAsync<DeleteMaliciousRequestsResponse>(req, "DeleteMaliciousRequests");
        }

        /// <summary>
        /// This API is used to delete malicious request records.
        /// </summary>
        /// <param name="req"><see cref="DeleteMaliciousRequestsRequest"/></param>
        /// <returns><see cref="DeleteMaliciousRequestsResponse"/></returns>
        public DeleteMaliciousRequestsResponse DeleteMaliciousRequestsSync(DeleteMaliciousRequestsRequest req)
        {
            return InternalRequestAsync<DeleteMaliciousRequestsResponse>(req, "DeleteMaliciousRequests")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to terminate the scan tasks.
        /// </summary>
        /// <param name="req"><see cref="DeleteMalwareScanTaskRequest"/></param>
        /// <returns><see cref="DeleteMalwareScanTaskResponse"/></returns>
        public Task<DeleteMalwareScanTaskResponse> DeleteMalwareScanTask(DeleteMalwareScanTaskRequest req)
        {
            return InternalRequestAsync<DeleteMalwareScanTaskResponse>(req, "DeleteMalwareScanTask");
        }

        /// <summary>
        /// This API is used to terminate the scan tasks.
        /// </summary>
        /// <param name="req"><see cref="DeleteMalwareScanTaskRequest"/></param>
        /// <returns><see cref="DeleteMalwareScanTaskResponse"/></returns>
        public DeleteMalwareScanTaskResponse DeleteMalwareScanTaskSync(DeleteMalwareScanTaskRequest req)
        {
            return InternalRequestAsync<DeleteMalwareScanTaskResponse>(req, "DeleteMalwareScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the Trojan whitelist.
        /// </summary>
        /// <param name="req"><see cref="DeleteMalwareWhiteListRequest"/></param>
        /// <returns><see cref="DeleteMalwareWhiteListResponse"/></returns>
        public Task<DeleteMalwareWhiteListResponse> DeleteMalwareWhiteList(DeleteMalwareWhiteListRequest req)
        {
            return InternalRequestAsync<DeleteMalwareWhiteListResponse>(req, "DeleteMalwareWhiteList");
        }

        /// <summary>
        /// This API is used to delete the Trojan whitelist.
        /// </summary>
        /// <param name="req"><see cref="DeleteMalwareWhiteListRequest"/></param>
        /// <returns><see cref="DeleteMalwareWhiteListResponse"/></returns>
        public DeleteMalwareWhiteListResponse DeleteMalwareWhiteListSync(DeleteMalwareWhiteListRequest req)
        {
            return InternalRequestAsync<DeleteMalwareWhiteListResponse>(req, "DeleteMalwareWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete Trojan records.
        /// </summary>
        /// <param name="req"><see cref="DeleteMalwaresRequest"/></param>
        /// <returns><see cref="DeleteMalwaresResponse"/></returns>
        public Task<DeleteMalwaresResponse> DeleteMalwares(DeleteMalwaresRequest req)
        {
            return InternalRequestAsync<DeleteMalwaresResponse>(req, "DeleteMalwares");
        }

        /// <summary>
        /// This API is used to delete Trojan records.
        /// </summary>
        /// <param name="req"><see cref="DeleteMalwaresRequest"/></param>
        /// <returns><see cref="DeleteMalwaresResponse"/></returns>
        public DeleteMalwaresResponse DeleteMalwaresSync(DeleteMalwaresRequest req)
        {
            return InternalRequestAsync<DeleteMalwaresResponse>(req, "DeleteMalwares")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the network attack allowlist.
        /// </summary>
        /// <param name="req"><see cref="DeleteNetAttackWhiteListRequest"/></param>
        /// <returns><see cref="DeleteNetAttackWhiteListResponse"/></returns>
        public Task<DeleteNetAttackWhiteListResponse> DeleteNetAttackWhiteList(DeleteNetAttackWhiteListRequest req)
        {
            return InternalRequestAsync<DeleteNetAttackWhiteListResponse>(req, "DeleteNetAttackWhiteList");
        }

        /// <summary>
        /// This API is used to delete the network attack allowlist.
        /// </summary>
        /// <param name="req"><see cref="DeleteNetAttackWhiteListRequest"/></param>
        /// <returns><see cref="DeleteNetAttackWhiteListResponse"/></returns>
        public DeleteNetAttackWhiteListResponse DeleteNetAttackWhiteListSync(DeleteNetAttackWhiteListRequest req)
        {
            return InternalRequestAsync<DeleteNetAttackWhiteListResponse>(req, "DeleteNetAttackWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete cross-region log-in records.
        /// </summary>
        /// <param name="req"><see cref="DeleteNonlocalLoginPlacesRequest"/></param>
        /// <returns><see cref="DeleteNonlocalLoginPlacesResponse"/></returns>
        public Task<DeleteNonlocalLoginPlacesResponse> DeleteNonlocalLoginPlaces(DeleteNonlocalLoginPlacesRequest req)
        {
            return InternalRequestAsync<DeleteNonlocalLoginPlacesResponse>(req, "DeleteNonlocalLoginPlaces");
        }

        /// <summary>
        /// This API is used to delete cross-region log-in records.
        /// </summary>
        /// <param name="req"><see cref="DeleteNonlocalLoginPlacesRequest"/></param>
        /// <returns><see cref="DeleteNonlocalLoginPlacesResponse"/></returns>
        public DeleteNonlocalLoginPlacesResponse DeleteNonlocalLoginPlacesSync(DeleteNonlocalLoginPlacesRequest req)
        {
            return InternalRequestAsync<DeleteNonlocalLoginPlacesResponse>(req, "DeleteNonlocalLoginPlaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete local privilege escalation based on IDs.
        /// </summary>
        /// <param name="req"><see cref="DeletePrivilegeEventsRequest"/></param>
        /// <returns><see cref="DeletePrivilegeEventsResponse"/></returns>
        public Task<DeletePrivilegeEventsResponse> DeletePrivilegeEvents(DeletePrivilegeEventsRequest req)
        {
            return InternalRequestAsync<DeletePrivilegeEventsResponse>(req, "DeletePrivilegeEvents");
        }

        /// <summary>
        /// This API is used to delete local privilege escalation based on IDs.
        /// </summary>
        /// <param name="req"><see cref="DeletePrivilegeEventsRequest"/></param>
        /// <returns><see cref="DeletePrivilegeEventsResponse"/></returns>
        public DeletePrivilegeEventsResponse DeletePrivilegeEventsSync(DeletePrivilegeEventsRequest req)
        {
            return InternalRequestAsync<DeletePrivilegeEventsResponse>(req, "DeletePrivilegeEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete local privilege elevation rules.
        /// </summary>
        /// <param name="req"><see cref="DeletePrivilegeRulesRequest"/></param>
        /// <returns><see cref="DeletePrivilegeRulesResponse"/></returns>
        public Task<DeletePrivilegeRulesResponse> DeletePrivilegeRules(DeletePrivilegeRulesRequest req)
        {
            return InternalRequestAsync<DeletePrivilegeRulesResponse>(req, "DeletePrivilegeRules");
        }

        /// <summary>
        /// This API is used to delete local privilege elevation rules.
        /// </summary>
        /// <param name="req"><see cref="DeletePrivilegeRulesRequest"/></param>
        /// <returns><see cref="DeletePrivilegeRulesResponse"/></returns>
        public DeletePrivilegeRulesResponse DeletePrivilegeRulesSync(DeletePrivilegeRulesRequest req)
        {
            return InternalRequestAsync<DeletePrivilegeRulesResponse>(req, "DeletePrivilegeRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete Reverse Shell events based on IDs.
        /// </summary>
        /// <param name="req"><see cref="DeleteReverseShellEventsRequest"/></param>
        /// <returns><see cref="DeleteReverseShellEventsResponse"/></returns>
        public Task<DeleteReverseShellEventsResponse> DeleteReverseShellEvents(DeleteReverseShellEventsRequest req)
        {
            return InternalRequestAsync<DeleteReverseShellEventsResponse>(req, "DeleteReverseShellEvents");
        }

        /// <summary>
        /// This API is used to delete Reverse Shell events based on IDs.
        /// </summary>
        /// <param name="req"><see cref="DeleteReverseShellEventsRequest"/></param>
        /// <returns><see cref="DeleteReverseShellEventsResponse"/></returns>
        public DeleteReverseShellEventsResponse DeleteReverseShellEventsSync(DeleteReverseShellEventsRequest req)
        {
            return InternalRequestAsync<DeleteReverseShellEventsResponse>(req, "DeleteReverseShellEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete Reverse Shell rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteReverseShellRulesRequest"/></param>
        /// <returns><see cref="DeleteReverseShellRulesResponse"/></returns>
        public Task<DeleteReverseShellRulesResponse> DeleteReverseShellRules(DeleteReverseShellRulesRequest req)
        {
            return InternalRequestAsync<DeleteReverseShellRulesResponse>(req, "DeleteReverseShellRules");
        }

        /// <summary>
        /// This API is used to delete Reverse Shell rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteReverseShellRulesRequest"/></param>
        /// <returns><see cref="DeleteReverseShellRulesResponse"/></returns>
        public DeleteReverseShellRulesResponse DeleteReverseShellRulesSync(DeleteReverseShellRulesRequest req)
        {
            return InternalRequestAsync<DeleteReverseShellRulesResponse>(req, "DeleteReverseShellRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete malicious request events.
        /// </summary>
        /// <param name="req"><see cref="DeleteRiskDnsEventRequest"/></param>
        /// <returns><see cref="DeleteRiskDnsEventResponse"/></returns>
        public Task<DeleteRiskDnsEventResponse> DeleteRiskDnsEvent(DeleteRiskDnsEventRequest req)
        {
            return InternalRequestAsync<DeleteRiskDnsEventResponse>(req, "DeleteRiskDnsEvent");
        }

        /// <summary>
        /// This API is used to delete malicious request events.
        /// </summary>
        /// <param name="req"><see cref="DeleteRiskDnsEventRequest"/></param>
        /// <returns><see cref="DeleteRiskDnsEventResponse"/></returns>
        public DeleteRiskDnsEventResponse DeleteRiskDnsEventSync(DeleteRiskDnsEventRequest req)
        {
            return InternalRequestAsync<DeleteRiskDnsEventResponse>(req, "DeleteRiskDnsEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete malicious request policies.
        /// </summary>
        /// <param name="req"><see cref="DeleteRiskDnsPolicyRequest"/></param>
        /// <returns><see cref="DeleteRiskDnsPolicyResponse"/></returns>
        public Task<DeleteRiskDnsPolicyResponse> DeleteRiskDnsPolicy(DeleteRiskDnsPolicyRequest req)
        {
            return InternalRequestAsync<DeleteRiskDnsPolicyResponse>(req, "DeleteRiskDnsPolicy");
        }

        /// <summary>
        /// This API is used to delete malicious request policies.
        /// </summary>
        /// <param name="req"><see cref="DeleteRiskDnsPolicyRequest"/></param>
        /// <returns><see cref="DeleteRiskDnsPolicyResponse"/></returns>
        public DeleteRiskDnsPolicyResponse DeleteRiskDnsPolicySync(DeleteRiskDnsPolicyRequest req)
        {
            return InternalRequestAsync<DeleteRiskDnsPolicyResponse>(req, "DeleteRiskDnsPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to stop scan tasks of a specified type.
        /// </summary>
        /// <param name="req"><see cref="DeleteScanTaskRequest"/></param>
        /// <returns><see cref="DeleteScanTaskResponse"/></returns>
        public Task<DeleteScanTaskResponse> DeleteScanTask(DeleteScanTaskRequest req)
        {
            return InternalRequestAsync<DeleteScanTaskResponse>(req, "DeleteScanTask");
        }

        /// <summary>
        /// This API is used to stop scan tasks of a specified type.
        /// </summary>
        /// <param name="req"><see cref="DeleteScanTaskRequest"/></param>
        /// <returns><see cref="DeleteScanTaskResponse"/></returns>
        public DeleteScanTaskResponse DeleteScanTaskSync(DeleteScanTaskRequest req)
        {
            return InternalRequestAsync<DeleteScanTaskResponse>(req, "DeleteScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the retrieval template.
        /// </summary>
        /// <param name="req"><see cref="DeleteSearchTemplateRequest"/></param>
        /// <returns><see cref="DeleteSearchTemplateResponse"/></returns>
        public Task<DeleteSearchTemplateResponse> DeleteSearchTemplate(DeleteSearchTemplateRequest req)
        {
            return InternalRequestAsync<DeleteSearchTemplateResponse>(req, "DeleteSearchTemplate");
        }

        /// <summary>
        /// This API is used to delete the retrieval template.
        /// </summary>
        /// <param name="req"><see cref="DeleteSearchTemplateRequest"/></param>
        /// <returns><see cref="DeleteSearchTemplateResponse"/></returns>
        public DeleteSearchTemplateResponse DeleteSearchTemplateSync(DeleteSearchTemplateRequest req)
        {
            return InternalRequestAsync<DeleteSearchTemplateResponse>(req, "DeleteSearchTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete tags.
        /// </summary>
        /// <param name="req"><see cref="DeleteTagsRequest"/></param>
        /// <returns><see cref="DeleteTagsResponse"/></returns>
        public Task<DeleteTagsResponse> DeleteTags(DeleteTagsRequest req)
        {
            return InternalRequestAsync<DeleteTagsResponse>(req, "DeleteTags");
        }

        /// <summary>
        /// This API is used to delete tags.
        /// </summary>
        /// <param name="req"><see cref="DeleteTagsRequest"/></param>
        /// <returns><see cref="DeleteTagsResponse"/></returns>
        public DeleteTagsResponse DeleteTagsSync(DeleteTagsRequest req)
        {
            return InternalRequestAsync<DeleteTagsResponse>(req, "DeleteTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete alarm policies.
        /// </summary>
        /// <param name="req"><see cref="DeleteWebHookPolicyRequest"/></param>
        /// <returns><see cref="DeleteWebHookPolicyResponse"/></returns>
        public Task<DeleteWebHookPolicyResponse> DeleteWebHookPolicy(DeleteWebHookPolicyRequest req)
        {
            return InternalRequestAsync<DeleteWebHookPolicyResponse>(req, "DeleteWebHookPolicy");
        }

        /// <summary>
        /// This API is used to delete alarm policies.
        /// </summary>
        /// <param name="req"><see cref="DeleteWebHookPolicyRequest"/></param>
        /// <returns><see cref="DeleteWebHookPolicyResponse"/></returns>
        public DeleteWebHookPolicyResponse DeleteWebHookPolicySync(DeleteWebHookPolicyRequest req)
        {
            return InternalRequestAsync<DeleteWebHookPolicyResponse>(req, "DeleteWebHookPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the alert recipient.
        /// </summary>
        /// <param name="req"><see cref="DeleteWebHookReceiverRequest"/></param>
        /// <returns><see cref="DeleteWebHookReceiverResponse"/></returns>
        public Task<DeleteWebHookReceiverResponse> DeleteWebHookReceiver(DeleteWebHookReceiverRequest req)
        {
            return InternalRequestAsync<DeleteWebHookReceiverResponse>(req, "DeleteWebHookReceiver");
        }

        /// <summary>
        /// This API is used to delete the alert recipient.
        /// </summary>
        /// <param name="req"><see cref="DeleteWebHookReceiverRequest"/></param>
        /// <returns><see cref="DeleteWebHookReceiverResponse"/></returns>
        public DeleteWebHookReceiverResponse DeleteWebHookReceiverSync(DeleteWebHookReceiverRequest req)
        {
            return InternalRequestAsync<DeleteWebHookReceiverResponse>(req, "DeleteWebHookReceiver")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the rules of WeCom chatbots.
        /// </summary>
        /// <param name="req"><see cref="DeleteWebHookRuleRequest"/></param>
        /// <returns><see cref="DeleteWebHookRuleResponse"/></returns>
        public Task<DeleteWebHookRuleResponse> DeleteWebHookRule(DeleteWebHookRuleRequest req)
        {
            return InternalRequestAsync<DeleteWebHookRuleResponse>(req, "DeleteWebHookRule");
        }

        /// <summary>
        /// This API is used to delete the rules of WeCom chatbots.
        /// </summary>
        /// <param name="req"><see cref="DeleteWebHookRuleRequest"/></param>
        /// <returns><see cref="DeleteWebHookRuleResponse"/></returns>
        public DeleteWebHookRuleResponse DeleteWebHookRuleSync(DeleteWebHookRuleRequest req)
        {
            return InternalRequestAsync<DeleteWebHookRuleResponse>(req, "DeleteWebHookRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the current grayscale configuration of the user.
        /// </summary>
        /// <param name="req"><see cref="DescribeABTestConfigRequest"/></param>
        /// <returns><see cref="DescribeABTestConfigResponse"/></returns>
        public Task<DescribeABTestConfigResponse> DescribeABTestConfig(DescribeABTestConfigRequest req)
        {
            return InternalRequestAsync<DescribeABTestConfigResponse>(req, "DescribeABTestConfig");
        }

        /// <summary>
        /// This API is used to obtain the current grayscale configuration of the user.
        /// </summary>
        /// <param name="req"><see cref="DescribeABTestConfigRequest"/></param>
        /// <returns><see cref="DescribeABTestConfigResponse"/></returns>
        public DescribeABTestConfigResponse DescribeABTestConfigSync(DescribeABTestConfigRequest req)
        {
            return InternalRequestAsync<DescribeABTestConfigResponse>(req, "DescribeABTestConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the configured aeskey and aesiv.
        /// </summary>
        /// <param name="req"><see cref="DescribeAESKeyRequest"/></param>
        /// <returns><see cref="DescribeAESKeyResponse"/></returns>
        public Task<DescribeAESKeyResponse> DescribeAESKey(DescribeAESKeyRequest req)
        {
            return InternalRequestAsync<DescribeAESKeyResponse>(req, "DescribeAESKey");
        }

        /// <summary>
        /// This API is used to obtain the configured aeskey and aesiv.
        /// </summary>
        /// <param name="req"><see cref="DescribeAESKeyRequest"/></param>
        /// <returns><see cref="DescribeAESKeyResponse"/></returns>
        public DescribeAESKeyResponse DescribeAESKeySync(DescribeAESKeyRequest req)
        {
            return InternalRequestAsync<DescribeAESKeyResponse>(req, "DescribeAESKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the account statistics data.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountStatisticsRequest"/></param>
        /// <returns><see cref="DescribeAccountStatisticsResponse"/></returns>
        public Task<DescribeAccountStatisticsResponse> DescribeAccountStatistics(DescribeAccountStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeAccountStatisticsResponse>(req, "DescribeAccountStatistics");
        }

        /// <summary>
        /// This API is used to obtain the account statistics data.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountStatisticsRequest"/></param>
        /// <returns><see cref="DescribeAccountStatisticsResponse"/></returns>
        public DescribeAccountStatisticsResponse DescribeAccountStatisticsSync(DescribeAccountStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeAccountStatisticsResponse>(req, "DescribeAccountStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the agent installation command.
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentInstallCommandRequest"/></param>
        /// <returns><see cref="DescribeAgentInstallCommandResponse"/></returns>
        public Task<DescribeAgentInstallCommandResponse> DescribeAgentInstallCommand(DescribeAgentInstallCommandRequest req)
        {
            return InternalRequestAsync<DescribeAgentInstallCommandResponse>(req, "DescribeAgentInstallCommand");
        }

        /// <summary>
        /// This API is used to obtain the agent installation command.
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentInstallCommandRequest"/></param>
        /// <returns><see cref="DescribeAgentInstallCommandResponse"/></returns>
        public DescribeAgentInstallCommandResponse DescribeAgentInstallCommandSync(DescribeAgentInstallCommandRequest req)
        {
            return InternalRequestAsync<DescribeAgentInstallCommandResponse>(req, "DescribeAgentInstallCommand")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the token for installing the agent in a hybrid cloud environment.
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentInstallationTokenRequest"/></param>
        /// <returns><see cref="DescribeAgentInstallationTokenResponse"/></returns>
        public Task<DescribeAgentInstallationTokenResponse> DescribeAgentInstallationToken(DescribeAgentInstallationTokenRequest req)
        {
            return InternalRequestAsync<DescribeAgentInstallationTokenResponse>(req, "DescribeAgentInstallationToken");
        }

        /// <summary>
        /// This API is used to obtain the token for installing the agent in a hybrid cloud environment.
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentInstallationTokenRequest"/></param>
        /// <returns><see cref="DescribeAgentInstallationTokenResponse"/></returns>
        public DescribeAgentInstallationTokenResponse DescribeAgentInstallationTokenSync(DescribeAgentInstallationTokenRequest req)
        {
            return InternalRequestAsync<DescribeAgentInstallationTokenResponse>(req, "DescribeAgentInstallationToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain all node information on the event corresponding to an alarm.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmIncidentNodesRequest"/></param>
        /// <returns><see cref="DescribeAlarmIncidentNodesResponse"/></returns>
        public Task<DescribeAlarmIncidentNodesResponse> DescribeAlarmIncidentNodes(DescribeAlarmIncidentNodesRequest req)
        {
            return InternalRequestAsync<DescribeAlarmIncidentNodesResponse>(req, "DescribeAlarmIncidentNodes");
        }

        /// <summary>
        /// This API is used to obtain all node information on the event corresponding to an alarm.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmIncidentNodesRequest"/></param>
        /// <returns><see cref="DescribeAlarmIncidentNodesResponse"/></returns>
        public DescribeAlarmIncidentNodesResponse DescribeAlarmIncidentNodesSync(DescribeAlarmIncidentNodesRequest req)
        {
            return InternalRequestAsync<DescribeAlarmIncidentNodesResponse>(req, "DescribeAlarmIncidentNodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of alarm IDs.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmVertexIdRequest"/></param>
        /// <returns><see cref="DescribeAlarmVertexIdResponse"/></returns>
        public Task<DescribeAlarmVertexIdResponse> DescribeAlarmVertexId(DescribeAlarmVertexIdRequest req)
        {
            return InternalRequestAsync<DescribeAlarmVertexIdResponse>(req, "DescribeAlarmVertexId");
        }

        /// <summary>
        /// This API is used to query the list of alarm IDs.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmVertexIdRequest"/></param>
        /// <returns><see cref="DescribeAlarmVertexIdResponse"/></returns>
        public DescribeAlarmVertexIdResponse DescribeAlarmVertexIdSync(DescribeAlarmVertexIdRequest req)
        {
            return InternalRequestAsync<DescribeAlarmVertexIdResponse>(req, "DescribeAlarmVertexId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the number of all software applications.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetAppCountRequest"/></param>
        /// <returns><see cref="DescribeAssetAppCountResponse"/></returns>
        public Task<DescribeAssetAppCountResponse> DescribeAssetAppCount(DescribeAssetAppCountRequest req)
        {
            return InternalRequestAsync<DescribeAssetAppCountResponse>(req, "DescribeAssetAppCount");
        }

        /// <summary>
        /// This API is used to obtain the number of all software applications.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetAppCountRequest"/></param>
        /// <returns><see cref="DescribeAssetAppCountResponse"/></returns>
        public DescribeAssetAppCountResponse DescribeAssetAppCountSync(DescribeAssetAppCountRequest req)
        {
            return InternalRequestAsync<DescribeAssetAppCountResponse>(req, "DescribeAssetAppCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the application list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetAppListRequest"/></param>
        /// <returns><see cref="DescribeAssetAppListResponse"/></returns>
        public Task<DescribeAssetAppListResponse> DescribeAssetAppList(DescribeAssetAppListRequest req)
        {
            return InternalRequestAsync<DescribeAssetAppListResponse>(req, "DescribeAssetAppList");
        }

        /// <summary>
        /// This API is used to query the application list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetAppListRequest"/></param>
        /// <returns><see cref="DescribeAssetAppListResponse"/></returns>
        public DescribeAssetAppListResponse DescribeAssetAppListSync(DescribeAssetAppListRequest req)
        {
            return InternalRequestAsync<DescribeAssetAppListResponse>(req, "DescribeAssetAppList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of software's associated processes.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetAppProcessListRequest"/></param>
        /// <returns><see cref="DescribeAssetAppProcessListResponse"/></returns>
        public Task<DescribeAssetAppProcessListResponse> DescribeAssetAppProcessList(DescribeAssetAppProcessListRequest req)
        {
            return InternalRequestAsync<DescribeAssetAppProcessListResponse>(req, "DescribeAssetAppProcessList");
        }

        /// <summary>
        /// This API is used to obtain the list of software's associated processes.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetAppProcessListRequest"/></param>
        /// <returns><see cref="DescribeAssetAppProcessListResponse"/></returns>
        public DescribeAssetAppProcessListResponse DescribeAssetAppProcessListSync(DescribeAssetAppProcessListRequest req)
        {
            return InternalRequestAsync<DescribeAssetAppProcessListResponse>(req, "DescribeAssetAppProcessList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the kernel module details.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetCoreModuleInfoRequest"/></param>
        /// <returns><see cref="DescribeAssetCoreModuleInfoResponse"/></returns>
        public Task<DescribeAssetCoreModuleInfoResponse> DescribeAssetCoreModuleInfo(DescribeAssetCoreModuleInfoRequest req)
        {
            return InternalRequestAsync<DescribeAssetCoreModuleInfoResponse>(req, "DescribeAssetCoreModuleInfo");
        }

        /// <summary>
        /// This API is used to obtain the kernel module details.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetCoreModuleInfoRequest"/></param>
        /// <returns><see cref="DescribeAssetCoreModuleInfoResponse"/></returns>
        public DescribeAssetCoreModuleInfoResponse DescribeAssetCoreModuleInfoSync(DescribeAssetCoreModuleInfoRequest req)
        {
            return InternalRequestAsync<DescribeAssetCoreModuleInfoResponse>(req, "DescribeAssetCoreModuleInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of asset management kernel modules.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetCoreModuleListRequest"/></param>
        /// <returns><see cref="DescribeAssetCoreModuleListResponse"/></returns>
        public Task<DescribeAssetCoreModuleListResponse> DescribeAssetCoreModuleList(DescribeAssetCoreModuleListRequest req)
        {
            return InternalRequestAsync<DescribeAssetCoreModuleListResponse>(req, "DescribeAssetCoreModuleList");
        }

        /// <summary>
        /// This API is used to query the list of asset management kernel modules.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetCoreModuleListRequest"/></param>
        /// <returns><see cref="DescribeAssetCoreModuleListResponse"/></returns>
        public DescribeAssetCoreModuleListResponse DescribeAssetCoreModuleListSync(DescribeAssetCoreModuleListRequest req)
        {
            return InternalRequestAsync<DescribeAssetCoreModuleListResponse>(req, "DescribeAssetCoreModuleList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the number of all databases.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetDatabaseCountRequest"/></param>
        /// <returns><see cref="DescribeAssetDatabaseCountResponse"/></returns>
        public Task<DescribeAssetDatabaseCountResponse> DescribeAssetDatabaseCount(DescribeAssetDatabaseCountRequest req)
        {
            return InternalRequestAsync<DescribeAssetDatabaseCountResponse>(req, "DescribeAssetDatabaseCount");
        }

        /// <summary>
        /// This API is used to obtain the number of all databases.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetDatabaseCountRequest"/></param>
        /// <returns><see cref="DescribeAssetDatabaseCountResponse"/></returns>
        public DescribeAssetDatabaseCountResponse DescribeAssetDatabaseCountSync(DescribeAssetDatabaseCountRequest req)
        {
            return InternalRequestAsync<DescribeAssetDatabaseCountResponse>(req, "DescribeAssetDatabaseCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the asset management database details.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetDatabaseInfoRequest"/></param>
        /// <returns><see cref="DescribeAssetDatabaseInfoResponse"/></returns>
        public Task<DescribeAssetDatabaseInfoResponse> DescribeAssetDatabaseInfo(DescribeAssetDatabaseInfoRequest req)
        {
            return InternalRequestAsync<DescribeAssetDatabaseInfoResponse>(req, "DescribeAssetDatabaseInfo");
        }

        /// <summary>
        /// This API is used to obtain the asset management database details.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetDatabaseInfoRequest"/></param>
        /// <returns><see cref="DescribeAssetDatabaseInfoResponse"/></returns>
        public DescribeAssetDatabaseInfoResponse DescribeAssetDatabaseInfoSync(DescribeAssetDatabaseInfoRequest req)
        {
            return InternalRequestAsync<DescribeAssetDatabaseInfoResponse>(req, "DescribeAssetDatabaseInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of asset management databases.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetDatabaseListRequest"/></param>
        /// <returns><see cref="DescribeAssetDatabaseListResponse"/></returns>
        public Task<DescribeAssetDatabaseListResponse> DescribeAssetDatabaseList(DescribeAssetDatabaseListRequest req)
        {
            return InternalRequestAsync<DescribeAssetDatabaseListResponse>(req, "DescribeAssetDatabaseList");
        }

        /// <summary>
        /// This API is used to query the list of asset management databases.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetDatabaseListRequest"/></param>
        /// <returns><see cref="DescribeAssetDatabaseListResponse"/></returns>
        public DescribeAssetDatabaseListResponse DescribeAssetDatabaseListSync(DescribeAssetDatabaseListRequest req)
        {
            return InternalRequestAsync<DescribeAssetDatabaseListResponse>(req, "DescribeAssetDatabaseList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the host disk partition list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetDiskListRequest"/></param>
        /// <returns><see cref="DescribeAssetDiskListResponse"/></returns>
        public Task<DescribeAssetDiskListResponse> DescribeAssetDiskList(DescribeAssetDiskListRequest req)
        {
            return InternalRequestAsync<DescribeAssetDiskListResponse>(req, "DescribeAssetDiskList");
        }

        /// <summary>
        /// This API is used to obtain the host disk partition list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetDiskListRequest"/></param>
        /// <returns><see cref="DescribeAssetDiskListResponse"/></returns>
        public DescribeAssetDiskListResponse DescribeAssetDiskListSync(DescribeAssetDiskListRequest req)
        {
            return InternalRequestAsync<DescribeAssetDiskListResponse>(req, "DescribeAssetDiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of asset management environment variables.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetEnvListRequest"/></param>
        /// <returns><see cref="DescribeAssetEnvListResponse"/></returns>
        public Task<DescribeAssetEnvListResponse> DescribeAssetEnvList(DescribeAssetEnvListRequest req)
        {
            return InternalRequestAsync<DescribeAssetEnvListResponse>(req, "DescribeAssetEnvList");
        }

        /// <summary>
        /// This API is used to query the list of asset management environment variables.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetEnvListRequest"/></param>
        /// <returns><see cref="DescribeAssetEnvListResponse"/></returns>
        public DescribeAssetEnvListResponse DescribeAssetEnvListSync(DescribeAssetEnvListRequest req)
        {
            return InternalRequestAsync<DescribeAssetEnvListResponse>(req, "DescribeAssetEnvList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the total number of resources of the host.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetHostTotalCountRequest"/></param>
        /// <returns><see cref="DescribeAssetHostTotalCountResponse"/></returns>
        public Task<DescribeAssetHostTotalCountResponse> DescribeAssetHostTotalCount(DescribeAssetHostTotalCountRequest req)
        {
            return InternalRequestAsync<DescribeAssetHostTotalCountResponse>(req, "DescribeAssetHostTotalCount");
        }

        /// <summary>
        /// This API is used to obtain the total number of resources of the host.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetHostTotalCountRequest"/></param>
        /// <returns><see cref="DescribeAssetHostTotalCountResponse"/></returns>
        public DescribeAssetHostTotalCountResponse DescribeAssetHostTotalCountSync(DescribeAssetHostTotalCountRequest req)
        {
            return InternalRequestAsync<DescribeAssetHostTotalCountResponse>(req, "DescribeAssetHostTotalCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the number of assets, including hosts, accounts, ports, processes, software, databases, web applications, web frameworks, web services, and web sites.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetInfoRequest"/></param>
        /// <returns><see cref="DescribeAssetInfoResponse"/></returns>
        public Task<DescribeAssetInfoResponse> DescribeAssetInfo(DescribeAssetInfoRequest req)
        {
            return InternalRequestAsync<DescribeAssetInfoResponse>(req, "DescribeAssetInfo");
        }

        /// <summary>
        /// This API is used to obtain the number of assets, including hosts, accounts, ports, processes, software, databases, web applications, web frameworks, web services, and web sites.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetInfoRequest"/></param>
        /// <returns><see cref="DescribeAssetInfoResponse"/></returns>
        public DescribeAssetInfoResponse DescribeAssetInfoSync(DescribeAssetInfoRequest req)
        {
            return InternalRequestAsync<DescribeAssetInfoResponse>(req, "DescribeAssetInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of asset management start services.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetInitServiceListRequest"/></param>
        /// <returns><see cref="DescribeAssetInitServiceListResponse"/></returns>
        public Task<DescribeAssetInitServiceListResponse> DescribeAssetInitServiceList(DescribeAssetInitServiceListRequest req)
        {
            return InternalRequestAsync<DescribeAssetInitServiceListResponse>(req, "DescribeAssetInitServiceList");
        }

        /// <summary>
        /// This API is used to query the list of asset management start services.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetInitServiceListRequest"/></param>
        /// <returns><see cref="DescribeAssetInitServiceListResponse"/></returns>
        public DescribeAssetInitServiceListResponse DescribeAssetInitServiceListSync(DescribeAssetInitServiceListRequest req)
        {
            return InternalRequestAsync<DescribeAssetInitServiceListResponse>(req, "DescribeAssetInitServiceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain Jar package details.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetJarInfoRequest"/></param>
        /// <returns><see cref="DescribeAssetJarInfoResponse"/></returns>
        public Task<DescribeAssetJarInfoResponse> DescribeAssetJarInfo(DescribeAssetJarInfoRequest req)
        {
            return InternalRequestAsync<DescribeAssetJarInfoResponse>(req, "DescribeAssetJarInfo");
        }

        /// <summary>
        /// This API is used to obtain Jar package details.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetJarInfoRequest"/></param>
        /// <returns><see cref="DescribeAssetJarInfoResponse"/></returns>
        public DescribeAssetJarInfoResponse DescribeAssetJarInfoSync(DescribeAssetJarInfoRequest req)
        {
            return InternalRequestAsync<DescribeAssetJarInfoResponse>(req, "DescribeAssetJarInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of Jar packages.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetJarListRequest"/></param>
        /// <returns><see cref="DescribeAssetJarListResponse"/></returns>
        public Task<DescribeAssetJarListResponse> DescribeAssetJarList(DescribeAssetJarListRequest req)
        {
            return InternalRequestAsync<DescribeAssetJarListResponse>(req, "DescribeAssetJarList");
        }

        /// <summary>
        /// This API is used to query the list of Jar packages.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetJarListRequest"/></param>
        /// <returns><see cref="DescribeAssetJarListResponse"/></returns>
        public DescribeAssetJarListResponse DescribeAssetJarListSync(DescribeAssetJarListRequest req)
        {
            return InternalRequestAsync<DescribeAssetJarListResponse>(req, "DescribeAssetJarList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the utilization of the system load, memory, and hard disk.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetLoadInfoRequest"/></param>
        /// <returns><see cref="DescribeAssetLoadInfoResponse"/></returns>
        public Task<DescribeAssetLoadInfoResponse> DescribeAssetLoadInfo(DescribeAssetLoadInfoRequest req)
        {
            return InternalRequestAsync<DescribeAssetLoadInfoResponse>(req, "DescribeAssetLoadInfo");
        }

        /// <summary>
        /// This API is used to obtain the utilization of the system load, memory, and hard disk.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetLoadInfoRequest"/></param>
        /// <returns><see cref="DescribeAssetLoadInfoResponse"/></returns>
        public DescribeAssetLoadInfoResponse DescribeAssetLoadInfoSync(DescribeAssetLoadInfoRequest req)
        {
            return InternalRequestAsync<DescribeAssetLoadInfoResponse>(req, "DescribeAssetLoadInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain asset management host resource details.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetMachineDetailRequest"/></param>
        /// <returns><see cref="DescribeAssetMachineDetailResponse"/></returns>
        public Task<DescribeAssetMachineDetailResponse> DescribeAssetMachineDetail(DescribeAssetMachineDetailRequest req)
        {
            return InternalRequestAsync<DescribeAssetMachineDetailResponse>(req, "DescribeAssetMachineDetail");
        }

        /// <summary>
        /// This API is used to obtain asset management host resource details.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetMachineDetailRequest"/></param>
        /// <returns><see cref="DescribeAssetMachineDetailResponse"/></returns>
        public DescribeAssetMachineDetailResponse DescribeAssetMachineDetailSync(DescribeAssetMachineDetailRequest req)
        {
            return InternalRequestAsync<DescribeAssetMachineDetailResponse>(req, "DescribeAssetMachineDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the resource monitoring list of the asset fingerprint page.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetMachineListRequest"/></param>
        /// <returns><see cref="DescribeAssetMachineListResponse"/></returns>
        public Task<DescribeAssetMachineListResponse> DescribeAssetMachineList(DescribeAssetMachineListRequest req)
        {
            return InternalRequestAsync<DescribeAssetMachineListResponse>(req, "DescribeAssetMachineList");
        }

        /// <summary>
        /// This API is used to obtain the resource monitoring list of the asset fingerprint page.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetMachineListRequest"/></param>
        /// <returns><see cref="DescribeAssetMachineListResponse"/></returns>
        public DescribeAssetMachineListResponse DescribeAssetMachineListSync(DescribeAssetMachineListRequest req)
        {
            return InternalRequestAsync<DescribeAssetMachineListResponse>(req, "DescribeAssetMachineList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain top 5 host tags.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetMachineTagTopRequest"/></param>
        /// <returns><see cref="DescribeAssetMachineTagTopResponse"/></returns>
        public Task<DescribeAssetMachineTagTopResponse> DescribeAssetMachineTagTop(DescribeAssetMachineTagTopRequest req)
        {
            return InternalRequestAsync<DescribeAssetMachineTagTopResponse>(req, "DescribeAssetMachineTagTop");
        }

        /// <summary>
        /// This API is used to obtain top 5 host tags.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetMachineTagTopRequest"/></param>
        /// <returns><see cref="DescribeAssetMachineTagTopResponse"/></returns>
        public DescribeAssetMachineTagTopResponse DescribeAssetMachineTagTopSync(DescribeAssetMachineTagTopRequest req)
        {
            return InternalRequestAsync<DescribeAssetMachineTagTopResponse>(req, "DescribeAssetMachineTagTop")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of asset management plan tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetPlanTaskListRequest"/></param>
        /// <returns><see cref="DescribeAssetPlanTaskListResponse"/></returns>
        public Task<DescribeAssetPlanTaskListResponse> DescribeAssetPlanTaskList(DescribeAssetPlanTaskListRequest req)
        {
            return InternalRequestAsync<DescribeAssetPlanTaskListResponse>(req, "DescribeAssetPlanTaskList");
        }

        /// <summary>
        /// This API is used to query the list of asset management plan tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetPlanTaskListRequest"/></param>
        /// <returns><see cref="DescribeAssetPlanTaskListResponse"/></returns>
        public DescribeAssetPlanTaskListResponse DescribeAssetPlanTaskListSync(DescribeAssetPlanTaskListRequest req)
        {
            return InternalRequestAsync<DescribeAssetPlanTaskListResponse>(req, "DescribeAssetPlanTaskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the total number of ports.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetPortCountRequest"/></param>
        /// <returns><see cref="DescribeAssetPortCountResponse"/></returns>
        public Task<DescribeAssetPortCountResponse> DescribeAssetPortCount(DescribeAssetPortCountRequest req)
        {
            return InternalRequestAsync<DescribeAssetPortCountResponse>(req, "DescribeAssetPortCount");
        }

        /// <summary>
        /// This API is used to obtain the total number of ports.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetPortCountRequest"/></param>
        /// <returns><see cref="DescribeAssetPortCountResponse"/></returns>
        public DescribeAssetPortCountResponse DescribeAssetPortCountSync(DescribeAssetPortCountRequest req)
        {
            return InternalRequestAsync<DescribeAssetPortCountResponse>(req, "DescribeAssetPortCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of asset management ports.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetPortInfoListRequest"/></param>
        /// <returns><see cref="DescribeAssetPortInfoListResponse"/></returns>
        public Task<DescribeAssetPortInfoListResponse> DescribeAssetPortInfoList(DescribeAssetPortInfoListRequest req)
        {
            return InternalRequestAsync<DescribeAssetPortInfoListResponse>(req, "DescribeAssetPortInfoList");
        }

        /// <summary>
        /// This API is used to obtain the list of asset management ports.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetPortInfoListRequest"/></param>
        /// <returns><see cref="DescribeAssetPortInfoListResponse"/></returns>
        public DescribeAssetPortInfoListResponse DescribeAssetPortInfoListSync(DescribeAssetPortInfoListRequest req)
        {
            return InternalRequestAsync<DescribeAssetPortInfoListResponse>(req, "DescribeAssetPortInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the total number of processes.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetProcessCountRequest"/></param>
        /// <returns><see cref="DescribeAssetProcessCountResponse"/></returns>
        public Task<DescribeAssetProcessCountResponse> DescribeAssetProcessCount(DescribeAssetProcessCountRequest req)
        {
            return InternalRequestAsync<DescribeAssetProcessCountResponse>(req, "DescribeAssetProcessCount");
        }

        /// <summary>
        /// This API is used to obtain the total number of processes.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetProcessCountRequest"/></param>
        /// <returns><see cref="DescribeAssetProcessCountResponse"/></returns>
        public DescribeAssetProcessCountResponse DescribeAssetProcessCountSync(DescribeAssetProcessCountRequest req)
        {
            return InternalRequestAsync<DescribeAssetProcessCountResponse>(req, "DescribeAssetProcessCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of asset management processes.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetProcessInfoListRequest"/></param>
        /// <returns><see cref="DescribeAssetProcessInfoListResponse"/></returns>
        public Task<DescribeAssetProcessInfoListResponse> DescribeAssetProcessInfoList(DescribeAssetProcessInfoListRequest req)
        {
            return InternalRequestAsync<DescribeAssetProcessInfoListResponse>(req, "DescribeAssetProcessInfoList");
        }

        /// <summary>
        /// This API is used to obtain the list of asset management processes.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetProcessInfoListRequest"/></param>
        /// <returns><see cref="DescribeAssetProcessInfoListResponse"/></returns>
        public DescribeAssetProcessInfoListResponse DescribeAssetProcessInfoListSync(DescribeAssetProcessInfoListRequest req)
        {
            return InternalRequestAsync<DescribeAssetProcessInfoListResponse>(req, "DescribeAssetProcessInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the latest trend of hosts.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetRecentMachineInfoRequest"/></param>
        /// <returns><see cref="DescribeAssetRecentMachineInfoResponse"/></returns>
        public Task<DescribeAssetRecentMachineInfoResponse> DescribeAssetRecentMachineInfo(DescribeAssetRecentMachineInfoRequest req)
        {
            return InternalRequestAsync<DescribeAssetRecentMachineInfoResponse>(req, "DescribeAssetRecentMachineInfo");
        }

        /// <summary>
        /// This API is used to obtain the latest trend of hosts.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetRecentMachineInfoRequest"/></param>
        /// <returns><see cref="DescribeAssetRecentMachineInfoResponse"/></returns>
        public DescribeAssetRecentMachineInfoResponse DescribeAssetRecentMachineInfoSync(DescribeAssetRecentMachineInfoRequest req)
        {
            return InternalRequestAsync<DescribeAssetRecentMachineInfoResponse>(req, "DescribeAssetRecentMachineInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of system installation packages for asset management.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetSystemPackageListRequest"/></param>
        /// <returns><see cref="DescribeAssetSystemPackageListResponse"/></returns>
        public Task<DescribeAssetSystemPackageListResponse> DescribeAssetSystemPackageList(DescribeAssetSystemPackageListRequest req)
        {
            return InternalRequestAsync<DescribeAssetSystemPackageListResponse>(req, "DescribeAssetSystemPackageList");
        }

        /// <summary>
        /// This API is used to obtain the list of system installation packages for asset management.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetSystemPackageListRequest"/></param>
        /// <returns><see cref="DescribeAssetSystemPackageListResponse"/></returns>
        public DescribeAssetSystemPackageListResponse DescribeAssetSystemPackageListSync(DescribeAssetSystemPackageListRequest req)
        {
            return InternalRequestAsync<DescribeAssetSystemPackageListResponse>(req, "DescribeAssetSystemPackageList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the number of resources, including hosts, accounts, ports, processes, software, databases, web applications, web frameworks, web services, and web sites.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetTotalCountRequest"/></param>
        /// <returns><see cref="DescribeAssetTotalCountResponse"/></returns>
        public Task<DescribeAssetTotalCountResponse> DescribeAssetTotalCount(DescribeAssetTotalCountRequest req)
        {
            return InternalRequestAsync<DescribeAssetTotalCountResponse>(req, "DescribeAssetTotalCount");
        }

        /// <summary>
        /// This API is used to obtain the number of resources, including hosts, accounts, ports, processes, software, databases, web applications, web frameworks, web services, and web sites.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetTotalCountRequest"/></param>
        /// <returns><see cref="DescribeAssetTotalCountResponse"/></returns>
        public DescribeAssetTotalCountResponse DescribeAssetTotalCountSync(DescribeAssetTotalCountRequest req)
        {
            return InternalRequestAsync<DescribeAssetTotalCountResponse>(req, "DescribeAssetTotalCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain Top5 resources of various types.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetTypeTopRequest"/></param>
        /// <returns><see cref="DescribeAssetTypeTopResponse"/></returns>
        public Task<DescribeAssetTypeTopResponse> DescribeAssetTypeTop(DescribeAssetTypeTopRequest req)
        {
            return InternalRequestAsync<DescribeAssetTypeTopResponse>(req, "DescribeAssetTypeTop");
        }

        /// <summary>
        /// This API is used to obtain Top5 resources of various types.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetTypeTopRequest"/></param>
        /// <returns><see cref="DescribeAssetTypeTopResponse"/></returns>
        public DescribeAssetTypeTopResponse DescribeAssetTypeTopSync(DescribeAssetTypeTopRequest req)
        {
            return InternalRequestAsync<DescribeAssetTypeTopResponse>(req, "DescribeAssetTypeTop")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the asset fingerprint type list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetTypesRequest"/></param>
        /// <returns><see cref="DescribeAssetTypesResponse"/></returns>
        public Task<DescribeAssetTypesResponse> DescribeAssetTypes(DescribeAssetTypesRequest req)
        {
            return InternalRequestAsync<DescribeAssetTypesResponse>(req, "DescribeAssetTypes");
        }

        /// <summary>
        /// This API is used to obtain the asset fingerprint type list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetTypesRequest"/></param>
        /// <returns><see cref="DescribeAssetTypesResponse"/></returns>
        public DescribeAssetTypesResponse DescribeAssetTypesSync(DescribeAssetTypesRequest req)
        {
            return InternalRequestAsync<DescribeAssetTypesResponse>(req, "DescribeAssetTypes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the total number of accounts.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetUserCountRequest"/></param>
        /// <returns><see cref="DescribeAssetUserCountResponse"/></returns>
        public Task<DescribeAssetUserCountResponse> DescribeAssetUserCount(DescribeAssetUserCountRequest req)
        {
            return InternalRequestAsync<DescribeAssetUserCountResponse>(req, "DescribeAssetUserCount");
        }

        /// <summary>
        /// This API is used to obtain the total number of accounts.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetUserCountRequest"/></param>
        /// <returns><see cref="DescribeAssetUserCountResponse"/></returns>
        public DescribeAssetUserCountResponse DescribeAssetUserCountSync(DescribeAssetUserCountRequest req)
        {
            return InternalRequestAsync<DescribeAssetUserCountResponse>(req, "DescribeAssetUserCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain host account details.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetUserInfoRequest"/></param>
        /// <returns><see cref="DescribeAssetUserInfoResponse"/></returns>
        public Task<DescribeAssetUserInfoResponse> DescribeAssetUserInfo(DescribeAssetUserInfoRequest req)
        {
            return InternalRequestAsync<DescribeAssetUserInfoResponse>(req, "DescribeAssetUserInfo");
        }

        /// <summary>
        /// This API is used to obtain host account details.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetUserInfoRequest"/></param>
        /// <returns><see cref="DescribeAssetUserInfoResponse"/></returns>
        public DescribeAssetUserInfoResponse DescribeAssetUserInfoSync(DescribeAssetUserInfoRequest req)
        {
            return InternalRequestAsync<DescribeAssetUserInfoResponse>(req, "DescribeAssetUserInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of host account Keys.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetUserKeyListRequest"/></param>
        /// <returns><see cref="DescribeAssetUserKeyListResponse"/></returns>
        public Task<DescribeAssetUserKeyListResponse> DescribeAssetUserKeyList(DescribeAssetUserKeyListRequest req)
        {
            return InternalRequestAsync<DescribeAssetUserKeyListResponse>(req, "DescribeAssetUserKeyList");
        }

        /// <summary>
        /// This API is used to obtain the list of host account Keys.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetUserKeyListRequest"/></param>
        /// <returns><see cref="DescribeAssetUserKeyListResponse"/></returns>
        public DescribeAssetUserKeyListResponse DescribeAssetUserKeyListSync(DescribeAssetUserKeyListRequest req)
        {
            return InternalRequestAsync<DescribeAssetUserKeyListResponse>(req, "DescribeAssetUserKeyList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of accounts.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetUserListRequest"/></param>
        /// <returns><see cref="DescribeAssetUserListResponse"/></returns>
        public Task<DescribeAssetUserListResponse> DescribeAssetUserList(DescribeAssetUserListRequest req)
        {
            return InternalRequestAsync<DescribeAssetUserListResponse>(req, "DescribeAssetUserList");
        }

        /// <summary>
        /// This API is used to obtain the list of accounts.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetUserListRequest"/></param>
        /// <returns><see cref="DescribeAssetUserListResponse"/></returns>
        public DescribeAssetUserListResponse DescribeAssetUserListSync(DescribeAssetUserListRequest req)
        {
            return InternalRequestAsync<DescribeAssetUserListResponse>(req, "DescribeAssetUserList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the number of all web applications.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebAppCountRequest"/></param>
        /// <returns><see cref="DescribeAssetWebAppCountResponse"/></returns>
        public Task<DescribeAssetWebAppCountResponse> DescribeAssetWebAppCount(DescribeAssetWebAppCountRequest req)
        {
            return InternalRequestAsync<DescribeAssetWebAppCountResponse>(req, "DescribeAssetWebAppCount");
        }

        /// <summary>
        /// This API is used to obtain the number of all web applications.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebAppCountRequest"/></param>
        /// <returns><see cref="DescribeAssetWebAppCountResponse"/></returns>
        public DescribeAssetWebAppCountResponse DescribeAssetWebAppCountSync(DescribeAssetWebAppCountRequest req)
        {
            return InternalRequestAsync<DescribeAssetWebAppCountResponse>(req, "DescribeAssetWebAppCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of asset management web applications.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebAppListRequest"/></param>
        /// <returns><see cref="DescribeAssetWebAppListResponse"/></returns>
        public Task<DescribeAssetWebAppListResponse> DescribeAssetWebAppList(DescribeAssetWebAppListRequest req)
        {
            return InternalRequestAsync<DescribeAssetWebAppListResponse>(req, "DescribeAssetWebAppList");
        }

        /// <summary>
        /// This API is used to obtain the list of asset management web applications.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebAppListRequest"/></param>
        /// <returns><see cref="DescribeAssetWebAppListResponse"/></returns>
        public DescribeAssetWebAppListResponse DescribeAssetWebAppListSync(DescribeAssetWebAppListRequest req)
        {
            return InternalRequestAsync<DescribeAssetWebAppListResponse>(req, "DescribeAssetWebAppList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of asset management Web application plugins.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebAppPluginListRequest"/></param>
        /// <returns><see cref="DescribeAssetWebAppPluginListResponse"/></returns>
        public Task<DescribeAssetWebAppPluginListResponse> DescribeAssetWebAppPluginList(DescribeAssetWebAppPluginListRequest req)
        {
            return InternalRequestAsync<DescribeAssetWebAppPluginListResponse>(req, "DescribeAssetWebAppPluginList");
        }

        /// <summary>
        /// This API is used to obtain the list of asset management Web application plugins.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebAppPluginListRequest"/></param>
        /// <returns><see cref="DescribeAssetWebAppPluginListResponse"/></returns>
        public DescribeAssetWebAppPluginListResponse DescribeAssetWebAppPluginListSync(DescribeAssetWebAppPluginListRequest req)
        {
            return InternalRequestAsync<DescribeAssetWebAppPluginListResponse>(req, "DescribeAssetWebAppPluginList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the number of all Web frameworks.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebFrameCountRequest"/></param>
        /// <returns><see cref="DescribeAssetWebFrameCountResponse"/></returns>
        public Task<DescribeAssetWebFrameCountResponse> DescribeAssetWebFrameCount(DescribeAssetWebFrameCountRequest req)
        {
            return InternalRequestAsync<DescribeAssetWebFrameCountResponse>(req, "DescribeAssetWebFrameCount");
        }

        /// <summary>
        /// This API is used to obtain the number of all Web frameworks.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebFrameCountRequest"/></param>
        /// <returns><see cref="DescribeAssetWebFrameCountResponse"/></returns>
        public DescribeAssetWebFrameCountResponse DescribeAssetWebFrameCountSync(DescribeAssetWebFrameCountRequest req)
        {
            return InternalRequestAsync<DescribeAssetWebFrameCountResponse>(req, "DescribeAssetWebFrameCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of asset management Web frameworks.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebFrameListRequest"/></param>
        /// <returns><see cref="DescribeAssetWebFrameListResponse"/></returns>
        public Task<DescribeAssetWebFrameListResponse> DescribeAssetWebFrameList(DescribeAssetWebFrameListRequest req)
        {
            return InternalRequestAsync<DescribeAssetWebFrameListResponse>(req, "DescribeAssetWebFrameList");
        }

        /// <summary>
        /// This API is used to obtain the list of asset management Web frameworks.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebFrameListRequest"/></param>
        /// <returns><see cref="DescribeAssetWebFrameListResponse"/></returns>
        public DescribeAssetWebFrameListResponse DescribeAssetWebFrameListSync(DescribeAssetWebFrameListRequest req)
        {
            return InternalRequestAsync<DescribeAssetWebFrameListResponse>(req, "DescribeAssetWebFrameList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the total number of Web sites.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebLocationCountRequest"/></param>
        /// <returns><see cref="DescribeAssetWebLocationCountResponse"/></returns>
        public Task<DescribeAssetWebLocationCountResponse> DescribeAssetWebLocationCount(DescribeAssetWebLocationCountRequest req)
        {
            return InternalRequestAsync<DescribeAssetWebLocationCountResponse>(req, "DescribeAssetWebLocationCount");
        }

        /// <summary>
        /// This API is used to obtain the total number of Web sites.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebLocationCountRequest"/></param>
        /// <returns><see cref="DescribeAssetWebLocationCountResponse"/></returns>
        public DescribeAssetWebLocationCountResponse DescribeAssetWebLocationCountSync(DescribeAssetWebLocationCountRequest req)
        {
            return InternalRequestAsync<DescribeAssetWebLocationCountResponse>(req, "DescribeAssetWebLocationCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the Web site details.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebLocationInfoRequest"/></param>
        /// <returns><see cref="DescribeAssetWebLocationInfoResponse"/></returns>
        public Task<DescribeAssetWebLocationInfoResponse> DescribeAssetWebLocationInfo(DescribeAssetWebLocationInfoRequest req)
        {
            return InternalRequestAsync<DescribeAssetWebLocationInfoResponse>(req, "DescribeAssetWebLocationInfo");
        }

        /// <summary>
        /// This API is used to obtain the Web site details.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebLocationInfoRequest"/></param>
        /// <returns><see cref="DescribeAssetWebLocationInfoResponse"/></returns>
        public DescribeAssetWebLocationInfoResponse DescribeAssetWebLocationInfoSync(DescribeAssetWebLocationInfoRequest req)
        {
            return InternalRequestAsync<DescribeAssetWebLocationInfoResponse>(req, "DescribeAssetWebLocationInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of Web sites.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebLocationListRequest"/></param>
        /// <returns><see cref="DescribeAssetWebLocationListResponse"/></returns>
        public Task<DescribeAssetWebLocationListResponse> DescribeAssetWebLocationList(DescribeAssetWebLocationListRequest req)
        {
            return InternalRequestAsync<DescribeAssetWebLocationListResponse>(req, "DescribeAssetWebLocationList");
        }

        /// <summary>
        /// This API is used to obtain the list of Web sites.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebLocationListRequest"/></param>
        /// <returns><see cref="DescribeAssetWebLocationListResponse"/></returns>
        public DescribeAssetWebLocationListResponse DescribeAssetWebLocationListSync(DescribeAssetWebLocationListRequest req)
        {
            return InternalRequestAsync<DescribeAssetWebLocationListResponse>(req, "DescribeAssetWebLocationList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of Web sites' virtual directories.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebLocationPathListRequest"/></param>
        /// <returns><see cref="DescribeAssetWebLocationPathListResponse"/></returns>
        public Task<DescribeAssetWebLocationPathListResponse> DescribeAssetWebLocationPathList(DescribeAssetWebLocationPathListRequest req)
        {
            return InternalRequestAsync<DescribeAssetWebLocationPathListResponse>(req, "DescribeAssetWebLocationPathList");
        }

        /// <summary>
        /// This API is used to obtain the list of Web sites' virtual directories.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebLocationPathListRequest"/></param>
        /// <returns><see cref="DescribeAssetWebLocationPathListResponse"/></returns>
        public DescribeAssetWebLocationPathListResponse DescribeAssetWebLocationPathListSync(DescribeAssetWebLocationPathListRequest req)
        {
            return InternalRequestAsync<DescribeAssetWebLocationPathListResponse>(req, "DescribeAssetWebLocationPathList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the number of all web services.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebServiceCountRequest"/></param>
        /// <returns><see cref="DescribeAssetWebServiceCountResponse"/></returns>
        public Task<DescribeAssetWebServiceCountResponse> DescribeAssetWebServiceCount(DescribeAssetWebServiceCountRequest req)
        {
            return InternalRequestAsync<DescribeAssetWebServiceCountResponse>(req, "DescribeAssetWebServiceCount");
        }

        /// <summary>
        /// This API is used to obtain the number of all web services.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebServiceCountRequest"/></param>
        /// <returns><see cref="DescribeAssetWebServiceCountResponse"/></returns>
        public DescribeAssetWebServiceCountResponse DescribeAssetWebServiceCountSync(DescribeAssetWebServiceCountRequest req)
        {
            return InternalRequestAsync<DescribeAssetWebServiceCountResponse>(req, "DescribeAssetWebServiceCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of asset management Web services.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebServiceInfoListRequest"/></param>
        /// <returns><see cref="DescribeAssetWebServiceInfoListResponse"/></returns>
        public Task<DescribeAssetWebServiceInfoListResponse> DescribeAssetWebServiceInfoList(DescribeAssetWebServiceInfoListRequest req)
        {
            return InternalRequestAsync<DescribeAssetWebServiceInfoListResponse>(req, "DescribeAssetWebServiceInfoList");
        }

        /// <summary>
        /// This API is used to query the list of asset management Web services.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebServiceInfoListRequest"/></param>
        /// <returns><see cref="DescribeAssetWebServiceInfoListResponse"/></returns>
        public DescribeAssetWebServiceInfoListResponse DescribeAssetWebServiceInfoListSync(DescribeAssetWebServiceInfoListRequest req)
        {
            return InternalRequestAsync<DescribeAssetWebServiceInfoListResponse>(req, "DescribeAssetWebServiceInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of processes associated with Web services.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebServiceProcessListRequest"/></param>
        /// <returns><see cref="DescribeAssetWebServiceProcessListResponse"/></returns>
        public Task<DescribeAssetWebServiceProcessListResponse> DescribeAssetWebServiceProcessList(DescribeAssetWebServiceProcessListRequest req)
        {
            return InternalRequestAsync<DescribeAssetWebServiceProcessListResponse>(req, "DescribeAssetWebServiceProcessList");
        }

        /// <summary>
        /// This API is used to obtain the list of processes associated with Web services.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebServiceProcessListRequest"/></param>
        /// <returns><see cref="DescribeAssetWebServiceProcessListResponse"/></returns>
        public DescribeAssetWebServiceProcessListResponse DescribeAssetWebServiceProcessListSync(DescribeAssetWebServiceProcessListRequest req)
        {
            return InternalRequestAsync<DescribeAssetWebServiceProcessListResponse>(req, "DescribeAssetWebServiceProcessList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain network attack details.
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackEventInfoRequest"/></param>
        /// <returns><see cref="DescribeAttackEventInfoResponse"/></returns>
        public Task<DescribeAttackEventInfoResponse> DescribeAttackEventInfo(DescribeAttackEventInfoRequest req)
        {
            return InternalRequestAsync<DescribeAttackEventInfoResponse>(req, "DescribeAttackEventInfo");
        }

        /// <summary>
        /// This API is used to obtain network attack details.
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackEventInfoRequest"/></param>
        /// <returns><see cref="DescribeAttackEventInfoResponse"/></returns>
        public DescribeAttackEventInfoResponse DescribeAttackEventInfoSync(DescribeAttackEventInfoRequest req)
        {
            return InternalRequestAsync<DescribeAttackEventInfoResponse>(req, "DescribeAttackEventInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to display the list of network attack detection events in pagination.
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackEventsRequest"/></param>
        /// <returns><see cref="DescribeAttackEventsResponse"/></returns>
        public Task<DescribeAttackEventsResponse> DescribeAttackEvents(DescribeAttackEventsRequest req)
        {
            return InternalRequestAsync<DescribeAttackEventsResponse>(req, "DescribeAttackEvents");
        }

        /// <summary>
        /// This API is used to display the list of network attack detection events in pagination.
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackEventsRequest"/></param>
        /// <returns><see cref="DescribeAttackEventsResponse"/></returns>
        public DescribeAttackEventsResponse DescribeAttackEventsSync(DescribeAttackEventsRequest req)
        {
            return InternalRequestAsync<DescribeAttackEventsResponse>(req, "DescribeAttackEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeAttackEvents 代替
        /// 
        /// This API is used to display the list of network attack logs in pagination.
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackLogsRequest"/></param>
        /// <returns><see cref="DescribeAttackLogsResponse"/></returns>
        public Task<DescribeAttackLogsResponse> DescribeAttackLogs(DescribeAttackLogsRequest req)
        {
            return InternalRequestAsync<DescribeAttackLogsResponse>(req, "DescribeAttackLogs");
        }

        /// <summary>
        /// DescribeAttackEvents 代替
        /// 
        /// This API is used to display the list of network attack logs in pagination.
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackLogsRequest"/></param>
        /// <returns><see cref="DescribeAttackLogsResponse"/></returns>
        public DescribeAttackLogsResponse DescribeAttackLogsSync(DescribeAttackLogsRequest req)
        {
            return InternalRequestAsync<DescribeAttackLogsResponse>(req, "DescribeAttackLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 已废弃
        /// 
        /// This API is used to backtrack attacks.
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackSourceRequest"/></param>
        /// <returns><see cref="DescribeAttackSourceResponse"/></returns>
        public Task<DescribeAttackSourceResponse> DescribeAttackSource(DescribeAttackSourceRequest req)
        {
            return InternalRequestAsync<DescribeAttackSourceResponse>(req, "DescribeAttackSource");
        }

        /// <summary>
        /// 已废弃
        /// 
        /// This API is used to backtrack attacks.
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackSourceRequest"/></param>
        /// <returns><see cref="DescribeAttackSourceResponse"/></returns>
        public DescribeAttackSourceResponse DescribeAttackSourceSync(DescribeAttackSourceRequest req)
        {
            return InternalRequestAsync<DescribeAttackSourceResponse>(req, "DescribeAttackSource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 已废弃
        /// 
        /// This API is used to query attack backtracking events.
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackSourceEventsRequest"/></param>
        /// <returns><see cref="DescribeAttackSourceEventsResponse"/></returns>
        public Task<DescribeAttackSourceEventsResponse> DescribeAttackSourceEvents(DescribeAttackSourceEventsRequest req)
        {
            return InternalRequestAsync<DescribeAttackSourceEventsResponse>(req, "DescribeAttackSourceEvents");
        }

        /// <summary>
        /// 已废弃
        /// 
        /// This API is used to query attack backtracking events.
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackSourceEventsRequest"/></param>
        /// <returns><see cref="DescribeAttackSourceEventsResponse"/></returns>
        public DescribeAttackSourceEventsResponse DescribeAttackSourceEventsSync(DescribeAttackSourceEventsRequest req)
        {
            return InternalRequestAsync<DescribeAttackSourceEventsResponse>(req, "DescribeAttackSourceEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the statistics of network attack data.
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackStatisticsRequest"/></param>
        /// <returns><see cref="DescribeAttackStatisticsResponse"/></returns>
        public Task<DescribeAttackStatisticsResponse> DescribeAttackStatistics(DescribeAttackStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeAttackStatisticsResponse>(req, "DescribeAttackStatistics");
        }

        /// <summary>
        /// This API is used to obtain the statistics of network attack data.
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackStatisticsRequest"/></param>
        /// <returns><see cref="DescribeAttackStatisticsResponse"/></returns>
        public DescribeAttackStatisticsResponse DescribeAttackStatisticsSync(DescribeAttackStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeAttackStatisticsResponse>(req, "DescribeAttackStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of Top 5 network attacks.
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackTopRequest"/></param>
        /// <returns><see cref="DescribeAttackTopResponse"/></returns>
        public Task<DescribeAttackTopResponse> DescribeAttackTop(DescribeAttackTopRequest req)
        {
            return InternalRequestAsync<DescribeAttackTopResponse>(req, "DescribeAttackTop");
        }

        /// <summary>
        /// This API is used to obtain the list of Top 5 network attacks.
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackTopRequest"/></param>
        /// <returns><see cref="DescribeAttackTopResponse"/></returns>
        public DescribeAttackTopResponse DescribeAttackTopSync(DescribeAttackTopRequest req)
        {
            return InternalRequestAsync<DescribeAttackTopResponse>(req, "DescribeAttackTop")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the network attack trend data.
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackTrendsRequest"/></param>
        /// <returns><see cref="DescribeAttackTrendsResponse"/></returns>
        public Task<DescribeAttackTrendsResponse> DescribeAttackTrends(DescribeAttackTrendsRequest req)
        {
            return InternalRequestAsync<DescribeAttackTrendsResponse>(req, "DescribeAttackTrends");
        }

        /// <summary>
        /// This API is used to obtain the network attack trend data.
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackTrendsRequest"/></param>
        /// <returns><see cref="DescribeAttackTrendsResponse"/></returns>
        public DescribeAttackTrendsResponse DescribeAttackTrendsSync(DescribeAttackTrendsRequest req)
        {
            return InternalRequestAsync<DescribeAttackTrendsResponse>(req, "DescribeAttackTrends")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of network attack threat types.
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackVulTypeListRequest"/></param>
        /// <returns><see cref="DescribeAttackVulTypeListResponse"/></returns>
        public Task<DescribeAttackVulTypeListResponse> DescribeAttackVulTypeList(DescribeAttackVulTypeListRequest req)
        {
            return InternalRequestAsync<DescribeAttackVulTypeListResponse>(req, "DescribeAttackVulTypeList");
        }

        /// <summary>
        /// This API is used to obtain the list of network attack threat types.
        /// </summary>
        /// <param name="req"><see cref="DescribeAttackVulTypeListRequest"/></param>
        /// <returns><see cref="DescribeAttackVulTypeListResponse"/></returns>
        public DescribeAttackVulTypeListResponse DescribeAttackVulTypeListSync(DescribeAttackVulTypeListRequest req)
        {
            return InternalRequestAsync<DescribeAttackVulTypeListResponse>(req, "DescribeAttackVulTypeList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain available order details.
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableExpertServiceDetailRequest"/></param>
        /// <returns><see cref="DescribeAvailableExpertServiceDetailResponse"/></returns>
        public Task<DescribeAvailableExpertServiceDetailResponse> DescribeAvailableExpertServiceDetail(DescribeAvailableExpertServiceDetailRequest req)
        {
            return InternalRequestAsync<DescribeAvailableExpertServiceDetailResponse>(req, "DescribeAvailableExpertServiceDetail");
        }

        /// <summary>
        /// This API is used to obtain available order details.
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableExpertServiceDetailRequest"/></param>
        /// <returns><see cref="DescribeAvailableExpertServiceDetailResponse"/></returns>
        public DescribeAvailableExpertServiceDetailResponse DescribeAvailableExpertServiceDetailSync(DescribeAvailableExpertServiceDetailRequest req)
        {
            return InternalRequestAsync<DescribeAvailableExpertServiceDetailResponse>(req, "DescribeAvailableExpertServiceDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the brute-force blocking mode.
        /// </summary>
        /// <param name="req"><see cref="DescribeBanModeRequest"/></param>
        /// <returns><see cref="DescribeBanModeResponse"/></returns>
        public Task<DescribeBanModeResponse> DescribeBanMode(DescribeBanModeRequest req)
        {
            return InternalRequestAsync<DescribeBanModeResponse>(req, "DescribeBanMode");
        }

        /// <summary>
        /// This API is used to obtain the brute-force blocking mode.
        /// </summary>
        /// <param name="req"><see cref="DescribeBanModeRequest"/></param>
        /// <returns><see cref="DescribeBanModeResponse"/></returns>
        public DescribeBanModeResponse DescribeBanModeSync(DescribeBanModeRequest req)
        {
            return InternalRequestAsync<DescribeBanModeResponse>(req, "DescribeBanMode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the block region.
        /// </summary>
        /// <param name="req"><see cref="DescribeBanRegionsRequest"/></param>
        /// <returns><see cref="DescribeBanRegionsResponse"/></returns>
        public Task<DescribeBanRegionsResponse> DescribeBanRegions(DescribeBanRegionsRequest req)
        {
            return InternalRequestAsync<DescribeBanRegionsResponse>(req, "DescribeBanRegions");
        }

        /// <summary>
        /// This API is used to obtain the block region.
        /// </summary>
        /// <param name="req"><see cref="DescribeBanRegionsRequest"/></param>
        /// <returns><see cref="DescribeBanRegionsResponse"/></returns>
        public DescribeBanRegionsResponse DescribeBanRegionsSync(DescribeBanRegionsRequest req)
        {
            return InternalRequestAsync<DescribeBanRegionsResponse>(req, "DescribeBanRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the block button status.
        /// </summary>
        /// <param name="req"><see cref="DescribeBanStatusRequest"/></param>
        /// <returns><see cref="DescribeBanStatusResponse"/></returns>
        public Task<DescribeBanStatusResponse> DescribeBanStatus(DescribeBanStatusRequest req)
        {
            return InternalRequestAsync<DescribeBanStatusResponse>(req, "DescribeBanStatus");
        }

        /// <summary>
        /// This API is used to obtain the block button status.
        /// </summary>
        /// <param name="req"><see cref="DescribeBanStatusRequest"/></param>
        /// <returns><see cref="DescribeBanStatusResponse"/></returns>
        public DescribeBanStatusResponse DescribeBanStatusSync(DescribeBanStatusRequest req)
        {
            return InternalRequestAsync<DescribeBanStatusResponse>(req, "DescribeBanStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the blocking allowlist list.
        /// </summary>
        /// <param name="req"><see cref="DescribeBanWhiteListRequest"/></param>
        /// <returns><see cref="DescribeBanWhiteListResponse"/></returns>
        public Task<DescribeBanWhiteListResponse> DescribeBanWhiteList(DescribeBanWhiteListRequest req)
        {
            return InternalRequestAsync<DescribeBanWhiteListResponse>(req, "DescribeBanWhiteList");
        }

        /// <summary>
        /// This API is used to obtain the blocking allowlist list.
        /// </summary>
        /// <param name="req"><see cref="DescribeBanWhiteListRequest"/></param>
        /// <returns><see cref="DescribeBanWhiteListResponse"/></returns>
        public DescribeBanWhiteListResponse DescribeBanWhiteListSync(DescribeBanWhiteListRequest req)
        {
            return InternalRequestAsync<DescribeBanWhiteListResponse>(req, "DescribeBanWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of baseline basic information.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineBasicInfoRequest"/></param>
        /// <returns><see cref="DescribeBaselineBasicInfoResponse"/></returns>
        public Task<DescribeBaselineBasicInfoResponse> DescribeBaselineBasicInfo(DescribeBaselineBasicInfoRequest req)
        {
            return InternalRequestAsync<DescribeBaselineBasicInfoResponse>(req, "DescribeBaselineBasicInfo");
        }

        /// <summary>
        /// This API is used to query the list of baseline basic information.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineBasicInfoRequest"/></param>
        /// <returns><see cref="DescribeBaselineBasicInfoResponse"/></returns>
        public DescribeBaselineBasicInfoResponse DescribeBaselineBasicInfoSync(DescribeBaselineBasicInfoRequest req)
        {
            return InternalRequestAsync<DescribeBaselineBasicInfoResponse>(req, "DescribeBaselineBasicInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list information of default policies of the baseline.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineDefaultStrategyListRequest"/></param>
        /// <returns><see cref="DescribeBaselineDefaultStrategyListResponse"/></returns>
        public Task<DescribeBaselineDefaultStrategyListResponse> DescribeBaselineDefaultStrategyList(DescribeBaselineDefaultStrategyListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineDefaultStrategyListResponse>(req, "DescribeBaselineDefaultStrategyList");
        }

        /// <summary>
        /// This API is used to query the list information of default policies of the baseline.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineDefaultStrategyListRequest"/></param>
        /// <returns><see cref="DescribeBaselineDefaultStrategyListResponse"/></returns>
        public DescribeBaselineDefaultStrategyListResponse DescribeBaselineDefaultStrategyListSync(DescribeBaselineDefaultStrategyListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineDefaultStrategyListResponse>(req, "DescribeBaselineDefaultStrategyList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query baseline details by baseline ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineDetailRequest"/></param>
        /// <returns><see cref="DescribeBaselineDetailResponse"/></returns>
        public Task<DescribeBaselineDetailResponse> DescribeBaselineDetail(DescribeBaselineDetailRequest req)
        {
            return InternalRequestAsync<DescribeBaselineDetailResponse>(req, "DescribeBaselineDetail");
        }

        /// <summary>
        /// This API is used to query baseline details by baseline ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineDetailRequest"/></param>
        /// <returns><see cref="DescribeBaselineDetailResponse"/></returns>
        public DescribeBaselineDetailResponse DescribeBaselineDetailSync(DescribeBaselineDetailRequest req)
        {
            return InternalRequestAsync<DescribeBaselineDetailResponse>(req, "DescribeBaselineDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of hosts affected by a baseline based on baseline ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineEffectHostListRequest"/></param>
        /// <returns><see cref="DescribeBaselineEffectHostListResponse"/></returns>
        public Task<DescribeBaselineEffectHostListResponse> DescribeBaselineEffectHostList(DescribeBaselineEffectHostListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineEffectHostListResponse>(req, "DescribeBaselineEffectHostList");
        }

        /// <summary>
        /// This API is used to query the list of hosts affected by a baseline based on baseline ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineEffectHostListRequest"/></param>
        /// <returns><see cref="DescribeBaselineEffectHostListResponse"/></returns>
        public DescribeBaselineEffectHostListResponse DescribeBaselineEffectHostListSync(DescribeBaselineEffectHostListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineEffectHostListResponse>(req, "DescribeBaselineEffectHostList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of hosts for baseline detection.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineHostDetectListRequest"/></param>
        /// <returns><see cref="DescribeBaselineHostDetectListResponse"/></returns>
        public Task<DescribeBaselineHostDetectListResponse> DescribeBaselineHostDetectList(DescribeBaselineHostDetectListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineHostDetectListResponse>(req, "DescribeBaselineHostDetectList");
        }

        /// <summary>
        /// This API is used to obtain the list of hosts for baseline detection.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineHostDetectListRequest"/></param>
        /// <returns><see cref="DescribeBaselineHostDetectListResponse"/></returns>
        public DescribeBaselineHostDetectListResponse DescribeBaselineHostDetectListSync(DescribeBaselineHostDetectListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineHostDetectListResponse>(req, "DescribeBaselineHostDetectList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to return Top N risky servers.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineHostTopRequest"/></param>
        /// <returns><see cref="DescribeBaselineHostTopResponse"/></returns>
        public Task<DescribeBaselineHostTopResponse> DescribeBaselineHostTop(DescribeBaselineHostTopRequest req)
        {
            return InternalRequestAsync<DescribeBaselineHostTopResponse>(req, "DescribeBaselineHostTop");
        }

        /// <summary>
        /// This API is used to return Top N risky servers.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineHostTopRequest"/></param>
        /// <returns><see cref="DescribeBaselineHostTopResponse"/></returns>
        public DescribeBaselineHostTopResponse DescribeBaselineHostTopSync(DescribeBaselineHostTopRequest req)
        {
            return InternalRequestAsync<DescribeBaselineHostTopResponse>(req, "DescribeBaselineHostTop")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of baseline detection items.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineItemDetectListRequest"/></param>
        /// <returns><see cref="DescribeBaselineItemDetectListResponse"/></returns>
        public Task<DescribeBaselineItemDetectListResponse> DescribeBaselineItemDetectList(DescribeBaselineItemDetectListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineItemDetectListResponse>(req, "DescribeBaselineItemDetectList");
        }

        /// <summary>
        /// This API is used to obtain the list of baseline detection items.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineItemDetectListRequest"/></param>
        /// <returns><see cref="DescribeBaselineItemDetectListResponse"/></returns>
        public DescribeBaselineItemDetectListResponse DescribeBaselineItemDetectListSync(DescribeBaselineItemDetectListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineItemDetectListResponse>(req, "DescribeBaselineItemDetectList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of check results on baseline check items.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineItemListRequest"/></param>
        /// <returns><see cref="DescribeBaselineItemListResponse"/></returns>
        public Task<DescribeBaselineItemListResponse> DescribeBaselineItemList(DescribeBaselineItemListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineItemListResponse>(req, "DescribeBaselineItemList");
        }

        /// <summary>
        /// This API is used to obtain the list of check results on baseline check items.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineItemListRequest"/></param>
        /// <returns><see cref="DescribeBaselineItemListResponse"/></returns>
        public DescribeBaselineItemListResponse DescribeBaselineItemListSync(DescribeBaselineItemListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineItemListResponse>(req, "DescribeBaselineItemList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of the baseline list.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineListRequest"/></param>
        /// <returns><see cref="DescribeBaselineListResponse"/></returns>
        public Task<DescribeBaselineListResponse> DescribeBaselineList(DescribeBaselineListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineListResponse>(req, "DescribeBaselineList");
        }

        /// <summary>
        /// This API is used to query the information of the baseline list.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineListRequest"/></param>
        /// <returns><see cref="DescribeBaselineListResponse"/></returns>
        public DescribeBaselineListResponse DescribeBaselineListSync(DescribeBaselineListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineListResponse>(req, "DescribeBaselineList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of baseline policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselinePolicyListRequest"/></param>
        /// <returns><see cref="DescribeBaselinePolicyListResponse"/></returns>
        public Task<DescribeBaselinePolicyListResponse> DescribeBaselinePolicyList(DescribeBaselinePolicyListRequest req)
        {
            return InternalRequestAsync<DescribeBaselinePolicyListResponse>(req, "DescribeBaselinePolicyList");
        }

        /// <summary>
        /// This API is used to obtain the list of baseline policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselinePolicyListRequest"/></param>
        /// <returns><see cref="DescribeBaselinePolicyListResponse"/></returns>
        public DescribeBaselinePolicyListResponse DescribeBaselinePolicyListSync(DescribeBaselinePolicyListRequest req)
        {
            return InternalRequestAsync<DescribeBaselinePolicyListResponse>(req, "DescribeBaselinePolicyList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information on corresponding check items based on baseline ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineRuleRequest"/></param>
        /// <returns><see cref="DescribeBaselineRuleResponse"/></returns>
        public Task<DescribeBaselineRuleResponse> DescribeBaselineRule(DescribeBaselineRuleRequest req)
        {
            return InternalRequestAsync<DescribeBaselineRuleResponse>(req, "DescribeBaselineRule");
        }

        /// <summary>
        /// This API is used to query the information on corresponding check items based on baseline ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineRuleRequest"/></param>
        /// <returns><see cref="DescribeBaselineRuleResponse"/></returns>
        public DescribeBaselineRuleResponse DescribeBaselineRuleSync(DescribeBaselineRuleRequest req)
        {
            return InternalRequestAsync<DescribeBaselineRuleResponse>(req, "DescribeBaselineRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the baseline detection progress by task ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineScanScheduleRequest"/></param>
        /// <returns><see cref="DescribeBaselineScanScheduleResponse"/></returns>
        public Task<DescribeBaselineScanScheduleResponse> DescribeBaselineScanSchedule(DescribeBaselineScanScheduleRequest req)
        {
            return InternalRequestAsync<DescribeBaselineScanScheduleResponse>(req, "DescribeBaselineScanSchedule");
        }

        /// <summary>
        /// This API is used to query the baseline detection progress by task ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineScanScheduleRequest"/></param>
        /// <returns><see cref="DescribeBaselineScanScheduleResponse"/></returns>
        public DescribeBaselineScanScheduleResponse DescribeBaselineScanScheduleSync(DescribeBaselineScanScheduleRequest req)
        {
            return InternalRequestAsync<DescribeBaselineScanScheduleResponse>(req, "DescribeBaselineScanSchedule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query policy details by baseline policy ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineStrategyDetailRequest"/></param>
        /// <returns><see cref="DescribeBaselineStrategyDetailResponse"/></returns>
        public Task<DescribeBaselineStrategyDetailResponse> DescribeBaselineStrategyDetail(DescribeBaselineStrategyDetailRequest req)
        {
            return InternalRequestAsync<DescribeBaselineStrategyDetailResponse>(req, "DescribeBaselineStrategyDetail");
        }

        /// <summary>
        /// This API is used to query policy details by baseline policy ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineStrategyDetailRequest"/></param>
        /// <returns><see cref="DescribeBaselineStrategyDetailResponse"/></returns>
        public DescribeBaselineStrategyDetailResponse DescribeBaselineStrategyDetailSync(DescribeBaselineStrategyDetailRequest req)
        {
            return InternalRequestAsync<DescribeBaselineStrategyDetailResponse>(req, "DescribeBaselineStrategyDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of baseline policies under the same user.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineStrategyListRequest"/></param>
        /// <returns><see cref="DescribeBaselineStrategyListResponse"/></returns>
        public Task<DescribeBaselineStrategyListResponse> DescribeBaselineStrategyList(DescribeBaselineStrategyListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineStrategyListResponse>(req, "DescribeBaselineStrategyList");
        }

        /// <summary>
        /// This API is used to query the information of baseline policies under the same user.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineStrategyListRequest"/></param>
        /// <returns><see cref="DescribeBaselineStrategyListResponse"/></returns>
        public DescribeBaselineStrategyListResponse DescribeBaselineStrategyListSync(DescribeBaselineStrategyListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineStrategyListResponse>(req, "DescribeBaselineStrategyList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query TOP baseline detection items based on policy IDs.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineTopRequest"/></param>
        /// <returns><see cref="DescribeBaselineTopResponse"/></returns>
        public Task<DescribeBaselineTopResponse> DescribeBaselineTop(DescribeBaselineTopRequest req)
        {
            return InternalRequestAsync<DescribeBaselineTopResponse>(req, "DescribeBaselineTop");
        }

        /// <summary>
        /// This API is used to query TOP baseline detection items based on policy IDs.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineTopRequest"/></param>
        /// <returns><see cref="DescribeBaselineTopResponse"/></returns>
        public DescribeBaselineTopResponse DescribeBaselineTopSync(DescribeBaselineTopRequest req)
        {
            return InternalRequestAsync<DescribeBaselineTopResponse>(req, "DescribeBaselineTop")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of baseline weak passwords.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineWeakPasswordListRequest"/></param>
        /// <returns><see cref="DescribeBaselineWeakPasswordListResponse"/></returns>
        public Task<DescribeBaselineWeakPasswordListResponse> DescribeBaselineWeakPasswordList(DescribeBaselineWeakPasswordListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineWeakPasswordListResponse>(req, "DescribeBaselineWeakPasswordList");
        }

        /// <summary>
        /// This API is used to obtain the list of baseline weak passwords.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineWeakPasswordListRequest"/></param>
        /// <returns><see cref="DescribeBaselineWeakPasswordListResponse"/></returns>
        public DescribeBaselineWeakPasswordListResponse DescribeBaselineWeakPasswordListSync(DescribeBaselineWeakPasswordListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineWeakPasswordListResponse>(req, "DescribeBaselineWeakPasswordList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the high-risk command list.
        /// </summary>
        /// <param name="req"><see cref="DescribeBashEventsRequest"/></param>
        /// <returns><see cref="DescribeBashEventsResponse"/></returns>
        public Task<DescribeBashEventsResponse> DescribeBashEvents(DescribeBashEventsRequest req)
        {
            return InternalRequestAsync<DescribeBashEventsResponse>(req, "DescribeBashEvents");
        }

        /// <summary>
        /// This API is used to obtain the high-risk command list.
        /// </summary>
        /// <param name="req"><see cref="DescribeBashEventsRequest"/></param>
        /// <returns><see cref="DescribeBashEventsResponse"/></returns>
        public DescribeBashEventsResponse DescribeBashEventsSync(DescribeBashEventsRequest req)
        {
            return InternalRequestAsync<DescribeBashEventsResponse>(req, "DescribeBashEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query high-risk command event details.
        /// </summary>
        /// <param name="req"><see cref="DescribeBashEventsInfoRequest"/></param>
        /// <returns><see cref="DescribeBashEventsInfoResponse"/></returns>
        public Task<DescribeBashEventsInfoResponse> DescribeBashEventsInfo(DescribeBashEventsInfoRequest req)
        {
            return InternalRequestAsync<DescribeBashEventsInfoResponse>(req, "DescribeBashEventsInfo");
        }

        /// <summary>
        /// This API is used to query high-risk command event details.
        /// </summary>
        /// <param name="req"><see cref="DescribeBashEventsInfoRequest"/></param>
        /// <returns><see cref="DescribeBashEventsInfoResponse"/></returns>
        public DescribeBashEventsInfoResponse DescribeBashEventsInfoSync(DescribeBashEventsInfoRequest req)
        {
            return InternalRequestAsync<DescribeBashEventsInfoResponse>(req, "DescribeBashEventsInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query high-risk command event details (new).
        /// </summary>
        /// <param name="req"><see cref="DescribeBashEventsInfoNewRequest"/></param>
        /// <returns><see cref="DescribeBashEventsInfoNewResponse"/></returns>
        public Task<DescribeBashEventsInfoNewResponse> DescribeBashEventsInfoNew(DescribeBashEventsInfoNewRequest req)
        {
            return InternalRequestAsync<DescribeBashEventsInfoNewResponse>(req, "DescribeBashEventsInfoNew");
        }

        /// <summary>
        /// This API is used to query high-risk command event details (new).
        /// </summary>
        /// <param name="req"><see cref="DescribeBashEventsInfoNewRequest"/></param>
        /// <returns><see cref="DescribeBashEventsInfoNewResponse"/></returns>
        public DescribeBashEventsInfoNewResponse DescribeBashEventsInfoNewSync(DescribeBashEventsInfoNewRequest req)
        {
            return InternalRequestAsync<DescribeBashEventsInfoNewResponse>(req, "DescribeBashEventsInfoNew")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of high-risk commands (new).
        /// </summary>
        /// <param name="req"><see cref="DescribeBashEventsNewRequest"/></param>
        /// <returns><see cref="DescribeBashEventsNewResponse"/></returns>
        public Task<DescribeBashEventsNewResponse> DescribeBashEventsNew(DescribeBashEventsNewRequest req)
        {
            return InternalRequestAsync<DescribeBashEventsNewResponse>(req, "DescribeBashEventsNew");
        }

        /// <summary>
        /// This API is used to obtain the list of high-risk commands (new).
        /// </summary>
        /// <param name="req"><see cref="DescribeBashEventsNewRequest"/></param>
        /// <returns><see cref="DescribeBashEventsNewResponse"/></returns>
        public DescribeBashEventsNewResponse DescribeBashEventsNewSync(DescribeBashEventsNewRequest req)
        {
            return InternalRequestAsync<DescribeBashEventsNewResponse>(req, "DescribeBashEventsNew")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of high-risk command policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeBashPoliciesRequest"/></param>
        /// <returns><see cref="DescribeBashPoliciesResponse"/></returns>
        public Task<DescribeBashPoliciesResponse> DescribeBashPolicies(DescribeBashPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeBashPoliciesResponse>(req, "DescribeBashPolicies");
        }

        /// <summary>
        /// This API is used to obtain the list of high-risk command policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeBashPoliciesRequest"/></param>
        /// <returns><see cref="DescribeBashPoliciesResponse"/></returns>
        public DescribeBashPoliciesResponse DescribeBashPoliciesSync(DescribeBashPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeBashPoliciesResponse>(req, "DescribeBashPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of high-risk command rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeBashRulesRequest"/></param>
        /// <returns><see cref="DescribeBashRulesResponse"/></returns>
        public Task<DescribeBashRulesResponse> DescribeBashRules(DescribeBashRulesRequest req)
        {
            return InternalRequestAsync<DescribeBashRulesResponse>(req, "DescribeBashRules");
        }

        /// <summary>
        /// This API is used to obtain the list of high-risk command rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeBashRulesRequest"/></param>
        /// <returns><see cref="DescribeBashRulesResponse"/></returns>
        public DescribeBashRulesResponse DescribeBashRulesSync(DescribeBashRulesRequest req)
        {
            return InternalRequestAsync<DescribeBashRulesResponse>(req, "DescribeBashRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of password cracking.
        /// </summary>
        /// <param name="req"><see cref="DescribeBruteAttackListRequest"/></param>
        /// <returns><see cref="DescribeBruteAttackListResponse"/></returns>
        public Task<DescribeBruteAttackListResponse> DescribeBruteAttackList(DescribeBruteAttackListRequest req)
        {
            return InternalRequestAsync<DescribeBruteAttackListResponse>(req, "DescribeBruteAttackList");
        }

        /// <summary>
        /// This API is used to obtain the list of password cracking.
        /// </summary>
        /// <param name="req"><see cref="DescribeBruteAttackListRequest"/></param>
        /// <returns><see cref="DescribeBruteAttackListResponse"/></returns>
        public DescribeBruteAttackListResponse DescribeBruteAttackListSync(DescribeBruteAttackListRequest req)
        {
            return InternalRequestAsync<DescribeBruteAttackListResponse>(req, "DescribeBruteAttackList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain brute force cracking rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeBruteAttackRulesRequest"/></param>
        /// <returns><see cref="DescribeBruteAttackRulesResponse"/></returns>
        public Task<DescribeBruteAttackRulesResponse> DescribeBruteAttackRules(DescribeBruteAttackRulesRequest req)
        {
            return InternalRequestAsync<DescribeBruteAttackRulesResponse>(req, "DescribeBruteAttackRules");
        }

        /// <summary>
        /// This API is used to obtain brute force cracking rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeBruteAttackRulesRequest"/></param>
        /// <returns><see cref="DescribeBruteAttackRulesResponse"/></returns>
        public DescribeBruteAttackRulesResponse DescribeBruteAttackRulesSync(DescribeBruteAttackRulesRequest req)
        {
            return InternalRequestAsync<DescribeBruteAttackRulesResponse>(req, "DescribeBruteAttackRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the fixable host information.
        /// </summary>
        /// <param name="req"><see cref="DescribeCanFixVulMachineRequest"/></param>
        /// <returns><see cref="DescribeCanFixVulMachineResponse"/></returns>
        public Task<DescribeCanFixVulMachineResponse> DescribeCanFixVulMachine(DescribeCanFixVulMachineRequest req)
        {
            return InternalRequestAsync<DescribeCanFixVulMachineResponse>(req, "DescribeCanFixVulMachine");
        }

        /// <summary>
        /// This API is used to query the fixable host information.
        /// </summary>
        /// <param name="req"><see cref="DescribeCanFixVulMachineRequest"/></param>
        /// <returns><see cref="DescribeCanFixVulMachineResponse"/></returns>
        public DescribeCanFixVulMachineResponse DescribeCanFixVulMachineSync(DescribeCanFixVulMachineRequest req)
        {
            return InternalRequestAsync<DescribeCanFixVulMachineResponse>(req, "DescribeCanFixVulMachine")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain hosts where Trojans cannot be isolated.
        /// </summary>
        /// <param name="req"><see cref="DescribeCanNotSeparateMachineRequest"/></param>
        /// <returns><see cref="DescribeCanNotSeparateMachineResponse"/></returns>
        public Task<DescribeCanNotSeparateMachineResponse> DescribeCanNotSeparateMachine(DescribeCanNotSeparateMachineRequest req)
        {
            return InternalRequestAsync<DescribeCanNotSeparateMachineResponse>(req, "DescribeCanNotSeparateMachine");
        }

        /// <summary>
        /// This API is used to obtain hosts where Trojans cannot be isolated.
        /// </summary>
        /// <param name="req"><see cref="DescribeCanNotSeparateMachineRequest"/></param>
        /// <returns><see cref="DescribeCanNotSeparateMachineResponse"/></returns>
        public DescribeCanNotSeparateMachineResponse DescribeCanNotSeparateMachineSync(DescribeCanNotSeparateMachineRequest req)
        {
            return InternalRequestAsync<DescribeCanNotSeparateMachineResponse>(req, "DescribeCanNotSeparateMachine")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain client exception events.
        /// </summary>
        /// <param name="req"><see cref="DescribeClientExceptionRequest"/></param>
        /// <returns><see cref="DescribeClientExceptionResponse"/></returns>
        public Task<DescribeClientExceptionResponse> DescribeClientException(DescribeClientExceptionRequest req)
        {
            return InternalRequestAsync<DescribeClientExceptionResponse>(req, "DescribeClientException");
        }

        /// <summary>
        /// This API is used to obtain client exception events.
        /// </summary>
        /// <param name="req"><see cref="DescribeClientExceptionRequest"/></param>
        /// <returns><see cref="DescribeClientExceptionResponse"/></returns>
        public DescribeClientExceptionResponse DescribeClientExceptionSync(DescribeClientExceptionRequest req)
        {
            return InternalRequestAsync<DescribeClientExceptionResponse>(req, "DescribeClientException")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 接口已无效
        /// 
        /// This API is used to obtain the data of the component statistics list.
        /// </summary>
        /// <param name="req"><see cref="DescribeComponentStatisticsRequest"/></param>
        /// <returns><see cref="DescribeComponentStatisticsResponse"/></returns>
        public Task<DescribeComponentStatisticsResponse> DescribeComponentStatistics(DescribeComponentStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeComponentStatisticsResponse>(req, "DescribeComponentStatistics");
        }

        /// <summary>
        /// 接口已无效
        /// 
        /// This API is used to obtain the data of the component statistics list.
        /// </summary>
        /// <param name="req"><see cref="DescribeComponentStatisticsRequest"/></param>
        /// <returns><see cref="DescribeComponentStatisticsResponse"/></returns>
        public DescribeComponentStatisticsResponse DescribeComponentStatisticsSync(DescribeComponentStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeComponentStatisticsResponse>(req, "DescribeComponentStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain vulnerability defense event details.
        /// </summary>
        /// <param name="req"><see cref="DescribeDefenceEventDetailRequest"/></param>
        /// <returns><see cref="DescribeDefenceEventDetailResponse"/></returns>
        public Task<DescribeDefenceEventDetailResponse> DescribeDefenceEventDetail(DescribeDefenceEventDetailRequest req)
        {
            return InternalRequestAsync<DescribeDefenceEventDetailResponse>(req, "DescribeDefenceEventDetail");
        }

        /// <summary>
        /// This API is used to obtain vulnerability defense event details.
        /// </summary>
        /// <param name="req"><see cref="DescribeDefenceEventDetailRequest"/></param>
        /// <returns><see cref="DescribeDefenceEventDetailResponse"/></returns>
        public DescribeDefenceEventDetailResponse DescribeDefenceEventDetailSync(DescribeDefenceEventDetailRequest req)
        {
            return InternalRequestAsync<DescribeDefenceEventDetailResponse>(req, "DescribeDefenceEventDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain DC agent installation command, including the token.
        /// </summary>
        /// <param name="req"><see cref="DescribeDirectConnectInstallCommandRequest"/></param>
        /// <returns><see cref="DescribeDirectConnectInstallCommandResponse"/></returns>
        public Task<DescribeDirectConnectInstallCommandResponse> DescribeDirectConnectInstallCommand(DescribeDirectConnectInstallCommandRequest req)
        {
            return InternalRequestAsync<DescribeDirectConnectInstallCommandResponse>(req, "DescribeDirectConnectInstallCommand");
        }

        /// <summary>
        /// This API is used to obtain DC agent installation command, including the token.
        /// </summary>
        /// <param name="req"><see cref="DescribeDirectConnectInstallCommandRequest"/></param>
        /// <returns><see cref="DescribeDirectConnectInstallCommandResponse"/></returns>
        public DescribeDirectConnectInstallCommandResponse DescribeDirectConnectInstallCommandSync(DescribeDirectConnectInstallCommandRequest req)
        {
            return InternalRequestAsync<DescribeDirectConnectInstallCommandResponse>(req, "DescribeDirectConnectInstallCommand")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the aggregation result of the ES field.
        /// </summary>
        /// <param name="req"><see cref="DescribeESAggregationsRequest"/></param>
        /// <returns><see cref="DescribeESAggregationsResponse"/></returns>
        public Task<DescribeESAggregationsResponse> DescribeESAggregations(DescribeESAggregationsRequest req)
        {
            return InternalRequestAsync<DescribeESAggregationsResponse>(req, "DescribeESAggregations");
        }

        /// <summary>
        /// This API is used to obtain the aggregation result of the ES field.
        /// </summary>
        /// <param name="req"><see cref="DescribeESAggregationsRequest"/></param>
        /// <returns><see cref="DescribeESAggregationsResponse"/></returns>
        public DescribeESAggregationsResponse DescribeESAggregationsSync(DescribeESAggregationsRequest req)
        {
            return InternalRequestAsync<DescribeESAggregationsResponse>(req, "DescribeESAggregations")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the emergency response list.
        /// </summary>
        /// <param name="req"><see cref="DescribeEmergencyResponseListRequest"/></param>
        /// <returns><see cref="DescribeEmergencyResponseListResponse"/></returns>
        public Task<DescribeEmergencyResponseListResponse> DescribeEmergencyResponseList(DescribeEmergencyResponseListRequest req)
        {
            return InternalRequestAsync<DescribeEmergencyResponseListResponse>(req, "DescribeEmergencyResponseList");
        }

        /// <summary>
        /// This API is used to obtain the emergency response list.
        /// </summary>
        /// <param name="req"><see cref="DescribeEmergencyResponseListRequest"/></param>
        /// <returns><see cref="DescribeEmergencyResponseListResponse"/></returns>
        public DescribeEmergencyResponseListResponse DescribeEmergencyResponseListSync(DescribeEmergencyResponseListRequest req)
        {
            return InternalRequestAsync<DescribeEmergencyResponseListResponse>(req, "DescribeEmergencyResponseList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of emergency vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="DescribeEmergencyVulListRequest"/></param>
        /// <returns><see cref="DescribeEmergencyVulListResponse"/></returns>
        public Task<DescribeEmergencyVulListResponse> DescribeEmergencyVulList(DescribeEmergencyVulListRequest req)
        {
            return InternalRequestAsync<DescribeEmergencyVulListResponse>(req, "DescribeEmergencyVulList");
        }

        /// <summary>
        /// This API is used to obtain the list of emergency vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="DescribeEmergencyVulListRequest"/></param>
        /// <returns><see cref="DescribeEmergencyVulListResponse"/></returns>
        public DescribeEmergencyVulListResponse DescribeEmergencyVulListSync(DescribeEmergencyVulListRequest req)
        {
            return InternalRequestAsync<DescribeEmergencyVulListResponse>(req, "DescribeEmergencyVulList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query alarm event details based on event table names and IDs.
        /// </summary>
        /// <param name="req"><see cref="DescribeEventByTableRequest"/></param>
        /// <returns><see cref="DescribeEventByTableResponse"/></returns>
        public Task<DescribeEventByTableResponse> DescribeEventByTable(DescribeEventByTableRequest req)
        {
            return InternalRequestAsync<DescribeEventByTableResponse>(req, "DescribeEventByTable");
        }

        /// <summary>
        /// This API is used to query alarm event details based on event table names and IDs.
        /// </summary>
        /// <param name="req"><see cref="DescribeEventByTableRequest"/></param>
        /// <returns><see cref="DescribeEventByTableResponse"/></returns>
        public DescribeEventByTableResponse DescribeEventByTableSync(DescribeEventByTableRequest req)
        {
            return InternalRequestAsync<DescribeEventByTableResponse>(req, "DescribeEventByTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the security manager list.
        /// </summary>
        /// <param name="req"><see cref="DescribeExpertServiceListRequest"/></param>
        /// <returns><see cref="DescribeExpertServiceListResponse"/></returns>
        public Task<DescribeExpertServiceListResponse> DescribeExpertServiceList(DescribeExpertServiceListRequest req)
        {
            return InternalRequestAsync<DescribeExpertServiceListResponse>(req, "DescribeExpertServiceList");
        }

        /// <summary>
        /// This API is used to obtain the security manager list.
        /// </summary>
        /// <param name="req"><see cref="DescribeExpertServiceListRequest"/></param>
        /// <returns><see cref="DescribeExpertServiceListResponse"/></returns>
        public DescribeExpertServiceListResponse DescribeExpertServiceListSync(DescribeExpertServiceListRequest req)
        {
            return InternalRequestAsync<DescribeExpertServiceListResponse>(req, "DescribeExpertServiceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the expert service order list.
        /// </summary>
        /// <param name="req"><see cref="DescribeExpertServiceOrderListRequest"/></param>
        /// <returns><see cref="DescribeExpertServiceOrderListResponse"/></returns>
        public Task<DescribeExpertServiceOrderListResponse> DescribeExpertServiceOrderList(DescribeExpertServiceOrderListRequest req)
        {
            return InternalRequestAsync<DescribeExpertServiceOrderListResponse>(req, "DescribeExpertServiceOrderList");
        }

        /// <summary>
        /// This API is used to obtain the expert service order list.
        /// </summary>
        /// <param name="req"><see cref="DescribeExpertServiceOrderListRequest"/></param>
        /// <returns><see cref="DescribeExpertServiceOrderListResponse"/></returns>
        public DescribeExpertServiceOrderListResponse DescribeExpertServiceOrderListSync(DescribeExpertServiceOrderListRequest req)
        {
            return InternalRequestAsync<DescribeExpertServiceOrderListResponse>(req, "DescribeExpertServiceOrderList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the list of hosts in a specific region.
        /// </summary>
        /// <param name="req"><see cref="DescribeExportMachinesRequest"/></param>
        /// <returns><see cref="DescribeExportMachinesResponse"/></returns>
        public Task<DescribeExportMachinesResponse> DescribeExportMachines(DescribeExportMachinesRequest req)
        {
            return InternalRequestAsync<DescribeExportMachinesResponse>(req, "DescribeExportMachines");
        }

        /// <summary>
        /// This API is used to export the list of hosts in a specific region.
        /// </summary>
        /// <param name="req"><see cref="DescribeExportMachinesRequest"/></param>
        /// <returns><see cref="DescribeExportMachinesResponse"/></returns>
        public DescribeExportMachinesResponse DescribeExportMachinesSync(DescribeExportMachinesRequest req)
        {
            return InternalRequestAsync<DescribeExportMachinesResponse>(req, "DescribeExportMachines")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to quickly analyze and count logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeFastAnalysisRequest"/></param>
        /// <returns><see cref="DescribeFastAnalysisResponse"/></returns>
        public Task<DescribeFastAnalysisResponse> DescribeFastAnalysis(DescribeFastAnalysisRequest req)
        {
            return InternalRequestAsync<DescribeFastAnalysisResponse>(req, "DescribeFastAnalysis");
        }

        /// <summary>
        /// This API is used to quickly analyze and count logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeFastAnalysisRequest"/></param>
        /// <returns><see cref="DescribeFastAnalysisResponse"/></returns>
        public DescribeFastAnalysisResponse DescribeFastAnalysisSync(DescribeFastAnalysisRequest req)
        {
            return InternalRequestAsync<DescribeFastAnalysisResponse>(req, "DescribeFastAnalysis")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to view the rule details API when an event occurs.
        /// </summary>
        /// <param name="req"><see cref="DescribeFileTamperEventRuleInfoRequest"/></param>
        /// <returns><see cref="DescribeFileTamperEventRuleInfoResponse"/></returns>
        public Task<DescribeFileTamperEventRuleInfoResponse> DescribeFileTamperEventRuleInfo(DescribeFileTamperEventRuleInfoRequest req)
        {
            return InternalRequestAsync<DescribeFileTamperEventRuleInfoResponse>(req, "DescribeFileTamperEventRuleInfo");
        }

        /// <summary>
        /// This API is used to view the rule details API when an event occurs.
        /// </summary>
        /// <param name="req"><see cref="DescribeFileTamperEventRuleInfoRequest"/></param>
        /// <returns><see cref="DescribeFileTamperEventRuleInfoResponse"/></returns>
        public DescribeFileTamperEventRuleInfoResponse DescribeFileTamperEventRuleInfoSync(DescribeFileTamperEventRuleInfoRequest req)
        {
            return InternalRequestAsync<DescribeFileTamperEventRuleInfoResponse>(req, "DescribeFileTamperEventRuleInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of core file monitoring events.
        /// </summary>
        /// <param name="req"><see cref="DescribeFileTamperEventsRequest"/></param>
        /// <returns><see cref="DescribeFileTamperEventsResponse"/></returns>
        public Task<DescribeFileTamperEventsResponse> DescribeFileTamperEvents(DescribeFileTamperEventsRequest req)
        {
            return InternalRequestAsync<DescribeFileTamperEventsResponse>(req, "DescribeFileTamperEvents");
        }

        /// <summary>
        /// This API is used to obtain the list of core file monitoring events.
        /// </summary>
        /// <param name="req"><see cref="DescribeFileTamperEventsRequest"/></param>
        /// <returns><see cref="DescribeFileTamperEventsResponse"/></returns>
        public DescribeFileTamperEventsResponse DescribeFileTamperEventsSync(DescribeFileTamperEventsRequest req)
        {
            return InternalRequestAsync<DescribeFileTamperEventsResponse>(req, "DescribeFileTamperEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the number of rules for monitoring files associated with a host.
        /// </summary>
        /// <param name="req"><see cref="DescribeFileTamperRuleCountRequest"/></param>
        /// <returns><see cref="DescribeFileTamperRuleCountResponse"/></returns>
        public Task<DescribeFileTamperRuleCountResponse> DescribeFileTamperRuleCount(DescribeFileTamperRuleCountRequest req)
        {
            return InternalRequestAsync<DescribeFileTamperRuleCountResponse>(req, "DescribeFileTamperRuleCount");
        }

        /// <summary>
        /// This API is used to query the number of rules for monitoring files associated with a host.
        /// </summary>
        /// <param name="req"><see cref="DescribeFileTamperRuleCountRequest"/></param>
        /// <returns><see cref="DescribeFileTamperRuleCountResponse"/></returns>
        public DescribeFileTamperRuleCountResponse DescribeFileTamperRuleCountSync(DescribeFileTamperRuleCountRequest req)
        {
            return InternalRequestAsync<DescribeFileTamperRuleCountResponse>(req, "DescribeFileTamperRuleCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query details of a monitoring rule.
        /// </summary>
        /// <param name="req"><see cref="DescribeFileTamperRuleInfoRequest"/></param>
        /// <returns><see cref="DescribeFileTamperRuleInfoResponse"/></returns>
        public Task<DescribeFileTamperRuleInfoResponse> DescribeFileTamperRuleInfo(DescribeFileTamperRuleInfoRequest req)
        {
            return InternalRequestAsync<DescribeFileTamperRuleInfoResponse>(req, "DescribeFileTamperRuleInfo");
        }

        /// <summary>
        /// This API is used to query details of a monitoring rule.
        /// </summary>
        /// <param name="req"><see cref="DescribeFileTamperRuleInfoRequest"/></param>
        /// <returns><see cref="DescribeFileTamperRuleInfoResponse"/></returns>
        public DescribeFileTamperRuleInfoResponse DescribeFileTamperRuleInfoSync(DescribeFileTamperRuleInfoRequest req)
        {
            return InternalRequestAsync<DescribeFileTamperRuleInfoResponse>(req, "DescribeFileTamperRuleInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of core file monitoring rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeFileTamperRulesRequest"/></param>
        /// <returns><see cref="DescribeFileTamperRulesResponse"/></returns>
        public Task<DescribeFileTamperRulesResponse> DescribeFileTamperRules(DescribeFileTamperRulesRequest req)
        {
            return InternalRequestAsync<DescribeFileTamperRulesResponse>(req, "DescribeFileTamperRules");
        }

        /// <summary>
        /// This API is used to obtain the list of core file monitoring rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeFileTamperRulesRequest"/></param>
        /// <returns><see cref="DescribeFileTamperRulesResponse"/></returns>
        public DescribeFileTamperRulesResponse DescribeFileTamperRulesSync(DescribeFileTamperRulesRequest req)
        {
            return InternalRequestAsync<DescribeFileTamperRulesResponse>(req, "DescribeFileTamperRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the statistics data of hosts.
        /// </summary>
        /// <param name="req"><see cref="DescribeGeneralStatRequest"/></param>
        /// <returns><see cref="DescribeGeneralStatResponse"/></returns>
        public Task<DescribeGeneralStatResponse> DescribeGeneralStat(DescribeGeneralStatRequest req)
        {
            return InternalRequestAsync<DescribeGeneralStatResponse>(req, "DescribeGeneralStat");
        }

        /// <summary>
        /// This API is used to obtain the statistics data of hosts.
        /// </summary>
        /// <param name="req"><see cref="DescribeGeneralStatRequest"/></param>
        /// <returns><see cref="DescribeGeneralStatResponse"/></returns>
        public DescribeGeneralStatResponse DescribeGeneralStatSync(DescribeGeneralStatRequest req)
        {
            return InternalRequestAsync<DescribeGeneralStatResponse>(req, "DescribeGeneralStat")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the data of the account change history list.
        /// </summary>
        /// <param name="req"><see cref="DescribeHistoryAccountsRequest"/></param>
        /// <returns><see cref="DescribeHistoryAccountsResponse"/></returns>
        public Task<DescribeHistoryAccountsResponse> DescribeHistoryAccounts(DescribeHistoryAccountsRequest req)
        {
            return InternalRequestAsync<DescribeHistoryAccountsResponse>(req, "DescribeHistoryAccounts");
        }

        /// <summary>
        /// This API is used to obtain the data of the account change history list.
        /// </summary>
        /// <param name="req"><see cref="DescribeHistoryAccountsRequest"/></param>
        /// <returns><see cref="DescribeHistoryAccountsResponse"/></returns>
        public DescribeHistoryAccountsResponse DescribeHistoryAccountsSync(DescribeHistoryAccountsRequest req)
        {
            return InternalRequestAsync<DescribeHistoryAccountsResponse>(req, "DescribeHistoryAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the log retrieval service information.
        /// </summary>
        /// <param name="req"><see cref="DescribeHistoryServiceRequest"/></param>
        /// <returns><see cref="DescribeHistoryServiceResponse"/></returns>
        public Task<DescribeHistoryServiceResponse> DescribeHistoryService(DescribeHistoryServiceRequest req)
        {
            return InternalRequestAsync<DescribeHistoryServiceResponse>(req, "DescribeHistoryService");
        }

        /// <summary>
        /// This API is used to query the log retrieval service information.
        /// </summary>
        /// <param name="req"><see cref="DescribeHistoryServiceRequest"/></param>
        /// <returns><see cref="DescribeHistoryServiceResponse"/></returns>
        public DescribeHistoryServiceResponse DescribeHistoryServiceSync(DescribeHistoryServiceRequest req)
        {
            return InternalRequestAsync<DescribeHistoryServiceResponse>(req, "DescribeHistoryService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the host and tag information.
        /// </summary>
        /// <param name="req"><see cref="DescribeHostInfoRequest"/></param>
        /// <returns><see cref="DescribeHostInfoResponse"/></returns>
        public Task<DescribeHostInfoResponse> DescribeHostInfo(DescribeHostInfoRequest req)
        {
            return InternalRequestAsync<DescribeHostInfoResponse>(req, "DescribeHostInfo");
        }

        /// <summary>
        /// This API is used to query the host and tag information.
        /// </summary>
        /// <param name="req"><see cref="DescribeHostInfoRequest"/></param>
        /// <returns><see cref="DescribeHostInfoResponse"/></returns>
        public DescribeHostInfoResponse DescribeHostInfoSync(DescribeHostInfoRequest req)
        {
            return InternalRequestAsync<DescribeHostInfoResponse>(req, "DescribeHostInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to retrieve the log-in audit list.
        /// </summary>
        /// <param name="req"><see cref="DescribeHostLoginListRequest"/></param>
        /// <returns><see cref="DescribeHostLoginListResponse"/></returns>
        public Task<DescribeHostLoginListResponse> DescribeHostLoginList(DescribeHostLoginListRequest req)
        {
            return InternalRequestAsync<DescribeHostLoginListResponse>(req, "DescribeHostLoginList");
        }

        /// <summary>
        /// This API is used to retrieve the log-in audit list.
        /// </summary>
        /// <param name="req"><see cref="DescribeHostLoginListRequest"/></param>
        /// <returns><see cref="DescribeHostLoginListResponse"/></returns>
        public DescribeHostLoginListResponse DescribeHostLoginListSync(DescribeHostLoginListRequest req)
        {
            return InternalRequestAsync<DescribeHostLoginListResponse>(req, "DescribeHostLoginList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain hot spot vulnerabilities across the entire network.
        /// </summary>
        /// <param name="req"><see cref="DescribeHotVulTopRequest"/></param>
        /// <returns><see cref="DescribeHotVulTopResponse"/></returns>
        public Task<DescribeHotVulTopResponse> DescribeHotVulTop(DescribeHotVulTopRequest req)
        {
            return InternalRequestAsync<DescribeHotVulTopResponse>(req, "DescribeHotVulTop");
        }

        /// <summary>
        /// This API is used to obtain hot spot vulnerabilities across the entire network.
        /// </summary>
        /// <param name="req"><see cref="DescribeHotVulTopRequest"/></param>
        /// <returns><see cref="DescribeHotVulTopResponse"/></returns>
        public DescribeHotVulTopResponse DescribeHotVulTopSync(DescribeHotVulTopRequest req)
        {
            return InternalRequestAsync<DescribeHotVulTopResponse>(req, "DescribeHotVulTop")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of ignored inspection items.
        /// </summary>
        /// <param name="req"><see cref="DescribeIgnoreBaselineRuleRequest"/></param>
        /// <returns><see cref="DescribeIgnoreBaselineRuleResponse"/></returns>
        public Task<DescribeIgnoreBaselineRuleResponse> DescribeIgnoreBaselineRule(DescribeIgnoreBaselineRuleRequest req)
        {
            return InternalRequestAsync<DescribeIgnoreBaselineRuleResponse>(req, "DescribeIgnoreBaselineRule");
        }

        /// <summary>
        /// This API is used to query the information of ignored inspection items.
        /// </summary>
        /// <param name="req"><see cref="DescribeIgnoreBaselineRuleRequest"/></param>
        /// <returns><see cref="DescribeIgnoreBaselineRuleResponse"/></returns>
        public DescribeIgnoreBaselineRuleResponse DescribeIgnoreBaselineRuleSync(DescribeIgnoreBaselineRuleRequest req)
        {
            return InternalRequestAsync<DescribeIgnoreBaselineRuleResponse>(req, "DescribeIgnoreBaselineRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the information of affected inspection items and hosts ignored with one click.
        /// </summary>
        /// <param name="req"><see cref="DescribeIgnoreHostAndItemConfigRequest"/></param>
        /// <returns><see cref="DescribeIgnoreHostAndItemConfigResponse"/></returns>
        public Task<DescribeIgnoreHostAndItemConfigResponse> DescribeIgnoreHostAndItemConfig(DescribeIgnoreHostAndItemConfigRequest req)
        {
            return InternalRequestAsync<DescribeIgnoreHostAndItemConfigResponse>(req, "DescribeIgnoreHostAndItemConfig");
        }

        /// <summary>
        /// This API is used to obtain the information of affected inspection items and hosts ignored with one click.
        /// </summary>
        /// <param name="req"><see cref="DescribeIgnoreHostAndItemConfigRequest"/></param>
        /// <returns><see cref="DescribeIgnoreHostAndItemConfigResponse"/></returns>
        public DescribeIgnoreHostAndItemConfigResponse DescribeIgnoreHostAndItemConfigSync(DescribeIgnoreHostAndItemConfigRequest req)
        {
            return InternalRequestAsync<DescribeIgnoreHostAndItemConfigResponse>(req, "DescribeIgnoreHostAndItemConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information on the list of hosts affected by ignored detection items based on detection item IDs and filter criteria.
        /// </summary>
        /// <param name="req"><see cref="DescribeIgnoreRuleEffectHostListRequest"/></param>
        /// <returns><see cref="DescribeIgnoreRuleEffectHostListResponse"/></returns>
        public Task<DescribeIgnoreRuleEffectHostListResponse> DescribeIgnoreRuleEffectHostList(DescribeIgnoreRuleEffectHostListRequest req)
        {
            return InternalRequestAsync<DescribeIgnoreRuleEffectHostListResponse>(req, "DescribeIgnoreRuleEffectHostList");
        }

        /// <summary>
        /// This API is used to query the information on the list of hosts affected by ignored detection items based on detection item IDs and filter criteria.
        /// </summary>
        /// <param name="req"><see cref="DescribeIgnoreRuleEffectHostListRequest"/></param>
        /// <returns><see cref="DescribeIgnoreRuleEffectHostListResponse"/></returns>
        public DescribeIgnoreRuleEffectHostListResponse DescribeIgnoreRuleEffectHostListSync(DescribeIgnoreRuleEffectHostListRequest req)
        {
            return InternalRequestAsync<DescribeIgnoreRuleEffectHostListResponse>(req, "DescribeIgnoreRuleEffectHostList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 接口已废弃
        /// 
        /// This API is used to obtain the index list.
        /// </summary>
        /// <param name="req"><see cref="DescribeIndexListRequest"/></param>
        /// <returns><see cref="DescribeIndexListResponse"/></returns>
        public Task<DescribeIndexListResponse> DescribeIndexList(DescribeIndexListRequest req)
        {
            return InternalRequestAsync<DescribeIndexListResponse>(req, "DescribeIndexList");
        }

        /// <summary>
        /// 接口已废弃
        /// 
        /// This API is used to obtain the index list.
        /// </summary>
        /// <param name="req"><see cref="DescribeIndexListRequest"/></param>
        /// <returns><see cref="DescribeIndexListResponse"/></returns>
        public DescribeIndexListResponse DescribeIndexListSync(DescribeIndexListRequest req)
        {
            return InternalRequestAsync<DescribeIndexListResponse>(req, "DescribeIndexList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query Java webshell event details.
        /// </summary>
        /// <param name="req"><see cref="DescribeJavaMemShellInfoRequest"/></param>
        /// <returns><see cref="DescribeJavaMemShellInfoResponse"/></returns>
        public Task<DescribeJavaMemShellInfoResponse> DescribeJavaMemShellInfo(DescribeJavaMemShellInfoRequest req)
        {
            return InternalRequestAsync<DescribeJavaMemShellInfoResponse>(req, "DescribeJavaMemShellInfo");
        }

        /// <summary>
        /// This API is used to query Java webshell event details.
        /// </summary>
        /// <param name="req"><see cref="DescribeJavaMemShellInfoRequest"/></param>
        /// <returns><see cref="DescribeJavaMemShellInfoResponse"/></returns>
        public DescribeJavaMemShellInfoResponse DescribeJavaMemShellInfoSync(DescribeJavaMemShellInfoRequest req)
        {
            return InternalRequestAsync<DescribeJavaMemShellInfoResponse>(req, "DescribeJavaMemShellInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of Java webshell events.
        /// </summary>
        /// <param name="req"><see cref="DescribeJavaMemShellListRequest"/></param>
        /// <returns><see cref="DescribeJavaMemShellListResponse"/></returns>
        public Task<DescribeJavaMemShellListResponse> DescribeJavaMemShellList(DescribeJavaMemShellListRequest req)
        {
            return InternalRequestAsync<DescribeJavaMemShellListResponse>(req, "DescribeJavaMemShellList");
        }

        /// <summary>
        /// This API is used to query the list of Java webshell events.
        /// </summary>
        /// <param name="req"><see cref="DescribeJavaMemShellListRequest"/></param>
        /// <returns><see cref="DescribeJavaMemShellListResponse"/></returns>
        public DescribeJavaMemShellListResponse DescribeJavaMemShellListSync(DescribeJavaMemShellListRequest req)
        {
            return InternalRequestAsync<DescribeJavaMemShellListResponse>(req, "DescribeJavaMemShellList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the Java webshell plugin information of the given host.
        /// </summary>
        /// <param name="req"><see cref="DescribeJavaMemShellPluginInfoRequest"/></param>
        /// <returns><see cref="DescribeJavaMemShellPluginInfoResponse"/></returns>
        public Task<DescribeJavaMemShellPluginInfoResponse> DescribeJavaMemShellPluginInfo(DescribeJavaMemShellPluginInfoRequest req)
        {
            return InternalRequestAsync<DescribeJavaMemShellPluginInfoResponse>(req, "DescribeJavaMemShellPluginInfo");
        }

        /// <summary>
        /// This API is used to query the Java webshell plugin information of the given host.
        /// </summary>
        /// <param name="req"><see cref="DescribeJavaMemShellPluginInfoRequest"/></param>
        /// <returns><see cref="DescribeJavaMemShellPluginInfoResponse"/></returns>
        public DescribeJavaMemShellPluginInfoResponse DescribeJavaMemShellPluginInfoSync(DescribeJavaMemShellPluginInfoRequest req)
        {
            return InternalRequestAsync<DescribeJavaMemShellPluginInfoResponse>(req, "DescribeJavaMemShellPluginInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the Java webshell plugin list.
        /// </summary>
        /// <param name="req"><see cref="DescribeJavaMemShellPluginListRequest"/></param>
        /// <returns><see cref="DescribeJavaMemShellPluginListResponse"/></returns>
        public Task<DescribeJavaMemShellPluginListResponse> DescribeJavaMemShellPluginList(DescribeJavaMemShellPluginListRequest req)
        {
            return InternalRequestAsync<DescribeJavaMemShellPluginListResponse>(req, "DescribeJavaMemShellPluginList");
        }

        /// <summary>
        /// This API is used to query the Java webshell plugin list.
        /// </summary>
        /// <param name="req"><see cref="DescribeJavaMemShellPluginListRequest"/></param>
        /// <returns><see cref="DescribeJavaMemShellPluginListResponse"/></returns>
        public DescribeJavaMemShellPluginListResponse DescribeJavaMemShellPluginListSync(DescribeJavaMemShellPluginListRequest req)
        {
            return InternalRequestAsync<DescribeJavaMemShellPluginListResponse>(req, "DescribeJavaMemShellPluginList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the authorization information.
        /// </summary>
        /// <param name="req"><see cref="DescribeLicenseRequest"/></param>
        /// <returns><see cref="DescribeLicenseResponse"/></returns>
        public Task<DescribeLicenseResponse> DescribeLicense(DescribeLicenseRequest req)
        {
            return InternalRequestAsync<DescribeLicenseResponse>(req, "DescribeLicense");
        }

        /// <summary>
        /// This API is used to query the authorization information.
        /// </summary>
        /// <param name="req"><see cref="DescribeLicenseRequest"/></param>
        /// <returns><see cref="DescribeLicenseResponse"/></returns>
        public DescribeLicenseResponse DescribeLicenseSync(DescribeLicenseRequest req)
        {
            return InternalRequestAsync<DescribeLicenseResponse>(req, "DescribeLicense")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of authorized machines bound to an authorization under the Settings Center-Authorization Management.
        /// </summary>
        /// <param name="req"><see cref="DescribeLicenseBindListRequest"/></param>
        /// <returns><see cref="DescribeLicenseBindListResponse"/></returns>
        public Task<DescribeLicenseBindListResponse> DescribeLicenseBindList(DescribeLicenseBindListRequest req)
        {
            return InternalRequestAsync<DescribeLicenseBindListResponse>(req, "DescribeLicenseBindList");
        }

        /// <summary>
        /// This API is used to obtain the list of authorized machines bound to an authorization under the Settings Center-Authorization Management.
        /// </summary>
        /// <param name="req"><see cref="DescribeLicenseBindListRequest"/></param>
        /// <returns><see cref="DescribeLicenseBindListResponse"/></returns>
        public DescribeLicenseBindListResponse DescribeLicenseBindListSync(DescribeLicenseBindListRequest req)
        {
            return InternalRequestAsync<DescribeLicenseBindListResponse>(req, "DescribeLicenseBindList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the binding task progress of the authorization.
        /// </summary>
        /// <param name="req"><see cref="DescribeLicenseBindScheduleRequest"/></param>
        /// <returns><see cref="DescribeLicenseBindScheduleResponse"/></returns>
        public Task<DescribeLicenseBindScheduleResponse> DescribeLicenseBindSchedule(DescribeLicenseBindScheduleRequest req)
        {
            return InternalRequestAsync<DescribeLicenseBindScheduleResponse>(req, "DescribeLicenseBindSchedule");
        }

        /// <summary>
        /// This API is used to query the binding task progress of the authorization.
        /// </summary>
        /// <param name="req"><see cref="DescribeLicenseBindScheduleRequest"/></param>
        /// <returns><see cref="DescribeLicenseBindScheduleResponse"/></returns>
        public DescribeLicenseBindScheduleResponse DescribeLicenseBindScheduleSync(DescribeLicenseBindScheduleRequest req)
        {
            return InternalRequestAsync<DescribeLicenseBindScheduleResponse>(req, "DescribeLicenseBindSchedule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the authorization overview information.
        /// </summary>
        /// <param name="req"><see cref="DescribeLicenseGeneralRequest"/></param>
        /// <returns><see cref="DescribeLicenseGeneralResponse"/></returns>
        public Task<DescribeLicenseGeneralResponse> DescribeLicenseGeneral(DescribeLicenseGeneralRequest req)
        {
            return InternalRequestAsync<DescribeLicenseGeneralResponse>(req, "DescribeLicenseGeneral");
        }

        /// <summary>
        /// This API is used to obtain the authorization overview information.
        /// </summary>
        /// <param name="req"><see cref="DescribeLicenseGeneralRequest"/></param>
        /// <returns><see cref="DescribeLicenseGeneralResponse"/></returns>
        public DescribeLicenseGeneralResponse DescribeLicenseGeneralSync(DescribeLicenseGeneralRequest req)
        {
            return InternalRequestAsync<DescribeLicenseGeneralResponse>(req, "DescribeLicenseGeneral")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain all authorization orders of a user.
        /// </summary>
        /// <param name="req"><see cref="DescribeLicenseListRequest"/></param>
        /// <returns><see cref="DescribeLicenseListResponse"/></returns>
        public Task<DescribeLicenseListResponse> DescribeLicenseList(DescribeLicenseListRequest req)
        {
            return InternalRequestAsync<DescribeLicenseListResponse>(req, "DescribeLicenseList");
        }

        /// <summary>
        /// This API is used to obtain all authorization orders of a user.
        /// </summary>
        /// <param name="req"><see cref="DescribeLicenseListRequest"/></param>
        /// <returns><see cref="DescribeLicenseListResponse"/></returns>
        public DescribeLicenseListResponse DescribeLicenseListSync(DescribeLicenseListRequest req)
        {
            return InternalRequestAsync<DescribeLicenseListResponse>(req, "DescribeLicenseList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the available configurations for authorization allowlists.
        /// </summary>
        /// <param name="req"><see cref="DescribeLicenseWhiteConfigRequest"/></param>
        /// <returns><see cref="DescribeLicenseWhiteConfigResponse"/></returns>
        public Task<DescribeLicenseWhiteConfigResponse> DescribeLicenseWhiteConfig(DescribeLicenseWhiteConfigRequest req)
        {
            return InternalRequestAsync<DescribeLicenseWhiteConfigResponse>(req, "DescribeLicenseWhiteConfig");
        }

        /// <summary>
        /// This API is used to query the available configurations for authorization allowlists.
        /// </summary>
        /// <param name="req"><see cref="DescribeLicenseWhiteConfigRequest"/></param>
        /// <returns><see cref="DescribeLicenseWhiteConfigResponse"/></returns>
        public DescribeLicenseWhiteConfigResponse DescribeLicenseWhiteConfigSync(DescribeLicenseWhiteConfigRequest req)
        {
            return InternalRequestAsync<DescribeLicenseWhiteConfigResponse>(req, "DescribeLicenseWhiteConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of logs available for shipping to Kafka.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogDeliveryKafkaOptionsRequest"/></param>
        /// <returns><see cref="DescribeLogDeliveryKafkaOptionsResponse"/></returns>
        public Task<DescribeLogDeliveryKafkaOptionsResponse> DescribeLogDeliveryKafkaOptions(DescribeLogDeliveryKafkaOptionsRequest req)
        {
            return InternalRequestAsync<DescribeLogDeliveryKafkaOptionsResponse>(req, "DescribeLogDeliveryKafkaOptions");
        }

        /// <summary>
        /// This API is used to query the list of logs available for shipping to Kafka.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogDeliveryKafkaOptionsRequest"/></param>
        /// <returns><see cref="DescribeLogDeliveryKafkaOptionsResponse"/></returns>
        public DescribeLogDeliveryKafkaOptionsResponse DescribeLogDeliveryKafkaOptionsSync(DescribeLogDeliveryKafkaOptionsRequest req)
        {
            return InternalRequestAsync<DescribeLogDeliveryKafkaOptionsResponse>(req, "DescribeLogDeliveryKafkaOptions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of log download tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogExportsRequest"/></param>
        /// <returns><see cref="DescribeLogExportsResponse"/></returns>
        public Task<DescribeLogExportsResponse> DescribeLogExports(DescribeLogExportsRequest req)
        {
            return InternalRequestAsync<DescribeLogExportsResponse>(req, "DescribeLogExports");
        }

        /// <summary>
        /// This API is used to obtain the list of log download tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogExportsRequest"/></param>
        /// <returns><see cref="DescribeLogExportsResponse"/></returns>
        public DescribeLogExportsResponse DescribeLogExportsSync(DescribeLogExportsRequest req)
        {
            return InternalRequestAsync<DescribeLogExportsResponse>(req, "DescribeLogExports")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the log histogram information.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogHistogramRequest"/></param>
        /// <returns><see cref="DescribeLogHistogramResponse"/></returns>
        public Task<DescribeLogHistogramResponse> DescribeLogHistogram(DescribeLogHistogramRequest req)
        {
            return InternalRequestAsync<DescribeLogHistogramResponse>(req, "DescribeLogHistogram");
        }

        /// <summary>
        /// This API is used to obtain the log histogram information.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogHistogramRequest"/></param>
        /// <returns><see cref="DescribeLogHistogramResponse"/></returns>
        public DescribeLogHistogramResponse DescribeLogHistogramSync(DescribeLogHistogramRequest req)
        {
            return InternalRequestAsync<DescribeLogHistogramResponse>(req, "DescribeLogHistogram")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the index.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogIndexRequest"/></param>
        /// <returns><see cref="DescribeLogIndexResponse"/></returns>
        public Task<DescribeLogIndexResponse> DescribeLogIndex(DescribeLogIndexRequest req)
        {
            return InternalRequestAsync<DescribeLogIndexResponse>(req, "DescribeLogIndex");
        }

        /// <summary>
        /// This API is used to query the index.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogIndexRequest"/></param>
        /// <returns><see cref="DescribeLogIndexResponse"/></returns>
        public DescribeLogIndexResponse DescribeLogIndexSync(DescribeLogIndexRequest req)
        {
            return InternalRequestAsync<DescribeLogIndexResponse>(req, "DescribeLogIndex")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the information of Kafka shipping.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogKafkaDeliverInfoRequest"/></param>
        /// <returns><see cref="DescribeLogKafkaDeliverInfoResponse"/></returns>
        public Task<DescribeLogKafkaDeliverInfoResponse> DescribeLogKafkaDeliverInfo(DescribeLogKafkaDeliverInfoRequest req)
        {
            return InternalRequestAsync<DescribeLogKafkaDeliverInfoResponse>(req, "DescribeLogKafkaDeliverInfo");
        }

        /// <summary>
        /// This API is used to obtain the information of Kafka shipping.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogKafkaDeliverInfoRequest"/></param>
        /// <returns><see cref="DescribeLogKafkaDeliverInfoResponse"/></returns>
        public DescribeLogKafkaDeliverInfoResponse DescribeLogKafkaDeliverInfoSync(DescribeLogKafkaDeliverInfoRequest req)
        {
            return InternalRequestAsync<DescribeLogKafkaDeliverInfoResponse>(req, "DescribeLogKafkaDeliverInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the log storage configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogStorageConfigRequest"/></param>
        /// <returns><see cref="DescribeLogStorageConfigResponse"/></returns>
        public Task<DescribeLogStorageConfigResponse> DescribeLogStorageConfig(DescribeLogStorageConfigRequest req)
        {
            return InternalRequestAsync<DescribeLogStorageConfigResponse>(req, "DescribeLogStorageConfig");
        }

        /// <summary>
        /// This API is used to obtain the log storage configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogStorageConfigRequest"/></param>
        /// <returns><see cref="DescribeLogStorageConfigResponse"/></returns>
        public DescribeLogStorageConfigResponse DescribeLogStorageConfigSync(DescribeLogStorageConfigRequest req)
        {
            return InternalRequestAsync<DescribeLogStorageConfigResponse>(req, "DescribeLogStorageConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the record of stored log size.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogStorageRecordRequest"/></param>
        /// <returns><see cref="DescribeLogStorageRecordResponse"/></returns>
        public Task<DescribeLogStorageRecordResponse> DescribeLogStorageRecord(DescribeLogStorageRecordRequest req)
        {
            return InternalRequestAsync<DescribeLogStorageRecordResponse>(req, "DescribeLogStorageRecord");
        }

        /// <summary>
        /// This API is used to obtain the record of stored log size.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogStorageRecordRequest"/></param>
        /// <returns><see cref="DescribeLogStorageRecordResponse"/></returns>
        public DescribeLogStorageRecordResponse DescribeLogStorageRecordSync(DescribeLogStorageRecordRequest req)
        {
            return InternalRequestAsync<DescribeLogStorageRecordResponse>(req, "DescribeLogStorageRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the statistics of the used log retrieval capacity.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogStorageStatisticRequest"/></param>
        /// <returns><see cref="DescribeLogStorageStatisticResponse"/></returns>
        public Task<DescribeLogStorageStatisticResponse> DescribeLogStorageStatistic(DescribeLogStorageStatisticRequest req)
        {
            return InternalRequestAsync<DescribeLogStorageStatisticResponse>(req, "DescribeLogStorageStatistic");
        }

        /// <summary>
        /// This API is used to obtain the statistics of the used log retrieval capacity.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogStorageStatisticRequest"/></param>
        /// <returns><see cref="DescribeLogStorageStatisticResponse"/></returns>
        public DescribeLogStorageStatisticResponse DescribeLogStorageStatisticSync(DescribeLogStorageStatisticRequest req)
        {
            return InternalRequestAsync<DescribeLogStorageStatisticResponse>(req, "DescribeLogStorageStatistic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain log types, and the returned result of this API indicates temporarily filterable log types.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogTypeRequest"/></param>
        /// <returns><see cref="DescribeLogTypeResponse"/></returns>
        public Task<DescribeLogTypeResponse> DescribeLogType(DescribeLogTypeRequest req)
        {
            return InternalRequestAsync<DescribeLogTypeResponse>(req, "DescribeLogType");
        }

        /// <summary>
        /// This API is used to obtain log types, and the returned result of this API indicates temporarily filterable log types.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogTypeRequest"/></param>
        /// <returns><see cref="DescribeLogTypeResponse"/></returns>
        public DescribeLogTypeResponse DescribeLogTypeSync(DescribeLogTypeRequest req)
        {
            return InternalRequestAsync<DescribeLogTypeResponse>(req, "DescribeLogType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of cross-region log-in allowlists after merge.
        /// </summary>
        /// <param name="req"><see cref="DescribeLoginWhiteCombinedListRequest"/></param>
        /// <returns><see cref="DescribeLoginWhiteCombinedListResponse"/></returns>
        public Task<DescribeLoginWhiteCombinedListResponse> DescribeLoginWhiteCombinedList(DescribeLoginWhiteCombinedListRequest req)
        {
            return InternalRequestAsync<DescribeLoginWhiteCombinedListResponse>(req, "DescribeLoginWhiteCombinedList");
        }

        /// <summary>
        /// This API is used to obtain the list of cross-region log-in allowlists after merge.
        /// </summary>
        /// <param name="req"><see cref="DescribeLoginWhiteCombinedListRequest"/></param>
        /// <returns><see cref="DescribeLoginWhiteCombinedListResponse"/></returns>
        public DescribeLoginWhiteCombinedListResponse DescribeLoginWhiteCombinedListSync(DescribeLoginWhiteCombinedListRequest req)
        {
            return InternalRequestAsync<DescribeLoginWhiteCombinedListResponse>(req, "DescribeLoginWhiteCombinedList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of allowlisted machines after merge.
        /// </summary>
        /// <param name="req"><see cref="DescribeLoginWhiteHostListRequest"/></param>
        /// <returns><see cref="DescribeLoginWhiteHostListResponse"/></returns>
        public Task<DescribeLoginWhiteHostListResponse> DescribeLoginWhiteHostList(DescribeLoginWhiteHostListRequest req)
        {
            return InternalRequestAsync<DescribeLoginWhiteHostListResponse>(req, "DescribeLoginWhiteHostList");
        }

        /// <summary>
        /// This API is used to query the list of allowlisted machines after merge.
        /// </summary>
        /// <param name="req"><see cref="DescribeLoginWhiteHostListRequest"/></param>
        /// <returns><see cref="DescribeLoginWhiteHostListResponse"/></returns>
        public DescribeLoginWhiteHostListResponse DescribeLoginWhiteHostListSync(DescribeLoginWhiteHostListRequest req)
        {
            return InternalRequestAsync<DescribeLoginWhiteHostListResponse>(req, "DescribeLoginWhiteHostList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the cross-region log-in allowlist list.
        /// </summary>
        /// <param name="req"><see cref="DescribeLoginWhiteListRequest"/></param>
        /// <returns><see cref="DescribeLoginWhiteListResponse"/></returns>
        public Task<DescribeLoginWhiteListResponse> DescribeLoginWhiteList(DescribeLoginWhiteListRequest req)
        {
            return InternalRequestAsync<DescribeLoginWhiteListResponse>(req, "DescribeLoginWhiteList");
        }

        /// <summary>
        /// This API is used to obtain the cross-region log-in allowlist list.
        /// </summary>
        /// <param name="req"><see cref="DescribeLoginWhiteListRequest"/></param>
        /// <returns><see cref="DescribeLoginWhiteListResponse"/></returns>
        public DescribeLoginWhiteListResponse DescribeLoginWhiteListSync(DescribeLoginWhiteListRequest req)
        {
            return InternalRequestAsync<DescribeLoginWhiteListResponse>(req, "DescribeLoginWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the clearing history records of a machine.
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineClearHistoryRequest"/></param>
        /// <returns><see cref="DescribeMachineClearHistoryResponse"/></returns>
        public Task<DescribeMachineClearHistoryResponse> DescribeMachineClearHistory(DescribeMachineClearHistoryRequest req)
        {
            return InternalRequestAsync<DescribeMachineClearHistoryResponse>(req, "DescribeMachineClearHistory");
        }

        /// <summary>
        /// This API is used to query the clearing history records of a machine.
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineClearHistoryRequest"/></param>
        /// <returns><see cref="DescribeMachineClearHistoryResponse"/></returns>
        public DescribeMachineClearHistoryResponse DescribeMachineClearHistorySync(DescribeMachineClearHistoryRequest req)
        {
            return InternalRequestAsync<DescribeMachineClearHistoryResponse>(req, "DescribeMachineClearHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the statistics of advanced defense events for hosts.
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineDefenseCntRequest"/></param>
        /// <returns><see cref="DescribeMachineDefenseCntResponse"/></returns>
        public Task<DescribeMachineDefenseCntResponse> DescribeMachineDefenseCnt(DescribeMachineDefenseCntRequest req)
        {
            return InternalRequestAsync<DescribeMachineDefenseCntResponse>(req, "DescribeMachineDefenseCnt");
        }

        /// <summary>
        /// This API is used to query the statistics of advanced defense events for hosts.
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineDefenseCntRequest"/></param>
        /// <returns><see cref="DescribeMachineDefenseCntResponse"/></returns>
        public DescribeMachineDefenseCntResponse DescribeMachineDefenseCntSync(DescribeMachineDefenseCntRequest req)
        {
            return InternalRequestAsync<DescribeMachineDefenseCntResponse>(req, "DescribeMachineDefenseCnt")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of host-related core file monitoring rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineFileTamperRulesRequest"/></param>
        /// <returns><see cref="DescribeMachineFileTamperRulesResponse"/></returns>
        public Task<DescribeMachineFileTamperRulesResponse> DescribeMachineFileTamperRules(DescribeMachineFileTamperRulesRequest req)
        {
            return InternalRequestAsync<DescribeMachineFileTamperRulesResponse>(req, "DescribeMachineFileTamperRules");
        }

        /// <summary>
        /// This API is used to query the list of host-related core file monitoring rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineFileTamperRulesRequest"/></param>
        /// <returns><see cref="DescribeMachineFileTamperRulesResponse"/></returns>
        public DescribeMachineFileTamperRulesResponse DescribeMachineFileTamperRulesSync(DescribeMachineFileTamperRulesRequest req)
        {
            return InternalRequestAsync<DescribeMachineFileTamperRulesResponse>(req, "DescribeMachineFileTamperRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of the host overview.
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineGeneralRequest"/></param>
        /// <returns><see cref="DescribeMachineGeneralResponse"/></returns>
        public Task<DescribeMachineGeneralResponse> DescribeMachineGeneral(DescribeMachineGeneralRequest req)
        {
            return InternalRequestAsync<DescribeMachineGeneralResponse>(req, "DescribeMachineGeneral");
        }

        /// <summary>
        /// This API is used to query the information of the host overview.
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineGeneralRequest"/></param>
        /// <returns><see cref="DescribeMachineGeneralResponse"/></returns>
        public DescribeMachineGeneralResponse DescribeMachineGeneralSync(DescribeMachineGeneralRequest req)
        {
            return InternalRequestAsync<DescribeMachineGeneralResponse>(req, "DescribeMachineGeneral")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the machine authorization information.
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineLicenseDetailRequest"/></param>
        /// <returns><see cref="DescribeMachineLicenseDetailResponse"/></returns>
        public Task<DescribeMachineLicenseDetailResponse> DescribeMachineLicenseDetail(DescribeMachineLicenseDetailRequest req)
        {
            return InternalRequestAsync<DescribeMachineLicenseDetailResponse>(req, "DescribeMachineLicenseDetail");
        }

        /// <summary>
        /// This API is used to query the machine authorization information.
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineLicenseDetailRequest"/></param>
        /// <returns><see cref="DescribeMachineLicenseDetailResponse"/></returns>
        public DescribeMachineLicenseDetailResponse DescribeMachineLicenseDetailSync(DescribeMachineLicenseDetailRequest req)
        {
            return InternalRequestAsync<DescribeMachineLicenseDetailResponse>(req, "DescribeMachineLicenseDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the machine operating system list.
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineOsListRequest"/></param>
        /// <returns><see cref="DescribeMachineOsListResponse"/></returns>
        public Task<DescribeMachineOsListResponse> DescribeMachineOsList(DescribeMachineOsListRequest req)
        {
            return InternalRequestAsync<DescribeMachineOsListResponse>(req, "DescribeMachineOsList");
        }

        /// <summary>
        /// This API is used to query the machine operating system list.
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineOsListRequest"/></param>
        /// <returns><see cref="DescribeMachineOsListResponse"/></returns>
        public DescribeMachineOsListResponse DescribeMachineOsListSync(DescribeMachineOsListRequest req)
        {
            return InternalRequestAsync<DescribeMachineOsListResponse>(req, "DescribeMachineOsList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of host regions.
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineRegionListRequest"/></param>
        /// <returns><see cref="DescribeMachineRegionListResponse"/></returns>
        public Task<DescribeMachineRegionListResponse> DescribeMachineRegionList(DescribeMachineRegionListRequest req)
        {
            return InternalRequestAsync<DescribeMachineRegionListResponse>(req, "DescribeMachineRegionList");
        }

        /// <summary>
        /// This API is used to query the list of host regions.
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineRegionListRequest"/></param>
        /// <returns><see cref="DescribeMachineRegionListResponse"/></returns>
        public DescribeMachineRegionListResponse DescribeMachineRegionListSync(DescribeMachineRegionListRequest req)
        {
            return InternalRequestAsync<DescribeMachineRegionListResponse>(req, "DescribeMachineRegionList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of machine regions.
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineRegionsRequest"/></param>
        /// <returns><see cref="DescribeMachineRegionsResponse"/></returns>
        public Task<DescribeMachineRegionsResponse> DescribeMachineRegions(DescribeMachineRegionsRequest req)
        {
            return InternalRequestAsync<DescribeMachineRegionsResponse>(req, "DescribeMachineRegions");
        }

        /// <summary>
        /// This API is used to obtain the list of machine regions.
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineRegionsRequest"/></param>
        /// <returns><see cref="DescribeMachineRegionsResponse"/></returns>
        public DescribeMachineRegionsResponse DescribeMachineRegionsSync(DescribeMachineRegionsRequest req)
        {
            return InternalRequestAsync<DescribeMachineRegionsResponse>(req, "DescribeMachineRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the statistics of host intrusion detection events.
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineRiskCntRequest"/></param>
        /// <returns><see cref="DescribeMachineRiskCntResponse"/></returns>
        public Task<DescribeMachineRiskCntResponse> DescribeMachineRiskCnt(DescribeMachineRiskCntRequest req)
        {
            return InternalRequestAsync<DescribeMachineRiskCntResponse>(req, "DescribeMachineRiskCnt");
        }

        /// <summary>
        /// This API is used to query the statistics of host intrusion detection events.
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineRiskCntRequest"/></param>
        /// <returns><see cref="DescribeMachineRiskCntResponse"/></returns>
        public DescribeMachineRiskCntResponse DescribeMachineRiskCntSync(DescribeMachineRiskCntRequest req)
        {
            return InternalRequestAsync<DescribeMachineRiskCntResponse>(req, "DescribeMachineRiskCnt")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query snapshots created by the host.
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineSnapshotRequest"/></param>
        /// <returns><see cref="DescribeMachineSnapshotResponse"/></returns>
        public Task<DescribeMachineSnapshotResponse> DescribeMachineSnapshot(DescribeMachineSnapshotRequest req)
        {
            return InternalRequestAsync<DescribeMachineSnapshotResponse>(req, "DescribeMachineSnapshot");
        }

        /// <summary>
        /// This API is used to query snapshots created by the host.
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineSnapshotRequest"/></param>
        /// <returns><see cref="DescribeMachineSnapshotResponse"/></returns>
        public DescribeMachineSnapshotResponse DescribeMachineSnapshotSync(DescribeMachineSnapshotRequest req)
        {
            return InternalRequestAsync<DescribeMachineSnapshotResponse>(req, "DescribeMachineSnapshot")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of hosts in a specific region.
        /// </summary>
        /// <param name="req"><see cref="DescribeMachinesRequest"/></param>
        /// <returns><see cref="DescribeMachinesResponse"/></returns>
        public Task<DescribeMachinesResponse> DescribeMachines(DescribeMachinesRequest req)
        {
            return InternalRequestAsync<DescribeMachinesResponse>(req, "DescribeMachines");
        }

        /// <summary>
        /// This API is used to obtain the list of hosts in a specific region.
        /// </summary>
        /// <param name="req"><see cref="DescribeMachinesRequest"/></param>
        /// <returns><see cref="DescribeMachinesResponse"/></returns>
        public DescribeMachinesResponse DescribeMachinesSync(DescribeMachinesRequest req)
        {
            return InternalRequestAsync<DescribeMachinesResponse>(req, "DescribeMachines")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of hosts.
        /// </summary>
        /// <param name="req"><see cref="DescribeMachinesSimpleRequest"/></param>
        /// <returns><see cref="DescribeMachinesSimpleResponse"/></returns>
        public Task<DescribeMachinesSimpleResponse> DescribeMachinesSimple(DescribeMachinesSimpleRequest req)
        {
            return InternalRequestAsync<DescribeMachinesSimpleResponse>(req, "DescribeMachinesSimple");
        }

        /// <summary>
        /// This API is used to obtain the list of hosts.
        /// </summary>
        /// <param name="req"><see cref="DescribeMachinesSimpleRequest"/></param>
        /// <returns><see cref="DescribeMachinesSimpleResponse"/></returns>
        public DescribeMachinesSimpleResponse DescribeMachinesSimpleSync(DescribeMachinesSimpleRequest req)
        {
            return InternalRequestAsync<DescribeMachinesSimpleResponse>(req, "DescribeMachinesSimple")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the Trojan list.
        /// </summary>
        /// <param name="req"><see cref="DescribeMalWareListRequest"/></param>
        /// <returns><see cref="DescribeMalWareListResponse"/></returns>
        public Task<DescribeMalWareListResponse> DescribeMalWareList(DescribeMalWareListRequest req)
        {
            return InternalRequestAsync<DescribeMalWareListResponse>(req, "DescribeMalWareList");
        }

        /// <summary>
        /// This API is used to obtain the Trojan list.
        /// </summary>
        /// <param name="req"><see cref="DescribeMalWareListRequest"/></param>
        /// <returns><see cref="DescribeMalWareListResponse"/></returns>
        public DescribeMalWareListResponse DescribeMalWareListSync(DescribeMalWareListRequest req)
        {
            return InternalRequestAsync<DescribeMalWareListResponse>(req, "DescribeMalWareList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of malicious request allowlists.
        /// </summary>
        /// <param name="req"><see cref="DescribeMaliciousRequestWhiteListRequest"/></param>
        /// <returns><see cref="DescribeMaliciousRequestWhiteListResponse"/></returns>
        public Task<DescribeMaliciousRequestWhiteListResponse> DescribeMaliciousRequestWhiteList(DescribeMaliciousRequestWhiteListRequest req)
        {
            return InternalRequestAsync<DescribeMaliciousRequestWhiteListResponse>(req, "DescribeMaliciousRequestWhiteList");
        }

        /// <summary>
        /// This API is used to query the list of malicious request allowlists.
        /// </summary>
        /// <param name="req"><see cref="DescribeMaliciousRequestWhiteListRequest"/></param>
        /// <returns><see cref="DescribeMaliciousRequestWhiteListResponse"/></returns>
        public DescribeMaliciousRequestWhiteListResponse DescribeMaliciousRequestWhiteListSync(DescribeMaliciousRequestWhiteListRequest req)
        {
            return InternalRequestAsync<DescribeMaliciousRequestWhiteListResponse>(req, "DescribeMaliciousRequestWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain Trojan file download addresses.
        /// </summary>
        /// <param name="req"><see cref="DescribeMalwareFileRequest"/></param>
        /// <returns><see cref="DescribeMalwareFileResponse"/></returns>
        public Task<DescribeMalwareFileResponse> DescribeMalwareFile(DescribeMalwareFileRequest req)
        {
            return InternalRequestAsync<DescribeMalwareFileResponse>(req, "DescribeMalwareFile");
        }

        /// <summary>
        /// This API is used to obtain Trojan file download addresses.
        /// </summary>
        /// <param name="req"><see cref="DescribeMalwareFileRequest"/></param>
        /// <returns><see cref="DescribeMalwareFileResponse"/></returns>
        public DescribeMalwareFileResponse DescribeMalwareFileSync(DescribeMalwareFileRequest req)
        {
            return InternalRequestAsync<DescribeMalwareFileResponse>(req, "DescribeMalwareFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to view malicious file details.
        /// </summary>
        /// <param name="req"><see cref="DescribeMalwareInfoRequest"/></param>
        /// <returns><see cref="DescribeMalwareInfoResponse"/></returns>
        public Task<DescribeMalwareInfoResponse> DescribeMalwareInfo(DescribeMalwareInfoRequest req)
        {
            return InternalRequestAsync<DescribeMalwareInfoResponse>(req, "DescribeMalwareInfo");
        }

        /// <summary>
        /// This API is used to view malicious file details.
        /// </summary>
        /// <param name="req"><see cref="DescribeMalwareInfoRequest"/></param>
        /// <returns><see cref="DescribeMalwareInfoResponse"/></returns>
        public DescribeMalwareInfoResponse DescribeMalwareInfoSync(DescribeMalwareInfoRequest req)
        {
            return InternalRequestAsync<DescribeMalwareInfoResponse>(req, "DescribeMalwareInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the information of virus scanning overview.
        /// </summary>
        /// <param name="req"><see cref="DescribeMalwareRiskOverviewRequest"/></param>
        /// <returns><see cref="DescribeMalwareRiskOverviewResponse"/></returns>
        public Task<DescribeMalwareRiskOverviewResponse> DescribeMalwareRiskOverview(DescribeMalwareRiskOverviewRequest req)
        {
            return InternalRequestAsync<DescribeMalwareRiskOverviewResponse>(req, "DescribeMalwareRiskOverview");
        }

        /// <summary>
        /// This API is used to obtain the information of virus scanning overview.
        /// </summary>
        /// <param name="req"><see cref="DescribeMalwareRiskOverviewRequest"/></param>
        /// <returns><see cref="DescribeMalwareRiskOverviewResponse"/></returns>
        public DescribeMalwareRiskOverviewResponse DescribeMalwareRiskOverviewSync(DescribeMalwareRiskOverviewRequest req)
        {
            return InternalRequestAsync<DescribeMalwareRiskOverviewResponse>(req, "DescribeMalwareRiskOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to open Intrusion Detection - Virus Scanning, and the risk warning content pops up.
        /// </summary>
        /// <param name="req"><see cref="DescribeMalwareRiskWarningRequest"/></param>
        /// <returns><see cref="DescribeMalwareRiskWarningResponse"/></returns>
        public Task<DescribeMalwareRiskWarningResponse> DescribeMalwareRiskWarning(DescribeMalwareRiskWarningRequest req)
        {
            return InternalRequestAsync<DescribeMalwareRiskWarningResponse>(req, "DescribeMalwareRiskWarning");
        }

        /// <summary>
        /// This API is used to open Intrusion Detection - Virus Scanning, and the risk warning content pops up.
        /// </summary>
        /// <param name="req"><see cref="DescribeMalwareRiskWarningRequest"/></param>
        /// <returns><see cref="DescribeMalwareRiskWarningResponse"/></returns>
        public DescribeMalwareRiskWarningResponse DescribeMalwareRiskWarningSync(DescribeMalwareRiskWarningRequest req)
        {
            return InternalRequestAsync<DescribeMalwareRiskWarningResponse>(req, "DescribeMalwareRiskWarning")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the scheduled scan configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeMalwareTimingScanSettingRequest"/></param>
        /// <returns><see cref="DescribeMalwareTimingScanSettingResponse"/></returns>
        public Task<DescribeMalwareTimingScanSettingResponse> DescribeMalwareTimingScanSetting(DescribeMalwareTimingScanSettingRequest req)
        {
            return InternalRequestAsync<DescribeMalwareTimingScanSettingResponse>(req, "DescribeMalwareTimingScanSetting");
        }

        /// <summary>
        /// This API is used to query the scheduled scan configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeMalwareTimingScanSettingRequest"/></param>
        /// <returns><see cref="DescribeMalwareTimingScanSettingResponse"/></returns>
        public DescribeMalwareTimingScanSettingResponse DescribeMalwareTimingScanSettingSync(DescribeMalwareTimingScanSettingRequest req)
        {
            return InternalRequestAsync<DescribeMalwareTimingScanSettingResponse>(req, "DescribeMalwareTimingScanSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of Trojan allowlists.
        /// </summary>
        /// <param name="req"><see cref="DescribeMalwareWhiteListRequest"/></param>
        /// <returns><see cref="DescribeMalwareWhiteListResponse"/></returns>
        public Task<DescribeMalwareWhiteListResponse> DescribeMalwareWhiteList(DescribeMalwareWhiteListRequest req)
        {
            return InternalRequestAsync<DescribeMalwareWhiteListResponse>(req, "DescribeMalwareWhiteList");
        }

        /// <summary>
        /// This API is used to obtain the list of Trojan allowlists.
        /// </summary>
        /// <param name="req"><see cref="DescribeMalwareWhiteListRequest"/></param>
        /// <returns><see cref="DescribeMalwareWhiteListResponse"/></returns>
        public DescribeMalwareWhiteListResponse DescribeMalwareWhiteListSync(DescribeMalwareWhiteListRequest req)
        {
            return InternalRequestAsync<DescribeMalwareWhiteListResponse>(req, "DescribeMalwareWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of affected Trojan allowlists.
        /// </summary>
        /// <param name="req"><see cref="DescribeMalwareWhiteListAffectListRequest"/></param>
        /// <returns><see cref="DescribeMalwareWhiteListAffectListResponse"/></returns>
        public Task<DescribeMalwareWhiteListAffectListResponse> DescribeMalwareWhiteListAffectList(DescribeMalwareWhiteListAffectListRequest req)
        {
            return InternalRequestAsync<DescribeMalwareWhiteListAffectListResponse>(req, "DescribeMalwareWhiteListAffectList");
        }

        /// <summary>
        /// This API is used to obtain the list of affected Trojan allowlists.
        /// </summary>
        /// <param name="req"><see cref="DescribeMalwareWhiteListAffectListRequest"/></param>
        /// <returns><see cref="DescribeMalwareWhiteListAffectListResponse"/></returns>
        public DescribeMalwareWhiteListAffectListResponse DescribeMalwareWhiteListAffectListSync(DescribeMalwareWhiteListAffectListRequest req)
        {
            return InternalRequestAsync<DescribeMalwareWhiteListAffectListResponse>(req, "DescribeMalwareWhiteListAffectList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to download the monthly inspection report of the security manager.
        /// </summary>
        /// <param name="req"><see cref="DescribeMonthInspectionReportRequest"/></param>
        /// <returns><see cref="DescribeMonthInspectionReportResponse"/></returns>
        public Task<DescribeMonthInspectionReportResponse> DescribeMonthInspectionReport(DescribeMonthInspectionReportRequest req)
        {
            return InternalRequestAsync<DescribeMonthInspectionReportResponse>(req, "DescribeMonthInspectionReport");
        }

        /// <summary>
        /// This API is used to download the monthly inspection report of the security manager.
        /// </summary>
        /// <param name="req"><see cref="DescribeMonthInspectionReportRequest"/></param>
        /// <returns><see cref="DescribeMonthInspectionReportResponse"/></returns>
        public DescribeMonthInspectionReportResponse DescribeMonthInspectionReportSync(DescribeMonthInspectionReportRequest req)
        {
            return InternalRequestAsync<DescribeMonthInspectionReportResponse>(req, "DescribeMonthInspectionReport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query network attack settings.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetAttackSettingRequest"/></param>
        /// <returns><see cref="DescribeNetAttackSettingResponse"/></returns>
        public Task<DescribeNetAttackSettingResponse> DescribeNetAttackSetting(DescribeNetAttackSettingRequest req)
        {
            return InternalRequestAsync<DescribeNetAttackSettingResponse>(req, "DescribeNetAttackSetting");
        }

        /// <summary>
        /// This API is used to query network attack settings.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetAttackSettingRequest"/></param>
        /// <returns><see cref="DescribeNetAttackSettingResponse"/></returns>
        public DescribeNetAttackSettingResponse DescribeNetAttackSettingSync(DescribeNetAttackSettingRequest req)
        {
            return InternalRequestAsync<DescribeNetAttackSettingResponse>(req, "DescribeNetAttackSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the network attack allowlist list.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetAttackWhiteListRequest"/></param>
        /// <returns><see cref="DescribeNetAttackWhiteListResponse"/></returns>
        public Task<DescribeNetAttackWhiteListResponse> DescribeNetAttackWhiteList(DescribeNetAttackWhiteListRequest req)
        {
            return InternalRequestAsync<DescribeNetAttackWhiteListResponse>(req, "DescribeNetAttackWhiteList");
        }

        /// <summary>
        /// This API is used to obtain the network attack allowlist list.
        /// </summary>
        /// <param name="req"><see cref="DescribeNetAttackWhiteListRequest"/></param>
        /// <returns><see cref="DescribeNetAttackWhiteListResponse"/></returns>
        public DescribeNetAttackWhiteListResponse DescribeNetAttackWhiteListSync(DescribeNetAttackWhiteListRequest req)
        {
            return InternalRequestAsync<DescribeNetAttackWhiteListResponse>(req, "DescribeNetAttackWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of port statistics.
        /// </summary>
        /// <param name="req"><see cref="DescribeOpenPortStatisticsRequest"/></param>
        /// <returns><see cref="DescribeOpenPortStatisticsResponse"/></returns>
        public Task<DescribeOpenPortStatisticsResponse> DescribeOpenPortStatistics(DescribeOpenPortStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeOpenPortStatisticsResponse>(req, "DescribeOpenPortStatistics");
        }

        /// <summary>
        /// This API is used to obtain the list of port statistics.
        /// </summary>
        /// <param name="req"><see cref="DescribeOpenPortStatisticsRequest"/></param>
        /// <returns><see cref="DescribeOpenPortStatisticsResponse"/></returns>
        public DescribeOpenPortStatisticsResponse DescribeOpenPortStatisticsSync(DescribeOpenPortStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeOpenPortStatisticsResponse>(req, "DescribeOpenPortStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the overview statistics.
        /// </summary>
        /// <param name="req"><see cref="DescribeOverviewStatisticsRequest"/></param>
        /// <returns><see cref="DescribeOverviewStatisticsResponse"/></returns>
        public Task<DescribeOverviewStatisticsResponse> DescribeOverviewStatistics(DescribeOverviewStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeOverviewStatisticsResponse>(req, "DescribeOverviewStatistics");
        }

        /// <summary>
        /// This API is used to obtain the overview statistics.
        /// </summary>
        /// <param name="req"><see cref="DescribeOverviewStatisticsRequest"/></param>
        /// <returns><see cref="DescribeOverviewStatisticsResponse"/></returns>
        public DescribeOverviewStatisticsResponse DescribeOverviewStatisticsSync(DescribeOverviewStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeOverviewStatisticsResponse>(req, "DescribeOverviewStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain local privilege escalation information details.
        /// </summary>
        /// <param name="req"><see cref="DescribePrivilegeEventInfoRequest"/></param>
        /// <returns><see cref="DescribePrivilegeEventInfoResponse"/></returns>
        public Task<DescribePrivilegeEventInfoResponse> DescribePrivilegeEventInfo(DescribePrivilegeEventInfoRequest req)
        {
            return InternalRequestAsync<DescribePrivilegeEventInfoResponse>(req, "DescribePrivilegeEventInfo");
        }

        /// <summary>
        /// This API is used to obtain local privilege escalation information details.
        /// </summary>
        /// <param name="req"><see cref="DescribePrivilegeEventInfoRequest"/></param>
        /// <returns><see cref="DescribePrivilegeEventInfoResponse"/></returns>
        public DescribePrivilegeEventInfoResponse DescribePrivilegeEventInfoSync(DescribePrivilegeEventInfoRequest req)
        {
            return InternalRequestAsync<DescribePrivilegeEventInfoResponse>(req, "DescribePrivilegeEventInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of local privilege escalation rules.
        /// </summary>
        /// <param name="req"><see cref="DescribePrivilegeRulesRequest"/></param>
        /// <returns><see cref="DescribePrivilegeRulesResponse"/></returns>
        public Task<DescribePrivilegeRulesResponse> DescribePrivilegeRules(DescribePrivilegeRulesRequest req)
        {
            return InternalRequestAsync<DescribePrivilegeRulesResponse>(req, "DescribePrivilegeRules");
        }

        /// <summary>
        /// This API is used to obtain the list of local privilege escalation rules.
        /// </summary>
        /// <param name="req"><see cref="DescribePrivilegeRulesRequest"/></param>
        /// <returns><see cref="DescribePrivilegeRulesResponse"/></returns>
        public DescribePrivilegeRulesResponse DescribePrivilegeRulesSync(DescribePrivilegeRulesRequest req)
        {
            return InternalRequestAsync<DescribePrivilegeRulesResponse>(req, "DescribePrivilegeRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the overview information of the Professional edition.
        /// </summary>
        /// <param name="req"><see cref="DescribeProVersionInfoRequest"/></param>
        /// <returns><see cref="DescribeProVersionInfoResponse"/></returns>
        public Task<DescribeProVersionInfoResponse> DescribeProVersionInfo(DescribeProVersionInfoRequest req)
        {
            return InternalRequestAsync<DescribeProVersionInfoResponse>(req, "DescribeProVersionInfo");
        }

        /// <summary>
        /// This API is used to obtain the overview information of the Professional edition.
        /// </summary>
        /// <param name="req"><see cref="DescribeProVersionInfoRequest"/></param>
        /// <returns><see cref="DescribeProVersionInfoResponse"/></returns>
        public DescribeProVersionInfoResponse DescribeProVersionInfoSync(DescribeProVersionInfoRequest req)
        {
            return InternalRequestAsync<DescribeProVersionInfoResponse>(req, "DescribeProVersionInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to check whether a single host or all hosts enable the professional version.
        /// </summary>
        /// <param name="req"><see cref="DescribeProVersionStatusRequest"/></param>
        /// <returns><see cref="DescribeProVersionStatusResponse"/></returns>
        public Task<DescribeProVersionStatusResponse> DescribeProVersionStatus(DescribeProVersionStatusRequest req)
        {
            return InternalRequestAsync<DescribeProVersionStatusResponse>(req, "DescribeProVersionStatus");
        }

        /// <summary>
        /// This API is used to check whether a single host or all hosts enable the professional version.
        /// </summary>
        /// <param name="req"><see cref="DescribeProVersionStatusRequest"/></param>
        /// <returns><see cref="DescribeProVersionStatusResponse"/></returns>
        public DescribeProVersionStatusResponse DescribeProVersionStatusSync(DescribeProVersionStatusRequest req)
        {
            return InternalRequestAsync<DescribeProVersionStatusResponse>(req, "DescribeProVersionStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the process statistics data.
        /// </summary>
        /// <param name="req"><see cref="DescribeProcessStatisticsRequest"/></param>
        /// <returns><see cref="DescribeProcessStatisticsResponse"/></returns>
        public Task<DescribeProcessStatisticsResponse> DescribeProcessStatistics(DescribeProcessStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeProcessStatisticsResponse>(req, "DescribeProcessStatistics");
        }

        /// <summary>
        /// This API is used to obtain the process statistics data.
        /// </summary>
        /// <param name="req"><see cref="DescribeProcessStatisticsRequest"/></param>
        /// <returns><see cref="DescribeProcessStatisticsResponse"/></returns>
        public DescribeProcessStatisticsResponse DescribeProcessStatisticsSync(DescribeProcessStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeProcessStatisticsResponse>(req, "DescribeProcessStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the product trial status.
        /// </summary>
        /// <param name="req"><see cref="DescribeProductStatusRequest"/></param>
        /// <returns><see cref="DescribeProductStatusResponse"/></returns>
        public Task<DescribeProductStatusResponse> DescribeProductStatus(DescribeProductStatusRequest req)
        {
            return InternalRequestAsync<DescribeProductStatusResponse>(req, "DescribeProductStatus");
        }

        /// <summary>
        /// This API is used to query the product trial status.
        /// </summary>
        /// <param name="req"><see cref="DescribeProductStatusRequest"/></param>
        /// <returns><see cref="DescribeProductStatusResponse"/></returns>
        public DescribeProductStatusResponse DescribeProductStatusSync(DescribeProductStatusRequest req)
        {
            return InternalRequestAsync<DescribeProductStatusResponse>(req, "DescribeProductStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the installation command of the public network access proxy.
        /// </summary>
        /// <param name="req"><see cref="DescribePublicProxyInstallCommandRequest"/></param>
        /// <returns><see cref="DescribePublicProxyInstallCommandResponse"/></returns>
        public Task<DescribePublicProxyInstallCommandResponse> DescribePublicProxyInstallCommand(DescribePublicProxyInstallCommandRequest req)
        {
            return InternalRequestAsync<DescribePublicProxyInstallCommandResponse>(req, "DescribePublicProxyInstallCommand");
        }

        /// <summary>
        /// This API is used to obtain the installation command of the public network access proxy.
        /// </summary>
        /// <param name="req"><see cref="DescribePublicProxyInstallCommandRequest"/></param>
        /// <returns><see cref="DescribePublicProxyInstallCommandResponse"/></returns>
        public DescribePublicProxyInstallCommandResponse DescribePublicProxyInstallCommandSync(DescribePublicProxyInstallCommandRequest req)
        {
            return InternalRequestAsync<DescribePublicProxyInstallCommandResponse>(req, "DescribePublicProxyInstallCommand")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of host snapshot backups.
        /// </summary>
        /// <param name="req"><see cref="DescribeRansomDefenseBackupListRequest"/></param>
        /// <returns><see cref="DescribeRansomDefenseBackupListResponse"/></returns>
        public Task<DescribeRansomDefenseBackupListResponse> DescribeRansomDefenseBackupList(DescribeRansomDefenseBackupListRequest req)
        {
            return InternalRequestAsync<DescribeRansomDefenseBackupListResponse>(req, "DescribeRansomDefenseBackupList");
        }

        /// <summary>
        /// This API is used to query the list of host snapshot backups.
        /// </summary>
        /// <param name="req"><see cref="DescribeRansomDefenseBackupListRequest"/></param>
        /// <returns><see cref="DescribeRansomDefenseBackupListResponse"/></returns>
        public DescribeRansomDefenseBackupListResponse DescribeRansomDefenseBackupListSync(DescribeRansomDefenseBackupListRequest req)
        {
            return InternalRequestAsync<DescribeRansomDefenseBackupListResponse>(req, "DescribeRansomDefenseBackupList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the anti-ransomware event list.
        /// </summary>
        /// <param name="req"><see cref="DescribeRansomDefenseEventsListRequest"/></param>
        /// <returns><see cref="DescribeRansomDefenseEventsListResponse"/></returns>
        public Task<DescribeRansomDefenseEventsListResponse> DescribeRansomDefenseEventsList(DescribeRansomDefenseEventsListRequest req)
        {
            return InternalRequestAsync<DescribeRansomDefenseEventsListResponse>(req, "DescribeRansomDefenseEventsList");
        }

        /// <summary>
        /// This API is used to query the anti-ransomware event list.
        /// </summary>
        /// <param name="req"><see cref="DescribeRansomDefenseEventsListRequest"/></param>
        /// <returns><see cref="DescribeRansomDefenseEventsListResponse"/></returns>
        public DescribeRansomDefenseEventsListResponse DescribeRansomDefenseEventsListSync(DescribeRansomDefenseEventsListRequest req)
        {
            return InternalRequestAsync<DescribeRansomDefenseEventsListResponse>(req, "DescribeRansomDefenseEventsList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of backup details.
        /// </summary>
        /// <param name="req"><see cref="DescribeRansomDefenseMachineListRequest"/></param>
        /// <returns><see cref="DescribeRansomDefenseMachineListResponse"/></returns>
        public Task<DescribeRansomDefenseMachineListResponse> DescribeRansomDefenseMachineList(DescribeRansomDefenseMachineListRequest req)
        {
            return InternalRequestAsync<DescribeRansomDefenseMachineListResponse>(req, "DescribeRansomDefenseMachineList");
        }

        /// <summary>
        /// This API is used to query the list of backup details.
        /// </summary>
        /// <param name="req"><see cref="DescribeRansomDefenseMachineListRequest"/></param>
        /// <returns><see cref="DescribeRansomDefenseMachineListResponse"/></returns>
        public DescribeRansomDefenseMachineListResponse DescribeRansomDefenseMachineListSync(DescribeRansomDefenseMachineListRequest req)
        {
            return InternalRequestAsync<DescribeRansomDefenseMachineListResponse>(req, "DescribeRansomDefenseMachineList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of policies bound to a host.
        /// </summary>
        /// <param name="req"><see cref="DescribeRansomDefenseMachineStrategyInfoRequest"/></param>
        /// <returns><see cref="DescribeRansomDefenseMachineStrategyInfoResponse"/></returns>
        public Task<DescribeRansomDefenseMachineStrategyInfoResponse> DescribeRansomDefenseMachineStrategyInfo(DescribeRansomDefenseMachineStrategyInfoRequest req)
        {
            return InternalRequestAsync<DescribeRansomDefenseMachineStrategyInfoResponse>(req, "DescribeRansomDefenseMachineStrategyInfo");
        }

        /// <summary>
        /// This API is used to obtain the list of policies bound to a host.
        /// </summary>
        /// <param name="req"><see cref="DescribeRansomDefenseMachineStrategyInfoRequest"/></param>
        /// <returns><see cref="DescribeRansomDefenseMachineStrategyInfoResponse"/></returns>
        public DescribeRansomDefenseMachineStrategyInfoResponse DescribeRansomDefenseMachineStrategyInfoSync(DescribeRansomDefenseMachineStrategyInfoRequest req)
        {
            return InternalRequestAsync<DescribeRansomDefenseMachineStrategyInfoResponse>(req, "DescribeRansomDefenseMachineStrategyInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the rollback task list.
        /// </summary>
        /// <param name="req"><see cref="DescribeRansomDefenseRollBackTaskListRequest"/></param>
        /// <returns><see cref="DescribeRansomDefenseRollBackTaskListResponse"/></returns>
        public Task<DescribeRansomDefenseRollBackTaskListResponse> DescribeRansomDefenseRollBackTaskList(DescribeRansomDefenseRollBackTaskListRequest req)
        {
            return InternalRequestAsync<DescribeRansomDefenseRollBackTaskListResponse>(req, "DescribeRansomDefenseRollBackTaskList");
        }

        /// <summary>
        /// This API is used to query the rollback task list.
        /// </summary>
        /// <param name="req"><see cref="DescribeRansomDefenseRollBackTaskListRequest"/></param>
        /// <returns><see cref="DescribeRansomDefenseRollBackTaskListResponse"/></returns>
        public DescribeRansomDefenseRollBackTaskListResponse DescribeRansomDefenseRollBackTaskListSync(DescribeRansomDefenseRollBackTaskListRequest req)
        {
            return InternalRequestAsync<DescribeRansomDefenseRollBackTaskListResponse>(req, "DescribeRansomDefenseRollBackTaskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain user anti-ransomware trends.
        /// </summary>
        /// <param name="req"><see cref="DescribeRansomDefenseStateRequest"/></param>
        /// <returns><see cref="DescribeRansomDefenseStateResponse"/></returns>
        public Task<DescribeRansomDefenseStateResponse> DescribeRansomDefenseState(DescribeRansomDefenseStateRequest req)
        {
            return InternalRequestAsync<DescribeRansomDefenseStateResponse>(req, "DescribeRansomDefenseState");
        }

        /// <summary>
        /// This API is used to obtain user anti-ransomware trends.
        /// </summary>
        /// <param name="req"><see cref="DescribeRansomDefenseStateRequest"/></param>
        /// <returns><see cref="DescribeRansomDefenseStateResponse"/></returns>
        public DescribeRansomDefenseStateResponse DescribeRansomDefenseStateSync(DescribeRansomDefenseStateRequest req)
        {
            return InternalRequestAsync<DescribeRansomDefenseStateResponse>(req, "DescribeRansomDefenseState")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the policy details.
        /// </summary>
        /// <param name="req"><see cref="DescribeRansomDefenseStrategyDetailRequest"/></param>
        /// <returns><see cref="DescribeRansomDefenseStrategyDetailResponse"/></returns>
        public Task<DescribeRansomDefenseStrategyDetailResponse> DescribeRansomDefenseStrategyDetail(DescribeRansomDefenseStrategyDetailRequest req)
        {
            return InternalRequestAsync<DescribeRansomDefenseStrategyDetailResponse>(req, "DescribeRansomDefenseStrategyDetail");
        }

        /// <summary>
        /// This API is used to obtain the policy details.
        /// </summary>
        /// <param name="req"><see cref="DescribeRansomDefenseStrategyDetailRequest"/></param>
        /// <returns><see cref="DescribeRansomDefenseStrategyDetailResponse"/></returns>
        public DescribeRansomDefenseStrategyDetailResponse DescribeRansomDefenseStrategyDetailSync(DescribeRansomDefenseStrategyDetailRequest req)
        {
            return InternalRequestAsync<DescribeRansomDefenseStrategyDetailResponse>(req, "DescribeRansomDefenseStrategyDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of anti-ransomware policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeRansomDefenseStrategyListRequest"/></param>
        /// <returns><see cref="DescribeRansomDefenseStrategyListResponse"/></returns>
        public Task<DescribeRansomDefenseStrategyListResponse> DescribeRansomDefenseStrategyList(DescribeRansomDefenseStrategyListRequest req)
        {
            return InternalRequestAsync<DescribeRansomDefenseStrategyListResponse>(req, "DescribeRansomDefenseStrategyList");
        }

        /// <summary>
        /// This API is used to query the list of anti-ransomware policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeRansomDefenseStrategyListRequest"/></param>
        /// <returns><see cref="DescribeRansomDefenseStrategyListResponse"/></returns>
        public DescribeRansomDefenseStrategyListResponse DescribeRansomDefenseStrategyListSync(DescribeRansomDefenseStrategyListRequest req)
        {
            return InternalRequestAsync<DescribeRansomDefenseStrategyListResponse>(req, "DescribeRansomDefenseStrategyList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of machines bound to an anti-ransomware policy.
        /// </summary>
        /// <param name="req"><see cref="DescribeRansomDefenseStrategyMachinesRequest"/></param>
        /// <returns><see cref="DescribeRansomDefenseStrategyMachinesResponse"/></returns>
        public Task<DescribeRansomDefenseStrategyMachinesResponse> DescribeRansomDefenseStrategyMachines(DescribeRansomDefenseStrategyMachinesRequest req)
        {
            return InternalRequestAsync<DescribeRansomDefenseStrategyMachinesResponse>(req, "DescribeRansomDefenseStrategyMachines");
        }

        /// <summary>
        /// This API is used to query the list of machines bound to an anti-ransomware policy.
        /// </summary>
        /// <param name="req"><see cref="DescribeRansomDefenseStrategyMachinesRequest"/></param>
        /// <returns><see cref="DescribeRansomDefenseStrategyMachinesResponse"/></returns>
        public DescribeRansomDefenseStrategyMachinesResponse DescribeRansomDefenseStrategyMachinesSync(DescribeRansomDefenseStrategyMachinesRequest req)
        {
            return InternalRequestAsync<DescribeRansomDefenseStrategyMachinesResponse>(req, "DescribeRansomDefenseStrategyMachines")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the ransomware situation across the entire network.
        /// </summary>
        /// <param name="req"><see cref="DescribeRansomDefenseTrendRequest"/></param>
        /// <returns><see cref="DescribeRansomDefenseTrendResponse"/></returns>
        public Task<DescribeRansomDefenseTrendResponse> DescribeRansomDefenseTrend(DescribeRansomDefenseTrendRequest req)
        {
            return InternalRequestAsync<DescribeRansomDefenseTrendResponse>(req, "DescribeRansomDefenseTrend");
        }

        /// <summary>
        /// This API is used to obtain the ransomware situation across the entire network.
        /// </summary>
        /// <param name="req"><see cref="DescribeRansomDefenseTrendRequest"/></param>
        /// <returns><see cref="DescribeRansomDefenseTrendResponse"/></returns>
        public DescribeRansomDefenseTrendResponse DescribeRansomDefenseTrendSync(DescribeRansomDefenseTrendRequest req)
        {
            return InternalRequestAsync<DescribeRansomDefenseTrendResponse>(req, "DescribeRansomDefenseTrend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the recommended number of protection cores for purchase.
        /// </summary>
        /// <param name="req"><see cref="DescribeRecommendedProtectCpuRequest"/></param>
        /// <returns><see cref="DescribeRecommendedProtectCpuResponse"/></returns>
        public Task<DescribeRecommendedProtectCpuResponse> DescribeRecommendedProtectCpu(DescribeRecommendedProtectCpuRequest req)
        {
            return InternalRequestAsync<DescribeRecommendedProtectCpuResponse>(req, "DescribeRecommendedProtectCpu");
        }

        /// <summary>
        /// This API is used to query the recommended number of protection cores for purchase.
        /// </summary>
        /// <param name="req"><see cref="DescribeRecommendedProtectCpuRequest"/></param>
        /// <returns><see cref="DescribeRecommendedProtectCpuResponse"/></returns>
        public DescribeRecommendedProtectCpuResponse DescribeRecommendedProtectCpuSync(DescribeRecommendedProtectCpuRequest req)
        {
            return InternalRequestAsync<DescribeRecommendedProtectCpuResponse>(req, "DescribeRecommendedProtectCpu")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query reverse shell details.
        /// </summary>
        /// <param name="req"><see cref="DescribeReverseShellEventInfoRequest"/></param>
        /// <returns><see cref="DescribeReverseShellEventInfoResponse"/></returns>
        public Task<DescribeReverseShellEventInfoResponse> DescribeReverseShellEventInfo(DescribeReverseShellEventInfoRequest req)
        {
            return InternalRequestAsync<DescribeReverseShellEventInfoResponse>(req, "DescribeReverseShellEventInfo");
        }

        /// <summary>
        /// This API is used to query reverse shell details.
        /// </summary>
        /// <param name="req"><see cref="DescribeReverseShellEventInfoRequest"/></param>
        /// <returns><see cref="DescribeReverseShellEventInfoResponse"/></returns>
        public DescribeReverseShellEventInfoResponse DescribeReverseShellEventInfoSync(DescribeReverseShellEventInfoRequest req)
        {
            return InternalRequestAsync<DescribeReverseShellEventInfoResponse>(req, "DescribeReverseShellEventInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of Reverse Shell.
        /// </summary>
        /// <param name="req"><see cref="DescribeReverseShellEventsRequest"/></param>
        /// <returns><see cref="DescribeReverseShellEventsResponse"/></returns>
        public Task<DescribeReverseShellEventsResponse> DescribeReverseShellEvents(DescribeReverseShellEventsRequest req)
        {
            return InternalRequestAsync<DescribeReverseShellEventsResponse>(req, "DescribeReverseShellEvents");
        }

        /// <summary>
        /// This API is used to obtain the list of Reverse Shell.
        /// </summary>
        /// <param name="req"><see cref="DescribeReverseShellEventsRequest"/></param>
        /// <returns><see cref="DescribeReverseShellEventsResponse"/></returns>
        public DescribeReverseShellEventsResponse DescribeReverseShellEventsSync(DescribeReverseShellEventsRequest req)
        {
            return InternalRequestAsync<DescribeReverseShellEventsResponse>(req, "DescribeReverseShellEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of Reverse Shell rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeReverseShellRulesRequest"/></param>
        /// <returns><see cref="DescribeReverseShellRulesResponse"/></returns>
        public Task<DescribeReverseShellRulesResponse> DescribeReverseShellRules(DescribeReverseShellRulesRequest req)
        {
            return InternalRequestAsync<DescribeReverseShellRulesResponse>(req, "DescribeReverseShellRules");
        }

        /// <summary>
        /// This API is used to obtain the list of Reverse Shell rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeReverseShellRulesRequest"/></param>
        /// <returns><see cref="DescribeReverseShellRulesResponse"/></returns>
        public DescribeReverseShellRulesResponse DescribeReverseShellRulesSync(DescribeReverseShellRulesRequest req)
        {
            return InternalRequestAsync<DescribeReverseShellRulesResponse>(req, "DescribeReverseShellRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query if the intrusion detection event update task is completed.
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskBatchStatusRequest"/></param>
        /// <returns><see cref="DescribeRiskBatchStatusResponse"/></returns>
        public Task<DescribeRiskBatchStatusResponse> DescribeRiskBatchStatus(DescribeRiskBatchStatusRequest req)
        {
            return InternalRequestAsync<DescribeRiskBatchStatusResponse>(req, "DescribeRiskBatchStatus");
        }

        /// <summary>
        /// This API is used to query if the intrusion detection event update task is completed.
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskBatchStatusRequest"/></param>
        /// <returns><see cref="DescribeRiskBatchStatusResponse"/></returns>
        public DescribeRiskBatchStatusResponse DescribeRiskBatchStatusSync(DescribeRiskBatchStatusRequest req)
        {
            return InternalRequestAsync<DescribeRiskBatchStatusResponse>(req, "DescribeRiskBatchStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query malicious request event details.
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskDnsEventInfoRequest"/></param>
        /// <returns><see cref="DescribeRiskDnsEventInfoResponse"/></returns>
        public Task<DescribeRiskDnsEventInfoResponse> DescribeRiskDnsEventInfo(DescribeRiskDnsEventInfoRequest req)
        {
            return InternalRequestAsync<DescribeRiskDnsEventInfoResponse>(req, "DescribeRiskDnsEventInfo");
        }

        /// <summary>
        /// This API is used to query malicious request event details.
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskDnsEventInfoRequest"/></param>
        /// <returns><see cref="DescribeRiskDnsEventInfoResponse"/></returns>
        public DescribeRiskDnsEventInfoResponse DescribeRiskDnsEventInfoSync(DescribeRiskDnsEventInfoRequest req)
        {
            return InternalRequestAsync<DescribeRiskDnsEventInfoResponse>(req, "DescribeRiskDnsEventInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of malicious request events.
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskDnsEventListRequest"/></param>
        /// <returns><see cref="DescribeRiskDnsEventListResponse"/></returns>
        public Task<DescribeRiskDnsEventListResponse> DescribeRiskDnsEventList(DescribeRiskDnsEventListRequest req)
        {
            return InternalRequestAsync<DescribeRiskDnsEventListResponse>(req, "DescribeRiskDnsEventList");
        }

        /// <summary>
        /// This API is used to obtain the list of malicious request events.
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskDnsEventListRequest"/></param>
        /// <returns><see cref="DescribeRiskDnsEventListResponse"/></returns>
        public DescribeRiskDnsEventListResponse DescribeRiskDnsEventListSync(DescribeRiskDnsEventListRequest req)
        {
            return InternalRequestAsync<DescribeRiskDnsEventListResponse>(req, "DescribeRiskDnsEventList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query malicious request details.
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskDnsInfoRequest"/></param>
        /// <returns><see cref="DescribeRiskDnsInfoResponse"/></returns>
        public Task<DescribeRiskDnsInfoResponse> DescribeRiskDnsInfo(DescribeRiskDnsInfoRequest req)
        {
            return InternalRequestAsync<DescribeRiskDnsInfoResponse>(req, "DescribeRiskDnsInfo");
        }

        /// <summary>
        /// This API is used to query malicious request details.
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskDnsInfoRequest"/></param>
        /// <returns><see cref="DescribeRiskDnsInfoResponse"/></returns>
        public DescribeRiskDnsInfoResponse DescribeRiskDnsInfoSync(DescribeRiskDnsInfoRequest req)
        {
            return InternalRequestAsync<DescribeRiskDnsInfoResponse>(req, "DescribeRiskDnsInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the malicious request list.
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskDnsListRequest"/></param>
        /// <returns><see cref="DescribeRiskDnsListResponse"/></returns>
        public Task<DescribeRiskDnsListResponse> DescribeRiskDnsList(DescribeRiskDnsListRequest req)
        {
            return InternalRequestAsync<DescribeRiskDnsListResponse>(req, "DescribeRiskDnsList");
        }

        /// <summary>
        /// This API is used to obtain the malicious request list.
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskDnsListRequest"/></param>
        /// <returns><see cref="DescribeRiskDnsListResponse"/></returns>
        public DescribeRiskDnsListResponse DescribeRiskDnsListSync(DescribeRiskDnsListRequest req)
        {
            return InternalRequestAsync<DescribeRiskDnsListResponse>(req, "DescribeRiskDnsList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of malicious request policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskDnsPolicyListRequest"/></param>
        /// <returns><see cref="DescribeRiskDnsPolicyListResponse"/></returns>
        public Task<DescribeRiskDnsPolicyListResponse> DescribeRiskDnsPolicyList(DescribeRiskDnsPolicyListRequest req)
        {
            return InternalRequestAsync<DescribeRiskDnsPolicyListResponse>(req, "DescribeRiskDnsPolicyList");
        }

        /// <summary>
        /// This API is used to obtain the list of malicious request policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskDnsPolicyListRequest"/></param>
        /// <returns><see cref="DescribeRiskDnsPolicyListResponse"/></returns>
        public DescribeRiskDnsPolicyListResponse DescribeRiskDnsPolicyListSync(DescribeRiskDnsPolicyListRequest req)
        {
            return InternalRequestAsync<DescribeRiskDnsPolicyListResponse>(req, "DescribeRiskDnsPolicyList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of abnormal processes.
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskProcessEventsRequest"/></param>
        /// <returns><see cref="DescribeRiskProcessEventsResponse"/></returns>
        public Task<DescribeRiskProcessEventsResponse> DescribeRiskProcessEvents(DescribeRiskProcessEventsRequest req)
        {
            return InternalRequestAsync<DescribeRiskProcessEventsResponse>(req, "DescribeRiskProcessEvents");
        }

        /// <summary>
        /// This API is used to obtain the list of abnormal processes.
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskProcessEventsRequest"/></param>
        /// <returns><see cref="DescribeRiskProcessEventsResponse"/></returns>
        public DescribeRiskProcessEventsResponse DescribeRiskProcessEventsSync(DescribeRiskProcessEventsRequest req)
        {
            return InternalRequestAsync<DescribeRiskProcessEventsResponse>(req, "DescribeRiskProcessEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the .security notification information.
        /// </summary>
        /// <param name="req"><see cref="DescribeSafeInfoRequest"/></param>
        /// <returns><see cref="DescribeSafeInfoResponse"/></returns>
        public Task<DescribeSafeInfoResponse> DescribeSafeInfo(DescribeSafeInfoRequest req)
        {
            return InternalRequestAsync<DescribeSafeInfoResponse>(req, "DescribeSafeInfo");
        }

        /// <summary>
        /// This API is used to query the .security notification information.
        /// </summary>
        /// <param name="req"><see cref="DescribeSafeInfoRequest"/></param>
        /// <returns><see cref="DescribeSafeInfoResponse"/></returns>
        public DescribeSafeInfoResponse DescribeSafeInfoSync(DescribeSafeInfoRequest req)
        {
            return InternalRequestAsync<DescribeSafeInfoResponse>(req, "DescribeSafeInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the Trojan scan progress.
        /// </summary>
        /// <param name="req"><see cref="DescribeScanMalwareScheduleRequest"/></param>
        /// <returns><see cref="DescribeScanMalwareScheduleResponse"/></returns>
        public Task<DescribeScanMalwareScheduleResponse> DescribeScanMalwareSchedule(DescribeScanMalwareScheduleRequest req)
        {
            return InternalRequestAsync<DescribeScanMalwareScheduleResponse>(req, "DescribeScanMalwareSchedule");
        }

        /// <summary>
        /// This API is used to query the Trojan scan progress.
        /// </summary>
        /// <param name="req"><see cref="DescribeScanMalwareScheduleRequest"/></param>
        /// <returns><see cref="DescribeScanMalwareScheduleResponse"/></returns>
        public DescribeScanMalwareScheduleResponse DescribeScanMalwareScheduleSync(DescribeScanMalwareScheduleRequest req)
        {
            return InternalRequestAsync<DescribeScanMalwareScheduleResponse>(req, "DescribeScanMalwareSchedule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the detection progress by taskid.
        /// </summary>
        /// <param name="req"><see cref="DescribeScanScheduleRequest"/></param>
        /// <returns><see cref="DescribeScanScheduleResponse"/></returns>
        public Task<DescribeScanScheduleResponse> DescribeScanSchedule(DescribeScanScheduleRequest req)
        {
            return InternalRequestAsync<DescribeScanScheduleResponse>(req, "DescribeScanSchedule");
        }

        /// <summary>
        /// This API is used to query the detection progress by taskid.
        /// </summary>
        /// <param name="req"><see cref="DescribeScanScheduleRequest"/></param>
        /// <returns><see cref="DescribeScanScheduleResponse"/></returns>
        public DescribeScanScheduleResponse DescribeScanScheduleSync(DescribeScanScheduleRequest req)
        {
            return InternalRequestAsync<DescribeScanScheduleResponse>(req, "DescribeScanSchedule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the status of recent scan tasks of the corresponding module.
        /// </summary>
        /// <param name="req"><see cref="DescribeScanStateRequest"/></param>
        /// <returns><see cref="DescribeScanStateResponse"/></returns>
        public Task<DescribeScanStateResponse> DescribeScanState(DescribeScanStateRequest req)
        {
            return InternalRequestAsync<DescribeScanStateResponse>(req, "DescribeScanState");
        }

        /// <summary>
        /// This API is used to query the status of recent scan tasks of the corresponding module.
        /// </summary>
        /// <param name="req"><see cref="DescribeScanStateRequest"/></param>
        /// <returns><see cref="DescribeScanStateResponse"/></returns>
        public DescribeScanStateResponse DescribeScanStateSync(DescribeScanStateRequest req)
        {
            return InternalRequestAsync<DescribeScanStateResponse>(req, "DescribeScanState")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the scan task details and scan progress information/exceptions.
        /// </summary>
        /// <param name="req"><see cref="DescribeScanTaskDetailsRequest"/></param>
        /// <returns><see cref="DescribeScanTaskDetailsResponse"/></returns>
        public Task<DescribeScanTaskDetailsResponse> DescribeScanTaskDetails(DescribeScanTaskDetailsRequest req)
        {
            return InternalRequestAsync<DescribeScanTaskDetailsResponse>(req, "DescribeScanTaskDetails");
        }

        /// <summary>
        /// This API is used to query the scan task details and scan progress information/exceptions.
        /// </summary>
        /// <param name="req"><see cref="DescribeScanTaskDetailsRequest"/></param>
        /// <returns><see cref="DescribeScanTaskDetailsResponse"/></returns>
        public DescribeScanTaskDetailsResponse DescribeScanTaskDetailsSync(DescribeScanTaskDetailsRequest req)
        {
            return InternalRequestAsync<DescribeScanTaskDetailsResponse>(req, "DescribeScanTaskDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of machine scan statuses for filtering.
        /// </summary>
        /// <param name="req"><see cref="DescribeScanTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeScanTaskStatusResponse"/></returns>
        public Task<DescribeScanTaskStatusResponse> DescribeScanTaskStatus(DescribeScanTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeScanTaskStatusResponse>(req, "DescribeScanTaskStatus");
        }

        /// <summary>
        /// This API is used to query the list of machine scan statuses for filtering.
        /// </summary>
        /// <param name="req"><see cref="DescribeScanTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeScanTaskStatusResponse"/></returns>
        public DescribeScanTaskStatusResponse DescribeScanTaskStatusSync(DescribeScanTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeScanTaskStatusResponse>(req, "DescribeScanTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the configuration for regular detection.
        /// </summary>
        /// <param name="req"><see cref="DescribeScanVulSettingRequest"/></param>
        /// <returns><see cref="DescribeScanVulSettingResponse"/></returns>
        public Task<DescribeScanVulSettingResponse> DescribeScanVulSetting(DescribeScanVulSettingRequest req)
        {
            return InternalRequestAsync<DescribeScanVulSettingResponse>(req, "DescribeScanVulSetting");
        }

        /// <summary>
        /// This API is used to query the configuration for regular detection.
        /// </summary>
        /// <param name="req"><see cref="DescribeScanVulSettingRequest"/></param>
        /// <returns><see cref="DescribeScanVulSettingResponse"/></returns>
        public DescribeScanVulSettingResponse DescribeScanVulSettingSync(DescribeScanVulSettingRequest req)
        {
            return InternalRequestAsync<DescribeScanVulSettingResponse>(req, "DescribeScanVulSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to visually obtain the attacked hot spots across the entire network on the large screen.
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenAttackHotspotRequest"/></param>
        /// <returns><see cref="DescribeScreenAttackHotspotResponse"/></returns>
        public Task<DescribeScreenAttackHotspotResponse> DescribeScreenAttackHotspot(DescribeScreenAttackHotspotRequest req)
        {
            return InternalRequestAsync<DescribeScreenAttackHotspotResponse>(req, "DescribeScreenAttackHotspot");
        }

        /// <summary>
        /// This API is used to visually obtain the attacked hot spots across the entire network on the large screen.
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenAttackHotspotRequest"/></param>
        /// <returns><see cref="DescribeScreenAttackHotspotResponse"/></returns>
        public DescribeScreenAttackHotspotResponse DescribeScreenAttackHotspotSync(DescribeScreenAttackHotspotRequest req)
        {
            return InternalRequestAsync<DescribeScreenAttackHotspotResponse>(req, "DescribeScreenAttackHotspot")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the security report on the large screen.
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenBroadcastsRequest"/></param>
        /// <returns><see cref="DescribeScreenBroadcastsResponse"/></returns>
        public Task<DescribeScreenBroadcastsResponse> DescribeScreenBroadcasts(DescribeScreenBroadcastsRequest req)
        {
            return InternalRequestAsync<DescribeScreenBroadcastsResponse>(req, "DescribeScreenBroadcasts");
        }

        /// <summary>
        /// This API is used to obtain the security report on the large screen.
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenBroadcastsRequest"/></param>
        /// <returns><see cref="DescribeScreenBroadcastsResponse"/></returns>
        public DescribeScreenBroadcastsResponse DescribeScreenBroadcastsSync(DescribeScreenBroadcastsRequest req)
        {
            return InternalRequestAsync<DescribeScreenBroadcastsResponse>(req, "DescribeScreenBroadcasts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the visualized attack and defense trends on the large screen.
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenDefenseTrendsRequest"/></param>
        /// <returns><see cref="DescribeScreenDefenseTrendsResponse"/></returns>
        public Task<DescribeScreenDefenseTrendsResponse> DescribeScreenDefenseTrends(DescribeScreenDefenseTrendsRequest req)
        {
            return InternalRequestAsync<DescribeScreenDefenseTrendsResponse>(req, "DescribeScreenDefenseTrends");
        }

        /// <summary>
        /// This API is used to obtain the visualized attack and defense trends on the large screen.
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenDefenseTrendsRequest"/></param>
        /// <returns><see cref="DescribeScreenDefenseTrendsResponse"/></returns>
        public DescribeScreenDefenseTrendsResponse DescribeScreenDefenseTrendsSync(DescribeScreenDefenseTrendsRequest req)
        {
            return InternalRequestAsync<DescribeScreenDefenseTrendsResponse>(req, "DescribeScreenDefenseTrends")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the visualized emergency notification on the large screen.
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenEmergentMsgRequest"/></param>
        /// <returns><see cref="DescribeScreenEmergentMsgResponse"/></returns>
        public Task<DescribeScreenEmergentMsgResponse> DescribeScreenEmergentMsg(DescribeScreenEmergentMsgRequest req)
        {
            return InternalRequestAsync<DescribeScreenEmergentMsgResponse>(req, "DescribeScreenEmergentMsg");
        }

        /// <summary>
        /// This API is used to obtain the visualized emergency notification on the large screen.
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenEmergentMsgRequest"/></param>
        /// <returns><see cref="DescribeScreenEmergentMsgResponse"/></returns>
        public DescribeScreenEmergentMsgResponse DescribeScreenEmergentMsgSync(DescribeScreenEmergentMsgRequest req)
        {
            return InternalRequestAsync<DescribeScreenEmergentMsgResponse>(req, "DescribeScreenEmergentMsg")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the statistics data of events on the security overview page.
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenEventsCntRequest"/></param>
        /// <returns><see cref="DescribeScreenEventsCntResponse"/></returns>
        public Task<DescribeScreenEventsCntResponse> DescribeScreenEventsCnt(DescribeScreenEventsCntRequest req)
        {
            return InternalRequestAsync<DescribeScreenEventsCntResponse>(req, "DescribeScreenEventsCnt");
        }

        /// <summary>
        /// This API is used to obtain the statistics data of events on the security overview page.
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenEventsCntRequest"/></param>
        /// <returns><see cref="DescribeScreenEventsCntResponse"/></returns>
        public DescribeScreenEventsCntResponse DescribeScreenEventsCntSync(DescribeScreenEventsCntRequest req)
        {
            return InternalRequestAsync<DescribeScreenEventsCntResponse>(req, "DescribeScreenEventsCnt")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the visualized statistics data of hosts on the screen.
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenGeneralStatRequest"/></param>
        /// <returns><see cref="DescribeScreenGeneralStatResponse"/></returns>
        public Task<DescribeScreenGeneralStatResponse> DescribeScreenGeneralStat(DescribeScreenGeneralStatRequest req)
        {
            return InternalRequestAsync<DescribeScreenGeneralStatResponse>(req, "DescribeScreenGeneralStat");
        }

        /// <summary>
        /// This API is used to obtain the visualized statistics data of hosts on the screen.
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenGeneralStatRequest"/></param>
        /// <returns><see cref="DescribeScreenGeneralStatResponse"/></returns>
        public DescribeScreenGeneralStatResponse DescribeScreenGeneralStatSync(DescribeScreenGeneralStatRequest req)
        {
            return InternalRequestAsync<DescribeScreenGeneralStatResponse>(req, "DescribeScreenGeneralStat")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the visualized host intrusion details on the large screen.
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenHostInvasionRequest"/></param>
        /// <returns><see cref="DescribeScreenHostInvasionResponse"/></returns>
        public Task<DescribeScreenHostInvasionResponse> DescribeScreenHostInvasion(DescribeScreenHostInvasionRequest req)
        {
            return InternalRequestAsync<DescribeScreenHostInvasionResponse>(req, "DescribeScreenHostInvasion");
        }

        /// <summary>
        /// This API is used to obtain the visualized host intrusion details on the large screen.
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenHostInvasionRequest"/></param>
        /// <returns><see cref="DescribeScreenHostInvasionResponse"/></returns>
        public DescribeScreenHostInvasionResponse DescribeScreenHostInvasionSync(DescribeScreenHostInvasionRequest req)
        {
            return InternalRequestAsync<DescribeScreenHostInvasionResponse>(req, "DescribeScreenHostInvasion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of available visualized host regions on the large screen.
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenMachineRegionsRequest"/></param>
        /// <returns><see cref="DescribeScreenMachineRegionsResponse"/></returns>
        public Task<DescribeScreenMachineRegionsResponse> DescribeScreenMachineRegions(DescribeScreenMachineRegionsRequest req)
        {
            return InternalRequestAsync<DescribeScreenMachineRegionsResponse>(req, "DescribeScreenMachineRegions");
        }

        /// <summary>
        /// This API is used to obtain the list of available visualized host regions on the large screen.
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenMachineRegionsRequest"/></param>
        /// <returns><see cref="DescribeScreenMachineRegionsResponse"/></returns>
        public DescribeScreenMachineRegionsResponse DescribeScreenMachineRegionsSync(DescribeScreenMachineRegionsRequest req)
        {
            return InternalRequestAsync<DescribeScreenMachineRegionsResponse>(req, "DescribeScreenMachineRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the visualized list of host regions on the large screen.
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenMachinesRequest"/></param>
        /// <returns><see cref="DescribeScreenMachinesResponse"/></returns>
        public Task<DescribeScreenMachinesResponse> DescribeScreenMachines(DescribeScreenMachinesRequest req)
        {
            return InternalRequestAsync<DescribeScreenMachinesResponse>(req, "DescribeScreenMachines");
        }

        /// <summary>
        /// This API is used to obtain the visualized list of host regions on the large screen.
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenMachinesRequest"/></param>
        /// <returns><see cref="DescribeScreenMachinesResponse"/></returns>
        public DescribeScreenMachinesResponse DescribeScreenMachinesSync(DescribeScreenMachinesRequest req)
        {
            return InternalRequestAsync<DescribeScreenMachinesResponse>(req, "DescribeScreenMachines")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the visualized introduction of CWPP engine on the large screen.
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenProtectionCntRequest"/></param>
        /// <returns><see cref="DescribeScreenProtectionCntResponse"/></returns>
        public Task<DescribeScreenProtectionCntResponse> DescribeScreenProtectionCnt(DescribeScreenProtectionCntRequest req)
        {
            return InternalRequestAsync<DescribeScreenProtectionCntResponse>(req, "DescribeScreenProtectionCnt");
        }

        /// <summary>
        /// This API is used to obtain the visualized introduction of CWPP engine on the large screen.
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenProtectionCntRequest"/></param>
        /// <returns><see cref="DescribeScreenProtectionCntResponse"/></returns>
        public DescribeScreenProtectionCntResponse DescribeScreenProtectionCntSync(DescribeScreenProtectionCntRequest req)
        {
            return InternalRequestAsync<DescribeScreenProtectionCntResponse>(req, "DescribeScreenProtectionCnt")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the security protection status on the large screen.
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenProtectionStatRequest"/></param>
        /// <returns><see cref="DescribeScreenProtectionStatResponse"/></returns>
        public Task<DescribeScreenProtectionStatResponse> DescribeScreenProtectionStat(DescribeScreenProtectionStatRequest req)
        {
            return InternalRequestAsync<DescribeScreenProtectionStatResponse>(req, "DescribeScreenProtectionStat");
        }

        /// <summary>
        /// This API is used to obtain the security protection status on the large screen.
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenProtectionStatRequest"/></param>
        /// <returns><see cref="DescribeScreenProtectionStatResponse"/></returns>
        public DescribeScreenProtectionStatResponse DescribeScreenProtectionStatSync(DescribeScreenProtectionStatRequest req)
        {
            return InternalRequestAsync<DescribeScreenProtectionStatResponse>(req, "DescribeScreenProtectionStat")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to count today's risky assets.
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenRiskAssetsTopRequest"/></param>
        /// <returns><see cref="DescribeScreenRiskAssetsTopResponse"/></returns>
        public Task<DescribeScreenRiskAssetsTopResponse> DescribeScreenRiskAssetsTop(DescribeScreenRiskAssetsTopRequest req)
        {
            return InternalRequestAsync<DescribeScreenRiskAssetsTopResponse>(req, "DescribeScreenRiskAssetsTop");
        }

        /// <summary>
        /// This API is used to count today's risky assets.
        /// </summary>
        /// <param name="req"><see cref="DescribeScreenRiskAssetsTopRequest"/></param>
        /// <returns><see cref="DescribeScreenRiskAssetsTopResponse"/></returns>
        public DescribeScreenRiskAssetsTopResponse DescribeScreenRiskAssetsTopSync(DescribeScreenRiskAssetsTopRequest req)
        {
            return InternalRequestAsync<DescribeScreenRiskAssetsTopResponse>(req, "DescribeScreenRiskAssetsTop")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain historical search records.
        /// </summary>
        /// <param name="req"><see cref="DescribeSearchLogsRequest"/></param>
        /// <returns><see cref="DescribeSearchLogsResponse"/></returns>
        public Task<DescribeSearchLogsResponse> DescribeSearchLogs(DescribeSearchLogsRequest req)
        {
            return InternalRequestAsync<DescribeSearchLogsResponse>(req, "DescribeSearchLogs");
        }

        /// <summary>
        /// This API is used to obtain historical search records.
        /// </summary>
        /// <param name="req"><see cref="DescribeSearchLogsRequest"/></param>
        /// <returns><see cref="DescribeSearchLogsResponse"/></returns>
        public DescribeSearchLogsResponse DescribeSearchLogsSync(DescribeSearchLogsRequest req)
        {
            return InternalRequestAsync<DescribeSearchLogsResponse>(req, "DescribeSearchLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of quick retrievals.
        /// </summary>
        /// <param name="req"><see cref="DescribeSearchTemplatesRequest"/></param>
        /// <returns><see cref="DescribeSearchTemplatesResponse"/></returns>
        public Task<DescribeSearchTemplatesResponse> DescribeSearchTemplates(DescribeSearchTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeSearchTemplatesResponse>(req, "DescribeSearchTemplates");
        }

        /// <summary>
        /// This API is used to obtain the list of quick retrievals.
        /// </summary>
        /// <param name="req"><see cref="DescribeSearchTemplatesRequest"/></param>
        /// <returns><see cref="DescribeSearchTemplatesResponse"/></returns>
        public DescribeSearchTemplatesResponse DescribeSearchTemplatesSync(DescribeSearchTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeSearchTemplatesResponse>(req, "DescribeSearchTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of security report articles.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityBroadcastInfoRequest"/></param>
        /// <returns><see cref="DescribeSecurityBroadcastInfoResponse"/></returns>
        public Task<DescribeSecurityBroadcastInfoResponse> DescribeSecurityBroadcastInfo(DescribeSecurityBroadcastInfoRequest req)
        {
            return InternalRequestAsync<DescribeSecurityBroadcastInfoResponse>(req, "DescribeSecurityBroadcastInfo");
        }

        /// <summary>
        /// This API is used to query the information of security report articles.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityBroadcastInfoRequest"/></param>
        /// <returns><see cref="DescribeSecurityBroadcastInfoResponse"/></returns>
        public DescribeSecurityBroadcastInfoResponse DescribeSecurityBroadcastInfoSync(DescribeSecurityBroadcastInfoRequest req)
        {
            return InternalRequestAsync<DescribeSecurityBroadcastInfoResponse>(req, "DescribeSecurityBroadcastInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the security report list page.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityBroadcastsRequest"/></param>
        /// <returns><see cref="DescribeSecurityBroadcastsResponse"/></returns>
        public Task<DescribeSecurityBroadcastsResponse> DescribeSecurityBroadcasts(DescribeSecurityBroadcastsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityBroadcastsResponse>(req, "DescribeSecurityBroadcasts");
        }

        /// <summary>
        /// This API is used to obtain the security report list page.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityBroadcastsRequest"/></param>
        /// <returns><see cref="DescribeSecurityBroadcastsResponse"/></returns>
        public DescribeSecurityBroadcastsResponse DescribeSecurityBroadcastsSync(DescribeSecurityBroadcastsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityBroadcastsResponse>(req, "DescribeSecurityBroadcasts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the dynamic message data of security events.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityDynamicsRequest"/></param>
        /// <returns><see cref="DescribeSecurityDynamicsResponse"/></returns>
        public Task<DescribeSecurityDynamicsResponse> DescribeSecurityDynamics(DescribeSecurityDynamicsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityDynamicsResponse>(req, "DescribeSecurityDynamics");
        }

        /// <summary>
        /// This API is used to obtain the dynamic message data of security events.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityDynamicsRequest"/></param>
        /// <returns><see cref="DescribeSecurityDynamicsResponse"/></returns>
        public DescribeSecurityDynamicsResponse DescribeSecurityDynamicsSync(DescribeSecurityDynamicsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityDynamicsResponse>(req, "DescribeSecurityDynamics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the statistics of security events.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityEventStatRequest"/></param>
        /// <returns><see cref="DescribeSecurityEventStatResponse"/></returns>
        public Task<DescribeSecurityEventStatResponse> DescribeSecurityEventStat(DescribeSecurityEventStatRequest req)
        {
            return InternalRequestAsync<DescribeSecurityEventStatResponse>(req, "DescribeSecurityEventStat");
        }

        /// <summary>
        /// This API is used to obtain the statistics of security events.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityEventStatRequest"/></param>
        /// <returns><see cref="DescribeSecurityEventStatResponse"/></returns>
        public DescribeSecurityEventStatResponse DescribeSecurityEventStatSync(DescribeSecurityEventStatRequest req)
        {
            return InternalRequestAsync<DescribeSecurityEventStatResponse>(req, "DescribeSecurityEventStat")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the statistics data of security overview-related events.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityEventsCntRequest"/></param>
        /// <returns><see cref="DescribeSecurityEventsCntResponse"/></returns>
        public Task<DescribeSecurityEventsCntResponse> DescribeSecurityEventsCnt(DescribeSecurityEventsCntRequest req)
        {
            return InternalRequestAsync<DescribeSecurityEventsCntResponse>(req, "DescribeSecurityEventsCnt");
        }

        /// <summary>
        /// This API is used to obtain the statistics data of security overview-related events.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityEventsCntRequest"/></param>
        /// <returns><see cref="DescribeSecurityEventsCntResponse"/></returns>
        public DescribeSecurityEventsCntResponse DescribeSecurityEventsCntSync(DescribeSecurityEventsCntRequest req)
        {
            return InternalRequestAsync<DescribeSecurityEventsCntResponse>(req, "DescribeSecurityEventsCnt")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 接口已无效
        /// 
        /// This API is used to obtain the summary of security protection statuses.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityProtectionStatRequest"/></param>
        /// <returns><see cref="DescribeSecurityProtectionStatResponse"/></returns>
        public Task<DescribeSecurityProtectionStatResponse> DescribeSecurityProtectionStat(DescribeSecurityProtectionStatRequest req)
        {
            return InternalRequestAsync<DescribeSecurityProtectionStatResponse>(req, "DescribeSecurityProtectionStat");
        }

        /// <summary>
        /// 接口已无效
        /// 
        /// This API is used to obtain the summary of security protection statuses.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityProtectionStatRequest"/></param>
        /// <returns><see cref="DescribeSecurityProtectionStatResponse"/></returns>
        public DescribeSecurityProtectionStatResponse DescribeSecurityProtectionStatSync(DescribeSecurityProtectionStatRequest req)
        {
            return InternalRequestAsync<DescribeSecurityProtectionStatResponse>(req, "DescribeSecurityProtectionStat")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the security event statistics data.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityTrendsRequest"/></param>
        /// <returns><see cref="DescribeSecurityTrendsResponse"/></returns>
        public Task<DescribeSecurityTrendsResponse> DescribeSecurityTrends(DescribeSecurityTrendsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityTrendsResponse>(req, "DescribeSecurityTrends");
        }

        /// <summary>
        /// This API is used to obtain the security event statistics data.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityTrendsRequest"/></param>
        /// <returns><see cref="DescribeSecurityTrendsResponse"/></returns>
        public DescribeSecurityTrendsResponse DescribeSecurityTrendsSync(DescribeSecurityTrendsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityTrendsResponse>(req, "DescribeSecurityTrends")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the number of risky files pending to be processed + the number of affected servers + whether to try to detect + last detection time.
        /// </summary>
        /// <param name="req"><see cref="DescribeServersAndRiskAndFirstInfoRequest"/></param>
        /// <returns><see cref="DescribeServersAndRiskAndFirstInfoResponse"/></returns>
        public Task<DescribeServersAndRiskAndFirstInfoResponse> DescribeServersAndRiskAndFirstInfo(DescribeServersAndRiskAndFirstInfoRequest req)
        {
            return InternalRequestAsync<DescribeServersAndRiskAndFirstInfoResponse>(req, "DescribeServersAndRiskAndFirstInfo");
        }

        /// <summary>
        /// This API is used to obtain the number of risky files pending to be processed + the number of affected servers + whether to try to detect + last detection time.
        /// </summary>
        /// <param name="req"><see cref="DescribeServersAndRiskAndFirstInfoRequest"/></param>
        /// <returns><see cref="DescribeServersAndRiskAndFirstInfoResponse"/></returns>
        public DescribeServersAndRiskAndFirstInfoResponse DescribeServersAndRiskAndFirstInfoSync(DescribeServersAndRiskAndFirstInfoRequest req)
        {
            return InternalRequestAsync<DescribeServersAndRiskAndFirstInfoResponse>(req, "DescribeServersAndRiskAndFirstInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query whether a policy exists by policy name.
        /// </summary>
        /// <param name="req"><see cref="DescribeStrategyExistRequest"/></param>
        /// <returns><see cref="DescribeStrategyExistResponse"/></returns>
        public Task<DescribeStrategyExistResponse> DescribeStrategyExist(DescribeStrategyExistRequest req)
        {
            return InternalRequestAsync<DescribeStrategyExistResponse>(req, "DescribeStrategyExist");
        }

        /// <summary>
        /// This API is used to query whether a policy exists by policy name.
        /// </summary>
        /// <param name="req"><see cref="DescribeStrategyExistRequest"/></param>
        /// <returns><see cref="DescribeStrategyExistResponse"/></returns>
        public DescribeStrategyExistResponse DescribeStrategyExistSync(DescribeStrategyExistRequest req)
        {
            return InternalRequestAsync<DescribeStrategyExistResponse>(req, "DescribeStrategyExist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the server information associated with the specified tag.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagMachinesRequest"/></param>
        /// <returns><see cref="DescribeTagMachinesResponse"/></returns>
        public Task<DescribeTagMachinesResponse> DescribeTagMachines(DescribeTagMachinesRequest req)
        {
            return InternalRequestAsync<DescribeTagMachinesResponse>(req, "DescribeTagMachines");
        }

        /// <summary>
        /// This API is used to obtain the server information associated with the specified tag.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagMachinesRequest"/></param>
        /// <returns><see cref="DescribeTagMachinesResponse"/></returns>
        public DescribeTagMachinesResponse DescribeTagMachinesSync(DescribeTagMachinesRequest req)
        {
            return InternalRequestAsync<DescribeTagMachinesResponse>(req, "DescribeTagMachines")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain all host tags.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagsRequest"/></param>
        /// <returns><see cref="DescribeTagsResponse"/></returns>
        public Task<DescribeTagsResponse> DescribeTags(DescribeTagsRequest req)
        {
            return InternalRequestAsync<DescribeTagsResponse>(req, "DescribeTags");
        }

        /// <summary>
        /// This API is used to obtain all host tags.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagsRequest"/></param>
        /// <returns><see cref="DescribeTagsResponse"/></returns>
        public DescribeTagsResponse DescribeTagsSync(DescribeTagsRequest req)
        {
            return InternalRequestAsync<DescribeTagsResponse>(req, "DescribeTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the CWPP authorized trial report (only available for console applications).
        /// </summary>
        /// <param name="req"><see cref="DescribeTrialReportRequest"/></param>
        /// <returns><see cref="DescribeTrialReportResponse"/></returns>
        public Task<DescribeTrialReportResponse> DescribeTrialReport(DescribeTrialReportRequest req)
        {
            return InternalRequestAsync<DescribeTrialReportResponse>(req, "DescribeTrialReport");
        }

        /// <summary>
        /// This API is used to query the CWPP authorized trial report (only available for console applications).
        /// </summary>
        /// <param name="req"><see cref="DescribeTrialReportRequest"/></param>
        /// <returns><see cref="DescribeTrialReportResponse"/></returns>
        public DescribeTrialReportResponse DescribeTrialReportSync(DescribeTrialReportRequest req)
        {
            return InternalRequestAsync<DescribeTrialReportResponse>(req, "DescribeTrialReport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the number of pending vulnerabilities of a specified category and the number of hosts in the vulnerability management module.
        /// </summary>
        /// <param name="req"><see cref="DescribeUndoVulCountsRequest"/></param>
        /// <returns><see cref="DescribeUndoVulCountsResponse"/></returns>
        public Task<DescribeUndoVulCountsResponse> DescribeUndoVulCounts(DescribeUndoVulCountsRequest req)
        {
            return InternalRequestAsync<DescribeUndoVulCountsResponse>(req, "DescribeUndoVulCounts");
        }

        /// <summary>
        /// This API is used to obtain the number of pending vulnerabilities of a specified category and the number of hosts in the vulnerability management module.
        /// </summary>
        /// <param name="req"><see cref="DescribeUndoVulCountsRequest"/></param>
        /// <returns><see cref="DescribeUndoVulCountsResponse"/></returns>
        public DescribeUndoVulCountsResponse DescribeUndoVulCountsSync(DescribeUndoVulCountsRequest req)
        {
            return InternalRequestAsync<DescribeUndoVulCountsResponse>(req, "DescribeUndoVulCounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the user's custom configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeUsersConfigRequest"/></param>
        /// <returns><see cref="DescribeUsersConfigResponse"/></returns>
        public Task<DescribeUsersConfigResponse> DescribeUsersConfig(DescribeUsersConfigRequest req)
        {
            return InternalRequestAsync<DescribeUsersConfigResponse>(req, "DescribeUsersConfig");
        }

        /// <summary>
        /// This API is used to query the user's custom configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeUsersConfigRequest"/></param>
        /// <returns><see cref="DescribeUsersConfigResponse"/></returns>
        public DescribeUsersConfigResponse DescribeUsersConfigSync(DescribeUsersConfigRequest req)
        {
            return InternalRequestAsync<DescribeUsersConfigResponse>(req, "DescribeUsersConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query common log-in locations.
        /// </summary>
        /// <param name="req"><see cref="DescribeUsualLoginPlacesRequest"/></param>
        /// <returns><see cref="DescribeUsualLoginPlacesResponse"/></returns>
        public Task<DescribeUsualLoginPlacesResponse> DescribeUsualLoginPlaces(DescribeUsualLoginPlacesRequest req)
        {
            return InternalRequestAsync<DescribeUsualLoginPlacesResponse>(req, "DescribeUsualLoginPlaces");
        }

        /// <summary>
        /// This API is used to query common log-in locations.
        /// </summary>
        /// <param name="req"><see cref="DescribeUsualLoginPlacesRequest"/></param>
        /// <returns><see cref="DescribeUsualLoginPlacesResponse"/></returns>
        public DescribeUsualLoginPlacesResponse DescribeUsualLoginPlacesSync(DescribeUsualLoginPlacesRequest req)
        {
            return InternalRequestAsync<DescribeUsualLoginPlacesResponse>(req, "DescribeUsualLoginPlaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain virus database and POC updates.
        /// </summary>
        /// <param name="req"><see cref="DescribeVdbAndPocInfoRequest"/></param>
        /// <returns><see cref="DescribeVdbAndPocInfoResponse"/></returns>
        public Task<DescribeVdbAndPocInfoResponse> DescribeVdbAndPocInfo(DescribeVdbAndPocInfoRequest req)
        {
            return InternalRequestAsync<DescribeVdbAndPocInfoResponse>(req, "DescribeVdbAndPocInfo");
        }

        /// <summary>
        /// This API is used to obtain virus database and POC updates.
        /// </summary>
        /// <param name="req"><see cref="DescribeVdbAndPocInfoRequest"/></param>
        /// <returns><see cref="DescribeVdbAndPocInfoResponse"/></returns>
        public DescribeVdbAndPocInfoResponse DescribeVdbAndPocInfoSync(DescribeVdbAndPocInfoRequest req)
        {
            return InternalRequestAsync<DescribeVdbAndPocInfoResponse>(req, "DescribeVdbAndPocInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the version comparison information.
        /// </summary>
        /// <param name="req"><see cref="DescribeVersionCompareChartRequest"/></param>
        /// <returns><see cref="DescribeVersionCompareChartResponse"/></returns>
        public Task<DescribeVersionCompareChartResponse> DescribeVersionCompareChart(DescribeVersionCompareChartRequest req)
        {
            return InternalRequestAsync<DescribeVersionCompareChartResponse>(req, "DescribeVersionCompareChart");
        }

        /// <summary>
        /// This API is used to obtain the version comparison information.
        /// </summary>
        /// <param name="req"><see cref="DescribeVersionCompareChartRequest"/></param>
        /// <returns><see cref="DescribeVersionCompareChartResponse"/></returns>
        public DescribeVersionCompareChartResponse DescribeVersionCompareChartSync(DescribeVersionCompareChartRequest req)
        {
            return InternalRequestAsync<DescribeVersionCompareChartResponse>(req, "DescribeVersionCompareChart")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to count the number of machines of Professional and Basic editions.
        /// </summary>
        /// <param name="req"><see cref="DescribeVersionStatisticsRequest"/></param>
        /// <returns><see cref="DescribeVersionStatisticsResponse"/></returns>
        public Task<DescribeVersionStatisticsResponse> DescribeVersionStatistics(DescribeVersionStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeVersionStatisticsResponse>(req, "DescribeVersionStatistics");
        }

        /// <summary>
        /// This API is used to count the number of machines of Professional and Basic editions.
        /// </summary>
        /// <param name="req"><see cref="DescribeVersionStatisticsRequest"/></param>
        /// <returns><see cref="DescribeVersionStatisticsResponse"/></returns>
        public DescribeVersionStatisticsResponse DescribeVersionStatisticsSync(DescribeVersionStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeVersionStatisticsResponse>(req, "DescribeVersionStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the attribute information of the specified point.
        /// </summary>
        /// <param name="req"><see cref="DescribeVertexDetailRequest"/></param>
        /// <returns><see cref="DescribeVertexDetailResponse"/></returns>
        public Task<DescribeVertexDetailResponse> DescribeVertexDetail(DescribeVertexDetailRequest req)
        {
            return InternalRequestAsync<DescribeVertexDetailResponse>(req, "DescribeVertexDetail");
        }

        /// <summary>
        /// This API is used to obtain the attribute information of the specified point.
        /// </summary>
        /// <param name="req"><see cref="DescribeVertexDetailRequest"/></param>
        /// <returns><see cref="DescribeVertexDetailResponse"/></returns>
        public DescribeVertexDetailResponse DescribeVertexDetailSync(DescribeVertexDetailRequest req)
        {
            return InternalRequestAsync<DescribeVertexDetailResponse>(req, "DescribeVertexDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the number of vulnerabilities of specified types in recent days and the number of hosts.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulCountByDatesRequest"/></param>
        /// <returns><see cref="DescribeVulCountByDatesResponse"/></returns>
        public Task<DescribeVulCountByDatesResponse> DescribeVulCountByDates(DescribeVulCountByDatesRequest req)
        {
            return InternalRequestAsync<DescribeVulCountByDatesResponse>(req, "DescribeVulCountByDates");
        }

        /// <summary>
        /// This API is used to obtain the number of vulnerabilities of specified types in recent days and the number of hosts.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulCountByDatesRequest"/></param>
        /// <returns><see cref="DescribeVulCountByDatesResponse"/></returns>
        public DescribeVulCountByDatesResponse DescribeVulCountByDatesSync(DescribeVulCountByDatesRequest req)
        {
            return InternalRequestAsync<DescribeVulCountByDatesResponse>(req, "DescribeVulCountByDates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query vulnerability details by CveId.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulCveIdInfoRequest"/></param>
        /// <returns><see cref="DescribeVulCveIdInfoResponse"/></returns>
        public Task<DescribeVulCveIdInfoResponse> DescribeVulCveIdInfo(DescribeVulCveIdInfoRequest req)
        {
            return InternalRequestAsync<DescribeVulCveIdInfoResponse>(req, "DescribeVulCveIdInfo");
        }

        /// <summary>
        /// This API is used to query vulnerability details by CveId.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulCveIdInfoRequest"/></param>
        /// <returns><see cref="DescribeVulCveIdInfoResponse"/></returns>
        public DescribeVulCveIdInfoResponse DescribeVulCveIdInfoSync(DescribeVulCveIdInfoRequest req)
        {
            return InternalRequestAsync<DescribeVulCveIdInfoResponse>(req, "DescribeVulCveIdInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of vulnerability defense events.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefenceEventRequest"/></param>
        /// <returns><see cref="DescribeVulDefenceEventResponse"/></returns>
        public Task<DescribeVulDefenceEventResponse> DescribeVulDefenceEvent(DescribeVulDefenceEventRequest req)
        {
            return InternalRequestAsync<DescribeVulDefenceEventResponse>(req, "DescribeVulDefenceEvent");
        }

        /// <summary>
        /// This API is used to obtain the list of vulnerability defense events.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefenceEventRequest"/></param>
        /// <returns><see cref="DescribeVulDefenceEventResponse"/></returns>
        public DescribeVulDefenceEventResponse DescribeVulDefenceEventSync(DescribeVulDefenceEventRequest req)
        {
            return InternalRequestAsync<DescribeVulDefenceEventResponse>(req, "DescribeVulDefenceEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the vulnerability defense list.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefenceListRequest"/></param>
        /// <returns><see cref="DescribeVulDefenceListResponse"/></returns>
        public Task<DescribeVulDefenceListResponse> DescribeVulDefenceList(DescribeVulDefenceListRequest req)
        {
            return InternalRequestAsync<DescribeVulDefenceListResponse>(req, "DescribeVulDefenceList");
        }

        /// <summary>
        /// This API is used to query the vulnerability defense list.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefenceListRequest"/></param>
        /// <returns><see cref="DescribeVulDefenceListResponse"/></returns>
        public DescribeVulDefenceListResponse DescribeVulDefenceListSync(DescribeVulDefenceListRequest req)
        {
            return InternalRequestAsync<DescribeVulDefenceListResponse>(req, "DescribeVulDefenceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the vulnerability defense overview information, including event trend and plugin enabling status.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefenceOverviewRequest"/></param>
        /// <returns><see cref="DescribeVulDefenceOverviewResponse"/></returns>
        public Task<DescribeVulDefenceOverviewResponse> DescribeVulDefenceOverview(DescribeVulDefenceOverviewRequest req)
        {
            return InternalRequestAsync<DescribeVulDefenceOverviewResponse>(req, "DescribeVulDefenceOverview");
        }

        /// <summary>
        /// This API is used to obtain the vulnerability defense overview information, including event trend and plugin enabling status.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefenceOverviewRequest"/></param>
        /// <returns><see cref="DescribeVulDefenceOverviewResponse"/></returns>
        public DescribeVulDefenceOverviewResponse DescribeVulDefenceOverviewSync(DescribeVulDefenceOverviewRequest req)
        {
            return InternalRequestAsync<DescribeVulDefenceOverviewResponse>(req, "DescribeVulDefenceOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the vulnerability defense plugin information on a single host.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefencePluginDetailRequest"/></param>
        /// <returns><see cref="DescribeVulDefencePluginDetailResponse"/></returns>
        public Task<DescribeVulDefencePluginDetailResponse> DescribeVulDefencePluginDetail(DescribeVulDefencePluginDetailRequest req)
        {
            return InternalRequestAsync<DescribeVulDefencePluginDetailResponse>(req, "DescribeVulDefencePluginDetail");
        }

        /// <summary>
        /// This API is used to obtain the vulnerability defense plugin information on a single host.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefencePluginDetailRequest"/></param>
        /// <returns><see cref="DescribeVulDefencePluginDetailResponse"/></returns>
        public DescribeVulDefencePluginDetailResponse DescribeVulDefencePluginDetailSync(DescribeVulDefencePluginDetailRequest req)
        {
            return InternalRequestAsync<DescribeVulDefencePluginDetailResponse>(req, "DescribeVulDefencePluginDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the current number of abnormal plugins.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefencePluginExceptionCountRequest"/></param>
        /// <returns><see cref="DescribeVulDefencePluginExceptionCountResponse"/></returns>
        public Task<DescribeVulDefencePluginExceptionCountResponse> DescribeVulDefencePluginExceptionCount(DescribeVulDefencePluginExceptionCountRequest req)
        {
            return InternalRequestAsync<DescribeVulDefencePluginExceptionCountResponse>(req, "DescribeVulDefencePluginExceptionCount");
        }

        /// <summary>
        /// This API is used to obtain the current number of abnormal plugins.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefencePluginExceptionCountRequest"/></param>
        /// <returns><see cref="DescribeVulDefencePluginExceptionCountResponse"/></returns>
        public DescribeVulDefencePluginExceptionCountResponse DescribeVulDefencePluginExceptionCountSync(DescribeVulDefencePluginExceptionCountRequest req)
        {
            return InternalRequestAsync<DescribeVulDefencePluginExceptionCountResponse>(req, "DescribeVulDefencePluginExceptionCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the vulnerability defense plugin status of each host.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefencePluginStatusRequest"/></param>
        /// <returns><see cref="DescribeVulDefencePluginStatusResponse"/></returns>
        public Task<DescribeVulDefencePluginStatusResponse> DescribeVulDefencePluginStatus(DescribeVulDefencePluginStatusRequest req)
        {
            return InternalRequestAsync<DescribeVulDefencePluginStatusResponse>(req, "DescribeVulDefencePluginStatus");
        }

        /// <summary>
        /// This API is used to obtain the vulnerability defense plugin status of each host.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefencePluginStatusRequest"/></param>
        /// <returns><see cref="DescribeVulDefencePluginStatusResponse"/></returns>
        public DescribeVulDefencePluginStatusResponse DescribeVulDefencePluginStatusSync(DescribeVulDefencePluginStatusRequest req)
        {
            return InternalRequestAsync<DescribeVulDefencePluginStatusResponse>(req, "DescribeVulDefencePluginStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the current vulnerability defense plugin settings.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefenceSettingRequest"/></param>
        /// <returns><see cref="DescribeVulDefenceSettingResponse"/></returns>
        public Task<DescribeVulDefenceSettingResponse> DescribeVulDefenceSetting(DescribeVulDefenceSettingRequest req)
        {
            return InternalRequestAsync<DescribeVulDefenceSettingResponse>(req, "DescribeVulDefenceSetting");
        }

        /// <summary>
        /// This API is used to obtain the current vulnerability defense plugin settings.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefenceSettingRequest"/></param>
        /// <returns><see cref="DescribeVulDefenceSettingResponse"/></returns>
        public DescribeVulDefenceSettingResponse DescribeVulDefenceSettingSync(DescribeVulDefenceSettingRequest req)
        {
            return InternalRequestAsync<DescribeVulDefenceSettingResponse>(req, "DescribeVulDefenceSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of hosts affected by vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulEffectHostListRequest"/></param>
        /// <returns><see cref="DescribeVulEffectHostListResponse"/></returns>
        public Task<DescribeVulEffectHostListResponse> DescribeVulEffectHostList(DescribeVulEffectHostListRequest req)
        {
            return InternalRequestAsync<DescribeVulEffectHostListResponse>(req, "DescribeVulEffectHostList");
        }

        /// <summary>
        /// This API is used to obtain the list of hosts affected by vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulEffectHostListRequest"/></param>
        /// <returns><see cref="DescribeVulEffectHostListResponse"/></returns>
        public DescribeVulEffectHostListResponse DescribeVulEffectHostListSync(DescribeVulEffectHostListRequest req)
        {
            return InternalRequestAsync<DescribeVulEffectHostListResponse>(req, "DescribeVulEffectHostList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of components affected by vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulEffectModulesRequest"/></param>
        /// <returns><see cref="DescribeVulEffectModulesResponse"/></returns>
        public Task<DescribeVulEffectModulesResponse> DescribeVulEffectModules(DescribeVulEffectModulesRequest req)
        {
            return InternalRequestAsync<DescribeVulEffectModulesResponse>(req, "DescribeVulEffectModules");
        }

        /// <summary>
        /// This API is used to obtain the list of components affected by vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulEffectModulesRequest"/></param>
        /// <returns><see cref="DescribeVulEffectModulesResponse"/></returns>
        public DescribeVulEffectModulesResponse DescribeVulEffectModulesSync(DescribeVulEffectModulesRequest req)
        {
            return InternalRequestAsync<DescribeVulEffectModulesResponse>(req, "DescribeVulEffectModules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain vulnerability emergency notifications.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulEmergentMsgRequest"/></param>
        /// <returns><see cref="DescribeVulEmergentMsgResponse"/></returns>
        public Task<DescribeVulEmergentMsgResponse> DescribeVulEmergentMsg(DescribeVulEmergentMsgRequest req)
        {
            return InternalRequestAsync<DescribeVulEmergentMsgResponse>(req, "DescribeVulEmergentMsg");
        }

        /// <summary>
        /// This API is used to obtain vulnerability emergency notifications.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulEmergentMsgRequest"/></param>
        /// <returns><see cref="DescribeVulEmergentMsgResponse"/></returns>
        public DescribeVulEmergentMsgResponse DescribeVulEmergentMsgSync(DescribeVulEmergentMsgRequest req)
        {
            return InternalRequestAsync<DescribeVulEmergentMsgResponse>(req, "DescribeVulEmergentMsg")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to check the host vulnerability fixing progress.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulFixStatusRequest"/></param>
        /// <returns><see cref="DescribeVulFixStatusResponse"/></returns>
        public Task<DescribeVulFixStatusResponse> DescribeVulFixStatus(DescribeVulFixStatusRequest req)
        {
            return InternalRequestAsync<DescribeVulFixStatusResponse>(req, "DescribeVulFixStatus");
        }

        /// <summary>
        /// This API is used to check the host vulnerability fixing progress.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulFixStatusRequest"/></param>
        /// <returns><see cref="DescribeVulFixStatusResponse"/></returns>
        public DescribeVulFixStatusResponse DescribeVulFixStatusSync(DescribeVulFixStatusRequest req)
        {
            return InternalRequestAsync<DescribeVulFixStatusResponse>(req, "DescribeVulFixStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the number of vulnerabilities pending to be processed and affected hosts.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulHostCountScanTimeRequest"/></param>
        /// <returns><see cref="DescribeVulHostCountScanTimeResponse"/></returns>
        public Task<DescribeVulHostCountScanTimeResponse> DescribeVulHostCountScanTime(DescribeVulHostCountScanTimeRequest req)
        {
            return InternalRequestAsync<DescribeVulHostCountScanTimeResponse>(req, "DescribeVulHostCountScanTime");
        }

        /// <summary>
        /// This API is used to obtain the number of vulnerabilities pending to be processed and affected hosts.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulHostCountScanTimeRequest"/></param>
        /// <returns><see cref="DescribeVulHostCountScanTimeResponse"/></returns>
        public DescribeVulHostCountScanTimeResponse DescribeVulHostCountScanTimeSync(DescribeVulHostCountScanTimeRequest req)
        {
            return InternalRequestAsync<DescribeVulHostCountScanTimeResponse>(req, "DescribeVulHostCountScanTime")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of top server risks.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulHostTopRequest"/></param>
        /// <returns><see cref="DescribeVulHostTopResponse"/></returns>
        public Task<DescribeVulHostTopResponse> DescribeVulHostTop(DescribeVulHostTopRequest req)
        {
            return InternalRequestAsync<DescribeVulHostTopResponse>(req, "DescribeVulHostTop");
        }

        /// <summary>
        /// This API is used to obtain the list of top server risks.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulHostTopRequest"/></param>
        /// <returns><see cref="DescribeVulHostTopResponse"/></returns>
        public DescribeVulHostTopResponse DescribeVulHostTopSync(DescribeVulHostTopRequest req)
        {
            return InternalRequestAsync<DescribeVulHostTopResponse>(req, "DescribeVulHostTop")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain vulnerability details with the CVSS version.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulInfoCvssRequest"/></param>
        /// <returns><see cref="DescribeVulInfoCvssResponse"/></returns>
        public Task<DescribeVulInfoCvssResponse> DescribeVulInfoCvss(DescribeVulInfoCvssRequest req)
        {
            return InternalRequestAsync<DescribeVulInfoCvssResponse>(req, "DescribeVulInfoCvss");
        }

        /// <summary>
        /// This API is used to obtain vulnerability details with the CVSS version.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulInfoCvssRequest"/></param>
        /// <returns><see cref="DescribeVulInfoCvssResponse"/></returns>
        public DescribeVulInfoCvssResponse DescribeVulInfoCvssSync(DescribeVulInfoCvssRequest req)
        {
            return InternalRequestAsync<DescribeVulInfoCvssResponse>(req, "DescribeVulInfoCvss")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of all user vulnerability tags.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulLabelsRequest"/></param>
        /// <returns><see cref="DescribeVulLabelsResponse"/></returns>
        public Task<DescribeVulLabelsResponse> DescribeVulLabels(DescribeVulLabelsRequest req)
        {
            return InternalRequestAsync<DescribeVulLabelsResponse>(req, "DescribeVulLabels");
        }

        /// <summary>
        /// This API is used to obtain the list of all user vulnerability tags.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulLabelsRequest"/></param>
        /// <returns><see cref="DescribeVulLabelsResponse"/></returns>
        public DescribeVulLabelsResponse DescribeVulLabelsSync(DescribeVulLabelsRequest req)
        {
            return InternalRequestAsync<DescribeVulLabelsResponse>(req, "DescribeVulLabels")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the statistics of vulnerability quantity and level distribution.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulLevelCountRequest"/></param>
        /// <returns><see cref="DescribeVulLevelCountResponse"/></returns>
        public Task<DescribeVulLevelCountResponse> DescribeVulLevelCount(DescribeVulLevelCountRequest req)
        {
            return InternalRequestAsync<DescribeVulLevelCountResponse>(req, "DescribeVulLevelCount");
        }

        /// <summary>
        /// This API is used to obtain the statistics of vulnerability quantity and level distribution.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulLevelCountRequest"/></param>
        /// <returns><see cref="DescribeVulLevelCountResponse"/></returns>
        public DescribeVulLevelCountResponse DescribeVulLevelCountSync(DescribeVulLevelCountRequest req)
        {
            return InternalRequestAsync<DescribeVulLevelCountResponse>(req, "DescribeVulLevelCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the data of the vulnerability list.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulListRequest"/></param>
        /// <returns><see cref="DescribeVulListResponse"/></returns>
        public Task<DescribeVulListResponse> DescribeVulList(DescribeVulListRequest req)
        {
            return InternalRequestAsync<DescribeVulListResponse>(req, "DescribeVulList");
        }

        /// <summary>
        /// This API is used to obtain the data of the vulnerability list.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulListRequest"/></param>
        /// <returns><see cref="DescribeVulListResponse"/></returns>
        public DescribeVulListResponse DescribeVulListSync(DescribeVulListRequest req)
        {
            return InternalRequestAsync<DescribeVulListResponse>(req, "DescribeVulList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the data for the vulnerability overview.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulOverviewRequest"/></param>
        /// <returns><see cref="DescribeVulOverviewResponse"/></returns>
        public Task<DescribeVulOverviewResponse> DescribeVulOverview(DescribeVulOverviewRequest req)
        {
            return InternalRequestAsync<DescribeVulOverviewResponse>(req, "DescribeVulOverview");
        }

        /// <summary>
        /// This API is used to obtain the data for the vulnerability overview.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulOverviewRequest"/></param>
        /// <returns><see cref="DescribeVulOverviewResponse"/></returns>
        public DescribeVulOverviewResponse DescribeVulOverviewSync(DescribeVulOverviewRequest req)
        {
            return InternalRequestAsync<DescribeVulOverviewResponse>(req, "DescribeVulOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the vulnerability database list.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulStoreListRequest"/></param>
        /// <returns><see cref="DescribeVulStoreListResponse"/></returns>
        public Task<DescribeVulStoreListResponse> DescribeVulStoreList(DescribeVulStoreListRequest req)
        {
            return InternalRequestAsync<DescribeVulStoreListResponse>(req, "DescribeVulStoreList");
        }

        /// <summary>
        /// This API is used to obtain the vulnerability database list.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulStoreListRequest"/></param>
        /// <returns><see cref="DescribeVulStoreListResponse"/></returns>
        public DescribeVulStoreListResponse DescribeVulStoreListSync(DescribeVulStoreListRequest req)
        {
            return InternalRequestAsync<DescribeVulStoreListResponse>(req, "DescribeVulStoreList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to count top vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulTopRequest"/></param>
        /// <returns><see cref="DescribeVulTopResponse"/></returns>
        public Task<DescribeVulTopResponse> DescribeVulTop(DescribeVulTopRequest req)
        {
            return InternalRequestAsync<DescribeVulTopResponse>(req, "DescribeVulTop");
        }

        /// <summary>
        /// This API is used to count top vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulTopRequest"/></param>
        /// <returns><see cref="DescribeVulTopResponse"/></returns>
        public DescribeVulTopResponse DescribeVulTopSync(DescribeVulTopRequest req)
        {
            return InternalRequestAsync<DescribeVulTopResponse>(req, "DescribeVulTop")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain information of the vulnerability situation.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulTrendRequest"/></param>
        /// <returns><see cref="DescribeVulTrendResponse"/></returns>
        public Task<DescribeVulTrendResponse> DescribeVulTrend(DescribeVulTrendRequest req)
        {
            return InternalRequestAsync<DescribeVulTrendResponse>(req, "DescribeVulTrend");
        }

        /// <summary>
        /// This API is used to obtain information of the vulnerability situation.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulTrendRequest"/></param>
        /// <returns><see cref="DescribeVulTrendResponse"/></returns>
        public DescribeVulTrendResponse DescribeVulTrendSync(DescribeVulTrendRequest req)
        {
            return InternalRequestAsync<DescribeVulTrendResponse>(req, "DescribeVulTrend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the alarming machine scope settings.
        /// </summary>
        /// <param name="req"><see cref="DescribeWarningHostConfigRequest"/></param>
        /// <returns><see cref="DescribeWarningHostConfigResponse"/></returns>
        public Task<DescribeWarningHostConfigResponse> DescribeWarningHostConfig(DescribeWarningHostConfigRequest req)
        {
            return InternalRequestAsync<DescribeWarningHostConfigResponse>(req, "DescribeWarningHostConfig");
        }

        /// <summary>
        /// This API is used to query the alarming machine scope settings.
        /// </summary>
        /// <param name="req"><see cref="DescribeWarningHostConfigRequest"/></param>
        /// <returns><see cref="DescribeWarningHostConfigResponse"/></returns>
        public DescribeWarningHostConfigResponse DescribeWarningHostConfigSync(DescribeWarningHostConfigRequest req)
        {
            return InternalRequestAsync<DescribeWarningHostConfigResponse>(req, "DescribeWarningHostConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of the current user's alarms.
        /// </summary>
        /// <param name="req"><see cref="DescribeWarningListRequest"/></param>
        /// <returns><see cref="DescribeWarningListResponse"/></returns>
        public Task<DescribeWarningListResponse> DescribeWarningList(DescribeWarningListRequest req)
        {
            return InternalRequestAsync<DescribeWarningListResponse>(req, "DescribeWarningList");
        }

        /// <summary>
        /// This API is used to obtain the list of the current user's alarms.
        /// </summary>
        /// <param name="req"><see cref="DescribeWarningListRequest"/></param>
        /// <returns><see cref="DescribeWarningListResponse"/></returns>
        public DescribeWarningListResponse DescribeWarningListSync(DescribeWarningListRequest req)
        {
            return InternalRequestAsync<DescribeWarningListResponse>(req, "DescribeWarningList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query alarm policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebHookPolicyRequest"/></param>
        /// <returns><see cref="DescribeWebHookPolicyResponse"/></returns>
        public Task<DescribeWebHookPolicyResponse> DescribeWebHookPolicy(DescribeWebHookPolicyRequest req)
        {
            return InternalRequestAsync<DescribeWebHookPolicyResponse>(req, "DescribeWebHookPolicy");
        }

        /// <summary>
        /// This API is used to query alarm policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebHookPolicyRequest"/></param>
        /// <returns><see cref="DescribeWebHookPolicyResponse"/></returns>
        public DescribeWebHookPolicyResponse DescribeWebHookPolicySync(DescribeWebHookPolicyRequest req)
        {
            return InternalRequestAsync<DescribeWebHookPolicyResponse>(req, "DescribeWebHookPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of alarm recipients.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebHookReceiverRequest"/></param>
        /// <returns><see cref="DescribeWebHookReceiverResponse"/></returns>
        public Task<DescribeWebHookReceiverResponse> DescribeWebHookReceiver(DescribeWebHookReceiverRequest req)
        {
            return InternalRequestAsync<DescribeWebHookReceiverResponse>(req, "DescribeWebHookReceiver");
        }

        /// <summary>
        /// This API is used to query the list of alarm recipients.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebHookReceiverRequest"/></param>
        /// <returns><see cref="DescribeWebHookReceiverResponse"/></returns>
        public DescribeWebHookReceiverResponse DescribeWebHookReceiverSync(DescribeWebHookReceiverRequest req)
        {
            return InternalRequestAsync<DescribeWebHookReceiverResponse>(req, "DescribeWebHookReceiver")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the usage of policies associated with the specified alarm recipient.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebHookReceiverUsageRequest"/></param>
        /// <returns><see cref="DescribeWebHookReceiverUsageResponse"/></returns>
        public Task<DescribeWebHookReceiverUsageResponse> DescribeWebHookReceiverUsage(DescribeWebHookReceiverUsageRequest req)
        {
            return InternalRequestAsync<DescribeWebHookReceiverUsageResponse>(req, "DescribeWebHookReceiverUsage");
        }

        /// <summary>
        /// This API is used to query the usage of policies associated with the specified alarm recipient.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebHookReceiverUsageRequest"/></param>
        /// <returns><see cref="DescribeWebHookReceiverUsageResponse"/></returns>
        public DescribeWebHookReceiverUsageResponse DescribeWebHookReceiverUsageSync(DescribeWebHookReceiverUsageRequest req)
        {
            return InternalRequestAsync<DescribeWebHookReceiverUsageResponse>(req, "DescribeWebHookReceiverUsage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the details of the WeCom chatbot rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebHookRuleRequest"/></param>
        /// <returns><see cref="DescribeWebHookRuleResponse"/></returns>
        public Task<DescribeWebHookRuleResponse> DescribeWebHookRule(DescribeWebHookRuleRequest req)
        {
            return InternalRequestAsync<DescribeWebHookRuleResponse>(req, "DescribeWebHookRule");
        }

        /// <summary>
        /// This API is used to obtain the details of the WeCom chatbot rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebHookRuleRequest"/></param>
        /// <returns><see cref="DescribeWebHookRuleResponse"/></returns>
        public DescribeWebHookRuleResponse DescribeWebHookRuleSync(DescribeWebHookRuleRequest req)
        {
            return InternalRequestAsync<DescribeWebHookRuleResponse>(req, "DescribeWebHookRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of WeCom chatbot rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebHookRulesRequest"/></param>
        /// <returns><see cref="DescribeWebHookRulesResponse"/></returns>
        public Task<DescribeWebHookRulesResponse> DescribeWebHookRules(DescribeWebHookRulesRequest req)
        {
            return InternalRequestAsync<DescribeWebHookRulesResponse>(req, "DescribeWebHookRules");
        }

        /// <summary>
        /// This API is used to obtain the list of WeCom chatbot rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebHookRulesRequest"/></param>
        /// <returns><see cref="DescribeWebHookRulesResponse"/></returns>
        public DescribeWebHookRulesResponse DescribeWebHookRulesSync(DescribeWebHookRulesRequest req)
        {
            return InternalRequestAsync<DescribeWebHookRulesResponse>(req, "DescribeWebHookRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to terminate resources.
        /// </summary>
        /// <param name="req"><see cref="DestroyOrderRequest"/></param>
        /// <returns><see cref="DestroyOrderResponse"/></returns>
        public Task<DestroyOrderResponse> DestroyOrder(DestroyOrderRequest req)
        {
            return InternalRequestAsync<DestroyOrderResponse>(req, "DestroyOrder");
        }

        /// <summary>
        /// This API is used to terminate resources.
        /// </summary>
        /// <param name="req"><see cref="DestroyOrderRequest"/></param>
        /// <returns><see cref="DestroyOrderResponse"/></returns>
        public DestroyOrderResponse DestroyOrderSync(DestroyOrderRequest req)
        {
            return InternalRequestAsync<DestroyOrderResponse>(req, "DestroyOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add or modify high-risk command rules.
        /// </summary>
        /// <param name="req"><see cref="EditBashRulesRequest"/></param>
        /// <returns><see cref="EditBashRulesResponse"/></returns>
        public Task<EditBashRulesResponse> EditBashRules(EditBashRulesRequest req)
        {
            return InternalRequestAsync<EditBashRulesResponse>(req, "EditBashRules");
        }

        /// <summary>
        /// This API is used to add or modify high-risk command rules.
        /// </summary>
        /// <param name="req"><see cref="EditBashRulesRequest"/></param>
        /// <returns><see cref="EditBashRulesResponse"/></returns>
        public EditBashRulesResponse EditBashRulesSync(EditBashRulesRequest req)
        {
            return InternalRequestAsync<EditBashRulesResponse>(req, "EditBashRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add or modify local privilege escalation rules (multiple servers supported).
        /// </summary>
        /// <param name="req"><see cref="EditPrivilegeRulesRequest"/></param>
        /// <returns><see cref="EditPrivilegeRulesResponse"/></returns>
        public Task<EditPrivilegeRulesResponse> EditPrivilegeRules(EditPrivilegeRulesRequest req)
        {
            return InternalRequestAsync<EditPrivilegeRulesResponse>(req, "EditPrivilegeRules");
        }

        /// <summary>
        /// This API is used to add or modify local privilege escalation rules (multiple servers supported).
        /// </summary>
        /// <param name="req"><see cref="EditPrivilegeRulesRequest"/></param>
        /// <returns><see cref="EditPrivilegeRulesResponse"/></returns>
        public EditPrivilegeRulesResponse EditPrivilegeRulesSync(EditPrivilegeRulesRequest req)
        {
            return InternalRequestAsync<EditPrivilegeRulesResponse>(req, "EditPrivilegeRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to edit reverse shell rules (multiple servers supported).
        /// </summary>
        /// <param name="req"><see cref="EditReverseShellRulesRequest"/></param>
        /// <returns><see cref="EditReverseShellRulesResponse"/></returns>
        public Task<EditReverseShellRulesResponse> EditReverseShellRules(EditReverseShellRulesRequest req)
        {
            return InternalRequestAsync<EditReverseShellRulesResponse>(req, "EditReverseShellRules");
        }

        /// <summary>
        /// This API is used to edit reverse shell rules (multiple servers supported).
        /// </summary>
        /// <param name="req"><see cref="EditReverseShellRulesRequest"/></param>
        /// <returns><see cref="EditReverseShellRulesResponse"/></returns>
        public EditReverseShellRulesResponse EditReverseShellRulesSync(EditReverseShellRulesRequest req)
        {
            return InternalRequestAsync<EditReverseShellRulesResponse>(req, "EditReverseShellRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add or edit tags.
        /// </summary>
        /// <param name="req"><see cref="EditTagsRequest"/></param>
        /// <returns><see cref="EditTagsResponse"/></returns>
        public Task<EditTagsResponse> EditTags(EditTagsRequest req)
        {
            return InternalRequestAsync<EditTagsResponse>(req, "EditTags");
        }

        /// <summary>
        /// This API is used to add or edit tags.
        /// </summary>
        /// <param name="req"><see cref="EditTagsRequest"/></param>
        /// <returns><see cref="EditTagsResponse"/></returns>
        public EditTagsResponse EditTagsSync(EditTagsRequest req)
        {
            return InternalRequestAsync<EditTagsResponse>(req, "EditTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the list of asset management applications.
        /// </summary>
        /// <param name="req"><see cref="ExportAssetAppListRequest"/></param>
        /// <returns><see cref="ExportAssetAppListResponse"/></returns>
        public Task<ExportAssetAppListResponse> ExportAssetAppList(ExportAssetAppListRequest req)
        {
            return InternalRequestAsync<ExportAssetAppListResponse>(req, "ExportAssetAppList");
        }

        /// <summary>
        /// This API is used to export the list of asset management applications.
        /// </summary>
        /// <param name="req"><see cref="ExportAssetAppListRequest"/></param>
        /// <returns><see cref="ExportAssetAppListResponse"/></returns>
        public ExportAssetAppListResponse ExportAssetAppListSync(ExportAssetAppListRequest req)
        {
            return InternalRequestAsync<ExportAssetAppListResponse>(req, "ExportAssetAppList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the list of asset management kernel modules.
        /// </summary>
        /// <param name="req"><see cref="ExportAssetCoreModuleListRequest"/></param>
        /// <returns><see cref="ExportAssetCoreModuleListResponse"/></returns>
        public Task<ExportAssetCoreModuleListResponse> ExportAssetCoreModuleList(ExportAssetCoreModuleListRequest req)
        {
            return InternalRequestAsync<ExportAssetCoreModuleListResponse>(req, "ExportAssetCoreModuleList");
        }

        /// <summary>
        /// This API is used to export the list of asset management kernel modules.
        /// </summary>
        /// <param name="req"><see cref="ExportAssetCoreModuleListRequest"/></param>
        /// <returns><see cref="ExportAssetCoreModuleListResponse"/></returns>
        public ExportAssetCoreModuleListResponse ExportAssetCoreModuleListSync(ExportAssetCoreModuleListRequest req)
        {
            return InternalRequestAsync<ExportAssetCoreModuleListResponse>(req, "ExportAssetCoreModuleList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the list of asset management databases.
        /// </summary>
        /// <param name="req"><see cref="ExportAssetDatabaseListRequest"/></param>
        /// <returns><see cref="ExportAssetDatabaseListResponse"/></returns>
        public Task<ExportAssetDatabaseListResponse> ExportAssetDatabaseList(ExportAssetDatabaseListRequest req)
        {
            return InternalRequestAsync<ExportAssetDatabaseListResponse>(req, "ExportAssetDatabaseList");
        }

        /// <summary>
        /// This API is used to export the list of asset management databases.
        /// </summary>
        /// <param name="req"><see cref="ExportAssetDatabaseListRequest"/></param>
        /// <returns><see cref="ExportAssetDatabaseListResponse"/></returns>
        public ExportAssetDatabaseListResponse ExportAssetDatabaseListSync(ExportAssetDatabaseListRequest req)
        {
            return InternalRequestAsync<ExportAssetDatabaseListResponse>(req, "ExportAssetDatabaseList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the list of asset management environment variables.
        /// </summary>
        /// <param name="req"><see cref="ExportAssetEnvListRequest"/></param>
        /// <returns><see cref="ExportAssetEnvListResponse"/></returns>
        public Task<ExportAssetEnvListResponse> ExportAssetEnvList(ExportAssetEnvListRequest req)
        {
            return InternalRequestAsync<ExportAssetEnvListResponse>(req, "ExportAssetEnvList");
        }

        /// <summary>
        /// This API is used to export the list of asset management environment variables.
        /// </summary>
        /// <param name="req"><see cref="ExportAssetEnvListRequest"/></param>
        /// <returns><see cref="ExportAssetEnvListResponse"/></returns>
        public ExportAssetEnvListResponse ExportAssetEnvListSync(ExportAssetEnvListRequest req)
        {
            return InternalRequestAsync<ExportAssetEnvListResponse>(req, "ExportAssetEnvList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the list of asset management startup services.
        /// </summary>
        /// <param name="req"><see cref="ExportAssetInitServiceListRequest"/></param>
        /// <returns><see cref="ExportAssetInitServiceListResponse"/></returns>
        public Task<ExportAssetInitServiceListResponse> ExportAssetInitServiceList(ExportAssetInitServiceListRequest req)
        {
            return InternalRequestAsync<ExportAssetInitServiceListResponse>(req, "ExportAssetInitServiceList");
        }

        /// <summary>
        /// This API is used to export the list of asset management startup services.
        /// </summary>
        /// <param name="req"><see cref="ExportAssetInitServiceListRequest"/></param>
        /// <returns><see cref="ExportAssetInitServiceListResponse"/></returns>
        public ExportAssetInitServiceListResponse ExportAssetInitServiceListSync(ExportAssetInitServiceListRequest req)
        {
            return InternalRequestAsync<ExportAssetInitServiceListResponse>(req, "ExportAssetInitServiceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the list of Jar packages.
        /// </summary>
        /// <param name="req"><see cref="ExportAssetJarListRequest"/></param>
        /// <returns><see cref="ExportAssetJarListResponse"/></returns>
        public Task<ExportAssetJarListResponse> ExportAssetJarList(ExportAssetJarListRequest req)
        {
            return InternalRequestAsync<ExportAssetJarListResponse>(req, "ExportAssetJarList");
        }

        /// <summary>
        /// This API is used to export the list of Jar packages.
        /// </summary>
        /// <param name="req"><see cref="ExportAssetJarListRequest"/></param>
        /// <returns><see cref="ExportAssetJarListResponse"/></returns>
        public ExportAssetJarListResponse ExportAssetJarListSync(ExportAssetJarListRequest req)
        {
            return InternalRequestAsync<ExportAssetJarListResponse>(req, "ExportAssetJarList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export asset management host resource details.
        /// </summary>
        /// <param name="req"><see cref="ExportAssetMachineDetailRequest"/></param>
        /// <returns><see cref="ExportAssetMachineDetailResponse"/></returns>
        public Task<ExportAssetMachineDetailResponse> ExportAssetMachineDetail(ExportAssetMachineDetailRequest req)
        {
            return InternalRequestAsync<ExportAssetMachineDetailResponse>(req, "ExportAssetMachineDetail");
        }

        /// <summary>
        /// This API is used to export asset management host resource details.
        /// </summary>
        /// <param name="req"><see cref="ExportAssetMachineDetailRequest"/></param>
        /// <returns><see cref="ExportAssetMachineDetailResponse"/></returns>
        public ExportAssetMachineDetailResponse ExportAssetMachineDetailSync(ExportAssetMachineDetailRequest req)
        {
            return InternalRequestAsync<ExportAssetMachineDetailResponse>(req, "ExportAssetMachineDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the list of resource monitoring.
        /// </summary>
        /// <param name="req"><see cref="ExportAssetMachineListRequest"/></param>
        /// <returns><see cref="ExportAssetMachineListResponse"/></returns>
        public Task<ExportAssetMachineListResponse> ExportAssetMachineList(ExportAssetMachineListRequest req)
        {
            return InternalRequestAsync<ExportAssetMachineListResponse>(req, "ExportAssetMachineList");
        }

        /// <summary>
        /// This API is used to export the list of resource monitoring.
        /// </summary>
        /// <param name="req"><see cref="ExportAssetMachineListRequest"/></param>
        /// <returns><see cref="ExportAssetMachineListResponse"/></returns>
        public ExportAssetMachineListResponse ExportAssetMachineListSync(ExportAssetMachineListRequest req)
        {
            return InternalRequestAsync<ExportAssetMachineListResponse>(req, "ExportAssetMachineList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the list of scheduled asset management tasks.
        /// </summary>
        /// <param name="req"><see cref="ExportAssetPlanTaskListRequest"/></param>
        /// <returns><see cref="ExportAssetPlanTaskListResponse"/></returns>
        public Task<ExportAssetPlanTaskListResponse> ExportAssetPlanTaskList(ExportAssetPlanTaskListRequest req)
        {
            return InternalRequestAsync<ExportAssetPlanTaskListResponse>(req, "ExportAssetPlanTaskList");
        }

        /// <summary>
        /// This API is used to export the list of scheduled asset management tasks.
        /// </summary>
        /// <param name="req"><see cref="ExportAssetPlanTaskListRequest"/></param>
        /// <returns><see cref="ExportAssetPlanTaskListResponse"/></returns>
        public ExportAssetPlanTaskListResponse ExportAssetPlanTaskListSync(ExportAssetPlanTaskListRequest req)
        {
            return InternalRequestAsync<ExportAssetPlanTaskListResponse>(req, "ExportAssetPlanTaskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the list of asset management ports.
        /// </summary>
        /// <param name="req"><see cref="ExportAssetPortInfoListRequest"/></param>
        /// <returns><see cref="ExportAssetPortInfoListResponse"/></returns>
        public Task<ExportAssetPortInfoListResponse> ExportAssetPortInfoList(ExportAssetPortInfoListRequest req)
        {
            return InternalRequestAsync<ExportAssetPortInfoListResponse>(req, "ExportAssetPortInfoList");
        }

        /// <summary>
        /// This API is used to export the list of asset management ports.
        /// </summary>
        /// <param name="req"><see cref="ExportAssetPortInfoListRequest"/></param>
        /// <returns><see cref="ExportAssetPortInfoListResponse"/></returns>
        public ExportAssetPortInfoListResponse ExportAssetPortInfoListSync(ExportAssetPortInfoListRequest req)
        {
            return InternalRequestAsync<ExportAssetPortInfoListResponse>(req, "ExportAssetPortInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the asset management process list.
        /// </summary>
        /// <param name="req"><see cref="ExportAssetProcessInfoListRequest"/></param>
        /// <returns><see cref="ExportAssetProcessInfoListResponse"/></returns>
        public Task<ExportAssetProcessInfoListResponse> ExportAssetProcessInfoList(ExportAssetProcessInfoListRequest req)
        {
            return InternalRequestAsync<ExportAssetProcessInfoListResponse>(req, "ExportAssetProcessInfoList");
        }

        /// <summary>
        /// This API is used to export the asset management process list.
        /// </summary>
        /// <param name="req"><see cref="ExportAssetProcessInfoListRequest"/></param>
        /// <returns><see cref="ExportAssetProcessInfoListResponse"/></returns>
        public ExportAssetProcessInfoListResponse ExportAssetProcessInfoListSync(ExportAssetProcessInfoListRequest req)
        {
            return InternalRequestAsync<ExportAssetProcessInfoListResponse>(req, "ExportAssetProcessInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export host trends of recent days (up to last 90 days).
        /// </summary>
        /// <param name="req"><see cref="ExportAssetRecentMachineInfoRequest"/></param>
        /// <returns><see cref="ExportAssetRecentMachineInfoResponse"/></returns>
        public Task<ExportAssetRecentMachineInfoResponse> ExportAssetRecentMachineInfo(ExportAssetRecentMachineInfoRequest req)
        {
            return InternalRequestAsync<ExportAssetRecentMachineInfoResponse>(req, "ExportAssetRecentMachineInfo");
        }

        /// <summary>
        /// This API is used to export host trends of recent days (up to last 90 days).
        /// </summary>
        /// <param name="req"><see cref="ExportAssetRecentMachineInfoRequest"/></param>
        /// <returns><see cref="ExportAssetRecentMachineInfoResponse"/></returns>
        public ExportAssetRecentMachineInfoResponse ExportAssetRecentMachineInfoSync(ExportAssetRecentMachineInfoRequest req)
        {
            return InternalRequestAsync<ExportAssetRecentMachineInfoResponse>(req, "ExportAssetRecentMachineInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the list of system installation packages for asset management.
        /// </summary>
        /// <param name="req"><see cref="ExportAssetSystemPackageListRequest"/></param>
        /// <returns><see cref="ExportAssetSystemPackageListResponse"/></returns>
        public Task<ExportAssetSystemPackageListResponse> ExportAssetSystemPackageList(ExportAssetSystemPackageListRequest req)
        {
            return InternalRequestAsync<ExportAssetSystemPackageListResponse>(req, "ExportAssetSystemPackageList");
        }

        /// <summary>
        /// This API is used to export the list of system installation packages for asset management.
        /// </summary>
        /// <param name="req"><see cref="ExportAssetSystemPackageListRequest"/></param>
        /// <returns><see cref="ExportAssetSystemPackageListResponse"/></returns>
        public ExportAssetSystemPackageListResponse ExportAssetSystemPackageListSync(ExportAssetSystemPackageListRequest req)
        {
            return InternalRequestAsync<ExportAssetSystemPackageListResponse>(req, "ExportAssetSystemPackageList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the account list.
        /// </summary>
        /// <param name="req"><see cref="ExportAssetUserListRequest"/></param>
        /// <returns><see cref="ExportAssetUserListResponse"/></returns>
        public Task<ExportAssetUserListResponse> ExportAssetUserList(ExportAssetUserListRequest req)
        {
            return InternalRequestAsync<ExportAssetUserListResponse>(req, "ExportAssetUserList");
        }

        /// <summary>
        /// This API is used to export the account list.
        /// </summary>
        /// <param name="req"><see cref="ExportAssetUserListRequest"/></param>
        /// <returns><see cref="ExportAssetUserListResponse"/></returns>
        public ExportAssetUserListResponse ExportAssetUserListSync(ExportAssetUserListRequest req)
        {
            return InternalRequestAsync<ExportAssetUserListResponse>(req, "ExportAssetUserList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the list of asset management Web applications.
        /// </summary>
        /// <param name="req"><see cref="ExportAssetWebAppListRequest"/></param>
        /// <returns><see cref="ExportAssetWebAppListResponse"/></returns>
        public Task<ExportAssetWebAppListResponse> ExportAssetWebAppList(ExportAssetWebAppListRequest req)
        {
            return InternalRequestAsync<ExportAssetWebAppListResponse>(req, "ExportAssetWebAppList");
        }

        /// <summary>
        /// This API is used to export the list of asset management Web applications.
        /// </summary>
        /// <param name="req"><see cref="ExportAssetWebAppListRequest"/></param>
        /// <returns><see cref="ExportAssetWebAppListResponse"/></returns>
        public ExportAssetWebAppListResponse ExportAssetWebAppListSync(ExportAssetWebAppListRequest req)
        {
            return InternalRequestAsync<ExportAssetWebAppListResponse>(req, "ExportAssetWebAppList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the list of asset management Web frameworks.
        /// </summary>
        /// <param name="req"><see cref="ExportAssetWebFrameListRequest"/></param>
        /// <returns><see cref="ExportAssetWebFrameListResponse"/></returns>
        public Task<ExportAssetWebFrameListResponse> ExportAssetWebFrameList(ExportAssetWebFrameListRequest req)
        {
            return InternalRequestAsync<ExportAssetWebFrameListResponse>(req, "ExportAssetWebFrameList");
        }

        /// <summary>
        /// This API is used to export the list of asset management Web frameworks.
        /// </summary>
        /// <param name="req"><see cref="ExportAssetWebFrameListRequest"/></param>
        /// <returns><see cref="ExportAssetWebFrameListResponse"/></returns>
        public ExportAssetWebFrameListResponse ExportAssetWebFrameListSync(ExportAssetWebFrameListRequest req)
        {
            return InternalRequestAsync<ExportAssetWebFrameListResponse>(req, "ExportAssetWebFrameList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the list of Web sites.
        /// </summary>
        /// <param name="req"><see cref="ExportAssetWebLocationListRequest"/></param>
        /// <returns><see cref="ExportAssetWebLocationListResponse"/></returns>
        public Task<ExportAssetWebLocationListResponse> ExportAssetWebLocationList(ExportAssetWebLocationListRequest req)
        {
            return InternalRequestAsync<ExportAssetWebLocationListResponse>(req, "ExportAssetWebLocationList");
        }

        /// <summary>
        /// This API is used to export the list of Web sites.
        /// </summary>
        /// <param name="req"><see cref="ExportAssetWebLocationListRequest"/></param>
        /// <returns><see cref="ExportAssetWebLocationListResponse"/></returns>
        public ExportAssetWebLocationListResponse ExportAssetWebLocationListSync(ExportAssetWebLocationListRequest req)
        {
            return InternalRequestAsync<ExportAssetWebLocationListResponse>(req, "ExportAssetWebLocationList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the list of asset management Web services.
        /// </summary>
        /// <param name="req"><see cref="ExportAssetWebServiceInfoListRequest"/></param>
        /// <returns><see cref="ExportAssetWebServiceInfoListResponse"/></returns>
        public Task<ExportAssetWebServiceInfoListResponse> ExportAssetWebServiceInfoList(ExportAssetWebServiceInfoListRequest req)
        {
            return InternalRequestAsync<ExportAssetWebServiceInfoListResponse>(req, "ExportAssetWebServiceInfoList");
        }

        /// <summary>
        /// This API is used to export the list of asset management Web services.
        /// </summary>
        /// <param name="req"><see cref="ExportAssetWebServiceInfoListRequest"/></param>
        /// <returns><see cref="ExportAssetWebServiceInfoListResponse"/></returns>
        public ExportAssetWebServiceInfoListResponse ExportAssetWebServiceInfoListSync(ExportAssetWebServiceInfoListRequest req)
        {
            return InternalRequestAsync<ExportAssetWebServiceInfoListResponse>(req, "ExportAssetWebServiceInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export network attack events.
        /// </summary>
        /// <param name="req"><see cref="ExportAttackEventsRequest"/></param>
        /// <returns><see cref="ExportAttackEventsResponse"/></returns>
        public Task<ExportAttackEventsResponse> ExportAttackEvents(ExportAttackEventsRequest req)
        {
            return InternalRequestAsync<ExportAttackEventsResponse>(req, "ExportAttackEvents");
        }

        /// <summary>
        /// This API is used to export network attack events.
        /// </summary>
        /// <param name="req"><see cref="ExportAttackEventsRequest"/></param>
        /// <returns><see cref="ExportAttackEventsResponse"/></returns>
        public ExportAttackEventsResponse ExportAttackEventsSync(ExportAttackEventsRequest req)
        {
            return InternalRequestAsync<ExportAttackEventsResponse>(req, "ExportAttackEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the list of hosts affected by baseline.
        /// </summary>
        /// <param name="req"><see cref="ExportBaselineEffectHostListRequest"/></param>
        /// <returns><see cref="ExportBaselineEffectHostListResponse"/></returns>
        public Task<ExportBaselineEffectHostListResponse> ExportBaselineEffectHostList(ExportBaselineEffectHostListRequest req)
        {
            return InternalRequestAsync<ExportBaselineEffectHostListResponse>(req, "ExportBaselineEffectHostList");
        }

        /// <summary>
        /// This API is used to export the list of hosts affected by baseline.
        /// </summary>
        /// <param name="req"><see cref="ExportBaselineEffectHostListRequest"/></param>
        /// <returns><see cref="ExportBaselineEffectHostListResponse"/></returns>
        public ExportBaselineEffectHostListResponse ExportBaselineEffectHostListSync(ExportBaselineEffectHostListRequest req)
        {
            return InternalRequestAsync<ExportBaselineEffectHostListResponse>(req, "ExportBaselineEffectHostList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the list of fixing baselines.
        /// </summary>
        /// <param name="req"><see cref="ExportBaselineFixListRequest"/></param>
        /// <returns><see cref="ExportBaselineFixListResponse"/></returns>
        public Task<ExportBaselineFixListResponse> ExportBaselineFixList(ExportBaselineFixListRequest req)
        {
            return InternalRequestAsync<ExportBaselineFixListResponse>(req, "ExportBaselineFixList");
        }

        /// <summary>
        /// This API is used to export the list of fixing baselines.
        /// </summary>
        /// <param name="req"><see cref="ExportBaselineFixListRequest"/></param>
        /// <returns><see cref="ExportBaselineFixListResponse"/></returns>
        public ExportBaselineFixListResponse ExportBaselineFixListSync(ExportBaselineFixListRequest req)
        {
            return InternalRequestAsync<ExportBaselineFixListResponse>(req, "ExportBaselineFixList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the baseline for host detection.
        /// </summary>
        /// <param name="req"><see cref="ExportBaselineHostDetectListRequest"/></param>
        /// <returns><see cref="ExportBaselineHostDetectListResponse"/></returns>
        public Task<ExportBaselineHostDetectListResponse> ExportBaselineHostDetectList(ExportBaselineHostDetectListRequest req)
        {
            return InternalRequestAsync<ExportBaselineHostDetectListResponse>(req, "ExportBaselineHostDetectList");
        }

        /// <summary>
        /// This API is used to export the baseline for host detection.
        /// </summary>
        /// <param name="req"><see cref="ExportBaselineHostDetectListRequest"/></param>
        /// <returns><see cref="ExportBaselineHostDetectListResponse"/></returns>
        public ExportBaselineHostDetectListResponse ExportBaselineHostDetectListSync(ExportBaselineHostDetectListRequest req)
        {
            return InternalRequestAsync<ExportBaselineHostDetectListResponse>(req, "ExportBaselineHostDetectList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export baseline check items.
        /// </summary>
        /// <param name="req"><see cref="ExportBaselineItemDetectListRequest"/></param>
        /// <returns><see cref="ExportBaselineItemDetectListResponse"/></returns>
        public Task<ExportBaselineItemDetectListResponse> ExportBaselineItemDetectList(ExportBaselineItemDetectListRequest req)
        {
            return InternalRequestAsync<ExportBaselineItemDetectListResponse>(req, "ExportBaselineItemDetectList");
        }

        /// <summary>
        /// This API is used to export baseline check items.
        /// </summary>
        /// <param name="req"><see cref="ExportBaselineItemDetectListRequest"/></param>
        /// <returns><see cref="ExportBaselineItemDetectListResponse"/></returns>
        public ExportBaselineItemDetectListResponse ExportBaselineItemDetectListSync(ExportBaselineItemDetectListRequest req)
        {
            return InternalRequestAsync<ExportBaselineItemDetectListResponse>(req, "ExportBaselineItemDetectList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the list of baselines.
        /// </summary>
        /// <param name="req"><see cref="ExportBaselineListRequest"/></param>
        /// <returns><see cref="ExportBaselineListResponse"/></returns>
        public Task<ExportBaselineListResponse> ExportBaselineList(ExportBaselineListRequest req)
        {
            return InternalRequestAsync<ExportBaselineListResponse>(req, "ExportBaselineList");
        }

        /// <summary>
        /// This API is used to export the list of baselines.
        /// </summary>
        /// <param name="req"><see cref="ExportBaselineListRequest"/></param>
        /// <returns><see cref="ExportBaselineListResponse"/></returns>
        public ExportBaselineListResponse ExportBaselineListSync(ExportBaselineListRequest req)
        {
            return InternalRequestAsync<ExportBaselineListResponse>(req, "ExportBaselineList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export high-risk command events.
        /// </summary>
        /// <param name="req"><see cref="ExportBashEventsRequest"/></param>
        /// <returns><see cref="ExportBashEventsResponse"/></returns>
        public Task<ExportBashEventsResponse> ExportBashEvents(ExportBashEventsRequest req)
        {
            return InternalRequestAsync<ExportBashEventsResponse>(req, "ExportBashEvents");
        }

        /// <summary>
        /// This API is used to export high-risk command events.
        /// </summary>
        /// <param name="req"><see cref="ExportBashEventsRequest"/></param>
        /// <returns><see cref="ExportBashEventsResponse"/></returns>
        public ExportBashEventsResponse ExportBashEventsSync(ExportBashEventsRequest req)
        {
            return InternalRequestAsync<ExportBashEventsResponse>(req, "ExportBashEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export high-risk command events (new).
        /// </summary>
        /// <param name="req"><see cref="ExportBashEventsNewRequest"/></param>
        /// <returns><see cref="ExportBashEventsNewResponse"/></returns>
        public Task<ExportBashEventsNewResponse> ExportBashEventsNew(ExportBashEventsNewRequest req)
        {
            return InternalRequestAsync<ExportBashEventsNewResponse>(req, "ExportBashEventsNew");
        }

        /// <summary>
        /// This API is used to export high-risk command events (new).
        /// </summary>
        /// <param name="req"><see cref="ExportBashEventsNewRequest"/></param>
        /// <returns><see cref="ExportBashEventsNewResponse"/></returns>
        public ExportBashEventsNewResponse ExportBashEventsNewSync(ExportBashEventsNewRequest req)
        {
            return InternalRequestAsync<ExportBashEventsNewResponse>(req, "ExportBashEventsNew")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the high-risk command policy.
        /// </summary>
        /// <param name="req"><see cref="ExportBashPoliciesRequest"/></param>
        /// <returns><see cref="ExportBashPoliciesResponse"/></returns>
        public Task<ExportBashPoliciesResponse> ExportBashPolicies(ExportBashPoliciesRequest req)
        {
            return InternalRequestAsync<ExportBashPoliciesResponse>(req, "ExportBashPolicies");
        }

        /// <summary>
        /// This API is used to export the high-risk command policy.
        /// </summary>
        /// <param name="req"><see cref="ExportBashPoliciesRequest"/></param>
        /// <returns><see cref="ExportBashPoliciesResponse"/></returns>
        public ExportBashPoliciesResponse ExportBashPoliciesSync(ExportBashPoliciesRequest req)
        {
            return InternalRequestAsync<ExportBashPoliciesResponse>(req, "ExportBashPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export password cracking records to a CSV file.
        /// </summary>
        /// <param name="req"><see cref="ExportBruteAttacksRequest"/></param>
        /// <returns><see cref="ExportBruteAttacksResponse"/></returns>
        public Task<ExportBruteAttacksResponse> ExportBruteAttacks(ExportBruteAttacksRequest req)
        {
            return InternalRequestAsync<ExportBruteAttacksResponse>(req, "ExportBruteAttacks");
        }

        /// <summary>
        /// This API is used to export password cracking records to a CSV file.
        /// </summary>
        /// <param name="req"><see cref="ExportBruteAttacksRequest"/></param>
        /// <returns><see cref="ExportBruteAttacksResponse"/></returns>
        public ExportBruteAttacksResponse ExportBruteAttacksSync(ExportBruteAttacksRequest req)
        {
            return InternalRequestAsync<ExportBruteAttacksResponse>(req, "ExportBruteAttacks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export core file events.
        /// </summary>
        /// <param name="req"><see cref="ExportFileTamperEventsRequest"/></param>
        /// <returns><see cref="ExportFileTamperEventsResponse"/></returns>
        public Task<ExportFileTamperEventsResponse> ExportFileTamperEvents(ExportFileTamperEventsRequest req)
        {
            return InternalRequestAsync<ExportFileTamperEventsResponse>(req, "ExportFileTamperEvents");
        }

        /// <summary>
        /// This API is used to export core file events.
        /// </summary>
        /// <param name="req"><see cref="ExportFileTamperEventsRequest"/></param>
        /// <returns><see cref="ExportFileTamperEventsResponse"/></returns>
        public ExportFileTamperEventsResponse ExportFileTamperEventsSync(ExportFileTamperEventsRequest req)
        {
            return InternalRequestAsync<ExportFileTamperEventsResponse>(req, "ExportFileTamperEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export core file monitoring rules.
        /// </summary>
        /// <param name="req"><see cref="ExportFileTamperRulesRequest"/></param>
        /// <returns><see cref="ExportFileTamperRulesResponse"/></returns>
        public Task<ExportFileTamperRulesResponse> ExportFileTamperRules(ExportFileTamperRulesRequest req)
        {
            return InternalRequestAsync<ExportFileTamperRulesResponse>(req, "ExportFileTamperRules");
        }

        /// <summary>
        /// This API is used to export core file monitoring rules.
        /// </summary>
        /// <param name="req"><see cref="ExportFileTamperRulesRequest"/></param>
        /// <returns><see cref="ExportFileTamperRulesResponse"/></returns>
        public ExportFileTamperRulesResponse ExportFileTamperRulesSync(ExportFileTamperRulesRequest req)
        {
            return InternalRequestAsync<ExportFileTamperRulesResponse>(req, "ExportFileTamperRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export information of ignored baseline detection items.
        /// </summary>
        /// <param name="req"><see cref="ExportIgnoreBaselineRuleRequest"/></param>
        /// <returns><see cref="ExportIgnoreBaselineRuleResponse"/></returns>
        public Task<ExportIgnoreBaselineRuleResponse> ExportIgnoreBaselineRule(ExportIgnoreBaselineRuleRequest req)
        {
            return InternalRequestAsync<ExportIgnoreBaselineRuleResponse>(req, "ExportIgnoreBaselineRule");
        }

        /// <summary>
        /// This API is used to export information of ignored baseline detection items.
        /// </summary>
        /// <param name="req"><see cref="ExportIgnoreBaselineRuleRequest"/></param>
        /// <returns><see cref="ExportIgnoreBaselineRuleResponse"/></returns>
        public ExportIgnoreBaselineRuleResponse ExportIgnoreBaselineRuleSync(ExportIgnoreBaselineRuleRequest req)
        {
            return InternalRequestAsync<ExportIgnoreBaselineRuleResponse>(req, "ExportIgnoreBaselineRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the list of hosts affected by ignored detection items based on detection item IDs.
        /// </summary>
        /// <param name="req"><see cref="ExportIgnoreRuleEffectHostListRequest"/></param>
        /// <returns><see cref="ExportIgnoreRuleEffectHostListResponse"/></returns>
        public Task<ExportIgnoreRuleEffectHostListResponse> ExportIgnoreRuleEffectHostList(ExportIgnoreRuleEffectHostListRequest req)
        {
            return InternalRequestAsync<ExportIgnoreRuleEffectHostListResponse>(req, "ExportIgnoreRuleEffectHostList");
        }

        /// <summary>
        /// This API is used to export the list of hosts affected by ignored detection items based on detection item IDs.
        /// </summary>
        /// <param name="req"><see cref="ExportIgnoreRuleEffectHostListRequest"/></param>
        /// <returns><see cref="ExportIgnoreRuleEffectHostListResponse"/></returns>
        public ExportIgnoreRuleEffectHostListResponse ExportIgnoreRuleEffectHostListSync(ExportIgnoreRuleEffectHostListRequest req)
        {
            return InternalRequestAsync<ExportIgnoreRuleEffectHostListResponse>(req, "ExportIgnoreRuleEffectHostList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the Java webshell plugin information.
        /// </summary>
        /// <param name="req"><see cref="ExportJavaMemShellPluginsRequest"/></param>
        /// <returns><see cref="ExportJavaMemShellPluginsResponse"/></returns>
        public Task<ExportJavaMemShellPluginsResponse> ExportJavaMemShellPlugins(ExportJavaMemShellPluginsRequest req)
        {
            return InternalRequestAsync<ExportJavaMemShellPluginsResponse>(req, "ExportJavaMemShellPlugins");
        }

        /// <summary>
        /// This API is used to export the Java webshell plugin information.
        /// </summary>
        /// <param name="req"><see cref="ExportJavaMemShellPluginsRequest"/></param>
        /// <returns><see cref="ExportJavaMemShellPluginsResponse"/></returns>
        public ExportJavaMemShellPluginsResponse ExportJavaMemShellPluginsSync(ExportJavaMemShellPluginsRequest req)
        {
            return InternalRequestAsync<ExportJavaMemShellPluginsResponse>(req, "ExportJavaMemShellPlugins")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the list of Java webshell events.
        /// </summary>
        /// <param name="req"><see cref="ExportJavaMemShellsRequest"/></param>
        /// <returns><see cref="ExportJavaMemShellsResponse"/></returns>
        public Task<ExportJavaMemShellsResponse> ExportJavaMemShells(ExportJavaMemShellsRequest req)
        {
            return InternalRequestAsync<ExportJavaMemShellsResponse>(req, "ExportJavaMemShells");
        }

        /// <summary>
        /// This API is used to export the list of Java webshell events.
        /// </summary>
        /// <param name="req"><see cref="ExportJavaMemShellsRequest"/></param>
        /// <returns><see cref="ExportJavaMemShellsResponse"/></returns>
        public ExportJavaMemShellsResponse ExportJavaMemShellsSync(ExportJavaMemShellsRequest req)
        {
            return InternalRequestAsync<ExportJavaMemShellsResponse>(req, "ExportJavaMemShells")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export authorization details.
        /// </summary>
        /// <param name="req"><see cref="ExportLicenseDetailRequest"/></param>
        /// <returns><see cref="ExportLicenseDetailResponse"/></returns>
        public Task<ExportLicenseDetailResponse> ExportLicenseDetail(ExportLicenseDetailRequest req)
        {
            return InternalRequestAsync<ExportLicenseDetailResponse>(req, "ExportLicenseDetail");
        }

        /// <summary>
        /// This API is used to export authorization details.
        /// </summary>
        /// <param name="req"><see cref="ExportLicenseDetailRequest"/></param>
        /// <returns><see cref="ExportLicenseDetailResponse"/></returns>
        public ExportLicenseDetailResponse ExportLicenseDetailSync(ExportLicenseDetailRequest req)
        {
            return InternalRequestAsync<ExportLicenseDetailResponse>(req, "ExportLicenseDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the downloaded malicious request files.
        /// </summary>
        /// <param name="req"><see cref="ExportMaliciousRequestsRequest"/></param>
        /// <returns><see cref="ExportMaliciousRequestsResponse"/></returns>
        public Task<ExportMaliciousRequestsResponse> ExportMaliciousRequests(ExportMaliciousRequestsRequest req)
        {
            return InternalRequestAsync<ExportMaliciousRequestsResponse>(req, "ExportMaliciousRequests");
        }

        /// <summary>
        /// This API is used to export the downloaded malicious request files.
        /// </summary>
        /// <param name="req"><see cref="ExportMaliciousRequestsRequest"/></param>
        /// <returns><see cref="ExportMaliciousRequestsResponse"/></returns>
        public ExportMaliciousRequestsResponse ExportMaliciousRequestsSync(ExportMaliciousRequestsRequest req)
        {
            return InternalRequestAsync<ExportMaliciousRequestsResponse>(req, "ExportMaliciousRequests")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export Trojan records to a CSV file.
        /// </summary>
        /// <param name="req"><see cref="ExportMalwaresRequest"/></param>
        /// <returns><see cref="ExportMalwaresResponse"/></returns>
        public Task<ExportMalwaresResponse> ExportMalwares(ExportMalwaresRequest req)
        {
            return InternalRequestAsync<ExportMalwaresResponse>(req, "ExportMalwares");
        }

        /// <summary>
        /// This API is used to export Trojan records to a CSV file.
        /// </summary>
        /// <param name="req"><see cref="ExportMalwaresRequest"/></param>
        /// <returns><see cref="ExportMalwaresResponse"/></returns>
        public ExportMalwaresResponse ExportMalwaresSync(ExportMalwaresRequest req)
        {
            return InternalRequestAsync<ExportMalwaresResponse>(req, "ExportMalwares")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export cross-region log-in event records in CSV format.
        /// </summary>
        /// <param name="req"><see cref="ExportNonlocalLoginPlacesRequest"/></param>
        /// <returns><see cref="ExportNonlocalLoginPlacesResponse"/></returns>
        public Task<ExportNonlocalLoginPlacesResponse> ExportNonlocalLoginPlaces(ExportNonlocalLoginPlacesRequest req)
        {
            return InternalRequestAsync<ExportNonlocalLoginPlacesResponse>(req, "ExportNonlocalLoginPlaces");
        }

        /// <summary>
        /// This API is used to export cross-region log-in event records in CSV format.
        /// </summary>
        /// <param name="req"><see cref="ExportNonlocalLoginPlacesRequest"/></param>
        /// <returns><see cref="ExportNonlocalLoginPlacesResponse"/></returns>
        public ExportNonlocalLoginPlacesResponse ExportNonlocalLoginPlacesSync(ExportNonlocalLoginPlacesRequest req)
        {
            return InternalRequestAsync<ExportNonlocalLoginPlacesResponse>(req, "ExportNonlocalLoginPlaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export local privilege escalation events.
        /// </summary>
        /// <param name="req"><see cref="ExportPrivilegeEventsRequest"/></param>
        /// <returns><see cref="ExportPrivilegeEventsResponse"/></returns>
        public Task<ExportPrivilegeEventsResponse> ExportPrivilegeEvents(ExportPrivilegeEventsRequest req)
        {
            return InternalRequestAsync<ExportPrivilegeEventsResponse>(req, "ExportPrivilegeEvents");
        }

        /// <summary>
        /// This API is used to export local privilege escalation events.
        /// </summary>
        /// <param name="req"><see cref="ExportPrivilegeEventsRequest"/></param>
        /// <returns><see cref="ExportPrivilegeEventsResponse"/></returns>
        public ExportPrivilegeEventsResponse ExportPrivilegeEventsSync(ExportPrivilegeEventsRequest req)
        {
            return InternalRequestAsync<ExportPrivilegeEventsResponse>(req, "ExportPrivilegeEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the list of host snapshot backups.
        /// </summary>
        /// <param name="req"><see cref="ExportRansomDefenseBackupListRequest"/></param>
        /// <returns><see cref="ExportRansomDefenseBackupListResponse"/></returns>
        public Task<ExportRansomDefenseBackupListResponse> ExportRansomDefenseBackupList(ExportRansomDefenseBackupListRequest req)
        {
            return InternalRequestAsync<ExportRansomDefenseBackupListResponse>(req, "ExportRansomDefenseBackupList");
        }

        /// <summary>
        /// This API is used to export the list of host snapshot backups.
        /// </summary>
        /// <param name="req"><see cref="ExportRansomDefenseBackupListRequest"/></param>
        /// <returns><see cref="ExportRansomDefenseBackupListResponse"/></returns>
        public ExportRansomDefenseBackupListResponse ExportRansomDefenseBackupListSync(ExportRansomDefenseBackupListRequest req)
        {
            return InternalRequestAsync<ExportRansomDefenseBackupListResponse>(req, "ExportRansomDefenseBackupList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the list of anti-ransomware events.
        /// </summary>
        /// <param name="req"><see cref="ExportRansomDefenseEventsListRequest"/></param>
        /// <returns><see cref="ExportRansomDefenseEventsListResponse"/></returns>
        public Task<ExportRansomDefenseEventsListResponse> ExportRansomDefenseEventsList(ExportRansomDefenseEventsListRequest req)
        {
            return InternalRequestAsync<ExportRansomDefenseEventsListResponse>(req, "ExportRansomDefenseEventsList");
        }

        /// <summary>
        /// This API is used to export the list of anti-ransomware events.
        /// </summary>
        /// <param name="req"><see cref="ExportRansomDefenseEventsListRequest"/></param>
        /// <returns><see cref="ExportRansomDefenseEventsListResponse"/></returns>
        public ExportRansomDefenseEventsListResponse ExportRansomDefenseEventsListSync(ExportRansomDefenseEventsListRequest req)
        {
            return InternalRequestAsync<ExportRansomDefenseEventsListResponse>(req, "ExportRansomDefenseEventsList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the backup details list.
        /// </summary>
        /// <param name="req"><see cref="ExportRansomDefenseMachineListRequest"/></param>
        /// <returns><see cref="ExportRansomDefenseMachineListResponse"/></returns>
        public Task<ExportRansomDefenseMachineListResponse> ExportRansomDefenseMachineList(ExportRansomDefenseMachineListRequest req)
        {
            return InternalRequestAsync<ExportRansomDefenseMachineListResponse>(req, "ExportRansomDefenseMachineList");
        }

        /// <summary>
        /// This API is used to export the backup details list.
        /// </summary>
        /// <param name="req"><see cref="ExportRansomDefenseMachineListRequest"/></param>
        /// <returns><see cref="ExportRansomDefenseMachineListResponse"/></returns>
        public ExportRansomDefenseMachineListResponse ExportRansomDefenseMachineListSync(ExportRansomDefenseMachineListRequest req)
        {
            return InternalRequestAsync<ExportRansomDefenseMachineListResponse>(req, "ExportRansomDefenseMachineList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the anti-ransomware policy list.
        /// </summary>
        /// <param name="req"><see cref="ExportRansomDefenseStrategyListRequest"/></param>
        /// <returns><see cref="ExportRansomDefenseStrategyListResponse"/></returns>
        public Task<ExportRansomDefenseStrategyListResponse> ExportRansomDefenseStrategyList(ExportRansomDefenseStrategyListRequest req)
        {
            return InternalRequestAsync<ExportRansomDefenseStrategyListResponse>(req, "ExportRansomDefenseStrategyList");
        }

        /// <summary>
        /// This API is used to export the anti-ransomware policy list.
        /// </summary>
        /// <param name="req"><see cref="ExportRansomDefenseStrategyListRequest"/></param>
        /// <returns><see cref="ExportRansomDefenseStrategyListResponse"/></returns>
        public ExportRansomDefenseStrategyListResponse ExportRansomDefenseStrategyListSync(ExportRansomDefenseStrategyListRequest req)
        {
            return InternalRequestAsync<ExportRansomDefenseStrategyListResponse>(req, "ExportRansomDefenseStrategyList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the list of machines bound to ransomware defense policies.
        /// </summary>
        /// <param name="req"><see cref="ExportRansomDefenseStrategyMachinesRequest"/></param>
        /// <returns><see cref="ExportRansomDefenseStrategyMachinesResponse"/></returns>
        public Task<ExportRansomDefenseStrategyMachinesResponse> ExportRansomDefenseStrategyMachines(ExportRansomDefenseStrategyMachinesRequest req)
        {
            return InternalRequestAsync<ExportRansomDefenseStrategyMachinesResponse>(req, "ExportRansomDefenseStrategyMachines");
        }

        /// <summary>
        /// This API is used to export the list of machines bound to ransomware defense policies.
        /// </summary>
        /// <param name="req"><see cref="ExportRansomDefenseStrategyMachinesRequest"/></param>
        /// <returns><see cref="ExportRansomDefenseStrategyMachinesResponse"/></returns>
        public ExportRansomDefenseStrategyMachinesResponse ExportRansomDefenseStrategyMachinesSync(ExportRansomDefenseStrategyMachinesRequest req)
        {
            return InternalRequestAsync<ExportRansomDefenseStrategyMachinesResponse>(req, "ExportRansomDefenseStrategyMachines")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export reverse shell events.
        /// </summary>
        /// <param name="req"><see cref="ExportReverseShellEventsRequest"/></param>
        /// <returns><see cref="ExportReverseShellEventsResponse"/></returns>
        public Task<ExportReverseShellEventsResponse> ExportReverseShellEvents(ExportReverseShellEventsRequest req)
        {
            return InternalRequestAsync<ExportReverseShellEventsResponse>(req, "ExportReverseShellEvents");
        }

        /// <summary>
        /// This API is used to export reverse shell events.
        /// </summary>
        /// <param name="req"><see cref="ExportReverseShellEventsRequest"/></param>
        /// <returns><see cref="ExportReverseShellEventsResponse"/></returns>
        public ExportReverseShellEventsResponse ExportReverseShellEventsSync(ExportReverseShellEventsRequest req)
        {
            return InternalRequestAsync<ExportReverseShellEventsResponse>(req, "ExportReverseShellEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the malicious request event list.
        /// </summary>
        /// <param name="req"><see cref="ExportRiskDnsEventListRequest"/></param>
        /// <returns><see cref="ExportRiskDnsEventListResponse"/></returns>
        public Task<ExportRiskDnsEventListResponse> ExportRiskDnsEventList(ExportRiskDnsEventListRequest req)
        {
            return InternalRequestAsync<ExportRiskDnsEventListResponse>(req, "ExportRiskDnsEventList");
        }

        /// <summary>
        /// This API is used to export the malicious request event list.
        /// </summary>
        /// <param name="req"><see cref="ExportRiskDnsEventListRequest"/></param>
        /// <returns><see cref="ExportRiskDnsEventListResponse"/></returns>
        public ExportRiskDnsEventListResponse ExportRiskDnsEventListSync(ExportRiskDnsEventListRequest req)
        {
            return InternalRequestAsync<ExportRiskDnsEventListResponse>(req, "ExportRiskDnsEventList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the malicious request policy list.
        /// </summary>
        /// <param name="req"><see cref="ExportRiskDnsPolicyListRequest"/></param>
        /// <returns><see cref="ExportRiskDnsPolicyListResponse"/></returns>
        public Task<ExportRiskDnsPolicyListResponse> ExportRiskDnsPolicyList(ExportRiskDnsPolicyListRequest req)
        {
            return InternalRequestAsync<ExportRiskDnsPolicyListResponse>(req, "ExportRiskDnsPolicyList");
        }

        /// <summary>
        /// This API is used to export the malicious request policy list.
        /// </summary>
        /// <param name="req"><see cref="ExportRiskDnsPolicyListRequest"/></param>
        /// <returns><see cref="ExportRiskDnsPolicyListResponse"/></returns>
        public ExportRiskDnsPolicyListResponse ExportRiskDnsPolicyListSync(ExportRiskDnsPolicyListRequest req)
        {
            return InternalRequestAsync<ExportRiskDnsPolicyListResponse>(req, "ExportRiskDnsPolicyList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export abnormal process events.
        /// </summary>
        /// <param name="req"><see cref="ExportRiskProcessEventsRequest"/></param>
        /// <returns><see cref="ExportRiskProcessEventsResponse"/></returns>
        public Task<ExportRiskProcessEventsResponse> ExportRiskProcessEvents(ExportRiskProcessEventsRequest req)
        {
            return InternalRequestAsync<ExportRiskProcessEventsResponse>(req, "ExportRiskProcessEvents");
        }

        /// <summary>
        /// This API is used to export abnormal process events.
        /// </summary>
        /// <param name="req"><see cref="ExportRiskProcessEventsRequest"/></param>
        /// <returns><see cref="ExportRiskProcessEventsResponse"/></returns>
        public ExportRiskProcessEventsResponse ExportRiskProcessEventsSync(ExportRiskProcessEventsRequest req)
        {
            return InternalRequestAsync<ExportRiskProcessEventsResponse>(req, "ExportRiskProcessEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the specified scan task details by task ID.
        /// </summary>
        /// <param name="req"><see cref="ExportScanTaskDetailsRequest"/></param>
        /// <returns><see cref="ExportScanTaskDetailsResponse"/></returns>
        public Task<ExportScanTaskDetailsResponse> ExportScanTaskDetails(ExportScanTaskDetailsRequest req)
        {
            return InternalRequestAsync<ExportScanTaskDetailsResponse>(req, "ExportScanTaskDetails");
        }

        /// <summary>
        /// This API is used to export the specified scan task details by task ID.
        /// </summary>
        /// <param name="req"><see cref="ExportScanTaskDetailsRequest"/></param>
        /// <returns><see cref="ExportScanTaskDetailsResponse"/></returns>
        public ExportScanTaskDetailsResponse ExportScanTaskDetailsSync(ExportScanTaskDetailsRequest req)
        {
            return InternalRequestAsync<ExportScanTaskDetailsResponse>(req, "ExportScanTaskDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export risk trends.
        /// </summary>
        /// <param name="req"><see cref="ExportSecurityTrendsRequest"/></param>
        /// <returns><see cref="ExportSecurityTrendsResponse"/></returns>
        public Task<ExportSecurityTrendsResponse> ExportSecurityTrends(ExportSecurityTrendsRequest req)
        {
            return InternalRequestAsync<ExportSecurityTrendsResponse>(req, "ExportSecurityTrends");
        }

        /// <summary>
        /// This API is used to export risk trends.
        /// </summary>
        /// <param name="req"><see cref="ExportSecurityTrendsRequest"/></param>
        /// <returns><see cref="ExportSecurityTrendsResponse"/></returns>
        public ExportSecurityTrendsResponse ExportSecurityTrendsSync(ExportSecurityTrendsRequest req)
        {
            return InternalRequestAsync<ExportSecurityTrendsResponse>(req, "ExportSecurityTrends")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export log files with large data volumes asynchronously.
        /// </summary>
        /// <param name="req"><see cref="ExportTasksRequest"/></param>
        /// <returns><see cref="ExportTasksResponse"/></returns>
        public Task<ExportTasksResponse> ExportTasks(ExportTasksRequest req)
        {
            return InternalRequestAsync<ExportTasksResponse>(req, "ExportTasks");
        }

        /// <summary>
        /// This API is used to export log files with large data volumes asynchronously.
        /// </summary>
        /// <param name="req"><see cref="ExportTasksRequest"/></param>
        /// <returns><see cref="ExportTasksResponse"/></returns>
        public ExportTasksResponse ExportTasksSync(ExportTasksRequest req)
        {
            return InternalRequestAsync<ExportTasksResponse>(req, "ExportTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export vulnerability defense events.
        /// </summary>
        /// <param name="req"><see cref="ExportVulDefenceEventRequest"/></param>
        /// <returns><see cref="ExportVulDefenceEventResponse"/></returns>
        public Task<ExportVulDefenceEventResponse> ExportVulDefenceEvent(ExportVulDefenceEventRequest req)
        {
            return InternalRequestAsync<ExportVulDefenceEventResponse>(req, "ExportVulDefenceEvent");
        }

        /// <summary>
        /// This API is used to export vulnerability defense events.
        /// </summary>
        /// <param name="req"><see cref="ExportVulDefenceEventRequest"/></param>
        /// <returns><see cref="ExportVulDefenceEventResponse"/></returns>
        public ExportVulDefenceEventResponse ExportVulDefenceEventSync(ExportVulDefenceEventRequest req)
        {
            return InternalRequestAsync<ExportVulDefenceEventResponse>(req, "ExportVulDefenceEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the list of vulnerability defenses.
        /// </summary>
        /// <param name="req"><see cref="ExportVulDefenceListRequest"/></param>
        /// <returns><see cref="ExportVulDefenceListResponse"/></returns>
        public Task<ExportVulDefenceListResponse> ExportVulDefenceList(ExportVulDefenceListRequest req)
        {
            return InternalRequestAsync<ExportVulDefenceListResponse>(req, "ExportVulDefenceList");
        }

        /// <summary>
        /// This API is used to export the list of vulnerability defenses.
        /// </summary>
        /// <param name="req"><see cref="ExportVulDefenceListRequest"/></param>
        /// <returns><see cref="ExportVulDefenceListResponse"/></returns>
        public ExportVulDefenceListResponse ExportVulDefenceListSync(ExportVulDefenceListRequest req)
        {
            return InternalRequestAsync<ExportVulDefenceListResponse>(req, "ExportVulDefenceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export vulnerability defense plugin events.
        /// </summary>
        /// <param name="req"><see cref="ExportVulDefencePluginEventRequest"/></param>
        /// <returns><see cref="ExportVulDefencePluginEventResponse"/></returns>
        public Task<ExportVulDefencePluginEventResponse> ExportVulDefencePluginEvent(ExportVulDefencePluginEventRequest req)
        {
            return InternalRequestAsync<ExportVulDefencePluginEventResponse>(req, "ExportVulDefencePluginEvent");
        }

        /// <summary>
        /// This API is used to export vulnerability defense plugin events.
        /// </summary>
        /// <param name="req"><see cref="ExportVulDefencePluginEventRequest"/></param>
        /// <returns><see cref="ExportVulDefencePluginEventResponse"/></returns>
        public ExportVulDefencePluginEventResponse ExportVulDefencePluginEventSync(ExportVulDefencePluginEventRequest req)
        {
            return InternalRequestAsync<ExportVulDefencePluginEventResponse>(req, "ExportVulDefencePluginEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the vulnerability detection Excel document.
        /// </summary>
        /// <param name="req"><see cref="ExportVulDetectionExcelRequest"/></param>
        /// <returns><see cref="ExportVulDetectionExcelResponse"/></returns>
        public Task<ExportVulDetectionExcelResponse> ExportVulDetectionExcel(ExportVulDetectionExcelRequest req)
        {
            return InternalRequestAsync<ExportVulDetectionExcelResponse>(req, "ExportVulDetectionExcel");
        }

        /// <summary>
        /// This API is used to export the vulnerability detection Excel document.
        /// </summary>
        /// <param name="req"><see cref="ExportVulDetectionExcelRequest"/></param>
        /// <returns><see cref="ExportVulDetectionExcelResponse"/></returns>
        public ExportVulDetectionExcelResponse ExportVulDetectionExcelSync(ExportVulDetectionExcelRequest req)
        {
            return InternalRequestAsync<ExportVulDetectionExcelResponse>(req, "ExportVulDetectionExcel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the vulnerability detection report.
        /// </summary>
        /// <param name="req"><see cref="ExportVulDetectionReportRequest"/></param>
        /// <returns><see cref="ExportVulDetectionReportResponse"/></returns>
        public Task<ExportVulDetectionReportResponse> ExportVulDetectionReport(ExportVulDetectionReportRequest req)
        {
            return InternalRequestAsync<ExportVulDetectionReportResponse>(req, "ExportVulDetectionReport");
        }

        /// <summary>
        /// This API is used to export the vulnerability detection report.
        /// </summary>
        /// <param name="req"><see cref="ExportVulDetectionReportRequest"/></param>
        /// <returns><see cref="ExportVulDetectionReportResponse"/></returns>
        public ExportVulDetectionReportResponse ExportVulDetectionReportSync(ExportVulDetectionReportRequest req)
        {
            return InternalRequestAsync<ExportVulDetectionReportResponse>(req, "ExportVulDetectionReport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the list of hosts affected by vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="ExportVulEffectHostListRequest"/></param>
        /// <returns><see cref="ExportVulEffectHostListResponse"/></returns>
        public Task<ExportVulEffectHostListResponse> ExportVulEffectHostList(ExportVulEffectHostListRequest req)
        {
            return InternalRequestAsync<ExportVulEffectHostListResponse>(req, "ExportVulEffectHostList");
        }

        /// <summary>
        /// This API is used to export the list of hosts affected by vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="ExportVulEffectHostListRequest"/></param>
        /// <returns><see cref="ExportVulEffectHostListResponse"/></returns>
        public ExportVulEffectHostListResponse ExportVulEffectHostListSync(ExportVulEffectHostListRequest req)
        {
            return InternalRequestAsync<ExportVulEffectHostListResponse>(req, "ExportVulEffectHostList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the vulnerability information, including the list of affected hosts and component information.
        /// </summary>
        /// <param name="req"><see cref="ExportVulInfoRequest"/></param>
        /// <returns><see cref="ExportVulInfoResponse"/></returns>
        public Task<ExportVulInfoResponse> ExportVulInfo(ExportVulInfoRequest req)
        {
            return InternalRequestAsync<ExportVulInfoResponse>(req, "ExportVulInfo");
        }

        /// <summary>
        /// This API is used to export the vulnerability information, including the list of affected hosts and component information.
        /// </summary>
        /// <param name="req"><see cref="ExportVulInfoRequest"/></param>
        /// <returns><see cref="ExportVulInfoResponse"/></returns>
        public ExportVulInfoResponse ExportVulInfoSync(ExportVulInfoRequest req)
        {
            return InternalRequestAsync<ExportVulInfoResponse>(req, "ExportVulInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the vulnerability list.
        /// </summary>
        /// <param name="req"><see cref="ExportVulListRequest"/></param>
        /// <returns><see cref="ExportVulListResponse"/></returns>
        public Task<ExportVulListResponse> ExportVulList(ExportVulListRequest req)
        {
            return InternalRequestAsync<ExportVulListResponse>(req, "ExportVulList");
        }

        /// <summary>
        /// This API is used to export the vulnerability list.
        /// </summary>
        /// <param name="req"><see cref="ExportVulListRequest"/></param>
        /// <returns><see cref="ExportVulListResponse"/></returns>
        public ExportVulListResponse ExportVulListSync(ExportVulListRequest req)
        {
            return InternalRequestAsync<ExportVulListResponse>(req, "ExportVulList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the locally stored data.
        /// </summary>
        /// <param name="req"><see cref="GetLocalStorageItemRequest"/></param>
        /// <returns><see cref="GetLocalStorageItemResponse"/></returns>
        public Task<GetLocalStorageItemResponse> GetLocalStorageItem(GetLocalStorageItemRequest req)
        {
            return InternalRequestAsync<GetLocalStorageItemResponse>(req, "GetLocalStorageItem");
        }

        /// <summary>
        /// This API is used to obtain the locally stored data.
        /// </summary>
        /// <param name="req"><see cref="GetLocalStorageItemRequest"/></param>
        /// <returns><see cref="GetLocalStorageItemResponse"/></returns>
        public GetLocalStorageItemResponse GetLocalStorageItemSync(GetLocalStorageItemRequest req)
        {
            return InternalRequestAsync<GetLocalStorageItemResponse>(req, "GetLocalStorageItem")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to ignore vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="IgnoreImpactedHostsRequest"/></param>
        /// <returns><see cref="IgnoreImpactedHostsResponse"/></returns>
        public Task<IgnoreImpactedHostsResponse> IgnoreImpactedHosts(IgnoreImpactedHostsRequest req)
        {
            return InternalRequestAsync<IgnoreImpactedHostsResponse>(req, "IgnoreImpactedHosts");
        }

        /// <summary>
        /// This API is used to ignore vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="IgnoreImpactedHostsRequest"/></param>
        /// <returns><see cref="IgnoreImpactedHostsResponse"/></returns>
        public IgnoreImpactedHostsResponse IgnoreImpactedHostsSync(IgnoreImpactedHostsRequest req)
        {
            return InternalRequestAsync<IgnoreImpactedHostsResponse>(req, "IgnoreImpactedHosts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of locally stored key values.
        /// </summary>
        /// <param name="req"><see cref="KeysLocalStorageRequest"/></param>
        /// <returns><see cref="KeysLocalStorageResponse"/></returns>
        public Task<KeysLocalStorageResponse> KeysLocalStorage(KeysLocalStorageRequest req)
        {
            return InternalRequestAsync<KeysLocalStorageResponse>(req, "KeysLocalStorage");
        }

        /// <summary>
        /// This API is used to obtain the list of locally stored key values.
        /// </summary>
        /// <param name="req"><see cref="KeysLocalStorageRequest"/></param>
        /// <returns><see cref="KeysLocalStorageResponse"/></returns>
        public KeysLocalStorageResponse KeysLocalStorageSync(KeysLocalStorageRequest req)
        {
            return InternalRequestAsync<KeysLocalStorageResponse>(req, "KeysLocalStorage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable the configuration of automatically enabling the professional protection configuration for newly added hosts.
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoOpenProVersionConfigRequest"/></param>
        /// <returns><see cref="ModifyAutoOpenProVersionConfigResponse"/></returns>
        public Task<ModifyAutoOpenProVersionConfigResponse> ModifyAutoOpenProVersionConfig(ModifyAutoOpenProVersionConfigRequest req)
        {
            return InternalRequestAsync<ModifyAutoOpenProVersionConfigResponse>(req, "ModifyAutoOpenProVersionConfig");
        }

        /// <summary>
        /// This API is used to enable the configuration of automatically enabling the professional protection configuration for newly added hosts.
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoOpenProVersionConfigRequest"/></param>
        /// <returns><see cref="ModifyAutoOpenProVersionConfigResponse"/></returns>
        public ModifyAutoOpenProVersionConfigResponse ModifyAutoOpenProVersionConfigSync(ModifyAutoOpenProVersionConfigRequest req)
        {
            return InternalRequestAsync<ModifyAutoOpenProVersionConfigResponse>(req, "ModifyAutoOpenProVersionConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the brute-force blocking mode.
        /// </summary>
        /// <param name="req"><see cref="ModifyBanModeRequest"/></param>
        /// <returns><see cref="ModifyBanModeResponse"/></returns>
        public Task<ModifyBanModeResponse> ModifyBanMode(ModifyBanModeRequest req)
        {
            return InternalRequestAsync<ModifyBanModeResponse>(req, "ModifyBanMode");
        }

        /// <summary>
        /// This API is used to modify the brute-force blocking mode.
        /// </summary>
        /// <param name="req"><see cref="ModifyBanModeRequest"/></param>
        /// <returns><see cref="ModifyBanModeResponse"/></returns>
        public ModifyBanModeResponse ModifyBanModeSync(ModifyBanModeRequest req)
        {
            return InternalRequestAsync<ModifyBanModeResponse>(req, "ModifyBanMode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set the block switch status.
        /// </summary>
        /// <param name="req"><see cref="ModifyBanStatusRequest"/></param>
        /// <returns><see cref="ModifyBanStatusResponse"/></returns>
        public Task<ModifyBanStatusResponse> ModifyBanStatus(ModifyBanStatusRequest req)
        {
            return InternalRequestAsync<ModifyBanStatusResponse>(req, "ModifyBanStatus");
        }

        /// <summary>
        /// This API is used to set the block switch status.
        /// </summary>
        /// <param name="req"><see cref="ModifyBanStatusRequest"/></param>
        /// <returns><see cref="ModifyBanStatusResponse"/></returns>
        public ModifyBanStatusResponse ModifyBanStatusSync(ModifyBanStatusRequest req)
        {
            return InternalRequestAsync<ModifyBanStatusResponse>(req, "ModifyBanStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the blocking allowlist.
        /// </summary>
        /// <param name="req"><see cref="ModifyBanWhiteListRequest"/></param>
        /// <returns><see cref="ModifyBanWhiteListResponse"/></returns>
        public Task<ModifyBanWhiteListResponse> ModifyBanWhiteList(ModifyBanWhiteListRequest req)
        {
            return InternalRequestAsync<ModifyBanWhiteListResponse>(req, "ModifyBanWhiteList");
        }

        /// <summary>
        /// This API is used to modify the blocking allowlist.
        /// </summary>
        /// <param name="req"><see cref="ModifyBanWhiteListRequest"/></param>
        /// <returns><see cref="ModifyBanWhiteListResponse"/></returns>
        public ModifyBanWhiteListResponse ModifyBanWhiteListSync(ModifyBanWhiteListRequest req)
        {
            return InternalRequestAsync<ModifyBanWhiteListResponse>(req, "ModifyBanWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to change the baseline policy settings.
        /// </summary>
        /// <param name="req"><see cref="ModifyBaselinePolicyRequest"/></param>
        /// <returns><see cref="ModifyBaselinePolicyResponse"/></returns>
        public Task<ModifyBaselinePolicyResponse> ModifyBaselinePolicy(ModifyBaselinePolicyRequest req)
        {
            return InternalRequestAsync<ModifyBaselinePolicyResponse>(req, "ModifyBaselinePolicy");
        }

        /// <summary>
        /// This API is used to change the baseline policy settings.
        /// </summary>
        /// <param name="req"><see cref="ModifyBaselinePolicyRequest"/></param>
        /// <returns><see cref="ModifyBaselinePolicyResponse"/></returns>
        public ModifyBaselinePolicyResponse ModifyBaselinePolicySync(ModifyBaselinePolicyRequest req)
        {
            return InternalRequestAsync<ModifyBaselinePolicyResponse>(req, "ModifyBaselinePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add or modify high-risk command policies.
        /// </summary>
        /// <param name="req"><see cref="ModifyBashPolicyRequest"/></param>
        /// <returns><see cref="ModifyBashPolicyResponse"/></returns>
        public Task<ModifyBashPolicyResponse> ModifyBashPolicy(ModifyBashPolicyRequest req)
        {
            return InternalRequestAsync<ModifyBashPolicyResponse>(req, "ModifyBashPolicy");
        }

        /// <summary>
        /// This API is used to add or modify high-risk command policies.
        /// </summary>
        /// <param name="req"><see cref="ModifyBashPolicyRequest"/></param>
        /// <returns><see cref="ModifyBashPolicyResponse"/></returns>
        public ModifyBashPolicyResponse ModifyBashPolicySync(ModifyBashPolicyRequest req)
        {
            return InternalRequestAsync<ModifyBashPolicyResponse>(req, "ModifyBashPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to switch the statuses of high-risk command policies.
        /// </summary>
        /// <param name="req"><see cref="ModifyBashPolicyStatusRequest"/></param>
        /// <returns><see cref="ModifyBashPolicyStatusResponse"/></returns>
        public Task<ModifyBashPolicyStatusResponse> ModifyBashPolicyStatus(ModifyBashPolicyStatusRequest req)
        {
            return InternalRequestAsync<ModifyBashPolicyStatusResponse>(req, "ModifyBashPolicyStatus");
        }

        /// <summary>
        /// This API is used to switch the statuses of high-risk command policies.
        /// </summary>
        /// <param name="req"><see cref="ModifyBashPolicyStatusRequest"/></param>
        /// <returns><see cref="ModifyBashPolicyStatusResponse"/></returns>
        public ModifyBashPolicyStatusResponse ModifyBashPolicyStatusSync(ModifyBashPolicyStatusRequest req)
        {
            return InternalRequestAsync<ModifyBashPolicyStatusResponse>(req, "ModifyBashPolicyStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify brute force cracking rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyBruteAttackRulesRequest"/></param>
        /// <returns><see cref="ModifyBruteAttackRulesResponse"/></returns>
        public Task<ModifyBruteAttackRulesResponse> ModifyBruteAttackRules(ModifyBruteAttackRulesRequest req)
        {
            return InternalRequestAsync<ModifyBruteAttackRulesResponse>(req, "ModifyBruteAttackRules");
        }

        /// <summary>
        /// This API is used to modify brute force cracking rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyBruteAttackRulesRequest"/></param>
        /// <returns><see cref="ModifyBruteAttackRulesResponse"/></returns>
        public ModifyBruteAttackRulesResponse ModifyBruteAttackRulesSync(ModifyBruteAttackRulesRequest req)
        {
            return InternalRequestAsync<ModifyBruteAttackRulesResponse>(req, "ModifyBruteAttackRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the status of network attack events.
        /// </summary>
        /// <param name="req"><see cref="ModifyEventAttackStatusRequest"/></param>
        /// <returns><see cref="ModifyEventAttackStatusResponse"/></returns>
        public Task<ModifyEventAttackStatusResponse> ModifyEventAttackStatus(ModifyEventAttackStatusRequest req)
        {
            return InternalRequestAsync<ModifyEventAttackStatusResponse>(req, "ModifyEventAttackStatus");
        }

        /// <summary>
        /// This API is used to modify the status of network attack events.
        /// </summary>
        /// <param name="req"><see cref="ModifyEventAttackStatusRequest"/></param>
        /// <returns><see cref="ModifyEventAttackStatusResponse"/></returns>
        public ModifyEventAttackStatusResponse ModifyEventAttackStatusSync(ModifyEventAttackStatusRequest req)
        {
            return InternalRequestAsync<ModifyEventAttackStatusResponse>(req, "ModifyEventAttackStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the core file events.
        /// </summary>
        /// <param name="req"><see cref="ModifyFileTamperEventsRequest"/></param>
        /// <returns><see cref="ModifyFileTamperEventsResponse"/></returns>
        public Task<ModifyFileTamperEventsResponse> ModifyFileTamperEvents(ModifyFileTamperEventsRequest req)
        {
            return InternalRequestAsync<ModifyFileTamperEventsResponse>(req, "ModifyFileTamperEvents");
        }

        /// <summary>
        /// This API is used to update the core file events.
        /// </summary>
        /// <param name="req"><see cref="ModifyFileTamperEventsRequest"/></param>
        /// <returns><see cref="ModifyFileTamperEventsResponse"/></returns>
        public ModifyFileTamperEventsResponse ModifyFileTamperEventsSync(ModifyFileTamperEventsRequest req)
        {
            return InternalRequestAsync<ModifyFileTamperEventsResponse>(req, "ModifyFileTamperEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to edit and add core file monitoring rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyFileTamperRuleRequest"/></param>
        /// <returns><see cref="ModifyFileTamperRuleResponse"/></returns>
        public Task<ModifyFileTamperRuleResponse> ModifyFileTamperRule(ModifyFileTamperRuleRequest req)
        {
            return InternalRequestAsync<ModifyFileTamperRuleResponse>(req, "ModifyFileTamperRule");
        }

        /// <summary>
        /// This API is used to edit and add core file monitoring rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyFileTamperRuleRequest"/></param>
        /// <returns><see cref="ModifyFileTamperRuleResponse"/></returns>
        public ModifyFileTamperRuleResponse ModifyFileTamperRuleSync(ModifyFileTamperRuleRequest req)
        {
            return InternalRequestAsync<ModifyFileTamperRuleResponse>(req, "ModifyFileTamperRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the core file rule status (batch deletion and disabling supported).
        /// </summary>
        /// <param name="req"><see cref="ModifyFileTamperRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyFileTamperRuleStatusResponse"/></returns>
        public Task<ModifyFileTamperRuleStatusResponse> ModifyFileTamperRuleStatus(ModifyFileTamperRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyFileTamperRuleStatusResponse>(req, "ModifyFileTamperRuleStatus");
        }

        /// <summary>
        /// This API is used to update the core file rule status (batch deletion and disabling supported).
        /// </summary>
        /// <param name="req"><see cref="ModifyFileTamperRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyFileTamperRuleStatusResponse"/></returns>
        public ModifyFileTamperRuleStatusResponse ModifyFileTamperRuleStatusSync(ModifyFileTamperRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyFileTamperRuleStatusResponse>(req, "ModifyFileTamperRuleStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable and disable Java webshell plugins.
        /// </summary>
        /// <param name="req"><see cref="ModifyJavaMemShellPluginSwitchRequest"/></param>
        /// <returns><see cref="ModifyJavaMemShellPluginSwitchResponse"/></returns>
        public Task<ModifyJavaMemShellPluginSwitchResponse> ModifyJavaMemShellPluginSwitch(ModifyJavaMemShellPluginSwitchRequest req)
        {
            return InternalRequestAsync<ModifyJavaMemShellPluginSwitchResponse>(req, "ModifyJavaMemShellPluginSwitch");
        }

        /// <summary>
        /// This API is used to enable and disable Java webshell plugins.
        /// </summary>
        /// <param name="req"><see cref="ModifyJavaMemShellPluginSwitchRequest"/></param>
        /// <returns><see cref="ModifyJavaMemShellPluginSwitchResponse"/></returns>
        public ModifyJavaMemShellPluginSwitchResponse ModifyJavaMemShellPluginSwitchSync(ModifyJavaMemShellPluginSwitchRequest req)
        {
            return InternalRequestAsync<ModifyJavaMemShellPluginSwitchResponse>(req, "ModifyJavaMemShellPluginSwitch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the Java webshell event status.
        /// </summary>
        /// <param name="req"><see cref="ModifyJavaMemShellsStatusRequest"/></param>
        /// <returns><see cref="ModifyJavaMemShellsStatusResponse"/></returns>
        public Task<ModifyJavaMemShellsStatusResponse> ModifyJavaMemShellsStatus(ModifyJavaMemShellsStatusRequest req)
        {
            return InternalRequestAsync<ModifyJavaMemShellsStatusResponse>(req, "ModifyJavaMemShellsStatus");
        }

        /// <summary>
        /// This API is used to modify the Java webshell event status.
        /// </summary>
        /// <param name="req"><see cref="ModifyJavaMemShellsStatusRequest"/></param>
        /// <returns><see cref="ModifyJavaMemShellsStatusResponse"/></returns>
        public ModifyJavaMemShellsStatusResponse ModifyJavaMemShellsStatusSync(ModifyJavaMemShellsStatusRequest req)
        {
            return InternalRequestAsync<ModifyJavaMemShellsStatusResponse>(req, "ModifyJavaMemShellsStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bind machines to an authorization in batches.
        /// </summary>
        /// <param name="req"><see cref="ModifyLicenseBindsRequest"/></param>
        /// <returns><see cref="ModifyLicenseBindsResponse"/></returns>
        public Task<ModifyLicenseBindsResponse> ModifyLicenseBinds(ModifyLicenseBindsRequest req)
        {
            return InternalRequestAsync<ModifyLicenseBindsResponse>(req, "ModifyLicenseBinds");
        }

        /// <summary>
        /// This API is used to bind machines to an authorization in batches.
        /// </summary>
        /// <param name="req"><see cref="ModifyLicenseBindsRequest"/></param>
        /// <returns><see cref="ModifyLicenseBindsResponse"/></returns>
        public ModifyLicenseBindsResponse ModifyLicenseBindsSync(ModifyLicenseBindsRequest req)
        {
            return InternalRequestAsync<ModifyLicenseBindsResponse>(req, "ModifyLicenseBinds")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to edit CWPP - pay-as-you-go authorization orders.
        /// </summary>
        /// <param name="req"><see cref="ModifyLicenseOrderRequest"/></param>
        /// <returns><see cref="ModifyLicenseOrderResponse"/></returns>
        public Task<ModifyLicenseOrderResponse> ModifyLicenseOrder(ModifyLicenseOrderRequest req)
        {
            return InternalRequestAsync<ModifyLicenseOrderResponse>(req, "ModifyLicenseOrder");
        }

        /// <summary>
        /// This API is used to edit CWPP - pay-as-you-go authorization orders.
        /// </summary>
        /// <param name="req"><see cref="ModifyLicenseOrderRequest"/></param>
        /// <returns><see cref="ModifyLicenseOrderResponse"/></returns>
        public ModifyLicenseOrderResponse ModifyLicenseOrderSync(ModifyLicenseOrderRequest req)
        {
            return InternalRequestAsync<ModifyLicenseOrderResponse>(req, "ModifyLicenseOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add or modify the access configuration of logs shipped to Kafka.
        /// </summary>
        /// <param name="req"><see cref="ModifyLogKafkaAccessRequest"/></param>
        /// <returns><see cref="ModifyLogKafkaAccessResponse"/></returns>
        public Task<ModifyLogKafkaAccessResponse> ModifyLogKafkaAccess(ModifyLogKafkaAccessRequest req)
        {
            return InternalRequestAsync<ModifyLogKafkaAccessResponse>(req, "ModifyLogKafkaAccess");
        }

        /// <summary>
        /// This API is used to add or modify the access configuration of logs shipped to Kafka.
        /// </summary>
        /// <param name="req"><see cref="ModifyLogKafkaAccessRequest"/></param>
        /// <returns><see cref="ModifyLogKafkaAccessResponse"/></returns>
        public ModifyLogKafkaAccessResponse ModifyLogKafkaAccessSync(ModifyLogKafkaAccessRequest req)
        {
            return InternalRequestAsync<ModifyLogKafkaAccessResponse>(req, "ModifyLogKafkaAccess")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the shipping configuration and switch of the specified log category.
        /// </summary>
        /// <param name="req"><see cref="ModifyLogKafkaDeliverTypeRequest"/></param>
        /// <returns><see cref="ModifyLogKafkaDeliverTypeResponse"/></returns>
        public Task<ModifyLogKafkaDeliverTypeResponse> ModifyLogKafkaDeliverType(ModifyLogKafkaDeliverTypeRequest req)
        {
            return InternalRequestAsync<ModifyLogKafkaDeliverTypeResponse>(req, "ModifyLogKafkaDeliverType");
        }

        /// <summary>
        /// This API is used to modify the shipping configuration and switch of the specified log category.
        /// </summary>
        /// <param name="req"><see cref="ModifyLogKafkaDeliverTypeRequest"/></param>
        /// <returns><see cref="ModifyLogKafkaDeliverTypeResponse"/></returns>
        public ModifyLogKafkaDeliverTypeResponse ModifyLogKafkaDeliverTypeSync(ModifyLogKafkaDeliverTypeRequest req)
        {
            return InternalRequestAsync<ModifyLogKafkaDeliverTypeResponse>(req, "ModifyLogKafkaDeliverType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the information of log shipping statuses.
        /// </summary>
        /// <param name="req"><see cref="ModifyLogKafkaStateRequest"/></param>
        /// <returns><see cref="ModifyLogKafkaStateResponse"/></returns>
        public Task<ModifyLogKafkaStateResponse> ModifyLogKafkaState(ModifyLogKafkaStateRequest req)
        {
            return InternalRequestAsync<ModifyLogKafkaStateResponse>(req, "ModifyLogKafkaState");
        }

        /// <summary>
        /// This API is used to modify the information of log shipping statuses.
        /// </summary>
        /// <param name="req"><see cref="ModifyLogKafkaStateRequest"/></param>
        /// <returns><see cref="ModifyLogKafkaStateResponse"/></returns>
        public ModifyLogKafkaStateResponse ModifyLogKafkaStateSync(ModifyLogKafkaStateRequest req)
        {
            return InternalRequestAsync<ModifyLogKafkaStateResponse>(req, "ModifyLogKafkaState")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the log storage configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyLogStorageConfigRequest"/></param>
        /// <returns><see cref="ModifyLogStorageConfigResponse"/></returns>
        public Task<ModifyLogStorageConfigResponse> ModifyLogStorageConfig(ModifyLogStorageConfigRequest req)
        {
            return InternalRequestAsync<ModifyLogStorageConfigResponse>(req, "ModifyLogStorageConfig");
        }

        /// <summary>
        /// This API is used to modify the log storage configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyLogStorageConfigRequest"/></param>
        /// <returns><see cref="ModifyLogStorageConfigResponse"/></returns>
        public ModifyLogStorageConfigResponse ModifyLogStorageConfigSync(ModifyLogStorageConfigRequest req)
        {
            return InternalRequestAsync<ModifyLogStorageConfigResponse>(req, "ModifyLogStorageConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the log-in audit allowlist information.
        /// </summary>
        /// <param name="req"><see cref="ModifyLoginWhiteInfoRequest"/></param>
        /// <returns><see cref="ModifyLoginWhiteInfoResponse"/></returns>
        public Task<ModifyLoginWhiteInfoResponse> ModifyLoginWhiteInfo(ModifyLoginWhiteInfoRequest req)
        {
            return InternalRequestAsync<ModifyLoginWhiteInfoResponse>(req, "ModifyLoginWhiteInfo");
        }

        /// <summary>
        /// This API is used to update the log-in audit allowlist information.
        /// </summary>
        /// <param name="req"><see cref="ModifyLoginWhiteInfoRequest"/></param>
        /// <returns><see cref="ModifyLoginWhiteInfoResponse"/></returns>
        public ModifyLoginWhiteInfoResponse ModifyLoginWhiteInfoSync(ModifyLoginWhiteInfoRequest req)
        {
            return InternalRequestAsync<ModifyLoginWhiteInfoResponse>(req, "ModifyLoginWhiteInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the log-in audit allowlist information. (The number of server lists needs to be less than 1,000.)
        /// </summary>
        /// <param name="req"><see cref="ModifyLoginWhiteRecordRequest"/></param>
        /// <returns><see cref="ModifyLoginWhiteRecordResponse"/></returns>
        public Task<ModifyLoginWhiteRecordResponse> ModifyLoginWhiteRecord(ModifyLoginWhiteRecordRequest req)
        {
            return InternalRequestAsync<ModifyLoginWhiteRecordResponse>(req, "ModifyLoginWhiteRecord");
        }

        /// <summary>
        /// This API is used to update the log-in audit allowlist information. (The number of server lists needs to be less than 1,000.)
        /// </summary>
        /// <param name="req"><see cref="ModifyLoginWhiteRecordRequest"/></param>
        /// <returns><see cref="ModifyLoginWhiteRecordResponse"/></returns>
        public ModifyLoginWhiteRecordResponse ModifyLoginWhiteRecordSync(ModifyLoginWhiteRecordRequest req)
        {
            return InternalRequestAsync<ModifyLoginWhiteRecordResponse>(req, "ModifyLoginWhiteRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the cleanup configuration of the machine.
        /// </summary>
        /// <param name="req"><see cref="ModifyMachineAutoClearConfigRequest"/></param>
        /// <returns><see cref="ModifyMachineAutoClearConfigResponse"/></returns>
        public Task<ModifyMachineAutoClearConfigResponse> ModifyMachineAutoClearConfig(ModifyMachineAutoClearConfigRequest req)
        {
            return InternalRequestAsync<ModifyMachineAutoClearConfigResponse>(req, "ModifyMachineAutoClearConfig");
        }

        /// <summary>
        /// This API is used to modify the cleanup configuration of the machine.
        /// </summary>
        /// <param name="req"><see cref="ModifyMachineAutoClearConfigRequest"/></param>
        /// <returns><see cref="ModifyMachineAutoClearConfigResponse"/></returns>
        public ModifyMachineAutoClearConfigResponse ModifyMachineAutoClearConfigSync(ModifyMachineAutoClearConfigRequest req)
        {
            return InternalRequestAsync<ModifyMachineAutoClearConfigResponse>(req, "ModifyMachineAutoClearConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the malicious request allowlist.
        /// </summary>
        /// <param name="req"><see cref="ModifyMaliciousRequestWhiteListRequest"/></param>
        /// <returns><see cref="ModifyMaliciousRequestWhiteListResponse"/></returns>
        public Task<ModifyMaliciousRequestWhiteListResponse> ModifyMaliciousRequestWhiteList(ModifyMaliciousRequestWhiteListRequest req)
        {
            return InternalRequestAsync<ModifyMaliciousRequestWhiteListResponse>(req, "ModifyMaliciousRequestWhiteList");
        }

        /// <summary>
        /// This API is used to update the malicious request allowlist.
        /// </summary>
        /// <param name="req"><see cref="ModifyMaliciousRequestWhiteListRequest"/></param>
        /// <returns><see cref="ModifyMaliciousRequestWhiteListResponse"/></returns>
        public ModifyMaliciousRequestWhiteListResponse ModifyMaliciousRequestWhiteListSync(ModifyMaliciousRequestWhiteListRequest req)
        {
            return InternalRequestAsync<ModifyMaliciousRequestWhiteListResponse>(req, "ModifyMaliciousRequestWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set scheduled scan.
        /// </summary>
        /// <param name="req"><see cref="ModifyMalwareTimingScanSettingsRequest"/></param>
        /// <returns><see cref="ModifyMalwareTimingScanSettingsResponse"/></returns>
        public Task<ModifyMalwareTimingScanSettingsResponse> ModifyMalwareTimingScanSettings(ModifyMalwareTimingScanSettingsRequest req)
        {
            return InternalRequestAsync<ModifyMalwareTimingScanSettingsResponse>(req, "ModifyMalwareTimingScanSettings");
        }

        /// <summary>
        /// This API is used to set scheduled scan.
        /// </summary>
        /// <param name="req"><see cref="ModifyMalwareTimingScanSettingsRequest"/></param>
        /// <returns><see cref="ModifyMalwareTimingScanSettingsResponse"/></returns>
        public ModifyMalwareTimingScanSettingsResponse ModifyMalwareTimingScanSettingsSync(ModifyMalwareTimingScanSettingsRequest req)
        {
            return InternalRequestAsync<ModifyMalwareTimingScanSettingsResponse>(req, "ModifyMalwareTimingScanSettings")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to edit the Trojan allowlist.
        /// </summary>
        /// <param name="req"><see cref="ModifyMalwareWhiteListRequest"/></param>
        /// <returns><see cref="ModifyMalwareWhiteListResponse"/></returns>
        public Task<ModifyMalwareWhiteListResponse> ModifyMalwareWhiteList(ModifyMalwareWhiteListRequest req)
        {
            return InternalRequestAsync<ModifyMalwareWhiteListResponse>(req, "ModifyMalwareWhiteList");
        }

        /// <summary>
        /// This API is used to edit the Trojan allowlist.
        /// </summary>
        /// <param name="req"><see cref="ModifyMalwareWhiteListRequest"/></param>
        /// <returns><see cref="ModifyMalwareWhiteListResponse"/></returns>
        public ModifyMalwareWhiteListResponse ModifyMalwareWhiteListSync(ModifyMalwareWhiteListRequest req)
        {
            return InternalRequestAsync<ModifyMalwareWhiteListResponse>(req, "ModifyMalwareWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify network attack settings.
        /// </summary>
        /// <param name="req"><see cref="ModifyNetAttackSettingRequest"/></param>
        /// <returns><see cref="ModifyNetAttackSettingResponse"/></returns>
        public Task<ModifyNetAttackSettingResponse> ModifyNetAttackSetting(ModifyNetAttackSettingRequest req)
        {
            return InternalRequestAsync<ModifyNetAttackSettingResponse>(req, "ModifyNetAttackSetting");
        }

        /// <summary>
        /// This API is used to modify network attack settings.
        /// </summary>
        /// <param name="req"><see cref="ModifyNetAttackSettingRequest"/></param>
        /// <returns><see cref="ModifyNetAttackSettingResponse"/></returns>
        public ModifyNetAttackSettingResponse ModifyNetAttackSettingSync(ModifyNetAttackSettingRequest req)
        {
            return InternalRequestAsync<ModifyNetAttackSettingResponse>(req, "ModifyNetAttackSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to edit the network attack whitelist.
        /// </summary>
        /// <param name="req"><see cref="ModifyNetAttackWhiteListRequest"/></param>
        /// <returns><see cref="ModifyNetAttackWhiteListResponse"/></returns>
        public Task<ModifyNetAttackWhiteListResponse> ModifyNetAttackWhiteList(ModifyNetAttackWhiteListRequest req)
        {
            return InternalRequestAsync<ModifyNetAttackWhiteListResponse>(req, "ModifyNetAttackWhiteList");
        }

        /// <summary>
        /// This API is used to edit the network attack whitelist.
        /// </summary>
        /// <param name="req"><see cref="ModifyNetAttackWhiteListRequest"/></param>
        /// <returns><see cref="ModifyNetAttackWhiteListResponse"/></returns>
        public ModifyNetAttackWhiteListResponse ModifyNetAttackWhiteListSync(ModifyNetAttackWhiteListRequest req)
        {
            return InternalRequestAsync<ModifyNetAttackWhiteListResponse>(req, "ModifyNetAttackWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the status of anti-ransomware events.
        /// </summary>
        /// <param name="req"><see cref="ModifyRansomDefenseEventsStatusRequest"/></param>
        /// <returns><see cref="ModifyRansomDefenseEventsStatusResponse"/></returns>
        public Task<ModifyRansomDefenseEventsStatusResponse> ModifyRansomDefenseEventsStatus(ModifyRansomDefenseEventsStatusRequest req)
        {
            return InternalRequestAsync<ModifyRansomDefenseEventsStatusResponse>(req, "ModifyRansomDefenseEventsStatus");
        }

        /// <summary>
        /// This API is used to modify the status of anti-ransomware events.
        /// </summary>
        /// <param name="req"><see cref="ModifyRansomDefenseEventsStatusRequest"/></param>
        /// <returns><see cref="ModifyRansomDefenseEventsStatusResponse"/></returns>
        public ModifyRansomDefenseEventsStatusResponse ModifyRansomDefenseEventsStatusSync(ModifyRansomDefenseEventsStatusRequest req)
        {
            return InternalRequestAsync<ModifyRansomDefenseEventsStatusResponse>(req, "ModifyRansomDefenseEventsStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the anti-ransomware policy status in batches.
        /// </summary>
        /// <param name="req"><see cref="ModifyRansomDefenseStrategyStatusRequest"/></param>
        /// <returns><see cref="ModifyRansomDefenseStrategyStatusResponse"/></returns>
        public Task<ModifyRansomDefenseStrategyStatusResponse> ModifyRansomDefenseStrategyStatus(ModifyRansomDefenseStrategyStatusRequest req)
        {
            return InternalRequestAsync<ModifyRansomDefenseStrategyStatusResponse>(req, "ModifyRansomDefenseStrategyStatus");
        }

        /// <summary>
        /// This API is used to modify the anti-ransomware policy status in batches.
        /// </summary>
        /// <param name="req"><see cref="ModifyRansomDefenseStrategyStatusRequest"/></param>
        /// <returns><see cref="ModifyRansomDefenseStrategyStatusResponse"/></returns>
        public ModifyRansomDefenseStrategyStatusResponse ModifyRansomDefenseStrategyStatusSync(ModifyRansomDefenseStrategyStatusRequest req)
        {
            return InternalRequestAsync<ModifyRansomDefenseStrategyStatusResponse>(req, "ModifyRansomDefenseStrategyStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify malicious request policies.
        /// </summary>
        /// <param name="req"><see cref="ModifyRiskDnsPolicyRequest"/></param>
        /// <returns><see cref="ModifyRiskDnsPolicyResponse"/></returns>
        public Task<ModifyRiskDnsPolicyResponse> ModifyRiskDnsPolicy(ModifyRiskDnsPolicyRequest req)
        {
            return InternalRequestAsync<ModifyRiskDnsPolicyResponse>(req, "ModifyRiskDnsPolicy");
        }

        /// <summary>
        /// This API is used to modify malicious request policies.
        /// </summary>
        /// <param name="req"><see cref="ModifyRiskDnsPolicyRequest"/></param>
        /// <returns><see cref="ModifyRiskDnsPolicyResponse"/></returns>
        public ModifyRiskDnsPolicyResponse ModifyRiskDnsPolicySync(ModifyRiskDnsPolicyRequest req)
        {
            return InternalRequestAsync<ModifyRiskDnsPolicyResponse>(req, "ModifyRiskDnsPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the status of malicious request policies.
        /// </summary>
        /// <param name="req"><see cref="ModifyRiskDnsPolicyStatusRequest"/></param>
        /// <returns><see cref="ModifyRiskDnsPolicyStatusResponse"/></returns>
        public Task<ModifyRiskDnsPolicyStatusResponse> ModifyRiskDnsPolicyStatus(ModifyRiskDnsPolicyStatusRequest req)
        {
            return InternalRequestAsync<ModifyRiskDnsPolicyStatusResponse>(req, "ModifyRiskDnsPolicyStatus");
        }

        /// <summary>
        /// This API is used to modify the status of malicious request policies.
        /// </summary>
        /// <param name="req"><see cref="ModifyRiskDnsPolicyStatusRequest"/></param>
        /// <returns><see cref="ModifyRiskDnsPolicyStatusResponse"/></returns>
        public ModifyRiskDnsPolicyStatusResponse ModifyRiskDnsPolicyStatusSync(ModifyRiskDnsPolicyStatusRequest req)
        {
            return InternalRequestAsync<ModifyRiskDnsPolicyStatusResponse>(req, "ModifyRiskDnsPolicyStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to change the status of intrusion detection events, including virus scanning, abnormal log-ins, password cracking, high-risk commands, reverse shells, and local privilege escalations.
        /// </summary>
        /// <param name="req"><see cref="ModifyRiskEventsStatusRequest"/></param>
        /// <returns><see cref="ModifyRiskEventsStatusResponse"/></returns>
        public Task<ModifyRiskEventsStatusResponse> ModifyRiskEventsStatus(ModifyRiskEventsStatusRequest req)
        {
            return InternalRequestAsync<ModifyRiskEventsStatusResponse>(req, "ModifyRiskEventsStatus");
        }

        /// <summary>
        /// This API is used to change the status of intrusion detection events, including virus scanning, abnormal log-ins, password cracking, high-risk commands, reverse shells, and local privilege escalations.
        /// </summary>
        /// <param name="req"><see cref="ModifyRiskEventsStatusRequest"/></param>
        /// <returns><see cref="ModifyRiskEventsStatusResponse"/></returns>
        public ModifyRiskEventsStatusResponse ModifyRiskEventsStatusSync(ModifyRiskEventsStatusRequest req)
        {
            return InternalRequestAsync<ModifyRiskEventsStatusResponse>(req, "ModifyRiskEventsStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create or modify user custom settings.
        /// </summary>
        /// <param name="req"><see cref="ModifyUsersConfigRequest"/></param>
        /// <returns><see cref="ModifyUsersConfigResponse"/></returns>
        public Task<ModifyUsersConfigResponse> ModifyUsersConfig(ModifyUsersConfigRequest req)
        {
            return InternalRequestAsync<ModifyUsersConfigResponse>(req, "ModifyUsersConfig");
        }

        /// <summary>
        /// This API is used to create or modify user custom settings.
        /// </summary>
        /// <param name="req"><see cref="ModifyUsersConfigRequest"/></param>
        /// <returns><see cref="ModifyUsersConfigResponse"/></returns>
        public ModifyUsersConfigResponse ModifyUsersConfigSync(ModifyUsersConfigRequest req)
        {
            return InternalRequestAsync<ModifyUsersConfigResponse>(req, "ModifyUsersConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to change the vulnerability defense event status. (Vulnerability fixing is carried out using another API.)
        /// </summary>
        /// <param name="req"><see cref="ModifyVulDefenceEventStatusRequest"/></param>
        /// <returns><see cref="ModifyVulDefenceEventStatusResponse"/></returns>
        public Task<ModifyVulDefenceEventStatusResponse> ModifyVulDefenceEventStatus(ModifyVulDefenceEventStatusRequest req)
        {
            return InternalRequestAsync<ModifyVulDefenceEventStatusResponse>(req, "ModifyVulDefenceEventStatus");
        }

        /// <summary>
        /// This API is used to change the vulnerability defense event status. (Vulnerability fixing is carried out using another API.)
        /// </summary>
        /// <param name="req"><see cref="ModifyVulDefenceEventStatusRequest"/></param>
        /// <returns><see cref="ModifyVulDefenceEventStatusResponse"/></returns>
        public ModifyVulDefenceEventStatusResponse ModifyVulDefenceEventStatusSync(ModifyVulDefenceEventStatusRequest req)
        {
            return InternalRequestAsync<ModifyVulDefenceEventStatusResponse>(req, "ModifyVulDefenceEventStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify vulnerability defense plugin settings.
        /// 1) The new settings apply to new hosts automatically. scope is set to 1, and quuids is left blank.
        /// 2) The new settings do not apply to Ultimate Edition hosts. scope is set to 0, and the current QUUID list is specified as the value of quuids.
        /// 3) For a given QUUID list, when scope is set to 0, QUUID selected by the user is specified as the value of quuids.
        /// </summary>
        /// <param name="req"><see cref="ModifyVulDefenceSettingRequest"/></param>
        /// <returns><see cref="ModifyVulDefenceSettingResponse"/></returns>
        public Task<ModifyVulDefenceSettingResponse> ModifyVulDefenceSetting(ModifyVulDefenceSettingRequest req)
        {
            return InternalRequestAsync<ModifyVulDefenceSettingResponse>(req, "ModifyVulDefenceSetting");
        }

        /// <summary>
        /// This API is used to modify vulnerability defense plugin settings.
        /// 1) The new settings apply to new hosts automatically. scope is set to 1, and quuids is left blank.
        /// 2) The new settings do not apply to Ultimate Edition hosts. scope is set to 0, and the current QUUID list is specified as the value of quuids.
        /// 3) For a given QUUID list, when scope is set to 0, QUUID selected by the user is specified as the value of quuids.
        /// </summary>
        /// <param name="req"><see cref="ModifyVulDefenceSettingRequest"/></param>
        /// <returns><see cref="ModifyVulDefenceSettingResponse"/></returns>
        public ModifyVulDefenceSettingResponse ModifyVulDefenceSettingSync(ModifyVulDefenceSettingRequest req)
        {
            return InternalRequestAsync<ModifyVulDefenceSettingResponse>(req, "ModifyVulDefenceSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the alarming machine scope settings.
        /// </summary>
        /// <param name="req"><see cref="ModifyWarningHostConfigRequest"/></param>
        /// <returns><see cref="ModifyWarningHostConfigResponse"/></returns>
        public Task<ModifyWarningHostConfigResponse> ModifyWarningHostConfig(ModifyWarningHostConfigRequest req)
        {
            return InternalRequestAsync<ModifyWarningHostConfigResponse>(req, "ModifyWarningHostConfig");
        }

        /// <summary>
        /// This API is used to modify the alarming machine scope settings.
        /// </summary>
        /// <param name="req"><see cref="ModifyWarningHostConfigRequest"/></param>
        /// <returns><see cref="ModifyWarningHostConfigResponse"/></returns>
        public ModifyWarningHostConfigResponse ModifyWarningHostConfigSync(ModifyWarningHostConfigRequest req)
        {
            return InternalRequestAsync<ModifyWarningHostConfigResponse>(req, "ModifyWarningHostConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify alarm settings.
        /// </summary>
        /// <param name="req"><see cref="ModifyWarningSettingRequest"/></param>
        /// <returns><see cref="ModifyWarningSettingResponse"/></returns>
        public Task<ModifyWarningSettingResponse> ModifyWarningSetting(ModifyWarningSettingRequest req)
        {
            return InternalRequestAsync<ModifyWarningSettingResponse>(req, "ModifyWarningSetting");
        }

        /// <summary>
        /// This API is used to modify alarm settings.
        /// </summary>
        /// <param name="req"><see cref="ModifyWarningSettingRequest"/></param>
        /// <returns><see cref="ModifyWarningSettingResponse"/></returns>
        public ModifyWarningSettingResponse ModifyWarningSettingSync(ModifyWarningSettingRequest req)
        {
            return InternalRequestAsync<ModifyWarningSettingResponse>(req, "ModifyWarningSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add or modify alarm policies.
        /// </summary>
        /// <param name="req"><see cref="ModifyWebHookPolicyRequest"/></param>
        /// <returns><see cref="ModifyWebHookPolicyResponse"/></returns>
        public Task<ModifyWebHookPolicyResponse> ModifyWebHookPolicy(ModifyWebHookPolicyRequest req)
        {
            return InternalRequestAsync<ModifyWebHookPolicyResponse>(req, "ModifyWebHookPolicy");
        }

        /// <summary>
        /// This API is used to add or modify alarm policies.
        /// </summary>
        /// <param name="req"><see cref="ModifyWebHookPolicyRequest"/></param>
        /// <returns><see cref="ModifyWebHookPolicyResponse"/></returns>
        public ModifyWebHookPolicyResponse ModifyWebHookPolicySync(ModifyWebHookPolicyRequest req)
        {
            return InternalRequestAsync<ModifyWebHookPolicyResponse>(req, "ModifyWebHookPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the alarm policy switch.
        /// </summary>
        /// <param name="req"><see cref="ModifyWebHookPolicyStatusRequest"/></param>
        /// <returns><see cref="ModifyWebHookPolicyStatusResponse"/></returns>
        public Task<ModifyWebHookPolicyStatusResponse> ModifyWebHookPolicyStatus(ModifyWebHookPolicyStatusRequest req)
        {
            return InternalRequestAsync<ModifyWebHookPolicyStatusResponse>(req, "ModifyWebHookPolicyStatus");
        }

        /// <summary>
        /// This API is used to modify the alarm policy switch.
        /// </summary>
        /// <param name="req"><see cref="ModifyWebHookPolicyStatusRequest"/></param>
        /// <returns><see cref="ModifyWebHookPolicyStatusResponse"/></returns>
        public ModifyWebHookPolicyStatusResponse ModifyWebHookPolicyStatusSync(ModifyWebHookPolicyStatusRequest req)
        {
            return InternalRequestAsync<ModifyWebHookPolicyStatusResponse>(req, "ModifyWebHookPolicyStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add or update the alarm recipient.
        /// </summary>
        /// <param name="req"><see cref="ModifyWebHookReceiverRequest"/></param>
        /// <returns><see cref="ModifyWebHookReceiverResponse"/></returns>
        public Task<ModifyWebHookReceiverResponse> ModifyWebHookReceiver(ModifyWebHookReceiverRequest req)
        {
            return InternalRequestAsync<ModifyWebHookReceiverResponse>(req, "ModifyWebHookReceiver");
        }

        /// <summary>
        /// This API is used to add or update the alarm recipient.
        /// </summary>
        /// <param name="req"><see cref="ModifyWebHookReceiverRequest"/></param>
        /// <returns><see cref="ModifyWebHookReceiverResponse"/></returns>
        public ModifyWebHookReceiverResponse ModifyWebHookReceiverSync(ModifyWebHookReceiverRequest req)
        {
            return InternalRequestAsync<ModifyWebHookReceiverResponse>(req, "ModifyWebHookReceiver")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add or modify the rules of WeCom chatbots.
        /// </summary>
        /// <param name="req"><see cref="ModifyWebHookRuleRequest"/></param>
        /// <returns><see cref="ModifyWebHookRuleResponse"/></returns>
        public Task<ModifyWebHookRuleResponse> ModifyWebHookRule(ModifyWebHookRuleRequest req)
        {
            return InternalRequestAsync<ModifyWebHookRuleResponse>(req, "ModifyWebHookRule");
        }

        /// <summary>
        /// This API is used to add or modify the rules of WeCom chatbots.
        /// </summary>
        /// <param name="req"><see cref="ModifyWebHookRuleRequest"/></param>
        /// <returns><see cref="ModifyWebHookRuleResponse"/></returns>
        public ModifyWebHookRuleResponse ModifyWebHookRuleSync(ModifyWebHookRuleRequest req)
        {
            return InternalRequestAsync<ModifyWebHookRuleResponse>(req, "ModifyWebHookRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the rules of WeCom chatbots.
        /// </summary>
        /// <param name="req"><see cref="ModifyWebHookRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyWebHookRuleStatusResponse"/></returns>
        public Task<ModifyWebHookRuleStatusResponse> ModifyWebHookRuleStatus(ModifyWebHookRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyWebHookRuleStatusResponse>(req, "ModifyWebHookRuleStatus");
        }

        /// <summary>
        /// This API is used to modify the rules of WeCom chatbots.
        /// </summary>
        /// <param name="req"><see cref="ModifyWebHookRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyWebHookRuleStatusResponse"/></returns>
        public ModifyWebHookRuleStatusResponse ModifyWebHookRuleStatusSync(ModifyWebHookRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyWebHookRuleStatusResponse>(req, "ModifyWebHookRuleStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable or disable website anti-tampering protection.
        /// </summary>
        /// <param name="req"><see cref="ModifyWebPageProtectSwitchRequest"/></param>
        /// <returns><see cref="ModifyWebPageProtectSwitchResponse"/></returns>
        public Task<ModifyWebPageProtectSwitchResponse> ModifyWebPageProtectSwitch(ModifyWebPageProtectSwitchRequest req)
        {
            return InternalRequestAsync<ModifyWebPageProtectSwitchResponse>(req, "ModifyWebPageProtectSwitch");
        }

        /// <summary>
        /// This API is used to enable or disable website anti-tampering protection.
        /// </summary>
        /// <param name="req"><see cref="ModifyWebPageProtectSwitchRequest"/></param>
        /// <returns><see cref="ModifyWebPageProtectSwitchResponse"/></returns>
        public ModifyWebPageProtectSwitchResponse ModifyWebPageProtectSwitchSync(ModifyWebPageProtectSwitchRequest req)
        {
            return InternalRequestAsync<ModifyWebPageProtectSwitchResponse>(req, "ModifyWebPageProtectSwitch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to roll back anti-ransomware snapshots.
        /// </summary>
        /// <param name="req"><see cref="RansomDefenseRollbackRequest"/></param>
        /// <returns><see cref="RansomDefenseRollbackResponse"/></returns>
        public Task<RansomDefenseRollbackResponse> RansomDefenseRollback(RansomDefenseRollbackRequest req)
        {
            return InternalRequestAsync<RansomDefenseRollbackResponse>(req, "RansomDefenseRollback");
        }

        /// <summary>
        /// This API is used to roll back anti-ransomware snapshots.
        /// </summary>
        /// <param name="req"><see cref="RansomDefenseRollbackRequest"/></param>
        /// <returns><see cref="RansomDefenseRollbackResponse"/></returns>
        public RansomDefenseRollbackResponse RansomDefenseRollbackSync(RansomDefenseRollbackRequest req)
        {
            return InternalRequestAsync<RansomDefenseRollbackResponse>(req, "RansomDefenseRollback")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch recover quarantined Trojan files.
        /// </summary>
        /// <param name="req"><see cref="RecoverMalwaresRequest"/></param>
        /// <returns><see cref="RecoverMalwaresResponse"/></returns>
        public Task<RecoverMalwaresResponse> RecoverMalwares(RecoverMalwaresRequest req)
        {
            return InternalRequestAsync<RecoverMalwaresResponse>(req, "RecoverMalwares");
        }

        /// <summary>
        /// This API is used to batch recover quarantined Trojan files.
        /// </summary>
        /// <param name="req"><see cref="RecoverMalwaresRequest"/></param>
        /// <returns><see cref="RecoverMalwaresResponse"/></returns>
        public RecoverMalwaresResponse RecoverMalwaresSync(RecoverMalwaresRequest req)
        {
            return InternalRequestAsync<RecoverMalwaresResponse>(req, "RecoverMalwares")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the locally stored data.
        /// </summary>
        /// <param name="req"><see cref="RemoveLocalStorageItemRequest"/></param>
        /// <returns><see cref="RemoveLocalStorageItemResponse"/></returns>
        public Task<RemoveLocalStorageItemResponse> RemoveLocalStorageItem(RemoveLocalStorageItemRequest req)
        {
            return InternalRequestAsync<RemoveLocalStorageItemResponse>(req, "RemoveLocalStorageItem");
        }

        /// <summary>
        /// This API is used to delete the locally stored data.
        /// </summary>
        /// <param name="req"><see cref="RemoveLocalStorageItemRequest"/></param>
        /// <returns><see cref="RemoveLocalStorageItemResponse"/></returns>
        public RemoveLocalStorageItemResponse RemoveLocalStorageItemSync(RemoveLocalStorageItemRequest req)
        {
            return InternalRequestAsync<RemoveLocalStorageItemResponse>(req, "RemoveLocalStorageItem")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete all records of the host. Currently, it only supports non-Tencent Cloud hosts, and the host needs to be offline.
        /// </summary>
        /// <param name="req"><see cref="RemoveMachineRequest"/></param>
        /// <returns><see cref="RemoveMachineResponse"/></returns>
        public Task<RemoveMachineResponse> RemoveMachine(RemoveMachineRequest req)
        {
            return InternalRequestAsync<RemoveMachineResponse>(req, "RemoveMachine");
        }

        /// <summary>
        /// This API is used to delete all records of the host. Currently, it only supports non-Tencent Cloud hosts, and the host needs to be offline.
        /// </summary>
        /// <param name="req"><see cref="RemoveMachineRequest"/></param>
        /// <returns><see cref="RemoveMachineResponse"/></returns>
        public RemoveMachineResponse RemoveMachineSync(RemoveMachineRequest req)
        {
            return InternalRequestAsync<RemoveMachineResponse>(req, "RemoveMachine")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to retry to create snapshots and automatically fix vulnerabilities when the creation fails.
        /// </summary>
        /// <param name="req"><see cref="RetryCreateSnapshotRequest"/></param>
        /// <returns><see cref="RetryCreateSnapshotResponse"/></returns>
        public Task<RetryCreateSnapshotResponse> RetryCreateSnapshot(RetryCreateSnapshotRequest req)
        {
            return InternalRequestAsync<RetryCreateSnapshotResponse>(req, "RetryCreateSnapshot");
        }

        /// <summary>
        /// This API is used to retry to create snapshots and automatically fix vulnerabilities when the creation fails.
        /// </summary>
        /// <param name="req"><see cref="RetryCreateSnapshotRequest"/></param>
        /// <returns><see cref="RetryCreateSnapshotResponse"/></returns>
        public RetryCreateSnapshotResponse RetryCreateSnapshotSync(RetryCreateSnapshotRequest req)
        {
            return InternalRequestAsync<RetryCreateSnapshotResponse>(req, "RetryCreateSnapshot")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to fix vulnerabilities on a single host when the fix fails.
        /// </summary>
        /// <param name="req"><see cref="RetryVulFixRequest"/></param>
        /// <returns><see cref="RetryVulFixResponse"/></returns>
        public Task<RetryVulFixResponse> RetryVulFix(RetryVulFixRequest req)
        {
            return InternalRequestAsync<RetryVulFixResponse>(req, "RetryVulFix");
        }

        /// <summary>
        /// This API is used to fix vulnerabilities on a single host when the fix fails.
        /// </summary>
        /// <param name="req"><see cref="RetryVulFixRequest"/></param>
        /// <returns><see cref="RetryVulFixResponse"/></returns>
        public RetryVulFixResponse RetryVulFixSync(RetryVulFixRequest req)
        {
            return InternalRequestAsync<RetryVulFixResponse>(req, "RetryVulFix")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain baseline detection and re-detection APIs.
        /// </summary>
        /// <param name="req"><see cref="ScanBaselineRequest"/></param>
        /// <returns><see cref="ScanBaselineResponse"/></returns>
        public Task<ScanBaselineResponse> ScanBaseline(ScanBaselineRequest req)
        {
            return InternalRequestAsync<ScanBaselineResponse>(req, "ScanBaseline");
        }

        /// <summary>
        /// This API is used to obtain baseline detection and re-detection APIs.
        /// </summary>
        /// <param name="req"><see cref="ScanBaselineRequest"/></param>
        /// <returns><see cref="ScanBaselineResponse"/></returns>
        public ScanBaselineResponse ScanBaselineSync(ScanBaselineRequest req)
        {
            return InternalRequestAsync<ScanBaselineResponse>(req, "ScanBaseline")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to restart the scan task. Specifying the machine is supported.
        /// </summary>
        /// <param name="req"><see cref="ScanTaskAgainRequest"/></param>
        /// <returns><see cref="ScanTaskAgainResponse"/></returns>
        public Task<ScanTaskAgainResponse> ScanTaskAgain(ScanTaskAgainRequest req)
        {
            return InternalRequestAsync<ScanTaskAgainResponse>(req, "ScanTaskAgain");
        }

        /// <summary>
        /// This API is used to restart the scan task. Specifying the machine is supported.
        /// </summary>
        /// <param name="req"><see cref="ScanTaskAgainRequest"/></param>
        /// <returns><see cref="ScanTaskAgainResponse"/></returns>
        public ScanTaskAgainResponse ScanTaskAgainSync(ScanTaskAgainRequest req)
        {
            return InternalRequestAsync<ScanTaskAgainResponse>(req, "ScanTaskAgain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to perform one-click vulnerability scans.
        /// </summary>
        /// <param name="req"><see cref="ScanVulRequest"/></param>
        /// <returns><see cref="ScanVulResponse"/></returns>
        public Task<ScanVulResponse> ScanVul(ScanVulRequest req)
        {
            return InternalRequestAsync<ScanVulResponse>(req, "ScanVul");
        }

        /// <summary>
        /// This API is used to perform one-click vulnerability scans.
        /// </summary>
        /// <param name="req"><see cref="ScanVulRequest"/></param>
        /// <returns><see cref="ScanVulResponse"/></returns>
        public ScanVulResponse ScanVulSync(ScanVulRequest req)
        {
            return InternalRequestAsync<ScanVulResponse>(req, "ScanVul")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to redetect the API.
        /// </summary>
        /// <param name="req"><see cref="ScanVulAgainRequest"/></param>
        /// <returns><see cref="ScanVulAgainResponse"/></returns>
        public Task<ScanVulAgainResponse> ScanVulAgain(ScanVulAgainRequest req)
        {
            return InternalRequestAsync<ScanVulAgainResponse>(req, "ScanVulAgain");
        }

        /// <summary>
        /// This API is used to redetect the API.
        /// </summary>
        /// <param name="req"><see cref="ScanVulAgainRequest"/></param>
        /// <returns><see cref="ScanVulAgainResponse"/></returns>
        public ScanVulAgainResponse ScanVulAgainSync(ScanVulAgainRequest req)
        {
            return InternalRequestAsync<ScanVulAgainResponse>(req, "ScanVulAgain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to complete regular vulnerability scan settings.
        /// </summary>
        /// <param name="req"><see cref="ScanVulSettingRequest"/></param>
        /// <returns><see cref="ScanVulSettingResponse"/></returns>
        public Task<ScanVulSettingResponse> ScanVulSetting(ScanVulSettingRequest req)
        {
            return InternalRequestAsync<ScanVulSettingResponse>(req, "ScanVulSetting");
        }

        /// <summary>
        /// This API is used to complete regular vulnerability scan settings.
        /// </summary>
        /// <param name="req"><see cref="ScanVulSettingRequest"/></param>
        /// <returns><see cref="ScanVulSettingResponse"/></returns>
        public ScanVulSettingResponse ScanVulSettingSync(ScanVulSettingRequest req)
        {
            return InternalRequestAsync<ScanVulSettingResponse>(req, "ScanVulSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query logs.
        /// </summary>
        /// <param name="req"><see cref="SearchLogRequest"/></param>
        /// <returns><see cref="SearchLogResponse"/></returns>
        public Task<SearchLogResponse> SearchLog(SearchLogRequest req)
        {
            return InternalRequestAsync<SearchLogResponse>(req, "SearchLog");
        }

        /// <summary>
        /// This API is used to query logs.
        /// </summary>
        /// <param name="req"><see cref="SearchLogRequest"/></param>
        /// <returns><see cref="SearchLogResponse"/></returns>
        public SearchLogResponse SearchLogSync(SearchLogRequest req)
        {
            return InternalRequestAsync<SearchLogResponse>(req, "SearchLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to isolate Trojans.
        /// </summary>
        /// <param name="req"><see cref="SeparateMalwaresRequest"/></param>
        /// <returns><see cref="SeparateMalwaresResponse"/></returns>
        public Task<SeparateMalwaresResponse> SeparateMalwares(SeparateMalwaresRequest req)
        {
            return InternalRequestAsync<SeparateMalwaresResponse>(req, "SeparateMalwares");
        }

        /// <summary>
        /// This API is used to isolate Trojans.
        /// </summary>
        /// <param name="req"><see cref="SeparateMalwaresRequest"/></param>
        /// <returns><see cref="SeparateMalwaresResponse"/></returns>
        public SeparateMalwaresResponse SeparateMalwaresSync(SeparateMalwaresRequest req)
        {
            return InternalRequestAsync<SeparateMalwaresResponse>(req, "SeparateMalwares")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set the high-risk command event status.
        /// </summary>
        /// <param name="req"><see cref="SetBashEventsStatusRequest"/></param>
        /// <returns><see cref="SetBashEventsStatusResponse"/></returns>
        public Task<SetBashEventsStatusResponse> SetBashEventsStatus(SetBashEventsStatusRequest req)
        {
            return InternalRequestAsync<SetBashEventsStatusResponse>(req, "SetBashEventsStatus");
        }

        /// <summary>
        /// This API is used to set the high-risk command event status.
        /// </summary>
        /// <param name="req"><see cref="SetBashEventsStatusRequest"/></param>
        /// <returns><see cref="SetBashEventsStatusResponse"/></returns>
        public SetBashEventsStatusResponse SetBashEventsStatusSync(SetBashEventsStatusRequest req)
        {
            return InternalRequestAsync<SetBashEventsStatusResponse>(req, "SetBashEventsStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set the expiration time of the locally stored data.
        /// </summary>
        /// <param name="req"><see cref="SetLocalStorageExpireRequest"/></param>
        /// <returns><see cref="SetLocalStorageExpireResponse"/></returns>
        public Task<SetLocalStorageExpireResponse> SetLocalStorageExpire(SetLocalStorageExpireRequest req)
        {
            return InternalRequestAsync<SetLocalStorageExpireResponse>(req, "SetLocalStorageExpire");
        }

        /// <summary>
        /// This API is used to set the expiration time of the locally stored data.
        /// </summary>
        /// <param name="req"><see cref="SetLocalStorageExpireRequest"/></param>
        /// <returns><see cref="SetLocalStorageExpireResponse"/></returns>
        public SetLocalStorageExpireResponse SetLocalStorageExpireSync(SetLocalStorageExpireRequest req)
        {
            return InternalRequestAsync<SetLocalStorageExpireResponse>(req, "SetLocalStorageExpire")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set the locally stored data.
        /// </summary>
        /// <param name="req"><see cref="SetLocalStorageItemRequest"/></param>
        /// <returns><see cref="SetLocalStorageItemResponse"/></returns>
        public Task<SetLocalStorageItemResponse> SetLocalStorageItem(SetLocalStorageItemRequest req)
        {
            return InternalRequestAsync<SetLocalStorageItemResponse>(req, "SetLocalStorageItem");
        }

        /// <summary>
        /// This API is used to set the locally stored data.
        /// </summary>
        /// <param name="req"><see cref="SetLocalStorageItemRequest"/></param>
        /// <returns><see cref="SetLocalStorageItemResponse"/></returns>
        public SetLocalStorageItemResponse SetLocalStorageItemSync(SetLocalStorageItemRequest req)
        {
            return InternalRequestAsync<SetLocalStorageItemResponse>(req, "SetLocalStorageItem")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to perform baseline checks.
        /// </summary>
        /// <param name="req"><see cref="StartBaselineDetectRequest"/></param>
        /// <returns><see cref="StartBaselineDetectResponse"/></returns>
        public Task<StartBaselineDetectResponse> StartBaselineDetect(StartBaselineDetectRequest req)
        {
            return InternalRequestAsync<StartBaselineDetectResponse>(req, "StartBaselineDetect");
        }

        /// <summary>
        /// This API is used to perform baseline checks.
        /// </summary>
        /// <param name="req"><see cref="StartBaselineDetectRequest"/></param>
        /// <returns><see cref="StartBaselineDetectResponse"/></returns>
        public StartBaselineDetectResponse StartBaselineDetectSync(StartBaselineDetectRequest req)
        {
            return InternalRequestAsync<StartBaselineDetectResponse>(req, "StartBaselineDetect")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to stop the asset scan task.
        /// </summary>
        /// <param name="req"><see cref="StopAssetScanRequest"/></param>
        /// <returns><see cref="StopAssetScanResponse"/></returns>
        public Task<StopAssetScanResponse> StopAssetScan(StopAssetScanRequest req)
        {
            return InternalRequestAsync<StopAssetScanResponse>(req, "StopAssetScan");
        }

        /// <summary>
        /// This API is used to stop the asset scan task.
        /// </summary>
        /// <param name="req"><see cref="StopAssetScanRequest"/></param>
        /// <returns><see cref="StopAssetScanResponse"/></returns>
        public StopAssetScanResponse StopAssetScanSync(StopAssetScanRequest req)
        {
            return InternalRequestAsync<StopAssetScanResponse>(req, "StopAssetScan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to stop baseline check.
        /// </summary>
        /// <param name="req"><see cref="StopBaselineDetectRequest"/></param>
        /// <returns><see cref="StopBaselineDetectResponse"/></returns>
        public Task<StopBaselineDetectResponse> StopBaselineDetect(StopBaselineDetectRequest req)
        {
            return InternalRequestAsync<StopBaselineDetectResponse>(req, "StopBaselineDetect");
        }

        /// <summary>
        /// This API is used to stop baseline check.
        /// </summary>
        /// <param name="req"><see cref="StopBaselineDetectRequest"/></param>
        /// <returns><see cref="StopBaselineDetectResponse"/></returns>
        public StopBaselineDetectResponse StopBaselineDetectSync(StopBaselineDetectRequest req)
        {
            return InternalRequestAsync<StopBaselineDetectResponse>(req, "StopBaselineDetect")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to stop displaying pop-up prompts about brute force cracking blocking.
        /// </summary>
        /// <param name="req"><see cref="StopNoticeBanTipsRequest"/></param>
        /// <returns><see cref="StopNoticeBanTipsResponse"/></returns>
        public Task<StopNoticeBanTipsResponse> StopNoticeBanTips(StopNoticeBanTipsRequest req)
        {
            return InternalRequestAsync<StopNoticeBanTipsResponse>(req, "StopNoticeBanTips");
        }

        /// <summary>
        /// This API is used to stop displaying pop-up prompts about brute force cracking blocking.
        /// </summary>
        /// <param name="req"><see cref="StopNoticeBanTipsRequest"/></param>
        /// <returns><see cref="StopNoticeBanTipsResponse"/></returns>
        public StopNoticeBanTipsResponse StopNoticeBanTipsSync(StopNoticeBanTipsRequest req)
        {
            return InternalRequestAsync<StopNoticeBanTipsResponse>(req, "StopNoticeBanTips")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to switch the statuses of high-risk command rules.
        /// </summary>
        /// <param name="req"><see cref="SwitchBashRulesRequest"/></param>
        /// <returns><see cref="SwitchBashRulesResponse"/></returns>
        public Task<SwitchBashRulesResponse> SwitchBashRules(SwitchBashRulesRequest req)
        {
            return InternalRequestAsync<SwitchBashRulesResponse>(req, "SwitchBashRules");
        }

        /// <summary>
        /// This API is used to switch the statuses of high-risk command rules.
        /// </summary>
        /// <param name="req"><see cref="SwitchBashRulesRequest"/></param>
        /// <returns><see cref="SwitchBashRulesResponse"/></returns>
        public SwitchBashRulesResponse SwitchBashRulesSync(SwitchBashRulesRequest req)
        {
            return InternalRequestAsync<SwitchBashRulesResponse>(req, "SwitchBashRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to synchronize the asset scan information.
        /// </summary>
        /// <param name="req"><see cref="SyncAssetScanRequest"/></param>
        /// <returns><see cref="SyncAssetScanResponse"/></returns>
        public Task<SyncAssetScanResponse> SyncAssetScan(SyncAssetScanRequest req)
        {
            return InternalRequestAsync<SyncAssetScanResponse>(req, "SyncAssetScan");
        }

        /// <summary>
        /// This API is used to synchronize the asset scan information.
        /// </summary>
        /// <param name="req"><see cref="SyncAssetScanRequest"/></param>
        /// <returns><see cref="SyncAssetScanResponse"/></returns>
        public SyncAssetScanResponse SyncAssetScanSync(SyncAssetScanRequest req)
        {
            return InternalRequestAsync<SyncAssetScanResponse>(req, "SyncAssetScan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to sync the summary of baseline detection progress.
        /// </summary>
        /// <param name="req"><see cref="SyncBaselineDetectSummaryRequest"/></param>
        /// <returns><see cref="SyncBaselineDetectSummaryResponse"/></returns>
        public Task<SyncBaselineDetectSummaryResponse> SyncBaselineDetectSummary(SyncBaselineDetectSummaryRequest req)
        {
            return InternalRequestAsync<SyncBaselineDetectSummaryResponse>(req, "SyncBaselineDetectSummary");
        }

        /// <summary>
        /// This API is used to sync the summary of baseline detection progress.
        /// </summary>
        /// <param name="req"><see cref="SyncBaselineDetectSummaryRequest"/></param>
        /// <returns><see cref="SyncBaselineDetectSummaryResponse"/></returns>
        public SyncBaselineDetectSummaryResponse SyncBaselineDetectSummarySync(SyncBaselineDetectSummaryRequest req)
        {
            return InternalRequestAsync<SyncBaselineDetectSummaryResponse>(req, "SyncBaselineDetectSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to sync the machine information.
        /// </summary>
        /// <param name="req"><see cref="SyncMachinesRequest"/></param>
        /// <returns><see cref="SyncMachinesResponse"/></returns>
        public Task<SyncMachinesResponse> SyncMachines(SyncMachinesRequest req)
        {
            return InternalRequestAsync<SyncMachinesResponse>(req, "SyncMachines");
        }

        /// <summary>
        /// This API is used to sync the machine information.
        /// </summary>
        /// <param name="req"><see cref="SyncMachinesRequest"/></param>
        /// <returns><see cref="SyncMachinesResponse"/></returns>
        public SyncMachinesResponse SyncMachinesSync(SyncMachinesRequest req)
        {
            return InternalRequestAsync<SyncMachinesResponse>(req, "SyncMachines")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to test the rules of WeCom chatbots.
        /// </summary>
        /// <param name="req"><see cref="TestWebHookRuleRequest"/></param>
        /// <returns><see cref="TestWebHookRuleResponse"/></returns>
        public Task<TestWebHookRuleResponse> TestWebHookRule(TestWebHookRuleRequest req)
        {
            return InternalRequestAsync<TestWebHookRuleResponse>(req, "TestWebHookRule");
        }

        /// <summary>
        /// This API is used to test the rules of WeCom chatbots.
        /// </summary>
        /// <param name="req"><see cref="TestWebHookRuleRequest"/></param>
        /// <returns><see cref="TestWebHookRuleResponse"/></returns>
        public TestWebHookRuleResponse TestWebHookRuleSync(TestWebHookRuleRequest req)
        {
            return InternalRequestAsync<TestWebHookRuleResponse>(req, "TestWebHookRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to mark identified Trojan files as Trusted.
        /// </summary>
        /// <param name="req"><see cref="TrustMalwaresRequest"/></param>
        /// <returns><see cref="TrustMalwaresResponse"/></returns>
        public Task<TrustMalwaresResponse> TrustMalwares(TrustMalwaresRequest req)
        {
            return InternalRequestAsync<TrustMalwaresResponse>(req, "TrustMalwares");
        }

        /// <summary>
        /// This API is used to mark identified Trojan files as Trusted.
        /// </summary>
        /// <param name="req"><see cref="TrustMalwaresRequest"/></param>
        /// <returns><see cref="TrustMalwaresResponse"/></returns>
        public TrustMalwaresResponse TrustMalwaresSync(TrustMalwaresRequest req)
        {
            return InternalRequestAsync<TrustMalwaresResponse>(req, "TrustMalwares")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to untrust Trojan files.
        /// </summary>
        /// <param name="req"><see cref="UntrustMalwaresRequest"/></param>
        /// <returns><see cref="UntrustMalwaresResponse"/></returns>
        public Task<UntrustMalwaresResponse> UntrustMalwares(UntrustMalwaresRequest req)
        {
            return InternalRequestAsync<UntrustMalwaresResponse>(req, "UntrustMalwares");
        }

        /// <summary>
        /// This API is used to untrust Trojan files.
        /// </summary>
        /// <param name="req"><see cref="UntrustMalwaresRequest"/></param>
        /// <returns><see cref="UntrustMalwaresResponse"/></returns>
        public UntrustMalwaresResponse UntrustMalwaresSync(UntrustMalwaresRequest req)
        {
            return InternalRequestAsync<UntrustMalwaresResponse>(req, "UntrustMalwares")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the policy information based on baseline policy IDs.
        /// </summary>
        /// <param name="req"><see cref="UpdateBaselineStrategyRequest"/></param>
        /// <returns><see cref="UpdateBaselineStrategyResponse"/></returns>
        public Task<UpdateBaselineStrategyResponse> UpdateBaselineStrategy(UpdateBaselineStrategyRequest req)
        {
            return InternalRequestAsync<UpdateBaselineStrategyResponse>(req, "UpdateBaselineStrategy");
        }

        /// <summary>
        /// This API is used to update the policy information based on baseline policy IDs.
        /// </summary>
        /// <param name="req"><see cref="UpdateBaselineStrategyRequest"/></param>
        /// <returns><see cref="UpdateBaselineStrategyResponse"/></returns>
        public UpdateBaselineStrategyResponse UpdateBaselineStrategySync(UpdateBaselineStrategyRequest req)
        {
            return InternalRequestAsync<UpdateBaselineStrategyResponse>(req, "UpdateBaselineStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of tags associated with machines.
        /// </summary>
        /// <param name="req"><see cref="UpdateMachineTagsRequest"/></param>
        /// <returns><see cref="UpdateMachineTagsResponse"/></returns>
        public Task<UpdateMachineTagsResponse> UpdateMachineTags(UpdateMachineTagsRequest req)
        {
            return InternalRequestAsync<UpdateMachineTagsResponse>(req, "UpdateMachineTags");
        }

        /// <summary>
        /// This API is used to obtain the list of tags associated with machines.
        /// </summary>
        /// <param name="req"><see cref="UpdateMachineTagsRequest"/></param>
        /// <returns><see cref="UpdateMachineTagsResponse"/></returns>
        public UpdateMachineTagsResponse UpdateMachineTagsSync(UpdateMachineTagsRequest req)
        {
            return InternalRequestAsync<UpdateMachineTagsResponse>(req, "UpdateMachineTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
