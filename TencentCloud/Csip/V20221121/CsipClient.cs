/*
 * Copyright (c) 2018 Tencent. All Rights Reserved.
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

namespace TencentCloud.Csip.V20221121
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Csip.V20221121.Models;

   public class CsipClient : AbstractClient{

       private const string endpoint = "csip.intl.tencentcloudapi.com";
       private const string version = "2022-11-21";
       private const string sdkVersion = "SDK_NET_3.0.1387";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CsipClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CsipClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to create or modify SMTP mailbox access requests.
        /// </summary>
        /// <param name="req"><see cref="AccessAIAnalysisSMTPRequest"/></param>
        /// <returns><see cref="AccessAIAnalysisSMTPResponse"/></returns>
        public Task<AccessAIAnalysisSMTPResponse> AccessAIAnalysisSMTP(AccessAIAnalysisSMTPRequest req)
        {
            return InternalRequestAsync<AccessAIAnalysisSMTPResponse>(req, "AccessAIAnalysisSMTP");
        }

        /// <summary>
        /// This API is used to create or modify SMTP mailbox access requests.
        /// </summary>
        /// <param name="req"><see cref="AccessAIAnalysisSMTPRequest"/></param>
        /// <returns><see cref="AccessAIAnalysisSMTPResponse"/></returns>
        public AccessAIAnalysisSMTPResponse AccessAIAnalysisSMTPSync(AccessAIAnalysisSMTPRequest req)
        {
            return InternalRequestAsync<AccessAIAnalysisSMTPResponse>(req, "AccessAIAnalysisSMTP")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Add asset administrator
        /// </summary>
        /// <param name="req"><see cref="AddDspmAssetManagerRequest"/></param>
        /// <returns><see cref="AddDspmAssetManagerResponse"/></returns>
        public Task<AddDspmAssetManagerResponse> AddDspmAssetManager(AddDspmAssetManagerRequest req)
        {
            return InternalRequestAsync<AddDspmAssetManagerResponse>(req, "AddDspmAssetManager");
        }

        /// <summary>
        /// Add asset administrator
        /// </summary>
        /// <param name="req"><see cref="AddDspmAssetManagerRequest"/></param>
        /// <returns><see cref="AddDspmAssetManagerResponse"/></returns>
        public AddDspmAssetManagerResponse AddDspmAssetManagerSync(AddDspmAssetManagerRequest req)
        {
            return InternalRequestAsync<AddDspmAssetManagerResponse>(req, "AddDspmAssetManager")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Add mirror repository information.
        /// </summary>
        /// <param name="req"><see cref="AddImageRegistryRequest"/></param>
        /// <returns><see cref="AddImageRegistryResponse"/></returns>
        public Task<AddImageRegistryResponse> AddImageRegistry(AddImageRegistryRequest req)
        {
            return InternalRequestAsync<AddImageRegistryResponse>(req, "AddImageRegistry");
        }

        /// <summary>
        /// Add mirror repository information.
        /// </summary>
        /// <param name="req"><see cref="AddImageRegistryRequest"/></param>
        /// <returns><see cref="AddImageRegistryResponse"/></returns>
        public AddImageRegistryResponse AddImageRegistrySync(AddImageRegistryRequest req)
        {
            return InternalRequestAsync<AddImageRegistryResponse>(req, "AddImageRegistry")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        /// CSIP Role Authorization Binding API
        /// </summary>
        /// <param name="req"><see cref="AddNewBindRoleUserRequest"/></param>
        /// <returns><see cref="AddNewBindRoleUserResponse"/></returns>
        public Task<AddNewBindRoleUserResponse> AddNewBindRoleUser(AddNewBindRoleUserRequest req)
        {
            return InternalRequestAsync<AddNewBindRoleUserResponse>(req, "AddNewBindRoleUser");
        }

        /// <summary>
        /// CSIP Role Authorization Binding API
        /// </summary>
        /// <param name="req"><see cref="AddNewBindRoleUserRequest"/></param>
        /// <returns><see cref="AddNewBindRoleUserResponse"/></returns>
        public AddNewBindRoleUserResponse AddNewBindRoleUserSync(AddNewBindRoleUserRequest req)
        {
            return InternalRequestAsync<AddNewBindRoleUserResponse>(req, "AddNewBindRoleUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Add a vulnerability allowlist
        /// </summary>
        /// <param name="req"><see cref="AddVulWhitelistRequest"/></param>
        /// <returns><see cref="AddVulWhitelistResponse"/></returns>
        public Task<AddVulWhitelistResponse> AddVulWhitelist(AddVulWhitelistRequest req)
        {
            return InternalRequestAsync<AddVulWhitelistResponse>(req, "AddVulWhitelist");
        }

        /// <summary>
        /// Add a vulnerability allowlist
        /// </summary>
        /// <param name="req"><see cref="AddVulWhitelistRequest"/></param>
        /// <returns><see cref="AddVulWhitelistResponse"/></returns>
        public AddVulWhitelistResponse AddVulWhitelistSync(AddVulWhitelistRequest req)
        {
            return InternalRequestAsync<AddVulWhitelistResponse>(req, "AddVulWhitelist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Batch modify the "periodic scan configuration / automatic synchronization of newly-added detection items / detection item hit configuration / customized detection items" settings in the baseline policy. Only fields passed in the request are modified.
        /// </summary>
        /// <param name="req"><see cref="BatchModifyBaselinePolicyRequest"/></param>
        /// <returns><see cref="BatchModifyBaselinePolicyResponse"/></returns>
        public Task<BatchModifyBaselinePolicyResponse> BatchModifyBaselinePolicy(BatchModifyBaselinePolicyRequest req)
        {
            return InternalRequestAsync<BatchModifyBaselinePolicyResponse>(req, "BatchModifyBaselinePolicy");
        }

        /// <summary>
        /// Batch modify the "periodic scan configuration / automatic synchronization of newly-added detection items / detection item hit configuration / customized detection items" settings in the baseline policy. Only fields passed in the request are modified.
        /// </summary>
        /// <param name="req"><see cref="BatchModifyBaselinePolicyRequest"/></param>
        /// <returns><see cref="BatchModifyBaselinePolicyResponse"/></returns>
        public BatchModifyBaselinePolicyResponse BatchModifyBaselinePolicySync(BatchModifyBaselinePolicyRequest req)
        {
            return InternalRequestAsync<BatchModifyBaselinePolicyResponse>(req, "BatchModifyBaselinePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Batch modify the scheduled scan task configurations of image repositories.
        /// </summary>
        /// <param name="req"><see cref="BatchModifyImageRegistryTimedScanTaskConfigRequest"/></param>
        /// <returns><see cref="BatchModifyImageRegistryTimedScanTaskConfigResponse"/></returns>
        public Task<BatchModifyImageRegistryTimedScanTaskConfigResponse> BatchModifyImageRegistryTimedScanTaskConfig(BatchModifyImageRegistryTimedScanTaskConfigRequest req)
        {
            return InternalRequestAsync<BatchModifyImageRegistryTimedScanTaskConfigResponse>(req, "BatchModifyImageRegistryTimedScanTaskConfig");
        }

        /// <summary>
        /// Batch modify the scheduled scan task configurations of image repositories.
        /// </summary>
        /// <param name="req"><see cref="BatchModifyImageRegistryTimedScanTaskConfigRequest"/></param>
        /// <returns><see cref="BatchModifyImageRegistryTimedScanTaskConfigResponse"/></returns>
        public BatchModifyImageRegistryTimedScanTaskConfigResponse BatchModifyImageRegistryTimedScanTaskConfigSync(BatchModifyImageRegistryTimedScanTaskConfigRequest req)
        {
            return InternalRequestAsync<BatchModifyImageRegistryTimedScanTaskConfigResponse>(req, "BatchModifyImageRegistryTimedScanTaskConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Batch Modify Sensitive Information Allowlist for Container Images
        /// </summary>
        /// <param name="req"><see cref="BatchModifyImageSensitiveWhitelistRequest"/></param>
        /// <returns><see cref="BatchModifyImageSensitiveWhitelistResponse"/></returns>
        public Task<BatchModifyImageSensitiveWhitelistResponse> BatchModifyImageSensitiveWhitelist(BatchModifyImageSensitiveWhitelistRequest req)
        {
            return InternalRequestAsync<BatchModifyImageSensitiveWhitelistResponse>(req, "BatchModifyImageSensitiveWhitelist");
        }

        /// <summary>
        /// Batch Modify Sensitive Information Allowlist for Container Images
        /// </summary>
        /// <param name="req"><see cref="BatchModifyImageSensitiveWhitelistRequest"/></param>
        /// <returns><see cref="BatchModifyImageSensitiveWhitelistResponse"/></returns>
        public BatchModifyImageSensitiveWhitelistResponse BatchModifyImageSensitiveWhitelistSync(BatchModifyImageSensitiveWhitelistRequest req)
        {
            return InternalRequestAsync<BatchModifyImageSensitiveWhitelistResponse>(req, "BatchModifyImageSensitiveWhitelist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Batch modify the Trojan allowlist for images.
        /// </summary>
        /// <param name="req"><see cref="BatchModifyImageVirusWhitelistRequest"/></param>
        /// <returns><see cref="BatchModifyImageVirusWhitelistResponse"/></returns>
        public Task<BatchModifyImageVirusWhitelistResponse> BatchModifyImageVirusWhitelist(BatchModifyImageVirusWhitelistRequest req)
        {
            return InternalRequestAsync<BatchModifyImageVirusWhitelistResponse>(req, "BatchModifyImageVirusWhitelist");
        }

        /// <summary>
        /// Batch modify the Trojan allowlist for images.
        /// </summary>
        /// <param name="req"><see cref="BatchModifyImageVirusWhitelistRequest"/></param>
        /// <returns><see cref="BatchModifyImageVirusWhitelistResponse"/></returns>
        public BatchModifyImageVirusWhitelistResponse BatchModifyImageVirusWhitelistSync(BatchModifyImageVirusWhitelistRequest req)
        {
            return InternalRequestAsync<BatchModifyImageVirusWhitelistResponse>(req, "BatchModifyImageVirusWhitelist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Batch Modify Vulnerability Allowlist for Container Images
        /// </summary>
        /// <param name="req"><see cref="BatchModifyImageVulWhitelistRequest"/></param>
        /// <returns><see cref="BatchModifyImageVulWhitelistResponse"/></returns>
        public Task<BatchModifyImageVulWhitelistResponse> BatchModifyImageVulWhitelist(BatchModifyImageVulWhitelistRequest req)
        {
            return InternalRequestAsync<BatchModifyImageVulWhitelistResponse>(req, "BatchModifyImageVulWhitelist");
        }

        /// <summary>
        /// Batch Modify Vulnerability Allowlist for Container Images
        /// </summary>
        /// <param name="req"><see cref="BatchModifyImageVulWhitelistRequest"/></param>
        /// <returns><see cref="BatchModifyImageVulWhitelistResponse"/></returns>
        public BatchModifyImageVulWhitelistResponse BatchModifyImageVulWhitelistSync(BatchModifyImageVulWhitelistRequest req)
        {
            return InternalRequestAsync<BatchModifyImageVulWhitelistResponse>(req, "BatchModifyImageVulWhitelist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Cancel a permanently ignored EDR multi-behavior alarm. Remove the corresponding host and rule record from the AI-Link permanent ignore allowlist and restore the alarm status to PENDING.
        /// </summary>
        /// <param name="req"><see cref="CancelEdrAlertIgnoreRequest"/></param>
        /// <returns><see cref="CancelEdrAlertIgnoreResponse"/></returns>
        public Task<CancelEdrAlertIgnoreResponse> CancelEdrAlertIgnore(CancelEdrAlertIgnoreRequest req)
        {
            return InternalRequestAsync<CancelEdrAlertIgnoreResponse>(req, "CancelEdrAlertIgnore");
        }

        /// <summary>
        /// Cancel a permanently ignored EDR multi-behavior alarm. Remove the corresponding host and rule record from the AI-Link permanent ignore allowlist and restore the alarm status to PENDING.
        /// </summary>
        /// <param name="req"><see cref="CancelEdrAlertIgnoreRequest"/></param>
        /// <returns><see cref="CancelEdrAlertIgnoreResponse"/></returns>
        public CancelEdrAlertIgnoreResponse CancelEdrAlertIgnoreSync(CancelEdrAlertIgnoreRequest req)
        {
            return InternalRequestAsync<CancelEdrAlertIgnoreResponse>(req, "CancelEdrAlertIgnore")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Determine whether the current user is on the flagship edition for hosts.
        /// </summary>
        /// <param name="req"><see cref="CheckCWPExposePathPermissionRequest"/></param>
        /// <returns><see cref="CheckCWPExposePathPermissionResponse"/></returns>
        public Task<CheckCWPExposePathPermissionResponse> CheckCWPExposePathPermission(CheckCWPExposePathPermissionRequest req)
        {
            return InternalRequestAsync<CheckCWPExposePathPermissionResponse>(req, "CheckCWPExposePathPermission");
        }

        /// <summary>
        /// Determine whether the current user is on the flagship edition for hosts.
        /// </summary>
        /// <param name="req"><see cref="CheckCWPExposePathPermissionRequest"/></param>
        /// <returns><see cref="CheckCWPExposePathPermissionResponse"/></returns>
        public CheckCWPExposePathPermissionResponse CheckCWPExposePathPermissionSync(CheckCWPExposePathPermissionRequest req)
        {
            return InternalRequestAsync<CheckCWPExposePathPermissionResponse>(req, "CheckCWPExposePathPermission")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Check whether the image repository instance name is duplicate.
        /// </summary>
        /// <param name="req"><see cref="CheckImageRegistryInstanceNameDuplicateRequest"/></param>
        /// <returns><see cref="CheckImageRegistryInstanceNameDuplicateResponse"/></returns>
        public Task<CheckImageRegistryInstanceNameDuplicateResponse> CheckImageRegistryInstanceNameDuplicate(CheckImageRegistryInstanceNameDuplicateRequest req)
        {
            return InternalRequestAsync<CheckImageRegistryInstanceNameDuplicateResponse>(req, "CheckImageRegistryInstanceNameDuplicate");
        }

        /// <summary>
        /// Check whether the image repository instance name is duplicate.
        /// </summary>
        /// <param name="req"><see cref="CheckImageRegistryInstanceNameDuplicateRequest"/></param>
        /// <returns><see cref="CheckImageRegistryInstanceNameDuplicateResponse"/></returns>
        public CheckImageRegistryInstanceNameDuplicateResponse CheckImageRegistryInstanceNameDuplicateSync(CheckImageRegistryInstanceNameDuplicateRequest req)
        {
            return InternalRequestAsync<CheckImageRegistryInstanceNameDuplicateResponse>(req, "CheckImageRegistryInstanceNameDuplicate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Determine whether the current user is on the flagship edition.
        /// </summary>
        /// <param name="req"><see cref="CheckIsUltimateVersionRequest"/></param>
        /// <returns><see cref="CheckIsUltimateVersionResponse"/></returns>
        public Task<CheckIsUltimateVersionResponse> CheckIsUltimateVersion(CheckIsUltimateVersionRequest req)
        {
            return InternalRequestAsync<CheckIsUltimateVersionResponse>(req, "CheckIsUltimateVersion");
        }

        /// <summary>
        /// Determine whether the current user is on the flagship edition.
        /// </summary>
        /// <param name="req"><see cref="CheckIsUltimateVersionRequest"/></param>
        /// <returns><see cref="CheckIsUltimateVersionResponse"/></returns>
        public CheckIsUltimateVersionResponse CheckIsUltimateVersionSync(CheckIsUltimateVersionRequest req)
        {
            return InternalRequestAsync<CheckIsUltimateVersionResponse>(req, "CheckIsUltimateVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Risk verification example
        /// </summary>
        /// <param name="req"><see cref="CheckRiskRequest"/></param>
        /// <returns><see cref="CheckRiskResponse"/></returns>
        public Task<CheckRiskResponse> CheckRisk(CheckRiskRequest req)
        {
            return InternalRequestAsync<CheckRiskResponse>(req, "CheckRisk");
        }

        /// <summary>
        /// Risk verification example
        /// </summary>
        /// <param name="req"><see cref="CheckRiskRequest"/></param>
        /// <returns><see cref="CheckRiskResponse"/></returns>
        public CheckRiskResponse CheckRiskSync(CheckRiskRequest req)
        {
            return InternalRequestAsync<CheckRiskResponse>(req, "CheckRisk")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Replicate a custom baseline policy.
        /// </summary>
        /// <param name="req"><see cref="CopyBaselinePolicyRequest"/></param>
        /// <returns><see cref="CopyBaselinePolicyResponse"/></returns>
        public Task<CopyBaselinePolicyResponse> CopyBaselinePolicy(CopyBaselinePolicyRequest req)
        {
            return InternalRequestAsync<CopyBaselinePolicyResponse>(req, "CopyBaselinePolicy");
        }

        /// <summary>
        /// Replicate a custom baseline policy.
        /// </summary>
        /// <param name="req"><see cref="CopyBaselinePolicyRequest"/></param>
        /// <returns><see cref="CopyBaselinePolicyResponse"/></returns>
        public CopyBaselinePolicyResponse CopyBaselinePolicySync(CopyBaselinePolicyRequest req)
        {
            return InternalRequestAsync<CopyBaselinePolicyResponse>(req, "CopyBaselinePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create an AI scheduled task.
        /// 
        /// Create an AI scheduled task by entering the task name, prompt content, and trigger configuration. The AI scheduled task ID will be returned after successful creation.
        /// </summary>
        /// <param name="req"><see cref="CreateAIScheduleRequest"/></param>
        /// <returns><see cref="CreateAIScheduleResponse"/></returns>
        public Task<CreateAIScheduleResponse> CreateAISchedule(CreateAIScheduleRequest req)
        {
            return InternalRequestAsync<CreateAIScheduleResponse>(req, "CreateAISchedule");
        }

        /// <summary>
        /// Create an AI scheduled task.
        /// 
        /// Create an AI scheduled task by entering the task name, prompt content, and trigger configuration. The AI scheduled task ID will be returned after successful creation.
        /// </summary>
        /// <param name="req"><see cref="CreateAIScheduleRequest"/></param>
        /// <returns><see cref="CreateAIScheduleResponse"/></returns>
        public CreateAIScheduleResponse CreateAIScheduleSync(CreateAIScheduleRequest req)
        {
            return InternalRequestAsync<CreateAIScheduleResponse>(req, "CreateAISchedule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Detect async tasks of AK
        /// </summary>
        /// <param name="req"><see cref="CreateAccessKeyCheckTaskRequest"/></param>
        /// <returns><see cref="CreateAccessKeyCheckTaskResponse"/></returns>
        public Task<CreateAccessKeyCheckTaskResponse> CreateAccessKeyCheckTask(CreateAccessKeyCheckTaskRequest req)
        {
            return InternalRequestAsync<CreateAccessKeyCheckTaskResponse>(req, "CreateAccessKeyCheckTask");
        }

        /// <summary>
        /// Detect async tasks of AK
        /// </summary>
        /// <param name="req"><see cref="CreateAccessKeyCheckTaskRequest"/></param>
        /// <returns><see cref="CreateAccessKeyCheckTaskResponse"/></returns>
        public CreateAccessKeyCheckTaskResponse CreateAccessKeyCheckTaskSync(CreateAccessKeyCheckTaskRequest req)
        {
            return InternalRequestAsync<CreateAccessKeyCheckTaskResponse>(req, "CreateAccessKeyCheckTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Trigger an AK asset sync task.
        /// </summary>
        /// <param name="req"><see cref="CreateAccessKeySyncTaskRequest"/></param>
        /// <returns><see cref="CreateAccessKeySyncTaskResponse"/></returns>
        public Task<CreateAccessKeySyncTaskResponse> CreateAccessKeySyncTask(CreateAccessKeySyncTaskRequest req)
        {
            return InternalRequestAsync<CreateAccessKeySyncTaskResponse>(req, "CreateAccessKeySyncTask");
        }

        /// <summary>
        /// Trigger an AK asset sync task.
        /// </summary>
        /// <param name="req"><see cref="CreateAccessKeySyncTaskRequest"/></param>
        /// <returns><see cref="CreateAccessKeySyncTaskResponse"/></returns>
        public CreateAccessKeySyncTaskResponse CreateAccessKeySyncTaskSync(CreateAccessKeySyncTaskRequest req)
        {
            return InternalRequestAsync<CreateAccessKeySyncTaskResponse>(req, "CreateAccessKeySyncTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Creates a task to export all assets.
        /// </summary>
        /// <param name="req"><see cref="CreateAllAssetsExportJobRequest"/></param>
        /// <returns><see cref="CreateAllAssetsExportJobResponse"/></returns>
        public Task<CreateAllAssetsExportJobResponse> CreateAllAssetsExportJob(CreateAllAssetsExportJobRequest req)
        {
            return InternalRequestAsync<CreateAllAssetsExportJobResponse>(req, "CreateAllAssetsExportJob");
        }

        /// <summary>
        /// Creates a task to export all assets.
        /// </summary>
        /// <param name="req"><see cref="CreateAllAssetsExportJobRequest"/></param>
        /// <returns><see cref="CreateAllAssetsExportJobResponse"/></returns>
        public CreateAllAssetsExportJobResponse CreateAllAssetsExportJobSync(CreateAllAssetsExportJobRequest req)
        {
            return InternalRequestAsync<CreateAllAssetsExportJobResponse>(req, "CreateAllAssetsExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Creates a component list export task for image assets.
        /// </summary>
        /// <param name="req"><see cref="CreateAssetComponentListExportJobRequest"/></param>
        /// <returns><see cref="CreateAssetComponentListExportJobResponse"/></returns>
        public Task<CreateAssetComponentListExportJobResponse> CreateAssetComponentListExportJob(CreateAssetComponentListExportJobRequest req)
        {
            return InternalRequestAsync<CreateAssetComponentListExportJobResponse>(req, "CreateAssetComponentListExportJob");
        }

        /// <summary>
        /// Creates a component list export task for image assets.
        /// </summary>
        /// <param name="req"><see cref="CreateAssetComponentListExportJobRequest"/></param>
        /// <returns><see cref="CreateAssetComponentListExportJobResponse"/></returns>
        public CreateAssetComponentListExportJobResponse CreateAssetComponentListExportJobSync(CreateAssetComponentListExportJobRequest req)
        {
            return InternalRequestAsync<CreateAssetComponentListExportJobResponse>(req, "CreateAssetComponentListExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a mirror repository component associated image list export task.
        /// </summary>
        /// <param name="req"><see cref="CreateAssetComponentRelatedImageListExportJobRequest"/></param>
        /// <returns><see cref="CreateAssetComponentRelatedImageListExportJobResponse"/></returns>
        public Task<CreateAssetComponentRelatedImageListExportJobResponse> CreateAssetComponentRelatedImageListExportJob(CreateAssetComponentRelatedImageListExportJobRequest req)
        {
            return InternalRequestAsync<CreateAssetComponentRelatedImageListExportJobResponse>(req, "CreateAssetComponentRelatedImageListExportJob");
        }

        /// <summary>
        /// Create a mirror repository component associated image list export task.
        /// </summary>
        /// <param name="req"><see cref="CreateAssetComponentRelatedImageListExportJobRequest"/></param>
        /// <returns><see cref="CreateAssetComponentRelatedImageListExportJobResponse"/></returns>
        public CreateAssetComponentRelatedImageListExportJobResponse CreateAssetComponentRelatedImageListExportJobSync(CreateAssetComponentRelatedImageListExportJobRequest req)
        {
            return InternalRequestAsync<CreateAssetComponentRelatedImageListExportJobResponse>(req, "CreateAssetComponentRelatedImageListExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create an asset search view.
        /// </summary>
        /// <param name="req"><see cref="CreateAssetFilterViewRequest"/></param>
        /// <returns><see cref="CreateAssetFilterViewResponse"/></returns>
        public Task<CreateAssetFilterViewResponse> CreateAssetFilterView(CreateAssetFilterViewRequest req)
        {
            return InternalRequestAsync<CreateAssetFilterViewResponse>(req, "CreateAssetFilterView");
        }

        /// <summary>
        /// Create an asset search view.
        /// </summary>
        /// <param name="req"><see cref="CreateAssetFilterViewRequest"/></param>
        /// <returns><see cref="CreateAssetFilterViewResponse"/></returns>
        public CreateAssetFilterViewResponse CreateAssetFilterViewSync(CreateAssetFilterViewRequest req)
        {
            return InternalRequestAsync<CreateAssetFilterViewResponse>(req, "CreateAssetFilterView")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a host process list export task
        /// </summary>
        /// <param name="req"><see cref="CreateAssetProcessExportJobRequest"/></param>
        /// <returns><see cref="CreateAssetProcessExportJobResponse"/></returns>
        public Task<CreateAssetProcessExportJobResponse> CreateAssetProcessExportJob(CreateAssetProcessExportJobRequest req)
        {
            return InternalRequestAsync<CreateAssetProcessExportJobResponse>(req, "CreateAssetProcessExportJob");
        }

        /// <summary>
        /// Create a host process list export task
        /// </summary>
        /// <param name="req"><see cref="CreateAssetProcessExportJobRequest"/></param>
        /// <returns><see cref="CreateAssetProcessExportJobResponse"/></returns>
        public CreateAssetProcessExportJobResponse CreateAssetProcessExportJobSync(CreateAssetProcessExportJobRequest req)
        {
            return InternalRequestAsync<CreateAssetProcessExportJobResponse>(req, "CreateAssetProcessExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an asset sync task.
        /// </summary>
        /// <param name="req"><see cref="CreateAssetSyncTaskRequest"/></param>
        /// <returns><see cref="CreateAssetSyncTaskResponse"/></returns>
        public Task<CreateAssetSyncTaskResponse> CreateAssetSyncTask(CreateAssetSyncTaskRequest req)
        {
            return InternalRequestAsync<CreateAssetSyncTaskResponse>(req, "CreateAssetSyncTask");
        }

        /// <summary>
        /// This API is used to create an asset sync task.
        /// </summary>
        /// <param name="req"><see cref="CreateAssetSyncTaskRequest"/></param>
        /// <returns><see cref="CreateAssetSyncTaskResponse"/></returns>
        public CreateAssetSyncTaskResponse CreateAssetSyncTaskSync(CreateAssetSyncTaskRequest req)
        {
            return InternalRequestAsync<CreateAssetSyncTaskResponse>(req, "CreateAssetSyncTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create an asset tag.
        /// </summary>
        /// <param name="req"><see cref="CreateAssetTagRequest"/></param>
        /// <returns><see cref="CreateAssetTagResponse"/></returns>
        public Task<CreateAssetTagResponse> CreateAssetTag(CreateAssetTagRequest req)
        {
            return InternalRequestAsync<CreateAssetTagResponse>(req, "CreateAssetTag");
        }

        /// <summary>
        /// Create an asset tag.
        /// </summary>
        /// <param name="req"><see cref="CreateAssetTagRequest"/></param>
        /// <returns><see cref="CreateAssetTagResponse"/></returns>
        public CreateAssetTagResponse CreateAssetTagSync(CreateAssetTagRequest req)
        {
            return InternalRequestAsync<CreateAssetTagResponse>(req, "CreateAssetTag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a sample risk list export task from the asset perspective
        /// </summary>
        /// <param name="req"><see cref="CreateAssetViewRisksExportJobRequest"/></param>
        /// <returns><see cref="CreateAssetViewRisksExportJobResponse"/></returns>
        public Task<CreateAssetViewRisksExportJobResponse> CreateAssetViewRisksExportJob(CreateAssetViewRisksExportJobRequest req)
        {
            return InternalRequestAsync<CreateAssetViewRisksExportJobResponse>(req, "CreateAssetViewRisksExportJob");
        }

        /// <summary>
        /// Create a sample risk list export task from the asset perspective
        /// </summary>
        /// <param name="req"><see cref="CreateAssetViewRisksExportJobRequest"/></param>
        /// <returns><see cref="CreateAssetViewRisksExportJobResponse"/></returns>
        public CreateAssetViewRisksExportJobResponse CreateAssetViewRisksExportJobSync(CreateAssetViewRisksExportJobRequest req)
        {
            return InternalRequestAsync<CreateAssetViewRisksExportJobResponse>(req, "CreateAssetViewRisksExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a baseline aggregation detection item export task. Use ExportType to select exporting statistics or risk details. You can limit the range by conditions such as policy and category. The task executes asynchronously in the backend. Once completed, you can download the result file from the export task list.
        /// </summary>
        /// <param name="req"><see cref="CreateBaselineAggregatedItemExportJobRequest"/></param>
        /// <returns><see cref="CreateBaselineAggregatedItemExportJobResponse"/></returns>
        public Task<CreateBaselineAggregatedItemExportJobResponse> CreateBaselineAggregatedItemExportJob(CreateBaselineAggregatedItemExportJobRequest req)
        {
            return InternalRequestAsync<CreateBaselineAggregatedItemExportJobResponse>(req, "CreateBaselineAggregatedItemExportJob");
        }

        /// <summary>
        /// Create a baseline aggregation detection item export task. Use ExportType to select exporting statistics or risk details. You can limit the range by conditions such as policy and category. The task executes asynchronously in the backend. Once completed, you can download the result file from the export task list.
        /// </summary>
        /// <param name="req"><see cref="CreateBaselineAggregatedItemExportJobRequest"/></param>
        /// <returns><see cref="CreateBaselineAggregatedItemExportJobResponse"/></returns>
        public CreateBaselineAggregatedItemExportJobResponse CreateBaselineAggregatedItemExportJobSync(CreateBaselineAggregatedItemExportJobRequest req)
        {
            return InternalRequestAsync<CreateBaselineAggregatedItemExportJobResponse>(req, "CreateBaselineAggregatedItemExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a baseline fix record export task to export the records of fixed detection items, including detection item information, asset information, and repair time. The task executes asynchronously in the backend. Once completed, the result file can be downloaded from the export task list.
        /// </summary>
        /// <param name="req"><see cref="CreateBaselineFixRecordExportJobRequest"/></param>
        /// <returns><see cref="CreateBaselineFixRecordExportJobResponse"/></returns>
        public Task<CreateBaselineFixRecordExportJobResponse> CreateBaselineFixRecordExportJob(CreateBaselineFixRecordExportJobRequest req)
        {
            return InternalRequestAsync<CreateBaselineFixRecordExportJobResponse>(req, "CreateBaselineFixRecordExportJob");
        }

        /// <summary>
        /// This API is used to create a baseline fix record export task to export the records of fixed detection items, including detection item information, asset information, and repair time. The task executes asynchronously in the backend. Once completed, the result file can be downloaded from the export task list.
        /// </summary>
        /// <param name="req"><see cref="CreateBaselineFixRecordExportJobRequest"/></param>
        /// <returns><see cref="CreateBaselineFixRecordExportJobResponse"/></returns>
        public CreateBaselineFixRecordExportJobResponse CreateBaselineFixRecordExportJobSync(CreateBaselineFixRecordExportJobRequest req)
        {
            return InternalRequestAsync<CreateBaselineFixRecordExportJobResponse>(req, "CreateBaselineFixRecordExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a baseline main task export task to export detection items and subtask data under the specified main task. The task executes asynchronously in the backend. Once completed, the result file can be downloaded in the export task list.
        /// </summary>
        /// <param name="req"><see cref="CreateBaselineMainTaskExportJobRequest"/></param>
        /// <returns><see cref="CreateBaselineMainTaskExportJobResponse"/></returns>
        public Task<CreateBaselineMainTaskExportJobResponse> CreateBaselineMainTaskExportJob(CreateBaselineMainTaskExportJobRequest req)
        {
            return InternalRequestAsync<CreateBaselineMainTaskExportJobResponse>(req, "CreateBaselineMainTaskExportJob");
        }

        /// <summary>
        /// Create a baseline main task export task to export detection items and subtask data under the specified main task. The task executes asynchronously in the backend. Once completed, the result file can be downloaded in the export task list.
        /// </summary>
        /// <param name="req"><see cref="CreateBaselineMainTaskExportJobRequest"/></param>
        /// <returns><see cref="CreateBaselineMainTaskExportJobResponse"/></returns>
        public CreateBaselineMainTaskExportJobResponse CreateBaselineMainTaskExportJobSync(CreateBaselineMainTaskExportJobRequest req)
        {
            return InternalRequestAsync<CreateBaselineMainTaskExportJobResponse>(req, "CreateBaselineMainTaskExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Example of creating an export task for a cloud resource configuration detection PDF report.
        /// </summary>
        /// <param name="req"><see cref="CreateCFGRiskPDFReportExportJobRequest"/></param>
        /// <returns><see cref="CreateCFGRiskPDFReportExportJobResponse"/></returns>
        public Task<CreateCFGRiskPDFReportExportJobResponse> CreateCFGRiskPDFReportExportJob(CreateCFGRiskPDFReportExportJobRequest req)
        {
            return InternalRequestAsync<CreateCFGRiskPDFReportExportJobResponse>(req, "CreateCFGRiskPDFReportExportJob");
        }

        /// <summary>
        /// Example of creating an export task for a cloud resource configuration detection PDF report.
        /// </summary>
        /// <param name="req"><see cref="CreateCFGRiskPDFReportExportJobRequest"/></param>
        /// <returns><see cref="CreateCFGRiskPDFReportExportJobResponse"/></returns>
        public CreateCFGRiskPDFReportExportJobResponse CreateCFGRiskPDFReportExportJobSync(CreateCFGRiskPDFReportExportJobRequest req)
        {
            return InternalRequestAsync<CreateCFGRiskPDFReportExportJobResponse>(req, "CreateCFGRiskPDFReportExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Example of creating an asset perspective risk list export task
        /// </summary>
        /// <param name="req"><see cref="CreateCFGRisksExportJobRequest"/></param>
        /// <returns><see cref="CreateCFGRisksExportJobResponse"/></returns>
        public Task<CreateCFGRisksExportJobResponse> CreateCFGRisksExportJob(CreateCFGRisksExportJobRequest req)
        {
            return InternalRequestAsync<CreateCFGRisksExportJobResponse>(req, "CreateCFGRisksExportJob");
        }

        /// <summary>
        /// Example of creating an asset perspective risk list export task
        /// </summary>
        /// <param name="req"><see cref="CreateCFGRisksExportJobRequest"/></param>
        /// <returns><see cref="CreateCFGRisksExportJobResponse"/></returns>
        public CreateCFGRisksExportJobResponse CreateCFGRisksExportJobSync(CreateCFGRisksExportJobRequest req)
        {
            return InternalRequestAsync<CreateCFGRisksExportJobResponse>(req, "CreateCFGRisksExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a CSIP manual scan.
        /// </summary>
        /// <param name="req"><see cref="CreateCSIPManualMalwareScanRequest"/></param>
        /// <returns><see cref="CreateCSIPManualMalwareScanResponse"/></returns>
        public Task<CreateCSIPManualMalwareScanResponse> CreateCSIPManualMalwareScan(CreateCSIPManualMalwareScanRequest req)
        {
            return InternalRequestAsync<CreateCSIPManualMalwareScanResponse>(req, "CreateCSIPManualMalwareScan");
        }

        /// <summary>
        /// This API is used to create a CSIP manual scan.
        /// </summary>
        /// <param name="req"><see cref="CreateCSIPManualMalwareScanRequest"/></param>
        /// <returns><see cref="CreateCSIPManualMalwareScanResponse"/></returns>
        public CreateCSIPManualMalwareScanResponse CreateCSIPManualMalwareScanSync(CreateCSIPManualMalwareScanRequest req)
        {
            return InternalRequestAsync<CreateCSIPManualMalwareScanResponse>(req, "CreateCSIPManualMalwareScan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a sample risk list export task from the asset perspective
        /// </summary>
        /// <param name="req"><see cref="CreateCheckViewRisksExportJobRequest"/></param>
        /// <returns><see cref="CreateCheckViewRisksExportJobResponse"/></returns>
        public Task<CreateCheckViewRisksExportJobResponse> CreateCheckViewRisksExportJob(CreateCheckViewRisksExportJobRequest req)
        {
            return InternalRequestAsync<CreateCheckViewRisksExportJobResponse>(req, "CreateCheckViewRisksExportJob");
        }

        /// <summary>
        /// Create a sample risk list export task from the asset perspective
        /// </summary>
        /// <param name="req"><see cref="CreateCheckViewRisksExportJobRequest"/></param>
        /// <returns><see cref="CreateCheckViewRisksExportJobResponse"/></returns>
        public CreateCheckViewRisksExportJobResponse CreateCheckViewRisksExportJobSync(CreateCheckViewRisksExportJobRequest req)
        {
            return InternalRequestAsync<CreateCheckViewRisksExportJobResponse>(req, "CreateCheckViewRisksExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an SCF export task.
        /// </summary>
        /// <param name="req"><see cref="CreateCloudFunctionExportJobRequest"/></param>
        /// <returns><see cref="CreateCloudFunctionExportJobResponse"/></returns>
        public Task<CreateCloudFunctionExportJobResponse> CreateCloudFunctionExportJob(CreateCloudFunctionExportJobRequest req)
        {
            return InternalRequestAsync<CreateCloudFunctionExportJobResponse>(req, "CreateCloudFunctionExportJob");
        }

        /// <summary>
        /// This API is used to create an SCF export task.
        /// </summary>
        /// <param name="req"><see cref="CreateCloudFunctionExportJobRequest"/></param>
        /// <returns><see cref="CreateCloudFunctionExportJobResponse"/></returns>
        public CreateCloudFunctionExportJobResponse CreateCloudFunctionExportJobSync(CreateCloudFunctionExportJobRequest req)
        {
            return InternalRequestAsync<CreateCloudFunctionExportJobResponse>(req, "CreateCloudFunctionExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a cluster asset sync task.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterAssetSyncTaskRequest"/></param>
        /// <returns><see cref="CreateClusterAssetSyncTaskResponse"/></returns>
        public Task<CreateClusterAssetSyncTaskResponse> CreateClusterAssetSyncTask(CreateClusterAssetSyncTaskRequest req)
        {
            return InternalRequestAsync<CreateClusterAssetSyncTaskResponse>(req, "CreateClusterAssetSyncTask");
        }

        /// <summary>
        /// This API is used to create a cluster asset sync task.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterAssetSyncTaskRequest"/></param>
        /// <returns><see cref="CreateClusterAssetSyncTaskResponse"/></returns>
        public CreateClusterAssetSyncTaskResponse CreateClusterAssetSyncTaskSync(CreateClusterAssetSyncTaskRequest req)
        {
            return InternalRequestAsync<CreateClusterAssetSyncTaskResponse>(req, "CreateClusterAssetSyncTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Creates a cluster container list export task
        /// </summary>
        /// <param name="req"><see cref="CreateClusterContainerListExportJobRequest"/></param>
        /// <returns><see cref="CreateClusterContainerListExportJobResponse"/></returns>
        public Task<CreateClusterContainerListExportJobResponse> CreateClusterContainerListExportJob(CreateClusterContainerListExportJobRequest req)
        {
            return InternalRequestAsync<CreateClusterContainerListExportJobResponse>(req, "CreateClusterContainerListExportJob");
        }

        /// <summary>
        /// Creates a cluster container list export task
        /// </summary>
        /// <param name="req"><see cref="CreateClusterContainerListExportJobRequest"/></param>
        /// <returns><see cref="CreateClusterContainerListExportJobResponse"/></returns>
        public CreateClusterContainerListExportJobResponse CreateClusterContainerListExportJobSync(CreateClusterContainerListExportJobRequest req)
        {
            return InternalRequestAsync<CreateClusterContainerListExportJobResponse>(req, "CreateClusterContainerListExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a cluster list export task
        /// </summary>
        /// <param name="req"><see cref="CreateClusterListExportJobRequest"/></param>
        /// <returns><see cref="CreateClusterListExportJobResponse"/></returns>
        public Task<CreateClusterListExportJobResponse> CreateClusterListExportJob(CreateClusterListExportJobRequest req)
        {
            return InternalRequestAsync<CreateClusterListExportJobResponse>(req, "CreateClusterListExportJob");
        }

        /// <summary>
        /// Create a cluster list export task
        /// </summary>
        /// <param name="req"><see cref="CreateClusterListExportJobRequest"/></param>
        /// <returns><see cref="CreateClusterListExportJobResponse"/></returns>
        public CreateClusterListExportJobResponse CreateClusterListExportJobSync(CreateClusterListExportJobRequest req)
        {
            return InternalRequestAsync<CreateClusterListExportJobResponse>(req, "CreateClusterListExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Creates a cluster namespace list export task. The export fields include namespace name, Labels, and creation time. Filter filtering is supported. Export is implemented through an async task. After JobId is returned, the frontend polls to query the export task status.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterNamespaceListExportJobRequest"/></param>
        /// <returns><see cref="CreateClusterNamespaceListExportJobResponse"/></returns>
        public Task<CreateClusterNamespaceListExportJobResponse> CreateClusterNamespaceListExportJob(CreateClusterNamespaceListExportJobRequest req)
        {
            return InternalRequestAsync<CreateClusterNamespaceListExportJobResponse>(req, "CreateClusterNamespaceListExportJob");
        }

        /// <summary>
        /// Creates a cluster namespace list export task. The export fields include namespace name, Labels, and creation time. Filter filtering is supported. Export is implemented through an async task. After JobId is returned, the frontend polls to query the export task status.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterNamespaceListExportJobRequest"/></param>
        /// <returns><see cref="CreateClusterNamespaceListExportJobResponse"/></returns>
        public CreateClusterNamespaceListExportJobResponse CreateClusterNamespaceListExportJobSync(CreateClusterNamespaceListExportJobRequest req)
        {
            return InternalRequestAsync<CreateClusterNamespaceListExportJobResponse>(req, "CreateClusterNamespaceListExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a cluster node list export task. The export fields include node ID, node name, public IP address, private IP address, node type, cores, client status, and running state. NodeType, ClientStatus, and RunStatus are internationalized. Filter filtering is supported, including ClientStatus memory filtering. Export is implemented through an async task. After JobId is returned, the frontend polls to query the export task status.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterNodeListExportJobRequest"/></param>
        /// <returns><see cref="CreateClusterNodeListExportJobResponse"/></returns>
        public Task<CreateClusterNodeListExportJobResponse> CreateClusterNodeListExportJob(CreateClusterNodeListExportJobRequest req)
        {
            return InternalRequestAsync<CreateClusterNodeListExportJobResponse>(req, "CreateClusterNodeListExportJob");
        }

        /// <summary>
        /// This API is used to create a cluster node list export task. The export fields include node ID, node name, public IP address, private IP address, node type, cores, client status, and running state. NodeType, ClientStatus, and RunStatus are internationalized. Filter filtering is supported, including ClientStatus memory filtering. Export is implemented through an async task. After JobId is returned, the frontend polls to query the export task status.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterNodeListExportJobRequest"/></param>
        /// <returns><see cref="CreateClusterNodeListExportJobResponse"/></returns>
        public CreateClusterNodeListExportJobResponse CreateClusterNodeListExportJobSync(CreateClusterNodeListExportJobRequest req)
        {
            return InternalRequestAsync<CreateClusterNodeListExportJobResponse>(req, "CreateClusterNodeListExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Example of creating a risk list export task from a compliance standard aggregation perspective
        /// </summary>
        /// <param name="req"><see cref="CreateComplianceRiskExportJobRequest"/></param>
        /// <returns><see cref="CreateComplianceRiskExportJobResponse"/></returns>
        public Task<CreateComplianceRiskExportJobResponse> CreateComplianceRiskExportJob(CreateComplianceRiskExportJobRequest req)
        {
            return InternalRequestAsync<CreateComplianceRiskExportJobResponse>(req, "CreateComplianceRiskExportJob");
        }

        /// <summary>
        /// Example of creating a risk list export task from a compliance standard aggregation perspective
        /// </summary>
        /// <param name="req"><see cref="CreateComplianceRiskExportJobRequest"/></param>
        /// <returns><see cref="CreateComplianceRiskExportJobResponse"/></returns>
        public CreateComplianceRiskExportJobResponse CreateComplianceRiskExportJobSync(CreateComplianceRiskExportJobRequest req)
        {
            return InternalRequestAsync<CreateComplianceRiskExportJobResponse>(req, "CreateComplianceRiskExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create Domain and IP Information
        /// </summary>
        /// <param name="req"><see cref="CreateDomainAndIpRequest"/></param>
        /// <returns><see cref="CreateDomainAndIpResponse"/></returns>
        public Task<CreateDomainAndIpResponse> CreateDomainAndIp(CreateDomainAndIpRequest req)
        {
            return InternalRequestAsync<CreateDomainAndIpResponse>(req, "CreateDomainAndIp");
        }

        /// <summary>
        /// Create Domain and IP Information
        /// </summary>
        /// <param name="req"><see cref="CreateDomainAndIpRequest"/></param>
        /// <returns><see cref="CreateDomainAndIpResponse"/></returns>
        public CreateDomainAndIpResponse CreateDomainAndIpSync(CreateDomainAndIpRequest req)
        {
            return InternalRequestAsync<CreateDomainAndIpResponse>(req, "CreateDomainAndIp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Creates a Dspm access record export task
        /// </summary>
        /// <param name="req"><see cref="CreateDspmAccessExportJobRequest"/></param>
        /// <returns><see cref="CreateDspmAccessExportJobResponse"/></returns>
        public Task<CreateDspmAccessExportJobResponse> CreateDspmAccessExportJob(CreateDspmAccessExportJobRequest req)
        {
            return InternalRequestAsync<CreateDspmAccessExportJobResponse>(req, "CreateDspmAccessExportJob");
        }

        /// <summary>
        /// Creates a Dspm access record export task
        /// </summary>
        /// <param name="req"><see cref="CreateDspmAccessExportJobRequest"/></param>
        /// <returns><see cref="CreateDspmAccessExportJobResponse"/></returns>
        public CreateDspmAccessExportJobResponse CreateDspmAccessExportJobSync(CreateDspmAccessExportJobRequest req)
        {
            return InternalRequestAsync<CreateDspmAccessExportJobResponse>(req, "CreateDspmAccessExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a Dspm application.
        /// </summary>
        /// <param name="req"><see cref="CreateDspmApplyOrderRequest"/></param>
        /// <returns><see cref="CreateDspmApplyOrderResponse"/></returns>
        public Task<CreateDspmApplyOrderResponse> CreateDspmApplyOrder(CreateDspmApplyOrderRequest req)
        {
            return InternalRequestAsync<CreateDspmApplyOrderResponse>(req, "CreateDspmApplyOrder");
        }

        /// <summary>
        /// This API is used to create a Dspm application.
        /// </summary>
        /// <param name="req"><see cref="CreateDspmApplyOrderRequest"/></param>
        /// <returns><see cref="CreateDspmApplyOrderResponse"/></returns>
        public CreateDspmApplyOrderResponse CreateDspmApplyOrderSync(CreateDspmApplyOrderRequest req)
        {
            return InternalRequestAsync<CreateDspmApplyOrderResponse>(req, "CreateDspmApplyOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Creates a Dspm approval history export task
        /// </summary>
        /// <param name="req"><see cref="CreateDspmApproveHistoryExportJobRequest"/></param>
        /// <returns><see cref="CreateDspmApproveHistoryExportJobResponse"/></returns>
        public Task<CreateDspmApproveHistoryExportJobResponse> CreateDspmApproveHistoryExportJob(CreateDspmApproveHistoryExportJobRequest req)
        {
            return InternalRequestAsync<CreateDspmApproveHistoryExportJobResponse>(req, "CreateDspmApproveHistoryExportJob");
        }

        /// <summary>
        /// Creates a Dspm approval history export task
        /// </summary>
        /// <param name="req"><see cref="CreateDspmApproveHistoryExportJobRequest"/></param>
        /// <returns><see cref="CreateDspmApproveHistoryExportJobResponse"/></returns>
        public CreateDspmApproveHistoryExportJobResponse CreateDspmApproveHistoryExportJobSync(CreateDspmApproveHistoryExportJobRequest req)
        {
            return InternalRequestAsync<CreateDspmApproveHistoryExportJobResponse>(req, "CreateDspmApproveHistoryExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a Dspm asset access topology export task.
        /// </summary>
        /// <param name="req"><see cref="CreateDspmAssetAccessTopologyExportJobRequest"/></param>
        /// <returns><see cref="CreateDspmAssetAccessTopologyExportJobResponse"/></returns>
        public Task<CreateDspmAssetAccessTopologyExportJobResponse> CreateDspmAssetAccessTopologyExportJob(CreateDspmAssetAccessTopologyExportJobRequest req)
        {
            return InternalRequestAsync<CreateDspmAssetAccessTopologyExportJobResponse>(req, "CreateDspmAssetAccessTopologyExportJob");
        }

        /// <summary>
        /// This API is used to create a Dspm asset access topology export task.
        /// </summary>
        /// <param name="req"><see cref="CreateDspmAssetAccessTopologyExportJobRequest"/></param>
        /// <returns><see cref="CreateDspmAssetAccessTopologyExportJobResponse"/></returns>
        public CreateDspmAssetAccessTopologyExportJobResponse CreateDspmAssetAccessTopologyExportJobSync(CreateDspmAssetAccessTopologyExportJobRequest req)
        {
            return InternalRequestAsync<CreateDspmAssetAccessTopologyExportJobResponse>(req, "CreateDspmAssetAccessTopologyExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create an asset list export task for Dspm.
        /// </summary>
        /// <param name="req"><see cref="CreateDspmAssetIdentifyInfoExportJobRequest"/></param>
        /// <returns><see cref="CreateDspmAssetIdentifyInfoExportJobResponse"/></returns>
        public Task<CreateDspmAssetIdentifyInfoExportJobResponse> CreateDspmAssetIdentifyInfoExportJob(CreateDspmAssetIdentifyInfoExportJobRequest req)
        {
            return InternalRequestAsync<CreateDspmAssetIdentifyInfoExportJobResponse>(req, "CreateDspmAssetIdentifyInfoExportJob");
        }

        /// <summary>
        /// Create an asset list export task for Dspm.
        /// </summary>
        /// <param name="req"><see cref="CreateDspmAssetIdentifyInfoExportJobRequest"/></param>
        /// <returns><see cref="CreateDspmAssetIdentifyInfoExportJobResponse"/></returns>
        public CreateDspmAssetIdentifyInfoExportJobResponse CreateDspmAssetIdentifyInfoExportJobSync(CreateDspmAssetIdentifyInfoExportJobRequest req)
        {
            return InternalRequestAsync<CreateDspmAssetIdentifyInfoExportJobResponse>(req, "CreateDspmAssetIdentifyInfoExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Creates a Dspm asset list export task
        /// </summary>
        /// <param name="req"><see cref="CreateDspmAssetsExportJobRequest"/></param>
        /// <returns><see cref="CreateDspmAssetsExportJobResponse"/></returns>
        public Task<CreateDspmAssetsExportJobResponse> CreateDspmAssetsExportJob(CreateDspmAssetsExportJobRequest req)
        {
            return InternalRequestAsync<CreateDspmAssetsExportJobResponse>(req, "CreateDspmAssetsExportJob");
        }

        /// <summary>
        /// Creates a Dspm asset list export task
        /// </summary>
        /// <param name="req"><see cref="CreateDspmAssetsExportJobRequest"/></param>
        /// <returns><see cref="CreateDspmAssetsExportJobResponse"/></returns>
        public CreateDspmAssetsExportJobResponse CreateDspmAssetsExportJobSync(CreateDspmAssetsExportJobRequest req)
        {
            return InternalRequestAsync<CreateDspmAssetsExportJobResponse>(req, "CreateDspmAssetsExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a Dspm audit filter policy.
        /// </summary>
        /// <param name="req"><see cref="CreateDspmAuditFilterStrategyRequest"/></param>
        /// <returns><see cref="CreateDspmAuditFilterStrategyResponse"/></returns>
        public Task<CreateDspmAuditFilterStrategyResponse> CreateDspmAuditFilterStrategy(CreateDspmAuditFilterStrategyRequest req)
        {
            return InternalRequestAsync<CreateDspmAuditFilterStrategyResponse>(req, "CreateDspmAuditFilterStrategy");
        }

        /// <summary>
        /// This API is used to create a Dspm audit filter policy.
        /// </summary>
        /// <param name="req"><see cref="CreateDspmAuditFilterStrategyRequest"/></param>
        /// <returns><see cref="CreateDspmAuditFilterStrategyResponse"/></returns>
        public CreateDspmAuditFilterStrategyResponse CreateDspmAuditFilterStrategySync(CreateDspmAuditFilterStrategyRequest req)
        {
            return InternalRequestAsync<CreateDspmAuditFilterStrategyResponse>(req, "CreateDspmAuditFilterStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create log export tasks.
        /// </summary>
        /// <param name="req"><see cref="CreateDspmExportTaskRequest"/></param>
        /// <returns><see cref="CreateDspmExportTaskResponse"/></returns>
        public Task<CreateDspmExportTaskResponse> CreateDspmExportTask(CreateDspmExportTaskRequest req)
        {
            return InternalRequestAsync<CreateDspmExportTaskResponse>(req, "CreateDspmExportTask");
        }

        /// <summary>
        /// This API is used to create log export tasks.
        /// </summary>
        /// <param name="req"><see cref="CreateDspmExportTaskRequest"/></param>
        /// <returns><see cref="CreateDspmExportTaskResponse"/></returns>
        public CreateDspmExportTaskResponse CreateDspmExportTaskSync(CreateDspmExportTaskRequest req)
        {
            return InternalRequestAsync<CreateDspmExportTaskResponse>(req, "CreateDspmExportTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a dspm data identification category.
        /// </summary>
        /// <param name="req"><see cref="CreateDspmIdentifyCategoryRequest"/></param>
        /// <returns><see cref="CreateDspmIdentifyCategoryResponse"/></returns>
        public Task<CreateDspmIdentifyCategoryResponse> CreateDspmIdentifyCategory(CreateDspmIdentifyCategoryRequest req)
        {
            return InternalRequestAsync<CreateDspmIdentifyCategoryResponse>(req, "CreateDspmIdentifyCategory");
        }

        /// <summary>
        /// This API is used to create a dspm data identification category.
        /// </summary>
        /// <param name="req"><see cref="CreateDspmIdentifyCategoryRequest"/></param>
        /// <returns><see cref="CreateDspmIdentifyCategoryResponse"/></returns>
        public CreateDspmIdentifyCategoryResponse CreateDspmIdentifyCategorySync(CreateDspmIdentifyCategoryRequest req)
        {
            return InternalRequestAsync<CreateDspmIdentifyCategoryResponse>(req, "CreateDspmIdentifyCategory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a dspm data identification template category association.
        /// </summary>
        /// <param name="req"><see cref="CreateDspmIdentifyComplianceCategoryRelationRequest"/></param>
        /// <returns><see cref="CreateDspmIdentifyComplianceCategoryRelationResponse"/></returns>
        public Task<CreateDspmIdentifyComplianceCategoryRelationResponse> CreateDspmIdentifyComplianceCategoryRelation(CreateDspmIdentifyComplianceCategoryRelationRequest req)
        {
            return InternalRequestAsync<CreateDspmIdentifyComplianceCategoryRelationResponse>(req, "CreateDspmIdentifyComplianceCategoryRelation");
        }

        /// <summary>
        /// This API is used to create a dspm data identification template category association.
        /// </summary>
        /// <param name="req"><see cref="CreateDspmIdentifyComplianceCategoryRelationRequest"/></param>
        /// <returns><see cref="CreateDspmIdentifyComplianceCategoryRelationResponse"/></returns>
        public CreateDspmIdentifyComplianceCategoryRelationResponse CreateDspmIdentifyComplianceCategoryRelationSync(CreateDspmIdentifyComplianceCategoryRelationRequest req)
        {
            return InternalRequestAsync<CreateDspmIdentifyComplianceCategoryRelationResponse>(req, "CreateDspmIdentifyComplianceCategoryRelation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a dspm data identification template.
        /// </summary>
        /// <param name="req"><see cref="CreateDspmIdentifyComplianceGroupRequest"/></param>
        /// <returns><see cref="CreateDspmIdentifyComplianceGroupResponse"/></returns>
        public Task<CreateDspmIdentifyComplianceGroupResponse> CreateDspmIdentifyComplianceGroup(CreateDspmIdentifyComplianceGroupRequest req)
        {
            return InternalRequestAsync<CreateDspmIdentifyComplianceGroupResponse>(req, "CreateDspmIdentifyComplianceGroup");
        }

        /// <summary>
        /// This API is used to create a dspm data identification template.
        /// </summary>
        /// <param name="req"><see cref="CreateDspmIdentifyComplianceGroupRequest"/></param>
        /// <returns><see cref="CreateDspmIdentifyComplianceGroupResponse"/></returns>
        public CreateDspmIdentifyComplianceGroupResponse CreateDspmIdentifyComplianceGroupSync(CreateDspmIdentifyComplianceGroupRequest req)
        {
            return InternalRequestAsync<CreateDspmIdentifyComplianceGroupResponse>(req, "CreateDspmIdentifyComplianceGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Replicate a dspm data identification template.
        /// </summary>
        /// <param name="req"><see cref="CreateDspmIdentifyComplianceGroupCopyRequest"/></param>
        /// <returns><see cref="CreateDspmIdentifyComplianceGroupCopyResponse"/></returns>
        public Task<CreateDspmIdentifyComplianceGroupCopyResponse> CreateDspmIdentifyComplianceGroupCopy(CreateDspmIdentifyComplianceGroupCopyRequest req)
        {
            return InternalRequestAsync<CreateDspmIdentifyComplianceGroupCopyResponse>(req, "CreateDspmIdentifyComplianceGroupCopy");
        }

        /// <summary>
        /// Replicate a dspm data identification template.
        /// </summary>
        /// <param name="req"><see cref="CreateDspmIdentifyComplianceGroupCopyRequest"/></param>
        /// <returns><see cref="CreateDspmIdentifyComplianceGroupCopyResponse"/></returns>
        public CreateDspmIdentifyComplianceGroupCopyResponse CreateDspmIdentifyComplianceGroupCopySync(CreateDspmIdentifyComplianceGroupCopyRequest req)
        {
            return InternalRequestAsync<CreateDspmIdentifyComplianceGroupCopyResponse>(req, "CreateDspmIdentifyComplianceGroupCopy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Creates a dspm data identification template data item association
        /// </summary>
        /// <param name="req"><see cref="CreateDspmIdentifyComplianceRuleRelationRequest"/></param>
        /// <returns><see cref="CreateDspmIdentifyComplianceRuleRelationResponse"/></returns>
        public Task<CreateDspmIdentifyComplianceRuleRelationResponse> CreateDspmIdentifyComplianceRuleRelation(CreateDspmIdentifyComplianceRuleRelationRequest req)
        {
            return InternalRequestAsync<CreateDspmIdentifyComplianceRuleRelationResponse>(req, "CreateDspmIdentifyComplianceRuleRelation");
        }

        /// <summary>
        /// Creates a dspm data identification template data item association
        /// </summary>
        /// <param name="req"><see cref="CreateDspmIdentifyComplianceRuleRelationRequest"/></param>
        /// <returns><see cref="CreateDspmIdentifyComplianceRuleRelationResponse"/></returns>
        public CreateDspmIdentifyComplianceRuleRelationResponse CreateDspmIdentifyComplianceRuleRelationSync(CreateDspmIdentifyComplianceRuleRelationRequest req)
        {
            return InternalRequestAsync<CreateDspmIdentifyComplianceRuleRelationResponse>(req, "CreateDspmIdentifyComplianceRuleRelation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a Dspm identity list export task.
        /// </summary>
        /// <param name="req"><see cref="CreateDspmIdentifyInfoListExportJobRequest"/></param>
        /// <returns><see cref="CreateDspmIdentifyInfoListExportJobResponse"/></returns>
        public Task<CreateDspmIdentifyInfoListExportJobResponse> CreateDspmIdentifyInfoListExportJob(CreateDspmIdentifyInfoListExportJobRequest req)
        {
            return InternalRequestAsync<CreateDspmIdentifyInfoListExportJobResponse>(req, "CreateDspmIdentifyInfoListExportJob");
        }

        /// <summary>
        /// This API is used to create a Dspm identity list export task.
        /// </summary>
        /// <param name="req"><see cref="CreateDspmIdentifyInfoListExportJobRequest"/></param>
        /// <returns><see cref="CreateDspmIdentifyInfoListExportJobResponse"/></returns>
        public CreateDspmIdentifyInfoListExportJobResponse CreateDspmIdentifyInfoListExportJobSync(CreateDspmIdentifyInfoListExportJobRequest req)
        {
            return InternalRequestAsync<CreateDspmIdentifyInfoListExportJobResponse>(req, "CreateDspmIdentifyInfoListExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Creating a dspm Data Identification and Classification Group
        /// </summary>
        /// <param name="req"><see cref="CreateDspmIdentifyLevelGroupRequest"/></param>
        /// <returns><see cref="CreateDspmIdentifyLevelGroupResponse"/></returns>
        public Task<CreateDspmIdentifyLevelGroupResponse> CreateDspmIdentifyLevelGroup(CreateDspmIdentifyLevelGroupRequest req)
        {
            return InternalRequestAsync<CreateDspmIdentifyLevelGroupResponse>(req, "CreateDspmIdentifyLevelGroup");
        }

        /// <summary>
        /// Creating a dspm Data Identification and Classification Group
        /// </summary>
        /// <param name="req"><see cref="CreateDspmIdentifyLevelGroupRequest"/></param>
        /// <returns><see cref="CreateDspmIdentifyLevelGroupResponse"/></returns>
        public CreateDspmIdentifyLevelGroupResponse CreateDspmIdentifyLevelGroupSync(CreateDspmIdentifyLevelGroupRequest req)
        {
            return InternalRequestAsync<CreateDspmIdentifyLevelGroupResponse>(req, "CreateDspmIdentifyLevelGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a dspm identification data item.
        /// </summary>
        /// <param name="req"><see cref="CreateDspmIdentifyRuleRequest"/></param>
        /// <returns><see cref="CreateDspmIdentifyRuleResponse"/></returns>
        public Task<CreateDspmIdentifyRuleResponse> CreateDspmIdentifyRule(CreateDspmIdentifyRuleRequest req)
        {
            return InternalRequestAsync<CreateDspmIdentifyRuleResponse>(req, "CreateDspmIdentifyRule");
        }

        /// <summary>
        /// This API is used to create a dspm identification data item.
        /// </summary>
        /// <param name="req"><see cref="CreateDspmIdentifyRuleRequest"/></param>
        /// <returns><see cref="CreateDspmIdentifyRuleResponse"/></returns>
        public CreateDspmIdentifyRuleResponse CreateDspmIdentifyRuleSync(CreateDspmIdentifyRuleRequest req)
        {
            return InternalRequestAsync<CreateDspmIdentifyRuleResponse>(req, "CreateDspmIdentifyRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a Dspm personal identity id.
        /// </summary>
        /// <param name="req"><see cref="CreateDspmPersonalIdentifyRequest"/></param>
        /// <returns><see cref="CreateDspmPersonalIdentifyResponse"/></returns>
        public Task<CreateDspmPersonalIdentifyResponse> CreateDspmPersonalIdentify(CreateDspmPersonalIdentifyRequest req)
        {
            return InternalRequestAsync<CreateDspmPersonalIdentifyResponse>(req, "CreateDspmPersonalIdentify");
        }

        /// <summary>
        /// Create a Dspm personal identity id.
        /// </summary>
        /// <param name="req"><see cref="CreateDspmPersonalIdentifyRequest"/></param>
        /// <returns><see cref="CreateDspmPersonalIdentifyResponse"/></returns>
        public CreateDspmPersonalIdentifyResponse CreateDspmPersonalIdentifySync(CreateDspmPersonalIdentifyRequest req)
        {
            return InternalRequestAsync<CreateDspmPersonalIdentifyResponse>(req, "CreateDspmPersonalIdentify")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a Dspm instance
        /// </summary>
        /// <param name="req"><see cref="CreateDspmResourceRequest"/></param>
        /// <returns><see cref="CreateDspmResourceResponse"/></returns>
        public Task<CreateDspmResourceResponse> CreateDspmResource(CreateDspmResourceRequest req)
        {
            return InternalRequestAsync<CreateDspmResourceResponse>(req, "CreateDspmResource");
        }

        /// <summary>
        /// Create a Dspm instance
        /// </summary>
        /// <param name="req"><see cref="CreateDspmResourceRequest"/></param>
        /// <returns><see cref="CreateDspmResourceResponse"/></returns>
        public CreateDspmResourceResponse CreateDspmResourceSync(CreateDspmResourceRequest req)
        {
            return InternalRequestAsync<CreateDspmResourceResponse>(req, "CreateDspmResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a Dspm risk export task
        /// </summary>
        /// <param name="req"><see cref="CreateDspmRiskExportJobRequest"/></param>
        /// <returns><see cref="CreateDspmRiskExportJobResponse"/></returns>
        public Task<CreateDspmRiskExportJobResponse> CreateDspmRiskExportJob(CreateDspmRiskExportJobRequest req)
        {
            return InternalRequestAsync<CreateDspmRiskExportJobResponse>(req, "CreateDspmRiskExportJob");
        }

        /// <summary>
        /// Create a Dspm risk export task
        /// </summary>
        /// <param name="req"><see cref="CreateDspmRiskExportJobRequest"/></param>
        /// <returns><see cref="CreateDspmRiskExportJobResponse"/></returns>
        public CreateDspmRiskExportJobResponse CreateDspmRiskExportJobSync(CreateDspmRiskExportJobRequest req)
        {
            return InternalRequestAsync<CreateDspmRiskExportJobResponse>(req, "CreateDspmRiskExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a Dspm custom risk policy.
        /// </summary>
        /// <param name="req"><see cref="CreateDspmRiskStrategyRequest"/></param>
        /// <returns><see cref="CreateDspmRiskStrategyResponse"/></returns>
        public Task<CreateDspmRiskStrategyResponse> CreateDspmRiskStrategy(CreateDspmRiskStrategyRequest req)
        {
            return InternalRequestAsync<CreateDspmRiskStrategyResponse>(req, "CreateDspmRiskStrategy");
        }

        /// <summary>
        /// This API is used to create a Dspm custom risk policy.
        /// </summary>
        /// <param name="req"><see cref="CreateDspmRiskStrategyRequest"/></param>
        /// <returns><see cref="CreateDspmRiskStrategyResponse"/></returns>
        public CreateDspmRiskStrategyResponse CreateDspmRiskStrategySync(CreateDspmRiskStrategyRequest req)
        {
            return InternalRequestAsync<CreateDspmRiskStrategyResponse>(req, "CreateDspmRiskStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a Dspm allowlist policy.
        /// </summary>
        /// <param name="req"><see cref="CreateDspmWhitelistStrategyRequest"/></param>
        /// <returns><see cref="CreateDspmWhitelistStrategyResponse"/></returns>
        public Task<CreateDspmWhitelistStrategyResponse> CreateDspmWhitelistStrategy(CreateDspmWhitelistStrategyRequest req)
        {
            return InternalRequestAsync<CreateDspmWhitelistStrategyResponse>(req, "CreateDspmWhitelistStrategy");
        }

        /// <summary>
        /// Create a Dspm allowlist policy.
        /// </summary>
        /// <param name="req"><see cref="CreateDspmWhitelistStrategyRequest"/></param>
        /// <returns><see cref="CreateDspmWhitelistStrategyResponse"/></returns>
        public CreateDspmWhitelistStrategyResponse CreateDspmWhitelistStrategySync(CreateDspmWhitelistStrategyRequest req)
        {
            return InternalRequestAsync<CreateDspmWhitelistStrategyResponse>(req, "CreateDspmWhitelistStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Creates a public network asset export task
        /// </summary>
        /// <param name="req"><see cref="CreateDynamicAssetsExportJobRequest"/></param>
        /// <returns><see cref="CreateDynamicAssetsExportJobResponse"/></returns>
        public Task<CreateDynamicAssetsExportJobResponse> CreateDynamicAssetsExportJob(CreateDynamicAssetsExportJobRequest req)
        {
            return InternalRequestAsync<CreateDynamicAssetsExportJobResponse>(req, "CreateDynamicAssetsExportJob");
        }

        /// <summary>
        /// Creates a public network asset export task
        /// </summary>
        /// <param name="req"><see cref="CreateDynamicAssetsExportJobRequest"/></param>
        /// <returns><see cref="CreateDynamicAssetsExportJobResponse"/></returns>
        public CreateDynamicAssetsExportJobResponse CreateDynamicAssetsExportJobSync(CreateDynamicAssetsExportJobRequest req)
        {
            return InternalRequestAsync<CreateDynamicAssetsExportJobResponse>(req, "CreateDynamicAssetsExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Triggered after you click start scanning. It supports multi-account and multiple asset types. When both hosts and container clusters are selected, it splits into two independent tasks (host + container).
        /// </summary>
        /// <param name="req"><see cref="CreateEDRManualScanRequest"/></param>
        /// <returns><see cref="CreateEDRManualScanResponse"/></returns>
        public Task<CreateEDRManualScanResponse> CreateEDRManualScan(CreateEDRManualScanRequest req)
        {
            return InternalRequestAsync<CreateEDRManualScanResponse>(req, "CreateEDRManualScan");
        }

        /// <summary>
        /// Triggered after you click start scanning. It supports multi-account and multiple asset types. When both hosts and container clusters are selected, it splits into two independent tasks (host + container).
        /// </summary>
        /// <param name="req"><see cref="CreateEDRManualScanRequest"/></param>
        /// <returns><see cref="CreateEDRManualScanResponse"/></returns>
        public CreateEDRManualScanResponse CreateEDRManualScanSync(CreateEDRManualScanRequest req)
        {
            return InternalRequestAsync<CreateEDRManualScanResponse>(req, "CreateEDRManualScan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an EDR alert export task.
        /// </summary>
        /// <param name="req"><see cref="CreateEdrAlertExportJobRequest"/></param>
        /// <returns><see cref="CreateEdrAlertExportJobResponse"/></returns>
        public Task<CreateEdrAlertExportJobResponse> CreateEdrAlertExportJob(CreateEdrAlertExportJobRequest req)
        {
            return InternalRequestAsync<CreateEdrAlertExportJobResponse>(req, "CreateEdrAlertExportJob");
        }

        /// <summary>
        /// This API is used to create an EDR alert export task.
        /// </summary>
        /// <param name="req"><see cref="CreateEdrAlertExportJobRequest"/></param>
        /// <returns><see cref="CreateEdrAlertExportJobResponse"/></returns>
        public CreateEdrAlertExportJobResponse CreateEdrAlertExportJobSync(CreateEdrAlertExportJobRequest req)
        {
            return InternalRequestAsync<CreateEdrAlertExportJobResponse>(req, "CreateEdrAlertExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an EDR alert ordinary export task.
        /// </summary>
        /// <param name="req"><see cref="CreateEdrLessAlertExportJobRequest"/></param>
        /// <returns><see cref="CreateEdrLessAlertExportJobResponse"/></returns>
        public Task<CreateEdrLessAlertExportJobResponse> CreateEdrLessAlertExportJob(CreateEdrLessAlertExportJobRequest req)
        {
            return InternalRequestAsync<CreateEdrLessAlertExportJobResponse>(req, "CreateEdrLessAlertExportJob");
        }

        /// <summary>
        /// This API is used to create an EDR alert ordinary export task.
        /// </summary>
        /// <param name="req"><see cref="CreateEdrLessAlertExportJobRequest"/></param>
        /// <returns><see cref="CreateEdrLessAlertExportJobResponse"/></returns>
        public CreateEdrLessAlertExportJobResponse CreateEdrLessAlertExportJobSync(CreateEdrLessAlertExportJobRequest req)
        {
            return InternalRequestAsync<CreateEdrLessAlertExportJobResponse>(req, "CreateEdrLessAlertExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create rules for automatic cloud boundary tagging.
        /// </summary>
        /// <param name="req"><see cref="CreateExposureAutoTagRuleRequest"/></param>
        /// <returns><see cref="CreateExposureAutoTagRuleResponse"/></returns>
        public Task<CreateExposureAutoTagRuleResponse> CreateExposureAutoTagRule(CreateExposureAutoTagRuleRequest req)
        {
            return InternalRequestAsync<CreateExposureAutoTagRuleResponse>(req, "CreateExposureAutoTagRule");
        }

        /// <summary>
        /// Create rules for automatic cloud boundary tagging.
        /// </summary>
        /// <param name="req"><see cref="CreateExposureAutoTagRuleRequest"/></param>
        /// <returns><see cref="CreateExposureAutoTagRuleResponse"/></returns>
        public CreateExposureAutoTagRuleResponse CreateExposureAutoTagRuleSync(CreateExposureAutoTagRuleRequest req)
        {
            return InternalRequestAsync<CreateExposureAutoTagRuleResponse>(req, "CreateExposureAutoTagRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Export Task for Exposed Assets
        /// </summary>
        /// <param name="req"><see cref="CreateExposuresExportJobRequest"/></param>
        /// <returns><see cref="CreateExposuresExportJobResponse"/></returns>
        public Task<CreateExposuresExportJobResponse> CreateExposuresExportJob(CreateExposuresExportJobRequest req)
        {
            return InternalRequestAsync<CreateExposuresExportJobResponse>(req, "CreateExposuresExportJob");
        }

        /// <summary>
        /// Export Task for Exposed Assets
        /// </summary>
        /// <param name="req"><see cref="CreateExposuresExportJobRequest"/></param>
        /// <returns><see cref="CreateExposuresExportJobResponse"/></returns>
        public CreateExposuresExportJobResponse CreateExposuresExportJobSync(CreateExposuresExportJobRequest req)
        {
            return InternalRequestAsync<CreateExposuresExportJobResponse>(req, "CreateExposuresExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a high-risk baseline risk export task.
        /// </summary>
        /// <param name="req"><see cref="CreateHighBaseLineRisksExportJobRequest"/></param>
        /// <returns><see cref="CreateHighBaseLineRisksExportJobResponse"/></returns>
        public Task<CreateHighBaseLineRisksExportJobResponse> CreateHighBaseLineRisksExportJob(CreateHighBaseLineRisksExportJobRequest req)
        {
            return InternalRequestAsync<CreateHighBaseLineRisksExportJobResponse>(req, "CreateHighBaseLineRisksExportJob");
        }

        /// <summary>
        /// This API is used to create a high-risk baseline risk export task.
        /// </summary>
        /// <param name="req"><see cref="CreateHighBaseLineRisksExportJobRequest"/></param>
        /// <returns><see cref="CreateHighBaseLineRisksExportJobResponse"/></returns>
        public CreateHighBaseLineRisksExportJobResponse CreateHighBaseLineRisksExportJobSync(CreateHighBaseLineRisksExportJobRequest req)
        {
            return InternalRequestAsync<CreateHighBaseLineRisksExportJobResponse>(req, "CreateHighBaseLineRisksExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a local image list export task. The export fields include image ID, image name, mirror version, number of associated containers, number of associated hosts, creation time, account nickname, and risk fields such as scan status, vulnerability, Trojan, and sensitive information. Filtering is supported. Export is implemented through an async task. After JobId is returned, the frontend polls to query the export task status. In single account mode, the NickName field is automatically excluded.
        /// </summary>
        /// <param name="req"><see cref="CreateHostImageListExportJobRequest"/></param>
        /// <returns><see cref="CreateHostImageListExportJobResponse"/></returns>
        public Task<CreateHostImageListExportJobResponse> CreateHostImageListExportJob(CreateHostImageListExportJobRequest req)
        {
            return InternalRequestAsync<CreateHostImageListExportJobResponse>(req, "CreateHostImageListExportJob");
        }

        /// <summary>
        /// Create a local image list export task. The export fields include image ID, image name, mirror version, number of associated containers, number of associated hosts, creation time, account nickname, and risk fields such as scan status, vulnerability, Trojan, and sensitive information. Filtering is supported. Export is implemented through an async task. After JobId is returned, the frontend polls to query the export task status. In single account mode, the NickName field is automatically excluded.
        /// </summary>
        /// <param name="req"><see cref="CreateHostImageListExportJobRequest"/></param>
        /// <returns><see cref="CreateHostImageListExportJobResponse"/></returns>
        public CreateHostImageListExportJobResponse CreateHostImageListExportJobSync(CreateHostImageListExportJobRequest req)
        {
            return InternalRequestAsync<CreateHostImageListExportJobResponse>(req, "CreateHostImageListExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a host vulnerability table export task.
        /// </summary>
        /// <param name="req"><see cref="CreateHostVulExportJobRequest"/></param>
        /// <returns><see cref="CreateHostVulExportJobResponse"/></returns>
        public Task<CreateHostVulExportJobResponse> CreateHostVulExportJob(CreateHostVulExportJobRequest req)
        {
            return InternalRequestAsync<CreateHostVulExportJobResponse>(req, "CreateHostVulExportJob");
        }

        /// <summary>
        /// This API is used to create a host vulnerability table export task.
        /// </summary>
        /// <param name="req"><see cref="CreateHostVulExportJobRequest"/></param>
        /// <returns><see cref="CreateHostVulExportJobResponse"/></returns>
        public CreateHostVulExportJobResponse CreateHostVulExportJobSync(CreateHostVulExportJobRequest req)
        {
            return InternalRequestAsync<CreateHostVulExportJobResponse>(req, "CreateHostVulExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create an IaC detection integration Token.
        /// </summary>
        /// <param name="req"><see cref="CreateIaCAccessTokenRequest"/></param>
        /// <returns><see cref="CreateIaCAccessTokenResponse"/></returns>
        public Task<CreateIaCAccessTokenResponse> CreateIaCAccessToken(CreateIaCAccessTokenRequest req)
        {
            return InternalRequestAsync<CreateIaCAccessTokenResponse>(req, "CreateIaCAccessToken");
        }

        /// <summary>
        /// Create an IaC detection integration Token.
        /// </summary>
        /// <param name="req"><see cref="CreateIaCAccessTokenRequest"/></param>
        /// <returns><see cref="CreateIaCAccessTokenResponse"/></returns>
        public CreateIaCAccessTokenResponse CreateIaCAccessTokenSync(CreateIaCAccessTokenRequest req)
        {
            return InternalRequestAsync<CreateIaCAccessTokenResponse>(req, "CreateIaCAccessToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Creates an IaC detection file export task
        /// </summary>
        /// <param name="req"><see cref="CreateIaCFileExportJobRequest"/></param>
        /// <returns><see cref="CreateIaCFileExportJobResponse"/></returns>
        public Task<CreateIaCFileExportJobResponse> CreateIaCFileExportJob(CreateIaCFileExportJobRequest req)
        {
            return InternalRequestAsync<CreateIaCFileExportJobResponse>(req, "CreateIaCFileExportJob");
        }

        /// <summary>
        /// Creates an IaC detection file export task
        /// </summary>
        /// <param name="req"><see cref="CreateIaCFileExportJobRequest"/></param>
        /// <returns><see cref="CreateIaCFileExportJobResponse"/></returns>
        public CreateIaCFileExportJobResponse CreateIaCFileExportJobSync(CreateIaCFileExportJobRequest req)
        {
            return InternalRequestAsync<CreateIaCFileExportJobResponse>(req, "CreateIaCFileExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an IaC detection file rescan task.
        /// </summary>
        /// <param name="req"><see cref="CreateIaCFileReScanTaskRequest"/></param>
        /// <returns><see cref="CreateIaCFileReScanTaskResponse"/></returns>
        public Task<CreateIaCFileReScanTaskResponse> CreateIaCFileReScanTask(CreateIaCFileReScanTaskRequest req)
        {
            return InternalRequestAsync<CreateIaCFileReScanTaskResponse>(req, "CreateIaCFileReScanTask");
        }

        /// <summary>
        /// This API is used to create an IaC detection file rescan task.
        /// </summary>
        /// <param name="req"><see cref="CreateIaCFileReScanTaskRequest"/></param>
        /// <returns><see cref="CreateIaCFileReScanTaskResponse"/></returns>
        public CreateIaCFileReScanTaskResponse CreateIaCFileReScanTaskSync(CreateIaCFileReScanTaskRequest req)
        {
            return InternalRequestAsync<CreateIaCFileReScanTaskResponse>(req, "CreateIaCFileReScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create an image asset list export task
        /// </summary>
        /// <param name="req"><see cref="CreateImageAssetListExportJobRequest"/></param>
        /// <returns><see cref="CreateImageAssetListExportJobResponse"/></returns>
        public Task<CreateImageAssetListExportJobResponse> CreateImageAssetListExportJob(CreateImageAssetListExportJobRequest req)
        {
            return InternalRequestAsync<CreateImageAssetListExportJobResponse>(req, "CreateImageAssetListExportJob");
        }

        /// <summary>
        /// Create an image asset list export task
        /// </summary>
        /// <param name="req"><see cref="CreateImageAssetListExportJobRequest"/></param>
        /// <returns><see cref="CreateImageAssetListExportJobResponse"/></returns>
        public CreateImageAssetListExportJobResponse CreateImageAssetListExportJobSync(CreateImageAssetListExportJobRequest req)
        {
            return InternalRequestAsync<CreateImageAssetListExportJobResponse>(req, "CreateImageAssetListExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create an image associated container asset export task
        /// </summary>
        /// <param name="req"><see cref="CreateImageAssociatedContainerListExportJobRequest"/></param>
        /// <returns><see cref="CreateImageAssociatedContainerListExportJobResponse"/></returns>
        public Task<CreateImageAssociatedContainerListExportJobResponse> CreateImageAssociatedContainerListExportJob(CreateImageAssociatedContainerListExportJobRequest req)
        {
            return InternalRequestAsync<CreateImageAssociatedContainerListExportJobResponse>(req, "CreateImageAssociatedContainerListExportJob");
        }

        /// <summary>
        /// Create an image associated container asset export task
        /// </summary>
        /// <param name="req"><see cref="CreateImageAssociatedContainerListExportJobRequest"/></param>
        /// <returns><see cref="CreateImageAssociatedContainerListExportJobResponse"/></returns>
        public CreateImageAssociatedContainerListExportJobResponse CreateImageAssociatedContainerListExportJobSync(CreateImageAssociatedContainerListExportJobRequest req)
        {
            return InternalRequestAsync<CreateImageAssociatedContainerListExportJobResponse>(req, "CreateImageAssociatedContainerListExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create image associated host asset list export task
        /// </summary>
        /// <param name="req"><see cref="CreateImageAssociatedHostListExportJobRequest"/></param>
        /// <returns><see cref="CreateImageAssociatedHostListExportJobResponse"/></returns>
        public Task<CreateImageAssociatedHostListExportJobResponse> CreateImageAssociatedHostListExportJob(CreateImageAssociatedHostListExportJobRequest req)
        {
            return InternalRequestAsync<CreateImageAssociatedHostListExportJobResponse>(req, "CreateImageAssociatedHostListExportJob");
        }

        /// <summary>
        /// Create image associated host asset list export task
        /// </summary>
        /// <param name="req"><see cref="CreateImageAssociatedHostListExportJobRequest"/></param>
        /// <returns><see cref="CreateImageAssociatedHostListExportJobResponse"/></returns>
        public CreateImageAssociatedHostListExportJobResponse CreateImageAssociatedHostListExportJobSync(CreateImageAssociatedHostListExportJobRequest req)
        {
            return InternalRequestAsync<CreateImageAssociatedHostListExportJobResponse>(req, "CreateImageAssociatedHostListExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create an image component list export task.
        /// </summary>
        /// <param name="req"><see cref="CreateImageComponentListExportJobRequest"/></param>
        /// <returns><see cref="CreateImageComponentListExportJobResponse"/></returns>
        public Task<CreateImageComponentListExportJobResponse> CreateImageComponentListExportJob(CreateImageComponentListExportJobRequest req)
        {
            return InternalRequestAsync<CreateImageComponentListExportJobResponse>(req, "CreateImageComponentListExportJob");
        }

        /// <summary>
        /// Create an image component list export task.
        /// </summary>
        /// <param name="req"><see cref="CreateImageComponentListExportJobRequest"/></param>
        /// <returns><see cref="CreateImageComponentListExportJobResponse"/></returns>
        public CreateImageComponentListExportJobResponse CreateImageComponentListExportJobSync(CreateImageComponentListExportJobRequest req)
        {
            return InternalRequestAsync<CreateImageComponentListExportJobResponse>(req, "CreateImageComponentListExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create Image Layer Vulnerability List Export Task
        /// </summary>
        /// <param name="req"><see cref="CreateImageLayerVulListExportJobRequest"/></param>
        /// <returns><see cref="CreateImageLayerVulListExportJobResponse"/></returns>
        public Task<CreateImageLayerVulListExportJobResponse> CreateImageLayerVulListExportJob(CreateImageLayerVulListExportJobRequest req)
        {
            return InternalRequestAsync<CreateImageLayerVulListExportJobResponse>(req, "CreateImageLayerVulListExportJob");
        }

        /// <summary>
        /// Create Image Layer Vulnerability List Export Task
        /// </summary>
        /// <param name="req"><see cref="CreateImageLayerVulListExportJobRequest"/></param>
        /// <returns><see cref="CreateImageLayerVulListExportJobResponse"/></returns>
        public CreateImageLayerVulListExportJobResponse CreateImageLayerVulListExportJobSync(CreateImageLayerVulListExportJobRequest req)
        {
            return InternalRequestAsync<CreateImageLayerVulListExportJobResponse>(req, "CreateImageLayerVulListExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a mirror repository connectivity check task.
        /// </summary>
        /// <param name="req"><see cref="CreateImageRegistryConnectivityTaskRequest"/></param>
        /// <returns><see cref="CreateImageRegistryConnectivityTaskResponse"/></returns>
        public Task<CreateImageRegistryConnectivityTaskResponse> CreateImageRegistryConnectivityTask(CreateImageRegistryConnectivityTaskRequest req)
        {
            return InternalRequestAsync<CreateImageRegistryConnectivityTaskResponse>(req, "CreateImageRegistryConnectivityTask");
        }

        /// <summary>
        /// This API is used to create a mirror repository connectivity check task.
        /// </summary>
        /// <param name="req"><see cref="CreateImageRegistryConnectivityTaskRequest"/></param>
        /// <returns><see cref="CreateImageRegistryConnectivityTaskResponse"/></returns>
        public CreateImageRegistryConnectivityTaskResponse CreateImageRegistryConnectivityTaskSync(CreateImageRegistryConnectivityTaskRequest req)
        {
            return InternalRequestAsync<CreateImageRegistryConnectivityTaskResponse>(req, "CreateImageRegistryConnectivityTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an image repository list export task.
        /// </summary>
        /// <param name="req"><see cref="CreateImageRegistryListExportJobRequest"/></param>
        /// <returns><see cref="CreateImageRegistryListExportJobResponse"/></returns>
        public Task<CreateImageRegistryListExportJobResponse> CreateImageRegistryListExportJob(CreateImageRegistryListExportJobRequest req)
        {
            return InternalRequestAsync<CreateImageRegistryListExportJobResponse>(req, "CreateImageRegistryListExportJob");
        }

        /// <summary>
        /// This API is used to create an image repository list export task.
        /// </summary>
        /// <param name="req"><see cref="CreateImageRegistryListExportJobRequest"/></param>
        /// <returns><see cref="CreateImageRegistryListExportJobResponse"/></returns>
        public CreateImageRegistryListExportJobResponse CreateImageRegistryListExportJobSync(CreateImageRegistryListExportJobRequest req)
        {
            return InternalRequestAsync<CreateImageRegistryListExportJobResponse>(req, "CreateImageRegistryListExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Creating an Image Scanning Task
        /// </summary>
        /// <param name="req"><see cref="CreateImageRegistryScanTaskRequest"/></param>
        /// <returns><see cref="CreateImageRegistryScanTaskResponse"/></returns>
        public Task<CreateImageRegistryScanTaskResponse> CreateImageRegistryScanTask(CreateImageRegistryScanTaskRequest req)
        {
            return InternalRequestAsync<CreateImageRegistryScanTaskResponse>(req, "CreateImageRegistryScanTask");
        }

        /// <summary>
        /// Creating an Image Scanning Task
        /// </summary>
        /// <param name="req"><see cref="CreateImageRegistryScanTaskRequest"/></param>
        /// <returns><see cref="CreateImageRegistryScanTaskResponse"/></returns>
        public CreateImageRegistryScanTaskResponse CreateImageRegistryScanTaskSync(CreateImageRegistryScanTaskRequest req)
        {
            return InternalRequestAsync<CreateImageRegistryScanTaskResponse>(req, "CreateImageRegistryScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create an image scanning task configuration for an image repository
        /// </summary>
        /// <param name="req"><see cref="CreateImageRegistryTimedScanTaskConfigRequest"/></param>
        /// <returns><see cref="CreateImageRegistryTimedScanTaskConfigResponse"/></returns>
        public Task<CreateImageRegistryTimedScanTaskConfigResponse> CreateImageRegistryTimedScanTaskConfig(CreateImageRegistryTimedScanTaskConfigRequest req)
        {
            return InternalRequestAsync<CreateImageRegistryTimedScanTaskConfigResponse>(req, "CreateImageRegistryTimedScanTaskConfig");
        }

        /// <summary>
        /// Create an image scanning task configuration for an image repository
        /// </summary>
        /// <param name="req"><see cref="CreateImageRegistryTimedScanTaskConfigRequest"/></param>
        /// <returns><see cref="CreateImageRegistryTimedScanTaskConfigResponse"/></returns>
        public CreateImageRegistryTimedScanTaskConfigResponse CreateImageRegistryTimedScanTaskConfigSync(CreateImageRegistryTimedScanTaskConfigRequest req)
        {
            return InternalRequestAsync<CreateImageRegistryTimedScanTaskConfigResponse>(req, "CreateImageRegistryTimedScanTaskConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create Image Sensitive Information List Export Task
        /// </summary>
        /// <param name="req"><see cref="CreateImageSensitiveInfoListExportJobRequest"/></param>
        /// <returns><see cref="CreateImageSensitiveInfoListExportJobResponse"/></returns>
        public Task<CreateImageSensitiveInfoListExportJobResponse> CreateImageSensitiveInfoListExportJob(CreateImageSensitiveInfoListExportJobRequest req)
        {
            return InternalRequestAsync<CreateImageSensitiveInfoListExportJobResponse>(req, "CreateImageSensitiveInfoListExportJob");
        }

        /// <summary>
        /// Create Image Sensitive Information List Export Task
        /// </summary>
        /// <param name="req"><see cref="CreateImageSensitiveInfoListExportJobRequest"/></param>
        /// <returns><see cref="CreateImageSensitiveInfoListExportJobResponse"/></returns>
        public CreateImageSensitiveInfoListExportJobResponse CreateImageSensitiveInfoListExportJobSync(CreateImageSensitiveInfoListExportJobRequest req)
        {
            return InternalRequestAsync<CreateImageSensitiveInfoListExportJobResponse>(req, "CreateImageSensitiveInfoListExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an allowlist for sensitive information in container images.
        /// </summary>
        /// <param name="req"><see cref="CreateImageSensitiveWhitelistRequest"/></param>
        /// <returns><see cref="CreateImageSensitiveWhitelistResponse"/></returns>
        public Task<CreateImageSensitiveWhitelistResponse> CreateImageSensitiveWhitelist(CreateImageSensitiveWhitelistRequest req)
        {
            return InternalRequestAsync<CreateImageSensitiveWhitelistResponse>(req, "CreateImageSensitiveWhitelist");
        }

        /// <summary>
        /// This API is used to create an allowlist for sensitive information in container images.
        /// </summary>
        /// <param name="req"><see cref="CreateImageSensitiveWhitelistRequest"/></param>
        /// <returns><see cref="CreateImageSensitiveWhitelistResponse"/></returns>
        public CreateImageSensitiveWhitelistResponse CreateImageSensitiveWhitelistSync(CreateImageSensitiveWhitelistRequest req)
        {
            return InternalRequestAsync<CreateImageSensitiveWhitelistResponse>(req, "CreateImageSensitiveWhitelist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create an image Trojan virus list export task
        /// </summary>
        /// <param name="req"><see cref="CreateImageVirusListExportJobRequest"/></param>
        /// <returns><see cref="CreateImageVirusListExportJobResponse"/></returns>
        public Task<CreateImageVirusListExportJobResponse> CreateImageVirusListExportJob(CreateImageVirusListExportJobRequest req)
        {
            return InternalRequestAsync<CreateImageVirusListExportJobResponse>(req, "CreateImageVirusListExportJob");
        }

        /// <summary>
        /// Create an image Trojan virus list export task
        /// </summary>
        /// <param name="req"><see cref="CreateImageVirusListExportJobRequest"/></param>
        /// <returns><see cref="CreateImageVirusListExportJobResponse"/></returns>
        public CreateImageVirusListExportJobResponse CreateImageVirusListExportJobSync(CreateImageVirusListExportJobRequest req)
        {
            return InternalRequestAsync<CreateImageVirusListExportJobResponse>(req, "CreateImageVirusListExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an image Trojan allowlist.
        /// </summary>
        /// <param name="req"><see cref="CreateImageVirusWhitelistRequest"/></param>
        /// <returns><see cref="CreateImageVirusWhitelistResponse"/></returns>
        public Task<CreateImageVirusWhitelistResponse> CreateImageVirusWhitelist(CreateImageVirusWhitelistRequest req)
        {
            return InternalRequestAsync<CreateImageVirusWhitelistResponse>(req, "CreateImageVirusWhitelist");
        }

        /// <summary>
        /// This API is used to create an image Trojan allowlist.
        /// </summary>
        /// <param name="req"><see cref="CreateImageVirusWhitelistRequest"/></param>
        /// <returns><see cref="CreateImageVirusWhitelistResponse"/></returns>
        public CreateImageVirusWhitelistResponse CreateImageVirusWhitelistSync(CreateImageVirusWhitelistRequest req)
        {
            return InternalRequestAsync<CreateImageVirusWhitelistResponse>(req, "CreateImageVirusWhitelist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a task of exporting the image vulnerability list.
        /// </summary>
        /// <param name="req"><see cref="CreateImageVulListExportJobRequest"/></param>
        /// <returns><see cref="CreateImageVulListExportJobResponse"/></returns>
        public Task<CreateImageVulListExportJobResponse> CreateImageVulListExportJob(CreateImageVulListExportJobRequest req)
        {
            return InternalRequestAsync<CreateImageVulListExportJobResponse>(req, "CreateImageVulListExportJob");
        }

        /// <summary>
        /// This API is used to create a task of exporting the image vulnerability list.
        /// </summary>
        /// <param name="req"><see cref="CreateImageVulListExportJobRequest"/></param>
        /// <returns><see cref="CreateImageVulListExportJobResponse"/></returns>
        public CreateImageVulListExportJobResponse CreateImageVulListExportJobSync(CreateImageVulListExportJobRequest req)
        {
            return InternalRequestAsync<CreateImageVulListExportJobResponse>(req, "CreateImageVulListExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Creates an export task for the vulnerability overview list of an image.
        /// </summary>
        /// <param name="req"><see cref="CreateImageVulSummaryListExportJobRequest"/></param>
        /// <returns><see cref="CreateImageVulSummaryListExportJobResponse"/></returns>
        public Task<CreateImageVulSummaryListExportJobResponse> CreateImageVulSummaryListExportJob(CreateImageVulSummaryListExportJobRequest req)
        {
            return InternalRequestAsync<CreateImageVulSummaryListExportJobResponse>(req, "CreateImageVulSummaryListExportJob");
        }

        /// <summary>
        /// Creates an export task for the vulnerability overview list of an image.
        /// </summary>
        /// <param name="req"><see cref="CreateImageVulSummaryListExportJobRequest"/></param>
        /// <returns><see cref="CreateImageVulSummaryListExportJobResponse"/></returns>
        public CreateImageVulSummaryListExportJobResponse CreateImageVulSummaryListExportJobSync(CreateImageVulSummaryListExportJobRequest req)
        {
            return InternalRequestAsync<CreateImageVulSummaryListExportJobResponse>(req, "CreateImageVulSummaryListExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a vulnerability allowlist for container images.
        /// </summary>
        /// <param name="req"><see cref="CreateImageVulWhitelistRequest"/></param>
        /// <returns><see cref="CreateImageVulWhitelistResponse"/></returns>
        public Task<CreateImageVulWhitelistResponse> CreateImageVulWhitelist(CreateImageVulWhitelistRequest req)
        {
            return InternalRequestAsync<CreateImageVulWhitelistResponse>(req, "CreateImageVulWhitelist");
        }

        /// <summary>
        /// This API is used to create a vulnerability allowlist for container images.
        /// </summary>
        /// <param name="req"><see cref="CreateImageVulWhitelistRequest"/></param>
        /// <returns><see cref="CreateImageVulWhitelistResponse"/></returns>
        public CreateImageVulWhitelistResponse CreateImageVulWhitelistSync(CreateImageVulWhitelistRequest req)
        {
            return InternalRequestAsync<CreateImageVulWhitelistResponse>(req, "CreateImageVulWhitelist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a Pod associated container list export task. Export fields include container ID, container name, running state, node ID, node type, image ID, image name, and isolation status. Filtering is supported. Export is implemented through an async task. After JobId is returned, front-end polling is used to query the export task status.
        /// </summary>
        /// <param name="req"><see cref="CreatePodContainerListExportJobRequest"/></param>
        /// <returns><see cref="CreatePodContainerListExportJobResponse"/></returns>
        public Task<CreatePodContainerListExportJobResponse> CreatePodContainerListExportJob(CreatePodContainerListExportJobRequest req)
        {
            return InternalRequestAsync<CreatePodContainerListExportJobResponse>(req, "CreatePodContainerListExportJob");
        }

        /// <summary>
        /// This API is used to create a Pod associated container list export task. Export fields include container ID, container name, running state, node ID, node type, image ID, image name, and isolation status. Filtering is supported. Export is implemented through an async task. After JobId is returned, front-end polling is used to query the export task status.
        /// </summary>
        /// <param name="req"><see cref="CreatePodContainerListExportJobRequest"/></param>
        /// <returns><see cref="CreatePodContainerListExportJobResponse"/></returns>
        public CreatePodContainerListExportJobResponse CreatePodContainerListExportJobSync(CreatePodContainerListExportJobRequest req)
        {
            return InternalRequestAsync<CreatePodContainerListExportJobResponse>(req, "CreatePodContainerListExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Creates a Pod Association service list export task. The export fields include service name, type, Selector, namespace, and creation time. Filtering is supported. When PodUniqueID is input, the Pod Association matching logic of DescribeClusterServiceList is reused. Export is implemented through an async task, and after JobId is returned, the frontend polls to query the export task status.
        /// </summary>
        /// <param name="req"><see cref="CreatePodServiceListExportJobRequest"/></param>
        /// <returns><see cref="CreatePodServiceListExportJobResponse"/></returns>
        public Task<CreatePodServiceListExportJobResponse> CreatePodServiceListExportJob(CreatePodServiceListExportJobRequest req)
        {
            return InternalRequestAsync<CreatePodServiceListExportJobResponse>(req, "CreatePodServiceListExportJob");
        }

        /// <summary>
        /// Creates a Pod Association service list export task. The export fields include service name, type, Selector, namespace, and creation time. Filtering is supported. When PodUniqueID is input, the Pod Association matching logic of DescribeClusterServiceList is reused. Export is implemented through an async task, and after JobId is returned, the frontend polls to query the export task status.
        /// </summary>
        /// <param name="req"><see cref="CreatePodServiceListExportJobRequest"/></param>
        /// <returns><see cref="CreatePodServiceListExportJobResponse"/></returns>
        public CreatePodServiceListExportJobResponse CreatePodServiceListExportJobSync(CreatePodServiceListExportJobRequest req)
        {
            return InternalRequestAsync<CreatePodServiceListExportJobResponse>(req, "CreatePodServiceListExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a public network asset export task.
        /// </summary>
        /// <param name="req"><see cref="CreatePublicAssetsExportJobRequest"/></param>
        /// <returns><see cref="CreatePublicAssetsExportJobResponse"/></returns>
        public Task<CreatePublicAssetsExportJobResponse> CreatePublicAssetsExportJob(CreatePublicAssetsExportJobRequest req)
        {
            return InternalRequestAsync<CreatePublicAssetsExportJobResponse>(req, "CreatePublicAssetsExportJob");
        }

        /// <summary>
        /// This API is used to create a public network asset export task.
        /// </summary>
        /// <param name="req"><see cref="CreatePublicAssetsExportJobRequest"/></param>
        /// <returns><see cref="CreatePublicAssetsExportJobResponse"/></returns>
        public CreatePublicAssetsExportJobResponse CreatePublicAssetsExportJobSync(CreatePublicAssetsExportJobRequest req)
        {
            return InternalRequestAsync<CreatePublicAssetsExportJobResponse>(req, "CreatePublicAssetsExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create Risk Center Scan Task
        /// </summary>
        /// <param name="req"><see cref="CreateRiskCenterScanTaskRequest"/></param>
        /// <returns><see cref="CreateRiskCenterScanTaskResponse"/></returns>
        public Task<CreateRiskCenterScanTaskResponse> CreateRiskCenterScanTask(CreateRiskCenterScanTaskRequest req)
        {
            return InternalRequestAsync<CreateRiskCenterScanTaskResponse>(req, "CreateRiskCenterScanTask");
        }

        /// <summary>
        /// Create Risk Center Scan Task
        /// </summary>
        /// <param name="req"><see cref="CreateRiskCenterScanTaskRequest"/></param>
        /// <returns><see cref="CreateRiskCenterScanTaskResponse"/></returns>
        public CreateRiskCenterScanTaskResponse CreateRiskCenterScanTaskSync(CreateRiskCenterScanTaskRequest req)
        {
            return InternalRequestAsync<CreateRiskCenterScanTaskResponse>(req, "CreateRiskCenterScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Sample code for creating a cloud resource configuration check risk details export task
        /// </summary>
        /// <param name="req"><see cref="CreateRiskDetailExportJobRequest"/></param>
        /// <returns><see cref="CreateRiskDetailExportJobResponse"/></returns>
        public Task<CreateRiskDetailExportJobResponse> CreateRiskDetailExportJob(CreateRiskDetailExportJobRequest req)
        {
            return InternalRequestAsync<CreateRiskDetailExportJobResponse>(req, "CreateRiskDetailExportJob");
        }

        /// <summary>
        /// Sample code for creating a cloud resource configuration check risk details export task
        /// </summary>
        /// <param name="req"><see cref="CreateRiskDetailExportJobRequest"/></param>
        /// <returns><see cref="CreateRiskDetailExportJobResponse"/></returns>
        public CreateRiskDetailExportJobResponse CreateRiskDetailExportJobSync(CreateRiskDetailExportJobRequest req)
        {
            return InternalRequestAsync<CreateRiskDetailExportJobResponse>(req, "CreateRiskDetailExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an ACL user access control rule. You can refer to several system rules or define a custom rule. At least one of them must be provided.
        /// </summary>
        /// <param name="req"><see cref="CreateSandboxACLRuleRequest"/></param>
        /// <returns><see cref="CreateSandboxACLRuleResponse"/></returns>
        public Task<CreateSandboxACLRuleResponse> CreateSandboxACLRule(CreateSandboxACLRuleRequest req)
        {
            return InternalRequestAsync<CreateSandboxACLRuleResponse>(req, "CreateSandboxACLRule");
        }

        /// <summary>
        /// This API is used to create an ACL user access control rule. You can refer to several system rules or define a custom rule. At least one of them must be provided.
        /// </summary>
        /// <param name="req"><see cref="CreateSandboxACLRuleRequest"/></param>
        /// <returns><see cref="CreateSandboxACLRuleResponse"/></returns>
        public CreateSandboxACLRuleResponse CreateSandboxACLRuleSync(CreateSandboxACLRuleRequest req)
        {
            return InternalRequestAsync<CreateSandboxACLRuleResponse>(req, "CreateSandboxACLRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a DLP user rule. You can reference several system rules (SystemRuleIDList) or define a custom rule (UserRuleContent, name + regular). At least one of both is required. UserRuleInfo is a newly-added optional structured input parameter. When it is passed together with UserRuleContent, UserRuleInfo takes precedence.
        /// </summary>
        /// <param name="req"><see cref="CreateSandboxDLPRuleRequest"/></param>
        /// <returns><see cref="CreateSandboxDLPRuleResponse"/></returns>
        public Task<CreateSandboxDLPRuleResponse> CreateSandboxDLPRule(CreateSandboxDLPRuleRequest req)
        {
            return InternalRequestAsync<CreateSandboxDLPRuleResponse>(req, "CreateSandboxDLPRule");
        }

        /// <summary>
        /// Create a DLP user rule. You can reference several system rules (SystemRuleIDList) or define a custom rule (UserRuleContent, name + regular). At least one of both is required. UserRuleInfo is a newly-added optional structured input parameter. When it is passed together with UserRuleContent, UserRuleInfo takes precedence.
        /// </summary>
        /// <param name="req"><see cref="CreateSandboxDLPRuleRequest"/></param>
        /// <returns><see cref="CreateSandboxDLPRuleResponse"/></returns>
        public CreateSandboxDLPRuleResponse CreateSandboxDLPRuleSync(CreateSandboxDLPRuleRequest req)
        {
            return InternalRequestAsync<CreateSandboxDLPRuleResponse>(req, "CreateSandboxDLPRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create command sandbox file access policy
        /// </summary>
        /// <param name="req"><see cref="CreateSandboxFileRuleRequest"/></param>
        /// <returns><see cref="CreateSandboxFileRuleResponse"/></returns>
        public Task<CreateSandboxFileRuleResponse> CreateSandboxFileRule(CreateSandboxFileRuleRequest req)
        {
            return InternalRequestAsync<CreateSandboxFileRuleResponse>(req, "CreateSandboxFileRule");
        }

        /// <summary>
        /// Create command sandbox file access policy
        /// </summary>
        /// <param name="req"><see cref="CreateSandboxFileRuleRequest"/></param>
        /// <returns><see cref="CreateSandboxFileRuleResponse"/></returns>
        public CreateSandboxFileRuleResponse CreateSandboxFileRuleSync(CreateSandboxFileRuleRequest req)
        {
            return InternalRequestAsync<CreateSandboxFileRuleResponse>(req, "CreateSandboxFileRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an LLM audit user rule. It must refer to at least one system rule and does not support user customization of rule content.
        /// </summary>
        /// <param name="req"><see cref="CreateSandboxLLMAuditRuleRequest"/></param>
        /// <returns><see cref="CreateSandboxLLMAuditRuleResponse"/></returns>
        public Task<CreateSandboxLLMAuditRuleResponse> CreateSandboxLLMAuditRule(CreateSandboxLLMAuditRuleRequest req)
        {
            return InternalRequestAsync<CreateSandboxLLMAuditRuleResponse>(req, "CreateSandboxLLMAuditRule");
        }

        /// <summary>
        /// This API is used to create an LLM audit user rule. It must refer to at least one system rule and does not support user customization of rule content.
        /// </summary>
        /// <param name="req"><see cref="CreateSandboxLLMAuditRuleRequest"/></param>
        /// <returns><see cref="CreateSandboxLLMAuditRuleResponse"/></returns>
        public CreateSandboxLLMAuditRuleResponse CreateSandboxLLMAuditRuleSync(CreateSandboxLLMAuditRuleRequest req)
        {
            return InternalRequestAsync<CreateSandboxLLMAuditRuleResponse>(req, "CreateSandboxLLMAuditRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Exported task for exposed surface scanning results
        /// </summary>
        /// <param name="req"><see cref="CreateScanStatisticExportJobRequest"/></param>
        /// <returns><see cref="CreateScanStatisticExportJobResponse"/></returns>
        public Task<CreateScanStatisticExportJobResponse> CreateScanStatisticExportJob(CreateScanStatisticExportJobRequest req)
        {
            return InternalRequestAsync<CreateScanStatisticExportJobResponse>(req, "CreateScanStatisticExportJob");
        }

        /// <summary>
        /// Exported task for exposed surface scanning results
        /// </summary>
        /// <param name="req"><see cref="CreateScanStatisticExportJobRequest"/></param>
        /// <returns><see cref="CreateScanStatisticExportJobResponse"/></returns>
        public CreateScanStatisticExportJobResponse CreateScanStatisticExportJobSync(CreateScanStatisticExportJobRequest req)
        {
            return InternalRequestAsync<CreateScanStatisticExportJobResponse>(req, "CreateScanStatisticExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an immediate detection task.
        /// </summary>
        /// <param name="req"><see cref="CreateScanTaskRequest"/></param>
        /// <returns><see cref="CreateScanTaskResponse"/></returns>
        public Task<CreateScanTaskResponse> CreateScanTask(CreateScanTaskRequest req)
        {
            return InternalRequestAsync<CreateScanTaskResponse>(req, "CreateScanTask");
        }

        /// <summary>
        /// This API is used to create an immediate detection task.
        /// </summary>
        /// <param name="req"><see cref="CreateScanTaskRequest"/></param>
        /// <returns><see cref="CreateScanTaskResponse"/></returns>
        public CreateScanTaskResponse CreateScanTaskSync(CreateScanTaskRequest req)
        {
            return InternalRequestAsync<CreateScanTaskResponse>(req, "CreateScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Upload a Skill ZIP file to trigger asynchronous security detection. After a successful upload, poll the DescribeSkillScanResult API using the returned ContentHash and EngineVersion to obtain the result. The upload API is idempotent. Re-uploading a file with the same Hash does not create a repetition task. Detection results are retained for 90 days. Re-upload for detection after the retention period expires.
        /// </summary>
        /// <param name="req"><see cref="CreateSkillScanRequest"/></param>
        /// <returns><see cref="CreateSkillScanResponse"/></returns>
        public Task<CreateSkillScanResponse> CreateSkillScan(CreateSkillScanRequest req)
        {
            return InternalRequestAsync<CreateSkillScanResponse>(req, "CreateSkillScan");
        }

        /// <summary>
        /// Upload a Skill ZIP file to trigger asynchronous security detection. After a successful upload, poll the DescribeSkillScanResult API using the returned ContentHash and EngineVersion to obtain the result. The upload API is idempotent. Re-uploading a file with the same Hash does not create a repetition task. Detection results are retained for 90 days. Re-upload for detection after the retention period expires.
        /// </summary>
        /// <param name="req"><see cref="CreateSkillScanRequest"/></param>
        /// <returns><see cref="CreateSkillScanResponse"/></returns>
        public CreateSkillScanResponse CreateSkillScanSync(CreateSkillScanRequest req)
        {
            return InternalRequestAsync<CreateSkillScanResponse>(req, "CreateSkillScan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retry the vulnerability repair task that failed to fix, and redispatch the repair instruction only for the hosts of the original task that failed to fix. Retry is allowed only when the task status is partially or totally failed to fix.
        /// </summary>
        /// <param name="req"><see cref="CreateVulFixRetryTaskRequest"/></param>
        /// <returns><see cref="CreateVulFixRetryTaskResponse"/></returns>
        public Task<CreateVulFixRetryTaskResponse> CreateVulFixRetryTask(CreateVulFixRetryTaskRequest req)
        {
            return InternalRequestAsync<CreateVulFixRetryTaskResponse>(req, "CreateVulFixRetryTask");
        }

        /// <summary>
        /// Retry the vulnerability repair task that failed to fix, and redispatch the repair instruction only for the hosts of the original task that failed to fix. Retry is allowed only when the task status is partially or totally failed to fix.
        /// </summary>
        /// <param name="req"><see cref="CreateVulFixRetryTaskRequest"/></param>
        /// <returns><see cref="CreateVulFixRetryTaskResponse"/></returns>
        public CreateVulFixRetryTaskResponse CreateVulFixRetryTaskSync(CreateVulFixRetryTaskRequest req)
        {
            return InternalRequestAsync<CreateVulFixRetryTaskResponse>(req, "CreateVulFixRetryTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Users manually submit vulnerability repair tasks, specify the vulnerabilities and target hosts that need to be repaired, and the system creates fixing tasks and dispatches execution. It supports options such as specifying the repair timeout period and whether to create a snapshot. The FixItems array is used to precisely control which hosts each vulnerability or KB patch repairs.
        /// </summary>
        /// <param name="req"><see cref="CreateVulFixTaskRequest"/></param>
        /// <returns><see cref="CreateVulFixTaskResponse"/></returns>
        public Task<CreateVulFixTaskResponse> CreateVulFixTask(CreateVulFixTaskRequest req)
        {
            return InternalRequestAsync<CreateVulFixTaskResponse>(req, "CreateVulFixTask");
        }

        /// <summary>
        /// Users manually submit vulnerability repair tasks, specify the vulnerabilities and target hosts that need to be repaired, and the system creates fixing tasks and dispatches execution. It supports options such as specifying the repair timeout period and whether to create a snapshot. The FixItems array is used to precisely control which hosts each vulnerability or KB patch repairs.
        /// </summary>
        /// <param name="req"><see cref="CreateVulFixTaskRequest"/></param>
        /// <returns><see cref="CreateVulFixTaskResponse"/></returns>
        public CreateVulFixTaskResponse CreateVulFixTaskSync(CreateVulFixTaskRequest req)
        {
            return InternalRequestAsync<CreateVulFixTaskResponse>(req, "CreateVulFixTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create an export task for the list of fixed vulnerabilities. It supports the same filter criteria as DescribeVulFixedList. The export is implemented via an asynchronous task. After a JobID is returned, the frontend polls to query the export task status. The export fields include vulnerability ID, vulnerability name, vulnerability level, VPR rating, vulnerability type, CVE ID, host name, instance ID, associated component & path, and repair time.
        /// </summary>
        /// <param name="req"><see cref="CreateVulFixedExportJobRequest"/></param>
        /// <returns><see cref="CreateVulFixedExportJobResponse"/></returns>
        public Task<CreateVulFixedExportJobResponse> CreateVulFixedExportJob(CreateVulFixedExportJobRequest req)
        {
            return InternalRequestAsync<CreateVulFixedExportJobResponse>(req, "CreateVulFixedExportJob");
        }

        /// <summary>
        /// Create an export task for the list of fixed vulnerabilities. It supports the same filter criteria as DescribeVulFixedList. The export is implemented via an asynchronous task. After a JobID is returned, the frontend polls to query the export task status. The export fields include vulnerability ID, vulnerability name, vulnerability level, VPR rating, vulnerability type, CVE ID, host name, instance ID, associated component & path, and repair time.
        /// </summary>
        /// <param name="req"><see cref="CreateVulFixedExportJobRequest"/></param>
        /// <returns><see cref="CreateVulFixedExportJobResponse"/></returns>
        public CreateVulFixedExportJobResponse CreateVulFixedExportJobSync(CreateVulFixedExportJobRequest req)
        {
            return InternalRequestAsync<CreateVulFixedExportJobResponse>(req, "CreateVulFixedExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a vulnerability rescan
        /// </summary>
        /// <param name="req"><see cref="CreateVulReScanRequest"/></param>
        /// <returns><see cref="CreateVulReScanResponse"/></returns>
        public Task<CreateVulReScanResponse> CreateVulReScan(CreateVulReScanRequest req)
        {
            return InternalRequestAsync<CreateVulReScanResponse>(req, "CreateVulReScan");
        }

        /// <summary>
        /// This API is used to create a vulnerability rescan
        /// </summary>
        /// <param name="req"><see cref="CreateVulReScanRequest"/></param>
        /// <returns><see cref="CreateVulReScanResponse"/></returns>
        public CreateVulReScanResponse CreateVulReScanSync(CreateVulReScanRequest req)
        {
            return InternalRequestAsync<CreateVulReScanResponse>(req, "CreateVulReScan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a vulnerability risk export task.
        /// </summary>
        /// <param name="req"><see cref="CreateVulRisksExportJobRequest"/></param>
        /// <returns><see cref="CreateVulRisksExportJobResponse"/></returns>
        public Task<CreateVulRisksExportJobResponse> CreateVulRisksExportJob(CreateVulRisksExportJobRequest req)
        {
            return InternalRequestAsync<CreateVulRisksExportJobResponse>(req, "CreateVulRisksExportJob");
        }

        /// <summary>
        /// This API is used to create a vulnerability risk export task.
        /// </summary>
        /// <param name="req"><see cref="CreateVulRisksExportJobRequest"/></param>
        /// <returns><see cref="CreateVulRisksExportJobResponse"/></returns>
        public CreateVulRisksExportJobResponse CreateVulRisksExportJobSync(CreateVulRisksExportJobRequest req)
        {
            return InternalRequestAsync<CreateVulRisksExportJobResponse>(req, "CreateVulRisksExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a vulnerability scanning (one-click scan).
        /// </summary>
        /// <param name="req"><see cref="CreateVulScanManualRequest"/></param>
        /// <returns><see cref="CreateVulScanManualResponse"/></returns>
        public Task<CreateVulScanManualResponse> CreateVulScanManual(CreateVulScanManualRequest req)
        {
            return InternalRequestAsync<CreateVulScanManualResponse>(req, "CreateVulScanManual");
        }

        /// <summary>
        /// This API is used to create a vulnerability scanning (one-click scan).
        /// </summary>
        /// <param name="req"><see cref="CreateVulScanManualRequest"/></param>
        /// <returns><see cref="CreateVulScanManualResponse"/></returns>
        public CreateVulScanManualResponse CreateVulScanManualSync(CreateVulScanManualRequest req)
        {
            return InternalRequestAsync<CreateVulScanManualResponse>(req, "CreateVulScanManual")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete the SMTP mailbox access information of the AI assistant.
        /// </summary>
        /// <param name="req"><see cref="DeleteAIAnalysisSMTPAccessRequest"/></param>
        /// <returns><see cref="DeleteAIAnalysisSMTPAccessResponse"/></returns>
        public Task<DeleteAIAnalysisSMTPAccessResponse> DeleteAIAnalysisSMTPAccess(DeleteAIAnalysisSMTPAccessRequest req)
        {
            return InternalRequestAsync<DeleteAIAnalysisSMTPAccessResponse>(req, "DeleteAIAnalysisSMTPAccess");
        }

        /// <summary>
        /// Delete the SMTP mailbox access information of the AI assistant.
        /// </summary>
        /// <param name="req"><see cref="DeleteAIAnalysisSMTPAccessRequest"/></param>
        /// <returns><see cref="DeleteAIAnalysisSMTPAccessResponse"/></returns>
        public DeleteAIAnalysisSMTPAccessResponse DeleteAIAnalysisSMTPAccessSync(DeleteAIAnalysisSMTPAccessRequest req)
        {
            return InternalRequestAsync<DeleteAIAnalysisSMTPAccessResponse>(req, "DeleteAIAnalysisSMTPAccess")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete AI scheduled tasks.
        /// 
        /// This API is used to delete a scheduled task based on the specified AI scheduled task ID. Deletion is irreversible.
        /// </summary>
        /// <param name="req"><see cref="DeleteAIScheduleRequest"/></param>
        /// <returns><see cref="DeleteAIScheduleResponse"/></returns>
        public Task<DeleteAIScheduleResponse> DeleteAISchedule(DeleteAIScheduleRequest req)
        {
            return InternalRequestAsync<DeleteAIScheduleResponse>(req, "DeleteAISchedule");
        }

        /// <summary>
        /// This API is used to delete AI scheduled tasks.
        /// 
        /// This API is used to delete a scheduled task based on the specified AI scheduled task ID. Deletion is irreversible.
        /// </summary>
        /// <param name="req"><see cref="DeleteAIScheduleRequest"/></param>
        /// <returns><see cref="DeleteAIScheduleResponse"/></returns>
        public DeleteAIScheduleResponse DeleteAIScheduleSync(DeleteAIScheduleRequest req)
        {
            return InternalRequestAsync<DeleteAIScheduleResponse>(req, "DeleteAISchedule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete the search view of a user-created specified asset
        /// </summary>
        /// <param name="req"><see cref="DeleteAssetFilterViewRequest"/></param>
        /// <returns><see cref="DeleteAssetFilterViewResponse"/></returns>
        public Task<DeleteAssetFilterViewResponse> DeleteAssetFilterView(DeleteAssetFilterViewRequest req)
        {
            return InternalRequestAsync<DeleteAssetFilterViewResponse>(req, "DeleteAssetFilterView");
        }

        /// <summary>
        /// Delete the search view of a user-created specified asset
        /// </summary>
        /// <param name="req"><see cref="DeleteAssetFilterViewRequest"/></param>
        /// <returns><see cref="DeleteAssetFilterViewResponse"/></returns>
        public DeleteAssetFilterViewResponse DeleteAssetFilterViewSync(DeleteAssetFilterViewRequest req)
        {
            return InternalRequestAsync<DeleteAssetFilterViewResponse>(req, "DeleteAssetFilterView")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete asset tag
        /// </summary>
        /// <param name="req"><see cref="DeleteAssetTagRequest"/></param>
        /// <returns><see cref="DeleteAssetTagResponse"/></returns>
        public Task<DeleteAssetTagResponse> DeleteAssetTag(DeleteAssetTagRequest req)
        {
            return InternalRequestAsync<DeleteAssetTagResponse>(req, "DeleteAssetTag");
        }

        /// <summary>
        /// Delete asset tag
        /// </summary>
        /// <param name="req"><see cref="DeleteAssetTagRequest"/></param>
        /// <returns><see cref="DeleteAssetTagResponse"/></returns>
        public DeleteAssetTagResponse DeleteAssetTagSync(DeleteAssetTagRequest req)
        {
            return InternalRequestAsync<DeleteAssetTagResponse>(req, "DeleteAssetTag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete custom baseline policies in batches. Only support deletion of policies with PolicyType=SELF. After deletion, historical risk records are retained, but no new results are generated.
        /// </summary>
        /// <param name="req"><see cref="DeleteBaselineSelfDefinedPolicyListRequest"/></param>
        /// <returns><see cref="DeleteBaselineSelfDefinedPolicyListResponse"/></returns>
        public Task<DeleteBaselineSelfDefinedPolicyListResponse> DeleteBaselineSelfDefinedPolicyList(DeleteBaselineSelfDefinedPolicyListRequest req)
        {
            return InternalRequestAsync<DeleteBaselineSelfDefinedPolicyListResponse>(req, "DeleteBaselineSelfDefinedPolicyList");
        }

        /// <summary>
        /// Delete custom baseline policies in batches. Only support deletion of policies with PolicyType=SELF. After deletion, historical risk records are retained, but no new results are generated.
        /// </summary>
        /// <param name="req"><see cref="DeleteBaselineSelfDefinedPolicyListRequest"/></param>
        /// <returns><see cref="DeleteBaselineSelfDefinedPolicyListResponse"/></returns>
        public DeleteBaselineSelfDefinedPolicyListResponse DeleteBaselineSelfDefinedPolicyListSync(DeleteBaselineSelfDefinedPolicyListRequest req)
        {
            return InternalRequestAsync<DeleteBaselineSelfDefinedPolicyListResponse>(req, "DeleteBaselineSelfDefinedPolicyList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// CSIP manual scan task delete API
        /// </summary>
        /// <param name="req"><see cref="DeleteCSIPMalwareScanTaskRequest"/></param>
        /// <returns><see cref="DeleteCSIPMalwareScanTaskResponse"/></returns>
        public Task<DeleteCSIPMalwareScanTaskResponse> DeleteCSIPMalwareScanTask(DeleteCSIPMalwareScanTaskRequest req)
        {
            return InternalRequestAsync<DeleteCSIPMalwareScanTaskResponse>(req, "DeleteCSIPMalwareScanTask");
        }

        /// <summary>
        /// CSIP manual scan task delete API
        /// </summary>
        /// <param name="req"><see cref="DeleteCSIPMalwareScanTaskRequest"/></param>
        /// <returns><see cref="DeleteCSIPMalwareScanTaskResponse"/></returns>
        public DeleteCSIPMalwareScanTaskResponse DeleteCSIPMalwareScanTaskSync(DeleteCSIPMalwareScanTaskRequest req)
        {
            return InternalRequestAsync<DeleteCSIPMalwareScanTaskResponse>(req, "DeleteCSIPMalwareScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deleting a cluster
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRequest"/></param>
        /// <returns><see cref="DeleteClusterResponse"/></returns>
        public Task<DeleteClusterResponse> DeleteCluster(DeleteClusterRequest req)
        {
            return InternalRequestAsync<DeleteClusterResponse>(req, "DeleteCluster");
        }

        /// <summary>
        /// Deleting a cluster
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRequest"/></param>
        /// <returns><see cref="DeleteClusterResponse"/></returns>
        public DeleteClusterResponse DeleteClusterSync(DeleteClusterRequest req)
        {
            return InternalRequestAsync<DeleteClusterResponse>(req, "DeleteCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete Domain and IP Request
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainAndIpRequest"/></param>
        /// <returns><see cref="DeleteDomainAndIpResponse"/></returns>
        public Task<DeleteDomainAndIpResponse> DeleteDomainAndIp(DeleteDomainAndIpRequest req)
        {
            return InternalRequestAsync<DeleteDomainAndIpResponse>(req, "DeleteDomainAndIp");
        }

        /// <summary>
        /// Delete Domain and IP Request
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainAndIpRequest"/></param>
        /// <returns><see cref="DeleteDomainAndIpResponse"/></returns>
        public DeleteDomainAndIpResponse DeleteDomainAndIpSync(DeleteDomainAndIpRequest req)
        {
            return InternalRequestAsync<DeleteDomainAndIpResponse>(req, "DeleteDomainAndIp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deletes a Dspm application form.
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmApplyOrderRequest"/></param>
        /// <returns><see cref="DeleteDspmApplyOrderResponse"/></returns>
        public Task<DeleteDspmApplyOrderResponse> DeleteDspmApplyOrder(DeleteDspmApplyOrderRequest req)
        {
            return InternalRequestAsync<DeleteDspmApplyOrderResponse>(req, "DeleteDspmApplyOrder");
        }

        /// <summary>
        /// Deletes a Dspm application form.
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmApplyOrderRequest"/></param>
        /// <returns><see cref="DeleteDspmApplyOrderResponse"/></returns>
        public DeleteDspmApplyOrderResponse DeleteDspmApplyOrderSync(DeleteDspmApplyOrderRequest req)
        {
            return InternalRequestAsync<DeleteDspmApplyOrderResponse>(req, "DeleteDspmApplyOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a Dspm asset account
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmAssetAccountRequest"/></param>
        /// <returns><see cref="DeleteDspmAssetAccountResponse"/></returns>
        public Task<DeleteDspmAssetAccountResponse> DeleteDspmAssetAccount(DeleteDspmAssetAccountRequest req)
        {
            return InternalRequestAsync<DeleteDspmAssetAccountResponse>(req, "DeleteDspmAssetAccount");
        }

        /// <summary>
        /// Delete a Dspm asset account
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmAssetAccountRequest"/></param>
        /// <returns><see cref="DeleteDspmAssetAccountResponse"/></returns>
        public DeleteDspmAssetAccountResponse DeleteDspmAssetAccountSync(DeleteDspmAssetAccountRequest req)
        {
            return InternalRequestAsync<DeleteDspmAssetAccountResponse>(req, "DeleteDspmAssetAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a Dspm audit filter policy
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmAuditFilterStrategyRequest"/></param>
        /// <returns><see cref="DeleteDspmAuditFilterStrategyResponse"/></returns>
        public Task<DeleteDspmAuditFilterStrategyResponse> DeleteDspmAuditFilterStrategy(DeleteDspmAuditFilterStrategyRequest req)
        {
            return InternalRequestAsync<DeleteDspmAuditFilterStrategyResponse>(req, "DeleteDspmAuditFilterStrategy");
        }

        /// <summary>
        /// Delete a Dspm audit filter policy
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmAuditFilterStrategyRequest"/></param>
        /// <returns><see cref="DeleteDspmAuditFilterStrategyResponse"/></returns>
        public DeleteDspmAuditFilterStrategyResponse DeleteDspmAuditFilterStrategySync(DeleteDspmAuditFilterStrategyRequest req)
        {
            return InternalRequestAsync<DeleteDspmAuditFilterStrategyResponse>(req, "DeleteDspmAuditFilterStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the backup logs.
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmBackupLogListRequest"/></param>
        /// <returns><see cref="DeleteDspmBackupLogListResponse"/></returns>
        public Task<DeleteDspmBackupLogListResponse> DeleteDspmBackupLogList(DeleteDspmBackupLogListRequest req)
        {
            return InternalRequestAsync<DeleteDspmBackupLogListResponse>(req, "DeleteDspmBackupLogList");
        }

        /// <summary>
        /// This API is used to delete the backup logs.
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmBackupLogListRequest"/></param>
        /// <returns><see cref="DeleteDspmBackupLogListResponse"/></returns>
        public DeleteDspmBackupLogListResponse DeleteDspmBackupLogListSync(DeleteDspmBackupLogListRequest req)
        {
            return InternalRequestAsync<DeleteDspmBackupLogListResponse>(req, "DeleteDspmBackupLogList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to cancel the log shipping configuration.
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmCkafkaConfigRequest"/></param>
        /// <returns><see cref="DeleteDspmCkafkaConfigResponse"/></returns>
        public Task<DeleteDspmCkafkaConfigResponse> DeleteDspmCkafkaConfig(DeleteDspmCkafkaConfigRequest req)
        {
            return InternalRequestAsync<DeleteDspmCkafkaConfigResponse>(req, "DeleteDspmCkafkaConfig");
        }

        /// <summary>
        /// This API is used to cancel the log shipping configuration.
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmCkafkaConfigRequest"/></param>
        /// <returns><see cref="DeleteDspmCkafkaConfigResponse"/></returns>
        public DeleteDspmCkafkaConfigResponse DeleteDspmCkafkaConfigSync(DeleteDspmCkafkaConfigRequest req)
        {
            return InternalRequestAsync<DeleteDspmCkafkaConfigResponse>(req, "DeleteDspmCkafkaConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete export tasks.
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmExportTaskRequest"/></param>
        /// <returns><see cref="DeleteDspmExportTaskResponse"/></returns>
        public Task<DeleteDspmExportTaskResponse> DeleteDspmExportTask(DeleteDspmExportTaskRequest req)
        {
            return InternalRequestAsync<DeleteDspmExportTaskResponse>(req, "DeleteDspmExportTask");
        }

        /// <summary>
        /// This API is used to delete export tasks.
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmExportTaskRequest"/></param>
        /// <returns><see cref="DeleteDspmExportTaskResponse"/></returns>
        public DeleteDspmExportTaskResponse DeleteDspmExportTaskSync(DeleteDspmExportTaskRequest req)
        {
            return InternalRequestAsync<DeleteDspmExportTaskResponse>(req, "DeleteDspmExportTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete dspm data identification category
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmIdentifyCategoryRequest"/></param>
        /// <returns><see cref="DeleteDspmIdentifyCategoryResponse"/></returns>
        public Task<DeleteDspmIdentifyCategoryResponse> DeleteDspmIdentifyCategory(DeleteDspmIdentifyCategoryRequest req)
        {
            return InternalRequestAsync<DeleteDspmIdentifyCategoryResponse>(req, "DeleteDspmIdentifyCategory");
        }

        /// <summary>
        /// Delete dspm data identification category
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmIdentifyCategoryRequest"/></param>
        /// <returns><see cref="DeleteDspmIdentifyCategoryResponse"/></returns>
        public DeleteDspmIdentifyCategoryResponse DeleteDspmIdentifyCategorySync(DeleteDspmIdentifyCategoryRequest req)
        {
            return InternalRequestAsync<DeleteDspmIdentifyCategoryResponse>(req, "DeleteDspmIdentifyCategory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deletes classification association from a dspm identification template
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmIdentifyComplianceCategoryRelationRequest"/></param>
        /// <returns><see cref="DeleteDspmIdentifyComplianceCategoryRelationResponse"/></returns>
        public Task<DeleteDspmIdentifyComplianceCategoryRelationResponse> DeleteDspmIdentifyComplianceCategoryRelation(DeleteDspmIdentifyComplianceCategoryRelationRequest req)
        {
            return InternalRequestAsync<DeleteDspmIdentifyComplianceCategoryRelationResponse>(req, "DeleteDspmIdentifyComplianceCategoryRelation");
        }

        /// <summary>
        /// Deletes classification association from a dspm identification template
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmIdentifyComplianceCategoryRelationRequest"/></param>
        /// <returns><see cref="DeleteDspmIdentifyComplianceCategoryRelationResponse"/></returns>
        public DeleteDspmIdentifyComplianceCategoryRelationResponse DeleteDspmIdentifyComplianceCategoryRelationSync(DeleteDspmIdentifyComplianceCategoryRelationRequest req)
        {
            return InternalRequestAsync<DeleteDspmIdentifyComplianceCategoryRelationResponse>(req, "DeleteDspmIdentifyComplianceCategoryRelation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete dspm data identification template
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmIdentifyComplianceGroupRequest"/></param>
        /// <returns><see cref="DeleteDspmIdentifyComplianceGroupResponse"/></returns>
        public Task<DeleteDspmIdentifyComplianceGroupResponse> DeleteDspmIdentifyComplianceGroup(DeleteDspmIdentifyComplianceGroupRequest req)
        {
            return InternalRequestAsync<DeleteDspmIdentifyComplianceGroupResponse>(req, "DeleteDspmIdentifyComplianceGroup");
        }

        /// <summary>
        /// Delete dspm data identification template
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmIdentifyComplianceGroupRequest"/></param>
        /// <returns><see cref="DeleteDspmIdentifyComplianceGroupResponse"/></returns>
        public DeleteDspmIdentifyComplianceGroupResponse DeleteDspmIdentifyComplianceGroupSync(DeleteDspmIdentifyComplianceGroupRequest req)
        {
            return InternalRequestAsync<DeleteDspmIdentifyComplianceGroupResponse>(req, "DeleteDspmIdentifyComplianceGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete dspm data identification template data item association
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmIdentifyComplianceRuleRelationRequest"/></param>
        /// <returns><see cref="DeleteDspmIdentifyComplianceRuleRelationResponse"/></returns>
        public Task<DeleteDspmIdentifyComplianceRuleRelationResponse> DeleteDspmIdentifyComplianceRuleRelation(DeleteDspmIdentifyComplianceRuleRelationRequest req)
        {
            return InternalRequestAsync<DeleteDspmIdentifyComplianceRuleRelationResponse>(req, "DeleteDspmIdentifyComplianceRuleRelation");
        }

        /// <summary>
        /// Delete dspm data identification template data item association
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmIdentifyComplianceRuleRelationRequest"/></param>
        /// <returns><see cref="DeleteDspmIdentifyComplianceRuleRelationResponse"/></returns>
        public DeleteDspmIdentifyComplianceRuleRelationResponse DeleteDspmIdentifyComplianceRuleRelationSync(DeleteDspmIdentifyComplianceRuleRelationRequest req)
        {
            return InternalRequestAsync<DeleteDspmIdentifyComplianceRuleRelationResponse>(req, "DeleteDspmIdentifyComplianceRuleRelation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a dspm data identification classification group
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmIdentifyLevelGroupRequest"/></param>
        /// <returns><see cref="DeleteDspmIdentifyLevelGroupResponse"/></returns>
        public Task<DeleteDspmIdentifyLevelGroupResponse> DeleteDspmIdentifyLevelGroup(DeleteDspmIdentifyLevelGroupRequest req)
        {
            return InternalRequestAsync<DeleteDspmIdentifyLevelGroupResponse>(req, "DeleteDspmIdentifyLevelGroup");
        }

        /// <summary>
        /// Delete a dspm data identification classification group
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmIdentifyLevelGroupRequest"/></param>
        /// <returns><see cref="DeleteDspmIdentifyLevelGroupResponse"/></returns>
        public DeleteDspmIdentifyLevelGroupResponse DeleteDspmIdentifyLevelGroupSync(DeleteDspmIdentifyLevelGroupRequest req)
        {
            return InternalRequestAsync<DeleteDspmIdentifyLevelGroupResponse>(req, "DeleteDspmIdentifyLevelGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete dspm data identification data item
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmIdentifyRuleRequest"/></param>
        /// <returns><see cref="DeleteDspmIdentifyRuleResponse"/></returns>
        public Task<DeleteDspmIdentifyRuleResponse> DeleteDspmIdentifyRule(DeleteDspmIdentifyRuleRequest req)
        {
            return InternalRequestAsync<DeleteDspmIdentifyRuleResponse>(req, "DeleteDspmIdentifyRule");
        }

        /// <summary>
        /// Delete dspm data identification data item
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmIdentifyRuleRequest"/></param>
        /// <returns><see cref="DeleteDspmIdentifyRuleResponse"/></returns>
        public DeleteDspmIdentifyRuleResponse DeleteDspmIdentifyRuleSync(DeleteDspmIdentifyRuleRequest req)
        {
            return InternalRequestAsync<DeleteDspmIdentifyRuleResponse>(req, "DeleteDspmIdentifyRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a Dspm personal identity id.
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmPersonalIdentifyRequest"/></param>
        /// <returns><see cref="DeleteDspmPersonalIdentifyResponse"/></returns>
        public Task<DeleteDspmPersonalIdentifyResponse> DeleteDspmPersonalIdentify(DeleteDspmPersonalIdentifyRequest req)
        {
            return InternalRequestAsync<DeleteDspmPersonalIdentifyResponse>(req, "DeleteDspmPersonalIdentify");
        }

        /// <summary>
        /// Delete a Dspm personal identity id.
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmPersonalIdentifyRequest"/></param>
        /// <returns><see cref="DeleteDspmPersonalIdentifyResponse"/></returns>
        public DeleteDspmPersonalIdentifyResponse DeleteDspmPersonalIdentifySync(DeleteDspmPersonalIdentifyRequest req)
        {
            return InternalRequestAsync<DeleteDspmPersonalIdentifyResponse>(req, "DeleteDspmPersonalIdentify")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete restore logs
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmRestoreLogListRequest"/></param>
        /// <returns><see cref="DeleteDspmRestoreLogListResponse"/></returns>
        public Task<DeleteDspmRestoreLogListResponse> DeleteDspmRestoreLogList(DeleteDspmRestoreLogListRequest req)
        {
            return InternalRequestAsync<DeleteDspmRestoreLogListResponse>(req, "DeleteDspmRestoreLogList");
        }

        /// <summary>
        /// Delete restore logs
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmRestoreLogListRequest"/></param>
        /// <returns><see cref="DeleteDspmRestoreLogListResponse"/></returns>
        public DeleteDspmRestoreLogListResponse DeleteDspmRestoreLogListSync(DeleteDspmRestoreLogListRequest req)
        {
            return InternalRequestAsync<DeleteDspmRestoreLogListResponse>(req, "DeleteDspmRestoreLogList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a DSPM custom risk policy. It only supports deletion of custom policies with rule_source=custom. Built-in policies are non-deletable. Disable them by setting IsEnabled in ModifyDspmRiskStrategy.
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmRiskStrategyRequest"/></param>
        /// <returns><see cref="DeleteDspmRiskStrategyResponse"/></returns>
        public Task<DeleteDspmRiskStrategyResponse> DeleteDspmRiskStrategy(DeleteDspmRiskStrategyRequest req)
        {
            return InternalRequestAsync<DeleteDspmRiskStrategyResponse>(req, "DeleteDspmRiskStrategy");
        }

        /// <summary>
        /// This API is used to delete a DSPM custom risk policy. It only supports deletion of custom policies with rule_source=custom. Built-in policies are non-deletable. Disable them by setting IsEnabled in ModifyDspmRiskStrategy.
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmRiskStrategyRequest"/></param>
        /// <returns><see cref="DeleteDspmRiskStrategyResponse"/></returns>
        public DeleteDspmRiskStrategyResponse DeleteDspmRiskStrategySync(DeleteDspmRiskStrategyRequest req)
        {
            return InternalRequestAsync<DeleteDspmRiskStrategyResponse>(req, "DeleteDspmRiskStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete dspmg shared account data
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmShareUserDataRequest"/></param>
        /// <returns><see cref="DeleteDspmShareUserDataResponse"/></returns>
        public Task<DeleteDspmShareUserDataResponse> DeleteDspmShareUserData(DeleteDspmShareUserDataRequest req)
        {
            return InternalRequestAsync<DeleteDspmShareUserDataResponse>(req, "DeleteDspmShareUserData");
        }

        /// <summary>
        /// Delete dspmg shared account data
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmShareUserDataRequest"/></param>
        /// <returns><see cref="DeleteDspmShareUserDataResponse"/></returns>
        public DeleteDspmShareUserDataResponse DeleteDspmShareUserDataSync(DeleteDspmShareUserDataRequest req)
        {
            return InternalRequestAsync<DeleteDspmShareUserDataResponse>(req, "DeleteDspmShareUserData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a Dspm allowlist policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmWhitelistStrategyRequest"/></param>
        /// <returns><see cref="DeleteDspmWhitelistStrategyResponse"/></returns>
        public Task<DeleteDspmWhitelistStrategyResponse> DeleteDspmWhitelistStrategy(DeleteDspmWhitelistStrategyRequest req)
        {
            return InternalRequestAsync<DeleteDspmWhitelistStrategyResponse>(req, "DeleteDspmWhitelistStrategy");
        }

        /// <summary>
        /// Delete a Dspm allowlist policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmWhitelistStrategyRequest"/></param>
        /// <returns><see cref="DeleteDspmWhitelistStrategyResponse"/></returns>
        public DeleteDspmWhitelistStrategyResponse DeleteDspmWhitelistStrategySync(DeleteDspmWhitelistStrategyRequest req)
        {
            return InternalRequestAsync<DeleteDspmWhitelistStrategyResponse>(req, "DeleteDspmWhitelistStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete EDR policies.
        /// </summary>
        /// <param name="req"><see cref="DeleteEDRRulesRequest"/></param>
        /// <returns><see cref="DeleteEDRRulesResponse"/></returns>
        public Task<DeleteEDRRulesResponse> DeleteEDRRules(DeleteEDRRulesRequest req)
        {
            return InternalRequestAsync<DeleteEDRRulesResponse>(req, "DeleteEDRRules");
        }

        /// <summary>
        /// This API is used to delete EDR policies.
        /// </summary>
        /// <param name="req"><see cref="DeleteEDRRulesRequest"/></param>
        /// <returns><see cref="DeleteEDRRulesResponse"/></returns>
        public DeleteEDRRulesResponse DeleteEDRRulesSync(DeleteEDRRulesRequest req)
        {
            return InternalRequestAsync<DeleteEDRRulesResponse>(req, "DeleteEDRRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete terminated scan tasks by physically deleting the primary and detailed tables. Only tasks in the final state can be deleted, and only the creator can perform the deletion.
        /// </summary>
        /// <param name="req"><see cref="DeleteEDRScanTaskRequest"/></param>
        /// <returns><see cref="DeleteEDRScanTaskResponse"/></returns>
        public Task<DeleteEDRScanTaskResponse> DeleteEDRScanTask(DeleteEDRScanTaskRequest req)
        {
            return InternalRequestAsync<DeleteEDRScanTaskResponse>(req, "DeleteEDRScanTask");
        }

        /// <summary>
        /// This API is used to delete terminated scan tasks by physically deleting the primary and detailed tables. Only tasks in the final state can be deleted, and only the creator can perform the deletion.
        /// </summary>
        /// <param name="req"><see cref="DeleteEDRScanTaskRequest"/></param>
        /// <returns><see cref="DeleteEDRScanTaskResponse"/></returns>
        public DeleteEDRScanTaskResponse DeleteEDRScanTaskSync(DeleteEDRScanTaskRequest req)
        {
            return InternalRequestAsync<DeleteEDRScanTaskResponse>(req, "DeleteEDRScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete EDR log collection path configurations in batches.
        /// </summary>
        /// <param name="req"><see cref="DeleteEdrLogCollectPathsRequest"/></param>
        /// <returns><see cref="DeleteEdrLogCollectPathsResponse"/></returns>
        public Task<DeleteEdrLogCollectPathsResponse> DeleteEdrLogCollectPaths(DeleteEdrLogCollectPathsRequest req)
        {
            return InternalRequestAsync<DeleteEdrLogCollectPathsResponse>(req, "DeleteEdrLogCollectPaths");
        }

        /// <summary>
        /// Delete EDR log collection path configurations in batches.
        /// </summary>
        /// <param name="req"><see cref="DeleteEdrLogCollectPathsRequest"/></param>
        /// <returns><see cref="DeleteEdrLogCollectPathsResponse"/></returns>
        public DeleteEdrLogCollectPathsResponse DeleteEdrLogCollectPathsSync(DeleteEdrLogCollectPathsRequest req)
        {
            return InternalRequestAsync<DeleteEdrLogCollectPathsResponse>(req, "DeleteEdrLogCollectPaths")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete rules for automatic cloud boundary tagging.
        /// </summary>
        /// <param name="req"><see cref="DeleteExposureAutoTagRuleRequest"/></param>
        /// <returns><see cref="DeleteExposureAutoTagRuleResponse"/></returns>
        public Task<DeleteExposureAutoTagRuleResponse> DeleteExposureAutoTagRule(DeleteExposureAutoTagRuleRequest req)
        {
            return InternalRequestAsync<DeleteExposureAutoTagRuleResponse>(req, "DeleteExposureAutoTagRule");
        }

        /// <summary>
        /// Delete rules for automatic cloud boundary tagging.
        /// </summary>
        /// <param name="req"><see cref="DeleteExposureAutoTagRuleRequest"/></param>
        /// <returns><see cref="DeleteExposureAutoTagRuleResponse"/></returns>
        public DeleteExposureAutoTagRuleResponse DeleteExposureAutoTagRuleSync(DeleteExposureAutoTagRuleRequest req)
        {
            return InternalRequestAsync<DeleteExposureAutoTagRuleResponse>(req, "DeleteExposureAutoTagRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete an IaC detection integration Token
        /// </summary>
        /// <param name="req"><see cref="DeleteIaCAccessTokenRequest"/></param>
        /// <returns><see cref="DeleteIaCAccessTokenResponse"/></returns>
        public Task<DeleteIaCAccessTokenResponse> DeleteIaCAccessToken(DeleteIaCAccessTokenRequest req)
        {
            return InternalRequestAsync<DeleteIaCAccessTokenResponse>(req, "DeleteIaCAccessToken");
        }

        /// <summary>
        /// Delete an IaC detection integration Token
        /// </summary>
        /// <param name="req"><see cref="DeleteIaCAccessTokenRequest"/></param>
        /// <returns><see cref="DeleteIaCAccessTokenResponse"/></returns>
        public DeleteIaCAccessTokenResponse DeleteIaCAccessTokenSync(DeleteIaCAccessTokenRequest req)
        {
            return InternalRequestAsync<DeleteIaCAccessTokenResponse>(req, "DeleteIaCAccessToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete an IaC detection file
        /// </summary>
        /// <param name="req"><see cref="DeleteIaCFileRequest"/></param>
        /// <returns><see cref="DeleteIaCFileResponse"/></returns>
        public Task<DeleteIaCFileResponse> DeleteIaCFile(DeleteIaCFileRequest req)
        {
            return InternalRequestAsync<DeleteIaCFileResponse>(req, "DeleteIaCFile");
        }

        /// <summary>
        /// Delete an IaC detection file
        /// </summary>
        /// <param name="req"><see cref="DeleteIaCFileRequest"/></param>
        /// <returns><see cref="DeleteIaCFileResponse"/></returns>
        public DeleteIaCFileResponse DeleteIaCFileSync(DeleteIaCFileRequest req)
        {
            return InternalRequestAsync<DeleteIaCFileResponse>(req, "DeleteIaCFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete image repository information.
        /// </summary>
        /// <param name="req"><see cref="DeleteImageRegistryRequest"/></param>
        /// <returns><see cref="DeleteImageRegistryResponse"/></returns>
        public Task<DeleteImageRegistryResponse> DeleteImageRegistry(DeleteImageRegistryRequest req)
        {
            return InternalRequestAsync<DeleteImageRegistryResponse>(req, "DeleteImageRegistry");
        }

        /// <summary>
        /// Delete image repository information.
        /// </summary>
        /// <param name="req"><see cref="DeleteImageRegistryRequest"/></param>
        /// <returns><see cref="DeleteImageRegistryResponse"/></returns>
        public DeleteImageRegistryResponse DeleteImageRegistrySync(DeleteImageRegistryRequest req)
        {
            return InternalRequestAsync<DeleteImageRegistryResponse>(req, "DeleteImageRegistry")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deletes an image repository scanning task.
        /// </summary>
        /// <param name="req"><see cref="DeleteImageRegistryScanTaskRequest"/></param>
        /// <returns><see cref="DeleteImageRegistryScanTaskResponse"/></returns>
        public Task<DeleteImageRegistryScanTaskResponse> DeleteImageRegistryScanTask(DeleteImageRegistryScanTaskRequest req)
        {
            return InternalRequestAsync<DeleteImageRegistryScanTaskResponse>(req, "DeleteImageRegistryScanTask");
        }

        /// <summary>
        /// Deletes an image repository scanning task.
        /// </summary>
        /// <param name="req"><see cref="DeleteImageRegistryScanTaskRequest"/></param>
        /// <returns><see cref="DeleteImageRegistryScanTaskResponse"/></returns>
        public DeleteImageRegistryScanTaskResponse DeleteImageRegistryScanTaskSync(DeleteImageRegistryScanTaskRequest req)
        {
            return InternalRequestAsync<DeleteImageRegistryScanTaskResponse>(req, "DeleteImageRegistryScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete the scheduled scan task configuration of an image repository.
        /// </summary>
        /// <param name="req"><see cref="DeleteImageRegistryTimedScanTaskConfigRequest"/></param>
        /// <returns><see cref="DeleteImageRegistryTimedScanTaskConfigResponse"/></returns>
        public Task<DeleteImageRegistryTimedScanTaskConfigResponse> DeleteImageRegistryTimedScanTaskConfig(DeleteImageRegistryTimedScanTaskConfigRequest req)
        {
            return InternalRequestAsync<DeleteImageRegistryTimedScanTaskConfigResponse>(req, "DeleteImageRegistryTimedScanTaskConfig");
        }

        /// <summary>
        /// Delete the scheduled scan task configuration of an image repository.
        /// </summary>
        /// <param name="req"><see cref="DeleteImageRegistryTimedScanTaskConfigRequest"/></param>
        /// <returns><see cref="DeleteImageRegistryTimedScanTaskConfigResponse"/></returns>
        public DeleteImageRegistryTimedScanTaskConfigResponse DeleteImageRegistryTimedScanTaskConfigSync(DeleteImageRegistryTimedScanTaskConfigRequest req)
        {
            return InternalRequestAsync<DeleteImageRegistryTimedScanTaskConfigResponse>(req, "DeleteImageRegistryTimedScanTaskConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an allowlist for sensitive information from a container image.
        /// </summary>
        /// <param name="req"><see cref="DeleteImageSensitiveWhitelistRequest"/></param>
        /// <returns><see cref="DeleteImageSensitiveWhitelistResponse"/></returns>
        public Task<DeleteImageSensitiveWhitelistResponse> DeleteImageSensitiveWhitelist(DeleteImageSensitiveWhitelistRequest req)
        {
            return InternalRequestAsync<DeleteImageSensitiveWhitelistResponse>(req, "DeleteImageSensitiveWhitelist");
        }

        /// <summary>
        /// This API is used to delete an allowlist for sensitive information from a container image.
        /// </summary>
        /// <param name="req"><see cref="DeleteImageSensitiveWhitelistRequest"/></param>
        /// <returns><see cref="DeleteImageSensitiveWhitelistResponse"/></returns>
        public DeleteImageSensitiveWhitelistResponse DeleteImageSensitiveWhitelistSync(DeleteImageSensitiveWhitelistRequest req)
        {
            return InternalRequestAsync<DeleteImageSensitiveWhitelistResponse>(req, "DeleteImageSensitiveWhitelist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the image Trojan allowlist.
        /// </summary>
        /// <param name="req"><see cref="DeleteImageVirusWhitelistRequest"/></param>
        /// <returns><see cref="DeleteImageVirusWhitelistResponse"/></returns>
        public Task<DeleteImageVirusWhitelistResponse> DeleteImageVirusWhitelist(DeleteImageVirusWhitelistRequest req)
        {
            return InternalRequestAsync<DeleteImageVirusWhitelistResponse>(req, "DeleteImageVirusWhitelist");
        }

        /// <summary>
        /// This API is used to delete the image Trojan allowlist.
        /// </summary>
        /// <param name="req"><see cref="DeleteImageVirusWhitelistRequest"/></param>
        /// <returns><see cref="DeleteImageVirusWhitelistResponse"/></returns>
        public DeleteImageVirusWhitelistResponse DeleteImageVirusWhitelistSync(DeleteImageVirusWhitelistRequest req)
        {
            return InternalRequestAsync<DeleteImageVirusWhitelistResponse>(req, "DeleteImageVirusWhitelist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deletes the vulnerability allowlist of a container image
        /// </summary>
        /// <param name="req"><see cref="DeleteImageVulWhitelistRequest"/></param>
        /// <returns><see cref="DeleteImageVulWhitelistResponse"/></returns>
        public Task<DeleteImageVulWhitelistResponse> DeleteImageVulWhitelist(DeleteImageVulWhitelistRequest req)
        {
            return InternalRequestAsync<DeleteImageVulWhitelistResponse>(req, "DeleteImageVulWhitelist");
        }

        /// <summary>
        /// Deletes the vulnerability allowlist of a container image
        /// </summary>
        /// <param name="req"><see cref="DeleteImageVulWhitelistRequest"/></param>
        /// <returns><see cref="DeleteImageVulWhitelistResponse"/></returns>
        public DeleteImageVulWhitelistResponse DeleteImageVulWhitelistSync(DeleteImageVulWhitelistRequest req)
        {
            return InternalRequestAsync<DeleteImageVulWhitelistResponse>(req, "DeleteImageVulWhitelist")
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
        /// Delete Risk Center Scan Task
        /// </summary>
        /// <param name="req"><see cref="DeleteRiskScanTaskRequest"/></param>
        /// <returns><see cref="DeleteRiskScanTaskResponse"/></returns>
        public Task<DeleteRiskScanTaskResponse> DeleteRiskScanTask(DeleteRiskScanTaskRequest req)
        {
            return InternalRequestAsync<DeleteRiskScanTaskResponse>(req, "DeleteRiskScanTask");
        }

        /// <summary>
        /// Delete Risk Center Scan Task
        /// </summary>
        /// <param name="req"><see cref="DeleteRiskScanTaskRequest"/></param>
        /// <returns><see cref="DeleteRiskScanTaskResponse"/></returns>
        public DeleteRiskScanTaskResponse DeleteRiskScanTaskSync(DeleteRiskScanTaskRequest req)
        {
            return InternalRequestAsync<DeleteRiskScanTaskResponse>(req, "DeleteRiskScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete ACL user rules in batches. After deletion, rules are no longer returned in list queries and no longer take effect on traffic. If any ID does not exist or belongs to another tenant, an error is returned overall.
        /// </summary>
        /// <param name="req"><see cref="DeleteSandboxACLRuleRequest"/></param>
        /// <returns><see cref="DeleteSandboxACLRuleResponse"/></returns>
        public Task<DeleteSandboxACLRuleResponse> DeleteSandboxACLRule(DeleteSandboxACLRuleRequest req)
        {
            return InternalRequestAsync<DeleteSandboxACLRuleResponse>(req, "DeleteSandboxACLRule");
        }

        /// <summary>
        /// Delete ACL user rules in batches. After deletion, rules are no longer returned in list queries and no longer take effect on traffic. If any ID does not exist or belongs to another tenant, an error is returned overall.
        /// </summary>
        /// <param name="req"><see cref="DeleteSandboxACLRuleRequest"/></param>
        /// <returns><see cref="DeleteSandboxACLRuleResponse"/></returns>
        public DeleteSandboxACLRuleResponse DeleteSandboxACLRuleSync(DeleteSandboxACLRuleRequest req)
        {
            return InternalRequestAsync<DeleteSandboxACLRuleResponse>(req, "DeleteSandboxACLRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Batch delete DLP user rules. If any ID does not exist or belongs to another tenant, an error is returned for the entire request.
        /// </summary>
        /// <param name="req"><see cref="DeleteSandboxDLPRuleRequest"/></param>
        /// <returns><see cref="DeleteSandboxDLPRuleResponse"/></returns>
        public Task<DeleteSandboxDLPRuleResponse> DeleteSandboxDLPRule(DeleteSandboxDLPRuleRequest req)
        {
            return InternalRequestAsync<DeleteSandboxDLPRuleResponse>(req, "DeleteSandboxDLPRule");
        }

        /// <summary>
        /// Batch delete DLP user rules. If any ID does not exist or belongs to another tenant, an error is returned for the entire request.
        /// </summary>
        /// <param name="req"><see cref="DeleteSandboxDLPRuleRequest"/></param>
        /// <returns><see cref="DeleteSandboxDLPRuleResponse"/></returns>
        public DeleteSandboxDLPRuleResponse DeleteSandboxDLPRuleSync(DeleteSandboxDLPRuleRequest req)
        {
            return InternalRequestAsync<DeleteSandboxDLPRuleResponse>(req, "DeleteSandboxDLPRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create command sandbox file access policy
        /// </summary>
        /// <param name="req"><see cref="DeleteSandboxFileRuleRequest"/></param>
        /// <returns><see cref="DeleteSandboxFileRuleResponse"/></returns>
        public Task<DeleteSandboxFileRuleResponse> DeleteSandboxFileRule(DeleteSandboxFileRuleRequest req)
        {
            return InternalRequestAsync<DeleteSandboxFileRuleResponse>(req, "DeleteSandboxFileRule");
        }

        /// <summary>
        /// Create command sandbox file access policy
        /// </summary>
        /// <param name="req"><see cref="DeleteSandboxFileRuleRequest"/></param>
        /// <returns><see cref="DeleteSandboxFileRuleResponse"/></returns>
        public DeleteSandboxFileRuleResponse DeleteSandboxFileRuleSync(DeleteSandboxFileRuleRequest req)
        {
            return InternalRequestAsync<DeleteSandboxFileRuleResponse>(req, "DeleteSandboxFileRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Batch delete LLM audit user rules. If any ID does not exist or belongs to another tenant, an error is returned overall.
        /// </summary>
        /// <param name="req"><see cref="DeleteSandboxLLMAuditRuleRequest"/></param>
        /// <returns><see cref="DeleteSandboxLLMAuditRuleResponse"/></returns>
        public Task<DeleteSandboxLLMAuditRuleResponse> DeleteSandboxLLMAuditRule(DeleteSandboxLLMAuditRuleRequest req)
        {
            return InternalRequestAsync<DeleteSandboxLLMAuditRuleResponse>(req, "DeleteSandboxLLMAuditRule");
        }

        /// <summary>
        /// Batch delete LLM audit user rules. If any ID does not exist or belongs to another tenant, an error is returned overall.
        /// </summary>
        /// <param name="req"><see cref="DeleteSandboxLLMAuditRuleRequest"/></param>
        /// <returns><see cref="DeleteSandboxLLMAuditRuleResponse"/></returns>
        public DeleteSandboxLLMAuditRuleResponse DeleteSandboxLLMAuditRuleSync(DeleteSandboxLLMAuditRuleRequest req)
        {
            return InternalRequestAsync<DeleteSandboxLLMAuditRuleResponse>(req, "DeleteSandboxLLMAuditRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a vulnerability allowlist.
        /// </summary>
        /// <param name="req"><see cref="DeleteVulWhitelistRequest"/></param>
        /// <returns><see cref="DeleteVulWhitelistResponse"/></returns>
        public Task<DeleteVulWhitelistResponse> DeleteVulWhitelist(DeleteVulWhitelistRequest req)
        {
            return InternalRequestAsync<DeleteVulWhitelistResponse>(req, "DeleteVulWhitelist");
        }

        /// <summary>
        /// This API is used to delete a vulnerability allowlist.
        /// </summary>
        /// <param name="req"><see cref="DeleteVulWhitelistRequest"/></param>
        /// <returns><see cref="DeleteVulWhitelistResponse"/></returns>
        public DeleteVulWhitelistResponse DeleteVulWhitelistSync(DeleteVulWhitelistRequest req)
        {
            return InternalRequestAsync<DeleteVulWhitelistResponse>(req, "DeleteVulWhitelist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete notification policies in batches.
        /// </summary>
        /// <param name="req"><see cref="DeleteWebhookPoliciesRequest"/></param>
        /// <returns><see cref="DeleteWebhookPoliciesResponse"/></returns>
        public Task<DeleteWebhookPoliciesResponse> DeleteWebhookPolicies(DeleteWebhookPoliciesRequest req)
        {
            return InternalRequestAsync<DeleteWebhookPoliciesResponse>(req, "DeleteWebhookPolicies");
        }

        /// <summary>
        /// Delete notification policies in batches.
        /// </summary>
        /// <param name="req"><see cref="DeleteWebhookPoliciesRequest"/></param>
        /// <returns><see cref="DeleteWebhookPoliciesResponse"/></returns>
        public DeleteWebhookPoliciesResponse DeleteWebhookPoliciesSync(DeleteWebhookPoliciesRequest req)
        {
            return InternalRequestAsync<DeleteWebhookPoliciesResponse>(req, "DeleteWebhookPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete receiving robots in batches. Before deletion, the reference relationships are automatically removed from all policies that refer to these robots.
        /// </summary>
        /// <param name="req"><see cref="DeleteWebhookReceiversRequest"/></param>
        /// <returns><see cref="DeleteWebhookReceiversResponse"/></returns>
        public Task<DeleteWebhookReceiversResponse> DeleteWebhookReceivers(DeleteWebhookReceiversRequest req)
        {
            return InternalRequestAsync<DeleteWebhookReceiversResponse>(req, "DeleteWebhookReceivers");
        }

        /// <summary>
        /// Delete receiving robots in batches. Before deletion, the reference relationships are automatically removed from all policies that refer to these robots.
        /// </summary>
        /// <param name="req"><see cref="DeleteWebhookReceiversRequest"/></param>
        /// <returns><see cref="DeleteWebhookReceiversResponse"/></returns>
        public DeleteWebhookReceiversResponse DeleteWebhookReceiversSync(DeleteWebhookReceiversRequest req)
        {
            return InternalRequestAsync<DeleteWebhookReceiversResponse>(req, "DeleteWebhookReceivers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Search for AI agent asset list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAgentAssetListRequest"/></param>
        /// <returns><see cref="DescribeAIAgentAssetListResponse"/></returns>
        public Task<DescribeAIAgentAssetListResponse> DescribeAIAgentAssetList(DescribeAIAgentAssetListRequest req)
        {
            return InternalRequestAsync<DescribeAIAgentAssetListResponse>(req, "DescribeAIAgentAssetList");
        }

        /// <summary>
        /// Search for AI agent asset list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAgentAssetListRequest"/></param>
        /// <returns><see cref="DescribeAIAgentAssetListResponse"/></returns>
        public DescribeAIAgentAssetListResponse DescribeAIAgentAssetListSync(DescribeAIAgentAssetListRequest req)
        {
            return InternalRequestAsync<DescribeAIAgentAssetListResponse>(req, "DescribeAIAgentAssetList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retrieves the scan list of AIAgent asset credentials
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAgentCredentialListRequest"/></param>
        /// <returns><see cref="DescribeAIAgentCredentialListResponse"/></returns>
        public Task<DescribeAIAgentCredentialListResponse> DescribeAIAgentCredentialList(DescribeAIAgentCredentialListRequest req)
        {
            return InternalRequestAsync<DescribeAIAgentCredentialListResponse>(req, "DescribeAIAgentCredentialList");
        }

        /// <summary>
        /// Retrieves the scan list of AIAgent asset credentials
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAgentCredentialListRequest"/></param>
        /// <returns><see cref="DescribeAIAgentCredentialListResponse"/></returns>
        public DescribeAIAgentCredentialListResponse DescribeAIAgentCredentialListSync(DescribeAIAgentCredentialListRequest req)
        {
            return InternalRequestAsync<DescribeAIAgentCredentialListResponse>(req, "DescribeAIAgentCredentialList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the leaked location list of one credential by credential group row ID in pages. It is used with the DescribeAIAgentCredentialList interface in the split and unfold scenario to avoid performance issues caused by pulling hundreds of thousands of locations at once in data skew scenarios.
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAgentCredentialLocationListRequest"/></param>
        /// <returns><see cref="DescribeAIAgentCredentialLocationListResponse"/></returns>
        public Task<DescribeAIAgentCredentialLocationListResponse> DescribeAIAgentCredentialLocationList(DescribeAIAgentCredentialLocationListRequest req)
        {
            return InternalRequestAsync<DescribeAIAgentCredentialLocationListResponse>(req, "DescribeAIAgentCredentialLocationList");
        }

        /// <summary>
        /// This API is used to query the leaked location list of one credential by credential group row ID in pages. It is used with the DescribeAIAgentCredentialList interface in the split and unfold scenario to avoid performance issues caused by pulling hundreds of thousands of locations at once in data skew scenarios.
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAgentCredentialLocationListRequest"/></param>
        /// <returns><see cref="DescribeAIAgentCredentialLocationListResponse"/></returns>
        public DescribeAIAgentCredentialLocationListResponse DescribeAIAgentCredentialLocationListSync(DescribeAIAgentCredentialLocationListRequest req)
        {
            return InternalRequestAsync<DescribeAIAgentCredentialLocationListResponse>(req, "DescribeAIAgentCredentialLocationList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Search the skill list of an AI Agent
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAgentSkillListRequest"/></param>
        /// <returns><see cref="DescribeAIAgentSkillListResponse"/></returns>
        public Task<DescribeAIAgentSkillListResponse> DescribeAIAgentSkillList(DescribeAIAgentSkillListRequest req)
        {
            return InternalRequestAsync<DescribeAIAgentSkillListResponse>(req, "DescribeAIAgentSkillList");
        }

        /// <summary>
        /// Search the skill list of an AI Agent
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAgentSkillListRequest"/></param>
        /// <returns><see cref="DescribeAIAgentSkillListResponse"/></returns>
        public DescribeAIAgentSkillListResponse DescribeAIAgentSkillListSync(DescribeAIAgentSkillListRequest req)
        {
            return InternalRequestAsync<DescribeAIAgentSkillListResponse>(req, "DescribeAIAgentSkillList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get the temporary download link of an AI analysis file.
        /// 
        /// The original address of the input file. Returns a signed temporary download link with a validity period of 2 hours.
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAnalysisFileDownloadURLRequest"/></param>
        /// <returns><see cref="DescribeAIAnalysisFileDownloadURLResponse"/></returns>
        public Task<DescribeAIAnalysisFileDownloadURLResponse> DescribeAIAnalysisFileDownloadURL(DescribeAIAnalysisFileDownloadURLRequest req)
        {
            return InternalRequestAsync<DescribeAIAnalysisFileDownloadURLResponse>(req, "DescribeAIAnalysisFileDownloadURL");
        }

        /// <summary>
        /// Get the temporary download link of an AI analysis file.
        /// 
        /// The original address of the input file. Returns a signed temporary download link with a validity period of 2 hours.
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAnalysisFileDownloadURLRequest"/></param>
        /// <returns><see cref="DescribeAIAnalysisFileDownloadURLResponse"/></returns>
        public DescribeAIAnalysisFileDownloadURLResponse DescribeAIAnalysisFileDownloadURLSync(DescribeAIAnalysisFileDownloadURLRequest req)
        {
            return InternalRequestAsync<DescribeAIAnalysisFileDownloadURLResponse>(req, "DescribeAIAnalysisFileDownloadURL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retrieve historical analysis records of the cloud security AI assistant.
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAnalysisHistoryRequest"/></param>
        /// <returns><see cref="DescribeAIAnalysisHistoryResponse"/></returns>
        public Task<DescribeAIAnalysisHistoryResponse> DescribeAIAnalysisHistory(DescribeAIAnalysisHistoryRequest req)
        {
            return InternalRequestAsync<DescribeAIAnalysisHistoryResponse>(req, "DescribeAIAnalysisHistory");
        }

        /// <summary>
        /// Retrieve historical analysis records of the cloud security AI assistant.
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAnalysisHistoryRequest"/></param>
        /// <returns><see cref="DescribeAIAnalysisHistoryResponse"/></returns>
        public DescribeAIAnalysisHistoryResponse DescribeAIAnalysisHistorySync(DescribeAIAnalysisHistoryRequest req)
        {
            return InternalRequestAsync<DescribeAIAnalysisHistoryResponse>(req, "DescribeAIAnalysisHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retrieve recommended questions for AI QA.
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAnalysisRecommendQuestionsRequest"/></param>
        /// <returns><see cref="DescribeAIAnalysisRecommendQuestionsResponse"/></returns>
        public Task<DescribeAIAnalysisRecommendQuestionsResponse> DescribeAIAnalysisRecommendQuestions(DescribeAIAnalysisRecommendQuestionsRequest req)
        {
            return InternalRequestAsync<DescribeAIAnalysisRecommendQuestionsResponse>(req, "DescribeAIAnalysisRecommendQuestions");
        }

        /// <summary>
        /// Retrieve recommended questions for AI QA.
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAnalysisRecommendQuestionsRequest"/></param>
        /// <returns><see cref="DescribeAIAnalysisRecommendQuestionsResponse"/></returns>
        public DescribeAIAnalysisRecommendQuestionsResponse DescribeAIAnalysisRecommendQuestionsSync(DescribeAIAnalysisRecommendQuestionsRequest req)
        {
            return InternalRequestAsync<DescribeAIAnalysisRecommendQuestionsResponse>(req, "DescribeAIAnalysisRecommendQuestions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain basic information of the Cloud Security AI Assistant.
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAnalysisRobotInfoRequest"/></param>
        /// <returns><see cref="DescribeAIAnalysisRobotInfoResponse"/></returns>
        public Task<DescribeAIAnalysisRobotInfoResponse> DescribeAIAnalysisRobotInfo(DescribeAIAnalysisRobotInfoRequest req)
        {
            return InternalRequestAsync<DescribeAIAnalysisRobotInfoResponse>(req, "DescribeAIAnalysisRobotInfo");
        }

        /// <summary>
        /// This API is used to obtain basic information of the Cloud Security AI Assistant.
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAnalysisRobotInfoRequest"/></param>
        /// <returns><see cref="DescribeAIAnalysisRobotInfoResponse"/></returns>
        public DescribeAIAnalysisRobotInfoResponse DescribeAIAnalysisRobotInfoSync(DescribeAIAnalysisRobotInfoRequest req)
        {
            return InternalRequestAsync<DescribeAIAnalysisRobotInfoResponse>(req, "DescribeAIAnalysisRobotInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query SMTP mailbox access information of the AI assistant
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAnalysisSMTPRequest"/></param>
        /// <returns><see cref="DescribeAIAnalysisSMTPResponse"/></returns>
        public Task<DescribeAIAnalysisSMTPResponse> DescribeAIAnalysisSMTP(DescribeAIAnalysisSMTPRequest req)
        {
            return InternalRequestAsync<DescribeAIAnalysisSMTPResponse>(req, "DescribeAIAnalysisSMTP");
        }

        /// <summary>
        /// Query SMTP mailbox access information of the AI assistant
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAnalysisSMTPRequest"/></param>
        /// <returns><see cref="DescribeAIAnalysisSMTPResponse"/></returns>
        public DescribeAIAnalysisSMTPResponse DescribeAIAnalysisSMTPSync(DescribeAIAnalysisSMTPRequest req)
        {
            return InternalRequestAsync<DescribeAIAnalysisSMTPResponse>(req, "DescribeAIAnalysisSMTP")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the AI-Link engine configuration
        /// </summary>
        /// <param name="req"><see cref="DescribeAILinkSettingRequest"/></param>
        /// <returns><see cref="DescribeAILinkSettingResponse"/></returns>
        public Task<DescribeAILinkSettingResponse> DescribeAILinkSetting(DescribeAILinkSettingRequest req)
        {
            return InternalRequestAsync<DescribeAILinkSettingResponse>(req, "DescribeAILinkSetting");
        }

        /// <summary>
        /// Query the AI-Link engine configuration
        /// </summary>
        /// <param name="req"><see cref="DescribeAILinkSettingRequest"/></param>
        /// <returns><see cref="DescribeAILinkSettingResponse"/></returns>
        public DescribeAILinkSettingResponse DescribeAILinkSettingSync(DescribeAILinkSettingRequest req)
        {
            return InternalRequestAsync<DescribeAILinkSettingResponse>(req, "DescribeAILinkSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the list of AI scheduled tasks.
        /// 
        /// Supports paging query and status filtering, and returns the scheduled task list and total number of entries.
        /// </summary>
        /// <param name="req"><see cref="DescribeAIScheduleListRequest"/></param>
        /// <returns><see cref="DescribeAIScheduleListResponse"/></returns>
        public Task<DescribeAIScheduleListResponse> DescribeAIScheduleList(DescribeAIScheduleListRequest req)
        {
            return InternalRequestAsync<DescribeAIScheduleListResponse>(req, "DescribeAIScheduleList");
        }

        /// <summary>
        /// Query the list of AI scheduled tasks.
        /// 
        /// Supports paging query and status filtering, and returns the scheduled task list and total number of entries.
        /// </summary>
        /// <param name="req"><see cref="DescribeAIScheduleListRequest"/></param>
        /// <returns><see cref="DescribeAIScheduleListResponse"/></returns>
        public DescribeAIScheduleListResponse DescribeAIScheduleListSync(DescribeAIScheduleListRequest req)
        {
            return InternalRequestAsync<DescribeAIScheduleListResponse>(req, "DescribeAIScheduleList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries AI scheduled task trigger plans.
        /// 
        /// This API is used to query the future trigger plan list of a specified AI scheduled task within a given time window.
        /// </summary>
        /// <param name="req"><see cref="DescribeAISchedulePlanListRequest"/></param>
        /// <returns><see cref="DescribeAISchedulePlanListResponse"/></returns>
        public Task<DescribeAISchedulePlanListResponse> DescribeAISchedulePlanList(DescribeAISchedulePlanListRequest req)
        {
            return InternalRequestAsync<DescribeAISchedulePlanListResponse>(req, "DescribeAISchedulePlanList");
        }

        /// <summary>
        /// Queries AI scheduled task trigger plans.
        /// 
        /// This API is used to query the future trigger plan list of a specified AI scheduled task within a given time window.
        /// </summary>
        /// <param name="req"><see cref="DescribeAISchedulePlanListRequest"/></param>
        /// <returns><see cref="DescribeAISchedulePlanListResponse"/></returns>
        public DescribeAISchedulePlanListResponse DescribeAISchedulePlanListSync(DescribeAISchedulePlanListRequest req)
        {
            return InternalRequestAsync<DescribeAISchedulePlanListResponse>(req, "DescribeAISchedulePlanList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries AI scheduled task statistics information.
        /// 
        /// Returns the total number of scheduled tasks and the number of running tasks for the current user.
        /// </summary>
        /// <param name="req"><see cref="DescribeAIScheduleStatsRequest"/></param>
        /// <returns><see cref="DescribeAIScheduleStatsResponse"/></returns>
        public Task<DescribeAIScheduleStatsResponse> DescribeAIScheduleStats(DescribeAIScheduleStatsRequest req)
        {
            return InternalRequestAsync<DescribeAIScheduleStatsResponse>(req, "DescribeAIScheduleStats");
        }

        /// <summary>
        /// Queries AI scheduled task statistics information.
        /// 
        /// Returns the total number of scheduled tasks and the number of running tasks for the current user.
        /// </summary>
        /// <param name="req"><see cref="DescribeAIScheduleStatsRequest"/></param>
        /// <returns><see cref="DescribeAIScheduleStatsResponse"/></returns>
        public DescribeAIScheduleStatsResponse DescribeAIScheduleStatsSync(DescribeAIScheduleStatsRequest req)
        {
            return InternalRequestAsync<DescribeAIScheduleStatsResponse>(req, "DescribeAIScheduleStats")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the details of AI scheduled task executions.
        /// 
        /// This API is used to query the detailed information of a specified task execution by task ID, including the execution status and results.
        /// </summary>
        /// <param name="req"><see cref="DescribeAIScheduleTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeAIScheduleTaskDetailResponse"/></returns>
        public Task<DescribeAIScheduleTaskDetailResponse> DescribeAIScheduleTaskDetail(DescribeAIScheduleTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeAIScheduleTaskDetailResponse>(req, "DescribeAIScheduleTaskDetail");
        }

        /// <summary>
        /// Queries the details of AI scheduled task executions.
        /// 
        /// This API is used to query the detailed information of a specified task execution by task ID, including the execution status and results.
        /// </summary>
        /// <param name="req"><see cref="DescribeAIScheduleTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeAIScheduleTaskDetailResponse"/></returns>
        public DescribeAIScheduleTaskDetailResponse DescribeAIScheduleTaskDetailSync(DescribeAIScheduleTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeAIScheduleTaskDetailResponse>(req, "DescribeAIScheduleTaskDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the scheduled AI task execution list.
        /// 
        /// Queries the historical execution records of AI scheduled tasks. Supports pagination and filtering by scheduled task ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeAIScheduleTaskListRequest"/></param>
        /// <returns><see cref="DescribeAIScheduleTaskListResponse"/></returns>
        public Task<DescribeAIScheduleTaskListResponse> DescribeAIScheduleTaskList(DescribeAIScheduleTaskListRequest req)
        {
            return InternalRequestAsync<DescribeAIScheduleTaskListResponse>(req, "DescribeAIScheduleTaskList");
        }

        /// <summary>
        /// This API is used to query the scheduled AI task execution list.
        /// 
        /// Queries the historical execution records of AI scheduled tasks. Supports pagination and filtering by scheduled task ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeAIScheduleTaskListRequest"/></param>
        /// <returns><see cref="DescribeAIScheduleTaskListResponse"/></returns>
        public DescribeAIScheduleTaskListResponse DescribeAIScheduleTaskListSync(DescribeAIScheduleTaskListRequest req)
        {
            return InternalRequestAsync<DescribeAIScheduleTaskListResponse>(req, "DescribeAIScheduleTaskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Access key alarm record AI analysis result details
        /// </summary>
        /// <param name="req"><see cref="DescribeAKAnalysisDetailRequest"/></param>
        /// <returns><see cref="DescribeAKAnalysisDetailResponse"/></returns>
        public Task<DescribeAKAnalysisDetailResponse> DescribeAKAnalysisDetail(DescribeAKAnalysisDetailRequest req)
        {
            return InternalRequestAsync<DescribeAKAnalysisDetailResponse>(req, "DescribeAKAnalysisDetail");
        }

        /// <summary>
        /// Access key alarm record AI analysis result details
        /// </summary>
        /// <param name="req"><see cref="DescribeAKAnalysisDetailRequest"/></param>
        /// <returns><see cref="DescribeAKAnalysisDetailResponse"/></returns>
        public DescribeAKAnalysisDetailResponse DescribeAKAnalysisDetailSync(DescribeAKAnalysisDetailRequest req)
        {
            return InternalRequestAsync<DescribeAKAnalysisDetailResponse>(req, "DescribeAKAnalysisDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Determine whether the user is a grayscale user
        /// </summary>
        /// <param name="req"><see cref="DescribeAbTestUserRequest"/></param>
        /// <returns><see cref="DescribeAbTestUserResponse"/></returns>
        public Task<DescribeAbTestUserResponse> DescribeAbTestUser(DescribeAbTestUserRequest req)
        {
            return InternalRequestAsync<DescribeAbTestUserResponse>(req, "DescribeAbTestUser");
        }

        /// <summary>
        /// Determine whether the user is a grayscale user
        /// </summary>
        /// <param name="req"><see cref="DescribeAbTestUserRequest"/></param>
        /// <returns><see cref="DescribeAbTestUserResponse"/></returns>
        public DescribeAbTestUserResponse DescribeAbTestUserSync(DescribeAbTestUserRequest req)
        {
            return InternalRequestAsync<DescribeAbTestUserResponse>(req, "DescribeAbTestUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get the call record list
        /// </summary>
        /// <param name="req"><see cref="DescribeAbnormalCallRecordRequest"/></param>
        /// <returns><see cref="DescribeAbnormalCallRecordResponse"/></returns>
        public Task<DescribeAbnormalCallRecordResponse> DescribeAbnormalCallRecord(DescribeAbnormalCallRecordRequest req)
        {
            return InternalRequestAsync<DescribeAbnormalCallRecordResponse>(req, "DescribeAbnormalCallRecord");
        }

        /// <summary>
        /// Get the call record list
        /// </summary>
        /// <param name="req"><see cref="DescribeAbnormalCallRecordRequest"/></param>
        /// <returns><see cref="DescribeAbnormalCallRecordResponse"/></returns>
        public DescribeAbnormalCallRecordResponse DescribeAbnormalCallRecordSync(DescribeAbnormalCallRecordRequest req)
        {
            return InternalRequestAsync<DescribeAbnormalCallRecordResponse>(req, "DescribeAbnormalCallRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// List of access key alarm records
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessKeyAlarmRequest"/></param>
        /// <returns><see cref="DescribeAccessKeyAlarmResponse"/></returns>
        public Task<DescribeAccessKeyAlarmResponse> DescribeAccessKeyAlarm(DescribeAccessKeyAlarmRequest req)
        {
            return InternalRequestAsync<DescribeAccessKeyAlarmResponse>(req, "DescribeAccessKeyAlarm");
        }

        /// <summary>
        /// List of access key alarm records
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessKeyAlarmRequest"/></param>
        /// <returns><see cref="DescribeAccessKeyAlarmResponse"/></returns>
        public DescribeAccessKeyAlarmResponse DescribeAccessKeyAlarmSync(DescribeAccessKeyAlarmRequest req)
        {
            return InternalRequestAsync<DescribeAccessKeyAlarmResponse>(req, "DescribeAccessKeyAlarm")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Access key alarm record details
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessKeyAlarmDetailRequest"/></param>
        /// <returns><see cref="DescribeAccessKeyAlarmDetailResponse"/></returns>
        public Task<DescribeAccessKeyAlarmDetailResponse> DescribeAccessKeyAlarmDetail(DescribeAccessKeyAlarmDetailRequest req)
        {
            return InternalRequestAsync<DescribeAccessKeyAlarmDetailResponse>(req, "DescribeAccessKeyAlarmDetail");
        }

        /// <summary>
        /// Access key alarm record details
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessKeyAlarmDetailRequest"/></param>
        /// <returns><see cref="DescribeAccessKeyAlarmDetailResponse"/></returns>
        public DescribeAccessKeyAlarmDetailResponse DescribeAccessKeyAlarmDetailSync(DescribeAccessKeyAlarmDetailRequest req)
        {
            return InternalRequestAsync<DescribeAccessKeyAlarmDetailResponse>(req, "DescribeAccessKeyAlarmDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retrieve the user access key asset list
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessKeyAssetRequest"/></param>
        /// <returns><see cref="DescribeAccessKeyAssetResponse"/></returns>
        public Task<DescribeAccessKeyAssetResponse> DescribeAccessKeyAsset(DescribeAccessKeyAssetRequest req)
        {
            return InternalRequestAsync<DescribeAccessKeyAssetResponse>(req, "DescribeAccessKeyAsset");
        }

        /// <summary>
        /// Retrieve the user access key asset list
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessKeyAssetRequest"/></param>
        /// <returns><see cref="DescribeAccessKeyAssetResponse"/></returns>
        public DescribeAccessKeyAssetResponse DescribeAccessKeyAssetSync(DescribeAccessKeyAssetRequest req)
        {
            return InternalRequestAsync<DescribeAccessKeyAssetResponse>(req, "DescribeAccessKeyAsset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// List of access key risk records
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessKeyRiskRequest"/></param>
        /// <returns><see cref="DescribeAccessKeyRiskResponse"/></returns>
        public Task<DescribeAccessKeyRiskResponse> DescribeAccessKeyRisk(DescribeAccessKeyRiskRequest req)
        {
            return InternalRequestAsync<DescribeAccessKeyRiskResponse>(req, "DescribeAccessKeyRisk");
        }

        /// <summary>
        /// List of access key risk records
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessKeyRiskRequest"/></param>
        /// <returns><see cref="DescribeAccessKeyRiskResponse"/></returns>
        public DescribeAccessKeyRiskResponse DescribeAccessKeyRiskSync(DescribeAccessKeyRiskRequest req)
        {
            return InternalRequestAsync<DescribeAccessKeyRiskResponse>(req, "DescribeAccessKeyRisk")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Access key risk record details
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessKeyRiskDetailRequest"/></param>
        /// <returns><see cref="DescribeAccessKeyRiskDetailResponse"/></returns>
        public Task<DescribeAccessKeyRiskDetailResponse> DescribeAccessKeyRiskDetail(DescribeAccessKeyRiskDetailRequest req)
        {
            return InternalRequestAsync<DescribeAccessKeyRiskDetailResponse>(req, "DescribeAccessKeyRiskDetail");
        }

        /// <summary>
        /// Access key risk record details
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessKeyRiskDetailRequest"/></param>
        /// <returns><see cref="DescribeAccessKeyRiskDetailResponse"/></returns>
        public DescribeAccessKeyRiskDetailResponse DescribeAccessKeyRiskDetailSync(DescribeAccessKeyRiskDetailRequest req)
        {
            return InternalRequestAsync<DescribeAccessKeyRiskDetailResponse>(req, "DescribeAccessKeyRiskDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query account details of a user.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessKeyUserDetailRequest"/></param>
        /// <returns><see cref="DescribeAccessKeyUserDetailResponse"/></returns>
        public Task<DescribeAccessKeyUserDetailResponse> DescribeAccessKeyUserDetail(DescribeAccessKeyUserDetailRequest req)
        {
            return InternalRequestAsync<DescribeAccessKeyUserDetailResponse>(req, "DescribeAccessKeyUserDetail");
        }

        /// <summary>
        /// This API is used to query account details of a user.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessKeyUserDetailRequest"/></param>
        /// <returns><see cref="DescribeAccessKeyUserDetailResponse"/></returns>
        public DescribeAccessKeyUserDetailResponse DescribeAccessKeyUserDetailSync(DescribeAccessKeyUserDetailRequest req)
        {
            return InternalRequestAsync<DescribeAccessKeyUserDetailResponse>(req, "DescribeAccessKeyUserDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query user account list
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessKeyUserListRequest"/></param>
        /// <returns><see cref="DescribeAccessKeyUserListResponse"/></returns>
        public Task<DescribeAccessKeyUserListResponse> DescribeAccessKeyUserList(DescribeAccessKeyUserListRequest req)
        {
            return InternalRequestAsync<DescribeAccessKeyUserListResponse>(req, "DescribeAccessKeyUserList");
        }

        /// <summary>
        /// Query user account list
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessKeyUserListRequest"/></param>
        /// <returns><see cref="DescribeAccessKeyUserListResponse"/></returns>
        public DescribeAccessKeyUserListResponse DescribeAccessKeyUserListSync(DescribeAccessKeyUserListRequest req)
        {
            return InternalRequestAsync<DescribeAccessKeyUserListResponse>(req, "DescribeAccessKeyUserList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Access key alarm record list
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessKeyWhiteListRequest"/></param>
        /// <returns><see cref="DescribeAccessKeyWhiteListResponse"/></returns>
        public Task<DescribeAccessKeyWhiteListResponse> DescribeAccessKeyWhiteList(DescribeAccessKeyWhiteListRequest req)
        {
            return InternalRequestAsync<DescribeAccessKeyWhiteListResponse>(req, "DescribeAccessKeyWhiteList");
        }

        /// <summary>
        /// Access key alarm record list
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessKeyWhiteListRequest"/></param>
        /// <returns><see cref="DescribeAccessKeyWhiteListResponse"/></returns>
        public DescribeAccessKeyWhiteListResponse DescribeAccessKeyWhiteListSync(DescribeAccessKeyWhiteListRequest req)
        {
            return InternalRequestAsync<DescribeAccessKeyWhiteListResponse>(req, "DescribeAccessKeyWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query client configuration settings (configuration group). This is a standalone API split from DescribeAgentRunMode.
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentConfigSettingRequest"/></param>
        /// <returns><see cref="DescribeAgentConfigSettingResponse"/></returns>
        public Task<DescribeAgentConfigSettingResponse> DescribeAgentConfigSetting(DescribeAgentConfigSettingRequest req)
        {
            return InternalRequestAsync<DescribeAgentConfigSettingResponse>(req, "DescribeAgentConfigSetting");
        }

        /// <summary>
        /// Query client configuration settings (configuration group). This is a standalone API split from DescribeAgentRunMode.
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentConfigSettingRequest"/></param>
        /// <returns><see cref="DescribeAgentConfigSettingResponse"/></returns>
        public DescribeAgentConfigSettingResponse DescribeAgentConfigSettingSync(DescribeAgentConfigSettingRequest req)
        {
            return InternalRequestAsync<DescribeAgentConfigSettingResponse>(req, "DescribeAgentConfigSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get the client running mode and runtime configuration information
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentRunModeRequest"/></param>
        /// <returns><see cref="DescribeAgentRunModeResponse"/></returns>
        public Task<DescribeAgentRunModeResponse> DescribeAgentRunMode(DescribeAgentRunModeRequest req)
        {
            return InternalRequestAsync<DescribeAgentRunModeResponse>(req, "DescribeAgentRunMode");
        }

        /// <summary>
        /// Get the client running mode and runtime configuration information
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentRunModeRequest"/></param>
        /// <returns><see cref="DescribeAgentRunModeResponse"/></returns>
        public DescribeAgentRunModeResponse DescribeAgentRunModeSync(DescribeAgentRunModeRequest req)
        {
            return InternalRequestAsync<DescribeAgentRunModeResponse>(req, "DescribeAgentRunMode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query client running policies (policy groups). This is a standalone API split from DescribeAgentRunMode.
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentRunPolicyRequest"/></param>
        /// <returns><see cref="DescribeAgentRunPolicyResponse"/></returns>
        public Task<DescribeAgentRunPolicyResponse> DescribeAgentRunPolicy(DescribeAgentRunPolicyRequest req)
        {
            return InternalRequestAsync<DescribeAgentRunPolicyResponse>(req, "DescribeAgentRunPolicy");
        }

        /// <summary>
        /// Query client running policies (policy groups). This is a standalone API split from DescribeAgentRunMode.
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentRunPolicyRequest"/></param>
        /// <returns><see cref="DescribeAgentRunPolicyResponse"/></returns>
        public DescribeAgentRunPolicyResponse DescribeAgentRunPolicySync(DescribeAgentRunPolicyRequest req)
        {
            return InternalRequestAsync<DescribeAgentRunPolicyResponse>(req, "DescribeAgentRunPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Alarm Center full alarm list API
        /// </summary>
        /// <param name="req"><see cref="DescribeAlertListRequest"/></param>
        /// <returns><see cref="DescribeAlertListResponse"/></returns>
        public Task<DescribeAlertListResponse> DescribeAlertList(DescribeAlertListRequest req)
        {
            return InternalRequestAsync<DescribeAlertListResponse>(req, "DescribeAlertList");
        }

        /// <summary>
        /// Alarm Center full alarm list API
        /// </summary>
        /// <param name="req"><see cref="DescribeAlertListRequest"/></param>
        /// <returns><see cref="DescribeAlertListResponse"/></returns>
        public DescribeAlertListResponse DescribeAlertListSync(DescribeAlertListRequest req)
        {
            return InternalRequestAsync<DescribeAlertListResponse>(req, "DescribeAlertList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the component list in an asset.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetComponentListRequest"/></param>
        /// <returns><see cref="DescribeAssetComponentListResponse"/></returns>
        public Task<DescribeAssetComponentListResponse> DescribeAssetComponentList(DescribeAssetComponentListRequest req)
        {
            return InternalRequestAsync<DescribeAssetComponentListResponse>(req, "DescribeAssetComponentList");
        }

        /// <summary>
        /// Query the component list in an asset.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetComponentListRequest"/></param>
        /// <returns><see cref="DescribeAssetComponentListResponse"/></returns>
        public DescribeAssetComponentListResponse DescribeAssetComponentListSync(DescribeAssetComponentListRequest req)
        {
            return InternalRequestAsync<DescribeAssetComponentListResponse>(req, "DescribeAssetComponentList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the list of associated images of image repository components.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetComponentRelatedImageListRequest"/></param>
        /// <returns><see cref="DescribeAssetComponentRelatedImageListResponse"/></returns>
        public Task<DescribeAssetComponentRelatedImageListResponse> DescribeAssetComponentRelatedImageList(DescribeAssetComponentRelatedImageListRequest req)
        {
            return InternalRequestAsync<DescribeAssetComponentRelatedImageListResponse>(req, "DescribeAssetComponentRelatedImageList");
        }

        /// <summary>
        /// Queries the list of associated images of image repository components.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetComponentRelatedImageListRequest"/></param>
        /// <returns><see cref="DescribeAssetComponentRelatedImageListResponse"/></returns>
        public DescribeAssetComponentRelatedImageListResponse DescribeAssetComponentRelatedImageListSync(DescribeAssetComponentRelatedImageListRequest req)
        {
            return InternalRequestAsync<DescribeAssetComponentRelatedImageListResponse>(req, "DescribeAssetComponentRelatedImageList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Asset detail information
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetDetailRequest"/></param>
        /// <returns><see cref="DescribeAssetDetailResponse"/></returns>
        public Task<DescribeAssetDetailResponse> DescribeAssetDetail(DescribeAssetDetailRequest req)
        {
            return InternalRequestAsync<DescribeAssetDetailResponse>(req, "DescribeAssetDetail");
        }

        /// <summary>
        /// Asset detail information
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetDetailRequest"/></param>
        /// <returns><see cref="DescribeAssetDetailResponse"/></returns>
        public DescribeAssetDetailResponse DescribeAssetDetailSync(DescribeAssetDetailRequest req)
        {
            return InternalRequestAsync<DescribeAssetDetailResponse>(req, "DescribeAssetDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Asset search view
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetFilterViewsRequest"/></param>
        /// <returns><see cref="DescribeAssetFilterViewsResponse"/></returns>
        public Task<DescribeAssetFilterViewsResponse> DescribeAssetFilterViews(DescribeAssetFilterViewsRequest req)
        {
            return InternalRequestAsync<DescribeAssetFilterViewsResponse>(req, "DescribeAssetFilterViews");
        }

        /// <summary>
        /// Asset search view
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetFilterViewsRequest"/></param>
        /// <returns><see cref="DescribeAssetFilterViewsResponse"/></returns>
        public DescribeAssetFilterViewsResponse DescribeAssetFilterViewsSync(DescribeAssetFilterViewsRequest req)
        {
            return InternalRequestAsync<DescribeAssetFilterViewsResponse>(req, "DescribeAssetFilterViews")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Asset information
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetInfoRequest"/></param>
        /// <returns><see cref="DescribeAssetInfoResponse"/></returns>
        public Task<DescribeAssetInfoResponse> DescribeAssetInfo(DescribeAssetInfoRequest req)
        {
            return InternalRequestAsync<DescribeAssetInfoResponse>(req, "DescribeAssetInfo");
        }

        /// <summary>
        /// Asset information
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetInfoRequest"/></param>
        /// <returns><see cref="DescribeAssetInfoResponse"/></returns>
        public DescribeAssetInfoResponse DescribeAssetInfoSync(DescribeAssetInfoRequest req)
        {
            return InternalRequestAsync<DescribeAssetInfoResponse>(req, "DescribeAssetInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Last Synchronization Time of Assets
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetLastSyncTimeRequest"/></param>
        /// <returns><see cref="DescribeAssetLastSyncTimeResponse"/></returns>
        public Task<DescribeAssetLastSyncTimeResponse> DescribeAssetLastSyncTime(DescribeAssetLastSyncTimeRequest req)
        {
            return InternalRequestAsync<DescribeAssetLastSyncTimeResponse>(req, "DescribeAssetLastSyncTime");
        }

        /// <summary>
        /// Last Synchronization Time of Assets
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetLastSyncTimeRequest"/></param>
        /// <returns><see cref="DescribeAssetLastSyncTimeResponse"/></returns>
        public DescribeAssetLastSyncTimeResponse DescribeAssetLastSyncTimeSync(DescribeAssetLastSyncTimeRequest req)
        {
            return InternalRequestAsync<DescribeAssetLastSyncTimeResponse>(req, "DescribeAssetLastSyncTime")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Asset Overview statistics
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetOverviewRequest"/></param>
        /// <returns><see cref="DescribeAssetOverviewResponse"/></returns>
        public Task<DescribeAssetOverviewResponse> DescribeAssetOverview(DescribeAssetOverviewRequest req)
        {
            return InternalRequestAsync<DescribeAssetOverviewResponse>(req, "DescribeAssetOverview");
        }

        /// <summary>
        /// Asset Overview statistics
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetOverviewRequest"/></param>
        /// <returns><see cref="DescribeAssetOverviewResponse"/></returns>
        public DescribeAssetOverviewResponse DescribeAssetOverviewSync(DescribeAssetOverviewRequest req)
        {
            return InternalRequestAsync<DescribeAssetOverviewResponse>(req, "DescribeAssetOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the process list of host nodes on exposed paths in cloud boundary analysis.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetProcessListRequest"/></param>
        /// <returns><see cref="DescribeAssetProcessListResponse"/></returns>
        public Task<DescribeAssetProcessListResponse> DescribeAssetProcessList(DescribeAssetProcessListRequest req)
        {
            return InternalRequestAsync<DescribeAssetProcessListResponse>(req, "DescribeAssetProcessList");
        }

        /// <summary>
        /// This API is used to query the process list of host nodes on exposed paths in cloud boundary analysis.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetProcessListRequest"/></param>
        /// <returns><see cref="DescribeAssetProcessListResponse"/></returns>
        public DescribeAssetProcessListResponse DescribeAssetProcessListSync(DescribeAssetProcessListRequest req)
        {
            return InternalRequestAsync<DescribeAssetProcessListResponse>(req, "DescribeAssetProcessList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Asset risk details
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetRiskDetailRequest"/></param>
        /// <returns><see cref="DescribeAssetRiskDetailResponse"/></returns>
        public Task<DescribeAssetRiskDetailResponse> DescribeAssetRiskDetail(DescribeAssetRiskDetailRequest req)
        {
            return InternalRequestAsync<DescribeAssetRiskDetailResponse>(req, "DescribeAssetRiskDetail");
        }

        /// <summary>
        /// Asset risk details
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetRiskDetailRequest"/></param>
        /// <returns><see cref="DescribeAssetRiskDetailResponse"/></returns>
        public DescribeAssetRiskDetailResponse DescribeAssetRiskDetailSync(DescribeAssetRiskDetailRequest req)
        {
            return InternalRequestAsync<DescribeAssetRiskDetailResponse>(req, "DescribeAssetRiskDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Cloud resource configuration risk list from the asset perspective
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetRiskListRequest"/></param>
        /// <returns><see cref="DescribeAssetRiskListResponse"/></returns>
        public Task<DescribeAssetRiskListResponse> DescribeAssetRiskList(DescribeAssetRiskListRequest req)
        {
            return InternalRequestAsync<DescribeAssetRiskListResponse>(req, "DescribeAssetRiskList");
        }

        /// <summary>
        /// Cloud resource configuration risk list from the asset perspective
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetRiskListRequest"/></param>
        /// <returns><see cref="DescribeAssetRiskListResponse"/></returns>
        public DescribeAssetRiskListResponse DescribeAssetRiskListSync(DescribeAssetRiskListRequest req)
        {
            return InternalRequestAsync<DescribeAssetRiskListResponse>(req, "DescribeAssetRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Asset sync task status
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetSyncTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeAssetSyncTaskStatusResponse"/></returns>
        public Task<DescribeAssetSyncTaskStatusResponse> DescribeAssetSyncTaskStatus(DescribeAssetSyncTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeAssetSyncTaskStatusResponse>(req, "DescribeAssetSyncTaskStatus");
        }

        /// <summary>
        /// Asset sync task status
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetSyncTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeAssetSyncTaskStatusResponse"/></returns>
        public DescribeAssetSyncTaskStatusResponse DescribeAssetSyncTaskStatusSync(DescribeAssetSyncTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeAssetSyncTaskStatusResponse>(req, "DescribeAssetSyncTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retrieves asset tag attributes
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetTagAttributesRequest"/></param>
        /// <returns><see cref="DescribeAssetTagAttributesResponse"/></returns>
        public Task<DescribeAssetTagAttributesResponse> DescribeAssetTagAttributes(DescribeAssetTagAttributesRequest req)
        {
            return InternalRequestAsync<DescribeAssetTagAttributesResponse>(req, "DescribeAssetTagAttributes");
        }

        /// <summary>
        /// Retrieves asset tag attributes
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetTagAttributesRequest"/></param>
        /// <returns><see cref="DescribeAssetTagAttributesResponse"/></returns>
        public DescribeAssetTagAttributesResponse DescribeAssetTagAttributesSync(DescribeAssetTagAttributesRequest req)
        {
            return InternalRequestAsync<DescribeAssetTagAttributesResponse>(req, "DescribeAssetTagAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Asset tag tree structured data
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetTagTreeRequest"/></param>
        /// <returns><see cref="DescribeAssetTagTreeResponse"/></returns>
        public Task<DescribeAssetTagTreeResponse> DescribeAssetTagTree(DescribeAssetTagTreeRequest req)
        {
            return InternalRequestAsync<DescribeAssetTagTreeResponse>(req, "DescribeAssetTagTree");
        }

        /// <summary>
        /// Asset tag tree structured data
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetTagTreeRequest"/></param>
        /// <returns><see cref="DescribeAssetTagTreeResponse"/></returns>
        public DescribeAssetTagTreeResponse DescribeAssetTagTreeSync(DescribeAssetTagTreeRequest req)
        {
            return InternalRequestAsync<DescribeAssetTagTreeResponse>(req, "DescribeAssetTagTree")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// All assets
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetTagsRequest"/></param>
        /// <returns><see cref="DescribeAssetTagsResponse"/></returns>
        public Task<DescribeAssetTagsResponse> DescribeAssetTags(DescribeAssetTagsRequest req)
        {
            return InternalRequestAsync<DescribeAssetTagsResponse>(req, "DescribeAssetTags");
        }

        /// <summary>
        /// All assets
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetTagsRequest"/></param>
        /// <returns><see cref="DescribeAssetTagsResponse"/></returns>
        public DescribeAssetTagsResponse DescribeAssetTagsSync(DescribeAssetTagsRequest req)
        {
            return InternalRequestAsync<DescribeAssetTagsResponse>(req, "DescribeAssetTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Asset tree structure
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetTreeRequest"/></param>
        /// <returns><see cref="DescribeAssetTreeResponse"/></returns>
        public Task<DescribeAssetTreeResponse> DescribeAssetTree(DescribeAssetTreeRequest req)
        {
            return InternalRequestAsync<DescribeAssetTreeResponse>(req, "DescribeAssetTree");
        }

        /// <summary>
        /// Asset tree structure
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetTreeRequest"/></param>
        /// <returns><see cref="DescribeAssetTreeResponse"/></returns>
        public DescribeAssetTreeResponse DescribeAssetTreeSync(DescribeAssetTreeRequest req)
        {
            return InternalRequestAsync<DescribeAssetTreeResponse>(req, "DescribeAssetTree")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain Vulnerability Risk List from Asset's Perspective
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetViewVulRiskListRequest"/></param>
        /// <returns><see cref="DescribeAssetViewVulRiskListResponse"/></returns>
        public Task<DescribeAssetViewVulRiskListResponse> DescribeAssetViewVulRiskList(DescribeAssetViewVulRiskListRequest req)
        {
            return InternalRequestAsync<DescribeAssetViewVulRiskListResponse>(req, "DescribeAssetViewVulRiskList");
        }

        /// <summary>
        /// Obtain Vulnerability Risk List from Asset's Perspective
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetViewVulRiskListRequest"/></param>
        /// <returns><see cref="DescribeAssetViewVulRiskListResponse"/></returns>
        public DescribeAssetViewVulRiskListResponse DescribeAssetViewVulRiskListSync(DescribeAssetViewVulRiskListRequest req)
        {
            return InternalRequestAsync<DescribeAssetViewVulRiskListResponse>(req, "DescribeAssetViewVulRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the region list of the backend scanning engine.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackendScanEngineRegionListRequest"/></param>
        /// <returns><see cref="DescribeBackendScanEngineRegionListResponse"/></returns>
        public Task<DescribeBackendScanEngineRegionListResponse> DescribeBackendScanEngineRegionList(DescribeBackendScanEngineRegionListRequest req)
        {
            return InternalRequestAsync<DescribeBackendScanEngineRegionListResponse>(req, "DescribeBackendScanEngineRegionList");
        }

        /// <summary>
        /// This API is used to query the region list of the backend scanning engine.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackendScanEngineRegionListRequest"/></param>
        /// <returns><see cref="DescribeBackendScanEngineRegionListResponse"/></returns>
        public DescribeBackendScanEngineRegionListResponse DescribeBackendScanEngineRegionListSync(DescribeBackendScanEngineRegionListRequest req)
        {
            return InternalRequestAsync<DescribeBackendScanEngineRegionListResponse>(req, "DescribeBackendScanEngineRegionList")
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
        /// This API is used to obtain the aggregated scan result list by detection item, for showing the number of passed and failed assets by detection item on the "Detection Item" Tab of the policy details page.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineAggregatedItemListRequest"/></param>
        /// <returns><see cref="DescribeBaselineAggregatedItemListResponse"/></returns>
        public Task<DescribeBaselineAggregatedItemListResponse> DescribeBaselineAggregatedItemList(DescribeBaselineAggregatedItemListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineAggregatedItemListResponse>(req, "DescribeBaselineAggregatedItemList");
        }

        /// <summary>
        /// This API is used to obtain the aggregated scan result list by detection item, for showing the number of passed and failed assets by detection item on the "Detection Item" Tab of the policy details page.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineAggregatedItemListRequest"/></param>
        /// <returns><see cref="DescribeBaselineAggregatedItemListResponse"/></returns>
        public DescribeBaselineAggregatedItemListResponse DescribeBaselineAggregatedItemListSync(DescribeBaselineAggregatedItemListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineAggregatedItemListResponse>(req, "DescribeBaselineAggregatedItemList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the aggregation scan result list by baseline policy dimension, for the "Baseline Scan Policy" module on the overview page to display pass/fail status by policy.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineAggregatedPolicyListRequest"/></param>
        /// <returns><see cref="DescribeBaselineAggregatedPolicyListResponse"/></returns>
        public Task<DescribeBaselineAggregatedPolicyListResponse> DescribeBaselineAggregatedPolicyList(DescribeBaselineAggregatedPolicyListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineAggregatedPolicyListResponse>(req, "DescribeBaselineAggregatedPolicyList");
        }

        /// <summary>
        /// This API is used to get the aggregation scan result list by baseline policy dimension, for the "Baseline Scan Policy" module on the overview page to display pass/fail status by policy.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineAggregatedPolicyListRequest"/></param>
        /// <returns><see cref="DescribeBaselineAggregatedPolicyListResponse"/></returns>
        public DescribeBaselineAggregatedPolicyListResponse DescribeBaselineAggregatedPolicyListSync(DescribeBaselineAggregatedPolicyListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineAggregatedPolicyListResponse>(req, "DescribeBaselineAggregatedPolicyList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the list of Policy IDs currently at the "statistical calculation" status, used for frontend polling to judge whether the scan results statistics are ready.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineCalculatingStatisticsPolicyIDListRequest"/></param>
        /// <returns><see cref="DescribeBaselineCalculatingStatisticsPolicyIDListResponse"/></returns>
        public Task<DescribeBaselineCalculatingStatisticsPolicyIDListResponse> DescribeBaselineCalculatingStatisticsPolicyIDList(DescribeBaselineCalculatingStatisticsPolicyIDListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineCalculatingStatisticsPolicyIDListResponse>(req, "DescribeBaselineCalculatingStatisticsPolicyIDList");
        }

        /// <summary>
        /// Queries the list of Policy IDs currently at the "statistical calculation" status, used for frontend polling to judge whether the scan results statistics are ready.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineCalculatingStatisticsPolicyIDListRequest"/></param>
        /// <returns><see cref="DescribeBaselineCalculatingStatisticsPolicyIDListResponse"/></returns>
        public DescribeBaselineCalculatingStatisticsPolicyIDListResponse DescribeBaselineCalculatingStatisticsPolicyIDListSync(DescribeBaselineCalculatingStatisticsPolicyIDListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineCalculatingStatisticsPolicyIDListResponse>(req, "DescribeBaselineCalculatingStatisticsPolicyIDList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the detection item list of a category.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineCategoryItemListRequest"/></param>
        /// <returns><see cref="DescribeBaselineCategoryItemListResponse"/></returns>
        public Task<DescribeBaselineCategoryItemListResponse> DescribeBaselineCategoryItemList(DescribeBaselineCategoryItemListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineCategoryItemListResponse>(req, "DescribeBaselineCategoryItemList");
        }

        /// <summary>
        /// This API is used to query the detection item list of a category.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineCategoryItemListRequest"/></param>
        /// <returns><see cref="DescribeBaselineCategoryItemListResponse"/></returns>
        public DescribeBaselineCategoryItemListResponse DescribeBaselineCategoryItemListSync(DescribeBaselineCategoryItemListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineCategoryItemListResponse>(req, "DescribeBaselineCategoryItemList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get the historical record list of baseline risk corrections, used to show fixed detection items and corresponding assets on the "Correction Record" page.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineFixRecordListRequest"/></param>
        /// <returns><see cref="DescribeBaselineFixRecordListResponse"/></returns>
        public Task<DescribeBaselineFixRecordListResponse> DescribeBaselineFixRecordList(DescribeBaselineFixRecordListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineFixRecordListResponse>(req, "DescribeBaselineFixRecordList");
        }

        /// <summary>
        /// Get the historical record list of baseline risk corrections, used to show fixed detection items and corresponding assets on the "Correction Record" page.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineFixRecordListRequest"/></param>
        /// <returns><see cref="DescribeBaselineFixRecordListResponse"/></returns>
        public DescribeBaselineFixRecordListResponse DescribeBaselineFixRecordListSync(DescribeBaselineFixRecordListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineFixRecordListResponse>(req, "DescribeBaselineFixRecordList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to retrieve the risk record list of detection item dimensions.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineItemRiskListRequest"/></param>
        /// <returns><see cref="DescribeBaselineItemRiskListResponse"/></returns>
        public Task<DescribeBaselineItemRiskListResponse> DescribeBaselineItemRiskList(DescribeBaselineItemRiskListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineItemRiskListResponse>(req, "DescribeBaselineItemRiskList");
        }

        /// <summary>
        /// This API is used to retrieve the risk record list of detection item dimensions.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineItemRiskListRequest"/></param>
        /// <returns><see cref="DescribeBaselineItemRiskListResponse"/></returns>
        public DescribeBaselineItemRiskListResponse DescribeBaselineItemRiskListSync(DescribeBaselineItemRiskListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineItemRiskListResponse>(req, "DescribeBaselineItemRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get the detection item list of built-in baseline classifications (parent category -> subcategory -> built-in detection item ID list) for selecting baseline detection items on the policy editing page.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineMainTaskItemListRequest"/></param>
        /// <returns><see cref="DescribeBaselineMainTaskItemListResponse"/></returns>
        public Task<DescribeBaselineMainTaskItemListResponse> DescribeBaselineMainTaskItemList(DescribeBaselineMainTaskItemListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineMainTaskItemListResponse>(req, "DescribeBaselineMainTaskItemList");
        }

        /// <summary>
        /// Get the detection item list of built-in baseline classifications (parent category -> subcategory -> built-in detection item ID list) for selecting baseline detection items on the policy editing page.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineMainTaskItemListRequest"/></param>
        /// <returns><see cref="DescribeBaselineMainTaskItemListResponse"/></returns>
        public DescribeBaselineMainTaskItemListResponse DescribeBaselineMainTaskItemListSync(DescribeBaselineMainTaskItemListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineMainTaskItemListResponse>(req, "DescribeBaselineMainTaskItemList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get the scan main task list for the Task Record page to show the history and results of one-click scan, period scanning, and disperse scan.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineMainTaskListRequest"/></param>
        /// <returns><see cref="DescribeBaselineMainTaskListResponse"/></returns>
        public Task<DescribeBaselineMainTaskListResponse> DescribeBaselineMainTaskList(DescribeBaselineMainTaskListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineMainTaskListResponse>(req, "DescribeBaselineMainTaskList");
        }

        /// <summary>
        /// Get the scan main task list for the Task Record page to show the history and results of one-click scan, period scanning, and disperse scan.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineMainTaskListRequest"/></param>
        /// <returns><see cref="DescribeBaselineMainTaskListResponse"/></returns>
        public DescribeBaselineMainTaskListResponse DescribeBaselineMainTaskListSync(DescribeBaselineMainTaskListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineMainTaskListResponse>(req, "DescribeBaselineMainTaskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retrieve header data of the baseline overview page, including the total count of failed detection items, the number of fixes in the past one year, the last scan time, and whether period scanning is currently enabled.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineOverviewRequest"/></param>
        /// <returns><see cref="DescribeBaselineOverviewResponse"/></returns>
        public Task<DescribeBaselineOverviewResponse> DescribeBaselineOverview(DescribeBaselineOverviewRequest req)
        {
            return InternalRequestAsync<DescribeBaselineOverviewResponse>(req, "DescribeBaselineOverview");
        }

        /// <summary>
        /// Retrieve header data of the baseline overview page, including the total count of failed detection items, the number of fixes in the past one year, the last scan time, and whether period scanning is currently enabled.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineOverviewRequest"/></param>
        /// <returns><see cref="DescribeBaselineOverviewResponse"/></returns>
        public DescribeBaselineOverviewResponse DescribeBaselineOverviewSync(DescribeBaselineOverviewRequest req)
        {
            return InternalRequestAsync<DescribeBaselineOverviewResponse>(req, "DescribeBaselineOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to retrieve the built-in baseline classification tree (parent category → subcategory → built-in detection item ID list) for policy details display.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselinePolicyCategoryListRequest"/></param>
        /// <returns><see cref="DescribeBaselinePolicyCategoryListResponse"/></returns>
        public Task<DescribeBaselinePolicyCategoryListResponse> DescribeBaselinePolicyCategoryList(DescribeBaselinePolicyCategoryListRequest req)
        {
            return InternalRequestAsync<DescribeBaselinePolicyCategoryListResponse>(req, "DescribeBaselinePolicyCategoryList");
        }

        /// <summary>
        /// This API is used to retrieve the built-in baseline classification tree (parent category → subcategory → built-in detection item ID list) for policy details display.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselinePolicyCategoryListRequest"/></param>
        /// <returns><see cref="DescribeBaselinePolicyCategoryListResponse"/></returns>
        public DescribeBaselinePolicyCategoryListResponse DescribeBaselinePolicyCategoryListSync(DescribeBaselinePolicyCategoryListRequest req)
        {
            return InternalRequestAsync<DescribeBaselinePolicyCategoryListResponse>(req, "DescribeBaselinePolicyCategoryList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get the Detection Item List configured in a policy.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselinePolicyItemListRequest"/></param>
        /// <returns><see cref="DescribeBaselinePolicyItemListResponse"/></returns>
        public Task<DescribeBaselinePolicyItemListResponse> DescribeBaselinePolicyItemList(DescribeBaselinePolicyItemListRequest req)
        {
            return InternalRequestAsync<DescribeBaselinePolicyItemListResponse>(req, "DescribeBaselinePolicyItemList");
        }

        /// <summary>
        /// Get the Detection Item List configured in a policy.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselinePolicyItemListRequest"/></param>
        /// <returns><see cref="DescribeBaselinePolicyItemListResponse"/></returns>
        public DescribeBaselinePolicyItemListResponse DescribeBaselinePolicyItemListSync(DescribeBaselinePolicyItemListRequest req)
        {
            return InternalRequestAsync<DescribeBaselinePolicyItemListResponse>(req, "DescribeBaselinePolicyItemList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of baseline policies for list page display of system and custom policies and their configuration status in scenarios such as cycle plan management.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselinePolicyListRequest"/></param>
        /// <returns><see cref="DescribeBaselinePolicyListResponse"/></returns>
        public Task<DescribeBaselinePolicyListResponse> DescribeBaselinePolicyList(DescribeBaselinePolicyListRequest req)
        {
            return InternalRequestAsync<DescribeBaselinePolicyListResponse>(req, "DescribeBaselinePolicyList");
        }

        /// <summary>
        /// This API is used to obtain the list of baseline policies for list page display of system and custom policies and their configuration status in scenarios such as cycle plan management.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselinePolicyListRequest"/></param>
        /// <returns><see cref="DescribeBaselinePolicyListResponse"/></returns>
        public DescribeBaselinePolicyListResponse DescribeBaselinePolicyListSync(DescribeBaselinePolicyListRequest req)
        {
            return InternalRequestAsync<DescribeBaselinePolicyListResponse>(req, "DescribeBaselinePolicyList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of existing users for a baseline policy name.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselinePolicyNameExistAppidListRequest"/></param>
        /// <returns><see cref="DescribeBaselinePolicyNameExistAppidListResponse"/></returns>
        public Task<DescribeBaselinePolicyNameExistAppidListResponse> DescribeBaselinePolicyNameExistAppidList(DescribeBaselinePolicyNameExistAppidListRequest req)
        {
            return InternalRequestAsync<DescribeBaselinePolicyNameExistAppidListResponse>(req, "DescribeBaselinePolicyNameExistAppidList");
        }

        /// <summary>
        /// This API is used to obtain the list of existing users for a baseline policy name.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselinePolicyNameExistAppidListRequest"/></param>
        /// <returns><see cref="DescribeBaselinePolicyNameExistAppidListResponse"/></returns>
        public DescribeBaselinePolicyNameExistAppidListResponse DescribeBaselinePolicyNameExistAppidListSync(DescribeBaselinePolicyNameExistAppidListRequest req)
        {
            return InternalRequestAsync<DescribeBaselinePolicyNameExistAppidListResponse>(req, "DescribeBaselinePolicyNameExistAppidList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get the scan subtask list to show the scan status and failure reason of each host or cluster in the "Asset dimension" section of the task details page.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineSubTaskListRequest"/></param>
        /// <returns><see cref="DescribeBaselineSubTaskListResponse"/></returns>
        public Task<DescribeBaselineSubTaskListResponse> DescribeBaselineSubTaskList(DescribeBaselineSubTaskListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineSubTaskListResponse>(req, "DescribeBaselineSubTaskList");
        }

        /// <summary>
        /// Get the scan subtask list to show the scan status and failure reason of each host or cluster in the "Asset dimension" section of the task details page.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineSubTaskListRequest"/></param>
        /// <returns><see cref="DescribeBaselineSubTaskListResponse"/></returns>
        public DescribeBaselineSubTaskListResponse DescribeBaselineSubTaskListSync(DescribeBaselineSubTaskListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineSubTaskListResponse>(req, "DescribeBaselineSubTaskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the baseline synchronization configuration of the current admin account. Only the Group Administrator can call this API. For ordinary member accounts, please use DescribeBaselineUserOtherConf.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineSyncConfRequest"/></param>
        /// <returns><see cref="DescribeBaselineSyncConfResponse"/></returns>
        public Task<DescribeBaselineSyncConfResponse> DescribeBaselineSyncConf(DescribeBaselineSyncConfRequest req)
        {
            return InternalRequestAsync<DescribeBaselineSyncConfResponse>(req, "DescribeBaselineSyncConf");
        }

        /// <summary>
        /// This API is used to get the baseline synchronization configuration of the current admin account. Only the Group Administrator can call this API. For ordinary member accounts, please use DescribeBaselineUserOtherConf.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineSyncConfRequest"/></param>
        /// <returns><see cref="DescribeBaselineSyncConfResponse"/></returns>
        public DescribeBaselineSyncConfResponse DescribeBaselineSyncConfSync(DescribeBaselineSyncConfRequest req)
        {
            return InternalRequestAsync<DescribeBaselineSyncConfResponse>(req, "DescribeBaselineSyncConf")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain the system built-in baseline classification tree (parent category → subcategory → built-in detection item ID list), used for selecting baseline detection items on the policy editing page.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineSystemCategoryListRequest"/></param>
        /// <returns><see cref="DescribeBaselineSystemCategoryListResponse"/></returns>
        public Task<DescribeBaselineSystemCategoryListResponse> DescribeBaselineSystemCategoryList(DescribeBaselineSystemCategoryListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineSystemCategoryListResponse>(req, "DescribeBaselineSystemCategoryList");
        }

        /// <summary>
        /// Obtain the system built-in baseline classification tree (parent category → subcategory → built-in detection item ID list), used for selecting baseline detection items on the policy editing page.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineSystemCategoryListRequest"/></param>
        /// <returns><see cref="DescribeBaselineSystemCategoryListResponse"/></returns>
        public DescribeBaselineSystemCategoryListResponse DescribeBaselineSystemCategoryListSync(DescribeBaselineSystemCategoryListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineSystemCategoryListResponse>(req, "DescribeBaselineSystemCategoryList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retrieve user-level baseline configuration for the current account.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineUserOtherConfRequest"/></param>
        /// <returns><see cref="DescribeBaselineUserOtherConfResponse"/></returns>
        public Task<DescribeBaselineUserOtherConfResponse> DescribeBaselineUserOtherConf(DescribeBaselineUserOtherConfRequest req)
        {
            return InternalRequestAsync<DescribeBaselineUserOtherConfResponse>(req, "DescribeBaselineUserOtherConf");
        }

        /// <summary>
        /// Retrieve user-level baseline configuration for the current account.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineUserOtherConfRequest"/></param>
        /// <returns><see cref="DescribeBaselineUserOtherConfResponse"/></returns>
        public DescribeBaselineUserOtherConfResponse DescribeBaselineUserOtherConfSync(DescribeBaselineUserOtherConfRequest req)
        {
            return InternalRequestAsync<DescribeBaselineUserOtherConfResponse>(req, "DescribeBaselineUserOtherConf")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to search for the custom dictionary of weak passwords for users under the current account.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineUserWeakPasswordConfRequest"/></param>
        /// <returns><see cref="DescribeBaselineUserWeakPasswordConfResponse"/></returns>
        public Task<DescribeBaselineUserWeakPasswordConfResponse> DescribeBaselineUserWeakPasswordConf(DescribeBaselineUserWeakPasswordConfRequest req)
        {
            return InternalRequestAsync<DescribeBaselineUserWeakPasswordConfResponse>(req, "DescribeBaselineUserWeakPasswordConf");
        }

        /// <summary>
        /// This API is used to search for the custom dictionary of weak passwords for users under the current account.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineUserWeakPasswordConfRequest"/></param>
        /// <returns><see cref="DescribeBaselineUserWeakPasswordConfResponse"/></returns>
        public DescribeBaselineUserWeakPasswordConfResponse DescribeBaselineUserWeakPasswordConfSync(DescribeBaselineUserWeakPasswordConfRequest req)
        {
            return InternalRequestAsync<DescribeBaselineUserWeakPasswordConfResponse>(req, "DescribeBaselineUserWeakPasswordConf")
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
        /// Risk statistics for cloud resource configuration check reports
        /// </summary>
        /// <param name="req"><see cref="DescribeCFGRiskReportStatisticsRequest"/></param>
        /// <returns><see cref="DescribeCFGRiskReportStatisticsResponse"/></returns>
        public Task<DescribeCFGRiskReportStatisticsResponse> DescribeCFGRiskReportStatistics(DescribeCFGRiskReportStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeCFGRiskReportStatisticsResponse>(req, "DescribeCFGRiskReportStatistics");
        }

        /// <summary>
        /// Risk statistics for cloud resource configuration check reports
        /// </summary>
        /// <param name="req"><see cref="DescribeCFGRiskReportStatisticsRequest"/></param>
        /// <returns><see cref="DescribeCFGRiskReportStatisticsResponse"/></returns>
        public DescribeCFGRiskReportStatisticsResponse DescribeCFGRiskReportStatisticsSync(DescribeCFGRiskReportStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeCFGRiskReportStatisticsResponse>(req, "DescribeCFGRiskReportStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the statistical information of scanning results.
        /// </summary>
        /// <param name="req"><see cref="DescribeCFGRiskStatisticsRequest"/></param>
        /// <returns><see cref="DescribeCFGRiskStatisticsResponse"/></returns>
        public Task<DescribeCFGRiskStatisticsResponse> DescribeCFGRiskStatistics(DescribeCFGRiskStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeCFGRiskStatisticsResponse>(req, "DescribeCFGRiskStatistics");
        }

        /// <summary>
        /// Query the statistical information of scanning results.
        /// </summary>
        /// <param name="req"><see cref="DescribeCFGRiskStatisticsRequest"/></param>
        /// <returns><see cref="DescribeCFGRiskStatisticsResponse"/></returns>
        public DescribeCFGRiskStatisticsResponse DescribeCFGRiskStatisticsSync(DescribeCFGRiskStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeCFGRiskStatisticsResponse>(req, "DescribeCFGRiskStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Cloud Defense Asset Center Statistics
        /// </summary>
        /// <param name="req"><see cref="DescribeCFWAssetStatisticsRequest"/></param>
        /// <returns><see cref="DescribeCFWAssetStatisticsResponse"/></returns>
        public Task<DescribeCFWAssetStatisticsResponse> DescribeCFWAssetStatistics(DescribeCFWAssetStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeCFWAssetStatisticsResponse>(req, "DescribeCFWAssetStatistics");
        }

        /// <summary>
        /// Cloud Defense Asset Center Statistics
        /// </summary>
        /// <param name="req"><see cref="DescribeCFWAssetStatisticsRequest"/></param>
        /// <returns><see cref="DescribeCFWAssetStatisticsResponse"/></returns>
        public DescribeCFWAssetStatisticsResponse DescribeCFWAssetStatisticsSync(DescribeCFWAssetStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeCFWAssetStatisticsResponse>(req, "DescribeCFWAssetStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get log index information
        /// </summary>
        /// <param name="req"><see cref="DescribeCLSLogIndexV3Request"/></param>
        /// <returns><see cref="DescribeCLSLogIndexV3Response"/></returns>
        public Task<DescribeCLSLogIndexV3Response> DescribeCLSLogIndexV3(DescribeCLSLogIndexV3Request req)
        {
            return InternalRequestAsync<DescribeCLSLogIndexV3Response>(req, "DescribeCLSLogIndexV3");
        }

        /// <summary>
        /// Get log index information
        /// </summary>
        /// <param name="req"><see cref="DescribeCLSLogIndexV3Request"/></param>
        /// <returns><see cref="DescribeCLSLogIndexV3Response"/></returns>
        public DescribeCLSLogIndexV3Response DescribeCLSLogIndexV3Sync(DescribeCLSLogIndexV3Request req)
        {
            return InternalRequestAsync<DescribeCLSLogIndexV3Response>(req, "DescribeCLSLogIndexV3")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Log analytics retrieval interface v3
        /// </summary>
        /// <param name="req"><see cref="DescribeCLSLogListV3Request"/></param>
        /// <returns><see cref="DescribeCLSLogListV3Response"/></returns>
        public Task<DescribeCLSLogListV3Response> DescribeCLSLogListV3(DescribeCLSLogListV3Request req)
        {
            return InternalRequestAsync<DescribeCLSLogListV3Response>(req, "DescribeCLSLogListV3");
        }

        /// <summary>
        /// Log analytics retrieval interface v3
        /// </summary>
        /// <param name="req"><see cref="DescribeCLSLogListV3Request"/></param>
        /// <returns><see cref="DescribeCLSLogListV3Response"/></returns>
        public DescribeCLSLogListV3Response DescribeCLSLogListV3Sync(DescribeCLSLogListV3Request req)
        {
            return InternalRequestAsync<DescribeCLSLogListV3Response>(req, "DescribeCLSLogListV3")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the consolidated billing information of the current account, including order status, payment mode, quotas, and other detailed information.
        /// </summary>
        /// <param name="req"><see cref="DescribeCSCPayInfoRequest"/></param>
        /// <returns><see cref="DescribeCSCPayInfoResponse"/></returns>
        public Task<DescribeCSCPayInfoResponse> DescribeCSCPayInfo(DescribeCSCPayInfoRequest req)
        {
            return InternalRequestAsync<DescribeCSCPayInfoResponse>(req, "DescribeCSCPayInfo");
        }

        /// <summary>
        /// Query the consolidated billing information of the current account, including order status, payment mode, quotas, and other detailed information.
        /// </summary>
        /// <param name="req"><see cref="DescribeCSCPayInfoRequest"/></param>
        /// <returns><see cref="DescribeCSCPayInfoResponse"/></returns>
        public DescribeCSCPayInfoResponse DescribeCSCPayInfoSync(DescribeCSCPayInfoRequest req)
        {
            return InternalRequestAsync<DescribeCSCPayInfoResponse>(req, "DescribeCSCPayInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the progress of the async binding task returned by ModifyCSIPLicenseBinds.
        /// </summary>
        /// <param name="req"><see cref="DescribeCSIPLicenseBindScheduleRequest"/></param>
        /// <returns><see cref="DescribeCSIPLicenseBindScheduleResponse"/></returns>
        public Task<DescribeCSIPLicenseBindScheduleResponse> DescribeCSIPLicenseBindSchedule(DescribeCSIPLicenseBindScheduleRequest req)
        {
            return InternalRequestAsync<DescribeCSIPLicenseBindScheduleResponse>(req, "DescribeCSIPLicenseBindSchedule");
        }

        /// <summary>
        /// Query the progress of the async binding task returned by ModifyCSIPLicenseBinds.
        /// </summary>
        /// <param name="req"><see cref="DescribeCSIPLicenseBindScheduleRequest"/></param>
        /// <returns><see cref="DescribeCSIPLicenseBindScheduleResponse"/></returns>
        public DescribeCSIPLicenseBindScheduleResponse DescribeCSIPLicenseBindScheduleSync(DescribeCSIPLicenseBindScheduleRequest req)
        {
            return InternalRequestAsync<DescribeCSIPLicenseBindScheduleResponse>(req, "DescribeCSIPLicenseBindSchedule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get host details of a CSIP scan task.
        /// </summary>
        /// <param name="req"><see cref="DescribeCSIPMalwareScanTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeCSIPMalwareScanTaskDetailResponse"/></returns>
        public Task<DescribeCSIPMalwareScanTaskDetailResponse> DescribeCSIPMalwareScanTaskDetail(DescribeCSIPMalwareScanTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeCSIPMalwareScanTaskDetailResponse>(req, "DescribeCSIPMalwareScanTaskDetail");
        }

        /// <summary>
        /// This API is used to get host details of a CSIP scan task.
        /// </summary>
        /// <param name="req"><see cref="DescribeCSIPMalwareScanTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeCSIPMalwareScanTaskDetailResponse"/></returns>
        public DescribeCSIPMalwareScanTaskDetailResponse DescribeCSIPMalwareScanTaskDetailSync(DescribeCSIPMalwareScanTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeCSIPMalwareScanTaskDetailResponse>(req, "DescribeCSIPMalwareScanTaskDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the progress of CSIP manual scan.
        /// </summary>
        /// <param name="req"><see cref="DescribeCSIPMalwareScanTaskProgressRequest"/></param>
        /// <returns><see cref="DescribeCSIPMalwareScanTaskProgressResponse"/></returns>
        public Task<DescribeCSIPMalwareScanTaskProgressResponse> DescribeCSIPMalwareScanTaskProgress(DescribeCSIPMalwareScanTaskProgressRequest req)
        {
            return InternalRequestAsync<DescribeCSIPMalwareScanTaskProgressResponse>(req, "DescribeCSIPMalwareScanTaskProgress");
        }

        /// <summary>
        /// This API is used to query the progress of CSIP manual scan.
        /// </summary>
        /// <param name="req"><see cref="DescribeCSIPMalwareScanTaskProgressRequest"/></param>
        /// <returns><see cref="DescribeCSIPMalwareScanTaskProgressResponse"/></returns>
        public DescribeCSIPMalwareScanTaskProgressResponse DescribeCSIPMalwareScanTaskProgressSync(DescribeCSIPMalwareScanTaskProgressRequest req)
        {
            return InternalRequestAsync<DescribeCSIPMalwareScanTaskProgressResponse>(req, "DescribeCSIPMalwareScanTaskProgress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain risk center risk overview sample code
        /// </summary>
        /// <param name="req"><see cref="DescribeCSIPRiskStatisticsRequest"/></param>
        /// <returns><see cref="DescribeCSIPRiskStatisticsResponse"/></returns>
        public Task<DescribeCSIPRiskStatisticsResponse> DescribeCSIPRiskStatistics(DescribeCSIPRiskStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeCSIPRiskStatisticsResponse>(req, "DescribeCSIPRiskStatistics");
        }

        /// <summary>
        /// Obtain risk center risk overview sample code
        /// </summary>
        /// <param name="req"><see cref="DescribeCSIPRiskStatisticsRequest"/></param>
        /// <returns><see cref="DescribeCSIPRiskStatisticsResponse"/></returns>
        public DescribeCSIPRiskStatisticsResponse DescribeCSIPRiskStatisticsSync(DescribeCSIPRiskStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeCSIPRiskStatisticsResponse>(req, "DescribeCSIPRiskStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain purchased CSPM order information.
        /// </summary>
        /// <param name="req"><see cref="DescribeCSPMPayInfoRequest"/></param>
        /// <returns><see cref="DescribeCSPMPayInfoResponse"/></returns>
        public Task<DescribeCSPMPayInfoResponse> DescribeCSPMPayInfo(DescribeCSPMPayInfoRequest req)
        {
            return InternalRequestAsync<DescribeCSPMPayInfoResponse>(req, "DescribeCSPMPayInfo");
        }

        /// <summary>
        /// This API is used to obtain purchased CSPM order information.
        /// </summary>
        /// <param name="req"><see cref="DescribeCSPMPayInfoRequest"/></param>
        /// <returns><see cref="DescribeCSPMPayInfoResponse"/></returns>
        public DescribeCSPMPayInfoResponse DescribeCSPMPayInfoSync(DescribeCSPMPayInfoRequest req)
        {
            return InternalRequestAsync<DescribeCSPMPayInfoResponse>(req, "DescribeCSPMPayInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// CVM Details
        /// </summary>
        /// <param name="req"><see cref="DescribeCVMAssetInfoRequest"/></param>
        /// <returns><see cref="DescribeCVMAssetInfoResponse"/></returns>
        public Task<DescribeCVMAssetInfoResponse> DescribeCVMAssetInfo(DescribeCVMAssetInfoRequest req)
        {
            return InternalRequestAsync<DescribeCVMAssetInfoResponse>(req, "DescribeCVMAssetInfo");
        }

        /// <summary>
        /// CVM Details
        /// </summary>
        /// <param name="req"><see cref="DescribeCVMAssetInfoRequest"/></param>
        /// <returns><see cref="DescribeCVMAssetInfoResponse"/></returns>
        public DescribeCVMAssetInfoResponse DescribeCVMAssetInfoSync(DescribeCVMAssetInfoRequest req)
        {
            return InternalRequestAsync<DescribeCVMAssetInfoResponse>(req, "DescribeCVMAssetInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get cvm list
        /// </summary>
        /// <param name="req"><see cref="DescribeCVMAssetsRequest"/></param>
        /// <returns><see cref="DescribeCVMAssetsResponse"/></returns>
        public Task<DescribeCVMAssetsResponse> DescribeCVMAssets(DescribeCVMAssetsRequest req)
        {
            return InternalRequestAsync<DescribeCVMAssetsResponse>(req, "DescribeCVMAssets");
        }

        /// <summary>
        /// Get cvm list
        /// </summary>
        /// <param name="req"><see cref="DescribeCVMAssetsRequest"/></param>
        /// <returns><see cref="DescribeCVMAssetsResponse"/></returns>
        public DescribeCVMAssetsResponse DescribeCVMAssetsSync(DescribeCVMAssetsRequest req)
        {
            return InternalRequestAsync<DescribeCVMAssetsResponse>(req, "DescribeCVMAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries cloud boundary analysis path nodes (dedicated for hosts)
        /// </summary>
        /// <param name="req"><see cref="DescribeCWPExposePathRequest"/></param>
        /// <returns><see cref="DescribeCWPExposePathResponse"/></returns>
        public Task<DescribeCWPExposePathResponse> DescribeCWPExposePath(DescribeCWPExposePathRequest req)
        {
            return InternalRequestAsync<DescribeCWPExposePathResponse>(req, "DescribeCWPExposePath");
        }

        /// <summary>
        /// Queries cloud boundary analysis path nodes (dedicated for hosts)
        /// </summary>
        /// <param name="req"><see cref="DescribeCWPExposePathRequest"/></param>
        /// <returns><see cref="DescribeCWPExposePathResponse"/></returns>
        public DescribeCWPExposePathResponse DescribeCWPExposePathSync(DescribeCWPExposePathRequest req)
        {
            return InternalRequestAsync<DescribeCWPExposePathResponse>(req, "DescribeCWPExposePath")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Cloud boundary analysis asset list (suitable for host assets)
        /// </summary>
        /// <param name="req"><see cref="DescribeCWPExposuresRequest"/></param>
        /// <returns><see cref="DescribeCWPExposuresResponse"/></returns>
        public Task<DescribeCWPExposuresResponse> DescribeCWPExposures(DescribeCWPExposuresRequest req)
        {
            return InternalRequestAsync<DescribeCWPExposuresResponse>(req, "DescribeCWPExposures");
        }

        /// <summary>
        /// Cloud boundary analysis asset list (suitable for host assets)
        /// </summary>
        /// <param name="req"><see cref="DescribeCWPExposuresRequest"/></param>
        /// <returns><see cref="DescribeCWPExposuresResponse"/></returns>
        public DescribeCWPExposuresResponse DescribeCWPExposuresSync(DescribeCWPExposuresRequest req)
        {
            return InternalRequestAsync<DescribeCWPExposuresResponse>(req, "DescribeCWPExposures")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the binding task progress of the authorization.
        /// </summary>
        /// <param name="req"><see cref="DescribeCWPLicenseBindScheduleRequest"/></param>
        /// <returns><see cref="DescribeCWPLicenseBindScheduleResponse"/></returns>
        public Task<DescribeCWPLicenseBindScheduleResponse> DescribeCWPLicenseBindSchedule(DescribeCWPLicenseBindScheduleRequest req)
        {
            return InternalRequestAsync<DescribeCWPLicenseBindScheduleResponse>(req, "DescribeCWPLicenseBindSchedule");
        }

        /// <summary>
        /// This API is used to query the binding task progress of the authorization.
        /// </summary>
        /// <param name="req"><see cref="DescribeCWPLicenseBindScheduleRequest"/></param>
        /// <returns><see cref="DescribeCWPLicenseBindScheduleResponse"/></returns>
        public DescribeCWPLicenseBindScheduleResponse DescribeCWPLicenseBindScheduleSync(DescribeCWPLicenseBindScheduleRequest req)
        {
            return InternalRequestAsync<DescribeCWPLicenseBindScheduleResponse>(req, "DescribeCWPLicenseBindSchedule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Host details
        /// </summary>
        /// <param name="req"><see cref="DescribeCWPMachineDetailRequest"/></param>
        /// <returns><see cref="DescribeCWPMachineDetailResponse"/></returns>
        public Task<DescribeCWPMachineDetailResponse> DescribeCWPMachineDetail(DescribeCWPMachineDetailRequest req)
        {
            return InternalRequestAsync<DescribeCWPMachineDetailResponse>(req, "DescribeCWPMachineDetail");
        }

        /// <summary>
        /// Host details
        /// </summary>
        /// <param name="req"><see cref="DescribeCWPMachineDetailRequest"/></param>
        /// <returns><see cref="DescribeCWPMachineDetailResponse"/></returns>
        public DescribeCWPMachineDetailResponse DescribeCWPMachineDetailSync(DescribeCWPMachineDetailRequest req)
        {
            return InternalRequestAsync<DescribeCWPMachineDetailResponse>(req, "DescribeCWPMachineDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the machine operating system list.
        /// </summary>
        /// <param name="req"><see cref="DescribeCWPMachineOsListRequest"/></param>
        /// <returns><see cref="DescribeCWPMachineOsListResponse"/></returns>
        public Task<DescribeCWPMachineOsListResponse> DescribeCWPMachineOsList(DescribeCWPMachineOsListRequest req)
        {
            return InternalRequestAsync<DescribeCWPMachineOsListResponse>(req, "DescribeCWPMachineOsList");
        }

        /// <summary>
        /// This API is used to query the machine operating system list.
        /// </summary>
        /// <param name="req"><see cref="DescribeCWPMachineOsListRequest"/></param>
        /// <returns><see cref="DescribeCWPMachineOsListResponse"/></returns>
        public DescribeCWPMachineOsListResponse DescribeCWPMachineOsListSync(DescribeCWPMachineOsListRequest req)
        {
            return InternalRequestAsync<DescribeCWPMachineOsListResponse>(req, "DescribeCWPMachineOsList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Host list
        /// </summary>
        /// <param name="req"><see cref="DescribeCWPMachinesRequest"/></param>
        /// <returns><see cref="DescribeCWPMachinesResponse"/></returns>
        public Task<DescribeCWPMachinesResponse> DescribeCWPMachines(DescribeCWPMachinesRequest req)
        {
            return InternalRequestAsync<DescribeCWPMachinesResponse>(req, "DescribeCWPMachines");
        }

        /// <summary>
        /// Host list
        /// </summary>
        /// <param name="req"><see cref="DescribeCWPMachinesRequest"/></param>
        /// <returns><see cref="DescribeCWPMachinesResponse"/></returns>
        public DescribeCWPMachinesResponse DescribeCWPMachinesSync(DescribeCWPMachinesRequest req)
        {
            return InternalRequestAsync<DescribeCWPMachinesResponse>(req, "DescribeCWPMachines")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the resource order list.
        /// </summary>
        /// <param name="req"><see cref="DescribeCWPOrderListRequest"/></param>
        /// <returns><see cref="DescribeCWPOrderListResponse"/></returns>
        public Task<DescribeCWPOrderListResponse> DescribeCWPOrderList(DescribeCWPOrderListRequest req)
        {
            return InternalRequestAsync<DescribeCWPOrderListResponse>(req, "DescribeCWPOrderList");
        }

        /// <summary>
        /// Query the resource order list.
        /// </summary>
        /// <param name="req"><see cref="DescribeCWPOrderListRequest"/></param>
        /// <returns><see cref="DescribeCWPOrderListResponse"/></returns>
        public DescribeCWPOrderListResponse DescribeCWPOrderListSync(DescribeCWPOrderListRequest req)
        {
            return InternalRequestAsync<DescribeCWPOrderListResponse>(req, "DescribeCWPOrderList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query Tencent Cloud scan IP information
        /// </summary>
        /// <param name="req"><see cref="DescribeCWPScanIpInfoRequest"/></param>
        /// <returns><see cref="DescribeCWPScanIpInfoResponse"/></returns>
        public Task<DescribeCWPScanIpInfoResponse> DescribeCWPScanIpInfo(DescribeCWPScanIpInfoRequest req)
        {
            return InternalRequestAsync<DescribeCWPScanIpInfoResponse>(req, "DescribeCWPScanIpInfo");
        }

        /// <summary>
        /// Query Tencent Cloud scan IP information
        /// </summary>
        /// <param name="req"><see cref="DescribeCWPScanIpInfoRequest"/></param>
        /// <returns><see cref="DescribeCWPScanIpInfoResponse"/></returns>
        public DescribeCWPScanIpInfoResponse DescribeCWPScanIpInfoSync(DescribeCWPScanIpInfoRequest req)
        {
            return InternalRequestAsync<DescribeCWPScanIpInfoResponse>(req, "DescribeCWPScanIpInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain Task Distribution Duration
        /// </summary>
        /// <param name="req"><see cref="DescribeCWPTaskDurationRequest"/></param>
        /// <returns><see cref="DescribeCWPTaskDurationResponse"/></returns>
        public Task<DescribeCWPTaskDurationResponse> DescribeCWPTaskDuration(DescribeCWPTaskDurationRequest req)
        {
            return InternalRequestAsync<DescribeCWPTaskDurationResponse>(req, "DescribeCWPTaskDuration");
        }

        /// <summary>
        /// Obtain Task Distribution Duration
        /// </summary>
        /// <param name="req"><see cref="DescribeCWPTaskDurationRequest"/></param>
        /// <returns><see cref="DescribeCWPTaskDurationResponse"/></returns>
        public DescribeCWPTaskDurationResponse DescribeCWPTaskDurationSync(DescribeCWPTaskDurationRequest req)
        {
            return InternalRequestAsync<DescribeCWPTaskDurationResponse>(req, "DescribeCWPTaskDuration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the call record list
        /// </summary>
        /// <param name="req"><see cref="DescribeCallRecordRequest"/></param>
        /// <returns><see cref="DescribeCallRecordResponse"/></returns>
        public Task<DescribeCallRecordResponse> DescribeCallRecord(DescribeCallRecordRequest req)
        {
            return InternalRequestAsync<DescribeCallRecordResponse>(req, "DescribeCallRecord");
        }

        /// <summary>
        /// Query the call record list
        /// </summary>
        /// <param name="req"><see cref="DescribeCallRecordRequest"/></param>
        /// <returns><see cref="DescribeCallRecordResponse"/></returns>
        public DescribeCallRecordResponse DescribeCallRecordSync(DescribeCallRecordRequest req)
        {
            return InternalRequestAsync<DescribeCallRecordResponse>(req, "DescribeCallRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the list of connectivity detection hosts
        /// </summary>
        /// <param name="req"><see cref="DescribeCheckConnectivityHostListRequest"/></param>
        /// <returns><see cref="DescribeCheckConnectivityHostListResponse"/></returns>
        public Task<DescribeCheckConnectivityHostListResponse> DescribeCheckConnectivityHostList(DescribeCheckConnectivityHostListRequest req)
        {
            return InternalRequestAsync<DescribeCheckConnectivityHostListResponse>(req, "DescribeCheckConnectivityHostList");
        }

        /// <summary>
        /// Query the list of connectivity detection hosts
        /// </summary>
        /// <param name="req"><see cref="DescribeCheckConnectivityHostListRequest"/></param>
        /// <returns><see cref="DescribeCheckConnectivityHostListResponse"/></returns>
        public DescribeCheckConnectivityHostListResponse DescribeCheckConnectivityHostListSync(DescribeCheckConnectivityHostListRequest req)
        {
            return InternalRequestAsync<DescribeCheckConnectivityHostListResponse>(req, "DescribeCheckConnectivityHostList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Cloud resource configuration risk list from the check perspective
        /// </summary>
        /// <param name="req"><see cref="DescribeCheckViewRisksRequest"/></param>
        /// <returns><see cref="DescribeCheckViewRisksResponse"/></returns>
        public Task<DescribeCheckViewRisksResponse> DescribeCheckViewRisks(DescribeCheckViewRisksRequest req)
        {
            return InternalRequestAsync<DescribeCheckViewRisksResponse>(req, "DescribeCheckViewRisks");
        }

        /// <summary>
        /// Cloud resource configuration risk list from the check perspective
        /// </summary>
        /// <param name="req"><see cref="DescribeCheckViewRisksRequest"/></param>
        /// <returns><see cref="DescribeCheckViewRisksResponse"/></returns>
        public DescribeCheckViewRisksResponse DescribeCheckViewRisksSync(DescribeCheckViewRisksRequest req)
        {
            return InternalRequestAsync<DescribeCheckViewRisksResponse>(req, "DescribeCheckViewRisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the listener list corresponding to a specified Tencent Cloud CLB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeClbListenerListRequest"/></param>
        /// <returns><see cref="DescribeClbListenerListResponse"/></returns>
        public Task<DescribeClbListenerListResponse> DescribeClbListenerList(DescribeClbListenerListRequest req)
        {
            return InternalRequestAsync<DescribeClbListenerListResponse>(req, "DescribeClbListenerList");
        }

        /// <summary>
        /// Queries the listener list corresponding to a specified Tencent Cloud CLB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeClbListenerListRequest"/></param>
        /// <returns><see cref="DescribeClbListenerListResponse"/></returns>
        public DescribeClbListenerListResponse DescribeClbListenerListSync(DescribeClbListenerListRequest req)
        {
            return InternalRequestAsync<DescribeClbListenerListResponse>(req, "DescribeClbListenerList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the list of Layer 7 forwarding rules corresponding to a specified CLB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeClbListenerRulesRequest"/></param>
        /// <returns><see cref="DescribeClbListenerRulesResponse"/></returns>
        public Task<DescribeClbListenerRulesResponse> DescribeClbListenerRules(DescribeClbListenerRulesRequest req)
        {
            return InternalRequestAsync<DescribeClbListenerRulesResponse>(req, "DescribeClbListenerRules");
        }

        /// <summary>
        /// Queries the list of Layer 7 forwarding rules corresponding to a specified CLB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeClbListenerRulesRequest"/></param>
        /// <returns><see cref="DescribeClbListenerRulesResponse"/></returns>
        public DescribeClbListenerRulesResponse DescribeClbListenerRulesSync(DescribeClbListenerRulesRequest req)
        {
            return InternalRequestAsync<DescribeClbListenerRulesResponse>(req, "DescribeClbListenerRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the CLB backend service list
        /// </summary>
        /// <param name="req"><see cref="DescribeClbTargetsRequest"/></param>
        /// <returns><see cref="DescribeClbTargetsResponse"/></returns>
        public Task<DescribeClbTargetsResponse> DescribeClbTargets(DescribeClbTargetsRequest req)
        {
            return InternalRequestAsync<DescribeClbTargetsResponse>(req, "DescribeClbTargets");
        }

        /// <summary>
        /// Query the CLB backend service list
        /// </summary>
        /// <param name="req"><see cref="DescribeClbTargetsRequest"/></param>
        /// <returns><see cref="DescribeClbTargetsResponse"/></returns>
        public DescribeClbTargetsResponse DescribeClbTargetsSync(DescribeClbTargetsRequest req)
        {
            return InternalRequestAsync<DescribeClbTargetsResponse>(req, "DescribeClbTargets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// All assets
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudAssetsRequest"/></param>
        /// <returns><see cref="DescribeCloudAssetsResponse"/></returns>
        public Task<DescribeCloudAssetsResponse> DescribeCloudAssets(DescribeCloudAssetsRequest req)
        {
            return InternalRequestAsync<DescribeCloudAssetsResponse>(req, "DescribeCloudAssets");
        }

        /// <summary>
        /// All assets
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudAssetsRequest"/></param>
        /// <returns><see cref="DescribeCloudAssetsResponse"/></returns>
        public DescribeCloudAssetsResponse DescribeCloudAssetsSync(DescribeCloudAssetsRequest req)
        {
            return InternalRequestAsync<DescribeCloudAssetsResponse>(req, "DescribeCloudAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Function list
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudFunctionListRequest"/></param>
        /// <returns><see cref="DescribeCloudFunctionListResponse"/></returns>
        public Task<DescribeCloudFunctionListResponse> DescribeCloudFunctionList(DescribeCloudFunctionListRequest req)
        {
            return InternalRequestAsync<DescribeCloudFunctionListResponse>(req, "DescribeCloudFunctionList");
        }

        /// <summary>
        /// Function list
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudFunctionListRequest"/></param>
        /// <returns><see cref="DescribeCloudFunctionListResponse"/></returns>
        public DescribeCloudFunctionListResponse DescribeCloudFunctionListSync(DescribeCloudFunctionListRequest req)
        {
            return InternalRequestAsync<DescribeCloudFunctionListResponse>(req, "DescribeCloudFunctionList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the asset list of a container cluster
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterAssetListRequest"/></param>
        /// <returns><see cref="DescribeClusterAssetListResponse"/></returns>
        public Task<DescribeClusterAssetListResponse> DescribeClusterAssetList(DescribeClusterAssetListRequest req)
        {
            return InternalRequestAsync<DescribeClusterAssetListResponse>(req, "DescribeClusterAssetList");
        }

        /// <summary>
        /// Queries the asset list of a container cluster
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterAssetListRequest"/></param>
        /// <returns><see cref="DescribeClusterAssetListResponse"/></returns>
        public DescribeClusterAssetListResponse DescribeClusterAssetListSync(DescribeClusterAssetListRequest req)
        {
            return InternalRequestAsync<DescribeClusterAssetListResponse>(req, "DescribeClusterAssetList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the synchronization task status of cluster assets.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterAssetSyncTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeClusterAssetSyncTaskStatusResponse"/></returns>
        public Task<DescribeClusterAssetSyncTaskStatusResponse> DescribeClusterAssetSyncTaskStatus(DescribeClusterAssetSyncTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeClusterAssetSyncTaskStatusResponse>(req, "DescribeClusterAssetSyncTaskStatus");
        }

        /// <summary>
        /// This API is used to query the synchronization task status of cluster assets.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterAssetSyncTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeClusterAssetSyncTaskStatusResponse"/></returns>
        public DescribeClusterAssetSyncTaskStatusResponse DescribeClusterAssetSyncTaskStatusSync(DescribeClusterAssetSyncTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeClusterAssetSyncTaskStatusResponse>(req, "DescribeClusterAssetSyncTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This example shows you how to obtain the cluster list.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterAssetsRequest"/></param>
        /// <returns><see cref="DescribeClusterAssetsResponse"/></returns>
        public Task<DescribeClusterAssetsResponse> DescribeClusterAssets(DescribeClusterAssetsRequest req)
        {
            return InternalRequestAsync<DescribeClusterAssetsResponse>(req, "DescribeClusterAssets");
        }

        /// <summary>
        /// This example shows you how to obtain the cluster list.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterAssetsRequest"/></param>
        /// <returns><see cref="DescribeClusterAssetsResponse"/></returns>
        public DescribeClusterAssetsResponse DescribeClusterAssetsSync(DescribeClusterAssetsRequest req)
        {
            return InternalRequestAsync<DescribeClusterAssetsResponse>(req, "DescribeClusterAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the associated application list of a container. It retrieves associated application service information by container ID and supports pagination.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterContainerAppListRequest"/></param>
        /// <returns><see cref="DescribeClusterContainerAppListResponse"/></returns>
        public Task<DescribeClusterContainerAppListResponse> DescribeClusterContainerAppList(DescribeClusterContainerAppListRequest req)
        {
            return InternalRequestAsync<DescribeClusterContainerAppListResponse>(req, "DescribeClusterContainerAppList");
        }

        /// <summary>
        /// This API is used to query the associated application list of a container. It retrieves associated application service information by container ID and supports pagination.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterContainerAppListRequest"/></param>
        /// <returns><see cref="DescribeClusterContainerAppListResponse"/></returns>
        public DescribeClusterContainerAppListResponse DescribeClusterContainerAppListSync(DescribeClusterContainerAppListRequest req)
        {
            return InternalRequestAsync<DescribeClusterContainerAppListResponse>(req, "DescribeClusterContainerAppList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the list of components associated with a container. Get associated component information by container ID. Pagination is supported.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterContainerComponentListRequest"/></param>
        /// <returns><see cref="DescribeClusterContainerComponentListResponse"/></returns>
        public Task<DescribeClusterContainerComponentListResponse> DescribeClusterContainerComponentList(DescribeClusterContainerComponentListRequest req)
        {
            return InternalRequestAsync<DescribeClusterContainerComponentListResponse>(req, "DescribeClusterContainerComponentList");
        }

        /// <summary>
        /// Query the list of components associated with a container. Get associated component information by container ID. Pagination is supported.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterContainerComponentListRequest"/></param>
        /// <returns><see cref="DescribeClusterContainerComponentListResponse"/></returns>
        public DescribeClusterContainerComponentListResponse DescribeClusterContainerComponentListSync(DescribeClusterContainerComponentListRequest req)
        {
            return InternalRequestAsync<DescribeClusterContainerComponentListResponse>(req, "DescribeClusterContainerComponentList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query cluster container details. It retrieves basic container info, mirror information, mount information, network info, and associated node information by container ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterContainerDetailRequest"/></param>
        /// <returns><see cref="DescribeClusterContainerDetailResponse"/></returns>
        public Task<DescribeClusterContainerDetailResponse> DescribeClusterContainerDetail(DescribeClusterContainerDetailRequest req)
        {
            return InternalRequestAsync<DescribeClusterContainerDetailResponse>(req, "DescribeClusterContainerDetail");
        }

        /// <summary>
        /// This API is used to query cluster container details. It retrieves basic container info, mirror information, mount information, network info, and associated node information by container ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterContainerDetailRequest"/></param>
        /// <returns><see cref="DescribeClusterContainerDetailResponse"/></returns>
        public DescribeClusterContainerDetailResponse DescribeClusterContainerDetailSync(DescribeClusterContainerDetailRequest req)
        {
            return InternalRequestAsync<DescribeClusterContainerDetailResponse>(req, "DescribeClusterContainerDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the container list of a cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterContainerListRequest"/></param>
        /// <returns><see cref="DescribeClusterContainerListResponse"/></returns>
        public Task<DescribeClusterContainerListResponse> DescribeClusterContainerList(DescribeClusterContainerListRequest req)
        {
            return InternalRequestAsync<DescribeClusterContainerListResponse>(req, "DescribeClusterContainerList");
        }

        /// <summary>
        /// Query the container list of a cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterContainerListRequest"/></param>
        /// <returns><see cref="DescribeClusterContainerListResponse"/></returns>
        public DescribeClusterContainerListResponse DescribeClusterContainerListSync(DescribeClusterContainerListRequest req)
        {
            return InternalRequestAsync<DescribeClusterContainerListResponse>(req, "DescribeClusterContainerList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the list of ports associated with a container. This API is used to obtain associated port information by container ID and supports pagination.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterContainerPortListRequest"/></param>
        /// <returns><see cref="DescribeClusterContainerPortListResponse"/></returns>
        public Task<DescribeClusterContainerPortListResponse> DescribeClusterContainerPortList(DescribeClusterContainerPortListRequest req)
        {
            return InternalRequestAsync<DescribeClusterContainerPortListResponse>(req, "DescribeClusterContainerPortList");
        }

        /// <summary>
        /// Query the list of ports associated with a container. This API is used to obtain associated port information by container ID and supports pagination.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterContainerPortListRequest"/></param>
        /// <returns><see cref="DescribeClusterContainerPortListResponse"/></returns>
        public DescribeClusterContainerPortListResponse DescribeClusterContainerPortListSync(DescribeClusterContainerPortListRequest req)
        {
            return InternalRequestAsync<DescribeClusterContainerPortListResponse>(req, "DescribeClusterContainerPortList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the associated process list of a container. It obtains associated process information by container ID, supports time sorting and pagination. Filter.By supports StartTime; Filter.Order supports ASC/DESC.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterContainerProcessListRequest"/></param>
        /// <returns><see cref="DescribeClusterContainerProcessListResponse"/></returns>
        public Task<DescribeClusterContainerProcessListResponse> DescribeClusterContainerProcessList(DescribeClusterContainerProcessListRequest req)
        {
            return InternalRequestAsync<DescribeClusterContainerProcessListResponse>(req, "DescribeClusterContainerProcessList");
        }

        /// <summary>
        /// This API is used to query the associated process list of a container. It obtains associated process information by container ID, supports time sorting and pagination. Filter.By supports StartTime; Filter.Order supports ASC/DESC.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterContainerProcessListRequest"/></param>
        /// <returns><see cref="DescribeClusterContainerProcessListResponse"/></returns>
        public DescribeClusterContainerProcessListResponse DescribeClusterContainerProcessListSync(DescribeClusterContainerProcessListRequest req)
        {
            return InternalRequestAsync<DescribeClusterContainerProcessListResponse>(req, "DescribeClusterContainerProcessList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the associated Web Service List of a container. It retrieves associated web service information by container ID and supports pagination.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterContainerWebServiceListRequest"/></param>
        /// <returns><see cref="DescribeClusterContainerWebServiceListResponse"/></returns>
        public Task<DescribeClusterContainerWebServiceListResponse> DescribeClusterContainerWebServiceList(DescribeClusterContainerWebServiceListRequest req)
        {
            return InternalRequestAsync<DescribeClusterContainerWebServiceListResponse>(req, "DescribeClusterContainerWebServiceList");
        }

        /// <summary>
        /// This API is used to query the associated Web Service List of a container. It retrieves associated web service information by container ID and supports pagination.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterContainerWebServiceListRequest"/></param>
        /// <returns><see cref="DescribeClusterContainerWebServiceListResponse"/></returns>
        public DescribeClusterContainerWebServiceListResponse DescribeClusterContainerWebServiceListSync(DescribeClusterContainerWebServiceListRequest req)
        {
            return InternalRequestAsync<DescribeClusterContainerWebServiceListResponse>(req, "DescribeClusterContainerWebServiceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Querying Cluster Details
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterDetailRequest"/></param>
        /// <returns><see cref="DescribeClusterDetailResponse"/></returns>
        public Task<DescribeClusterDetailResponse> DescribeClusterDetail(DescribeClusterDetailRequest req)
        {
            return InternalRequestAsync<DescribeClusterDetailResponse>(req, "DescribeClusterDetail");
        }

        /// <summary>
        /// Querying Cluster Details
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterDetailRequest"/></param>
        /// <returns><see cref="DescribeClusterDetailResponse"/></returns>
        public DescribeClusterDetailResponse DescribeClusterDetailSync(DescribeClusterDetailRequest req)
        {
            return InternalRequestAsync<DescribeClusterDetailResponse>(req, "DescribeClusterDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the cluster installation command
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterInstallCommandRequest"/></param>
        /// <returns><see cref="DescribeClusterInstallCommandResponse"/></returns>
        public Task<DescribeClusterInstallCommandResponse> DescribeClusterInstallCommand(DescribeClusterInstallCommandRequest req)
        {
            return InternalRequestAsync<DescribeClusterInstallCommandResponse>(req, "DescribeClusterInstallCommand");
        }

        /// <summary>
        /// Query the cluster installation command
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterInstallCommandRequest"/></param>
        /// <returns><see cref="DescribeClusterInstallCommandResponse"/></returns>
        public DescribeClusterInstallCommandResponse DescribeClusterInstallCommandSync(DescribeClusterInstallCommandRequest req)
        {
            return InternalRequestAsync<DescribeClusterInstallCommandResponse>(req, "DescribeClusterInstallCommand")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the cluster namespace list.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterNamespaceListRequest"/></param>
        /// <returns><see cref="DescribeClusterNamespaceListResponse"/></returns>
        public Task<DescribeClusterNamespaceListResponse> DescribeClusterNamespaceList(DescribeClusterNamespaceListRequest req)
        {
            return InternalRequestAsync<DescribeClusterNamespaceListResponse>(req, "DescribeClusterNamespaceList");
        }

        /// <summary>
        /// Query the cluster namespace list.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterNamespaceListRequest"/></param>
        /// <returns><see cref="DescribeClusterNamespaceListResponse"/></returns>
        public DescribeClusterNamespaceListResponse DescribeClusterNamespaceListSync(DescribeClusterNamespaceListRequest req)
        {
            return InternalRequestAsync<DescribeClusterNamespaceListResponse>(req, "DescribeClusterNamespaceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the cluster node list.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterNodeListRequest"/></param>
        /// <returns><see cref="DescribeClusterNodeListResponse"/></returns>
        public Task<DescribeClusterNodeListResponse> DescribeClusterNodeList(DescribeClusterNodeListRequest req)
        {
            return InternalRequestAsync<DescribeClusterNodeListResponse>(req, "DescribeClusterNodeList");
        }

        /// <summary>
        /// Query the cluster node list.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterNodeListRequest"/></param>
        /// <returns><see cref="DescribeClusterNodeListResponse"/></returns>
        public DescribeClusterNodeListResponse DescribeClusterNodeListSync(DescribeClusterNodeListRequest req)
        {
            return InternalRequestAsync<DescribeClusterNodeListResponse>(req, "DescribeClusterNodeList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Cluster Pod List
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterPodAssetsRequest"/></param>
        /// <returns><see cref="DescribeClusterPodAssetsResponse"/></returns>
        public Task<DescribeClusterPodAssetsResponse> DescribeClusterPodAssets(DescribeClusterPodAssetsRequest req)
        {
            return InternalRequestAsync<DescribeClusterPodAssetsResponse>(req, "DescribeClusterPodAssets");
        }

        /// <summary>
        /// Cluster Pod List
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterPodAssetsRequest"/></param>
        /// <returns><see cref="DescribeClusterPodAssetsResponse"/></returns>
        public DescribeClusterPodAssetsResponse DescribeClusterPodAssetsSync(DescribeClusterPodAssetsRequest req)
        {
            return InternalRequestAsync<DescribeClusterPodAssetsResponse>(req, "DescribeClusterPodAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query Pod details in A cluster. It is A new Type A API for the container asset revision and serves as the main entrance to the Pod Asset Details Page. The input parameter is only UniqueID. The output parameters cover asset information, cluster, namespace, node, Workload, as well as the number of risk events and alarm events grouped by four risk levels.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterPodDetailRequest"/></param>
        /// <returns><see cref="DescribeClusterPodDetailResponse"/></returns>
        public Task<DescribeClusterPodDetailResponse> DescribeClusterPodDetail(DescribeClusterPodDetailRequest req)
        {
            return InternalRequestAsync<DescribeClusterPodDetailResponse>(req, "DescribeClusterPodDetail");
        }

        /// <summary>
        /// This API is used to query Pod details in A cluster. It is A new Type A API for the container asset revision and serves as the main entrance to the Pod Asset Details Page. The input parameter is only UniqueID. The output parameters cover asset information, cluster, namespace, node, Workload, as well as the number of risk events and alarm events grouped by four risk levels.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterPodDetailRequest"/></param>
        /// <returns><see cref="DescribeClusterPodDetailResponse"/></returns>
        public DescribeClusterPodDetailResponse DescribeClusterPodDetailSync(DescribeClusterPodDetailRequest req)
        {
            return InternalRequestAsync<DescribeClusterPodDetailResponse>(req, "DescribeClusterPodDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Inquires the cluster pod list
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterPodListRequest"/></param>
        /// <returns><see cref="DescribeClusterPodListResponse"/></returns>
        public Task<DescribeClusterPodListResponse> DescribeClusterPodList(DescribeClusterPodListRequest req)
        {
            return InternalRequestAsync<DescribeClusterPodListResponse>(req, "DescribeClusterPodList");
        }

        /// <summary>
        /// Inquires the cluster pod list
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterPodListRequest"/></param>
        /// <returns><see cref="DescribeClusterPodListResponse"/></returns>
        public DescribeClusterPodListResponse DescribeClusterPodListSync(DescribeClusterPodListRequest req)
        {
            return InternalRequestAsync<DescribeClusterPodListResponse>(req, "DescribeClusterPodList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the cluster service list.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterServiceListRequest"/></param>
        /// <returns><see cref="DescribeClusterServiceListResponse"/></returns>
        public Task<DescribeClusterServiceListResponse> DescribeClusterServiceList(DescribeClusterServiceListRequest req)
        {
            return InternalRequestAsync<DescribeClusterServiceListResponse>(req, "DescribeClusterServiceList");
        }

        /// <summary>
        /// Query the cluster service list.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterServiceListRequest"/></param>
        /// <returns><see cref="DescribeClusterServiceListResponse"/></returns>
        public DescribeClusterServiceListResponse DescribeClusterServiceListSync(DescribeClusterServiceListRequest req)
        {
            return InternalRequestAsync<DescribeClusterServiceListResponse>(req, "DescribeClusterServiceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query cluster overview data
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterSummaryRequest"/></param>
        /// <returns><see cref="DescribeClusterSummaryResponse"/></returns>
        public Task<DescribeClusterSummaryResponse> DescribeClusterSummary(DescribeClusterSummaryRequest req)
        {
            return InternalRequestAsync<DescribeClusterSummaryResponse>(req, "DescribeClusterSummary");
        }

        /// <summary>
        /// Query cluster overview data
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterSummaryRequest"/></param>
        /// <returns><see cref="DescribeClusterSummaryResponse"/></returns>
        public DescribeClusterSummaryResponse DescribeClusterSummarySync(DescribeClusterSummaryRequest req)
        {
            return InternalRequestAsync<DescribeClusterSummaryResponse>(req, "DescribeClusterSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query super node details in a cluster and return basic info (region, availability zone, last asset update time, node origin, subnet, and core count) and cluster information (cluster name, Cluster ID, cluster status, Kubernetes version, and Kubelet version).
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterSuperNodeInfoRequest"/></param>
        /// <returns><see cref="DescribeClusterSuperNodeInfoResponse"/></returns>
        public Task<DescribeClusterSuperNodeInfoResponse> DescribeClusterSuperNodeInfo(DescribeClusterSuperNodeInfoRequest req)
        {
            return InternalRequestAsync<DescribeClusterSuperNodeInfoResponse>(req, "DescribeClusterSuperNodeInfo");
        }

        /// <summary>
        /// This API is used to query super node details in a cluster and return basic info (region, availability zone, last asset update time, node origin, subnet, and core count) and cluster information (cluster name, Cluster ID, cluster status, Kubernetes version, and Kubelet version).
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterSuperNodeInfoRequest"/></param>
        /// <returns><see cref="DescribeClusterSuperNodeInfoResponse"/></returns>
        public DescribeClusterSuperNodeInfoResponse DescribeClusterSuperNodeInfoSync(DescribeClusterSuperNodeInfoRequest req)
        {
            return InternalRequestAsync<DescribeClusterSuperNodeInfoResponse>(req, "DescribeClusterSuperNodeInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Cloud resource configuration detection compliance overview
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceOverviewRequest"/></param>
        /// <returns><see cref="DescribeComplianceOverviewResponse"/></returns>
        public Task<DescribeComplianceOverviewResponse> DescribeComplianceOverview(DescribeComplianceOverviewRequest req)
        {
            return InternalRequestAsync<DescribeComplianceOverviewResponse>(req, "DescribeComplianceOverview");
        }

        /// <summary>
        /// Cloud resource configuration detection compliance overview
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceOverviewRequest"/></param>
        /// <returns><see cref="DescribeComplianceOverviewResponse"/></returns>
        public DescribeComplianceOverviewResponse DescribeComplianceOverviewSync(DescribeComplianceOverviewRequest req)
        {
            return InternalRequestAsync<DescribeComplianceOverviewResponse>(req, "DescribeComplianceOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Cloud resource configuration risk list from the compliance standard aggregation perspective
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceRiskListRequest"/></param>
        /// <returns><see cref="DescribeComplianceRiskListResponse"/></returns>
        public Task<DescribeComplianceRiskListResponse> DescribeComplianceRiskList(DescribeComplianceRiskListRequest req)
        {
            return InternalRequestAsync<DescribeComplianceRiskListResponse>(req, "DescribeComplianceRiskList");
        }

        /// <summary>
        /// Cloud resource configuration risk list from the compliance standard aggregation perspective
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceRiskListRequest"/></param>
        /// <returns><see cref="DescribeComplianceRiskListResponse"/></returns>
        public DescribeComplianceRiskListResponse DescribeComplianceRiskListSync(DescribeComplianceRiskListRequest req)
        {
            return InternalRequestAsync<DescribeComplianceRiskListResponse>(req, "DescribeComplianceRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Cloud resource configuration inspection standard chapter clause tree
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceStandardTermTreeRequest"/></param>
        /// <returns><see cref="DescribeComplianceStandardTermTreeResponse"/></returns>
        public Task<DescribeComplianceStandardTermTreeResponse> DescribeComplianceStandardTermTree(DescribeComplianceStandardTermTreeRequest req)
        {
            return InternalRequestAsync<DescribeComplianceStandardTermTreeResponse>(req, "DescribeComplianceStandardTermTree");
        }

        /// <summary>
        /// Cloud resource configuration inspection standard chapter clause tree
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceStandardTermTreeRequest"/></param>
        /// <returns><see cref="DescribeComplianceStandardTermTreeResponse"/></returns>
        public DescribeComplianceStandardTermTreeResponse DescribeComplianceStandardTermTreeSync(DescribeComplianceStandardTermTreeRequest req)
        {
            return InternalRequestAsync<DescribeComplianceStandardTermTreeResponse>(req, "DescribeComplianceStandardTermTree")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Category statistics for cloud resource configuration detection specifications
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceStatisticsRequest"/></param>
        /// <returns><see cref="DescribeComplianceStatisticsResponse"/></returns>
        public Task<DescribeComplianceStatisticsResponse> DescribeComplianceStatistics(DescribeComplianceStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeComplianceStatisticsResponse>(req, "DescribeComplianceStatistics");
        }

        /// <summary>
        /// Category statistics for cloud resource configuration detection specifications
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceStatisticsRequest"/></param>
        /// <returns><see cref="DescribeComplianceStatisticsResponse"/></returns>
        public DescribeComplianceStatisticsResponse DescribeComplianceStatisticsSync(DescribeComplianceStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeComplianceStatisticsResponse>(req, "DescribeComplianceStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Example of cloud resource configuration risk rule list
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigCheckRulesRequest"/></param>
        /// <returns><see cref="DescribeConfigCheckRulesResponse"/></returns>
        public Task<DescribeConfigCheckRulesResponse> DescribeConfigCheckRules(DescribeConfigCheckRulesRequest req)
        {
            return InternalRequestAsync<DescribeConfigCheckRulesResponse>(req, "DescribeConfigCheckRules");
        }

        /// <summary>
        /// Example of cloud resource configuration risk rule list
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigCheckRulesRequest"/></param>
        /// <returns><see cref="DescribeConfigCheckRulesResponse"/></returns>
        public DescribeConfigCheckRulesResponse DescribeConfigCheckRulesSync(DescribeConfigCheckRulesRequest req)
        {
            return InternalRequestAsync<DescribeConfigCheckRulesResponse>(req, "DescribeConfigCheckRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the CSPM auto quota shared configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeCspmShardConfigRequest"/></param>
        /// <returns><see cref="DescribeCspmShardConfigResponse"/></returns>
        public Task<DescribeCspmShardConfigResponse> DescribeCspmShardConfig(DescribeCspmShardConfigRequest req)
        {
            return InternalRequestAsync<DescribeCspmShardConfigResponse>(req, "DescribeCspmShardConfig");
        }

        /// <summary>
        /// This API is used to query the CSPM auto quota shared configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeCspmShardConfigRequest"/></param>
        /// <returns><see cref="DescribeCspmShardConfigResponse"/></returns>
        public DescribeCspmShardConfigResponse DescribeCspmShardConfigSync(DescribeCspmShardConfigRequest req)
        {
            return InternalRequestAsync<DescribeCspmShardConfigResponse>(req, "DescribeCspmShardConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// number of user-customized tags
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomAssetTagCountRequest"/></param>
        /// <returns><see cref="DescribeCustomAssetTagCountResponse"/></returns>
        public Task<DescribeCustomAssetTagCountResponse> DescribeCustomAssetTagCount(DescribeCustomAssetTagCountRequest req)
        {
            return InternalRequestAsync<DescribeCustomAssetTagCountResponse>(req, "DescribeCustomAssetTagCount");
        }

        /// <summary>
        /// number of user-customized tags
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomAssetTagCountRequest"/></param>
        /// <returns><see cref="DescribeCustomAssetTagCountResponse"/></returns>
        public DescribeCustomAssetTagCountResponse DescribeCustomAssetTagCountSync(DescribeCustomAssetTagCountRequest req)
        {
            return InternalRequestAsync<DescribeCustomAssetTagCountResponse>(req, "DescribeCustomAssetTagCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Example of a custom risk rule configuration detail list
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomRiskRuleDetailRequest"/></param>
        /// <returns><see cref="DescribeCustomRiskRuleDetailResponse"/></returns>
        public Task<DescribeCustomRiskRuleDetailResponse> DescribeCustomRiskRuleDetail(DescribeCustomRiskRuleDetailRequest req)
        {
            return InternalRequestAsync<DescribeCustomRiskRuleDetailResponse>(req, "DescribeCustomRiskRuleDetail");
        }

        /// <summary>
        /// Example of a custom risk rule configuration detail list
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomRiskRuleDetailRequest"/></param>
        /// <returns><see cref="DescribeCustomRiskRuleDetailResponse"/></returns>
        public DescribeCustomRiskRuleDetailResponse DescribeCustomRiskRuleDetailSync(DescribeCustomRiskRuleDetailRequest req)
        {
            return InternalRequestAsync<DescribeCustomRiskRuleDetailResponse>(req, "DescribeCustomRiskRuleDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Lists the configuration of custom risk rules
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomRiskRulesRequest"/></param>
        /// <returns><see cref="DescribeCustomRiskRulesResponse"/></returns>
        public Task<DescribeCustomRiskRulesResponse> DescribeCustomRiskRules(DescribeCustomRiskRulesRequest req)
        {
            return InternalRequestAsync<DescribeCustomRiskRulesResponse>(req, "DescribeCustomRiskRules");
        }

        /// <summary>
        /// Lists the configuration of custom risk rules
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomRiskRulesRequest"/></param>
        /// <returns><see cref="DescribeCustomRiskRulesResponse"/></returns>
        public DescribeCustomRiskRulesResponse DescribeCustomRiskRulesSync(DescribeCustomRiskRulesRequest req)
        {
            return InternalRequestAsync<DescribeCustomRiskRulesResponse>(req, "DescribeCustomRiskRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DB Asset Details
        /// </summary>
        /// <param name="req"><see cref="DescribeDbAssetInfoRequest"/></param>
        /// <returns><see cref="DescribeDbAssetInfoResponse"/></returns>
        public Task<DescribeDbAssetInfoResponse> DescribeDbAssetInfo(DescribeDbAssetInfoRequest req)
        {
            return InternalRequestAsync<DescribeDbAssetInfoResponse>(req, "DescribeDbAssetInfo");
        }

        /// <summary>
        /// DB Asset Details
        /// </summary>
        /// <param name="req"><see cref="DescribeDbAssetInfoRequest"/></param>
        /// <returns><see cref="DescribeDbAssetInfoResponse"/></returns>
        public DescribeDbAssetInfoResponse DescribeDbAssetInfoSync(DescribeDbAssetInfoRequest req)
        {
            return InternalRequestAsync<DescribeDbAssetInfoResponse>(req, "DescribeDbAssetInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Database Asset List
        /// </summary>
        /// <param name="req"><see cref="DescribeDbAssetsRequest"/></param>
        /// <returns><see cref="DescribeDbAssetsResponse"/></returns>
        public Task<DescribeDbAssetsResponse> DescribeDbAssets(DescribeDbAssetsRequest req)
        {
            return InternalRequestAsync<DescribeDbAssetsResponse>(req, "DescribeDbAssets");
        }

        /// <summary>
        /// Database Asset List
        /// </summary>
        /// <param name="req"><see cref="DescribeDbAssetsRequest"/></param>
        /// <returns><see cref="DescribeDbAssetsResponse"/></returns>
        public DescribeDbAssetsResponse DescribeDbAssetsSync(DescribeDbAssetsRequest req)
        {
            return InternalRequestAsync<DescribeDbAssetsResponse>(req, "DescribeDbAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retrieve the built-in default security scoring rules for resetting custom rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultSecurityScoreRuleRequest"/></param>
        /// <returns><see cref="DescribeDefaultSecurityScoreRuleResponse"/></returns>
        public Task<DescribeDefaultSecurityScoreRuleResponse> DescribeDefaultSecurityScoreRule(DescribeDefaultSecurityScoreRuleRequest req)
        {
            return InternalRequestAsync<DescribeDefaultSecurityScoreRuleResponse>(req, "DescribeDefaultSecurityScoreRule");
        }

        /// <summary>
        /// Retrieve the built-in default security scoring rules for resetting custom rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultSecurityScoreRuleRequest"/></param>
        /// <returns><see cref="DescribeDefaultSecurityScoreRuleResponse"/></returns>
        public DescribeDefaultSecurityScoreRuleResponse DescribeDefaultSecurityScoreRuleSync(DescribeDefaultSecurityScoreRuleRequest req)
        {
            return InternalRequestAsync<DescribeDefaultSecurityScoreRuleResponse>(req, "DescribeDefaultSecurityScoreRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Domain name list
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainAssetsRequest"/></param>
        /// <returns><see cref="DescribeDomainAssetsResponse"/></returns>
        public Task<DescribeDomainAssetsResponse> DescribeDomainAssets(DescribeDomainAssetsRequest req)
        {
            return InternalRequestAsync<DescribeDomainAssetsResponse>(req, "DescribeDomainAssets");
        }

        /// <summary>
        /// Domain name list
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainAssetsRequest"/></param>
        /// <returns><see cref="DescribeDomainAssetsResponse"/></returns>
        public DescribeDomainAssetsResponse DescribeDomainAssetsSync(DescribeDomainAssetsRequest req)
        {
            return InternalRequestAsync<DescribeDomainAssetsResponse>(req, "DescribeDomainAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query Dspm access records
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAccessRecordRequest"/></param>
        /// <returns><see cref="DescribeDspmAccessRecordResponse"/></returns>
        public Task<DescribeDspmAccessRecordResponse> DescribeDspmAccessRecord(DescribeDspmAccessRecordRequest req)
        {
            return InternalRequestAsync<DescribeDspmAccessRecordResponse>(req, "DescribeDspmAccessRecord");
        }

        /// <summary>
        /// Query Dspm access records
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAccessRecordRequest"/></param>
        /// <returns><see cref="DescribeDspmAccessRecordResponse"/></returns>
        public DescribeDspmAccessRecordResponse DescribeDspmAccessRecordSync(DescribeDspmAccessRecordRequest req)
        {
            return InternalRequestAsync<DescribeDspmAccessRecordResponse>(req, "DescribeDspmAccessRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the Dspm access topology account list
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAccessTopologyAccountsRequest"/></param>
        /// <returns><see cref="DescribeDspmAccessTopologyAccountsResponse"/></returns>
        public Task<DescribeDspmAccessTopologyAccountsResponse> DescribeDspmAccessTopologyAccounts(DescribeDspmAccessTopologyAccountsRequest req)
        {
            return InternalRequestAsync<DescribeDspmAccessTopologyAccountsResponse>(req, "DescribeDspmAccessTopologyAccounts");
        }

        /// <summary>
        /// Queries the Dspm access topology account list
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAccessTopologyAccountsRequest"/></param>
        /// <returns><see cref="DescribeDspmAccessTopologyAccountsResponse"/></returns>
        public DescribeDspmAccessTopologyAccountsResponse DescribeDspmAccessTopologyAccountsSync(DescribeDspmAccessTopologyAccountsRequest req)
        {
            return InternalRequestAsync<DescribeDspmAccessTopologyAccountsResponse>(req, "DescribeDspmAccessTopologyAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the Dspm access topology asset list
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAccessTopologyAssetsRequest"/></param>
        /// <returns><see cref="DescribeDspmAccessTopologyAssetsResponse"/></returns>
        public Task<DescribeDspmAccessTopologyAssetsResponse> DescribeDspmAccessTopologyAssets(DescribeDspmAccessTopologyAssetsRequest req)
        {
            return InternalRequestAsync<DescribeDspmAccessTopologyAssetsResponse>(req, "DescribeDspmAccessTopologyAssets");
        }

        /// <summary>
        /// Query the Dspm access topology asset list
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAccessTopologyAssetsRequest"/></param>
        /// <returns><see cref="DescribeDspmAccessTopologyAssetsResponse"/></returns>
        public DescribeDspmAccessTopologyAssetsResponse DescribeDspmAccessTopologyAssetsSync(DescribeDspmAccessTopologyAssetsRequest req)
        {
            return InternalRequestAsync<DescribeDspmAccessTopologyAssetsResponse>(req, "DescribeDspmAccessTopologyAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the Dspm access topology ip list
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAccessTopologyIpsRequest"/></param>
        /// <returns><see cref="DescribeDspmAccessTopologyIpsResponse"/></returns>
        public Task<DescribeDspmAccessTopologyIpsResponse> DescribeDspmAccessTopologyIps(DescribeDspmAccessTopologyIpsRequest req)
        {
            return InternalRequestAsync<DescribeDspmAccessTopologyIpsResponse>(req, "DescribeDspmAccessTopologyIps");
        }

        /// <summary>
        /// Query the Dspm access topology ip list
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAccessTopologyIpsRequest"/></param>
        /// <returns><see cref="DescribeDspmAccessTopologyIpsResponse"/></returns>
        public DescribeDspmAccessTopologyIpsResponse DescribeDspmAccessTopologyIpsSync(DescribeDspmAccessTopologyIpsRequest req)
        {
            return InternalRequestAsync<DescribeDspmAccessTopologyIpsResponse>(req, "DescribeDspmAccessTopologyIps")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries Dspm application history
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmApplyHistoryRequest"/></param>
        /// <returns><see cref="DescribeDspmApplyHistoryResponse"/></returns>
        public Task<DescribeDspmApplyHistoryResponse> DescribeDspmApplyHistory(DescribeDspmApplyHistoryRequest req)
        {
            return InternalRequestAsync<DescribeDspmApplyHistoryResponse>(req, "DescribeDspmApplyHistory");
        }

        /// <summary>
        /// Queries Dspm application history
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmApplyHistoryRequest"/></param>
        /// <returns><see cref="DescribeDspmApplyHistoryResponse"/></returns>
        public DescribeDspmApplyHistoryResponse DescribeDspmApplyHistorySync(DescribeDspmApplyHistoryRequest req)
        {
            return InternalRequestAsync<DescribeDspmApplyHistoryResponse>(req, "DescribeDspmApplyHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the Dspm application form list
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmApplyOrderListRequest"/></param>
        /// <returns><see cref="DescribeDspmApplyOrderListResponse"/></returns>
        public Task<DescribeDspmApplyOrderListResponse> DescribeDspmApplyOrderList(DescribeDspmApplyOrderListRequest req)
        {
            return InternalRequestAsync<DescribeDspmApplyOrderListResponse>(req, "DescribeDspmApplyOrderList");
        }

        /// <summary>
        /// Queries the Dspm application form list
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmApplyOrderListRequest"/></param>
        /// <returns><see cref="DescribeDspmApplyOrderListResponse"/></returns>
        public DescribeDspmApplyOrderListResponse DescribeDspmApplyOrderListSync(DescribeDspmApplyOrderListRequest req)
        {
            return InternalRequestAsync<DescribeDspmApplyOrderListResponse>(req, "DescribeDspmApplyOrderList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query Dspm approval history
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmApproveHistoryRequest"/></param>
        /// <returns><see cref="DescribeDspmApproveHistoryResponse"/></returns>
        public Task<DescribeDspmApproveHistoryResponse> DescribeDspmApproveHistory(DescribeDspmApproveHistoryRequest req)
        {
            return InternalRequestAsync<DescribeDspmApproveHistoryResponse>(req, "DescribeDspmApproveHistory");
        }

        /// <summary>
        /// Query Dspm approval history
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmApproveHistoryRequest"/></param>
        /// <returns><see cref="DescribeDspmApproveHistoryResponse"/></returns>
        public DescribeDspmApproveHistoryResponse DescribeDspmApproveHistorySync(DescribeDspmApproveHistoryRequest req)
        {
            return InternalRequestAsync<DescribeDspmApproveHistoryResponse>(req, "DescribeDspmApproveHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries Dspm approval form list
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmApproveOrderListRequest"/></param>
        /// <returns><see cref="DescribeDspmApproveOrderListResponse"/></returns>
        public Task<DescribeDspmApproveOrderListResponse> DescribeDspmApproveOrderList(DescribeDspmApproveOrderListRequest req)
        {
            return InternalRequestAsync<DescribeDspmApproveOrderListResponse>(req, "DescribeDspmApproveOrderList");
        }

        /// <summary>
        /// Queries Dspm approval form list
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmApproveOrderListRequest"/></param>
        /// <returns><see cref="DescribeDspmApproveOrderListResponse"/></returns>
        public DescribeDspmApproveOrderListResponse DescribeDspmApproveOrderListSync(DescribeDspmApproveOrderListRequest req)
        {
            return InternalRequestAsync<DescribeDspmApproveOrderListResponse>(req, "DescribeDspmApproveOrderList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the Dspm asset access topology
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetAccessTopologyRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetAccessTopologyResponse"/></returns>
        public Task<DescribeDspmAssetAccessTopologyResponse> DescribeDspmAssetAccessTopology(DescribeDspmAssetAccessTopologyRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetAccessTopologyResponse>(req, "DescribeDspmAssetAccessTopology");
        }

        /// <summary>
        /// Query the Dspm asset access topology
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetAccessTopologyRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetAccessTopologyResponse"/></returns>
        public DescribeDspmAssetAccessTopologyResponse DescribeDspmAssetAccessTopologySync(DescribeDspmAssetAccessTopologyRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetAccessTopologyResponse>(req, "DescribeDspmAssetAccessTopology")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query Dspm asset account identity information
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetAccountIdentifyRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetAccountIdentifyResponse"/></returns>
        public Task<DescribeDspmAssetAccountIdentifyResponse> DescribeDspmAssetAccountIdentify(DescribeDspmAssetAccountIdentifyRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetAccountIdentifyResponse>(req, "DescribeDspmAssetAccountIdentify");
        }

        /// <summary>
        /// Query Dspm asset account identity information
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetAccountIdentifyRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetAccountIdentifyResponse"/></returns>
        public DescribeDspmAssetAccountIdentifyResponse DescribeDspmAssetAccountIdentifySync(DescribeDspmAssetAccountIdentifyRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetAccountIdentifyResponse>(req, "DescribeDspmAssetAccountIdentify")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Querying preset privileged information of Dspm asset accounts
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetAccountPresetPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetAccountPresetPrivilegesResponse"/></returns>
        public Task<DescribeDspmAssetAccountPresetPrivilegesResponse> DescribeDspmAssetAccountPresetPrivileges(DescribeDspmAssetAccountPresetPrivilegesRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetAccountPresetPrivilegesResponse>(req, "DescribeDspmAssetAccountPresetPrivileges");
        }

        /// <summary>
        /// Querying preset privileged information of Dspm asset accounts
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetAccountPresetPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetAccountPresetPrivilegesResponse"/></returns>
        public DescribeDspmAssetAccountPresetPrivilegesResponse DescribeDspmAssetAccountPresetPrivilegesSync(DescribeDspmAssetAccountPresetPrivilegesRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetAccountPresetPrivilegesResponse>(req, "DescribeDspmAssetAccountPresetPrivileges")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Querying privileged information of Dspm asset accounts after recycling
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetAccountRecycledPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetAccountRecycledPrivilegesResponse"/></returns>
        public Task<DescribeDspmAssetAccountRecycledPrivilegesResponse> DescribeDspmAssetAccountRecycledPrivileges(DescribeDspmAssetAccountRecycledPrivilegesRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetAccountRecycledPrivilegesResponse>(req, "DescribeDspmAssetAccountRecycledPrivileges");
        }

        /// <summary>
        /// Querying privileged information of Dspm asset accounts after recycling
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetAccountRecycledPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetAccountRecycledPrivilegesResponse"/></returns>
        public DescribeDspmAssetAccountRecycledPrivilegesResponse DescribeDspmAssetAccountRecycledPrivilegesSync(DescribeDspmAssetAccountRecycledPrivilegesRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetAccountRecycledPrivilegesResponse>(req, "DescribeDspmAssetAccountRecycledPrivileges")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the Dspm asset account list.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetAccountsRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetAccountsResponse"/></returns>
        public Task<DescribeDspmAssetAccountsResponse> DescribeDspmAssetAccounts(DescribeDspmAssetAccountsRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetAccountsResponse>(req, "DescribeDspmAssetAccounts");
        }

        /// <summary>
        /// Query the Dspm asset account list.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetAccountsRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetAccountsResponse"/></returns>
        public DescribeDspmAssetAccountsResponse DescribeDspmAssetAccountsSync(DescribeDspmAssetAccountsRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetAccountsResponse>(req, "DescribeDspmAssetAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query asset database information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetDatabaseListRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetDatabaseListResponse"/></returns>
        public Task<DescribeDspmAssetDatabaseListResponse> DescribeDspmAssetDatabaseList(DescribeDspmAssetDatabaseListRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetDatabaseListResponse>(req, "DescribeDspmAssetDatabaseList");
        }

        /// <summary>
        /// This API is used to query asset database information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetDatabaseListRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetDatabaseListResponse"/></returns>
        public DescribeDspmAssetDatabaseListResponse DescribeDspmAssetDatabaseListSync(DescribeDspmAssetDatabaseListRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetDatabaseListResponse>(req, "DescribeDspmAssetDatabaseList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of Dspm asset databases.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetDatabasesRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetDatabasesResponse"/></returns>
        public Task<DescribeDspmAssetDatabasesResponse> DescribeDspmAssetDatabases(DescribeDspmAssetDatabasesRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetDatabasesResponse>(req, "DescribeDspmAssetDatabases");
        }

        /// <summary>
        /// This API is used to query the list of Dspm asset databases.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetDatabasesRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetDatabasesResponse"/></returns>
        public DescribeDspmAssetDatabasesResponse DescribeDspmAssetDatabasesSync(DescribeDspmAssetDatabasesRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetDatabasesResponse>(req, "DescribeDspmAssetDatabases")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the dspm asset field information
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetFieldListRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetFieldListResponse"/></returns>
        public Task<DescribeDspmAssetFieldListResponse> DescribeDspmAssetFieldList(DescribeDspmAssetFieldListRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetFieldListResponse>(req, "DescribeDspmAssetFieldList");
        }

        /// <summary>
        /// Queries the dspm asset field information
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetFieldListRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetFieldListResponse"/></returns>
        public DescribeDspmAssetFieldListResponse DescribeDspmAssetFieldListSync(DescribeDspmAssetFieldListRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetFieldListResponse>(req, "DescribeDspmAssetFieldList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query sample values of dspm asset fields
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetFieldSamplesRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetFieldSamplesResponse"/></returns>
        public Task<DescribeDspmAssetFieldSamplesResponse> DescribeDspmAssetFieldSamples(DescribeDspmAssetFieldSamplesRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetFieldSamplesResponse>(req, "DescribeDspmAssetFieldSamples");
        }

        /// <summary>
        /// Query sample values of dspm asset fields
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetFieldSamplesRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetFieldSamplesResponse"/></returns>
        public DescribeDspmAssetFieldSamplesResponse DescribeDspmAssetFieldSamplesSync(DescribeDspmAssetFieldSamplesRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetFieldSamplesResponse>(req, "DescribeDspmAssetFieldSamples")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the dspm asset data recognition information list
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetIdentifyInfoListRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetIdentifyInfoListResponse"/></returns>
        public Task<DescribeDspmAssetIdentifyInfoListResponse> DescribeDspmAssetIdentifyInfoList(DescribeDspmAssetIdentifyInfoListRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetIdentifyInfoListResponse>(req, "DescribeDspmAssetIdentifyInfoList");
        }

        /// <summary>
        /// Queries the dspm asset data recognition information list
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetIdentifyInfoListRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetIdentifyInfoListResponse"/></returns>
        public DescribeDspmAssetIdentifyInfoListResponse DescribeDspmAssetIdentifyInfoListSync(DescribeDspmAssetIdentifyInfoListRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetIdentifyInfoListResponse>(req, "DescribeDspmAssetIdentifyInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the list of Dspm asset IDs
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetIdsRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetIdsResponse"/></returns>
        public Task<DescribeDspmAssetIdsResponse> DescribeDspmAssetIds(DescribeDspmAssetIdsRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetIdsResponse>(req, "DescribeDspmAssetIds");
        }

        /// <summary>
        /// Queries the list of Dspm asset IDs
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetIdsRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetIdsResponse"/></returns>
        public DescribeDspmAssetIdsResponse DescribeDspmAssetIdsSync(DescribeDspmAssetIdsRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetIdsResponse>(req, "DescribeDspmAssetIds")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query Dspm asset login credentials
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetLoginCredentialRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetLoginCredentialResponse"/></returns>
        public Task<DescribeDspmAssetLoginCredentialResponse> DescribeDspmAssetLoginCredential(DescribeDspmAssetLoginCredentialRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetLoginCredentialResponse>(req, "DescribeDspmAssetLoginCredential");
        }

        /// <summary>
        /// Query Dspm asset login credentials
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetLoginCredentialRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetLoginCredentialResponse"/></returns>
        public DescribeDspmAssetLoginCredentialResponse DescribeDspmAssetLoginCredentialSync(DescribeDspmAssetLoginCredentialRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetLoginCredentialResponse>(req, "DescribeDspmAssetLoginCredential")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the security analysis status of Dspm assets.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetSecurityAnalyseStatusRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetSecurityAnalyseStatusResponse"/></returns>
        public Task<DescribeDspmAssetSecurityAnalyseStatusResponse> DescribeDspmAssetSecurityAnalyseStatus(DescribeDspmAssetSecurityAnalyseStatusRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetSecurityAnalyseStatusResponse>(req, "DescribeDspmAssetSecurityAnalyseStatus");
        }

        /// <summary>
        /// Query the security analysis status of Dspm assets.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetSecurityAnalyseStatusRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetSecurityAnalyseStatusResponse"/></returns>
        public DescribeDspmAssetSecurityAnalyseStatusResponse DescribeDspmAssetSecurityAnalyseStatusSync(DescribeDspmAssetSecurityAnalyseStatusRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetSecurityAnalyseStatusResponse>(req, "DescribeDspmAssetSecurityAnalyseStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries supported permissions for Dspm assets
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetSupportedPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetSupportedPrivilegesResponse"/></returns>
        public Task<DescribeDspmAssetSupportedPrivilegesResponse> DescribeDspmAssetSupportedPrivileges(DescribeDspmAssetSupportedPrivilegesRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetSupportedPrivilegesResponse>(req, "DescribeDspmAssetSupportedPrivileges");
        }

        /// <summary>
        /// Queries supported permissions for Dspm assets
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetSupportedPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetSupportedPrivilegesResponse"/></returns>
        public DescribeDspmAssetSupportedPrivilegesResponse DescribeDspmAssetSupportedPrivilegesSync(DescribeDspmAssetSupportedPrivilegesRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetSupportedPrivilegesResponse>(req, "DescribeDspmAssetSupportedPrivileges")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query asset table information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetTableListRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetTableListResponse"/></returns>
        public Task<DescribeDspmAssetTableListResponse> DescribeDspmAssetTableList(DescribeDspmAssetTableListRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetTableListResponse>(req, "DescribeDspmAssetTableList");
        }

        /// <summary>
        /// This API is used to query asset table information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetTableListRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetTableListResponse"/></returns>
        public DescribeDspmAssetTableListResponse DescribeDspmAssetTableListSync(DescribeDspmAssetTableListRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetTableListResponse>(req, "DescribeDspmAssetTableList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the Dspm asset list.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetsRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetsResponse"/></returns>
        public Task<DescribeDspmAssetsResponse> DescribeDspmAssets(DescribeDspmAssetsRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetsResponse>(req, "DescribeDspmAssets");
        }

        /// <summary>
        /// Queries the Dspm asset list.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetsRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetsResponse"/></returns>
        public DescribeDspmAssetsResponse DescribeDspmAssetsSync(DescribeDspmAssetsRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetsResponse>(req, "DescribeDspmAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query dspm audit filter policies
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAuditFilterStrategyRequest"/></param>
        /// <returns><see cref="DescribeDspmAuditFilterStrategyResponse"/></returns>
        public Task<DescribeDspmAuditFilterStrategyResponse> DescribeDspmAuditFilterStrategy(DescribeDspmAuditFilterStrategyRequest req)
        {
            return InternalRequestAsync<DescribeDspmAuditFilterStrategyResponse>(req, "DescribeDspmAuditFilterStrategy");
        }

        /// <summary>
        /// Query dspm audit filter policies
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAuditFilterStrategyRequest"/></param>
        /// <returns><see cref="DescribeDspmAuditFilterStrategyResponse"/></returns>
        public DescribeDspmAuditFilterStrategyResponse DescribeDspmAuditFilterStrategySync(DescribeDspmAuditFilterStrategyRequest req)
        {
            return InternalRequestAsync<DescribeDspmAuditFilterStrategyResponse>(req, "DescribeDspmAuditFilterStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the backup log list.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmBackupLogListRequest"/></param>
        /// <returns><see cref="DescribeDspmBackupLogListResponse"/></returns>
        public Task<DescribeDspmBackupLogListResponse> DescribeDspmBackupLogList(DescribeDspmBackupLogListRequest req)
        {
            return InternalRequestAsync<DescribeDspmBackupLogListResponse>(req, "DescribeDspmBackupLogList");
        }

        /// <summary>
        /// This API is used to query the backup log list.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmBackupLogListRequest"/></param>
        /// <returns><see cref="DescribeDspmBackupLogListResponse"/></returns>
        public DescribeDspmBackupLogListResponse DescribeDspmBackupLogListSync(DescribeDspmBackupLogListRequest req)
        {
            return InternalRequestAsync<DescribeDspmBackupLogListResponse>(req, "DescribeDspmBackupLogList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the log backup configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmBackupSettingRequest"/></param>
        /// <returns><see cref="DescribeDspmBackupSettingResponse"/></returns>
        public Task<DescribeDspmBackupSettingResponse> DescribeDspmBackupSetting(DescribeDspmBackupSettingRequest req)
        {
            return InternalRequestAsync<DescribeDspmBackupSettingResponse>(req, "DescribeDspmBackupSetting");
        }

        /// <summary>
        /// This API is used to query the log backup configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmBackupSettingRequest"/></param>
        /// <returns><see cref="DescribeDspmBackupSettingResponse"/></returns>
        public DescribeDspmBackupSettingResponse DescribeDspmBackupSettingSync(DescribeDspmBackupSettingRequest req)
        {
            return InternalRequestAsync<DescribeDspmBackupSettingResponse>(req, "DescribeDspmBackupSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the routing information of the CKafka instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmCkafkaRouteListRequest"/></param>
        /// <returns><see cref="DescribeDspmCkafkaRouteListResponse"/></returns>
        public Task<DescribeDspmCkafkaRouteListResponse> DescribeDspmCkafkaRouteList(DescribeDspmCkafkaRouteListRequest req)
        {
            return InternalRequestAsync<DescribeDspmCkafkaRouteListResponse>(req, "DescribeDspmCkafkaRouteList");
        }

        /// <summary>
        /// This API is used to query the routing information of the CKafka instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmCkafkaRouteListRequest"/></param>
        /// <returns><see cref="DescribeDspmCkafkaRouteListResponse"/></returns>
        public DescribeDspmCkafkaRouteListResponse DescribeDspmCkafkaRouteListSync(DescribeDspmCkafkaRouteListRequest req)
        {
            return InternalRequestAsync<DescribeDspmCkafkaRouteListResponse>(req, "DescribeDspmCkafkaRouteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the topic list of the instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmCkafkaTopicListRequest"/></param>
        /// <returns><see cref="DescribeDspmCkafkaTopicListResponse"/></returns>
        public Task<DescribeDspmCkafkaTopicListResponse> DescribeDspmCkafkaTopicList(DescribeDspmCkafkaTopicListRequest req)
        {
            return InternalRequestAsync<DescribeDspmCkafkaTopicListResponse>(req, "DescribeDspmCkafkaTopicList");
        }

        /// <summary>
        /// This API is used to query the topic list of the instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmCkafkaTopicListRequest"/></param>
        /// <returns><see cref="DescribeDspmCkafkaTopicListResponse"/></returns>
        public DescribeDspmCkafkaTopicListResponse DescribeDspmCkafkaTopicListSync(DescribeDspmCkafkaTopicListRequest req)
        {
            return InternalRequestAsync<DescribeDspmCkafkaTopicListResponse>(req, "DescribeDspmCkafkaTopicList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the list of dspm dictionary information
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmDictionaryListRequest"/></param>
        /// <returns><see cref="DescribeDspmDictionaryListResponse"/></returns>
        public Task<DescribeDspmDictionaryListResponse> DescribeDspmDictionaryList(DescribeDspmDictionaryListRequest req)
        {
            return InternalRequestAsync<DescribeDspmDictionaryListResponse>(req, "DescribeDspmDictionaryList");
        }

        /// <summary>
        /// Query the list of dspm dictionary information
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmDictionaryListRequest"/></param>
        /// <returns><see cref="DescribeDspmDictionaryListResponse"/></returns>
        public DescribeDspmDictionaryListResponse DescribeDspmDictionaryListSync(DescribeDspmDictionaryListRequest req)
        {
            return InternalRequestAsync<DescribeDspmDictionaryListResponse>(req, "DescribeDspmDictionaryList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query export tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmExportTaskRequest"/></param>
        /// <returns><see cref="DescribeDspmExportTaskResponse"/></returns>
        public Task<DescribeDspmExportTaskResponse> DescribeDspmExportTask(DescribeDspmExportTaskRequest req)
        {
            return InternalRequestAsync<DescribeDspmExportTaskResponse>(req, "DescribeDspmExportTask");
        }

        /// <summary>
        /// This API is used to query export tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmExportTaskRequest"/></param>
        /// <returns><see cref="DescribeDspmExportTaskResponse"/></returns>
        public DescribeDspmExportTaskResponse DescribeDspmExportTaskSync(DescribeDspmExportTaskRequest req)
        {
            return InternalRequestAsync<DescribeDspmExportTaskResponse>(req, "DescribeDspmExportTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Querying the dspm data identification classification list
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyCategoryListRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyCategoryListResponse"/></returns>
        public Task<DescribeDspmIdentifyCategoryListResponse> DescribeDspmIdentifyCategoryList(DescribeDspmIdentifyCategoryListRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyCategoryListResponse>(req, "DescribeDspmIdentifyCategoryList");
        }

        /// <summary>
        /// Querying the dspm data identification classification list
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyCategoryListRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyCategoryListResponse"/></returns>
        public DescribeDspmIdentifyCategoryListResponse DescribeDspmIdentifyCategoryListSync(DescribeDspmIdentifyCategoryListRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyCategoryListResponse>(req, "DescribeDspmIdentifyCategoryList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of data items associated with dspm data recognition template classifications.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyComplianceCategoryRuleListRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyComplianceCategoryRuleListResponse"/></returns>
        public Task<DescribeDspmIdentifyComplianceCategoryRuleListResponse> DescribeDspmIdentifyComplianceCategoryRuleList(DescribeDspmIdentifyComplianceCategoryRuleListRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyComplianceCategoryRuleListResponse>(req, "DescribeDspmIdentifyComplianceCategoryRuleList");
        }

        /// <summary>
        /// This API is used to query the list of data items associated with dspm data recognition template classifications.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyComplianceCategoryRuleListRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyComplianceCategoryRuleListResponse"/></returns>
        public DescribeDspmIdentifyComplianceCategoryRuleListResponse DescribeDspmIdentifyComplianceCategoryRuleListSync(DescribeDspmIdentifyComplianceCategoryRuleListRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyComplianceCategoryRuleListResponse>(req, "DescribeDspmIdentifyComplianceCategoryRuleList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query dspm identification template details
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyComplianceGroupDetailRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyComplianceGroupDetailResponse"/></returns>
        public Task<DescribeDspmIdentifyComplianceGroupDetailResponse> DescribeDspmIdentifyComplianceGroupDetail(DescribeDspmIdentifyComplianceGroupDetailRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyComplianceGroupDetailResponse>(req, "DescribeDspmIdentifyComplianceGroupDetail");
        }

        /// <summary>
        /// Query dspm identification template details
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyComplianceGroupDetailRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyComplianceGroupDetailResponse"/></returns>
        public DescribeDspmIdentifyComplianceGroupDetailResponse DescribeDspmIdentifyComplianceGroupDetailSync(DescribeDspmIdentifyComplianceGroupDetailRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyComplianceGroupDetailResponse>(req, "DescribeDspmIdentifyComplianceGroupDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the dspm data identification template list
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyComplianceGroupListRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyComplianceGroupListResponse"/></returns>
        public Task<DescribeDspmIdentifyComplianceGroupListResponse> DescribeDspmIdentifyComplianceGroupList(DescribeDspmIdentifyComplianceGroupListRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyComplianceGroupListResponse>(req, "DescribeDspmIdentifyComplianceGroupList");
        }

        /// <summary>
        /// Queries the dspm data identification template list
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyComplianceGroupListRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyComplianceGroupListResponse"/></returns>
        public DescribeDspmIdentifyComplianceGroupListResponse DescribeDspmIdentifyComplianceGroupListSync(DescribeDspmIdentifyComplianceGroupListRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyComplianceGroupListResponse>(req, "DescribeDspmIdentifyComplianceGroupList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Querying dspm data identification distribution statistics
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyDistributionStatisticsRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyDistributionStatisticsResponse"/></returns>
        public Task<DescribeDspmIdentifyDistributionStatisticsResponse> DescribeDspmIdentifyDistributionStatistics(DescribeDspmIdentifyDistributionStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyDistributionStatisticsResponse>(req, "DescribeDspmIdentifyDistributionStatistics");
        }

        /// <summary>
        /// Querying dspm data identification distribution statistics
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyDistributionStatisticsRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyDistributionStatisticsResponse"/></returns>
        public DescribeDspmIdentifyDistributionStatisticsResponse DescribeDspmIdentifyDistributionStatisticsSync(DescribeDspmIdentifyDistributionStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyDistributionStatisticsResponse>(req, "DescribeDspmIdentifyDistributionStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the Dspm identity ID list.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyIdListRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyIdListResponse"/></returns>
        public Task<DescribeDspmIdentifyIdListResponse> DescribeDspmIdentifyIdList(DescribeDspmIdentifyIdListRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyIdListResponse>(req, "DescribeDspmIdentifyIdList");
        }

        /// <summary>
        /// Query the Dspm identity ID list.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyIdListRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyIdListResponse"/></returns>
        public DescribeDspmIdentifyIdListResponse DescribeDspmIdentifyIdListSync(DescribeDspmIdentifyIdListRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyIdListResponse>(req, "DescribeDspmIdentifyIdList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the Dspm identity information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyInfoRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyInfoResponse"/></returns>
        public Task<DescribeDspmIdentifyInfoResponse> DescribeDspmIdentifyInfo(DescribeDspmIdentifyInfoRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyInfoResponse>(req, "DescribeDspmIdentifyInfo");
        }

        /// <summary>
        /// Queries the Dspm identity information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyInfoRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyInfoResponse"/></returns>
        public DescribeDspmIdentifyInfoResponse DescribeDspmIdentifyInfoSync(DescribeDspmIdentifyInfoRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyInfoResponse>(req, "DescribeDspmIdentifyInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the Dspm identity information list
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyInfoListRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyInfoListResponse"/></returns>
        public Task<DescribeDspmIdentifyInfoListResponse> DescribeDspmIdentifyInfoList(DescribeDspmIdentifyInfoListRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyInfoListResponse>(req, "DescribeDspmIdentifyInfoList");
        }

        /// <summary>
        /// Query the Dspm identity information list
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyInfoListRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyInfoListResponse"/></returns>
        public DescribeDspmIdentifyInfoListResponse DescribeDspmIdentifyInfoListSync(DescribeDspmIdentifyInfoListRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyInfoListResponse>(req, "DescribeDspmIdentifyInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the dspm data identification classification group list
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyLevelGroupListRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyLevelGroupListResponse"/></returns>
        public Task<DescribeDspmIdentifyLevelGroupListResponse> DescribeDspmIdentifyLevelGroupList(DescribeDspmIdentifyLevelGroupListRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyLevelGroupListResponse>(req, "DescribeDspmIdentifyLevelGroupList");
        }

        /// <summary>
        /// Query the dspm data identification classification group list
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyLevelGroupListRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyLevelGroupListResponse"/></returns>
        public DescribeDspmIdentifyLevelGroupListResponse DescribeDspmIdentifyLevelGroupListSync(DescribeDspmIdentifyLevelGroupListRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyLevelGroupListResponse>(req, "DescribeDspmIdentifyLevelGroupList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the dspm data identification data item details
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyRuleDetailRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyRuleDetailResponse"/></returns>
        public Task<DescribeDspmIdentifyRuleDetailResponse> DescribeDspmIdentifyRuleDetail(DescribeDspmIdentifyRuleDetailRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyRuleDetailResponse>(req, "DescribeDspmIdentifyRuleDetail");
        }

        /// <summary>
        /// Queries the dspm data identification data item details
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyRuleDetailRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyRuleDetailResponse"/></returns>
        public DescribeDspmIdentifyRuleDetailResponse DescribeDspmIdentifyRuleDetailSync(DescribeDspmIdentifyRuleDetailRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyRuleDetailResponse>(req, "DescribeDspmIdentifyRuleDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the list of dspm identification data items.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyRuleListRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyRuleListResponse"/></returns>
        public Task<DescribeDspmIdentifyRuleListResponse> DescribeDspmIdentifyRuleList(DescribeDspmIdentifyRuleListRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyRuleListResponse>(req, "DescribeDspmIdentifyRuleList");
        }

        /// <summary>
        /// Query the list of dspm identification data items.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyRuleListRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyRuleListResponse"/></returns>
        public DescribeDspmIdentifyRuleListResponse DescribeDspmIdentifyRuleListSync(DescribeDspmIdentifyRuleListRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyRuleListResponse>(req, "DescribeDspmIdentifyRuleList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query verification results of dspm data identification data items.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyRuleTestResultRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyRuleTestResultResponse"/></returns>
        public Task<DescribeDspmIdentifyRuleTestResultResponse> DescribeDspmIdentifyRuleTestResult(DescribeDspmIdentifyRuleTestResultRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyRuleTestResultResponse>(req, "DescribeDspmIdentifyRuleTestResult");
        }

        /// <summary>
        /// This API is used to query verification results of dspm data identification data items.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyRuleTestResultRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyRuleTestResultResponse"/></returns>
        public DescribeDspmIdentifyRuleTestResultResponse DescribeDspmIdentifyRuleTestResultSync(DescribeDspmIdentifyRuleTestResultRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyRuleTestResultResponse>(req, "DescribeDspmIdentifyRuleTestResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the log type for log shipping.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmLogDeliveryTypeRequest"/></param>
        /// <returns><see cref="DescribeDspmLogDeliveryTypeResponse"/></returns>
        public Task<DescribeDspmLogDeliveryTypeResponse> DescribeDspmLogDeliveryType(DescribeDspmLogDeliveryTypeRequest req)
        {
            return InternalRequestAsync<DescribeDspmLogDeliveryTypeResponse>(req, "DescribeDspmLogDeliveryType");
        }

        /// <summary>
        /// This API is used to query the log type for log shipping.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmLogDeliveryTypeRequest"/></param>
        /// <returns><see cref="DescribeDspmLogDeliveryTypeResponse"/></returns>
        public DescribeDspmLogDeliveryTypeResponse DescribeDspmLogDeliveryTypeSync(DescribeDspmLogDeliveryTypeRequest req)
        {
            return InternalRequestAsync<DescribeDspmLogDeliveryTypeResponse>(req, "DescribeDspmLogDeliveryType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the log list information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmLogListRequest"/></param>
        /// <returns><see cref="DescribeDspmLogListResponse"/></returns>
        public Task<DescribeDspmLogListResponse> DescribeDspmLogList(DescribeDspmLogListRequest req)
        {
            return InternalRequestAsync<DescribeDspmLogListResponse>(req, "DescribeDspmLogList");
        }

        /// <summary>
        /// This API is used to query the log list information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmLogListRequest"/></param>
        /// <returns><see cref="DescribeDspmLogListResponse"/></returns>
        public DescribeDspmLogListResponse DescribeDspmLogListSync(DescribeDspmLogListRequest req)
        {
            return InternalRequestAsync<DescribeDspmLogListResponse>(req, "DescribeDspmLogList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the log shipping configuration of a tenant.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmLogTypeConfigListRequest"/></param>
        /// <returns><see cref="DescribeDspmLogTypeConfigListResponse"/></returns>
        public Task<DescribeDspmLogTypeConfigListResponse> DescribeDspmLogTypeConfigList(DescribeDspmLogTypeConfigListRequest req)
        {
            return InternalRequestAsync<DescribeDspmLogTypeConfigListResponse>(req, "DescribeDspmLogTypeConfigList");
        }

        /// <summary>
        /// This API is used to query the log shipping configuration of a tenant.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmLogTypeConfigListRequest"/></param>
        /// <returns><see cref="DescribeDspmLogTypeConfigListResponse"/></returns>
        public DescribeDspmLogTypeConfigListResponse DescribeDspmLogTypeConfigListSync(DescribeDspmLogTypeConfigListRequest req)
        {
            return InternalRequestAsync<DescribeDspmLogTypeConfigListResponse>(req, "DescribeDspmLogTypeConfigList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get purchased Dspm order information
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmPayInfoRequest"/></param>
        /// <returns><see cref="DescribeDspmPayInfoResponse"/></returns>
        public Task<DescribeDspmPayInfoResponse> DescribeDspmPayInfo(DescribeDspmPayInfoRequest req)
        {
            return InternalRequestAsync<DescribeDspmPayInfoResponse>(req, "DescribeDspmPayInfo");
        }

        /// <summary>
        /// Get purchased Dspm order information
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmPayInfoRequest"/></param>
        /// <returns><see cref="DescribeDspmPayInfoResponse"/></returns>
        public DescribeDspmPayInfoResponse DescribeDspmPayInfoSync(DescribeDspmPayInfoRequest req)
        {
            return InternalRequestAsync<DescribeDspmPayInfoResponse>(req, "DescribeDspmPayInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries Dspm visitor application records.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmPersonApplyHistoryRequest"/></param>
        /// <returns><see cref="DescribeDspmPersonApplyHistoryResponse"/></returns>
        public Task<DescribeDspmPersonApplyHistoryResponse> DescribeDspmPersonApplyHistory(DescribeDspmPersonApplyHistoryRequest req)
        {
            return InternalRequestAsync<DescribeDspmPersonApplyHistoryResponse>(req, "DescribeDspmPersonApplyHistory");
        }

        /// <summary>
        /// Queries Dspm visitor application records.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmPersonApplyHistoryRequest"/></param>
        /// <returns><see cref="DescribeDspmPersonApplyHistoryResponse"/></returns>
        public DescribeDspmPersonApplyHistoryResponse DescribeDspmPersonApplyHistorySync(DescribeDspmPersonApplyHistoryRequest req)
        {
            return InternalRequestAsync<DescribeDspmPersonApplyHistoryResponse>(req, "DescribeDspmPersonApplyHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the list of Dspm personal identification information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmPersonalIdentifyListRequest"/></param>
        /// <returns><see cref="DescribeDspmPersonalIdentifyListResponse"/></returns>
        public Task<DescribeDspmPersonalIdentifyListResponse> DescribeDspmPersonalIdentifyList(DescribeDspmPersonalIdentifyListRequest req)
        {
            return InternalRequestAsync<DescribeDspmPersonalIdentifyListResponse>(req, "DescribeDspmPersonalIdentifyList");
        }

        /// <summary>
        /// Query the list of Dspm personal identification information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmPersonalIdentifyListRequest"/></param>
        /// <returns><see cref="DescribeDspmPersonalIdentifyListResponse"/></returns>
        public DescribeDspmPersonalIdentifyListResponse DescribeDspmPersonalIdentifyListSync(DescribeDspmPersonalIdentifyListRequest req)
        {
            return InternalRequestAsync<DescribeDspmPersonalIdentifyListResponse>(req, "DescribeDspmPersonalIdentifyList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries Dspm instances
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmResourceRequest"/></param>
        /// <returns><see cref="DescribeDspmResourceResponse"/></returns>
        public Task<DescribeDspmResourceResponse> DescribeDspmResource(DescribeDspmResourceRequest req)
        {
            return InternalRequestAsync<DescribeDspmResourceResponse>(req, "DescribeDspmResource");
        }

        /// <summary>
        /// Queries Dspm instances
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmResourceRequest"/></param>
        /// <returns><see cref="DescribeDspmResourceResponse"/></returns>
        public DescribeDspmResourceResponse DescribeDspmResourceSync(DescribeDspmResourceRequest req)
        {
            return InternalRequestAsync<DescribeDspmResourceResponse>(req, "DescribeDspmResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries Dspm risk records
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmRiskRequest"/></param>
        /// <returns><see cref="DescribeDspmRiskResponse"/></returns>
        public Task<DescribeDspmRiskResponse> DescribeDspmRisk(DescribeDspmRiskRequest req)
        {
            return InternalRequestAsync<DescribeDspmRiskResponse>(req, "DescribeDspmRisk");
        }

        /// <summary>
        /// Queries Dspm risk records
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmRiskRequest"/></param>
        /// <returns><see cref="DescribeDspmRiskResponse"/></returns>
        public DescribeDspmRiskResponse DescribeDspmRiskSync(DescribeDspmRiskRequest req)
        {
            return InternalRequestAsync<DescribeDspmRiskResponse>(req, "DescribeDspmRisk")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries Dspm risk details
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmRiskDetailRequest"/></param>
        /// <returns><see cref="DescribeDspmRiskDetailResponse"/></returns>
        public Task<DescribeDspmRiskDetailResponse> DescribeDspmRiskDetail(DescribeDspmRiskDetailRequest req)
        {
            return InternalRequestAsync<DescribeDspmRiskDetailResponse>(req, "DescribeDspmRiskDetail");
        }

        /// <summary>
        /// Queries Dspm risk details
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmRiskDetailRequest"/></param>
        /// <returns><see cref="DescribeDspmRiskDetailResponse"/></returns>
        public DescribeDspmRiskDetailResponse DescribeDspmRiskDetailSync(DescribeDspmRiskDetailRequest req)
        {
            return InternalRequestAsync<DescribeDspmRiskDetailResponse>(req, "DescribeDspmRiskDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries Dspm risk policies
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmRiskStrategyRequest"/></param>
        /// <returns><see cref="DescribeDspmRiskStrategyResponse"/></returns>
        public Task<DescribeDspmRiskStrategyResponse> DescribeDspmRiskStrategy(DescribeDspmRiskStrategyRequest req)
        {
            return InternalRequestAsync<DescribeDspmRiskStrategyResponse>(req, "DescribeDspmRiskStrategy");
        }

        /// <summary>
        /// Queries Dspm risk policies
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmRiskStrategyRequest"/></param>
        /// <returns><see cref="DescribeDspmRiskStrategyResponse"/></returns>
        public DescribeDspmRiskStrategyResponse DescribeDspmRiskStrategySync(DescribeDspmRiskStrategyRequest req)
        {
            return InternalRequestAsync<DescribeDspmRiskStrategyResponse>(req, "DescribeDspmRiskStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query Dspm risk group policies
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmRiskStrategyGroupRequest"/></param>
        /// <returns><see cref="DescribeDspmRiskStrategyGroupResponse"/></returns>
        public Task<DescribeDspmRiskStrategyGroupResponse> DescribeDspmRiskStrategyGroup(DescribeDspmRiskStrategyGroupRequest req)
        {
            return InternalRequestAsync<DescribeDspmRiskStrategyGroupResponse>(req, "DescribeDspmRiskStrategyGroup");
        }

        /// <summary>
        /// Query Dspm risk group policies
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmRiskStrategyGroupRequest"/></param>
        /// <returns><see cref="DescribeDspmRiskStrategyGroupResponse"/></returns>
        public DescribeDspmRiskStrategyGroupResponse DescribeDspmRiskStrategyGroupSync(DescribeDspmRiskStrategyGroupRequest req)
        {
            return InternalRequestAsync<DescribeDspmRiskStrategyGroupResponse>(req, "DescribeDspmRiskStrategyGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query Dspm risk trends.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmRiskTendencyRequest"/></param>
        /// <returns><see cref="DescribeDspmRiskTendencyResponse"/></returns>
        public Task<DescribeDspmRiskTendencyResponse> DescribeDspmRiskTendency(DescribeDspmRiskTendencyRequest req)
        {
            return InternalRequestAsync<DescribeDspmRiskTendencyResponse>(req, "DescribeDspmRiskTendency");
        }

        /// <summary>
        /// Query Dspm risk trends.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmRiskTendencyRequest"/></param>
        /// <returns><see cref="DescribeDspmRiskTendencyResponse"/></returns>
        public DescribeDspmRiskTendencyResponse DescribeDspmRiskTendencySync(DescribeDspmRiskTendencyRequest req)
        {
            return InternalRequestAsync<DescribeDspmRiskTendencyResponse>(req, "DescribeDspmRiskTendency")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the audit session list information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmSessionListRequest"/></param>
        /// <returns><see cref="DescribeDspmSessionListResponse"/></returns>
        public Task<DescribeDspmSessionListResponse> DescribeDspmSessionList(DescribeDspmSessionListRequest req)
        {
            return InternalRequestAsync<DescribeDspmSessionListResponse>(req, "DescribeDspmSessionList");
        }

        /// <summary>
        /// This API is used to query the audit session list information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmSessionListRequest"/></param>
        /// <returns><see cref="DescribeDspmSessionListResponse"/></returns>
        public DescribeDspmSessionListResponse DescribeDspmSessionListSync(DescribeDspmSessionListRequest req)
        {
            return InternalRequestAsync<DescribeDspmSessionListResponse>(req, "DescribeDspmSessionList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query Dspm statistical information
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmStatisticsRequest"/></param>
        /// <returns><see cref="DescribeDspmStatisticsResponse"/></returns>
        public Task<DescribeDspmStatisticsResponse> DescribeDspmStatistics(DescribeDspmStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeDspmStatisticsResponse>(req, "DescribeDspmStatistics");
        }

        /// <summary>
        /// Query Dspm statistical information
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmStatisticsRequest"/></param>
        /// <returns><see cref="DescribeDspmStatisticsResponse"/></returns>
        public DescribeDspmStatisticsResponse DescribeDspmStatisticsSync(DescribeDspmStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeDspmStatisticsResponse>(req, "DescribeDspmStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries information on asset types supported by Dspm.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmSupportedAssetTypeRequest"/></param>
        /// <returns><see cref="DescribeDspmSupportedAssetTypeResponse"/></returns>
        public Task<DescribeDspmSupportedAssetTypeResponse> DescribeDspmSupportedAssetType(DescribeDspmSupportedAssetTypeRequest req)
        {
            return InternalRequestAsync<DescribeDspmSupportedAssetTypeResponse>(req, "DescribeDspmSupportedAssetType");
        }

        /// <summary>
        /// Queries information on asset types supported by Dspm.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmSupportedAssetTypeRequest"/></param>
        /// <returns><see cref="DescribeDspmSupportedAssetTypeResponse"/></returns>
        public DescribeDspmSupportedAssetTypeResponse DescribeDspmSupportedAssetTypeSync(DescribeDspmSupportedAssetTypeRequest req)
        {
            return InternalRequestAsync<DescribeDspmSupportedAssetTypeResponse>(req, "DescribeDspmSupportedAssetType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the Dspm asset status synchronization.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmSyncAssetsStatusRequest"/></param>
        /// <returns><see cref="DescribeDspmSyncAssetsStatusResponse"/></returns>
        public Task<DescribeDspmSyncAssetsStatusResponse> DescribeDspmSyncAssetsStatus(DescribeDspmSyncAssetsStatusRequest req)
        {
            return InternalRequestAsync<DescribeDspmSyncAssetsStatusResponse>(req, "DescribeDspmSyncAssetsStatus");
        }

        /// <summary>
        /// Query the Dspm asset status synchronization.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmSyncAssetsStatusRequest"/></param>
        /// <returns><see cref="DescribeDspmSyncAssetsStatusResponse"/></returns>
        public DescribeDspmSyncAssetsStatusResponse DescribeDspmSyncAssetsStatusSync(DescribeDspmSyncAssetsStatusRequest req)
        {
            return InternalRequestAsync<DescribeDspmSyncAssetsStatusResponse>(req, "DescribeDspmSyncAssetsStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the Dspm user synchronization status.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmSyncUsersStatusRequest"/></param>
        /// <returns><see cref="DescribeDspmSyncUsersStatusResponse"/></returns>
        public Task<DescribeDspmSyncUsersStatusResponse> DescribeDspmSyncUsersStatus(DescribeDspmSyncUsersStatusRequest req)
        {
            return InternalRequestAsync<DescribeDspmSyncUsersStatusResponse>(req, "DescribeDspmSyncUsersStatus");
        }

        /// <summary>
        /// Query the Dspm user synchronization status.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmSyncUsersStatusRequest"/></param>
        /// <returns><see cref="DescribeDspmSyncUsersStatusResponse"/></returns>
        public DescribeDspmSyncUsersStatusResponse DescribeDspmSyncUsersStatusSync(DescribeDspmSyncUsersStatusRequest req)
        {
            return InternalRequestAsync<DescribeDspmSyncUsersStatusResponse>(req, "DescribeDspmSyncUsersStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the tenant CKafka instance list.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmUserCkafkaInstanceListRequest"/></param>
        /// <returns><see cref="DescribeDspmUserCkafkaInstanceListResponse"/></returns>
        public Task<DescribeDspmUserCkafkaInstanceListResponse> DescribeDspmUserCkafkaInstanceList(DescribeDspmUserCkafkaInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeDspmUserCkafkaInstanceListResponse>(req, "DescribeDspmUserCkafkaInstanceList");
        }

        /// <summary>
        /// This API is used to query the tenant CKafka instance list.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmUserCkafkaInstanceListRequest"/></param>
        /// <returns><see cref="DescribeDspmUserCkafkaInstanceListResponse"/></returns>
        public DescribeDspmUserCkafkaInstanceListResponse DescribeDspmUserCkafkaInstanceListSync(DescribeDspmUserCkafkaInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeDspmUserCkafkaInstanceListResponse>(req, "DescribeDspmUserCkafkaInstanceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the Dspm allowlist policy.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmWhitelistStrategyRequest"/></param>
        /// <returns><see cref="DescribeDspmWhitelistStrategyResponse"/></returns>
        public Task<DescribeDspmWhitelistStrategyResponse> DescribeDspmWhitelistStrategy(DescribeDspmWhitelistStrategyRequest req)
        {
            return InternalRequestAsync<DescribeDspmWhitelistStrategyResponse>(req, "DescribeDspmWhitelistStrategy");
        }

        /// <summary>
        /// Query the Dspm allowlist policy.
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmWhitelistStrategyRequest"/></param>
        /// <returns><see cref="DescribeDspmWhitelistStrategyResponse"/></returns>
        public DescribeDspmWhitelistStrategyResponse DescribeDspmWhitelistStrategySync(DescribeDspmWhitelistStrategyRequest req)
        {
            return InternalRequestAsync<DescribeDspmWhitelistStrategyResponse>(req, "DescribeDspmWhitelistStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// List of specified asset types
        /// </summary>
        /// <param name="req"><see cref="DescribeDynamicAssetsRequest"/></param>
        /// <returns><see cref="DescribeDynamicAssetsResponse"/></returns>
        public Task<DescribeDynamicAssetsResponse> DescribeDynamicAssets(DescribeDynamicAssetsRequest req)
        {
            return InternalRequestAsync<DescribeDynamicAssetsResponse>(req, "DescribeDynamicAssets");
        }

        /// <summary>
        /// List of specified asset types
        /// </summary>
        /// <param name="req"><see cref="DescribeDynamicAssetsRequest"/></param>
        /// <returns><see cref="DescribeDynamicAssetsResponse"/></returns>
        public DescribeDynamicAssetsResponse DescribeDynamicAssetsSync(DescribeDynamicAssetsRequest req)
        {
            return InternalRequestAsync<DescribeDynamicAssetsResponse>(req, "DescribeDynamicAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of EDR policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeEDRRuleListRequest"/></param>
        /// <returns><see cref="DescribeEDRRuleListResponse"/></returns>
        public Task<DescribeEDRRuleListResponse> DescribeEDRRuleList(DescribeEDRRuleListRequest req)
        {
            return InternalRequestAsync<DescribeEDRRuleListResponse>(req, "DescribeEDRRuleList");
        }

        /// <summary>
        /// This API is used to obtain the list of EDR policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeEDRRuleListRequest"/></param>
        /// <returns><see cref="DescribeEDRRuleListResponse"/></returns>
        public DescribeEDRRuleListResponse DescribeEDRRuleListSync(DescribeEDRRuleListRequest req)
        {
            return InternalRequestAsync<DescribeEDRRuleListResponse>(req, "DescribeEDRRuleList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the scan task list. Filter.Filters supports Name: Keyword (blurry, OperatorType=9), ScanType (MANUAL/CYCLE), TaskType (HOST/CONTAINER), Status (WAIT/SCANNING/FINISHED/FAILED/CANCELED), AppId (account).
        /// </summary>
        /// <param name="req"><see cref="DescribeEDRScanRecordListRequest"/></param>
        /// <returns><see cref="DescribeEDRScanRecordListResponse"/></returns>
        public Task<DescribeEDRScanRecordListResponse> DescribeEDRScanRecordList(DescribeEDRScanRecordListRequest req)
        {
            return InternalRequestAsync<DescribeEDRScanRecordListResponse>(req, "DescribeEDRScanRecordList");
        }

        /// <summary>
        /// This API is used to query the scan task list. Filter.Filters supports Name: Keyword (blurry, OperatorType=9), ScanType (MANUAL/CYCLE), TaskType (HOST/CONTAINER), Status (WAIT/SCANNING/FINISHED/FAILED/CANCELED), AppId (account).
        /// </summary>
        /// <param name="req"><see cref="DescribeEDRScanRecordListRequest"/></param>
        /// <returns><see cref="DescribeEDRScanRecordListResponse"/></returns>
        public DescribeEDRScanRecordListResponse DescribeEDRScanRecordListSync(DescribeEDRScanRecordListRequest req)
        {
            return InternalRequestAsync<DescribeEDRScanRecordListResponse>(req, "DescribeEDRScanRecordList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query scan task details. Filter.Filters supports Name: Status (asset scan status, OperatorType=7 IN match, Value: WAIT/SCANNING/FINISHED/FAILED).
        /// </summary>
        /// <param name="req"><see cref="DescribeEDRScanTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeEDRScanTaskDetailResponse"/></returns>
        public Task<DescribeEDRScanTaskDetailResponse> DescribeEDRScanTaskDetail(DescribeEDRScanTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeEDRScanTaskDetailResponse>(req, "DescribeEDRScanTaskDetail");
        }

        /// <summary>
        /// Query scan task details. Filter.Filters supports Name: Status (asset scan status, OperatorType=7 IN match, Value: WAIT/SCANNING/FINISHED/FAILED).
        /// </summary>
        /// <param name="req"><see cref="DescribeEDRScanTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeEDRScanTaskDetailResponse"/></returns>
        public DescribeEDRScanTaskDetailResponse DescribeEDRScanTaskDetailSync(DescribeEDRScanTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeEDRScanTaskDetailResponse>(req, "DescribeEDRScanTaskDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain EDR alarm quantity statistics for the asset module. It queries the EDR alarm table based on the passed-in MemberId and InstanceIDs and returns the number of alarm records. If InstanceIDs is empty, summarized statistics are returned. Otherwise, statistics are returned by InstanceID granularity.
        /// </summary>
        /// <param name="req"><see cref="DescribeEdrAlertCountForAssetRequest"/></param>
        /// <returns><see cref="DescribeEdrAlertCountForAssetResponse"/></returns>
        public Task<DescribeEdrAlertCountForAssetResponse> DescribeEdrAlertCountForAsset(DescribeEdrAlertCountForAssetRequest req)
        {
            return InternalRequestAsync<DescribeEdrAlertCountForAssetResponse>(req, "DescribeEdrAlertCountForAsset");
        }

        /// <summary>
        /// This API is used to obtain EDR alarm quantity statistics for the asset module. It queries the EDR alarm table based on the passed-in MemberId and InstanceIDs and returns the number of alarm records. If InstanceIDs is empty, summarized statistics are returned. Otherwise, statistics are returned by InstanceID granularity.
        /// </summary>
        /// <param name="req"><see cref="DescribeEdrAlertCountForAssetRequest"/></param>
        /// <returns><see cref="DescribeEdrAlertCountForAssetResponse"/></returns>
        public DescribeEdrAlertCountForAssetResponse DescribeEdrAlertCountForAssetSync(DescribeEdrAlertCountForAssetRequest req)
        {
            return InternalRequestAsync<DescribeEdrAlertCountForAssetResponse>(req, "DescribeEdrAlertCountForAsset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Alarm quantity statistics in the container scenario.
        /// </summary>
        /// <param name="req"><see cref="DescribeEdrAlertCountForContainerRequest"/></param>
        /// <returns><see cref="DescribeEdrAlertCountForContainerResponse"/></returns>
        public Task<DescribeEdrAlertCountForContainerResponse> DescribeEdrAlertCountForContainer(DescribeEdrAlertCountForContainerRequest req)
        {
            return InternalRequestAsync<DescribeEdrAlertCountForContainerResponse>(req, "DescribeEdrAlertCountForContainer");
        }

        /// <summary>
        /// Alarm quantity statistics in the container scenario.
        /// </summary>
        /// <param name="req"><see cref="DescribeEdrAlertCountForContainerRequest"/></param>
        /// <returns><see cref="DescribeEdrAlertCountForContainerResponse"/></returns>
        public DescribeEdrAlertCountForContainerResponse DescribeEdrAlertCountForContainerSync(DescribeEdrAlertCountForContainerRequest req)
        {
            return InternalRequestAsync<DescribeEdrAlertCountForContainerResponse>(req, "DescribeEdrAlertCountForContainer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain EDR alert details, including complete information such as alert content JSON, asset enrichment, and intelligence enrichment.
        /// </summary>
        /// <param name="req"><see cref="DescribeEdrAlertInfoRequest"/></param>
        /// <returns><see cref="DescribeEdrAlertInfoResponse"/></returns>
        public Task<DescribeEdrAlertInfoResponse> DescribeEdrAlertInfo(DescribeEdrAlertInfoRequest req)
        {
            return InternalRequestAsync<DescribeEdrAlertInfoResponse>(req, "DescribeEdrAlertInfo");
        }

        /// <summary>
        /// This API is used to obtain EDR alert details, including complete information such as alert content JSON, asset enrichment, and intelligence enrichment.
        /// </summary>
        /// <param name="req"><see cref="DescribeEdrAlertInfoRequest"/></param>
        /// <returns><see cref="DescribeEdrAlertInfoResponse"/></returns>
        public DescribeEdrAlertInfoResponse DescribeEdrAlertInfoSync(DescribeEdrAlertInfoRequest req)
        {
            return InternalRequestAsync<DescribeEdrAlertInfoResponse>(req, "DescribeEdrAlertInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the EDR alarm list.
        /// </summary>
        /// <param name="req"><see cref="DescribeEdrAlertListRequest"/></param>
        /// <returns><see cref="DescribeEdrAlertListResponse"/></returns>
        public Task<DescribeEdrAlertListResponse> DescribeEdrAlertList(DescribeEdrAlertListRequest req)
        {
            return InternalRequestAsync<DescribeEdrAlertListResponse>(req, "DescribeEdrAlertList");
        }

        /// <summary>
        /// Query the EDR alarm list.
        /// </summary>
        /// <param name="req"><see cref="DescribeEdrAlertListRequest"/></param>
        /// <returns><see cref="DescribeEdrAlertListResponse"/></returns>
        public DescribeEdrAlertListResponse DescribeEdrAlertListSync(DescribeEdrAlertListRequest req)
        {
            return InternalRequestAsync<DescribeEdrAlertListResponse>(req, "DescribeEdrAlertList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// EDR alert multi-attack stage queries
        /// </summary>
        /// <param name="req"><see cref="DescribeEdrAlertMultiAttackStagesRequest"/></param>
        /// <returns><see cref="DescribeEdrAlertMultiAttackStagesResponse"/></returns>
        public Task<DescribeEdrAlertMultiAttackStagesResponse> DescribeEdrAlertMultiAttackStages(DescribeEdrAlertMultiAttackStagesRequest req)
        {
            return InternalRequestAsync<DescribeEdrAlertMultiAttackStagesResponse>(req, "DescribeEdrAlertMultiAttackStages");
        }

        /// <summary>
        /// EDR alert multi-attack stage queries
        /// </summary>
        /// <param name="req"><see cref="DescribeEdrAlertMultiAttackStagesRequest"/></param>
        /// <returns><see cref="DescribeEdrAlertMultiAttackStagesResponse"/></returns>
        public DescribeEdrAlertMultiAttackStagesResponse DescribeEdrAlertMultiAttackStagesSync(DescribeEdrAlertMultiAttackStagesRequest req)
        {
            return InternalRequestAsync<DescribeEdrAlertMultiAttackStagesResponse>(req, "DescribeEdrAlertMultiAttackStages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retrieves EDR alarm statistics
        /// </summary>
        /// <param name="req"><see cref="DescribeEdrAlertSummaryRequest"/></param>
        /// <returns><see cref="DescribeEdrAlertSummaryResponse"/></returns>
        public Task<DescribeEdrAlertSummaryResponse> DescribeEdrAlertSummary(DescribeEdrAlertSummaryRequest req)
        {
            return InternalRequestAsync<DescribeEdrAlertSummaryResponse>(req, "DescribeEdrAlertSummary");
        }

        /// <summary>
        /// Retrieves EDR alarm statistics
        /// </summary>
        /// <param name="req"><see cref="DescribeEdrAlertSummaryRequest"/></param>
        /// <returns><see cref="DescribeEdrAlertSummaryResponse"/></returns>
        public DescribeEdrAlertSummaryResponse DescribeEdrAlertSummarySync(DescribeEdrAlertSummaryRequest req)
        {
            return InternalRequestAsync<DescribeEdrAlertSummaryResponse>(req, "DescribeEdrAlertSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query EDR alarm tags in batches.
        /// </summary>
        /// <param name="req"><see cref="DescribeEdrAlertThreatTagsRequest"/></param>
        /// <returns><see cref="DescribeEdrAlertThreatTagsResponse"/></returns>
        public Task<DescribeEdrAlertThreatTagsResponse> DescribeEdrAlertThreatTags(DescribeEdrAlertThreatTagsRequest req)
        {
            return InternalRequestAsync<DescribeEdrAlertThreatTagsResponse>(req, "DescribeEdrAlertThreatTags");
        }

        /// <summary>
        /// This API is used to query EDR alarm tags in batches.
        /// </summary>
        /// <param name="req"><see cref="DescribeEdrAlertThreatTagsRequest"/></param>
        /// <returns><see cref="DescribeEdrAlertThreatTagsResponse"/></returns>
        public DescribeEdrAlertThreatTagsResponse DescribeEdrAlertThreatTagsSync(DescribeEdrAlertThreatTagsRequest req)
        {
            return InternalRequestAsync<DescribeEdrAlertThreatTagsResponse>(req, "DescribeEdrAlertThreatTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the exclusion network segment configurations for EDR log collection. TCP logs from network segments in the exclusion list will not be collected. If no user configuration exists, the system-recommended default network segments will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeEdrExcludeNetworkSegmentsRequest"/></param>
        /// <returns><see cref="DescribeEdrExcludeNetworkSegmentsResponse"/></returns>
        public Task<DescribeEdrExcludeNetworkSegmentsResponse> DescribeEdrExcludeNetworkSegments(DescribeEdrExcludeNetworkSegmentsRequest req)
        {
            return InternalRequestAsync<DescribeEdrExcludeNetworkSegmentsResponse>(req, "DescribeEdrExcludeNetworkSegments");
        }

        /// <summary>
        /// This API is used to query the exclusion network segment configurations for EDR log collection. TCP logs from network segments in the exclusion list will not be collected. If no user configuration exists, the system-recommended default network segments will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeEdrExcludeNetworkSegmentsRequest"/></param>
        /// <returns><see cref="DescribeEdrExcludeNetworkSegmentsResponse"/></returns>
        public DescribeEdrExcludeNetworkSegmentsResponse DescribeEdrExcludeNetworkSegmentsSync(DescribeEdrExcludeNetworkSegmentsRequest req)
        {
            return InternalRequestAsync<DescribeEdrExcludeNetworkSegmentsResponse>(req, "DescribeEdrExcludeNetworkSegments")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the EDR export download link
        /// </summary>
        /// <param name="req"><see cref="DescribeEdrExportJobDownloadURLRequest"/></param>
        /// <returns><see cref="DescribeEdrExportJobDownloadURLResponse"/></returns>
        public Task<DescribeEdrExportJobDownloadURLResponse> DescribeEdrExportJobDownloadURL(DescribeEdrExportJobDownloadURLRequest req)
        {
            return InternalRequestAsync<DescribeEdrExportJobDownloadURLResponse>(req, "DescribeEdrExportJobDownloadURL");
        }

        /// <summary>
        /// Query the EDR export download link
        /// </summary>
        /// <param name="req"><see cref="DescribeEdrExportJobDownloadURLRequest"/></param>
        /// <returns><see cref="DescribeEdrExportJobDownloadURLResponse"/></returns>
        public DescribeEdrExportJobDownloadURLResponse DescribeEdrExportJobDownloadURLSync(DescribeEdrExportJobDownloadURLRequest req)
        {
            return InternalRequestAsync<DescribeEdrExportJobDownloadURLResponse>(req, "DescribeEdrExportJobDownloadURL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Export the EDR task list.
        /// </summary>
        /// <param name="req"><see cref="DescribeEdrExportJobListRequest"/></param>
        /// <returns><see cref="DescribeEdrExportJobListResponse"/></returns>
        public Task<DescribeEdrExportJobListResponse> DescribeEdrExportJobList(DescribeEdrExportJobListRequest req)
        {
            return InternalRequestAsync<DescribeEdrExportJobListResponse>(req, "DescribeEdrExportJobList");
        }

        /// <summary>
        /// Export the EDR task list.
        /// </summary>
        /// <param name="req"><see cref="DescribeEdrExportJobListRequest"/></param>
        /// <returns><see cref="DescribeEdrExportJobListResponse"/></returns>
        public DescribeEdrExportJobListResponse DescribeEdrExportJobListSync(DescribeEdrExportJobListRequest req)
        {
            return InternalRequestAsync<DescribeEdrExportJobListResponse>(req, "DescribeEdrExportJobList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the collection path configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeEdrLogCollectPathsRequest"/></param>
        /// <returns><see cref="DescribeEdrLogCollectPathsResponse"/></returns>
        public Task<DescribeEdrLogCollectPathsResponse> DescribeEdrLogCollectPaths(DescribeEdrLogCollectPathsRequest req)
        {
            return InternalRequestAsync<DescribeEdrLogCollectPathsResponse>(req, "DescribeEdrLogCollectPaths");
        }

        /// <summary>
        /// This API is used to query the collection path configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeEdrLogCollectPathsRequest"/></param>
        /// <returns><see cref="DescribeEdrLogCollectPathsResponse"/></returns>
        public DescribeEdrLogCollectPathsResponse DescribeEdrLogCollectPathsSync(DescribeEdrLogCollectPathsRequest req)
        {
            return InternalRequestAsync<DescribeEdrLogCollectPathsResponse>(req, "DescribeEdrLogCollectPaths")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Result download URL of an export task
        /// </summary>
        /// <param name="req"><see cref="DescribeExportJobDownloadURLRequest"/></param>
        /// <returns><see cref="DescribeExportJobDownloadURLResponse"/></returns>
        public Task<DescribeExportJobDownloadURLResponse> DescribeExportJobDownloadURL(DescribeExportJobDownloadURLRequest req)
        {
            return InternalRequestAsync<DescribeExportJobDownloadURLResponse>(req, "DescribeExportJobDownloadURL");
        }

        /// <summary>
        /// Result download URL of an export task
        /// </summary>
        /// <param name="req"><see cref="DescribeExportJobDownloadURLRequest"/></param>
        /// <returns><see cref="DescribeExportJobDownloadURLResponse"/></returns>
        public DescribeExportJobDownloadURLResponse DescribeExportJobDownloadURLSync(DescribeExportJobDownloadURLRequest req)
        {
            return InternalRequestAsync<DescribeExportJobDownloadURLResponse>(req, "DescribeExportJobDownloadURL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Exports the task list
        /// </summary>
        /// <param name="req"><see cref="DescribeExportJobManageListRequest"/></param>
        /// <returns><see cref="DescribeExportJobManageListResponse"/></returns>
        public Task<DescribeExportJobManageListResponse> DescribeExportJobManageList(DescribeExportJobManageListRequest req)
        {
            return InternalRequestAsync<DescribeExportJobManageListResponse>(req, "DescribeExportJobManageList");
        }

        /// <summary>
        /// Exports the task list
        /// </summary>
        /// <param name="req"><see cref="DescribeExportJobManageListRequest"/></param>
        /// <returns><see cref="DescribeExportJobManageListResponse"/></returns>
        public DescribeExportJobManageListResponse DescribeExportJobManageListSync(DescribeExportJobManageListRequest req)
        {
            return InternalRequestAsync<DescribeExportJobManageListResponse>(req, "DescribeExportJobManageList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Cloud boundary analysis asset category
        /// </summary>
        /// <param name="req"><see cref="DescribeExposeAssetCategoryRequest"/></param>
        /// <returns><see cref="DescribeExposeAssetCategoryResponse"/></returns>
        public Task<DescribeExposeAssetCategoryResponse> DescribeExposeAssetCategory(DescribeExposeAssetCategoryRequest req)
        {
            return InternalRequestAsync<DescribeExposeAssetCategoryResponse>(req, "DescribeExposeAssetCategory");
        }

        /// <summary>
        /// Cloud boundary analysis asset category
        /// </summary>
        /// <param name="req"><see cref="DescribeExposeAssetCategoryRequest"/></param>
        /// <returns><see cref="DescribeExposeAssetCategoryResponse"/></returns>
        public DescribeExposeAssetCategoryResponse DescribeExposeAssetCategorySync(DescribeExposeAssetCategoryRequest req)
        {
            return InternalRequestAsync<DescribeExposeAssetCategoryResponse>(req, "DescribeExposeAssetCategory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the cloud boundary analysis path node
        /// </summary>
        /// <param name="req"><see cref="DescribeExposePathRequest"/></param>
        /// <returns><see cref="DescribeExposePathResponse"/></returns>
        public Task<DescribeExposePathResponse> DescribeExposePath(DescribeExposePathRequest req)
        {
            return InternalRequestAsync<DescribeExposePathResponse>(req, "DescribeExposePath");
        }

        /// <summary>
        /// Query the cloud boundary analysis path node
        /// </summary>
        /// <param name="req"><see cref="DescribeExposePathRequest"/></param>
        /// <returns><see cref="DescribeExposePathResponse"/></returns>
        public DescribeExposePathResponse DescribeExposePathSync(DescribeExposePathRequest req)
        {
            return InternalRequestAsync<DescribeExposePathResponse>(req, "DescribeExposePath")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Pending risks to be governed for cloud boundaries
        /// </summary>
        /// <param name="req"><see cref="DescribeExposeRiskStatisticsRequest"/></param>
        /// <returns><see cref="DescribeExposeRiskStatisticsResponse"/></returns>
        public Task<DescribeExposeRiskStatisticsResponse> DescribeExposeRiskStatistics(DescribeExposeRiskStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeExposeRiskStatisticsResponse>(req, "DescribeExposeRiskStatistics");
        }

        /// <summary>
        /// Pending risks to be governed for cloud boundaries
        /// </summary>
        /// <param name="req"><see cref="DescribeExposeRiskStatisticsRequest"/></param>
        /// <returns><see cref="DescribeExposeRiskStatisticsResponse"/></returns>
        public DescribeExposeRiskStatisticsResponse DescribeExposeRiskStatisticsSync(DescribeExposeRiskStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeExposeRiskStatisticsResponse>(req, "DescribeExposeRiskStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// List of pending risks in cloud boundaries
        /// </summary>
        /// <param name="req"><see cref="DescribeExposeRisksRequest"/></param>
        /// <returns><see cref="DescribeExposeRisksResponse"/></returns>
        public Task<DescribeExposeRisksResponse> DescribeExposeRisks(DescribeExposeRisksRequest req)
        {
            return InternalRequestAsync<DescribeExposeRisksResponse>(req, "DescribeExposeRisks");
        }

        /// <summary>
        /// List of pending risks in cloud boundaries
        /// </summary>
        /// <param name="req"><see cref="DescribeExposeRisksRequest"/></param>
        /// <returns><see cref="DescribeExposeRisksResponse"/></returns>
        public DescribeExposeRisksResponse DescribeExposeRisksSync(DescribeExposeRisksRequest req)
        {
            return InternalRequestAsync<DescribeExposeRisksResponse>(req, "DescribeExposeRisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// List of boundary rules
        /// </summary>
        /// <param name="req"><see cref="DescribeExposeRulesRequest"/></param>
        /// <returns><see cref="DescribeExposeRulesResponse"/></returns>
        public Task<DescribeExposeRulesResponse> DescribeExposeRules(DescribeExposeRulesRequest req)
        {
            return InternalRequestAsync<DescribeExposeRulesResponse>(req, "DescribeExposeRules");
        }

        /// <summary>
        /// List of boundary rules
        /// </summary>
        /// <param name="req"><see cref="DescribeExposeRulesRequest"/></param>
        /// <returns><see cref="DescribeExposeRulesResponse"/></returns>
        public DescribeExposeRulesResponse DescribeExposeRulesSync(DescribeExposeRulesRequest req)
        {
            return InternalRequestAsync<DescribeExposeRulesResponse>(req, "DescribeExposeRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Rule attributes for automatic tagging at cloud boundaries
        /// </summary>
        /// <param name="req"><see cref="DescribeExposureAutoTagAttributeRequest"/></param>
        /// <returns><see cref="DescribeExposureAutoTagAttributeResponse"/></returns>
        public Task<DescribeExposureAutoTagAttributeResponse> DescribeExposureAutoTagAttribute(DescribeExposureAutoTagAttributeRequest req)
        {
            return InternalRequestAsync<DescribeExposureAutoTagAttributeResponse>(req, "DescribeExposureAutoTagAttribute");
        }

        /// <summary>
        /// Rule attributes for automatic tagging at cloud boundaries
        /// </summary>
        /// <param name="req"><see cref="DescribeExposureAutoTagAttributeRequest"/></param>
        /// <returns><see cref="DescribeExposureAutoTagAttributeResponse"/></returns>
        public DescribeExposureAutoTagAttributeResponse DescribeExposureAutoTagAttributeSync(DescribeExposureAutoTagAttributeRequest req)
        {
            return InternalRequestAsync<DescribeExposureAutoTagAttributeResponse>(req, "DescribeExposureAutoTagAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Automatic tagging of cloud boundaries - rule list
        /// </summary>
        /// <param name="req"><see cref="DescribeExposureAutoTagRulesRequest"/></param>
        /// <returns><see cref="DescribeExposureAutoTagRulesResponse"/></returns>
        public Task<DescribeExposureAutoTagRulesResponse> DescribeExposureAutoTagRules(DescribeExposureAutoTagRulesRequest req)
        {
            return InternalRequestAsync<DescribeExposureAutoTagRulesResponse>(req, "DescribeExposureAutoTagRules");
        }

        /// <summary>
        /// Automatic tagging of cloud boundaries - rule list
        /// </summary>
        /// <param name="req"><see cref="DescribeExposureAutoTagRulesRequest"/></param>
        /// <returns><see cref="DescribeExposureAutoTagRulesResponse"/></returns>
        public DescribeExposureAutoTagRulesResponse DescribeExposureAutoTagRulesSync(DescribeExposureAutoTagRulesRequest req)
        {
            return InternalRequestAsync<DescribeExposureAutoTagRulesResponse>(req, "DescribeExposureAutoTagRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query Internet exposure cycle count trend statistics.
        /// </summary>
        /// <param name="req"><see cref="DescribeExposureTrendRequest"/></param>
        /// <returns><see cref="DescribeExposureTrendResponse"/></returns>
        public Task<DescribeExposureTrendResponse> DescribeExposureTrend(DescribeExposureTrendRequest req)
        {
            return InternalRequestAsync<DescribeExposureTrendResponse>(req, "DescribeExposureTrend");
        }

        /// <summary>
        /// Query Internet exposure cycle count trend statistics.
        /// </summary>
        /// <param name="req"><see cref="DescribeExposureTrendRequest"/></param>
        /// <returns><see cref="DescribeExposureTrendResponse"/></returns>
        public DescribeExposureTrendResponse DescribeExposureTrendSync(DescribeExposureTrendRequest req)
        {
            return InternalRequestAsync<DescribeExposureTrendResponse>(req, "DescribeExposureTrend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Cloud boundary analysis asset list
        /// </summary>
        /// <param name="req"><see cref="DescribeExposuresRequest"/></param>
        /// <returns><see cref="DescribeExposuresResponse"/></returns>
        public Task<DescribeExposuresResponse> DescribeExposures(DescribeExposuresRequest req)
        {
            return InternalRequestAsync<DescribeExposuresResponse>(req, "DescribeExposures");
        }

        /// <summary>
        /// Cloud boundary analysis asset list
        /// </summary>
        /// <param name="req"><see cref="DescribeExposuresRequest"/></param>
        /// <returns><see cref="DescribeExposuresResponse"/></returns>
        public DescribeExposuresResponse DescribeExposuresSync(DescribeExposuresRequest req)
        {
            return InternalRequestAsync<DescribeExposuresResponse>(req, "DescribeExposures")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain Gateway List
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayAssetsRequest"/></param>
        /// <returns><see cref="DescribeGatewayAssetsResponse"/></returns>
        public Task<DescribeGatewayAssetsResponse> DescribeGatewayAssets(DescribeGatewayAssetsRequest req)
        {
            return InternalRequestAsync<DescribeGatewayAssetsResponse>(req, "DescribeGatewayAssets");
        }

        /// <summary>
        /// Obtain Gateway List
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayAssetsRequest"/></param>
        /// <returns><see cref="DescribeGatewayAssetsResponse"/></returns>
        public DescribeGatewayAssetsResponse DescribeGatewayAssetsSync(DescribeGatewayAssetsRequest req)
        {
            return InternalRequestAsync<DescribeGatewayAssetsResponse>(req, "DescribeGatewayAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the high-risk baseline risk list of host nodes under the cloud boundary analysis exposed path.
        /// </summary>
        /// <param name="req"><see cref="DescribeHighBaseLineRiskListRequest"/></param>
        /// <returns><see cref="DescribeHighBaseLineRiskListResponse"/></returns>
        public Task<DescribeHighBaseLineRiskListResponse> DescribeHighBaseLineRiskList(DescribeHighBaseLineRiskListRequest req)
        {
            return InternalRequestAsync<DescribeHighBaseLineRiskListResponse>(req, "DescribeHighBaseLineRiskList");
        }

        /// <summary>
        /// Query the high-risk baseline risk list of host nodes under the cloud boundary analysis exposed path.
        /// </summary>
        /// <param name="req"><see cref="DescribeHighBaseLineRiskListRequest"/></param>
        /// <returns><see cref="DescribeHighBaseLineRiskListResponse"/></returns>
        public DescribeHighBaseLineRiskListResponse DescribeHighBaseLineRiskListSync(DescribeHighBaseLineRiskListRequest req)
        {
            return InternalRequestAsync<DescribeHighBaseLineRiskListResponse>(req, "DescribeHighBaseLineRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Search the host kb risk list.
        /// </summary>
        /// <param name="req"><see cref="DescribeHostKBRiskListRequest"/></param>
        /// <returns><see cref="DescribeHostKBRiskListResponse"/></returns>
        public Task<DescribeHostKBRiskListResponse> DescribeHostKBRiskList(DescribeHostKBRiskListRequest req)
        {
            return InternalRequestAsync<DescribeHostKBRiskListResponse>(req, "DescribeHostKBRiskList");
        }

        /// <summary>
        /// Search the host kb risk list.
        /// </summary>
        /// <param name="req"><see cref="DescribeHostKBRiskListRequest"/></param>
        /// <returns><see cref="DescribeHostKBRiskListResponse"/></returns>
        public DescribeHostKBRiskListResponse DescribeHostKBRiskListSync(DescribeHostKBRiskListRequest req)
        {
            return InternalRequestAsync<DescribeHostKBRiskListResponse>(req, "DescribeHostKBRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain host vulnerability VPR information.
        /// </summary>
        /// <param name="req"><see cref="DescribeHostVulItemVPRInfoRequest"/></param>
        /// <returns><see cref="DescribeHostVulItemVPRInfoResponse"/></returns>
        public Task<DescribeHostVulItemVPRInfoResponse> DescribeHostVulItemVPRInfo(DescribeHostVulItemVPRInfoRequest req)
        {
            return InternalRequestAsync<DescribeHostVulItemVPRInfoResponse>(req, "DescribeHostVulItemVPRInfo");
        }

        /// <summary>
        /// This API is used to obtain host vulnerability VPR information.
        /// </summary>
        /// <param name="req"><see cref="DescribeHostVulItemVPRInfoRequest"/></param>
        /// <returns><see cref="DescribeHostVulItemVPRInfoResponse"/></returns>
        public DescribeHostVulItemVPRInfoResponse DescribeHostVulItemVPRInfoSync(DescribeHostVulItemVPRInfoRequest req)
        {
            return InternalRequestAsync<DescribeHostVulItemVPRInfoResponse>(req, "DescribeHostVulItemVPRInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the host vulnerability overview.
        /// </summary>
        /// <param name="req"><see cref="DescribeHostVulOverviewRequest"/></param>
        /// <returns><see cref="DescribeHostVulOverviewResponse"/></returns>
        public Task<DescribeHostVulOverviewResponse> DescribeHostVulOverview(DescribeHostVulOverviewRequest req)
        {
            return InternalRequestAsync<DescribeHostVulOverviewResponse>(req, "DescribeHostVulOverview");
        }

        /// <summary>
        /// This API is used to obtain the host vulnerability overview.
        /// </summary>
        /// <param name="req"><see cref="DescribeHostVulOverviewRequest"/></param>
        /// <returns><see cref="DescribeHostVulOverviewResponse"/></returns>
        public DescribeHostVulOverviewResponse DescribeHostVulOverviewSync(DescribeHostVulOverviewRequest req)
        {
            return InternalRequestAsync<DescribeHostVulOverviewResponse>(req, "DescribeHostVulOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to retrieve the host vulnerability risk list.
        /// </summary>
        /// <param name="req"><see cref="DescribeHostVulRiskListRequest"/></param>
        /// <returns><see cref="DescribeHostVulRiskListResponse"/></returns>
        public Task<DescribeHostVulRiskListResponse> DescribeHostVulRiskList(DescribeHostVulRiskListRequest req)
        {
            return InternalRequestAsync<DescribeHostVulRiskListResponse>(req, "DescribeHostVulRiskList");
        }

        /// <summary>
        /// This API is used to retrieve the host vulnerability risk list.
        /// </summary>
        /// <param name="req"><see cref="DescribeHostVulRiskListRequest"/></param>
        /// <returns><see cref="DescribeHostVulRiskListResponse"/></returns>
        public DescribeHostVulRiskListResponse DescribeHostVulRiskListSync(DescribeHostVulRiskListRequest req)
        {
            return InternalRequestAsync<DescribeHostVulRiskListResponse>(req, "DescribeHostVulRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retrieve the IaC detection file list.
        /// </summary>
        /// <param name="req"><see cref="DescribeIaCFileListRequest"/></param>
        /// <returns><see cref="DescribeIaCFileListResponse"/></returns>
        public Task<DescribeIaCFileListResponse> DescribeIaCFileList(DescribeIaCFileListRequest req)
        {
            return InternalRequestAsync<DescribeIaCFileListResponse>(req, "DescribeIaCFileList");
        }

        /// <summary>
        /// Retrieve the IaC detection file list.
        /// </summary>
        /// <param name="req"><see cref="DescribeIaCFileListRequest"/></param>
        /// <returns><see cref="DescribeIaCFileListResponse"/></returns>
        public DescribeIaCFileListResponse DescribeIaCFileListSync(DescribeIaCFileListRequest req)
        {
            return InternalRequestAsync<DescribeIaCFileListResponse>(req, "DescribeIaCFileList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain the IaC detection file overview.
        /// </summary>
        /// <param name="req"><see cref="DescribeIaCFileOverviewRequest"/></param>
        /// <returns><see cref="DescribeIaCFileOverviewResponse"/></returns>
        public Task<DescribeIaCFileOverviewResponse> DescribeIaCFileOverview(DescribeIaCFileOverviewRequest req)
        {
            return InternalRequestAsync<DescribeIaCFileOverviewResponse>(req, "DescribeIaCFileOverview");
        }

        /// <summary>
        /// Obtain the IaC detection file overview.
        /// </summary>
        /// <param name="req"><see cref="DescribeIaCFileOverviewRequest"/></param>
        /// <returns><see cref="DescribeIaCFileOverviewResponse"/></returns>
        public DescribeIaCFileOverviewResponse DescribeIaCFileOverviewSync(DescribeIaCFileOverviewRequest req)
        {
            return InternalRequestAsync<DescribeIaCFileOverviewResponse>(req, "DescribeIaCFileOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain the IaC detection file report.
        /// </summary>
        /// <param name="req"><see cref="DescribeIaCFileReportRequest"/></param>
        /// <returns><see cref="DescribeIaCFileReportResponse"/></returns>
        public Task<DescribeIaCFileReportResponse> DescribeIaCFileReport(DescribeIaCFileReportRequest req)
        {
            return InternalRequestAsync<DescribeIaCFileReportResponse>(req, "DescribeIaCFileReport");
        }

        /// <summary>
        /// Obtain the IaC detection file report.
        /// </summary>
        /// <param name="req"><see cref="DescribeIaCFileReportRequest"/></param>
        /// <returns><see cref="DescribeIaCFileReportResponse"/></returns>
        public DescribeIaCFileReportResponse DescribeIaCFileReportSync(DescribeIaCFileReportRequest req)
        {
            return InternalRequestAsync<DescribeIaCFileReportResponse>(req, "DescribeIaCFileReport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to search the IaC detection integration Token list.
        /// </summary>
        /// <param name="req"><see cref="DescribeIaCTokenListRequest"/></param>
        /// <returns><see cref="DescribeIaCTokenListResponse"/></returns>
        public Task<DescribeIaCTokenListResponse> DescribeIaCTokenList(DescribeIaCTokenListRequest req)
        {
            return InternalRequestAsync<DescribeIaCTokenListResponse>(req, "DescribeIaCTokenList");
        }

        /// <summary>
        /// This API is used to search the IaC detection integration Token list.
        /// </summary>
        /// <param name="req"><see cref="DescribeIaCTokenListRequest"/></param>
        /// <returns><see cref="DescribeIaCTokenListResponse"/></returns>
        public DescribeIaCTokenListResponse DescribeIaCTokenListSync(DescribeIaCTokenListRequest req)
        {
            return InternalRequestAsync<DescribeIaCTokenListResponse>(req, "DescribeIaCTokenList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries image asset details.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageAssetDetailRequest"/></param>
        /// <returns><see cref="DescribeImageAssetDetailResponse"/></returns>
        public Task<DescribeImageAssetDetailResponse> DescribeImageAssetDetail(DescribeImageAssetDetailRequest req)
        {
            return InternalRequestAsync<DescribeImageAssetDetailResponse>(req, "DescribeImageAssetDetail");
        }

        /// <summary>
        /// Queries image asset details.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageAssetDetailRequest"/></param>
        /// <returns><see cref="DescribeImageAssetDetailResponse"/></returns>
        public DescribeImageAssetDetailResponse DescribeImageAssetDetailSync(DescribeImageAssetDetailRequest req)
        {
            return InternalRequestAsync<DescribeImageAssetDetailResponse>(req, "DescribeImageAssetDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the image asset list
        /// </summary>
        /// <param name="req"><see cref="DescribeImageAssetListRequest"/></param>
        /// <returns><see cref="DescribeImageAssetListResponse"/></returns>
        public Task<DescribeImageAssetListResponse> DescribeImageAssetList(DescribeImageAssetListRequest req)
        {
            return InternalRequestAsync<DescribeImageAssetListResponse>(req, "DescribeImageAssetList");
        }

        /// <summary>
        /// Query the image asset list
        /// </summary>
        /// <param name="req"><see cref="DescribeImageAssetListRequest"/></param>
        /// <returns><see cref="DescribeImageAssetListResponse"/></returns>
        public DescribeImageAssetListResponse DescribeImageAssetListSync(DescribeImageAssetListRequest req)
        {
            return InternalRequestAsync<DescribeImageAssetListResponse>(req, "DescribeImageAssetList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the number of related assets of an image.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageAssociatedAssetCountRequest"/></param>
        /// <returns><see cref="DescribeImageAssociatedAssetCountResponse"/></returns>
        public Task<DescribeImageAssociatedAssetCountResponse> DescribeImageAssociatedAssetCount(DescribeImageAssociatedAssetCountRequest req)
        {
            return InternalRequestAsync<DescribeImageAssociatedAssetCountResponse>(req, "DescribeImageAssociatedAssetCount");
        }

        /// <summary>
        /// Query the number of related assets of an image.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageAssociatedAssetCountRequest"/></param>
        /// <returns><see cref="DescribeImageAssociatedAssetCountResponse"/></returns>
        public DescribeImageAssociatedAssetCountResponse DescribeImageAssociatedAssetCountSync(DescribeImageAssociatedAssetCountRequest req)
        {
            return InternalRequestAsync<DescribeImageAssociatedAssetCountResponse>(req, "DescribeImageAssociatedAssetCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the container assets associated with an image.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageAssociatedContainerListRequest"/></param>
        /// <returns><see cref="DescribeImageAssociatedContainerListResponse"/></returns>
        public Task<DescribeImageAssociatedContainerListResponse> DescribeImageAssociatedContainerList(DescribeImageAssociatedContainerListRequest req)
        {
            return InternalRequestAsync<DescribeImageAssociatedContainerListResponse>(req, "DescribeImageAssociatedContainerList");
        }

        /// <summary>
        /// Queries the container assets associated with an image.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageAssociatedContainerListRequest"/></param>
        /// <returns><see cref="DescribeImageAssociatedContainerListResponse"/></returns>
        public DescribeImageAssociatedContainerListResponse DescribeImageAssociatedContainerListSync(DescribeImageAssociatedContainerListRequest req)
        {
            return InternalRequestAsync<DescribeImageAssociatedContainerListResponse>(req, "DescribeImageAssociatedContainerList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the asset list of hosts associated with the image.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageAssociatedHostListRequest"/></param>
        /// <returns><see cref="DescribeImageAssociatedHostListResponse"/></returns>
        public Task<DescribeImageAssociatedHostListResponse> DescribeImageAssociatedHostList(DescribeImageAssociatedHostListRequest req)
        {
            return InternalRequestAsync<DescribeImageAssociatedHostListResponse>(req, "DescribeImageAssociatedHostList");
        }

        /// <summary>
        /// Query the asset list of hosts associated with the image.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageAssociatedHostListRequest"/></param>
        /// <returns><see cref="DescribeImageAssociatedHostListResponse"/></returns>
        public DescribeImageAssociatedHostListResponse DescribeImageAssociatedHostListSync(DescribeImageAssociatedHostListRequest req)
        {
            return InternalRequestAsync<DescribeImageAssociatedHostListResponse>(req, "DescribeImageAssociatedHostList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the image component list.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageComponentListRequest"/></param>
        /// <returns><see cref="DescribeImageComponentListResponse"/></returns>
        public Task<DescribeImageComponentListResponse> DescribeImageComponentList(DescribeImageComponentListRequest req)
        {
            return InternalRequestAsync<DescribeImageComponentListResponse>(req, "DescribeImageComponentList");
        }

        /// <summary>
        /// Queries the image component list.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageComponentListRequest"/></param>
        /// <returns><see cref="DescribeImageComponentListResponse"/></returns>
        public DescribeImageComponentListResponse DescribeImageComponentListSync(DescribeImageComponentListRequest req)
        {
            return InternalRequestAsync<DescribeImageComponentListResponse>(req, "DescribeImageComponentList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the image repository export task list
        /// </summary>
        /// <param name="req"><see cref="DescribeImageExportJobListRequest"/></param>
        /// <returns><see cref="DescribeImageExportJobListResponse"/></returns>
        public Task<DescribeImageExportJobListResponse> DescribeImageExportJobList(DescribeImageExportJobListRequest req)
        {
            return InternalRequestAsync<DescribeImageExportJobListResponse>(req, "DescribeImageExportJobList");
        }

        /// <summary>
        /// Queries the image repository export task list
        /// </summary>
        /// <param name="req"><see cref="DescribeImageExportJobListRequest"/></param>
        /// <returns><see cref="DescribeImageExportJobListResponse"/></returns>
        public DescribeImageExportJobListResponse DescribeImageExportJobListSync(DescribeImageExportJobListRequest req)
        {
            return InternalRequestAsync<DescribeImageExportJobListResponse>(req, "DescribeImageExportJobList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the image layer information list
        /// </summary>
        /// <param name="req"><see cref="DescribeImageLayerListRequest"/></param>
        /// <returns><see cref="DescribeImageLayerListResponse"/></returns>
        public Task<DescribeImageLayerListResponse> DescribeImageLayerList(DescribeImageLayerListRequest req)
        {
            return InternalRequestAsync<DescribeImageLayerListResponse>(req, "DescribeImageLayerList");
        }

        /// <summary>
        /// Query the image layer information list
        /// </summary>
        /// <param name="req"><see cref="DescribeImageLayerListRequest"/></param>
        /// <returns><see cref="DescribeImageLayerListResponse"/></returns>
        public DescribeImageLayerListResponse DescribeImageLayerListSync(DescribeImageLayerListRequest req)
        {
            return InternalRequestAsync<DescribeImageLayerListResponse>(req, "DescribeImageLayerList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the list of vulnerabilities in an image layer
        /// </summary>
        /// <param name="req"><see cref="DescribeImageLayerVulListRequest"/></param>
        /// <returns><see cref="DescribeImageLayerVulListResponse"/></returns>
        public Task<DescribeImageLayerVulListResponse> DescribeImageLayerVulList(DescribeImageLayerVulListRequest req)
        {
            return InternalRequestAsync<DescribeImageLayerVulListResponse>(req, "DescribeImageLayerVulList");
        }

        /// <summary>
        /// Queries the list of vulnerabilities in an image layer
        /// </summary>
        /// <param name="req"><see cref="DescribeImageLayerVulListRequest"/></param>
        /// <returns><see cref="DescribeImageLayerVulListResponse"/></returns>
        public DescribeImageLayerVulListResponse DescribeImageLayerVulListSync(DescribeImageLayerVulListRequest req)
        {
            return InternalRequestAsync<DescribeImageLayerVulListResponse>(req, "DescribeImageLayerVulList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the repository asset overview of images
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRegistryAssetOverviewRequest"/></param>
        /// <returns><see cref="DescribeImageRegistryAssetOverviewResponse"/></returns>
        public Task<DescribeImageRegistryAssetOverviewResponse> DescribeImageRegistryAssetOverview(DescribeImageRegistryAssetOverviewRequest req)
        {
            return InternalRequestAsync<DescribeImageRegistryAssetOverviewResponse>(req, "DescribeImageRegistryAssetOverview");
        }

        /// <summary>
        /// Query the repository asset overview of images
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRegistryAssetOverviewRequest"/></param>
        /// <returns><see cref="DescribeImageRegistryAssetOverviewResponse"/></returns>
        public DescribeImageRegistryAssetOverviewResponse DescribeImageRegistryAssetOverviewSync(DescribeImageRegistryAssetOverviewRequest req)
        {
            return InternalRequestAsync<DescribeImageRegistryAssetOverviewResponse>(req, "DescribeImageRegistryAssetOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the connectivity check task result of an image repository.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRegistryConnectivityTaskResultRequest"/></param>
        /// <returns><see cref="DescribeImageRegistryConnectivityTaskResultResponse"/></returns>
        public Task<DescribeImageRegistryConnectivityTaskResultResponse> DescribeImageRegistryConnectivityTaskResult(DescribeImageRegistryConnectivityTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeImageRegistryConnectivityTaskResultResponse>(req, "DescribeImageRegistryConnectivityTaskResult");
        }

        /// <summary>
        /// Query the connectivity check task result of an image repository.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRegistryConnectivityTaskResultRequest"/></param>
        /// <returns><see cref="DescribeImageRegistryConnectivityTaskResultResponse"/></returns>
        public DescribeImageRegistryConnectivityTaskResultResponse DescribeImageRegistryConnectivityTaskResultSync(DescribeImageRegistryConnectivityTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeImageRegistryConnectivityTaskResultResponse>(req, "DescribeImageRegistryConnectivityTaskResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the image repository list.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRegistryListRequest"/></param>
        /// <returns><see cref="DescribeImageRegistryListResponse"/></returns>
        public Task<DescribeImageRegistryListResponse> DescribeImageRegistryList(DescribeImageRegistryListRequest req)
        {
            return InternalRequestAsync<DescribeImageRegistryListResponse>(req, "DescribeImageRegistryList");
        }

        /// <summary>
        /// This API is used to query the image repository list.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRegistryListRequest"/></param>
        /// <returns><see cref="DescribeImageRegistryListResponse"/></returns>
        public DescribeImageRegistryListResponse DescribeImageRegistryListSync(DescribeImageRegistryListRequest req)
        {
            return InternalRequestAsync<DescribeImageRegistryListResponse>(req, "DescribeImageRegistryList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the mirror repository namespace list.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRegistryNamespaceListRequest"/></param>
        /// <returns><see cref="DescribeImageRegistryNamespaceListResponse"/></returns>
        public Task<DescribeImageRegistryNamespaceListResponse> DescribeImageRegistryNamespaceList(DescribeImageRegistryNamespaceListRequest req)
        {
            return InternalRequestAsync<DescribeImageRegistryNamespaceListResponse>(req, "DescribeImageRegistryNamespaceList");
        }

        /// <summary>
        /// This API is used to query the mirror repository namespace list.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRegistryNamespaceListRequest"/></param>
        /// <returns><see cref="DescribeImageRegistryNamespaceListResponse"/></returns>
        public DescribeImageRegistryNamespaceListResponse DescribeImageRegistryNamespaceListSync(DescribeImageRegistryNamespaceListRequest req)
        {
            return InternalRequestAsync<DescribeImageRegistryNamespaceListResponse>(req, "DescribeImageRegistryNamespaceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query subtask information of image repository scanning
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRegistryScanSubTaskListRequest"/></param>
        /// <returns><see cref="DescribeImageRegistryScanSubTaskListResponse"/></returns>
        public Task<DescribeImageRegistryScanSubTaskListResponse> DescribeImageRegistryScanSubTaskList(DescribeImageRegistryScanSubTaskListRequest req)
        {
            return InternalRequestAsync<DescribeImageRegistryScanSubTaskListResponse>(req, "DescribeImageRegistryScanSubTaskList");
        }

        /// <summary>
        /// Query subtask information of image repository scanning
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRegistryScanSubTaskListRequest"/></param>
        /// <returns><see cref="DescribeImageRegistryScanSubTaskListResponse"/></returns>
        public DescribeImageRegistryScanSubTaskListResponse DescribeImageRegistryScanSubTaskListSync(DescribeImageRegistryScanSubTaskListRequest req)
        {
            return InternalRequestAsync<DescribeImageRegistryScanSubTaskListResponse>(req, "DescribeImageRegistryScanSubTaskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the image repository scan task list
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRegistryScanTaskListRequest"/></param>
        /// <returns><see cref="DescribeImageRegistryScanTaskListResponse"/></returns>
        public Task<DescribeImageRegistryScanTaskListResponse> DescribeImageRegistryScanTaskList(DescribeImageRegistryScanTaskListRequest req)
        {
            return InternalRequestAsync<DescribeImageRegistryScanTaskListResponse>(req, "DescribeImageRegistryScanTaskList");
        }

        /// <summary>
        /// Query the image repository scan task list
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRegistryScanTaskListRequest"/></param>
        /// <returns><see cref="DescribeImageRegistryScanTaskListResponse"/></returns>
        public DescribeImageRegistryScanTaskListResponse DescribeImageRegistryScanTaskListSync(DescribeImageRegistryScanTaskListRequest req)
        {
            return InternalRequestAsync<DescribeImageRegistryScanTaskListResponse>(req, "DescribeImageRegistryScanTaskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// View the scheduled scan task configuration of a mirror repository
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRegistryTimedScanTaskConfigRequest"/></param>
        /// <returns><see cref="DescribeImageRegistryTimedScanTaskConfigResponse"/></returns>
        public Task<DescribeImageRegistryTimedScanTaskConfigResponse> DescribeImageRegistryTimedScanTaskConfig(DescribeImageRegistryTimedScanTaskConfigRequest req)
        {
            return InternalRequestAsync<DescribeImageRegistryTimedScanTaskConfigResponse>(req, "DescribeImageRegistryTimedScanTaskConfig");
        }

        /// <summary>
        /// View the scheduled scan task configuration of a mirror repository
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRegistryTimedScanTaskConfigRequest"/></param>
        /// <returns><see cref="DescribeImageRegistryTimedScanTaskConfigResponse"/></returns>
        public DescribeImageRegistryTimedScanTaskConfigResponse DescribeImageRegistryTimedScanTaskConfigSync(DescribeImageRegistryTimedScanTaskConfigRequest req)
        {
            return InternalRequestAsync<DescribeImageRegistryTimedScanTaskConfigResponse>(req, "DescribeImageRegistryTimedScanTaskConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the preview of a scheduled scan task in the mirror repository
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRegistryTimedScanTaskPreviewRequest"/></param>
        /// <returns><see cref="DescribeImageRegistryTimedScanTaskPreviewResponse"/></returns>
        public Task<DescribeImageRegistryTimedScanTaskPreviewResponse> DescribeImageRegistryTimedScanTaskPreview(DescribeImageRegistryTimedScanTaskPreviewRequest req)
        {
            return InternalRequestAsync<DescribeImageRegistryTimedScanTaskPreviewResponse>(req, "DescribeImageRegistryTimedScanTaskPreview");
        }

        /// <summary>
        /// Query the preview of a scheduled scan task in the mirror repository
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRegistryTimedScanTaskPreviewRequest"/></param>
        /// <returns><see cref="DescribeImageRegistryTimedScanTaskPreviewResponse"/></returns>
        public DescribeImageRegistryTimedScanTaskPreviewResponse DescribeImageRegistryTimedScanTaskPreviewSync(DescribeImageRegistryTimedScanTaskPreviewRequest req)
        {
            return InternalRequestAsync<DescribeImageRegistryTimedScanTaskPreviewResponse>(req, "DescribeImageRegistryTimedScanTaskPreview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the sensitive information list of an image
        /// </summary>
        /// <param name="req"><see cref="DescribeImageSensitiveInfoListRequest"/></param>
        /// <returns><see cref="DescribeImageSensitiveInfoListResponse"/></returns>
        public Task<DescribeImageSensitiveInfoListResponse> DescribeImageSensitiveInfoList(DescribeImageSensitiveInfoListRequest req)
        {
            return InternalRequestAsync<DescribeImageSensitiveInfoListResponse>(req, "DescribeImageSensitiveInfoList");
        }

        /// <summary>
        /// Query the sensitive information list of an image
        /// </summary>
        /// <param name="req"><see cref="DescribeImageSensitiveInfoListRequest"/></param>
        /// <returns><see cref="DescribeImageSensitiveInfoListResponse"/></returns>
        public DescribeImageSensitiveInfoListResponse DescribeImageSensitiveInfoListSync(DescribeImageSensitiveInfoListRequest req)
        {
            return InternalRequestAsync<DescribeImageSensitiveInfoListResponse>(req, "DescribeImageSensitiveInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the sensitive information allowlist for container images
        /// </summary>
        /// <param name="req"><see cref="DescribeImageSensitiveWhitelistRequest"/></param>
        /// <returns><see cref="DescribeImageSensitiveWhitelistResponse"/></returns>
        public Task<DescribeImageSensitiveWhitelistResponse> DescribeImageSensitiveWhitelist(DescribeImageSensitiveWhitelistRequest req)
        {
            return InternalRequestAsync<DescribeImageSensitiveWhitelistResponse>(req, "DescribeImageSensitiveWhitelist");
        }

        /// <summary>
        /// Query the sensitive information allowlist for container images
        /// </summary>
        /// <param name="req"><see cref="DescribeImageSensitiveWhitelistRequest"/></param>
        /// <returns><see cref="DescribeImageSensitiveWhitelistResponse"/></returns>
        public DescribeImageSensitiveWhitelistResponse DescribeImageSensitiveWhitelistSync(DescribeImageSensitiveWhitelistRequest req)
        {
            return InternalRequestAsync<DescribeImageSensitiveWhitelistResponse>(req, "DescribeImageSensitiveWhitelist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the Trojan virus list of an image
        /// </summary>
        /// <param name="req"><see cref="DescribeImageVirusListRequest"/></param>
        /// <returns><see cref="DescribeImageVirusListResponse"/></returns>
        public Task<DescribeImageVirusListResponse> DescribeImageVirusList(DescribeImageVirusListRequest req)
        {
            return InternalRequestAsync<DescribeImageVirusListResponse>(req, "DescribeImageVirusList");
        }

        /// <summary>
        /// Queries the Trojan virus list of an image
        /// </summary>
        /// <param name="req"><see cref="DescribeImageVirusListRequest"/></param>
        /// <returns><see cref="DescribeImageVirusListResponse"/></returns>
        public DescribeImageVirusListResponse DescribeImageVirusListSync(DescribeImageVirusListRequest req)
        {
            return InternalRequestAsync<DescribeImageVirusListResponse>(req, "DescribeImageVirusList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the Trojan allowlist of an image.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageVirusWhitelistRequest"/></param>
        /// <returns><see cref="DescribeImageVirusWhitelistResponse"/></returns>
        public Task<DescribeImageVirusWhitelistResponse> DescribeImageVirusWhitelist(DescribeImageVirusWhitelistRequest req)
        {
            return InternalRequestAsync<DescribeImageVirusWhitelistResponse>(req, "DescribeImageVirusWhitelist");
        }

        /// <summary>
        /// This API is used to query the Trojan allowlist of an image.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageVirusWhitelistRequest"/></param>
        /// <returns><see cref="DescribeImageVirusWhitelistResponse"/></returns>
        public DescribeImageVirusWhitelistResponse DescribeImageVirusWhitelistSync(DescribeImageVirusWhitelistRequest req)
        {
            return InternalRequestAsync<DescribeImageVirusWhitelistResponse>(req, "DescribeImageVirusWhitelist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the detailed information of the Trojan allowlist of an image.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageVirusWhitelistDetailRequest"/></param>
        /// <returns><see cref="DescribeImageVirusWhitelistDetailResponse"/></returns>
        public Task<DescribeImageVirusWhitelistDetailResponse> DescribeImageVirusWhitelistDetail(DescribeImageVirusWhitelistDetailRequest req)
        {
            return InternalRequestAsync<DescribeImageVirusWhitelistDetailResponse>(req, "DescribeImageVirusWhitelistDetail");
        }

        /// <summary>
        /// Queries the detailed information of the Trojan allowlist of an image.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageVirusWhitelistDetailRequest"/></param>
        /// <returns><see cref="DescribeImageVirusWhitelistDetailResponse"/></returns>
        public DescribeImageVirusWhitelistDetailResponse DescribeImageVirusWhitelistDetailSync(DescribeImageVirusWhitelistDetailRequest req)
        {
            return InternalRequestAsync<DescribeImageVirusWhitelistDetailResponse>(req, "DescribeImageVirusWhitelistDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the image vulnerability list.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageVulListRequest"/></param>
        /// <returns><see cref="DescribeImageVulListResponse"/></returns>
        public Task<DescribeImageVulListResponse> DescribeImageVulList(DescribeImageVulListRequest req)
        {
            return InternalRequestAsync<DescribeImageVulListResponse>(req, "DescribeImageVulList");
        }

        /// <summary>
        /// This API is used to query the image vulnerability list.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageVulListRequest"/></param>
        /// <returns><see cref="DescribeImageVulListResponse"/></returns>
        public DescribeImageVulListResponse DescribeImageVulListSync(DescribeImageVulListRequest req)
        {
            return InternalRequestAsync<DescribeImageVulListResponse>(req, "DescribeImageVulList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the image vulnerability overview list
        /// </summary>
        /// <param name="req"><see cref="DescribeImageVulSummaryListRequest"/></param>
        /// <returns><see cref="DescribeImageVulSummaryListResponse"/></returns>
        public Task<DescribeImageVulSummaryListResponse> DescribeImageVulSummaryList(DescribeImageVulSummaryListRequest req)
        {
            return InternalRequestAsync<DescribeImageVulSummaryListResponse>(req, "DescribeImageVulSummaryList");
        }

        /// <summary>
        /// Queries the image vulnerability overview list
        /// </summary>
        /// <param name="req"><see cref="DescribeImageVulSummaryListRequest"/></param>
        /// <returns><see cref="DescribeImageVulSummaryListResponse"/></returns>
        public DescribeImageVulSummaryListResponse DescribeImageVulSummaryListSync(DescribeImageVulSummaryListRequest req)
        {
            return InternalRequestAsync<DescribeImageVulSummaryListResponse>(req, "DescribeImageVulSummaryList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the vulnerability allowlist of a container image.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageVulWhitelistRequest"/></param>
        /// <returns><see cref="DescribeImageVulWhitelistResponse"/></returns>
        public Task<DescribeImageVulWhitelistResponse> DescribeImageVulWhitelist(DescribeImageVulWhitelistRequest req)
        {
            return InternalRequestAsync<DescribeImageVulWhitelistResponse>(req, "DescribeImageVulWhitelist");
        }

        /// <summary>
        /// This API is used to query the vulnerability allowlist of a container image.
        /// </summary>
        /// <param name="req"><see cref="DescribeImageVulWhitelistRequest"/></param>
        /// <returns><see cref="DescribeImageVulWhitelistResponse"/></returns>
        public DescribeImageVulWhitelistResponse DescribeImageVulWhitelistSync(DescribeImageVulWhitelistRequest req)
        {
            return InternalRequestAsync<DescribeImageVulWhitelistResponse>(req, "DescribeImageVulWhitelist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the details of a single Windows KB patch based on the user's input KB internal ID, and return the basic KB info, release time, whether restart is required, as well as the list of vulnerabilities associated with the KB.
        /// </summary>
        /// <param name="req"><see cref="DescribeKBDetailRequest"/></param>
        /// <returns><see cref="DescribeKBDetailResponse"/></returns>
        public Task<DescribeKBDetailResponse> DescribeKBDetail(DescribeKBDetailRequest req)
        {
            return InternalRequestAsync<DescribeKBDetailResponse>(req, "DescribeKBDetail");
        }

        /// <summary>
        /// Query the details of a single Windows KB patch based on the user's input KB internal ID, and return the basic KB info, release time, whether restart is required, as well as the list of vulnerabilities associated with the KB.
        /// </summary>
        /// <param name="req"><see cref="DescribeKBDetailRequest"/></param>
        /// <returns><see cref="DescribeKBDetailResponse"/></returns>
        public DescribeKBDetailResponse DescribeKBDetailSync(DescribeKBDetailRequest req)
        {
            return InternalRequestAsync<DescribeKBDetailResponse>(req, "DescribeKBDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the list of hosts that can update a specified KB patch. This API is used for Windows patch repair scenarios to query which hosts lack the patch and support auto-update before user-submitted KB patch update tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeKBUpdatableMachineListRequest"/></param>
        /// <returns><see cref="DescribeKBUpdatableMachineListResponse"/></returns>
        public Task<DescribeKBUpdatableMachineListResponse> DescribeKBUpdatableMachineList(DescribeKBUpdatableMachineListRequest req)
        {
            return InternalRequestAsync<DescribeKBUpdatableMachineListResponse>(req, "DescribeKBUpdatableMachineList");
        }

        /// <summary>
        /// Query the list of hosts that can update a specified KB patch. This API is used for Windows patch repair scenarios to query which hosts lack the patch and support auto-update before user-submitted KB patch update tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeKBUpdatableMachineListRequest"/></param>
        /// <returns><see cref="DescribeKBUpdatableMachineListResponse"/></returns>
        public DescribeKBUpdatableMachineListResponse DescribeKBUpdatableMachineListSync(DescribeKBUpdatableMachineListRequest req)
        {
            return InternalRequestAsync<DescribeKBUpdatableMachineListResponse>(req, "DescribeKBUpdatableMachineList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query credential details and return credential metadata and masked credential data. The access type returns an Access array (original Key, masked Value), and the sts type returns an STS object (original System, masked SecretID and SecretKey).
        /// </summary>
        /// <param name="req"><see cref="DescribeKeySandboxCredentialRequest"/></param>
        /// <returns><see cref="DescribeKeySandboxCredentialResponse"/></returns>
        public Task<DescribeKeySandboxCredentialResponse> DescribeKeySandboxCredential(DescribeKeySandboxCredentialRequest req)
        {
            return InternalRequestAsync<DescribeKeySandboxCredentialResponse>(req, "DescribeKeySandboxCredential");
        }

        /// <summary>
        /// This API is used to query credential details and return credential metadata and masked credential data. The access type returns an Access array (original Key, masked Value), and the sts type returns an STS object (original System, masked SecretID and SecretKey).
        /// </summary>
        /// <param name="req"><see cref="DescribeKeySandboxCredentialRequest"/></param>
        /// <returns><see cref="DescribeKeySandboxCredentialResponse"/></returns>
        public DescribeKeySandboxCredentialResponse DescribeKeySandboxCredentialSync(DescribeKeySandboxCredentialRequest req)
        {
            return InternalRequestAsync<DescribeKeySandboxCredentialResponse>(req, "DescribeKeySandboxCredential")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the voucher list.
        /// </summary>
        /// <param name="req"><see cref="DescribeKeySandboxCredentialListRequest"/></param>
        /// <returns><see cref="DescribeKeySandboxCredentialListResponse"/></returns>
        public Task<DescribeKeySandboxCredentialListResponse> DescribeKeySandboxCredentialList(DescribeKeySandboxCredentialListRequest req)
        {
            return InternalRequestAsync<DescribeKeySandboxCredentialListResponse>(req, "DescribeKeySandboxCredentialList");
        }

        /// <summary>
        /// Query the voucher list.
        /// </summary>
        /// <param name="req"><see cref="DescribeKeySandboxCredentialListRequest"/></param>
        /// <returns><see cref="DescribeKeySandboxCredentialListResponse"/></returns>
        public DescribeKeySandboxCredentialListResponse DescribeKeySandboxCredentialListSync(DescribeKeySandboxCredentialListRequest req)
        {
            return InternalRequestAsync<DescribeKeySandboxCredentialListResponse>(req, "DescribeKeySandboxCredentialList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get last check-now task info
        /// </summary>
        /// <param name="req"><see cref="DescribeLastScanTaskInfoRequest"/></param>
        /// <returns><see cref="DescribeLastScanTaskInfoResponse"/></returns>
        public Task<DescribeLastScanTaskInfoResponse> DescribeLastScanTaskInfo(DescribeLastScanTaskInfoRequest req)
        {
            return InternalRequestAsync<DescribeLastScanTaskInfoResponse>(req, "DescribeLastScanTaskInfo");
        }

        /// <summary>
        /// Get last check-now task info
        /// </summary>
        /// <param name="req"><see cref="DescribeLastScanTaskInfoRequest"/></param>
        /// <returns><see cref="DescribeLastScanTaskInfoResponse"/></returns>
        public DescribeLastScanTaskInfoResponse DescribeLastScanTaskInfoSync(DescribeLastScanTaskInfoRequest req)
        {
            return InternalRequestAsync<DescribeLastScanTaskInfoResponse>(req, "DescribeLastScanTaskInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the overall status of all valid authorizations under the current account, returns total count, used, remaining, and expiry time grouped by billing item, and also returns the auto-purchase switch status and merged remaining unbind count. The output sequence is fixed as: flagship edition → pro edition → RASP → other.
        /// </summary>
        /// <param name="req"><see cref="DescribeLicenseStatusRequest"/></param>
        /// <returns><see cref="DescribeLicenseStatusResponse"/></returns>
        public Task<DescribeLicenseStatusResponse> DescribeLicenseStatus(DescribeLicenseStatusRequest req)
        {
            return InternalRequestAsync<DescribeLicenseStatusResponse>(req, "DescribeLicenseStatus");
        }

        /// <summary>
        /// Queries the overall status of all valid authorizations under the current account, returns total count, used, remaining, and expiry time grouped by billing item, and also returns the auto-purchase switch status and merged remaining unbind count. The output sequence is fixed as: flagship edition → pro edition → RASP → other.
        /// </summary>
        /// <param name="req"><see cref="DescribeLicenseStatusRequest"/></param>
        /// <returns><see cref="DescribeLicenseStatusResponse"/></returns>
        public DescribeLicenseStatusResponse DescribeLicenseStatusSync(DescribeLicenseStatusRequest req)
        {
            return InternalRequestAsync<DescribeLicenseStatusResponse>(req, "DescribeLicenseStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the firewall rules of a lightweight application server
        /// </summary>
        /// <param name="req"><see cref="DescribeLighthouseFirewallRulesRequest"/></param>
        /// <returns><see cref="DescribeLighthouseFirewallRulesResponse"/></returns>
        public Task<DescribeLighthouseFirewallRulesResponse> DescribeLighthouseFirewallRules(DescribeLighthouseFirewallRulesRequest req)
        {
            return InternalRequestAsync<DescribeLighthouseFirewallRulesResponse>(req, "DescribeLighthouseFirewallRules");
        }

        /// <summary>
        /// Query the firewall rules of a lightweight application server
        /// </summary>
        /// <param name="req"><see cref="DescribeLighthouseFirewallRulesRequest"/></param>
        /// <returns><see cref="DescribeLighthouseFirewallRulesResponse"/></returns>
        public DescribeLighthouseFirewallRulesResponse DescribeLighthouseFirewallRulesSync(DescribeLighthouseFirewallRulesRequest req)
        {
            return InternalRequestAsync<DescribeLighthouseFirewallRulesResponse>(req, "DescribeLighthouseFirewallRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query CLB Listener List
        /// </summary>
        /// <param name="req"><see cref="DescribeListenerListRequest"/></param>
        /// <returns><see cref="DescribeListenerListResponse"/></returns>
        public Task<DescribeListenerListResponse> DescribeListenerList(DescribeListenerListRequest req)
        {
            return InternalRequestAsync<DescribeListenerListResponse>(req, "DescribeListenerList");
        }

        /// <summary>
        /// Query CLB Listener List
        /// </summary>
        /// <param name="req"><see cref="DescribeListenerListRequest"/></param>
        /// <returns><see cref="DescribeListenerListResponse"/></returns>
        public DescribeListenerListResponse DescribeListenerListSync(DescribeListenerListRequest req)
        {
            return InternalRequestAsync<DescribeListenerListResponse>(req, "DescribeListenerList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the global configuration for anti-uninstallation.
        /// </summary>
        /// <param name="req"><see cref="DescribeLoginTypeGlobalConfRequest"/></param>
        /// <returns><see cref="DescribeLoginTypeGlobalConfResponse"/></returns>
        public Task<DescribeLoginTypeGlobalConfResponse> DescribeLoginTypeGlobalConf(DescribeLoginTypeGlobalConfRequest req)
        {
            return InternalRequestAsync<DescribeLoginTypeGlobalConfResponse>(req, "DescribeLoginTypeGlobalConf");
        }

        /// <summary>
        /// This API is used to obtain the global configuration for anti-uninstallation.
        /// </summary>
        /// <param name="req"><see cref="DescribeLoginTypeGlobalConfRequest"/></param>
        /// <returns><see cref="DescribeLoginTypeGlobalConfResponse"/></returns>
        public DescribeLoginTypeGlobalConfResponse DescribeLoginTypeGlobalConfSync(DescribeLoginTypeGlobalConfRequest req)
        {
            return InternalRequestAsync<DescribeLoginTypeGlobalConfResponse>(req, "DescribeLoginTypeGlobalConf")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get the host list for QR code log-in
        /// </summary>
        /// <param name="req"><see cref="DescribeLoginTypeHostRequest"/></param>
        /// <returns><see cref="DescribeLoginTypeHostResponse"/></returns>
        public Task<DescribeLoginTypeHostResponse> DescribeLoginTypeHost(DescribeLoginTypeHostRequest req)
        {
            return InternalRequestAsync<DescribeLoginTypeHostResponse>(req, "DescribeLoginTypeHost");
        }

        /// <summary>
        /// Get the host list for QR code log-in
        /// </summary>
        /// <param name="req"><see cref="DescribeLoginTypeHostRequest"/></param>
        /// <returns><see cref="DescribeLoginTypeHostResponse"/></returns>
        public DescribeLoginTypeHostResponse DescribeLoginTypeHostSync(DescribeLoginTypeHostRequest req)
        {
            return InternalRequestAsync<DescribeLoginTypeHostResponse>(req, "DescribeLoginTypeHost")
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
        /// This API is used to obtain the host login method.
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineLoginTypeRequest"/></param>
        /// <returns><see cref="DescribeMachineLoginTypeResponse"/></returns>
        public Task<DescribeMachineLoginTypeResponse> DescribeMachineLoginType(DescribeMachineLoginTypeRequest req)
        {
            return InternalRequestAsync<DescribeMachineLoginTypeResponse>(req, "DescribeMachineLoginType");
        }

        /// <summary>
        /// This API is used to obtain the host login method.
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineLoginTypeRequest"/></param>
        /// <returns><see cref="DescribeMachineLoginTypeResponse"/></returns>
        public DescribeMachineLoginTypeResponse DescribeMachineLoginTypeSync(DescribeMachineLoginTypeRequest req)
        {
            return InternalRequestAsync<DescribeMachineLoginTypeResponse>(req, "DescribeMachineLoginType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the scheduled scan configuration for file scan and removal.
        /// </summary>
        /// <param name="req"><see cref="DescribeMalwareTimingScanSettingRequest"/></param>
        /// <returns><see cref="DescribeMalwareTimingScanSettingResponse"/></returns>
        public Task<DescribeMalwareTimingScanSettingResponse> DescribeMalwareTimingScanSetting(DescribeMalwareTimingScanSettingRequest req)
        {
            return InternalRequestAsync<DescribeMalwareTimingScanSettingResponse>(req, "DescribeMalwareTimingScanSetting");
        }

        /// <summary>
        /// This API is used to query the scheduled scan configuration for file scan and removal.
        /// </summary>
        /// <param name="req"><see cref="DescribeMalwareTimingScanSettingRequest"/></param>
        /// <returns><see cref="DescribeMalwareTimingScanSettingResponse"/></returns>
        public DescribeMalwareTimingScanSettingResponse DescribeMalwareTimingScanSettingSync(DescribeMalwareTimingScanSettingRequest req)
        {
            return InternalRequestAsync<DescribeMalwareTimingScanSettingResponse>(req, "DescribeMalwareTimingScanSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Show mandatory vulnerability intelligence for businesses.
        /// </summary>
        /// <param name="req"><see cref="DescribeMandatoryVulSetRequest"/></param>
        /// <returns><see cref="DescribeMandatoryVulSetResponse"/></returns>
        public Task<DescribeMandatoryVulSetResponse> DescribeMandatoryVulSet(DescribeMandatoryVulSetRequest req)
        {
            return InternalRequestAsync<DescribeMandatoryVulSetResponse>(req, "DescribeMandatoryVulSet");
        }

        /// <summary>
        /// Show mandatory vulnerability intelligence for businesses.
        /// </summary>
        /// <param name="req"><see cref="DescribeMandatoryVulSetRequest"/></param>
        /// <returns><see cref="DescribeMandatoryVulSetResponse"/></returns>
        public DescribeMandatoryVulSetResponse DescribeMandatoryVulSetSync(DescribeMandatoryVulSetRequest req)
        {
            return InternalRequestAsync<DescribeMandatoryVulSetResponse>(req, "DescribeMandatoryVulSet")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain a list of batch tasks for modification of host login methods.
        /// </summary>
        /// <param name="req"><see cref="DescribeModifyMachinesLoginTypeTasksRequest"/></param>
        /// <returns><see cref="DescribeModifyMachinesLoginTypeTasksResponse"/></returns>
        public Task<DescribeModifyMachinesLoginTypeTasksResponse> DescribeModifyMachinesLoginTypeTasks(DescribeModifyMachinesLoginTypeTasksRequest req)
        {
            return InternalRequestAsync<DescribeModifyMachinesLoginTypeTasksResponse>(req, "DescribeModifyMachinesLoginTypeTasks");
        }

        /// <summary>
        /// This API is used to obtain a list of batch tasks for modification of host login methods.
        /// </summary>
        /// <param name="req"><see cref="DescribeModifyMachinesLoginTypeTasksRequest"/></param>
        /// <returns><see cref="DescribeModifyMachinesLoginTypeTasksResponse"/></returns>
        public DescribeModifyMachinesLoginTypeTasksResponse DescribeModifyMachinesLoginTypeTasksSync(DescribeModifyMachinesLoginTypeTasksRequest req)
        {
            return InternalRequestAsync<DescribeModifyMachinesLoginTypeTasksResponse>(req, "DescribeModifyMachinesLoginTypeTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retrieve the total number of assets integrated across multiple clouds (Tencent Cloud, Alibaba Cloud, AWS, Huawei Cloud, Azure, etc.) and the details of asset counts for each cloud service provider.
        /// </summary>
        /// <param name="req"><see cref="DescribeMultiCloudAssetCountRequest"/></param>
        /// <returns><see cref="DescribeMultiCloudAssetCountResponse"/></returns>
        public Task<DescribeMultiCloudAssetCountResponse> DescribeMultiCloudAssetCount(DescribeMultiCloudAssetCountRequest req)
        {
            return InternalRequestAsync<DescribeMultiCloudAssetCountResponse>(req, "DescribeMultiCloudAssetCount");
        }

        /// <summary>
        /// Retrieve the total number of assets integrated across multiple clouds (Tencent Cloud, Alibaba Cloud, AWS, Huawei Cloud, Azure, etc.) and the details of asset counts for each cloud service provider.
        /// </summary>
        /// <param name="req"><see cref="DescribeMultiCloudAssetCountRequest"/></param>
        /// <returns><see cref="DescribeMultiCloudAssetCountResponse"/></returns>
        public DescribeMultiCloudAssetCountResponse DescribeMultiCloudAssetCountSync(DescribeMultiCloudAssetCountRequest req)
        {
            return InternalRequestAsync<DescribeMultiCloudAssetCountResponse>(req, "DescribeMultiCloudAssetCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the global configuration for NFS scanning.
        /// </summary>
        /// <param name="req"><see cref="DescribeNFSScanConfRequest"/></param>
        /// <returns><see cref="DescribeNFSScanConfResponse"/></returns>
        public Task<DescribeNFSScanConfResponse> DescribeNFSScanConf(DescribeNFSScanConfRequest req)
        {
            return InternalRequestAsync<DescribeNFSScanConfResponse>(req, "DescribeNFSScanConf");
        }

        /// <summary>
        /// This API is used to obtain the global configuration for NFS scanning.
        /// </summary>
        /// <param name="req"><see cref="DescribeNFSScanConfRequest"/></param>
        /// <returns><see cref="DescribeNFSScanConfResponse"/></returns>
        public DescribeNFSScanConfResponse DescribeNFSScanConfSync(DescribeNFSScanConfRequest req)
        {
            return InternalRequestAsync<DescribeNFSScanConfResponse>(req, "DescribeNFSScanConf")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the host list for QR code log-in.
        /// </summary>
        /// <param name="req"><see cref="DescribeNFSScanHostRequest"/></param>
        /// <returns><see cref="DescribeNFSScanHostResponse"/></returns>
        public Task<DescribeNFSScanHostResponse> DescribeNFSScanHost(DescribeNFSScanHostRequest req)
        {
            return InternalRequestAsync<DescribeNFSScanHostResponse>(req, "DescribeNFSScanHost");
        }

        /// <summary>
        /// This API is used to query the host list for QR code log-in.
        /// </summary>
        /// <param name="req"><see cref="DescribeNFSScanHostRequest"/></param>
        /// <returns><see cref="DescribeNFSScanHostResponse"/></returns>
        public DescribeNFSScanHostResponse DescribeNFSScanHostSync(DescribeNFSScanHostRequest req)
        {
            return InternalRequestAsync<DescribeNFSScanHostResponse>(req, "DescribeNFSScanHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain Network Interface Card List
        /// </summary>
        /// <param name="req"><see cref="DescribeNICAssetsRequest"/></param>
        /// <returns><see cref="DescribeNICAssetsResponse"/></returns>
        public Task<DescribeNICAssetsResponse> DescribeNICAssets(DescribeNICAssetsRequest req)
        {
            return InternalRequestAsync<DescribeNICAssetsResponse>(req, "DescribeNICAssets");
        }

        /// <summary>
        /// Obtain Network Interface Card List
        /// </summary>
        /// <param name="req"><see cref="DescribeNICAssetsRequest"/></param>
        /// <returns><see cref="DescribeNICAssetsResponse"/></returns>
        public DescribeNICAssetsResponse DescribeNICAssetsSync(DescribeNICAssetsRequest req)
        {
            return InternalRequestAsync<DescribeNICAssetsResponse>(req, "DescribeNICAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the nat policy corresponding to a Tencent Cloud nat gateway instance
        /// </summary>
        /// <param name="req"><see cref="DescribeNatRulesRequest"/></param>
        /// <returns><see cref="DescribeNatRulesResponse"/></returns>
        public Task<DescribeNatRulesResponse> DescribeNatRules(DescribeNatRulesRequest req)
        {
            return InternalRequestAsync<DescribeNatRulesResponse>(req, "DescribeNatRules");
        }

        /// <summary>
        /// Query the nat policy corresponding to a Tencent Cloud nat gateway instance
        /// </summary>
        /// <param name="req"><see cref="DescribeNatRulesRequest"/></param>
        /// <returns><see cref="DescribeNatRulesResponse"/></returns>
        public DescribeNatRulesResponse DescribeNatRulesSync(DescribeNatRulesRequest req)
        {
            return InternalRequestAsync<DescribeNatRulesResponse>(req, "DescribeNatRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the cyber attack detection switch and asset scope configuration
        /// </summary>
        /// <param name="req"><see cref="DescribeNetAttackSettingRequest"/></param>
        /// <returns><see cref="DescribeNetAttackSettingResponse"/></returns>
        public Task<DescribeNetAttackSettingResponse> DescribeNetAttackSetting(DescribeNetAttackSettingRequest req)
        {
            return InternalRequestAsync<DescribeNetAttackSettingResponse>(req, "DescribeNetAttackSetting");
        }

        /// <summary>
        /// Query the cyber attack detection switch and asset scope configuration
        /// </summary>
        /// <param name="req"><see cref="DescribeNetAttackSettingRequest"/></param>
        /// <returns><see cref="DescribeNetAttackSettingResponse"/></returns>
        public DescribeNetAttackSettingResponse DescribeNetAttackSettingSync(DescribeNetAttackSettingRequest req)
        {
            return InternalRequestAsync<DescribeNetAttackSettingResponse>(req, "DescribeNetAttackSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query client offline duration
        /// </summary>
        /// <param name="req"><see cref="DescribeNotifyAgentOfflineDurationRequest"/></param>
        /// <returns><see cref="DescribeNotifyAgentOfflineDurationResponse"/></returns>
        public Task<DescribeNotifyAgentOfflineDurationResponse> DescribeNotifyAgentOfflineDuration(DescribeNotifyAgentOfflineDurationRequest req)
        {
            return InternalRequestAsync<DescribeNotifyAgentOfflineDurationResponse>(req, "DescribeNotifyAgentOfflineDuration");
        }

        /// <summary>
        /// Query client offline duration
        /// </summary>
        /// <param name="req"><see cref="DescribeNotifyAgentOfflineDurationRequest"/></param>
        /// <returns><see cref="DescribeNotifyAgentOfflineDurationResponse"/></returns>
        public DescribeNotifyAgentOfflineDurationResponse DescribeNotifyAgentOfflineDurationSync(DescribeNotifyAgentOfflineDurationRequest req)
        {
            return InternalRequestAsync<DescribeNotifyAgentOfflineDurationResponse>(req, "DescribeNotifyAgentOfflineDuration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get the notification asset scope configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeNotifyAssetConfigRequest"/></param>
        /// <returns><see cref="DescribeNotifyAssetConfigResponse"/></returns>
        public Task<DescribeNotifyAssetConfigResponse> DescribeNotifyAssetConfig(DescribeNotifyAssetConfigRequest req)
        {
            return InternalRequestAsync<DescribeNotifyAssetConfigResponse>(req, "DescribeNotifyAssetConfig");
        }

        /// <summary>
        /// Get the notification asset scope configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeNotifyAssetConfigRequest"/></param>
        /// <returns><see cref="DescribeNotifyAssetConfigResponse"/></returns>
        public DescribeNotifyAssetConfigResponse DescribeNotifyAssetConfigSync(DescribeNotifyAssetConfigRequest req)
        {
            return InternalRequestAsync<DescribeNotifyAssetConfigResponse>(req, "DescribeNotifyAssetConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get notification settings
        /// </summary>
        /// <param name="req"><see cref="DescribeNotifySettingRequest"/></param>
        /// <returns><see cref="DescribeNotifySettingResponse"/></returns>
        public Task<DescribeNotifySettingResponse> DescribeNotifySetting(DescribeNotifySettingRequest req)
        {
            return InternalRequestAsync<DescribeNotifySettingResponse>(req, "DescribeNotifySetting");
        }

        /// <summary>
        /// Get notification settings
        /// </summary>
        /// <param name="req"><see cref="DescribeNotifySettingRequest"/></param>
        /// <returns><see cref="DescribeNotifySettingResponse"/></returns>
        public DescribeNotifySettingResponse DescribeNotifySettingSync(DescribeNotifySettingRequest req)
        {
            return InternalRequestAsync<DescribeNotifySettingResponse>(req, "DescribeNotifySetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets notification settings for risk governance.
        /// </summary>
        /// <param name="req"><see cref="DescribeNotifySettingAkRequest"/></param>
        /// <returns><see cref="DescribeNotifySettingAkResponse"/></returns>
        public Task<DescribeNotifySettingAkResponse> DescribeNotifySettingAk(DescribeNotifySettingAkRequest req)
        {
            return InternalRequestAsync<DescribeNotifySettingAkResponse>(req, "DescribeNotifySettingAk");
        }

        /// <summary>
        /// Gets notification settings for risk governance.
        /// </summary>
        /// <param name="req"><see cref="DescribeNotifySettingAkRequest"/></param>
        /// <returns><see cref="DescribeNotifySettingAkResponse"/></returns>
        public DescribeNotifySettingAkResponse DescribeNotifySettingAkSync(DescribeNotifySettingAkRequest req)
        {
            return InternalRequestAsync<DescribeNotifySettingAkResponse>(req, "DescribeNotifySettingAk")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain advanced configurations for alarm center notifications.
        /// </summary>
        /// <param name="req"><see cref="DescribeNotifySettingAlertRequest"/></param>
        /// <returns><see cref="DescribeNotifySettingAlertResponse"/></returns>
        public Task<DescribeNotifySettingAlertResponse> DescribeNotifySettingAlert(DescribeNotifySettingAlertRequest req)
        {
            return InternalRequestAsync<DescribeNotifySettingAlertResponse>(req, "DescribeNotifySettingAlert");
        }

        /// <summary>
        /// This API is used to obtain advanced configurations for alarm center notifications.
        /// </summary>
        /// <param name="req"><see cref="DescribeNotifySettingAlertRequest"/></param>
        /// <returns><see cref="DescribeNotifySettingAlertResponse"/></returns>
        public DescribeNotifySettingAlertResponse DescribeNotifySettingAlertSync(DescribeNotifySettingAlertRequest req)
        {
            return InternalRequestAsync<DescribeNotifySettingAlertResponse>(req, "DescribeNotifySettingAlert")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query Group Account Details
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationInfoRequest"/></param>
        /// <returns><see cref="DescribeOrganizationInfoResponse"/></returns>
        public Task<DescribeOrganizationInfoResponse> DescribeOrganizationInfo(DescribeOrganizationInfoRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationInfoResponse>(req, "DescribeOrganizationInfo");
        }

        /// <summary>
        /// Query Group Account Details
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationInfoRequest"/></param>
        /// <returns><see cref="DescribeOrganizationInfoResponse"/></returns>
        public DescribeOrganizationInfoResponse DescribeOrganizationInfoSync(DescribeOrganizationInfoRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationInfoResponse>(req, "DescribeOrganizationInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query Group Account User List
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationUserInfoRequest"/></param>
        /// <returns><see cref="DescribeOrganizationUserInfoResponse"/></returns>
        public Task<DescribeOrganizationUserInfoResponse> DescribeOrganizationUserInfo(DescribeOrganizationUserInfoRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationUserInfoResponse>(req, "DescribeOrganizationUserInfo");
        }

        /// <summary>
        /// Query Group Account User List
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationUserInfoRequest"/></param>
        /// <returns><see cref="DescribeOrganizationUserInfoResponse"/></returns>
        public DescribeOrganizationUserInfoResponse DescribeOrganizationUserInfoSync(DescribeOrganizationUserInfoRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationUserInfoResponse>(req, "DescribeOrganizationUserInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Asset list
        /// </summary>
        /// <param name="req"><see cref="DescribeOtherCloudAssetsRequest"/></param>
        /// <returns><see cref="DescribeOtherCloudAssetsResponse"/></returns>
        public Task<DescribeOtherCloudAssetsResponse> DescribeOtherCloudAssets(DescribeOtherCloudAssetsRequest req)
        {
            return InternalRequestAsync<DescribeOtherCloudAssetsResponse>(req, "DescribeOtherCloudAssets");
        }

        /// <summary>
        /// Asset list
        /// </summary>
        /// <param name="req"><see cref="DescribeOtherCloudAssetsRequest"/></param>
        /// <returns><see cref="DescribeOtherCloudAssetsResponse"/></returns>
        public DescribeOtherCloudAssetsResponse DescribeOtherCloudAssetsSync(DescribeOtherCloudAssetsRequest req)
        {
            return InternalRequestAsync<DescribeOtherCloudAssetsResponse>(req, "DescribeOtherCloudAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the container list associated with a Pod
        /// </summary>
        /// <param name="req"><see cref="DescribePodContainerListRequest"/></param>
        /// <returns><see cref="DescribePodContainerListResponse"/></returns>
        public Task<DescribePodContainerListResponse> DescribePodContainerList(DescribePodContainerListRequest req)
        {
            return InternalRequestAsync<DescribePodContainerListResponse>(req, "DescribePodContainerList");
        }

        /// <summary>
        /// Query the container list associated with a Pod
        /// </summary>
        /// <param name="req"><see cref="DescribePodContainerListRequest"/></param>
        /// <returns><see cref="DescribePodContainerListResponse"/></returns>
        public DescribePodContainerListResponse DescribePodContainerListSync(DescribePodContainerListRequest req)
        {
            return InternalRequestAsync<DescribePodContainerListResponse>(req, "DescribePodContainerList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Port detection list
        /// </summary>
        /// <param name="req"><see cref="DescribePortDetectListRequest"/></param>
        /// <returns><see cref="DescribePortDetectListResponse"/></returns>
        public Task<DescribePortDetectListResponse> DescribePortDetectList(DescribePortDetectListRequest req)
        {
            return InternalRequestAsync<DescribePortDetectListResponse>(req, "DescribePortDetectList");
        }

        /// <summary>
        /// Port detection list
        /// </summary>
        /// <param name="req"><see cref="DescribePortDetectListRequest"/></param>
        /// <returns><see cref="DescribePortDetectListResponse"/></returns>
        public DescribePortDetectListResponse DescribePortDetectListSync(DescribePortDetectListRequest req)
        {
            return InternalRequestAsync<DescribePortDetectListResponse>(req, "DescribePortDetectList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the number of port scanning tasks under the current account.
        /// </summary>
        /// <param name="req"><see cref="DescribePortScanTaskCountRequest"/></param>
        /// <returns><see cref="DescribePortScanTaskCountResponse"/></returns>
        public Task<DescribePortScanTaskCountResponse> DescribePortScanTaskCount(DescribePortScanTaskCountRequest req)
        {
            return InternalRequestAsync<DescribePortScanTaskCountResponse>(req, "DescribePortScanTaskCount");
        }

        /// <summary>
        /// Query the number of port scanning tasks under the current account.
        /// </summary>
        /// <param name="req"><see cref="DescribePortScanTaskCountRequest"/></param>
        /// <returns><see cref="DescribePortScanTaskCountResponse"/></returns>
        public DescribePortScanTaskCountResponse DescribePortScanTaskCountSync(DescribePortScanTaskCountRequest req)
        {
            return InternalRequestAsync<DescribePortScanTaskCountResponse>(req, "DescribePortScanTaskCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the global configuration for anti-uninstallation.
        /// </summary>
        /// <param name="req"><see cref="DescribePreventUninstallGlobalConfRequest"/></param>
        /// <returns><see cref="DescribePreventUninstallGlobalConfResponse"/></returns>
        public Task<DescribePreventUninstallGlobalConfResponse> DescribePreventUninstallGlobalConf(DescribePreventUninstallGlobalConfRequest req)
        {
            return InternalRequestAsync<DescribePreventUninstallGlobalConfResponse>(req, "DescribePreventUninstallGlobalConf");
        }

        /// <summary>
        /// This API is used to obtain the global configuration for anti-uninstallation.
        /// </summary>
        /// <param name="req"><see cref="DescribePreventUninstallGlobalConfRequest"/></param>
        /// <returns><see cref="DescribePreventUninstallGlobalConfResponse"/></returns>
        public DescribePreventUninstallGlobalConfResponse DescribePreventUninstallGlobalConfSync(DescribePreventUninstallGlobalConfRequest req)
        {
            return InternalRequestAsync<DescribePreventUninstallGlobalConfResponse>(req, "DescribePreventUninstallGlobalConf")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retrieve the host list for uninstallation prevention.
        /// </summary>
        /// <param name="req"><see cref="DescribePreventUninstallHostRequest"/></param>
        /// <returns><see cref="DescribePreventUninstallHostResponse"/></returns>
        public Task<DescribePreventUninstallHostResponse> DescribePreventUninstallHost(DescribePreventUninstallHostRequest req)
        {
            return InternalRequestAsync<DescribePreventUninstallHostResponse>(req, "DescribePreventUninstallHost");
        }

        /// <summary>
        /// Retrieve the host list for uninstallation prevention.
        /// </summary>
        /// <param name="req"><see cref="DescribePreventUninstallHostRequest"/></param>
        /// <returns><see cref="DescribePreventUninstallHostResponse"/></returns>
        public DescribePreventUninstallHostResponse DescribePreventUninstallHostSync(DescribePreventUninstallHostRequest req)
        {
            return InternalRequestAsync<DescribePreventUninstallHostResponse>(req, "DescribePreventUninstallHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain the global configuration for process protection.
        /// </summary>
        /// <param name="req"><see cref="DescribeProcessDaemonGlobalConfRequest"/></param>
        /// <returns><see cref="DescribeProcessDaemonGlobalConfResponse"/></returns>
        public Task<DescribeProcessDaemonGlobalConfResponse> DescribeProcessDaemonGlobalConf(DescribeProcessDaemonGlobalConfRequest req)
        {
            return InternalRequestAsync<DescribeProcessDaemonGlobalConfResponse>(req, "DescribeProcessDaemonGlobalConf");
        }

        /// <summary>
        /// Obtain the global configuration for process protection.
        /// </summary>
        /// <param name="req"><see cref="DescribeProcessDaemonGlobalConfRequest"/></param>
        /// <returns><see cref="DescribeProcessDaemonGlobalConfResponse"/></returns>
        public DescribeProcessDaemonGlobalConfResponse DescribeProcessDaemonGlobalConfSync(DescribeProcessDaemonGlobalConfRequest req)
        {
            return InternalRequestAsync<DescribeProcessDaemonGlobalConfResponse>(req, "DescribeProcessDaemonGlobalConf")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get the process daemon host list.
        /// </summary>
        /// <param name="req"><see cref="DescribeProcessDaemonHostRequest"/></param>
        /// <returns><see cref="DescribeProcessDaemonHostResponse"/></returns>
        public Task<DescribeProcessDaemonHostResponse> DescribeProcessDaemonHost(DescribeProcessDaemonHostRequest req)
        {
            return InternalRequestAsync<DescribeProcessDaemonHostResponse>(req, "DescribeProcessDaemonHost");
        }

        /// <summary>
        /// Get the process daemon host list.
        /// </summary>
        /// <param name="req"><see cref="DescribeProcessDaemonHostRequest"/></param>
        /// <returns><see cref="DescribeProcessDaemonHostResponse"/></returns>
        public DescribeProcessDaemonHostResponse DescribeProcessDaemonHostSync(DescribeProcessDaemonHostRequest req)
        {
            return InternalRequestAsync<DescribeProcessDaemonHostResponse>(req, "DescribeProcessDaemonHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Public network asset
        /// </summary>
        /// <param name="req"><see cref="DescribePublicCloudAssetsRequest"/></param>
        /// <returns><see cref="DescribePublicCloudAssetsResponse"/></returns>
        public Task<DescribePublicCloudAssetsResponse> DescribePublicCloudAssets(DescribePublicCloudAssetsRequest req)
        {
            return InternalRequestAsync<DescribePublicCloudAssetsResponse>(req, "DescribePublicCloudAssets");
        }

        /// <summary>
        /// Public network asset
        /// </summary>
        /// <param name="req"><see cref="DescribePublicCloudAssetsRequest"/></param>
        /// <returns><see cref="DescribePublicCloudAssetsResponse"/></returns>
        public DescribePublicCloudAssetsResponse DescribePublicCloudAssetsSync(DescribePublicCloudAssetsRequest req)
        {
            return InternalRequestAsync<DescribePublicCloudAssetsResponse>(req, "DescribePublicCloudAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// IP Public Network List
        /// </summary>
        /// <param name="req"><see cref="DescribePublicIpAssetsRequest"/></param>
        /// <returns><see cref="DescribePublicIpAssetsResponse"/></returns>
        public Task<DescribePublicIpAssetsResponse> DescribePublicIpAssets(DescribePublicIpAssetsRequest req)
        {
            return InternalRequestAsync<DescribePublicIpAssetsResponse>(req, "DescribePublicIpAssets");
        }

        /// <summary>
        /// IP Public Network List
        /// </summary>
        /// <param name="req"><see cref="DescribePublicIpAssetsRequest"/></param>
        /// <returns><see cref="DescribePublicIpAssetsResponse"/></returns>
        public DescribePublicIpAssetsResponse DescribePublicIpAssetsSync(DescribePublicIpAssetsRequest req)
        {
            return InternalRequestAsync<DescribePublicIpAssetsResponse>(req, "DescribePublicIpAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the authorization list for application protection.
        /// </summary>
        /// <param name="req"><see cref="DescribeRaspLicenseListRequest"/></param>
        /// <returns><see cref="DescribeRaspLicenseListResponse"/></returns>
        public Task<DescribeRaspLicenseListResponse> DescribeRaspLicenseList(DescribeRaspLicenseListRequest req)
        {
            return InternalRequestAsync<DescribeRaspLicenseListResponse>(req, "DescribeRaspLicenseList");
        }

        /// <summary>
        /// This API is used to query the authorization list for application protection.
        /// </summary>
        /// <param name="req"><see cref="DescribeRaspLicenseListRequest"/></param>
        /// <returns><see cref="DescribeRaspLicenseListResponse"/></returns>
        public DescribeRaspLicenseListResponse DescribeRaspLicenseListSync(DescribeRaspLicenseListRequest req)
        {
            return InternalRequestAsync<DescribeRaspLicenseListResponse>(req, "DescribeRaspLicenseList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query repository overview
        /// </summary>
        /// <param name="req"><see cref="DescribeRegistryOverviewRequest"/></param>
        /// <returns><see cref="DescribeRegistryOverviewResponse"/></returns>
        public Task<DescribeRegistryOverviewResponse> DescribeRegistryOverview(DescribeRegistryOverviewRequest req)
        {
            return InternalRequestAsync<DescribeRegistryOverviewResponse>(req, "DescribeRegistryOverview");
        }

        /// <summary>
        /// Query repository overview
        /// </summary>
        /// <param name="req"><see cref="DescribeRegistryOverviewRequest"/></param>
        /// <returns><see cref="DescribeRegistryOverviewResponse"/></returns>
        public DescribeRegistryOverviewResponse DescribeRegistryOverviewSync(DescribeRegistryOverviewRequest req)
        {
            return InternalRequestAsync<DescribeRegistryOverviewResponse>(req, "DescribeRegistryOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the region list of an image repository.
        /// </summary>
        /// <param name="req"><see cref="DescribeRegistryRegionListRequest"/></param>
        /// <returns><see cref="DescribeRegistryRegionListResponse"/></returns>
        public Task<DescribeRegistryRegionListResponse> DescribeRegistryRegionList(DescribeRegistryRegionListRequest req)
        {
            return InternalRequestAsync<DescribeRegistryRegionListResponse>(req, "DescribeRegistryRegionList");
        }

        /// <summary>
        /// Queries the region list of an image repository.
        /// </summary>
        /// <param name="req"><see cref="DescribeRegistryRegionListRequest"/></param>
        /// <returns><see cref="DescribeRegistryRegionListResponse"/></returns>
        public DescribeRegistryRegionListResponse DescribeRegistryRegionListSync(DescribeRegistryRegionListRequest req)
        {
            return InternalRequestAsync<DescribeRegistryRegionListResponse>(req, "DescribeRegistryRegionList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Repository Image List
        /// </summary>
        /// <param name="req"><see cref="DescribeRepositoryImageAssetsRequest"/></param>
        /// <returns><see cref="DescribeRepositoryImageAssetsResponse"/></returns>
        public Task<DescribeRepositoryImageAssetsResponse> DescribeRepositoryImageAssets(DescribeRepositoryImageAssetsRequest req)
        {
            return InternalRequestAsync<DescribeRepositoryImageAssetsResponse>(req, "DescribeRepositoryImageAssets");
        }

        /// <summary>
        /// Repository Image List
        /// </summary>
        /// <param name="req"><see cref="DescribeRepositoryImageAssetsRequest"/></param>
        /// <returns><see cref="DescribeRepositoryImageAssetsResponse"/></returns>
        public DescribeRepositoryImageAssetsResponse DescribeRepositoryImageAssetsSync(DescribeRepositoryImageAssetsRequest req)
        {
            return InternalRequestAsync<DescribeRepositoryImageAssetsResponse>(req, "DescribeRepositoryImageAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the intranet alert and asset scope configuration for rebound Shell.
        /// </summary>
        /// <param name="req"><see cref="DescribeReverseShellSystemPolicyConfigRequest"/></param>
        /// <returns><see cref="DescribeReverseShellSystemPolicyConfigResponse"/></returns>
        public Task<DescribeReverseShellSystemPolicyConfigResponse> DescribeReverseShellSystemPolicyConfig(DescribeReverseShellSystemPolicyConfigRequest req)
        {
            return InternalRequestAsync<DescribeReverseShellSystemPolicyConfigResponse>(req, "DescribeReverseShellSystemPolicyConfig");
        }

        /// <summary>
        /// This API is used to query the intranet alert and asset scope configuration for rebound Shell.
        /// </summary>
        /// <param name="req"><see cref="DescribeReverseShellSystemPolicyConfigRequest"/></param>
        /// <returns><see cref="DescribeReverseShellSystemPolicyConfigResponse"/></returns>
        public DescribeReverseShellSystemPolicyConfigResponse DescribeReverseShellSystemPolicyConfigSync(DescribeReverseShellSystemPolicyConfigRequest req)
        {
            return InternalRequestAsync<DescribeReverseShellSystemPolicyConfigResponse>(req, "DescribeReverseShellSystemPolicyConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the risk call record list.
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCallRecordRequest"/></param>
        /// <returns><see cref="DescribeRiskCallRecordResponse"/></returns>
        public Task<DescribeRiskCallRecordResponse> DescribeRiskCallRecord(DescribeRiskCallRecordRequest req)
        {
            return InternalRequestAsync<DescribeRiskCallRecordResponse>(req, "DescribeRiskCallRecord");
        }

        /// <summary>
        /// This API is used to obtain the risk call record list.
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCallRecordRequest"/></param>
        /// <returns><see cref="DescribeRiskCallRecordResponse"/></returns>
        public DescribeRiskCallRecordResponse DescribeRiskCallRecordSync(DescribeRiskCallRecordRequest req)
        {
            return InternalRequestAsync<DescribeRiskCallRecordResponse>(req, "DescribeRiskCallRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain Configuration Risk List from Asset's Perspective
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterAssetViewCFGRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterAssetViewCFGRiskListResponse"/></returns>
        public Task<DescribeRiskCenterAssetViewCFGRiskListResponse> DescribeRiskCenterAssetViewCFGRiskList(DescribeRiskCenterAssetViewCFGRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterAssetViewCFGRiskListResponse>(req, "DescribeRiskCenterAssetViewCFGRiskList");
        }

        /// <summary>
        /// Obtain Configuration Risk List from Asset's Perspective
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterAssetViewCFGRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterAssetViewCFGRiskListResponse"/></returns>
        public DescribeRiskCenterAssetViewCFGRiskListResponse DescribeRiskCenterAssetViewCFGRiskListSync(DescribeRiskCenterAssetViewCFGRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterAssetViewCFGRiskListResponse>(req, "DescribeRiskCenterAssetViewCFGRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain Port Risk List from Asset's Perspective
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterAssetViewPortRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterAssetViewPortRiskListResponse"/></returns>
        public Task<DescribeRiskCenterAssetViewPortRiskListResponse> DescribeRiskCenterAssetViewPortRiskList(DescribeRiskCenterAssetViewPortRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterAssetViewPortRiskListResponse>(req, "DescribeRiskCenterAssetViewPortRiskList");
        }

        /// <summary>
        /// Obtain Port Risk List from Asset's Perspective
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterAssetViewPortRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterAssetViewPortRiskListResponse"/></returns>
        public DescribeRiskCenterAssetViewPortRiskListResponse DescribeRiskCenterAssetViewPortRiskListSync(DescribeRiskCenterAssetViewPortRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterAssetViewPortRiskListResponse>(req, "DescribeRiskCenterAssetViewPortRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain Vulnerability Risk List from Asset's Perspective
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterAssetViewVULRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterAssetViewVULRiskListResponse"/></returns>
        public Task<DescribeRiskCenterAssetViewVULRiskListResponse> DescribeRiskCenterAssetViewVULRiskList(DescribeRiskCenterAssetViewVULRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterAssetViewVULRiskListResponse>(req, "DescribeRiskCenterAssetViewVULRiskList");
        }

        /// <summary>
        /// Obtain Vulnerability Risk List from Asset's Perspective
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterAssetViewVULRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterAssetViewVULRiskListResponse"/></returns>
        public DescribeRiskCenterAssetViewVULRiskListResponse DescribeRiskCenterAssetViewVULRiskListSync(DescribeRiskCenterAssetViewVULRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterAssetViewVULRiskListResponse>(req, "DescribeRiskCenterAssetViewVULRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain Weak Password Risk List from Asset's Perspective
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterAssetViewWeakPasswordRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterAssetViewWeakPasswordRiskListResponse"/></returns>
        public Task<DescribeRiskCenterAssetViewWeakPasswordRiskListResponse> DescribeRiskCenterAssetViewWeakPasswordRiskList(DescribeRiskCenterAssetViewWeakPasswordRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterAssetViewWeakPasswordRiskListResponse>(req, "DescribeRiskCenterAssetViewWeakPasswordRiskList");
        }

        /// <summary>
        /// Obtain Weak Password Risk List from Asset's Perspective
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterAssetViewWeakPasswordRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterAssetViewWeakPasswordRiskListResponse"/></returns>
        public DescribeRiskCenterAssetViewWeakPasswordRiskListResponse DescribeRiskCenterAssetViewWeakPasswordRiskListSync(DescribeRiskCenterAssetViewWeakPasswordRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterAssetViewWeakPasswordRiskListResponse>(req, "DescribeRiskCenterAssetViewWeakPasswordRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain Configuration Risk List from Configuration's Perspective
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterCFGViewCFGRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterCFGViewCFGRiskListResponse"/></returns>
        public Task<DescribeRiskCenterCFGViewCFGRiskListResponse> DescribeRiskCenterCFGViewCFGRiskList(DescribeRiskCenterCFGViewCFGRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterCFGViewCFGRiskListResponse>(req, "DescribeRiskCenterCFGViewCFGRiskList");
        }

        /// <summary>
        /// Obtain Configuration Risk List from Configuration's Perspective
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterCFGViewCFGRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterCFGViewCFGRiskListResponse"/></returns>
        public DescribeRiskCenterCFGViewCFGRiskListResponse DescribeRiskCenterCFGViewCFGRiskListSync(DescribeRiskCenterCFGViewCFGRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterCFGViewCFGRiskListResponse>(req, "DescribeRiskCenterCFGViewCFGRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain Port Risk List from Port's Perspective
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterPortViewPortRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterPortViewPortRiskListResponse"/></returns>
        public Task<DescribeRiskCenterPortViewPortRiskListResponse> DescribeRiskCenterPortViewPortRiskList(DescribeRiskCenterPortViewPortRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterPortViewPortRiskListResponse>(req, "DescribeRiskCenterPortViewPortRiskList");
        }

        /// <summary>
        /// Obtain Port Risk List from Port's Perspective
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterPortViewPortRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterPortViewPortRiskListResponse"/></returns>
        public DescribeRiskCenterPortViewPortRiskListResponse DescribeRiskCenterPortViewPortRiskListSync(DescribeRiskCenterPortViewPortRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterPortViewPortRiskListResponse>(req, "DescribeRiskCenterPortViewPortRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Sample code for obtaining risk trend analysis
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterRiskTrendAnalysisRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterRiskTrendAnalysisResponse"/></returns>
        public Task<DescribeRiskCenterRiskTrendAnalysisResponse> DescribeRiskCenterRiskTrendAnalysis(DescribeRiskCenterRiskTrendAnalysisRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterRiskTrendAnalysisResponse>(req, "DescribeRiskCenterRiskTrendAnalysis");
        }

        /// <summary>
        /// Sample code for obtaining risk trend analysis
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterRiskTrendAnalysisRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterRiskTrendAnalysisResponse"/></returns>
        public DescribeRiskCenterRiskTrendAnalysisResponse DescribeRiskCenterRiskTrendAnalysisSync(DescribeRiskCenterRiskTrendAnalysisRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterRiskTrendAnalysisResponse>(req, "DescribeRiskCenterRiskTrendAnalysis")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain Risk Service List
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterServerRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterServerRiskListResponse"/></returns>
        public Task<DescribeRiskCenterServerRiskListResponse> DescribeRiskCenterServerRiskList(DescribeRiskCenterServerRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterServerRiskListResponse>(req, "DescribeRiskCenterServerRiskList");
        }

        /// <summary>
        /// Obtain Risk Service List
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterServerRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterServerRiskListResponse"/></returns>
        public DescribeRiskCenterServerRiskListResponse DescribeRiskCenterServerRiskListSync(DescribeRiskCenterServerRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterServerRiskListResponse>(req, "DescribeRiskCenterServerRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain Vulnerability Risk List from Vulnerability's Perspective
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterVULViewVULRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterVULViewVULRiskListResponse"/></returns>
        public Task<DescribeRiskCenterVULViewVULRiskListResponse> DescribeRiskCenterVULViewVULRiskList(DescribeRiskCenterVULViewVULRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterVULViewVULRiskListResponse>(req, "DescribeRiskCenterVULViewVULRiskList");
        }

        /// <summary>
        /// Obtain Vulnerability Risk List from Vulnerability's Perspective
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterVULViewVULRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterVULViewVULRiskListResponse"/></returns>
        public DescribeRiskCenterVULViewVULRiskListResponse DescribeRiskCenterVULViewVULRiskListSync(DescribeRiskCenterVULViewVULRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterVULViewVULRiskListResponse>(req, "DescribeRiskCenterVULViewVULRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain Content Risk List
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterWebsiteRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterWebsiteRiskListResponse"/></returns>
        public Task<DescribeRiskCenterWebsiteRiskListResponse> DescribeRiskCenterWebsiteRiskList(DescribeRiskCenterWebsiteRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterWebsiteRiskListResponse>(req, "DescribeRiskCenterWebsiteRiskList");
        }

        /// <summary>
        /// Obtain Content Risk List
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterWebsiteRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterWebsiteRiskListResponse"/></returns>
        public DescribeRiskCenterWebsiteRiskListResponse DescribeRiskCenterWebsiteRiskListSync(DescribeRiskCenterWebsiteRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterWebsiteRiskListResponse>(req, "DescribeRiskCenterWebsiteRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Sample risk detail list
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskDetailListRequest"/></param>
        /// <returns><see cref="DescribeRiskDetailListResponse"/></returns>
        public Task<DescribeRiskDetailListResponse> DescribeRiskDetailList(DescribeRiskDetailListRequest req)
        {
            return InternalRequestAsync<DescribeRiskDetailListResponse>(req, "DescribeRiskDetailList");
        }

        /// <summary>
        /// Sample risk detail list
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskDetailListRequest"/></param>
        /// <returns><see cref="DescribeRiskDetailListResponse"/></returns>
        public DescribeRiskDetailListResponse DescribeRiskDetailListSync(DescribeRiskDetailListRequest req)
        {
            return InternalRequestAsync<DescribeRiskDetailListResponse>(req, "DescribeRiskDetailList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Sample code for querying risk rule details
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskRuleDetailRequest"/></param>
        /// <returns><see cref="DescribeRiskRuleDetailResponse"/></returns>
        public Task<DescribeRiskRuleDetailResponse> DescribeRiskRuleDetail(DescribeRiskRuleDetailRequest req)
        {
            return InternalRequestAsync<DescribeRiskRuleDetailResponse>(req, "DescribeRiskRuleDetail");
        }

        /// <summary>
        /// Sample code for querying risk rule details
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskRuleDetailRequest"/></param>
        /// <returns><see cref="DescribeRiskRuleDetailResponse"/></returns>
        public DescribeRiskRuleDetailResponse DescribeRiskRuleDetailSync(DescribeRiskRuleDetailRequest req)
        {
            return InternalRequestAsync<DescribeRiskRuleDetailResponse>(req, "DescribeRiskRuleDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Illustrative example of the advanced configuration risk rule list
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskRulesRequest"/></param>
        /// <returns><see cref="DescribeRiskRulesResponse"/></returns>
        public Task<DescribeRiskRulesResponse> DescribeRiskRules(DescribeRiskRulesRequest req)
        {
            return InternalRequestAsync<DescribeRiskRulesResponse>(req, "DescribeRiskRules");
        }

        /// <summary>
        /// Illustrative example of the advanced configuration risk rule list
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskRulesRequest"/></param>
        /// <returns><see cref="DescribeRiskRulesResponse"/></returns>
        public DescribeRiskRulesResponse DescribeRiskRulesSync(DescribeRiskRulesRequest req)
        {
            return InternalRequestAsync<DescribeRiskRulesResponse>(req, "DescribeRiskRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get the periodic schedule for risk scans
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskScanCronConfigRequest"/></param>
        /// <returns><see cref="DescribeRiskScanCronConfigResponse"/></returns>
        public Task<DescribeRiskScanCronConfigResponse> DescribeRiskScanCronConfig(DescribeRiskScanCronConfigRequest req)
        {
            return InternalRequestAsync<DescribeRiskScanCronConfigResponse>(req, "DescribeRiskScanCronConfig");
        }

        /// <summary>
        /// Get the periodic schedule for risk scans
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskScanCronConfigRequest"/></param>
        /// <returns><see cref="DescribeRiskScanCronConfigResponse"/></returns>
        public DescribeRiskScanCronConfigResponse DescribeRiskScanCronConfigSync(DescribeRiskScanCronConfigRequest req)
        {
            return InternalRequestAsync<DescribeRiskScanCronConfigResponse>(req, "DescribeRiskScanCronConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the alias list of a specified SCF function.
        /// </summary>
        /// <param name="req"><see cref="DescribeSCFAliasListRequest"/></param>
        /// <returns><see cref="DescribeSCFAliasListResponse"/></returns>
        public Task<DescribeSCFAliasListResponse> DescribeSCFAliasList(DescribeSCFAliasListRequest req)
        {
            return InternalRequestAsync<DescribeSCFAliasListResponse>(req, "DescribeSCFAliasList");
        }

        /// <summary>
        /// Queries the alias list of a specified SCF function.
        /// </summary>
        /// <param name="req"><see cref="DescribeSCFAliasListRequest"/></param>
        /// <returns><see cref="DescribeSCFAliasListResponse"/></returns>
        public DescribeSCFAliasListResponse DescribeSCFAliasListSync(DescribeSCFAliasListRequest req)
        {
            return InternalRequestAsync<DescribeSCFAliasListResponse>(req, "DescribeSCFAliasList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the list of SCF functions in the specified namespace. Only functions of the Event trigger type are returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeSCFFunctionListRequest"/></param>
        /// <returns><see cref="DescribeSCFFunctionListResponse"/></returns>
        public Task<DescribeSCFFunctionListResponse> DescribeSCFFunctionList(DescribeSCFFunctionListRequest req)
        {
            return InternalRequestAsync<DescribeSCFFunctionListResponse>(req, "DescribeSCFFunctionList");
        }

        /// <summary>
        /// Query the list of SCF functions in the specified namespace. Only functions of the Event trigger type are returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeSCFFunctionListRequest"/></param>
        /// <returns><see cref="DescribeSCFFunctionListResponse"/></returns>
        public DescribeSCFFunctionListResponse DescribeSCFFunctionListSync(DescribeSCFFunctionListRequest req)
        {
            return InternalRequestAsync<DescribeSCFFunctionListResponse>(req, "DescribeSCFFunctionList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the version list of a specified SCF function.
        /// </summary>
        /// <param name="req"><see cref="DescribeSCFFunctionVersionListRequest"/></param>
        /// <returns><see cref="DescribeSCFFunctionVersionListResponse"/></returns>
        public Task<DescribeSCFFunctionVersionListResponse> DescribeSCFFunctionVersionList(DescribeSCFFunctionVersionListRequest req)
        {
            return InternalRequestAsync<DescribeSCFFunctionVersionListResponse>(req, "DescribeSCFFunctionVersionList");
        }

        /// <summary>
        /// Queries the version list of a specified SCF function.
        /// </summary>
        /// <param name="req"><see cref="DescribeSCFFunctionVersionListRequest"/></param>
        /// <returns><see cref="DescribeSCFFunctionVersionListResponse"/></returns>
        public DescribeSCFFunctionVersionListResponse DescribeSCFFunctionVersionListSync(DescribeSCFFunctionVersionListRequest req)
        {
            return InternalRequestAsync<DescribeSCFFunctionVersionListResponse>(req, "DescribeSCFFunctionVersionList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the namespace list of SCF in the designated region for the current user.
        /// </summary>
        /// <param name="req"><see cref="DescribeSCFNamespaceListRequest"/></param>
        /// <returns><see cref="DescribeSCFNamespaceListResponse"/></returns>
        public Task<DescribeSCFNamespaceListResponse> DescribeSCFNamespaceList(DescribeSCFNamespaceListRequest req)
        {
            return InternalRequestAsync<DescribeSCFNamespaceListResponse>(req, "DescribeSCFNamespaceList");
        }

        /// <summary>
        /// Queries the namespace list of SCF in the designated region for the current user.
        /// </summary>
        /// <param name="req"><see cref="DescribeSCFNamespaceListRequest"/></param>
        /// <returns><see cref="DescribeSCFNamespaceListResponse"/></returns>
        public DescribeSCFNamespaceListResponse DescribeSCFNamespaceListSync(DescribeSCFNamespaceListRequest req)
        {
            return InternalRequestAsync<DescribeSCFNamespaceListResponse>(req, "DescribeSCFNamespaceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the ACL access control alarm log list by paging. It supports precise filtering of a single alarm by Filter.Name=ID for the details page scenario.
        /// </summary>
        /// <param name="req"><see cref="DescribeSandboxACLAlertListRequest"/></param>
        /// <returns><see cref="DescribeSandboxACLAlertListResponse"/></returns>
        public Task<DescribeSandboxACLAlertListResponse> DescribeSandboxACLAlertList(DescribeSandboxACLAlertListRequest req)
        {
            return InternalRequestAsync<DescribeSandboxACLAlertListResponse>(req, "DescribeSandboxACLAlertList");
        }

        /// <summary>
        /// This API is used to query the ACL access control alarm log list by paging. It supports precise filtering of a single alarm by Filter.Name=ID for the details page scenario.
        /// </summary>
        /// <param name="req"><see cref="DescribeSandboxACLAlertListRequest"/></param>
        /// <returns><see cref="DescribeSandboxACLAlertListResponse"/></returns>
        public DescribeSandboxACLAlertListResponse DescribeSandboxACLAlertListSync(DescribeSandboxACLAlertListRequest req)
        {
            return InternalRequestAsync<DescribeSandboxACLAlertListResponse>(req, "DescribeSandboxACLAlertList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the access control rule list for ACL users under the current tenant. Import Filter.Name=RuleID to query an individual rule precisely.
        /// </summary>
        /// <param name="req"><see cref="DescribeSandboxACLRuleListRequest"/></param>
        /// <returns><see cref="DescribeSandboxACLRuleListResponse"/></returns>
        public Task<DescribeSandboxACLRuleListResponse> DescribeSandboxACLRuleList(DescribeSandboxACLRuleListRequest req)
        {
            return InternalRequestAsync<DescribeSandboxACLRuleListResponse>(req, "DescribeSandboxACLRuleList");
        }

        /// <summary>
        /// This API is used to query the access control rule list for ACL users under the current tenant. Import Filter.Name=RuleID to query an individual rule precisely.
        /// </summary>
        /// <param name="req"><see cref="DescribeSandboxACLRuleListRequest"/></param>
        /// <returns><see cref="DescribeSandboxACLRuleListResponse"/></returns>
        public DescribeSandboxACLRuleListResponse DescribeSandboxACLRuleListSync(DescribeSandboxACLRuleListRequest req)
        {
            return InternalRequestAsync<DescribeSandboxACLRuleListResponse>(req, "DescribeSandboxACLRuleList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the traffic sandbox access control (ACL) system rule list. System rules are built into the CSIP platform and can be referenced by user rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeSandboxACLSystemRuleListRequest"/></param>
        /// <returns><see cref="DescribeSandboxACLSystemRuleListResponse"/></returns>
        public Task<DescribeSandboxACLSystemRuleListResponse> DescribeSandboxACLSystemRuleList(DescribeSandboxACLSystemRuleListRequest req)
        {
            return InternalRequestAsync<DescribeSandboxACLSystemRuleListResponse>(req, "DescribeSandboxACLSystemRuleList");
        }

        /// <summary>
        /// Queries the traffic sandbox access control (ACL) system rule list. System rules are built into the CSIP platform and can be referenced by user rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeSandboxACLSystemRuleListRequest"/></param>
        /// <returns><see cref="DescribeSandboxACLSystemRuleListResponse"/></returns>
        public DescribeSandboxACLSystemRuleListResponse DescribeSandboxACLSystemRuleListSync(DescribeSandboxACLSystemRuleListRequest req)
        {
            return InternalRequestAsync<DescribeSandboxACLSystemRuleListResponse>(req, "DescribeSandboxACLSystemRuleList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Paging query for the DLP data leakage alert log list. Supports precise filtering of a single alert by Filter.Name=ID for the details page scenario.
        /// </summary>
        /// <param name="req"><see cref="DescribeSandboxDLPAlertListRequest"/></param>
        /// <returns><see cref="DescribeSandboxDLPAlertListResponse"/></returns>
        public Task<DescribeSandboxDLPAlertListResponse> DescribeSandboxDLPAlertList(DescribeSandboxDLPAlertListRequest req)
        {
            return InternalRequestAsync<DescribeSandboxDLPAlertListResponse>(req, "DescribeSandboxDLPAlertList");
        }

        /// <summary>
        /// Paging query for the DLP data leakage alert log list. Supports precise filtering of a single alert by Filter.Name=ID for the details page scenario.
        /// </summary>
        /// <param name="req"><see cref="DescribeSandboxDLPAlertListRequest"/></param>
        /// <returns><see cref="DescribeSandboxDLPAlertListResponse"/></returns>
        public DescribeSandboxDLPAlertListResponse DescribeSandboxDLPAlertListSync(DescribeSandboxDLPAlertListRequest req)
        {
            return InternalRequestAsync<DescribeSandboxDLPAlertListResponse>(req, "DescribeSandboxDLPAlertList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the DLP user rule list of the current tenant. Input Filter.Name=RuleID to query an individual rule for the details page scenario.
        /// </summary>
        /// <param name="req"><see cref="DescribeSandboxDLPRuleListRequest"/></param>
        /// <returns><see cref="DescribeSandboxDLPRuleListResponse"/></returns>
        public Task<DescribeSandboxDLPRuleListResponse> DescribeSandboxDLPRuleList(DescribeSandboxDLPRuleListRequest req)
        {
            return InternalRequestAsync<DescribeSandboxDLPRuleListResponse>(req, "DescribeSandboxDLPRuleList");
        }

        /// <summary>
        /// Query the DLP user rule list of the current tenant. Input Filter.Name=RuleID to query an individual rule for the details page scenario.
        /// </summary>
        /// <param name="req"><see cref="DescribeSandboxDLPRuleListRequest"/></param>
        /// <returns><see cref="DescribeSandboxDLPRuleListResponse"/></returns>
        public DescribeSandboxDLPRuleListResponse DescribeSandboxDLPRuleListSync(DescribeSandboxDLPRuleListRequest req)
        {
            return InternalRequestAsync<DescribeSandboxDLPRuleListResponse>(req, "DescribeSandboxDLPRuleList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the traffic sandbox data leakage protection (DLP) system rule list. System rules are built into the CSIP platform and can be referenced by user rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeSandboxDLPSystemRuleListRequest"/></param>
        /// <returns><see cref="DescribeSandboxDLPSystemRuleListResponse"/></returns>
        public Task<DescribeSandboxDLPSystemRuleListResponse> DescribeSandboxDLPSystemRuleList(DescribeSandboxDLPSystemRuleListRequest req)
        {
            return InternalRequestAsync<DescribeSandboxDLPSystemRuleListResponse>(req, "DescribeSandboxDLPSystemRuleList");
        }

        /// <summary>
        /// Queries the traffic sandbox data leakage protection (DLP) system rule list. System rules are built into the CSIP platform and can be referenced by user rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeSandboxDLPSystemRuleListRequest"/></param>
        /// <returns><see cref="DescribeSandboxDLPSystemRuleListResponse"/></returns>
        public DescribeSandboxDLPSystemRuleListResponse DescribeSandboxDLPSystemRuleListSync(DescribeSandboxDLPSystemRuleListRequest req)
        {
            return InternalRequestAsync<DescribeSandboxDLPSystemRuleListResponse>(req, "DescribeSandboxDLPSystemRuleList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the command sandbox file rule list.
        /// </summary>
        /// <param name="req"><see cref="DescribeSandboxFileRuleListRequest"/></param>
        /// <returns><see cref="DescribeSandboxFileRuleListResponse"/></returns>
        public Task<DescribeSandboxFileRuleListResponse> DescribeSandboxFileRuleList(DescribeSandboxFileRuleListRequest req)
        {
            return InternalRequestAsync<DescribeSandboxFileRuleListResponse>(req, "DescribeSandboxFileRuleList");
        }

        /// <summary>
        /// Query the command sandbox file rule list.
        /// </summary>
        /// <param name="req"><see cref="DescribeSandboxFileRuleListRequest"/></param>
        /// <returns><see cref="DescribeSandboxFileRuleListResponse"/></returns>
        public DescribeSandboxFileRuleListResponse DescribeSandboxFileRuleListSync(DescribeSandboxFileRuleListRequest req)
        {
            return InternalRequestAsync<DescribeSandboxFileRuleListResponse>(req, "DescribeSandboxFileRuleList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Paging query for the LLM audit alarm log list. Supports precise filtering of a single alarm by Filter.Name=ID for the details page scenario.
        /// </summary>
        /// <param name="req"><see cref="DescribeSandboxLLMAuditAlertListRequest"/></param>
        /// <returns><see cref="DescribeSandboxLLMAuditAlertListResponse"/></returns>
        public Task<DescribeSandboxLLMAuditAlertListResponse> DescribeSandboxLLMAuditAlertList(DescribeSandboxLLMAuditAlertListRequest req)
        {
            return InternalRequestAsync<DescribeSandboxLLMAuditAlertListResponse>(req, "DescribeSandboxLLMAuditAlertList");
        }

        /// <summary>
        /// Paging query for the LLM audit alarm log list. Supports precise filtering of a single alarm by Filter.Name=ID for the details page scenario.
        /// </summary>
        /// <param name="req"><see cref="DescribeSandboxLLMAuditAlertListRequest"/></param>
        /// <returns><see cref="DescribeSandboxLLMAuditAlertListResponse"/></returns>
        public DescribeSandboxLLMAuditAlertListResponse DescribeSandboxLLMAuditAlertListSync(DescribeSandboxLLMAuditAlertListRequest req)
        {
            return InternalRequestAsync<DescribeSandboxLLMAuditAlertListResponse>(req, "DescribeSandboxLLMAuditAlertList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the LLM audit user rule list for the current tenant. LLM audit rules do not support user-defined content and can only refer to system rule composites. Import Filter.Name=RuleID for exact querying of an individual rule (for details page scenarios).
        /// </summary>
        /// <param name="req"><see cref="DescribeSandboxLLMAuditRuleListRequest"/></param>
        /// <returns><see cref="DescribeSandboxLLMAuditRuleListResponse"/></returns>
        public Task<DescribeSandboxLLMAuditRuleListResponse> DescribeSandboxLLMAuditRuleList(DescribeSandboxLLMAuditRuleListRequest req)
        {
            return InternalRequestAsync<DescribeSandboxLLMAuditRuleListResponse>(req, "DescribeSandboxLLMAuditRuleList");
        }

        /// <summary>
        /// Queries the LLM audit user rule list for the current tenant. LLM audit rules do not support user-defined content and can only refer to system rule composites. Import Filter.Name=RuleID for exact querying of an individual rule (for details page scenarios).
        /// </summary>
        /// <param name="req"><see cref="DescribeSandboxLLMAuditRuleListRequest"/></param>
        /// <returns><see cref="DescribeSandboxLLMAuditRuleListResponse"/></returns>
        public DescribeSandboxLLMAuditRuleListResponse DescribeSandboxLLMAuditRuleListSync(DescribeSandboxLLMAuditRuleListRequest req)
        {
            return InternalRequestAsync<DescribeSandboxLLMAuditRuleListResponse>(req, "DescribeSandboxLLMAuditRuleList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the rule list of the LLM audit system. System rules are built into the CSIP platform and originate from the LLM audit system rule base. They are split into two flat rule arrays by LLM reasoning protection and ToolCall protection and can be referenced by user rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeSandboxLLMAuditSystemRuleListRequest"/></param>
        /// <returns><see cref="DescribeSandboxLLMAuditSystemRuleListResponse"/></returns>
        public Task<DescribeSandboxLLMAuditSystemRuleListResponse> DescribeSandboxLLMAuditSystemRuleList(DescribeSandboxLLMAuditSystemRuleListRequest req)
        {
            return InternalRequestAsync<DescribeSandboxLLMAuditSystemRuleListResponse>(req, "DescribeSandboxLLMAuditSystemRuleList");
        }

        /// <summary>
        /// This API is used to query the rule list of the LLM audit system. System rules are built into the CSIP platform and originate from the LLM audit system rule base. They are split into two flat rule arrays by LLM reasoning protection and ToolCall protection and can be referenced by user rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeSandboxLLMAuditSystemRuleListRequest"/></param>
        /// <returns><see cref="DescribeSandboxLLMAuditSystemRuleListResponse"/></returns>
        public DescribeSandboxLLMAuditSystemRuleListResponse DescribeSandboxLLMAuditSystemRuleListSync(DescribeSandboxLLMAuditSystemRuleListRequest req)
        {
            return InternalRequestAsync<DescribeSandboxLLMAuditSystemRuleListResponse>(req, "DescribeSandboxLLMAuditSystemRuleList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain Scan Report List
        /// </summary>
        /// <param name="req"><see cref="DescribeScanReportListRequest"/></param>
        /// <returns><see cref="DescribeScanReportListResponse"/></returns>
        public Task<DescribeScanReportListResponse> DescribeScanReportList(DescribeScanReportListRequest req)
        {
            return InternalRequestAsync<DescribeScanReportListResponse>(req, "DescribeScanReportList");
        }

        /// <summary>
        /// Obtain Scan Report List
        /// </summary>
        /// <param name="req"><see cref="DescribeScanReportListRequest"/></param>
        /// <returns><see cref="DescribeScanReportListResponse"/></returns>
        public DescribeScanReportListResponse DescribeScanReportListSync(DescribeScanReportListRequest req)
        {
            return InternalRequestAsync<DescribeScanReportListResponse>(req, "DescribeScanReportList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query result statistics of cloud boundary analysis scans.
        /// </summary>
        /// <param name="req"><see cref="DescribeScanStatisticRequest"/></param>
        /// <returns><see cref="DescribeScanStatisticResponse"/></returns>
        public Task<DescribeScanStatisticResponse> DescribeScanStatistic(DescribeScanStatisticRequest req)
        {
            return InternalRequestAsync<DescribeScanStatisticResponse>(req, "DescribeScanStatistic");
        }

        /// <summary>
        /// This API is used to query result statistics of cloud boundary analysis scans.
        /// </summary>
        /// <param name="req"><see cref="DescribeScanStatisticRequest"/></param>
        /// <returns><see cref="DescribeScanStatisticResponse"/></returns>
        public DescribeScanStatisticResponse DescribeScanStatisticSync(DescribeScanStatisticRequest req)
        {
            return InternalRequestAsync<DescribeScanStatisticResponse>(req, "DescribeScanStatistic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain Scan Task List
        /// </summary>
        /// <param name="req"><see cref="DescribeScanTaskListRequest"/></param>
        /// <returns><see cref="DescribeScanTaskListResponse"/></returns>
        public Task<DescribeScanTaskListResponse> DescribeScanTaskList(DescribeScanTaskListRequest req)
        {
            return InternalRequestAsync<DescribeScanTaskListResponse>(req, "DescribeScanTaskList");
        }

        /// <summary>
        /// Obtain Scan Task List
        /// </summary>
        /// <param name="req"><see cref="DescribeScanTaskListRequest"/></param>
        /// <returns><see cref="DescribeScanTaskListResponse"/></returns>
        public DescribeScanTaskListResponse DescribeScanTaskListSync(DescribeScanTaskListRequest req)
        {
            return InternalRequestAsync<DescribeScanTaskListResponse>(req, "DescribeScanTaskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the scan task record list.
        /// </summary>
        /// <param name="req"><see cref="DescribeScanTaskRecordListRequest"/></param>
        /// <returns><see cref="DescribeScanTaskRecordListResponse"/></returns>
        public Task<DescribeScanTaskRecordListResponse> DescribeScanTaskRecordList(DescribeScanTaskRecordListRequest req)
        {
            return InternalRequestAsync<DescribeScanTaskRecordListResponse>(req, "DescribeScanTaskRecordList");
        }

        /// <summary>
        /// This API is used to query the scan task record list.
        /// </summary>
        /// <param name="req"><see cref="DescribeScanTaskRecordListRequest"/></param>
        /// <returns><see cref="DescribeScanTaskRecordListResponse"/></returns>
        public DescribeScanTaskRecordListResponse DescribeScanTaskRecordListSync(DescribeScanTaskRecordListRequest req)
        {
            return InternalRequestAsync<DescribeScanTaskRecordListResponse>(req, "DescribeScanTaskRecordList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the list of custom domain name endpoints for Tencent Cloud SCF
        /// </summary>
        /// <param name="req"><see cref="DescribeScfCustomDomainEndpointsRequest"/></param>
        /// <returns><see cref="DescribeScfCustomDomainEndpointsResponse"/></returns>
        public Task<DescribeScfCustomDomainEndpointsResponse> DescribeScfCustomDomainEndpoints(DescribeScfCustomDomainEndpointsRequest req)
        {
            return InternalRequestAsync<DescribeScfCustomDomainEndpointsResponse>(req, "DescribeScfCustomDomainEndpoints");
        }

        /// <summary>
        /// Query the list of custom domain name endpoints for Tencent Cloud SCF
        /// </summary>
        /// <param name="req"><see cref="DescribeScfCustomDomainEndpointsRequest"/></param>
        /// <returns><see cref="DescribeScfCustomDomainEndpointsResponse"/></returns>
        public DescribeScfCustomDomainEndpointsResponse DescribeScfCustomDomainEndpointsSync(DescribeScfCustomDomainEndpointsRequest req)
        {
            return InternalRequestAsync<DescribeScfCustomDomainEndpointsResponse>(req, "DescribeScfCustomDomainEndpoints")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query vulnerability information in the three-dimensional protection center.
        /// </summary>
        /// <param name="req"><see cref="DescribeSearchBugInfoRequest"/></param>
        /// <returns><see cref="DescribeSearchBugInfoResponse"/></returns>
        public Task<DescribeSearchBugInfoResponse> DescribeSearchBugInfo(DescribeSearchBugInfoRequest req)
        {
            return InternalRequestAsync<DescribeSearchBugInfoResponse>(req, "DescribeSearchBugInfo");
        }

        /// <summary>
        /// Query vulnerability information in the three-dimensional protection center.
        /// </summary>
        /// <param name="req"><see cref="DescribeSearchBugInfoRequest"/></param>
        /// <returns><see cref="DescribeSearchBugInfoResponse"/></returns>
        public DescribeSearchBugInfoResponse DescribeSearchBugInfoSync(DescribeSearchBugInfoRequest req)
        {
            return InternalRequestAsync<DescribeSearchBugInfoResponse>(req, "DescribeSearchBugInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the security group rules correspond to the specified security group ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupPolicyRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupPolicyResponse"/></returns>
        public Task<DescribeSecurityGroupPolicyResponse> DescribeSecurityGroupPolicy(DescribeSecurityGroupPolicyRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupPolicyResponse>(req, "DescribeSecurityGroupPolicy");
        }

        /// <summary>
        /// Query the security group rules correspond to the specified security group ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupPolicyRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupPolicyResponse"/></returns>
        public DescribeSecurityGroupPolicyResponse DescribeSecurityGroupPolicySync(DescribeSecurityGroupPolicyRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupPolicyResponse>(req, "DescribeSecurityGroupPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain security risk trends and return the daily number of risks grouped by dimension.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityRiskTrendRequest"/></param>
        /// <returns><see cref="DescribeSecurityRiskTrendResponse"/></returns>
        public Task<DescribeSecurityRiskTrendResponse> DescribeSecurityRiskTrend(DescribeSecurityRiskTrendRequest req)
        {
            return InternalRequestAsync<DescribeSecurityRiskTrendResponse>(req, "DescribeSecurityRiskTrend");
        }

        /// <summary>
        /// This API is used to obtain security risk trends and return the daily number of risks grouped by dimension.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityRiskTrendRequest"/></param>
        /// <returns><see cref="DescribeSecurityRiskTrendResponse"/></returns>
        public DescribeSecurityRiskTrendResponse DescribeSecurityRiskTrendSync(DescribeSecurityRiskTrendRequest req)
        {
            return InternalRequestAsync<DescribeSecurityRiskTrendResponse>(req, "DescribeSecurityRiskTrend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the security score overview and real-time compute point deductions in each dimension and sub-item.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityScoreOverviewRequest"/></param>
        /// <returns><see cref="DescribeSecurityScoreOverviewResponse"/></returns>
        public Task<DescribeSecurityScoreOverviewResponse> DescribeSecurityScoreOverview(DescribeSecurityScoreOverviewRequest req)
        {
            return InternalRequestAsync<DescribeSecurityScoreOverviewResponse>(req, "DescribeSecurityScoreOverview");
        }

        /// <summary>
        /// This API is used to obtain the security score overview and real-time compute point deductions in each dimension and sub-item.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityScoreOverviewRequest"/></param>
        /// <returns><see cref="DescribeSecurityScoreOverviewResponse"/></returns>
        public DescribeSecurityScoreOverviewResponse DescribeSecurityScoreOverviewSync(DescribeSecurityScoreOverviewRequest req)
        {
            return InternalRequestAsync<DescribeSecurityScoreOverviewResponse>(req, "DescribeSecurityScoreOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retrieve the security scoring rules for the current account. If no custom rules exist, return the built-in default.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityScoreRuleRequest"/></param>
        /// <returns><see cref="DescribeSecurityScoreRuleResponse"/></returns>
        public Task<DescribeSecurityScoreRuleResponse> DescribeSecurityScoreRule(DescribeSecurityScoreRuleRequest req)
        {
            return InternalRequestAsync<DescribeSecurityScoreRuleResponse>(req, "DescribeSecurityScoreRule");
        }

        /// <summary>
        /// Retrieve the security scoring rules for the current account. If no custom rules exist, return the built-in default.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityScoreRuleRequest"/></param>
        /// <returns><see cref="DescribeSecurityScoreRuleResponse"/></returns>
        public DescribeSecurityScoreRuleResponse DescribeSecurityScoreRuleSync(DescribeSecurityScoreRuleRequest req)
        {
            return InternalRequestAsync<DescribeSecurityScoreRuleResponse>(req, "DescribeSecurityScoreRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query Skill security detection alarm details, including local alarm information and engine real-time detection data.
        /// </summary>
        /// <param name="req"><see cref="DescribeSkillScanAlertDetailRequest"/></param>
        /// <returns><see cref="DescribeSkillScanAlertDetailResponse"/></returns>
        public Task<DescribeSkillScanAlertDetailResponse> DescribeSkillScanAlertDetail(DescribeSkillScanAlertDetailRequest req)
        {
            return InternalRequestAsync<DescribeSkillScanAlertDetailResponse>(req, "DescribeSkillScanAlertDetail");
        }

        /// <summary>
        /// This API is used to query Skill security detection alarm details, including local alarm information and engine real-time detection data.
        /// </summary>
        /// <param name="req"><see cref="DescribeSkillScanAlertDetailRequest"/></param>
        /// <returns><see cref="DescribeSkillScanAlertDetailResponse"/></returns>
        public DescribeSkillScanAlertDetailResponse DescribeSkillScanAlertDetailSync(DescribeSkillScanAlertDetailRequest req)
        {
            return InternalRequestAsync<DescribeSkillScanAlertDetailResponse>(req, "DescribeSkillScanAlertDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the Skill security detection alarm list with pagination, filtering, and sorting supported.
        /// </summary>
        /// <param name="req"><see cref="DescribeSkillScanAlertListRequest"/></param>
        /// <returns><see cref="DescribeSkillScanAlertListResponse"/></returns>
        public Task<DescribeSkillScanAlertListResponse> DescribeSkillScanAlertList(DescribeSkillScanAlertListRequest req)
        {
            return InternalRequestAsync<DescribeSkillScanAlertListResponse>(req, "DescribeSkillScanAlertList");
        }

        /// <summary>
        /// Queries the Skill security detection alarm list with pagination, filtering, and sorting supported.
        /// </summary>
        /// <param name="req"><see cref="DescribeSkillScanAlertListRequest"/></param>
        /// <returns><see cref="DescribeSkillScanAlertListResponse"/></returns>
        public DescribeSkillScanAlertListResponse DescribeSkillScanAlertListSync(DescribeSkillScanAlertListRequest req)
        {
            return InternalRequestAsync<DescribeSkillScanAlertListResponse>(req, "DescribeSkillScanAlertList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query Skill security detection billing information, including order status, total quota, consumed quota, expiration time, and payment mode. If no order exists, zero values are returned (only TimeNow and BetaEndTime). Trial orders are claimed through ModifyTrialStatus(Module=9), and official orders are created through the billing system.
        /// </summary>
        /// <param name="req"><see cref="DescribeSkillScanPayInfoRequest"/></param>
        /// <returns><see cref="DescribeSkillScanPayInfoResponse"/></returns>
        public Task<DescribeSkillScanPayInfoResponse> DescribeSkillScanPayInfo(DescribeSkillScanPayInfoRequest req)
        {
            return InternalRequestAsync<DescribeSkillScanPayInfoResponse>(req, "DescribeSkillScanPayInfo");
        }

        /// <summary>
        /// This API is used to query Skill security detection billing information, including order status, total quota, consumed quota, expiration time, and payment mode. If no order exists, zero values are returned (only TimeNow and BetaEndTime). Trial orders are claimed through ModifyTrialStatus(Module=9), and official orders are created through the billing system.
        /// </summary>
        /// <param name="req"><see cref="DescribeSkillScanPayInfoRequest"/></param>
        /// <returns><see cref="DescribeSkillScanPayInfoResponse"/></returns>
        public DescribeSkillScanPayInfoResponse DescribeSkillScanPayInfoSync(DescribeSkillScanPayInfoRequest req)
        {
            return InternalRequestAsync<DescribeSkillScanPayInfoResponse>(req, "DescribeSkillScanPayInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the security detection result of a skill. After calling CreateSkillScan successfully, use the returned ContentHash + EngineVersion to poll this API to obtain the result. We recommend polling for the first time 5 minutes after a successful upload. If detection is not completed, poll once every 1 minute afterward. The response uses the Status field to distinguish four statuses: detection completed (SUCCESS), detecting (SCANNING), no record (NOT_FOUND), and detection failed (FAILED). Note: Detection results are retained for 90 days. NOT_FOUND will be returned after they expire.
        /// </summary>
        /// <param name="req"><see cref="DescribeSkillScanResultRequest"/></param>
        /// <returns><see cref="DescribeSkillScanResultResponse"/></returns>
        public Task<DescribeSkillScanResultResponse> DescribeSkillScanResult(DescribeSkillScanResultRequest req)
        {
            return InternalRequestAsync<DescribeSkillScanResultResponse>(req, "DescribeSkillScanResult");
        }

        /// <summary>
        /// Queries the security detection result of a skill. After calling CreateSkillScan successfully, use the returned ContentHash + EngineVersion to poll this API to obtain the result. We recommend polling for the first time 5 minutes after a successful upload. If detection is not completed, poll once every 1 minute afterward. The response uses the Status field to distinguish four statuses: detection completed (SUCCESS), detecting (SCANNING), no record (NOT_FOUND), and detection failed (FAILED). Note: Detection results are retained for 90 days. NOT_FOUND will be returned after they expire.
        /// </summary>
        /// <param name="req"><see cref="DescribeSkillScanResultRequest"/></param>
        /// <returns><see cref="DescribeSkillScanResultResponse"/></returns>
        public DescribeSkillScanResultResponse DescribeSkillScanResultSync(DescribeSkillScanResultRequest req)
        {
            return InternalRequestAsync<DescribeSkillScanResultResponse>(req, "DescribeSkillScanResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retrieve the user access key asset list from an IP perspective.
        /// </summary>
        /// <param name="req"><see cref="DescribeSourceIPAssetRequest"/></param>
        /// <returns><see cref="DescribeSourceIPAssetResponse"/></returns>
        public Task<DescribeSourceIPAssetResponse> DescribeSourceIPAsset(DescribeSourceIPAssetRequest req)
        {
            return InternalRequestAsync<DescribeSourceIPAssetResponse>(req, "DescribeSourceIPAsset");
        }

        /// <summary>
        /// Retrieve the user access key asset list from an IP perspective.
        /// </summary>
        /// <param name="req"><see cref="DescribeSourceIPAssetRequest"/></param>
        /// <returns><see cref="DescribeSourceIPAssetResponse"/></returns>
        public DescribeSourceIPAssetResponse DescribeSourceIPAssetSync(DescribeSourceIPAssetRequest req)
        {
            return InternalRequestAsync<DescribeSourceIPAssetResponse>(req, "DescribeSourceIPAsset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query user access key asset list from source IP perspective.
        /// </summary>
        /// <param name="req"><see cref="DescribeSourceIPDetailRequest"/></param>
        /// <returns><see cref="DescribeSourceIPDetailResponse"/></returns>
        public Task<DescribeSourceIPDetailResponse> DescribeSourceIPDetail(DescribeSourceIPDetailRequest req)
        {
            return InternalRequestAsync<DescribeSourceIPDetailResponse>(req, "DescribeSourceIPDetail");
        }

        /// <summary>
        /// This API is used to query user access key asset list from source IP perspective.
        /// </summary>
        /// <param name="req"><see cref="DescribeSourceIPDetailRequest"/></param>
        /// <returns><see cref="DescribeSourceIPDetailResponse"/></returns>
        public DescribeSourceIPDetailResponse DescribeSourceIPDetailSync(DescribeSourceIPDetailRequest req)
        {
            return InternalRequestAsync<DescribeSourceIPDetailResponse>(req, "DescribeSourceIPDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the sub-account list of a group
        /// </summary>
        /// <param name="req"><see cref="DescribeSubUserInfoRequest"/></param>
        /// <returns><see cref="DescribeSubUserInfoResponse"/></returns>
        public Task<DescribeSubUserInfoResponse> DescribeSubUserInfo(DescribeSubUserInfoRequest req)
        {
            return InternalRequestAsync<DescribeSubUserInfoResponse>(req, "DescribeSubUserInfo");
        }

        /// <summary>
        /// Query the sub-account list of a group
        /// </summary>
        /// <param name="req"><see cref="DescribeSubUserInfoRequest"/></param>
        /// <returns><see cref="DescribeSubUserInfoResponse"/></returns>
        public DescribeSubUserInfoResponse DescribeSubUserInfoSync(DescribeSubUserInfoRequest req)
        {
            return InternalRequestAsync<DescribeSubUserInfoResponse>(req, "DescribeSubUserInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain Subnet List
        /// </summary>
        /// <param name="req"><see cref="DescribeSubnetAssetsRequest"/></param>
        /// <returns><see cref="DescribeSubnetAssetsResponse"/></returns>
        public Task<DescribeSubnetAssetsResponse> DescribeSubnetAssets(DescribeSubnetAssetsRequest req)
        {
            return InternalRequestAsync<DescribeSubnetAssetsResponse>(req, "DescribeSubnetAssets");
        }

        /// <summary>
        /// Obtain Subnet List
        /// </summary>
        /// <param name="req"><see cref="DescribeSubnetAssetsRequest"/></param>
        /// <returns><see cref="DescribeSubnetAssetsResponse"/></returns>
        public DescribeSubnetAssetsResponse DescribeSubnetAssetsSync(DescribeSubnetAssetsRequest req)
        {
            return InternalRequestAsync<DescribeSubnetAssetsResponse>(req, "DescribeSubnetAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the TCR instance list.
        /// </summary>
        /// <param name="req"><see cref="DescribeTCRInstanceListRequest"/></param>
        /// <returns><see cref="DescribeTCRInstanceListResponse"/></returns>
        public Task<DescribeTCRInstanceListResponse> DescribeTCRInstanceList(DescribeTCRInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeTCRInstanceListResponse>(req, "DescribeTCRInstanceList");
        }

        /// <summary>
        /// This API is used to obtain the TCR instance list.
        /// </summary>
        /// <param name="req"><see cref="DescribeTCRInstanceListRequest"/></param>
        /// <returns><see cref="DescribeTCRInstanceListResponse"/></returns>
        public DescribeTCRInstanceListResponse DescribeTCRInstanceListSync(DescribeTCRInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeTCRInstanceListResponse>(req, "DescribeTCRInstanceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Tagging policy enforcement asset list
        /// </summary>
        /// <param name="req"><see cref="DescribeTagRuleAssetsRequest"/></param>
        /// <returns><see cref="DescribeTagRuleAssetsResponse"/></returns>
        public Task<DescribeTagRuleAssetsResponse> DescribeTagRuleAssets(DescribeTagRuleAssetsRequest req)
        {
            return InternalRequestAsync<DescribeTagRuleAssetsResponse>(req, "DescribeTagRuleAssets");
        }

        /// <summary>
        /// Tagging policy enforcement asset list
        /// </summary>
        /// <param name="req"><see cref="DescribeTagRuleAssetsRequest"/></param>
        /// <returns><see cref="DescribeTagRuleAssetsResponse"/></returns>
        public DescribeTagRuleAssetsResponse DescribeTagRuleAssetsSync(DescribeTagRuleAssetsRequest req)
        {
            return InternalRequestAsync<DescribeTagRuleAssetsResponse>(req, "DescribeTagRuleAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain Task Scan Report List
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskLogListRequest"/></param>
        /// <returns><see cref="DescribeTaskLogListResponse"/></returns>
        public Task<DescribeTaskLogListResponse> DescribeTaskLogList(DescribeTaskLogListRequest req)
        {
            return InternalRequestAsync<DescribeTaskLogListResponse>(req, "DescribeTaskLogList");
        }

        /// <summary>
        /// Obtain Task Scan Report List
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskLogListRequest"/></param>
        /// <returns><see cref="DescribeTaskLogListResponse"/></returns>
        public DescribeTaskLogListResponse DescribeTaskLogListSync(DescribeTaskLogListRequest req)
        {
            return InternalRequestAsync<DescribeTaskLogListResponse>(req, "DescribeTaskLogList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain the Temporary Link for Report Download
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskLogURLRequest"/></param>
        /// <returns><see cref="DescribeTaskLogURLResponse"/></returns>
        public Task<DescribeTaskLogURLResponse> DescribeTaskLogURL(DescribeTaskLogURLRequest req)
        {
            return InternalRequestAsync<DescribeTaskLogURLResponse>(req, "DescribeTaskLogURL");
        }

        /// <summary>
        /// Obtain the Temporary Link for Report Download
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskLogURLRequest"/></param>
        /// <returns><see cref="DescribeTaskLogURLResponse"/></returns>
        public DescribeTaskLogURLResponse DescribeTaskLogURLSync(DescribeTaskLogURLRequest req)
        {
            return InternalRequestAsync<DescribeTaskLogURLResponse>(req, "DescribeTaskLogURL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain the pre-consumed quota for scans.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskPredictCostQuotaRequest"/></param>
        /// <returns><see cref="DescribeTaskPredictCostQuotaResponse"/></returns>
        public Task<DescribeTaskPredictCostQuotaResponse> DescribeTaskPredictCostQuota(DescribeTaskPredictCostQuotaRequest req)
        {
            return InternalRequestAsync<DescribeTaskPredictCostQuotaResponse>(req, "DescribeTaskPredictCostQuota");
        }

        /// <summary>
        /// Obtain the pre-consumed quota for scans.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskPredictCostQuotaRequest"/></param>
        /// <returns><see cref="DescribeTaskPredictCostQuotaResponse"/></returns>
        public DescribeTaskPredictCostQuotaResponse DescribeTaskPredictCostQuotaSync(DescribeTaskPredictCostQuotaRequest req)
        {
            return InternalRequestAsync<DescribeTaskPredictCostQuotaResponse>(req, "DescribeTaskPredictCostQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query TOP attack information
        /// </summary>
        /// <param name="req"><see cref="DescribeTopAttackInfoRequest"/></param>
        /// <returns><see cref="DescribeTopAttackInfoResponse"/></returns>
        public Task<DescribeTopAttackInfoResponse> DescribeTopAttackInfo(DescribeTopAttackInfoRequest req)
        {
            return InternalRequestAsync<DescribeTopAttackInfoResponse>(req, "DescribeTopAttackInfo");
        }

        /// <summary>
        /// Query TOP attack information
        /// </summary>
        /// <param name="req"><see cref="DescribeTopAttackInfoRequest"/></param>
        /// <returns><see cref="DescribeTopAttackInfoResponse"/></returns>
        public DescribeTopAttackInfoResponse DescribeTopAttackInfoSync(DescribeTopAttackInfoRequest req)
        {
            return InternalRequestAsync<DescribeTopAttackInfoResponse>(req, "DescribeTopAttackInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the behavior overview of user behavior analysis.
        /// </summary>
        /// <param name="req"><see cref="DescribeUebaBehaviorSummaryRequest"/></param>
        /// <returns><see cref="DescribeUebaBehaviorSummaryResponse"/></returns>
        public Task<DescribeUebaBehaviorSummaryResponse> DescribeUebaBehaviorSummary(DescribeUebaBehaviorSummaryRequest req)
        {
            return InternalRequestAsync<DescribeUebaBehaviorSummaryResponse>(req, "DescribeUebaBehaviorSummary");
        }

        /// <summary>
        /// Queries the behavior overview of user behavior analysis.
        /// </summary>
        /// <param name="req"><see cref="DescribeUebaBehaviorSummaryRequest"/></param>
        /// <returns><see cref="DescribeUebaBehaviorSummaryResponse"/></returns>
        public DescribeUebaBehaviorSummaryResponse DescribeUebaBehaviorSummarySync(DescribeUebaBehaviorSummaryRequest req)
        {
            return InternalRequestAsync<DescribeUebaBehaviorSummaryResponse>(req, "DescribeUebaBehaviorSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the list of user behavior analysis policies
        /// </summary>
        /// <param name="req"><see cref="DescribeUebaRuleRequest"/></param>
        /// <returns><see cref="DescribeUebaRuleResponse"/></returns>
        public Task<DescribeUebaRuleResponse> DescribeUebaRule(DescribeUebaRuleRequest req)
        {
            return InternalRequestAsync<DescribeUebaRuleResponse>(req, "DescribeUebaRule");
        }

        /// <summary>
        /// Query the list of user behavior analysis policies
        /// </summary>
        /// <param name="req"><see cref="DescribeUebaRuleRequest"/></param>
        /// <returns><see cref="DescribeUebaRuleResponse"/></returns>
        public DescribeUebaRuleResponse DescribeUebaRuleSync(DescribeUebaRuleRequest req)
        {
            return InternalRequestAsync<DescribeUebaRuleResponse>(req, "DescribeUebaRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the user overview of the user behavior analysis module.
        /// </summary>
        /// <param name="req"><see cref="DescribeUebaUserSummaryRequest"/></param>
        /// <returns><see cref="DescribeUebaUserSummaryResponse"/></returns>
        public Task<DescribeUebaUserSummaryResponse> DescribeUebaUserSummary(DescribeUebaUserSummaryRequest req)
        {
            return InternalRequestAsync<DescribeUebaUserSummaryResponse>(req, "DescribeUebaUserSummary");
        }

        /// <summary>
        /// This API is used to get the user overview of the user behavior analysis module.
        /// </summary>
        /// <param name="req"><see cref="DescribeUebaUserSummaryRequest"/></param>
        /// <returns><see cref="DescribeUebaUserSummaryResponse"/></returns>
        public DescribeUebaUserSummaryResponse DescribeUebaUserSummarySync(DescribeUebaUserSummaryRequest req)
        {
            return InternalRequestAsync<DescribeUebaUserSummaryResponse>(req, "DescribeUebaUserSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain AK information of the account
        /// </summary>
        /// <param name="req"><see cref="DescribeUserAKInfoListRequest"/></param>
        /// <returns><see cref="DescribeUserAKInfoListResponse"/></returns>
        public Task<DescribeUserAKInfoListResponse> DescribeUserAKInfoList(DescribeUserAKInfoListRequest req)
        {
            return InternalRequestAsync<DescribeUserAKInfoListResponse>(req, "DescribeUserAKInfoList");
        }

        /// <summary>
        /// Obtain AK information of the account
        /// </summary>
        /// <param name="req"><see cref="DescribeUserAKInfoListRequest"/></param>
        /// <returns><see cref="DescribeUserAKInfoListResponse"/></returns>
        public DescribeUserAKInfoListResponse DescribeUserAKInfoListSync(DescribeUserAKInfoListRequest req)
        {
            return InternalRequestAsync<DescribeUserAKInfoListResponse>(req, "DescribeUserAKInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain CSPM information of an account.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserCSPMInfoListRequest"/></param>
        /// <returns><see cref="DescribeUserCSPMInfoListResponse"/></returns>
        public Task<DescribeUserCSPMInfoListResponse> DescribeUserCSPMInfoList(DescribeUserCSPMInfoListRequest req)
        {
            return InternalRequestAsync<DescribeUserCSPMInfoListResponse>(req, "DescribeUserCSPMInfoList");
        }

        /// <summary>
        /// This API is used to obtain CSPM information of an account.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserCSPMInfoListRequest"/></param>
        /// <returns><see cref="DescribeUserCSPMInfoListResponse"/></returns>
        public DescribeUserCSPMInfoListResponse DescribeUserCSPMInfoListSync(DescribeUserCSPMInfoListRequest req)
        {
            return InternalRequestAsync<DescribeUserCSPMInfoListResponse>(req, "DescribeUserCSPMInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the account call record list.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserCallRecordRequest"/></param>
        /// <returns><see cref="DescribeUserCallRecordResponse"/></returns>
        public Task<DescribeUserCallRecordResponse> DescribeUserCallRecord(DescribeUserCallRecordRequest req)
        {
            return InternalRequestAsync<DescribeUserCallRecordResponse>(req, "DescribeUserCallRecord");
        }

        /// <summary>
        /// This API is used to obtain the account call record list.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserCallRecordRequest"/></param>
        /// <returns><see cref="DescribeUserCallRecordResponse"/></returns>
        public DescribeUserCallRecordResponse DescribeUserCallRecordSync(DescribeUserCallRecordRequest req)
        {
            return InternalRequestAsync<DescribeUserCallRecordResponse>(req, "DescribeUserCallRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get the dspm information list of an account
        /// </summary>
        /// <param name="req"><see cref="DescribeUserDspmInfoListRequest"/></param>
        /// <returns><see cref="DescribeUserDspmInfoListResponse"/></returns>
        public Task<DescribeUserDspmInfoListResponse> DescribeUserDspmInfoList(DescribeUserDspmInfoListRequest req)
        {
            return InternalRequestAsync<DescribeUserDspmInfoListResponse>(req, "DescribeUserDspmInfoList");
        }

        /// <summary>
        /// Get the dspm information list of an account
        /// </summary>
        /// <param name="req"><see cref="DescribeUserDspmInfoListRequest"/></param>
        /// <returns><see cref="DescribeUserDspmInfoListResponse"/></returns>
        public DescribeUserDspmInfoListResponse DescribeUserDspmInfoListSync(DescribeUserDspmInfoListRequest req)
        {
            return InternalRequestAsync<DescribeUserDspmInfoListResponse>(req, "DescribeUserDspmInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// CSPM quota information of a user
        /// </summary>
        /// <param name="req"><see cref="DescribeUserInfoRequest"/></param>
        /// <returns><see cref="DescribeUserInfoResponse"/></returns>
        public Task<DescribeUserInfoResponse> DescribeUserInfo(DescribeUserInfoRequest req)
        {
            return InternalRequestAsync<DescribeUserInfoResponse>(req, "DescribeUserInfo");
        }

        /// <summary>
        /// CSPM quota information of a user
        /// </summary>
        /// <param name="req"><see cref="DescribeUserInfoRequest"/></param>
        /// <returns><see cref="DescribeUserInfoResponse"/></returns>
        public DescribeUserInfoResponse DescribeUserInfoSync(DescribeUserInfoRequest req)
        {
            return InternalRequestAsync<DescribeUserInfoResponse>(req, "DescribeUserInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Vulnerability list in the risk center of the new security center
        /// </summary>
        /// <param name="req"><see cref="DescribeVULListRequest"/></param>
        /// <returns><see cref="DescribeVULListResponse"/></returns>
        public Task<DescribeVULListResponse> DescribeVULList(DescribeVULListRequest req)
        {
            return InternalRequestAsync<DescribeVULListResponse>(req, "DescribeVULList");
        }

        /// <summary>
        /// Vulnerability list in the risk center of the new security center
        /// </summary>
        /// <param name="req"><see cref="DescribeVULListRequest"/></param>
        /// <returns><see cref="DescribeVULListResponse"/></returns>
        public DescribeVULListResponse DescribeVULListSync(DescribeVULListRequest req)
        {
            return InternalRequestAsync<DescribeVULListResponse>(req, "DescribeVULList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query Vulnerability Risk Advanced Configuration
        /// </summary>
        /// <param name="req"><see cref="DescribeVULRiskAdvanceCFGListRequest"/></param>
        /// <returns><see cref="DescribeVULRiskAdvanceCFGListResponse"/></returns>
        public Task<DescribeVULRiskAdvanceCFGListResponse> DescribeVULRiskAdvanceCFGList(DescribeVULRiskAdvanceCFGListRequest req)
        {
            return InternalRequestAsync<DescribeVULRiskAdvanceCFGListResponse>(req, "DescribeVULRiskAdvanceCFGList");
        }

        /// <summary>
        /// Query Vulnerability Risk Advanced Configuration
        /// </summary>
        /// <param name="req"><see cref="DescribeVULRiskAdvanceCFGListRequest"/></param>
        /// <returns><see cref="DescribeVULRiskAdvanceCFGListResponse"/></returns>
        public DescribeVULRiskAdvanceCFGListResponse DescribeVULRiskAdvanceCFGListSync(DescribeVULRiskAdvanceCFGListRequest req)
        {
            return InternalRequestAsync<DescribeVULRiskAdvanceCFGListResponse>(req, "DescribeVULRiskAdvanceCFGList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retrieve vulnerability details
        /// </summary>
        /// <param name="req"><see cref="DescribeVULRiskDetailRequest"/></param>
        /// <returns><see cref="DescribeVULRiskDetailResponse"/></returns>
        public Task<DescribeVULRiskDetailResponse> DescribeVULRiskDetail(DescribeVULRiskDetailRequest req)
        {
            return InternalRequestAsync<DescribeVULRiskDetailResponse>(req, "DescribeVULRiskDetail");
        }

        /// <summary>
        /// Retrieve vulnerability details
        /// </summary>
        /// <param name="req"><see cref="DescribeVULRiskDetailRequest"/></param>
        /// <returns><see cref="DescribeVULRiskDetailResponse"/></returns>
        public DescribeVULRiskDetailResponse DescribeVULRiskDetailSync(DescribeVULRiskDetailRequest req)
        {
            return InternalRequestAsync<DescribeVULRiskDetailResponse>(req, "DescribeVULRiskDetail")
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
        /// Check whether the current user is eligible to claim vouchers for the designated promotion.
        /// </summary>
        /// <param name="req"><see cref="DescribeVoucherEligibilityRequest"/></param>
        /// <returns><see cref="DescribeVoucherEligibilityResponse"/></returns>
        public Task<DescribeVoucherEligibilityResponse> DescribeVoucherEligibility(DescribeVoucherEligibilityRequest req)
        {
            return InternalRequestAsync<DescribeVoucherEligibilityResponse>(req, "DescribeVoucherEligibility");
        }

        /// <summary>
        /// Check whether the current user is eligible to claim vouchers for the designated promotion.
        /// </summary>
        /// <param name="req"><see cref="DescribeVoucherEligibilityRequest"/></param>
        /// <returns><see cref="DescribeVoucherEligibilityResponse"/></returns>
        public DescribeVoucherEligibilityResponse DescribeVoucherEligibilitySync(DescribeVoucherEligibilityRequest req)
        {
            return InternalRequestAsync<DescribeVoucherEligibilityResponse>(req, "DescribeVoucherEligibility")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain VPC List
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcAssetsRequest"/></param>
        /// <returns><see cref="DescribeVpcAssetsResponse"/></returns>
        public Task<DescribeVpcAssetsResponse> DescribeVpcAssets(DescribeVpcAssetsRequest req)
        {
            return InternalRequestAsync<DescribeVpcAssetsResponse>(req, "DescribeVpcAssets");
        }

        /// <summary>
        /// Obtain VPC List
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcAssetsRequest"/></param>
        /// <returns><see cref="DescribeVpcAssetsResponse"/></returns>
        public DescribeVpcAssetsResponse DescribeVpcAssetsSync(DescribeVpcAssetsRequest req)
        {
            return InternalRequestAsync<DescribeVpcAssetsResponse>(req, "DescribeVpcAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the associated server of a vulnerable component.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulComponentRelateHostRequest"/></param>
        /// <returns><see cref="DescribeVulComponentRelateHostResponse"/></returns>
        public Task<DescribeVulComponentRelateHostResponse> DescribeVulComponentRelateHost(DescribeVulComponentRelateHostRequest req)
        {
            return InternalRequestAsync<DescribeVulComponentRelateHostResponse>(req, "DescribeVulComponentRelateHost");
        }

        /// <summary>
        /// This API is used to query the associated server of a vulnerable component.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulComponentRelateHostRequest"/></param>
        /// <returns><see cref="DescribeVulComponentRelateHostResponse"/></returns>
        public DescribeVulComponentRelateHostResponse DescribeVulComponentRelateHostSync(DescribeVulComponentRelateHostRequest req)
        {
            return InternalRequestAsync<DescribeVulComponentRelateHostResponse>(req, "DescribeVulComponentRelateHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of a specified vulnerability repair task, including detailed data such as remediation status and snapshot status for each host, and supports pagination and filtering.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulFixTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeVulFixTaskDetailResponse"/></returns>
        public Task<DescribeVulFixTaskDetailResponse> DescribeVulFixTaskDetail(DescribeVulFixTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeVulFixTaskDetailResponse>(req, "DescribeVulFixTaskDetail");
        }

        /// <summary>
        /// This API is used to query the details of a specified vulnerability repair task, including detailed data such as remediation status and snapshot status for each host, and supports pagination and filtering.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulFixTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeVulFixTaskDetailResponse"/></returns>
        public DescribeVulFixTaskDetailResponse DescribeVulFixTaskDetailSync(DescribeVulFixTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeVulFixTaskDetailResponse>(req, "DescribeVulFixTaskDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the vulnerability repair task record list with paging, support by conditional filtering such as remediation status and time range, and show summary information for each repair task.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulFixTaskListRequest"/></param>
        /// <returns><see cref="DescribeVulFixTaskListResponse"/></returns>
        public Task<DescribeVulFixTaskListResponse> DescribeVulFixTaskList(DescribeVulFixTaskListRequest req)
        {
            return InternalRequestAsync<DescribeVulFixTaskListResponse>(req, "DescribeVulFixTaskList");
        }

        /// <summary>
        /// This API is used to query the vulnerability repair task record list with paging, support by conditional filtering such as remediation status and time range, and show summary information for each repair task.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulFixTaskListRequest"/></param>
        /// <returns><see cref="DescribeVulFixTaskListResponse"/></returns>
        public DescribeVulFixTaskListResponse DescribeVulFixTaskListSync(DescribeVulFixTaskListRequest req)
        {
            return InternalRequestAsync<DescribeVulFixTaskListResponse>(req, "DescribeVulFixTaskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the host list where specified vulnerabilities can be repaired. Before a user submits a repair task, it is necessary to query which hosts support automatic fix, providing data support for users to select repair targets.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulFixableMachineListRequest"/></param>
        /// <returns><see cref="DescribeVulFixableMachineListResponse"/></returns>
        public Task<DescribeVulFixableMachineListResponse> DescribeVulFixableMachineList(DescribeVulFixableMachineListRequest req)
        {
            return InternalRequestAsync<DescribeVulFixableMachineListResponse>(req, "DescribeVulFixableMachineList");
        }

        /// <summary>
        /// This API is used to query the host list where specified vulnerabilities can be repaired. Before a user submits a repair task, it is necessary to query which hosts support automatic fix, providing data support for users to select repair targets.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulFixableMachineListRequest"/></param>
        /// <returns><see cref="DescribeVulFixableMachineListResponse"/></returns>
        public DescribeVulFixableMachineListResponse DescribeVulFixableMachineListSync(DescribeVulFixableMachineListRequest req)
        {
            return InternalRequestAsync<DescribeVulFixableMachineListResponse>(req, "DescribeVulFixableMachineList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the repair details of a certain fixed vulnerability on a specified host, including basic information about the vulnerability, repair host information, and a detailed list of associated components and paths (component name, version number hit, associated path, repair command).
        /// </summary>
        /// <param name="req"><see cref="DescribeVulFixedHostDetailRequest"/></param>
        /// <returns><see cref="DescribeVulFixedHostDetailResponse"/></returns>
        public Task<DescribeVulFixedHostDetailResponse> DescribeVulFixedHostDetail(DescribeVulFixedHostDetailRequest req)
        {
            return InternalRequestAsync<DescribeVulFixedHostDetailResponse>(req, "DescribeVulFixedHostDetail");
        }

        /// <summary>
        /// This API is used to query the repair details of a certain fixed vulnerability on a specified host, including basic information about the vulnerability, repair host information, and a detailed list of associated components and paths (component name, version number hit, associated path, repair command).
        /// </summary>
        /// <param name="req"><see cref="DescribeVulFixedHostDetailRequest"/></param>
        /// <returns><see cref="DescribeVulFixedHostDetailResponse"/></returns>
        public DescribeVulFixedHostDetailResponse DescribeVulFixedHostDetailSync(DescribeVulFixedHostDetailRequest req)
        {
            return InternalRequestAsync<DescribeVulFixedHostDetailResponse>(req, "DescribeVulFixedHostDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of repaired vulnerabilities, show vulnerability information with successful fixes and statistics on repair conditions, helping users understand the repair results.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulFixedListRequest"/></param>
        /// <returns><see cref="DescribeVulFixedListResponse"/></returns>
        public Task<DescribeVulFixedListResponse> DescribeVulFixedList(DescribeVulFixedListRequest req)
        {
            return InternalRequestAsync<DescribeVulFixedListResponse>(req, "DescribeVulFixedList");
        }

        /// <summary>
        /// This API is used to query the list of repaired vulnerabilities, show vulnerability information with successful fixes and statistics on repair conditions, helping users understand the repair results.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulFixedListRequest"/></param>
        /// <returns><see cref="DescribeVulFixedListResponse"/></returns>
        public DescribeVulFixedListResponse DescribeVulFixedListSync(DescribeVulFixedListRequest req)
        {
            return InternalRequestAsync<DescribeVulFixedListResponse>(req, "DescribeVulFixedList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query host-associated vulnerability components.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulHostRelateComponentRequest"/></param>
        /// <returns><see cref="DescribeVulHostRelateComponentResponse"/></returns>
        public Task<DescribeVulHostRelateComponentResponse> DescribeVulHostRelateComponent(DescribeVulHostRelateComponentRequest req)
        {
            return InternalRequestAsync<DescribeVulHostRelateComponentResponse>(req, "DescribeVulHostRelateComponent");
        }

        /// <summary>
        /// This API is used to query host-associated vulnerability components.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulHostRelateComponentRequest"/></param>
        /// <returns><see cref="DescribeVulHostRelateComponentResponse"/></returns>
        public DescribeVulHostRelateComponentResponse DescribeVulHostRelateComponentSync(DescribeVulHostRelateComponentRequest req)
        {
            return InternalRequestAsync<DescribeVulHostRelateComponentResponse>(req, "DescribeVulHostRelateComponent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to retrieve the vulnerability ignore list.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulIgnoreRuleListRequest"/></param>
        /// <returns><see cref="DescribeVulIgnoreRuleListResponse"/></returns>
        public Task<DescribeVulIgnoreRuleListResponse> DescribeVulIgnoreRuleList(DescribeVulIgnoreRuleListRequest req)
        {
            return InternalRequestAsync<DescribeVulIgnoreRuleListResponse>(req, "DescribeVulIgnoreRuleList");
        }

        /// <summary>
        /// This API is used to retrieve the vulnerability ignore list.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulIgnoreRuleListRequest"/></param>
        /// <returns><see cref="DescribeVulIgnoreRuleListResponse"/></returns>
        public DescribeVulIgnoreRuleListResponse DescribeVulIgnoreRuleListSync(DescribeVulIgnoreRuleListRequest req)
        {
            return InternalRequestAsync<DescribeVulIgnoreRuleListResponse>(req, "DescribeVulIgnoreRuleList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain vulnerability list
        /// </summary>
        /// <param name="req"><see cref="DescribeVulItemListRequest"/></param>
        /// <returns><see cref="DescribeVulItemListResponse"/></returns>
        public Task<DescribeVulItemListResponse> DescribeVulItemList(DescribeVulItemListRequest req)
        {
            return InternalRequestAsync<DescribeVulItemListResponse>(req, "DescribeVulItemList");
        }

        /// <summary>
        /// This API is used to obtain vulnerability list
        /// </summary>
        /// <param name="req"><see cref="DescribeVulItemListRequest"/></param>
        /// <returns><see cref="DescribeVulItemListResponse"/></returns>
        public DescribeVulItemListResponse DescribeVulItemListSync(DescribeVulItemListRequest req)
        {
            return InternalRequestAsync<DescribeVulItemListResponse>(req, "DescribeVulItemList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtains the vulnerability tag list
        /// </summary>
        /// <param name="req"><see cref="DescribeVulLabelListRequest"/></param>
        /// <returns><see cref="DescribeVulLabelListResponse"/></returns>
        public Task<DescribeVulLabelListResponse> DescribeVulLabelList(DescribeVulLabelListRequest req)
        {
            return InternalRequestAsync<DescribeVulLabelListResponse>(req, "DescribeVulLabelList");
        }

        /// <summary>
        /// Obtains the vulnerability tag list
        /// </summary>
        /// <param name="req"><see cref="DescribeVulLabelListRequest"/></param>
        /// <returns><see cref="DescribeVulLabelListResponse"/></returns>
        public DescribeVulLabelListResponse DescribeVulLabelListSync(DescribeVulLabelListRequest req)
        {
            return InternalRequestAsync<DescribeVulLabelListResponse>(req, "DescribeVulLabelList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the list of vulnerabilities on host nodes under the exposed path in cloud boundary analysis.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulRiskListRequest"/></param>
        /// <returns><see cref="DescribeVulRiskListResponse"/></returns>
        public Task<DescribeVulRiskListResponse> DescribeVulRiskList(DescribeVulRiskListRequest req)
        {
            return InternalRequestAsync<DescribeVulRiskListResponse>(req, "DescribeVulRiskList");
        }

        /// <summary>
        /// Query the list of vulnerabilities on host nodes under the exposed path in cloud boundary analysis.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulRiskListRequest"/></param>
        /// <returns><see cref="DescribeVulRiskListResponse"/></returns>
        public DescribeVulRiskListResponse DescribeVulRiskListSync(DescribeVulRiskListRequest req)
        {
            return InternalRequestAsync<DescribeVulRiskListResponse>(req, "DescribeVulRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retrieve the associated component of a vulnerability
        /// </summary>
        /// <param name="req"><see cref="DescribeVulRiskRelateComponentRequest"/></param>
        /// <returns><see cref="DescribeVulRiskRelateComponentResponse"/></returns>
        public Task<DescribeVulRiskRelateComponentResponse> DescribeVulRiskRelateComponent(DescribeVulRiskRelateComponentRequest req)
        {
            return InternalRequestAsync<DescribeVulRiskRelateComponentResponse>(req, "DescribeVulRiskRelateComponent");
        }

        /// <summary>
        /// Retrieve the associated component of a vulnerability
        /// </summary>
        /// <param name="req"><see cref="DescribeVulRiskRelateComponentRequest"/></param>
        /// <returns><see cref="DescribeVulRiskRelateComponentResponse"/></returns>
        public DescribeVulRiskRelateComponentResponse DescribeVulRiskRelateComponentSync(DescribeVulRiskRelateComponentRequest req)
        {
            return InternalRequestAsync<DescribeVulRiskRelateComponentResponse>(req, "DescribeVulRiskRelateComponent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Search for hosts associated with vulnerabilities or KBs
        /// </summary>
        /// <param name="req"><see cref="DescribeVulRiskRelateHostRequest"/></param>
        /// <returns><see cref="DescribeVulRiskRelateHostResponse"/></returns>
        public Task<DescribeVulRiskRelateHostResponse> DescribeVulRiskRelateHost(DescribeVulRiskRelateHostRequest req)
        {
            return InternalRequestAsync<DescribeVulRiskRelateHostResponse>(req, "DescribeVulRiskRelateHost");
        }

        /// <summary>
        /// Search for hosts associated with vulnerabilities or KBs
        /// </summary>
        /// <param name="req"><see cref="DescribeVulRiskRelateHostRequest"/></param>
        /// <returns><see cref="DescribeVulRiskRelateHostResponse"/></returns>
        public DescribeVulRiskRelateHostResponse DescribeVulRiskRelateHostSync(DescribeVulRiskRelateHostRequest req)
        {
            return InternalRequestAsync<DescribeVulRiskRelateHostResponse>(req, "DescribeVulRiskRelateHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain vulnerability scanning (period scanning).
        /// </summary>
        /// <param name="req"><see cref="DescribeVulScanPeriodicRequest"/></param>
        /// <returns><see cref="DescribeVulScanPeriodicResponse"/></returns>
        public Task<DescribeVulScanPeriodicResponse> DescribeVulScanPeriodic(DescribeVulScanPeriodicRequest req)
        {
            return InternalRequestAsync<DescribeVulScanPeriodicResponse>(req, "DescribeVulScanPeriodic");
        }

        /// <summary>
        /// This API is used to obtain vulnerability scanning (period scanning).
        /// </summary>
        /// <param name="req"><see cref="DescribeVulScanPeriodicRequest"/></param>
        /// <returns><see cref="DescribeVulScanPeriodicResponse"/></returns>
        public DescribeVulScanPeriodicResponse DescribeVulScanPeriodicSync(DescribeVulScanPeriodicRequest req)
        {
            return InternalRequestAsync<DescribeVulScanPeriodicResponse>(req, "DescribeVulScanPeriodic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to retrieve vulnerability scanning task detail
        /// </summary>
        /// <param name="req"><see cref="DescribeVulScanTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeVulScanTaskDetailResponse"/></returns>
        public Task<DescribeVulScanTaskDetailResponse> DescribeVulScanTaskDetail(DescribeVulScanTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeVulScanTaskDetailResponse>(req, "DescribeVulScanTaskDetail");
        }

        /// <summary>
        /// This API is used to retrieve vulnerability scanning task detail
        /// </summary>
        /// <param name="req"><see cref="DescribeVulScanTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeVulScanTaskDetailResponse"/></returns>
        public DescribeVulScanTaskDetailResponse DescribeVulScanTaskDetailSync(DescribeVulScanTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeVulScanTaskDetailResponse>(req, "DescribeVulScanTaskDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to search vulnerability scanning task history
        /// </summary>
        /// <param name="req"><see cref="DescribeVulScanTaskListRequest"/></param>
        /// <returns><see cref="DescribeVulScanTaskListResponse"/></returns>
        public Task<DescribeVulScanTaskListResponse> DescribeVulScanTaskList(DescribeVulScanTaskListRequest req)
        {
            return InternalRequestAsync<DescribeVulScanTaskListResponse>(req, "DescribeVulScanTaskList");
        }

        /// <summary>
        /// This API is used to search vulnerability scanning task history
        /// </summary>
        /// <param name="req"><see cref="DescribeVulScanTaskListRequest"/></param>
        /// <returns><see cref="DescribeVulScanTaskListResponse"/></returns>
        public DescribeVulScanTaskListResponse DescribeVulScanTaskListSync(DescribeVulScanTaskListRequest req)
        {
            return InternalRequestAsync<DescribeVulScanTaskListResponse>(req, "DescribeVulScanTaskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain Vulnerability Risk List from Vulnerability's Perspective
        /// </summary>
        /// <param name="req"><see cref="DescribeVulViewVulRiskListRequest"/></param>
        /// <returns><see cref="DescribeVulViewVulRiskListResponse"/></returns>
        public Task<DescribeVulViewVulRiskListResponse> DescribeVulViewVulRiskList(DescribeVulViewVulRiskListRequest req)
        {
            return InternalRequestAsync<DescribeVulViewVulRiskListResponse>(req, "DescribeVulViewVulRiskList");
        }

        /// <summary>
        /// Obtain Vulnerability Risk List from Vulnerability's Perspective
        /// </summary>
        /// <param name="req"><see cref="DescribeVulViewVulRiskListRequest"/></param>
        /// <returns><see cref="DescribeVulViewVulRiskListResponse"/></returns>
        public DescribeVulViewVulRiskListResponse DescribeVulViewVulRiskListSync(DescribeVulViewVulRiskListRequest req)
        {
            return InternalRequestAsync<DescribeVulViewVulRiskListResponse>(req, "DescribeVulViewVulRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the notification policy list for the current tenant by page, corresponding to the table on the Notification Policy Configuration Tab in Notification Center - Robot Notification. The returned fields are simplified info required for row display. Use DescribeWebhookPolicy for complete configuration in editing scenarios. Each tenant can have up to 100 notification policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebhookPolicyListRequest"/></param>
        /// <returns><see cref="DescribeWebhookPolicyListResponse"/></returns>
        public Task<DescribeWebhookPolicyListResponse> DescribeWebhookPolicyList(DescribeWebhookPolicyListRequest req)
        {
            return InternalRequestAsync<DescribeWebhookPolicyListResponse>(req, "DescribeWebhookPolicyList");
        }

        /// <summary>
        /// This API is used to query the notification policy list for the current tenant by page, corresponding to the table on the Notification Policy Configuration Tab in Notification Center - Robot Notification. The returned fields are simplified info required for row display. Use DescribeWebhookPolicy for complete configuration in editing scenarios. Each tenant can have up to 100 notification policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebhookPolicyListRequest"/></param>
        /// <returns><see cref="DescribeWebhookPolicyListResponse"/></returns>
        public DescribeWebhookPolicyListResponse DescribeWebhookPolicyListSync(DescribeWebhookPolicyListRequest req)
        {
            return InternalRequestAsync<DescribeWebhookPolicyListResponse>(req, "DescribeWebhookPolicyList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of receiving robots for the current tenant by page, corresponding to the table on the Receive Bot Management Tab in Notification Center - Robot Notification. Each tenant can have up to 50 robots.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebhookReceiverListRequest"/></param>
        /// <returns><see cref="DescribeWebhookReceiverListResponse"/></returns>
        public Task<DescribeWebhookReceiverListResponse> DescribeWebhookReceiverList(DescribeWebhookReceiverListRequest req)
        {
            return InternalRequestAsync<DescribeWebhookReceiverListResponse>(req, "DescribeWebhookReceiverList");
        }

        /// <summary>
        /// This API is used to query the list of receiving robots for the current tenant by page, corresponding to the table on the Receive Bot Management Tab in Notification Center - Robot Notification. Each tenant can have up to 50 robots.
        /// </summary>
        /// <param name="req"><see cref="DescribeWebhookReceiverListRequest"/></param>
        /// <returns><see cref="DescribeWebhookReceiverListResponse"/></returns>
        public DescribeWebhookReceiverListResponse DescribeWebhookReceiverListSync(DescribeWebhookReceiverListRequest req)
        {
            return InternalRequestAsync<DescribeWebhookReceiverListResponse>(req, "DescribeWebhookReceiverList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Disable scheduled AI tasks.
        /// 
        /// Set the status of the specified AI scheduled task to disabled. After it is disabled, the task will suspend automatic execution.
        /// </summary>
        /// <param name="req"><see cref="DisableAIScheduleRequest"/></param>
        /// <returns><see cref="DisableAIScheduleResponse"/></returns>
        public Task<DisableAIScheduleResponse> DisableAISchedule(DisableAIScheduleRequest req)
        {
            return InternalRequestAsync<DisableAIScheduleResponse>(req, "DisableAISchedule");
        }

        /// <summary>
        /// Disable scheduled AI tasks.
        /// 
        /// Set the status of the specified AI scheduled task to disabled. After it is disabled, the task will suspend automatic execution.
        /// </summary>
        /// <param name="req"><see cref="DisableAIScheduleRequest"/></param>
        /// <returns><see cref="DisableAIScheduleResponse"/></returns>
        public DisableAIScheduleResponse DisableAIScheduleSync(DisableAIScheduleRequest req)
        {
            return InternalRequestAsync<DisableAIScheduleResponse>(req, "DisableAISchedule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to download export logs.
        /// </summary>
        /// <param name="req"><see cref="DownloadDspmExportLogRequest"/></param>
        /// <returns><see cref="DownloadDspmExportLogResponse"/></returns>
        public Task<DownloadDspmExportLogResponse> DownloadDspmExportLog(DownloadDspmExportLogRequest req)
        {
            return InternalRequestAsync<DownloadDspmExportLogResponse>(req, "DownloadDspmExportLog");
        }

        /// <summary>
        /// This API is used to download export logs.
        /// </summary>
        /// <param name="req"><see cref="DownloadDspmExportLogRequest"/></param>
        /// <returns><see cref="DownloadDspmExportLogResponse"/></returns>
        public DownloadDspmExportLogResponse DownloadDspmExportLogSync(DownloadDspmExportLogRequest req)
        {
            return InternalRequestAsync<DownloadDspmExportLogResponse>(req, "DownloadDspmExportLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Enable AI scheduled tasks.
        /// 
        /// Set the status of the specified AI scheduled task to enabled. After it is enabled, the task will automatically execute based on the trigger configuration.
        /// </summary>
        /// <param name="req"><see cref="EnableAIScheduleRequest"/></param>
        /// <returns><see cref="EnableAIScheduleResponse"/></returns>
        public Task<EnableAIScheduleResponse> EnableAISchedule(EnableAIScheduleRequest req)
        {
            return InternalRequestAsync<EnableAIScheduleResponse>(req, "EnableAISchedule");
        }

        /// <summary>
        /// Enable AI scheduled tasks.
        /// 
        /// Set the status of the specified AI scheduled task to enabled. After it is enabled, the task will automatically execute based on the trigger configuration.
        /// </summary>
        /// <param name="req"><see cref="EnableAIScheduleRequest"/></param>
        /// <returns><see cref="EnableAIScheduleResponse"/></returns>
        public EnableAIScheduleResponse EnableAIScheduleSync(EnableAIScheduleRequest req)
        {
            return InternalRequestAsync<EnableAIScheduleResponse>(req, "EnableAISchedule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Exports host details of a CSIP scan task to Excel files. This API is used to query the download link through DescribeExportMachines after asynchronous generation.
        /// </summary>
        /// <param name="req"><see cref="ExportCSIPMalwareScanTaskDetailRequest"/></param>
        /// <returns><see cref="ExportCSIPMalwareScanTaskDetailResponse"/></returns>
        public Task<ExportCSIPMalwareScanTaskDetailResponse> ExportCSIPMalwareScanTaskDetail(ExportCSIPMalwareScanTaskDetailRequest req)
        {
            return InternalRequestAsync<ExportCSIPMalwareScanTaskDetailResponse>(req, "ExportCSIPMalwareScanTaskDetail");
        }

        /// <summary>
        /// Exports host details of a CSIP scan task to Excel files. This API is used to query the download link through DescribeExportMachines after asynchronous generation.
        /// </summary>
        /// <param name="req"><see cref="ExportCSIPMalwareScanTaskDetailRequest"/></param>
        /// <returns><see cref="ExportCSIPMalwareScanTaskDetailResponse"/></returns>
        public ExportCSIPMalwareScanTaskDetailResponse ExportCSIPMalwareScanTaskDetailSync(ExportCSIPMalwareScanTaskDetailRequest req)
        {
            return InternalRequestAsync<ExportCSIPMalwareScanTaskDetailResponse>(req, "ExportCSIPMalwareScanTaskDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Export the host list for client settings.
        /// </summary>
        /// <param name="req"><see cref="ExportClientSettingHostListRequest"/></param>
        /// <returns><see cref="ExportClientSettingHostListResponse"/></returns>
        public Task<ExportClientSettingHostListResponse> ExportClientSettingHostList(ExportClientSettingHostListRequest req)
        {
            return InternalRequestAsync<ExportClientSettingHostListResponse>(req, "ExportClientSettingHostList");
        }

        /// <summary>
        /// Export the host list for client settings.
        /// </summary>
        /// <param name="req"><see cref="ExportClientSettingHostListRequest"/></param>
        /// <returns><see cref="ExportClientSettingHostListResponse"/></returns>
        public ExportClientSettingHostListResponse ExportClientSettingHostListSync(ExportClientSettingHostListRequest req)
        {
            return InternalRequestAsync<ExportClientSettingHostListResponse>(req, "ExportClientSettingHostList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the EDR policy list.
        /// </summary>
        /// <param name="req"><see cref="ExportEDRRulesRequest"/></param>
        /// <returns><see cref="ExportEDRRulesResponse"/></returns>
        public Task<ExportEDRRulesResponse> ExportEDRRules(ExportEDRRulesRequest req)
        {
            return InternalRequestAsync<ExportEDRRulesResponse>(req, "ExportEDRRules");
        }

        /// <summary>
        /// This API is used to export the EDR policy list.
        /// </summary>
        /// <param name="req"><see cref="ExportEDRRulesRequest"/></param>
        /// <returns><see cref="ExportEDRRulesResponse"/></returns>
        public ExportEDRRulesResponse ExportEDRRulesSync(ExportEDRRulesRequest req)
        {
            return InternalRequestAsync<ExportEDRRulesResponse>(req, "ExportEDRRules")
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
        /// Install Agent for cluster container security (parallel container installation method).
        /// 
        /// capi layer processing process:
        /// 1. Query the DB cluster list by ClusterCaMD5List (only used for resolving the appid ownership of each cluster, not for existence/type verification)
        /// 2. Group by appid and pass through to the access side ClusterInstall RPC
        /// 
        /// Description (container asset revision 2026 H1): This API is a passthrough API. The capi layer does not verify the existence, data type, or format of ClusterCaMD5. ClusterCaMD5 values that miss in the DB are silently skipped with no error reported.
        /// </summary>
        /// <param name="req"><see cref="InstallClusterAgentRequest"/></param>
        /// <returns><see cref="InstallClusterAgentResponse"/></returns>
        public Task<InstallClusterAgentResponse> InstallClusterAgent(InstallClusterAgentRequest req)
        {
            return InternalRequestAsync<InstallClusterAgentResponse>(req, "InstallClusterAgent");
        }

        /// <summary>
        /// Install Agent for cluster container security (parallel container installation method).
        /// 
        /// capi layer processing process:
        /// 1. Query the DB cluster list by ClusterCaMD5List (only used for resolving the appid ownership of each cluster, not for existence/type verification)
        /// 2. Group by appid and pass through to the access side ClusterInstall RPC
        /// 
        /// Description (container asset revision 2026 H1): This API is a passthrough API. The capi layer does not verify the existence, data type, or format of ClusterCaMD5. ClusterCaMD5 values that miss in the DB are silently skipped with no error reported.
        /// </summary>
        /// <param name="req"><see cref="InstallClusterAgentRequest"/></param>
        /// <returns><see cref="InstallClusterAgentResponse"/></returns>
        public InstallClusterAgentResponse InstallClusterAgentSync(InstallClusterAgentRequest req)
        {
            return InternalRequestAsync<InstallClusterAgentResponse>(req, "InstallClusterAgent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Install the key sandbox SKILL on specified machine instances. Batch operations are supported, allowing input of multiple instance IDs at once. After installation, the AI Agent on the target machine can access credentials through the key sandbox proxy without being exposed to plaintext keys. Duplicate invocations on installed instances will not trigger an error (idempotent) and are deemed successful.
        /// </summary>
        /// <param name="req"><see cref="InstallKeySandboxSkillRequest"/></param>
        /// <returns><see cref="InstallKeySandboxSkillResponse"/></returns>
        public Task<InstallKeySandboxSkillResponse> InstallKeySandboxSkill(InstallKeySandboxSkillRequest req)
        {
            return InternalRequestAsync<InstallKeySandboxSkillResponse>(req, "InstallKeySandboxSkill");
        }

        /// <summary>
        /// Install the key sandbox SKILL on specified machine instances. Batch operations are supported, allowing input of multiple instance IDs at once. After installation, the AI Agent on the target machine can access credentials through the key sandbox proxy without being exposed to plaintext keys. Duplicate invocations on installed instances will not trigger an error (idempotent) and are deemed successful.
        /// </summary>
        /// <param name="req"><see cref="InstallKeySandboxSkillRequest"/></param>
        /// <returns><see cref="InstallKeySandboxSkillResponse"/></returns>
        public InstallKeySandboxSkillResponse InstallKeySandboxSkillSync(InstallKeySandboxSkillRequest req)
        {
            return InternalRequestAsync<InstallKeySandboxSkillResponse>(req, "InstallKeySandboxSkill")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Trigger installation of the traffic sandbox plugin to AI Agent assets in a specified range. Use BelongAssetType to distinguish host or container dimensions, and use EffectScope to specify the installation target (INCLUDE = install only to specified assets, EXCLUDE = all assets minus specified assets). This API only triggers the action and does not wait for completion.
        /// </summary>
        /// <param name="req"><see cref="InstallSandboxPluginRequest"/></param>
        /// <returns><see cref="InstallSandboxPluginResponse"/></returns>
        public Task<InstallSandboxPluginResponse> InstallSandboxPlugin(InstallSandboxPluginRequest req)
        {
            return InternalRequestAsync<InstallSandboxPluginResponse>(req, "InstallSandboxPlugin");
        }

        /// <summary>
        /// Trigger installation of the traffic sandbox plugin to AI Agent assets in a specified range. Use BelongAssetType to distinguish host or container dimensions, and use EffectScope to specify the installation target (INCLUDE = install only to specified assets, EXCLUDE = all assets minus specified assets). This API only triggers the action and does not wait for completion.
        /// </summary>
        /// <param name="req"><see cref="InstallSandboxPluginRequest"/></param>
        /// <returns><see cref="InstallSandboxPluginResponse"/></returns>
        public InstallSandboxPluginResponse InstallSandboxPluginSync(InstallSandboxPluginRequest req)
        {
            return InternalRequestAsync<InstallSandboxPluginResponse>(req, "InstallSandboxPlugin")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify the AI-Link engine configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyAILinkSettingRequest"/></param>
        /// <returns><see cref="ModifyAILinkSettingResponse"/></returns>
        public Task<ModifyAILinkSettingResponse> ModifyAILinkSetting(ModifyAILinkSettingRequest req)
        {
            return InternalRequestAsync<ModifyAILinkSettingResponse>(req, "ModifyAILinkSetting");
        }

        /// <summary>
        /// Modify the AI-Link engine configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyAILinkSettingRequest"/></param>
        /// <returns><see cref="ModifyAILinkSettingResponse"/></returns>
        public ModifyAILinkSettingResponse ModifyAILinkSettingSync(ModifyAILinkSettingRequest req)
        {
            return InternalRequestAsync<ModifyAILinkSettingResponse>(req, "ModifyAILinkSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify a scheduled AI task.
        /// 
        /// Partial update is supported. Only the passed-in optional fields are updated. Whether the trigger list is fully replaced is controlled by the UpdateTriggers flag.
        /// </summary>
        /// <param name="req"><see cref="ModifyAIScheduleRequest"/></param>
        /// <returns><see cref="ModifyAIScheduleResponse"/></returns>
        public Task<ModifyAIScheduleResponse> ModifyAISchedule(ModifyAIScheduleRequest req)
        {
            return InternalRequestAsync<ModifyAIScheduleResponse>(req, "ModifyAISchedule");
        }

        /// <summary>
        /// Modify a scheduled AI task.
        /// 
        /// Partial update is supported. Only the passed-in optional fields are updated. Whether the trigger list is fully replaced is controlled by the UpdateTriggers flag.
        /// </summary>
        /// <param name="req"><see cref="ModifyAIScheduleRequest"/></param>
        /// <returns><see cref="ModifyAIScheduleResponse"/></returns>
        public ModifyAIScheduleResponse ModifyAIScheduleSync(ModifyAIScheduleRequest req)
        {
            return InternalRequestAsync<ModifyAIScheduleResponse>(req, "ModifyAISchedule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify client log collection settings exclusive to CSIP. It allows you to set the log collection type and asset scope for which the settings take effect.
        /// </summary>
        /// <param name="req"><see cref="ModifyAgentConfigSettingRequest"/></param>
        /// <returns><see cref="ModifyAgentConfigSettingResponse"/></returns>
        public Task<ModifyAgentConfigSettingResponse> ModifyAgentConfigSetting(ModifyAgentConfigSettingRequest req)
        {
            return InternalRequestAsync<ModifyAgentConfigSettingResponse>(req, "ModifyAgentConfigSetting");
        }

        /// <summary>
        /// This API is used to modify client log collection settings exclusive to CSIP. It allows you to set the log collection type and asset scope for which the settings take effect.
        /// </summary>
        /// <param name="req"><see cref="ModifyAgentConfigSettingRequest"/></param>
        /// <returns><see cref="ModifyAgentConfigSettingResponse"/></returns>
        public ModifyAgentConfigSettingResponse ModifyAgentConfigSettingSync(ModifyAgentConfigSettingRequest req)
        {
            return InternalRequestAsync<ModifyAgentConfigSettingResponse>(req, "ModifyAgentConfigSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Set the client running mode and configuration
        /// </summary>
        /// <param name="req"><see cref="ModifyAgentRunModeRequest"/></param>
        /// <returns><see cref="ModifyAgentRunModeResponse"/></returns>
        public Task<ModifyAgentRunModeResponse> ModifyAgentRunMode(ModifyAgentRunModeRequest req)
        {
            return InternalRequestAsync<ModifyAgentRunModeResponse>(req, "ModifyAgentRunMode");
        }

        /// <summary>
        /// Set the client running mode and configuration
        /// </summary>
        /// <param name="req"><see cref="ModifyAgentRunModeRequest"/></param>
        /// <returns><see cref="ModifyAgentRunModeResponse"/></returns>
        public ModifyAgentRunModeResponse ModifyAgentRunModeSync(ModifyAgentRunModeRequest req)
        {
            return InternalRequestAsync<ModifyAgentRunModeResponse>(req, "ModifyAgentRunMode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify the client running policy group. This API is used to set custom policies and associate machine lists.
        /// </summary>
        /// <param name="req"><see cref="ModifyAgentRunPolicyRequest"/></param>
        /// <returns><see cref="ModifyAgentRunPolicyResponse"/></returns>
        public Task<ModifyAgentRunPolicyResponse> ModifyAgentRunPolicy(ModifyAgentRunPolicyRequest req)
        {
            return InternalRequestAsync<ModifyAgentRunPolicyResponse>(req, "ModifyAgentRunPolicy");
        }

        /// <summary>
        /// Modify the client running policy group. This API is used to set custom policies and associate machine lists.
        /// </summary>
        /// <param name="req"><see cref="ModifyAgentRunPolicyRequest"/></param>
        /// <returns><see cref="ModifyAgentRunPolicyResponse"/></returns>
        public ModifyAgentRunPolicyResponse ModifyAgentRunPolicySync(ModifyAgentRunPolicyRequest req)
        {
            return InternalRequestAsync<ModifyAgentRunPolicyResponse>(req, "ModifyAgentRunPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Tag an asset as core or not.
        /// </summary>
        /// <param name="req"><see cref="ModifyAssetCoreAttributeRequest"/></param>
        /// <returns><see cref="ModifyAssetCoreAttributeResponse"/></returns>
        public Task<ModifyAssetCoreAttributeResponse> ModifyAssetCoreAttribute(ModifyAssetCoreAttributeRequest req)
        {
            return InternalRequestAsync<ModifyAssetCoreAttributeResponse>(req, "ModifyAssetCoreAttribute");
        }

        /// <summary>
        /// Tag an asset as core or not.
        /// </summary>
        /// <param name="req"><see cref="ModifyAssetCoreAttributeRequest"/></param>
        /// <returns><see cref="ModifyAssetCoreAttributeResponse"/></returns>
        public ModifyAssetCoreAttributeResponse ModifyAssetCoreAttributeSync(ModifyAssetCoreAttributeRequest req)
        {
            return InternalRequestAsync<ModifyAssetCoreAttributeResponse>(req, "ModifyAssetCoreAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update the asset search view.
        /// </summary>
        /// <param name="req"><see cref="ModifyAssetFilterViewRequest"/></param>
        /// <returns><see cref="ModifyAssetFilterViewResponse"/></returns>
        public Task<ModifyAssetFilterViewResponse> ModifyAssetFilterView(ModifyAssetFilterViewRequest req)
        {
            return InternalRequestAsync<ModifyAssetFilterViewResponse>(req, "ModifyAssetFilterView");
        }

        /// <summary>
        /// Update the asset search view.
        /// </summary>
        /// <param name="req"><see cref="ModifyAssetFilterViewRequest"/></param>
        /// <returns><see cref="ModifyAssetFilterViewResponse"/></returns>
        public ModifyAssetFilterViewResponse ModifyAssetFilterViewSync(ModifyAssetFilterViewRequest req)
        {
            return InternalRequestAsync<ModifyAssetFilterViewResponse>(req, "ModifyAssetFilterView")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to edit asset tags.
        /// </summary>
        /// <param name="req"><see cref="ModifyAssetTagRequest"/></param>
        /// <returns><see cref="ModifyAssetTagResponse"/></returns>
        public Task<ModifyAssetTagResponse> ModifyAssetTag(ModifyAssetTagRequest req)
        {
            return InternalRequestAsync<ModifyAssetTagResponse>(req, "ModifyAssetTag");
        }

        /// <summary>
        /// This API is used to edit asset tags.
        /// </summary>
        /// <param name="req"><see cref="ModifyAssetTagRequest"/></param>
        /// <returns><see cref="ModifyAssetTagResponse"/></returns>
        public ModifyAssetTagResponse ModifyAssetTagSync(ModifyAssetTagRequest req)
        {
            return InternalRequestAsync<ModifyAssetTagResponse>(req, "ModifyAssetTag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Operate assets to edit tags.
        /// </summary>
        /// <param name="req"><see cref="ModifyAssetTagsRequest"/></param>
        /// <returns><see cref="ModifyAssetTagsResponse"/></returns>
        public Task<ModifyAssetTagsResponse> ModifyAssetTags(ModifyAssetTagsRequest req)
        {
            return InternalRequestAsync<ModifyAssetTagsResponse>(req, "ModifyAssetTags");
        }

        /// <summary>
        /// Operate assets to edit tags.
        /// </summary>
        /// <param name="req"><see cref="ModifyAssetTagsRequest"/></param>
        /// <returns><see cref="ModifyAssetTagsResponse"/></returns>
        public ModifyAssetTagsResponse ModifyAssetTagsSync(ModifyAssetTagsRequest req)
        {
            return InternalRequestAsync<ModifyAssetTagsResponse>(req, "ModifyAssetTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Operate assets and edit tags.
        /// </summary>
        /// <param name="req"><see cref="ModifyAssetTagsByAssetInfoRequest"/></param>
        /// <returns><see cref="ModifyAssetTagsByAssetInfoResponse"/></returns>
        public Task<ModifyAssetTagsByAssetInfoResponse> ModifyAssetTagsByAssetInfo(ModifyAssetTagsByAssetInfoRequest req)
        {
            return InternalRequestAsync<ModifyAssetTagsByAssetInfoResponse>(req, "ModifyAssetTagsByAssetInfo");
        }

        /// <summary>
        /// Operate assets and edit tags.
        /// </summary>
        /// <param name="req"><see cref="ModifyAssetTagsByAssetInfoRequest"/></param>
        /// <returns><see cref="ModifyAssetTagsByAssetInfoResponse"/></returns>
        public ModifyAssetTagsByAssetInfoResponse ModifyAssetTagsByAssetInfoSync(ModifyAssetTagsByAssetInfoRequest req)
        {
            return InternalRequestAsync<ModifyAssetTagsByAssetInfoResponse>(req, "ModifyAssetTagsByAssetInfo")
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
        /// Create or edit a baseline policy. Policy.ID 0 means create, non-zero means edit. Name is required when creating or editing. CheckAssetType and Type must comply with the CheckAssetType and PolicyType enums.
        /// </summary>
        /// <param name="req"><see cref="ModifyBaselinePolicyRequest"/></param>
        /// <returns><see cref="ModifyBaselinePolicyResponse"/></returns>
        public Task<ModifyBaselinePolicyResponse> ModifyBaselinePolicy(ModifyBaselinePolicyRequest req)
        {
            return InternalRequestAsync<ModifyBaselinePolicyResponse>(req, "ModifyBaselinePolicy");
        }

        /// <summary>
        /// Create or edit a baseline policy. Policy.ID 0 means create, non-zero means edit. Name is required when creating or editing. CheckAssetType and Type must comply with the CheckAssetType and PolicyType enums.
        /// </summary>
        /// <param name="req"><see cref="ModifyBaselinePolicyRequest"/></param>
        /// <returns><see cref="ModifyBaselinePolicyResponse"/></returns>
        public ModifyBaselinePolicyResponse ModifyBaselinePolicySync(ModifyBaselinePolicyRequest req)
        {
            return InternalRequestAsync<ModifyBaselinePolicyResponse>(req, "ModifyBaselinePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Batch enable or disable baseline policies. Once disabled, a policy will no longer be included in scans and statistics.
        /// </summary>
        /// <param name="req"><see cref="ModifyBaselinePolicyEnableRequest"/></param>
        /// <returns><see cref="ModifyBaselinePolicyEnableResponse"/></returns>
        public Task<ModifyBaselinePolicyEnableResponse> ModifyBaselinePolicyEnable(ModifyBaselinePolicyEnableRequest req)
        {
            return InternalRequestAsync<ModifyBaselinePolicyEnableResponse>(req, "ModifyBaselinePolicyEnable");
        }

        /// <summary>
        /// Batch enable or disable baseline policies. Once disabled, a policy will no longer be included in scans and statistics.
        /// </summary>
        /// <param name="req"><see cref="ModifyBaselinePolicyEnableRequest"/></param>
        /// <returns><see cref="ModifyBaselinePolicyEnableResponse"/></returns>
        public ModifyBaselinePolicyEnableResponse ModifyBaselinePolicyEnableSync(ModifyBaselinePolicyEnableRequest req)
        {
            return InternalRequestAsync<ModifyBaselinePolicyEnableResponse>(req, "ModifyBaselinePolicyEnable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the baseline synchronization configuration of the current account (admin). When AutoSync is true, TargetAppidList cannot be empty and its elements cannot be 0.
        /// </summary>
        /// <param name="req"><see cref="ModifyBaselineSyncConfRequest"/></param>
        /// <returns><see cref="ModifyBaselineSyncConfResponse"/></returns>
        public Task<ModifyBaselineSyncConfResponse> ModifyBaselineSyncConf(ModifyBaselineSyncConfRequest req)
        {
            return InternalRequestAsync<ModifyBaselineSyncConfResponse>(req, "ModifyBaselineSyncConf");
        }

        /// <summary>
        /// This API is used to update the baseline synchronization configuration of the current account (admin). When AutoSync is true, TargetAppidList cannot be empty and its elements cannot be 0.
        /// </summary>
        /// <param name="req"><see cref="ModifyBaselineSyncConfRequest"/></param>
        /// <returns><see cref="ModifyBaselineSyncConfResponse"/></returns>
        public ModifyBaselineSyncConfResponse ModifyBaselineSyncConfSync(ModifyBaselineSyncConfRequest req)
        {
            return InternalRequestAsync<ModifyBaselineSyncConfResponse>(req, "ModifyBaselineSyncConf")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update user-level baseline configurations for the current account, including sync permission, offline risk clearing, and Agent scan timeout.
        /// </summary>
        /// <param name="req"><see cref="ModifyBaselineUserOtherConfRequest"/></param>
        /// <returns><see cref="ModifyBaselineUserOtherConfResponse"/></returns>
        public Task<ModifyBaselineUserOtherConfResponse> ModifyBaselineUserOtherConf(ModifyBaselineUserOtherConfRequest req)
        {
            return InternalRequestAsync<ModifyBaselineUserOtherConfResponse>(req, "ModifyBaselineUserOtherConf");
        }

        /// <summary>
        /// This API is used to update user-level baseline configurations for the current account, including sync permission, offline risk clearing, and Agent scan timeout.
        /// </summary>
        /// <param name="req"><see cref="ModifyBaselineUserOtherConfRequest"/></param>
        /// <returns><see cref="ModifyBaselineUserOtherConfResponse"/></returns>
        public ModifyBaselineUserOtherConfResponse ModifyBaselineUserOtherConfSync(ModifyBaselineUserOtherConfRequest req)
        {
            return InternalRequestAsync<ModifyBaselineUserOtherConfResponse>(req, "ModifyBaselineUserOtherConf")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update the custom "user weak password" dictionary for the current account. The dictionary content is stored after server encryption. Input an empty string to clear it.
        /// </summary>
        /// <param name="req"><see cref="ModifyBaselineUserWeakPasswordConfRequest"/></param>
        /// <returns><see cref="ModifyBaselineUserWeakPasswordConfResponse"/></returns>
        public Task<ModifyBaselineUserWeakPasswordConfResponse> ModifyBaselineUserWeakPasswordConf(ModifyBaselineUserWeakPasswordConfRequest req)
        {
            return InternalRequestAsync<ModifyBaselineUserWeakPasswordConfResponse>(req, "ModifyBaselineUserWeakPasswordConf");
        }

        /// <summary>
        /// Update the custom "user weak password" dictionary for the current account. The dictionary content is stored after server encryption. Input an empty string to clear it.
        /// </summary>
        /// <param name="req"><see cref="ModifyBaselineUserWeakPasswordConfRequest"/></param>
        /// <returns><see cref="ModifyBaselineUserWeakPasswordConfResponse"/></returns>
        public ModifyBaselineUserWeakPasswordConfResponse ModifyBaselineUserWeakPasswordConfSync(ModifyBaselineUserWeakPasswordConfRequest req)
        {
            return InternalRequestAsync<ModifyBaselineUserWeakPasswordConfResponse>(req, "ModifyBaselineUserWeakPasswordConf")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set the status of brute force attack blocking.
        /// </summary>
        /// <param name="req"><see cref="ModifyBruteAttackBanStatusRequest"/></param>
        /// <returns><see cref="ModifyBruteAttackBanStatusResponse"/></returns>
        public Task<ModifyBruteAttackBanStatusResponse> ModifyBruteAttackBanStatus(ModifyBruteAttackBanStatusRequest req)
        {
            return InternalRequestAsync<ModifyBruteAttackBanStatusResponse>(req, "ModifyBruteAttackBanStatus");
        }

        /// <summary>
        /// This API is used to set the status of brute force attack blocking.
        /// </summary>
        /// <param name="req"><see cref="ModifyBruteAttackBanStatusRequest"/></param>
        /// <returns><see cref="ModifyBruteAttackBanStatusResponse"/></returns>
        public ModifyBruteAttackBanStatusResponse ModifyBruteAttackBanStatusSync(ModifyBruteAttackBanStatusRequest req)
        {
            return InternalRequestAsync<ModifyBruteAttackBanStatusResponse>(req, "ModifyBruteAttackBanStatus")
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
        /// Bind host authorization or RASP authorization to a specified order. Execute asynchronously and return TaskId to query progress. Specify the authorized version by LicenseType.
        /// </summary>
        /// <param name="req"><see cref="ModifyCSIPLicenseBindsRequest"/></param>
        /// <returns><see cref="ModifyCSIPLicenseBindsResponse"/></returns>
        public Task<ModifyCSIPLicenseBindsResponse> ModifyCSIPLicenseBinds(ModifyCSIPLicenseBindsRequest req)
        {
            return InternalRequestAsync<ModifyCSIPLicenseBindsResponse>(req, "ModifyCSIPLicenseBinds");
        }

        /// <summary>
        /// Bind host authorization or RASP authorization to a specified order. Execute asynchronously and return TaskId to query progress. Specify the authorized version by LicenseType.
        /// </summary>
        /// <param name="req"><see cref="ModifyCSIPLicenseBindsRequest"/></param>
        /// <returns><see cref="ModifyCSIPLicenseBindsResponse"/></returns>
        public ModifyCSIPLicenseBindsResponse ModifyCSIPLicenseBindsSync(ModifyCSIPLicenseBindsRequest req)
        {
            return InternalRequestAsync<ModifyCSIPLicenseBindsResponse>(req, "ModifyCSIPLicenseBinds")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Manually unbind host authorization. Execute synchronously and return results directly. Only unbind host authorization (category=0, including Pro and Ultimate editions). In single order mode, appid can locate the order without the need to pass ResourceId. For RASP unbinding, use ModifyCSIPRaspLicenseUnBinds.
        /// </summary>
        /// <param name="req"><see cref="ModifyCSIPLicenseUnBindsRequest"/></param>
        /// <returns><see cref="ModifyCSIPLicenseUnBindsResponse"/></returns>
        public Task<ModifyCSIPLicenseUnBindsResponse> ModifyCSIPLicenseUnBinds(ModifyCSIPLicenseUnBindsRequest req)
        {
            return InternalRequestAsync<ModifyCSIPLicenseUnBindsResponse>(req, "ModifyCSIPLicenseUnBinds");
        }

        /// <summary>
        /// Manually unbind host authorization. Execute synchronously and return results directly. Only unbind host authorization (category=0, including Pro and Ultimate editions). In single order mode, appid can locate the order without the need to pass ResourceId. For RASP unbinding, use ModifyCSIPRaspLicenseUnBinds.
        /// </summary>
        /// <param name="req"><see cref="ModifyCSIPLicenseUnBindsRequest"/></param>
        /// <returns><see cref="ModifyCSIPLicenseUnBindsResponse"/></returns>
        public ModifyCSIPLicenseUnBindsResponse ModifyCSIPLicenseUnBindsSync(ModifyCSIPLicenseUnBindsRequest req)
        {
            return InternalRequestAsync<ModifyCSIPLicenseUnBindsResponse>(req, "ModifyCSIPLicenseUnBinds")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Bind RASP or Flagship Edition Authorization to a specified order. Execute asynchronously and return TaskId to query progress. LicenseType=rasp binds RASP, LicenseType=enterprise_hp binds flagship host authorization. AssetType is case-sensitive for host/container node/EKS.
        /// </summary>
        /// <param name="req"><see cref="ModifyCSIPRaspLicenseBindsRequest"/></param>
        /// <returns><see cref="ModifyCSIPRaspLicenseBindsResponse"/></returns>
        public Task<ModifyCSIPRaspLicenseBindsResponse> ModifyCSIPRaspLicenseBinds(ModifyCSIPRaspLicenseBindsRequest req)
        {
            return InternalRequestAsync<ModifyCSIPRaspLicenseBindsResponse>(req, "ModifyCSIPRaspLicenseBinds");
        }

        /// <summary>
        /// Bind RASP or Flagship Edition Authorization to a specified order. Execute asynchronously and return TaskId to query progress. LicenseType=rasp binds RASP, LicenseType=enterprise_hp binds flagship host authorization. AssetType is case-sensitive for host/container node/EKS.
        /// </summary>
        /// <param name="req"><see cref="ModifyCSIPRaspLicenseBindsRequest"/></param>
        /// <returns><see cref="ModifyCSIPRaspLicenseBindsResponse"/></returns>
        public ModifyCSIPRaspLicenseBindsResponse ModifyCSIPRaspLicenseBindsSync(ModifyCSIPRaspLicenseBindsRequest req)
        {
            return InternalRequestAsync<ModifyCSIPRaspLicenseBindsResponse>(req, "ModifyCSIPRaspLicenseBinds")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Manually unbind RASP authorization. Execute synchronously and return results directly. Only unbind RASP authorization (category=1), with no unbinding frequency limit. In single order mode, appid can locate the order without the need to pass ResourceId.
        /// </summary>
        /// <param name="req"><see cref="ModifyCSIPRaspLicenseUnBindsRequest"/></param>
        /// <returns><see cref="ModifyCSIPRaspLicenseUnBindsResponse"/></returns>
        public Task<ModifyCSIPRaspLicenseUnBindsResponse> ModifyCSIPRaspLicenseUnBinds(ModifyCSIPRaspLicenseUnBindsRequest req)
        {
            return InternalRequestAsync<ModifyCSIPRaspLicenseUnBindsResponse>(req, "ModifyCSIPRaspLicenseUnBinds");
        }

        /// <summary>
        /// Manually unbind RASP authorization. Execute synchronously and return results directly. Only unbind RASP authorization (category=1), with no unbinding frequency limit. In single order mode, appid can locate the order without the need to pass ResourceId.
        /// </summary>
        /// <param name="req"><see cref="ModifyCSIPRaspLicenseUnBindsRequest"/></param>
        /// <returns><see cref="ModifyCSIPRaspLicenseUnBindsResponse"/></returns>
        public ModifyCSIPRaspLicenseUnBindsResponse ModifyCSIPRaspLicenseUnBindsSync(ModifyCSIPRaspLicenseUnBindsRequest req)
        {
            return InternalRequestAsync<ModifyCSIPRaspLicenseUnBindsResponse>(req, "ModifyCSIPRaspLicenseUnBinds")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify the cluster protection status.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterDefendStatusRequest"/></param>
        /// <returns><see cref="ModifyClusterDefendStatusResponse"/></returns>
        public Task<ModifyClusterDefendStatusResponse> ModifyClusterDefendStatus(ModifyClusterDefendStatusRequest req)
        {
            return InternalRequestAsync<ModifyClusterDefendStatusResponse>(req, "ModifyClusterDefendStatus");
        }

        /// <summary>
        /// Modify the cluster protection status.
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterDefendStatusRequest"/></param>
        /// <returns><see cref="ModifyClusterDefendStatusResponse"/></returns>
        public ModifyClusterDefendStatusResponse ModifyClusterDefendStatusSync(ModifyClusterDefendStatusRequest req)
        {
            return InternalRequestAsync<ModifyClusterDefendStatusResponse>(req, "ModifyClusterDefendStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify the bucket monitoring status.
        /// </summary>
        /// <param name="req"><see cref="ModifyCosAuditBucketMonitorStatusRequest"/></param>
        /// <returns><see cref="ModifyCosAuditBucketMonitorStatusResponse"/></returns>
        public Task<ModifyCosAuditBucketMonitorStatusResponse> ModifyCosAuditBucketMonitorStatus(ModifyCosAuditBucketMonitorStatusRequest req)
        {
            return InternalRequestAsync<ModifyCosAuditBucketMonitorStatusResponse>(req, "ModifyCosAuditBucketMonitorStatus");
        }

        /// <summary>
        /// Modify the bucket monitoring status.
        /// </summary>
        /// <param name="req"><see cref="ModifyCosAuditBucketMonitorStatusRequest"/></param>
        /// <returns><see cref="ModifyCosAuditBucketMonitorStatusResponse"/></returns>
        public ModifyCosAuditBucketMonitorStatusResponse ModifyCosAuditBucketMonitorStatusSync(ModifyCosAuditBucketMonitorStatusRequest req)
        {
            return InternalRequestAsync<ModifyCosAuditBucketMonitorStatusResponse>(req, "ModifyCosAuditBucketMonitorStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Updates the CSPM automated quota manager shared switch.
        /// </summary>
        /// <param name="req"><see cref="ModifyCspmShardConfigRequest"/></param>
        /// <returns><see cref="ModifyCspmShardConfigResponse"/></returns>
        public Task<ModifyCspmShardConfigResponse> ModifyCspmShardConfig(ModifyCspmShardConfigRequest req)
        {
            return InternalRequestAsync<ModifyCspmShardConfigResponse>(req, "ModifyCspmShardConfig");
        }

        /// <summary>
        /// Updates the CSPM automated quota manager shared switch.
        /// </summary>
        /// <param name="req"><see cref="ModifyCspmShardConfigRequest"/></param>
        /// <returns><see cref="ModifyCspmShardConfigResponse"/></returns>
        public ModifyCspmShardConfigResponse ModifyCspmShardConfigSync(ModifyCspmShardConfigRequest req)
        {
            return InternalRequestAsync<ModifyCspmShardConfigResponse>(req, "ModifyCspmShardConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify Dspm access management information
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmAccessRecordRequest"/></param>
        /// <returns><see cref="ModifyDspmAccessRecordResponse"/></returns>
        public Task<ModifyDspmAccessRecordResponse> ModifyDspmAccessRecord(ModifyDspmAccessRecordRequest req)
        {
            return InternalRequestAsync<ModifyDspmAccessRecordResponse>(req, "ModifyDspmAccessRecord");
        }

        /// <summary>
        /// Modify Dspm access management information
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmAccessRecordRequest"/></param>
        /// <returns><see cref="ModifyDspmAccessRecordResponse"/></returns>
        public ModifyDspmAccessRecordResponse ModifyDspmAccessRecordSync(ModifyDspmAccessRecordRequest req)
        {
            return InternalRequestAsync<ModifyDspmAccessRecordResponse>(req, "ModifyDspmAccessRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modifies the data identification template of the current dspm application
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmApplyingIdentifyComplianceGroupRequest"/></param>
        /// <returns><see cref="ModifyDspmApplyingIdentifyComplianceGroupResponse"/></returns>
        public Task<ModifyDspmApplyingIdentifyComplianceGroupResponse> ModifyDspmApplyingIdentifyComplianceGroup(ModifyDspmApplyingIdentifyComplianceGroupRequest req)
        {
            return InternalRequestAsync<ModifyDspmApplyingIdentifyComplianceGroupResponse>(req, "ModifyDspmApplyingIdentifyComplianceGroup");
        }

        /// <summary>
        /// Modifies the data identification template of the current dspm application
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmApplyingIdentifyComplianceGroupRequest"/></param>
        /// <returns><see cref="ModifyDspmApplyingIdentifyComplianceGroupResponse"/></returns>
        public ModifyDspmApplyingIdentifyComplianceGroupResponse ModifyDspmApplyingIdentifyComplianceGroupSync(ModifyDspmApplyingIdentifyComplianceGroupRequest req)
        {
            return InternalRequestAsync<ModifyDspmApplyingIdentifyComplianceGroupResponse>(req, "ModifyDspmApplyingIdentifyComplianceGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modifies the Dspm approval form status.
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmApproveStatusRequest"/></param>
        /// <returns><see cref="ModifyDspmApproveStatusResponse"/></returns>
        public Task<ModifyDspmApproveStatusResponse> ModifyDspmApproveStatus(ModifyDspmApproveStatusRequest req)
        {
            return InternalRequestAsync<ModifyDspmApproveStatusResponse>(req, "ModifyDspmApproveStatus");
        }

        /// <summary>
        /// Modifies the Dspm approval form status.
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmApproveStatusRequest"/></param>
        /// <returns><see cref="ModifyDspmApproveStatusResponse"/></returns>
        public ModifyDspmApproveStatusResponse ModifyDspmApproveStatusSync(ModifyDspmApproveStatusRequest req)
        {
            return InternalRequestAsync<ModifyDspmApproveStatusResponse>(req, "ModifyDspmApproveStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify Dspm asset account information.
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmAssetAccountRequest"/></param>
        /// <returns><see cref="ModifyDspmAssetAccountResponse"/></returns>
        public Task<ModifyDspmAssetAccountResponse> ModifyDspmAssetAccount(ModifyDspmAssetAccountRequest req)
        {
            return InternalRequestAsync<ModifyDspmAssetAccountResponse>(req, "ModifyDspmAssetAccount");
        }

        /// <summary>
        /// Modify Dspm asset account information.
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmAssetAccountRequest"/></param>
        /// <returns><see cref="ModifyDspmAssetAccountResponse"/></returns>
        public ModifyDspmAssetAccountResponse ModifyDspmAssetAccountSync(ModifyDspmAssetAccountRequest req)
        {
            return InternalRequestAsync<ModifyDspmAssetAccountResponse>(req, "ModifyDspmAssetAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify Dspm asset account permissions
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmAssetAccountPrivilegesRequest"/></param>
        /// <returns><see cref="ModifyDspmAssetAccountPrivilegesResponse"/></returns>
        public Task<ModifyDspmAssetAccountPrivilegesResponse> ModifyDspmAssetAccountPrivileges(ModifyDspmAssetAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<ModifyDspmAssetAccountPrivilegesResponse>(req, "ModifyDspmAssetAccountPrivileges");
        }

        /// <summary>
        /// Modify Dspm asset account permissions
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmAssetAccountPrivilegesRequest"/></param>
        /// <returns><see cref="ModifyDspmAssetAccountPrivilegesResponse"/></returns>
        public ModifyDspmAssetAccountPrivilegesResponse ModifyDspmAssetAccountPrivilegesSync(ModifyDspmAssetAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<ModifyDspmAssetAccountPrivilegesResponse>(req, "ModifyDspmAssetAccountPrivileges")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modifies a Dspm Asset Data scan task
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmAssetDataScanTaskRequest"/></param>
        /// <returns><see cref="ModifyDspmAssetDataScanTaskResponse"/></returns>
        public Task<ModifyDspmAssetDataScanTaskResponse> ModifyDspmAssetDataScanTask(ModifyDspmAssetDataScanTaskRequest req)
        {
            return InternalRequestAsync<ModifyDspmAssetDataScanTaskResponse>(req, "ModifyDspmAssetDataScanTask");
        }

        /// <summary>
        /// Modifies a Dspm Asset Data scan task
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmAssetDataScanTaskRequest"/></param>
        /// <returns><see cref="ModifyDspmAssetDataScanTaskResponse"/></returns>
        public ModifyDspmAssetDataScanTaskResponse ModifyDspmAssetDataScanTaskSync(ModifyDspmAssetDataScanTaskRequest req)
        {
            return InternalRequestAsync<ModifyDspmAssetDataScanTaskResponse>(req, "ModifyDspmAssetDataScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify the status of a Dspm Asset Data scan task
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmAssetDataScanTaskStatusRequest"/></param>
        /// <returns><see cref="ModifyDspmAssetDataScanTaskStatusResponse"/></returns>
        public Task<ModifyDspmAssetDataScanTaskStatusResponse> ModifyDspmAssetDataScanTaskStatus(ModifyDspmAssetDataScanTaskStatusRequest req)
        {
            return InternalRequestAsync<ModifyDspmAssetDataScanTaskStatusResponse>(req, "ModifyDspmAssetDataScanTaskStatus");
        }

        /// <summary>
        /// Modify the status of a Dspm Asset Data scan task
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmAssetDataScanTaskStatusRequest"/></param>
        /// <returns><see cref="ModifyDspmAssetDataScanTaskStatusResponse"/></returns>
        public ModifyDspmAssetDataScanTaskStatusResponse ModifyDspmAssetDataScanTaskStatusSync(ModifyDspmAssetDataScanTaskStatusRequest req)
        {
            return InternalRequestAsync<ModifyDspmAssetDataScanTaskStatusResponse>(req, "ModifyDspmAssetDataScanTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify the Dspm asset log delivery switch.
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmAssetLogDeliverySwitchRequest"/></param>
        /// <returns><see cref="ModifyDspmAssetLogDeliverySwitchResponse"/></returns>
        public Task<ModifyDspmAssetLogDeliverySwitchResponse> ModifyDspmAssetLogDeliverySwitch(ModifyDspmAssetLogDeliverySwitchRequest req)
        {
            return InternalRequestAsync<ModifyDspmAssetLogDeliverySwitchResponse>(req, "ModifyDspmAssetLogDeliverySwitch");
        }

        /// <summary>
        /// Modify the Dspm asset log delivery switch.
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmAssetLogDeliverySwitchRequest"/></param>
        /// <returns><see cref="ModifyDspmAssetLogDeliverySwitchResponse"/></returns>
        public ModifyDspmAssetLogDeliverySwitchResponse ModifyDspmAssetLogDeliverySwitchSync(ModifyDspmAssetLogDeliverySwitchRequest req)
        {
            return InternalRequestAsync<ModifyDspmAssetLogDeliverySwitchResponse>(req, "ModifyDspmAssetLogDeliverySwitch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify the Dspm asset log delivery switch
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmAssetSecurityAnalysisSwitchRequest"/></param>
        /// <returns><see cref="ModifyDspmAssetSecurityAnalysisSwitchResponse"/></returns>
        public Task<ModifyDspmAssetSecurityAnalysisSwitchResponse> ModifyDspmAssetSecurityAnalysisSwitch(ModifyDspmAssetSecurityAnalysisSwitchRequest req)
        {
            return InternalRequestAsync<ModifyDspmAssetSecurityAnalysisSwitchResponse>(req, "ModifyDspmAssetSecurityAnalysisSwitch");
        }

        /// <summary>
        /// Modify the Dspm asset log delivery switch
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmAssetSecurityAnalysisSwitchRequest"/></param>
        /// <returns><see cref="ModifyDspmAssetSecurityAnalysisSwitchResponse"/></returns>
        public ModifyDspmAssetSecurityAnalysisSwitchResponse ModifyDspmAssetSecurityAnalysisSwitchSync(ModifyDspmAssetSecurityAnalysisSwitchRequest req)
        {
            return InternalRequestAsync<ModifyDspmAssetSecurityAnalysisSwitchResponse>(req, "ModifyDspmAssetSecurityAnalysisSwitch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify a Dspm audit filter policy
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmAuditFilterStrategyRequest"/></param>
        /// <returns><see cref="ModifyDspmAuditFilterStrategyResponse"/></returns>
        public Task<ModifyDspmAuditFilterStrategyResponse> ModifyDspmAuditFilterStrategy(ModifyDspmAuditFilterStrategyRequest req)
        {
            return InternalRequestAsync<ModifyDspmAuditFilterStrategyResponse>(req, "ModifyDspmAuditFilterStrategy");
        }

        /// <summary>
        /// Modify a Dspm audit filter policy
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmAuditFilterStrategyRequest"/></param>
        /// <returns><see cref="ModifyDspmAuditFilterStrategyResponse"/></returns>
        public ModifyDspmAuditFilterStrategyResponse ModifyDspmAuditFilterStrategySync(ModifyDspmAuditFilterStrategyRequest req)
        {
            return InternalRequestAsync<ModifyDspmAuditFilterStrategyResponse>(req, "ModifyDspmAuditFilterStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the log backup settings.
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmBackupSettingRequest"/></param>
        /// <returns><see cref="ModifyDspmBackupSettingResponse"/></returns>
        public Task<ModifyDspmBackupSettingResponse> ModifyDspmBackupSetting(ModifyDspmBackupSettingRequest req)
        {
            return InternalRequestAsync<ModifyDspmBackupSettingResponse>(req, "ModifyDspmBackupSetting");
        }

        /// <summary>
        /// This API is used to modify the log backup settings.
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmBackupSettingRequest"/></param>
        /// <returns><see cref="ModifyDspmBackupSettingResponse"/></returns>
        public ModifyDspmBackupSettingResponse ModifyDspmBackupSettingSync(ModifyDspmBackupSettingRequest req)
        {
            return InternalRequestAsync<ModifyDspmBackupSettingResponse>(req, "ModifyDspmBackupSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to save the tenant CKafka configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmCkafkaSaveRequest"/></param>
        /// <returns><see cref="ModifyDspmCkafkaSaveResponse"/></returns>
        public Task<ModifyDspmCkafkaSaveResponse> ModifyDspmCkafkaSave(ModifyDspmCkafkaSaveRequest req)
        {
            return InternalRequestAsync<ModifyDspmCkafkaSaveResponse>(req, "ModifyDspmCkafkaSave");
        }

        /// <summary>
        /// This API is used to save the tenant CKafka configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmCkafkaSaveRequest"/></param>
        /// <returns><see cref="ModifyDspmCkafkaSaveResponse"/></returns>
        public ModifyDspmCkafkaSaveResponse ModifyDspmCkafkaSaveSync(ModifyDspmCkafkaSaveRequest req)
        {
            return InternalRequestAsync<ModifyDspmCkafkaSaveResponse>(req, "ModifyDspmCkafkaSave")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable the log shipping.
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmCkafkaStartRequest"/></param>
        /// <returns><see cref="ModifyDspmCkafkaStartResponse"/></returns>
        public Task<ModifyDspmCkafkaStartResponse> ModifyDspmCkafkaStart(ModifyDspmCkafkaStartRequest req)
        {
            return InternalRequestAsync<ModifyDspmCkafkaStartResponse>(req, "ModifyDspmCkafkaStart");
        }

        /// <summary>
        /// This API is used to enable the log shipping.
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmCkafkaStartRequest"/></param>
        /// <returns><see cref="ModifyDspmCkafkaStartResponse"/></returns>
        public ModifyDspmCkafkaStartResponse ModifyDspmCkafkaStartSync(ModifyDspmCkafkaStartRequest req)
        {
            return InternalRequestAsync<ModifyDspmCkafkaStartResponse>(req, "ModifyDspmCkafkaStart")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable the log type shipping.
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmCkafkaStopRequest"/></param>
        /// <returns><see cref="ModifyDspmCkafkaStopResponse"/></returns>
        public Task<ModifyDspmCkafkaStopResponse> ModifyDspmCkafkaStop(ModifyDspmCkafkaStopRequest req)
        {
            return InternalRequestAsync<ModifyDspmCkafkaStopResponse>(req, "ModifyDspmCkafkaStop");
        }

        /// <summary>
        /// This API is used to disable the log type shipping.
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmCkafkaStopRequest"/></param>
        /// <returns><see cref="ModifyDspmCkafkaStopResponse"/></returns>
        public ModifyDspmCkafkaStopResponse ModifyDspmCkafkaStopSync(ModifyDspmCkafkaStopRequest req)
        {
            return InternalRequestAsync<ModifyDspmCkafkaStopResponse>(req, "ModifyDspmCkafkaStop")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modifies dspm data identification categorization
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmIdentifyCategoryRequest"/></param>
        /// <returns><see cref="ModifyDspmIdentifyCategoryResponse"/></returns>
        public Task<ModifyDspmIdentifyCategoryResponse> ModifyDspmIdentifyCategory(ModifyDspmIdentifyCategoryRequest req)
        {
            return InternalRequestAsync<ModifyDspmIdentifyCategoryResponse>(req, "ModifyDspmIdentifyCategory");
        }

        /// <summary>
        /// Modifies dspm data identification categorization
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmIdentifyCategoryRequest"/></param>
        /// <returns><see cref="ModifyDspmIdentifyCategoryResponse"/></returns>
        public ModifyDspmIdentifyCategoryResponse ModifyDspmIdentifyCategorySync(ModifyDspmIdentifyCategoryRequest req)
        {
            return InternalRequestAsync<ModifyDspmIdentifyCategoryResponse>(req, "ModifyDspmIdentifyCategory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modifies a dspm data identification template
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmIdentifyComplianceGroupRequest"/></param>
        /// <returns><see cref="ModifyDspmIdentifyComplianceGroupResponse"/></returns>
        public Task<ModifyDspmIdentifyComplianceGroupResponse> ModifyDspmIdentifyComplianceGroup(ModifyDspmIdentifyComplianceGroupRequest req)
        {
            return InternalRequestAsync<ModifyDspmIdentifyComplianceGroupResponse>(req, "ModifyDspmIdentifyComplianceGroup");
        }

        /// <summary>
        /// Modifies a dspm data identification template
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmIdentifyComplianceGroupRequest"/></param>
        /// <returns><see cref="ModifyDspmIdentifyComplianceGroupResponse"/></returns>
        public ModifyDspmIdentifyComplianceGroupResponse ModifyDspmIdentifyComplianceGroupSync(ModifyDspmIdentifyComplianceGroupRequest req)
        {
            return InternalRequestAsync<ModifyDspmIdentifyComplianceGroupResponse>(req, "ModifyDspmIdentifyComplianceGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modifies the status of a dspm data identification template
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmIdentifyComplianceGroupStatusRequest"/></param>
        /// <returns><see cref="ModifyDspmIdentifyComplianceGroupStatusResponse"/></returns>
        public Task<ModifyDspmIdentifyComplianceGroupStatusResponse> ModifyDspmIdentifyComplianceGroupStatus(ModifyDspmIdentifyComplianceGroupStatusRequest req)
        {
            return InternalRequestAsync<ModifyDspmIdentifyComplianceGroupStatusResponse>(req, "ModifyDspmIdentifyComplianceGroupStatus");
        }

        /// <summary>
        /// Modifies the status of a dspm data identification template
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmIdentifyComplianceGroupStatusRequest"/></param>
        /// <returns><see cref="ModifyDspmIdentifyComplianceGroupStatusResponse"/></returns>
        public ModifyDspmIdentifyComplianceGroupStatusResponse ModifyDspmIdentifyComplianceGroupStatusSync(ModifyDspmIdentifyComplianceGroupStatusRequest req)
        {
            return InternalRequestAsync<ModifyDspmIdentifyComplianceGroupStatusResponse>(req, "ModifyDspmIdentifyComplianceGroupStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify association level information of dspm data identification template data items.
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmIdentifyComplianceRuleLevelInfoRequest"/></param>
        /// <returns><see cref="ModifyDspmIdentifyComplianceRuleLevelInfoResponse"/></returns>
        public Task<ModifyDspmIdentifyComplianceRuleLevelInfoResponse> ModifyDspmIdentifyComplianceRuleLevelInfo(ModifyDspmIdentifyComplianceRuleLevelInfoRequest req)
        {
            return InternalRequestAsync<ModifyDspmIdentifyComplianceRuleLevelInfoResponse>(req, "ModifyDspmIdentifyComplianceRuleLevelInfo");
        }

        /// <summary>
        /// This API is used to modify association level information of dspm data identification template data items.
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmIdentifyComplianceRuleLevelInfoRequest"/></param>
        /// <returns><see cref="ModifyDspmIdentifyComplianceRuleLevelInfoResponse"/></returns>
        public ModifyDspmIdentifyComplianceRuleLevelInfoResponse ModifyDspmIdentifyComplianceRuleLevelInfoSync(ModifyDspmIdentifyComplianceRuleLevelInfoRequest req)
        {
            return InternalRequestAsync<ModifyDspmIdentifyComplianceRuleLevelInfoResponse>(req, "ModifyDspmIdentifyComplianceRuleLevelInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify Dspm identity information.
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmIdentifyInfoRequest"/></param>
        /// <returns><see cref="ModifyDspmIdentifyInfoResponse"/></returns>
        public Task<ModifyDspmIdentifyInfoResponse> ModifyDspmIdentifyInfo(ModifyDspmIdentifyInfoRequest req)
        {
            return InternalRequestAsync<ModifyDspmIdentifyInfoResponse>(req, "ModifyDspmIdentifyInfo");
        }

        /// <summary>
        /// Modify Dspm identity information.
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmIdentifyInfoRequest"/></param>
        /// <returns><see cref="ModifyDspmIdentifyInfoResponse"/></returns>
        public ModifyDspmIdentifyInfoResponse ModifyDspmIdentifyInfoSync(ModifyDspmIdentifyInfoRequest req)
        {
            return InternalRequestAsync<ModifyDspmIdentifyInfoResponse>(req, "ModifyDspmIdentifyInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modifies dspm data identification classification groups
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmIdentifyLevelGroupRequest"/></param>
        /// <returns><see cref="ModifyDspmIdentifyLevelGroupResponse"/></returns>
        public Task<ModifyDspmIdentifyLevelGroupResponse> ModifyDspmIdentifyLevelGroup(ModifyDspmIdentifyLevelGroupRequest req)
        {
            return InternalRequestAsync<ModifyDspmIdentifyLevelGroupResponse>(req, "ModifyDspmIdentifyLevelGroup");
        }

        /// <summary>
        /// Modifies dspm data identification classification groups
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmIdentifyLevelGroupRequest"/></param>
        /// <returns><see cref="ModifyDspmIdentifyLevelGroupResponse"/></returns>
        public ModifyDspmIdentifyLevelGroupResponse ModifyDspmIdentifyLevelGroupSync(ModifyDspmIdentifyLevelGroupRequest req)
        {
            return InternalRequestAsync<ModifyDspmIdentifyLevelGroupResponse>(req, "ModifyDspmIdentifyLevelGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify dspm data identification grading information.
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmIdentifyLevelItemRequest"/></param>
        /// <returns><see cref="ModifyDspmIdentifyLevelItemResponse"/></returns>
        public Task<ModifyDspmIdentifyLevelItemResponse> ModifyDspmIdentifyLevelItem(ModifyDspmIdentifyLevelItemRequest req)
        {
            return InternalRequestAsync<ModifyDspmIdentifyLevelItemResponse>(req, "ModifyDspmIdentifyLevelItem");
        }

        /// <summary>
        /// Modify dspm data identification grading information.
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmIdentifyLevelItemRequest"/></param>
        /// <returns><see cref="ModifyDspmIdentifyLevelItemResponse"/></returns>
        public ModifyDspmIdentifyLevelItemResponse ModifyDspmIdentifyLevelItemSync(ModifyDspmIdentifyLevelItemRequest req)
        {
            return InternalRequestAsync<ModifyDspmIdentifyLevelItemResponse>(req, "ModifyDspmIdentifyLevelItem")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify a dspm identification data item
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmIdentifyRuleRequest"/></param>
        /// <returns><see cref="ModifyDspmIdentifyRuleResponse"/></returns>
        public Task<ModifyDspmIdentifyRuleResponse> ModifyDspmIdentifyRule(ModifyDspmIdentifyRuleRequest req)
        {
            return InternalRequestAsync<ModifyDspmIdentifyRuleResponse>(req, "ModifyDspmIdentifyRule");
        }

        /// <summary>
        /// Modify a dspm identification data item
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmIdentifyRuleRequest"/></param>
        /// <returns><see cref="ModifyDspmIdentifyRuleResponse"/></returns>
        public ModifyDspmIdentifyRuleResponse ModifyDspmIdentifyRuleSync(ModifyDspmIdentifyRuleRequest req)
        {
            return InternalRequestAsync<ModifyDspmIdentifyRuleResponse>(req, "ModifyDspmIdentifyRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modifies the status of a dspm identification data item
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmIdentifyRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyDspmIdentifyRuleStatusResponse"/></returns>
        public Task<ModifyDspmIdentifyRuleStatusResponse> ModifyDspmIdentifyRuleStatus(ModifyDspmIdentifyRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyDspmIdentifyRuleStatusResponse>(req, "ModifyDspmIdentifyRuleStatus");
        }

        /// <summary>
        /// Modifies the status of a dspm identification data item
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmIdentifyRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyDspmIdentifyRuleStatusResponse"/></returns>
        public ModifyDspmIdentifyRuleStatusResponse ModifyDspmIdentifyRuleStatusSync(ModifyDspmIdentifyRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyDspmIdentifyRuleStatusResponse>(req, "ModifyDspmIdentifyRuleStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify DspmIp information.
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmIpInfoRequest"/></param>
        /// <returns><see cref="ModifyDspmIpInfoResponse"/></returns>
        public Task<ModifyDspmIpInfoResponse> ModifyDspmIpInfo(ModifyDspmIpInfoRequest req)
        {
            return InternalRequestAsync<ModifyDspmIpInfoResponse>(req, "ModifyDspmIpInfo");
        }

        /// <summary>
        /// Modify DspmIp information.
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmIpInfoRequest"/></param>
        /// <returns><see cref="ModifyDspmIpInfoResponse"/></returns>
        public ModifyDspmIpInfoResponse ModifyDspmIpInfoSync(ModifyDspmIpInfoRequest req)
        {
            return InternalRequestAsync<ModifyDspmIpInfoResponse>(req, "ModifyDspmIpInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the log shipping configuration information.
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmLogDeliveryTypeRequest"/></param>
        /// <returns><see cref="ModifyDspmLogDeliveryTypeResponse"/></returns>
        public Task<ModifyDspmLogDeliveryTypeResponse> ModifyDspmLogDeliveryType(ModifyDspmLogDeliveryTypeRequest req)
        {
            return InternalRequestAsync<ModifyDspmLogDeliveryTypeResponse>(req, "ModifyDspmLogDeliveryType");
        }

        /// <summary>
        /// This API is used to modify the log shipping configuration information.
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmLogDeliveryTypeRequest"/></param>
        /// <returns><see cref="ModifyDspmLogDeliveryTypeResponse"/></returns>
        public ModifyDspmLogDeliveryTypeResponse ModifyDspmLogDeliveryTypeSync(ModifyDspmLogDeliveryTypeRequest req)
        {
            return InternalRequestAsync<ModifyDspmLogDeliveryTypeResponse>(req, "ModifyDspmLogDeliveryType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modifies the Dspm personal identity ID.
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmPersonalIdentifyRequest"/></param>
        /// <returns><see cref="ModifyDspmPersonalIdentifyResponse"/></returns>
        public Task<ModifyDspmPersonalIdentifyResponse> ModifyDspmPersonalIdentify(ModifyDspmPersonalIdentifyRequest req)
        {
            return InternalRequestAsync<ModifyDspmPersonalIdentifyResponse>(req, "ModifyDspmPersonalIdentify");
        }

        /// <summary>
        /// Modifies the Dspm personal identity ID.
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmPersonalIdentifyRequest"/></param>
        /// <returns><see cref="ModifyDspmPersonalIdentifyResponse"/></returns>
        public ModifyDspmPersonalIdentifyResponse ModifyDspmPersonalIdentifySync(ModifyDspmPersonalIdentifyRequest req)
        {
            return InternalRequestAsync<ModifyDspmPersonalIdentifyResponse>(req, "ModifyDspmPersonalIdentify")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to restore the backup logs.
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmRestoreLogTaskRequest"/></param>
        /// <returns><see cref="ModifyDspmRestoreLogTaskResponse"/></returns>
        public Task<ModifyDspmRestoreLogTaskResponse> ModifyDspmRestoreLogTask(ModifyDspmRestoreLogTaskRequest req)
        {
            return InternalRequestAsync<ModifyDspmRestoreLogTaskResponse>(req, "ModifyDspmRestoreLogTask");
        }

        /// <summary>
        /// This API is used to restore the backup logs.
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmRestoreLogTaskRequest"/></param>
        /// <returns><see cref="ModifyDspmRestoreLogTaskResponse"/></returns>
        public ModifyDspmRestoreLogTaskResponse ModifyDspmRestoreLogTaskSync(ModifyDspmRestoreLogTaskRequest req)
        {
            return InternalRequestAsync<ModifyDspmRestoreLogTaskResponse>(req, "ModifyDspmRestoreLogTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modifies Dspm risk information
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmRiskInfoRequest"/></param>
        /// <returns><see cref="ModifyDspmRiskInfoResponse"/></returns>
        public Task<ModifyDspmRiskInfoResponse> ModifyDspmRiskInfo(ModifyDspmRiskInfoRequest req)
        {
            return InternalRequestAsync<ModifyDspmRiskInfoResponse>(req, "ModifyDspmRiskInfo");
        }

        /// <summary>
        /// Modifies Dspm risk information
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmRiskInfoRequest"/></param>
        /// <returns><see cref="ModifyDspmRiskInfoResponse"/></returns>
        public ModifyDspmRiskInfoResponse ModifyDspmRiskInfoSync(ModifyDspmRiskInfoRequest req)
        {
            return InternalRequestAsync<ModifyDspmRiskInfoResponse>(req, "ModifyDspmRiskInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modifies Dspm risk policies
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmRiskStrategyRequest"/></param>
        /// <returns><see cref="ModifyDspmRiskStrategyResponse"/></returns>
        public Task<ModifyDspmRiskStrategyResponse> ModifyDspmRiskStrategy(ModifyDspmRiskStrategyRequest req)
        {
            return InternalRequestAsync<ModifyDspmRiskStrategyResponse>(req, "ModifyDspmRiskStrategy");
        }

        /// <summary>
        /// Modifies Dspm risk policies
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmRiskStrategyRequest"/></param>
        /// <returns><see cref="ModifyDspmRiskStrategyResponse"/></returns>
        public ModifyDspmRiskStrategyResponse ModifyDspmRiskStrategySync(ModifyDspmRiskStrategyRequest req)
        {
            return InternalRequestAsync<ModifyDspmRiskStrategyResponse>(req, "ModifyDspmRiskStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify the Dspm allowlist policy
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmWhitelistStrategyRequest"/></param>
        /// <returns><see cref="ModifyDspmWhitelistStrategyResponse"/></returns>
        public Task<ModifyDspmWhitelistStrategyResponse> ModifyDspmWhitelistStrategy(ModifyDspmWhitelistStrategyRequest req)
        {
            return InternalRequestAsync<ModifyDspmWhitelistStrategyResponse>(req, "ModifyDspmWhitelistStrategy");
        }

        /// <summary>
        /// Modify the Dspm allowlist policy
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmWhitelistStrategyRequest"/></param>
        /// <returns><see cref="ModifyDspmWhitelistStrategyResponse"/></returns>
        public ModifyDspmWhitelistStrategyResponse ModifyDspmWhitelistStrategySync(ModifyDspmWhitelistStrategyRequest req)
        {
            return InternalRequestAsync<ModifyDspmWhitelistStrategyResponse>(req, "ModifyDspmWhitelistStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to edit or create an EDR policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyEDRRuleRequest"/></param>
        /// <returns><see cref="ModifyEDRRuleResponse"/></returns>
        public Task<ModifyEDRRuleResponse> ModifyEDRRule(ModifyEDRRuleRequest req)
        {
            return InternalRequestAsync<ModifyEDRRuleResponse>(req, "ModifyEDRRule");
        }

        /// <summary>
        /// This API is used to edit or create an EDR policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyEDRRuleRequest"/></param>
        /// <returns><see cref="ModifyEDRRuleResponse"/></returns>
        public ModifyEDRRuleResponse ModifyEDRRuleSync(ModifyEDRRuleRequest req)
        {
            return InternalRequestAsync<ModifyEDRRuleResponse>(req, "ModifyEDRRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the switch status of EDR policies.
        /// </summary>
        /// <param name="req"><see cref="ModifyEDRRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyEDRRuleStatusResponse"/></returns>
        public Task<ModifyEDRRuleStatusResponse> ModifyEDRRuleStatus(ModifyEDRRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyEDRRuleStatusResponse>(req, "ModifyEDRRuleStatus");
        }

        /// <summary>
        /// This API is used to modify the switch status of EDR policies.
        /// </summary>
        /// <param name="req"><see cref="ModifyEDRRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyEDRRuleStatusResponse"/></returns>
        public ModifyEDRRuleStatusResponse ModifyEDRRuleStatusSync(ModifyEDRRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyEDRRuleStatusResponse>(req, "ModifyEDRRuleStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Batch modify EDR policy actions.
        /// </summary>
        /// <param name="req"><see cref="ModifyEDRRulesActionRequest"/></param>
        /// <returns><see cref="ModifyEDRRulesActionResponse"/></returns>
        public Task<ModifyEDRRulesActionResponse> ModifyEDRRulesAction(ModifyEDRRulesActionRequest req)
        {
            return InternalRequestAsync<ModifyEDRRulesActionResponse>(req, "ModifyEDRRulesAction");
        }

        /// <summary>
        /// Batch modify EDR policy actions.
        /// </summary>
        /// <param name="req"><see cref="ModifyEDRRulesActionRequest"/></param>
        /// <returns><see cref="ModifyEDRRulesActionResponse"/></returns>
        public ModifyEDRRulesActionResponse ModifyEDRRulesActionSync(ModifyEDRRulesActionRequest req)
        {
            return InternalRequestAsync<ModifyEDRRulesActionResponse>(req, "ModifyEDRRulesAction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// EDR alert quarantine and recovery
        /// </summary>
        /// <param name="req"><see cref="ModifyEdrAlertIsolationRequest"/></param>
        /// <returns><see cref="ModifyEdrAlertIsolationResponse"/></returns>
        public Task<ModifyEdrAlertIsolationResponse> ModifyEdrAlertIsolation(ModifyEdrAlertIsolationRequest req)
        {
            return InternalRequestAsync<ModifyEdrAlertIsolationResponse>(req, "ModifyEdrAlertIsolation");
        }

        /// <summary>
        /// EDR alert quarantine and recovery
        /// </summary>
        /// <param name="req"><see cref="ModifyEdrAlertIsolationRequest"/></param>
        /// <returns><see cref="ModifyEdrAlertIsolationResponse"/></returns>
        public ModifyEdrAlertIsolationResponse ModifyEdrAlertIsolationSync(ModifyEdrAlertIsolationRequest req)
        {
            return InternalRequestAsync<ModifyEdrAlertIsolationResponse>(req, "ModifyEdrAlertIsolation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Permanently ignore EDR multi-behavior alarms. Add the host and rule corresponding to the alarm to the AI-Link permanent ignore allowlist. Subsequently, alarms of the same type will be automatically discarded.
        /// </summary>
        /// <param name="req"><see cref="ModifyEdrAlertPermanentIgnoreRequest"/></param>
        /// <returns><see cref="ModifyEdrAlertPermanentIgnoreResponse"/></returns>
        public Task<ModifyEdrAlertPermanentIgnoreResponse> ModifyEdrAlertPermanentIgnore(ModifyEdrAlertPermanentIgnoreRequest req)
        {
            return InternalRequestAsync<ModifyEdrAlertPermanentIgnoreResponse>(req, "ModifyEdrAlertPermanentIgnore");
        }

        /// <summary>
        /// Permanently ignore EDR multi-behavior alarms. Add the host and rule corresponding to the alarm to the AI-Link permanent ignore allowlist. Subsequently, alarms of the same type will be automatically discarded.
        /// </summary>
        /// <param name="req"><see cref="ModifyEdrAlertPermanentIgnoreRequest"/></param>
        /// <returns><see cref="ModifyEdrAlertPermanentIgnoreResponse"/></returns>
        public ModifyEdrAlertPermanentIgnoreResponse ModifyEdrAlertPermanentIgnoreSync(ModifyEdrAlertPermanentIgnoreRequest req)
        {
            return InternalRequestAsync<ModifyEdrAlertPermanentIgnoreResponse>(req, "ModifyEdrAlertPermanentIgnore")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Handle the status of an EDR alert
        /// </summary>
        /// <param name="req"><see cref="ModifyEdrAlertStatusRequest"/></param>
        /// <returns><see cref="ModifyEdrAlertStatusResponse"/></returns>
        public Task<ModifyEdrAlertStatusResponse> ModifyEdrAlertStatus(ModifyEdrAlertStatusRequest req)
        {
            return InternalRequestAsync<ModifyEdrAlertStatusResponse>(req, "ModifyEdrAlertStatus");
        }

        /// <summary>
        /// Handle the status of an EDR alert
        /// </summary>
        /// <param name="req"><see cref="ModifyEdrAlertStatusRequest"/></param>
        /// <returns><see cref="ModifyEdrAlertStatusResponse"/></returns>
        public ModifyEdrAlertStatusResponse ModifyEdrAlertStatusSync(ModifyEdrAlertStatusRequest req)
        {
            return InternalRequestAsync<ModifyEdrAlertStatusResponse>(req, "ModifyEdrAlertStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the CIDR block exclusion settings for log collection. IPs, IP ranges, and CIDR formats are supported, with up to 100 entries.
        /// </summary>
        /// <param name="req"><see cref="ModifyEdrExcludeNetworkSegmentsRequest"/></param>
        /// <returns><see cref="ModifyEdrExcludeNetworkSegmentsResponse"/></returns>
        public Task<ModifyEdrExcludeNetworkSegmentsResponse> ModifyEdrExcludeNetworkSegments(ModifyEdrExcludeNetworkSegmentsRequest req)
        {
            return InternalRequestAsync<ModifyEdrExcludeNetworkSegmentsResponse>(req, "ModifyEdrExcludeNetworkSegments");
        }

        /// <summary>
        /// This API is used to modify the CIDR block exclusion settings for log collection. IPs, IP ranges, and CIDR formats are supported, with up to 100 entries.
        /// </summary>
        /// <param name="req"><see cref="ModifyEdrExcludeNetworkSegmentsRequest"/></param>
        /// <returns><see cref="ModifyEdrExcludeNetworkSegmentsResponse"/></returns>
        public ModifyEdrExcludeNetworkSegmentsResponse ModifyEdrExcludeNetworkSegmentsSync(ModifyEdrExcludeNetworkSegmentsRequest req)
        {
            return InternalRequestAsync<ModifyEdrExcludeNetworkSegmentsResponse>(req, "ModifyEdrExcludeNetworkSegments")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify path configurations for application log collection.
        /// </summary>
        /// <param name="req"><see cref="ModifyEdrLogCollectPathRequest"/></param>
        /// <returns><see cref="ModifyEdrLogCollectPathResponse"/></returns>
        public Task<ModifyEdrLogCollectPathResponse> ModifyEdrLogCollectPath(ModifyEdrLogCollectPathRequest req)
        {
            return InternalRequestAsync<ModifyEdrLogCollectPathResponse>(req, "ModifyEdrLogCollectPath");
        }

        /// <summary>
        /// This API is used to modify path configurations for application log collection.
        /// </summary>
        /// <param name="req"><see cref="ModifyEdrLogCollectPathRequest"/></param>
        /// <returns><see cref="ModifyEdrLogCollectPathResponse"/></returns>
        public ModifyEdrLogCollectPathResponse ModifyEdrLogCollectPathSync(ModifyEdrLogCollectPathRequest req)
        {
            return InternalRequestAsync<ModifyEdrLogCollectPathResponse>(req, "ModifyEdrLogCollectPath")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update automatic cloud boundary tagging rules
        /// </summary>
        /// <param name="req"><see cref="ModifyExposureAutoTagRuleRequest"/></param>
        /// <returns><see cref="ModifyExposureAutoTagRuleResponse"/></returns>
        public Task<ModifyExposureAutoTagRuleResponse> ModifyExposureAutoTagRule(ModifyExposureAutoTagRuleRequest req)
        {
            return InternalRequestAsync<ModifyExposureAutoTagRuleResponse>(req, "ModifyExposureAutoTagRule");
        }

        /// <summary>
        /// Update automatic cloud boundary tagging rules
        /// </summary>
        /// <param name="req"><see cref="ModifyExposureAutoTagRuleRequest"/></param>
        /// <returns><see cref="ModifyExposureAutoTagRuleResponse"/></returns>
        public ModifyExposureAutoTagRuleResponse ModifyExposureAutoTagRuleSync(ModifyExposureAutoTagRuleRequest req)
        {
            return InternalRequestAsync<ModifyExposureAutoTagRuleResponse>(req, "ModifyExposureAutoTagRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Enable or disable automatic cloud boundary tagging rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyExposureAutoTagRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyExposureAutoTagRuleStatusResponse"/></returns>
        public Task<ModifyExposureAutoTagRuleStatusResponse> ModifyExposureAutoTagRuleStatus(ModifyExposureAutoTagRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyExposureAutoTagRuleStatusResponse>(req, "ModifyExposureAutoTagRuleStatus");
        }

        /// <summary>
        /// Enable or disable automatic cloud boundary tagging rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyExposureAutoTagRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyExposureAutoTagRuleStatusResponse"/></returns>
        public ModifyExposureAutoTagRuleStatusResponse ModifyExposureAutoTagRuleStatusSync(ModifyExposureAutoTagRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyExposureAutoTagRuleStatusResponse>(req, "ModifyExposureAutoTagRuleStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update custom tags for cloud boundaries
        /// </summary>
        /// <param name="req"><see cref="ModifyExposureTagRequest"/></param>
        /// <returns><see cref="ModifyExposureTagResponse"/></returns>
        public Task<ModifyExposureTagResponse> ModifyExposureTag(ModifyExposureTagRequest req)
        {
            return InternalRequestAsync<ModifyExposureTagResponse>(req, "ModifyExposureTag");
        }

        /// <summary>
        /// Update custom tags for cloud boundaries
        /// </summary>
        /// <param name="req"><see cref="ModifyExposureTagRequest"/></param>
        /// <returns><see cref="ModifyExposureTagResponse"/></returns>
        public ModifyExposureTagResponse ModifyExposureTagSync(ModifyExposureTagRequest req)
        {
            return InternalRequestAsync<ModifyExposureTagResponse>(req, "ModifyExposureTag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify the storage cycle of IaC detection integration tokens.
        /// </summary>
        /// <param name="req"><see cref="ModifyIaCTokenPeriodRequest"/></param>
        /// <returns><see cref="ModifyIaCTokenPeriodResponse"/></returns>
        public Task<ModifyIaCTokenPeriodResponse> ModifyIaCTokenPeriod(ModifyIaCTokenPeriodRequest req)
        {
            return InternalRequestAsync<ModifyIaCTokenPeriodResponse>(req, "ModifyIaCTokenPeriod");
        }

        /// <summary>
        /// Modify the storage cycle of IaC detection integration tokens.
        /// </summary>
        /// <param name="req"><see cref="ModifyIaCTokenPeriodRequest"/></param>
        /// <returns><see cref="ModifyIaCTokenPeriodResponse"/></returns>
        public ModifyIaCTokenPeriodResponse ModifyIaCTokenPeriodSync(ModifyIaCTokenPeriodRequest req)
        {
            return InternalRequestAsync<ModifyIaCTokenPeriodResponse>(req, "ModifyIaCTokenPeriod")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify image repository information.
        /// </summary>
        /// <param name="req"><see cref="ModifyImageRegistryRequest"/></param>
        /// <returns><see cref="ModifyImageRegistryResponse"/></returns>
        public Task<ModifyImageRegistryResponse> ModifyImageRegistry(ModifyImageRegistryRequest req)
        {
            return InternalRequestAsync<ModifyImageRegistryResponse>(req, "ModifyImageRegistry");
        }

        /// <summary>
        /// Modify image repository information.
        /// </summary>
        /// <param name="req"><see cref="ModifyImageRegistryRequest"/></param>
        /// <returns><see cref="ModifyImageRegistryResponse"/></returns>
        public ModifyImageRegistryResponse ModifyImageRegistrySync(ModifyImageRegistryRequest req)
        {
            return InternalRequestAsync<ModifyImageRegistryResponse>(req, "ModifyImageRegistry")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify the scheduled scan task configuration of an image repository
        /// </summary>
        /// <param name="req"><see cref="ModifyImageRegistryTimedScanTaskConfigRequest"/></param>
        /// <returns><see cref="ModifyImageRegistryTimedScanTaskConfigResponse"/></returns>
        public Task<ModifyImageRegistryTimedScanTaskConfigResponse> ModifyImageRegistryTimedScanTaskConfig(ModifyImageRegistryTimedScanTaskConfigRequest req)
        {
            return InternalRequestAsync<ModifyImageRegistryTimedScanTaskConfigResponse>(req, "ModifyImageRegistryTimedScanTaskConfig");
        }

        /// <summary>
        /// Modify the scheduled scan task configuration of an image repository
        /// </summary>
        /// <param name="req"><see cref="ModifyImageRegistryTimedScanTaskConfigRequest"/></param>
        /// <returns><see cref="ModifyImageRegistryTimedScanTaskConfigResponse"/></returns>
        public ModifyImageRegistryTimedScanTaskConfigResponse ModifyImageRegistryTimedScanTaskConfigSync(ModifyImageRegistryTimedScanTaskConfigRequest req)
        {
            return InternalRequestAsync<ModifyImageRegistryTimedScanTaskConfigResponse>(req, "ModifyImageRegistryTimedScanTaskConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modifies the Sensitive Information Allowlist of a Container Image
        /// </summary>
        /// <param name="req"><see cref="ModifyImageSensitiveWhitelistRequest"/></param>
        /// <returns><see cref="ModifyImageSensitiveWhitelistResponse"/></returns>
        public Task<ModifyImageSensitiveWhitelistResponse> ModifyImageSensitiveWhitelist(ModifyImageSensitiveWhitelistRequest req)
        {
            return InternalRequestAsync<ModifyImageSensitiveWhitelistResponse>(req, "ModifyImageSensitiveWhitelist");
        }

        /// <summary>
        /// Modifies the Sensitive Information Allowlist of a Container Image
        /// </summary>
        /// <param name="req"><see cref="ModifyImageSensitiveWhitelistRequest"/></param>
        /// <returns><see cref="ModifyImageSensitiveWhitelistResponse"/></returns>
        public ModifyImageSensitiveWhitelistResponse ModifyImageSensitiveWhitelistSync(ModifyImageSensitiveWhitelistRequest req)
        {
            return InternalRequestAsync<ModifyImageSensitiveWhitelistResponse>(req, "ModifyImageSensitiveWhitelist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query asset database information.
        /// </summary>
        /// <param name="req"><see cref="ModifyImageVirusWhitelistRequest"/></param>
        /// <returns><see cref="ModifyImageVirusWhitelistResponse"/></returns>
        public Task<ModifyImageVirusWhitelistResponse> ModifyImageVirusWhitelist(ModifyImageVirusWhitelistRequest req)
        {
            return InternalRequestAsync<ModifyImageVirusWhitelistResponse>(req, "ModifyImageVirusWhitelist");
        }

        /// <summary>
        /// This API is used to query asset database information.
        /// </summary>
        /// <param name="req"><see cref="ModifyImageVirusWhitelistRequest"/></param>
        /// <returns><see cref="ModifyImageVirusWhitelistResponse"/></returns>
        public ModifyImageVirusWhitelistResponse ModifyImageVirusWhitelistSync(ModifyImageVirusWhitelistRequest req)
        {
            return InternalRequestAsync<ModifyImageVirusWhitelistResponse>(req, "ModifyImageVirusWhitelist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modifies the vulnerability allowlist of a container image.
        /// </summary>
        /// <param name="req"><see cref="ModifyImageVulWhitelistRequest"/></param>
        /// <returns><see cref="ModifyImageVulWhitelistResponse"/></returns>
        public Task<ModifyImageVulWhitelistResponse> ModifyImageVulWhitelist(ModifyImageVulWhitelistRequest req)
        {
            return InternalRequestAsync<ModifyImageVulWhitelistResponse>(req, "ModifyImageVulWhitelist");
        }

        /// <summary>
        /// Modifies the vulnerability allowlist of a container image.
        /// </summary>
        /// <param name="req"><see cref="ModifyImageVulWhitelistRequest"/></param>
        /// <returns><see cref="ModifyImageVulWhitelistResponse"/></returns>
        public ModifyImageVulWhitelistResponse ModifyImageVulWhitelistSync(ModifyImageVulWhitelistRequest req)
        {
            return InternalRequestAsync<ModifyImageVulWhitelistResponse>(req, "ModifyImageVulWhitelist")
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
        /// Modify the remark information of a host asset
        /// </summary>
        /// <param name="req"><see cref="ModifyMachineRemarkRequest"/></param>
        /// <returns><see cref="ModifyMachineRemarkResponse"/></returns>
        public Task<ModifyMachineRemarkResponse> ModifyMachineRemark(ModifyMachineRemarkRequest req)
        {
            return InternalRequestAsync<ModifyMachineRemarkResponse>(req, "ModifyMachineRemark");
        }

        /// <summary>
        /// Modify the remark information of a host asset
        /// </summary>
        /// <param name="req"><see cref="ModifyMachineRemarkRequest"/></param>
        /// <returns><see cref="ModifyMachineRemarkResponse"/></returns>
        public ModifyMachineRemarkResponse ModifyMachineRemarkSync(ModifyMachineRemarkRequest req)
        {
            return InternalRequestAsync<ModifyMachineRemarkResponse>(req, "ModifyMachineRemark")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify host login methods in batches.
        /// </summary>
        /// <param name="req"><see cref="ModifyMachinesLoginTypeRequest"/></param>
        /// <returns><see cref="ModifyMachinesLoginTypeResponse"/></returns>
        public Task<ModifyMachinesLoginTypeResponse> ModifyMachinesLoginType(ModifyMachinesLoginTypeRequest req)
        {
            return InternalRequestAsync<ModifyMachinesLoginTypeResponse>(req, "ModifyMachinesLoginType");
        }

        /// <summary>
        /// This API is used to modify host login methods in batches.
        /// </summary>
        /// <param name="req"><see cref="ModifyMachinesLoginTypeRequest"/></param>
        /// <returns><see cref="ModifyMachinesLoginTypeResponse"/></returns>
        public ModifyMachinesLoginTypeResponse ModifyMachinesLoginTypeSync(ModifyMachinesLoginTypeRequest req)
        {
            return InternalRequestAsync<ModifyMachinesLoginTypeResponse>(req, "ModifyMachinesLoginType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify the scheduled scan configuration for malicious file scan, including scan cycle, detection mode, asset scope, engine selection, and quarantine configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyMalwareTimingScanSettingsRequest"/></param>
        /// <returns><see cref="ModifyMalwareTimingScanSettingsResponse"/></returns>
        public Task<ModifyMalwareTimingScanSettingsResponse> ModifyMalwareTimingScanSettings(ModifyMalwareTimingScanSettingsRequest req)
        {
            return InternalRequestAsync<ModifyMalwareTimingScanSettingsResponse>(req, "ModifyMalwareTimingScanSettings");
        }

        /// <summary>
        /// Modify the scheduled scan configuration for malicious file scan, including scan cycle, detection mode, asset scope, engine selection, and quarantine configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyMalwareTimingScanSettingsRequest"/></param>
        /// <returns><see cref="ModifyMalwareTimingScanSettingsResponse"/></returns>
        public ModifyMalwareTimingScanSettingsResponse ModifyMalwareTimingScanSettingsSync(ModifyMalwareTimingScanSettingsRequest req)
        {
            return InternalRequestAsync<ModifyMalwareTimingScanSettingsResponse>(req, "ModifyMalwareTimingScanSettings")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add or update the global configuration for NFS scanning.
        /// </summary>
        /// <param name="req"><see cref="ModifyNFSScanConfRequest"/></param>
        /// <returns><see cref="ModifyNFSScanConfResponse"/></returns>
        public Task<ModifyNFSScanConfResponse> ModifyNFSScanConf(ModifyNFSScanConfRequest req)
        {
            return InternalRequestAsync<ModifyNFSScanConfResponse>(req, "ModifyNFSScanConf");
        }

        /// <summary>
        /// This API is used to add or update the global configuration for NFS scanning.
        /// </summary>
        /// <param name="req"><see cref="ModifyNFSScanConfRequest"/></param>
        /// <returns><see cref="ModifyNFSScanConfResponse"/></returns>
        public ModifyNFSScanConfResponse ModifyNFSScanConfSync(ModifyNFSScanConfRequest req)
        {
            return InternalRequestAsync<ModifyNFSScanConfResponse>(req, "ModifyNFSScanConf")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable process guard.
        /// </summary>
        /// <param name="req"><see cref="ModifyNFSScanHostRequest"/></param>
        /// <returns><see cref="ModifyNFSScanHostResponse"/></returns>
        public Task<ModifyNFSScanHostResponse> ModifyNFSScanHost(ModifyNFSScanHostRequest req)
        {
            return InternalRequestAsync<ModifyNFSScanHostResponse>(req, "ModifyNFSScanHost");
        }

        /// <summary>
        /// This API is used to disable process guard.
        /// </summary>
        /// <param name="req"><see cref="ModifyNFSScanHostRequest"/></param>
        /// <returns><see cref="ModifyNFSScanHostResponse"/></returns>
        public ModifyNFSScanHostResponse ModifyNFSScanHostSync(ModifyNFSScanHostRequest req)
        {
            return InternalRequestAsync<ModifyNFSScanHostResponse>(req, "ModifyNFSScanHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify the network attack detection switch and asset scope configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyNetAttackSettingRequest"/></param>
        /// <returns><see cref="ModifyNetAttackSettingResponse"/></returns>
        public Task<ModifyNetAttackSettingResponse> ModifyNetAttackSetting(ModifyNetAttackSettingRequest req)
        {
            return InternalRequestAsync<ModifyNetAttackSettingResponse>(req, "ModifyNetAttackSetting");
        }

        /// <summary>
        /// Modify the network attack detection switch and asset scope configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyNetAttackSettingRequest"/></param>
        /// <returns><see cref="ModifyNetAttackSettingResponse"/></returns>
        public ModifyNetAttackSettingResponse ModifyNetAttackSettingSync(ModifyNetAttackSettingRequest req)
        {
            return InternalRequestAsync<ModifyNetAttackSettingResponse>(req, "ModifyNetAttackSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify client offline duration.
        /// </summary>
        /// <param name="req"><see cref="ModifyNotifyAgentOfflineDurationRequest"/></param>
        /// <returns><see cref="ModifyNotifyAgentOfflineDurationResponse"/></returns>
        public Task<ModifyNotifyAgentOfflineDurationResponse> ModifyNotifyAgentOfflineDuration(ModifyNotifyAgentOfflineDurationRequest req)
        {
            return InternalRequestAsync<ModifyNotifyAgentOfflineDurationResponse>(req, "ModifyNotifyAgentOfflineDuration");
        }

        /// <summary>
        /// This API is used to modify client offline duration.
        /// </summary>
        /// <param name="req"><see cref="ModifyNotifyAgentOfflineDurationRequest"/></param>
        /// <returns><see cref="ModifyNotifyAgentOfflineDurationResponse"/></returns>
        public ModifyNotifyAgentOfflineDurationResponse ModifyNotifyAgentOfflineDurationSync(ModifyNotifyAgentOfflineDurationRequest req)
        {
            return InternalRequestAsync<ModifyNotifyAgentOfflineDurationResponse>(req, "ModifyNotifyAgentOfflineDuration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify the asset scope configuration for notifications
        /// </summary>
        /// <param name="req"><see cref="ModifyNotifyAssetConfigRequest"/></param>
        /// <returns><see cref="ModifyNotifyAssetConfigResponse"/></returns>
        public Task<ModifyNotifyAssetConfigResponse> ModifyNotifyAssetConfig(ModifyNotifyAssetConfigRequest req)
        {
            return InternalRequestAsync<ModifyNotifyAssetConfigResponse>(req, "ModifyNotifyAssetConfig");
        }

        /// <summary>
        /// Modify the asset scope configuration for notifications
        /// </summary>
        /// <param name="req"><see cref="ModifyNotifyAssetConfigRequest"/></param>
        /// <returns><see cref="ModifyNotifyAssetConfigResponse"/></returns>
        public ModifyNotifyAssetConfigResponse ModifyNotifyAssetConfigSync(ModifyNotifyAssetConfigRequest req)
        {
            return InternalRequestAsync<ModifyNotifyAssetConfigResponse>(req, "ModifyNotifyAssetConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify the member account for notification.
        /// </summary>
        /// <param name="req"><see cref="ModifyNotifyMemberRequest"/></param>
        /// <returns><see cref="ModifyNotifyMemberResponse"/></returns>
        public Task<ModifyNotifyMemberResponse> ModifyNotifyMember(ModifyNotifyMemberRequest req)
        {
            return InternalRequestAsync<ModifyNotifyMemberResponse>(req, "ModifyNotifyMember");
        }

        /// <summary>
        /// Modify the member account for notification.
        /// </summary>
        /// <param name="req"><see cref="ModifyNotifyMemberRequest"/></param>
        /// <returns><see cref="ModifyNotifyMemberResponse"/></returns>
        public ModifyNotifyMemberResponse ModifyNotifyMemberSync(ModifyNotifyMemberRequest req)
        {
            return InternalRequestAsync<ModifyNotifyMemberResponse>(req, "ModifyNotifyMember")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modifies notification settings
        /// </summary>
        /// <param name="req"><see cref="ModifyNotifySettingRequest"/></param>
        /// <returns><see cref="ModifyNotifySettingResponse"/></returns>
        public Task<ModifyNotifySettingResponse> ModifyNotifySetting(ModifyNotifySettingRequest req)
        {
            return InternalRequestAsync<ModifyNotifySettingResponse>(req, "ModifyNotifySetting");
        }

        /// <summary>
        /// Modifies notification settings
        /// </summary>
        /// <param name="req"><see cref="ModifyNotifySettingRequest"/></param>
        /// <returns><see cref="ModifyNotifySettingResponse"/></returns>
        public ModifyNotifySettingResponse ModifyNotifySettingSync(ModifyNotifySettingRequest req)
        {
            return InternalRequestAsync<ModifyNotifySettingResponse>(req, "ModifyNotifySetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify notification settings
        /// </summary>
        /// <param name="req"><see cref="ModifyNotifySettingAkRequest"/></param>
        /// <returns><see cref="ModifyNotifySettingAkResponse"/></returns>
        public Task<ModifyNotifySettingAkResponse> ModifyNotifySettingAk(ModifyNotifySettingAkRequest req)
        {
            return InternalRequestAsync<ModifyNotifySettingAkResponse>(req, "ModifyNotifySettingAk");
        }

        /// <summary>
        /// Modify notification settings
        /// </summary>
        /// <param name="req"><see cref="ModifyNotifySettingAkRequest"/></param>
        /// <returns><see cref="ModifyNotifySettingAkResponse"/></returns>
        public ModifyNotifySettingAkResponse ModifyNotifySettingAkSync(ModifyNotifySettingAkRequest req)
        {
            return InternalRequestAsync<ModifyNotifySettingAkResponse>(req, "ModifyNotifySettingAk")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify alarm center notification advanced configuration
        /// </summary>
        /// <param name="req"><see cref="ModifyNotifySettingAlertRequest"/></param>
        /// <returns><see cref="ModifyNotifySettingAlertResponse"/></returns>
        public Task<ModifyNotifySettingAlertResponse> ModifyNotifySettingAlert(ModifyNotifySettingAlertRequest req)
        {
            return InternalRequestAsync<ModifyNotifySettingAlertResponse>(req, "ModifyNotifySettingAlert");
        }

        /// <summary>
        /// Modify alarm center notification advanced configuration
        /// </summary>
        /// <param name="req"><see cref="ModifyNotifySettingAlertRequest"/></param>
        /// <returns><see cref="ModifyNotifySettingAlertResponse"/></returns>
        public ModifyNotifySettingAlertResponse ModifyNotifySettingAlertSync(ModifyNotifySettingAlertRequest req)
        {
            return InternalRequestAsync<ModifyNotifySettingAlertResponse>(req, "ModifyNotifySettingAlert")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify Group Account Status
        /// </summary>
        /// <param name="req"><see cref="ModifyOrganizationAccountStatusRequest"/></param>
        /// <returns><see cref="ModifyOrganizationAccountStatusResponse"/></returns>
        public Task<ModifyOrganizationAccountStatusResponse> ModifyOrganizationAccountStatus(ModifyOrganizationAccountStatusRequest req)
        {
            return InternalRequestAsync<ModifyOrganizationAccountStatusResponse>(req, "ModifyOrganizationAccountStatus");
        }

        /// <summary>
        /// Modify Group Account Status
        /// </summary>
        /// <param name="req"><see cref="ModifyOrganizationAccountStatusRequest"/></param>
        /// <returns><see cref="ModifyOrganizationAccountStatusResponse"/></returns>
        public ModifyOrganizationAccountStatusResponse ModifyOrganizationAccountStatusSync(ModifyOrganizationAccountStatusRequest req)
        {
            return InternalRequestAsync<ModifyOrganizationAccountStatusResponse>(req, "ModifyOrganizationAccountStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify the auto-scaling configuration (multi-module and expandable; only the CWP module is available in the current period).
        /// 
        /// Auto-scaling is an external user-oriented concept equivalent to automatic purchase (auto_repurchase) at the underlying layer: when an account has new assets, the desired authorization is automatically purchased.
        /// 
        /// Supplemental description:
        /// 1. In the current period, only the HostConfig module is implemented for host security. Subsequent scalability allows named module fields for container security and AI-Agent security. Configuration fields of each module can be heterogeneous.
        /// 2. Partial update semantics: An empty module object indicates that the module is not modified, and an empty field in the module indicates that this field is not modified;
        /// 3. HostConfig.Switch linkage map: auto_repurchase_switch; auto_bind_switch is always on and not modified by this API.
        /// 4. Auto renewal (renew_flag) is not modified by this API; to query the limit/amount, call DescribeLicenseStatus.
        /// 5. The top auto scaling global switch state is aggregated by the frontend based on each module switch. The backend does not store or return the global switch.
        /// </summary>
        /// <param name="req"><see cref="ModifyPayConfigRequest"/></param>
        /// <returns><see cref="ModifyPayConfigResponse"/></returns>
        public Task<ModifyPayConfigResponse> ModifyPayConfig(ModifyPayConfigRequest req)
        {
            return InternalRequestAsync<ModifyPayConfigResponse>(req, "ModifyPayConfig");
        }

        /// <summary>
        /// Modify the auto-scaling configuration (multi-module and expandable; only the CWP module is available in the current period).
        /// 
        /// Auto-scaling is an external user-oriented concept equivalent to automatic purchase (auto_repurchase) at the underlying layer: when an account has new assets, the desired authorization is automatically purchased.
        /// 
        /// Supplemental description:
        /// 1. In the current period, only the HostConfig module is implemented for host security. Subsequent scalability allows named module fields for container security and AI-Agent security. Configuration fields of each module can be heterogeneous.
        /// 2. Partial update semantics: An empty module object indicates that the module is not modified, and an empty field in the module indicates that this field is not modified;
        /// 3. HostConfig.Switch linkage map: auto_repurchase_switch; auto_bind_switch is always on and not modified by this API.
        /// 4. Auto renewal (renew_flag) is not modified by this API; to query the limit/amount, call DescribeLicenseStatus.
        /// 5. The top auto scaling global switch state is aggregated by the frontend based on each module switch. The backend does not store or return the global switch.
        /// </summary>
        /// <param name="req"><see cref="ModifyPayConfigRequest"/></param>
        /// <returns><see cref="ModifyPayConfigResponse"/></returns>
        public ModifyPayConfigResponse ModifyPayConfigSync(ModifyPayConfigRequest req)
        {
            return InternalRequestAsync<ModifyPayConfigResponse>(req, "ModifyPayConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to configure protection settings for the major event protection package.
        /// </summary>
        /// <param name="req"><see cref="ModifyProtectionSettingRequest"/></param>
        /// <returns><see cref="ModifyProtectionSettingResponse"/></returns>
        public Task<ModifyProtectionSettingResponse> ModifyProtectionSetting(ModifyProtectionSettingRequest req)
        {
            return InternalRequestAsync<ModifyProtectionSettingResponse>(req, "ModifyProtectionSetting");
        }

        /// <summary>
        /// This API is used to configure protection settings for the major event protection package.
        /// </summary>
        /// <param name="req"><see cref="ModifyProtectionSettingRequest"/></param>
        /// <returns><see cref="ModifyProtectionSettingResponse"/></returns>
        public ModifyProtectionSettingResponse ModifyProtectionSettingSync(ModifyProtectionSettingRequest req)
        {
            return InternalRequestAsync<ModifyProtectionSettingResponse>(req, "ModifyProtectionSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Bind an important period guarantee protection authorization package.
        /// </summary>
        /// <param name="req"><see cref="ModifyRaspLicenseBindsRequest"/></param>
        /// <returns><see cref="ModifyRaspLicenseBindsResponse"/></returns>
        public Task<ModifyRaspLicenseBindsResponse> ModifyRaspLicenseBinds(ModifyRaspLicenseBindsRequest req)
        {
            return InternalRequestAsync<ModifyRaspLicenseBindsResponse>(req, "ModifyRaspLicenseBinds");
        }

        /// <summary>
        /// Bind an important period guarantee protection authorization package.
        /// </summary>
        /// <param name="req"><see cref="ModifyRaspLicenseBindsRequest"/></param>
        /// <returns><see cref="ModifyRaspLicenseBindsResponse"/></returns>
        public ModifyRaspLicenseBindsResponse ModifyRaspLicenseBindsSync(ModifyRaspLicenseBindsRequest req)
        {
            return InternalRequestAsync<ModifyRaspLicenseBindsResponse>(req, "ModifyRaspLicenseBinds")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the intranet alert and asset scope configuration for rebound Shell.
        /// </summary>
        /// <param name="req"><see cref="ModifyReverseShellSystemPolicyConfigRequest"/></param>
        /// <returns><see cref="ModifyReverseShellSystemPolicyConfigResponse"/></returns>
        public Task<ModifyReverseShellSystemPolicyConfigResponse> ModifyReverseShellSystemPolicyConfig(ModifyReverseShellSystemPolicyConfigRequest req)
        {
            return InternalRequestAsync<ModifyReverseShellSystemPolicyConfigResponse>(req, "ModifyReverseShellSystemPolicyConfig");
        }

        /// <summary>
        /// This API is used to modify the intranet alert and asset scope configuration for rebound Shell.
        /// </summary>
        /// <param name="req"><see cref="ModifyReverseShellSystemPolicyConfigRequest"/></param>
        /// <returns><see cref="ModifyReverseShellSystemPolicyConfigResponse"/></returns>
        public ModifyReverseShellSystemPolicyConfigResponse ModifyReverseShellSystemPolicyConfigSync(ModifyReverseShellSystemPolicyConfigRequest req)
        {
            return InternalRequestAsync<ModifyReverseShellSystemPolicyConfigResponse>(req, "ModifyReverseShellSystemPolicyConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify Risk Center Risk Status
        /// </summary>
        /// <param name="req"><see cref="ModifyRiskCenterRiskStatusRequest"/></param>
        /// <returns><see cref="ModifyRiskCenterRiskStatusResponse"/></returns>
        public Task<ModifyRiskCenterRiskStatusResponse> ModifyRiskCenterRiskStatus(ModifyRiskCenterRiskStatusRequest req)
        {
            return InternalRequestAsync<ModifyRiskCenterRiskStatusResponse>(req, "ModifyRiskCenterRiskStatus");
        }

        /// <summary>
        /// Modify Risk Center Risk Status
        /// </summary>
        /// <param name="req"><see cref="ModifyRiskCenterRiskStatusRequest"/></param>
        /// <returns><see cref="ModifyRiskCenterRiskStatusResponse"/></returns>
        public ModifyRiskCenterRiskStatusResponse ModifyRiskCenterRiskStatusSync(ModifyRiskCenterRiskStatusRequest req)
        {
            return InternalRequestAsync<ModifyRiskCenterRiskStatusResponse>(req, "ModifyRiskCenterRiskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify Risk Center Scan Task
        /// </summary>
        /// <param name="req"><see cref="ModifyRiskCenterScanTaskRequest"/></param>
        /// <returns><see cref="ModifyRiskCenterScanTaskResponse"/></returns>
        public Task<ModifyRiskCenterScanTaskResponse> ModifyRiskCenterScanTask(ModifyRiskCenterScanTaskRequest req)
        {
            return InternalRequestAsync<ModifyRiskCenterScanTaskResponse>(req, "ModifyRiskCenterScanTask");
        }

        /// <summary>
        /// Modify Risk Center Scan Task
        /// </summary>
        /// <param name="req"><see cref="ModifyRiskCenterScanTaskRequest"/></param>
        /// <returns><see cref="ModifyRiskCenterScanTaskResponse"/></returns>
        public ModifyRiskCenterScanTaskResponse ModifyRiskCenterScanTaskSync(ModifyRiskCenterScanTaskRequest req)
        {
            return InternalRequestAsync<ModifyRiskCenterScanTaskResponse>(req, "ModifyRiskCenterScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update the periodic scanning plan
        /// </summary>
        /// <param name="req"><see cref="ModifyRiskScanCronConfigRequest"/></param>
        /// <returns><see cref="ModifyRiskScanCronConfigResponse"/></returns>
        public Task<ModifyRiskScanCronConfigResponse> ModifyRiskScanCronConfig(ModifyRiskScanCronConfigRequest req)
        {
            return InternalRequestAsync<ModifyRiskScanCronConfigResponse>(req, "ModifyRiskScanCronConfig");
        }

        /// <summary>
        /// Update the periodic scanning plan
        /// </summary>
        /// <param name="req"><see cref="ModifyRiskScanCronConfigRequest"/></param>
        /// <returns><see cref="ModifyRiskScanCronConfigResponse"/></returns>
        public ModifyRiskScanCronConfigResponse ModifyRiskScanCronConfigSync(ModifyRiskScanCronConfigRequest req)
        {
            return InternalRequestAsync<ModifyRiskScanCronConfigResponse>(req, "ModifyRiskScanCronConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify an existing ACL user rule. Fields not passed retain their original values, and partial field update is supported.
        /// </summary>
        /// <param name="req"><see cref="ModifySandboxACLRuleRequest"/></param>
        /// <returns><see cref="ModifySandboxACLRuleResponse"/></returns>
        public Task<ModifySandboxACLRuleResponse> ModifySandboxACLRule(ModifySandboxACLRuleRequest req)
        {
            return InternalRequestAsync<ModifySandboxACLRuleResponse>(req, "ModifySandboxACLRule");
        }

        /// <summary>
        /// Modify an existing ACL user rule. Fields not passed retain their original values, and partial field update is supported.
        /// </summary>
        /// <param name="req"><see cref="ModifySandboxACLRuleRequest"/></param>
        /// <returns><see cref="ModifySandboxACLRuleResponse"/></returns>
        public ModifySandboxACLRuleResponse ModifySandboxACLRuleSync(ModifySandboxACLRuleRequest req)
        {
            return InternalRequestAsync<ModifySandboxACLRuleResponse>(req, "ModifySandboxACLRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Batch switch the enable/disable status of ACL user rules. If any rule does not exist, belongs to another tenant, or has been deleted, an error is returned for the entirety.
        /// </summary>
        /// <param name="req"><see cref="ModifySandboxACLRuleStatusRequest"/></param>
        /// <returns><see cref="ModifySandboxACLRuleStatusResponse"/></returns>
        public Task<ModifySandboxACLRuleStatusResponse> ModifySandboxACLRuleStatus(ModifySandboxACLRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifySandboxACLRuleStatusResponse>(req, "ModifySandboxACLRuleStatus");
        }

        /// <summary>
        /// Batch switch the enable/disable status of ACL user rules. If any rule does not exist, belongs to another tenant, or has been deleted, an error is returned for the entirety.
        /// </summary>
        /// <param name="req"><see cref="ModifySandboxACLRuleStatusRequest"/></param>
        /// <returns><see cref="ModifySandboxACLRuleStatusResponse"/></returns>
        public ModifySandboxACLRuleStatusResponse ModifySandboxACLRuleStatusSync(ModifySandboxACLRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifySandboxACLRuleStatusResponse>(req, "ModifySandboxACLRuleStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Batch update traffic sandbox alarms (overwrite ACL, DLP, and LLM audit). Locate the alarm source by AlertType + BelongAssetType. Status supports HANDLED / IGNORE to modify status, as well as DELETE to delete. If any alarm ID does not exist or belongs to another tenant, an error is returned overall. Note: Whitelisting (PASS) is not handled by this interface. It is triggered by Create/Modify***Rule writing back through AlertID.
        /// </summary>
        /// <param name="req"><see cref="ModifySandboxAlertStatusRequest"/></param>
        /// <returns><see cref="ModifySandboxAlertStatusResponse"/></returns>
        public Task<ModifySandboxAlertStatusResponse> ModifySandboxAlertStatus(ModifySandboxAlertStatusRequest req)
        {
            return InternalRequestAsync<ModifySandboxAlertStatusResponse>(req, "ModifySandboxAlertStatus");
        }

        /// <summary>
        /// Batch update traffic sandbox alarms (overwrite ACL, DLP, and LLM audit). Locate the alarm source by AlertType + BelongAssetType. Status supports HANDLED / IGNORE to modify status, as well as DELETE to delete. If any alarm ID does not exist or belongs to another tenant, an error is returned overall. Note: Whitelisting (PASS) is not handled by this interface. It is triggered by Create/Modify***Rule writing back through AlertID.
        /// </summary>
        /// <param name="req"><see cref="ModifySandboxAlertStatusRequest"/></param>
        /// <returns><see cref="ModifySandboxAlertStatusResponse"/></returns>
        public ModifySandboxAlertStatusResponse ModifySandboxAlertStatusSync(ModifySandboxAlertStatusRequest req)
        {
            return InternalRequestAsync<ModifySandboxAlertStatusResponse>(req, "ModifySandboxAlertStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify an existing DLP user rule. Fields not passed retain their original values, and partial field update is supported. BelongAssetType cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifySandboxDLPRuleRequest"/></param>
        /// <returns><see cref="ModifySandboxDLPRuleResponse"/></returns>
        public Task<ModifySandboxDLPRuleResponse> ModifySandboxDLPRule(ModifySandboxDLPRuleRequest req)
        {
            return InternalRequestAsync<ModifySandboxDLPRuleResponse>(req, "ModifySandboxDLPRule");
        }

        /// <summary>
        /// Modify an existing DLP user rule. Fields not passed retain their original values, and partial field update is supported. BelongAssetType cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifySandboxDLPRuleRequest"/></param>
        /// <returns><see cref="ModifySandboxDLPRuleResponse"/></returns>
        public ModifySandboxDLPRuleResponse ModifySandboxDLPRuleSync(ModifySandboxDLPRuleRequest req)
        {
            return InternalRequestAsync<ModifySandboxDLPRuleResponse>(req, "ModifySandboxDLPRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Batch switch the enable/disable status of DLP user rules. If any rule does not exist, belongs to another tenant, or has been deleted, an error is returned for the entirety.
        /// </summary>
        /// <param name="req"><see cref="ModifySandboxDLPRuleStatusRequest"/></param>
        /// <returns><see cref="ModifySandboxDLPRuleStatusResponse"/></returns>
        public Task<ModifySandboxDLPRuleStatusResponse> ModifySandboxDLPRuleStatus(ModifySandboxDLPRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifySandboxDLPRuleStatusResponse>(req, "ModifySandboxDLPRuleStatus");
        }

        /// <summary>
        /// Batch switch the enable/disable status of DLP user rules. If any rule does not exist, belongs to another tenant, or has been deleted, an error is returned for the entirety.
        /// </summary>
        /// <param name="req"><see cref="ModifySandboxDLPRuleStatusRequest"/></param>
        /// <returns><see cref="ModifySandboxDLPRuleStatusResponse"/></returns>
        public ModifySandboxDLPRuleStatusResponse ModifySandboxDLPRuleStatusSync(ModifySandboxDLPRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifySandboxDLPRuleStatusResponse>(req, "ModifySandboxDLPRuleStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify command sandbox file access rule
        /// </summary>
        /// <param name="req"><see cref="ModifySandboxFileRuleRequest"/></param>
        /// <returns><see cref="ModifySandboxFileRuleResponse"/></returns>
        public Task<ModifySandboxFileRuleResponse> ModifySandboxFileRule(ModifySandboxFileRuleRequest req)
        {
            return InternalRequestAsync<ModifySandboxFileRuleResponse>(req, "ModifySandboxFileRule");
        }

        /// <summary>
        /// Modify command sandbox file access rule
        /// </summary>
        /// <param name="req"><see cref="ModifySandboxFileRuleRequest"/></param>
        /// <returns><see cref="ModifySandboxFileRuleResponse"/></returns>
        public ModifySandboxFileRuleResponse ModifySandboxFileRuleSync(ModifySandboxFileRuleRequest req)
        {
            return InternalRequestAsync<ModifySandboxFileRuleResponse>(req, "ModifySandboxFileRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Batch enable or disable command sandbox file access rules.
        /// </summary>
        /// <param name="req"><see cref="ModifySandboxFileRuleStatusRequest"/></param>
        /// <returns><see cref="ModifySandboxFileRuleStatusResponse"/></returns>
        public Task<ModifySandboxFileRuleStatusResponse> ModifySandboxFileRuleStatus(ModifySandboxFileRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifySandboxFileRuleStatusResponse>(req, "ModifySandboxFileRuleStatus");
        }

        /// <summary>
        /// Batch enable or disable command sandbox file access rules.
        /// </summary>
        /// <param name="req"><see cref="ModifySandboxFileRuleStatusRequest"/></param>
        /// <returns><see cref="ModifySandboxFileRuleStatusResponse"/></returns>
        public ModifySandboxFileRuleStatusResponse ModifySandboxFileRuleStatusSync(ModifySandboxFileRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifySandboxFileRuleStatusResponse>(req, "ModifySandboxFileRuleStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify an existing LLM audit user rule. Fields not passed retain their original values, and partial field update is supported.
        /// </summary>
        /// <param name="req"><see cref="ModifySandboxLLMAuditRuleRequest"/></param>
        /// <returns><see cref="ModifySandboxLLMAuditRuleResponse"/></returns>
        public Task<ModifySandboxLLMAuditRuleResponse> ModifySandboxLLMAuditRule(ModifySandboxLLMAuditRuleRequest req)
        {
            return InternalRequestAsync<ModifySandboxLLMAuditRuleResponse>(req, "ModifySandboxLLMAuditRule");
        }

        /// <summary>
        /// Modify an existing LLM audit user rule. Fields not passed retain their original values, and partial field update is supported.
        /// </summary>
        /// <param name="req"><see cref="ModifySandboxLLMAuditRuleRequest"/></param>
        /// <returns><see cref="ModifySandboxLLMAuditRuleResponse"/></returns>
        public ModifySandboxLLMAuditRuleResponse ModifySandboxLLMAuditRuleSync(ModifySandboxLLMAuditRuleRequest req)
        {
            return InternalRequestAsync<ModifySandboxLLMAuditRuleResponse>(req, "ModifySandboxLLMAuditRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Batch switch the enable or disable status of LLM audit user rules. If any rule does not exist, belongs to another tenant, or has been deleted, an error is returned overall.
        /// </summary>
        /// <param name="req"><see cref="ModifySandboxLLMAuditRuleStatusRequest"/></param>
        /// <returns><see cref="ModifySandboxLLMAuditRuleStatusResponse"/></returns>
        public Task<ModifySandboxLLMAuditRuleStatusResponse> ModifySandboxLLMAuditRuleStatus(ModifySandboxLLMAuditRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifySandboxLLMAuditRuleStatusResponse>(req, "ModifySandboxLLMAuditRuleStatus");
        }

        /// <summary>
        /// Batch switch the enable or disable status of LLM audit user rules. If any rule does not exist, belongs to another tenant, or has been deleted, an error is returned overall.
        /// </summary>
        /// <param name="req"><see cref="ModifySandboxLLMAuditRuleStatusRequest"/></param>
        /// <returns><see cref="ModifySandboxLLMAuditRuleStatusResponse"/></returns>
        public ModifySandboxLLMAuditRuleStatusResponse ModifySandboxLLMAuditRuleStatusSync(ModifySandboxLLMAuditRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifySandboxLLMAuditRuleStatusResponse>(req, "ModifySandboxLLMAuditRuleStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify a security scoring rule. You need to pass in a complete rule set.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityScoreRuleRequest"/></param>
        /// <returns><see cref="ModifySecurityScoreRuleResponse"/></returns>
        public Task<ModifySecurityScoreRuleResponse> ModifySecurityScoreRule(ModifySecurityScoreRuleRequest req)
        {
            return InternalRequestAsync<ModifySecurityScoreRuleResponse>(req, "ModifySecurityScoreRule");
        }

        /// <summary>
        /// Modify a security scoring rule. You need to pass in a complete rule set.
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityScoreRuleRequest"/></param>
        /// <returns><see cref="ModifySecurityScoreRuleResponse"/></returns>
        public ModifySecurityScoreRuleResponse ModifySecurityScoreRuleSync(ModifySecurityScoreRuleRequest req)
        {
            return InternalRequestAsync<ModifySecurityScoreRuleResponse>(req, "ModifySecurityScoreRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Edit the ak monitoring account.
        /// </summary>
        /// <param name="req"><see cref="ModifyShareUserAKRequest"/></param>
        /// <returns><see cref="ModifyShareUserAKResponse"/></returns>
        public Task<ModifyShareUserAKResponse> ModifyShareUserAK(ModifyShareUserAKRequest req)
        {
            return InternalRequestAsync<ModifyShareUserAKResponse>(req, "ModifyShareUserAK");
        }

        /// <summary>
        /// Edit the ak monitoring account.
        /// </summary>
        /// <param name="req"><see cref="ModifyShareUserAKRequest"/></param>
        /// <returns><see cref="ModifyShareUserAKResponse"/></returns>
        public ModifyShareUserAKResponse ModifyShareUserAKSync(ModifyShareUserAKRequest req)
        {
            return InternalRequestAsync<ModifyShareUserAKResponse>(req, "ModifyShareUserAK")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Edit a CSPM shared account
        /// </summary>
        /// <param name="req"><see cref="ModifyShareUserCSPMRequest"/></param>
        /// <returns><see cref="ModifyShareUserCSPMResponse"/></returns>
        public Task<ModifyShareUserCSPMResponse> ModifyShareUserCSPM(ModifyShareUserCSPMRequest req)
        {
            return InternalRequestAsync<ModifyShareUserCSPMResponse>(req, "ModifyShareUserCSPM");
        }

        /// <summary>
        /// Edit a CSPM shared account
        /// </summary>
        /// <param name="req"><see cref="ModifyShareUserCSPMRequest"/></param>
        /// <returns><see cref="ModifyShareUserCSPMResponse"/></returns>
        public ModifyShareUserCSPMResponse ModifyShareUserCSPMSync(ModifyShareUserCSPMRequest req)
        {
            return InternalRequestAsync<ModifyShareUserCSPMResponse>(req, "ModifyShareUserCSPM")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Edit dspm monitored account
        /// </summary>
        /// <param name="req"><see cref="ModifyShareUserDspmRequest"/></param>
        /// <returns><see cref="ModifyShareUserDspmResponse"/></returns>
        public Task<ModifyShareUserDspmResponse> ModifyShareUserDspm(ModifyShareUserDspmRequest req)
        {
            return InternalRequestAsync<ModifyShareUserDspmResponse>(req, "ModifyShareUserDspm");
        }

        /// <summary>
        /// Edit dspm monitored account
        /// </summary>
        /// <param name="req"><see cref="ModifyShareUserDspmRequest"/></param>
        /// <returns><see cref="ModifyShareUserDspmResponse"/></returns>
        public ModifyShareUserDspmResponse ModifyShareUserDspmSync(ModifyShareUserDspmRequest req)
        {
            return InternalRequestAsync<ModifyShareUserDspmResponse>(req, "ModifyShareUserDspm")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Batch modify the processing status of Skill security detection alarms.
        /// </summary>
        /// <param name="req"><see cref="ModifySkillScanAlertStatusRequest"/></param>
        /// <returns><see cref="ModifySkillScanAlertStatusResponse"/></returns>
        public Task<ModifySkillScanAlertStatusResponse> ModifySkillScanAlertStatus(ModifySkillScanAlertStatusRequest req)
        {
            return InternalRequestAsync<ModifySkillScanAlertStatusResponse>(req, "ModifySkillScanAlertStatus");
        }

        /// <summary>
        /// Batch modify the processing status of Skill security detection alarms.
        /// </summary>
        /// <param name="req"><see cref="ModifySkillScanAlertStatusRequest"/></param>
        /// <returns><see cref="ModifySkillScanAlertStatusResponse"/></returns>
        public ModifySkillScanAlertStatusResponse ModifySkillScanAlertStatusSync(ModifySkillScanAlertStatusRequest req)
        {
            return InternalRequestAsync<ModifySkillScanAlertStatusResponse>(req, "ModifySkillScanAlertStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update the switch of a custom policy
        /// </summary>
        /// <param name="req"><see cref="ModifyUebaRuleSwitchRequest"/></param>
        /// <returns><see cref="ModifyUebaRuleSwitchResponse"/></returns>
        public Task<ModifyUebaRuleSwitchResponse> ModifyUebaRuleSwitch(ModifyUebaRuleSwitchRequest req)
        {
            return InternalRequestAsync<ModifyUebaRuleSwitchResponse>(req, "ModifyUebaRuleSwitch");
        }

        /// <summary>
        /// Update the switch of a custom policy
        /// </summary>
        /// <param name="req"><see cref="ModifyUebaRuleSwitchRequest"/></param>
        /// <returns><see cref="ModifyUebaRuleSwitchResponse"/></returns>
        public ModifyUebaRuleSwitchResponse ModifyUebaRuleSwitchSync(ModifyUebaRuleSwitchRequest req)
        {
            return InternalRequestAsync<ModifyUebaRuleSwitchResponse>(req, "ModifyUebaRuleSwitch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify vulnerability scanning (period scanning).
        /// </summary>
        /// <param name="req"><see cref="ModifyVulScanPeriodicRequest"/></param>
        /// <returns><see cref="ModifyVulScanPeriodicResponse"/></returns>
        public Task<ModifyVulScanPeriodicResponse> ModifyVulScanPeriodic(ModifyVulScanPeriodicRequest req)
        {
            return InternalRequestAsync<ModifyVulScanPeriodicResponse>(req, "ModifyVulScanPeriodic");
        }

        /// <summary>
        /// This API is used to modify vulnerability scanning (period scanning).
        /// </summary>
        /// <param name="req"><see cref="ModifyVulScanPeriodicRequest"/></param>
        /// <returns><see cref="ModifyVulScanPeriodicResponse"/></returns>
        public ModifyVulScanPeriodicResponse ModifyVulScanPeriodicSync(ModifyVulScanPeriodicRequest req)
        {
            return InternalRequestAsync<ModifyVulScanPeriodicResponse>(req, "ModifyVulScanPeriodic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the vulnerability allowlist configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyVulWhitelistConfigRequest"/></param>
        /// <returns><see cref="ModifyVulWhitelistConfigResponse"/></returns>
        public Task<ModifyVulWhitelistConfigResponse> ModifyVulWhitelistConfig(ModifyVulWhitelistConfigRequest req)
        {
            return InternalRequestAsync<ModifyVulWhitelistConfigResponse>(req, "ModifyVulWhitelistConfig");
        }

        /// <summary>
        /// This API is used to modify the vulnerability allowlist configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyVulWhitelistConfigRequest"/></param>
        /// <returns><see cref="ModifyVulWhitelistConfigResponse"/></returns>
        public ModifyVulWhitelistConfigResponse ModifyVulWhitelistConfigSync(ModifyVulWhitelistConfigRequest req)
        {
            return InternalRequestAsync<ModifyVulWhitelistConfigResponse>(req, "ModifyVulWhitelistConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the vulnerability allowlist switch.
        /// </summary>
        /// <param name="req"><see cref="ModifyVulWhitelistSwitchRequest"/></param>
        /// <returns><see cref="ModifyVulWhitelistSwitchResponse"/></returns>
        public Task<ModifyVulWhitelistSwitchResponse> ModifyVulWhitelistSwitch(ModifyVulWhitelistSwitchRequest req)
        {
            return InternalRequestAsync<ModifyVulWhitelistSwitchResponse>(req, "ModifyVulWhitelistSwitch");
        }

        /// <summary>
        /// This API is used to modify the vulnerability allowlist switch.
        /// </summary>
        /// <param name="req"><see cref="ModifyVulWhitelistSwitchRequest"/></param>
        /// <returns><see cref="ModifyVulWhitelistSwitchResponse"/></returns>
        public ModifyVulWhitelistSwitchResponse ModifyVulWhitelistSwitchSync(ModifyVulWhitelistSwitchRequest req)
        {
            return InternalRequestAsync<ModifyVulWhitelistSwitchResponse>(req, "ModifyVulWhitelistSwitch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Add or modify a notification policy. ID > 0 means modification; ID = 0 or not passed means adding new. When MemberAppIds is configured as empty, the policy only acts on current root account events; when not empty, it acts on the self account + listed member accounts at the same time.
        /// </summary>
        /// <param name="req"><see cref="ModifyWebhookPolicyRequest"/></param>
        /// <returns><see cref="ModifyWebhookPolicyResponse"/></returns>
        public Task<ModifyWebhookPolicyResponse> ModifyWebhookPolicy(ModifyWebhookPolicyRequest req)
        {
            return InternalRequestAsync<ModifyWebhookPolicyResponse>(req, "ModifyWebhookPolicy");
        }

        /// <summary>
        /// Add or modify a notification policy. ID > 0 means modification; ID = 0 or not passed means adding new. When MemberAppIds is configured as empty, the policy only acts on current root account events; when not empty, it acts on the self account + listed member accounts at the same time.
        /// </summary>
        /// <param name="req"><see cref="ModifyWebhookPolicyRequest"/></param>
        /// <returns><see cref="ModifyWebhookPolicyResponse"/></returns>
        public ModifyWebhookPolicyResponse ModifyWebhookPolicySync(ModifyWebhookPolicyRequest req)
        {
            return InternalRequestAsync<ModifyWebhookPolicyResponse>(req, "ModifyWebhookPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Switch the enable status of the notification policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyWebhookPolicyStatusRequest"/></param>
        /// <returns><see cref="ModifyWebhookPolicyStatusResponse"/></returns>
        public Task<ModifyWebhookPolicyStatusResponse> ModifyWebhookPolicyStatus(ModifyWebhookPolicyStatusRequest req)
        {
            return InternalRequestAsync<ModifyWebhookPolicyStatusResponse>(req, "ModifyWebhookPolicyStatus");
        }

        /// <summary>
        /// Switch the enable status of the notification policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyWebhookPolicyStatusRequest"/></param>
        /// <returns><see cref="ModifyWebhookPolicyStatusResponse"/></returns>
        public ModifyWebhookPolicyStatusResponse ModifyWebhookPolicyStatusSync(ModifyWebhookPolicyStatusRequest req)
        {
            return InternalRequestAsync<ModifyWebhookPolicyStatusResponse>(req, "ModifyWebhookPolicyStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Add or modify a receiving robot. ID > 0 means modifying an existing record; ID = 0 or not passed means adding new. The robot type is determined by the Type field. When Type=WEBHOOK, WebhookAddr is required. When Type=SCF, SCFRegion/Namespace/FunctionName/FunctionVersion/Alias/MaxWaitSeconds are all required. Type is not allowed to be changed during modification.
        /// </summary>
        /// <param name="req"><see cref="ModifyWebhookReceiverRequest"/></param>
        /// <returns><see cref="ModifyWebhookReceiverResponse"/></returns>
        public Task<ModifyWebhookReceiverResponse> ModifyWebhookReceiver(ModifyWebhookReceiverRequest req)
        {
            return InternalRequestAsync<ModifyWebhookReceiverResponse>(req, "ModifyWebhookReceiver");
        }

        /// <summary>
        /// Add or modify a receiving robot. ID > 0 means modifying an existing record; ID = 0 or not passed means adding new. The robot type is determined by the Type field. When Type=WEBHOOK, WebhookAddr is required. When Type=SCF, SCFRegion/Namespace/FunctionName/FunctionVersion/Alias/MaxWaitSeconds are all required. Type is not allowed to be changed during modification.
        /// </summary>
        /// <param name="req"><see cref="ModifyWebhookReceiverRequest"/></param>
        /// <returns><see cref="ModifyWebhookReceiverResponse"/></returns>
        public ModifyWebhookReceiverResponse ModifyWebhookReceiverSync(ModifyWebhookReceiverRequest req)
        {
            return InternalRequestAsync<ModifyWebhookReceiverResponse>(req, "ModifyWebhookReceiver")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Risk operation example
        /// </summary>
        /// <param name="req"><see cref="OperateRiskRequest"/></param>
        /// <returns><see cref="OperateRiskResponse"/></returns>
        public Task<OperateRiskResponse> OperateRisk(OperateRiskRequest req)
        {
            return InternalRequestAsync<OperateRiskResponse>(req, "OperateRisk");
        }

        /// <summary>
        /// Risk operation example
        /// </summary>
        /// <param name="req"><see cref="OperateRiskRequest"/></param>
        /// <returns><see cref="OperateRiskResponse"/></returns>
        public OperateRiskResponse OperateRiskSync(OperateRiskRequest req)
        {
            return InternalRequestAsync<OperateRiskResponse>(req, "OperateRisk")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Custom risk rule
        /// </summary>
        /// <param name="req"><see cref="OperateRiskRulePolicyRequest"/></param>
        /// <returns><see cref="OperateRiskRulePolicyResponse"/></returns>
        public Task<OperateRiskRulePolicyResponse> OperateRiskRulePolicy(OperateRiskRulePolicyRequest req)
        {
            return InternalRequestAsync<OperateRiskRulePolicyResponse>(req, "OperateRiskRulePolicy");
        }

        /// <summary>
        /// Custom risk rule
        /// </summary>
        /// <param name="req"><see cref="OperateRiskRulePolicyRequest"/></param>
        /// <returns><see cref="OperateRiskRulePolicyResponse"/></returns>
        public OperateRiskRulePolicyResponse OperateRiskRulePolicySync(OperateRiskRulePolicyRequest req)
        {
            return InternalRequestAsync<OperateRiskRulePolicyResponse>(req, "OperateRiskRulePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Reset the Dspm asset account password.
        /// </summary>
        /// <param name="req"><see cref="ResetDspmAssetAccountPasswordRequest"/></param>
        /// <returns><see cref="ResetDspmAssetAccountPasswordResponse"/></returns>
        public Task<ResetDspmAssetAccountPasswordResponse> ResetDspmAssetAccountPassword(ResetDspmAssetAccountPasswordRequest req)
        {
            return InternalRequestAsync<ResetDspmAssetAccountPasswordResponse>(req, "ResetDspmAssetAccountPassword");
        }

        /// <summary>
        /// Reset the Dspm asset account password.
        /// </summary>
        /// <param name="req"><see cref="ResetDspmAssetAccountPasswordRequest"/></param>
        /// <returns><see cref="ResetDspmAssetAccountPasswordResponse"/></returns>
        public ResetDspmAssetAccountPasswordResponse ResetDspmAssetAccountPasswordSync(ResetDspmAssetAccountPasswordRequest req)
        {
            return InternalRequestAsync<ResetDspmAssetAccountPasswordResponse>(req, "ResetDspmAssetAccountPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// RetryExportLog
        /// </summary>
        /// <param name="req"><see cref="RetryDspmExportLogRequest"/></param>
        /// <returns><see cref="RetryDspmExportLogResponse"/></returns>
        public Task<RetryDspmExportLogResponse> RetryDspmExportLog(RetryDspmExportLogRequest req)
        {
            return InternalRequestAsync<RetryDspmExportLogResponse>(req, "RetryDspmExportLog");
        }

        /// <summary>
        /// RetryExportLog
        /// </summary>
        /// <param name="req"><see cref="RetryDspmExportLogRequest"/></param>
        /// <returns><see cref="RetryDspmExportLogResponse"/></returns>
        public RetryDspmExportLogResponse RetryDspmExportLogSync(RetryDspmExportLogRequest req)
        {
            return InternalRequestAsync<RetryDspmExportLogResponse>(req, "RetryDspmExportLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Restore a Dspm asset account.
        /// </summary>
        /// <param name="req"><see cref="RevertDspmAssetAccountRequest"/></param>
        /// <returns><see cref="RevertDspmAssetAccountResponse"/></returns>
        public Task<RevertDspmAssetAccountResponse> RevertDspmAssetAccount(RevertDspmAssetAccountRequest req)
        {
            return InternalRequestAsync<RevertDspmAssetAccountResponse>(req, "RevertDspmAssetAccount");
        }

        /// <summary>
        /// Restore a Dspm asset account.
        /// </summary>
        /// <param name="req"><see cref="RevertDspmAssetAccountRequest"/></param>
        /// <returns><see cref="RevertDspmAssetAccountResponse"/></returns>
        public RevertDspmAssetAccountResponse RevertDspmAssetAccountSync(RevertDspmAssetAccountRequest req)
        {
            return InternalRequestAsync<RevertDspmAssetAccountResponse>(req, "RevertDspmAssetAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to trigger a rescan of some detection items for a single asset.
        /// </summary>
        /// <param name="req"><see cref="ScanBaselineAssetItemListRequest"/></param>
        /// <returns><see cref="ScanBaselineAssetItemListResponse"/></returns>
        public Task<ScanBaselineAssetItemListResponse> ScanBaselineAssetItemList(ScanBaselineAssetItemListRequest req)
        {
            return InternalRequestAsync<ScanBaselineAssetItemListResponse>(req, "ScanBaselineAssetItemList");
        }

        /// <summary>
        /// This API is used to trigger a rescan of some detection items for a single asset.
        /// </summary>
        /// <param name="req"><see cref="ScanBaselineAssetItemListRequest"/></param>
        /// <returns><see cref="ScanBaselineAssetItemListResponse"/></returns>
        public ScanBaselineAssetItemListResponse ScanBaselineAssetItemListSync(ScanBaselineAssetItemListRequest req)
        {
            return InternalRequestAsync<ScanBaselineAssetItemListResponse>(req, "ScanBaselineAssetItemList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to rescan detection items under a specified policy.
        /// </summary>
        /// <param name="req"><see cref="ScanBaselineItemListRequest"/></param>
        /// <returns><see cref="ScanBaselineItemListResponse"/></returns>
        public Task<ScanBaselineItemListResponse> ScanBaselineItemList(ScanBaselineItemListRequest req)
        {
            return InternalRequestAsync<ScanBaselineItemListResponse>(req, "ScanBaselineItemList");
        }

        /// <summary>
        /// This API is used to rescan detection items under a specified policy.
        /// </summary>
        /// <param name="req"><see cref="ScanBaselineItemListRequest"/></param>
        /// <returns><see cref="ScanBaselineItemListResponse"/></returns>
        public ScanBaselineItemListResponse ScanBaselineItemListSync(ScanBaselineItemListRequest req)
        {
            return InternalRequestAsync<ScanBaselineItemListResponse>(req, "ScanBaselineItemList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Trigger a holistic rescan for a batch of baseline policies via the one-click scan entry on the strategy list page. All assets within the policy hit scope will be rescanned.
        /// </summary>
        /// <param name="req"><see cref="ScanBaselinePolicyListRequest"/></param>
        /// <returns><see cref="ScanBaselinePolicyListResponse"/></returns>
        public Task<ScanBaselinePolicyListResponse> ScanBaselinePolicyList(ScanBaselinePolicyListRequest req)
        {
            return InternalRequestAsync<ScanBaselinePolicyListResponse>(req, "ScanBaselinePolicyList");
        }

        /// <summary>
        /// Trigger a holistic rescan for a batch of baseline policies via the one-click scan entry on the strategy list page. All assets within the policy hit scope will be rescanned.
        /// </summary>
        /// <param name="req"><see cref="ScanBaselinePolicyListRequest"/></param>
        /// <returns><see cref="ScanBaselinePolicyListResponse"/></returns>
        public ScanBaselinePolicyListResponse ScanBaselinePolicyListSync(ScanBaselinePolicyListRequest req)
        {
            return InternalRequestAsync<ScanBaselinePolicyListResponse>(req, "ScanBaselinePolicyList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Triggers a rescan for a batch of risk records. It is commonly used for rescanning after selecting multiple risks on the Risk List page.
        /// </summary>
        /// <param name="req"><see cref="ScanBaselineRiskListRequest"/></param>
        /// <returns><see cref="ScanBaselineRiskListResponse"/></returns>
        public Task<ScanBaselineRiskListResponse> ScanBaselineRiskList(ScanBaselineRiskListRequest req)
        {
            return InternalRequestAsync<ScanBaselineRiskListResponse>(req, "ScanBaselineRiskList");
        }

        /// <summary>
        /// Triggers a rescan for a batch of risk records. It is commonly used for rescanning after selecting multiple risks on the Risk List page.
        /// </summary>
        /// <param name="req"><see cref="ScanBaselineRiskListRequest"/></param>
        /// <returns><see cref="ScanBaselineRiskListResponse"/></returns>
        public ScanBaselineRiskListResponse ScanBaselineRiskListSync(ScanBaselineRiskListRequest req)
        {
            return InternalRequestAsync<ScanBaselineRiskListResponse>(req, "ScanBaselineRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete CSIP manual scan tasks.
        /// </summary>
        /// <param name="req"><see cref="ScanCSIPTaskAgainRequest"/></param>
        /// <returns><see cref="ScanCSIPTaskAgainResponse"/></returns>
        public Task<ScanCSIPTaskAgainResponse> ScanCSIPTaskAgain(ScanCSIPTaskAgainRequest req)
        {
            return InternalRequestAsync<ScanCSIPTaskAgainResponse>(req, "ScanCSIPTaskAgain");
        }

        /// <summary>
        /// This API is used to delete CSIP manual scan tasks.
        /// </summary>
        /// <param name="req"><see cref="ScanCSIPTaskAgainRequest"/></param>
        /// <returns><see cref="ScanCSIPTaskAgainResponse"/></returns>
        public ScanCSIPTaskAgainResponse ScanCSIPTaskAgainSync(ScanCSIPTaskAgainRequest req)
        {
            return InternalRequestAsync<ScanCSIPTaskAgainResponse>(req, "ScanCSIPTaskAgain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a scan task based on the original task configuration. If AssetId is empty, get all asset info from TaskId. If AssetId is not empty, only the single asset is included.
        /// </summary>
        /// <param name="req"><see cref="ScanEDRTaskAgainRequest"/></param>
        /// <returns><see cref="ScanEDRTaskAgainResponse"/></returns>
        public Task<ScanEDRTaskAgainResponse> ScanEDRTaskAgain(ScanEDRTaskAgainRequest req)
        {
            return InternalRequestAsync<ScanEDRTaskAgainResponse>(req, "ScanEDRTaskAgain");
        }

        /// <summary>
        /// Create a scan task based on the original task configuration. If AssetId is empty, get all asset info from TaskId. If AssetId is not empty, only the single asset is included.
        /// </summary>
        /// <param name="req"><see cref="ScanEDRTaskAgainRequest"/></param>
        /// <returns><see cref="ScanEDRTaskAgainResponse"/></returns>
        public ScanEDRTaskAgainResponse ScanEDRTaskAgainSync(ScanEDRTaskAgainRequest req)
        {
            return InternalRequestAsync<ScanEDRTaskAgainResponse>(req, "ScanEDRTaskAgain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Sends the access verification code for a Dspm asset
        /// </summary>
        /// <param name="req"><see cref="SendDspmAssetLoginSmsCodeRequest"/></param>
        /// <returns><see cref="SendDspmAssetLoginSmsCodeResponse"/></returns>
        public Task<SendDspmAssetLoginSmsCodeResponse> SendDspmAssetLoginSmsCode(SendDspmAssetLoginSmsCodeRequest req)
        {
            return InternalRequestAsync<SendDspmAssetLoginSmsCodeResponse>(req, "SendDspmAssetLoginSmsCode");
        }

        /// <summary>
        /// Sends the access verification code for a Dspm asset
        /// </summary>
        /// <param name="req"><see cref="SendDspmAssetLoginSmsCodeRequest"/></param>
        /// <returns><see cref="SendDspmAssetLoginSmsCodeResponse"/></returns>
        public SendDspmAssetLoginSmsCodeResponse SendDspmAssetLoginSmsCodeSync(SendDspmAssetLoginSmsCodeRequest req)
        {
            return InternalRequestAsync<SendDspmAssetLoginSmsCodeResponse>(req, "SendDspmAssetLoginSmsCode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to test the tenant CKafka connectivity.
        /// </summary>
        /// <param name="req"><see cref="SendDspmCkafkaTestRequest"/></param>
        /// <returns><see cref="SendDspmCkafkaTestResponse"/></returns>
        public Task<SendDspmCkafkaTestResponse> SendDspmCkafkaTest(SendDspmCkafkaTestRequest req)
        {
            return InternalRequestAsync<SendDspmCkafkaTestResponse>(req, "SendDspmCkafkaTest");
        }

        /// <summary>
        /// This API is used to test the tenant CKafka connectivity.
        /// </summary>
        /// <param name="req"><see cref="SendDspmCkafkaTestRequest"/></param>
        /// <returns><see cref="SendDspmCkafkaTestResponse"/></returns>
        public SendDspmCkafkaTestResponse SendDspmCkafkaTestSync(SendDspmCkafkaTestRequest req)
        {
            return InternalRequestAsync<SendDspmCkafkaTestResponse>(req, "SendDspmCkafkaTest")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Enable or modify the anti-uninstall feature configuration.
        /// </summary>
        /// <param name="req"><see cref="StartOrModifyPreventUninstallRequest"/></param>
        /// <returns><see cref="StartOrModifyPreventUninstallResponse"/></returns>
        public Task<StartOrModifyPreventUninstallResponse> StartOrModifyPreventUninstall(StartOrModifyPreventUninstallRequest req)
        {
            return InternalRequestAsync<StartOrModifyPreventUninstallResponse>(req, "StartOrModifyPreventUninstall");
        }

        /// <summary>
        /// Enable or modify the anti-uninstall feature configuration.
        /// </summary>
        /// <param name="req"><see cref="StartOrModifyPreventUninstallRequest"/></param>
        /// <returns><see cref="StartOrModifyPreventUninstallResponse"/></returns>
        public StartOrModifyPreventUninstallResponse StartOrModifyPreventUninstallSync(StartOrModifyPreventUninstallRequest req)
        {
            return InternalRequestAsync<StartOrModifyPreventUninstallResponse>(req, "StartOrModifyPreventUninstall")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable or modify process guard feature configurations.
        /// </summary>
        /// <param name="req"><see cref="StartOrModifyProcessDaemonRequest"/></param>
        /// <returns><see cref="StartOrModifyProcessDaemonResponse"/></returns>
        public Task<StartOrModifyProcessDaemonResponse> StartOrModifyProcessDaemon(StartOrModifyProcessDaemonRequest req)
        {
            return InternalRequestAsync<StartOrModifyProcessDaemonResponse>(req, "StartOrModifyProcessDaemon");
        }

        /// <summary>
        /// This API is used to enable or modify process guard feature configurations.
        /// </summary>
        /// <param name="req"><see cref="StartOrModifyProcessDaemonRequest"/></param>
        /// <returns><see cref="StartOrModifyProcessDaemonResponse"/></returns>
        public StartOrModifyProcessDaemonResponse StartOrModifyProcessDaemonSync(StartOrModifyProcessDaemonRequest req)
        {
            return InternalRequestAsync<StartOrModifyProcessDaemonResponse>(req, "StartOrModifyProcessDaemon")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to stop a specified baseline scan main task. It only takes effect for tasks in the INIT, SUBTASK_CREATING, or SCANNING status.
        /// </summary>
        /// <param name="req"><see cref="StopBaselineScanTaskRequest"/></param>
        /// <returns><see cref="StopBaselineScanTaskResponse"/></returns>
        public Task<StopBaselineScanTaskResponse> StopBaselineScanTask(StopBaselineScanTaskRequest req)
        {
            return InternalRequestAsync<StopBaselineScanTaskResponse>(req, "StopBaselineScanTask");
        }

        /// <summary>
        /// This API is used to stop a specified baseline scan main task. It only takes effect for tasks in the INIT, SUBTASK_CREATING, or SCANNING status.
        /// </summary>
        /// <param name="req"><see cref="StopBaselineScanTaskRequest"/></param>
        /// <returns><see cref="StopBaselineScanTaskResponse"/></returns>
        public StopBaselineScanTaskResponse StopBaselineScanTaskSync(StopBaselineScanTaskRequest req)
        {
            return InternalRequestAsync<StopBaselineScanTaskResponse>(req, "StopBaselineScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// CSIP manual scan stop API
        /// </summary>
        /// <param name="req"><see cref="StopCSIPManualMalwareScanRequest"/></param>
        /// <returns><see cref="StopCSIPManualMalwareScanResponse"/></returns>
        public Task<StopCSIPManualMalwareScanResponse> StopCSIPManualMalwareScan(StopCSIPManualMalwareScanRequest req)
        {
            return InternalRequestAsync<StopCSIPManualMalwareScanResponse>(req, "StopCSIPManualMalwareScan");
        }

        /// <summary>
        /// CSIP manual scan stop API
        /// </summary>
        /// <param name="req"><see cref="StopCSIPManualMalwareScanRequest"/></param>
        /// <returns><see cref="StopCSIPManualMalwareScanResponse"/></returns>
        public StopCSIPManualMalwareScanResponse StopCSIPManualMalwareScanSync(StopCSIPManualMalwareScanRequest req)
        {
            return InternalRequestAsync<StopCSIPManualMalwareScanResponse>(req, "StopCSIPManualMalwareScan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Stop or cancel a scan task. For tasks in SCANNING status, call RPC to stop them. For tasks in WAIT status, update the database directly to cancel them. Only the task creator can perform these operations.
        /// </summary>
        /// <param name="req"><see cref="StopEDRScanTaskRequest"/></param>
        /// <returns><see cref="StopEDRScanTaskResponse"/></returns>
        public Task<StopEDRScanTaskResponse> StopEDRScanTask(StopEDRScanTaskRequest req)
        {
            return InternalRequestAsync<StopEDRScanTaskResponse>(req, "StopEDRScanTask");
        }

        /// <summary>
        /// Stop or cancel a scan task. For tasks in SCANNING status, call RPC to stop them. For tasks in WAIT status, update the database directly to cancel them. Only the task creator can perform these operations.
        /// </summary>
        /// <param name="req"><see cref="StopEDRScanTaskRequest"/></param>
        /// <returns><see cref="StopEDRScanTaskResponse"/></returns>
        public StopEDRScanTaskResponse StopEDRScanTaskSync(StopEDRScanTaskRequest req)
        {
            return InternalRequestAsync<StopEDRScanTaskResponse>(req, "StopEDRScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Terminate an image scanning task in a mirror repository
        /// </summary>
        /// <param name="req"><see cref="StopImageRegistryScanTaskRequest"/></param>
        /// <returns><see cref="StopImageRegistryScanTaskResponse"/></returns>
        public Task<StopImageRegistryScanTaskResponse> StopImageRegistryScanTask(StopImageRegistryScanTaskRequest req)
        {
            return InternalRequestAsync<StopImageRegistryScanTaskResponse>(req, "StopImageRegistryScanTask");
        }

        /// <summary>
        /// Terminate an image scanning task in a mirror repository
        /// </summary>
        /// <param name="req"><see cref="StopImageRegistryScanTaskRequest"/></param>
        /// <returns><see cref="StopImageRegistryScanTaskResponse"/></returns>
        public StopImageRegistryScanTaskResponse StopImageRegistryScanTaskSync(StopImageRegistryScanTaskRequest req)
        {
            return InternalRequestAsync<StopImageRegistryScanTaskResponse>(req, "StopImageRegistryScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable the anti-uninstallation feature.
        /// </summary>
        /// <param name="req"><see cref="StopPreventUninstallRequest"/></param>
        /// <returns><see cref="StopPreventUninstallResponse"/></returns>
        public Task<StopPreventUninstallResponse> StopPreventUninstall(StopPreventUninstallRequest req)
        {
            return InternalRequestAsync<StopPreventUninstallResponse>(req, "StopPreventUninstall");
        }

        /// <summary>
        /// This API is used to disable the anti-uninstallation feature.
        /// </summary>
        /// <param name="req"><see cref="StopPreventUninstallRequest"/></param>
        /// <returns><see cref="StopPreventUninstallResponse"/></returns>
        public StopPreventUninstallResponse StopPreventUninstallSync(StopPreventUninstallRequest req)
        {
            return InternalRequestAsync<StopPreventUninstallResponse>(req, "StopPreventUninstall")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable process guard.
        /// </summary>
        /// <param name="req"><see cref="StopProcessDaemonRequest"/></param>
        /// <returns><see cref="StopProcessDaemonResponse"/></returns>
        public Task<StopProcessDaemonResponse> StopProcessDaemon(StopProcessDaemonRequest req)
        {
            return InternalRequestAsync<StopProcessDaemonResponse>(req, "StopProcessDaemon");
        }

        /// <summary>
        /// This API is used to disable process guard.
        /// </summary>
        /// <param name="req"><see cref="StopProcessDaemonRequest"/></param>
        /// <returns><see cref="StopProcessDaemonResponse"/></returns>
        public StopProcessDaemonResponse StopProcessDaemonSync(StopProcessDaemonRequest req)
        {
            return InternalRequestAsync<StopProcessDaemonResponse>(req, "StopProcessDaemon")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Stop Scanning Tasks of Risk Center
        /// </summary>
        /// <param name="req"><see cref="StopRiskCenterTaskRequest"/></param>
        /// <returns><see cref="StopRiskCenterTaskResponse"/></returns>
        public Task<StopRiskCenterTaskResponse> StopRiskCenterTask(StopRiskCenterTaskRequest req)
        {
            return InternalRequestAsync<StopRiskCenterTaskResponse>(req, "StopRiskCenterTask");
        }

        /// <summary>
        /// Stop Scanning Tasks of Risk Center
        /// </summary>
        /// <param name="req"><see cref="StopRiskCenterTaskRequest"/></param>
        /// <returns><see cref="StopRiskCenterTaskResponse"/></returns>
        public StopRiskCenterTaskResponse StopRiskCenterTaskSync(StopRiskCenterTaskRequest req)
        {
            return InternalRequestAsync<StopRiskCenterTaskResponse>(req, "StopRiskCenterTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Stop vulnerability scanning (task scan).
        /// </summary>
        /// <param name="req"><see cref="StopVulScanTaskRequest"/></param>
        /// <returns><see cref="StopVulScanTaskResponse"/></returns>
        public Task<StopVulScanTaskResponse> StopVulScanTask(StopVulScanTaskRequest req)
        {
            return InternalRequestAsync<StopVulScanTaskResponse>(req, "StopVulScanTask");
        }

        /// <summary>
        /// Stop vulnerability scanning (task scan).
        /// </summary>
        /// <param name="req"><see cref="StopVulScanTaskRequest"/></param>
        /// <returns><see cref="StopVulScanTaskResponse"/></returns>
        public StopVulScanTaskResponse StopVulScanTaskSync(StopVulScanTaskRequest req)
        {
            return InternalRequestAsync<StopVulScanTaskResponse>(req, "StopVulScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Synchronize assets supported by dspm
        /// </summary>
        /// <param name="req"><see cref="SyncDspmAssetsRequest"/></param>
        /// <returns><see cref="SyncDspmAssetsResponse"/></returns>
        public Task<SyncDspmAssetsResponse> SyncDspmAssets(SyncDspmAssetsRequest req)
        {
            return InternalRequestAsync<SyncDspmAssetsResponse>(req, "SyncDspmAssets");
        }

        /// <summary>
        /// Synchronize assets supported by dspm
        /// </summary>
        /// <param name="req"><see cref="SyncDspmAssetsRequest"/></param>
        /// <returns><see cref="SyncDspmAssetsResponse"/></returns>
        public SyncDspmAssetsResponse SyncDspmAssetsSync(SyncDspmAssetsRequest req)
        {
            return InternalRequestAsync<SyncDspmAssetsResponse>(req, "SyncDspmAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Synchronize the list of dspm users.
        /// </summary>
        /// <param name="req"><see cref="SyncDspmUsersRequest"/></param>
        /// <returns><see cref="SyncDspmUsersResponse"/></returns>
        public Task<SyncDspmUsersResponse> SyncDspmUsers(SyncDspmUsersRequest req)
        {
            return InternalRequestAsync<SyncDspmUsersResponse>(req, "SyncDspmUsers");
        }

        /// <summary>
        /// Synchronize the list of dspm users.
        /// </summary>
        /// <param name="req"><see cref="SyncDspmUsersRequest"/></param>
        /// <returns><see cref="SyncDspmUsersResponse"/></returns>
        public SyncDspmUsersResponse SyncDspmUsersSync(SyncDspmUsersRequest req)
        {
            return InternalRequestAsync<SyncDspmUsersResponse>(req, "SyncDspmUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Synchronize the mirror repository
        /// </summary>
        /// <param name="req"><see cref="SyncImageRegistryRequest"/></param>
        /// <returns><see cref="SyncImageRegistryResponse"/></returns>
        public Task<SyncImageRegistryResponse> SyncImageRegistry(SyncImageRegistryRequest req)
        {
            return InternalRequestAsync<SyncImageRegistryResponse>(req, "SyncImageRegistry");
        }

        /// <summary>
        /// Synchronize the mirror repository
        /// </summary>
        /// <param name="req"><see cref="SyncImageRegistryRequest"/></param>
        /// <returns><see cref="SyncImageRegistryResponse"/></returns>
        public SyncImageRegistryResponse SyncImageRegistrySync(SyncImageRegistryRequest req)
        {
            return InternalRequestAsync<SyncImageRegistryResponse>(req, "SyncImageRegistry")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Send a test message to the designated receiving robot to verify reachability and configuration. Use the "Test" button in the corresponding table row.
        /// </summary>
        /// <param name="req"><see cref="TestWebhookReceiverRequest"/></param>
        /// <returns><see cref="TestWebhookReceiverResponse"/></returns>
        public Task<TestWebhookReceiverResponse> TestWebhookReceiver(TestWebhookReceiverRequest req)
        {
            return InternalRequestAsync<TestWebhookReceiverResponse>(req, "TestWebhookReceiver");
        }

        /// <summary>
        /// Send a test message to the designated receiving robot to verify reachability and configuration. Use the "Test" button in the corresponding table row.
        /// </summary>
        /// <param name="req"><see cref="TestWebhookReceiverRequest"/></param>
        /// <returns><see cref="TestWebhookReceiverResponse"/></returns>
        public TestWebhookReceiverResponse TestWebhookReceiverSync(TestWebhookReceiverRequest req)
        {
            return InternalRequestAsync<TestWebhookReceiverResponse>(req, "TestWebhookReceiver")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Uninstall the cluster container security Agent.
        /// </summary>
        /// <param name="req"><see cref="UninstallClusterAgentRequest"/></param>
        /// <returns><see cref="UninstallClusterAgentResponse"/></returns>
        public Task<UninstallClusterAgentResponse> UninstallClusterAgent(UninstallClusterAgentRequest req)
        {
            return InternalRequestAsync<UninstallClusterAgentResponse>(req, "UninstallClusterAgent");
        }

        /// <summary>
        /// Uninstall the cluster container security Agent.
        /// </summary>
        /// <param name="req"><see cref="UninstallClusterAgentRequest"/></param>
        /// <returns><see cref="UninstallClusterAgentResponse"/></returns>
        public UninstallClusterAgentResponse UninstallClusterAgentSync(UninstallClusterAgentRequest req)
        {
            return InternalRequestAsync<UninstallClusterAgentResponse>(req, "UninstallClusterAgent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Uninstall the key sandbox SKILL from designated machine instances. Support batch operations, allowing multiple instance IDs at once. After uninstallation, the AI Agent on the target machine will not be able to access credentials via the key sandbox proxy. Repeated calls on instances not installed will not trigger an error (idempotent), and are directly deemed successful.
        /// </summary>
        /// <param name="req"><see cref="UninstallKeySandboxSkillRequest"/></param>
        /// <returns><see cref="UninstallKeySandboxSkillResponse"/></returns>
        public Task<UninstallKeySandboxSkillResponse> UninstallKeySandboxSkill(UninstallKeySandboxSkillRequest req)
        {
            return InternalRequestAsync<UninstallKeySandboxSkillResponse>(req, "UninstallKeySandboxSkill");
        }

        /// <summary>
        /// Uninstall the key sandbox SKILL from designated machine instances. Support batch operations, allowing multiple instance IDs at once. After uninstallation, the AI Agent on the target machine will not be able to access credentials via the key sandbox proxy. Repeated calls on instances not installed will not trigger an error (idempotent), and are directly deemed successful.
        /// </summary>
        /// <param name="req"><see cref="UninstallKeySandboxSkillRequest"/></param>
        /// <returns><see cref="UninstallKeySandboxSkillResponse"/></returns>
        public UninstallKeySandboxSkillResponse UninstallKeySandboxSkillSync(UninstallKeySandboxSkillRequest req)
        {
            return InternalRequestAsync<UninstallKeySandboxSkillResponse>(req, "UninstallKeySandboxSkill")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Tag risks or alarms as processed or ignored.
        /// </summary>
        /// <param name="req"><see cref="UpdateAccessKeyAlarmStatusRequest"/></param>
        /// <returns><see cref="UpdateAccessKeyAlarmStatusResponse"/></returns>
        public Task<UpdateAccessKeyAlarmStatusResponse> UpdateAccessKeyAlarmStatus(UpdateAccessKeyAlarmStatusRequest req)
        {
            return InternalRequestAsync<UpdateAccessKeyAlarmStatusResponse>(req, "UpdateAccessKeyAlarmStatus");
        }

        /// <summary>
        /// Tag risks or alarms as processed or ignored.
        /// </summary>
        /// <param name="req"><see cref="UpdateAccessKeyAlarmStatusRequest"/></param>
        /// <returns><see cref="UpdateAccessKeyAlarmStatusResponse"/></returns>
        public UpdateAccessKeyAlarmStatusResponse UpdateAccessKeyAlarmStatusSync(UpdateAccessKeyAlarmStatusRequest req)
        {
            return InternalRequestAsync<UpdateAccessKeyAlarmStatusResponse>(req, "UpdateAccessKeyAlarmStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Edit the remark of an access key/source IP.
        /// </summary>
        /// <param name="req"><see cref="UpdateAccessKeyRemarkRequest"/></param>
        /// <returns><see cref="UpdateAccessKeyRemarkResponse"/></returns>
        public Task<UpdateAccessKeyRemarkResponse> UpdateAccessKeyRemark(UpdateAccessKeyRemarkRequest req)
        {
            return InternalRequestAsync<UpdateAccessKeyRemarkResponse>(req, "UpdateAccessKeyRemark");
        }

        /// <summary>
        /// Edit the remark of an access key/source IP.
        /// </summary>
        /// <param name="req"><see cref="UpdateAccessKeyRemarkRequest"/></param>
        /// <returns><see cref="UpdateAccessKeyRemarkResponse"/></returns>
        public UpdateAccessKeyRemarkResponse UpdateAccessKeyRemarkSync(UpdateAccessKeyRemarkRequest req)
        {
            return InternalRequestAsync<UpdateAccessKeyRemarkResponse>(req, "UpdateAccessKeyRemark")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to handle alarm status in batches.
        /// </summary>
        /// <param name="req"><see cref="UpdateAlertStatusListRequest"/></param>
        /// <returns><see cref="UpdateAlertStatusListResponse"/></returns>
        public Task<UpdateAlertStatusListResponse> UpdateAlertStatusList(UpdateAlertStatusListRequest req)
        {
            return InternalRequestAsync<UpdateAlertStatusListResponse>(req, "UpdateAlertStatusList");
        }

        /// <summary>
        /// This API is used to handle alarm status in batches.
        /// </summary>
        /// <param name="req"><see cref="UpdateAlertStatusListRequest"/></param>
        /// <returns><see cref="UpdateAlertStatusListResponse"/></returns>
        public UpdateAlertStatusListResponse UpdateAlertStatusListSync(UpdateAlertStatusListRequest req)
        {
            return InternalRequestAsync<UpdateAlertStatusListResponse>(req, "UpdateAlertStatusList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Bind and update a cluster owner
        /// </summary>
        /// <param name="req"><see cref="UpdateClusterOwnerRequest"/></param>
        /// <returns><see cref="UpdateClusterOwnerResponse"/></returns>
        public Task<UpdateClusterOwnerResponse> UpdateClusterOwner(UpdateClusterOwnerRequest req)
        {
            return InternalRequestAsync<UpdateClusterOwnerResponse>(req, "UpdateClusterOwner");
        }

        /// <summary>
        /// Bind and update a cluster owner
        /// </summary>
        /// <param name="req"><see cref="UpdateClusterOwnerRequest"/></param>
        /// <returns><see cref="UpdateClusterOwnerResponse"/></returns>
        public UpdateClusterOwnerResponse UpdateClusterOwnerSync(UpdateClusterOwnerRequest req)
        {
            return InternalRequestAsync<UpdateClusterOwnerResponse>(req, "UpdateClusterOwner")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Verify the login verification code for a Dspm asset.
        /// </summary>
        /// <param name="req"><see cref="VerifyDspmAssetLoginCodeRequest"/></param>
        /// <returns><see cref="VerifyDspmAssetLoginCodeResponse"/></returns>
        public Task<VerifyDspmAssetLoginCodeResponse> VerifyDspmAssetLoginCode(VerifyDspmAssetLoginCodeRequest req)
        {
            return InternalRequestAsync<VerifyDspmAssetLoginCodeResponse>(req, "VerifyDspmAssetLoginCode");
        }

        /// <summary>
        /// Verify the login verification code for a Dspm asset.
        /// </summary>
        /// <param name="req"><see cref="VerifyDspmAssetLoginCodeRequest"/></param>
        /// <returns><see cref="VerifyDspmAssetLoginCodeResponse"/></returns>
        public VerifyDspmAssetLoginCodeResponse VerifyDspmAssetLoginCodeSync(VerifyDspmAssetLoginCodeRequest req)
        {
            return InternalRequestAsync<VerifyDspmAssetLoginCodeResponse>(req, "VerifyDspmAssetLoginCode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
