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

namespace TencentCloud.Organization.V20210331
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Organization.V20210331.Models;

   public class OrganizationClient : AbstractClient{

       private const string endpoint = "organization.tencentcloudapi.com";
       private const string version = "2021-03-31";
       private const string sdkVersion = "SDK_NET_3.0.1059";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public OrganizationClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public OrganizationClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to add SAML signing certificates.
        /// </summary>
        /// <param name="req"><see cref="AddExternalSAMLIdPCertificateRequest"/></param>
        /// <returns><see cref="AddExternalSAMLIdPCertificateResponse"/></returns>
        public Task<AddExternalSAMLIdPCertificateResponse> AddExternalSAMLIdPCertificate(AddExternalSAMLIdPCertificateRequest req)
        {
            return InternalRequestAsync<AddExternalSAMLIdPCertificateResponse>(req, "AddExternalSAMLIdPCertificate");
        }

        /// <summary>
        /// This API is used to add SAML signing certificates.
        /// </summary>
        /// <param name="req"><see cref="AddExternalSAMLIdPCertificateRequest"/></param>
        /// <returns><see cref="AddExternalSAMLIdPCertificateResponse"/></returns>
        public AddExternalSAMLIdPCertificateResponse AddExternalSAMLIdPCertificateSync(AddExternalSAMLIdPCertificateRequest req)
        {
            return InternalRequestAsync<AddExternalSAMLIdPCertificateResponse>(req, "AddExternalSAMLIdPCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add an organization node.
        /// </summary>
        /// <param name="req"><see cref="AddOrganizationNodeRequest"/></param>
        /// <returns><see cref="AddOrganizationNodeResponse"/></returns>
        public Task<AddOrganizationNodeResponse> AddOrganizationNode(AddOrganizationNodeRequest req)
        {
            return InternalRequestAsync<AddOrganizationNodeResponse>(req, "AddOrganizationNode");
        }

        /// <summary>
        /// This API is used to add an organization node.
        /// </summary>
        /// <param name="req"><see cref="AddOrganizationNodeRequest"/></param>
        /// <returns><see cref="AddOrganizationNodeResponse"/></returns>
        public AddOrganizationNodeResponse AddOrganizationNodeSync(AddOrganizationNodeRequest req)
        {
            return InternalRequestAsync<AddOrganizationNodeResponse>(req, "AddOrganizationNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add policies to permission configurations.
        /// </summary>
        /// <param name="req"><see cref="AddPermissionPolicyToRoleConfigurationRequest"/></param>
        /// <returns><see cref="AddPermissionPolicyToRoleConfigurationResponse"/></returns>
        public Task<AddPermissionPolicyToRoleConfigurationResponse> AddPermissionPolicyToRoleConfiguration(AddPermissionPolicyToRoleConfigurationRequest req)
        {
            return InternalRequestAsync<AddPermissionPolicyToRoleConfigurationResponse>(req, "AddPermissionPolicyToRoleConfiguration");
        }

        /// <summary>
        /// This API is used to add policies to permission configurations.
        /// </summary>
        /// <param name="req"><see cref="AddPermissionPolicyToRoleConfigurationRequest"/></param>
        /// <returns><see cref="AddPermissionPolicyToRoleConfigurationResponse"/></returns>
        public AddPermissionPolicyToRoleConfigurationResponse AddPermissionPolicyToRoleConfigurationSync(AddPermissionPolicyToRoleConfigurationRequest req)
        {
            return InternalRequestAsync<AddPermissionPolicyToRoleConfigurationResponse>(req, "AddPermissionPolicyToRoleConfiguration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add users to a user group.
        /// </summary>
        /// <param name="req"><see cref="AddUserToGroupRequest"/></param>
        /// <returns><see cref="AddUserToGroupResponse"/></returns>
        public Task<AddUserToGroupResponse> AddUserToGroup(AddUserToGroupRequest req)
        {
            return InternalRequestAsync<AddUserToGroupResponse>(req, "AddUserToGroup");
        }

        /// <summary>
        /// This API is used to add users to a user group.
        /// </summary>
        /// <param name="req"><see cref="AddUserToGroupRequest"/></param>
        /// <returns><see cref="AddUserToGroupResponse"/></returns>
        public AddUserToGroupResponse AddUserToGroupSync(AddUserToGroupRequest req)
        {
            return InternalRequestAsync<AddUserToGroupResponse>(req, "AddUserToGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bind an organization member to a sub-account of the organization admin.
        /// </summary>
        /// <param name="req"><see cref="BindOrganizationMemberAuthAccountRequest"/></param>
        /// <returns><see cref="BindOrganizationMemberAuthAccountResponse"/></returns>
        public Task<BindOrganizationMemberAuthAccountResponse> BindOrganizationMemberAuthAccount(BindOrganizationMemberAuthAccountRequest req)
        {
            return InternalRequestAsync<BindOrganizationMemberAuthAccountResponse>(req, "BindOrganizationMemberAuthAccount");
        }

        /// <summary>
        /// This API is used to bind an organization member to a sub-account of the organization admin.
        /// </summary>
        /// <param name="req"><see cref="BindOrganizationMemberAuthAccountRequest"/></param>
        /// <returns><see cref="BindOrganizationMemberAuthAccountResponse"/></returns>
        public BindOrganizationMemberAuthAccountResponse BindOrganizationMemberAuthAccountSync(BindOrganizationMemberAuthAccountRequest req)
        {
            return InternalRequestAsync<BindOrganizationMemberAuthAccountResponse>(req, "BindOrganizationMemberAuthAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind an organization member from a sub-account of the organization admin.
        /// </summary>
        /// <param name="req"><see cref="CancelOrganizationMemberAuthAccountRequest"/></param>
        /// <returns><see cref="CancelOrganizationMemberAuthAccountResponse"/></returns>
        public Task<CancelOrganizationMemberAuthAccountResponse> CancelOrganizationMemberAuthAccount(CancelOrganizationMemberAuthAccountRequest req)
        {
            return InternalRequestAsync<CancelOrganizationMemberAuthAccountResponse>(req, "CancelOrganizationMemberAuthAccount");
        }

        /// <summary>
        /// This API is used to unbind an organization member from a sub-account of the organization admin.
        /// </summary>
        /// <param name="req"><see cref="CancelOrganizationMemberAuthAccountRequest"/></param>
        /// <returns><see cref="CancelOrganizationMemberAuthAccountResponse"/></returns>
        public CancelOrganizationMemberAuthAccountResponse CancelOrganizationMemberAuthAccountSync(CancelOrganizationMemberAuthAccountRequest req)
        {
            return InternalRequestAsync<CancelOrganizationMemberAuthAccountResponse>(req, "CancelOrganizationMemberAuthAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to clear the SAML identity provider configuration information.
        /// </summary>
        /// <param name="req"><see cref="ClearExternalSAMLIdentityProviderRequest"/></param>
        /// <returns><see cref="ClearExternalSAMLIdentityProviderResponse"/></returns>
        public Task<ClearExternalSAMLIdentityProviderResponse> ClearExternalSAMLIdentityProvider(ClearExternalSAMLIdentityProviderRequest req)
        {
            return InternalRequestAsync<ClearExternalSAMLIdentityProviderResponse>(req, "ClearExternalSAMLIdentityProvider");
        }

        /// <summary>
        /// This API is used to clear the SAML identity provider configuration information.
        /// </summary>
        /// <param name="req"><see cref="ClearExternalSAMLIdentityProviderRequest"/></param>
        /// <returns><see cref="ClearExternalSAMLIdentityProviderResponse"/></returns>
        public ClearExternalSAMLIdentityProviderResponse ClearExternalSAMLIdentityProviderSync(ClearExternalSAMLIdentityProviderRequest req)
        {
            return InternalRequestAsync<ClearExternalSAMLIdentityProviderResponse>(req, "ClearExternalSAMLIdentityProvider")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create user groups.
        /// </summary>
        /// <param name="req"><see cref="CreateGroupRequest"/></param>
        /// <returns><see cref="CreateGroupResponse"/></returns>
        public Task<CreateGroupResponse> CreateGroup(CreateGroupRequest req)
        {
            return InternalRequestAsync<CreateGroupResponse>(req, "CreateGroup");
        }

        /// <summary>
        /// This API is used to create user groups.
        /// </summary>
        /// <param name="req"><see cref="CreateGroupRequest"/></param>
        /// <returns><see cref="CreateGroupResponse"/></returns>
        public CreateGroupResponse CreateGroupSync(CreateGroupRequest req)
        {
            return InternalRequestAsync<CreateGroupResponse>(req, "CreateGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add a delegated admin of the organization service.
        /// </summary>
        /// <param name="req"><see cref="CreateOrgServiceAssignRequest"/></param>
        /// <returns><see cref="CreateOrgServiceAssignResponse"/></returns>
        public Task<CreateOrgServiceAssignResponse> CreateOrgServiceAssign(CreateOrgServiceAssignRequest req)
        {
            return InternalRequestAsync<CreateOrgServiceAssignResponse>(req, "CreateOrgServiceAssign");
        }

        /// <summary>
        /// This API is used to add a delegated admin of the organization service.
        /// </summary>
        /// <param name="req"><see cref="CreateOrgServiceAssignRequest"/></param>
        /// <returns><see cref="CreateOrgServiceAssignResponse"/></returns>
        public CreateOrgServiceAssignResponse CreateOrgServiceAssignSync(CreateOrgServiceAssignRequest req)
        {
            return InternalRequestAsync<CreateOrgServiceAssignResponse>(req, "CreateOrgServiceAssign")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an organization.
        /// </summary>
        /// <param name="req"><see cref="CreateOrganizationRequest"/></param>
        /// <returns><see cref="CreateOrganizationResponse"/></returns>
        public Task<CreateOrganizationResponse> CreateOrganization(CreateOrganizationRequest req)
        {
            return InternalRequestAsync<CreateOrganizationResponse>(req, "CreateOrganization");
        }

        /// <summary>
        /// This API is used to create an organization.
        /// </summary>
        /// <param name="req"><see cref="CreateOrganizationRequest"/></param>
        /// <returns><see cref="CreateOrganizationResponse"/></returns>
        public CreateOrganizationResponse CreateOrganizationSync(CreateOrganizationRequest req)
        {
            return InternalRequestAsync<CreateOrganizationResponse>(req, "CreateOrganization")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add an organization identity.
        /// </summary>
        /// <param name="req"><see cref="CreateOrganizationIdentityRequest"/></param>
        /// <returns><see cref="CreateOrganizationIdentityResponse"/></returns>
        public Task<CreateOrganizationIdentityResponse> CreateOrganizationIdentity(CreateOrganizationIdentityRequest req)
        {
            return InternalRequestAsync<CreateOrganizationIdentityResponse>(req, "CreateOrganizationIdentity");
        }

        /// <summary>
        /// This API is used to add an organization identity.
        /// </summary>
        /// <param name="req"><see cref="CreateOrganizationIdentityRequest"/></param>
        /// <returns><see cref="CreateOrganizationIdentityResponse"/></returns>
        public CreateOrganizationIdentityResponse CreateOrganizationIdentitySync(CreateOrganizationIdentityRequest req)
        {
            return InternalRequestAsync<CreateOrganizationIdentityResponse>(req, "CreateOrganizationIdentity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an organization member.
        /// </summary>
        /// <param name="req"><see cref="CreateOrganizationMemberRequest"/></param>
        /// <returns><see cref="CreateOrganizationMemberResponse"/></returns>
        public Task<CreateOrganizationMemberResponse> CreateOrganizationMember(CreateOrganizationMemberRequest req)
        {
            return InternalRequestAsync<CreateOrganizationMemberResponse>(req, "CreateOrganizationMember");
        }

        /// <summary>
        /// This API is used to create an organization member.
        /// </summary>
        /// <param name="req"><see cref="CreateOrganizationMemberRequest"/></param>
        /// <returns><see cref="CreateOrganizationMemberResponse"/></returns>
        public CreateOrganizationMemberResponse CreateOrganizationMemberSync(CreateOrganizationMemberRequest req)
        {
            return InternalRequestAsync<CreateOrganizationMemberResponse>(req, "CreateOrganizationMember")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add organization member access authorization.
        /// </summary>
        /// <param name="req"><see cref="CreateOrganizationMemberAuthIdentityRequest"/></param>
        /// <returns><see cref="CreateOrganizationMemberAuthIdentityResponse"/></returns>
        public Task<CreateOrganizationMemberAuthIdentityResponse> CreateOrganizationMemberAuthIdentity(CreateOrganizationMemberAuthIdentityRequest req)
        {
            return InternalRequestAsync<CreateOrganizationMemberAuthIdentityResponse>(req, "CreateOrganizationMemberAuthIdentity");
        }

        /// <summary>
        /// This API is used to add organization member access authorization.
        /// </summary>
        /// <param name="req"><see cref="CreateOrganizationMemberAuthIdentityRequest"/></param>
        /// <returns><see cref="CreateOrganizationMemberAuthIdentityResponse"/></returns>
        public CreateOrganizationMemberAuthIdentityResponse CreateOrganizationMemberAuthIdentitySync(CreateOrganizationMemberAuthIdentityRequest req)
        {
            return InternalRequestAsync<CreateOrganizationMemberAuthIdentityResponse>(req, "CreateOrganizationMemberAuthIdentity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an organization member access authorization policy.
        /// </summary>
        /// <param name="req"><see cref="CreateOrganizationMemberPolicyRequest"/></param>
        /// <returns><see cref="CreateOrganizationMemberPolicyResponse"/></returns>
        public Task<CreateOrganizationMemberPolicyResponse> CreateOrganizationMemberPolicy(CreateOrganizationMemberPolicyRequest req)
        {
            return InternalRequestAsync<CreateOrganizationMemberPolicyResponse>(req, "CreateOrganizationMemberPolicy");
        }

        /// <summary>
        /// This API is used to create an organization member access authorization policy.
        /// </summary>
        /// <param name="req"><see cref="CreateOrganizationMemberPolicyRequest"/></param>
        /// <returns><see cref="CreateOrganizationMemberPolicyResponse"/></returns>
        public CreateOrganizationMemberPolicyResponse CreateOrganizationMemberPolicySync(CreateOrganizationMemberPolicyRequest req)
        {
            return InternalRequestAsync<CreateOrganizationMemberPolicyResponse>(req, "CreateOrganizationMemberPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an organization member access policy.
        /// </summary>
        /// <param name="req"><see cref="CreateOrganizationMembersPolicyRequest"/></param>
        /// <returns><see cref="CreateOrganizationMembersPolicyResponse"/></returns>
        public Task<CreateOrganizationMembersPolicyResponse> CreateOrganizationMembersPolicy(CreateOrganizationMembersPolicyRequest req)
        {
            return InternalRequestAsync<CreateOrganizationMembersPolicyResponse>(req, "CreateOrganizationMembersPolicy");
        }

        /// <summary>
        /// This API is used to create an organization member access policy.
        /// </summary>
        /// <param name="req"><see cref="CreateOrganizationMembersPolicyRequest"/></param>
        /// <returns><see cref="CreateOrganizationMembersPolicyResponse"/></returns>
        public CreateOrganizationMembersPolicyResponse CreateOrganizationMembersPolicySync(CreateOrganizationMembersPolicyRequest req)
        {
            return InternalRequestAsync<CreateOrganizationMembersPolicyResponse>(req, "CreateOrganizationMembersPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to grant authorizations on member accounts.
        /// </summary>
        /// <param name="req"><see cref="CreateRoleAssignmentRequest"/></param>
        /// <returns><see cref="CreateRoleAssignmentResponse"/></returns>
        public Task<CreateRoleAssignmentResponse> CreateRoleAssignment(CreateRoleAssignmentRequest req)
        {
            return InternalRequestAsync<CreateRoleAssignmentResponse>(req, "CreateRoleAssignment");
        }

        /// <summary>
        /// This API is used to grant authorizations on member accounts.
        /// </summary>
        /// <param name="req"><see cref="CreateRoleAssignmentRequest"/></param>
        /// <returns><see cref="CreateRoleAssignmentResponse"/></returns>
        public CreateRoleAssignmentResponse CreateRoleAssignmentSync(CreateRoleAssignmentRequest req)
        {
            return InternalRequestAsync<CreateRoleAssignmentResponse>(req, "CreateRoleAssignment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create permission configurations.
        /// </summary>
        /// <param name="req"><see cref="CreateRoleConfigurationRequest"/></param>
        /// <returns><see cref="CreateRoleConfigurationResponse"/></returns>
        public Task<CreateRoleConfigurationResponse> CreateRoleConfiguration(CreateRoleConfigurationRequest req)
        {
            return InternalRequestAsync<CreateRoleConfigurationResponse>(req, "CreateRoleConfiguration");
        }

        /// <summary>
        /// This API is used to create permission configurations.
        /// </summary>
        /// <param name="req"><see cref="CreateRoleConfigurationRequest"/></param>
        /// <returns><see cref="CreateRoleConfigurationResponse"/></returns>
        public CreateRoleConfigurationResponse CreateRoleConfigurationSync(CreateRoleConfigurationRequest req)
        {
            return InternalRequestAsync<CreateRoleConfigurationResponse>(req, "CreateRoleConfiguration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a SCIM key.
        /// </summary>
        /// <param name="req"><see cref="CreateSCIMCredentialRequest"/></param>
        /// <returns><see cref="CreateSCIMCredentialResponse"/></returns>
        public Task<CreateSCIMCredentialResponse> CreateSCIMCredential(CreateSCIMCredentialRequest req)
        {
            return InternalRequestAsync<CreateSCIMCredentialResponse>(req, "CreateSCIMCredential");
        }

        /// <summary>
        /// This API is used to create a SCIM key.
        /// </summary>
        /// <param name="req"><see cref="CreateSCIMCredentialRequest"/></param>
        /// <returns><see cref="CreateSCIMCredentialResponse"/></returns>
        public CreateSCIMCredentialResponse CreateSCIMCredentialSync(CreateSCIMCredentialRequest req)
        {
            return InternalRequestAsync<CreateSCIMCredentialResponse>(req, "CreateSCIMCredential")
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
        /// This API is used to create sub-user synchronization tasks.
        /// </summary>
        /// <param name="req"><see cref="CreateUserSyncProvisioningRequest"/></param>
        /// <returns><see cref="CreateUserSyncProvisioningResponse"/></returns>
        public Task<CreateUserSyncProvisioningResponse> CreateUserSyncProvisioning(CreateUserSyncProvisioningRequest req)
        {
            return InternalRequestAsync<CreateUserSyncProvisioningResponse>(req, "CreateUserSyncProvisioning");
        }

        /// <summary>
        /// This API is used to create sub-user synchronization tasks.
        /// </summary>
        /// <param name="req"><see cref="CreateUserSyncProvisioningRequest"/></param>
        /// <returns><see cref="CreateUserSyncProvisioningResponse"/></returns>
        public CreateUserSyncProvisioningResponse CreateUserSyncProvisioningSync(CreateUserSyncProvisioningRequest req)
        {
            return InternalRequestAsync<CreateUserSyncProvisioningResponse>(req, "CreateUserSyncProvisioning")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete user groups.
        /// </summary>
        /// <param name="req"><see cref="DeleteGroupRequest"/></param>
        /// <returns><see cref="DeleteGroupResponse"/></returns>
        public Task<DeleteGroupResponse> DeleteGroup(DeleteGroupRequest req)
        {
            return InternalRequestAsync<DeleteGroupResponse>(req, "DeleteGroup");
        }

        /// <summary>
        /// This API is used to delete user groups.
        /// </summary>
        /// <param name="req"><see cref="DeleteGroupRequest"/></param>
        /// <returns><see cref="DeleteGroupResponse"/></returns>
        public DeleteGroupResponse DeleteGroupSync(DeleteGroupRequest req)
        {
            return InternalRequestAsync<DeleteGroupResponse>(req, "DeleteGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a delegated admin of the organization service.
        /// </summary>
        /// <param name="req"><see cref="DeleteOrgServiceAssignRequest"/></param>
        /// <returns><see cref="DeleteOrgServiceAssignResponse"/></returns>
        public Task<DeleteOrgServiceAssignResponse> DeleteOrgServiceAssign(DeleteOrgServiceAssignRequest req)
        {
            return InternalRequestAsync<DeleteOrgServiceAssignResponse>(req, "DeleteOrgServiceAssign");
        }

        /// <summary>
        /// This API is used to delete a delegated admin of the organization service.
        /// </summary>
        /// <param name="req"><see cref="DeleteOrgServiceAssignRequest"/></param>
        /// <returns><see cref="DeleteOrgServiceAssignResponse"/></returns>
        public DeleteOrgServiceAssignResponse DeleteOrgServiceAssignSync(DeleteOrgServiceAssignRequest req)
        {
            return InternalRequestAsync<DeleteOrgServiceAssignResponse>(req, "DeleteOrgServiceAssign")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an organization.
        /// </summary>
        /// <param name="req"><see cref="DeleteOrganizationRequest"/></param>
        /// <returns><see cref="DeleteOrganizationResponse"/></returns>
        public Task<DeleteOrganizationResponse> DeleteOrganization(DeleteOrganizationRequest req)
        {
            return InternalRequestAsync<DeleteOrganizationResponse>(req, "DeleteOrganization");
        }

        /// <summary>
        /// This API is used to delete an organization.
        /// </summary>
        /// <param name="req"><see cref="DeleteOrganizationRequest"/></param>
        /// <returns><see cref="DeleteOrganizationResponse"/></returns>
        public DeleteOrganizationResponse DeleteOrganizationSync(DeleteOrganizationRequest req)
        {
            return InternalRequestAsync<DeleteOrganizationResponse>(req, "DeleteOrganization")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an organization identity.
        /// </summary>
        /// <param name="req"><see cref="DeleteOrganizationIdentityRequest"/></param>
        /// <returns><see cref="DeleteOrganizationIdentityResponse"/></returns>
        public Task<DeleteOrganizationIdentityResponse> DeleteOrganizationIdentity(DeleteOrganizationIdentityRequest req)
        {
            return InternalRequestAsync<DeleteOrganizationIdentityResponse>(req, "DeleteOrganizationIdentity");
        }

        /// <summary>
        /// This API is used to delete an organization identity.
        /// </summary>
        /// <param name="req"><see cref="DeleteOrganizationIdentityRequest"/></param>
        /// <returns><see cref="DeleteOrganizationIdentityResponse"/></returns>
        public DeleteOrganizationIdentityResponse DeleteOrganizationIdentitySync(DeleteOrganizationIdentityRequest req)
        {
            return InternalRequestAsync<DeleteOrganizationIdentityResponse>(req, "DeleteOrganizationIdentity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete organization member access authorization.
        /// </summary>
        /// <param name="req"><see cref="DeleteOrganizationMemberAuthIdentityRequest"/></param>
        /// <returns><see cref="DeleteOrganizationMemberAuthIdentityResponse"/></returns>
        public Task<DeleteOrganizationMemberAuthIdentityResponse> DeleteOrganizationMemberAuthIdentity(DeleteOrganizationMemberAuthIdentityRequest req)
        {
            return InternalRequestAsync<DeleteOrganizationMemberAuthIdentityResponse>(req, "DeleteOrganizationMemberAuthIdentity");
        }

        /// <summary>
        /// This API is used to delete organization member access authorization.
        /// </summary>
        /// <param name="req"><see cref="DeleteOrganizationMemberAuthIdentityRequest"/></param>
        /// <returns><see cref="DeleteOrganizationMemberAuthIdentityResponse"/></returns>
        public DeleteOrganizationMemberAuthIdentityResponse DeleteOrganizationMemberAuthIdentitySync(DeleteOrganizationMemberAuthIdentityRequest req)
        {
            return InternalRequestAsync<DeleteOrganizationMemberAuthIdentityResponse>(req, "DeleteOrganizationMemberAuthIdentity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to remove a member account from the organization, rather than delete the account.
        /// </summary>
        /// <param name="req"><see cref="DeleteOrganizationMembersRequest"/></param>
        /// <returns><see cref="DeleteOrganizationMembersResponse"/></returns>
        public Task<DeleteOrganizationMembersResponse> DeleteOrganizationMembers(DeleteOrganizationMembersRequest req)
        {
            return InternalRequestAsync<DeleteOrganizationMembersResponse>(req, "DeleteOrganizationMembers");
        }

        /// <summary>
        /// This API is used to remove a member account from the organization, rather than delete the account.
        /// </summary>
        /// <param name="req"><see cref="DeleteOrganizationMembersRequest"/></param>
        /// <returns><see cref="DeleteOrganizationMembersResponse"/></returns>
        public DeleteOrganizationMembersResponse DeleteOrganizationMembersSync(DeleteOrganizationMembersRequest req)
        {
            return InternalRequestAsync<DeleteOrganizationMembersResponse>(req, "DeleteOrganizationMembers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an organization member access policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteOrganizationMembersPolicyRequest"/></param>
        /// <returns><see cref="DeleteOrganizationMembersPolicyResponse"/></returns>
        public Task<DeleteOrganizationMembersPolicyResponse> DeleteOrganizationMembersPolicy(DeleteOrganizationMembersPolicyRequest req)
        {
            return InternalRequestAsync<DeleteOrganizationMembersPolicyResponse>(req, "DeleteOrganizationMembersPolicy");
        }

        /// <summary>
        /// This API is used to delete an organization member access policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteOrganizationMembersPolicyRequest"/></param>
        /// <returns><see cref="DeleteOrganizationMembersPolicyResponse"/></returns>
        public DeleteOrganizationMembersPolicyResponse DeleteOrganizationMembersPolicySync(DeleteOrganizationMembersPolicyRequest req)
        {
            return InternalRequestAsync<DeleteOrganizationMembersPolicyResponse>(req, "DeleteOrganizationMembersPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch delete organization nodes.
        /// </summary>
        /// <param name="req"><see cref="DeleteOrganizationNodesRequest"/></param>
        /// <returns><see cref="DeleteOrganizationNodesResponse"/></returns>
        public Task<DeleteOrganizationNodesResponse> DeleteOrganizationNodes(DeleteOrganizationNodesRequest req)
        {
            return InternalRequestAsync<DeleteOrganizationNodesResponse>(req, "DeleteOrganizationNodes");
        }

        /// <summary>
        /// This API is used to batch delete organization nodes.
        /// </summary>
        /// <param name="req"><see cref="DeleteOrganizationNodesRequest"/></param>
        /// <returns><see cref="DeleteOrganizationNodesResponse"/></returns>
        public DeleteOrganizationNodesResponse DeleteOrganizationNodesSync(DeleteOrganizationNodesRequest req)
        {
            return InternalRequestAsync<DeleteOrganizationNodesResponse>(req, "DeleteOrganizationNodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to remove authorizations on member accounts.
        /// </summary>
        /// <param name="req"><see cref="DeleteRoleAssignmentRequest"/></param>
        /// <returns><see cref="DeleteRoleAssignmentResponse"/></returns>
        public Task<DeleteRoleAssignmentResponse> DeleteRoleAssignment(DeleteRoleAssignmentRequest req)
        {
            return InternalRequestAsync<DeleteRoleAssignmentResponse>(req, "DeleteRoleAssignment");
        }

        /// <summary>
        /// This API is used to remove authorizations on member accounts.
        /// </summary>
        /// <param name="req"><see cref="DeleteRoleAssignmentRequest"/></param>
        /// <returns><see cref="DeleteRoleAssignmentResponse"/></returns>
        public DeleteRoleAssignmentResponse DeleteRoleAssignmentSync(DeleteRoleAssignmentRequest req)
        {
            return InternalRequestAsync<DeleteRoleAssignmentResponse>(req, "DeleteRoleAssignment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the permission configuration information.
        /// </summary>
        /// <param name="req"><see cref="DeleteRoleConfigurationRequest"/></param>
        /// <returns><see cref="DeleteRoleConfigurationResponse"/></returns>
        public Task<DeleteRoleConfigurationResponse> DeleteRoleConfiguration(DeleteRoleConfigurationRequest req)
        {
            return InternalRequestAsync<DeleteRoleConfigurationResponse>(req, "DeleteRoleConfiguration");
        }

        /// <summary>
        /// This API is used to delete the permission configuration information.
        /// </summary>
        /// <param name="req"><see cref="DeleteRoleConfigurationRequest"/></param>
        /// <returns><see cref="DeleteRoleConfigurationResponse"/></returns>
        public DeleteRoleConfigurationResponse DeleteRoleConfigurationSync(DeleteRoleConfigurationRequest req)
        {
            return InternalRequestAsync<DeleteRoleConfigurationResponse>(req, "DeleteRoleConfiguration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a SCIM key.
        /// </summary>
        /// <param name="req"><see cref="DeleteSCIMCredentialRequest"/></param>
        /// <returns><see cref="DeleteSCIMCredentialResponse"/></returns>
        public Task<DeleteSCIMCredentialResponse> DeleteSCIMCredential(DeleteSCIMCredentialRequest req)
        {
            return InternalRequestAsync<DeleteSCIMCredentialResponse>(req, "DeleteSCIMCredential");
        }

        /// <summary>
        /// This API is used to delete a SCIM key.
        /// </summary>
        /// <param name="req"><see cref="DeleteSCIMCredentialRequest"/></param>
        /// <returns><see cref="DeleteSCIMCredentialResponse"/></returns>
        public DeleteSCIMCredentialResponse DeleteSCIMCredentialSync(DeleteSCIMCredentialRequest req)
        {
            return InternalRequestAsync<DeleteSCIMCredentialResponse>(req, "DeleteSCIMCredential")
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
        /// This API is used to delete sub-user synchronization tasks.
        /// </summary>
        /// <param name="req"><see cref="DeleteUserSyncProvisioningRequest"/></param>
        /// <returns><see cref="DeleteUserSyncProvisioningResponse"/></returns>
        public Task<DeleteUserSyncProvisioningResponse> DeleteUserSyncProvisioning(DeleteUserSyncProvisioningRequest req)
        {
            return InternalRequestAsync<DeleteUserSyncProvisioningResponse>(req, "DeleteUserSyncProvisioning");
        }

        /// <summary>
        /// This API is used to delete sub-user synchronization tasks.
        /// </summary>
        /// <param name="req"><see cref="DeleteUserSyncProvisioningRequest"/></param>
        /// <returns><see cref="DeleteUserSyncProvisioningResponse"/></returns>
        public DeleteUserSyncProvisioningResponse DeleteUserSyncProvisioningSync(DeleteUserSyncProvisioningRequest req)
        {
            return InternalRequestAsync<DeleteUserSyncProvisioningResponse>(req, "DeleteUserSyncProvisioning")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain TCO Identity Center service information.
        /// </summary>
        /// <param name="req"><see cref="DescribeIdentityCenterRequest"/></param>
        /// <returns><see cref="DescribeIdentityCenterResponse"/></returns>
        public Task<DescribeIdentityCenterResponse> DescribeIdentityCenter(DescribeIdentityCenterRequest req)
        {
            return InternalRequestAsync<DescribeIdentityCenterResponse>(req, "DescribeIdentityCenter");
        }

        /// <summary>
        /// This API is used to obtain TCO Identity Center service information.
        /// </summary>
        /// <param name="req"><see cref="DescribeIdentityCenterRequest"/></param>
        /// <returns><see cref="DescribeIdentityCenterResponse"/></returns>
        public DescribeIdentityCenterResponse DescribeIdentityCenterSync(DescribeIdentityCenterRequest req)
        {
            return InternalRequestAsync<DescribeIdentityCenterResponse>(req, "DescribeIdentityCenter")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the organization information.
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationRequest"/></param>
        /// <returns><see cref="DescribeOrganizationResponse"/></returns>
        public Task<DescribeOrganizationResponse> DescribeOrganization(DescribeOrganizationRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationResponse>(req, "DescribeOrganization");
        }

        /// <summary>
        /// This API is used to get the organization information.
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationRequest"/></param>
        /// <returns><see cref="DescribeOrganizationResponse"/></returns>
        public DescribeOrganizationResponse DescribeOrganizationSync(DescribeOrganizationRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationResponse>(req, "DescribeOrganization")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of sub-accounts bound to an organization member.
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationMemberAuthAccountsRequest"/></param>
        /// <returns><see cref="DescribeOrganizationMemberAuthAccountsResponse"/></returns>
        public Task<DescribeOrganizationMemberAuthAccountsResponse> DescribeOrganizationMemberAuthAccounts(DescribeOrganizationMemberAuthAccountsRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationMemberAuthAccountsResponse>(req, "DescribeOrganizationMemberAuthAccounts");
        }

        /// <summary>
        /// This API is used to get the list of sub-accounts bound to an organization member.
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationMemberAuthAccountsRequest"/></param>
        /// <returns><see cref="DescribeOrganizationMemberAuthAccountsResponse"/></returns>
        public DescribeOrganizationMemberAuthAccountsResponse DescribeOrganizationMemberAuthAccountsSync(DescribeOrganizationMemberAuthAccountsRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationMemberAuthAccountsResponse>(req, "DescribeOrganizationMemberAuthAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of organization member access authorization.
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationMemberAuthIdentitiesRequest"/></param>
        /// <returns><see cref="DescribeOrganizationMemberAuthIdentitiesResponse"/></returns>
        public Task<DescribeOrganizationMemberAuthIdentitiesResponse> DescribeOrganizationMemberAuthIdentities(DescribeOrganizationMemberAuthIdentitiesRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationMemberAuthIdentitiesResponse>(req, "DescribeOrganizationMemberAuthIdentities");
        }

        /// <summary>
        /// This API is used to obtain the list of organization member access authorization.
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationMemberAuthIdentitiesRequest"/></param>
        /// <returns><see cref="DescribeOrganizationMemberAuthIdentitiesResponse"/></returns>
        public DescribeOrganizationMemberAuthIdentitiesResponse DescribeOrganizationMemberAuthIdentitiesSync(DescribeOrganizationMemberAuthIdentitiesRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationMemberAuthIdentitiesResponse>(req, "DescribeOrganizationMemberAuthIdentities")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of authorization policies of an organization member.
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationMemberPoliciesRequest"/></param>
        /// <returns><see cref="DescribeOrganizationMemberPoliciesResponse"/></returns>
        public Task<DescribeOrganizationMemberPoliciesResponse> DescribeOrganizationMemberPolicies(DescribeOrganizationMemberPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationMemberPoliciesResponse>(req, "DescribeOrganizationMemberPolicies");
        }

        /// <summary>
        /// This API is used to get the list of authorization policies of an organization member.
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationMemberPoliciesRequest"/></param>
        /// <returns><see cref="DescribeOrganizationMemberPoliciesResponse"/></returns>
        public DescribeOrganizationMemberPoliciesResponse DescribeOrganizationMemberPoliciesSync(DescribeOrganizationMemberPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationMemberPoliciesResponse>(req, "DescribeOrganizationMemberPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of organization members.
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationMembersRequest"/></param>
        /// <returns><see cref="DescribeOrganizationMembersResponse"/></returns>
        public Task<DescribeOrganizationMembersResponse> DescribeOrganizationMembers(DescribeOrganizationMembersRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationMembersResponse>(req, "DescribeOrganizationMembers");
        }

        /// <summary>
        /// This API is used to get the list of organization members.
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationMembersRequest"/></param>
        /// <returns><see cref="DescribeOrganizationMembersResponse"/></returns>
        public DescribeOrganizationMembersResponse DescribeOrganizationMembersSync(DescribeOrganizationMembersRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationMembersResponse>(req, "DescribeOrganizationMembers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of organization nodes.
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationNodesRequest"/></param>
        /// <returns><see cref="DescribeOrganizationNodesResponse"/></returns>
        public Task<DescribeOrganizationNodesResponse> DescribeOrganizationNodes(DescribeOrganizationNodesRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationNodesResponse>(req, "DescribeOrganizationNodes");
        }

        /// <summary>
        /// This API is used to get the list of organization nodes.
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationNodesRequest"/></param>
        /// <returns><see cref="DescribeOrganizationNodesResponse"/></returns>
        public DescribeOrganizationNodesResponse DescribeOrganizationNodesSync(DescribeOrganizationNodesRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationNodesResponse>(req, "DescribeOrganizationNodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to undeploy permission configurations on member accounts.
        /// </summary>
        /// <param name="req"><see cref="DismantleRoleConfigurationRequest"/></param>
        /// <returns><see cref="DismantleRoleConfigurationResponse"/></returns>
        public Task<DismantleRoleConfigurationResponse> DismantleRoleConfiguration(DismantleRoleConfigurationRequest req)
        {
            return InternalRequestAsync<DismantleRoleConfigurationResponse>(req, "DismantleRoleConfiguration");
        }

        /// <summary>
        /// This API is used to undeploy permission configurations on member accounts.
        /// </summary>
        /// <param name="req"><see cref="DismantleRoleConfigurationRequest"/></param>
        /// <returns><see cref="DismantleRoleConfigurationResponse"/></returns>
        public DismantleRoleConfigurationResponse DismantleRoleConfigurationSync(DismantleRoleConfigurationRequest req)
        {
            return InternalRequestAsync<DismantleRoleConfigurationResponse>(req, "DismantleRoleConfiguration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the SAML identity provider configuration information.
        /// </summary>
        /// <param name="req"><see cref="GetExternalSAMLIdentityProviderRequest"/></param>
        /// <returns><see cref="GetExternalSAMLIdentityProviderResponse"/></returns>
        public Task<GetExternalSAMLIdentityProviderResponse> GetExternalSAMLIdentityProvider(GetExternalSAMLIdentityProviderRequest req)
        {
            return InternalRequestAsync<GetExternalSAMLIdentityProviderResponse>(req, "GetExternalSAMLIdentityProvider");
        }

        /// <summary>
        /// This API is used to query the SAML identity provider configuration information.
        /// </summary>
        /// <param name="req"><see cref="GetExternalSAMLIdentityProviderRequest"/></param>
        /// <returns><see cref="GetExternalSAMLIdentityProviderResponse"/></returns>
        public GetExternalSAMLIdentityProviderResponse GetExternalSAMLIdentityProviderSync(GetExternalSAMLIdentityProviderRequest req)
        {
            return InternalRequestAsync<GetExternalSAMLIdentityProviderResponse>(req, "GetExternalSAMLIdentityProvider")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the user group information.
        /// </summary>
        /// <param name="req"><see cref="GetGroupRequest"/></param>
        /// <returns><see cref="GetGroupResponse"/></returns>
        public Task<GetGroupResponse> GetGroup(GetGroupRequest req)
        {
            return InternalRequestAsync<GetGroupResponse>(req, "GetGroup");
        }

        /// <summary>
        /// This API is used to query the user group information.
        /// </summary>
        /// <param name="req"><see cref="GetGroupRequest"/></param>
        /// <returns><see cref="GetGroupResponse"/></returns>
        public GetGroupResponse GetGroupSync(GetGroupRequest req)
        {
            return InternalRequestAsync<GetGroupResponse>(req, "GetGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the status of async tasks of user synchronization.
        /// </summary>
        /// <param name="req"><see cref="GetProvisioningTaskStatusRequest"/></param>
        /// <returns><see cref="GetProvisioningTaskStatusResponse"/></returns>
        public Task<GetProvisioningTaskStatusResponse> GetProvisioningTaskStatus(GetProvisioningTaskStatusRequest req)
        {
            return InternalRequestAsync<GetProvisioningTaskStatusResponse>(req, "GetProvisioningTaskStatus");
        }

        /// <summary>
        /// This API is used to query the status of async tasks of user synchronization.
        /// </summary>
        /// <param name="req"><see cref="GetProvisioningTaskStatusRequest"/></param>
        /// <returns><see cref="GetProvisioningTaskStatusResponse"/></returns>
        public GetProvisioningTaskStatusResponse GetProvisioningTaskStatusSync(GetProvisioningTaskStatusRequest req)
        {
            return InternalRequestAsync<GetProvisioningTaskStatusResponse>(req, "GetProvisioningTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the permission configuration information.
        /// </summary>
        /// <param name="req"><see cref="GetRoleConfigurationRequest"/></param>
        /// <returns><see cref="GetRoleConfigurationResponse"/></returns>
        public Task<GetRoleConfigurationResponse> GetRoleConfiguration(GetRoleConfigurationRequest req)
        {
            return InternalRequestAsync<GetRoleConfigurationResponse>(req, "GetRoleConfiguration");
        }

        /// <summary>
        /// This API is used to query the permission configuration information.
        /// </summary>
        /// <param name="req"><see cref="GetRoleConfigurationRequest"/></param>
        /// <returns><see cref="GetRoleConfigurationResponse"/></returns>
        public GetRoleConfigurationResponse GetRoleConfigurationSync(GetRoleConfigurationRequest req)
        {
            return InternalRequestAsync<GetRoleConfigurationResponse>(req, "GetRoleConfiguration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query SCIM synchronization status.
        /// </summary>
        /// <param name="req"><see cref="GetSCIMSynchronizationStatusRequest"/></param>
        /// <returns><see cref="GetSCIMSynchronizationStatusResponse"/></returns>
        public Task<GetSCIMSynchronizationStatusResponse> GetSCIMSynchronizationStatus(GetSCIMSynchronizationStatusRequest req)
        {
            return InternalRequestAsync<GetSCIMSynchronizationStatusResponse>(req, "GetSCIMSynchronizationStatus");
        }

        /// <summary>
        /// This API is used to query SCIM synchronization status.
        /// </summary>
        /// <param name="req"><see cref="GetSCIMSynchronizationStatusRequest"/></param>
        /// <returns><see cref="GetSCIMSynchronizationStatusResponse"/></returns>
        public GetSCIMSynchronizationStatusResponse GetSCIMSynchronizationStatusSync(GetSCIMSynchronizationStatusRequest req)
        {
            return InternalRequestAsync<GetSCIMSynchronizationStatusResponse>(req, "GetSCIMSynchronizationStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the status of async tasks.
        /// </summary>
        /// <param name="req"><see cref="GetTaskStatusRequest"/></param>
        /// <returns><see cref="GetTaskStatusResponse"/></returns>
        public Task<GetTaskStatusResponse> GetTaskStatus(GetTaskStatusRequest req)
        {
            return InternalRequestAsync<GetTaskStatusResponse>(req, "GetTaskStatus");
        }

        /// <summary>
        /// This API is used to query the status of async tasks.
        /// </summary>
        /// <param name="req"><see cref="GetTaskStatusRequest"/></param>
        /// <returns><see cref="GetTaskStatusResponse"/></returns>
        public GetTaskStatusResponse GetTaskStatusSync(GetTaskStatusRequest req)
        {
            return InternalRequestAsync<GetTaskStatusResponse>(req, "GetTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the user information.
        /// </summary>
        /// <param name="req"><see cref="GetUserRequest"/></param>
        /// <returns><see cref="GetUserResponse"/></returns>
        public Task<GetUserResponse> GetUser(GetUserRequest req)
        {
            return InternalRequestAsync<GetUserResponse>(req, "GetUser");
        }

        /// <summary>
        /// This API is used to query the user information.
        /// </summary>
        /// <param name="req"><see cref="GetUserRequest"/></param>
        /// <returns><see cref="GetUserResponse"/></returns>
        public GetUserResponse GetUserSync(GetUserRequest req)
        {
            return InternalRequestAsync<GetUserResponse>(req, "GetUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the CAM user synchronization.
        /// </summary>
        /// <param name="req"><see cref="GetUserSyncProvisioningRequest"/></param>
        /// <returns><see cref="GetUserSyncProvisioningResponse"/></returns>
        public Task<GetUserSyncProvisioningResponse> GetUserSyncProvisioning(GetUserSyncProvisioningRequest req)
        {
            return InternalRequestAsync<GetUserSyncProvisioningResponse>(req, "GetUserSyncProvisioning");
        }

        /// <summary>
        /// This API is used to query the CAM user synchronization.
        /// </summary>
        /// <param name="req"><see cref="GetUserSyncProvisioningRequest"/></param>
        /// <returns><see cref="GetUserSyncProvisioningResponse"/></returns>
        public GetUserSyncProvisioningResponse GetUserSyncProvisioningSync(GetUserSyncProvisioningRequest req)
        {
            return InternalRequestAsync<GetUserSyncProvisioningResponse>(req, "GetUserSyncProvisioning")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the SAML service provider configuration information.
        /// </summary>
        /// <param name="req"><see cref="GetZoneSAMLServiceProviderInfoRequest"/></param>
        /// <returns><see cref="GetZoneSAMLServiceProviderInfoResponse"/></returns>
        public Task<GetZoneSAMLServiceProviderInfoResponse> GetZoneSAMLServiceProviderInfo(GetZoneSAMLServiceProviderInfoRequest req)
        {
            return InternalRequestAsync<GetZoneSAMLServiceProviderInfoResponse>(req, "GetZoneSAMLServiceProviderInfo");
        }

        /// <summary>
        /// This API is used to query the SAML service provider configuration information.
        /// </summary>
        /// <param name="req"><see cref="GetZoneSAMLServiceProviderInfoRequest"/></param>
        /// <returns><see cref="GetZoneSAMLServiceProviderInfoResponse"/></returns>
        public GetZoneSAMLServiceProviderInfoResponse GetZoneSAMLServiceProviderInfoSync(GetZoneSAMLServiceProviderInfoRequest req)
        {
            return InternalRequestAsync<GetZoneSAMLServiceProviderInfoResponse>(req, "GetZoneSAMLServiceProviderInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query space statistics.
        /// </summary>
        /// <param name="req"><see cref="GetZoneStatisticsRequest"/></param>
        /// <returns><see cref="GetZoneStatisticsResponse"/></returns>
        public Task<GetZoneStatisticsResponse> GetZoneStatistics(GetZoneStatisticsRequest req)
        {
            return InternalRequestAsync<GetZoneStatisticsResponse>(req, "GetZoneStatistics");
        }

        /// <summary>
        /// This API is used to query space statistics.
        /// </summary>
        /// <param name="req"><see cref="GetZoneStatisticsRequest"/></param>
        /// <returns><see cref="GetZoneStatisticsResponse"/></returns>
        public GetZoneStatisticsResponse GetZoneStatisticsSync(GetZoneStatisticsRequest req)
        {
            return InternalRequestAsync<GetZoneStatisticsResponse>(req, "GetZoneStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to invite a member.
        /// </summary>
        /// <param name="req"><see cref="InviteOrganizationMemberRequest"/></param>
        /// <returns><see cref="InviteOrganizationMemberResponse"/></returns>
        public Task<InviteOrganizationMemberResponse> InviteOrganizationMember(InviteOrganizationMemberRequest req)
        {
            return InternalRequestAsync<InviteOrganizationMemberResponse>(req, "InviteOrganizationMember");
        }

        /// <summary>
        /// This API is used to invite a member.
        /// </summary>
        /// <param name="req"><see cref="InviteOrganizationMemberRequest"/></param>
        /// <returns><see cref="InviteOrganizationMemberResponse"/></returns>
        public InviteOrganizationMemberResponse InviteOrganizationMemberSync(InviteOrganizationMemberRequest req)
        {
            return InternalRequestAsync<InviteOrganizationMemberResponse>(req, "InviteOrganizationMember")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the SAML signing certificate list.
        /// </summary>
        /// <param name="req"><see cref="ListExternalSAMLIdPCertificatesRequest"/></param>
        /// <returns><see cref="ListExternalSAMLIdPCertificatesResponse"/></returns>
        public Task<ListExternalSAMLIdPCertificatesResponse> ListExternalSAMLIdPCertificates(ListExternalSAMLIdPCertificatesRequest req)
        {
            return InternalRequestAsync<ListExternalSAMLIdPCertificatesResponse>(req, "ListExternalSAMLIdPCertificates");
        }

        /// <summary>
        /// This API is used to query the SAML signing certificate list.
        /// </summary>
        /// <param name="req"><see cref="ListExternalSAMLIdPCertificatesRequest"/></param>
        /// <returns><see cref="ListExternalSAMLIdPCertificatesResponse"/></returns>
        public ListExternalSAMLIdPCertificatesResponse ListExternalSAMLIdPCertificatesSync(ListExternalSAMLIdPCertificatesRequest req)
        {
            return InternalRequestAsync<ListExternalSAMLIdPCertificatesResponse>(req, "ListExternalSAMLIdPCertificates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the user list of the user group.
        /// </summary>
        /// <param name="req"><see cref="ListGroupMembersRequest"/></param>
        /// <returns><see cref="ListGroupMembersResponse"/></returns>
        public Task<ListGroupMembersResponse> ListGroupMembers(ListGroupMembersRequest req)
        {
            return InternalRequestAsync<ListGroupMembersResponse>(req, "ListGroupMembers");
        }

        /// <summary>
        /// This API is used to query the user list of the user group.
        /// </summary>
        /// <param name="req"><see cref="ListGroupMembersRequest"/></param>
        /// <returns><see cref="ListGroupMembersResponse"/></returns>
        public ListGroupMembersResponse ListGroupMembersSync(ListGroupMembersRequest req)
        {
            return InternalRequestAsync<ListGroupMembersResponse>(req, "ListGroupMembers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the user group list.
        /// </summary>
        /// <param name="req"><see cref="ListGroupsRequest"/></param>
        /// <returns><see cref="ListGroupsResponse"/></returns>
        public Task<ListGroupsResponse> ListGroups(ListGroupsRequest req)
        {
            return InternalRequestAsync<ListGroupsResponse>(req, "ListGroups");
        }

        /// <summary>
        /// This API is used to query the user group list.
        /// </summary>
        /// <param name="req"><see cref="ListGroupsRequest"/></param>
        /// <returns><see cref="ListGroupsResponse"/></returns>
        public ListGroupsResponse ListGroupsSync(ListGroupsRequest req)
        {
            return InternalRequestAsync<ListGroupsResponse>(req, "ListGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the user group joined by users.
        /// </summary>
        /// <param name="req"><see cref="ListJoinedGroupsForUserRequest"/></param>
        /// <returns><see cref="ListJoinedGroupsForUserResponse"/></returns>
        public Task<ListJoinedGroupsForUserResponse> ListJoinedGroupsForUser(ListJoinedGroupsForUserRequest req)
        {
            return InternalRequestAsync<ListJoinedGroupsForUserResponse>(req, "ListJoinedGroupsForUser");
        }

        /// <summary>
        /// This API is used to query the user group joined by users.
        /// </summary>
        /// <param name="req"><see cref="ListJoinedGroupsForUserRequest"/></param>
        /// <returns><see cref="ListJoinedGroupsForUserResponse"/></returns>
        public ListJoinedGroupsForUserResponse ListJoinedGroupsForUserSync(ListJoinedGroupsForUserRequest req)
        {
            return InternalRequestAsync<ListJoinedGroupsForUserResponse>(req, "ListJoinedGroupsForUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of delegated admins of the organization service.
        /// </summary>
        /// <param name="req"><see cref="ListOrgServiceAssignMemberRequest"/></param>
        /// <returns><see cref="ListOrgServiceAssignMemberResponse"/></returns>
        public Task<ListOrgServiceAssignMemberResponse> ListOrgServiceAssignMember(ListOrgServiceAssignMemberRequest req)
        {
            return InternalRequestAsync<ListOrgServiceAssignMemberResponse>(req, "ListOrgServiceAssignMember");
        }

        /// <summary>
        /// This API is used to obtain the list of delegated admins of the organization service.
        /// </summary>
        /// <param name="req"><see cref="ListOrgServiceAssignMemberRequest"/></param>
        /// <returns><see cref="ListOrgServiceAssignMemberResponse"/></returns>
        public ListOrgServiceAssignMemberResponse ListOrgServiceAssignMemberSync(ListOrgServiceAssignMemberRequest req)
        {
            return InternalRequestAsync<ListOrgServiceAssignMemberResponse>(req, "ListOrgServiceAssignMember")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of access identities of an organization member.
        /// </summary>
        /// <param name="req"><see cref="ListOrganizationIdentityRequest"/></param>
        /// <returns><see cref="ListOrganizationIdentityResponse"/></returns>
        public Task<ListOrganizationIdentityResponse> ListOrganizationIdentity(ListOrganizationIdentityRequest req)
        {
            return InternalRequestAsync<ListOrganizationIdentityResponse>(req, "ListOrganizationIdentity");
        }

        /// <summary>
        /// This API is used to get the list of access identities of an organization member.
        /// </summary>
        /// <param name="req"><see cref="ListOrganizationIdentityRequest"/></param>
        /// <returns><see cref="ListOrganizationIdentityResponse"/></returns>
        public ListOrganizationIdentityResponse ListOrganizationIdentitySync(ListOrganizationIdentityRequest req)
        {
            return InternalRequestAsync<ListOrganizationIdentityResponse>(req, "ListOrganizationIdentity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of organization service settings.
        /// </summary>
        /// <param name="req"><see cref="ListOrganizationServiceRequest"/></param>
        /// <returns><see cref="ListOrganizationServiceResponse"/></returns>
        public Task<ListOrganizationServiceResponse> ListOrganizationService(ListOrganizationServiceRequest req)
        {
            return InternalRequestAsync<ListOrganizationServiceResponse>(req, "ListOrganizationService");
        }

        /// <summary>
        /// This API is used to obtain the list of organization service settings.
        /// </summary>
        /// <param name="req"><see cref="ListOrganizationServiceRequest"/></param>
        /// <returns><see cref="ListOrganizationServiceResponse"/></returns>
        public ListOrganizationServiceResponse ListOrganizationServiceSync(ListOrganizationServiceRequest req)
        {
            return InternalRequestAsync<ListOrganizationServiceResponse>(req, "ListOrganizationService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the policy list in permission configurations.
        /// </summary>
        /// <param name="req"><see cref="ListPermissionPoliciesInRoleConfigurationRequest"/></param>
        /// <returns><see cref="ListPermissionPoliciesInRoleConfigurationResponse"/></returns>
        public Task<ListPermissionPoliciesInRoleConfigurationResponse> ListPermissionPoliciesInRoleConfiguration(ListPermissionPoliciesInRoleConfigurationRequest req)
        {
            return InternalRequestAsync<ListPermissionPoliciesInRoleConfigurationResponse>(req, "ListPermissionPoliciesInRoleConfiguration");
        }

        /// <summary>
        /// This API is used to obtain the policy list in permission configurations.
        /// </summary>
        /// <param name="req"><see cref="ListPermissionPoliciesInRoleConfigurationRequest"/></param>
        /// <returns><see cref="ListPermissionPoliciesInRoleConfigurationResponse"/></returns>
        public ListPermissionPoliciesInRoleConfigurationResponse ListPermissionPoliciesInRoleConfigurationSync(ListPermissionPoliciesInRoleConfigurationRequest req)
        {
            return InternalRequestAsync<ListPermissionPoliciesInRoleConfigurationResponse>(req, "ListPermissionPoliciesInRoleConfiguration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the authorization list.
        /// </summary>
        /// <param name="req"><see cref="ListRoleAssignmentsRequest"/></param>
        /// <returns><see cref="ListRoleAssignmentsResponse"/></returns>
        public Task<ListRoleAssignmentsResponse> ListRoleAssignments(ListRoleAssignmentsRequest req)
        {
            return InternalRequestAsync<ListRoleAssignmentsResponse>(req, "ListRoleAssignments");
        }

        /// <summary>
        /// This API is used to query the authorization list.
        /// </summary>
        /// <param name="req"><see cref="ListRoleAssignmentsRequest"/></param>
        /// <returns><see cref="ListRoleAssignmentsResponse"/></returns>
        public ListRoleAssignmentsResponse ListRoleAssignmentsSync(ListRoleAssignmentsRequest req)
        {
            return InternalRequestAsync<ListRoleAssignmentsResponse>(req, "ListRoleAssignments")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the permission configuration deployment list.
        /// </summary>
        /// <param name="req"><see cref="ListRoleConfigurationProvisioningsRequest"/></param>
        /// <returns><see cref="ListRoleConfigurationProvisioningsResponse"/></returns>
        public Task<ListRoleConfigurationProvisioningsResponse> ListRoleConfigurationProvisionings(ListRoleConfigurationProvisioningsRequest req)
        {
            return InternalRequestAsync<ListRoleConfigurationProvisioningsResponse>(req, "ListRoleConfigurationProvisionings");
        }

        /// <summary>
        /// This API is used to query the permission configuration deployment list.
        /// </summary>
        /// <param name="req"><see cref="ListRoleConfigurationProvisioningsRequest"/></param>
        /// <returns><see cref="ListRoleConfigurationProvisioningsResponse"/></returns>
        public ListRoleConfigurationProvisioningsResponse ListRoleConfigurationProvisioningsSync(ListRoleConfigurationProvisioningsRequest req)
        {
            return InternalRequestAsync<ListRoleConfigurationProvisioningsResponse>(req, "ListRoleConfigurationProvisionings")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the permission configuration list.
        /// </summary>
        /// <param name="req"><see cref="ListRoleConfigurationsRequest"/></param>
        /// <returns><see cref="ListRoleConfigurationsResponse"/></returns>
        public Task<ListRoleConfigurationsResponse> ListRoleConfigurations(ListRoleConfigurationsRequest req)
        {
            return InternalRequestAsync<ListRoleConfigurationsResponse>(req, "ListRoleConfigurations");
        }

        /// <summary>
        /// This API is used to query the permission configuration list.
        /// </summary>
        /// <param name="req"><see cref="ListRoleConfigurationsRequest"/></param>
        /// <returns><see cref="ListRoleConfigurationsResponse"/></returns>
        public ListRoleConfigurationsResponse ListRoleConfigurationsSync(ListRoleConfigurationsRequest req)
        {
            return InternalRequestAsync<ListRoleConfigurationsResponse>(req, "ListRoleConfigurations")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the user SCIM key list.
        /// </summary>
        /// <param name="req"><see cref="ListSCIMCredentialsRequest"/></param>
        /// <returns><see cref="ListSCIMCredentialsResponse"/></returns>
        public Task<ListSCIMCredentialsResponse> ListSCIMCredentials(ListSCIMCredentialsRequest req)
        {
            return InternalRequestAsync<ListSCIMCredentialsResponse>(req, "ListSCIMCredentials");
        }

        /// <summary>
        /// This API is used to query the user SCIM key list.
        /// </summary>
        /// <param name="req"><see cref="ListSCIMCredentialsRequest"/></param>
        /// <returns><see cref="ListSCIMCredentialsResponse"/></returns>
        public ListSCIMCredentialsResponse ListSCIMCredentialsSync(ListSCIMCredentialsRequest req)
        {
            return InternalRequestAsync<ListSCIMCredentialsResponse>(req, "ListSCIMCredentials")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the async task list.
        /// </summary>
        /// <param name="req"><see cref="ListTasksRequest"/></param>
        /// <returns><see cref="ListTasksResponse"/></returns>
        public Task<ListTasksResponse> ListTasks(ListTasksRequest req)
        {
            return InternalRequestAsync<ListTasksResponse>(req, "ListTasks");
        }

        /// <summary>
        /// This API is used to query the async task list.
        /// </summary>
        /// <param name="req"><see cref="ListTasksRequest"/></param>
        /// <returns><see cref="ListTasksResponse"/></returns>
        public ListTasksResponse ListTasksSync(ListTasksRequest req)
        {
            return InternalRequestAsync<ListTasksResponse>(req, "ListTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the CAM user synchronization list.
        /// </summary>
        /// <param name="req"><see cref="ListUserSyncProvisioningsRequest"/></param>
        /// <returns><see cref="ListUserSyncProvisioningsResponse"/></returns>
        public Task<ListUserSyncProvisioningsResponse> ListUserSyncProvisionings(ListUserSyncProvisioningsRequest req)
        {
            return InternalRequestAsync<ListUserSyncProvisioningsResponse>(req, "ListUserSyncProvisionings");
        }

        /// <summary>
        /// This API is used to query the CAM user synchronization list.
        /// </summary>
        /// <param name="req"><see cref="ListUserSyncProvisioningsRequest"/></param>
        /// <returns><see cref="ListUserSyncProvisioningsResponse"/></returns>
        public ListUserSyncProvisioningsResponse ListUserSyncProvisioningsSync(ListUserSyncProvisioningsRequest req)
        {
            return InternalRequestAsync<ListUserSyncProvisioningsResponse>(req, "ListUserSyncProvisionings")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the user list.
        /// </summary>
        /// <param name="req"><see cref="ListUsersRequest"/></param>
        /// <returns><see cref="ListUsersResponse"/></returns>
        public Task<ListUsersResponse> ListUsers(ListUsersRequest req)
        {
            return InternalRequestAsync<ListUsersResponse>(req, "ListUsers");
        }

        /// <summary>
        /// This API is used to query the user list.
        /// </summary>
        /// <param name="req"><see cref="ListUsersRequest"/></param>
        /// <returns><see cref="ListUsersResponse"/></returns>
        public ListUsersResponse ListUsersSync(ListUsersRequest req)
        {
            return InternalRequestAsync<ListUsersResponse>(req, "ListUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to move a member to the specified organization node.
        /// </summary>
        /// <param name="req"><see cref="MoveOrganizationNodeMembersRequest"/></param>
        /// <returns><see cref="MoveOrganizationNodeMembersResponse"/></returns>
        public Task<MoveOrganizationNodeMembersResponse> MoveOrganizationNodeMembers(MoveOrganizationNodeMembersRequest req)
        {
            return InternalRequestAsync<MoveOrganizationNodeMembersResponse>(req, "MoveOrganizationNodeMembers");
        }

        /// <summary>
        /// This API is used to move a member to the specified organization node.
        /// </summary>
        /// <param name="req"><see cref="MoveOrganizationNodeMembersRequest"/></param>
        /// <returns><see cref="MoveOrganizationNodeMembersResponse"/></returns>
        public MoveOrganizationNodeMembersResponse MoveOrganizationNodeMembersSync(MoveOrganizationNodeMembersRequest req)
        {
            return InternalRequestAsync<MoveOrganizationNodeMembersResponse>(req, "MoveOrganizationNodeMembers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to activate Identity Center service (CIC).
        /// </summary>
        /// <param name="req"><see cref="OpenIdentityCenterRequest"/></param>
        /// <returns><see cref="OpenIdentityCenterResponse"/></returns>
        public Task<OpenIdentityCenterResponse> OpenIdentityCenter(OpenIdentityCenterRequest req)
        {
            return InternalRequestAsync<OpenIdentityCenterResponse>(req, "OpenIdentityCenter");
        }

        /// <summary>
        /// This API is used to activate Identity Center service (CIC).
        /// </summary>
        /// <param name="req"><see cref="OpenIdentityCenterRequest"/></param>
        /// <returns><see cref="OpenIdentityCenterResponse"/></returns>
        public OpenIdentityCenterResponse OpenIdentityCenterSync(OpenIdentityCenterRequest req)
        {
            return InternalRequestAsync<OpenIdentityCenterResponse>(req, "OpenIdentityCenter")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to deploy permission configurations on member accounts.
        /// </summary>
        /// <param name="req"><see cref="ProvisionRoleConfigurationRequest"/></param>
        /// <returns><see cref="ProvisionRoleConfigurationResponse"/></returns>
        public Task<ProvisionRoleConfigurationResponse> ProvisionRoleConfiguration(ProvisionRoleConfigurationRequest req)
        {
            return InternalRequestAsync<ProvisionRoleConfigurationResponse>(req, "ProvisionRoleConfiguration");
        }

        /// <summary>
        /// This API is used to deploy permission configurations on member accounts.
        /// </summary>
        /// <param name="req"><see cref="ProvisionRoleConfigurationRequest"/></param>
        /// <returns><see cref="ProvisionRoleConfigurationResponse"/></returns>
        public ProvisionRoleConfigurationResponse ProvisionRoleConfigurationSync(ProvisionRoleConfigurationRequest req)
        {
            return InternalRequestAsync<ProvisionRoleConfigurationResponse>(req, "ProvisionRoleConfiguration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to exit an organization.
        /// </summary>
        /// <param name="req"><see cref="QuitOrganizationRequest"/></param>
        /// <returns><see cref="QuitOrganizationResponse"/></returns>
        public Task<QuitOrganizationResponse> QuitOrganization(QuitOrganizationRequest req)
        {
            return InternalRequestAsync<QuitOrganizationResponse>(req, "QuitOrganization");
        }

        /// <summary>
        /// This API is used to exit an organization.
        /// </summary>
        /// <param name="req"><see cref="QuitOrganizationRequest"/></param>
        /// <returns><see cref="QuitOrganizationResponse"/></returns>
        public QuitOrganizationResponse QuitOrganizationSync(QuitOrganizationRequest req)
        {
            return InternalRequestAsync<QuitOrganizationResponse>(req, "QuitOrganization")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to remove SAML signing certificates.
        /// </summary>
        /// <param name="req"><see cref="RemoveExternalSAMLIdPCertificateRequest"/></param>
        /// <returns><see cref="RemoveExternalSAMLIdPCertificateResponse"/></returns>
        public Task<RemoveExternalSAMLIdPCertificateResponse> RemoveExternalSAMLIdPCertificate(RemoveExternalSAMLIdPCertificateRequest req)
        {
            return InternalRequestAsync<RemoveExternalSAMLIdPCertificateResponse>(req, "RemoveExternalSAMLIdPCertificate");
        }

        /// <summary>
        /// This API is used to remove SAML signing certificates.
        /// </summary>
        /// <param name="req"><see cref="RemoveExternalSAMLIdPCertificateRequest"/></param>
        /// <returns><see cref="RemoveExternalSAMLIdPCertificateResponse"/></returns>
        public RemoveExternalSAMLIdPCertificateResponse RemoveExternalSAMLIdPCertificateSync(RemoveExternalSAMLIdPCertificateRequest req)
        {
            return InternalRequestAsync<RemoveExternalSAMLIdPCertificateResponse>(req, "RemoveExternalSAMLIdPCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to remove policies from permission configurations.
        /// </summary>
        /// <param name="req"><see cref="RemovePermissionPolicyFromRoleConfigurationRequest"/></param>
        /// <returns><see cref="RemovePermissionPolicyFromRoleConfigurationResponse"/></returns>
        public Task<RemovePermissionPolicyFromRoleConfigurationResponse> RemovePermissionPolicyFromRoleConfiguration(RemovePermissionPolicyFromRoleConfigurationRequest req)
        {
            return InternalRequestAsync<RemovePermissionPolicyFromRoleConfigurationResponse>(req, "RemovePermissionPolicyFromRoleConfiguration");
        }

        /// <summary>
        /// This API is used to remove policies from permission configurations.
        /// </summary>
        /// <param name="req"><see cref="RemovePermissionPolicyFromRoleConfigurationRequest"/></param>
        /// <returns><see cref="RemovePermissionPolicyFromRoleConfigurationResponse"/></returns>
        public RemovePermissionPolicyFromRoleConfigurationResponse RemovePermissionPolicyFromRoleConfigurationSync(RemovePermissionPolicyFromRoleConfigurationRequest req)
        {
            return InternalRequestAsync<RemovePermissionPolicyFromRoleConfigurationResponse>(req, "RemovePermissionPolicyFromRoleConfiguration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to removes users from a user group.
        /// </summary>
        /// <param name="req"><see cref="RemoveUserFromGroupRequest"/></param>
        /// <returns><see cref="RemoveUserFromGroupResponse"/></returns>
        public Task<RemoveUserFromGroupResponse> RemoveUserFromGroup(RemoveUserFromGroupRequest req)
        {
            return InternalRequestAsync<RemoveUserFromGroupResponse>(req, "RemoveUserFromGroup");
        }

        /// <summary>
        /// This API is used to removes users from a user group.
        /// </summary>
        /// <param name="req"><see cref="RemoveUserFromGroupRequest"/></param>
        /// <returns><see cref="RemoveUserFromGroupResponse"/></returns>
        public RemoveUserFromGroupResponse RemoveUserFromGroupSync(RemoveUserFromGroupRequest req)
        {
            return InternalRequestAsync<RemoveUserFromGroupResponse>(req, "RemoveUserFromGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to configure the SAML identity provider information.
        /// </summary>
        /// <param name="req"><see cref="SetExternalSAMLIdentityProviderRequest"/></param>
        /// <returns><see cref="SetExternalSAMLIdentityProviderResponse"/></returns>
        public Task<SetExternalSAMLIdentityProviderResponse> SetExternalSAMLIdentityProvider(SetExternalSAMLIdentityProviderRequest req)
        {
            return InternalRequestAsync<SetExternalSAMLIdentityProviderResponse>(req, "SetExternalSAMLIdentityProvider");
        }

        /// <summary>
        /// This API is used to configure the SAML identity provider information.
        /// </summary>
        /// <param name="req"><see cref="SetExternalSAMLIdentityProviderRequest"/></param>
        /// <returns><see cref="SetExternalSAMLIdentityProviderResponse"/></returns>
        public SetExternalSAMLIdentityProviderResponse SetExternalSAMLIdentityProviderSync(SetExternalSAMLIdentityProviderRequest req)
        {
            return InternalRequestAsync<SetExternalSAMLIdentityProviderResponse>(req, "SetExternalSAMLIdentityProvider")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a custom policy for permission configurations.
        /// </summary>
        /// <param name="req"><see cref="UpdateCustomPolicyForRoleConfigurationRequest"/></param>
        /// <returns><see cref="UpdateCustomPolicyForRoleConfigurationResponse"/></returns>
        public Task<UpdateCustomPolicyForRoleConfigurationResponse> UpdateCustomPolicyForRoleConfiguration(UpdateCustomPolicyForRoleConfigurationRequest req)
        {
            return InternalRequestAsync<UpdateCustomPolicyForRoleConfigurationResponse>(req, "UpdateCustomPolicyForRoleConfiguration");
        }

        /// <summary>
        /// This API is used to modify a custom policy for permission configurations.
        /// </summary>
        /// <param name="req"><see cref="UpdateCustomPolicyForRoleConfigurationRequest"/></param>
        /// <returns><see cref="UpdateCustomPolicyForRoleConfigurationResponse"/></returns>
        public UpdateCustomPolicyForRoleConfigurationResponse UpdateCustomPolicyForRoleConfigurationSync(UpdateCustomPolicyForRoleConfigurationRequest req)
        {
            return InternalRequestAsync<UpdateCustomPolicyForRoleConfigurationResponse>(req, "UpdateCustomPolicyForRoleConfiguration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify user group information.
        /// </summary>
        /// <param name="req"><see cref="UpdateGroupRequest"/></param>
        /// <returns><see cref="UpdateGroupResponse"/></returns>
        public Task<UpdateGroupResponse> UpdateGroup(UpdateGroupRequest req)
        {
            return InternalRequestAsync<UpdateGroupResponse>(req, "UpdateGroup");
        }

        /// <summary>
        /// This API is used to modify user group information.
        /// </summary>
        /// <param name="req"><see cref="UpdateGroupRequest"/></param>
        /// <returns><see cref="UpdateGroupResponse"/></returns>
        public UpdateGroupResponse UpdateGroupSync(UpdateGroupRequest req)
        {
            return InternalRequestAsync<UpdateGroupResponse>(req, "UpdateGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update an organization identity.
        /// </summary>
        /// <param name="req"><see cref="UpdateOrganizationIdentityRequest"/></param>
        /// <returns><see cref="UpdateOrganizationIdentityResponse"/></returns>
        public Task<UpdateOrganizationIdentityResponse> UpdateOrganizationIdentity(UpdateOrganizationIdentityRequest req)
        {
            return InternalRequestAsync<UpdateOrganizationIdentityResponse>(req, "UpdateOrganizationIdentity");
        }

        /// <summary>
        /// This API is used to update an organization identity.
        /// </summary>
        /// <param name="req"><see cref="UpdateOrganizationIdentityRequest"/></param>
        /// <returns><see cref="UpdateOrganizationIdentityResponse"/></returns>
        public UpdateOrganizationIdentityResponse UpdateOrganizationIdentitySync(UpdateOrganizationIdentityRequest req)
        {
            return InternalRequestAsync<UpdateOrganizationIdentityResponse>(req, "UpdateOrganizationIdentity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update organization member information.
        /// </summary>
        /// <param name="req"><see cref="UpdateOrganizationMemberRequest"/></param>
        /// <returns><see cref="UpdateOrganizationMemberResponse"/></returns>
        public Task<UpdateOrganizationMemberResponse> UpdateOrganizationMember(UpdateOrganizationMemberRequest req)
        {
            return InternalRequestAsync<UpdateOrganizationMemberResponse>(req, "UpdateOrganizationMember");
        }

        /// <summary>
        /// This API is used to update organization member information.
        /// </summary>
        /// <param name="req"><see cref="UpdateOrganizationMemberRequest"/></param>
        /// <returns><see cref="UpdateOrganizationMemberResponse"/></returns>
        public UpdateOrganizationMemberResponse UpdateOrganizationMemberSync(UpdateOrganizationMemberRequest req)
        {
            return InternalRequestAsync<UpdateOrganizationMemberResponse>(req, "UpdateOrganizationMember")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update an organization node.
        /// </summary>
        /// <param name="req"><see cref="UpdateOrganizationNodeRequest"/></param>
        /// <returns><see cref="UpdateOrganizationNodeResponse"/></returns>
        public Task<UpdateOrganizationNodeResponse> UpdateOrganizationNode(UpdateOrganizationNodeRequest req)
        {
            return InternalRequestAsync<UpdateOrganizationNodeResponse>(req, "UpdateOrganizationNode");
        }

        /// <summary>
        /// This API is used to update an organization node.
        /// </summary>
        /// <param name="req"><see cref="UpdateOrganizationNodeRequest"/></param>
        /// <returns><see cref="UpdateOrganizationNodeResponse"/></returns>
        public UpdateOrganizationNodeResponse UpdateOrganizationNodeSync(UpdateOrganizationNodeRequest req)
        {
            return InternalRequestAsync<UpdateOrganizationNodeResponse>(req, "UpdateOrganizationNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the permission configuration information.
        /// </summary>
        /// <param name="req"><see cref="UpdateRoleConfigurationRequest"/></param>
        /// <returns><see cref="UpdateRoleConfigurationResponse"/></returns>
        public Task<UpdateRoleConfigurationResponse> UpdateRoleConfiguration(UpdateRoleConfigurationRequest req)
        {
            return InternalRequestAsync<UpdateRoleConfigurationResponse>(req, "UpdateRoleConfiguration");
        }

        /// <summary>
        /// This API is used to modify the permission configuration information.
        /// </summary>
        /// <param name="req"><see cref="UpdateRoleConfigurationRequest"/></param>
        /// <returns><see cref="UpdateRoleConfigurationResponse"/></returns>
        public UpdateRoleConfigurationResponse UpdateRoleConfigurationSync(UpdateRoleConfigurationRequest req)
        {
            return InternalRequestAsync<UpdateRoleConfigurationResponse>(req, "UpdateRoleConfiguration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable or disable a SCIM key.
        /// </summary>
        /// <param name="req"><see cref="UpdateSCIMCredentialStatusRequest"/></param>
        /// <returns><see cref="UpdateSCIMCredentialStatusResponse"/></returns>
        public Task<UpdateSCIMCredentialStatusResponse> UpdateSCIMCredentialStatus(UpdateSCIMCredentialStatusRequest req)
        {
            return InternalRequestAsync<UpdateSCIMCredentialStatusResponse>(req, "UpdateSCIMCredentialStatus");
        }

        /// <summary>
        /// This API is used to enable or disable a SCIM key.
        /// </summary>
        /// <param name="req"><see cref="UpdateSCIMCredentialStatusRequest"/></param>
        /// <returns><see cref="UpdateSCIMCredentialStatusResponse"/></returns>
        public UpdateSCIMCredentialStatusResponse UpdateSCIMCredentialStatusSync(UpdateSCIMCredentialStatusRequest req)
        {
            return InternalRequestAsync<UpdateSCIMCredentialStatusResponse>(req, "UpdateSCIMCredentialStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable or disable user SCIM synchronization.
        /// </summary>
        /// <param name="req"><see cref="UpdateSCIMSynchronizationStatusRequest"/></param>
        /// <returns><see cref="UpdateSCIMSynchronizationStatusResponse"/></returns>
        public Task<UpdateSCIMSynchronizationStatusResponse> UpdateSCIMSynchronizationStatus(UpdateSCIMSynchronizationStatusRequest req)
        {
            return InternalRequestAsync<UpdateSCIMSynchronizationStatusResponse>(req, "UpdateSCIMSynchronizationStatus");
        }

        /// <summary>
        /// This API is used to enable or disable user SCIM synchronization.
        /// </summary>
        /// <param name="req"><see cref="UpdateSCIMSynchronizationStatusRequest"/></param>
        /// <returns><see cref="UpdateSCIMSynchronizationStatusResponse"/></returns>
        public UpdateSCIMSynchronizationStatusResponse UpdateSCIMSynchronizationStatusSync(UpdateSCIMSynchronizationStatusRequest req)
        {
            return InternalRequestAsync<UpdateSCIMSynchronizationStatusResponse>(req, "UpdateSCIMSynchronizationStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify user information.
        /// </summary>
        /// <param name="req"><see cref="UpdateUserRequest"/></param>
        /// <returns><see cref="UpdateUserResponse"/></returns>
        public Task<UpdateUserResponse> UpdateUser(UpdateUserRequest req)
        {
            return InternalRequestAsync<UpdateUserResponse>(req, "UpdateUser");
        }

        /// <summary>
        /// This API is used to modify user information.
        /// </summary>
        /// <param name="req"><see cref="UpdateUserRequest"/></param>
        /// <returns><see cref="UpdateUserResponse"/></returns>
        public UpdateUserResponse UpdateUserSync(UpdateUserRequest req)
        {
            return InternalRequestAsync<UpdateUserResponse>(req, "UpdateUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the user status.
        /// </summary>
        /// <param name="req"><see cref="UpdateUserStatusRequest"/></param>
        /// <returns><see cref="UpdateUserStatusResponse"/></returns>
        public Task<UpdateUserStatusResponse> UpdateUserStatus(UpdateUserStatusRequest req)
        {
            return InternalRequestAsync<UpdateUserStatusResponse>(req, "UpdateUserStatus");
        }

        /// <summary>
        /// This API is used to modify the user status.
        /// </summary>
        /// <param name="req"><see cref="UpdateUserStatusRequest"/></param>
        /// <returns><see cref="UpdateUserStatusResponse"/></returns>
        public UpdateUserStatusResponse UpdateUserStatusSync(UpdateUserStatusRequest req)
        {
            return InternalRequestAsync<UpdateUserStatusResponse>(req, "UpdateUserStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create sub-user synchronization tasks.
        /// </summary>
        /// <param name="req"><see cref="UpdateUserSyncProvisioningRequest"/></param>
        /// <returns><see cref="UpdateUserSyncProvisioningResponse"/></returns>
        public Task<UpdateUserSyncProvisioningResponse> UpdateUserSyncProvisioning(UpdateUserSyncProvisioningRequest req)
        {
            return InternalRequestAsync<UpdateUserSyncProvisioningResponse>(req, "UpdateUserSyncProvisioning");
        }

        /// <summary>
        /// This API is used to create sub-user synchronization tasks.
        /// </summary>
        /// <param name="req"><see cref="UpdateUserSyncProvisioningRequest"/></param>
        /// <returns><see cref="UpdateUserSyncProvisioningResponse"/></returns>
        public UpdateUserSyncProvisioningResponse UpdateUserSyncProvisioningSync(UpdateUserSyncProvisioningRequest req)
        {
            return InternalRequestAsync<UpdateUserSyncProvisioningResponse>(req, "UpdateUserSyncProvisioning")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the user's space name.
        /// </summary>
        /// <param name="req"><see cref="UpdateZoneRequest"/></param>
        /// <returns><see cref="UpdateZoneResponse"/></returns>
        public Task<UpdateZoneResponse> UpdateZone(UpdateZoneRequest req)
        {
            return InternalRequestAsync<UpdateZoneResponse>(req, "UpdateZone");
        }

        /// <summary>
        /// This API is used to update the user's space name.
        /// </summary>
        /// <param name="req"><see cref="UpdateZoneRequest"/></param>
        /// <returns><see cref="UpdateZoneResponse"/></returns>
        public UpdateZoneResponse UpdateZoneSync(UpdateZoneRequest req)
        {
            return InternalRequestAsync<UpdateZoneResponse>(req, "UpdateZone")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
