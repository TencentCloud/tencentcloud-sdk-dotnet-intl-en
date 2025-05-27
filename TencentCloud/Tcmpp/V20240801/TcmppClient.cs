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

namespace TencentCloud.Tcmpp.V20240801
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tcmpp.V20240801.Models;

   public class TcmppClient : AbstractClient{

       private const string endpoint = "tcmpp.intl.tencentcloudapi.com";
       private const string version = "2024-08-01";
       private const string sdkVersion = "SDK_NET_3.0.1139";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TcmppClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TcmppClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to add a team member.
        /// </summary>
        /// <param name="req"><see cref="AddTeamMemberRequest"/></param>
        /// <returns><see cref="AddTeamMemberResponse"/></returns>
        public Task<AddTeamMemberResponse> AddTeamMember(AddTeamMemberRequest req)
        {
            return InternalRequestAsync<AddTeamMemberResponse>(req, "AddTeamMember");
        }

        /// <summary>
        /// This API is used to add a team member.
        /// </summary>
        /// <param name="req"><see cref="AddTeamMemberRequest"/></param>
        /// <returns><see cref="AddTeamMemberResponse"/></returns>
        public AddTeamMemberResponse AddTeamMemberSync(AddTeamMemberRequest req)
        {
            return InternalRequestAsync<AddTeamMemberResponse>(req, "AddTeamMember")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query if the domain is in the allowlist or blocklist
        /// </summary>
        /// <param name="req"><see cref="CheckGlobalDomainRequest"/></param>
        /// <returns><see cref="CheckGlobalDomainResponse"/></returns>
        public Task<CheckGlobalDomainResponse> CheckGlobalDomain(CheckGlobalDomainRequest req)
        {
            return InternalRequestAsync<CheckGlobalDomainResponse>(req, "CheckGlobalDomain");
        }

        /// <summary>
        /// This API is used to query if the domain is in the allowlist or blocklist
        /// </summary>
        /// <param name="req"><see cref="CheckGlobalDomainRequest"/></param>
        /// <returns><see cref="CheckGlobalDomainResponse"/></returns>
        public CheckGlobalDomainResponse CheckGlobalDomainSync(CheckGlobalDomainRequest req)
        {
            return InternalRequestAsync<CheckGlobalDomainResponse>(req, "CheckGlobalDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to configure the preview version of a mini program.
        /// </summary>
        /// <param name="req"><see cref="ConfigureMNPPreviewRequest"/></param>
        /// <returns><see cref="ConfigureMNPPreviewResponse"/></returns>
        public Task<ConfigureMNPPreviewResponse> ConfigureMNPPreview(ConfigureMNPPreviewRequest req)
        {
            return InternalRequestAsync<ConfigureMNPPreviewResponse>(req, "ConfigureMNPPreview");
        }

        /// <summary>
        /// This API is used to configure the preview version of a mini program.
        /// </summary>
        /// <param name="req"><see cref="ConfigureMNPPreviewRequest"/></param>
        /// <returns><see cref="ConfigureMNPPreviewResponse"/></returns>
        public ConfigureMNPPreviewResponse ConfigureMNPPreviewSync(ConfigureMNPPreviewRequest req)
        {
            return InternalRequestAsync<ConfigureMNPPreviewResponse>(req, "ConfigureMNPPreview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an application.
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationRequest"/></param>
        /// <returns><see cref="CreateApplicationResponse"/></returns>
        public Task<CreateApplicationResponse> CreateApplication(CreateApplicationRequest req)
        {
            return InternalRequestAsync<CreateApplicationResponse>(req, "CreateApplication");
        }

        /// <summary>
        /// This API is used to create an application.
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationRequest"/></param>
        /// <returns><see cref="CreateApplicationResponse"/></returns>
        public CreateApplicationResponse CreateApplicationSync(CreateApplicationRequest req)
        {
            return InternalRequestAsync<CreateApplicationResponse>(req, "CreateApplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a sensitive API of an application.
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationSensitiveAPIRequest"/></param>
        /// <returns><see cref="CreateApplicationSensitiveAPIResponse"/></returns>
        public Task<CreateApplicationSensitiveAPIResponse> CreateApplicationSensitiveAPI(CreateApplicationSensitiveAPIRequest req)
        {
            return InternalRequestAsync<CreateApplicationSensitiveAPIResponse>(req, "CreateApplicationSensitiveAPI");
        }

        /// <summary>
        /// This API is used to create a sensitive API of an application.
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationSensitiveAPIRequest"/></param>
        /// <returns><see cref="CreateApplicationSensitiveAPIResponse"/></returns>
        public CreateApplicationSensitiveAPIResponse CreateApplicationSensitiveAPISync(CreateApplicationSensitiveAPIRequest req)
        {
            return InternalRequestAsync<CreateApplicationSensitiveAPIResponse>(req, "CreateApplicationSensitiveAPI")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add a new mini program version
        /// </summary>
        /// <param name="req"><see cref="CreateConsoleMNPVersionCompileTaskRequest"/></param>
        /// <returns><see cref="CreateConsoleMNPVersionCompileTaskResponse"/></returns>
        public Task<CreateConsoleMNPVersionCompileTaskResponse> CreateConsoleMNPVersionCompileTask(CreateConsoleMNPVersionCompileTaskRequest req)
        {
            return InternalRequestAsync<CreateConsoleMNPVersionCompileTaskResponse>(req, "CreateConsoleMNPVersionCompileTask");
        }

        /// <summary>
        /// This API is used to add a new mini program version
        /// </summary>
        /// <param name="req"><see cref="CreateConsoleMNPVersionCompileTaskRequest"/></param>
        /// <returns><see cref="CreateConsoleMNPVersionCompileTaskResponse"/></returns>
        public CreateConsoleMNPVersionCompileTaskResponse CreateConsoleMNPVersionCompileTaskSync(CreateConsoleMNPVersionCompileTaskRequest req)
        {
            return InternalRequestAsync<CreateConsoleMNPVersionCompileTaskResponse>(req, "CreateConsoleMNPVersionCompileTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a mini program service domain
        /// </summary>
        /// <param name="req"><see cref="CreateDomainRequest"/></param>
        /// <returns><see cref="CreateDomainResponse"/></returns>
        public Task<CreateDomainResponse> CreateDomain(CreateDomainRequest req)
        {
            return InternalRequestAsync<CreateDomainResponse>(req, "CreateDomain");
        }

        /// <summary>
        /// This API is used to create a mini program service domain
        /// </summary>
        /// <param name="req"><see cref="CreateDomainRequest"/></param>
        /// <returns><see cref="CreateDomainResponse"/></returns>
        public CreateDomainResponse CreateDomainSync(CreateDomainRequest req)
        {
            return InternalRequestAsync<CreateDomainResponse>(req, "CreateDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add domains to allowlist or blocklist
        /// </summary>
        /// <param name="req"><see cref="CreateGlobalDomainRequest"/></param>
        /// <returns><see cref="CreateGlobalDomainResponse"/></returns>
        public Task<CreateGlobalDomainResponse> CreateGlobalDomain(CreateGlobalDomainRequest req)
        {
            return InternalRequestAsync<CreateGlobalDomainResponse>(req, "CreateGlobalDomain");
        }

        /// <summary>
        /// This API is used to add domains to allowlist or blocklist
        /// </summary>
        /// <param name="req"><see cref="CreateGlobalDomainRequest"/></param>
        /// <returns><see cref="CreateGlobalDomainResponse"/></returns>
        public CreateGlobalDomainResponse CreateGlobalDomainSync(CreateGlobalDomainRequest req)
        {
            return InternalRequestAsync<CreateGlobalDomainResponse>(req, "CreateGlobalDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a global domain allowlist or blocklist.
        /// </summary>
        /// <param name="req"><see cref="CreateGlobalDomainACLRequest"/></param>
        /// <returns><see cref="CreateGlobalDomainACLResponse"/></returns>
        public Task<CreateGlobalDomainACLResponse> CreateGlobalDomainACL(CreateGlobalDomainACLRequest req)
        {
            return InternalRequestAsync<CreateGlobalDomainACLResponse>(req, "CreateGlobalDomainACL");
        }

        /// <summary>
        /// This API is used to create a global domain allowlist or blocklist.
        /// </summary>
        /// <param name="req"><see cref="CreateGlobalDomainACLRequest"/></param>
        /// <returns><see cref="CreateGlobalDomainACLResponse"/></returns>
        public CreateGlobalDomainACLResponse CreateGlobalDomainACLSync(CreateGlobalDomainACLRequest req)
        {
            return InternalRequestAsync<CreateGlobalDomainACLResponse>(req, "CreateGlobalDomainACL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a mini program
        /// </summary>
        /// <param name="req"><see cref="CreateMNPRequest"/></param>
        /// <returns><see cref="CreateMNPResponse"/></returns>
        public Task<CreateMNPResponse> CreateMNP(CreateMNPRequest req)
        {
            return InternalRequestAsync<CreateMNPResponse>(req, "CreateMNP");
        }

        /// <summary>
        /// This API is used to create a mini program
        /// </summary>
        /// <param name="req"><see cref="CreateMNPRequest"/></param>
        /// <returns><see cref="CreateMNPResponse"/></returns>
        public CreateMNPResponse CreateMNPSync(CreateMNPRequest req)
        {
            return InternalRequestAsync<CreateMNPResponse>(req, "CreateMNP")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a mini program approval request.
        /// </summary>
        /// <param name="req"><see cref="CreateMNPApprovalRequest"/></param>
        /// <returns><see cref="CreateMNPApprovalResponse"/></returns>
        public Task<CreateMNPApprovalResponse> CreateMNPApproval(CreateMNPApprovalRequest req)
        {
            return InternalRequestAsync<CreateMNPApprovalResponse>(req, "CreateMNPApproval");
        }

        /// <summary>
        /// This API is used to create a mini program approval request.
        /// </summary>
        /// <param name="req"><see cref="CreateMNPApprovalRequest"/></param>
        /// <returns><see cref="CreateMNPApprovalResponse"/></returns>
        public CreateMNPApprovalResponse CreateMNPApprovalSync(CreateMNPApprovalRequest req)
        {
            return InternalRequestAsync<CreateMNPApprovalResponse>(req, "CreateMNPApproval")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add a domain name to the allowlist/blocklist of a mini program.
        /// </summary>
        /// <param name="req"><see cref="CreateMNPDomainACLRequest"/></param>
        /// <returns><see cref="CreateMNPDomainACLResponse"/></returns>
        public Task<CreateMNPDomainACLResponse> CreateMNPDomainACL(CreateMNPDomainACLRequest req)
        {
            return InternalRequestAsync<CreateMNPDomainACLResponse>(req, "CreateMNPDomainACL");
        }

        /// <summary>
        /// This API is used to add a domain name to the allowlist/blocklist of a mini program.
        /// </summary>
        /// <param name="req"><see cref="CreateMNPDomainACLRequest"/></param>
        /// <returns><see cref="CreateMNPDomainACLResponse"/></returns>
        public CreateMNPDomainACLResponse CreateMNPDomainACLSync(CreateMNPDomainACLRequest req)
        {
            return InternalRequestAsync<CreateMNPDomainACLResponse>(req, "CreateMNPDomainACL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a permission request to allow a mini program calling sensitive APIs.
        /// </summary>
        /// <param name="req"><see cref="CreateMNPSensitiveAPIPermissionApprovalRequest"/></param>
        /// <returns><see cref="CreateMNPSensitiveAPIPermissionApprovalResponse"/></returns>
        public Task<CreateMNPSensitiveAPIPermissionApprovalResponse> CreateMNPSensitiveAPIPermissionApproval(CreateMNPSensitiveAPIPermissionApprovalRequest req)
        {
            return InternalRequestAsync<CreateMNPSensitiveAPIPermissionApprovalResponse>(req, "CreateMNPSensitiveAPIPermissionApproval");
        }

        /// <summary>
        /// This API is used to create a permission request to allow a mini program calling sensitive APIs.
        /// </summary>
        /// <param name="req"><see cref="CreateMNPSensitiveAPIPermissionApprovalRequest"/></param>
        /// <returns><see cref="CreateMNPSensitiveAPIPermissionApprovalResponse"/></returns>
        public CreateMNPSensitiveAPIPermissionApprovalResponse CreateMNPSensitiveAPIPermissionApprovalSync(CreateMNPSensitiveAPIPermissionApprovalRequest req)
        {
            return InternalRequestAsync<CreateMNPSensitiveAPIPermissionApprovalResponse>(req, "CreateMNPSensitiveAPIPermissionApproval")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a mini program version.
        /// </summary>
        /// <param name="req"><see cref="CreateMNPVersionRequest"/></param>
        /// <returns><see cref="CreateMNPVersionResponse"/></returns>
        public Task<CreateMNPVersionResponse> CreateMNPVersion(CreateMNPVersionRequest req)
        {
            return InternalRequestAsync<CreateMNPVersionResponse>(req, "CreateMNPVersion");
        }

        /// <summary>
        /// This API is used to create a mini program version.
        /// </summary>
        /// <param name="req"><see cref="CreateMNPVersionRequest"/></param>
        /// <returns><see cref="CreateMNPVersionResponse"/></returns>
        public CreateMNPVersionResponse CreateMNPVersionSync(CreateMNPVersionRequest req)
        {
            return InternalRequestAsync<CreateMNPVersionResponse>(req, "CreateMNPVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to release the mini program
        /// </summary>
        /// <param name="req"><see cref="CreateOnlineApplyRequest"/></param>
        /// <returns><see cref="CreateOnlineApplyResponse"/></returns>
        public Task<CreateOnlineApplyResponse> CreateOnlineApply(CreateOnlineApplyRequest req)
        {
            return InternalRequestAsync<CreateOnlineApplyResponse>(req, "CreateOnlineApply");
        }

        /// <summary>
        /// This API is used to release the mini program
        /// </summary>
        /// <param name="req"><see cref="CreateOnlineApplyRequest"/></param>
        /// <returns><see cref="CreateOnlineApplyResponse"/></returns>
        public CreateOnlineApplyResponse CreateOnlineApplySync(CreateOnlineApplyRequest req)
        {
            return InternalRequestAsync<CreateOnlineApplyResponse>(req, "CreateOnlineApply")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to submit mini program version for approval
        /// </summary>
        /// <param name="req"><see cref="CreatePlatformAuditRequest"/></param>
        /// <returns><see cref="CreatePlatformAuditResponse"/></returns>
        public Task<CreatePlatformAuditResponse> CreatePlatformAudit(CreatePlatformAuditRequest req)
        {
            return InternalRequestAsync<CreatePlatformAuditResponse>(req, "CreatePlatformAudit");
        }

        /// <summary>
        /// This API is used to submit mini program version for approval
        /// </summary>
        /// <param name="req"><see cref="CreatePlatformAuditRequest"/></param>
        /// <returns><see cref="CreatePlatformAuditResponse"/></returns>
        public CreatePlatformAuditResponse CreatePlatformAuditSync(CreatePlatformAuditRequest req)
        {
            return InternalRequestAsync<CreatePlatformAuditResponse>(req, "CreatePlatformAudit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the encryption key
        /// </summary>
        /// <param name="req"><see cref="CreatePresetKeyRequest"/></param>
        /// <returns><see cref="CreatePresetKeyResponse"/></returns>
        public Task<CreatePresetKeyResponse> CreatePresetKey(CreatePresetKeyRequest req)
        {
            return InternalRequestAsync<CreatePresetKeyResponse>(req, "CreatePresetKey");
        }

        /// <summary>
        /// This API is used to obtain the encryption key
        /// </summary>
        /// <param name="req"><see cref="CreatePresetKeyRequest"/></param>
        /// <returns><see cref="CreatePresetKeyResponse"/></returns>
        public CreatePresetKeyResponse CreatePresetKeySync(CreatePresetKeyRequest req)
        {
            return InternalRequestAsync<CreatePresetKeyResponse>(req, "CreatePresetKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add a sensitive API
        /// </summary>
        /// <param name="req"><see cref="CreateSensitiveAPIRequest"/></param>
        /// <returns><see cref="CreateSensitiveAPIResponse"/></returns>
        public Task<CreateSensitiveAPIResponse> CreateSensitiveAPI(CreateSensitiveAPIRequest req)
        {
            return InternalRequestAsync<CreateSensitiveAPIResponse>(req, "CreateSensitiveAPI");
        }

        /// <summary>
        /// This API is used to add a sensitive API
        /// </summary>
        /// <param name="req"><see cref="CreateSensitiveAPIRequest"/></param>
        /// <returns><see cref="CreateSensitiveAPIResponse"/></returns>
        public CreateSensitiveAPIResponse CreateSensitiveAPISync(CreateSensitiveAPIRequest req)
        {
            return InternalRequestAsync<CreateSensitiveAPIResponse>(req, "CreateSensitiveAPI")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to apply for sensitive API permissions
        /// </summary>
        /// <param name="req"><see cref="CreateSensitiveApiApplyRequest"/></param>
        /// <returns><see cref="CreateSensitiveApiApplyResponse"/></returns>
        public Task<CreateSensitiveApiApplyResponse> CreateSensitiveApiApply(CreateSensitiveApiApplyRequest req)
        {
            return InternalRequestAsync<CreateSensitiveApiApplyResponse>(req, "CreateSensitiveApiApply");
        }

        /// <summary>
        /// This API is used to apply for sensitive API permissions
        /// </summary>
        /// <param name="req"><see cref="CreateSensitiveApiApplyRequest"/></param>
        /// <returns><see cref="CreateSensitiveApiApplyResponse"/></returns>
        public CreateSensitiveApiApplyResponse CreateSensitiveApiApplySync(CreateSensitiveApiApplyRequest req)
        {
            return InternalRequestAsync<CreateSensitiveApiApplyResponse>(req, "CreateSensitiveApiApply")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a team.
        /// </summary>
        /// <param name="req"><see cref="CreateTeamRequest"/></param>
        /// <returns><see cref="CreateTeamResponse"/></returns>
        public Task<CreateTeamResponse> CreateTeam(CreateTeamRequest req)
        {
            return InternalRequestAsync<CreateTeamResponse>(req, "CreateTeam");
        }

        /// <summary>
        /// This API is used to create a team.
        /// </summary>
        /// <param name="req"><see cref="CreateTeamRequest"/></param>
        /// <returns><see cref="CreateTeamResponse"/></returns>
        public CreateTeamResponse CreateTeamSync(CreateTeamRequest req)
        {
            return InternalRequestAsync<CreateTeamResponse>(req, "CreateTeam")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add team members
        /// </summary>
        /// <param name="req"><see cref="CreateTeamMemberRequest"/></param>
        /// <returns><see cref="CreateTeamMemberResponse"/></returns>
        public Task<CreateTeamMemberResponse> CreateTeamMember(CreateTeamMemberRequest req)
        {
            return InternalRequestAsync<CreateTeamMemberResponse>(req, "CreateTeamMember");
        }

        /// <summary>
        /// This API is used to add team members
        /// </summary>
        /// <param name="req"><see cref="CreateTeamMemberRequest"/></param>
        /// <returns><see cref="CreateTeamMemberResponse"/></returns>
        public CreateTeamMemberResponse CreateTeamMemberSync(CreateTeamMemberRequest req)
        {
            return InternalRequestAsync<CreateTeamMemberResponse>(req, "CreateTeamMember")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a user
        /// </summary>
        /// <param name="req"><see cref="CreateUserRequest"/></param>
        /// <returns><see cref="CreateUserResponse"/></returns>
        public Task<CreateUserResponse> CreateUser(CreateUserRequest req)
        {
            return InternalRequestAsync<CreateUserResponse>(req, "CreateUser");
        }

        /// <summary>
        /// This API is used to create a user
        /// </summary>
        /// <param name="req"><see cref="CreateUserRequest"/></param>
        /// <returns><see cref="CreateUserResponse"/></returns>
        public CreateUserResponse CreateUserSync(CreateUserRequest req)
        {
            return InternalRequestAsync<CreateUserResponse>(req, "CreateUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete applications
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationRequest"/></param>
        /// <returns><see cref="DeleteApplicationResponse"/></returns>
        public Task<DeleteApplicationResponse> DeleteApplication(DeleteApplicationRequest req)
        {
            return InternalRequestAsync<DeleteApplicationResponse>(req, "DeleteApplication");
        }

        /// <summary>
        /// This API is used to delete applications
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationRequest"/></param>
        /// <returns><see cref="DeleteApplicationResponse"/></returns>
        public DeleteApplicationResponse DeleteApplicationSync(DeleteApplicationRequest req)
        {
            return InternalRequestAsync<DeleteApplicationResponse>(req, "DeleteApplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a sensitive API.
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationSensitiveAPIRequest"/></param>
        /// <returns><see cref="DeleteApplicationSensitiveAPIResponse"/></returns>
        public Task<DeleteApplicationSensitiveAPIResponse> DeleteApplicationSensitiveAPI(DeleteApplicationSensitiveAPIRequest req)
        {
            return InternalRequestAsync<DeleteApplicationSensitiveAPIResponse>(req, "DeleteApplicationSensitiveAPI");
        }

        /// <summary>
        /// This API is used to delete a sensitive API.
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationSensitiveAPIRequest"/></param>
        /// <returns><see cref="DeleteApplicationSensitiveAPIResponse"/></returns>
        public DeleteApplicationSensitiveAPIResponse DeleteApplicationSensitiveAPISync(DeleteApplicationSensitiveAPIRequest req)
        {
            return InternalRequestAsync<DeleteApplicationSensitiveAPIResponse>(req, "DeleteApplicationSensitiveAPI")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete domains from allowlist or blocklist
        /// </summary>
        /// <param name="req"><see cref="DeleteGlobalDomainRequest"/></param>
        /// <returns><see cref="DeleteGlobalDomainResponse"/></returns>
        public Task<DeleteGlobalDomainResponse> DeleteGlobalDomain(DeleteGlobalDomainRequest req)
        {
            return InternalRequestAsync<DeleteGlobalDomainResponse>(req, "DeleteGlobalDomain");
        }

        /// <summary>
        /// This API is used to delete domains from allowlist or blocklist
        /// </summary>
        /// <param name="req"><see cref="DeleteGlobalDomainRequest"/></param>
        /// <returns><see cref="DeleteGlobalDomainResponse"/></returns>
        public DeleteGlobalDomainResponse DeleteGlobalDomainSync(DeleteGlobalDomainRequest req)
        {
            return InternalRequestAsync<DeleteGlobalDomainResponse>(req, "DeleteGlobalDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the mini program
        /// </summary>
        /// <param name="req"><see cref="DeleteMNPRequest"/></param>
        /// <returns><see cref="DeleteMNPResponse"/></returns>
        public Task<DeleteMNPResponse> DeleteMNP(DeleteMNPRequest req)
        {
            return InternalRequestAsync<DeleteMNPResponse>(req, "DeleteMNP");
        }

        /// <summary>
        /// This API is used to delete the mini program
        /// </summary>
        /// <param name="req"><see cref="DeleteMNPRequest"/></param>
        /// <returns><see cref="DeleteMNPResponse"/></returns>
        public DeleteMNPResponse DeleteMNPSync(DeleteMNPRequest req)
        {
            return InternalRequestAsync<DeleteMNPResponse>(req, "DeleteMNP")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete sensitive API
        /// </summary>
        /// <param name="req"><see cref="DeleteSensitiveAPIRequest"/></param>
        /// <returns><see cref="DeleteSensitiveAPIResponse"/></returns>
        public Task<DeleteSensitiveAPIResponse> DeleteSensitiveAPI(DeleteSensitiveAPIRequest req)
        {
            return InternalRequestAsync<DeleteSensitiveAPIResponse>(req, "DeleteSensitiveAPI");
        }

        /// <summary>
        /// This API is used to delete sensitive API
        /// </summary>
        /// <param name="req"><see cref="DeleteSensitiveAPIRequest"/></param>
        /// <returns><see cref="DeleteSensitiveAPIResponse"/></returns>
        public DeleteSensitiveAPIResponse DeleteSensitiveAPISync(DeleteSensitiveAPIRequest req)
        {
            return InternalRequestAsync<DeleteSensitiveAPIResponse>(req, "DeleteSensitiveAPI")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a team
        /// </summary>
        /// <param name="req"><see cref="DeleteTeamRequest"/></param>
        /// <returns><see cref="DeleteTeamResponse"/></returns>
        public Task<DeleteTeamResponse> DeleteTeam(DeleteTeamRequest req)
        {
            return InternalRequestAsync<DeleteTeamResponse>(req, "DeleteTeam");
        }

        /// <summary>
        /// This API is used to delete a team
        /// </summary>
        /// <param name="req"><see cref="DeleteTeamRequest"/></param>
        /// <returns><see cref="DeleteTeamResponse"/></returns>
        public DeleteTeamResponse DeleteTeamSync(DeleteTeamRequest req)
        {
            return InternalRequestAsync<DeleteTeamResponse>(req, "DeleteTeam")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a team member
        /// </summary>
        /// <param name="req"><see cref="DeleteTeamMemberRequest"/></param>
        /// <returns><see cref="DeleteTeamMemberResponse"/></returns>
        public Task<DeleteTeamMemberResponse> DeleteTeamMember(DeleteTeamMemberRequest req)
        {
            return InternalRequestAsync<DeleteTeamMemberResponse>(req, "DeleteTeamMember");
        }

        /// <summary>
        /// This API is used to delete a team member
        /// </summary>
        /// <param name="req"><see cref="DeleteTeamMemberRequest"/></param>
        /// <returns><see cref="DeleteTeamMemberResponse"/></returns>
        public DeleteTeamMemberResponse DeleteTeamMemberSync(DeleteTeamMemberRequest req)
        {
            return InternalRequestAsync<DeleteTeamMemberResponse>(req, "DeleteTeamMember")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a user
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRequest"/></param>
        /// <returns><see cref="DeleteUserResponse"/></returns>
        public Task<DeleteUserResponse> DeleteUser(DeleteUserRequest req)
        {
            return InternalRequestAsync<DeleteUserResponse>(req, "DeleteUser");
        }

        /// <summary>
        /// This API is used to delete a user
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRequest"/></param>
        /// <returns><see cref="DeleteUserResponse"/></returns>
        public DeleteUserResponse DeleteUserSync(DeleteUserRequest req)
        {
            return InternalRequestAsync<DeleteUserResponse>(req, "DeleteUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query details of an application. 
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationRequest"/></param>
        /// <returns><see cref="DescribeApplicationResponse"/></returns>
        public Task<DescribeApplicationResponse> DescribeApplication(DescribeApplicationRequest req)
        {
            return InternalRequestAsync<DescribeApplicationResponse>(req, "DescribeApplication");
        }

        /// <summary>
        /// This API is used to query details of an application. 
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationRequest"/></param>
        /// <returns><see cref="DescribeApplicationResponse"/></returns>
        public DescribeApplicationResponse DescribeApplicationSync(DescribeApplicationRequest req)
        {
            return InternalRequestAsync<DescribeApplicationResponse>(req, "DescribeApplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query application configuration information
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationConfigRequest"/></param>
        /// <returns><see cref="DescribeApplicationConfigResponse"/></returns>
        public Task<DescribeApplicationConfigResponse> DescribeApplicationConfig(DescribeApplicationConfigRequest req)
        {
            return InternalRequestAsync<DescribeApplicationConfigResponse>(req, "DescribeApplicationConfig");
        }

        /// <summary>
        /// This API is used to query application configuration information
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationConfigRequest"/></param>
        /// <returns><see cref="DescribeApplicationConfigResponse"/></returns>
        public DescribeApplicationConfigResponse DescribeApplicationConfigSync(DescribeApplicationConfigRequest req)
        {
            return InternalRequestAsync<DescribeApplicationConfigResponse>(req, "DescribeApplicationConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the configuration files of an application.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationConfigFileRequest"/></param>
        /// <returns><see cref="DescribeApplicationConfigFileResponse"/></returns>
        public Task<DescribeApplicationConfigFileResponse> DescribeApplicationConfigFile(DescribeApplicationConfigFileRequest req)
        {
            return InternalRequestAsync<DescribeApplicationConfigFileResponse>(req, "DescribeApplicationConfigFile");
        }

        /// <summary>
        /// This API is used to query the configuration files of an application.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationConfigFileRequest"/></param>
        /// <returns><see cref="DescribeApplicationConfigFileResponse"/></returns>
        public DescribeApplicationConfigFileResponse DescribeApplicationConfigFileSync(DescribeApplicationConfigFileRequest req)
        {
            return InternalRequestAsync<DescribeApplicationConfigFileResponse>(req, "DescribeApplicationConfigFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of application. 
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationListRequest"/></param>
        /// <returns><see cref="DescribeApplicationListResponse"/></returns>
        public Task<DescribeApplicationListResponse> DescribeApplicationList(DescribeApplicationListRequest req)
        {
            return InternalRequestAsync<DescribeApplicationListResponse>(req, "DescribeApplicationList");
        }

        /// <summary>
        /// This API is used to query the list of application. 
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationListRequest"/></param>
        /// <returns><see cref="DescribeApplicationListResponse"/></returns>
        public DescribeApplicationListResponse DescribeApplicationListSync(DescribeApplicationListRequest req)
        {
            return InternalRequestAsync<DescribeApplicationListResponse>(req, "DescribeApplicationList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the approval list of the mini program versions
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationMNPVersionAuditListRequest"/></param>
        /// <returns><see cref="DescribeApplicationMNPVersionAuditListResponse"/></returns>
        public Task<DescribeApplicationMNPVersionAuditListResponse> DescribeApplicationMNPVersionAuditList(DescribeApplicationMNPVersionAuditListRequest req)
        {
            return InternalRequestAsync<DescribeApplicationMNPVersionAuditListResponse>(req, "DescribeApplicationMNPVersionAuditList");
        }

        /// <summary>
        /// This API is used to query the approval list of the mini program versions
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationMNPVersionAuditListRequest"/></param>
        /// <returns><see cref="DescribeApplicationMNPVersionAuditListResponse"/></returns>
        public DescribeApplicationMNPVersionAuditListResponse DescribeApplicationMNPVersionAuditListSync(DescribeApplicationMNPVersionAuditListRequest req)
        {
            return InternalRequestAsync<DescribeApplicationMNPVersionAuditListResponse>(req, "DescribeApplicationMNPVersionAuditList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to list sensitive APIs of an application. 
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationSensitiveAPIListRequest"/></param>
        /// <returns><see cref="DescribeApplicationSensitiveAPIListResponse"/></returns>
        public Task<DescribeApplicationSensitiveAPIListResponse> DescribeApplicationSensitiveAPIList(DescribeApplicationSensitiveAPIListRequest req)
        {
            return InternalRequestAsync<DescribeApplicationSensitiveAPIListResponse>(req, "DescribeApplicationSensitiveAPIList");
        }

        /// <summary>
        /// This API is used to list sensitive APIs of an application. 
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationSensitiveAPIListRequest"/></param>
        /// <returns><see cref="DescribeApplicationSensitiveAPIListResponse"/></returns>
        public DescribeApplicationSensitiveAPIListResponse DescribeApplicationSensitiveAPIListSync(DescribeApplicationSensitiveAPIListRequest req)
        {
            return InternalRequestAsync<DescribeApplicationSensitiveAPIListResponse>(req, "DescribeApplicationSensitiveAPIList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query if the mini program version is created successfully
        /// </summary>
        /// <param name="req"><see cref="DescribeConsoleMNPVersionCompileTaskRequest"/></param>
        /// <returns><see cref="DescribeConsoleMNPVersionCompileTaskResponse"/></returns>
        public Task<DescribeConsoleMNPVersionCompileTaskResponse> DescribeConsoleMNPVersionCompileTask(DescribeConsoleMNPVersionCompileTaskRequest req)
        {
            return InternalRequestAsync<DescribeConsoleMNPVersionCompileTaskResponse>(req, "DescribeConsoleMNPVersionCompileTask");
        }

        /// <summary>
        /// This API is used to query if the mini program version is created successfully
        /// </summary>
        /// <param name="req"><see cref="DescribeConsoleMNPVersionCompileTaskRequest"/></param>
        /// <returns><see cref="DescribeConsoleMNPVersionCompileTaskResponse"/></returns>
        public DescribeConsoleMNPVersionCompileTaskResponse DescribeConsoleMNPVersionCompileTaskSync(DescribeConsoleMNPVersionCompileTaskRequest req)
        {
            return InternalRequestAsync<DescribeConsoleMNPVersionCompileTaskResponse>(req, "DescribeConsoleMNPVersionCompileTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the domain name list configured for the mini program
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainInfoRequest"/></param>
        /// <returns><see cref="DescribeDomainInfoResponse"/></returns>
        public Task<DescribeDomainInfoResponse> DescribeDomainInfo(DescribeDomainInfoRequest req)
        {
            return InternalRequestAsync<DescribeDomainInfoResponse>(req, "DescribeDomainInfo");
        }

        /// <summary>
        /// This API is used to query the domain name list configured for the mini program
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainInfoRequest"/></param>
        /// <returns><see cref="DescribeDomainInfoResponse"/></returns>
        public DescribeDomainInfoResponse DescribeDomainInfoSync(DescribeDomainInfoRequest req)
        {
            return InternalRequestAsync<DescribeDomainInfoResponse>(req, "DescribeDomainInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of teams with domains that obtained the ICP filing
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainTeamListRequest"/></param>
        /// <returns><see cref="DescribeDomainTeamListResponse"/></returns>
        public Task<DescribeDomainTeamListResponse> DescribeDomainTeamList(DescribeDomainTeamListRequest req)
        {
            return InternalRequestAsync<DescribeDomainTeamListResponse>(req, "DescribeDomainTeamList");
        }

        /// <summary>
        /// This API is used to query the list of teams with domains that obtained the ICP filing
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainTeamListRequest"/></param>
        /// <returns><see cref="DescribeDomainTeamListResponse"/></returns>
        public DescribeDomainTeamListResponse DescribeDomainTeamListSync(DescribeDomainTeamListRequest req)
        {
            return InternalRequestAsync<DescribeDomainTeamListResponse>(req, "DescribeDomainTeamList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the global domain allowlist and blocklist.
        /// </summary>
        /// <param name="req"><see cref="DescribeGlobalDomainACLRequest"/></param>
        /// <returns><see cref="DescribeGlobalDomainACLResponse"/></returns>
        public Task<DescribeGlobalDomainACLResponse> DescribeGlobalDomainACL(DescribeGlobalDomainACLRequest req)
        {
            return InternalRequestAsync<DescribeGlobalDomainACLResponse>(req, "DescribeGlobalDomainACL");
        }

        /// <summary>
        /// This API is used to query the global domain allowlist and blocklist.
        /// </summary>
        /// <param name="req"><see cref="DescribeGlobalDomainACLRequest"/></param>
        /// <returns><see cref="DescribeGlobalDomainACLResponse"/></returns>
        public DescribeGlobalDomainACLResponse DescribeGlobalDomainACLSync(DescribeGlobalDomainACLRequest req)
        {
            return InternalRequestAsync<DescribeGlobalDomainACLResponse>(req, "DescribeGlobalDomainACL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query domain allowlist and blocklist
        /// </summary>
        /// <param name="req"><see cref="DescribeGlobalDomainListRequest"/></param>
        /// <returns><see cref="DescribeGlobalDomainListResponse"/></returns>
        public Task<DescribeGlobalDomainListResponse> DescribeGlobalDomainList(DescribeGlobalDomainListRequest req)
        {
            return InternalRequestAsync<DescribeGlobalDomainListResponse>(req, "DescribeGlobalDomainList");
        }

        /// <summary>
        /// This API is used to query domain allowlist and blocklist
        /// </summary>
        /// <param name="req"><see cref="DescribeGlobalDomainListRequest"/></param>
        /// <returns><see cref="DescribeGlobalDomainListResponse"/></returns>
        public DescribeGlobalDomainListResponse DescribeGlobalDomainListSync(DescribeGlobalDomainListRequest req)
        {
            return InternalRequestAsync<DescribeGlobalDomainListResponse>(req, "DescribeGlobalDomainList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query details of a mini program. 
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPRequest"/></param>
        /// <returns><see cref="DescribeMNPResponse"/></returns>
        public Task<DescribeMNPResponse> DescribeMNP(DescribeMNPRequest req)
        {
            return InternalRequestAsync<DescribeMNPResponse>(req, "DescribeMNP");
        }

        /// <summary>
        /// This API is used to query details of a mini program. 
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPRequest"/></param>
        /// <returns><see cref="DescribeMNPResponse"/></returns>
        public DescribeMNPResponse DescribeMNPSync(DescribeMNPRequest req)
        {
            return InternalRequestAsync<DescribeMNPResponse>(req, "DescribeMNP")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the mini program version management information
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPAllStageVersionsRequest"/></param>
        /// <returns><see cref="DescribeMNPAllStageVersionsResponse"/></returns>
        public Task<DescribeMNPAllStageVersionsResponse> DescribeMNPAllStageVersions(DescribeMNPAllStageVersionsRequest req)
        {
            return InternalRequestAsync<DescribeMNPAllStageVersionsResponse>(req, "DescribeMNPAllStageVersions");
        }

        /// <summary>
        /// This API is used to query the mini program version management information
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPAllStageVersionsRequest"/></param>
        /// <returns><see cref="DescribeMNPAllStageVersionsResponse"/></returns>
        public DescribeMNPAllStageVersionsResponse DescribeMNPAllStageVersionsSync(DescribeMNPAllStageVersionsRequest req)
        {
            return InternalRequestAsync<DescribeMNPAllStageVersionsResponse>(req, "DescribeMNPAllStageVersions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to list the approval requests related with a mini program version.
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPApprovalListRequest"/></param>
        /// <returns><see cref="DescribeMNPApprovalListResponse"/></returns>
        public Task<DescribeMNPApprovalListResponse> DescribeMNPApprovalList(DescribeMNPApprovalListRequest req)
        {
            return InternalRequestAsync<DescribeMNPApprovalListResponse>(req, "DescribeMNPApprovalList");
        }

        /// <summary>
        /// This API is used to list the approval requests related with a mini program version.
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPApprovalListRequest"/></param>
        /// <returns><see cref="DescribeMNPApprovalListResponse"/></returns>
        public DescribeMNPApprovalListResponse DescribeMNPApprovalListSync(DescribeMNPApprovalListRequest req)
        {
            return InternalRequestAsync<DescribeMNPApprovalListResponse>(req, "DescribeMNPApprovalList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the mini program version management information
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPBoardRequest"/></param>
        /// <returns><see cref="DescribeMNPBoardResponse"/></returns>
        public Task<DescribeMNPBoardResponse> DescribeMNPBoard(DescribeMNPBoardRequest req)
        {
            return InternalRequestAsync<DescribeMNPBoardResponse>(req, "DescribeMNPBoard");
        }

        /// <summary>
        /// This API is used to query the mini program version management information
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPBoardRequest"/></param>
        /// <returns><see cref="DescribeMNPBoardResponse"/></returns>
        public DescribeMNPBoardResponse DescribeMNPBoardSync(DescribeMNPBoardRequest req)
        {
            return InternalRequestAsync<DescribeMNPBoardResponse>(req, "DescribeMNPBoard")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of mini program types.
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPCategoryRequest"/></param>
        /// <returns><see cref="DescribeMNPCategoryResponse"/></returns>
        public Task<DescribeMNPCategoryResponse> DescribeMNPCategory(DescribeMNPCategoryRequest req)
        {
            return InternalRequestAsync<DescribeMNPCategoryResponse>(req, "DescribeMNPCategory");
        }

        /// <summary>
        /// This API is used to query the list of mini program types.
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPCategoryRequest"/></param>
        /// <returns><see cref="DescribeMNPCategoryResponse"/></returns>
        public DescribeMNPCategoryResponse DescribeMNPCategorySync(DescribeMNPCategoryRequest req)
        {
            return InternalRequestAsync<DescribeMNPCategoryResponse>(req, "DescribeMNPCategory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query mini program details
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPDetailRequest"/></param>
        /// <returns><see cref="DescribeMNPDetailResponse"/></returns>
        public Task<DescribeMNPDetailResponse> DescribeMNPDetail(DescribeMNPDetailRequest req)
        {
            return InternalRequestAsync<DescribeMNPDetailResponse>(req, "DescribeMNPDetail");
        }

        /// <summary>
        /// This API is used to query mini program details
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPDetailRequest"/></param>
        /// <returns><see cref="DescribeMNPDetailResponse"/></returns>
        public DescribeMNPDetailResponse DescribeMNPDetailSync(DescribeMNPDetailRequest req)
        {
            return InternalRequestAsync<DescribeMNPDetailResponse>(req, "DescribeMNPDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the domain name allowlist / blocklist of a mini program. 
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPDomainACLRequest"/></param>
        /// <returns><see cref="DescribeMNPDomainACLResponse"/></returns>
        public Task<DescribeMNPDomainACLResponse> DescribeMNPDomainACL(DescribeMNPDomainACLRequest req)
        {
            return InternalRequestAsync<DescribeMNPDomainACLResponse>(req, "DescribeMNPDomainACL");
        }

        /// <summary>
        /// This API is used to query the domain name allowlist / blocklist of a mini program. 
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPDomainACLRequest"/></param>
        /// <returns><see cref="DescribeMNPDomainACLResponse"/></returns>
        public DescribeMNPDomainACLResponse DescribeMNPDomainACLSync(DescribeMNPDomainACLRequest req)
        {
            return InternalRequestAsync<DescribeMNPDomainACLResponse>(req, "DescribeMNPDomainACL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of mini programs.
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPListRequest"/></param>
        /// <returns><see cref="DescribeMNPListResponse"/></returns>
        public Task<DescribeMNPListResponse> DescribeMNPList(DescribeMNPListRequest req)
        {
            return InternalRequestAsync<DescribeMNPListResponse>(req, "DescribeMNPList");
        }

        /// <summary>
        /// This API is used to query the list of mini programs.
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPListRequest"/></param>
        /// <returns><see cref="DescribeMNPListResponse"/></returns>
        public DescribeMNPListResponse DescribeMNPListSync(DescribeMNPListRequest req)
        {
            return InternalRequestAsync<DescribeMNPListResponse>(req, "DescribeMNPList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query mini program details in the mini program list
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPManagerDetailRequest"/></param>
        /// <returns><see cref="DescribeMNPManagerDetailResponse"/></returns>
        public Task<DescribeMNPManagerDetailResponse> DescribeMNPManagerDetail(DescribeMNPManagerDetailRequest req)
        {
            return InternalRequestAsync<DescribeMNPManagerDetailResponse>(req, "DescribeMNPManagerDetail");
        }

        /// <summary>
        /// This API is used to query mini program details in the mini program list
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPManagerDetailRequest"/></param>
        /// <returns><see cref="DescribeMNPManagerDetailResponse"/></returns>
        public DescribeMNPManagerDetailResponse DescribeMNPManagerDetailSync(DescribeMNPManagerDetailRequest req)
        {
            return InternalRequestAsync<DescribeMNPManagerDetailResponse>(req, "DescribeMNPManagerDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the mini program list
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPManagerListRequest"/></param>
        /// <returns><see cref="DescribeMNPManagerListResponse"/></returns>
        public Task<DescribeMNPManagerListResponse> DescribeMNPManagerList(DescribeMNPManagerListRequest req)
        {
            return InternalRequestAsync<DescribeMNPManagerListResponse>(req, "DescribeMNPManagerList");
        }

        /// <summary>
        /// This API is used to query the mini program list
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPManagerListRequest"/></param>
        /// <returns><see cref="DescribeMNPManagerListResponse"/></returns>
        public DescribeMNPManagerListResponse DescribeMNPManagerListSync(DescribeMNPManagerListRequest req)
        {
            return InternalRequestAsync<DescribeMNPManagerListResponse>(req, "DescribeMNPManagerList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeMNPOfflinePackageURL
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPOfflinePackageURLRequest"/></param>
        /// <returns><see cref="DescribeMNPOfflinePackageURLResponse"/></returns>
        public Task<DescribeMNPOfflinePackageURLResponse> DescribeMNPOfflinePackageURL(DescribeMNPOfflinePackageURLRequest req)
        {
            return InternalRequestAsync<DescribeMNPOfflinePackageURLResponse>(req, "DescribeMNPOfflinePackageURL");
        }

        /// <summary>
        /// DescribeMNPOfflinePackageURL
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPOfflinePackageURLRequest"/></param>
        /// <returns><see cref="DescribeMNPOfflinePackageURLResponse"/></returns>
        public DescribeMNPOfflinePackageURLResponse DescribeMNPOfflinePackageURLSync(DescribeMNPOfflinePackageURLRequest req)
        {
            return InternalRequestAsync<DescribeMNPOfflinePackageURLResponse>(req, "DescribeMNPOfflinePackageURL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of a mini program preview version.
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPPreviewRequest"/></param>
        /// <returns><see cref="DescribeMNPPreviewResponse"/></returns>
        public Task<DescribeMNPPreviewResponse> DescribeMNPPreview(DescribeMNPPreviewRequest req)
        {
            return InternalRequestAsync<DescribeMNPPreviewResponse>(req, "DescribeMNPPreview");
        }

        /// <summary>
        /// This API is used to query the details of a mini program preview version.
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPPreviewRequest"/></param>
        /// <returns><see cref="DescribeMNPPreviewResponse"/></returns>
        public DescribeMNPPreviewResponse DescribeMNPPreviewSync(DescribeMNPPreviewRequest req)
        {
            return InternalRequestAsync<DescribeMNPPreviewResponse>(req, "DescribeMNPPreview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details filled in the service description
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPPrivacyRequest"/></param>
        /// <returns><see cref="DescribeMNPPrivacyResponse"/></returns>
        public Task<DescribeMNPPrivacyResponse> DescribeMNPPrivacy(DescribeMNPPrivacyRequest req)
        {
            return InternalRequestAsync<DescribeMNPPrivacyResponse>(req, "DescribeMNPPrivacy");
        }

        /// <summary>
        /// This API is used to query the details filled in the service description
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPPrivacyRequest"/></param>
        /// <returns><see cref="DescribeMNPPrivacyResponse"/></returns>
        public DescribeMNPPrivacyResponse DescribeMNPPrivacySync(DescribeMNPPrivacyRequest req)
        {
            return InternalRequestAsync<DescribeMNPPrivacyResponse>(req, "DescribeMNPPrivacy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to list all released versions of a mini program.
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPReleasedVersionHistoryRequest"/></param>
        /// <returns><see cref="DescribeMNPReleasedVersionHistoryResponse"/></returns>
        public Task<DescribeMNPReleasedVersionHistoryResponse> DescribeMNPReleasedVersionHistory(DescribeMNPReleasedVersionHistoryRequest req)
        {
            return InternalRequestAsync<DescribeMNPReleasedVersionHistoryResponse>(req, "DescribeMNPReleasedVersionHistory");
        }

        /// <summary>
        /// This API is used to list all released versions of a mini program.
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPReleasedVersionHistoryRequest"/></param>
        /// <returns><see cref="DescribeMNPReleasedVersionHistoryResponse"/></returns>
        public DescribeMNPReleasedVersionHistoryResponse DescribeMNPReleasedVersionHistorySync(DescribeMNPReleasedVersionHistoryRequest req)
        {
            return InternalRequestAsync<DescribeMNPReleasedVersionHistoryResponse>(req, "DescribeMNPReleasedVersionHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query details of a specific permission request to call sensitive APIs.
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPSensitiveAPIPermissionApprovalRequest"/></param>
        /// <returns><see cref="DescribeMNPSensitiveAPIPermissionApprovalResponse"/></returns>
        public Task<DescribeMNPSensitiveAPIPermissionApprovalResponse> DescribeMNPSensitiveAPIPermissionApproval(DescribeMNPSensitiveAPIPermissionApprovalRequest req)
        {
            return InternalRequestAsync<DescribeMNPSensitiveAPIPermissionApprovalResponse>(req, "DescribeMNPSensitiveAPIPermissionApproval");
        }

        /// <summary>
        /// This API is used to query details of a specific permission request to call sensitive APIs.
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPSensitiveAPIPermissionApprovalRequest"/></param>
        /// <returns><see cref="DescribeMNPSensitiveAPIPermissionApprovalResponse"/></returns>
        public DescribeMNPSensitiveAPIPermissionApprovalResponse DescribeMNPSensitiveAPIPermissionApprovalSync(DescribeMNPSensitiveAPIPermissionApprovalRequest req)
        {
            return InternalRequestAsync<DescribeMNPSensitiveAPIPermissionApprovalResponse>(req, "DescribeMNPSensitiveAPIPermissionApproval")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query permission requests to allow a mini program calling sensitive APIs.
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPSensitiveAPIPermissionApprovalListRequest"/></param>
        /// <returns><see cref="DescribeMNPSensitiveAPIPermissionApprovalListResponse"/></returns>
        public Task<DescribeMNPSensitiveAPIPermissionApprovalListResponse> DescribeMNPSensitiveAPIPermissionApprovalList(DescribeMNPSensitiveAPIPermissionApprovalListRequest req)
        {
            return InternalRequestAsync<DescribeMNPSensitiveAPIPermissionApprovalListResponse>(req, "DescribeMNPSensitiveAPIPermissionApprovalList");
        }

        /// <summary>
        /// This API is used to query permission requests to allow a mini program calling sensitive APIs.
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPSensitiveAPIPermissionApprovalListRequest"/></param>
        /// <returns><see cref="DescribeMNPSensitiveAPIPermissionApprovalListResponse"/></returns>
        public DescribeMNPSensitiveAPIPermissionApprovalListResponse DescribeMNPSensitiveAPIPermissionApprovalListSync(DescribeMNPSensitiveAPIPermissionApprovalListRequest req)
        {
            return InternalRequestAsync<DescribeMNPSensitiveAPIPermissionApprovalListResponse>(req, "DescribeMNPSensitiveAPIPermissionApprovalList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of sensitive APIs that available to a mini program.
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPSensitiveAPIPermissionListRequest"/></param>
        /// <returns><see cref="DescribeMNPSensitiveAPIPermissionListResponse"/></returns>
        public Task<DescribeMNPSensitiveAPIPermissionListResponse> DescribeMNPSensitiveAPIPermissionList(DescribeMNPSensitiveAPIPermissionListRequest req)
        {
            return InternalRequestAsync<DescribeMNPSensitiveAPIPermissionListResponse>(req, "DescribeMNPSensitiveAPIPermissionList");
        }

        /// <summary>
        /// This API is used to query the list of sensitive APIs that available to a mini program.
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPSensitiveAPIPermissionListRequest"/></param>
        /// <returns><see cref="DescribeMNPSensitiveAPIPermissionListResponse"/></returns>
        public DescribeMNPSensitiveAPIPermissionListResponse DescribeMNPSensitiveAPIPermissionListSync(DescribeMNPSensitiveAPIPermissionListRequest req)
        {
            return InternalRequestAsync<DescribeMNPSensitiveAPIPermissionListResponse>(req, "DescribeMNPSensitiveAPIPermissionList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the mini program type list
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPTypeRequest"/></param>
        /// <returns><see cref="DescribeMNPTypeResponse"/></returns>
        public Task<DescribeMNPTypeResponse> DescribeMNPType(DescribeMNPTypeRequest req)
        {
            return InternalRequestAsync<DescribeMNPTypeResponse>(req, "DescribeMNPType");
        }

        /// <summary>
        /// This API is used to query the mini program type list
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPTypeRequest"/></param>
        /// <returns><see cref="DescribeMNPTypeResponse"/></returns>
        public DescribeMNPTypeResponse DescribeMNPTypeSync(DescribeMNPTypeRequest req)
        {
            return InternalRequestAsync<DescribeMNPTypeResponse>(req, "DescribeMNPType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the result of the task to create a mini program version.
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPVersionRequest"/></param>
        /// <returns><see cref="DescribeMNPVersionResponse"/></returns>
        public Task<DescribeMNPVersionResponse> DescribeMNPVersion(DescribeMNPVersionRequest req)
        {
            return InternalRequestAsync<DescribeMNPVersionResponse>(req, "DescribeMNPVersion");
        }

        /// <summary>
        /// This API is used to query the result of the task to create a mini program version.
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPVersionRequest"/></param>
        /// <returns><see cref="DescribeMNPVersionResponse"/></returns>
        public DescribeMNPVersionResponse DescribeMNPVersionSync(DescribeMNPVersionRequest req)
        {
            return InternalRequestAsync<DescribeMNPVersionResponse>(req, "DescribeMNPVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of the mini program preview version
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPVersionPreviewRequest"/></param>
        /// <returns><see cref="DescribeMNPVersionPreviewResponse"/></returns>
        public Task<DescribeMNPVersionPreviewResponse> DescribeMNPVersionPreview(DescribeMNPVersionPreviewRequest req)
        {
            return InternalRequestAsync<DescribeMNPVersionPreviewResponse>(req, "DescribeMNPVersionPreview");
        }

        /// <summary>
        /// This API is used to query the details of the mini program preview version
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPVersionPreviewRequest"/></param>
        /// <returns><see cref="DescribeMNPVersionPreviewResponse"/></returns>
        public DescribeMNPVersionPreviewResponse DescribeMNPVersionPreviewSync(DescribeMNPVersionPreviewRequest req)
        {
            return InternalRequestAsync<DescribeMNPVersionPreviewResponse>(req, "DescribeMNPVersionPreview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query offline mini program packages
        /// </summary>
        /// <param name="req"><see cref="DescribeOfflineMNPPackageRequest"/></param>
        /// <returns><see cref="DescribeOfflineMNPPackageResponse"/></returns>
        public Task<DescribeOfflineMNPPackageResponse> DescribeOfflineMNPPackage(DescribeOfflineMNPPackageRequest req)
        {
            return InternalRequestAsync<DescribeOfflineMNPPackageResponse>(req, "DescribeOfflineMNPPackage");
        }

        /// <summary>
        /// This API is used to query offline mini program packages
        /// </summary>
        /// <param name="req"><see cref="DescribeOfflineMNPPackageRequest"/></param>
        /// <returns><see cref="DescribeOfflineMNPPackageResponse"/></returns>
        public DescribeOfflineMNPPackageResponse DescribeOfflineMNPPackageSync(DescribeOfflineMNPPackageRequest req)
        {
            return InternalRequestAsync<DescribeOfflineMNPPackageResponse>(req, "DescribeOfflineMNPPackage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the release version history
        /// </summary>
        /// <param name="req"><see cref="DescribeOnlineVersionRequest"/></param>
        /// <returns><see cref="DescribeOnlineVersionResponse"/></returns>
        public Task<DescribeOnlineVersionResponse> DescribeOnlineVersion(DescribeOnlineVersionRequest req)
        {
            return InternalRequestAsync<DescribeOnlineVersionResponse>(req, "DescribeOnlineVersion");
        }

        /// <summary>
        /// This API is used to query the release version history
        /// </summary>
        /// <param name="req"><see cref="DescribeOnlineVersionRequest"/></param>
        /// <returns><see cref="DescribeOnlineVersionResponse"/></returns>
        public DescribeOnlineVersionResponse DescribeOnlineVersionSync(DescribeOnlineVersionRequest req)
        {
            return InternalRequestAsync<DescribeOnlineVersionResponse>(req, "DescribeOnlineVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query role permission information
        /// </summary>
        /// <param name="req"><see cref="DescribeRoleDetailRequest"/></param>
        /// <returns><see cref="DescribeRoleDetailResponse"/></returns>
        public Task<DescribeRoleDetailResponse> DescribeRoleDetail(DescribeRoleDetailRequest req)
        {
            return InternalRequestAsync<DescribeRoleDetailResponse>(req, "DescribeRoleDetail");
        }

        /// <summary>
        /// This API is used to query role permission information
        /// </summary>
        /// <param name="req"><see cref="DescribeRoleDetailRequest"/></param>
        /// <returns><see cref="DescribeRoleDetailResponse"/></returns>
        public DescribeRoleDetailResponse DescribeRoleDetailSync(DescribeRoleDetailRequest req)
        {
            return InternalRequestAsync<DescribeRoleDetailResponse>(req, "DescribeRoleDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of roles. 
        /// </summary>
        /// <param name="req"><see cref="DescribeRoleListRequest"/></param>
        /// <returns><see cref="DescribeRoleListResponse"/></returns>
        public Task<DescribeRoleListResponse> DescribeRoleList(DescribeRoleListRequest req)
        {
            return InternalRequestAsync<DescribeRoleListResponse>(req, "DescribeRoleList");
        }

        /// <summary>
        /// This API is used to query the list of roles. 
        /// </summary>
        /// <param name="req"><see cref="DescribeRoleListRequest"/></param>
        /// <returns><see cref="DescribeRoleListResponse"/></returns>
        public DescribeRoleListResponse DescribeRoleListSync(DescribeRoleListRequest req)
        {
            return InternalRequestAsync<DescribeRoleListResponse>(req, "DescribeRoleList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query sensitive API approval list
        /// </summary>
        /// <param name="req"><see cref="DescribeSensitiveAPIAuditListRequest"/></param>
        /// <returns><see cref="DescribeSensitiveAPIAuditListResponse"/></returns>
        public Task<DescribeSensitiveAPIAuditListResponse> DescribeSensitiveAPIAuditList(DescribeSensitiveAPIAuditListRequest req)
        {
            return InternalRequestAsync<DescribeSensitiveAPIAuditListResponse>(req, "DescribeSensitiveAPIAuditList");
        }

        /// <summary>
        /// This API is used to query sensitive API approval list
        /// </summary>
        /// <param name="req"><see cref="DescribeSensitiveAPIAuditListRequest"/></param>
        /// <returns><see cref="DescribeSensitiveAPIAuditListResponse"/></returns>
        public DescribeSensitiveAPIAuditListResponse DescribeSensitiveAPIAuditListSync(DescribeSensitiveAPIAuditListRequest req)
        {
            return InternalRequestAsync<DescribeSensitiveAPIAuditListResponse>(req, "DescribeSensitiveAPIAuditList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query all sensitive APIs list
        /// </summary>
        /// <param name="req"><see cref="DescribeSensitiveAPIListRequest"/></param>
        /// <returns><see cref="DescribeSensitiveAPIListResponse"/></returns>
        public Task<DescribeSensitiveAPIListResponse> DescribeSensitiveAPIList(DescribeSensitiveAPIListRequest req)
        {
            return InternalRequestAsync<DescribeSensitiveAPIListResponse>(req, "DescribeSensitiveAPIList");
        }

        /// <summary>
        /// This API is used to query all sensitive APIs list
        /// </summary>
        /// <param name="req"><see cref="DescribeSensitiveAPIListRequest"/></param>
        /// <returns><see cref="DescribeSensitiveAPIListResponse"/></returns>
        public DescribeSensitiveAPIListResponse DescribeSensitiveAPIListSync(DescribeSensitiveAPIListRequest req)
        {
            return InternalRequestAsync<DescribeSensitiveAPIListResponse>(req, "DescribeSensitiveAPIList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query sensitive API permission approval details
        /// </summary>
        /// <param name="req"><see cref="DescribeSensitiveApiApplyDetailRequest"/></param>
        /// <returns><see cref="DescribeSensitiveApiApplyDetailResponse"/></returns>
        public Task<DescribeSensitiveApiApplyDetailResponse> DescribeSensitiveApiApplyDetail(DescribeSensitiveApiApplyDetailRequest req)
        {
            return InternalRequestAsync<DescribeSensitiveApiApplyDetailResponse>(req, "DescribeSensitiveApiApplyDetail");
        }

        /// <summary>
        /// This API is used to query sensitive API permission approval details
        /// </summary>
        /// <param name="req"><see cref="DescribeSensitiveApiApplyDetailRequest"/></param>
        /// <returns><see cref="DescribeSensitiveApiApplyDetailResponse"/></returns>
        public DescribeSensitiveApiApplyDetailResponse DescribeSensitiveApiApplyDetailSync(DescribeSensitiveApiApplyDetailRequest req)
        {
            return InternalRequestAsync<DescribeSensitiveApiApplyDetailResponse>(req, "DescribeSensitiveApiApplyDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the sensitive API permission list
        /// </summary>
        /// <param name="req"><see cref="DescribeSensitiveApiAuthListRequest"/></param>
        /// <returns><see cref="DescribeSensitiveApiAuthListResponse"/></returns>
        public Task<DescribeSensitiveApiAuthListResponse> DescribeSensitiveApiAuthList(DescribeSensitiveApiAuthListRequest req)
        {
            return InternalRequestAsync<DescribeSensitiveApiAuthListResponse>(req, "DescribeSensitiveApiAuthList");
        }

        /// <summary>
        /// This API is used to query the sensitive API permission list
        /// </summary>
        /// <param name="req"><see cref="DescribeSensitiveApiAuthListRequest"/></param>
        /// <returns><see cref="DescribeSensitiveApiAuthListResponse"/></returns>
        public DescribeSensitiveApiAuthListResponse DescribeSensitiveApiAuthListSync(DescribeSensitiveApiAuthListRequest req)
        {
            return InternalRequestAsync<DescribeSensitiveApiAuthListResponse>(req, "DescribeSensitiveApiAuthList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query application list information
        /// </summary>
        /// <param name="req"><see cref="DescribeSimpleApplicationInfoListRequest"/></param>
        /// <returns><see cref="DescribeSimpleApplicationInfoListResponse"/></returns>
        public Task<DescribeSimpleApplicationInfoListResponse> DescribeSimpleApplicationInfoList(DescribeSimpleApplicationInfoListRequest req)
        {
            return InternalRequestAsync<DescribeSimpleApplicationInfoListResponse>(req, "DescribeSimpleApplicationInfoList");
        }

        /// <summary>
        /// This API is used to query application list information
        /// </summary>
        /// <param name="req"><see cref="DescribeSimpleApplicationInfoListRequest"/></param>
        /// <returns><see cref="DescribeSimpleApplicationInfoListResponse"/></returns>
        public DescribeSimpleApplicationInfoListResponse DescribeSimpleApplicationInfoListSync(DescribeSimpleApplicationInfoListRequest req)
        {
            return InternalRequestAsync<DescribeSimpleApplicationInfoListResponse>(req, "DescribeSimpleApplicationInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the team information list
        /// </summary>
        /// <param name="req"><see cref="DescribeSimpleTeamListRequest"/></param>
        /// <returns><see cref="DescribeSimpleTeamListResponse"/></returns>
        public Task<DescribeSimpleTeamListResponse> DescribeSimpleTeamList(DescribeSimpleTeamListRequest req)
        {
            return InternalRequestAsync<DescribeSimpleTeamListResponse>(req, "DescribeSimpleTeamList");
        }

        /// <summary>
        /// This API is used to query the team information list
        /// </summary>
        /// <param name="req"><see cref="DescribeSimpleTeamListRequest"/></param>
        /// <returns><see cref="DescribeSimpleTeamListResponse"/></returns>
        public DescribeSimpleTeamListResponse DescribeSimpleTeamListSync(DescribeSimpleTeamListRequest req)
        {
            return InternalRequestAsync<DescribeSimpleTeamListResponse>(req, "DescribeSimpleTeamList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query details of a team. 
        /// </summary>
        /// <param name="req"><see cref="DescribeTeamRequest"/></param>
        /// <returns><see cref="DescribeTeamResponse"/></returns>
        public Task<DescribeTeamResponse> DescribeTeam(DescribeTeamRequest req)
        {
            return InternalRequestAsync<DescribeTeamResponse>(req, "DescribeTeam");
        }

        /// <summary>
        /// This API is used to query details of a team. 
        /// </summary>
        /// <param name="req"><see cref="DescribeTeamRequest"/></param>
        /// <returns><see cref="DescribeTeamResponse"/></returns>
        public DescribeTeamResponse DescribeTeamSync(DescribeTeamRequest req)
        {
            return InternalRequestAsync<DescribeTeamResponse>(req, "DescribeTeam")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query a specified team’s domains that obtained ICP filing
        /// </summary>
        /// <param name="req"><see cref="DescribeTeamDomainListRequest"/></param>
        /// <returns><see cref="DescribeTeamDomainListResponse"/></returns>
        public Task<DescribeTeamDomainListResponse> DescribeTeamDomainList(DescribeTeamDomainListRequest req)
        {
            return InternalRequestAsync<DescribeTeamDomainListResponse>(req, "DescribeTeamDomainList");
        }

        /// <summary>
        /// This API is used to query a specified team’s domains that obtained ICP filing
        /// </summary>
        /// <param name="req"><see cref="DescribeTeamDomainListRequest"/></param>
        /// <returns><see cref="DescribeTeamDomainListResponse"/></returns>
        public DescribeTeamDomainListResponse DescribeTeamDomainListSync(DescribeTeamDomainListRequest req)
        {
            return InternalRequestAsync<DescribeTeamDomainListResponse>(req, "DescribeTeamDomainList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of teams. 
        /// </summary>
        /// <param name="req"><see cref="DescribeTeamListRequest"/></param>
        /// <returns><see cref="DescribeTeamListResponse"/></returns>
        public Task<DescribeTeamListResponse> DescribeTeamList(DescribeTeamListRequest req)
        {
            return InternalRequestAsync<DescribeTeamListResponse>(req, "DescribeTeamList");
        }

        /// <summary>
        /// This API is used to query the list of teams. 
        /// </summary>
        /// <param name="req"><see cref="DescribeTeamListRequest"/></param>
        /// <returns><see cref="DescribeTeamListResponse"/></returns>
        public DescribeTeamListResponse DescribeTeamListSync(DescribeTeamListRequest req)
        {
            return InternalRequestAsync<DescribeTeamListResponse>(req, "DescribeTeamList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query team member list
        /// </summary>
        /// <param name="req"><see cref="DescribeTeamMemberListRequest"/></param>
        /// <returns><see cref="DescribeTeamMemberListResponse"/></returns>
        public Task<DescribeTeamMemberListResponse> DescribeTeamMemberList(DescribeTeamMemberListRequest req)
        {
            return InternalRequestAsync<DescribeTeamMemberListResponse>(req, "DescribeTeamMemberList");
        }

        /// <summary>
        /// This API is used to query team member list
        /// </summary>
        /// <param name="req"><see cref="DescribeTeamMemberListRequest"/></param>
        /// <returns><see cref="DescribeTeamMemberListResponse"/></returns>
        public DescribeTeamMemberListResponse DescribeTeamMemberListSync(DescribeTeamMemberListRequest req)
        {
            return InternalRequestAsync<DescribeTeamMemberListResponse>(req, "DescribeTeamMemberList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the member list of a specified team
        /// </summary>
        /// <param name="req"><see cref="DescribeTeamMembersRequest"/></param>
        /// <returns><see cref="DescribeTeamMembersResponse"/></returns>
        public Task<DescribeTeamMembersResponse> DescribeTeamMembers(DescribeTeamMembersRequest req)
        {
            return InternalRequestAsync<DescribeTeamMembersResponse>(req, "DescribeTeamMembers");
        }

        /// <summary>
        /// This API is used to query the member list of a specified team
        /// </summary>
        /// <param name="req"><see cref="DescribeTeamMembersRequest"/></param>
        /// <returns><see cref="DescribeTeamMembersResponse"/></returns>
        public DescribeTeamMembersResponse DescribeTeamMembersSync(DescribeTeamMembersRequest req)
        {
            return InternalRequestAsync<DescribeTeamMembersResponse>(req, "DescribeTeamMembers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain a temporary key for file uploads
        /// </summary>
        /// <param name="req"><see cref="DescribeTempSecret4UploadFile2CosRequest"/></param>
        /// <returns><see cref="DescribeTempSecret4UploadFile2CosResponse"/></returns>
        public Task<DescribeTempSecret4UploadFile2CosResponse> DescribeTempSecret4UploadFile2Cos(DescribeTempSecret4UploadFile2CosRequest req)
        {
            return InternalRequestAsync<DescribeTempSecret4UploadFile2CosResponse>(req, "DescribeTempSecret4UploadFile2Cos");
        }

        /// <summary>
        /// This API is used to obtain a temporary key for file uploads
        /// </summary>
        /// <param name="req"><see cref="DescribeTempSecret4UploadFile2CosRequest"/></param>
        /// <returns><see cref="DescribeTempSecret4UploadFile2CosResponse"/></returns>
        public DescribeTempSecret4UploadFile2CosResponse DescribeTempSecret4UploadFile2CosSync(DescribeTempSecret4UploadFile2CosRequest req)
        {
            return InternalRequestAsync<DescribeTempSecret4UploadFile2CosResponse>(req, "DescribeTempSecret4UploadFile2Cos")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query details of a user. 
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRequest"/></param>
        /// <returns><see cref="DescribeUserResponse"/></returns>
        public Task<DescribeUserResponse> DescribeUser(DescribeUserRequest req)
        {
            return InternalRequestAsync<DescribeUserResponse>(req, "DescribeUser");
        }

        /// <summary>
        /// This API is used to query details of a user. 
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRequest"/></param>
        /// <returns><see cref="DescribeUserResponse"/></returns>
        public DescribeUserResponse DescribeUserSync(DescribeUserRequest req)
        {
            return InternalRequestAsync<DescribeUserResponse>(req, "DescribeUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query user details
        /// </summary>
        /// <param name="req"><see cref="DescribeUserDetailRequest"/></param>
        /// <returns><see cref="DescribeUserDetailResponse"/></returns>
        public Task<DescribeUserDetailResponse> DescribeUserDetail(DescribeUserDetailRequest req)
        {
            return InternalRequestAsync<DescribeUserDetailResponse>(req, "DescribeUserDetail");
        }

        /// <summary>
        /// This API is used to query user details
        /// </summary>
        /// <param name="req"><see cref="DescribeUserDetailRequest"/></param>
        /// <returns><see cref="DescribeUserDetailResponse"/></returns>
        public DescribeUserDetailResponse DescribeUserDetailSync(DescribeUserDetailRequest req)
        {
            return InternalRequestAsync<DescribeUserDetailResponse>(req, "DescribeUserDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the user list
        /// </summary>
        /// <param name="req"><see cref="DescribeUserListRequest"/></param>
        /// <returns><see cref="DescribeUserListResponse"/></returns>
        public Task<DescribeUserListResponse> DescribeUserList(DescribeUserListRequest req)
        {
            return InternalRequestAsync<DescribeUserListResponse>(req, "DescribeUserList");
        }

        /// <summary>
        /// This API is used to query the user list
        /// </summary>
        /// <param name="req"><see cref="DescribeUserListRequest"/></param>
        /// <returns><see cref="DescribeUserListResponse"/></returns>
        public DescribeUserListResponse DescribeUserListSync(DescribeUserListRequest req)
        {
            return InternalRequestAsync<DescribeUserListResponse>(req, "DescribeUserList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set a sensitive API to Restricted.
        /// </summary>
        /// <param name="req"><see cref="DisableApplicationSensitiveAPIRequest"/></param>
        /// <returns><see cref="DisableApplicationSensitiveAPIResponse"/></returns>
        public Task<DisableApplicationSensitiveAPIResponse> DisableApplicationSensitiveAPI(DisableApplicationSensitiveAPIRequest req)
        {
            return InternalRequestAsync<DisableApplicationSensitiveAPIResponse>(req, "DisableApplicationSensitiveAPI");
        }

        /// <summary>
        /// This API is used to set a sensitive API to Restricted.
        /// </summary>
        /// <param name="req"><see cref="DisableApplicationSensitiveAPIRequest"/></param>
        /// <returns><see cref="DisableApplicationSensitiveAPIResponse"/></returns>
        public DisableApplicationSensitiveAPIResponse DisableApplicationSensitiveAPISync(DisableApplicationSensitiveAPIRequest req)
        {
            return InternalRequestAsync<DisableApplicationSensitiveAPIResponse>(req, "DisableApplicationSensitiveAPI")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable the company’s domain name that obtained the ICP filing
        /// </summary>
        /// <param name="req"><see cref="DisableTeamDomainRequest"/></param>
        /// <returns><see cref="DisableTeamDomainResponse"/></returns>
        public Task<DisableTeamDomainResponse> DisableTeamDomain(DisableTeamDomainRequest req)
        {
            return InternalRequestAsync<DisableTeamDomainResponse>(req, "DisableTeamDomain");
        }

        /// <summary>
        /// This API is used to disable the company’s domain name that obtained the ICP filing
        /// </summary>
        /// <param name="req"><see cref="DisableTeamDomainRequest"/></param>
        /// <returns><see cref="DisableTeamDomainResponse"/></returns>
        public DisableTeamDomainResponse DisableTeamDomainSync(DisableTeamDomainRequest req)
        {
            return InternalRequestAsync<DisableTeamDomainResponse>(req, "DisableTeamDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set an application sensitive API to public.
        /// </summary>
        /// <param name="req"><see cref="EnableApplicationSensitiveAPIRequest"/></param>
        /// <returns><see cref="EnableApplicationSensitiveAPIResponse"/></returns>
        public Task<EnableApplicationSensitiveAPIResponse> EnableApplicationSensitiveAPI(EnableApplicationSensitiveAPIRequest req)
        {
            return InternalRequestAsync<EnableApplicationSensitiveAPIResponse>(req, "EnableApplicationSensitiveAPI");
        }

        /// <summary>
        /// This API is used to set an application sensitive API to public.
        /// </summary>
        /// <param name="req"><see cref="EnableApplicationSensitiveAPIRequest"/></param>
        /// <returns><see cref="EnableApplicationSensitiveAPIResponse"/></returns>
        public EnableApplicationSensitiveAPIResponse EnableApplicationSensitiveAPISync(EnableApplicationSensitiveAPIRequest req)
        {
            return InternalRequestAsync<EnableApplicationSensitiveAPIResponse>(req, "EnableApplicationSensitiveAPI")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to change application information
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationRequest"/></param>
        /// <returns><see cref="ModifyApplicationResponse"/></returns>
        public Task<ModifyApplicationResponse> ModifyApplication(ModifyApplicationRequest req)
        {
            return InternalRequestAsync<ModifyApplicationResponse>(req, "ModifyApplication");
        }

        /// <summary>
        /// This API is used to change application information
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationRequest"/></param>
        /// <returns><see cref="ModifyApplicationResponse"/></returns>
        public ModifyApplicationResponse ModifyApplicationSync(ModifyApplicationRequest req)
        {
            return InternalRequestAsync<ModifyApplicationResponse>(req, "ModifyApplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the application package name
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationAppKeyRequest"/></param>
        /// <returns><see cref="ModifyApplicationAppKeyResponse"/></returns>
        public Task<ModifyApplicationAppKeyResponse> ModifyApplicationAppKey(ModifyApplicationAppKeyRequest req)
        {
            return InternalRequestAsync<ModifyApplicationAppKeyResponse>(req, "ModifyApplicationAppKey");
        }

        /// <summary>
        /// This API is used to modify the application package name
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationAppKeyRequest"/></param>
        /// <returns><see cref="ModifyApplicationAppKeyResponse"/></returns>
        public ModifyApplicationAppKeyResponse ModifyApplicationAppKeySync(ModifyApplicationAppKeyRequest req)
        {
            return InternalRequestAsync<ModifyApplicationAppKeyResponse>(req, "ModifyApplicationAppKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to change the app download address
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationAppUrlRequest"/></param>
        /// <returns><see cref="ModifyApplicationAppUrlResponse"/></returns>
        public Task<ModifyApplicationAppUrlResponse> ModifyApplicationAppUrl(ModifyApplicationAppUrlRequest req)
        {
            return InternalRequestAsync<ModifyApplicationAppUrlResponse>(req, "ModifyApplicationAppUrl");
        }

        /// <summary>
        /// This API is used to change the app download address
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationAppUrlRequest"/></param>
        /// <returns><see cref="ModifyApplicationAppUrlResponse"/></returns>
        public ModifyApplicationAppUrlResponse ModifyApplicationAppUrlSync(ModifyApplicationAppUrlRequest req)
        {
            return InternalRequestAsync<ModifyApplicationAppUrlResponse>(req, "ModifyApplicationAppUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to edit the mini program domain information
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainRequest"/></param>
        /// <returns><see cref="ModifyDomainResponse"/></returns>
        public Task<ModifyDomainResponse> ModifyDomain(ModifyDomainRequest req)
        {
            return InternalRequestAsync<ModifyDomainResponse>(req, "ModifyDomain");
        }

        /// <summary>
        /// This API is used to edit the mini program domain information
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainRequest"/></param>
        /// <returns><see cref="ModifyDomainResponse"/></returns>
        public ModifyDomainResponse ModifyDomainSync(ModifyDomainRequest req)
        {
            return InternalRequestAsync<ModifyDomainResponse>(req, "ModifyDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify domain allowlist or blocklist
        /// </summary>
        /// <param name="req"><see cref="ModifyGlobalDomainRequest"/></param>
        /// <returns><see cref="ModifyGlobalDomainResponse"/></returns>
        public Task<ModifyGlobalDomainResponse> ModifyGlobalDomain(ModifyGlobalDomainRequest req)
        {
            return InternalRequestAsync<ModifyGlobalDomainResponse>(req, "ModifyGlobalDomain");
        }

        /// <summary>
        /// This API is used to modify domain allowlist or blocklist
        /// </summary>
        /// <param name="req"><see cref="ModifyGlobalDomainRequest"/></param>
        /// <returns><see cref="ModifyGlobalDomainResponse"/></returns>
        public ModifyGlobalDomainResponse ModifyGlobalDomainSync(ModifyGlobalDomainRequest req)
        {
            return InternalRequestAsync<ModifyGlobalDomainResponse>(req, "ModifyGlobalDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify mini program information
        /// </summary>
        /// <param name="req"><see cref="ModifyMNPRequest"/></param>
        /// <returns><see cref="ModifyMNPResponse"/></returns>
        public Task<ModifyMNPResponse> ModifyMNP(ModifyMNPRequest req)
        {
            return InternalRequestAsync<ModifyMNPResponse>(req, "ModifyMNP");
        }

        /// <summary>
        /// This API is used to modify mini program information
        /// </summary>
        /// <param name="req"><see cref="ModifyMNPRequest"/></param>
        /// <returns><see cref="ModifyMNPResponse"/></returns>
        public ModifyMNPResponse ModifyMNPSync(ModifyMNPRequest req)
        {
            return InternalRequestAsync<ModifyMNPResponse>(req, "ModifyMNP")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to edit the mini program domain information.
        /// </summary>
        /// <param name="req"><see cref="ModifyMNPDomainRequest"/></param>
        /// <returns><see cref="ModifyMNPDomainResponse"/></returns>
        public Task<ModifyMNPDomainResponse> ModifyMNPDomain(ModifyMNPDomainRequest req)
        {
            return InternalRequestAsync<ModifyMNPDomainResponse>(req, "ModifyMNPDomain");
        }

        /// <summary>
        /// This API is used to edit the mini program domain information.
        /// </summary>
        /// <param name="req"><see cref="ModifyMNPDomainRequest"/></param>
        /// <returns><see cref="ModifyMNPDomainResponse"/></returns>
        public ModifyMNPDomainResponse ModifyMNPDomainSync(ModifyMNPDomainRequest req)
        {
            return InternalRequestAsync<ModifyMNPDomainResponse>(req, "ModifyMNPDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to remove the mini program
        /// </summary>
        /// <param name="req"><see cref="ModifyMNPStatusOfflineRequest"/></param>
        /// <returns><see cref="ModifyMNPStatusOfflineResponse"/></returns>
        public Task<ModifyMNPStatusOfflineResponse> ModifyMNPStatusOffline(ModifyMNPStatusOfflineRequest req)
        {
            return InternalRequestAsync<ModifyMNPStatusOfflineResponse>(req, "ModifyMNPStatusOffline");
        }

        /// <summary>
        /// This API is used to remove the mini program
        /// </summary>
        /// <param name="req"><see cref="ModifyMNPStatusOfflineRequest"/></param>
        /// <returns><see cref="ModifyMNPStatusOfflineResponse"/></returns>
        public ModifyMNPStatusOfflineResponse ModifyMNPStatusOfflineSync(ModifyMNPStatusOfflineRequest req)
        {
            return InternalRequestAsync<ModifyMNPStatusOfflineResponse>(req, "ModifyMNPStatusOffline")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to configure the mini program preview version
        /// </summary>
        /// <param name="req"><see cref="ModifyMNPVersionPreviewRequest"/></param>
        /// <returns><see cref="ModifyMNPVersionPreviewResponse"/></returns>
        public Task<ModifyMNPVersionPreviewResponse> ModifyMNPVersionPreview(ModifyMNPVersionPreviewRequest req)
        {
            return InternalRequestAsync<ModifyMNPVersionPreviewResponse>(req, "ModifyMNPVersionPreview");
        }

        /// <summary>
        /// This API is used to configure the mini program preview version
        /// </summary>
        /// <param name="req"><see cref="ModifyMNPVersionPreviewRequest"/></param>
        /// <returns><see cref="ModifyMNPVersionPreviewResponse"/></returns>
        public ModifyMNPVersionPreviewResponse ModifyMNPVersionPreviewSync(ModifyMNPVersionPreviewRequest req)
        {
            return InternalRequestAsync<ModifyMNPVersionPreviewResponse>(req, "ModifyMNPVersionPreview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to rollback a mini program release version
        /// </summary>
        /// <param name="req"><see cref="ModifyOnlineVersionRequest"/></param>
        /// <returns><see cref="ModifyOnlineVersionResponse"/></returns>
        public Task<ModifyOnlineVersionResponse> ModifyOnlineVersion(ModifyOnlineVersionRequest req)
        {
            return InternalRequestAsync<ModifyOnlineVersionResponse>(req, "ModifyOnlineVersion");
        }

        /// <summary>
        /// This API is used to rollback a mini program release version
        /// </summary>
        /// <param name="req"><see cref="ModifyOnlineVersionRequest"/></param>
        /// <returns><see cref="ModifyOnlineVersionResponse"/></returns>
        public ModifyOnlineVersionResponse ModifyOnlineVersionSync(ModifyOnlineVersionRequest req)
        {
            return InternalRequestAsync<ModifyOnlineVersionResponse>(req, "ModifyOnlineVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to approve or reject the release of the mini program version
        /// </summary>
        /// <param name="req"><see cref="ModifyPlatformAuditStatusRequest"/></param>
        /// <returns><see cref="ModifyPlatformAuditStatusResponse"/></returns>
        public Task<ModifyPlatformAuditStatusResponse> ModifyPlatformAuditStatus(ModifyPlatformAuditStatusRequest req)
        {
            return InternalRequestAsync<ModifyPlatformAuditStatusResponse>(req, "ModifyPlatformAuditStatus");
        }

        /// <summary>
        /// This API is used to approve or reject the release of the mini program version
        /// </summary>
        /// <param name="req"><see cref="ModifyPlatformAuditStatusRequest"/></param>
        /// <returns><see cref="ModifyPlatformAuditStatusResponse"/></returns>
        public ModifyPlatformAuditStatusResponse ModifyPlatformAuditStatusSync(ModifyPlatformAuditStatusRequest req)
        {
            return InternalRequestAsync<ModifyPlatformAuditStatusResponse>(req, "ModifyPlatformAuditStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to approve or reject the sensitive API permission application
        /// </summary>
        /// <param name="req"><see cref="ModifySensitiveAPIAuditStatusRequest"/></param>
        /// <returns><see cref="ModifySensitiveAPIAuditStatusResponse"/></returns>
        public Task<ModifySensitiveAPIAuditStatusResponse> ModifySensitiveAPIAuditStatus(ModifySensitiveAPIAuditStatusRequest req)
        {
            return InternalRequestAsync<ModifySensitiveAPIAuditStatusResponse>(req, "ModifySensitiveAPIAuditStatus");
        }

        /// <summary>
        /// This API is used to approve or reject the sensitive API permission application
        /// </summary>
        /// <param name="req"><see cref="ModifySensitiveAPIAuditStatusRequest"/></param>
        /// <returns><see cref="ModifySensitiveAPIAuditStatusResponse"/></returns>
        public ModifySensitiveAPIAuditStatusResponse ModifySensitiveAPIAuditStatusSync(ModifySensitiveAPIAuditStatusRequest req)
        {
            return InternalRequestAsync<ModifySensitiveAPIAuditStatusResponse>(req, "ModifySensitiveAPIAuditStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to change team information
        /// </summary>
        /// <param name="req"><see cref="ModifyTeamRequest"/></param>
        /// <returns><see cref="ModifyTeamResponse"/></returns>
        public Task<ModifyTeamResponse> ModifyTeam(ModifyTeamRequest req)
        {
            return InternalRequestAsync<ModifyTeamResponse>(req, "ModifyTeam");
        }

        /// <summary>
        /// This API is used to change team information
        /// </summary>
        /// <param name="req"><see cref="ModifyTeamRequest"/></param>
        /// <returns><see cref="ModifyTeamResponse"/></returns>
        public ModifyTeamResponse ModifyTeamSync(ModifyTeamRequest req)
        {
            return InternalRequestAsync<ModifyTeamResponse>(req, "ModifyTeam")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify team member information.
        /// </summary>
        /// <param name="req"><see cref="ModifyTeamMemberRequest"/></param>
        /// <returns><see cref="ModifyTeamMemberResponse"/></returns>
        public Task<ModifyTeamMemberResponse> ModifyTeamMember(ModifyTeamMemberRequest req)
        {
            return InternalRequestAsync<ModifyTeamMemberResponse>(req, "ModifyTeamMember");
        }

        /// <summary>
        /// This API is used to modify team member information.
        /// </summary>
        /// <param name="req"><see cref="ModifyTeamMemberRequest"/></param>
        /// <returns><see cref="ModifyTeamMemberResponse"/></returns>
        public ModifyTeamMemberResponse ModifyTeamMemberSync(ModifyTeamMemberRequest req)
        {
            return InternalRequestAsync<ModifyTeamMemberResponse>(req, "ModifyTeamMember")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify user information.
        /// </summary>
        /// <param name="req"><see cref="ModifyUserRequest"/></param>
        /// <returns><see cref="ModifyUserResponse"/></returns>
        public Task<ModifyUserResponse> ModifyUser(ModifyUserRequest req)
        {
            return InternalRequestAsync<ModifyUserResponse>(req, "ModifyUser");
        }

        /// <summary>
        /// This API is used to modify user information.
        /// </summary>
        /// <param name="req"><see cref="ModifyUserRequest"/></param>
        /// <returns><see cref="ModifyUserResponse"/></returns>
        public ModifyUserResponse ModifyUserSync(ModifyUserRequest req)
        {
            return InternalRequestAsync<ModifyUserResponse>(req, "ModifyUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to reset user password
        /// </summary>
        /// <param name="req"><see cref="ModifyUserPasswordRequest"/></param>
        /// <returns><see cref="ModifyUserPasswordResponse"/></returns>
        public Task<ModifyUserPasswordResponse> ModifyUserPassword(ModifyUserPasswordRequest req)
        {
            return InternalRequestAsync<ModifyUserPasswordResponse>(req, "ModifyUserPassword");
        }

        /// <summary>
        /// This API is used to reset user password
        /// </summary>
        /// <param name="req"><see cref="ModifyUserPasswordRequest"/></param>
        /// <returns><see cref="ModifyUserPasswordResponse"/></returns>
        public ModifyUserPasswordResponse ModifyUserPasswordSync(ModifyUserPasswordRequest req)
        {
            return InternalRequestAsync<ModifyUserPasswordResponse>(req, "ModifyUserPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to approve or reject the release of a mini program version.
        /// </summary>
        /// <param name="req"><see cref="ProcessMNPApprovalRequest"/></param>
        /// <returns><see cref="ProcessMNPApprovalResponse"/></returns>
        public Task<ProcessMNPApprovalResponse> ProcessMNPApproval(ProcessMNPApprovalRequest req)
        {
            return InternalRequestAsync<ProcessMNPApprovalResponse>(req, "ProcessMNPApproval");
        }

        /// <summary>
        /// This API is used to approve or reject the release of a mini program version.
        /// </summary>
        /// <param name="req"><see cref="ProcessMNPApprovalRequest"/></param>
        /// <returns><see cref="ProcessMNPApprovalResponse"/></returns>
        public ProcessMNPApprovalResponse ProcessMNPApprovalSync(ProcessMNPApprovalRequest req)
        {
            return InternalRequestAsync<ProcessMNPApprovalResponse>(req, "ProcessMNPApproval")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to approve or reject the sensitive API permission application. 
        /// </summary>
        /// <param name="req"><see cref="ProcessMNPSensitiveAPIPermissionApprovalRequest"/></param>
        /// <returns><see cref="ProcessMNPSensitiveAPIPermissionApprovalResponse"/></returns>
        public Task<ProcessMNPSensitiveAPIPermissionApprovalResponse> ProcessMNPSensitiveAPIPermissionApproval(ProcessMNPSensitiveAPIPermissionApprovalRequest req)
        {
            return InternalRequestAsync<ProcessMNPSensitiveAPIPermissionApprovalResponse>(req, "ProcessMNPSensitiveAPIPermissionApproval");
        }

        /// <summary>
        /// This API is used to approve or reject the sensitive API permission application. 
        /// </summary>
        /// <param name="req"><see cref="ProcessMNPSensitiveAPIPermissionApprovalRequest"/></param>
        /// <returns><see cref="ProcessMNPSensitiveAPIPermissionApprovalResponse"/></returns>
        public ProcessMNPSensitiveAPIPermissionApprovalResponse ProcessMNPSensitiveAPIPermissionApprovalSync(ProcessMNPSensitiveAPIPermissionApprovalRequest req)
        {
            return InternalRequestAsync<ProcessMNPSensitiveAPIPermissionApprovalResponse>(req, "ProcessMNPSensitiveAPIPermissionApproval")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to release a mini program version.
        /// </summary>
        /// <param name="req"><see cref="ReleaseMNPVersionRequest"/></param>
        /// <returns><see cref="ReleaseMNPVersionResponse"/></returns>
        public Task<ReleaseMNPVersionResponse> ReleaseMNPVersion(ReleaseMNPVersionRequest req)
        {
            return InternalRequestAsync<ReleaseMNPVersionResponse>(req, "ReleaseMNPVersion");
        }

        /// <summary>
        /// This API is used to release a mini program version.
        /// </summary>
        /// <param name="req"><see cref="ReleaseMNPVersionRequest"/></param>
        /// <returns><see cref="ReleaseMNPVersionResponse"/></returns>
        public ReleaseMNPVersionResponse ReleaseMNPVersionSync(ReleaseMNPVersionRequest req)
        {
            return InternalRequestAsync<ReleaseMNPVersionResponse>(req, "ReleaseMNPVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to remove a mini program.
        /// </summary>
        /// <param name="req"><see cref="RemoveMNPRequest"/></param>
        /// <returns><see cref="RemoveMNPResponse"/></returns>
        public Task<RemoveMNPResponse> RemoveMNP(RemoveMNPRequest req)
        {
            return InternalRequestAsync<RemoveMNPResponse>(req, "RemoveMNP");
        }

        /// <summary>
        /// This API is used to remove a mini program.
        /// </summary>
        /// <param name="req"><see cref="RemoveMNPRequest"/></param>
        /// <returns><see cref="RemoveMNPResponse"/></returns>
        public RemoveMNPResponse RemoveMNPSync(RemoveMNPRequest req)
        {
            return InternalRequestAsync<RemoveMNPResponse>(req, "RemoveMNP")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to rollback a mini program online version.
        /// </summary>
        /// <param name="req"><see cref="RollbackMNPVersionRequest"/></param>
        /// <returns><see cref="RollbackMNPVersionResponse"/></returns>
        public Task<RollbackMNPVersionResponse> RollbackMNPVersion(RollbackMNPVersionRequest req)
        {
            return InternalRequestAsync<RollbackMNPVersionResponse>(req, "RollbackMNPVersion");
        }

        /// <summary>
        /// This API is used to rollback a mini program online version.
        /// </summary>
        /// <param name="req"><see cref="RollbackMNPVersionRequest"/></param>
        /// <returns><see cref="RollbackMNPVersionResponse"/></returns>
        public RollbackMNPVersionResponse RollbackMNPVersionSync(RollbackMNPVersionRequest req)
        {
            return InternalRequestAsync<RollbackMNPVersionResponse>(req, "RollbackMNPVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
