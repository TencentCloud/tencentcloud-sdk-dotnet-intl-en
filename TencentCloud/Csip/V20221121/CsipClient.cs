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
       private const string sdkVersion = "SDK_NET_3.0.1372";

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
        /// This API is used to add the CAM role of Cloud Security Center (CSC) to the current account. The name of the CAM role is "csip".
        /// </summary>
        /// <param name="req"><see cref="AddNewBindRoleUserRequest"/></param>
        /// <returns><see cref="AddNewBindRoleUserResponse"/></returns>
        public Task<AddNewBindRoleUserResponse> AddNewBindRoleUser(AddNewBindRoleUserRequest req)
        {
            return InternalRequestAsync<AddNewBindRoleUserResponse>(req, "AddNewBindRoleUser");
        }

        /// <summary>
        /// This API is used to add the CAM role of Cloud Security Center (CSC) to the current account. The name of the CAM role is "csip".
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
        /// Detect AK async task.
        /// </summary>
        /// <param name="req"><see cref="CreateAccessKeyCheckTaskRequest"/></param>
        /// <returns><see cref="CreateAccessKeyCheckTaskResponse"/></returns>
        public Task<CreateAccessKeyCheckTaskResponse> CreateAccessKeyCheckTask(CreateAccessKeyCheckTaskRequest req)
        {
            return InternalRequestAsync<CreateAccessKeyCheckTaskResponse>(req, "CreateAccessKeyCheckTask");
        }

        /// <summary>
        /// Detect AK async task.
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
        /// This API is used to create an asset with the specific domain/IP.
        /// </summary>
        /// <param name="req"><see cref="CreateDomainAndIpRequest"/></param>
        /// <returns><see cref="CreateDomainAndIpResponse"/></returns>
        public Task<CreateDomainAndIpResponse> CreateDomainAndIp(CreateDomainAndIpRequest req)
        {
            return InternalRequestAsync<CreateDomainAndIpResponse>(req, "CreateDomainAndIp");
        }

        /// <summary>
        /// This API is used to create an asset with the specific domain/IP.
        /// </summary>
        /// <param name="req"><see cref="CreateDomainAndIpRequest"/></param>
        /// <returns><see cref="CreateDomainAndIpResponse"/></returns>
        public CreateDomainAndIpResponse CreateDomainAndIpSync(CreateDomainAndIpRequest req)
        {
            return InternalRequestAsync<CreateDomainAndIpResponse>(req, "CreateDomainAndIp")
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
        /// Create an IaC detection integration Token
        /// </summary>
        /// <param name="req"><see cref="CreateIaCAccessTokenRequest"/></param>
        /// <returns><see cref="CreateIaCAccessTokenResponse"/></returns>
        public Task<CreateIaCAccessTokenResponse> CreateIaCAccessToken(CreateIaCAccessTokenRequest req)
        {
            return InternalRequestAsync<CreateIaCAccessTokenResponse>(req, "CreateIaCAccessToken");
        }

        /// <summary>
        /// Create an IaC detection integration Token
        /// </summary>
        /// <param name="req"><see cref="CreateIaCAccessTokenRequest"/></param>
        /// <returns><see cref="CreateIaCAccessTokenResponse"/></returns>
        public CreateIaCAccessTokenResponse CreateIaCAccessTokenSync(CreateIaCAccessTokenRequest req)
        {
            return InternalRequestAsync<CreateIaCAccessTokenResponse>(req, "CreateIaCAccessToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create an IaC detection file export task
        /// </summary>
        /// <param name="req"><see cref="CreateIaCFileExportJobRequest"/></param>
        /// <returns><see cref="CreateIaCFileExportJobResponse"/></returns>
        public Task<CreateIaCFileExportJobResponse> CreateIaCFileExportJob(CreateIaCFileExportJobRequest req)
        {
            return InternalRequestAsync<CreateIaCFileExportJobResponse>(req, "CreateIaCFileExportJob");
        }

        /// <summary>
        /// Create an IaC detection file export task
        /// </summary>
        /// <param name="req"><see cref="CreateIaCFileExportJobRequest"/></param>
        /// <returns><see cref="CreateIaCFileExportJobResponse"/></returns>
        public CreateIaCFileExportJobResponse CreateIaCFileExportJobSync(CreateIaCFileExportJobRequest req)
        {
            return InternalRequestAsync<CreateIaCFileExportJobResponse>(req, "CreateIaCFileExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create an IaC detection file rescan task
        /// </summary>
        /// <param name="req"><see cref="CreateIaCFileReScanTaskRequest"/></param>
        /// <returns><see cref="CreateIaCFileReScanTaskResponse"/></returns>
        public Task<CreateIaCFileReScanTaskResponse> CreateIaCFileReScanTask(CreateIaCFileReScanTaskRequest req)
        {
            return InternalRequestAsync<CreateIaCFileReScanTaskResponse>(req, "CreateIaCFileReScanTask");
        }

        /// <summary>
        /// Create an IaC detection file rescan task
        /// </summary>
        /// <param name="req"><see cref="CreateIaCFileReScanTaskRequest"/></param>
        /// <returns><see cref="CreateIaCFileReScanTaskResponse"/></returns>
        public CreateIaCFileReScanTaskResponse CreateIaCFileReScanTaskSync(CreateIaCFileReScanTaskRequest req)
        {
            return InternalRequestAsync<CreateIaCFileReScanTaskResponse>(req, "CreateIaCFileReScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a risk scan task. 
        /// </summary>
        /// <param name="req"><see cref="CreateRiskCenterScanTaskRequest"/></param>
        /// <returns><see cref="CreateRiskCenterScanTaskResponse"/></returns>
        public Task<CreateRiskCenterScanTaskResponse> CreateRiskCenterScanTask(CreateRiskCenterScanTaskRequest req)
        {
            return InternalRequestAsync<CreateRiskCenterScanTaskResponse>(req, "CreateRiskCenterScanTask");
        }

        /// <summary>
        /// This API is used to create a risk scan task. 
        /// </summary>
        /// <param name="req"><see cref="CreateRiskCenterScanTaskRequest"/></param>
        /// <returns><see cref="CreateRiskCenterScanTaskResponse"/></returns>
        public CreateRiskCenterScanTaskResponse CreateRiskCenterScanTaskSync(CreateRiskCenterScanTaskRequest req)
        {
            return InternalRequestAsync<CreateRiskCenterScanTaskResponse>(req, "CreateRiskCenterScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Upload the Skill ZIP file to trigger asynchronous security detection. After a successful upload, use the returned ContentHash and EngineVersion to poll the DescribeSkillScanResult API to obtain the result. The upload API is idempotent, and uploading the same file with an identical hash will not create a repetition task. The detection result is reserved for 90 days. If overdue, reupload the file for detection.
        /// </summary>
        /// <param name="req"><see cref="CreateSkillScanRequest"/></param>
        /// <returns><see cref="CreateSkillScanResponse"/></returns>
        public Task<CreateSkillScanResponse> CreateSkillScan(CreateSkillScanRequest req)
        {
            return InternalRequestAsync<CreateSkillScanResponse>(req, "CreateSkillScan");
        }

        /// <summary>
        /// Upload the Skill ZIP file to trigger asynchronous security detection. After a successful upload, use the returned ContentHash and EngineVersion to poll the DescribeSkillScanResult API to obtain the result. The upload API is idempotent, and uploading the same file with an identical hash will not create a repetition task. The detection result is reserved for 90 days. If overdue, reupload the file for detection.
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
        /// This API is used to delete assets.
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainAndIpRequest"/></param>
        /// <returns><see cref="DeleteDomainAndIpResponse"/></returns>
        public Task<DeleteDomainAndIpResponse> DeleteDomainAndIp(DeleteDomainAndIpRequest req)
        {
            return InternalRequestAsync<DeleteDomainAndIpResponse>(req, "DeleteDomainAndIp");
        }

        /// <summary>
        /// This API is used to delete assets.
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainAndIpRequest"/></param>
        /// <returns><see cref="DeleteDomainAndIpResponse"/></returns>
        public DeleteDomainAndIpResponse DeleteDomainAndIpSync(DeleteDomainAndIpRequest req)
        {
            return InternalRequestAsync<DeleteDomainAndIpResponse>(req, "DeleteDomainAndIp")
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
        /// Delete IaC detection file
        /// </summary>
        /// <param name="req"><see cref="DeleteIaCFileRequest"/></param>
        /// <returns><see cref="DeleteIaCFileResponse"/></returns>
        public Task<DeleteIaCFileResponse> DeleteIaCFile(DeleteIaCFileRequest req)
        {
            return InternalRequestAsync<DeleteIaCFileResponse>(req, "DeleteIaCFile");
        }

        /// <summary>
        /// Delete IaC detection file
        /// </summary>
        /// <param name="req"><see cref="DeleteIaCFileRequest"/></param>
        /// <returns><see cref="DeleteIaCFileResponse"/></returns>
        public DeleteIaCFileResponse DeleteIaCFileSync(DeleteIaCFileRequest req)
        {
            return InternalRequestAsync<DeleteIaCFileResponse>(req, "DeleteIaCFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a risk scan task.
        /// </summary>
        /// <param name="req"><see cref="DeleteRiskScanTaskRequest"/></param>
        /// <returns><see cref="DeleteRiskScanTaskResponse"/></returns>
        public Task<DeleteRiskScanTaskResponse> DeleteRiskScanTask(DeleteRiskScanTaskRequest req)
        {
            return InternalRequestAsync<DeleteRiskScanTaskResponse>(req, "DeleteRiskScanTask");
        }

        /// <summary>
        /// This API is used to delete a risk scan task.
        /// </summary>
        /// <param name="req"><see cref="DeleteRiskScanTaskRequest"/></param>
        /// <returns><see cref="DeleteRiskScanTaskResponse"/></returns>
        public DeleteRiskScanTaskResponse DeleteRiskScanTaskSync(DeleteRiskScanTaskRequest req)
        {
            return InternalRequestAsync<DeleteRiskScanTaskResponse>(req, "DeleteRiskScanTask")
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
        /// Retrieve the AI agent asset list
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAgentAssetListRequest"/></param>
        /// <returns><see cref="DescribeAIAgentAssetListResponse"/></returns>
        public Task<DescribeAIAgentAssetListResponse> DescribeAIAgentAssetList(DescribeAIAgentAssetListRequest req)
        {
            return InternalRequestAsync<DescribeAIAgentAssetListResponse>(req, "DescribeAIAgentAssetList");
        }

        /// <summary>
        /// Retrieve the AI agent asset list
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAgentAssetListRequest"/></param>
        /// <returns><see cref="DescribeAIAgentAssetListResponse"/></returns>
        public DescribeAIAgentAssetListResponse DescribeAIAgentAssetListSync(DescribeAIAgentAssetListRequest req)
        {
            return InternalRequestAsync<DescribeAIAgentAssetListResponse>(req, "DescribeAIAgentAssetList")
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
        /// Retrieve the call record list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAbnormalCallRecordRequest"/></param>
        /// <returns><see cref="DescribeAbnormalCallRecordResponse"/></returns>
        public Task<DescribeAbnormalCallRecordResponse> DescribeAbnormalCallRecord(DescribeAbnormalCallRecordRequest req)
        {
            return InternalRequestAsync<DescribeAbnormalCallRecordResponse>(req, "DescribeAbnormalCallRecord");
        }

        /// <summary>
        /// Retrieve the call record list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAbnormalCallRecordRequest"/></param>
        /// <returns><see cref="DescribeAbnormalCallRecordResponse"/></returns>
        public DescribeAbnormalCallRecordResponse DescribeAbnormalCallRecordSync(DescribeAbnormalCallRecordRequest req)
        {
            return InternalRequestAsync<DescribeAbnormalCallRecordResponse>(req, "DescribeAbnormalCallRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// List of alarm records for access keys.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessKeyAlarmRequest"/></param>
        /// <returns><see cref="DescribeAccessKeyAlarmResponse"/></returns>
        public Task<DescribeAccessKeyAlarmResponse> DescribeAccessKeyAlarm(DescribeAccessKeyAlarmRequest req)
        {
            return InternalRequestAsync<DescribeAccessKeyAlarmResponse>(req, "DescribeAccessKeyAlarm");
        }

        /// <summary>
        /// List of alarm records for access keys.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessKeyAlarmRequest"/></param>
        /// <returns><see cref="DescribeAccessKeyAlarmResponse"/></returns>
        public DescribeAccessKeyAlarmResponse DescribeAccessKeyAlarmSync(DescribeAccessKeyAlarmRequest req)
        {
            return InternalRequestAsync<DescribeAccessKeyAlarmResponse>(req, "DescribeAccessKeyAlarm")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Alarm Record Details for Access Key.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessKeyAlarmDetailRequest"/></param>
        /// <returns><see cref="DescribeAccessKeyAlarmDetailResponse"/></returns>
        public Task<DescribeAccessKeyAlarmDetailResponse> DescribeAccessKeyAlarmDetail(DescribeAccessKeyAlarmDetailRequest req)
        {
            return InternalRequestAsync<DescribeAccessKeyAlarmDetailResponse>(req, "DescribeAccessKeyAlarmDetail");
        }

        /// <summary>
        /// Alarm Record Details for Access Key.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessKeyAlarmDetailRequest"/></param>
        /// <returns><see cref="DescribeAccessKeyAlarmDetailResponse"/></returns>
        public DescribeAccessKeyAlarmDetailResponse DescribeAccessKeyAlarmDetailSync(DescribeAccessKeyAlarmDetailRequest req)
        {
            return InternalRequestAsync<DescribeAccessKeyAlarmDetailResponse>(req, "DescribeAccessKeyAlarmDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain user access key asset list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessKeyAssetRequest"/></param>
        /// <returns><see cref="DescribeAccessKeyAssetResponse"/></returns>
        public Task<DescribeAccessKeyAssetResponse> DescribeAccessKeyAsset(DescribeAccessKeyAssetRequest req)
        {
            return InternalRequestAsync<DescribeAccessKeyAssetResponse>(req, "DescribeAccessKeyAsset");
        }

        /// <summary>
        /// Obtain user access key asset list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessKeyAssetRequest"/></param>
        /// <returns><see cref="DescribeAccessKeyAssetResponse"/></returns>
        public DescribeAccessKeyAssetResponse DescribeAccessKeyAssetSync(DescribeAccessKeyAssetRequest req)
        {
            return InternalRequestAsync<DescribeAccessKeyAssetResponse>(req, "DescribeAccessKeyAsset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Access key risk record list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessKeyRiskRequest"/></param>
        /// <returns><see cref="DescribeAccessKeyRiskResponse"/></returns>
        public Task<DescribeAccessKeyRiskResponse> DescribeAccessKeyRisk(DescribeAccessKeyRiskRequest req)
        {
            return InternalRequestAsync<DescribeAccessKeyRiskResponse>(req, "DescribeAccessKeyRisk");
        }

        /// <summary>
        /// Access key risk record list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessKeyRiskRequest"/></param>
        /// <returns><see cref="DescribeAccessKeyRiskResponse"/></returns>
        public DescribeAccessKeyRiskResponse DescribeAccessKeyRiskSync(DescribeAccessKeyRiskRequest req)
        {
            return InternalRequestAsync<DescribeAccessKeyRiskResponse>(req, "DescribeAccessKeyRisk")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Access Key Risk Record Details.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessKeyRiskDetailRequest"/></param>
        /// <returns><see cref="DescribeAccessKeyRiskDetailResponse"/></returns>
        public Task<DescribeAccessKeyRiskDetailResponse> DescribeAccessKeyRiskDetail(DescribeAccessKeyRiskDetailRequest req)
        {
            return InternalRequestAsync<DescribeAccessKeyRiskDetailResponse>(req, "DescribeAccessKeyRiskDetail");
        }

        /// <summary>
        /// Access Key Risk Record Details.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessKeyRiskDetailRequest"/></param>
        /// <returns><see cref="DescribeAccessKeyRiskDetailResponse"/></returns>
        public DescribeAccessKeyRiskDetailResponse DescribeAccessKeyRiskDetailSync(DescribeAccessKeyRiskDetailRequest req)
        {
            return InternalRequestAsync<DescribeAccessKeyRiskDetailResponse>(req, "DescribeAccessKeyRiskDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the user's account details.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessKeyUserDetailRequest"/></param>
        /// <returns><see cref="DescribeAccessKeyUserDetailResponse"/></returns>
        public Task<DescribeAccessKeyUserDetailResponse> DescribeAccessKeyUserDetail(DescribeAccessKeyUserDetailRequest req)
        {
            return InternalRequestAsync<DescribeAccessKeyUserDetailResponse>(req, "DescribeAccessKeyUserDetail");
        }

        /// <summary>
        /// Query the user's account details.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessKeyUserDetailRequest"/></param>
        /// <returns><see cref="DescribeAccessKeyUserDetailResponse"/></returns>
        public DescribeAccessKeyUserDetailResponse DescribeAccessKeyUserDetailSync(DescribeAccessKeyUserDetailRequest req)
        {
            return InternalRequestAsync<DescribeAccessKeyUserDetailResponse>(req, "DescribeAccessKeyUserDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the account list of a user.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessKeyUserListRequest"/></param>
        /// <returns><see cref="DescribeAccessKeyUserListResponse"/></returns>
        public Task<DescribeAccessKeyUserListResponse> DescribeAccessKeyUserList(DescribeAccessKeyUserListRequest req)
        {
            return InternalRequestAsync<DescribeAccessKeyUserListResponse>(req, "DescribeAccessKeyUserList");
        }

        /// <summary>
        /// Query the account list of a user.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessKeyUserListRequest"/></param>
        /// <returns><see cref="DescribeAccessKeyUserListResponse"/></returns>
        public DescribeAccessKeyUserListResponse DescribeAccessKeyUserListSync(DescribeAccessKeyUserListRequest req)
        {
            return InternalRequestAsync<DescribeAccessKeyUserListResponse>(req, "DescribeAccessKeyUserList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to list all alarms in the alert center.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlertListRequest"/></param>
        /// <returns><see cref="DescribeAlertListResponse"/></returns>
        public Task<DescribeAlertListResponse> DescribeAlertList(DescribeAlertListRequest req)
        {
            return InternalRequestAsync<DescribeAlertListResponse>(req, "DescribeAlertList");
        }

        /// <summary>
        /// This API is used to list all alarms in the alert center.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlertListRequest"/></param>
        /// <returns><see cref="DescribeAlertListResponse"/></returns>
        public DescribeAlertListResponse DescribeAlertListSync(DescribeAlertListRequest req)
        {
            return InternalRequestAsync<DescribeAlertListResponse>(req, "DescribeAlertList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the process list of host nodes under the exposed path in cloud boundary analysis.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetProcessListRequest"/></param>
        /// <returns><see cref="DescribeAssetProcessListResponse"/></returns>
        public Task<DescribeAssetProcessListResponse> DescribeAssetProcessList(DescribeAssetProcessListRequest req)
        {
            return InternalRequestAsync<DescribeAssetProcessListResponse>(req, "DescribeAssetProcessList");
        }

        /// <summary>
        /// Query the process list of host nodes under the exposed path in cloud boundary analysis.
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetProcessListRequest"/></param>
        /// <returns><see cref="DescribeAssetProcessListResponse"/></returns>
        public DescribeAssetProcessListResponse DescribeAssetProcessListSync(DescribeAssetProcessListRequest req)
        {
            return InternalRequestAsync<DescribeAssetProcessListResponse>(req, "DescribeAssetProcessList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Cloud resource configuration risk list from asset perspective
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetRiskListRequest"/></param>
        /// <returns><see cref="DescribeAssetRiskListResponse"/></returns>
        public Task<DescribeAssetRiskListResponse> DescribeAssetRiskList(DescribeAssetRiskListRequest req)
        {
            return InternalRequestAsync<DescribeAssetRiskListResponse>(req, "DescribeAssetRiskList");
        }

        /// <summary>
        /// Cloud resource configuration risk list from asset perspective
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetRiskListRequest"/></param>
        /// <returns><see cref="DescribeAssetRiskListResponse"/></returns>
        public DescribeAssetRiskListResponse DescribeAssetRiskListSync(DescribeAssetRiskListRequest req)
        {
            return InternalRequestAsync<DescribeAssetRiskListResponse>(req, "DescribeAssetRiskList")
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
        /// Obtain risk center risk overview example.
        /// </summary>
        /// <param name="req"><see cref="DescribeCSIPRiskStatisticsRequest"/></param>
        /// <returns><see cref="DescribeCSIPRiskStatisticsResponse"/></returns>
        public Task<DescribeCSIPRiskStatisticsResponse> DescribeCSIPRiskStatistics(DescribeCSIPRiskStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeCSIPRiskStatisticsResponse>(req, "DescribeCSIPRiskStatistics");
        }

        /// <summary>
        /// Obtain risk center risk overview example.
        /// </summary>
        /// <param name="req"><see cref="DescribeCSIPRiskStatisticsRequest"/></param>
        /// <returns><see cref="DescribeCSIPRiskStatisticsResponse"/></returns>
        public DescribeCSIPRiskStatisticsResponse DescribeCSIPRiskStatisticsSync(DescribeCSIPRiskStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeCSIPRiskStatisticsResponse>(req, "DescribeCSIPRiskStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query details of CVM assets.
        /// </summary>
        /// <param name="req"><see cref="DescribeCVMAssetInfoRequest"/></param>
        /// <returns><see cref="DescribeCVMAssetInfoResponse"/></returns>
        public Task<DescribeCVMAssetInfoResponse> DescribeCVMAssetInfo(DescribeCVMAssetInfoRequest req)
        {
            return InternalRequestAsync<DescribeCVMAssetInfoResponse>(req, "DescribeCVMAssetInfo");
        }

        /// <summary>
        /// This API is used to query details of CVM assets.
        /// </summary>
        /// <param name="req"><see cref="DescribeCVMAssetInfoRequest"/></param>
        /// <returns><see cref="DescribeCVMAssetInfoResponse"/></returns>
        public DescribeCVMAssetInfoResponse DescribeCVMAssetInfoSync(DescribeCVMAssetInfoRequest req)
        {
            return InternalRequestAsync<DescribeCVMAssetInfoResponse>(req, "DescribeCVMAssetInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retrieve the cvm list.
        /// </summary>
        /// <param name="req"><see cref="DescribeCVMAssetsRequest"/></param>
        /// <returns><see cref="DescribeCVMAssetsResponse"/></returns>
        public Task<DescribeCVMAssetsResponse> DescribeCVMAssets(DescribeCVMAssetsRequest req)
        {
            return InternalRequestAsync<DescribeCVMAssetsResponse>(req, "DescribeCVMAssets");
        }

        /// <summary>
        /// Retrieve the cvm list.
        /// </summary>
        /// <param name="req"><see cref="DescribeCVMAssetsRequest"/></param>
        /// <returns><see cref="DescribeCVMAssetsResponse"/></returns>
        public DescribeCVMAssetsResponse DescribeCVMAssetsSync(DescribeCVMAssetsRequest req)
        {
            return InternalRequestAsync<DescribeCVMAssetsResponse>(req, "DescribeCVMAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retrieve the call record list.
        /// </summary>
        /// <param name="req"><see cref="DescribeCallRecordRequest"/></param>
        /// <returns><see cref="DescribeCallRecordResponse"/></returns>
        public Task<DescribeCallRecordResponse> DescribeCallRecord(DescribeCallRecordRequest req)
        {
            return InternalRequestAsync<DescribeCallRecordResponse>(req, "DescribeCallRecord");
        }

        /// <summary>
        /// Retrieve the call record list.
        /// </summary>
        /// <param name="req"><see cref="DescribeCallRecordRequest"/></param>
        /// <returns><see cref="DescribeCallRecordResponse"/></returns>
        public DescribeCallRecordResponse DescribeCallRecordSync(DescribeCallRecordRequest req)
        {
            return InternalRequestAsync<DescribeCallRecordResponse>(req, "DescribeCallRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// List of cloud resource configuration risks from a check perspective
        /// </summary>
        /// <param name="req"><see cref="DescribeCheckViewRisksRequest"/></param>
        /// <returns><see cref="DescribeCheckViewRisksResponse"/></returns>
        public Task<DescribeCheckViewRisksResponse> DescribeCheckViewRisks(DescribeCheckViewRisksRequest req)
        {
            return InternalRequestAsync<DescribeCheckViewRisksResponse>(req, "DescribeCheckViewRisks");
        }

        /// <summary>
        /// List of cloud resource configuration risks from a check perspective
        /// </summary>
        /// <param name="req"><see cref="DescribeCheckViewRisksRequest"/></param>
        /// <returns><see cref="DescribeCheckViewRisksResponse"/></returns>
        public DescribeCheckViewRisksResponse DescribeCheckViewRisksSync(DescribeCheckViewRisksRequest req)
        {
            return InternalRequestAsync<DescribeCheckViewRisksResponse>(req, "DescribeCheckViewRisks")
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
        /// This API is used to list cluster pods.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterPodAssetsRequest"/></param>
        /// <returns><see cref="DescribeClusterPodAssetsResponse"/></returns>
        public Task<DescribeClusterPodAssetsResponse> DescribeClusterPodAssets(DescribeClusterPodAssetsRequest req)
        {
            return InternalRequestAsync<DescribeClusterPodAssetsResponse>(req, "DescribeClusterPodAssets");
        }

        /// <summary>
        /// This API is used to list cluster pods.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterPodAssetsRequest"/></param>
        /// <returns><see cref="DescribeClusterPodAssetsResponse"/></returns>
        public DescribeClusterPodAssetsResponse DescribeClusterPodAssetsSync(DescribeClusterPodAssetsRequest req)
        {
            return InternalRequestAsync<DescribeClusterPodAssetsResponse>(req, "DescribeClusterPodAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Cloud Resource Configuration Risk Rule List Example
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigCheckRulesRequest"/></param>
        /// <returns><see cref="DescribeConfigCheckRulesResponse"/></returns>
        public Task<DescribeConfigCheckRulesResponse> DescribeConfigCheckRules(DescribeConfigCheckRulesRequest req)
        {
            return InternalRequestAsync<DescribeConfigCheckRulesResponse>(req, "DescribeConfigCheckRules");
        }

        /// <summary>
        /// Cloud Resource Configuration Risk Rule List Example
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigCheckRulesRequest"/></param>
        /// <returns><see cref="DescribeConfigCheckRulesResponse"/></returns>
        public DescribeConfigCheckRulesResponse DescribeConfigCheckRulesSync(DescribeConfigCheckRulesRequest req)
        {
            return InternalRequestAsync<DescribeConfigCheckRulesResponse>(req, "DescribeConfigCheckRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query details of a database asset. 
        /// </summary>
        /// <param name="req"><see cref="DescribeDbAssetInfoRequest"/></param>
        /// <returns><see cref="DescribeDbAssetInfoResponse"/></returns>
        public Task<DescribeDbAssetInfoResponse> DescribeDbAssetInfo(DescribeDbAssetInfoRequest req)
        {
            return InternalRequestAsync<DescribeDbAssetInfoResponse>(req, "DescribeDbAssetInfo");
        }

        /// <summary>
        /// This API is used to query details of a database asset. 
        /// </summary>
        /// <param name="req"><see cref="DescribeDbAssetInfoRequest"/></param>
        /// <returns><see cref="DescribeDbAssetInfoResponse"/></returns>
        public DescribeDbAssetInfoResponse DescribeDbAssetInfoSync(DescribeDbAssetInfoRequest req)
        {
            return InternalRequestAsync<DescribeDbAssetInfoResponse>(req, "DescribeDbAssetInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to list database assets.
        /// </summary>
        /// <param name="req"><see cref="DescribeDbAssetsRequest"/></param>
        /// <returns><see cref="DescribeDbAssetsResponse"/></returns>
        public Task<DescribeDbAssetsResponse> DescribeDbAssets(DescribeDbAssetsRequest req)
        {
            return InternalRequestAsync<DescribeDbAssetsResponse>(req, "DescribeDbAssets");
        }

        /// <summary>
        /// This API is used to list database assets.
        /// </summary>
        /// <param name="req"><see cref="DescribeDbAssetsRequest"/></param>
        /// <returns><see cref="DescribeDbAssetsResponse"/></returns>
        public DescribeDbAssetsResponse DescribeDbAssetsSync(DescribeDbAssetsRequest req)
        {
            return InternalRequestAsync<DescribeDbAssetsResponse>(req, "DescribeDbAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to list domain assets. 
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainAssetsRequest"/></param>
        /// <returns><see cref="DescribeDomainAssetsResponse"/></returns>
        public Task<DescribeDomainAssetsResponse> DescribeDomainAssets(DescribeDomainAssetsRequest req)
        {
            return InternalRequestAsync<DescribeDomainAssetsResponse>(req, "DescribeDomainAssets");
        }

        /// <summary>
        /// This API is used to list domain assets. 
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainAssetsRequest"/></param>
        /// <returns><see cref="DescribeDomainAssetsResponse"/></returns>
        public DescribeDomainAssetsResponse DescribeDomainAssetsSync(DescribeDomainAssetsRequest req)
        {
            return InternalRequestAsync<DescribeDomainAssetsResponse>(req, "DescribeDomainAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Cloud boundary analysis asset category.
        /// </summary>
        /// <param name="req"><see cref="DescribeExposeAssetCategoryRequest"/></param>
        /// <returns><see cref="DescribeExposeAssetCategoryResponse"/></returns>
        public Task<DescribeExposeAssetCategoryResponse> DescribeExposeAssetCategory(DescribeExposeAssetCategoryRequest req)
        {
            return InternalRequestAsync<DescribeExposeAssetCategoryResponse>(req, "DescribeExposeAssetCategory");
        }

        /// <summary>
        /// Cloud boundary analysis asset category.
        /// </summary>
        /// <param name="req"><see cref="DescribeExposeAssetCategoryRequest"/></param>
        /// <returns><see cref="DescribeExposeAssetCategoryResponse"/></returns>
        public DescribeExposeAssetCategoryResponse DescribeExposeAssetCategorySync(DescribeExposeAssetCategoryRequest req)
        {
            return InternalRequestAsync<DescribeExposeAssetCategoryResponse>(req, "DescribeExposeAssetCategory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the node of the cloud boundary analysis path.
        /// </summary>
        /// <param name="req"><see cref="DescribeExposePathRequest"/></param>
        /// <returns><see cref="DescribeExposePathResponse"/></returns>
        public Task<DescribeExposePathResponse> DescribeExposePath(DescribeExposePathRequest req)
        {
            return InternalRequestAsync<DescribeExposePathResponse>(req, "DescribeExposePath");
        }

        /// <summary>
        /// Query the node of the cloud boundary analysis path.
        /// </summary>
        /// <param name="req"><see cref="DescribeExposePathRequest"/></param>
        /// <returns><see cref="DescribeExposePathResponse"/></returns>
        public DescribeExposePathResponse DescribeExposePathSync(DescribeExposePathRequest req)
        {
            return InternalRequestAsync<DescribeExposePathResponse>(req, "DescribeExposePath")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Cloud Boundary Analysis Asset List.
        /// </summary>
        /// <param name="req"><see cref="DescribeExposuresRequest"/></param>
        /// <returns><see cref="DescribeExposuresResponse"/></returns>
        public Task<DescribeExposuresResponse> DescribeExposures(DescribeExposuresRequest req)
        {
            return InternalRequestAsync<DescribeExposuresResponse>(req, "DescribeExposures");
        }

        /// <summary>
        /// Cloud Boundary Analysis Asset List.
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
        /// Query the high-risk baseline risk list of host nodes under the exposed path in cloud boundary analysis.
        /// </summary>
        /// <param name="req"><see cref="DescribeHighBaseLineRiskListRequest"/></param>
        /// <returns><see cref="DescribeHighBaseLineRiskListResponse"/></returns>
        public Task<DescribeHighBaseLineRiskListResponse> DescribeHighBaseLineRiskList(DescribeHighBaseLineRiskListRequest req)
        {
            return InternalRequestAsync<DescribeHighBaseLineRiskListResponse>(req, "DescribeHighBaseLineRiskList");
        }

        /// <summary>
        /// Query the high-risk baseline risk list of host nodes under the exposed path in cloud boundary analysis.
        /// </summary>
        /// <param name="req"><see cref="DescribeHighBaseLineRiskListRequest"/></param>
        /// <returns><see cref="DescribeHighBaseLineRiskListResponse"/></returns>
        public DescribeHighBaseLineRiskListResponse DescribeHighBaseLineRiskListSync(DescribeHighBaseLineRiskListRequest req)
        {
            return InternalRequestAsync<DescribeHighBaseLineRiskListResponse>(req, "DescribeHighBaseLineRiskList")
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
        /// Retrieve the IaC detection file list
        /// </summary>
        /// <param name="req"><see cref="DescribeIaCFileListRequest"/></param>
        /// <returns><see cref="DescribeIaCFileListResponse"/></returns>
        public Task<DescribeIaCFileListResponse> DescribeIaCFileList(DescribeIaCFileListRequest req)
        {
            return InternalRequestAsync<DescribeIaCFileListResponse>(req, "DescribeIaCFileList");
        }

        /// <summary>
        /// Retrieve the IaC detection file list
        /// </summary>
        /// <param name="req"><see cref="DescribeIaCFileListRequest"/></param>
        /// <returns><see cref="DescribeIaCFileListResponse"/></returns>
        public DescribeIaCFileListResponse DescribeIaCFileListSync(DescribeIaCFileListRequest req)
        {
            return InternalRequestAsync<DescribeIaCFileListResponse>(req, "DescribeIaCFileList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retrieve IaC detection file overview
        /// </summary>
        /// <param name="req"><see cref="DescribeIaCFileOverviewRequest"/></param>
        /// <returns><see cref="DescribeIaCFileOverviewResponse"/></returns>
        public Task<DescribeIaCFileOverviewResponse> DescribeIaCFileOverview(DescribeIaCFileOverviewRequest req)
        {
            return InternalRequestAsync<DescribeIaCFileOverviewResponse>(req, "DescribeIaCFileOverview");
        }

        /// <summary>
        /// Retrieve IaC detection file overview
        /// </summary>
        /// <param name="req"><see cref="DescribeIaCFileOverviewRequest"/></param>
        /// <returns><see cref="DescribeIaCFileOverviewResponse"/></returns>
        public DescribeIaCFileOverviewResponse DescribeIaCFileOverviewSync(DescribeIaCFileOverviewRequest req)
        {
            return InternalRequestAsync<DescribeIaCFileOverviewResponse>(req, "DescribeIaCFileOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retrieve the IaC detection file report
        /// </summary>
        /// <param name="req"><see cref="DescribeIaCFileReportRequest"/></param>
        /// <returns><see cref="DescribeIaCFileReportResponse"/></returns>
        public Task<DescribeIaCFileReportResponse> DescribeIaCFileReport(DescribeIaCFileReportRequest req)
        {
            return InternalRequestAsync<DescribeIaCFileReportResponse>(req, "DescribeIaCFileReport");
        }

        /// <summary>
        /// Retrieve the IaC detection file report
        /// </summary>
        /// <param name="req"><see cref="DescribeIaCFileReportRequest"/></param>
        /// <returns><see cref="DescribeIaCFileReportResponse"/></returns>
        public DescribeIaCFileReportResponse DescribeIaCFileReportSync(DescribeIaCFileReportRequest req)
        {
            return InternalRequestAsync<DescribeIaCFileReportResponse>(req, "DescribeIaCFileReport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retrieve the IaC detection integration Token list
        /// </summary>
        /// <param name="req"><see cref="DescribeIaCTokenListRequest"/></param>
        /// <returns><see cref="DescribeIaCTokenListResponse"/></returns>
        public Task<DescribeIaCTokenListResponse> DescribeIaCTokenList(DescribeIaCTokenListRequest req)
        {
            return InternalRequestAsync<DescribeIaCTokenListResponse>(req, "DescribeIaCTokenList");
        }

        /// <summary>
        /// Retrieve the IaC detection integration Token list
        /// </summary>
        /// <param name="req"><see cref="DescribeIaCTokenListRequest"/></param>
        /// <returns><see cref="DescribeIaCTokenListResponse"/></returns>
        public DescribeIaCTokenListResponse DescribeIaCTokenListSync(DescribeIaCTokenListRequest req)
        {
            return InternalRequestAsync<DescribeIaCTokenListResponse>(req, "DescribeIaCTokenList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query credential details and return credential metadata and masked credential data. The access kind returns an Access array (original Key, masked Value), and the sts kind returns an STS object (original System, masked SecretID and SecretKey).
        /// </summary>
        /// <param name="req"><see cref="DescribeKeySandboxCredentialRequest"/></param>
        /// <returns><see cref="DescribeKeySandboxCredentialResponse"/></returns>
        public Task<DescribeKeySandboxCredentialResponse> DescribeKeySandboxCredential(DescribeKeySandboxCredentialRequest req)
        {
            return InternalRequestAsync<DescribeKeySandboxCredentialResponse>(req, "DescribeKeySandboxCredential");
        }

        /// <summary>
        /// Query credential details and return credential metadata and masked credential data. The access kind returns an Access array (original Key, masked Value), and the sts kind returns an STS object (original System, masked SecretID and SecretKey).
        /// </summary>
        /// <param name="req"><see cref="DescribeKeySandboxCredentialRequest"/></param>
        /// <returns><see cref="DescribeKeySandboxCredentialResponse"/></returns>
        public DescribeKeySandboxCredentialResponse DescribeKeySandboxCredentialSync(DescribeKeySandboxCredentialRequest req)
        {
            return InternalRequestAsync<DescribeKeySandboxCredentialResponse>(req, "DescribeKeySandboxCredential")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the voucher list
        /// </summary>
        /// <param name="req"><see cref="DescribeKeySandboxCredentialListRequest"/></param>
        /// <returns><see cref="DescribeKeySandboxCredentialListResponse"/></returns>
        public Task<DescribeKeySandboxCredentialListResponse> DescribeKeySandboxCredentialList(DescribeKeySandboxCredentialListRequest req)
        {
            return InternalRequestAsync<DescribeKeySandboxCredentialListResponse>(req, "DescribeKeySandboxCredentialList");
        }

        /// <summary>
        /// Query the voucher list
        /// </summary>
        /// <param name="req"><see cref="DescribeKeySandboxCredentialListRequest"/></param>
        /// <returns><see cref="DescribeKeySandboxCredentialListResponse"/></returns>
        public DescribeKeySandboxCredentialListResponse DescribeKeySandboxCredentialListSync(DescribeKeySandboxCredentialListRequest req)
        {
            return InternalRequestAsync<DescribeKeySandboxCredentialListResponse>(req, "DescribeKeySandboxCredentialList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of TCP listeners.
        /// </summary>
        /// <param name="req"><see cref="DescribeListenerListRequest"/></param>
        /// <returns><see cref="DescribeListenerListResponse"/></returns>
        public Task<DescribeListenerListResponse> DescribeListenerList(DescribeListenerListRequest req)
        {
            return InternalRequestAsync<DescribeListenerListResponse>(req, "DescribeListenerList");
        }

        /// <summary>
        /// This API is used to query the list of TCP listeners.
        /// </summary>
        /// <param name="req"><see cref="DescribeListenerListRequest"/></param>
        /// <returns><see cref="DescribeListenerListResponse"/></returns>
        public DescribeListenerListResponse DescribeListenerListSync(DescribeListenerListRequest req)
        {
            return InternalRequestAsync<DescribeListenerListResponse>(req, "DescribeListenerList")
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
        /// Gets the list of other cloud assets
        /// </summary>
        /// <param name="req"><see cref="DescribeOtherCloudAssetsRequest"/></param>
        /// <returns><see cref="DescribeOtherCloudAssetsResponse"/></returns>
        public Task<DescribeOtherCloudAssetsResponse> DescribeOtherCloudAssets(DescribeOtherCloudAssetsRequest req)
        {
            return InternalRequestAsync<DescribeOtherCloudAssetsResponse>(req, "DescribeOtherCloudAssets");
        }

        /// <summary>
        /// Gets the list of other cloud assets
        /// </summary>
        /// <param name="req"><see cref="DescribeOtherCloudAssetsRequest"/></param>
        /// <returns><see cref="DescribeOtherCloudAssetsResponse"/></returns>
        public DescribeOtherCloudAssetsResponse DescribeOtherCloudAssetsSync(DescribeOtherCloudAssetsRequest req)
        {
            return InternalRequestAsync<DescribeOtherCloudAssetsResponse>(req, "DescribeOtherCloudAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of public IP assets.
        /// </summary>
        /// <param name="req"><see cref="DescribePublicIpAssetsRequest"/></param>
        /// <returns><see cref="DescribePublicIpAssetsResponse"/></returns>
        public Task<DescribePublicIpAssetsResponse> DescribePublicIpAssets(DescribePublicIpAssetsRequest req)
        {
            return InternalRequestAsync<DescribePublicIpAssetsResponse>(req, "DescribePublicIpAssets");
        }

        /// <summary>
        /// This API is used to query the list of public IP assets.
        /// </summary>
        /// <param name="req"><see cref="DescribePublicIpAssetsRequest"/></param>
        /// <returns><see cref="DescribePublicIpAssetsResponse"/></returns>
        public DescribePublicIpAssetsResponse DescribePublicIpAssetsSync(DescribePublicIpAssetsRequest req)
        {
            return InternalRequestAsync<DescribePublicIpAssetsResponse>(req, "DescribePublicIpAssets")
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
        /// Retrieve risk call record list.
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCallRecordRequest"/></param>
        /// <returns><see cref="DescribeRiskCallRecordResponse"/></returns>
        public Task<DescribeRiskCallRecordResponse> DescribeRiskCallRecord(DescribeRiskCallRecordRequest req)
        {
            return InternalRequestAsync<DescribeRiskCallRecordResponse>(req, "DescribeRiskCallRecord");
        }

        /// <summary>
        /// Retrieve risk call record list.
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCallRecordRequest"/></param>
        /// <returns><see cref="DescribeRiskCallRecordResponse"/></returns>
        public DescribeRiskCallRecordResponse DescribeRiskCallRecordSync(DescribeRiskCallRecordRequest req)
        {
            return InternalRequestAsync<DescribeRiskCallRecordResponse>(req, "DescribeRiskCallRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of configuration risks by assets.
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterAssetViewCFGRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterAssetViewCFGRiskListResponse"/></returns>
        public Task<DescribeRiskCenterAssetViewCFGRiskListResponse> DescribeRiskCenterAssetViewCFGRiskList(DescribeRiskCenterAssetViewCFGRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterAssetViewCFGRiskListResponse>(req, "DescribeRiskCenterAssetViewCFGRiskList");
        }

        /// <summary>
        /// This API is used to query the list of configuration risks by assets.
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterAssetViewCFGRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterAssetViewCFGRiskListResponse"/></returns>
        public DescribeRiskCenterAssetViewCFGRiskListResponse DescribeRiskCenterAssetViewCFGRiskListSync(DescribeRiskCenterAssetViewCFGRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterAssetViewCFGRiskListResponse>(req, "DescribeRiskCenterAssetViewCFGRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of port risks by assets.
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterAssetViewPortRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterAssetViewPortRiskListResponse"/></returns>
        public Task<DescribeRiskCenterAssetViewPortRiskListResponse> DescribeRiskCenterAssetViewPortRiskList(DescribeRiskCenterAssetViewPortRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterAssetViewPortRiskListResponse>(req, "DescribeRiskCenterAssetViewPortRiskList");
        }

        /// <summary>
        /// This API is used to query the list of port risks by assets.
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterAssetViewPortRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterAssetViewPortRiskListResponse"/></returns>
        public DescribeRiskCenterAssetViewPortRiskListResponse DescribeRiskCenterAssetViewPortRiskListSync(DescribeRiskCenterAssetViewPortRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterAssetViewPortRiskListResponse>(req, "DescribeRiskCenterAssetViewPortRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of vulnerabilities by assets.
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterAssetViewVULRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterAssetViewVULRiskListResponse"/></returns>
        public Task<DescribeRiskCenterAssetViewVULRiskListResponse> DescribeRiskCenterAssetViewVULRiskList(DescribeRiskCenterAssetViewVULRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterAssetViewVULRiskListResponse>(req, "DescribeRiskCenterAssetViewVULRiskList");
        }

        /// <summary>
        /// This API is used to query the list of vulnerabilities by assets.
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterAssetViewVULRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterAssetViewVULRiskListResponse"/></returns>
        public DescribeRiskCenterAssetViewVULRiskListResponse DescribeRiskCenterAssetViewVULRiskListSync(DescribeRiskCenterAssetViewVULRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterAssetViewVULRiskListResponse>(req, "DescribeRiskCenterAssetViewVULRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of weak passwords by assets.
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterAssetViewWeakPasswordRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterAssetViewWeakPasswordRiskListResponse"/></returns>
        public Task<DescribeRiskCenterAssetViewWeakPasswordRiskListResponse> DescribeRiskCenterAssetViewWeakPasswordRiskList(DescribeRiskCenterAssetViewWeakPasswordRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterAssetViewWeakPasswordRiskListResponse>(req, "DescribeRiskCenterAssetViewWeakPasswordRiskList");
        }

        /// <summary>
        /// This API is used to query the list of weak passwords by assets.
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
        /// This API is used to query the list of port risks by ports.
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterPortViewPortRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterPortViewPortRiskListResponse"/></returns>
        public Task<DescribeRiskCenterPortViewPortRiskListResponse> DescribeRiskCenterPortViewPortRiskList(DescribeRiskCenterPortViewPortRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterPortViewPortRiskListResponse>(req, "DescribeRiskCenterPortViewPortRiskList");
        }

        /// <summary>
        /// This API is used to query the list of port risks by ports.
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterPortViewPortRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterPortViewPortRiskListResponse"/></returns>
        public DescribeRiskCenterPortViewPortRiskListResponse DescribeRiskCenterPortViewPortRiskListSync(DescribeRiskCenterPortViewPortRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterPortViewPortRiskListResponse>(req, "DescribeRiskCenterPortViewPortRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of services in risk.
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterServerRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterServerRiskListResponse"/></returns>
        public Task<DescribeRiskCenterServerRiskListResponse> DescribeRiskCenterServerRiskList(DescribeRiskCenterServerRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterServerRiskListResponse>(req, "DescribeRiskCenterServerRiskList");
        }

        /// <summary>
        /// This API is used to query the list of services in risk.
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterServerRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterServerRiskListResponse"/></returns>
        public DescribeRiskCenterServerRiskListResponse DescribeRiskCenterServerRiskListSync(DescribeRiskCenterServerRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterServerRiskListResponse>(req, "DescribeRiskCenterServerRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of vulnerabilities by vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterVULViewVULRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterVULViewVULRiskListResponse"/></returns>
        public Task<DescribeRiskCenterVULViewVULRiskListResponse> DescribeRiskCenterVULViewVULRiskList(DescribeRiskCenterVULViewVULRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterVULViewVULRiskListResponse>(req, "DescribeRiskCenterVULViewVULRiskList");
        }

        /// <summary>
        /// This API is used to query the list of vulnerabilities by vulnerabilities.
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
        /// Risk detail list example
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskDetailListRequest"/></param>
        /// <returns><see cref="DescribeRiskDetailListResponse"/></returns>
        public Task<DescribeRiskDetailListResponse> DescribeRiskDetailList(DescribeRiskDetailListRequest req)
        {
            return InternalRequestAsync<DescribeRiskDetailListResponse>(req, "DescribeRiskDetailList");
        }

        /// <summary>
        /// Risk detail list example
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskDetailListRequest"/></param>
        /// <returns><see cref="DescribeRiskDetailListResponse"/></returns>
        public DescribeRiskDetailListResponse DescribeRiskDetailListSync(DescribeRiskDetailListRequest req)
        {
            return InternalRequestAsync<DescribeRiskDetailListResponse>(req, "DescribeRiskDetailList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query risk rule details example
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskRuleDetailRequest"/></param>
        /// <returns><see cref="DescribeRiskRuleDetailResponse"/></returns>
        public Task<DescribeRiskRuleDetailResponse> DescribeRiskRuleDetail(DescribeRiskRuleDetailRequest req)
        {
            return InternalRequestAsync<DescribeRiskRuleDetailResponse>(req, "DescribeRiskRuleDetail");
        }

        /// <summary>
        /// Query risk rule details example
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskRuleDetailRequest"/></param>
        /// <returns><see cref="DescribeRiskRuleDetailResponse"/></returns>
        public DescribeRiskRuleDetailResponse DescribeRiskRuleDetailSync(DescribeRiskRuleDetailRequest req)
        {
            return InternalRequestAsync<DescribeRiskRuleDetailResponse>(req, "DescribeRiskRuleDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Advanced configuration risk rule list illustrative example
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskRulesRequest"/></param>
        /// <returns><see cref="DescribeRiskRulesResponse"/></returns>
        public Task<DescribeRiskRulesResponse> DescribeRiskRules(DescribeRiskRulesRequest req)
        {
            return InternalRequestAsync<DescribeRiskRulesResponse>(req, "DescribeRiskRules");
        }

        /// <summary>
        /// Advanced configuration risk rule list illustrative example
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskRulesRequest"/></param>
        /// <returns><see cref="DescribeRiskRulesResponse"/></returns>
        public DescribeRiskRulesResponse DescribeRiskRulesSync(DescribeRiskRulesRequest req)
        {
            return InternalRequestAsync<DescribeRiskRulesResponse>(req, "DescribeRiskRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of scan reports.
        /// </summary>
        /// <param name="req"><see cref="DescribeScanReportListRequest"/></param>
        /// <returns><see cref="DescribeScanReportListResponse"/></returns>
        public Task<DescribeScanReportListResponse> DescribeScanReportList(DescribeScanReportListRequest req)
        {
            return InternalRequestAsync<DescribeScanReportListResponse>(req, "DescribeScanReportList");
        }

        /// <summary>
        /// This API is used to get the list of scan reports.
        /// </summary>
        /// <param name="req"><see cref="DescribeScanReportListRequest"/></param>
        /// <returns><see cref="DescribeScanReportListResponse"/></returns>
        public DescribeScanReportListResponse DescribeScanReportListSync(DescribeScanReportListRequest req)
        {
            return InternalRequestAsync<DescribeScanReportListResponse>(req, "DescribeScanReportList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the statistical information of cloud boundary analysis scanning results.
        /// </summary>
        /// <param name="req"><see cref="DescribeScanStatisticRequest"/></param>
        /// <returns><see cref="DescribeScanStatisticResponse"/></returns>
        public Task<DescribeScanStatisticResponse> DescribeScanStatistic(DescribeScanStatisticRequest req)
        {
            return InternalRequestAsync<DescribeScanStatisticResponse>(req, "DescribeScanStatistic");
        }

        /// <summary>
        /// Query the statistical information of cloud boundary analysis scanning results.
        /// </summary>
        /// <param name="req"><see cref="DescribeScanStatisticRequest"/></param>
        /// <returns><see cref="DescribeScanStatisticResponse"/></returns>
        public DescribeScanStatisticResponse DescribeScanStatisticSync(DescribeScanStatisticRequest req)
        {
            return InternalRequestAsync<DescribeScanStatisticResponse>(req, "DescribeScanStatistic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of scan tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeScanTaskListRequest"/></param>
        /// <returns><see cref="DescribeScanTaskListResponse"/></returns>
        public Task<DescribeScanTaskListResponse> DescribeScanTaskList(DescribeScanTaskListRequest req)
        {
            return InternalRequestAsync<DescribeScanTaskListResponse>(req, "DescribeScanTaskList");
        }

        /// <summary>
        /// This API is used to get the list of scan tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeScanTaskListRequest"/></param>
        /// <returns><see cref="DescribeScanTaskListResponse"/></returns>
        public DescribeScanTaskListResponse DescribeScanTaskListSync(DescribeScanTaskListRequest req)
        {
            return InternalRequestAsync<DescribeScanTaskListResponse>(req, "DescribeScanTaskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query information of a vulnerability.
        /// </summary>
        /// <param name="req"><see cref="DescribeSearchBugInfoRequest"/></param>
        /// <returns><see cref="DescribeSearchBugInfoResponse"/></returns>
        public Task<DescribeSearchBugInfoResponse> DescribeSearchBugInfo(DescribeSearchBugInfoRequest req)
        {
            return InternalRequestAsync<DescribeSearchBugInfoResponse>(req, "DescribeSearchBugInfo");
        }

        /// <summary>
        /// This API is used to query information of a vulnerability.
        /// </summary>
        /// <param name="req"><see cref="DescribeSearchBugInfoRequest"/></param>
        /// <returns><see cref="DescribeSearchBugInfoResponse"/></returns>
        public DescribeSearchBugInfoResponse DescribeSearchBugInfoSync(DescribeSearchBugInfoRequest req)
        {
            return InternalRequestAsync<DescribeSearchBugInfoResponse>(req, "DescribeSearchBugInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the billing information of Skill security detection, including order status, total quota, consumed quota, expiry time, and payment mode. It returns zero values (only TimeNow and BetaEndTime included) when no order exists. Trial orders can be claimed via ModifyTrialStatus(Module=9), and official orders are generated by the billing system.
        /// </summary>
        /// <param name="req"><see cref="DescribeSkillScanPayInfoRequest"/></param>
        /// <returns><see cref="DescribeSkillScanPayInfoResponse"/></returns>
        public Task<DescribeSkillScanPayInfoResponse> DescribeSkillScanPayInfo(DescribeSkillScanPayInfoRequest req)
        {
            return InternalRequestAsync<DescribeSkillScanPayInfoResponse>(req, "DescribeSkillScanPayInfo");
        }

        /// <summary>
        /// This API is used to query the billing information of Skill security detection, including order status, total quota, consumed quota, expiry time, and payment mode. It returns zero values (only TimeNow and BetaEndTime included) when no order exists. Trial orders can be claimed via ModifyTrialStatus(Module=9), and official orders are generated by the billing system.
        /// </summary>
        /// <param name="req"><see cref="DescribeSkillScanPayInfoRequest"/></param>
        /// <returns><see cref="DescribeSkillScanPayInfoResponse"/></returns>
        public DescribeSkillScanPayInfoResponse DescribeSkillScanPayInfoSync(DescribeSkillScanPayInfoRequest req)
        {
            return InternalRequestAsync<DescribeSkillScanPayInfoResponse>(req, "DescribeSkillScanPayInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the security detection result of Skill. After successfully calling CreateSkillScan, use the returned ContentHash + EngineVersion to poll this interface and obtain the result. For the first time, poll 5 minutes after successful upload. If detection is not completed, poll every 1 minute afterward. The response distinguishes four types of status via the Status field: detection complete (SUCCESS), in-progress detection (SCANNING), no record (NOT_FOUND), and detection failed (FAILED). Note: The detection result is retained for 90 days. It will return NOT_FOUND when overdue.
        /// </summary>
        /// <param name="req"><see cref="DescribeSkillScanResultRequest"/></param>
        /// <returns><see cref="DescribeSkillScanResultResponse"/></returns>
        public Task<DescribeSkillScanResultResponse> DescribeSkillScanResult(DescribeSkillScanResultRequest req)
        {
            return InternalRequestAsync<DescribeSkillScanResultResponse>(req, "DescribeSkillScanResult");
        }

        /// <summary>
        /// Query the security detection result of Skill. After successfully calling CreateSkillScan, use the returned ContentHash + EngineVersion to poll this interface and obtain the result. For the first time, poll 5 minutes after successful upload. If detection is not completed, poll every 1 minute afterward. The response distinguishes four types of status via the Status field: detection complete (SUCCESS), in-progress detection (SCANNING), no record (NOT_FOUND), and detection failed (FAILED). Note: The detection result is retained for 90 days. It will return NOT_FOUND when overdue.
        /// </summary>
        /// <param name="req"><see cref="DescribeSkillScanResultRequest"/></param>
        /// <returns><see cref="DescribeSkillScanResultResponse"/></returns>
        public DescribeSkillScanResultResponse DescribeSkillScanResultSync(DescribeSkillScanResultRequest req)
        {
            return InternalRequestAsync<DescribeSkillScanResultResponse>(req, "DescribeSkillScanResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain user access key asset list (source IP perspective).
        /// </summary>
        /// <param name="req"><see cref="DescribeSourceIPAssetRequest"/></param>
        /// <returns><see cref="DescribeSourceIPAssetResponse"/></returns>
        public Task<DescribeSourceIPAssetResponse> DescribeSourceIPAsset(DescribeSourceIPAssetRequest req)
        {
            return InternalRequestAsync<DescribeSourceIPAssetResponse>(req, "DescribeSourceIPAsset");
        }

        /// <summary>
        /// This API is used to obtain user access key asset list (source IP perspective).
        /// </summary>
        /// <param name="req"><see cref="DescribeSourceIPAssetRequest"/></param>
        /// <returns><see cref="DescribeSourceIPAssetResponse"/></returns>
        public DescribeSourceIPAssetResponse DescribeSourceIPAssetSync(DescribeSourceIPAssetRequest req)
        {
            return InternalRequestAsync<DescribeSourceIPAssetResponse>(req, "DescribeSourceIPAsset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the sub-account list of the group
        /// </summary>
        /// <param name="req"><see cref="DescribeSubUserInfoRequest"/></param>
        /// <returns><see cref="DescribeSubUserInfoResponse"/></returns>
        public Task<DescribeSubUserInfoResponse> DescribeSubUserInfo(DescribeSubUserInfoRequest req)
        {
            return InternalRequestAsync<DescribeSubUserInfoResponse>(req, "DescribeSubUserInfo");
        }

        /// <summary>
        /// Query the sub-account list of the group
        /// </summary>
        /// <param name="req"><see cref="DescribeSubUserInfoRequest"/></param>
        /// <returns><see cref="DescribeSubUserInfoResponse"/></returns>
        public DescribeSubUserInfoResponse DescribeSubUserInfoSync(DescribeSubUserInfoRequest req)
        {
            return InternalRequestAsync<DescribeSubUserInfoResponse>(req, "DescribeSubUserInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of subnets.
        /// </summary>
        /// <param name="req"><see cref="DescribeSubnetAssetsRequest"/></param>
        /// <returns><see cref="DescribeSubnetAssetsResponse"/></returns>
        public Task<DescribeSubnetAssetsResponse> DescribeSubnetAssets(DescribeSubnetAssetsRequest req)
        {
            return InternalRequestAsync<DescribeSubnetAssetsResponse>(req, "DescribeSubnetAssets");
        }

        /// <summary>
        /// This API is used to get the list of subnets.
        /// </summary>
        /// <param name="req"><see cref="DescribeSubnetAssetsRequest"/></param>
        /// <returns><see cref="DescribeSubnetAssetsResponse"/></returns>
        public DescribeSubnetAssetsResponse DescribeSubnetAssetsSync(DescribeSubnetAssetsRequest req)
        {
            return InternalRequestAsync<DescribeSubnetAssetsResponse>(req, "DescribeSubnetAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of scan task reports.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskLogListRequest"/></param>
        /// <returns><see cref="DescribeTaskLogListResponse"/></returns>
        public Task<DescribeTaskLogListResponse> DescribeTaskLogList(DescribeTaskLogListRequest req)
        {
            return InternalRequestAsync<DescribeTaskLogListResponse>(req, "DescribeTaskLogList");
        }

        /// <summary>
        /// This API is used to get the list of scan task reports.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskLogListRequest"/></param>
        /// <returns><see cref="DescribeTaskLogListResponse"/></returns>
        public DescribeTaskLogListResponse DescribeTaskLogListSync(DescribeTaskLogListRequest req)
        {
            return InternalRequestAsync<DescribeTaskLogListResponse>(req, "DescribeTaskLogList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the temp download link of a report. 
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskLogURLRequest"/></param>
        /// <returns><see cref="DescribeTaskLogURLResponse"/></returns>
        public Task<DescribeTaskLogURLResponse> DescribeTaskLogURL(DescribeTaskLogURLRequest req)
        {
            return InternalRequestAsync<DescribeTaskLogURLResponse>(req, "DescribeTaskLogURL");
        }

        /// <summary>
        /// This API is used to get the temp download link of a report. 
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskLogURLRequest"/></param>
        /// <returns><see cref="DescribeTaskLogURLResponse"/></returns>
        public DescribeTaskLogURLResponse DescribeTaskLogURLSync(DescribeTaskLogURLRequest req)
        {
            return InternalRequestAsync<DescribeTaskLogURLResponse>(req, "DescribeTaskLogURL")
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
        /// Query the user behavior analysis policy list
        /// </summary>
        /// <param name="req"><see cref="DescribeUebaRuleRequest"/></param>
        /// <returns><see cref="DescribeUebaRuleResponse"/></returns>
        public Task<DescribeUebaRuleResponse> DescribeUebaRule(DescribeUebaRuleRequest req)
        {
            return InternalRequestAsync<DescribeUebaRuleResponse>(req, "DescribeUebaRule");
        }

        /// <summary>
        /// Query the user behavior analysis policy list
        /// </summary>
        /// <param name="req"><see cref="DescribeUebaRuleRequest"/></param>
        /// <returns><see cref="DescribeUebaRuleResponse"/></returns>
        public DescribeUebaRuleResponse DescribeUebaRuleSync(DescribeUebaRuleRequest req)
        {
            return InternalRequestAsync<DescribeUebaRuleResponse>(req, "DescribeUebaRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain account call record list.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserCallRecordRequest"/></param>
        /// <returns><see cref="DescribeUserCallRecordResponse"/></returns>
        public Task<DescribeUserCallRecordResponse> DescribeUserCallRecord(DescribeUserCallRecordRequest req)
        {
            return InternalRequestAsync<DescribeUserCallRecordResponse>(req, "DescribeUserCallRecord");
        }

        /// <summary>
        /// Obtain account call record list.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserCallRecordRequest"/></param>
        /// <returns><see cref="DescribeUserCallRecordResponse"/></returns>
        public DescribeUserCallRecordResponse DescribeUserCallRecordSync(DescribeUserCallRecordRequest req)
        {
            return InternalRequestAsync<DescribeUserCallRecordResponse>(req, "DescribeUserCallRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Security Center Risk Center - List of Vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="DescribeVULListRequest"/></param>
        /// <returns><see cref="DescribeVULListResponse"/></returns>
        public Task<DescribeVULListResponse> DescribeVULList(DescribeVULListRequest req)
        {
            return InternalRequestAsync<DescribeVULListResponse>(req, "DescribeVULList");
        }

        /// <summary>
        /// Security Center Risk Center - List of Vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="DescribeVULListRequest"/></param>
        /// <returns><see cref="DescribeVULListResponse"/></returns>
        public DescribeVULListResponse DescribeVULListSync(DescribeVULListRequest req)
        {
            return InternalRequestAsync<DescribeVULListResponse>(req, "DescribeVULList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the advanced configuration of vulnerability scan.
        /// </summary>
        /// <param name="req"><see cref="DescribeVULRiskAdvanceCFGListRequest"/></param>
        /// <returns><see cref="DescribeVULRiskAdvanceCFGListResponse"/></returns>
        public Task<DescribeVULRiskAdvanceCFGListResponse> DescribeVULRiskAdvanceCFGList(DescribeVULRiskAdvanceCFGListRequest req)
        {
            return InternalRequestAsync<DescribeVULRiskAdvanceCFGListResponse>(req, "DescribeVULRiskAdvanceCFGList");
        }

        /// <summary>
        /// This API is used to query the advanced configuration of vulnerability scan.
        /// </summary>
        /// <param name="req"><see cref="DescribeVULRiskAdvanceCFGListRequest"/></param>
        /// <returns><see cref="DescribeVULRiskAdvanceCFGListResponse"/></returns>
        public DescribeVULRiskAdvanceCFGListResponse DescribeVULRiskAdvanceCFGListSync(DescribeVULRiskAdvanceCFGListRequest req)
        {
            return InternalRequestAsync<DescribeVULRiskAdvanceCFGListResponse>(req, "DescribeVULRiskAdvanceCFGList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retrieve vulnerability details.
        /// </summary>
        /// <param name="req"><see cref="DescribeVULRiskDetailRequest"/></param>
        /// <returns><see cref="DescribeVULRiskDetailResponse"/></returns>
        public Task<DescribeVULRiskDetailResponse> DescribeVULRiskDetail(DescribeVULRiskDetailRequest req)
        {
            return InternalRequestAsync<DescribeVULRiskDetailResponse>(req, "DescribeVULRiskDetail");
        }

        /// <summary>
        /// Retrieve vulnerability details.
        /// </summary>
        /// <param name="req"><see cref="DescribeVULRiskDetailRequest"/></param>
        /// <returns><see cref="DescribeVULRiskDetailResponse"/></returns>
        public DescribeVULRiskDetailResponse DescribeVULRiskDetailSync(DescribeVULRiskDetailRequest req)
        {
            return InternalRequestAsync<DescribeVULRiskDetailResponse>(req, "DescribeVULRiskDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of VPCs.
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcAssetsRequest"/></param>
        /// <returns><see cref="DescribeVpcAssetsResponse"/></returns>
        public Task<DescribeVpcAssetsResponse> DescribeVpcAssets(DescribeVpcAssetsRequest req)
        {
            return InternalRequestAsync<DescribeVpcAssetsResponse>(req, "DescribeVpcAssets");
        }

        /// <summary>
        /// This API is used to get the list of VPCs.
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
        /// Query the list of vulnerabilities of host nodes under the exposed path in cloud boundary analysis.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulRiskListRequest"/></param>
        /// <returns><see cref="DescribeVulRiskListResponse"/></returns>
        public Task<DescribeVulRiskListResponse> DescribeVulRiskList(DescribeVulRiskListRequest req)
        {
            return InternalRequestAsync<DescribeVulRiskListResponse>(req, "DescribeVulRiskList");
        }

        /// <summary>
        /// Query the list of vulnerabilities of host nodes under the exposed path in cloud boundary analysis.
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
        /// This API is used to modify the storage cycle of the IaC detection integration Token.
        /// </summary>
        /// <param name="req"><see cref="ModifyIaCTokenPeriodRequest"/></param>
        /// <returns><see cref="ModifyIaCTokenPeriodResponse"/></returns>
        public Task<ModifyIaCTokenPeriodResponse> ModifyIaCTokenPeriod(ModifyIaCTokenPeriodRequest req)
        {
            return InternalRequestAsync<ModifyIaCTokenPeriodResponse>(req, "ModifyIaCTokenPeriod");
        }

        /// <summary>
        /// This API is used to modify the storage cycle of the IaC detection integration Token.
        /// </summary>
        /// <param name="req"><see cref="ModifyIaCTokenPeriodRequest"/></param>
        /// <returns><see cref="ModifyIaCTokenPeriodResponse"/></returns>
        public ModifyIaCTokenPeriodResponse ModifyIaCTokenPeriodSync(ModifyIaCTokenPeriodRequest req)
        {
            return InternalRequestAsync<ModifyIaCTokenPeriodResponse>(req, "ModifyIaCTokenPeriod")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify group account status
        /// </summary>
        /// <param name="req"><see cref="ModifyOrganizationAccountStatusRequest"/></param>
        /// <returns><see cref="ModifyOrganizationAccountStatusResponse"/></returns>
        public Task<ModifyOrganizationAccountStatusResponse> ModifyOrganizationAccountStatus(ModifyOrganizationAccountStatusRequest req)
        {
            return InternalRequestAsync<ModifyOrganizationAccountStatusResponse>(req, "ModifyOrganizationAccountStatus");
        }

        /// <summary>
        /// Modify group account status
        /// </summary>
        /// <param name="req"><see cref="ModifyOrganizationAccountStatusRequest"/></param>
        /// <returns><see cref="ModifyOrganizationAccountStatusResponse"/></returns>
        public ModifyOrganizationAccountStatusResponse ModifyOrganizationAccountStatusSync(ModifyOrganizationAccountStatusRequest req)
        {
            return InternalRequestAsync<ModifyOrganizationAccountStatusResponse>(req, "ModifyOrganizationAccountStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the status of a risk. 
        /// </summary>
        /// <param name="req"><see cref="ModifyRiskCenterRiskStatusRequest"/></param>
        /// <returns><see cref="ModifyRiskCenterRiskStatusResponse"/></returns>
        public Task<ModifyRiskCenterRiskStatusResponse> ModifyRiskCenterRiskStatus(ModifyRiskCenterRiskStatusRequest req)
        {
            return InternalRequestAsync<ModifyRiskCenterRiskStatusResponse>(req, "ModifyRiskCenterRiskStatus");
        }

        /// <summary>
        /// This API is used to modify the status of a risk. 
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
        /// Refresh the custom policy switch
        /// </summary>
        /// <param name="req"><see cref="ModifyUebaRuleSwitchRequest"/></param>
        /// <returns><see cref="ModifyUebaRuleSwitchResponse"/></returns>
        public Task<ModifyUebaRuleSwitchResponse> ModifyUebaRuleSwitch(ModifyUebaRuleSwitchRequest req)
        {
            return InternalRequestAsync<ModifyUebaRuleSwitchResponse>(req, "ModifyUebaRuleSwitch");
        }

        /// <summary>
        /// Refresh the custom policy switch
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
        /// This API is used to stop a scan task. 
        /// </summary>
        /// <param name="req"><see cref="StopRiskCenterTaskRequest"/></param>
        /// <returns><see cref="StopRiskCenterTaskResponse"/></returns>
        public Task<StopRiskCenterTaskResponse> StopRiskCenterTask(StopRiskCenterTaskRequest req)
        {
            return InternalRequestAsync<StopRiskCenterTaskResponse>(req, "StopRiskCenterTask");
        }

        /// <summary>
        /// This API is used to stop a scan task. 
        /// </summary>
        /// <param name="req"><see cref="StopRiskCenterTaskRequest"/></param>
        /// <returns><see cref="StopRiskCenterTaskResponse"/></returns>
        public StopRiskCenterTaskResponse StopRiskCenterTaskSync(StopRiskCenterTaskRequest req)
        {
            return InternalRequestAsync<StopRiskCenterTaskResponse>(req, "StopRiskCenterTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Tag the risk or Alarm as processed/ignored.
        /// </summary>
        /// <param name="req"><see cref="UpdateAccessKeyAlarmStatusRequest"/></param>
        /// <returns><see cref="UpdateAccessKeyAlarmStatusResponse"/></returns>
        public Task<UpdateAccessKeyAlarmStatusResponse> UpdateAccessKeyAlarmStatus(UpdateAccessKeyAlarmStatusRequest req)
        {
            return InternalRequestAsync<UpdateAccessKeyAlarmStatusResponse>(req, "UpdateAccessKeyAlarmStatus");
        }

        /// <summary>
        /// Tag the risk or Alarm as processed/ignored.
        /// </summary>
        /// <param name="req"><see cref="UpdateAccessKeyAlarmStatusRequest"/></param>
        /// <returns><see cref="UpdateAccessKeyAlarmStatusResponse"/></returns>
        public UpdateAccessKeyAlarmStatusResponse UpdateAccessKeyAlarmStatusSync(UpdateAccessKeyAlarmStatusRequest req)
        {
            return InternalRequestAsync<UpdateAccessKeyAlarmStatusResponse>(req, "UpdateAccessKeyAlarmStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Edit access key/Source IP remark.
        /// </summary>
        /// <param name="req"><see cref="UpdateAccessKeyRemarkRequest"/></param>
        /// <returns><see cref="UpdateAccessKeyRemarkResponse"/></returns>
        public Task<UpdateAccessKeyRemarkResponse> UpdateAccessKeyRemark(UpdateAccessKeyRemarkRequest req)
        {
            return InternalRequestAsync<UpdateAccessKeyRemarkResponse>(req, "UpdateAccessKeyRemark");
        }

        /// <summary>
        /// Edit access key/Source IP remark.
        /// </summary>
        /// <param name="req"><see cref="UpdateAccessKeyRemarkRequest"/></param>
        /// <returns><see cref="UpdateAccessKeyRemarkResponse"/></returns>
        public UpdateAccessKeyRemarkResponse UpdateAccessKeyRemarkSync(UpdateAccessKeyRemarkRequest req)
        {
            return InternalRequestAsync<UpdateAccessKeyRemarkResponse>(req, "UpdateAccessKeyRemark")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Batch alarm status process API
        /// </summary>
        /// <param name="req"><see cref="UpdateAlertStatusListRequest"/></param>
        /// <returns><see cref="UpdateAlertStatusListResponse"/></returns>
        public Task<UpdateAlertStatusListResponse> UpdateAlertStatusList(UpdateAlertStatusListRequest req)
        {
            return InternalRequestAsync<UpdateAlertStatusListResponse>(req, "UpdateAlertStatusList");
        }

        /// <summary>
        /// Batch alarm status process API
        /// </summary>
        /// <param name="req"><see cref="UpdateAlertStatusListRequest"/></param>
        /// <returns><see cref="UpdateAlertStatusListResponse"/></returns>
        public UpdateAlertStatusListResponse UpdateAlertStatusListSync(UpdateAlertStatusListRequest req)
        {
            return InternalRequestAsync<UpdateAlertStatusListResponse>(req, "UpdateAlertStatusList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
