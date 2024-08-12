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

       private const string endpoint = "tcmpp.tencentcloudapi.com";
       private const string version = "2024-08-01";
       private const string sdkVersion = "SDK_NET_3.0.959";

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
        /// This API is used to add users to a team
        /// </summary>
        /// <param name="req"><see cref="AddTeamMemberRequest"/></param>
        /// <returns><see cref="AddTeamMemberResponse"/></returns>
        public Task<AddTeamMemberResponse> AddTeamMember(AddTeamMemberRequest req)
        {
            return InternalRequestAsync<AddTeamMemberResponse>(req, "AddTeamMember");
        }

        /// <summary>
        /// This API is used to add users to a team
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
        /// This API is used to add an application
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationRequest"/></param>
        /// <returns><see cref="CreateApplicationResponse"/></returns>
        public Task<CreateApplicationResponse> CreateApplication(CreateApplicationRequest req)
        {
            return InternalRequestAsync<CreateApplicationResponse>(req, "CreateApplication");
        }

        /// <summary>
        /// This API is used to add an application
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationRequest"/></param>
        /// <returns><see cref="CreateApplicationResponse"/></returns>
        public CreateApplicationResponse CreateApplicationSync(CreateApplicationRequest req)
        {
            return InternalRequestAsync<CreateApplicationResponse>(req, "CreateApplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add new mini program version to the console
        /// </summary>
        /// <param name="req"><see cref="CreateConsoleMNPVersionCompileTaskRequest"/></param>
        /// <returns><see cref="CreateConsoleMNPVersionCompileTaskResponse"/></returns>
        public Task<CreateConsoleMNPVersionCompileTaskResponse> CreateConsoleMNPVersionCompileTask(CreateConsoleMNPVersionCompileTaskRequest req)
        {
            return InternalRequestAsync<CreateConsoleMNPVersionCompileTaskResponse>(req, "CreateConsoleMNPVersionCompileTask");
        }

        /// <summary>
        /// This API is used to add new mini program version to the console
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
        /// This API is used to apply for sensitive API call permissions
        /// </summary>
        /// <param name="req"><see cref="CreateSensitiveApiApplyRequest"/></param>
        /// <returns><see cref="CreateSensitiveApiApplyResponse"/></returns>
        public Task<CreateSensitiveApiApplyResponse> CreateSensitiveApiApply(CreateSensitiveApiApplyRequest req)
        {
            return InternalRequestAsync<CreateSensitiveApiApplyResponse>(req, "CreateSensitiveApiApply");
        }

        /// <summary>
        /// This API is used to apply for sensitive API call permissions
        /// </summary>
        /// <param name="req"><see cref="CreateSensitiveApiApplyRequest"/></param>
        /// <returns><see cref="CreateSensitiveApiApplyResponse"/></returns>
        public CreateSensitiveApiApplyResponse CreateSensitiveApiApplySync(CreateSensitiveApiApplyRequest req)
        {
            return InternalRequestAsync<CreateSensitiveApiApplyResponse>(req, "CreateSensitiveApiApply")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a team
        /// </summary>
        /// <param name="req"><see cref="CreateTeamRequest"/></param>
        /// <returns><see cref="CreateTeamResponse"/></returns>
        public Task<CreateTeamResponse> CreateTeam(CreateTeamRequest req)
        {
            return InternalRequestAsync<CreateTeamResponse>(req, "CreateTeam");
        }

        /// <summary>
        /// This API is used to create a team
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
        /// This API is used to delete a sensitive API
        /// </summary>
        /// <param name="req"><see cref="DeleteSensitiveAPIRequest"/></param>
        /// <returns><see cref="DeleteSensitiveAPIResponse"/></returns>
        public Task<DeleteSensitiveAPIResponse> DeleteSensitiveAPI(DeleteSensitiveAPIRequest req)
        {
            return InternalRequestAsync<DeleteSensitiveAPIResponse>(req, "DeleteSensitiveAPI");
        }

        /// <summary>
        /// This API is used to delete a sensitive API
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
        /// This API is used to query application details
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationRequest"/></param>
        /// <returns><see cref="DescribeApplicationResponse"/></returns>
        public Task<DescribeApplicationResponse> DescribeApplication(DescribeApplicationRequest req)
        {
            return InternalRequestAsync<DescribeApplicationResponse>(req, "DescribeApplication");
        }

        /// <summary>
        /// This API is used to query application details
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
        /// This API is used to query application list data
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationListRequest"/></param>
        /// <returns><see cref="DescribeApplicationListResponse"/></returns>
        public Task<DescribeApplicationListResponse> DescribeApplicationList(DescribeApplicationListRequest req)
        {
            return InternalRequestAsync<DescribeApplicationListResponse>(req, "DescribeApplicationList");
        }

        /// <summary>
        /// This API is used to query application list data
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
        /// This API is used to query if the mini program version is uploaded successfully
        /// </summary>
        /// <param name="req"><see cref="DescribeConsoleMNPVersionCompileTaskRequest"/></param>
        /// <returns><see cref="DescribeConsoleMNPVersionCompileTaskResponse"/></returns>
        public Task<DescribeConsoleMNPVersionCompileTaskResponse> DescribeConsoleMNPVersionCompileTask(DescribeConsoleMNPVersionCompileTaskRequest req)
        {
            return InternalRequestAsync<DescribeConsoleMNPVersionCompileTaskResponse>(req, "DescribeConsoleMNPVersionCompileTask");
        }

        /// <summary>
        /// This API is used to query if the mini program version is uploaded successfully
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
        /// This API is used to query the details of the mini program trial version
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPVersionPreviewRequest"/></param>
        /// <returns><see cref="DescribeMNPVersionPreviewResponse"/></returns>
        public Task<DescribeMNPVersionPreviewResponse> DescribeMNPVersionPreview(DescribeMNPVersionPreviewRequest req)
        {
            return InternalRequestAsync<DescribeMNPVersionPreviewResponse>(req, "DescribeMNPVersionPreview");
        }

        /// <summary>
        /// This API is used to query the details of the mini program trial version
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
        /// This API is used to query the current release version of the mini program
        /// </summary>
        /// <param name="req"><see cref="DescribeOnlineVersionRequest"/></param>
        /// <returns><see cref="DescribeOnlineVersionResponse"/></returns>
        public Task<DescribeOnlineVersionResponse> DescribeOnlineVersion(DescribeOnlineVersionRequest req)
        {
            return InternalRequestAsync<DescribeOnlineVersionResponse>(req, "DescribeOnlineVersion");
        }

        /// <summary>
        /// This API is used to query the current release version of the mini program
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
        /// This API is used to query role list data
        /// </summary>
        /// <param name="req"><see cref="DescribeRoleListRequest"/></param>
        /// <returns><see cref="DescribeRoleListResponse"/></returns>
        public Task<DescribeRoleListResponse> DescribeRoleList(DescribeRoleListRequest req)
        {
            return InternalRequestAsync<DescribeRoleListResponse>(req, "DescribeRoleList");
        }

        /// <summary>
        /// This API is used to query role list data
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
        /// This API is used to query sensitive API call details
        /// </summary>
        /// <param name="req"><see cref="DescribeSensitiveApiApplyDetailRequest"/></param>
        /// <returns><see cref="DescribeSensitiveApiApplyDetailResponse"/></returns>
        public Task<DescribeSensitiveApiApplyDetailResponse> DescribeSensitiveApiApplyDetail(DescribeSensitiveApiApplyDetailRequest req)
        {
            return InternalRequestAsync<DescribeSensitiveApiApplyDetailResponse>(req, "DescribeSensitiveApiApplyDetail");
        }

        /// <summary>
        /// This API is used to query sensitive API call details
        /// </summary>
        /// <param name="req"><see cref="DescribeSensitiveApiApplyDetailRequest"/></param>
        /// <returns><see cref="DescribeSensitiveApiApplyDetailResponse"/></returns>
        public DescribeSensitiveApiApplyDetailResponse DescribeSensitiveApiApplyDetailSync(DescribeSensitiveApiApplyDetailRequest req)
        {
            return InternalRequestAsync<DescribeSensitiveApiApplyDetailResponse>(req, "DescribeSensitiveApiApplyDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the sensitive APIs that require permission
        /// </summary>
        /// <param name="req"><see cref="DescribeSensitiveApiAuthListRequest"/></param>
        /// <returns><see cref="DescribeSensitiveApiAuthListResponse"/></returns>
        public Task<DescribeSensitiveApiAuthListResponse> DescribeSensitiveApiAuthList(DescribeSensitiveApiAuthListRequest req)
        {
            return InternalRequestAsync<DescribeSensitiveApiAuthListResponse>(req, "DescribeSensitiveApiAuthList");
        }

        /// <summary>
        /// This API is used to query the sensitive APIs that require permission
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
        /// This API is used to query team details
        /// </summary>
        /// <param name="req"><see cref="DescribeTeamRequest"/></param>
        /// <returns><see cref="DescribeTeamResponse"/></returns>
        public Task<DescribeTeamResponse> DescribeTeam(DescribeTeamRequest req)
        {
            return InternalRequestAsync<DescribeTeamResponse>(req, "DescribeTeam");
        }

        /// <summary>
        /// This API is used to query team details
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
        /// This API is used to query the team list that can be viewed by the current role permissions
        /// </summary>
        /// <param name="req"><see cref="DescribeTeamListRequest"/></param>
        /// <returns><see cref="DescribeTeamListResponse"/></returns>
        public Task<DescribeTeamListResponse> DescribeTeamList(DescribeTeamListRequest req)
        {
            return InternalRequestAsync<DescribeTeamListResponse>(req, "DescribeTeamList");
        }

        /// <summary>
        /// This API is used to query the team list that can be viewed by the current role permissions
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
        /// This API is used to configure the mini program trial version
        /// </summary>
        /// <param name="req"><see cref="ModifyMNPVersionPreviewRequest"/></param>
        /// <returns><see cref="ModifyMNPVersionPreviewResponse"/></returns>
        public Task<ModifyMNPVersionPreviewResponse> ModifyMNPVersionPreview(ModifyMNPVersionPreviewRequest req)
        {
            return InternalRequestAsync<ModifyMNPVersionPreviewResponse>(req, "ModifyMNPVersionPreview");
        }

        /// <summary>
        /// This API is used to configure the mini program trial version
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
        /// This API is used to approve the release of the mini program version
        /// </summary>
        /// <param name="req"><see cref="ModifyPlatformAuditStatusRequest"/></param>
        /// <returns><see cref="ModifyPlatformAuditStatusResponse"/></returns>
        public Task<ModifyPlatformAuditStatusResponse> ModifyPlatformAuditStatus(ModifyPlatformAuditStatusRequest req)
        {
            return InternalRequestAsync<ModifyPlatformAuditStatusResponse>(req, "ModifyPlatformAuditStatus");
        }

        /// <summary>
        /// This API is used to approve the release of the mini program version
        /// </summary>
        /// <param name="req"><see cref="ModifyPlatformAuditStatusRequest"/></param>
        /// <returns><see cref="ModifyPlatformAuditStatusResponse"/></returns>
        public ModifyPlatformAuditStatusResponse ModifyPlatformAuditStatusSync(ModifyPlatformAuditStatusRequest req)
        {
            return InternalRequestAsync<ModifyPlatformAuditStatusResponse>(req, "ModifyPlatformAuditStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to approve sensitive API call permission
        /// </summary>
        /// <param name="req"><see cref="ModifySensitiveAPIAuditStatusRequest"/></param>
        /// <returns><see cref="ModifySensitiveAPIAuditStatusResponse"/></returns>
        public Task<ModifySensitiveAPIAuditStatusResponse> ModifySensitiveAPIAuditStatus(ModifySensitiveAPIAuditStatusRequest req)
        {
            return InternalRequestAsync<ModifySensitiveAPIAuditStatusResponse>(req, "ModifySensitiveAPIAuditStatus");
        }

        /// <summary>
        /// This API is used to approve sensitive API call permission
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
        /// This API is used to change team member roles
        /// </summary>
        /// <param name="req"><see cref="ModifyTeamMemberRequest"/></param>
        /// <returns><see cref="ModifyTeamMemberResponse"/></returns>
        public Task<ModifyTeamMemberResponse> ModifyTeamMember(ModifyTeamMemberRequest req)
        {
            return InternalRequestAsync<ModifyTeamMemberResponse>(req, "ModifyTeamMember");
        }

        /// <summary>
        /// This API is used to change team member roles
        /// </summary>
        /// <param name="req"><see cref="ModifyTeamMemberRequest"/></param>
        /// <returns><see cref="ModifyTeamMemberResponse"/></returns>
        public ModifyTeamMemberResponse ModifyTeamMemberSync(ModifyTeamMemberRequest req)
        {
            return InternalRequestAsync<ModifyTeamMemberResponse>(req, "ModifyTeamMember")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to edit user information
        /// </summary>
        /// <param name="req"><see cref="ModifyUserRequest"/></param>
        /// <returns><see cref="ModifyUserResponse"/></returns>
        public Task<ModifyUserResponse> ModifyUser(ModifyUserRequest req)
        {
            return InternalRequestAsync<ModifyUserResponse>(req, "ModifyUser");
        }

        /// <summary>
        /// This API is used to edit user information
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

    }
}
