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

namespace TencentCloud.Tcsas.V20250106
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tcsas.V20250106.Models;

   public class TcsasClient : AbstractClient{

       private const string endpoint = "tcsas.intl.tencentcloudapi.com";
       private const string version = "2025-01-06";
       private const string sdkVersion = "SDK_NET_3.0.1139";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TcsasClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TcsasClient(Credential credential, string region, ClientProfile profile)
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
        /// This API is used to configure the preview of a mini program.
        /// </summary>
        /// <param name="req"><see cref="ConfigureMNPPreviewRequest"/></param>
        /// <returns><see cref="ConfigureMNPPreviewResponse"/></returns>
        public Task<ConfigureMNPPreviewResponse> ConfigureMNPPreview(ConfigureMNPPreviewRequest req)
        {
            return InternalRequestAsync<ConfigureMNPPreviewResponse>(req, "ConfigureMNPPreview");
        }

        /// <summary>
        /// This API is used to configure the preview of a mini program.
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
        /// This API is used to create a mini program.
        /// </summary>
        /// <param name="req"><see cref="CreateMNPRequest"/></param>
        /// <returns><see cref="CreateMNPResponse"/></returns>
        public Task<CreateMNPResponse> CreateMNP(CreateMNPRequest req)
        {
            return InternalRequestAsync<CreateMNPResponse>(req, "CreateMNP");
        }

        /// <summary>
        /// This API is used to create a mini program.
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
        /// This API is used to add a domain name to the allowlist / blocklist of a mini program.
        /// </summary>
        /// <param name="req"><see cref="CreateMNPDomainACLRequest"/></param>
        /// <returns><see cref="CreateMNPDomainACLResponse"/></returns>
        public Task<CreateMNPDomainACLResponse> CreateMNPDomainACL(CreateMNPDomainACLRequest req)
        {
            return InternalRequestAsync<CreateMNPDomainACLResponse>(req, "CreateMNPDomainACL");
        }

        /// <summary>
        /// This API is used to add a domain name to the allowlist / blocklist of a mini program.
        /// </summary>
        /// <param name="req"><see cref="CreateMNPDomainACLRequest"/></param>
        /// <returns><see cref="CreateMNPDomainACLResponse"/></returns>
        public CreateMNPDomainACLResponse CreateMNPDomainACLSync(CreateMNPDomainACLRequest req)
        {
            return InternalRequestAsync<CreateMNPDomainACLResponse>(req, "CreateMNPDomainACL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a permission request to allow a mini program to call sensitive APIs.
        /// </summary>
        /// <param name="req"><see cref="CreateMNPSensitiveAPIPermissionApprovalRequest"/></param>
        /// <returns><see cref="CreateMNPSensitiveAPIPermissionApprovalResponse"/></returns>
        public Task<CreateMNPSensitiveAPIPermissionApprovalResponse> CreateMNPSensitiveAPIPermissionApproval(CreateMNPSensitiveAPIPermissionApprovalRequest req)
        {
            return InternalRequestAsync<CreateMNPSensitiveAPIPermissionApprovalResponse>(req, "CreateMNPSensitiveAPIPermissionApproval");
        }

        /// <summary>
        /// This API is used to create a permission request to allow a mini program to call sensitive APIs.
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
        /// This API is used to obtain the encryption key.
        /// </summary>
        /// <param name="req"><see cref="CreatePresetKeyRequest"/></param>
        /// <returns><see cref="CreatePresetKeyResponse"/></returns>
        public Task<CreatePresetKeyResponse> CreatePresetKey(CreatePresetKeyRequest req)
        {
            return InternalRequestAsync<CreatePresetKeyResponse>(req, "CreatePresetKey");
        }

        /// <summary>
        /// This API is used to obtain the encryption key.
        /// </summary>
        /// <param name="req"><see cref="CreatePresetKeyRequest"/></param>
        /// <returns><see cref="CreatePresetKeyResponse"/></returns>
        public CreatePresetKeyResponse CreatePresetKeySync(CreatePresetKeyRequest req)
        {
            return InternalRequestAsync<CreatePresetKeyResponse>(req, "CreatePresetKey")
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
        /// This API is used to create a user.
        /// </summary>
        /// <param name="req"><see cref="CreateUserRequest"/></param>
        /// <returns><see cref="CreateUserResponse"/></returns>
        public Task<CreateUserResponse> CreateUser(CreateUserRequest req)
        {
            return InternalRequestAsync<CreateUserResponse>(req, "CreateUser");
        }

        /// <summary>
        /// This API is used to create a user.
        /// </summary>
        /// <param name="req"><see cref="CreateUserRequest"/></param>
        /// <returns><see cref="CreateUserResponse"/></returns>
        public CreateUserResponse CreateUserSync(CreateUserRequest req)
        {
            return InternalRequestAsync<CreateUserResponse>(req, "CreateUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the applications.
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationRequest"/></param>
        /// <returns><see cref="DeleteApplicationResponse"/></returns>
        public Task<DeleteApplicationResponse> DeleteApplication(DeleteApplicationRequest req)
        {
            return InternalRequestAsync<DeleteApplicationResponse>(req, "DeleteApplication");
        }

        /// <summary>
        /// This API is used to delete the applications.
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
        /// This API is used to delete domains from the allowlist or blocklist.
        /// </summary>
        /// <param name="req"><see cref="DeleteGlobalDomainRequest"/></param>
        /// <returns><see cref="DeleteGlobalDomainResponse"/></returns>
        public Task<DeleteGlobalDomainResponse> DeleteGlobalDomain(DeleteGlobalDomainRequest req)
        {
            return InternalRequestAsync<DeleteGlobalDomainResponse>(req, "DeleteGlobalDomain");
        }

        /// <summary>
        /// This API is used to delete domains from the allowlist or blocklist.
        /// </summary>
        /// <param name="req"><see cref="DeleteGlobalDomainRequest"/></param>
        /// <returns><see cref="DeleteGlobalDomainResponse"/></returns>
        public DeleteGlobalDomainResponse DeleteGlobalDomainSync(DeleteGlobalDomainRequest req)
        {
            return InternalRequestAsync<DeleteGlobalDomainResponse>(req, "DeleteGlobalDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a mini program.
        /// </summary>
        /// <param name="req"><see cref="DeleteMNPRequest"/></param>
        /// <returns><see cref="DeleteMNPResponse"/></returns>
        public Task<DeleteMNPResponse> DeleteMNP(DeleteMNPRequest req)
        {
            return InternalRequestAsync<DeleteMNPResponse>(req, "DeleteMNP");
        }

        /// <summary>
        /// This API is used to delete a mini program.
        /// </summary>
        /// <param name="req"><see cref="DeleteMNPRequest"/></param>
        /// <returns><see cref="DeleteMNPResponse"/></returns>
        public DeleteMNPResponse DeleteMNPSync(DeleteMNPRequest req)
        {
            return InternalRequestAsync<DeleteMNPResponse>(req, "DeleteMNP")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to deletes a team.
        /// </summary>
        /// <param name="req"><see cref="DeleteTeamRequest"/></param>
        /// <returns><see cref="DeleteTeamResponse"/></returns>
        public Task<DeleteTeamResponse> DeleteTeam(DeleteTeamRequest req)
        {
            return InternalRequestAsync<DeleteTeamResponse>(req, "DeleteTeam");
        }

        /// <summary>
        /// This API is used to deletes a team.
        /// </summary>
        /// <param name="req"><see cref="DeleteTeamRequest"/></param>
        /// <returns><see cref="DeleteTeamResponse"/></returns>
        public DeleteTeamResponse DeleteTeamSync(DeleteTeamRequest req)
        {
            return InternalRequestAsync<DeleteTeamResponse>(req, "DeleteTeam")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a team member.
        /// </summary>
        /// <param name="req"><see cref="DeleteTeamMemberRequest"/></param>
        /// <returns><see cref="DeleteTeamMemberResponse"/></returns>
        public Task<DeleteTeamMemberResponse> DeleteTeamMember(DeleteTeamMemberRequest req)
        {
            return InternalRequestAsync<DeleteTeamMemberResponse>(req, "DeleteTeamMember");
        }

        /// <summary>
        /// This API is used to delete a team member.
        /// </summary>
        /// <param name="req"><see cref="DeleteTeamMemberRequest"/></param>
        /// <returns><see cref="DeleteTeamMemberResponse"/></returns>
        public DeleteTeamMemberResponse DeleteTeamMemberSync(DeleteTeamMemberRequest req)
        {
            return InternalRequestAsync<DeleteTeamMemberResponse>(req, "DeleteTeamMember")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a user.
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRequest"/></param>
        /// <returns><see cref="DeleteUserResponse"/></returns>
        public Task<DeleteUserResponse> DeleteUser(DeleteUserRequest req)
        {
            return InternalRequestAsync<DeleteUserResponse>(req, "DeleteUser");
        }

        /// <summary>
        /// This API is used to delete a user.
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRequest"/></param>
        /// <returns><see cref="DeleteUserResponse"/></returns>
        public DeleteUserResponse DeleteUserSync(DeleteUserRequest req)
        {
            return InternalRequestAsync<DeleteUserResponse>(req, "DeleteUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the application details.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationRequest"/></param>
        /// <returns><see cref="DescribeApplicationResponse"/></returns>
        public Task<DescribeApplicationResponse> DescribeApplication(DescribeApplicationRequest req)
        {
            return InternalRequestAsync<DescribeApplicationResponse>(req, "DescribeApplication");
        }

        /// <summary>
        /// This API is used to query the application details.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationRequest"/></param>
        /// <returns><see cref="DescribeApplicationResponse"/></returns>
        public DescribeApplicationResponse DescribeApplicationSync(DescribeApplicationRequest req)
        {
            return InternalRequestAsync<DescribeApplicationResponse>(req, "DescribeApplication")
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
        /// This API is used to query the applications.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationListRequest"/></param>
        /// <returns><see cref="DescribeApplicationListResponse"/></returns>
        public Task<DescribeApplicationListResponse> DescribeApplicationList(DescribeApplicationListRequest req)
        {
            return InternalRequestAsync<DescribeApplicationListResponse>(req, "DescribeApplicationList");
        }

        /// <summary>
        /// This API is used to query the applications.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationListRequest"/></param>
        /// <returns><see cref="DescribeApplicationListResponse"/></returns>
        public DescribeApplicationListResponse DescribeApplicationListSync(DescribeApplicationListRequest req)
        {
            return InternalRequestAsync<DescribeApplicationListResponse>(req, "DescribeApplicationList")
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
        /// This API is used to query the mini program details.
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPRequest"/></param>
        /// <returns><see cref="DescribeMNPResponse"/></returns>
        public Task<DescribeMNPResponse> DescribeMNP(DescribeMNPRequest req)
        {
            return InternalRequestAsync<DescribeMNPResponse>(req, "DescribeMNP");
        }

        /// <summary>
        /// This API is used to query the mini program details.
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPRequest"/></param>
        /// <returns><see cref="DescribeMNPResponse"/></returns>
        public DescribeMNPResponse DescribeMNPSync(DescribeMNPRequest req)
        {
            return InternalRequestAsync<DescribeMNPResponse>(req, "DescribeMNP")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the mini program version management information.
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPAllStageVersionsRequest"/></param>
        /// <returns><see cref="DescribeMNPAllStageVersionsResponse"/></returns>
        public Task<DescribeMNPAllStageVersionsResponse> DescribeMNPAllStageVersions(DescribeMNPAllStageVersionsRequest req)
        {
            return InternalRequestAsync<DescribeMNPAllStageVersionsResponse>(req, "DescribeMNPAllStageVersions");
        }

        /// <summary>
        /// This API is used to query the mini program version management information.
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
        /// This API is used to query the mini program types.
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPCategoryRequest"/></param>
        /// <returns><see cref="DescribeMNPCategoryResponse"/></returns>
        public Task<DescribeMNPCategoryResponse> DescribeMNPCategory(DescribeMNPCategoryRequest req)
        {
            return InternalRequestAsync<DescribeMNPCategoryResponse>(req, "DescribeMNPCategory");
        }

        /// <summary>
        /// This API is used to query the mini program types.
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPCategoryRequest"/></param>
        /// <returns><see cref="DescribeMNPCategoryResponse"/></returns>
        public DescribeMNPCategoryResponse DescribeMNPCategorySync(DescribeMNPCategoryRequest req)
        {
            return InternalRequestAsync<DescribeMNPCategoryResponse>(req, "DescribeMNPCategory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the domain allowlist / blocklist of a mini program.
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPDomainACLRequest"/></param>
        /// <returns><see cref="DescribeMNPDomainACLResponse"/></returns>
        public Task<DescribeMNPDomainACLResponse> DescribeMNPDomainACL(DescribeMNPDomainACLRequest req)
        {
            return InternalRequestAsync<DescribeMNPDomainACLResponse>(req, "DescribeMNPDomainACL");
        }

        /// <summary>
        /// This API is used to query the domain allowlist / blocklist of a mini program.
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPDomainACLRequest"/></param>
        /// <returns><see cref="DescribeMNPDomainACLResponse"/></returns>
        public DescribeMNPDomainACLResponse DescribeMNPDomainACLSync(DescribeMNPDomainACLRequest req)
        {
            return InternalRequestAsync<DescribeMNPDomainACLResponse>(req, "DescribeMNPDomainACL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the mini programs.
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPListRequest"/></param>
        /// <returns><see cref="DescribeMNPListResponse"/></returns>
        public Task<DescribeMNPListResponse> DescribeMNPList(DescribeMNPListRequest req)
        {
            return InternalRequestAsync<DescribeMNPListResponse>(req, "DescribeMNPList");
        }

        /// <summary>
        /// This API is used to query the mini programs.
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPListRequest"/></param>
        /// <returns><see cref="DescribeMNPListResponse"/></returns>
        public DescribeMNPListResponse DescribeMNPListSync(DescribeMNPListRequest req)
        {
            return InternalRequestAsync<DescribeMNPListResponse>(req, "DescribeMNPList")
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
        /// This API is used to query the mini program preview details.
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPPreviewRequest"/></param>
        /// <returns><see cref="DescribeMNPPreviewResponse"/></returns>
        public Task<DescribeMNPPreviewResponse> DescribeMNPPreview(DescribeMNPPreviewRequest req)
        {
            return InternalRequestAsync<DescribeMNPPreviewResponse>(req, "DescribeMNPPreview");
        }

        /// <summary>
        /// This API is used to query the mini program preview details.
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPPreviewRequest"/></param>
        /// <returns><see cref="DescribeMNPPreviewResponse"/></returns>
        public DescribeMNPPreviewResponse DescribeMNPPreviewSync(DescribeMNPPreviewRequest req)
        {
            return InternalRequestAsync<DescribeMNPPreviewResponse>(req, "DescribeMNPPreview")
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
        /// This API is used to query the mini program version creation results.
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPVersionRequest"/></param>
        /// <returns><see cref="DescribeMNPVersionResponse"/></returns>
        public Task<DescribeMNPVersionResponse> DescribeMNPVersion(DescribeMNPVersionRequest req)
        {
            return InternalRequestAsync<DescribeMNPVersionResponse>(req, "DescribeMNPVersion");
        }

        /// <summary>
        /// This API is used to query the mini program version creation results.
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPVersionRequest"/></param>
        /// <returns><see cref="DescribeMNPVersionResponse"/></returns>
        public DescribeMNPVersionResponse DescribeMNPVersionSync(DescribeMNPVersionRequest req)
        {
            return InternalRequestAsync<DescribeMNPVersionResponse>(req, "DescribeMNPVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the roles.
        /// </summary>
        /// <param name="req"><see cref="DescribeRoleListRequest"/></param>
        /// <returns><see cref="DescribeRoleListResponse"/></returns>
        public Task<DescribeRoleListResponse> DescribeRoleList(DescribeRoleListRequest req)
        {
            return InternalRequestAsync<DescribeRoleListResponse>(req, "DescribeRoleList");
        }

        /// <summary>
        /// This API is used to query the roles.
        /// </summary>
        /// <param name="req"><see cref="DescribeRoleListRequest"/></param>
        /// <returns><see cref="DescribeRoleListResponse"/></returns>
        public DescribeRoleListResponse DescribeRoleListSync(DescribeRoleListRequest req)
        {
            return InternalRequestAsync<DescribeRoleListResponse>(req, "DescribeRoleList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the team details.
        /// </summary>
        /// <param name="req"><see cref="DescribeTeamRequest"/></param>
        /// <returns><see cref="DescribeTeamResponse"/></returns>
        public Task<DescribeTeamResponse> DescribeTeam(DescribeTeamRequest req)
        {
            return InternalRequestAsync<DescribeTeamResponse>(req, "DescribeTeam");
        }

        /// <summary>
        /// This API is used to query the team details.
        /// </summary>
        /// <param name="req"><see cref="DescribeTeamRequest"/></param>
        /// <returns><see cref="DescribeTeamResponse"/></returns>
        public DescribeTeamResponse DescribeTeamSync(DescribeTeamRequest req)
        {
            return InternalRequestAsync<DescribeTeamResponse>(req, "DescribeTeam")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the teams.
        /// </summary>
        /// <param name="req"><see cref="DescribeTeamListRequest"/></param>
        /// <returns><see cref="DescribeTeamListResponse"/></returns>
        public Task<DescribeTeamListResponse> DescribeTeamList(DescribeTeamListRequest req)
        {
            return InternalRequestAsync<DescribeTeamListResponse>(req, "DescribeTeamList");
        }

        /// <summary>
        /// This API is used to query the teams.
        /// </summary>
        /// <param name="req"><see cref="DescribeTeamListRequest"/></param>
        /// <returns><see cref="DescribeTeamListResponse"/></returns>
        public DescribeTeamListResponse DescribeTeamListSync(DescribeTeamListRequest req)
        {
            return InternalRequestAsync<DescribeTeamListResponse>(req, "DescribeTeamList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the team members.
        /// </summary>
        /// <param name="req"><see cref="DescribeTeamMemberListRequest"/></param>
        /// <returns><see cref="DescribeTeamMemberListResponse"/></returns>
        public Task<DescribeTeamMemberListResponse> DescribeTeamMemberList(DescribeTeamMemberListRequest req)
        {
            return InternalRequestAsync<DescribeTeamMemberListResponse>(req, "DescribeTeamMemberList");
        }

        /// <summary>
        /// This API is used to query the team members.
        /// </summary>
        /// <param name="req"><see cref="DescribeTeamMemberListRequest"/></param>
        /// <returns><see cref="DescribeTeamMemberListResponse"/></returns>
        public DescribeTeamMemberListResponse DescribeTeamMemberListSync(DescribeTeamMemberListRequest req)
        {
            return InternalRequestAsync<DescribeTeamMemberListResponse>(req, "DescribeTeamMemberList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain a temporary key for file uploads.
        /// </summary>
        /// <param name="req"><see cref="DescribeTempSecret4UploadFile2CosRequest"/></param>
        /// <returns><see cref="DescribeTempSecret4UploadFile2CosResponse"/></returns>
        public Task<DescribeTempSecret4UploadFile2CosResponse> DescribeTempSecret4UploadFile2Cos(DescribeTempSecret4UploadFile2CosRequest req)
        {
            return InternalRequestAsync<DescribeTempSecret4UploadFile2CosResponse>(req, "DescribeTempSecret4UploadFile2Cos");
        }

        /// <summary>
        /// This API is used to obtain a temporary key for file uploads.
        /// </summary>
        /// <param name="req"><see cref="DescribeTempSecret4UploadFile2CosRequest"/></param>
        /// <returns><see cref="DescribeTempSecret4UploadFile2CosResponse"/></returns>
        public DescribeTempSecret4UploadFile2CosResponse DescribeTempSecret4UploadFile2CosSync(DescribeTempSecret4UploadFile2CosRequest req)
        {
            return InternalRequestAsync<DescribeTempSecret4UploadFile2CosResponse>(req, "DescribeTempSecret4UploadFile2Cos")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the user details.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRequest"/></param>
        /// <returns><see cref="DescribeUserResponse"/></returns>
        public Task<DescribeUserResponse> DescribeUser(DescribeUserRequest req)
        {
            return InternalRequestAsync<DescribeUserResponse>(req, "DescribeUser");
        }

        /// <summary>
        /// This API is used to query the user details.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRequest"/></param>
        /// <returns><see cref="DescribeUserResponse"/></returns>
        public DescribeUserResponse DescribeUserSync(DescribeUserRequest req)
        {
            return InternalRequestAsync<DescribeUserResponse>(req, "DescribeUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the users.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserListRequest"/></param>
        /// <returns><see cref="DescribeUserListResponse"/></returns>
        public Task<DescribeUserListResponse> DescribeUserList(DescribeUserListRequest req)
        {
            return InternalRequestAsync<DescribeUserListResponse>(req, "DescribeUserList");
        }

        /// <summary>
        /// This API is used to query the users.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserListRequest"/></param>
        /// <returns><see cref="DescribeUserListResponse"/></returns>
        public DescribeUserListResponse DescribeUserListSync(DescribeUserListRequest req)
        {
            return InternalRequestAsync<DescribeUserListResponse>(req, "DescribeUserList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set a sensitive API to restricted.
        /// </summary>
        /// <param name="req"><see cref="DisableApplicationSensitiveAPIRequest"/></param>
        /// <returns><see cref="DisableApplicationSensitiveAPIResponse"/></returns>
        public Task<DisableApplicationSensitiveAPIResponse> DisableApplicationSensitiveAPI(DisableApplicationSensitiveAPIRequest req)
        {
            return InternalRequestAsync<DisableApplicationSensitiveAPIResponse>(req, "DisableApplicationSensitiveAPI");
        }

        /// <summary>
        /// This API is used to set a sensitive API to restricted.
        /// </summary>
        /// <param name="req"><see cref="DisableApplicationSensitiveAPIRequest"/></param>
        /// <returns><see cref="DisableApplicationSensitiveAPIResponse"/></returns>
        public DisableApplicationSensitiveAPIResponse DisableApplicationSensitiveAPISync(DisableApplicationSensitiveAPIRequest req)
        {
            return InternalRequestAsync<DisableApplicationSensitiveAPIResponse>(req, "DisableApplicationSensitiveAPI")
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
        /// This API is used to change the application information.
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationRequest"/></param>
        /// <returns><see cref="ModifyApplicationResponse"/></returns>
        public Task<ModifyApplicationResponse> ModifyApplication(ModifyApplicationRequest req)
        {
            return InternalRequestAsync<ModifyApplicationResponse>(req, "ModifyApplication");
        }

        /// <summary>
        /// This API is used to change the application information.
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationRequest"/></param>
        /// <returns><see cref="ModifyApplicationResponse"/></returns>
        public ModifyApplicationResponse ModifyApplicationSync(ModifyApplicationRequest req)
        {
            return InternalRequestAsync<ModifyApplicationResponse>(req, "ModifyApplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the domain allowlist or blocklist.
        /// </summary>
        /// <param name="req"><see cref="ModifyGlobalDomainRequest"/></param>
        /// <returns><see cref="ModifyGlobalDomainResponse"/></returns>
        public Task<ModifyGlobalDomainResponse> ModifyGlobalDomain(ModifyGlobalDomainRequest req)
        {
            return InternalRequestAsync<ModifyGlobalDomainResponse>(req, "ModifyGlobalDomain");
        }

        /// <summary>
        /// This API is used to modify the domain allowlist or blocklist.
        /// </summary>
        /// <param name="req"><see cref="ModifyGlobalDomainRequest"/></param>
        /// <returns><see cref="ModifyGlobalDomainResponse"/></returns>
        public ModifyGlobalDomainResponse ModifyGlobalDomainSync(ModifyGlobalDomainRequest req)
        {
            return InternalRequestAsync<ModifyGlobalDomainResponse>(req, "ModifyGlobalDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the mini program information.
        /// </summary>
        /// <param name="req"><see cref="ModifyMNPRequest"/></param>
        /// <returns><see cref="ModifyMNPResponse"/></returns>
        public Task<ModifyMNPResponse> ModifyMNP(ModifyMNPRequest req)
        {
            return InternalRequestAsync<ModifyMNPResponse>(req, "ModifyMNP");
        }

        /// <summary>
        /// This API is used to modify the mini program information.
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
        /// This API is used to change the team information.
        /// </summary>
        /// <param name="req"><see cref="ModifyTeamRequest"/></param>
        /// <returns><see cref="ModifyTeamResponse"/></returns>
        public Task<ModifyTeamResponse> ModifyTeam(ModifyTeamRequest req)
        {
            return InternalRequestAsync<ModifyTeamResponse>(req, "ModifyTeam");
        }

        /// <summary>
        /// This API is used to change the team information.
        /// </summary>
        /// <param name="req"><see cref="ModifyTeamRequest"/></param>
        /// <returns><see cref="ModifyTeamResponse"/></returns>
        public ModifyTeamResponse ModifyTeamSync(ModifyTeamRequest req)
        {
            return InternalRequestAsync<ModifyTeamResponse>(req, "ModifyTeam")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the team member information.
        /// </summary>
        /// <param name="req"><see cref="ModifyTeamMemberRequest"/></param>
        /// <returns><see cref="ModifyTeamMemberResponse"/></returns>
        public Task<ModifyTeamMemberResponse> ModifyTeamMember(ModifyTeamMemberRequest req)
        {
            return InternalRequestAsync<ModifyTeamMemberResponse>(req, "ModifyTeamMember");
        }

        /// <summary>
        /// This API is used to modify the team member information.
        /// </summary>
        /// <param name="req"><see cref="ModifyTeamMemberRequest"/></param>
        /// <returns><see cref="ModifyTeamMemberResponse"/></returns>
        public ModifyTeamMemberResponse ModifyTeamMemberSync(ModifyTeamMemberRequest req)
        {
            return InternalRequestAsync<ModifyTeamMemberResponse>(req, "ModifyTeamMember")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the user information.
        /// </summary>
        /// <param name="req"><see cref="ModifyUserRequest"/></param>
        /// <returns><see cref="ModifyUserResponse"/></returns>
        public Task<ModifyUserResponse> ModifyUser(ModifyUserRequest req)
        {
            return InternalRequestAsync<ModifyUserResponse>(req, "ModifyUser");
        }

        /// <summary>
        /// This API is used to modify the user information.
        /// </summary>
        /// <param name="req"><see cref="ModifyUserRequest"/></param>
        /// <returns><see cref="ModifyUserResponse"/></returns>
        public ModifyUserResponse ModifyUserSync(ModifyUserRequest req)
        {
            return InternalRequestAsync<ModifyUserResponse>(req, "ModifyUser")
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
        /// This API is used to approve or reject the sensitive API permission requests.
        /// </summary>
        /// <param name="req"><see cref="ProcessMNPSensitiveAPIPermissionApprovalRequest"/></param>
        /// <returns><see cref="ProcessMNPSensitiveAPIPermissionApprovalResponse"/></returns>
        public Task<ProcessMNPSensitiveAPIPermissionApprovalResponse> ProcessMNPSensitiveAPIPermissionApproval(ProcessMNPSensitiveAPIPermissionApprovalRequest req)
        {
            return InternalRequestAsync<ProcessMNPSensitiveAPIPermissionApprovalResponse>(req, "ProcessMNPSensitiveAPIPermissionApproval");
        }

        /// <summary>
        /// This API is used to approve or reject the sensitive API permission requests.
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
